//-----------------------------------------------------------------------------
// Mission List
//
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

function getMissionList(%type) {
	if (!isObject(MissionListGroup))
		RootGroup.add(new SimGroup(MissionListGroup));
	if (isObject($Mission::List[%type]))
		return $Mission::List[%type];

	switch$ (%type) {
	case "offline":
		%list = new ScriptObject() {
			class = "OfflineMissionList";
			superClass = "MissionList";
		};
		%list.loadGames();
	case "lb":
		%list = new ScriptObject() {
			class = "OnlineMissionList";
			superClass = "MissionList";
		};
	case "mp":
		%list = new ScriptObject() {
			class = "OnlineMissionList";
			superClass = "MissionList";
		};
	case "server":
		%list = new ScriptObject() {
			class = "OnlineMissionList";
			superClass = "MissionList";
		};
		%list.addNamespace("ServerMissionList");
	case "marbleland":
		%list = new ScriptObject() {
			class = "MarblelandMissionList";
			superClass = "MissionList";
		};
	default:
		%list = new ScriptObject() {
			class = "OfflineMissionList";
			superClass = "MissionList";
		};
	}
	MissionListGroup.add(%list);
	$Mission::List[%type] = %list;
	return %list;
}

//-----------------------------------------------------------------------------
// MissionList Interface
//-----------------------------------------------------------------------------

/// Get a newline-separated list of all available Games
/// @return List of Games in the format (Id TAB DisplayName)
function MissionList::getGameList(%this) {
	error(%this.class @ "::getGameList unimplemented!");
	return "NA" TAB "N/A";
}

/// Get a newline-separated list of all available Difficulties for a given Game
/// @param game Id of game to list
/// @return List of Difficulties in the format (Id TAB DisplayName)
function MissionList::getDifficultyList(%this, %game) {
	error(%this.class @ "::getDifficultyList unimplemented!");
	return "NA" TAB "N/A";
}

/// Determine if a given Game and Difficulty exists
/// @param game Id of game
/// @param difficulty Id of difficulty
/// @return True if that game/difficulty exists
function MissionList::hasMissionList(%this, %game, %difficulty) {
	error(%this.class @ "::hasMissionList unimplemented!");
	return false;
}

/// Generate internal mission list structures for a given Game and Difficulty.
/// This function will generate an object whose name is the return value of
/// %this.getMissionList(%game, %difficulty) and whose type is an Array() whose
/// entries are MissionInfo ScriptObjects.
/// @param game Id of game to build
/// @param difficulty Id of difficulty to build
function MissionList::buildMissionList(%this, %game, %difficulty) {
	error(%this.class @ "::buildMissionList unimplemented!");
	%list = %this.getMissionList(%game, %difficulty);
	Array(%list);
}

/// Get the path to the directory containing the mission files for a given Game and Difficulty.
/// @param game Id of game
/// @param difficulty Id of difficulty
/// @return Path of directory
function MissionList::getMissionDirectory(%this, %game, %difficulty) {
	error(%this.class @ "::getMissionDirectory unimplemented!");
	return "platinum/data/missions/custom/";
}

/// Get the path to the directory containing the icon files for a given Game and Difficulty.
/// @param game Id of game
/// @param difficulty Id of difficulty
/// @return Path of directory
function MissionList::getBitmapDirectory(%this, %game, %difficulty) {
	error(%this.class @ "::getBitmapDirectory unimplemented!");
	return "platinum/data/missions/custom/";
}

/// Get the path to the directory containing the preview images for a given Game and Difficulty.
/// @param game Id of game
/// @param difficulty Id of difficulty
/// @return Path of directory
function MissionList::getPreviewDirectory(%this, %game, %difficulty) {
	error(%this.class @ "::getPreviewDirectory unimplemented!");
	return "platinum/data/previews/custom/";
}

/// Get the forced game mode for a given Game and Difficulty. It will be enabled
/// for all levels in this regardless of if they specify it.
/// @param game Id of game
/// @param difficulty Id of difficulty
/// @return Space separated list of game modes
function MissionList::getGameMode(%this, %game, %difficulty) {
	error(%this.class @ "::getGameMode unimplemented!");
	return "";
}

/// Determine if achievements exist for this game, and therefore, if logic to update
/// them should be run.
/// @param game Id of game
/// @return True if achievements should be checked
function MissionList::shouldCheckAchievements(%this, %game) {
	error(%this.class @ "::shouldCheckAchievements unimplemented!");
	return false;
}

//-----------------------------------------------------------------------------
// General functions that apply to all the mission lists
//-----------------------------------------------------------------------------

//Get the mission list object's name.
function MissionList::getMissionList(%this, %game, %difficulty) {
	if (%game $= "") {
		error("getMissionList: blank game");
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		error("getMissionList: blank difficulty");
		%difficulty = $MissionType;
	}
	return "ML_" @ %this.getId() @ "_" @ alphaNum(%game) @ "_" @ alphaNum(%difficulty);
}

function MissionList::getGameName(%this, %search) {
	%games = %this.getGameList();
	%gcount = getRecordCount(%games);
	for (%i = 0; %i < %gcount; %i ++) {
		%game = getRecord(%games, %i);
		%gameName = getField(%game, 0);
		%gameDisplay = getField(%game, 1);
		if (%gameName $= %search) {
			return %gameDisplay;
		}
	}
	return "";
}

