//------------------------------------------------------------------------------
// Multiplayer Package
// gameConnection.cs
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
// GameConnection Commands

function GameConnection::startTimer(%this) {
	commandToClient(%this, 'startTimer');
}

function GameConnection::stopTimer(%this) {
	commandToClient(%this, 'stopTimer');
}

function GameConnection::resetTimer(%this) {
	commandToClient(%this, 'resetTimer');
}
function GameConnection::setTimeStopped(%this, %stopped) {
	if (%this.fake)
		return;
	commandToClient(%this, 'setTimeStopped', %stopped);
}

function GameConnection::setMessage(%this, %message, %timeout) {
	commandToClient(%this, 'setMessage', %message, %timeout);
}

function GameConnection::playPitchedSound(%this, %sound) {
	commandToClient(%this, 'playPitchedSound', %sound);
}

// sets quick respawn status
function GameConnection::setQuickRespawnStatus(%this, %status) {
	%this.canQuickRespawn = %status;
}

function GameConnection::getGemCount(%this) {
	return Mode::callback("getGemCount", %this.gemCount, new ScriptObject() {
		client = %this;
		_delete = true;
	});
}

function GameConnection::activateAchievement(%this, %catId, %achId) {
	commandToClient(%this, 'ActivateAchievement', %catId, %achId);
}

function GameConnection::setGemCount(%this, %gems) {
	if ($Server::ServerType $= "MultiPlayer") {
		%count = ClientGroup.getCount();
		%best = true;
		for (%i = 0; %i < %count; %i ++) {
			%client = ClientGroup.getObject(%i);
			if (%client.gemCount > %gems) {
				%best = false;
				break;
			}
		}
	} else
		%best = false;
	if (%best) {
		%count = ClientGroup.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%client = ClientGroup.getObject(%i);
			commandToClient(%client, 'setGemCount', %client.getGemCount(), false);
		}
	}
	commandToClient(%this, 'setGemCount', %gems, %best);
}

function GameConnection::setMaxGems(%this, %gems) {
	commandToClient(%this, 'setMaxGems', %gems);
}

function GameConnection::displayGemMessage(%this, %amount, %color) {
	commandToClient(%this, 'displayGemMessage', %amount, %color);
}

function GameConnection::addHelpLine(%this, %line, %playBeep) {
	commandToClientLong(%this, 'addHelpLine', %line, %playBeep);
}

function GameConnection::addBubbleLine(%this, %line, %help, %time, %isAHelpTrigger) {
	if (%this.fake)
		return;
	cancel(%this.downsched);
	commandToClientLong(%this, 'AddBubbleLine', %line, %help, %isAHelpTrigger);

	if (%time $= "")
		%time = 5000;
	if (%time > 0) {
		%this.downsched = %this.schedule(%time, hideBubble);
	}
}
function GameConnection::hideBubble(%this) {
	if (%this.fake)
		return;
	commandToClient(%this, 'HideBubble');
}

function GameConnection::adjustTimer(%this, %time) {
	commandToClient(%this, 'adjustTimer', %time);
}

function GameConnection::addBonusTime(%this, %time) {
	commandToClient(%this, 'addBonusTime', %time);
}

function GameConnection::setBonusTime(%this, %time) {
	commandToClient(%this, 'setBonusTime', %time);
}

function GameConnection::setTime(%this, %time) {
	commandToClient(%this, 'setTime', %time);
}

function GameConnection::setPowerUp(%this, %powerUp, %powerUpId, %skinName) {
	commandToClient(%this, 'setPowerUp', %powerUp, %powerUpId, %skinName);
}

function GameConnection::setCameraFov(%this, %fov) {
	commandToClient(%this, 'setCameraFov', %fov);
}

function GameConnection::setCameraDistance(%this, %time, %smooth, %distance) {
	commandToClient(%this, 'setCameraDistance', %time, %smooth, %distance);
}

function GameConnection::setGravityDir(%this, %dir, %reset, %rot) {
	%this.gravityDir = %dir;
	%this.gravityRot = %rot;
	%this.gravityUV  = getWords(%dir, 6, 8);
	if (%rot $= "")
		%this.gravityRot = RotationFromOrtho(%dir);

	%this.player.setGravityDir(%dir, %reset);

	echo("Client" SPC %this SPC "setting gravity dir to" SPC %dir SPC "rot:" SPC %rot);
	commandToClient(%this, 'setGravityDir', %dir, %reset, %rot);
}

function GameConnection::applyImpulse(%this, %position, %impulse) {
	commandToClient(%this, 'ApplyImpulse', %position, %impulse);
}

function GameConnection::gravityImpulse(%this, %position, %impulse) {
	commandToClient(%this, 'GravityImpulse', %position, %impulse);
}

