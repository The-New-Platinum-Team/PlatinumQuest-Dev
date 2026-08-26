//-----------------------------------------------------------------------------
// Race Co-op Missions
//
// Adds "Race" categories to the MP mission list by pointing at the existing
// co-op directories - no mission files are copied. overrides/ holds race-only
// edits that replace a same-named coop file for Race (Co-op keeps its
// original); directors_all/ holds hand-picked levels with no coop equivalent;
// $RaceCoop::Excluded hides specific coop levels from Race only.
//
// Add a row to $RaceCoop::Games to register a mod.
//-----------------------------------------------------------------------------

$RaceCoop::CoopDirectory     = "platinum/data/multiplayer/coop";
$RaceCoop::RaceDirectory     = "platinum/data/multiplayer/race";
$RaceCoop::OverrideDirectory = "platinum/data/multiplayer/race/overrides";
$RaceCoop::AddedFlag         = false; // guards against double-injection

// modId TAB display name TAB difficulty folder suffixes TAB source base directory
$RaceCoop::Games[0] = "gold"      TAB "Race (Gold)"             TAB "beginner intermediate advanced"                 TAB $RaceCoop::CoopDirectory;
$RaceCoop::Games[1] = "platinum"  TAB "Race (Platinum)"         TAB "beginner intermediate advanced expert"          TAB $RaceCoop::CoopDirectory;
$RaceCoop::Games[2] = "ultra"     TAB "Race (Ultra)"            TAB "beginner intermediate advanced"                 TAB $RaceCoop::CoopDirectory;
$RaceCoop::Games[3] = "directors" TAB "Race (Director's Edits)" TAB "all"                                            TAB $RaceCoop::RaceDirectory @ "/directors_all";
$RaceCoop::GameCount = 4;

$RaceCoop::DifficultyDisplay["all"] = "All Levels";

// Levels excluded from Race (due to being trivial or broken)
$RaceCoop::Excluded["Nukesweeper.mis"]           = true;
$RaceCoop::Excluded["NukesweeperRevisited.mis"]  = true;
$RaceCoop::Excluded["Elevator.mis"]              = true;
$RaceCoop::Excluded["LearnTheSuperJump.mis"]     = true;
$RaceCoop::Excluded["PlatformTraining.mis"]      = true;
$RaceCoop::Excluded["LearnTheSuperSpeed.mis"]    = true;
$RaceCoop::Excluded["Gyrocopter.mis"]            = true;
$RaceCoop::Excluded["TimeTrial.mis"]             = true;
$RaceCoop::Excluded["SuperBounce.mis"]           = true;
$RaceCoop::Excluded["ShockAbsorber.mis"]         = true;
$RaceCoop::Excluded["Breezeway.mis"]             = true;
$RaceCoop::Excluded["Trapdoors!.mis"]            = true;
$RaceCoop::Excluded["JumpJumpJump.mis"]          = true;
$RaceCoop::Excluded["ForkInTheRoad.mis"]         = true;
$RaceCoop::Excluded["ShockDrop.mis"]             = true;
$RaceCoop::Excluded["TornadoAlley.mis"]          = true;
$RaceCoop::Excluded["FreeFall.mis"]              = true;
$RaceCoop::Excluded["Let'sRoll!.mis"]            = true;
$RaceCoop::Excluded["BumpYourHead.mis"]          = true;
$RaceCoop::Excluded["AvoidingHazards.mis"]       = true;
$RaceCoop::Excluded["DownhillRacing.mis"]        = true;
$RaceCoop::Excluded["Morph.mis"]                 = true;
$RaceCoop::Excluded["TeleportTraining.mis"]      = true;
$RaceCoop::Excluded["aimhigh_ultra.mis"]         = true;
$RaceCoop::Excluded["levelone_ultra.mis"]        = true;
$RaceCoop::Excluded["leveltwo_ultra.mis"]        = true;
$RaceCoop::Excluded["level_three_ultra.mis"]     = true;
$RaceCoop::Excluded["friction_ultra.mis"]        = true;
$RaceCoop::Excluded["level_five_ultra.mis"]      = true;
$RaceCoop::Excluded["jumpjumpjump_ultra.mis"]    = true;
$RaceCoop::Excluded["GoForTheGreen.mis"]         = true;
$RaceCoop::Excluded["TrainingTowers.mis"]        = true;
$RaceCoop::Excluded["LearnTheBouncyFloor.mis"]   = true;

