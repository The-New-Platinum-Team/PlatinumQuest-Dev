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


//-----------------------------------------------------------------------------
//Start of Particle System Option
//-----------------------------------------------------------------------------

if ($pref::Video::particleSystem == 2) {

	datablock ParticleData(BounceParticle)	{
		textureName          = "~/data/particles/mbu/smoke";
		dragCoeffiecient     = 0.5;
		gravityCoefficient   = -0.1;
		windCoefficient      = 0;
		inheritedVelFactor   = 0;
		constantAcceleration = -2;
		lifetimeMS           = 400;
		lifetimeVarianceMS   = 50;
		useInvAlpha =  false;
		spinSpeed     = 90;
		spinRandomMin = -90.0;
		spinRandomMax =  90.0;

		colors[0]     = "0.5 0.5 0.5 0.3";
		colors[1]     = "0.3 0.3 0.2 0.1";
		colors[2]     = "0.2 0.2 0.1 0.0";

		sizes[0]      = 0.4;
		sizes[1]      = 0.2;
		sizes[2]      = 0.1;

		times[0]      = 0;
		times[1]      = 0.75;
		times[2]      = 1.0;
	};

	datablock ParticleEmitterData(MarbleBounceEmitter)	{
		ejectionPeriodMS = 10;
		periodVarianceMS = 0;
		ejectionVelocity = 6.0;
		velocityVariance = 0.25;
		thetaMin         = 80.0;
		thetaMax         = 90.0;
		lifetimeMS       = 250;
		particles = "BounceParticle";
	};

} else if ($pref::Video::particleSystem == 1) {

	datablock ParticleData(BounceParticle)	{
		textureName          = "~/data/particles/star";
		dragCoeffiecient     = 1.0;
		gravityCoefficient   = 0;
		windCoefficient      = 0;
		inheritedVelFactor   = 0;
		constantAcceleration = -2;
		lifetimeMS           = 500;
		lifetimeVarianceMS   = 100;
		useInvAlpha =  true;
		spinSpeed     = 90;
		spinRandomMin = -90.0;
		spinRandomMax =  90.0;

		colors[0]     = "0.9 0.0 0.0 1.0";
		colors[1]     = "0.9 0.9 0.0 1.0";
		colors[2]     = "0.9 0.9 0.0 0.0";

		sizes[0]      = 0.25;
		sizes[1]      = 0.25;
		sizes[2]      = 0.25;

		times[0]      = 0;
		times[1]      = 0.75;
		times[2]      = 1.0;
	};

	datablock ParticleEmitterData(MarbleBounceEmitter)	{
		ejectionPeriodMS = 80;
		periodVarianceMS = 0;
		ejectionVelocity = 3.0;
		velocityVariance = 0.25;
		thetaMin         = 80.0;
		thetaMax         = 90.0;
		lifetimeMS       = 250;
		particles = "BounceParticle";
	};

} else {

	datablock ParticleData(BounceParticle) {
		textureName          = "~/data/particles/star";
		dragCoeffiecient     = 1.0;
		gravityCoefficient   = 0;
		windCoefficient      = 0;
		inheritedVelFactor   = 0;
		constantAcceleration = -2;
		lifetimeMS           = 500;
		lifetimeVarianceMS   = 100;
		useInvAlpha =  true;
		spinSpeed     = 90;
		spinRandomMin = -90.0;
		spinRandomMax =  90.0;

		colors[0]     = "0.9 0.0 0.0 1.0";
		colors[1]     = "0.9 0.9 0.0 1.0";
		colors[2]     = "0.9 0.9 0.0 0.0";

		sizes[0]      = 0.25;
		sizes[1]      = 0.25;
		sizes[2]      = 0.25;

		times[0]      = 0;
		times[1]      = 0.75;
		times[2]      = 1.0;
	};

	datablock ParticleEmitterData(MarbleBounceEmitter) 
	{
		ejectionPeriodMS = 80;
		periodVarianceMS = 0;
		ejectionVelocity = 3.0;
		velocityVariance = 0.25;
		thetaMin         = 80.0;
		thetaMax         = 90.0;
		lifetimeMS       = 250;
		particles = "BounceParticle";
	};
}

