//-----------------------------------------------------------------------------
// Null mode - default behavior
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

//All modes are a subclass of Mode. Every mode will have a ScriptObject
// created for it which will have onLoad called when a user loads the mode.
function Mode_null::onLoad(%this) {
	//Register the mode for all of the callbacks which it will need to use.
	// The null mode registers for all callbacks, and has documentation on
	// each in the functions below.
	%this.registerCallback("onCreateGhost");
	%this.registerCallback("getCheckpointPos");
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onStartGame");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("onEndGame");
	%this.registerCallback("onGameState");
	%this.registerCallback("onClientEnterGame");
	%this.registerCallback("onClientLeaveGame");
	%this.registerCallback("onResetStats");
	%this.registerCallback("shouldTotalGemCount");
	%this.registerCallback("onEnterPad");
	%this.registerCallback("onLeavePad");
	%this.registerCallback("onOutOfBounds");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("getGemCount");
	%this.registerCallback("onSpawnPlayer");
	%this.registerCallback("onRestartLevel");
	%this.registerCallback("onQuickRespawnPlayer");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onCreatePlayer");
	%this.registerCallback("shouldPickupGem");
	%this.registerCallback("shouldIgnoreGem");
	%this.registerCallback("shouldStoreGem");
	%this.registerCallback("shouldResetGem");
	%this.registerCallback("shouldDisablePoweup");
	%this.registerCallback("shouldPickupPowerup");
	%this.registerCallback("onPlayerJoin");
	%this.registerCallback("onPlayerLeave");
	%this.registerCallback("onCollision");
	%this.registerCallback("updateWinner");
	%this.registerCallback("onUpdateGhost");
	%this.registerCallback("getStartTime");
	%this.registerCallback("shouldResetPath");
	%this.registerCallback("shouldPickupItem");
	%this.registerCallback("shouldAllowTTs");
	%this.registerCallback("onHuntGemSpawn");
	%this.registerCallback("onBlast");
	%this.registerCallback("onServerChat");
	%this.registerCallback("shouldSetSpectate");
	%this.registerCallback("onTimeExpire");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("shouldUseUltraMarble");
	%this.registerCallback("getMarbleSize");
	%this.registerCallback("getUltraMarbleSize");
	%this.registerCallback("getMegaMarbleSize");
	%this.registerCallback("getQuickRespawnTimeout");
	%this.registerCallback("getMaxSpectators");
	%this.registerCallback("getPregameUserRow");
	%this.registerCallback("shouldUseClientPowerups");
	%this.registerCallback("shouldSendScores");
	%this.registerCallback("modifyPlayerScoreData");
	%this.registerCallback("modifyScoreData");
	%this.registerCallback("shouldRestorePowerup");
	%this.registerCallback("canFinish");
	%this.registerCallback("getFinishMessage");
	%this.registerCallback("onBeforeMissionLoad");
	%this.registerCallback("onActivateCheckpoint");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	%this.registerCallback("onPreServerVariableSet");
	%this.registerCallback("onPostServerVariableSet");

	//Don't kill our CPU, but this is how you'd do it
	//%this.registerCallback("onFrameAdvance");

	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_null::onCreateGhost(%this, %object) {
	//Description:
	// Called from GameConnection::createGhost when a player's ghost is
	// initially created.
	//Parameters:
	// client - GameConnection
}
function Mode_null::getCheckpointPos(%this, %object) {
	//Description:
	// Called from respawnPlayer to get where the player will respawn.
	//Parameters:
	// client - GameConnection
	// num - int
	// add - vector
	// sub - vector
	//Returns
	// Matrix TAB rot TAB pitch
}
function Mode_null::onMissionLoaded(%this, %object) {
	//Description:
	// Called from onMissionLoaded.
	//Parameters:
	// none
}
function Mode_null::onMissionEnded(%this, %object) {
	//Description:
	// Called from onMissionEnded.
	//Parameters:
	// none
}
function Mode_null::onMissionReset(%this, %object) {
	//Description:
	// Called from onMissionReset.
	//Parameters:
	// none
}
function Mode_null::onStartGame(%this, %object) {
	//Description:
	// Called from startGame.
	//Parameters:
	// none
}
function Mode_null::onEndGameSetup(%this, %object) {
	//Description:
	// Called from endGameSetup.
	//Parameters:
	// none
}
function Mode_null::onEndGame(%this, %object) {
	//Description:
	// Called from endGame.
	//Parameters:
	// none
}
function Mode_null::onGameState(%this, %object) {
	//Description:
	// Called when a client has their game state set (setGameState)
	//Parameters:
	// client - GameConnection
	// state - string
}
function Mode_null::onClientEnterGame(%this, %object) {
	//Description:
	// Called when a client enters the game. (onClientEnterGame)
	//Parameters:
	// client - GameConnection
}
function Mode_null::onClientLeaveGame(%this, %object) {
	//Description:
	// Called when a client leaves the game. (onClientLeaveGame)
	//Parameters:
	// client - GameConnection
}
function Mode_null::onResetStats(%this, %object) {
	//Description:
	// Called when a client's stats are reset (resetStats)
	//Parameters:
	// client - GameConnection
}
function Mode_null::shouldTotalGemCount(%this, %object) {
	//Description:
	// Called in onEnterPad to see if the game should total all players
	// gem counts for activating the finish pad (like co-op mode).
	//Parameters:
	// none
	//Returns:
	// true/false
	return false;
}
function Mode_null::onEnterPad(%this, %object) {
	//Description:
	// Called when a client enters a pad. (onEnterPad) If it returns true the
	// default behavior will be overridden.
	//Parameters:
	// client - GameConnection
	// isFinishTrigger - if the client touched a finish trigger
	//Returns:
	// true/false
	return false;
}
function Mode_null::onLeavePad(%this, %object) {
	//Description:
	// Called when a client leaves a pad. (onLeavePad)
	//Parameters:
	// client - GameConnection
}
function Mode_null::onOutOfBounds(%this, %object) {
	//Description:
	// Called when a client goes Out of Bounds.
	//Parameters:
	// client - GameConnection
}
function Mode_null::onFoundGem(%this, %object) {
	//Description:
	// Called when a client finds a gem. This method should display any
	// desired message to the client and/or play sound.
	//Parameters:
	// client - GameConnection
	// amount - int
	// gem - Item

	%remaining = $Game::gemCount - %object.client.getGemCount();
	if (%remaining <= 0) {
		messageClient(%object.client, 'MsgHaveAllGems', "\c0Finish the level.");
		%object.client.playPitchedSound("gotalldiamonds");
	} else {
		if (%remaining == 1) {
			%msg = "\c0One gem remaining.";
		} else {
			%msg = "\c0" @ %remaining @ " gems remaining.";
		}

		messageClient(%object.client, 'MsgItemPickup', %msg, %remaining);
		%object.client.playPitchedSound("gotDiamond");
	}
}
function Mode_null::getGemCount(%this, %object) {
	//Description:
	// Called to get how many gems a client has. Note this is how many they appear
	// to have, the %this.gemCount variable may be different.
	//Parameters:
	// client - GameConnection
	//Returns:
	// integer

	%total = Mode::callback("shouldTotalGemCount", false);
	if ($Server::ServerType $= "MultiPlayer" && %total) {
		//Get the total gemcount and tell everyone
		%gemCount = 0;
		%count = ClientGroup.getCount();
		for (%i = 0; %i < %count; %i ++)
			%gemCount += ClientGroup.getObject(%i).gemCount;
	} else {
		%gemCount = %object.client.gemCount;
	}
	return %gemCount;
}
function Mode_null::onSpawnPlayer(%this, %object) {
	//Description:
	// Called when a client's player is spawned initially. (spawnPlayer)
	//Parameters:
	// client - GameConnection
	// spawnPoint - Matrix TAB yaw TAB pitch
}
function Mode_null::onRestartLevel(%this, %object) {
	//Description:
	// Called when the level is restarted. (restartLevel)
	//Parameters:
	// none
}
function Mode_null::onQuickRespawnPlayer(%this, %object) {
	//Description:
	// Called when a client quick respawns. (quickRespawnPlayer)
	//Parameters:
	// client - GameConnection
}
function Mode_null::shouldRestartOnOOB(%this, %object) {
	//Description:
	// Called to determine if the game should be reset when a client is
	// respawned. Returning true will setGameState(start) for MP, and will
	// onMissionReset() for SP.
	//Parameters:
	// client - GameConnection
	//Returns:
	// true/false
	return true;
}
function Mode_null::shouldResetTime(%this, %object) {
	//Description:
	// Called to determine if a client's time should be reset when respawning
	// to their previous checkpoint's (or the default) time.
	//Parameters:
	// client - GameConnection
	//Returns:
	// true/false
	return $Server::ServerType $= "SinglePlayer";
}
function Mode_null::onRespawnPlayer(%this, %object) {
	//Description:
	// Called when a client respawns. (respawnPlayer)
	//Parameters:
	// client - GameConnection
	// spawnPoint - Matrix TAB rot TAB pitch
}
function Mode_null::onCreatePlayer(%this, %object) {
	//Description:
	// Called when a client's player is created. (createPlayer)
	//Parameters:
	// client - GameConnection
	// spawnPoint - Matrix TAB rot TAB pitch
}
function Mode_null::shouldPickupGem(%this, %object) {
	//Description:
	// Called to determine if a client should pick up a gem.
	//Parameters:
	// this - DataBlock
	//	obj - Item
	// user - Marble
	// amount - int
	//Returns:
	// true/false
	return true;
}
function Mode_null::shouldIgnoreGem(%this, %object) {
	//Description:
	// Called to determine if a client should ignore a gem after picking it
	// up. If this returns true, then the client will not get an onFoundGem
	// message.
	//Parameters:
	// this - DataBlock
	//	obj - Item
	// user - Marble
	// amount - int
	//Returns:
	// true/false
	return false;
}
function Mode_null::shouldStoreGem(%this, %object) {
	//Description:
	// Called to determine if a client should store pickup information
	// about a gem that they collected (id, value counts).
	//Parameters:
	// this - DataBlock
	//	obj - Item
	// user - Marble
	// amount - int
	//Returns:
	// true/false
	return true;
}
function Mode_null::shouldResetGem(%this, %object) {
	//Description:
	// Called to determine if a gem should be respawned in onMissionReset.
	//Parameters:
	// this - DataBlock
	//	obj - Item
	//Returns:
	// true/false
	return true;
}
function Mode_null::shouldDisablePoweup(%this, %object) {
	//Description:
	// Called to determine if a PowerUp should be disabled for a client.
	// Used in race mode and the like.
	//Parameters:
	// this - DataBlock
	//	obj - Item
	// user - Marble
	// amount - int
	//Returns:
	// true/false
	return false;
}
function Mode_null::shouldPickupPowerup(%this, %object) {
	//Description:
	// Called to determine if a player should pick up a PowerUp. Unlike the
	// above method, if this returns false, inventory PowerUps will still be
	// collected, they just won't disappear.
	//Parameters:
	// this - DataBlock
	//	obj - Item
	// user - Marble
	// amount - int
	//Returns:
	// true/false
	return true;
}
function Mode_null::onPlayerJoin(%this, %object) {
	//Description:
	// Called when a client joins the server. (finishConnect)
	//Parameters:
	// client - GameConnection
}
function Mode_null::onPlayerLeave(%this, %object) {
	//Description:
	// Called when a client leaves the server (onDrop)
	//Parameters:
	// client - GameConnection
}
function Mode_null::onCollision(%this, %object) {
	//Description:
	// Called when two marbles collide.
	//Parameters:
	// client1 - GameConnection
	// client2 - GameConnection
}
function Mode_null::updateWinner(%this, %object) {
	//Description:
	// Called to determine the order of winners when a game is finished.
	// Used only in the winner display system, not for rating calculation.
	//Parameters:
	// winners - Array object
	//Note:
	// Add clients to the array; mutate it and don't return anything
}
function Mode_null::onUpdateGhost(%this, %object) {
	//Description:
	// Called when a client's ghost is updated. This could be when they
	// activate a mega marble, change their marble skin, or any other action
	// that calls updateGhostDatablock.
	//Parameters:
	// client - GameConnection
}
function Mode_null::getStartTime(%this, %object) {
	//Description:
	// Called to determine the initial time for a level, could be duration
	// or simply start time.
	//Parameters:
	// none
	//Return:
	// integer
	return 0;
}
function Mode_null::shouldResetPath(%this, %object) {
	//Description:
	// Called to determine if an Item / PathedInterior should reset itself
	// during onMissionReset.
	//Parameters:
	// this - Item
	//Return:
	// true/false

	// Always reset in SP, only on restart for MP
	return $MP::Restarting || $Server::ServerType $= "SinglePlayer";
}
function Mode_null::shouldPickupItem(%this, %object) {
	//Description:
	// Called to determine if a client should pick up an item.
	//Parameters:
	// this - DataBlock
	//	obj - Item
	// user - Marble
	// amount - int
	//Returns:
	// true/false
	return true;
}
function Mode_null::shouldAllowTTs(%this, %object) {
	//Description:
	// Called to determine if the game mode allows Time Travels. If false
	// is returned, all Time Travels will be uncollectable.
	//Parameters:
	// none
	//Return:
	// true/false
	return true;
}
function Mode_null::onHuntGemSpawn(%this, %object) {
	//Description:
	// Called when a set of gems is spawned using the hunt code.
	//Parameters:
	// none
}
function Mode_null::onBlast(%this, %object) {
	//Description:
	// Called when a client blasts, with a strength of how much the blast will
	// affect another client.
	//Parameters:
	// this - GameConnection
	// other - GameConnection
	// strength - float
}
function Mode_null::onServerChat(%this, %object) {
	//Description:
	// Called when a client sends a chat message. If true is returned, the
	// message will not be sent.
	//Parameters:
	// client - GameConnection
	// message - string
	//Returns:
	// true/false
	return false;
}
function Mode_null::shouldSetSpectate(%this, %object) {
	//Description:
	// Called when a client tries to spectate. This will determine if they can
	// spectate, although player limit and state restrictions still apply.
	//Parameters:
	// client - GameConnection
	//Returns:
	// true/false
	return true;
}
function Mode_null::onTimeExpire(%this, %object) {
	//Description:
	// Called when the timer reaches 00:00.000 ingame. If true is returned,
	// then a GameEnd command will be sent.
	//Parameters:
	// none
	//Returns:
	// true/false

	//If the current mode is not a countdown mode, then don't do anything.
	return (Mode::callback("timeMultiplier", 1) <= 0);
}
function Mode_null::timeMultiplier(%this, %object) {
	//Description:
	// Called to determine which direction the timer should run (forwards
	// is positive, backwards is negative) and at what rate. (1 is default).
	//Parameters:
	// none
	//Returns:
	// Integer

	//Default behavior is forwards at 1x
	return 1;
}
function Mode_null::shouldUseUltraMarble(%this, %object) {
	//Description:
	// Called to determine if a player's marble should use an MBU-sized marble
	//Parameters:
	// client - GameConnection
	// skinChoice - string
	//Returns:
	// true/false
	return !!MissionInfo.useUltraMarble;
}
function Mode_null::getMarbleSize(%this, %object) {
	//Description:
	// Called to determine the radius of a player for normal levels
	//Parameters:
	// client - GameConnection
	// skinChoice - string
	//Returns:
	// Integer

	// MBG is slightly different than MBP/PQ because ~~someone couldn't measure~~
	// Because reasons
	if ($CurrentGame $= "Gold")
		return %object.client.player.getDataBlock().goldScale;
	else
		return %object.client.player.getDataBlock().scale;
}
function Mode_null::getUltraMarbleSize(%this, %object) {
	//Description:
	// Called to determine the radius of a player for MBU levels
	//Parameters:
	// client - GameConnection
	// skinChoice - string
	//Returns:
	// Integer

	return %object.client.player.getDataBlock().ultraScale;
}
function Mode_null::getMegaMarbleSize(%this, %object) {
	//Description:
	// Called to determine the radius of a player for mega marbles
	//Parameters:
	// client - GameConnection
	// skinChoice - string
	//Returns:
	// Integer

	return %object.client.player.getDataBlock().megaScale;
}
function Mode_null::getQuickRespawnTimeout(%this, %object) {
	//Description:
	// Called to determine how long a player's quick respawn should be locked.
	//Parameters:
	// client - GameConnection
	//Returns:
	// Integer (ms)

	return $MP::QuickSpawnTimeout;
}
function Mode_null::getMaxSpectators(%this) {
	//Description:
	// Called to determine the maximum number of people who can spectate on
	// a server.
	//Parameters:
	// none
	//Returns:
	// Integer

	return getRealPlayerCount() - 1;
}
function Mode_null::getPregameUserRow(%this, %object) {
	//Description:
	// Gets the row that should be displayed on the pre-game screen for a player.
	//Parameters:
	// client - GameConnection
	//Returns:
	// String

	//Blank string just uses the server default
	return "";
}
function Mode_null::shouldUseClientPowerups(%this) {
	//Description:
	// Called to determine if the mode should use client-sided powerups.
	//Parameters:
	// none
	//Returns:
	// true/false
	return $MP::FastPowerups;
}
function Mode_null::shouldSendScores(%this) {
	//Description:
	// Called to determine if the game should calculate multiplayer scores.
	//Parameters:
	// none
	//Returns:
	// true/false
	return true;
}
function Mode_null::modifyPlayerScoreData(%this, %object) {
	//Description:
	// Called when sending scores; allows modes to modify the data sent to
	// the server. Return the updated data string for that player.
	//Parameters:
	// client - GameConnection
	// data - string
	//Returns:
	// string

	return %object.data;
}
function Mode_null::modifyScoreData(%this, %object) {
	//Description:
	// Called when sending scores; allows modes to modify the data sent to
	// the server.
	//Parameters:
	// data - string
	//Returns:
	// string

	return %object.data;
}
function Mode_null::onFrameAdvance(%this, %delta) {
	//Description:
	// Called on every tick of the timer. Note that delta is not an object
	// like the other functions.
	//Parameters:
	// delta - float
}
function Mode_null::shouldRestorePowerup(%this, %object) {
	//Description:
	// Called when respawning to determine if we should save the user's powerup
	// and give it back after respawning. False will just reset it.
	//Parameters:
	// client - GameConnection

	return false;
}
function Mode_null::canFinish(%this, %object) {
	//Description:
	// Called to determine if a player is allowed to finish the level.
	//Parameters:
	// client - GameConnection
	//Returns:
	// true/false

	return !($Game::GemCount && %object.client.getGemCount() < $Game::GemCount);
}
function Mode_null::getFinishMessage(%this, %object) {
	//Description:
	// Called to get the message for why you cannot finish.
	//Parameters:
	// client - GameConnection
	//Returns:
	// string

	return "";
}
function Mode_null::onBeforeMissionLoad(%this) {
	//Description:
	// Called right before the mission is executed, so modes can reset stuff
	// that is updated in onAdd functions.
	//Parameters:
	// none
}
function Mode_null::onActivateCheckpoint(%this, %object) {
	//Description:
	// Called to get the message for why you cannot finish.
	//Parameters:
	// client - GameConnection
	// obj - SceneObject
}
function Mode_null::getScoreType(%this) {
	//Description:
	// Called to determine if a final score is a time or a score
	//Parameters:
	// none
	//Returns:
	// ScoreType

	return $ScoreType::Time;
}
function Mode_null::getFinalScore(%this, %object) {
	//Description:
	// Called to determine if a final score is a time or a score
	//Parameters:
	// client - Client whose final score is being calculated
	//Returns:
	// ScoreType TAB time

	return $ScoreType::Time TAB $Time::CurrentTime;
}
function Mode_null::onPreServerVariableSet(%this, %object) {
	//Description:
	// Called to determine if a server variable update should be allowed
	//Parameters:
	// id - string: Variable identifier
	// previous - string: Previous value of variable
	// value - string: New value to set
	//Returns:
	// true/false

	return true;
}
function Mode_null::onPostServerVariableSet(%this, %object) {
	//Description:
	// Called after a server variable update has happened
	//Parameters:
	// id - string: Variable identifier
	// previous - string: Previous value of variable
	// value - string: New value of variable
}