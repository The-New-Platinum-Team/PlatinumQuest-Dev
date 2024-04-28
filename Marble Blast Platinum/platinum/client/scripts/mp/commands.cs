//------------------------------------------------------------------------------
// Multiplayer Package
// clientCmds.cs
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
// PlayGui Commands

function clientCmdStartTimer() {
	PlayGui.startTimer();
	PlayGui.refreshRed();
}

function clientCmdStopTimer() {
	PlayGui.stopTimer();
	PlayGui.refreshRed();
}

function clientCmdResetTimer() {
	PlayGui.resetTimer();
	PlayGui.refreshRed();
}

function clientCmdSetTimeStopped(%stopped) {
	PlayGui.setTimeStopped(%stopped);
}

function clientCmdSetMessage(%message, %timeout) {
	PlayGui.setMessage(%message, %timeout);
}

function clientCmdSetGemCount(%gems, %best) {
	PlayGui.setGemCount(%gems, %best);

	if ($Record::Recording) {
		if ($Game::isMode["quota"]) {
			recordWriteGems(RecordFO, %gems, $Game::GemCount, PlayGui.maxGems, %best);
		} else {
			recordWriteGems(RecordFO, %gems, PlayGui.maxGems, PlayGui.maxGems, %best);
		}
	}
}

function clientCmdSetMaxGems(%gems) {
	PlayGui.setMaxGems(%gems);
}

function clientCmdDisplayGemMessage(%amount, %color) {
	PlayGui.displayGemMessage(%amount, %color);
}

function clientCmdAddHelpLine(%line, %playBeep) {
	addHelpLine(%line, %playBeep);
}

function clientCmdAddBubbleLine(%line, %help, %isAHelpBubble) {
	addBubbleLine(%line, %help, "", %isAHelpBubble);
}

function clientCmdHideBubble() {
	hideBubble();
}

function clientCmdAdjustTimer(%time) {
	PlayGui.adjustTimer(%time);
}

function clientCmdAddBonusTime(%time) {
	PlayGui.addBonusTime(%time);
}

function clientCmdSetBonusTime(%time) {
	PlayGui.setBonusTime(%time);
}

function clientCmdSetTime(%time) {
	PlayGui.setTime(%time);
}

function clientCmdPlayPitchedSound(%sound) {
	playPitchedSound(%sound);
}

function clientCmdActivateMovingObjects(%active) {
	$Client::MovingObjectsActive = %active;
	setSimuatingPathedInteriors(%active);
}

function clientCmdMegaMarble(%mega) {
	$Client::MegaMarble = %mega;
	Physics::reloadLayers();
}

function clientCmdUpdateMarbleShape(%marble) {
	%obj = getClientSyncObject(%marble);
	if (isObject(%obj)) {
		%obj.reloadShader();
	}
}

function clientCmdFoundEgg(%time, %eggName, %eggPickup) {
	PlayGui.showEggTime(%time);

	if ($playingDemo) {
		// Just play the sound and return, using the already-found sound effect
		commandToServer('EggStatus', false, %eggName, %eggPickup);
		return;
	}

	//Record the egg
	$Game::EasterEgg = true;
	$Game::EasterEggTime = %time;

	%first = ($pref::EasterEggTime[$Server::MissionFile] $= "");
	if ($pref::EasterEggTime[$Server::MissionFile] $= "") {
		$pref::EasterEggTime[$Server::MissionFile] = %time;
	} else {
		$pref::EasterEggTime[$Server::MissionFile] = min(%time, $pref::EasterEggTime[$Server::MissionFile]);
	}

	if (lb()) {
		%saved = PlayMissionGui.onlineEasterEggCache.getFieldValue(PlayMissionGui.getMissionInfo().id);

		if (%time < %saved || %saved $= "") {
			PlayMissionGui.onlineEasterEggCache.setFieldValue(PlayMissionGui.getMissionInfo().id, %time);
		}

		commandToServer('EggStatus', (%saved $= ""), %eggName, %eggPickup);
		statsRecordEgg(PlayMissionGui.getMissionInfo(), %time);
	} else {
		commandToServer('EggStatus', %first, %eggName, %eggPickup);
	}
	if (PlayMissionGui.ml.shouldCheckAchievements($CurrentGame)) {
		checkNestEggAchievements();
		Unlock::updateCaches();
	}
	savePrefs();
}

