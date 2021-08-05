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
uniform vec2 screenSize;

float roundN(float x, float y) {
    return floor(x / y + 0.5) * y;
}

// Hardcoded through automation
int checkGlowColor(vec3 color) {
    if(abs(color.b - 0.13) < 0.01) {
        if(abs(color.g - 0.23) < 0.01) {
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.24) < 0.01) {
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.89) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.13) < 0.01) {
        if(abs(color.g - 0.24) < 0.01) {
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.69) < 0.01) {
        if(abs(color.g - 0.40) < 0.01) {
            if(abs(color.r - 0.10) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.09) < 0.01) {
        if(abs(color.g - 0.20) < 0.01) {
            if(abs(color.r - 0.83) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.83) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.09) < 0.01) {
        if(abs(color.g - 0.20) < 0.01) {
            if(abs(color.r - 0.82) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.82) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.83) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.83) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.20) < 0.01) {
            if(abs(color.r - 0.83) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.21) < 0.01) {
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.10) < 0.01) {
        if(abs(color.g - 0.20) < 0.01) {
            if(abs(color.r - 0.82) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.83) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.20) < 0.01) {
            if(abs(color.r - 0.83) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.21) < 0.01) {
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.21) < 0.01) {
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.10) < 0.01) {
        if(abs(color.g - 0.20) < 0.01) {
            if(abs(color.r - 0.82) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.20) < 0.01) {
            if(abs(color.r - 0.82) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.83) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.83) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.21) < 0.01) {
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.21) < 0.01) {
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.84) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.11) < 0.01) {
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.21) < 0.01) {
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.85) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.11) < 0.01) {
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.11) < 0.01) {
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.23) < 0.01) {
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.12) < 0.01) {
        if(abs(color.g - 0.22) < 0.01) {
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.23) < 0.01) {
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.23) < 0.01) {
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
    }
    if(abs(color.b - 0.12) < 0.01) {
        if(abs(color.g - 0.23) < 0.01) {
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
        }
        if(abs(color.g - 0.23) < 0.01) {
            if(abs(color.r - 0.88) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.86) < 0.01) {
                return 1;
            }
            if(abs(color.r - 0.87) < 0.01) {
                return 1;
            }
        }
    }
    return 0;
}

vec4 illuminate(vec4 color) {
    if(checkGlowColor(color.rgb) == 1) {
        return color * 6;
    }
    return vec4(0, 0, 0, 0);
}

vec4 blur13(sampler2D texture, vec2 uv, vec2 resolution) {

    const int blurSize = 16;
    const float blurStep = 1;
    int counter = 0;
    vec4 avgcolor = vec4(0.0, 0.0, 0.0, 0.0);
    for(int i = 0; i < blurSize; i++) {
        for(int j = 0; j < blurSize; j++) {
            vec2 offset = vec2(float(i * blurStep), float(j * blurStep));
            vec2 centre = vec2(blurSize * blurStep / 2, blurSize * blurStep / 2);
            vec4 illumColor = illuminate(texture2D(texture, (uv + offset - centre) / resolution));
            avgcolor += illumColor;
            counter++;
        }
    }
    avgcolor /= counter;

    vec4 color = avgcolor;
    return color;
}

void main() {
    vec2 pixel = (UV * screenSize);

    vec4 color = (texture2D(textureSampler, pixel / screenSize));

    vec4 lumColor = blur13(textureSampler, pixel, screenSize);

    // Invert colors
    gl_FragColor = color + lumColor;
}