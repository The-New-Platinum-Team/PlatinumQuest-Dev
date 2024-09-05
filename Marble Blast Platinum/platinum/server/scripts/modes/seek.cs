//-----------------------------------------------------------------------------
// Hide and Seek mode
//
// Originally created in 2015
//
// Copyright (c) 2023 The Platinum Team
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

function Mode_seek::onLoad(%this) {
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
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
	%this.registerCallback("updateWinner");
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
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("onRespawnOnCheckpoint");
	%this.registerCallback("onServerChat");
	%this.registerCallback("getPlayerListSkin");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_seek::onMissionReset(%this) {
	//Seek variable
	$Game::Seeking = false;
	//Cancel countdown
	cancelSeekCountdown();
	//Choose the seeker
	chooseSeeker();
	//No gems in this mode
	hideGems();

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.player.onNextFrame(setCloaked, false);
		%client.hat.setCloaked(false);
	}
}
function Mode_seek::onMissionEnded(%this) {
	//Reset all the clients
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setSeeker(false);
		commandToClient(%client, 'ClearSeekLayers');
		if (isObject(%client.player)) {
			%client.player.setCloaked(false);
			%client.hat.setCloaked(false);
			%client.player.setMode(Normal);
		}
	}
	cancelSeekCountdown();
}
function Mode_seek::onTimeExpire(%this) {
	if ($Game::Seeking) {
		endGameSetup();
	} else {
		startSeeking();
	}
	return false;
}
function Mode_seek::onCollision(%this, %object) {
	if ($Game::Seeking) {
		if (%object.client1.seeker != %object.client2.seeker) {
			//Someone got tagged
			if (%object.client1.seeker) {
				%object.client1.onFind(%object.client2);
			} else {
				%object.client2.onFind(%object.client1);
			}
		}
	}
}
function Mode_seek::enableMarbleCollisions(%this) {
	return true;
}
function Mode_seek::onServerGo(%this) {
	startHiding();
}
function Mode_seek::onBlast(%this, %object) {
	if ($Game::Seeking) {
		%findRadius = %object.this.client.blastValue * 4;
		if (%object.this.client.usingTripleBlast) {
			%findRadius = 1.6;
		}
		if (%object.this.client.usingSpecialBlast) {
			%findRadius = 4;
		}
		if (%object.this.client.isMegaMarble()) {
			%findRadius /= $MP::MegaBlastModifier;
		}
		if (%object.other.client.isMegaMarble()) {
			return;
		}
		%mePos = %object.this.getWorldBoxCenter();
		%theyPos = %object.other.getWorldBoxCenter();
		if (VectorDist(%mePos, %theyPos) < %findRadius && %object.this.client.seeker && !%object.other.client.seeker) {
			//Someone got tagged
			%object.this.client.onFind(%object.other.client);
		}
	}
}
function Mode_seek::onUpdateGhost(%this, %object) {
	%object.client.updateSeekerMarble();
}
function Mode_seek::onGameState(%this, %object) {
	if (%object.state $= "go" && !$Game::Seeking && %object.client.seeker) {
		%object.client.player.setMode(Start);
	}
}
function Mode_seek::onClientEnterGame(%this, %object) {
	if (isGameStarted() && mp()) {
		//If you join mid-game, you aren't allowed to play, to prevent cheating via spectator stuff
		%object.client.setSpectating(true);
	}
	commandToClient(%object.client, 'SeekGracePeriod');
}
function Mode_seek::onClientLeaveGame(%this, %object) {
	//Don't break the ongoing game if someone leaves
	%object.client.setSeeker(false);
	detectSeekerUpdate();
}
function Mode_seek::timeMultiplier(%this) {
	return -1;
}
function Mode_seek::shouldResetTime(%this) {
	return false;
}
function Mode_seek::shouldRestartOnOOB(%this) {
	return false;
}
function Mode_seek::onEndGameSetup(%this) {
	checkSeekVictory();
}
function Mode_seek::updateWinner(%this, %winners) {
	updateSeekWinner(%winners);
}
function Mode_seek::shouldAllowTTs(%this) {
	return false;
}
function Mode_seek::onEnterPad(%this, %object) {
	return true;
}
function Mode_seek::onOutOfBounds(%this, %object) {
	if ($Game::Seeking && !%object.client.seeker) {
		//No going OOB as a hider
		%object.client.setSeeker(true);
		%object.client.addBubbleLine("No going out of bounds! Go find the other players!");
		serverSendChat("<color:ff6666>" @ %object.client.getDisplayName() SPC "went out of bounds!");
		commandToAll('playPitchedSound', opponentDiamond);
		whiteAll(0.05);
		detectSeekerUpdate();
	}
}
function Mode_seek::onQuickRespawnPlayer(%this, %object) {
	if ($Game::Seeking && !%object.client.seeker) {
		//No quick respawning as a hider
		%object.client.setSeeker(true);
		%object.client.addBubbleLine("No quick respawning! Go find the other players!");
		serverSendChat("<color:ff6666>" @ %object.client.getDisplayName() SPC "went out of bounds!");
		commandToAll('playPitchedSound', opponentDiamond);
		whiteAll(0.05);
		detectSeekerUpdate();
	}
}
function Mode_seek::getStartTime(%this) {
	return MissionInfo.hideTime ? MissionInfo.hideTime : 30000;
}
function Mode_seek::getScoreType(%this) {
	return $ScoreType::Score;
}
function Mode_seek::getFinalScore(%this, %object) {
	return $ScoreType::Score TAB %object.client.getGemCount();
}
function Mode_seek::shouldSetSpectate(%this, %object) {
	//No spectating to find the hiders
	return false;
}
function Mode_seek::getMaxSpectators(%this) {
	//Need at least two players
	return getRealPlayerCount() - 2;
}
function Mode_seek::onFoundGem(%this, %object) {
	%object.client.playPitchedSound("gotDiamond");
}
function Mode_seek::shouldRestorePowerup(%this) {
	return true;
}
function Mode_seek::onRespawnPlayer(%this, %object) {
	if (!$Game::Seeking && (%object.client.state $= "go" || %object.client.state $= "end") && !%object.client.seeker) { 
		//Recloak them, as the cloak disappears on respawn
		%object.client.player.setCloaked(true);
	}
}
function Mode_seek::shouldRespawnGems(%this) {
	return false;
}
function Mode_seek::onDeactivate(%this) {
	%this.onMissionEnded();
}
function Mode_seek::onRespawnOnCheckpoint(%this, %object) {
	if ($Game::Seeking && !%object.client.seeker) {
		%object.client.setSeeker(true);
		%object.client.addBubbleLine("No quick respawning! Go find the other players!");
		serverSendChat("<color:ff6666>" @ %object.client.getDisplayName() SPC "went out of bounds!");
		detectSeekerUpdate();
	}
	if (!$Game::Seeking && (%object.client.state $= "go" || %object.client.state $= "end") && !%object.client.seeker) {
		%object.client.player.setCloaked(true);
	}
	if (!$Game::Seeking && (%object.client.state $= "go" || %object.client.state $= "end") && %object.client.seeker) {
		%object.client.player.setMode(Start);
	}
}
function Mode_seek::onServerChat(%this, %object) {
	//Seek chat command
	if (getWord(%object.message, 0) $= "/left") {
		//Check how many hiders are left
		%hiders = 0;
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (!%client.seeker && %client.isActive()) {
				%hiders ++;
			}
		}
		if (%hiders == 1) {
			%object.client.sendChat("There is 1 hider left.");
		} else {
			%object.client.sendChat("There are" SPC %hiders SPC "hiders left.");
		}
		return true;
	}
}
function Mode_seek::getPlayerListSkin(%this, %object) {
	if (!$Game::Running || !$Server::Started) {
		return %object.client.skinChoice;
	} else if (!%object.client.isActive()) {
		return "platinum/data/shapes/images/Blank.dts" TAB "" TAB "" TAB "" TAB "";
	}
	//Which skin should be displayed in the player list?
	if (%object.client.seeker) {
		%skinChoice = "platinum/data/shapes/balls/ball-superball.dts" TAB "skin50" TAB getField(%object.client.skinChoice, 2) TAB getField(%object.client.skinChoice, 3) TAB getField(%object.client.skinChoice, 4);
	} else if (findField(%object.client.skinChoice, "skin50") != -1) {
		%skinChoice = "platinum/data/shapes/balls/ball-superball.dts" TAB "base" TAB getField(%object.client.skinChoice, 2) TAB getField(%object.client.skinChoice, 3) TAB getField(%object.client.skinChoice, 4);
	} else {
		%skinChoice = %object.client.skinChoice;
	}
	return %skinChoice;
}

