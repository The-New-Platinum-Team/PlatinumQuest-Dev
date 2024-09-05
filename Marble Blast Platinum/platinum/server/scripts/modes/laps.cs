//-----------------------------------------------------------------------------
// Laps Mode
//
// Copyright (c) 2015 The Platinum Team
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

function Mode_laps::onLoad(%this) {
	%this.registerCallback("onBeforeMissionLoad");
	%this.registerCallback("onResetStats");
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onActivateCheckpoint");
	%this.registerCallback("onRespawnOnCheckpoint");
	%this.registerCallback("getCheckpointPos");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_laps::onBeforeMissionLoad(%this) {
	$Laps::LastCheckpointNumber = 0;
}
function Mode_laps::onResetStats(%this, %object) {
	%object.client.resetLaps();
}
function Mode_laps::onMissionLoaded(%this) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.resetLaps();
	}
	commandToAll('SetLapsTotal', MissionInfo.lapsNumber);
}
function Mode_laps::onMissionReset(%this) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.resetLaps();
	}
	commandToAll('SetLapsTotal', MissionInfo.lapsNumber);
}
function Mode_laps::onActivateCheckpoint(%this, %object) {
	%object.client.checkpointLapsCPCheck = %object.client.lapsCPCheck;
	%object.client.checkpointLapsCounter = %object.client.lapsCounter;
	%object.client.checkpointLapsHitLastCP = %object.client.lapsHitLastCP;
	%object.client.checkpointLapsStartTime = %object.client.lapsStartTime;
}
function Mode_laps::onRespawnOnCheckpoint(%this, %object) {
	%object.client.lapsCPCheck = %object.client.checkpointLapsCPCheck;
	%object.client.lapsCounter = %object.client.checkpointLapsCounter;
	%object.client.lapsHitLastCP = %object.client.checkpointLapsHitLastCP;
	%object.client.lapsStartTime = %object.client.checkpointLapsStartTime;
	commandToClient(%object.client, 'SetLapsComplete', %object.client.lapsCounter);
}
function Mode_laps::getCheckpointPos(%this, %object) {
	//Don't override a checkpoint if we have one
	if (MissionInfo.noLapsCheckpoint)
		return "";
	if (isObject(%object.client.lapsCP)) {
		%cp = %object.client.lapsCP;
		if (%cp.customSpawnPoint) {
			%trans = setWord(%cp.spawnPoint, 6, mDegToRad(getWord(%cp.spawnPoint, 6)));
		} else {
			%trans = %object.client.lapsPosition SPC "0 0 1" SPC %object.client.lapsCamera;
		}
		return %trans TAB %object.client.lapsGravity TAB 0.45;
	}
	return "";
}

datablock TriggerData(LapsCounterTrigger) {
	tickPeriodMS = 10;
	customField[0, "field"  ] = "enableRespawning";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Enable Respawning";
	customField[0, "desc"   ] = "If the trigger should allow players to respawn at it.";
	customField[0, "default"] = "true";
	customField[1, "field"  ] = "customSpawnPoint";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Use Spawn Point";
	customField[1, "desc"   ] = "If the spawn point field should be used.";
	customField[1, "default"] = "false";
	customField[2, "field"  ] = "spawnPoint";
	customField[2, "type"   ] = "MatrixF";
	customField[2, "name"   ] = "Spawn Point";
	customField[2, "desc"   ] = "Transform (position and rotation) where players will spawn if they fall OOB (Multiplayer only).";
	customField[2, "default"] = "";
	customField[3, "field"  ] = "forceGravity";
	customField[3, "type"   ] = "AngAxisF";
	customField[3, "name"   ] = "Force Gravity";
	customField[3, "desc"   ] = "Gravity rotation to use when respawning (blank = use current).";
	customField[3, "default"] = "";
};

