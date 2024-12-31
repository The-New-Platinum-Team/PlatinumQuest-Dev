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
// TG_TEX2
@group(2) @binding(0)
var normalMap: texture_2d<f32>; 
@group(2) @binding(1)
var specularMap: texture_2d<f32>; 
@group(2) @binding(2)
var normalSampler: sampler;
@group(2) @binding(3)
var specularSampler: sampler;
// TG_CUBEMAP1
@group(3) @binding(0)
var cubeTex: texture_cube<f32>; // diffuse
@group(3) @binding(1)
var cubeSampler: sampler;

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
fn vSkyboxIce(in: ITRPQVert) -> PQRasterizerData {
   var out : PQRasterizerData;

   var lightDir = tsUniforms.lights[0].position.xyz;
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0f);
   var calcNorm : vec4<f32> = vec4<f32>(in.norm.xyz, 0.0f);
   var calcTangent: vec4<f32> = vec4<f32>(in.tangent, 0.0f);
   var calcBitangent: vec4<f32> = vec4<f32>(in.bitangent, 0.0f);
   var worldPos : vec3<f32> = (calcPos * tsUniforms.objectMat).xyz;
   var worldNorm : vec3<f32> = (calcNorm * transpose(expandTo44(tsUniforms.invObjectMat))).xyz;
   var worldTangent : vec3<f32> = (calcTangent * transpose(expandTo44(tsUniforms.invObjectMat))).xyz;
   var worldBitangent: vec3<f32> = (calcBitangent * transpose(expandTo44(tsUniforms.invObjectMat))).xyz;

   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;

   var camPos : vec3<f32> = (vec4<f32>(0,0,0,1) * commonUniforms.invCameraView).xyz;

   var tbn = mat3x3<f32>(worldTangent, worldBitangent, worldNorm);
   
   out.clipSpacePosition = calcPos * mvp;
   out.worldSpacePosition = (calcPos * tsUniforms.objectMat);
   out.modelViewPosition = (calcPos * commonUniforms.modelview).xyz;
   out.uv = (vec4<f32>(in.tex.xy, 0.0,1.0) * tsUniforms.texMats[0]).xy * tsUniforms.miscState.xy;
   out.norm = worldNorm;
   out.camDir = vec4<f32>(normalize((vec4<f32>(0,1,0,0) * expandTo44(commonUniforms.invCameraView)).xyz), 0);
   // out.camDir = vec4<f32>(out.camDir.xyz * tbn, 0.0);
   out.lightDir = lightDir * tbn;
   out.camPos = camPos * tbn;
   out.tangentPos = out.worldSpacePosition * tbn;

   // HandleVertLight(worldPos, worldNorm, out.camDir.xyz, out.color);
   return out;
}

@fragment
fn fSkyboxIce(in: PQRasterizerData) -> @location(0) vec4<f32> {
   var materialColor : vec4<f32> = vec4<f32>(textureSample(diffuseMap, diffuseSampler, in.uv).rgba); // base
   var normalColor : vec3<f32> = vec3<f32>(normalize((textureSample(normalMap, normalSampler, in.uv).rgba * 2.0 - 1.0).rgb));
   var lightNormal = normalize(in.lightDir);
   var cosTheta = clamp(dot(normalColor.rgb, lightNormal.rgb), 0.0, 1.0);
   var lightUnit = tsUniforms.lights[0];
   var effectiveSun : vec4<f32> = lightUnit.ambient + (cosTheta * lightUnit.diffuse);
   effectiveSun = vec4<f32>(clamp(effectiveSun.r, 0.0, 1.0), 
      clamp(effectiveSun.g, 0.0, 1.0), 
      clamp(effectiveSun.b, 0.0, 1.0),
      clamp(effectiveSun.a, 0.0, 1.0));

   var outCol = vec4<f32>(materialColor.rgb * effectiveSun.rgb, 1.0);

   var normalModel = normalize(reflect(-in.norm.xyz, normalColor));
   var camDir = normalize(in.tangentPos - in.camPos);
   var camReflection = reflect(camDir, normalModel);
   var skyboxColor = textureSample(cubeTex, cubeSampler, camReflection.xzy);

   outCol = mix(outCol, skyboxColor, tsUniforms.fogState.x);

   outCol += vec4<f32>(0.2, 0.25, 0.3, 1.0) * cosTheta;

   var viewDir = in.camPos - in.tangentPos;

   var specularColor : vec4<f32> = vec4<f32>(textureSample(specularMap, specularSampler, in.uv).rgba);
   var lightReflection = reflect(-lightNormal.xyz, normalColor.rgb);
   var cosAlpha = clamp(dot(normalize(viewDir), lightReflection), 0.0, 1.0);
   
   outCol += vec4<f32>(specularColor.rgb * lightUnit.diffuse.rgb * pow(cosAlpha, 9.0), 1.0);
   return outCol;
}