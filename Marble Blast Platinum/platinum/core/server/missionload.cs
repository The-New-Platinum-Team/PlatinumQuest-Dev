//-----------------------------------------------------------------------------
// Portions Copyright (c) 2021 The Platinum Team
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

//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Server mission loading
//-----------------------------------------------------------------------------

// On every mission load except the first, there is a pause after
// the initial mission info is downloaded to the client.
$MissionLoadPause = 3000;

//-----------------------------------------------------------------------------

function loadMission(%missionName, %isFirstMission) {

	%isChallenge = strPos(%missionName, "challenge/data") != -1;
	if (%isChallenge) {
		%missionName = strReplace(%missionName, "challenge/data", "platinum/data");
		$Event::Modes = "challenge"; // This is such horrible, horrible hacks
	} else {
		$Event::Modes = "";
	}

	if ($loadingMission) {
		error("Already loading a mission! Please cancel the previous load first");
		return;
	}

	// Unload marbleland missions EXCEPT the one that is gonna be played
	%marblelandId = marblelandGetFileId(%missionName);
	if (%marblelandId !$= "") {
		if (marblelandHasMission(%marblelandId) && !marblelandMissionNeedsUpdate(%marblelandId)) {
			if (!marblelandLoad(%marblelandId)) {
				error("Could not load mission from marbleland: " @ %missionName);
				onMissionLoadFailed();
				return;
			}
			if (!isScriptFile(%missionName)) {
				error("Could not find mission " @ %missionName);
				onMissionLoadFailed();
				return;
			}
		} else {
			// Don't have this one yet... download it later in stage 1
		}
	} else {
		marblelandLoad(-1);

		if (!isScriptFile(%missionName)) {
			error("Could not find mission " @ %missionName);
			onMissionLoadFailed();
			return;
		}
	}

	%isChallenge = strPos(%missionName, "challenge/data") != -1;
	if (%isChallenge) {
		%missionName = strReplace(%missionName, "challenge/data", "platinum/data");
	}

	if ($loadingMission) {
		error("Already loading a mission! Please cancel the previous load first");
		return;
	}

	// Make sure all the clients have loaded the mission package too
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.getAddress() $= "local") {
			continue;
		}
		if (%marblelandId !$= "") {
			%client.marblelandLoad(%marblelandId);
		} else {
			%client.marblelandLoad(-1);
		}
	}

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.ready = false;
	}
	pruneFakeClients();

	$loadingMission = true;

	endMission();
	echo("*** LOADING MISSION: " @ %missionName);
	echo("*** Stage 1 load");

	// Reset all of these
	clearCenterPrintAll();
	clearBottomPrintAll();
	clearServerPaths();
	serverResetSyncObjects();

	// increment the mission sequence (used for ghost sequencing)
	$missionSequence++;
	$missionRunning = false;
	$Server::MissionFile = %missionName;
	$Server::Started = false;
	$Editor::Opened = false;

	// Download mission info to the clients
	%count = ClientGroup.getCount();
	for (%cl = 0; %cl < %count; %cl++) {
		%client = ClientGroup.getObject(%cl);
		sendLoadInfoToClient(%client);
		commandToClient(%client, 'ShowLoadScreen');
	}

	// Now that everyone knows they're loading, make sure we have the level from marbleland
	%marblelandId = marblelandGetFileId(%missionName);
	if (%marblelandId !$= "" && (!marblelandHasMission(%marblelandId) || marblelandMissionNeedsUpdate(%marblelandId))) {
		marblelandDownload(%marblelandId, LMS1_downloadFinished);
		return;
	}

	// Sanity
	if (!isScriptFile(%missionName)) {
		error("Could not find mission " @ %missionName);
		onMissionLoadFailed();
		return;
	}

	// if this isn't the first mission, allow some time for the server
	// to transmit information to the clients:
	if (%isFirstMission || $Server::ServerType $= "SinglePlayer")
		loadMissionStage2();
	else
		$LoadStage2 = schedule($MissionLoadPause, ServerGroup, loadMissionStage2);
}

