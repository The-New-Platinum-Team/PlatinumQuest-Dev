//-----------------------------------------------------------------------------
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

function epmtbutton(%obj) {
	LargeFunctionDlg.init("editPhysModTrigger", "Edit PhysMod Trigger", 1);
	$Editor::PhysModTrigger = %obj;

	LargeFunctionDlg.addCheckBox("PhysMod_noEmitters", "Hide Emitters", %obj.noEmitters, 0);
	LargeFunctionDlg.addNote("Descriptions at the bottom if you want to know what a specific setting does.", 0);
	LargeFunctionDlg.addNote("", 0);

	for (%i = 0; %obj.value[%i] !$= ""; %i ++) {
		%customDefault[%obj.marbleAttribute[%i]] = %obj.value[%i];
		%customMega[%obj.marbleAttribute[%i]] = %obj.megaValue[%i];
	}

	LargeFunctionDlg.addNote("Marble Settings:", 0);
	for (%i = 0; %i < MarbleAttributeInfoArray.getSize(); %i ++) {
		%attribute = MarbleAttributeInfoArray.getEntry(%i);
		%type      = %attribute.type;
		if (%type !$= "datablock")
			continue;

		%field     = %attribute.internalField;
		%variable  = %attribute.variable;
		%name      = %attribute.displayName;
		%value     = %customDefault[%field];
		%default   = getVariable(strReplace(%variable, "##", "DefaultMarble"));
		%value     = %value $= "" ? %default : %value;
		%gui = "PhysMod_DefaultMarble_" @ %field;
		LargeFunctionDlg.addTextEditField(%gui, "Regular Marble " @ %name @ " (default is " @ %default @ ")", %value, 50, 4);

		if (isFunction("PhysMod_check_" @ %field)) {
			%gui.validate = %gui @ ".setValue(PhysMod_check_" @ %field @ "(1*" @ %gui @ ".getValue()));";
		} else {
			%gui.validate = %gui @ ".setValue(1*" @ %gui @ ".getValue());";
		}
	}
	for (%i = 0; %i < MarbleAttributeInfoArray.getSize(); %i ++) {
		%attribute = MarbleAttributeInfoArray.getEntry(%i);
		%type      = %attribute.type;
		if (%type !$= "datablock")
			continue;

		%field     = %attribute.internalField;
		%variable  = %attribute.variable;
		%name      = %attribute.displayName;
		%value     = %customMega[%field];
		%default   = getVariable(strReplace(%variable, "##", "MegaMarble"));
		%value     = %value $= "" ? %default : %value;
		%gui = "PhysMod_MegaMarble_" @ %field;
		LargeFunctionDlg.addTextEditField(%gui, "Mega Marble " @ %name @ " (default is " @ %default @ ")", %value, 50, 4);

		if (isFunction("PhysMod_check_" @ %field)) {
			%gui.validate = %gui @ ".setValue(PhysMod_check_" @ %field @ "(1*" @ %gui @ ".getValue()));";
		} else {
			%gui.validate = %gui @ ".setValue(1*" @ %gui @ ".getValue());";
		}
	}

	LargeFunctionDlg.addNote("Game Settings:", 0);
	for (%i = 0; %i < MarbleAttributeInfoArray.getSize(); %i ++) {
		%attribute = MarbleAttributeInfoArray.getEntry(%i);
		%type      = %attribute.type;
		if (%type !$= "global")
			continue;

		%field     = %attribute.internalField;
		%variable  = %attribute.variable;
		%name      = %attribute.displayName;
		%value     = %customDefault[%field];
		%default   = getVariable(strReplace(%variable, "##", "DefaultMarble"));
		%value     = %value $= "" ? %default : %value;
		%gui = "PhysMod_DefaultMarble_" @ %field;
		LargeFunctionDlg.addTextEditField(%gui, %name @ " (default is " @ %default @ ")", %value, 50, 4);

		if (isFunction("PhysMod_check_" @ %field)) {
			%gui.validate = %gui @ ".setValue(PhysMod_check_" @ %field @ "(1*" @ %gui @ ".getValue()));";
		} else {
			%gui.validate = %gui @ ".setValue(1*" @ %gui @ ".getValue());";
		}
	}

	//Descriptions
	LargeFunctionDlg.addNote("", 0);
	LargeFunctionDlg.addNote("Physics Setting Descriptions:", 0);
	LargeFunctionDlg.addNote("Max Roll Velocity", 1);
	LargeFunctionDlg.addNote("How fast you can roll forwards without diagonal or jumping.", 2);
	LargeFunctionDlg.addNote("Angular Acceleration", 1);
	LargeFunctionDlg.addNote("How quickly the you speed up when you roll forwards.", 2);
	LargeFunctionDlg.addNote("Braking Acceleration", 1);
	LargeFunctionDlg.addNote("How quickly the you slow down when you roll backwards while moving forwards.", 2); //Probably
	LargeFunctionDlg.addNote("Air Acceleration", 1);
	LargeFunctionDlg.addNote("How much moving while airborne (and not touching a wall) will affect your velocity.", 2);
	LargeFunctionDlg.addNote("Gravity", 1);
	LargeFunctionDlg.addNote("How quickly you speed up when falling.", 2);
	LargeFunctionDlg.addNote("Negative would mean you fall upwards, zero means you float forever.", 2);
	LargeFunctionDlg.addNote("Static Friction", 1);
	LargeFunctionDlg.addNote("How much skidding will slow you down.", 2); //Probably
	LargeFunctionDlg.addNote("Kinetic Friction", 1);
	LargeFunctionDlg.addNote("How much rolling will slow you down.", 2); //Probably
	LargeFunctionDlg.addNote("Bounce Kinetic Friction", 1);
	LargeFunctionDlg.addNote("How much your spin affects the way you bounce.", 2); //Probably
	LargeFunctionDlg.addNote("Max Dot Slide", 1);
	LargeFunctionDlg.addNote("How high of an angle from which you can hit the ground and slide.", 2); //Probably
	LargeFunctionDlg.addNote("1 means you can stick to the ground and slide from falling directly downwards.", 2);
	LargeFunctionDlg.addNote("Bounce Restitution", 1);
	LargeFunctionDlg.addNote("How much higher you will go after bouncing. Less than 1 means you'll bounce less high.", 2);
	LargeFunctionDlg.addNote("1 means you'll bounce forever at the same height, and greater than 1 means you bounce higher every time.", 2);
	LargeFunctionDlg.addNote("Jump Impulse", 1);
	LargeFunctionDlg.addNote("How strong your jumps are; your velocity after jumping will be at least this much.", 2);
	LargeFunctionDlg.addNote("Max Force Radius", 1);
	LargeFunctionDlg.addNote("From how far you are affected by fans and tornadoes.", 2);
	LargeFunctionDlg.addNote("Minimum Bounce Velocity", 1);
	LargeFunctionDlg.addNote("You'll bounce only if you hit the ground going faster than this.", 2);
	LargeFunctionDlg.addNote("Mass", 1);
	LargeFunctionDlg.addNote("How much less fans and tornadoes (and other hazards) will affect you.", 2);
	LargeFunctionDlg.addNote("Higher means your marble is \"heavier\" so they don't affect you as much.", 2);
	LargeFunctionDlg.addNote("Camera Speed Multiplier", 1);
	LargeFunctionDlg.addNote("Multiplies how fast your camera moves by default.", 2);
	LargeFunctionDlg.addNote("1 for regular camera, 0 to disable camera movement, -1 to make the camera backwards.", 2);
	LargeFunctionDlg.addNote("Movement Speed Multiplier", 1);
	LargeFunctionDlg.addNote("Multiplies how fast your marble moves when you roll.", 2);
	LargeFunctionDlg.addNote("Time Scale", 1);
	LargeFunctionDlg.addNote("Multiplies the speed at which the game is running.", 2);
	LargeFunctionDlg.addNote("0.5 would be half-speed slow motion, and 2 would be double speed.", 2);
	LargeFunctionDlg.addNote("Super Jump Velocity", 1);
	LargeFunctionDlg.addNote("Applied velocity when using a Super Jump.", 2);
	LargeFunctionDlg.addNote("Super Speed Velocity", 1);
	LargeFunctionDlg.addNote("Applied velocity when using a Super Speed.", 2);
	LargeFunctionDlg.addNote("Super Bounce Restitution", 1);
	LargeFunctionDlg.addNote("When using a Super Bounce, restitution is set to this.", 2);
	LargeFunctionDlg.addNote("Shock Absorber Restitution", 1);
	LargeFunctionDlg.addNote("When using a Shock Absorber, restitution is set to this.", 2);
	LargeFunctionDlg.addNote("Gyrocopter Gravity Multiplier", 1);
	LargeFunctionDlg.addNote("When using a Gyrocopter, Gravity will be multiplied by this factor.", 2);
	LargeFunctionDlg.addNote("Gyrocopter Air Acceleration Multiplier", 1);
	LargeFunctionDlg.addNote("When using a Gyrocopter, Air Acceleration will be multiplied by this factor.", 2);
}

