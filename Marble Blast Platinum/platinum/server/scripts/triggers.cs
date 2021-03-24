//-----------------------------------------------------------------------------
// Portions Copyright (c) 2021 The Platinum Team
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
// Torque Game Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

// Normally the trigger class would be sub-classed to support different
// functionality, but we're going to use the name of the trigger instead
// as an experiment.

datablock TriggerData(DefaultTrigger) {
	tickPeriodMS = 100;
};

function Trigger::isPointInside(%this, %point, %checkBoundsToo) {
	return isPointInsideBox(%point, %this.getWorldBox(), %checkBoundsToo);
}

function Trigger::setBounds(%this, %box) {
	%this.polyhedron = "0 0 0 1 0 0 0 1 0 0 0 1";
	%trans = BoxMin(%box);
	%scale = VectorSub(BoxMax(%box), BoxMin(%box));
	%this.setTransform(%trans);
	%this.setScale(%scale);
}

//-------------------------------------

function Trigger::onMissionReset(%this) {
	%this.getDataBlock().onMissionReset(%this);
}
function TriggerData::onMissionReset(%this, %obj) {

}

//-------------------------------------

function Trigger::onInspectApply(%this) {
	%this.getDataBlock().onInspectApply(%this);
}

function TriggerData::onInspectApply(%this, %obj) {

}

//-------------------------------------

function Trigger::onCheckpointReset(%this) {
	%this.getDataBlock().onCheckpointReset(%this);
}
function TriggerData::onCheckpointReset(%this, %obj) {

}

//-------------------------------------

function Trigger::onActivateCheckpoint(%this) {
	%this.getDataBlock().onActivateCheckpoint(%this);
}
function TriggerData::onActivateCheckpoint(%this, %obj) {

}

//-----------------------------------------------------------------------------

datablock TriggerData(InBoundsTrigger) {
	tickPeriodMS = 100;
};

function InBoundsTrigger::onLeaveTrigger(%this,%trigger,%obj) {
	if (%obj.noPickup)
		return;

	// Leaving an in bounds area.
	%obj.getDatablock().onOutOfBounds(%obj);
}

//-----------------------------------------------------------------------------

datablock TriggerData(OutOfBoundsTrigger) {
	tickPeriodMS = 100;
};

function OutOfBoundsTrigger::onEnterTrigger(%this,%trigger,%obj) {
	if (%obj.noPickup)
		return;

	// Entering an out of bounds area
	%obj.getDatablock().onOutOfBounds(%obj);
}

//-----------------------------------------------------------------------------

datablock TriggerData(HelpTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "text";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Help Text";
	customField[0, "desc"   ] = "Text that is shown to the player when they enter the trigger.";
	customField[0, "default"] = "Help Text";
	customField[1, "field"  ] = "displayonce";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Only Display Once";
	customField[1, "desc"   ] = "If the trigger should only show once (resets on restart).";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "persistTime";
	customField[2, "type"   ] = "time";
	customField[2, "name"   ] = "Persist Time";
	customField[2, "desc"   ] = "For how long the help message will be visible after entering the trigger.";
	customField[2, "default"] = "5000";
	customField[3, "field"  ] = "extended";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Use Extended Help";
	customField[3, "desc"   ] = "If the extended help dialog should be used instead.";
	customField[3, "default"] = "0";
};

function HelpTrigger::onAdd(%this, %obj) {
	if (%obj.text $= "")
		%obj.text = "Help Text";
	if (%obj.displayonce $= "")
		%obj.displayonce = 0;
	if (%obj.persistTime $= "")
		%obj.persistTime = 5000;
	if (%obj.extended)
		%obj.extended = 0;
}

function HelpTrigger::onEnterTrigger(%this,%trigger,%obj) {
	if (!%trigger.displayonce || %trigger._resettime != $Game::ResetTime) {
		%trigger._resettime = $Game::ResetTime;

		if (%obj._lastHelper !$= %trigger) {
			//Play the noise
			%obj.client.play2D(HelpDingSfx);
		}
		%obj._lastHelper = %trigger;

		%time = (%trigger.persistTime ? 0 : 5000);
		%obj.client.addBubbleLine(%trigger.text, %trigger.extended, %time, true);
		cancel(%obj.client.downsched);
		cancel(%obj.client.clearHelperSch);
	}
}

