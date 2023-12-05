//-----------------------------------------------------------------------------
// Fireball PowerUp for MBPQ
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

datablock AudioProfile(doFireballSfx) {
	filename    = "~/data/sound/doSuperJump.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(PuFireballVoiceSfx) {
	filename    = "~/data/sound/puFireballVoice.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(PuFireballBlastSfx) {
	filename    = "~/data/sound/explode1_tweaked.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(FireballItem) {
	// Mission editor category
	superCategory = "PowerUps";
	category = "PlatinumQuest";
	className = "PowerUp";

	activeAudio = DoFireballSfx;
	pickupAudio = PuFireballVoiceSfx;

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/fireball.dts";
	emap = false;
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	// Dynamic properties defined by the scripts
	pickupName = "a Fireball PowerUp!";
	maxInventory = 1;

	respawnTime = 10000;

	fxEmitter[0] = "FireballItemEmitter";
	playAnimation = "1";

	customField[0, "field"  ] = "activeTime";
	customField[0, "type"   ] = "time";
	customField[0, "name"   ] = "Active Time";
	customField[0, "desc"   ] = "How long the fireball lasts.";
	customField[0, "default"] = "7000";
};

function FireballItem::onAdd(%this, %obj) {
	echo("FIREBALLITEM::ONADD: THIS ("@%this@") OBJ ("@%obj@")");
	if (%obj.activeTime $= "")
		%obj.activeTime = "7000";
	if (%this.playAnimation)
		%obj.playThread(0, "flame");
	//if (%obj.blastLimit $= "")
	//%obj.blastLimit = "2000";   //TODO: if we have blue fireball or whatever, can make that one more powerful or whatever

	//%obj.playThread(0,"SJanim1");
	PowerUp::onAdd(%this, %obj);

	%this.initFX(%obj);
}

function FireballItem::onPickup(%this, %obj, %user, %amount) {
	%disable = Mode::callback("shouldDisablePowerup", false, new ScriptObject() {
		this = %this;
		obj = %obj;
		user = %user;
		amount = %amount;
		_delete = true;
	});
	if (%disable) {
		return false;
	}
	echo("FIREBALLITEM::ONPICKUP: THIS ("@%this@") OBJ ("@%obj@") %user ("@%user@")");
	if (%user._fireballTime !$= "" && %obj.activeTime < %user._fireballTime - (getSimTime() - %user._fireballStartTime))
		return;
	%user._fireball = %obj;

	//Don't pick up a fireball with less time
	if (%user.client.getFireballTime() < %obj.activeTime) {
		%user.client.fireballInit(%obj.activeTime);
		return Parent::onPickup(%this, %obj, %user, %amount, 1);
	}
	return false;
	//Fireball::Init(MarbleObject, MarbleObject.fireball);
}

//------------------------------------------------

function serverCmdFireballBlast(%client, %position) {
	if (%client.player._fireballActive) {
		%client.player._fireball.getDataBlock().blast(%client.player._fireball, %client.player);
	}
}

function FireballItem::Blast(%this, %item, %marble) {
	%time = %marble._fireballTime - (getSimTime() - %marble._fireballStartTime);

	//calculate radius (maximum 3, minimum 1.5) for ice shards and destroy any within
	%radius = (%time / %item.activeTime) * 1.5 + 1.5;
	%mask = $TypeMasks::ShapeBaseObjectType;

	InitContainerRadiusSearch(%marble.getposition(), %radius, %mask);

	//monitorThis("MarbleObject.fireballTime");
	%smash = false;

	for (%obj = ContainerSearchNext(); isObject(%obj); %obj = ContainerSearchNext()) {
		if (%obj.getDatablock().className $= "IceShard" && %obj.getDamageState() !$= "Destroyed") {
			//%obj.startFade(0, 0, true);

			//add them to a reset list (also setDamageState destroyed in this function)
			%this.addIceShard(%item, %obj, %marble);
			//play sound, particles

			%pos = VectorAdd(%obj.getPosition(), "0 0 -0.5");
			spawnEmitter(1000, IceShardBreak1Emitter, %pos);
			spawnEmitter(1000, IceShardBreak2Emitter, %pos);
			%smash = true;
		}
	}

	if (%smash) {
		ServerPlay3D(IceShardSmashSfx, %marble.getTransform());
	}

	//adjust particle radius, sound volume, before firing
	//do particles, sound
	ServerPlay3D(PuFireballBlastSfx, %marble.getTransform());
	%pos = vectorAdd(%marble.getPosition(), "0 0 0.5");
	spawnEmitter(1000, Fireball1Emitter, %pos);
	spawnEmitter(1000, Fireball2Emitter, %pos);
	spawnEmitter(1000, Fireball4Emitter, %pos);
}

