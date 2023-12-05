//-----------------------------------------------------------------------------
// Gem Madness Mode (server)
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

function Mode_GemMadness::onLoad(%this) {
	%this.registerCallback("shouldStoreGem");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("onOutOfBounds");

	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldResetGem");
	%this.registerCallback("getStartTime");
	%this.registerCallback("onTimeExpire");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	%this.registerCallback("onEnterPad");
	%this.registerCallback("shouldRestorePowerup");

	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_GemMadness::onFoundGem(%this, %object) {
	// Play gem sound when collected
	%object.client.playPitchedSound("gotDiamond" @ (%object.gem._huntDatablock.huntExtraValue + 1));
}
function Mode_GemMadness::shouldStoreGem(%this, %object) {
	// gems, like hunt mode, have different levels of points
	%object.user.client.gemCount += %object.obj._huntDatablock.huntExtraValue;
	%object.user.client.gemsFound[%object.obj._huntDatablock.huntExtraValue + 1] ++;

	// simply just despawns the gem object
	unspawnGem(%object.obj);
	$Game::GemCount --;

	%object.user.client.displayGemMessage((%object.obj._huntDatablock.huntExtraValue + 1 >= 0 ? "+" : "") @ (%object.obj._huntDatablock.huntExtraValue + 1), %object.obj._huntDatablock.messageColor);

	commandToAll('UseTimeScore', ($Game::GemCount == 0));
	if ($Game::GemCount == 0) {
		Time::stop();
		Time::set(MissionInfo.time - $Time::CurrentTime);

		%this.gotAllGems = true;

		//They win!
		$Game::FinishClient = %object.client;
		endGameSetup();
	}

	return false;
}
function Mode_GemMadness::shouldResetGem(%this, %object) {
	return false;
}
function Mode_GemMadness::shouldResetTime(%this, %object) {
	return false;
}
function Mode_GemMadness::shouldRestartOnOOB(%this, %object) {
	return false;
}
function Mode_GemMadness::shouldRespawnGems(%this, %object) {
	return false;
}
function Mode_GemMadness::shouldRestorePowerup(%this, %object) {
	return true;
}
function Mode_GemMadness::shouldRestartOnOOB(%this, %object) {
	// previously restarted on singleplayer, now oob finishes level with current score
	return false;
}
function Mode_GemMadness::onOutOfBounds(%this, %object) {
	if ($Server::ServerType $= "SinglePlayer") {
		%this.gotAllGems = false;
		commandToAll('UseTimeScore', false);
		%object.client.player.setMode(Victory);
		messageClient(%object.client, 'MsgRaceOver', '\c0Congratulations! You\'ve finished!');
		$Game::FinishClient = %object.client;
		endGameSetup();
	}
}

function Mode_GemMadness::shouldResetTime(%this, %object) {
	// The timer should reset only for singleplayer when the marble goes oob
	return ($Server::ServerType $= "SinglePlayer");
}
function Mode_GemMadness::shouldResetGem(%this, %object) {
	// Whenever the mission is reset via onMissionReset(), the gems should be
	// respawned
	return true;
}
function Mode_GemMadness::getStartTime(%this) {
	return (MissionInfo.time ? MissionInfo.time : 300000);
}
function Mode_GemMadness::onTimeExpire(%this) {
	%this.gotAllGems = false;
	commandToAll('UseTimeScore', false);
}
function Mode_GemMadness::timeMultiplier(%this) {
	// Timer counts down
	return -1;
}
function Mode_GemMadness::getScoreType(%this) {
	if (%this.gotAllGems) {
		return $ScoreType::Time;
	}
	return $ScoreType::Score;
}
function Mode_GemMadness::getFinalScore(%this, %object) {
	if (%this.gotAllGems) {
		return $ScoreType::Time TAB $Time::CurrentTime;
	}
	return $ScoreType::Score TAB %object.client.getGemCount();
}
function Mode_GemMadness::onEnterPad(%this, %object) {
	%this.gotAllGems = false;
	commandToAll('UseTimeScore', false);
	%object.client.player.setMode(Victory);
	messageClient(%object.client, 'MsgRaceOver', '\c0Congratulations! You\'ve finished!');
	$Game::FinishClient = %object.client;
	endGameSetup();
	return true;
}
