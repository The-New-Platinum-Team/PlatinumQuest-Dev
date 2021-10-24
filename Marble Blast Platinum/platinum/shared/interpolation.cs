//-----------------------------------------------------------------------------
// Node interpolation: Used both for client and server
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

function Node::getNextNode(%obj, %node) {
	if (%node == -1)
		return %node;
	return Node_getNextNode(%obj, %node);

	//Where is the next node in the list? Linked list-style.
	if (isObject(%node.nextNode)) {
		return %node.nextNode.getId();
	}

	//Check if the next node id is set (client objects use IDs because stuff may
	// not have finished syncing yet).
	if (%node._nextNodeId !$= "") {
		//Make sure it exists first
		%sync = getClientSyncObject(%node._nextNodeId);
		if (isObject(%sync)) {
			return %sync.getId();
		}
	}

	//Branch nodes are on a per-object basis, and this makes them suck ass
	if (Node::isBranching(%obj, %node)) {
		if (!isObject(%obj) && !isObject(getClientSyncObject(%obj))) {
			if (isObject(getWord(%node.branchNodes, 0)))
				return getWord(%node.branchNodes, 0).getId();
			return %node;
		}
		%rng = getSprng(%obj._pathRngStart, 0, getWordCount(%node.branchNodes));
		if (isObject(getWord(%node.branchNodes, %rng)))
			return getWord(%node.branchNodes, %rng).getId();
		return %node;
	}

	//If nothing is after us, then just use ourselves.
	return %node;
}

function Node::isBranching(%obj, %node) {
	return Node_isBranching(%obj, %node);
	return getWordCount(%node.branchNodes) > 1;
}

function Node::getPrevNode(%obj, %node, %group) {
	return Node_getPrevNode(%obj, %node, %group);
	//Iterate over the group and try to find the a node that points to this node
	for (%i = 0; %i < %group.getCount(); %i ++) {
		%obj = %group.getObject(%i);
		//Search subgroups for nodes too
		if (%obj.getClassName() $= "SimGroup") {
			//If we found one, use that
			%test = Node::getPrevNode(%obj, %node, %obj);
			if (%test != -1)
				return %test;
			continue;
		}
		//Try to find a PathNode that points to this node
		if (%obj.getClassName() $= "StaticShape" &&
		                           %obj.getDataBlock().getName() $= "PathNode" &&
		                                   (
		                                       (isObject(%obj.nextNode) && %obj.nextNode.getId() == %node.getId()) ||
		                                       (%obj._nextNodeId !$= "" && %obj._nextNodeId == %node.getSyncId())
		                                   )
		   )
			return %obj;
	}
	return -1;
}

function Node::getAdjustedProgress(%obj, %node, %t) {
	return Node_getAdjustedProgress(%obj, %node, %t);
	//Cosine smoothing, should mimic the accelerate feature of moving platforms.
	if (%node.Smooth || (%t <= 0.50 && %node.SmoothStart) || (%t > 0.50 && %node.SmoothEnd)) {
		%t = -0.5 * mCos(%t * $pi) + 0.5;
	}

	//Normally just the original
	return %t;
}

function Node::getBezierHandle1(%obj, %node) {
	return Node_getBezierHandle1(%obj, %node);
	if (isObject(%node.BezierHandle1))
		return %node.BezierHandle1;

	%sync = getClientSyncObject(%node._BezierHandle1id);
	if (%node._BezierHandle1id !$= "" && isObject(%sync))
		return %sync;

	return -1;
}

function Node::getBezierHandle2(%obj, %node) {
	return Node_getBezierHandle2(%obj, %node);
	if (isObject(%node.BezierHandle2))
		return %node.BezierHandle2;

	%sync = getClientSyncObject(%node._BezierHandle2id);
	if (%node._BezierHandle2id !$= "" && isObject(%sync))
		return %sync;

	return -1;
}

