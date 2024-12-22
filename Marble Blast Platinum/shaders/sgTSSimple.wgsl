#include "stStructs.wgsl"
#include "sgCommon.wgsl"
#include "sgTSCommon.wgsl" 

// UG_COMMON_TS
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
@group(0) @binding(1)
var<uniform> tsUniforms: TSUniformSet;
// TG_TEX1
@group(1) @binding(0)
var texs0: texture_2d<f32>; // diffuse
@group(1) @binding(1)
var samplers0: sampler;
// TG_TEX2
@group(2) @binding(0)
var etexs0: texture_2d<f32>; // fog
@group(2) @binding(1)
var etexs1: texture_2d<f32>; // emap
@group(2) @binding(2)
var esamplers0: sampler;
@group(2) @binding(3)
var esamplers1: sampler;

// Simple TSPL Shaders (requiring at most 2 textures)

@vertex
fn vTSPL(in : TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   return out;
}

@vertex
fn vTSPL_SELFILLUM(in : TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicUnlitShape(&out, in);
   return out;
}


@vertex
fn vTSPL_DEPTH(in : TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   return out;
}

@vertex
fn vTSPL_FOG(in : TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   HandleBasicFog(&out, in);
   return out;
}

@vertex
fn vTSPL_FOG_DEPTH(in : TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   HandleBasicFog(&out, in);
   return out;
}

@vertex
fn vTSPL_SELFILLUM_DEPTH(in : TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicUnlitShape(&out, in);
   return out;
}

@vertex
fn vTSPL_SELFILLUM_FOG(in : TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicUnlitShape(&out, in);
   HandleBasicFog(&out, in);
   return out;
}

@vertex
fn vTSPL_SELFILLUM_FOG_DEPTH(in : TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicUnlitShape(&out, in);
   HandleBasicFog(&out, in);
   return out;
}



@fragment
fn fTSPL(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   return calcColor;
}

//

@fragment
fn fTSPL_SELFILLUM_DEPTH(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   return calcColor;
}

@fragment
fn fTSPL_SELFILLUM_FOG(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}

@fragment
fn fTSPL_SELFILLUM_FOG_DEPTH(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}


@fragment
fn fTSPL_DEPTH(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   return calcColor;
}

@fragment
fn fTSPL_FOG(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}

@fragment
fn fTSPL_FOG_DEPTH(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}

@fragment
fn fTSPL_SELFILLUM(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   return calcColor;
}
