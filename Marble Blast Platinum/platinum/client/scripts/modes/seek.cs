//-----------------------------------------------------------------------------
// Hide and "Seek" mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_seek) {
	class = "ModeInfo_seek";
	superclass = "ModeInfo";

	identifier = "seek";
	file = "seek";

	name = "Hide and Seek";
	desc = "Hide in the recesses of the level, or search and tag your way to victory!";
	complete = 1;

	teams = 0;
	hide = 1;
});


function ClientMode_seek::onLoad(%this) {
	%this.registerCallback("nametagDistance");
	%this.registerCallback("nametagRaycast");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onEndGameSetup");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}

function ClientMode_seek::nametagDistance(%this) {
	%time = ($Game::SeekGrace ? $Game::SeekGrace : 20000);
	return (PlayGui.currentTime < %time ? 2000 : 0);
}
function ClientMode_seek::nametagRaycast(%this) {
	return false;
}
function ClientMode_seek::timeMultiplier(%this) {
	return -1;
}
function ClientMode_seek::onEndGameSetup(%this) {
	PlayGui.setTime(0);
}

function clientCmdSeekGracePeriod(%time) {
	$Game::SeekGrace = %time;
}
