#include "stStructs.wgsl"
#include "sgCommon.wgsl"

@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
// TG_TEX
@group(1) @binding(0)
var texs0: texture_2d<f32>;
@group(1) @binding(1)
var samplers0: sampler;


// Line Shader

@vertex
fn vLine(in: ITRVert) -> RasterizerData {
   var out : RasterizerData;  
   
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   var pdir : vec4<f32> = vec4<f32>(in.norm.xyz, 0.0f) * mvp; 
   var len : f32 = sqrt(pdir.x * pdir.x + pdir.y * pdir.y);
   pdir.x /= len;
   pdir.y /= len;
   var projectedPosition : vec4<f32> = vec4<f32>(in.pos + in.norm.xyz * in.tex.x, 1) * mvp;
   projectedPosition += vec4<f32>((vec2<f32>(pdir.y * 1.0, pdir.x * -1.0)) * (in.tex.y - 0.5) * projectedPosition.z * commonUniforms.coreScale.xy * commonUniforms.coreScale.z, 0, 0);

   out.clipSpacePosition = projectedPosition;
   out.color = in.col;
   out.norm = vec3<f32>(0,0,0);
   out.alpha_test = commonUniforms.miscControl.x;
   return out;
}

@fragment
fn fLine(in: RasterizerData) -> @location(0) vec4<f32> {
   return in.color;
}