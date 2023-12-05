//-----------------------------------------------------------------------------
// clientSpectator.cs
//
// allows you to spectate through people's cameras!
//
// To spectate, just do:
//    commandToServer('Spectate');
//
// Copyright (c) 2013 The Platinum Team
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
// Variables
//-----------------------------------------------------------------------------

// lets us know if we are in spectate mode or not.
$SpectateMode = false;

// the current plebian index to spectate
$spectatorIndex = 0;

// the ID handle of the current person we are spectating.
$spectatorPerson = -1;

// your own camera object
$MP::Camera = -1;

// time inbetween lerps
$cameraLerpTime = 200;
$cameraLocalLerpTime = 75;

//-----------------------------------------------------------------------------
// client commands
//-----------------------------------------------------------------------------

// this lets us know that we can now start spectating
function clientCmdGoSpectateNow() {
	// start spectate mode
	$SpectateMode = true;
	setSpectateFlying(true);

	HUD_ShowPowerUp.setVisible(false);
	HUD_PowerupBackground.setVisible(false);
	PG_TopLeftCounterContainer.setVisible(false);

	PG_SpectatorMenu.setVisible(!$pref::minimalSpectateUI);

	PlayGui.updateBlastBar();
	commandToServer('GoSpectateAck');
}

// when we finish spectating
function clientCmdFinishSpectating() {
	$SpectateMode = false;
	HUD_ShowPowerUp.setVisible(true);
	HUD_PowerupBackground.setVisible(true);
	PG_TopLeftCounterContainer.setVisible(true);
	PG_SpectatorMenu.setVisible(false);

	PlayGui.updateBlastBar();
}

// if too many players are spectators, inform the client that there are
// to many and they have to play.  SORRY BUT THAT IS JUST HOW IT IS PLEBIANS.
function clientCmdNoSpectate() {
	MessageBoxOK("Sorry", "You may not spectate as there are already too many people who are spectating.");
	MPPreGameSpectate.setValue(false);
	MPPreGameSpectate.setActive(false);
}

function clientCmdSpectateFull(%full) {
	//echo("Spectate is full:" SPC %full);
	$MP::SpectateFull = %full;
	MPPreGameSpectate.setActive(!%full);
}

function clientCmdSpectateChoice() {
	MessageBoxYesNo("Join Game in Progress?", "Do you want to join the current game in progress?", "commandToServer(\'Spectate\', false);", "");
}

function clientCmdSpectatePowerUp(%index, %name, %powerup) {
	devecho("Spectate Powerup" SPC %index @ "/" @ %name SPC "is" SPC %powerup);
	$MP::ClientPowerUp[%index] = %powerup;
	if ($spectatorIndex == %index && !$SpectateFlying)
		PlayGui.setPowerUp(%powerup);
}

//-----------------------------------------------------------------------------
// functions specific to spectate mode
//-----------------------------------------------------------------------------

// false means chase
//       true means flying
$SpectateFlying = false;

// toggles spectating between flying and orbiting
function toggleSpectateMode() {
	setSpectateFlying(!$SpectateFlying);
}

function setSpectateFlying(%flying) {
	if (!$SpectateMode) {
		return;
	}

	$SpectateFlying = %flying;

	if (%flying) {
		Physics::popLayerName("spectateFollow");
		HUD_ShowPowerUp.setVisible(false);
		HUD_PowerupBackground.setVisible(false);
	} else {
		Physics::pushLayerName("spectateFollow");
		HUD_ShowPowerUp.setVisible(true); // See their powerup
		HUD_PowerupBackground.setVisible(true);
	}

	// display the spectator menu to the clients via the PlayGui
	showSpectatorMenu(true);

	if (%flying) {
		// stop lerping, we are flying.
		PlayGui.setPowerUp("");
		cancel($SpectateCameraLerp);
		$spectatorPerson = -1;
	} else {
		// if we are not flying, we need to pick a client.
		pickNextSpectator();
	}
}

