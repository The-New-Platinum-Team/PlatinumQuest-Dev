//-----------------------------------------------------------------------------
// Marble Hats
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

function MPhatFinishAnim(%hat) {
	%hat.animating = false;
}

$HatAnimationSpeed = 5;

if (!isObject(HatSet)) {
	RootGroup.add(new SimSet(HatSet));
}

function MPupdateHats() {
	for (%i = 0; %i < HatSet.getCount(); %i ++) {
		%hat = HatSet.getObject(%i);
		%marble = %hat.marble;

		if (isObject(%marble)) {
			MPUpdateHat(%hat, %marble);
		}
	}
}

/**
 * @param {StaticShape} %hat
 * @param {Marble} %marble
 */
function MPUpdateHat(%hat, %marble) {
	%velocity = %marble.getVelocity();
	%speed = VectorLen(%velocity);
	if (%velocity !$= "0 0 0") {

		%grav = RotMultiply(%marble.getGravityRot(), "1 0 0 3.1415926535898");
		%anti = MatrixInverse("0 0 0" SPC %grav);
		%velanti = MatrixMulVector(%anti,%velocity);
		%yaw = VectorYaw(%velanti);
		%rot = "0 0 -1" SPC %yaw;
		%rot = RotMultiply(RotMultiply(%grav, "0 0 1 3.14159"), %rot);
		%tip = VectorRot(VectorAdd(VectorScale(%velocity, -1), VectorScale(%marble.getGravityDir(), 20)), %marble.getGravityDir());
		%rot = RotMultiply(%tip, %rot);

		if (strpos(%rot, "nan") != -1 || strpos(%rot, "inf") != -1 || strpos(%rot, "#") != -1) {
			%hat.setTransform(getWords(%marble.getTransform(), 0, 2) SPC getWords(%hat.getTransform(), 3, 6));
			return;
		}

		if (%speed > $HatAnimationSpeed && !%hat.waving && !%hat.animating) {
			%hat.playThread(0, "SpeedUp");
			%hat.waveSch = %hat.schedule(500, playThread, 0, "roll");
			%hat.waving = true;
			%hat.animating = true;
			schedule(500, 0, MPhatFinishAnim, %hat);
		}
		if (%speed < $HatAnimationSpeed && %hat.waving && !%hat.animating) {
			%hat.playThread(0, "SlowDown");
			cancel(%hat.waveSch);
			%hat.waving = false;
			%hat.animating = true;
			schedule(500, 0, MPhatFinishAnim, %hat);
		}

		%hat.setTransform(getWords(%marble.getTransform(), 0, 2) SPC %rot);
	}
}

/**
 * @param {StaticShape} %hat
 */
function MPFindHat(%hat, %marbleId) {
	if ($Server::Lobby)
		return;

	//Try and find the hat
	%marble = getClientSyncObject(%marbleId);

	if (isObject(%hat) && isObject(%marble)) {
		HatSet.add(%hat);
		%hat.marble = %marble;
	}
}