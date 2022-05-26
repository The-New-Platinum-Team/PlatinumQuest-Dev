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
//-----------------------------------------------------------------------------

//
// Terrain editor should not pop up in the Level Editor!!!
// It's functional as you can see below but doesn't appear anymore!
// Also commented out bits not used in the Level Editor by anyone.
//


// All level editor prefs are saved here
$Editor::PrefsFile = "~/core/editor/WEprefs.cs";

function EditorGui::getPrefs() {
	// Load level editor prefs ($WEpref::) from disk
	exec($Editor::PrefsFile);
	EWorldEditor.dropType = getPrefSetting($WEpref::dropType, "atCamera");

	// same defaults as WorldEditor ctor
	EWorldEditor.planarMovement = getPrefSetting($WEpref::planarMovement, true);
	EWorldEditor.undoLimit = getPrefSetting($WEpref::undoLimit, 40);
	EWorldEditor.projectDistance = getPrefSetting($WEpref::projectDistance, 2000);
	EWorldEditor.boundingBoxCollision = getPrefSetting($WEpref::boundingBoxCollision, true);
	EWorldEditor.renderPlane = getPrefSetting($WEpref::renderPlane, true);
	EWorldEditor.renderPlaneHashes = getPrefSetting($WEpref::renderPlaneHashes, true);
	EWorldEditor.gridColor = getPrefSetting($WEpref::gridColor, "255 255 255 20");
	EWorldEditor.planeDim = getPrefSetting($WEpref::planeDim, 500);
	EWorldEditor.gridSize = getPrefSetting($WEpref::gridSize, "10 10 10");
	EWorldEditor.renderPopupBackground = getPrefSetting($WEpref::renderPopupBackground, true);
	EWorldEditor.popupBackgroundColor = getPrefSetting($WEpref::popupBackgroundColor, "100 100 100");
	EWorldEditor.popupTextColor = getPrefSetting($WEpref::popupTextColor, "255 255 0");
	EWorldEditor.objectTextColor = getPrefSetting($WEpref::objectTextColor, "255 255 255");
	EWorldEditor.objectsUseBoxCenter = getPrefSetting($WEpref::objectsUseBoxCenter, true);
	EWorldEditor.axisGizmoMaxScreenLen = getPrefSetting($WEpref::axisGizmoMaxScreenLen, 200);
	EWorldEditor.axisGizmoActive = getPrefSetting($WEpref::axisGizmoActive, true);
	EWorldEditor.mouseMoveScale = getPrefSetting($WEpref::mouseMoveScale, 0.25);
	EWorldEditor.mouseRotateScale = getPrefSetting($WEpref::mouseRotateScale, $pi / 16);
	EWorldEditor.mouseScaleScale = getPrefSetting($WEpref::mouseScaleScale, 0.01);
	EWorldEditor.minScaleFactor = getPrefSetting($WEpref::minScaleFactor, 0.1);
	EWorldEditor.maxScaleFactor = getPrefSetting($WEpref::maxScaleFactor, 4000);
	EWorldEditor.objSelectColor = getPrefSetting($WEpref::objSelectColor, "255 0 0");
	EWorldEditor.objMouseOverSelectColor = getPrefSetting($WEpref::objMouseOverSelectColor, "0 0 255");
	EWorldEditor.objMouseOverColor = getPrefSetting($WEpref::objMouseOverColor, "0 255 0");
	EWorldEditor.showMousePopupInfo = getPrefSetting($WEpref::showMousePopupInfo, true);
	EWorldEditor.dragRectColor = getPrefSetting($WEpref::dragRectColor, "255 255 0");
	EWorldEditor.renderObjText = getPrefSetting($WEpref::renderObjText, true);
	EWorldEditor.renderObjHandle = getPrefSetting($WEpref::renderObjHandle, true);
	EWorldEditor.faceSelectColor = getPrefSetting($WEpref::faceSelectColor, "0 0 100 100");
	EWorldEditor.renderSelectionBox = getPrefSetting($WEpref::renderSelectionBox, true);
	EWorldEditor.selectionBoxColor = getPrefSetting($WEpref::selectionBoxColor, "255 255 0");
	EWorldEditor.snapToGrid = getPrefSetting($WEpref::snapToGrid, false);
	EWorldEditor.snapRotations = getPrefSetting($WEpref::snapRotations, false);
	EWorldEditor.rotationSnap = getPrefSetting($WEpref::rotationSnap, "15");
	EWorldEditor.descriptiveFieldNames = getPrefSetting($WEpref::descriptiveFieldNames, true);
	EWorldEditor.gemType = getPrefSetting($WEpref::gemType, "pq");
}

function EditorGui::setPrefs() {
	$WEpref::dropType = EWorldEditor.dropType;
	$WEpref::planarMovement = EWorldEditor.planarMovement;
	$WEpref::undoLimit = EWorldEditor.undoLimit;
	$WEpref::projectDistance = EWorldEditor.projectDistance;
	$WEpref::boundingBoxCollision = EWorldEditor.boundingBoxCollision;
	$WEpref::renderPlane = EWorldEditor.renderPlane;
	$WEpref::renderPlaneHashes = EWorldEditor.renderPlaneHashes;
	$WEpref::gridColor = EWorldEditor.GridColor;
	$WEpref::planeDim = EWorldEditor.planeDim;
	$WEpref::gridSize = EWorldEditor.GridSize;
	$WEpref::renderPopupBackground = EWorldEditor.renderPopupBackground;
	$WEpref::popupBackgroundColor = EWorldEditor.PopupBackgroundColor;
	$WEpref::popupTextColor = EWorldEditor.PopupTextColor;
	$WEpref::objectTextColor = EWorldEditor.ObjectTextColor;
	$WEpref::objectsUseBoxCenter = EWorldEditor.objectsUseBoxCenter;
	$WEpref::axisGizmoMaxScreenLen = EWorldEditor.axisGizmoMaxScreenLen;
	$WEpref::axisGizmoActive = EWorldEditor.axisGizmoActive;
	$WEpref::mouseMoveScale = EWorldEditor.mouseMoveScale;
	$WEpref::mouseRotateScale = EWorldEditor.mouseRotateScale;
	$WEpref::mouseScaleScale = EWorldEditor.mouseScaleScale;
	$WEpref::minScaleFactor = EWorldEditor.minScaleFactor;
	$WEpref::maxScaleFactor = EWorldEditor.maxScaleFactor;
	$WEpref::objSelectColor = EWorldEditor.objSelectColor;
	$WEpref::objMouseOverSelectColor = EWorldEditor.objMouseOverSelectColor;
	$WEpref::objMouseOverColor = EWorldEditor.objMouseOverColor;
	$WEpref::showMousePopupInfo = EWorldEditor.showMousePopupInfo;
	$WEpref::dragRectColor = EWorldEditor.dragRectColor;
	$WEpref::renderObjText = EWorldEditor.renderObjText;
	$WEpref::renderObjHandle = EWorldEditor.renderObjHandle;
	$WEpref::raceSelectColor = EWorldEditor.faceSelectColor;
	$WEpref::renderSelectionBox = EWorldEditor.renderSelectionBox;
	$WEpref::selectionBoxColor = EWorldEditor.selectionBoxColor;
	$WEpref::snapToGrid = EWorldEditor.snapToGrid;
	$WEpref::snapRotations = EWorldEditor.snapRotations;
	$WEpref::rotationSnap = EWorldEditor.rotationSnap;
	$WEpref::descriptiveFieldNames = EWorldEditor.descriptiveFieldNames;
	$WEpref::gemType = EWorldEditor.gemType;

	// Save level editor prefs ($WEpref::) to disk
	export("$WEpref*", $Editor::PrefsFile);
}

function EditorGui::onSleep(%this) {
	%this.setPrefs();
}

