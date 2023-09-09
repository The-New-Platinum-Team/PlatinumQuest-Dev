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

datablock StaticShapeData(PathNode) {
	category = "Paths";
	className = "Node";

	shapeFile = "~/data/shapes/paths/pathnode.dts";
	renderEditor = true;

	scopeAlways = true;
	noBox = 1;

	customField[0, "field"  ] = "NextNode";
	customField[0, "type"   ] = "object";
	customField[0, "name"   ] = "Next Node Name";
	customField[0, "desc"   ] = "Name of the next path node object.";
	customField[0, "default"] = "Next Node Object Name";
	customField[1, "field"  ] = "Delay";
	customField[1, "type"   ] = "time";
	customField[1, "name"   ] = "Delay Before Start";
	customField[1, "desc"   ] = "Delay this long after hitting the node before going to the next one.";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "TimeToNext";
	customField[2, "type"   ] = "time";
	customField[2, "name"   ] = "Time to Next";
	customField[2, "desc"   ] = "How long it takes to get to the next node.";
	customField[2, "default"] = "5000";
	customField[3, "field"  ] = "SmoothStart";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Smooth on Start";
	customField[3, "desc"   ] = "Smooth start only. Smoothing is cosine like a PathedInterior's \"Accelerate\".";
	customField[3, "default"] = "0";
	customField[4, "field"  ] = "SmoothEnd";
	customField[4, "type"   ] = "boolean";
	customField[4, "name"   ] = "Smooth on End";
	customField[4, "desc"   ] = "Smooth end only. Smoothing is cosine like a PathedInterior's \"Accelerate\".";
	customField[4, "default"] = "0";
	customField[5, "field"  ] = "Smooth";
	customField[5, "type"   ] = "boolean";
	customField[5, "name"   ] = "Smooth Start/End";
	customField[5, "desc"   ] = "Smooth both start and end. Smoothing is cosine like a PathedInterior's \"Accelerate\".";
	customField[5, "default"] = "0";
	customField[6, "field"  ] = "UsePosition";
	customField[6, "type"   ] = "boolean";
	customField[6, "name"   ] = "Use Position";
	customField[6, "desc"   ] = "If the object being moved should use the node's position.";
	customField[6, "default"] = "1";
	customField[7, "field"  ] = "UseRotation";
	customField[7, "type"   ] = "boolean";
	customField[7, "name"   ] = "Use Rotation";
	customField[7, "desc"   ] = "If the object being moved should use the node's rotation.";
	customField[7, "default"] = "1";
	customField[8, "field"  ] = "UseScale";
	customField[8, "type"   ] = "boolean";
	customField[8, "name"   ] = "Use Scale";
	customField[8, "desc"   ] = "If the object being moved should use the node's scale.";
	customField[8, "default"] = "1";
	customField[9, "field"  ] = "ReverseRotation";
	customField[9, "type"   ] = "boolean";
	customField[9, "name"   ] = "Reverse Rotation";
	customField[9, "desc"   ] = "If the direction of rotation should be reversed.";
	customField[9, "default"] = "0";
	customField[10, "field"  ] = "RotationMultiplier";
	customField[10, "type"   ] = "float";
	customField[10, "name"   ] = "Rotation Multiplier";
	customField[10, "desc"   ] = "Multiply rotation amounts by this value.";
	customField[10, "default"] = "1";
	customField[11, "field"  ] = "bezier";
	customField[11, "type"   ] = "boolean";
	customField[11, "name"   ] = "Use Bezier Curve";
	customField[11, "desc"   ] = "If the node should use a Bezier curve for smoothing progress (needs Bezier handle objects, use node editor to create them).";
	customField[11, "default"] = "0";
	customField[12, "field"  ] = "BezierHandle1";
	customField[12, "type"   ] = "object";
	customField[12, "name"   ] = "Bezier Handle 1 Name";
	customField[12, "desc"   ] = "Name of the object which is the first Bezier handle.";
	customField[12, "default"] = "";
	customField[13, "field"  ] = "BezierHandle2";
	customField[13, "type"   ] = "object";
	customField[13, "name"   ] = "Bezier Handle 2 Name";
	customField[13, "desc"   ] = "Name of the object which is the second Bezier handle.";
	customField[13, "default"] = "";
	customField[14, "field"  ] = "spline";
	customField[14, "type"   ] = "boolean";
	customField[14, "name"   ] = "Use Spline Curve";
	customField[14, "desc"   ] = "If the node should use a Spline curve for smoothing progress.";
	customField[14, "default"] = "0";
	customField[15, "field"  ] = "FinalRotOffset";
	customField[15, "type"   ] = "AngAxisF";
	customField[15, "name"   ] = "Rotation Offset";
	customField[15, "desc"   ] = "Additional rotation applied after all other rotation calculations.";
	customField[15, "default"] = "1 0 0 0";
	customField[16, "field"  ] = "branchNodes";
	customField[16, "type"   ] = "string";
	customField[16, "name"   ] = "Branching Node Names";
	customField[16, "desc"   ] = "Space-separated list of possible next nodes for this node. One will be randomly picked.";
	customField[16, "default"] = " ";
	customField[17, "field"  ] = "Speed";
	customField[17, "type"   ] = "float";
	customField[17, "name"   ] = "Movement Speed";
	customField[17, "desc"   ] = "Move along path at this speed instead of using the Time to Next.";
	customField[17, "default"] = "0";
	customField[18, "field"  ] = "placed";
	customField[18, "type"   ] = "boolean";
	customField[18, "name"   ] = "Initialized";
	customField[18, "desc"   ] = "This is true if the node has been inited already.";
	customField[18, "default"] = "1";
	customField[18, "disable"] = "1";
};

