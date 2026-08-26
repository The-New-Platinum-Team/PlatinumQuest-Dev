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
	%this.registerCallback("onMissionReset");
	%this.registerCallback("shouldEnableBlast");
	%this.registerCallback("shouldUpdateBlast");
	%this.registerCallback("updateControls");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
//Blast is only available on Ultra race levels, never Gold/Platinum -
//MissionInfo.game is carried over unmodified from the source mission files
//(Ultra's set it to "Ultra", Gold/Platinum's never set it at all)
function ClientMode_race::shouldEnableBlast(%this) {
	return MissionInfo.game $= "Ultra";
}
//shouldUpdateBlast()'s own default only charges blast once $PlayTimerActive
//is set, which doesn't happen until "Go!" - charge it from the moment the
//marble spawns instead, same as single player. (Can't key this off
//$Game::State: clientCmdSetGameState explicitly skips updating it for the
//host, so that never reads "Ready" locally in a listen-served race.)
function ClientMode_race::shouldUpdateBlast(%this) {
	return shouldEnableBlast() && MPMyMarbleExists();
}
//PQ Gem Madness levels show a countdown from the level's original time
//limit, matching how Gem Madness normally displays. The underlying clock
//(PlayGui.currentTime) still counts up from 0 like every other race
//level - that's what actually gets used for ranking - this only
//overwrites the rendered digits afterward, purely cosmetic.
function ClientMode_race::updateControls(%this) {
	if (MissionInfo.pqSourceMode !$= "GemMadness")
		return "";

	%et = MissionInfo.time - PlayGui.currentTime;
	if (%et < 0)
		%et = 0;

	%hundredth = div64_int(mod64_int(%et, 1000), 10);
	%totalSeconds = div64_int(%et, 1000);
	%seconds = mod64_int(%totalSeconds, 60);
	%minutes = div64_int(sub64_int(%totalSeconds, %seconds), 60);

	%secondsOne   = %seconds % 10;
	%secondsTen   = (%seconds - %secondsOne) / 10;
	%minutesOne   = %minutes % 10;
	%minutesTen   = (%minutes - %minutesOne) / 10;
	%hundredthOne = %hundredth % 10;
	%hundredthTen = (%hundredth - %hundredthOne) / 10;

	if ($pref::Thousandths) {
		%thousandth = mod64_int(%et, 10);
		Min_Ten_Th.setTimeNumber(%minutesTen);
		Min_One_Th.setTimeNumber(%minutesOne);
		Sec_Ten_Th.setTimeNumber(%secondsTen);
		Sec_One_Th.setTimeNumber(%secondsOne);
		Sec_Tenth_Th.setTimeNumber(%hundredthTen);
		Sec_Hundredth_Th.setTimeNumber(%hundredthOne);
		Sec_Thousandth_Th.setTimeNumber(%thousandth);
	} else {
		Min_Ten.setTimeNumber(%minutesTen);
		Min_One.setTimeNumber(%minutesOne);
		Sec_Ten.setTimeNumber(%secondsTen);
		Sec_One.setTimeNumber(%secondsOne);
		Sec_Tenth.setTimeNumber(%hundredthTen);
		Sec_Hundredth.setTimeNumber(%hundredthOne);
	}
	return "";
}
function ClientMode_race::onMissionReset(%this) {
	//Fresh attempt - claimed time items become pickupable (and visible)
	//again. The server clears its own matching guard in
	//TimeTravelItem::onMissionReset.
	%count = ServerConnection.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);
		if (%obj.getDataBlock().getClassName() $= "ItemData")
			%obj.raceClaimed = false;
	}
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
//Every base powerup datablock the switches below need to recognize also has
//_PQ and/or _MBU (Ultra) variants (e.g. MegaMarbleItem_MBU, BlastItem_MBU)
//used by their respective levels - matching only the base name here left
//Ultra powerups like Marble Melee Primer's Blast/Mega Marble completely
//unpickupable in race, since the datablock name never matched any case and
//fell through to "ignore this item" / "don't pick it up".
function ClientMode_race::shouldIgnoreItem(%this, %object) {
	switch$ (%object.this.getDataBlock().getName()) {
	case "SuperJumpItem" or "SuperJumpItem_PQ" or "SuperJumpItem_MBU" or "CustomSuperJumpItem_PQ" or
			"SuperSpeedItem" or "SuperSpeedItem_PQ" or "SuperSpeedItem_MBU" or
			"SuperBounceItem" or "SuperBounceItem_PQ" or
			"ShockAbsorberItem" or "ShockAbsorberItem_PQ" or
			"HelicopterItem" or "HelicopterItem_PQ" or "HelicopterItem_MBU" or
			"MegaMarbleItem" or "MegaMarbleItem_MBU" or
			"BlastItem" or "BlastItem_MBU" or
			"AntiGravityItem" or "AntiGravityItem_PQ" or "AntiGravityItem_MBU" or
			"NoRespawnAntiGravityItem" or "NoRespawnAntiGravityItem_PQ" or "NoRespawnAntiGravityItem_MBU" or
			"TeleportItem" or "AnvilItem" or "BubbleItem":
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
	case "SuperJumpItem" or "SuperJumpItem_PQ" or "SuperJumpItem_MBU" or "CustomSuperJumpItem_PQ" or
			"SuperSpeedItem" or "SuperSpeedItem_PQ" or "SuperSpeedItem_MBU" or
			"SuperBounceItem" or "SuperBounceItem_PQ" or
			"ShockAbsorberItem" or "ShockAbsorberItem_PQ" or
			"HelicopterItem" or "HelicopterItem_PQ" or "HelicopterItem_MBU" or
			"MegaMarbleItem" or "MegaMarbleItem_MBU" or
			"BlastItem" or "BlastItem_MBU" or
			"AntiGravityItem" or "AntiGravityItem_PQ" or "AntiGravityItem_MBU" or
			"NoRespawnAntiGravityItem" or "NoRespawnAntiGravityItem_PQ" or "NoRespawnAntiGravityItem_MBU" or
			"TeleportItem" or "AnvilItem" or "BubbleItem":
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

//Unlike gems, a time item shouldn't come back just because you fell back
//to (or before) a checkpoint - once you've claimed it, it's yours for the
//rest of this attempt. raceClaimed marks that permanently (until mission
//reset - see ClientMode_race::onMissionReset), separately from the
//checkpoint-based _checkpoint tracking gems use.
function clientCmdTimeItemPickup(%id) {
	%item = getClientSyncObject(%id);
	%item.hide(true);
	%item.raceClaimed = true;
	Radar::RemoveTarget(%item);
}

function racingOnRespawn() {
	%count = ServerConnection.getCount();

	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);
		if (%obj.getDataBlock().getClassName() $= "ItemData" && !%obj.raceClaimed) {
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
		if (%obj.getDataBlock().getClassName() $= "ItemData" && !%obj.raceClaimed && %obj._checkpoint >= $Client::RaceLastCP) {
			%obj.hide(false);
			%obj._checkpoint = 0;
			%obj.startFade(0, 0, false);
		}
	}
}
