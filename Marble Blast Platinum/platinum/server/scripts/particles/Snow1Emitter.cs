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
datablock ParticleData(Snow1Particle) {
	textureName = $usermods @ "/data/particles/powerup/spark.png";
	dragCoefficient = 0.25;
	gravityCoefficient = 2;
	inheritedVelFactor = 0.25;

	lifeTimeMS = 6000;
	lifetimeVarianceMS = 0;

	spinSpeed = 5;
	spinRandomMin = 0;
	spinRandomMax = 2;

	useInvAlpha = true;

	colors[0] = "1 1 1 1.0";
	colors[1] = "1 1 1 0.9";
	colors[2] = "1 1 1 0.5";

	sizes[0] = 0.5;
	sizes[1] = 0.5;
	sizes[2] = 0.1;

	times[0] = 0;
	times[1] = 0.9;
	times[2] = 1.0;
};

//--- Emitter ---
datablock ParticleEmitterData(Snow1Emitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = 5;
	periodVarianceMS = 0;
	ejectionVelocity = 30;
	velocityVariance = 20;
	thetaMin = 90;
	thetaMax = 90;
	phiReferenceVel = 0;
	phiVariance = 360;
	lifetimeMS = 0;
	particles = "Snow1Particle";
	noHide = true;
};

//--- Particle ---
datablock ParticleData(Snow1GParticle : Snow1Particle) {
	gravityCoefficient = 0;
};

//--- Emitter ---
datablock ParticleEmitterData(Snow1GEmitter : Snow1Emitter) {
	ejectionPeriodMS = 15;
	thetaMin = 0;
	thetaMax = 180;
	particles = "Snow1GParticle";
	noHide = true;
};

