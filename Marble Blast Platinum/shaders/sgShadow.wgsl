// Render shadow using cascade shadows

@group(0) @binding(2)
var shadowDepthMap: texture_depth_2d_array;
@group(0) @binding(3)
var shadowDepthSampler: sampler;

fn SampleCascade(cascade: i32, worldPos: vec3<f32>, normal: vec3<f32>) -> f32 {
    var nrm = normalize(normal);
    var ndl = clamp(dot(nrm, -commonUniforms.shadowDir.xyz), 0.0, 1.0);

    var texel = commonUniforms.shadowParams.y; // 1 / shadow map size
    var info = commonUniforms.shadowCascadeInfo[cascade];
    var texelWorld = info.x;
    var depthRange = 1.0 / max(info.y, 1e-8);

    var slope = sqrt(max(0.0, 1.0 - ndl * ndl)) / max(ndl, 0.2);
    var bias = texelWorld * (1.0 + 2.0 * slope) / depthRange;
    var normalBias = max(commonUniforms.shadowParams.w, texelWorld * 1.25);
    var biasedWorld = worldPos + nrm * normalBias;

    var base = vec4<f32>(biasedWorld, 1.0) * commonUniforms.shadowCascadeViewProj;
    var cascadeScale = commonUniforms.shadowCascadeScale[cascade];
    var cascadeOffset = commonUniforms.shadowCascadeOffset[cascade];
    var shadowPos = base.xyz * cascadeScale.xyz + cascadeOffset.xyz;

    var uv = shadowPos.xy;

    // Cascade doesn't cover this point
    if uv.x < 0.0 || uv.x > 1.0 || uv.y < 0.0 || uv.y > 1.0 || shadowPos.z > 1.0 {
        return -1.0;
    }

    var visibility = 0.0;

    if cascade < 2 {
        var disc: array<vec2<f32>, 12> = array<vec2<f32>, 12>(
            vec2<f32>(0.2041, 0.0000),
            vec2<f32>(-0.2607, 0.2388),
            vec2<f32>(0.0399, -0.4547),
            vec2<f32>(0.3286, 0.4286),
            vec2<f32>(-0.6030, -0.1067),
            vec2<f32>(0.5712, -0.3634),
            vec2<f32>(-0.1911, 0.7107),
            vec2<f32>(-0.3644, -0.7016),
            vec2<f32>(0.7906, 0.2887),
            vec2<f32>(-0.8224, 0.3395),
            vec2<f32>(0.3965, -0.8472),
            vec2<f32>(0.2930, 0.9341)
        );

        var radius = texel * 3.0;

        // Static per-pixel jitter
        var rnd = fract(sin(dot(worldPos.xz, vec2<f32>(12.9898, 78.233))) * 43758.5453);
        var rnd2 = fract(sin(dot(worldPos.yz + vec2<f32>(19.19, 7.73), vec2<f32>(39.346, 11.135))) * 24634.6345);
        var ang = rnd * 6.2831853;
        var cs = cos(ang);
        var sn = sin(ang);
        var centerJitter = (vec2<f32>(rnd, rnd2) - 0.5) * texel;

        var ramp = max(texelWorld * 1.5 / depthRange, 1e-7);

        for (var i: i32 = 0; i < 12; i = i + 1) {
            var p = disc[i];
            var rotated = vec2<f32>(p.x * cs - p.y * sn, p.x * sn + p.y * cs) * radius;
            var offset = centerJitter + rotated;
            var sampleDepth = textureSampleLevel(shadowDepthMap, shadowDepthSampler, uv + offset, cascade, 0i);
            var diff = shadowPos.z - bias - sampleDepth;
            visibility = visibility + (1.0 - clamp(diff / ramp, 0.0, 1.0));
        }

        visibility = visibility / 12.0;
    } else {
        // 3x3 rotated PCF for the far cascades.
        var rnd = fract(sin(dot(worldPos.xz, vec2<f32>(12.9898, 78.233))) * 43758.5453);
        var ang = rnd * 6.2831853;
        var cs = cos(ang);
        var sn = sin(ang);

        for (var y: i32 = -1; y <= 1; y = y + 1) {
            for (var x: i32 = -1; x <= 1; x = x + 1) {
                var p = vec2<f32>(f32(x), f32(y));
                var rotated = vec2<f32>(p.x * cs - p.y * sn, p.x * sn + p.y * cs);
                var offset = rotated * texel;
                var sampleDepth = textureSampleLevel(shadowDepthMap, shadowDepthSampler, uv + offset, cascade, 0i);
                visibility = visibility + select(0.0, 1.0, shadowPos.z - bias <= sampleDepth);
            }
        }
        visibility = visibility / 9.0;
    }

    // Only the last cascade has a visible outer border.
    if cascade == 3 {
        var edge = min(min(uv.x, 1.0 - uv.x), min(uv.y, 1.0 - uv.y));
        visibility = visibility * smoothstep(0.0, 0.05, edge);
    }

    return visibility;
}

fn SampleShadow(worldPos: vec3<f32>, normal: vec3<f32>) -> f32 {
    if commonUniforms.shadowParams.x < 0.5 {
        return 1.0;
    }

    var camForward = normalize((vec4<f32>(0, 1, 0, 0) * expandTo44(commonUniforms.invCameraView)).xyz);
    var viewZ = dot(worldPos - commonUniforms.shadowEye.xyz, camForward);
    if viewZ <= 0.0 || viewZ >= commonUniforms.shadowSplits.w {
        return 1.0;
    }

    var cascade: i32 = 0;
    if viewZ > commonUniforms.shadowSplits.x { cascade = 1; }
    if viewZ > commonUniforms.shadowSplits.y { cascade = 2; }
    if viewZ > commonUniforms.shadowSplits.z { cascade = 3; }

    var visibility = -1.0;
    for (var c: i32 = cascade; c < 4; c = c + 1) {
        var v = SampleCascade(c, worldPos, normal);
        if v >= 0.0 {
            visibility = v;
            break;
        }
    }

    if visibility < 0.0 {
        return 1.0;
    }

    // Cross-fade
    var split = commonUniforms.shadowSplits.x;
    if cascade == 1 { split = commonUniforms.shadowSplits.y; }
    if cascade == 2 { split = commonUniforms.shadowSplits.z; }
    if cascade == 3 { split = commonUniforms.shadowSplits.w; }

    if cascade < 3 {
        var band = split * 0.1;
        if viewZ > split - band {
            var t = clamp((viewZ - (split - band)) / band, 0.0, 1.0);
            var nextVisibility = SampleCascade(cascade + 1, worldPos, normal);
            if nextVisibility >= 0.0 {
                visibility = mix(visibility, nextVisibility, t);
            }
        }
    }

    return visibility;
}

fn ApplyShadow(color: vec4<f32>, worldPos: vec3<f32>, normal: vec3<f32>) -> vec4<f32> {
    var visibility = SampleShadow(worldPos, normal);
    var shadowed = 1.0 - visibility;
    return vec4<f32>(color.rgb * mix(1.0, commonUniforms.shadowActive.y, shadowed), color.a);
}
