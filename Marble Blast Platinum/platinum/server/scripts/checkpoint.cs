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

// CHECKPOINT BASE CODE

datablock TriggerData(CheckpointTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "respawnPoint";
	customField[0, "type"   ] = "object";
	customField[0, "name"   ] = "Respawn Point";
	customField[0, "desc"   ] = "Name of the object to respawn on.";
	customField[0, "default"] = "";
	customField[1, "field"  ] = "add";
	customField[1, "type"   ] = "Point3F";
	customField[1, "name"   ] = "Respawn Offset";
	customField[1, "desc"   ] = "Offset from checkpoint pad that you will respawn. Normal is 0 0 3, but blank will use current gravity.";
	customField[1, "default"] = "";
	customField[2, "field"  ] = "gravity";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Use Gravity";
	customField[2, "desc"   ] = "If true, the checkpoint will spawn the player with gravity relative to the checkpoint's rotation on respawn.";
	customField[2, "default"] = "0";
};

datablock StaticShapeData(checkPoint) {
	className = "CheckPointClass";
	category = "Pads";
	shapeFile = "~/data/shapes/buttons/checkPoint.dts";

	customField[0, "field"  ] = "disableOOB";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Disable if OOB";
	customField[0, "desc"   ] = "Don't let people use this checkpoint if they're OOB.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "add";
	customField[1, "type"   ] = "Point3F";
	customField[1, "name"   ] = "Respawn Offset";
	customField[1, "desc"   ] = "Offset from checkpoint pad that you will respawn. Normal is 0 0 3, but blank will use current gravity.";
	customField[1, "default"] = "";
	customField[2, "field"  ] = "gravity";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Use Gravity";
	customField[2, "desc"   ] = "If true, the checkpoint will spawn the player with gravity relative to the its rotation on respawn.";
	customField[2, "default"] = "0";
	customField[3, "field"  ] = "chkcollide";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Checkpoint on Collision?";
	customField[3, "desc"   ] = "If ticked off then you won't get a checkpoint on collision, this is recommended to be used in conjunction with Checkpoint Trigger.";
	customField[3, "default"] = "1";
};

datablock StaticShapeData(Checkpoint_PQ : checkPoint) {
	shapeFile = "~/data/shapes_pq/Gameplay/pads/checkpoint.dts";
};

datablock StaticShapeData(Checkpoint_MBU : checkPoint) {
	shapeFile = "~/data/shapes_mbu/pads/checkpad.dts";
};

datablock StaticShapeData(Checkpoint_MBXP : checkPoint) {
	shapeFile = "~/data/shapes/pads/checkpoint.dts";
};

datablock StaticShapeData(Checkpoint_BM : checkPoint) {
	shapeFile = "~/data/shapes_bm/pads/checkpad.dts";
};

function Checkpoint_MBU::onMissionReset(%this, %obj) {
	if (!$Game::Menu) {
		%obj.setThreadDir(0,false);
	}
}

function Checkpoint_MBU::onActivateCheckpoint(%this, %obj) {
	if (!$Game::Menu) {
		%obj.setThreadDir(0,false);
	}
}

function Checkpoint_BM::onMissionReset(%this, %obj) {
	if (!$Game::Menu) {
		%obj.setThreadDir(0,false);
	}
}

function Checkpoint_BM::onActivateCheckpoint(%this, %obj) {
	if (!$Game::Menu) {
		%obj.setThreadDir(0,false);
	}
}

function Checkpoint_MBXP::onMissionReset(%this, %obj) {
	return Checkpoint_MBU::onMissionReset(%this, %obj);
}

function Checkpoint_MBXP::onActivateCheckpoint(%this, %obj) {
	return Checkpoint_MBU::onActivateCheckpoint(%this, %obj);
}

