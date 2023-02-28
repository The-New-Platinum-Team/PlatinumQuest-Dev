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

$RtaSpeedrun::IsEnabled = false;
$RtaSpeedrun::EndMission = "";

$RtaSpeedrun::IsTiming = false;
$RtaSpeedrun::IsDone = false;
$RtaSpeedrun::Time = 0;

$RtaSpeedrun::CurrentMissionType = "";
$RtaSpeedrun::CurrentMissionTypeBegan = 0;

$RtaSpeedrun::LastSplitTime = -1;
$RtaSpeedrun::MissionTypeDuration = -1;

package rtaSpeedrunFrameAdvance {
	function onFrameAdvance(%timeDelta) {
		Parent::onFrameAdvance(%timeDelta);
		if ($RtaSpeedrun::IsTiming && !($Client::Loading || $Game::Loading || $Menu::Loading)) {
			$RtaSpeedrun::Time = add64_int($RtaSpeedrun::Time, %timeDelta / getTimeScale());
			RtaSpeedrunUpdateTimers();
		}
	}
};
activatePackage(rtaSpeedrunFrameAdvance);

function RtaSpeedrunUpdateTimers() {
	%text = formatTimeHoursMs($RtaSpeedrun::Time);
	if ($RtaSpeedrun::IsDone)
		%text = %text SPC "Final Time";
	if ($RtaSpeedrun::LastSplitTime > 0)
		%text = %text NL formatTimeHoursMs($RtaSpeedrun::LastSplitTime) SPC "Split";
	if ($RtaSpeedrun::MissionTypeDuration > 0)
		%text = %text NL formatTimeHoursMs($RtaSpeedrun::MissionTypeDuration) SPC "Category";
	PlayGui.updateRtaSpeedrunTimer(%text);
	PlayMissionGui.updateRtaSpeedrunTimer(%text);
	LoadingGui.updateRtaSpeedrunTimer(%text);
}

function RtaSpeedrunStart() {
	$RtaSpeedrun::IsEnabled = true;
	$RtaSpeedrun::IsTiming = false;
	$RtaSpeedrun::IsDone = false;
	$RtaSpeedrun::Time = 0;

	$RtaSpeedrun::CurrentMissionType = "";
	$RtaSpeedrun::LastSplitTime = -1;
	$RtaSpeedrun::MissionTypeDuration = -1;

	RtaSpeedrunUpdateTimers();

	echo("An RTA speedrun will start when you enter a level, and end when you finish" SPC $RtaSpeedrun::EndMission);
	echo("Good luck!");
}

function RtaSpeedrunSetEnd() {
	$RtaSpeedrun::EndMission = $Server::MissionFile;
	echo("The last level of the RTA speedrun set to" SPC $RtaSpeedrun::EndMission);
}

function RtaSpeedrunMissionStarted() {
	if (!$RtaSpeedrun::IsTiming) {
		echo("Speedrun mode began timing!");
		$RtaSpeedrun::IsTiming = true;
	}
	$RtaSpeedrun::LastSplitTime = -1;
	$RtaSpeedrun::MissionTypeDuration = -1;
	if ($MissionType !$= $RtaSpeedrun::CurrentMissionType) {
		$RtaSpeedrun::CurrentMissionType = $MissionType;
		$RtaSpeedrun::CurrentMissionTypeBegan = $RtaSpeedrun::Time;
	}
	RtaSpeedrunUpdateTimers();
}

function RtaSpeedrunMissionEnded() {
	if ($RtaSpeedrun::EndMission $= $Server::MissionFile) {
		echo("Just finished the end level! Speedrun mode over");
		echo("Final time:" SPC $RtaSpeedrun::Time);
		$RtaSpeedrun::IsEnabled = false;
		$RtaSpeedrun::IsTiming = false;
		$RtaSpeedrun::IsDone = true;
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
	if ($RtaSpeedrun::IsDone && $RtaSpeedrun::CurrentMissionTypeBegan > 0)
		%isEndOfMissionType = true;
	if (%isEndOfMissionType && (!$RtaSpeedrun::IsDone || $RtaSpeedrun::CurrentMissionTypeBegan > 0))
		$RtaSpeedrun::MissionTypeDuration = sub64_int($RtaSpeedrun::Time, $RtaSpeedrun::CurrentMissionTypeBegan);
	if (!$RtaSpeedrun::IsDone && $RtaSpeedrun::MissionTypeDuration != $RtaSpeedrun::Time)
		$RtaSpeedrun::LastSplitTime = $RtaSpeedrun::Time;
	RtaSpeedrunUpdateTimers();
}
