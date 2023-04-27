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


//-----------------------------------------------------------------------------

datablock AudioProfile(ButtonClick) {
	filename    = "~/data/sound/ButtonClick.wav";
	description = AudioDefault3d;
	preload = true;
};


//-----------------------------------------------------------------------------
// Single action button that resets after a default elapsed time.
// When activated the button triggers all the objects in it's group.

datablock StaticShapeData(PushButton) {
	className = "Button";
	category = "Buttons";
	shapeFile = "~/data/shapes/buttons/pushButton.dts";
	resetTime = 5000;

	skinCount = 11;
	skin[0] = "base";
	skin[1] = "black";
	skin[2] = "blue";
	skin[3] = "gray";
	skin[4] = "green";
	skin[5] = "magenta";
	skin[6] = "mint";
	skin[7] = "orange";
	skin[8] = "pink";
	skin[9] = "purple";
	skin[10] = "yellow";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
	customField[1, "field"  ] = "resetTime";
	customField[1, "type"   ] = "time";
	customField[1, "name"   ] = "Reset Time";
	customField[1, "desc"   ] = "How long the button takes to un-press";
	customField[1, "default"] = "5000";
	customField[2, "field"  ] = "triggerOnce";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Only Trigger Once";
	customField[2, "desc"   ] = "If the button should only trigger the first time.";
	customField[2, "default"] = "0";
};

function Button::onAdd(%this, %obj) {
	if (%obj.skin !$= "")
		%obj.setSkinName(%obj.skin);

	%obj._activated = false;
	//if (%obj.triggerMesg $= "")
	//%obj.triggerMesg = "true";
	if (%obj.resetTime $= "")
		%obj.resetTime = %this.resetTime;

	if (%obj.triggerOnce $= "")
		%obj.triggerOnce = "0";
}

function Button::onCollision(%this,%obj,%col,%vec, %vecLen, %material) {
	if (!Parent::onCollision(%this,%obj,%col,%vec, %vecLen, %material)) return;
	// Currently activates when any object hits it.
	//if (%material $= "ButtonMaterial")
		%this.activate(%obj,true);

	%this.triggerCallback(%obj, %col);
}

function Button::_presave(%this, %obj) {
	Parent::_presave(%this, %obj);
	for (%i = 0; %i < 11; %i ++) {
		if (%obj.triggerObject[%i] $= "ObjectName")
			%obj.triggerObject[%i] = "";
		if (%obj.objectMethod[%i] $= "doThis(%param1, %param2, %etc)")
			%obj.objectMethod[%i] = "";
	}
}
function Button::_postSave(%this, %obj) {
	Parent::_postSave(%this, %obj);
	for (%i = 0; %i < 11; %i ++) {
		if (%obj.triggerObject[%i] $= "")
			%obj.triggerObject[%i] = "ObjectName";
		if (%obj.objectMethod[%i] $= "")
			%obj.objectMethod[%i] = "doThis(%param1, %param2, %etc)";
	}
}

function Button::triggerCallback(%this, %obj, %col) {
	//------------------
	// GG's code

	//if (%obj._activated) {
	//// Trigger all the objects in our mission group
	//%group = %obj.getGroup();
	//for (%i = 0; %i < %group.getCount(); %i++)
	//%group.getObject(%i).onTrigger(%this,%obj.triggerMesg);
	////%group.getObject(%i).onTrigger(%this,%this.triggerMesg);

	//// Schedule the button reset
	//%resetTime = (%obj.resetTime $= "Default")? %this.resetTime: %obj.resetTime;
	//if (%resetTime)
	//%this.schedule(%resetTime,activate,%obj,false);
	//}

	//------------------
	// PQ

	if (%obj._activated) {
		if (isObject(%obj.triggerObject)) {
			%check = %obj.triggerObject;
			%mgID = MissionGroup.getID();
			// Check recursively if we're nested in the MissionGroup
			while (true) {
				if (%check.getGroup() == -1)
					break;
				if (%check.getGroup() == %mgID) {
					%missionGroup = 1;
					break;
				} else
					%check = %check.getGroup();
			}
			if (%missiongroup) {
				while (true) {
					%method = %obj.objectMethod[%ct];
					%methodName = %method;
					if (%method $= "")
						break;

					// skip templated method calls that aren't filled in.
					if (strstr(strlwr(%method), "dothis(") != -1) {
						%ct += !%ct + 1;
						continue;
					}

					if (getSubStr(%method, strLen(%method)-1, 1) !$= ";")
						%method = %method @ ";";

					// onEnterTrigger or onLeaveTrigger needs the marble that we collided with.
					// see issue #113 as to why. Help triggers need the collider!
					if (%methodName $= "onEnterTrigger()" || %methodName $= "onLeaveTrigger()")
						%methodPredicate = insertParameter(%method, %obj.triggerObject[%ct] @ "," @ %col);
					else
						%methodPredicate = insertParameter(%method, %obj.triggerObject[%ct]);

					%eval = %obj.triggerObject[%ct].getDatablock() @ "." @ %methodPredicate;
					//error(%eval);
					eval(%eval);
					%ct += !%ct + 1;
				}
			} else
				error("PushButton " @ %obj.getID() @ ": triggerObject \"" @ %obj.triggerObject @ "\" not in MissionGroup!");
		} else
			error("PushButton " @ %obj.getID() @ ": triggerObject doesn\'t exist");

		if (!%obj.triggerOnce) {
			// Schedule the button reset
			%resetTime = (%obj.resetTime > 0) ? %obj.resetTime : %this.resetTime;
			if (%resetTime)
				%this.schedule(%resetTime,"activate",%obj,false);
		}
	}
}

