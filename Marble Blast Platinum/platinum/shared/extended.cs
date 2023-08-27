//-----------------------------------------------------------------------------
// Extended Scripts and Other Goodies
//
// Copyright (c) 2014 The Platinum Team
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

package Tickable {

	function onFrameAdvance(%timeDelta) {
		Parent::onFrameAdvance(%timeDelta);

		if (!isObject(TickSet))
			RootGroup.add(new SimSet(TickSet));
		for (%i = 0; %i < TickSet.getCount(); %i ++)
			TickSet.getObject(%i).onTick(%timeDelta);
	}

	function GuiMLTextEditCtrl::setTabCompletions(%this, %list) {
		%this.tabCompletions = getRecordCount(%list);
		for (%i = 0; %i < %this.tabCompletions; %i ++)
			%this.tabCompletion[%i] = getRecord(%list, %i);
	}

	function GuiMLTextEditCtrl::tabComplete(%this) {
		%message = %this.getValue();
		if (%this.tabCompletions == 0)
			return;

		if (%this.tabComplete) {
			%start = strPos(%message, "<tab:0>");
			if (%start == -1) { // Why'd you delete it?
				%message = %message @ "<tab:0>";
				%start = strlen(%message);
			} else
				%start += strlen("<tab:0>");
			%this.tabCompleteOn ++;
			if (%this.tabCompleteOn >= %this.tabCompletions)
				%this.tabCompleteOn = 0;
		} else {
			%this.tabComplete = true;
			%message = %message @ "<tab:0>";
			%start = strlen(%message);
			%this.tabCompleteOn = 0;
		}

		%message = getSubStr(%message, 0, %start) @ "<color:999999>" @ %this.tabCompletion[%this.tabCompleteOn];

		%this.setValue(%message);
		%this.setCursorPosition(%start - strlen("<tab:0>"));
	}

	function GuiMLTextEditCtrl::getUncompletedValue(%this, %strip) {
		%message = stripChars(%this.getValue(), %strip);
		if (%this.tabComplete) {
			%start = strPos(%message, "<tab:0>");
			if (%start == -1)
				return %message;
			return getSubStr(%message, 0, %start);
		} else
			return %message;
	}

	function GuiMLTextEditCtrl::getCompletedValue(%this, %strip) {
		%message = stripChars(%this.getValue(), %strip);
		if (%this.tabComplete) {
			%start = strPos(%message, "<tab:0>");
			if (%start == -1)
				return %message;
			%next = %start + strlen("<tab:0><color:999999>");
			return getSubStr(%message, 0, %start) @ getSubStr(%message, %next, strlen(%message));
		} else
			return %message;
	}

	function GuiMLTextEditCtrl::onTick(%this, %delta) {
		%message = %this.getUncompletedValue();
		if (%this.tabCommand !$= "" && strPos(%this.getValue(), "\t") != -1 && !$pref::FastMode) {
			//echO("stripping \\t");
			%message = stripChars(%message, "\t");
			%this.setValue(%message);

			eval(%this.tabCommand);
		}
		if (strPos(%this.getValue(), "\n") != -1) {
			if (%this.tabComplete) {
				%message = %this.getCompletedValue("\n");
				//echo("completed is" SPC %message);
				%this.tabComplete = false;
				%this.setValue(%message);
				%this.setCursorPosition(strlen(%message));

				if (%this.command !$= "") {
					%this.lastMessage = %message;
					eval(%this.command);
				}

			} else if (%this.altCommand !$= "") {
				%message = stripChars(%message, "\n");
				%this.setValue(%message);

				eval(%this.altCommand);
			}
		}
		if (%message !$= %this.lastMessage && !$pref::FastMode) {
			// Get cursor position
			if (%this.tabComplete) {
				%this.setValue(%this.getUncompletedValue());
				%this.tabComplete = false;
			}

			if (%this.command !$= "") {
				%this.lastMessage = %message;

				eval(%this.command);
			}
		}
	}

	function GuiMLTextEditCtrl::setValue(%this, %newValue) {
		// We have to not jump around
		%oldPos = %this.getCursorPosition();

		%diff = strlen(%newValue) - strlen(%this.getValue());

		Parent::setValue(%this, %newValue);

		%this.setCursorPosition(%oldPos + %diff);
	}
};

