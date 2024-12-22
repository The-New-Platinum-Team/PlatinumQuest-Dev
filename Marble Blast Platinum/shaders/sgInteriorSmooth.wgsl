#include "stStructs.wgsl"
#include "sgCommon.wgsl"
#include "sgTSCommon.wgsl"

// UG_COMMON_TS
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
@group(0) @binding(1)
var<uniform> tsUniforms: TSUniformSet;
// TG_TEX2
@group(1) @binding(0)
var texs0: texture_2d<f32>; // base
@group(1) @binding(1)
var samplers0: sampler;


// Interior Shaders

@vertex
fn vInteriorSmooth(in: ITRVert) -> TSRasterizerData {
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
fn fInteriorSmooth(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var base : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color; // base
   return base;
}