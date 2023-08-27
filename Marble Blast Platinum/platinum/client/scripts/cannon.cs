//-----------------------------------------------------------------------------
// Client-Side Cannon Scripts
// Matan is not allowed to look at this file. If he ever does, he can no longer
// say "this isn't cannon.cs" and have any credibility. Because this is,
// in fact, cannon.cs
// Hi Matan, if you're reading this then lmaoo get fucked by the above
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

function cannonAdded(%cannon, %base) {
	devecho("[Cannon Client]: Found cannon" SPC %cannon.getSyncId() @ ", base" SPC %base);
	$Client::Cannon[%cannon._id] = %cannon;
	$Client::Cannons = max($Client::Cannons, %cannon._id);
}

function clientCmdResetCannons(%count) {
	//Cannons start at index 1
	for (%i = 1; %i <= %count; %i ++) {
		%cannon = $Client::Cannon[%i];
		%base   = getClientSyncObject(%cannon._base);

		%yaw   = mDegToRad(%cannon.yaw);
		%pitch = -mDegToRad(%cannon.pitch);

		//Get the cannon's initial position
		%startTrans = MatrixPos(%cannon._baseTrans) SPC "1 0 0 0";
		%startTrans = MatrixMultiply(%startTrans, "0 0 0 0 0 1" SPC %yaw);

		//The base's position is found before pitch is applied
		%baseTrans = %startTrans;

		%startTrans = MatrixMultiply(%startTrans, "0 0 0 1 0 0" SPC %pitch);

		//Reset both the cannon and base
		if (isObject(%cannon))
			%cannon.setTransform(%startTrans);
		if (isObject(%base))
			%base.setTransform(%baseTrans);

		%cannon.lastYaw   = %yaw;
		%cannon.lastPitch = %pitch;
	}
	//Disable any currently active cannon
	clientCmdCancelCannon(false);
}

function checkCannons() {
	%count = $Client::Cannons;
	for (%id = 1; %id <= %count; %id ++) {
		%cannon = $Client::Cannon[%id];
		if (!isObject(%cannon)) {
			//Try to find the cannon
			%pos = MatrixPos(%cannon._baseTrans);
			devecho("[Cannon Client]: Looking for cannon" SPC %id SPC "at position (" @ %pos @ ")");
			%objs = findObjectsAtPosition(%pos, ServerConnection);
			if (%objs.getSize() > 0) {
				//We found it
				devecho("[Cannon Client]: Found cannon" SPC %id);
				for (%i = 0; %i < %objs.getSize(); %i ++) {
					%obj = %objs.getEntry(%i);
					%shape = %obj.getDataBlock().shapeFile;

					if (strPos(%shape, "base") != -1) {
						//Cannon base
						$Client::CannonBase[%id] = %obj;
						devecho("[Cannon Client]: Found cannon base:" SPC %id @ "/" @ %obj);
					} else {
						//Cannon body
						$Client::Cannon[%id] = %obj;
						devecho("[Cannon Client]: Found cannon object:" SPC %id @ "/" @ %obj);
					}
				}
			}
			%objs.delete();
		}
	}
}

function clientCmdEnterCannon(%id) {
	//Make sure that the cannon into which we're trying to enter exists
	%cannon = $Client::Cannon[%id];
	if (!isObject(%cannon)) {
		checkCannons();
	}

	// Lock powerup
	clientCmdLockPowerup(true);

	%instant = %cannon.instant;
	%useCharge = %cannon.useCharge;

	//We may hit the side of the cannon we enter, don't reset these twice
	if (!$Client::ColCannon) {
		if (!%instant) {
			setMarbleCamYaw(%cannon.lastYaw);
			setMarbleCamPitch(%cannon.lastPitch);
		}

		$Client::CannonCharge = 0;
	}
	$Client::ColCannon = %cannon;

	//Reset velocity so we don't fire incorrectly
	$MP::MyMarble.setVelocity("0 0 0");
	$MP::MyMarble.setAngularVelocity("0 0 0");

	devecho("[Cannon Client]: Entering Cannon Collided with" SPC %cannon @ "/" @ %id);

	if (%instant) {
		if (%cannon.instantDelayTime) {
			//Delay it
			echo("[Cannon Client]: Activating Instant Cannon " @ %id @ " With Delay: " @ %cannon.instantDelayTime);
			schedule(%cannon.instantDelayTime, 0, activateInstantCannon);
		} else {
			echo("[Cannon Client]: Activating Instant Cannon " @ %id);
			//Need a delay otherwise it won't shoot.
			onNextFrame(activateInstantCannon);
		}
		return;
	}

	$pitchMin = -($pi / 2);
	$pitchMax = ($pi / 2);

	$Cannon::BeforeGravity = $MP::MyMarble.getDataBlock().gravity;
	Physics::pushLayerName("frozen");

	useScriptCameraTransform(true);
	resetCameraFov();
	PlayGui.positionMessageHud();
}

