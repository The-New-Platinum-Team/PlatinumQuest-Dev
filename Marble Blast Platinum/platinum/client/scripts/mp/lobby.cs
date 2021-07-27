//------------------------------------------------------------------------------
// Multiplayer Package
// clientLobby.cs
//
// Copyright (c) 2013 The Platinum Team
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

function clientCmdOpenLobby() {
	if ($Server::ServerType !$= "MultiPlayer")
		return;
	$Server::Lobby = true;
	if ($Client::NeedInit) {
		PlayMissionGui.init();
	}

	%entry = PlayerList.getEntry($MP::ClientIndex);
	%entry.progress = 0;
	%entry.loadState = -1;

	PlayMissionGui.open();
}

function clientCmdLobbyReturned() {
	RootGui.popDialog(MessageBoxYesNoDlg);

	$Server::Lobby = true;
	$Client::Loaded = false;
	$Client::Loading = false;
	$Game::Running = false;
	$missionRunning = false;

	%entry = PlayerList.getEntry($MP::ClientIndex);
	%entry.progress = 0;
	%entry.loadState = -1;

	setLoadProgress(-1, 0, 0);

	disableInteriorRenderBuffers();
	flushInteriorRenderBuffers();
	cleanupReflectiveMarble();
	clientClearPaths();

	PlayMissionGui.updateMPButtons();
}

function clientCmdLobbyMissionInfo(%info, %file, %game, %difficulty, %mode) {
	if (!mp())
		return;

	$MP::MissionObj = new ScriptObject();
	$MP::MissionObj.setFields(%info);

	%update = false;
	if ($CurrentGame !$= %game) {
		PlayMissionGui.setGame(%game);
		%update = true;
	}
	if ($MissionType !$= %difficulty) {
		PlayMissionGui.setMissionType(%difficulty);
		%update = true;
	}
	if (%update) {
		PlayMissionGui.showMissionList();
		echo("Got Game: " @ %game);
		echo("Got MissionType: " @ %difficulty);
	}

	//Set mode
	%modeInfo = getModeInfo(%mode);
	$MP::CurrentMode = %mode;
	$MP::CurrentModeInfo = %modeInfo;

	// Update missionlist
	PlayMissionGui.setSelectedMission($MP::MissionObj, %game, %difficulty);
	if (!$Server::Hosting) {
		PlayMissionGui.deactivateMissionList();
	}

	// Store these for later
	$MP::MissionFile = %file;

	if ((!$Server::Hosting || $Server::_Dedicated) && !$MP::DownloadMissionAvailable[$MP::MissionFile]) {
		RootGui.popDialog(MPDownloadDlg);
	}

	commandToServer('MissionFileCheck', %file, getFileCRC(%file));
}

//-----------------------------------------------------------------------------
// Player list
//
// Client Ready States:
// 0 - Lobby
// 1 - Preloading
// 2 - Ready for Start
//
//-----------------------------------------------------------------------------

