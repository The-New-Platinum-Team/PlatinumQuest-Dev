//-----------------------------------------------------------------------------
// Collection mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_collection) {
	class = "ModeInfo_collection";
	superclass = "ModeInfo";

	identifier = "collection";
	file = "collection";

	name = "Collection";
	desc = "Race to get all the gems of your color before anyone else can collect all of theirs.";
	complete = 1;

	teams = 0;
});


function ClientMode_collection::onLoad(%this) {
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("radarShouldShowObject");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("shouldGhostFollow");
	%this.registerCallback("getDefaultScore"); // main_gi
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_collection::timeMultiplier(%this) {
	return -1;
}
function ClientMode_collection::radarShouldShowObject(%this, %gem) {
	return %this.getGemColor(%gem) $= $Client::CollectionColor;
}
function ClientMode_collection::getGemColor(%this, %gem) {
	return %gem.getSkinName();
}
function ClientMode_collection::onEndGameSetup(%this) {
}
function ClientMode_collection::shouldGhostFollow(%this, %object) {
	return true;
}

function clientCmdSetCollectionColor(%color) {
	$Client::CollectionColor = %color;
	HUD_ShowGem.setModel($usermods @ "/data/shapes/items/gem.dts", %color);
	Hunt_ShowGem.setModel($usermods @ "/data/shapes/items/gem.dts", %color);
}

function clientCmdCollectionRing(%index, %id) {
	//Find it
	%obj = getClientSyncObject(%id);
	if (!isObject(%obj)) {
		schedule(100, 0, clientCmdCollectionRing, %index, %id);
		return;
	}

	if (%index == $MP::ClientIndex) {
		if (!isObject(GhostFollowSet)) {
			RootGroup.add(new SimSet(GhostFollowSet));
		}
		GhostFollowSet.add(%obj);
	} else {
		//Someone else's. Don't show it

		//Goodbye
		%obj.setTransform("-1e9 -1e9 -1e9 1 0 0 0");
		%obj.setScale("0 0 0");
	}
}

function ClientMode_collection::getDefaultScore(%this) {  // main_gi
	return $ScoreType::Score TAB 0 TAB "Matan W.";
}