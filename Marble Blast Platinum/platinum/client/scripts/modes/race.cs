//-----------------------------------------------------------------------------
// Client Race Mode stuff
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

//-----------------------------------------------------------------------------
// This was started at 3:15:44am (for Matan) on 11/8/2014 and all he has to say
// right now is "I thought I saw clientRating.cs"
//
// I think he's gone senile. Someone call a paramedic.
// He thinks I'm funny. I think his brain is toasted.
//-----------------------------------------------------------------------------

ModeInfoGroup.add(new ScriptObject(ModeInfo_race) {
	class = "ModeInfo_race";
	superclass = "ModeInfo";

	identifier = "race";
	file = "race";

	name = "Racing";
	desc = "Race ahead of your competition as you see who can finish the level the fastest!";
	complete = 1;

	teams = 0;
	hide = 1;
});


function ClientMode_race::onLoad(%this) {
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onRespawnOnCheckpoint");
	%this.registerCallback("onActivateCheckpoint");
	%this.registerCallback("shouldIgnoreItem");
	%this.registerCallback("shouldPickupItem");
	%this.registerCallback("shouldUseClientPowerups");
	%this.registerCallback("radarShouldShowObject");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_race::onRespawnPlayer(%this) {
	racingOnRespawn();
	$Client::RaceLastCP = 0;
}
function ClientMode_race::onRespawnOnCheckpoint(%this) {
	racingOnRespawnAtCheckpoint($Client::RaceLastCP);
}
function ClientMode_race::onActivateCheckpoint(%this) {
	$Client::RaceLastCP ++;
}
function ClientMode_race::shouldIgnoreItem(%this, %object) {
	switch$ (%object.this.getDataBlock().getName()) {
	case "SuperJumpItem" or
			"SuperSpeedItem" or
			"SuperBounceItem" or
			"ShockAbsorberItem" or
			"HelicopterItem" or
			"MegaMarbleItem" or
			"BlastItem" or
			"AntiGravityItem" or
			"NoRespawnAntiGravityItem":
		//PowerUp
		if (%object.this.respawning) {
			return true;
		} else {
			if (%object.this._getPowerUpId() != 0) {
				if (%object.marble._powerUpId == %object.this._getPowerUpId()) {
					return true;
				}
				return false;
			}
			return false;
		}
	}
	return true;
}
function ClientMode_race::shouldPickupItem(%this, %object) {
	switch$ (%object.this.getDataBlock().getName()) {
	case "SuperJumpItem" or
			"SuperSpeedItem" or
			"SuperBounceItem" or
			"ShockAbsorberItem" or
			"HelicopterItem" or
			"MegaMarbleItem" or
			"BlastItem" or
			"AntiGravityItem" or
			"NoRespawnAntiGravityItem":
		//PowerUp
		if (%object.this.respawning) {
			return false;
		} else {
			if (%object.this._getPowerUpId() != 0) {
				if (%object.marble._powerUpId == %object.this._getPowerUpId()) {
					return false;
				}
				return true;
			}
			return true;
		}
	}
	return false;
}
function ClientMode_race::shouldUseClientPowerups(%this) {
	return true;
}
function ClientMode_race::radarShouldShowObject(%this, %object) {
	return !%object.isCloaked() && !%object.isHidden();
}

function clientCmdGemPickup(%id) {
	%gem = getClientSyncObject(%id);
	%gem.hide(true);
	%gem._checkpoint = $Client::RaceLastCP;
	Radar::RemoveTarget(%gem);
}

function racingOnRespawn() {
	%count = ServerConnection.getCount();

	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);
		if (%obj.getDataBlock().getClassName() $= "ItemData") {
			%obj.hide(false);
			%obj._checkpoint = 0;
			%obj.startFade(0, 0, false);
		}
	}
}

function racingOnRespawnAtCheckpoint() {
	%count = ServerConnection.getCount();

	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);
		if (%obj.getDataBlock().getClassName() $= "ItemData" && %obj._checkpoint >= $Client::RaceLastCP) {
			%obj.hide(false);
			%obj._checkpoint = 0;
			%obj.startFade(0, 0, false);
		}
	}
}
