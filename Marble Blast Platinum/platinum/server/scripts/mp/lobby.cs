//------------------------------------------------------------------------------
// Multiplayer Package
// serverLobby.cs
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

//------------------------------------------------------------------------------
//
// Client Load States:
// -1 - Lobby
//  0 - Loading
//  1 - Sending Files
//  2 - Confirming
//  3 - Ready
//  4 - Playing
//
//------------------------------------------------------------------------------

function GameConnection::loadLobby(%this) {
	if ($Server::ServerType $= "SinglePlayer")
		return;

	// Send clients to the lobby
	commandToClient(%this, 'OpenLobby');

	%this.loadState = -1; //Lobby

	// Send them stats about MPPlayMission
	%this.updatePlaymission();

	// Notify the crowd
	updatePlayerlist();

	// Reset the stats from the last game
	%this.resetStats();
}

function serverCmdSetMission(%client, %file, %game, %difficulty, %forceMode) {
	if (%client.isHost()) {
		if ($Server::Dedicated) {
			if (!isScriptFile(%file)) {
				//We don't have their file!
				echo("Invalid mission:" SPC %file);
				commandToClient(%client, 'InvalidMission', %file);
				return;
			}
			echo("Valid mission:" SPC %file);
			commandToClient(%client, 'ValidMission', %file);
		}

		serverSetMission(%file, %game, %difficulty, %forceMode);
	}
}

function serverSetMission(%file, %game, %difficulty, %forceMode) {
	%info = getMissionInfo(%file);

	if (%game $= "") {
		%game = resolveMissionGame(%info);
	}
	if (%difficulty $= "") {
		%difficulty = resolveMissionType(%info);
	}

	//Set type
	$CurrentGame = %game;
	$MissionType = %difficulty;

	//Set mode
	%modeInfo = getModeInfo(%forceMode);
	$MP::CurrentMode = %forceMode;
	$MP::CurrentModeInfo = %modeInfo;

	//Set mission
	$MP::MissionObj = %info;
	$MP::MissionFile = %info.file;

	if ($Server::Dedicated) {
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%cl = ClientGroup.getObject(%i);
			%cl.canDownload[$MP::MissionFile] = !%info.noDownload;
			commandToClient(%cl, 'CanDownloadMission', $MP::MissionFile, !%info.noDownload);
		}
	}

	reloadAllPlayMission();

	Mode::callback("setMission", "", new ScriptObject() {
		file = %file;
		game = %game;
		difficulty = %difficulty;
		mode = %forceMode;
		_delete = true;
	});

	// Check for interiors because of plebs

	%clients = ClientGroup.getCount();

	// Let them all know!
	for (%i = 0; %i < %info.interiors; %i ++) {
		commandToAll('CheckInterior', %info.interior[%i], %i);

		// Set them to not having the interiors by default
		for (%j = 0; %j < %clients; %j ++) {
			ClientGroup.getObject(%j).hasInterior[%i] = false;
		}
	}
}

function serverCmdInteriorStatus(%client, %interior, %index, %crc) {
	// Make sure they have the right interior
	%serverCRC = getFileCRC(%interior);
	if (%crc !$= %serverCRC) {
		error("Client" SPC %client.getUsername() SPC "interior CRC mismatch: (" @ %crc SPC "!=" SPC %serverCRC @ ")!");
	} else {
		%client.hasInterior[%index] = true;
	}
}

function serverCmdSetTeamMode(%client, %teammode) {
	if (%client.isHost()) {
		$MP::TeamMode = %teammode;
		onServerInfoQuery();
		updateTeams();
	}
}

function reloadAllPlaymission() {
	if ($Server::ServerType $= "SinglePlayer")
		return;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.isHost())
			continue;
		%client.updatePlaymission();
	}
	updatePlayerList();
}

function GameConnection::updatePlaymission(%this) {
	// Basic mission info that is used for playmission
	traceGuard();
	%info = $MP::MissionObj.getFields();
	traceGuardEnd();
	commandToClientLong(%this, 'LobbyMissionInfo', %info, $MP::MissionFile, $CurrentGame, $MissionType, $MP::CurrentMode);
}

