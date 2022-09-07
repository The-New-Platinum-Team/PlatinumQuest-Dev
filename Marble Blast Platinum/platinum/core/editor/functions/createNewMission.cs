//-----------------------------------------------------------------------------
// Creating new missions
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

//----------------------------------------

function createNewMission() {
	%missionFileName = CNM_MissionFileName.getValue();
	if (%missionFileName $= ".mis" || stripChars(%missionFileName, " ") $= "") {
		Assert("Info", "Invalid mission file name.");
		return;
	}

	if (!strstrbool(%missionFileName, ".mis"))
		%missionFileName = %missionFileName @ ".mis";

	%overwrite = CNM_OVERWRITE.getValue();
	%levelType = "custom";

	%fileString = "platinum/data/missions/" @ strlwr(%levelType) @ "/" @ %missionFileName;

	if (findFirstFile(%filestring) !$= "" && !%overwrite) {
		Assert("Info", "Mission file name is used!\n\nIf you want to overwrite this file, use the checkbox at the bottom of the dialog.");
		return;
	} else
		LargeFunctionDlg.cleanup();

	//BASICS

	%interiorFileName = CNM_InteriorFileName.getValue();

	%levelName = CNM_LevelName.getValue();
	%authorName = CNM_AuthorName.getValue();
	%levelNumber = CNM_LevelNumber.getValue();
	%levelDesc = strReplace(CNM_LevelDesc.getValue(), "\\n", "\n");

	//GAMEMODES

	%gm = "";
	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%mode = ModeInfoGroup.getObject(%i);
		%use[strlwr(%mode.identifier)] = ("EMI_Use" @ %mode.identifier).getValue();

		if (%use[strlwr(%mode.identifier)])
			%gm = addWord(%gm, %mode.identifier);
	}

	//%useDistance = CNM_UseDistance.getValue();
	//%distance_minimumDistance = CNM_Distance_MinimumDistance.getValue();

//////////////////////////////////////////////////////////////////////////////////////////////////////
// MISSIONGROUP SETUP - Condensed version of interiorTest()
	if ($Game::Menu) {
		endMission();
		$Game::Menu = false;
	}
	onServerCreated(); // gotta hack here to get the datablocks loaded...
	%missionGroup = createEmptyMission(%levelName);

	MissionInfo.GameMode = %gm;

	if (%interiorFileName !$= "") {
		if (!strstrbool(%interiorFileName, ".dif"))
			%interiorFileName = %interiorFileName @ ".dif";
		%interiorFilePath = findFirstFile("*" @ %interiorFileName);
		%interior = new InteriorInstance() {
			position = "0 0 0";
			rotation = "1 0 0 0";
			scale = "1 1 1";
			interiorFile = %interiorFilePath;
		};
		%missionGroup.add(%interior);
		%interior.magicButton();
	}

	if (!isObject(StartPoint)) {
		%pt = new StaticShape(StartPoint) {
			position = "0 -5 100";
			rotation = "1 0 0 0";
			scale = "1 1 1";
			dataBlock = "StartPad_PQ";
		};
		MissionGroup.add(%pt);
	}

	if (!isObject(EndPoint)) {
		%pt = new StaticShape(EndPoint) {
			position = "0 5 100";
			rotation = "1 0 0 0";
			scale = "1 1 1";
			dataBlock = "EndPad_PQ";
		};
		MissionGroup.add(%pt);
	}
	if (%interior) {
		%box = %interior.getWorldBox();
		%mx = getWord(%box, 0);
		%my = getWord(%box, 1);
		%mz = getWord(%box, 2);
		%MMx = getWord(%box, 3);
		%MMy = getWord(%box, 4);
		%MMz = getWord(%box, 5);
		%scale = ((%MMx - %mx)*2 + 25) SPC((%MMy - %my)*2 + 25) SPC((%MMz - %mz)*2 + 25);
		%pos = %mx - 25/2 - getRadius("x", %interior)/2 SPC %MMy + 25/2 + getRadius("y", %interior)/2 SPC %mz - 25/2 - getRadius("z", %interior)/2;
	} else {
		%pos = "-25 25 75";
		%scale = "50 50 50";
	}
	new Trigger(Bounds) {
		position = %pos;
		scale = %scale;
		rotation = "1 0 0 0";
		dataBlock = "InBoundsTrigger";
		polyhedron = "0.0000000 0.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 -1.0000000 0.0000000 0.0000000 0.0000000 1.0000000";
	};
	MissionGroup.add(Bounds);
////////////////////////////////////////////////////////////////////////////////////////////////////////

	MissionInfo.GameMode = $CNM::GameMode;
	MissionInfo.Game = "PlatinumQuest";

	MissionInfo.name = %levelName;
	MissionInfo.artist = %authorName;
	MissionInfo.level = %levelNumber;
	MissionInfo.desc = %levelDesc;

	%missionGroup.save(%fileString);
	%missionGroup.delete();

	menuLoadStartMission(%fileString);
}