function MissionList::getDifficultyName(%this, %game, %search) {
	%difficulties = %this.getDifficultyList(%game);
	%dcount = getRecordCount(%difficulties);
	for (%i = 0; %i < %dcount; %i ++) {
		%difficulty = getRecord(%difficulties, %i);
		%difficultyName = getField(%difficulty, 0);
		%difficultyDisplay = getField(%difficulty, 1);
		if (%difficultyName $= %search) {
			return %difficultyDisplay;
		}
	}
	return "";
}

function MissionList::getMission(%this, %game, %difficulty, %file) {
	if (%game $= "") {
		error("getMission: blank game");
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		error("getMission: blank difficulty");
		%difficulty = $MissionType;
	}

	%list = %this.getMissionList(%game, %difficulty);
	if (!isObject(%list)) {
		%this.buildMissionList(%game, %difficulty);
	}
	for (%i = 0; %i < %list.getSize(); %i ++) {
		%mission = %list.getEntry(%i);
		if (%mission.file $= %file) {
			return %mission;
		}
	}

	return -1;
}

function MissionList::getMissionPreview(%this, %game, %difficulty, %mission) {
	%file = %mission.file;
	if (%mission.previews_directory !$= "") {
			%dir = expandFilename(%mission.previews_directory);
	} else
		%dir = expandFilename(%this.getPreviewDirectory(%game, %difficulty));

	%prev = %dir @ "/" @ fileBase(%file) @ ".prev";
	//Old style that's easier to ship
	if (!isBitmap(%prev)) {
		%prev = filePath(%file) @ "/" @ fileBase(%file) @ ".prev";
	}

	return %prev;
}

function MissionList::getDifficultyTreeNode(%this, %game, %path) {
	return TreeGet(%this.getDifficultyTree(%game), %path);
}

function MissionList::buildDifficultyTreeRecurse(%this, %root, %array) {
	%count = %array.getSize();
	//This will have missions if the last item is not an array
	if (%count > 0 && (%array.getEntry(%count - 1).class !$= "Array")) {
		%title = (%array.title $= "" ? %array.name : %array.title);
		%this.difficultyTreeList = addRecord(%this.difficultyTreeList, TreePath(%root, %array) TAB %title);
	}

	for (%i = 0; %i < %count; %i ++) {
		%obj = %array.getEntry(%i);
		if (isObject(%obj) && (%obj.class $= "Array")) {
			%this.buildDifficultyTreeRecurse(%root, %obj);
		}
	}
}

function MissionList::dumpMissions(%this) {
	%games = %this.getGameList();
	%gcount = getRecordCount(%games);
	for (%i = 0; %i < %gcount; %i ++) {
		%game = getRecord(%games, %i);
		%gameName = getField(%game, 0);
		echo("Game " @ %game @ ":");

		%difficulties = %this.getDifficultyList(%gameName);
		%dcount = getRecordCount(%difficulties);
		for (%j = 0; %j < %dcount; %j ++) {
			%difficulty = getRecord(%difficulties, %j);
			%difficultyName = getField(%difficulty, 0);
			echo("   Difficulty " @ %difficulty @ ":");
			%this.buildMissionList(%gameName, %difficultyName);

			%missions = %this.getMissionList(%gameName, %difficultyName);
			for (%k = 0; %k < %missions.getSize(); %k ++) {
				%mission = %missions.getEntry(%k);
				echo("      Mission " @ %mission.name @ " (obj " @ %mission @ ")");
			}
		}
	}
}

//-----------------------------------------------------------------------------
// Strictly offline SP mission list
//-----------------------------------------------------------------------------

function OfflineMissionList::loadGames(%this) {
	%this.games = Array(OfflineMissionListGames);

	%pattern = "platinum/data/games/*.json";
	for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
		echo("OfflineMissionList :: Read game: " @ %file);
		%game = jsonParse(fread(%file));

		%this.games.addEntry(%game);
		%this.game[%game.name] = %game;

		if (!%game.custom) {
			for (%j = 0; %j < %game.difficulties.getSize(); %j ++) {
				%difficulty = %game.difficulties.getEntry(%j);

				%this.difficulty[%game.name, %difficulty.name] = %difficulty;
			}
		}
	}
	%this.games.sort(compareMissionListGame);

	//Since we expect these to not change, do this stuff ahead of time
	%this.gameList = "";
	for (%i = 0; %i < %this.games.getSize(); %i ++) {
		%game = %this.games.getEntry(%i);
		%this.gameList = addRecord(%this.gameList, %game.name TAB %game.display);

		echo("OfflineMissionList :: Register game " @ %game.display);

		if (!%game.custom) {
			%this.difficultyList[%game.name] = "";
			for (%j = 0; %j < %game.difficulties.getSize(); %j ++) {
				%difficulty = %game.difficulties.getEntry(%j);
				%this.difficultyList[%game.name] = addRecord(%this.difficultyList[%game.name], %difficulty.name TAB %difficulty.display);

				echo("OfflineMissionList :: Register difficulty " @ %game.display @ "/" @ %difficulty.display);
			}
		}
	}
}

function compareMissionListGame(%a, %b) {
	return %a.order < %b.order;
}

function OfflineMissionList::getGameList(%this) {
	return %this.gameList;
}

function OfflineMissionList::getDifficultyList(%this, %game) {
	if (%game $= "") {
		error("getDifficultyList: blank game");
		%game = $CurrentGame;
	}

	if (%this.game[%game].custom) {
		%diffTree = %this.getDifficultyTree(%game);
		%this.difficultyTreeList = "";
		%this.buildDifficultyTreeRecurse(%diffTree, %diffTree);
		return %this.difficultyTreeList;
	}

	return %this.difficultyList[%game];
}

