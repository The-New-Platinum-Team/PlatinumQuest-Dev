//-----------------------------------------------------------------------------
// Gem Madness Mode (client)
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_GemMadness) {
	class = "ModeInfo_GemMadness";
	superclass = "ModeInfo";

	identifier = "GemMadness";
	file = "GemMadness";

	name = "Gem Madness";
	desc = "Collect as many gems as you can before time runs out!";
	complete = 1;
});


/**
 * @param {ClientMode} %this
 */
function ClientMode_GemMadness::onLoad(%this) {
	%this.registerCallback("shouldUpdateGems");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("getDefaultScore");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}

/**
 * @param {ClientMode_GemMadness} %this
 */
function ClientMode_GemMadness::shouldUpdateGems(%this) {
	// Just borrowing the hunt counter here

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
/**
 * @param {ClientMode_GemMadness} %this
 */
function ClientMode_GemMadness::timeMultiplier(%this) {
	// Timer counts down
	return -1;
}
/**
 * @param {ClientMode_GemMadness} %this
 */
function ClientMode_GemMadness::getDefaultScore(%this) {
	return $ScoreType::Score TAB 0 TAB "Matan W.";
}

function clientCmdUseTimeScore(%use) {
	$Game::UseTimeScore = %use;
}