//--------------------------------------------------------------------------

function GameConnection::onFind(%this, %client) {
	//Let us know
	%this.addBubbleLine("You have found" SPC %client.getDisplayName() @ "!");
	%this.onFoundGem(1);
	%this.gemsFound[5] ++;

	serverSendChat("<color:ff6666>" @ %this.getDisplayName() SPC "has found" SPC %client.getDisplayName() @ "!");

	//Let them know
	%client.setSeeker(true);
	%client.addBubbleLine("You have been found! Go find the other players!");

	detectSeekerUpdate();
}

function GameConnection::setSeeker(%this, %seeker) {
	%this.seeker = %seeker;
	%this.updateGhostDatablock();
	if (%seeker) {
		%this.setNameTag("<color:ff6666>" @ %this.getDisplayName());
	} else {
		%this.setNameTag("");
	}
	updatePlayerList();
}

function GameConnection::updateSeekerMarble(%this) {
	//Hider slowdown, Seeker speedup, Seeker skin, shape fixing
	if (%this.seeker) {
		%this.player.setSkinName("skin50");
		%this.player.setDatablock(SeekerMarble);
		commandToClient(%this, 'PushSeekerLayer');
	}
	if (!%this.seeker && $Game::Seeking) {
		%this.checkSkinCheat();
		commandToClient(%this, 'PushHiderLayer');
	}
	if (!%this.seeker && (!$Game::Seeking || !$Game::isMode["seek"])) {
		%this.checkSkinCheat();
		commandToClient(%this, 'ClearSeekLayers');
	}
	commandToClient(%this, 'ReloadReflections');
}

