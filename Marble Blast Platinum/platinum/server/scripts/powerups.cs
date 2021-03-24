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
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Easter Egg Codes by GarageGames, Alex Swanson and Spy47
// Random PowerUp Code by Spy47
// NoRespawn GravMod code from PQ
// Blast and Mega Marble PowerUp code new
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// PowerUp base class
//-----------------------------------------------------------------------------

function PowerUp::onPickup(%this,%obj,%user,%amount) {
	// Dont' pickup the power up if it's the same
	// one we already have.
	if (isObject(%user.powerUpData) && %user.powerUpData.getId() == %this.getId())
		return false;

	%disable = Mode::callback("shouldDisablePowerup", false, new ScriptObject() {
		this = %this;
		obj = %obj;
		user = %user;
		amount = %amount;
		_delete = true;
	});
	if (%disable) {
		return false;
	}

	// Grab it...
	%user.client.play2d(%this.pickupAudio);
	if (%this.powerUpId) {
		if (%obj.showHelpOnPickup) {
			%user.client.addBubbleLine("Press <func:bind mouseFire> to use the " @ %this.useName @ "!", false, 5000);
		}

		%user.client.checkpointFoundPowerup = true;

		%user.setPowerUp(%this, false, %obj);
	}

	%pickup = Mode::callback("shouldPickupPowerUp", true, new ScriptObject() {
		this = %this;
		obj = %obj;
		user = %user;
		amount = %amount;
		_delete = true;
	});

	if (%pickup)
		return Parent::onPickup(%this, %obj, %user, %amount);
	return true;
}

function PowerUp::onUse(%this, %obj, %user) {
	%user.playAudio(0, %this.activeAudio);

	%time = %user.getDataBlock().powerUpTime[%this.powerUpId] !$= "" ? %user.getDataBlock().powerUpTime[%this.powerUpId] : %user.getDataBlock()._powerUpTime[%this.powerUpId];

	cancel(%user.powerupSchedule[%this.powerUpId]);
	%user.client.activatePowerup(%this.powerUpId);
	%user.powerupSchedule[%this.powerUpId] = %user.client.schedule(%time, "deactivatePowerup", %this.powerUpId);

	%name = %this.getName();

	// do stuff for multiplayer
	if ($Server::ServerType $= "Multiplayer") {
		// particles for clients
		if (%name $= "SuperJumpItem" || %name $= "SuperJumpItem_PQ")
			%user.client.transferParticles(MarbleSuperJumpEmitter, true);
		else if (%name $= "SuperSpeedItem" || %name $= "SuperSpeedItem_PQ")
			%user.client.transferParticles(MarbleSuperSpeedEmitter, true);
	}
	if (%this.image !$= "") {
		//Don't show two images if they already have one
		if (!isEventPending(%user.client.unmount[%this.powerUpId]))
			%user.client.mountPlayerImage(%this, %this.imageSlot);

		//But do cancel and reschedule
		cancel(%user.client.unmount[%this.powerUpId]);
		%user.client.unmount[%this.powerUpId] = %user.client.schedule(%time, "unmountPlayerImage", %this.imageSlot);
	}

	//Use all powerups
	return true;
}

//-----------------------------------------------------------------------------

datablock AudioProfile(doSuperJumpSfx) {
	filename    = "~/data/sound/doSuperJump.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(PuSuperJumpVoiceSfx) {
	filename    = "~/data/sound/puSuperJumpVoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(SuperJumpItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";
	powerUpId = 1;

	activeAudio = DoSuperJumpSfx;
	pickupAudio = PuSuperJumpVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes/items/superjump.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	// Dynamic properties defined by the scripts
	pickupName = "a Super Jump PowerUp!";
	useName= "Super Jump PowerUp!";
	maxInventory = 1;
	coopClient = 1;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
};

datablock ItemData(SuperJumpItem_PQ : SuperJumpItem) {
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/superjump.dts";
};

//-----------------------------------------------------------------------------

datablock AudioProfile(PuSuperBounceVoiceSfx) {
	filename    = "~/data/sound/puSuperBounceVoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(SuperBounceItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";
	powerUpId = 3;

	pickupAudio = PuSuperBounceVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes/items/superbounce.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	// Dynamic properties defined by the scripts
	pickupName = "a Super Bounce PowerUp!";
	useName = "Super Bounce PowerUp!";
	maxInventory = 1;
	coopClient = 1;

	image = SuperBounceImage;
	imageSlot = 5;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
};

datablock AudioProfile(SuperBounceLoopSfx) {
	filename    = "~/data/sound/forcefield.wav";
	description = AudioClosestLooping3d;
	preload = true;
};

datablock ShapeBaseImageData(SuperBounceImage) {
	// Basic Item properties
	shapeFile = "~/data/shapes/images/glow_bounce.dts";
	emap = true;

	// Specify mount point & offset for 3rd person, and eye offset
	// for first person rendering.
	mountPoint = 0;
	offset = "0 0 0";
	stateName[0] = "Blah";
	stateSound[0] = SuperBounceLoopSfx;
};

datablock ItemData(SuperBounceItem_PQ : SuperBounceItem) {
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/superbounce.dts";
	image = SuperBounceImage_PQ;
};

datablock ShapeBaseImageData(SuperBounceImage_PQ : SuperBounceImage) {
	shapeFile = "~/data/shapes_pq/images/glow_bounce.dts";
};

