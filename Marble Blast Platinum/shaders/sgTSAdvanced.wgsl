#include "stStructs.wgsl"
#include "sgCommon.wgsl"
#include "sgTSCommon.wgsl"

// UG_COMMON_TS
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
@group(0) @binding(1)
var<uniform> tsUniforms: TSUniformSet;
// TG_TEX4
@group(1) @binding(0)
var texs0: texture_2d<f32>; // diffuse
@group(1) @binding(1)
var texs1: texture_2d<f32>; // emap alpha
@group(1) @binding(2)
var texs2: texture_2d<f32>; // dmap
@group(1) @binding(3)
var texs3: texture_2d<f32>; // unused
@group(1) @binding(4)
var samplers0: sampler;
@group(1) @binding(5)
var samplers1: sampler;
@group(1) @binding(6)
var samplers2: sampler;
@group(1) @binding(7)
var samplers3: sampler;

// TG_TEX2
@group(2) @binding(0)
var etexs0: texture_2d<f32>; // fog
@group(2) @binding(1)
var etexs1: texture_2d<f32>; // emap
@group(2) @binding(2)
var esamplers0: sampler;
@group(2) @binding(3)
var esamplers1: sampler;

// Advanced TS Util


fn HandleAdvancedMapFrag(base: vec4<f32>,
                           in: TSRasterizerData,
                           emapTex: texture_2d<f32>, // emap
                           emapSampler: sampler,
                           emapAlphaTex: texture_2d<f32>, // emapAlpha
                           emapAlphaSampler: sampler,
                           dmap: texture_2d<f32>, // dmap
                           dmapSampler: sampler) -> vec4<f32> {
   var calcColor : vec4<f32> = base;
   
   // Control vars
   var dmapOn : f32 = 1.0-step(in.fragControl.z, 0.0);
   var emapOn : f32 = 1.0-step(in.fragControl.y, 0.0);
   var alphaIsReflectance : f32 = 1.0-step(in.fragControl.w, 0.0);
   var invDmapOn : f32 = 1.0-dmapOn;
   var invEmapOn : f32 = 1.0-emapOn;
   var invAlphaIsReflectance : f32 = 1.0-alphaIsReflectance;
   
   // EMap via envTexCoord
   
   var emapTexture : vec4<f32> = textureSample(emapTex, emapSampler, in.envTexCoord);
   var emapAlpha : f32 = textureSample(emapAlphaTex, emapAlphaSampler, in.uv1).a;
   // We need to choose either emapTexture.a or emapAlpha depending on whether
   // fragControl.w is set
   var emapMaskAlpha : f32 = (alphaIsReflectance * emapAlpha) + (invAlphaIsReflectance * emapTexture.a);
   // Modulate with env flag
   emapMaskAlpha *= in.fragControl.y;

   calcColor = vec4<f32>(calcColor.rgb, calcColor.a * invAlphaIsReflectance + emapMaskAlpha * alphaIsReflectance);

   // Apply to emapTexture
   // emapTexture = vec4<f32>((emapTexture.rgb * emapMaskAlpha) + (calcColor.rgb * (1.0 - emapMaskAlpha)), calcColor.a);
   // Output
   calcColor = mix(emapTexture, calcColor, emapAlpha); // (emapOn * emapTexture) + (invEmapOn * calcColor);
   
   // DMap via uv2
   // NOTE: original TGE has a convoluted setup for this. Instead we are just going to
   // at least be consistent for 99% of cases.
   
   // var dmapAlphaOut : f32 = (1.0f-in.fragControl.z)*0.5f;
   // var dmapTexture : vec4<f32> = textureSample(dmap, dmapSampler, in.uv2);
   // var dmapTexEnv : vec3<f32> = vec3<f32>(1.0-dmapAlphaOut,1.0-dmapAlphaOut,1.0-dmapAlphaOut);
   // // Apply to dmapTexture (i.e. GL_BLEND)
   // dmapTexture = vec4<f32>((dmapTexEnv.rgb * dmapTexture.rgb) + (1.0 * (vec3<f32>(1.0,1.0,1.0) - dmapTexture.rgb)), dmapTexture.a);
   // // Blend with base (DST_COLOR, SRC_COLOR); passthrough alpha
   // dmapTexture = vec4<f32>((dmapTexture.rgb * calcColor.rgb) + (calcColor.rgb * dmapTexture.rgb), calcColor.a);
   // calcColor = (dmapOn * dmapTexture) + (invDmapOn * calcColor);
   
   // Output
   return calcColor;
}