function clientCmdSetToggleCamera(%toggle) {
	if (%toggle) {
		Physics::pushLayerName("toggleCamera");
	} else {
		Physics::popLayerName("toggleCamera");
	}
}

function clientCmdActivateAchievement(%catId, %achId) {
	activateAchievement(%catId, %achId);
}

function clientCmdSetPowerUp(%powerUp, %id, %skinName) {
	PlayGui.setPowerUp(%powerUp, %skinName);
	$MP::MyMarble.powerUpId = %id;
}

function clientCmdLockPowerup(%locked) {
	cancel($CannonLockPowerupSchedule);
	$powerupLocked = %locked;
	PlayGui.lockPowerup(%locked);

	if (!%locked) {
		usePowerup($mouseFire);
	}
}

function clientCmdDoPowerUp(%powerUpId) {
	//Crashes if ID > 5
	if (%powerUpId > 5)
		return;
	$Client::UsedPowerup[%powerUpId] = true;
	$MP::MyMarble.doPowerUp(%powerUpId);
}

function clientCmdActivatePowerUp(%powerUpId) {
	$Client::UsedPowerup[%powerUpId] = true;
	$Game::PowerupActive[%powerUpId] = true;
	$Game::PowerupStart[%powerUpId] = getSimTime();

	if (%powerupId >= 3 && %powerupId <= 5) {
		// [1] Super Jump / [2] Super Speed / [8] Anvil are instant.
		// [3] Super Bounce, [4] Shock Absorber, [5] Gyrocopter
		// [6] Mega Marble 10s, [7] Teleporter 2s. Handled by their respective powerup codes.
		// [9] Nerfed super jump for White Noise PQ level.
		PlayGui.pushPowerupTimer(%powerupId, getSimTime(), $MP::MyMarble.getDataBlock().powerUpTime[%powerupId]);
	}
	//if (%powerUpId == 6)
	//MegaRollingHardSfx.filename = RollingHardSfx.filename = "~/data/sound/mega_roll.wav";
	//Mega Marble sounds require engine hacks
}
function clientCmdDeactivatePowerUp(%powerUpId) {
	$Game::PowerupActive[%powerUpId] = false;
	//if (%powerUpId == 6)
	//MegaRollingHardSfx.filename = RollingHardSfx.filename = "~/data/sound/Rolling_Hard.wav";
}

function clientCmdSetCameraFov(%fov) {
	setCameraFov(%fov);
}

function clientCmdInitSprng(%seed) {
	if (!$Server::Hosting) {
		initSprng(%seed);
	}
}

// Totally not disguised name!
function clientCmdGameStatus(%status) {
	$Editor::Opened = %status;
	if (%status) {
		$Game::CameraSpeedMultiplier = 1;
		$Game::MovementSpeedMultiplier = 1;
	}
}

function clientCmdNoCollision(%item) {
	if (isObject(%item))
		%item.hide(false);
}

function clientCmdStartCountdown(%time, %icon) {
	PlayGui.startCountdown(%time, %icon);
}
function clientCmdStartCountdownLeft(%time, %icon) {
	PlayGui.startCountdownLeft(%time, %icon);
}
function clientCmdSetHuntCompetitiveTimer(%time) {
	// I think the hunt competitive timer doesn't work in MP, because the host needs to get all info about the timer to set it. So we gotta call this to all clients and then the host will update.
	PlayGui.startCountdownLeft(%time, "timerHuntRespawn");
}