function EditorGui::init(%this) {
	%this.getPrefs();

	$SelectedOperation = -1;
	$NextOperationId   = 1;

	EditorMenuBar.clearMenus();
	EditorMenuBar.addMenu("File", 0);
	EditorMenuBar.addMenuItem("File", "New Mission...", 1);
	EditorMenuBar.addMenuItem("File", "Open Mission...", 2, "Ctrl O");
	EditorMenuBar.addMenuItem("File", "Save Mission...", 3, "Ctrl S");
	EditorMenuBar.addMenuItem("File", "Save Mission As...", 4);
	EditorMenuBar.addMenuItem("File", "-", 0);
	EditorMenuBar.addMenuItem("File", "Reload Current Mission", 5);
	EditorMenuBar.addMenuItem("File", "Test Mission", 6);
	EditorMenuBar.addMenuItem("File", "Test Camera Path", 7);
	EditorMenuBar.addMenuItem("File", "-", 0);
	EditorMenuBar.addMenuItem("File", "Get Icon Picture", 8);
	EditorMenuBar.addMenuItem("File", "Get Preview Picture", 9);

	EditorMenuBar.addMenu("Edit", 1);
	EditorMenuBar.addMenuItem("Edit", "Undo", 1, "Ctrl Z");
	EditorMenuBar.setMenuItemBitmap("Edit", "Undo", 1);
	EditorMenuBar.addMenuItem("Edit", "Redo", 2, "Ctrl R");
	EditorMenuBar.setMenuItemBitmap("Edit", "Redo", 2);
	EditorMenuBar.addMenuItem("Edit", "-", 0);
	EditorMenuBar.addMenuItem("Edit", "Cut", 3, "Ctrl X");
	EditorMenuBar.setMenuItemBitmap("Edit", "Cut", 3);
	EditorMenuBar.addMenuItem("Edit", "Copy", 4, "Ctrl C");
	EditorMenuBar.setMenuItemBitmap("Edit", "Copy", 4);
	EditorMenuBar.addMenuItem("Edit", "Paste", 5, "Ctrl V");
	EditorMenuBar.setMenuItemBitmap("Edit", "Paste", 5);
	EditorMenuBar.addMenuItem("Edit", "-", 0);
	EditorMenuBar.addMenuItem("Edit", "Select All", 6, "Ctrl A");
	EditorMenuBar.addMenuItem("Edit", "Select None", 7, "Ctrl N");
	EditorMenuBar.addMenuItem("Edit", "-", 0);
	EditorMenuBar.addMenuItem("Edit", "World Editor Settings...", 12);
	EditorMenuBar.addMenuItem("Edit", "-", 0);
	EditorMenuBar.addMenuItem("Edit", "Group Selection", 8);
	EditorMenuBar.addMenuItem("Edit", "Ungroup Selection", 9);

	EditorMenuBar.addMenu("Camera", 7);
	EditorMenuBar.addMenuItem("Camera", "Drop Camera at Player", 1, "Alt Q");
	EditorMenuBar.addMenuItem("Camera", "Drop Player at Camera", 2, "Alt W");
	EditorMenuBar.addMenuItem("Camera", "Toggle Camera", 10, "Alt C");
	EditorMenuBar.addMenuItem("Camera", "-", 0);
	EditorMenuBar.addMenuItem("Camera", "Slowest", 3, "Shift 1", 1);
	EditorMenuBar.addMenuItem("Camera", "Very Slow", 4, "Shift 2", 1);
	EditorMenuBar.addMenuItem("Camera", "Slow", 5, "Shift 3", 1);
	EditorMenuBar.addMenuItem("Camera", "Medium Pace", 6, "Shift 4", 1);
	EditorMenuBar.addMenuItem("Camera", "Fast", 7, "Shift 5", 1);
	EditorMenuBar.addMenuItem("Camera", "Very Fast", 8, "Shift 6", 1);
	EditorMenuBar.addMenuItem("Camera", "Fastest", 9, "Shift 7", 1);
	EditorMenuBar.addMenuItem("Camera", "-", 0);
	EditorMenuBar.addMenuItem("Camera", "Focus on Selection", 11, "Alt F");

	EditorMenuBar.addMenu("World", 6);
	EditorMenuBar.addMenuItem("World", "Lock Selection", 10, "Ctrl L");
	EditorMenuBar.addMenuItem("World", "Unlock Selection", 11, "Ctrl Shift L");
	EditorMenuBar.addMenuItem("World", "-", 0);
	EditorMenuBar.addMenuItem("World", "Hide Selection", 12, "Ctrl H");
	EditorMenuBar.addMenuItem("World", "Show Selection", 13, "Ctrl Shift H");
	EditorMenuBar.addMenuItem("World", "-", 0);
	EditorMenuBar.addMenuItem("World", "Delete Selection", 17, "Delete");
	EditorMenuBar.addMenuItem("World", "Camera To Selection", 14);
	EditorMenuBar.addMenuItem("World", "Reset Transforms", 15);
	EditorMenuBar.addMenuItem("World", "Drop Selection", 16, "Ctrl D");
	EditorMenuBar.addMenuItem("World", "Add Selection to Instant Group", 17);
	EditorMenuBar.addMenuItem("World", "-", 0);
	//EditorMenuBar.addMenuItem("World", "Drop at Origin", 0, "", 1);
	EditorMenuBar.addMenuItem("World", "Drop at Camera", 1, "Alt 1", 1);
	EditorMenuBar.addMenuItem("World", "Drop at Average Camera", 7, "Alt 2", 1);
	//EditorMenuBar.addMenuItem("World", "Drop at Camera w/Rot", 2, "", 1);
	//EditorMenuBar.addMenuItem("World", "Drop below Camera", 3, "", 1);
	//EditorMenuBar.addMenuItem("World", "Drop at Screen Center", 4, "", 1);
	EditorMenuBar.addMenuItem("World", "Drop at Centroid", 5, "Alt 3", 1);
	EditorMenuBar.addMenuItem("World", "Drop to Ground", 6, "Alt 4", 1);

	EditorMenuBar.addMenu("Create", 7);
	EditorMenuBar.addMenuItem("Create", "- Pads -", 0);
	EditorMenuBar.addMenuItemConf("Create", "Start Pad", 23, "", 1);
	EditorMenuBar.addMenuItemConf("Create", "End Pad", 24, "", 1);
	EditorMenuBar.addMenuItem("Create", "- Gems -", 0);
	EditorMenuBar.addMenuItemConf("Create", "Red Gem", 1, "1", 1);
	EditorMenuBar.addMenuItemConf("Create", "Yellow Gem", 2, "2", 1);
	EditorMenuBar.addMenuItemConf("Create", "Blue Gem", 3, "3", 1);
	EditorMenuBar.addMenuItemConf("Create", "Platinum Gem", 18, "", 1);
	EditorMenuBar.addMenuItemConf("Create", "Random Color Gem", 19, "", 1);
	EditorMenuBar.addMenuItem("Create", "- Powerups -", 0);
	EditorMenuBar.addMenuItemConf("Create", "Super Jump", 4, "4", 1);
	EditorMenuBar.addMenuItemConf("Create", "Super Speed", 5, "5", 1);
	EditorMenuBar.addMenuItemConf("Create", "Gyrocopter", 6, "6", 1);
	EditorMenuBar.addMenuItemConf("Create", "Super Bounce", 7, "7", 1);
	EditorMenuBar.addMenuItemConf("Create", "Shock Absorber", 20, "8", 1);
	EditorMenuBar.addMenuItemConf("Create", "Time Travel", 8, "9", 1);
	EditorMenuBar.addMenuItemConf("Create", "Time Penalty", 9, "0", 1);
	EditorMenuBar.addMenuItemConf("Create", "Mega Marble", 10, "-", 1);
	EditorMenuBar.addMenuItemConf("Create", "Ultra Blast", 11, "=", 1);
    EditorMenuBar.addMenuItemConf("Create", "Teleporter", 12, "", 1);
	EditorMenuBar.addMenuItem("Create", "- Triggers -", 0);
    EditorMenuBar.addMenuItemConf("Create", "Spawn Trigger", 13, "", 1);
	EditorMenuBar.addMenuItemConf("Create", "Bounds Trigger", 14, "", 1);
	EditorMenuBar.addMenuItemConf("Create", "Help Text Trigger", 22, "", 1);
	EditorMenuBar.addMenuItem("Create", "- Others -", 0);
	EditorMenuBar.addMenuItemConf("Create", "Gem Group", 15, "", 1);
	EditorMenuBar.addMenuItemConf("Create", "Camera Marker", 16, "M", 1);
	EditorMenuBar.addMenuItemConf("Create", "PathNode at Selection", 17, "", 1);
	EditorMenuBar.addMenuItemConf("Create", "Marble Dummy", 21, "N", 1);

	EditorMenuBar.addMenu("Special", 8);
	EditorMenuBar.addMenuItem("Special", "Make GemGroup", 1);
	EditorMenuBar.addMenuItem("Special", "Destroy GemGroups", 2);
	EditorMenuBar.addMenuItem("Special", "-", 0);
	EditorMenuBar.addMenuItem("Special", "Show all Gems", 3);
	EditorMenuBar.addMenuItem("Special", "Hide all Gems", 8);
	EditorMenuBar.addMenuItem("Special", "Spawn GemGroup", 9);
	EditorMenuBar.addMenuItem("Special", "-", 0);
	EditorMenuBar.addMenuItem("Special", "Drop at Ground", 4);
	EditorMenuBar.addMenuItem("Special", "Round Coordinates", 5);
	EditorMenuBar.addMenuItem("Special", "Drop + Round", 6);
	EditorMenuBar.addMenuItem("Special", "-", 0);
	EditorMenuBar.addMenuItem("Special", "Random Offset", 7);
	EditorMenuBar.addMenuItem("Special", "Skin Selector", 8);

	EditorMenuBar.addMenu("Window", 2);
	EditorMenuBar.addMenuItem("Window", "World Editor", 2, "F2", 1);
	EditorMenuBar.addMenuItem("Window", "World Editor Inspector", 3, "F3", 1);
	EditorMenuBar.addMenuItem("Window", "World Editor Creator", 4, "F4", 1);
	EditorMenuBar.addMenuItem("Window", "Particle Editor", 6, "F5", 1);

	EditorMenuBar.onCameraMenuItemSelect(6, "Medium Pace");
	switch$ ($WEpref::dropType) {
		case "atOrigin":     EditorMenuBar.onWorldMenuItemSelect(0, "Drop at Origin");
		case "atCamera":     EditorMenuBar.onWorldMenuItemSelect(1, "Drop at Camera");
		case "atCamera":     EditorMenuBar.onWorldMenuItemSelect(7, "Drop at Average Camera");
		case "atCameraRot":  EditorMenuBar.onWorldMenuItemSelect(2, "Drop at Camera w/Rot");
		case "belowCamera":  EditorMenuBar.onWorldMenuItemSelect(3, "Drop below Camera");
		case "screenCenter": EditorMenuBar.onWorldMenuItemSelect(4, "Drop at Screen Center");
		case "toGround":     EditorMenuBar.onWorldMenuItemSelect(5, "Drop to Ground");
		case "atCentroid":   EditorMenuBar.onWorldMenuItemSelect(6, "Drop at Centroid");
	}

	EWorldEditor.init();

	//
	Creator.init();
	EditorTree.init();
	ObjectBuilderGui.init();
	EWActiveReplayList.init();

	EWorldEditor.isDirty = false;
	EditorGui.saveAs = false;
}

//Add a menu bar item, only if the key is not in your config.
// For Whirligig who uses 4 to roll forward and ended up creating lots of SpawnTriggers.
function EditorMenuBar::addMenuItemConf(%this, %menu, %menuItemText, %menuItemId, %accelerator, %checkGroup) {
	%command = MoveMap.getCommand("keyboard", %accelerator);
	if (%command !$= "") {
		//Let taunt keys go through to the editor
		if (strPos(%command, "taunt") == -1)
			%accelerator = "";
	}
	%this.addMenuItem(%menu, %menuItemText, %menuItemId, %accelerator, %checkGroup);
}

function EditorNewMission() {
	if (EWorldEditor.isDirty) {
		MessageBoxYesNo("Mission Modified", "Would you like to save changes to the current mission \"" @
		                $Server::MissionFile @ "\" before creating a new mission?", "EditorDoNewMission(true);", "EditorDoNewMission(false);");
	} else
		EditorDoNewMission(false);
}

function EditorSaveMissionMenu() {
	if (EditorGui.saveAs)
		EditorSaveMissionAs();
	else
		EditorSaveMission();
}

function EditorSaveMission() {
	if ($Server::MissionFile $= ($usermods @ "/data/multiplayer/hunt/custom/ExampleMission.mis") || $Server::MissionFile $= ($usermods @ "/data/missions/MissionTemplate.mis")) {
		EditorSaveMissionAs();
		return;
	}
	// just save the mission without renaming it

	// first check for dirty and read-only files:
	if ((EWorldEditor.isDirty) && !isWriteableFileName($Server::MissionFile)) {
		MessageBoxOK("Error", "Mission file \""@ $Server::MissionFile @ "\" is read-only.");
		return false;
	}

	// now write the terrain and mission files out:

	if (EWorldEditor.isDirty) {
		// Update the base transforms of the moving platforms incase the user never hit Apply in the inspector
		updatePathedInteriorBaseTransforms();
		deactivatePackage(save);
		ActivatePackage(save);
		onMissionReset();
		MissionGroup._presave();

		%compiled = false;
		if (!EditorWriteMission($Server::MissionFile, %compiled)) {
			//Didn't work? Clean up the stuff
			MissionGroup._postsave();
			deactivatePackage(save);

			return false;
		}

		MissionGroup._postsave();
		deactivatePackage(save);

		MessageBoxOK("Saved", "Saved mission to file \""@ $Server::MissionFile @ "\".");
	}

	EWorldEditor.isDirty = false;
	EditorGui.saveAs = false;

	return true;
}

function EditorWriteMission(%file, %compiled) {
	if (!isObject(MissionInfo)) {
		MessageBoxOK("Error", "Your mission has no MissionInfo! Please create one so the level select can show it properly.");
		return false;
	}

	//Nothing special about ordinary missions
	if (!%compiled) {
		MissionGroup.add(MissionInfo);
		MissionGroup.bringToFront(MissionInfo);

		//Make a back up
		%backup = %file @ ".tmp";
		copyFile(%file, %backup);

		//Just save it like normal
		MissionGroup.save(%file);
		return true;
	}

	//Stop trying to overwrite our missions, dummy
	if (!isFile(%file) && isFile(%file @ ".dso")) {
		MessageBoxOK("Error", "You're trying to save a compiled mission without the source!" NL
		             "This will break the mission and is a Very Bad Idea (TM)." NL
		             "If you are creating a new level, use Save As and give it a different file name.");
		return false;
	}

	return mcsSaveMission(%file);
}

function EditorDoSaveAs(%missionName) {
	activatePackage(Save);
	EWorldEditor.isDirty = true;
	%saveMissionFile = $Server::MissionFile;

	$Server::MissionFile = %missionName;

	if (!EditorSaveMission()) {
		$Server::MissionFile = %saveMissionFile;
	}
}

function EditorSaveMissionAs() {
	getSaveFilename("*.mis", "EditorDoSaveAs", $Server::MissionFile);

}

function EditorDoLoadMission(%file) {
	// close the current editor, it will get cleaned up by MissionCleanup
	Editor.close();

	loadMission(%file, true) ;

	// recreate and open the editor
	Editor::create();
	MissionCleanup.add(Editor);
	EditorGui.loadingMission = true;
	Editor.open();
}

function EditorSaveBeforeLoad() {
	if (EditorSaveMission())
		getLoadFilename("~/data/missions*/*.mis\t~/data/missions*/*.mcs", "EditorDoLoadMission");
}

function EditorDoNewMission(%saveFirst) {
	if (%saveFirst)
		EditorSaveMission();

	%file = $Server::ServerType $= "MultiPlayer" ? "ExampleMission.mis" : "MissionTemplate.mis";
	%mission = findFirstFile("*/" @ %file);
	if (%mission $= "") {
		MessageBoxOk("Error", "Missing mission template \"" @ %file @ "\".");
		return;
	}
	EditorDoLoadMission(%mission);
	EditorGui.saveAs = true;
	EWorldEditor.isDirty = true;
}

function EditorOpenMission() {
	if (EWorldEditor.isDirty) {
		MessageBoxYesNo("Mission Modified", "Would you like to save changes to the current mission \"" @
		                $Server::MissionFile @ "\" before opening a new mission?", "EditorSaveBeforeLoad();", "getLoadFilename(\"~/data/missions*/*.mis\\t~/data/missions*/*.mcs\", \"EditorDoLoadMission\");");
	} else
		getLoadFilename("~/data/missions*/*.mis\t~/data/missions*/*.mcs", "EditorDoLoadMission");
}

function EditorReloadMission(%test) {
	if (EWorldEditor.isDirty) {
		MessageBoxYesNo("Mission Modified", "Would you like to save changes to the current mission \"" @
		                $Server::MissionFile @ "\" before " @ (%test ? "testing" : "reloading") @ " it?",
		                "EditorSaveBeforeReload(" @ %test @ ");", "EditorDoReloadMission(" @ %test @ ");");
	} else {
		EditorDoReloadMission(%test);
	}
}

