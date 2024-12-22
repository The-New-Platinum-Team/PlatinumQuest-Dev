#include "stStructs.wgsl"
#include "sgCommon.wgsl"

// UG_COMMON
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
// TG_TEX1
@group(1) @binding(0)
var texs0: texture_2d<f32>;
@group(1) @binding(1)
var samplers0: sampler;
// TG_TEX1
@group(2) @binding(0)
var texs1: texture_depth_2d;
@group(2) @binding(1)
var samplers1: sampler;

// http://stackoverflow.com/a/6657284/214063
fn linearize(z_b: f32) -> f32 {
    var z_n: f32 = 2.0 * z_b - 1.0;
    var z_e: f32 = 2.0 * 0.01 * 500.0 / (500.0 + 0.01 - z_n * (500.0 - 0.01));
    return z_e;
}

@vertex
fn vPostFx(in: GuiVert) -> RasterizerData {
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0);
   
   var out : RasterizerData;
   
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   out.clipSpacePosition = calcPos * mvp;
   out.uv1 = in.tex;
   out.uv2 = in.tex;
   out.color = commonUniforms.modulationColor * in.col;
   out.norm = vec3<f32>(0,0,0);
   
   return out;
}

@fragment
fn fPostFx(in: RasterizerData) -> @location(0) vec4<f32> {
   var color: vec4<f32> = textureSample(texs0, samplers0, in.uv1).rgba;
   var depth = linearize((textureSample(texs1, samplers1, in.uv1) + 1.0) / 2.0);

   color = mix(color, vec4<f32>(0.05, 0.2, 0.4, 1.0), clamp((depth - 10) / 20.0, 0.0, 0.5));

   return color * in.color;
}