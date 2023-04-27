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
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("getStartTime");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_king::onMissionReset(%this) {
	cancel($MP::Schedule::Collision);
	MPupdateCollisionKing();
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

//-----------------------------------------------------------------------------
//Marble collision stuff
function MPupdateCollisionKing() {
	cancel($MP::Schedule::CollisionKing);
	if ($Server::Dedicated && getRealPlayerCount() == 0)
		return;

	if (!$Server::Hosting || $Server::_Dedicated || $Server::ServerType $= "SinglePlayer")
		return;

	//just in case
	if (!$Game::isMode["king"])
		return;


	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!isObject(%client.player))
			continue;
		%player = %client.player;
		if (isObject(%player)) {
			%datablock1 = %client.player.getDatablock();
			%pos_p = %client.player.getPosition();
			for (%j = 0; %j < %count; %j ++) {
				if (%j == %i)
					continue;
				%clientJ = ClientGroup.getObject(%j);
				if (!isObject(%clientJ.player))
					continue;

				%datablock2 = %clientJ.player.getDatablock();
				%pos_o = %clientJ.player.getPosition();

				%mega1 = %client.isMegaMarble();
				%mega2 = %clientJ.isMegaMarble();

				%dist = VectorDist(%pos_p, %pos_o);
				%d2 = %dist - ((%client.player.getCollisionRadius() - %clientJ.player.getCollisionRadius()) / 2);

				//The first big change to this code
				//This is so non-mega collisions use the regular marble size
				if (%mega1) {
					%dist -= %datablock1.impactRadius[%mega1];
				} else if (!%mega1) {
					%dist -= 0.27;
				}

				if (%mega2) {
					%dist -= %datablock1.impactRadius[%mega2];
				} else if (!%mega2) {
					%dist -= 0.27;
				}
				
				if (%dist < 0) {

					if (%client.lastCollision == %clientJ)
						continue;
					if (%clientJ.lastCollision == %client)
						continue;
					if (%client.lastColTime[%clientJ] !$= "" && %client.lastColTime[%clientJ] + 1000 > getRealTime())
						continue;
					if (%clientJ.lastColTime[%client] !$= "" && %clientJ.lastColTime[%client] + 1000 > getRealTime())
						continue;

					//This line is what disables regular marble collisions normally
					//if (!%mega1 && !%mega2)
						//continue;

					if ((%mega1 == %mega2 && VectorLen(%client.player.getVelocity()) < VectorLen(%clientJ.player.getVelocity())) || (%mega2 && !%mega1))
						continue;

					%skip = false;
					if (%client.noCol) {
						%client.noCol --;
						%skip = true;
					}
					if (%clientJ.noCol) {
						%clientJ.noCol --;
						%skip = true;
					}
					if (%skip)
						continue;

					%client.lastCollision = %clientJ;
					%clientJ.lastCollision = %client;
					%client.lastColTime[%clientJ] = getRealTime();
					%clientJ.lastColTime[%client] = getRealTime();

					//Here's where all the numbers are changed
					//Regular marble collision is supposed to be weaker than mega marble collision
					//Values taken from marble.cs and defaults.cs
					if (%mega1) {
						%maximum  = %datablock1.impactMaximum[%mega1];
					} else if (!%mega1) {
						%maximum = 25;
					}
					if (%mega2) {
						%maximum2 = %datablock2.impactMaximum[%mega2];
					} else if (!%mega2) {
						%maximum2 = 25;
					}

					if (%mega1) {
						%multiplier  = %datablock1.impactMultiplier[%mega1];
					} else if (!%mega1) {
						%multiplier = 4;
					}
					if (%mega2) {
						%multiplier2 = %datablock2.impactMultiplier[%mega2];
					} else if (!%mega2) {
						%multiplier2 = 4;
					}

					if (%mega1) {
						%reduction  = %datablock1.impactReduction[%mega1];
					} else if (!%mega1) {
						%reduction = 0.25;
					}
					if (%mega2) {
						%reduction2 = %datablock2.impactReduction[%mega2];
					} else if (!%mega2) {
						%reduction2 = 0.25;
					}


					if (%mega1) {
						%bSpeed = VectorLen(%client.player.getVelocity()) + (VectorLen(%clientJ.player.getVelocity()) * %datablock1.impactBounceBack[%mega1]);
					} else if (!%mega1) {
						%bSpeed = VectorLen(%client.player.getVelocity()) + (VectorLen(%clientJ.player.getVelocity()) * 0.5);
					}

					%source  = VectorSub(%pos_o, %pos_p);
					%source2 = VectorSub(%pos_p, %pos_o);

					%affect = %source;
					%affect2 = %source2;

					%affection  = min(%bSpeed * %multiplier,  %maximum);
					%affection2 = min(%bSpeed * %multiplier2, %maximum2);

					if ($MP::TeamMode && isObject(%clientJ.team) && isObject(%client.team)) {
						if (%clientJ.team.getId() == %client.team.getId()) {
							%affection  /= $MP::CollisionTeamDampen;
							%affection2 /= $MP::CollisionTeamDampen;
						}
					}

					%affect  = VectorScale(%affect,  %affection);
					%affect2 = VectorScale(%affect2, %reduction2);

					echo("Impulse to " @ %clientJ.namebase @ ": (" @ %source @ ") (" @ %affect @ ")");
					echo("Impulse to " @ %client.namebase @ ": (" @ %source2 @ ") (" @ %affect2 @ ")");

					if (!%client.disableCollision)
						commandToClient(%clientJ,'applyImpulse',%source,%affect);
					if (!%clientJ.disableCollision)
						commandToClient(%client,'applyImpulse',%source2,%affect2);

					Mode::callback("onCollision", "", new ScriptObject() {
						client1 = %client;
						client2 = %clientJ;
						source1 = %source;
						source2 = %source2;
						affect1 = %affect;
						affect2 = %affect2;
						_delete = true;
					});

					if (%mega1 || %mega2) {
						%sfx = eval("return MegaMarble.bounce" @ getRandom(1, 4) @ ";");
						%sfx2 = eval("return MegaMarble.bounce" @ getRandom(1, 4) @ ";");
						%client.play2d(%sfx);
						%clientJ.play2d(%sfx);
					}
				} else {
					%client.lastCollision = "";
				}
			}
		}
	}
	$MP::Schedule::CollisionKing = schedule($MP::Collision::Delta, 0, "MPupdateCollisionKing");
}