//-----------------------------------------------------------------------------

datablock AudioProfile(DoSuperSpeedSfx) {
	filename    = "~/data/sound/doSuperSpeed.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(PuSuperSpeedVoiceSfx) {
	filename    = "~/data/sound/puSuperSpeedVoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(SuperSpeedItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";
	powerUpId = 2;

	activeAudio = DoSuperSpeedSfx;
	pickupAudio = PuSuperSpeedVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes/items/superspeed.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	// Dynamic properties defined by the scripts
	pickupName = "a Super Speed PowerUp!";
	useName = "Super Speed PowerUp!";
	maxInventory = 1;
	coopClient = 1;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
};

datablock ItemData(SuperSpeedItem_PQ : SuperSpeedItem) {
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/superspeed.dts";
};

//-----------------------------------------------------------------------------

datablock AudioProfile(PuShockAbsorberVoiceSfx) {
	filename    = "~/data/sound/puShockAbsorberVoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(ShockAbsorberItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";
	powerUpId = 4;

	pickupAudio = PuShockAbsorberVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes/items/shockabsorber.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	// Dynamic properties defined by the scripts
	pickupName = "a Shock Absorber PowerUp!";
	useName = "Shock Absorber PowerUp!";
	maxInventory = 1;
	coopClient = 1;
	emap = false;

	image = ShockAbsorberImage;
	imageSlot = 1;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
};

datablock AudioProfile(ShockLoopSfx) {
	filename    = "~/data/sound/superbounceactive.wav";
	description = AudioClosestLooping3d;
	preload = true;
};

datablock ShapeBaseImageData(ShockAbsorberImage) {
	// Basic Item properties
	shapeFile = "~/data/shapes/images/glow_bounce.dts";
	emap = true;

	// Specify mount point & offset for 3rd person, and eye offset
	// for first person rendering.
	mountPoint = 1;
	offset = "0 0 0";
	stateName[0] = "Blah";
	stateSound[0] = ShockLoopSfx;
};

datablock ItemData(ShockAbsorberItem_PQ : ShockAbsorberItem) {
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/pillow.dts";
	image = ShockAbsorberImage_PQ;
};

datablock ShapeBaseImageData(ShockAbsorberImage_PQ : ShockAbsorberImage) {
	shapeFile = "~/data/shapes_pq/images/glow_bounce.dts";
};

//-----------------------------------------------------------------------------
// TODO: multiplayer support for PQ helicopter ghosting

datablock AudioProfile(doHelicopterSfx) {
	filename    = "~/data/sound/doHelicopter.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(PuGyrocopterVoiceSfx) {
	filename    = "~/data/sound/puGyrocopterVoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(HelicopterItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";
	powerUpId = 5;

	activeAudio = DoHelicopterSfx;
	pickupAudio = PuGyrocopterVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes/images/helicopter.dts";
//   shapeFile = "~/data/shapes/items/megaHelicopter.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	// Dynamic properties defined by the scripts
	pickupName = "a Gyrocopter PowerUp!";
	useName = "Gyrocopter PowerUp!";
	maxInventory = 1;
	coopClient = 1;

	image = ActualHelicopterImage;
	megaImage = MegaHelicopterImage;
	imageSlot = 3;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
};

datablock AudioProfile(HelicopterLoopSfx) {
	filename    = "~/data/sound/Use_Gyrocopter.wav";
	description = AudioClosestLooping3d;
	preload = true;
};

datablock ShapeBaseImageData(HelicopterImage) {
	// Basic Item properties
	shapeFile = "~/data/shapes/images/Blank.dts";
//   shapeFile = "~/data/shapes/items/helicopter.dts";
	emap = true;
	mountPoint = 2;
};

datablock ShapeBaseImageData(ActualHelicopterImage) {
	// Basic Item properties
	shapeFile = "~/data/shapes/images/helicopter.dts";
	emap = true;
	mountPoint = 3;
	offset = "0 0 0";
	stateName[0]                     = "Rotate";
	stateSequence[0]                 = "rotate";
//   stateName[0]                     = "Ambient";
//   stateSequence[0]                 = "ambient";
	stateSound[0] = HelicopterLoopSfx;
	ignoreMountRotation = true;
};

datablock ShapeBaseImageData(MegaHelicopterImage : ActualHelicopterImage) {
	shapeFile = "~/data/shapes/items/megaHelicopter.dts";
};

datablock ItemData(HelicopterItem_PQ : HelicopterItem) {
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/gyrocopter.dts";
	image = HelicopterImage_PQ;
};

datablock ShapeBaseImageData(HelicopterImage_PQ : ActualHelicopterImage) {
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/gyrocopter.dts";
};

//-----------------------------------------------------------------------------
// Special non-inventory power ups
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

datablock AudioProfile(PuRandomVoiceSfx) {
	filename    = "~/data/sound/puRandomVoice.wav";
	description = AudioDefault3D;
	preload = true;
};

datablock ItemData(RandomPowerUpItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";

	// Basic Item properties
	pickupAudio = PuTimeTravelVoiceSfx;
	shapeFile = "~/data/shapes/items/random.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	// Dynamic properties defined by the scripts
	noRespawn = true;
	maxInventory = 1;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "timeBonus";
	customField[1, "type"   ] = "time";
	customField[1, "name"   ] = "Time Bonus";
	customField[1, "desc"   ] = "Bonus time to add if the Random PowerUp gives you a Time Travel.";
	customField[1, "default"] = $Game::TimeTravelBonus;
};

