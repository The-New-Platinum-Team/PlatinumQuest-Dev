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

if ($pref::Video::particleSystem == 2) {

datablock ParticleData(MarbleWhiteTrailParticle) {
      textureName          = "~/data/particles/mbu/burst";
      dragCoefficient     = 0.0;
      gravityCoefficient   = 0;   
      inheritedVelFactor   = 0.00;
      lifetimeMS           = 2000;
      lifetimeVarianceMS   = 0;
      useInvAlpha = false;
      spinRandomMin = -90.0;
      spinRandomMax = 90.0;

      colors[0]     = "0.5 0.3 0.2 1.0";
      colors[1]     = "0.5 0.3 0.2 1.0";
      colors[2]     = "0.2 0.0 0.0 0.0";

      sizes[0]      = 0.6;
      sizes[1]      = 0.5;
      sizes[2]      = 0.1;

      times[0]      = 0.0;
      times[1]      = 0.5;
      times[2]      = 1.0;
   };

datablock ParticleEmitterData(MarbleWhiteTrailEmitter)  {
      ejectionPeriodMS = 9;
      periodVarianceMS = 0;
      ejectionVelocity = 3.0;
      velocityVariance = 0.25;
      thetaMin         = 60.0;
      thetaMax         = 90.0;
      lifetimeMS = "0";
      lifetimeVarianceMS = "0";
      particles = "MarbleWhiteTrailParticle";
   };

} else if ($pref::Video::particleSystem == 1) {

   // datablock ParticleData(MarbleWhiteTrailParticle)  {
   //    textureName          = "~/data/particles/smoke";
   //    dragCoeffiecient     = 1.0;
   //    gravityCoefficient   = 0;
   //    windCoefficient      = 0;
   //    inheritedVelFactor   = 1;
   //    constantAcceleration = 0;
   //    lifetimeMS           = 100;
   //    lifetimeVarianceMS   = 10;
   //    useInvAlpha =  true;
   //    spinSpeed     = 0;

   //    colors[0]     = "1 1 0 0.0";
   //    colors[1]     = "1 1 0 1";
   //    colors[2]     = "1 1 1 0.0";

   //    sizes[0]      = 0.7;
   //    sizes[1]      = 0.4;
   //    sizes[2]      = 0.1;

   //    times[0]      = 0;
   //    times[1]      = 0.15;
   //    times[2]      = 1.0;
   // };

   datablock ParticleEmitterData(MarbleWhiteTrailEmitter)  {
      className = "ParticleEmitterData";
      ejectionPeriodMS = "5";
      periodVarianceMS = "0";
      ejectionVelocity = "0.0";
      velocityVariance = "0.25";
      thetaMin         = "80.0";
      thetaMax         = "90.0";
      lifetimeMS = "0";
      lifetimeVarianceMS = "0";
      framesPerSec = "1";
      particles = "MarbleWhiteTrailParticle";
   };

} else {

//--- Particle ---
   datablock ParticleData(MarbleWhiteTrailParticle) {
      dragCoefficient = "0";
      windCoefficient = "0";
      gravityCoefficient = "-0.002442";
      inheritedVelFactor = "0.248532";
      constantAcceleration = "0";
      lifetimeMS = "992";
      lifetimeVarianceMS = "128";
      spinSpeed = "10";
      spinRandomMin = "0";
      spinRandomMax = "0.5";
      useInvAlpha = "1";
      animateTexture = "0";
      framesPerSec = "1";
      textureName = "platinum/data/particles/glint2";
      animTexName[0] = "platinum/data/particles/glint2";
      colors[0] = "1.000000 1.000000 1.000000 1.000000";
      colors[1] = "1.000000 1.000000 1.000000 1.000000";
      colors[2] = "1.000000 1.000000 1.000000 0.000000";
      colors[3] = "1.000000 1.000000 1.000000 1.000000";
      sizes[0] = "0.19";
      sizes[1] = "0.19";
      sizes[2] = "0.29";
      sizes[3] = "1";
      times[0] = "0";
      times[1] = "0.2";
      times[2] = "1";
      times[3] = "1";
   };

//--- Emitter ---
datablock ParticleEmitterData(MarbleWhiteTrailEmitter) {
      ejectionPeriodMS = "50";
      periodVarianceMS = "20";
      ejectionVelocity = "2";
      velocityVariance = "0.25";
      ejectionOffset = "0";
      thetaMin = "90";
      thetaMax = "100";
      phiReferenceVel = "0";
      phiVariance = "360";
      overrideAdvance = "0";
      orientParticles = "0";
      orientOnVelocity = "1";
      particles = "MarbleWhiteTrailParticle";
      lifetimeMS = "0";
      lifetimeVarianceMS = "0";
      useEmitterSizes = "0";
      useEmitterColors = "0";
         newVarianceMS = "8";
         noHide = "0";
         oldVarianceMS = "8";
   };
}
