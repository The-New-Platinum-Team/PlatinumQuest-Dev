//-----------------------------------------------------------------------------
// physics.cs
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

if (!isObject(PhysicsLayerGroup)) {
	// The group is unordered, thus does not control the ordering of the physics
	// layers. This group only exists for the soul purpose of keeping the physics
	// layer structs inside of a group and not floating around everywhere.
	// Thanks, Obama...I mean GarageGames for keeping floating objects in any
	// simgroup. :)
	RootGroup.add(new SimGroup(PhysicsLayerGroup));

	// The array implementation is actually responsible for controlling the
	// ordering of the physics layers.
	Array(PhysicsLayerArray);
}

/// Sets the default gravity and jump impulse of the level for.
/// @arg gravity The gravity value that's used as default for all marbles.
/// @arg jumpImpulse The jumpImpulse value that's used as defaults for all
/// marbles.
function clientCmdPhysicsValues(%gravity, %jumpImpulse) {
	$Game::Gravity = %gravity;
	$Game::JumpImpulse = %jumpImpulse;
}

/// Resets the physics properties to all marbles
function Physics::resetToDefaultMarble() {
	//Get all attributes' default values (from defaultProperties.cs) and apply them
	for (%i = 0; %i < MarbleAttributeInfoArray.getSize(); %i ++) {
		%attribute = MarbleAttributeInfoArray.getEntry(%i);
		%field     = %attribute.internalName;
		%variable  = %attribute.variable;
		%value     = getVariable(strReplace(%variable, "##", "DefaultMarble"));
		%megaValue = getVariable(strReplace(%variable, "##", "MegaMarble"));
		Physics::setProperty(%field, %value, %megaValue);
	}
}

/// Get the value of a physics property
/// @arg field The attribute to apply to the marbles.
function Physics::getProperty(%field) {
	%attribute = MarbleAttributeInfoArray.getFieldValue(%field);
	%type = %attribute.type;
	//These are all global variables set by ::setProperty.
	// Probably could use datablock field getting, but that's way too much
	// effort and might not even be as accurate. So this will work.
	switch$ (%type) {
	case "datablock":
		if (MPMyMarbleExists()) {
			//Get straight from marble if we can
			return $MP::MyMarble.getDataBlock().getFieldValue(%field);
		}
		return $Physics::PropertyValue[%field];
	case "global":
		switch$ (%field) {
		case "cameraSpeedMultiplier":
			return $Game::CameraSpeedMultiplier;
		case "movementSpeedMultiplier":
			return $Game::MovementSpeedMultiplier;
		case "timeScale":
			return getTimeScale();
		case "superJumpVelocity":
			return getSuperJumpVelocity();
		case "superSpeedVelocity":
			return getSuperSpeedVelocity();
		case "superBounceRestitution":
			return getSuperBounceRestitution();
		case "shockAbsorberRestitution":
			return getShockAbsorberRestitution();
		case "helicopterGravityMultiplier":
			return getHelicopterGravityMultiplier();
		case "helicopterAirAccelerationMultiplier":
			return getHelicopterAirAccelerationMultiplier();
		}
	}
}