function serverCmdMissionFileCheck(%client, %file, %crc) {
	%client.missionCRC[%file] = %crc;
	if (getFileCRC(%file) $= %crc)
		%client.missionPassed[%file] = true;
	else if (%crc != -1)
		%client.missionFailed[%file] = true;
}

function serverCmdLobbyReturn(%client) {
	if (%client.isHost()) {
		lobbyReturn();
	}
}

function lobbyReturn() {
	if ($Server::ServerType $= "SinglePlayer")
		return;

	if ($Server::_Dedicated) {
		error("Invalid call to lobbyReturn()");
		return;
	}
	commandToAll('CloseEndGame');

	if (!$Server::Dedicated)
		HudMessageVector.clear();

	if (isObject(MusicPlayer))
		MusicPlayer.stop();

	commandToAll('clearBottomPrint');
	commandToAll('clearCenterPrint');

	commandToAll('finishSpectating');
	updateSpectateFull();

	endMission(true);
	$Server::Lobby = true;
	$Server::Loading = false;
	$Game::Running = false;
	$missionRunning = false;
	$Server::SpectateCount = 0;

	pruneFakeClients();

	// Reset peoples' states back to default when they finish loading

	%loadStr = "";

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.loading = false;
		%client.loadState = -1; //Lobby
		%client.loadProgress = 0;

		if (%client.isHost()) {
			commandToClient(%client, 'LobbyReturned');
		}

		if (%i == 0) {
			%loadStr = %client.index SPC %client.loadProgress SPC %client.loadState;
		} else {
			%loadStr = %loadStr NL %client.index SPC %client.loadProgress SPC %client.loadState;
		}
	}
	commandToAllLong('ClientLoadProgress', %loadStr);

	Time::reset();
	clearModes();
	commandToAll('OpenLobby');
	updatePlayerlist();
}

function serverCmdLobbyRestart(%client) {
	if (%client.isHost()) {
		commandToAll('CloseEndGame');
		lobbyRestart();
	}
}

function serverCmdRestartLevel(%client) {
	if (%client.isHost()) {
		commandToAll('CloseEndGame');

		pruneFakeClients();
		restartLevel();
		updatePlayerlist();
	}
}

function lobbyRestart() {
	if ($Server::ServerType $= "SinglePlayer")
		return;

	if ($Server::_Dedicated) {
		error("LobbyRestart on dedicated server!");
	}

	if (!$Server::Started) {
		//what
		error("lobbyRestart() :: Not started yet");
		return;
	}

	pruneFakeClients();

	hideGems();
	spawnHuntGemGroup();
	$Server::Started = false;
	setGameState("waiting");
	updateSpectateFull();
	$Server::SpectateCount = 0;

	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.startOverview();
		%client.resetStats();
		%client.setPregame(true);
		%client.gemCount = 0;
		%client.spawnPoint = "";
		%client.setGemCount(%client.getGemCount());
		%client.ready = false;
	}

	Time::reset();
	updatePlayerlist();
}

//-----------------------------------------------------------------------------

function serverCmdMarblelandPlay(%client, %id) {
	if (%client.isHost()) {
		if (!isObject(marblelandGetMission(%id))) {
			%client.sendChat("<color:ff6666>Unknown Marbleland level: " @ %id);
			return;
		}

		// Download first
		serverMarblelandDownload(%id, SMP_downloadComplete);
	}
}

function SMP_downloadComplete(%id, %success) {
	if (!%success) {
		return;
	}

	serverLoadMission(marblelandGetMission(%id).file);
}


function serverCmdMarblelandDownload(%client, %id) {
	if (%client.isHost()) {
		if (!isObject(marblelandGetMission(%id))) {
			%client.sendChat("<color:ff6666>Unknown Marbleland level: " @ %id);
			return;
		}
		serverSendChat("<color:66ff66>Downloading Marbleland level: " @ destroyTorqueML(marblelandGetMission(%id).name));
		serverMarblelandDownload(%id, SMD_complete);
	}
}

