//-----------------------------------------------------------------------------
// Moving Objects
//
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

function onUnpackUpdateMovingObject(%obj) {
}

//-----------------------------------------------------------------------------

function clientClearPaths() {
	ClientMovingObjects.clear();
	ClientParentedObjects.clear();
}

if (!isObject(ClientMovingObjects)) {
	Array(ClientMovingObjects);
	RootGroup.add(ClientMovingObjects);
}

function moveOnPath(%obj) {
	echo("moveOnPath() :: Moving " @ %obj);
	%id = %obj.getSyncId();
	if (!ClientMovingObjects.containsEntry(%id)) {
		// start interpolating on the next frame callback.
		ClientMovingObjects.addEntry(%id);

		//Check if it needs to start having a moving emitter
		%count = ClientEmitterSet.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%emitter = ClientEmitterSet.getObject(%i);
			if (%emitter.attachId == %obj.getSyncId()) {
				%emitter.follow = %obj;
				ClientMovingEmitterSet.add(%emitter);
			}
		}
	}
}

function cancelMoving(%obj) {
	echo("cancelMoving() :: Stopping " @ %obj);
	%id = %obj.getSyncId();
	if (ClientMovingObjects.containsEntry(%id)) {
		// start interpolating on the next frame callback.
		ClientMovingObjects.removeMatching(%id);
	}
}

function updateClientMovingObjects(%delta) {
	%count = ClientMovingObjects.getSize();
	for (%i = 0; %i < %count; %i++) {
		%id = ClientMovingObjects.getEntry(%i);
		%obj = getClientSyncObject(%id);

		if (!isObject(%obj)) {
			continue;
		}

		// Check if the game has ended. If we are in end and we should StopWhenFinished,
		// then do so.
		if ($Game::State $= "End" && %obj.StopWhenFinished)
			continue;

		%node = getClientSyncObject(%obj._pathSyncId);
		%prev = getClientSyncObject(%obj._pathPrevSyncId);

		//Nothing to travel on, bail
		if (!isObject(%node)) {
			continue;
		}
		//No previous? Just use the one we got, probably at the front
		if (!isObject(%prev)) {
			%prev = %node;
		}

		//echo("obj is:" SPC %obj SPC "node is:" SPC %node SPC "pathSyncId:" SPC %obj._pathSyncID);
		//continue;

		// advance path
		%obj._pathPosition += %delta;
		%time = Node::getPathTime(%obj, %node);

		while (%obj._pathPosition > %time) {
			%obj._pathPosition -= %time;

			%prev = %node;
			%node = Node::getNextNode(%obj, %node);
			if (isObject(%node)) {
				%obj._pathPrevSyncId = %obj._pathSyncId;
				%obj._pathSyncId = %node.getSyncId();

				//Update our RNG index if we use a branch node
				if (Node::isBranching(%obj, %prev)) {
					%obj._pathRngStart ++;
					%obj._pathRngStart %= 256;
				}
				%time = Node::getPathTime(%obj, %node);
			}

			if (%prev == %node)
				break;
		}

		//Got to the end of the path
		if (!isObject(%node)) {
			continue;
		}

		Node::updatePath(%obj, %node, %prev, %obj._pathPosition);
	}
}

//-----------------------------------------------------------------------------

if (!isObject(ClientParentedObjects)) {
	Array(ClientParentedObjects);
	RootGroup.add(ClientParentedObjects);
}

function beginParenting(%obj, %parentId) {
	%objId = %obj.getSyncId();

	// start interpolating on the next frame callback.
	if (!ClientParentedObjects.containsEntry(%objId)) {
		ClientParentedObjects.addEntry(%objId);
	}
}

function clientCmdStopParenting(%objId) {
	ClientParentedObjects.removeMatching(%objId);
}

function stopParenting(%objId) {
	ClientParentedObjects.removeMatching(%objId);
}

// function updateClientParentedObjects(%delta) {
// 	%count = ClientParentedObjects.getSize();
// 	for (%i = 0; %i < %count; %i++) {
// 		%id = ClientParentedObjects.getEntry(%i);
// 		%obj = getClientSyncObject(%id);
// 		if (!isObject(%obj)) {
// 			continue;
// 		}

// 		//Resolve our parent
// 		%parent = getClientSyncObject(%obj._parentId);
// 		if (!isObject(%parent)) {
// 			continue;
// 		}

// 		//Get each of the variables that we need
// 		%simple    = %obj.parentSimple;
// 		%transform = %obj._parentTransform;
// 		%offset    = %obj.parentOffset;
// 		%noRot     = %obj.parentNoRot;

// 		%trans = %parent.getTransform();
// 		if (%noRot)
// 			%trans = MatrixPos(%trans) SPC "1 0 0 ";

// 		if (%simple) {
// 			//Simple parenting is just taking the transform from the parent
// 			%final = %trans;
// 		} else {
// 			//If we don't currently have a parent transform calculated then we
// 			// can't really parent, as the server controls this.
// 			if (%transform $= "") {
// 				continue;
// 			}
// 			//Parenting is super crazy simple
// 			%final = MatrixMultiply(%trans, %transform);
// 		}

