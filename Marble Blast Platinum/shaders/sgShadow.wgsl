// Render shadow using cascade shadows

@group(0) @binding(2)
var shadowDepthMap: texture_depth_2d_array;
@group(0) @binding(3)
var shadowDepthSampler: sampler;

fn SampleCascade(cascade: i32, worldPos: vec3<f32>, normal: vec3<f32>) -> f32 {
   var cascadeView = commonUniforms.shadowMatrix[cascade];
   var cascadeProj = commonUniforms.shadowProj[cascade];

   var n = normalize(normal);
   var ndl = clamp(dot(n, -commonUniforms.shadowDir.xyz), 0.0, 1.0);

   var texel = commonUniforms.shadowParams.y; // 1 / shadow map size
   var proj00 = abs(cascadeProj[0][0]);
   var texelWorld = select(1.0, 2.0 * texel / proj00, proj00 > 1e-8);
   var proj22 = abs(cascadeProj[2][2]);
   var depthRange = select(1.0, 1.0 / proj22, proj22 > 1e-8);

   var slope = sqrt(max(0.0, 1.0 - ndl * ndl)) / max(ndl, 0.2);
   var bias = texelWorld * (1.0 + 2.0 * slope) / depthRange;
   var normalBias = max(commonUniforms.shadowParams.w, texelWorld * 1.25);
   var biasedWorld = worldPos + n * normalBias;

   var lightMvp = expandTo44(cascadeView) * cascadeProj;
   var lightClip = vec4<f32>(biasedWorld, 1.0) * lightMvp;
   if (lightClip.w <= 0.0) {
      return 1.0;
   }

   var lightSpace = lightClip.xyz / lightClip.w;
   var uv = vec2<f32>(lightSpace.x * 0.5 + 0.5, 0.5 - lightSpace.y * 0.5);

   // Cascade doesn't cover this point
   if (uv.x < 0.0 || uv.x > 1.0 || uv.y < 0.0 || uv.y > 1.0 || lightSpace.z > 1.0) {
      return -1.0;
   }


   // Rotate the PCF kernel per surface point to smoothen the shadow, weird trick.
   var rnd = fract(sin(dot(worldPos.xz, vec2<f32>(12.9898, 78.233))) * 43758.5453);
   var ang = rnd * 6.2831853;
   var cs = cos(ang);
   var sn = sin(ang);

   var visibility = 0.0;
   for (var y: i32 = -2; y <= 2; y = y + 1) {
      for (var x: i32 = -2; x <= 2; x = x + 1) {
         var p = vec2<f32>(f32(x), f32(y));
         var rotated = vec2<f32>(p.x * cs - p.y * sn, p.x * sn + p.y * cs);
         var offset = rotated * texel;
         var sampleDepth = textureSampleLevel(shadowDepthMap, shadowDepthSampler, uv + offset, cascade, 0i);
         visibility = visibility + select(0.0, 1.0, lightSpace.z - bias <= sampleDepth);
      }
   }

   visibility = visibility / 25.0;

   // Only the last cascade has a visible outer border.
   if (cascade == 3) {
      var edge = min(min(uv.x, 1.0 - uv.x), min(uv.y, 1.0 - uv.y));
      visibility = visibility * smoothstep(0.0, 0.05, edge);
   }

   return visibility;
}

fn SampleShadow(worldPos: vec3<f32>, normal: vec3<f32>) -> f32 {
   if (commonUniforms.shadowParams.x < 0.5) {
      return 1.0;
   }

   var dist = length(worldPos - commonUniforms.shadowEye.xyz);
   if (dist >= commonUniforms.shadowSplits.w) {
      return 1.0;
   }

   var cascade: i32 = 0;
   if (dist > commonUniforms.shadowSplits.x) { cascade = 1; }
   if (dist > commonUniforms.shadowSplits.y) { cascade = 2; }
   if (dist > commonUniforms.shadowSplits.z) { cascade = 3; }

   var visibility = -1.0;
   for (var c: i32 = cascade; c < 4; c = c + 1) {
      var v = SampleCascade(c, worldPos, normal);
      if (v >= 0.0) {
         visibility = v;
         break;
      }
   }

   if (visibility < 0.0) {
      return 1.0;
   }

   // Cross-fade
   var split = commonUniforms.shadowSplits.x;
   if (cascade == 1) { split = commonUniforms.shadowSplits.y; }
   if (cascade == 2) { split = commonUniforms.shadowSplits.z; }
   if (cascade == 3) { split = commonUniforms.shadowSplits.w; }

   if (cascade < 3) {
      var band = split * 0.1;
      if (dist > split - band) {
         var t = clamp((dist - (split - band)) / band, 0.0, 1.0);
         var nextVisibility = SampleCascade(cascade + 1, worldPos, normal);
         if (nextVisibility >= 0.0) {
            visibility = mix(visibility, nextVisibility, t);
         }
      }
   }

   return visibility;
}

fn ApplyShadow(color: vec4<f32>, worldPos: vec3<f32>, normal: vec3<f32>) -> vec4<f32> {
   var visibility = SampleShadow(worldPos, normal);
   var shadowed = 1.0 - visibility;
   return vec4<f32>(color.rgb * mix(1.0, 0.666, shadowed), color.a);
}
