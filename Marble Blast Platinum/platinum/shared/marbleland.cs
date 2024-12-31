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

/// Download the list of missions from Marbleland
/// @param callback void(%success) Function to call upon completion
function marblelandDownloadMissionList(%callback) {
	%dl = new HTTPObject(MarblelandJSONDownloader);
	%dl.success = 0;
	%dl.callback = %callback;
	%dl.get("https://marbleland.vaniverse.io","/api/level/list","");
}

function MarblelandJSONDownloader::onLine(%this, %line) {
	echo("Loaded Marbleland MissionList");
	$MarblelandMissionList = jsonParse(%line);
	%this.success = 1;

	fwrite("platinum/json/marblelandLevels.json", %line);

	// Prepare lookup
	for (%i = 0; %i < $MarblelandMissionList.getSize(); %i++) {
		%entry = $MarblelandMissionList.getEntry(%i);
		$MarblelandMissionList.lookup[%entry.id] = %entry;

		%missionId = %entry.id;
		%misname = strreplace(%entry.baseName, ".mis", "") @ "_" @ %missionId @ ".mis";
		%entry.file = "platinum/data/missions/marbleland/" @ %misname;
		%entry.searchName = stripChars(strlwr(trim(%entry.name)), '\n\t');
	}

	if ($marblelandArg !$= "") {
		if (marblelandGetMission($marblelandArg) !$= "") {
			%entry = marblelandGetMission($marblelandArg);
			RootGui.setContent(LoadingGui);
			schedule(1000, 0, menuLoadStartMission, %entry.file);
			$marblelandArg = "";
		}
	}
}

function MarblelandJSONDownloader::onDisconnect(%this) {
	if (%this.callback !$= "") {
		schedule(100, 0, %this.callback, %this.success);
	}
	%this.destroy();
}

//-----------------------------------------------------------------------------

/// Download the list of packs from Marbleland
/// @param callback void(%success) Function to call upon completion
function marblelandDownloadPackList(%callback) {
	%dl = new HTTPObject(MarblelandPacksJSONDownloader);
	%dl.success = 0;
	%dl.callback = %callback;
	%dl.get("https://marbleland.vaniverse.io","/api/pack/list","");
}

function MarblelandPacksJSONDownloader::onLine(%this, %line) {
	echo("Loaded MarblelandPacks MissionList");
	$MarblelandPackList = jsonParse(%line);
	%this.success = 1;

	fwrite("platinum/json/marblelandPacks.json", %line);

	// Prepare lookup
	for (%i = 0; %i < $MarblelandPackList.getSize(); %i++) {
		%entry = $MarblelandPackList.getEntry(%i);
		%entry.searchName = stripChars(strlwr(trim(%entry.name)), '\n\t');
		%entry.searchArtist = strlwr(trim(%entry.createdBy.username));
		$MarblelandPackList.lookup[%entry.id] = %entry;
	}
}

function MarblelandPacksJSONDownloader::onDisconnect(%this) {
	if (%this.callback !$= "") {
		schedule(100, 0, %this.callback, %this.success);
	}
	%this.destroy();
}

//-----------------------------------------------------------------------------

/// Download a specific level's mbpak
/// @param id Level ID
/// @param callback void(%id, %success) Function to call upon completion
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
	%dl.get("https://marbleland.vaniverse.io", "/api/level/" @ %mission.id @ "/mbpak", "assuming=none&append-id-to-mis=1");
}

