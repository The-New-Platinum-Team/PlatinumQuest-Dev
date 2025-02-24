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

//-----------------------------------------------------------------------------
// MCS Mission saving
//-----------------------------------------------------------------------------

//.mcs mission format:
// <getMissionInfo>
// <unlock function>
// <client scripts>
// <server premission scripts>
// <mission>
// <server postmission scripts>

function mcsSaveMission(%file) {
	MessageBoxOk("Saving MCS File", "This may take a few seconds...\n\nReading old mission file for scripts... (1 / 6)");
	Canvas.repaint();

	$MCS::File = %file;
	%misName = alphaNum(fileBase(%file));
	deleteVariables("$MCS::Section*");

	//Read the current mission so we can get its scripts
	$MCS::Conts = fread(%file);
	$MCS::Length = strlen($MCS::Conts);

	if (fileExt(%file) $= ".mcs") {
		//Get the sections of script in the mission
		if (!mcsSectionize()) {
			return false;
		}
	} else {
		//We want to save a MCS instead of the MIS we have already
		%mcsFile = filePath(%file) @ "/" @ fileBase(%file) @ ".mcs";
		%tempFile = %file @ ".old";
		moveFile(%file, %tempFile);

		//Switch to the MCS file
		%file = %mcsFile;
		$Server::MissionFile = %file;

		if (!mcsSectionizeOld()) {
			return false;
		}
	}

	MessageBoxOk("Saving MCS File", "This may take a few seconds...\n\nWriting MissionInfo... (2 / 6)");
	Canvas.repaint();

	$MCS::Buffer = "";

	//Get rid of these
	ServerGroup.add(MissionInfo);
	ServerGroup.add(MusicProfile);

	//Extra fields for the level select
	mcsPrepareMissionInfo();

	%missionInfoFn = (mp() ? "MP_PQ_" : (lb() ? "LB_PQ_" : "PQ_")) @ %misName @ "_GetMissionInfo";
	%loadMissionFn = (mp() ? "MP_PQ_" : (lb() ? "LB_PQ_" : "PQ_")) @ %misName @ "_LoadMission";

	mcsWriteObjectFunctionSection("INFO", MissionInfo, %missionInfoFn);

	MessageBoxOk("Saving MCS File", "This may take a few seconds...\n\nFormatting MissionInfo... (3 / 6)");
	Canvas.repaint();

	//Magical formatting
	mcsFormatMissionInfo();

	//Clean up
	mcsCleanMissionInfo();

	mcsWriteScriptSection("UNLOCK");
	mcsWriteScriptSection("CLIENT SCRIPTS");
	mcsWriteScriptSection("SERVER PREMISSION SCRIPTS");

	MessageBoxOk("Saving MCS File", "This may take a few seconds...\n\nWriting MissionGroup... (4 / 6)");
	Canvas.repaint();

	mcsWriteObjectFunctionSection("MISSION", MissionGroup, %loadMissionFn);
	mcsWriteScriptSection("SERVER POSTMISSION SCRIPTS");

	//Strip off the trailing newline
	$MCS::Buffer = getSubStr($MCS::Buffer, 0, strlen($MCS::Buffer) - 1);

	MessageBoxOk("Saving MCS File", "This may take a few seconds...\n\nFormatting MissionGroup... (5 / 6)");
	Canvas.repaint();

	//Formatting the actual file itself to clean up some stuff
	mcsFormatMission();

	MessageBoxOk("Saving MCS File", "This may take a few seconds...\n\nWriting Final Mission... (6 / 6)");
	Canvas.repaint();

	fwrite(%file, $MCS::Buffer);
	compile(%file);
}