datablock StaticShapeData(BezierHandle) {
	category = "Paths";
	className = "BezierHandle";
	shapeFile = "~/data/shapes/paths/handle.dts";
	renderEditor = true;
	scopeAlways = true;
	noBox = 1;
};

function Node::onAdd(%this, %obj) {
	if (!isObject(PathNodeGroup)) {
		new SimGroup(PathNodeGroup);
		MissionGroup.add(PathNodeGroup);
	}
	PathNodeGroup.onNextFrame("add", %obj);

	if (isObject(%obj.nextNode))      %obj._nextNodeId      = %obj.nextNode.getSyncId();
	if (isObject(%obj.BezierHandle1)) %obj._BezierHandle1id = %obj.BezierHandle1.getSyncId();
	if (isObject(%obj.BezierHandle2)) %obj._BezierHandle2id = %obj.BezierHandle2.getSyncId();
	%obj.setSync();

	//Init the node

	if (%obj.placed)
		return;

	//Editor TODO: Fields aren't added in the order specified here... they're placed inefficiently

	if (%obj.NextNode $= "")
		%obj.NextNode = "Next Node Object Name";
	if (%obj.Delay $= "")// Wait this many ms before progressing along path
		%obj.Delay = "0";
	if (%obj.TimeToNext $= "") // Time in ms to next node
		%obj.TimeToNext = "5000";

	if (%obj.SmoothStart $= "") // Smooth acceleration on the start of the path
		%obj.SmoothStart = "0";
	if (%obj.SmoothEnd $= "") // Smooth acceleration on the end of the path
		%obj.SmoothEnd = "0";
	if (%obj.Smooth $= "") // Smooth acceleration everywhere
		%obj.Smooth = "0";

	if (%obj.UsePosition $= "") // Apply the position of the node & nextnode path to this object
		%obj.UsePosition = "1";
	if (%obj.UseRotation $= "") // Apply the rotation of the node & nextnode path to this object
		%obj.UseRotation = "1";
	if (%obj.UseScale $= "") // Apply the scale of the node & nextnode path to this object
		%obj.UseScale = "1";

	if (%obj.ReverseRotation $= "")  // Reverse rotation angle (boolean)
		%obj.ReverseRotation = "0";
	if (%obj.RotationMultiplier $= "")  // Multiply output rotation by this amount
		%obj.RotationMultiplier = "1";

	if (%obj.bezier !$= "") {
		if (%obj.BezierHandle1 $= "")
			%obj.BezierHandle1 = "";
		if (%obj.BezierHandle2 $= "")
			%obj.BezierHandle2 = "";
	} else {
		%obj.bezier = "0";
	}
	if (%obj.FinalRotOffset $= "") // Apply this rotation (in euler Roll Pitch Yaw) after all other rotation calculations
		%obj.FinalRotOffset = "0 0 0";
	if (%obj.Spline $= "") // Like bezier except you can be lazy
		%obj.Spline = "0";

	// Allows for branching paths (random pick)
	// use: list potential nextNodes separated by spaces
	if (%obj.branchNodes $= "")
		%obj.branchNodes = " ";

	// Speed: if > 0 and using LINEAR, object moves at approximately this speed;
	// otherwise, we move using TimeToNext
	if (%obj.Speed $= "")
		%obj.Speed = 0;

	%obj.placed = 1;
}

