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
	%this.setLastEggTime(-1);

	%this.missionType = "";
	%this.setMissionTypeBeganTime(0);
	%this.missionTypeDuration = -1;
	%this.currentGame = "";
	%this.setCurrentGameBeganTime(0);
	%this.currentGameDuration = -1;

	%this.receivedMbgWarning = false;

	// Global since stupid GuiCheckBoxCtrl can't access variables inside RtaSpeedrun object
	$RtaTimeEndsOnEgg = false;

	%this.smartHideSplits = true;
	if (%this.loadProgress()) {
		ASSERT("RTA Speedrun Recovery", "RTA Speedrun in-progress detected!\nResume the next level to continue the speedrun.");
		%this.setIsCrashRecoveryMode(true);
		%this.updateTimers();
	}
	%this.setIsValid(true);
}
RtaSpeedrun.schedule(100, create);


function RtaSpeedrun::onFrameAdvanceWithPause(%this, %timeDelta) {
	if (%this.isEnabled && !($Client::Loading || $Game::Loading || $Menu::Loading)) {
		%this.setTime(add64_int(%this.time, %timeDelta / getTimeScale()));
		%this.updateTimers();
	}
}

package RtaSpeedrunFrameAdvance {
	function onFrameAdvanceWithPause(%timeDelta) {
		Parent::onFrameAdvanceWithPause(%timeDelta);
		RtaSpeedrun.onFrameAdvanceWithPause(%timeDelta);
	}
};
activatePackage(RtaSpeedrunFrameAdvance);

function RtaSpeedrun::updateTimers(%this) {
	if (!%this.isEnabled && !%this.isDone) {
		if (%this.shouldStartRun || %this.isCrashRecoveryMode)
			%this.setTimerText(formatTimeHoursMs(%this.time));
		else
			%this.setTimerText("");
		return;
	}
	%showGame = %this.currentGameDuration > 0;
	%showCategory = %this.missionTypeDuration > 0;
	%lastTime = %this.lastSplitTime;
	%lastTimeIsEgg = false;
	if ($Pref::RtaShowEggSplits && %this.lastEggTime > %this.lastSplitTime) {
		%lastTime = %this.lastEggTime;
		%lastTimeIsEgg = true;
	}
	%showSplit = $pref::RtaShowAllSplits && %lastTime > 0;

	if (%this.smartHideSplits) {
		if (%this.isDone) {
			%showSplit = false;
			if (%this.missionTypeDuration == %this.time)
				%showCategory = false;
			if (%this.currentGameDuration == %this.time)
				%showGame = false;
		}
		if (%lastTime == %this.missionTypeDuration
			|| %lastTime == %this.currentGameDuration)
			%showSplit = false;
		if (%showCategory && %showGame && (%this.currentGameDuration == %this.missionTypeDuration)) {
			%showGame = false;
		}
	}

	%prevPrefThousandths = $pref::Thousandths; // Show the final time with ms always, for leaderboard fairness
	if (%this.isDone) {
		$pref::Thousandths = true;
		%text = formatTimeHoursMs(%this.time) SPC "Final Time";
		%this.prevFinalTime = %this.time;
	} else {
		%text = formatTimeHoursMs(%this.time);
	}
	if (%showGame) {
		$pref::Thousandths = true;
		%text = %text NL formatTimeHoursMs(%this.currentGameDuration) SPC "Final Game Time";
	}
	if (%showCategory) {
		$pref::Thousandths = true;
		%text = %text NL formatTimeHoursMs(%this.missionTypeDuration) SPC "Final Category Time";
	}
	$pref::Thousandths = %prevPrefThousandths;
	if (%showSplit) {
		%suffix = %lastTimeIsEgg ? "Egg Split" : "Split";
		%text = %text NL formatTimeHoursMs(%lastTime) SPC %suffix;
	}
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
	%this.setLastEggTime(-1);

	%this.missionType = "";
	%this.setMissionTypeBeganTime(0);
	%this.missionTypeDuration = -1;
	%this.currentGame = "";
	%this.setCurrentGameBeganTime(0);
	%this.currentGameDuration = -1;

	%this.updateTimers();
	PlayMissionGui.resetPlayButton();

	echo("An RTA speedrun will start when you enter a level, and end when you finish" SPC %this.endMission);
	echo("Good luck!");
}

function RtaSpeedrun::stop(%this) {
	%this.setShouldStartRun(false);
	%this.setIsEnabled(false);
	%this.setIsDone(false);
	%this.setIsCrashRecoveryMode(false);
	%this.updateTimers();
	%this.clearProgress();
	PlayMissionGui.resetPlayButton();
}

function RtaSpeedrun::setEnd(%this, %arg) {
	if (%arg $= "") {
		%this.endMissionInfo = PlayMissionGui.getMissionInfo();
	} else {
		%this.endMissionInfo = getMissionInfo(%arg);
	}
	%this.endMission = %this.endMissionInfo.file;
	echo("The last level of the RTA speedrun set to" SPC %this.endMission);

	if (!%this.receivedMbgWarning && (stripos(%this.endMission, "data/missions_mbg/") != -1 || stripos(%this.endMission, "data/lbmissions_mbg/") != -1)) {
		ASSERT("Warning", "You have selected a Marble Blast Gold level as the final level. In order for a run to be valid on speedrun.com/mbg, it can't be done in PQ, it must be done in vanilla MBG. Feel free to run it if you would like, just be aware that it will not be verified. If it's part of a larger speedrun with multiple games (e.g. a colored name speedrun) which you plan on ending in MBG, then feel free to ignore this warning.");
		%this.receivedMbgWarning = true;
	}

	PlayMissionGui.resetPlayButton();
}