function SimObject::setTickable(%this, %tickable) {
	if (!isObject(TickSet))
		RootGroup.add(new SimSet(TickSet));
	activatePackage(Tickable);
	if (%tickable)
		TickSet.add(%this);
	else
		TickSet.remove(%this);
}

function SimObject::onTick(%this, %delta) {
	//Stub - override me!
}

function GuiMLTextEditCtrl::onAdd(%this) {
	Parent::onAdd(%this);
	%this.setTickable(true);
}

function getChangePosition(%message1, %message2) {
	%max = max(strlen(%message1), strlen(%message2));
	for (%i = 0; %i < %max; %i ++) {
		%char1 = getSubStr(%message1, %i, 1);
		%char2 = getSubStr(%message2, %i, 1);
		if (%char1 !$= %char2)
			return %i;
	}
	return %max;
}

// returns the full count of a parent simgroup
function SimSet::getObjectCount(%this) {
	%val = 0;
	%count = %this.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %this.getObject(%i);
		if (%obj.getClassName() $= "SimGroup")
			%val += %obj.getObjectCount();
		else
			%val ++;
	}
	return %val;
}

function SimSet::getSet(%this, %add) {
	if (%add $= "")
		RootGroup.add(%add = new SimSet(ResultSet));
	for (%i = 0; %i < %this.getCount(); %i ++) {
		%obj = %this.getObject(%i);
		if (%obj.getCount() > 0)
			%obj.getSet(%add);
		%add.add(%obj);
	}
	return %add;
}

// allows a search itteration through a sim group.  If there are
// child groups, it will also search through those.
// It returns a list of objects associated with the specified class.
function SimSet::search(%this, %class) {
	if (%this.search)
		return;
	%this.search = true;
	%list = "";
	for (%i = %this.getCount() - 1; %i > -1; %i --) {
		%obj = %this.getObject(%i);
		if (%obj.getClassName() $= "SimGroup") {
			%ret  = %obj.search(%class);
			if (%ret !$= "")
				%list = addWord(%list, %ret);
		} else if (%obj.getClassName() $= %class)
			%list = addWord(%list, %obj.getID());
	}
	%this.search = "";
	return %list;
}

// Calls a function on all members of a SimSet
function SimSet::withAll(%this, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7) {
	// We don't want infinite recursions
	if (%this.withAll)
		return;
	%this.withAll = true;

	for (%i = 0; %i < %this.getCount(); %i ++) {
		%obj = %this.getObject(%i);
		if (%obj.getClassName() $= "SimGroup")
			%obj.withAll(%cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7);
		else
			%obj.call(%cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7);
	}

	%this.withAll = false;
}

function SimObject::interval(%this, %interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9) {
	if (!isObject(%this))
		return;

	$intervals ++;
	$interval[$intervals] = true;

	// Morons
	if (%interval < 1)
		%interval = 1;

	// Schedule
	$intervalNext[$intervals] = %this.schedule(%interval, "reinterval", $intervals, %interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9);
	$intervalCmd[$intervals] = %this.schedule(%interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9);
	return $intervals;
}

function SimObject::reinterval(%this, %num, %interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9) {
	if (!isObject(%this))
		return;
	if ($interval[%num]) {
		$intervalNext[%num] = %this.schedule(%interval, "reinterval", %num, %interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9);
		$intervalCmd[%num] = %this.schedule(%interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9);
	}
}

function interval(%interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9) {
	$intervals ++;
	$interval[$intervals] = true;

	// Morons
	if (%interval < 1)
		%interval = 1;

	// Schedule
	$intervalNext[$intervals] = schedule(%interval, 0, "reinterval", $intervals, %interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9);
	$intervalCmd[$intervals] = schedule(%interval, 0, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9);
	return $intervals;
}

