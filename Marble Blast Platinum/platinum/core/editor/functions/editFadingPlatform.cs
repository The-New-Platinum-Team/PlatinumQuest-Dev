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

$EFPDefault["fadeOutTime"]   = "500";
$EFPDefault["invisibleTime"] = "1500";
$EFPDefault["fadeInTime"]    = "500";
$EFPDefault["permanent"]     = "0";
$EFPDefault["startOffset"]   = "0";
$EFPDefault["visibleTime"]   = "1500";
$EFPDefault["level"]         = "2";
$EFPDefault["initialState"]  = "0";

function efpbutton(%obj) {
	$Editor::FadingPlatform = %obj;
	$EFPFunctionality = %obj.functionality;

	efpUpdate();
}

function efpupdate() {
	%obj = $Editor::FadingPlatform;
	LargeFunctionDlg.init("editFadingPlatform", "Edit Fading Platform", 1);

	%funcList =
	    "trapdoor" TAB "Trapdoor" NL
	    "periodic" TAB "Periodic" NL
	    "fading" TAB "Fading";

	if (EWorldEditor.getSelectionSize() == 1) {
		LargeFunctionDlg.addNote("\c5Editing " @ %obj.getName() @ " (Object " @ %obj.getID() @ ")");
		LargeFunctionDlg.addTextEditField("EFP_Name", "Fading platform name:", %obj.getName(), 150, -3);
	} else {
		LargeFunctionDlg.addNote("\c5Editing many fading platforms");
	}
	LargeFunctionDlg.addNote("", 0);

	//LargeFunctionDlg.addNote("\c5Basic Trigger Settings", 0);
	//LargeFunctionDlg.addCheckBox("EditPathTrigger_triggerOnce", "Only Trigger Once", %obj.triggerOnce, 0);
	//LargeFunctionDlg.addTimeEditField("EditPathTrigger_initialPosition_" @ %i, "Initial Position " @ %i, %initialPosition, 300, -1);

	LargeFunctionDlg.addNote("Platform Style:", 0);
	LargeFunctionDlg.addNote("This is how you want the fading platform to behave. Each style is slightly different:", 0);
	LargeFunctionDlg.addNote("\c5Trapdoor\c0 fading platforms will fade out after being touched once. They remain invisible", 1);
	LargeFunctionDlg.addNote("for a given period of time and then reappear if not marked as \c5permanent\c0.", 2);
	LargeFunctionDlg.addNote("\c5Periodic\c0 fading platforms will fade in and out automatically on their own. You can specify", 1);
	LargeFunctionDlg.addNote("how long they will take to fade out, remain invisible, fade in, and remain visible. So everything.", 2);
	LargeFunctionDlg.addNote("\c5Fading\c0 fading platforms have a given number of times they can be hit, and fade out over time", 1);
	LargeFunctionDlg.addNote("as you remain on the platform, or one step every time you touch it. You can set", 2);
	LargeFunctionDlg.addNote("the maximum number of times the player is allowed to touch the platform.", 2);
	LargeFunctionDlg.addDropMenu("EFP_Functionality", "Fading Platform Style", 4, %funcList, %obj.functionality);
	EFP_Functionality.command = "efpUpdateFunc();";

	switch$ ($EFPFunctionality) {
	case "trapdoor":
		LargeFunctionDlg.addNote("When the player touches the platform, it will fade out for \c5fadeOutTime\c0 seconds.", 1);
		LargeFunctionDlg.addNote("It will then stop being solid and stay hidden for \c5invisibleTime\c0 seconds.", 1);
		LargeFunctionDlg.addNote("If not permanent, it will become solid again and fade in for \c5fadeInTime\c0 seconds.", 1);
		LargeFunctionDlg.addNote("After that, it will become enabled again.", 1);
		LargeFunctionDlg.addNote("", 0);

		LargeFunctionDlg.addTimeEditField("EFP_fadeOutTime", "Fade Out Time", (%obj.fadeOutTime $= "" ? $EFPDefault["fadeOutTime"] : %obj.fadeOutTime), 0);
		LargeFunctionDlg.addTimeEditField("EFP_invisibleTime", "Invisible Time", (%obj.invisibleTime $= "" ? $EFPDefault["invisibleTime"] : %obj.invisibleTime), 0);
		LargeFunctionDlg.addTimeEditField("EFP_fadeInTime", "Fade in Time", (%obj.fadeInTime $= "" ? $EFPDefault["fadeInTime"] : %obj.fadeInTime), 0);

		LargeFunctionDlg.addCheckBox("EFP_permanent", "Platform is Permanent (don't fade back in)", (%obj.permanent $= "" ? $EFPDefault["permanent"] : %obj.permanent), 0);
	case "periodic":
		LargeFunctionDlg.addNote("At the start of the mission, the platform will wait \c5startOffset\c0 seconds.", 1);
		LargeFunctionDlg.addNote("Then it will fade out for \c5fadeOutTime\c0 seconds.", 2);
		LargeFunctionDlg.addNote("It will then stop being solid and stay hidden for \c5invisibleTime\c0 seconds.", 2);
		LargeFunctionDlg.addNote("Then it will become solid again and fade in for \c5fadeInTime\c0 seconds.", 2);
		LargeFunctionDlg.addNote("After that, it will become visible for \c5visibleTime\c0 seconds.", 2);
		LargeFunctionDlg.addNote("Then it will start fading out again.", 2);
		LargeFunctionDlg.addNote("", 0);

		LargeFunctionDlg.addTimeEditField("EFP_startOffset", "Start Offset", (%obj.startOffset $= "" ? $EFPDefault["startOffset"] : %obj.startOffset), 0);
		LargeFunctionDlg.addTimeEditField("EFP_fadeOutTime", "Fade Out Time", (%obj.fadeOutTime $= "" ? $EFPDefault["fadeOutTime"] : %obj.fadeOutTime), 0);
		LargeFunctionDlg.addTimeEditField("EFP_invisibleTime", "Invisible Time", (%obj.invisibleTime $= "" ? $EFPDefault["invisibleTime"] : %obj.invisibleTime), 0);
		LargeFunctionDlg.addTimeEditField("EFP_fadeInTime", "Fade In Time", (%obj.fadeInTime $= "" ? $EFPDefault["fadeInTime"] : %obj.fadeInTime), 0);
		LargeFunctionDlg.addTimeEditField("EFP_visibleTime", "Visible Time", (%obj.visibleTime $= "" ? $EFPDefault["visibleTime"] : %obj.visibleTime), 0);
	case "fading":
		LargeFunctionDlg.addNote("The platform will slowly fade out over \c5level\c0 different stages.", 1);
		LargeFunctionDlg.addNote("At the start of the mission, the platform will fade out \c5initialState\c0 steps.", 1);
		LargeFunctionDlg.addNote("", 0);

		LargeFunctionDlg.addTextEditField("EFP_level", "Number of stages to fade out entirely:", (%obj.level $= "" ? $EFPDefault["level"] : %obj.level), 0);
		LargeFunctionDlg.addTextEditField("EFP_initialState", "Number of stages faded at start:", (%obj.initialState $= "" ? $EFPDefault["initialState"] : %obj.initialState), 0);
	}
}

