//-----------------------------------------------------------------------------
// Quota Mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_quota) {
	class = "ModeInfo_quota";
	superclass = "ModeInfo";

	identifier = "quota";
	file = "quota";

	name = "Gem Quota";
	desc = "Grab the required amount of Gems or go for 100%!";
	complete = 1;
});


function ClientMode_quota::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
	%this.registerCallback("radarShowShouldFinish");
	%this.registerCallback("shouldUpdateGems");
	%this.registerCallback("showEndGame");
	%this.registerCallback("onShowPlayGui");
	%this.registerCallback("onRespawnOnCheckpoint");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onClientLeaveGame");


}
function ClientMode_quota::radarShowShouldFinish(%this, %remaining) {
	return PlayGui.gemCount >= MissionInfo.GemQuota;
}
function ClientMode_quota::shouldUpdateGems(%this) {
	%gotQuota = (PlayGui.gemCount >= MissionInfo.GemQuota);
	PlayGui.gemGreen = %gotQuota;

	%trueMaxGems = $Game::GemCount; // Since "GemCount" doesn't count extra-valued gems, this will need to be reworked if Hunt+Quota integration happens.
	%gotAllGems = (PlayGui.gemCount == %trueMaxGems);
	if (%gotAllGems) { // Rainbow gem counter on 100% quota
		GemsQuota.setVisible(false);
		PlayGui.gemRainbow = true;
		PlayGui.gemRainbowNewMax = %trueMaxGems;
	} else {
		GemsQuota.setVisible(true);
		PlayGui.gemRainbow = false;
		cancel($quotacompleteparty);
	}
	return true;
}
function ClientMode_quota::showEndGame(%this) {
	//If they got 100% mark it down
	if (PlayGui.gemCount == $Game::GemCount) {
		//You bet, save their best 100% time (because more LBs!)
		$pref::Quota100[$Server::MissionFile] = getField($Game::FinalScore, 1);

		if (lb()) {
			//Add the 100% immediately to the lbs if we need to
			%id = PlayMissionGui.getMissionInfo().id;
			if (!isObject(PlayMissionGui.personalScoreListCache.quota100.getFieldValue(%id))) {
				%score = $Game::FinalScore;

				JSONGroup.add(%q100 = new ScriptObject() {
					mission_id = %id;
					score_type = getField(%score, 0) == $ScoreType::Time ? "time" : "score";
					score = getField(%score, 1);
				});
				PlayMissionGui.personalScoreListCache.quota100.setFieldValue(%id, %q100);
			}
		}
	}
	return "";
}

function undoRainbowEffectIfNeeded(%needed) {
	if ((PlayGui.gemCount != $Game::GemCount) || %needed) { // again, $Game::GemCount is inaccurate for hunt+quota integration
		GemsQuota.setVisible(true);
		PlayGui.gemRainbow = false;
		cancel($quotacompleteparty);
		PlayGui.updateGems();
	}
}

function ClientMode_quota::onMissionReset(%this) {
	undoRainbowEffectIfNeeded();
}
function ClientMode_quota::onRespawnOnCheckpoint(%this) {
	undoRainbowEffectIfNeeded();
}
function ClientMode_quota::onClientLeaveGame(%this) {
	undoRainbowEffectIfNeeded(true);
}


function ClientMode_quota::onShowPlayGui(%this) {
	GemsQuota.setVisible(true);
	GemsQuota.setText("<font:24><color:FFFFFF>/" @ $Game::GemCount);
}

function clientCmdSetGemQuota(%count, %quota) {
	$Game::GemCount = %count;
	PlayGui.setMaxGems(%quota);
	GemsQuota.setVisible(true);
	GemsQuota.setText("<font:24><color:FFFFFF>/" @ $Game::GemCount);

	if ($Record::Recording) {
		recordWriteGems(RecordFO, PlayGui.gemCount, %count, %quota, (PlayGui.gemCount >= %quota));
	}
}
