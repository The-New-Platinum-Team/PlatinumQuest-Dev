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
var etexs0: texture_2d<f32>;
@group(2) @binding(1)
var esamplers0: sampler;

// Terrain-specific shaders





@fragment
fn fTerrainRenderSquare(in: RasterizerData) -> @location(0) vec4<f32> {
   // using haze, distance in terrain vert
   var base : vec4<f32> = textureSample(texs0, samplers0, in.uv1).rgba;  // (haze, distance)
   // using fogRed, fogGreen in terrain vert
   var extra : vec4<f32> = textureSample(etexs0, esamplers0, in.uv2).rgba; // (fogRed, fogGreen)
   
   // GL_REPLACE + GL_DECAL
   // GL_DECAL.rgb = (TEXTURE.rgb * TEXTURE.a) + (PRIMARY.rgb * (1.0 - TEXTURE.a))
   // GL_DECAL.a = extra.a
   return vec4<f32>((extra.rgb * extra.a) + (base.rgb * (1.0f - extra.a)), extra.a);
}
