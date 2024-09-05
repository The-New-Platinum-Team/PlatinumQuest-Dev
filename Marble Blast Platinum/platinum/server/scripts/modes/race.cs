//------------------------------------------------------------------------------
// Racing mode
//
// Originally created in 2014
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

function Mode_race::onLoad(%this) {
	%this.registerCallback("shouldUseTimeScoreboard");
	%this.registerCallback("onEnterPad");
	%this.registerCallback("shouldPickupGem");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onRespawnOnCheckpoint");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("canFinish");
	%this.registerCallback("shouldIgnoreGem");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("shouldDisablePowerUp");
	%this.registerCallback("shouldPickupPowerup");
	%this.registerCallback("shouldUseClientPowerups");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldTotalGemCount");
	%this.registerCallback("shouldSetSpectate");
	%this.registerCallback("onClientLeaveGame");
	%this.registerCallback("getQuickRespawnTimeout");
	%this.registerCallback("shouldAllowTTs");
	%this.registerCallback("onFrameAdvance");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	%this.registerCallback("onClientEnterGame");
	%this.registerCallback("onPlayerJoin");
	%this.registerCallback("onDeactivate");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_race::shouldUseTimeScoreboard(%this) {
	return true;
}
function Mode_race::onEnterPad(%this, %object) {
	%finisher = %object.client;
	if (%finisher.canFinish()) {
		%this.playersFinished ++;
		%finisher.finalTime = $Time::CurrentTime;
		echo("[Mode Race]:" SPC formatTime(%finisher.finalTime) SPC "is" SPC %finisher.getDisplayName() @ "\'s final time.");
		%finisher.player.setMode(Victory);
		//startFireWorks($Game::EndPad);
		updateSingleScore(%finisher);
		%finisher.isFinished = true;
		if (%this.playersFinished == 1) {
			//Only the first winner should see this message
			%finisher.addHelpLine("Congratulations! You\'ve won!");
		} else {
			%finisher.addHelpLine("Congratulations! You\'ve finished!");
		}
		if (%this.playersFinished < ClientGroup.getCount()) {
			%finisher.playPitchedSound("firewrks");
		}
		if (mp()) {
			cancel(%finisher.racingWinSpectate);
			%finisher.racingWinSpectate = %finisher.schedule(5000, racingWinSpectate);
			for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
				%client = ClientGroup.getObject(%i);
				if (%client.getID() == %finisher.getID())
					continue;
				if (%this.playersFinished == 1) {
					%client.addHelpLine(%finisher.getDisplayName() SPC "has won!");
				} else {
					%client.addHelpLine(%finisher.getDisplayName() SPC "has finished!");
				}
			}
			serverSendScores();
			%finisher.sendEndGameScores();
			if (!$Game::Finished)
				%finisher.startTimer(); //sendEndGameScores stops the timer
		}
		%this.checkRaceEnd();

	} else {
		%finisher.addHelpLine("You may not finish without all the gems!");
		%finisher.playPitchedSound("missinggems");
	}
	return true;
}
function Mode_race::shouldPickupGem(%this, %object) {
	%gem = %object.obj.getID();
	%client = %object.user.client;
	if (!%client.raceFoundGem[%gem]) {
		//You picked up a gem...
		%client.raceFoundGem[%gem] = true;
		%client.raceLookupGem[%client.gemCount] = %gem;
		%client.raceLookupGemCP[%client.gemCount] = %client.curCheckpointNum;
		%client.gemCount ++;
		%client.setGemCount(%client.gemCount);
		%remaining = $Game::gemCount - %client.gemCount;
		if (%remaining <= 0) {
			messageClient(%client, 'MsgHaveAllGems', "\c0You have all the gems, head for the finish!");
			%client.playPitchedSound("gotalldiamonds");
		} else {
			if (%remaining == 1)
				%msg = "\c0You picked up a gem! Only one gem to go!";
			else
				%msg = "\c0You picked up a gem!  " @ %remaining @ " gems to go!";
			messageClient(%client, 'MsgItemPickup', %msg, %remaining);
			%client.playPitchedSound("gotDiamond");
		}
		%fx = isObject(%gem._fx[0]) ? %gem._fx[0].getSyncID() : -1;
		commandToClient(%client, 'GemPickup', %gem.getSyncId(), %gem.staticGem.getSyncID(), %fx, %client.curCheckpointNum);
	}
	return false;
}
function Mode_race::onRespawnPlayer(%this, %object) {
	%client = %object.client;
	for (%i = 0; %i < $Game::GemCount; %i ++) {
		%gem = %client.raceLookupGem[%i];
		%client.raceFoundGem[%gem] = false;
		%client.raceLookupGem[%i] = "";
		%client.raceLookupGemCP[%i] = "";
	}
	%client.gemCount = 0;
	%client.setGemCount(%client.gemCount);
	commandToClient(%client, 'RacingOnRespawn');
}
function Mode_race::onRespawnOnCheckpoint(%this, %object) {
	%client = %object.client;
	%gemCount = $Game::GemCount;
	for (%i = 0; %i < $Game::GemCount; %i ++) {
		%gem = %client.raceLookupGem[%i];
		if (!isObject(%gem) || %client.raceLookupGemCP[%i] >= %client.curCheckpointNum) {
			%client.raceFoundGem[%gem] = false;
			%client.raceLookupGem[%i] = "";
			%gemCount --;
		}
	}
	%client.gemCount = %gemCount;
	%client.setGemCount(%client.gemCount);
	commandToClient(%client, 'RacingOnRespawnOnCheckpoint', %client.curCheckpointNum);
}
function Mode_race::onMissionReset(%this) {
	%this.playersFinished = 0;
	%gems = MissionGroup.findGems();
	for (%i = 0; %i < getWordCount(%gems); %i ++) {
		%object = getWord(%gems, %i);
		if (!isObject(%object.staticGem)) {
			//Create a transparent, static gem
			MissionCleanup.add(%object.staticGem = new StaticShape() {
				position = %object.position;
				rotation = %object.rotation;
				scale = %object.scale;
				datablock = "StaticGem" @ strchr(%object.getDataBlock().getName(), "_");
			});
			%object.staticGem.setCloaked(true);
			%newGem = true;
		}
		%object.staticGem.setTransform(%object.getTransform());
	}
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		cancel(%client.racingWinSpectate);
		if (%client.isFinished) {
			if (isObject(%client.player))
				%client.player.delete();
			%client.setSpectating(false);
			%client.isFinished = false;
		}
		for (%j = 0; %j < $Game::GemCount; %j ++) {
			%gem = %client.raceLookupGem[%j];
			%client.raceFoundGem[%gem] = false;
			%client.raceLookupGem[%j] = "";
			%client.raceLookupGemCP[%j] = "";
		}
	}
	updateScores();
	commandToAll('RacingOnRespawn');
	if (%newGem)
		schedule(1000, 0, commandToAll, 'RacingOnRespawn');
}
function Mode_race::onMissionEnded(%this) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		cancel(%client.racingWinSpectate);
		if (%client.isFinished) {
			%client.setSpectating(false);
			%client.isFinished = false;
		}
		for (%j = 0; %j < $Game::GemCount; %j ++) {
			%gem = %client.raceLookupGem[%j];
			%client.raceFoundGem[%gem] = false;
			%client.raceLookupGem[%j] = "";
			%client.raceLookupGemCP[%j] = "";
		}
	}
	commandToAll('RacingOnRespawn');
	updateScores();
	%gems = MissionGroup.findGems();
	for (%i = 0; %i < getWordCount(%gems); %i ++) {
		%object = getWord(%gems, %i);
		if (isObject(%object.staticGem))
			%object.staticGem.delete();
	}
}
function Mode_race::canFinish(%this, %object) {
	return !($Game::GemCount && %object.client.gemCount < $Game::GemCount);
}
function Mode_race::shouldIgnoreGem(%this, %object) {
	return true;
}
function Mode_race::shouldRespawnGems(%this, %object) {
	return false;
}
function Mode_race::shouldDisablePowerup(%this, %object) {
	if (!mp())
		return false;
	//Stuff that is handled by the client
	return %object.this.coopClient;
}
function Mode_race::shouldPickupPowerup(%this, %object) {
	if (!mp())
		return true;
	//Stuff that is handled by the client
	return !%object.this.coopClient;
}
function Mode_race::shouldUseClientPowerups(%this) {
	if (!mp())
		return false;
	return true;
}
function Mode_race::shouldRestartOnOOB(%this, %object) {
	return false;
}
function Mode_race::shouldResetTime(%this, %object) {
	return false;
}
function Mode_race::shouldTotalGemCount(%this) {
	return false;
}
function Mode_race::shouldSetSpectate(%this, %object) {
	return !%object.client.isFinished;
}
function Mode_race::onClientLeaveGame(%this, %object) {
	%this.checkRaceEnd();
}
function Mode_race::getQuickRespawnTimeout(%this, %object) {
	//Allow them to respawn instantly
	return 0;
}
function Mode_race::shouldAllowTTs(%this) {
	return false;
}
function Mode_race::onFrameAdvance(%this, %delta) {
	if (MissionInfo.Time !$= "") {
		//End the game when the Par Time has been passed
		if ($Time::CurrentTime >= MissionInfo.Time && $Time::TimerRunning) {
			Time::stop();
			Time::set(MissionInfo.Time);
			$Time::CurrentTime = MissionInfo.Time;
			$Time::ElapsedTime = MissionInfo.Time;
			%this.racingEndGame();
		}
	}
}
function Mode_race::getScoreType(%this) {
	return $ScoreType::Time;
}
function Mode_race::getFinalScore(%this, %object) {
	if (mp()) {
		return $ScoreType::Time TAB min(%object.client.finalTime, 5999999);
	} else {
		return $ScoreType::Time TAB $Time::CurrentTime;
	}
}
function Mode_race::onClientEnterGame(%this, %object) {
	commandToClient(%client, 'RacingOnRespawn');
}
function Mode_race::onPlayerJoin(%this, %object) {
	if (%object.client.finalTime $= "") {
		%object.client.finalTime = 6000000;
	}
	if (%object.client.finalTime < 6000000) {
		%object.client.isFinished = true;
	}
}
function Mode_race::onDeactivate(%this) {
	%this.onMissionEnded();
}

//-----------------------------------------------------------------------------

function GameConnection::racingWinSpectate(%this) {
	if ($Game::State $= "Waiting")
		return;
	%this.setSpectating(true);
	commandToClient(%this, 'RacingOnRespawn');
	if (mp()) {
		commandToClient(%this, 'GameEnd');
	}
}

function Mode_race::checkRaceEnd(%this) {
	if (!isGameStarted())
		return;
	//If no one is racing, the game ends
	%left = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.isFinished && %client.isActive()) {
			%left ++;
		}
	}
	if (%left == 0) {
		%this.racingEndGame();
	}
}

function Mode_race::racingEndGame(%this) {
	endGameSetup();
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.isFinished) {
			%client.addBubbleLine("Time\'s up!");
			%client.playPitchedSound("alarm_timeout");
		}
	}
	updateScores();
}