function RandomPowerUpItem::getPickupName(%this, %obj) {
	if (%obj.timeBonus !$= "")
		%time = %obj.timeBonus / 1000;
	else
		%time = $Game::TimeTravelBonus / 1000;

	return "a " @ %time @ " second Time Travel!";
}

function RandomPowerUpItem::OnPickup(%this,%obj,%user,%amount) {
	// for PQ, we can not have a time travel item
	if (MissionInfo.game $= "PlatinumQuest")
		%pupIdx = getRandom(1, 5);
	else
		%pupIdx = getRandom(1, 6);
	switch (%pupIdx) {
	case 1:
		%pup = SuperJumpItem;
	case 2:
		%pup = SuperSpeedItem;
	case 3:
		%pup = HelicopterItem;
	case 4:
		%pup = SuperBounceItem;
	case 5:
		%pup = ShockAbsorberItem;
	case 6:
		return TimeTravelItem::onPickup(%this,%obj,%user,%amount);
	}

	// PQ suffix
	if (MissionInfo.game $= "PlatinumQuest")
		%pup = %pup @ "_PQ";

	return PowerUp::OnPickup(%pup.getId(),%obj,%user,%amount);
}

//-----------------------------------------------------------------------------

datablock AudioProfile(PuTimeTravelVoiceSfx) {
	filename    = "~/data/sound/puTimeTravelVoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(TimeTravelItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";

	// Basic Item properties
	pickupAudio = PuTimeTravelVoiceSfx;
	shapeFile = "~/data/shapes/items/timetravel.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	// Dynamic properties defined by the scripts
	noRespawn = true;
	maxInventory = 1;
	noPickupMessage = true;

	//For ::timeCheck() to replace if the time is negative
	replacement = "TimePenaltyItem";

	//For the time message
	messageColor = "99ff99";
	grayMessageColor = "cccccc";

	customField[0, "field"  ] = "timeBonus";
	customField[0, "type"   ] = "time";
	customField[0, "name"   ] = "Time Bonus";
	customField[0, "desc"   ] = "Bonus time to add.";
	customField[0, "default"] = $Game::TimeTravelBonus;
};

datablock ItemData(TimeTravelItem_PQ : TimeTravelItem) {
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/timetravel.dts";

	//For ::timeCheck() to replace if the time is negative
	replacement = "TimePenaltyItem_PQ";
};

datablock ItemData(SundialItem_PQ : TimeTravelItem) {
	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/sundial.dts";

	//For ::timeCheck() to replace if the time is negative
	replacement = "TimePenaltyItem_PQ";
};

function TimeTravelItem::onAdd(%this, %obj) {
	if (%obj.timeBonus $= "")
		%obj.timeBonus = "5000";

	%this.checkTime(%obj);
}

function TimeTravelItem::onPickup(%this,%obj,%user,%amount) {
	if (!Parent::onPickup(%this, %obj, %user, %amount)) {
		return false;
	}

	if (!Mode::callback("shouldAllowTTs", true)) {
		return false;
	}

	%bonus = (%obj.timeBonus $= "" ? $Game::TimeTravelBonus : %obj.timeBonus);
	%color = (%bonus == 0 ? %this.grayMessageColor : %this.messageColor);
	%sign = (Mode::callback("timeMultiplier", 1) > 0 ? "-" : "+");

	//Show a message
	%user.client.displayGemMessage(%sign @(%bonus / 1000) @ "s", %color);

	if (%bonus > 0)
		%user.client.incBonusTime(%bonus);

	commandToAll('UpdateTimeTravelCountdown'); // main_gi v4.2.3
	
	return true;
}

function TimeTravelItem_PQ::onAdd(%this, %obj) {
	return TimeTravelItem::onAdd(%this, %obj);
}
function TimeTravelItem_PQ::onPickup(%this,%obj,%user,%amount) {
	return TimeTravelItem::onPickup(%this, %obj, %user, %amount);
}

function SundialItem_PQ::onAdd(%this, %obj) {
	return TimeTravelItem::onAdd(%this, %obj);
}
function SundialItem_PQ::onPickup(%this,%obj,%user,%amount) {
	return TimeTravelItem::onPickup(%this, %obj, %user, %amount);
}

//-----------------------------------------------------------------------------
// Time Penalty (negative TT) Items

datablock ItemData(TimePenaltyItem : TimeTravelItem) {
	//pickupAudio = TimePenaltySfx;
	shapeFile = "~/data/shapes/items/timetravel.dts";

	//For ::timeCheck() to replace if the time is negative
	replacement = "TimeTravelItem";

	//For the time message
	messageColor = "ff9999";
	grayMessageColor = "cccccc";

	customField[0, "field"  ] = "timePenalty";
	customField[0, "type"   ] = "time";
	customField[0, "name"   ] = "Time Penalty";
	customField[0, "desc"   ] = "Penalty time to add to elapsed time.";
	customField[0, "default"] = "5000";
};