function GameConnection::checkSkinCheat(%this) {
	//No using the "hex" skin while you are a hider
	%marble = %this.getMarbleChoice();
	%skin = getField(%marble, 1);

	if (%skin $= "skin50" && !%this.seeker) {
		%this.player.setSkinName("base");
	}
}

//--------------------------------------------------------------------------

function detectSeekerUpdate() {
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
		if (%client.seeker && %client.isActive()) {
			%seekers ++;
		} else if (!%client.seeker && %client.isActive()) {
			%hiders ++;
		}
	}

	//Choose a new seeker if we need to
	if (%seekers == 0) {
		//This might cause the next statement to trigger, if you only have one player left who is a hider. So we do this first.
		%hiders --;
		%seekers ++;
		if (%hiders > 0) {
			chooseSeeker();
			serverSendChat(LBChatColor("notification") @ "The seekers have left! Picking a new one...");
		}
	}
	//If we're all out of hiders, game over
	if (%hiders <= 0) {
		endGameSetup();
	}
}


function chooseSeeker() {
	setRandomSeed($Sim::Time);

	if (mp() && isObject($Seek::LastInitial))
		echo("[Mode Seek]: Last seeker was" SPC $Seek::LastInitial.getDisplayName() SPC "so we\'ll pick someone new.");

	//Make everyone a hider except for one seeker
	%possible = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setSeeker(false);

		//Don't let the same person go twice
		if ($Seek::LastInitial.getId() == %client.getId())
			continue;

		if (!%client.isActive())
			continue;

		%clients[%possible] = %client;
		%possible ++;
	}

	//Pick them from ClientGroup at random
	%seeker = %clients[getRandom(0, %possible - 1)];

	//You are now the seeker
	%seeker.setSeeker(true);
	$Seek::LastInitial = %seeker;
	//%seeker.updateSeekerMarble();
	%seeker.schedule(%seeker.getPing() + 350, updateGhostDatablock);

	
	if (!$Game::Seeking && $Game::State $= "Go") {
		//In case the seeker leaves before seeking time and a new seeker needs to be chosen, lock them in place
		%seeker.resetCheckpoint();
		%seeker.player.setMode(Start);
		%seeker.player.setCloaked(false);
		
		//Winterfest hat support
		%seeker.hat.setCloaked(false);
	}
	if ($Game::State $= "Go" && $Time::ElapsedTime != 0 && mp()) {
		%seeker.addHelpLine("You are the Seeker.");
	}
}

//--------------------------------------------------------------------------

