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

$EPTDefault["Object"] = "Object Name";
$EPTDefault["Path"] = "Path Node Name";
$EPTDefault["InitialPosition"] = "0";

/**
 * @param {Type} %obj
 */
function eptbutton(%obj) {
	LargeFunctionDlg.init("editPathTrigger", "Edit Trigger", 1);
	$Editor::PathTrigger = %obj;

	LargeFunctionDlg.addNote("", 0);
	LargeFunctionDlg.addNote("\c5Basic Trigger Settings", 0);
	LargeFunctionDlg.addCheckBox("EditPathTrigger_triggerOnce", "Only Trigger Once", %obj.triggerOnce, 0);

	LargeFunctionDlg.addNote("", 0);
	LargeFunctionDlg.addNote("\c5Targets", 0);

	//How many targets do we need?
	%targets = 3;
	while (%obj.object[%targets] !$= "") {
		%targets ++;
	}
	//Some extras in case they run out
	%targets += 2;
	$Editor::PathTriggerTargets = %targets;

	for (%i = 1; %i < %targets; %i ++) {
		%object          = (%obj.object[%i]          $= "" ? $EPTDefault["object"]          : %obj.object[%i]);
		%path            = (%obj.path[%i]            $= "" ? $EPTDefault["path"]            : %obj.path[%i]);
		%initialPosition = (%obj.initialPosition[%i] $= "" ? $EPTDefault["initialPosition"] : %obj.initialPosition[%i]);

		LargeFunctionDlg.addTextEditField("EditPathTrigger_object_"          @ %i, "Trigger Object "   @ %i, %object, 300, -1);
		LargeFunctionDlg.addTextEditField("EditPathTrigger_path_"            @ %i, "Object Path "      @ %i, %path, 300, -1);
		LargeFunctionDlg.addTimeEditField("EditPathTrigger_initialPosition_" @ %i, "Initial Position " @ %i, %initialPosition, 300, -1);
	}
}

/**
 * @param {LargeFunctionDlg} %gui
 */
function editPathTrigger(%gui) {
	%obj = $Editor::PathTrigger;

	%obj.triggerOnce = EditPathTrigger_triggerOnce.getValue();

	for (%i = 1; %i < $Editor::PathTriggerTargets; %i ++) {
		%object          = (EditPathTrigger_object_          @ %i).getValue();
		%path            = (EditPathTrigger_path_            @ %i).getValue();
		%initialPosition = (EditPathTrigger_initialPosition_ @ %i).getValue();
		%object          = (%object          $= $EPTDefault["object"]          ? "" : %object);
		%path            = (%path            $= $EPTDefault["path"]            ? "" : %path);
		%initialPosition = (%initialPosition $= $EPTDefault["initialPosition"] ? "" : %initialPosition);

		%obj.object[%i]          = %object;
		%obj.path[%i]            = %path;
		%obj.initialPosition[%i] = %initialPosition;
	}

	%gui.cleanup();
	EditorInspector.inspector.inspect(EditorInspector.object);
	EWorldEditor.isDirty = true;
}
