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
//-----------------------------------------------------------------------------//-----------------------------------------------------------------------------

//todo
//
//camera adjust should happen when using superspeed while powerup button is held down
//MAKE LEVEL PARTS MAP IN CONSTRUCTOR FOR 2D MAPS
//Freeze camera on OOB
//Use missioninfo to level start 2d
//lockedpitch freepitch
//
//STEP ONE: press ESC
//STEP TWO: press 'home' button or whatever key is 'forceRespawn'
//STEP THREE: press the restart button (from the pause menu)
//STEP FOUR: ???
//STEP FIVE: SEIZUREEEEEEEEEEEEE, FIX!!!!! (aka profit!)

ModeInfoGroup.add(new ScriptObject(ModeInfo_2d) {
	class = "ModeInfo_2d";
	superclass = "ModeInfo";

	identifier = "2d";
	file = "2d";

	name = "2D";
	desc = "Lose a dimension but none of the challenge.";
});


/**
 * @param {ClientMode} %this
 */
function ClientMode_2d::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("onEditorOpened");
	%this.registerCallback("onEditorClosed");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("getCameraFov");
}
/**
 * @param {ClientMode_2d} %this
 */
function ClientMode_2d::onDeactivate(%this) {
	$Game::2D = false;
}
/**
 * @param {ClientMode_2d} %this
 */
function ClientMode_2d::onEditorOpened(%this) {
	if ($Game::2D) {
		Physics::popLayerName("2d");
	}

	$Editor::Was2D = $Game::2D;
	$Game::2D = false;
}
/**
 * @param {ClientMode_2d} %this
 */
function ClientMode_2d::onEditorClosed(%this) {
	$Game::2D = $Editor::Was2D;
	$Editor::Was2D = "";

	if ($Game::2D) {
		Physics::pushLayerName("2d");
	}
}
/**
 * @param {ClientMode_2d} %this
 */
function ClientMode_2d::onMissionEnded(%this) {
	clientCmdStop2D(true);
}
/**
 * @param {ClientMode_2d} %this
 */
function ClientMode_2d::onRespawnPlayer(%this) {
	if ($Game::2D) {
		Physics::pushLayerName("2d");
	}
}
/**
 * @param {ClientMode_2d} %this
 */
function ClientMode_2d::getCameraFov(%this) {
	if ($Game::2D) {
		//Because otherwise you can see way too much
		return 90;
	} else {
		//Let something else figure this out
		return "";
	}
}

function clientCmdStart2D(%yaw, %inverted, %distance) {
	$Game::2DYaw = %yaw;
	$Game::2DInverted = %inverted;

	if ($Game::2D) {
		CDT(1000, 1, %distance);
	} else {
		$Game::2D = true;
		$Game::2DPrevCameraDistance = getCameraDistance();
		%distance = %distance !$= "" ? mAbs(%distance) : 5;
		CDT(1000, 1, %distance);
	}

	Physics::pushLayerName("2d");

	$mvForwardAction = 0;
	$mvBackwardAction = 0;
	$mvYawRightSpeed = 0;
	$mvYawLeftSpeed = 0;
	$mvPitchDownSpeed = 0;
	$mvPitchUpSpeed = 0;

	resetCameraFov();
}

function clientCmdStop2D(%resetCamera) {
	$Game::2D = false;

	if ($Game::2DPrevCameraDistance !$= "" && %resetCamera) {
		if (getCameraDistance() != $Game::2DPrevCameraDistance)
			CDT(1000, 1, $Game::2DPrevCameraDistance);
		$Game::2DPrevCameraDistance = "";
	}
	Physics::popLayerName("2d");
	resetCameraFov();
}
