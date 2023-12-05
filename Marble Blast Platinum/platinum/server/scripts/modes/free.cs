//-----------------------------------------------------------------------------
// Free World mode
//
// Originally created in 2013
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

function Mode_free::onLoad(%this) {
	%this.registerCallback("onMissionReset");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onTimeExpire");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("onGameState");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("canFinish");
	%this.registerCallback("onEnterPad");
	%this.registerCallback("shouldAllowTTs");
	%this.registerCallback("shouldRestorePowerup");
	%this.registerCallback("getGemCount");
	%this.registerCallback("getMaxSpectators");
	%this.registerCallback("getQuickRespawnTimeout");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_free::onMissionReset(%this) {
	//No gems
	hideGems();
	%this.schedule(100, startTime);
}
function Mode_free::timeMultiplier(%this) {
	//ooooh 0x time multiplier
	return 0;
}
function Mode_free::onTimeExpire(%this) {
	return false;
}
function Mode_free::shouldResetTime(%this) {
	return false;
}
function Mode_free::shouldRestartOnOOB(%this) {
	return false;
}
function Mode_free::onGameState(%this, %object) {
	//No RSG sequence
	cancel(%object.client.stateSchedule);
	cancel($Game::StateSchedule);
	%object.client.player.setMode(Normal);
	%object.client.setMessage("");
	
	if (%object.state !$= "waiting") {
		%object.client.state = "Go";
		$Game::State = "Go";
		%object.client.player.disableStartHelpText = true;
	}
}
function Mode_free::onDeactivate(%this) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		ClientGroup.getObject(%i).player.disableStartHelpText = false;
	}
}
function Mode_free::canFinish(%this, %object) {
	return false;
}
function Mode_free::onEnterPad(%this, %object) {
	return true;
}
function Mode_free::shouldAllowTTs(%this) {
	return false;
}
function Mode_free::shouldRestorePowerup(%this, %object) {
	return true;
}
function Mode_free::getGemCount(%this, %object) {
	//Scores don't exist here!
	%object.client.gemCount = "";
	return "";
}
function Mode_free::getMaxSpectators(%this) {
	//You should be allowed to spectate even if no one else is playing
	return $MP::PlayerMaximum;
}
function Mode_free::getQuickRespawnTimeout(%this, %object) {
	//You should always be able to quick respawn
	return 0;
}

function Mode_free::startTime(%this) {
	if ($Game::State $= "Waiting")
		return;
	Time::start();
	cancel($Game::StateSchedule);
	$Game::State = "Go";
}