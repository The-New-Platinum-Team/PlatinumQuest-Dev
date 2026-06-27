//-----------------------------------------------------------------------------
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

$ReplayVersion = 28;

$RecordTag["time"] = 1;
$RecordTag["position"] = 2;
$RecordTag["platform"] = 3;
$RecordTag["scores"] = 4;
$RecordTag["spawn"] = 5;
$RecordTag["pickup"] = 6;
$RecordTag["physics"] = 7;
$RecordTag["collision"] = 8;
$RecordTag["gravity"] = 9;
$RecordTag["gems"] = 10;
$RecordTag["movement"] = 11;
$RecordTag["time2"] = 12;

$ReplayForceThreshold = 0.5;

function rt() {
	playReplay(findFirstFile("platinum/data/recordings/*.rrec"));
}
function rnt(%a) {
	playReplay(findFirstFile("platinum/data/recordings/" @ %a @ ".rrec"));
}
function pb() {
	return PlaybackGroup.getObject(0);
}

if (!isObject(PlaybackGroup)) {
	RootGroup.add(new SimGroup(PlaybackGroup));
}

function recordMissionReplay(%file) {
	//Marble doesn't exist-- we need to wait before starting so we don't get problems
	cancel($Record::StartSchedule);
	if (!MPMyMarbleExists()) {
		$Record::StartSchedule = schedule(10, 0, recordMissionReplay, %file);
		return;
	}

	//Generate a default filename if we aren't given one
	if (%file $= "") {
		%base = $userMods @ "/data/recordings/";
		%file = alphaNum(fileBase($Client::MissionFile));

		//Just take the level's name and add a number to the end, incrementing
		// until it's free
		%index = 0;
		while (isFile(%base @ %file @ %index @ ".rrec")) {
			%index ++;
		}
		%file = %base @ %file @ %index @ ".rrec";
		echo(%file);
	}

	recordStart($MP::MyMarble, %file);
	$Record::Started = true;
}

function recordStart(%object, %file) {
	new ReplayObject(RecordFO);
	$Record::Started = false;
	$Record::Marble = %object;
	$Record::Recording = true;
	$Record::File = %file;

	recordWriteHeader(RecordFO);
	recordWriteTime(RecordFO);
	recordWriteGravity(RecordFO, 1);
	if (ClientSpawnedArray.getSize() > 0 && $Client::WaitingSpawnCount <= 0) {
		%writeSpawn = true;
		// Don't write if we're missing any gems from the spawn set
		for (%i = 0; %i < ClientSpawnedArray.getSize(); %i ++) {
			%syncId = ClientSpawnedArray.getEntry(%i);
			if (!isObject(getClientSyncObject(%syncId))) {
				%writeSpawn = false;
				break;
			}
		}
		if (%writeSpawn) {
			recordWriteSpawn(RecordFO);
		}
	}
	if ($Game::isMode["quota"]) {
		recordWriteGems(RecordFO, PlayGui.gemCount, $Game::GemCount, PlayGui.maxGems, PlayGui.gemGreen);
	} else {
		recordWriteGems(RecordFO, PlayGui.gemCount, PlayGui.maxGems, PlayGui.maxGems, PlayGui.gemGreen);
	}
	recordWriteMovement(RecordFO);
}

function recordFinish() {
	//Shut it down
	RecordFO.write($Record::File);
	RecordFO.delete();

	$Record::Recording = false;
	$Record::Started = false;
}

function recordEnd(%cb) {
	if (isEventPending($recordFinish)) {
		cancel($recordFinish);
	}
	if ($Record::Recording) {
		recordFinish();
	}
	if ($Record::NeedSave) {
		CompleteDemoDlg.open(%cb);
		return true;
	}
	return false;
}

function recordOnRespawn() {
	echo("ROR " @ $Record::Started);
	if (!$Record::Started) {
		$Record::Started = true;
		recordLoop();
	} else {
		recordReset();
	}
}

function recordReset() {
	recordFinish();
	recordStart($Record::Marble, $Record::File);

	$Record::Started = true;
}