function mcsSectionize() {
	%pos = 0;
	%count = 0;
	while ((%pos = stripos($MCS::Conts, "//--- ", %pos)) != -1) {
		%start = %pos;
		//Get the line contents
		%end = stripos($MCS::Conts, "\n", %pos);
		%line = getSubStr($MCS::Conts, %pos, (%end == -1 ? $MCS::Length : %end - %pos));
		%pos += strlen(%line);

		//Not what we're looking for
		if (getSubStr(%line, strlen(%line) - 4, 4) !$= " ---") {
			echo("MCS invalid line: " @ %line @ " didn't get end-dashed");
			continue;
		}

		//Inner bits
		%conts = getSubStr(%line, 6, strlen(%line) - 10);

		//What type of marker is this
		%type = getWord(%conts, getWordCount(%conts) - 1);
		%name = getWords(%conts, 0, getWordCount(%conts) - 2);

		if (%name $= "PQ WRITE") {
			//Old PQ mcs mission
			return mcsSectionizeOld();
		}

		//What does the marker type mean, begin/end
		switch$ (%type) {
		case "BEGIN":
			if ($MCS::SectionBegin[%name] !$= "") {
				error("MCS duplicate section: " @ %name);
				continue;
			}
			if (%pos > 0 && getSubStr($MCS::Conts, %pos, 1) $= "\n")
				%pos ++;
			$MCS::SectionBegin[%name] = %pos;
			echo("MCS found section " @ %name @ " start at " @ %pos);
		case "END":
			if ($MCS::SectionBegin[%name] $= "") {
				error("MCS section has no start: " @ %name);
				continue;
			}
			if ($MCS::SectionEnd[%name] !$= "") {
				error("MCS duplicate section: " @ %name);
				continue;
			}

			$MCS::SectionEnd[%name] = %start;
			$MCS::SectionLen[%name] = $MCS::SectionEnd[%name] - $MCS::SectionBegin[%name];
			$MCS::SectionConts[%name] = getSubStr($MCS::Conts, $MCS::SectionBegin[%name], $MCS::SectionLen[%name]);

			echo("MCS found section " @ %name @ " of length " @ $MCS::SectionLen[%name]);
		default:
			error("MCS unknown marker line name: " @ %name);
		}

		//Failsafe
		%count ++;
		if (%count > 20) {
			error("MCS Save: Overflow?");
			return false;
		}
	}
	return true;
}

function mcsSectionizeOld() {
	//Everything before //--- OBJECT WRITE BEGIN --- is SERVER PREMISSION SCRIPTS
	//Everything after  //--- OBJECT WRITE END ---   is SERVER POSTMISSION SCRIPTS
	//If one of the two doesn't exist, everything is SERVER PREMISSION SCRIPTS

	//See if it's an old PQ mcs mission, and try to get the stuff before and after
	// the WRITE BEGIN / WRITE END
	%startPos = stripos($MCS::Conts, "//--- PQ WRITE BEGIN ---");
	%endPos = stripos($MCS::Conts, "//--- PQ WRITE END ---");
	if (%startPos != -1 && %endPos != -1) {
		//Yes it's an old PQ mcs mission
		%endPos += 23; //strlen("//--- PQ WRITE END ---\n")

		//Strip newline as well
		if (getSubStr($MCS::Conts, %endPos, 1) $= "\n")
			%endPos ++;
		if (getSubStr($MCS::Conts, %startPos, 1) $= "\n")
			%startPos ++;
	} else {
		//No it's a regular mission
		%startPos = stripos($MCS::Conts, "//--- OBJECT WRITE BEGIN ---");
		%endPos = stripos($MCS::Conts, "//--- OBJECT WRITE END ---");

		if (%startPos == -1 || %endPos == -1) {
			//What the hell, no bounds on this mission
			//Just dump everything at the start
			%startPos = $MCS::Length;
			%endPos = $MCS::Length;
		} else {
			%endPos += 27; //strlen("//--- OBJECT WRITE END ---\n")

			//Strip newline as well
			if (getSubStr($MCS::Conts, %endPos, 1) $= "\n")
				%endPos ++;
			if (getSubStr($MCS::Conts, %startPos, 1) $= "\n")
				%startPos ++;
		}
	}

	//Stuff before and after the write starts/ends
	%before = getSubStr($MCS::Conts, 0, %startPos);
	%after = getSubStr($MCS::Conts, %endPos, $MCS::Length);

	//Strip off extra newlines because Torque puts way too many in
	if (%before !$= "" && getSubStr(%before, strlen(%before) - 1, 1) !$= "\n")
		%before = %before @ "\n";

	//We don't need them if they're just a single newline
	if (%before $= "\n")
		%before = "";
	if (%after $= "\n")
		%after = "";

	$MCS::SectionLen["SERVER PREMISSION SCRIPTS"] = strlen(%before);
	$MCS::SectionConts["SERVER PREMISSION SCRIPTS"] = %before;
	$MCS::SectionLen["SERVER POSTMISSION SCRIPTS"] = strlen(%after);
	$MCS::SectionConts["SERVER POSTMISSION SCRIPTS"] = %after;

	return true;
}