function serverCmdMarblelandDownloadStatus(%client, %id, %success) {
	if (%client.marblelandDownloadCallback[%id] !$= "") {
		%client.call(%client.marblelandDownloadCallback[%id], %id, %success);
	}
}

function serverCmdMarblelandHasMissionStatus(%client, %id, %success) {
	if (%client.marblelandHasMissionCallback[%id] !$= "") {
		%client.call(%client.marblelandHasMissionCallback[%id], %id, %success);
	}
}

function SMD_complete(%id, %success) {
	if (%success) {
		serverSendChat("<color:66ff66>Downloaded successfully: " @ destroyTorqueML(marblelandGetMission(%id).name));
	} else {
		serverSendChat("<color:ff6666>Downloaded failed: " @ destroyTorqueML(marblelandGetMission(%id).name));
	}

	commandToAll('MarblelandDownloadStatus', %id, %success);
}

function serverMarblelandDownload(%id, %callback) {
	%mis = marblelandGetMission(%id);
	if (!isObject(%mis)) {
		call(%callback, %id, false);
		return;
	}
	if (%mis.hasCustomCode) {
		call(%callback, %id, false);
		return;
	}

	// First, make sure the server can download it
	$Server::MarblelandCallback[%id] = %callback;
	marblelandDownload(%id, SMD_serverDownloadComplete);
}

function SMD_serverDownloadComplete(%id, %success) {
	if (!%success) {
		if ($Server::MarblelandCallback[%id] !$= "") {
			schedule(100, 0, $Server::MarblelandCallback[%id], %id, false);
		}
		return;
	}

	// Once the server has it, tell all the clients to download it too
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.getAddress() $= "local") {
			%client.marblelandSuccess[%id] = true;
			continue;
		}
		%client.marblelandSuccess[%id] = "";
		%client.marblelandDownload(%id, lobbyMarblelandDownloadComplete);
	}

	SMD_checkSuccess(%id);
}

function GameConnection::lobbyMarblelandDownloadComplete(%this, %id, %success) {
	echo(%this.getDisplayName() @ " downloaded " @ %id @ " with success: " @ %success);
	%this.marblelandSuccess[%id] = %success;
	SMD_checkSuccess(%id);
}

function SMD_checkSuccess(%id) {
	%allDone = true;
	%allSuccess = true;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.marblelandSuccess[%id] $= "") {
			%allDone = false;
			break;
		}
		if (%client.marblelandSuccess[%id] == 0) {
			%allSuccess = false;
			break;
		}
	}

	if (!%allDone) {
		return;
	}

	if ($Server::MarblelandCallback[%id] !$= "") {
		schedule(100, 0, $Server::MarblelandCallback[%id], %id, %allSuccess);
	}
}

//-----------------------------------------------------------------------------
// Player list
//-----------------------------------------------------------------------------

function updatePlayerlist() {
	// Only once per frame, please!
	if (!$PlayerlistUpdate)
		onNextFrame(_updatePlayerList);
	$PlayerlistUpdate = true;

	cancel($MP::PlayerListSchedule);
	$MP::PlayerListSchedule = schedule(10000, 0, updatePlayerlist);
}

function _updatePlayerList() {
	$PlayerlistUpdate = false;
	if ($Server::Dedicated)
		refreshPlayerList();
	else
		commandToServer('refreshPlayerList');
}

function serverCmdRefreshPlayerList(%client) {
	if (!%client.isHost()) {
		%client.updatePlayerlist();
	} else {
		refreshPlayerList();
	}
}

function refreshPlayerList() {
	// Update the lists of all the clients
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.updatePlayerlist();
	}
	updateReadyUserList();
}

function serverCmdUpdatePlayerlist(%client) {
	// Punt this over to the GameConnection object (easier this way)
	%client.updatePlayerlist();
}