function clientCmdLeaveCannon() {
	//Cancel these regardless of if we're in a cannon or not
	cancelCannonPowerupLock();
	cancelCannonMovementLock();

	if (!isObject($Client::ColCannon)) {
		return;
	}

	echo("[Cannon Client]: Leaving Cannon" SPC $Client::ColCannon);

	//If they want to wait before unlocking controls then schedule the unlock
	cannonLock();

	alxStop($Client::CannonChargeStartHandle);
	alxStop($Client::CannonChargeLoopHandle);

	$Client::ColCannon = 0;
	$Client::CannonCharge = 0;

	$pitchMin = -0.95;
	$pitchMax =  1.5;

	Physics::popLayerName("frozen");

	useScriptCameraTransform(false);
	resetCameraFov();
	PlayGui.positionMessageHud();
}

function clientCmdCancelCannon(%place) {
	//Cancel these regardless of if we're in a cannon or not
	cancelCannonPowerupLock();
	cancelCannonMovementLock();

	if (!isObject($Client::ColCannon)) {
		return;
	}

	if (%place) {
		// God seizure why
		%length = getWord($Client::ColCannon.getScale(), 1);
		%exitpos = vectorAdd(vectorScale(getUnitVector(0, getMarbleCamYaw(), 1), -1.5 * %length), $Client::ColCannon.getPosition());
		$MP::MyMarble.setTransform(%exitpos);
		$MP::MyMarble.setVelocity("0 0 0");
		$MP::MyMarble.setAngularVelocity("0 0 0");
		$MP::MyMarble.setCameraYaw(getMarbleCamYaw());
		$MP::MyMarble.setCameraPitch(0.45);
	}

	alxStop($Client::CannonChargeStartHandle);
	alxStop($Client::CannonChargeLoopHandle);

	clientCmdLockPowerup(false);

	$Client::ColCannon = 0;
	$Client::CannonCharge = 0;

	$pitchMin = -0.95;
	$pitchMax =  1.5;

	Physics::popLayerName("frozen");

	useScriptCameraTransform(false);
	resetCameraFov();
	PlayGui.positionMessageHud();
}

function cannonLock() {
	if ($Client::ColCannon.lockTime > 0) {
		Physics::pushLayerName("cannonLockControls");

		//Lock camera only if they request it
		if ($Client::ColCannon.lockCam) {
			Physics::pushLayerName("cannonLockCamera");
		}

		cancel($CannonMovementLockSchedule);
		$CannonMovementLockSchedule = schedule($Client::ColCannon.lockTime, 0, cancelCannonMovementLock);
	}

	//Lock powerup when firing
	%powerupLockTime = ($Client::ColCannon.lockTime == 0 ? 300 : $Client::ColCannon.lockTime);
	cancel($CannonPowerupLockSchedule);
	$CannonPowerupLockSchedule = schedule(%powerupLockTime, 0, cancelCannonPowerupLock);
}

function cancelCannonPowerupLock() {
	cancel($CannonPowerupLockSchedule);
	clientCmdLockPowerup(false);
}

function cancelCannonMovementLock() {
	cancel($CannonMovementLockSchedule);
	Physics::popLayerName("cannonLockControls");
	Physics::popLayerName("cannonLockCamera");
}