function BezierHandle::onAdd(%this, %obj) {
	%obj.setSync();
}

//-----------------------------------------------------------------------------

if (!isObject(ServerMovingObjectSet)) {
	RootGroup.add(new SimSet(ServerMovingObjectSet));
}

function resetMovingObjects() {
	for (%i = 0; %i < ServerMovingObjectSet.getCount(); %i ++) {
		%object = ServerMovingObjectSet.getObject(%i);

		if (isObject(%object)) {
			%object.resetPath();
			%object.setSync("cancelMoving");
		}
	}
	for (%i = 0; %i < ServerParentedObjectSet.getCount(); %i ++) {
		%object = ServerParentedObjectSet.getObject(%i);

		if (isObject(%object)) {
			%object.setSync("stopParenting");
		}
	}

	ServerMovingObjectSet.clear();
	ServerParentedObjectSet.clear();

	ServerGroup.findMovingObjects();
	ServerGroup.findParentedObjects();
}

function resetMovingObjectsFast() {
	for (%i = 0; %i < ServerMovingObjectSet.getCount(); %i ++) {
		%object = ServerMovingObjectSet.getObject(%i);

		if (isObject(%object)) {
			%object.resetPath();
			%object.setSync("cancelMoving");
		}
	}
	ServerMovingObjectSet.clear();

	ServerGroup.findMovingObjects();

}

function SimGroup::findMovingObjects(%this) {
	%count = %this.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %this.getObject(%i);

		if (%obj.getClassName() $= "SimGroup") {
			%obj.findMovingObjects();
		} else if (%obj.path !$= "") {
			%obj.moveOnPath(%obj.path);
		}
	}
}

function SimGroup::findParentedObjects(%this) {
	%count = %this.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %this.getObject(%i);

		if (%obj.getClassName() $= "SimGroup") {
			%obj.findParentedObjects();
		} else if (isObject(%obj.parent) || isObject(%obj._parent)) {
			%obj.beginParenting();
		}
	}
}

function GameConnection::sendMovingObjects(%this) {
	for (%i = 0; %i < ServerMovingObjectSet.getCount(); %i ++) {
		%object = ServerMovingObjectSet.getObject(%i);

		if (isObject(%object)) {
			%object.setSync("MoveOnPath", %object._pathNode.getSyncId());
		}
	}
}

//-----------------------------------------------------------------------------

function SceneObject::resetPath(%this) {
	//Reset objects to their initial positions
	if (%this._initialPathPosition !$= "")
		%this.setTransform(%this._initialPathPosition);
	if (%this._initialPathScale !$= "")
		%this.setScale(%this._initialPathScale);
	%this._pathPosition = 0;
}

function SceneObject::moveOnPath(%this, %firstNode) {
	// flag before updating path, this marks the object as a moving object
	%this._moving = true;
	%this._pathPosition = 0;
	%this._pathNode = %firstNode;
	%this._pathPrevNode = %firstNode;
	%this._pathSyncId = %this._pathNode.getSyncId();
	%this._pathRngStart = (getRandom(0, 255) + %this.getSyncId()) % 256;

	//Store initial positions so we can reset later
	if (%this._initialPathPosition $= "")
		%this._initialPathPosition = %this.getTransform();
	if (%this._initialPathScale $= "")
		%this._initialPathScale = %this.getScale();

	//Start on the new path.
	%this.updatePathPosition(0);

	//Add the object to the list
	ServerMovingObjectSet.add(%this);

	// Sync object to send fields.
	%this.setSync("moveOnPath", %this._pathSyncId);
}

