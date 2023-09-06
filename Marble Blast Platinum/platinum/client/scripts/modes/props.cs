//-----------------------------------------------------------------------------
// Prop Hunt mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_props) {
	class = "ModeInfo_props";
	superclass = "ModeInfo";

	identifier = "props";
	file = "props";

	name = "Prop Hunt";
	desc = "Disguise yourself and try to evade detection!";
	complete = 1;

	teams = 0;
	hide = 1;
});


function ClientMode_props::onLoad(%this) {
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("shouldGhostFollow");
	%this.registerCallback("updateGhostFollow");
	%this.registerCallback("shouldIgnoreItem");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}

function ClientMode_props::timeMultiplier(%this) {
	return -1;
}
function ClientMode_props::onEndGameSetup(%this) {
	PlayGui.setTime(0);
}
function ClientMode_props::shouldGhostFollow(%this) {
	return true;
}
function ClientMode_props::shouldIgnoreItem(%this, %obj) {
	//Ignore our own prop, because otherwise it flashes
	return GhostFollowSet.isMember(%obj);
}
function ClientMode_props::updateGhostFollow(%this, %obj) {
	//Set the item's position to the marble's position,
	// rotated to gravity, and dropped at the ground.
	%gravity = $Game::GravityRot;
	%trans = getWords($MP::MyMarble.getTransform(), 0, 2) SPC %gravity;
	//Flip because gravity is inverse
	%trans = MatrixMultiply(%trans, "0 0 0 1 0 0 3.14159");
	//Which direction do we cast in?
	%castDir = MatrixMulPoint("0 0 0" SPC %gravity, "0 0 2");
	//Cast
	%cast = ClientContainerRayCast(MatrixPos(%trans), VectorAdd(MatrixPos(%trans), %castDir), $TypeMasks::InteriorObjectType | $TypeMasks::StaticShapeObjectType);
	if (%cast) {
		//Move to cast pos
		%trans = getWords(%cast, 1, 3) SPC getWords(%trans, 3, 6);
	} else {
		//No cast, put it inside the marble with a radius of 0.2
		%add = MatrixMulPoint("0 0 0" SPC %gravity, "0 0 0.2");
		%trans = VectorAdd(MatrixPos(%trans), %add) SPC getWords(%trans, 3, 6);
	}
	//Calculate the zdrop if needed
	if (%obj.zdrop $= "") {
		//Normalize position and rotation
		%obj.setTransform("0 0 0 1 0 0 0");
		%obj.zdrop = VectorSub(%obj.getPosition(), getWords(%obj.getWorldBoxCenter(), 0, 1) SPC getWord(%obj.getWorldBox(), 2));
	}

	%trans = MatrixMultiply(%trans, %obj.zdrop SPC "1 0 0 0");
	if (%obj.getClassName() $= "Item") {
		//Simulate item rotation because constant setTransform() breaks the
		// engine rotation.
		// Period = 1 full turn / 3 seconds (hardcoded in engine)
		// Always on Z axis too
		%trans = MatrixMultiply(%trans, "0 0 0 0 0 1" SPC($Sim::Time * ($pi * 2) / 3));
	}
	%obj.setTransform(%trans);
	return true;
}

function clientCmdDetectProp(%scale, %propClass, %propdb) {
	cancel($Client::PropSch);
	devecho("Looking for prop:" SPC %scale SPC %propClass SPC %propdb);
	%prop = -1;

	//Try to find the prop in ServerConnection
	%count = ServerConnection.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);

		if (!(%obj.getType() & $TypeMasks::GameBaseObjectType))
			continue;

		//Look for scale, class, and datablock
		if (%obj.getScale() $= %scale && %obj.getClassName() $= %propClass && %obj.getDataBlock().getName() $= %propdb) {
			//It's our prop
			%prop = %obj;
			break;
		}
	}

	//If we didn't find it, try again in a bit
	if (!isObject(%prop)) {
		devecho("Didn\'t find one! Trying again.");
		$Client::PropSch = schedule(200, 0, clientCmdDetectProp, %scale, %propClass, %propdb);
		return;
	}

	if (!isObject(GhostFollowSet)) {
		RootGroup.add(new SimSet(GhostFollowSet));
	}
	devecho("Found one!");
	GhostFollowSet.add(%prop);
}
