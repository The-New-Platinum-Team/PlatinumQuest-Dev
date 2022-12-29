//-----------------------------------------------------------------------------
// Multiplayer Package
// server.cs
//
// Copyright (c) 2013 The Platinum Team
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
// The cool start function
function serverStartGame() {
	//And don't do it again!
	$Server::SpawnGroups = false;

	// start the game
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setPregame(false);

		if (%client.spectating) {
			%client.cancelOverview();
			%client.setSpectating(true);
		} else
			%client.stopOverview();

		// set force spectators in case we have it.
		// don't want plebs switching back and forth.
		if ($MPPref::ForceSpectators)
			%client.forceSpectate = true;
	}

	$Server::Started = true;
	$Game::FirstSpawn = true;

	updatePlayerlist();
	schedule($MPPref::OverviewFinishSpeed * 1000, 0, serverStartFinish);
}

function serverStartFinish() {
	//Finish starting things
	activateMovingObjects(true);
	restartLevel();

	// update the score list
	updateScores();

	$Server::SpawnGroups = true;
	$Game::FirstSpawn = false;
}

function GameConnection::setPregame(%this, %set) {
	commandToClient(%this, 'setPregame', %set);
	updateSpectateFull();
}

//-----------------------------------------------------------------------------

// update the pre game user list and ready list
function updateReadyUserList() {
	if ($Server::ServerType $= "SinglePlayer")
		return;
	%list = "";
	$MP::ReadyCount = 0;
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (isRealClient(%client) && !%client.connected)
			continue;

		if (%client.ready) {
			$MP::ReadyCount ++;
		}
	}

	// update the userlist for pregame
	messageAll('MsgReadyCount', "", $MP::ReadyCount, getRealPlayerCount());
	commandToAll('UpdatePreGame');
}

//-----------------------------------------------------------------------------

// determine if the server has moving platforms or not
function serverHasMovingPlatforms(%group) {
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();
		if (%class $= "SimGroup") {
				// if we find it, stop execution
				if (serverHasMovingPlatforms(%obj))
					return true;
			} else if (%class $= "PathedInterior")
				return true;
	}
	return false;
}

//-----------------------------------------------------------------------------

// out of bounds loop check, also does mouse fire for powerups and stuff
function MPOutofBounds() {
	cancel($MP::Schedule::OOB);
	if ($Server::Dedicated && getRealPlayerCount() == 0)
		return;

	if (!$Server::Hosting)
		return;

	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);

		if (isObject(%client.player)) {
			//Detect if they are touching the ground. Radius is BoxX
			%ground = ContainerBoxEmpty($TypeMasks::InteriorObjectType, %client.player.getPosition(), %client.player.getCollisionRadius() + 1);
			if (!%ground) {
				%client.player.lastTouch = %client.player.getPosition();
			}

			if (%client.mouseFire) {
				if (!%client.fireOn) {
					%client.mouseFire(true);
					%client.fireOn = true;
					%client.fireNum ++;
				}

				if (%client.isOOB) {
					%client.respawnFromOOB();
				} else if ((%client.player.powerUpId !$= "") && !%client.cannon && !%client.player.lockPowerup) {
					%client.player.onPowerUpUsed();
				}
			} else if (%client.fireOn) {
				%client.mouseFire(false);
				%client.fireOn = false;
			}
		}
	}
	$MP::Schedule::OOB = schedule(50, 0, MPOutofBounds);
}

function GameConnection::mouseFire(%this, %val) {
	//Nada
}

//-----------------------------------------------------------------------------

// update score
// this function is called when one of the following events happen:
// - Player joins the match
// - Player leaves the match
// - Match Starts
// - Match Ends
// - Player collects a Gem
// - Every 10 seconds to make sure (insanity check)
function updateScores() {
	if ($Server::ServerType $= "SinglePlayer")
		return;
	if ($Server::Dedicated && getRealPlayerCount() == 0)
		return;

	for (%i = 0; %i < ClientGroup.getCount(); %i ++)
		ClientGroup.getObject(%i).updateScores();

	if ($Server::Dedicated) {
		// I like my info
		dumpScores();
	}
}

