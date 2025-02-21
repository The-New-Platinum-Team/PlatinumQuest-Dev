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
datablock ParticleData(GustParticle) {
	dragCoefficient = "0";
	windCoefficient = "0";
	gravityCoefficient = "-0.002442002";
	inheritedVelFactor = "0";
	constantAcceleration = "-5";
	lifetimeMS = "608";
	lifetimeVarianceMS = "96";
	spinSpeed = "4.21569";
	spinRandomMin = "-100";
	spinRandomMax = "0.5";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/speck";
	animTexName[0] = "platinum/data/particles/gust";
	colors[0] = "0.440945 0.330709 0.086614 0.000000";
	colors[1] = "0.448819 0.299213 0.062992 0.000000";
	colors[2] = "0.385827 0.259843 0.110236 0.346457";
	colors[3] = "0.771654 0.669291 0.488189 0.000000";
	sizes[0] = "0.88";
	sizes[1] = "3.73";
	sizes[2] = "3.43";
	sizes[3] = "2.35";
	times[0] = "0";
	times[1] = "0.24";
	times[2] = "0.46";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(GustEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "10";
	periodVarianceMS = "9";
	ejectionVelocity = "5.29";
	velocityVariance = "0.88";
	ejectionOffset = "4.31";
	thetaMin = "98.82353";
	thetaMax = "139.4118";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "GustParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
	newVarianceMS = "9";
	oldVarianceMS = "9";
};
