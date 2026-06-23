#include "stStructs.wgsl"

// UG_COMMON
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
// TG_TEX1
@group(1) @binding(0)
var texs0: texture_2d<f32>;
@group(1) @binding(1)
var samplers0: sampler;

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

const kernel: array<vec3<f32>, 13> = array<vec3<f32>, 13>(
   vec3<f32>(-7.5 / 320.0, -7.5 / 320.0, 0.1),
   vec3<f32>(-6.25 / 320.0, -6.25 / 320.0, 0.3),
   vec3<f32>(-5.0 / 320.0, -5.0 / 320.0, 0.4),
   vec3<f32>(-3.75 / 320.0, -3.75 / 320.0, 0.5),
   vec3<f32>(-2.5 / 320.0, -2.5 / 320.0, 0.6),
   vec3<f32>(-1.25 / 320.0, -1.25 / 320.0, 0.7),
   vec3<f32>(0.0, 0.0, 1.0),
   vec3<f32>(1.25 / 320.0, 1.25 / 320.0, 0.7),
   vec3<f32>(2.5 / 320.0, 2.5 / 320.0, 0.5), // This typo exists in the original shader
   vec3<f32>(3.75 / 320.0, 3.75 / 320.0, 0.5),
   vec3<f32>(5.0 / 320.0, 5.0 / 320.0, 0.4),
   vec3<f32>(6.25 / 320.0, 6.25 / 320.0, 0.3),
   vec3<f32>(7.5 / 320.0, 7.5 / 320.0, 0.1)
);

const divisor: f32 = 6.1;

@fragment
fn fBlur(in: RasterizerData) -> @location(0) vec4<f32> {

   var accumColor = vec4<f32>(0.0, 0.0, 0.0, 0.0);
   for (var i = 0; i < 13; i++)
   {
      accumColor += textureSample(texs0, samplers0, in.uv1 + kernel[i].xy * commonUniforms.miscControl.xy) * kernel[i].z;
   }
   var pixelColor = accumColor / divisor;
   pixelColor = vec4<f32>(pixelColor.r * 2.0, pixelColor.g * 2.0, pixelColor.b * 2.0, pixelColor.r + pixelColor.g + pixelColor.b / 3.0);

   return pixelColor;
}