function clientCmdPlayerlistPlayer(%list, %maxIdx) {
	// Clear the list
	//Delete all player objects in the list
	for (%i = 0; %i < PlayerList.getSize(); %i ++) {
		%obj = PlayerList.getEntry(%i);
		if (isObject(%obj)) {
			%obj.dirty = true;
		}
	}

	for (%i = PlayerList.getSize(); %i <= %maxIdx; %i ++) {
		PlayerList.addEntry("");
	}

	if (!isObject(PlayerObjectGroup))
		RootGroup.add(new SimGroup(PlayerObjectGroup));

	$MP::ClientIndexMax = %maxIdx;

	%cnt = getRecordCount(%list);
	for (%i = 0; %i < %cnt; %i++) {
		%data = getRecord(%list, %i);
		%idx = getField(%data, 12);

		//New player?
		if (!isObject(PlayerList.getEntry(%idx))) {
			//So we don't ignore it below
			%newEntry = true;

			PlayerObjectGroup.add(%obj = new ScriptObject());
			PlayerList.replaceEntryByIndex(%idx, %obj);
		}
		%playerObj = PlayerList.getEntry(%idx);
		%playerObj.dirty = false; //Don't delete this object; it has update

		//    %client.getUsername() // 0
		// TAB %client.loadState     // 1
		// TAB %client.ready         // 2
		// TAB %host                 // 3
		// TAB %admin                // 4
		// TAB %client.skinChoice    // 5
		// TAB %team                 // 6
		// TAB %teamColor            // 7
		// TAB %ping                 // 8
		// TAB %nametag              // 9
		// TAB %specState            // 10
		// TAB %rating               // 11
		// TAB %client.index         // 12 (up above)

		%playerObj.name      = collapseEscape(getField(%data,  0));
		%playerObj.ready     = collapseEscape(getField(%data,  2));
		%playerObj.host      = collapseEscape(getField(%data,  3));
		%playerObj.admin     = collapseEscape(getField(%data,  4));
		%playerObj.marble    = collapseEscape(getField(%data,  5));
		%playerObj.team      = collapseEscape(getField(%data,  6));
		%playerObj.color     = collapseEscape(getField(%data,  7));
		%playerObj.ping      = collapseEscape(getField(%data,  8));
		%playerObj.nametag   = collapseEscape(getField(%data,  9));
		%playerObj.specState = collapseEscape(getField(%data, 10));
		%playerObj.rating    = collapseEscape(getField(%data, 11));

		//Updated by the client, shouldn't be overwritten
		if (%idx != $MP::ClientIndex || %newEntry) {
			%playerObj.loadState = collapseEscape(getField(%data, 1));
		}
	}

	for (%i = 0; %i < PlayerList.getSize(); %i ++) {
		%obj = PlayerList.getEntry(%i);
		if (isObject(%obj) && %obj.dirty) {
			%obj.delete();
			PlayerList.replaceEntryByIndex(%i, "");
		}
	}

	PlayMissionGui.updateServerPlayerList();
	MPPlayersDlg.updatePlayerList();
}

function clientCmdClientLoadProgress(%recordSet) {

	if ($Server::ServerType !$= "MultiPlayer")
		return;
	if (!isObject(PlayerList))
		return;

	%cnt = getRecordCount(%recordSet);
	for (%i = 0; %i < %cnt; %i++) {
		%record = getRecord(%recordSet, %i);
		%idx = getWord(%record, 0);
		%progress = getWord(%record, 1);
		%state = getWord(%record, 2);

		%entry = PlayerList.getEntry(%idx);
		%entry.progress = %progress;
		%entry.loadState = %state;

		if (%progress < $MP::LerpProgress[%idx]) {
			$MP::LerpProgress[%idx] = %progress;
			$MP::LerpStart[%idx] = %progress;
			$MP::LerpFinish[%idx] = %progress;
		}
	}

	PlayMissionGui.updateServerPlayerList();
}

//-----------------------------------------------------------------------------
// Team Support

function clientCmdTeamMode(%teamMode) {
	$MP::TeamMode = %teamMode;
	PlayMissionGui.updateChatPanel(false);

	if (!$MP::TeamMode) {
		MPTeamOptionsDlg.close();
		MPTeamSelectDlg.close();
		MPTeamCreateDlg.close();
		MPTeamJoinDlg.close();
	}
}

function clientCmdTeamJoin(%name) {
	addTeamChatLine("Joined team \"" @ %name @ "\".");
}

function clientCmdTeamLeave(%name) {
	addTeamChatLine("Left team \"" @ %name @ "\".");
}

function clientCmdTeamStatus(%default) {
	$MP::TeamDefault = %default;
	PlayMissionGui.updateTeams();
}

function clientCmdTeamName(%name) {
	$MP::TeamName = %name;
	PlayMissionGui.updateTeams();
}