function HelpTrigger::onLeaveTrigger(%this,%trigger,%obj) {
	//It will disappear itself if the trigger doesn't persist
	if (%trigger.persistTime !$= "") {
		cancel(%obj.client.downsched);
		%obj.client.downsched = %obj.client.schedule(%trigger.persistTime, hideBubble);
		%obj.client.clearHelperSch = %obj.schedule(%trigger.persistTime + 1000, "setFieldValue", "_lastHelper", "");
	}
}

//-----------------------------------------------------------------------------

datablock TriggerData(SpawnTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "gravity";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Use Gravity";
	customField[0, "desc"   ] = "If true, the trigger will spawn the player with gravity relative to the trigger's rotation on respawn.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "center";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Use Center";
	customField[1, "desc"   ] = "Use the trigger's center instead of spawning at its \"position\" (corner).";
	customField[1, "default"] = "1";
};

function SpawnTrigger::onAdd(%this, %obj) {
	if (!isObject(SpawnPointSet)) {
		new SimSet(SpawnPointSet);
		RootGroup.add(SpawnPointSet);
	}
	SpawnPointSet.add(%obj);

	if (%obj.gravity $= "")
		%obj.gravity = "0";
}

function SpawnTrigger::blockSpawning(%this, %obj) {
	%obj._block = true;
	%this.schedule(1000, "unblockSpawning", %obj);
}

function SpawnTrigger::unblockSpawning(%this, %obj) {
	%obj._block = false;
}

datablock StaticShapeData(SpawnPoint) {
	shapeFile = "~/data/shapes_pq/Other/SpawnPoint.dts";
};

function SpawnPoint::onAdd(%this, %obj) {
	%obj = nameToId(%obj);
	MissionGroup.add(%trigger = new Trigger(%obj.getName()) {
		position = %obj.position;
		rotation = %obj.rotation;
		scale = %obj.scale;
		datablock = "SpawnTrigger";
		polyhedron = "0.0000000 0.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 -1.0000000 0.0000000 0.0000000 0.0000000 1.0000000";
	});

	%trigger.gravity = %obj.useGravityDir;
	//Need to detach this
	%obj.onNextFrame(delete);
}

//-----------------------------------------------------------------------------
//Trigger that disables movement keys on your marble

datablock TriggerData(NoMovementKeysTrigger) {
	tickPeriodMS = 100;
};

function NoMovementKeysTrigger::onEnterTrigger(%this,%trigger,%obj) {
	%obj.client.movementTriggers ++;
	if (%obj.client.movementTriggers == 1) {
		%obj.client.setMovementKeysEnabled(false);
	}
}

function NoMovementKeysTrigger::onLeaveTrigger(%this,%trigger,%obj) {
	%obj.client.movementTriggers --;
	if (%obj.client.movementTriggers == 0) {
		%obj.client.setMovementKeysEnabled(true);
	}
}

//-----------------------------------------------------------------------------

datablock TriggerData(RepetitiveTriggerGotoTarget) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "NumTimesToTrigger";
	customField[0, "type"   ] = "numeric";
	customField[0, "name"   ] = "Times to Trigger";
	customField[0, "desc"   ] = "How many times the player has to enter the trigger to activate it.";
	customField[0, "default"] = "Help Text";
	customField[1, "field"  ] = "TriggerOnce";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Only Trigger Once";
	customField[1, "desc"   ] = "If the trigger only activates one time.";
	customField[1, "default"] = "1";
	customField[2, "field"  ] = "NumTimesToRepeat";
	customField[2, "type"   ] = "numeric";
	customField[2, "name"   ] = "Times to Repeat";
	customField[2, "desc"   ] = "If triggered, entering the trigger a multiple of this many times will activate it again.";
	customField[2, "default"] = "0";
	customField[3, "field"  ] = "ActivateOnLap";
	customField[3, "type"   ] = "numeric";
	customField[3, "name"   ] = "Activate on Lap #";
	customField[3, "desc"   ] = "If laps mode, the trigger will only activate on this lap.";
	customField[3, "default"] = "0";
	customField[4, "field"  ] = "targetTime";
	customField[4, "type"   ] = "numeric";
	customField[4, "name"   ] = "Target Time";
	customField[4, "desc"   ] = "The time to which the PathedInterior will travel when the trigger is activated.";
	customField[4, "default"] = "999999";
	customField[5, "field"  ] = "delayTargetTime";
	customField[5, "type"   ] = "numeric";
	customField[5, "name"   ] = "Delayed Target Time";
	customField[5, "desc"   ] = "Optional time for DelayTriggerGoToTargets to use.";
	customField[5, "default"] = "";
};

