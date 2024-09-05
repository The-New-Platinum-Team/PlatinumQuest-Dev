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
	%this.registerCallback("onFoundGem");
	%this.registerCallback("getStartTime");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	%this.registerCallback("enableMarbleCollisions");
	%this.registerCallback("shouldRestorePowerup");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_king::onFoundGem(%this, %object) {
//	%object.client.playPitchedSound("gotDiamond");
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
function Mode_king::getScoreType(%this) {
	return $ScoreType::Score;
}
function Mode_king::getFinalScore(%this, %object) {
	return $ScoreType::Score TAB %object.client.getGemCount();
}
function Mode_king::timeMultiplier(%this) {
	return -1;
}
function Mode_king::enableMarbleCollisions(%this) {
	return true;
}
function Mode_king::shouldRestorePowerup(%this) {
	return true;
}

//-----------------------------------------------------------------------------

function GameConnection::enterKingTrigger(%this, %trigger) {
	%this.kingTrigger = %trigger;
	%this.kingSchedule = %this.schedule(1000, updateKingTrigger);
}
function GameConnection::leaveKingTrigger(%this, %trigger) {
	%this.kingTrigger = false;
	cancel(%this.kingSchedule);
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
					%this.gemCount += %points;
					%this.setGemCount(%this.getGemCount());
					updateSingleScore(%this);
				}
			} else {
				%this.gemCount += %points;
				%this.setGemCount(%this.getGemCount());
				updateSingleScore(%this);
			}
		} else {
			//if (%this.gemCount > 0) {
				//%this.gemCount -= 1;
				//%this.setGemCount(%this.getGemCount());
				//updateSingleScore(%this);
			//}
		}
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

datablock ParticleData(KingTrigParticle) {
	textureName          = "platinum/data/particles/orb";
	dragCoefficient      = 1;
	gravityCoefficient   = 0.2;
	windCoefficient = 0;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 200;
	lifetimeVarianceMS   = 0;

	colors[0]     = "0.99 0.54 0.09 1";
	colors[1]     = "0.99 0.54 0.09 1";

	sizes[0]      = 1;
	sizes[1]      = 1;
};

datablock ParticleEmitterData(KingTrigEmitter) {
	ejectionPeriodMS = 7;
	periodVarianceMS = 0;
	ejectionVelocity = 2;
	velocityVariance = 1.0;
	ejectionOffset   = 0.0;
	thetaMin         = 0;
	thetaMax         = 60;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvances = false;
	particles = "KingTrigParticle";
	noHide = 1;
};

datablock ParticleEmitterNodeData(KingTrigEmitterNode) {
	timeMultiple = 1;
};

function KingTrigger::onAdd(%this, %trigger) {	
	%pos = %trigger.getTransform();
	%scale = %trigger.getScale();   //buildKingTrigger() or whatever it was called in here now. ~Connie
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

	%pos[8] = %x SPC %y - (%sY / 2) SPC %z;
	%pos[9] = %x + %sX SPC %y - (%sY / 2) SPC %z;

	%pos[10] = %x SPC %y - (%sY / 2) SPC %z + %sZ;
	%pos[11] = %x + %sX SPC %y - (%sY / 2) SPC %z + %sZ;

	%pos[12] = %x + (%sX / 2) SPC %y SPC %z;
	%pos[13] = %x + (%sX / 2) SPC %y - %sY SPC %z;

	%pos[14] = %x + (%sX / 2) SPC %y SPC %z + %sZ;
	%pos[15] = %x + (%sX / 2) SPC %y - %sY SPC %z + %sZ;

	for (%j = 0; %j < 16; %j++) {
		%emitter = new ParticleEmitterNode() {
			position = %pos[%j];
			rotation = "1 0 0 0";
			scale = "1 1 1";
			datablock = "KingTrigEmitterNode";
			emitter = "KingTrigEmitter";
		};
		MissionCleanup.add(%emitter);
		%trigger.ParticleEmitter[%j] = %emitter;
	}
}

function KingTrigger::onInspectApply(%this, %trigger) {
	for (%d = 0; %d < 16; %d++) {
		%trigger.ParticleEmitter[%d].getID().delete();   //Get rid of them all. ~Connie
	} 

	KingTrigger::onAdd(%this, %trigger);   //Then add them back. ~Connie
}

function KingTrigger::onEnterTrigger(%this, %trigger, %obj) {
	%obj.client.enterKingTrigger(%trigger);
	messageClient(%obj.client, 'MsgKTrigOne', "You have entered the King Trigger!");
	%obj.client.playPitchedSound("gotDiamond");
}

function KingTrigger::onLeaveTrigger(%this, %trigger, %obj) {
	%obj.client.leaveKingTrigger(%trigger);
	messageClient(%obj.client, 'MsgKTrigTwo', "You have exited the King Trigger!");
	%obj.client.playPitchedSound("missinggems");
}