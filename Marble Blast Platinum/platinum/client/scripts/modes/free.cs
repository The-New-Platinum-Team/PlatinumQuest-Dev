//-----------------------------------------------------------------------------
// Free World mode
//
// Originally created in 2013
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_free) {
	class = "ModeInfo_free";
	superclass = "ModeInfo";

	identifier = "free";
	file = "free";

	name = "Free World";
	desc = "Take your time and explore the level, there are no gems and no timers here.";
	complete = 1;
});


function ClientMode_free::onLoad(%this) {
	%this.registerCallback("shouldUpdateGems");
	%this.registerCallback("updateControls");
	%this.registerCallback("timeMultiplier");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_free::shouldUpdateGems(%this) {
	//No timer or gem counter
	PG_Timer.setVisible(false);
	PG_TimerThousands.setVisible(false);
	PG_GemCounter.setVisible(false);
	return false;
}
function ClientMode_free::updateControls(%this) {
	//No timer or gem counter
	PG_Timer.setVisible(false);
	PG_TimerThousands.setVisible(false);
	PG_GemCounter.setVisible(false);
}
function ClientMode_free::timeMultiplier(%this) {
	//ooooh 0x time multiplier
	return 0;
}