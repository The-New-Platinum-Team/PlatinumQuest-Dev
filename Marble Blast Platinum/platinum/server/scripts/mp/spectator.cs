//-----------------------------------------------------------------------------
// serverSpectator.cs
//
// allows you to spectate through people's cameras!
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

function serverCmdSetSpectate(%client, %spectate) {
	// FOR Force Spectate:
	// we allow to switch only if they are going INTO spectate,
	// if they have 0 points, and force spectator.
	// This is because what happens if the client accidently forgets
	// to press spectate.  We give them a grace period sort of :)
	if ((%client.forceSpectate) && (%client.gemCount || %client.spectating))
		return;

	// do not give clients a head start
	if (%client.state !$= "play" && %client.state !$= "go" && %client.spectating && !$Game::Pregame)
		return;

	if (!Mode::callback("shouldSetSpectate", true, new ScriptObject() {
	client = %client;
	_delete = true;
}))
	return;

	%client.spectating = %spectate;

	$Server::SpectateCount = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		if (ClientGroup.getObject(%i).spectating)
			$Server::SpectateCount ++;
	}

	//Maximum number of people who can spectate
	%max = Mode::callback("getMaxSpectators", getRealPlayerCount() - 1);

	// one person must play!!
	// post RC1: need to be for both spectating and not spectating
	// was causing a glitch to happen where sometimes people could not
	// be able to toggle spectate mode in pregame menu.

	//If we weren't supposed to be spectating, unset us
	if ($Server::SpectateCount > %max && %spectate) {
		commandToClient(%client, 'NoSpectate');
		commandToClient(%client, 'SpectateFull', true);
		%client.spectating = false;
		$Server::SpectateCount --;
		return;
	}

	updateSpectateFull();
	refreshPlayerList();
}

function updateSpectateFull() {
	//Maximum number of people who can spectate
	%max = Mode::callback("getMaxSpectators", getRealPlayerCount() - 1);

	devecho("Max Spectators:" SPC %max SPC "current:" SPC $Server::SpectateCount);

	//If we were the last player to spectate, the list is full
	if ($Server::SpectateCount >= %max) {
		//Tell everyone else that spectate is full
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%cl = ClientGroup.getObject(%i);

			//If we're spectating already, still let us unspectate
			commandToClient(%cl, 'SpectateFull', !%cl.spectating);
		}

		devecho("Spectate is full");
	} else {
		//Not full, everyone can know
		commandToAll('SpectateFull', false);
		devecho("Spectate is not full");
	}
}

function serverCmdSpectate(%client, %spectating) {
	if (%spectating $= "")
		%spectating = !%client.spectating;
	if (%spectating == %client.spectating) //No difference
		return;
	serverCmdSetSpectate(%client, %spectating);
	if (%client.spectating == %spectating)
		%client.setSpectating(%spectating);
}

function GameConnection::setSpectating(%this, %spectating) {
	%this.spectating = %spectating;

	if (%spectating) {
		// a bit hackish but should work.
		if (isObject(%this.camera))
			%this.toggleCamera();

		// give the clients time to have the objects deleted.
		schedule(50, 0, finishSpectate, %this);
	} else {
		%this.spawnPlayer();
		%this.startGame();
		if ($Game::State $= "start") { // Skip Ready/Set/Go, unless the host is still going through Ready/Set/Go. Also, the 'startGame' above doesn't modify this variable.
			%this.player.setMode(Start);
			%this.setGameState(Ready);
		}

		// make keys enabled again for controlling the client!
		commandToClient(%this, 'FinishSpectating');

		// we got rid of a spectator.  Update the ghosts already!
		schedule(500, 0, commandToAll, 'FixGhost');
	}

	updatePlayerlist();
}

// finishes the spectate, forces all clients to update
function finishSpectate(%client) {
	// tell clients that they need to update there ghost lists! We have
	// a spectator
	commandToAll('FixGhost');

	// let the client know that they can spectate now
	commandToClient(%client, 'GoSpectateNow');
}

function serverCmdGoSpectateAck(%client) {
	//They're spectating now, delete their player
	%client.deletePlayer();
}