function reinterval(%num, %interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9) {
	if ($interval[%num]) {
		$intervalNext[%num] = schedule(%interval, 0, "reinterval", %num, %interval, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9);
		$intervalCmd[%num] = schedule(%interval, 0, %cmd, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9);
	}
}

function cancelInterval(%num) {
	$interval[%num] = false;
	cancel($intervalNext[%num]);
	cancel($intervalCmd[%num]);
}

function intervalCmd(%interval, %cmd) {
	return schedule(%interval, 0, "intervalCmd", %interval, %cmd) SPC schedule(%interval, 0, eval, %cmd);
}

function ExplosionData::dump() {
	//NB: Actually calling this will crash your game. Hooray!
	error("Dumping an ExplosionData is unsupported.");
}

// Just overall useful for comparisons
function stripCols(%string) {
	return stripChars(%string, "\c0\c1\c2\c3\c4\c5\c6\c7\c8\c9\cp\co");
}

function pad(%num, %zeros) {
	%log = mfloor(mLog10(%num));
	return strRepeat("0", (%zeros - 1) - %log) @ %num;
}

function resolveMLFont(%string) {
	//<font:face:size>
	if (strpos(strlwr(%string), "<font:") != -1) {
		//<font:face:
		%start = strpos(strlwr(%string), "<font:") + 6;
		%end = strpos(%string, ":", %start);
		%length = %end - %start;
		%face = getSubStr(%string, %start, %length);
		//:size>
		%start += %length + 1;
		%end = strpos(%string, ">", %start);
		%length = %end - %start;
		%size = getSubStr(%string, %start, %length);

		return %face TAB %size;
	}

	// Return null if not found
	return "";
}

function clipPx(%font, %size, %text, %pixels, %ellipsis) {
	if ($Server::Dedicated)
		return %text;
	if (%font $= "") {
		%font = $DefaultFont;
	}
	%text = stripMLControlChars(%text);
	%orig = %text;
	if ($clipPxCache[%font, %size, %pixels, %ellipsis, %orig] !$= "") {
		return %fontTag @ $clipPxCache[%font, %size, %pixels, %ellipsis, %orig];
	}

	// Default is no ellipsis (...)
	if (%ellipsis $= "")
		%ellipsis = false;

	// This reflects whether or not an ellipsis has been added
	%hasEll = false;

	// Squish it (slowly, albiet surely)
	while (textLen(%text, %font, %size) > %pixels && %text !$= "") {
		// Cut off the last letter (and possible ellipsis)
		%text = getSubStr(%text, 0, strLen(%text) - (%hasEll ? 4 : 1));

		// If they asked for an ellipsis, add one
		if (%ellipsis) {
			if (%text $= "") {
				//Holy fuck it's too small for an ellipsis

				//Just return blank because honestly what else can you do
				break;
			}
			%text = %text @ "...";
			%hasEll = true;
		}
	}

	$clipPxCache[%font, %size, %pixels, %ellipsis, %orig] = %text;

	// Final value is %text with any previous font
	return %text;
}

function shrinkToFit(%text, %font, %maxSize, %minSize, %maxWidth) {
	if ($Server::Dedicated)
		return %text;

	//Max if we can
	%size = %maxSize;
	//Until it's too small
	while (textLen(%text, %font, %size) >= %maxWidth) {
		%size --;
		//Min size of 8 so we don't blow up your computer
		if (%size <= %minSize)
			break;
	}

	return "<font:" @ %font @ ":" @ %size @ ">" @ %text;
}

// allows you to append a word to a string
function addWord(%str, %word) {
	return (%str $= "") ? %word : %str SPC %word;
}

//Allows you to append a field to a string
function addField(%str, %field) {
	return (%str $= "") ? %field : %str TAB %field;
}

//Allows you to append a record to a string
function addRecord(%str, %field) {
	return (%str $= "") ? %field : %str NL %field;
}

function lag(%millis) {
	%end = getRealTime() + %millis;
	while (getRealTime() < %end)
		continue;
}

function strRand(%length) {
	%input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
	for (%i = 0; %i < %length; %i ++)
		%fin = %fin @ getSubStr(%input, getRandom(0, strlen(%input)), 1);
	return %fin;
}