function clientCmdTeamDescStart() {
	// Prepare for desc update
	$MP::TeamDescParts = 0;
	$MP::TeamDesc = "";
}

function clientCmdTeamDescPart(%part) {
	$MP::TeamDescPart[$MP::TeamDescParts] = %part;
	$MP::TeamDescParts ++;
}

function clientCmdTeamDescEnd() {
	// And finish the send
	%descFinal = "";
	for (%i = 0; %i < $MP::TeamDescParts; %i ++) {
		%descFinal = %descFinal @ $MP::TeamDescPart[%i];
		$MP::TeamDescPart[%i] = "";
	}
	// If this is too long, echo() will crash D:
	if (strLen(%descFinal) > $MP::TeamDescMaxLength)
		%descFinal = getSubStr(%descFinal, 0, $MP::TeamDescMaxLength);
	$MP::TeamDescParts = "";
	$MP::TeamDesc = %descFinal;
	PlayMissionGui.updateTeams();
}

function clientCmdTeamLeader(%leader) {
	$MP::TeamLeader = %leader;
	PlayMissionGui.updateTeams();
}

function clientCmdTeamLeaderStatus(%leaderStatus) {
	$MP::TeamLeaderStatus = %leaderStatus;
	PlayMissionGui.updateTeams();
}

function clientCmdTeamRole(%role) {
	$MP::TeamRole = %role;
	PlayMissionGui.updateTeams();
}

function clientCmdTeamColor(%color) {
	$MP::TeamColor = %color;
	PlayMissionGui.updateTeams();
}

function clientCmdTeamPrivate(%private) {
	$MP::TeamPrivate = %private;
	PlayMissionGui.updateTeams();
}

function clientCmdTeamPlayerListStart() {
	// Reset / create TeamPlayerList
	if (isObject(TeamPlayerList))
		TeamPlayerList.delete();
	Array("TeamPlayerList");
}

function clientCmdTeamPlayerListEnd() {
	MPTeamSelectDlg.updateTeam();
	PlayMissionGui.updateTeamUserlist();
}

function clientCmdTeamPlayerListPlayer(%playerName, %leader, %role) {
	// Insert the player
	if (!TeamPlayerList.containsEntry(%playerName))
		TeamPlayerList.addEntry(%playerName TAB %leader TAB %role);
}

function clientCmdTeamInfoStatus(%default) {
	$MP::TeamInfoDefault = %default;
	MPTeamJoinDlg.updateTeam();
}

function clientCmdTeamInfoName(%name) {
	$MP::TeamInfoName = %name;
	MPTeamJoinDlg.updateTeam();
}

function clientCmdTeamInfoDescStart() {
	// Prepare for desc update
	$MP::TeamInfoDescParts = 0;
	$MP::TeamInfoDesc = "";
}

function clientCmdTeamInfoDescPart(%part) {
	$MP::TeamInfoDescPart[$MP::TeamInfoDescParts] = %part;
	$MP::TeamInfoDescParts ++;
}

function clientCmdTeamInfoDescEnd() {
	// And finish the send
	%descFinal = "";
	for (%i = 0; %i < $MP::TeamInfoDescParts; %i ++) {
		%descFinal = %descFinal @ $MP::TeamInfoDescPart[%i];
		$MP::TeamInfoDescPart[%i] = "";
	}
	// If this is too long, echo() will crash D:
	if (strLen(%descFinal) > $MP::TeamDescMaxLength)
		%descFinal = getSubStr(%descFinal, 0, $MP::TeamDescMaxLength);
	$MP::TeamInfoDescParts = "";
	$MP::TeamInfoDesc = %descFinal;
	MPTeamJoinDlg.updateTeam();
}

function clientCmdTeamInfoPlayerListStart() {
	// Reset / create TeamPlayerList
	if (isObject(TeamInfoPlayerList))
		TeamInfoPlayerList.delete();
	Array("TeamInfoPlayerList");
}

