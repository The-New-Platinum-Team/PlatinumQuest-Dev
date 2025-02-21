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

// Hooray

$Party::HatColor[0] = "base";
$Party::HatColor[1] = "brown";
$Party::HatColor[2] = "green";
$Party::HatColor[3] = "orange";
$Party::HatColor[4] = "pink";
$Party::HatColor[5] = "purple";
$Party::HatColor[6] = "red";
$Party::HatColor[7] = "yellow";
$Party::HatColors = 8;

$Party::Mode[0] = "sssuper";
$Party::Mode[1] = "float";
$Party::Mode[2] = "randpup";
$Party::Mode[3] = "instantpup";
$Party::Mode[4] = "nojump";
$Party::Mode[5] = "alljump";
$Party::Mode[6] = "releasio";
$Party::Mode[7] = "mega";
$Party::Mode[8] = "mini";
$Party::Mode[9] = "big";
$Party::Mode[10] = "small";
$Party::Mode[11] = "helicoptery";
$Party::Mode[12] = "steal";
$Party::Mode[13] = "fastpoints";
$Party::Mode[14] = "squish";
$Party::Mode[15] = "squash";
$Party::Mode[16] = "joj";
$Party::Mode[17] = "madness";
$Party::Mode[18] = "forwardsj";
$Party::Mode[19] = "monstermega";

$Party::ModeChance[0] = 1;
$Party::ModeChance[1] = 0.3;
$Party::ModeChance[2] = 1;
$Party::ModeChance[3] = 1;
$Party::ModeChance[4] = 0.4;
$Party::ModeChance[5] = 0.2;
$Party::ModeChance[6] = 0.1;
$Party::ModeChance[7] = 0.5;
$Party::ModeChance[8] = 0.3;
$Party::ModeChance[9] = 0.5;
$Party::ModeChance[10] = 0.2;
$Party::ModeChance[11] = 0.8;
$Party::ModeChance[12] = 2;
$Party::ModeChance[13] = 1;
$Party::ModeChance[14] = 0.4;
$Party::ModeChance[15] = 0.4;
$Party::ModeChance[16] = 0.01;
$Party::ModeChance[17] = 0.2;
$Party::ModeChance[18] = 1;
$Party::ModeChance[19] = 1;

$Party::Modes = 20;

$Party::ModesPerMap = 4;

//In order of how good they are
$Party::Pup[0] = "HelicopterItem";
$Party::Pup[1] = "SuperJumpItem";
$Party::Pup[2] = "AnvilItem";
$Party::Pup[3] = "SuperSpeedItem";
$Party::Pup[4] = "BlastItem";
$Party::Pup[5] = "MegaMarbleItem";
$Party::Pup[6] = "ShockAbsorberItem";
$Party::Pup[7] = "SuperBounceItem";
$Party::Pup[8] = "TeleportItem";
$Party::Pup[9] = "TimeTravelItem";
$Party::Pup[10] = "AntiGravityItem";
$Party::Pups = 11;

function Mode_party::onLoad(%this) {
	%this.registerCallback("onActivate");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("onCreatePlayer");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("getMarbleSize");
	%this.registerCallback("getMegaMarbleSize");
	%this.registerCallback("onBlast");
	%this.registerCallback("onHuntGemSpawn");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}

function Mode_party::onActivate(%this) {
	partyPickModes();
}

function Mode_party::onDeactivate(%this) {
	deleteVariables("$Party::Server::ActiveMode*");
}

function Mode_party::onCreatePlayer(%this, %data) {
	%client = %data.client;
	%hat = %client.createGhostHat(PartyHatImage, PartyHatLargeImage);
	%hat.setSkinName($Party::HatColor[getRandom(0, $Party::HatColors - 1)]);
}

function Mode_party::getMarbleSize(%this, %object) {
	%marble = %object.client.getMarbleChoice();
	%db = getField(%marble, 0);

	if ($Party::Server::ActiveMode["mega"]) {
		return 0.6666;
	}
	if ($Party::Server::ActiveMode["mini"]) {
		return 0.05;
	}
	return %db.scale;
}

function Mode_party::getMegaMarbleSize(%this, %object) {
	%marble = %object.client.getMarbleChoice();
	%db = getField(%marble, 0);

	if ($Party::Server::ActiveMode["monstermega"]) {
		return 3;
	}
	if ($Party::Server::ActiveMode["mega"]) {
		return 0.18975;
	}
	if ($Party::Server::ActiveMode["mini"]) {
		return 0.18975;
	}
	return %db.megaScale;
}