$MCS::DefaultScript["INFO"] = "//Mission information for the level select. Generated from the MissionInfo object except with extra goodies.\n";
$MCS::PostScript["INFO"] = "";

$MCS::DefaultScript["UNLOCK"] = "//In the event that you want this mission to be locked by a function, here's\n// where you should put that. Just uncomment this function and fill it out:\n//function unlock_MissionNameHere(%mission) { //%mission is the MissionInfo\n//\treturn true; //True if the mission is unlocked\n//}\n";
$MCS::PostScript["UNLOCK"] = "//Don't continue loading if this just wants the mission info\nif ($loadingMissionInfo) return;\n";

$MCS::DefaultScript["CLIENT SCRIPTS"] = "//Put any scripts that will be loaded on all clients (in MP / SP) here.\n// Note: these will be loaded by dedicated servers too, so be sure to test for\n// $Server::Dedicated before creating any GUI.\n\n";
$MCS::PostScript["CLIENT SCRIPTS"] = "//Don't continue loading if this is a client (non-server)\nif (!$Server::Hosting || $Server::_Dedicated) return;\n";

$MCS::DefaultScript["SERVER PREMISSION SCRIPTS"] = "//These scripts will be loaded by the server only, before the mission is created.\n// This is a great place to put custom datablocks.\n\n";
$MCS::PostScript["SERVER PREMISSION SCRIPTS"] = "";

$MCS::DefaultScript["MISSION"] = "";
$MCS::PostScript["MISSION"] = "";

$MCS::DefaultScript["SERVER POSTMISSION SCRIPTS"] = "//Put any scripts that will be loaded after the mission is loaded here\n\n";
$MCS::PostScript["SERVER POSTMISSION SCRIPTS"] = "";


function mcsWriteScriptSection(%section) {
	%out =  "//--- " @ %section @ " BEGIN ---\n";
	if ($MCS::CustomContents[%section] $= "") {
		if ($MCS::SectionLen[%section] == 0) {
			%out = %out @ $MCS::DefaultScript[%section];
		} else {
			%out = %out @ $MCS::SectionConts[%section];
		}
	} else {
		%out = %out @ $MCS::CustomContents[%section];
	}
	%out = %out @ "//--- " @ %section @ " END ---\n";
	%out = %out @ $MCS::PostScript[%section];

	$MCS::Buffer = $MCS::Buffer @ %out;
}

function mcsWriteObjectFunctionSection(%section, %object, %fnname) {
	%out =  "//--- " @ %section @ " BEGIN ---\n";
	%out = %out @ $MCS::DefaultScript[%section];
	%out = %out @ "function " @ %fnname @ "() {\n";
	%out = %out @ "\treturn\n";

	//Stringify the object
	%saveSpot = filePath($MCS::File) @ "/.temp.cs";
	%object.save(%saveSpot, "saveFieldCompare");
	%conts = fread(%saveSpot);
	%conts = strReplace(%conts, "//--- OBJECT WRITE BEGIN ---\n", "");
	%conts = strReplace(%conts, "//--- OBJECT WRITE END ---\n", "");

	%out = %out @ %conts;

	//Clean up
	deleteFile(%saveSpot);

	%out = %out @ "}\n";
	%out = %out @ "//--- " @ %section @ " END ---\n";
	%out = %out @ $MCS::PostScript[%section];

	$MCS::Buffer = $MCS::Buffer @ %out;
}

//Something you'd never see in an actual mission
$MCS::CustomRadarRuleReplacement = "$$CustomRadarRuleReplacement$$";

