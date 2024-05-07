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

//------------------------------------------------------------------------------
// Console onEditorRender functions:
//------------------------------------------------------------------------------
// Functions:
//   - renderSphere([pos], [radius], <sphereLevel>);
//   - renderCircle([pos], [normal], [radius], <segments>);
//   - renderTriangle([pnt], [pnt], [pnt]);
//   - renderLine([start], [end], <thickness>);
//   - renderBox([box], <thickness>);
//
// Variables:
//   - consoleFrameColor - line prims are rendered with this
//   - consoleFillColor
//   - consoleSphereLevel - level of polyhedron subdivision
//   - consoleCircleSegments
//   - consoleLineWidth
//------------------------------------------------------------------------------

function WorldEditor::renderBox(%this, %box, %thickness) {
	%this.renderLine(getWord(%box, 0) SPC getWord(%box, 1) SPC getWord(%box, 2), getWord(%box, 0) SPC getWord(%box, 1) SPC getWord(%box, 5), %thickness);
	%this.renderLine(getWord(%box, 3) SPC getWord(%box, 1) SPC getWord(%box, 2), getWord(%box, 3) SPC getWord(%box, 1) SPC getWord(%box, 5), %thickness);
	%this.renderLine(getWord(%box, 0) SPC getWord(%box, 4) SPC getWord(%box, 2), getWord(%box, 0) SPC getWord(%box, 4) SPC getWord(%box, 5), %thickness);
	%this.renderLine(getWord(%box, 3) SPC getWord(%box, 4) SPC getWord(%box, 2), getWord(%box, 3) SPC getWord(%box, 4) SPC getWord(%box, 5), %thickness);

	%this.renderLine(getWord(%box, 0) SPC getWord(%box, 1) SPC getWord(%box, 2), getWord(%box, 3) SPC getWord(%box, 1) SPC getWord(%box, 2), %thickness);
	%this.renderLine(getWord(%box, 0) SPC getWord(%box, 4) SPC getWord(%box, 2), getWord(%box, 3) SPC getWord(%box, 4) SPC getWord(%box, 2), %thickness);
	%this.renderLine(getWord(%box, 0) SPC getWord(%box, 1) SPC getWord(%box, 5), getWord(%box, 3) SPC getWord(%box, 1) SPC getWord(%box, 5), %thickness);
	%this.renderLine(getWord(%box, 0) SPC getWord(%box, 4) SPC getWord(%box, 5), getWord(%box, 3) SPC getWord(%box, 4) SPC getWord(%box, 5), %thickness);

	%this.renderLine(getWord(%box, 0) SPC getWord(%box, 1) SPC getWord(%box, 2), getWord(%box, 0) SPC getWord(%box, 4) SPC getWord(%box, 2), %thickness);
	%this.renderLine(getWord(%box, 3) SPC getWord(%box, 1) SPC getWord(%box, 2), getWord(%box, 3) SPC getWord(%box, 4) SPC getWord(%box, 2), %thickness);
	%this.renderLine(getWord(%box, 0) SPC getWord(%box, 1) SPC getWord(%box, 5), getWord(%box, 0) SPC getWord(%box, 4) SPC getWord(%box, 5), %thickness);
	%this.renderLine(getWord(%box, 3) SPC getWord(%box, 1) SPC getWord(%box, 5), getWord(%box, 3) SPC getWord(%box, 4) SPC getWord(%box, 5), %thickness);
}

function WorldEditor::renderArrow(%this, %start, %end) {
	%this.renderLine(%start,%end);
	%mat = MatrixPoint(%end SPC "1 0 0 0",%start);
	%up = MatrixMulPoint(%mat,"0 0.1 -0.2");
	%left = MatrixMulPoint(%mat,"-0.1 0 -0.2");
	%right = MatrixMulPoint(%mat,"0.1 0 -0.2");
	%down = MatrixMulPoint(%mat,"0 -0.1 -0.2");
	%this.renderLine(%end,%up);
	%this.renderLine(%end,%down);
	%this.renderLine(%end,%left);
	%this.renderLine(%end,%right);
}