//-----------------------------------------------------------------------------
//End of Particle System Option
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// these aren't used but we are keeping them so the engine don't go
// KABOOM
//
// Reason for not using them: they aren't sexy enough.

// datablock ParticleData(TrailParticle) {
// 	textureName          = "~/data/particles/smoke";
// 	dragCoeffiecient     = 1.0;
// 	gravityCoefficient   = 0;
// 	windCoefficient      = 0;
// 	inheritedVelFactor   = 1;
// 	constantAcceleration = 0;
// 	lifetimeMS           = 100;
// 	lifetimeVarianceMS   = 10;
// 	useInvAlpha =  true;
// 	spinSpeed     = 0;

// 	colors[0]     = "1 1 0 0.0";
// 	colors[1]     = "1 1 0 1";
// 	colors[2]     = "1 1 1 0.0";

// 	sizes[0]      = 0.7;
// 	sizes[1]      = 0.4;
// 	sizes[2]      = 0.1;

// 	times[0]      = 0;
// 	times[1]      = 0.15;
// 	times[2]      = 1.0;
// };

datablock ParticleEmitterData(MarbleTrailOldEmitter) {
   ejectionPeriodMS = 5;
   periodVarianceMS = 0;
   ejectionVelocity = 0.0;
   velocityVariance = 0.25;
   thetaMin         = 80.0;
   thetaMax         = 90.0;
   lifetimeMS       = 10000;
   particles = "TrailParticle";
};

//-----------------------------------------------------------------------------

datablock ParticleData(SuperJumpParticle) {
	textureName          = "~/data/particles/twirl";
	dragCoefficient      = 0.25;
	gravityCoefficient   = 0;
	inheritedVelFactor   = 0.1;
	constantAcceleration = 0;
	lifetimeMS           = 1000;
	lifetimeVarianceMS   = 150;
	spinSpeed     = 90;
	spinRandomMin = -90.0;
	spinRandomMax =  90.0;

	colors[0]     = "0 0.5 1 0";
	colors[1]     = "0 0.6 1 1.0";
	colors[2]     = "0 0.6 1 0.0";

	sizes[0]      = 0.25;
	sizes[1]      = 0.25;
	sizes[2]      = 0.5;

	times[0]      = 0;
	times[1]      = 0.75;
	times[2]      = 1.0;
};

datablock ParticleEmitterData(MarbleSuperJumpEmitter) {
	ejectionPeriodMS = 10;
	periodVarianceMS = 0;
	ejectionVelocity = 1.0;
	velocityVariance = 0.25;
	thetaMin         = 150.0;
	thetaMax         = 170.0;
	lifetimeMS       = 5000;
	particles = "SuperJumpParticle";
};

//-----------------------------------------------------------------------------

datablock ParticleData(SuperSpeedParticle) {
	textureName          = "~/data/particles/powerup/spark";
	dragCoefficient      = 0.25;
	gravityCoefficient   = 0;
	inheritedVelFactor   = 0.25;
	constantAcceleration = 0;
	lifetimeMS           = 1500;
	lifetimeVarianceMS   = 150;

	// I've always felt the super speed's colour is too yellow, and feels more suited to MBG.
	// These changes make it closer to a white colour:
	colors[0]     = "0.8 0.8 0.2 0.0";
	colors[1]     = "0.8 0.8 0.2 1.0";
	colors[2]     = "0.8 0.8 0.2 0.0";

	sizes[0]      = 0.25;
	sizes[1]      = 0.25;
	sizes[2]      = 1.0;

	times[0]      = 0;
	times[1]      = 0.25;
	times[2]      = 1.0;
};

