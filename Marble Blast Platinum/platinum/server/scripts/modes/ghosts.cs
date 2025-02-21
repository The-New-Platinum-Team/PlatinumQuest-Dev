//------------------------------------------------------------------------------
// Halloween Mode
//
// Copyright (c) 2015 The Platinum Team
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

/// Distance from center that the spookies will spawn at.
$Spooky::GhostSpawnRadius = 10;

/// Max distance a ghost will look to scan for a player.
$Spooky::GhostDistance = 25;

/// Speed ghost moves at in units per second once it tracks an object.
$Spooky::GhostTrackingSpeed = 1.0;

/// When the ghost is farther away, move at this speed (units per second)
$Spooky::GhostTrackingSpeedFast = 2.0;

/// When the ghost is REALLY FAR AWAY, GO LUDECRIS SPEED
$Spooky::GhostTrackingFASTFASTFASTSpeed = 5.0;

/// If the distance is > than this, make it go fast
$Spooky::FASTFASTFASTDistance = 50;

/// When it goes from fast to the slow motion in terms of units per second
$Spooky::GhostGoSlowAt = 10;

/// How many different ghost datablocks there are
$Spooky::GhostDTSCount = 4;

/// Time for each update tick
$Spooky::Delta = 15;

/// Time after a ghost OOBs a player that they won't chase them
$Spooky::GhostCooldown = 10000;

/// Additional cooldown time per # of ghosts per player
$Spooky::GhostCooldown1 = 0000;
$Spooky::GhostCooldown2 = 5000;
$Spooky::GhostCooldownN = 10000; // > 3

if (!isObject(SpookyGhostSet)) {
	new SimSet(SpookyGhostSet);
	RootGroup.add(SpookyGhostSet);
}

/// Enum for ai state machine
$Spooky::State::eWaiting = 0;
$Spooky::State::eFindPlayer = 1;
$Spooky::State::eTrackPlayer = 2;
$Spooky::State::eFindGem = 3;
$Spooky::State::eTrackGem = 4;
$Spooky::State::eWander = 5;

$Spooky::GhostFace[0] = "base";
$Spooky::GhostFace[1] = "creeper";
$Spooky::GhostFace[2] = "lenny";
$Spooky::GhostFace[3] = "pumpkin";
$Spooky::GhostFace[4] = "happy";
$Spooky::GhostFace[5] = "lady";
$Spooky::GhostFace[6] = "oooo";
$Spooky::GhostFace[7] = "scared";
$Spooky::GhostFaceCount = 8;

function Mode_ghosts::onLoad(%this) {
	echo("[Mode" SPC %this.name @ "]: Loaded!");
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onCreatePlayer");
	%this.registerCallback("onClientLeaveGame");
	%this.registerCallback("onOutOfBounds");
	%this.registerCallback("modifyScoreData");
}

function Mode_ghosts::modifyScoreData(%this, %object) {
	return %object.data @ "&extraModes[]=ghosts";
}

function Mode_ghosts::onMissionLoaded(%this) {
	updateScaryGhosts();
}
function Mode_ghosts::onMissionEnded(%this) {
	// cancel event schedules
	cancel($Spooky::ScaryGhostSchedule);
}
function Mode_ghosts::onMissionReset(%this) {
	// put them in place!
	// they respawn in a circle, but do not spawn in a circle.
	// because...raisins.
	respawnScaryGhosts();
	updateScaryGhosts();

	// reset "marble immunity" if attacked by a ghost
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i++)
		ClientGroup.getObject(%i).ghostImmunityTimer = 0;
}
function Mode_ghosts::onCreatePlayer(%this) {
	$Spooky::GhostCountPerPlayer = MissionInfo.ghostsPerPlayer ? MissionInfo.ghostsPerPlayer : 1;

	for (%i = 0; %i < $Spooky::GhostCountPerPlayer; %i++)
		createAScaryGhost();
}
function Mode_ghosts::onClientLeaveGame(%this) {
	// just delete a ghost, depending on how many per player
	for (%i = 0; %i < $Spooky::GhostCountPerPlayer; %i++)
		SpookyGhostSet.getObject(0).delete();
}
function Mode_ghosts::onOutOfBounds(%this, %obj) {
	// get scared.
	// set to true when frightened by a ghost.
	if (%obj.client.scareMePls) {
		serverPlay3d(GhostSound6, %obj.getTransform());
		commandToClient(%obj.client, '3Spooky5Me');
		%obj.client.scareMePls = false;
	}
	%obj.client.ghostImmunityTimer = $Spooky::GhostCooldown;
}


datablock StaticShapeData(ScaryGhost) {
	shapefile = $usermods @ "/data/shapes/Halloween/ghost_base.dts";
	scopeAlways = true;
	emap = false;
};

function ScaryGhost::onAdd(%this, %obj) {
	%obj.playThread(0, "ambient");
	%this.schedule(getRandom(5000, 10000), "spookySound", %obj);
}

