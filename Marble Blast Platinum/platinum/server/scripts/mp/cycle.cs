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

//States of the cycle server state machine

// 0 - At the level select, players get to vote
// 1 - Loading the chosen level
// 2 - Waiting at the pregame screen for players to press ready
// 3 - Playing the level
$Cycle::State[0] = "select";
$Cycle::State[1] = "load";
$Cycle::State[2] = "ready";
$Cycle::State[3] = "play";

$Cycle::Time[0] = 1000*60;
$Cycle::Time[2] = 1000*20;

$Cycle::Pause[1] = 1000*10;
$Cycle::Pause[3] = 1000*30;

function startCycleServer() {
	activatePackage(CycleServer);

	$Server::Cycle = true;
}

//TODO:
// What happens if people join midway -- try to include them
// What happens if everyone leaves -- Stop mission, return to state 0
// At state 0, if there is nobody, don't start the countdown until somebody joins
// What if nobody votes -- pick a random map

//-----------------------------------------------------------------------------
// State 0: Level Selection
//-----------------------------------------------------------------------------

function cycle0Start() {
	$Cycle::State = 0;

	//Set everybody to host so they can choose missions
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.cycle0Start();
	}

	cycleCountdown("Voting ends", $Cycle::Time[0], cycle0Finish);
}

/**
 * @param {GameConnection} %this
 */
function GameConnection::cycle0Start(%this) {
	%this.setHost(true);
	%this.sendChat("Select a mission and press Preload to vote for it!");

	%this.cycle0Vote = "";
}

/**
 * @param {Type} %client
 */
function cycle0Switch(%client, %file, %game, %difficulty, %forceMode) {
	//Probably nothing
	error(%client.namebase @ " switches to " @ %file);
}

/**
 * @param {GameConnection} %client
 */
function cycle0Vote(%client, %file) {
	if (isScriptFile(%client.cycle0Vote)) {

		//Tell them to stop picking
		%client.setHost(false);

		//Then count their vote
		error(%client.namebase @ " votes for " @ %file);
		serverSendChat(LBChatColor("record") @ %client.namebase @ " votes for " @ %file);

		%client.cycle0Vote = %file;

		cycle0Check();
	} else {
		error(%client.namebase @ " fails to vote for " @ %file);
		%client.sendChat("Server does not have that mission! Pick another one.");
	}
}

function cycle0Check() {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);

		if (%client.cycle0Vote $= "") {
			return;
		}
	}

	cycle0Finish();
}

function cycle0Finish() {
	cycleCountdownCancel();

	serverSendChat("========================");
	serverSendChat("Votes:");
	serverSendChat("========================");

	%levels = Array("Cycle0Levels");

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);

		if (%client.cycle0Vote $= "") {
			continue;
		}

		if (isScriptFile(%client.cycle0Vote)) {
			%levels.addEntry(%client.cycle0Vote);
			serverSendChat(%client.namebase @ ": " @ %client.cycle0Vote);
		}
	}

	if (%levels.getSize() == 0) {
		serverSendChat("No votes!");
		%levels.delete();

		cycleCountdown("Voting ends", $Cycle::Time[0], cycle0Finish);
		return;
	}

	//Pick a random one
	%file = %levels.getEntry(getRandom(0, %levels.getSize() - 1));

	%levels.delete();

	//Play it!
	cycle1Start(%file);
}

//-----------------------------------------------------------------------------
// State 1: Loading
//-----------------------------------------------------------------------------

function cycle1Start(%file) {
	$Cycle::State = 1;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.cycle1Start();
	}

	%info = getMissionInfo(%file, true);

	serverSendChat("Playing " @ %file);
	serverSetMission(%file, %info.game, %info.type, "");
	serverLoadMission(%file);
}

/**
 * @param {GameConnection} %this
 */
function GameConnection::cycle1Start(%this) {
	%this.setHost(false);
}

function cycle1CheckLoad() {
	if ($Server::Loaded) {
		cycle1Finish();
	}
}

function cycle1Finish() {
	cycleCountdown("Starting", $Cycle::Pause[1], cycle2Start);
}

//-----------------------------------------------------------------------------
// State 2: Pregame
//-----------------------------------------------------------------------------

function cycle2Start(%file) {
	$Cycle::State = 2;
	serverEnterGame();

	cycleCountdown("Playing", $Cycle::Time[2], cycle2Finish);
}

function cycle2Ready(%client) {
	if ($MP::ReadyCount == getRealPlayerCount()) {
		cycle2Finish();
	}
}

function cycle2Finish() {
	cycleCountdownCancel();
	cycle3Start();
}

//-----------------------------------------------------------------------------
// State 3: Playing
//-----------------------------------------------------------------------------

function cycle3Start(%file) {
	$Cycle::State = 3;
	serverPreGamePlay(true);
}

function cycle3Finish() {
	cycleCountdown("Returning", $Cycle::Pause[1], cycle3Cleanup);
}