function recordLoop(%delta) {
	if (!$Record::Recording)
		return;

	if (!isObject($Record::Marble)) {
		$Record::Marble = $MP::MyMarble;
	}
	if (!isObject($Record::Marble)) {
		//No this isn't going to be any better
		return;
	}

	if ($Record::Started) {
		//Write a line of data for us
		recordWriteTime(RecordFO);
		recordWritePosition($Record::Marble, RecordFO);
		recordWritePlatforms(RecordFO);
	}
}

function recordWriteHeader(%replay) {
	//Flags are metadata / lb / mp

	%replay.replayVersion = $ReplayVersion;
	%replay.gameVersion = $MP::RevisionOn;
	%replay.missionFile = $Server::MissionFile;
	%replay.marbleSelection = MarbleSelectDlg.getSelection();
	%replay.leaderboards = lb();
	%replay.multiplayer = mp();
	%replay.cameraSmoothing = !!$pref::cameraSmoothing;
	%replay.sprngSeed = $Server::SprngSeed;
}

function recordWriteMetadata(%replay, %author, %name, %desc) {
	%replay.author = %author;
	%replay.name = %name;
	%replay.desc = %desc;
}

function recordWriteTime(%replay) {
	%replay.writeTime();
}

function recordWritePosition(%object, %replay) {
	%replay.writePosition(%object);
}

function recordWritePlatforms(%replay) {
	%replay.writePlatforms();
}

function recordWriteScores(%stream) {
	%stream.writeRawU8($RecordTag["scores"]);
	//TODO
}

function recordWriteSpawn(%replay) {
	%replay.writeSpawn();
}

function recordWritePickup(%replay, %db, %position) {
	%replay.writePickup(%db, %position);
}

function recordWriteCollision(%replay, %db, %position) {
	%replay.writeCollision(%db, %position);
}

function recordWritePhysics(%replay) {
	%replay.writePhysics();
}

function recordCheckPhysicsUpdate(%stream) {
	%updated = false;
	//Check all attributes' values for changes
	%count = MarbleAttributeInfoArray.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%attribute = MarbleAttributeInfoArray.getEntry(%i);
		%field = %attribute.internalField;
		%value = Physics::getProperty(%field);

		if (%stream._lastPhysics[%field] !$= %value) {
			//Updated one
			%updated = true;
			break;
		}
	}

	if (%updated) {
		recordWritePhysics(%stream);
	}
}

function recordWriteGravity(%replay, %instant) {
	%replay.writeGravity(%instant);
}

function recordWriteGems(%replay, %count, %max, %quota, %green) {
	%replay.writeGems(%count, %max, %quota, %green);
}

function recordWriteMovement(%replay) {
	%replay.writeMovement();
}

//-----------------------------------------------------------------------------

function recordGetPathedInteriors(%group, %list) {
	if (%group $= "")
		%group = MissionGroup;
	if (%list $= "")
		%list = Array(ReplayPathedInteriorsArray);

	if (!isObject(%group)) {
		return %list;
	}

	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();
		if (%class $= "SimGroup") {
			//Recursion
			recordGetPathedInteriors(%obj, %list);
		} else if (%class $= "PathedInterior") {
			%id = %obj.getSyncId();
			%client = getClientSyncObject(%id);
			if (isObject(%client)) {
				%list.addEntry(%client);
			} else {
				//Don't have a client object, just use the server one for now and
				// tell it to update asap
				%obj.forceNetUpdate();
				%list.addEntry(%obj);
			}
		}
	}

	return %list;
}

//-----------------------------------------------------------------------------

