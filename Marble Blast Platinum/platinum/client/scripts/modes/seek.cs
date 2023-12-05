//-----------------------------------------------------------------------------
// Hide and Seek mode
//
// Originally created in 2015
//
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_seek) {
	class = "ModeInfo_seek";
	superclass = "ModeInfo";

	identifier = "seek";
	file = "seek";

	name = "Hide and Seek";
	desc = "Hide in the recesses of the level, or search and tag your way to victory!";
	complete = 1;
});


function ClientMode_seek::onLoad(%this) {
	%this.registerCallback("onMissionReset");
	%this.registerCallback("nametagDistance");
	%this.registerCallback("nametagRaycast");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("disableBlastIndicator");
	%this.registerCallback("shouldUpdateGems");
	%this.registerCallback("getDefaultScore");
	%this.registerCallback("showEndGame");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_seek::onMissionReset(%this) {
	clientCmdSeekGracePeriod();
}

function clientCmdSeekGracePeriod() {
	//Disable timer
	MissionInfo.AlarmStartTime = -100; //Hack: Set the alarm time in MissionInfo to negative, so the alarm doesn't go off
	$PlayTimerAlarmText = true;
}

//--------------------------------------------------------------------------

function ClientMode_seek::nametagDistance(%this) {
	return false;
}
function ClientMode_seek::nametagRaycast(%this) {
	return false;
}
function ClientMode_seek::timeMultiplier(%this) {
	return -1;
}
function ClientMode_seek::onEndGameSetup(%this) {
	PlayGui.stopTimer();
}
function ClientMode_seek::disableBlastIndicator(%this) {
	return true;
}

//--------------------------------------------------------------------------

function ClientMode_seek::shouldUpdateGems(%this) {
	//Borrowed from hunt.cs
	PG_GemCounter.setVisible(false);
	PG_HuntCounter.setVisible(true);

	%count = PlayGui.gemCount;
	%max = PlayGui.maxGems;

	%one = %count % 10;
	%ten = ((%count - %one) / 10) % 10;
	%hundred = ((%count - %one - (%ten * 10)) / 100) % 10;
	%thousand = ((%count - %one - (%ten * 10) - (%hundred * 100)) / 1000) % 10;

	%color = ($Server::ServerType $= "Multiplayer" && PlayGui.gemGreen) ? $TimeColor["stopped"] : $TimeColor["normal"];

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
function ClientMode_seek::getDefaultScore(%this) {
	return $ScoreType::Score TAB 0 TAB "Matan W.";
}

//--------------------------------------------------------------------------

function clientCmdReloadReflections() {
	cleanupReflectiveMarble();
}

function clientCmdClearSeekLayers() {
	Physics::popLayerName(HiderMarble);
	Physics::popLayerName(SeekerMarble);
}

function clientCmdPushSeekerLayer() {
	Physics::popLayerName(HiderMarble);
	Physics::pushLayerName(SeekerMarble);
}
function clientCmdPushHiderLayer() {
	Physics::popLayerName(SeekerMarble);
	Physics::pushLayerName(HiderMarble);
}

//ooh physics layers
//RIP datablock method
Physics::registerLayer("SeekerMarble",
                       "maxRollVelocity 21 16.8" NL
                       "angularAcceleration 105 84" NL
                       "brakingAcceleration 42 35" NL
                       "airAcceleration 7 7" NL
                       "staticFriction 1.54 1.4" NL
                       "kineticFriction 0.98 1.12" NL
                       "bounceKineticFriction 0.28 0.42"
                      );
Physics::registerLayer("HiderMarble",
                       "maxRollVelocity 7.5 6" NL
                       "angularAcceleration 37.5 30" NL
                       "brakingAcceleration 24 20" NL
                       "airAcceleration 2 2" NL
                       "staticFriction 1.3 1.18" NL
                       "kineticFriction 0.9 1.03" NL
                       "bounceKineticFriction 0.2 0.3"
                      );

//--------------------------------------------------------------------------

function ClientMode_seek::showEndGame(%this) {
	%this.onNextFrame(updateSeekEndGame);
	return false;
}

function ClientMode_seek::updateSeekEndGame(%this) {
	if (!$Game::isMode["seek"])
		return;
	//Hide and Seek end screen: Blues = People you found; Yellows = Win as a hider
	MPEndGameRedGem.setVisible(false);
	MPEndGameYellowGem.setVisible(false);
	MPEndGameBlueGem.setVisible(false);
	MPEndGamePlatinumGem.setVisible(false);
	MPDualCategoryOne.setVisible(true);
	MPDualCategoryTwo.setVisible(true);
	MPDualCategoryOne.setText("<bold:30><just:center><color:FFFF00>Hider\nWin");
	MPDualCategoryTwo.setText("<bold:30><just:center><color:4040FF>People\nFound");

	%players = ($MP::TeamMode ? TeamScorePlayerList.getSize() : ScoreList.getSize());
	for (%i = 0; %i < %players; %i ++) {
		%index = ($MP::TeamMode ? getRecord(TeamScorePlayerList.getEntry(%i), 3) : ScoreList.getEntry(%i).index);
		%R = "MPEndTextR" @ %index;
		%Y = "MPEndTextY" @ %index;
		%B = "MPEndTextB" @ %index;
		%P = "MPEndTextP" @ %index;
		%R.setVisible(false);
		%Y.resize(369, 3, 52, 14);
		%B.resize(444, 3, 52, 14);
		%P.setVisible(false);
	}
}