// choses the next plebian to watch
function pickNextSpectator() {
	if (!isObject(getCamera()))
		return;

	// flush out bad plebians, we want a real plebian not a fake one
	// that doesn't exist...
	//
	// This is how you do a do-while in MB, you just set the condition to false
	// for the first time.

	$spectatorPerson = -1;
	%wrapped = false;
	while (!isObject($spectatorPerson)) {
		$spectatorIndex ++;

		// if we gone to high, we need to bring it back to 0
		if ($spectatorIndex > PlayerList.getSize()) {
			$spectatorIndex = 0;
			if (%wrapped) {
				// We're never going to find one
				break;
			}
			%wrapped = true;
		}

		// post RC1:
		// this was under the continue, and doesn't make sense as to why.
		// it is causing an infinite loop....
		$spectatorPerson = PlayerList.getEntry($spectatorIndex).player;
	}

	onPickSpectator();
}

function pickPrevSpectator() {
	if (!isObject(getCamera()))
		return;

	// flush out bad plebians, we want a real plebian not a fake one
	// that doesn't exist...
	//
	// This is how you do a do-while in MB, you just set the condition to false
	// for the first time.

	$spectatorPerson = -1;
	%wrapped = false;

	%highest = PlayerList.getSize() - 1;
	while (!isObject($spectatorPerson)) {
		$spectatorIndex --;

		// if we gone to low, bring it to max - 1
		if ($spectatorIndex < 0) {
			$spectatorIndex = %highest;
			if (%wrapped) {
				// We're never going to find one
				break;
			}
			%wrapped = true;
		}

		$spectatorPerson = PlayerList.getEntry($spectatorIndex).player;
		if (!isObject($spectatorPerson))
			continue;
	}

	onPickSpectator();
}

function onPickSpectator() {
	if (!isObject($spectatorPerson)) {
		// Nobody to spectate, free cam instead
//      devecho("No spectators.  We don\'t want an infinate loop!  Stop searching.");
		setSpectateFlying(true);
		return;
	}
//   devecho("Chose Spectator Index:" SPC $spectatorIndex);
	$MP::Camera.setTransform($spectatorPerson.getWorldBoxCenter() SPC "1 0 0 0");
	updateCameraLerp();
	PlayGui.setPowerUp($MP::ClientPowerUp[$spectatorIndex]);
}

// gets the camera object
// Note: only *YOUR* camera is scoped to you, so you only have 1 Camera
// in server connection at a time =)
function getCamera() {
	if (!isObject(ServerConnection))
		return;
	//New camera?
	if (isObject(ServerConnection.getControlObject()) && ServerConnection.getControlObject().getClassName() $= "Camera")
		$MP::Camera = ServerConnection.getControlObject();
	if (isObject($MP::Camera))
		return $MP::Camera;
	%count = ServerConnection.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);
		if (%obj.getClassName() $= "Camera") {
			$MP::Camera = %obj;
			return %obj;
		}
	}
	$MP::Camera = -1;
	return -1;
}

//-----------------------------------------------------------------------------

function Camera::setNextLerp(%this, %point, %rot, %time) {
	// Set delta = 0 (immediate)
	%this.lerpDelta = 0;

	// Time is time until we reach that point
	%this.lerpTime = %time;

	// Start pos is using LerpLast (camera orbit point), or getPosition
	// if needed.
	%this.lerpStart = (%this.lerpLast $= "" ? %this.getPosition() : %this.lerpLast);

	// End is where we want to end up
	%this.lerpEnd = %point;

	if (%rot !$= "") {
		// Start is last rot
		%this.lerpRotStart = (%this.lerpRotLast $= "" ? getWords(%this.getTransform(), 3, 6) : %this.lerpRotLast);

		// End is where we want to end up
		%this.lerpRotEnd = %rot;
	}
}