function playReplay(%file, %race) {
	//Read the header from the replay
	%info = getReplayInfo(%file);
	if(!%race)
		$playingDemo = true;
	$demoLB = %info.lb;

	//Go find it on pmg
	// check if it is marbleland
	if (marblelandIsMission(%info.missionFile)) {
		%minfo = marblelandGetMission(marblelandGetFileId(%info.missionFile));
	} else {
		%minfo = getMissionInfo(%info.missionFile);
	}
	if (%minfo == -1) {
		MessageBoxOk("Error", "Error loading the replay. Check your console.");
		$playingDemo = 0;
		return;
	}
	PlayMissionGui.setSelectedMission(%minfo);

	echo("Need to load mission " @ %info.missionFile @ " and replay " @ %file);

	$Playback::CurrentFile = %file;
	$Playback::Ghost = %race;

	//How convenient
	deactivateMenuHandler("PMMenu");
	activateMenuHandler("Replay");
	RootGui.setContent(LoadingGui);

	if ($Menu::Loaded && $Menu::MissionFile $= %info.missionFile) {
		Replay_MissionLoaded();
	} else {
		menuLoadMission(%info.missionFile);
	}
}

function Replay_MissionLoaded() {
	echo("Playing replay");
	menuPlay();
}

function Replay_Play() {
	deactivateMenuHandler("Replay");
	%file = $Playback::CurrentFile;

	if(!$Playback::Ghost) {
		//Get replay marble info
		%info = getReplayInfo(%file);
		playbackPlayer(%file, %info.marbleSelection);
	}
}

function Replay_MissionLoadFailed() {
	//Oh no we're hosed
	menuMissionEnd();
	if (lb()) {
		RootGui.setContent(PlayMissionGui);
	} else {
		RootGui.setContent(MainMenuGui);
	}
	Canvas.pushDialog(PlayDemoGui);
	MessageBoxOk("Error", "Error loading the replay. Check your console.");
	$playingDemo = 0;
}

function clientCmdStopReplays() {
	if (isObject(PlaybackGroup)) {
		for (%i = PlaybackGroup.getCount() - 1; %i >= 0; %i --) {
			%info = PlaybackGroup.getObject(%i);
			if (!%info.ghost) {
				continue;
			}
			%info.finish();
		}
	}
}

function clientCmdRestartReplays() {
	if (isObject(PlaybackGroup)) {
		for (%i = PlaybackGroup.getCount() - 1; %i >= 0; %i --) {
			%info = PlaybackGroup.getObject(%i);
			if (!%info.ghost) {
				continue;
			}
			%info.replay.rewind();
		}
	}
}

function playbackCancel() {
	//Kill any running demos
	if (isObject(PlaybackGroup)) {
		for (%i = PlaybackGroup.getCount() - 1; %i >= 0; %i --) {
			%info = PlaybackGroup.getObject(%i);
			if (%info.ghost) {
				continue;
			}
			%info.finish();
		}
	}
}

function onDemoPlayDone(%replay) {
	%replay.info.finish();

	if ($playingDemo) {
		$playingDemo = false;
	}

	$pref::cameraSmoothing = $TempCameraSmoothing; // Reset this back to what it was

	//Dump stats
	echo("------------------------------------------------------------");
	echo(" REPLAY STATS:");
	echo(" Final Time: " @ $Time::CurrentTime);
	echo(" Total Bonus: " @ $Time::TotalBonus);
	echo(" Gem Count: " @ LocalClientConnection.gemCount);
	echo(" Gems Collected: " @ LocalClientConnection.gemPickupCount);
	echo("  - Red: " @ LocalClientConnection.gemsFound[1]);
	echo("  - Yellow: " @ LocalClientConnection.gemsFound[2]);
	echo("  - Blue: " @ LocalClientConnection.gemsFound[5]);
	echo("  - Platinum: " @ LocalClientConnection.gemsFound[10]);
	echo("------------------------------------------------------------");

	//Reset input
	$mvLeftAction = 0;
	$mvRightAction = 0;
	$mvForwardAction = 0;
	$mvBackwardAction = 0;
	usePowerup(0);
	jump(0);
	mouseFire(0);
	useBlast(0);
	forceRespawn(0);

	//Exit the mission
	menuDestroyServer();
	PlayMissionGui.setSelectedMission(PlayMissionGui.getMissionInfo());

	//Back to where we started
	if (lb()) {
		if ($replayFromWorldRecord) {
			RootGui.setContent(PlayMissionGui);
			PlayMissionGui.showGlobalScores();
		} else {
			RootGui.setContent(LBChatGui);
		}
	} else {
		RootGui.setContent(MainMenuGui);
	}
	if ($replayFromPlayDemoGui)
		Canvas.pushDialog(PlayDemoGui);

	$replayFromPlayDemoGui = false;
	$replayFromWorldRecord = false;
}