datablock ParticleEmitterData(MarbleSuperSpeedEmitter) {
	ejectionPeriodMS = 5;
	periodVarianceMS = 0;
	ejectionVelocity = 1.0;
	velocityVariance = 0.25;
	thetaMin         = 130.0;
	thetaMax         = 170.0;
	lifetimeMS       = 5000;
	particles = "SuperSpeedParticle";
};

//--- Particle ---
datablock ParticleData(MarbleTrailBubbleParticle) {
	dragCoefficient = "1.176";
	windCoefficient = "0";
	gravityCoefficient = "-0.176";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = 1000;
	lifetimeVarianceMS = "176";
	spinSpeed = "1";
	spinRandomMin = "0";
	spinRandomMax = "0.5";
	useInvAlpha = "0";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "~/data/particles/bubble";
	colors[0] = "0.843137 0.833333 0.843137 1.000000";
	colors[1] = "0.784314 0.813725 0.882353 1.000000";
	colors[2] = "0.843137 0.862745 0.892157 1.000000";
	colors[3] = "0.892157 0.911765 0.980392 0.000000";
	sizes[0] = "0";
	sizes[1] = "0.05";
	sizes[2] = "0.1";
	sizes[3] = "0.3";
	times[0] = "0";
	times[1] = "0.0212202";
	times[2] = "0.93756";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(MarbleTrailBubbleEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "20";
	periodVarianceMS = "19";
	ejectionVelocity = "0";
	velocityVariance = "0";
	ejectionOffset = "0.2";
	thetaMin = "0";
	thetaMax = "61.7647";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "1";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "MarbleTrailBubbleParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};

datablock ParticleEmitterNodeData(ParticleTrailNode) {
	timeMultiple = 1.003;
};

//-----------------------------------------------------------------------------
// ActivePowerUp
// 0 - no active powerup
// 1 - Super Jump
// 2 - Super Speed
// 3 - Super Bounce
// 4 - Indestructible

datablock AudioProfile(Bounce1Sfx) {
	filename    = "~/data/sound/bouncehard1.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(Bounce2Sfx) {
	filename    = "~/data/sound/bouncehard2.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(Bounce3Sfx) {
	filename    = "~/data/sound/bouncehard3.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(Bounce4Sfx) {
	filename    = "~/data/sound/bouncehard4.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(JumpSfx) {
	filename    = "~/data/sound/Jump.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(RollingHardSfx) {
	filename    = "~/data/sound/Rolling_Hard.wav";
	description = AudioClosestLooping3d;
	preload = true;
};

datablock AudioProfile(SlippingSfx) {
	filename    = "~/data/sound/Sliding.wav";
	description = AudioClosestLooping3d;
	preload = true;
};

datablock MarbleData(DefaultMarble) {
	shapeFile = "~/data/shapes/balls/ball-superball.dts";
	emap = true;
	renderFirstPerson = true;
// maxRollVelocity = 55;
// angularAcceleration = 120;
	maxRollVelocity = 15;
	angularAcceleration = 75;
	brakingAcceleration = 30;
	gravity = ($Game::Gravity $= "" ? 20 : $Game::Gravity);
	staticFriction = 1.1;
	kineticFriction = 0.7;
	bounceKineticFriction = 0.2;
	maxDotSlide = 0.5;
	bounceRestitution = 0.5;
	jumpImpulse = ($Game::JumpImpulse $= "" ? 7.5 : $Game::JumpImpulse);
	maxForceRadius = 50;

	scale      = 0.18975;
	goldScale  = 0.2;
	ultraScale = 0.3;
	megaScale  = 0.6666;

	bounce1 = Bounce1Sfx;
	bounce2 = Bounce2Sfx;
	bounce3 = Bounce3Sfx;
	bounce4 = Bounce4Sfx;

	rollHardSound = RollingHardSfx;
	slipSound = SlippingSfx;
	jumpSound = JumpSfx;

	// Emitters
	// 1.50 update: changed minTrailSpeed to 20
	// WE use our own, lets make it impossible to have!!!!
	minTrailSpeed = 10;            // Trail threshold
	trailEmitter = MarbleTrailOldEmitter;

	minBounceSpeed = 3;           // Bounce threshold
	bounceEmitter = MarbleBounceEmitter;

	powerUpEmitter[1] = MarbleSuperJumpEmitter; 		// Super Jump
	powerUpEmitter[2] = MarbleSuperSpeedEmitter; 	// Super Speed
// powerUpEmitter[3] = MarbleSuperBounceEmitter; 	// Super Bounce
// powerUpEmitter[4] = MarbleShockAbsorberEmitter; 	// Shock Absorber

	// 1.50 update: helicopter now has an emitter.  But we still don't use
	// this, have a new way of doing it.
// powerUpEmitter[5] = MarbleHelicopterEmitter; 	// Helicopter

	// Power up timouts. Timeout on the speed and jump only affect
	// the particle trail
	// 1.50 update: helicopter now has emitter.  it is the same time
	// as powerupTime[5]
	powerUpTime[1] = 1000;	// Super Jump
	powerUpTime[2] = 1000; 	// Super Speed
	powerUpTime[3] = 5000; 	// Super Bounce
	powerUpTime[4] = 5000; 	// Shock Absorber
	powerUpTime[5] = 5000; 	// Helicopter
	_powerUpTime[6] = 10000;	// Mega Marble

	powerUpData[1] = SuperJumpItem;
	powerUpData[2] = SuperSpeedItem;
	powerUpData[3] = SuperBounceItem;
	powerUpData[4] = ShockAbsorberItem;
	powerUpData[5] = HelicopterItem;

	// Allowable Inventory Items
	maxInv[SuperJumpItem] = 20;
	maxInv[SuperSpeedItem] = 20;
	maxInv[SuperBounceItem] = 20;
	maxInv[IndestructibleItem] = 20;
	maxInv[TimeTravelItem] = 20;
//   maxInv[GoodiesItem] = 10;

	// new fields for multiplayer.

	// Impact forces for collision
	//Not Mega marble
	impactRadius[false] = 0.27; //Do not touch
	impactMinimum[false] = 0.3;
	impactMultiplier[false] = $MP::Collision::Multiplier; //Works best
	impactMaximum[false] = $MP::Collision::Maximum;
	impactReduction[false] = 0.25;
	impactBounceBack[false] = 0.5;

	impactRadius[true] = 0.93;
	impactMinimum[true] = 0.1;
	impactMultiplier[true] = $MP::Collision::MegaMultiplier;
	impactMaximum[true] = $MP::Collision::MegaMaximum;
	impactReduction[true] = 0.1;
	impactBounceBack[true] = 0.10;

	blastModifier = $MP::NormalBlastModifier; //Multiplies blast values by this
};

datablock MarbleData(CustomMarble : DefaultMarble) {
	shapeFile = getField(MarbleSelectDlg.getSelection(), 0);
	skin = getField(MarbleSelectDlg.getSelection(), 1);
};
// doing this for lb marble
datablock MarbleData(LBDefaultMarble : DefaultMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/ball-superball.dts";
};
datablock MarbleData(LB3DMarble : DefaultMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/3dMarble.dts";
};
datablock MarbleData(LBMidPMarble : DefaultMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/midp.dts";
};
datablock MarbleData(LBGarageGamesMarble : DefaultMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/garageGames.dts";
};
datablock MarbleData(LBPack1Marble : DefaultMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/pack1/pack1marble.dts";
};

function createMarbleDatablocks() {
	for (%i = 0; %i < MarbleSelectDlg.lists.getSize(); %i ++) {
		%list = MarbleSelectDlg.lists.getEntry(%i);
		%base = %list.base;
		%array = %list.marbles;

		for (%j = 0; %j < %array.getSize(); %j ++) {
			%marble = %array.getEntry(%j);
			%shape = %marble.shape;
			%file = %base @ "/" @ %shape;

			%dataname = "CustomMarble" @ %i @ "_" @ %j;
			$MarbleDatablock[%file] = %dataname;

			if (!isObject(%dataname)) {
				//First we need to create the datablock without parenting fields because
				// otherwise it will inherit the marble radius as well. But only if the
				// parent is larger. Because sure that's fine.

				//So create an empty one first
				eval("new MarbleData(TempData) {" @
					"shapeFile = \"" @ expandEscape(%file) @ "\";" @
				"};");
				//And steal its collision radius
				%size = TempData.getCollisionRadius();
				//Cleaning up
				TempData.delete();
				//Create new marble datablocks for every shape file (probably won't create
				// too many datablocks for MB to handle. We didn't need to load quickly)
				eval("datablock MarbleData(" @ %dataname @ " : LBDefaultMarble) {"@
					"shapeFile = \"" @ expandEscape(%file) @ "\";" @
				"};");
				//And set the new db's radius to the value we got above
				%dataname.setCollisionRadius(%size);
			}
		}
	}
}

function findMarbleDatablock(%shapeFile) {
	%dataname = $MarbleDatablock[%shapeFile];
	if (!isObject(%dataname)) {
		return LBDefaultMarble;
	}
	return %dataname;
}

//Dedicated servers create these datablocks after downloading the marble list
if (!$Server::Dedicated) {
	createMarbleDatablocks();
}

//------------------------------------------------------------------------------

// datablock AudioProfile(MegaBounce1Sfx) {
// 	filename    = "~/data/sound/mega_bouncehard1.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };

// datablock AudioProfile(MegaBounce2Sfx) {
// 	filename    = "~/data/sound/mega_bouncehard2.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };

// datablock AudioProfile(MegaBounce3Sfx) {
// 	filename    = "~/data/sound/mega_bouncehard3.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };

// datablock AudioProfile(MegaBounce4Sfx) {
// 	filename    = "~/data/sound/mega_bouncehard4.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };

// datablock AudioProfile(MegaJumpSfx) {
// 	filename    = "~/data/sound/Jump.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };

// datablock AudioProfile(MegaRollingHardSfx) {
// 	filename    = "~/data/sound/mega_roll.wav";
// 	description = AudioClosestLooping3d;
// 	preload = true;
// };

// datablock AudioProfile(MegaSlippingSfx) {
// 	filename    = "~/data/sound/Sliding.wav";
// 	description = AudioClosestLooping3d;
// 	preload = true;
// };

//-----------------------------------------------------------------------------

function MarbleData::onAdd(%this, %obj) {
	//echo("New Marble: " @ %obj);
}

function MarbleData::onTrigger(%this, %obj, %triggerNum, %val) {
}


//-----------------------------------------------------------------------------

function MarbleData::onCollision(%this,%obj,%col) {
	if (%obj.noPickup || ($playingDemo && !$Playback::DemoFrame))
		return;

	// Try and pickup all items
	if (%col.getClassName() $= "Item") {
		// No after-finish pickups (sorry, Me)
		if (%obj.client.state $= "End")
			return;

		if ($Editor::Opened && $LB::LoggedIn)
			return;

		%data = %col.getDatablock();
		if (%obj.pickup(%col,1)) {
			commandToClient(%obj.client, 'ItemPickup', %col.getSyncId());

			if ($Record::Recording) {
				recordWriteTime(RecordFO);
				recordWritePickup(RecordFO, %data.getName(), %col.getPosition());
			}
		}
	}
}

function GameBaseData::onCollision(%this, %obj, %col, %vec, %vecLen, %material) {
	if (%col.noPickup || ($playingDemo && !$Playback::DemoFrame))
		return false;

	if ($Record::Recording) {
		recordWriteTime(RecordFO);
		recordWriteCollision(RecordFO, %this.getName(), %obj.getPosition());
	}

	return true;
}

//-----------------------------------------------------------------------------
// The following event callbacks are punted over to the connection
// for processing

function MarbleData::onEnterPad(%this,%object) {
	%object.client.onEnterPad();
}

function MarbleData::onLeavePad(%this,%object) {
	%object.client.onLeavePad();
}

function MarbleData::onStartPenalty(%this,%object) {
	%object.client.onStartPenalty();
}

function MarbleData::onOutOfBounds(%this,%object) {
	%object.client.onOutOfBounds();
}

function MarbleData::setCheckpoint(%this,%object,%check) {
	%object.client.setCheckpoint(%check);
}

//-----------------------------------------------------------------------------
// Marble object
//-----------------------------------------------------------------------------

function Marble::setPowerUp(%this,%item,%reset,%obj) {
	if (%this.lockPowerup) {
		%this.heldPowerup = %item;
		%this.powerUpData = "";
		%this.setPowerUpId("0", %reset);
		return;
	}

	echo("Server " @ %this @ " setting powerup to " @ %item.powerUpId @ " / " @ %obj @ " reset: " @ %reset);

	cancel(%this.powerupRespawn);
	if (!$MPPref::FastPowerups || $Server::ServerType $= "SinglePlayer" || %this.client.isHost()) {
		commandToClient(%this.client, 'SetPowerUp', %item.shapeFile, %item.powerUpId, (isObject(%obj) ? %obj.getSkinName() : ""));
		%this.powerUpData = %item;
	}

	//Send to spectators
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.spectating)
			continue;

		commandToClient(%client, 'SpectatePowerUp', %this.client.index, %this.client.getUsername(), %item.shapeFile);
	}

	%this.heldPowerup = %item;

	if (%item.powerUpId > 5) {
		%this.setPowerUpId(0, false);
		%this.powerUpId = %item.powerUpId;
		%this.powerUpObj = %obj;

		if (%item.client) {
			%this.hasClientPowerup = true;
			commandToClient(%this.client, 'PickupClientPowerup', %item.getName(), %reset, %obj.getSyncId(), %obj.getDatablock().getData(%obj));
		} else if (%this.hasClientPowerup) {
			%this.hasClientPowerup = false;
			commandToClient(%this.client, 'ResetClientPowerup', %item.getName(), %reset);
		}

		return;
	} else if (%this.hasClientPowerup) {
		//Non-custom powerups are never cliented
		%this.hasClientPowerup = false;
		commandToClient(%this.client, 'ResetClientPowerup', %item.getName(), %reset);
	}

	if (!$MPPref::FastPowerups || $Server::ServerType $= "SinglePlayer" || (!$Server::Dedicated && %this.client.isHost()))
		%this.setPowerUpId(%item.powerUpId,%reset);
}

