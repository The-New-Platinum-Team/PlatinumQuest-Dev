//-----------------------------------------------------------------------------
// Cannons
// Matan is not allowed to look at this file. If he ever does, he can no longer
// say "this isn't cannon.cs" and have any credibility. Because this is,
// in fact, cannon.cs
// Hi Matan, if you're reading this then lmaoo get fucked by the above
//
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

function Cannon::onCollision(%this, %obj, %col) {
	if (!Parent::onCollision(%this, %obj, %col)) return;
	%col.client.enterCannon(%obj);
}
function CannonBase::onCollision(%this, %obj, %col) {
	if (!Parent::onCollision(%this, %obj, %col)) return;
	if (%obj._cannon) {
		%col.client.enterCannon(getServerSyncObject(%obj._cannon));
	}
}

function GameConnection::enterCannon(%this, %cannon) {
	if (%this.disableCannon || %this.disableCannon[%cannon])
		return;

	if (%this.cannon)
		return;

	if (%this.isOOB)
		return;

	%this.cannon = %cannon;
	%this.player.noPickup = true;
	%this.player.lockPowerup();

	if (%this.isMegaMarble()) {
		%this.setMegaMarble(false);
	}

	echo("[Cannon Server]: Entering cannon" SPC %cannon._id);

	//Kill their momentum
	%this.player.setTransform(%cannon.getTransform());
	commandToClient(%this, 'EnterCannon', %cannon._id);
}

function GameConnection::leaveCannon(%this) {
	echo("[Cannon Server]: Leaving cannon" SPC %cannon._id);

	%cannon = %this.cannon;
	//Show the cannon's explosion
	%cannon.getDataBlock().explode(%cannon);

	%this.cannon = 0;
	%this.disableCannon = true;
	%this.disableCannon[%cannon] = true;
	%this.lastCannon = %cannon;

	%unlockTime = (%cannon.lockTime == 0 ? 300 : %cannon.lockTime);
	%this.player.unlockPowerup(%unlockTime);

	%this.schedule(200, activateCannon);
	%this.schedule(200, activateCannon, %cannon);
}

function GameConnection::cancelCannon(%this, %place) {
	%this.activateCannon(%this.cannon);
	%this.activateCannon();
	%this.cannon = 0;

	%this.player.unlockPowerup();
	commandToClient(%this, 'CancelCannon', %place);
}

function GameConnection::isInCannon(%this) {
	return %this.cannon != 0;
}

function serverCmdLeaveCannon(%client) {
	%client.leaveCannon();
}

function GameConnection::activateCannon(%this, %cannon) {
	if (%cannon $= "") {
		%this.disableCannon = false;
		%this.disableCannon[%this.lastCannon] = false;
		%this.player.noPickup = false;
	} else {
		%this.disableCannon[%cannon] = false;
	}
}

//-----------------------------------------------------------------------------
// Object management
//-----------------------------------------------------------------------------

function initCannons() {
	$Server::Cannons = 0;
}

function Cannon::onAdd(%this, %obj) {
	//Start with ID 1
	$Server::Cannons ++;
	echo("Add cannon " SPC %obj);

	%trans = %obj.getTransform();
	%id = $Server::Cannons;
	%obj._id = %id;

	%obj._baseTrans = %trans;

	//Set its fields
	%this.initFields(%obj);

	//Store the cannon
	$Server::Cannon[%id] = %obj;
	$Server::CannonRef[%obj] = %id;

	%obj.setSync("cannonAdded", %obj);

	echo("[Cannon Server]: Adding cannon" SPC %obj @ "/" @ %id SPC "with transform (" @ %trans @ ")");
}

function Cannon::onEditorDrag(%this, %obj) {
	%trans = %obj.getTransform();
	%obj._baseTrans = %trans;

	%client = getClientSyncObject(%obj.getSyncId());
	if (isObject(%client)) {
		%client._baseTrans = %trans;
	}

	%this.reset(%obj);
	%base = $Server::CannonBase[%obj._id];
	%clientBase = getClientSyncObject(%obj._base);
	if (isObject(%clientBase)) {
		%clientBase.setTransform(%base.getTransform());
	}
}

