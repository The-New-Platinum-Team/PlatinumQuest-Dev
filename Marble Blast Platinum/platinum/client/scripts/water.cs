//-----------------------------------------------------------------------------
// water.cs
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

//-----------------------------------------------------------------------------
// TODO: what if you change your marble to a mega marble?
//       The physics won't change. Dear god help me
//
// TODO: all gravities for water support? Decide later.
//
// TODO: maybe recycle particles and actually have them update real-time
//       and just be all client based instead of being in sync with the server?
//       Cause this is going to look laggy as hell over a connection.
//
// TODO: check if the control object isn't a marble, i.e. camera
//-----------------------------------------------------------------------------

/// The amount of water triggers that the marble is touching.
$Water::LastCount = 0;

/// Min speed in order to get the bubble trail going on the marble.
$Water::BubbleTrailSpeed = 1.25;

/// All water triggers that the control object touches are placed into this set
if (!isObject(WaterMarbleIsInSet)) {
	new SimSet(WaterMarbleIsInSet);
	RootGroup.add(WaterMarbleIsInSet);
}

/// Called whenever the marble enters a water trigger.
/// @arg marble The marble object entering the trigger.
function WaterPhysicsTrigger_onClientEnterTrigger(%this, %trigger, %marble) {
	if (!isObject(%marble.waterIsInSet)) {
		%marble.waterIsInSet = new SimSet(WaterIsInSet);
		RootGroup.add(%marble.waterIsInSet);

		// we haven't hit water YET, so last count is 0
		%marble.waterLastCount = 0;
	}
	%marble.waterIsInSet.add(%trigger);
	updateClientWater();
}

function WaterPhysicsTrigger_onClientStayTrigger(%this, %trigger, %marble) {
	//Nothing
}

/// Called whenever the marble leaves a water trigger.
/// @arg marble The marble object leaving the trigger.
function WaterPhysicsTrigger_onClientLeaveTrigger(%this, %trigger, %marble) {
	%marble.waterIsInSet.remove(%trigger);
	updateClientWater();
}

/// Called whenever the client controlled marble enters water.
/// If you are transitioning from one water trigger to the next, this callback
/// is not fired, as it will be seamless.
/// It will only be called on the first water trigger is entered.
function WaterPhysicsTrigger_onEnterWater(%this, %trigger) {
	// apply water physics
	Physics::pushLayerName("water");

	%velocity = $MP::MyMarble.getVelocity();
	%speed = vectorLen(%velocity);
	//echo("Speed when hitting the water:" SPC %speed);
	//echo("Velocity when hitting the water:" SPC %velocity);
	//echo("velocity multiplier:" SPC %trigger.velocityMultiplier);

	// Velocity change.
	%velocityChange = vectorScale(%velocity, -%trigger.VelocityMultiplier);
	$MP::MyMarble.applyImpulse("0 0 0", %velocityChange);
	//echo("Applying impulse:" SPC %velocityChange);

	//Cancel any fireball we have
	clientCmdFireballExpire();

	// Check which emitter will be used based upon speed.
	// If the speed was at least 20 units per second, then it is considered
	// that the marble has splatted hard against the water.
	// TODO: might need to adjust these.
	if (%speed >= 50) {
		%datablock = "Splash3Emitter";
		%splattedAgainstWater = true;
	} else if (%speed >= 20) {
		%datablock = "Splash1Emitter";
		%splattedAgainstWater = true;
	} else {
		%datablock = "Splash2Emitter";
		%splattedAgainstWater = false; // wasn't a hard enough splash
	}

	%position = vectorAdd($MP::MyMarble.getPosition(), "0 0 -0.4");
	commandToServer('WaterSplash', %datablock, %position);

	// Hitting the water too hard causes an extra particle emitter to be placed.
	if (%splattedAgainstWater) {
		%position = vectorAdd($MP::MyMarble.getPosition(), "0 0 -0.4");
		commandToServer('WaterSplash', "Drop1Emitter", %position);
	}
}

/// Called whenever the client controlled marble leaves the water.
/// If you are transitioning from one water trigger to the next, this callback
/// is not fired, as it will be seamless.
/// It will only be called once the last water trigger is left.
function onLeaveWater() {
	// Let the server know we need a particle emitter for leaving the water
	%position = vectorAdd($MP::MyMarble.getPosition(), "0 0 -0.4");
	commandToServer('WaterSplash', "Splash2Emitter", %position);

	// clear physics
	Physics::popLayerName("water");
}

