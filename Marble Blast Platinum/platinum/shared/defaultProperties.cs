//-----------------------------------------------------------------------------
// defaultProperties.cs
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

/// Default Marble Physics Constants
/// {
$Physics::DefaultMarble::MaxRollVelocity = 15;
$Physics::DefaultMarble::AngularAcceleration = 75;
$Physics::DefaultMarble::BrakingAcceleration = 30;
$Physics::DefaultMarble::AirAcceleration = 5;
$Physics::DefaultMarble::Gravity = 20;
$Physics::DefaultMarble::StaticFriction = 1.1;
$Physics::DefaultMarble::KineticFriction = 0.7;
$Physics::DefaultMarble::BounceKineticFriction = 0.2;
$Physics::DefaultMarble::MaxDotSlide = 0.5;
$Physics::DefaultMarble::JumpImpulse = 7.5;
$Physics::DefaultMarble::MaxForceRadius = 50;
$Physics::DefaultMarble::MinBounceVel = 0.1;
$Physics::DefaultMarble::BounceRestitution = 0.5;
$Physics::DefaultMarble::Mass = 1;
$Physics::DefaultMarble::PowerUpTime3 = 5000;
$Physics::DefaultMarble::PowerUpTime4 = 5000;
$Physics::DefaultMarble::PowerUpTime5 = 5000;
/// }

/// Mega Marble Physics Constants
/// {
$Physics::MegaMarble::MaxRollVelocity = 12;
$Physics::MegaMarble::AngularAcceleration = 60;
$Physics::MegaMarble::BrakingAcceleration = 25;
$Physics::MegaMarble::AirAcceleration = 5;
$Physics::MegaMarble::Gravity = 22;
$Physics::MegaMarble::StaticFriction = 1.0;
$Physics::MegaMarble::KineticFriction = 0.8;
$Physics::MegaMarble::BounceKineticFriction = 0.3;
$Physics::MegaMarble::MaxDotSlide = 0.3;
$Physics::MegaMarble::JumpImpulse = 7.5;
$Physics::MegaMarble::MaxForceRadius = 75;
$Physics::MegaMarble::MinBounceVel = 0.1;
$Physics::MegaMarble::BounceRestitution = 0.5;
$Physics::MegaMarble::Mass = 1;
$Physics::MegaMarble::PowerUpTime3 = 5000;
$Physics::MegaMarble::PowerUpTime4 = 5000;
$Physics::MegaMarble::PowerUpTime5 = 5000;
/// }

/// {
$Physics::Defaults::CameraDistance = 2.5;
$Physics::Defaults::CameraSpeedMultiplier = 1;
$Physics::Defaults::MovementSpeedMultiplier = 1;
$Physics::Defaults::TimeScale = 1;
$Physics::Defaults::SuperJumpVelocity = 20;
$Physics::Defaults::SuperSpeedVelocity = 25;
$Physics::Defaults::SuperBounceRestitution = 0.9;
$Physics::Defaults::ShockAbsorberRestitution = 0.01;
$Physics::Defaults::HelicopterGravityMultiplier = 0.25;
$Physics::Defaults::HelicopterAirAccelerationMultiplier = 2;
/// }

/// Add each physics attribute that we are concerned about with the marble
/// into an attribute list.
/// {
if (!isObject(MarbleDatablockAttributesArray)) {
	Array(MarbleDatablockAttributesArray);
	MarbleDatablockAttributesArray.addEntry("maxRollVelocity");
	MarbleDatablockAttributesArray.addEntry("angularAcceleration");
	MarbleDatablockAttributesArray.addEntry("brakingAcceleration");
	MarbleDatablockAttributesArray.addEntry("airAcceleration");
	MarbleDatablockAttributesArray.addEntry("gravity");
	MarbleDatablockAttributesArray.addEntry("staticFriction");
	MarbleDatablockAttributesArray.addEntry("kineticFriction");
	MarbleDatablockAttributesArray.addEntry("bounceKineticFriction");
	MarbleDatablockAttributesArray.addEntry("maxDotSlide");
	MarbleDatablockAttributesArray.addEntry("bounceRestitution");
	MarbleDatablockAttributesArray.addEntry("jumpImpulse");
	MarbleDatablockAttributesArray.addEntry("maxForceRadius");
	MarbleDatablockAttributesArray.addEntry("minBounceVel");
	MarbleDatablockAttributesArray.addEntry("mass");
	MarbleDatablockAttributesArray.addEntry("cameraDistance");
	MarbleDatablockAttributesArray.addEntry("powerUpTime[3]");
	MarbleDatablockAttributesArray.addEntry("powerUpTime[4]");
	MarbleDatablockAttributesArray.addEntry("powerUpTime[5]");
}
/// }

/// Also keep some info for all attributes
/// {

function addMarbleAttributeInfo(%attributeStr) {
	%internalName = getField(%attributeStr, 0);
	%type = getField(%attributeStr, 1);
	%variable = getField(%attributeStr, 2);
	%displayName = getField(%attributeStr, 3);
	if (isObject(MarbleAttributeInfoArray)) {
		%obj = new ScriptObject(MarbleAttributeInfo) {
			internalName = %internalName;
			type = %type;
			variable = %variable;
			displayName = %displayName;
		};
		MarbleAttributeInfoArray.addEntry(%obj);
		MarbleAttributeInfoArray.setFieldValue(%internalName, %obj);
	}
}