function OfflineMissionList::shouldUseDifficultyTree(%this, %game) {
	return %game $= "Custom";
}

function OfflineMissionList::getDifficultyTree(%this, %game) {
	if (!isObject(%this.customDifficultyTree)) {
		return %this.buildCustomDifficultyTree();
	}
	return %this.customDifficultyTree;
}

function OfflineMissionList::buildCustomDifficultyTree(%this) {
	%difficulties = TreeNode();

	//Get custom levels for specific games first
	for (%i = 0; %i < %this.games.getSize(); %i ++) {
		%game = %this.games.getEntry(%i);

		if (!%game.custom) {
			for (%j = 0; %j < %game.customPaths.getSize(); %j ++) {
				%dir = %game.customPaths.getEntry(%j);

				%pattern = %dir @ "/*";
				for (%file = findFirstMission(%pattern); %file !$= ""; %file = findNextMission(%pattern)) {
					if (strpos(%file, "__MACOSX") != -1 || strpos(%file, "/._") != -1) {
						//macOS extended attributes break things
						continue;
					}
					//Gold/platinum/data/missions/thing/dir/
					%node = TreeBuild(%difficulties, %name);
					%node.title = %display;
					%node.dir = %dir;

					%info = getMissionInfo(%file, true);
					//If a zip file overwrites a mission you can get two missions with the same path... this prevents that
					if (!%node.containsEntry(%info)) {
						%node.addEntry(%info);
					}
				}
			}
		}
	}

	%custom = TreeBuild(%difficulties, "Custom");

	//Then try the other directories
	for (%i = 0; %i < %this.games.getSize(); %i ++) {
		%game = %this.games.getEntry(%i);

		if (%game.custom) {
			for (%j = 0; %j < %game.customPaths.getSize(); %j ++) {
				%dir = %game.customPaths.getEntry(%j);

				%pattern = %dir @ "/*";
				for (%file = findFirstMission(%pattern); %file !$= ""; %file = findNextMission(%pattern)) {
					if (strpos(%file, "__MACOSX") != -1 || strpos(%file, "/._") != -1) {
						//macOS extended attributes break things
						continue;
					}
					//platinum/data/missions/thing/dir/
					%dir = filePath(%file);

					%node = TreeBuild(%custom, %dir);
					%node.dir = %dir;

					%info = getMissionInfo(%file, true);

					//If a zip file overwrites a mission you can get two missions with the same path... this prevents that
					if (!%node.containsEntry(%info)) {
						%node.addEntry(%info);
					}
					if (!%custom.containsEntry(%info)) {
						%custom.addEntry(%info);
					}
				}
			}
		}
	}
	recurseSort(%custom, sortNameOrArray);

	%this.customDifficultyTree = %difficulties;

	return %this.customDifficultyTree;
}

function OfflineMissionList::getMissionDirectory(%this, %game, %difficulty) {
	if (%game $= "") {
		error("getMissionDirectory: blank game");
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		error("getMissionDirectory: blank difficulty");
		%difficulty = $MissionType;
	}
	if (%this.game[%game].custom) {
		%node = %this.getDifficultyTreeNode(%game, %difficulty);
		return %node.dir;
	}
	return %this.difficulty[%game, %difficulty].missionDirectory;
}

function OfflineMissionList::getBitmapDirectory(%this, %game, %difficulty) {
	if (%game $= "") {
		error("getBitmapDirectory: blank game");
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		error("getBitmapDirectory: blank difficulty");
		%difficulty = $MissionType;
	}
	if (%this.game[%game].custom) {
		%node = %this.getDifficultyTreeNode(%game, %difficulty);
		return %node.dir;
	}
	return %this.difficulty[%game, %difficulty].bitmapDirectory;
}

function OfflineMissionList::getPreviewDirectory(%this, %game, %difficulty) {
	if (%game $= "") {
		error("getPreviewDirectory: blank game");
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		error("getPreviewDirectory: blank difficulty");
		%difficulty = $MissionType;
	}
	if (%this.game[%game].custom) {
		%node = %this.getDifficultyTreeNode(%game, %difficulty);
		return %node.dir;
	}
	return %this.difficulty[%game, %difficulty].previewDirectory;
}

function OfflineMissionList::buildMissionList(%this, %game, %difficulty) {
	if (%game $= "") {
		error("buildMissionList: blank game");
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		error("buildMissionList: blank difficulty");
		%difficulty = $MissionType;
	}

	//Mission list name
	%list = %this.getMissionList(%game, %difficulty);

	//We need to delete the list if we have one already
	if (isObject(%list)) {
		%list.delete();
	}
	//Create the list
	%list = Array(%list);
	MissionListGroup.add(%list);

	if (%this.game[%game].custom) {
		%node = %this.getDifficultyTreeNode(%game, %difficulty);
		%count = %node.getSize();
		for (%i = 0; %i < %count; %i ++) {
			%entry = %node.getEntry(%i);
			//Don't add sub-arrays
			if (%entry.class $= "Array") {
				continue;
			}
			%list.addEntry(%entry);
		}

		//Sort the list by level
		%list.sort(MissionSortName);
	} else {
		%dir = %this.getMissionDirectory(%game, %difficulty);
		//Preload all MCS files first because otherwise rebuilding the hash tables will take forever
		$loadingMissionInfo = true;
		for (%file = findFirstMission(%dir @ "/*"); %file !$= ""; %file = findNextMission(%dir @ "/*")) {
			if (strpos(%file, "__MACOSX") != -1 || strpos(%file, "/._") != -1) {
				//macOS extended attributes break things
				continue;
			}
			if (fileExt(%file) $= ".mcs") {
				exec(%file);
			}
		}
		$loadingMissionInfo = false;

		//Find all the maps in the level directory
		for (%file = findFirstMission(%dir @ "/*"); %file !$= ""; %file = findNextMission(%dir @ "/*")) {
			if (strpos(%file, "__MACOSX") != -1 || strpos(%file, "/._") != -1) {
				//macOS extended attributes break things
				continue;
			}
			//Get the file's info
			%info = getMissionInfo(%file, true);

			//Didn't load, don't show it
			if (!isObject(%info))
				continue;

			//And put it in the list
			%list.addEntry(%info);
		}
		//Sort the list by level
		%list.sort(MissionSortLevel);
	}
}