function createAScaryGhost() {
	%obj = new StaticShape() {
		datablock = "ScaryGhost";
		position  = "0 0 0";
		rotation  = "1 0 0 0";
		scale     = "1 1 1";

		// currently the marble its tracking
		tracking = -1;
	};
	MissionCleanup.add(%obj);
	SpookyGhostSet.add(%obj);

	%obj.setSkinName($Spooky::GhostFace[getRandom(0, $Spooky::GhostFaceCount - 1)]);

	%box = MissionGroup.getWorldBox();
	%center = BoxCenterX(%box) SPC BoxCenterY(%box) SPC BoxMaxZ(%box);
	%obj.setTransform(%center SPC "1 0 0 0");
}

function respawnScaryGhosts() {
	%box = MissionGroup.getWorldBox();
	%center = BoxCenterX(%box) SPC BoxCenterY(%box) SPC BoxMaxZ(%box);

	%angle = 0;
	%count = SpookyGhostSet.getCount();
	%theta = mDegToRad(360 / %count);
	for (%i = 0; %i < %count; %i++) {
		%obj = SpookyGhostSet.getObject(%i);

		// calculate position to put it in a circle using angle and center
		// as parameters for it's transformation matrix.
		%rotation = "0 0 1" SPC %angle;
		%x = mCos(%angle) * $Spooky::GhostSpawnRadius;
		%y = mSin(%angle) * $Spooky::GhostSpawnRadius;
		%position = %x SPC %y SPC "0";
		%position = vectorAdd(%center, %position);
		%transform = %position SPC %rotation;
		%obj.setTransform(%transform);

		// next angle!
		%angle += %theta;

		// set state to waiting state
		%obj.following = -1;
		%obj.timer = 0;
		%obj.state = $Spooky::State::eWaiting;
	}
}

/// Determines whether a object has a ghost already following it.
/// @param object The object to check if a ghost is following it.
/// @return the ghost object that is following the object, or 0
///  if no ghost is following the object.
function objectHasGhostFollowing(%object) {
	%count = SpookyGhostSet.getCount();
	for (%i = 0; %i < %count; %i++) {
		%obj = SpookyGhostSet.getObject(%i);
		if (%obj.following == %object)
			return true;
	}
	return false;
}

function updateScaryGhosts() {
	cancel($Spooky::ScaryGhostSchedule);

	%count = SpookyGhostSet.getCount();
	for (%i = 0; %i < %count; %i++) {
		%obj = SpookyGhostSet.getObject(%i);

		// state machine for each kind of state for the ghost.
		switch (%obj.state) {
		case ($Spooky::State::eWaiting):
			// do nothing
			SpookyState::waiting(%obj);
		case ($Spooky::State::eFindPlayer):
			// find a player to track
			SpookyState::findPlayer(%obj, false);
		case ($Spooky::State::eTrackPlayer):
			// track a player
			SpookyState::trackPlayer(%obj);
		case ($Spooky::State::eFindGem):
			// find a gem
			SpookyState::findGem(%obj);
		case ($Spooky::State::eTrackGem):
			// track a gem
			SpookyState::trackGem(%obj);
		case ($Spooky::State::eWander):
			//Wander aimlessly
			SpookyState::wander(%obj);
		}
	}

	// ghost immunity
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i++) {
		%client = ClientGroup.getObject(%i);
		%client.ghostImmunityTimer -= $Spooky::Delta;
		if (%client.ghostImmunityTimer < 0)
			%client.ghostImmunityTimer = 0;
	}

	// check for collisions
	scaryGhostCheckCollision();

	$Spooky::ScaryGhostSchedule = schedule($Spooky::Delta, 0, updateScaryGhosts);
}

function scaryGhostCheckCollision() {
	%count = SpookyGhostSet.getCount();
	%clientCount = ClientGroup.getCount();

	for (%i = 0; %i < %clientCount; %i++) {
		%client = ClientGroup.getObject(%i);
		// sanity checking
		if (!isObject(%client) || !isObject(%client.player))
			continue;

		// if the client is already out of bounds, no need to replace
		// them out of bounds
		if (%client.isOOB)
			continue;

		// immute clients don't get killed :)
		if (%client.ghostImmunityTimer > 0)
			continue;

		%box = %client.player.getWorldBox();

		for (%j = 0; %j < %count; %j++) {
			%ghost = SpookyGhostSet.getObject(%j);
			// sanity checking
			if (!isObject(%ghost))
				continue;

			if (boxInterceptsBox(%ghost.getWorldBox(), %box)) {

				if (%client.isMegaMarble()) {
					// Mega Marble gives you a pass but the ghost eats your Mega
					%client.setMegaMarble(false);
				} else {
					// COLLIDE. GO OUT OF BOUNDS MATE
					// true means don't send the OOB message
					%client.scareMePls = true;
					%client.onOutOfBounds(true);
				}

				// grant immunity
				%client.ghostImmunityTimer = $Spooky::GhostCooldown;
				switch ($Spooky::GhostCountPerPlayer) {
				case 1:
					%client.ghostImmunityTimer += $Spooky::GhostCooldown1;
				case 2:
					%client.ghostImmunityTimer += $Spooky::GhostCooldown2;
				default:
					%client.ghostImmunityTimer += $Spooky::GhostCooldownN;
				}

				break; // inner loop can break, we are already out of bounds
			}
		}
	}
}

