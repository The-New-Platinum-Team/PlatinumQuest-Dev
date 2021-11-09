//-----------------------------------------------------------------------------
// miscFunctions.cs
//
// Copyright (c) 2009 The Platinum Team
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

//String definitions
//------------

// this variable defines the min. speed for the trail emitter
// This is in this file because it needs to be executed on both
// the client and the server side.
$TrailEmitterSpeed = 10;
$TrailEmitterWhiteSpeed = 30;

// important math variables actually used in code
$pi = 3.141592653589793238462643383279502884;
$tau = $pi * 2;
$sqrt_2 = mSqrt(2);
$e = 2.71828182846;
$pi2 = 2 * $pi;
$pi_2 = $pi / 2;
$pi3_2 = ($pi * 3) / 2;
$pi_180 = $pi / 180;

//-------------------------------------------------------------------------------------
// General use functions
//------------

//-------------------------------------------------------------------------------------

function pythag(%a, %b) { //Pythagorean theorem
	return mSqrt(mPow(%a, 2) + mPow(%b, 2));
}

//-------------------------------------------------------------------------------------

function getRadius(%dim, %object) { //get x/y/z radius of an object's bounding box
	if (%dim $= "x") {
		%word = 0;
	}
	if (%dim $= "y") {
		%word = 1;
	}
	if (%dim $= "z") {
		%word = 2;
	}
	%str = %object.getWorldBox();
	%radius = (mAbs(getword(%str, %word) - getword(%str, %word+3))/2);
	return %radius;
}

//-------------------------------------------------------------------------------------

function isNumber(%str)  //tests whether a string is a number
{
  if (%str > 0 || %str < 0)
    return true;
  else if (%str $= "0")
    return true;
  else
    return false;
}

function getBaseName(%name, %flag) //strip trailing numbers from string; alternatively, insert a space between basename and number
{
  %len = strlen(%name);
  %i = 0;
  while (isNumber(getSubStr(%name, %len - 1 - %i, 1)))
  {
    %pos = %len - %i - 1;
    %i++;
  }
  %basename = getSubStr(%name, 0, %pos);
  if (!%flag)
    return %basename;

  %combined = %basename SPC getSubStr(%name, %pos, 65535);
  return %combined;
}

//-------------------------------------------------------------------------------------

//Find unit vector based on given pitch and yaw
//Used in cannon velocity calculation

function getUnitVector(%pitch, %yaw, %inv) {
	if (%pitch == 0)
		%temp = 1;
	else
		%temp = mcos(%pitch);


	%X += mcos(%yaw) * %temp;
	%Y += msin(%yaw) * %temp;
	%Z -= msin(%pitch);   //credit: MikeTacular at gamedev.net forums

	if (%inv)
		return %Y SPC %X SPC %Z;
	else
		return %X SPC %Y SPC %Z;
}

//-------------------------------------------------------------------------------------

function measureAngle(%a1, %a2, %rad) { //return angle measurement under 180 degrees (rad optional), may need tweaked
	if (%rad) {
		%a1 += $pi2;
		%a2 += $pi2;

		%angle = $pi2;
	} else {
		%a1 += 720;
		%a2 += 720;

		%angle = 360;
	}
	%first = mAbs(%a1 - %a2);
	%second = mAbs(%a1 + %angle - %a2);
	%third = mAbs(%a2 + %angle - %a1);

	if (mAbs(%a1 - %a2) < %angle / 2) //our first choice, if we aren't going over 180 degrees of measurement
		return mAbs(%a1 - %a2);

	//echo(%third);
	//echo(%second);
	//echo(%first);

	if (mAbs(%a1 - %a2) > %angle / 2) { //if angle is greater than 180 or pi
		if (%a1 > %a2)
			return %third;
		else
			return %second;
	} else
		return %first;

}