function EditorSaveBeforeReload(%test) {
	if (EditorSaveMission())
		EditorDoReloadMission(%test);
}

function EditorDoReloadMission(%test) {
	$Editor::Test = %test;
	//Reload their current mission
	Editor.close();

	activateMenuHandler("EditorMenu");

	menuDestroyServer();

	RootGui.setContent(LoadingGui);
	RootGui.showPreviewImage(true);
	Canvas.repaint();

	menuCreateServer();
	menuLoadMission($Server::MissionFile);
	$Game::UseMenu = true;

	RootGui.setContent(LoadingGui);
}
function EditorMenu_MissionLoaded() {
	menuPlay();
}
function EditorMenu_Play() {
	deactivateMenuHandler("EditorMenu");

	if (!$Editor::Test) {
		$Editor::Enabled = true;
		$Editor::Opened = true;
		Editor::create();
		MissionCleanup.add(Editor);
		Editor.open();
	}

	RootGui.showPreviewImage(false);
}

function EditorTestCameraPath() {
	LocalClientConnection.setToggleCamera(true);

	%camera = LocalClientConnection.camera;
	%camera.setTransform(CameraPath1.getTransform());
	getCamera().setTransform(CameraPath1.getTransform());

	//Start camera loop
	$EditorCamSchedule =%camera.schedule(500, moveOnPath, CameraPath1);
	$EditorTestCamPath = true;
}

function EditorIconScreenshot() {
	doMiniShot();
	RootGui.setContent(EditorGui);
}

function EditorPreviewScreenshot() {
	LocalClientConnection.setToggleCamera(true);
	schedule(100, 0, EditorDoPreviewScreenshot);
}

function EditorDoPreviewScreenshot() {
	getCamera().setTransform(CameraPath1.getTransform());

	%path = filePath($Server::MissionFile) @ "/" @ fileBase($Server::MissionFile) @ ".prev.png";

	//Get FOV
	%fov = ClientMode::callback("getMenuCameraFov", 90);
	if (MissionInfo.menuCameraFov !$= "") {
		%fov = MissionInfo.menuCameraFov;
	}

	RootGui.setContent(MiniShotGui);
	Minishotter.forceFOV = %fov;
	Minishotter.resize(0, 0, getWord(getResolution(), 0), getWord(getResolution(), 1));
	Canvas.repaint();
	screenShot(%path, getWord(getResolution(), 0), getWord(getResolution(), 1));
	RootGui.setContent(EditorGui);
}

function EditorMenuBar::onMenuSelect(%this, %menuId, %menu) {
	if (%menu $= "File") {
		EditorMenuBar.setMenuItemEnable("File", "Save Mission...",
		                                EWorldEditor.isDirty);
	} else if (%menu $= "Edit") {
		// enable/disable undo, redo, cut, copy, paste depending on editor settings

		if (EWorldEditor.isVisible()) {
			%selSize = EWorldEditor.getSelectionSize();
			%lockCount = EWorldEditor.getSelectionLockCount();

			// do actions based on world editor...
			EditorMenuBar.setMenuItemEnable("Edit", "Select All", true);
			EditorMenuBar.setMenuItemEnable("Edit", "Paste", EWorldEditor.canPasteSelection());
			%canCutCopy = EWorldEditor.getSelectionSize() > 0;

			EditorMenuBar.setMenuItemEnable("Edit", "Cut", %canCutCopy);
			EditorMenuBar.setMenuItemEnable("Edit", "Copy", %canCutCopy);

			EditorMenuBar.setMenuItemEnable("Edit", "Group Selection", %selSize > 0 && %lockCount == 0);
			EditorMenuBar.setMenuItemEnable("Edit", "Ungroup Selection", %selSize > 0 && %lockCount == 0);

		}
	} else if (%menu $= "World") {
		%selSize = EWorldEditor.getSelectionSize();
		%lockCount = EWorldEditor.getSelectionLockCount();
		%hideCount = EWorldEditor.getSelectionHiddenCount();

		EditorMenuBar.setMenuItemEnable("World", "Lock Selection", %lockCount < %selSize);
		EditorMenuBar.setMenuItemEnable("World", "Unlock Selection", %lockCount > 0);
		EditorMenuBar.setMenuItemEnable("World", "Hide Selection", %hideCount < %selSize);
		EditorMenuBar.setMenuItemEnable("World", "Show Selection", %hideCount > 0);

		EditorMenuBar.setMenuItemEnable("World", "Add Selection to Instant Group", %selSize > 0);
		EditorMenuBar.setMenuItemEnable("World", "Camera To Selection", %selSize > 0);
		EditorMenuBar.setMenuItemEnable("World", "Reset Transforms", %selSize > 0 && %lockCount == 0);
		EditorMenuBar.setMenuItemEnable("World", "Drop Selection", %selSize > 0 && %lockCount == 0);
		EditorMenuBar.setMenuItemEnable("World", "Delete Selection", %selSize > 0 && %lockCount == 0);
	} else if (%menu $= "Special") {
		// the item needs to be only 1 and it needs to be skinable.
		%hasSkins = (EWorldEditor.getSelectionSize() == 1) && (EWorldEditor.getSelectedObject(0).getDatablock().skin[0] !$= "");

		EditorMenuBar.setMenuItemEnable("Special", "Skin Selector", %hasSkins);
	}
}

function EditorMenuBar::onMenuItemSelect(%this, %menuId, %menu, %itemId, %item) {
	switch$ (%menu) {
	case "File":
		%this.onFileMenuItemSelect(%itemId, %item);
	case "Edit":
		%this.onEditMenuItemSelect(%itemId, %item);
	case "World":
		%this.onWorldMenuItemSelect(%itemId, %item);
	case "Window":
		%this.onWindowMenuItemSelect(%itemId, %item);
	case "Create":
		%this.onCreateMenuItemSelect(%itemId, %item);
	case "Special":
		%this.onSpecialMenuItemSelect(%itemId, %item);
	case "Camera":
		%this.onCameraMenuItemSelect(%itemId, %item);
	}
}

function EditorMenuBar::onFileMenuItemSelect(%this, %itemId, %item) {
	switch$ (%item) {
	case "New Mission...":
		EditorNewMission();
	case "Open Mission...":
		EditorOpenMission();
	case "Save Mission...":
		EditorSaveMissionMenu();
	case "Save Mission As...":
		EditorSaveMissionAs();
	case "Reload Current Mission":
		EditorReloadMission(false);
	case "Test Mission":
		EditorReloadMission(true);
	case "Test Camera Path":
		EditorTestCameraPath();
	case "Get Icon Picture":
		EditorIconScreenshot();
	case "Get Preview Picture":
		EditorPreviewScreenshot();
	}
}

function EditorMenuBar::onCameraMenuItemSelect(%this, %itemId, %item) {
	switch$ (%item) {
	case "Drop Camera at Player":
		commandToServer('dropCameraAtPlayer');
	case "Drop Player at Camera":
		commandToServer('DropPlayerAtCamera');
	case "Toggle Camera":
		commandToServer('ToggleCamera');
	case "Focus on Selection":
		EWorldEditor.focusOnSelection();
	default:
		// all the rest are camera speeds:
		// item ids go from 3 (slowest) to 9 (fastest)
		%this.setMenuItemChecked("Camera", %itemId, true);
		// camera movement speed goes from 5 to 200:
		$Camera::movementSpeed = ((%itemId - 3) / 6.0) * 195 + 5;
		ECameraSpeed.setValue($Camera::movementSpeed);
	}
}

function EditorMenuBar::onWorldMenuItemSelect(%this, %itemId, %item) {
	// edit commands for world editor...
	switch$ (%item) {
	case "Lock Selection":
		EWorldEditor.lockSelection(true);
	case "Unlock Selection":
		EWorldEditor.lockSelection(false);
	case "Hide Selection":
		EWorldEditor.hideSelection(true);
	case "Show Selection":
		EWorldEditor.hideSelection(false);
	case "Camera To Selection":
		EWorldEditor.dropCameraToSelection();
	case "Reset Transforms":
		EWorldEditor.resetTransforms();
	case "Drop Selection":
		EWorldEditor.dropSelection();
	case "Delete Selection":
		EWorldEditor.deleteSelection();
	case "Add Selection to Instant Group":
		EWorldEditor.addSelectionToAddGroup();
	default:
		echo("Drop type: " @ %item);
		EditorMenuBar.setMenuItemChecked("World", %item, true);
		EWorldEditor.dropAvg = false;
		switch$ (%item) {
		case "Drop at Origin":
			EWorldEditor.dropType = "atOrigin";
		case "Drop at Camera":
			EWorldEditor.dropType = "atCamera";
		case "Drop at Average Camera":
			EWorldEditor.dropType = "atCamera";
			EWorldEditor.dropAvg = true;
		case "Drop at Camera w/Rot":
			EWorldEditor.dropType = "atCameraRot";
		case "Drop below Camera":
			EWorldEditor.dropType = "belowCamera";
		case "Drop at Screen Center":
			EWorldEditor.dropType = "screenCenter";
		case "Drop to Ground":
			EWorldEditor.dropType = "toGround";
		case "Drop at Centroid":
			EWorldEditor.dropType = "atCentroid";
		}
	}
}

function EditorMenuBar::onEditMenuItemSelect(%this, %itemId, %item) {
	if (%item $= "World Editor Settings...")
		RootGui.pushDialog(WorldEditorSettingsDlg);
	else if (%item $= "Relight Scene")
		lightScene("", forceAlways);
	else if (EWorldEditor.isVisible()) {
		// edit commands for world editor...
		switch$ (%item) {
		case "Undo":
			EWorldEditor.undo();
		case "Redo":
			EWorldEditor.redo();
		case "Copy":
			EWorldEditor.copySelection();
		case "Cut":
			EWorldEditor.copySelection();
			EWorldEditor.deleteSelection();
		case "Paste":
			EWorldEditor.pasteSelection();
			EWorldEditor.onPaste();
		case "Select All":
		case "Select None":
		case "Group Selection":
			EWorldEditor.groupSelection();
		case "Ungroup Selection":
			EWorldEditor.ungroupSelection();
		}
	}
}

function EditorMenuBar::onWindowMenuItemSelect(%this, %itemId, %item) {
	switch$ (%item) {
	case "Particle Editor":
		toggleParticleEditor(1);
	default:
		EditorGui.setEditor(%item);
	}
}