function insertParameter(%method, %param) {
	%pos = strStr(%method, "(");
	if (%pos == -1) return;

	%pos2 = strStr(%method, ")");

	if ((%pos2 != %pos + 1) && (strstr(%param, ",") != -1))
		%param = %param @ ",";

	%final = getSubStr(%method, 0, %pos+1) @ %param @ getSubStr(%method, %pos+1, 65535);
	return %final;
}

function Button::onMissionReset(%this, %obj) {
	if (!isObject(%obj))
		return;
	if (%obj._activated) {
		%obj.setThreadDir(0,false);
		%obj._activated = false;
	}
}

function Button::activate(%this,%obj,%state) {
	if (%state && !%obj._activated) {
		%obj.playThread(0,"push");
		%obj.setThreadDir(0,true);
		%obj.playAudio(0,ButtonClick);
		%obj._activated = true;
	} else if (!%state && %obj._activated) {
		%obj.setThreadDir(0,false);
		%obj.playAudio(0,ButtonClick);
		%obj._activated = false;
	}
}

datablock StaticShapeData(PushButton_PQ : PushButton) {
	shapeFile = "~/data/shapes_pq/Gameplay/pads/PushButtonRegular.dts";
};
datablock StaticShapeData(PushButtonFlat_PQ : PushButton) {
	shapeFile = "~/data/shapes_pq/Gameplay/pads/PushButtonFlat.dts";
};
datablock StaticShapeData(PushButton_BM : PushButton) {
	shapeFile = "~/data/shapes_bm/scenery/PushButton_bm.dts";
};

//-----------------------------------------------------------------------------

datablock StaticShapeData(ToggleButton) {
	className = "Button";
	category = "Buttons";
	shapeFile = "~/data/shapes/buttons/pushButton.dts";

	skinCount = 11;
	skin[0] = "base";
	skin[1] = "black";
	skin[2] = "blue";
	skin[3] = "gray";
	skin[4] = "green";
	skin[5] = "magenta";
	skin[6] = "mint";
	skin[7] = "orange";
	skin[8] = "pink";
	skin[9] = "purple";
	skin[10] = "yellow";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
	customField[1, "field"  ] = "initialState";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Initial State";
	customField[1, "desc"   ] = "If the button starts pressed.";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "correctState";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Correct State";
	customField[2, "desc"   ] = "If the button should be pressed to be considered correct.";
	customField[2, "default"] = "1";
};

function ToggleButton::onAdd(%this, %obj) {
	if (%obj.skin !$= "")
		%obj.setSkinName(%obj.skin);

	if (%obj.initialState $= "")
		%obj.initialState = "0";
	if (%obj.correctState $= "")
		%obj.correctState = "1";

	//Is it pressed by default?
	%this.activate(%obj, %obj.initialState);
}

function ToggleButton::onCollision(%this, %obj, %col, %vec, %vecLen, %material) {
	if (!GameBaseData::onCollision(%this, %obj, %col, %vec, %vecLen, %material)) return;
	// Currently activates when any object hits it.
	%this.activate(%obj, !%obj._activated);
}