function LMS1_downloadFinished(%id, %success) {
	echo("*** Stage 1 Marbleland Download " @ %id @ " finished: " @ %success);
	if (!%success) {
		error("Could not download marbleland mission " @ %id);
		onMissionLoadFailed();
		return;
	}
	if (!marblelandLoad(%id)) {
		error("Could not load mission from marbleland after download: " @ $Server::MissionFile);
		onMissionLoadFailed();
		return;
	}
	if (!isScriptFile($Server::MissionFile)) {
		error("Could not find mission after download: " @ $Server::MissionFile);
		onMissionLoadFailed();
		return;
	}

	// We don't need to delay, the download should have done that for us :)
	loadMissionStage2();
}

//-----------------------------------------------------------------------------

function loadMissionStage2(%trustlevel) {
	$Server::_ServerType = $Server::ServerType;
	$Server::ServerType = "SinglePlayer";

	// Create the mission group off the ServerGroup
	echo("*** Stage 2 load");
	$instantGroup = ServerGroup;

	// Make sure the mission exists
	%file = $Server::MissionFile;

	if ($pref::AlwaysTrust[$Server::MissionFile] == 1) {
		%trustlevel = 1;
	}

	if (checkforMaliciousCode(%file) && !%trustlevel) {
		MalcodeError("Level Loading Halted!", "The level you just tried to load might have Malicious Code, which could be used to alter game files. Please review the code detected and decide if you want to continue loading the level or not.");
		return;
	}

	if (!isScriptFile(%file)) {
		error("Could not find mission " @ %file);

		loadMissionFinish(false);
		return;
	}

	// Calculate the mission CRC.  The CRC is used by the clients
	// to caching mission lighting.
	$missionCRC = getFileCRC(%file);

	//Load modes as the correct server type
	$Server::ServerType = $Server::_ServerType;

	//Set the game mode before mission load, as some modes may have datablocks
	// that need to be created.

	%modes = resolveMissionGameModes($Server::MissionFile, "");
	setGameModes(%modes); //Custom game modes

	//Load mission as singleplayer
	$Server::ServerType = "SinglePlayer";

	//Reset function
	onBeforeMissionLoad();

	//Create this before we load
	new SimGroup(MissionCleanup);

	// Exec the mission, objects are added to the ServerGroup
	%oldError = $ScriptError;
	$ScriptError = "";
	exec(%file);
	%error = $ScriptError;
	$ScriptError = %oldError;

	if (!$Server::Dedicated && %error !$= "") {
		MessageBoxOk("Script Error", %error);
		loadMissionFinish(false);
		return;
	}

	//New compiled mcs missions need to have their LoadMission called
	if (fileExt(%file) $= ".mcs") {
		//MCS has a convenient function for loading
		%fn = "PQ_" @ alphaNum(fileBase(%file)) @ "_LoadMission";

		//Leaderboards need a separate method
		if (mp() || strPos(%file, "data/multiplayer") != -1) {
			%fn = "MP_" @ %fn;
		} else if (lb() || strPos(%file, "data/lb") != -1) {
			%fn = "LB_" @ %fn;
		}

		//Wtf
		if (!isFunction(%fn)) {
			error(".mcs file " @ %file @ " does not have the correct LoadMission function!");
			error("Should be " @ %fn @ " but no such function was found!");

			$ScriptError = $ScriptError NL ".mcs file " @ %file @ " does not have the correct LoadMission function! Should be " @ %fn @ " but no such function was found!";
			MessageBoxOk("Script Error", $ScriptError);
			loadMissionFinish(false);
			return;
		}

		//Load her up
		call(%fn);

		//Missions no longer have MissionInfo in the MissionGroup, so create one if needed
		if (!isObject(MissionInfo)) {
			//How nice
			%info = getMissionInfo($Server::MissionFile);
			//Copy it
			ServerGroup.add(new ScriptObject(MissionInfo));

			traceGuard();
				MissionInfo.setFields(%info.getFields());
			traceGuardEnd();
		} else {
			//Make sure this doesn't go in MissionGroup
			ServerGroup.add(MissionInfo);
		}
	}

	%script = filePath(%file) @ "/" @ fileBase(%file) @ ".cs";
	if (isScriptFile(%script)) {
		commandToAll('MissionScript', %script);
	}

	// If there was a problem with the load, let's try another mission
	if (!isObject(MissionGroup)) {
		error("No 'MissionGroup' found in mission \"" @ $missionName @ "\". Check your mission file for any syntax errors.");

		loadMissionFinish(false);
		return;
	}

	// Mission cleanup group
	$instantGroup = MissionCleanup;

	// Construct MOD paths
	pathOnMissionLoadDone();

	// Mission loading done...
	echo("*** Mission loaded");

	//Clear the camera and paths
	resetMovingObjects();
	ClientParentedObjects.clear();
	ClientMovingObjects.clear();

	//Update gravity and stuff
	applyGravity();

	if (!isObject(CameraPath1)) {
		generateDefaultCameraPath();
	}

	$Server::MissionName = MissionInfo.name;
	onServerInfoQuery();

	// Start all the clients in the mission
	$missionRunning = true;
	for (%clientIndex = 0; %clientIndex < ClientGroup.getCount(); %clientIndex++)
		ClientGroup.getObject(%clientIndex).loadMission();

	// Go ahead and launch the game
	onMissionLoaded();
	purgeResources();

	loadMissionFinish(true);
}

