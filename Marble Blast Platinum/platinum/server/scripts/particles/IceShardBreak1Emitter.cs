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
datablock ParticleData(IceShardBreak1Particle) {
	dragCoefficient = "2.352941";
	windCoefficient = "0.2745098";
	gravityCoefficient = "0.1176471";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "422";
	lifetimeVarianceMS = "421";
	spinSpeed = "6.47059";
	spinRandomMin = "-90";
	spinRandomMax = "0.5";
	useInvAlpha = "0";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/fireball_1B";
	animTexName[0] = "platinum/data/particles/fireball_1B";
	colors[0] = "0.842520 0.700787 0.653543 0.000000";
	colors[1] = "0.779528 0.598425 0.519685 1.000000";
	colors[2] = "0.881890 0.519685 0.370079 0.574803";
	colors[3] = "0.889764 0.905512 0.976378 0.000000";
	sizes[0] = "0.1";
	sizes[1] = "0.24";
	sizes[2] = "0.34";
	sizes[3] = "0.29";
	times[0] = "0";
	times[1] = "0.28";
	times[2] = "0.74";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(IceShardBreak1Emitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "2";
	periodVarianceMS = "1";
	ejectionVelocity = "2";
	velocityVariance = "0.05";
	ejectionOffset = "0.2";
	thetaMin = "65.29412";
	thetaMax = "155.2941";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "IceShardBreak1Particle";
	lifetimeMS = "166";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
	newVarianceMS = "1";
	oldVarianceMS = "0";
};
