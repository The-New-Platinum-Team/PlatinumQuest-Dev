//-----------------------------------------------------------------------------
// Prop Hunt mode
//
// Originally created in 2015
//
// Copyright (c) 2024 The Platinum Team
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

function Mode_props::onLoad(%this) {
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("shouldPickupItem");
	%this.registerCallback("shouldDisablePowerup");
	%this.registerCallback("shouldPickupGem");
	%this.registerCallback("shouldIgnoreGem");
	%this.registerCallback("shouldStoreGem");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("shouldDisableShockwave");
	%this.registerCallback("onTimeExpire");
	%this.registerCallback("onCollision");
	%this.registerCallback("enableMarbleCollisions");
	%this.registerCallback("onServerGo");
	%this.registerCallback("onBlast");
	%this.registerCallback("onUpdateGhost");
	%this.registerCallback("onGameState");
	%this.registerCallback("onClientEnterGame");
	%this.registerCallback("onClientLeaveGame");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("shouldAllowTTs");
	%this.registerCallback("onEnterPad");
	%this.registerCallback("onOutOfBounds");
	%this.registerCallback("onQuickRespawnPlayer");
	%this.registerCallback("getStartTime");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	%this.registerCallback("shouldSetSpectate");
	%this.registerCallback("getMaxSpectators");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("shouldRestorePowerup");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("onRespawnOnCheckpoint");
	%this.registerCallback("onServerChat");
	%this.registerCallback("getPlayerListSkin");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_props::onMissionReset(%this) {
	//Seek variable
	$Game::Seeking = false;
	//Cancel countdown
	cancelSeekCountdown();

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setHunter(false);
		%client.playerListGem = $GemSkinColors[getRandom(1, 10)];
		%client.hat.delete();
		if (%client.propEliminated) {
			%client.setSpectating(false);
			%client.propEliminated = false;
		}
		//For testing offline
		if (!mp())
			%client.wasHunter = !%client.wasHunter;
	}
	onNextFrame(commandToAll, 'ReloadReflections');
}
function Mode_props::onMissionEnded(%this) {
	//Reset all the clients
	$Game::Seeking = false;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setHunter(false);
		%client.playerListGem = "";
		if (isObject(%client.player)) {
			%client.player.setMode(Normal);
		}
		if (%client.propEliminated) {
			if (isObject(%client.player))
				%client.player.delete();
			%client.setSpectating(false);
			%client.propEliminated = false;
		}
	}
	onNextFrame(commandToAll, 'ReloadReflections');
	cancelSeekCountdown();
}
function Mode_props::shouldPickupItem(%this, %object) {
	if (%object.obj.prop)
		return false;
	if (!%object.user.client.hunter) {
		if ($Game::Seeking)
			return false;
		if (getSubStr(%object.obj.getDatablock().getName(), 0, 14) $= "MegaMarbleItem")
			return false;
	}
	return true;
}
function Mode_props::shouldDisablePowerup(%this, %object) {
	return !%this.shouldPickupItem(%object);
}
function Mode_props::shouldPickupGem(%this, %object) {
	return false;
}
function Mode_props::shouldIgnoreGem(%this, %object) {
	return true;
}
function Mode_props::shouldStoreGem(%this, %object) {
	return false;
}
function Mode_props::shouldRespawnGems(%this, %object) {
	return false;
}
function Mode_props::shouldDisableShockwave(%this, %object) {
	return !%object.this.client.hunter;
}
function Mode_props::onTimeExpire(%this) {
	if ($Game::Seeking) {
		endGameSetup();
	} else {
		startHunting();
	}
	return false;
}
function Mode_props::onCollision(%this, %object) {
	if ($Game::Seeking) {
		if (%object.client1.hunter != %object.client2.hunter) {
			//Someone got tagged
			if (%object.client1.hunter) {
				%object.client1.propFound(%object.client2);
			} else {
				%object.client2.propFound(%object.client1);
			}
		}
	}
}
function Mode_props::enableMarbleCollisions(%this) {
	return true;
}
function Mode_props::onServerGo(%this) {
	//Choose the hunters
	chooseHunters();
	startDisguise();
}
function Mode_props::onBlast(%this, %object) {
	%findRadius = %object.this.client.blastValue * 3;
	if (%object.this.client.usingTripleBlast) {
		%findRadius = 1.2;
	}
	if (%object.this.client.usingSpecialBlast) {
		%findRadius = 3;
	}
	// if (%object.other.client.isMegaMarble()) {
	// 	return;
	// }
	%mePos = %object.this.getWorldBoxCenter();
	%theyPos = %object.other.getWorldBoxCenter();
	if (VectorDist(%mePos, %theyPos) < %findRadius && %object.this.client.hunter && !%object.other.client.hunter) {
		//Someone got tagged
		%object.this.client.propFound(%object.other.client);
	}
}
function Mode_props::onUpdateGhost(%this, %object) {
	%object.client.updatePropMarble();
}
function Mode_props::onGameState(%this, %object) {
	if (%object.state $= "go" && !$Game::Seeking && %object.client.hunter) {
		%object.client.player.setMode(Start);
	}
}
function Mode_props::onClientEnterGame(%this, %object) {
	if (isGameStarted() && mp()) {
		//If you join mid-game, you aren't allowed to play, to prevent cheating via spectator stuff
		%object.client.setSpectating(true);
	}
	commandToClient(%object.client, 'SeekGracePeriod');
}
function Mode_props::onClientLeaveGame(%this, %object) {
	//Don't break the ongoing game if someone leaves
	%object.client.setHunter(false);
	detectHunterUpdate();
}
function Mode_props::timeMultiplier(%this) {
	return -1;
}
function Mode_props::shouldResetTime(%this) {
	return false;
}
function Mode_props::shouldRestartOnOOB(%this) {
	return false;
}
function Mode_props::onEndGameSetup(%this) {
	checkHuntVictory();
}
function Mode_props::shouldAllowTTs(%this) {
	return false;
}
function Mode_props::onEnterPad(%this, %object) {
	return true;
}
function Mode_props::onOutOfBounds(%this, %object) {
	if ($Game::Seeking && !%object.client.hunter) {
		//No going OOB as a hider
		%object.client.propEliminated();
		%object.client.addBubbleLine("No going out of bounds!");
		serverSendChat("<color:6666ff>" @ %object.client.getDisplayName() SPC "went out of bounds!");
		commandToAll('playPitchedSound', opponentDiamond);
		whiteAll(0.05);
		detectHunterUpdate();
	}
}
function Mode_props::onQuickRespawnPlayer(%this, %object) {
	if ($Game::Seeking && !%object.client.hunter) {
		//No quick respawning as a hider
		%object.client.propEliminated();
		%object.client.addBubbleLine("No quick respawning!");
		serverSendChat("<color:6666ff>" @ %object.client.getDisplayName() SPC "went out of bounds!");
		commandToAll('playPitchedSound', opponentDiamond);
		whiteAll(0.05);
		detectHunterUpdate();
	}
}
function Mode_props::getStartTime(%this) {
	return MissionInfo.disguiseTime ? MissionInfo.disguiseTime : 50000;
}
function Mode_props::getScoreType(%this) {
	return $ScoreType::Score;
}
function Mode_props::getFinalScore(%this, %object) {
	return $ScoreType::Score TAB %object.client.getGemCount();
}
function Mode_props::shouldSetSpectate(%this, %object) {
	//No spectating to find the hiders
	return false;
}
function Mode_props::getMaxSpectators(%this) {
	//Need at least two players
	return getRealPlayerCount() - 2;
}
function Mode_props::onFoundGem(%this, %object) {
	%object.client.playPitchedSound("gotDiamond");
}
function Mode_props::shouldRestorePowerup(%this) {
	return true;
}
function Mode_props::shouldRespawnGems(%this) {
	return false;
}
function Mode_props::onDeactivate(%this) {
	%this.onMissionEnded();
}
function Mode_props::onRespawnOnCheckpoint(%this, %object) {
	if ($Game::Seeking && !%object.client.hunter) {
		%object.client.propEliminated();
		%object.client.addBubbleLine("No quick respawning!");
		serverSendChat("<color:6666ff>" @ %object.client.getDisplayName() SPC "went out of bounds!");
		detectHunterUpdate();
	}
	if (!$Game::Seeking && (%object.client.state $= "go" || %object.client.state $= "end") && %object.client.hunter) {
		%object.client.player.setMode(Start);
	}
}
function Mode_props::onServerChat(%this, %object) {
	//Seek chat command
	if (getWord(%object.message, 0) $= "/left") {
		//Check how many hiders are left
		%hiders = 0;
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (!%client.hunter && %client.isActive()) {
				%hiders ++;
			}
		}
		if (%hiders == 1) {
			%object.client.sendChat("There is 1 prop left.");
		} else {
			%object.client.sendChat("There are" SPC %hiders SPC "props left.");
		}
		return true;
	}
}
function Mode_props::getPlayerListSkin(%this, %object) {
	if (!$Game::Running || !$Server::Started)
		return %object.client.skinChoice;
	//Display a gem on the player list
	if (!%object.client.hunter && isObject(%object.client.prop) && %object.client.isActive()) {
		%skinChoice = "platinum/data/shapes/items/gem.dts" TAB %object.client.playerListGem TAB "" TAB "" TAB "";
	} else {
		%skinChoice = %object.client.skinChoice;
	}
	return %skinChoice;
}

