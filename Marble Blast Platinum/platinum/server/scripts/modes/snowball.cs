//-----------------------------------------------------------------------------
// Snowball mode for Aayrl <3
//
// Copyright (c) 2014 The Platinum Team
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

function Mode_snowball::onLoad(%this) {
	%this.registerCallback("onCreatePlayer");
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onPlayerJoin");
	%this.registerCallback("modifyPlayerScoreData");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_snowball::onMissionLoaded(%this) {
	initSnow();
	initSnowParticles();
}
function Mode_snowball::onMissionEnded(%this) {
	resetSnowParticles();
}
function Mode_snowball::onPlayerJoin(%this, %object) {
	commandToClient(%object.client, 'SnowballsOnly', $MP::Server::SnowballsOnly);
}
function Mode_snowball::onMissionReset(%this) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		ClientGroup.getObject(%i).snowballs = 0;
		ClientGroup.getObject(%i).snowballhits = 0;
	}
}
function Mode_snowball::onCreatePlayer(%this, %data) {
	%client = %data.client;
	%client.createGhostHat(SantaHatImage, SantaHatLargeImage);
}
function Mode_snowball::modifyPlayerScoreData(%this, %object) {
	%data = %object.data @ "&scores[snowballs][]=" @ %object.client.snowballs;
	%data = %data @ "&scores[snowballhits][]=" @ %object.client.snowballhits;
	return %data;
}

package Mode_snowball {
	function IceShard::onCollision(%this, %ice, %marble, %unused1, %unused2, %material) {
		if (!Parent::onCollision(%this, %ice, %marble, %unused1, %unused2, %material))
			return;

		if (%ice.achievement39) {
			commandToClient(%marble.client, 'IceShardEarn');
		}
	}
};

function serverCmdSnowballsOnly(%client, %enable) {
	if (%client.isHost()) {
		$MP::Server::SnowballsOnly = %enable;
		commandToAll('SnowballsOnly', %enable);
	}
}

//-----------------------------------------------------------------------------

$SnowballTick = 20;
$SnowballSpeed = 20;
$SnowballGravity = -2;
$SnowballLimit = 150; //ms

datablock ParticleData(SnowballCollisionParticle) {
	textureName          = "~/data/particles/smoke";
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

	colors[0]     = "1 1 1 1.0";
	colors[1]     = "1 1 1 1.0";
	colors[2]     = "1 1 1 0.0";

	sizes[0]      = 0.25;
	sizes[1]      = 0.25;
	sizes[2]      = 0.25;

	times[0]      = 0;
	times[1]      = 0.75;
	times[2]      = 1.0;
};
datablock ParticleEmitterData(SnowballCollisionEmitter) {
	ejectionPeriodMS = 3;
	periodVarianceMS = 0;
	ejectionVelocity = 3.0;
	velocityVariance = 1.0;
	thetaMin         = 90.0;
	thetaMax         = 90.0;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	lifetimeMS       = 0;
	particles = "SnowballCollisionParticle";
};

datablock StaticShapeData(ThrownSnowball) {
	shapeFile = "~/data/shapes/Xmas/snowball/snowball.dts";
};
function ThrownSnowball::onAdd(%this, %obj) {
	%obj.setSkinName("uskin31");
}

