//-----------------------------------------------------------------------------
// Hunt mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_hunt) {
	class = "ModeInfo_hunt";
	superclass = "ModeInfo";

	identifier = "hunt";
	file = "hunt";

	name = "Gem Hunt";
	desc = "Collect Gems and earn as many points as you can!";
	complete = 1;

	teams = 1;
});


function ClientMode_hunt::onLoad(%this) {
	%this.registerCallback("shouldUpdateGems");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("getDefaultScore");
	%this.registerCallback("onClientLeaveGame");
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("getGemColor");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}


function updatePredictor() {
	cancel($updatePredictorSchedule);
	if (!$Game::IsMode["hunt"]) {PGScorePredictor.setVisible(false); return;}
	PGScorePredictor.setVisible(true);
	%score = PlayGui.gemCount;
	if (%score < 10) {
		PGScorePredictor.setPosition("117 50");
	} else if (%score < 100) {
		PGScorePredictor.setPosition("100 50");
	} else if (%score < 1000) {
		PGScorePredictor.setPosition("89 50");
	} else {
		PGScorePredictor.setPosition("73 50");
	}
	// Code stolen from \platinum\client\scripts\mp\scores.cs

	%platinumColor = "FFFFFF";
	%ultimateColor = "FFCC22";
	%estimated = mFloor(%score * (MissionInfo.time) / max(1, MissionInfo.time - PlayGui.currentTime));
	// vars to look at: MissionInfo.time, PlayGui.currentTime, PlayGui.bonusTime, PlayGui.totalTime, PlayGui.totalBonus
	// in Hunt, currentTime is basically reversed.

	%predictorMax = 0;
	if (MissionInfo.awesomeScore) {
		%predictorMax = MissionInfo.awesomeScore * $pref::ScorePredictorMaxFactor;
	}

	if ((MissionInfo.time - PlayGui.currentTime) < 10000 || (%predictorMax > 0 && %estimated > %predictorMax)) { // Don't show if the match hasn't been 10s long, to prevent stupid predictors
		PGScorePredictor.setText(" ");
	} else {
		%estimatedColor = "<shadowcolor:0000007f><shadow:1:1>";
		%vs = !$Server::Hosting //Not host, so there must be someone else who is
			|| (!$Server::_Dedicated && ClientGroup.getCount() > 1) //Hosting local, another player
			|| ($Server::_Dedicated && isObject(ScoreList.player[1])); //Hosting dedicated, hack but should work
		%scoreIdx = (%vs ? 0 : 1);
		%score = MissionInfo.score[%scoreIdx] || MissionInfo.score;
		%pla = MissionInfo.platinumScore[%scoreIdx] || MissionInfo.platinumScore;
		%ult = MissionInfo.ultimateScore[%scoreIdx] || MissionInfo.ultimateScore;
		// Do not involve Awesome Score in the visuals, that's a spoilery red color that is also close to the failing-par color.

		if (%estimated < %par && %par)
			%estimated = "<spush>" @ %estimatedColor @ "<color:FF6666>" @ %estimated @ "<spop>";
		else if (%estimated >= %ult && %ult)
			%estimated = "<spush>" @ %estimatedColor @ "<color:" @ %ultimateColor @ ">" @ %estimated @ "<spop>";
		else if (%estimated >= %pla && %pla)
			%estimated = "<spush>" @ %estimatedColor @ "<color:" @ %platinumColor @ ">" @ %estimated @ "<spop>";
		%font = "<bold:24>"; // default <bold:48>

		PGScorePredictor.setText($MPPref::ScorePredictor ? %font @ %estimated : "");
	}
	$updatePredictorSchedule = schedule(1000, 0, updatePredictor);
}

function ClientMode_hunt::onClientLeaveGame(%this) {
	cancel($updatePredictorSchedule);
	PGScorePredictor.setVisible(false);

	$MPPref::Server::CompetitiveMode = false;
	Hunt_CompetitiveClearTimer();
}

function ClientMode_hunt::shouldUpdateGems(%this) {
	PG_GemCounter.setVisible(false);
	PG_HuntCounter.setVisible(true);

	%count = PlayGui.gemCount;
	%max = PlayGui.maxGems;

	%one = %count % 10;
	%ten = ((%count - %one) / 10) % 10;
	%hundred = ((%count - %one - (%ten * 10)) / 100) % 10;
	%thousand = ((%count - %one - (%ten * 10) - (%hundred * 100)) / 1000) % 10;

	%color = ($Server::ServerType $= "Multiplayer" && PlayGui.gemGreen) ? $TimeColor["stopped"] : $TimeColor["normal"];

	updatePredictor();

	HuntGemsFoundOne.setVisible(true);
	HuntGemsFoundTen.setVisible(true);
	HuntGemsFoundHundred.setVisible(true);
	HuntGemsFoundThousand.setVisible(true);

	if (%count < 10) {
		HuntGemsFoundTen.setVisible(false);
		HuntGemsFoundHundred.setVisible(false);
		HuntGemsFoundThousand.setVisible(false);

		HuntGemsFoundOne.setNumberColor(%one, %color);
	} else if (%count < 100) {
		HuntGemsFoundHundred.setVisible(false);
		HuntGemsFoundThousand.setVisible(false);

		HuntGemsFoundOne.setNumberColor(%one, %color);
		HuntGemsFoundTen.setNumberColor(%ten, %color);
	} else if (%count < 1000) {
		HuntGemsFoundThousand.setVisible(false);

		HuntGemsFoundOne.setNumberColor(%one, %color);
		HuntGemsFoundTen.setNumberColor(%ten, %color);
		HuntGemsFoundHundred.setNumberColor(%hundred, %color);
	} else {
		HuntGemsFoundOne.setNumberColor(%one, %color);
		HuntGemsFoundTen.setNumberColor(%ten, %color);
		HuntGemsFoundHundred.setNumberColor(%hundred, %color);
		HuntGemsFoundThousand.setNumberColor(%thousand, %color);
	}
	return false;
}
function ClientMode_hunt::onMissionLoaded(%this) {
	PGScorePredictor.setVisible(true);
}
function ClientMode_hunt::getGemColor(%this, %gem) {
	return %gem.getSkinName();
}
function ClientMode_hunt::timeMultiplier(%this) {
	return -1;
}
function ClientMode_hunt::onEndGameSetup(%this) {
	PlayGui.setTime(0);
}
function ClientMode_hunt::getDefaultScore(%this) {
	return $ScoreType::Score TAB 0 TAB "Matan W.";
}
