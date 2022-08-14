//-----------------------------------------------------------------------------
// Portions Copyright (c) 2021 The Platinum Team
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

//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

// Nuke and Magnet codes by Lonestar for Marble Blast Platinum

//-----------------------------------------------------------------------------

datablock AudioProfile(TrapDoorOpenSfx) {
	filename    = "~/data/sound/TrapDoorOpen.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(TrapDoorOpenMbgSfx) {
	filename    = "~/data/sound/ap_mbg/TrapDoorOpen.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(TrapDoorOpenMbuSfx) {
	filename    = "~/data/sound/ap_mbu/TrapDoorOpen.ogg";
	description = AudioDefault3d;
	preload = true;
};


datablock StaticShapeData(TrapDoor) {
	className = "TrapDoorClass";
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";
	shapeFile = "~/data/shapes/hazards/trapdoor.dts";
	resetTime = 5000;
	scopeAlways = true;

	// TODO: rethink which textures to use, perhaps use more. Remove frictions as they do not take effect.
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";

	customField[0, "field"  ] = "resetTime";
	customField[0, "type"   ] = "time";
	customField[0, "name"   ] = "Reset Time";
	customField[0, "desc"   ] = "How long it takes the trapdoor to reopen.";
	customField[0, "default"] = "Default";
	customField[1, "field"  ] = "skin";
	customField[1, "type"   ] = "string";
	customField[1, "name"   ] = "Skin Name";
	customField[1, "desc"   ] = "Which skin to use (see skin selector).";
	customField[1, "default"] = "skin0";
	customField[2, "field"  ] = "mbuanim";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Use MBU anim/sound?";
	customField[2, "desc"   ] = "If ticked then the old anim/sound will be used for MBU trapdoors.";
	customField[2, "default"] = "0";
};

datablock StaticShapeData(TrapDoor_PQ : TrapDoor) {
	superCategory = "Hazards";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/hazards/trapdoor.dts";
};

// datablock StaticShapeData(TrapDoor_MBU : TrapDoor) {
// 	shapeFile = "~/data/shapes_mbu/hazards/trapdoor.dts";
// };

function TrapDoorClass::onAdd(%this, %obj) {
	%obj._open = false;
	%obj._timeout = 200;
	// Default variables
	if (%obj.resetTime $= "0")
		%obj.resetTime = "Default";
		
	// Skin takes effect upon mission reset or reload
	if (%obj.skinName !$= "") { //clean up old skinname field
		%obj.skin = %obj.skinName;
		%obj.skinName = "";
	}

	if (%obj.skin $= "")
		%obj.skin = %obj.getSkinName();
	else
		%obj.setSkinName(%obj.skin);

	if ((Sky.materialList $= "platinum/data/skies/sky_day.dml") && (%obj.skin $= "")) {
		%obj.skin = "skin1";
		%obj.setSkinName(%obj.skin);
		if ($TexturePack::MBXP) {
			%obj.skin = "skin0";
			%obj.setSkinName(%obj.skin);
		}
	}

	if (%obj.mbuanim $= "")
		%obj.mbuanim = "0";
}

function TrapDoorClass::onCollision(%this,%obj,%col) {
	if (!Parent::onCollision(%this,%obj,%col)) return;
	if (!%obj._open) {
		// pause before opening - give marble a chance to get off
		%this.schedule(%obj._timeout,"open",%obj);
		%obj._open = true;

		// Schedule the button reset
		%resetTime = (%obj.resetTime $= "Default")? %this.resetTime: %obj.resetTime;
		if (%resetTime)
			%this.schedule(%resetTime,close,%obj);
	}
}

function TrapdoorClass::open(%this, %obj) {
	if ((%obj.skin $= "skin1") && (%obj.dataBlock $= "Trapdoor"))
	%obj.playAudio(0,TrapDoorOpenMbgSfx);
	
	else %obj.playAudio(0,TrapDoorOpenSfx);

	%obj.setThreadDir(0,true);
	%obj.playThread(0,"fall",1);
	%obj._open = true;
}

function TrapDoor_MBU::open(%this, %obj) {
	%obj.setThreadDir(0,true);

	if (((%obj.mbuanim $= "1") && (%obj.dataBlock $= "Trapdoor_MBU")) || ($pref::spchanges && %obj.isTemperable $= "1"))  {
	%obj.playThread(0,"mbuFall",1);
	%obj.playAudio(0,TrapDoorOpenMbuSfx);

	} else { 
	%obj.playThread(0,"fall",1);
	%obj.playAudio(0,TrapDoorOpenSfx);
	}

	%obj._open = true;
}

function TrapdoorClass::close(%this, %obj) {
	if ((%obj.skin $= "skin1") && (%obj.dataBlock $= "Trapdoor"))
	%obj.playAudio(0,TrapDoorOpenMbgSfx);
	else %obj.playAudio(0,TrapDoorOpenSfx);

	%obj.setThreadDir(0,false);
	%obj._open = false;
}

function TrapDoor_MBU::close(%this, %obj) {
	%obj.setThreadDir(0,false);

	if (((%obj.mbuanim $= "1") && (%obj.dataBlock $= "Trapdoor_MBU")) || ($pref::spchanges && %obj.isTemperable $= "1")) 
	%obj.playAudio(0,TrapDoorOpenMbuSfx);
	else %obj.playAudio(0,TrapDoorOpenSfx);

	%obj._open = false;
}