datablock ItemData(TimePenaltyItem_PQ : TimeTravelItem) {
	//pickupAudio = TimePenaltySfx;
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/timepenalty.dts";

	//For ::timeCheck() to replace if the time is negative
	replacement = "TimeTravelItem_PQ";

	//For the time message
	messageColor = "ff9999";
	grayMessageColor = "cccccc";
};

function TimePenaltyItem::onAdd(%this, %obj) {
	if (%obj.timePenalty $= "")
		%obj.timePenalty = "5000";

	%this.checkTime(%obj);
}

function TimePenaltyItem::onPickup(%this,%obj,%user,%amount) {
	if (!Parent::onPickup(%this, %obj, %user, %amount)) {
		return false;
	}

	if (!Mode::callback("shouldAllowTTs", true)) {
		return false;
	}

	%penalty = (%obj.timePenalty $= "" ? $Game::TimeTravelBonus : %obj.timePenalty);
	%color = (%penalty == 0 ? %this.grayMessageColor : %this.messageColor);
	%sign = (Mode::callback("timeMultiplier", 1) > 0 ? "+" : "-");

	//Show a message
	%user.client.displayGemMessage(%sign @(%penalty / 1000) @ "s", %color);

	if (%penalty > 0)
		%user.client.incBonusTime(-%penalty);

	return true;
}

function TimePenaltyItem_PQ::onAdd(%this, %obj) {
	TimePenaltyItem::onAdd(%this, %obj);
}
function TimePenaltyItem_PQ::onPickup(%this, %obj, %user, %amount) {
	return TimePenaltyItem::onPickup(%this, %obj, %user, %amount);
}

//-----------------------------------------------------------------------------
// Respawning Time Travel/Penalty Items

datablock ItemData(RespawningTimeTravelItem : TimeTravelItem) {
	noRespawn = false;
	//For ::timeCheck() to replace if the time is negative
	replacement = "RespawningTimePenaltyItem";
};

datablock ItemData(RespawningTimePenaltyItem : TimePenaltyItem) {
	noRespawn = false;
	//For ::timeCheck() to replace if the time is negative
	replacement = "RespawningTimeTravelItem";
};

datablock ItemData(RespawningTimeTravelItem_PQ : TimeTravelItem_PQ) {
	noRespawn = false;
	//For ::timeCheck() to replace if the time is negative
	replacement = "RespawningTimePenaltyItem_PQ";
};

datablock ItemData(RespawningTimePenaltyItem_PQ : TimePenaltyItem_PQ) {
	noRespawn = false;
	//For ::timeCheck() to replace if the time is negative
	replacement = "RespawningTimeTravelItem_PQ";
};

function RespawningTimeTravelItem::onAdd(%this, %obj) {
	TimeTravelItem::onAdd(%this, %obj);
	if (%obj.respawnTime $= "")
		%obj.respawnTime = "7000";
}
function RespawningTimePenaltyItem::onAdd(%this, %obj) {
	TimePenaltyItem::onAdd(%this, %obj);
	if (%obj.respawnTime $= "")
		%obj.respawnTime = "7000";
}
function RespawningTimeTravelItem_PQ::onAdd(%this, %obj) {
	RespawningTimeTravelItem::onAdd(%this, %obj);
}
function RespawningTimePenaltyItem_PQ::onAdd(%this, %obj) {
	RespawningTimePenaltyItem::onAdd(%this, %obj);
}

function RespawningTimeTravelItem::onPickup(%this, %obj, %user, %amount) {
	return TimeTravelItem::onPickup(%this, %obj, %user, %amount);
}
function RespawningTimePenaltyItem::onPickup(%this, %obj, %user, %amount) {
	return TimePenaltyItem::onPickup(%this, %obj, %user, %amount);
}
function RespawningTimeTravelItem_PQ::onPickup(%this, %obj, %user, %amount) {
	return TimeTravelItem::onPickup(%this, %obj, %user, %amount);
}
function RespawningTimePenaltyItem_PQ::onPickup(%this, %obj, %user, %amount) {
	return TimePenaltyItem::onPickup(%this, %obj, %user, %amount);
}

//-----------------------------------------------------------------------------
// Negative TTs should become TPs and vice versa

function TimeTravelItem::checkTime(%this, %obj) {
	if (%obj.timeBonus >= 0 || %obj.timeBonus $= "") {
		return;
	}

	%replacement = %this.replacement;
	%obj.timePenalty = -%obj.timeBonus;
	%obj.timeBonus = "";
	%obj.setDataBlock(%replacement);
}

function TimeTravelItem_PQ::checkTime(%this, %obj) {
	TimeTravelItem::checkTime(%this, %obj);
}
function SundialItem_PQ::checkTime(%this, %obj) {
	TimeTravelItem::checkTime(%this, %obj);
}
function TimePenaltyItem::checkTime(%this, %obj) {
	if (%obj.timePenalty >= 0 || %obj.timePenalty $= "") {
		return;
	}

	%replacement = %this.replacement;
	%obj.timeBonus = -%obj.timePenalty;
	%obj.timePenalty = "";
	%obj.setDataBlock(%replacement);
}
function TimePenaltyItem_PQ::checkTime(%this, %obj) {
	TimePenaltyItem::checkTime(%this, %obj);
}