function SpookyState::waiting(%obj) {
	// Untracks players or gems that could have been being tracked.
	// basically does a reset
	%clientCount = ClientGroup.getCount();
	for (%i = 0; %i < %clientCount; %i++) {
		%client = ClientGroup.getObject(%i);
		if (!isObject(%client.player))
			continue;

		if (%client.player.theFollowingGhost == %obj.following)
			%client.player.theFollowingGhost = -1;
	}
	%obj.following = -1;

	// ready/set does nothing
	if ($Game::State $= "Go") {
		// "Think time" which means the spooky ghost just sits there in place.
		%obj.timer -= $Spooky::Delta;
		if (%obj.timer <= 0) {
			%obj.timer = 0;

			// go find another player or gem, using a RNG
			SpookyState::findPlayer(%obj);
			if (%obj.following == -1) {
				SpookyState::findGem(%obj);
				if (%obj.following == -1) {
					%obj.state = $Spooky::State::eWander;
				}
			}
		}
	}
}

function SpookyState::findPlayer(%obj, %alreadyTrackingGem) {
	%clientCount = ClientGroup.getCount();
	%pos = %obj.getPosition();
	%max = $Spooky::GhostDistance;
	%target = -1;
	for (%i = 0; %i < %clientCount; %i++) {
		%client = ClientGroup.getObject(%i);
		if (!isObject(%client.player))
			continue;

		// if this client already has a ghost following it, don't make
		// them get to scared by having multiple follow.
		if (isObject(%client.player.theFollowingGhost))
			continue;

		// check for immunity, if you have immunity, don't get attacked
		if (%client.ghostImmunityTimer > 0)
			continue;

		// check distance, find closest to go to
		%dist = vectorDist(%pos, %client.player.getPosition());
		if (%dist < %max) {
			%max = %dist;
			%target = %client.player;
		}
	}

	if (%target != -1) {
		// if we've found a marble to latch onto
		%obj.following = %target;
		%obj.state = $Spooky::State::eTrackPlayer;
		%target.theFollowingGhost = %obj;
		return true;
	} else if (!%alreadyTrackingGem) {
		// we didn't find a marble. Maybe they were out of range,
		// or the marble already has a ghost following it.
		// go find a gem!
		%obj.following = -1;
		%obj.state = $Spooky::State::eFindGem;
	}
	return false;
}

function SpookyState::trackPlayer(%obj) {
	// If the following object left or Disconnected, stop following
	if (!isObject(%obj.following)) {
		%obj.timer = 1000; // make ghost wait 1 second before continuing another task
		%obj.state = $Spooky::State::eWaiting;
		return;
	}

	// if the player has a ghost immunity, don't track
	if (%obj.following.client.ghostImmunityTimer > 0) {
		%obj.following.theFollowingGhost = -1; // let the game know that
		%obj.timer = 250;
		%obj.state = $Spooky::State::eWaiting;
		return;
	}

	// if the player is gone, go wait a bit
	%dist = vectorDist(%obj.getPosition(), %obj.following.getPosition());
	if (%dist > $Spooky::GhostDistance) {
		%obj.following.theFollowingGhost = -1; // let the game know that
		%obj.timer = 500; // make ghost wait 500ms before continuing
		%obj.state = $Spooky::State::eWaiting;
		return;
	}

	// move the ghost
	moveSpookyGhost(%obj);
}

function SpookyState::findGem(%obj) {
	// find closet non-hidden gem.
	%max = 999999999;
	%target = -1;
	%pos = %obj.getPosition();
	makeGemGroup(MissionGroup, true);
	for (%i = 0; %i < $GemsCount; %i++) {
		if ($Gems[%i].isHidden())
			continue;

		// Note: Unlike players, multiple ghosts can track the same gem
		// check distance, find closest to go to
		%dist = vectorDist(%pos, $Gems[%i].getPosition());
		%dist /= (1 + $Gems[%i]._huntDatablock.huntExtraValue);
		if (%dist < %max && !objectHasGhostFollowing($Gems[%i])) {
			%max = %dist;
			%target = $Gems[%i];
		}
	}

	// if we've found a gem to latch onto
	if (%target != -1) {
		%obj.following = %target;
		%obj.state = $Spooky::State::eTrackGem;
	} else {
		// we didn't find a gem. Maybe they were out of range
		// go find a player
		%obj.following = -1;
		%obj.state = $Spooky::State::eFindPlayer;
	}
}