function RepetitiveTriggerGotoTarget::onEnterTrigger(%this,%trigger,%obj) {
	if ($Game::isMode["laps"] && (%trigger.ActivateOnLap > 0) && (%trigger.ActivateOnLap > %obj.client.lapsCounter))
		return;

	%trigger._entercount[%obj]++;
	if (%trigger._enternum[%obj] $= "") {
		%trigger._enternum[%trigger._enters] = %obj;
		%trigger._enternum[%obj] = %trigger._enters;
		%trigger._enters ++;
	}

	if (%trigger._entercount[%obj] < %trigger.NumTimesToTrigger)
		return;
	if (%trigger.TriggerOnce == 1 &&  %trigger._entercount[%obj] > %trigger.NumTimesToTrigger)
		return;
	if (%trigger._Triggered == 1 && %trigger.NumTimesToRepeat != 0 && (%trigger._entercount[%obj] - %trigger.NumTimesToTrigger) % %trigger.NumTimesToRepeat != 0)
		return;

	%grp = %trigger.getGroup();
	for (%i = 0; (%plat = %grp.getObject(%i)) != -1; %i++) {
		if (%plat.getClassName() $= "PathedInterior") {
			if (%trigger.delayTargetTime !$= "")
				%plat.delayTargetTime = %trigger.delayTargetTime;
			%plat.setTargetPosition(%trigger.targetTime);
			%trigger._Triggered = 1;
		}
	}
}

function RepetitiveTriggerGotoTarget::onLeaveTrigger(%this,%trigger,%obj) {

}

function RepetitiveTriggerGotoTarget::onAdd(%this, %obj) {
	if (%obj.NumTimesToTrigger $= "")
		%obj.NumTimesToTrigger = " ";

	if (%obj.TriggerOnce $= "")
		%obj.TriggerOnce = "1";

	if (%obj.NumTimesToRepeat $= "")
		%obj.NumTimesToRepeat = "0";

	if (%obj.ActivateOnLap $= "")
		%obj.ActivateOnLap = "0";

	%obj._enters = 0;
}

function RepetitiveTriggerGotoTarget::onMissionReset(%this,%trigger) {
	for (%i = 0; %i < %trigger._enters; %i ++) {
		%obj = %trigger._enternum[%i];
		%trigger._entercount[%obj] = "";
		%trigger._enternum[%obj] = "";
		%trigger._enternum[%i] = "";
	}
	%trigger._enters = 0;
	%trigger._Triggered = 0;
}

//-----------------------------------------------------------------------------

datablock TriggerData(UsePowerupTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "powerup";
	customField[0, "type"   ] = "ItemData";
	customField[0, "class"  ] = "PowerUp";
	customField[0, "name"   ] = "PowerUp";
	customField[0, "desc"   ] = "Which PowerUp to activate when the player enters the trigger.";
	customField[0, "default"] = "SuperJumpItem";
};

function UsePowerupTrigger::onEnterTrigger(%this,%trigger,%obj) {
	%powerup = %trigger.powerup;

	commandToClient(%obj.client, 'doPowerUp', %powerup.powerUpId);
	%powerup.onUse(%trigger, %obj);
}

function UsePowerupTrigger::onAdd(%this, %obj) {
	if (%obj.powerup $= "")
		%obj.powerup = "SuperJumpItem";
}


//-----------------------------------------------------------------------------

datablock TriggerData(GemChangeTrigger) {
	tickPeriodMS = 50;
	greenMessageColor = "99ff99";
	grayMessageColor = "cccccc";
	redMessageColor = "ff9999";

	customField[0, "field"  ] = "gemBonus";
	customField[0, "type"   ] = "numeric";
	customField[0, "name"   ] = "Gem Change Amount";
	customField[0, "desc"   ] = "How many points to add or subtract.";
	customField[0, "default"] = -1;
};

