// This should just contain functions belonging to all TS shaders
// They should at most use 1 texture and commonUniforms and tsUniforms

/*
 Note on fog impl:
 
 Fog uses a 2d texture. Verts in the shape should get assigned the following coords:
 
 {
    x = (VisibleDistanceMod - Dist) * InvVisibleDistance;
    y = (z - HeightOffset) * InvHeightRange;
 }
 
 Parameters for this are encoded into fogState, specifically:
 
 fogState.x = VisibleDistanceMod
 fogState.y = InvVisibleDistanceMod
 fogState.y = HeightOffset
 fogState.z = InvHeightRange
 
 In addition:
 
 fogColor.a = FogEnabled (if > 0)
 
 
 Note on texCoords:
 
 Texgen is not used. Texture matrix is applied after.
 
 */

fn CalcFogCoord(
               worldCoord : vec3<f32>,
               camPos : vec3<f32>,
               fogState : vec4<f32>) -> vec2<f32> {
   /* const */ var dist : f32 = length(camPos.xyz - worldCoord);
   
   /* const */ var VisibleDistanceMod : f32 = fogState.x;
   /* const */ var InvVisibleDistance : f32 = fogState.y;
   /* const */ var HeightOffset : f32 = fogState.z;
   /* const */ var InvHeightRange : f32 = fogState.w;
   
   var z : f32 = worldCoord.z;//(worldCoord.z + camPos.z);
   return vec2<f32>((VisibleDistanceMod - dist) * InvVisibleDistance,
                      (z - HeightOffset) * InvHeightRange);
}


/*
 Note on light impl:
 
 Functions mostly like OpenGL with unused stuff removed.
 
 Mostly based on math from https://www.glprogramming.com/red/chapter05.html
 */


fn calcSingleLight(camDir: vec3<f32>, vpos: vec3<f32>, vnormal: vec3<f32>,
               lightUnit: LightUnit) -> vec3<f32> {
   // Handle basic positional vs directional light
   var lightDir : vec3<f32>;
   var attenFactor : f32 = 1.0f;
   
   if (lightUnit.position.w != 0.0f)
   {
      // Point light
      lightDir = lightUnit.position.xyz - vpos;
      var lightVertexDist : f32 = length(lightDir);
      lightDir = normalize(lightDir);
      var quadAtten : f32 = lightUnit.attenEnabled.z * lightVertexDist;
      var invAtten : f32 = 1.0-step(lightUnit.attenEnabled.x + lightUnit.attenEnabled.y + lightUnit.attenEnabled.z, 0.0);
      
      attenFactor = 1.0f / (
                                  lightUnit.attenEnabled.x +
                                  (lightUnit.attenEnabled.y * lightVertexDist) +
                                  (quadAtten * quadAtten)  +
                            invAtten); // avoid div by zero
   }
   else
   {
      // Directional light
      lightDir = lightUnit.position.xyz;
   }
   
   // Diffuse
   var diffuseDot : f32 = dot(vnormal, lightDir);
   diffuseDot = max(dot(vnormal, lightDir), 0.0);
   
   // // Spotlight effect
   // // NOTE: should pow(spotDotFactor, exp) but since TGE doesn't use this
   // // we ignore it.
   /* const */ var RAD180 : f32 = 3.14159f;
   var spotDotFactor : f32 = max(dot(lightDir, lightUnit.spotDirectionCutoff.xyz), 0.0);
   var spotlightEffect : f32;
   if (lightUnit.spotDirectionCutoff.w < RAD180)
   {
      var cosv : f32 = cos(lightUnit.spotDirectionCutoff.w);
      // spotDotFactor < cos(lightUnit.spotDirectionCutoff.w) ? 0.0f : spotDotFactor;
      spotlightEffect = ((step(spotDotFactor, cosv) * 0.0) + (step(cosv, spotDotFactor) * spotDotFactor));
   }
   else
   {
      spotlightEffect = 1.0f;
   }
   
   // // Specular...
   // // NOTE: in tge, shininess is never set so specular color is
   // // always modulated by 1
   // var reflectionDirection : vec3<f32> = reflect(-lightDir, vnormal);
   // var specFunc : f32 = max(dot(reflectionDirection, camDir), 0.0);
   
   // Do final calc
   var calc : vec3<f32> = lightUnit.ambient.rgb +
          (diffuseDot * lightUnit.diffuse.rgb);
          //(specFunc * lightUnit.specular.rgb);
   
   calc *= attenFactor * spotlightEffect;
   calc *= lightUnit.attenEnabled.w;
   
   return calc;
}

fn calcLighting(vpos: vec3<f32>,
                    vnorm: vec3<f32>,
                 camDir: vec3<f32>) -> vec3<f32> {
   var calc : vec3<f32>;
   
   calc = tsUniforms.lightAmbient.rgb;
   
   for (var i : u32 = 0; i<MAX_LIGHTS; i++) {
      calc += calcSingleLight(camDir, vpos, vnorm, tsUniforms.lights[i]);
   }
   
   return calc;
}


