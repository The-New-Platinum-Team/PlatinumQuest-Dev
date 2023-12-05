//-----------------------------------------------------------------------------
// Consistency mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_consistency) {
	class = "ModeInfo_consistency";
	superclass = "ModeInfo";

	identifier = "consistency";
	file = "consistency";

	name = "Consistency";
	desc = "Stay above the target speed!";
	complete = 0;
});


function ClientMode_consistency::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
	%this.registerCallback("onActivate");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("shouldShowSpeedometer");
	%this.registerCallback("updateSpeedometer");
}
function ClientMode_consistency::onActivate(%this) {
	PGConsMarker.setVisible(1);
}
function ClientMode_consistency::onDeactivate(%this) {
	PGConsMarker.setVisible(0);
}
function ClientMode_consistency::shouldShowSpeedometer(%this) {
	return true;
}
function ClientMode_consistency::updateSpeedometer(%this, %velocity) {
	PGConsMarker.setPosition(0 SPC getWord(PGSPDBackground.position, 1) + 857 - 8 * MissionInfo.MinimumSpeed);
	if (%velocity > MissionInfo.MinimumSpeed) {
		PGConsMarker.setBitmap($usermods @ "/client/ui/game/speedometer/cons_normal.png");
	} else {
		PGConsMarker.setBitmap($usermods @ "/client/ui/game/speedometer/cons_tooslow.png");
	}
}