function EditorMenuBar::onCreateMenuItemSelect(%this, %itemId, %item) {
	%obj = -1;
	switch$ (%item) {
	case "Red Gem":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "GemItemRed_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "GemItemRed_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "GemItemRed";
				rotate = 1;
				static = 1;
			};
		}
	case "Yellow Gem":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "GemItemYellow_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "GemItemYellow_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "GemItemYellow";
				rotate = 1;
				static = 1;
			};
		}
	case "Blue Gem":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "GemItemBlue_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "GemItemBlue_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "GemItemBlue";
				rotate = 1;
				static = 1;
			};
		}
	case "Platinum Gem":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "GemItemPlatinum_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "GemItemPlatinum_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "GemItemPlatinum";
				rotate = 1;
				static = 1;
			};
		}
	case "Random Color Gem":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "GemItem_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "GemItemRed_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "GemItem";
				rotate = 1;
				static = 1;
			};
		}
	case "Super Jump":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "SuperJumpItem_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "SuperJumpItem_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "SuperJumpItem";
				rotate = 1;
				static = 1;
			};
		}
	case "Super Speed":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "SuperSpeedItem_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "SuperSpeedItem_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "SuperSpeedItem";
				rotate = 1;
				static = 1;
			};
		}
	case "Super Bounce":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "SuperBounceItem_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "SuperBounceItem_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "SuperBounceItem";
				rotate = 1;
				static = 1;
			};
		}
	case "Time Travel":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "TimeTravelItem_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "TimeTravelItem_MBU";
				rotate = 1;
				static = 1;
			};
		case "Gold":
			%obj = new Item() {
				dataBlock = "TimeTravelItem";
				rotate = 1;
				static = 1;
				skin = "mbg";
			};
		default:
			%obj = new Item() {
				dataBlock = "TimeTravelItem";
				rotate = 1;
				static = 1;
			};
		}
	case "Time Penalty":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "TimePenaltyItem_PQ";
				rotate = 1;
				static = 1;
			};
		case "Gold":
			%obj = new Item() {
				dataBlock = "TimePenaltyItem";
				rotate = 1;
				static = 1;
				skin = "mbgpenalty";
			};
		default:
			%obj = new Item() {
				dataBlock = "TimePenaltyItem";
				rotate = 1;
				static = 1;
				skin = "penalty";
			};
		}
	case "Shock Absorber":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "ShockAbsorberItem_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "ShockAbsorberItem_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "ShockAbsorberItem";
				rotate = 1;
				static = 1;
			};
		}
	case "Gyrocopter":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new Item() {
				dataBlock = "HelicopterItem_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new Item() {
				dataBlock = "HelicopterItem_MBU";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new Item() {
				dataBlock = "HelicopterItem";
				rotate = 1;
				static = 1;
			};
		}
	case "Start Pad":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new StaticShape() {
				dataBlock = "StartPad_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new StaticShape() {
				dataBlock = "StartPad_MBU";
				rotate = 1;
				static = 1;
			};
		case "Gold":
			%obj = new StaticShape() {
				dataBlock = "StartPad_MBG";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new StaticShape() {
				dataBlock = "StartPad";
				rotate = 1;
				static = 1;
			};
		}
	case "End Pad":
		switch$ (MissionInfo.game) {
		case "PlatinumQuest":
			%obj = new StaticShape() {
				dataBlock = "EndPad_PQ";
				rotate = 1;
				static = 1;
			};
		case "Ultra":
			%obj = new StaticShape() {
				dataBlock = "EndPad_MBU";
				rotate = 1;
				static = 1;
			};
		case "Gold":
			%obj = new StaticShape() {
				dataBlock = "EndPad_MBG";
				rotate = 1;
				static = 1;
			};
		default:
			%obj = new StaticShape() {
				dataBlock = "EndPad";
				rotate = 1;
				static = 1;
			};
		}
	case "Spawn Trigger":
		%obj = new Trigger() {
			dataBlock = "SpawnTrigger";
			polyhedron = "0 0 0 1 0 0 0 -1 0 0 0 1";
			center = "1";
		};
	case "Help Text Trigger":
		%obj = new Trigger() {
			dataBlock = "HelpTrigger";
			polyhedron = "0 0 0 1 0 0 0 -1 0 0 0 1";
			center = "1";
			text = "Help Text";
		};
	case "Marble Dummy":
		%obj = new Marble("MarbleDummy") {
			dataBlock = "DefaultMarble";
            Controllable = "0";
            client = "1";
            powerUpData = "0";
			rotate = 1;
			static = 1;
		};
	case "Teleporter":
		%obj = new Item() {
			dataBlock = "TeleportItem";
			rotate = 1;
			static = 1;
		};
	case "Mega Marble":
		%obj = new Item() {
			dataBlock = "MegaMarbleItem";
			rotate = 1;
			static = 1;
		};
	case "Ultra Blast":
		%obj = new Item() {
			dataBlock = "BlastItem";
			rotate = 1;
			static = 1;
		};
	case "Bounds Trigger":
		generateWorldBox();
	case "Gem Group":
		EWorldEditor.makeGemGroup();
	case "Camera Marker":
		EWorldEditor.createCameraMarker();
	case "PathNode at Selection":
		EWorldEditor.createPathNodeAtSelection();
	}
	if (%obj != -1) {
		%obj.setTransform("0 0 0 1 0 0 0");
		$InstantGroup.add(%obj);
		EWorldEditor.clearSelection();
		EWorldEditor.selectObject(%obj);
		EWorldEditor.dropSelection();
	}
}

function EditorMenuBar::onSpecialMenuItemSelect(%this, %itemId, %item) {
	switch$ (%item) {
	case "Make GemGroup":
		EWorldEditor.makeGemGroup();
	case "Destroy GemGroups":
		EWorldEditor.destroyGemGroups();
	case "Show all Gems":
		showGems();
	case "Hide all Gems":
		hideGems();
	case "Spawn GemGroup":
		spawnHuntGemGroup();
	case "Drop at Ground":
		EWorldEditor.dropAtGround();
	case "Round Coordinates":
		EWorldEditor.roundCoords();
	case "Drop + Round":
		EWorldEditor.roundCoords();
		EWorldEditor.dropAtGround();
	case "Random Offset": //:D
		EWorldEditor.malign();
	case "Skin Selector":
		EWorldEditor.skinSelection();
	}
}

function EditorGui::setWorldEditorVisible(%this) {
	EWorldEditor.setVisible(true);
	EWorldEditor.makeFirstResponder(true);
}

function EditorGui::setEditor(%this, %editor) {
	EditorMenuBar.setMenuItemBitmap("Window", %this.currentEditor, -1);
	EditorMenuBar.setMenuItemBitmap("Window", %editor, 0);
	%this.currentEditor = %editor;

	switch$ (%editor) {
	case "World Editor":
		EWFrame.setVisible(false);
		%this.setWorldEditorVisible();
	case "World Editor Inspector":
		EWFrame.setVisible(true);
		EWCreatorPane.setVisible(false);
		EWInspectorPane.setVisible(true);
		EWReplaysPane.setVisible(false);
		%this.setWorldEditorVisible();
	case "World Editor Creator":
		EWFrame.setVisible(true);
		EWCreatorPane.setVisible(true);
		EWInspectorPane.setVisible(false);
		EWReplaysPane.setVisible(false);
		%this.setWorldEditorVisible();
	case "Replay Editor":
		EWFrame.setVisible(true);
		EWCreatorPane.setVisible(false);
		EWInspectorPane.setVisible(false);
		EWReplaysPane.setVisible(true);
		%this.setWorldEditorVisible();
	}
}

function EditorGui::getHelpPage(%this) {
	switch$ (%this.currentEditor) {
	case "World Editor" or "World Editor Inspector" or "World Editor Creator":
		return "5. World Editor";
	}
}


function EWorldEditor::dropSelection(%this) {
	if (%this.dropType $= "toGround")
		%this.dropAtGround();
	else
		Parent::dropSelection(%this);
	if (%this.dropAvg) {
		// Average pos
		%this.roundCoords();
	}
}

function EditorGui::onWake(%this) {
	if ($pref::Input::ControlDevice $= "Joystick") {
		JoystickMap.push();
	} else {
		MoveMap.push();
	}
	EditorMap.push();
	%this.setEditor(%this.currentEditor);

	EMovingObjectsCheck.setValue(true);
	EWorldEditor.enableMovingObjects = true;

	//Wait so the canvas size aligns correctly
	EWorldEditor.schedule(10, buildSpecial);

	setDiscordStatus("In Editor");
}

function EditorGui::onSleep(%this) {
	EditorMap.pop();
	MoveMap.pop();
	JoystickMap.pop();

	activateMovingObjects(true);
	updateGameDiscordStatus();

	if ($EditorTestCamPath) {
		$EditorTestCamPath = false;
		cancel($EditorCamSchedule);
		LocalClientConnection.camera.cancelMoving();
	}
}

function EditorTree::init(%this) {
	%this.open(MissionGroup);
}

function EditorTree::onInspect(%this, %obj) {
	EditorInspector.inspector.inspect(%obj, EWorldEditor.descriptiveFieldNames);
	EditorInspector.object = %obj;
	ECreateSubsBtn.setVisible(%obj.getClassName() $= "InteriorInstance");
	InspectorNameEdit.setValue(%obj.getName());
}

function EditorTree::onSelect(%this, %obj) {
	if (%obj.getName() $= "MissionInfo") {
		emibutton();
		return;
	}

	EWorldEditor.selectObject(%obj);
	EWorldEditor.buildSpecial();
}

function EditorTree::onUnselect(%this, %obj) {
	EWorldEditor.unselectObject(%obj);
	EWorldEditor.buildSpecial();
}

//------------------------------------------------------------------------------
// Functions
//------------------------------------------------------------------------------

function WorldEditor::createSubs(%this) {
	for (%i = 0; %i < %this.getSelectionSize(); %i++) {
		%obj = %this.getSelectedObject(%i);
		if (%obj.getClassName() $= "InteriorInstance")
			%obj.magicButton();
	}
}

function WorldEditor::init(%this) {
	// add objclasses which we do not want to collide with
	%this.ignoreObjClass(Sky);

	// editing modes
	%this.numEditModes = 3;
	%this.editMode[0]    = "move";
	%this.editMode[1]    = "rotate";
	%this.editMode[2]    = "scale";

	// context menu
	new GuiControl(WEContextPopupDlg) {
		profile = "GuiModelessDialogProfile";
		horizSizing = "width";
		vertSizing = "height";
		position = "0 0";
		extent = "640 480";
		minExtent = "8 8";
		visible = "1";
		setFirstResponder = "0";
		modal = "1";

		new GuiPopUpMenuCtrl(WEContextPopup) {
			profile = "GuiScrollProfile";
			position = "0 0";
			extent = "0 0";
			minExtent = "0 0";
			maxPopupHeight = "200";
			command = "RootGui.popDialog(WEContextPopupDlg);";
		};
	};
	WEContextPopup.setVisible(false);
}

//------------------------------------------------------------------------------

function WorldEditor::onDblClick(%this, %obj) {
	// Commented out because making someone double click to do this is stupid
	// and has the possibility of moving hte object

	//Inspector.inspect(%obj);
	//InspectorNameEdit.setValue(%obj.getName());
}

function WorldEditor::onClick(%this, %obj) {
	EditorInspector.inspector.inspect(%obj, EWorldEditor.descriptiveFieldNames);
	EditorInspector.object = %obj;
	ECreateSubsBtn.setVisible(%obj.getClassName() $= "InteriorInstance");
	InspectorNameEdit.setValue(%obj.getName());
	EWorldEditor.buildSpecial();

	%this.checkDeselect();
}

function onEditorDrag() {
	for (%i = 0; %i < EWorldEditor.getSelectionSize(); %i ++) {
		%obj = EWorldEditor.getSelectedObject(%i);

		//Do something with it
		%obj.onEditorDrag();
	}
}

function SimObject::onEditorDrag(%this) {
	//Stub
}

function WorldEditor::checkDeselect(%this) {
	cancel(%this.deselectSch);
	%this.deselectSch = %this.schedule(100, checkDeselect);

	%size = %this.getSelectionSize();
	if (%size !$= %this.lastSize) {
		if (%size == 0) {
			%this.onUnselectAll();
		}
		%this.lastSize = %size;
	}
}

function EWorldEditor::onUnselectAll(%this) {
	%this.buildSpecial();
}

function EWorldEditor::onPaste(%this) {
	//Select the pasted object if we have one
	if (%this.getSelectionSize() > 0) {
		EditorInspector.inspector.inspect(%this.getSelectedObject(0));
	}
	for (%i = 0; %i < %this.getSelectionSize(); %i ++) {
		%obj = %this.getSelectedObject(%i);

		//Clean up the old particles, if it had any
		for (%j = 0; isObject(%obj._fx[%j]); %j ++) {
			%obj._fx[%j] = "";
		}
		if (%obj._isFx) {
			//Don't copy+paste fx objects
			%obj.delete();
			%i --;
		}
	}
}

//------------------------------------------------------------------------------

function WorldEditor::export(%this) {
	getSaveFilename("~/editor/*.mac", %this @ ".doExport", "selection.mac");
}

function WorldEditor::doExport(%this, %file) {
	missionGroup.save("~/editor/" @ %file, true);
}

function WorldEditor::import(%this) {
	getLoadFilename("~/editor/*.mac", %this @ ".doImport");
}

function WorldEditor::doImport(%this, %file) {
	exec("~/editor/" @ %file);
}

function WorldEditor::onGuiUpdate(%this, %text) {

}

function WorldEditor::getSelectionLockCount(%this) {
	%ret = 0;
	for (%i = 0; %i < %this.getSelectionSize(); %i++) {
		%obj = %this.getSelectedObject(%i);
		if (%obj.locked $= "true")
			%ret++;
	}
	return %ret;
}

function WorldEditor::getSelectionHiddenCount(%this) {
	%ret = 0;
	for (%i = 0; %i < %this.getSelectionSize(); %i++) {
		%obj = %this.getSelectedObject(%i);
		if (%obj.hidden $= "true")
			%ret++;
	}
	return %ret;
}

function WorldEditor::dropCameraToSelection(%this) {
	if (%this.getSelectionSize() == 0)
		return;

	%pos = %this.getSelectionCentroid();
	%cam = ServerConnection.getControlObject().getTransform();

	// set the pnt
	%cam = setWord(%cam, 0, getWord(%pos, 0));
	%cam = setWord(%cam, 1, getWord(%pos, 1));
	%cam = setWord(%cam, 2, getWord(%pos, 2));

	ServerConnection.getControlObject().setTransform(%cam);
}