function Marble::getPowerUp(%this) {
	return (isObject(%this.powerUpData) ? %this.powerUpData.getId() : %this.powerUpData);
}

function GameConnection::activatePowerup(%this, %powerUpId) {
	%this.player.powerupActive[%powerupId] = true;
	commandToClient(%this, 'ActivatePowerUp', %powerUpId);
}

function GameConnection::deactivatePowerup(%this, %powerUpId) {
	%this.player.powerupActive[%powerupId] = false;
	commandToClient(%this, 'DeactivatePowerUp', %powerUpId);
}

function GameConnection::mountPlayerImage(%this, %powerUp, %slot) {
	%image = %powerUp.image;
	if (%this.isMegaMarble() && %powerUp.megaImage !$= "") {
		%image = %powerUp.megaImage;
	} else if ((MissionInfo.useUltraMarble $= "1") && %powerUp.image $= "HelicopterImage_MBU") {
		%image = %powerUp.ultraImage;
	}

	// These are hard-coded into the engine (shame on you, GG)
//	if (%image $= "HelicopterImage" || %image $= "SuperBounceImage" || %image $= "ShockAbsorberImage")
//		return;
	%this.player.mountImage(%image, %slot);
}

function GameConnection::unmountPlayerImage(%this, %slot) {
	%this.player.unmountImage(%slot);
}

