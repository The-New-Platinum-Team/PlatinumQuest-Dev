#include "stStructs.wgsl"
#include "sgCommon.wgsl"

// UG_TERRAIN_BLEND
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
@group(0) @binding(1)
var samplers0: sampler;
@group(0) @binding(2)
var alphaSampler: sampler;

// TG_TEX8
@group(1) @binding(0)
var texs0: texture_2d<f32>;
@group(1) @binding(1)
var texs1: texture_2d<f32>;
@group(1) @binding(2)
var texs2: texture_2d<f32>;
@group(1) @binding(3)
var texs3: texture_2d<f32>;
@group(1) @binding(4)
var texs4: texture_2d<f32>;
@group(1) @binding(5)
var texs5: texture_2d<f32>;
@group(1) @binding(6)
var texs6: texture_2d<f32>;
@group(1) @binding(7)
var texs7: texture_2d<f32>;

// TG_TEX8
@group(2) @binding(0)
var atexs0: texture_2d<f32>;
@group(2) @binding(1)
var atexs1: texture_2d<f32>;
@group(2) @binding(2)
var atexs2: texture_2d<f32>;
@group(2) @binding(3)
var atexs3: texture_2d<f32>;
@group(2) @binding(4)
var atexs4: texture_2d<f32>;
@group(2) @binding(5)
var atexs5: texture_2d<f32>;
@group(2) @binding(6)
var atexs6: texture_2d<f32>;
@group(2) @binding(7)
var atexs7: texture_2d<f32>;

struct TerrainBlendData {
   @builtin(position)  clipSpacePosition: vec4<f32>,
   @location(1) uv1: vec2<f32>,
   @location(2) uv2: vec2<f32>,
   @location(3) @interpolate(flat) c1: vec4<f32>,
   @location(4) @interpolate(flat) c2: vec4<f32>
};

// Terrain blender specific shaders

@vertex
fn vTerrainBlendVert(in: GuiVert) -> TerrainBlendData {
   var out : TerrainBlendData;
   
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0);
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   out.clipSpacePosition = calcPos * mvp;
   out.uv1 = in.tex;
   out.uv2 = in.texe;

   out.c1 = select(vec4<f32>(0.0), vec4<f32>(1.0), vec4<bool>(in.pad1 > vec4<u32>(0)));
   out.c2 = select(vec4<f32>(0.0), vec4<f32>(1.0), vec4<bool>(in.pad2 > vec4<u32>(0)));
   
   return out;
}

@fragment
fn fTerrainBlendSquare(in: TerrainBlendData) -> @location(0) vec4<f32> {
   var v1: vec3<f32> = (
                 textureSample(texs0, samplers0, in.uv1).rgb *
                 textureSample(atexs0, alphaSampler, in.uv2).r
                 );
   var v2: vec3<f32> = (
                 textureSample(texs1, samplers0, in.uv1).rgb *
                 textureSample(atexs1, alphaSampler, in.uv2).r
                 );
   var v3: vec3<f32> = (
                 textureSample(texs2, samplers0, in.uv1).rgb *
                 textureSample(atexs2, alphaSampler, in.uv2).r
                 );
   var v4: vec3<f32> = (
                 textureSample(texs3, samplers0, in.uv1).rgb *
                 textureSample(atexs3, alphaSampler, in.uv2).r
                 );
   var v5: vec3<f32> = (
                 textureSample(texs4, samplers0, in.uv1).rgb *
                 textureSample(atexs4, alphaSampler, in.uv2).r
                 );
   var v6: vec3<f32> = (
                 textureSample(texs5, samplers0, in.uv1).rgb *
                 textureSample(atexs5, alphaSampler, in.uv2).r
                 );
   var v7: vec3<f32> = (
                 textureSample(texs6, samplers0, in.uv1).rgb *
                 textureSample(atexs6, alphaSampler, in.uv2).r
                 );
   var v8: vec3<f32> = (
                 textureSample(texs7, samplers0, in.uv1).rgb *
                 textureSample(atexs7, alphaSampler, in.uv2).r
                 );

   // NOTE: to avoid excess uniform buffer use, we store the alpha stuff inside color and norm
   return vec4<f32>((v1 * in.c1.x) + (v2 * in.c1.y) + (v3 * in.c1.z) + (v4 * in.c1.w) +
   (v5 * in.c2.x) + (v6 * in.c2.y) + (v7 * in.c2.z) + (v8 * in.c2.w), 1.0);
}