// * pastes the selection at the same place (used to move obj from a group to another)
function WorldEditor::moveSelectionInPlace(%this) {
	%saveDropType = %this.dropType;
	%this.dropType = "atCentroid";
	%this.copySelection();
	%this.deleteSelection();
	%this.pasteSelection();
	%this.dropType = %saveDropType;
}

function WorldEditor::addSelectionToAddGroup(%this) {
	for (%i = 0; %i < %this.getSelectionSize(); %i++) {
		%obj = %this.getSelectedObject(%i);
		$InstantGroup.add(%obj);
	}

}
// resets the scale and rotation on the selection set
function WorldEditor::resetTransforms(%this) {
	%this.addUndoState();

	for (%i = 0; %i < %this.getSelectionSize(); %i++) {
		%obj = %this.getSelectedObject(%i);
		%transform = %obj.getTransform();

		%transform = setWord(%transform, 3, "0");
		%transform = setWord(%transform, 4, "0");
		%transform = setWord(%transform, 5, "1");
		%transform = setWord(%transform, 6, "0");

		//
		%obj.setTransform(%transform);
		%obj.setScale("1 1 1");
	}
}


function WorldEditorToolbarDlg::init(%this) {
	WorldEditorInspectorCheckBox.setValue(WorldEditorToolFrameSet.isMember("EditorToolInspectorGui"));
	WorldEditorMissionAreaCheckBox.setValue(WorldEditorToolFrameSet.isMember("EditorToolMissionAreaGui"));
	WorldEditorTreeCheckBox.setValue(WorldEditorToolFrameSet.isMember("EditorToolTreeViewGui"));
	WorldEditorCreatorCheckBox.setValue(WorldEditorToolFrameSet.isMember("EditorToolCreatorGui"));
}

function Creator::init(%this) {
	%this.clear();

	$InstantGroup = "MissionGroup";

	%groups = Array("TreeNode");

	// ---------- INTERIORS
	%base = Array("TreeNode");
	%base.name = "Interiors";
	%groups.addEntry(%base);

	// walk all the interiors and add them to the correct group
	%interiorObj = "";
	%file = findFirstFile("*.dif");

	while (%file !$= "") {
		// Determine which group to put the file in
		// and build the group heirarchy as we go
		%split     = strreplace(%file, "/", "\t");
		%dirCount  = getFieldCount(%split)-1;
		%parentObj = %base;

		for (%i = 0; %i < %dirCount; %i ++) {
			%parent = getFields(%split, 0, %i);
			// if the group doesn't exist create it
			if (!%interiorObj[%parent]) {
				%interiorObj[%parent] = Array("TreeNode");
				%interiorObj[%parent].name = getField(%split, %i);
				%parentObj.addEntry(%interiorObj[%parent]);
			}
			%parentObj = %interiorObj[%parent];
		}
		// Add the file to the group
		%create = "interior" TAB %file;
		%parentObj.addEntry(fileBase(%file) TAB %create);

		%file = findNextFile("*.dif");
	}
	recurseSort(%base, sortNameOrArray);

	// ---------- SHAPES - add in all the shapes now...
	%base = Array("TreeNode");
	%base.name = "Shapes";
	%groups.addEntry(%base);
	%dataGroup = "DataBlockGroup";

	for (%i = 0; %i < %dataGroup.getCount(); %i++) {
		%obj = %dataGroup.getObject(%i);
		//echo("Obj: " @ %obj.getName() @ " - " @ %obj.category);
		if (%obj.superCategory !$= "") {
			%superGrp = Array("TreeNode");
			%superGrp.name = %obj.superCategory;
			%base.addEntry(%superGrp);

			%grp = Array("TreeNode");
			%grp.name = %obj.category;
			%superGrp.addEntry(%grp);

			%grp.addEntry(%obj.getName() TAB "create" TAB %obj.getClassName() TAB %obj.getName());
		} else if (%obj.category !$= "" || %obj.category != 0) {
			%grp = Array("TreeNode");
			%grp.name = %obj.category;
			%base.addEntry(%grp);

			%grp.addEntry(%obj.getName() TAB "create" TAB %obj.getClassName() TAB %obj.getName());
		}
	}
	recurseSort(%base, sortNameOrArray);

	// ---------- Static Shapes
	%base = Array("TreeNode");
	%base.name = "Static Shapes";
	%groups.addEntry(%base);

	// walk all the statics and add them to the correct group
	%staticId = "";
	%file = findFirstFile("*.dts");
	while (%file !$= "") {
		// Determine which group to put the file in
		// and build the group heirarchy as we go
		%split     = strreplace(%file, "/", "\t");
		%dirCount  = getFieldCount(%split)-1;
		%parentObj = %base;

		for (%i = 0; %i < %dirCount; %i ++) {
			%parent = getFields(%split, 0, %i);
			// if the group doesn't exist create it
			if (!%staticObj[%parent]) {
				%staticObj[%parent] = Array("TreeNode");
				%staticObj[%parent].name = getField(%split, %i);
				%parentObj.addEntry(%staticObj[%parent]);
			}
			%parentObj = %staticObj[%parent];
		}
		// Add the file to the group
		%create = "TSStatic" TAB %file;
		%parentObj.addEntry(fileBase(%file) TAB %create);

		%file = findNextFile("*.dts");
	}

	recurseSort(%base, sortNameOrArray);

	// *** OBJECTS - do the objects now...
	// Mission/Environment only got 1 code each remaining in them so we'll show those.
	// See below to see which code we left in each bit.
	%objGroup[0] = "Environment";
	%objGroup[1] = "Mission";
	%objGroup[2] = "System";
	//%objGroup[3] = "AI";

//   %Environment_Item[0] = "Sky";
//   %Environment_Item[1] = "Sun";
//   %Environment_Item[2] = "Lightning";
//   %Environment_Item[3] = "Water";
//   %Environment_Item[4] = "Terrain";
//   %Environment_Item[5] = "AudioEmitter";
//   %Environment_Item[6] = "Precipitation";
// We don't use the above anymore, so the one below does not need to be in that order anymore.
//   %Environment_Item[7] = "ParticleEmitter";
	%Environment_Item[0] = "Sky";
	%Environment_Item[1] = "Sun";
	%Environment_Item[2] = "AudioEmitter";
	%Environment_Item[3] = "ParticleEmitter";

//   %Mission_Item[0] = "MissionArea";
//   %Mission_Item[1] = "Marker";
// We don't use the above anymore, so the one below does not need to be in that order anymore.
//   %Mission_Item[2] = "Trigger";
//   %Mission_Item[3] = "PhysicalZone";
//   %Mission_Item[4] = "Camera";
	//%Mission_Item[5] = "GameType";
	//%Mission_Item[6] = "Forcefield";
	%Mission_Item[0] = "MissionArea";
	%Mission_Item[1] = "Marker";
	%Mission_Item[2] = "Trigger";
	%Mission_Item[3] = "Camera";

	%System_Item[0] = "SimGroup";

	//%AI_Item[0] = "Objective";
	//%AI_Item[1] = "NavigationGraph";

	// objects group
	%base = Array("TreeNode");
	%base.name = "Mission Objects";
	%groups.addEntry(%base);

	// create 'em
	for (%i = 0; %objGroup[%i] !$= ""; %i++) {
		%grp = Array("TreeNode");
		%grp.name = %objGroup[%i];
		%base.addEntry(%grp);

		%groupTag = "%" @ %objGroup[%i] @ "_Item";

		%done = false;
		for (%j = 0; !%done; %j++) {
			eval("%itemTag = " @ %groupTag @ %j @ ";");
			if (%itemTag $= "")
				%done = true;
			else
				%grp.addEntry(%itemTag TAB "build" TAB %itemTag);
		}
	}

	%this.recurseInsert(%groups, 0);

	//Clean up
	%groups.recurseDelete();
}

function Creator::recurseInsert(%this, %array, %parentId) {
	%count = %array.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %array.getEntry(%i);
		if (isObject(%obj) && (%obj.class $= "Array")) {
			%groupId = %this.addGroup(%parentId, %obj.name);
			%this.recurseInsert(%obj, %groupId);
		} else {
			%this.addItem(%parentId, getField(%obj, 0), getFields(%obj, 1));
		}
	}
}

function createInterior(%name) {
	%obj = new InteriorInstance() {
		position = "0 0 0";
		rotation = "0 0 0";
		interiorFile = %name;
	};

	return (%obj);
}

function Creator::onAction(%this) {
//   %this.currentSel = -1;
//   %this.currentRoot = -1;
//   %this.currentObj = -1;

	%sel = %this.getSelected();
	if (%sel == -1 || %this.isGroup(%sel))
		return;

	// the value is the callback function..
	if (%this.getValue(%sel) $= "")
		return;

//   %this.currentSel = %sel;
//   %this.currentRoot = %this.getRootGroup(%sel);

	%val = %this.getValue(%sel);

	%action = getField(%val, 0);
	%rest = getFields(%val, 1, getFieldCount(%val));

	commandToServer('Create', %action, %rest);
}

function Creator::create(%this, %obj) {
	if (%obj == -1 || %obj == 0)
		return;

//   %this.currentObj = %obj;

	$InstantGroup.add(%obj);

	// drop it from the editor - only SceneObjects can be selected...
	EWorldEditor.clearSelection();
	EWorldEditor.selectObject(%obj);
	EWorldEditor.dropSelection();
}

function serverCmdCreate(%client, %type, %value) {
	switch$ (%type) {
	case "interior":
		%obj = createInterior(%value);
	case "create":
		%data = (getField(%value, 1));
		//("GemItemRed")::create("GemItemRed");
		echo("(nameToId(\"" @ expandEscape(%data) @ "\")).create(\"" @ expandEscape(getField(%value, 1)) @ "\");");
		%obj = eval("(nameToId(\"" @ expandEscape(%data) @ "\")).create(\"" @ expandEscape(getField(%value, 1)) @ "\");");
	case "TSStatic":
		%obj = TSStatic::create(%value);
	case "build":
		ObjectBuilderGui.call("build" @ %value);
	}

	if (%client.isHost()) {
		%obj.setTransform(MatrixMultiply(getWords(%obj.getTransform(), 0, 2) SPC %client.gravityRot, "0 0 0 1 0 0 3.14159"));
		EWorldEditor.clearSelection();
		EWorldEditor.selectObject(%obj);
		if (EWorldEditor.dropType $= "toGround") {
			EWorldEditor.dropType = "atCamera";
			EWorldEditor.dropSelection();
			EWorldEditor.dropType = "toGround";
		}
		EWorldEditor.dropSelection();
		EWorldEditor.buildSpecial();
	} else {
//      echo("Client" SPC %client.getUsername() SPC "creating an object!");
		%client.createItem = %obj;
		%obj.position = %client.player.getEstCameraTransform();
		MissionGroup.add(%obj);
		commandToClient(%client, 'Create', %obj.getSyncId());
	}
}

function clientCmdCreate(%syncId, %tries) {
	if (%tries > 20) {
		MessageBoxOk("Could not create!", "There was an error creating the object!");
		return;
	}

	//Find it
	%obj = getClientSyncObject(%syncId);

	if (isObject(%obj)) {
		EditorInspector.inspector.inspect(%obj);
		EditorInspector.object = %obj;
	} else {
		schedule(100, 0, clientCmdCreate, %syncId, %tries + 1);
	}
}

function serverCmdCreateItemUpdate(%client, %field, %value) {
	%obj = %client.createItem;
	if (!isObject(%obj))
		return;

//   echo("Client is setting obj" SPC %obj SPC %field SPC "to" SPC %value);

	eval(%obj @ "." @ alphaNum(%field) @ " = \"" @ expandEscape(%value) @ "\";");
}

function TSStatic::create(%shapeName) {
	%obj = new TSStatic() {
		shapeName = %shapeName;
	};
	return (%obj);
}

function TSStatic::damage(%this) {
	// prevent console error spam
}

//--------------------------------------
function strip(%stripStr, %strToStrip) {
	%len = strlen(%stripStr);
	if (strcmp(getSubStr(%strToStrip, 0, %len), %stripStr) == 0)
		return getSubStr(%strToStrip, %len, 100000);
	return %strToStrip;
}

function getPrefSetting(%pref, %default) {
	//
	if (%pref $= "")
		return (%default);
	else
		return (%pref);
}

//------------------------------------------------------------------------------