function TimeTravelItem::onInspectApply(%this, %obj) {
	Parent::onInspectApply(%this, %obj);
	%this.checkTime(%obj);
}
function TimeTravelItem_PQ::onInspectApply(%this, %obj) {
	TimeTravelItem::onInspectApply(%this, %obj);
}
function TimePenaltyItem::onInspectApply(%this, %obj) {
	Parent::onInspectApply(%this, %obj);
	%this.checkTime(%obj);
}
function TimePenaltyItem_PQ::onInspectApply(%this, %obj) {
	TimePenaltyItem::onInspectApply(%this, %obj);
}
function SundialItem_PQ::onInspectApply(%this, %obj) {
	TimeTravelItem::onInspectApply(%this, %obj);
}

function RespawningTimeTravelItem::checkTime(%this, %obj, %user, %amount) {
	TimeTravelItem::checkTime(%this, %obj, %user, %amount);
}
function RespawningTimePenaltyItem::checkTime(%this, %obj, %user, %amount) {
	TimePenaltyItem::checkTime(%this, %obj, %user, %amount);
}
function RespawningTimeTravelItem_PQ::checkTime(%this, %obj, %user, %amount) {
	TimeTravelItem::checkTime(%this, %obj, %user, %amount);
}
function RespawningTimePenaltyItem_PQ::checkTime(%this, %obj, %user, %amount) {
	TimePenaltyItem::checkTime(%this, %obj, %user, %amount);
}

function RespawningTimeTravelItem::onInspectApply(%this, %obj, %user, %amount) {
	TimeTravelItem::onInspectApply(%this, %obj, %user, %amount);
}
function RespawningTimePenaltyItem::onInspectApply(%this, %obj, %user, %amount) {
	TimePenaltyItem::onInspectApply(%this, %obj, %user, %amount);
}
function RespawningTimeTravelItem_PQ::onInspectApply(%this, %obj, %user, %amount) {
	TimeTravelItem::onInspectApply(%this, %obj, %user, %amount);
}
function RespawningTimePenaltyItem_PQ::onInspectApply(%this, %obj, %user, %amount) {
	TimePenaltyItem::onInspectApply(%this, %obj, %user, %amount);
}

//-----------------------------------------------------------------------------

datablock AudioProfile(PuAntiGravityVoiceSfx) {
	filename    = "~/data/sound/gravitychange.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(AntiGravityItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";

	pickupAudio = PuAntiGravityVoiceSfx;
	pickupName = "a Gravity Modifier!";

	// Basic Item properties
	shapeFile = "~/data/shapes/items/antiGravity.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	// Dynamic properties defined by the scripts
	maxInventory = 1;
	coopClient = 1;
};

datablock ItemData(AntiGravityItem_PQ : AntiGravityItem) {
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/GravMod.dts";

	pickupName = "a Gravity Modifier!";
};

function AntiGravityItem::onAdd(%this, %obj) {
	%obj.playThread(0,"Ambient");
}

function AntiGravityItem::onPickup(%this,%obj,%user,%amount) {
	%rotation = getWords(%obj.getTransform(),3);
	%ortho = vectorOrthoBasis(%rotation);
	%ortho = VectorRemoveNotation(%ortho);

	if (!VectorEqual(getWords(%user.getGravityDir(), 6, 8), getWords(%ortho, 6, 8))) {
		if (!Parent::onPickup(%this, %obj, %user, %amount)) {
			return false;
		}
		%user.client.setGravityDir(%ortho, false, %rotation);
		//echo("Checkpint reached, saving gravity: " @ %ortho);
		return true;
	}
	return false;
}

/// I wish datablocks had better subclassing in TorqueScript :l
/// The following is a workaround for PQ shapes to share the same code
/// {
function AntiGravityItem_PQ::onAdd(%this, %obj) {
	AntiGravityItem::onAdd(%this, %obj);
}

function AntiGravityItem_PQ::onPickup(%this, %obj, %user, %amount) {
	return AntiGravityItem::onPickup(%this, %obj, %user, %amount);
}

/// }

//-----------------------------------------------------------------------------

datablock ItemData(EasterEgg) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";

	shapeFile = "~/data/shapes/items/easteregg.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	displayName = "Easter Egg";

	// Dynamic properties defined by the scripts
	noRespawn = true;
	maxInventory = 1;
	noPickupMessage = true; // Don't display a message here. We're doing it later.
};

function EasterEgg::getPickupName(%this, %obj) {
	return "an Easter Egg!";
}

function EasterEgg::onPickup(%this,%obj,%user,%amount) {
	if (!Parent::onPickup(%this, %obj, %user, %amount)) {
		return false;
	}

	if ($Editor::Opened) {
		return false;
	}

	$Game::EasterEgg = true;

	//Save time for easter egg races
	%time = $Time::ElapsedTime;

	$Game::EasterEgg = true;
	//Client handles the everything and lets us know if this is a new egg for them
	commandToClient(%user.client, 'FoundEgg', %time, %this.displayName, %this.getPickupName());

	return true;
}

function serverCmdEggStatus(%client, %status, %display, %pickup) {
	if (%status) {
		%client.playPitchedSound("easter");
	} else {
		%client.playPitchedSound("easterfound");
	}
}

//-----------------------------------------------------------------------------