function MarblelandDownloader::onDownload(%this, %path) {
	%this.success = 1;

	%mission = $MarblelandMissionList.lookup[%this.id];

	$pref::MarblelandMission[%this.id] = $MarblelandMissionList.lookup[%this.id].editedAt;

	deleteFile("platinum/data/missions/marbleland/" @ %mission.file @ ".cache");

	MarblelandPackages.addEntry(%this.id);
	loadMBPackageMis("marbleland/" @ %this.id);

	getMissionList("marbleland").addInstalledMission(%mission);
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

/// Download the icon for a specific level
/// @param id Level ID
/// @param callback void(%id, %success, %bmp) Function to call upon completion
/// @param bmp The bitmap object
function marblelandDownloadIcon(%id, %callback, %bmp) {
	echo("Marbleland icon: " @ %id SPC %callback);
	%mission = $MarblelandMissionList.lookup[%id];

	if (!isObject(%mission)) {
		schedule(100, 0, %callback, %id, false);
		return;
	}

	%dl = new HTTPObject(MarblelandIconDownloader);
	%dl.callback = %callback;
	%dl.id = %mission.id;
	%dl.success = 0;
	%dl.bmp = %bmp;
	%dl.setDownloadPath("vfs://marbleland/" @ %mission.id @ ".jpg");
	%dl.get("https://marbleland.vaniverse.io","/api/level/" @ %mission.id @ "/image","");
}

function MarblelandIconDownloader::onDownload(%this, %path) {
	%this.success = 1;
}

function MarblelandIconDownloader::onDisconnect(%this) {
	echo("Marbleland icon download status: " @ %this.id @ " success: " @ %this.success);
	if (%this.callback !$= "") {
		// Get out of this stack frame
		schedule(100, 0, %this.callback, %this.id, %this.success, %this.bmp);
	}
	%this.destroy();
}

/// Download the preview for a specific level
/// @param id Level ID
/// @param callback void(%id, %success, %bmp) Function to call upon completion
/// @param bmp The bitmap object
function marblelandDownloadPreview(%id, %callback, %bmp) {
	echo("Marbleland preview: " @ %id SPC %callback);
	%mission = $MarblelandMissionList.lookup[%id];

	if (!isObject(%mission)) {
		schedule(100, 0, %callback, %id, false);
		return;
	}

	%dl = new HTTPObject(MarblelandPreviewDownloader);
	%dl.callback = %callback;
	%dl.id = %mission.id;
	%dl.success = 0;
	%dl.bmp = %bmp;
	%dl.setDownloadPath("vfs://marbleland/prev-" @ %mission.id @ ".jpg");
	%dl.get("https://marbleland.vaniverse.io","/api/level/" @ %mission.id @ "/prev-image","width=" @ getWord(getResolution(), 0) @ "&height=" @ getWord(getResolution(), 1));
}

function MarblelandPreviewDownloader::onDownload(%this, %path) {
	%this.success = 1;
}

function MarblelandPreviewDownloader::onDisconnect(%this) {
	echo("Marbleland preview download status: " @ %this.id @ " success: " @ %this.success);
	if (%this.callback !$= "") {
		// Get out of this stack frame
		schedule(100, 0, %this.callback, %this.id, %this.success, %this.bmp);
	}
	%this.destroy();
}

//-----------------------------------------------------------------------------

/// Delete a level's mbpak
/// @param id Level ID
function marblelandDelete(%id) {
	MarblelandPackages.removeMatching(%id);
	unloadMBPackage("marbleland/" @ %id);
	deletePackage("marbleland/" @ %id);
}

//-----------------------------------------------------------------------------

/// Get the marbleland ID for a mission file (if it is valid)
/// @param file Mission file path
/// @return Marbleland ID, or empty string if not a marbleland mission
function marblelandGetFileId(%file) {
	if (strpos(expandFilename(%file), "platinum/data/missions/marbleland/") != -1) {
		%id = getSubStr(%file, strrpos(%file, "_") + 1, strrpos(%file, ".") - strrpos(%file, "_") - 1); // Thanks, Vani for this super convenient way to retrieve Ids
		return %id;
	} else {
		return "";
	}
}

/// Determine if a mission file is a marbleland mission
/// @param file Mission file path
/// @return True if it is a marbleland mission
function marblelandIsMission(%file) {
	if (strpos(expandFilename(%file), "platinum/data/missions/marbleland/") != -1) {
		return true;
	} else {
		return false;
	}
}

/// Get the marbleland mission info structure for a mission
/// @param id Mission ID
/// @return Info structure from the marbleland mission list
function marblelandGetMission(%id) {
	return $MarblelandMissionList.lookup[%id];
}

/// Determine if a given marbleland mission is downloaded
/// @param id Mission ID
/// @return True if that mission is downloaded
function marblelandHasMission(%id) {
	return isLoadedMBPackage("marbleland/" @ %id);
}

/// Check if a given marbleland mission needs an update
/// @param id Mission ID
/// @return True if that mission needs an update
function marblelandMissionNeedsUpdate(%id) {
	if ($pref::MarblelandMission[%id] $= "") {
		return false;
	}
	return $pref::MarblelandMission[%id] < $MarblelandMissionList.lookup[%id].editedAt;
}

/// Check if a given marbleland mission uses custom code
/// @param mission Mission ID
/// @return True if that mission uses custom code
function marblelandUsesCustomCode(%mission) {

	if (%mission.file !$= "") {
		if (marblelandIsMission(%mission.file)) {
			%missionId = marblelandGetFileId(%mission.file);
		}
	} else {
		%missionId = %mission.id;
	}
	if (marblelandGetMission(%missionId) !$= "") {
		return $MarblelandMissionList.lookup[%missionId].hasCustomCode;
	} else {
		return false;
	}
}

//-----------------------------------------------------------------------------

Array(MarblelandLoadedPackages);

/// Reload all download marbleland mission packages
function marblelandReloadMissions() {
	echo("Reloading Marbleland");
	for (%i = 0; %i < MarblelandPackages.getSize(); %i++) {
		%pakName = MarblelandPackages.getEntry(%i);
		if (!isLoadedMBPackage("marbleland/" @ %pakName)) {
			loadMBPackageMis("marbleland/" @ %pakName);
		}
	}
}

/// Unload all marbleland mission packages
function marblelandUnloadMissions() {
	echo("Unloading Marbleland");
	for (%i = 0; %i < MarblelandPackages.getSize(); %i++) {
		%pakName = MarblelandPackages.getEntry(%i);
		if (isLoadedMBPackage("marbleland/" @ %pakName)) {
			unloadMBPackage("marbleland/" @ %pakName);
		}
	}
}

/// Load (for playing) a given marbleland mission (if exists). Only 1 mission can be
/// loaded at a time, so this will also unload any previously loaded marbleland mission.
/// @param id Mission ID
/// @return True if loading was successful
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
		return true;
	}
	return false;
}

