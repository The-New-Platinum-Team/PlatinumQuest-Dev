//-----------------------------------------------------------------------------
// saveObject.cs
//
// Copyright (c) 2013 The Platinum Team
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

$_presavefields = -1;
$_presavefield[$_presavefields++] = "superClass";
$_presavefield[$_presavefields++] = "class";
$_presavefield[$_presavefields++] = "spawnWeight";
$_presavefield[$_presavefields++] = "block";
$_presavefield[$_presavefields++] = "light";
$_presavefield[$_presavefields++] = "pickup";
$_presavefield[$_presavefields++] = "pickupCheckpoint";
$_presavefield[$_presavefields++] = "pathPosition";
$_presavefield[$_presavefields++] = "pathSchedule";
$_presavefield[$_presavefields++] = "targetPosition";
$_presavefield[$_presavefields++] = "PathSyncId";
$_presavefield[$_presavefields++] = "PathNode";
$_presavefield[$_presavefields++] = "moving";
$_presavefield[$_presavefields++] = "fx";
$_presavefield[$_presavefields++] = "fx0";
$_presavefield[$_presavefields++] = "fx1";
$_presavefield[$_presavefields++] = "fx2";
$_presavefield[$_presavefields++] = "fx3";
$_presavefield[$_presavefields++] = "fx4";
$_presavefield[$_presavefields++] = "fx5";
$_presavefield[$_presavefields++] = "fx6";
$_presavefield[$_presavefields++] = "fx7";
$_presavefield[$_presavefields++] = "cancelme";
$_presavefield[$_presavefields++] = "cancelme1";
$_presavefield[$_presavefields++] = "cancelme2";
$_presavefield[$_presavefields++] = "cancelme3";
$_presavefield[$_presavefields++] = "nextNodeId";
$_presavefield[$_presavefields++] = "pathRngStart";
$_presavefield[$_presavefields++] = "respawns";
$_presavefield[$_presavefields++] = "respawnSchedule";
$_presavefield[$_presavefields++] = "bezierHandle1Id";
$_presavefield[$_presavefields++] = "bezierHandle2Id";
$_presavefield[$_presavefields++] = "downSched";
$_presavefield[$_presavefields++] = "pathPrevNode";
$_presavefield[$_presavefields++] = "pickupCheckpoint_PQ";
$_presavefield[$_presavefields++] = "respawnschedule";
$_presavefield[$_presavefields++] = "spawnCount";
$_presavefield[$_presavefields++] = "entercount";
$_presavefield[$_presavefields++] = "enters";
$_presavefield[$_presavefields++] = "triggered";
$_presavefield[$_presavefields++] = "baseTrans";
$_presavefield[$_presavefields++] = "base";
$_presavefield[$_presavefields++] = "cannon";
$_presavefield[$_presavefields++] = "g";
$_presavefield[$_presavefields++] = "difficulty_id";
$_presavefield[$_presavefields++] = "difficultyId";
$_presavefield[$_presavefields++] = "game_id";
$_presavefield[$_presavefields++] = "gameId";
$_presavefield[$_presavefields++] = "downloaded";
$_presavefield[$_presavefields++] = "hash";
$_presavefield[$_presavefields++] = "is_custom";
$_presavefield[$_presavefields++] = "sort_index";
$_presavefield[$_presavefields++] = "unformattedText";

function SimDatablock::_presave(%this, %obj) {}
function SimDatablock::_postsave(%this, %obj) {}

