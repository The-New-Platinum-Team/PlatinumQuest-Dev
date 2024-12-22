#include "stStructs.wgsl"
#include "sgCommon.wgsl"
#include "sgTSCommon.wgsl"

// UG_FLUID
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
@group(0) @binding(1)
var<uniform> tsUniforms: TSUniformSet;
@group(0) @binding(2)
var<uniform> fluidUniforms: FluidUniformSet;
// TG_TEX4
@group(1) @binding(0)
var texs0: texture_2d<f32>; // base
@group(1) @binding(1)
var texs1: texture_2d<f32>; // shore
@group(1) @binding(2)
var texs2: texture_2d<f32>; // shoreDepth
@group(1) @binding(3)
var texs3: texture_2d<f32>; // spec
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
var etexs0: texture_2d<f32>; // env
@group(2) @binding(1)
var etexs1: texture_2d<f32>; // fog
@group(2) @binding(2)
var esamplers0: sampler;
@group(2) @binding(3)
var esamplers1: sampler;

struct WaterRasterizerData {
   @builtin(position) clipSpacePosition : vec4<f32>,
   
   @location(0) worldSpacePosition : vec3<f32>,
   @location(1) modelViewPosition : vec3<f32>,
   @location(2) norm : vec3<f32>,
   @location(3) fogTexCoord : vec2<f32>,
   @location(4) color : vec4<f32>,
   @location(5) @interpolate(flat) viewParams : vec4<f32>,
   @location(6) @interpolate(flat) viewParams2 : vec4<f32>,
   
   @location(7) @interpolate(flat) lightDir : vec4<f32>,
   @location(8) @interpolate(flat) camDir : vec4<f32>,
   @location(9) @interpolate(flat) fogColor : vec4<f32>,
   
   // FluidVert
   @location(10) uv12 : vec4<f32>,
   @location(11) alt_uv1 : vec2<f32>,
   @location(12) specular_uv1 : vec2<f32>,
   @location(13) uv34 : vec4<f32>,
   @location(14) rgba3 : vec4<f32>,
   @location(15) specular : vec4<f32>
}

// Water shaders

fn HandleWaterFog(out: ptr<function, WaterRasterizerData>, in: TSVert) {
   var camPos : vec3<f32> = (vec4<f32>(0,0,0,1) * commonUniforms.invCameraView).xyz;
   (*out).fogTexCoord = CalcFogCoord((*out).worldSpacePosition, camPos, tsUniforms.fogState);
   (*out).fogColor = tsUniforms.fogColor;
}

fn SetupFluidBasicVert(out: ptr<function, WaterRasterizerData>,
                           in: TSVert)
{
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0f);
   var calcNorm : vec4<f32> = vec4<f32>(in.norm.xyz, 0.0f);
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   
   (*out).clipSpacePosition = calcPos * mvp;
   (*out).worldSpacePosition = (calcPos * tsUniforms.objectMat);
   (*out).modelViewPosition = (calcPos * mv).xyz;
   //(*out).uv1 = (vec4<f32>(in.tex1.xy, 0.0,1.0) * tsUniforms.texMats[0]).xy;
   //(*out).uv2 = (vec4<f32>(in.tex2.xy, 0.0,1.0) * tsUniforms.texMats[1]).xy;
   (*out).norm = (calcNorm * mvp).xyz;
   (*out).camDir = vec4<f32>(normalize((vec4<f32>(0,1,0,0) * expandTo44(commonUniforms.invCameraView)).xyz), 0);
   
   (*out).color = commonUniforms.modulationColor;
}

fn SetupFluidTexMatSetup(out: ptr<function, WaterRasterizerData>) {
   var orig_uv1 : vec2<f32> = (*out).uv12.xy;

   var out_uv1 : vec2<f32> = (vec4<f32>((*out).uv12.xy, 0.0,1.0)  * tsUniforms.texMats[0]).xy; // base depth
   (*out).alt_uv1 = (vec4<f32>(orig_uv1.xy, 0.0,1.0) * tsUniforms.texMats[1]).xy; // parallax layer
   var out_uv2 : vec2<f32> = (vec4<f32>((*out).uv12.zw, 0.0,1.0)  * tsUniforms.texMats[0]).xy; // shore
   
   (*out).uv12 = vec4<f32>(out_uv1, out_uv2);

   // rotate (30.0f, 0.0f, 0.0f, 1.0f),
   // scale (0.2, 0.2, 0.2)
   var specularMatrix : mat4x4<f32> = mat4x4<f32>   (
     vec4<f32>(0.200000003, 0, 0, 0),
     vec4<f32>(0, 0.17258513, 0.104714431, 0),
     vec4<f32>(0, 0, 0.17258513, 0),
     vec4<f32>(0, 0, 0, 1));
   (*out).specular_uv1 = (vec4<f32>(orig_uv1.xy, 0.0,1.0) * specularMatrix).xy;
}