function OfflineMissionList::hasMissionList(%this, %game, %difficulty) {
	if (%this.game[%game].custom) {
		%node = %this.getDifficultyTreeNode(%game, %difficulty);
		if (!isObject(%node)) {
			return false;
		}
		%count = %node.getSize();
		//This will have missions if the last item is not an array
		return (%count > 0 && (%node.getEntry(%count - 1).class !$= "Array"));
	}
	return findFirstMission(%this.getMissionDirectory(%game, %difficulty) @ "/*") !$= "";
}

//Offline mission lists don't do game modes
function OfflineMissionList::getGameMode(%this, %game) {
	return "";
}

function OfflineMissionList::shouldCheckAchievements(%this, %game) {
	// Everything but custom
	return (%game !$= "Custom");
}

//-----------------------------------------------------------------------------
// Server-controlled game, difficulty, and mission lists
//-----------------------------------------------------------------------------

function OnlineMissionList::setOnlineMissionList(%this, %list) {
	//Since it was being put into MissionCleanup
	RootGroup.add(%list);

	//Don't overwrite our current mission list
	if (isObject(%this.onlineMissionList)) {
		return false;
	}

	%this.onlineMissionList = %list;
	%this.buildMissionLookup();

	return true;
}

function OnlineMissionList::buildMissionLookup(%this) {
	//Build a lookup list of all game and difficulty names and ids so we can
	// get their JSONObjects with only the id or name

	%games = %this.onlineMissionList.games;
	for (%i = 0; %i < %games.getSize(); %i ++) {
		%game = %games.getEntry(%i);
		%gameId = %game.id;

		%this.lookupGame[%game.id] = %game;
		%this.lookupGame[%game.name] = %game;

		%difficulties = %game.difficulties;
		for (%j = 0; %j < %difficulties.getSize(); %j ++) {
			%difficulty = %difficulties.getEntry(%j);
			%difficultyId = %difficulty.id;

			%this.lookupDifficulty[%difficulty.id] = %difficulty;
			%this.lookupDifficulty[%game.name, %difficulty.name] = %difficulty;

			%missions = %difficulty.missions;
			for (%k = 0; %k < %missions.getSize(); %k ++) {
				%mission = %missions.getEntry(%k);
				if (%game.name !$= "challenge") {
					%this.lookupMission[%mission.basename] = %mission;
					%this.lookupMission[%mission.id] = %mission;
					%this.lookupMission[%mission.file] = %mission;
				} else {
					%this.lookupMission[%mission.basename, "challenge"] = %mission;
					%this.lookupMission[%mission.id] = %mission;
					%this.lookupMission[%mission.file, "challenge"] = %mission;
				}
				%mission.difficultyId = %difficultyId;
				%mission.gameId = %gameId;
			}
		}
	}
}

function OnlineMissionList::shouldUseDifficultyTree(%this, %game) {
	return false;
}

function OnlineMissionList::getGameList(%this) {
	//List of all games
	%games = %this.onlineMissionList.games;
	%list = "";
	for (%i = 0; %i < %games.getSize(); %i ++) {
		%id = %games.getEntry(%i).id;
		//Convert ids to names
		%name = %this.lookupGame[%id].name;
		%display = %this.lookupGame[%id].display;

		%list = addRecord(%list, %name TAB %display);
	}

	return %list;
}

function OnlineMissionList::getDifficultyList(%this, %gameName) {
	if (%gameName $= "") {
		%gameName = $CurrentGame;
	}

	//Id of the current game for finding the right difficulty
	%game = %this.lookupGame[%gameName];

	//All the difficulties for this game
	%difficulties = %game.difficulties;

	%list = "";
	for (%i = 0; %i < %difficulties.getSize(); %i ++) {
		//Add to list
		%difficulty = %difficulties.getEntry(%i);
		%list = addRecord(%list, %difficulty.name TAB %difficulty.display);
	}

	return %list;
}

function OnlineMissionList::getMissionDirectory(%this, %game, %difficulty) {
	if (%game $= "") {
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		%difficulty = $MissionType;
	}

	return %this.lookupDifficulty[%game, %difficulty].directory;
}

function OnlineMissionList::getBitmapDirectory(%this, %game, %difficulty) {
	if (%game $= "") {
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		%difficulty = $MissionType;
	}

	return %this.lookupDifficulty[%game, %difficulty].bitmap_directory;
}

function OnlineMissionList::getPreviewDirectory(%this, %game, %difficulty) {
	if (%game $= "") {
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		%difficulty = $MissionType;
	}

	return %this.lookupDifficulty[%game, %difficulty].previews_directory;
}

