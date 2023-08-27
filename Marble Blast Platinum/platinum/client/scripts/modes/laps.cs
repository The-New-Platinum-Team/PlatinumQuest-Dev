//-----------------------------------------------------------------------------
// Laps mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_laps) {
	class = "ModeInfo_laps";
	superclass = "ModeInfo";

	identifier = "laps";
	file = "laps";

	name = "Laps";
	desc = "Complete laps around the level to finish!";
});


function ClientMode_laps::onLoad(%this) {
	%this.registerCallback("onShowPlayGui");
	%this.registerCallback("updatePlayMission");
	%this.registerCallback("updateEndGame");
	%this.registerCallback("getScoreFields");
	%this.registerCallback("onMissionReset");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_laps::onShowPlayGui(%this) {
	PGLapsCounter.setVisible(1);
}
function ClientMode_laps::getBestLapTime(%this) {
	%info = PlayMissionGui.getMissionInfo();
	if (lb()) {
		//Get the best lap time from the lbs
		%best = 5999999;
		%cache = PlayMissionGui.personalScoreCache[PlayMissionGui.getMissionInfo().id];
		if (isObject(%cache)) {
			%lapCache = %cache.bestLap;
			if (isObject(%lapCache)) {
				%best = %lapCache.time;
			}
		} else {
			return "";
		}
	} else {
		%best = ($pref::LapsBestTime[%info.file] $= "" ? 5999999 : $pref::LapsBestTime[%info.file]);
	}

	return %best;
}
function ClientMode_laps::updatePlayMission(%this, %location) {
	switch$ (%location) {
	case "sp":
		%text = PM_MissionScoresInfo.getText();

		if (!Unlock::canPlayMission(PlayMissionGui.getMissionInfo()))
			return;

		%best = %this.getBestLapTime();
		if (%best $= "")
			return;

		%bpos = strPos(%text, "<bitmap:");
		if (%bpos != -1) {
			%text = getSubStr(%text, 0, %bpos) @ "Best Lap:<just:right>" @ formatTime(%best) @ "\n<just:left>" @ getSubStr(%text, %bpos, strlen(%text));
		} else {
			%text = %text @ "<just:left>Best Lap:<just:right>" @ formatTime(%best);
		}
		PM_MissionScoresInfo.setText(%text);
	}
}
function ClientMode_laps::updateEndGame(%this) {
	%info = PlayMissionGui.getMissionInfo();
	if ($Game::BestCurrentLap >= 0) {
		%text = "<font:26><just:left>Best Lap:<just:right>" @ formatTime($Game::BestCurrentLap);
	} else {
		%text = "<font:26><just:left>Best Lap:<just:right>Nothing???";
	}

	EG_TopTimesText.addText(%text, true);
}
function ClientMode_laps::onMissionReset(%this) {
	$Game::BestCurrentLap = -1;
}
function ClientMode_laps::getScoreFields(%this) {
	//Give them our best lap if we have one... (we should, right?)
	if ($Game::BestCurrentLap >= 0)
		return "&lapTime=" @ removeScientificNotation($Game::BestCurrentLap);
	return "";
}

function clientCmdSetLapsComplete(%count) {
	PlayGui.setLapsComplete(%count);
}

function clientCmdSetLapsTotal(%total) {
	PlayGui.setLapsTotal(%total);
}

function clientCmdLapTime(%number, %time) {
	%message = "";
	%best = ClientMode_laps.getBestLapTime();
	if (%time < %best) {
		//If it's a *new* best and not just the only best
		if ($pref::LapsBestTime[$Client::MissionFile] !$= "" || %number > 2) {
			%message = "New best lap time! ";
		}

		//Best lap
		$pref::LapsBestTime[$Client::MissionFile] = %time;
		savePrefs();
	}

	%message = %message @ "Lap " @ (%number - 1) @ "\'s Time: " @ formatTime(%time);
	addBubbleLine(%message, false, 5000);

	//Save our best lap time for this session
	if ($Game::BestCurrentLap >= 0) {
		$Game::BestCurrentLap = min($Game::BestCurrentLap, %time);
	} else {
		$Game::BestCurrentLap = %time;
	}
}