function CannonBase::onEditorDrag(%this, %obj) {
	%baseTrans = %obj.getTransform();
	%cannon = $Server::Cannon[%obj._id];

	if (isObject(%cannon)) {
		%trans = MatrixPos(%baseTrans) SPC MatrixRot(%cannon.getTransform());

		%cannon.setTransform(%trans);
		%cannon._baseTrans = %trans;

		%client = getClientSyncObject(%cannon.getSyncId());
		if (isObject(%client)) {
			%client._baseTrans = %trans;
		}

		%cannon.getDatablock().reset(%cannon);
	}
}

function DefaultCannonBase::onAdd(%this, %obj, %tries) {
	//Cancel if we have a previous schedule going
	cancel(%this.findSchedule[%obj]);
	if (!isObject(%obj) || %tries > 10)
		return;

	//Check if the base has a cannon assigned to it
	echo("[Cannon Server]: Looking for cannon for base" SPC %obj);

	//Cannons start at 1
	for (%i = 0; %i <= $Server::Cannons; %i ++) {
		//Fake cannon?
		%cannon = $Server::Cannon[%i];
		if (!isObject(%cannon))
			continue;
		//Check its transformation
		%trans = %cannon._baseTrans;

		if (MatrixPos(%trans) $= MatrixPos(%obj.getTransform()) || (%cannon.basename $= %obj.getName())) {
			//Found it
			echo("[Cannon Server]: Found base for cannon" SPC %i);
			$Server::CannonBase[%i] = %obj;
			%obj._id = %i;
			%obj._cannon = %cannon.getSyncId();
			%cannon._base = %obj.getSyncId();

			%obj.setSync("");
			%cannon.setSync("cannonAdded", %obj);
			return;
		}
	}

	//Couldn't find one. Reschedule it.
	%this.findSchedule[%obj] = %this.schedule(100, onAdd, %obj, %tries ++);
}

function Cannon::reset(%this, %obj) {
	if (%obj._id $= "") {
		return;
	}

	%base = $Server::CannonBase[%obj._id];

	//Move it back so clients update
	%trans = %obj._baseTrans;

	%yaw   = mDegToRad(%obj.yaw);
	%pitch = -mDegToRad(%obj.pitch);

	//Get the cannon's initial position
	%startTrans = MatrixPos(%trans) SPC "1 0 0 0";
	%startTrans = MatrixMultiply(%startTrans, "0 0 0 0 0 1" SPC %yaw);

	//The base's position is found before pitch is applied
	%baseTrans = %startTrans;

	%startTrans = MatrixMultiply(%startTrans, "0 0 0 1 0 0" SPC %pitch);

	//Reset both the cannon and base
	%obj.setTransform(%startTrans);
	if (isObject(%base))
		%base.setTransform(%baseTrans);
}

function Cannon::onInspectApply(%this, %obj) {
	%this.reset(%obj);

	if (%obj.instant == 1)
		%obj.setSkinName("orange");
	else
		%obj.setSkinName(%this.skin);

	if (%obj.getDatablock().cannonForce !$= "") {
		%obj.useCharge = 0;
		%obj.chargeTime = "";
		%obj.force = %this.cannonForce;
	}


	%obj.setSync("cannonAdded", %obj);
}

function resetCannons() {
	//Cannons start at 1
	for (%i = 1; %i <= $Server::Cannons; %i ++) {
		//Fake cannon?
		%cannon = $Server::Cannon[%i];
		if (!isObject(%cannon))
			continue;

		%cannon.getDataBlock().reset(%cannon);
	}

	//Send all clients a reset message
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);

		//Except for fake ones
		if (%client.fake)
			continue;

		//Handled below
		%client.resetCannons();
	}
}