//-----------------------------------------------------------------------------
datablock AudioProfile(DuctFanSfx) {
	filename    = "~/data/sound/Fan_loop.wav";
	description = AudioClosestLooping3d;
	preload = true;
};


datablock StaticShapeData(DuctFan) {
	className = "Fan";
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";
	shapeFile = "~/data/shapes/hazards/ductfan.dts";
	scopeAlways = true;

	forceType[0] = Cone;       // Force type {Spherical, Field, Cone}
	forceNode[0] = 0;          // Shape node transform
	forceStrength[0] = $Game::FanStrength;     // Force to apply
	forceStrengthModifier[0] = 1; //Modifier of forceStrength
	forceRadius[0] = 10;       // Max radius
	forceArc[0] = 0.7;         // Cos angle

	powerOn = true;         // Default state
};

datablock StaticShapeData(SmallDuctFan) {
	className = "Fan";
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";
	shapeFile = "~/data/shapes/hazards/ductfan.dts";
	scopeAlways = true;

	scale = "0.5 0.5 0.5";

	forceType[0] = Cone;       // Force type {Spherical, Field, Cone}
	forceNode[0] = 0;          // Shape node transform
	forceStrength[0] = $Game::FanStrength * 0.25;     // Force to apply
	forceStrengthModifier[0] = 0.25; //Modifier of forceStrength
	forceRadius[0] = 5;       // Max radius
	forceArc[0] = 0.7;         // Cos angle

	powerOn = true;         // Default state
};

datablock StaticShapeData(DuctFan_BM : DuctFan) {
	className = "Fan";
	superCategory = "Hazards";
	category = "Blasted";
	shapeFile = "~/data/shapes_bm/hazards/ductfan.dts";
	scopeAlways = true;

	forceType[0] = Cone;       // Force type {Spherical, Field, Cone}
	forceNode[0] = 0;          // Shape node transform
	forceStrength[0] = $Game::FanStrength;     // Force to apply
	forceStrengthModifier[0] = 1; //Modifier of forceStrength
	forceRadius[0] = 10;       // Max radius
	forceArc[0] = 0.7;         // Cos angle

	powerOn = true;         // Default state
};

datablock StaticShapeData(DuctFan_PQ : DuctFan) {
	superCategory = "Hazards";
	category = "PlatinumQuest";

	compile = "pls";
	shapeFile = "~/data/shapes_pq/Gameplay/hazards/ductfan.dts";
};
datablock StaticShapeData(SmallDuctFan_PQ : SmallDuctFan) {
	superCategory = "Hazards";
	category = "PlatinumQuest";

	compile = "pls";
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/ductfan.dts";
};
datablock StaticShapeData(DuctFan_MBU : DuctFan) {
	superCategory = "Hazards";
	category = "Marble_Blast_Ultra/Mobile";
		
	compile = "pls";
	shapeFile = "~/data/shapes_mbu/hazards/mbu-hitboxes/ductfan.dts";
};
datablock StaticShapeData(SmallDuctFan_MBU : SmallDuctFan) {
	superCategory = "Hazards";
	category = "Marble_Blast_Ultra/Mobile";
		
	compile = "pls";
	shapeFile = "~/data/shapes_mbu/mbu-hitboxes/hazards/ductfan.dts";
};

datablock StaticShapeData(NomeshDuctFan_PQ : DuctFan) {
	superCategory = "Hazards";
	category = "PlatinumQuest";

	compile = "pls";
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/ductfannomesh.dts";
};

function Fan::onAdd(%this,%obj) {
	if (%this.powerOn) {
		%obj.playAudio(0, DuctFanSfx);
		%obj.playThread(0,"spin");
	}
	%obj.setPoweredState(%this.powerOn);
}

function Fan::onTrigger(%this,%obj,%mesg) {
	if (%mesg) {
		%obj.playAudio(0, DuctFanSfx);
		%obj.playThread(0,"spin");
	} else {
		%obj.stopThread(0);
		%obj.stopAudio(0);
	}
	%obj.setPoweredState(%mesg);
}

function Fan::onMissionReset(%this, %obj) {
	if (!$Game::Menu && %obj.getPoweredState()) {
		%obj.stopAudio(0);
		%obj.playAudio(0, DuctFanSfx);
	}
}

function Ductfan_MBM::onAdd(%this,%obj) {
   if ($pref::spchanges && %obj.isTemperable $= "1")
	%obj.setDataBlock("Ductfan_MBU");
	return Fan::onAdd(%this, %obj);
}
//-----------------------------------------------------------------------------


datablock AudioProfile(TornadoSfx) {
	filename    = "~/data/sound/Tornado.wav";
	description = AudioClosestLooping3d;
	preload = true;
};

datablock StaticShapeData(Tornado) {
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";

	shapeFile = "~/data/shapes/hazards/tornado.dts";
	scopeAlways = true;

	// Pull the marble in
	forceType[0] = Spherical;  // Force type {Spherical, Field, Cone}
	forceStrength[0] = -60;     // Force to apply
	forceRadius[0] = 8;       // Max radius

	// Counter sphere to slow the marble down near the center
	forceType[1] = Spherical;
	forceStrength[1] = 60;
	forceRadius[1] = 3;

	// Field to shoot the marble up
	forceType[2] = Field;
	forceVector[2] = "0 0 1";
	forceStrength[2] = 250;
	forceRadius[2] = 3;
};

function Tornado::onAdd(%this,%obj) {
	%obj.playThread(0,"ambient");
	%obj.playAudio(0,TornadoSfx);
	%obj.setPoweredState(true);
}