if (!isObject(MarbleAttributeInfoArray)) {
	Array(MarbleAttributeInfoArray);
	//                                internal name                             type            variable                                                      display name
	addMarbleAttributeInfo("maxRollVelocity"                     TAB "datablock" TAB "$Physics::##::MaxRollVelocity"                           TAB "Max Roll Velocity");
	addMarbleAttributeInfo("angularAcceleration"                 TAB "datablock" TAB "$Physics::##::AngularAcceleration"                       TAB "Angular Acceleration");
	addMarbleAttributeInfo("brakingAcceleration"                 TAB "datablock" TAB "$Physics::##::BrakingAcceleration"                       TAB "Braking Acceleration");
	addMarbleAttributeInfo("airAcceleration"                     TAB "datablock" TAB "$Physics::##::AirAcceleration"                           TAB "Air Acceleration");
	addMarbleAttributeInfo("gravity"                             TAB "datablock" TAB "$Game::Gravity"                                          TAB "Gravity");
	addMarbleAttributeInfo("staticFriction"                      TAB "datablock" TAB "$Physics::##::StaticFriction"                            TAB "Static Friction");
	addMarbleAttributeInfo("kineticFriction"                     TAB "datablock" TAB "$Physics::##::KineticFriction"                           TAB "Kinetic Friction");
	addMarbleAttributeInfo("bounceKineticFriction"               TAB "datablock" TAB "$Physics::##::BounceKineticFriction"                     TAB "Bounce Kinetic Friction");
	addMarbleAttributeInfo("maxDotSlide"                         TAB "datablock" TAB "$Physics::##::MaxDotSlide"                               TAB "Max Dot Slide");
	addMarbleAttributeInfo("bounceRestitution"                   TAB "datablock" TAB "$Physics::##::BounceRestitution"                         TAB "Bounce Restitution");
	addMarbleAttributeInfo("jumpImpulse"                         TAB "datablock" TAB "$Game::JumpImpulse"                                      TAB "Jump Impulse");
	addMarbleAttributeInfo("maxForceRadius"                      TAB "datablock" TAB "$Physics::##::MaxForceRadius"                            TAB "Max Force Radius");
	addMarbleAttributeInfo("minBounceVel"                        TAB "datablock" TAB "$Physics::##::MinBounceVel"                              TAB "Minimum Bounce Velocity");
	addMarbleAttributeInfo("mass"                                TAB "datablock" TAB "$Physics::##::Mass"                                      TAB "Mass");
	addMarbleAttributeInfo("powerUpTime[3]"                      TAB "datablock" TAB "$Physics::##::PowerUpTime3"                              TAB "Super Bounce Duration");
	addMarbleAttributeInfo("powerUpTime[4]"                      TAB "datablock" TAB "$Physics::##::PowerUpTime4"                              TAB "Shock Absorber Duration");
	addMarbleAttributeInfo("powerUpTime[5]"                      TAB "datablock" TAB "$Physics::##::PowerUpTime5"                              TAB "Helicopter Duration");
	addMarbleAttributeInfo("cameraSpeedMultiplier"               TAB "global"    TAB "$Physics::Defaults::CameraSpeedMultiplier"               TAB "Camera Speed Multiplier");
	addMarbleAttributeInfo("movementSpeedMultiplier"             TAB "global"    TAB "$Physics::Defaults::MovementSpeedMultiplier"             TAB "Movement Speed Multiplier");
	addMarbleAttributeInfo("timeScale"                           TAB "global"    TAB "$Physics::Defaults::TimeScale"                           TAB "Time Scale");
	addMarbleAttributeInfo("superJumpVelocity"                   TAB "global"    TAB "$Physics::Defaults::SuperJumpVelocity"                   TAB "Super Jump Velocity");
	addMarbleAttributeInfo("superSpeedVelocity"                  TAB "global"    TAB "$Physics::Defaults::SuperSpeedVelocity"                  TAB "Super Speed Velocity");
	addMarbleAttributeInfo("superBounceRestitution"              TAB "global"    TAB "$Physics::Defaults::SuperBounceRestitution"              TAB "Super Bounce Restitution");
	addMarbleAttributeInfo("shockAbsorberRestitution"            TAB "global"    TAB "$Physics::Defaults::ShockAbsorberRestitution"            TAB "Shock Absorber Restitution");
	addMarbleAttributeInfo("helicopterGravityMultiplier"         TAB "global"    TAB "$Physics::Defaults::HelicopterGravityMultiplier"         TAB "Gyrocopter Gravity Multiplier");
	addMarbleAttributeInfo("helicopterAirAccelerationMultiplier" TAB "global"    TAB "$Physics::Defaults::HelicopterAirAccelerationMultiplier" TAB "Gyrocopter Air Acceleration Multiplier");
}
/// }