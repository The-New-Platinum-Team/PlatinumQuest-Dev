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
var texs1: texture_2d<f32>; // emap (yes, actually grouped!)
@group(1) @binding(2)
var samplers0: sampler;
@group(1) @binding(3)
var samplers1: sampler;
// TG_TEX1
@group(2) @binding(0)
var etexs0: texture_2d<f32>; // fog
@group(2) @binding(1)
var esamplers0: sampler;
// TG_TEX1
@group(3) @binding(0)
var ltexs0: texture_2d<f32>; // lmap
@group(3) @binding(1)
var lsamplers0: sampler;


// Interior Shaders

@vertex
fn vInterior(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicUnlitShape(&out, in);
   HandleBasicFog(&out, in);
   return out;
}

@vertex
fn vInteriorShape(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   HandleBasicFog(&out, in);
   return out;
}

@vertex
fn vInteriorEnvMap(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   HandleBasicFog(&out, in);
   return out;
}

@fragment
fn fInteriorVertLit(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var base : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color; // base
   var fogSample : vec4<f32> = in.fogColor.a * textureSample(texs1, samplers1, in.fogTexCoord).rgba; // fog
   
   // GL_DECAL blending
   return vec4<f32>((fogSample.rgb * fogSample.a) + (base.rgb * (1.0f - fogSample.a)), base.a);
}

@fragment
fn fInteriorLightmap(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var lightmapColor : vec3<f32> = textureSample(ltexs0, lsamplers0, in.uv2).rgb; // lmap
   var baseTex : vec4<f32> = textureSample(texs0, samplers0, in.uv1).rgba; // base
   
   // Base
   var calcColor : vec4<f32> = vec4<f32>(baseTex.rgb * lightmapColor.rgb, baseTex.a * in.color.a);// * in.color;
   // Fog
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}

@fragment
fn fInteriorEnvMap(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var envTex : vec4<f32> = textureSample(texs1, samplers1, in.uv1).rgba; // env
   // Base
   var calcColor : vec4<f32> = vec4<f32>(envTex.rgba * in.color);// * in.color;
   // Fog
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}