function playbackSyncStart(%object, %info) {
	%file = getField(%info, 0);
	%ghost = getField(%info, 1);
	%start = getField(%info, 2);
	playbackStart(%object, %file, %ghost, %start);
}

function playbackStart(%object, %file, %ghost, %start) {
	PlaybackGroup.add(%info = new ScriptObject() {
		class = "PlaybackInfo";
	});
	%info.marble = %object;
	echo("the marble is:" SPC %info.marble);
	%info.file = %file;
	%info.ghost = %ghost;
	%info.start = %start;

	%info.start();
}

function PlaybackInfo::start(%this) {
	%this.playing = true;
	%this.replay = new ReplayObject(PlaybackFO);
	%this.replay.info = %this;
	if (!%this.replay.open(%this.file)) {
		%this.finish();
		return;
	}

	if (%this.ghost) {
		%this.replay.setGhostMarble(%this.marble);
		if($Game::isMode["hunt"]) {
			PGScoreListContainer.setVisible(true);

			%author = %this.replay.author !$= "" ? %this.replay.author : "Player";
			%player1 = $pref::highscoreName TAB "0" TAB "0 0 0 0" TAB "0" TAB strreplace(MarbleSelectDlg.getSelection(), "\t", "\\t") TAB "0";
			%player2 = "Past" SPC %author TAB "0"  TAB "0 0 0 0" TAB "1" TAB strreplace(%this.replay.marbleSelection, "\t", "\\t") TAB "0";

			clientCmdScoreListPlayer(%player1 NL %player2);
		}
	} else {
		MoveMap.pop();
		JoystickMap.pop();
		DemoMap.push();

		initSprng(%this.sprngSeed);
		$TempCameraSmoothing = $pref::cameraSmoothing;
		$pref::cameraSmoothing = %this.cameraSmoothing;
	}
}

function replayToggleCamera(%input) {
	if (%input) {
		if (LocalClientConnection.getControlObject() != LocalClientConnection.camera) {
			$mvLeftAction = 0;
			$mvRightAction = 0;
			$mvForwardAction = 0;
			$mvBackwardAction = 0;
			usePowerup(0);
			jump(0);
			mouseFire(0);
			useBlast(0);

			// Physics::popLayerName("noInput");
			MoveMap.push();
			JoystickMap.push();
			DemoMap.pop();
		} else {

			// Physics::pushLayerName("noInput");
			MoveMap.pop();
			JoystickMap.pop();
			DemoMap.push();
		}

		commandToServer('ToggleCamera');
	}
}

function delayDemoFinish() {
	$playingDemo = false;
}

function PlaybackInfo::finish(%this) {
	if (%this.destructing) {
		return; // to prevent onDemoPlayDone calling this function again
	}
	%this.destructing = true;
	if ($debugreplay) {
		backtrace();
		echo("Finishing replay playback");
	}

	if (%this.ghost) {
		if (isObject(%this.marble)) {
			%this.marble.setTransform("-1e9 -1e9 -1e9 1 0 0 0");
		}
	} else {
		//Controlling self, disable the disabling
		// Physics::popLayerName("noInput");
		endReplayPlayback();
	}

	if (isObject(%this.replay)) {
		%this.replay.delete();
	}

	%this.playing = false;
	%this.delete();
}

function PlaybackInfo::step(%this, %timeDelta) {
	if (%this.ghost) {
		// step the ghost playback
		%this.replay.stepGhost(%timeDelta);
		return;
	}
	if (!%this.started) {
		%this.started = true;
		%this.replay.beginPlayback();
	}
}

function PlaybackFO::applyReplayServerTime(%this, %total, %current, %bonus, %elapsed, %clientTotal, %clientCurrent, %clientBonus, %active) {
	$Time::TotalTime = %total;
	$Time::CurrentTime = %current;
	$Time::TotalBonus = %bonus;
	$Time::ElapsedTime = %elapsed;
	PlayGui.currentTime = %clientCurrent;
	PlayGui.bonusTime = %clientBonus;
	PlayGui.updateControls();
	PlayGui.updateTimeTravelCountdown();
}

