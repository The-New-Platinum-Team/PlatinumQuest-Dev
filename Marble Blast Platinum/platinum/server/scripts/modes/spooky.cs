//------------------------------------------------------------------------------
// Multiplayer Package
// Halloween Mode
//
// Copyright (c) 2015 The Platinum Team
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

function Mode_spooky::onLoad(%this) {
	echo("[Mode" SPC %this.name @ "]: Loaded!");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onCreatePlayer");
	%this.registerCallback("onActivate");
	%this.registerCallback("onDeactivate");
}
function Mode_spooky::onMissionEnded(%this) {
	// cancel event schedules
	cancel($lightningLoop);
}
function Mode_spooky::onMissionReset(%this) {
	startLightning();
}
function Mode_spooky::onCreatePlayer(%this, %object) {
	%object.client.createGhostHat(WitchHat, WitchHatBig);
}
function Mode_spooky::onActivate(%this) {
	SnoreParticle.colors[0] = "0.787402 0.000000 0.000000 1.000000";
	SnoreParticle.colors[1] = "0.787402 0.000000 0.000000 1.000000";
	SnoreParticle.colors[2] = "1.000000 0.000000 0.000000 0.000000";
	SnoreParticle.colors[3] = "1.000000 0.000000 0.000000 1.000000";
}
function Mode_spooky::onDeactivate(%this) {
	SnoreParticle.colors[0] = "0.787402 1.000000 0.787402 1.000000";
	SnoreParticle.colors[1] = "0.787402 1.000000 0.787402 1.000000";
	SnoreParticle.colors[2] = "1.000000 1.000000 1.000000 0.000000";
	SnoreParticle.colors[3] = "1.000000 1.000000 1.000000 1.000000";
}

//-----------------------------------------------------------------------------

function serverCmdSpookyGhosts(%client, %enable) {
	if (%client.isHost()) {
		$MP::Server::SpookyGhosts = %enable;
		commandToAll('SpookyGhosts', %enable);
	}
}

//-----------------------------------------------------------------------------

datablock AudioProfile(lightningSfx) {
	filename    = "~/data/sound/lightning_impact.wav";
	description = Audio2D;
	preload = true;
};
datablock AudioProfile(quietLightningSfx) {
	filename    = "~/data/sound/lightning_impact.wav";
	description = Quieter3D;
	preload = true;
};

function startLightning() {
	$Game::LightningLevel = 3;
	lightningLoop();
}

function lightningLoop() {
	if (!$Game::Running) {
		return;
	}
	cancel($lightningLoop);

	$Game::LightningLevel += 0.05;

	if ($Game::LightningLevel < 1) {
		//Pre-lighting strike, going to strike when it hits 1.0
		//Slightly higher chance of striking
		if (getRandom() < 0.05) {
			whiteAll(0.15);
			serverPlay2d(quietLightningSfx);
		}
	} else {
		//Post-strike, just have random bursts
		if (getRandom() < 0.03) {
			whiteAll(0.15);
			serverPlay2d(quietLightningSfx);
		}
	}
	if ($Game::LightningLevel >= 1 && $Game::LightningLevel < 2) {
		//Strike!
		whiteAll(0.7);
		serverPlay2d(lightningSfx);
		//Strike eventually, but give it some time
		$Game::LightningLevel = 2 + (getRandom() * 7);
	}
	//Make it take a while to strike again
	if ($Game::LightningLevel > 16) {
		$Game::LightningLevel = 0;
	}
	$lightningLoop = schedule(500, 0, lightningLoop);
}

function whiteAll(%amount) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setWhiteOut(%amount);
	}
}


//---------------------------------------------------------------------
// Halloween Scenery

datablock StaticShapeData(CandyBasket) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/candy_basket.dts";
	renderDistance = "60";
};

datablock StaticShapeData(HayBale) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/Hay_bale.dts";
	renderDistance = "60";
};

datablock StaticShapeData(HayCube) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/Hay_cube.dts";
	renderDistance = "60";
};

datablock StaticShapeData(HayStack) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/Hay_stack.dts";
	renderDistance = "60";
};

datablock StaticShapeData(CandyPileBig) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/pile-o-candy_big.dts";
	renderDistance = "20";
};

datablock StaticShapeData(CandyPileSmall) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/pile-o-candy_small.dts";
	renderDistance = "20";
};

datablock StaticShapeData(PumpkinScary) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/pumpkin.dts";
	renderDistance = "60";
};

datablock StaticShapeData(PumpkinRegular) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/pumpkin__normal_bad.dts";
	renderDistance = "60";
};

datablock StaticShapeData(PumpkinDent) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/pumpkin_bad.dts";
	renderDistance = "60";
};

datablock StaticShapeData(PumpkinBigDent) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/pumpkin_bad_bad.dts";
	renderDistance = "60";
};

datablock StaticShapeData(PumpkinScaryNoLight) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/pumpkin_scarry_bad.dts";
	renderDistance = "60";
};

datablock StaticShapeData(Bat) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/bat.dts";
	renderDistance = "100";
};

function Bat::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
}

datablock StaticShapeData(CandyCorn) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/candy_corn.dts";
};

// Gems