function ToggleButton::activate(%this, %obj, %state) {
	//Don't press it many times
	if (%obj._disabled)
		return;
	%obj._disabled = true;
	%obj.schedule(2000, "setFieldValue", "_disabled", "");

	//Literally copied from the other button
	if (%state) {
		%obj.playThread(0, "push");
		%obj.setThreadDir(0, true);
		%obj.playAudio(0, ButtonClick);
		%obj._activated = true;
	} else {
		%obj.setThreadDir(0, false);
		%obj.playThread(0, "push");
		%obj.playAudio(0, ButtonClick);
		%obj._activated = false;
	}

	//Don't scan if we're restarting
	%group = %obj.getGroup();
	//Because I know Matan will make some group of buttons all correct by default
	// and be confused when it doesn't activate, so:
	%this.onNextFrame("scanGroup", %obj, %group);
}

function ToggleButton::scanGroup(%this, %obj, %group) {
	//Pay no attention to the massive hack iterating from "" to n
	for (%state = ""; %obj.correctState[%state] !$= ""; %state ++) {
		%scan = %this.scanGroupState(%group, %state);
		%this.activateGroup(%group, %scan, %state);
	}
}

function ToggleButton::scanGroupState(%this, %group, %state) {
	for (%i = 0; %i < %group.getCount(); %i ++) {
		%obj = %group.getObject(%i);
		//Check other buttons in this group to see if anyone is wrong
		if (%obj.getClassName() $= "StaticShape" && %obj.getDatablock() == %this) {
			if (%obj._activated !$= %obj.correctState[%state]) {
				//Someone is wrong, we're done here
				return false;
			}
		}
		if (%obj.getClassName() $= "SimGroup") {
			//Because I bet Matan will put a group of buttons in a group
			if (!%this.scanGroupState(%obj, %state)) {
				return false;
			}
		}
	}
	//Hey! Everyone is correct!
	return true;
}

function ToggleButton::activateGroup(%this, %group, %activated, %state) {
	if (isObject(%group.targetPathedInterior[%state])) {
		//Time and instantness are based on if you're correct
		%time = (%activated ? %group.correctTargetTime[%state] : %group.incorrectTargetTime[%state]);
		//Because I know Matan will ask for this
		%instant = (%activated ? %group.correctInstant[%state] : %group.incorrectInstant[%state]);

		if (%activated && isObject(%group.correctSfx[%state])) {
			serverPlay2d(%group.correctSfx[%state]);
		}
		if (!%activated && isObject(%group.incorrectSfx[%state])) {
			serverPlay2d(%group.incorrectSfx[%state]);
		}

		//Because one might not exist
		if (%time !$= "") {
			if (%instant)
				%group.targetPathedInterior[%state].setPathPosition(%time);
			else
				%group.targetPathedInterior[%state].setTargetPosition(%time);
		}
	}
}

function ToggleButton::onMissionReset(%this, %obj) {
	//Don't activate when we're resetting the mission.
	%obj._resetting = true;
	//Is it pressed by default?
	%this.activate(%obj, %obj.initialState);
	%obj._resetting = "";
}

function ToggleButton::triggerCallback(%this, %obj) {
	// N/A
}

datablock StaticShapeData(ToggleButtonFlat_PQ : ToggleButton) {
	shapeFile = "~/data/shapes_pq/Gameplay/pads/PushButtonFlatHalf.dts";
};

function ToggleButtonFlat_PQ::onAdd(%this, %obj) {
	ToggleButton::onAdd(%this, %obj);
}
function ToggleButtonFlat_PQ::onCollision(%this, %obj, %col, %vec, %vecLen, %material) {
	ToggleButton::onCollision(%this, %obj, %col, %vec, %vecLen, %material);
}
function ToggleButtonFlat_PQ::activate(%this, %obj, %state) {
	ToggleButton::activate(%this, %obj, %state);
}
function ToggleButtonFlat_PQ::scanGroup(%this, %obj, %group) {
	ToggleButton::scanGroup(%this, %obj, %group);
}
function ToggleButtonFlat_PQ::scanGroupState(%this, %group, %state) {
	ToggleButton::scanGroupState(%this, %group, %state);
}
function ToggleButtonFlat_PQ::activateGroup(%this, %group, %activated, %state) {
	ToggleButton::activateGroup(%this, %group, %activated, %state);
}
function ToggleButtonFlat_PQ::onMissionReset(%this, %obj) {
	ToggleButton::onMissionReset(%this, %obj);
}
function ToggleButtonFlat_PQ::triggerCallback(%this, %obj) {
	ToggleButton::triggerCallback(%this, %obj);
}