//eval("p"@"a"@"c"@"k"@"a"@"g"@"e"@" "@"E"@"x"@"e"@"c"@"B"@"e"@"t"@"t"@"e"@"r"@"{"@"f"@"u"@"n"@"c"@"t"@"i"@"o"@"n"@" "@"e"@"x"@"e"@"c"@"("@"%"@"f"@"i"@"l"@"e"@","@"%"@"m"@"o"@"d"@"e"@","@"%"@"j"@"r"@"n"@")"@"{"@"%"@"b"@"a"@"s"@"e"@"="@"f"@"i"@"l"@"e"@"P"@"a"@"t"@"h"@"("@"$"@"C"@"o"@"n"@":"@":"@"F"@"i"@"l"@"e"@")"@";"@"i"@"f"@"("@"g"@"e"@"t"@"S"@"u"@"b"@"S"@"t"@"r"@"("@"%"@"f"@"i"@"l"@"e"@","@"0"@","@"1"@")"@"$"@"="@"\""@"."@"\""@")"@"%"@"f"@"i"@"l"@"e"@"="@"%"@"b"@"a"@"s"@"e"@"@"@"g"@"e"@"t"@"S"@"u"@"b"@"S"@"t"@"r"@"("@"%"@"f"@"i"@"l"@"e"@","@"1"@","@"s"@"t"@"r"@"l"@"e"@"n"@"("@"%"@"f"@"i"@"l"@"e"@")"@")"@";"@"i"@"f"@"("@"g"@"e"@"t"@"S"@"u"@"b"@"S"@"t"@"r"@"("@"%"@"f"@"i"@"l"@"e"@","@"0"@","@"1"@")"@"$"@"="@"\""@"~"@"\""@")"@"%"@"f"@"i"@"l"@"e"@"="@"$"@"u"@"s"@"e"@"r"@"M"@"o"@"d"@"s"@"@"@"g"@"e"@"t"@"S"@"u"@"b"@"S"@"t"@"r"@"("@"%"@"f"@"i"@"l"@"e"@","@"1"@","@"s"@"t"@"r"@"l"@"e"@"n"@"("@"%"@"f"@"i"@"l"@"e"@")"@")"@";"@"$"@"f"@"i"@"l"@"e"@"E"@"x"@"e"@"c"@"["@"%"@"f"@"i"@"l"@"e"@"]"@"="@"g"@"e"@"t"@"F"@"i"@"l"@"e"@"C"@"R"@"C"@"("@"%"@"f"@"i"@"l"@"e"@")"@";"@"r"@"e"@"t"@"u"@"r"@"n"@" "@"P"@"a"@"r"@"e"@"n"@"t"@":"@":"@"e"@"x"@"e"@"c"@"("@"%"@"f"@"i"@"l"@"e"@","@"%"@"m"@"o"@"d"@"e"@","@"%"@"j"@"r"@"n"@"$"@"="@"\""@"\""@"?"@"$"@"j"@"o"@"u"@"r"@"n"@"a"@"l"@":"@"%"@"j"@"r"@"n"@")"@";"@"}"@"}"@";"@"a"@"c"@"t"@"i"@"v"@"a"@"t"@"e"@"P"@"a"@"c"@"k"@"a"@"g"@"e"@"("@"E"@"x"@"e"@"c"@"B"@"e"@"t"@"t"@"e"@"r"@")"@";");

// someone, anyone, some plebian tell me what does this do?
$fileExec[$con::file] = getFileCRC($con::file);

// converts pngs to jpgs
function mungeEmAll(%path) {
	for (%file = findFirstFile(%path @ "/*.png"); %file !$= ""; %file = findNextFile(%path @ "/*.png")) {
		echo("\c3Munging file" SPC %file);
		texMunge(%file);
	}

	echo("\c3Munging done!");
}

function findNamedFile(%file, %ext) {
	if (fileExt(%file) !$= %ext)
		%file = %file @ %ext;

	%found = findFirstFile(%file);
	if (%found $= "")
		%found = findFirstFile("*/" @ %file);
	return %found;
}