function GemChangeTrigger::onEnterTrigger(%this,%trigger,%obj) {
	if (%trigger.gemBonus $= "")
		%trigger.gemBonus = -1; // made default, the "-1" here and in the later part of the code, are because -1 is the default

	if (%trigger.gemBonus < 0 && %obj.client.gemCount < mAbs(%trigger.gemBonus)) { // in the case where gems would subtract into the negative
		if (%obj.client.gemCount != 0) { // give no call to the client if they already have 0 gems
			%obj.client.gemCount = 0;   // - works only silently, doesn't update gem counter
			%obj.client.setGemCount(0); // - works only visually, updates only gem counter
		}
	} else {
		%obj.client.gemCount += %trigger.gemBonus;
		%obj.client.setGemCount(%obj.client.gemCount + %trigger.gemBonus);

	}

	%bonus = (%trigger.gemBonus $= "" ? -1 : %trigger.gemBonus);
	%color = (%bonus == 0 ? %this.grayMessageColor : (%bonus < 0 ? %this.redMessageColor : %this.greenMessageColor));
	%sign = (%bonus > 0 ? "+" : "");

	//Show a message
	%obj.client.displayGemMessage(%sign @ %bonus, %color);
}

//-----------------------------------------------------------------------------

datablock TriggerData(TimeTravelTrigger) {
	tickPeriodMS = 50;

	//For the time message
	greenMessageColor = "99ff99";
	grayMessageColor = "cccccc";
	redMessageColor = "ff9999";

	customField[0, "field"  ] = "timeBonus";
	customField[0, "type"   ] = "time";
	customField[0, "name"   ] = "Time Bonus";
	customField[0, "desc"   ] = "How much bonus time to add.";
	customField[0, "default"] = $Game::TimeTravelBonus;
};

function TimeTravelTrigger::onEnterTrigger(%this,%trigger,%obj) {
	if (%trigger.timeBonus $= "")
		%trigger.timeBonus = $Game::TimeTravelBonus;

	%obj.client.incBonusTime(%trigger.timeBonus);

	%bonus = (%trigger.timeBonus $= "" ? $Game::TimeTravelBonus : %trigger.timeBonus);
	%color = (%bonus == 0 ? %this.grayMessageColor : (%bonus < 0 ? %this.redMessageColor : %this.greenMessageColor));

	//Hunt maps are reversed
	%sign = (Mode::callback("timeMultiplier", 1) > 0 ? (%bonus < 0 ? "+" : "-") : (%bonus < 0 ? "-" : "+"));

	//Show a message
	%obj.client.displayGemMessage(%sign @ mAbs(%bonus / 1000) @ "s", %color);
}

//-----------------------------------------------------------------------------
//Trigger that disables movement keys on your marble

datablock TriggerData(TimeStopTrigger) {
	tickPeriodMS = 100;
};

function TimeStopTrigger::onEnterTrigger(%this,%trigger,%obj) {
	//Don't do this in MP
	if ($Server::ServerType $= "MultiPlayer")
		return;

	%obj.client.timeStopTriggers ++;
	if (%obj.client.timeStopTriggers == 1) {
		$Game::TimeStoppedClients ++;
		if ($Game::TimeStoppedClients == 1) {
			Time::stop();
			commandToClient(%obj.client, 'UpdateTimeTravelCountdown'); // main_gi v4.2.3: Update TT timer even in a timestop
		}
	}
}

function TimeStopTrigger::onLeaveTrigger(%this,%trigger,%obj) {
	//Don't do this in MP
	if ($Server::ServerType $= "MultiPlayer")
		return;

	%obj.client.timeStopTriggers --;
	if (%obj.client.timeStopTriggers <= 0) {
		%obj.client.timeStopTriggers = 0;
		$Game::TimeStoppedClients --;
		if ($Game::TimeStoppedClients == 0) {
			Time::start();
		}
		//If we do this above, it will detect leaving a trigger on restart
		if ($Game::TimeStoppedClients <= 0) {
			$Game::TimeStoppedClients = 0;
		}
	}
}

//-----------------------------------------------------------------------------

datablock TriggerData(CameraDistanceTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "Time";
	customField[0, "type"   ] = "time";
	customField[0, "name"   ] = "Time";
	customField[0, "desc"   ] = "For how long the transition should take";
	customField[0, "default"] = "1000";
	customField[1, "field"  ] = "Smooth";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Smooth";
	customField[1, "desc"   ] = "If the distance transition should be smooth";
	customField[1, "default"] = "1";
	customField[2, "field"  ] = "Distance";
	customField[2, "type"   ] = "numeric";
	customField[2, "name"   ] = "Distance";
	customField[2, "desc"   ] = "Camera distance to set.";
	customField[2, "default"] = "2.5";
	customField[3, "field"  ] = "KeepEffectOnLeave";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Keep Effect on Leave";
	customField[3, "desc"   ] = "If the camera should not revert when leaving the trigger.";
	customField[3, "default"] = "1";
	customField[4, "field"  ] = "ForceExitValue";
	customField[4, "type"   ] = "numeric";
	customField[4, "name"   ] = "Force Exit Value";
	customField[4, "desc"   ] = "Optional value to force camera distance when leaving the trigger.";
	customField[4, "default"] = "0";
};

