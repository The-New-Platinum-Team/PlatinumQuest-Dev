//-----------------------------------------------------------------------------
// Copyright (c) 2021 The Platinum Team
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
//-----------------------------------------------------------------------------

varying vec2 UV;
uniform sampler2D textureSampler;
uniform sampler2D depthSampler;
uniform sampler2D bloomDepthSampler;
uniform vec2 screenSize;
uniform bool compareDepth;
uniform int bloomQuality;
uniform float offsetMultiplier;
uniform bool horizontalDir;
uniform int passNum;

const float zNear = 0.01f;
const float zFar = 500.f;

// http://stackoverflow.com/a/6657284/214063
float linearize(float z_b) {
    float z_n = 2.0 * z_b - 1.0;
    float z_e = 2.0 * zNear * zFar / (zFar + zNear - z_n * (zFar - zNear));
    return z_e;
}

float roundN(float x, float y) {
    return floor(x / y + 0.5) * y;
}

vec4 illuminate(vec4 color) {
    return color * 3;
}

float S(float n) {
    return (n / 2) * (-4 - n - 1);
}

vec4 blur13(sampler2D texture, vec2 uv, vec2 resolution) {

    const int blurSize = 8;
    const float blurStep = 2.5;
    const float coeffs[4] = float[] (1, 7, 21, 35);
    float cosum = 16384;
    vec4 avgcolor = vec4(0.0, 0.0, 0.0, 0.0);
    for(int i = 0; i < blurSize; i++) {
        for(int j = 0; j < blurSize; j++) {
            vec2 offset = vec2(float(i * blurStep), float(j * blurStep));
            vec2 centre = vec2(blurSize * blurStep / 2, blurSize * blurStep / 2);
            vec4 pixdepth = (texture2D(depthSampler, (uv + offset - centre) / resolution));
            vec4 bloomdepth = (texture2D(bloomDepthSampler, (uv + offset - centre) / resolution));

            float pivotX = min(float(abs(float(i - 3))), float(abs(float(i - 4))));
            float pivotY = min(float(abs(float(j - 3))), float(abs(float(j - 4))));
            float coeff = (coeffs[int(3 - pivotX)]) * (coeffs[int(3 - pivotY)]);

            if(linearize(bloomdepth.z) - linearize(pixdepth.z) > 0.01) {
                continue;
            }

            vec4 illumColor = illuminate(texture2D(texture, (uv + offset - centre) / resolution)) * coeff;
            avgcolor += illumColor;
        }
    }
    avgcolor /= cosum;

    vec4 color = avgcolor;
    return color;
}

vec4 blur14(sampler2D image, vec2 uv, vec2 resolution, bool horizontal) {
    vec4 color = vec4(0.0);
    float weight[5] = float[] (0.227027, 0.1945946, 0.1216216, 0.054054, 0.016216);

    vec2 tex_offset = 5.0 / resolution; // gets size of single texel
    vec3 result = texture2D(image, uv).rgb * weight[0]; // current fragment's contribution
    if(horizontal)
    {
        for(int i = 1; i < 5; ++i)
        {
            result += texture2D(image, uv + vec2(tex_offset.x * i, 0.0)).rgb * weight[i];
            result += texture2D(image, uv - vec2(tex_offset.x * i, 0.0)).rgb * weight[i];
        }
    }
    else
    {
        for(int i = 1; i < 5; ++i)
        {
            result += texture2D(image, uv + vec2(0.0, tex_offset.y * i)).rgb * weight[i];
            result += texture2D(image, uv - vec2(0.0, tex_offset.y * i)).rgb * weight[i];
        }
    }
    return vec4(result * 1.4, texture2D(image, uv).a);
}

vec4 blurUltra(sampler2D image, vec2 uv, bool horizontal, vec2 resolution) {
    float kernel[4] = float[] (0.175, 0.275, 0.375, 0.475);
    float offset[4] = float[] (3.5, 2.5, 1.5, 0.5);

    vec2 tex_offset = 5.0 / resolution; // gets size of single texel

    vec4 accumColor = vec4(0);
    if (horizontal) {
        accumColor += texture2D(image, uv + vec2(offset[0] * offsetMultiplier * tex_offset.x, 0)) * kernel[0];
        accumColor += texture2D(image, uv + vec2(offset[1] * offsetMultiplier * tex_offset.x, 0)) * kernel[1];
        accumColor += texture2D(image, uv + vec2(offset[2] * offsetMultiplier * tex_offset.x, 0)) * kernel[2];
        accumColor += texture2D(image, uv + vec2(offset[3] * offsetMultiplier * tex_offset.x, 0)) * kernel[3];
    } else {
        accumColor += texture2D(image, uv + vec2(0, offset[0] * offsetMultiplier * tex_offset.y)) * kernel[0];
        accumColor += texture2D(image, uv + vec2(0, offset[1] * offsetMultiplier * tex_offset.y)) * kernel[1];
        accumColor += texture2D(image, uv + vec2(0, offset[2] * offsetMultiplier * tex_offset.y)) * kernel[2];
        accumColor += texture2D(image, uv + vec2(0, offset[3] * offsetMultiplier * tex_offset.y)) * kernel[3];
    }

    vec4 outColor = accumColor / 1.25;
    outColor.a = outColor.x + outColor.y + outColor.z / 3;
    outColor.xyz *= 1.25;
    return outColor;
}

void main() {

    if (passNum == 5 && bloomQuality == 3) {
        gl_FragColor = texture2D(textureSampler, UV);
        return;
    }

    vec2 pixel = (UV * screenSize);

    vec4 color;
    if (bloomQuality == 2)
        color = (blur14(textureSampler, pixel / screenSize, screenSize, true) + blur14(textureSampler, pixel / screenSize, screenSize, false)) / 2;
    else if (bloomQuality == 3) {
        color = (blurUltra(textureSampler, pixel / screenSize, true, screenSize) + blurUltra(textureSampler, pixel / screenSize, false, screenSize)) / 2;
    } else 
        color = (texture2D(textureSampler, pixel / screenSize));

    vec4 lumColor = vec4(0, 0, 0, 0);
    if (bloomQuality == 1)
        lumColor = blur13(textureSampler, pixel, screenSize);

    vec4 pixdepth = (texture2D(depthSampler, pixel / screenSize));
    vec4 bloomdepth = (texture2D(bloomDepthSampler, pixel / screenSize));
    if (compareDepth) {
        if(bloomdepth.z - pixdepth.z > 0) {
            color = vec4(0, 0, 0, 0);
        }
    }

    // Invert colors
    gl_FragColor = color + lumColor;
}