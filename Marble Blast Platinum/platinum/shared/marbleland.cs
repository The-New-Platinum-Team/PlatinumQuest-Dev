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

	fwrite("platinum/json/marblelandList.json", %line);

	// Prepare lookup
	for (%i = 0; %i < $MarblelandMissionList.getSize(); %i++) {
		%entry = $MarblelandMissionList.getEntry(%i);
		$MarblelandMissionList.lookup[%entry.id] = %entry;

		%missionId = %entry.id;
		%misname = strreplace(%entry.baseName, ".mis", "") @ "_" @ %missionId @ ".mis";
		%entry.file = "platinum/data/missions/marbleland/" @ %misname;
	}
}

function MarblelandJSONDownloader::onDisconnect(%this) {
	if (%this.callback !$= "") {
		schedule(100, 0, %this.callback, %this.success);
	}
	%this.destroy();
}

//-----------------------------------------------------------------------------

function marblelandDownload(%id, %callback) {
	echo("Marbleland downloading: " @ %id SPC %callback);
	%mission = $MarblelandMissionList.lookup[%id];

	if (!isObject(%mission)) {
		schedule(100, 0, %callback, %id, false);
		return;
	}

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
}

function MarblelandDownloader::onDisconnect(%this) {
	echo("Marbleland download status: " @ %this.id @ " success: " @ %this.success);
	if (%this.callback !$= "") {
		// Get out of this stack frame
		schedule(100, 0, %this.callback, %this.id, %this.success);
	}
	%this.destroy();
}

//-----------------------------------------------------------------------------

function marblelandDelete(%id) {
	MarblelandPackages.removeMatching(%id);
	unloadMBPackage("marbleland/" @ %id);
	deletePackage("marbleland/" @ %id);
}

//-----------------------------------------------------------------------------

function marblelandGetFileId(%file) {
	if (strpos(expandFilename(%file), "platinum/data/missions/marbleland/") != -1) {
		%id = getSubStr(%file, strrpos(%file, "_") + 1, strrpos(%file, ".") - strrpos(%file, "_") - 1); // Thanks, Vani for this super convenient way to retrieve Ids
		return %id;
	} else {
		return "";
	}
}

function marblelandIsMission(%file) {
	if (strpos(expandFilename(%file), "platinum/data/missions/marbleland/") != -1) {
		return true;
	} else {
		return false;
	}
}

function marblelandGetMission(%id) {
	return $MarblelandMissionList.lookup[%id];
}

function marblelandHasMission(%id) {
	return isLoadedMBPackage("marbleland/" @ %id);
}

//-----------------------------------------------------------------------------

Array(MarblelandLoadedPackages);

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
	for (%i = 0; %i < MarblelandLoadedPackages.getSize(); %i++) {
		%pakName = MarblelandLoadedPackages.getEntry(%i);
		if (%pakName != %id) {
			if (isLoadedMBPackage("marbleland/" @ %pakName)) {
				unloadMBPackage("marbleland/" @ %pakName);
				loadMBPackageMis("marbleland/" @ %pakName);
			}
		}
	}
	MarblelandLoadedPackages.clear();

	if (isObject($MarblelandMissionList.lookup[%id])) {
		// Reload the one which is gonna be played
		loadMBPackage("marbleland/" @ %id);
		MarblelandLoadedPackages.addEntry(%id);
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

//-----------------------------------------------------------------------------
// RandomityGuy's weird fake LBs

function marblelandSubmit(%mission, %user, %score, %scoreType) {
	new HTTPObject(MarblelandSubmitter);
	MarblelandSubmitter.post("https://pqmarblelandlbs.vani.ga","/score", "", "mission=" @ URLEncode(%mission) @ "&username=" @ URLEncode(%user) @ "&score=" @ %score @ "&scoreType=" @ %scoreType);
}

function MarblelandSubmitter::onLine(%this, %line) {
	fwrite("platinum/json/marblelandSubmit.json", %line);
}

function MarblelandSubmitter::onDisconnect(%this) {
	%this.destroy();
}

function marblelandGetScores(%mission, %callback) {
	if (isObject(MarblelandRetriever))
		MarblelandRetriever.cancelled = true; // Cancel existing request cause bruh
	new HTTPObject(MarblelandRetriever);
	MarblelandRetriever.success = 0;
	MarblelandRetriever.mission = %mission;
	MarblelandRetriever.callback = %callback;
	MarblelandRetriever.get("https://pqmarblelandlbs.vani.ga", "/score", "mission=" @ URLEncode(%mission));
}

function MarblelandRetriever::onLine(%this, %line) {
	if (%this.cancelled)
		return;
	fwrite("platinum/json/marblelandScores.json", %line);
	%scoreData = jsonParse(%line);
	if (%this.callback !$= "") {
		call(%this.callback, true, %this.mission, %scoreData);
	}
	%this.success = 1;
}

function MarblelandRetriever::onDisconnect(%this) {
	if (!%this.success && !%this.cancelled) {
		if (%this.callback !$= "") {
			call(%this.callback, false, %this.mission, %scoreData);
		}
	}
	%this.destroy();
}