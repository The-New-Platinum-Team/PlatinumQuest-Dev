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
    const float blurStep = 1;
    float cosum = 0;
    vec4 avgcolor = vec4(0.0, 0.0, 0.0, 0.0);
    for(int i = 0; i < blurSize; i++) {
        for(int j = 0; j < blurSize; j++) {
            vec2 offset = vec2(float(i * blurStep), float(j * blurStep));
            vec2 centre = vec2(blurSize * blurStep / 2, blurSize * blurStep / 2);
            vec4 pixdepth = (texture2D(depthSampler, (uv + offset - centre) / resolution));
            vec4 bloomdepth = (texture2D(bloomDepthSampler, (uv + offset - centre) / resolution));

            float pivotX = min(float(abs(float(i - 3))), float(abs(float(i - 4))));
            float pivotY = min(float(abs(float(j - 3))), float(abs(float(j - 4))));
            float coeff = (10 - S(pivotX)) * (10 - S(pivotY));

            if(pixdepth.z < bloomdepth.z) {
                cosum += coeff;
                continue;
            }

            vec4 illumColor = illuminate(texture2D(texture, (uv + offset - centre) / resolution)) * coeff;
            avgcolor += illumColor;
            cosum += coeff;
        }
    }
    avgcolor /= cosum;

    vec4 color = avgcolor;
    return color;
}

void main() {
    vec2 pixel = (UV * screenSize);

    vec4 color = (texture2D(textureSampler, pixel / screenSize));

    vec4 lumColor = blur13(textureSampler, pixel, screenSize);

    vec4 pixdepth = (texture2D(depthSampler, pixel / screenSize));
    vec4 bloomdepth = (texture2D(bloomDepthSampler, pixel / screenSize));
    if(pixdepth.z < bloomdepth.z) {
        color = vec4(0, 0, 0, 0);
    }

    // Invert colors
    gl_FragColor = color + lumColor;
}