function CameraDistanceTrigger::onAdd(%this, %obj) {
	if (%obj.Time $= "")
		%obj.Time = "1000";

	if (%obj.Smooth $= "")
		%obj.Smooth = "1";

	if (%obj.Distance $= "")
		%obj.Distance = "2.5";

	if (%obj.KeepEffectOnLeave $= "")
		%obj.KeepEffectOnLeave = "1";

	if (%obj.ForceExitValue $= "")
		%obj.ForceExitValue = "0";

	%obj.setSync("onReceiveTrigger");
}

//-----------------------------------------------------------------------------

datablock TriggerData(AlignmentTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "x";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Align X";
	customField[0, "desc"   ] = "If the trigger should align you on the x-axis.";
	customField[0, "default"] = "none";
	customField[1, "field"  ] = "y";
	customField[1, "type"   ] = "string";
	customField[1, "name"   ] = "Align Y";
	customField[1, "desc"   ] = "If the trigger should align you on the y-axis.";
	customField[1, "default"] = "trigger";
	customField[2, "field"  ] = "z";
	customField[2, "type"   ] = "string";
	customField[2, "name"   ] = "Align Z";
	customField[2, "desc"   ] = "If the trigger should align you on the z-axis.";
	customField[2, "default"] = "none";
	customField[3, "field"  ] = "alwaysOn";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Always On";
	customField[3, "desc"   ] = "If on, the trigger will always align when the marble is inside it.";
	customField[3, "default"] = "0";
};

function AlignmentTrigger::onAdd(%this, %obj) {
	if (%obj.X $= "")      //Align marble to a position (useful for 2d)
		%obj.X = "none";    //Input:         Output:
	//
	if (%obj.Y $= "")      //Any Number     Align to this specific coordinate
		%obj.Y = "trigger"; //trigger        Align to trigger's center coordinate
	//none           Don't align this coordinate
	if (%obj.Z $= "")
		%obj.Z = "none";

	if (%obj.alwaysOn $= "")
		%obj.alwaysOn = "0";

	%obj.setSync("onReceiveTrigger");
}

//-----------------------------------------------------------------------------

//UNFINISHED CODE, but should work, but could use more features
datablock TriggerData(PathTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "TriggerOnce";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Only Trigger Once";
	customField[0, "desc"   ] = "If the trigger should only work once.";
	customField[0, "default"] = "true";
};

function PathTrigger::onEnterTrigger(%this, %trigger, %obj) {
	if (%trigger.TriggerOnce && %trigger._resetTime == $Game::ResetTime)
		return;
	else
		%trigger._resetTime = $Game::ResetTime;  //maybe port this system up to the RTGTT if it works well

	%i = 1;

	while (isObject(%trigger.Object[%i])) {
		if (isObject(%trigger.Path[%i]))
			%path = %trigger.Path[%i];
		%trigger.Object[%i].MoveOnPath(%path, %trigger.InitialPosition[%i]);
		%i ++;
	}
}

function PathTrigger::onAdd(%this, %obj) {
	//if (%obj.NumTimesToTrigger $= "")
	//	%obj.NumTimesToTrigger = "1";

	if (%obj.TriggerOnce $= "")
		%obj.TriggerOnce = "1";

	//if (%obj.NumTimesToRepeat $= "")
	//	%obj.NumTimesToRepeat = "0";
}

//-----------------------------------------------------------------------------

datablock TriggerData(EventConnectionTrigger) {
	tickPeriodMS = 100;
};

function EventConnectionTrigger::onEnterTrigger(%this, %trigger, %user) {
	//Don't let us hit the same trigger twice in a row
	if (%user.client.lastEventTrigger == %trigger)
		return;
	//If another trigger is trying to send its message, we should wait
	if (%user.client.eventTimeout > getSimTime()) {
		%this.schedule(1000, onEnterTrigger, %trigger, %user);
		return;
	}

	statsRecordEventTrigger(%user.client, %trigger.achId, %trigger);

	%timeout = (%trigger.timeout $= "" ? 5000 : %trigger.timeout);

	%this.user.client.eventTimeout = getSimTime() + %timeout;
	%this.user.client.lastEventTrigger = %trigger;

	if (%trigger.rolloverText !$= "")
		%user.client.addHelpLine(%trigger.rolloverText);
}