function Node::getPointList(%obj, %node, %prev) {
	return Node_getPointList(%obj, %node, %prev);
	//Next node, and future next node too (needed for spline)
	%next  = Node::getNextNode(%obj, %node);
	%next2 = Node::getNextNode(%obj, %next);

	if (%next.getId() == %node.getId()) {
		//We're the next node. So don't go anywhere.
		return %node.getPosition();
	}

	//Easy accessors for the positions
	%startPos = %node.getPosition();
	%endPos   = %next.getPosition();

	//Start a list of control points for this node
	%posList = %startPos;

	//If either of the nodes have bezier handles, we should add them to the position list.
	if (%node.bezier && isObject(Node::getBezierHandle2(%obj, %node))) {
		%posList = %posList TAB MatrixPos(Node::getBezierHandle2(%obj, %node).getTransform());
	} else if (%node.Spline) {
		//Time for each node
		%nodeTime = Node::getPathTime(%obj, %node);
		%prevTime = Node::getPathTime(%obj, %prev);

		// Spline code adapted from Whirligig231
		%prevPos = %prev.getPosition();
		%dist = (VectorDist(%startPos, %prevPos) / 3) * (max(%nodeTime, 1) / max(%prevTime, 1));
		%sub = VectorNormalize(VectorSub(%endPos, %prevPos));
		%splinePos = VectorAdd(%startPos, VectorScale(%sub, %dist));

		%posList = %posList TAB %splinePos;
	}
	if (%next.bezier && isObject(Node::getBezierHandle1(%obj, %next))) {
		%posList = %posList TAB MatrixPos(Node::getBezierHandle1(%obj, %next).getTransform());
	} else if (%next.Spline) {
		// Spline code adapted from Whirligig231
		%futurePos = %next2.getPosition();
		%dist = (VectorDist(%endPos, %startPos) / 3);
		%sub = VectorNormalize(VectorSub(%futurePos, %startPos));
		%splinePos = VectorSub(%endPos, VectorScale(%sub, %dist));

		%posList = %posList TAB %splinePos;
	}
	%posList = %posList TAB %endPos;

	return %posList;
}

function Node::getPathPosition(%obj, %node, %prev, %t) {
	return Node_getPathPosition(%obj, %node, %prev, %t);
	//Get the interpolated position along the path from %node to %node.nextNode
	// at time %t (ms).

	return VectorBezier(Node::getAdjustedProgress(%obj, %node, %t), Node::getPointList(%obj, %node, %prev));
}

function Node::getPathTime(%obj, %node) {
	return Node_getPathTime(%obj, %node);
	//Speed field for moving at a constant speed over an unknown distance
	if (%node.speed > 0) {
		%next = Node::getNextNode(%obj, %node);
		%distance = VectorDist(%next.getPosition(), %node.getPosition());
		return %node.delay + (%distance / %node.speed) * 1000;
	}

	//Normally we just use timeToNext
	return %node.delay + %node.timeToNext;
}

function Node::getPathRotation(%obj, %node, %prev, %t) {
	return Node_getPathRotation(%obj, %node, %prev, %t);
	//Get the interpolated rotation along the path from %node to %node.nextNode
	// at time %t (ms).

	%next = Node::getNextNode(%obj, %node);
	%next2 = Node::getNextNode(%obj, %next);

	if (%next.getId() == %node.getId()) {
		//We're the next node. So don't go anywhere.
		return MatrixRot(%node.getTransform());
	}

	%startRot = MatrixRot(%node.getTransform());
	%endRot   = MatrixRot(%next.getTransform());

	if (%node.reverseRotation) {
		%t = 1 - %t;
	}

	%rot = RotInterpolate(%startRot, %endRot, Node::getAdjustedProgress(%obj, %node, %t));

	//If they want it faster
	if (%node.RotationMultiplier !$= "") {
		%rot = setWord(%rot, 3, getWord(%rot, 3) * %node.RotationMultiplier);
	}

	//Final rot applied after all other rotations
	if (%node.FinalRotOffset !$= "" && %node.FinalRotOffset !$= "0 0 0")
		%rot = RotMultiply(%rot, %node.FinalRotOffset);

	return %rot;
}

