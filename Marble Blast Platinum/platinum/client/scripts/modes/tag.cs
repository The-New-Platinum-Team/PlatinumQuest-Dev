//-----------------------------------------------------------------------------
// Tag mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_tag) {
	class = "ModeInfo_tag";
	superclass = "ModeInfo";

	identifier = "tag";
	file = "tag";

	name = "Tag";
	desc = "Tag your opponents by blasting them; the player with the least points wins!";
	complete = 1;

	teams = 0;
	hide = 1;
});

ModeInfoGroup.add(new ScriptObject(ModeInfo_keepAway) {
	class = "ModeInfo_keepAway";
	superclass = "ModeInfo";

	identifier = "keepAway";
	file = "tag";

	name = "Keep Away";
	desc = "Yes.";

	hide = 1;
	hasMissions = 0;
});

ModeInfoGroup.add(new ScriptObject(ModeInfo_stampede) {
	class = "ModeInfo_stampede";
	superclass = "ModeInfo";

	identifier = "stampede";
	file = "tag";

	name = "Stampede";
	desc = "Yes.";

	hide = 1;
	hasMissions = 0;
});


function ClientMode_tag::onLoad(%this) {
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onEndGameSetup");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_tag::timeMultiplier(%this) {
	return -1;
}
function ClientMode_tag::onEndGameSetup(%this) {
	PlayGui.setTime(0);
}

function ClientMode_keepAway::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}

function ClientMode_stampede::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