function Tornado::onMissionReset(%this, %obj) {
	if (!$Game::Menu) {
		%obj.stopAudio(0);
		%obj.playAudio(0, TornadoSfx);
	}
}

datablock StaticShapeData(Tornado_MBM : Tornado) {
	superCategory = "Hazards";
	category = "Marble_Blast_Ultra/Mobile";

	shapeFile = "~/data/shapes_mbu/hazards/tornado.dts";
	
	// Field to shoot the marble up
	forceType[2] = Field;
	forceVector[2] = "0 0 1";
	forceStrength[2] = 350;
	forceRadius[2] = 3;
};

datablock StaticShapeData(Tornado) {
	superCategory = "Hazards";
	category = "Blasted";

	shapeFile = "~/data/shapes_bm/hazards/tornado.dts";
	
	// Field to shoot the marble up
	forceType[2] = Field;
	forceVector[2] = "0 0 1";
	forceStrength[2] = 250;
	forceRadius[2] = 3;
};

//-----------------------------------------------------------------------------
datablock StaticShapeData(OilSlick) {
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";
	shapeFile = "~/data/shapes/hazards/oilslick.dts";
	scopeAlways = true;

	customField[1, "field"  ] = "skin";
	customField[1, "type"   ] = "string";
	customField[1, "name"   ] = "Skin Name";
	customField[1, "desc"   ] = "Which skin to use (see skin selector).";
	customField[1, "default"] = "skin0";

	skin[0] = "base";
	skin[1] = "ice";
};

function OilSlick::onAdd(%this,%obj) {
	if (%obj.skin $= "")
		%obj.skin = "base";
		
	// Skin takes effect upon mission reset or reload
	if (%obj.skinName !$= "") { //clean up old skinname field
		%obj.skin = %obj.skinName;
		%obj.skinName = "";
	}

	if (%obj.skin $= "")
		%obj.skin = %obj.getSkinName();
	else
		%obj.setSkinName(%obj.skin);
}

//-----------------------------------------------------------------------------
// LandMine

datablock AudioProfile(ExplodeSfx) {
	filename    = "~/data/sound/NukeExplode.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ParticleData(LandMineParticle) {
	textureName          = "~/data/particles/smoke";
	dragCoefficient      = 2;
	gravityCoefficient   = 0.2;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 1000;
	lifetimeVarianceMS   = 150;

	colors[0]     = "0.56 0.36 0.26 1.0";
	colors[1]     = "0.56 0.36 0.26 0.0";

	sizes[0]      = 0.5;
	sizes[1]      = 1.0;
};

datablock ParticleEmitterData(LandMineEmitter) {
	ejectionPeriodMS = 7;
	periodVarianceMS = 0;
	ejectionVelocity = 2;
	velocityVariance = 1.0;
	ejectionOffset   = 0.0;
	thetaMin         = 0;
	thetaMax         = 60;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvances = false;
	particles = "LandMineParticle";
};

datablock ParticleData(LandMineSmoke) {
	textureName          = "~/data/particles/smoke";
	dragCoeffiecient     = 100.0;
	gravityCoefficient   = 0;
	inheritedVelFactor   = 0.25;
	constantAcceleration = -0.80;
	lifetimeMS           = 1200;
	lifetimeVarianceMS   = 300;
	useInvAlpha =  true;
	spinRandomMin = -80.0;
	spinRandomMax =  80.0;

	colors[0]     = "0.56 0.36 0.26 1.0";
	colors[1]     = "0.2 0.2 0.2 1.0";
	colors[2]     = "0.0 0.0 0.0 0.0";

	sizes[0]      = 1.0;
	sizes[1]      = 1.5;
	sizes[2]      = 2.0;

	times[0]      = 0.0;
	times[1]      = 0.5;
	times[2]      = 1.0;
};

datablock ParticleEmitterData(LandMineSmokeEmitter) {
	ejectionPeriodMS = 10;
	periodVarianceMS = 0;
	ejectionVelocity = 4;
	velocityVariance = 0.5;
	thetaMin         = 0.0;
	thetaMax         = 180.0;
	lifetimeMS       = 250;
	particles = "LandMineSmoke";
};

datablock ParticleData(LandMineSparks) {
	textureName          = "~/data/particles/spark";
	dragCoefficient      = 1;
	gravityCoefficient   = 0.0;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 500;
	lifetimeVarianceMS   = 350;

	colors[0]     = "0.60 0.40 0.30 1.0";
	colors[1]     = "0.60 0.40 0.30 1.0";
	colors[2]     = "1.0 0.40 0.30 0.0";

	sizes[0]      = 0.5;
	sizes[1]      = 0.25;
	sizes[2]      = 0.25;

	times[0]      = 0.0;
	times[1]      = 0.5;
	times[2]      = 1.0;
};

datablock ParticleEmitterData(LandMineSparkEmitter) {
	ejectionPeriodMS = 3;
	periodVarianceMS = 0;
	ejectionVelocity = 13;
	velocityVariance = 6.75;
	ejectionOffset   = 0.0;
	thetaMin         = 0;
	thetaMax         = 180;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvances = false;
	orientParticles  = true;
	lifetimeMS       = 100;
	particles = "LandMineSparks";
};

datablock ExplosionData(LandMineSubExplosion1) {
	offset = 1.0;
	emitter[0] = LandMineSmokeEmitter;
	emitter[1] = LandMineSparkEmitter;
};

