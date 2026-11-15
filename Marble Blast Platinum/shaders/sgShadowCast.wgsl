#include "stStructs.wgsl"

// For casting shadows

@group(0) @binding(0)
var<uniform> commonUniforms: CommonUniformSet;
@group(0) @binding(1)
var<uniform> tsUniforms: TSUniformSet;

struct ShadowVertOut {
   @builtin(position) position: vec4<f32>,
   @location(0) depth: f32,
};

struct ShadowFragOut {
   @builtin(frag_depth) depth: f32,
};

fn ShadowWorldPos(pos: vec3<f32>) -> ShadowVertOut {
   var world = vec4<f32>(pos, 1.0) * tsUniforms.objectMat;
   var cascade = i32(commonUniforms.shadowActive.x);

   var base = vec4<f32>(world.xyz, 1.0) * commonUniforms.shadowCascadeViewProj;
   var cascadeScale = commonUniforms.shadowCascadeScale[cascade];
   var cascadeOffset = commonUniforms.shadowCascadeOffset[cascade];
   var shadowPos = base.xyz * cascadeScale.xyz + cascadeOffset.xyz;

   var out: ShadowVertOut;
   // convert back to clip space.
   out.position = vec4<f32>(shadowPos.x * 2.0 - 1.0, 1.0 - shadowPos.y * 2.0, shadowPos.z, 1.0);
   out.depth = shadowPos.z;
   return out;
}

@vertex
fn vShadowTS(in: TSVert) -> ShadowVertOut {
   return ShadowWorldPos(in.pos);
}

@vertex
fn vShadowITR(in: ITRVert) -> ShadowVertOut {
   return ShadowWorldPos(in.pos);
}

@vertex
fn vShadowITRPQ(in: ITRPQVert) -> ShadowVertOut {
   return ShadowWorldPos(in.pos);
}

@fragment
fn fShadow(in: ShadowVertOut) -> ShadowFragOut {
   var out: ShadowFragOut;
   out.depth = clamp(in.depth, 0.0, 1.0);
   return out;
}
