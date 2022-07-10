//-----------------------------------------------------------------------------
// Copyright (c) 2022 The Platinum Team
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

function marblelandDownloadLevelList(%callback) {
	if (!isObject(MarblelandJSONDownloader)) {
		%dl = new HTTPObject(MarblelandJSONDownloader);
		%dl.success = 0;
		%dl.callback = %callback;
		%dl.get("https://marbleland.vani.ga","/api/level/list","");
	}
}

function MarblelandJSONDownloader::onLine(%this, %line) {
	echo("Loaded Marbleland MissionList");
	$MarblelandMissionList = jsonParse(%line);
	%this.success = 1;

	// Prepare lookup
	for (%i = 0; %i < $MarblelandMissionList.getSize(); %i++) {
		%entry = $MarblelandMissionList.getEntry(%i);
		$MarblelandMissionList.lookup[%entry.id] = %entry;
	}
}

function MarblelandJSONDownloader::onDisconnect(%this) {
	if (%this.callback !$= "") {
		schedule(100, 0, %this.callback, %this.success);
	}
	%this.delete();
}

//-----------------------------------------------------------------------------

function marblelandDownload(%id, %callback) {
	%mission = $MarblelandMissionList.lookup[%id];

	mkdir("packages/marbleland", 493);
	chmod("packages/marbleland", 493);
	%dl = new HTTPObject(MarblelandDownloader);
	%dl.callback = %callback;
	%dl.id = %mission.id;
	%dl.success = 0;
	%dl.setDownloadPath("packages/marbleland/" @ %mission.id @ ".mbpak");
	%dl.get("https://marbleland.vani.ga", "/api/level/" @ %mission.id @ "/mbpak", "assuming=none&append-id-to-mis=1");
}

function MarblelandDownloader::onDownload(%this, %path) {
	%this.success = 1;

	$pref::MarblelandMission[%this.id] = $MarblelandMissionList.lookup[%this.id].editedAt;

	MarblelandPackages.addEntry(%this.id);
	loadMBPackageMis("marbleland/" @ %this.id);

	if (!$Server::Dedicated) {
		marblelandRefreshMissionList();
	}
}

function MarblelandDownloader::onDisconnect(%this) {
	if (%this.callback !$= "") {
		// Get out of this stack frame
		schedule(100, 0, %this.callback, %this.id, %this.success);
	}
	%this.delete();
}

//-----------------------------------------------------------------------------

function marblelandDelete(%id) {
	MarblelandPackages.removeMatching(%id);
	unloadMBPackage("marbleland/" @ %id);
	deletePackage("marbleland/" @ %id);
}

//-----------------------------------------------------------------------------

function marblelandGetMission(%id) {
	return $MarblelandMissionList.lookup[%id];
}

function marblelandHaveMission(%id) {
	return isLoadedMBPackage("marbleland/" @ %id);
}

//-----------------------------------------------------------------------------

function marblelandReloadMissions() {
	echo("Reloading Marbleland");
	for (%i = 0; %i < MarblelandPackages.getSize(); %i++) {
		%pakName = MarblelandPackages.getEntry(%i);
		if (!isLoadedMBPackage("marbleland/" @ %pakName)) {
			loadMBPackageMis("marbleland/" @ %pakName);
		}
	}
}

function marblelandUnloadMissions() {
	echo("Unloading Marbleland");
	for (%i = 0; %i < MarblelandPackages.getSize(); %i++) {
		%pakName = MarblelandPackages.getEntry(%i);
		if (isLoadedMBPackage("marbleland/" @ %pakName)) {
			unloadMBPackage("marbleland/" @ %pakName);
		}
	}
}

function marblelandLoad(%id) {
	echo("Marbleland load " @ %id);
	// Get the ids of the rest of the marbleland missions and unload them
	for (%i = 0; %i < MarblelandPackages.getSize(); %i++) {
		%pakName = MarblelandPackages.getEntry(%i);
		if (%pakName != %id) {
			if (isLoadedMBPackage("marbleland/" @ %pakName)) {
				unloadMBPackage("marbleland/" @ %pakName);
				loadMBPackageMis("marbleland/" @ %pakName);
			}
		}
	}

	if (isObject($MarblelandMissionList.lookup[%id])) {
		// Reload the one which is gonna be played
		loadMBPackage("marbleland/" @ %id);
	}
}

// Client only!
function marblelandRefreshMissionList() {
	// Refresh "Custom" and "custom/marbleland" difficulties
	getMissionList("offline").buildCustomDifficultyTree();
	%ml = getMissionList("offline").getMissionList("Custom", "Custom/");
	if (isObject(%ml)) {
		%ml.delete();
	}
	%ml = getMissionList("offline").getMissionList("Custom", "Custom/platinum/data/missions/marbleland");
	if (isObject(%ml)) {
		%ml.delete();
	}

	if ($MissionType $= "Custom/" || $MissionType $= "Custom/platinum/data/missions/marbleland/") {
		PlayMissionGui.buildCustomDifficultyList();
		PlayMissionGui.setMissionType($MissionType);
		PlayMissionGui.showMissionList();
	}
}