fn HandleVertLight(pos: vec3<f32>, norm: vec3<f32>, camDir: vec3<f32>, col: vec4<f32>) -> vec4<f32> {
   var lighting : vec4<f32> = saturate(vec4<f32>(tsUniforms.miscState.x * calcLighting(pos, norm, camDir), 0.0f));
   var invLight : f32 = 1.0f-tsUniforms.miscState.x;
   var ret: vec4<f32> = (col * invLight) + (lighting * tsUniforms.miscState.x);
   ret.a = 1.0f;
   return ret;
}


fn HandleEnvironmentMap(out: ptr<function, TSRasterizerData>,
                         in: TSVert) {
   // NOTE: This needs to be reversed for being row-major, and reversed again for
   // being an inverse transform.
   //var invCameraView : mat4x4<f32> = expandTo44(commonUniforms.invCameraView) * expandTo44(tsUniforms.invObjectMat);

   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0f);
   var calcNorm : vec4<f32> = vec4<f32>(in.norm.xyz, 0.0f);
   var worldPos : vec3<f32> = (calcPos * tsUniforms.objectMat).xyz;
   var worldNorm : vec3<f32> = (calcNorm * transpose(expandTo44(tsUniforms.invObjectMat))).xyz;

   var camPos : vec3<f32> = (vec4<f32>(0,0,0,1) * commonUniforms.invCameraView).xyz;

   var u = normalize(worldPos - camPos);
   var r = 2 * dot(worldNorm, u) * worldNorm - u;
   r.z += 1.0;
   var m : f32 = 1.0 / (2.0 * sqrt(dot(r, r)));
   (*out).envTexCoord = vec2<f32>(r.x * m + 0.5, r.y * m + 0.5);

   //(*out).envTexCoord = HandleSphereTexGen(expandTo44(commonUniforms.modelview), invCameraView, in.pos.xyz, in.norm.xyz);
}

fn HandleBasicFog(out: ptr<function, TSRasterizerData>,
                         in: TSVert) {
   var camPos : vec3<f32> = (vec4<f32>(0,0,0,1) * commonUniforms.invCameraView).xyz;
   (*out).fogTexCoord = CalcFogCoord((*out).worldSpacePosition, camPos, tsUniforms.fogState);
   (*out).fogColor = tsUniforms.fogColor;
}

fn HandleBasicLitShape(out: ptr<function, TSRasterizerData>,
                         in: TSVert) {
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0f);
   var calcNorm : vec4<f32> = vec4<f32>(in.norm.xyz, 0.0f);
   var worldPos : vec3<f32> = (calcPos * tsUniforms.objectMat).xyz;
   var worldNorm : vec3<f32> = (calcNorm * transpose(expandTo44(tsUniforms.invObjectMat))).xyz;
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   
   (*out).clipSpacePosition = calcPos * mvp;
   (*out).worldSpacePosition = (calcPos * tsUniforms.objectMat);
   (*out).modelViewPosition = (calcPos * commonUniforms.modelview).xyz;
   (*out).uv1 = (vec4<f32>(in.tex1.xy, 0.0,1.0) * tsUniforms.texMats[0]).xy;
   (*out).uv2 = (vec4<f32>(in.tex2.xy, 0.0,1.0) * tsUniforms.texMats[1]).xy;
   (*out).norm = (calcNorm * mvp).xyz;
   (*out).camDir = vec4<f32>(normalize((vec4<f32>(0,1,0,0) * expandTo44(commonUniforms.invCameraView)).xyz), 0);
   (*out).fragControl = tsUniforms.miscState;
   
   (*out).color = commonUniforms.modulationColor * in.col;
   (*out).color = HandleVertLight(worldPos, worldNorm, (*out).camDir.xyz, (*out).color);
   (*out).color = (*out).color * vec4<f32>(1.0, 1.0, 1.0, tsUniforms.miscState.w);
}

fn HandleBasicUnlitShape(out: ptr<function, TSRasterizerData>,
                           in: TSVert) {
   var calcPos : vec4<f32> = vec4<f32>(in.pos.xyz, 1.0f);
   var calcNorm : vec4<f32> = vec4<f32>(in.norm.xyz, 0.0f);
   var mv : mat4x4<f32> = expandTo44(commonUniforms.modelview);
   var mvp : mat4x4<f32> = mv * commonUniforms.projection;
   
   (*out).clipSpacePosition = calcPos * mvp;
   (*out).worldSpacePosition = (calcPos * tsUniforms.objectMat);
   (*out).modelViewPosition = (calcPos * mv).xyz;
   (*out).uv1 = (vec4<f32>(in.tex1.xy, 0.0,1.0) * tsUniforms.texMats[0]).xy;
   (*out).uv2 = (vec4<f32>(in.tex2.xy, 0.0,1.0) * tsUniforms.texMats[1]).xy;
   (*out).norm = (calcNorm * mvp).xyz;
   (*out).camDir = vec4<f32>(normalize((vec4<f32>(0,1,0,0) * expandTo44(commonUniforms.invCameraView)).xyz), 0);
   (*out).fragControl = tsUniforms.miscState;
   
   (*out).color = commonUniforms.modulationColor * in.col * vec4<f32>(1.0, 1.0, 1.0, tsUniforms.miscState.w);
}