datablock ExplosionData(LandMineSubExplosion2) {
	offset = 1.0;
	emitter[0] = LandMineSmokeEmitter;
	emitter[1] = LandMineSparkEmitter;
};

datablock ExplosionData(LandMineExplosion) {
	soundProfile = ExplodeSfx;
	lifeTimeMS = 1200;

	// Volume particles
	particleEmitter = LandMineEmitter;
	particleDensity = 80;
	particleRadius = 1;

	// Point emission
	emitter[0] = LandMineSmokeEmitter;
	emitter[1] = LandMineSparkEmitter;

	// Sub explosion objects
	subExplosion[0] = LandMineSubExplosion1;
	subExplosion[1] = LandMineSubExplosion2;

	// Camera Shaking
	shakeCamera = true;
	camShakeFreq = "10.0 11.0 10.0";
	camShakeAmp = "1.0 1.0 1.0";
	camShakeDuration = 0.5;
	camShakeRadius = 10.0;

	// Impulse
	impulseRadius = 10;
	impulseForce = 15;

	// Dynamic light
	lightStartRadius = 0;
	lightEndRadius = 0;
	lightStartColor = "0.5 0.5 0";
	lightEndColor = "0 0 0";
};

datablock StaticShapeData(LandMine) {
	className = "LandMineClass";
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";
	shapeFile = "~/data/shapes/hazards/landmine.dts";
	explosion = LandMineExplosion;
	renderWhenDestroyed = false;
	resetTime = 5000;
};

datablock StaticShapeData(LandMine_PQ : LandMine) {
	superCategory = "Hazards";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Mine/landmine.dts";
	skin = "base";
};

datablock StaticShapeData(LandMine_BM : LandMine) {
	superCategory = "Hazards";
	category = "Blasted";

	shapeFile = "~/data/shapes_bm/Hazards/LandMine_bm.dts";
	skin = "base";
};

datablock StaticShapeData(LandMine_MBM : LandMine) {
	superCategory = "Hazards";
	category = "Marble_Blast_Ultra/Mobile";

	shapeFile = "~/data/shapes_mbu/hazards/landmine.dts";
	skin = "base";
};

function LandMineClass::onAdd(%this, %obj) {
	if (%obj.resetTime $= "")
		%obj.resetTime = "Default";

	// PQ landmine has a skin
	if (%this.skin !$= "")
		%obj.setSkinName(%this.skin);

	%obj.playThread(0, "anim0");
}

function LandMineClass::onCollision(%this, %obj, %col) {
	if (!Parent::onCollision(%this, %obj, %col)) return;
	%obj.setDamageState("Destroyed");

	%resetTime = (%obj.resetTime $= "Default")? %this.resetTime: %obj.resetTime;
	if (%resetTime) {
		%obj.startFade(0, 0, true);
		%obj.schedule(%resetTime, setDamageState,"Enabled");
		%obj.schedule(%resetTime, "startFade", 1000, 0, false);
	}
}

//-----------------------------------------------------------------------------

datablock AudioProfile(MagnetSfx) {
	filename    = "~/data/sound/magnet.wav";
	description = AudioClosestLooping3d;
	preload = true;
};

datablock StaticShapeData(Magnet) {
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";
	shapeFile = "~/data/shapes/hazards/Magnet/magnet.dts";
	scopeAlways = true;
	forceType[0] = Cone;
	// Force type {Spherical, Field, Cone}
	forceNode[0] = 0;
	// Shape node transform
	forceStrength[0] = -90;
	// Force to apply
	forceRadius[0] = 10;
	// Max radius
	forceArc[0] = 0.7;
	// Cos angle
	powerOn = true;
	// Default state
};


function Magnet::onAdd(%this,%obj) {
	if (%this.powerOn) {
		%obj.playAudio(0, MagnetSfx);
		%obj.playThread(0,"spin");
	}
	%obj.setPoweredState(%this.powerOn);
}

function Magnet::onTrigger(%this,%obj,%mesg) {
	if (%mesg) {
		%obj.playAudio(0, MagnetSfx);
		%obj.playThread(0,"spin");
	} else {
		%obj.stopThread(0);
		%obj.stopAudio(0);
	}
	%obj.setPoweredState(%mesg);
}

function Magnet::onMissionReset(%this, %obj) {
	if (!$Game::Menu && %obj.getPoweredState()) {
		%obj.stopAudio(0);
		%obj.playAudio(0, MagnetSfx);
	}
}

//-----------------------------------------------------------------------------

// datablock AudioProfile(ExplodeSfx) {
// 	filename    = "~/data/sound/NukeExplode.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };


// datablock ParticleData(NukeParticle) { // Is this even used?
// 	textureName          = "~/data/particles/smoke";
// 	dragCoefficient      = 2;
// 	gravityCoefficient   = 0.2;
// 	inheritedVelFactor   = 0.2;
// 	constantAcceleration = 0.0;
// 	lifetimeMS           = 1000;
// 	lifetimeVarianceMS   = 1500;

// 	colors[0]     = "0.56 0.36 0.26 1.0";
// 	colors[1]     = "0.56 0.36 0.26 0.0";

// 	sizes[0]      = 0.5;
// 	sizes[1]      = 1.0;
// };


datablock ParticleEmitterData(NukeEmitter) {
	ejectionPeriodMS = 7;
	periodVarianceMS = 0;
	ejectionVelocity = 2;
	velocityVariance = 1.0;
	ejectionOffset   = 0.0;
	thetaMin         = 0;
	thetaMax         = 60;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvances = false;
	particles = "LandMineParticle";
};


