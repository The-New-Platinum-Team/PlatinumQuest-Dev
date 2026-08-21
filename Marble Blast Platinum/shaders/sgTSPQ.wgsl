#include "stStructs.wgsl"

// UG_COMMON_TS
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
@group(0) @binding(1)
var<uniform> tsUniforms: TSUniformSet;
// TG_TEX2
@group(1) @binding(0)
var diffuseMap: texture_2d<f32>; // diffuse
@group(1) @binding(1)
var normalMap: texture_2d<f32>; // normal
@group(1) @binding(2)
var diffuseSampler: sampler;
@group(1) @binding(3)
var normalSampler: sampler;
// TG_CUBEMAP1
@group(2) @binding(0)
var cubeTex: texture_cube<f32>; // diffuse
@group(2) @binding(1)
var cubeSampler: sampler;
// TG_TEX1
@group(3) @binding(0)
var refractbuffer: texture_2d<f32>; // for refraction
@group(3) @binding(1)
var refractbufferSampler: sampler;

// Simple TSPL Shaders (requiring at most 2 textures)

@vertex
fn vTS_DefaultMaterial(in : ITRPQVert) -> PQRasterizerData {
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

   var outLightVecW = step(-0.5, dot(worldNorm, lightDir));

   var w = commonUniforms.modelview[2];

   var projectedPosition = calcPos * mvp;
   
   out.clipSpacePosition = calcPos * mvp;
   out.worldSpacePosition = (calcPos * tsUniforms.objectMat);
   out.modelViewPosition = projectedPosition.xyw;
   out.uv = in.tex.xy; // (vec4<f32>(in.tex.xy, 0.0,1.0) * tsUniforms.texMats[0]).xy * tsUniforms.miscState.xy;
   out.norm = worldNorm;
   out.camDir = vec4<f32>(camPos.xyz, 1.0);
   // out.camDir = vec4<f32>(out.camDir.xyz * tbn, 0.0);
   out.lightDir = lightDir * tbn;
   out.camPos = camPos * tbn;
   out.tangentPos = out.worldSpacePosition * tbn;

   // HandleVertLight(worldPos, worldNorm, out.camDir.xyz, out.color);
   return out;
}

@fragment
fn fTS_DefaultMaterial(in: PQRasterizerData) -> @location(0) vec4<f32> {
   var calculatedUV = in.uv;
   var bumpNormal = textureSample(normalMap, normalSampler, calculatedUV).xyz * 2.0 - 1.0;
   var outLightVec = normalize(in.lightDir);
   var lightUnit = tsUniforms.lights[0];
   var bumpDot = (dot(bumpNormal, outLightVec) + 1.0) * 0.5;

   var diffuse = textureSample(diffuseMap, diffuseSampler, calculatedUV);
   var outCol = diffuse;

   if (tsUniforms.fogState.y > 0.5)
   {
      // Distortion in pixels; set to 0.0 to disable
      let distortionPx = 0.3;
      let distortionUV = (bumpNormal.xy * distortionPx);

      // clipSpacePosition.xy is already in pixels
      let uv = in.modelViewPosition.xy + distortionUV;
      let screenUV = uv / in.modelViewPosition.z;

      var refractColor = textureSample(
         refractbuffer,
         refractbufferSampler,
         screenUV * 0.5 + vec2<f32>(0.5, 0.5)
      );
      outCol *= refractColor;
   }

   var shading = vec4<f32>(1.08, 1.03, 0.90, 1.0);
   outCol *= (shading * bumpDot) + lightUnit.ambient;

   var eyeVec = normalize(in.camPos - in.tangentPos);
   var worldEyeVec = normalize(in.camDir.xyz - in.worldSpacePosition);

   // Cubemap reflection (tangent-space)
   var reflDir = reflect(-worldEyeVec, normalize(bumpNormal));
   var cubemapColor = textureSample(cubeTex, cubeSampler, reflDir.xzy);
   var reflectionStrength = 0.6 * tsUniforms.fogState.z;
   outCol = vec4<f32>(outCol.rgb + cubemapColor.rgb * reflectionStrength, outCol.a);

   var halfAng = normalize(eyeVec + outLightVec);
   var specValue = clamp(dot(bumpNormal, halfAng), 0.0, 1.0) * in.camDir.w;

   var specularColor = tsUniforms.fogColor;
   var shininess = tsUniforms.fogState.x;
   var specular = specularColor * pow(specValue, shininess);
   outCol += specular * diffuse.a;
   if (tsUniforms.fogState.y < 0.5 && tsUniforms.fogState.z < 0.5) {
      outCol.a = 1.0;
   }

   // Gamma correction using our regression model
	var a = 1.00759;
	var b = 1.18764;
	outCol.r = a * pow(outCol.r, b);
	outCol.g = a * pow(outCol.g, b);
	outCol.b = a * pow(outCol.b, b);

//    outCol = vec4<f32>(cubemapColor.rgb, 1.0);

   return outCol;
}