function GameConnection::updatePlayerlist(%this) {
	// Send them the complete player list and ready states
	%this.playerlistSend ++;

	%list = "";

	%set = ClientGroup.merge(FakeClientGroup);
	%count = %set.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = %set.getObject(%i);

		%team       = Team::getTeamName(%client.team);
		%teamColor  = Team::getTeamColor(%client.team);
		%host       = %client.isHost();
		%admin      = %client.isAdmin();
		%ping       = %client.getPing();
		%nametag    = %client.getNameTag();
		%specState  = (%client.isReal() ? (%client.spectating ? 2 : 1) : 0);
		%rating     = %client.rating;

		%playerData =
		    expandEscape(%client.getUsername())  // 0
		    TAB expandEscape(%client.loadState)      // 1
		    TAB expandEscape(%client.ready)          // 2
		    TAB expandEscape(%host)                  // 3
		    TAB expandEscape(%admim)                 // 4
		    TAB expandEscape(%client.skinChoice)     // 5
		    TAB expandEscape(%team)                  // 6
		    TAB expandEscape(%teamColor)             // 7
		    TAB expandEscape(%ping)                  // 8
		    TAB expandEscape(%nametag)               // 9
		    TAB expandEscape(%specState)             // 10
		    TAB expandEscape(%rating)                // 11
		    TAB %client.index                        // 12
		    ;


		if (%i == 0)
			%list = %playerData;
		else
			%list = %list NL %playerData;
	}
	commandToClientLong(%this, 'PlayerlistPlayer', %list, $Game::ClientIndex);
	%set.delete();

	// Score list... Why not?
	%this.updateScores();
}

function serverCmdMissionLoadProgress(%client, %progress, %state) {
	if (%state != %client.loadState) // Detach this!
		onNextFrame(updatePlayerlist);
	%client.loadProgress = %progress;
	%client.loadState = %state;
	%last = mFloor(%client.loadProgress * $MP::LoadSegments);

	if (%last == 0 != %client.lastProgress) {
		%str = %client.index SPC (%last / $MP::LoadSegments) SPC %state;
		commandToAllExcept(%client, 'ClientLoadProgress', %str);
	}
	%client.lastProgress = %last;
}

function serverCmdMissionLoadFile(%client, %file) {
	%client.loadingFile = %file;
}

//-----------------------------------------------------------------------------
// Team Support

function GameConnection::updateTeam(%this) {
	if ($Server::ServerType $= "SinglePlayer")
		return;

	Team::fix();

	commandToClient(%this, 'TeamMode', $MP::TeamMode);
	if ($MP::TeamMode) {
		%team = %this.team;

		// Send them basic infos
		commandToClient(%this, 'TeamStatus', Team::isDefaultTeam(%team));
		commandToClient(%this, 'TeamName', Team::getTeamName(%team));
		%maxLength = 255;
		%descSend = Team::getTeamDescription(%team);
		commandToClient(%this, 'TeamDescStart');
		for (%i = 0; %i < mCeil(strLen(%descSend) / %maxLength); %i ++)
			commandToClient(%this, 'TeamDescPart', getSubStr(%descSend, %i * %maxLength, %maxLength));
		commandToClient(%this, 'TeamDescEnd');
		commandToClient(%this, 'TeamColor', Team::getTeamColor(%team));
		commandToClient(%this, 'TeamLeader', Team::getTeamLeader(%team));
		commandToClient(%this, 'TeamLeaderStatus', Team::isTeamLeader(%team, %this));
		commandToClient(%this, 'TeamRole', Team::getTeamRole(%team, %this));
		commandToClient(%this, 'TeamPrivate', Team::getTeamPrivate(%team));

		// Send them a team listing
		commandToClient(%this, 'TeamPlayerListStart');
		%count = %team.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%player = %team.getObject(%i);
			commandToClient(%this, 'TeamPlayerListPlayer', %player.getUsername(), Team::isTeamLeader(%team, %player), Team::getTeamRole(%team, %player));
		}
		commandToClient(%this, 'TeamPlayerListEnd');
	}
}

function serverCmdTeamList(%client) {
	%client.sendTeamList();
}