datablock ParticleData(NukeSmoke) {
	textureName          = "~/data/particles/smoke";
	dragCoeffiecient     = 100.0;
	gravityCoefficient   = -0.5;
	inheritedVelFactor   = 0.25;
	constantAcceleration = -0.80;
	lifetimeMS           = 10000;
	lifetimeVarianceMS   = 3000;
	useInvAlpha =  true;
	spinRandomMin = -80.0;
	spinRandomMax =  80.0;

	colors[0]     = "0.56 0.36 0.26 1.0";
	colors[1]     = "0.2 0.2 0.2 1.0";
	colors[2]     = "0.0 0.0 0.0 0.0";

	sizes[0]      = 1.0;
	sizes[1]      = 1.5;
	sizes[2]      = 2.0;

	times[0]      = 0.0;
	times[1]      = 0.5;
	times[2]      = 1.0;
};


datablock ParticleEmitterData(NukeSmokeEmitter) {
	ejectionPeriodMS = 10;
	periodVarianceMS = 0;
	ejectionVelocity = 4;
	velocityVariance = 0.5;
	thetaMin         = 0.0;
	thetaMax         = 180.0;
	lifetimeMS       = 250;
	particles = "NukeSmoke";
};

datablock ParticleData(NukeSparks) {
	textureName          = "~/data/particles/spark";
	dragCoefficient      = 1;
	gravityCoefficient   = 0.0;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 5000;
	lifetimeVarianceMS   = 2000;

	colors[0]     = "0.60 0.40 0.30 1.0";
	colors[1]     = "0.60 0.40 0.30 1.0";
	colors[2]     = "1.0 0.40 0.30 0.0";

	sizes[0]      = 0.5;
	sizes[1]      = 0.25;
	sizes[2]      = 0.25;

	times[0]      = 0.0;
	times[1]      = 0.5;
	times[2]      = 1.0;
};


datablock ParticleEmitterData(NukeSparkEmitter) {
	ejectionPeriodMS = 3;
	periodVarianceMS = 0;
	ejectionVelocity = 13;
	velocityVariance = 6.75;
	ejectionOffset   = 0.0;
	thetaMin         = 0;
	thetaMax         = 180;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvances = false;
	orientParticles  = true;
	lifetimeMS       = 5000;
	particles = "NukeSparks";
};


datablock ExplosionData(NukeSubBlow1) {
	offset = 1.0;
	emitter[0] = NukeSmokeEmitter;
	emitter[1] = NukeSparkEmitter;
};

datablock ExplosionData(NukeSubBlow2) {
	offset = 1.0;
	emitter[0] = NukeSmokeEmitter;
	emitter[1] = NukeSparkEmitter;
};

datablock ExplosionData(NukeExplosion) {
	soundProfile = ExplodeSfx;
	lifeTimeMS = 10000;

	// Volume particles
	particleEmitter = NukeEmitter;
	particleDensity = 120;
	particleRadius = 3;

	// Point emission
	emitter[0] = NukeSmokeEmitter;
	emitter[1] = NukeSparkEmitter;

	// Sub explosion objects
	subExplosion[0] = NukeSubBlow1;
	subExplosion[1] = NukeSubBlow2;

	// Camera Shaking
	shakeCamera = true;
	camShakeFreq = "10.0 11.0 10.0";
	camShakeAmp = "1.0 1.0 1.0";
	camShakeDuration = 5;
	camShakeRadius = 50.0;

	// Impulse
	impulseRadius = 10;
	impulseForce = 100;

	// Dynamic light
	lightStartRadius = 0;
	lightEndRadius = 0;
	lightStartColor = "0.5 0.5 0";
	lightEndColor = "0 0 0";
};

datablock StaticShapeData(Nuke) {
	className = "NukeClass";
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";
	shapeFile = "~/data/shapes/hazards/Nuke/nuke.dts";

	explosion = NukeExplosion;
	renderWhenDestroyed = false;
	resetTime = 15000;

	customField[0, "field"  ] = "resetTime";
	customField[0, "type"   ] = "time";
	customField[0, "name"   ] = "Reset Time";
	customField[0, "desc"   ] = "How long it takes the nuke to respawn.";
	customField[0, "default"] = "15000";
};

datablock StaticShapeData(Nuke_PQ : Nuke) {
	superCategory = "Hazards";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Mine/landmine.dts";
	skin = "nuke";
};


function NukeClass::onAdd(%this, %obj) {
	if (%obj.resetTime $= "")
		%obj.resetTime = "15000";

	// PQ nuke uses a skin
	if (%this.skin !$= "")
		%obj.setSkinName(%this.skin);

	%obj.playThread(0, "anim0");
}

function NukeClass::onCollision(%this, %obj, %col) {
	if (!Parent::onCollision(%this, %obj, %col)) return;
	%obj.setDamageState("Destroyed");
	if (%obj.nukesweeper) {
		return;
	}
	%resetTime = (%obj.resetTime $= "Default")? %this.resetTime: %obj.resetTime;
	if (%resetTime) {
		%obj.startFade(0, 0, true);
		%obj.schedule(%resetTime, setDamageState,"Enabled");
		%obj.schedule(%resetTime, "startFade", 1000, 0, false);
	}
}

//-----------------------------------------------------------------------------
// PQ hazard shapes
//-----------------------------------------------------------------------------

