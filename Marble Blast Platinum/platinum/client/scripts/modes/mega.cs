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

	teams = 1;
});


function ClientMode_mega::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("getDefaultScore");
	%this.registerCallback("radarGetDotBitmap");
	%this.registerCallback("nametagRaycast");
	%this.registerCallback("loadModeSettings");
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

function ClientMode_mega::loadModeSettings(%this) {
	%i = 0;
	%this.serverSetting[%i++,  "Name"] = "AlwaysMega";
	%this.serverSetting[%i,   "Title"] = "Always Mega Marble";
	%this.serverSetting[%i,    "Type"] = "check";
	%this.serverSetting[%i, "IsField"] = false;
	%this.serverSetting["AlwaysMega"] = %i;

	%this.serverSetting[%i++,  "Name"] = "Steal";
	%this.serverSetting[%i,   "Title"] = "Steal Mode";
	%this.serverSetting[%i,    "Type"] = "check";
	%this.serverSetting[%i, "IsField"] = false;
	%this.serverSetting["Steal"] = %i;
	
	%this.totalSettings = %i;
}