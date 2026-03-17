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

datablock PathedInteriorData(PathedDefault) {
	customField[0, "field"  ] = "initialTargetPosition";
	customField[0, "type"   ] = "int"; //Technically time but can be negative
	customField[0, "name"   ] = "Initial Target Position";
	customField[0, "desc"   ] = "At restart will start traveling towards this time along the path. -1 for looping forwards, -2 for looping backwards.";
	customField[0, "default"] = "";
	customField[1, "field"  ] = "initialPosition";
	customField[1, "type"   ] = "int"; //Technically time but can be negative
	customField[1, "name"   ] = "Initial Path Position";
	customField[1, "desc"   ] = "At restart will be at this time along the path.";
	customField[1, "default"] = "";
};

datablock PathedInteriorData(PathedMovingBlock) { // TODO PathedMovingBlock : PathedDefault?
	customField[0, "field"  ] = "initialTargetPosition";
	customField[0, "type"   ] = "int"; //Technically time but can be negative
	customField[0, "name"   ] = "Initial Target Position";
	customField[0, "desc"   ] = "At restart will start traveling towards this time along the path. -1 for looping forwards, -2 for looping backwards.";
	customField[0, "default"] = "";
	customField[1, "field"  ] = "initialPosition";
	customField[1, "type"   ] = "int"; //Technically time but can be negative
	customField[1, "name"   ] = "Initial Path Position";
	customField[1, "desc"   ] = "At restart will be at this time along the path.";
	customField[1, "default"] = "";
};

function PathedInteriorData::onMissionReset(%data, %obj) {
	if (Mode::callback("shouldResetPath", true, new ScriptObject() {
		this = %this;
		_delete = true;
	})) {
		if (%obj.initialPosition !$= "")
			%obj.setPathPosition(%obj.initialPosition);
		else
			%obj.setPathPosition(0);
		if (%obj.initialTargetPosition !$= "")
			%obj.setTargetPosition(%obj.initialTargetPosition);
		else
			%obj.setTargetPosition(0);
	}
}

function PathedInterior::onTrigger(%this,%temp,%triggerMesg) {
	// default just makes it loop
	if (%triggerMesg == "true")
		%triggerMesg = -2;

	%this.setTargetPosition(%triggerMesg);
}

function PathedInterior::getPath(%this) {
	%group = %this.getGroup();
	for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
		if(%obj.getClassName() $= "Path") {
			return %obj;
		}
	}
	return -1;
}

function PathedInterior::recenterPath(%this) {
	%path = %this.getPath();
	if(isObject(%path)) {
		%offset = VectorSub(%this.getWorldBoxCenter(), %path.getObject(0).getWorldBoxCenter());
		for(%i = 0; (%obj = %path.getObject(%i)) != -1; %i++) {
			%obj.setTransform(VectorAdd(%offset, %obj.getPosition()));
		}
	}
}

function PathedInterior::onEditorCopy(%this) {
	%group = %this.getGroup();
	if(%group.getName() $= "MustChange_g")
		EWorldEditor.onNextFrame("noteMCGroupSelected", %group);
}

function PathedInterior::onEditorPaste(%this) {
	%group = %this.getGroup();
	if(EWorldEditor.mcGroupIsSelected[%group] || %group.getName() $= "MissionGroup")
		MustChange_g::toNewGroup(%group, %this);

	%this.setTargetPosition(%this.initialTargetPosition);
	if(%this.initialTargetPosition < 0)
		syncMovingPlatforms();
}

function PathedInterior::onEditorDelete(%this) {
	%group = %this.getGroup();
	if(%group.getName() $= "MustChange_g") {
		if(EWorldEditor.cut)
			return;
		for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
			if(%obj != %this && %obj.getClassName() $= "PathedInterior") {
				return; // Path is still in use
			}
		}
		%group.onNextFrame("delete");
	}
}

function PathedInterior::inspectPostApply(%this) {
	return;
}

function PathedInterior::onInspectApply(%this) {
	%this.setPathPosition(%this.initialPosition);
	%this.setTargetPosition(%this.initialTargetPosition);
	if(%this.initialTargetPosition < 0)
		syncMovingPlatforms();
}

