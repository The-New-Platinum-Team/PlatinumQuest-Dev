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

//-----------------------------------------------------------------------------
// fixes 1/11/16 :
// - Fixed keepVelocity
// - Added an option to just use the destination point's center of the box
//   instead of the corner of the trigger. Make it optional to keep compat.
//   with other levels.
// - Added ability to adjust the camera yaw after arriving at destination.
//-----------------------------------------------------------------------------

datablock TriggerData(DestinationTrigger) {
	tickPeriodMS = 100;
};

datablock TriggerData(TeleportTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "destination";
	customField[0, "type"   ] = "object";
	customField[0, "name"   ] = "Destination Object Name";
	customField[0, "desc"   ] = "Name of the destination object.";
	customField[0, "default"] = "";
	customField[1, "field"  ] = "delay";
	customField[1, "type"   ] = "time";
	customField[1, "name"   ] = "Delay";
	customField[1, "desc"   ] = "How long you have to wait to teleport.";
	customField[1, "default"] = "2000";
	customField[2, "field"  ] = "centerDestPoint";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Centered on Destination";
	customField[2, "desc"   ] = "If the teleporter should use the destination's center and not it's position (this is probably what you want).";
	customField[2, "default"] = "1";
	customField[3, "field"  ] = "keepVelocity";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Keep Velocity";
	customField[3, "desc"   ] = "Don't reset marble velocity when teleporting.";
	customField[3, "default"] = "0";
	customField[4, "field"  ] = "inverseVelocity";
	customField[4, "type"   ] = "boolean";
	customField[4, "name"   ] = "Invert Velocity";
	customField[4, "desc"   ] = "If marble velocity should be inverted when teleporting.";
	customField[4, "default"] = "0";
	customField[5, "field"  ] = "keepAngular";
	customField[5, "type"   ] = "boolean";
	customField[5, "name"   ] = "Keep Angular Velocity";
	customField[5, "desc"   ] = "Don't reset angular velocity when teleporting.";
	customField[5, "default"] = "0";
	customField[6, "field"  ] = "keepCamera";
	customField[6, "type"   ] = "boolean";
	customField[6, "name"   ] = "Keep Camera Direction";
	customField[6, "desc"   ] = "Don't reset camera direction when teleporting.";
	customField[6, "default"] = "0";
	customField[7, "field"  ] = "cameraYaw";
	customField[7, "type"   ] = "float";
	customField[7, "name"   ] = "Camera Yaw";
	customField[7, "desc"   ] = "Set marble's camera yaw to this value (in radians) after teleporting.";
	customField[7, "default"] = "";
	customField[8, "field"  ] = "GemsToActivate";
	customField[8, "type"   ] = "int";
	customField[8, "name"   ] = "Gem Count to Activate";
	customField[8, "desc"   ] = "Getting this many gems will activate the teleporter.";
	customField[8, "default"] = "";
	customField[9, "field"  ] = "GemsToDeactivate";
	customField[9, "type"   ] = "int";
	customField[9, "name"   ] = "Gem Count to Deactivate";
	customField[9, "desc"   ] = "Getting this many gems will deactivate the teleporter.";
	customField[9, "default"] = "";
	customField[10, "field"  ] = "DisplayGemsMessage";
	customField[10, "type"   ] = "boolean";
	customField[10, "name"   ] = "Show Gem Count Message";
	customField[10, "desc"   ] = "Alert the player if they don't have the right number of gems.";
	customField[10, "default"] = "0";
	customField[11, "field"  ] = "silent";
	customField[11, "type"   ] = "boolean";
	customField[11, "name"   ] = "Silent";
	customField[11, "desc"   ] = "Don't play a noise. Very handy for sneaky triggers.";
	customField[11, "default"] = "0";
};

