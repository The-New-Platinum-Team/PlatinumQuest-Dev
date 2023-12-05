//------------------------------------------------------------------------------
// Multiplayer Package
// collision.cs
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

function MPupdateGhostCollision() {
	cancel($MP::Schedule::Collision);
	if ($Server::Dedicated && getRealPlayerCount() == 0)
		return;

	if (!$Server::Hosting || $Server::_Dedicated || $Server::ServerType $= "SinglePlayer")
		return;

	%nonMegaCollisions = (Mode::callback("enableMarbleCollisions", false));

	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!isObject(%client.player))
			continue;
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

			%dist = VectorDist(%pos_p, %pos_o);
			//%d2 = %dist - ((%client.player.getCollisionRadius() - %clientJ.player.getCollisionRadius()) / 2);

			%mega1 = %client.isMegaMarble();
			%mega2 = %clientJ.isMegaMarble();

			%dist -= %datablock1.impactRadius[%mega1];
			%dist -= %datablock2.impactRadius[%mega2];
			if (%dist > 0) {
				%client.lastCollision = "";
				continue;
			}

			if (%client.lastCollision == %clientJ)
				continue;
			if (%clientJ.lastCollision == %client)
				continue;
			if (%client.lastColTime[%clientJ] !$= "" && %client.lastColTime[%clientJ] + 1000 > getRealTime())
				continue;
			if (%clientJ.lastColTime[%client] !$= "" && %clientJ.lastColTime[%client] + 1000 > getRealTime())
				continue;

			//Don't apply collisions if no one has a mega marble, unless the mode requires them
			if (!%nonMegaCollisions && !%mega1 && !%mega2)
				continue;

			// The faster player wins, unless one player has a Mega
			if ((%mega1 == %mega2 && VectorLen(%client.player.getVelocity()) < VectorLen(%clientJ.player.getVelocity())) || (%mega2 && !%mega1))
				continue;

//               if (%client.speed < %datablock1.impactMinimum)
//                  continue;

//               %ray = ContainerRayCast(%client.player.position, VectorAdd(%client.player.position, %client.lastDifference), $TypeMasks::StaticShapeObjectType, %client.player);

			//collide
			%client.lastCollision = %clientJ;
			%clientJ.lastCollision = %client;
			%client.lastColTime[%clientJ] = getRealTime();
			%clientJ.lastColTime[%client] = getRealTime();

			//Maximum impulse multiplier =D
			%maximum  = %datablock1.impactMaximum[%mega1];
			%maximum2 = %datablock2.impactMaximum[%mega2];

			//Default multiplier
			%multiplier  = %datablock1.impactMultiplier[%mega1];
			%multiplier2 = %datablock2.impactMultiplier[%mega2];

			//Default reduction
			%reduction  = %datablock1.impactReduction[%mega1];
			%reduction2 = %datablock2.impactReduction[%mega2];

			//Calculate marble speed
			%bSpeed = VectorLen(%client.player.getVelocity()) + (VectorLen(%clientJ.player.getVelocity()) * %datablock1.impactBounceBack[%mega1]);

			//Get source vectors
			%source  = VectorSub(%pos_o, %pos_p);
			%source2 = VectorSub(%pos_p, %pos_o);

			//Get impulse vector
			%affect = %source;
			%affect2 = %source2;

			//Get impulse strength
			%affection  = min(%bSpeed * %multiplier,  %maximum);
			%affection2 = min(%bSpeed * %multiplier2, %maximum2);

			if ($MP::TeamMode && isObject(%clientJ.team) && isObject(%client.team) && %clientJ.team.getId() == %client.team.getId()) {
				%affection  /= $MP::CollisionTeamDampen;
				%affection2 /= $MP::CollisionTeamDampen;
			}

			//Scale impulse vector to stength
			%affect  = VectorScale(%affect,  %affection);
			%affect2 = VectorScale(%affect2, %reduction2);

			echo("Impulse to " @ %clientJ.getDisplayName() @ ": (" @ %source @ ") (" @ %affect @ ")");
			echo("Impulse to " @ %client.getDisplayName() @ ": (" @ %source2 @ ") (" @ %affect2 @ ")");

			//only affect the ghosted client...
			if (!%client.disableCollision)
				commandToClient(%clientJ, 'applyImpulse', %source, %affect);
			if (!%clientJ.disableCollision)
				commandToClient(%client, 'applyImpulse', %source2, %affect2);

			//Only allow points if the game has started
			if ($Game::State $= "Go") {
				Mode::callback("onCollision", "", new ScriptObject() {
					client1 = %client;
					client2 = %clientJ;
					source1 = %source;
					source2 = %source2;
					affect1 = %affect;
					affect2 = %affect2;
					_delete = true;
				});
			}
		}
	}
	$MP::Schedule::Collision = schedule($MP::Collision::Delta, 0, "MPupdateGhostCollision");
}

//-----------------------------------------------------------------------------

function Marble::getFrontPosition(%this) {
	%center = %this.getWorldBoxCenter();
	%diff = %this.client.posDiff;
	%diff = VectorNormalize(%diff);
	%diff = VectorScale(%diff, 0.2);
	return VectorAdd(%center, %diff);
}

function Marble::getBackPosition(%this) {
	%center = %this.getWorldBoxCenter();
	%diff = %this.client.posDiff;
	%diff = VectorNormalize(%diff);
	%diff = VectorScale(%diff, 0.2);
	return VectorSub(%center, %diff);
}

function Marble::getWidth(%this) {
	return VectorDot(%this.scale, "0.2 0.2 0.2") / 3;
}