function Checkpoint_PQ::onAdd(%this, %obj) {
	%rotation = %obj.getRotation();
	%rotation = getWords(%rotation, 0, 2) SPC mRadToDeg(getWord(%rotation, 3));
	%temp = new StaticShape() {
		datablock = SillyGlass;
		position = %obj.getPosition();
		rotation = %rotation;
		scale = %obj.getScale();
	};
	%temp.setParent(%obj, "0 0 0 1 0 0 0", true, "0 0 0");
	%obj._glass = %temp;
	MissionCleanup.add(%temp);
	
   if (%obj.chkcollide $= "")
	%obj.chkcollide = "1";
}

datablock StaticShapeData(SillyGlass : checkPoint) {
	className = "";
	shapefile = "~/data/shapes_pq/Gameplay/pads/silly_cp_glass.dts";
};

function Checkpoint_PQ::onEditorDrag(%this, %obj) {
	%obj._glass.setTransform(%obj.getTransform());
	%obj._glass.setScale(%obj.getScale());
}

function Checkpoint_PQ::onInspectApply(%this, %obj) {
	%obj._glass.setTransform(%obj.getTransform());
	%obj._glass.setScale(%obj.getScale());
}

// CHECKPOINT BUTTON
function CheckpointTrigger::onEnterTrigger(%this,%obj,%col) {
	if (%col.noPickup || %col._warping) {
		return;
	}
	//echo("got into trigger");
	//%obj.setCheckpoint($Game::Checkpoint[%this.checkpointNum]);

	%player = %col.client;

	//if(!%obj.checkpointNum)
	//   echo("ERROR!!! No checkpointNum specified.");
	if (%obj != %player.curCheckpoint && %obj.unusable !$= "1") {
		%col.client.setCheckpointTrigger(%obj);
	}
}

function CheckpointTrigger::onMissionReset(%this, %obj) {
	if (%obj.unusable $= "1" && $TexturePack::MBXP)
		%obj.unusable = 0;
}

function CheckPointClass::onCollision(%this,%obj,%col,%vec, %vecLen, %material) {
	if (!Parent::onCollision(%this,%obj,%col,%vec, %vecLen, %material)) return;
	if (%col.noPickup || %col._warping) {
		return;
	}
	//echo("got into trigger");
	//if(!%obj.checkpointNum)
	//   echo("ERROR!!! No checkpointNum specified.");

	%player = %col.client;
	if (%obj != %col.client.curCheckpoint && %obj.chkcollide $= "1") {
		%col.client.setCheckpointButton(%obj);
	}
}

function CheckPointClass::onAdd( %this, %obj )
{
   if (%obj.chkcollide $= "")
	%obj.chkcollide = "1";

   if ($pref::spchanges && %obj.isTemperable $= "1") {
	%obj.setDataBlock("Checkpoint_MBU");
	%obj.setScale("1 1 1");
   }
}

function GameConnection::setCheckpointButton(%this, %object) {
	if (Mode::callback("shouldDisableCheckpoint", false, new ScriptObject() {
		client = %this;
		obj = %object;
		_delete = true;
	})) {
		return;
	}

	//Make sure they can actually use this checkpoint first
	if (%this.isOOB && %object.disableOOB)
		return;

	messageClient(%this, 'MsgCheckpoint', "\c0Checkpoint reached!");
	%this.playPitchedSound("checkpoint");

	%this.setCheckpoint(%object, %object);
}

function GameConnection::setCheckpointTrigger(%this, %object) {
	if (Mode::callback("shouldDisableCheckpoint", false, new ScriptObject() {
		client = %this;
		obj = %object;
		_delete = true;
	})) {
		return;
	}

	//Make sure they can actually use this checkpoint first
	%respawnPoint = %object.respawnPoint;
	if (!isObject(%respawnPoint)) {
		ASSERT("Error Handler", "Checkpoint " @ %object.getId() @ " has an invalid respawn point!");
		return;
	}

	if (%this.isOOB && %respawnPoint.disableOOB)
		return;

	messageClient(%this, 'MsgCheckpoint', "\c0Checkpoint reached!");
	%this.playPitchedSound("checkpoint");

	%this.setCheckpoint(%object, %respawnPoint);
	// %object.playThread(0, "activate");
	%respawnPoint.playThread(0, "activate", 1);
	%respawnPoint.setThreadDir(0,true);
}