/// Refresh the UI and mission list structures for marbleland
/// Only for use on a client
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

/// Submit a score time to the marbleland leaderboards
/// @param mission file path
/// @param user Username of player
/// @param score Score value
/// @param scoreType Score type
function marblelandSubmit(%mission, %user, %score, %scoreType) {
	new HTTPObject(MarblelandSubmitter);
	MarblelandSubmitter.post("https://marbleblast.com","/pq/leader/api/Score/RecordMarblelandScore.php", "", "mission=" @ URLEncode(%mission) @ "&username=" @ URLEncode(%user) @ "&score=" @ %score @ "&scoreType=" @ %scoreType);
}

function MarblelandSubmitter::onLine(%this, %line) {
	fwrite("platinum/json/marblelandSubmit.json", %line);
}

function MarblelandSubmitter::onDisconnect(%this) {
	%this.destroy();
}

/// Get a marbleland mission's leaderboards
/// @param mission file path
/// @param callback void(%mission, %scoreData) Callback to call upon completion
function marblelandGetScores(%mission, %callback) {
	if (isObject(MarblelandRetriever))
		MarblelandRetriever.cancelled = true; // Cancel existing request cause bruh
	new HTTPObject(MarblelandRetriever);
	MarblelandRetriever.success = 0;
	MarblelandRetriever.mission = %mission;
	MarblelandRetriever.callback = %callback;
	MarblelandRetriever.get("https://marbleblast.com", "/pq/leader/api/Score/GetMarblelandScores.php", "mission=" @ URLEncode(%mission));
}