function Mode_party::onMissionReset(%this) {
	$Party::MegaScale = "1 1 1";
	partyPickModes();
}

function Mode_party::onBlast(%this, %object) {
	if ($Party::Server::ActiveMode["steal"] && $Game::State !$= "End") {
		%mePos = %object.this.getWorldBoxCenter();
		%theyPos = %object.other.getWorldBoxCenter();

		%stealRad = %object.this.client.blastValue * 6;
		%stealRad += (%object.this.client.getPing() * 0.05);

		if (VectorDist(%mePos, %theyPos) < %stealRad) {
			//Steal their points
			%steal = (%object.this.client.blastValue * 5);
			if (%object.this.client.isMegaMarble()) {
				%steal *= 2;
			}
			%steal = mRound(min(%steal, %object.other.client.gemCount));

			if (%steal > 0) {
				%object.this.client.onFoundGem(%steal);
				%object.other.client.onFoundGem(-%steal);

				%object.this.client.displayGemMessage("+" @ %steal, "88ff88");
				%object.other.client.displayGemMessage("-" @ %steal, "ff8888");
			}
		}
	}
}

function Mode_party::onHuntGemSpawn(%this) {
	if ($Party::Server::ActiveMode["madness"]) {
		hideGems();
		makeGemGroup(MissionGroup, true);
		makeGemGroup(MissionCleanup);
		for (%i = 0; %i < $GemsCount; %i ++) {
			%gem = $Gems[%i];
			%gem.hide(false);
		}
		$Hunt::CurrentGemCount = $GemsCount;
	}
}

function partyPickModes() {
	//Pick some party modes and do em!

	%availModes = "";
	%max = 0;
	for (%i = 0; %i < $Party::Modes; %i ++) {
		%availModes = addWord(%availModes, %i);
		%max += $Party::ModeChance[%i];
	}
	%modeCount = mCeil(mSqrt(getRandom()) * $Party::ModesPerMap);

	%modes = "";
	for (%i = 0; %i < %modeCount; %i ++) {
		%rand = getRandom() * %max;
		echo("rand: " @ %rand);

		for (%j = 0; %j < getWordCount(%availModes); %j ++) {
			%avail = getWord(%availModes, %j);
			if ($Party::ModeChance[%avail] < %rand) {
				%rand -= $Party::ModeChance[%avail];
				continue;
			}

			%mode = $Party::Mode[%avail];
			%availModes = removeWord(%availModes, %avail);
			%modes = addWord(%modes, %mode);

			echo("was: " @ %mode);

			%chance = $Party::ModeChance[%avail];
			%max -= %chance;

			break;
		}
	}

	setPartyModes(%modes);
}

function setPartyModes(%modes) {
	echo("[Mode Party]: Got party mode list:" SPC %modes);

	deleteVariables("$Party::Server::ActiveMode*");
	for (%i = 0; %i < getWordCount(%modes); %i ++) {
		$Party::Server::ActiveMode[%i] = getWord(%modes, %i);
		$Party::Server::ActiveMode[getWord(%modes, %i)] = true;
	}
	$Party::Server::ActiveModes = getWordCount(%modes);

	commandToAll('SetPartyModes', %modes);

	if (!$Server::Lobby) {
		serverSendChat("Party Modes: " @ %modes);
	}

	partyApply();
}

function partyApply() {
	if ($Party::Server::ActiveMode["big"]) {
		megaScale("2 2 2");
	} else if ($Party::Server::ActiveMode["small"]) {
		megaScale("0.5 0.5 0.5");
	} else if ($Party::Server::ActiveMode["squish"]) {
		megaScale("1 1 0.25");
	} else if ($Party::Server::ActiveMode["squash"]) {
		megaScale("0.25 0.25 1");
	}

	if ($Party::Server::ActiveMode["steal"]) {
		activateMode("steal");
	}

	if ($Party::Server::ActiveMode["randpup"] || $Party::Server::ActiveMode["helicoptery"]) {
		partySwapItems(true);
	} else {
		partySwapItems(false);
	}

	partyLoop();
}

function partyLoop() {
	cancel($partySchedule);
	if (!$Game::isMode["party"]) {
		return;
	}

	$partyCounter ++;

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!isObject(%client.player)) {
			continue;
		}

		if ($Party::Server::ActiveMode["fastpoints"] && (($partyCounter + %i) % 10) == 0 && !%client.isOOB) {
			%speed = VectorLen(%client.player.getVelocity());
			if (%speed > 50) {
				%client.onFoundGem(5);
				%client.displayGemMessage("+5", "cccccc");
			} else if (%speed > 40) {
				%client.onFoundGem(4);
				%client.displayGemMessage("+4", "cccccc");
			} else if (%speed > 30) {
				%client.onFoundGem(3);
				%client.displayGemMessage("+3", "cccccc");
			} else if (%speed > 20) {
				%client.onFoundGem(2);
				%client.displayGemMessage("+2", "cccccc");
			} else if (%speed > 10) {
				%client.onFoundGem(1);
				%client.displayGemMessage("+1", "cccccc");
			}
		}
	}

	$partySchedule = schedule(250, 0, partyLoop);
}