function GameConnection::setMarbleVelocity(%this, %velocity) {
	commandToClient(%this, 'SetMarbleVelocity', %velocity);
}

function GameConnection::freezeMarble(%this, %frozen, %position) {
	commandToClient(%this, 'FreezeMarble', %frozen, %position);
}

function GameConnection::setBubbleTime(%this, %time, %infinite) {
	%this.bubbleTime = %time;
	%this.bubbleInfinite = %infinite;
	commandToClient(%this, 'SetBubbleTime', %time, %infinite);
}

function GameConnection::activateBubble(%this, %active) {
	commandToClient(%this, 'ActivateBubble', %active);
}

function GameConnection::fixGhost(%this) {
	commandToClient(%this, 'FixGhost');
}

function GameConnection::endGameSetup(%this) {
	commandToClient(%this, 'EndGameSetup');
}

function GameConnection::incrementOOBCounter(%this) {
	commandToClient(%this, 'incrementOOBCounter');
}

function GameConnection::setBlastValue(%this, %blastValue) {
	%this.blastValue = %blastValue;
	commandToClient(%this, 'setBlastValue', %blastValue);
}

function GameConnection::setSpecialBlast(%this, %specialBlast) {
	%this.usingSpecialBlast = %specialBlast;
	commandToClient(%this, 'setSpecialBlast', %specialBlast);
}

function GameConnection::radarInit(%this) {
	commandToClient(%this, 'RadarStart');
	commandToClient(%this, 'RadarBuildSearch');
}

function GameConnection::setMovementKeysEnabled(%this, %enabled) {
	if (%this.fake)
		return;
	commandToClient(%this, 'EnableMovementKeys', %enabled);
}

function GameConnection::sendSharedSpawnPoint(%this) {
	if ($MP::SharedSpawnPointIndex $= "") {
		chooseSharedSpawnPoint();
	}
	commandToClient(%this, 'setSharedSpawnPoint', $MP::SharedSpawnPointIndex);
}

function GameConnection::setWhiteOut(%this, %whiteout) {
	%this.player.setWhiteOut(max(%this.player.getWhiteOut(), %whiteout));
}

function updateSpawnSet(%grp) {
	if (!isObject(SpawnPointSet)) {
		new SimSet(SpawnPointSet);
		RootGroup.add(SpawnPointSet);
	}
	for (%i = 0; %i < %grp.getCount(); %i ++) {
		%obj = %grp.getObject(%i);
		if (%obj.getClassName() $= "Trigger" && %obj.getDataBlock().getName() $= "SpawnTrigger")
			SpawnPointSet.add(%obj);
		if (%obj.getClassName() $= "SimGroup")
			updateSpawnSet(%obj);
	}
}

function GameConnection::spawningBlocked(%this) {
	if (%this.spawningBlocked) {
		return true;
	}
	if (!mp()) {
		return false;
	}

	//If there aren't any spawn points we don't have anything to be blocked on
	updateSpawnSet(MissionGroup);
	if (!isObject(SpawnPointSet))
		return false;

	%size = SpawnPointSet.getCount();
	if (%size == 0)
		return false;

	//If all spawn points are blocked we're blocked too
	for (%i = 0; %i < %size; %i ++) {
		%obj = SpawnPointSet.getObject(%i);
		if (!isObject(%obj))
			continue;
		if (!%obj._block)
			return false;
	}
	return !isObject(StartPoint);
}

function GameConnection::blockSpawning(%this, %time) {
	//Used for consistency mode calcuations, actual blocking uses a schedule
	%this.lastSpawnTime = $Sim::Time;
	%this.schedule(%time, unblockSpawning);

	%this.spawningBlocked = true;
}

function GameConnection::unblockSpawning(%this) {
	%this.spawningBlocked = false;
}

function GameConnection::getSpawnTrigger(%this) {
	if (!isObject(SpawnPointSet))
		return -1;
	if (!isObject(%this.player))
		return -1;

	%size = SpawnPointSet.getCount();
	if (%size == 0)
		return -1;

	%closest = 0;
	%distance = -1;

	if (($Sim::Time - %this.lastSpawnTime) > 4)
		%this.lastSpawnTrigger = "";

	%playerPos = getWords((%this.player.lastTouch !$= "" ? %this.player.lastTouch : %this.player.getTransform()), 0, 2);

	if (!isObject(%this.player)) // We don't know *where* we'll spawn!
		return SpawnPointSet.getObject(getRandom(0, %size - 1));

	for (%i = 0; %i < %size; %i ++) {
		%obj = SpawnPointSet.getObject(%i);
		if (!isObject(%obj) || %obj == %this.lastSpawnTrigger || %obj._block)
			continue;
		%dist = VectorDist(%obj.getPosition(), %playerPos);
		if (%dist < %distance || %distance == -1) {
			%closest = %obj;
			%distance = %dist;
		}
	}

	if (%closest == 0) {
//      error("Closest is 0!");
//      error("Random spawning!");
		return SpawnPointSet.getObject(getRandom(0, %size - 1));
	}

	return %closest;
}

