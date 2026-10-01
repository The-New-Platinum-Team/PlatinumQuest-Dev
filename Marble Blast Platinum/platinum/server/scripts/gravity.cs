//-----------------------------------------------------------------------------
// Gravity triggers and the like, from PQ
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

datablock TriggerData(GravityTrigger) {
	tickPeriodMS = 100;
	customField[0, "field"  ] = "SimRotation";
	customField[0, "type"   ] = "AngAxisF";
	customField[0, "name"   ] = "Gravity Rotation";
	customField[0, "desc"   ] = "Rotation of the gravity to set; think Gravity Modifiers.";
	customField[0, "default"] = "1 0 0 0";
	customField[1, "field"  ] = "onLeave";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Activate on Leave";
	customField[1, "desc"   ] = "If false, change gravity on enter, if true, change on leave.";
	customField[1, "default"] = "1 0 0 0";
};

/**
 * @param {TriggerData} %this
 * @param {Trigger} %obj
 */
function GravityTrigger::onAdd(%this, %obj) {
	if (%obj.SimRotation $= "")
		%obj.SimRotation = "1 0 0 0";

	if (%obj.onLeave $= "")
		%obj.onLeave = "0";

	%obj.setSync("onReceiveTrigger");
}

/**
 * @param {TriggerData} %this
 * @param {Trigger} %obj
 */
function GravityTrigger::onInspectApply(%this, %obj) {
	%obj.setSync("onReceiveTrigger");
}

/**
 * @param {TriggerData} %this
 */
function GravityTrigger::getCustomFields(%this, %obj) {
	return
	    "SimRotation" TAB
	    "onLeave";
}

//-----------------------------------------------------------------------------

//TODO: $game::gravitydir is not defined here

datablock TriggerData(AlterGravityTrigger) {
	tickPeriodMS = 100;
	customField[0, "field"  ] = "MeasureAxis";
	customField[0, "type"   ] = "enum";
	customField[0, "name"   ] = "Measured Axis";
	customField[0, "desc"   ] = "Moving along this axis will change the gravity.";
	customField[0, "default"] = "x";
	customEnum["MeasureAxis", 0, "value"] = "x";
	customEnum["MeasureAxis", 0, "name" ] = "X";
	customEnum["MeasureAxis", 1, "value"] = "y";
	customEnum["MeasureAxis", 1, "name" ] = "Y";
	customEnum["MeasureAxis", 2, "value"] = "z";
	customEnum["MeasureAxis", 2, "name" ] = "Z";
	customField[1, "field"  ] = "FlipMeasure";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Flip Measure";
	customField[1, "desc"   ] = "If the gravity measure should be inverted.";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "ReverseRot";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Reverse Rotation";
	customField[2, "desc"   ] = "If the rotation direction is inverted.";
	customField[2, "default"] = "0";
	customField[3, "field"  ] = "StartingGravityRot";
	customField[3, "type"   ] = "float";
	customField[3, "name"   ] = "Starting Gravity Angle";
	customField[3, "desc"   ] = "Angle at which your gravity will be at the start of the trigger.";
	customField[3, "default"] = "0";
	customField[4, "field"  ] = "EndingGravityRot";
	customField[4, "type"   ] = "float";
	customField[4, "name"   ] = "Ending Gravity Angle";
	customField[4, "desc"   ] = "Angle at the end of the trigger.";
	customField[4, "default"] = "720";
	customField[5, "field"  ] = "GravityAxis";
	customField[5, "type"   ] = "enum";
	customField[5, "name"   ] = "Gravity Axis";
	customField[5, "desc"   ] = "Axis along which your gravity changes.";
	customField[5, "default"] = "y";
	customEnum["GravityAxis", 0, "value"] = "x";
	customEnum["GravityAxis", 0, "name" ] = "X";
	customEnum["GravityAxis", 1, "value"] = "y";
	customEnum["GravityAxis", 1, "name" ] = "Y";
	customEnum["GravityAxis", 2, "value"] = "z";
	customEnum["GravityAxis", 2, "name" ] = "Z";
};

/**
 * @param {TriggerData} %this
 * @param {Trigger} %obj
 */
function AlterGravityTrigger::onAdd(%this, %obj) {
	if (%obj.MeasureAxis $= "")
		%obj.MeasureAxis = "x";

	if (%obj.FlipMeasure $= "")
		%obj.FlipMeasure = "0";

	if (%obj.ReverseRot $= "")
		%obj.ReverseRot = "0";

	if (%obj.StartingGravityRot $= "")
		%obj.StartingGravityRot = "0";

	if (%obj.EndingGravityRot $= "")
		%obj.EndingGravityRot = "720";

	if (%obj.GravityAxis $= "")
		%obj.GravityAxis = "y";

	%obj.setSync("onReceiveTrigger");
}

/**
 * @param {TriggerData} %this
 * @param {Trigger} %obj
 */
function AlterGravityTrigger::onInspectApply(%this, %obj) {
	%obj.setSync("onReceiveTrigger");
}

/**
 * @param {TriggerData} %this
 */
function AlterGravityTrigger::getCustomFields(%this, %obj) {
	return
	    "MeasureAxis"        TAB
	    "FlipMeasure"        TAB
	    "ReverseRot"         TAB
	    "StartingGravityRot" TAB
	    "EndingGravityRot"   TAB
	    "GravityAxis";
}

//-----------------------------------------------------------------------------

//TODO: $game::gravitydir is not defined here