// CALM YO BUTT
// I FIXED DIS STUPID abuse where you would spawn at 0 0 300
// horray for simsets?
function GameConnection::getCheckpointPos(%this,%num,%add) {
	%defaultGrav = "1 0 0 3.141592653589793238462643383279502884";
	%defaultPos = "0 0 300 1 0 0 0";
	%defaultPitch = (MissionInfo.cameraPitch $= "" ? 0.45 : MissionInfo.cameraPitch);

	//Where will we spawn?

	//Check if the game mode has a spawn for us
	%spawn = Mode::callback("getCheckpointPos", "", new ScriptObject() {
		client = %this;
		num = %num;
		add = %add;
		_delete = true;
	});
	if (%spawn !$= "") {
		//They do, use that instead of whatever we were planning
		devecho("getCheckpointPos: Using gamemode-specified spawnpoint.");
		if (getFieldCount(%spawn) == 1) {
			//Ugh the mode only gave us position
			%spawn = %spawn TAB %defaultGrav TAB %defaultPitch;
		}

		echo("Found start point: " @ %spawn);
		echo("  Transform: " @ getField(%spawn, 0));
		echo("  Gravity: " @ getField(%spawn, 1));

		return %spawn;
	} else if (isObject(%this.checkpointPad)) {
		//Checkpoints trump all other spawn points
		%spawn = %this.checkpointPad;
		devecho("getCheckpointPos: Using checkpoint pad for spawn platform");
	} else {
		//Does the startpad exist? Prefer it to a trigger.
		if (isObject(StartPoint)) {
			// Use the startpad's transform
			devecho("getCheckpointPos: Found StartPoint, using that.");
			%spawn = StartPoint;
		} else {
			// Just use the normal spawn trigger code
			if (%this.quickRespawning)
				%spawn = %this.getFurthestSpawnTrigger();
			else if (%this.restarting)
				%spawn = %this.getRandomSpawnTrigger();
			else
				%spawn = %this.getSpawnTrigger();

			//Update the trigger so we don't have a mess of people at the same point
			if (isObject(%spawn)) {
				%this.lastSpawnTrigger = %spawn;
				%spawn.getDataBlock().blockSpawning(%spawn);
				devecho("getCheckpointPos: Found normal spawn trigger.");
			}
		}
	}
	//No spawns found, just dump the default
	if (!isObject(%spawn)) {
		devecho("getCheckpointPos: No spawn point found.");
		return %defaultPos TAB %defaultGrav TAB %defaultPitch; // If this happens, I will stop coding.
	}

	//Rotation is just the spawnpoint's rotation
	%rotation = getWords(%spawn.getTransform(), 3, 6);

	//Pitch should really use the rotation from above but cbf
	%pitch = %defaultPitch;
	//Gravity can be specified or just default
	if (%spawn.gravity) {
		if (%spawn.gravityDir !$= "") {
			%gravity = rotationFromOrtho(%spawn.gravityDir);
		} else {
			%gravity = RotMultiply(%rotation, "1 0 0 3.1415926");
		}
		//Gravity takes on the forwards rotation so we shouldn't apply it twice
		%rotation = "1 0 0 0";
	} else if (%this.checkpointed) {
		//Gravity takes on the forwards rotation so we shouldn't apply it twice
		%gravity = rotationFromOrtho(%this.checkPointGravityDir);
		if (!VectorEqual(%gravity, %defaultGrav)) {
			%rotation = "1 0 0 0";
		}
	} else {
		%gravity = %defaultGrav;
	}

	//If the checkpoint has an add field, we should use it
	%add = %spawn.add;
	//If there is none, try to fill in a default
	if (%add $= "") {
		//Default is 3 units up, rotated if your spawnpoint has gravity
		%add = RotMulVector(%gravity, "0 0 -3");
	}

	//Where are we actually spawning?
	if (%spawn.center) {
		//Use the world box center XY and the transform Z for our spawnpoint
		%position = vectorAdd(getWords(%spawn.getWorldBoxCenter(), 0, 1) SPC getWord(%spawn.getTransform(), 2), %add);
	} else {
		//Just use the transform, super simple
		%position = vectorAdd(%spawn.getTransform(),%add);
	}

	echo("Found start point: " @ %spawn);
	echo("  Transform: " @ %spawn.getTransform());
	echo("  Add: " @ %add);
	echo("  Gravity: " @ %spawn.gravity);
	echo("  Center: " @ %spawn.center);

	echo("Calculated start parameters:");
	echo("  Position: " @ %position);
	echo("  Rotation: " @ %rotation);
	echo("  Gravity Direction: " @ %gravity);
	echo("  Pitch: " @ %pitch);

	return %position SPC %rotation TAB %gravity TAB %pitch;
}