function startHiding() {
	//Init hiding period
	$Game::Seeking = false;
	$Seek::Endmessage = false;
	cancelSeekCountdown();
	%time = (MissionInfo.hideTime ? MissionInfo.hideTime : 30000);
	Time::stop();
	Time::set(%time);
	Time::start();
	startSeekCountdown(%time, "Seeking starting in %s second(s)!", startSeeking);

	//Stop the seeker, let the hiders go
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		//%client.updateGhostDatablock();


		if (%client.seeker) {
			//The seeker is anchored to the start pad
			%client.resetCheckpoint();
			%client.player.setMode(Start);
			%client.player.trailEmitter[8].delete();
			%client.addBubbleLine("Everyone is hiding, better take notes!");

		} else {
			%client.player.setCloaked(true);
			%client.player.trailEmitter[8].delete();
			%client.addBubbleLine("The Seeker is coming to get you! Find a place to hide!");

			//Winterfest hat support
			%client.hat.setCloaked(true);
		}
	}
	detectSeekerUpdate();
}

function startSeeking() {
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
		if (%client.seeker) {
			%client.player.setMode(Normal);
			%client.addBubbleLine("Go find them!");

		} else {
			%client.player.setCloaked(false);
			//Hiders become slower
			%client.updateSeekerMarble();
			%client.addBubbleLine("The Seeker is loose!");

			//Winterfest hat support
			%client.hat.setCloaked(false);
		}
	}
	detectSeekerUpdate();
}

//--------------------------------------------------------------------------

function checkSeekVictory() {
	cancelSeekCountdown();
	if ($Seek::Endmessage)
		return;

	//Count the total number of hiders and seekers to see who wins
	%seekers = 0;
	%hiders = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		//Don't count disconnected people, or spectators
		if (%client.seeker && %client.isActive()) {
			%seekers ++;
		} else if (!%client.seeker && %client.isActive()) {
			%hiders ++;
		}
	}
	
	$Seek::Endmessage = true;

	if (%hiders != 0) {
		serverSendChat("<color:66ff66>The hiders have won!");

		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.winner = (!%client.seeker && %client.isActive());
			if (%client.winner) {
				%client.gemsFound[2] ++;
			}
		}
	} else if (%hiders == 0 && %seekers != 0) {
		serverSendChat("<color:66ff66>The seekers have won!");

		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.winner = (%client.seeker && %client.gemsFound[5] > 0 && %client.isActive());
		}
	} else {
		//Nobody is left...

		//Nobody wins!
	}

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.gemCount = (%client.seeker ? %client.gemsFound[5] * 15 : ((getPlayingPlayerCount() - 1) * 10) * %client.gemsFound[2]);
		%client.setGemCount(%client.gemCount);
	}
	updateScores();
}

function updateSeekWinner(%winners) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.winner) {
			%winners.addEntry(%client);
		}
	}
}

//--------------------------------------------------------------------------

function startSeekCountdown(%time, %message, %editorCmd) {
	$Seek::CountdownEvent1 = schedule(%time - 3000, 0, seekCountdownRemaining, 3, %message);
	$Seek::CountdownEvent2 = schedule(%time - 2000, 0, seekCountdownRemaining, 2, %message);
	$Seek::CountdownEvent3 = schedule(%time - 1000, 0, seekCountdownRemaining, 1, %message);

	if (%editorCmd !$= "" && $Editor::Opened)
		$Seek::CountdownEvent4 = schedule(%time, 0, %editorCmd);
}

function cancelSeekCountdown() {
	cancel($Seek::CountdownEvent1);
	cancel($Seek::CountdownEvent2);
	cancel($Seek::CountdownEvent3);
	cancel($Seek::CountdownEvent4);
}

function seekCountdownRemaining(%seconds, %message) {
	if (!isGameStarted())
		return;
	//Quick and dirty string replacement
	%message = strreplace(%message, "%s", %seconds);

	//Plurals as well
	%message = strreplace(%message, "(s)", (%seconds == 1 ? "" : "s"));

	//And tell everyone
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.addBubbleLine(%message);
	}
}

//-----------------------------------------------------------------------------
//Setting the seeker shape
datablock MarbleData(SeekerMarble : LBDefaultMarble) {
	shapeFile = "~/data/shapes/balls/ball-superball.dts";
};

//Returns whether or not the player is actively playing at the moment
function GameConnection::isActive(%this) { 
	return %this.isReal() && !%this.loading && !%this.spectating && isObject(%this.player);
}

//Returns whether or not the game is currently "started": not in menu/lobby, not pregame, and not finished
function isGameStarted() { 
	return (mp() ? $Game::Running && $Server::Started : !$Game::Menu) && !$Game::Finished;
}