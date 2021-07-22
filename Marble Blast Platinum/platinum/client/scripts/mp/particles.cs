//------------------------------------------------------------------------------
// Multiplayer Package
// clientParticles.cs
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

// this global simset is used for client emitters that need updates.
// much faster than reorganizing a list of global array variables!
if (!isObject(ClientEmitterSet)) {
	new SimSet(ClientEmitterSet);
	RootGroup.add(ClientEmitterSet);
}
if (!isObject(ClientMarbleEmitterSet)) {
	new SimSet(ClientMarbleEmitterSet);
	RootGroup.add(ClientMarbleEmitterSet);
}
if (!isObject(ClientMovingEmitterSet)) {
	new SimSet(ClientMovingEmitterSet);
	RootGroup.add(ClientMovingEmitterSet);
}

function onUnpackTrailEmitter(%emitter, %n) {
	if (!isObject(ServerConnection))
		return;

	if ($Server::Lobby)
		return;

	//Sometimes these are deleted
	if (!isObject(%emitter))
		return;

	cancel($emitterFind[%emitter]);
	if (%emitter.follow == -1) {
		//Try to find the follow
		%follow = getClientSyncObject(%emitter.attachId);
		if (%follow == -1) {
			//error("Can't find follow object (id " @ %emitter.attachId @ ") for sync ID " @ %emitter @ "!");

			if (%n > 0 && %n % 3 == 0) {
				//warn("Requesting a force update from the server...");

				//Hey seriously, send the damn object
				commandToServer('SyncObjectUpdate', %emitter.attachId);
			}

			//Try again
			$emitterFind[%emitter] = schedule(250, 0, onUnpackTrailEmitter, %emitter, %n + 1);
			return;
		}

		%emitter.follow = %follow;
		if (%n > 0) {
			//echo("Emitter " @ %emitter @ " found follow object " @ %emitter.follow @ " after (only) " @ (%n + 0) @ " tries!");
		}
	}

	if (isMarbleEmitterTime(%emitter.getDatablock().timeMultiple)) {
		ClientMarbleEmitterSet.add(%emitter);
	} else {
		ClientEmitterSet.add(%emitter);
		if (ClientMovingObjects.containsEntry(%emitter.follow.getSyncId()) ||
		    ClientParentedObjects.containsEntry(%emitter.follow.getSyncId()) ||
		    %emitter.follow.getClassName() $= "Marble") {
			ClientMovingEmitterSet.add(%emitter);
		}
	}
}

// determines if we are a emitter that we need to check for
function isMarbleEmitterTime(%time) {
	//I hate floating point arithmetic. 1.003 != 1.003 or some dumb shit
	return mAbs(%time - 1.003) < 0.0005;
}

// this function updates the emitter positions client sided
function updateEmitterPositions() {
	if ($Server::ServerType $= "" || !isObject(ServerConnection) || $pref::FastMode)
		return;

	%count = ClientMovingEmitterSet.getCount();
	%removeAmount = 0;
	for (%i = 0; %i < %count; %i ++) {
		%obj = ClientMovingEmitterSet.getObject(%i);

		// the ghost object got deleted, so we need to remove this from
		// the set.
		if (!isObject(%obj.follow)) {
			%remove[%removeAmount] = %obj;
			%removeAmount ++;
			devecho("Remove emitter:" SPC %obj SPC "follow = " @ %obj.follow);
			continue;
		}

		%rot = getWords(%obj.getTransform(), 3, 6);
		%obj.setTransform(%obj.follow.getPosition() SPC %rot);
	}

	// clean up old emitters
	for (%i = 0; %i < %removeAmount; %i ++)
		ClientMovingEmitterSet.remove(%remove[%i]);

	// trail emitters
	updateTrailEmitters();
}