function Node::getPathScale(%obj, %node, %prev, %t) {
	return Node_getPathScale(%obj, %node, %prev, %t);
	//Get the interpolated scale along the path from %node to %node.nextNode
	// at time %t (ms).

	%next = Node::getNextNode(%obj, %node);
	%next2 = Node::getNextNode(%obj, %next);

	if (%next.getId() == %node.getId()) {
		//We're the next node. So don't go anywhere.
		return %node.getScale();
	}

	%startScale = %node.getScale();
	%endScale   = %next.getScale();

	return VectorLerp(%startScale, %endScale, Node::getAdjustedProgress(%obj, %node, %t));
}

function Node::getPathTransform(%obj, %node, %prev, %t) {
	return Node_getPathTransform(%obj, %node, %prev, %t);
	%pos   = (%node.usePosition ? Node::getPathPosition(%obj, %node, %prev, %t) : "");
	%rot   = (%node.useRotation ? Node::getPathRotation(%obj, %node, %prev, %t) : "");
	%scale = (%node.useScale    ? Node::getPathScale(%obj, %node, %prev, %t) : "");

	return %pos TAB %rot TAB %scale;
}

function Node::updatePath(%obj, %node, %prev, %position) {
	Node_updatePath(%obj, %node, %prev, %position);
	return;
	//Where should we be along the node's path? ( pos TAB rot TAB scale )
	if (%node.delay != 0 && %position < %node.delay) {
		%t = 0;
	} else {
		%position -= %node.delay;
		%t = mClamp(%position / max(Node::getPathTime(%obj, %node) - %node.delay, 1), 0, 1);
	}
	%trans = Node::getPathTransform(%obj, %node, %prev, %t);

	//Extract fields
	%pos = getField(%trans, 0);
	%rot = getField(%trans, 1);
	%scale = getField(%trans, 2);

	if (%obj.getClassName() $= "Item" && %obj.isClientObject() && %obj.rotate) {
		//Simulate item rotation because constant setTransform() breaks the
		// engine rotation.
		// Period = 1 full turn / 3 seconds (hardcoded in engine)
		// Always on Z axis too
		%rot = RotMultiply(%rot, "0 0 1" SPC ($Sim::Time * ($pi * 2) / 3));
	}

	//Should we update our position (slight optimization, don't setTransform if
	// we don't modify transform).
	%update = false;
	%objTrans = %obj.getTransform();

	//Check if the position has moved
	if (%pos !$= "") {
		//New transform uses the new position and the old rotation
		%objTrans = %pos SPC MatrixRot(%objTrans);
		%update = true;
	}
	//Check if the rotation has changed
	if (%rot !$= "") {
		//New transform uses the new rotation and the old position
		%objTrans = MatrixPos(%objTrans) SPC %rot;
		%update = true;
	}
	//If position or rotation has changed, update the object.
	if (%update) {
		%obj.setTransform(%objTrans);
	}

	//Check if the scale has changed
	if (%scale !$= "") {
		//Simple setter
		%obj.setScale(%scale);
	}
}

//-----------------------------------------------------------------------------
// Super predictable pseudorandom number generator

function initSprng(%seed) {
	if (%seed $= "")
		%seed = getRealTime();
	setRandomSeed(%seed);
	if (isObject(Sprng)) {
		Sprng.delete();
	}
	%table = Array("Sprng");
	for (%i = 0; %i < 256; %i ++) {
		%table.addEntry(%i);
	}
	for (%i = 0; %i < 256; %i ++) {
		%table.swap(%i, getRandom(0, 255));
	}
	if ($Server::Hosting && !$Server::Dedicated) {
		commandToAll('InitSprng', %seed);
		$Server::SprngSeed = %seed;
	}
	return %seed;
}

function getSprng(%index, %low, %high) {
	%rand = Sprng.getEntry(%index);
	%rand %= (%high - %low);
	%rand += %low;
	return %rand;
}
