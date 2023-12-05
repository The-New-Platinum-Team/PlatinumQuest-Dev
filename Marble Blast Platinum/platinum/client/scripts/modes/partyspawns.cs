//-----------------------------------------------------------------------------
// Party Spawns
//
// Originally created in 2021
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_partyspawns) {
	class = "ModeInfo_partyspawns";
	superclass = "ModeInfo";

	identifier = "partyspawns";
	file = "partyspawns";

	name = "Party Spawns";
	desc = "Extra gem colors, and special gem properties!";
	complete = 0;
});


function ClientMode_partyspawns::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}

$RadarColor["white"]  = "255 255 255 255";
$RadarColor["rainbow"]  = "75 0 130 255";

//$RadarColor["gold"]  = "212 175 55 255";
//$RadarColor["maroon"]  = "128 0 0 255";

function clientCmdTripleBlast(%enable) {
	$MP::TripleBlast = %enable;
	PlayGui.updateBlastBar();
}

//-----------------------------------------------------------------------------

function clientCmdRainbowGem(%force) {
	Physics::pushLayerName(RainbowGem);
	if (%force)
		$Party::RainbowGemTime = getSimTime();
	if (getSimTime() - $Party::RainbowGemTime > 20000 || %force) {
		PlayGui.pushPowerupTimer(100, getSimTime(), 20000);
	} else {
		PlayGui.pushPowerupTimer(100, getSimTime(), (20000 - (getSimTime() - $Party::RainbowGemTime)));
	}
}

function clientCmdEndRainbowGem() {
	Physics::popLayerName(RainbowGem);
	PlayGui.pushPowerupTimer(100, getSimTime(), 0);
}

function clientCmdWhiteGem(%force) {
	Physics::pushLayerName(WhiteGem);
	if (%force)
		$Party::WhiteGemTime = getSimTime();
	if (getSimTime() - $Party::WhiteGemTime > 5000 || %force) {
		PlayGui.pushPowerupTimer(102, getSimTime(), 5000);
	} else {
		PlayGui.pushPowerupTimer(102, getSimTime(), (5000 - (getSimTime() - $Party::WhiteGemTime)));
	}
}

function clientCmdEndWhiteGem() {
	Physics::popLayerName(WhiteGem);
	PlayGui.pushPowerupTimer(102, getSimTime(), 0);
}

function clientCmdBlackGem(%force) {
	if (%force)
		$Party::BlackGemTime = getSimTime();
	if (getSimTime() - $Party::BlackGemTime > 10000 || %force) {
		PlayGui.pushPowerupTimer(101, getSimTime(), 10000);
	} else {
		PlayGui.pushPowerupTimer(101, getSimTime(), (10000 - (getSimTime() - $Party::BlackGemTime)));
	}
}

function clientCmdEndBlackGem() {
	PlayGui.pushPowerupTimer(101, getSimTime(), 0);
}

//-----------------------------------------------------------------------------

Physics::registerLayer("RainbowGem",
                       "maxRollVelocity 30 30" NL
                       "angularAcceleration 200 200" NL
                       "brakingAcceleration 50 50" NL
                       "airAcceleration 15 15" NL
                       "jumpImpulse 10 10" NL
                       "kineticFriction 1.8 1.8"
                      );

Physics::registerLayer("WhiteGem",
                       "gravity 7.5 7.5"
                       );