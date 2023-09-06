//-----------------------------------------------------------------------------
// Haste Mode
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

function Mode_haste::onLoad(%this) {
	echo("[Mode" SPC %this.name @ "]: Loaded!");
	%this.registerCallback("canFinish");
	%this.registerCallback("getFinishMessage");
}
function Mode_haste::canFinish(%this, %object) {
	//Make sure they're going fast enough
	if (VectorLen(%object.client.player.getVelocity()) < MissionInfo.SpeedToQualify) {
		return false;
	}
	//Unknown, let the other modes decide
	return "";
}
function Mode_haste::getFinishMessage(%this, %object) {
	//Make sure they're going fast enough
	if (VectorLen(%object.client.player.getVelocity()) < MissionInfo.SpeedToQualify) {
		return "You may not finish without reaching the qualifying speed!";
	}
	//Unknown, let the other modes decide
	return "";
}