function mcsPrepareMissionInfo() {
	//Try and find an easteregg / nest egg
	%egg1 = mcsSearch(MissionGroup, "datablock=EasterEgg");
	%egg2 = mcsSearch(MissionGroup, "datablock=NestEgg_PQ");
	MissionInfo.easterEgg = (isObject(%egg1) || isObject(%egg2));

	//How many gems we have
	%gems = mcsSearchAll(MissionGroup, "datablockClass=Gem");
	MissionInfo.gems = %gems.getSize();

	if ($Game::isMode["hunt"] || $Game::isMode["GemMadness"]) {
		//How many of each type of gems we have
		%gems1  = mcsSearchAll(MissionGroup, "datablock=GemItemRed").getSize()      + mcsSearchAll(MissionGroup, "datablock=GemItemRed_PQ").getSize()      + mcsSearchAll(MissionGroup, "datablock=FancyGemItem_PQ;skin=red").getSize();
		%gems2  = mcsSearchAll(MissionGroup, "datablock=GemItemYellow").getSize()   + mcsSearchAll(MissionGroup, "datablock=GemItemYellow_PQ").getSize()   + mcsSearchAll(MissionGroup, "datablock=FancyGemItem_PQ;skin=yellow").getSize();
		%gems5  = mcsSearchAll(MissionGroup, "datablock=GemItemBlue").getSize()     + mcsSearchAll(MissionGroup, "datablock=GemItemBlue_PQ").getSize()     + mcsSearchAll(MissionGroup, "datablock=FancyGemItem_PQ;skin=blue").getSize();
		%gems10 = mcsSearchAll(MissionGroup, "datablock=GemItemPlatinum").getSize() + mcsSearchAll(MissionGroup, "datablock=GemItemPlatinum_PQ").getSize() + mcsSearchAll(MissionGroup, "datablock=FancyGemItem_PQ;skin=platinum").getSize();
		MissionInfo.gems[1] = %gems1;
		MissionInfo.gems[2] = %gems2;
		MissionInfo.gems[5] = %gems5;
		MissionInfo.gems[10] = %gems10;
		MissionInfo.maxScore = %gems1 + (%gems2 * 2) + (%gems5 * 5) + (%gems10 * 10);
	} else {
		//Not hunt, these don't matter
		MissionInfo.gems[1] = "";
		MissionInfo.gems[2] = "";
		MissionInfo.gems[5] = "";
		MissionInfo.gems[10] = "";
		MissionInfo.maxScore = MissionInfo.gems;
	}

	//All interiors (and pathed)
	%interiors = mcsSearchAll(MissionGroup, "class=InteriorInstance");
	%mps = mcsSearchAll(MissionGroup, "class=PathedInterior");

	//Find unique files
	%intFiles = Array(MCSInteriorsArray);
	for (%i = 0; %i < %interiors.getSize(); %i ++) {
		%int = %interiors.getEntry(%i);
		if (%found[%int.interiorFile])
			continue;
		%found[%int.interiorFile] = true;
		%intFiles.addEntry(%int.interiorFile);
	}
	for (%i = 0; %i < %mps.getSize(); %i ++) {
		%int = %mps.getEntry(%i);
		if (%found[%int.interiorResource])
			continue;
		%found[%int.interiorResource] = true;
		%intFiles.addEntry(%int.interiorResource);
	}

	//Clean up any old interiors data
	if (MissionInfo.interiors !$= "") {
		for (%i = 0; %i < MissionInfo.interiors; %i ++) {
			MissionInfo.interior[%i] = "";
		}
		MissionInfo.interiors = "";
	}

	//Assign a list of interiors
	MissionInfo.interiors = %intFiles.getSize();
	for (%i = 0; %i < %intFiles.getSize(); %i ++) {
		MissionInfo.interior[%i] = %intFiles.getEntry(%i);
	}

	//Default radar rule
	if (MissionInfo.customRadarRule $= "")
		MissionInfo.customRadarRule = $Radar::Flags::Gems | $Radar::Flags::EndPad;

	$MCS::CustomRadarRuleTemp = MissionInfo.customRadarRule;
	MissionInfo.customRadarRule = $MCS::CustomRadarRuleReplacement;

	//This can change so don't save it
	MissionInfo.file = "";
	MissionInfo.canPlay = "";
	MissionInfo.completion = "";

	%intFiles.delete();
}