datablock StaticShapeData(Tornado_PQ : Tornado) {
	superCategory = "Hazards";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/hazards/tornado.dts";

	fxEmitter[0] = "GustEmitter";
	fxEmitter[1] = "SpeckEmitter";
};

// TODO: put this in its own cs file like PQ has [the particle]

//--- Particle ---
datablock ParticleData(FanGustParticle) {
	dragCoefficient = "0.581623";
	windCoefficient = "0";
	gravityCoefficient = "-0.00732601";
	inheritedVelFactor = "0.46771";
	constantAcceleration = "0";
	lifetimeMS = "800";
	lifetimeVarianceMS = "96";
	spinSpeed = "4.21569";
	spinRandomMin = "-100";
	spinRandomMax = "93";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "";
	animTexName[0] = "platinum/data/particles/gust";
	colors[0] = "0.803150 0.779528 0.803150 0.000000";
	colors[1] = "0.732283 0.700787 0.661417 0.362205";
	colors[2] = "0.748031 0.732283 0.732283 0.346457";
	colors[3] = "0.763780 0.755906 0.724409 0.000000";
	sizes[0] = "0.875908";
	sizes[1] = "3.72642";
	sizes[2] = "3.42428";
	sizes[3] = "2.35";
	times[0] = "0";
	times[1] = "0.176471";
	times[2] = "0.458824";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(FanGustEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "79";
	periodVarianceMS = "78";
	ejectionVelocity = "10.28";
	velocityVariance = "0.87";
	ejectionOffset = "0";
	thetaMin = "67";
	thetaMax = "112";
	phiReferenceVel = "0";
	phiVariance = "42.3529";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "0";
	particles = "FanGustParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};

//--- Particle ---
datablock ParticleData(SpeckParticle) {
	dragCoefficient = "0";
	windCoefficient = "0";
	gravityCoefficient = "0";
	inheritedVelFactor = "0";
	constantAcceleration = "-5";
	lifetimeMS = "911";
	lifetimeVarianceMS = "96";
	spinSpeed = "6.86275";
	spinRandomMin = "-90";
	spinRandomMax = "161.765";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/speck";
	animTexName[0] = "platinum/data/particles/speck";
	colors[0] = "0.441176 0.333333 0.088235 0.000000";
	colors[1] = "0.745098 0.568627 0.382353 0.000000";
	colors[2] = "0.735294 0.607843 0.460784 0.280000";
	colors[3] = "0.774510 0.676471 0.490196 1.000000";
	sizes[0] = "0.78";
	sizes[1] = "1";
	sizes[2] = "1";
	sizes[3] = "0";
	times[0] = "0";
	times[1] = "0.24";
	times[2] = "0.39";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(SpeckEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "10";
	periodVarianceMS = "9";
	ejectionVelocity = "11.5686";
	velocityVariance = "0.686275";
	ejectionOffset = "6.27451";
	thetaMin = 236.471 - 180;
	thetaMax = 307.059 - 180;
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "SpeckParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};


function Tornado_PQ::onAdd(%this, %obj) {
	Tornado::onAdd(%this, %obj);

	// load particles
	%this.schedule(1000, "initFX", %obj);
}

function Tornado_MBM::onAdd(%this, %obj) {
	Tornado::onAdd(%this, %obj);
}

function Tornado_PQ::onMissionReset(%this, %obj) {
	Tornado::onMissionReset(%this, %obj);
}

function Tornado_MBM::onMissionReset(%this, %obj) {
	Tornado::onMissionReset(%this, %obj);
}

//---------------------------------------------------------------------
// Propellers

datablock StaticShapeData(Propeller) {
	className = "PropellerClass";
	superCategory = "Hazards";
	category = "Propellers";
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Propeller.dts";
	scopeAlways = true;

	forceType[0] = Cone;       // Force type {Spherical, Field, Cone}
	forceNode[0] = 0;          // Shape node transform
	forceStrength[0] = 0;      // Force to apply
	forceRadius[0] = 10;       // Max radius
	forceArc[0] = 0.7;         // Cos angle
	powerOn = true;            // Default state
};

// Use as reference
// DUCT FAN: 40
// SMALL DUCT FAN: 10
// PropLarge 4 is default values of force 40 radius 50 arc 0.7
// PropSmall 4 is default values of force 10 radius 5 arc 0.7
// Order: PropLarge, PropSmall, PropLargeReverse, PropSmallReverse, function PropellerClass:onAdd


//-------------------------
// Large propellers

datablock StaticShapeData(PropLarge1 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_large_1.dts";
	forceStrength[0] = 15;     // Force to apply
	forceRadius[0] = 25;       // Max radius
	forceArc[0] = 0.7;         // Cos angle
};

datablock StaticShapeData(PropLarge2 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_large_2.dts";
	forceStrength[0] = 25;
	forceRadius[0] = 35;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropLarge3 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_large_3.dts";
	forceStrength[0] = 35;
	forceRadius[0] = 45;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropLarge4 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_large_4.dts";
	forceStrength[0] = 40;
	forceRadius[0] = 50;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropLarge5 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_large_5.dts";
	forceStrength[0] = 45;
	forceRadius[0] = 55;
	forceArc[0] = 0.7;
};

//-------------------------
// Small propellers

datablock StaticShapeData(PropSmall1 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_Small_1.dts";
	forceStrength[0] = 4;    // Force to apply
	forceRadius[0] = 4;      // Max radius
	forceArc[0] = 0.7;       // Cos angle
};

datablock StaticShapeData(PropSmall2 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_Small_2.dts";
	forceStrength[0] = 6;
	forceRadius[0] = 4.5;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropSmall3 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_Small_3.dts";
	forceStrength[0] = 8;
	forceRadius[0] = 4.75;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropSmall4 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_Small_4.dts";
	forceStrength[0] = 10;
	forceRadius[0] = 5;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropSmall5 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Forward/Propeller_Small_5.dts";
	forceStrength[0] = 15;
	forceRadius[0] = 7;
	forceArc[0] = 0.7;
};

//-------------------------
// Reverse values (sucks in)

//-------------------------
// Large propellers

datablock StaticShapeData(PropLargeReverse1 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_large_r_1.dts";
	forceStrength[0] = -15;    // Force to apply
	forceRadius[0] = 25;       // Max radius
	forceArc[0] = 0.7;         // Cos angle
};

datablock StaticShapeData(PropLargeReverse2 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_large_r_2.dts";
	forceStrength[0] = -25;
	forceRadius[0] = 35;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropLargeReverse3 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_large_r_3.dts";
	forceStrength[0] = -35;
	forceRadius[0] = 45;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropLargeReverse4 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_large_r_4.dts";
	forceStrength[0] = -40;
	forceRadius[0] = 50;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropLargeReverse5 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_large_r_5.dts";
	forceStrength[0] = -45;
	forceRadius[0] = 55;
	forceArc[0] = 0.7;
};

//-------------------------
// Small propellers

datablock StaticShapeData(PropSmallReverse1 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_Small_r_1.dts";
	forceStrength[0] = -4;    // Force to apply
	forceRadius[0] = 4;      // Max radius
	forceArc[0] = 0.7;       // Cos angle
};

datablock StaticShapeData(PropSmallReverse2 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_Small_r_2.dts";
	forceStrength[0] = -6;
	forceRadius[0] = 4.5;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropSmallReverse3 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_Small_r_3.dts";
	forceStrength[0] = -8;
	forceRadius[0] = 4.75;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropSmallReverse4 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_Small_r_4.dts";
	forceStrength[0] = -10;
	forceRadius[0] = 5;
	forceArc[0] = 0.7;
};

datablock StaticShapeData(PropSmallReverse5 : Propeller) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Reverse/Propeller_Small_r_5.dts";
	forceStrength[0] = -15;
	forceRadius[0] = 7;
	forceArc[0] = 0.7;
};

function PropellerClass::onAdd(%this, %obj) {
	if (%this.powerOn) {
		%obj.playThread(1, "Rotate");
	}
	%obj.setPoweredState(%this.powerOn);
}

//-----------------------------------------------------------------------------
// Ice Slick
//-----------------------------------------------------------------------------

datablock StaticShapeData(IceSlick1) {
	className = "Hazard";
	superCategory = "Hazards";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/IceSlick1.dts";

	emap = true;
};

datablock StaticShapeData(IceSlick2 : IceSlick1) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/IceSlick2.dts";
};

datablock StaticShapeData(IceSlick3 : IceSlick1) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/IceSlick3.dts";
};

datablock StaticShapeData(IceSlick4 : IceSlick1) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/IceSlick4.dts";
};

