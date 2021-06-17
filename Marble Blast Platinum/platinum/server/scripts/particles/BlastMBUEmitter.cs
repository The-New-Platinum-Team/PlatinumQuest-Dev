//--- Particle ---

datablock ParticleData(BlastMBUEmitterParticle) {
	dragCoefficient = "2.54902";
	windCoefficient = "0";
	gravityCoefficient = "0.215686";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "150";
	lifetimeVarianceMS = "0";
	spinSpeed = "10";
	spinRandomMin = "-100";
	spinRandomMax = "0.5";
	useInvAlpha = "0";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/ultrablast";
	animTexName[0] = "platinum/data/particles/ultrablast";
	colors[0]     = "0.2 0.4 1.0 1.0";
	colors[1]     = "0.5 0.7 1.0 1.0";
	colors[2]     = "0.5 0.7 1.0 0.0";
	sizes[0] = "0.88";
	sizes[1] = "0.59";
	sizes[2] = "0";
	sizes[3] = "1";
	times[0] = "0";
	times[1] = "0.14";
	times[2] = "0.72";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---

datablock ParticleEmitterData(BlastMBUEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "1";
	periodVarianceMS = "0";
	ejectionVelocity = "0";
	velocityVariance = "0";
	ejectionOffset = "0";
	thetaMin = "0";
	thetaMax = "61.7647";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "BlastMBUEmitterParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};