function cannonSetCamera(%yaw, %pitch) {
	devecho("[Cannon Client]: Setting Camera to (" @ %yaw @ ", " @ %pitch @ ")");

	//Normalize pitch for cannons
	%pitch /= 2;
	%pitch += 0.45;

	if (VectorEqual(getGravityDir(), "0 0 -1")) {
		//Correct for yaw inherent in the gravity direction
		%gravityYaw = VectorAngle("1 0 0", getWords($Game::GravityDir, 0, 2));
	} else {
		//???
		%gravityYaw = 0;
	}

	setMarbleCamYaw(%yaw + %gravityYaw);
	setMarbleCamPitch(%pitch);
}

function isCannonActive() {
	return $Client::ColCannon;
}

function activateInstantCannon() {
	%cannon = $Client::ColCannon;
	%yaw   = mDegToRad(%cannon.yaw);
	%pitch = -mDegToRad(%cannon.pitch);

	updateCannonView(0);
	finishCannonCharge();

	if (!$Game::2D)
		cannonSetCamera(%yaw, %pitch);
}

function updateCannon(%delta) {
	//Update the interface
	updateCannonView(%delta);
	updateCannonUI(%delta);

	//Update if we need to launch
	updateCannonLaunch(%delta);
}

function updateCannonLaunch(%delta) {
	%cannon = $Client::ColCannon;
	if (isObject(%cannon)) {
		//Variables from the current cannon
		%instant   = %cannon.instant;
		%useCharge = %cannon.useCharge;

		//Should we be firing?
		%mouseFire = $mouseFire;

		if (%useCharge) {
			//If we need to charge, update it
			if (%mouseFire) {
				updateCannonCharge(%delta);
			} else {
				//Don't finish when we're entering
				finishCannonCharge();
			}
		} else if (%instant) {
			//Instant cannons fire in another method
		} else  {
			//Not instant, not charging, fire when ready.
			if (%mouseFire) {
				finishCannonCharge();
			}
		}
	}
}

function updateCannonCharge(%delta) {
	%cannon = $Client::ColCannon;

	//Play audio when we start charging
	if ($Client::CannonCharge == 0) {
		$Client::CannonChargeStartHandle = alxPlay(ChargeStartSfx);
	}

	//Increase the charge
	$Client::CannonCharge += %delta;

	//Max charge
	if ($Client::CannonCharge > %cannon.chargeTime) {
		$Client::CannonCharge = %cannon.chargeTime;

		//Max charge, play the loop
		if (!alxIsPlaying($Client::CannonChargeLoopHandle)) {
			alxStop($Client::CannonChargeStartHandle);
			$Client::CannonChargeLoopHandle = alxPlay(ChargeLoopSfx);
		}
	}
}

function finishCannonCharge() {
	%cannon = $Client::ColCannon;

	//Variables from the current cannon
	%useCharge = %cannon.useCharge;
	%instant   = %cannon.instant;

	//Don't let them fire on the first frame.
	if (%useCharge) {
		if ($Client::CannonCharge) {
			//Stop charging audio
			alxStop($Client::CannonChargeStartHandle);
			alxStop($Client::CannonChargeLoopHandle);
		} else {
			return;
		}
	}

	if (%instant) {
		%yaw   =  mDegToRad(%cannon.yaw);
		%pitch = -mDegToRad(%cannon.pitch);
	} else {
		//Get marble pitch/yaw for the cannon
		%pitch = getMarbleCamPitch();
		%yaw   = getMarbleCamYaw();
	}

	%trans = "0 0 0 1 0 0 0";
	//Apply yaw and pitch rotations
	%trans = MatrixMultiply(%trans, "0 0 0 0 0 1" SPC %yaw);
	%trans = MatrixMultiply(%trans, "0 0 0 1 0 0" SPC %pitch);
	//We are shot forwards (y axis is down the barrel)
	%trans = MatrixMultiply(%trans, "0 1 0 1 0 0 0");

	//Current charge percentage
	%t = $Client::CannonCharge / %cannon.chargeTime;

	//Cannon force
	%force = %cannon.force;
	if (%cannon.useCharge) {
		%force *= %t;
	}

	echo("[Cannon Client]: Shooting marble from cannon" SPC %id);

	%start = MatrixMultiply(MatrixPos(%cannon._baseTrans), %trans);
	$MP::MyMarble.setTransform(%cannon._baseTrans);

	//Make sure we're no longer stuck in the cannon
	clientCmdLeaveCannon();

	//Fire!
	%vel = VectorScale(MatrixPos(%trans), %force);
	$MP::MyMarble.setVelocity(%vel);
	$MP::MyMarble.setAngularVelocity("0 0 0");
	echo("[Cannon Client]: Shooting marble at vel" SPC %vel);
	$Client::CannonCount ++;

	$Client::CannonCharge = 0;
	commandToServer('LeaveCannon');

	// camera is already set on instant cannons
	if (!%instant)
		cannonSetCamera(normalizeAngle(%yaw), normalizeAngle(%pitch));
}