package Mode_party {
	function party() {
		echo("Party party party, I want to have a party!");
	}
};

function megaScale(%scale) {
	if (getWordCount(%scale) == 1) {
		%scale = %scale SPC %scale SPC %scale;
	}

	%old = $Party::MegaScale;
	if (%old !$= "") {
		%old = (1 / getWord(%old, 0)) SPC (1 / getWord(%old, 1)) SPC (1 / getWord(%old, 2));
		scaleGroup(%old, MissionGroup);
		scaleGroup(%old, MissionCleanup);
	}

	$Party::MegaScale = %scale;
	scaleGroup(%scale, MissionGroup);
	scaleGroup(%scale, MissionCleanup);
}

function scaleGroup(%scale, %group) {
	for (%i = 0; %i < %group.getCount(); %i ++) {
		%obj = %group.getObject(%i);
		if (%obj.getClassName() $= "SimGroup") {
			scaleGroup(%scale, %obj);
		} else {
			%obj.setScale(VectorMult(%obj.scale, %scale));
			%obj.setTransform(VectorMult(getWords(%obj.getTransform(), 0, 2), %scale) SPC getWords(%obj.getTransform(), 3, 6));
		}
	}
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(PartyHatImage) {
	// Basic Item properties
	shapeFile = "~/data/shapes_pq/party/hat/PartyHat.dts";
	emap = true;
};

datablock StaticShapeData(PartyHatLargeImage) {
	// Basic Item properties
	shapeFile = "~/data/shapes_pq/party/hat/PartyHatMega.dts";
	emap = true;
};

//-----------------------------------------------------------------------------

function partySwapItems(%enable) {
	RootGroup.add(%set = new SimSet(PartySwapSet));
	addAll("PowerUps", %set, "MissionGroup");

	for (%i = 0; %i < %set.getCount(); %i ++) {
		%item = %set.getObject(%i);

		%item.hide(%enable);

		if (isObject(%item.party)) {
			%item.party.hide(!%enable);
		}

		if (!isObject(%item.party) && %enable) {
			MissionCleanup.add(%item.party = new Item() {
				position = %item.position;
				rotation = %item.rotation;
				scale = %item.scale;
				dataBlock = "PartyItem";
				collideable = %item.collideable;
				static = %item.static;
				rotate = %item.rotate;
				item = %item;
			});
		}
	}

	%set.delete();
}

datablock ItemData(PartyItem) {
	// Mission editor category
	category = "PowerUps";
	className = "PowerUp";
	powerUpId = 10;

	pickupAudio = PuSuperJumpVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes/items/random.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	// Dynamic properties defined by the scripts
	maxInventory = 1;
	coopClient = 1;
	emap = false;
};


function PartyItem::getPickupName(%this, %obj) {
	return "a Party Item!";
}

function PartyItem::onPickup(%this,%obj,%user,%amount) {
	%client = %user.client;
	%place = %client.getPlace();
	%count = $MP::TeamMode ? TeamGroup.getCount() : ClientGroup.getCount();

	//So better players get worse pups
	%lowBound = mClamp(mRound($Party::Pups - ($Party::Pups / %count * %place)), 0, $Party::Pups - 1);
	//So lesser players don't get worse pups
	%highBound = mClamp(%lowBound + 5, 0, $Party::Pups - 1);

	%pup = $Party::Pup[getRandom(%lowBound, %highBound)];

	if ($Party::Server::ActiveMode["helicoptery"]) {
		%pup = "HelicopterItem";
	}

	echo("[Mode Party]: Cause you're in " @ %place @ "/" @ %count @ " place you can get pups index from " @ %lowBound @ " to " @ %highBound);
	echo("[Mode Party]: And you got... " @ %pup);

	%noRespawn = %pup.noRespawn;
	%timeBonus = %obj.timeBonus;
	%pup.noRespawn = false;
	%obj.timeBonus = 1000;
	%r = %pup.onPickup(%obj,%user,%amount);
	%pup.noRespawn = %noRespawn;
	%obj.timeBonus = %timeBonus;
	return %r;
}