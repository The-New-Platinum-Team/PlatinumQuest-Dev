//-----------------------------------------------------------------------------
// Elimination Mode
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
function Mode_elimination::onLoad(%this) {
	%this.registerCallback("onPlayerJoin");
	%this.registerCallback("onClientEnterGame");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("getStartTime");
	%this.registerCallback("onTimeExpire");
	%this.registerCallback("shouldPickupGem");
	%this.registerCallback("shouldSetSpectate");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
/**
 * @param {Mode_elimination} %this
 * @param {Type} %object
 */
function Mode_elimination::onPlayerJoin(%this, %object) {
	%object.client.eliminated = true;
}
/**
 * @param {Mode_elimination} %this
 * @param {Type} %object
 */
function Mode_elimination::onClientEnterGame(%this, %object) {
	if (%object.client.eliminated) {
		%object.client.setToggleCamera(true);
		%object.client.deletePlayer();
	}
}
/**
 * @param {Mode_elimination} %this
 */
function Mode_elimination::onMissionReset(%this, %object) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.eliminated = %client.spectating;
	}
}
/**
 * @param {Mode_elimination} %this
 */
function Mode_elimination::shouldRestartOnOOB(%this, %object) {
	return false;
}
/**
 * @param {Mode_elimination} %this
 * @param {Type} %object
 */
function Mode_elimination::shouldSetSpectate(%this, %object) {
	return !%object.client.eliminated;
}
/**
 * @param {Mode_elimination} %this
 */
function Mode_elimination::getStartTime(%this, %object) {
	return MissionInfo.eliminationTime $= "" ? 60000 : MissionInfo.eliminationTime;
}
/**
 * @param {Mode_elimination} %this
 */
function Mode_elimination::onTimeExpire(%this, %object) {
	//Find the player with the least points
	%count = ClientGroup.getCount();
	%playing = 0;
	%least = -1;
	%tie = false;

	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);

		if (%client.eliminated)
			continue;

		%playing ++;
		if (%least == -1 || %client.gemCount < %least.gemCount) {
			%least = %client;
			%tie = false;
		} else if (%least != -1 && %client.gemCount == %least.gemCount) {
			%tie = true;
		}
	}
	//Let people know
	if (%tie) {
		if (!%this.tieMode) {
			serverSendChat("<color:ff6666>There\'s a tie! Sudden death!");
			%this.tieMode = true;
		}
	} else {
		%least.setToggleCamera(true);
		%least.deletePlayer();
//		%least.setSpectating(true);
		serverSendChat("<color:ff6666>" @ %least.getDisplayName() SPC "has been eliminated!");
		%this.tieMode = false;
		%least.eliminated = true;
	}

	//If there's no players left, then the game ends
	if (%playing <= 2) {
		return true;
	}

	if (!%this.tieMode) {
		//Reset everyone's time
		%count = ClientGroup.getCount();
		%time = %this.getStartTime();
		for (%i = 0; %i < %count; %i ++) {
			%client = ClientGroup.getObject(%i);

			%client.stopTimer();
			%client.setTime(%time);
			%client.startTimer();
		}
		PlayGui.setTime(%time);
	}
	return false;
}
