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
datablock ParticleData(FireballItemParticle) {
	dragCoefficient = "2.546432";
	windCoefficient = "0.25";
	gravityCoefficient = "0.05";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "2000";
	lifetimeVarianceMS = "96";
	spinSpeed = "1";
	spinRandomMin = "-50";
	spinRandomMax = "0";
	useInvAlpha = "0";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/fireball_5";
	animTexName[0] = "platinum/data/particles/fireball_5";
	colors[0] = "0.842520 0.826772 0.842520 0.440945";
	colors[1] = "0.779528 0.811024 0.881890 1.000000";
	colors[2] = "0.842520 0.858268 0.889764 0.000000";
	colors[3] = "0.889764 0.905512 0.976378 0.000000";
	sizes[0] = "0.1";
	sizes[1] = "0.24";
	sizes[2] = "0.88";
	sizes[3] = "0.8";
	times[0] = "0";
	times[1] = "0.28";
	times[2] = "0.74";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(FireballItemEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "200";
	periodVarianceMS = "60";
	ejectionVelocity = "0.5";
	velocityVariance = "0";
	ejectionOffset = "0.2";
	thetaMin = "120";
	thetaMax = "160";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "FireballItemParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
	newVarianceMS = "2";
	oldVarianceMS = "2";
};