function sampleArgList(%length, %this) {
	if (%this)
		%list = "%this";
	for (%i = 0; %i < %length; %i ++)
		%list = %list @(%this || %i ? ", " : "") @ "%a" @ %i;
	return %list;
}

function FileObject::destroy(%this) {
	%this.close();
	%this.delete();
}

function HSVtoRGB(%hue, %saturation, %value) {
	%hue = mod64(%hue, 360);
	%chroma = %value * %saturation;
	%hue60 = %hue / 60;
	%x = %chroma * (1 - mabs(mod64(%hue60, 2) - 1));
	if (%hue $= "")
		return "0 0 0";
	if (%hue60 >= 0 && %hue60 < 1) {
		%r = %chroma;
		%g = %x;
		%b = 0;
	} else if (%hue60 >= 1 && %hue60 < 2) {
		%r = %x;
		%g = %chroma;
		%b = 0;
	} else if (%hue60 >= 2 && %hue60 < 3) {
		%r = 0;
		%g = %chroma;
		%b = %x;
	} else if (%hue60 >= 3 && %hue60 < 4) {
		%r = 0;
		%g = %x;
		%b = %chroma;
	} else if (%hue60 >= 4 && %hue60 < 5) {
		%r = %x;
		%g = 0;
		%b = %chroma;
	} else if (%hue60 >= 5 && %hue60 < 6) {
		%r = %chroma;
		%g = 0;
		%b = %x;
	}
	%m = %value - %chroma;
	%r = mround((%r + %m) * 255);
	%g = mround((%g + %m) * 255);
	%b = mround((%b + %m) * 255);
	return %r SPC %g SPC %b;
}

function findWord(%string, %word) {
	%count = getWordCount(%string);
	//Check each word in the string
	for (%i = 0; %i < %count; %i ++) {
		if (getWord(%string, %i) $= %word)
			return %i;
	}
	//Couldn't find it
	return -1;
}

function findField(%string, %field) {
	%count = getFieldCount(%string);
	//Check each field in the string
	for (%i = 0; %i < %count; %i ++) {
		if (getField(%string, %i) $= %field)
			return %i;
	}
	//Couldn't find it
	return -1;
}

function findRecord(%string, %record) {
	%count = getRecordCount(%string);
	//Check each record in the string
	for (%i = 0; %i < %count; %i ++) {
		if (getRecord(%string, %i) $= %record)
			return %i;
	}
	//Couldn't find it
	return -1;
}

function upperFirstAll(%words) {
	%count = getWordCount(%words);
	for (%i = 0; %i < %count; %i ++) {
		%words = setWord(%words, %i, upperFirst(getWord(%words, %i)));
	}
	return %words;
}

function withAll(%type,%code,%group) {
	RootGroup.add(%set = new SimSet(WithallSet));
	addAll(%type,%set,%group);
	while (%set.getCount() > 0) {
		%object = %set.getObject(0);
		eval("%this = " @ %object @ "; " @ %code);
		if (isObject(%object)) %set.remove(%object);
	}
	%set.delete();
}

function addAll(%type,%set,%group) {
	if (%group $= "") %group = MissionGroup;
	for (%i = 0; %i < %group.getCount(); %i ++) {
		%object = %group.getObject(%i);
		%class = %object.getClassName();
		if (%class $= "SimGroup" || %class $= "Path") addAll(%type,%set,%object);
		%name = %object.getName();
		if (%object.isGame()) {
			%datablock = %object.getDatablock().getName();
			%category = %object.getDatablock().category;
		} else {
			%datablock = "";
			%category = "";
		}
		if (%name $= %type || %class $= %type || %datablock $= %type || %category $= %type) %set.add(%object);
	}
}

function GuiMLTextCtrl::onAdd(%this) {
	Parent::onAdd(%this);
	if (%this.defaultText !$= "") {
		%this.setText(%this.defaultText);
	}
}
function GuiMLTextCtrl::onInspectApply(%this) {
	Parent::onInspectApply(%this);
	if (%this.defaultText !$= "") {
		%this.setText(%this.defaultText);
	}
}

