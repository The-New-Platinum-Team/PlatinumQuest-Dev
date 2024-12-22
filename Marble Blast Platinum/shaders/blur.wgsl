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

fn blur13(uv: vec2<f32>, resolution: vec2<f32>, direction: vec2<f32>) -> vec4<f32> {
    var color: vec4<f32> = vec4<f32>(0.0, 0.0, 0.0, 0.0);
    var off1: vec2<f32> = vec2<f32>(1.411764705882353, 1.411764705882353) * direction;
    var off2: vec2<f32> = vec2<f32>(3.2941176470588234, 3.2941176470588234) * direction;
    var off3: vec2<f32> = vec2<f32>(5.176470588235294, 5.176470588235294) * direction;
    color += textureSample(texs0, samplers0, uv) * 0.1964825501511404;
    color += textureSample(texs0, samplers0, uv + (off1 / resolution)) * 0.2969069646728344;
    color += textureSample(texs0, samplers0, uv - (off1 / resolution)) * 0.2969069646728344;
    color += textureSample(texs0, samplers0, uv + (off2 / resolution)) * 0.09447039785044732;
    color += textureSample(texs0, samplers0, uv - (off2 / resolution)) * 0.09447039785044732;
    color += textureSample(texs0, samplers0, uv + (off3 / resolution)) * 0.010381362401148057;
    color += textureSample(texs0, samplers0, uv - (off3 / resolution)) * 0.010381362401148057;
    return color;
}

@vertex
fn vBlur(in: GuiVert) -> RasterizerData {
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0);
   
   var out : RasterizerData;
   out.clipSpacePosition = calcPos;
   out.uv1 = ((vec2<f32>(in.pos.x + 1.0, -in.pos.y + 1.0)) / 2.0);
   out.uv2 = in.tex;
   out.color = commonUniforms.modulationColor * in.col;
   out.norm = vec3<f32>(0,0,0);
   
   return out;
}

@fragment
fn fBlur(in: RasterizerData) -> @location(0) vec4<f32> {
   var pixel: vec2<f32> = (in.uv1 * commonUniforms.miscControl.zw) / (commonUniforms.miscControl.xy);
   return (blur13(pixel, commonUniforms.miscControl.zw, vec2<f32>(0.0, 1.0)) +
                    blur13(pixel, commonUniforms.miscControl.zw, vec2<f32>(1.0, 0.0))) /
                   2.0;
}