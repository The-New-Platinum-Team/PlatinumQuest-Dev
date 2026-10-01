//-----------------------------------------------------------------------------
// Consistency Mode
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
function Mode_consistency::onLoad(%this) {
	echo("[Mode" SPC %this.name @ "]: Loaded!");
	%this.registerCallback("onFrameAdvance");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onRespawnOnCheckpoint");
}
/**
 * @param {Mode_consistency} %this
 */
function Mode_consistency::onFrameAdvance(%this, %delta) {
	//Check for grace period
	if ($Time::CurrentTime < MissionInfo.gracePeriod)
		return;
	if ((Mode::callback("timeMultiplier", 1) < 0) && (Mode::callback("getStartTime", 0) - $Time::CurrentTime) < MissionInfo.gracePeriod)
		return;
	if ($Game::Finished || $Editor::Opened)
		return;

	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!isObject(%client.player))
			continue;

		//Don't cancel this if we've already lost
		if (%client.consistencyFailed)
			continue;

		//Grace period for respawning
		if ((($Sim::Time - %client.lastSpawnTime) * 1000) < MissionInfo.gracePeriod)
			continue;

		//How fast are they going?
		%vel = %client.player.getVelocity();
		%speed = VectorLen(%vel);

		//How long do we have to get back up to speed
		%delay = (MissionInfo.PenaltyDelay ? MissionInfo.PenaltyDelay : 2000);

		if (%speed < MissionInfo.MinimumSpeed) {
			//Don't scedule the lose considion if it's already running
			if (!%client.consistencyFailing) {
				//TODO: Sound for going too slow? Images too
				%client.consistencyFailing = true;
				%client.consistencyFailSch = %client.schedule(%delay, "onConsistencyFail");
				%client.addBubbleLine("Too slow!", false, 1000);
			}
		} else {
			if (%client.consistencyFailing) {
				%client.consistencyFailing = false;
				cancel(%client.consistencyFailSch);
			}
		}
	}
}
/**
 * @param {Mode_consistency} %this
 * @param {Type} %object
 */
function Mode_consistency::onRespawnPlayer(%this, %object) {
	//Reset everything
	%object.client.consistencyFailing = false;
	%object.client.consistencyFailed = false;
	cancel(%object.client.consistencyFailSch);
}
/**
 * @param {Mode_consistency} %this
 * @param {Type} %object
 */
function Mode_consistency::onRespawnOnCheckpoint(%this, %object) {
	//Reset everything
	%object.client.consistencyFailing = false;
	%object.client.consistencyFailed = false;
	cancel(%object.client.consistencyFailSch);
}
/**
 * @param {GameConnection} %this
 */
function GameConnection::onConsistencyFail(%this) {
	if ($Editor::Opened) {
		return;
	}

	//TODO: Images and stuff
	if ($Game::isMode["hunt"] || $Game::isMode["huntMadness"]) {
		//Restart it all
		restartLevel();
	} else {
		%this.onOutOfBounds(true);
	}
	%this.consistencyFailed = true;
	%this.addBubbleLine("Consistency failed!", false);
}
