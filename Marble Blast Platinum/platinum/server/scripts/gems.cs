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
// Gem base class
//-----------------------------------------------------------------------------

$GemSkinColors[0] = "base";
$GemSkinColors[1] = "base";
$GemSkinColors[2] = "blue";
$GemSkinColors[3] = "red";
$GemSkinColors[4] = "yellow";
$GemSkinColors[5] = "purple";
$GemSkinColors[6] = "orange";
$GemSkinColors[7] = "green";
$GemSkinColors[8] = "turquoise";
$GemSkinColors[9] = "black";
$GemSkinColors[10] = "platinum";
$GemSkinColors[11] = "specialpurple";
$GemSkinColors[12] = "specialyellow";
$GemSkinColors[13] = "specialplatinum";
$GemSkinColors[14] = "white";

function Gem::onAdd(%this,%obj) {
	if (%this.skin !$= "") {
		%obj.setSkinName(%this.skin);
	} else if (%obj.skin !$= "") {
		%obj.setSkinName(%obj.skin);
	} else {
		// Random skin if none assigned
		%obj.setSkinName($GemSkinColors[getRandom(10)]);
	}

	if (%obj.getSkinName() $= "base") {
		%obj._huntDatablock = "GemItem";
	} else {
		%obj._huntDatablock = "GemItem" @ upperFirst(%obj.getSkinName());
	}
	%obj._huntColor = %obj.getSkinName();

	// create particles for PQ gems
	if (%this.pq) {
		%this.initFX(%obj);
	}
}

// TODO: allow fancy gem to have points in hunt/gem madness in PQ
function Gem::onPickup(%this,%obj,%user,%amount) {
	%pickup = Mode::callback("shouldPickupGem", true, new ScriptObject() {
		this = %this;
		obj = %obj;
		user = %user;
		amount = %amount;
		_delete = true;
	});
	if (%pickup) {
		//Item::onPickup may be false if item pickups are disabled
		if (!Parent::onPickup(%this,%obj,%user,%amount)) {
			return false;
		}
	}

	%ignore = Mode::callback("shouldIgnoreGem", false, new ScriptObject() {
		this = %this;
		obj = %obj;
		user = %user;
		amount = %amount;
		_delete = true;
	});
	if (%ignore)
		return false;

	%store = Mode::callback("shouldStoreGem", true, new ScriptObject() {
		this = %this;
		obj = %obj;
		user = %user;
		amount = %amount;
		_delete = true;
	});
	if (%store) {
		if ($Server::ServerType $= "MultiPlayer") {
			if (%user.client.gemPickup[%obj])
				return false;

			%user.client.gemPickup[%obj] = true;
			%user.client.gemPickups[%user.client.gemPickupCount] = %obj;
			%user.client.gemLookup[%obj] = %user.client.gemPickupCount;
			%user.client.gemPickupCount ++;
		}
	}

	%obj.getDataBlock().clearFX(%obj);

	%user.client.gemsFoundTotal ++;
	%user.client.onFoundGem(%amount, %obj);
	if (%obj.nukesweeper)
		%obj.trigger.getDataBlock().reset(%obj.trigger);
	return true;
}

function Gem::onMissionReset(%this, %obj) {
	%reset = Mode::callback("shouldResetGem", true, new ScriptObject() {
		this = %this;
		obj = %obj;
		_delete = true;
	});
	if (!%reset) {
		return %reset;
	}

	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		ClientGroup.getObject(%i).gemPickup[%obj] = 0;
	}

	return Parent::onMissionReset(%this, %obj);
}