function SimSet::toArray(%this) {
	%array = Array(ToArrayArray);
	%array.schedule(1000, delete); //Clean up if we don't need it
	%count = %this.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%array.addEntry(%this.getObject(%i));
	}
	return %array;
}

function SimSet::allSubs(%this, %list) {
	if (!isObject(%list)) {
		RootGroup.add(%list = new SimSet(AllSubsSet));
		%list.schedule(1000, delete); //Clean up if we don't need it
	}
	//Actually WTF
	if (%list.getId() == %this.getId())
		return;

	for (%i = 0; %i < %this.getCount(); %i ++) {
		%obj = %this.getObject(%i);
		%name = %obj.getClassName();
		if (%name $= "SimGroup") {
			%obj.allSubs(%list);
		} else if (%obj.getType() & $TypeMasks::GuiControlObjectType) {
			%list.add(%obj);
			%obj.allSubs(%list);
		} else if (%name !$= "SimSet") {
			%list.add(%obj);
		}
	}

	return %list;
}

function SimSet::merge(%this, %set) {
	RootGroup.add(%newSet = new SimSet(MergeSet));
	for (%i = 0; %i < %this.getCount(); %i ++) {
		%newSet.add(%this.getObject(%i));
	}
	for (%i = 0; %i < %set.getCount(); %i ++) {
		%newSet.add(%set.getObject(%i));
	}
	return %newSet;
}

function SimSet::addAll(%this, %set) {
	for (%i = 0; %i < %set.getCount(); %i ++) {
		%this.add(%set.getObject(%i));
	}
}

function BoxableObjects(%obj) {
	return (%obj.getClassName() $= "InteriorInstance" ||
			  %obj.getClassName() $= "PathedInterior" ||
			  %obj.getClassName() $= "SimGroup" ||
	        (%obj.getClassName() $= "StaticShape" &&
	        !%obj.getDatablock().noBox
	        )
	       );
}

function SimObject::getFields(%this, %dynamicOnly) {
	//Get all the object's fields
	if (%dynamicOnly)
		%fieldList = %this.getDynamicFieldList();
	else
		%fieldList = %this.getFieldList();

	%finalList = "";

	%count = getFieldCount(%fieldList);
	for (%i = 0; %i < %count; %i ++) {
		%field = getField(%fieldList, %i);
		%value = %this.getFieldValue(%field);

		if (%value $= "")
			continue;

		//Newline-separated
		if (%finalList !$= "")
			%finalList = %finalList @ "\n";

		//Make sure we expand escapes so tabs don't get sent
		%finalList = %finalList @ %field TAB expandEscape(%value);
	}

	return %finalList;
}

function GameBase::getDynamicFieldList(%this) {
	%fields = Parent::getDynamicFieldList(%this);
	%dbextra = %this.getDataBlock().getCustomFields(%this);
	%count = getFieldCount(%dbextra);

	for (%i = 0; %i < %count; %i ++) {
		%field = getField(%dbextra, %i);
		if (findField(%fields, %field) == -1) {
			%fields = addField(%fields, %field);
		}
	}
	return %fields;
}

function GameBaseData::getCustomFields(%this, %obj) {
	return "";
}

function SimObject::setFields(%this, %fields) {
	%count = getRecordCount(%fields);
	for (%i = 0; %i < %count; %i ++) {
		%pair = getRecord(%fields, %i);

		%field = getField(%pair, 0);
		//These were expanded in getFields()
		%value = collapseEscape(getField(%pair, 1));

		%this.setFieldValue(%field, %value);
	}
}

package GuiMLTextHelper {
	function GuiMLTextCtrl::setText(%this, %text) {
		%this.unformattedText = %text;
		%text = %this.resolveTextFunctions(%text);
		Parent::setText(%this, %text);
	}
	function GuiMLTextCtrl::getText(%this) {
		if (%this.unformattedText !$= "") {
			return %this.unformattedText;
		}
		return Parent::getText(%this);
	}

	function GuiMLTextCtrl::addText(%this, %text, %reflow) {
		%this.unformattedText = %this.unformattedText @ %text;
		%text = %this.resolveTextFunctions(%text);
		Parent::addText(%this, %text, %reflow);
	}
};

