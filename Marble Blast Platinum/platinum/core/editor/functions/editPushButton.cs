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

$EPBDefault["triggerObject"] = "ObjectName";
$EPBDefault["objectMethod"] = "doThis(%param1, %param2, %etc)";

/**
 * @param {Type} %obj
 */
function epbbutton(%obj) {
	LargeFunctionDlg.init("editPushButton", "Edit Button", 1);
	$Editor::PushButton = %obj;

	LargeFunctionDlg.addNote("", 0);
	LargeFunctionDlg.addNote("\c5Basic Button Settings", 0);
	LargeFunctionDlg.addTimeEditField("EditPushButton_resetTime", "Reset Time", %obj.resetTime, 100, -1);
	LargeFunctionDlg.addCheckBox("EditPushButton_triggerOnce", "Only Trigger Once", %obj.triggerOnce, 0);

	LargeFunctionDlg.addNote("", 0);
	LargeFunctionDlg.addNote("\c5Targets", 0);

	//How many targets do we need?
	%targets = 8;
	while (%obj.triggerObject[%targets] !$= "") {
		%targets ++;
	}
	//Some extras in case they run out
	%targets += 2;
	$Editor::PushButtonTargets = %targets;

	for (%i = ""; %i < %targets; %i += (!%i + 1)) {
		%triggerObject = (%obj.triggerObject[%i] $= "" ? $EPBDefault["triggerObject"] : %obj.triggerObject[%i]);
		%objectMethod = (%obj.objectMethod[%i] $= "" ? $EPBDefault["objectMethod"] : %obj.objectMethod[%i]);

		LargeFunctionDlg.addTextEditField("EditPushButton_triggerObject_" @ %i, "Trigger Object " @ %i, %triggerObject, 300, -1);
		LargeFunctionDlg.addTextEditField("EditPushButton_objectMethod_" @ %i, "Object Method " @ %i, %objectMethod, 300, -1);
	}
}

/**
 * @param {LargeFunctionDlg} %gui
 */
function editPushButton(%gui) {
	%obj = $Editor::PushButton;

	%obj.resetTime = EditPushButton_resetTime.getValue();
	%obj.triggerOnce = EditPushButton_triggerOnce.getValue();

	for (%i = ""; %i < $Editor::PushButtonTargets; %i += (!%i + 1)) {
		%triggerObject = (EditPushButton_triggerObject_ @ %i).getValue();
		%objectMethod = (EditPushButton_objectMethod_ @ %i).getValue();
		%triggerObject = (%triggerObject $= $EPBDefault["triggerObject"] ? "" : %triggerObject);
		%objectMethod = (%objectMethod $= $EPBDefault["objectMethod"] ? "" : %objectMethod);

		%obj.triggerObject[%i] = %triggerObject;
		%obj.objectMethod[%i] = %objectMethod;
	}

	%gui.cleanup();
	EditorInspector.inspector.inspect(EditorInspector.object);
	EWorldEditor.isDirty = true;
}