datablock TriggerData(LapsCheckpoint) {
	tickPeriodMS = 10;

	customField[0, "field"  ] = "checkpointNumber";
	customField[0, "type"   ] = "int";
	customField[0, "name"   ] = "Checkpoint Number";
	customField[0, "desc"   ] = "Sequence number for this trigger, has to be 1 greater than the previous trigger. First trigger has to be 1.";
	customField[0, "default"] = "";
	customField[1, "field"  ] = "enableRespawning";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Enable Respawning";
	customField[1, "desc"   ] = "If the trigger should allow players to respawn at it.";
	customField[1, "default"] = "true";
	customField[2, "field"  ] = "customSpawnPoint";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Use Custom Spawn Point";
	customField[2, "desc"   ] = "If the spawn point field should be used.";
	customField[2, "default"] = "false";
	customField[3, "field"  ] = "spawnPoint";
	customField[3, "type"   ] = "MatrixF";
	customField[3, "name"   ] = "Spawn Point";
	customField[3, "desc"   ] = "Transform (position and rotation) where players will spawn if they fall OOB (Multiplayer only).";
	customField[3, "default"] = "";
	customField[4, "field"  ] = "forceGravity";
	customField[4, "type"   ] = "AngAxisF";
	customField[4, "name"   ] = "Force Gravity";
	customField[4, "desc"   ] = "Gravity rotation to use when respawning (blank = use current).";
	customField[4, "default"] = "";
};

function GameConnection::resetLaps(%this) {
	%this.lapsCounter = 1;
	%this.lapsLastTime = 0;
	%this.lapsBestTime = 0;

	%this.lapsCP = 0;
	%this.lapsCPCheck = 1;
	%this.lapsHitLastCP = 0;
	%this.lapsStartTime = 0;

	%this.checkpointLapsCPCheck = 1;
	%this.checkpointLapsCounter = 1;
	%this.checkpointLapsHitLastCP = 0;
	%this.checkpointLapsCP = 0;
	%this.checkpointLapsStartTime = 0;

	commandToClient(%this, 'SetLapsComplete', 1);
}

function GameConnection::onNextLap(%this) {
	if (%this.lapsCounter >= MissionInfo.lapsNumber) {
		// If we have not collected all of the gems, you can't finish you fool!
		if (%this.getGemCount() != $Game::GemCount) {
			%message = "You need to collect all the gems to finish!";
			%this.addBubbleLine(%message, false, 5000);
			%this.playPitchedSound("missinggems");
		} else {
			// Finish the game
			%this.onEnterPad();
		}
	}

	%this.lapsCounter ++;
	%this.lapsCPCheck = 1;
	%this.lapsHitLastCP = 0;

	%lapTime = sub64_int($Time::CurrentTime, %this.lapsStartTime);
	%this.lapsStartTime = $Time::CurrentTime;

	commandToClient(%this, 'LapTime', %this.lapsCounter, %lapTime);
	commandToClient(%this, 'SetLapsComplete', min(MissionInfo.lapsNumber, %this.lapsCounter));

	return true;
}

function LapsCounterTrigger::onEnterTrigger(%this, %trigger, %obj) {
	if (%obj.client.lapsHitLastCP == 1) {
		// Increment Lap Counter and reset Checkpoint number checker
		if (%obj.client.onNextLap()) {
			%obj.client.activateLapsCheckpoint(%trigger);
		}
		devecho("Hit laps checkpoint #0");
	} else {
		//As long as they didn't hit the same checkpoint they just entered
		if (%obj.client.lapsCPCheck != 1) {
			// Must have went backwards :O
			//Seiz - Don't do anything here; user can progress again by hitting the checkpoint that they needed to hit
			error("Missed a laps checkpoint! Hit #0 instead of #" @ %obj.client.lapsCPCheck);
			%obj.client.addBubbleLine("Wrong way!", false, 5000);
		} else {
			devecho("Hit the same laps checkpoint we were at, #0");
		}
	}
}

function LapsCheckpoint::onEnterTrigger(%this, %trigger, %obj) {
	// Find the last Checkpoint in the lap
	%highest = $Laps::LastCheckpointNumber;

	// Get the Checkpoint's ID, then find the number
	%cpID = %trigger.getID();

	// If collided Checkpoint number = what is expected to be next
	if (%cpID.checkpointNumber == %obj.client.lapsCPCheck) {
		// Checking for highest Checkpoint number. If highest, reset to 0
		if (%obj.client.lapsCPCheck == %highest) {
			%obj.client.lapsCPCheck = 0;
			%obj.client.lapsHitLastCP = 1;
			%obj.client.activateLapsCheckpoint(%trigger);
		} else {
			%obj.client.lapsCPCheck++;
			%obj.client.activateLapsCheckpoint(%trigger);
		}
		devecho("Hit laps checkpoint #" @ %cpID.checkpointNumber);
	} else {
		//As long as they didn't hit the same checkpoint they just entered
		if (!((%cpID.checkpointNumber + 1) == %obj.client.lapsCPCheck
			|| (%cpID.checkpointNumber == %highest && %obj.client.lapsCPCheck == 0))) {
			// Must have went backwards :O
			//Seiz - Don't do anything here; user can progress again by hitting the checkpoint that they needed to hit
			error("Missed a laps checkpoint! Hit #" @ %cpID.checkpointNumber @ " instead of #" @ %obj.client.lapsCPCheck);
			%obj.client.addBubbleLine("Wrong way!", false, 5000);
		} else {
			devecho("Hit the same laps checkpoint we were at, #" @ %cpId.checkpointNumber);
		}
	}
}