function PlaybackFO::applyReplayTime(%this, %total, %current, %bonus, %active) {
	$Time::TotalTime = %total;
	$Time::CurrentTime = %current;
	$Time::TotalBonus = %bonus;
	PlayGui.currentTime = %current;
	PlayGui.bonusTime = %bonus;
	PlayGui.updateControls();
	PlayGui.updateTimeTravelCountdown();
}

function playbackStep(%timeDelta) {
	%count = PlaybackGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		PlaybackGroup.getObject(%i).step(%timeDelta);
	}
}

function PlaybackFO::applyReplaySpawn(%this, %position) {
	%gems = findObjectsAtPosition(%position);

	for (%j = 0; %j < %gems.getSize(); %j ++) {
		%gem = %gems.getEntry(%j);
		if (%gem.getClassName() $= "Item" && %gem.getDataBlock().className $= "Gem" && %gem.isHidden()) {
			if ($debugreplay)
				echo("Spawn gem " @ %gem @ " at " @ %position);
			spawnGem(%gem);
		}
	}

	%gems.delete();
}

function PlaybackFO::applyReplayPickup(%this, %db, %position) {
	%objs = findObjectsNearPosition(%position, 0.25);
	if (%objs.getSize() < 0) {
		%objs.delete();
		return;
	}
	for (%i = 0; %i < %objs.getSize(); %i ++) {
		%col = %objs.getEntry(%i);

		if (strStr(%db, "GemItem") == -1 || strStr(%col.getDataBlock().getName(), "GemItem") == -1) {
			if ((%col.getType() & $TypeMasks::GameBaseObjectType) && %col.getDataBlock().getName() !$= %db && (%col.getDataBlock().getName() !$= (%db @ "_MBU")))
				continue;
		}

		if ($debugreplay)
			echo("Hacky pickup of item at " @ %position);
		
		$Playback::DemoFrame = true; //Hack
		DefaultMarble.onCollision(LocalClientConnection.player, %col);
		$Playback::DemoFrame = false;
	}
	%objs.delete();
}

function PlaybackFO::applyReplayGhostPickup(%this, %db, %position) {
	%objs = findObjectsNearPosition(%position, 0.25);
	if (%objs.getSize() < 0) {
		%objs.delete();
		return;
	}
	for (%i = 0; %i < %objs.getSize(); %i ++) {
		%col = %objs.getEntry(%i);

		if (strStr(%db, "GemItem") == -1 || strStr(%col.getDataBlock().getName(), "GemItem") == -1) {
			if ((%col.getType() & $TypeMasks::GameBaseObjectType) && %col.getDataBlock().getName() !$= %db && (%col.getDataBlock().getName() !$= (%db @ "_MBU")))
				continue;
		}

		if ($debugreplay)
			echo("Hacky pickup of item at " @ %position);
		
		$Playback::DemoFrame = true; //Hack
		if(%this.info.ghost) {
			%ghost = %this.info.marble;
			if($pref::ghostReplayItems) {
				if(%notGem) {
					%pData = %col.getDataBlock();
					%pId = %pData._getPowerUpId();
					if(%pId != 0) {
						%ghost.powerUpData = %pData;
						%ghost._powerUpId = %pId;
					}
					%col.setFadeVal(0.75);
					%col.schedule(%col.respawnTime $= "" ? $Item::RespawnTime : %col.respawnTime, "setFadeVal", 1);
				} else {
					LocalClientConnection.playPitchedSound("opponentDiamond");
					if(!$Game::isMode["hunt"]) {
						%col.setFadeVal(0.75);
						%ghost.checkpointGem[%ghost.checkpointGemCount] = %col;
						%ghost.checkpointGemCount++;
					}
				}
			}
		}
		$Playback::DemoFrame = false;
	}
	%objs.delete();
}