//-----------------------------------------------------------------------------
// Ice Shard
//-----------------------------------------------------------------------------

//TODO: keep marble (while frozen) in a single spot, don't let other things move it
//      (BECAUSE MARBLE CAN BE HIT OR HIT OTHER THINGS BEFORE / AFTER FREEZE)
//      MAYBE shatter ice if it's moved
//Sam says:
//on some ice shards, i can spin the marble inside the ice
datablock AudioProfile(IceShardFreezeSfx) {
	filename    = "~/data/sound/ice_freeze.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(IceShardCrackSfx) {
	filename    = "~/data/sound/ice_crack.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(IceShardSmashSfx) {
	filename    = "~/data/sound/ice_smash.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock StaticShapeData(IceShard1) {
	className = "IceShard";
	superCategory = "Hazards";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Ice_Shard.dts";
	renderWhenDestroyed = false;
	emap = true;

	fxEmitter[0] = "IceShardMistEmitter";
	fxEmitter[1] = "IceShardShineEmitter";
};

datablock StaticShapeData(IceShard2 : IceShard1) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Ice_Shard_2.dts";
};

datablock StaticShapeData(IceChunkData) {
	className = "IceChunk";
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/ice.dts";
	superCategory = "Hazards";
	category = "PlatinumQuest";
	emap = true;
};

function IceShard1::onAdd(%this, %ice) {
	//particles init
	%this.schedule(500, "initFX", %ice);

//	Hazard::onAdd(%this, %ice);
}
function IceShard2::onAdd(%this, %ice) {
	//particles init
	IceShard1::onAdd(%this, %ice);
}

function IceShard1::onMissionReset(%this, %ice) {
	%ice.setDamageState("Enabled");
}

function IceShard2::onMissionReset(%this, %ice) {
	IceShard1::onMissionReset(%this, %ice);
}