function dumpScores() {
	echo("Scores Update:");
	%count = ClientGroup.getCount();

	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (isRealClient(%client) && !%client.connected)
			continue;
		%score = %client.gemCount;
		echo(%client.getUsername() @ ":" SPC %score SPC "(" @ %client.gemsFound[1] SPC %client.gemsFound[2] SPC %client.gemsFound[5] SPC %client.gemsFound[10] @ ")");
	}
}

function GameConnection::updateScores(%this) {
	if ($Server::ServerType $= "SinglePlayer")
		return;

	// We need to send different things if we're in different modes
	if ($MP::TeamMode) {
		// Send a team total, and then player scores for that team
		%count = TeamGroup.getCount();

		%list = "";

		for (%i = 0; %i < %count; %i ++) {
			%team = TeamGroup.getObject(%i);
			%total = 0;

			// Calculate group score from all players
			%players = %team.getCount();
			for (%j = 0; %j < %players; %j ++)
				%total += %team.getObject(%j).gemCount;

			%playerList = "";

			// Send player scores from the team
			for (%j = 0; %j < %players; %j ++) {
				%client = %team.getObject(%j);
				%score = %client.gemCount;
				%skinChoice = %client.skinChoice;
				%gems = %client.gemsFound[1] SPC %client.gemsFound[2] SPC %client.gemsFound[5] SPC %client.gemsFound[10];

				%rec = expandEscape(%client.getUsername())
					TAB %score
					TAB %client.index
					TAB expandEscape(%skinChoice)
					TAB %gems
				;

				if (%playerList $= "")
					%playerList = %rec;
				else
					%playerList = %playerList NL %rec;
			}

			%record = expandEscape(Team::getTeamName(%team))
				TAB %total
				TAB %team.number
				TAB %team.color
				TAB %playerList
			;

			if (%list $= "")
				%list = %record;
			else
				%list = %list @ "$$" @ %record;
		}

		commandToClientLong(%this, 'ScoreListTeamPlayer', %list);
	} else {
		%set = ClientGroup.merge(FakeClientGroup);

		%list = "";

		// Simple send: each individual and score is sent
		%count = %set.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%client = %set.getObject(%i);
			if (isRealClient(%client) && !%client.connected)
				continue;
			%score = %client.gemCount;
			%gems = %client.gemsFound[1] SPC %client.gemsFound[2] SPC %client.gemsFound[5] SPC %client.gemsFound[10];

			%record = expandEscape(%client.getUsername())
				TAB %score
				TAB %gems
				TAB %client.index
				TAB expandEscape(%client.skinChoice)
				TAB %client.totalBonus
			;

			if (%list $= "")
				%list = %record;
			else
				%list = %list NL %record;
		}

		commandToClientLong(%this, 'ScoreListPlayer', %list);
		%set.delete();
	}
}

function updateSingleScore(%client) {
	// We need to send different things if we're in different modes
	if ($MP::TeamMode) {
		// Send a team total, and then player scores for that team
		%team = %client.team;
		%score = 0;

		// Calculate group score from all players
		%players = %team.getCount();
		for (%j = 0; %j < %players; %j ++)
			%score += %team.getObject(%j).gemCount;

		commandToAll('ScoreListTeamUpdate', Team::getTeamName(%team), %score, %team.number, %team.color);

		// Send player scores from the team
		%score = %client.gemCount;
		%skinChoice = %client.skinChoice;
		%gems = %client.gemsFound[1] SPC %client.gemsFound[2] SPC %client.gemsFound[5] SPC %client.gemsFound[10];
		//echo("Skin choice is" SPC %skinChoice);
		commandToAll('ScoreListTeamPlayerUpdate', Team::getTeamName(%team), %client.getUsername(), %score, %client.index, %skinChoice, %gems);
		commandToAll('ScoreListUpdate', %client.index, %score, %gems, %client.totalBonus);
	} else {
		%score = %client.gemCount;
		%gems = %client.gemsFound[1] SPC %client.gemsFound[2] SPC %client.gemsFound[5] SPC %client.gemsFound[10];
		commandToAll('ScoreListUpdate', %client.index, %score, %gems, %client.totalBonus);
	}
}

