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
datablock ParticleData(IceShardBreak2Particle) {
	dragCoefficient = "0.3921569";
	windCoefficient = "0";
	gravityCoefficient = "0.1764706";
	inheritedVelFactor = "0";
	constantAcceleration = "0.392157";
	lifetimeMS = "480";
	lifetimeVarianceMS = "235";
	spinSpeed = "9.11765";
	spinRandomMin = "-100";
	spinRandomMax = "0.5";
	useInvAlpha = "0";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/fireball_2B";
	animTexName[0] = "platinum/data/particles/fireball_2B";
	colors[0] = "0.842520 0.826772 0.842520 0.440945";
	colors[1] = "0.779528 0.811024 0.881890 1.000000";
	colors[2] = "0.842520 0.858268 0.889764 0.000000";
	colors[3] = "0.889764 0.905512 0.976378 0.000000";
	sizes[0] = "0.78";
	sizes[1] = "0.93";
	sizes[2] = "0";
	sizes[3] = "0";
	times[0] = "0";
	times[1] = "0.28";
	times[2] = "0.74";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(IceShardBreak2Emitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "4";
	periodVarianceMS = "3";
	ejectionVelocity = "2.45098";
	velocityVariance = "0.05";
	ejectionOffset = "0.09803922";
	thetaMin = "40.58823";
	thetaMax = "150";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "IceShardBreak2Particle";
	lifetimeMS = "160";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
	newVarianceMS = "3";
	oldVarianceMS = "3";
};