datablock StaticShapeData(CandyCollectable) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/candy_collectable.dts";
};

function CandyCollectable::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
}

datablock StaticShapeData(MrSkeletal) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/spooky_skeleton.dts";
	renderDistance = "100";
};

datablock StaticShapeData(MrSkeletalSad) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/sad_skeleton.dts";
	renderDistance = "100";
};

datablock StaticShapeData(MrSkeletalTired) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/tired_skeleton.dts";
	renderDistance = "100";
};

datablock StaticShapeData(Cobwebs) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/spider_web.dts";
	renderDistance = "30";
};

datablock StaticShapeData(WitchHat) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/WitchHatNormal.dts";
	renderDistance = "30";
};

datablock StaticShapeData(WitchHatBig) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/WitchHatBig.dts";
	renderDistance = "100";
};

// Vermontry (January edition)

datablock StaticShapeData(Vermontry) {
	className = "Halloween";
	category = "Halloween";
	shapefile = $usermods @ "/data/shapes/Halloween/Vermontry/Vermontry.dts";

	noBox = true;
};

function Vermontry::onAdd(%this, %obj) {
	%obj.playThread(0, "Rotate");
}


// Xmas lights in Halloween

datablock StaticShapeData(HalloweenLights2U) {
	className = "Halloween";
	category = "Halloween";
	emap = "true";
	shapefile = $usermods @ "/data/shapes/Halloween/HalloweenLights_2T.dts";
	renderDistance = "20";
};

function HalloweenLights2U::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

datablock StaticShapeData(HalloweenLights3U) {
	className = "Halloween";
	category = "Halloween";
	emap = "true";
	shapefile = $usermods @ "/data/shapes/Halloween/HalloweenLights_3T.dts";
	renderDistance = "20";
};

function HalloweenLights3U::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

datablock StaticShapeData(HalloweenLights6U) {
	className = "Halloween";
	category = "Halloween";
	emap = "true";
	shapefile = $usermods @ "/data/shapes/Halloween/HalloweenLights_6T.dts";
	renderDistance = "20";
};

function HalloweenLights6U::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

datablock StaticShapeData(HalloweenLights9U) {
	className = "Halloween";
	category = "Halloween";
	emap = "true";
	shapefile = $usermods @ "/data/shapes/Halloween/HalloweenLights_9T.dts";
	renderDistance = "20";
};

function HalloweenLights9U::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%obj.playThread(1, "ambient2");
}

//-----------------------------------------------------------------------------

datablock AudioProfile(CandyCornSfx) {
	filename    = "~/data/sound/candycorn.wav";
	description = AudioDefault3D;
	preload = true;
};

datablock ItemData(CandyCornItem) {
	category = "Halloween";
	shapeFile = $usermods @ "/data/shapes/Halloween/candy_corn.dts";

	// Basic Item properties
	pickupAudio = CandyCornSfx;
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	emap = false;

	// Dynamic properties defined by the scripts
	noRespawn = true;
	maxInventory = 0;
};

function CandyCornItem::onAdd(%this, %obj) {

}

function CandyCornItem::onPickup(%this, %obj, %user, %amount) {
	%time = (Mode::callback("getStartTime", 0) - $Time::CurrentTime) + $Time::TotalBonus;

	//Send a tcp request
	commandToClient(%user.client, 'CandyCorn', %time);
	%user.client.play2D(CandyCornSfx);
	%obj.hide(true);
	messageClient(%user.client, 'MsgItemPickup', "Ooh a piece of candy!");
	return true;
}

//-----------------------------------------------------------------------------

datablock ItemData(CandyItem : GemItem) {
	shapeFile = "~/data/shapes/Halloween/candy_gem.dts";
	category = "Halloween";
	pickupName = "a pile of candy!";
};

datablock ItemData(CandyItemRed : GemItemRed) {
	shapeFile = "~/data/shapes/Halloween/candy_gem.dts";
	category = "Halloween";
	pickupName = "a pile of candy!";
	messageColor = "cc3333";
};

datablock ItemData(CandyItemYellow : GemItemYellow) {
	shapeFile = "~/data/shapes/Halloween/candy_gem.dts";
	category = "Halloween";
	pickupName = "a pile of candy!";
	messageColor = "cc7033";
	skin = "orange";
};

datablock ItemData(CandyItemBlue : GemItemBlue) {
	shapeFile = "~/data/shapes/Halloween/candy_gem.dts";
	category = "Halloween";
	pickupName = "a pile of candy!";
	messageColor = "000000";
	skin = "black";
};

function CandyItem::onAdd(%this, %obj) {
	Gem::onAdd(%this, %obj);
	%obj._huntDatablock = %this.getName();
}
function CandyItemRed::onAdd(%this, %obj) {
	Gem::onAdd(%this, %obj);
	%obj._huntDatablock = %this.getName();
}
function CandyItemYellow::onAdd(%this, %obj) {
	Gem::onAdd(%this, %obj);
	%obj._huntDatablock = %this.getName();
}
function CandyItemBlue::onAdd(%this, %obj) {
	Gem::onAdd(%this, %obj);
	%obj._huntDatablock = %this.getName();
}