// Compare everyone's scores and get a client's current place in the game
function FakeGameConnection::getPlace(%this) {
	%place = 1;

	if ($MP::TeamMode) {
		// Calculate group score from all players
		%players = %this.team.getCount();
		for (%j = 0; %j < %players; %j ++)
			%teamscore += %this.team.getObject(%j).gemCount;

		for (%i = 0; %i < TeamGroup.getCount(); %i ++) {
			%team = TeamGroup.getObject(%i);

			// Calculate group score from all players
			%players = %team.getCount();
			for (%j = 0; %j < %players; %j ++)
				%score += %team.getObject(%j).gemCount;

			if (%team.getId() == %this.team.getId())
				continue;
			if (%score > %teamscore)
				%place ++;
		}
	} else {
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%player = ClientGroup.getObject(%i);
			if (%player.getId() == %this.getId())
				continue;
			if (%player.gemCount > %this.gemCount)
				%place ++;
		}
	}

	return %place;
}

// Compare everyone's scores and get a client's current place in the game
function GameConnection::getPlace(%this) {
	%place = 1;

	if ($MP::TeamMode) {
		return Team::getTeamPlace(%this.team);
	} else {
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%player = ClientGroup.getObject(%i);
			if (%player.getId() == %this.getId())
				continue;
			if (%player.gemCount > %this.gemCount)
				%place ++;
		}
	}

	return %place;
}

function GameConnection::setNameTag(%this, %name) {
	%this.customName = %name;
	updatePlayerlist();
}

function GameConnection::getNameTag(%this) {
	if (%this.customName !$= "")
		return trim(%this.customName);
	return %this.getDisplayName();
}

function serverResetScores() {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		$Master::ScoreRating[%i] = 0;
		$Master::ScoreChange[%i] = 0;
	}
}

function serverSendScores() {
	if ($Server::ServerType $= "SinglePlayer")
		return;
	if (Mode::callback("shouldSendScores", true)) {
		commandToAll('MasterScoreCount', $Master::Scores);
		for (%i = 0; %i < $Master::Scores; %i ++) {
			commandToAll('MasterScorePlayer', %i, $Master::ScorePlayer[%i]);
			commandToAll('MasterScoreRating', %i, $Master::ScoreRating[%i]);
			commandToAll('MasterScoreChange', %i, $Master::ScoreChange[%i]);
		}
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (%client.spectating) {
				commandToAll('MasterScorePlayer', %i, %client.getUsername());
				commandToAll('MasterScoreRating', %i, -1);
				commandToAll('MasterScoreChange', %i, 0);
			}
			commandToAll('PlayerGemCount', %client.getUsername(), %client.gemsFound[1], %client.gemsFound[2], %client.gemsFound[5], %client.gemsFound[10]);
		}
	} else {
		commandToAll('MasterScoreCount', ClientGroup.getCount());
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			commandToAll('MasterScorePlayer', %i, %client.getUsername());
			commandToAll('MasterScoreRating', %i, -1);
			commandToAll('MasterScoreChange', %i, 0);
			commandToAll('PlayerGemCount', %client.getUsername(), %client.gemsFound[1], %client.gemsFound[2], %client.gemsFound[5], %client.gemsFound[10]);
		}
	}
	commandToAll('MasterScoreFinish');
}

function MPsendScores() {
	devecho("MP Score Send");
	updateScores();

	for (%i = 0; %i < $Master::Scores; %i ++) {
		commandToAll('MasterScoreRating', %i, -2);
		commandToAll('MasterScoreChange', %i, 0);
	}
	if (MPshouldSendScores()) {
		// Calculate scores!
		if (Mode::callback("shouldSendScores", true)) {
			statsRecordMatch(getMissionList("mp").getMission($CurrentGame, $MissionType, $Server::MissionFile));
		}
	}
	serverSendScores();
}

function MPshouldSendScores() {
	if (!$MPPref::Server::SubmitScores) {
		return false;
	}
	if ($Game::isMode["hunt"] && $MP::ScoreSendingDisabled) { // If Double Spawns are turned on
		return false;
	}

	return true;
}

//-----------------------------------------------------------------------------