function GameConnection::activateLapsCheckpoint(%this, %trigger) {
	if (%this.isOOB && %trigger.disableOOB)
		return;
	if (MissionInfo.noLapsCheckpoint)
		return;
	if (!%trigger.enableRespawning)
		return;

	%this.setCheckpoint(%trigger, %trigger);

	//Some custom fields that need to be set for respawning
	if (%trigger.forceGravity !$= "") {
		%grav = getWords(%trigger.forceGravity, 0, 2) SPC mDegToRad(getWord(%trigger.forceGravity, 3));
		%this.checkpointGravityDir = VectorOrthoBasis(%grav);
		%this.checkpointGravityRot = %grav;
		%this.lapsGravity = %grav;
	} else {
		%this.checkpointGravityDir = %this.player.getGravityDir();
		%this.checkpointGravityRot = %this.player.getGravityRot();
		%this.lapsGravity = %this.player.getGravityRot();
	}

	%this.lapsCP = %trigger;
	%this.lapsPosition = MatrixPos(%this.player.getTransform());
	%this.lapsCamera = %this.player.getCameraYaw();

	devecho("[Mode laps]: Activate laps checkpoint");
}

function LapsCheckpoint::checkGroup(%this, %obj) {
	//Make sure this goes into the laps group
	if (!isObject(LapsGroup)) {
		MissionGroup.add(new SimGroup(LapsGroup));
	}
	LapsGroup.add(%obj);
}

function LapsCheckpoint::onAdd(%this, %obj) {
	//Need to schedule this because the group could be created after the object
	%this.onNextFrame(checkGroup, %obj);

	//If this doesn't have a checkpoint number, increment it
	if (%obj.checkpointNumber $= "") {
		%obj.checkpointNumber = $Laps::LastCheckpointNumber;
		$Laps::LastCheckpointNumber ++;
	} else {
		$Laps::LastCheckpointNumber = max($Laps::LastCheckpointNumber, %obj.checkpointNumber);
	}

	//Default spawn point is current position (but with degrees)
	if (%obj.spawnPoint $= "") {
		%obj.spawnPoint = %obj.getWorldBoxCenter() SPC MatrixRot(%obj.getTransform());
		%obj.spawnPoint = setWord(%obj.spawnPoint, 6, mRadToDeg(getWord(%obj.spawnPoint, 6)));
	}
	if (%obj.customSpawnPoint $= "") {
		%obj.customSpawnPoint = false;
	}
	if (%obj.enableRespawning $= "") {
		%obj.enableRespawning = true;
	}
}

function LapsCheckpoint::onMissionReset(%this, %obj) {
	$Laps::LastCheckpointNumber = max($Laps::LastCheckpointNumber, %obj.checkpointNumber);
}

function LapsCounterTrigger::checkGroup(%this, %obj) {
	//Make sure this goes into the laps group
	if (!isObject(LapsGroup)) {
		MissionGroup.add(new SimGroup(LapsGroup));
	}
	LapsGroup.add(%obj);
}

function LapsCounterTrigger::onAdd(%this, %obj) {
	//Need to schedule this because the group could be created after the object
	%this.onNextFrame(checkGroup, %obj);

	//Default spawn point is current position (but with degrees)
	if (%obj.spawnPoint $= "") {
		%obj.spawnPoint = %obj.getWorldBoxCenter() SPC MatrixRot(%obj.getTransform());
		%obj.spawnPoint = setWord(%obj.spawnPoint, 6, mRadToDeg(getWord(%obj.spawnPoint, 6)));
	}
	if (%obj.customSpawnPoint $= "") {
		%obj.customSpawnPoint = false;
	}
	if (%obj.enableRespawning $= "") {
		%obj.enableRespawning = true;
	}
}