function OnlineMissionList::buildMissionList(%this, %game, %difficulty) {
	if (%game $= "") {
		%game = $CurrentGame;
	}
	if (%difficulty $= "") {
		%difficulty = $MissionType;
	}

	//Current list
	%difficultyObj = %this.lookupDifficulty[%game, %difficulty];
	%gameObj = %this.lookupGame[%game];

	if (%difficultyObj.is_local) {
		OfflineMissionList::buildMissionList(%this, %game, %difficulty);
		%list = %this.getMissionList(%game, %difficulty);

		//Fix level numbers
		%count = %list.getSize();
		for (%i = 0; %i < %count; %i ++) {
			%mission = %list.getEntry(%i);
			if (%mission.id !$= "") {
				//Double feature lmao
				continue;
			}
			%mission.is_custom = 1;
			%mission.gameId = %difficultyObj.game_id;
			%mission.difficultyId = %difficultyObj.id;
			%mission.easterEgg |= %mission.has_egg;
			%mission.downloaded = true;
		}

		%list.sort(MissionSortName);
	} else {
		//Mission list name
		%list = %this.getMissionList(%game, %difficulty);

		//We need to delete the list if we have one already
		if (isObject(%list)) {
			%list.delete();
		}
		//Create the list
		%list = Array(%list);
		MissionListGroup.add(%list);

		//For the LB, use the server's sorting for the missions
		%missionList = %difficultyObj.missions;

		//Preload all MCS files first because otherwise rebuilding the hash tables will take forever
		$loadingMissionInfo = true;
		for (%i = 0; %i < %missionList.getSize(); %i ++) {
			%missionObj = %missionList.getEntry(%i);
			%file = %missionObj.file;

			if (fileExt(%file) $= ".mcs") {
				if (isScriptFile(%file)) {
					exec(%file);
				}
			}
		}
		$loadingMissionInfo = false;

		//Use its list instead of searching for files
		for (%i = 0; %i < %missionList.getSize(); %i ++) {
			%missionObj = %missionList.getEntry(%i);
			%file = %missionObj.file;

			//Use the local .mis if we can, otherwise create a shell mission
			if (isScriptFile(%file)) {
				%info = getMissionInfo(%file, true);
				%info.downloaded = true;

				if (%info.is_custom) {
					//Double feature lmao
					%info.is_custom = false;
				}

				//So this lines up with what torque expects
				%missionObj.level = %missionObj.number;

				//Update with info from the server
				%fields = %missionObj.getDynamicFieldList();
				%count = getFieldCount(%fields);
				for (%j = 0; %j < %count; %j ++) {
					%field = getField(%fields, %j);
					%info.setFieldValue(%field, %missionObj.getFieldValue(%field));
				}

				//Inherit these
				%info.game = %game;
				%info.type = %difficulty;

				//Inherit game blast settings if we don't have one defined
				if (%info.blast $= "" && %info.noBlast $= "") {
					if (%gameObj.has_blast) {
						%info.blast = 1;
					} else {
						%info.noBlast = 1;
					}
				}

				//Because this is too slow to calculate
				if (%missionObj.has_egg) {
					%info.easterEgg = true;
				}

				//CRC BABYYY
				// %hash = getMissionHash(%info);
				// if (%hash $= %missionObj.hash) {
				// 	echo("Matched hash: " @ %missionObj SPC %info SPC %info.name);
				// } else {
				// 	error("Unmatched hash: " @ %missionObj SPC %info SPC %info.name);
				// }
			} else {
				//You don't have it? Just put an empty mission there instead
				MissionInfoGroup.add(%info = new ScriptObject() {
					name = %missionObj.name;
					level = %missionObj.number;
					game = %game;
					type = %difficulty;

					gameId = %missionObj.gameId;
					difficultyId = %missionObj.difficultyId;
					easterEgg = %missionObj.has_egg;
					id = %missionObj.id;

					previews_directory = %missionObj.previews_directory;
					bitmap_directory = %missionObj.bitmap_directory;

					file = %file;
					downloaded = false;
					partial = true;
				});
				$Mission::Info[%file] = %info;
			}

			%list.addEntry(%info);
		}
	}

	//Fix level numbers
	%count = %list.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%list.getEntry(%i).level = %i + 1;
	}
}

function OnlineMissionList::hasMissionList(%this, %game, %difficulty) {
	return findFirstMission(%this.getMissionDirectory(%game, %difficulty) @ "/*") !$= "";
}

function OnlineMissionList::getGameMode(%this, %game) {
	if (%game $= "") {
		%game = $CurrentGame;
	}
	%gameObj = %this.lookupGame[%game];
	%mode = %gameObj.force_gamemode;
	if (%mode $= "challenge") {
		setWeeklyChallenge(%gameObj.challenge);
	}
	return %mode;
}

function OnlineMissionList::getMissionById(%this, %id) {
	%games = %this.onlineMissionList.games;
	for (%i = 0; %i < %games.getSize(); %i ++) {
		%game = %games.getEntry(%i);
		%gameName = %game.name;
		%difficulties = %game.difficulties;
		for (%j = 0; %j < %difficulties.getSize(); %j ++) {
			%difficulty = %difficulties.getEntry(%j);
			%difficultyName = %difficulty.name;

			%ml = %this.getMissionList(%gameName, %difficultyName);
			if (!isObject(%ml)) {
				%this.buildMissionList(%gameName, %difficultyName);
			}

			%missions = %difficulty.missions;
			for (%k = 0; %k < %missions.getSize(); %k ++) {
				%mission = %missions.getEntry(%k);
				%info = %ml.getEntry(%k);
				if (%info.id == %id) {
					return %info;
				}
			}
		}
	}
}