function updateWinner() {
	%winners = array(WinnersArray);

	// This is completely mode-specific
	Mode::callback("updateWinner", "", %winners);

	// Do something with the winner
	for (%i = 0; %i < %winners.getSize(); %i ++) {
		%winners.getEntry(%i).wins ++;

		if ($MPPref::DisplayWinners)
			serverSendChat(%winners.getEntry(%i).getDisplayName() SPC "is the winner!");
	}

	if ($MPPref::DisplayWinners && %winners.getSize())
		displayWins();

	%winners.delete();
}

function displayWins() {
	serverSendChat("Winners:");

	%list = array(WinnersArray);

	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%top = -1;
		for (%j = 0; %j < %count; %j ++) {
			%client = ClientGroup.getObject(%j);
			if (%list.containsEntry(%client))
				continue;

			if (%top == -1 || %client.wins > %top.wins)
				%top = %client;
		}

		%list.addEntry(%top);
	}

	%names  = "";
	%scores = "";

	for (%i = 0; %i < %list.getSize(); %i ++) {
		%client = %list.getEntry(%i);
		if (%names !$= "") {
			%names = %names @  " - ";
			%scores = %scores @ "-";
		}
		%names = %names @ %client.getDisplayName();
		%scores = %scores @ mFloor(%client.wins);
	}

	serverSendChat(%names);
	serverSendChat(%scores);

	%list.delete();
}

function resetWins() {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		ClientGroup.getObject(%i).wins = 0;
	}
}

//-----------------------------------------------------------------------------

function testahedron(%pos, %clear) {
	if (%clear)
		while (isObject(TESTAHEDRON))
			TESTAHEDRON.delete();
	new TSStatic(TESTAHEDRON) {
		position = %pos;
		rotation = "0 0 0 0";
		scale = "1 1 1";
		shapeName = "~/data/shapes/markers/octahedron.dts";
	};
}

//-----------------------------------------------------------------------------

//Synchronize clients' clocks on a regular interval
function MPSyncClocks() {
	//Don't do this in SP
	if ($Server::ServerType !$= "MultiPlayer")
		return;

	cancel($MP::Schedule::ClockSync);
	syncClients();
	$MP::Schedule::ClockSync = schedule(5000, 0, MPSyncClocks);
}

//-----------------------------------------------------------------------------

/// Sends datablock names down the pipe for a specific client.
/// @param client - The client to send datablock names too.
function MPSendDataBlockNames(%client) {
	%count = DatablockGroup.getCount();
	%list = "";
	for (%i = 0; %i < %count; %i++) {
		%obj = DataBlockGroup.getObject(%i);
		%field = %obj.getId() SPC %obj.getName();
		if (%list $= "")
			%list = %field;
		else
			%list = %list TAB %field;
	}
	commandToClientLong(%client, 'RecDataBlockNames', %list);
	MPSendDatablockInfo(%client);
}

function MPSendDatablockInfo(%client) {
	//TODO: This is really hacky and hardcoded, we should investigate a better
	// solution if time allows.
	commandToClient(%client, 'DatablockField', PathNode,           "renderEditor", PathNode.renderEditor);
	commandToClient(%client, 'DatablockField', BezierHandle,       "renderEditor", BezierHandle.renderEditor);
	commandToClient(%client, 'DatablockField', BackupGem,          "renderEditor", BackupGem.renderEditor);
	commandToClient(%client, 'DatablockField', PhysModEmitter,     "noHide",       PhysModEmitter.noHide);
	commandToClient(%client, 'DatablockField', pickupSfx,          "description",  pickupSfx.description);
	commandToClient(%client, 'DatablockField', HelpDingSfx,        "description",  HelpDingSfx.description);
	commandToClient(%client, 'DatablockField', ReadyVoiceSfx,      "description",  ReadyVoiceSfx.description);
	commandToClient(%client, 'DatablockField', SetVoiceSfx,        "description",  SetVoiceSfx.description);
	commandToClient(%client, 'DatablockField', GetRollingVoiceSfx, "description",  GetRollingVoiceSfx.description);
	commandToClient(%client, 'DatablockField', jumpSfx,            "description",  jumpSfx.description);
	commandToClient(%client, 'DatablockField', bounceSfx,          "description",  bounceSfx.description);
}