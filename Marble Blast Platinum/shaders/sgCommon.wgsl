// This should just contain functions belonging to all shaders
// They should at most use 1 texture and commonUniforms

// Util funcs

fn HandleFogFrag(base: vec4<f32>,
                     fogTexCoord: vec2<f32>,
                     fogColor: vec4<f32>,
                     fogTex: texture_2d<f32>,
                     fogSampler: sampler) -> vec4<f32> {
   // GL_DECAL blending
   var fogSample : vec4<f32> = fogColor.a * textureSample(fogTex, fogSampler, fogTexCoord).rgba; // fog
   return vec4<f32>((fogSample.rgb * fogSample.a) + (base.rgb * (1.0f - fogSample.a)), base.a);
}

fn HandleLinearTexGen(objectCoord: vec3<f32>, texgenS: vec4<f32>, texgenT: vec4<f32>) -> vec2<f32> {
   var dotObjectCoord : vec4<f32> = vec4<f32>(objectCoord.xyz, 0.0);
   return vec2<f32>(dot(dotObjectCoord, texgenS), dot(dotObjectCoord, texgenT));
}

fn HandleSphereTexGen(modelView: mat4x4<f32>,     // camera * object
                          invCameraView: mat4x4<f32>, // inverse(camera)
                          objectCoord: vec3<f32>,
                          objectNormal: vec3<f32>) -> vec2<f32> {
   var modelViewInverse : mat4x4<f32> = invCameraView * modelView;
   var eyeVertex : vec3<f32> = normalize((vec4<f32>(objectCoord.xyz, 1.0) * modelView).xyz); // M * V
   var eyeNormal : vec3<f32> = normalize(((modelViewInverse) * vec4<f32>(objectNormal.xyz, 0.0)).xyz); // V * M
   var reflectionVector : vec3<f32> = eyeVertex - eyeNormal * 2.0 * dot(eyeVertex, eyeNormal);
   reflectionVector.z += 1.0;
   var m : f32 = 1.0 / (2.0 * sqrt(dot(reflectionVector, reflectionVector)));
   return vec2<f32>(reflectionVector.x * m + 0.5,
                 reflectionVector.y * m + 0.5);
}

// Vertex Shaders

@vertex
fn vFBGuiVert(in: GuiVert) -> RasterizerData {
   var out : RasterizerData;
 
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0);
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   out.clipSpacePosition = calcPos * mvp;
   out.uv1 = in.tex;
   out.uv2 = in.texe;
   out.color = in.col;
   out.norm = vec3<f32>(0,0,0);
   out.alpha_test = commonUniforms.miscControl.x;
   
   return out;
}

@vertex
fn vFBTSVert(in: TSVert) -> RasterizerData {
   var out : RasterizerData;
   
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0);
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   out.clipSpacePosition = calcPos * mvp;
   out.uv1 = in.tex1;
   out.uv2 = in.tex2;
   out.color = in.col;
   out.norm = in.norm.xyz;
   out.alpha_test = commonUniforms.miscControl.x;
   
   return out;
}

//
// Fallback Fragment Functions
//

@fragment
fn fFBFrag(in: RasterizerData) -> @location(0) vec4<f32> {
   return vec4<f32>(1.0f,0.0f,1.0f,1.0f);
}

//
// Generic Vert Functions
//

@vertex
fn vNoColorGuiVert(in: GuiVert) -> RasterizerData {
   var out : RasterizerData;
   
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0);
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   out.clipSpacePosition = calcPos * mvp;
   out.uv1 = in.tex;
   out.uv2 = in.tex;
   out.color = vec4<f32>(1,1,1,1);
   out.norm = vec3<f32>(0,0,0);
   
   return out;
}

@vertex
fn vModGuiVert(in: GuiVert) -> RasterizerData {
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0);
   
   var out : RasterizerData;
   
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   out.clipSpacePosition = calcPos * mvp;
   out.uv1 = in.tex;
   out.uv2 = in.tex;
   out.color = commonUniforms.modulationColor * in.col;
   out.norm = vec3<f32>(0,0,0);
   
   return out;
}