function RtaSpeedrun::missionStarted(%this) {
	RTAAS_setCurrentMission($Server::MissionFile);
	if (%this.isCrashRecoveryMode) {
		echo("Crash recovery run resumed!");
		%this.setIsCrashRecoveryMode(false);
		%this.setIsEnabled(true);
	}
	if (%this.shouldStartRun && !%this.isEnabled) {
		echo("Speedrun mode began timing!");
		%this.setIsEnabled(true);
		%this.setShouldStartRun(false);
	}
	if (!%this.isEnabled)
		return;
	%this.setLastSplitTime(-1);
	%this.setLastEggTime(-1);
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
	%this.saveProgress();
}

function RtaSpeedrun::missionEnded(%this) {
	if (!%this.isEnabled)
		return;
	if (!$RtaTimeEndsOnEgg && %this.endMission $= $Server::MissionFile) {
		echo("Just finished the end level! Speedrun mode over");
		echo("Final time:" SPC %this.time);
		%this.setIsEnabled(false);
		%this.setIsDone(true);
		%this.clearProgress();
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
	%this.saveProgress();
}

function RtaSpeedrun::missionRestarted(%this) {
	if (!%this.isEnabled)
		return;
	%this.setLastSplitTime(-1);
	%this.setLastEggTime(-1);
	%this.missionTypeDuration = -1;
	%this.currentGameDuration = -1;
	%this.updateTimers();
	%this.saveProgress();
}

function RtaSpeedrun::eggCollected(%this) {
	if (!%this.isEnabled)
		return;
	%this.setLastEggTime(%this.time);
	if ($RtaTimeEndsOnEgg && %this.endMission $= $Server::MissionFile) {
		echo("Just collected the last egg! Speedrun mode over");
		echo("Final time:" SPC %this.time);
		%this.setIsEnabled(false);
		%this.setIsDone(true);
		%this.clearProgress();
	}
	%this.updateTimers();
	%this.saveProgress();
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

function RtaSpeedrun::saveProgress(%this) {
	if (%this.isCrashRecoveryMode)
		return;
	if (!%this.isEnabled) {
		%this.clearProgress();
		return;
	}
	$RtaProgress::time = %this.time;
	$RtaProgress::endMission = %this.endMission;
	$RtaProgress::missionType = %this.missionType;
	$RtaProgress::missionTypeBeganTime = %this.missionTypeBeganTime;
	$RtaProgress::currentGame = %this.currentGame;
	$RtaProgress::currentGameBeganTime = %this.currentGameBeganTime;
	$RtaProgress::timeEndsOnEgg = $RtaTimeEndsOnEgg;
	export("$RtaProgress::*", "~/client/rtaProgress.cs", False);
}

function RtaSpeedrun::loadProgress(%this) {
	%progressFile = "platinum/client/rtaProgress.cs";
	if (!isFile(%progressFile)) {
		return false;
	}
	exec(%progressFile);
	%this.setTime($RtaProgress::time);
	%this.setEnd($RtaProgress::endMission);
	%this.missionType = $RtaProgress::missionType;
	%this.missionTypeBeganTime = $RtaProgress::missionTypeBeganTime;
	%this.currentGame = $RtaProgress::currentGame;
	%this.currentGameBeganTime = $RtaProgress::currentGameBeganTime;
	$RtaTimeEndsOnEgg = $RtaProgress::timeEndsOnEgg;
	echo("Loaded" SPC %progressFile @ ", RTA Speedrun in progress!!!");
	return true;
}

function RtaSpeedrun::clearProgress(%this) {
	%progressFile = "platinum/client/rtaProgress.cs";
	if (isFile(%progressFile))
		deleteFile(%progressFile);
	if (isFile(%progressFile @ ".dso"))
		deleteFile(%progressFile @ ".dso");
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
function RtaSpeedrun::setIsCrashRecoveryMode(%this, %isCrashRecoveryMode) {
	%this.isCrashRecoveryMode = %isCrashRecoveryMode;
	RTAAS_setIsCrashRecoveryMode(%this.isCrashRecoveryMode);
}
function RtaSpeedrun::setTime(%this, %time) {
	%this.time = %time;
	RTAAS_setTime(%this.time);
}
function RtaSpeedrun::setLastSplitTime(%this, %time) {
	%this.lastSplitTime = %time;
	RTAAS_setLastSplitTime(%this.lastSplitTime);
}
function RtaSpeedrun::setLastEggTime(%this, %time) {
	%this.lastEggTime = %time;
	RTAAS_setLastEggTime(%this.lastEggTime);
}
function RtaSpeedrun::setMissionTypeBeganTime(%this, %time) {
	%this.missionTypeBeganTime = %time;
	RTAAS_setMissionTypeBeganTime(%this.missionTypeBeganTime);
}
function RtaSpeedrun::setCurrentGameBeganTime(%this, %time) {
	%this.currentGameBeganTime = %time;
	RTAAS_setCurrentGameBeganTime(%this.currentGameBeganTime);
}