// Sets up texcoords for a fluid vertex
fn SetupFluidVert(out: ptr<function, WaterRasterizerData>, objectPos: vec3<f32>) {
   /* const */ var eyePos : vec3<f32> = fluidUniforms.viewParams.xyz;
   /* const */ var envMapIntensity : f32 = fluidUniforms.viewParams.w;
   /* const */ var squarePos : vec2<f32> = fluidUniforms.squareDepthPoints.xy;
   /* const */ var depthTexel : vec2<f32> = fluidUniforms.squareDepthPoints.zw;
   /* const */ var tessSurface : f32 = fluidUniforms.tessDistortParams.x;
   /* const */ var tessShore : f32 = fluidUniforms.tessDistortParams.y;
   /* const */ var distortMagnitude : f32 = fluidUniforms.tessDistortParams.z;
   /* const */ var distortGridScale : f32 = fluidUniforms.tessDistortParams.w;
   /* const */ var secsInDistortTime : f32 = fluidUniforms.timeParams.x;
   
   // Calc reflection vector
   var objectDistance : f32 = length(eyePos - objectPos);
   var reflectionVector : vec3<f32> = vec3<f32>(objectPos.x - eyePos.x,
                                    eyePos.y - objectPos.y,
                                    objectPos.z - eyePos.z);
   
   reflectionVector.z = max(abs(reflectionVector.z), 0.001f);
   
   // Calc uv3
   var distanceFactor : f32 = saturate(objectDistance / 0.001);
   var envMultiplier : f32 = (objectDistance - reflectionVector.z) / (objectDistance * objectDistance); // moves away from edges
   var out_uv3 : vec2<f32> = reflectionVector.xy * envMultiplier * distanceFactor;
   
   // Change range
   out_uv3 = (out_uv3 * 0.5) + vec2<f32>(0.5, 0.5);
   
   // Distortion
   var qValues : vec3<f32> = vec3<f32>(150.0, 2.0, 0.01);
   var aValues : vec2<f32> = vec2<f32>(cos((objectPos.x / qValues.x) + secsInDistortTime),
                           sin((objectPos.y / qValues.x) + secsInDistortTime));
   out_uv3 = out_uv3 + (aValues.xy * qValues.zz);
   
   // Fresnel blend
   var baseEnvIntensity : f32 = ((aValues.x + aValues.y) * 0.15f + 0.5f);
   (*out).rgba3 = vec4<f32>(1.0, 1.0, 1.0, baseEnvIntensity * envMapIntensity);
   
   var sTValues : vec2<f32> = vec2<f32>(distortMagnitude * cos((objectPos.x * distortGridScale) + secsInDistortTime),
                            distortMagnitude * sin((objectPos.y * distortGridScale) + secsInDistortTime));
   
   var out_uv1 : vec2<f32> = ((((objectPos.xy - (squarePos * 8)) * depthTexel.xy)) * tessSurface) + sTValues;
   var out_uv2 : vec2<f32> = ((((objectPos.xy - (squarePos * 8)) * depthTexel.xy)) * tessShore  ) + sTValues;
   var out_uv4 : vec2<f32> = (   objectPos.xy - (squarePos * 8)) * depthTexel.xy;
   
   (*out).uv12 = vec4<f32>(out_uv1, out_uv2);
   (*out).uv34 = vec4<f32>(out_uv3, out_uv4);

   (*out).viewParams = fluidUniforms.viewParams;
   (*out).viewParams2 = fluidUniforms.viewParams2;
   (*out).lightDir = fluidUniforms.lightDir;
}

fn SetupFluidVertSpecular(out: ptr<function, WaterRasterizerData>, objectPos: vec3<f32>) {
   var eyeDir : vec3<f32> = normalize((*out).viewParams.xyz - objectPos.xyz);
   var halfVec : vec3<f32> = normalize(-fluidUniforms.lightDir.xyz + eyeDir);
   var specValue : f32 = dot(halfVec, vec3<f32>(0.0, 0.0, 1.0));
   specValue = max(specValue, 0.0);
   (*out).specular = fluidUniforms.specColor * pow(specValue, fluidUniforms.lightDir.w);
}

@vertex
fn vWaterBlockSimple(in: TSVert) -> WaterRasterizerData {
   var out : WaterRasterizerData;
   
   SetupFluidBasicVert(&out, in);
   SetupFluidVert(&out, in.pos.xyz);
   SetupFluidTexMatSetup(&out);
   HandleWaterFog(&out, in);
   
   return out;
}

