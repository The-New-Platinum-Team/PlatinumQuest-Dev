//-----------------------------------------------------------------------------
// Elimination mode
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

function Mode_elimination::onLoad(%this) {
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onClientEnterGame");
	%this.registerCallback("onClientLeaveGame");
	%this.registerCallback("onPlayerJoin");
	%this.registerCallback("onRestartLevel");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldSetSpectate");
	%this.registerCallback("getStartTime");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("onTimeExpire");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_elimination::onMissionReset(%this) {
	%this.Tie = false;
	cancel(%this.antiCamp);
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.eliminated = (%client.spectating || %client.loading || !%client.isReal());
	}
}
function Mode_elimination::onMissionEnded(%this) {
	cancel(%this.antiCamp);
	%this.Tie = false;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.eliminated = false;
	}
}
function Mode_elimination::onClientEnterGame(%this, %object) {
	if (%object.client.eliminated && isGameStarted() && mp()) {
		%object.client.setSpectating(true);
	}
}
function Mode_elimination::onClientLeaveGame(%this, %object) {
	%object.client.eliminated = true;
	%this.checkWin();
}
function Mode_elimination::onPlayerJoin(%this, %object) {
	if (isGameStarted() && mp())
		%object.client.eliminated = true;
}
function Mode_elimination::onRestartLevel(%this) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.eliminated) {
			%client.eliminated = false;
			%client.spectating = false;
			//%client.setSpectating(false);
		}
	}
}
function Mode_elimination::shouldRestartOnOOB(%this) {
	return false;
}
function Mode_elimination::shouldResetTime(%this) {
	return false;
}
function Mode_elimination::shouldSetSpectate(%this, %object) {
	return !%object.client.eliminated;
}
function Mode_elimination::getStartTime(%this) {
	return MissionInfo.eliminationTime ? MissionInfo.eliminationTime : 60000;
}
function Mode_elimination::timeMultiplier(%this) {
	return -1;
}
function Mode_elimination::onDeactivate(%this) {
	%this.onMissionEnded();
}

//-----------------------------------------------------------------------------

function Mode_elimination::onTimeExpire(%this) {
	if (!mp())
	 	return true;

	//Find the player with the least points
	%playing = %this.getPlayers();
	%tie = false;

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);

		if (%client.eliminated)
			continue;

		if (%client.getElimPlace() == %playing) {
			%least = %client;
		}
	}
	if (!isObject(%least))
		%tie = true;

	//Let people know
	if (%tie) {
		if (!%this.Tie) {
			serverSendChat("<color:ff6666>There\'s a tie! Sudden death!");
			%this.Tie = true;
			%this.antiCamp = %this.schedule(30000, AntiCamp);
		}
	} else {
		if (%playing >= 2) {
			//%least.spectating = true;
			//%least.setToggleCamera(true);
			//%least.deletePlayer();
			%least.setSpectating(true);
			serverSendChat("<color:ff6666>" @ %least.getDisplayName() SPC "has been eliminated!");
			%this.Tie = false;
			%least.eliminated = true;
		}
	}

	//If there's no players left, then the game ends
	if (%playing <= 2 && !%tie) {
		%this.markWinner();
		//endGameSetup();
	}

	if (%playing > 2 && !%tie) {
		//Reset everyone's time
		cancel(%this.antiCamp);
		%time = %this.getStartTime();
		Time::stop();
		Time::set(%time);
		$Time::ElapsedTime = 0;
		Time::start();
	}
	return false;
}

//-----------------------------------------------------------------------------

function Mode_elimination::checkWin(%this) {
	//When someone leaves, check if there is only one player left, if so they win!
	%playing = %this.getPlayers();

	if (%playing <= 1) {
		%this.markWinner();
	}
}

function Mode_elimination::markWinner(%this) {
	if (isGameStarted() && mp()) {
		cancel(%this.antiCamp);
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);

			if (!%client.eliminated) {
				serverSendChat("<color:00ff00>" @ %client.getDisplayName() SPC "is the winner!");
				$Game::FinishClient = %client; //In case you're playing co-op elimination?
			}
		}
		endGameSetup();
	}
}

function Mode_elimination::getPlayers(%this) {
	%players = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.eliminated) 
			%players ++;
	}
	return %players;
}


function GameConnection::getElimPlace(%this, %tie) {
	%place = 1;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%player = ClientGroup.getObject(%i);
		if (%player.eliminated)
			continue;
		if (%player.getId() == %this.getId())
			continue;
		
		if (Mode::callback("shouldUseTimeScoreboard", false)) {
			if (%player.finalTime < %this.finalTime && !%tie)
				%place ++; 	
			else if (%player.gemCount > %this.gemCount && !%tie) 
				%place ++;
			else if (%player.finalTime <= %this.finalTime && %tie)
				%place ++; 	
			else if (%player.gemCount >= %this.gemCount && %tie) 
				%place ++;

		} else {
			if (%player.gemCount > %this.gemCount && !%tie)
				%place ++;

			else if (%player.gemCount >= %this.gemCount && %tie)
				%place ++;
		}
	}

	return %place;
}

//-----------------------------------------------------------------------------
//This is so you can't stall the game indefinitely with sudden death...
function Mode_elimination::antiCamp(%this) {
	cancel(%this.antiCamp);
	if (!isGameStarted())
		return;
	if (!$Game::isMode["elimination"])
		return;
	if (!mp())
		return;

	%playing = %this.getPlayers();
	%tie = false;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);

		if (%client.eliminated)
			continue;

		if (%client.getElimPlace(true) == %playing) {
			%client.setSpectating(true);
			serverSendChat("<color:ff6666>Tiebreaker!" SPC %client.getDisplayName() SPC "has been eliminated!");
			%client.eliminated = true;
		}
	}
	
	%time = %this.getStartTime();
	Time::stop();
	Time::set(%time);
	$Time::ElapsedTime = 0;
	Time::start();
	%this.Tie = false;
	%this.checkWin();
}