function GameConnection::getFurthestSpawnTrigger(%this) {
	if (!isObject(SpawnPointSet))
		return -1;

	%spawnCount = SpawnPointSet.getCount();
	if (%spawnCount == 0)
		return -1;

	%furthest = 0;
	%distance = -1;

	if (($Sim::Time - %this.lastSpawnTime) > 4)
		%this.lastSpawnTrigger = "";

	%playerPos = getWords((%this.player.lastTouch !$= "" ? %this.player.lastTouch : %this.player.getTransform()), 0, 2);

	// The gem positions are kinda like the marble's pos... I guess?
	// If this happens, see ya on the other side of the level, sucker
	if ($Game::IsMode["hunt"] && getRandom(0, 50) > 5)
		%playerPos = %this.getNearestGem(true, false).getPosition();

	if (!isObject(%this.player)) // We don't know *where* we'll spawn!
		return SpawnPointSet.getObject(getRandom(0, %spawnCount - 1));

	// Random entry
	%count = getRandom(%spawnCount / 2, %spawnCount * 2) + 3;

	for (%i = 0; %i < %count; %i ++) {
		%obj = SpawnPointSet.getObject(%i);
		if (!isObject(%obj) || %obj == %this.lastSpawnTrigger || %obj._block)
			continue;
		%dist = VectorDist(%obj.getPosition(), %playerPos);

		// Pick the furthest trigger. This'll teach you to quickspawn abuse,
		// you ass! Next time roll for the damned gems.
		if (%dist > %distance || %distance == -1) {
			%furthest = %obj;
			%distance = %dist;
		}
	}

	if (%furthest == 0) {
//		error("RS Furthest is 0!");
//		error("RS Random spawning!");
		return SpawnPointSet.getObject(getRandom(0, %spawnCount - 1));
	}

	// random enough
	return %furthest;
}

function GameConnection::getRandomSpawnTrigger(%this) {
	if (!isObject(SpawnPointSet))
		return -1;

	%size = SpawnPointSet.getCount();
	if (%size == 0)
		return -1;

	if (($Sim::Time - %this.lastSpawnTime) > 4)
		%this.lastSpawnTrigger = "";

	return SpawnPointSet.getObject(getRandom(0, %size - 1));
}

function GameConnection::getSharedSpawnTrigger(%this) {
	if (!isObject(SpawnPointSet))
		return -1;

	%size = SpawnPointSet.getCount();
	if (%size == 0)
		return -1;

	if (($Sim::Time - %this.lastSpawnTime) > 4)
		%this.lastSpawnTrigger = "";

	if ($MP::SharedSpawnPointIndex $= "") {
		// We don't have a value here...
		$MP::SharedSpawnPointIndex = 0;
	}

	%index = $MP::SharedSpawnPointIndex % %size;

	return SpawnPointSet.getObject(%index);
}

function GameConnection::pointToNearestGem(%this) {
	%pos = %this.player.getPosition();
	%yp = transformToNearestGem(%this.player.getGravityRot(), %pos, true);

	%this.player.setCameraYaw(getField(%yp, 0));
	%this.player.setCameraPitch(getField(%yp, 1));
}

function transformToNearestGem(%gravity, %pos, %highestValue) {
	%nearest = getNearestGem(%pos, %highestValue, true);
	if (%nearest == -1)
		return;

	%dist = VectorSub(getWords(%nearest.getTransform(), 0, 2), %pos);
	%dist = MatrixMulVector("0 0 0" SPC RotMultiply(%gravity, "1 0 0 3.1415926"), %dist);

	%angle = mAtan(getWord(%dist, 0), getWord(%dist, 1));

	%dist = setWord(%dist, 2, getWord(%dist, 2) - 2);
	%hypo = VectorLen(%dist);
	%pitch = -mAsin((getWord(%dist, 2) / %hypo) * 0.7);

	return %angle TAB %pitch;
}

//-----------------------------------------------------------------------------

function GameConnection::marblelandHasMission(%this, %id, %callback) {
	%this.marblelandHasMissionCallback[%id] = %callback;
	commandToClient(%this, 'MarblelandHasMission', %id);
}

function GameConnection::marblelandDownload(%this, %id, %callback) {
	%this.marblelandDownloadCallback[%id] = %callback;
	commandToClient(%this, 'MarblelandDownload', %id);
}

function GameConnection::marblelandLoad(%this, %id) {
	commandToClient(%this, 'MarblelandLoad', %id);
}
