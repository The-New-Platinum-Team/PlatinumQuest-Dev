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

new ScriptObject(RtaSpeedrun) {
	class = "RtaSpeedrun";
};

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
			RtaSpeedrun.updateTimers();
		}
	}
};
activatePackage(RtaSpeedrunFrameAdvance);

function RtaSpeedrun::updateTimers(%this) {
	%text = formatTimeHoursMs(%this.time);
	if (%this.isDone)
		%text = %text SPC "Final Time";
	if (%this.lastSplitTime > 0)
		%text = %text NL formatTimeHoursMs(%this.lastSplitTime) SPC "Split";
	if (%this.missionTypeDuration > 0)
		%text = %text NL formatTimeHoursMs(%this.missionTypeDuration) SPC "Category";
	%this.setTimerText(%text);
}

function RtaSpeedrun::setTimerText(%this, %text) {
	PlayGui.updateRtaSpeedrunTimer(%text);
	PlayMissionGui.updateRtaSpeedrunTimer(%text);
	LoadingGui.updateRtaSpeedrunTimer(%text);
}

function RtaSpeedrun::start(%this) {
	%this.shouldStartRun = true;
	%this.isEnabled = false;
	%this.isDone = false;
	%this.time = 0;

	%this.currentMissionType = "";
	%this.lastSplitTime = -1;
	%this.missionTypeDuration = -1;
	%this.pauseStartedTime = -1;

	%this.updateTimers();

	echo("An RTA speedrun will start when you enter a level, and end when you finish" SPC %this.endMission);
	echo("Good luck!");
}

function RtaSpeedrun::stop(%this) {
	%this.isEnabled = false;
	%this.isDone = false;
	%this.time = 0;
	%this.updateTimers();
}

function RtaSpeedrun::setEnd(%this) {
	%this.endMission = PlayMissionGui.getMissionInfo().file;
	echo("The last level of the RTA speedrun set to" SPC %this.endMission);
}

function RtaSpeedrun::missionStarted(%this) {
	if (%this.shouldStartRun && !%this.isEnabled) {
		echo("Speedrun mode began timing!");
		%this.isEnabled = true;
		%this.shouldStartRun = false;
	}
	if (!%this.isEnabled)
		return;
	%this.lastSplitTime = -1;
	%this.missionTypeDuration = -1;
	if ($MissionType !$= %this.currentMissionType) {
		%this.currentMissionType = $MissionType;
		%this.currentMissionTypeBegan = %this.time;
	}
	%this.updateTimers();
}

function RtaSpeedrun::missionEnded(%this) {
	if (!%this.isEnabled)
		return;
	if (%this.endMission $= $Server::MissionFile) {
		echo("Just finished the end level! Speedrun mode over");
		echo("Final time:" SPC %this.time);
		%this.isEnabled = false;
		%this.isDone = true;
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
	%this.lastSplitTime = %this.time;
	if (%this.isDone && %this.currentMissionTypeBegan > 0)
		%isEndOfMissionType = true;
	if (%isEndOfMissionType && (!%this.isDone || %this.currentMissionTypeBegan > 0))
		%this.missionTypeDuration = sub64_int(%this.time, %this.currentMissionTypeBegan);
	%this.updateTimers();
}

function RtaSpeedrun::pauseGame(%this) {
	if (!%this.isEnabled)
		return;
	%this.pauseStartedTime = getRealTime();
}

function RtaSpeedrun::unpauseGame(%this) {
	if (!%this.isEnabled)
		return;
	if (%this.pauseStartedTime < 0)
		return;
	%currentTime = getRealTime();
	%diff = sub64_int(%currentTime, %this.pauseStartedTime);
	%this.time = add64_int(%this.time, %diff);
	%this.pauseStartedTime = -1;
}
