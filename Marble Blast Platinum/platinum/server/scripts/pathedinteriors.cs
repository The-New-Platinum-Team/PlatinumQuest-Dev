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

datablock AudioProfile(MovingBlockSustainSfx)
{
   filename = "~/data/sound/MovingBlockLoop.wav";
   description = AudioClosestLooping3d;
   preload = true;
};

datablock PathedInteriorData(PathedDefault) {
	foo = bla;

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

datablock PathedInteriorData(PathedMovingBlock) {
	sustainSound = MovingBlockSustainSfx;

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

//   echo(%this.delayTargetTime);
	%this.setTargetPosition(%triggerMesg);
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
	// Entering an out of bounds area
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

datablock TriggerData(TriggerGotoDelayTarget) {
	tickPeriodMS = 100;
};

function TriggerGotoDelayTarget::onEnterTrigger(%this,%trigger,%obj) {
	%grp = %trigger.getGroup();
	for (%i = 0; (%plat = %grp.getObject(%i)) != -1; %i++) {
		if (%plat.getClassName() $= "PathedInterior")
			%plat.setTargetPosition(%plat.delayTargetTime);
	}
	// Entering an out of bounds area
}

function TriggerGotoDelayTarget::onLeaveTrigger(%this, %trigger, %obj) {

}


function Path::onMissionReset(%this) {
//	echo("add path:" SPC %this);
//	echo("looping:" SPC %this.isLooping);
	if (%this.isLooping) {
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
}

function Marker::onEditorDrag(%this) {
	//Wow major hack -- update paths so the platforms move
	pathOnMissionLoadDone();
}
