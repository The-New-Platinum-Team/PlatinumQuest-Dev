//-----------------------------------------------------------------------------
// Elimination mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_elimination) {
	class = "ModeInfo_elimination";
	superclass = "ModeInfo";

	identifier = "elimination";
	file = "elimination";

	name = "Elimination";
	desc = "Feel the pressure as the lowest scoring players are removed one by one!";

	teams = 1;
	hide = 1;
});


function ClientMode_elimination::onLoad(%this) {
	%this.registerCallback("onEndGameSetup");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_elimination::onEndGameSetup(%this) {
	PlayGui.setTime(0);
}

