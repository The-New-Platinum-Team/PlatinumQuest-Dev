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
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onFoundGem");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}

function Mode_training::onMissionReset(%this) {
	//Count the total
	%this.spawnMax = %this.getCurrentSpawnScore();
	%this.spawnTime = getSimTime();
	%this.waitingNotice = false;
}

function Mode_training::onHuntGemSpawn(%this) {
	if (%this.waitingNotice) {
		//Got half the points on the last gem in the spawn
		commandToClient(%this.waitingClient, 'TrainingTime', sub64_int(getSimTime(), %this.spawnTime));
	}
	//Count the total
	%this.spawnMax = %this.getCurrentSpawnScore();
	%this.spawnTime = getSimTime();

	//If they get 100% in the time before we spawn the next then don't do it
	cancel(%this.spawnSch);
}

function Mode_training::onFoundGem(%this, %object) {
	//Count how many gems remain
	%score = %this.getCurrentSpawnScore();

	if (%score <= %this.spawnMax / 2) {
		//You got em all
		if (!isEventPending(%this.spawnSch)) {
			%this.spawnSch = schedule(1000, 0, spawnHuntGemGroup);
			%this.waitingNotice = false;
			commandToClient(%object.client, 'TrainingTime', sub64_int(getSimTime(), %this.spawnTime));
		}
	} else {
		%this.waitingNotice = true;
		%this.waitingClient = %object.client;
	}
}

function Mode_training::getCurrentSpawnScore(%this) {
	%score = 0;
	for (%i = 0; %i < SpawnedSet.getCount(); %i ++) {
		%score += 1 + SpawnedSet.getObject(%i)._huntDatablock.huntExtraValue;
	}
	return %score;
}