function editPhysModTrigger(%gui) {
	%obj = $Editor::PhysModTrigger;
	%obj.noEmitters = PhysMod_noEmitters.getValue();

	for (%i = 0; %obj.marbleAttribute[%i] !$= ""; %i ++) {
		%obj.value[%i] = "";
		%obj.megaValue[%i] = "";
	}

	%changes = 0;
	for (%i = 0; %i < MarbleAttributeInfoArray.getSize(); %i ++) {
		%attribute = MarbleAttributeInfoArray.getEntry(%i);
		%field     = %attribute.internalField;
		%variable  = %attribute.variable;

		%defaultDefault = getVariable(strReplace(%variable, "##", "DefaultMarble"));
		%defaultMega    = getVariable(strReplace(%variable, "##", "MegaMarble"));

		%customDefault = ("PhysMod_DefaultMarble_" @ %field).getValue();
		%customMega    = (isObject("PhysMod_MegaMarble_" @ %field) ? ("PhysMod_MegaMarble_" @ %field).getValue() : %customDefault);

		if (isFunction("PhysMod_check_" @ %field)) {
			%customDefault = call(("PhysMod_check_" @ %field), %customDefault);
			%customMega = call(("PhysMod_check_" @ %field), %customMega);
		}

		if (%customDefault !$= %defaultDefault || %customMega !$= %defaultMega) {
			%obj.marbleAttribute[%changes] = %field;

			if (%customDefault !$= %defaultDefault) {
				echo("Changed value " @ %changes @ ": making default " @ %field SPC %customDefault);
				%obj.value[%changes] = %customDefault;
			}

			if (%customMega !$= %defaultMega) {
				echo("Changed value " @ %changes @ ": making mega " @ %field SPC %customMega);
				%obj.megaValue[%changes] = %customMega;
			}

			%changes ++;
		}
	}

	%obj.setSync("onReceiveTrigger");
	EditorInspector.inspector.inspect(EditorInspector.object);

	%gui.cleanup();
}


function PhysMod_check_maxDotSlide(%val) {
	return mClamp(%val, 0, 1);
}
function PhysMod_check_maxForceRadius(%val) {
	return max(%val, 0);
}
function PhysMod_check_timeScale(%val) {
	return mClamp(%val, 0.05, 50);
}
function PhysMod_check_mass(%val) {
	return max(%val, 0.01);
}
function PhysMod_check_movementSpeedMultiplier(%val) {
	return mClamp(%val, -1, 1);
}
