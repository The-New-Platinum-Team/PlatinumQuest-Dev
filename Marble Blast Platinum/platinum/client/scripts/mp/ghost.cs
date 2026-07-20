//------------------------------------------------------------------------------
// Multiplayer Package
// clientGhost.cs
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

/// Gets the client sided controllable marble.
/// @return the marble object that is inside of ServerConnection
function MPgetMyMarble() {
	if (isObject(ServerConnection) && isObject(ServerConnection.getControlObject())) {
		if (ServerConnection.getControlObject().getClassName() $= "Marble")
			ServerConnection.marble = ServerConnection.getControlObject();
		if (ServerConnection.marble $= "")
			ServerConnection.marble = -1;
		if (!isObject(ServerConnection.marble))
			ServerConnection.marble = -1;
		$MP::MyMarble = ServerConnection.marble;
	} else
		$MP::MyMarble = -1;
	ServerConnection.player = $MP::MyMarble;
	return $MP::MyMarble;
}

/// Check to see if *your* client sided marble is stored in memory as an object
/// @return true if *your* marble does exist.
function MPMyMarbleExists() {
	cancel($MP::Schedule::MyMarbleExists);
	if (isObject($MP::MyMarble))
		return true;
	else if (MPgetMyMarble() != -1)
		return true;
	$MP::Schedule::MyMarbleExists = schedule(100, 0, "MPMyMarbleExists");
	return false;
}

/// Cancels all of the async multiplayer schedules that run during multiplayer
/// gameplay.
function MPCancelClientSchedules() {
	cancel($MP::Schedule::FixGhost);
	cancel($MP::Schedule::ItemCollision);
	cancel($MP::Schedule::EmitterPosition);
}

/// Updates the player list with each player's respective client-side marble.
function updateMarbleIds() {
	for (%i = 0; %i < PlayerList.getSize(); %i ++) {
		%entry = PlayerList.getEntry(%i);
		//Some players may not exist
		if (!isObject(%entry))
			continue;

		//Player's marble ID
		%id = %entry.marbleId;

		//See if they have a marble
		%marble = getClientSyncObject(%id);
		if (isObject(%marble)) {
			//Found it: now set it.
			%entry.player = %marble;
			%marble.index = %i;
		}
	}
}

/// Fixes ghosting by periodically running in the background async.
function fixGhost() {
	// Check for ServerConnection!
	if (!isObject(ServerConnection))
		return;

	// Fix the timer!
	cancel($MP::Schedule::FixGhost);

	// Get my marble!
	MPgetMyMarble();

	// item collision!
	buildItemList();

	// Update the marble ids
	updateMarbleIds();

	// Find which dbs are marbles
	findMarbleDatablocks();

	// Restart the timer!
	$MP::Schedule::FixGhost = schedule($MP::ClientFixTime, 0, fixGhost);

	// Breathe a sigh of relief, and feel a weight lifted off your
	// shoulders, for the ghosts have been fixed. You will not have to see
	// their derpy faces around here, but instead bask in the bliss from only
	// seeing the things you were meant to see. No more ghosts following you,
	// nobody sitting lifeless on the start pad. Nobody standing still in
	// various places, and never self-collide again. Ahh. That is bliss.
	//
	// man is this function slow :D

	//Update in 2015: Fuck this method.
}

/// Freezes or thaws the marble object.
/// @arg frozen Sets whether the marble is frozen or thawed
/**
 * @param {Marble} %this
 */
function Marble::freeze(%this, %frozen, %mode) {
	if (%mode $= "")
		%mode = true;

	// POWERUP LOCKING BITCHES
	clientCmdLockPowerup(%frozen);

	if (%frozen) {
		$Client::Frozen = true;
		%this.setVelocity("0 0 0");
		%this.setAngularVelocity("0 0 0");
		Physics::pushLayerName("frozen");
	} else {
		$Client::Frozen = false;
		Physics::popLayerName("frozen");
	}
}