function GameConnection::setCheckpoint(%this, %object, %respawnPoint) {
	if (!isObject(%respawnPoint)) {
		%respawnPoint = %object;
	}

	// Store the last checkpoint which will be used to restore
	// the player when he goes out of bounds.

	// DO WEIRD STUFF YOU WON'T UNDERSTAND NO MATTER YOU TRY.

	%this.checkpointPad = %respawnPoint;
	%this.checkpointTime = $Time::CurrentTime;
	%this.checkpointBonusTime = $Time::BonusTime;
	%this.checkpointPowerUp = %this.player.getPowerUp();
	%this.checkpointPowerUpObj = %this.player.powerUpObj;
	%this.checkpointBlast = %this.blastValue;
	%this.checkpointSpecialBlast = %this.usingSpecialBlast;
	%this.checkpointAdd = %object.add;
	%this.checkpointGravityDir = %this.player.getGravityDir();
	%this.checkpointGravityRot = %this.player.getGravityRot();
	%this.checkpointFireballTime = %this.getFireballTime();
	%this.checkpointBubbleTime = %this.bubbleTime;
	%this.checkpointBubbleInfinite = %this.bubbleInfinite;
	%this.saveCheckpointGemCount();

	//echo("gem count" @ %player.gemCount);
	%this.checkpointed = 1; // We've hit a checkpoint once.

	%this.curCheckpoint = %object;
	%this.curCheckpointNum++;

	ServerGroup.onActivateCheckpoint();
	%this.sendCallback("OnActivateCheckpoint");
	Mode::callback("onActivateCheckpoint", "", new ScriptObject() {
		client = %this;
		obj = %object;
		_delete = true;
	});
}

function GameConnection::setPowerUpOnCheckpoint(%this, %powerup, %obj) {
	//If you get a PowerUp in the 0.5s after respawning
	if (%this.checkpointFoundPowerup)
		return;

	%this.player.setPowerUp(%powerup, true, %obj);
}