function clientCmdTeamInfoPlayerListEnd() {
	MPTeamJoinDlg.updateTeam();
}

function clientCmdTeamInfoPlayerListPlayer(%playerName, %leader) {
	// Insert the player
	if (!TeamInfoPlayerList.containsEntry(%playerName))
		TeamInfoPlayerList.addEntry(%playerName TAB %leader);
}

function clientCmdTeamInfoEnd() {
	$MP::TeamInfoLoading = false;
	MPTeamJoinDlg.updateTeam();
}

function clientCmdTeamListStart() {
	// Reset / create TeamList
	if (isObject(TeamList))
		TeamList.delete();
	Array("TeamList");
}

function clientCmdTeamListTeam(%teamName, %color) {
	// Insert the new team
	if (!TeamList.containsRecord(%teamName, 0))
		TeamList.addEntry(%teamName NL %color);
}

function clientCmdTeamListEnd() {
	MPTeamJoinDlg.updateTeamList();
	MPTeamSelectDlg.updateTeam();
}

function clientCmdTeamColorsUsed(%used) {
	$MP::TeamColorsUsed = %used;
}

function clientCmdTeamCreateSucceeded() {
	MPTeamCreateDlg.close();
	MPTeamJoinDlg.close();
}

function clientCmdTeamCreateFailed() {
	MessageBoxOk("Team Creation Failed", "The team could not be created. Either another team with that name already exists, or there was an unknown error.");
}

function clientCmdTeamInvite(%player, %teamName) {
	MessageBoxYesNo("Team Invite", upperFirst(%player) SPC "has invited you to join team" SPC %teamName @ ". Press yes to join team" SPC %teamName @($MP::TeamDefault ? "." : " and to leave your current team."), "acceptTeamInvite(\"" @ %teamName @ "\");", "declineTeamInvite(\"" @ %teamName @ "\");");
}

function acceptTeamInvite(%teamName) {
	commandToServer('TeamInviteAccept', %teamName);
}

function declineTeamInvite(%teamName) {
	commandToServer('TeamInviteDecline', %teamName);
}

function clientCmdTeamInviteDecline(%player) {
	MessageBoxOk("Team Invitation Declined", upperFirst(%player) SPC "has declined your team invitation.");
}

function clientCmdMasterServerScore(%level, %index, %player, %score, %practice, %teams) {
	// Four-dimensional arrays. Yeah, I went there. Try visualizing a 4D
	// array in your mind. You can't. You know 1D arrays are like lists, 2D
	// arrays are like rectangles, and 3D arrays are like rectangular prisms. So
	// what does a 4D array look like? Good luck trying to think of one.
	$Master::ServerScore[%level, %index, %practice, %teams] = %player TAB %score;
}

function clientCmdMasterTopScore(%level, %index, %player, %score, %practice, %teams) {
	$Master::TopScore[%level, %index, %practice, %teams] = %player TAB %score;
	$Master::TopScoreCount[%level, %practice, %teams] = max($Master::TopScoreCount, %index);
}

function clientCmdMasterLevelScores() {
	deleteVariables("$Master::TopScore" @ fileBase($MP::MissionFile) @ "*");
}

function clientCmdMasterLevelScoresEnd() {
	PlayMissionGui.updateMissionInfo();
}

function clientCmdInvalidMission(%file) {
	//Tell MPPMGui
	$MP::InvalidMission[%file] = true;

	PlayMissionGui.updateMissionInfo();
	PlayMissionGui.updateMPButtons();
}

function clientCmdValidMission(%file) {
	//Tell MPPMGui
	$MP::ValidMission[%file] = true;

	if ($MP::MissionFile $= %file)
		$MP::MissionPassed = true;

	PlayMissionGui.updateMissionInfo();
	PlayMissionGui.updateMPButtons();
}