function MarblelandRetriever::onLine(%this, %line) {
	if (%this.cancelled)
		return;
	%line = restWords(restWords(%line));
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

//-----------------------------------------------------------------------------

function createMarblelandPacksMissionQueue(%pack) {
	RootGroup.add(%queue = new ScriptObject(PackQueue) {
		class = "MarblelandPacksMissionQueue";
		superClass = "MissionQueue";
		pack = %pack;
	});
	return %queue;
}

function MarblelandPacksMissionQueue::getQueueName(%this) {
	return %this.pack.name;
}

function MarblelandPacksMissionQueue::getMissionCount(%this) {
	return %this.pack.levelIds.getSize();
}

function MarblelandPacksMissionQueue::getMissionInfo(%this, %index) {
	%missionId = %this.pack.levelIds.getEntry(%index);
	%mission = marblelandGetMission(%missionId);
	return %mission;
}

function MarblelandPacksMissionQueue::onEnd(%this, %completed) {
	MissionQueue::onEnd(%this, %completed);
}

//-----------------------------------------------------------------------------

function startRandomMissionList(%count) {
	%queue = createMarblelandRandomMissionQueue(%count);
	menuPlayQueue(%queue.getId());
}

function createMarblelandRandomMissionQueue(%count) {
	%queue = new ScriptObject(MarblelandRandomMissionQueue) {
		class = "MarblelandRandomMissionQueue";
		superClass = "MissionQueue";
		count = %count;
	};
	RootGroup.add(%queue);

	%possible = Array();
	%ml = $MarblelandMissionList;
	for (%i = 0; %i < %ml.getSize(); %i ++) {
		%mis = %ml.getEntry(%i);
		if (%mis.qualifyingTime >= 60000)
			continue;
		if (%mis.goldTime >= 60000)
			continue;
		if (%mis.platinumTime >= 60000)
			continue;
		if (%mis.goldTime !$= "" && %mis.goldTime < 10000)
			continue;
		if (%mis.platinumTime !$= "" && %mis.platinumTime < 10000)
			continue;
		if (%mis.goldTime $= "" && %mis.platinumTime $= "")
			continue;
		if (%mis.gameType !$= "single")
			continue;
		if (%mis.gems > 50)
			continue;

		%possible.addEntry(%mis.id);
	}

	for (%i = 0; %i < %count; %i ++) {
		%idx = getRandom(0, %possible.getSize() - 1);
		%id = %possible.getEntry(%idx);
		%queue.missions[%i] = %id;
		%possible.removeEntry(%idx);
	}
	return %queue;
}

function MarblelandRandomMissionQueue::getQueueName(%this) {
	return %this.count @ " Random Levels";
}

function MarblelandRandomMissionQueue::getMissionCount(%this) {
	return %this.count;
}

function MarblelandRandomMissionQueue::getMissionInfo(%this, %index) {
	%mission = marblelandGetMission(%this.missions[%index]);
	return %mission;
}

function MarblelandRandomMissionQueue::isUpcomingHidden(%this) {
	return true;
}

// For RPC calls, currently used for marbleland
function onRPCLine(%line)
{
	echo("RPC Line:" SPC %line);
	%cmd = getWord(%line, 0);
	echo("RPC Command:" SPC %cmd);
	if (%cmd $= "marbleland") {
		%level = stripChars(trim(getWord(%line, 1)), "\r");

		echo("Marbleland Level:" SPC %level);
		menuDestroyServer(); // Stop whatever is preloaded so we don't crash

		if (!$Server::Hosting)
		{
			%lookup = marblelandGetMission(%level);
			if (%lookup !$= "") {
				%entry = %lookup;
				RootGui.setContent(LoadingGui);
				schedule(1000, 0, menuLoadStartMission, %entry.file);
			}
		}
		else
		{
			commandToServer('MarblelandPlay', %level);
		}
	}
}