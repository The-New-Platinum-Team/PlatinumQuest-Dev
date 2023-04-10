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

ModeInfoGroup.add(new ScriptObject(ModeInfo_king) {
	class = "ModeInfo_king";
	superclass = "ModeInfo";

	identifier = "king";
	file = "king";

	name = "King of the Hill";
	desc = "Assert your dominance and stand your ground as king of the hill!";
	complete = 1;

	teams = 1;
});


function ClientMode_king::onLoad(%this) {
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("shouldUpdateGems");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("getDefaultScore");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_king::timeMultiplier(%this) {
	return -1;
}

function ClientMode_king::shouldUpdateGems(%this) {
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
function ClientMode_king::onEndGameSetup(%this) {
	PlayGui.setTime(0);
}
function ClientMode_king::getDefaultScore(%this) {
	return $ScoreType::Score TAB 0 TAB "Matan W.";
}