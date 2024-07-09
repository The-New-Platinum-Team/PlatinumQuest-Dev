//-----------------------------------------------------------------------------
// Camera Triggers
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

function CameraDistanceTrigger_onClientEnterTrigger(%this, %trigger, %user) {
	//Don't care if other people use this
	if (!MPMyMarbleExists() || %user.getId() != MPGetMyMarble().getId())
		return;
	%trigger.prevDistance = getCameraDistance();

	CDT(%trigger.time, %trigger.smooth, %trigger.distance);
}

function CameraDistanceTrigger_onClientStayTrigger(%this, %trigger, %user) {
	//Nothing
}

function CameraDistanceTrigger_onClientLeaveTrigger(%this, %trigger, %user) {
	//Don't care if other people use this
	if (!MPMyMarbleExists() || %user.getId() != MPGetMyMarble().getId())
		return;
	if (%trigger.keepeffectonleave)
		return;

	if (%trigger.ForceExitValue)
		CDT(%trigger.time, %trigger.smooth, %trigger.ForceExitValue);
	else if (%trigger.prevDistance !$= "")
		CDT(%trigger.time, %trigger.smooth, %trigger.prevDistance);
	else if (MissionInfo.initialCameraDistance !$= "")
		CDT(%trigger.time, %trigger.smooth, MissionInfo.initialCameraDistance);
	else
		CDT(%trigger.time, %trigger.smooth, $Physics::Defaults::CameraDistance);

	%trigger.prevdistance = "";
}

function clientCmdSetCameraDistance(%time, %smooth, %distance) {
	// If a CDT is active then just set the original distance and let it keep going
	if ($CDT::IsRunning) {
		$CDT::OriginalDistance = %distance;
		return;
	}

	if (%time <= 0)
		%time = 1;
	if (%distance $= "")
		%distance = $Physics::Defaults::CameraDistance;

	CDT(%time, %smooth, %distance);
}

function getCameraDistance() {
	//If we're CDTing give us the final
	if ($CDT::IsRunning) {
		return $CDT::Distance;
	}
	//Get current camera distance
	return $MP::MyMarble.getdatablock().cameraDistance;
}

//Camera Distance Trigger function
//%time - time in ms to perform fade
//%smooth - movement is smoothed, not constant
//%distance - new distance to change to

function CDT(%time, %smooth, %distance, %isLoop) {
	cancel($CDTSched);

	%db = $MP::MyMarble.getdatablock();

	if (%time) {
		if (!%isLoop && $CDT::IsRunning) {
			//we're already running, so let's change course

			$CDT::TimeCount = 0;
			$CDT::Time = %time;
			$CDT::Smooth = %smooth;
			$CDT::Distance = %distance;
			$CDT::OriginalDistance = %db.cameradistance;
		}
		//otherwise, this is a new CDT loop
		$CDT::TimeCount = 0;
		$CDT::Time = %time;
		$CDT::Smooth = %smooth;
		$CDT::Distance = %distance;
		$CDT::OriginalDistance = %db.cameradistance;
	}

	$CDT::IsRunning = 1;

	if ($CDT::TimeCount >= $CDT::Time) {
		%db.cameradistance = $CDT::Distance;
		$CDT::TimeCount = "";
		$CDT::Time = "";
		$CDT::Smooth = "";
		$CDT::Distance = "";
		$CDT::OriginalDistance = "";
		$CDT::IsRunning = 0;
		return;
	}

	if ($CDT::Smooth) {
		%wavepos = -0.5 * mCos(($CDT::TimeCount / $CDT::Time) * 3.14159) + 0.5;
		%newdist = $CDT::OriginalDistance + (%wavepos * ($CDT::Distance - $CDT::OriginalDistance));
	} else
		%newdist = $CDT::OriginalDistance + ($CDT::Distance - $CDT::OriginalDistance) * ($CDT::TimeCount / $CDT::Time);
	%db.cameradistance = %newdist;

	$CDT::TimeCount += 14;

	$CDTSched = schedule(14, 0, "CDT", 0, 0, 0, 1);
}

function CDTCancel() {
	$CDT::IsRunning = 0;
	cancel($CDTSched);
}

function CDTReset() {
	%distance = ($CDT::OriginalDistance $= "" ? $Physics::Defaults::CameraDistance : $CDT::OriginalDistance);
	%group = (!$Server::Hosting || $Server::_Dedicated) ? ServerConnection : DataBlockGroup;

	// find all marble datablocks and reset them to this
	for (%i = 0; %i < %group.getCount(); %i++) {
		%db = %group.getObject(%i);
		if (%db.getClassName() $= "MarbleData") {
			%db.cameraDistance = %distance;
		}
	}
}