function SceneObject::cancelMoving(%this) {
	%this._moving = false;
	%this._pathPosition = 0;
	%this._pathNode = 0;
	%this._pathPrevNode = 0;
	%this._pathSyncId = 0;
	%this.setSync("cancelMoving");

	ServerMovingObjectSet.remove(%this);
}

function updateServerMovingObjects(%delta) {
	for (%i = 0; %i < ServerMovingObjectSet.getCount(); %i ++) {
		%obj = ServerMovingObjectSet.getObject(%i);

		// If we are in the end game state, stop all objects that are
		// supposed to be StopWhenFinished
		if ($Game::State $= "End" && %obj.StopWhenFinished)
			continue;

		%obj.updatePathPosition(%delta);
	}
}

function SceneObject::updatePathPosition(%this, %delta) {
	if (!isObject(%this._pathNode)) {
		//End of the path. Stop.
		return;
	}

	%this._pathPosition += %delta;
	%time = Node::getPathTime(%this, %this._pathNode);

	//Check if we've hit the end of the node's path. If that is the case, then
	// we need to start on the next node.
	while (%this._pathPosition > %time) {
		//Subtract any extra time from after the end of the first node. We should
		// be (t - prevnode.time) ms into the next path after this.
		%this._pathPosition -= %time;

		//Use the next node on the list (linked list)
		%this._pathPrevNode = %this._pathNode;
		%this._pathNode = Node::getNextNode(%this, %this._pathNode);
		%this._pathSyncId = %this._pathNode.getSyncId();

		//Update our RNG index if we use a branch node
		if (Node::isBranching(%this, %this._pathPrevNode)) {
			%this._pathRngStart ++;
			%this._pathRngStart %= 256;
		}

		%time = Node::getPathTime(%this, %this._pathNode);

		//If we hit the end of the path, don't loop forever
		if (%this._pathPrevNode == %this._pathNode)
			break;
	}

	//Have we hit the end or been given an invalid node?
	if (!isObject(%this._pathNode)) {
		//End of the path. Stop.
		return;
	}

	Node::updatePath(%this, %this._pathNode, %this._pathPrevNode, %this._pathPosition);
}

//-----------------------------------------------------------------------------

if (!isObject(ServerParentedObjectSet)) {
	RootGroup.add(new SimSet(ServerParentedObjectSet));
}

function SceneObject::beginParenting(%this) {
	%parent = isObject(%this.parent) ? %this.parent : %this._parent;
	objectToParent(%this, %parent, %this.parentModTrans, %this.parentSimple, %this.parentOffset, %this.parentNoRot);
}

function updateServerParentedObjects(%delta) {
	for (%i = 0; %i < ServerParentedObjectSet.getCount(); %i ++) {
		%obj = ServerParentedObjectSet.getObject(%i);
		if (!isObject(%obj))
			continue;
		%obj.updateParenting(%delta);
	}
}

// function SceneObject::updateParenting(%this, %delta) {
// 	//Make sure this object is actually parented
// 	%parent = %this.parent;
// 	if (!isObject(%parent)) {
// 		return;
// 	}

// 	//Parenting variables from the object
// 	%simple    = %this.parentSimple;
// 	%transform = %this._parentTransform;
// 	%offset    = %this.parentOffset;
// 	%noRot     = %this.parentNoRot;

// 	%trans = %parent.getTransform();
// 	if (%noRot)
// 		%trans = MatrixPos(%trans) SPC "1 0 0 ";

// 	if (%simple) {
// 		//Simple parenting is just taking the transform from the parent
// 		%final = %trans;
// 	} else {
// 		//If we don't currently have a parent transform calculated for this object
// 		// then just use this handy function
// 		if (%transform $= "") {
// 			%transform = calcParentModTrans(%this, %parent);
// 			//Look how nice that was
// 			%this._parentTransform = %transform;
// 		}
// 		//Parenting is super crazy simple
// 		%final = MatrixMultiply(%trans, %transform);
// 	}

// 	//Apply an offset if requested
// 	%final = MatrixMultiply(%final, %offset SPC "1 0 0 0");
// 	//And set the transform
// 	%this.setTransform(%final);
// }

