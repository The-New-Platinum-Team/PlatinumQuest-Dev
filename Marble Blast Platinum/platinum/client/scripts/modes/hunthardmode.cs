//-----------------------------------------------------------------------------
// hunt hard mode mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_hunthardmode) {
	class = "ModeInfo_hunthardmode";
	superclass = "ModeInfo";

	identifier = "hunthardmode";
	file = "hunthardmode";

	name = "Hunt - Hard Mode";
	desc = "No PowerUps, No Blasting, No Yellows or Blues. Black Gems will give you a random Powerup. Good luck! (I do not recommend playing on maps with gems that are unreachable without PU's)";

	teams = 1;
});


function ClientMode_hunthardmode::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}