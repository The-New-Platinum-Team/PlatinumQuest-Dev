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
// Cursor Control
//------------------------------------------------------------------------------

$cursorControlled = true;

function cursorOff() {
	if ($cursorControlled)
		lockMouse(true);
	Canvas.cursorOff();
}

function cursorOn() {
	if ($cursorControlled)
		lockMouse(false);
	Canvas.cursorOn();
	Canvas.setCursor(DefaultCursor);
}

// In the CanvasCursor package we add some additional functionality to the
// built-in GuiCanvas class, of which the global Canvas object is an instance.
// In this case, the behavior we want is for the cursor to automatically display,
// except when the only guis visible want no cursor - most notably,
// in the case of the example, the play gui.
// In order to override or extend an existing class, we use the script package
// feature.

package CanvasCursor {

// The checkCursor method iterates through all the root controls on the canvas
// (basically the content control and any visible dialogs).  If all of them
// have the .noCursor attribute set, the cursor is turned off, otherwise it is
// turned on.

	/**
	 * @param {GuiCanvas} %this
	 */
	function GuiCanvas::checkCursor(%this) {
		%cursorShouldBeOn = false;
		for (%i = 0; %i < %this.getCount(); %i++) {
			%control = %this.getObject(%i);
			if (%control.getName() $= "RootGui")
				continue;
			if (%control.noCursor $= "") {
				%cursorShouldBeOn = true;
				break;
			}
		}
		if (%cursorShouldBeOn != %this.isCursorOn()) {
			if (%cursorShouldBeOn)
				cursorOn();
			else
				cursorOff();
		}
	}

// below, all functions which can alter which content controls are visible
// are extended to call the checkCursor function.  For package'd functions,
// the Parent:: call refers to the original implementation of that function,
// or a version that was declared in a previously activated package.
// In this case the parent calls should point to the built in versions
// of GuiCanvas functions.

	/**
	 * @param {GuiCanvas} %this
	 * @param {GuiControl} %ctrl
	 */
	function GuiCanvas::setContent(%this, %ctrl) {
		Parent::setContent(%this, %ctrl);
		%this.checkCursor();
		trackGuiOpen(%ctrl);
	}

	/**
	 * @param {GuiCanvas} %this
	 * @param {GuiControl} %ctrl
	 */
	function GuiCanvas::pushDialog(%this, %ctrl) {
		Parent::pushDialog(%this, %ctrl);
		%this.checkCursor();
		trackGuiOpen(%ctrl);
	}

	/**
	 * @param {GuiCanvas} %this
	 * @param {GuiControl} %ctrl
	 */
	function GuiCanvas::popDialog(%this, %ctrl) {
		Parent::popDialog(%this, %ctrl);
		%this.checkCursor();
	}

	/**
	 * @param {GuiCanvas} %this
	 */
	function GuiCanvas::popLayer(%this, %layer) {
		Parent::popLayer(%this, %layer);
		%this.checkCursor();
	}

	/**
	 * @param {GuiCanvas} %this
	 */
	function GuiCanvas::repaint(%this) {
		//So we can find this in trace logs
		Parent::repaint(%this);
	}

};

// activate the package when the script loads.
activatePackage(CanvasCursor);