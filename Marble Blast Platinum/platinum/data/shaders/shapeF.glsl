//-----------------------------------------------------------------------------
// Copyright (c) 2020 Whirligig231
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

varying vec2 uv;
varying vec3 vert_position;
varying vec3 normal_vector;

uniform sampler2D textureSampler;
// uniform sampler2D normalSampler;
#if (QUALITY_LEVEL > 0)
// uniform sampler2D specularSampler;
#endif
uniform samplerCube skyboxSampler;

uniform vec3 camera_position;
uniform mat4 rot_from_torque_mat;
uniform mat4 rot_to_torque_mat;
uniform vec4 ambient_color;
uniform vec4 sun_color;
uniform vec3 sun_direction;

float tanh(float x) {
    return (exp(2.0 * x) - 1.0) / (exp(2.0 * x) + 1.0);
}

float sigmoid(float x) {
    return 0.5 + 0.5 * tanh(2.0 * x - 1.0);
}

float atanh(float x) {
    return 0.5 * log((1.0 + x) / (1.0 - x));
}

float invSigmoid(float x) {
    return 0.5 + 0.5 * atanh(2.0 * x - 1.0);
}

void main() {
    // Correct UV based on texture scale
    vec2 scaled_uv = uv;

    // Texture values
    vec4 material_color = texture2D(textureSampler, scaled_uv);

    gl_FragColor = vec4(material_color.rgb, 1);
    // gl_FragColor = vec4((1+normal_model)/2, 0);
}