function updateCannonView(%delta) {
	%cannon = $Client::ColCannon;
	%base = getClientSyncObject(%cannon._base);
	if (isObject(%cannon)) {
		//Pitch is always limited
		%lowBound  = mDegToRad(%cannon.pitchBoundLow);
		%highBound = mDegToRad(%cannon.pitchBoundHigh);

		%instant = %cannon.instant;

		if (!%instant) {
			//Fix the pitch/yaw
			if (getMarbleCamPitch() > -%lowBound) {
				setMarbleCamPitch(-%lowBound);
			}
			if (getMarbleCamPitch() < -%highBound) {
				setMarbleCamPitch(-%highBound);
			}
		}

		//Yaw is offset by this much
		%initialYaw = mDegToRad(%cannon.yaw);

		//Yaw is only sometimes limited
		if (%cannon.yawLimit) {
			%leftBound  = mDegToRad(%cannon.yawBoundLeft);
			%rightBound = mDegToRad(%cannon.yawBoundRight);

			//Check if they went offscreen

			//Subtract
			%finalYaw = normalizeAngle(getMarbleCamYaw() - %initialYaw);

			//Fix yaw within the bounds
			if (%finalYaw > %rightBound) {
				setMarbleCamYaw(%rightBound + %initialYaw);
			}
			if (%finalYaw < -%leftBound) {
				setMarbleCamYaw((-%leftBound + %initialYaw));
			}
		}

		%instant = %cannon.instant;
		if (%instant) {
			%yaw   = mDegToRad(%cannon.yaw);
			%pitch = -mDegToRad(%cannon.pitch);
		} else {
			//Get marble pitch/yaw for the cannon
			%yaw   = getMarbleCamYaw();
			%pitch = getMarbleCamPitch();
		}

		%cannon.lastYaw   = %yaw;
		%cannon.lastPitch = %pitch;

		//Set the cannon's transformation to the cannon's position rotated
		// around by the camera (z axis is the yaw rotation)
		%baseTrans = "0 0 0 1 0 0 0";
		%baseTrans = MatrixMultiply(%baseTrans, MatrixPos(%cannon._baseTrans));
		%baseTrans = MatrixMultiply(%baseTrans, "0 0 0 0 0 1" SPC %yaw);

		//Base is set before we apply pitch
		if (isObject(%base))
			%base.setTransform(%baseTrans);

		//Body has pitch applied (x axis is the up/down swivel)
		%bodyTrans = MatrixMultiply(%baseTrans, "0 0 0 1 0 0" SPC %pitch);
		%cannon.setTransform(%bodyTrans);

		$MP::MyMarble.setTransform(%bodyTrans);

		//Camera is moved slightly forwards in the body (y axis is down the barrel)
		%cameraTrans = MatrixMultiply(%bodyTrans, "0 " @ (0.45 * VectorLen($Client::ColCannon.getScale())) @ " 0 0 0 0 0");

		//And update the view
		$Cannon::CameraTransform = %cameraTrans;
	}
}

