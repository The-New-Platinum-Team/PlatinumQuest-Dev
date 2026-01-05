//-----------------------------------------------------------------------------
// Portions Copyright (c) 2021 The Platinum Team
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
// Torque Game Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

// These scripts make use of dynamic attribute values on Item datablocks,
// these are as follows:
//
//    maxInventory      Max inventory per object (100 bullets per box, etc.)
//    pickupName        Name to display when client pickups item
//
// Item objects can have:
//
//    count             The # of inventory items in the object.  This
//                      defaults to maxInventory if not set.

//-----------------------------------------------------------------------------
// ItemData base class methods used by all items
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

function Item::respawn(%this) {
	// This method is used to respawn static ammo and weapon items
	// and is usually called when the item is picked up.
	// Instant fade...
	%this.setFadeVal(0);
	%this.hide(true);

	%respawnTime = (%this.respawnTime $= "" ? $Item::RespawnTime : %this.respawnTime);

	%this._respawns ++;

	//Don't return if over the max
	if (%this.maxRespawns > 0 && %this._respawns > %this.maxRespawns)
		return;

	// Schedule a reapearance
	%this._respawnSchedule = %this.schedule(%respawnTime, "onRespawn");
}

function Item::onRespawn(%this, %noFade) {
	cancel(%this._respawnSchedule);
	%this.hide(false);
	if (%this._sync) {
		%this.setSync();
	}
	if (%noFade) {
		%this.setFadeVal(1);
	} else {
		%this.setFadeVal(0);
		%this.schedule(100, "startFade", 1000, 0, false);
	}

	%this.getDataBlock().initFX(%this);
	%this.getDataBlock().onRespawn(%this);
}

function Item::onMissionReset(%this) {
	cancelAll(%this);
	if (%this.getDataBlock().onMissionReset(%this)) {
		%this.onRespawn(true);
	}
	// Reset paths if we're restarting
	if (Mode::callback("shouldResetPath", true, new ScriptObject() {
		this = %this;
		_delete = true;
	})) {
		%this.resetPath();
	}
	%this._respawns = 0;
}

function Item::onCheckpointReset(%this) {
	if (%this.checkpointInstantRespawn || %this.getDataBlock().checkpointInstantRespawn && %this.isHidden()) {
		cancelAll(%this);
		%this.onRespawn(true);
	}
}

function ItemData::onMissionReset(%this, %obj) {
	return true;
}

function ItemData::onRespawn(%this, %obj) {

}

function ItemData::getPickupName(%this, %obj) {
	// When the audio pack is set to change powerup names, do that. ~ Connie
	if ($Audio::CurrentAudioPack.changepowerupnames == 1)
	{
		switch$ (%this.pickupName)
		{
			// Powerups for all games
			case "a Super Jump PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.superjump $= "")
					return "a Super Jump PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.superjump;
			case "a Super Speed PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.superspeed $= "")
					return "a Super Speed PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.superspeed;
			case "a Super Bounce PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.superbounce $= "")
					return "a Super Bounce PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.superbounce;
			case "a Shock Absorber PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.shockabsorber $= "")
					return "a Shock Absorber PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.shockabsorber;
			case "a Gravity Modifier!":
				if ($Audio::CurrentAudioPack.powerupstrings.antigravity $= "")
					return "a Gravity Modifier!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.antigravity;
			case "a Gyrocopter PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.gyrocopter $= "")
					return "a Gyrocopter PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.gyrocopter;

			// MBU & MP Powerups
			case "a Mega Marble PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.megamarble $= "")
					return "a Mega Marble PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.megamarble;
			case "a Blast PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.blast $= "")
					return "a Blast PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.blast;

			// PQ Powerups - The Teleporter is handled in powerups.cs
			case "an Anvil PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.anvil $= "")
					return "an Anvil PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.anvil;
			case "a Bubble PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.bubble $= "")
					return "a Bubble PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.bubble;
			case "a Fireball PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.fireball $= "")
					return "a Fireball PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.fireball;

			// Others
			case "a Super Stop PowerUp!":
				if ($Audio::CurrentAudioPack.powerupstrings.superstop $= "")
					return "a Super Stop PowerUp!";
				else
					return $Audio::CurrentAudioPack.powerupstrings.superstop;
			default:
				return %this.pickupName;
		}
	}
	else
	{
		return %this.pickupName;
	}
}

function ItemData::onPickup(%this,%obj,%user,%amount) {
	%pickup = Mode::callback("shouldPickupItem", true, new ScriptObject() {
		this = %this;
		obj = %obj;
		user = %user;
		amount = %amount;
		_delete = true;
	});

	//Mode-specific disabling
	if (!%pickup)
		return false;

	// Inform the client what they got.
	if (isObject(%user.client) && !%this.noPickupMessage) {
		messageClient(%user.client, 'MsgItemPickup', '\c0You picked up %1', %this.getPickupName(%obj));
	}

// Superior alernative...
//      messageClient(%user.client, 'MsgItemPickup', '\c0you were nicely, kindly, generously, allowed to have %1', %this.getPickupName(%obj));

	// Which checkpoint did you pick up this gem?
	//echo("DEBUG: CurCheckpointNum:" SPC %user.client.CurCheckpointNum);
	//echo("DEBUG: %user:" SPC %user);
	if (%this.checkpointRespawn) {
		%obj._pickUp = %user.client;
		%obj._pickUpCheckpoint = %user.client.curCheckpointNum;
	}
	//echo("DEBUG: %obj._pickUpCheckpoint:" SPC %obj._pickUpCheckpoint);
	//echo("DEBUG: %obj._pickUp:" SPC %obj._pickUp);

	// If the item is a static respawn item, then go ahead and
	// respawn it, otherwise remove it from the world.
	// Anything not taken up by inventory is lost.
	if (%this.permanent) {
		%obj.setCollisionTimeout(%user);
	} else if (%obj.isStatic()) {
		%this.clearFX(%obj);
		if (%this.noRespawn || %obj.noRespawn) {
			%obj.hide(true);
		} else {
			%obj.respawn();
		}
	} else {
		%this.clearFX(%obj);
		%obj.delete();
	}
	return true;
}


//-----------------------------------------------------------------------------
// Hook into the mission editor.

function ItemData::create(%data) {
	// The mission editor invokes this method when it wants to create
	// an object of the given datablock type.  For the mission editor
	// we always create "static" re-spawnable rotating objects.
	%obj = new Item() {
		dataBlock = %data;
		static = true;
		rotate = true;
	};
	return %obj;
}


function SimObject::isGame(%this) {
	return 0;
}

function GameBase::isGame(%this) {
	return 1;
}

function SimObject::isScene(%this) {
	return 0;
}

function SceneObject::isScene(%this) {
	return 1;
}