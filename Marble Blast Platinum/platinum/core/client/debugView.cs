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

//-------------------------------------------------------
// Additional functionality for DebugView gui object
//-------------------------------------------------------
// Makes DebugView able to act like a mini console
//
// Todo:
// - Ability to monitor variables, or post changes to variables without bumping other lines
//

//$DebugView::UseTimeStamps = 1;

/**
 * @param {DebugView} %gui
 */
function DebugView::getTime(%gui) {
	%ret = "[" @ timeSinceLoad() @ "]: ";
	return %ret;
}

/**
 * @param {DebugView} %gui
 */
function DebugView::onAdd(%gui) {
	if (%gui.useTimeStamps $= "")
		%gui.useTimeStamps = 1;

	for (%i = 0; %i < %gui.getMaxLines(); %i++) {
		%gui.knownline[%i] = "";
		%gui.knowncolor[%i] = "";
	}
}

/**
 * @param {DebugView} %gui
 */
function DebugView::error(%gui, %string) {
	%gui.ConsoleBump(%string, %wipe, "0.9 0 0");
}

/**
 * @param {DebugView} %gui
 */
function DebugView::warn(%gui, %string) {
	%gui.ConsoleBump(%string, %wipe, "1.0 0.4 0.4");
}

/**
 * @param {DebugView} %gui
 */
function DebugView::echo(%gui, %string, %wipe, %color) {
	if (%color $= "")
		%color = "0 0 0";
	%gui.ConsoleBump(%string, %wipe, %color);
}

/**
 * @param {DebugView} %this
 */
function DebugView::success(%gui, %string, %wipe) {
	%gui.ConsoleBump(%string, %wipe, "0 0.6 0");
}

/**
 * @param {DebugView} %this
 */
function DebugView::clearAll(%gui) {
	%count = %gui.getMaxLines();
	for (%i = 0; %i < %count; %i++)
		%gui.setText(%i, "", "0 0 0");

	%gui.onAdd(); //quick hack to clear stored values
}

/**
 * @param {DebugView} %this
 */
function DebugView::consoleBump(%gui, %string, %wipe, %color) {
	if (%gui.useTimeStamps)
		%string = %gui.getTime() @ %string;

	%count = %gui.getMaxLines();

	if (%wipe) {
		%gui.clearAll();
		%gui.setText(0, %string, %color);
	} else {
		for (%i = 0; %i < %count; %i++) {
			%gui.KnownLine[%i] = %gui.KnownLine[%i+1];
			%gui.KnownColor[%i] = %gui.KnownColor[%i+1];
		}

		%gui.KnownLine[%count-1] = %string;
		%gui.KnownColor[%count-1] = %color;

		for (%i = 0; %i < %count; %i++) {
			%gui.setText(%i, %gui.KnownLine[%i], %gui.KnownColor[%i]);
		}
	}
}

/**
 * @param {DebugView} %this
 */
function DebugView::getMaxLines(%gui) {
	%y = getWord(%gui.extent, 1);

	%maxlines = mFloor((%y - 3) / 22);

	return %maxlines * 2 - 1;

	//4 to 11
	//12 to 16
	//17 to 25
}