//--------------------------------------------------------------------------

function GameConnection::propFound(%this, %client) {
	//Let us know
	%this.addBubbleLine("You have found" SPC %client.getDisplayName() @ "!");
	%this.onFoundGem(1);
	%this.gemsFound[10] ++;

	serverSendChat("<color:6666ff>" @ %this.getDisplayName() SPC "has found" SPC %client.getDisplayName() @ "!");

	//Let them know
	%client.propEliminated();
	%client.addBubbleLine("You have been found!");

	detectHunterUpdate();
}

function GameConnection::propEliminated(%this) {
	//Remove their prop
	%this.clearProp();

	//Make them a spectator, and set the camera to where they were found
	%transform = %this.player.getEstCameraTransform();
	%this.camera.setTransform(%transform);
	commandToClient(%this, 'propEliminated', %transform);
	%this.setSpectating(true);
	%this.deletePlayer();
	%this.propEliminated = true;
}

function GameConnection::setHunter(%this, %hunter) {
	%this.hunter = %hunter;
	%this.updateGhostDatablock();
	if (%hunter || !$Game::Seeking) {
		%this.clearProp();
		commandToClient(%this, 'ClearPropLayer');
	}
	updatePlayerList();
}

function GameConnection::updatePropMarble(%this) {
	if (!$Game::isMode["props"])
		return;
	if (!%this.hunter && isObject(%this.prop) && %this.isActive() && (%this.state $= "go" || %this.state $= "end")) {
		//Make the prop's marble invisible
		%this.player.setDatablock(NullMarble);
		if (%this.isMegaMarble()) {
			%this.player.setCollisionRadius(Mode::callback("getMegaMarbleSize", 0.6666, new ScriptObject() {
				client = %this;
				skinChoice = %this.skinChoice;
				_delete = true;
			}));
		} else {
			%this.player.setCollisionRadius(Mode::callback("getMarbleSize", 0.18975, new ScriptObject() {
				client = %this;
				skinChoice = %this.skinChoice;
				_delete = true;
			}));
		}
		//Delete trail emitters
		for (%i = 0; %i < %this.player.trailEmitters; %i ++) {
			%emitter = %this.player.trailEmitter[%i];
			if (isObject(%emitter))
				%emitter.delete();
		}
		%this.player.trailEmitters = 0;
		if ($Game::Seeking) {
			commandToClient(%this, 'PushPropLayer');
		}
	}
	//Reassign trail emitters if they're not a prop
	if (%this.hunter && !%this.player.trailEmitters && %this.isActive()) {
		%this.player.assignNewTrailEmitter(0, "Trail",           "MarbleTrailEmitter");
		%this.player.assignNewTrailEmitter(1, "WhiteTrail",      "MarbleWhiteTrailEmitter");
		%this.player.assignNewTrailEmitter(2, "Splash4",         "Splash4Emitter");
		%this.player.assignNewTrailEmitter(3, "TrailBubble",     "MarbleTrailBubbleEmitter");
		%this.player.assignNewTrailEmitter(4, "Fireball3",       "Fireball3Emitter");
		%this.player.assignNewTrailEmitter(5, "Fireball4_2",     "Fireball4_2Emitter");
		%this.player.assignNewTrailEmitter(6, "Fireball3Mega",   "Fireball3MegaEmitter");
		%this.player.assignNewTrailEmitter(7, "Fireball4_2Mega", "Fireball4_2MegaEmitter");
	}
	commandToClient(%this, 'ReloadReflections');
}

