//-----------------------------------------------------------------------------
// Gravity stuff
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

function setGravityVector(%newDown, %instant) {
	//Thanks to Whirligig for the help
	%oldGravity = $Game::GravityDir;
	%oldRight = getWords(%oldGravity, 0, 2);
	%oldBack = getWords(%oldGravity, 3, 5);
	%oldDown = getGravityDir();

	%cross = VectorCrossSpecial(%oldDown, %newDown);
	%axis = VectorNormalize(%cross);
	%angle = VectorAngle(%oldDown, %newDown);

	//Make sure the angle is good
	if (%angle !$= "nan" && strpos(%angle, "IND") == -1 && VectorLen(%cross) > 0.001) {
		%newRight = VectorRotate(%oldRight, %axis, %angle);
		%newBack = VectorRotate(%oldBack, %axis, %angle);

		%newGravity = %newRight SPC %newBack SPC %newDown;
		clientCmdSetGravityDir(%newGravity, %instant, RotationFromOrtho(%newGravity));
	}
}

function clientCmdSetGravityDir(%dir, %instant, %rotation) {
	if ($playingDemo && !$Playback::DemoFrame) {
		return;
	}
	//Update if instant so we change rotation of the ortho even if the gravity doesn't
	if (%instant || !orthoCompare($Game::GravityDir, %dir)) {
		$Game::LastGravityDir = %dir;
		$Game::GravityDir = %dir;
		$Game::GravityRot = %rotation;
		setGravityDir(%dir, %instant);
		calcGravityUV();
	}

	if ($Record::Recording) {
		recordWriteGravity(RecordFO, %instant);
	}
}

//-----------------------------------------------------------------------------
// Gravity triggers and the like, from PQ
//-----------------------------------------------------------------------------

function GravityTrigger_shouldTriggerForPlayer(%this, %trigger, %player) {
	return (MPMyMarbleExists() && %player.getId() == MPGetMyMarble().getId());
}

function GravityTrigger_onClientEnterTrigger(%this, %trigger, %user) {
	Gravity::onClientEnterTrigger(%trigger, %user);
}

function GravityTrigger_onClientStayTrigger(%this, %trigger, %user) {
	//Nothing
}

function GravityTrigger_onClientLeaveTrigger(%this, %trigger, %user) {
	Gravity::onClientLeaveTrigger(%trigger, %user);
}

function GravityTrigger_getDistance(%this, %trigger, %player) {
	return 0;
}

function GravityTrigger_getRadius(%this, %trigger, %player) {
	return -1;
}

function GravityTrigger_onPlayerEnter(%this, %trigger, %player) {
	if (!%trigger.onLeave) {
		%ppos = %player.getWorldBoxCenter();
		%newDown = GravityTrigger_getDownVector(%this, %trigger, %ppos);
		setGravityVector(%newDown, true);
	}
}

function GravityTrigger_onPlayerLeave(%this, %trigger, %player) {
	if (%trigger.onLeave) {
		%ppos = %player.getWorldBoxCenter();
		%newDown = GravityTrigger_getDownVector(%this, %trigger, %ppos);
		setGravityVector(%newDown, true);
	}
}

function GravityTrigger_getDownVector(%this, %trigger, %point) {
	%tweaked = getWords(%trigger.simrotation, 0, 2) SPC mDegToRad(getWord(%trigger.simrotation, 3));
	%ortho = vectorOrthoBasis(%tweaked);
	return getWords(%ortho, 6);
}

function GravityTrigger_onPlayerUpdate(%this, %trigger, %player) {
	//Nothing
}

//-----------------------------------------------------------------------------

function AlterGravityTrigger_shouldTriggerForPlayer(%this, %trigger, %player) {
	return (MPMyMarbleExists() && %player.getId() == MPGetMyMarble().getId());
}

function AlterGravityTrigger_onClientEnterTrigger(%this, %trigger, %user) {
	Gravity::onClientEnterTrigger(%trigger, %user);
}

function AlterGravityTrigger_onClientStayTrigger(%this, %trigger, %user) {
	//Nothing
}

function AlterGravityTrigger_onClientLeaveTrigger(%this, %trigger, %user) {
	Gravity::onClientLeaveTrigger(%trigger, %user);
}