function OnlineMissionList::dumpMissions(%this) {
	%games = %this.onlineMissionList.games;
	for (%i = 0; %i < %games.getSize(); %i ++) {
		%game = %games.getEntry(%i);
		%gameName = %game.name;
		echo("Game " @ %game.display @ " (obj " @ %game @ "):");

		%difficulties = %game.difficulties;
		for (%j = 0; %j < %difficulties.getSize(); %j ++) {
			%difficulty = %difficulties.getEntry(%j);
			%difficultyName = %difficulty.name;
			echo("   Difficulty " @ %difficulty.display @ " (obj " @ %difficulty @ "):");
			%this.buildMissionList(%gameName, %difficultyName);

			%missions = %difficulty.missions;
			for (%k = 0; %k < %missions.getSize(); %k ++) {
				%mission = %missions.getEntry(%k);
				%info = %this.getMissionList(%gameName, %difficultyName).getEntry(%k);
				echo("      Mission " @ %mission.name @ " id " @ %mission.id @ " (obj " @ %mission @ ", info " @ %info @ ")");
			}
		}
	}
}

function OnlineMissionList::clearOnlineCache(%this) {
	//Clean up the mission list itself
	%this.onlineMissionList.recurseDelete();

	//Clean up any mission SimGroups
	for (%i = 0; %i < MissionListGroup.getCount(); %i ++) {
		%group = MissionListGroup.getObject(%i);
		if (stristr(%group.getName(), %this.getId()) != -1) {
			%group.recurseDelete();
			%i --;
		}
	}
	%this.recurseDelete();
}

function OnlineMissionList::shouldCheckAchievements(%this, %game) {
	return true;
}


//-----------------------------------------------------------------------------
// Multiplayer Mission List is a little weirder
//-----------------------------------------------------------------------------

function ServerMissionList::clear(%this) {
	//Clean up any mission SimGroups
	for (%i = 0; %i < MissionListGroup.getCount(); %i ++) {
		%group = MissionListGroup.getObject(%i);
		if (stristr(%group.getName(), %this.getId()) != -1) {
			%group.recurseDelete();
			%i --;
		}
	}

	%this.gameList = "";
	%this.difficultyList = "";
}

function ServerMissionList::addGame(%this, %gameName, %gameDisplay) {
	devecho(%this SPC "addGame:" SPC %gameName SPC %gameDisplay);
	%this.gameList = addRecord(%this.gameList, %gameName TAB %gameDisplay);
	%this.difficultyList[%gameName] = "";
}

function ServerMissionList::addDifficulty(%this, %gameName, %difficultyName, %difficultyDisplay, %directory, %bitmapDir, %previewDir, %gameMode) {
	devecho(%this SPC "addDifficulty:" SPC %gameName SPC %difficultyName SPC %difficultyDisplay);
	%this.difficultyList[%gameName] = addRecord(%this.difficultyList[%gameName], %difficultyName TAB %difficultyDisplay);
	%this.difficulty[%gameName, %difficultyName, "Directory"] = %directory;
	%this.difficulty[%gameName, %difficultyName, "BitmapDir"] = %bitmapDir;
	%this.difficulty[%gameName, %difficultyName, "PreviewDir"] = %previewDir;
	%this.difficulty[%gameName, %difficultyName, "GameMode"] = %gameMode;
	%this.missionListLoaded[%gameName, %difficultyName] = false;
	%this.missionListLoading[%gameName, %difficultyName] = false;
}

function ServerMissionList::addMission(%this, %gameName, %difficultyName, %info) {
	MissionInfoGroup.add(%mission = new ScriptObject());
	%mission.setFields(%info);
	devecho(%this SPC "addMission:" SPC %gameName SPC %difficultyName SPC %mission);

	//Cache the info for this mission so we don't try to getMissionInfo() it later
	if (!isFile(%mission.file)) {
		$Mission::Info[%mission.file] = %mission;
	}

	%list = MissionList::getMissionList(%this, %gameName, %difficultyName);
	devecho("List is " @ %list);
	%list.addEntry(%mission);
}

function ServerMissionList::clearMisisons(%this, %gameName, %difficultyName) {
	if (isObject(%this.missionList[%gameName, %difficultyName])) {
		%this.missionList[%gameName, %difficultyName].delete();
	}
	%list = Array(MissionList::getMissionList(%this, %gameName, %difficultyName));
	%this.missionList[%gameName, %difficultyName] = %list;
	%this.missionListLoaded[%gameName, %difficultyName] = false;

	MissionListGroup.add(%list);
}

function ServerMissionList::doneMissions(%this, %gameName, %difficultyName) {
	%this.missionListLoaded[%gameName, %difficultyName] = true;
}

function ServerMissionList::getGameList(%this) {
	//List of all games
	return %this.gameList;
}

function ServerMissionList::shouldUseDifficultyTree(%this, %game) {
	return false;
}

function ServerMissionList::getDifficultyList(%this, %gameName) {
	if (%gameName $= "") {
		%gameName = $CurrentGame;
	}
	//List of all difficulties
	return %this.difficultyList[%gameName];
}

function ServerMissionList::getMissionDirectory(%this, %gameName, %difficultyName) {
	if (%gameName $= "") {
		%gameName = $CurrentGame;
	}
	if (%difficultyName $= "") {
		%difficultyName = $MissionType;
	}
	return %this.difficulty[%gameName, %difficultyName, "Directory"];
}

