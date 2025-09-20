//-----------------------------------------------------------------------------
// physMod.cs
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

/// The amount of particle emitters and bases for each trigger, if they have
/// particle emitters.
$PhysModParticleEmitterCountPerTrigger = 4;

datablock TriggerData(MarblePhysModTrigger) {
	tickPeriodMS = 10;

	customField[0, "field"  ] = "noEmitters";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Disable Emitters";
	customField[0, "desc"   ] = "If the trigger should not spawn any emitters.";
	customField[0, "default"] = "0";
};

datablock StaticShapeData(PhysModEmitterBase) {
	className = "Other";
	category = "Other";
	shapeFile = "~/data/shapes_pq/Other/physModEmitterBase.dts";

	fxDatablock[0] = "PhysModEmitterNode";
	fxEmitter[0] = "PhysModEmitter";
	fxSkin[0] = true;
};

datablock ParticleData(PhysModParticle) {
	dragCoefficient = 1;
	windCoefficient = 0;
	gravityCoefficient = -0.2;
	inheritedVelFactor = 0;
	constantAcceleration = 0;
	lifetimeMS = 6000;
	lifetimeVarianceMS = 0;
	spinSpeed = 10;
	spinRandomMin = 0;
	spinRandomMax = 0;
	useInvAlpha = false;
	textureName = "platinum/data/particles/orb";

	colors[0] = "1 1 1 1";
	colors[1] = "0.5 0.5 1 0.75";
	colors[2] = "0 0 1 0.25";

	sizes[0] = 1;
	sizes[1] = 2;
	sizes[2] = 5;

	times[0] = 1;
	times[1] = 1.5;
	times[2] = 2;
};

datablock ParticleEmitterData(PhysModEmitter) {
	ejectionPeriodMS = 150;
	periodVarianceMS = 5;
	ejectionVelocity = 1.5;
	velocityVariance = 0.25;
	ejectionOffset = 0;
	thetaMax = 11.25;
	thetaMin = -11.25;
	phiReferenceVel = 0;
	phiVariance = 360;
	overrideAdvance = false;
	orientParticles = false;
	orientOnVelocity = false;
	particles = "PhysModParticle";
	lifetimeMS = 0;
	lifetimeVariance = 0;
	noHide = 1;
};

datablock ParticleEmitterNodeData(PhysModEmitterNode) {
	timeMultiple = 1;
};

//-----------------------------------------------------------------------------

/// Callback from the engine whenever a physmod trigger is added.
/// @arg this The datablock of the physmod trigger
/// @arg obj The trigger instance
function MarblePhysModTrigger::onAdd(%this, %obj) {
	//compatibility - convert the data storage strings
	if (%obj.marbleAttribute !$= "") {
		%obj.marbleAttribute[0] = %obj.marbleAttribute;
		%obj.value[0] = %obj.value;
		%obj.megaValue[0] = %obj.megaValue;
		%obj.marbleAttribute = "";
		%obj.value = "";
		%obj.megaValue = "";
	}

	//set up defaults
	// marbleAttribute - The physics attribute
	// value           - The value for regular sized marbles to apply
	// megaValue       - The value for mega marbles to apply
	// noEmitters      - Whether emiters should be built or not for physmod
	if (%obj.noEmitters $= "")
		%obj.noEmitters = 0;

	// simset to cache the physmod triggers in a group.
	%obj.setSync("onReceiveTrigger");
}

function buildPhysmodEmitters(%group) {
	%count = %group.getCount();

	for (%i = 0; %i < %count; %i++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();

		if (%class $= "SimGroup")
			buildPhysmodEmitters(%obj);
		else if (%class $= "Trigger" && %obj.getDataBlock().getName() $= "MarblePhysModTrigger" && !%obj.noEmitters) {
			if (%obj._builtEmitters) {
				continue;
			}
			%obj._builtEmitters = true;

			// create position array for each emitter to be placed around
			// the corner of the physmod trigger.
			%pos = %obj.getTransform();
			%scale = %obj.getScale();
			%x = getWord(%pos, 0);
			%y = getWord(%pos, 1);
			%z = getWord(%pos, 2);
			%sX = getWord(%scale, 0);
			%sY = getWord(%scale, 1);

			%pos[0] = %x SPC %y SPC %z;
			%pos[1] = %x + %sX SPC %y SPC %z;
			%pos[2] = %x SPC %y - %sY SPC %z;
			%pos[3] = %x + %sX SPC %y - %sY SPC %z;

			for (%j = 0; %j < $PhysModParticleEmitterCountPerTrigger; %j++) {
				%staticShape = new StaticShape() {
					position = %pos[%j];
					rotation = "1 0 0 0";
					scale = "1 1 1";
					datablock = PhysModEmitterBase;
				};
				MissionCleanup.add(%staticShape);
				$PhysModStaticShape[%obj.getId()] = %staticShape;
			}
		}
	}
}

function PhysModEmitterBase::onAdd(%this, %obj) {
	%this.initFX(%obj);
}
