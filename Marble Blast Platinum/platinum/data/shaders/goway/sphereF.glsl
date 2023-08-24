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
varying vec3 model_vert_position;

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

#define time 1500;

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

vec4 permute(vec4 x){return mod(((x*34.0)+1.0)*x, 289.0);}
vec4 taylorInvSqrt(vec4 r){return 1.79284291400159 - 0.85373472095314 * r;}
vec3 fade(vec3 t) {return t*t*t*(t*(t*6.0-15.0)+10.0);}

float cnoise(vec3 P){
  vec3 Pi0 = floor(P); // Integer part for indexing
  vec3 Pi1 = Pi0 + vec3(1.0); // Integer part + 1
  Pi0 = mod(Pi0, 289.0);
  Pi1 = mod(Pi1, 289.0);
  vec3 Pf0 = fract(P); // Fractional part for interpolation
  vec3 Pf1 = Pf0 - vec3(1.0); // Fractional part - 1.0
  vec4 ix = vec4(Pi0.x, Pi1.x, Pi0.x, Pi1.x);
  vec4 iy = vec4(Pi0.yy, Pi1.yy);
  vec4 iz0 = Pi0.zzzz;
  vec4 iz1 = Pi1.zzzz;

  vec4 ixy = permute(permute(ix) + iy);
  vec4 ixy0 = permute(ixy + iz0);
  vec4 ixy1 = permute(ixy + iz1);

  vec4 gx0 = ixy0 / 7.0;
  vec4 gy0 = fract(floor(gx0) / 7.0) - 0.5;
  gx0 = fract(gx0);
  vec4 gz0 = vec4(0.5) - abs(gx0) - abs(gy0);
  vec4 sz0 = step(gz0, vec4(0.0));
  gx0 -= sz0 * (step(0.0, gx0) - 0.5);
  gy0 -= sz0 * (step(0.0, gy0) - 0.5);

  vec4 gx1 = ixy1 / 7.0;
  vec4 gy1 = fract(floor(gx1) / 7.0) - 0.5;
  gx1 = fract(gx1);
  vec4 gz1 = vec4(0.5) - abs(gx1) - abs(gy1);
  vec4 sz1 = step(gz1, vec4(0.0));
  gx1 -= sz1 * (step(0.0, gx1) - 0.5);
  gy1 -= sz1 * (step(0.0, gy1) - 0.5);

  vec3 g000 = vec3(gx0.x,gy0.x,gz0.x);
  vec3 g100 = vec3(gx0.y,gy0.y,gz0.y);
  vec3 g010 = vec3(gx0.z,gy0.z,gz0.z);
  vec3 g110 = vec3(gx0.w,gy0.w,gz0.w);
  vec3 g001 = vec3(gx1.x,gy1.x,gz1.x);
  vec3 g101 = vec3(gx1.y,gy1.y,gz1.y);
  vec3 g011 = vec3(gx1.z,gy1.z,gz1.z);
  vec3 g111 = vec3(gx1.w,gy1.w,gz1.w);

  vec4 norm0 = taylorInvSqrt(vec4(dot(g000, g000), dot(g010, g010), dot(g100, g100), dot(g110, g110)));
  g000 *= norm0.x;
  g010 *= norm0.y;
  g100 *= norm0.z;
  g110 *= norm0.w;
  vec4 norm1 = taylorInvSqrt(vec4(dot(g001, g001), dot(g011, g011), dot(g101, g101), dot(g111, g111)));
  g001 *= norm1.x;
  g011 *= norm1.y;
  g101 *= norm1.z;
  g111 *= norm1.w;

  float n000 = dot(g000, Pf0);
  float n100 = dot(g100, vec3(Pf1.x, Pf0.yz));
  float n010 = dot(g010, vec3(Pf0.x, Pf1.y, Pf0.z));
  float n110 = dot(g110, vec3(Pf1.xy, Pf0.z));
  float n001 = dot(g001, vec3(Pf0.xy, Pf1.z));
  float n101 = dot(g101, vec3(Pf1.x, Pf0.y, Pf1.z));
  float n011 = dot(g011, vec3(Pf0.x, Pf1.yz));
  float n111 = dot(g111, Pf1);

  vec3 fade_xyz = fade(Pf0);
  vec4 n_z = mix(vec4(n000, n100, n010, n110), vec4(n001, n101, n011, n111), fade_xyz.z);
  vec2 n_yz = mix(n_z.xy, n_z.zw, fade_xyz.y);
  float n_xyz = mix(n_yz.x, n_yz.y, fade_xyz.x); 
  return 2.2 * n_xyz;
}

float safe_snoise(vec3 p)
{
  float f = abs(cnoise(p));
  return f;
}

float rand(vec2 co) {
    return fract(sin(dot(co, vec2(12.9898, 78.233))) * 43758.5453);
}

vec3 random_vector3_offset(float seed) {
    return vec3(100 + rand(vec2(seed, seed)) * 100, 100 + rand(vec2(seed, seed)) * 100, 100 + rand(vec2(seed, seed)) * 100);
}