function clientCmdIncrementOOBCounter() {
	//Don't oob if we're exiting
	if ($Server::ServerType $= "" || $Game::Menu || $Game::Credits)
		return;
	// HOORAY FOR THE OOB COUNTER !!!
	if (lb()) {
		$LBPref::OOBCount ++;
	}
	$pref::LevelOOBs[strreplace($Client::MissionFile, "lbmission", "mission")] ++;
	if (!$playingDemo && $Server::ServerType !$= "Multiplayer") { // no MP mode
		$PREF::OOBCOUNT ++;
		if ($Pref::ShowOOBMessages) {
			if (OOBCounter::check())
				echo("You got owned.");
		}
	}
}

function clientCmdSetGameState(%state) {
	// Host gets these already
	if (!$Server::Hosting || $Server::_Dedicated)
		$Game::State = %state;
}

//-----------------------------------------------------------------------------
// Ghost / Marble commands

// applys an impulse to each client
function clientCmdApplyImpulse(%position,%impulse) {
	if (MPMyMarbleExists())
		$MP::MyMarble.applyImpulse(%position,%impulse);
}

// Multiplies impulse vector by gravity, then impulses
function clientCmdGravityImpulse(%position,%impulse) {
	if (MPMyMarbleExists())
		$MP::MyMarble.applyImpulse(%position,VectorMult(VectorScale(%impulse, -1), getGravityDir()));
}

function clientCmdSetMarbleVelocity(%velocity) {
	$MP::MyMarble.setVelocity(%velocity);
}

function clientCmdMarbleTeleport(%offset) {
	if (MPMyMarbleExists())
		$MP::MyMarble.setTransform(VectorAdd(getWords($MP::MyMarble.getTransform(), 0, 2), %offset) SPC getWords($MP::MyMarble.getTransform(), 3));
}

// Fix them!
function clientCmdFixGhost() {
	fixGhost();
}

function clientCmdWaitForEndgame() {
	// Called right when you start doing the "victory" stage of the endgame
	RootGui.popDialog(MPExitGameDlg);

	//Disable respawning
	$Client::GameRunning = false;
	cancel($forceRespawn);
}

function clientCmdEndGameSetup(%score, %elapsed, %bonus, %finisherIndex) {
	// Single player... grab the playgui as the elapsed time and
	// roll in clients penalty and bonus
	PlayGUI.stopTimer();

	$Game::FinalScore = %score;
	$Game::ElapsedTime = %elapsed;
	$Game::BonusTime = %bonus;
	$Game::FinisherIndex = %finisherIndex; //Used in coop
}

// Called when adding a ghost to the list
function clientCmdGhostId(%index, %id) {
	PlayerList.getEntry(%index).marbleId = %id;

	//See if they have a marble
	%marble = getClientSyncObject(%id);
	if (isObject(%marble)) {
		PlayerList.getEntry(%index).player = %marble;
		%marble.index = %index;
	}

	//Attach particles and stuff
	fixGhost();
}

function onNewMarble(%marble, %index) {
	PlayerList.getEntry(%index).player = %marble;
	%marble.index = %index;

	//Now that we know what shaders it should use, reset it
	%marble.reloadShader();
}

//-----------------------------------------------------------------------------
// other commands

function clientCmdTeamChat(%sender, %team, %leader, %message) {
	onTeamChat(%sender, %team, %leader, %message);
}

// if you try to somehow play when clients are not ready
function clientCmdHostNotReady() {
	LBAssert("Error!", "Not all clients are ready.  Please wait..");
}

// push the dialog
function clientCmdPushDialog(%dialog) {
	if (isObject(%dialog))
		RootGui.pushDialog(%dialog);
}

// pop the dialog
function clientCmdPopDialog(%dialog) {
	if (isObject(%dialog))
		RootGui.popDialog(%dialog);
}