function SpawnSphere::onEditorRender(%this, %editor, %selected, %expanded) {
	if (%selected $= "true") {
		%editor.consoleFrameColor = "255 0 0";
		%editor.consoleFillColor = "0 0 0 0";
		%editor.renderSphere(%this.getWorldBoxCenter(), %this.radius, 1);
	}
}

function AudioEmitter::onEditorRender(%this, %editor, %selected, %expanded) {
	if (%selected $= "true" && %this.is3D && !%this.useProfileDescription) {
		%editor.consoleFillColor = "0 0 0 0";

		%editor.consoleFrameColor = "255 0 0";
		%editor.renderSphere(%this.getTransform(), %this.minDistance, 1);

		%editor.consoleFrameColor = "0 0 255";
		%editor.renderSphere(%this.getTransform(), %this.maxDistance, 1);
	}
}

function renderTest() {
	EWorldEditor.consoleFrameColor = "255 0 0";
	EWorldEditor.consoleFillColor = "0 0 0 0";
	EWorldEditor.renderSphere("0 0 0", 10, 1);
	EWorldEditor.rendercircle("10 0 0", "0 0 0", 1, 360);
}

function PathedInterior::onEditorRender(%this, %editor, %selected, %expanded) {
	if (%selected $= "false")
		return;

	%group = %this.getGroup();
	for (%i = 0; %i < %group.getCount(); %i ++)
		if (%group.getObject(%i).getClassName() $= "Path")
			%group.getObject(%i).onEditorRender(%editor, %selected, %expanded);
}

function Path::onEditorRender(%this, %editor, %selected, %expanded) {
	if (%selected $= "false")
		return;
	if (%this.getCount() == 0)
		return;

	// Make sure we only render this set once per frame
	if ($Editor::LastRender[%this] == $Sim::Time)
		return;

	$Editor::LastRender[%this] = $Sim::Time;

	%time = 999999999999;
	// Test for a TriggerGotoTarget
	%group = %this.getGroup();
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		if (%obj.getClassName() $= "Trigger" && %obj.getDataBlock().getName() $= "TriggerGotoTarget")
			%time = %obj.targetTime;
	}

	%group = %this;
	%count = %group.getCount();
	for (%i = 1; %i < %count; %i++) {
		if (%prevObj $= "")
			%prevObj = %group.getObject(0);
		if (%prev2Obj $= "")
			%prev2Obj = %group.getObject(0);

		if (%time < 0)
			break;
		%amt = 1.0;
		%time -= %prevObj.msToNext;
		if (%time < 0) {
			%amt = (%prevObj.msToNext + %time) / %prevObj.msToNext;
		}
		%amt = max(min(1, %amt), 0);

		%obj = %group.getObject(%i);
		%futureObj = (%group.getCount() == %i + 1 ? %group.getObject(0) : %group.getObject(%i + 1));

		%color = (%i / (%count-1)) * 255;
		%colorI = (%count-%i) / %count * 255;

		//echo(%color / 255 SPC %colori / 255);

		%new = %obj.getPosition();//VectorAdd(%prevObj.getPosition(), VectorScale(VectorSub(%obj.getPosition(), %prevObj.getPosition()), %amt));

		if (%obj.smoothingType $= "Spline") {
			// Matrices for camera position splining
			%start    = %prevObj.getPosition();
			%startMat = %prevObj.getTransform();
			%end    = %obj.getPosition();
			%endMat = %obj.getTransform();
			%future = %futureObj.getPosition();
			%prev   = %prev2Obj.getPosition();

			%dist = (VectorDist(%start, %prev) / 3) * (max(%prevObj.targetTime, 1) / max(%prev2Obj.targetTime, 1));
			%sub = VectorNormalize(VectorSub(%end, %prev));
			%a = VectorAdd(%start, VectorScale(%sub, %dist));

			%dist = (VectorDist(%end, %start) / 3);
			%sub = VectorNormalize(VectorSub(%future, %start));
			%b = VectorSub(%end, VectorScale(%sub, %dist));

			%count = %group.getCount();
			%inc = (%count < 10 ? 0.1 : 0.25);
			for (%u = 0; %u < 1; %u += %inc) {
				%s = VectorBezier(%u, %start TAB %a TAB %b TAB %end);
				%e = VectorBezier(%u + %inc, %start TAB %a TAB %b TAB %end);

				%editor.consoleFrameColor = "0 0 0";
				%editor.renderLine(%s, %e, 8);
				%editor.consoleFrameColor = (%color * 255 / 255 + 0) SPC(%colorI * 255 / 255 + 0) SPC 100;
				%editor.renderLine(%s, %e, 4);
			}
//		%editor.renderSphere(%a, 2);
//		%editor.renderSphere(%b, 2);
		} else {
			%editor.consoleFrameColor = "0 0 0";
			%editor.renderLine(%prevObj.getPosition(), %new, 8);
			%editor.consoleFrameColor = (%color * 255 / 255 + 0) SPC(%colorI * 255 / 255 + 0) SPC 100;
			%editor.renderLine(%prevObj.getPosition(), %new, 4);
		}

		%prev2Obj = %prevObj;
		%prevObj = %obj;
	}
}

