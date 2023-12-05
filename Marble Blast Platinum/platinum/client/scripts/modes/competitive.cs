//-----------------------------------------------------------------------------
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


// This mode has no code (it's in hunt and huntGems, on by the variable '$MPPref::Server::CompetitiveMode')
ModeInfoGroup.add(new ScriptObject(ModeInfo_competitive) {
	class = "ModeInfo_competitive";
	superclass = "ModeInfo";

	identifier = "competitive";
	file = "competitive";

	name = "<spush><color:ff0000>Competitive Mode";
	desc = "<spop><spush><color:ff7777>20 second gem autorespawn timer (decreases to 15/10/5 seconds at 3/2/1 gems remaining). 5 second Mega Marble. Only Ultra Blast pushes other players. No quickspawn. Shared starting point.<spop>";
	complete = 0;
	hide = 1;
});

function ClientMode_competitive::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