function AlterGravityTrigger_getDistance(%this, %trigger, %player) {
	return 0;
}

function AlterGravityTrigger_getRadius(%this, %trigger, %player) {
	return -1;
}

function AlterGravityTrigger_onPlayerEnter(%this, %trigger, %player) {

}

function AlterGravityTrigger_onPlayerLeave(%this, %trigger, %player) {
	switch$ (%trigger.GravityAxis) {
	case "x":
		%gdim = 0;
	case "y":
		%gdim = 1;
	case "z":
		%gdim = 2;
	}
	%rot = $AG::ClosestRot;
	%rotation = "0 0 0" SPC -mDegToRad(%rot);
	%newRot = setWord(%rotation, %gdim, 1);
	%ortho = vectorOrthoBasis(%newRot);
	setGravityVector(getWords(%ortho, 6), true);
}

function AlterGravityTrigger_getDownVector(%this, %trigger, %point) {
	//get the lowest bound of the trigger
	switch$ (%trigger.MeasureAxis) {
	case "x":
		%dim = 0;
	case "y":
		%dim = 1;
	case "z":
		%dim = 2;
	}
	switch$ (%trigger.GravityAxis) {
	case "x":
		%gdim = 0;
	case "y":
		%gdim = 1;
	case "z":
		%gdim = 2;
	}

	%m = getWord(%point, %dim);

	%lowbound = getWord(%trigger.getPosition(), %dim) + (%trigger.FlipMeasure * -2 * getRadius(%trigger.MeasureAxis, %trigger));
	%totaldist = getRadius(%trigger.MeasureAxis, %trigger) * 2;

	//start measuring from the low bound

	%diff = %m - %lowbound;
	%fraction = %diff / %totaldist;
	if (%trigger.FlipMeasure)
		%fraction -= 1;
	%fraction = mAbs(%fraction);

	//echo(%diff SPC %totaldist SPC %fraction);
	$AG::ClosestRot = (%trigger.EndingGravityRot - %trigger.StartingGravityRot) * mRound(%fraction) + %trigger.StartingGravityRot;
	//calculate rotation

	if (%fraction <= 1.0 && %fraction >= 0) { //don't allow extra values outside marble center in trig
		%rot = (%trigger.EndingGravityRot - %trigger.StartingGravityRot) * %fraction + %trigger.StartingGravityRot;
	} else {
		%rot = $AG::ClosestRot;
	}


	%rotation = "0 0 0" SPC -mDegToRad(%rot);
	%newRot = setWord(%rotation, %gdim, 1);
	%ortho = vectorOrthoBasis(%newRot);

	return getWords(%ortho, 6);
}

function AlterGravityTrigger_onPlayerUpdate(%this, %trigger, %player) {
	%ppos = %player.getWorldBoxCenter();
	%newDown = AlterGravityTrigger_getDownVector(%this, %trigger, %ppos);
	setGravityVector(%newDown, true);
}

//-----------------------------------------------------------------------------

function GravityWellTrigger_shouldTriggerForPlayer(%this, %trigger, %player) {
	return (MPMyMarbleExists() && %player.getId() == MPGetMyMarble().getId());
}

function GravityWellTrigger_onClientEnterTrigger(%this, %trigger, %user) {
	Gravity::onClientEnterTrigger(%trigger, %user);
}

function GravityWellTrigger_onClientStayTrigger(%this, %trigger, %user) {
	//Nothing
}

function GravityWellTrigger_onClientLeaveTrigger(%this, %trigger, %user) {
	Gravity::onClientLeaveTrigger(%trigger, %user);
}

function GravityWellTrigger_getDistance(%this, %trigger, %player) {
	//Trigger fields if specified, defaults otherwise
	%radius = (%trigger.useRadius ? %trigger.RadiusSize : -1);
	%center = (getWordCount(%trigger.custompoint) == 3 ? %trigger.custompoint : %trigger.getWorldBoxCenter());

	//How far are we?
	%objCenter = %player.getWorldBoxCenter();
	%off = VectorSub(%center, %objCenter);
	switch$ (%trigger.axis) {
	case "x":
		%off = setWord(%off, 0, 0);
	case "y":
		%off = setWord(%off, 1, 0);
	case "z":
		%off = setWord(%off, 2, 0);
	}
	%dist = VectorLen(%off);

	//If we're not within radius, don't even try
	return (%radius == -1 ? %dist : (%dist > %radius ? -1 : %dist));
}