function Gem::onInspectApply(%this, %obj) {
	if (%obj.getSkinName() $= "base") {
		%obj._huntDatablock = "GemItem";
	} else {
		%obj._huntDatablock = "GemItem" @ upperFirst(%obj.getSkinName());
	}
	%obj._huntColor = %obj.getSkinName();
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(StaticGem) {
	shapeFile = "~/data/shapes/items/gem.dts";
};

datablock ItemData(GemItem) {
	// Mission editor category
	superCategory = "gems";
	category = "Marble Blast Gold/Platinum";

	className = "Gem";

	// Basic Item properties
	shapeFile = "~/data/shapes/items/gem.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	emap = false;

	// Dynamic properties defined by the scripts
	pickupName = "a diamond!";
	maxInventory = 1;
	noRespawn = true;
	gemType = 1;
	noPickupMessage = true;
	pickUpCheckpoint = "0";
	huntPointValue = 0;

	checkpointRespawn = 1;

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

datablock ItemData(GemItemBlue: GemItem) {
	skin = "blue";
	huntExtraValue = 4; //1 less because you get 1 point for collecting it
	spawnChance = 0.35;
	messageColor = "6666ff";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemRed: GemItem) {
	skin = "red";
	huntExtraValue = 0; //1 pt
	spawnChance = 0.90;
	messageColor = "ff6666";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemYellow: GemItem) {
	skin = "yellow";
	huntExtraValue = 1; //2 pts
	spawnChance = 0.65;
	messageColor = "ffff66";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemPink: GemItem) {
	skin = "base";
	huntExtraValue = 0;
	spawnChance = 0.1;
	messageColor = "ff66ff";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemPurple: GemItem) {
	skin = "purple";
	huntExtraValue = 5; //6 pts
	spawnChance = 0.1;
	messageColor = "cc44ff";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemGreen: GemItem) {
	skin = "Green";
	huntExtraValue = 3; //4 pts
	spawnChance = 0.3;
	messageColor = "66ff66";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemTurquoise: GemItem) {
	skin = "Turquoise";
	huntExtraValue = 6; //7
	spawnChance = 0.1;
	messageColor = "55ffff";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemOrange: GemItem) {
	skin = "orange";
	huntExtraValue = 2; //3 pts
	spawnChance = 0.45;
	messageColor = "ffaa33";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemBlack: GemItem) {
	skin = "black";
	huntExtraValue = -2; //-1 pts
	spawnChance = 0.45;
	messageColor = "000000";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemPlatinum: GemItem) {
	skin = "platinum";
	huntExtraValue = 9; //10 pts
	spawnChance = 0.18;
	messageColor = "dddddd";
	customField[0, "field"] = "";
};

// datablock ItemData(GemItemSpecialPurple: GemItem) {
// 	skin = "specialpurple";
// 	huntExtraValue = 9; //10 pts
// 	spawnChance = 0.90;
// 	messageColor = "d461ff";
// 	customField[0, "field"] = "";
// };

// datablock ItemData(GemItemSpecialYellow: GemItem) {
// 	skin = "specialyellow";
// 	huntExtraValue = 19; //20 pts
// 	spawnChance = 0.65;
// 	messageColor = "f0e161";
// 	customField[0, "field"] = "";
// };

// datablock ItemData(GemItemSpecialPlatinum: GemItem) {
// 	skin = "specialplatinum";
// 	huntExtraValue = 49; //50 pts
// 	spawnChance = 0.35;
// 	messageColor = "a0a0a0";
// 	customField[0, "field"] = "";
// };

// datablock ItemData(GemItemWhite: GemItem) {
// 	skin = "white";
// 	huntExtraValue = -1; //0 pts
// 	spawnChance = 0.80;
// 	messageColor = "ffffff";
// 	customField[0, "field"] = "";
// };

// datablock ItemData(GemItemRainbow: GemItem) {
// 	skin = "rainbow";
// 	huntExtraValue = 8; //9 pts
// 	spawnChance = 0.24;
// 	messageColor = "4b0082";
// 	customField[0, "field"] = "";
// };

datablock ItemData(GemItem_PQ : GemItem) {
	superCategory = "gems";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/Gems/gem.dts";
	pickupName = "a gem!";
	pq = true; // for gemFX

	fxEmitter[0] = "GemEmitter";
	fxSkin[0] = true;


	customField[0, "field"  ] = "noParticles";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Disable Particles";
	customField[0, "desc"   ] = "If the gem should not spawn a particle emitter.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "skin";
	customField[1, "type"   ] = "string";
	customField[1, "name"   ] = "Skin Name";
	customField[1, "desc"   ] = "Which skin to use (see skin selector).";
	customField[1, "default"] = "";
};

datablock ItemData(GemItemBlue_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "blue";
	huntExtraValue = 4; //1 less because you get 1 point for collecting it
	spawnChance = 0.35;
	messageColor = "9999ff";
	customField[1, "disable"] = 1;
};

datablock ItemData(GemItemRed_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "red";
	huntExtraValue = 0; //1 pt
	spawnChance = 0.90;
	messageColor = "ff9999";
	customField[1, "disable"] = 1;
};

datablock ItemData(GemItemYellow_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "yellow";
	huntExtraValue = 1; //2 pts
	spawnChance = 0.65;
	messageColor = "ffff99";
	customField[1, "disable"] = 1;
};

datablock ItemData(GemItemPink_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "base";
	customField[1, "disable"] = 1;
};

datablock ItemData(GemItemPurple_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "purple";
	customField[1, "disable"] = 1;
};

datablock ItemData(GemItemGreen_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "Green";
	customField[1, "disable"] = 1;
};

datablock ItemData(GemItemTurquoise_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "Turquoise";
	customField[1, "disable"] = 1;
};

datablock ItemData(GemItemOrange_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "orange";
	customField[1, "disable"] = 1;
};

datablock ItemData(GemItemBlack_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "black";
	customField[1, "disable"] = 1;
};

datablock ItemData(GemItemPlatinum_PQ: GemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "platinum";
	huntExtraValue = 9; //10 pts
	spawnChance = 0.18;
	messageColor = "cccccc";
	customField[1, "disable"] = 1;
};

// datablock ItemData(GemItemSpecialPurple_PQ: GemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "specialpurple";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(GemItemSpecialYellow_PQ: GemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "specialyellow";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(GemItemSpecialPlatinum_PQ: GemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "specialplatinum";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(GemItemWhite_PQ: GemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "white";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(GemItemRainbow_PQ: GemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "rainbow";
// 	customField[1, "disable"] = 1;
// };

datablock ItemData(FancyGemItem_PQ : GemItem) {
	superCategory = "gems";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/Gems/gem_fancy.dts";
	skin[0] = "base";
	skin[1] = "red";
	skin[2] = "yellow";
	skin[3] = "blue";
	skin[4] = "pink";
	skin[5] = "purple";
	skin[6] = "green";
	skin[7] = "turquoise";
	skin[8] = "orange";
	skin[9] = "black";
	skin[10] = "platinum";
	skin[11] = "specialpurple";
	skin[12] = "specialyellow";
	skin[13] = "specialplatinum";

	pickupName = "a gem!";
	pq = true; // for GemFX

	fxEmitter[0] = "GemEmitter";
	fxSkin[0] = true;

	customField[0, "field"  ] = "noParticles";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Disable Particles";
	customField[0, "desc"   ] = "If the gem should not spawn a particle emitter.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "skin";
	customField[1, "type"   ] = "string";
	customField[1, "name"   ] = "Skin Name";
	customField[1, "desc"   ] = "Which skin to use (see skin selector).";
	customField[1, "default"] = "";
};

datablock ItemData(FancyGemItemBlue_PQ: FancyGemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "blue";
	huntExtraValue = 4; //1 less because you get 1 point for collecting it
	spawnChance = 0.35;
	messageColor = "9999ff";
	customField[1, "disable"] = 1;
};

datablock ItemData(FancyGemItemRed_PQ: FancyGemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "red";
	huntExtraValue = 0; //1 pt
	spawnChance = 0.90;
	messageColor = "ff9999";
	customField[1, "disable"] = 1;
};

datablock ItemData(FancyGemItemYellow_PQ: FancyGemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "yellow";
	huntExtraValue = 1; //2 pts
	spawnChance = 0.65;
	messageColor = "ffff99";
	customField[1, "disable"] = 1;
};

// datablock ItemData(FancyGemItemPink_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "base";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(FancyGemItemPurple_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "purple";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(FancyGemItemGreen_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "Green";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(FancyGemItemTurquoise_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "Turquoise";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(FancyGemItemOrange_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "orange";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(FancyGemItemBlack_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "black";
// 	customField[1, "disable"] = 1;
// };

datablock ItemData(FancyGemItemPlatinum_PQ: FancyGemItem_PQ) {
	superCategory = "gems";
	category = "PlatinumQuest";

	skin = "platinum";
	huntExtraValue = 9; //10 pts
	spawnChance = 0.18;
	messageColor = "cccccc";
	customField[1, "disable"] = 1;
};

// datablock ItemData(FancyGemItemSpecialPurple_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "specialpurple";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(FancyGemItemSpecialYellow_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "specialyellow";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(FancyGemItemSpecialPlatinum_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "specialplatinum";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(FancyGemItemWhite_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "white";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(FancyGemItemRainbow_PQ: FancyGemItem_PQ) {
// 	superCategory = "gems";
// 	category = "PlatinumQuest";

// 	skin = "rainbow";
// 	customField[1, "disable"] = 1;
// };

// datablock ItemData(GemItem_MBU : GemItem) {
// 	shapeFile = "~/data/shapes_mbu/items/gem.dts";

// 	pickupName = "a gem!";

// 	customField[0, "field"  ] = "skin";
// 	customField[0, "type"   ] = "string";
// 	customField[0, "name"   ] = "Skin Name";
// 	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
// 	customField[0, "default"] = "";
// };

// datablock ItemData(GemItemRed_MBU : GemItem_MBU) {
// 	skin = "red";
// 	huntExtraValue = 0; //1 pt
// 	spawnChance = 0.90;
// 	messageColor = "ff9999";
// 	customField[0, "field"] = "";
// };

// datablock ItemData(GemItemYellow_MBU : GemItem_MBU) {
// 	skin = "yellow";
// 	huntExtraValue = 1; //2 pts
// 	spawnChance = 0.65;
// 	messageColor = "ffff99";
// 	customField[0, "field"] = "";
// };

// datablock ItemData(GemItemBlue_MBU : GemItem_MBU) {
// 	skin = "blue";
// 	huntExtraValue = 4; //1 less because you get 1 point for collecting it
// 	spawnChance = 0.35;
// 	messageColor = "9999ff";
// 	customField[0, "field"] = "";
// };

// datablock ItemData(GemItemPlatinum_MBU : GemItem_MBU) {
// 	skin = "platinum";
// 	huntExtraValue = 9; //10 pts
// 	spawnChance = 0.18;
// 	messageColor = "cccccc";
// 	customField[0, "field"] = "";
// };

datablock ItemData(GemItem_BM : GemItem) {
	superCategory = "gems";
	category = "Blasted";

	shapeFile = "~/data/shapes_bm/Gems/Gem_BM.dts";
	pickupName = "a gem!";

	customField[0, "field"  ] = "noParticles";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Disable Particles";
	customField[0, "desc"   ] = "If the gem should not spawn a particle emitter.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "skin";
	customField[1, "type"   ] = "string";
	customField[1, "name"   ] = "Skin Name";
	customField[1, "desc"   ] = "Which skin to use (see skin selector).";
	customField[1, "default"] = "";
};

datablock ItemData(GemItemPurple_BM : GemItem_BM) {
	superCategory = "gems";
	category = "Blasted";

 	skin = "purple";
	customField[0, "field"] = "";
};

//-----------------------------------------------------------------------------

datablock ItemData(BackupGem) {
	// Basic Item properties
	shapeFile = "~/data/shapes/items/gem.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	emap = false;

	// Dynamic properties defined by the scripts
	pickupName = "a diamond!";
	maxInventory = 1;
	noRespawn = true;
	gemType = 1;
	noPickupMessage = true;

	renderEditor = true;

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

//-----------------------------------------------------------------------------

datablock ParticleData(GemParticleBase) {
	textureName          = "~/data/particles/glint";
	dragCoeffiecient     = 0.1;
	gravityCoefficient   = 0;
	windCoefficient      = 0;
	inheritedVelFactor   = 0;
	constantAcceleration = 0;
	lifetimeMS           = 1500;
	lifetimeVarianceMS   = 100;
	useInvAlpha   = true;
	spinSpeed     = 1;
	spinRandomMin = -5.0;
	spinRandomMax = 5.0;

	colors[0] = "1.000000 0.000000 1.000000 1.000000";
	colors[1] = "1.000000 0.382353 1.000000 1.000000";
	colors[2] = "1.000000 0.490196 1.000000 0.000000";

	sizes[0]      = 0.15;
	sizes[1]      = 0.05;
	sizes[2]      = 0.05;

	times[0]      = 0;
	times[1]      = 0.75;
	times[2]      = 1.0;
};

datablock ParticleEmitterData(GemEmitterBase) {
	ejectionPeriodMS = 40;
	periodVarianceMS = 0;
	ejectionVelocity = 0.3;
	velocityVariance = 0.01;
	thetaMin         = 0.0;
	thetaMax         = 150.0;
	lifetimeMS       = 0;
	particles = "GemParticleBase";
};

datablock ParticleData(GemParticleGreen : GemParticleBase) {
	colors[0]     = "0.2 1.0 0.2 1.0";
	colors[1]     = "0.5 1.0 0.5 1.0";
	colors[2]     = "0.5 1.0 0.5 0.0";
};

datablock ParticleEmitterData(GemEmitterGreen : GemEmitterBase) {
	particles = "GemParticleGreen";
};

datablock ParticleData(GemParticleRed : GemParticleBase) {
	colors[0]     = "0.8 0.1 0.1 1.0";
	colors[1]     = "0.8 0.3 0.3 1.0";
	colors[2]     = "0.8 0.3 0.3 0.0";
};

datablock ParticleEmitterData(GemEmitterRed : GemEmitterBase) {
	particles = "GemParticleRed";
};

datablock ParticleData(GemParticleBlue : GemParticleBase) {
	colors[0]     = "0.2 0.4 1.0 1.0";
	colors[1]     = "0.5 0.7 1.0 1.0";
	colors[2]     = "0.5 0.7 1.0 0.0";
};

datablock ParticleEmitterData(GemEmitterBlue : GemEmitterBase) {
	particles = "GemParticleBlue";
};

datablock ParticleData(GemParticleBlack : GemParticleBase) {
	colors[0]     = "0.2 0.2 0.2 1.0";
	colors[1]     = "0.5 0.5 0.5 1.0";
	colors[2]     = "0.5 0.5 0.5 0.0";
};

datablock ParticleEmitterData(GemEmitterBlack : GemEmitterBase) {
	particles = "GemParticleBlack";
};

datablock ParticleData(GemParticlePlatinum : GemParticleBase) {
	colors[0]     = "0.5 0.5 0.5 1.0";
	colors[1]     = "0.7 0.7 0.7 1.0";
	colors[2]     = "1.0 1.0 1.0 0.5";
	colors[3]     = "1.0 1.0 1.0 0.0";
	sizes[3] = 0.2;
	times[2] = 0.95;
	times[3] = 1;
};

datablock ParticleEmitterData(GemEmitterPlatinum : GemEmitterBase) {
	particles = "GemParticlePlatinum";
};

datablock ParticleData(GemParticleYellow : GemParticleBase) {
	colors[0]     = "1.0 1.0 0.2 1.0";
	colors[1]     = "1.0 1.0 0.5 1.0";
	colors[2]     = "1.0 1.0 0.5 0.0";
};

datablock ParticleEmitterData(GemEmitterYellow : GemEmitterBase) {
	particles = "GemParticleYellow";
};

datablock ParticleData(GemParticlePurple : GemParticleBase) {
	colors[0]     = "0.8 0.3 1.0 1.0";
	colors[1]     = "0.8 0.5 1.0 1.0";
	colors[2]     = "0.8 0.5 1.0 0.0";
};

datablock ParticleEmitterData(GemEmitterPurple : GemEmitterBase) {
	particles = "GemParticlePurple";
};

datablock ParticleData(GemParticleOrange : GemParticleBase) {
	colors[0]     = "1.0 0.8 0.2 1.0";
	colors[1]     = "1.0 0.8 0.5 1.0";
	colors[2]     = "1.0 0.8 0.5 0.0";
};

datablock ParticleEmitterData(GemEmitterOrange : GemEmitterBase) {
	particles = "GemParticleOrange";
};

datablock ParticleData(GemParticlePink : GemParticleBase) {
	colors[0] = "1.000000 0.000000 1.000000 1.000000";
	colors[1] = "1.000000 0.382353 1.000000 1.000000";
	colors[2] = "1.000000 0.490196 1.000000 0.000000";
};

datablock ParticleEmitterData(GemEmitterPink : GemEmitterBase) {
	particles = "GemParticlePink";
};

datablock ParticleData(GemParticleTurquoise : GemParticleBase) {
	colors[0]     = "0.2 1.0 1.0 1.0";
	colors[1]     = "0.5 1.0 1.0 1.0";
	colors[2]     = "0.5 1.0 1.0 0.0";
};

datablock ParticleEmitterData(GemEmitterTurquoise : GemEmitterBase) {
	particles = "GemParticleTurquoise";
};

//MBU Datablocks down below.

if (!$pref::LegacyItems) {
	datablock ItemData(GemItem_MBU : GemItem) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		shapeFile = "~/data/shapes_mbu/items/gem.dts";

		pickupName = "a gem!";
		skin[0] = "base";
		skin[1] = "red";
		skin[2] = "yellow";
		skin[3] = "blue";
		skin[4] = "pink";
		skin[5] = "purple";
		skin[6] = "green";
		skin[7] = "turquoise";
		skin[8] = "orange";
		skin[9] = "black";
		skin[10] = "platinum";
		skin[11] = "specialpurple";
		skin[12] = "specialyellow";
		skin[13] = "specialplatinum";

		customField[0, "field"  ] = "skin";
		customField[0, "type"   ] = "string";
		customField[0, "name"   ] = "Skin Name";
		customField[0, "desc"   ] = "Which skin to use (see skin selector).";
		customField[0, "default"] = "";
	};
	datablock ItemData(GemItemRed_MBU : GemItem_MBU) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		skin = "red";
		huntExtraValue = 0; //1 pt
		spawnChance = 0.90;
		messageColor = "ff9999";
		customField[0, "field"] = "";
	};
	datablock ItemData(GemItemYellow_MBU : GemItem_MBU) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		skin = "yellow";
		huntExtraValue = 1; //2 pts
		spawnChance = 0.65;
		messageColor = "ffff99";
		customField[0, "field"] = "";
	};
	datablock ItemData(GemItemBlue_MBU : GemItem_MBU) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		skin = "blue";
		huntExtraValue = 4; //1 less because you get 1 point for collecting it
		spawnChance = 0.35;
		messageColor = "9999ff";
		customField[0, "field"] = "";
	};
	datablock ItemData(GemItemPlatinum_MBU : GemItem_MBU) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		skin = "platinum";
		huntExtraValue = 9; //10 pts
		spawnChance = 0.18;
		messageColor = "cccccc";
		customField[0, "field"] = "";
	};
    // datablock ItemData(GemItemPink_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

	//     skin = "base";
	//     huntExtraValue = 0;
	//     spawnChance = 0.1;
    // 	messageColor = "ff66ff";
	//     customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemPurple_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

	//     skin = "purple";
	//     huntExtraValue = 5; //6 pts
	//     spawnChance = 0.1;
	//     messageColor = "cc44ff";
	//     customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemGreen_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

	//     skin = "Green";
	//     huntExtraValue = 3; //4 pts
	//     spawnChance = 0.3;
	//     messageColor = "66ff66";
	//     customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemTurquoise_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "Turquoise";
    // 	huntExtraValue = 6; //7
    // 	spawnChance = 0.1;
    // 	messageColor = "55ffff";
    // 	customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemOrange_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "orange";
    // 	huntExtraValue = 2; //3 pts
    // 	spawnChance = 0.45;
    // 	messageColor = "ffaa33";
    // 	customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemBlack_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "black";
    // 	huntExtraValue = -2; //-1 pts
    // 	spawnChance = 0.45;
    // 	messageColor = "000000";
    // 	customField[0, "field"] = "";
    // };		
    // datablock ItemData(GemItemWhite_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "white";
    // 	huntExtraValue = -1; //0 pts
    // 	spawnChance = 0.80;
    // 	messageColor = "000000";
    // 	customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemRainbow_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "rainbow";
    // 	huntExtraValue = 8; //9 pts
    // 	spawnChance = 0.24;
    // 	messageColor = "4b0082";
    // 	customField[0, "field"] = "";
    // };
} else {
	datablock ItemData(GemItem_MBU : GemItem) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		shapeFile = "~/data/shapes/items/gem.dts";

		pickupName = "a gem!";
		skin[0] = "base";
		skin[1] = "red";
		skin[2] = "yellow";
		skin[3] = "blue";
		skin[4] = "pink";
		skin[5] = "purple";
		skin[6] = "green";
		skin[7] = "turquoise";
		skin[8] = "orange";
		skin[9] = "black";
		skin[10] = "platinum";
		skin[11] = "specialpurple";
		skin[12] = "specialyellow";
		skin[13] = "specialplatinum";

		customField[0, "field"  ] = "skin";
		customField[0, "type"   ] = "string";
		customField[0, "name"   ] = "Skin Name";
		customField[0, "desc"   ] = "Which skin to use (see skin selector).";
		customField[0, "default"] = "";
	};
	datablock ItemData(GemItemRed_MBU : GemItem_MBU) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		skin = "red";
		huntExtraValue = 0; //1 pt
		spawnChance = 0.90;
		messageColor = "ff9999";
		customField[0, "field"] = "";
	};
	datablock ItemData(GemItemYellow_MBU : GemItem_MBU) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		skin = "yellow";
		huntExtraValue = 1; //2 pts
		spawnChance = 0.65;
		messageColor = "ffff99";
		customField[0, "field"] = "";
	};
	datablock ItemData(GemItemBlue_MBU : GemItem_MBU) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		skin = "blue";
		huntExtraValue = 4; //1 less because you get 1 point for collecting it
		spawnChance = 0.35;
		messageColor = "9999ff";
		customField[0, "field"] = "";
	};
	datablock ItemData(GemItemPlatinum_MBU : GemItem_MBU) {
		superCategory = "gems";
		category = "Marble Blast Ultra";

		skin = "platinum";
		huntExtraValue = 9; //10 pts
		spawnChance = 0.18;
		messageColor = "cccccc";
		customField[0, "field"] = "";
	};		
    // datablock ItemData(GemItemPink_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

	//     skin = "base";
	//     huntExtraValue = 0;
	//     spawnChance = 0.1;
    // 	messageColor = "ff66ff";
	//     customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemPurple_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

	//     skin = "purple";
	//     huntExtraValue = 5; //6 pts
	//     spawnChance = 0.1;
	//     messageColor = "cc44ff";
	//     customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemGreen_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

	//     skin = "Green";
	//     huntExtraValue = 3; //4 pts
	//     spawnChance = 0.3;
	//     messageColor = "66ff66";
	//     customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemTurquoise_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "Turquoise";
    // 	huntExtraValue = 6; //7
    // 	spawnChance = 0.1;
    // 	messageColor = "55ffff";
    // 	customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemOrange_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "orange";
    // 	huntExtraValue = 2; //3 pts
    // 	spawnChance = 0.45;
    // 	messageColor = "ffaa33";
    // 	customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemBlack_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "black";
    // 	huntExtraValue = -2; //-1 pts
    // 	spawnChance = 0.45;
    // 	messageColor = "000000";
    // 	customField[0, "field"] = "";
    // };	
    // datablock ItemData(GemItemWhite_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "white";
    // 	huntExtraValue = -1; //0 pts
    // 	spawnChance = 0.80;
    // 	messageColor = "000000";
    // 	customField[0, "field"] = "";
    // };
    // datablock ItemData(GemItemRainbow_MBU: GemItem_MBU) {
	// 	superCategory = "gems";
	// 	category = "Marble Blast Ultra";

    // 	skin = "rainbow";
    // 	huntExtraValue = 8; //9 pts
    // 	spawnChance = 0.24;
    // 	messageColor = "4b0082";
    // 	customField[0, "field"] = "";
    // };				
}