function GameConnection::sendTeamList(%this) {
	if ($Server::ServerType $= "SinglePlayer")
		return;

	commandToClient(%this, 'TeamListStart');
	%count = TeamGroup.getCount();
	%used = "0\t0\t0\t0\t0\t0\t0\t0";
	for (%i = 0; %i < %count; %i ++) {
		%team = TeamGroup.getObject(%i);
		if (%team.color >= 0)
			%used = setField(%used, %team.color, 1);
		if (%team.permanent || !%team.private || %this.isHost())
			commandToClient(%this, 'TeamListTeam', Team::getTeamName(%team), %team.color);
	}
	commandToClient(%this, 'TeamListEnd');

	commandToClient(%this, 'TeamColorsUsed', %used);
}

function updateTeams() {
	if ($Server::ServerType $= "SinglePlayer")
		return;

	// Only update once per frame call, we don't want any race conditions.
	// This lets any working team logic settle down (removing/adding players,
	// creating/deleting teams) before we update the peoples
	if (!$TeamsUpdate)
		onNextFrame(refreshTeams);
	$TeamsUpdate = true;
	onNextFrame(setVariable, "$TeamsUpdate", false);
}

function refreshTeams() {
	if ($Server::ServerType $= "SinglePlayer")
		return;

	// Fix any non-teamed players
	Team::fix();

	%count = TeamGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%team = TeamGroup.getObject(%i);
		%tcount = %team.getCount();
		for (%j = 0; %j < %tcount; %j ++) {
			%client = %team.getObject(%j);
			if (%client.team $= "")
				%client.team = %team.getId();
		}
	}

	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.team $= "" || !isObject(%client.team))
			Team::addPlayer(Team::getDefaultTeam(), %client);
	}

	// Send the clients the public team list
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.sendTeamList();
		%client.updateTeam();
	}

	updatePlayerlist();
}

function serverCmdTeamLeave(%client) {
	// You left a team, sending you back to the default team!
	Team::removePlayer(%client.team);
	Team::addPlayer(Team::getDefaultTeam(), %client);
	refreshTeams();
}

function serverCmdTeamDelete(%client) {
	// Why would you ever want to delete your team?
	%team = %client.team;
	if (Team::isTeamLeader(%team, %client) && !Team::isDefaultTeam(%team)) {
		// Ohhhhhhhhhh nooooooooooo!
		Team::deleteTeam(%team);
		refreshTeams();
	}
}

function serverCmdTeamNameUpdate(%client, %name) {
	%team = %client.team;
	if (Team::isTeamLeader(%team, %client) && !Team::isDefaultTeam(%team)) {
		// Send it to them
		Team::setTeamName(%team, %name);
		refreshTeams();
	}
}

function serverCmdTeamColorUpdate(%client, %color) {
	%team = %client.team;
	if (Team::isTeamLeader(%team, %client) && !Team::isDefaultTeam(%team)) {
		// Send it to them
		Team::setTeamColor(%team, %color);
		refreshTeams();
	}
}

function serverCmdTeamDescUpdateStart(%client) {
	%team = %client.team;
	if (Team::isTeamLeader(%team, %client) && !Team::isDefaultTeam(%team)) {
		// Prepare for desc update
		%team = Team::getTeam(%team);
		%team.descParts = 0;
	}
}

function serverCmdTeamDescUpdatePart(%client, %part) {
	%team = %client.team;
	if (Team::isTeamLeader(%team, %client) && !Team::isDefaultTeam(%team)) {
		// Stash the part until we're good
		%team = Team::getTeam(%team);
		%team.descPart[%team.descParts] = %part;
		%team.descParts ++;
	}
}

function serverCmdTeamDescUpdateEnd(%client) {
	%team = %client.team;
	if (Team::isTeamLeader(%team, %client) && !Team::isDefaultTeam(%team)) {
		%team = Team::getTeam(%team);
//      %team.dump();
		// And finish the send
		%descFinal = "";
		for (%i = 0; %i < %team.descParts; %i ++) {
			%descFinal = %descFinal @ %team.descPart[%i];
			%team.descPart[%i] = "";
		}
		// If this is too long, echo() will crash D:
		if (strLen(%descFinal) > $MP::TeamDescMaxLength)
			%descFinal = getSubStr(%descFinal, 0, $MP::TeamDescMaxLength);
		%team.descParts = "";
		Team::setTeamDescription(%team, %descFinal);
	}
}

