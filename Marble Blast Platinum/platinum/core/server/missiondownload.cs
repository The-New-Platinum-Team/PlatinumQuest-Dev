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
// Mission Loading
// The server portion of the client/server mission loading process
//-----------------------------------------------------------------------------

//--------------------------------------------------------------------------
// Loading Phases:
// Phase 1: Transmit Datablocks
//          Transmit targets
// Phase 2: Transmit Ghost Objects
// Phase 3: Transmit Sync Objects
//
// The server invokes the client MissionStartPhase[1-3] function to request
// permission to start each phase.  When a client is ready for a phase,
// it responds with MissionStartPhase[1-3]Ack.

function GameConnection::loadMission(%this) {
	// Send over the information that will display the server info
	// when we learn it got there, we'll send the data blocks
	%this.currentPhase = 0;
	if (%this.isAIControlled()) {
		// Cut to the chase...
		%this.onClientEnterGame();
	} else {
		// Send mission information to the client
		sendLoadInfoToClient(%client);

		%this.loading = true;
		echo("*** Sending mission load to client: " @ $Server::MissionFile);

		// Check for Marbleland mission status if necessary
		if (marblelandIsMission($Server::MissionFile)) {
			%this.marblelandHasMission(marblelandGetFileId($Server::MissionFile), "onMarblelandHasMission");
		} else {
			%this.onMarblelandDownloadComplete(true);
		}
	}
}

function GameConnection::onMarblelandHasMission(%this, %id, %success) {
	if (%id !$= marblelandGetFileId($Server::MissionFile))
		return;
	if (%success) {
		%this.onMarblelandDownloadComplete(true);
		return;
	}

	%this.marblelandDownload(%id, onMarblelandDownloadComplete, %success);
}

function GameConnection::onMarblelandDownloadComplete(%this, %success) {
	if (!%success) {
		%this.delete("Could not download mission " @ $Server::MissionFile);
		return;
	}

	commandToClient(%this, 'ShowLoadScreen');
	commandToClient(%this, 'MissionStartPhase1', $missionSequence,
	                $Server::MissionFile, MissionGroup.musicTrack);
}

function serverCmdMissionStartPhase1Ack(%client, %seq) {
	// Make sure to ignore calls from a previous mission load
	if (%seq != $missionSequence || !$MissionRunning)
		return;
	if (%client.currentPhase != 0)
		return;
	%client.currentPhase = 1;

	// Start with the CRC
	%client.setMissionCRC($missionCRC);

	// Send over the datablocks...
	// OnDataBlocksDone will get called when have confirmation
	// that they've all been received.
	%client.transmitDataBlocks($missionSequence);
}

function GameConnection::onDataBlocksDone(%this, %missionSequence) {
	// Make sure to ignore calls from a previous mission load
	if (%missionSequence != $missionSequence)
		return;
	if (%this.currentPhase != 1)
		return;
	%this.currentPhase = 1.5;

	// Send names now, after all datablocks have been sent
	// everyone but the local client gets them. If dedicated,
	// everyone gets them.
	if (!%this.isHost() || $Server::Dedicated)
		MPSendDataBlockNames(%this);

	// On to the next phase
	commandToClient(%this, 'MissionStartPhase2', $missionSequence, $Server::MissionFile);
}

function serverCmdMissionStartPhase2Ack(%client, %seq) {
	// Make sure to ignore calls from a previous mission load
	if (%seq != $missionSequence || !$MissionRunning)
		return;
	if (%client.currentPhase != 1.5)
		return;
	%client.currentPhase = 2;

	// Update mod paths, this needs to get there before the objects.
	%client.transmitPaths();

	// Start ghosting objects to the client
	%client.activateGhosting();

}

function GameConnection::clientWantsGhostAlwaysRetry(%client) {
	if ($MissionRunning)
		%client.activateGhosting();
}

function GameConnection::onGhostAlwaysFailed(%client) {
	// ???
}

function GameConnection::onGhostAlwaysObjectsReceived(%client) {
	// Ready for next phase.
	commandToClient(%client, 'MissionStartPhase3', $missionSequence, $Server::MissionFile);
}

function serverCmdMissionStartPhase3Ack(%client, %seq) {
	// Make sure to ignore calls from a previous mission load
	if (%seq != $missionSequence || !$MissionRunning)
		return;
	if (%client.currentPhase != 2)
		return;
	%client.currentPhase = 3;

	%client.sendSyncObjects();
}

function serverCmdAllSyncObjectsComplete(%client, %seq) {
	// Make sure to ignore calls from a previous mission load
	if (%seq != $missionSequence || !$MissionRunning)
		return;
	if (%client.currentPhase != 3)
		return;
	%client.currentPhase = 4;

	// Server is ready to drop into the game
	%client.loading = false;

	if (mp()) {
		%client.onFinishLoading();
	} else {
		%client.startMission();
		%client.onClientEnterGame();
	}
}