datablock TriggerData(RelativeTPTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "destination";
	customField[0, "type"   ] = "object";
	customField[0, "name"   ] = "Destination Object Name";
	customField[0, "desc"   ] = "Name of the destination object.";
	customField[0, "default"] = "";
	customField[1, "field"  ] = "delay";
	customField[1, "type"   ] = "time";
	customField[1, "name"   ] = "Delay";
	customField[1, "desc"   ] = "How long you have to wait to teleport.";
	customField[1, "default"] = "2000";
	customField[2, "field"  ] = "silent";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Silent";
	customField[2, "desc"   ] = "Don't play a noise. Very handy for sneaky triggers.";
	customField[2, "default"] = "0";
	customField[3, "field"  ] = "TPScale";
	customField[3, "type"   ] = "Point3F";
	customField[3, "name"   ] = "Distance Scale";
	customField[3, "desc"   ] = "Offset distance will be scaled by this vector.";
	customField[3, "default"] = "1 1 1";
	customField[4, "field"  ] = "TPOffset";
	customField[4, "type"   ] = "Point3F";
	customField[4, "name"   ] = "Additional Offset";
	customField[4, "desc"   ] = "Offset this much from the destination trigger's center.";
	customField[4, "default"] = "0 0 0";
};

datablock AudioProfile(TeleportSound) {
	fileName = "~/data/sound/teleport.wav";
	description = AudioClose3d;
	preload = true;
};

function TeleportTrigger::checkDest(%group, %destination) {
	for (%i = 0; %i < %group.getCount(); %i++) {
		%object = %group.getObject(%i);
		%type = %object.getClassName();
		%name = %object.getName();
		//echo("This object is called " @ %name @ ", but destination is " @ %destination);
		//if (%type $= "SimGroup")
		//   return TeleportTrigger::checkDest(%group, %destination);
		//else
		if (%name $= %destination)
			return %object;
	}
	return nameToId(%destination);
}

function GameConnection::teleportPlayer(%this, %player, %obj, %teleTrigger) {
	if ($Game::BlockTeleports) {
		echo("Blocked teleport abuse");
		return;
	}
	if (%teleTrigger.centerDestPoint || %obj.centerDestPoint) {
		// FUCKING HELL. CAN'T FIGURE OUT HOW TO CENTER SHIT.
		%pos = %obj.getWorldBoxCenter();
	} else {
		//echo("DEBUG: Object is " @ %obj);
		%destPos = %obj.getPosition();
		%x = getWord(%destPos, 0);
		%y = getWord(%destPos, 1);
		%z = getWord(%destPos, 2);
		%z += 3.0;
		%pos = %x SPC %y SPC %z;
		//echo("DEBUG: Going to " @ %pos);
	}
	%this.playPitchedSound("spawn");

	%player.setTransform(%pos);

	//Reset fields
	if (!%teleTrigger.keepVelocity && !%obj.keepVelocity) {
		%player.setVelocity("0 0 0");
	}
	if (%teleTrigger.inverseVelocity || %obj.inverseVelocity) {
		%player.setVelocity(VectorScale(%player.getVelocity(), -1));
	}
	if (!%obj.keepAngular || !%teleTrigger.keepAngular) {
		%player.setAngularVelocity("0 0 0");
	}

	// Let the camera be allowed to be adjusted by yaw. The value can be
	// defined on either the teleport trigger or the destination trigger.
	// If no value is set, it resets it to 0.
	if (!%teleTrigger.keepCamera && !%obj.keepCamera) {
		if (%teleTrigger.cameraYaw !$= "")
			%yaw = mDegToRad(%teleTrigger.cameraYaw);
		else if (%obj.cameraYaw !$= "")
			%yaw = mDegToRad(%obj.cameraYaw);
		else
			%yaw = 0;
		%player.setCameraYaw(%yaw);
		%player.setCameraPitch(0.45);
	}
}