// changed %obj to %this
function Marble::onPowerUpUsed(%this) {
	%used = true;
	if (isObject(%this.powerUpData)) {
		%used = %this.powerUpData.onUse(%this.powerUpObj, %this);
	}

	if (!%used) {
		return;
	}

	if ($Server::ServerType $= "SinglePlayer" || !$MPPref::FastPowerups || %this.client.isHost())
		commandToClient(%this.client, 'SetPowerUp', "", 0);

	//Send to spectators
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.spectating)
			continue;

		commandToClient(%client, 'SpectatePowerUp', %this.client.index, %this.client.getUsername(), "");
	}

	%this.powerUpObj = "";
	%this.powerUpId = "";
	%this.heldPowerup = "";
	%this.powerUpData = "";
	%this.oldPowerupData = "";
	%this.oldPowerupObj = "";
}

function serverCmdUsePowerup(%client) {
	%client.player.onPowerUpUsed();
}

function serverCmdOnPowerUpUsed(%client, %id) {
	//They used the pup; do stuff from it
	if (Mode::callback("shouldUseClientPowerups", false)) {
		echo("Fast mode: " @ %client.getUsername() @ " used a " @ %client.player.getDatablock().powerUpData[%id].getName());
		commandToAllExcept(%client, 'ClientPowerUp', %client.index, %id);
	}
}