function Editor::open(%this) {
	// Load Prefs
	EditorGui.getPrefs();

	%this.prevContent = RootGui.getContent();
	RootGui.setContent(EditorGui);

	$Editor::Opened = true;
	commandToAll('GameStatus', $Editor::Opened);

	ClientMode::callback("onEditorOpened");
	Mode::callback("onEditorOpened");
}

function Editor::close(%this) {
	// Save prefs
	EditorGui.setPrefs();

	if (%this.prevContent == -1 || %this.prevContent $= "")
		%this.prevContent = "PlayGui";

	RootGui.setContent(%this.prevContent);

	MessageHud.close();

	ClientMode::callback("onEditorClosed");
	Mode::callback("onEditorClosed");
}

//------------------------------------------------------------------------------

// From now on, if your moving platform's PathedInterior does not have default position/rotation/scale values, their basePosition/Rotation/Scale equivalent(s) will automatically get set

// This function will do the above. It allows the user to alter a moving platform in the editor, and have the changes actually be reflected in gameplay
function updatePathedInteriorBaseTransforms() {
	// We will find all of the MustChange groups (they should contain PathedInteriors)
	for (%i = 0; %i < MissionGroup.getCount(); %i++) {
		%obj = MissionGroup.getObject(%i); // Get the next object from MissionGroup
		if (%obj.getName() $= "MustChange_g") { // Follow
			// Now we'll search for a PathedInterior inside here
			%count = %obj.getCount(); // Just so we can reuse %obj
			for (%j = 0; %j < %count; %j++) {
				%obk = %obj.getObject(%j); // Get the next object from the current MustChange group
				if (%obk.getClassName() $= "PathedInterior") { // Check if it's a PathedInterior
					if (%obk.position !$= "0 0 0")
						%obk.basePosition = %obk.position;
					if (%obk.rotation !$= "1 0 0 0")
						%obk.baseRotation = %obk.rotation;
					if (%obk.scale !$= "1 1 1")
						%obk.baseScale = %obk.scale;
				}
			}
		}
	}
}

//------------------------------------------------------------------------------

function generateWorldBox() {
	$InstantGroup = MissionCleanup;
	%box = MissionGroup.getWorldBox();
	%box = VectorSub(BoxMin(%box), "15 15 5") SPC VectorAdd(BoxMax(%box), "15 15 50");
	$InstantGroup = MissionGroup;

	new Trigger(Bounds) {
		position = "0 0 0";
		scale = "1 1 1";
		rotation = "1 0 0 0";
		dataBlock = "InBoundsTrigger";
		polyhedron = "0.0000000 0.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 1.0000000";
	};
	Bounds.setBounds(%box);
	MissionGroup.add(Bounds);
}

function EWorldEditor::makeGemGroup(%this) {
	if (!isObject(GemGroups))
		MissionGroup.add(new SimGroup(GemGroups));
	GemGroups.add(%group = new SimGroup("GemGroup" @ GemGroups.getCount()));
	for (%i = 0; %i < %this.getSelectionSize(); %i ++) {
		%obj = %this.getSelectedObject(%i);
		if (%obj.getClassName() $= "Item" && %obj.getDataBlock().className $= "Gem")
			%group.add(%obj);
	}
	//Set this, but give them the choice
	if (MissionInfo.gemGroups $= "") {
		MessageBoxYesNo("Spawn Whole Groups", "Select yes to spawn entire gem groups with each spawn. Select no to spawn gems randomly from one of the groups.", "MissionInfo.gemGroups = 1;", "MissionInfo.gemGroups = 2;");
	}
}

function EWorldEditor::destroyGemGroups(%this) {
	if (%this.getSelectionSize()) {
		for (%i = 0; %i < %this.getSelectionSize(); %i ++) {
			%obj = %this.getSelectedObject(%i);
			if (%obj.getGroup().getName() $= "GemGroups") {
				while (%obj.getCount())
					MissionGroup.add(%obj.getObject(0));
				%obj.delete();
			}
		}
	} else if (isObject(GemGroups)) {
		for (%i = 0; %i < GemGroups.getCount(); %i ++) {
			%obj = GemGroups.getObject(%i);
			while (%obj.getCount())
				MissionGroup.add(%obj.getObject(0));
			%obj.delete();
		}
		GemGroups.delete();
	}
}

function EWorldEditor::createCameraMarker(%this) {
	if (!isObject(PathNodeGroup))
		MissionGroup.add(new SimGroup(PathNodeGroup));

	%id = 1;
	while (isObject("CameraPath" @ %id)) {
		%id ++;
	}

	%obj = new StaticShape("CameraPath" @ %id) {
		position = "0 0 0";
		rotation = "1 0 0 0";
		scale = "1 1 1";
		timeToNext = "3000";
		placed = "1";
		reverseRotation = "0";
		usePosition = "1";
		useRotation = "1";
		useScale = "0";
		nextNode = "CameraPath1";
		datablock = "PathNode";
	};

	%obj.setTransform(getCamera().getTransform());
	PathNodeGroup.add(%obj);

	nameToId("CameraPath" @(%id - 1)).nextNode = %obj.getName();
}

function EWorldEditor::createPathNodeAtSelection(%this) {
	for (%i = 0; %i < %this.getSelectionSize(); %i++) {
		%iobj = %this.getSelectedObject(%i);
		%obj = new StaticShape() {
			position = %iobj.position;
			rotation = %iobj.rotation;
			scale = %iobj.scale;
			timeToNext = "3000";
			placed = "1";
			reverseRotation = "0";
			usePosition = "1";
			useRotation = "1";
			useScale = "1";
			datablock = "PathNode";
		};

		%obj.setTransform(%iobj.getTransform());
		%obj.setScale(%iobj.getScale());
		%obj.forceNetUpdate();
		PathNodeGroup.add(%obj);
	}

	%this.clearSelection();
	%this.selectObject(%obj);
}

//-----------------------------------------------------------------------------

function EWorldEditor::dropAtGround(%this) {
	%local = true;
	%count = %this.getSelectionSize();
	EWorldEditor.addUndoState();

	for (%i = 0; %i < %count; %i++) {
		%obj = %this.getSelectedObject(%i);
		%db = %obj.getDatablock();
		%drop = 0;
		if (%obj.getClassName() !$= "Trigger") { //todo: account for things that don't use datablocks
			%trans = %obj.getTransform();
			%obj.setTransform("0 0 0 1 0 0 0");
			%drop = getWord(%obj.position, 2) - BoxMinZ(%obj.getWorldBox());
			%obj.setTransform(%trans);
		}

		if (%local)
			%uvec = rottoVector(%obj.getRotation(), "0 0 -1");
		else
			%uvec = "0 0 -1";

		%vec = vectorScale(%uvec, 5); //only drop down if we detect interior within 5 unit range

		%pos = %obj.getPosition();
		%hit = ContainerRayCast(vectorSub(%pos, vectorScale(%vec, 0.2)), vectoradd(%pos, %vec), $TypeMasks::InteriorObjectType | $TypeMasks::StaticShapeObjectType, %obj);

		if (%hit) {
			%pos = vectorAdd(getWords(%hit, 1, 3), vectorScale(%uvec, (-1 * %drop)));
			%obj.setTransform(%pos SPC getWords(%obj.getTransform(), 3, 6));
		}
	}
}

function EWorldEditor::rotateBy(%this, %rotation) {
	%rotation = setWord(%rotation, 3, mDegToRad(getWord(%rotation, 3)));
	%count = %this.getSelectionSize();

	for (%i = 0; %i < %count; %i++) {
		%obj = %this.getSelectedObject(%i);

		%trans = %obj.getTransform();
		%obj.setTransform(getWords(%trans, 0, 2) SPC getWords(MatrixMultiply("0 0 0" SPC getWords(%trans, 3, 6), "0 0 0" SPC %rotation), 3, 6));
	}
}

function EWorldEditor::roundCoords(%this) {
	if (%this.getSelectionSize()) {
		EWorldEditor.addUndoState();
		for (%i = 0; %i < %this.getSelectionSize(); %i ++) {
			%obj = %this.getSelectedObject(%i);
			%pos = %obj.position;
			%pos = mRound(getWord(%pos, 0) / %this.mouseMoveScale) * %this.mouseMoveScale SPC mRound(getWord(%pos, 1) / %this.mouseMoveScale) * %this.mouseMoveScale SPC mRound(getWord(%pos, 2) / %this.mouseMoveScale) * %this.mouseMoveScale;
			%obj.setTransform(%pos SPC getWords(%obj.getTransform(), 3, 6));
		}
	}
}

function EWorldEditor::malign(%this) {
	if (%this.getSelectionSize()) {
		EWorldEditor.addUndoState();
		for (%i = 0; %i < %this.getSelectionSize(); %i ++) {
			%obj = %this.getSelectedObject(%i);
			%pos = %obj.position;
			%pos = getWord(%pos, 0)+(-0.5+getRandom()) SPC getWord(%pos, 1)+(-0.5+getRandom()) / 2 SPC getWord(%pos, 2)+(-0.5+getRandom());
			%obj.setTransform(%pos SPC getWords(%obj.getTransform(), 3, 6));
		}
	}
}

function EWorldEditor::skinSelection(%this) {
	showSkinSelectionDlg(%this.getSelectedObject(0));
}

function EWorldEditor::applySkin(%this, %skin) {
	if (%this.getSelectionSize()) {
		for (%i = 0; %i < %this.getSelectionSize(); %i ++) {
			%obj = %this.getSelectedObject(%i);
			%obj.inspectPreApply();

			%obj.skin = %skin;
			%obj.setSkinName(%skin);

			%obj.inspectPostApply();
			%obj.onInspectApply();
		}
		EditorInspector.inspector.inspect(EditorInspector.object);
		EWorldEditor.isDirty = true;
	}
}

function EWorldEditor::groupSelection(%this) {
	if (%this.getSelectionSize()) {
		$InstantGroup.add(%group = new SimGroup());
		for (%i = 0; %i < %this.getSelectionSize(); %i ++) {
			%obj = %this.getSelectedObject(%i);
			%group.add(%obj);
		}
	}
}

function EWorldEditor::ungroupSelection(%this) {
	if (%this.getSelectionSize()) {
		for (%i = 0; %i < %this.getSelectionSize(); %i ++) {
			%obj = %this.getSelectedObject(%i);
			$InstantGroup.add(%obj);
		}
	}
}

//-----------------------------------------------------------------------------

function EWorldEditor::checkChat(%this, %client, %message) {
	switch$ (%message) {
	case "/v1":
		%obj = new Item() {
			dataBlock = "GemItemRed";
			rotate = 1;
			static = 1;
		};
	case "/v2":
		%obj = new Item() {
			dataBlock = "GemItemYellow";
			rotate = 1;
			static = 1;
		};
	case "/v3":
		%obj = new Item() {
			dataBlock = "GemItemBlue";
			rotate = 1;
			static = 1;
		};
	case "/v4":
		%obj = new Trigger() {
			dataBlock = "SpawnTrigger";
			polyhedron = "0 0 0 1 0 0 0 -1 0 0 0 1";
			center = "1";
		};
	case "/v5":
		%obj = new Item() {
			dataBlock = "SuperJumpItem";
			rotate = 1;
			static = 1;
		};
	case "/v6":
		%obj = new Item() {
			dataBlock = "SuperSpeedItem";
			rotate = 1;
			static = 1;
		};
	case "/v7":
		%obj = new Item() {
			dataBlock = "HelicopterItem";
			rotate = 1;
			static = 1;
		};
	case "/v8":
		%obj = new Item() {
			dataBlock = "MegaMarbleItem";
			rotate = 1;
			static = 1;
		};
	case "/v9":
		%obj = new Item() {
			dataBlock = "BlastItem";
			rotate = 1;
			static = 1;
		};
	case "/v10":
		//Find nearest obj and delete it
		InitContainerRadiusSearch(%client.player.position, 1, $TypeMasks::ItemObjectType);
		if ((%obj = ContainerSearchNext()) == -1)
			return true;
		%obj.delete();
		return true;
	case "/v11":
		//Find nearest obj and move it
		InitContainerRadiusSearch(%client.player.position, 1, $TypeMasks::ItemObjectType);
		if ((%obj = ContainerSearchNext()) == -1)
			return true;
	}
	if (!isObject(%obj))
		return false;
	%mat = "0 0 0" SPC rotationFromOrtho($Game::GravityDir);
	%mat = MatrixMultiply(%mat, "0 0 0 1 0 0 3.1415926");
	%map = MatrixMultiply(%mat, getWords(%obj.getTransform(), 0, 2));
	%obj.setTransform(%mat);
	%rot = getWords(%obj.getTransform(), 3, 6);
	echo(%rot);
	MissionGroup.add(%obj);
	%pos = %client.player.getWorldBoxCenter();

//	echo("Center is" SPC %pos);

//	if (getGravityDir() $= "0 0 -1") {
	%pos = VectorScale(%pos, 1 / %this.mouseMoveScale);

	//	echo("Scaled is" SPC %pos);

	%pos = VectorRound(%pos, 0);

	//	echo("Rounded is" SPC %pos);

	%pos = VectorScale(%pos, %this.mouseMoveScale);

	//	echo("Unscaled is" SPC %pos);

//	}

	echo(%pos TAB %rot);

	%obj.setTransform(%pos SPC %rot);
	%this.clearSelection();
	%this.selectObject(%obj);
	%this.dropAtGround();

	return true;
}