/// Applies a physics property on all of the marbles.
/// @arg field The attribute to apply to the marbles.
/// @arg value The value of the attribute for regular marbles.
/// @arg megaValue The value of the attribute for mega marbles.
function Physics::setProperty(%field, %value, %megaValue) {
	%attribute = MarbleAttributeInfoArray.getFieldValue(%field);
	%type = %attribute.type;
	devecho("Set " @ %type @ " physics property \"" @ %field @ "\" to " @ %value @ " (mega: " @ %megaValue @ ")");
	switch$ (%type) {
	case "datablock":

		//Mega marbles
		if ($Client::MegaMarble) {
			%value = %megaValue;
		}

		//Apply to every possible marble datablock
		%count = MarbleDataSet.getCount();
		for (%i = 0; %i < %count; %i++) {
			%db = MarbleDataSet.getObject(%i);
			%db.setFieldValue(%field, %value);
		}
		//Save this for ::getProperty
		$Physics::PropertyValue[%field] = %value;
	case "global":
		switch$ (%field) {
		case "cameraSpeedMultiplier":
			//Update any existing movements by first reverting the last multiplier
			// and then applying the new one
			if ($Game::CameraSpeedMultiplier != 0) {
				$mvPitchDownSpeed /= $Game::CameraSpeedMultiplier;
				$mvPitchUpSpeed /= $Game::CameraSpeedMultiplier;
				$mvYawRightSpeed /= $Game::CameraSpeedMultiplier;
				$mvYawLeftSpeed /= $Game::CameraSpeedMultiplier;
				$mvUpAction /= $Game::CameraSpeedMultiplier;
				$mvDownAction /= $Game::CameraSpeedMultiplier;
			}
			//See default.bind.cs for how this variable is used
			$Game::CameraSpeedMultiplier = ($Editor::Opened ? 1 : %value);

			$mvPitchDownSpeed *= $Game::CameraSpeedMultiplier;
			$mvPitchUpSpeed *= $Game::CameraSpeedMultiplier;
			$mvYawRightSpeed *= $Game::CameraSpeedMultiplier;
			$mvYawLeftSpeed *= $Game::CameraSpeedMultiplier;
			$mvUpAction *= $Game::CameraSpeedMultiplier;
			$mvDownAction *= $Game::CameraSpeedMultiplier;
		case "movementSpeedMultiplier":
			//Update any existing movements by first reverting the last multiplier
			// and then applying the new one
			if ($Game::MovementSpeedMultiplier != 0) {
				$mvLeftAction /= $Game::MovementSpeedMultiplier;
				$mvRightAction /= $Game::MovementSpeedMultiplier;
				$mvForwardAction /= $Game::MovementSpeedMultiplier;
				$mvBackwardAction /= $Game::MovementSpeedMultiplier;
			}
			//See default.bind.cs for how this variable is used
			$Game::MovementSpeedMultiplier = ($Editor::Opened ? 1 : %value);

			$mvLeftAction *= $Game::MovementSpeedMultiplier;
			$mvRightAction *= $Game::MovementSpeedMultiplier;
			$mvForwardAction *= $Game::MovementSpeedMultiplier;
			$mvBackwardAction *= $Game::MovementSpeedMultiplier;
		case "timeScale":
			setTimeScale(%value);
		case "superJumpVelocity":
			setSuperJumpVelocity(%value);
		case "superSpeedVelocity":
			setSuperSpeedVelocity(%value);
		case "superBounceRestitution":
			setSuperBounceRestitution(%value);
		case "shockAbsorberRestitution":
			setShockAbsorberRestitution(%value);
		case "helicopterGravityMultiplier":
			setHelicopterGravityMultiplier(%value);
		case "helicopterAirAccelerationMultiplier":
			setHelicopterAirAccelerationMultiplier(%value);
		}
	}

	if ($Record::Recording) {
		onNextFrame(recordWritePhysics, RecordFO);
	}
}

/// Pushes a physics layer onto the physics system.
/// @arg info a new line seperated list with each line containing at least 2
///      words. The lines contain the following:
///      attributeName value
///      attributeName value megamarblevalue
/// @note If a mega value isn't specified, the value that was given for the
///       regular marble will be used.
/// @return the layer object ID that will be used for poping off the layer.
function Physics::pushLayer(%info) {
	%layer = new ScriptObject(ActivePhysicsLayer) {
		layer = PhysicsLayerArray.getSize();
		attributeCount = 0;
	};
	PhysicsLayerGroup.add(%layer);
	PhysicsLayerArray.addEntry(%layer);

	// store and apply attributes, values, and megavalues
	%count = getRecordCount(%info);
	for (%i = 0; %i < %count; %i++) {
		%record = getRecord(%info, %i);

		%layer.attribute[%i] = getWord(%record, 0);
		%layer.value[%i] = getWord(%record, 1);

		// check to see if we have a mega value given or not.
		// if it was not given, then just set it to the value.
		if (getWordCount(%record) == 3)
			%layer.megaValue[%i] = getWord(%record, 2);
		else
			%layer.megaValue[%i] = %layer.value[%i];

		// finally, apply the attributes.
		Physics::setProperty(%layer.attribute[%i], %layer.value[%i], %layer.megaValue[%i]);
	}
	%layer.attributeCount = %count;

	return %layer;
}