//--------------------------------------------------------------------------

function detectHunterUpdate() {
	if (!isGameStarted())
		return;
	if ($Editor::Opened)
		return;

	//Check if nobody is a seeker. If that's the case, we need a new seeker!
	//Also check if everyone is a seeker. If so, the seekers win!
	%seekers = 0;
	%hiders = 0;

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		//Don't count disconnected people, or spectators
		if (%client.hunter && %client.isActive()) {
			%seekers ++;
		} else if (!%client.hunter && %client.isActive()) {
			%hiders ++;
		}
	}

	//If we're all out of hiders, game over
	if (%hiders == 0 || %seekers == 0) {
		endGameSetup();
	}
}


function chooseHunters() {
	setRandomSeed($Sim::Time);

	//For testing offline
	if (!mp()) {
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.setHunter(!%client.wasHunter);
		}
		return;
	}

	//Make half the lobby hunters
	%possible = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setHunter(false);

		if (!%client.isActive())
			continue;

		%clients[%possible] = %client;
		%possible ++;
	}
	%p = mFloor(%possible / 2);
	for (%i = 0; %i < %p; %i ++) {
		%random = getRandom(0, %possible - 1);
		%hunter = %clients[%random];
		%hunter.setHunter(true);
		echo("[Mode Props]: Choosing" SPC %hunter.getDisplayName() SPC "as a hunter.");
		%clients[%random] = "";
		for (%j = %random; %j < %possible - 2; %j ++) {
			%clients[%j] = %clients[%j + 1];
		}
		%possible --;
	}
}