function ThrownSnowball::updateThrow(%this, %obj) {
	//Update the position of the snowball
	%oldPos = getWords(%obj.getTransform(), 0, 2);
	%velocity = VectorScale(%obj.velocity, $SnowballTick / 1000);
	%velocity = VectorScale(%velocity, $SnowballSpeed * mSqrt(%obj.scalar));
	%newPos = VectorAdd(%oldPos, %velocity);

	//Check to see if we've hit anything
	%cast = ContainerRayCast(%oldPos, %newPos, $TypeMasks::InteriorObjectType, %obj);
	if (%cast) {
		echo(%cast);
		%this.collide(%obj, getWords(%cast, 1, 3), getWords(%cast, 4, 6));
		return;
	}

	//Actually move the thing
	%obj.setTransform(%newPos SPC "1 0 0 0");

	//Detect for client-snowball collision
	%box = %obj.getWorldBox();
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		//Don't hit ourselves
		if (isObject(%obj.thrower) && %client.getId() == %obj.thrower.getId())
			continue;
		if (isObject(%client.player)) {
			%pbox = %client.player.getWorldBox();

			if (boxInterceptsBox(%box, %pbox)) {
				//You hit them!
				%points = %obj.scalar;

				if ($Game::isMode["tag"])
					%points *= -1;

				//Extra push for mega marble
				if (%client.isMegaMarble())
					%points /= 1.5;
				if (%obj.thrower.isMegaMarble())
					%points *= 1.5;
				%points = mFloor(%points);

				%points = min(%points, %client.gemCount);

				//Update gem counts
				%client.gemCount -= %points;
				%client.setGemCount(%client.gemCount);
				%obj.thrower.gemCount += %points + 1;
				%obj.thrower.setGemCount(%obj.thrower.gemCount);
				updateScores();

				//Extra points for hitting someone?

				if (MissionInfo.pointsPerHit !$= "")
					%obj.thrower.gemCount += MissionInfo.pointsPerHit;

				//Impulse scale, megas too
				%scale = 2 * %scalar;
				if (%client.isMegaMarble())
					%scale /= 4;
				if (%obj.thrower.isMegaMarble())
					%scale *= 4;

				//Boop the player
				%client.applyImpulse("0 0 0", VectorScale(%obj.velocity, 4));

				//Noise
				%client.play3D(IceShardCrackSfx, %obj.getTransform());
				%obj.thrower.play3D(IceShardCrackSfx, %obj.getTransform());

				//Stats
				%obj.thrower.snowballhits ++;

				%theyPos = %client.player.getPosition();
				%this.collide(%obj, VectorScale(VectorAdd(%newPos, %theyPos), 0.5), VectorSub(%newPos, %theyPos));
				return;
			}
		}
	}

	if (isObject(Bounds)) {
		if (boxInterceptsBox(%box, Bounds.getWorldBox())) {
			%this.schedule($SnowballTick, "updateThrow", %obj);
		} else {
			%obj.emitter.delete();
			%obj.delete();
		}
	}
}

function ThrownSnowball::collide(%this, %obj, %position, %normal) {
	//Calculate the axis/angle for the collision normal
	%normal = VectorNormalize(%normal);
	%axis = VectorCrossSpecial(%normal, "0 0 1");
	%angle = VectorAngle(%normal, %axis);

	%rotation = %axis SPC %angle;
	%position = VectorAdd(%position, VectorScale(%normal, 0.1));

	%emitter = new ParticleEmitterNode() {
		datablock = FireworkNode;
		emitter = SnowballCollisionEmitter;
		position = %position;
		rotation = %rotation;
		scale = "1 1 1";
	};
	MissionCleanup.add(%emitter);
	%emitter.setScopeAlways();

	%lifetime = 30 * %obj.scalar;

	%emitter.schedule(%lifetime, "delete");
	%emitter.setTransform(%position SPC %rotation);
	%obj.emitter.delete();
	%obj.delete();
}

function ThrownSnowball::throw(%this, %obj, %yawPitch, %gravity) {
	%yaw   = getWord(%yawPitch, 0);
	%pitch = getWord(%yawPitch, 1);

	%cos = mCos(%yaw);
	%sin = mSin(%yaw);

	%obj.velocity = VectorScale(VectorRotate(-%sin SPC %cos SPC 0, getWords(%gravity, 0, 2), -getWord(%gravity, 3)), -1);
	%obj.yaw = %yaw;

	%this.schedule($SnowballTick, "updateThrow", %obj);
}

