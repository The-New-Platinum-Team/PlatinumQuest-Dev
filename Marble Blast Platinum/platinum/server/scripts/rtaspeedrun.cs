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
	%this.setIsValid(false);
	%this.setShouldStartRun(false);
	%this.endMission = "";

	%this.setIsEnabled(false);
	%this.setIsDone(false);
	%this.setTime(0);

	%this.pauseStartedTime = -1;
	%this.setLastSplitTime(-1);

	%this.missionType = "";
	%this.setMissionTypeBeganTime(0);
	%this.missionTypeDuration = -1;
	%this.currentGame = "";
	%this.setCurrentGameBeganTime(0);
	%this.currentGameDuration = -1;

	%this.smartHideSplits = true;
	%this.setIsValid(true);
}
RtaSpeedrun.create();

function RtaSpeedrun::onFrameAdvance(%this, %timeDelta) {
	if (%this.isEnabled && !($Client::Loading || $Game::Loading || $Menu::Loading)) {
		%this.setTime(add64_int(%this.time, %timeDelta / getTimeScale()));
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
		if (%this.shouldStartRun)
			%this.setTimerText(formatTimeHoursMs(%this.time));
		else
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
		if (%showCategory && %showGame && (%this.currentGameDuration == %this.missionTypeDuration)) {
			%showGame = false;
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
	%this.setShouldStartRun(true);
	%this.setIsEnabled(false);
	%this.setIsDone(false);
	%this.setTime(0);

	%this.pauseStartedTime = -1;
	%this.setLastSplitTime(-1);

	%this.missionType = "";
	%this.setMissionTypeBeganTime(0);
	%this.missionTypeDuration = -1;
	%this.currentGame = "";
	%this.setCurrentGameBeganTime(0);
	%this.currentGameDuration = -1;

	%this.updateTimers();

	RTAAS_setIsPauseScreenOpen(false);

	echo("An RTA speedrun will start when you enter a level, and end when you finish" SPC %this.endMission);
	echo("Good luck!");
}

function RtaSpeedrun::stop(%this) {
	%this.setShouldStartRun(false);
	%this.setIsEnabled(false);
	%this.setIsDone(false);
	%this.updateTimers();
}

function RtaSpeedrun::setEnd(%this) {
	%this.endMission = PlayMissionGui.getMissionInfo().file;
	echo("The last level of the RTA speedrun set to" SPC %this.endMission);
}

function RtaSpeedrun::missionStarted(%this) {
	RTAAS_setCurrentMission($Server::MissionFile);
	if (%this.shouldStartRun && !%this.isEnabled) {
		echo("Speedrun mode began timing!");
		%this.setIsEnabled(true);
		%this.setShouldStartRun(false);
	}
	if (!%this.isEnabled)
		return;
	%this.setLastSplitTime(-1);
	%this.missionTypeDuration = -1;
	%this.currentGameDuration = -1;
	if ($MissionType !$= %this.missionType) {
		%this.missionType = $MissionType;
		%this.setMissionTypeBeganTime(%this.time);
	}
	if ($CurrentGame !$= %this.currentGame) {
		%this.currentGame = $CurrentGame;
		%this.setCurrentGameBeganTime(%this.time);
	}
	%this.updateTimers();
}

function RtaSpeedrun::missionEnded(%this) {
	if (!%this.isEnabled)
		return;
	if (%this.endMission $= $Server::MissionFile) {
		echo("Just finished the end level! Speedrun mode over");
		echo("Final time:" SPC %this.time);
		%this.setIsEnabled(false);
		%this.setIsDone(true);
	}
	%isEndOfMissionType = false;
	%isEndOfCurrentGame = false;
	if (%this.isDone) {
		%isEndOfMissionType = true;
		%isEndOfCurrentGame = true;
	} else {
		%nextMission = EndGameDlg.getNextLevel();
		if (!isObject(getRecord(%nextMission, 0)) || %this.isGameEndSpecialCase($Server::MissionFile)) {
			%isEndOfMissionType = true;
			%isEndOfCurrentGame = true;
		} else {
			%nextMissionType = getRecord(%nextMission, 2);
			if (%nextMissionType !$= $MissionType)
				%isEndOfMissionType = true;
		}
	}
	%this.setLastSplitTime(%this.time);
	if (%isEndOfMissionType)
		%this.missionTypeDuration = sub64_int(%this.time, %this.missionTypeBeganTime);
	if (%isEndOfCurrentGame)
		%this.currentGameDuration = sub64_int(%this.time, %this.currentGameBeganTime);
	%this.updateTimers();
}

function RtaSpeedrun::pauseGame(%this) {
	RTAAS_setIsPauseScreenOpen(true);
	if (!%this.isEnabled)
		return;
	%this.pauseStartedTime = getRealTime();
}

function RtaSpeedrun::unpauseGame(%this) {
	RTAAS_setIsPauseScreenOpen(false);
	if (!%this.isEnabled)
		return;
	if (%this.pauseStartedTime < 0)
		return;
	%currentTime = getRealTime();
	%diff = sub64_int(%currentTime, %this.pauseStartedTime);
	%this.setTime(add64_int(%this.time, %diff));
	%this.pauseStartedTime = -1;
}

function RtaSpeedrun::isGameEndSpecialCase(%this, %mission) {
	// Some games/categories have multiple valid places to represent the "end" of the speedrun/ We want to account for
	// all of them, and even let the same run count towards each of the categories.
	switch$ (%mission) {
		case "platinum/data/missions_mbg/advanced/KingOfTheMountain.mis": return true;
		case "platinum/data/missions_mbu/advanced/schadenfreude_ultra.mis": return true;
		case "platinum/data/lbmissions_mbu/advanced/schadenfreude_ultra.mis": return true;
		case "platinum/data/missions_mbu/advanced/hypercube_ultra.mis": return true;
		case "platinum/data/missions_mbp/expert/BattlecubeFinale.mis": return true;
		case "platinum/data/missions_pq/expert/ManicBounce.mcs": return true;
		case "platinum/data/lbmissions_pq/expert/ManicBounce.mcs": return true;
		case "platinum/data/missions_pq/bonus/Puzzle11Nightmare.mcs": return true;
		case "platinum/data/lbmissions_pq/bonus/Puzzle11Nightmare.mcs": return true;
	}
	return false;
}

// Setters for most properties, to update the RTAAutosplitter plugin's values as well
function RtaSpeedrun::setIsValid(%this, %isValid) {
	%this.isValid = %isValid;
	RTAAS_setIsValid(%this.isValid);
}
function RtaSpeedrun::setIsEnabled(%this, %isEnabled) {
	%this.isEnabled = %isEnabled;
	RTAAS_setIsEnabled(%this.isEnabled);
}
function RtaSpeedrun::setIsDone(%this, %isDone) {
	%this.isDone = %isDone;
	RTAAS_setIsDone(%this.isDone);
}
function RtaSpeedrun::setShouldStartRun(%this, %shouldStartRun) {
	%this.shouldStartRun = %shouldStartRun;
	RTAAS_setShouldStartRun(%this.shouldStartRun);
}
function RtaSpeedrun::setTime(%this, %time) {
	%this.time = %time;
	RTAAS_setTime(%this.time);
}
function RtaSpeedrun::setLastSplitTime(%this, %time) {
	%this.lastSplitTime = %time;
	RTAAS_setLastSplitTime(%this.lastSplitTime);
}
function RtaSpeedrun::setMissionTypeBeganTime(%this, %time) {
	%this.missionTypeBeganTime = %time;
	RTAAS_setMissionTypeBeganTime(%this.missionTypeBeganTime);
}
function RtaSpeedrun::setCurrentGameBeganTime(%this, %time) {
	%this.currentGameBeganTime = %time;
	RTAAS_setCurrentGameBeganTime(%this.currentGameBeganTime);
}