// NOTE: in TGE, the fancy waterblock is rendered in several stages, and through the magic of blending
// it pulls in the current fragment color on each pass. So Its practically impossible to replicate the
// specific look without following this convention.

@vertex
fn vWaterBlockAdvanced(in : TSVert) -> WaterRasterizerData {
   var out : WaterRasterizerData;
   
   SetupFluidBasicVert(&out, in);
   SetupFluidVert(&out, in.pos.xyz);
   SetupFluidTexMatSetup(&out);
   SetupFluidVertSpecular(&out, in.pos.xyz);
   HandleWaterFog(&out, in);
   
   return out;
}

@fragment
fn fWaterBlockSimple(in: WaterRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32> = vec4<f32>(0,0,0,1);
   var calcColorBase : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.uv12.xy).rgba) * in.viewParams2.x; // base
   var calcColorParallax : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.alt_uv1).rgba) * in.viewParams2.x; // base
   var calcColorEnvMap : vec4<f32> = vec4<f32>(textureSample(etexs0, esamplers0, in.uv34.xy).rgba) * in.viewParams.w; // env map
   
   var baseFlag : f32 = 1.0-step(in.viewParams2.x, 0.0);
   var invBaseFlag : f32 = 1.0-baseFlag;
   var parallaxFlag : f32 = 1.0-step(in.viewParams2.y, 0.0);
   var invParallaxFlag : f32 = 1.0-parallaxFlag;
   
   // Blend layers
   var newColor : vec4<f32> = (calcColorBase.rgba * calcColorBase.a) + (calcColor.rgba * (1.0 - calcColorBase.a));
   calcColor = (newColor * baseFlag) + (calcColor * invBaseFlag);
   newColor = (calcColorParallax.rgba * calcColorParallax.a) + (calcColor.rgba * (1.0 - calcColorParallax.a));
   calcColor = (newColor * parallaxFlag) + (calcColor * invParallaxFlag);
   
   // Blend env map (uses GL_ONE)
   calcColor = (calcColorEnvMap.rgba * calcColorEnvMap.a) + (calcColor.rgba);
   
   // Apply fog
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs1, esamplers1);
   return calcColor;
}

@fragment
fn fWaterBlockAdvancedStage1(in: WaterRasterizerData) -> @location(0) vec4<f32> {
   var calcDepth : vec4<f32> = vec4<f32>(1,1,1, (textureSample(texs2, samplers2, in.uv34.zw).r)); // shoreDepth
   var layerOpacity : vec4<f32>    = vec4<f32>(1,1,1, in.viewParams2.x);
   var calcColorBase : vec4<f32>     = vec4<f32>(textureSample(texs0, samplers0, in.uv12.xy).rgba) * calcDepth; // base
   
   var baseFlag : f32 = 1.0-step(in.viewParams2.x, 0.0);
   return (calcColorBase * layerOpacity) * baseFlag;
}

@fragment
fn fWaterBlockAdvancedStage2(in: WaterRasterizerData) -> @location(0) vec4<f32> {
   var calcDepth : vec4<f32> = vec4<f32>(1,1,1, (textureSample(texs2, samplers2, in.uv34.zw).r)); // shoreDepth
   var layerOpacity : vec4<f32>    = vec4<f32>(1,1,1, in.viewParams2.x);
   var calcColorParallax : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.alt_uv1).rgba) * calcDepth; // base
   
   var parallaxFlag : f32 = 1.0-step(in.viewParams2.y, 0.0);
   return (calcColorParallax * layerOpacity) * parallaxFlag;
}

@fragment
fn fWaterBlockAdvancedStage3(in: WaterRasterizerData) -> @location(0) vec4<f32> {
   var calcShore : vec4<f32> = vec4<f32>(1,1,1, (textureSample(texs2, samplers2, in.uv34.zw).g)); // shoreDepth
   var layerOpacity : vec4<f32>    = vec4<f32>(1,1,1, in.viewParams2.x);
   var calcColorShore : vec4<f32>    = vec4<f32>(textureSample(texs1, samplers1, in.uv12.zw).rgba) * calcShore; // shore
   
   // Shore
   return calcColorShore * layerOpacity;
}

@fragment
fn fWaterBlockAdvancedStage4(in: WaterRasterizerData) -> @location(0) vec4<f32> {
   var calcDepth : vec4<f32> = vec4<f32>(1,1,1, (textureSample(texs2, samplers2, in.uv34.zw).r)); // shoreDepth
   var layerOpacity : vec4<f32>    = vec4<f32>(1,1,1, in.viewParams2.x);
   var calcSpecularMask : vec4<f32>  = vec4<f32>(textureSample(texs3, samplers3, in.specular_uv1).rgba) * in.specular * calcDepth; // spec
   
   //
   // Specular highlights
   return calcSpecularMask * layerOpacity;
}

