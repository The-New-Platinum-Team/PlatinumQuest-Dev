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

function RtaSpeedrun::create(%this) {
	%this.shouldStartRun = false;
	%this.endMission = "";

	%this.isEnabled = false;
	%this.isDone = false;
	%this.time = 0;

	%this.pauseStartedTime = -1;
	%this.lastSplitTime = -1;

	%this.missionType = "";
	%this.missionTypeBegan = 0;
	%this.missionTypeDuration = -1;
	%this.currentGame = "";
	%this.currentGameBegan = 0;
	%this.currentGameDuration = -1;

	%this.smartHideSplits = true;
}
RtaSpeedrun.create();

function RtaSpeedrun::onFrameAdvance(%this, %timeDelta) {
	if (%this.isEnabled && !($Client::Loading || $Game::Loading || $Menu::Loading)) {
		%this.time = add64_int(%this.time, %timeDelta / getTimeScale());
		%this.updateTimers();
	}
}

package RtaSpeedrunFrameAdvance {
	function onFrameAdvance(%timeDelta) {
		Parent::onFrameAdvance(%timeDelta);
		RtaSpeedrun.onFrameAdvance(%timeDelta);
	}
};
activatePackage(RtaSpeedrunFrameAdvance);

function RtaSpeedrun::updateTimers(%this) {
	if (!%this.isEnabled && !%this.isDone) {
		%this.setTimerText("");
		return;
	}
	%showGame = %this.currentGameDuration > 0;
	%showCategory = %this.missionTypeDuration > 0;
	%showSplit = %this.lastSplitTime > 0;

	if (%this.smartHideSplits) {
		if (%this.isDone) {
			%showSplit = false;
			if (%this.missionTypeDuration == %this.time)
				%showCategory = false;
			if (%this.currentGameDuration == %this.time)
				%showGame = false;
		}
		if (%this.lastSplitTime == %this.missionTypeDuration
			|| %this.lastSplitTime == %this.currentGameDuration)
			%showSplit = false;
		if (%this.currentGameDuration == %this.missionTypeDuration) {
			if (%this.isDone && %this.currentGameBegan == 0)
				%showGame = false;
			else
				%showCategory = false;
		}
	}

	%text = formatTimeHoursMs(%this.time);
	if (%this.isDone)
		%text = %text SPC "Final Time";
	if (%showGame)
		%text = %text NL formatTimeHoursMs(%this.currentGameDuration) SPC "Game";
	if (%showCategory)
		%text = %text NL formatTimeHoursMs(%this.missionTypeDuration) SPC "Category";
	if (%showSplit)
		%text = %text NL formatTimeHoursMs(%this.lastSplitTime) SPC "Split";
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

	%this.pauseStartedTime = -1;
	%this.lastSplitTime = -1;

	%this.missionType = "";
	%this.missionTypeBegan = 0;
	%this.missionTypeDuration = -1;
	%this.currentGame = "";
	%this.currentGameBegan = 0;
	%this.currentGameDuration = -1;

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
	%this.currentGameDuration = -1;
	if ($MissionType !$= %this.missionType) {
		%this.missionType = $MissionType;
		%this.missionTypeBegan = %this.time;
	}
	if ($CurrentGame !$= %this.currentGame) {
		%this.currentGame = $CurrentGame;
		%this.currentGameBegan = %this.time;
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
	%isEndOfCurrentGame = false;
	if (%this.isDone) {
		%isEndOfMissionType = true;
		%isEndOfCurrentGame = true;
	} else {
		%nextMission = EndGameDlg.getNextLevel();
		if (!isObject(getRecord(%nextMission, 0))) {
			%isEndOfMissionType = true;
			%isEndOfCurrentGame = true;
		} else {
			%nextMissionType = getRecord(%nextMission, 2);
			if (%nextMissionType !$= $MissionType)
				%isEndOfMissionType = true;
		}
	}
	%this.lastSplitTime = %this.time;
	if (%isEndOfMissionType)
		%this.missionTypeDuration = sub64_int(%this.time, %this.missionTypeBegan);
	if (%isEndOfCurrentGame)
		%this.currentGameDuration = sub64_int(%this.time, %this.currentGameBegan);
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