function GameConnection::resetCannons(%this) {
	//All client-sided
	commandToClient(%this, 'ResetCannons', $Server::Cannons);
}

//-----------------------------------------------------------------------------
// Datablocks
//-----------------------------------------------------------------------------

datablock StaticShapeData(Target) {
	className = "TargetShape";
	category = "Cannon";
	shapeFile = "~/data/shapes_pq/Gameplay/Cannon/target.dts";
	skin[0] = "base";
	skin[1] = "cool";
	skin[2] = "red";
	skin[3] = "blue";
	skin[4] = "green";
	skin[5] = "checkpoint";
};

function Target::onAdd(%this, %obj) {
	%obj.setSkinName(%obj.skin);
}

datablock AudioProfile(CannonExplodeSfx) {
	filename    = "~/data/sound/explode1_tweaked.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(CannonExplodeForceSfx) {
	filename = "~/data/sound/CannonLaunch.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ParticleData(CannonParticle) {
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

datablock ParticleEmitterData(CannonEmitter) {
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
	particles = "CannonParticle";
};

datablock ParticleData(CannonSmoke) {
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

datablock ParticleEmitterData(CannonSmokeEmitter) {
	ejectionPeriodMS = 10;
	periodVarianceMS = 0;
	ejectionVelocity = 4;
	velocityVariance = 0.5;
	thetaMin         = 0.0;
	thetaMax         = 180.0;
	lifetimeMS       = 250;
	particles = "CannonSmoke";
};

datablock ParticleData(CannonSparks) {
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

datablock ParticleEmitterData(CannonSparkEmitter) {
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
	particles = "CannonSparks";
};

datablock ExplosionData(CannonSubExplosion1) {
	offset = 1.0;
	emitter[0] = CannonSmokeEmitter;
	emitter[1] = CannonSparkEmitter;
	// Impulse
	impulseRadius = 0;
	impulseForce = 0;
};

datablock ExplosionData(CannonSubExplosion2) {
	offset = 1.0;
	emitter[0] = CannonSmokeEmitter;
	emitter[1] = CannonSparkEmitter;
	// Impulse
	impulseRadius = 0;
	impulseForce = 0;
};

datablock ExplosionData(CannonExplosion) {
	lifeTimeMS = 1200;

	// Volume particles
	particleEmitter = CannonEmitter;
	particleDensity = 80;
	particleRadius = 1;

	// Point emission
	emitter[0] = CannonSmokeEmitter;
	emitter[1] = CannonSparkEmitter;

	// Sub explosion objects
	subExplosion[0] = CannonSubExplosion1;
	subExplosion[1] = CannonSubExplosion2;

	// Camera Shaking
	shakeCamera = true;
	camShakeFreq = "10.0 11.0 10.0";
	camShakeAmp = "1.0 1.0 1.0";
	camShakeDuration = 0.5;
	camShakeRadius = 10.0;

	// Impulse
	impulseRadius = 0;
	impulseForce = 0;

	// Dynamic light
	lightStartRadius = 0.01;
	lightEndRadius = 0;
	lightStartColor = "0.0 0.0 0";
	lightEndColor = "0 0 0";
};


datablock StaticShapeData(DefaultCannon) { // Default cannon
	// Mission editor category
	category = "Cannon";
	className = "Cannon";

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/Cannon/cannon.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	skin = "white";
	explosion = "CannonExplosion";

	customField[0, "field"  ] = "useCharge";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Charge Cannon";
	customField[0, "desc"   ] = "If the player needs to charge the cannon by holding fire.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "chargeTime";
	customField[1, "type"   ] = "int";
	customField[1, "name"   ] = "Charge Time";
	customField[1, "desc"   ] = "How long it takes to fully charge the cannon.";
	customField[1, "default"] = "2000";
	customField[2, "field"  ] = "force";
	customField[2, "type"   ] = "float";
	customField[2, "name"   ] = "Force";
	customField[2, "desc"   ] = "How much force is applied when the cannon fires.";
	customField[2, "default"] = "30";
	customField[3, "field"  ] = "pitch";
	customField[3, "type"   ] = "float";
	customField[3, "name"   ] = "Default Pitch";
	customField[3, "desc"   ] = "Default initial camera pitch (up/down) in degrees. For reference, 0 = straight ahead, 85 = near straight up, -85 = near straight down.";
	customField[3, "default"] = "0";
	customField[4, "field"  ] = "yaw";
	customField[4, "type"   ] = "float";
	customField[4, "name"   ] = "Default Yaw";
	customField[4, "desc"   ] = "Default initial camera yaw (left/right) in degrees. For reference, 0 or 360 = +y direction, 90 = +x direction, 180 = -y direction, 270 = -x direction.";
	customField[4, "default"] = "0";
	customField[5, "field"  ] = "pitchBoundHigh";
	customField[5, "type"   ] = "float";
	customField[5, "name"   ] = "Pitch High Bound";
	customField[5, "desc"   ] = "Absolute maximum degrees for pitch. 85 = near straight up.";
	customField[5, "default"] = "80";
	customField[6, "field"  ] = "pitchBoundLow";
	customField[6, "type"   ] = "float";
	customField[6, "name"   ] = "Pitch Low Bound";
	customField[6, "desc"   ] = "Absolute minimum degrees for pitch. -85 = near straight down.";
	customField[6, "default"] = "-30";
	customField[7, "field"  ] = "yawLimit";
	customField[7, "type"   ] = "boolean";
	customField[7, "name"   ] = "Use Yaw Limits";
	customField[7, "desc"   ] = "If the yaw limits should be enabled";
	customField[7, "default"] = "1";
	customField[8, "field"  ] = "yawBoundLeft";
	customField[8, "type"   ] = "float";
	customField[8, "name"   ] = "Yaw Left Bound";
	customField[8, "desc"   ] = "Maximum degrees left you can point relative to the starting yaw. 180 = straight backwards.";
	customField[8, "default"] = "70";
	customField[9, "field"  ] = "yawBoundRight";
	customField[9, "type"   ] = "float";
	customField[9, "name"   ] = "Yaw Right Bound";
	customField[9, "desc"   ] = "Maximum degrees right you can point relative to the starting yaw. 180 = straight backwards.";
	customField[9, "default"] = "70";
	customField[10, "field"  ] = "instant";
	customField[10, "type"   ] = "boolean";
	customField[10, "name"   ] = "Instant Cannon";
	customField[10, "desc"   ] = "If the cannon fires instantly on enter.";
	customField[10, "default"] = "0";
	customField[11, "field"  ] = "instantDelayTime";
	customField[11, "type"   ] = "time";
	customField[11, "name"   ] = "Instant Delay Time";
	customField[11, "desc"   ] = "Delay fire for an instant cannon by this much.";
	customField[11, "default"] = "0";
	customField[12, "field"  ] = "useBase";
	customField[12, "type"   ] = "boolean";
	customField[12, "name"   ] = "Create Cannon Base";
	customField[12, "desc"   ] = "If a base should be created for this cannon (if none exists).";
	customField[12, "default"] = "1";
	customField[13, "field"  ] = "lockTime";
	customField[13, "type"   ] = "time";
	customField[13, "name"   ] = "Controls Lock Time";
	customField[13, "desc"   ] = "For how long after firing controls are locked.";
	customField[13, "default"] = "0";
	customField[14, "field"  ] = "lockCam";
	customField[14, "type"   ] = "boolean";
	customField[14, "name"   ] = "Also Lock Camera";
	customField[14, "desc"   ] = "If the camera should be locked after firing too.";
	customField[14, "default"] = "0";
	customField[15, "field"  ] = "basename";
	customField[15, "type"   ] = "string";
	customField[15, "name"   ] = "Base Object Name";
	customField[15, "desc"   ] = "Name of the object which is this cannon's base.";
	customField[15, "default"] = "";
	customField[16, "field"  ] = "showReticle";
	customField[16, "type"   ] = "boolean";
	customField[16, "name"   ] = "Show Reticle";
	customField[16, "desc"   ] = "Show a reticle in the center that displays the cannon's power.";
	customField[16, "default"] = "0";
	customField[17, "field"  ] = "showAim";
	customField[17, "type"   ] = "boolean";
	customField[17, "name"   ] = "Show Aim Assist";
	customField[17, "desc"   ] = "Show rings for helping players to aim. NOTE: May be inaccurate over long distances or with gravity changes/triggers.";
	customField[17, "default"] = "1";
	customField[18, "field"  ] = "aimSize";
	customField[18, "type"   ] = "float";
	customField[18, "name"   ] = "Aim Assist Radius";
	customField[18, "desc"   ] = "Radius of the rings used for aim assist. Marble radius is 0.2";
	customField[18, "default"] = "0.25";
	customField[19, "field"  ] = "aimTriggers";
	customField[19, "type"   ] = "boolean";
	customField[19, "name"   ] = "Aim Assist PhysMod";
	customField[19, "desc"   ] = "Account for PhysMod triggers with the aim assist rings... Adds significant lag though.";
	customField[19, "default"] = "false";
};

datablock StaticShapeData(Cannon_Low : DefaultCannon) { // Green; force = 20
	skin = "green";
	cannonForce = 20;
	customField[0, "disable"] = 1;
	customField[1, "disable"] = 1;
	customField[2, "disable"] = 1;
};

datablock StaticShapeData(Cannon_Mid : DefaultCannon) { // Blue; force = 35
	skin = "blue";
	cannonForce = 35;
	customField[0, "disable"] = 1;
	customField[1, "disable"] = 1;
	customField[2, "disable"] = 1;
};

datablock StaticShapeData(Cannon_High : DefaultCannon) { // Red; force = 50
	skin = "red";
	cannonForce = 50;
	customField[0, "disable"] = 1;
	customField[1, "disable"] = 1;
	customField[2, "disable"] = 1;
};

datablock StaticShapeData(Cannon_Custom : DefaultCannon) { // White
	skin = "white";
};

datablock StaticShapeData(DefaultCannonBase) { //base
	className = "CannonBase";
	category = "Cannon";
	shapeFile = "~/data/shapes_pq/Gameplay/Cannon/base.dts";
};

function Cannon::explode(%this, %obj) {

	// Play the forceful sound effect when we have cannon force >= 200
	if (%obj.force >= 200)
		serverPlay3D(CannonExplodeForceSfx, %obj.getPosition());
	else
		serverPlay3D(CannonExplodeSfx, %obj.getPosition());

	%obj.setDamageState("Destroyed");
	%obj.schedule(1000, "setDamageState", "Enabled");
}

//Copied from PQ
function Cannon::initFields(%this, %obj) {
	// ------------
	// Cannon Values
	// ------------

	if (%obj.useCharge $= "")   // Use "hold click to charge" mode.
		%obj.useCharge = 0;

	if (%obj.getDatablock().cannonForce !$= "") {
		%obj.chargeTime = "";
		%obj.force = "";
	} else {
		if (%obj.chargeTime $= "")  //Amount of time until max charge (only if useCharge == 1)
			%obj.chargeTime = 2000;
		if (%obj.force $= "") // Launch force
			%obj.force = 30;
	}

	//Datablock overrides objects
	if (%obj.getDataBlock().cannonForce !$= "")
		%obj.force = %obj.getDataBlock().cannonForce;

	if (%obj.pitch $= "") // Starting yaw and pitch values, in degrees. Pitch = aim up/down; yaw = aim left/right
		%obj.pitch = 0;    // These values are used to set rotation of the cannon upon mission load / restart.
	if (%obj.yaw $= "")   // The cannon does not use saved Torque rotation values.
		%obj.yaw = 0;      // Both Pitch and Yaw are absolute.
	// For reference: 0° or 360°	= +y direction
	//                90°       	= +x direction
	//   (YAW)        180°      	= -y direction
	//                270°      	= -x direction
	// Please do not use negative values for yaw!
	// In order to lock yaw, set both bounds to 0.  This will fire in the direction of base yaw.

	// For reference: 0° 	= straight ahead
	//                85°	= near straight up
	//   (PITCH)     -80° 	= near straight down


	if (%obj.pitchBoundHigh $= "") // The boundaries of pitch, in degrees. (looking up/down)
		%obj.pitchBoundHigh = 80;   // Both values are absolute. Let's look at the default values.
	if (%obj.pitchBoundLow $= "")  // PitchBoundHigh of 80 means the cannon cannot aim above 80∞ upwards.
		%obj.pitchBoundLow = -30;   // PitchBoundLow of -30 means the cannon cannot aim below 30∞ downwards.

	if (%obj.yawBoundLeft $= "")   // The boundaries of yaw, in degrees. (looking left/right)
		%obj.yawBoundLeft = 70;     // Both values are relative.  This means they are added/subtracted to/from the starting yaw value.
	if (%obj.yawBoundRight $= "")  // YawBoundLeft of 70 means you can look left 70∞ from the starting angle.
		%obj.yawBoundRight = 70;    // YawBoundRight of 70 means you can look right 70∞ from the starting angle.

	if (%obj.yawLimit $= "")       // Enable the yaw limits. (1 or 0)
		%obj.yawLimit = 1;          // If disabled, cannon can rotate freely.

	if (%obj.instant $= "")        // Instant fire on touch cannon, optional delay below.
		%obj.instant = 0;

	if (%obj.instantDelayTime $= "")  // Delay time for instant launch.
		%obj.instantDelayTime = 0;

	if (%obj.useBase $= "")   // Spawn base true/false
		%obj.useBase = 1;

	if (%obj.lockTime $= "")  // Time (in ms) to lock controls after firing
		%obj.lockTime = 0;

	if (%obj.lockCam $= "")   // Also lock camera controls (1 or 0)
		%obj.lockCam = 0;

	if (%obj.showReticle $= "")   // Show the reticle
		%obj.showReticle = 0;

	if (%obj.showAim $= "")   // Show the aiming rings
		%obj.showAim = 1;

	if (%obj.aimSize $= "")   // Aiming ring radius
		%obj.aimSize = 0.25;

	if (%obj.aimTriggers $= "")   // Aiming using physmod
		%obj.aimTriggers = false;

	if (%obj.basename $= "" && %obj.useBase) { // Spawn a base and place it with cannon
		%name = "CBase0";
		%num = 0;
		while (isObject(%name)) { // Assign it a name
			%name = "CBase" @ %num;
			%num ++;
		}

		new StaticShape(%name) {
			position = %obj.getPosition();
			rotation = "1 0 0 0";
			scale = %obj.getScale();
			dataBlock = "DefaultCannonBase";
		};
		MissionGroup.add(%name);
		%obj.basename = %name;
	}

	if (%obj.instant == 1)
		%obj.setSkinName("orange");
	else
		%obj.setSkinName(%this.skin);
}

$Editor::Fields["Cannon"] =
	"useCharge" SPC
	"chargeTime" SPC
	"force" SPC
	"yaw" SPC
	"pitch" SPC
	"pitchBoundLow" SPC
	"pitchBoundHigh" SPC
	"yawBoundLeft" SPC
	"yawBoundRight" SPC
	"yawLimit" SPC
	"instant" SPC
	"instantDelayTime" SPC
	"useBase" SPC
	"lockTime" SPC
	"lockCam" SPC
	"basename" SPC
	"showReticle" SPC
	"showAim" SPC
	"aimSize" SPC
	"aimTriggers";