function CompareAngles(%a1, %a2, %var, %rad) { //if angles are within variance, return true, else false; 4th field is use radians flag
	if (%var <= mAbs(MeasureAngle(%a1, %a2, %rad)))
		return true;
	else
		return false;
}

//-------------------------------------------------------------------------------------

//apply a series of rotations, can be used to rotate existing rotation about global axes
//or to apply rotation to local axes

function applyrotations(%r1, %r2, %r3, %r4) {
	%i = 1;
	while (true) {
		if (%i == 1)
			%blah = %r1;
		if (%i == 2)
			%blah = %r2;  //messy, but %r[%i] won't work
		if (%i == 3)
			%blah = %r3;
		if (%i == 4)
			%blah = %r4;
		if (%blah $= "") break;
		//echo(%blah);
		if (getWordCount(%blah) == 3)
			%blah = rotEtoAA(%blah, 1);
		%q = rotAAtoQ(%blah);

		if (%qtotal $= "")
			%qtotal = %q;
		else
			%qtotal = rotQmultiply(%qtotal, %q);

		//echo(%qtotal);

		%i++;
		if (%i > 5) break;
	}
	%finalrot = rotQtoAA(rotQnormalize(%qtotal));
	//echo(%finalrot);
	return %finalrot;
}

function SceneObject::getRotation(%this) {
	return getWords(%this.getTransform(), 3, 6);
}

//-------------------------------------------------------------------------------------

function c() { // Crash - can be used as hack repellant
	%a=1%0;
}

function d() { // SUDDENLY DESKTOP
	d();
}

//-------------------------------------------------------------------------------------

function exec2(%name, %noCalls) { // Find and exec script by base name only (execs gui / cs multiples, exact name/extension copies will fail)
	%noCalls = !!%noCalls;
	%t = 0;

	%toexec = FindNamedFile(%name, ".cs");
	if (%toexec !$= "") {
		exec(%toexec, %noCalls);
		%t++;
	}

	%toexec = FindNamedFile(%name, ".gui");
	if (%toexec !$= "") {
		exec(%toexec, %noCalls);
		%t++;
	}
	if (%t == 0) {
		error("Script not found: " @ %name @ " cs/gui");
		return false;
	}
	return true;
}

function rescanPaths() {
	setModPaths($modPath);
}

function timeSinceLoad() {
	return formattime(getSimTime());
}

//-------------------------------------------------------------------------------------

function Sun::onAdd(%this, %run) {
	if (!%run) {
		%this.schedule(250, "onAdd", 1);
		return;
	}

	if (%this.getName() $= "") {
		for (%i = 1; isObject("Sun" @ %i); %i++)
			%a = 1;
		%this.setName("Sun" @ %i);
		if (isObject(MissionData))
			MissionData.add(%this);
	}
}

//-------------------------------------------------------------------------------------

function bumpMissionGroup(%grp) {
	%mg = MissionGroup;
	%mg.bringtoFront(%grp);
	if (!isObject(MissionData)) {
		schedule(200, 0, "buildMDataGroup");
	} else
		%mg.bringtoFront(MissionData);
}

function buildMDataGroup() {
	if (isObject(MissionData) || !$Game::Running)
		return;

	%mg = MissionGroup;
	new SimGroup(MissionData);
	%md = MissionData;

	%mg.add(MissionData);
	%md.schedule(100, add, MissionInfo);
	for (%i = 1; isObject("Sun" @ %i); %i++)
		%md.schedule(100, add, "Sun" @ %i);
	%md.schedule(100, add, Sky);
	%md.schedule(100, add, MissionArea);
}

//-------------------------------------------------------------------------------------

function useMyMarbleCamera() {
	return !isCannonActive() && MPMyMarbleExists();
}

function getMarbleCamYaw() {
	if (useMyMarbleCamera()) {
		$cameraYaw = MPGetMyMarble().getCameraYaw();
	}
	return $cameraYaw;
}

