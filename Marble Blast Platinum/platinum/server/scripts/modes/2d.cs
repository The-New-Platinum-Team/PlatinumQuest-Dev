//-----------------------------------------------------------------------------
// 2D Mode from PQ
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

function Mode_2d::onLoad(%this) {
	%this.registerCallback("onSpawnPlayer");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onMissionEnded");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}

function Mode_2d::onMissionLoaded(%this) {
	%this.detectCamera();
}

function Mode_2d::detectCamera(%this) {
	echo("[Mode 2d]: MissionInfo " @ MissionInfo.getId() @ " camera plane is " @ MissionInfo.cameraPlane);
	if (MissionInfo.cameraPlane $= "") {
		//No 2d by default
		return;
	}

	//Figure out what the camera yaw should be
	switch$ (MissionInfo.cameraPlane) {
	case "xz": //X / Z axis: camera should be at default
		%this.targetYaw = 0;
	case "yz": //Y / Z axis: camera should be 1/4 turn
		%this.targetYaw = $pi_2;
	default: //Custom angle (in degrees)
		%this.targetYaw = mDegToRad(MissionInfo.cameraPlane);
	}

	if (MissionInfo.invertCameraPlane) { //If the camera should be rotated 180
		%this.targetYaw += $pi;
	}
}

function Mode_2d::onMissionEnded(%this) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.isReal())
			continue;
		%client.stop2D();
	}
	%this.targetYaw = "";
}
function Mode_2d::onSpawnPlayer(%this, %object) {
	%this.detectCamera();

	if (%this.targetYaw $= "") {
		warn("[Mode 2d]: No default mode, using 3d by default!");
	} else {
		echo("[Mode 2d]: Target yaw: " @ %this.targetYaw);
		%object.client.start2D(%this.targetYaw, MissionInfo.invertCameraPlane, MissionInfo.initialCameraDistance);
	}
}
function Mode_2d::onRespawnPlayer(%this, %object) {
	%this.detectCamera();

	if (%this.targetYaw $= "") {
		warn("[Mode 2d]: No default mode, using 3d by default!");
	} else {
		echo("[Mode 2d]: Target yaw: " @ %this.targetYaw);
		%object.client.start2D(%this.targetYaw, MissionInfo.invertCameraPlane, MissionInfo.initialCameraDistance);
	}
}

//make FOV 100, make auto FOV changer based on res

function GameConnection::start2D(%this, %yaw, %inverted, %cameraDistance) {
	%this.player.setCameraYaw(%yaw);
	%this.active2D = true; //Because fields can't start with a number
	commandToClient(%this, 'Start2D', %yaw, %inverted, %cameraDistance);
}

function GameConnection::stop2D(%this, %resetCamera) {
	%this.active2D = false;
	commandToClient(%this, 'Stop2D', %resetCamera);
}

//-----------------------------------------------------------------------------

datablock TriggerData(TDTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "Plane";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "2D Plane";
	customField[0, "desc"   ] = "Plane to start 2D mode in (xz xy yz or a degree value)";
	customField[0, "default"] = "xz";
	customField[1, "field"  ] = "InvertDirection";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Invert Direction";
	customField[1, "desc"   ] = "If the plane should be rotated 180 degrees.";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "KeepEffectOnLeave";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Keep Effect on Leave";
	customField[2, "desc"   ] = "Don't reset to 3D when leaving the trigger.";
	customField[2, "default"] = "0";
	customField[3, "field"  ] = "Override";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Override Active 2D";
	customField[3, "desc"   ] = "Override any other 2D mode that is currently active";
	customField[3, "default"] = "1";
	customField[4, "field"  ] = "CamDistance";
	customField[4, "type"   ] = "float";
	customField[4, "name"   ] = "Camera Distance";
	customField[4, "desc"   ] = "Set the marble's camera distance to this when entering or NoChange to not change it.";
	customField[4, "default"] = "5";
	customField[5, "field"  ] = "targetPitch";
	customField[5, "type"   ] = "float";
	customField[5, "name"   ] = "Camera Pitch";
	customField[5, "desc"   ] = "Set the marble's camera pitch (in degrees) to this when entering or NoChange to not change it.";
	customField[5, "default"] = "NoChange";
};

function TDTrigger::onAdd(%this, %obj) {
	if (%obj.Plane $= "")              //Plane to lock to 2d. Uses xz if left blank.
		%obj.Plane = "xz";              //Also accepts degree values.

	if (%obj.InvertDirection $= "")    //180 degree rotation applied to above value
		%obj.InvertDirection = "0";

	if (%obj.KeepEffectOnLeave $= "")  //Keep 2d active upon leaving trigger.
		%obj.KeepEffectOnLeave = "0";   //(to avoid coating your entire 2d section with the trigger)

	if (%obj.Override $= "")           //Override any other 2d that is currently active.
		%obj.Override = "1";

	if (%obj.CamDistance $= "")        //Change Marble's camera distance to this.
		%obj.CamDistance = "5";         //Set to "NoChange" to keep current distance.

	if (%obj.targetPitch $= "")        //Change Marble's camera pitch to this.
		%obj.targetPitch = "NoChange";  //Set to "NoChange" to keep current pitch.

	if (!$Game::isMode["2d"]) {
		%modes = resolveMissionGameModes($Server::MissionFile, "");
		%modes = addWord(%modes, "2d");
		MissionInfo.gameMode = %modes;
		setGameModes(%modes);

		error("TDTrigger needs 2d mode but it's not listed in MissionInfo. Activating it ourselves");
	}
}

function TDTrigger::onEnterTrigger(%this,%trigger,%obj) {
	//Figure out what the camera yaw should be
	switch$ (%trigger.plane) {
	case "xz": //X / Z axis: camera should be at default
		%targetYaw = 0;
	case "yz": //Y / Z axis: camera should be 1/4 turn
		%targetYaw = $pi_2;
	default: //Custom angle (in degrees)
		%targetYaw = mDegToRad(%trigger.plane);
	}

	if (%trigger.InvertDirection) { //If the camera should be rotated 180
		%targetYaw += $pi;
	}

	if (%trigger.targetPitch !$= "NoChange") {
		%obj.setCameraPitch(mDegToRad(%trigger.targetPitch));
	}

	%obj.client.start2D(%targetYaw, %trigger.InvertDirection, %trigger.CamDistance $= "NoChange" ? "" : %trigger.CamDistance);
}

function TDTrigger::onLeaveTrigger(%this,%trigger,%obj) {
	if (%trigger.KeepEffectOnLeave)
		return;

	%obj.client.stop2D(true);
}

//-----------------------------------------------------------------------------

datablock TriggerData(StopTDTrigger) {
	tickPeriodMS = 100;
};

function StopTDTrigger::onEnterTrigger(%this,%trigger,%obj) {
	%obj.client.stop2D(true);
}