package RaceCoopMissions {

function statsGetMissionListChallengeLine(%line, %req) {
	// Let the real handler parse the live Marbleland categories first
	Parent::statsGetMissionListChallengeLine(%line, %req);

	if (%req.gameType $= "Multiplayer" && !$RaceCoop::AddedFlag) {
		addRaceCoopCategories();
	}
}

// Race categories read from a source directory instead of a server-sent list
function OnlineMissionList::buildMissionList(%this, %game, %difficulty) {
	%difficultyObj = %this.lookupDifficulty[%game, %difficulty];
	if (%difficultyObj.race_coop_source !$= "") {
		buildRaceCoopMissionList(%this, %game, %difficulty, %difficultyObj);
		return;
	}

	Parent::buildMissionList(%this, %game, %difficulty);
}

};
activatePackage(RaceCoopMissions);

function buildRaceCoopMissionList(%ml, %game, %difficulty, %difficultyObj) {
	%list = %ml.getMissionList(%game, %difficulty);
	if (isObject(%list)) {
		%list.delete();
	}
	%list = Array(%list);
	MissionListGroup.add(%list);

	%dir = %difficultyObj.race_coop_source;

	// Preload all MCS files first, same as the normal directory-scan path
	$loadingMissionInfo = true;
	for (%file = findFirstMission(%dir @ "/*"); %file !$= ""; %file = findNextMission(%dir @ "/*")) {
		if (fileExt(%file) $= ".mcs") {
			exec(%file);
		}
	}
	$loadingMissionInfo = false;

	for (%file = findFirstMission(%dir @ "/*"); %file !$= ""; %file = findNextMission(%dir @ "/*")) {
		if (fileExt(%file) !$= ".mis") {
			continue;
		}

		%name = fileName(%file);
		if ($RaceCoop::Excluded[%name]) {
			continue;
		}

		// Use the race-specific edit if one exists for this level
		%overrideFile = $RaceCoop::OverrideDirectory @ "/" @ %name;
		if (isFile(%overrideFile)) {
			%file = %overrideFile;
		}

		%info = getMissionInfo(%file, true);
		if (!isObject(%info)) {
			continue;
		}

		%info.gameId = %difficultyObj.game_id;
		%info.difficultyId = %difficultyObj.id;
		%info.is_custom = 1;
		%info.downloaded = true;

		%list.addEntry(%info);
	}

	%list.sort(MissionSortLevel);

	%count = %list.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%list.getEntry(%i).level = %i + 1;
	}
}

function addRaceCoopCategories() {
	%ml = getMissionList("mp");
	if (!isObject(%ml.onlineMissionList)) {
		error("addRaceCoopCategories: online mission list isn't ready yet");
		return;
	}

	for (%g = 0; %g < $RaceCoop::GameCount; %g ++) {
		%modId        = getField($RaceCoop::Games[%g], 0);
		%display      = getField($RaceCoop::Games[%g], 1);
		%difficulties = getField($RaceCoop::Games[%g], 2);
		%sourceBase   = getField($RaceCoop::Games[%g], 3);

		%gameId = "race" @ upperFirst(%modId);
		%isDirectors = (%modId $= "directors");

		// Bail out quietly if the folders aren't there yet (no isDirectory()
		// in this engine build, so check for an actual .mis file instead)
		%probeDir = %isDirectors ? %sourceBase : (%sourceBase @ "/" @ %modId @ "_" @ getWord(%difficulties, 0));
		if (findFirstMission(%probeDir @ "/*") $= "") {
			error("addRaceCoopCategories: no race levels found for" SPC %modId @ ", skipping");
			continue;
		}

		RootGroup.add(%difficultyArray = Array(RaceCoopDifficultyList @ %gameId));

		%dcount = getWordCount(%difficulties);
		for (%d = 0; %d < %dcount; %d ++) {
			%diffId  = getWord(%difficulties, %d);
			%dirName = %isDirectors ? %sourceBase : (%sourceBase @ "/" @ %modId @ "_" @ %diffId);

			%diffDisplay = $RaceCoop::DifficultyDisplay[%diffId];
			if (%diffDisplay $= "")
				%diffDisplay = upperFirst(%diffId);

			RootGroup.add(%difficulty = new ScriptObject() {
				id                  = %gameId @ upperFirst(%diffId);
				name                = %diffId;
				display             = %diffDisplay;
				directory           = %dirName;
				bitmap_directory    = %dirName;
				previews_directory  = %dirName;
				race_coop_source    = %dirName;
				game_id             = %gameId;
			});

			%difficultyArray.addEntry(%difficulty);
		}

		// force_gamemode forces every mission under this category into Race
		// mode regardless of what the underlying .mis file was built for
		RootGroup.add(%game = new ScriptObject() {
			id             = %gameId;
			name           = %gameId;
			display        = %display;
			force_gamemode = "race";
			has_blast      = (%modId $= "ultra");
			difficulties   = %difficultyArray;
		});

		%ml.onlineMissionList.games.addEntry(%game);
	}

	%ml.buildMissionLookup();
	$RaceCoop::AddedFlag = true;
}
