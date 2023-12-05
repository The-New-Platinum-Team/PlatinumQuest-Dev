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


datablock StaticShapeData(WaterPlane) {
	category = "Water";
	className = "Water";
	shapeFile = "~/data/shapes_pq/Gameplay/water.dts";

	emap = false;
	animation = false;
	isScaled = false;
};

datablock StaticShapeData(WaterCylinder : WaterPlane) {
	shapeFile = "~/data/shapes_pq/Other/CylinderWater.dts";
	animation = true;
	isThin = true;
};

datablock StaticShapeData(WaterCylinder_slow : WaterPlane) {
	shapeFile = "~/data/shapes_pq/Other/CylinderWater_slow.dts";
	animation = true;
	isScaled = true;
};

datablock TriggerData(WaterPhysicsTrigger) {
	tickPeriod = 100;

	customField[0, "field"  ] = "VelocityMultiplier";
	customField[0, "type"   ] = "float";
	customField[0, "name"   ] = "Velocity Multiplier";
	customField[0, "desc"   ] = "Multiply marble velocity by this factor when entering the water trigger.";
	customField[0, "default"] = "0.5";
};

function WaterPhysicsTrigger::onAdd(%this, %obj) {
	// Changes velocity of the marble whenever you are under water
	if (%obj.VelocityMultiplier $= "")
		%obj.VelocityMultiplier = 0.5;

	%obj.setSync("onReceiveTrigger");
}

function Water::onAdd(%this, %obj) {
	// water animations.
	if (%this.animation)
		%obj.playThread(0, "ambient");

	// If the isThin property is flagged, that means that the z axis scale is small.
	if (%this.isScaled) {
		%scale = getWords(%obj.getScale(), 0, 1) SPC "0.0001";
		%obj.setScale(%scale);
	}
}

function serverCmdWaterSplash(%client, %datablock, %position) {
	%particleEffect = new ParticleEmitterNode() {
		datablock = FireWorkNode;
		emitter = %datablock;
		position = %position;
		rotation = "1 0 0 0";
		scale = "1 1 1";
	};
	MissionCleanup.add(%particleEffect);

	//Ruin their fireball's day
	if (%client.player._fireballActive) {
		%client.play2d(fireballSizzleSfx);
		%client.setFireballTime(0);
		%client.fireballExpire();
	}

	// TODO: what if we already clean up the mission before it deletes?
	// will it crash, will it just fail and do it, or does it clean it up?
	%particleEffect.schedule(1000, delete);
}

function WaterPhysicsTrigger::onEnterTrigger(%this, %trigger, %obj) {
	%obj.inWater = true;
}
function WaterPhysicsTrigger::onLeaveTrigger(%this, %trigger, %obj) {
	%obj.inWater = false;
}