function GameConnection::respawnOnCheckpoint(%this) {
	// Reset the player back to the last checkpoint
	cancel(%this.respawnSchedule);

	if (%this.spawningBlocked()) {
		error("Spawning blocked for client:" SPC %this);
		%this.respawnSchedule = %this.schedule(300, "respawnOnCheckpoint");
		return;
	}
	%this.blockSpawning(300);

	$Game::BlockTeleports = true; // Prevent teleport exploits unless the player actually enters one
	
	//Will happen at the start of next frame so no shame in doing it now
	%this.sendCallback("OnRespawnOnCheckpoint");

	//setGravityDir("1 0 0 0 -1 0 0 0 -1",true);
	endFireWorks();

	if (%this.cannon) {
		%this.cancelCannon();
	}

	cancel(%this.respawnSchedule);
	cancel(%this.player.iceShardSchedule);
	if (%this.player.isFrozen) {
		%this.player.iceShard.getDatablock().unfreeze(%this.player.iceShard, %this.player, true);
	}

	%this.clearAllPowerups();
	%this.player.setOOB(false);
	%this.player.setMode(Normal);
	%this.freezeMarble(false);

	%this.player.lockPowerup();
	%this.player.unlockPowerup(100);

	//Revert powerups
	if (%this.checkpointFireballTime == 0) {
		%this.fireballExpire();
	} else {
		%this.fireballInit(%this.checkpointFireballTime);
	}
	%this.setBubbleTime(%this.checkpointBubbleTime, %this.checkpointBubbleInfinite);

	cancel(%this.checkpointPowerupSchedule);
	if (%this.checkPointPowerUp)
		%this.checkpointPowerupSchedule = %this.schedule($powerupDelay, "setPowerUpOnCheckpoint", %this.checkPointPowerUp, %this.checkPointPowerUpObj);
	%this.player.setPowerUp(0,true);
	%this.player.powerUpData = "";
	%this.checkpointFoundPowerup = false;

	%pos = %this.getCheckpointPos(0, %this.checkPointAdd);
	echo("Checkpoint respawn at " @ %pos);
	%this.player.setVelocity("0 0 0");
	%this.player.setAngularVelocity("0 0 0");
	%this.player.setPosition(getField(%pos, 0), getField(%pos, 2));

	%ortho = VectorOrthoBasis(getField(%pos, 1));
	%ortho = VectorRemoveNotation(%ortho);
	%this.setGravityDir(%ortho, true, getField(%pos, 1));

	%this.restoreCheckpointGemCount();
	%this.respawnObjects(MissionGroup); // Respawn gems.

	%this.blastValue = %this.checkpointBlast;
	%this.setBlastValue(%this.blastValue);
	%this.setSpecialBlast(%this.checkpointSpecialBlast);
	%this.usingPartyTripleBlast = false;
	$MP::PartyTripleBlast = false;

	//SP only right now--
	if ($Server::ServerType $= "SinglePlayer") {
		//Reset TT time if they checkpoint abuse
		if (($CurrentGame $= "PlatinumQuest" || MissionInfo.game $= "PlatinumQuest" || (MissionInfo.game $= "Custom" && MissionInfo.modification $= "PlatinumQuest")) && !MissionInfo.noAntiCheckpoint) {
			Time::setBonusTime(0);
		}
	}
	%this.setGemCount(%this.getGemCount());
	%this.playPitchedSound("spawn");
	//setGameState("Play"); // Remove onscreen message
	// stop the oob message
	cancel(CenterMessageDlg.timer);
	%this.setMessage("");

	ServerGroup.onCheckpointReset();

	Mode::callback("onRespawnOnCheckpoint", "", new ScriptObject() {
		client = %this;
		_delete = true;
	});
}

// Respawn gems not in checkpoint.
function GameConnection::respawnObjects(%this, %group) {
	devecho("Starting respawnObjects.");
	// Count up all gems out there are in the world
	for (%i = 0; %i < %group.getCount(); %i++) {
		%object = %group.getObject(%i);
		%type = %object.getClassName();
		if (%type $= "SimGroup")
			%this.respawnObjects(%object);
		else {
			if (%object._pickUpCheckpoint >= %this.curCheckpointNum && isObject(%object._pickUp) && %object._pickUp.getId() == %this.getId()) {
				//echo("Respawning gem" SPC %object);
				%object.onMissionReset(); // respawn gem.
				%object._pickUpCheckpoint = "";
				%object._pickUp = "";
				%this.gemPickup[%object] = false;
				devecho("Gem respawned.");
			}
		}
	}

	for (%i = 0; %i < %this.gemPickupCount; %i++) {
		%this.gemPickup[%this.gemPickups[%i]] = "";
		%this.gemLookup[%this.gemPickups[%i]] = "";
		%this.gemPickups[%i] = "";
	}
	%this.gemPickupCount = 0;
}