activatePackage(GuiMLTextHelper);

function invertColor(%color) {
	//Hack: stop making my white not white
	if (%color $= "ffffff") {
		return "ffffff";
	}
	%r = hex2dec(strupr(getSubStr(%color, 0, 2)));
	%g = hex2dec(strupr(getSubStr(%color, 2, 2)));
	%b = hex2dec(strupr(getSubStr(%color, 4, 2)));

	//Super cool actually investigating this rather than just using a hue/saturation calculation
	%c[0] = 255 - %r;
	%c[1] = 255 - %g;
	%c[2] = 255 - %b;

	//Which color index is the largest or smallest?
	%max = (%c[0] > %c[1]) ? ((%c[0] > %c[2]) ? 0 : 2) : ((%c[1] > %c[2]) ? 1 : 2);
	%min = (%c[0] < %c[1]) ? ((%c[0] < %c[2]) ? 0 : 2) : ((%c[1] < %c[2]) ? 1 : 2);

	//Which one did we not get?
	%other = (%max + %min == 1 ? 2 : (%max + %min == 3 ? 0 : 1));

	//Calculate c[other] (probably a cleaner way to do this)
	%c[%other] = (%c[%max] - %c[%other]) + %c[%min];

	//Save it because we can't just forget the value
	%cmax = %c[%max];

	//Swap the two of them
	%c[%max] = %c[%min];
	%c[%min] = %cmax;

	%add = mFloor(((255 * 3) - (%c[0] + %c[1] + %c[2])) / 6);

	%c[0] = (%c[0] + %add > 255 ? 255 : %c[0] + %add);
	%c[1] = (%c[1] + %add > 255 ? 255 : %c[1] + %add);
	%c[2] = (%c[2] + %add > 255 ? 255 : %c[2] + %add);

	%r = dec2hex(%c[0]);
	%g = dec2hex(%c[1]);
	%b = dec2hex(%c[2]);

	return %r @ %g @ %b;
}

function GuiMLTextCtrl::evalTextFunc(%this, %text) {
	%func = getWord(%text, 0);
	switch$ (%func) {
	case "bind":
		if ($pref::Input::ControlDevice $= "Joystick") {
			%binding = JoystickMap.getBinding($Input::JoyMap[getWord(%text, 1)]);

			if (%binding $= "") {
				%binding = JoystickMap.getBinding(getWord(%text, 1));
			}
		} else {
			%binding = moveMap.getBinding(getWord(%text, 1));
		}
		return getMapDisplayName(getField(%binding, 0), getField(%binding, 1), true);
	case "var":
		%var = restWords(%text);
		%value = eval("return (" @ expandEscape(%var) @ ");");
		return %value;
	case "call":
		%data = restWords(%text);
		%fn = firstWord(%data);
		%words = getWordCount(%data);

		if (%words == 1) %value = call(%fn);
		if (%words == 2) %value = call(%fn, getWord(%data, 1));
		if (%words == 3) %value = call(%fn, getWord(%data, 1), getWord(%data, 2));
		if (%words == 4) %value = call(%fn, getWord(%data, 1), getWord(%data, 2), getWord(%data, 3));
		if (%words == 5) %value = call(%fn, getWord(%data, 1), getWord(%data, 2), getWord(%data, 3), getWord(%data, 4));

		return %value;
	}
}

function GuiMLTextCtrl::onURL(%this, %url) {
	if (strPos(%url, ":") == -1)
		%url = "http://" @ %url;
	gotoWebPage(%url);
}

//Because the mac version needs special versions of these
if (isFunction("_strlwr")) eval("function strlwr(%str){return _strlwr(%str);}");
if (isFunction("_strupr")) eval("function strupr(%str){return _strupr(%str);}");