function SpookyState::trackGem(%obj) {
	// If the following object got deleted.
	if (!isObject(%obj.following)) {
		%obj.timer = 1000; // make ghost wait 1 second before continuing another task
		%obj.state = $Spooky::State::eWaiting;
		return;
	}

	// if the gem went hidden, stop tracking it and do something else.
	if (%obj.following.isHidden()) {
		%obj.timer = 500; // wait 500ms before doing something else
		%obj.state = $Spooky::State::eWaiting;
		return;
	}

	// if we can latch onto a marble, then just do that. Gems are supposed
	// to just keep them moving.
	if (SpookyState::findPlayer(%obj, true)) {
		echo("Found a player! going to track player instead of gem now!");
		return;
	}

	if (VectorDist(%obj.following.getPosition(), %obj.getPosition()) < 1) {
		%obj.timer = 1000; // make ghost wait 1 second before continuing another task
		%obj.state = $Spooky::State::eWaiting;
		return;
	}

	moveSpookyGhost(%obj);
}

function SpookyState::wander(%obj) {
	// Try to go somewhere random
	if (%obj.trackPoint $= "") {
		%box = MissionGroup.getWorldBox();
		%obj.trackPoint = getRandom(BoxMinX(%box), BoxMaxX(%box)) SPC getRandom(BoxMinY(%box), BoxMaxY(%box)) SPC getRandom(BoxMinZ(%box), BoxMaxZ(%box));
	}

	// if we can latch onto a marble, then just do that. Gems are supposed
	// to just keep them moving.
	if (SpookyState::findPlayer(%obj, true)) {
		echo("Found a player! going to track player instead of wander now!");
		return;
	}

	%dist = VectorDist(%obj.trackPoint, %obj.getPosition());

	if (%dist < 1) {
		%obj.trackPoint = "";
		%obj.timer = 1000; // make ghost wait 1 second before continuing another task
		%obj.state = $Spooky::State::eWaiting;
		return;
	}

	moveSpookyGhost(%obj);
}

function moveSpookyGhost(%obj) {
	// move the ghost towards the player in units per second
	if (%obj.state == $Spooky::State::eWander) {
		%sub = VectorSub(%obj.trackPoint, %obj.getPosition());
	} else {
		%sub = vectorSub(%obj.following.getPosition(), %obj.getPosition());
	}

	%normal = vectorNormalize(%sub);

	// go slower if we are closer so they can have time to escape
	%distance = vectorLen(%sub);
	if (%distance > $Spooky::FASTFASTFASTDistance)
		%speedFactor = $Spooky::GhostTrackingFASTFASTFASTSpeed;
	else if (%distance > $Spooky::GhostGoSlowAt)
		%speedFactor = $Spooky::GhostTrackingSpeedFast;
	else
		%speedFactor = $Spooky::GhostTrackingSpeed;

	%velocity = vectorScale(%normal, (%speedFactor * (1000 / $Spooky::Delta)) / 1000);
	%finalGhostPosition = vectorAdd(%obj.getPosition(), %velocity);

	// rotate ghost to face the player
	// cheap ass way of calculating pitch.
	%yaw = mAtan(getWord(%sub, 0), getWord(%sub, 1)) - ($pi/2);
	%pitch = mClamp(getWord(%sub, 2), -0.95, 0.95);
	%pitchMatrix = "0 0 0 0 1 0" SPC %pitch;
	%yawMatrix = "0 0 0 0 0 1" SPC %yaw;
	%transform = MatrixMultiply(%pitchMatrix, %yawMatrix);
	%transform = %finalGhostPosition SPC getWords(%transform, 3, 6);
	%obj.setTransform(%transform);
}

// //-----------------------------------------------------------------------------
// // Spooky Matan Ghost Noises
// // ----------------------------------------------------------------------------

// // Standard Ghost exhasperations
datablock AudioProfile(GhostSound1)  {
	filename = "~/data/sound/ghost/g1.wav";
	description = AudioDefault3D;
	preload = true;
};		// Gasp 1
// datablock AudioProfile(GhostSound2)  { filename = "~/data/sound/ghost/g2.wav"; description = AudioDefault3D; preload = true; };		// Gasp 2
// datablock AudioProfile(GhostSound3)  { filename = "~/data/sound/ghost/g3.wav"; description = AudioDefault3D; preload = true; };		// Exhale 1
// datablock AudioProfile(GhostSound4)  { filename = "~/data/sound/ghost/g4.wav"; description = AudioDefault3D; preload = true; };		// Exhale 2
// datablock AudioProfile(GhostSound5)  { filename = "~/data/sound/ghost/g23.wav"; description = AudioDefault3D; preload = true; };	// Shriek noise thing
datablock AudioProfile(GhostSound6)  {
	filename = "~/data/sound/ghost/g47.wav";
	description = AudioDefault3D;
	preload = true;
};	// Haunting Laughter
// datablock AudioProfile(GhostSound7)  { filename = "~/data/sound/ghost/g17.wav"; description = AudioDefault3D; preload = true; };	// Soft Coughing
// datablock AudioProfile(GhostSound8)  { filename = "~/data/sound/ghost/g18.wav"; description = AudioDefault3D; preload = true; };	// Soft Coughing 2
// datablock AudioProfile(GhostSound9)  { filename = "~/data/sound/ghost/g71.wav"; description = AudioDefault3D; preload = true; };	// Sigh
// datablock AudioProfile(GhostSound10) { filename = "~/data/sound/ghost/g72.wav"; description = AudioDefault3D; preload = true; };	// Oooh