//-----------------------------------------------------------------------------

function CameraTrigger_onClientEnterTrigger(%this, %trigger, %user) {
	if (%trigger.pitch !$= "" && %trigger.pitch !$= "NoChange")
		%user.setCameraPitch(%trigger.useRadians ? %trigger.pitch : mDegToRad(%trigger.pitch));
	if (%trigger.yaw !$= "" && %trigger.yaw !$= "NoChange")
		%user.setCameraYaw(%trigger.useRadians ? %trigger.yaw : mDegToRad(%trigger.yaw));
}

function CameraTrigger_onClientStayTrigger(%this, %trigger, %user) {
	//Nothing
}

function CameraTrigger_onClientLeaveTrigger(%this, %trigger, %user) {
	//Nothing
}

//-----------------------------------------------------------------------------

function resetCameraFov() {
	if ($Game::Menu) {
		//Menu default
		%fov = ClientMode::callback("getMenuCameraFov", 90);

		//If the mission overrides it
		if (MissionInfo.menuCameraFov !$= "") {
			%fov = MissionInfo.menuCameraFov;
		}
	} else {
		//Default from the options
		%fov = ClientMode::callback("getCameraFov", $pref::Player::defaultFov);

		//If the mission overrides it
		if (MissionInfo.cameraFov !$= "") {
			%fov = MissionInfo.cameraFov;
		}
	}

	//Locked to 90 always for cannons
	if (isCannonActive()) {
		%fov = 90;
	}

	// Set the player's FOV
	setCameraFov(%fov);
}

function setCameraFov(%fov) {
	gameCtrlCheck();
	echo("Set camera fov: " @ %fov);
	PG_GameCtrl.forceFov = %fov;
	PG_ShowCtrl.forceFov = %fov;
	PG_SaveMyBaconCtrl.forceFov = %fov;
}

function getCameraFov() {
	gameCtrlCheck();
	if (PG_GameCtrl.isVisible() && PG_GameCtrl.forceFov)
		return PG_GameCtrl.forceFov;
	if (PG_ShowCtrl.isVisible() && PG_ShowCtrl.forceFov)
		return PG_ShowCtrl.forceFov;
	//Built-in
	return $cameraFov;
}

//-----------------------------------------------------------------------------

function getScriptCameraTransform() {
	if (isCannonActive()) {
		return $Cannon::CameraTransform;
	}
	return $MP::MyMarble.getCameraTransform();
}

function gameCtrlCheck() {
	if (!isObject(PG_GameCtrl)) {
		RootGui.add(new GameTSCtrl(PG_GameCtrl) {
			profile = "GuiDefaultProfile";
			horizSizing = "width";
			vertSizing = "height";
			position = "0 0";
			extent = Canvas.getExtent();
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
			cameraZRot = "0";
			forceFOV = "90";
		});
		RootGui.pushToBack(PG_ShowCtrl);
	}
	if (!isObject(PG_ShowCtrl)) {
		RootGui.add(new ShowTSCtrl(PG_ShowCtrl) {
			profile = "GuiDefaultProfile";
			horizSizing = "width";
			vertSizing = "height";
			position = "0 0";
			extent = Canvas.getExtent();
			minExtent = "8 8";
			visible = "0";
			helpTag = "0";
			cameraZRot = "0";
			forceFOV = "90";
		});
	}
}

function useScriptCameraTransform(%use) {
	gameCtrlCheck();
	$Game::ScriptCameraTransform = %use;
	PG_GameCtrl.setVisible(!%use);
	PG_ShowCtrl.setVisible(%use);

	//Major hackery: Use two because one stops showing
	PG_SaveMyBaconCtrl.setVisible(%use);

	//Find the sky
	%sky = findSky(($Server::Hosting && !$Server::_Dedicated) ? MissionGroup : ServerConnection);
	if (isObject(%sky))
		%distance = %sky.getFieldValue("visibleDistance");
	else
		%distance = 500; //Reasonable guess

	PG_ShowCtrl.setVisibleDistance(%distance);
	PG_SaveMyBaconCtrl.setVisibleDistance(%distance);
}

function PG_ShowCtrl::onRender(%this) {
	if (isObject($Client::ColCannon)) {
		updateCannonAim(%this);
	}
}
function PG_SaveMyBaconCtrl::onRender(%this) {
	if (isObject($Client::ColCannon)) {
		updateCannonAim(%this);
	}
}

function getCameraTransform() {
	if ($Game::ScriptCameraTransform) {
		return getScriptCameraTransform();
	} else {
		return getFastCameraTransform();
	}
}