function mcsFormatMissionInfo() {
	//Strip the name from MissionInfo
	$MCS::Buffer = strReplace($MCS::Buffer, "\nnew ScriptObject(MissionInfo) {\n", "\nnew ScriptObject() {\n");

	//Format the custom radar rule
	%rule = $MCS::CustomRadarRuleTemp;
	%ruleStr = "$Radar::Flags::None";
	if ((%rule & (1 << 0)) != 0)
		%ruleStr = %ruleStr @ " | $Radar::Flags::Gems";
	if ((%rule & (1 << 1)) != 0)
		%ruleStr = %ruleStr @ " | $Radar::Flags::TimeTravels";
	if ((%rule & (1 << 2)) != 0)
		%ruleStr = %ruleStr @ " | $Radar::Flags::EndPad";
	if ((%rule & (1 << 3)) != 0)
		%ruleStr = %ruleStr @ " | $Radar::Flags::Checkpoints";
	if ((%rule & (1 << 4)) != 0)
		%ruleStr = %ruleStr @ " | $Radar::Flags::Cannons";
	if ((%rule & (1 << 5)) != 0)
		%ruleStr = %ruleStr @ " | $Radar::Flags::Powerups";

	if (%rule != 0) {
		//22 == strlen("$Radar::Flags::None | ")
		%ruleStr = getSubStr(%ruleStr, 22, strlen(%ruleStr));
	}
	$MCS::Buffer = strReplace($MCS::Buffer, "\"" @ $MCS::CustomRadarRuleReplacement @ "\"", %ruleStr);
	$MCS::Buffer = strReplace($MCS::Buffer, "\"platinum/", "$usermods @ \"/");

	//Replace starting spaces with tabs
	%lines = getRecordCount($MCS::Buffer);
	for (%i = 0; %i < %lines; %i ++) {
		%line = getRecord($MCS::Buffer, %i);
		%len = strlen(%line);

		//# of spaces
		for (%pos = 0; %pos < %len; %pos ++) {
			if (strpos(%line, "   ", %pos) == %pos) {
				%line = getSubStr(%line, 0, %pos) @ "\t" @ getSubStr(%line, %pos + 3, %len);
				%len -= 2;
			} else {
				break;
			}
		}
		$MCS::Buffer = setRecord($MCS::Buffer, %i, %line);
	}
}