function GravityWellTrigger_getRadius(%this, %trigger, %player) {
	return (%trigger.useRadius ? %trigger.RadiusSize : -1);
}

function GravityWellTrigger_onPlayerEnter(%this, %trigger, %player) {
	if (%trigger.RestoreGravity) {
		$GW::RestoreGravity = $Game::GravityRot;
	}
}

function GravityWellTrigger_onPlayerLeave(%this, %trigger, %player) {
	if (%trigger.RestoreGravity !$= "") {
		if (%trigger.RestoreGravity $= "1") {
			%grav = $GW::RestoreGravity;
		} else {
			%grav = getWords(%trigger.RestoreGravity, 0, 2) SPC mDegToRad(getWord(%trigger.RestoreGravity, 3));
		}

		%down = getWords(VectorOrthoBasis(%grav), 6);

		setGravityVector(%down, true);
	}
}

function GravityWellTrigger_getDownVector(%this, %trigger, %point) {
	if (getWordCount(%trigger.custompoint) == 3)
		%tpos = %trigger.custompoint;
	else
		%tpos = %trigger.getWorldBoxCenter();
	%invert = %trigger.invert;

	%off = VectorSub(%point, %tpos);
	switch$ (%trigger.axis) {
	case "x":
		%vec = 0 SPC getWord(%off, 1) SPC getWord(%off, 2);
	case "y":
		%vec = getWord(%off, 0) SPC 0 SPC getWord(%off, 2);
	case "z":
		%vec = getWord(%off, 0) SPC getWord(%off, 1) SPC 0;
	}

	return VectorNormalize(!%invert ? VectorScale(%vec, -1) : %vec);
}

function GravityWellTrigger_onPlayerUpdate(%this, %trigger, %player) {
	%ppos = %player.getWorldBoxCenter();
	%newDown = GravityWellTrigger_getDownVector(%this, %trigger, %ppos);
	setGravityVector(%newDown, true);
}

//-----------------------------------------------------------------------------

function GravityPointTrigger_shouldTriggerForPlayer(%this, %trigger, %player) {
	return (MPMyMarbleExists() && %player.getId() == MPGetMyMarble().getId());
}

function GravityPointTrigger_onClientEnterTrigger(%this, %trigger, %user) {
	Gravity::onClientEnterTrigger(%trigger, %user);
}

function GravityPointTrigger_onClientStayTrigger(%this, %trigger, %user) {
	//Nothing
}

function GravityPointTrigger_onClientLeaveTrigger(%this, %trigger, %user) {
	Gravity::onClientLeaveTrigger(%trigger, %user);
}

function GravityPointTrigger_getDistance(%this, %trigger, %object) {
	//Trigger fields if specified, defaults otherwise
	%radius = (%trigger.useRadius ? %trigger.RadiusSize : -1);
	%center = (getWordCount(%trigger.custompoint) == 3 ? %trigger.custompoint : %trigger.getWorldBoxCenter());

	//How far are we?
	%objCenter = %object.getWorldBoxCenter();
	%dist = VectorDist(%center, %objCenter);

	//If we're not within radius, don't even try
	return (%radius == -1 ? %dist : (%dist > %radius ? -1 : %dist));
}

function GravityPointTrigger_getRadius(%this, %trigger, %object) {
	return (%trigger.useRadius ? %trigger.RadiusSize : -1);
}

function GravityPointTrigger_onPlayerEnter(%this, %trigger, %object) {

}

function GravityPointTrigger_getDownVector(%this, %trigger, %point) {
	if (getWordCount(%trigger.custompoint) == 3)
		%center = %trigger.custompoint;
	else
		%center = %trigger.getWorldBoxCenter();

	//Calculate gravity angle
	%dist = VectorSub(%point, %center);
	%dist = VectorNormalize(%dist);
	return VectorNormalize((%trigger.invert ? VectorSub(%point, %center) : VectorSub(%center, %point)));
}

function GravityPointTrigger_onPlayerUpdate(%this, %trigger, %object) {
	%pos = %object.getPosition();
	%newDown = GravityPointTrigger_getDownVector(%this, %trigger, %pos);
	setGravityVector(%newDown, true);
}