function loadMissionFinish(%success) {
	$loadingMission = false;

	if ($Server::_ServerType !$= "") {
		$Server::ServerType = $Server::_ServerType;
		$Server::_ServerType = "";
	}

	if (!%success) {
		onMissionLoadFailed();
	}
}

function applyGravity() {
	if (MissionInfo.gravity $= "")
		$Game::Gravity = 20;
	else
		$Game::Gravity = MissionInfo.gravity;

	if (MissionInfo.jumpImpulse $= "")
		$Game::JumpImpulse = 7.5;
	else
		$Game::JumpImpulse = MissionInfo.jumpImpulse;

	if (MissionInfo.fanStrength $= "")
		$Game::FanStrength = 40;
	else
		$Game::FanStrength = MissionInfo.fanStrength;

	if (MissionInfo.marbleRadius $= "")
		$Game::MarbleRadius = 0.18975;
	else
		$Game::MarbleRadius = MissionInfo.marbleRadius;

//	echo("Found gravity:" SPC MissionInfo.gravity);
//	echo("Found jump:" SPC MissionInfo.jumpImpulse);
//	echo("Found fan strength:" SPC MissionInfo.fanStrength);

	for (%i = 0; %i < DataBlockGroup.getCount(); %i ++) {
		%db = DataBlockGroup.getObject(%i);
		if (%db.getClassName() $= "MarbleData" && !%db.nomods) {
			%db.gravity = $Game::Gravity;
			%db.jumpImpulse = $Game::JumpImpulse;
			%db.scale = $Game::MarbleRadius;
		}
		if (%db.getClassName() $= "StaticShapeData" && %db.className $= "Fan" && !%db.nomods) {
			%db.forceStrength[0] = $Game::FanStrength * %db.forceStrengthModifier[0];
		}
		if (%db.getClassName() $= "ParticleEmitterData" && (!%db.periodModified || %db.ejectionPeriodMS != %db.newPeriod || %db.periodVarianceMS != %db.newVarianceMS)) {
			if (%db.oldPeriod $= "")
				%db.oldPeriod = %db.ejectionPeriodMS;
			if (%db.oldVarianceMS $= "")
				%db.oldVarianceMS = %db.periodVarianceMS;

//			echo("Period was" SPC %db.oldPeriod);
			if ($pref::Video::ParticlesPercent == 0) {
				%db.ejectionPeriodMS = 1000000;
				%db.periodVarianceMS = 500000;
			} else {
				%db.ejectionPeriodMS = max(mCeil(%db.oldPeriod * (1 / $pref::Video::ParticlesPercent)), 1);
				%db.periodVarianceMS = max(mCeil(%db.oldVarianceMS * (1 / $pref::Video::ParticlesPercent)), 1);
			}
			%db.newPeriod = %db.ejectionPeriodMS;
			%db.newVarianceMS = %db.periodVarianceMS;
//			echo("Period is" SPC %db.newPeriod);
			%db.periodModified = true;
		}
	}
}

//-----------------------------------------------------------------------------

