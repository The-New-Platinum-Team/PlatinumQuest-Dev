//-----------------------------------------------------------------------------
// MissionInfo editing
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

function emibutton(%revert) {
	%pos = LFDWScroll.getPosition();
	LargeFunctionDlg.init("editMissionInfo", "Edit MissionInfo", 1);

	%gm = strlwr(resolveMissionGameModes(MissionInfo.gamemode));

	%modes = Array(EMI_ModesArray);
	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%mode = ModeInfoGroup.getObject(%i);
		%ident = %mode.identifier;
		%use[strlwr(%ident)] = stristrbool(%gm, %ident);
		if (%mode.hide)
			continue;

		%modes.addEntry(%mode);
	}
	%modes.sort(ModeSort);
	%defaultScore = ClientMode::callbackModeList(%gm, "getDefaultScore", $ScoreType::Time TAB 5999999 TAB "Matan W.");
	%useTime = getField(%defaultScore, 0) == $ScoreType::Time;

	//List of songs (literally copied from jukeboxdlg)
	%songs = "";
	for (%file = findFirstFile($usermods @ "/data/sound/music/*.ogg"); %file !$= ""; %file = findNextFile($usermods @ "/data/sound/music/*.ogg")) {
		// Remove upbeat finale and good to jump to (Loop Edit)
		%base = fileBase(%file);
		%name = fileBase(%file) @ ".ogg";
		if (%name $= "Upbeat Finale" || %name $= "Good to Jump to (Loop Edit)")
			continue;
		%songs = addRecord(%songs, %name TAB %base);
	}

	//Game list is provided by PMG
	%games = PlayMissionGui.getGameList();

	//BASICS
	LargeFunctionDlg.addTextEditField("EMI_LevelName", "Level name (as shown in level select):", MissionInfo.name, 350, -1);
	LargeFunctionDlg.addTextEditField("EMI_AuthorName", "Author name:", MissionInfo.artist !$= "" ? MissionInfo.artist : $pref::HighScoreName, 200, -1);
	LargeFunctionDlg.addTextEditField("EMI_LevelNumber", "Level number:", MissionInfo.level, 100, -1);
	LargeFunctionDlg.addTextEditField("EMI_LevelDesc", "Level description:", strReplace(MissionInfo.desc, "\n", "\\n"), 350, -1);
	LargeFunctionDlg.addTextEditField("EMI_StartHelpText", "Start help message:", strReplace(MissionInfo.startHelpText, "\n", "\\n"), 350, -1);
	LargeFunctionDlg.addDropMenu("EMI_Game", "Game:", 5, %games, MissionInfo.game);
	LargeFunctionDlg.addDropMenu("EMI_Music", "Music Track:", 5, %songs, MissionInfo.music);
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addTextEditField("EMI_GeneralHint", "General hint:", strReplace(MissionInfo.generalHint, "\n", "\\n"), 350, -1);
	LargeFunctionDlg.addTextEditField("EMI_UltimateHint", "Ultimate hint:", strReplace(MissionInfo.ultimateHint, "\n", "\\n"), 350, -1);
	LargeFunctionDlg.addTextEditField("EMI_AwesomeHint", "Awesome hint:", strReplace(MissionInfo.awesomeHint, "\n", "\\n"), 350, -1);
	LargeFunctionDlg.addTextEditField("EMI_EggHint", "NestEgg hint:", strReplace(MissionInfo.eggHint, "\n", "\\n"), 350, -1);
	LargeFunctionDlg.addTextEditField("EMI_Trivia", "Trivia:", strReplace(MissionInfo.trivia, "\n", "\\n"), 350, -1);
	LargeFunctionDlg.addNote("");

	//GAMEMODES
	LargeFunctionDlg.addNote("\c4----------- GAMEMODES -----------");
	LargeFunctionDlg.addNote("\c5-- Main Mode --");
	%mode = getModeInfo("null");
	%ident = %mode.identifier;
	%name = %mode.name;
	eval("function EMI_Use" @ %ident @ "::onPressed(%this, %gui){ EMI_replaceGameModes(\"" @ strlwr(%ident) @ "\", %this.getValue()); emibutton(true); }");
	LargeFunctionDlg.addCheckBox("EMI_Use" @ %ident, "Normal / Gem Collection", %use[%ident], 0);

	for (%i = 0; %i < %modes.getSize(); %i ++) {
		%mode = %modes.getEntry(%i);
		if (%mode.complete) {
			%ident = %mode.identifier;
			%name = %mode.name;
			eval("function EMI_Use" @ %ident @ "::onPressed(%this, %gui){ EMI_replaceGameModes(\"" @ strlwr(%ident) @ "\", %this.getValue()); emibutton(true); }");
			LargeFunctionDlg.addCheckBox("EMI_Use" @ %ident, upperFirstAll(%name), %use[%ident], 0);
		}
	}
	LargeFunctionDlg.addNote("\c5-- Extra Modes --");
	for (%i = 0; %i < %modes.getSize(); %i ++) {
		%mode = %modes.getEntry(%i);
		if (!%mode.complete) {
			%ident = %mode.identifier;
			%name = %mode.name;
			eval("function EMI_Use" @ %ident @ "::onPressed(%this, %gui){ EMI_replaceGameModes(\"" @ strlwr(%ident) @ "\", %this.getValue()); emibutton(true); }");
			LargeFunctionDlg.addCheckBox("EMI_Use" @ %ident, upperFirstAll(%name), %use[%ident], 0);
		}
	}

	LargeFunctionDlg.addNote("\c4----------- Challenge Times and Scores -----------");
	if (%useTime) {
		LargeFunctionDlg.addTimeEditField("EMI_ParTime", "Qualify (par) time | 0 = unlimited:", MissionInfo.time, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_GoldTime", "Gold Time:", MissionInfo.goldTime, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_PlatinumTime", "Platinum time:", MissionInfo.platinumTime, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_UltimateTime", "Ultimate time:", MissionInfo.ultimateTime, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_AwesomeTime", "Awesome time:", MissionInfo.awesomeTime, 100, -1);
		LargeFunctionDlg.addTextEditField("EMI_AlarmStartTime", "Time limit warning (seconds before par):", MissionInfo.alarmStartTime, 100, -1);
	} else {
		LargeFunctionDlg.addTimeEditField("EMI_TimeLimit", "Time limit:", MissionInfo.time, 100, -1);
		LargeFunctionDlg.addTextEditField("EMI_AlarmStartTime", "Time limit warning (seconds before zero):", MissionInfo.alarmStartTime, 100, -1);
		LargeFunctionDlg.addNote("\c5-- Challenge Scores --");
		LargeFunctionDlg.addTextEditField("EMI_ParScore", "Minimum score to qualify:", MissionInfo.score, 100, -1);
		LargeFunctionDlg.addTextEditField("EMI_GoldScore", "Gold Score:", MissionInfo.goldScore, 100, -1);
		LargeFunctionDlg.addTextEditField("EMI_PlatinumScore", "Platinum score:", MissionInfo.platinumScore, 100, -1);
		LargeFunctionDlg.addTextEditField("EMI_UltimateScore", "Ultimate score:", MissionInfo.ultimateScore, 100, -1);
		LargeFunctionDlg.addTextEditField("EMI_AwesomeScore", "Awesome score:", MissionInfo.awesomeScore, 100, -1);
		if (%use["gemmadness"]) {
			LargeFunctionDlg.addNote("\c5-- Challenge Times --");
			LargeFunctionDlg.addNote("These apply only if their corresponding score is blank");
			LargeFunctionDlg.addTextEditField("EMI_GoldTime", "Gold Time:", MissionInfo.goldTime, 100, -1);
			LargeFunctionDlg.addTextEditField("EMI_PlatinumTime", "Platinum time:", MissionInfo.platinumTime, 100, -1);
			LargeFunctionDlg.addTextEditField("EMI_UltimateTime", "Ultimate time:", MissionInfo.ultimateTime, 100, -1);
			LargeFunctionDlg.addTextEditField("EMI_AwesomeTime", "Awesome time:", MissionInfo.awesomeTime, 100, -1);
		}
	}

	if (%use["quota"]) {
		LargeFunctionDlg.addNote("\c4----------- Quota -----------");
		LargeFunctionDlg.addTextEditField("EMI_Quota_GemQuota", "Minimum number of gems to qualify:", MissionInfo.gemQuota, 100, -1);
	}
	if (%use["hunt"]) {
		LargeFunctionDlg.addNote("\c4----------- Hunt -----------");
		LargeFunctionDlg.addTextEditField("EMI_Hunt_GemSpawnRadius", "Gem spawn radius:", MissionInfo.radiusFromGem, 100, -1);
		LargeFunctionDlg.addTextEditField("EMI_Hunt_MaxGemsPerSpawn", "Maximum gems per spawn:", MissionInfo.maxGemsPerSpawn, 100, -1);
		LargeFunctionDlg.addDropMenu("EMI_Hunt_GemGroups", "Use Gem Groups:", 0, "0\tNo\n1\tSpawn Whole Group\n2\tRandom Spawn in Group", MissionInfo.gemGroups);
		LargeFunctionDlg.addTextEditField("EMI_Hunt_SpawnBlock", "Minimum Next Spawn Distance (= 2 * spawn radius):", MissionInfo.spawnBlock, 100, -1);
		LargeFunctionDlg.addNote("\c5-- Gem spawn chances --", 0);
		LargeFunctionDlg.addSlider("EMI_Hunt_RGSC", "Red gem chance:", "0 1", MissionInfo.redSpawnChance, 1, 0);
		LargeFunctionDlg.addSlider("EMI_Hunt_YGSC", "Yellow gem chance:", "0 1", MissionInfo.yellowSpawnChance, 1, 0);
		LargeFunctionDlg.addSlider("EMI_Hunt_BGSC", "Blue gem chance:", "0 1", MissionInfo.blueSpawnChance, 1, 0);
		LargeFunctionDlg.addSlider("EMI_Hunt_PGSC", "Platinum gem chance:", "0 1", MissionInfo.platinumSpawnChance, 1, 0);
	}
	if (%use["haste"]) {
		LargeFunctionDlg.addNote("\c4----------- Haste -----------");
		LargeFunctionDlg.addTextEditField("EMI_Haste_SpeedToQualify", "Speed to qualify:", MissionInfo.speedToQualify, 100, -1);
	}
	if (%use["consistency"]) {
		LargeFunctionDlg.addNote("\c4----------- Consistency -----------");
		LargeFunctionDlg.addTextEditField("EMI_Consistency_MinimumSpeed", "Minimum speed requirement:", MissionInfo.minimumSpeed, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_Consistency_GracePeriod", "Grace period at start:", MissionInfo.gracePeriod, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_Consistency_PenaltyDelay", "Penalty delay:", MissionInfo.penaltyDelay, 100, -1);
	}
	if (%use["gemmadness"]) {
	}
	if (%use["2d"]) {
		LargeFunctionDlg.addNote("\c4----------- 2d -----------");
		LargeFunctionDlg.addTextEditField("EMI_2d_CameraPlane", "Camera Plane", MissionInfo.cameraPlane, 100, -1);
		LargeFunctionDlg.addNote("Possible values: xz yz or an angle in degrees.");
		LargeFunctionDlg.addNote("Leaving this blank will give you 3d, but allow enabling 2d later with a TDTrigger.");
		LargeFunctionDlg.addCheckBox("EMI_2d_InvertCameraPlane", "Invert Plane?", MissionInfo.invertCameraPlane, 0);
	}
	if (%use["laps"]) {
		LargeFunctionDlg.addNote("\c4----------- Laps -----------");
		LargeFunctionDlg.addTextEditField("EMI_Laps_LapsNumber", "Total number of laps:", MissionInfo.lapsNumber, 100, -1);
		LargeFunctionDlg.addCheckBox("EMI_Laps_NoLapsCheckpoint", "Disable Trigger Checkpoints:", MissionInfo.noLapsCheckpoint, 0);
	}
	if (%use["collection"]) {
		LargeFunctionDlg.addNote("\c4----------- Collection -----------");
		LargeFunctionDlg.addTextEditField("EMI_Collection_DisableColor", "Disable a Color:", MissionInfo.disableColor, 100, -1);
		LargeFunctionDlg.addCheckBox("EMI_Collection_NoRandom", "Don't Randomize Gem Colors:", MissionInfo.noRandom, 0);
	}
	if (%use["elimination"]) {
		LargeFunctionDlg.addNote("\c4----------- Elimination -----------");
		LargeFunctionDlg.addTimeEditField("EMI_Elimination_EliminationTime", "Time Before Elimination:", MissionInfo.eliminationTime, 100, -1);
	}
	if (%use["seek"]) {
		LargeFunctionDlg.addNote("\c4----------- Seek -----------");
		LargeFunctionDlg.addTimeEditField("EMI_Seek_GraceTime", "Grace Period Time:", MissionInfo.graceTime, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_Seek_HideTime", "Hide Time:", MissionInfo.hideTime, 100, -1);
	}
	if (%use["tag"]) {
		LargeFunctionDlg.addNote("\c4----------- Tag -----------");
		LargeFunctionDlg.addTextEditField("EMI_Elimination_TagRadius", "Tag Radius:", MissionInfo.tagRadius, 100, -1);
	}
	if (%use["spooky"]) {
		LargeFunctionDlg.addNote("\c4----------- Halloween Event -----------");
		LargeFunctionDlg.addTextEditField("EMI_Spooky_GhostsPerPlayer", "Ghosts per Player:", MissionInfo.ghostsPerPlayer, 100, -1);
	}
	if (%use["snowball"]) {
		LargeFunctionDlg.addNote("\c4----------- Halloween Event -----------");
		LargeFunctionDlg.addTextEditField("EMI_Snowball_PointsPerHit", "Points per Hit:", MissionInfo.pointsPerHit, 100, -1);
		LargeFunctionDlg.addCheckBox("EMI_Snowball_NoAchShard", "No Achievement Ice Shard:", MissionInfo.noAchShard, 0);
		LargeFunctionDlg.addCheckBox("EMI_Snowball_SnowGravity", "Gravity-less Snow:", MissionInfo.snowGravity, 0);
	} if (%use["getpastthepost"]) {
		LargeFunctionDlg.addNote("\c4----------- Get Past the Post -----------");
		LargeFunctionDlg.addTextEditField("EMI_Getpastthepost_markerpost", "Score to hit:", MissionInfo.markerpost, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_GoldTime", "Gold time:", MissionInfo.goldTime, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_PlatinumTime", "Platinum time:", MissionInfo.platinumTime, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_UltimateTime", "Ultimate time:", MissionInfo.ultimateTime, 100, -1);
		LargeFunctionDlg.addTimeEditField("EMI_AwesomeTime", "Awesome time:", MissionInfo.awesomeTime, 100, -1);
	} if (%use["huntplus"]) {
		LargeFunctionDlg.addNote("\c4----------- Hunt Plus -----------");
		LargeFunctionDlg.addTextEditField("EMI_Hunt_TimeBonus", "Time Bonus after spawn (Blank for normal hunt):", MissionInfo.additionaltime, 100, -1);
	    LargeFunctionDlg.addCheckBox("EMI_Hunt_RagingBull", "SS and SJ upon new spawn (Uncheck for normal hunt)", MissionInfo.ragingbull, 0);
	}

	LargeFunctionDlg.addNote("\c4----------- Radar -----------");
	LargeFunctionDlg.addCheckBox("EMI_Radar", "Allow Radar (always true for PQ levels):", MissionInfo.radar, 0);
	LargeFunctionDlg.addCheckBox("EMI_HideRadar", "Disable Radar:", MissionInfo.hideRadar, 0);
	LargeFunctionDlg.addCheckBox("EMI_ForceRadar", "Force Radar to be on:", MissionInfo.forceRadar, 0);
	LargeFunctionDlg.addTextEditField("EMI_RadarDistance", "Item Search Distance:", MissionInfo.radarDistance, 100, -1);
	LargeFunctionDlg.addTextEditField("EMI_RadarGemDistance", "Gem/Finish Search Distance:", MissionInfo.radarGemDistance, 100, -1);

	LargeFunctionDlg.addNote("\c4----------- Blast -----------");
	LargeFunctionDlg.addNote("Enabled by default for Ultra and non-PQ Multiplayer maps. Use one of these to change the default behavior.");
	LargeFunctionDlg.addCheckBox("EMI_Blast", "Allow Blast:", MissionInfo.blast, 0);
	LargeFunctionDlg.addCheckBox("EMI_NoBlast", "Disable Blast:", MissionInfo.noBlast, 0);

	//Radar rules
	LargeFunctionDlg.addNote("\c4\t----------- Custom Radar Rules -----------");
	LargeFunctionDlg.addCheckBox("EMI_Radar_Flags_Gems", "Show Gems on Radar:", (MissionInfo.customRadarRule & (1 << 0)) != 0, 0);
	LargeFunctionDlg.addCheckBox("EMI_Radar_Flags_TimeTravels", "Show Time Travels on Radar:", (MissionInfo.customRadarRule & (1 << 1)) != 0, 0);
	LargeFunctionDlg.addCheckBox("EMI_Radar_Flags_EndPad", "Show EndPad on Radar:", (MissionInfo.customRadarRule & (1 << 2)) != 0, 0);
	LargeFunctionDlg.addCheckBox("EMI_Radar_Flags_Checkpoints", "Show Checkpoints on Radar:", (MissionInfo.customRadarRule & (1 << 3)) != 0, 0);
	LargeFunctionDlg.addCheckBox("EMI_Radar_Flags_Cannons", "Show Cannons on Radar:", (MissionInfo.customRadarRule & (1 << 4)) != 0, 0);
	LargeFunctionDlg.addCheckBox("EMI_Radar_Flags_Powerups", "Show PowerUps on Radar:", (MissionInfo.customRadarRule & (1 << 5)) != 0, 0);

	//Camera Stuff
	LargeFunctionDlg.addNote("\c4\t----------- Camera Settings -----------");
	LargeFunctionDlg.addTextEditField("EMI_cameraFov", "Default Camera FOV", MissionInfo.cameraFov, 100, -1);
	LargeFunctionDlg.addTextEditField("EMI_menuCameraFov", "Menu Overview Camera FOV", MissionInfo.menuCameraFov, 100, -1);
	LargeFunctionDlg.addTextEditField("EMI_cameraPitch", "Initial Camera Pitch", MissionInfo.cameraPitch, 100, -1);
	LargeFunctionDlg.addTextEditField("EMI_initialCameraDistance", "Initial Camera Distance", MissionInfo.initialCameraDistance, 100, -1);

	LargeFunctionDlg.addNote("\c4\t----------- Advanced Settings -----------");
	LargeFunctionDlg.addTimeEditField("EMI_PSHTT", "Start Help Text Persist Time", MissionInfo.persistStartHelpTextTime, 100, -1);
	LargeFunctionDlg.addCheckBox("EMI_NoAntiCheckpoint", "Don't Clear Bonus Time on Checkpoints", MissionInfo.noAntiCheckpoint, 0);
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addTextEditField("EMI_MarbleRadius", "Default Marble Radius", MissionInfo.marbleRadius, 100, -1);
	LargeFunctionDlg.addCheckBox("EMI_UseUltraMarble", "Use Ultra Marble Size", MissionInfo.useUltraMarble, 0);
	LargeFunctionDlg.addCheckBox("EMI_Mega", "Always Mega Marble", MissionInfo.mega, 0);
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addTextEditField("EMI_FanStrength", "Default Fan Strength", MissionInfo.fanStrength, 100, -1);
	LargeFunctionDlg.addTextEditField("EMI_Gravity", "Default Gravity", MissionInfo.gravity, 100, -1);
	LargeFunctionDlg.addTextEditField("EMI_JumpImpulse", "Default Jump Impulse", MissionInfo.jumpImpulse, 100, -1);
	LargeFunctionDlg.addCheckBox("EMI_MPFriction", "Disable Moving Platform Friction:", MissionInfo.NoMPFriction, 0);
	LargeFunctionDlg.addNote("");
	%compiled = (fileExt($Server::MissionFile) $= ".mcs") || $pref::WriteMCS;
	if (%compiled) {
		LargeFunctionDlg.addTextEditField("EMI_Requirements", "Requirements Text", MissionInfo.requirements, 350, -1);
		LargeFunctionDlg.addTextEditField("EMI_UnlockFunc", "Unlock Function (in MCS file)", MissionInfo.unlockFunc, 350, -1);
	}

	if (%revert) {
		LFDWScroll.setPosition(%pos);
	}
}

function ModeSort(%modeA, %modeB) {
	if (%modeA.complete != %modeB.complete) {
		return %modeA.complete > %modeB.complete;
	}
	return stricmp(%modeA.name, %modeB.name) < 0;
}

function EMI_replaceGameModes(%newMode, %on) {
	%mode = strlwr(MissionInfo.gameMode);
	if (%on) {
		if (getModeInfo(%newMode).complete) {
			for (%i = 0; %i < getWordCount(%mode); %i ++) {
				%info = getModeInfo(getWord(%mode, %i));
				if (%info.complete) {
					%mode = removeWord(%mode, %i);
					%i --;
				}
			}
		}

		%mode = %mode @ " " @ %newMode;
		while (strstrbool(%mode, "  ")) {
			%mode = strReplace(%mode, "  ", " ");
		}
	} else {
		%mode = strReplace(%mode, %newMode, "");
	}
	%mode = trim(%mode);
	MissionInfo.gameMode = %mode;
	setClientGameModes(%mode);

	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%info = ModeInfoGroup.getObject(%i);
		%ident = %info.identifier;
		if (%info.hide)
			continue;

		%use = stristrbool(%mode, %info.identifier);
		(EMI_Use @ %info.identifier).setValue(%use);
	}

	%modes.delete();
}