function Camera::setNextSpline(%this, %point, %next, %rot, %time) {
	// Set delta = 0 (immediate)
	%this.lerpDelta = 0;

	// Old time for relative splining
	%this.lerpTimeOld = (%this.lerpTime $= "" ? %time : %this.lerpTime);

	// Time is time until we reach that point
	%this.lerpTime = %time;

	// Old/previous start is the last start position
	%this.lerpStartOld = (%this.lerpStart $= "" ? %this.getPosition() : %this.lerpStart);

	// Start pos is using LerpLast (camera orbit point), or getPosition
	// if needed.
	%this.lerpStart    = (%this.lerpLast $= "" ? %this.getPosition() : %this.lerpLast);

	// End is where we want to end up
	%this.lerpEnd = %point;

	// Next is the point after end
	%this.lerpNext = %next;

	if (%rot !$= "") {
		// Start is last rot
		%this.lerpRotStart = (%this.lerpRotLast $= "" ? getWords(%this.getTransform(), 3, 6) : %this.lerpRotLast);

		// End is where we want to end up
		%this.lerpRotEnd = %rot;
	}

	%this.lerpSpline = true;
}

function Camera::followPath(%this, %path, %spline) {
	// %path is a TAB-separated list of "x y z r1 r2 r3 r4 t"
	%time  = 0;
	%count = getFieldCount(%path);
	for (%i = 0; %i < %count; %i ++) {
		// Iterate through each node
		%node = getField(%path, %i);
		%pos = getWords(%node, 0, 2);
		%rot = getWords(%node, 3, 6);
		%t   = getWord(%node, 7);

		if (%spline) {
			%next = getWords(%node, 8, 10);

			// Basic scheduling
			%this.schedule(%time, "setNextSpline", %pos, %next, %rot, %t);
		} else {
			// Basic scheduling
			%this.schedule(%time, "setNextLerp", %pos, %rot, %t);
		}
		%time += %t;
	}
}

function updateCameraLerp() {
	cancel($SpectateCameraLerp);
	if (!isObject(getCamera()) || !isObject($spectatorPerson))
		return;
	%delta = $cameraLerpTime;
	%next = $spectatorPerson.getWorldBoxCenter();
	if (strpos(%next, "nan") == -1)
		$MP::Camera.setNextLerp(%next, "", %delta);
	$SpectateCameraLerp = schedule(%delta, 0, updateCameraLerp);
}

