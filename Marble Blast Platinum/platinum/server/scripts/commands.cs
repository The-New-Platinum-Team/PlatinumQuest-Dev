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
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Misc. server commands available to clients
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

/**
 * @param {GameConnection} %client
 */
function serverCmdToggleCamera(%client) {
	// we want spectating now.
	if ($Editor::Opened || $Server::ServerType $= "SinglePlayer" || %client.spectating || $playingDemo) {
		// Moved to camera.cs
		%client.toggleCamera();
	}
}

/**
 * @param {GameConnection} %client
 */
function serverCmdDropPlayerAtCamera(%client) {
	if ($Editor::Opened) {
		%client.player.setTransform(%client.camera.getTransform());
		%client.player.setVelocity("0 0 0");
		%client.player.setAngularVelocity("0 0 0");
		%client.setControlObject(%client.player);
	}
}

/**
 * @param {GameConnection} %client
 */
function serverCmdDropCameraAtPlayer(%client) {
	if ($Editor::Opened) {
		%client.camera.setTransform(%client.player.getEstCameraTransform());
		%client.camera.setVelocity("0 0 0");
		%client.setControlObject(%client.camera);
		commandToClient(%client, 'DropCameraAtPlayer');
	}
}

/**
 * @param {GameConnection} %client
 * @param {int} %index
 */
function serverCmdPlaytestPoint(%client, %index) {
	if (lb() || mp() || !isObject(%client.player) || !isObject(MissionGroup) || !$Editor::Opened)
		return;

	%count = MissionGroup.getCount();
	for (%i = 0; %i < %count; %i++) {
		%obj = MissionGroup.getObject(%i);
		if (%obj.getClassName() $= "ScriptObject" && %obj.class $= "PlaytestPoint" && mFloor(%obj.index) == %index) {
			%pos = %obj.position !$= "" ? %obj.position : "0 0 0";
			%rot = %obj.rotation !$= "" ? %obj.rotation : "1 0 0 0";
			%rotRad = getWords(%rot, 0, 2) SPC mDegToRad(getWord(%rot, 3));
			%gravity = RotMultiply(%rotRad, "1 0 0 3.1415926");
			%ortho = VectorRemoveNotation(VectorOrthoBasis(%gravity));

			if ($Game::State $= "Start" || $Game::State $= "Ready" || $Game::State $= "Set")
				setGameState("Go");

			%client.setGravityDir(%ortho, true, %gravity);
			%client.player.setTransform(%pos SPC "1 0 0 0");
			%client.player.setCameraYaw(0);
			%client.player.setCameraPitch(MissionInfo.cameraPitch $= "" ? 0.45 : MissionInfo.cameraPitch);
			%client.player.setVelocity("0 0 0");
			%client.player.setAngularVelocity("0 0 0");
			%client.setControlObject(%client.player);
			%client.playPitchedSound("spawn");

			%client.addBubbleLine("Playtest Point #" @ %index, false, 2000);
			return;
		}
	}
}