/// Pops the physics layer specified off of the physics "stack" and resorts
/// all of the physics layers based upon the layer id by bumping down subsequent
/// layers by a value of 1. Afterwards, the physics system is cleared to the
/// default values, and each layer starting from layer 0 (if there are any
/// layers) are reapplied until all of the layers are done being reapplied.
/// @arg layer The layer to remove. Whenever it is removed, it is deleted
///      from the physics system.
function Physics::popLayer(%layer) {
	if (!isObject(%layer)) {
		error("Physics::popLayer(" @ %layer @ ") :: unable to find physics Layer.");
		return;
	}

	// layer id we are removing
	%layerID = %layer.layer;
	%layer.delete();
	PhysicsLayerArray.removeEntriesByContents(%layer);

	// reprioritize layers.
	%count = PhysicsLayerArray.getSize();
	for (%i = 0; %i < %count; %i++) {
		%obj = PhysicsLayerArray.getEntry(%i);

		// no reason to bump down lower layers than the current one we are
		// removing
		if (%obj.layer >= %layerID)
			%obj.layer--;
	}

	// Quick sort layers based upon layer id
	PhysicsLayerArray.sort(Physics_sortLayers);

	// reset physics and apply each layer.
	Physics::resetToDefaultMarble();
	for (%i = 0; %i < %count; %i++) {
		%obj = PhysicsLayerArray.getEntry(%i);

		%attribCount = %obj.attributeCount;
		for (%j = 0; %j < %attribCount; %j++)
			Physics::setProperty(%obj.attribute[%j], %obj.value[%j], %obj.megaValue[%j]);
	}
}

/// Callback function used for quick sorting the Physics Layers.
/// @return true if the layer of object A is less than object B.
function Physics_sortLayers(%a, %b) {
	return %a.layer < %b.layer;
}

function Physics::dumpLayers() {
	echo("Active physics layers:");

	%count = PhysicsLayerArray.getSize();
	for (%i = 0; %i < %count; %i++) {
		%obj = PhysicsLayerArray.getEntry(%i);

		echo("Layer " @ %i @ ": " @ %obj.name);

		%attribCount = %obj.attributeCount;
		for (%j = 0; %j < %attribCount; %j++) {
			echo("   Attribute " @ %i @ ": " @ %obj.attribute[%j] @ " value: " @ %obj.value[%j] @ " mega value: " @ %obj.megaValue[%j]);
		}
	}
}

function Physics::reloadLayers() {
	echo("Physics reloading layers");

	//Reset physics and apply each layer.
	Physics::resetToDefaultMarble();
	%count = PhysicsLayerArray.getSize();
	for (%i = 0; %i < %count; %i++) {
		%obj = PhysicsLayerArray.getEntry(%i);

		%attribCount = %obj.attributeCount;
		for (%j = 0; %j < %attribCount; %j++)
			Physics::setProperty(%obj.attribute[%j], %obj.value[%j], %obj.megaValue[%j]);
	}
}

function Physics::popAllLayers() {
	PhysicsLayerArray.clear();
	Physics::resetToDefaultMarble();
	echo("Physics popping all layers");
}

function Physics::pushLayerName(%name) {
	%layer = $Physics::NamedLayer[%name];
	if (isObject(%layer)) {
		if (isObject(%layer.layer) && PhysicsLayerArray.contains(%layer.layer))
			return;
		echo("Pushed physics layer " @ %name);
		%layer.layer = Physics::pushLayer(%layer.fields);
		%layer.layer.name = %name;
		%layer.pushed = true;
	}
}

function Physics::popLayerName(%name) {
	%layer = $Physics::NamedLayer[%name];
	if (isObject(%layer) && isObject(%layer.layer) && PhysicsLayerArray.contains(%layer.layer)) {
		echo("Popped physics layer " @ %name);
		Physics::popLayer(%layer.layer);
		%layer.pushed = false;
	}
}