function cycle3Cleanup() {
	cycleCountdownCancel();

	lobbyReturn();
	cycle0Start();
}

//-----------------------------------------------------------------------------
// Override package
//-----------------------------------------------------------------------------

package CycleServer {
	function checkAllClientsLoaded() {
		Parent::checkAllClientsLoaded();
		cycle1CheckLoad();
	}
	/**
	 * @param {GameConnection} %client
	 */
	function serverCmdSetMission(%client, %file, %game, %difficulty, %forceMode) {
		cycle0Switch(%client, %file, %game, %difficulty, %forceMode);
	}
	/**
	 * @param {GameConnection} %client
	 */
	function serverCmdLoadMission(%client, %file) {
		cycle0Vote(%client, %file);
	}
	/**
	 * @param {GameConnection} %client
	 */
	function GameConnection::finishConnect(%client) {
		Parent::finishConnect(%client);

		//Gotta get them up to speed
		switch ($Cycle::State) {
		case 0:
			%client.cycle0Start();
		case 1:
			%client.cycle1Start();
		}
	}

	/**
	 * @param {GameConnection} %client
	 */
	function serverCmdReady(%client, %ready) {
		Parent::serverCmdReady(%client, %ready);
		updateReadyUserList();
		cycle2Ready(%client);
	}
	function endGameSetup() {
		Parent::endGameSetup();
		cycle3Finish();
	}
};

//-----------------------------------------------------------------------------
// Helper functions
//-----------------------------------------------------------------------------

function cycleCountdown(%name, %time, %function) {
	//Cancel previous
	cycleCountdownCancel();

	$Cycle::Countdowns = -1; //pls
	$Cycle::Countdown[$Cycle::Countdowns++] = schedule(%time, 0, %function);

	serverSendChat(cycleFormatCountdown(%time, %name));
	$Cycle::Countdown[$Cycle::Countdowns++] = schedule(%time - 1000, 0, serverSendChat, cycleFormatCountdown(1000, %name));
	$Cycle::Countdown[$Cycle::Countdowns++] = schedule(%time - 2000, 0, serverSendChat, cycleFormatCountdown(2000, %name));
	$Cycle::Countdown[$Cycle::Countdowns++] = schedule(%time - 3000, 0, serverSendChat, cycleFormatCountdown(3000, %name));
	$Cycle::Countdown[$Cycle::Countdowns++] = schedule(%time - 4000, 0, serverSendChat, cycleFormatCountdown(4000, %name));
	if (%time > 5000) {
		$Cycle::Countdown[$Cycle::Countdowns++] = schedule(%time - 5000, 0, serverSendChat, cycleFormatCountdown(5000, %name));
	}
	if (%time > 10000) {
		$Cycle::Countdown[$Cycle::Countdowns++] = schedule(%time - 10000, 0, serverSendChat, cycleFormatCountdown(10000, %name));
	}
	if (%time > 30000) {
		$Cycle::Countdown[$Cycle::Countdowns++] = schedule(%time - 30000, 0, serverSendChat, cycleFormatCountdown(30000, %name));
	}
	if (%time > 60000) {
		$Cycle::Countdown[$Cycle::Countdowns++] = schedule(%time - 60000, 0, serverSendChat, cycleFormatCountdown(60000, %name));
	}
}

function cycleCountdownCancel() {
	for (%i = 0; %i < $Cycle::Countdowns; %i ++) {
		cancel($Cycle::Countdown[%i]);
	}
}

function cycleFormatCountdown(%time, %name) {
	return %name @ " in " @ (%time / 1000) @ "...";
}

/**
 * @param {MissionList} %ml
 * @param {Array} %collection
 */
function collectMissions(%ml, %game, %difficulty, %collection) {
	/** @type {Array} */
	%list = %ml.getMissionList(%game, %difficulty);
	if (!isObject(%list)) {
		%ml.buildMissionList(%game, %difficulty);
	}
	if (!isObject(%list)) {
		return;
	}

	for (%i = 0; %i < %list.getSize(); %i ++) {
		%mission = %list.getEntry(%i);
		//Send them the file

		%info = getMissionInfo(%mission.file, true);
		%collection.addEntry(%info);
	}
}

function getRandomHuntMap() {
	%ml = getMissionList("mp");

	%list = Array(CycleMapListArray);
	%difficulties = %ml.getDifficultyList("Hunt");
	%dcount = getRecordCount(%difficulties);
	for (%i = 0; %i < %dcount; %i ++) {
		%difficulty = getRecord(%difficulties, %i);
		%difficultyName = getField(%difficulty, 0);
		collectMissions(%ml, "Hunt", %difficultyName, %list);
	}
	collectMissions(%ml, "CustomHunt", "Custom", %list);

	//Play a random one
	%mis = %list.getEntry(getRandom(%list.getSize() - 1));

	%list.delete();

	return %mis;
}