datablock AudioProfile(NestEggSfx) {
	filename    = "~/data/sound/nestegg.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(NestEggFoundSfx) {
	filename    = "~/data/sound/nesteggfound.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(NestEgg_PQ) {
	// Mission editor category
	category = "Powerups";	// This should be put in a new category
	className = "PowerUp";	// Ditto
	// category: NestEggs	className: Egg

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/NestEgg/NestEggNoTrans.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	displayName = "Nest Egg";

	// Dynamic properties defined by the scripts
	noRespawn = true;
	maxInventory = 1;
	noPickupMessage = true;

	skin[0] = "base";
	skin[1] = "black";
	skin[2] = "blue";
	skin[3] = "brown";
	skin[4] = "green";
	skin[5] = "orange";
	skin[6] = "purple";
	skin[7] = "red";
	skinCount = 8;

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

function NestEgg_PQ::onAdd(%this, %obj) {
	if (%obj.skin $= "")
		%obj.skin = "base";

	// make sure skin exists. If not, keep it as base
	%found = false;
	for (%i = 0; %i < %this.skinCount; %i++) {
		if (%obj.skin $= %this.skin[%i]) {
			%found = true;
			break;
		}
	}

	if (%found)
		%obj.setSkinName(%obj.skin);
	else
		%obj.setSkinName("base");
}

function NestEgg_PQ::getPickupName(%this, %obj) {
	return "a Nest Egg!";
}

function NestEgg_PQ::onPickup(%this,%obj,%user,%amount) {
	return EasterEgg::onPickup(%this, %obj, %user, %amount);
}


//-----------------------------------------------------------------------------

datablock ItemData(NoRespawnAntiGravityItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";

	pickupAudio = PuAntiGravityVoiceSfx;
	pickupName = "a Gravity Modifier!";

	// Basic Item properties
	shapeFile = "~/data/shapes/items/antiGravity.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	noPickup = true;

	// haaaacked, allow for MP support
	permanent = true;
	density = 9001; // actually transfers, used for item collision
};

function NoRespawnAntiGravityItem::onAdd(%this, %obj) {
	%obj.playThread(0,"Ambient");
}

function NoRespawnAntiGravityItem::onPickup(%this,%obj,%user,%amount) {
	%rotation = getWords(%obj.getTransform(),3);
	%ortho = VectorRemoveNotation(VectorOrthoBasis(%rotation));
	if (!VectorEqual(getWords(%user.getGravityDir(), 6, 8), getWords(%ortho, 6, 8))) {
		if (!Parent::onPickup(%this, %obj, %user, %amount)) {
			return false;
		}
		%user.client.setGravityDir(%ortho, false, %rotation);
		return true;
	}
	return false;
}

datablock ItemData(NoRespawnAntiGravityItem_PQ : NoRespawnAntiGravityItem) {
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/GravMod.dts";

	pickupName = "a Gravity Modifier!";
};

function NoRespawnAntiGravityItem_PQ::onAdd(%this, %obj) {
	NoRespawnAntiGravityItem::onAdd(%this, %obj);
}

function NoRespawnAntiGravityItem_PQ::onPickup(%this, %obj, %user, %amount) {
	return NoRespawnAntiGravityItem::onPickup(%this, %obj, %user, %amount);
}

//-----------------------------------------------------------------------------

datablock AudioProfile(PuBlastVoiceSfx) {
	filename    = "~/data/sound/puBlastVoice.wav";
	description = AudioDefault3d;
	preload     = true;
};

datablock ItemData(BlastItem) {
	className = "PowerUp";
	category = "PowerUps";

	pickupAudio = PuBlastVoiceSfx;
	shapeFile = "~/data/shapes/items/blast.dts";
	emap = false;
	pickupName = "a Blast PowerUp!";
	coopClient = 1;
};

function BlastItem::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
}

function BlastItem::onPickup(%this, %obj, %user, %amount) {
	if (%user.client.disableBlast) {
		return false;
	}
	if (!Parent::onPickup(%this, %obj, %user, %amount)) {
		return false;
	}
	%user.client.setBlastValue(1);
	%user.client.setSpecialBlast(true);
	return true;
}

//-----------------------------------------------------------------------------

datablock AudioProfile(doMegaMarbleSfx) {
	filename    = "~/data/sound/doSuperJump.wav";
//   filename    = "~/data/sound/doMegaMarble.wav";
	description = AudioDefault3d;
	preload     = true;
};

datablock AudioProfile(PuMegaMarbleVoiceSfx) {
	filename    = "~/data/sound/puMegaMarbleVoice.wav";
	description = AudioDefault3d;
	preload     = true;
};

datablock ItemData(MegaMarbleItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";
	powerUpId = 6;

	activeAudio = DoMegaMarbleSfx;
	pickupAudio = PuMegaMarbleVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes/items/MegaMarble.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	// Dynamic properties defined by the scripts
	pickupName = "a Mega Marble PowerUp!";
	useName = "Mega Marble PowerUp";
	maxInventory = 1;
	coopClient = 1;

	defaultTimeout = 10000;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "timeout";
	customField[1, "type"   ] = "time";
	customField[1, "name"   ] = "Duration";
	customField[1, "desc"   ] = "How long the Mega Marble should last.";
	customField[1, "default"] = "10000";
};

function MegaMarbleItem::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
}