//-----------------------------------------------------------------------------

$Editor::ExpandExtent = 200;

function editorExpand() {
	%val = EditorExpandInspector.getValue();
	%pos = EWFrame.getPosition();
	%ext = EWFrame.getExtent();
	%h = getWord(%ext, 1);
	%y = getWord(%pos, 1);
	if (%val) {
		%x = getWord(%pos, 0) - $Editor::ExpandExtent;
		%w = getWord(%ext, 0) + $Editor::ExpandExtent;
	} else {
		%x = getWord(%pos, 0) + $Editor::ExpandExtent;
		%w = getWord(%ext, 0) - $Editor::ExpandExtent;
	}
	EWFrame.resize(%x, %y, %w, %h);
	EWSpecialBox.setWidth(getWord(Canvas.getExtent(), 0) - %w);
}

function EWorldEditor::toggleMovingObjects(%this) {
	EWorldEditor.enableMovingObjects = !EWorldEditor.enableMovingObjects;
	activateMovingObjects(EWorldEditor.enableMovingObjects);

	EMovingObjectsCheck.setValue(EWorldEditor.enableMovingObjects);
}

//------------------------------------------------------------------------------

function EWActiveReplayList::init(%this) {
	%this.clear();
	for (%i = 0; %i < MissionInfo.replays; %i ++) {
		%this.addReplay(%i, MissionInfo.replay[%i], MissionInfo.replayStart[%i]);
	}
}

function EWActiveReplayList::addReplay(%this, %index, %file, %time) {
	%this.setHeight((%index + 1) * 40);
	%this.add(new GuiControl("EWReplayBox" @ %index) {
		profile = "GuiDefaultProfile";
		horizSizing = "right";
		vertSizing = "bottom";
		position = "0" SPC(40 * %index);
		extent = "234 40";
		minExtent = "8 8";
		visible = "1";
		helpTag = "0";

		new GuiTextEditCtrl("EWReplayEdit" @ %index) {
			profile = (isFile(%file) ? GuiTextEditProfile : GuiTextEditDangerProfile);
			horizSizing = "right";
			vertSizing = "bottom";
			position = "1 1";
			extent = "160 18";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
			text = %file;
			maxLength = "255";
			maxPixelWidth = "0";
			command = "EWActiveReplayList.editReplay(" @ %index @ ");";
			altCommand = "EWActiveReplayList.updateReplay(" @ %index @ ");";
			escapeCommand = "EWActiveReplayList.cancelEditReplay(" @ %index @ ");";
			historySize = "0";
			password = "0";
			tabComplete = "0";
			sinkAllKeyEvents = "0";
		};
		new GuiButtonCtrl() {
			profile = "GuiButtonProfile";
			horizSizing = "left";
			vertSizing = "bottom";
			position = "164 0";
			extent = "38 20";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
			text = "Select";
			command = "EWActiveReplayList.selectReplay(" @ %index @ ");";
			groupNum = "-1";
			buttonType = "PushButton";
			repeatPeriod = "1000";
			repeatDecay = "1";
		};
		new GuiButtonCtrl() {
			profile = "GuiButtonProfile";
			horizSizing = "left";
			vertSizing = "bottom";
			position = "204 0";
			extent = "30 20";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
			text = "-";
			command = "EWActiveReplayList.deleteReplay(" @ %index @ ");";
			groupNum = "-1";
			buttonType = "PushButton";
			repeatPeriod = "1000";
			repeatDecay = "1";
		};
		new GuiTextCtrl() {
			profile = "GuiTextProfile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "3 23";
			extent = "70 18";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
			text = "Start Time:";
			maxLength = "255";
		};
		new GuiTextEditCtrl("EWReplayTime" @ %index) {
			profile = GuiTextEditProfile;
			horizSizing = "right";
			vertSizing = "bottom";
			position = "72 21";
			extent = "160 18";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
			text = %time;
			maxLength = "255";
			maxPixelWidth = "0";
			command = "EWActiveReplayList.editReplayTime(" @ %index @ ");";
			altCommand = "EWActiveReplayList.updateReplayTime(" @ %index @ ");";
			escapeCommand = "EWActiveReplayList.cancelEditReplayTime(" @ %index @ ");";
			historySize = "0";
			password = "0";
			tabComplete = "0";
			sinkAllKeyEvents = "0";
		};
	});
	("EWReplayEdit" @ %index).makeFirstResponder(false);
}

function EWActiveReplayList::editReplay(%this, %index) {
	("EWReplayEdit" @ %index).setProfile(GuiTextEditWarnProfile);
}
function EWActiveReplayList::cancelEditReplay(%this, %index) {
	("EWReplayEdit" @ %index).setValue(MissionInfo.replay[%index]);
	("EWReplayEdit" @ %index).setProfile(GuiTextEditProfile);
	("EWReplayEdit" @ %index).makeFirstResponder(false);
}
function EWActiveReplayList::updateReplay(%this, %index) {
	%replayValue = ("EWReplayEdit" @ %index).getValue();
	if (isFile(%replayValue)) {
		MissionInfo.replay[%index] = %replayValue;
		("EWReplayEdit" @ %index).setProfile(GuiTextEditSuccessProfile);
		("EWReplayEdit" @ %index).makeFirstResponder(false);
		("EWReplayEdit" @ %index).schedule(2000, setProfile, GuiTextEditProfile);
		EWorldEditor.isDirty = true;
	} else {
		("EWReplayEdit" @ %index).setProfile(GuiTextEditDangerProfile);
	}
}
function EWActiveReplayList::editReplayTime(%this, %index) {
	("EWReplayTime" @ %index).setProfile(GuiTextEditWarnProfile);
}
function EWActiveReplayList::cancelEditReplayTime(%this, %index) {
	("EWReplayTime" @ %index).setValue(MissionInfo.replayTime[%index]);
	("EWReplayTime" @ %index).setProfile(GuiTextEditProfile);
	("EWReplayTime" @ %index).makeFirstResponder(false);
}
function EWActiveReplayList::updateReplayTime(%this, %index) {
	%timeValue = ("EWReplayTime" @ %index).getValue();
	MissionInfo.replayTime[%index] = %timeValue;
	("EWReplayTime" @ %index).setProfile(GuiTextEditSuccessProfile);
	("EWReplayTime" @ %index).makeFirstResponder(false);
	("EWReplayTime" @ %index).schedule(2000, setProfile, GuiTextEditProfile);
	EWorldEditor.isDirty = true;
}
function EWActiveReplayList::selectReplay(%this, %index) {
	%this.selectReplay = %index;
	getLoadFilename("*.rrec", "EWSelectReplay");
}
function EWSelectReplay(%replay) {
	MissionInfo.replay[%index] = %replay;
	("EWReplayEdit" @ %index).setValue(%replay);
	EWorldEditor.isDirty = true;
}
function EWActiveReplayList::deleteReplay(%this, %index) {
	("EWReplayBox" @ %index).delete();

	//Delete and shift
	for (%i = %index; %i < MissionInfo.replays; %i ++) {
		MissionInfo.replay[%i] = MissionInfo.replay[%i + 1];
		MissionInfo.replayTime[%i] = MissionInfo.replayTime[%i + 1];
	}
	MissionInfo.replays --;
	MissionInfo.replay[MissionInfo.replays] = "";

	%this.init();
	EWorldEditor.isDirty = true;
}

function EWActiveReplayList::createNew(%this) {
	%file = filePath($Server::MissionFile) @ "/" @ fileBase($Server::MissionFile) @ "_" @(MissionInfo.replays + 0) @ ".rrec";
	getSaveFilename("*.rrec", "EWCreateNewReplay", %file);
}
function EWCreateNewReplay(%replay) {
	MessageBoxOk("Start Replay", "The replay will start when you close this window <spush><bold>and the editor<spop>, and will stop when you <spush><bold>reopen the editor<spop> press enter.", "EWActiveReplayList.startRecording(\"" @ %replay @ "\");");
}
function EWActiveReplayList::startRecording(%this, %replay) {
	%this.replayLocation = %replay;
	EditorMap.bindCmd(keyboard, "enter", "EWActiveReplayList.stopRecording();", "");
	recordStart($MP::MyMarble, %replay);
	$Record::Started = true;
}
function EWActiveReplayList::stopRecording(%this) {
	recordFinish();
	MessageBoxOk("Replay Done", "The replay has been saved to " @ %this.replayLocation);
	MissionInfo.replay[(MissionInfo.replays + 0)] = %this.replayLocation;
	MissionInfo.replayTime[(MissionInfo.replays + 0)] = 0;
	MissionInfo.replays ++;

	%this.init();
	EWorldEditor.isDirty = true;
}

function EWActiveReplayList::addExisting(%this) {
	getLoadFilename("*.rrec", "EWAddExistingReplay");
}

function EWAddExistingReplay(%replay) {
	MissionInfo.replay[(MissionInfo.replays + 0)] = %replay;
	MissionInfo.replayTime[(MissionInfo.replays + 0)] = 0;
	MissionInfo.replays ++;

	EWActiveReplayList.init();
	EWorldEditor.isDirty = true;
}

//------------------------------------------------------------------------------

function EWorldEditor::buildSpecial(%this) {
	%count = %this.getSelectionSize();
	%this.clearSpecial();

	echo("Build special for " @ %count @ " objects.");

	if (%count == 0) {
		%this.buildSpecialNone();
		return;
	}
	if (%count > 1) {
		%type = 2147483647;
		for (%i = 1; %i < %count; %i ++) {
			%obj1 = %this.getSelectedObject(%i - 1);
			%obj2 = %this.getSelectedObject(%i);

			%type &= %obj1.getType();
			%type &= %obj2.getType();

			//Don't allow multiple edits as one unless they're all the same datablock
			// (or same datablock class)
			if (%obj1.getClassName() !$= %obj2.getClassName())
				continue;
			if ((%obj1.getDataBlock() !$= %obj2.getDataBlock()) &&
			    (%obj1.getDataBlock().className !$= %obj2.getDataBlock().className))
				continue;
			%this.buildSpecialSingle(%obj1);
			return;
		}

		%this.buildSpecialMultiple(%type);
		return;
	}

	%this.buildSpecialSingle(%this.getSelectedObject(0));
}

function EWorldEditor::buildSpecialNone(%this) {
	%this.addSpecial("Edit Mission Info", "emibutton();");
	%this.addSpecial("Change Skybox", "csbbutton();");
}

function EWorldEditor::buildSpecialSingle(%this, %obj) {
	%type = %obj.getType();
	%class = %obj.getClassName();
	if (%type & $TypeMasks::GameBaseObjectType) {
		//Check if it's a special trigger we can make easier
		%dbName = %obj.getDatablock().getName();
		switch$ (%dbName) {
		case "MarblePhysModTrigger":
			%this.addSpecial("Edit PhysMod Trigger", "epmtbutton(" @ %obj @ ");");
		case "PathNode":
			%this.addSpecial("Edit Path Node", "epnbutton(" @ %obj @ ");");
		case "PathTrigger":
			%this.addSpecial("Edit Path Trigger", "eptbutton(" @ %obj @ ");");
		case "PushButton" or "PushButton_PQ" or "PushButtonExtended_PQ" or "PushButtonFlat_PQ":
			%this.addSpecial("Edit Button", "epbbutton(" @ %obj @ ");");
		}
		if (%obj.getDatablock().className $= "FadePlatformClass") {
			%this.addSpecial("Edit Fading Platform", "efpbutton(" @ %obj @ ");");
		}
		if (%obj.getDatablock().className $= "Gem") {
			%this.addSpecial("Make Platinum", "changeGemColor(" @ %obj @ ", \"Platinum\");");
			%this.addSpecial("Make Blue", "changeGemColor(" @ %obj @ ", \"Blue\");");
			%this.addSpecial("Make Yellow", "changeGemColor(" @ %obj @ ", \"Yellow\");");
			%this.addSpecial("Make Red", "changeGemColor(" @ %obj @ ", \"Red\");");
		}

		%this.addSpecial("Parenting Config", "openParentConfigDlg(" @ %obj @ ");");
		if (%obj.getDatablock().skin[0] !$= "") {
			%this.addSpecial("Skin Selector", "EWorldEditor.skinSelection();");
		}
	}
	switch$ (%class) {
	case "Sky":
		%this.addSpecial("Change Skybox", "csbbutton();");
	}
	%this.addSpecial("Drop to Ground", "EWorldEditor.dropAtGround();");
	%this.addSpecial("Rotate", "EWorldEditor.rotateManually();");
	%this.addSpecial("Translate", "EWorldEditor.translateManually();");
}