function efpUpdateFunc() {
	%func = EFP_Functionality.getValue();
	%func = strReplace(%func, "*", "");
	$EFPFunctionality = %func;
	efpUpdate();
}

function editFadingPlatform(%gui) {
	EWorldEditor.applyAllSelection("efpApply");

	%gui.cleanup();
	EditorInspector.inspector.inspect(EditorInspector.object);
	EWorldEditor.isDirty = true;
}

function efpApply(%obj) {
	%obj.functionality = $EFPFunctionality;
	switch$ ($EFPFunctionality) {
	case "trapdoor":
		%obj.fadeOutTime = (EFP_fadeOutTime.getValue() $= "" ? $EFPDefault["fadeOutTime"] : EFP_fadeOutTime.getValue());
		%obj.invisibleTime = (EFP_invisibleTime.getValue() $= "" ? $EFPDefault["invisibleTime"] : EFP_invisibleTime.getValue());
		%obj.fadeInTime = (EFP_fadeInTime.getValue() $= "" ? $EFPDefault["fadeInTime"] : EFP_fadeInTime.getValue());
		%obj.permanent = (EFP_permanent.getValue() $= "" ? $EFPDefault["permanent"] : EFP_permanent.getValue());
	case "periodic":
		%obj.startOffset = (EFP_startOffset.getValue() $= "" ? $EFPDefault["startOffset"] : EFP_startOffset.getValue());
		%obj.fadeOutTime = (EFP_fadeOutTime.getValue() $= "" ? $EFPDefault["fadeOutTime"] : EFP_fadeOutTime.getValue());
		%obj.invisibleTime = (EFP_invisibleTime.getValue() $= "" ? $EFPDefault["invisibleTime"] : EFP_invisibleTime.getValue());
		%obj.fadeInTime = (EFP_fadeInTime.getValue() $= "" ? $EFPDefault["fadeInTime"] : EFP_fadeInTime.getValue());
		%obj.visibleTime = (EFP_visibleTime.getValue() $= "" ? $EFPDefault["visibleTime"] : EFP_visibleTime.getValue());
	case "fading":
		%obj.level = (EFP_level.getValue() $= "" ? $EFPDefault["level"] : EFP_level.getValue());
		%obj.initialState = (EFP_initialState.getValue() $= "" ? $EFPDefault["initialState"] : EFP_initialState.getValue());
	}
}