function serverCmdTeamPrivateUpdate(%client, %private) {
	%team = %client.team;
	if (Team::isTeamLeader(%team, %client) && !Team::isDefaultTeam(%team)) {
		// Send it to them
		Team::setTeamPrivate(%team, %private);
	}
}

function serverCmdTeamInfo(%client, %team) {
	%team = Team::getTeam(%team);
	if (%team == -1)
		return;

	// Send them basic infos
	commandToClient(%client, 'TeamInfoStatus', Team::isDefaultTeam(%team));
	commandToClient(%client, 'TeamInfoName', Team::getTeamName(%team));

	%maxLength = 255;
	%descSend = Team::getTeamDescription(%team);
	commandToClient(%client, 'TeamInfoDescStart');
	for (%i = 0; %i < mCeil(strLen(%descSend) / %maxLength); %i ++)
		commandToClient(%client, 'TeamInfoDescPart', getSubStr(%descSend, %i * %maxLength, %maxLength));
	commandToClient(%client, 'TeamInfoDescEnd');

	// Send them a team listing
	commandToClient(%client, 'TeamInfoPlayerListStart');
	%count = %team.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%player = %team.getObject(%i);
		commandToClient(%client, 'TeamInfoPlayerListPlayer', %player.getUsername(), Team::isTeamLeader(%team, %player));
	}
	commandToClient(%client, 'TeamInfoPlayerListEnd');

	commandToClient(%client, 'TeamInfoEnd');
}

function serverCmdTeamJoin(%client, %team) {
	%team = Team::getTeam(%team);

	// No private joins!
	if (%team.private)
		return;

	Team::addPlayer(%team, %client);
	updatePlayerlist();
}

function serverCmdTeamCreate(%client, %name, %private, %color) {
	if (Team::createTeam(%name, %client, false, %private, $MP::NewTeamDesc, %color)) {
		updateTeams();
		updatePlayerlist();
		commandToClient(%client, 'TeamCreateSucceeded');
	} else {
		commandToClient(%client, 'TeamCreateFailed');
	}
}

function serverCmdTeamInvite(%client, %player) {
	%team = %client.team;
	if (Team::isTeamLeader(%team, %client)) {
		// Send it to them
		%recp = GameConnection::resolveName(%player);
		commandToClient(%recp, 'TeamInvite', %client.getUsername(), Team::getTeamName(%team));

		// Store the invite
		%team.invite[%recp] = true;
	}
}

function serverCmdTeamInviteAccept(%client, %team) {
	%team = Team::getTeam(%team);

	// No private joins! Unless you're invited, that is.
	if (%team.private && !%team.invite[%client])
		return;

	// Clear this, they only get one invite
	%team.invite[%client] = false;

	Team::addPlayer(%team, %client);
	updatePlayerlist();

	//echo(%team.leader.getUsername() SPC "invited" SPC %client.getUsername());
}

function serverCmdTeamInviteDecline(%client, %team) {
	%team = Team::getTeam(%team);

	// Clear this, they only get one invite
	%team.invite[%client] = false;

	commandToClient(%team.leader, 'TeamInviteDecline', %client.getUsername());
}

function serverCmdTeamPromote(%client, %player) {
	// Dunno why you would want to do this
	%team = %client.team;

	// Make sure only the leader can promote people :)
	if (Team::isTeamLeader(%team, %client)) {
		%recp = GameConnection::resolveName(%player);

		// They are the new leader!
		Team::setTeamLeader(%recp);
	}
}

function serverCmdTeamKick(%client, %player) {
	%team = %client.team;

	// Make sure only the leader can kick people
	if (Team::isTeamLeader(%team, %client)) {
		%recp = GameConnection::resolveName(%player);

		// Get the fuck off my team.
		Team::removePlayer(%recp);
	}
}