function clientCmdSetPregame(%isPregame) {
	$Game::Pregame = %isPregame;
	if (%isPregame && RootGui.getContent().getName() $= "PlayGui") {
		disableChatHUD();
		RootGui.pushDialog(MPPreGameDlg);
	} else {
		RootGui.popDialog(MPPreGameDlg);
		hideControllerUI();
	}
}

function clientCmdUpdatePregame() {
	MPPreGameDlg.update();
}

function clientCmdSetBlastValue(%blastValue) {
	$MP::BlastValue = %blastValue;
	PlayGui.setBlastValue(%blastValue);
	PlayGui.updateBlastBar();
}

function clientCmdSetSpecialBlast(%special) {
	$MP::SpecialBlast = %special;
	PlayGui.updateBlastBar();
}

// receive private chat
function clientCmdPrivateMessage(%name, %message) {
	onServerChat(%name, %message);
//   addLBChatLine(%message);
}

function clientCmdHostStatus(%status) {
	$Server::Hosting = %status;
	MPPreGameDlg.updateActive();
	MPEndGameDlg.updateActive();
	MPExitGameDlg.updateActive();

	//Update the level select
	PlayMissionGui.init();
	if ($Server::Lobby) {
		PlayMissionGui.initInterface();
		PlayMissionGui.updateMPButtons();
	}

	if (!%status) {
		Canvas.popDialog(MPDedicatedServerDlg);
		Canvas.popDialog(MPDedicatedPlayersDlg);
	}
}

function clientCmdDedicated(%status) {
	$Server::_Dedicated = %status;
}

function clientCmdEnableMovementKeys(%enabled) {
	if (%enabled) {
		Physics::popLayerName("noMovement");
	} else {
		Physics::pushLayerName("noMovement");
	}
}

function clientCmdShockwave(%mePos, %strength, %myMod, %theyMod) {
	%theyPos = $MP::MyMarble.getWorldBoxCenter();
	if (VectorDist(%theypos, %mePos) < %strength) {
		%dist = VectorSub(%theypos, %mepos);
		%dist = VectorScale(VectorNormalize(%dist), %strength);
		$MP::MyMarble.applyImpulse("0 0 0", VectorScale(%dist, %theyMod / %myMod));
	}
}

function clientCmdServerSetting(%setting, %value) {
	//TODO: Port these to the other settings
	switch$ (%setting) {
	case "ForceSpectators":
		$Server::ForceSpectators = %value;
	case "MaxPlayers":
		$Server::MaxPlayers = %value;
	}
}

function clientCmdServerSettingsList() {
	MPDedicatedServerDlg.resetSettings();
}

function clientCmdServerSettingsListItem(%id, %name, %value, %type, %min, %max) {
	MPDedicatedServerDlg.addSetting(%id, %name, %value, %type, %min, %max);

	$MP::Client::ServerSetting[%id] = %value;
	$MP::Client::ServerSetting[%id, "name"]  = %name;
	$MP::Client::ServerSetting[%id, "type"]  = %type;
	$MP::Client::ServerSetting[%id, "min"]   = %min;
	$MP::Client::ServerSetting[%id, "max"]   = %max;
}

function clientCmdServerSettingsListEnd() {
	MPDedicatedServerDlg.generateSettings();
	PlayMissionGui.updateMissionInfo();
}

function clientCmdFreezeMarble(%frozen, %position) {
	$MP::MyMarble.freeze(%frozen, %position);
}

//-----------------------------------------------------------------------------
// CRC Checking
// CRC validation will check to ensure that clients are not cheating.
// although not totally perfect, it will provide a sufficient amount
// of protection and will also prevent hacked up servers from being used.
// Note this will only CRC the .cs.dso files
//
// Also will check .cs.dso file counts to ensure that we dont have
// additional scripts

