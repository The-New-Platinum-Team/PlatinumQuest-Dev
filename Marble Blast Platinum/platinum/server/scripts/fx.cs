//-----------------------------------------------------------------------------
// Effects and particles and stuff
//
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

function GameBaseData::initFX(%this, %obj) {
	if (!isObject(FXGroup)) {
		new SimGroup(FXGroup);
		MissionCleanup.add(FXGroup);
	}

	//No particles anyway, ignore this
	if (%this.fxEmitter[0] $= "")
		return;

	//If the object doesn't want to have particles then don't make it
	if (%obj.noParticles $= "")
		%obj.noParticles = "0";
	if (%obj.noParticles)
		return;

	if (%obj._isBackup)
		return;

	if ((%obj.getType() & $TypeMasks::ShapeBaseObjectType) && %obj.isHidden()) {
		return;
	}

	for (%i = 0; %this.fxEmitter[%i] !$= ""; %i ++) {
		//Don't create double emitters
		if (isObject(%obj._fx[%i]))
			continue;

		%datablock = %this.fxDatablock[%i];
		%emitter = %this.fxEmitter[%i];

		//Default is boring
		if (%datablock $= "")
			%datablock = "FireworkNode";

		//Datablocks can specify to have the skin name appended
		if (%this.fxSkin[%i])
			%emitter = %emitter @ %obj.getSkinName();

		cancel(%this.createFXSchedule[%obj, %i]);
		%this.createFXSchedule[%obj, %i] = %this.schedule(10, createFXEmitter, %obj, %datablock, %emitter, %i);
	}
}

function GameBaseData::createFXEmitter(%this, %obj, %datablock, %emitter, %index) {
	//Because apparently this can happen sometimes
	if (!isObject(%obj)) {
		return;
	}
	//Don't create double emitters
	if (isObject(%obj._fx[%i])) {
		return;
	}

	//Could have hidden in this time
	if ((%obj.getType() & $TypeMasks::ShapeBaseObjectType) && %obj.isHidden()) {
		return;
	}

	%pos = vectorAdd(%obj.getWorldBoxCenter(), "0 0 0.05");
	%emitter = new ParticleEmitterNode() {
		datablock = %datablock;
		emitter = %emitter;
		position = %pos;
		rotation = %obj.getRotation();
		scale = "0 0 0";
		trail = "1";
		attachId = %obj.getSyncId();
		_isFX = "1";
	};
	%obj._fx[%index] = %emitter;

	//Holy shit stop being deleted
	if (!isObject(FXGroup)) {
		new SimGroup(FXGroup);
		MissionCleanup.add(FXGroup);
	}

	// FXGroup should automatically clean up all particles once the game ends
	// should not have any leaks.
	FXGroup.add(%emitter);

	// Fuck it, it's PQ.
	// We wonder why this game is so buggy.
	%obj.forceNetUpdate();

	//Try again in a few seconds maybe this will catch the few gems whose
	// particles don't want to follow.
	%obj.onNextFrame(forceNetUpdate);
	%emitter.schedule(500, forceNetUpdate);

	if (isServerMovingObject(%obj)) {
		%emitter.setParent(%obj, "0 0 0 1 0 0 0", true, "0 0 0");
	}
}

function GameBaseData::clearFX(%this, %obj) {
	// kill off the particles
	for (%i = 0; isObject(%obj._fx[%i]); %i ++) {
		%obj._fx[%i].delete();
		%obj._fx[%i] = "";
	}
}
