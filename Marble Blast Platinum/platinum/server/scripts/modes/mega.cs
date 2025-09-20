//-----------------------------------------------------------------------------
// Mega Mode
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

function Mode_mega::onLoad(%this) {
	%this.registerCallback("onCollision");
	%this.registerCallback("getStartTime");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("shouldResetGem");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("shouldRestorePowerup");
	%this.registerCallback("updateWinner");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_mega::onCollision(%this, %object) {
	if ($MP::Teammode &&
	        isObject(%object.client1.team) && isObject(%object.client2.team) &&
	        %object.client1.team.getId() == %object.client2.team.getId()) {
		//Team kill! No points!
		return;
	}
	%pts = mFloor(mLog(VectorLen(%object.client1.player.getVelocity())) / mLog(2)) + 1;
	if (%pts > 0) {
		%object.client1.onFoundGem(%pts);
		%object.client1.displayGemMessage("+" @ %pts, "99ff99");
		%object.client1.gemsFound[5] ++;
		%object.client2.gemsFound[1] ++;
	}
}
function Mode_mega::timeMultiplier(%this) {
	return -1;
}
function Mode_mega::getStartTime(%this) {
	return (MissionInfo.time ? MissionInfo.time : 300000);
}
function Mode_mega::shouldResetGem(%this, %object) {
	return false;
}
function Mode_mega::shouldResetTime(%this, %object) {
	return false;
}
function Mode_mega::shouldRestartOnOOB(%this, %object) {
	return false;
}
function Mode_mega::shouldRespawnGems(%this, %object) {
	return false;
}
function Mode_mega::shouldRestorePowerup(%this, %object) {
	return true;
}
function Mode_mega::updateWinner(%this, %winners) {
	//The player with the most points wins
	%winner = ClientGroup.getObject(0);
	%count = ClientGroup.getCount();

	//Who has the most points?
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
function Mode_mega::getScoreType(%this) {
	return $ScoreType::Score;
}
function Mode_mega::getFinalScore(%this, %object) {
	return $ScoreType::Score TAB %object.client.getGemCount();
}