// Fragment shaders

@fragment
fn fGenericAddColorTexture(in: RasterizerData) -> @location(0) vec4<f32> {
   return vec4<f32>(in.color.rgb, in.color.a * textureSample(texs0, samplers0, in.uv1).a);
}

@fragment
fn fGenericAlphaStencil(in: RasterizerData) -> @location(0) vec4<f32> {
   var stencilSample : vec4<f32> = textureSample(texs0, samplers0, in.uv1);
   if (stencilSample.a < in.color.a) {
      discard;
   }
   return vec4<f32>(in.color.rgb, 1.0f);
}

@fragment
fn fGenericColor(in: RasterizerData) -> @location(0) vec4<f32> {
   return in.color;
}

@fragment
fn fGenericSampleAlpha(in: RasterizerData) -> @location(0) vec4<f32> {
   return textureSample(texs0, samplers0, in.uv1).aaaa;
}

@fragment
fn fGenericSample(in: RasterizerData) -> @location(0) vec4<f32> {
   return textureSample(texs0, samplers0, in.uv1).rgba;
}

@fragment
fn fGenericModColorTexture(in: RasterizerData) -> @location(0) vec4<f32> {
   return textureSample(texs0, samplers0, in.uv1).rgba * in.color;
}

@fragment
fn fGenericFontTexture(in: RasterizerData) -> @location(0) vec4<f32> {
   return vec4<f32>(1,1,1,textureSample(texs0, samplers0, in.uv1).r) * in.color; // NOTE: using red channel here
}

@fragment
fn fGenericBlendColorTexture(in: RasterizerData) -> @location(0) vec4<f32> {
   // This needs to use GL_BLEND equation i.e.
   // (CONSTANT * TEXTURE) + (PRIMARY * (1.0 - TEXTURE))
   // + normal GL_MODULATE for alpha
   //
   // CONSTANT=mod color, PRIMARY=mod color
   // so if mod=1 then:
   // (1.0*1) + (1.0*(1.0-1)) = 1.0
   // also:
   // (1.0*0.1) + (1.0*(1.0-0.1)) = 1.0
   // also:
   // (0.1*0.1) + (0.1*(1.0-0.1)) = 0.1
   var tex : vec4<f32> = textureSample(texs0, samplers0, in.uv1);
   var out : vec4<f32> = vec4<f32>((in.color.rgb * tex.rgb) + (in.color.rgb * (vec3<f32>(1.0f,1.0f,1.0f) - tex.rgb)), tex.a * in.color.a);
   return out;
}

@fragment
fn fGenericModColorNoAlphaTexture(in: RasterizerData) -> @location(0)vec4<f32> {
   return vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgb, in.color.a);
}

@fragment
fn fGenericSampleColor(in: RasterizerData) -> @location(0) vec4<f32> {
   return vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgb, 1.0);
}

@fragment
fn fShadow(in: RasterizerData) -> @location(0) vec4<f32> {
   return textureSample(texs0, samplers0, in.uv1).rrra * in.color;
}

@fragment
fn fDebugRed(in: RasterizerData) -> @location(0) vec4<f32> {
   return vec4<f32>(1,0,0,1);
}

// TSVert Vertex Shaders


// TSVert Fragment Shaders

@fragment
fn fSampleAlphaTest(in: RasterizerData) -> @location(0) vec4<f32> {
   var ret : vec4<f32> = vec4<f32>(in.color.rgba * textureSample(texs0, samplers0, in.uv1).rgba);
   simpleClip(ret.a - in.alpha_test);
   return ret;
}


// Terrain


@fragment
fn fTerrainDetailSquare(in: RasterizerData) -> @location(0) vec4<f32> {
   return textureSample(texs0, samplers0, in.uv1).rgba * in.color;
}


@fragment
fn fTerrainLightmapSquare(in: RasterizerData) -> @location(0) vec4<f32> {
   return vec4<f32>(textureSample(texs0, samplers0, in.uv1).rgba);
}