function Physics::registerLayer(%name, %fields) {
	PhysicsLayerGroup.add($Physics::NamedLayer[%name] = new ScriptObject(RegisteredPhysicsLayer) {
		fields = %fields;
	});
}

function MarblePhysModTrigger_onClientEnterTrigger(%this, %trigger, %marble) {
	if (%marble !$= $MP::MyMarble || %trigger.disabled)
		return;
	$PhysModTrigger[%trigger] = Physics::pushLayer(%trigger.fieldCache);
}

function MarblePhysModTrigger_onClientStayTrigger(%this, %trigger, %marble) {
	//Nothing
}

function MarblePhysModTrigger_onClientLeaveTrigger(%this, %trigger, %marble) {
	if (%marble !$= $MP::MyMarble || %trigger.disabled)
		return;
	Physics::popLayer($PhysModTrigger[%trigger]);
	$PhysModTrigger[%trigger] = "";
}


Physics::registerLayer("frozen",
                       "gravity 0" NL
                       "angularAcceleration 0" NL
                       "jumpImpulse 0" NL
                       "brakingAcceleration 0" NL
                       "bounceRestitution 0" NL
                       "airAcceleration 0" NL
                       "maxDotSlide 0"
                      );

Physics::registerLayer("noInput",
                       "gravity 0" NL
                       "angularAcceleration 0" NL
                       "jumpImpulse 0" NL
                       "brakingAcceleration 0" NL
                       "bounceRestitution 0" NL
                       "airAcceleration 0" NL
                       "cameraSpeedMultiplier 0" NL
                       "movementSpeedMultiplier 0" NL
                       "maxDotSlide 0"
                      );

Physics::registerLayer("overview",
                       "cameraSpeedMultiplier 0" NL
                       "movementSpeedMultiplier 0"
                      );

Physics::registerLayer("spectateFollow",
                       "movementSpeedMultiplier 0"
                      );

Physics::registerLayer("noMovement",
                       "airAcceleration 0" NL
                       "angularAcceleration 0"
                      );

Physics::registerLayer("cannonLockControls",
                       "jumpImpulse 0" NL
                       "airAcceleration 0" NL
                       "angularAcceleration 0" NL
                       "maxDotSlide 0"
                      );

Physics::registerLayer("cannonLockCamera",
                       "cameraSpeedMultiplier 0"
                      );

Physics::registerLayer("toggleCamera",
                       "cameraSpeedMultiplier 1" NL
                       "movementSpeedMultiplier 1" NL
                       "timeScale 1"
                      );

Physics::registerLayer("2d",
                       "cameraSpeedMultiplier 0"
                      );

Physics::registerLayer("water",
                       "maxRollVelocity 5 5" NL
                       "angularAcceleration 35 35" NL
                       "gravity 10 10" NL
                       "staticFriction 1.1 1.1" NL
                       "kineticFriction 0.7 0.7" NL
                       "bounceKineticFriction 0.2 0.2" NL
                       "maxDotSlide 0.5 0.5" NL
                       "bounceRestitution 0.2 0.2" NL
                       "jumpImpulse 7.5 7.5"
                      );

Physics::registerLayer("bubble",
                       "maxRollVelocity 10 10" NL
                       "angularAcceleration 55 55" NL
                       "brakingAcceleration 30 30" NL
                       "airAcceleration 7 7" NL
                       "gravity -5 -5" NL
                       "staticFriction 1.1 1.1" NL
                       "kineticFriction 0.7 0.7" NL
                       "bounceKineticFriction 0.2 0.2" NL
                       "maxDotSlide 0.5 0.5" NL
                       "bounceRestitution 0.7 0.7" NL
                       "jumpImpulse 7.5 7.5" NL
                       "minTrailSpeed 1.2 1.25"
                      );

Physics::registerLayer("diagonull",
                      "maxRollVelocity 10.6066 10.6066" NL
                      "angularAcceleration 53.033 53.033" NL
                      "airAcceleration 3.3234 3.3234"
                      );