function PlaybackFO::applyReplayCollision(%this, %db, %position) {
	%objs = findObjectsNearPosition(%position, 0.25);
	if (%objs.getSize() < 0) {
		%objs.delete();
		return;
	}
	for (%i = 0; %i < %objs.getSize(); %i ++) {
		%col = %objs.getEntry(%i);

		if (strStr(%db, "GemItem") == -1 || strStr(%col.getDataBlock().getName(), "GemItem") == -1) {
			if ((%col.getType() & $TypeMasks::GameBaseObjectType) && %col.getDataBlock().getName() !$= %db && (%col.getDataBlock().getName() !$= (%db @ "_MBU")))
				continue;
		}

		%db = %col.getDataBlock().getName();

		if ($debugreplay)
			echo("Hacky collision of item at " @ %position);

		$Playback::DemoFrame = true; //Hack
		%db.onCollision(%col, $Record::Marble);
		$Playback::DemoFrame = false;
	}
	%objs.delete();
}

function PlaybackFO::applyReplayGhostCollision(%this, %db, %position) {
	%objs = findObjectsNearPosition(%position, 0.25);
	if (%objs.getSize() < 0) {
		%objs.delete();
		return;
	}
	for (%i = 0; %i < %objs.getSize(); %i ++) {
		%col = %objs.getEntry(%i);

		if (strStr(%db, "GemItem") == -1 || strStr(%col.getDataBlock().getName(), "GemItem") == -1) {
			if ((%col.getType() & $TypeMasks::GameBaseObjectType) && %col.getDataBlock().getName() !$= %db && (%col.getDataBlock().getName() !$= (%db @ "_MBU")))
				continue;
		}

		%db = %col.getDataBlock().getName();

		if ($debugreplay)
			echo("Hacky collision of item at " @ %position);
		
		if(%this.info.ghost) {
			%ghost = %this.info.marble;
			if($pref::ghostReplayItems) {
				%col.playAudio(0, %col.getDataBlock().sound);
				// Hack: fake the ghost checkpoint (TODO: checkpoint triggers?)
				if(%col.getDataBlock().className $= "CheckPointClass") {
					if(%ghost.checkpoint != %col) {
						%ghost.checkpoint = %col;
						%ghost.checkpointGemCount = 0;
					}
				}
			}	
		}
	}
	%objs.delete();
}

function PlaybackFO::applyReplayPhysics(%this, %field, %value) {
	Physics::setProperty(%field, %value);
}

function PlaybackFO::applyReplayGravity(%this, %dir, %instant, %rot) {
	$Playback::DemoFrame = true;
	if (%instant || !orthoCompare(%dir, $Game::GravityDir)) {
		clientCmdSetGravityDir(%dir, %instant, %rot);
		LocalClientConnection.setGravityDir(%dir, %instant, %rot);
	}
	$Playback::DemoFrame = false;
}

function PlaybackFO::applyReplayGems(%this, %count, %max, %quota, %green) {
	LocalClientConnection.gemCount = %count;
	$Game::GemCount = %max;

	if ($Game::isMode["quota"]) {
		clientCmdSetGemQuota(%max, %quota);
	} else {
		PlayGui.setMaxGems(%max);
	}
	PlayGui.setGemCount(%count, %green);
}

function PlaybackFO::applyReplayGhostGems(%this, %count, %max, %quota, %green) {
	if (%this.info.ghost) {
		clientCmdScoreListUpdate(1, %this.count, "0 0 0 0", 0);
		return;
	}
}
//-----------------------------------------------------------------------------

function RecordRO::applyReplayGhostInput(%this, %flags) {
	%change = (%flags ^ %this.lastInput);
	%this.lastInput = %flags;

	if (%change & 1 << 0) {
		if(%this.marble.powerUpData.powerUpID !$= "" && %this.marble.powerUpData.powerUpID < 6)
			%this.marble.doPowerup(%this.marble.powerUpData.powerUpID);
		%this.marble.onPowerUpUsed();
	}
	if (%change & 1 << 5) {
		for(%i = 0; %i < %this.marble.checkpointGemCount; %i++) {
			%this.marble.checkpointGem[%i].setFadeVal(1);
		}
		%this.marble.checkpointGemCount = 0;
	}
}

