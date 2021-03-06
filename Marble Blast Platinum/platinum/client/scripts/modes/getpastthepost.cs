//-----------------------------------------------------------------------------
// Hunt - Get Past the Post mode
//
// Copyright (c) 2021 The Platinum Team
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_getpastthepost) {
	class = "ModeInfo_getpastthepost";
	superclass = "ModeInfo";

	identifier = "getpastthepost";
	file = "getpastthepost";

	name = "Hunt - Get Past the Post";
	desc = "How quickly can you get the required amount of points?";

	teams = 0;
});


function ClientMode_getpastthepost::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
	%this.registerCallback("onShowPlayGui");
}

function ClientMode_getpastthepost::onShowPlayGui(%this) {
	PastThePostCount.setVisible(true);
	PastThePostCount.setText("<font:24><color:FFFFFF>/" @ Missioninfo.markerpost);
}

function clientCmdSetPastThePostCount(%count) {
	$Game::GemCount = %count;
	PlayGui.setMaxGems(MissionInfo.markerpost);
	PastThePostCount.setVisible(true);
	PastThePostCount.setText("<font:24><color:FFFFFF>/" @ Missioninfo.markerpost);

	if ($Record::Recording) {
		recordWriteGems(RecordFO, PlayGui.gemCount, %count, MissionInfo.markerpost, (PlayGui.gemCount >= MissionInfo.markerpost));
	}
}