@fragment
fn fWaterBlockAdvancedStage5(in: WaterRasterizerData) -> @location(0) vec4<f32> {
   var calcDepth : vec4<f32> = vec4<f32>(1,1,1, (textureSample(texs2, samplers2, in.uv34.zw).r)); // shoreDepth
   var layerOpacity : vec4<f32>    = vec4<f32>(1,1,1, in.viewParams2.x);
   var calcEnvMap : vec4<f32>      = vec4<f32>(textureSample(etexs0, esamplers0, in.uv34.xy).rgba) * calcDepth * in.rgba3; // env
   
   // Blend env map
   return calcEnvMap * layerOpacity;
}

@fragment
fn fWaterBlockAdvancedStage6(in: WaterRasterizerData) -> @location(0) vec4<f32> {
   var fogSample : vec4<f32> = in.fogColor.a * textureSample(etexs1, esamplers1, in.fogTexCoord).rgba; // fog
   return fogSample;
}


@fragment
fn fWaterBlockAdvanced(in: WaterRasterizerData) -> @location(0) vec4<f32> {
   var calcColor : vec4<f32>       = vec4<f32>(0,0,0,0);
   var layerOpacity : vec4<f32>    = vec4<f32>(1,1,1, in.viewParams2.x);
   var depthShore : vec2<f32> = textureSample(texs2, samplers2, in.uv34.zw).rg; // shoreDepth
   var calcDepth : vec4<f32> = vec4<f32>(1,1,1, (depthShore.r));
   var calcShore : vec4<f32> = vec4<f32>(1,1,1, (depthShore.g));
   var calcColorBase : vec4<f32>     = vec4<f32>(textureSample(texs0, samplers0, in.uv12.xy).rgba) * calcDepth; // base
   var calcColorParallax : vec4<f32> = vec4<f32>(textureSample(texs0, samplers0, in.alt_uv1).rgba) * calcDepth; // base
   var calcColorShore : vec4<f32>    = vec4<f32>(textureSample(texs1, samplers1, in.uv12.zw).rgba) * calcShore; // shore
   var calcSpecularMask : vec4<f32>  = vec4<f32>(textureSample(texs3, samplers3, in.specular_uv1).rgba) * in.specular * calcDepth; // spec
   var calcEnvMap : vec4<f32>        = vec4<f32>(textureSample(etexs0,  esamplers0, in.uv34.xy).rgba) * calcDepth * in.rgba3; // env
   
   var baseFlag : f32 = 1.0-step(in.viewParams2.x, 0.0);
   var invBaseFlag : f32 = 1.0-baseFlag;
   var parallaxFlag : f32 = 1.0-step(in.viewParams2.y, 0.0);
   var invParallaxFlag : f32 = 1.0-parallaxFlag;
   
   // NOTE: In non-depth mode (Simple), TGE modulates the color with m_Opacity and blends with (SRC_ALPHA, INV_SRC_ALPHA)
   // In depth mode, it works the same except opacity is always 1 and the depth texture is instead used for alpha modulation.
   
   // Base layer A
   var layerColor : vec4<f32> = calcColorBase * layerOpacity;
   var newColor : vec4<f32> = (layerColor.rgba * layerColor.a) + (calcColor.rgba * (1.0 - layerColor.a));
   calcColor = (newColor * baseFlag) + (calcColor * invBaseFlag); // flag
   // Base layer B
   layerColor = calcColorParallax * layerOpacity;
   newColor   = (layerColor.rgba * layerColor.a) + (calcColor.rgba * (1.0 - layerColor.a));
   calcColor  = (newColor * parallaxFlag) + (calcColor * invParallaxFlag); // flag
   
   // Shore
   layerColor = calcColorShore * layerOpacity;
   calcColor   = (layerColor.rgba * layerColor.a) + (calcColor.rgba * (1.0 - layerColor.a));
   
   // Specular highlights
   layerColor = calcSpecularMask * layerOpacity;
   calcColor   = (layerColor.rgba * layerColor.a) + (calcColor.rgba * (1.0 - layerColor.a));
   //return layerColor;
   
   // Blend env map
   layerColor = calcEnvMap * layerOpacity;
   calcColor   = (layerColor.rgba * layerColor.a) + (calcColor.rgba * (1.0 - layerColor.a));
   
   // Apply fog
   calcColor = HandleFogFrag(calcColor, in.fogTexCoord, in.fogColor, etexs1, esamplers1);
   
   return calcColor;
}

