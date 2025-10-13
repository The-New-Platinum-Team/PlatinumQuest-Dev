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
// Hard coded images referenced from C++ code
//------------------------------------------------------------------------------

//   editor/SelectHandle.png
//   editor/DefaultHandle.png
//   editor/LockedHandle.png


//------------------------------------------------------------------------------
// Functions
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// Mission Editor
//------------------------------------------------------------------------------

function Editor::create() {
	// Not much to do here, build it and they will come...
	// Only one thing... the editor is a gui control which
	// expect the Canvas to exist, so it must be constructed
	// before the editor.
	new EditManager(Editor) {
		profile = "GuiDefaultProfile";
		horizSizing = "right";
		vertSizing = "top";
		position = "0 0";
		extent = "640 480";
		minExtent = "8 8";
		visible = "1";
		setFirstResponder = "0";
		modal = "1";
		helpTag = "0";
		open = false;
	};
}


function Editor::onAdd(%this) {
	// Basic stuff
	exec("./cursors.cs");

	// Tools
	exec("./editor.bind.cs");
	exec("./objectBuilderGui.gui");
	exec("./ParticleEditor.cs");
	exec("./PETimeLineDlg.cs");
	exec("./PETimeLineDlg.gui");

	// New World Editor
	exec("./EditorGui.gui");
	exec("./EditorGui.cs");

	// skinselection editor
	exec("./SkinSelectionDlg.gui");

	// World Editor
	exec("./WorldEditorSettingsDlg.gui");
	exec("./SingleValueGui.gui");

	// Terrain Editor
	exec("./TerrainEditorVSettingsgui.gui");

	// object saving overrides
	exec("./saveObject.cs");
	exec("./mcs.cs");

	// do gui initialization...
	EditorGui.init();

	//
	exec("./editorrender.cs");

	//
	exec("./blenderconnection.cs");

	ClientMode::callback("onEditorLoad");
	Mode::callback("onEditorLoad");
	Editor::loadFunctions();
}

function Editor::loadFunctions() {
	if (!isObject(LargeFunctionDlg)) {
		exec("./LargeFunctionDlg.gui");
		exec("./functions/changeSkybox.cs");
		exec("./functions/createNewMission.cs");
		exec("./functions/editFadingPlatform.cs");
		exec("./functions/editMissionInfo.cs");
		exec("./functions/editPathNode.cs");
		exec("./functions/editPathTrigger.cs");
		exec("./functions/editPhysModTrigger.cs");
		exec("./functions/editPushButton.cs");
		exec("./functions/parentConfig.cs");
	}
}

function Editor::checkActiveLoadDone() {
	if (isObject(EditorGui) && EditorGui.loadingMission) {
		RootGui.setContent(EditorGui);
		EditorGui.loadingMission = false;
		return true;
	}
	return false;
}

//------------------------------------------------------------------------------
function toggleEditor(%make) {
	if (%make && $Editor::Enabled && !lb()) {
		if (!$missionRunning) {
			MessageBoxOK("Mission Required", "Please load a mission before activating the Level Editor.");
			return;
		}

		if (!isObject(Editor)) {
			Editor::create();
			MissionCleanup.add(Editor);
		}
		if (RootGui.getContent() == EditorGui.getId())
			Editor.close();
		else
			Editor.open();
	}
}

//------------------------------------------------------------------------------
//  The editor action maps are defined in editor.bind.cs
GlobalActionMap.bind(keyboard, "f11", toggleEditor);