// Yoink'd from PQ
function Marker::onEditorRender(%this, %editor, %selected, %expanded) {
	if (%selected $= "false")
		return;

	%group = %this.getGroup();
	%group.onEditorRender(%editor, %selected, %expanded);
}

//function Item::onEditorRender(%this, %editor, %selected, %expanded)
//{
//   if(%this.getDataBlock().getName() $= "MineDeployed")
//   {
//      %editor.consoleFillColor = "0 0 0 0";
//      %editor.consoleFrameColor = "255 0 0";
//      %editor.renderSphere(%this.getWorldBoxCenter(), 6, 1);
//   }
//}

function Trigger::onEditorRender(%this, %editor, %selected, %expanded) {
	%this.getDataBlock().onEditorRender(%this, %editor, %selected, %expanded);
}
function Item::onEditorRender(%this, %editor, %selected, %expanded) {
	%this.getDataBlock().onEditorRender(%this, %editor, %selected, %expanded);
}
function ShapeBase::onEditorRender(%this, %editor, %selected, %expanded) {
	%this.getDataBlock().onEditorRender(%this, %editor, %selected, %expanded);
}

function TriggerData::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (isServerMovingObject(%obj)) {
		%editor.consoleFrameColor = "255 0 0";

		%node = %obj._PathNode;
		if (isObject(%node)) {
			%node.onEditorRender(%editor, %selected, %expanded);
		}
	}
}
function ItemData::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (isServerMovingObject(%obj)) {
		%editor.consoleFrameColor = "255 0 0";

		%node = %obj._PathNode;
		if (isObject(%node)) {
			%node.onEditorRender(%editor, %selected, %expanded);
		}
	}
}
function ShapeBaseData::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (isServerMovingObject(%obj)) {
		%editor.consoleFrameColor = "255 0 0";

		%node = %obj._PathNode;
		if (isObject(%node)) {
			%node.onEditorRender(%editor, %selected, %expanded);
		}
	}
}

function AlterGravityTrigger::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (%selected $= "true") {
		//Find the normal / radius for the rings
		%box = %obj.getWorldBox();

		%x0 = BoxCenterX(%box);
		%y0 = BoxCenterY(%box);
		%z0 = BoxCenterZ(%box);
		%x1 = getWord(%box, 3);
		%y1 = getWord(%box, 4);
		%z1 = getWord(%box, 5);
		%dx = BoxSizeX(%box);
		%dy = BoxSizeY(%box);
		%dz = BoxSizeZ(%box);

		switch$ (%obj.measureAxis) {
		case "x": %x0 = getWord(%box, 0);
		case "y": %y0 = getWord(%box, 1);
		case "z": %z0 = getWord(%box, 2);
		}
		switch$ (%obj.GravityAxis) {
		case "x": %dx = (BoxSizeX(%box) / 50) - 0.001;
		case "y": %dy = (BoxSizeY(%box) / 50) - 0.001;
		case "z": %dz = (BoxSizeZ(%box) / 50) - 0.001;
		}

		for (%x = %x0; %x <= %x1; %x += %dx) {
			for (%y = %y0; %y <= %y1; %y += %dy) {
				for (%z = %z0; %z <= %z1; %z += %dz) {
					%pt = %x SPC %y SPC %z;

					%down = AlterGravityTrigger_getDownVector(AlterGravityTrigger, %obj, %pt);
					%end = VectorAdd(%pt, %down);

					%editor.renderArrow(%pt, %end);
				}
			}
		}
	}
}