// function calcParentModTrans(%object, %parent) {
// 	// Compute a transform to move this object to its current
// 	// position relative to the parent.
// 	%ptrans = getWords(%parent.getTransform(), 3);
// 	%ttrans = getWords(%object.getTransform(), 3);
// 	%ptrans = setWord(%ptrans, 3, "-" @ getWord(%ptrans, 3));
// 	%rotation = matrixMultiply("0 0 0" SPC %ttrans, "0 0 0" SPC %ptrans);
// 	%translation = vectorSub(%object.getPosition(), %parent.getPosition());
// 	%transform = %translation SPC getWords(%rotation, 3);
// 	return %transform;
// }


//----------------------------------------
// Related member functions

// All 3d game world objects
function SceneObject::setParent(%this, %parent, %transform, %simple, %offset, %noRot) {
	objectToParent(%this, %parent, %transform, %simple, %offset, %noRot);
}

// Objects needing their server object updated:
function ShapeBase::setParent(%this, %parent, %transform, %simple, %offset, %noRot) {
	if ($Game::JustLoadedMission)
		schedule(1000, 0, "objectToParent", %this, %parent, %transform, %simple, %offset, %noRot);
	else
		objectToParent(%this, %parent, %transform, %simple, %offset, %noRot);
}

function fxLight::setParent(%this, %parent, %transform, %simple, %offset, %noRot) {
	if ($Game::JustLoadedMission)
		schedule(1000, 0, "objectToParent", %this, %parent, %transform, 1, %offset, %noRot);
	else
		objectToParent(%this, %parent, %transform, 1, %offset, %noRot);
}

function ParticleEmitterNode::setParent(%this, %parent, %transform, %simple, %offset, %noRot) {
	if ($Game::JustLoadedMission)
		schedule(1000, 0, "objectToParent", %this, %parent, %transform, 1, %offset, %noRot);
	else
		objectToParent(%this, %parent, %transform, 1, %offset, %noRot);
}

function objectToParent(%object, %parent, %transform, %simple, %offset, %noRot) {
	//Make sure this object is actually parented (it may not be because recursion)
	if (!isObject(%parent)) {
		//Stop parenting if we setParent to something that doesn't exist
		if (isObject(%object._parent)) {
			%object.stopParenting();
		}
		return;
	}

	if (%transform $= "") {
		//Look how nice that was
		%transform = calcParentModeTrans(%object, %parent);
	}

	if (%offset $= "") {
		%offset = "0 0 0";
	}

	%object.parentOffset = %offset;
	%object.parentSimple = %simple;
	%object.parentNoRot = %noRot;
	%object._parentTransform = %transform;
	%object._parentId = %parent.getSyncId();
	%object._parent = %parent;

	%object.setSync("beginParenting", %parent.getSyncId());
	%parent.setSync();

	//Apply parenting recursively backwards
	%parent.beginParenting();

	//Add the object to the list
	ServerParentedObjectSet.add(%object);
}

function SceneObject::stopParenting(%this) {
	ServerParentedObjectSet.remove(%this);
	%this._parent = "";

	commandToAll('StopParenting', %this.getSyncId());
}

//-----------------------------------------------------------------------------

function activateMovingObjects(%active) {
	$Server::MovingObjectsActive = %active;
	setSimuatingPathedInteriors(%active);
	commandToAll('ActivateMovingObjects', %active);
}

function isServerMovingObject(%obj) {
	return (%obj._moving || isObject(%obj.path) || isObject(%obj.parent) || isObject(%obj._parent));
}

$Editor::Fields["PathNode"] =
	"NextNode" SPC
	"Delay" SPC
	"TimeToNext" SPC
	"SmoothStart" SPC
	"SmoothEnd" SPC
	"Smooth" SPC
	"SmoothFactor" SPC
	"UsePosition" SPC
	"UseRotation" SPC
	"UseScale" SPC
	"ReverseRotation" SPC
	"RotationMultiplier" SPC
	"bezierRotation" SPC
	"bezier" SPC
	"BezierHandle1" SPC
	"BezierHandle2" SPC
	"FinalRotOffset" SPC
	"Spline" SPC
	"branchNodes" SPC
	"Speed" SPC
	"StopWhenFinished" SPC
	"placed";