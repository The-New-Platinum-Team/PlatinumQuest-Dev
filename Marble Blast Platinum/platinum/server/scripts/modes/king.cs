//-----------------------------------------------------------------------------
// King Mode
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

function Mode_king::onLoad(%this) {
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("shouldStoreGem");
	%this.registerCallback("getStartTime");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("timeMultiplier");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_king::onMissionLoaded(%this) {
	// Make triggers for the King stuff
	buildKingEmitters(MissionGroup);
}

function buildKingEmitters(%group) {
	%count = %group.getCount();

	for (%i = 0; %i < %count; %i++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();

		if (%class $= "SimGroup")
			buildKing(%obj);
		else if (%class $= "Trigger" &&
		         %obj.getDataBlock().getName() $= "KingTrigger" &&
		         !%obj.noEmitters) {

			if (%obj._builtEmitters) {
				continue;
			}
			%obj._builtEmitters = true;

			// create position array for each emitter to be placed around
			// the corner of the physmod trigger. I mean king trigger.
			%pos = %obj.getTransform();
			%scale = %obj.getScale();
			%x = getWord(%pos, 0);
			%y = getWord(%pos, 1);
			%z = getWord(%pos, 2);
			%sX = getWord(%scale, 0);
			%sY = getWord(%scale, 1);
			%sZ = getWord(%scale, 2);

			%pos[0] = %x SPC %y SPC %z;
			%pos[1] = %x + %sX SPC %y SPC %z;
			%pos[2] = %x SPC %y - %sY SPC %z;
			%pos[3] = %x + %sX SPC %y - %sY SPC %z;
			%pos[4] = %x SPC %y SPC %z + %sZ;
			%pos[5] = %x + %sX SPC %y SPC %z + %sZ;
			%pos[6] = %x SPC %y - %sY SPC %z + %sZ;
			%pos[7] = %x + %sX SPC %y - %sY SPC %z + %sZ;
			// Draw physmod shape on each corner
			for (%j = 0; %j <= 3; %j++) {
				%staticShape = new StaticShape() {
					position = %pos[%j];
					rotation = "1 0 0 0";
					scale = "1 1 1";
					datablock = PhysModEmitterBase;
				};
				MissionCleanup.add(%staticShape);
				$PhysModStaticShape[%obj.getId()] = %staticShape;
			}
			//%staticShape = new StaticShape() {
			//	position = %pos[0];
			//	rotation = "1 0 0 0";
			//	scale = %sX SPC %sY SPC %sZ;
			//	dataBlock = "WaterCylinder";
			//};
			//MissionCleanup.add(%staticShape);
			//$PhysModStaticShape[%obj.getId()] = %staticShape;

			// Draw 6 rectangles that correspond to the king trigger
			//%rectpos[0] = %pos[0] SPC %pos[1] SPC %pos[2];
			//%rectsize[0] = %sX/8 SPC %sY/8 SPC 0.001;
			//%rectpos[1] = %pos[4] SPC %pos[5] SPC %pos[6];
			//%rectsize[1] = %sX/8 SPC %sY/8 SPC 0.001;
			//%rectpos[2] = %pos[0] SPC %pos[1] SPC %pos[4];
			//%rectsize[2] = 0.001 SPC %sY/8 SPC %sZ/8;
			//for (%j = 0; %j <= 2; %j++) {
			//	%staticShape = new StaticShape() {
			//		position = %rectpos[%j];
			//		rotation = "1 0 0 0";
			//		scale = %rectsize[%j];
			//		dataBlock = "WaterPlane";
			//	};
			//}
		}
	}
}

function Mode_king::onFoundGem(%this, %object) {
//	%object.client.playPitchedSound("gotDiamond");
	%object.client.displayGemMessage("+1", "ff0000");
	return false;
}

function Mode_king::shouldStoreGem(%this, %object) {
}
function Mode_king::getStartTime(%this) {
	return (MissionInfo.time ? MissionInfo.time : 300000);
}
function Mode_king::shouldResetTime(%this, %object) {
	return false;
}
function Mode_king::shouldRestartOnOOB(%this, %object) {
	return false;
}
function Mode_king::shouldRespawnGems(%this, %object) {
	return false;
}
function Mode_king::timeMultiplier(%this) {
	return -1;
}
function GameConnection::enterKingTrigger(%this, %trigger) {
	%this.kingTrigger = %trigger;
	%this.updateKingTrigger();
}
function GameConnection::leaveKingTrigger(%this, %trigger) {
	%this.kingTrigger = false;
}
function GameConnection::updateKingTrigger(%this) {
	cancel(%this.kingSchedule);
	if (!$Game::Finished) {
		if (isObject(%this.kingTrigger)) {
			%points = %this.kingTrigger.multiplier $= "" ? 1.0 : %this.kingTrigger.multiplier;
			if (%points < 1) {
				%this.tempPoints += %points;
				if (%this.tempPoints > 1) {
					%points = mFloor(%this.tempPoints);
					%this.tempPoints -= %points;
					%this.onFoundGem(%points);
				}
			} else {
				%this.onFoundGem(%points);
			}
		} else {
			if (%this.gemCount > 0) {
				%this.gemCount -= 1;
				%this.setGemCount(%this.getGemCount());
			}
		}
		updateScores();
		%this.kingSchedule = %this.schedule(1000, "updateKingTrigger");
	}
}


//-----------------------------------------------------------------------------

datablock TriggerData(KingTrigger) {
	tickPeriodMS = 100;

	customField[0, "field"  ] = "multiplier";
	customField[0, "type"   ] = "float";
	customField[0, "name"   ] = "Multiplier";
	customField[0, "desc"   ] = "How many points per second this trigger gives.";
	customField[0, "default"] = "1";
};

function KingTrigger::onEnterTrigger(%this, %trigger, %obj) {
	%obj.client.enterKingTrigger(%trigger);
}

function KingTrigger::onLeaveTrigger(%this, %trigger, %obj) {
	%obj.client.leaveKingTrigger(%trigger);
}