function EWorldEditor::buildSpecialMultiple(%this, %type) {
	%this.addSpecial("Group Items", "EWorldEditor.groupSelection();");
	%this.addSpecial("Ungroup Items", "EWorldEditor.ungroupSelection();");
	if (%type & $TypeMasks::GameBaseObjectType) {
		%this.addSpecial("Drop to Ground", "EWorldEditor.dropAtGround();");
		%this.addSpecial("Rotate", "EWorldEditor.rotateManually();");
		%this.addSpecial("Translate", "EWorldEditor.translateManually();");
	}
}

function EWorldEditor::applyAllSelection(%this, %function) {
	%count = %this.getSelectionSize();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %this.getSelectedObject(%i);
		call(%function, %obj);
	}
}

function EWorldEditor::clearSpecial(%this) {
	EWSpecialScroll.setWidth(getWord(EWSpecialBox.getExtent(), 0) - 4);
	EWSpecialScroll.clear();
}

function EWorldEditor::addSpecial(%this, %name, %action) {
	if (EWSpecialScroll.getCount() == 0)
		%start = getWord(EWSpecialBox.getExtent(), 0);
	else
		%start = getWord(EWSpecialScroll.getObject(EWSpecialScroll.getCount() - 1).position, 0);
	%length = textLen(%name, "Arial", "14") + 20;

	//EWSpecialScroll.setWidth(530);
	EWSpecialScroll.add(new GuiButtonCtrl() {
		profile = "GuiButtonProfile";
		horizSizing = "left";
		vertSizing = "bottom";
		position = (%start - %length) SPC 0;
		extent = %length SPC 30;
		minExtent = "8 8";
		visible = "1";
		command = %action;
		helpTag = "0";
		text = %name;
		groupNum = "-1";
		buttonType = "PushButton";
		repeatPeriod = "1000";
		repeatDecay = "1";
	});
}

//------------------------------------------------------------------------------

function EWorldEditor::translateManually(%this) {
	LargeFunctionDlg.init("editorTranslate3d", "Translate Manually", 1);
	LargeFunctionDlg.addNote("Move the selected object(s) along the following axes:");
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addTextEditField("ET3D_TransX", "X", 0, 350, -1);
	LargeFunctionDlg.addTextEditField("ET3D_TransY", "Y", 0, 350, -1);
	LargeFunctionDlg.addTextEditField("ET3D_TransZ", "Z", 0, 350, -1);
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addCheckbox("ET3D_Local", "Local Axes", 0, 0);
	LargeFunctionDlg.addNote("If you check the box, the object will be moved along its local axes.");
	LargeFunctionDlg.addNote("\tThese are the axes that are shown on the movement gizmo.");
	LargeFunctionDlg.addNote("If you don't check the box, the object will move along the absolute axes:");
	LargeFunctionDlg.addNote("\tx: (1 0 0), y: (0 1 0), and z: (0 0 1)");
}

function editorTranslate3d() {
	EWorldEditor.addUndoState();
	EWorldEditor.applyAllSelection("editorTranslate3dObj");
	Canvas.popDialog(LargeFunctionDlg);
}

function ET3D_Local::onPressed(%this) {
	//I don't care
}

function editorTranslate3dObj(%obj) {
	%translation = ET3D_TransX.getValue() SPC ET3D_TransY.getValue() SPC ET3D_TransZ.getValue();
	if (ET3D_Local.getValue()) {
		%obj.setTransform(MatrixMultiply(%obj.getTransform(), %translation SPC "1 0 0 0"));
	} else {
		%obj.setTransform(VectorAdd(MatrixPos(%obj.getTransform()), %translation) SPC MatrixRot(%obj.getTransform()));
	}
}

//------------------------------------------------------------------------------

function EWorldEditor::rotateManually(%this) {
	LargeFunctionDlg.init("editorRotate3d", "Rotate Manually", 1);
	LargeFunctionDlg.addNote("Rotate the selected object(s) along the following axes (in degrees, -360 to 360):");
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addTextEditField("ER3D_RotX", "X rotation", 0, 350, -1);
	LargeFunctionDlg.addTextEditField("ER3D_RotY", "Y rotation", 0, 350, -1);
	LargeFunctionDlg.addTextEditField("ER3D_RotZ", "Z rotation", 0, 350, -1);
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addCheckbox("ER3D_Local", "Local Axes", 1, 0);
	LargeFunctionDlg.addNote("If you leave the box checked, the object will be rotated along its local axes.");
	LargeFunctionDlg.addNote("\tThese are the axes that are shown on the movement gizmo.");
	LargeFunctionDlg.addNote("If you uncheck the box, the object will rotate along the absolute axes:");
	LargeFunctionDlg.addNote("\tx: (1 0 0), y: (0 1 0), and z: (0 0 1)");

	if (EWorldEditor.getSelectionSize() > 1) {
		%centroids = "2\tGroup Center\n0\tObject Origin\n1\tBox Center\n3\tPoint";
		%default = 2;
	} else {
		%centroids = "0\tObject Origin\n1\tBox Center\n3\tPoint";
		%default = EWorldEditor.objectsUseBoxCenter ? 1 : 0;
	}
	echo(%centroids);

	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addDropMenu("ER3D_CentroidChoice", "Rotation Center", 5, %centroids, %default);
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addNote("For Point-centered rotation");
	LargeFunctionDlg.addTextEditField("ER3D_CenterX", "X center", 0, 350, -1);
	LargeFunctionDlg.addTextEditField("ER3D_CenterY", "Y center", 0, 350, -1);
	LargeFunctionDlg.addTextEditField("ER3D_CenterZ", "Z center", 0, 350, -1);
	LargeFunctionDlg.addNote("");
	LargeFunctionDlg.addNote("Box Center: Rotate around the object's center");
	LargeFunctionDlg.addNote("Object Origin: Rotate around the object's position (not necessarily center).");
	LargeFunctionDlg.addNote("\tTo see object origins, open the Editor Settings and disable \"Objects Use Box Center\".");
	if (EWorldEditor.getSelectionSize() > 1) {
		LargeFunctionDlg.addNote("Group Center: Rotate all grouped objects as one. This disables rotating around local axes.");
	}
	ER3D_CentroidChoice.command = "er3d_updateCheck();";
	er3d_updateCheck();
}

function er3d_updateCheck() {
	ER3D_Local.setActive(ER3D_CentroidChoice.getValue() !$= "Group Center");
}

function editorRotate3d() {
	EWorldEditor.addUndoState();
	EWorldEditor.applyAllSelection("editorRotate3dObj");
	Canvas.popDialog(LargeFunctionDlg);
}

function ER3D_Local::onPressed(%this) {
	//I don't care
}

function editorRotate3dObj(%obj) {
	%matrix = MatrixInverse(MatrixCreateFromEuler(mDegToRad(ER3D_RotX.getValue()) SPC mDegToRad(ER3D_RotY.getValue()) SPC mDegToRad(ER3D_RotZ.getValue())));

	%local = ER3D_Local.getValue();
	switch$ (ER3D_CentroidChoice.getValue()) {
	case "3":
		%local = false;
		%center = ER3D_CenterX.getValue() SPC ER3D_CenterY.getValue() SPC ER3D_CenterZ.getValue();
	case "2":
		%local = false;
		%center = EWorldEditor.getSelectionCentroid();
	case "1":
		%center = %obj.getWorldBoxCenter();
	case "0":
		%center = MatrixPos(%obj.getTransform());
	}

	//Center is %offset past position
	%offset = VectorSub(%center, %obj.getTransform());
	//Offset in modelspace
	%offset = MatrixMulVector(MatrixInverse(%obj.getTransform()), %offset);
	//Translate away so we rotate around %center and not the object's origin
	%obj.setTransform(MatrixMultiply(%obj.getTransform(), %offset SPC "1 0 0 0"));

	if (%local) {
		%obj.setTransform(MatrixMultiply(%obj.getTransform(), %matrix));
	} else {
		%obj.setTransform(MatrixPos(%obj.getTransform()) SPC RotMultiply(MatrixRot(%matrix), MatrixRot(%obj.getTransform())));
	}

	//Revert our original translation
	%obj.setTransform(MatrixMultiply(%obj.getTransform(), VectorScale(%offset, -1) SPC "1 0 0 0"));
	%obj.forceNetUpdate();
}

//-----------------------------------------------------------------------------

function changeGemColor(%obj, %color) {
	%db = %obj.getDatablock().getName();
	switch$ (%db) {
	case "GemItem" or
	     "GemItemBlue" or
	     "GemItemRed" or
	     "GemItemYellow" or
	     "GemItemPurple" or
	     "GemItemGreen" or
	     "GemItemTurquoise" or
	     "GemItemOrange" or
	     "GemItemBlack" or
	     "GemItemPlatinum":
		%obj.setDataBlock("GemItem" @ %color);
		%obj.setSkinName(strlwr(%color));
		%obj.onInspectApply();
	case "GemItem_PQ" or
	     "GemItemBlue_PQ" or
	     "GemItemRed_PQ" or
	     "GemItemYellow_PQ" or
	     "GemItemPurple_PQ" or
	     "GemItemGreen_PQ" or
	     "GemItemTurquoise_PQ" or
	     "GemItemOrange_PQ" or
	     "GemItemBlack_PQ" or
	     "GemItemPlatinum_PQ":
		%obj.setDataBlock("GemItem" @ %color @ "_PQ");
		%obj.setSkinName(strlwr(%color));
		%obj.onInspectApply();
	case "FancyGemItem_PQ":
		%obj.setSkinName(strlwr(%color));
		%obj.onInspectApply();
	case "CandyItem" or
	     "CandyItemBlue" or
	     "CandyItemRed" or
	     "CandyItemYellow" or
	     "CandyItemPurple" or
	     "CandyItemGreen" or
	     "CandyItemTurquoise" or
	     "CandyItemOrange" or
	     "CandyItemBlack" or
	     "CandyItemPlatinum":
		%obj.setDataBlock("CandyItem" @ %color);
		%obj.setSkinName(strlwr(%color));
		%obj.onInspectApply();
	case "GemItem_MBU" or
	     "GemItemBlue_MBU" or
	     "GemItemRed_MBU" or
	     "GemItemYellow_MBU" or
	     "GemItemPurple_MBU" or
	     "GemItemGreen_MBU" or
	     "GemItemTurquoise_MBU" or
	     "GemItemOrange_MBU" or
	     "GemItemBlack_MBU" or
	     "GemItemPlatinum_MBU":
		%obj.setDataBlock("GemItem" @ %color @ "_MBU");
		%obj.setSkinName(strlwr(%color));
		%obj.onInspectApply();
	}
}

//-----------------------------------------------------------------------------

function EWorldEditor::focusOnSelection(%this) {
	if (%this.getSelectionSize() == 0) {
		//Get bounds of entire level
		%box = MissionGroup.getWorldBox();
	} else {
		//Get bounds of selection
		%box = "1e9 1e9 1e9 -1e9 -1e9 -1e9";
		for (%i = 0; %i < %this.getSelectionSize(); %i ++) {
			%obj = %this.getSelectedObject(%i);
			%box = BoxUnion(%box, %obj.getWorldBox());
		}
	}

	//Now focus
	if (ServerConnection.getControlObject().getClassName() !$= "Camera") {
		return;
	}
	%camera = ServerConnection.getControlObject();
	%center = BoxCenter(%box);
	%size = BoxSize(%box);
	%trans = %center SPC "1 0 0 0";
	%offset = MatrixMultiply("0 0 0" SPC MatrixRot(%camera.getTransform()), "0 -" @ VectorLen(%size) @ " 0 1 0 0 0");
	%trans = MatrixMultiply(%trans, %offset);
	%camera.setTransform(%trans);
}