datablock TriggerData(GravityWellTrigger) {
	tickPeriodMS = 100;
	customField[0, "field"  ] = "Axis";
	customField[0, "type"   ] = "enum";
	customField[0, "name"   ] = "Axis of Rotation";
	customField[0, "desc"   ] = "Gravity will rotate around this axis.";
	customField[0, "default"] = "x";
	customEnum["Axis", 0, "value"] = "x";
	customEnum["Axis", 0, "name" ] = "X";
	customEnum["Axis", 1, "value"] = "y";
	customEnum["Axis", 1, "name" ] = "Y";
	customEnum["Axis", 2, "value"] = "z";
	customEnum["Axis", 2, "name" ] = "Z";
	customField[1, "field"  ] = "CustomPoint";
	customField[1, "type"   ] = "Point3F";
	customField[1, "name"   ] = "Custom Center";
	customField[1, "desc"   ] = "If not blank, rotate around this point instead of trigger's center";
	customField[1, "default"] = "";
	customField[2, "field"  ] = "Invert";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Invert Direction";
	customField[2, "desc"   ] = "Point outwards instead of inwards.";
	customField[2, "default"] = "0";
	customField[3, "field"  ] = "RadiusSize";
	customField[3, "type"   ] = "float";
	customField[3, "name"   ] = "Max Radius";
	customField[3, "desc"   ] = "Trigger will only work within this radius (if UseRadius is checked).";
	customField[3, "default"] = "";
	customField[4, "field"  ] = "UseRadius";
	customField[4, "type"   ] = "boolean";
	customField[4, "name"   ] = "Use Radius";
	customField[4, "desc"   ] = "If the max radius should be used.";
	customField[4, "default"] = "0";
	customField[5, "field"  ] = "RestoreGravity";
	customField[5, "type"   ] = "string";
	customField[5, "name"   ] = "Restore Gravity";
	customField[5, "desc"   ] = "Blank to not reset, 1 to reset to gravity on enter, otherwise a rotation axis-angle. Down is 1 0 0 180";
	customField[5, "default"] = "";
};

/**
 * @param {TriggerData} %this
 * @param {Trigger} %obj
 */
function GravityWellTrigger::onAdd(%this,%obj) {
	if (%obj.Axis $= "")
		%obj.Axis = "x";
	if (%obj.CustomPoint $= "")
		%obj.CustomPoint = " ";
	if (%obj.Invert $= "")
		%obj.Invert = "0";
	if (%obj.RadiusSize $= "")
		%obj.RadiusSize = "";
	if (%obj.UseRadius $= "")
		%obj.UseRadius = "";
	if (%obj.RestoreGravity $= "") // Restore prior gravity dir on leave
		%obj.RestoreGravity = "";  // 1 gets gravity upon enter, otherwise specify a four-unit rotation

	%obj.setSync("onReceiveTrigger");
}

/**
 * @param {TriggerData} %this
 * @param {Trigger} %obj
 */
function GravityWellTrigger::onInspectApply(%this, %obj) {
	%obj.setSync("onReceiveTrigger");
}

/**
 * @param {TriggerData} %this
 */
function GravityWellTrigger::getCustomFields(%this, %obj) {
	return
	    "Axis"        TAB
	    "CustomPoint" TAB
	    "Invert"      TAB
	    "UseRadius"   TAB
	    "Radius"      TAB
	    "RestoreGravity";
}

//-----------------------------------------------------------------------------

//TODO: $game::gravitydir is not defined here

datablock TriggerData(GravityPointTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "CustomPoint";
	customField[0, "type"   ] = "Point3F";
	customField[0, "name"   ] = "Custom Center";
	customField[0, "desc"   ] = "If not blank, rotate around this point instead of trigger's center";
	customField[0, "default"] = "";
	customField[1, "field"  ] = "Invert";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Invert Direction";
	customField[1, "desc"   ] = "Point outwards instead of inwards.";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "RadiusSize";
	customField[2, "type"   ] = "float";
	customField[2, "name"   ] = "Max Radius";
	customField[2, "desc"   ] = "Trigger will only work within this radius (if UseRadius is checked).";
	customField[2, "default"] = "20";
	customField[3, "field"  ] = "UseRadius";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Use Radius";
	customField[3, "desc"   ] = "If the max radius should be used.";
	customField[3, "default"] = "0";
	customField[4, "field"  ] = "UpDownLeave";
	customField[4, "type"   ] = "boolean";
	customField[4, "name"   ] = "Point Up/Down on Leave";
	customField[4, "desc"   ] = "If leaving should point gravity straight up or straight down depending on offset.";
	customField[4, "default"] = "0";
};

/**
 * @param {TriggerData} %this
 * @param {Trigger} %obj
 */
function GravityPointTrigger::onAdd(%this,%obj) {
	if (%obj.CustomPoint $= "")
		%obj.CustomPoint = " ";
	if (%obj.Invert $= "")
		%obj.Invert = "0";
	if (%obj.useRadius $= "")
		%obj.useRadius = "1";
	if (%obj.RadiusSize $= "")
		%obj.RadiusSize = "20";
	if (%obj.UpDownLeave $= "")
		%obj.UpDownLeave = "0";

	%obj.setSync("onReceiveTrigger");
}

/**
 * @param {TriggerData} %this
 * @param {Trigger} %obj
 */
function GravityPointTrigger::onInspectApply(%this, %obj) {
	%obj.setSync("onReceiveTrigger");
}

/**
 * @param {TriggerData} %this
 */
function GravityPointTrigger::getCustomFields(%this, %obj) {
	return
	    "CustomPoint" TAB
	    "Invert"      TAB
	    "useRadius"   TAB
	    "RadiusSize"  TAB
	    "UpDownLeave";
}