/// Called every frame to update everything dealing with water.
/// @note called in onFrameAdvance
/// @see onFrameAdvance, WaterTrigger::onEnterWater, WaterTrigger::onLeaveWater
function updateClientWater() {
	%cameraPos = MatrixPos(getCameraTransform());
	if (%cameraPos == -1) {
		UnderwaterOL.setVisible(false);
		return;
	}

	if (!MPMyMarbleExists()) {
		UnderwaterOL.setVisible(false);
		return;
	}

	// get information from the control object
	// these can stay out side of the loop because we only
	// use these for the control object.
	%ctrlPlayer = $MP::MyMarble;

	if (!isObject(%ctrlPlayer.waterIsInSet)) {
		%ctrlPlayer.waterIsInSet = new SimSet(WaterIsInSet);
		RootGroup.add(%ctrlPlayer.waterIsInSet);

		// we haven't hit water YET, so last count is 0
		%ctrlPlayer.waterLastCount = 0;
	}

	// check camera overlay
	performWaterOverlay(%ctrlPlayer.waterIsInSet, %cameraPos);

	%size = PlayerList.getSize();
	for (%i = 0; %i < %size; %i ++) {
		%player = PlayerList.getEntry(%i).player;
		if (!isObject(%player))
			continue;

		if (!isObject(%player.waterIsInSet)) {
			%player.waterIsInSet = new SimSet(WaterIsInSet);
			RootGroup.add(%player.waterIsInSet);

			// we haven't hit water YET, so last count is 0
			%player.waterLastCount = 0;
		}

		%pos = %player.getPosition();
		%count = %player.waterIsInSet.getCount();

		// having a count > 0 means we are in the water
		if (%count > 0) {
			// get closest trigger that the marble is overlapping based upon a simple
			// distance check.
			%closestTrigger = findClosestWaterTrigger(%player.waterIsInSet, %pos);

			// We are in the water! Check to see if we just entered the water or not
			// note: onEnterWater is only called on the control object.
			if (%player.waterLastCount == 0) {
				if (%player == %ctrlPlayer)
					WaterPhysicsTrigger_onEnterWater(WaterPhysicsTrigger, %closestTrigger);

				%player.isInWater = true;
				%player.bubbleEmitter = false; // splash trail
			}

			%inWater = %closestTrigger.testObject(%player);
			if (%inWater) {
				// fully submerged into the water
				%player.bubbleEmitter = true; // bubble trail
			} else {
				%player.bubbleEmitter = false; // splash trail
			}

			// This is if you are not fully submerged into the water, but you are
			// partially in it. This is where the physics change occurs, rapidly
			// depending on z depth.
			//
			// The math: ask seizure, but I think it's just a math formula to make
			// the water seem realistic. As you go deeper, the slower you go until
			// you are fully submerged.
			//
			// Note: physics only affects *you* not other clients
			if (%player == %ctrlPlayer) {
				%zdist = mClamp(getWord(%pos, 2) - getWord(%closestTrigger.getWorldBox(), 5), 0, 0.2);

				%db = %player.getDatablock();
				%db.maxRollVelocity = %zdist / 0.2 * 10 + 5;
				%db.angularAcceleration = %zdist / 0.2 * 40 + 35;
			}
		} else if (%player.waterLastCount > 0) {
			// onLeaveWater is only called on the control object
			if (%player == %ctrlPlayer)
				onLeaveWater();
			%player.isInWater = false;
			%player.bubbleEmitter = false; // splash trail
		}

		%player.waterLastCount = %count;
	}
}

/// Finds the closet water trigger to the position specified.
/// @arg pos The position of the control object.
/// @return the client trigger object (SimObject) that is closest to the control
///         object's position, or -1 if the control object is not inside of a
///         water trigger.
/// @see updateClientWater
function findClosestWaterTrigger(%set, %pos) {
	%closestTrigger = -1;
	%checkDist = 999999;
	%count = %set.getCount();

	for (%i = 0; %i < %count; %i++) {
		%trigger = %set.getObject(%i);
		%check = VectorDist(%trigger.getWorldBoxCenter(), %pos);
		if (%check <= %checkDist) {
			%closestTrigger = %trigger;
			%checkDist = %check;
		}
	}
	return %closestTrigger;
}

