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

datablock StaticShapeData(ReplayGhost) {
	shapeFile = "~/data/shapes/balls/ball-superball.dts";
	scopeAlways = true;
};

function playbackGhost(%file, %time) {
	%object = new Marble() {
		dataBlock = "DefaultMarble";
		mutePowerups = true;
	};

	%info = getReplayInfo(%file);
	%conn = new GameConnection() {
		player = %object;
	};
	%object.client = %conn;
	%conn.skinChoice = %info.marbleSelection;
	%conn.updateGhostDatablock();

	//%object.setFadeVal(0.75);
	%object.forceNetUpdate();
	PlaybackGhostGroup.add(%object);
	LocalClientConnection.syncObject(%object, "playbackSyncStart", %file TAB 1 TAB %time);
}

function playbackPlayer(%file, %marbleSelection) {
	LocalClientConnection.skinChoice = %marbleSelection;
	LocalClientConnection.updateGhostDatablock();
	LocalClientConnection.syncObject(LocalClientConnection.player, "playbackSyncStart", %file TAB 0 TAB 0);
	//Pls
	Time::reset();
	onNextFrame("playbackResetTime"); //So we don't break shit
}

function playbackResetTime() {
	Time::reset();
}