function editMissionInfo(%gui) {
	%modes = Array(EMI_ModesArray);
	%gm = "";
	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%mode = ModeInfoGroup.getObject(%i);
		%use[strlwr(%mode.identifier)] = ("EMI_Use" @ %mode.identifier).getValue();

		if (%use[strlwr(%mode.identifier)])
			%gm = addWord(%gm, %mode.identifier);
	}

	MissionInfo.GameMode = %gm;
	%gm = resolveMissionGameModes(%gm);
	setGameModes(%gm);

	MissionInfo.name = EMI_LevelName.getValue();
	MissionInfo.artist = EMI_AuthorName.getValue();
	//MissionInfo.type = %type;
	MissionInfo.level = EMI_LevelNumber.getValue();
	MissionInfo.desc = strReplace(EMI_LevelDesc.getValue(), "\\n", "\n");
	MissionInfo.GeneralHint = strReplace(EMI_GeneralHint.getValue(), "\\n", "\n");
	MissionInfo.UltimateHint = strReplace(EMI_UltimateHint.getValue(), "\\n", "\n");
	MissionInfo.AwesomeHint = strReplace(EMI_AwesomeHint.getValue(), "\\n", "\n");
	MissionInfo.EggHint = strReplace(EMI_EggHint.getValue(), "\\n", "\n");
	MissionInfo.trivia = strReplace(EMI_Trivia.getValue(), "\\n", "\n");
	MissionInfo.startHelpText = strReplace(EMI_StartHelpText.getValue(), "\\n", "\n");
	MissionInfo.game = EMI_Game.getValue();
	MissionInfo.music = EMI_Music.getValue();

	%defaultScore = ClientMode::callbackModeList(%gm, "getDefaultScore", $ScoreType::Time TAB 5999999 TAB "Matan W.");
	%useTime = getField(%defaultScore, 0) == $ScoreType::Time;

	if (%useTime) {
		miAssign(time, EMI_ParTime);
	} else {
		miAssign(time, EMI_TimeLimit);
	}

	miAssign(platinumTime, EMI_PlatinumTime);
	miAssign(goldTime, EMI_GoldTime);
	miAssign(ultimateTime, EMI_UltimateTime);
	miAssign(awesomeTime, EMI_AwesomeTime);
	miAssign(alarmStartTime, EMI_AlarmStartTime);

	miAssign(gemQuota, EMI_Quota_GemQuota, $Game::isMode["quota"]);

	miAssign(radiusFromGem, EMI_Hunt_GemSpawnRadius, $Game::isMode["hunt"]);
	miAssign(maxGemsPerSpawn, EMI_Hunt_MaxGemsPerSpawn, $Game::isMode["hunt"]);
	miAssign(gemGroups, EMI_Hunt_GemGroups, $Game::isMode["hunt"]);
	miAssign(spawnBlock, EMI_Hunt_SpawnBlock, $Game::isMode["hunt"]);
	miAssign(redSpawnChance, EMI_Hunt_RGSC, $Game::isMode["hunt"]);
	miAssign(yellowSpawnChance, EMI_Hunt_YGSC, $Game::isMode["hunt"]);
	miAssign(blueSpawnChance, EMI_Hunt_BGSC, $Game::isMode["hunt"]);
	miAssign(platinumSpawnChance, EMI_Hunt_PGSC, $Game::isMode["hunt"]);

	miAssign(additionaltime, EMI_Hunt_TimeBonus, $Game::isMode["huntplus"]);
	miAssign(ragingbull, EMI_Hunt_RagingBull, $Game::isMode["huntplus"]);

	miAssign(score, EMI_ParScore, !%useTime);
	miAssign(platinumScore, EMI_PlatinumScore, !%useTime);
	miAssign(ultimateScore, EMI_UltimateScore, !%useTime);
	miAssign(awesomeScore, EMI_AwesomeScore, !%useTime);

	miAssign(speedToQualify, EMI_Haste_SpeedToQualify, $Game::isMode["haste"]);

	miAssign(minimumSpeed, EMI_Consistency_MinimumSpeed, $Game::isMode["consistency"]);
	miAssign(gracePeriod, EMI_Consistency_GracePeriod, $Game::isMode["consistency"]);
	miAssign(penaltyDelay, EMI_Consistency_PenaltyDelay, $Game::isMode["consistency"]);

	miAssign(lapsNumber, EMI_Laps_LapsNumber, $Game::isMode["laps"]);
	miAssign(noLapsCheckpoint, EMI_Laps_NoLapsCheckpoint, $Game::isMode["laps"]);

	miAssign(cameraPlane, EMI_2d_CameraPlane, $Game::isMode["2d"]);
	miAssign(invertCameraPlane, EMI_2d_InvertCameraPlane, $Game::isMode["2d"]);

	miAssign(disableColor, EMI_Collection_disableColor, $Game::isMode["collection"]);
	miAssign(noRandom, EMI_Collection_NoRandom, $Game::isMode["collection"]);

	miAssign(eliminationTime, EMI_Elimination_EliminationTime, $Game::isMode["elimination"]);

	miAssign(graceTime, EMI_Seek_GraceTime, $Game::isMode["seek"]);
	miAssign(hideTime, EMI_Seek_HideTime, $Game::isMode["seek"]);

	miAssign(tagRadius, EMI_Elimination_TagRadius, $Game::isMode["tag"]);

	miAssign(ghostsPerPlayer, EMI_Spooky_GhostsPerPlayer, $Game::isMode["spooky"]);

	miAssign(pointsPerHit, EMI_Snowball_PointsPerHit, $Game::isMode["snowball"]);
	miAssign(noAchShard, EMI_Snowball_NoAchShard, $Game::isMode["snowball"]);
	miAssign(snowGravity, EMI_Snowball_SnowGravity, $Game::isMode["snowball"]);
	
	miAssign(markerpost, EMI_Getpastthepost_markerpost, $Game::isMode["getpastthepost"]);

	miAssign(radar, EMI_Radar);
	miAssign(hideRadar, EMI_HideRadar);
	miAssign(forceRadar, EMI_ForceRadar);
	miAssign(radarDistance, EMI_RadarDistance);
	miAssign(radarGemDistance, EMI_RadarGemDistance);
	%flags = 0
		| (EMI_Radar_Flags_Gems.getValue() ? $Radar::Flags::Gems : 0)
		| (EMI_Radar_Flags_TimeTravels.getValue() ? $Radar::Flags::TimeTravels : 0)
		| (EMI_Radar_Flags_EndPad.getValue() ? $Radar::Flags::EndPad : 0)
		| (EMI_Radar_Flags_Checkpoints.getValue() ? $Radar::Flags::Checkpoints : 0)
		| (EMI_Radar_Flags_Cannons.getValue() ? $Radar::Flags::Cannons : 0)
		| (EMI_Radar_Flags_Powerups.getValue() ? $Radar::Flags::Powerups : 0)
	;
	MissionInfo.customRadarRule = %flags;

	miAssign(blast, EMI_Blast);
	miAssign(noBlast, EMI_NoBlast);

	miAssign(cameraFov, EMI_cameraFov);
	miAssign(menuCameraFov, EMI_menuCameraFov);
	miAssign(cameraPitch, EMI_cameraPitch);
	miAssign(initialCameraDistance, EMI_InitialCameraDistance);

	miAssign(persistStartHelpTextTime, EMI_PSHTT);
	miAssign(noAntiCheckpoint, EMI_NoAntiCheckpoint);
	miAssign(marbleRadius, EMI_MarbleRadius);
	miAssign(useUltraMarble, EMI_UseUltraMarble);
	miAssign(mega, EMI_Mega);
	miAssign(fanStrength, EMI_FanStrength);
	miAssign(gravity, EMI_Gravity);
	miAssign(jumpImpulse, EMI_JumpImpulse);
	miAssign(NoMPFriction, EMI_MPFriction);

	%compiled = (fileExt($Server::MissionFile) $= ".mcs") || $pref::WriteMCS;
	if (%compiled) {
		miAssign(requirements, EMI_Requirements);
		miAssign(unlockFunc, EMI_UnlockFunc);
	}

	%modes.delete();
	%gui.cleanup();
	EWorldEditor.isDirty = true;
}

function miAssign(%field, %control, %cond) {
	if (!isObject(%control) || (%cond !$= "" && !%cond)) {
		MissionInfo.setFieldValue(%field, "");
		return;
	}
	if (%control.getClassName() $= "GuiCheckBoxCtrl") {
		MissionInfo.setFieldValue(%field, %control.getValue() ? "1" : "");
	} else if (%control.TimeEntryCtrl) {
		MissionInfo.setFieldValue(%field, %control.getValue() == 0 ? "" : %control.getValue());
	} else {
		MissionInfo.setFieldValue(%field, %control.getValue());
	}
}

function strstrbool(%str, %search) {
	return strstr(%str, %search) != -1;
}

function stristrbool(%str, %search) {
	return stristr(%str, %search) != -1;
}