function GravityWellTrigger::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (%selected $= "true") {
		%center = (getWordCount(%obj.custompoint) == 3 ? %obj.custompoint : %obj.getWorldBoxCenter());
		%radius = GravityPointTrigger_getRadius("GravityPointTrigger", %obj);
		if (%radius == -1) {
			%radius = 9999;
		} else {
			%normal = (%obj.axis $= "x") SPC (%obj.axis $= "y") SPC (%obj.axis $= "z");
			%editor.renderCircle(%center, %normal, %radius, 20);
		}

		//Find the normal / radius for the rings
		%box = %obj.getWorldBox();

		%x0 = getWord(%box, 0);
		%y0 = getWord(%box, 1);
		%z0 = getWord(%box, 2);
		%x1 = getWord(%box, 3);
		%y1 = getWord(%box, 4);
		%z1 = getWord(%box, 5);

		%dx = (BoxSizeX(%box) / 10) - 0.001;
		%dy = (BoxSizeY(%box) / 10) - 0.001;
		%dz = (BoxSizeZ(%box) / 10) - 0.001;
		switch$ (%obj.axis) {
		case "x":
			%dx = BoxSizeX(%box);
			%x0 = BoxCenterX(%box);
			%x1 = BoxCenterX(%box);
		case "y":
			%dy = BoxSizeY(%box);
			%y0 = BoxCenterY(%box);
			%y1 = BoxCenterY(%box);
		case "z":
			%dz = BoxSizeZ(%box);
			%z0 = BoxCenterZ(%box);
			%z1 = BoxCenterZ(%box);
		}

		for (%x = %x0; %x <= %x1; %x += %dx) {
			for (%y = %y0; %y <= %y1; %y += %dy) {
				for (%z = %z0; %z <= %z1; %z += %dz) {
					%pt = %x SPC %y SPC %z;

					if (VectorDist(%pt, %center) > %radius)
						continue;

					%down = GravityWellTrigger_getDownVector(GravityWellTrigger, %obj, %pt);
					%end = VectorAdd(%pt, %down);

					%editor.renderArrow(%pt, %end);
				}
			}
		}
	}
}

function GravityPointTrigger::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (%selected $= "true") {
		%center = (getWordCount(%obj.custompoint) == 3 ? %obj.custompoint : %obj.getWorldBoxCenter());
		%radius = GravityPointTrigger_getRadius("GravityPointTrigger", %obj);
		if (%radius == -1) {
			%radius = 9999;
		} else {
			%editor.renderSphere(%center, %radius, 1);
		}

		//Find the normal / radius for the rings
		%box = %obj.getWorldBox();

		%x0 = getWord(%box, 0);
		%y0 = getWord(%box, 1);
		%z0 = getWord(%box, 2);
		%x1 = getWord(%box, 3);
		%y1 = getWord(%box, 4);
		%z1 = getWord(%box, 5);
		%dx = (BoxSizeX(%box) / 5) - 0.001;
		%dy = (BoxSizeY(%box) / 5) - 0.001;
		%dz = (BoxSizeZ(%box) / 5) - 0.001;

		for (%x = %x0; %x <= %x1; %x += %dx) {
			for (%y = %y0; %y <= %y1; %y += %dy) {
				for (%z = %z0; %z <= %z1; %z += %dz) {
					%pt = %x SPC %y SPC %z;

					if (VectorDist(%pt, %center) > %radius)
						continue;

					%down = GravityPointTrigger_getDownVector(GravityWellTrigger, %obj, %pt);
					%end = VectorAdd(%pt, %down);

					%editor.renderArrow(%pt, %end);
				}
			}
		}
	}
}