function Marble::lockPowerup(%this, %time, %reset) {
//	HUD_PowerupFrame.setBitmap("pqport/client/ui/PlayGui/powerup_locked.png");
	%this.lockPowerup = 1;
	%this.setPowerUp(%this.heldPowerup, %reset, 1);

	commandToClient(%this.client, 'LockPowerup', true);

	cancel(%this.unlockSchedule);
	if (%time)
		%this.unlockSchedule = %this.schedule(%time, "unlockPowerup");
}

function Marble::unlockPowerup(%this, %time) {
	cancel(%this.unlockSchedule);
	if (%time) {
		%this.unlockSchedule = %this.schedule(%time, "unlockPowerup");
		return;
	}

	commandToClient(%this.client, 'LockPowerup', false);

//	HUD_PowerupFrame.setBitmap("pqport/client/ui/PlayGui/powerup.png");
	%this.lockPowerup = 0;
	%this.setPowerUp(%this.heldPowerup);
}

//-----------------------------------------------------------------------------

function onMarbleDataPreSend(%datablock) {
	if ($Server::_Dedicated)
		return;
	if (!isObject(MarbleDatablockAttributesArray))
		return;

	// save the attribute values on the marble
	%count = MarbleDatablockAttributesArray.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%attribute = MarbleDatablockAttributesArray.getEntry(%i);
		$Temp::MarbleAttribute[%i] = %datablock.getFieldValue(%attribute);
	}
}

function onMarbleDataPostSend(%datablock) {
	if ($Server::_Dedicated)
		return;
	if (!isObject(MarbleDatablockAttributesArray))
		return;

	// restore attribute on the datablock
	%count = MarbleDatablockAttributesArray.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%attribute = MarbleDatablockAttributesArray.getEntry(%i);
		%datablock.setFieldValue(%attribute, $Temp::MarbleAttribute[%i]);
	}
	deleteVariables("$Temp::MarbleAttribute*");
}

//-----------------------------------------------------------------------------

function Marble::assignNewTrailEmitter(%this, %slot, %type, %emitter) {
	%emit = new ParticleEmitterNode() {
		datablock = ParticleTrailNode;
		emitter   = %emitter;
		position  = "-9999999 -9999999 -99999999";
		rotation  = "1 0 0 0";
		scale     = "1 1 1";
		type      = %type;
		trail     = true;
		attachId  = %this.getSyncId();
	};
	%emit.setScopeAlways(); //So the client can tell it when to appear/disappear
	%emit.setSync();
	MissionCleanup.add(%emit);
	%this.trailEmitter[%slot] = %emit;
	%this.trailEmitters = max(%this.trailEmitters, %slot + 1);

	return %emit;
}