function ServerMissionList::getBitmapDirectory(%this, %gameName, %difficultyName) {
	if (%gameName $= "") {
		%gameName = $CurrentGame;
	}
	if (%difficultyName $= "") {
		%difficultyName = $MissionType;
	}
	return %this.difficulty[%gameName, %difficultyName, "BitmapDir"];
}

function ServerMissionList::getPreviewDirectory(%this, %gameName, %difficultyName) {
	if (%gameName $= "") {
		%gameName = $CurrentGame;
	}
	if (%difficultyName $= "") {
		%difficultyName = $MissionType;
	}
	return %this.difficulty[%gameName, %difficultyName, "PreviewDir"];
}

function ServerMissionList::getGameMode(%this, %gameName, %difficultyName) {
	if (%gameName $= "") {
		%gameName = $CurrentGame;
	}
	if (%difficultyName $= "") {
		%difficultyName = $MissionType;
	}
	return %this.difficulty[%gameName, %difficultyName, "GameMode"];
}

function ServerMissionList::hasMissionList(%this, %gameName, %difficultyName) {
	return true; //Sure we do
}

function ServerMissionList::getMissionList(%this, %gameName, %difficultyName) {
	if (%gameName $= "") {
		%gameName = $CurrentGame;
	}
	if (%difficultyName $= "") {
		%difficultyName = $MissionType;
	}
	if (!%this.missionListLoaded[%gameName, %difficultyName]) {
		//Hey we should try stealing it from the server copy... great idea
		%list = getMissionList("mp").getMissionList(%gameName, %difficultyName);
		if (!isObject(%list)) {
			//Wow even that one isn't ready
			getMissionList("mp").buildMissionList(%gameName, %difficultyName);
		}

		//Ask our server for the list, but only once please
		if (!%this.missionListLoading[%gameName, %difficultyName]) {
			%this.missionListLoading[%gameName, %difficultyName] = true;
			devecho("Need to get " @ %gameName SPC %difficultyName);
			//Get to wait for the server to send it
			commandToServer('GetMissionList', %gameName, %difficultyName);
		}

		return %list;
	}
	return MissionList::getMissionList(%this, %gameName, %difficultyName);
}

function ServerMissionList::buildMissionList(%this, %gameName, %difficultyName) {
	if (!%this.missionListLoaded[%gameName, %difficultyName]) {
		if (!%this.missionListLoading[%gameName, %difficultyName]) {
			%this.missionListLoading[%gameName, %difficultyName] = true;
			devecho("Need to get " @ %gameName SPC %difficultyName);
			//Get to wait for the server to send it
			commandToServer('GetMissionList', %gameName, %difficultyName);
		}
	}
}

function ServerMissionList::shouldCheckAchievements(%this, %game) {
	return false;
}

//-----------------------------------------------------------------------------

function MarblelandMissionList::getGameList(%this) {
	return "Levels\tLevels" NL
	       "Packs\tPacks";
}

function MarblelandMissionList::getDifficultyList(%this, %game) {
	switch$ (%game) {
	case "Levels":
		return "All\tAlphabetical" NL
		       "Newest\tNewest First" NL
			   "Installed\tInstalled Only";
	case "Packs":
		%diffTree = %this.getDifficultyTree(%game);
		%this.difficultyTreeList = "";
		%this.buildDifficultyTreeRecurse(%diffTree, %diffTree);
		return %this.difficultyTreeList;
	}
}

function MarblelandMissionList::getDifficultyTree(%this, %game) {
	switch$ (%game) {
	case "Packs":
		if (!isObject(%this.packsTree)) {
			%this.packsTree = TreeNode();

			%packs = Array();
			for (%i = 0; %i < $MarblelandPackList.getSize(); %i++) {
				%pack = $MarblelandPackList.getEntry(%i);
				%node = TreeBuild(%this.packsTree, %pack.name);
				%node.pack = %pack;
				%node.id = %pack.id;

				for (%j = 0; %j < %pack.levelIds.getSize(); %j ++) {
					%levelId = %pack.levelIds.getEntry(%j);

					%mis = marblelandGetMission(%levelId);

					MissionInfoGroup.add(%info = new ScriptObject() {
						name = %mis.name;
						level = %i;
						game = %mis.modification;
						type = "Custom";
						desc = %mis.desc;
						artist = %mis.artist;
						gameMode = %mis.gameMode;

						// I was going to complain about this but actually it's pretty smart
						goldTime = %mis.goldTime;
						platinumTime = %mis.platinumTime;
						ultimateTime = %mis.ultimateTime;
						awesomeTime = %mis.awesomeTime;
						goldScore = %mis.goldScore;
						platinumScore = %mis.platinumScore;
						ultimateScore = %mis.ultimateScore;
						awesomeScore = %mis.awesomeScore;

						gems = %mis.gems;

						easterEgg = %mis.hasEasterEgg;
						id = %mis.id;

						hasCustomCode = marblelandUsesCustomCode(%mis);
						requirements = (marblelandUsesCustomCode(%mis) ? "Play the level Offline as it uses custom code.": "");

						file = %mis.file;
						searchName = %mis.searchName;
						addedAt = %mis.addedAt;
						downloaded = false;
						partial = true;
					});
					%node.addEntry(%info);
				}
			}
			recurseSort(%this.packsTree, sortIndexOrArray);
			%this.packsTree.sort(sortNameOrArray);
		}
		return %this.packsTree;
	}
}

