//-----------------------------------------------------------------------------
// Time Entry Controls
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

function TimeEntryCtrl(%ctrl, %args) {
	%ctrl.command = "TimeEntryCtrlUpdate(" @ %ctrl @ ");";
	%ctrl.setValue(formatTime(0));
	TimeEntryCtrlUpdate(%ctrl);
}

function TimeEntryCtrlUpdate(%ctrl) {
	//Strip non-numbers and stuff off
	%val = %ctrl.getValue2();
	%len = strlen(%val);
	%val = stripNot(%val, "0123456789:.");
	//Record the difference so we can ignore it
	%alphadiff = %len - strlen(%val);

	//Find where it was changed
	%lastlen = strlen(%ctrl.last);
	%len = strlen(%val);
	%pos = %ctrl.getCursorPos() - %alphadiff;
	%diff = %len - %lastlen;

	//Detect addition or deletion
	if (%len > %lastlen) {
		//Addition
		//What to do: strip puntuation, delete N chars in front of selection, punctuate
		%val = unpunctuateTime(%val);
		%delStart = %pos;
		//If you start typing after one of the punctuations we need to correct for that
		if (%pos > 3)
			%delStart --;
		if (%pos > 6)
			%delStart --;
		//Remove the extra characters we overwrote
		%val = getSubStr(%val, 0, %delStart) @ getSubStr(%val, %delStart + %diff, %len);
		%val = punctuateTime(%val);
		//If you end on punctuation then go to the next one automatically
		if (%pos == 2)
			%pos ++;
		if (%pos == 5)
			%pos ++;
	} else if (%len < %lastlen) {
		//Deletion
		//What to do: find what was deleted and replace it with zeroes
		// If punctuation was deleted we need to replace it
		%val = unpunctuateTime(%val);
		%unlast = unpunctuateTime(%ctrl.last);
		%undiff = strlen(%val) - strlen(%unlast);
		if (%val == %unlast) {
			//Actually they only deleted punctuation. Just re-add it
			%val = punctuateTime(%val);
		} else {
			//Find where they deleted
			%delStart = %pos;
			//If you start typing after one of the punctuations we need to correct for that
			if (%pos > 2)
				%delStart --;
			if (%pos > 5)
				%delStart --;
			//Fill how many chars they deleted with zeroes
			%val = getSubStr(%val, 0, %delStart) @ strRepeat("0", -%undiff) @ getSubStr(%val, %delStart, %len);
			//If you end on punctuation then back up a little more
			if (%pos == 3)
				%pos --;
			if (%pos == 6)
				%pos --;
			%val = punctuateTime(%val);
		}
	} else {
		//Replacement
		//What to do: if they replaced punctuation like a moron, ignore it

		//Good enough for science
		%val = unpunctuateTime(%val);
		%val = punctuateTime(%val);
	}

	%ctrl.setValue2(%val);
	%ctrl.setCursorPos(%pos);
	%ctrl.last = %val;
}

//Override the default set/get methods for our custom controls so they seem like
// you're actually entering ms instead of a formatted time.
function GuiTextEditCtrl::getValue(%this) {
	%val = Parent::getValue(%this);
	if (%this.TimeEntryCtrl) {
		return unformatTime(%val);
	}
	return %val;
}
function GuiTextEditCtrl::setValue(%this, %value) {
	if (%this.TimeEntryCtrl) {
		Parent::setValue(%this, formatTime(%value));
		return;
	}
	Parent::setValue(%this, %value);
}

//Hackarounds so we can avoid the hacks above
function GuiTextEditCtrl::getValue2(%this) {
	return Parent::getValue(%this);
}
function GuiTextEditCtrl::setValue2(%this, %value) {
	Parent::setValue(%this, %value);
}

function unpunctuateTime(%time) {
	return stripChars(%time, ".:");
}
function punctuateTime(%time) {
	return getSubStr(%time, 0, 2) @ ":" @ getSubStr(%time, 2, 2) @ "." @ getSubStr(%time, 4, 3);
}

function unformatTime(%formatted) {
	%formatted = nextToken(%formatted, "minutes", ":");
	%ms = nextToken(%formatted, "seconds", ".");

	if (strlen(%ms) == 2)
		%ms *= 10;
	if (strlen(%ms) > 3)
		%ms = getSubStr(%ms, 0, 3);

	return add64_int(%ms + (%seconds * 1000), mult64_int(%minutes * 60, 1000));
}

Controls::addControl("GuiTextEditCtrl", "TimeEntryCtrl");