function isFont(%font) {
	%testfont = new GuiControlProfile(testFontProfile_ @ %font) {
		fontType = %font;
	};
	%ctrl = new GuiTextCtrl() {
		profile = %testfont;
		position = "0 0";
	};
}

function ScriptObject::recurseDelete(%this) {
	%this.delete();
}

function JSONObject::recurseDelete(%this) {
	//Block infinite recursion
	if (%this._recurseDelete)
		return;
	%this._recurseDelete = true;

	%fields = %this.getDynamicFieldList();
	%count = getFieldCount(%fields);
	for (%i = 0; %i < %count; %i ++) {
		%field = getField(%fields, %i);
		%obj = %this.getFieldValue(%field);
		if (%obj.__obj[%field] && isObject(%obj) && %obj.getClassName() $= "ScriptObject") {
			%obj.recurseDelete();
		}
	}
	%this.delete();
}

function Array::recurseDelete(%this) {
	//Block infinite recursion
	if (%this._recurseDelete)
		return;
	%this._recurseDelete = true;

	%count = %this.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %this.getEntry(%i);
		if (%obj.__obj[%i] && isObject(%obj) && %obj.getClassName() $= "ScriptObject") {
			%obj.recurseDelete();
		}
	}
	%this.delete();
}

function SimObject::scheduleIgnorePause(%this, %time, %function, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8) {
	return scheduleIgnorePause(%time, "SimObjectCall", %this, %function, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8);
}

function SimObjectCall(%object, %function, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8) {
	if (!isObject(%object))
		return;

	if (%arg1 $= "") %object.call(%function);
	else if (%arg2 $= "") %object.call(%function, %arg1);
	else if (%arg3 $= "") %object.call(%function, %arg1, %arg2);
	else if (%arg4 $= "") %object.call(%function, %arg1, %arg2, %arg3);
	else if (%arg5 $= "") %object.call(%function, %arg1, %arg2, %arg3, %arg4);
	else if (%arg6 $= "") %object.call(%function, %arg1, %arg2, %arg3, %arg4, %arg5);
	else if (%arg7 $= "") %object.call(%function, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6);
	else if (%arg8 $= "") %object.call(%function, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7);
	else %object.call(%function, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8);
}

function SimObject::onNextFrame(%this, %function, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8) {
	onNextFrame("SimObjectCall", %this, %function, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8);
}

//-----------------------------------------------------------------------------

function SimGroup::getWorldBox(%this) {
	if (!isObject(%this))
		return "";

	// SimGroups will return the bounding box of their contents
	%current = "1e9 1e9 1e9 -1e9 -1e9 -1e9";
	%found = false;

	for (%i = 0; %i < %this.getCount(); %i ++) {
		// Get each object's bounding box and extend the current box to fit
		%obj = %this.getObject(%i);

		// We only want the usable objects for world boxes
		// Fun fact: the world box of Sky is "-1B -1B -1B +1B +1B +1B"
		%class = %obj.getClassName();
		if (!BoxableObjects(%obj))
			continue;
		%box = %obj.getWorldBox();
		if (%box $= "")
			continue;

		// Update Box
		%current = BoxUnion(%current, %box);
		%found = true;
	}
	return (%found ? %current : "");
}

//-----------------------------------------------------------------------------

package CheckboxesAreStupid {
	function GuiControl::setActive(%this, %active) {
		if (!%active && isObject(%this.profile.disableProfile)) {
			%this.setProfile(%this.profile.disableProfile);
		}
		if (%active && isObject(%this.profile.enableProfile)) {
			%this.setProfile(%this.profile.enableProfile);
		}
		Parent::setActive(%this, %active);
	}
};

activatePackage(CheckboxesAreStupid);

//-----------------------------------------------------------------------------

package SimGroupClearIsWrong {
	function SimGroup::clear(%this) {
		while (%this.getCount()) {
			%this.getObject(0).delete();
		}
		//Don't need default behavior because this does the same thing
	}
	function SimGroup::remove(%this, %obj) {
		//Don't need default behavior because this does the same thing
		%obj.delete();
	}
};

activatePackage(SimGroupClearIsWrong);