function MarblelandMissionList::hasMissionList(%this, %game, %difficulty) {
	switch$ (%game) {
	case "Levels":
		switch$ (%difficulty) {
		case "All":
			return true;
		case "Newest":
			return true;
		case "Installed":
			return true;
		default:
			return false;
		}
	case "Packs":
		return isObject(%this.getDifficultyTreeNode(%game, %difficulty));
	default:
		return false;
	}
}

function MarblelandMissionList::buildMissionList(%this, %game, %difficulty) {
	%list = %this.getMissionList(%game, %difficulty);
	if (isObject(%list)) {
		%list.delete();
	}
	Array(%list);

	%sort = MissionSortSearchName;
	switch$ (%game) {
	case "Levels":
		switch$ (%difficulty) {
		case "All":
			%ml = $MarblelandMissionList;
			%sort = MissionSortSearchName;
		case "Newest":
			%ml = $MarblelandMissionList;
			%sort = MissionSortNewest;
		case "Installed":
			%ml = MarblelandPackages;
		}
	case "Packs":
		%ml = %this.getDifficultyTreeNode(%game, %difficulty);
		%sort = MissionSortLevel;
	}

	for (%i = 0; %i < %ml.getSize(); %i ++) {
		%mis = %ml.getEntry(%i);

		if (%game $= "Levels" && %difficulty $= "Installed") {
			%mis = marblelandGetMission(%mis); // MarblelandPackages has an id
		}

		if (%mis.class $= "Array") {
			continue;
		}

		MissionInfoGroup.add(%info = new ScriptObject() {
			name = %mis.name;
			level = %i;
			game = %mis.modification;
			type = "Custom";
			desc = %mis.desc;
			artist = %mis.artist;
			gameMode = %mis.gameMode;

			// I was going to complain about this but actually it's pretty smart
			goldTime = %mis.goldTime;
			platinumTime = %mis.platinumTime;
			ultimateTime = %mis.ultimateTime;
			awesomeTime = %mis.awesomeTime;
			goldScore = %mis.goldScore;
			platinumScore = %mis.platinumScore;
			ultimateScore = %mis.ultimateScore;
			awesomeScore = %mis.awesomeScore;

			gems = %mis.gems;

			easterEgg = %mis.hasEasterEgg;
			id = %mis.id;

			hasCustomCode = marblelandUsesCustomCode(%mis);
			requirements = (marblelandUsesCustomCode(%mis) ? "Play the level Offline as it uses custom code.": "");

			file = %mis.file;
			searchName = %mis.searchName;
			addedAt = %mis.addedAt;
			downloaded = false;
			partial = true;
		});
		%list.addEntry(%info);
	}
	%list.sort(%sort);

	//Fix level numbers
	%count = %list.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%list.getEntry(%i).level = %i + 1;
	}
}

function MarblelandMissionList::addInstalledMission(%this, %mis) {
	%list = %this.getMissionList("Levels", "Installed");
	if (isObject(%list)) {
		MissionInfoGroup.add(%info = new ScriptObject() {
			name = %mis.name;
			level = %list.getSize();
			game = %mis.modification;
			type = "Custom";
			desc = %mis.desc;
			artist = %mis.artist;
			gameMode = %mis.gameMode;

			// I was going to complain about this but actually it's pretty smart
			goldTime = %mis.goldTime;
			platinumTime = %mis.platinumTime;
			ultimateTime = %mis.ultimateTime;
			awesomeTime = %mis.awesomeTime;
			goldScore = %mis.goldScore;
			platinumScore = %mis.platinumScore;
			ultimateScore = %mis.ultimateScore;
			awesomeScore = %mis.awesomeScore;

			gems = %mis.gems;

			easterEgg = %mis.hasEasterEgg;
			id = %mis.id;

			hasCustomCode = marblelandUsesCustomCode(%mis);
			requirements = (marblelandUsesCustomCode(%mis) ? "Play the level Offline as it uses custom code.": "");

			file = %mis.file;
			searchName = %mis.searchName;
			addedAt = %mis.addedAt;
			downloaded = false;
			partial = true;
		});
		%list.addEntry(%info);
		%list.sort(MissionSortSearchName);
		
		//Fix level numbers
		%count = %list.getSize();
		for (%i = 0; %i < %count; %i ++) {
			%list.getEntry(%i).level = %i + 1;
		}
	}
}

function MarblelandMissionList::shouldUseDifficultyTree(%this, %game) {
	return %game $= "Packs";
}

function MarblelandMissionList::getMissionDirectory(%this, %game, %difficulty) {
	return "platinum/data/missions/marbleland/";
}

function MarblelandMissionList::getBitmapDirectory(%this, %game, %difficulty) {
	return "platinum/data/missions/marbleland/";
}

function MarblelandMissionList::getPreviewDirectory(%this, %game, %difficulty) {
	return "platinum/data/missions/marbleland/";
}

function MarblelandMissionList::getGameMode(%this, %game, %difficulty) {
	return "";
}

function MarblelandMissionList::shouldCheckAchievements(%this, %game) {
	return false;
}

//-----------------------------------------------------------------------------
// Helpers
//-----------------------------------------------------------------------------

function MissionSortLevel(%a, %b) {
	return %a.level < %b.level;
}
function MissionSortName(%a, %b) {
	return stricmp(%a.name, %b.name) < 0;
}
function MissionSortSearchName(%a, %b) {
	return stricmp(%a.searchName, %b.searchName) < 0;
}
function MissionSortNewest(%a, %b) {
	return %a.addedAt > %b.addedAt;
}
function PackSortSearchName(%a, %b) {
	return stricmp(%a.searchName, %b.searchName) < 0;
}