function TeleportTrigger::onEnterTrigger(%data, %obj, %colObj) {
	%name = %obj.getName();
	%client = %colObj.client;
	%destination = %obj.destination;
	%delay = %obj.delay;
	$Game::BlockTeleports = false;

	if (%client.gemCount < %obj.GemsToActivate) {
		if (%obj.DisplayGemsMessage) {
			%s = (%obj.GemsToActivate == 1) ? "" : "s";
			%client.addBubbleLine("You need " @ %obj.GemsToActivate @ " gem" @ %s @ " to activate this Teleporter.", 1, 2000);
		}
		return;
	}
	if (%obj.GemsToDeactivate !$= "" && %obj.GemsToDeactivate > -1) {
		if (%client.gemCount < %obj.GemsToDeactivate) {
			if (%obj.DisplayGemsMessage) {
				%s = (%obj.GemsToDeactivate == 1) ? "" : "s";
				%client.addBubbleLine("You need " @ %obj.GemsToDeactivate @ " gem" @ %s @ " to deactivate this Teleporter.", 1, 2000);
			}
		} else {
			return;
		}
	}

	// Error handler : If no destination specified...
	if (%destination $= "") {
		ASSERT("Error Handler", "There's no destination specified! Please check the .mis file.");
		return;
	}

	if (%delay $= "")
		%delay = 2000;

//   if(!%client)
//   {
//      echo("not a client!");
//      return;
//   }
//   echo("Teleport client:" SPC %client);

	%destination_obj = TeleportTrigger::checkDest(%obj.getGroup(), %destination);
	//echo("It returned " @ %destination_obj);
	if (%destination_obj == -1) {
		ASSERT("Error Handler", "checkDest() returned -1. Maybe the specified destination doesn't exist.");
		return;
	}

	messageClient(%client, 'teleportMsg', "\c0Teleporter has been activated" @((%delay >= 2000) ? ", please wait." : "."));

	cancel(%client.teleSched[%obj]);
	%client.teleSched[%obj] = %client.schedule(%delay, "teleportPlayer", %colObj, %destination_obj, %obj);
	if (!%trigger.silent)
		%client.teleSound = %client.play3D(TeleportSound, %client.player.getTransform());
	%client.player.setCloaked(true);
	commandToClient(%client, 'PushTimer', 696969, getSimTime(), %delay);
}

function TeleportTrigger::onLeaveTrigger(%data, %obj, %colObj) {
	%checkname = %obj.getName();
	%client = %colObj.client;
	//echo("TeleportTrigger::onLeaveTrigger called!");
	cancel(%client.teleSched[%obj]);
	alxStop(%client.teleSound);
	%client.player.setCloaked(false);
	commandToClient(%client, 'PushTimer', 696969, getSimTime(), 0);
}

function RelativeTPTrigger::onAdd(%this, %obj) {
	if (%obj.delay $= "")
		%obj.delay = "0";
	if (%obj.destination $= "")
		%obj.destination = "[TRIGGER NAME]";
	if (%obj.TPScale $= "")
		%obj.TPScale = "1 1 1";
	if (%obj.TPOffset $= "")
		%obj.TPOffset = "0 0 0";
	if (%obj.silent $= "")
		%obj.silent = 0;
}

function RelativeTPTrigger::onEnterTrigger(%data, %trigger, %obj) {
	%destination_obj = TeleportTrigger::checkDest(MissionGroup, %trigger.destination);
	//echo("It returned " @ %destination_obj);
	if (%destination_obj == -1) {
		ASSERT("Error Handler", "checkDest() returned -1. Maybe the specified destination doesn't exist.");
		return;
	}
	$Game::BlockTeleports = false;

	%client = %obj.client;

	// Calculate offset and do a command to client.
	%diff = vectorScale2(VectorScale(%trigger.getWorldBoxCenter(), -1), %trigger.TPScale);
	%pos = vectorAdd(%trigger.destination.getWorldBoxCenter(), %diff);
	%pos = vectorAdd(%pos, %trigger.TPOffset);

	//So they don't warp into stuff
	%obj.noPickup = true;
	commandToClient(%client, 'MarbleTeleport', %pos);

	cancel(%client.teleSched[%obj]);
	alxStop(%client.teleSound);
	if (!%trigger.silent)
		%client.teleSound = %client.play3D(TeleportSound, %client.player.getPosition());
}

function RelativeTPTrigger::onLeaveTrigger(%data, %trigger, %obj) {
	%client = %obj.client;
	cancel(%client.teleSched[%obj]);
	alxStop(%client.teleSound);
	%obj.noPickup = false;
}