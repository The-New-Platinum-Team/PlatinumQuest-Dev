//-----------------------------------------------------------------------------
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

function epnbutton(%node) {
	LargeFunctionDlg.node = %node;
	LargeFunctionDlg.init("PNEdit", "Edit PathNode", 1);
	LargeFunctionDlg.addNote("\c5Editing " @ %node.getName() @ " (Object " @ %node.getID() @ ")");
	LargeFunctionDlg.addTextEditField("PNE_Name", "Node name:", %node.getName(), 150, -3);
	LargeFunctionDlg.addTextEditField("PNE_NextNode", "Next node name:", %node.nextNode, 150, -3);
	LargeFunctionDlg.addTimeEditField("PNE_Delay", "Delay before moving:", %node.delay, 100, -3);
	LargeFunctionDlg.addTimeEditField("PNE_TimeToNext", "Time to next node:", %node.timeToNext, 100, -3);
	LargeFunctionDlg.addTextEditField("PNE_Speed", "Travel speed - overrides TimeToNext", %node.Speed, 100, -2.8);
	LargeFunctionDlg.addNote("\c5* Speed option not available if using Smooth or Bezier");
	LargeFunctionDlg.addCheckBox("PNE_SmoothStart", "Smooth acceleration at start of path", %node.smoothStart);
	LargeFunctionDlg.addCheckBox("PNE_SmoothEnd", "Smooth decelration at end of path", %node.smoothEnd);
	LargeFunctionDlg.addCheckBox("PNE_UsePosition", "Move object along 3d path (use position)", %node.usePosition);
	LargeFunctionDlg.addCheckBox("PNE_UseRotation", "Rotate object to match with nodes (use rotation)", %node.useRotation);
	LargeFunctionDlg.addCheckBox("PNE_UseScale", "Scale object to match with nodes (use scale)", %node.useScale);
	LargeFunctionDlg.addCheckBox("PNE_ReverseRotation", "Reverse direction of rotation", %node.reverseRotation);
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addTextEditField("PNE_rotationMultiplier", "Multiply change in rotation by this amount:", %node.rotationMultiplier, 100, -1);
	LargeFunctionDlg.addCheckBox("PNE_Bezier", "Use bezier curve (handles will be auto-generated upon clicking Accept)", %node.bezier);
	LargeFunctionDlg.addCheckBox("PNE_Spline", "Use spline curve (use instead of bezier or smooth)", %node.spline);
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addNote("Final rotation offset as euler angle x y z:");
	%roll = getWord(%node.FinalRotOffset, 0);
	%pitch = getWord(%node.FinalRotOffset, 1);
	%yaw = getWord(%node.FinalRotOffset, 2);
	LargeFunctionDlg.addSlider("PNE_FRO_X", "Roll (x)", "0 360", isNumber(%roll) ? mod64(%roll, 360) : 0, 1, 1);
	LargeFunctionDlg.addSlider("PNE_FRO_Y", "Pitch (y)", "0 360", isNumber(%pitch) ? mod64(%pitch, 360) : 0, 1, 1);
	LargeFunctionDlg.addSlider("PNE_FRO_Z", "Yaw (z)", "0 360", isNumber(%yaw) ? mod64(%yaw, 360) : 0, 1, 1);
	LargeFunctionDlg.addTextEditField("PNE_BranchNodes", "BranchNodes - list potential NextNodes separated by spaces:", %node.BranchNodes, 250, 2);
}

function PNEdit(%gui) {
	%node = %gui.node;
	if (!isObject(%node)) {
		Assert("!?", "Node doesn't exist!?");
		%gui.cleanup();
		return;
	}
	//if (isObject(PNE_Name.getValue()))
	//{
	//Assert("Info", "Node name already exists");
	//return;
	//}
	//else
	%node.setName(PNE_Name.getValue());
	%node.nextnode = PNE_NextNode.getValue();
	%node.delay = PNE_Delay.getvalue();
	%node.timeToNext = PNE_TimeToNext.getValue();
	%node.smoothStart = PNE_SmoothStart.getValue();
	%node.smoothEnd = PNE_SmoothEnd.getValue();
	%node.usePosition = PNE_UsePosition.getValue();
	%node.useRotation = PNE_UseRotation.getValue();
	%node.useScale = PNE_UseScale.getValue();
	%node.reverseRotation = PNE_ReverseRotation.getValue();
	%node.rotationMultiplier = PNE_RotationMultiplier.getValue();
	%node.bezier = PNE_Bezier.getValue();
	if (%node.bezier) {
		for (%i = 1; %i <= 2; %i++) {
			if (!isObject(%node.BezierHandle[%i]) && isObject(%node.nextnode)) {
				%name = %node.getName() @ "_Handle" @ %i;
				%pos = vectorAdd(%node.nextnode.getposition(), vectorscale(%node.getposition(), -1));
				%pos = vectorscale(%pos, %i/3);
				%pos = vectorAdd(%node.getposition(), %pos);
				new StaticShape(%name) {
					position = %pos;
					rotation = "1 0 0 0";
					scale = "1 1 1";
					dataBlock = "BezierHandle";
				};
				%name.parentnode = %node;
				%node.BezierHandle[%i] = %name;
			} else //make sure we update in case the node name was changed
				%node.BezierHandle[%i].setName(%node.getName() @ "_Handle" @ %i);
		}
	}
	%node.spline = PNE_Spline.getValue();

	%node.LookAtPoint = PNE_LookAtPoint.getValue();

	//%node.FinalRotOffset = PNE_FinalRotOffset.getValue();
	%node.FinalRotOffset = PNE_FRO_X.getValue() SPC PNE_FRO_Y.getValue() SPC PNE_FRO_Z.getValue();
	%node.branchNodes = PNE_BranchNodes.getValue();
	%node.Speed = PNE_Speed.getValue();

	%gui.cleanup();
	%node.setSync();
	EditorInspector.inspector.inspect(EditorInspector.object);
	EWorldEditor.isDirty = true;
}

function BuildSomeNodes(%name, %number, %loop) {
	%pos = $MP::MyMarble.getPosition();
	%x = getWord(%pos, 0);
	%y = getWord(%pos, 1);
	%z = getWord(%pos, 2);

	for (%i = 1; %i < %number + 1; %i++) {
		if (%loop && %i == %number)
			%next = %name @ 1;
		else
			%next = %name @ (%i + 1);

		%node = new StaticShape(%name @ %i) {
			position = %x SPC (%y + (%i * 2)) SPC %z;
			rotation = "1 0 0 0";
			scale = "1 1 1";
			dataBlock = "PathNode";
			TimeToNext = "2000";
			NextNode = %next;
		};
		MissionGroup.add(%node);
	}
}

function PNEPlace(%node, %flag) {
	if (%flag) {
		%node.setTransform(getCamera().getTransform());
		return;
	}

	%node.setTransform(getCamera().getPosition() SPC %node.getRotation());
}

function newNode(%prevnode) {
	if (!isObject(%prevnode))
		return;

	%blah = getBaseName(%prevnode.getname(), 1);
	%basename = firstWord(%blah);
	%number = restWords(%blah);

	if (isObject(%basename @ %number + 1))
		return;

	%pos = %prevnode.getPosition();

	%node = new StaticShape(%basename @ %number++) {
		position = vectorAdd(%pos, "0 2 0");
		rotation = "1 0 0 0";
		scale = "1 1 1";
		dataBlock = "PathNode";
		TimeToNext = "2000";
		NextNode = %basename @ %number++;
	};
	MissionGroup.add(%node);
}