function GameConnection::startOverview(%this) {
	%this.overview = true;
	%this.spectating = false;

	if (!isObject(%this.camera)) {
		// Overview isn't much good without a camera!
		%this.camera = new Camera() {
			dataBlock = Observer;
		};
		MissionCleanup.add(%this.camera);
		%this.camera.scopeToClient(%this);
	}

	// Let them use their new camera
	%this.setToggleCamera(true);

	%this.deletePlayer();

	commandToClient(%this, 'clearCenterPrint');
	commandToClient(%this, 'StartOverview', MissionInfo.overviewHeight, MissionInfo.overviewWidth);
	%this.camera.setTransform(CameraPath1.getTransform());
	%this.camera.schedule(1000, moveOnPath, CameraPath1);
	activateMovingObjects(true);
}

function GameConnection::stopOverview(%this) {
	%this.overview = false;
	%this.spectating = false;

	if ($MPPref::OverviewFinishSpeed == 0) {
		%this.restarting = true;
		%pos = %this.getCheckpointPos(0);
		%this.spawnPlayer(%pos);
		echo("Overview stopping to pos:" SPC %pos);
		%this.player.setMode(Start);
		%this.finishOverview(%pos);
		%this.restarting = false;
		return;
	}

	%this.restarting = true;
	%pos = %this.getCheckpointPos(0);
	echo("Overview stopping to pos:" SPC %pos);
	%this.spawnPlayer(%pos);
	%this.respawnPlayer(%pos);
	%this.player.setMode(Start);
	%this.setToggleCamera(true);
	%this.schedule($MPPref::OverviewFinishSpeed * 1000, finishOverview, %pos);
	%this.restarting = false;

	%aimPos = getWords(getField(%pos, 0), 0, 2);
	%finalRot = getWord(getField(%pos, 0), 6);
	%finalPos = VectorSub(%aimPos, mSin(%finalRot) SPC mCos(%finalRot) SPC 0);
//   testahedron(%finalpos, true);

	// Finished overviewing, let them have control
	commandToClient(%this, 'FinishOverview', $MPPref::OverviewFinishSpeed * 1000, %aimPos, %finalPos, getField(%pos, 2));
}

function GameConnection::finishOverview(%this, %pos) {
	commandToClient(%this, 'StopOverview');
	%this.spawnPoint = %pos;

	// Respawn the player, otherwise we won't be able to ghost anything!
	%this.respawnPlayer(%pos);
	%this.setToggleCamera(false);
	commandToAll('FixGhost');
}

function GameConnection::cancelOverview(%this, %pos) {
	%this.overview = false;
	%this.restarting = false;

	commandToClient(%this, 'StopOverview');
	commandToAll('FixGhost');
}

//-----------------------------------------------------------------------------

function generateDefaultCameraPath() {
	//Generate a path for the camera

	//World box
	%box = MissionGroup.getWorldBox();
	%box = BoxExtend(%box, 10);

	//Generate path nodes around the outside
	%nodes = 16;
	for (%i = 0; %i < %nodes; %i ++) {
		//Nodes are linked-lists; loop in a circle
		%name = "CameraPath" @ (%i + 1);
		%next = "CameraPath" @ (%i == (%nodes - 1) ? 1 : (%i + 2));

		%angle = ($tau / %nodes) * %i;

		//Simple orbit around the outside of the box; 7/8 of the way up
		%position = (BoxCenterX(%box) + (mCos(%angle) * BoxSizeX(%box))) SPC
		            (BoxCenterY(%box) + (mSin(%angle) * BoxSizeY(%box))) SPC
		            (BoxCenterZ(%box) + (BoxSizeZ(%box) * 3 / 8));

		//Create a pathnode at the position
		MissionCleanup.add(new StaticShape(%name) {
			position = %position;
			rotation = "1 0 0 0";
			dataBlock = "PathNode";
			UsePosition = "1";
			TimeToNext = "4000";
			NextNode = %next;
			UseRotation = "1";
		});

		//Look at the center
		%pitch = mAtan((BoxSizeZ(%box) * 3 / 8), VectorLen(BoxSizeX(%box) SPC BoxSizeY(%box) SPC 0));

		//Rotation of the path node
		%yaw   = "0 0 0 0 0 1" SPC -(%angle + ($pi / 2));
		%pitch = "0 0 0 1 0 0" SPC %pitch;
		%name.setTransform(MatrixMultiply(%name.getTransform(), MatrixMultiply(%yaw, %pitch)));
	}
}

