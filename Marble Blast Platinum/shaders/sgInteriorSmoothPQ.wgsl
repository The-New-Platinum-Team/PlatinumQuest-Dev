#include "stStructs.wgsl"

// UG_COMMON_TS
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
@group(0) @binding(1)
var<uniform> tsUniforms: TSUniformSet;
// TG_TEX1
@group(1) @binding(0)
var diffuseMap: texture_2d<f32>; // base
@group(1) @binding(1)
var diffuseSampler: sampler;

// Interior Shaders
fn calcSingleLight(camDir: vec3<f32>, vpos: vec3<f32>, vnormal: vec3<f32>,
               lightUnit: LightUnit) -> vec3<f32> {
   // Handle basic positional vs directional light
   var lightDir : vec3<f32>;
   var attenFactor : f32 = 1.0f;
   
   if (lightUnit.position.w != 0.0f)
   {
      // Point light
      lightDir = lightUnit.position.xyz - vpos;
      var lightVertexDist : f32 = length(lightDir);
      lightDir = normalize(lightDir);
      var quadAtten : f32 = lightUnit.attenEnabled.z * lightVertexDist;
      var invAtten : f32 = 1.0-step(lightUnit.attenEnabled.x + lightUnit.attenEnabled.y + lightUnit.attenEnabled.z, 0.0);
      
      attenFactor = 1.0f / (
                                  lightUnit.attenEnabled.x +
                                  (lightUnit.attenEnabled.y * lightVertexDist) +
                                  (quadAtten * quadAtten)  +
                            invAtten); // avoid div by zero
   }
   else
   {
      // Directional light
      lightDir = lightUnit.position.xyz;
   }
   
   // Diffuse
   var diffuseDot : f32 = dot(vnormal, lightDir);
   diffuseDot = max(dot(vnormal, lightDir), 0.0);
   
   // // Spotlight effect
   // // NOTE: should pow(spotDotFactor, exp) but since TGE doesn't use this
   // // we ignore it.
   /* const */ var RAD180 : f32 = 3.14159f;
   var spotDotFactor : f32 = max(dot(lightDir, lightUnit.spotDirectionCutoff.xyz), 0.0);
   var spotlightEffect : f32;
   if (lightUnit.spotDirectionCutoff.w < RAD180)
   {
      var cosv : f32 = cos(lightUnit.spotDirectionCutoff.w);
      // spotDotFactor < cos(lightUnit.spotDirectionCutoff.w) ? 0.0f : spotDotFactor;
      spotlightEffect = ((step(spotDotFactor, cosv) * 0.0) + (step(cosv, spotDotFactor) * spotDotFactor));
   }
   else
   {
      spotlightEffect = 1.0f;
   }
   
   // // Specular...
   // // NOTE: in tge, shininess is never set so specular color is
   // // always modulated by 1
   // var reflectionDirection : vec3<f32> = reflect(-lightDir, vnormal);
   // var specFunc : f32 = max(dot(reflectionDirection, camDir), 0.0);
   
   // Do final calc
   var calc : vec3<f32> = lightUnit.ambient.rgb +
          (diffuseDot * lightUnit.diffuse.rgb);
          //(specFunc * lightUnit.specular.rgb);
   
   calc *= attenFactor * spotlightEffect;
   calc *= lightUnit.attenEnabled.w;
   
   return calc;
}



@vertex
fn vSmooth(in: ITRPQVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0f);
   var calcNorm : vec4<f32> = vec4<f32>(in.norm.xyz, 0.0f);
   var worldPos : vec3<f32> = (calcPos * tsUniforms.objectMat).xyz;
   var worldNorm : vec3<f32> = (calcNorm * transpose(expandTo44(tsUniforms.invObjectMat))).xyz;
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   
   out.clipSpacePosition = calcPos * mvp;
   out.worldSpacePosition = (calcPos * tsUniforms.objectMat);
   out.modelViewPosition = (calcPos * commonUniforms.modelview).xyz;
   out.uv1 = (vec4<f32>(in.tex.xy, 0.0,1.0) * tsUniforms.texMats[0]).xy;
   out.norm = (calcNorm * mvp).xyz;
   out.camDir = vec4<f32>(normalize((vec4<f32>(0,1,0,0) * expandTo44(commonUniforms.invCameraView)).xyz), 0);
   out.fragControl = tsUniforms.miscState;

   var calc : vec3<f32>;
   
   for (var i : u32 = 0; i<MAX_LIGHTS; i++) {
      calc += calcSingleLight(out.camDir.xyz, worldPos, worldNorm, tsUniforms.lights[i]);
   }
   out.color = vec4<f32>(saturate(calc), 1.0);// HandleVertLight(worldPos, worldNorm, out.camDir.xyz, out.color);
   return out;
}

@fragment
fn fSmooth(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var base : vec4<f32> = vec4<f32>(textureSample(diffuseMap, diffuseSampler, in.uv1).rgba) * in.color; // base
   return base;
}