// // Silly Ghosts
// datablock AudioProfile(GhostSound11)  { filename = "~/data/sound/ghost/g5.wav"; description = AudioDefault3D; preload = true; };	// Kalle
// datablock AudioProfile(GhostSound12)  { filename = "~/data/sound/ghost/g7.wav"; description = AudioDefault3D; preload = true; };	// HiGuy
// datablock AudioProfile(GhostSound13)  { filename = "~/data/sound/ghost/g8.wav"; description = AudioDefault3D; preload = true; };	// Jeff
// datablock AudioProfile(GhostSound14)  { filename = "~/data/sound/ghost/g9.wav"; description = AudioDefault3D; preload = true; };	// Matan
// datablock AudioProfile(GhostSound15)  { filename = "~/data/sound/ghost/g10.wav"; description = AudioDefault3D; preload = true; };	// Regislian
// datablock AudioProfile(GhostSound16)  { filename = "~/data/sound/ghost/g11.wav"; description = AudioDefault3D; preload = true; };	// Buzzmusic
// datablock AudioProfile(GhostSound17)  { filename = "~/data/sound/ghost/g12.wav"; description = AudioDefault3D; preload = true; };	// Spooky
// datablock AudioProfile(GhostSound18)  { filename = "~/data/sound/ghost/g13.wav"; description = AudioDefault3D; preload = true; };	// Aayrl
// datablock AudioProfile(GhostSound19)  { filename = "~/data/sound/ghost/g14.wav"; description = AudioDefault3D; preload = true; };	// Damn it ?
// datablock AudioProfile(GhostSound20)  { filename = "~/data/sound/ghost/g15.wav"; description = AudioDefault3D; preload = true; };	// John Cena
// datablock AudioProfile(GhostSound21)  { filename = "~/data/sound/ghost/g16.wav"; description = AudioDefault3D; preload = true; };	// Help I'm Lost
// datablock AudioProfile(GhostSound22)  { filename = "~/data/sound/ghost/g19.wav"; description = AudioDefault3D; preload = true; };	// 2Spooky4Me
// datablock AudioProfile(GhostSound23)  { filename = "~/data/sound/ghost/g20.wav"; description = AudioDefault3D; preload = true; };	// Threefolder
// datablock AudioProfile(GhostSound24)  { filename = "~/data/sound/ghost/g21.wav"; description = AudioDefault3D; preload = true; };	// RDS Empire
// datablock AudioProfile(GhostSound25)  { filename = "~/data/sound/ghost/g22.wav"; description = AudioDefault3D; preload = true; };	// PQ Where
// datablock AudioProfile(GhostSound26)  { filename = "~/data/sound/ghost/g24.wav"; description = AudioDefault3D; preload = true; };	// Doot Doot
// datablock AudioProfile(GhostSound27)  { filename = "~/data/sound/ghost/g25.wav"; description = AudioDefault3D; preload = true; };	// Dank Memes
// datablock AudioProfile(GhostSound28)  { filename = "~/data/sound/ghost/g26.wav"; description = AudioDefault3D; preload = true; };	// Lose the Game
// datablock AudioProfile(GhostSound29)  { filename = "~/data/sound/ghost/g27.wav"; description = AudioDefault3D; preload = true; };	// Kurt Perks 2016
// datablock AudioProfile(GhostSound30)  { filename = "~/data/sound/ghost/g28.wav"; description = AudioDefault3D; preload = true; };	// Always Salt your Pasta while Boiling It
// datablock AudioProfile(GhostSound31)  { filename = "~/data/sound/ghost/g29.wav"; description = AudioDefault3D; preload = true; };	// And Don't Call me Shirley
// datablock AudioProfile(GhostSound32)  { filename = "~/data/sound/ghost/g30.wav"; description = AudioDefault3D; preload = true; };	// Are you 18 yet?
// datablock AudioProfile(GhostSound33)  { filename = "~/data/sound/ghost/g31.wav"; description = AudioDefault3D; preload = true; };	// Are you still there?
// datablock AudioProfile(GhostSound34)  { filename = "~/data/sound/ghost/g32.wav"; description = AudioDefault3D; preload = true; };	// B5 ... Miss
// datablock AudioProfile(GhostSound35)  { filename = "~/data/sound/ghost/g33.wav"; description = AudioDefault3D; preload = true; };	// Batman does not eat nachos
// datablock AudioProfile(GhostSound36)  { filename = "~/data/sound/ghost/g34.wav"; description = AudioDefault3D; preload = true; };	// Be serious with me!
// datablock AudioProfile(GhostSound37)  { filename = "~/data/sound/ghost/g35.wav"; description = AudioDefault3D; preload = true; };	// Beware the Airhorn
// datablock AudioProfile(GhostSound38)  { filename = "~/data/sound/ghost/g36.wav"; description = AudioDefault3D; preload = true; };	// Beware
// datablock AudioProfile(GhostSound39)  { filename = "~/data/sound/ghost/g37.wav"; description = AudioDefault3D; preload = true; };	// Bloody Hell mate!
// datablock AudioProfile(GhostSound40)  { filename = "~/data/sound/ghost/g38.wav"; description = AudioDefault3D; preload = true; };	// Bloody Mary
// datablock AudioProfile(GhostSound41)  { filename = "~/data/sound/ghost/g39.wav"; description = AudioDefault3D; preload = true; };	// Bow chika bow wow
// datablock AudioProfile(GhostSound42)  { filename = "~/data/sound/ghost/g40.wav"; description = AudioDefault3D; preload = true; };	// Candlejack
// datablock AudioProfile(GhostSound43)  { filename = "~/data/sound/ghost/g41.wav"; description = AudioDefault3D; preload = true; };	// Challenges where
// datablock AudioProfile(GhostSound44)  { filename = "~/data/sound/ghost/g42.wav"; description = AudioDefault3D; preload = true; };	// Come Discord Brah
// datablock AudioProfile(GhostSound45)  { filename = "~/data/sound/ghost/g43.wav"; description = AudioDefault3D; preload = true; };	// Disconnect ... Invalid Packet
// datablock AudioProfile(GhostSound46)  { filename = "~/data/sound/ghost/g44.wav"; description = AudioDefault3D; preload = true; };	// Do not pass go
// datablock AudioProfile(GhostSound47)  { filename = "~/data/sound/ghost/g45.wav"; description = AudioDefault3D; preload = true; };	// Don't Blink
// datablock AudioProfile(GhostSound48)  { filename = "~/data/sound/ghost/g46.wav"; description = AudioDefault3D; preload = true; };	// Download more RAM
// datablock AudioProfile(GhostSound49)  { filename = "~/data/sound/ghost/g48.wav"; description = AudioDefault3D; preload = true; };	// Free JoJo
// datablock AudioProfile(GhostSound50)  { filename = "~/data/sound/ghost/g49.wav"; description = AudioDefault3D; preload = true; };	// Give us your money please
// datablock AudioProfile(GhostSound51)  { filename = "~/data/sound/ghost/g50.wav"; description = AudioDefault3D; preload = true; };	// Gotta Ghost Fast
// datablock AudioProfile(GhostSound52)  { filename = "~/data/sound/ghost/g51.wav"; description = AudioDefault3D; preload = true; };	// HiGuy Crash bug
// datablock AudioProfile(GhostSound53)  { filename = "~/data/sound/ghost/g52.wav"; description = AudioDefault3D; preload = true; };	// Hosis
// datablock AudioProfile(GhostSound54)  { filename = "~/data/sound/ghost/g53.wav"; description = AudioDefault3D; preload = true; };	// joj
// datablock AudioProfile(GhostSound55)  { filename = "~/data/sound/ghost/g54.wav"; description = AudioDefault3D; preload = true; };	// I like chocolate
// datablock AudioProfile(GhostSound56)  { filename = "~/data/sound/ghost/g55.wav"; description = AudioDefault3D; preload = true; };	// I like pizza
// datablock AudioProfile(GhostSound57)  { filename = "~/data/sound/ghost/g56.wav"; description = AudioDefault3D; preload = true; };	// Illuminati confirmed
// datablock AudioProfile(GhostSound58)  { filename = "~/data/sound/ghost/g57.wav"; description = AudioDefault3D; preload = true; };	// I never beat A-Maze-Ing's qualify time
// datablock AudioProfile(GhostSound59)  { filename = "~/data/sound/ghost/g58.wav"; description = AudioDefault3D; preload = true; };	// I see you
// datablock AudioProfile(GhostSound60)  { filename = "~/data/sound/ghost/g59.wav"; description = AudioDefault3D; preload = true; };	// It's time to d-d-d-d-duel
// datablock AudioProfile(GhostSound61)  { filename = "~/data/sound/ghost/g60.wav"; description = AudioDefault3D; preload = true; };	// It's time
// datablock AudioProfile(GhostSound62)  { filename = "~/data/sound/ghost/g61.wav"; description = AudioDefault3D; preload = true; };	// Join the Navy
// datablock AudioProfile(GhostSound63)  { filename = "~/data/sound/ghost/g62.wav"; description = AudioDefault3D; preload = true; };	// Join us
// datablock AudioProfile(GhostSound64)  { filename = "~/data/sound/ghost/g63.wav"; description = AudioDefault3D; preload = true; };	// Let me out of here
// datablock AudioProfile(GhostSound65)  { filename = "~/data/sound/ghost/g64.wav"; description = AudioDefault3D; preload = true; };	// Made in China
// datablock AudioProfile(GhostSound66)  { filename = "~/data/sound/ghost/g65.wav"; description = AudioDefault3D; preload = true; };	// Make Halloween Great Again
// datablock AudioProfile(GhostSound67)  { filename = "~/data/sound/ghost/g66.wav"; description = AudioDefault3D; preload = true; };	// Make Marble Blast Great Again
// datablock AudioProfile(GhostSound68)  { filename = "~/data/sound/ghost/g67.wav"; description = AudioDefault3D; preload = true; };	// Mega Marble Kids
// datablock AudioProfile(GhostSound69)  { filename = "~/data/sound/ghost/g68.wav"; description = AudioDefault3D; preload = true; };	// My Favorite Day is FrightDay
// datablock AudioProfile(GhostSound70)  { filename = "~/data/sound/ghost/g69.wav"; description = AudioDefault3D; preload = true; };	// My Precious
// datablock AudioProfile(GhostSound71)  { filename = "~/data/sound/ghost/g70.wav"; description = AudioDefault3D; preload = true; };	// NonHomogenousSecondOrderLinearDifferentialEquatioonnnnssss
// datablock AudioProfile(GhostSound72)  { filename = "~/data/sound/ghost/g73.wav"; description = AudioDefault3D; preload = true; };	// Oooh Candy
// datablock AudioProfile(GhostSound73)  { filename = "~/data/sound/ghost/g74.wav"; description = AudioDefault3D; preload = true; };	// Pay attention to me
// datablock AudioProfile(GhostSound74)  { filename = "~/data/sound/ghost/g75.wav"; description = AudioDefault3D; preload = true; };	// Pineapple Pizza
// datablock AudioProfile(GhostSound75)  { filename = "~/data/sound/ghost/g76.wav"; description = AudioDefault3D; preload = true; };	// Pokemon Gooooooooohst
// datablock AudioProfile(GhostSound76)  { filename = "~/data/sound/ghost/g77.wav"; description = AudioDefault3D; preload = true; };	// PQ
// datablock AudioProfile(GhostSound77)  { filename = "~/data/sound/ghost/g78.wav"; description = AudioDefault3D; preload = true; };	// PQ crashed make pq crash again
// datablock AudioProfile(GhostSound78)  { filename = "~/data/sound/ghost/g79.wav"; description = AudioDefault3D; preload = true; };	// PQ crashed please send a crash log
// datablock AudioProfile(GhostSound79)  { filename = "~/data/sound/ghost/g80.wav"; description = AudioDefault3D; preload = true; };	// Punkin Pie
// datablock AudioProfile(GhostSound80)  { filename = "~/data/sound/ghost/g81.wav"; description = AudioDefault3D; preload = true; };	// spooooocough...cough..dead
// datablock AudioProfile(GhostSound81)  { filename = "~/data/sound/ghost/g82.wav"; description = AudioDefault3D; preload = true; };	// Puzzle Level 12 Exists
// datablock AudioProfile(GhostSound82)  { filename = "~/data/sound/ghost/g83.wav"; description = AudioDefault3D; preload = true; };	// QuArK is better than Constructor
// datablock AudioProfile(GhostSound83)  { filename = "~/data/sound/ghost/g84.wav"; description = AudioDefault3D; preload = true; };	// Random Noise Here
// datablock AudioProfile(GhostSound84)  { filename = "~/data/sound/ghost/g85.wav"; description = AudioDefault3D; preload = true; };	// Rick Ghastly is my Favorite Singer
// datablock AudioProfile(GhostSound85)  { filename = "~/data/sound/ghost/g86.wav"; description = AudioDefault3D; preload = true; };	// Rosie Ghostie
// datablock AudioProfile(GhostSound86)  { filename = "~/data/sound/ghost/g87.wav"; description = AudioDefault3D; preload = true; };	// Salty
// datablock AudioProfile(GhostSound87)  { filename = "~/data/sound/ghost/g88.wav"; description = AudioDefault3D; preload = true; };	// Awesome
// datablock AudioProfile(GhostSound88)  { filename = "~/data/sound/ghost/g89.wav"; description = AudioDefault3D; preload = true; };	// Scoobydoobydoo..where are you..
// datablock AudioProfile(GhostSound89)  { filename = "~/data/sound/ghost/g90.wav"; description = AudioDefault3D; preload = true; };	// Shazbot
// datablock AudioProfile(GhostSound90)  { filename = "~/data/sound/ghost/g91.wav"; description = AudioDefault3D; preload = true; };	// Spam all day every day
// datablock AudioProfile(GhostSound91)  { filename = "~/data/sound/ghost/g92.wav"; description = AudioDefault3D; preload = true; };	// Speedboostaiiiirrrrrrrrrr
// datablock AudioProfile(GhostSound92)  { filename = "~/data/sound/ghost/g94.wav"; description = AudioDefault3D; preload = true; };	// Spook-ghetti
// datablock AudioProfile(GhostSound93)  { filename = "~/data/sound/ghost/g95.wav"; description = AudioDefault3D; preload = true; };	// Spooky Ghouls
// datablock AudioProfile(GhostSound94)  { filename = "~/data/sound/ghost/g96.wav"; description = AudioDefault3D; preload = true; };	// TeeWorlds
// datablock AudioProfile(GhostSound95)  { filename = "~/data/sound/ghost/g97.wav"; description = AudioDefault3D; preload = true; };	// Thanks Obama
// datablock AudioProfile(GhostSound96)  { filename = "~/data/sound/ghost/g98.wav"; description = AudioDefault3D; preload = true; };	// The boogieman lives
// datablock AudioProfile(GhostSound97)  { filename = "~/data/sound/ghost/g99.wav"; description = AudioDefault3D; preload = true; };	// There's no place like hell
// datablock AudioProfile(GhostSound98)  { filename = "~/data/sound/ghost/g100.wav"; description = AudioDefault3D; preload = true; };	// This is Sparta
// datablock AudioProfile(GhostSound99)  { filename = "~/data/sound/ghost/g101.wav"; description = AudioDefault3D; preload = true; };	// Thou shall not pass
// datablock AudioProfile(GhostSound100) { filename = "~/data/sound/ghost/g103.wav"; description = AudioDefault3D; preload = true; };	// Too Spooky
// datablock AudioProfile(GhostSound101) { filename = "~/data/sound/ghost/g104.wav"; description = AudioDefault3D; preload = true; };	// Tourney hype
// datablock AudioProfile(GhostSound102) { filename = "~/data/sound/ghost/g105.wav"; description = AudioDefault3D; preload = true; };	// Tsuf
// datablock AudioProfile(GhostSound103) { filename = "~/data/sound/ghost/g106.wav"; description = AudioDefault3D; preload = true; };	// Thistle
// datablock AudioProfile(GhostSound104) { filename = "~/data/sound/ghost/g107.wav"; description = AudioDefault3D; preload = true; };	// VislinkCannotBeCoplanarWithANode
// datablock AudioProfile(GhostSound105) { filename = "~/data/sound/ghost/g108.wav"; description = AudioDefault3D; preload = true; };	// Welcome to Replay of the Day
// datablock AudioProfile(GhostSound106) { filename = "~/data/sound/ghost/g109.wav"; description = AudioDefault3D; preload = true; };	// Why am I speaking like this?
// datablock AudioProfile(GhostSound107) { filename = "~/data/sound/ghost/g110.wav"; description = AudioDefault3D; preload = true; };	// Windows encountered an error
// datablock AudioProfile(GhostSound108) { filename = "~/data/sound/ghost/g111.wav"; description = AudioDefault3D; preload = true; };	// Windows is updating your computer