// updates your camera position and rotation to smoothly interpolate it
function interpolateCamera(%delta) {
	if (!isObject(getCamera()))
		return;

	// WE ARE IN CONTROL IF NOT ATTACHED.
	if ($SpectateFlying)
		return;

	// Set up the position variables
	%position  = $MP::Camera.lerpStart;
	if (%position $= "") {
		if (!isObject($spectatorPerson))
			return;

		$MP::Camera.setNextLerp($spectatorPerson.getWorldBoxCenter(), 1);
		%position  = $MP::Camera.lerpStart;
	}

	%endPos = $MP::Camera.lerpEnd;

	// Progress is time / total
	%progress = $MP::Camera.lerpDelta / $MP::Camera.lerpTime;
	if ($MP::Camera.lerpTime < 10)
		%progress = 1;

	// Don't over-shoot it
	if (%progress > 1)
		%progress = 1;

	// Optional ease in/out for smoothness
	if ($MP::Camera.lerpEase)
		%progress = ease(0, 1, 1, %progress);

	// Delta is time since last lerp point update
	$MP::Camera.lerpDelta += %delta;

	if ($MP::Camera.lerpSpline && $MP::Camera.lerpRotEnd !$= "") {
		// Matrices for camera position splining
		%prev = $MP::Camera.lerpStartOld;
		%next = $MP::Camera.lerpNext;

		%dist1 = (VectorDist(%position, %prev) / 3) * ($MP::Camera.lerpTime / $MP::Camera.lerpTimeOld);
		%dist2 = VectorDist(%endPos, %position) / 3;

		%sub1 = VectorNormalize(VectorSub(%endPos, %position));
		%sub2 = VectorNormalize(VectorSub(%next, %endPos));

		// Extra spline control points for the bezier
		%a = VectorAdd(%position, VectorScale(%sub1, %dist1));
		%b = VectorSub(%endPos, VectorScale(%sub2, %dist2));

		%interPos = VectorBezier(%progress, %position TAB %a TAB %b TAB %endPos);
	} else {
		// interpolate position
		%interPos = vectorLerp(%position, %endPos, %progress);
		//%interPos = %position;
	}

	$MP::Camera.lerpLast = %interPos;

	if ($MP::Camera.lerpRotEnd !$= "") {
		%rotation = RotBezier(%progress, $MP::Camera.lerpRotStart TAB $MP::Camera.lerpRotEnd);
//		%rotation = RotPoint(%rotation, VectorBezierDeriv(%progress, %position, %a, %b, %endPos), "1 0 0");

		%this.lerpRotLast = %rotation;
//		addHelpLine(%rotation);
		%rotation = "0 0 0" SPC %rotation;
	} else {
		// I can't find an exact substitute for marble yaw movement. Anyone
		// know a better way to do this?
		%horizScale = mCos($cameraPitch) * 2.5;

		// make the camera "orbit" around the marble
		%ortho = -mSin($cameraYaw) * %horizScale SPC -mCos($cameraYaw) * %horizScale SPC(mSin($cameraPitch) * 2.5) + 0.25;
		%startPos = %interPos;
		%interPos = VectorAdd(%interPos, %ortho);

		// Check for collision
		%cast = clientContainerRayCast(%startPos, %interPos, $TypeMasks::InteriorObjectType);
		if (%cast) {
			//Set position to the wall
			%interpos = getWords(%cast, 1, 3);

			//Add 0.1 units so walls don't clip quite so bad
			%interpos = VectorAdd(%interpos, VectorScale(VectorNormalize(VectorSub(%endPos, %interpos)), 0.1));
		}

		// Cool matrixy stuff for pitch and yaw rotation
		%vec1 = "0 0 0 0 0 1" SPC $cameraYaw;
		%vec2 = "0 0 0 1 0 0" SPC $cameraPitch;

		// Multiply yaw * pitch for the complete rotation
		%rotation = MatrixMultiply(%vec1, %vec2);
	}

	// Multiply pos * rotation for the final value
	%transform = MatrixMultiply(%interPos SPC "0 0 0 0", %rotation);

	$MP::Camera.setTransform(%transform);
}

// this toggles the spectator menu on the playGui
function showSpectatorMenu(%show) {
	if (!ClientMode::callback("showSpectatorMenu", true, new ScriptObject() {
		show = %show;
		_delete = true;
	})) {
		return;
	}
	if (%show) {
		%text = "<bold:28><just:center>Spectator Info<font:14>\n" NL
		        "<bold:22><just:left>Toggle Fly / Orbit:<just:right><func:bind toggleSpectateModeType>" NL
		        "<just:left>Exit Spectate Mode:<just:right><func:bind toggleCamera>";

		// orbit mode we show more options.
		if (!$SpectateFlying) {
			%text = %text @
			        "<just:left>Prev Player:<just:right><func:bind moveLeft>" NL
			        "<just:left>Next Player:<just:right><func:bind moveRight>";
		}
		PG_SpectatorText.setText(%text);
	}
	PG_SpectatorMenu.setVisible(%show);
}

//-----------------------------------------------------------------------------

function clientCmdStartOverview(%heightOffset, %width) {
	Physics::pushLayerName("overview");

	// Make sure client MO's are activated.
	clientCmdActivateMovingObjects(true);
}

function clientCmdFinishOverview(%lerptime, %aimPos, %finalPos, %pitch) {
	$MP::OverviewFinish = true;
}

function clientCmdStopOverview() {
	Physics::popLayerName("overview");
	$MP::OverviewFinish = false;
}

//-----------------------------------------------------------------------------
// Support functions
//-----------------------------------------------------------------------------

function clientCmdDropCameraAtPlayer(%client) {
	if (!MPMyMarbleExists())
		return;
	getCamera().setTransform(MPGetMyMarble().getCameraTransform());
}