// 		//Apply an offset if requested
// 		%final = MatrixMultiply(%final, %offset SPC "1 0 0 0");
// 		if (%obj.getClassName() $= "Item") {
// 			//Simulate item rotation because constant setTransform() breaks the
// 			// engine rotation.
// 			// Period = 1 full turn / 3 seconds (hardcoded in engine)
// 			// Always on Z axis too
// 			%final = MatrixMultiply(%final, "0 0 0 0 0 1" SPC($Sim::Time * ($pi * 2) / 3));
// 		}
// 		//And set the transform
// 		%obj.setTransform(%final);
// 	}
// }

//Magic constant for ice shard "bounciness". Found by mutual argument.
//0 = full bounce, 1 = go straight through. This value made the least salt.
$shardBounce = 0.2;

function SceneObject::getSurfaceVelocity(%this, %marble, %point, %distance) {
	if (%this.getClassName() $= "StaticShape"
		&& stristr(%this.getDatablock().getName(), "IceShard") != -1) {

		if (%marble.fireball) {
			return VectorScale(%marble.getVelocity(), $shardBounce);
		}
	}

	if (ClientParentedObjects.containsEntry(%this.getSyncId())) {
		//We're parented
		%parent = getClientSyncObject(%this._parentId);
		if (!isObject(%parent))
			return "0 0 0";
		return %parent.getSurfaceVelocity(%marble, %point, %distance);
	}
	if (!ClientMovingObjects.containsEntry(%this.getSyncId())) {
		//echo("nope");
		return "0 0 0";
	}

	//For stuff that breaks the game
	if (%this.disablePhysics) {
		return "0 0 0";
	}

	//testahedron(%point, 1);

	//that's 18s / 1 turn
	//1 turn = 6.28 m * r
	//1 turn / 18s
	//6.28m * r / 18s

	%prev = getClientSyncObject(%this._pathPrevSyncId);
	%node = getClientSyncObject(%this._pathSyncId);
	%next = Node::getNextNode(%this, %node);

	//At the end
	if (%next == %node || !isObject(%next)) {
		return "0 0 0";
	}

	%timeDelta = %node.timeToNext;
	%t = %this._pathPosition / max(%node.timeToNext, 1);

	//Velocity from translation
	if (%node.usePosition) {
		%transVel = VectorBezierDeriv(Node::getAdjustedProgress(%this, %node, %t), Node::getPointList(%this, %node, %prev));
		%transVel = VectorScale(%transVel, 1000 / %timeDelta);
	} else {
		%transVel = "0 0 0";
	}

	//Velocity from rotation
	if (%node.useRotation) {
		//Todo: Continuous derivative?
		%startRot = MatrixRot(%next.getTransform());
		%endRot   = MatrixRot(%node.getTransform());
		%mat0 = "0 0 0" SPC RotInterpolate(%startRot, %endRot, Node::getAdjustedProgress(%this, %node, %t));
		%mat1 = "0 0 0" SPC RotInterpolate(%startRot, %endRot, Node::getAdjustedProgress(%this, %node, %t + 0.001));

		%div = MatrixDivide(%mat1, %mat0);

		%rotAxis = getWords(%div, 3, 5);
		%rotDelta = getWord(%div, 6) / 0.001;

		if (%timeDelta == 0 || %rotDelta == 0) {
			//Explosions
			%rotVel = "0 0 0";
		} else {
			if (%node.reverseRotation)
				%rotDelta *= -1;
			%center = MatrixPos(%this.getTransform());
			%mpos = %marble.getWorldBoxCenter();
			%off = VectorSub(%point, %center);

			//Credits to Whirligig for this math
			//"projection into a plane in 3D is rejection from the normal"
			%offLen = VectorLen(VectorRej(%off, %rotAxis));
			%dist = VectorDist(%point, %mpos);

			%mult = mClamp(%marble.getCollisionRadius() / %dist, 1, 2);

			%vel = VectorNormalize(VectorCross(%off, %rotAxis));
			%speed = (%rotDelta * %offLen / (%timeDelta / 1000)) * %mult;

			%rotVel = VectorScale(%vel, %speed);
		}
	} else {
		%rotVel = "0 0 0";
	}

	//TODO: Scale velocity, which will be a pita
	if (false) { //%node.useScale) {
		%startScale = %node.getScale();
		%endScale   = %next.getScale();
		%sub = VectorSub(%endScale, %startScale);
		%len = VectorLen(%sub);

		%scaleVel = VectorScale(VectorNormalize(%sub), %len / (%timeDelta / 1000));
		echo("Scale vel: " @ %scaleVel);

		%center = MatrixPos(%this.getTransform());
		%centerDist = VectorSub(%point, %center);
		echo("Center dist: " @ %centerDist);

		%scaleVel = VectorMult(%centerDist, %scaleVel);

	} else {
		%scaleVel = "0 0 0";
	}

//echo("transVel:" SPC %transVel);
//echo("rotVel:" SPC %rotVel);
//echo("scaleVel:" SPC %scaleVel);

	return VectorAdd(VectorAdd(%transVel, %rotVel), %scaleVel);
}