function clientCmdCloseLobby() {
	$Server::Lobby = false;
	PG_LBChatEntry.setValue(""); // Clear ingame chat
	LBSetChatMessage("", PG_LBChatEntry);
}

function clientCmdDifficultyListStart() {
	//LBMessage("Downloading Mission List...", "disconnect();");

	//Clear server mission list
	%ml = getMissionList("server");
	%ml.clear();
}

function clientCmdDifficultyListGame(%gameName, %gameDisplay) {
	%ml = getMissionList("server");
	%ml.addGame(%gameName, %gameDisplay);
}

function clientCmdDifficultyListDifficulty(%gameName, %difficultyName, %difficultyDisplay, %directory, %bitmapDir, %previewDir, %gameMode) {
	%ml = getMissionList("server");
	%ml.addDifficulty(%gameName, %difficultyName, %difficultyDisplay, %directory, %bitmapDir, %previewDir, %gameMode);
}

function clientCmdDifficultyListEnd() {
	//Don't trap us at the message screen if we're not going to the lobby
	if ($Server::Lobby) {
		RootGui.setContent(PlayMissionGui);
		//Update the play screen
		PlayMissionGui.updateMPButtons();
	}
}

function clientCmdMissionListStart(%gameName, %difficultyName) {
	//LBMessage("Downloading Mission List...", "disconnect();");

	//Clear server mission list
	%ml = getMissionList("server");
	%ml.clearMisisons(%gameName, %difficultyName);
}

//Args are out of order because commandToClientLong puts the long arg in the first arg
function clientCmdMissionListMission(%info, %gameName, %difficultyName) {
	//See if we need to add this to the list
	%ml = getMissionList("server");
	%ml.addMission(%gameName, %difficultyName, %info);
}

function clientCmdMissionListEnd(%gameName, %difficultyName) {
	%ml = getMissionList("server");
	%ml.doneMissions(%gameName, %difficultyName);

	if ($Client::NeedInit) {
		$Client::NeedInit = false;
		PlayMissionGui.init();
	}
	if ($Server::Lobby) {
		//Really only need to update if we are showing this difficluty
		%info = PlayMissionGui.getMissionInfo();
		if ((%gameName $= resolveMissionGame(%info)) && (%difficultyName $= resolveMissionType(%info))) {
			//Update to show the real mission list
			PlayMissionGui.showMissionList();

			//Select the current mission again so it doesn't deselect when the list updates
			PlayMissionGui.setSelectedMission(%info, resolveMissionGame(%info), resolveMissionType(%info));

			//Update the play screen
			PlayMissionGui.updateMPButtons();
		}

		if (SearchDlg.isAwake()) {
			SearchDlg.buildSearch();
		}
	}
}

function clientCmdCheckInterior(%interior, %index) {
	// Tell the server what we have
	commandToServer('InteriorStatus', %interior, %index, getFileCRC(%interior));
}

function clientCmdMissionScript(%file, %dso, %sha) {
	exec("./callbacks.cs");
	echo("Trying to load Mission Script:" SPC %file);
	if (isFile(%file)) {
		if (%dso) {
			//Trying to exec a .dso gives an error, exec the cs version instead
			// even if a cs doesn't exist.
			if (fileExt(%file) $= "dso") {
				exec(filePath(%file) @ "/" @ fileBase(%file));
			} else {
				exec(%file);
			}
		} else {
			%conts = fread(%file);
			eval(%conts);
			echo("Evaluating" SPC %file SPC "of length" SPC strlen(%conts));
		}
	} else if (%file !$= "") {
		error("No such file" SPC %file);
		commandToServer('MissionScriptError', %file, %dso);
	}
}

//-----------------------------------------------------------------------------

function clientCmdLoadProgress(%loaded, %count) {
	echo(%loaded @ " / " @ %count @ " players loaded.");
	if (%loaded == %count) {
		PlayMissionGui.onMPMissionLoaded();
	}
}