datablock TriggerData(TriggerGotoTarget) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "targetTime";
	customField[0, "type"   ] = "int";
	customField[0, "name"   ] = "Target Time";
	customField[0, "desc"   ] = "Time along path the trigger will start traveling towards. -1 for looping forwards, -2 for looping backwards.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "instant";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Instant";
	customField[1, "desc"   ] = "Instantly warp to the target time along the path.";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "IContinueToTTime";
	customField[2, "type"   ] = "time";
	customField[2, "name"   ] = "Continue Target Time";
	customField[2, "desc"   ] = "If instant, the platform will start traveling towards this time after warping. Zero to disable.";
	customField[2, "default"] = "0";
	customField[3, "field"  ] = "delayTargetTime";
	customField[3, "type"   ] = "time";
	customField[3, "name"   ] = "Delay Target Time";
	customField[3, "desc"   ] = "If the player enters a TriggerGotoDelayTarget after this trigger, the platform will continue to this time.";
	customField[3, "default"] = "0";
};

function TriggerGotoTarget::onEnterTrigger(%this,%trigger,%obj) {
	%grp = %trigger.getGroup();
	for (%i = 0; (%plat = %grp.getObject(%i)) != -1; %i++) {
		if (%plat.getClassName() $= "PathedInterior") {
			if (%trigger.delayTargetTime !$= "")
				%plat.delayTargetTime = %trigger.delayTargetTime;
			if (%trigger.instant) {
				%plat.onNextFrame("setPathPosition", %trigger.targetTime);
				if (%trigger.IContinueToTTime) {
					%plat.onNextFrame("setTargetPosition", %trigger.IContinueToTTime);
				}
			} else if (!%trigger.instant) {
				%plat.onNextFrame("setTargetPosition", %trigger.targetTime);
			}
		}
	}
}

function TriggerGotoTarget::onLeaveTrigger(%this, %trigger, %obj) {

}

function TriggerGotoTarget::onAdd(%this, %trigger) {
	// Target time (normal)

	if (%trigger.targetTime $= "")
		%trigger.targetTime = 0;

	// Choose whether you want to snap the MP back to its starting position or whether it will go back by itself. Don't have marble in the same area, it could cause insta-OOB.
	// Example: a MP has a path of 40 seconds, but the marble falls off 30 seconds into the ride. You can use 'Instant' to get the MP called back without having to wait the entire path.
	// Replaces Trigger Go To Targets!

	if (%trigger.instant $= "")
		%trigger.instant = 0;
	// After using "instant", the MP can be allocated a new "target time". You can use it to be the same or different value as the original Target Time.
	// Example: a MP has a path of 40 seconds, but the marble falls off 30 seconds into the ride.
	// You can use 'Instant' to get the MP called back, and then set IContinueToTTime to 40 seconds so that the MP will go its full path again.
	// This way, not matter how many times the marble will fall, the MP will always go on its allocated route.
	// This is easier and better to use than multiple Trigger Go To Targets

	if (%trigger.IContinueToTTime $= "")
		%trigger.IContinueToTTime = 0;

	// Use this to delay any aforementioned applied effects for this period of time (in ms)
	//if (%trigger.delay $= "")
	//%trigger.delay = 0;    (disabled atm)
}

function TriggerGotoTarget::getPath(%this, %trigger) {
	%group = %trigger.getGroup();
	for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
		if(%obj.getClassName() $= "Path") {
			return %obj;
		}
	}
	return -1;
}

function TriggerGotoTarget_onEditorDelete(%this, %trigger) {
	%group = %trigger.getGroup();

	if(%group.getName() !$= "MissionGroup") {
		for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
			if(%obj != %trigger && %obj.getDataBlock().getName() $= "TriggerGotoTarget")
				return; // Still using a trigger
		}
		for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
			if(%obj.getClassName() $= "PathedInterior") {
				%obj.initialTargetPosition = -1;
				%obj.setTargetPosition(-1); // Start looping again
			}
		}
		syncMovingPlatforms();
	}
}

function TriggerGotoTarget_onEditorPaste(%this, %trigger) {
	%group = %trigger.getGroup();
	if(EWorldEditor.mcGroupIsSelected[%group] || %group.getName() $= "MissionGroup")
		MustChange_g::toNewGroup(%group, %trigger);
}

function TriggerGotoTarget::onInspectApply(%this, %trigger) {
	if(%trigger.targetSeqNum !$= "") {
		%path = %this.getPath(%trigger);
		if(isObject(%path))
			%path.recalcTime();
	}
}