function GameConnection::resetCheckpoint(%this) {
	cancel(%this.checkpointPowerupSchedule);

	%this.checkpointed = 0; // Reset checkpoint counter.
	%this.curCheckpoint = 0;
	%this.curCheckpointNum = 0;

	%this.checkPointPad = $Game::StartPad;
	%this.checkPointTime = Mode::callback("getStartTime", 0);
	%this.checkPointBonusTime = 0;
	%this.checkPointPowerUp = 0;
	%this.checkPointBlast = 0;
	%this.checkpointSpecialBlast = 0;
	%this.checkpointFireballTime = 0;
	%this.checkpointBubbleTime = 0;
	%this.checkpointBubbleInfinite = false;

	%this.resetCheckpointGemCount();
}

function GameConnection::resetCheckpointGemCount(%this) {
	%this.checkPointGemCount = 0;
	%this.checkPointGemsFound[1] = 0;
	%this.checkPointGemsFound[2] = 0;
	%this.checkPointGemsFound[5] = 0;
	%this.checkPointGemsFound[10] = 0;
	%this.checkPointGemsFoundTotal = 0;
}

function GameConnection::restoreCheckpointGemCount(%this) {
	%this.gemCount = %this.checkPointGemCount;
	%this.gemsFound[1] = %this.checkPointGemsFound[1];
	%this.gemsFound[2] = %this.checkPointGemsFound[2];
	%this.gemsFound[5] = %this.checkPointGemsFound[5];
	%this.gemsFound[10] = %this.checkPointGemsFound[10];
	%this.gemsFoundTotal  = %this.checkPointGemsFoundTotal;
}

function GameConnection::saveCheckpointGemCount(%this) {
	%this.checkPointGemCount = %this.gemCount;
	%this.checkPointGemsFound[1] = %this.gemsFound[1];
	%this.checkPointGemsFound[2] = %this.gemsFound[2];
	%this.checkPointGemsFound[5] = %this.gemsFound[5];
	%this.checkPointGemsFound[10] = %this.gemsFound[10];
	%this.checkPointGemsFoundTotal = %this.gemsFoundTotal;
}

function SimGroup::onCheckpointReset(%this) {
	if (%this.cpresetting) //It's apparently inside itself.. Shit
		return;
	%this.cpresetting = true;
	%count = %this.getCount();
	for (%i = 0; %i < %count; %i++)
		%this.getObject(%i).onCheckpointReset();
	%this.cpresetting = "";
}

function SimObject::onCheckpointReset(%this) {
}

function GameBase::onCheckpointReset(%this) {
	%this.getDataBlock().onCheckpointReset(%this);
}

function SimGroup::onActivateCheckpoint(%this) {
	if (%this.cpactivate) //It's apparently inside itself.. Shit
		return;
	%this.cpactivate = true;
	%count = %this.getCount();
	for (%i = 0; %i < %count; %i++)
		%this.getObject(%i).onActivateCheckpoint();
	%this.cpactivate = "";
}

function SimObject::onActivateCheckpoint(%this) {
}

function GameBase::onActivateCheckpoint(%this) {
	%this.getDataBlock().onActivateCheckpoint(%this);
}

function trot() {
	Withall("SpawnTrigger", "ttrot(%this);", MissionGroup);
}

function ttrot(%trig) {
	%trans = %trig.getTransform();
	%pos = MatrixPos(%trans);
	%rot = MatrixMultiply("0 0 0" SPC MatrixRot(%trans), "0 0 0 1 0 0 3.141592653589");
	%trig.setTransform(MatrixMultiply(%pos, %rot));
}
function tnoadd() {
	withall("SpawnTrigger", "%this.add=\"0 0 0\";");
}