function cnmbutton() {
	LargeFunctionDlg.init("createNewMission", "Create New Mission", 1);
	$CNM::GameMode = "";

	//TODO: music choice - LargeFunctionDlg.addDropMenu("CNM_Music", "Music Track:", 0, "none song1 song2 *song3");

	//BASICS
	LargeFunctionDlg.addTextEditField("CNM_MissionFileName", "Mission filename:", ".mis", 200, -1);
	LargeFunctionDlg.addTextEditField("CNM_InteriorFileName", "Interior filename for interior test [optional]:", "", 200, -1);
	LargeFunctionDlg.addTextEditField("CNM_LevelName", "Level name (as shown in level select):", "My Level Name", 350, -1);
	LargeFunctionDlg.addTextEditField("CNM_AuthorName", "Author name:", $pref::HighScoreName, 200, -1);
	LargeFunctionDlg.addTextEditField("CNM_LevelNumber", "Level number:", "1000", 100, -1);
	LargeFunctionDlg.addTextEditField("CNM_LevelDesc", "Level description:", "Type your level description here", 350, -1);
	LargeFunctionDlg.addNote("Note: More options available in the in-game editor.");

	%modes = Array(CNM_ModesArray);
	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%mode = ModeInfoGroup.getObject(%i);
		%ident = %mode.identifier;
		if (%mode.hide)
			continue;

		%modes.addEntry(%mode);
	}
	%modes.sort(ModeSort);

	//GAMEMODES

	LargeFunctionDlg.addNote("\c4----------- GAMEMODES -----------");
	LargeFunctionDlg.addNote("\c5-- Main Mode --");
	%mode = getModeInfo("null");
	%ident = %mode.identifier;
	%name = %mode.name;
	eval("function CNM_Use" @ %ident @ "::onPressed(%this, %gui){ CNM_replaceGameModes(\"" @ strlwr(%ident) @ "\", %this.getValue()); }");
	LargeFunctionDlg.addCheckBox("CNM_Use" @ %ident, "Normal / Gem Collection", true, 0);

	for (%i = 0; %i < %modes.getSize(); %i ++) {
		%mode = %modes.getEntry(%i);
		if (%mode.complete) {
			%ident = %mode.identifier;
			%name = %mode.name;
			eval("function CNM_Use" @ %ident @ "::onPressed(%this, %gui){ CNM_replaceGameModes(\"" @ strlwr(%ident) @ "\", %this.getValue()); }");
			LargeFunctionDlg.addCheckBox("CNM_Use" @ %ident, upperFirstAll(%name), false, 0);
		}
	}
	LargeFunctionDlg.addNote("\c5-- Extra Modes --");
	for (%i = 0; %i < %modes.getSize(); %i ++) {
		%mode = %modes.getEntry(%i);
		if (!%mode.complete) {
			%ident = %mode.identifier;
			%name = %mode.name;
			eval("function CNM_Use" @ %ident @ "::onPressed(%this, %gui){ CNM_replaceGameModes(\"" @ strlwr(%ident) @ "\", %this.getValue()); }");
			LargeFunctionDlg.addCheckBox("CNM_Use" @ %ident, upperFirstAll(%name), false, 0);
		}
	}
	LargeFunctionDlg.addNote("\c4-----------------------------------------------------------");
	LargeFunctionDlg.addCheckBox("CNM_OVERWRITE", "If mission already exists, overwrite file with this new one.", 0, 0);

	%modes.delete();
}

function createEmptyMission(%name) {
	$Editor::Enabled = 1; // Because I don't know which var to use anymore D:

	exec($usermods @ "/data/missions/MissionTemplate.mis");
	MissionInfo.name = %name;

	return MissionGroup;
}

function CNM_replaceGameModes(%newMode, %on) {
	%mode = strlwr($CNM::GameMode);
	if (%on) {
		if (getModeInfo(%newMode).complete) {
			for (%i = 0; %i < getWordCount(%mode); %i ++) {
				%info = getModeInfo(getWord(%mode, %i));
				if (%info.complete) {
					%mode = removeWord(%mode, %i);
					%i --;
				}
			}
		}

		if (getModeInfo(%newMode).complete) {
			%mode = %newMode @ " " @ %mode;
		} else {
			%mode = %mode @ " " @ %newMode;
		}
		while (strstrbool(%mode, "  ")) {
			%mode = strReplace(%mode, "  ", " ");
		}
	} else {
		%mode = strReplace(%mode, %newMode, "");
	}
	%mode = trim(%mode);
	%mode = resolveMissionGameModes("", %mode);
	$CNM::GameMode = %mode;

	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%info = ModeInfoGroup.getObject(%i);
		%ident = %info.identifier;
		if (!isObject(CNM_Use @ %info.identifier))
			continue;

		%use = stristrbool(%mode, %info.identifier);
		echo(%mode TAB %info.identifier SPC %use);
		(CNM_Use @ %info.identifier).setValue(%use);
	}
}