datablock TriggerData(TriggerGotoDelayTarget) {
	tickPeriodMS = 100;
};

function TriggerGotoDelayTarget::onEnterTrigger(%this,%trigger,%obj) {
	%grp = %trigger.getGroup();
	for (%i = 0; (%plat = %grp.getObject(%i)) != -1; %i++) {
		if (%plat.getClassName() $= "PathedInterior")
			%plat.setTargetPosition(%plat.delayTargetTime);
	}
}

function TriggerGotoDelayTarget::onLeaveTrigger(%this, %trigger, %obj) {

}

function TriggerGotoDelayTarget::getPath(%this, %trigger) {
	return TriggerGotoTarget.getPath(%trigger);
}

function TriggerGotoDelayTarget_onEditorDelete(%this, %trigger) {
	TriggerGotoTarget_onEditorDelete(TriggerGotoTarget, %trigger);
}

function TriggerGotoDelayTarget_onEditorPaste(%this, %trigger) {
	TriggerGotoTarget_onEditorPaste(TriggerGotoTarget, %trigger);
}

function Path::onMissionReset(%this) {
	if (%this.isLooping) { //TODO should just implement this in the engine
		%this.isLooping = false;

		%first = %this.getObject(0);
		if (%this.getObject(%this.getCount() - 1).position !$= %first.position) {
			%this.add(new Marker() {
				position = %first.position;
				rotation = %first.rotation;
				scale = %first.scale;
				seqNum = %this.getObject(%this.getCount() - 1).seqNum + 1;
			});
		}
	}
	// Populate empty paths if needed
	if(%this.getCount() < 2) {
		%group = %this.getGroup();
		for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++){
			if(%obj.getClassName() $= "PathedInterior") {
				if(%this.getCount() < 1) {
					%this.add(new Marker() {
						position = %obj.getWorldBoxCenter();
						msToNext = 1000;
						seqNum = 0;
					});
				}
				%this.add(new Marker() {
					position = %this.getObject(0).position;
					msToNext = 1000;
					seqNum = 1;
				});
				break;
			}
		}
	}
}

function Path::setSpeed(%this, %speed) {
	%this.speed = %speed;
	%this.recalcTime();
	%this.update();
}

function Path::recalcTime(%this) {
	// Update triggers
	%group = %this.getGroup();
	for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
		if(%obj.targetSeqNum $= "")
			continue;

		if(!%builtCumTimes) {
			%cumTimes[%this.getObject(0).seqNum] = 0;
			for(%j = 1; (%m2 = %this.getObject(%j)) != -1; %j++) {
				%m1 = %this.getObject(%j-1);
				%cumTimes[%m2.seqNum] = %cumTimes[%m1.seqNum] + %m1.msToNext;
			}
			%builtCumTimes = true;
		}
		// Fall back if we can't find the target marker
		while(%cumTimes[%obj.targetSeqNum] $= "" && %obj.targetSeqNum > 0) {
			%obj.targetSeqNum--;
		}

		%obj.targetTime = %cumTimes[%obj.targetSeqNum];
	}

	if(%this.speed $= "")
		return;

	// Update markers
	for(%i = 1; (%m2 = %this.getObject(%i)) != -1; %i++) {
		%m1 = %this.getObject(%i-1);
		%dist = VectorDist(%m1.position, %m2.position);
		%m1.msToNext = 1000 * (%dist / %this.speed);
	}
}

function Path::setSmoothingType(%this, %type) {
	for(%i = 0; %i < %this.getCount(); %i++) {
		%m1 = %this.getObject(%i);
		%m1.smoothingType = %type;
	}
	%this.update();
}

function Marker::onEditorSetTransform(%this) {
	Parent::onEditorSetTransform(%this);
	%path = %this.getGroup();
	if(%path.getClassName() $= "Path") {
		%path.onNextFrame("recalcTime");
		%path.onNextFrame("update");

		// If it's the first marker or there's a stopped platform, we need to update the offset
		%group = %path.getGroup();
		for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
			if(%obj.getClassName() $= "PathedInterior")
				if(%this == %path.getObject(0) || %obj.getPathPosition() == %obj.getTargetPosition())
					%obj.onNextFrame("refreshPath");
		}
	}
}

function Marker::onInspectApply(%this) {
	%path = %this.getGroup();
	if(%path.getClassName() $= "Path") {
		%path.recalcTime();
		%path.update();
	}
}

