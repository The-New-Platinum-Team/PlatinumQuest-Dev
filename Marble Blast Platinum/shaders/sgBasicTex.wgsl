#include "stStructs.wgsl"
#include "sgCommon.wgsl"

// UG_COMMON
@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
// TG_TEX
@group(1) @binding(0)
var texs0: texture_2d<f32>;
@group(1) @binding(1)
var samplers0: sampler;