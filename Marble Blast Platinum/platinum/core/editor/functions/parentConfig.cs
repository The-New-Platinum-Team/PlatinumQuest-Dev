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

//----------------------------------------
// Editor: parent config dlg
//


function openParentConfigDlg(%object) {
	LargeFunctionDlg.PCD_Object = %object;
	LargeFunctionDlg.init("acceptParentConfig", "Parent Configuration", 1);
	LargeFunctionDlg.addNote("Editing " @ %object.getClassName() @ " object " @ (%object.getName() !$= "" ? ("(Name: " @ %object.getName() @ ") ") : "") @ "(ID: " @ %object.getID() @ ")");
	LargeFunctionDlg.addButton("PCD_Remove", "Stop Parenting");
	LargeFunctionDlg.addNote();
	LargeFunctionDlg.addNote("---------------------------------------------------------------------------------------");
	LargeFunctionDlg.addNote();
	LargeFunctionDlg.addTextEditField("PCD_Parent", "Parent object name:", %object.parent !$= "" ? %object.parent : "ObjectNameHere", 150, -5);
	LargeFunctionDlg.addCheckBox("PCD_Simple", "Simple (use only Offset, ignores any rotation)", !!%object.parentSimple);
	LargeFunctionDlg.addNote();
	LargeFunctionDlg.addTextEditField("PCD_Offset", "Final unit offset (after rotation):", %object.parentOffset !$= "" ? %object.parentOffset : "0 0 0", 150, -3);
	LargeFunctionDlg.addTextEditField("PCD_PMT", "Parent-child transform value:", %object.parentModTrans !$= "" ? %object.parentModTrans : "0 0 0 1 0 0 0", 350, -3);
	LargeFunctionDlg.addButton("PCD_LCO", "Lock Current Orientation");
	LargeFunctionDlg.addNote();
	LargeFunctionDlg.addNote();
	LargeFunctionDlg.addCheckBox("PCD_SetParent", "setParent on accept? (otherwise, you will need to restart to see changes)", 1);
}

function PCD_Remove::onPressed(%this, %gui) {
	//Stop!
	%gui.PCD_Object.setParent("");
}

function PCD_LCO::onPressed(%this, %gui) {
	%object = %gui.PCD_Object;
	%parent = PCD_Parent.getValue();
	if (isObject(%object) && isObject(%parent)) {
		%transform = calcParentModeTrans(%object, %parent);
		PCD_PMT.setValue(%transform);
	}
}

function acceptParentConfig(%gui) {
	%parent = PCD_Parent.getValue();
	if (!isObject(%parent))
		ASSERT("Parent Error", "The Parent Object Name value is not a real object.");
	else if (isNumber(%parent))
		ASSERT("Parent Error", "The \"Parent object name\" is a numeric ID; please use a name for your parent object.");
	else {
		%object = %gui.PCD_Object;
		%object.parent = %parent;
		%object.parentSimple = PCD_Simple.getValue();
		%object.parentOffset = PCD_Offset.getValue();
		%object.parentModTrans = PCD_PMT.getValue();
		if (PCD_SetParent.getValue())
			%object.setParent(%parent, %object.parentModTrans, %object.parentSimple, %object.parentOffset);
		%gui.cleanup();
	}
}
