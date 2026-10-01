//-----------------------------------------------------------------------------
// Quota Mode
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

/**
 * @param {Mode} %this
 */
function Mode_quota::onLoad(%this) {
	echo("[Mode" SPC %this.name @ "]: Loaded!");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onGameState");
	%this.registerCallback("canFinish");
	%this.registerCallback("getFinishMessage");
}
/**
 * @param {Mode_quota} %this
 * @param {Type} %object
 */
function Mode_quota::canFinish(%this, %object) {
	%quota = MissionInfo.GemQuota;
	return !($Game::GemCount && %object.client.getGemCount() < %quota);
}
/**
 * @param {Mode_quota} %this
 * @param {Type} %object
 */
function Mode_quota::getFinishMessage(%this, %object) {
	%gemCount = %object.client.getGemCount();

	%quota = MissionInfo.GemQuota;
	if ($Game::GemCount && %gemCount < %quota) {
		return "You may not finish without reaching the gem quota!";
	} else if ($Game::GemCount && %gemCount == $Game::GemCount) {
		return "Wha-? How?! You ACED the level! You Rock!";
	} else {
		return "Congratulations! You\'ve finished!";
	}
}
/**
 * @param {Mode_quota} %this
 * @param {Type} %object
 */
function Mode_quota::onFoundGem(%this, %object) {
	%quota = MissionInfo.GemQuota;
	%gemCount = %object.client.getGemCount();

	%remaining = %quota - %gemCount;
	if (%remaining == 0) {
		%msgType = 'MsgHaveAllGems';
		%msg = "\c0You've reached the gem quota, head for the finish!";
		%object.client.playPitchedSound("gotalldiamonds");
	} else {
		%msgType = 'MsgItemPickup';
		if (%remaining == 1) {
			%msg = "\c0You picked up a gem! Only one gem to go!";
			%object.client.playPitchedSound("gotDiamond");
		} else if (%remaining > 1) {
			%msg = "\c0You picked up a gem! " @ %remaining @ " gems to go!";
			%object.client.playPitchedSound("gotDiamond");
		} else if (%gemCount == $Game::GemCount) {
			if (MissionInfo.time $= "") {
				%msg = "\c0Wow, you got all the gems! Head for the finish!";
			} else if ($Time::CurrentTime < MissionInfo.time) {
				%msg = "\c0Wow, you got all the gems! Head for the finish before time runs out!";
				//todo: play sound here and above
			} else {
				%msg = "\c0You got all the gems, but the time already ran out!";
			}
			%object.client.playPitchedSound("gotalldiamonds");
		} else if ($Game::GemCount - %gemCount == 1) {
			%msg = "\c0You picked up a gem! Only one more gem to reach 100%!";
			%object.client.playPitchedSound("gotDiamond");
		} else {
			%msg = "\c0You picked up a gem! " @ $Game::GemCount - %gemCount SPC "gems more to reach 100%!";
			%object.client.playPitchedSound("gotDiamond");
		}
	}
	messageClient(%object.client, %msgType, %msg, %remaining);
}
/**
 * @param {Mode_quota} %this
 */
function Mode_quota::onMissionReset(%this) {
	commandToAll('SetGemQuota', $Game::GemCount, MissionInfo.GemQuota);
}
/**
 * @param {Mode_quota} %this
 * @param {Type} %object
 */
function Mode_quota::onGameState(%this, %object) {
	commandToClient(%object.client, 'SetGemQuota', $Game::GemCount, MissionInfo.GemQuota);
}