function updateTeamMode() {
	if ($Server::Hosting) {
		// Have to do some setting up / tearing down team support
		if ($MP::TeamMode) {
			// Add all players to the default team, and create it if none
			// exists.
			%defaultTeam =  Team::createDefaultTeam();

			%count = ClientGroup.getCount();
			for (%i = 0; %i < %count; %i ++) {
				%client = ClientGroup.getObject(%i);

				// If they have a saved team, don't take them out of it!
				if (%client.oldTeam) {
					if (Team::addPlayer(%client.oldTeam, %client))
						continue;
				}

				// Otherwise, add them to the default team
				Team::addPlayer(%defaultTeam, %client);
				%client.updateTeam();
			}

			updateTeams();
		} else {
			// Team mode disabled.
			%count = ClientGroup.getCount();
			for (%i = 0; %i < %count; %i ++) {
				%client = ClientGroup.getObject(%i);
				%client.oldTeam = %client.team;
				%client.team = "";
				%client.updateTeam();
			}

			updateTeams();
		}
	}
	updatePlayerlist();
}

//-----------------------------------------------------------------------------

function serverCmdKickUser(%client, %name) {
	if (%client.isHost()) {
		%player = GameConnection::resolveName(%name);

		// If we found someone, kick them
		if (isObject(%player)) {
			kick(%player);
		}
		// Update our lists immediately
		updatePlayerlist();
	}
}

function serverCmdBanUser(%client, %name) {
	// Banning is not allowed on dedicated servers.
	if (%client.isHost() && !$Server::Dedicated) {
		%player = GameConnection::resolveName(%name);

		// If we found someone, ban them
		if (isObject(%player)) {
			ban(%player);
		}
		// Update our lists immediately
		updatePlayerlist();
	}
}

function serverCmdUnbanUser(%client, %name) {
	// Banning is not allowed on dedicated servers.
	if (%client.isHost() && !$Server::Dedicated) {
		unban(%name);

		// Update our lists immediately
		updatePlayerlist();
	}
}

function serverCmdMakeHost(%client, %name) {
	if (%client.isHost()) {
		%player = GameConnection::resolveName(%name);

		// If we found someone, kick them
		if (isObject(%player)) {
			%client.setHost(false);
			%player.setHost(true);

			serverSendChat(LBChatColor("notification") @ "The Host has changed to " @ %player.getDisplayName() @ ".");
		}
		// Update our lists immediately
		updatePlayerlist();
	}
}

//-----------------------------------------------------------------------------
// Mission Loading A.K.A the fun Section

function serverCmdLoadMission(%client, %file) {
	if (%client.isHost()) {
		serverLoadMission(%file);
	}
}

function serverLoadMission(%file) {
	if ($Server::Loading) {
		error("serverLoadMission: Already loading! Finish load first!");
		return;
	}

	// Load the actual mission here
	$Server::MissionFile = %file;
	$Server::Loading = true;

	// Send their file
	MPsendImageFile();

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.ready = false;
		%client.loadState = 0; //Loading
	}
	pruneFakeClients();
	refreshPlayerList();

	// Normal load sequence
	loadMission(%file);
}

function GameConnection::onFinishLoading(%this) {
	%this.loadState = 3; //Ready
	updatePlayerlist();

	//Check to see if we've finished
	checkAllClientsLoaded();

	if (!$Server::Lobby) {
		//We're already ingame, man!

		//Join the current game
		%this.startMission();
		%this.onClientEnterGame();
	}
}

function checkAllClientsLoaded() {
	//See how many people are loaded
	%loaded = 0;
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.loading) {
			%loaded ++;
		}
	}

	echo("Mission load update: Progress is now " @ %loaded @ "/" @ %count);

	//Has everyone finished loading?
	commandToAll('LoadProgress', %loaded, %count);
	if (%loaded == %count && $Server::Lobby) {
		$Server::Loading = false;
		$Server::Loaded = true;
		$Game::Running = false;
	}
}