//-----------------------------------------------------------------------------

function PlaybackFO::applyReplayMountImages(%this, %img0, %img1, %img2, %img3, %img4, %img5, %img6, %img7) {
	%object = $MP::MyMarble;
	%mountImages[0] = %img0;
	%mountImages[1] = %img1;
	%mountImages[2] = %img2;
	%mountImages[3] = %img3;
	%mountImages[4] = %img4;
	%mountImages[5] = %img5;
	%mountImages[6] = %img6;
	%mountImages[7] = %img7;
	for (%i = 0; %i < 8; %i ++) {
		%image = %mountImage[%i];

		%imageSlot = %i;

		if (%i == 1 && %image $= "ShockAbsorberImage") {
			%imageSlot = 4; // That fix
			%overrode[4] = true;
		}

		if (%i == 3 && (%image $= "ActualHelicopterImage" || %image $= "HelicopterImage_MBU" || %image $= "HelicopterImage_MBUBall")) {
			%imageSlot = 5; // That fix
			%overrode[5] = true;
		}

		if (%i == 3 && %mountImage[5] $= "SuperBounceImage")
			continue; // Don't override!!

		if (%i == 5 && %image $= "SuperBounceImage") {
			%imageSlot = 3; // That fix
			%overrode[3] = true;
		}

		if (%overrode[%i])
			continue;

		%current = %object.getMountedImage(%imageSlot);
		if (%image $= "ActualHelicopterImage" && !$pref::LegacyItems && MissionInfo.game $= "Ultra")
			%image = "HelicopterImage_MBUBall";
		if (isObject(%current)) {
			%current = %current.getName();
		}

		if (%image !$= %current) {
			if (%image $= "0") {
				%object.unmountImage(%imageSlot);
			} else {
				%object.mountImage(%image, %imageSlot);
			}
		}
	}
}

function PlaybackFO::applyReplayGhostMountImages(%this, %object, %img0, %img1, %img2, %img3, %img4, %img5, %img6, %img7) {
	%mountImages[0] = %img0;
	%mountImages[1] = %img1;
	%mountImages[2] = %img2;
	%mountImages[3] = %img3;
	%mountImages[4] = %img4;
	%mountImages[5] = %img5;
	%mountImages[6] = %img6;
	%mountImages[7] = %img7;
	for (%i = 0; %i < 8; %i ++) {
		%image = %mountImage[%i];

		%imageSlot = %i;

		if (%i == 1 && %image $= "ShockAbsorberImage") {
			%imageSlot = 4; // That fix
			%overrode[4] = true;
		}

		if (%i == 3 && (%image $= "ActualHelicopterImage" || %image $= "HelicopterImage_MBU" || %image $= "HelicopterImage_MBUBall")) {
			%imageSlot = 5; // That fix
			%overrode[5] = true;
		}

		if (%i == 3 && %mountImage[5] $= "SuperBounceImage")
			continue; // Don't override!!

		if (%i == 5 && %image $= "SuperBounceImage") {
			%imageSlot = 3; // That fix
			%overrode[3] = true;
		}

		if (%overrode[%i])
			continue;

		%current = %object.getMountedImage(%imageSlot);
		if (%image $= "ActualHelicopterImage" && !$pref::LegacyItems && MissionInfo.game $= "Ultra")
			%image = "HelicopterImage_MBUBall";
		if (isObject(%current)) {
			%current = %current.getName();
		}

		if (%image !$= %current) {
			if (%image $= "0") {
				%object.unmountImage(%imageSlot);
			} else {
				%object.mountImage(%image, %imageSlot);
			}
		}
	}
}

function interpolate(%a, %b, %t) {
	return %a + (%b - %a) * %t;
}

function cinterpolate(%a, %b, %t, %limit) {
	//Normalize angles so going from 359 deg to 1 deg doesn't pass through 180 deg
	if (%a > %b && (%a - %b) > (%limit / 2))
		%b += %limit;
	if (%b > %a && (%b - %a) > (%limit / 2))
		%a += %limit;
	return %a + (%b - %a) * %t;
}