//--------------------------------------------------------------------------

function startDisguise() {
	//Init hiding period
	$Game::Seeking = false;
	$Props::Endmessage = false;
	cancelSeekCountdown();
	%time = (MissionInfo.disguiseTime ? MissionInfo.disguiseTime : 50000);
	Time::stop();
	Time::set(%time);
	Time::start();
	startSeekCountdown(%time, "Hunting begins in %s second(s)!", startHunting);

	//Stop the seeker, let the hiders go
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		//%client.updateGhostDatablock();


		if (%client.hunter) {
			//The seeker is anchored to the start pad
			%client.resetCheckpoint();
			%client.player.setMode(Start);
			%client.player.trailEmitter[8].delete();
			%client.addBubbleLine("Prop hunt! Try to find which props are fake!");


		} else if (%client.isActive()) {
			%client.setProp(getDefaultProp());
			%client.addBubbleLine("You\'ve been disguised! Try to blend in.");
		}
	}
	detectHunterUpdate();
}

function startHunting() {
	$Game::Seeking = true;
	cancelSeekCountdown();
	Time::stop();
	%time = (MissionInfo.Time ? MissionInfo.Time : 300000);
	Time::set(%time);
	Time::start();
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		//%client.updateGhostDatablock();
		

		//Start both the seeker and the hiders
		if (%client.hunter) {
			%client.player.setMode(Normal);
			%client.addBubbleLine("Good luck!");

		} else if (%client.isActive()) {
			%client.player.lockPowerup();
			commandToClient(%client, 'PushPropLayer');
			%client.addBubbleLine("Good luck!");
		}
	}
	detectHunterUpdate();
}

//--------------------------------------------------------------------------

function checkHuntVictory() {
	cancelSeekCountdown();
	if ($Props::Endmessage)
		return;

	//Count the total number of hiders and seekers to see who wins
	%seekers = 0;
	%hiders = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		//Don't count disconnected people, or spectators
		if (%client.hunter && %client.isActive()) {
			%seekers ++;
		} else if (!%client.hunter && %client.isActive()) {
			%hiders ++;
		}
	}
	
	$Props::Endmessage = true;

	if (%hiders != 0) {
		serverSendChat("<color:66ff66>The props have won!");

		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.winner = (!%client.hunter && %client.isActive());
			if (%client.winner) {
				%client.gemsFound[5] ++;
			}
		}
	} else if (%hiders == 0 && %seekers != 0) {
		serverSendChat("<color:66ff66>The hunters have won!");

		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.winner = (%client.hunter && %client.gemsFound[10] > 0 && %client.isActive());
		}
	} else {
		//Nobody is left...

		//Nobody wins!
	}

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.gemCount = (%client.hunter ? %client.gemsFound[10] * 15 : ((getPlayingPlayerCount() - 1) * 10) * %client.gemsFound[5]);
		%client.setGemCount(%client.gemCount);
	}
	updateScores();
}

