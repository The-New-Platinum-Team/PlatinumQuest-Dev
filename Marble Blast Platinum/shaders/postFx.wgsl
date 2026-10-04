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

@vertex
fn vPostFx(in: GuiVert) -> RasterizerData {
    var calcPos: vec4<f32> = vec4<f32>(in.pos.xyz, 1.0);

    var out: RasterizerData;

    var mv: mat4x4<f32> = expandTo44(commonUniforms.modelview);
    var mvp: mat4x4<f32> = mv * commonUniforms.projection;
    out.clipSpacePosition = calcPos * mvp;
    out.uv1 = in.tex;
    out.uv2 = in.tex;
    out.color = commonUniforms.modulationColor * in.col;
    out.norm = vec3<f32>(0, 0, 0);

    return out;
}

fn fxaaLuma(color: vec3<f32>) -> f32 {
    return dot(color, vec3<f32>(0.299, 0.587, 0.114));
}

@fragment
fn fPostFx(in: RasterizerData) -> @location(0) vec4<f32> {
    let size = vec2<f32>(textureDimensions(texs0));
    let texel = 1.0 / size;
    let uv = in.uv1;

    let center = textureSample(texs0, samplers0, uv);
    let nw = textureSample(texs0, samplers0, uv + vec2<f32>(-1.0, -1.0) * texel);
    let ne = textureSample(texs0, samplers0, uv + vec2<f32>(1.0, -1.0) * texel);
    let sw = textureSample(texs0, samplers0, uv + vec2<f32>(-1.0, 1.0) * texel);
    let se = textureSample(texs0, samplers0, uv + vec2<f32>(1.0, 1.0) * texel);

    let lumaM = fxaaLuma(center.rgb);
    let lumaNW = fxaaLuma(nw.rgb);
    let lumaNE = fxaaLuma(ne.rgb);
    let lumaSW = fxaaLuma(sw.rgb);
    let lumaSE = fxaaLuma(se.rgb);

    let lumaMin = min(lumaM, min(min(lumaNW, lumaNE), min(lumaSW, lumaSE)));
    let lumaMax = max(lumaM, max(max(lumaNW, lumaNE), max(lumaSW, lumaSE)));

    let dir = vec2<f32>(
        -((lumaNW + lumaNE) - (lumaSW + lumaSE)),
        (lumaNW + lumaSW) - (lumaNE + lumaSE)
    );

    let reduce = max(
        (lumaNW + lumaNE + lumaSW + lumaSE) * (0.25 * 0.125),
        1.0 / 128.0
    );
    let reciprocalMin = 1.0 / (min(abs(dir.x), abs(dir.y)) + reduce);
    let direction = clamp(dir * reciprocalMin, vec2<f32>(-8.0), vec2<f32>(8.0)) * texel;

    // All sampling happens in uniform control flow (no branch / early return)
    let sampleA = 0.5 * (textureSample(texs0, samplers0, uv + direction * (1.0 / 3.0 - 0.5)) +
        textureSample(texs0, samplers0, uv + direction * (2.0 / 3.0 - 0.5)));
    let sampleB = sampleA * 0.5 + 0.25 * (textureSample(texs0, samplers0, uv + direction * -0.5) +
        textureSample(texs0, samplers0, uv + direction * 0.5));

    let lumaB = fxaaLuma(sampleB.rgb);
    // Standard FXAA: if sampleB leaves the local luma range, fall back to sampleA
    let blurred = select(sampleB, sampleA, lumaB < lumaMin || lumaB > lumaMax);

    // Flat region: skip AA and keep the original pixel
    let isFlat = lumaMax - lumaMin < max(0.0312, lumaMax * 0.125);
    return select(blurred, center, isFlat) * in.color;
}