function GravityTrigger::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (%selected $= "true") {
		//Find the normal / radius for the rings
		%box = %obj.getWorldBox();

		%x0 = getWord(%box, 0);
		%y0 = getWord(%box, 1);
		%z0 = getWord(%box, 2);
		%x1 = getWord(%box, 3);
		%y1 = getWord(%box, 4);
		%z1 = getWord(%box, 5);
		%dx = (BoxSizeX(%box) / 2) - 0.001;
		%dy = (BoxSizeY(%box) / 2) - 0.001;
		%dz = (BoxSizeZ(%box) / 2) - 0.001;

		for (%x = %x0; %x <= %x1; %x += %dx) {
			for (%y = %y0; %y <= %y1; %y += %dy) {
				for (%z = %z0; %z <= %z1; %z += %dz) {
					%pt = %x SPC %y SPC %z;

					%down = GravityTrigger_getDownVector(GravityTrigger, %obj, %pt);
					%end = VectorAdd(%pt, %down);

					%editor.renderArrow(%pt, %end);
				}
			}
		}
	}
}

function Cannon::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (%selected $= "true") {
		if (%obj.instant) {
			%cannon = %obj;

			%trans = "0 0 0 1 0 0 0";
			//Apply yaw and pitch rotations
			%trans = MatrixMultiply(%trans, "0 0 0 0 0 1" SPC mDegToRad(%cannon.yaw));
			%trans = MatrixMultiply(%trans, "0 0 0 1 0 0" SPC -mDegToRad(%cannon.pitch));
			//We are shot forwards (y axis is down the barrel)
			%trans = MatrixMultiply(%trans, "0 1 0 1 0 0 0");
		} else {
			%cannon = getClientSyncObject(%obj.getSyncId());

			%trans = "0 0 0 1 0 0 0";
			//Apply yaw and pitch rotations
			%trans = MatrixMultiply(%trans, "0 0 0 0 0 1" SPC %cannon.lastYaw);
			%trans = MatrixMultiply(%trans, "0 0 0 1 0 0" SPC %cannon.lastPitch);
			//We are shot forwards (y axis is down the barrel)
			%trans = MatrixMultiply(%trans, "0 1 0 1 0 0 0");
		}

		%start = %obj.getPosition();
		%vel = VectorScale(MatrixPos(%trans), %obj.force);

		%gravity = "0 0 -20";
		%timeStep = 0.02;

		for (%i = 0; %i < 250; %i ++) {
			%vel = VectorAdd(%vel, VectorScale(%gravity, %timeStep));
			%end = VectorAdd(%start, VectorScale(%vel, %timeStep));

			//Check for entering a physmod trigger
			%count = ClientTriggerSet.getCount();
			for (%j = 0; %j < %count; %j ++) {
				%trigger = ClientTriggerSet.getObject(%j);

				if (%trigger.isPointInside(%end)) {
					if (!%inTrigger[%trigger]) {
						%inTrigger[%trigger] = true;
						for (%k = 0; %trigger.marbleAttribute[%k] !$= ""; %k ++) {
							if (%trigger.marbleAttribute[%k] $= "gravity") {
								%gravity = VectorScale(getGravityDir(), %trigger.value[%k]);
								%beforeGravity = $Cannon::BeforeGravity;
							}
						}
					}
				} else if (%inTrigger[%trigger]) {
					%inTrigger[%trigger] = false;
					for (%k = 0; %trigger.marbleAttribute[%k] !$= ""; %k ++) {
						if (%trigger.marbleAttribute[%k] $= "gravity") {
							%gravity = %beforeGravity;
						}
					}
				}
			}

			%cast = ContainerRayCast(%start, %end, $TypeMasks::StaticShapeObjectType | $TypeMasks::InteriorObjectType, %cannon);
			if (%cast) {
				%end = getWords(%cast, 1, 3);
			}

			%editor.renderLine(%start, %end, 3);
			%start = %end;

			if (%cast) {
				break;
			}
		}
	}
}