function updateCannonUI(%delta) {
	//Check if we have an active cannon
	%cannon = $Client::ColCannon;
	if (isObject(%cannon)) {
		//Get its color for the interface
		%reticle = %cannon.getSkinName();
		if (%reticle $= "")
			%reticle = "white";

		if (%cannon.showReticle && %cannon.showAim)
			%reticle = "mini";

		//Update these bitmaps
		PGCannonRet.setBitmap($userMods @ "/client/ui/game/cannon/ret" @ %reticle @ ".png");

		//Current charge percentage
		%t = $Client::CannonCharge / %cannon.chargeTime;

		//Charge interface
		if (%t > 0.1) {
			%img = mFloor(%t * 10);

			//Don't update more than necessary
			if ($Cannon::LastCharge == %img)
				return;
			$Cannon::LastCharge = %img;

			if (%t < 0.6) {
				//Bottom half only
				PGChargeIm3.setBitmap($userMods @ "/client/ui/game/cannon/charge_3_" @ %img @ ".png");
				PGChargeIm4.setBitmap($userMods @ "/client/ui/game/cannon/charge_4_" @ %img @ ".png");
				%zero = $userMods @ "/client/ui/game/cannon/cannon_0.png";
				PGchargeIm1.setBitmap(%zero);
				PGChargeIm2.setBitmap(%zero);
			} else {
				//Charged enough for the top half
				%img -= 5;
				PGChargeIm1.setBitmap($userMods @ "/client/ui/game/cannon/charge_1_" @ %img @ ".png");
				PGChargeIm2.setBitmap($userMods @ "/client/ui/game/cannon/charge_2_" @ %img @ ".png");
				PGChargeIm3.setBitmap($userMods @ "/client/ui/game/cannon/charge_3_5.png");
				PGChargeIm4.setBitmap($userMods @ "/client/ui/game/cannon/charge_4_5.png");
			}
		} else {
			//Uncharged or not yet charged
			%zero = $userMods @ "/client/ui/game/cannon/cannon_0.png";
			PGchargeIm1.setBitmap(%zero);
			PGChargeIm2.setBitmap(%zero);
			PGChargeIm3.setBitmap(%zero);
			PGChargeIm4.setBitmap(%zero);

			//Reset this
			$Cannon::LastCharge = 0;
		}

		//Show everything
		PGCannonRet.setVisible(%cannon.showReticle);
		PGChargeGui.setVisible(%cannon.useCharge && !%cannon.showAim);
		PGCannonExitText.setVisible(true);

		PGCannonExitText.setText("<font:24><color:ffffff>Press <func:bind useBlast> to exit cannon.");

		//updateCannonAim();
	} else {
		//Hide everything
		PGCannonRet.setVisible(false);
		PGChargeGui.setVisible(false);
		PGCannonExitText.setVisible(false);

		%zero = $userMods @ "/client/ui/game/cannon/cannon_0.png";
	}
}