function serverCmdEnterGame(%client) {
	if (%client.isHost()) {
		serverEnterGame();
	}
}

function serverEnterGame() {
	if (!$Server::Lobby) {
		error("Trying to enter game while already in game");
		return;
	}

	applyGravity();

	// Start all the clients in the mission
	$Server::Lobby = false;
	$missionRunning = true;
	$Game::Running = true;

	Time::reset();
	hideGems();
	spawnHuntGemGroup();

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.startMission();
		%client.onClientEnterGame();
	}
}

function GameConnection::sendDifficultyList(%this) {
	commandToClient(%this, 'DifficultyListStart');

	//Find all levels and let them know
	%ml = getMissionList("mp");
	%games = %ml.getGameList();
	%gcount = getRecordCount(%games);
	for (%i = 0; %i < %gcount; %i ++) {
		%game = getRecord(%games, %i);
		%gameName = getField(%game, 0);

		commandToClient(%this, 'DifficultyListGame', getField(%game, 0), getField(%game, 1));

		%difficulties = %ml.getDifficultyList(%gameName);
		%dcount = getRecordCount(%difficulties);
		for (%j = 0; %j < %dcount; %j ++) {
			%difficulty = getRecord(%difficulties, %j);
			%difficultyName = getField(%difficulty, 0);

			%directory = %ml.getMissionDirectory(%gameName, %difficultyName);
			%bitmapDir = %ml.getBitmapDirectory(%gameName, %difficultyName);
			%previewDir = %ml.getPreviewDirectory(%gameName, %difficultyName);
			%gameMode = %ml.getGameMode(%gameName);

			commandToClient(%this, 'DifficultyListDifficulty', %gameName, getField(%difficulty, 0), getField(%difficulty, 1), %directory, %bitmapDir, %previewDir, %gameMode);
		}
	}
	commandToClient(%this, 'DifficultyListEnd');
}

function serverCmdGetMissionList(%client, %gameName, %difficultyName) {
	//Find all levels and let them know
	%ml = getMissionList("mp");

	%list = %ml.getMissionList(%gameName, %difficultyName);
	if (!isObject(%list)) {
		%ml.buildMissionList(%gameName, %difficultyName);
	}
	if (!isObject(%list)) {
		return;
	}

	commandToClient(%client, 'MissionListStart', %gameName, %difficultyName);

	for (%k = 0; %k < %list.getSize(); %k ++) {
		%mission = %list.getEntry(%k);
		//Send them the file

		traceGuard();
		%info = getMissionInfo(%mission.file, true).getFields();
		echo("Info length:" SPC strLen(%info));

		//Args are out of order because commandToClientLong puts the long arg in the first arg
		commandToClientLong(%client, 'MissionListMission', %info, %gameName, %difficultyName);
		traceGuardEnd();
	}
	commandToClient(%client, 'MissionListEnd', %gameName, %difficultyName);

	if ($MissionType $= "Marbleland" && $CurrentGame $= "Marbleland") {
		// Swap pls
		commandToClient(%client, 'SwapMissionListMP');
	}

	if ($MissionType $= "Custom" && !%client.isHost()) {
		%client.updatePlaymission();
		if (%client.loading)
			sendLoadInfoToClient(%client);
	}
}


//Funny comments graveyard:

// I'MA SHOVEL PHASE 2 DOWN YOUR GODDAMN THROAT IF I HAVE TO
// Wow. That got really serious really fast. Phase 2 up next: ghosting

// Teeeeeeeechnically, they've finished phase 2
// At this point, they should be completely preloaded

// I don't know what to put here :(
// ヽ༼ຈل͜ຈ༽ﾉ ʀᴀɪsᴇ ᴜʀ ᴅᴏɴɢᴇʀs ヽ༼ຈل͜ຈ༽ﾉ

//On 8/14/13, at 2:20 PM, Aaron Youch wrote:
// > Raise your pirates

// PSYCH! Turns out there is more. Thanks, PQbama.