function SimObject::_presave(%this) {
	if (%this.getType() & $TypeMasks::GameBaseObjectType) {
		%this.getDatablock()._presave(%this);
	}
	%fields = %this.getDynamicFieldList();
	%count = 0;
	for (%i = 0; %i < getFieldCount(%fields); %i ++) {
		%field = getField(%fields, %i);
		%value = %this.getFieldValue(%field);
		if (getSubStr(%field, 0, 1) $= "_") {
			$_presaveTemp[%this.getId(), %count, "field"] = %field;
			$_presaveTemp[%this.getId(), %count, "value"] = %value;
			devecho("PRESAVE: Clear temp field " @ %count @ ": " @ %field @ " (" @ %value @ ")");
			%this.setFieldValue(%field, "");
			%count ++;
		}
	}
	$_presaveTemp[%this.getId(), "count"] = %count;
	for (%i = 0; %i <= $_presavefields; %i ++) {
		%field = $_presavefield[%i];
		%value = %this.getFieldValue(%field);
		$_presave[%this.getID(), %field] = %value;
		%this.setFieldValue(%field, "");
		devecho("PRESAVE: Clear extra field " @ %field @ " (" @ %value @ ")");
	}

	// Iterate all the items
	if (%this.getClassName() $= "SimGroup")
		for (%i = 0; %i < %this.getCount(); %i ++)
			%this.getObject(%i)._presave();
}
function SimObject::_postSave(%this) {
	if (%this.getType() & $TypeMasks::GameBaseObjectType) {
		%this.getDatablock()._postSave(%this);
	}
	for (%i = 0; %i < $_presaveTemp[%this.getId(), "count"]; %i ++) {
		%field = $_presaveTemp[%this.getId(), %i, "field"];
		%value = $_presaveTemp[%this.getId(), %i, "value"];
		devecho("POSTSAVE: Restore temp field " @ %i @ ": " @ %field @ " (" @ %value @ ")");
		%this.setFieldValue(%field, %value);
	}
	for (%i = 0; %i <= $_presavefields; %i ++) {
		%field = $_presavefield[%i];
		%value = $_presave[%this.getID(), %field];
		%this.setFieldValue(%field, %value);
		$_presave[%this.getID(), %field] = "";
		devecho("POSTSAVE: Restore extra field " @ %field @ " (" @ %value @ ")");
	}

	// Clean up
	deleteVariables("$_presave" @ %this.getID() @ "_*");

	// Iterate all the items
	if (%this.getClassName() $= "SimGroup")
		for (%i = 0; %i < %this.getCount(); %i ++)
			%this.getObject(%i)._postsave();
}

activatePackage(Save);

function SimObject::getSaveFields(%this) {
	%fields = $Editor::Fields[%this.getName()];
	if (%fields $= "" && (%this.getType() & $TypeMasks::GameBaseObjectType))
		%fields = addWord($Editor::Fields[%this.getDatablock().getName()], %fields);
	if (%fields $= "" && (%this.getType() & $TypeMasks::GameBaseObjectType))
		%fields = addWord($Editor::Fields[%this.getDatablock().className], %fields);
	if (%fields $= "")
		%fields = addWord($Editor::Fields[%this.class], %fields);
	if (%fields $= "")
		%fields = addWord($Editor::Fields[%this.superClass], %fields);
	if (%fields $= "")
		%fields = addWord($Editor::Fields[%this.getClassName()], %fields);
	return %fields;
}

function SimObject::saveFieldCompare(%this, %aname, %avalue, %bname, %bvalue) {
	%fields = %this.getSaveFields();

	%apos = findWord(%fields, %aname);
	%bpos = findWord(%fields, %bname);

	if (%apos == -1 && %bpos != -1) return false;
	if (%apos != -1 && %bpos == -1) return true;
	if (%apos == -1 && %bpos == -1) return (stricmp(%aname, %bname) < 0);
	return (%apos < %bpos);
}

$Editor::Fields["MissionInfo"] =
    "name" SPC
    "type" SPC
    "level" SPC
    "desc" SPC
    "startHelpText" SPC
    "artist" SPC
    "music" SPC
    "game" SPC
    "gameMode" SPC
    "time" SPC
    "goldTime" SPC
    "platinumTime" SPC
    "ultimateTime" SPC
    "awesomeTime" SPC
    "score" SPC
    "platinumScore" SPC
    "ultimateScore" SPC
    "awesomeScore" SPC
    "maxGemsPerSpawn" SPC
    "radiusFromGem" SPC
    "redSpawnChance" SPC
    "yellowSpawnChance" SPC
    "blueSpawnChance" SPC
    "platinumSpawnChance" SPC
    "generalHint" SPC
    "ultimateHint" SPC
    "awesomeHint" SPC
    "eggHint" SPC
    "eastereggHint" SPC
    "CustomRadarRule";
