//-----------------------------------------------------------------------------
// Gravitex mode
//
// Inspired by Hunt Plus - Gravitex, from 2022
//
// Copyright (c) 2023 The Platinum Team
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
// How Gravitex works:
// Hunt: Switch gravity after a gem spawn
// Mega Marble War: Switch gravity after a collision
// Collection / Co-op / Others: Switch gravity after 10 seconds
//-----------------------------------------------------------------------------

function Mode_gravitex::onLoad(%this) {
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onActivate");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("onHuntGemSpawn");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("onServerGo");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onRespawnOnCheckpoint");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}

$Gravitex::Time = 10000;

//--------------------------------------------------------------------------
//Reset gravitex variables
function Mode_gravitex::onMissionReset(%this) {
	%this.Gravitex0 = true;
	%this.Gravitex1 = false;
	%this.Gravitex2 = false;
	cancel(%this.GravitexSchedule);
}
function Mode_gravitex::onMissionEnded(%this) {
	%this.Gravitex0 = true;
	%this.Gravitex1 = false;
	%this.Gravitex2 = false;
	cancel(%this.GravitexSchedule);
}
function Mode_gravitex::onActivate(%this) {
	%this.onMissionEnded();
}
function Mode_gravitex::onDeactivate(%this) {
	%this.onMissionEnded();
	ClientGroup.forEach("%this.setGravityDir", "1 0 0 0 -1 0 0 0 -1", true, "1 0 0 3.1415926535");
}

//--------------------------------------------------------------------------

function Mode_gravitex::onHuntGemSpawn(%this) {
	if (!$Game::isMode["hunt"])
		return;

	if (isGameStarted() && !$Game::FirstSpawn) {
		%this.gravitex();
	}
}

function Mode_gravitex::onFoundGem(%this, %object) {
	if (!$Game::isMode["mega"])
		return;

	if (isGameStarted()) {
		%this.gravitex();
	}
}

function Mode_gravitex::onServerGo(%this) {
	cancel(%this.GravitexSchedule);
	if ($Game::isMode["hunt"] || $Game::isMode["mega"])
		return;
	%this.GravitexSchedule = %this.schedule($Gravitex::Time, gravitex, true);
}

//--------------------------------------------------------------------------

function Mode_gravitex::gravitex(%this, %loop) {
	cancel(%this.GravitexSchedule);
	if (!$Game::isMode["gravitex"])
		return;
	if (!isGameStarted())
		return;

	if (%this.Gravitex1 || %this.Gravitex0) {
		%this.Gravitex0 = false;
		%this.Gravitex1 = false;
		%this.Gravitex2 = true;
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.setGravityDir("-0.965925 0 0.258822 0 1 0 -0.258822 0 -0.965925");
			%client.play2D(PuAntiGravityVoiceSfx);
		}
	} else if (%this.Gravitex2) {
		%this.Gravitex0 = false;
		%this.Gravitex1 = true;
		%this.Gravitex2 = false;
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.setGravityDir("-0.965926 0 -0.258817 0 1 0 0.258817 0 -0.965926");
			%client.play2D(PuAntiGravityVoiceSfx);
		}
	}
	
	//gravitex(true) starts a loop
	if (%loop)
		%this.GravitexSchedule = %this.schedule($Gravitex::Time, gravitex, true);
}

//--------------------------------------------------------------------------

function Mode_gravitex::onRespawnPlayer(%this, %object) {
	if (%this.Gravitex1) {
		%object.client.setGravityDir("-0.965926 0 -0.258817 0 1 0 0.258817 0 -0.965926", true, getField(%object.client.getCheckpointPos(), 1));
	} else if (%this.Gravitex2) {
		%object.client.setGravityDir("-0.965925 0 0.258822 0 1 0 -0.258822 0 -0.965925", true, getField(%object.client.getCheckpointPos(), 1));
	}

}
function Mode_gravitex::onRespawnOnCheckpoint(%this, %object) {
	if (%this.Gravitex1) {
		%object.client.setGravityDir("-0.965926 0 -0.258817 0 1 0 0.258817 0 -0.965926", true, getField(%object.client.getCheckpointPos(), 1));
	} else if (%this.Gravitex2) {
		%object.client.setGravityDir("-0.965925 0 0.258822 0 1 0 -0.258822 0 -0.965925", true, getField(%object.client.getCheckpointPos(), 1));
	}

}