function getMarbleCamPitch() {
	if (useMyMarbleCamera()) {
		$cameraPitch = MPGetMyMarble().getCameraPitch();
	}
	return $cameraPitch;
}
function setMarbleCamYaw(%yaw) {
	if (useMyMarbleCamera())
		MPGetMyMarble().setCameraYaw(%yaw);
	$cameraYaw = %yaw;
}
function setMarbleCamPitch(%pitch) {
	if (useMyMarbleCamera())
		MPGetMyMarble().setCameraPitch(%pitch);
	$cameraPitch = %pitch;
}

function calcGravityUV() {
	%uv = rottoVector($Game::GravityRot, "0 0 1");
	if (getWord(%uv, 2) $= "-1")
		%uv = "0 0 -1";
	$Game::GravityUV = %uv;

	calcGRot();
}

function calcGRot() {
	$GRot = rotAAtoQ($Game::GravityRot);
	$GRotI = rotQinvert($GRot);
}

//-------------------------------------------------------------------------------------

function normalOfGravity(%gravity) {
	%vec = rottoVector(%gravity, "0 0 -1");
	return %vec;
}

//-----------------------------------------------------------------

function spawnEmitter(%time, %db, %position, %parentto) {
	if (%time $= "") %time = 1000;
	if (!isObject(%db))
		return;
	%obj = new ParticleEmitterNode() {
		datablock = FireWorkNode;
		emitter = %db;
		position = %position;
	};
	MissionCleanup.add(%obj);
	%obj.setScopeAlways();
	%obj.schedule(%time, "delete");

	if (isObject(%parentto))
		%obj.setParent(%parentto);
}

//-----------------------------------------------------------------

function Marble::getEstCameraTransform(%this) {
	if (!isObject(%this))
		return "0 0 0 1 0 0 0";

	//Get their camera settings
	%pitch = %this.getCameraPitch();
	%yaw = %this.getCameraYaw();

	// AA matrices for yaw and pitch
	%vec1 = "0 0 0 0 0 1" SPC %yaw;
	%vec2 = "0 0 0 1 0 0" SPC %pitch;

	// GravityRot is the down direction, rotate that to face upwadrs
	%upVec = MatrixMultiply("0 0 0" SPC %this.getGravityRot(), "0 0 0 1 0 0" SPC $pi);

	// Multiply yaw * pitch for the complete rotation
	%rotation = MatrixMultiply(%vec1, %vec2);
	// Apply gravity to the rotation. Apply it first so we pitch/yaw in respect
	// to the gravity direction.
	%rotation = MatrixMultiply(%upVec, %rotation);

	// Camera is 2.5 units back from the marble
	%ortho = MatrixMulPoint(%rotation, "0" SPC %this.getDatablock().cameraDistance SPC -%this.getCollisionRadius());

	// Where we start the raycast
	%startPos = MatrixPos(%this.getTransform());
	// Final camera position if nothing is hit
	%interPos = VectorSub(%startPos, %ortho);

	// Check for collision
	%cast = clientContainerRayCast(%startPos, %interPos, $TypeMasks::InteriorObjectType);
	if (%cast) {
		//Set position to the wall
		%interpos = getWords(%cast, 1, 3);

		//Add 0.1 units so walls don't clip quite so bad
		%interpos = VectorAdd(%interpos, VectorScale(VectorNormalize(VectorSub(%endPos, %interpos)), 0.1));
	}
	// Apply rotation to position
	%transform = MatrixMultiply(%interPos SPC "1 0 0 0", %rotation);

	return %transform;
}

function normalizeAngle(%angle) {
	if (%angle > $pi)
		%angle -= $tau;
	if (%angle < -$pi)
		%angle += $tau;
	return %angle;
}

function strrpos(%haystack, %needle) {
	%index = strpos(%haystack, %needle);
	%testindex = strpos(%haystack, %needle, %index + 1);
	while (%testindex != -1) {
		%index = %testindex;
		%testindex = strpos(%haystack, %needle, %index + 1);
	}
	return %index;
}