function Marker::onEditorCopy(%this) {
	%group = %this.getGroup().getGroup();
	if(%group.getName() $= "MustChange_g")
		EWorldEditor.onNextFrame("noteMCGroupSelected", %group);
}

function Marker::onEditorPaste(%this) {
	%path = %this.getGroup();
	if(%path.getClassName() !$= "Path") {
		MustChange_g::toNewGroup(%path, %this);
		return;
	}

	%group = %path.getGroup();
	if(EWorldEditor.mcGroupIsSelected[%group]) {
		MustChange_g::toNewGroup(%group, %this);
		return;
	}

	for(%i = 0; (%obj = %path.getObject(%i)) != -1; %i++) {
		if(%this != %obj && %this.seqNum == %obj.seqNum) {
			%conflict = 1;
			break;
		}
	}
	if(%conflict != 1)
		return; // Can use this seqNum

	%num = %this.seqNum;
	for(%i = 0; (%obj = %path.getObject(%i)) != -1; %i++) {
		if(%obj.seqNum >= %num + 1) {
			%obj.seqNum++;
		}	
		if(%obj.seqNum < %num) {
			if(%prev $= "" || %obj.seqNum > %prev.seqNum)
				%prev = %obj;
		}
		if(%obj.seqNum > %num) {
			if(%next $= "" || %obj.seqNum < %next.seqNum)
				%next = %obj;
		}
	}

	// Update any indexed path triggers
	for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
		if(%obj.targetSeqNum !$= "" && %this.seqNum < %obj.targetSeqNum)
			%obj.targetSeqNum++;
	}

	%this.seqNum = %num + 1;
	
	%path.onNextFrame("recalcTime");
	%path.onNextFrame("update");
}

function Marker::onEditorDelete(%this) {
	if(EWorldEditor.cut)
		return; // Assume the user is gonna paste them back

	%path = %this.getGroup();
	if(%path.getClassName() !$= "Path")
		return;

	%group = %path.getGroup();

	if(%path.getCount() == 1 && !EWorldEditor.cut) {
		if(%group.getCount() == 1) {
			%group.onNextFrame("delete");
			return;
		}
		// Still using this MustChange_g
		%path.add(new Marker() {
			position = %this.position;
			smoothingType = %this.smoothingType;
		});
	}

	%num = %this.seqNum;

	for(%i = 0; (%obj = %path.getObject(%i)) != -1; %i++) {
		if(%obj == %this)
			continue;
		if(%obj.seqNum > %num) {
			%obj.seqNum--;
			if(%next $= "" || %obj.seqNum < %next.seqNum)
				%next = %obj;
		}
	}

	// Fallback if we deleted the last marker
	if(%next $= "")
		%next = %path.getObject(%path.getCount() - 2);

	// Update any indexed path triggers
	for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
		if(%obj.targetSeqNum !$= "" && %obj.targetSeqNum > 0 && %this.seqNum < %obj.targetSeqNum)
			%obj.targetSeqNum--;
	}

	EWorldEditor.onNextFrame("selectSingle", %next);
	%path.onNextFrame("recalcTime");
	%path.onNextFrame("update");
}

function Marker::moveToStart(%this) {
	%group = %this.getGroup();
	if(%group.getClassName() $= "Path") {
		%this.setTransform(%group.getObject(0).getTransform());
		%this.onEditorSetTransform();
	}
}

function MustChange_g::toNewGroup(%this, %obj) {
	if(!isObject(%this._newGroup)) {
		%this._newGroup = new SimGroup(MustChange_g) {
			new Path();
		};
	}
	if(%obj.getClassName() $= "Marker")
		%this._newGroup.getObject(0).add(%obj);
	else
		%this._newGroup.add(%obj);
	onNextFrame("eval", %this @ "._newGroup = -1;");
}

function syncMovingPlatforms() {
	for(%i = 0; (%group = MissionGroup.getObject(%i)) != -1; %i++) {
		if (%group.getName() $= "MustChange_g") {
			for(%j = 0; (%obk = %group.getObject(%j)) != -1; %j++) {
				if (%obk.getClassName() $= "PathedInterior" && (%obk.getTargetPosition() < 0 || %obk.initialTargetPosition < 0)) {
					%obk.onMissionReset();
				}
			}
		}
	}
}