function clientCmdCheckCRC() {
	if (%this.pinging)
		return;

	// Update the message
	LBMessage("Verifying with server", "disconnect();");

	// The server gives us absolutely no information about what we should
	// send. That bastard! We'll show him!

	// We should probably do a compile, just to make sure we have what the
	// server wants. Don't want to be denied, now do we?

	%patterns = "*.cs;*.gui";

	// Turn off logging, nobody needs to see this!
	%buff = $Con::LogBufferEnabled;
	$Con::LogBufferEnabled = false;

	%compiled = false;

	// Token-separated fields
	while (%patterns !$= "") {
		%patterns = nextToken(%patterns, "exp", ";");

		for (%file = findFirstFile(%exp); %file !$= ""; %file = findNextFile(%exp)) {
			// Leaving a hole in because some level scripts were boning people (these scripts are never exec'd, only read+eval'd)
			if (filePath(filePath(filePath(%file))) $= ($usermods @ "/data/multiplayer"))
				continue;
			// We should compile all of these files, just to be sure
			if (!isFile(%file @ ".dso")) {
				if (compile(%file))
					%compiled = true;
				else {
					// If it didn't compile, well shit! We'll just have to send
					// the old .dso and hope the server likes it!
					$Con::LogBufferEnabled = %buff;
					devecho("Could not compile file:" SPC %file);
					$Con::LogBufferEnabled = false;
				}
			}
		}
	}

	// If any new files blipped into existence, tell us about them!
//   if (%compiled)
//      setModPaths($usermods);

	// Turn it back on, we want info!
	$Con::LogBufferEnabled = %buff;

	// Let the server know we're about to flood it with CRCs
	// Otherwise it won't let know we're coming, and will just ignore us.
	commandToServer('StartCRC');

	%files = 0;
	%sendPattern = "*.dso";
	for (%file = findFirstFile(%sendPattern); %file !$= ""; %file = findNextFile(%sendPattern)) {
		if (strPos(strlwr(%file), "prefs.cs") != -1 || strPos(strlwr(%file), ".svn") != -1 || strPos(strlwr(%file), "config.cs") != -1 || strPos(strlwr(%file), "banlist.cs") != -1)
			continue;
		if (filePath(filePath(filePath(%file))) $= ($usermods @ "/data/multiplayer"))
			continue;
		//Ignore mcs.dso
		if (fileExt(%file) $= ".dso" && fileExt(fileBase(%file)) $= ".mcs")
			continue;

		// For each of these files, we should send it to the server
		commandToServer('FileCRC', %file, getFileCRC(%file));

		// The server wants to know how many files we have!
		%files ++;
	}

	// Let the server we've finished. It'll either kick us out, or nicely
	// let us join. Hopefully we've managed to satisfy it's requirements!
	commandToServer('FinishCRC', %files);
}

function clientCmdCRCError(%error) {
	devecho("\c2There was a CRC error:" SPC %error);
}


function clientCmdVerifySession() {
	// We need to verify out session with the server. Let's hope it likes
	// us! (Insider note: the server does not like the client)

	LBMessage("Verifying Session...", "disconnect();");
	commandToServer('VerifySession', $LBGameSess, false);
}

function clientCmdVerifySuccess() {
	// Hooray, the server accepts us! Maybe it'll give us a belly rub :3
}

/// Sets the datablock names
function clientCmdRecDataBlockNames(%list) {
	%count = getFieldCount(%list);
	for (%i = 0; %i < %count; %i++) {
		%field = getField(%list, %i);
		%obj = getWord(%field, 0);
		%name = getWord(%field, 1);
		%obj.setName(%name);

		devecho("Setting datablock id" SPC %obj SPC "to be named" SPC %name);
	}
}

function clientCmdMarblelandDownload(%id) {
	marblelandDownload(%id, clientMarblelandDownloadFinished);
}

function clientCmdMarblelandHasMission(%id) {
	commandToServer('MarblelandHasMissionStatus', %id, marblelandHasMission(%id));
}

function clientMarblelandDownloadFinished(%id, %success) {
	commandToServer('MarblelandDownloadStatus', %id, %success);
}

function clientCmdMarblelandLoad(%id) {
	marblelandLoad(%id);
}