/// Called to perform the overlay of the underwater shader whenever
/// the client marble or camera is underwater.
/// @arg cameraPos The camera position of the control object
/// @return true if the camera of the control object is fully submerged
///         false if it is not. It can return false even if the control object
///         is not touching any water.
/// @see updateClientWater
function performWaterOverlay(%set, %cameraPos) {
	%count = %set.getCount();
	for (%i = 0; %i < %count; %i++) {
		%trigger = %set.getObject(%i);

		// Check if the camera position is inside of the trigger we can do
		// the overlay for the water effect
		if (%trigger.isPointInside(%cameraPos)) {
			UnderwaterOL.setVisible(true);
			return true;
		}
	}

	UnderwaterOL.setVisible(false);
	return false;
}

//-----------------------------------------------------------------------------
// Bubble
//-----------------------------------------------------------------------------

function clientCmdSetBubbleTime(%time, %infinite) {
	%active = (%time > 0);
	if (!%active || %infinite || %time > $Game::BubbleTime) {
		$Game::BubbleTotalTime = %time; // total time used for determining hud image
		$Game::BubbleTime = %time; // counter
		$Game::BubbleInfinite = %infinite;
	}
	$Game::BubbleReady = %active;

	PlayGui.updateBubbleBar();
	ActivateBubble(%active);
}

function ActivateBubble(%val) {
	if (%val) {
		BubbleLoop(0);
	} else {
		BubblePop();
	}
}

//debug info: monitorThis("$Game::BubbleTime $Game::BubbleReady $Game::BubbleActive $Game::BubbleLoopActive");

function BubbleLoop(%delta) {
	if (!isObject(MissionInfo)) {
		PlayGui.updateBubbleBar();
		$Game::BubbleActive = 0;
		$Game::BubbleTime = 0;
		return;
	}
	%mouse = ($mvTriggerCount0 % 2 == 1);
	%using = ((%mouse && !$Client::ColCannon) || $Game::ForceBubble);

	if ($Game::BubbleActive) {
		//Let go of the mouse (or whatever): pops
			if (!%using) {
			BubblePop();
			return;
		}
		//Exit the water: pops
		if (!$MP::MyMarble.isInWater) {
			BubblePop();
			return;
		}
	} else {
		if ($MP::MyMarble.isInWater && %using && $Game::BubbleReady && $Game::BubbleTime > 0) {
			//play sound, grow bubble (mounted image)
			UseBubble(1);
			PlayGui.updateBubbleBar();
			$MP::MyMarble.mountImage(BubbleImage, 0);
			$Game::BubbleActive = 1;
		}
	}

	//Update UI if we're using it
	if ($Game::BubbleActive) {
		//update gui powerup info
		PlayGui.updateBubbleBar();
		//check remaining time
		if (!$Game::BubbleInfinite) {
			$Game::BubbleTime -= %delta;
		}
		if ($Game::BubbleTime <= 0) {
			$Game::BubbleReady = 1;
			BubblePop();
			alxPlay(BubblePopSfx);
			$Game::BubbleReady = 0;
			$Game::BubbleTime = 0;
		}
	}
}

function BubblePop() {
	if (MPMyMarbleExists() && ($MP::MyMarble.getMountedImage(0) == BubbleImage.getID())) {
		$MP::MyMarble.unmountImage(0);
		PlayGui.updateBubbleBar();
	}

	if (!$Game::BubbleActive || !$Game::BubbleReady) {
		return;
	}
	//play sound, play shape animation, particles
	//maybe use setDamageValue(Destroyed)
	UseBubble(0);
	$Game::BubbleActive = 0;

	commandToServer('BubbleTime', $Game::BubbleTime);
}

function UseBubble(%active) {
	if (%active) {
		Physics::pushLayerName("bubble");
	} else {
		//Deactivate bubble physics
		Physics::popLayerName("bubble");
	}
}

function BubbleSaveCP() {
	$Checkpoint::BubbleTime     = $Game::BubbleTime;
	$Checkpoint::BubbleInfinite = $Game::BubbleInfinite;
	$Checkpoint::BubbleReady    = $Game::BubbleReady;
}

function BubbleRestoreCP() {
	$Game::BubbleTime     = $Checkpoint::BubbleTime;
	$Game::BubbleInfinite = $Checkpoint::BubbleInfinite;
	$Game::BubbleReady    = $Checkpoint::BubbleReady;

	ActivateBubble($Game::BubbleTime > 0);
	PlayGui.updateBubbleBar();
}
function BubbleClearCP() {
	$Checkpoint::BubbleTime = 0;
	$Checkpoint::BubbleInfinite = 0;
	$Checkpoint::BubbleReady = 0;
}