//--------------------------------------------------------------------------

function GameConnection::clearProp(%this) {
	if (!isObject(%this.prop))
		return;
	%this.prop.clearFX(%this.prop);
	%this.prop.delete();
	%this.updateGhostDatablock();

	//Winterfest hat support
	%this.hat.hide(false);
}

//List of allowed props
$Props::AllowedProps = "GemItem GemItem_PQ GemItem_MBU FancyGemItem_PQ SuperSpeedItem SuperSpeedItem_PQ SuperSpeedItem_MBU SuperJumpItem SuperJumpItem_PQ SuperJumpItem_MBUHelicopterItem HelicopterItem_PQ HelicopterItem_MBU ShockAbsorberItem ShockAbsorberItem_PQ SuperBounceItem SuperBounceItem_PQ AntiGravityItem AntiGravityItem_PQ AntiGravityItem_MBU TimeTravelItem TimeTravelItem_PQ TimeTravelItem_MBU TimePenaltyItem TimePenaltyItem_PQ MegaMarbleItem MegaMarbleItem_MBU BlastItem BlastItem_MBU AnvilItem TeleportItem BubbleItem FireballItem SundialItem_PQ RandomPowerUpItem DefaultMarble PartyHatImage CandyItemRed CandyItemYellow CandyItemBlue Plant01 Tulip";

function GameConnection::setProp(%this, %prop) {
	if (!$Game::isMode["props"])
		return;
	if (%this.hunter)
		return;

	if (isObject(%this.prop)) {
		%this.prop.clearFX(%this.prop);
		%this.prop.delete();
	}

	//Only use these props, otherwise use the default
	if (strStr(strlwr($Props::AllowedProps), strlwr(%prop)) == -1)
		%prop = "GemItem";

	//Class is the datablock class sans "Data" (e.g. ItemData -> Item)
	%propClass = getSubStr(%prop.getClassName(), 0, strlen(%prop.getClassName()) - 4);

	//<Client>.prop = new <Class>() {
	//   scale = "<Client Scale>";
	//   datablock = "<Datablock>";
	//   prop = "1";
	//   client = "<Client>";
	//};
	eval(%this @ ".prop = new " @ %propClass @ "() { scale = \"" @ %this.scale @ "\"; datablock = \"" @ %prop @ "\"; prop = \"1\"; client = \"" @ %this @ "\"; };");

	if (%propClass $= "Item") {
		%this.prop.static = true;
		%this.prop.rotate = true;
		%this.prop.collideable = false;
	}

	if (%prop.superCategory $= "Hazards") {
		%this.prop.setPoweredState(0);
		%this.prop.stopAudio(0);
	}

	MissionCleanup.add(%this.prop);
	%this.updatePropMarble();

	%this.prop.setSync("DetectProp", %this.player.getSyncId());
}


function GameConnection::setPropFX(%this) {
	for (%i = 0; isObject(%this.prop._fx[%i]); %i ++) {
		%this.prop._fx[%i].setSync("DetectPropFX", %this.prop.getSyncId());
	}
}

function getDefaultProp() {
	if (isObject(MissionInfo.defaultProp))
		return MissionInfo.defaultProp;
	%game = MissionInfo.game;
	return %game $= "PlatinumQuest" ? "GemItem_PQ" : (%game $= "Ultra" ? "GemItem_MBU" : "GemItem");
}

function serverCmdSetProp(%client, %prop) {
	%client.setProp(%prop);
}

datablock MarbleData(NullMarble : LBDefaultMarble) {
	shapeFile = "~/data/shapes/images/Blank.dts"; //TODO: Make a blank marble DTS

	bounceEmitter = "";
};