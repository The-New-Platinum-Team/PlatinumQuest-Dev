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

// Go'way said I had to make this its own mode. And I think he's a pretty cool
// guy so I'm doing that for him.

function Mode_steal::onLoad(%this) {
	%this.registerCallback("onBlast");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}

function Mode_steal::onBlast(%this, %object) {
	if ($Game::State $= "End")
		return;

	%mePos = %object.this.getWorldBoxCenter();
	%theyPos = %object.other.getWorldBoxCenter();

	//Blast radius: 3-6 tiles
	%blastRadius = 6 + (%object.this.client.blastValue - 0.2) * 7.5;
	if (VectorDist(%mePos, %theyPos) < %blastRadius) {
		//Steal their points
		%steal = (%object.this.client.blastValue * 2);
		
		// if (%object.this.client.usingTripleBlast) 
		// 	%steal = 1;
		
		if (%object.other.client.isMegaMarble())
			%steal *= 0.25;
			
		%steal = mRound(min(%steal, %object.other.client.gemCount));

		if (%steal > 0) {
			%object.this.client.onFoundGem(%steal);
			%object.other.client.onFoundGem(-%steal);

			%object.this.client.displayGemMessage("+" @ %steal, "99ff99");
			%object.other.client.displayGemMessage("-" @ %steal, "ff9999");
		}
	}
}