function serverCmdThrowSnowball(%client, %direction, %position) {
	if (%client.state $= "End" || $Game::State $= "End") {
		return;
	}

	if (!$MPPref::EnableSnowballs)
		return;

	if (%client.lastSnowball $= "")
		%client.lastSnowball = getSimTime();

	%delta = getSimTime() - %client.lastSnowball;

	if (%delta < $SnowballLimit)
		return;

	%client.lastSnowball = getSimTime();
	%client.snowballs ++;

	//Make a snowball and throw it
	%scalar = (1 + (%client.blastValue));
	if (%client.isMegaMarble()) {
		%scalar *= 2;
		//Offset
		%position = VectorSub(%position, "0 0 0.5");
	}
	%scale = VectorScale("0.5 0.5 0.5", %scalar);

	%snowball = new StaticShape() {
		position = %position;
		rotation = "1 0 0 0";
		scale = %scale;
		datablock = "ThrownSnowball";
		thrower = %client;
		scalar = %scalar;
	};
	MissionCleanup.add(%snowball);
	%snowball.forceNetUpdate();

	%emitter = new ParticleEmitterNode() {
		datablock = FireWorkNode;
		emitter = MarbleWhiteTrailEmitter;
		position = %position;
		rotation = "1 0 0 0";
		scale = %scale;
		trail = true;
		attachId = %snowball.getSyncId();
	};
	MissionCleanup.add(%emitter);

	%snowball.emitter = %emitter;

	%emitter.setScopeAlways();
	ThrownSnowball.throw(%snowball, %direction, %client.player.getGravityRot());
}

function initSnowParticles() {
	MarbleWhiteTrailParticle.applySnow();
	MarbleTrailParticle.applySnow();
	SuperSpeedParticle.applySnow();
	SuperJumpParticle.applySnow();
	TrailParticle.applySnow();
	BounceParticle.applySnow();
	BlastSmoke.applySnow();
	UltraBlastSmoke.applySnow();
}

function resetSnowParticles() {
	MarbleWhiteTrailParticle.revertSnow();
	MarbleTrailParticle.revertSnow();
	SuperSpeedParticle.revertSnow();
	SuperJumpParticle.revertSnow();
	TrailParticle.revertSnow();
	BounceParticle.revertSnow();
	BlastSmoke.revertSnow();
	UltraBlastSmoke.revertSnow();
}

function ParticleData::applySnow(%this) {
	if (!%this.snow) {
		%this.snow = true;
		%this.oldColors[0] = %this.colors[0];
		%this.oldColors[1] = %this.colors[1];
		%this.oldColors[2] = %this.colors[2];
		%this.oldTextureName = %this.textureName;
		%this.textureName = $userMods @ "/data/particles/snow.png";
		%this.colors[0] = "1 1 1" SPC getWord(%this.colors[0], 3);
		%this.colors[1] = "1 1 1" SPC getWord(%this.colors[1], 3);
		%this.colors[2] = "1 1 1" SPC getWord(%this.colors[2], 3);
	}
}

function ParticleData::revertSnow(%this) {
	if (%this.snow) {
		%this.snow = false;
		%this.textureName = %this.oldTextureName;
		%this.colors[0] = %this.oldColors[0];
		%this.colors[1] = %this.oldColors[1];
		%this.colors[2] = %this.oldColors[2];
		%this.oldColors[0] = "";
		%this.oldColors[1] = "";
		%this.oldColors[2] = "";
		%this.oldTextureName = "";
	}
}

function initSnow() {
	if (MissionInfo.snowGravity $= "") {
		%top = -999;
		for (%i = 0; %i < MissionGroup.getCount(); %i ++) {
			%obj = MissionGroup.getObject(%i);
			if (%obj.getClassName() $= "InteriorInstance")
				%top = max(%top, getWord(%obj.getWorldBox(), 5));
		}

		%obj = new ParticleEmitterNode() {
			datablock = FireWorkNode;
			emitter = Snow1Emitter;
			position = "0 0" SPC(%top + 100);
			rotation = "1 0 0 0";
		};
		MissionCleanup.add(%obj);
		%obj.setScopeAlways();

		%obj = new ParticleEmitterNode() {
			datablock = FireWorkNode;
			emitter = Snow2Emitter;
			position = "0 0" SPC(%top + 150);
			rotation = "1 0 0 0";
		};
		MissionCleanup.add(%obj);
		%obj.setScopeAlways();

		if (MissionInfo.noAchShard $= "") {
			%obj = new StaticShape() {
				position = "0 0" SPC(%top + 150);
				rotation = "1 0 0 180";
				datablock = IceShard1;
				achievement39 = "1";
			};
			MissionCleanup.add(%obj);
		}
	} else {
		%centers = "";
		%count = 0;
		for (%i = 0; %i < MissionGroup.getCount(); %i ++) {
			%obj = MissionGroup.getObject(%i);
			if (%obj.getClassName() $= "InteriorInstance") {
				%centers = VectorAdd(%centers, %obj.getWorldBoxCenter());
				%count ++;
			}
		}

		%center = VectorScale(%centers, 1 / %count);

		%obj = new ParticleEmitterNode() {
			datablock = FireWorkNode;
			emitter = Snow1GEmitter;
			position = %center;
			rotation = "1 0 0 0";
		};
		MissionCleanup.add(%obj);
		%obj.setScopeAlways();

		%obj = new ParticleEmitterNode() {
			datablock = FireWorkNode;
			emitter = Snow2GEmitter;
			position = %center;
			rotation = "1 0 0 0";
		};
		MissionCleanup.add(%obj);
		%obj.setScopeAlways();
	}
}