function EventConnectionTrigger::onEventLine(%this, %trigger, %line, %client) {
	//Send text when it goes through
	if (%trigger.text[%line] !$= "") {
		%delay   = (%trigger.delay   $= "" ? 5000 : %trigger.delay);
		%timeout = (%trigger.timeout $= "" ? 5000 : %trigger.timeout) + %delay;

		%client.eventTimeout = getSimTime() + %timeout;
		%client.lastEventTrigger = %trigger;
		%client.schedule(%delay, addHelpLine, %trigger.text[%line]);
	}
}

//-----------------------------------------------------------------------------

datablock TriggerData(FinishTrigger) {
	tickPeriodMS = 100;
};

function FinishTrigger::onEnterTrigger(%this,%trigger,%obj) {
	if (Mode::callback("onEnterPad", false, new ScriptObject() {
		client = %obj.client;
		isFinishTrigger = true;
		_delete = true;
	}))
	return;

	if (%obj.client.canFinish()) {
		%obj.client.player.setMode(Victory);
		messageClient(%obj.client, 'MsgRaceOver', %obj.client.getFinishMessage());
		$Game::FinishClient = %obj.client;
		endGameSetup();
	} else {
		%obj.client.playPitchedSound("missinggems");
		messageClient(%obj.client, 'MsgMissingGems', %obj.client.getFinishMessage());
	}
}

//-----------------------------------------------------------------------------

// NOTICE: If we need lock powerup trigger combined with ice shard, or if the
// trigger is really big and a cannon is inside of it, let someone know so they can
// prevent edge cases araising from the locking mechanism getting screwed up.

datablock TriggerData(LockPowerupTrigger) {
	tickPeriodMS = 100;
};

function LockPowerupTrigger::onEnterTrigger(%this,%trigger,%obj) {
	commandToClient(%obj.client, 'LockPowerup', true);
}

function LockPowerupTrigger::onLeaveTrigger(%this,%trigger,%obj) {
	commandToClient(%obj.client, 'LockPowerup', false);
}


//-----------------------------------------------------------------------------

datablock TriggerData(SetVelocityTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "velocity";
	customField[0, "type"   ] = "Point3F";
	customField[0, "name"   ] = "Velocity";
	customField[0, "desc"   ] = "Velocity the trigger will set.";
	customField[0, "default"] = "0 0 0";
	customField[1, "field"  ] = "ignoreX";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Ignore X";
	customField[1, "desc"   ] = "If the trigger should not affect velocity on the x-axis.";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "ignoreY";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Ignore Y";
	customField[2, "desc"   ] = "If the trigger should not affect velocity on the y-axis.";
	customField[2, "default"] = "0";
	customField[3, "field"  ] = "ignoreZ";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Ignore X";
	customField[3, "desc"   ] = "If the trigger should not affect velocity on the z-axis.";
	customField[3, "default"] = "0";
};

function SetVelocityTrigger::onEnterTrigger(%this,%trigger,%obj) {
	%vel = %trigger.velocity;
	if (%trigger.ignoreX) %vel = setWord(%vel, 0, getWord(%obj.getVelocity(), 0));
	if (%trigger.ignoreY) %vel = setWord(%vel, 1, getWord(%obj.getVelocity(), 1));
	if (%trigger.ignoreZ) %vel = setWord(%vel, 2, getWord(%obj.getVelocity(), 2));
	%obj.setVelocity(%vel);
}

function SetVelocityTrigger::onAdd(%this, %obj) {
	if (%obj.Velocity $= "")
		%obj.Velocity = "0 0 0";
	if (%obj.ignoreX $= "")
		%obj.ignoreX = 0;
	if (%obj.ignoreY $= "")
		%obj.ignoreY = 0;
	if (%obj.ignoreZ $= "")
		%obj.ignoreZ = 0;
}

//-----------------------------------------------------------------------------