function onMissionLoadFailed() {
	$instantGroup = RootGroup;
	$MissionRunning = false;

	//Load failed!
	if ($Menu::Startup) {
		$Menu::Startup = false;

		//Ah dicks
		error("Error in loading startup mission! Need to get to the main menu somehow!");
		$pref::AnimatePreviews = 0;
		$ScriptError = addRecord($ScriptError, "Due to script errors, animated backgrounds have been disabled.");
		%file = $Server::MissionFile;

		menuDestroyServer();
		menuSetMission(%file);
	} else {
		endMission();
	}

	commandToAll('MissionLoadFailed');
}

//-----------------------------------------------------------------------------

function endMission(%noSend) {
	$Server::Loaded = false;
	$Server::Loading = false;
	$Editor::Enabled = false;

	if (!isObject(MissionGroup))
		return;

	endFireWorks();

	echo("*** ENDING MISSION");

	// Inform the game code we're done.
	onMissionEnded();

	// Inform the clients
	for (%clientIndex = 0; %clientIndex < ClientGroup.getCount(); %clientIndex++) {
		// clear ghosts and paths from all clients
		%cl = ClientGroup.getObject(%clientIndex);
		if (!%noSend)
			%cl.endMission();
		%cl.resetGhosting();
		%cl.clearPaths();
	}

	// Delete everything
	while (isObject(MissionGroup))
		MissionGroup.delete();
	while (isObject(MissionCleanup))
		MissionCleanup.delete();
	while (isObject(FXGroup))
		FXGroup.delete();

	$ServerGroup.delete();
	$ServerGroup = new SimGroup(ServerGroup);

	//Clean up the last mission
	flushInteriorRenderBuffers();
	cleanupReflectiveMarble();
	loadMissionFinish(true);
}

//-----------------------------------------------------------------------------

function MPsendImageFile() {
	//Major hacks in this function: send the image file via an AudioProfile.
	// Security warning: technically this will allow any host to send any file.
	// Probably never going to be a problem though.

	// Create the mission image sender
	if (isObject(MissionImageSender))
		MissionImageSender.delete();

	// Try to find their image
	$MP::MissionImage = filePath($Server::MissionFile) @ "/" @ fileBase($Server::MissionFile) @ ".png";
	if (!isFile($MP::MissionImage))
		$MP::MissionImage = filePath($Server::MissionFile) @ "/" @ fileBase($Server::MissionFile) @ ".jpg";
	if (!isFile($MP::MissionImage))
		$MP::MissionImage = filePath($Server::MissionFile) @ "/" @ fileBase($Server::MissionFile) @ ".bmp";

	// If we found it, create an AudioProfile for us
	if (isFile($MP::MissionImage)) {
		//We can use a global variable to make this eval much simpler
		eval("datablock AudioProfile(MissionImageSender) {" @
		     "filename = $MP::MissionImage;" @
		     "description = \"AudioDefault3d\";" @
		     "};");
	}
}

function GameConnection::sendMissionScript(%this) {
	for (%i = 0; %i < %client.sentFiles; %i ++) {
		%client.sentFile[%client.sentFile[%i]] = "";
		%client.sentFile[%i] = "";
	}
	%client.sentFiles = 0;

	if (fileExt($Server::MissionFile) $= ".mcs") {
		//Don't send people mcs files cause they break stuff
		return;
	} else {
		%script = filePath($Server::MissionFile) @ "/" @ fileBase($Server::MissionFile) @ ".cs";
		if (isFile(%script)) {
			commandToClient(%this, 'MissionScript', %script, false, "");
		} else if (isFile(%script @ ".dso")) {
			commandToClient(%this, 'MissionScript', %script @ ".dso", true, "");
		} else {
			commandToClient(%this, 'MissionScript', "", false, -1);
		}
	}
}

function serverCmdMissionScriptError(%client, %file, %dso) {
	if (%dso) {
		error("Client" SPC %client.getUsername() SPC "does not have compiled script" SPC %file @ ". You need to send it to them.");
	} else if (!%client.sentFile[%file]) {
		error("Client" SPC %client.getUsername() SPC "does not have script" SPC %file @ ". Sending it automagically.");
		%client.sendFile(%file);
		%client.sentFile[%file] = true;
		%client.sentFile[%client.sentFiles] = %file;
		%client.sentFiles ++;
		commandToClient(%client, 'MissionScript', %file, false, "");
	}
}
