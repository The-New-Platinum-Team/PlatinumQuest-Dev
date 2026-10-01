//------------------------------------------------------------------------------
// Multiplayer Package
// serverParticles.cs
//
// Copyright (c) 2013 The Platinum Team
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

datablock ParticleEmitterNodeData(MPEmitterNode) {
	// hack, timeMultiple sends across the network, so use this
	// to determine if we are a MPEmitterNode
	timeMultiple = 1.001;
};

// see documentation on this in clientParticles.cs
// for the use of powerup emitters only in multiplayer.
datablock ParticleEmitterNodeData(MPPowerupNode) {
	timeMultiple = 1.002;
};

// transfer particles to the clients
//
// %isPowerup is optional and lets us know if the particle if from a powerup
// this is used so that we can hide particles if they are our own on the client
// %rotation allows you to specify the emitter rotation for direction-based particles
/**
 * @param {GameConnection} %this
 * @param {Type} %emitter
 */
function GameConnection::transferParticles(%this, %emitter, %isEnginePowerup, %rotation) {
	// failsafe checks to make sure this doesn't happen if we don't need it
	if (!isObject(%this.player) || !isObject(%emitter))
		return;

	// %scale is based off of the current player's scale, used to determine
	// which particle emitter goes with which on the client side.
	%scale     = %this.player.getScale();
	%position  = %this.player.getPosition();
	%datablock = %isEnginePowerup ? MPPowerupNode : MPEmitterNode;

	if (%rotation $= "") {
		%rotation = "1 0 0 0";
	} else {
		//Torque uses degrees, but only for new()
		%rotation = setWord(%rotation, 3, getWord(%rotation, 3) * (180 / $pi));
	}

	%particle = new ParticleEmitterNode() {
		datablock = %datablock;
		emitter   = %emitter;
		position  = %position;
		rotation  = %rotation;
		scale     = %scale;
		trail     = "1";
		attachId  = %this.player.getSyncId();
	};
	MissionCleanup.add(%particle);
	%particle.setScopeAlways();

	// if we are a powerup, use that time, else use emitter.lifeTimeMS
	switch$ (%emitter) {
	case MarbleSuperJumpEmitter:
		%emitterTime = %this.player.getDataBlock().powerUpTime[1];
	case MarbleSuperSpeedEmitter:
		%emitterTime = %this.player.getDataBlock().powerUpTime[2];
	default:
		%emitterTime = %emitter.lifeTimeMS;
	}

	// local host gets 0 for this but we want to help those a tiny bit
	// with latency issues.  ServerConnection is actually 15MS according to
	// the method, however for some odd reason client.getping on server is 0Ms
	%ping = %this.getPing();
	if (%ping < $PingMin)
		%ping = $PingMin;

	// give extra time before deleting for latency.
	%time = getAveragePing() + %ping + %emitterTime + 100;
	%time = nanCheck(%time, 1000);
	%particle.schedule(%time, "delete");

	%particle.setScopeAlways();
	%particle.forceNetUpdate();
}
