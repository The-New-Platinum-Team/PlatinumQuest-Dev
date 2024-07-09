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
   textureName = "platinum/data/particles/spark";
   animTexName[0] = "platinum/data/particles/spark";
   colors[0] = "1.000000 1.000000 1.000000 0.227451";
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