function HelpBubble::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (%selected $= "true") {
		%editor.renderSphere(%obj.getPosition(), %obj.triggerRadius, 2);
	}
}

function PathNode::onEditorRender(%this, %obj, %editor, %selected, %expanded, %segments, %first, %prev) {
	if (%selected $= "true") {
		//If we're the first node
		if (%first $= "") {
			//Some initial conditions
			%first = %obj.getId();
			%prev = Node::getPrevNode(-1, %first, MissionGroup);
			%segments = 20;
		} else if (%first.getId() == %obj.getId()) {
			//Hit the first node again, this must be a loop.
			return;
		} else if (%segments == 0) {
			//We've recursed a bit far, after this point everything will be super slow.
			// Also segments decreases linearly with node count so at this point the
			// path is super inaccurate and won't actually show.
			return;
		}

		//Draw control points in blue
		%editor.consoleFrameColor = "0 0 255";
		%posList = Node::getPointList(-1, %obj, %prev);
		for (%i = 0; %i < getFieldCount(%posList); %i ++) {
			%editor.renderSphere(getField(%posList, %i), 1, 0);
		}

		%editor.consoleFrameColor = "255 0 0";

		//Optimize for non-spline paths
		if (getFieldCount(%posList) == 2) {
			//Just go start->end
			%editor.renderLine(Node::getPathPosition(-1, %obj, %prev, 0), Node::getPathPosition(-1, %obj, %prev, 1));
		} else {
			//Draw the actual path itself in red
			%pos = Node::getPathPosition(-1, %obj, %prev, 0);
			for (%i = 0; %i < %segments; %i ++) {
				//Calculate the next point on the path and draw a line between them
				%end = Node::getPathPosition(-1, %obj, %prev, (%i + 1) / %segments);
				%editor.renderLine(%pos, %end, 2);
				%pos = %end;
			}
		}

		//Render the next node in the path if we haven't hit the end (end would
		// be this node == next node)
		%next = Node::getNextNode(-1, %obj);
		if (%next.getId() != %obj.getId()) {
			%this.onEditorRender(%next, %editor, %selected, %expanded, %segments - 1, %first, %obj);
		}
	}
}

function BezierHandle::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (%selected $= "true") {
		if (isObject(%obj.parent)) {
			%obj.parent.onEditorRender(%editor, %selected, %expanded);
		}
		if (isObject(%obj.parentnode)) {
			%obj.parentnode.onEditorRender(%editor, %selected, %expanded);
		}
	}
}

function LapsCounterTrigger::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (!%obj.enableRespawning) {
		return;
	}
	%trans = (%obj.spawnPoint $= "" ? (%obj.getWorldBoxCenter() SPC MatrixRot(%obj.getTransform())) : setWord(%obj.spawnPoint, 6, mDegToRad(getWord(%obj.spawnPoint, 6))));
	%editor.renderSphere(%trans, 1, 1);
	%forward = MatrixMulVector(%trans, "0 3 0");
	%editor.renderArrow(MatrixPos(%trans), VectorAdd(%trans, %forward));
}

function LapsCheckpoint::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (!%obj.enableRespawning) {
		return;
	}
	%trans = (%obj.spawnPoint $= "" ? (%obj.getWorldBoxCenter() SPC MatrixRot(%obj.getTransform())) : setWord(%obj.spawnPoint, 6, mDegToRad(getWord(%obj.spawnPoint, 6))));
	%editor.renderSphere(%trans, 1, 1);
	%forward = MatrixMulVector(%trans, "0 3 0");
	%editor.renderArrow(MatrixPos(%trans), VectorAdd(%trans, %forward));
}

//Draw a line from a Teleport Trigger to it's destination when selected.
//Could be useful if a level has many teleport triggers and many destination triggers. ~Connie
function TeleportTrigger::onEditorRender(%this, %obj, %editor, %selected, %expanded) {
	if (%selected $= "true") {
		%teltrig = %obj;
		%destination = %obj.destination.getId();
		%editor.renderLine(%teltrig.getWorldBoxCenter(), %destination.getWorldBoxCenter(), 2);	
	}
}