function IceShard::onCollision(%this, %ice, %marble, %unused1, %unused2, %material) {
	if (!Parent::onCollision(%this, %ice, %marble, %unused1, %unused2, %material)) return;
	echo(%material);
	//unfortunately colliding at both textures return the material mapped to shard_ice.png
	//I'm thinking this is because the collision might be "textured" with shard_ice.png
	//sounds odd, but I think if the collision model of the base of the shard can be
	//textured as "snow" somehow, this would solve the problem

	if (%marble._fireballActive) {
		//Did the fireball take out the ice shard?
		if (%marble._fireball.getDataBlock().iceCollision(%marble._fireball, %marble, %ice))
			return true;
	}

	$IceShard::FreezeTime = 2; //two seconds frozen
	$IceShard::InvulnTime = 1; //can't be frozen again for one second after unfreeze

	if (!%marble.isFrozen && %marble.lastFreezeTime + $IceShard::FreezeTime + $IceShard::InvulnTime < $Sim::Time) {
		ECHO("IT\'S COLD, BRO");

		if (%marble.client.isMegaMarble()) {
			%marble.client.setMegaMarble(false);
			%marble.client.play3D(IceShardCrackSfx, %marble.getTransform());
			return true;
		}
		%marble.client.freezeMarble(true);

		if (!isObject(%marble.iceChunk)) {
			%marble.iceChunk = new StaticShape() {
				datablock = IceChunkData;
			};
			MissionCleanup.add(%marble.iceChunk);
		}
		%marble.iceChunk.hide(false);
		%pos = %marble.getPosition();
		%scale = %marble.getCollisionRadius() / 0.18975;
		%marble.iceChunk.setScale(vectorScale("1 1 1", %scale + 0.1));
		%marble.iceChunk.setParent(%marble, "0 0 0", 1);

		%marble.client.Play3D(IceShardFreezeSfx, %marble.getTransform());

		%marble.iceShard = %ice;
		%marble.iceShardSchedule = %this.schedule($IceShard::FreezeTime * 1000, unfreeze, %ice, %marble);
		%marble.isFrozen = 1;
		%marble.lastFreezeTime = $Sim::Time;
	}

	return true;
}

function IceShard::unfreeze(%this, %ice, %marble, %cancel) {
	if (!%marble.isFrozen)
		return;

	ECHO("IT WAS COLD, BRO");

	%marble.client.freezeMarble(false);

	if (%cancel) {
		%marble.lastFreezeTime = 0;
	} else {
		%pos = %marble.getPosition();
		%rot = applyrotations(%marble.getGravityRot(), "0 180 0");
		%rot = getWords(%rot, 0, 2) SPC mRadToDeg(getWord(%rot, 3));
		%vec = vectorNormalize(vectorSub(%pos, %ice.getPosition()));
		//		echo(%rot);
		//impulse at unfreeze:
		// - 3 in the direction opposite of ice shard
		// - 5 in the "up" direction
		%impulse = vectorScale(getWords(%vec, 0, 1), 3);
		%impulse = vectorAdd(vectorScale(normalOfGravity(%marble.getGravityRot()), 5), %impulse);

		%marble.client.play3D(IceShardCrackSfx, %marble.getTransform());

		%obj = new ParticleEmitterNode() {
			datablock = FireWorkNode;
			emitter = IceChunkChunkEmitter;
			position = %pos;
			rotation = %rot;
		};
		MissionCleanup.add(%obj);
		%obj.setScopeAlways();
		%obj.schedule(%obj.emitter.lifetimeMS + 2, "delete");

		%obj = new ParticleEmitterNode() {
			datablock = FireWorkNode;
			emitter = IceChunkSnowEmitter;
			position = %pos;
			rotation = %rot;
		};

		MissionCleanup.add(%obj);
		%obj.setScopeAlways();
		%obj.schedule(%obj.emitter.lifetimeMS+2, "delete");

		%marble.client.applyImpulse("0 0 0", %impulse);
	}

	%marble.iceChunk.stopParenting();
	%marble.iceChunk.hide(true);

	echo("Ice shard impulse is " @ %impulse);
	%marble.isFrozen = 0;
}

//MBU Datablocks down below.

if (!$pref::LegacyItems) {
	datablock StaticShapeData(TrapDoor_MBU : TrapDoor) {
		superCategory = "Hazards";
		category = "Marble_Blast_Ultra/Mobile";
	
		shapeFile = "~/data/shapes_mbu/hazards/trapdoor.dts";
	};

	datablock StaticShapeData(Ductfan_MBM : DuctFan) {
		superCategory = "Hazards";
		category = "Marble_Blast_Ultra/Mobile";

		compile = "pls";
		shapeFile = "~/data/shapes_mbu/hazards/ductfan.dts";
	};
	datablock StaticShapeData(SmallDuctFan_MBM : SmallDuctFan) {
		superCategory = "Hazards";
		category = "Marble_Blast_Ultra/Mobile";
		
		compile = "pls";
		shapeFile = "~/data/shapes_mbu/hazards/ductfan.dts";
	};
} else {
	datablock StaticShapeData(TrapDoor_MBU : TrapDoor) {
		superCategory = "Hazards";
		category = "Marble_Blast_Ultra/Mobile";
		
		shapeFile = "~/data/shapes/hazards/trapdoor.dts";
	};

	datablock StaticShapeData(Ductfan_MBM : DuctFan) {
		superCategory = "Hazards";
		category = "Marble_Blast_Ultra/Mobile";
		
		compile = "pls";
		shapeFile = "~/data/shapes/hazards/ductfan.dts";
	};
	datablock StaticShapeData(SmallDuctFan_MBM : SmallDuctFan) {
		superCategory = "Hazards";
		category = "Marble_Blast_Ultra/Mobile";
		
		compile = "pls";
		shapeFile = "~/data/shapes/hazards/ductfan.dts";
	};
}