datablock StaticShapeData(SantaHatImage) {
	// Basic Item properties
	shapeFile = "~/data/shapes/Xmas/SantaHat.dts";
	emap = true;
};

datablock StaticShapeData(SantaHatLargeImage) {
	// Basic Item properties
	shapeFile = "~/data/shapes/Xmas/SantaHatMega.dts";
	emap = true;
};

function SantaHatImage::onAdd(%this, %obj) {
	//Something
}

//-----------------------------------------------------------------------------

datablock ItemData(SnowGlobe) {
	shapeFile = "~/data/shapes/Xmas/SnowGlobe.dts";
	emap = true;

	category = "Xmas";
};

datablock AudioProfile(SnowGlobeSfx) {
	fileName = "~/data/sound/snowglobe.wav";
	description = AudioDefault3d;
	preload = true;
};

function SnowGlobe::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.rotate = 0;
}

function SnowGlobe::onPickup(%this, %obj, %user, %amount) {
	//Save time for easter egg races
	if (Mode::callback("timeMultiplier", 1) > 0) {
		%time = $Time::CurrentTime + $Time::TotalBonus;
	} else {
		%time = (Mode::callback("getStartTime", 0) - $Time::CurrentTime) + $Time::TotalBonus;
	}

	commandToClient(%user.client, 'SnowGlobe', %time);
	%obj.hide(true);
	serverPlay3d(SnowGlobeSfx, %obj.getPosition());
	return true;
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(CandyCane) {
	shapeFile = "~/data/shapes/Xmas/CandyCane.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "60";
};

//-----------------------------------------------------------------------------

datablock StaticShapeData(ChristmasLights2T) {
	shapeFile = "~/data/shapes/Xmas/ChristmasLights_2T.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "20";
};

datablock StaticShapeData(ChristmasLights3T) {
	shapeFile = "~/data/shapes/Xmas/ChristmasLights_3T.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "20";
};

datablock StaticShapeData(ChristmasLights6T) {
	shapeFile = "~/data/shapes/Xmas/ChristmasLights_6T.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "20";
};

datablock StaticShapeData(ChristmasLights9T) {
	shapeFile = "~/data/shapes/Xmas/ChristmasLights_9T.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "20";
};

function ChristmasLights2T::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

function ChristmasLights3T::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

function ChristmasLights6T::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

function ChristmasLights9T::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(ChristmasTreeDecorated) {
	shapeFile = "~/data/shapes/Xmas/ChristmasTreeDecorated.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "80";
};

datablock StaticShapeData(ChristmasTreeNormal) {
	shapeFile = "~/data/shapes/Xmas/ChristmasTreeNormal.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "80";
};

datablock StaticShapeData(ChristmasTreeNormalDark) {
	shapeFile = "~/data/shapes/Xmas/ChristmasTreeNormalDark.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "80";
};

datablock StaticShapeData(ChristmasTreeSnowy) {
	shapeFile = "~/data/shapes/Xmas/ChristmasTreeSnowy.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "80";
};

datablock StaticShapeData(ChristmasTreeSnowyLong) {
	shapeFile = "~/data/shapes/Xmas/ChristmasTreeSnowyLong.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "80";
};

function ChristmasTreeDecorated::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

function ChristmasTreeNormal::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

function ChristmasTreeNormalDark::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

function ChristmasTreeSnowy::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

function ChristmasTreeSnowyLong::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(GiftCrateNormalOpen) {
	shapeFile = "~/data/shapes/Xmas/GiftCrateNormalOpen.dts";
	emap = true;

	skin[0]  = "base";
	skin[1]  = "plaid";
	skin[2]  = "plaid2";
	skin[3]  = "plaid3";
	skin[4]  = "Regcrate1";
	skin[5]  = "Regcrate2";
	skin[6]  = "Regcrate3";
	skin[7]  = "Regcrate4";
	skin[8]  = "Regcrate5";
	skin[9]  = "Regcrate6";
	skin[10] = "stripe1";
	skin[11] = "stripe2";
	skin[12] = "stripe3";
	skin[13] = "stripe4";
	skins = 14;
	category = "Xmas";
	renderDistance = "30";
};

datablock StaticShapeData(GiftCrateBigNormal) {
	shapeFile = "~/data/shapes/Xmas/GiftCrateBigNormal.dts";
	emap = true;

	skin[0]  = "base";
	skin[1]  = "plaid";
	skin[2]  = "plaid2";
	skin[3]  = "plaid3";
	skin[4]  = "Regcrate1";
	skin[5]  = "Regcrate2";
	skin[6]  = "Regcrate3";
	skin[7]  = "Regcrate4";
	skin[8]  = "Regcrate5";
	skin[9]  = "Regcrate6";
	skin[10] = "stripe1";
	skin[11] = "stripe2";
	skin[12] = "stripe3";
	skin[13] = "stripe4";
	skins = 14;
	category = "Xmas";
	renderDistance = "30";
};

datablock StaticShapeData(GiftCrateNormalClosed) {
	shapeFile = "~/data/shapes/Xmas/GiftCrateNormalClosed.dts";
	emap = true;

	skin[0]  = "base";
	skin[1]  = "plaid";
	skin[2]  = "plaid2";
	skin[3]  = "plaid3";
	skin[4]  = "Regcrate1";
	skin[5]  = "Regcrate2";
	skin[6]  = "Regcrate3";
	skin[7]  = "Regcrate4";
	skin[8]  = "Regcrate5";
	skin[9]  = "Regcrate6";
	skin[10] = "stripe1";
	skin[11] = "stripe2";
	skin[12] = "stripe3";
	skin[13] = "stripe4";
	skins = 14;
	category = "Xmas";
	renderDistance = "30";
};

datablock StaticShapeData(GiftCrateNormal) {
	shapeFile = "~/data/shapes/Xmas/GiftBoxNormal.dts";
	emap = true;

	skin[0]  = "base";
	skin[1]  = "Flatcrate1";
	skin[2]  = "Flatcrate2";
	skin[3]  = "Flatcrate3";
	skin[4]  = "Flatcrate4";
	skin[5]  = "Flatcrate5";
	skin[6]  = "Flatcrate6";
	skin[7]  = "plaid";
	skin[8]  = "plaid2";
	skin[9]  = "plaid3";
	skin[10] = "Regcrate1";
	skin[11] = "Regcrate2";
	skin[12] = "Regcrate3";
	skin[13] = "Regcrate4";
	skin[14] = "Regcrate5";
	skin[15] = "Regcrate6";
	skin[16] = "stripe1";
	skin[17] = "stripe2";
	skin[18] = "stripe3";
	skin[19] = "stripe4";
	skins = 20;
	category = "Xmas";
	renderDistance = "30";
};

datablock StaticShapeData(GiftCrateTeared) {
	shapeFile = "~/data/shapes/Xmas/GiftBoxTeared.dts";
	emap = true;

	skin[0]  = "base";
	skin[1]  = "Flatcrate1";
	skin[2]  = "Flatcrate2";
	skin[3]  = "Flatcrate3";
	skin[4]  = "Flatcrate4";
	skin[5]  = "Flatcrate5";
	skin[6]  = "Flatcrate6";
	skin[7]  = "Regcrate1";
	skin[8]  = "Regcrate2";
	skin[9]  = "Regcrate3";
	skin[10] = "Regcrate4";
	skin[11] = "Regcrate5";
	skin[12] = "Regcrate6";
	skins = 13;
	category = "Xmas";
	renderDistance = "30";
};

function GiftCrateNormalOpen::onAdd(%this, %obj) {
	if (%obj.skin $= "") {
		%skin = %this.skin[getRandom(0, %this.skins - 1)];
		%obj.setSkinName(%skin);
	} else {
		%obj.setSkinName(%obj.skin);
	}
}

function GiftCrateBigNormal::onAdd(%this, %obj) {
	if (%obj.skin $= "") {
		%skin = %this.skin[getRandom(0, %this.skins - 1)];
		%obj.setSkinName(%skin);
	} else {
		%obj.setSkinName(%obj.skin);
	}
}

function GiftCrateNormalClosed::onAdd(%this, %obj) {
	if (%obj.skin $= "") {
		%skin = %this.skin[getRandom(0, %this.skins - 1)];
		%obj.setSkinName(%skin);
	} else {
		%obj.setSkinName(%obj.skin);
	}
}

function GiftCrateNormal::onAdd(%this, %obj) {
	if (%obj.skin $= "") {
		%skin = %this.skin[getRandom(0, %this.skins - 1)];
		%obj.setSkinName(%skin);
	} else {
		%obj.setSkinName(%obj.skin);
	}
}

function GiftCrateTeared::onAdd(%this, %obj) {
	if (%obj.skin $= "") {
		%skin = %this.skin[getRandom(0, %this.skins - 1)];
		%obj.setSkinName(%skin);
	} else {
		%obj.setSkinName(%obj.skin);
	}
}

datablock StaticShapeData(GiftBooks) {
	shapeFile = "~/data/shapes/Xmas/GiftBooks.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

datablock StaticShapeData(GiftConsole) {
	shapeFile = "~/data/shapes/Xmas/GiftConsole.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

datablock StaticShapeData(GiftGame) {
	shapeFile = "~/data/shapes/Xmas/GiftGame.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

datablock StaticShapeData(GiftTV) {
	shapeFile = "~/data/shapes/Xmas/GiftTV.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

//-----------------------------------------------------------------------------

datablock StaticShapeData(GingerBreadMan) {
	shapeFile = "~/data/shapes/Xmas/GingerBreadMan.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "20";
};

//-----------------------------------------------------------------------------

datablock StaticShapeData(Mistletoes) {
	shapeFile = "~/data/shapes/Xmas/Mistletoes.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

function Mistletoes::onAdd(%this, %obj) {
	%obj.setSkinName(%obj.skin);
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(RegularBush) {
	shapeFile = "~/data/shapes/Xmas/Regular_Bush.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "50";
};

datablock StaticShapeData(SnowyBush) {
	shapeFile = "~/data/shapes/Xmas/Snowy_Bush.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "50";
};

//-----------------------------------------------------------------------------

datablock StaticShapeData(SnowBallBig) {
	shapeFile = "~/data/shapes/Xmas/Snow_ball_Big.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "50";
};

datablock StaticShapeData(SnowBallBigImperfect) {
	shapeFile = "~/data/shapes/Xmas/Snow_ball_big_imperfect.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "50";
};

datablock StaticShapeData(SnowBallPile) {
	shapeFile = "~/data/shapes/Xmas/Snow_ball_pile.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "50";
};

datablock StaticShapeData(SnowBallSmall) {
	shapeFile = "~/data/shapes/Xmas/Snow_ball_small.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "50";
};

//-----------------------------------------------------------------------------

datablock StaticShapeData(Snowman) {
	shapeFile = "~/data/shapes/Xmas/Snowman.dts";
	emap = true;

	skin[0]  = "base";
	skin[1]  = "ahh";
	skin[2]  = "disturbed";
	skin[3]  = "eh";
	skin[4]  = "happy";
	skin[5]  = "hipster";
	skin[6]  = "kawaii";
	skin[7]  = "lenny";
	skin[8]  = "olaf";
	skin[9]  = "regular";
	skin[10] = "running";
	skins = 11;
	category = "Xmas";
	renderDistance = "50";
};

function Snowman::onAdd(%this, %obj) {
	if (%obj.skin $= "") {
		%skin = %this.skin[getRandom(0, %this.skins - 1)];
		%obj.setSkinName(%skin);
	} else {
		%obj.setSkinName(%obj.skin);
	}
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(SnowPatch1) {
	shapeFile = "~/data/shapes/Xmas/SnowPatch_1.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

datablock StaticShapeData(SnowPatch2) {
	shapeFile = "~/data/shapes/Xmas/SnowPatch_2.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

datablock StaticShapeData(SnowPatch3) {
	shapeFile = "~/data/shapes/Xmas/SnowPatch_3.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

datablock StaticShapeData(SnowPatch4) {
	shapeFile = "~/data/shapes/Xmas/SnowPatch_4.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

datablock StaticShapeData(SnowPatch5) {
	shapeFile = "~/data/shapes/Xmas/SnowPatch_5.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

datablock StaticShapeData(SnowPatch6) {
	shapeFile = "~/data/shapes/Xmas/SnowPatch_6.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "40";
};

//-----------------------------------------------------------------------------

datablock StaticShapeData(SockwGame) {
	shapeFile = "~/data/shapes/Xmas/SockwGame.dts";
	emap = true;

	skin[0]  = "Aayrl";
	skin[1]  = "Andrew";
	skin[2]  = "base";
	skin[3]  = "Buzzmusic";
	skin[4]  = "Dierking";
	skin[5]  = "gitbot";
	skin[6]  = "HiGuy";
	skin[7]  = "hperks";
	skin[8]  = "Jack";
	skin[9]  = "Jeff";
	skin[10] = "Kalle";
	skin[11] = "Kurt";
	skin[12] = "Matan";
	skin[13] = "RDs";
	skin[14] = "Regislian";
	skins = 15;
	category = "Xmas";
	renderDistance = "20";
};

datablock StaticShapeData(SockwGift) {
	shapeFile = "~/data/shapes/Xmas/SockwGift.dts";
	emap = true;

	skin[0]  = "Aayrl";
	skin[1]  = "Andrew";
	skin[2]  = "base";
	skin[3]  = "Buzzmusic";
	skin[4]  = "Dierking";
	skin[5]  = "gitbot";
	skin[6]  = "HiGuy";
	skin[7]  = "hperks";
	skin[8]  = "Jack";
	skin[9]  = "Jeff";
	skin[10] = "Kalle";
	skin[11] = "Kurt";
	skin[12] = "Matan";
	skin[13] = "RDs";
	skin[14] = "Regislian";
	skins = 15;
	category = "Xmas";
	renderDistance = "20";
};

datablock StaticShapeData(SockwNobody) {
	shapeFile = "~/data/shapes/Xmas/SockwNobody.dts";
	emap = true;

	skin[0]  = "Aayrl";
	skin[1]  = "Andrew";
	skin[2]  = "base";
	skin[3]  = "Buzzmusic";
	skin[4]  = "Dierking";
	skin[5]  = "gitbot";
	skin[6]  = "HiGuy";
	skin[7]  = "hperks";
	skin[8]  = "Jack";
	skin[9]  = "Jeff";
	skin[10] = "Kalle";
	skin[11] = "Kurt";
	skin[12] = "Matan";
	skin[13] = "RDs";
	skin[14] = "Regislian";
	skins = 15;
	category = "Xmas";
	renderDistance = "20";
};

function SockwGame::onAdd(%this, %obj) {
	if (%obj.skin $= "") {
		%skin = %this.skin[getRandom(0, %this.skins - 1)];
		%obj.setSkinName(%skin);
	} else {
		%obj.setSkinName(%obj.skin);
	}
}

function SockwGift::onAdd(%this, %obj) {
	if (%obj.skin $= "") {
		%skin = %this.skin[getRandom(0, %this.skins - 1)];
		%obj.setSkinName(%skin);
	} else {
		%obj.setSkinName(%obj.skin);
	}
}

function SockwNobody::onAdd(%this, %obj) {
	if (%obj.skin $= "") {
		%skin = %this.skin[getRandom(0, %this.skins - 1)];
		%obj.setSkinName(%skin);
	} else {
		%obj.setSkinName(%obj.skin);
	}
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(TheGameBox) {
	shapeFile = "~/data/shapes/Xmas/TheGame_box.dts";
	emap = true;
	category = "Xmas";
	renderDistance = "20";
};
