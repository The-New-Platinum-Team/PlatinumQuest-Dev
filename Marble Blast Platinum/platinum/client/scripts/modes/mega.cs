//-----------------------------------------------------------------------------
// Mega Mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_mega) {
	class = "ModeInfo_mega";
	superclass = "ModeInfo";

	identifier = "mega";
	file = "mega";

	name = "Mega Marble War";
	desc = "Earn points by hitting your opponents with Mega Marbles!";
	complete = 1;
});


function ClientMode_mega::onLoad(%this) {
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("getDefaultScore");
	%this.registerCallback("radarGetDotBitmap");
	%this.registerCallback("nametagRaycast");
	%this.registerCallback("showEndGame");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_mega::timeMultiplier(%this) {
	return -1;
}
function ClientMode_mega::onEndGameSetup(%this) {
	PlayGui.setTime(0);
}
function ClientMode_mega::getDefaultScore(%this) {
	return $ScoreType::Score TAB 0 TAB "Matan W.";
}
function ClientMode_mega::radarGetDotBitmap(%this, %object) {
	if (%object.getClassName() $= "Marble" && %object != $MP::MyMarble) {
		return $userMods @ "/client/ui/mp/radar/Marble.png" TAB "white";
	}
	return "";
}
function ClientMode_mega::nametagRaycast(%this) {
	return false;
}

//-----------------------------------------------------------------------------

function ClientMode_mega::showEndGame(%this) {
	%this.onNextFrame(updateMegaEndGame);
	return false;
}

function ClientMode_mega::updateMegaEndGame(%this) {
	if (!$Game::isMode["mega"])
		return;
	//Mega War uses a different kinda end screen, Reds = Times you've been hit; Blues = Hits you got
	MPEndGameRedGem.setVisible(false);
	MPEndGameYellowGem.setVisible(false);
	MPEndGameBlueGem.setVisible(false);
	MPEndGamePlatinumGem.setVisible(false);
	MPDualCategoryOne.setVisible(true);
	MPDualCategoryTwo.setVisible(true);
	MPDualCategoryOne.setText("<bold:30><just:center><color:FF0000>Opp.\nHits");
	MPDualCategoryTwo.setText("<bold:30><just:center><color:4040FF>Your\nHits");

	%players = ($MP::TeamMode ? TeamScorePlayerList.getSize() : ScoreList.getSize());
	for (%i = 0; %i < %players; %i ++) {
		%index = ($MP::TeamMode ? getRecord(TeamScorePlayerList.getEntry(%i), 3) : ScoreList.getEntry(%i).index);
		%R = "MPEndTextR" @ %index;
		%Y = "MPEndTextY" @ %index;
		%B = "MPEndTextB" @ %index;
		%P = "MPEndTextP" @ %index;
		%R.resize(369, 3, 52, 14);
		%Y.setVisible(false);
		%B.resize(444, 3, 52, 14);
		%P.setVisible(false);
	}
}
