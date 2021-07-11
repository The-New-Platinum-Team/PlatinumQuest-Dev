//-----------------------------------------------------------------------------
// Hunt training mode
//
// Copyright (c) 2017 The Platinum Team
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

function Mode_training::onLoad(%this) {
	%this.registerCallback("onHuntGemSpawn");
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}

function Mode_training::onMissionReset(%this) {
	//Count the total
	%this.spawnMax = %this.getCurrentSpawnScore();
	%this.spawnTime = getSimTime();
	cancel($countdowngraphic);
	cancel($pointsmessage);
	cancel($respawngemsloop);
	%this.schedule(4000, respawnTimerLoop); // 4000 is the ready set go sequence
}

function Mode_training::onMissionLoaded(%this) {
	// Make spawnpoints visible
	echo("Load");
	// For each spawnpoint
	%spawnCount = SpawnPointSet.getCount();
	for (%i = 0; %i < %spawnCount; %i ++) {
		%spawn = SpawnPointSet.getObject(%i);
		//addGemLight(%spawn);
		MissionCleanup.add(%spawn._light = new StaticShape() {
			datablock = "PhysModEmitterBase";
			position = getWords(%spawn.position, 0, 1) SPC (getWord(%spawn.position, 2) - 8); // lower the emitter by a lot
			rotation = %spawn.rotation;
			scale = %spawn.scale;
		});
	}
	//%staticShape = new StaticShape() {
	//	position = %pos[%j];
	//	rotation = "1 0 0 0";
	//	scale = "1 1 1";
	//	datablock = PhysModEmitterBase;
	//};
	//MissionCleanup.add(%staticShape);
	MissionInfo.redSpawnChance = 0.001;
	MissionInfo.yellowSpawnChance = 0.001;
	MissionInfo.blueSpawnChance = 1;
	MissionInfo.platinumSpawnChance = 1;
	MissionInfo.radiusFromGem = "135";
	MissionInfo.blast = "1";
	MissionInfo.CustomRadarRule = $Radar::Flags::Gems | $Radar::Flags::Powerups;
}


function Mode_training::onMissionEnded(%this) {
	cancel($countdowngraphic);
	cancel($pointsmessage);
	cancel($respawngemsloop);
}

function Mode_training::pointsMessage(%this) {
	if (sub64_int(getSimTime(), %this.spawnTime) < %this.respawnTimer) {
		commandToAll('TrainingTime', sub64_int(getSimTime(), %this.spawnTime));
	} else {
		commandToAll('PointsMessage', %this.spawnMax - %this.getCurrentSpawnScore(), %this.spawnMax);
	}
	
}

function deleteNonBlues() { // (unused function)
	// There's a blue? Delete all except that.
	echo("Delete!");
	%blue = false;
	%gemCount = SpawnedSet.getCount();
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];
		if (%gem._huntDatablock.huntExtraValue == 0) {
			unspawnGem(%gem, true);
		}
	}
	// Hide gemlights:
	commandToAll('UpdateItems');
}

function Mode_training::onHuntGemSpawn(%this) {
	cancel($pointsmessage);
	%this.respawnTimerLoop();

	%this.spawnMax = %this.getCurrentSpawnScore();
	%this.spawnTime = getSimTime();
}

function Mode_training::respawnTimerLoop(%this) {
	echo("Hey!");
	cancel($countdowngraphic);
	cancel($pointsmessage);
	cancel($respawngemsloop);
	%this.respawnTimer = 7000;
	%time = %this.respawnTimer;
	if (PlayGui.currentTime > %time) {
		$countdowngraphic = schedule(0, 0, commandToAll, 'StartCountdown', %time, "timerTimeTravel");
		$pointsmessage    = %this.schedule(%time, pointsMessage);
		$respawngemsloop    = schedule(%time+1, 0, spawnHuntGemGroup); // +1 so points message displays first
	}
}

function Mode_training::getCurrentSpawnScore(%this) {
	%score = 0;
	for (%i = 0; %i < SpawnedSet.getCount(); %i ++) {
		%score += 1 + SpawnedSet.getObject(%i)._huntDatablock.huntExtraValue;
	}
	return %score;
}
