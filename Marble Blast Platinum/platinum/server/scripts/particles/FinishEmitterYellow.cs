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
datablock ParticleData(FinishParticleYellow) {
	dragCoefficient = "1.56863";
	windCoefficient = "0";
	gravityCoefficient = "1";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "813";
	lifetimeVarianceMS = "96";
	spinSpeed = "1";
	spinRandomMin = "-5";
	spinRandomMax = "0.5";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/glint";
	animTexName[0] = "platinum/data/particles/glint";
	colors[0] = "1.000000 1.000000 0.196850 1.000000";
	colors[1] = "1.000000 1.000000 0.496063 1.000000";
	colors[2] = "1.000000 1.000000 0.496063 0.000000";
	colors[3] = "1.000000 1.000000 1.000000 1.000000";
	sizes[0] = "0.15";
	sizes[1] = "0.05";
	sizes[2] = "0.05";
	sizes[3] = "1";
	times[0] = "0";
	times[1] = "0.75";
	times[2] = "1";
	times[3] = "1";
	dragCoeffiecient = "0.1";
};

//--- Emitter ---
datablock ParticleEmitterData(FinishEmitterYellow) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "393";
	periodVarianceMS = "30";
	ejectionVelocity = "2.45098";
	velocityVariance = "0.588235";
	ejectionOffset = "1.56863";
	thetaMin = "90";
	thetaMax = "180";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "FinishParticleYellow";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
	newVarianceMS = "1";
	noHide = "0";
	oldVarianceMS = "0";
};
