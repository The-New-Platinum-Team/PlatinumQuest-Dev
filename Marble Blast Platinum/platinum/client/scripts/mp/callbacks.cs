//-----------------------------------------------------------------------------
// ClientCallbacks.cs
//
// For mis mod support that doesn't make me go crazy
// Re-executed on server join / level load
//
// Copyright (c) 2014 The Platinum Team
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

function clientCbOnServerJoin() {

}

function clientCbOnServerLeave() {

}

function clientCbOnOutOfBounds() {

}

function clientCbOnRespawn() {

}

function clientCbOnRespawnOnCheckpoint() {

}

function clientCbOnActivateCheckpoint() {

}

function clientCbOnPlayerJoin() {

}

function clientCbOnPlayerLeave() {

}

function clientCbOnMissionLoaded() {

}

function clientCbOnMissionEnded() {

}

function clientCbOnMissionReset() {

}

function clientCbOnRestartLevel() {

}

function clientCbOnEndGameSetup() {

}

function clientCbOnHuntGemSpawn() {

}

function clientCbCheckEndgameAchievements() {

}

function clientCbOnFrameAdvance(%timeDelta) { //For weather

}

function clientCmdCbOnOutOfBounds() {
	clientCbOnOutOfBounds();
	ClientMode::callback("onOutOfBounds", "");
}

function clientCmdCbOnRespawn() {
	clientCbOnRespawn();
	ClientMode::callback("onRespawnPlayer", "");

	if (ClientMode::callback("shouldUseClientPowerups", false)) {
		$MP::MyMarble._respawnPowerup();
	}
	//Clear bubble stuff
	BubbleClearCP();
	clientCmdSetBubbleTime(0, 0);

	//Clear fireball
	clientCmdFireballExpire();

	deleteVariables("$Client::UsedPowerup*");

	PlayGui.clearPowerupTimers();

	clientResetTriggerEntry();
	Gravity::clearTriggers();
	Physics::popAllLayers();
	clientTriggerCollisionTest();
	$Client::Frozen = false;
	$Client::CannonCount = 0;
	$Game::Jumped = false;
	$Game::Jumps = 0;

	clientCmdCancelCannon(false);
	clearMessages();
}

function clientCmdCbOnRespawnOnCheckpoint() {
	clientCbOnRespawnOnCheckpoint();
	ClientMode::callback("onRespawnOnCheckpoint", "");

	$MP::MyMarble._respawnPowerupOnCheckpoint();
	BubbleRestoreCP();
	$Game::BubbleActive = 0;
	Physics::popLayerName("Bubble");

	PlayGui.clearPowerupTimers();

	clientResetTriggerEntry();
	Gravity::clearTriggers();
	$Client::Frozen = false;

	clientCmdCancelCannon(false);
}

function clientCmdCbOnActivateCheckpoint() {
	clientCbOnActivateCheckpoint();
	ClientMode::callback("onActivateCheckpoint", "");

	$MP::MyMarble._onActivateCheckpoint();
	BubbleSaveCP();
}

function clientCmdCbOnPlayerJoin() {
	clientCbOnPlayerJoin();
	ClientMode::callback("onPlayerJoin", "");
}

function clientCmdCbOnPlayerLeave() {
	clientCbOnPlayerLeave();
	ClientMode::callback("onPlayerLeave", "");
}

function clientCmdCbOnMissionLoaded() {
	clientCbOnMissionLoaded();
	ClientMode::callback("onMissionLoaded", "");

	//Reset gravity loops
	cancel($AGL);

	clientResetTriggerEntry();
	Gravity::clearTriggers();
	Physics::popAllLayers();
	clientTriggerCollisionTest();

	//Clear bubble stuff
	BubbleClearCP();
	clientCmdSetBubbleTime(0, 0);
	//Clear fireball
	clientCmdFireballExpire();

	clientCmdCancelCannon(false);
}

function clientCmdCbOnMissionEnded() {
	clientCbOnMissionEnded();
	ClientMode::callback("onMissionEnded", "");

	// clean up triggers
	devecho("Cleaning up client sided triggers. Mission ended.");
	clearClientTriggerList();
	clientClearPaths();

	clientCmdCancelCannon(false);
}

function clientCmdCbOnMissionReset() {
	clientCbOnMissionReset();
	ClientMode::callback("onMissionReset", "");
}

function clientCmdCbOnRestartLevel() {
	clientCbOnRestartLevel();
	ClientMode::callback("onRestartLevel", "");

	if ($Record::Recording) {
		recordOnRespawn();
	}
}

function clientCmdCbOnEndGameSetup() {
	clientCbOnEndGameSetup();
	ClientMode::callback("onEndGameSetup", "");
}

function clientCmdCbOnHuntGemSpawn() {
	clientCbOnHuntGemSpawn();
	ClientMode::callback("onHuntGemSpawn", "");

	if ($Record::Recording) {
		recordWriteSpawn(RecordFO);
	}
}

function clientCmdCbCheckEndgameAchievements() {
	clientCbCheckEndgameAchievements();
}
