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
// TG_CUBEMAP1
@group(2) @binding(0)
var cubeTex: texture_cube<f32>; // diffuse
@group(2) @binding(1)
var cubeSampler: sampler;

fn tanh(x: f32) -> f32 {
    return (exp(2.0 * x) - 1.0) / (exp(2.0 * x) + 1.0);
}

fn sigmoid(x: f32) -> f32 {
    return 0.5 + 0.5 * tanh(2.0 * x - 1.0);
}

fn atanh(x: f32) -> f32 {
    return 0.5 * log((1.0 + x) / (1.0 - x));
}

fn invSigmoid(x: f32) -> f32 {
    return 0.5 + 0.5 * atanh(2.0 * x - 1.0);
}

fn uvFromNormal(normal_vector: vec3<f32>) -> vec2<f32> {
    let fourMat = expandTo44(tsUniforms.objectMat);
    let normal_vector_transformed = fourMat * vec4<f32>(normal_vector, 0);
    let ret = vec2<f32>(
        (atan2(normal_vector_transformed.y, normal_vector_transformed.x) + 3.14159265) / (2.0 * 3.14159265),
        (atan2(-normal_vector_transformed.z, sqrt(normal_vector_transformed.x * normal_vector_transformed.x +
                                                  normal_vector_transformed.y * normal_vector_transformed.y)) + 
         3.14159265 / 2.0) / 3.14159265
    );
    return ret;
}

fn frac(t: f32) -> f32 {
    return t - floor(t);
}

fn GetRandom(co: vec2<f32>) -> f32 {
    return frac(sin(dot(co, vec2<f32>(12.9898, 78.233))) * 43758.5453);
}

fn normalWarp(normal: vec3<f32>) -> vec3<f32> {
    let fourMat = expandTo44(tsUniforms.objectMat);
    let local = (fourMat * vec4<f32>(normal, 0.0)).xyz;
    return (transpose(fourMat) * 
           vec4<f32>(normalize(local + 0.1 * vec3<f32>(GetRandom(local.yz), GetRandom(local.zx), GetRandom(local.xy))), 0.0)).xyz;
}


@vertex
fn vMarble(in : TSVert) -> TSRasterizerData {
   var out : TSRasterizerData;

   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0f);
   var calcNorm : vec4<f32> = vec4<f32>(in.norm.xyz, 0.0f);
   var worldPos : vec3<f32> = (calcPos * tsUniforms.objectMat).xyz;
   var worldNorm : vec3<f32> = (calcNorm * tsUniforms.objectMat).xyz;
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   
   out.clipSpacePosition = calcPos * mvp;
   out.worldSpacePosition = (calcPos * tsUniforms.objectMat);
   out.modelViewPosition = (calcPos * commonUniforms.modelview).xyz;
   out.uv1 = (vec4<f32>(in.tex1.xy, 0.0,1.0) * tsUniforms.texMats[0]).xy;
   out.uv2 = (vec4<f32>(in.tex2.xy, 0.0,1.0) * tsUniforms.texMats[1]).xy;
   out.norm = worldNorm;
   out.camDir = vec4<f32>(normalize((vec4<f32>(0,1,0,0) * expandTo44(commonUniforms.invCameraView)).xyz), 0);
   out.fragControl = tsUniforms.miscState;
   
   out.color = commonUniforms.modulationColor * in.col;
   out.color = HandleVertLight(worldPos, worldNorm, out.camDir.xyz, out.color);
   out.color = out.color * vec4<f32>(1.0, 1.0, 1.0, tsUniforms.miscState.w);
   return out;
}

@fragment
fn fMarble(in: TSRasterizerData) -> @location(0) vec4<f32> {

   var materialColor : vec4<f32> = textureSample(texs0, samplers0, uvFromNormal(in.norm));

   var normalModel2 = normalWarp(in.norm);

   var cameraReflection: vec3<f32> = reflect(in.camDir.xyz, normalModel2);

   var reflectAmount : f32 = 1.0;

   var reflectionColor = textureSample(cubeTex, cubeSampler, cameraReflection.xzy);
   reflectAmount = invSigmoid(0.01 + 0.98 * materialColor.a);
   reflectAmount -= 0.7 * (2.0 * -dot(normalModel2, in.camDir.xyz) - 1.0);
   reflectAmount = sigmoid(reflectAmount);
   reflectAmount = 0.95 * reflectAmount;

   var calcColor : vec4<f32> = vec4<f32>(materialColor.rgb * reflectionColor.rgb, 1.0);

   return calcColor;
}