function mcsFormatMission() {
	//Line-specific
	%lines = getRecordCount($MCS::Buffer);
	%inside = false;
	for (%i = 0; %i < %lines; %i ++) {
		%line = getRecord($MCS::Buffer, %i);

		if (%line $= "//--- MISSION BEGIN ---") {
			echo("Inside mission, starting format");
			%inside = true;
			continue;
		}
		if (%line $= "//--- MISSION END ---") {
			echo("Out of mission, stopping format");
			%inside = false;
			break;
		}
		if (!%inside) {
			continue;
		}

		%len = strlen(%line);

		//# of spaces
		for (%pos = 0; %pos < %len; %pos ++) {
			if (strpos(%line, "   ", %pos) == %pos) {
				%line = getSubStr(%line, 0, %pos) @ "\t" @ getSubStr(%line, %pos + 3, %len);
				%len -= 2;
			} else {
				break;
			}
		}

		//new Object(something with a space in the name is a syntax error)
		%newPos = strpos(%line, "new ");
		if (%newPos != -1) {
			//Make sure it complies
			%openParenPos = strpos(%line, "(", %newPos);
			%closeParenPos = strrpos(%line, ")");
			%conts = getSubStr(%line, %openParenPos + 1, %closeParenPos - %openParenPos - 1);

			if (stripChars(%conts, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_") !$= "") {
				%conts = "\"" @ expandEscape(%conts) @ "\"";
				%line = getSubStr(%line, 0, %openParenPos + 1) @ %conts @ getSubStr(%line, %closeParenPos, %len);
			}
		}

		%line = strReplace(%line, "\"platinum/", "$usermods @ \"/");

		$MCS::Buffer = setRecord($MCS::Buffer, %i, %line);
	}
}

function mcsCleanMissionInfo() {
	MissionInfo.easterEgg = "";
	MissionInfo.gems = "";
	MissionInfo.gems[1] = "";
	MissionInfo.gems[2] = "";
	MissionInfo.gems[5] = "";
	MissionInfo.gems[10] = "";
	MissionInfo.maxScore = "";
	MissionInfo.file = $Server::MissionFile;

	//Clean up any old interiors data
	if (MissionInfo.interiors !$= "") {
		for (%i = 0; %i < MissionInfo.interiors; %i ++) {
			MissionInfo.interior[%i] = "";
		}
		MissionInfo.interiors = "";
	}

	MissionInfo.customRadarRule = $MCS::CustomRadarRuleTemp;
}

function mcsMatch(%obj, %sel) {
	%match = false;
	while (%sel !$= "") {
		%sel = nextToken(%sel, "token", ";");

		%pos = strpos(%token, "=");
		if (%pos == -1)
			continue;
		%selector = getSubStr(%token, 0, %pos);
		%value = getSubStr(%token, %pos + 1, strlen(%token));

		switch$ (%selector) {
		case "datablock":
			//No datablock, can't match
			if ((%obj.getType() & $TypeMasks::GameBaseObjectType) == 0)
				return false;
			//Wrong DB, can't match
			if (%obj.getDataBlock().getName() !$= %value)
				return false;
			%match = true;
		case "class":
			//Wrong class
			if (%obj.getClassName() !$= %value)
				return false;
			%match = true;
		case "datablockClass":
			//No datablock, can't match
			if ((%obj.getType() & $TypeMasks::GameBaseObjectType) == 0)
				return false;
			//Wrong DB, can't match
			if (%obj.getDataBlock().className !$= %value)
				return false;
			%match = true;
		default:
			//Assume it's a dynamic field and try to get it
			if (%obj.getFieldValue(%selector) !$= %value)
				return false;
			%match = true;
		}
	}
	return %match;
}

function mcsSearch(%group, %sel) {
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();
		if (mcsMatch(%obj, %sel))
			return %obj;
		if (%class $= "SimGroup") {
				%sub = mcsSearch(%obj, %sel);
				if (isObject(%sub))
					return %sub;
			}
	}
	return -1;
}

function mcsSearchAll(%group, %sel, %array) {
	if (%array $= "") {
		%array = Array(MCSSearchArray);
		%array.schedule(1000, delete);
	}

	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();
		if (mcsMatch(%obj, %sel))
			%array.addEntry(%obj);
		if (%class $= "SimGroup") {
			mcsSearchAll(%obj, %sel, %array);
		}
	}
	return %array;
}

//-----------------------------------------------------------------------------
// Helper utility to write all missions as mcs
//-----------------------------------------------------------------------------

function mcsbooyah() {
	booyahnext($Server::MissionFile);
}

function booyahnext(%mission) {
	//Reload their current mission
	Editor.close();

	activateMenuHandler("Booyah");

	menuDestroyServer();

	RootGui.setContent(LoadingGui);
	RootGui.showPreviewImage(true);
	Canvas.repaint();

	menuCreateServer();
	menuLoadMission(%mission);
	$Game::UseMenu = true;

	RootGui.setContent(LoadingGui);
}
function Booyah_MissionLoaded() {
	menuPlay();
}
function Booyah_Play() {
	deactivateMenuHandler("Booyah");

	Editor::create();
	MissionCleanup.add(Editor);
	Editor.open();

	RootGui.showPreviewImage(true);

	mmccss();

	//Load next
	%pmg = PlayMissionGui;
	%pmg.selectedIndex++;

	%list = %pmg.getMissionList();
	%idx = %pmg.selectedIndex;

	if (%idx >= %list.getSize())
		RootGui.setContent(PlayGui);

	%mission = %list.getEntry(%idx);
	%file = %mission.file;

	schedule(1000, 0, booyahnext, %file);
}

function mmccss() {
	onMissionReset();

	activatePackage(save);
	MissionGroup._presave();
	mcsSaveMission($Server::MissionFile);
	MissionGroup._postsave();
	deactivatePackage(save);
}