function FireballItem::addIceShard(%this, %item, %ice, %marble) {
	%ice.setDamageState("Destroyed");
	%ice.getDatablock().clearFX(%ice);

	//Tell the client to respawn this like it was a gem
	%ice._pickUp = %marble.client;
	%ice._pickUpCheckpoint = %marble.client.curCheckpointNum;
}

function FireballItem::IceCollision(%this, %item, %marble, %ice) {
	//sent here from iceshard collision if fireball is active
	echo("FIREBALL::ICECOLLISION: MARBLE ("@%marble@") ICE ("@%ice@")");
	if (!%marble._fireballActive)
		return false;

	//add ice shard to a reset list (also setDamageState destroyed in this function)
	%this.addIceShard(%item, %ice, %marble);

	%pos = VectorAdd(%ice.getPosition(), "0 0 -0.5");
	spawnEmitter(1000, IceShardBreak1Emitter, %pos);
	spawnEmitter(1000, IceShardBreak2Emitter, %pos);

	ServerPlay3D(IceShardSmashSfx, %marble.getTransform());

	//subtract time
	cancel(%marble._fireballSchedule);
	%marble._fireballTime -= 500;
	%marble.client.setFireballTime(%marble._fireballTime);
	%time = %marble._fireballTime - (getSimTime() - %marble._fireballStartTime);
	if (%time <= 0) {
		%marble.client.fireballExpire();
	} else {
		%time = %marble._fireballTime - (getSimTime() - %marble._fireballStartTime);
		if (%time < 0)
			return true;
		%marble._fireballSchedule = %marble.client.schedule(%time, "fireballExpire");
	}
	return true;
}

function GameConnection::fireballExpire(%this) {
	if (!%this.player._fireballActive)
		return;

	//called when fireball's time (energy) is done
	%this.player._fireballActive = 0;
	%this.player._fireball = "";
	cancel(%this.player._fireballSchedule);
	//deactivate particles
	commandToAll('FireballEndParticles', %this.index);
	//maybe play a fizzle sound
	//ServerPlay3D(PuFireballFizzleSfx, %marble.getTransform());
	commandToClient(%this, 'FireballExpire');
}

function GameConnection::setFireballTime(%this, %time) {
	commandToClient(%this, 'SetFireballTime', %time);
}

function GameConnection::fireballInit(%this, %time) {
	if (%this.player.inWater) {
		%this.play2D(fireballSizzleSfx);
		%this.setBubbleTime(0, false);
		%this.bubbleInfinite = false;
		return;
	}
	//called when fireball is activated
	%this.player._fireballActive = 1;
	%this.player._fireballTime = %time;
	%this.player._fireballStartTime = getSimTime();

	//Ruin their bubble
	%this.setBubbleTime(0, false);
	%this.bubbleInfinite = false;

	//activate GUI
	commandToAll('FireballStartParticles', %this.index);

	//Let the client know
	commandToClient(%this, 'FireballInit', %time);

	//And schedule it being put out
	cancel(%this.player._fireballSchedule);
	%this.player._fireballSchedule = %this.schedule(%time, "fireballExpire");
}

function GameConnection::getFireballTime(%this) {
	return max(0, %this.player._fireballTime - (getSimTime() - %this.player._fireballStartTime));
}

//Fireball:
//normally hits ice shards and lose 0.5 secs power per hit - if you have 1-499ms left and hit an ice shard, it destroys ice shard and fireball
//right click to "fire blast" - rebind to any button
//blast whatever 'X' time is left = power. It doesn't substract ANY time from the actual fireball, but has a 2 seconds cooldown
//blast power becomes smaller as you get less power - if you have less than 1000ms you can't blast anymore
//blast also kills ice shards in X radius which becomes smaller as time
//destroyed ice shard: where its the normal snow @ bottom but shattered from 10% height up, no effect on marble

//the marble should power right through the ice shard instead of bouncing off
//probably should have a slightly different-looking fireball item (blue flame?) that you can collect and hold