float fractal_noise(vec3 p, float details, float roughness)
{
  float fscale = 1.0;
  float amp = 1.0;
  float maxamp = 0.0;
  float sum = 0.0;
  float octaves = clamp(details, 0.0, 16.0);
  int n = int(octaves);
  for (int i = 0; i <= n; i++) {
    float t = safe_snoise(fscale * p);
    sum += t * amp;
    maxamp += amp;
    amp *= clamp(roughness, 0.0, 1.0);
    fscale *= 2.0;
  }
  float rmd = octaves - floor(octaves);
  if (rmd != 0.0) {
    float t = safe_snoise(fscale * p);
    float sum2 = sum + t * amp;
    sum /= maxamp;
    sum2 /= maxamp + amp;
    return (1.0 - rmd) * sum + rmd * sum2;
  }
  else {
    return sum / maxamp;
  }
}

vec3 noise_texture(vec3 co, float detail, float roughness, float distortion)
{
  vec3 p = co;
  if (distortion != 0.0) {
    p += vec3(safe_snoise(p + random_vector3_offset(0.0)) * distortion,
                 safe_snoise(p + random_vector3_offset(1.0)) * distortion,
                 safe_snoise(p + random_vector3_offset(2.0)) * distortion);
  }

  float value = fractal_noise(p, detail, roughness);
  vec3 Color = vec3(value, fractal_noise(p + random_vector3_offset(3.0), detail, roughness), fractal_noise(p + random_vector3_offset(4.0), detail, roughness));
  return Color;
}

vec3 rgb2hsv(vec3 c)
{
    vec4 K = vec4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
    vec4 p = mix(vec4(c.bg, K.wz), vec4(c.gb, K.xy), step(c.b, c.g));
    vec4 q = mix(vec4(p.xyw, c.r), vec4(c.r, p.yzx), step(p.x, c.r));

    float d = q.x - min(q.w, q.y);
    float e = 1.0e-10;
    return vec3(abs(q.z + (q.w - q.y) / (6.0 * d + e)), d / (q.x + e), q.x);
}

vec3 rotateAngAxis(vec3 input, vec3 axis, float angle) {
    return cos(angle) * input + sin(angle) * (cross(axis, input)) + (1.0 - cos(angle)) * dot(axis, input) * axis;
}

vec3 gradientfunc(float input) {
    if (input <= 0.32) return mix(vec3(0, 1, 1), vec3(0, 0.022, 1), input);
    if (input > 0.32 && input <= 0.423) return mix(vec3(0, 0.022, 1), vec3(0.0078431, 0, 0.596078), input - 0.32);
    if (input > 0.423) return mix(vec3(0.0078431, 0, 0.596078), vec3(0, 0, 0), input - 0.423);
    return vec3(1.0, 0.0, 0.0);
}

void main() {
    // Correct UV based on texture scale
    vec2 scaled_uv = uv;

    float val1 = 1.520 + (model_vert_position.z * 1.520);

    vec3 rotVec = rotateAngAxis(model_vert_position, vec3(0, 0, 1), val1);
    rotVec.x *= 0.560;
    rotVec.y *= 0.560;
    rotVec.z *= 0.1;

    vec3 addVec = vec3(0, 0, float(time) / 6000);
    vec3 resultVec = addVec + rotVec;

    vec3 noiseVec = noise_texture(resultVec * 3, 2, 0.5, 0);

    vec3 hsvCol = rgb2hsv(noiseVec);

    vec3 returnColor = gradientfunc(hsvCol.x);

    // Texture values
    vec4 material_color = vec4(returnColor, 0.2); //texture2D(textureSampler, scaled_uv);

    // Normalize the light vector so we can dot it
    vec3 light_normal = normalize(-sun_direction);

    // Cosine of the angle from the light to the normal
    float cosTheta = clamp(dot(normal_vector, light_normal), 0, 1);

    // Sun color is multiplied by angle for bump mapping, then clamped to [0, 1] so we don't clip
    vec4 effectiveSun = sun_color * cosTheta;

    // Ambient color first
    effectiveSun += ambient_color;

    // Clamp sun so we don't clip
    effectiveSun = vec4(clamp(effectiveSun.r, 0, 1), clamp(effectiveSun.g, 0, 1),
                        clamp(effectiveSun.b, 0, 1), 1);

    // Worldspace normal taking normal mapping into account
    vec3 normal_model = normal_vector;  // normalize(reflect(-normal_vector, normal_color));
    // Direction from camera to vertex
    vec3 camera_direction = normalize(vert_position - camera_position);
    // Reflect the camera off the normal so we know where on the skysphere to show
    vec3 camera_reflection = reflect(camera_direction, normal_model);

    // Reflected coordinates onto the given skybox
    vec3 skyboxR = camera_reflection;
    // Get the color from the skybox
    vec4 reflectionColor = textureCube(skyboxSampler, skyboxR);
    // Apply the reflected skybox color
    float reflectAmount = invSigmoid(0.01 + 0.98 * material_color.a);
    reflectAmount -= 0.7 * (2.0 * -dot(normal_model, camera_direction) - 1.0);
    reflectAmount = sigmoid(reflectAmount);
    reflectAmount = 0.95 * reflectAmount;

    gl_FragColor =
        vec4(mix(material_color.rgb * effectiveSun.rgb, reflectionColor.rgb, reflectAmount), 1);
    // gl_FragColor = vec4((1+normal_model)/2, 0);
}