function MegaMarbleItem::onUse(%this, %obj, %user) {
	if (!%user.client.isMegaMarble()) {
		if (%user.isFrozen) {
			%user.iceShard.getDataBlock().unFreeze(%user.iceShard, %user, true);
			return true;
		}
		%user.client.setMegaMarble(true);
		%ray = ContainerRayCast(%user.getPosition(), VectorSub(%user.getPosition(), VectorMult("-1 -1 -1", getWords(%user.getGravityDir(), 6, 8))), $TypeMasks::InteriorObjectType, %user);
		if (isObject(getWord(%ray, 0)))
			%user.client.schedule(10, gravityImpulse, "0 0 -1", "6 6 6");

		if (%user.powerupActive[HelicopterItem.powerUpId]) {
			%user.client.unmountPlayerImage(HelicopterItem.imageSlot);
			%user.client.mountPlayerImage(HelicopterItem, HelicopterItem.imageSlot);
		}
	}
	%timeout = (%obj.timeout > 0 ? %obj.timeout : %this.defaultTimeout);
	cancel(%user.megaSchedule);
	%user.megaSchedule = %this.schedule(%timeout, "onUnuse", %obj, %user);

	return Parent::onUse(%this, %obj, %user);
}

function MegaMarbleItem::onUnuse(%this, %obj, %user) {
	cancel(%user.megaSchedule);

	%user.client.setMegaMarble(false);
	%user.client.schedule(10, gravityImpulse, "0 0 1", "-2 -2 -2");

	if (%user.powerupActive[HelicopterItem.powerUpId]) {
		%user.client.unmountPlayerImage(HelicopterItem.imageSlot);
		%user.client.mountPlayerImage(HelicopterItem, HelicopterItem.imageSlot);
	}
}

//-----------------------------------------------------------------------------

datablock AudioProfile(PuTeleportItemVoiceSfx) {
	filename    = "~/data/sound/putteleportitemvoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(DoTeleportItemSfx) {
	filename    = "~/data/sound/teleport.wav";
	description = AudioDefault3d;
	preload = true;
};


datablock ItemData(TeleportItem) {
	// Mission editor category
	category = "Powerups";
	className = "PowerUp";
	powerUpId = 7;

	activeAudio = DoTeleportItemSfx;
	pickupAudio = PuTeleportItemVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/teleport.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	// Dynamic properties defined by the scripts
	pickupName = "a Teleport PowerUp! Press <func:bind mouseFire> to set location!";
	useName = "Teleport PowerUp";
	maxInventory = 1;
	emap = false;
	radar = 1;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "teletime";
	customField[1, "type"   ] = "time";
	customField[1, "name"   ] = "Delay Time";
	customField[1, "desc"   ] = "How long the teleporter takes to activate after usage.";
	customField[1, "default"] = "2000";
	customField[2, "field"  ] = "keepVelocity";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Keep Velocity";
	customField[2, "desc"   ] = "If true the player's velocity will not be set to zero on teleport.";
	customField[2, "default"] = "0";
};

datablock StaticShapeData(WireBall) {
	className = "Misc";
	category = "Other";
	shapeFile = "~/data/shapes_pq/Other/wireball.dts";
};

function TeleportItem::onAdd(%this, %obj) {
	if (%obj.teletime $= "")
		%obj.teletime = 2000;

	if (%obj.keepVelocity) {
		%obj.setSkinName("yellow");
	}

	Parent::onAdd(%this, %obj);
}

function TeleportItem::onInspectApply(%this, %obj) {
	if (%obj.keepVelocity) {
		%obj.setSkinName("yellow");
	} else {
		%obj.setSkinName("base");
	}
}

function TeleportItem::onUse(%this, %obj, %user) {
	if (%user.teleporterFireNum == %user.client.fireNum)
		return false;
	if (%user.teleporterLocationSet) {
		//Activate teleporter
		%this.performTeleport(%obj, %user);
		return Parent::onUse(%this, %obj, %user);
	} else {
		//Set location
		%this.setLocation(%obj, %user);
		return false;
	}
}

function TeleportItem::getPickupName(%this, %obj) {
	if (%obj.keepVelocity) {
		return "a Transporter PowerUp!";
	} else {
		return "a Teleporter PowerUp!";
	}
}

function TeleportItem::performTeleport(%this, %obj, %user) {
	%user.teleporterWire.delete();

	//Delay the return teleport
	cancel(%user.client.telePowerupSched);
	%user.client.telePowerupSched = %this.schedule(%user.teleporterTime, finishTeleport, %obj, %user);
	%user.setCloaked(true);
}

function TeleportItem::finishTeleport(%this, %obj, %user) {
	%user.setCloaked(false);

	if (!%obj.keepVelocity) {
		%user.setVelocity("0 0 0");
		%user.setAngularVelocity("0 0 0");
	}

	%user.setTransform(%user.teleporterPosition);
	%user.setCameraPitch(%user.teleporterPitch);
	%user.setCameraYaw(%user.teleporterYaw);
	%user.client.setGravityDir(%user.teleporterGravity, true, %user.teleporterGravityRot);

	%user.teleporterLocationSet = false;
}