function updateCannonAim(%ctrl) {
	%cannon = $Client::ColCannon;
	if (!%cannon.showAim) {
		return;
	}

	%force = %cannon.force;
	if (%cannon.useCharge) {
		%t = ($Client::CannonCharge / %cannon.chargeTime);

		//Don't show charge rings until we charge a bunch
		if (%t < 0.25)
			return;
		%force *= %t;
	}
	%radius = %cannon.aimSize;
	//If people are idiots then don't give them nice things
	if (%radius <= 0) {
		return;
	}

	%trans = "0 0 0 1 0 0 0";
	//Apply yaw and pitch rotations
	%trans = MatrixMultiply(%trans, "0 0 0 0 0 1" SPC %cannon.lastYaw);
	%trans = MatrixMultiply(%trans, "0 0 0 1 0 0" SPC %cannon.lastPitch);
	//We are shot forwards (y axis is down the barrel)
	%trans = MatrixMultiply(%trans, "0 1 0 1 0 0 0");

	//Gravity to use as the "current" because cannons activate a no-gravity layer
	if ($Client::PlayingDemo) {
		%beforeGravity = $Playback::LastPhysicsValue["gravity"];
	} else {
		%beforeGravity = $Cannon::BeforeGravity;
	}

	%initPos = %cannon.getPosition();
	%start = %initPos;
	%vel = VectorScale(MatrixPos(%trans), %force);
	%gravity = VectorScale(getGravityDir(), %beforeGravity);

	//How long each iteration will take (seconds)
	%timeStep = mClamp(%force * 0.001, $pref::CannonAimPrecision, $pref::CannonAimPrecision * 10);
	%iSteps = $pref::CannonAimIterations;

	//This is turbo slow, so provide a less precise but fast option
	if ($pref::FastMode) {
		%timeStep = mClamp(%force * 0.001, $pref::CannonAimPrecisionFast, $pref::CannonAimPrecisionFast * 10);
		%iSteps = $pref::CannonAimIterationsFast;
	}

	for (%i = 0; %i < %iSteps; %i ++) {
		if (%cannon.aimTriggers) {
			//I don't know where I'm going, but I'm on my way.
			// The road goes on forever, but the party never ends.

			//Also this style of integration is really crappy
			%vel = VectorAdd(%vel, VectorScale(%gravity, %timeStep));
			%end = VectorAdd(%start, VectorScale(%vel, %timeStep));

			//Check for entering a physmod trigger
			// only check every 10 times, it's balls slow.
			if (%i % 10 == 0) {
				%count = ClientTriggerSet.getCount();
				for (%j = 0; %j < %count; %j ++) {
					%trigger = ClientTriggerSet.getObject(%j);

					if (%trigger.isPointInside(%end)) {
						if (!%inTrigger[%trigger]) {
							%inTrigger[%trigger] = true;
							for (%k = 0; %trigger.marbleAttribute[%k] !$= ""; %k ++) {
								if (%trigger.marbleAttribute[%k] $= "gravity") {
									%gravity = VectorScale(getGravityDir(), %trigger.value[%k]);
									%beforeGravity = %beforeGravity;
								}
							}
						}
					} else if (%inTrigger[%trigger]) {
						%inTrigger[%trigger] = false;
						for (%k = 0; %trigger.marbleAttribute[%k] !$= ""; %k ++) {
							if (%trigger.marbleAttribute[%k] $= "gravity") {
								%gravity = %beforeGravity;
							}
						}
					}
				}
			}
		} else {
			//Non-trigger based so we can just assume gravity is constant. This makes
			// the code a lot faster.

			//x = x_0 + v_0 * t + 0.5 * a * t * t
			%start = VectorAdd(VectorAdd(%initPos, VectorScale(%vel, %i * %timeStep)), VectorScale(%gravity, 0.5 * mPow(%i * %timeStep, 2)));
			%end = VectorAdd(VectorAdd(%initPos, VectorScale(%vel, (%i + 1) * %timeStep)), VectorScale(%gravity, 0.5 * mPow((%i + 1) * %timeStep, 2)));
		}

		//Check if we've hit the ground and stop there
		%cast = ClientContainerRayCast(%start, %end, $TypeMasks::StaticShapeObjectType | $TypeMasks::InteriorObjectType);
		if (%cast) {
			%end = getWords(%cast, 1, 3);
		}

		%positions[%i] = %end;
		%normals[%i] = VectorSub(%end, %start);

		%start = %end;

		if (%cast) {
			//Normal is relative to the object we hit
			%hit = getWord(%cast, 0);
			%normal = MatrixMulVector(%hit.getTransform(), getWords(%cast, 4, 6));

			//Draw the ground normal because sure why not
			%ctrl.renderCircle(getWords(%cast, 1, 3), %normal, %radius, 40, "0 255 0", 2);
			%stepCount = %i;
			break;
		}
	}
	if (%i == %iSteps) {
		%stepCount = %iSteps;
	}

	%circleCount = 12;

	//Render a set number of circles
	for (%i = 0; %i < %circleCount; %i ++) {
		%index = mFloor(%i * %stepCount / %circleCount);
		%position = %positions[%index];
		%normal = %normals[%index];

		//Render circles to show where we're aiming
		%progress = mClamp(%i / %circleCount, 0, 1);
		%color = hsvToRgb(%progress * 60, 1, 1) SPC "255";

		%ctrl.renderCircle(%position, %normal, %radius, 40, %color, 2);
	}
}

//-----------------------------------------------------------------------------
// Audio Profiles
//-----------------------------------------------------------------------------

new AudioProfile(ChargeLoopSfx) {
	fileName = "~/data/sound/charge_loop.ogg";
	description = ClientAudioLooping2D;
	preload = true;
};

new AudioProfile(ChargeStartSfx) {
	fileName = "~/data/sound/charge_start.ogg";
	description = AudioGui;
	preload = true;
};