datablock TriggerData(CancelVelocityTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "cancelX";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Cancel X";
	customField[0, "desc"   ] = "If the trigger should cancel velocity on the x-axis.";
	customField[0, "default"] = "0";
	customField[1, "field"  ] = "cancelY";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Cancel Y";
	customField[1, "desc"   ] = "If the trigger should cancel velocity on the y-axis.";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "cancelZ";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Cancel X";
	customField[2, "desc"   ] = "If the trigger should cancel velocity on the z-axis.";
	customField[2, "default"] = "0";
};

function CancelVelocityTrigger::onEnterTrigger(%this,%trigger,%obj) {
	%vel = %obj.getVelocity();

	%velx = !%trigger.cancelX ? getWord(%vel, 0) : 0;
	%vely = !%trigger.cancelY ? getWord(%vel, 1) : 0;
	%velz = !%trigger.cancelZ ? getWord(%vel, 2) : 0;

	%obj.setVelocity(%velx SPC %vely SPC %velz);
}

function CancelVelocityTrigger::onAdd(%this, %obj) {
	if (%obj.CancelX $= "")
		%obj.CancelX = "0";

	if (%obj.CancelY $= "")
		%obj.CancelY = "1";

	if (%obj.CancelZ $= "")
		%obj.CancelZ = "0";

}

//-----------------------------------------------------------------------------

datablock TriggerData(DisableShapeForceTrigger) {
	tickPeriodMS = 100;
};

function DisableShapeForceTrigger::onEnterTrigger(%this,%trigger,%marble) {
	%i = 0;
	while (isObject(%trigger.target[%i++])) {
		%trigger.target[%i].setPoweredState(!!%trigger.invert);
	}
}

function DisableShapeForceTrigger::onLeaveTrigger(%this,%trigger,%marble) {
	%i = 0;
	while (isObject(%trigger.target[%i++])) {
		%trigger.target[%i].setPoweredState(!%trigger.invert);
	}
}

function DisableShapeForceTrigger::onAdd(%this, %obj) {
	if (%obj.invert $= "")
		%obj.invert = 0;
	if (%obj.target[1] $= "")
		%obj.target[1] = "ObjectName";
}

//-----------------------------------------------------------------------------

/// This trigger keeps the bubble activated while the client is inside of it.
/// All of this is simulated on the client side as the powerup code resides on
/// the client.
datablock TriggerData(BubbleUseTrigger) {
	tickPeriodMS = 100;
};

function BubbleUseTrigger::onAdd(%this, %obj) {
	%obj.setSync("onReceiveTrigger");
}

//-----------------------------------------------------------------------------

datablock TriggerData(CameraTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "pitch";
	customField[0, "type"   ] = "float";
	customField[0, "name"   ] = "Pitch";
	customField[0, "desc"   ] = "Camera pitch to set";
	customField[0, "default"] = "NoChange";
	customField[1, "field"  ] = "yaw";
	customField[1, "type"   ] = "float";
	customField[1, "name"   ] = "Yaw";
	customField[1, "desc"   ] = "Camera yaw to set";
	customField[1, "default"] = "NoChange";
	customField[2, "field"  ] = "useRadians";
	customField[2, "type"   ] = "boolean";
	customField[2, "name"   ] = "Use Radians";
	customField[2, "desc"   ] = "If the values are in radians";
	customField[2, "default"] = "1";
};

function CameraTrigger::onAdd(%this, %obj) {
	if (%obj.pitch $= "")
		%obj.pitch = "NoChange";
	if (%obj.yaw $= "")
		%obj.yaw = "NoChange";
	if (%obj.useRadians $= "")
		%obj.useRadians = "1";

	%obj.setSync("onReceiveTrigger");
}

//-----------------------------------------------------------------------------

if (!isObject(AchievementTriggerSet)) {
	RootGroup.add(new SimSet(AchievementTriggerSet));
}

datablock TriggerData(AchievementTrigger){
	tickPeriodMS = 100;
};

function AchievementTrigger::onAdd(%this, %obj) {
	if (%obj.ordered $= "")
		%obj.ordered = "0";
	if (%obj.index $= "")
		%obj.index = "-1";
	if (%obj.resetOnCheckpoint $= "")
		%obj.resetOnCheckpoint = "1";
	if (%obj.achievementCategory $= "")
		%obj.achievementCategory = "1";
	if (%obj.achievementNumber $= "")
		%obj.achievementNumber = "-1";
	if (%obj.minGemCount $= "")
		%obj.minGemCount = "0";

	AchievementTriggerSet.add(%obj);
}

