// Vert types

struct GuiVert {
   @location(0) pos: vec3<f32>,
   @location(1) tex: vec2<f32>,
   @location(2) texe: vec2<f32>,
   @location(3) col: vec4<f32>,
   @location(4) pad1: vec4<u32>,
   @location(5) pad2: vec4<u32>
};

struct TSVert {
  @location(0) pos:  vec3<f32>,
  @location(1) norm: vec4<f32>,
  @location(2) col:  vec4<f32>,
  @location(3) tex1: vec2<f32>,
  @location(4) tex2: vec2<f32>
};

struct ITRVert {
   @location(0) pos: vec3<f32>,
   @location(1) norm: vec3<f32>,
   @location(2) tex: vec2<f32>,
   @location(3) col: vec4<f32>,
   @location(4) pad1: vec4<u32>,
}

struct ITRPQVert {
   @location(0) pos: vec3<f32>,
   @location(1) norm: vec3<f32>,
   @location(2) tex: vec2<f32>,
   @location(3) tangent: vec3<f32>,
   @location(4) bitangent: vec3<f32>,
}

// Uniform buffers

struct CommonUniformSet {
   projection: mat4x4<f32>,
   modelview: mat3x4<f32>,
   invCameraView: mat3x4<f32>,
   modulationColor: vec4<f32>, // global modulation
   coreScale: vec4<f32>, // x y z lineSize/pointSize
   miscControl: vec4<f32>,
   clipPlane: vec4<f32>,
   depthBias: vec4<f32>, // (bias, slope, clamp, enabled)
   miscControl2: vec4<f32> // alphaTest, X, X, X
}

struct LightUnit {
   diffuse: vec4<f32>,
   ambient: vec4<f32>,
   specular: vec4<f32>,
   
   position: vec4<f32>,
   spotDirectionCutoff: vec4<f32>, // always 180
   attenEnabled: vec4<f32> // const, lin, quad, enables
}

struct FluidUniformSet {
   squareDepthPoints: vec4<f32>, // Square*, DepthTexel*
   tessDistortParams: vec4<f32>, // TessellationSurface, TessellationShore, DistortMagnitude, DistortGridScale
   timeParams: vec4<f32>,        // Seconds / DistortTime, Seconds
   viewParams: vec4<f32>,        // Eye.xyz, EnvMapIntensity
   viewParams2: vec4<f32>,       // Opacity, ShowA, ShowB
   lightDir: vec4<f32>,          // Dir, SpecPower
   specColor: vec4<f32>         // Dir, 0
}

const MAX_LIGHTS: u32 = 7;

// NOTE: mat3x4<f32> in metal = 3 columns, 4 rows
struct TSUniformSet {
   // Fog
   fogState: vec4<f32>,
   fogColor: vec4<f32>,
   
   // Misc
   miscState: vec4<f32>,
   objectMat: mat3x4<f32>,
   invObjectMat: mat3x4<f32>,
   
   // Texture matrices (80 bytes)
   texMats : array<mat3x4<f32>, 2>,
   texPlanes : array<vec4<f32>, 2>,
   
   // Lighting ambient
   lightAmbient: vec4<f32>,

   // Lighting
   lights : array<LightUnit, MAX_LIGHTS>
}

struct TerrainBlendUniformSet {
   blendAlphas: array<vec4<f32>, 2>
}

// Fragment input structs

struct RasterizerData {
   @builtin(position)  clipSpacePosition: vec4<f32>,
   @location(0) color: vec4<f32>,
   @location(1) uv1: vec2<f32>,
   @location(2) uv2: vec2<f32>,
   @location(3) norm: vec3<f32>,
   @location(4) alpha_test : f32
}

struct TSRasterizerData {
   @builtin(position) clipSpacePosition: vec4<f32>,
   @location(0) color: vec4<f32>,
   @location(1) uv1: vec2<f32>,
   @location(2) uv2: vec2<f32>,
   @location(3) worldSpacePosition: vec3<f32>,
   @location(4) modelViewPosition: vec3<f32>,
   @location(5) norm: vec3<f32>,
   @location(6) envTexCoord: vec2<f32>,
   @location(7) fogTexCoord: vec2<f32>,
   @location(8) @interpolate(flat) camDir: vec4<f32>,
   @location(9) @interpolate(flat) fogColor: vec4<f32>,
   @location(10) @interpolate(flat) fragControl: vec4<f32>,

   @location(11) alpha_test : f32
}

struct PQRasterizerData {
   @builtin(position) clipSpacePosition: vec4<f32>,
   @location(0) uv: vec2<f32>,
   @location(1) worldSpacePosition: vec3<f32>,
   @location(2) modelViewPosition: vec3<f32>,
   @location(3) @interpolate(linear) norm: vec3<f32>,
   @location(4) camDir: vec4<f32>,
   @location(5) lightDir: vec3<f32>,
   @location(6) camPos: vec3<f32>,
   @location(7) tangentPos: vec3<f32>
}

struct ISmoothRasterizerData {
   @builtin(position) clipSpacePosition: vec4<f32>,
   @location(0) color: vec4<f32>,
   @location(1) uv1: vec2<f32>,
   @location(2) uv2: vec2<f32>,
   @location(3) worldSpacePosition: vec3<f32>,
   @location(4) modelViewPosition: vec3<f32>,
   @location(5) norm: vec3<f32>
}


// Util funcs

fn simpleClip(value : f32) {
   if (value <= 0) {
      discard;
      }
}

fn expandTo44(/*const*/ mat: mat3x4<f32>) -> mat4x4<f32> {
   return mat4x4<f32>(mat[0], mat[1], mat[2], vec4<f32>(0,0,0,1));
}
