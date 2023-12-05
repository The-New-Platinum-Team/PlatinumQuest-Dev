//-----------------------------------------------------------------------------
// Haste mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_haste) {
	class = "ModeInfo_haste";
	superclass = "ModeInfo";

	identifier = "haste";
	file = "haste";

	name = "Haste";
	desc = "Build up speed to activate the finish!";
	complete = 0;
});


function ClientMode_haste::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
	%this.registerCallback("onActivate");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("shouldShowSpeedometer");
	%this.registerCallback("updateSpeedometer");
}
function ClientMode_haste::onActivate(%this) {
	PGHasteMarker.setVisible(1);
}
function ClientMode_haste::onDeactivate(%this) {
	PGHasteMarker.setVisible(0);
}
function ClientMode_haste::shouldShowSpeedometer(%this) {
	return true;
}
function ClientMode_haste::updateSpeedometer(%this, %velocity) {
	PGHasteMarker.setPosition(0 SPC getWord(PGSPDBackground.position, 1) + 857 - 8 * MissionInfo.SpeedToQualify);
	if (%velocity > MissionInfo.SpeedToQualify) {
		PGHasteMarker.setBitmap($usermods @ "/client/ui/game/speedometer/haste_achieved.png");
	} else {
		PGHasteMarker.setBitmap($usermods @ "/client/ui/game/speedometer/haste_notachieved.png");
	}
}