function AchievementTrigger::onMissionReset(%this, %obj) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.nextAchievementTrigger = 0;
		%client.hasAchievementTrigger[%obj.index] = 0;
	}
}

function AchievementTrigger::onCheckpointReset(%this, %obj) {
	if (!%obj.resetOnCheckpoint)
		return;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.nextAchievementTrigger = %client.checkpointNextAchievementTrigger;
		%client.hasAchievementTrigger[%obj.index] = %client.checkpointHasAchievementTrigger[%obj.index];
		%client.hasAchievementTrigger[%obj] = %client.checkpointHasAchievementTrigger[%obj];
	}
}

function AchievementTrigger::onActivateCheckpoint(%this, %obj) {
	if (!%obj.resetOnCheckpoint)
		return;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.checkpointNextAchievementTrigger = %client.nextAchievementTrigger;
		%client.checkpointHasAchievementTrigger[%obj.index] = %client.hasAchievementTrigger[%obj.index];
		%client.checkpointHasAchievementTrigger[%obj] = %client.hasAchievementTrigger[%obj];
	}
}

function AchievementTrigger::onEnterTrigger(%this, %trigger, %user) {
	if (%trigger.ordered) {
		if (%user.client.nextAchievementTrigger == %trigger.index) {
			devecho("Activate ordered achievement trigger index " @ %trigger.index);
			%user.client.nextAchievementTrigger ++;

			//Check for victory
			%count = AchievementTriggerSet.getCount();
			for (%i = 0; %i < %count; %i ++) {
				%other = AchievementTriggerSet.getObject(%i);
				if (%other.index > %trigger.index)
					return;
			}
			//Minimum to get this achievement
			if (%user.client.getGemCount() < %trigger.minGemCount) {
				return;
			}
			//Nothing else is higher, we got the achievement!
			%user.client.activateAchievement(%trigger.achievementCategory, %trigger.achievementNumber);
		}
	} else {
		devecho("Activate unordered achievement trigger id " @ %trigger.getId());

		//Check for victory
		%count = AchievementTriggerSet.getCount();
		%user.client.hasAchievementTrigger[%trigger] = true;
		for (%i = 0; %i < %count; %i ++) {
			%other = AchievementTriggerSet.getObject(%i);
			if (!%user.client.hasAchievementTrigger[%other])
				return;
		}
		//Minimum to get this achievement
		if (%user.client.getGemCount() < %trigger.minGemCount) {
			return;
		}
		//Nothing else is higher, we got the achievement!
		%user.client.activateAchievement(%trigger.achievementCategory, %trigger.achievementNumber);
	}
}

//-----------------------------------------------------------------------------

datablock TriggerData(CountdownStartTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "time";
	customField[0, "type"   ] = "time";
	customField[0, "name"   ] = "Time";
	customField[0, "desc"   ] = "How long the countdown lasts.";
	customField[0, "default"] = "10000";
	customField[1, "field"  ] = "icon";
	customField[1, "type"   ] = "string";
	customField[1, "name"   ] = "Timer Icon";
	customField[1, "desc"   ] = "Name of the icon to put next to the countdown timer. Should be the name of a file in platinum/client/ui/game/countdown/";
	customField[1, "default"] = "timerTimeTravel";
	customField[2, "field"  ] = "startDelay";
	customField[2, "type"   ] = "time";
	customField[2, "name"   ] = "Start Delay";
	customField[2, "desc"   ] = "How long to wait before starting the countdown.";
	customField[2, "default"] = "0";
	customField[3, "field"  ] = "activateOnce";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Only Activate Once";
	customField[3, "desc"   ] = "If the trigger should only activate once (resets on restart).";
	customField[3, "default"] = "0";
};

function CountdownStartTrigger::onEnterTrigger(%this, %trigger, %user) {
	if (%trigger.activateOnce && %trigger._resetTime == $Game::ResetTime)
		return;
	else
		%trigger._resetTime = $Game::ResetTime;

	%user.countdownSch = schedule(%trigger.startDelay, 0, commandToAll, 'StartCountdown', %trigger.time, %trigger.icon);
}

//-----------------------------------------------------------------------------

// Since I know someone is going to request it
datablock TriggerData(CountdownStopTrigger) {
	tickPeriodMS = 100;
};

function CountdownStopTrigger::onEnterTrigger(%this, %trigger, %user) {
	cancel(%user.countdownSch);
	commandToAll('StartCountdown', 0); //Lazy
}
