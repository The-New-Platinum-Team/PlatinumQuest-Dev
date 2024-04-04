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

$ReplayVersion = 26;

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
if (!isObject(PlaybackFrameGroup)) {
	RootGroup.add(new SimGroup(PlaybackFrameGroup));
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
	new FileObject(RecordFO);
	if (RecordFO.openForWrite(%file)) {
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
}

function recordFinish() {
	//Shut it down
	RecordFO.close();
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

function recordWriteHeader(%stream) {
	//Flags are metadata / lb / mp
	%flags = 0 | (lb() << 1) | (mp() << 2);

	%stream.writeRawS16($ReplayVersion);
	%stream.writeRawS16($MP::RevisionOn);
	%stream.writeRawString8($Server::MissionFile);
	%stream.writeRawString8(MarbleSelectDlg.getSelection());
	%stream.writeRawU8(%flags);
	%stream.writeRawU32($Server::SprngSeed);
}

function recordWriteMetadata(%stream, %author, %name, %desc) {
	%stream.writeRawString8(%author);
	%stream.writeRawString8(%name);
	%stream.writeRawString16(%desc);
}

function recordWriteTime(%stream) {
	//Various fields that we need
	%stream.writeRawU8($RecordTag["time2"]);

	//Server time
	%stream.writeRawS32($Time::TotalTime);
	%stream.writeRawS32($Time::CurrentTime);
	%stream.writeRawS32($Time::ElapsedTime);
	%stream.writeRawS32($Time::BonusTime);
	//Client time
	%stream.writeRawS32(PlayGui.totalTime);
	%stream.writeRawS32(PlayGui.currentTime);
	%stream.writeRawS32(PlayGui.bonusTime);
	%stream.writeRawU8($PlayTimerActive);
}

function recordWritePosition(%object, %stream) {
	%stream.writeRawU8($RecordTag["position"]);

	recordWriteInput(%stream);
	%object.recordSerialize(%stream);
}

function recordWritePlatforms(%stream) {
	%stream.writeRawU8($RecordTag["platform"]);
	%platforms = recordGetPathedInteriors();
	%count = %platforms.getSize();
	%stream.writeRawS32(%count);
	for (%i = 0; %i < %count; %i ++) {
		%obj = %platforms.getEntry(%i);
		%stream.writeRawS32(%obj.getPathPosition());
		%stream.writeRawS32(%obj.getTargetPosition());
	}
	%platforms.delete();
}

function recordWriteScores(%stream) {
	%stream.writeRawU8($RecordTag["scores"]);
	//TODO
}

function recordWriteSpawn(%stream) {
	%stream.writeRawU8($RecordTag["spawn"]);
	//Write all gems
	%count = ClientSpawnedArray.getSize();
	%stream.writeRawS32(%count);
	for (%i = 0; %i < %count; %i ++) {
		%syncId = ClientSpawnedArray.getEntry(%i);
		%obj = getClientSyncObject(%syncId);
		%stream.writeRawPoint3F(%obj.getPosition());
	}
}

function recordWritePickup(%stream, %db, %position) {
	%stream.writeRawU8($RecordTag["pickup"]);
	%stream.writeRawString8(%db);
	%stream.writeRawPoint3F(%position);
}

function recordWriteCollision(%stream, %db, %position) {
	%stream.writeRawU8($RecordTag["collision"]);
	%stream.writeRawString8(%db);
	%stream.writeRawPoint3F(%position);
}

function recordWritePhysics(%stream) {
	//How many have been updated
	%total = 0;

	//Get all attributes' values and only write the ones that update
	%count = MarbleAttributeInfoArray.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%attribute = MarbleAttributeInfoArray.getEntry(%i);
		%field = %attribute.internalField;
		%value = Physics::getProperty(%field);

		if (%stream._lastPhysics[%field] !$= %value) {
			//Only write if it's updated
			%total ++;
			devecho("Write physics update: " @ %field);
		}
	}

	if (%total == 0) {
		return;
	}

	%stream.writeRawU8($RecordTag["physics"]);
	%stream.writeRawU8(%total);
	for (%i = 0; %i < %count; %i ++) {
		%attribute = MarbleAttributeInfoArray.getEntry(%i);
		%field = %attribute.internalField;
		%value = Physics::getProperty(%field);

		if (%stream._lastPhysics[%field] !$= %value) {
			//Only write if it's updated
			%stream.writeRawString8(%field);
			%stream.writeRawString8(%value);
		}
		%stream._lastPhysics[%field] = %value;
	}
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

function recordWriteGravity(%stream, %instant) {
	%stream.writeRawU8($RecordTag["gravity"]);

	//Now the gravity
	%stream.writeRawOrthoF($Game::GravityDir);
	%stream.writeRawU8(%instant);
	%stream.writeRawAngAxisF($Game::GravityRot);
}

function recordWriteGems(%stream, %count, %max, %quota, %green) {
	%stream.writeRawU8($RecordTag["gems"]);

	//Because some dickwad is going to use more than 255 gems
	%stream.writeRawU16(%count);
	%stream.writeRawU16(%max);
	%stream.writeRawU16(%quota);
	%stream.writeRawU8(%green);
}

function recordWriteMovement(%stream) {
	%stream.writeRawU8($RecordTag["movement"]);

	//These are F32 because controllers produce float moves
	%stream.writeRawF32($mvLeftAction);
	%stream.writeRawF32($mvRightAction);
	%stream.writeRawF32($mvForwardAction);
	%stream.writeRawF32($mvBackwardAction);
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

function playReplay(%file) {
	//Read the header from the replay
	%info = getReplayInfo(%file);
	$playingDemo = true;
	$demoLB = %info.lb;

	//Go find it on pmg
	%minfo = getMissionInfo(%info.missionFile);
	if (%minfo == -1) {
		MessageBoxOk("Error", "Error loading the replay. Check your console.");
		$playingDemo = 0;
		return;
	}
	PlayMissionGui.setSelectedMission(%minfo);

	echo("Need to load mission " @ %info.missionFile @ " and replay " @ %file);

	$Playback::CurrentFile = %file;

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

	//Get replay marble info
	%info = getReplayInfo(%file);
	playbackPlayer(%file, %info.marbleSelection);
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
	if (isObject(PlaybackFrameGroup)) {
		PlaybackFrameGroup.clear();
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

function onDemoPlayDone() {
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
	%info.fo = new FileObject();
	%info.marble = %object;
	%info.file = %file;
	%info.ghost = %ghost;
	%info.start = %start;

	%info.start();
}

function PlaybackInfo::start(%this) {
	%this.playing = true;
	if (%this.fo.openForRead(%this.file)) {
		if (!%this.readHeader()) {
			//No we can't
			%this.finish();
			return;
		}
		if (!%this.ghost) {
			//Controlling self, disable everything!
			Physics::pushLayerName("noInput");
			MoveMap.pop();
			JoystickMap.pop();
			DemoMap.push();

			initSprng(%this.sprngSeed);
		}
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

			Physics::popLayerName("noInput");
			MoveMap.push();
			JoystickMap.push();
			DemoMap.pop();
		} else {

			Physics::pushLayerName("noInput");
			MoveMap.pop();
			JoystickMap.pop();
			DemoMap.push();
		}

		commandToServer('ToggleCamera');
	}
}

function playbackDump(%file, %ghost) {
	$debugreplay = 1;
	PlaybackGroup.add(%info = new ScriptObject() {
		class = "PlaybackInfo";
	});
	%info.fo = new FileObject();
	%info.file = %file;
	%info.ghost = %ghost;

	%info.start();
	while (%info.readLine()) {

	}
	%info.finish();
	$debugreplay = 0;
}

function playbackDumpCsv(%file, %ghost) {
	$replaycsv = 1;
	PlaybackGroup.add(%info = new ScriptObject() {
		class = "PlaybackInfo";
	});
	%info.fo = new FileObject();
	%info.file = %file;
	%info.ghost = %ghost;

	$replayCSVFile = new FileObject();
	$replayCSVFile.openForWrite(%file @ ".csv");

	setPrintTime(false);
	$replayCSVFile.writeLine("total,current,bonus,active");
	//echo("x y z ax ay az aa vx vy vz");
	%info.start();
	while (%info.readLine()) {

	}
	if (isObject(%info)) {
		%info.finish();
	}
	$replayCSVFile.close();
	$replayCSVFile.delete();

	$replaycsv = 0;
}

function PlaybackInfo::finish(%this) {
	//Shut it down
	if (isObject(%this.fo)) {
		%this.fo.close();
		%this.fo.delete();
	}

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
		Physics::popLayerName("noInput");
		if ($playingDemo) {
			onDemoPlayDone(false);
			$playingDemo = false;
		}
	}

	%this.playing = false;
	%this.delete();
}

function PlaybackInfo::readLine(%this) {
	if (!isObject(%this.fo)) {
		echo("No file");
		%this.finish();
		return false;
	}
	if (%this.fo.isEOF()) {
		if($debugreplay)echo("EOF");
		%this.finish();
		return false;
	}
	if (!%this.playing) {
		if($debugreplay)echo("Not playing");
		%this.finish();
		return false;
	}

	%this.nextFrame.frames = 0;

	while (true) {
		//What type the next pack of data is
		%tag = %this.fo.readRawU8(); if($debugreplay)echo("Read U8 %tag: " @ %tag);
		if($debugreplay)echo("Read pack of tag " @ %tag);
		switch (%tag) {
		case $RecordTag["time"]:
			if($debugreplay)echo("Frame type: Time");
			%frame = %this.readTime();
			break; //Out of the while-loop, very strange but that's how TS works
		case $RecordTag["time2"]:
			if($debugreplay)echo("Frame type: Time2");
			%frame = %this.readTime2();
			break; //Out of the while-loop, very strange but that's how TS works
		case $RecordTag["position"]:
			if($debugreplay)echo("Frame type: Position");
			%frame = %this.readPosition();
		case $RecordTag["platform"]:
			if($debugreplay)echo("Frame type: Platform");
			%frame = %this.readPlatform();
		case $RecordTag["scores"]:
			if($debugreplay)echo("Frame type: Scores");
			%frame = %this.readScores();
		case $RecordTag["spawn"]:
			if($debugreplay)echo("Frame type: Spawn");
			%frame = %this.readSpawn();
		case $RecordTag["pickup"]:
			if($debugreplay)echo("Frame type: Pickup");
			%frame = %this.readPickup();
		case $RecordTag["physics"]:
			if($debugreplay)echo("Frame type: Physics");
			%frame = %this.readPhysics();
		case $RecordTag["collision"]:
			if($debugreplay)echo("Frame type: Collision");
			%frame = %this.readCollision();
		case $RecordTag["gravity"]:
			if($debugreplay)echo("Frame type: Gravity");
			%frame = %this.readGravity();
		case $RecordTag["gems"]:
			if($debugreplay)echo("Frame type: Gems");
			%frame = %this.readGems();
		case $RecordTag["movement"]:
			if($debugreplay)echo("Frame type: Movement");
			%frame = %this.readMovement();
		default:
			PlaybackFrameGroup.add(%frame = new ScriptObject() {
				class = "PlaybackFrame";
			});
			// We don't know frame size so everything after this will be corrupt
			if($debugreplay)echo("Frame type: Unknown");
			%this.finish();
			return false;
		}
		%this.nextFrame.frame[%this.nextFrame.frames] = %frame;
		%this.nextFrame.frames ++;

		//Find prev for this frame
		for (%i = 0; %i < %this.lastFrame.frames; %i ++) {
			//Basically anything which is the same class counts as the next frame.
			// It's so we can interpolate
			if (%this.lastFrame.frame[%i].class $= %frame.class) {
				%frame.lastFrame = %this.lastFrame.frame[%i];
				break;
			}
		}

		//If we've reached the end, stop
		if (%this.fo.isEOF()) {
			if($debugreplay)echo("EOF");
			%this.finish();
			return false;
		}
		if (!%this.playing) {
			if($debugreplay)echo("Not playing");
			%this.finish();
			return false;
		}
	}
	if (!isObject(%this.lastFrame)) {
		%this.firstFrame = %this.nextFrame;
	}
	%frame.lastFrame = %this.nextFrame;

	//for (%i = 0; %i < %this.lastFrame.frames; %i ++) {
	//	%this.lastFrame.frames[%i].delete();
	//}
	//%this.lastFrame.delete();

	%this.lastFrame = %this.nextFrame;

	%this.nextFrame = %frame;

	%this.lastFrame.nextFrame = %this.nextFrame;
	%this.lastFrame.delta = %this.nextFrame.total - %this.lastFrame.total;

	return true;
}

function PlaybackInfo::step(%this) {
	%lastFrame = %this.lastFrame.lastFrame;
	%nextFrame = %this.lastFrame;

	%current = $Time::TotalTime;

	if (%this.ghost) {
		//Current time should not care about when the recording was started.
		%current += %this.firstFrame.total;
		%current -= %this.start;
	}

	if($debugreplay)echo("PIstep: " @ %current @ " next: " @ %nextFrame.total);

	%offset = %current - %nextFrame.total;
	while (%offset > 0) {
		//EOF if readline returns false
		if (!%this.readLine()) {
			return;
		}

		%lastFrame = %this.lastFrame.lastFrame;
		%nextFrame = %this.lastFrame;
		if($debugreplay)echo("PIsubstep: " @ %current @ " next: " @ %nextFrame.total);

		if (isObject(%nextFrame)) {
			%offset = %current - %nextFrame.total;
			if (%offset > 0) {
				if($debugreplay)echo("apply frame at 1");
				%nextFrame.apply(%this.marble, 1);
			} else {
				if($debugreplay)echo("offset is " @ %offset @ " !> 0");
			}
		}
	}

	if (!isObject(%nextFrame)) {
		if($debugreplay)echo("no next frame?");
		return;
	}
	if (isObject(%lastFrame)) {
		%t = (%current - %lastFrame.total) / %lastFrame.delta;
	} else {
		%t = 1;
	}

	if($debugreplay)echo("pgtime: " @ %current @ " next time: " @ %nextFrame.total @ " last time: " @ %lastFrame.total @ " delta: " @ %lastFrame.delta @ " T: " @ %t);
	if (%t < 0) {
		error("??? Negative time?");
		return;
	}
	%t = mClamp(%t, 0, 1); //So we don't go crazy
	%nextFrame.apply(%this.marble, %t);
}

function PlaybackTimeFrame::apply(%this, %object, %t) {
	//Update time first
	if (!%this.info.ghost) {
		$PlayTimerActive = %this.active;
		if (%this.cheatElapsed) {
			//Fuck me
			%delta = (%this.nextFrame.current - %this.current);
			%deltaBonus = %delta + (%this.nextFrame.bonus - %this.bonus);
			$Time::CurrentTime = %this.serverCurrent + %delta;
			$Time::ElapsedTime = %this.serverElapsed + %deltaBonus;
		} else {
			$Time::CurrentTime = %this.serverCurrent;
			$Time::ElapsedTime = %this.serverElapsed;
		}
		$Time::TotalBonus = %this.serverBonus;
		%current = interpolate(%this.lastFrame.current, %this.current, %t);
		PlayGui.currentTime = %current;
		PlayGui.bonusTime = interpolate(%this.lastFrame.bonus, %this.bonus, %t);
		PlayGui.updateControls();
		PlayGui.updateTimeTravelCountdown();
	}

	for (%i = 0; %i < %this.frames; %i ++) {
		%this.frame[%i].apply(%object, %t);
	}

	if($debugreplay) {
		if (!isObject(%this.info.lastTimes)) {
			%this.info.lastTimes = Array();
		}

		%this.info.lastTimes.addEntry(%this);
		while (%this.total - %this.info.lastTimes.getEntry(0).total > 1000) {
			%this.info.lastTimes.removeEntry(0);
		}
		error("FPS: " @ %this.info.lastTimes.getSize());
	}
}

function playbackStep() {
	%count = PlaybackGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		PlaybackGroup.getObject(%i).step();
	}
}

function PlaybackInfo::readHeader(%this) {
	%this.version = %this.fo.readRawS16(); if($debugreplay)echo("Read S16 %this.version: " @ %this.version);
	%this.gameVersion = %this.fo.readRawS16(); if($debugreplay)echo("Read S16 %this.gameVersion: " @ %this.gameVersion);
	if (%this.version > $ReplayVersion) {
		error("Unsupported replay version " @ %this.version @ " (currently version " @ $ReplayVersion @ ")");
		return false;
	}

	%this.missionFile = %this.fo.readRawString8(); if($debugreplay)echo("Read String8 %this.missionFile: " @ %this.missionFile);
	%this.marbleSelection = %this.fo.readRawString8(); if($debugreplay)echo("Read String8 %this.marbleSelection: " @ %this.marbleSelection);

	//If we have metadata
	%flags = %this.fo.readRawU8(); if($debugreplay)echo("Read U8 %flags: " @ %flags);
	%this.hasMetadata = %flags & 1;
	%this.lb          = (%flags & (1 << 1)) == (1 << 1);
	%this.mp          = (%flags & (1 << 2)) == (1 << 2);
	if (%this.hasMetadata == 1) {
		%this.readMetadata();
	}
	%this.sprngSeed = %this.fo.readRawU32(); if($debugreplay)echo("Read U32 %this.sprngSeed: " @ %this.sprngSeed);
	return true;
}

function PlaybackInfo::readTime(%this) {
	//Play it back
	PlaybackFrameGroup.add(%nextFrame = new ScriptObject() {
		class = "PlaybackTimeFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});
	%nextFrame.total = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.total: " @ %nextFrame.total);
	%nextFrame.current = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.current: " @ %nextFrame.current);
	%nextFrame.bonus = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.bonus: " @ %nextFrame.bonus);
	%nextFrame.active = %this.fo.readRawU8(); if($debugreplay)echo("Read U8 %nextFrame.active: " @ %nextFrame.active);
	//Don't have this info, so make a best guess
	%nextFrame.serverTotal = %nextFrame.total;
	%nextFrame.serverCurrent = %nextFrame.current;
	%nextFrame.serverElapsed = %nextFrame.current - %nextFrame.bonus;
	%nextFrame.serverBonus = %nextFrame.bonus;
	%nextFrame.clientTotal = %nextFrame.total;
	%nextFrame.clientCurrent = %nextFrame.current;
	%nextFrame.clientBonus = %nextFrame.bonus;
	%nextFrame.cheatElapsed = 1;
	if ($replaycsv) {$replayCSVFile.writeLine(%nextFrame.total @ "," @ %nextFrame.current @ "," @ %nextFrame.bonus @ "," @ %nextFrame.active); }
	return %nextFrame;
}

function PlaybackInfo::readTime2(%this) {
	//Play it back
	PlaybackFrameGroup.add(%nextFrame = new ScriptObject() {
		class = "PlaybackTimeFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});
	%nextFrame.serverTotal = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.serverTotal: " @ %nextFrame.serverTotal);
	%nextFrame.serverCurrent = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.serverCurrent: " @ %nextFrame.serverCurrent);
	%nextFrame.serverElapsed = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.serverElapsed: " @ %nextFrame.serverElapsed);
	%nextFrame.serverBonus = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.serverBonus: " @ %nextFrame.serverBonus);
	%nextFrame.clientTotal = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.clientTotal: " @ %nextFrame.clientTotal);
	%nextFrame.clientCurrent = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.clientCurrent: " @ %nextFrame.clientCurrent);
	%nextFrame.clientBonus = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %nextFrame.clientBonus: " @ %nextFrame.clientBonus);
	%nextFrame.active = %this.fo.readRawU8(); if($debugreplay)echo("Read U8 %nextFrame.active: " @ %nextFrame.active);
	//Compatibility
	%nextFrame.total = %nextFrame.serverTotal;
	%nextFrame.current = %nextFrame.clientCurrent;
	%nextFrame.bonus = %nextFrame.clientBonus;
	%nextFrame.cheatElapsed = 0;
	if ($replaycsv) {$replayCSVFile.writeLine(%nextFrame.total @ "," @ %nextFrame.current @ "," @ %nextFrame.bonus @ "," @ %nextFrame.active); }
	return %nextFrame;
}

function PlaybackInfo::readPosition(%this) {
	//Play it back
	%className = (isObject(%this.marble) ? %this.marble.getClassName() : "Marble");
	%class = "Playback" @ %className;
	//TODO: If we ever record something that's NOT a marble then look into this
	if (%className !$= "Marble") {
		%class = "PlaybackFakeMarble";
	}
	PlaybackFrameGroup.add(%nextFrame = new ScriptObject() {
		class = %class;
		superClass = "PlaybackFrame";
		info = %this;
	});
	%nextFrame.input = %this.readInput();
	%nextFrame.recordDeserialize(%this.fo);
	return %nextFrame;
}

function PlaybackInfo::readPlatform(%this) {
	PlaybackFrameGroup.add(%platformFrame = new ScriptObject() {
		class = "PlaybackPlatformFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});
	%platformFrame.platforms = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %platformFrame.platforms: " @ %platformFrame.platforms);
	for (%i = 0; %i < %platformFrame.platforms; %i ++) {
		%platformFrame.pathTime[%i] = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %platformFrame.pathTime["@%i@"]: " @ %platformFrame.pathTime[%i]);
		%platformFrame.targetTime[%i] = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %platformFrame.targetTime["@%i@"]: " @ %platformFrame.targetTime[%i]);
	}

	return %platformFrame;
}

function PlaybackInfo::readMetadata(%this) {
	%this.author = %this.fo.readRawString8(); if($debugreplay)echo("Read String8 %this.author: " @ %this.author);
	%this.name = %this.fo.readRawString8(); if($debugreplay)echo("Read String8 %this.name: " @ %this.name);
	%this.desc = %this.fo.readRawString16(); if($debugreplay)echo("Read String16 %this.desc: " @ %this.desc);
}

function PlaybackPlatformFrame::apply(%this, %object, %t) {
	%platforms = recordGetPathedInteriors();
	%count = min(%platforms.getSize(), %this.platforms);
	for (%i = 0; %i < %count; %i ++) {
		%obj = %platforms.getEntry(%i);

		%current = %obj.getPathPosition();
		%expected = cinterpolate(%this.lastFrame.pathTime[%i], %this.pathTime[%i], %t, %obj.getPathTotalTime());

		if (mAbs(%expected - %current) > 25) {
			%obj.setPathPosition2(%expected);
			echo("Set path position to " @ %expected);
		}
	}
}

function PlaybackInfo::readScores(%this) {
	//TODO

}

function PlaybackInfo::readSpawn(%this) {
	PlaybackFrameGroup.add(%spawnFrame = new ScriptObject() {
		class = "PlaybackSpawnFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});

	%spawnFrame.gems = %this.fo.readRawS32(); if($debugreplay)echo("Read S32 %spawnFrame.gems: " @ %spawnFrame.gems);
	for (%i = 0; %i < %spawnFrame.gems; %i ++) {
		%spawnFrame.spawnPosition[%i] = %this.fo.readRawPoint3F(); if($debugreplay)echo("Read S32 %spawnFrame.spawnPosition["@%i@"]: " @ %spawnFrame.spawnPosition[%i]);
	}

	return %spawnFrame;
}

function PlaybackSpawnFrame::apply(%this, %object, %t) {
	if (%this.applied) {
		return;
	}
	%this.applied = true;
	hideGems();

	if($debugreplay)echo("Spawning " @ %this.gems @ " gems");

	for (%i = 0; %i < %this.gems; %i ++) {
		%position = %this.spawnPosition[%i];
		%gems = findObjectsAtPosition(%position);

		for (%j = 0; %j < %gems.getSize(); %j ++) {
			%gem = %gems.getEntry(%j);
			if (%gem.getClassName() $= "Item" && %gem.getDataBlock().className $= "Gem" && %gem.isHidden()) {
				if($debugreplay)echo("Spawn gem " @ %gem @ " at " @ %position);
				spawnGem(%gem);
			}
		}

		%gems.delete();
	}
}

function PlaybackInfo::readPickup(%this) {
	PlaybackFrameGroup.add(%pickupFrame = new ScriptObject() {
		class = "PlaybackPickupFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});
	%pickupFrame.db = %this.fo.readRawString8(); if($debugreplay)echo("Read String8 %pickupFrame.db: " @ %pickupFrame.db);
	%pickupFrame.position = %this.fo.readRawPoint3F(); if($debugreplay)echo("Read S32 %pickupFrame.position: " @ %pickupFrame.position);

	return %pickupFrame;
}

function PlaybackPickupFrame::apply(%this, %object, %t) {
	if (%this.applied) {
		return;
	}
	%this.applied = true;

	//Find it and pick it up
	%objs = findObjectsNearPosition(%this.position, 0.25);
	if (%objs.getSize() < 0) {
		%objs.delete();
		return;
	}
	for (%i = 0; %i < %objs.getSize(); %i ++) {
		%col = %objs.getEntry(%i);
		
		if (strStr(%this.db, "GemItem") == -1 || strStr(%col.getDataBlock().getName(), "GemItem") == -1) {
			if (%col.getDataBlock().getName() !$= %this.db && (%col.getDataBlock().getName() !$= (%this.db @ "_MBU")))
				continue;
		}

		if($debugreplay)echo("Hacky pickup of item at " @ %this.position);
		//Hack
		$Playback::DemoFrame = true;
		DefaultMarble.onCollision(LocalClientConnection.player, %col);
		$Playback::DemoFrame = false;
	}
	%objs.delete();
}

function PlaybackInfo::readCollision(%this) {
	PlaybackFrameGroup.add(%collisionFrame = new ScriptObject() {
		class = "PlaybackCollisionFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});
	%collisionFrame.db = %this.fo.readRawString8(); if($debugreplay)echo("Read String8 %collisionFrame.db: " @ %collisionFrame.db);
	%collisionFrame.position = %this.fo.readRawPoint3F(); if($debugreplay)echo("Read S32 %collisionFrame.position: " @ %collisionFrame.position);

	return %collisionFrame;
}

function PlaybackCollisionFrame::apply(%this, %object, %t) {
	if (%this.applied) {
		return;
	}
	%this.applied = true;

	//Find it and pick it up
	%objs = findObjectsNearPosition(%this.position, 0.25);
	if (%objs.getSize() < 0) {
		%objs.delete();
		return;
	}
	for (%i = 0; %i < %objs.getSize(); %i ++) {
		%col = %objs.getEntry(%i);

		if (strStr(%this.db, "GemItem") == -1 || strStr(%col.getDataBlock().getName(), "GemItem") == -1) {
			if ((%col.getType() & $TypeMasks::GameBaseObjectType) && %col.getDataBlock().getName() !$= %this.db && (%col.getDataBlock().getName() !$= (%this.db @ "_MBU")))
				continue;
		}

		%this.db = %col.getDataBlock().getName();

		if($debugreplay)echo("Hacky collision of item at " @ %this.position);
		//Hack
		$Playback::DemoFrame = true;
		%this.db.onCollision(%col, LocalClientConnection.player);
		$Playback::DemoFrame = false;
	}
	%objs.delete();
}

function PlaybackInfo::readPhysics(%this) {
	PlaybackFrameGroup.add(%physicsFrame = new ScriptObject() {
		class = "PlaybackPhysicsFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});
	%physicsFrame.count = %this.fo.readRawU8(); if($debugreplay)echo("Read U8 %physicsFrame.count: " @ %physicsFrame.count);
	for (%i = 0; %i < %physicsFrame.count; %i ++) {
		%physicsFrame.field[%i] = %this.fo.readRawString8(); if($debugreplay)echo("Read String8 %physicsFrame.field["@%i@"]: " @ %physicsFrame.field[%i]);
		%physicsFrame.value[%i] = %this.fo.readRawString8(); if($debugreplay)echo("Read String8 %physicsFrame.value["@%i@"]: " @ %physicsFrame.value[%i]);
	}

	return %physicsFrame;
}

function PlaybackPhysicsFrame::apply(%this, %object, %t) {
	if (%this.applied) {
		return;
	}
	%this.applied = true;

	//We don't actually want to use these physics... so just pretend we apply them
	for (%i = 0; %i < %this.count; %i ++) {
		%field = %this.field[%i];
		%value = %this.value[%i];
		if ($Playback::PhysicsValue[%field] !$= "") {
			$Playback::LastPhysicsValue[%field] = $Playback::PhysicsValue[%field];
		} else {
			//No previous data so just use what the current is
			$Playback::LastPhysicsValue[%field] = %value;
		}
		$Playback::PhysicsValue[%field] = %value;

		if($debugreplay)echo("pretend physics " @ %field @ " old value " @ $Playback::LastPhysicsValue[%field]);
		if($debugreplay)echo("pretend physics " @ %field @ " value " @ %value);
	}
}

function PlaybackInfo::readGravity(%this) {
	PlaybackFrameGroup.add(%gravityFrame = new ScriptObject() {
		class = "PlaybackGravityFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});
	%gravityFrame.dir = %this.fo.readRawOrthoF(); if($debugreplay)echo("Read OrthoF %gravityFrame.dir: " @ %gravityFrame.dir);
	%gravityFrame.instant = %this.fo.readRawU8(); if($debugreplay)echo("Read U8 %gravityFrame.instant: " @ %gravityFrame.instant);
	%gravityFrame.rot = %this.fo.readRawAngAxisF(); if($debugreplay)echo("Read AngAxisF %gravityFrame.rot: " @ %gravityFrame.rot);

	return %gravityFrame;
}

function PlaybackGravityFrame::apply(%this, %object, %t) {
	if (%this.applied) {
		return;
	}
	%this.applied = true;

	$Playback::DemoFrame = true;
	if (%this.instant || !orthoCompare(%this.dir, $Game::GravityDir)) {
		clientCmdSetGravityDir(%this.dir, %this.instant, %this.rot);
		if (!%this.info.ghost) {
			LocalClientConnection.setGravityDir(%this.dir, %this.instant, %this.rot);
		}
	}
	$Playback::DemoFrame = false;
}

function PlaybackInfo::readGems(%this) {
	PlaybackFrameGroup.add(%gemsFrame = new ScriptObject() {
		class = "PlaybackGemsFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});
	%gemsFrame.count = %this.fo.readRawU16(); if($debugreplay)echo("Read U16 %gemsFrame.count: " @ %gemsFrame.count);
	%gemsFrame.max = %this.fo.readRawU16(); if($debugreplay)echo("Read U16 %gemsFrame.max: " @ %gemsFrame.max);
	%gemsFrame.quota = %this.fo.readRawU16(); if($debugreplay)echo("Read U16 %gemsFrame.quota: " @ %gemsFrame.quota);
	%gemsFrame.green = %this.fo.readRawU8(); if($debugreplay)echo("Read U8 %gemsFrame.green: " @ %gemsFrame.green);

	return %gemsFrame;
}

function PlaybackGemsFrame::apply(%this, %object, %t) {
	if (%this.applied) {
		return;
	}
	%this.applied = true;

	LocalClientConnection.gemCount = %this.count;
	$Game::GemCount = %this.max;

	if ($Game::isMode["quota"]) {
		clientCmdSetGemQuota(%this.max, %this.quota);
	} else {
		PlayGui.setMaxGems(%this.max);
	}
	PlayGui.setGemCount(%this.count, %this.green);
}

function PlaybackInfo::readMovement(%this) {
	PlaybackFrameGroup.add(%movementFrame = new ScriptObject() {
		class = "PlaybackMovementFrame";
		superClass = "PlaybackFrame";
		info = %this;
	});
	%movementFrame.left = %this.fo.readRawF32(); if($debugreplay)echo("Read F32 %movementFrame.left: " @ %movementFrame.left);
	%movementFrame.right = %this.fo.readRawF32(); if($debugreplay)echo("Read F32 %movementFrame.right: " @ %movementFrame.right);
	%movementFrame.forward = %this.fo.readRawF32(); if($debugreplay)echo("Read F32 %movementFrame.forward: " @ %movementFrame.forward);
	%movementFrame.backward = %this.fo.readRawF32(); if($debugreplay)echo("Read F32 %movementFrame.backward: " @ %movementFrame.backward);

	return %movementFrame;
}

function PlaybackMovementFrame::apply(%this, %object, %t) {
	if (LocalClientConnection.getControlObject() == LocalClientConnection.camera)
		return;
	$mvLeftAction = %this.left;
	$mvRightAction = %this.right;
	$mvForwardAction = %this.forward;
	$mvBackwardAction = %this.backward;
}

//-----------------------------------------------------------------------------

function recordWriteInput(%stream) {
	%flags = 0;
	%flags |= $mvTriggerCount0 << 0;
	%flags |= $mvTriggerCount1 << 1;
	%flags |= $mvTriggerCount2 << 2;
	%flags |= $mouseFire       << 3;
	%flags |= $useBlast        << 4;
	%flags |= $forceCheckpointRespawn << 5;
	%stream.writeRawS32(%flags);
}

function PlaybackInfo::readInput(%this) {
	%input = %this.fo.readRawS32();
	return %input;
}

function PlaybackFrame::applyInput(%this) {
	%flags = %this.input;
	%change = (%flags ^ %this.info.lastInput);
	%this.info.lastInput = %flags;

	if (%change & 1 << 0) usePowerup(!!(%flags & 1 << 0));
	if (%change & 1 << 2) jump      (!!(%flags & 1 << 2));
	if (%change & 1 << 3) mouseFire (!!(%flags & 1 << 3));
	if (%change & 1 << 4) useBlast  (!!(%flags & 1 << 4));
	if (%change & 1 << 5) forceRespawn(!!(%flags & 1 << 5));
}

//-----------------------------------------------------------------------------

function SceneObject::recordSerialize(%this, %stream) {
	%stream.writeRawMatrixF(%this.getTransform());
}

function ShapeBase::recordSerialize(%this, %stream) {
	Parent::recordSerialize(%this, %stream);

	//Get any mounted images
	%images = "";
	for (%i = 0; %i < 8; %i ++) {
		%image = %this.getMountedImage(%i);
		if (isObject(%image)) {
			%image = %image.getName();
		}
		%stream.writeRawString8(%image);
	}
}

function Marble::recordSerialize(%this, %stream) {
	Parent::recordSerialize(%this, %stream);
	%stream.writeRawPoint3F(%this.getVelocity());
	%stream.writeRawPoint3F(%this.getAngularVelocity());
	%stream.writeRawF32(%this.getCollisionRadius());

	if (%this == $MP::MyMarble) {
		%stream.writeRawF32(getMarbleCamYaw());
		%stream.writeRawF32(getMarbleCamPitch());

		recordCheckPhysicsUpdate(%stream);
	} else {
		%stream.writeRawF32(%this.getCameraYaw());
		%stream.writeRawF32(%this.getCameraPitch());
	}
}

function PlaybackSceneObject::recordDeserialize(%this, %stream) {
	%this.transform = %stream.readRawMatrixF(); if ($debugreplay)echo("Read MatrixF %this.transform: " @ %this.transform);
}

function PlaybackShapeBase::recordDeserialize(%this, %stream) {
	PlaybackSceneObject::recordDeserialize(%this, %stream);

	//Mount any images that we're given
	for (%i = 0; %i < 8; %i ++) {
		%image = %stream.readRawString8(); if ($debugreplay)echo("Read String8 %image["@%i@"]: " @ %image);
		%this.mountImage[%i] = %image;
	}
}

function PlaybackMarble::recordDeserialize(%this, %stream) {
	PlaybackShapeBase::recordDeserialize(%this, %stream);
	%this.velocity    = %stream.readRawPoint3F(); if ($debugreplay)echo("Read Point3F %this.velocity: " @ %this.velocity);
	%this.angular     = %stream.readRawPoint3F(); if ($debugreplay)echo("Read Point3F %this.angular: " @ %this.angular);
	%this.radius      = %stream.readRawF32(); if ($debugreplay)echo("Read F32 %this.radius: " @ %this.radius);
	%this.cameraYaw   = %stream.readRawF32(); if ($debugreplay)echo("Read F32 %this.cameraYaw: " @ %this.cameraYaw);
	%this.cameraPitch = %stream.readRawF32(); if ($debugreplay)echo("Read F32 %this.cameraPitch: " @ %this.cameraPitch);
	//if ($replaycsv) echo(strreplace(%this.transform SPC %this.velocity, " ", ","));
}

function PlaybackFakeMarble::recordDeserialize(%this, %stream) {
	PlaybackShapeBase::recordDeserialize(%this, %stream);
	%stream.readRawPoint3F(); // %this.velocity
	%stream.readRawPoint3F(); // %this.angular
	%stream.readRawF32(); // %this.radius
	%stream.readRawF32(); // %this.cameraYaw
	%stream.readRawF32(); // %this.cameraPitch
}

function PlaybackSceneObject::apply(%this, %object, %t) {
	%interp = MatInterpolate(%this.lastFrame.transform, %this.transform, %t);
	%objTrans = %object.getTransform();
	%trans = MatrixPos(%objTrans) SPC MatrixRot(%interp);

	//Only move position if necessary
	if (VectorDist(MatrixPos(%objTrans), MatrixPos(%interp)) > $ReplayForceThreshold) {
		%trans = %interp;
		echo("Force move");
	} else {
		//echo("Delta is " SPC VectorDist(MatrixPos(%objTrans), MatrixPos(%interp)));
		%trans = MatInterpolate(%objTrans, %interp, 0.5);
	}
	%object.setTransform(%trans);
}

function PlaybackShapeBase::apply(%this, %object, %t) {
	PlaybackSceneObject::apply(%this, %object, %t);

	for (%i = 0; %i < 8; %i ++) {
		%image = %this.mountImage[%i];
		%current = %object.getMountedImage(%i);
		if (%image $= "ActualHelicopterImage" && !$pref::LegacyItems && MissionInfo.game $= "Ultra")
			%image = "HelicopterImage_MBUBall";
		if (isObject(%current)) {
			%current = %current.getName();
		}

		if (%image !$= %current) {
			if (%image $= "0") {
				%object.unmountImage(%i);
			} else {
				%object.mountImage(%image, %i);
			}
		}
	}
}

function PlaybackMarble::apply(%this, %object, %t) {
	PlaybackShapeBase::apply(%this, %object, %t);

	%velocity = VectorLerp(%this.lastFrame.velocity, %this.velocity, %t); //Interpolated velocity

	//%interp = MatInterpolate(%this.lastFrame.transform, %this.transform, %t);
	//%objTrans = %object.getTransform();
	//%dist = VectorSub(MatrixPos(%interp), MatrixPos(%objTrans));
	//echo("Replay dist: " @ %dist @ " one frame of velocity is " @ VectorScale(%velocity, 0.016));

	//%velocity = VectorAdd(%velocity, %dist); //Factor in distance drift

	%object.setVelocity(%velocity);
	%object.setAngularVelocity(VectorLerp(%this.lastFrame.angular, %this.angular, %t));
	%object.setCollisionRadius(%this.radius);
	if (LocalClientConnection.getControlObject() != LocalClientConnection.camera) {
		if (%object == $MP::MyMarble) {
			setMarbleCamYaw(cinterpolate(%this.lastFrame.cameraYaw, %this.cameraYaw, %t, $pi * 2));
			setMarbleCamPitch(cinterpolate(%this.lastFrame.cameraPitch, %this.cameraPitch, %t, $pi * 2));
			%this.applyInput();
		} else {
			%object.setCameraYaw(cinterpolate(%this.lastFrame.cameraYaw, %this.cameraYaw, %t, $pi * 2));
			%object.setCameraPitch(cinterpolate(%this.lastFrame.cameraPitch, %this.cameraPitch, %t, $pi * 2));
		}
	}
}

function PlaybackFakeMarble::apply(%this, %object, %t) {
	PlaybackShapeBase::apply(%this, %object, %t);
}

function interpolate(%a, %b, %t) {
	return %a + (%b - %a) * %t;
}

function cinterpolate(%a, %b, %t, %limit) {
	//Normalize angles so going from 359 deg to 1 deg doesn't pass through 180 deg
	if (%a > %b && (%a - %b) > (%limit / 2)) %b += %limit;
	if (%b > %a && (%b - %a) > (%limit / 2)) %a += %limit;
	return %a + (%b - %a) * %t;
}