// // Matan being silly, 1/200 times.
// datablock AudioProfile(GhostSoundFun) { filename = "~/data/sound/ghost/g112.wav"; description = AudioDefault3D; preload = true; };			// Ooh Aah I am a Ghost

// // Play an Airhorn meme every 1/400 times.
datablock AudioProfile(GhostSoundAirhorn) {
	filename = "~/data/sound/ghost/airhorn.wav";
	description = AudioDefault3D;
	preload = true;
};	// AIRHORN.WAAAAAAAAV

// // Truly Terrifying noises. 1/500 choose one of these randomly.
// datablock AudioProfile(GhostSoundScary1) { filename = "~/data/sound/ghost/GETOUT.wav"; description = AudioDefault3D; preload = true; };		// GET OUT
// datablock AudioProfile(GhostSoundScary2) { filename = "~/data/sound/ghost/g113.wav"; description = AudioDefault3D; preload = true; };	// SILENCE
// datablock AudioProfile(GhostSoundScary3) { filename = "~/data/sound/ghost/tsuf.wav"; description = AudioDefault3D; preload = true; };		// Tsuf Squeak
// datablock AudioProfile(GhostSoundScary4) { filename = "~/data/sound/ghost/g114.wav"; description = AudioDefault3D; preload = true; };		// Yeti 1
// datablock AudioProfile(GhostSoundScary5) { filename = "~/data/sound/ghost/g115.wav"; description = AudioDefault3D; preload = true; };		// Yeti 2

// Map ghost sounds to ghosts.
function ScaryGhost::spookySound(%this, %obj) {
	cancel(%this.spookySoundSch[%obj]);

	%ghostrandom = $userMods @ "/data/sound/ghost/" @ "g" @ getRandom(1, 111) @ ".wav";

	if (!isObject(%obj))
		return;
	%sound = GhostSound @ getRandom(1);
	if (getRandom(0, 1000) == 1000)
		%sound = GhostSoundAirhorn;

	serverPlay3d(%sound, %obj.getTransform());

	%this.spookySoundSch[%obj] = %this.schedule(getRandom(15000, 20000), "spookySound", %obj);
	%this.randomSoundSch[%obj] = %this.schedule(getRandom(7500, 10000), GhostSound1.filename = %ghostrandom); //Hacky method in order to preserve datablock space.
}
