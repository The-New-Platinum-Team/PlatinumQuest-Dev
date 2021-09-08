//-----------------------------------------------------------------------------
// Hunt Mode
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

function Mode_hunt::onLoad(%this) {
	%this.registerCallback("onActivate");
	%this.registerCallback("shouldStoreGem");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("shouldResetGem");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("shouldTotalGemCount");
	%this.registerCallback("getStartTime");
	%this.registerCallback("updateWinner");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onHuntGemSpawn");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("shouldRestorePowerup");
	%this.registerCallback("shouldPlayRespawnSound");
	%this.registerCallback("onHuntGemSpawn");
	%this.registerCallback("onClientLeaveGame");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_hunt::onActivate(%this) {
	// Hack: this will allow hunt mode to start out with a group
	// instead of all of them appearing. This is only used for
	// singleplayer as multiplayer takes care of it already.
	if ($Server::ServerType $= "SinglePlayer")
		$Server::SpawnGroups = true;
}

function huntStoreGem(%client, %huntExtraValue, %color) {
	if (!%client.disableGems[%huntExtraValue + 1]) {
		%client.gemCount += %huntExtraValue;
		%client.gemsFound[%huntExtraValue + 1] ++;
	} else
		%client.gemsFound[1] ++;

	//Show a message
	%client.displayGemMessage((%huntExtraValue+1 >= 0? "+":"") @ (%huntExtraValue + 1), %color);
}

function Mode_hunt::shouldStoreGem(%this, %object) {
	huntStoreGem(%object.user.client, %object.obj._huntDatablock.huntExtraValue, %object.obj._huntDatablock.messageColor);

	if ($MPPref::Server::PingStealFix > 0 && mp() && !$Game::isMode["coop"]) {
		%backup = spawnBackupGem(%object.obj);
		%backup._finder[%object.user] = true;
	}

	unspawnGem(%object.obj);

	return false;
}

function Mode_hunt::startCompetitiveAutorespawn(%this) {
	cancel($Hunt_CompetitiveAutorespawn);
	%this.respawnTimer = $Hunt::Competitive_AutorespawnTime;
	%time = %this.respawnTimer;
	if (PlayGui.currentTime > %time) {
		Hunt_CompetitiveSetTimer(%time);
	} else {
		// The countdown is not going to trigger, don't bother showing it.
		commandToAll('StartCountdownLeft', 0, "timerHuntRespawn");
	}
}
function Mode_hunt::onMissionReset(%this, %object) {
	resetSpawnWeights();
	hideGems();

	$Hunt::CurrentCompetitivePointsLeftBehind = 0;
	$Hunt::CurrentCompetitiveGemsLeftBehind = 0;
	if ($Server::SpawnGroups) {
		$Game::FirstSpawn = true;
		spawnHuntGemGroup();
		$Game::FirstSpawn = false;

		//Orient all clients to face the gemspawn
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (!%client.spectating) {
				%client.pointToNearestGem();
			}
		}
	}

	if ($MPPref::Server::CompetitiveMode) {
		if (!mp() || $Game::isMode["coop"] || !$Game::isMode["hunt"]) {
			$MPPref::Server::CompetitiveMode = 0;
			Hunt_CompetitiveClearTimer();
			return;
		}
		if (!$Hunt::Competitive_TimerWaitsForFirstGem) {
			%this.schedule(3500, startCompetitiveAutorespawn);
		} else {
			Hunt_CompetitiveClearTimer();
		}
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.addBubbleLine("Competitive Mode is on. Gems respawn after 20 seconds, and that time drops if 3 or less gems remain. No quickspawn.");
		}
	}
}
function Mode_hunt::onMissionEnded(%this) {
	$MP::nonPartyGemsPerSpawn = false;
}
function Mode_hunt::onHuntGemSpawn(%this) {
	if ($MPPref::Server::CompetitiveMode && !$Hunt::Competitive_TimerWaitsForFirstGem) {
		%this.startCompetitiveAutorespawn();
	}
}
function Mode_hunt::onRespawnPlayer(%this, %object) {
	%object.client.pointToNearestGem();
}
function Mode_hunt::getStartTime(%this) {
	return (MissionInfo.time ? MissionInfo.time : 300000);
}
function Mode_hunt::shouldResetGem(%this, %object) {
	return false;
}
function Mode_hunt::shouldResetTime(%this, %object) {
	return false;
}
function Mode_hunt::shouldRestartOnOOB(%this, %object) {
	return false;
}
function Mode_hunt::shouldRespawnGems(%this, %object) {
	return false;
}
function Mode_hunt::shouldRestorePowerup(%this, %object) {
	return true;
}
function Mode_hunt::getScoreType(%this) {
	return $ScoreType::Score;
}
function Mode_hunt::getFinalScore(%this, %object) {
	return $ScoreType::Score TAB %object.client.getGemCount();
}
function Mode_hunt::timeMultiplier(%this) {
	return -1;
}
function Mode_hunt::onFoundGem(%this, %object) {
	%object.client.playPitchedSound("gotDiamond" @ (%object.gem._huntDatablock.huntExtraValue + 1));
}
function Mode_hunt::shouldTotalGemCount(%this) {
	return false;
}
function Mode_hunt::updateWinner(%this, %winners) {
	//In Hunt mode, the player with the most gems wins
	%winner = ClientGroup.getObject(0);
	%count = ClientGroup.getCount();

	//Who has the most gems?
	for (%i = 1; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.gemCount > %winner.gemCount)
			%winner = %client;
	}

	%winners.addEntry(%winner);
	//Check for other winners
	for (%i = 1; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%winner == %client)
			continue;
		if (%client.gemCount == %winner.gemCount)
			%winners.addEntry(%client);
	}
}
function Mode_hunt::shouldPlayRespawnSound(%this) {
	// Hunt mode should not play respawn sound when player respawns from OOB
	return false;
}
function Mode_hunt::onClientLeaveGame(%this) {
	if ($MPPref::Server::CompetitiveMode) {
		RootGui.pushDialog(MPExitGameDlg);
		$gamePaused = true;
		MPExitTitle.setText("<color:ff0000><bold:28><just:center>PAUSED - Player Disconnected");
		MPExitDisconnect.setText($Server::Hosting ? "Level Select" : "Disconnect");
		MPExitReturn.setText("Unpause");
		MPExitReturn.setVisible($Server::Hosting);
		MPExitDisconnect.setVisible(false);
		MPExitRestart1.setVisible(false);
		MPExitRestart2.setVisible(false);
		MPExitQuickspawn.setVisible(false);
	}
}