// this function updates the trail emitters to the correct positions
// based upon velocities.
function updateTrailEmitters() {
	if ($Server::ServerType $= "" || !isObject(ServerConnection) || $pref::FastMode)
		return;

	%count = ClientMarbleEmitterSet.getCount();
	%removeAmount = 0;
	for (%i = 0; %i < %count; %i ++) {
		%obj = ClientMarbleEmitterSet.getObject(%i);
		%follow = %obj.follow;

		// if the marble got deleted, we need to remove it form the set
		if (!isObject(%follow)) {
			%remove[%removeAmount] = %obj;
			%removeAmount ++;
			continue;
		}
		%marble = %follow.getClassName() $= "Marble";

		// the new position to display the client particle.
		%position = %follow.getPosition();

		// determine visibility
		// if we have a high enough velocity, display it, else hide it.
		%speed = VectorLen(%follow.getVelocity());

		//Mega marble is ~2x greater than default collision radius
		%mega = (%marble && %follow.getCollisionRadius() > (%follow.getDatablock().getCollisionRadius() * 2));

		//Trail particle criteria:
		//Not in water:
		//Show gold trail if vel > $TrailEmitterSpeed
		//Show white trail if vel > $TrailEmitterWhiteSpeed
		//Show fireball emitter if you have a fireball!

		//In water, and speed > 1:
		//Show splash if not follow.bubbleEmitter
		//Show bubble if follow.bubbleEmitter

		%water = %follow.isInWater;
		if (%water) {
			%show["Splash4"] = (%speed > 1 && !%follow.bubbleEmitter);
			%show["TrailBubble"] = (%speed > 1 && %follow.bubbleEmitter);
			%show["Trail"] = false;
			%show["WhiteTrail"] = false;
			%show["Fireball3"] = false;
			%show["Fireball4_2"] = false;
		} else {
			if (%follow.fireball) {
				%show["Fireball3"] = !%mega;
				%show["Fireball4_2"] = !%mega;
				%show["Fireball3Mega"] = %mega;
				%show["Fireball4_2Mega"] = %mega;
				%show["Trail"] = false;
				%show["WhiteTrail"] = false;
			} else {
				%show["Trail"] = (%speed > $TrailEmitterSpeed && %speed < $TrailEmitterWhiteSpeed);
				%show["WhiteTrail"] = (%speed > $TrailEmitterWhiteSpeed);
				%show["Fireball3"] = false;
				%show["Fireball4_2"] = false;
				%show["Fireball5"] = false;
			}
			//These are always false if not in water
			%show["Splash4"] = false;
			%show["TrailBubble"] = false;
		}

		%snoreThreshold = 0.01;
		%snoreTimeout = 10;

		//Snore emitter requires you to be still
		if (%speed < %snoreThreshold && %follow.lastMovement !$= "" && $Game::State $= "Go") {
			%show["Snore"] = $pref::Snore && (($Sim::Time - %follow.lastMovement) > %snoreTimeout);
		} else {
			%follow.lastMovement = $Sim::Time;
			%show["Snore"] = false;
		}

		//Stop getting in my face
		if (isCannonActive() || $Game::State $= "End") {
			%show["Trail"] = false;
			%show["WhiteTrail"] = false;
			%show["Snore"] = false;
			%show["Splash4"] = false;
			%show["TrailBubble"] = false;
			%show["Fireball3"] = false;
			%show["Fireball4_2"] = false;
			%show["Fireball3Mega"] = false;
			%show["Fireball4_2Mega"] = false;
		}

		//Need to call it this because %show == %show[""] and if %obj.type is unset
		// then it will just use whatever the previous has.
		%doShow = %show[%obj.type];
		if (%obj.type $= "" || %show[%obj.type] $= "") {
			//If we don't know if we should show it, then show it unless it's a
			// ParticleTrailNode (i.e. a marble trail)

			%doShow = !isMarbleEmitterTime(%obj.getDataBlock().timeMultiple);
		}

		//If we're showing it or don't know to not show it, show it
		if (%doShow) {
			%obj.setTransform(%position SPC "1 0 0 0");
		} else {
			%obj.setTransform("-999999 -999999 -999999 1 0 0 0");
		}
	}

	// clean up old trail emitters
	for (%i = 0; %i < %removeAmount; %i ++)
		ClientMarbleEmitterSet.remove(%remove[%i]);
}