// Advanced TSPL Shaders

@vertex
fn vTSPL_ADVANCED_MAP(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   HandleEnvironmentMap(&out, in);
   return out;
}

@vertex
fn vTSPL_ADVANCED_MAP_DEPTH(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   HandleEnvironmentMap(&out, in);
   return out;
}

@vertex
fn vTSPL_ADVANCED_MAP_FOG(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   HandleBasicFog(&out, in);
   HandleEnvironmentMap(&out, in);
   return out;
}

@vertex
fn vTSPL_ADVANCED_MAP_FOG_DEPTH(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicLitShape(&out, in);
   HandleBasicFog(&out, in);
   HandleEnvironmentMap(&out, in);
   return out;
}

@vertex
fn vTSPL_SELFILLUM_ADVANCED_MAP(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicUnlitShape(&out, in);
   HandleEnvironmentMap(&out, in);
   return out;
}

@vertex
fn vTSPL_SELFILLUM_ADVANCED_MAP_DEPTH(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicUnlitShape(&out, in);
   HandleEnvironmentMap(&out, in);
   return out;
}

@vertex
fn vTSPL_SELFILLUM_ADVANCED_MAP_FOG(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicUnlitShape(&out, in);
   HandleEnvironmentMap(&out, in);
   HandleBasicFog(&out, in);
   return out;
}

@vertex
fn vTSPL_SELFILLUM_ADVANCED_MAP_FOG_DEPTH(in: TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;
   HandleBasicUnlitShape(&out, in);
   HandleEnvironmentMap(&out, in);
   HandleBasicFog(&out, in);
   return out;
}

@fragment
fn fTSPL_ADVANCED_MAP(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleAdvancedMapFrag(calcColor,
                                     in,
                                     etexs1, esamplers1,  // emap
                                     texs0,  samplers0,  // emapAlpha
                                     texs2,  samplers2); // dmap
   return calcColor;
}

@fragment
fn fTSPL_ADVANCED_MAP_DEPTH(in: TSRasterizerData) -> @location(0) vec4<f32> {
   
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleAdvancedMapFrag(calcColor,
                                     in,
                                     etexs1, esamplers1,  // emap
                                     texs0,  samplers0,  // emapAlpha
                                     texs2,  samplers2); // dmap
   return calcColor;
}

@fragment
fn fTSPL_ADVANCED_MAP_FOG(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleAdvancedMapFrag(calcColor,
                                     in,
                                     etexs1, esamplers1,  // emap
                                     texs0,  samplers0,  // emapAlpha
                                     texs2,  samplers2); // dmap
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}

@fragment
fn fTSPL_ADVANCED_MAP_FOG_DEPTH(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleAdvancedMapFrag(calcColor,
                                     in,
                                     etexs1, esamplers1,  // emap
                                     texs0,  samplers0,  // emapAlpha
                                     texs2,  samplers2); // dmap
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}


@fragment
fn fTSPL_SELFILLUM_ADVANCED_MAP(in: TSRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleAdvancedMapFrag(calcColor,
                                     in,
                                     etexs1, esamplers1,  // emap
                                     texs1,  samplers1,  // emapAlpha
                                     texs2,  samplers2); // dmap
   return calcColor;
}

@fragment
fn fTSPL_SELFILLUM_ADVANCED_MAP_DEPTH(in: TSRasterizerData) -> @location(0) vec4<f32> {
   
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleAdvancedMapFrag(calcColor,
                                     in,
                                     etexs1, esamplers1,  // emap
                                     texs1,  samplers1,  // emapAlpha
                                     texs2,  samplers2); // dmap
   return calcColor;
}

@fragment
fn fTSPL_SELFILLUM_ADVANCED_MAP_FOG(in: TSRasterizerData) -> @location(0) vec4<f32> {
   
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleAdvancedMapFrag(calcColor,
                                     in,
                                     etexs1, esamplers1,  // emap
                                     texs1,  samplers1,  // emapAlpha
                                     texs2,  samplers2); // dmap
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}

@fragment
fn fTSPL_SELFILLUM_ADVANCED_MAP_FOG_DEPTH(in: TSRasterizerData) -> @location(0) vec4<f32> {
   
   var calcColor : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba) * in.color;
   calcColor = HandleAdvancedMapFrag(calcColor,
                                     in,
                                     etexs1, esamplers1,  // emap
                                     texs1,  samplers1,  // emapAlpha
                                     texs2,  samplers2); // dmap
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs0, esamplers0);
   return calcColor;
}