function GravityPointTrigger_onPlayerLeave(%this, %trigger, %object) {
	if (getWordCount(%trigger.custompoint) == 3)
		%center = %trigger.custompoint;
	else
		%center = %trigger.getWorldBoxCenter();

	%pos = %object.getPosition();

	//Calculate gravity angle
	%dist = VectorSub(%pos, %center);

	if (%trigger.UpDownLeave) {
		if (getWord(%dist, 2) > 0)
			%down = "0 0 -1";
		else
			%down = "0 0 1";

		setGravityVector(%down, true);
	}
}

//-----------------------------------------------------------------------------

function Gravity::clearTriggers(%user) {
	deleteVariables("$Gravity::Trigger*");
	deleteVariables("$Gravity::LastTrigger*");
}

function Gravity::onClientEnterTrigger(%trigger, %user) {
	if (!%trigger.shouldTriggerForPlayer(%user))
		return;
	//Don't set null triggers
	if ($Gravity::Triggers[%user] $= "")
		$Gravity::Triggers[%user] = 0;
	$Gravity::Trigger[%user, $Gravity::Triggers[%user]] = %trigger;
	$Gravity::Triggers[%user] ++;
}

function Gravity::onClientLeaveTrigger(%trigger, %user) {
	if (!%trigger.shouldTriggerForPlayer(%user))
		return;
	for (%i = 0; %i < $Gravity::Triggers[%user]; %i ++) {
		if ($Gravity::Trigger[%user, %i] == %trigger) {
			for (%j = %i; %j < $Gravity::Triggers[%user]; %j ++) {
				$Gravity::Trigger[%user, %j] = $Gravity::Trigger[%user, %j + 1];
			}
			$Gravity::Triggers[%user] --;
			break;
		}
	}
}

function Gravity::getClosestTrigger(%user) {
	//Start with -1 so we have default values
	%closest = -1;
	%closestDist = -1;

	//Find the closest trigger to our marble
	for (%i = 0; %i < $Gravity::Triggers[%user]; %i ++) {
		%trigger = $Gravity::Trigger[%user, %i];

		//If the trigger no longer exists, we need to remove it
		if (!isObject(%trigger)) {
			//Remove the trigger
			Gravity::onClientLeaveTrigger(%trigger, %user);

			//Restart this iteration
			%i --;
			continue;
		}

		%distance = %trigger.getDistance(%user);

		//Don't apply triggers we can't deal with
		if (%distance $= "")
			continue;
		//Out of range
		if (%distance == -1)
			continue;

		//We're closer if there was no previous trigger or our distance is less
		%closer = (%closestDist == -1 || %distance < %closestDist);

		//If we have the same distance, the two triggers have the same origin. Do some radius checking
		if ((%distance - %closestDist) * (%distance - %closestDist) < 0.0001) {
			%triggerRad = %trigger.getRadius(%user);
			%closestRad = %closest.getRadius(%user);

			//If they have a larger radius then we are closer.
			//If their radius is infinite and ours is not, then we're closer too.
			//If our radius is infinite and theirs isn't, they're closer.
			//If both are infinite, they always win.
			if (%closestRad == -1 && %triggerRad != -1 || (%triggerRad != -1 && %triggerRad < %closestRad)) {
				%closer = true;
			}
		}

		//If we are closer, replace them
		if (%closer) {
			%closest = %trigger;
			%closestDist = %distance;
		}
	}
	return %closest;
}

function Gravity::update() {
	%player = MPGetMyMarble();
	%trigger = Gravity::getClosestTrigger(%player);

	if (isObject(%trigger)) {
		//If this is a new trigger, we should let it know we've entered
		if ($Gravity::LastTrigger[%player] != %trigger) {
			$Gravity::LastTrigger[%player] = %trigger;
			%trigger.onPlayerEnter(%player);
		}
		%trigger.onPlayerUpdate(%player);
	} else {
		//If this was the last trigger we left, we should send it an exit message
		if (isObject($Gravity::LastTrigger[%player])) {
			$Gravity::LastTrigger[%player].onPlayerLeave(%player);
			$Gravity::LastTrigger[%player] = 0;
		}
	}
}
