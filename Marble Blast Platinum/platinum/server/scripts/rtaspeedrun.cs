//-----------------------------------------------------------------------------
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

new SimObject(RtaSpeedrun);

RtaSpeedrun.shouldStartRun = false;
RtaSpeedrun.endMission = "";

RtaSpeedrun.isEnabled = false;
RtaSpeedrun.isDone = false;
RtaSpeedrun.time = 0;

RtaSpeedrun.currentMissionType = "";
RtaSpeedrun.currentMissionTypeBegan = 0;

RtaSpeedrun.lastSplitTime = -1;
RtaSpeedrun.missionTypeDuration = -1;
RtaSpeedrun.pauseStartedTime = -1;

package RtaSpeedrunFrameAdvance {
	function onFrameAdvance(%timeDelta) {
		Parent::onFrameAdvance(%timeDelta);
		if (RtaSpeedrun.isEnabled && !($Client::Loading || $Game::Loading || $Menu::Loading)) {
			RtaSpeedrun.time = add64_int(RtaSpeedrun.time, %timeDelta / getTimeScale());
			RtaSpeedrun::updateTimers();
		}
	}
};
activatePackage(RtaSpeedrunFrameAdvance);

function RtaSpeedrun::updateTimers(%this) {
	%text = formatTimeHoursMs(RtaSpeedrun.time);
	if (RtaSpeedrun.isDone)
		%text = %text SPC "Final Time";
	if (RtaSpeedrun.lastSplitTime > 0)
		%text = %text NL formatTimeHoursMs(RtaSpeedrun.lastSplitTime) SPC "Split";
	if (RtaSpeedrun.missionTypeDuration > 0)
		%text = %text NL formatTimeHoursMs(RtaSpeedrun.missionTypeDuration) SPC "Category";
	PlayGui.updateRtaSpeedrunTimer(%text);
	PlayMissionGui.updateRtaSpeedrunTimer(%text);
	LoadingGui.updateRtaSpeedrunTimer(%text);
}

function RtaSpeedrun::start(%this) {
	RtaSpeedrun.shouldStartRun = true;
	RtaSpeedrun.isEnabled = false;
	RtaSpeedrun.isDone = false;
	RtaSpeedrun.time = 0;

	RtaSpeedrun.currentMissionType = "";
	RtaSpeedrun.lastSplitTime = -1;
	RtaSpeedrun.missionTypeDuration = -1;
	RtaSpeedrun.pauseStartedTime = -1;

	RtaSpeedrun::updateTimers();

	echo("An RTA speedrun will start when you enter a level, and end when you finish" SPC RtaSpeedrun.endMission);
	echo("Good luck!");
}

function RtaSpeedrun::stop(%this) {
	RtaSpeedrun.isEnabled = false;
	RtaSpeedrun.isDone = false;
	RtaSpeedrun.time = 0;
	RtaSpeedrun::updateTimers();
}

function RtaSpeedrun::setEnd(%this) {
	RtaSpeedrun.endMission = PlayMissionGui.getMissionInfo().file;
	echo("The last level of the RTA speedrun set to" SPC RtaSpeedrun.endMission);
}

function RtaSpeedrun::missionStarted(%this) {
	if (RtaSpeedrun.shouldStartRun && !RtaSpeedrun.isEnabled) {
		echo("Speedrun mode began timing!");
		RtaSpeedrun.isEnabled = true;
		RtaSpeedrun.shouldStartRun = false;
	}
	if (!RtaSpeedrun.isEnabled)
		return;
	RtaSpeedrun.lastSplitTime = -1;
	RtaSpeedrun.missionTypeDuration = -1;
	if ($MissionType !$= RtaSpeedrun.currentMissionType) {
		RtaSpeedrun.currentMissionType = $MissionType;
		RtaSpeedrun.currentMissionTypeBegan = RtaSpeedrun.time;
	}
	RtaSpeedrun::updateTimers();
}

function RtaSpeedrun::missionEnded(%this) {
	if (!RtaSpeedrun.isEnabled)
		return;
	if (RtaSpeedrun.endMission $= $Server::MissionFile) {
		echo("Just finished the end level! Speedrun mode over");
		echo("Final time:" SPC RtaSpeedrun.time);
		RtaSpeedrun.isEnabled = false;
		RtaSpeedrun.isDone = true;
	}
	%isEndOfMissionType = false;
	%nextMission = EndGameDlg.getNextLevel();
	if (!isObject(getRecord(%nextMission, 0))) {
		%isEndOfMissionType = true;
	} else {
		%nextMissionType = getRecord(%nextMission, 2);
		if (%nextMissionType !$= $MissionType)
			%isEndOfMissionType = true;
	}
	RtaSpeedrun.lastSplitTime = RtaSpeedrun.time;
	if (RtaSpeedrun.isDone && RtaSpeedrun.currentMissionTypeBegan > 0)
		%isEndOfMissionType = true;
	if (%isEndOfMissionType && (!RtaSpeedrun.isDone || RtaSpeedrun.currentMissionTypeBegan > 0))
		RtaSpeedrun.missionTypeDuration = sub64_int(RtaSpeedrun.time, RtaSpeedrun.currentMissionTypeBegan);
	RtaSpeedrun::updateTimers();
}

function RtaSpeedrun::pauseGame(%this) {
	if (!RtaSpeedrun.isEnabled)
		return;
	RtaSpeedrun.pauseStartedTime = getRealTime();
}

function RtaSpeedrun::unpauseGame(%this) {
	if (!RtaSpeedrun.isEnabled)
		return;
	if (RtaSpeedrun.pauseStartedTime < 0)
		return;
	%currentTime = getRealTime();
	%diff = sub64_int(%currentTime, RtaSpeedrun.pauseStartedTime);
	RtaSpeedrun.time = add64_int(RtaSpeedrun.time, %diff);
	RtaSpeedrun.pauseStartedTime = -1;
}
