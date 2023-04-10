//-----------------------------------------------------------------------------
// King Mode
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

function Mode_king::onLoad(%this) {
	%this.registerCallback("onFoundGem");
	%this.registerCallback("getStartTime");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_king::onFoundGem(%this, %object) {
//	%object.client.playPitchedSound("gotDiamond");
}
function Mode_king::getStartTime(%this) {
	return (MissionInfo.time ? MissionInfo.time : 300000);
}
function Mode_king::shouldResetTime(%this, %object) {
	return false;
}
function Mode_king::shouldRestartOnOOB(%this, %object) {
	return false;
}
function Mode_king::shouldRespawnGems(%this, %object) {
	return false;
}
function Mode_king::getScoreType(%this) {
	return $ScoreType::Score;
}
function Mode_king::getFinalScore(%this, %object) {
	return $ScoreType::Score TAB %object.client.getGemCount();
}
function Mode_king::timeMultiplier(%this) {
	return -1;
}
function GameConnection::enterKingTrigger(%this, %trigger) {
	%this.kingTrigger = %trigger;
	%this.updateKingTrigger();
}
function GameConnection::leaveKingTrigger(%this, %trigger) {
	%this.kingTrigger = false;
}
function GameConnection::updateKingTrigger(%this) {
	cancel(%this.kingSchedule);
	if (!$Game::Finished) {
		if (isObject(%this.kingTrigger)) {
			%points = %this.kingTrigger.multiplier $= "" ? 1.0 : %this.kingTrigger.multiplier;
			if (%points < 1) {
				%this.tempPoints += %points;
				if (%this.tempPoints > 1) {
					%points = mFloor(%this.tempPoints);
					%this.tempPoints -= %points;
					%this.onFoundGem(%points);
				}
			} else {
				%this.onFoundGem(%points);
			}
		} else {
			if (%this.gemCount > 0) {
				%this.gemCount -= 1;
				%this.setGemCount(%this.getGemCount());
			}
		}
		updateScores();
		%this.kingSchedule = %this.schedule(1000, "updateKingTrigger");
	}
}


//-----------------------------------------------------------------------------

datablock TriggerData(KingTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "multiplier";
	customField[0, "type"   ] = "float";
	customField[0, "name"   ] = "Multiplier";
	customField[0, "desc"   ] = "How many points per second this trigger gives.";
	customField[0, "default"] = "1";
};

function KingTrigger::onEnterTrigger(%this, %trigger, %obj) {
	%obj.client.enterKingTrigger(%trigger);
}

function KingTrigger::onLeaveTrigger(%this, %trigger, %obj) {
	%obj.client.leaveKingTrigger(%trigger);
}