function TeleportItem::setLocation(%this, %obj, %user) {
	//Create a wire marble for showing the location
	%user.teleporterWire = new StaticShape() {
		position = %user.position;
		rotation = "1 0 0 0";
		scale = "1 1 1";
		datablock = "WireBall";
	};
	MissionCleanup.add(%user.teleporterWire);

	if (%obj.keepVelocity) {
		%user.teleporterWire.setSkinName("yellow");
	}

	%user.teleporterPosition = %user.getTransform();
	%user.teleporterPitch = %user.getCameraPitch();
	%user.teleporterYaw = %user.getCameraYaw();
	%user.teleporterGravity = %user.getGravityDir();
	%user.teleporterGravityRot = %user.getGravityRot();
	%user.teleporterTime = %obj.teletime;

	%user.teleporterLocationSet = true;
	%user.teleporterFireNum = %user.client.fireNum;
}

//-----------------------------------------------------------------------------

datablock AudioProfile(PuAnvilVoiceSfx) {
	filename    = "~/data/sound/puanvilvoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(DoAnvilSfx) {
	filename    = "~/data/sound/doAnvil.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(AnvilItem) {
	// Mission editor category
	category = "Powerups";
	className = "PowerUp";
	powerUpId = 8;

	activeAudio = DoAnvilSfx;
	pickupAudio = PuAnvilVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/anvil.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	// Dynamic properties defined by the scripts
	pickupName = "an Anvil PowerUp!";
	useName = "Anvil PowerUp";
	maxInventory = 1;
	emap = false;
	radar = 1;

	client = true;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
};

function AnvilItem::getData(%this, %obj) {
	return "";
}

//-----------------------------------------------------------------------------


datablock AudioProfile(PuBubbleVoiceSfx) {
	filename    = "~/data/sound/puBubbleVoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(DoBubbleSfx) {
	//filename    = "~/data/sound/doBubble.wav";
	filename    = "~/data/sound/puBubbleVoice.wav"; // TODO?
	description = AudioDefault3d;
	preload = true;
};

datablock ShapeBaseImageData(BubbleImage) {
	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/bubble.dts";
	emap = true;

	// Specify mount point & offset for 3rd person, and eye offset
	// for first person rendering.
	mountPoint = 0;
	offset = "0 0 0";
	stateName[0] = "Blah";
	stateSound[0] = SuperBounceLoopSfx;
};

datablock ItemData(BubbleItem) {
	// Mission editor category
	category = "Powerups";
	className = "PowerUp";

	activeAudio = DoBubbleSfx;
	pickupAudio = PuBubbleVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/bubble.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	// Dynamic properties defined by the scripts
	pickupName = "a Bubble Powerup!";
	useName = "Bubble Powerup";
	maxInventory = 1;
	radar = 1;

	fxEmitter[0] = "ItemBubbleEmitter";

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "infinite";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Infinite";
	customField[1, "desc"   ] = "If the bubble has infinite time.";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "time";
	customField[2, "type"   ] = "time";
	customField[2, "name"   ] = "Duration";
	customField[2, "desc"   ] = "How long the bubble PowerUp lasts.";
	customField[2, "default"] = "5000";
};


// Marble floats above water. Increase water velocity movement by 50-75% ? Marble cannot jump.
// Powerup is defaulted to 5 seconds of use.
// Player has a timer of some sort indicating how much time is left (maybe use progressbar.png, ~\pqport\data\shapes)
// Level specific code where this powerup is toggleable on/off is not to be done here, but in the specific level(s).

function BubbleItem::onAdd(%this, %obj) {
	if (%obj.Infinite $= "")
		%obj.Infinite = 0;

	if (%obj.Time $= "")
		%obj.Time = 5000;

	//particles init
	%this.schedule(250, initFX, %obj);

	Parent::onAdd(%this, %obj);
}

function BubbleItem::onPickup(%this, %obj, %user, %amount) {
	if (%user.client.bubbleInfinite)
		return false; //already have infinite, no sense to pick up another one

	//Can't bubble with fireball
	if (%user._fireballActive) {
		%user.client.play2d(bubbleSnuffSfx);
		%obj.respawn();
		return false;
	}

	//otherwise set this one as our new object
	if (!Parent::onPickup(%this, %obj, %user, %amount)) {
		return false;
	}

	%user.client.setBubbleTime(%obj.time, %obj.infinite);
	return true;
}

function serverCmdBubbleTime(%client, %time) {
	//Just take their word for it, as long as they don't *increase* their time
	if (%client.bubbleTime > %time) {
		%client.bubbleTime = %time;
	}
}

//-----------------------------------------------------------------------------

datablock ItemData(CustomSuperJumpItem_PQ : SuperJumpItem) {
	// TODO: get a new DTS shape for weak super jump
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/superjump.dts";
	powerUpId = 9;

	pickupName = "a Super Jump PowerUp!";
	useName = "Super Jump PowerUp!";

	client = true;

	customField[0, "field"  ] = "showHelpOnPickup";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Show Help Message";
	customField[0, "desc"   ] = "If the player should see a help message for how to use the PowerUp when they collect it.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "power";
	customField[1, "type"   ] = "float";
	customField[1, "name"   ] = "Jump Force";
	customField[1, "desc"   ] = "How much force to apply to the marble.";
	customField[1, "default"] = "10";
};

function CustomSuperJumpItem_PQ::onAdd(%this, %obj) {
	if (%obj.power $= "")
		%obj.power = 10;

	%obj.setSync();
}

function CustomSuperJumpItem_PQ::getData(%this, %obj) {
	return "power" TAB %obj.power;
}



// powerUpId = 10 ==> PartyItem
