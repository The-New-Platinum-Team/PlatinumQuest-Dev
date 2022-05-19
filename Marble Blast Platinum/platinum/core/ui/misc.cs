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

//package CursorPack {
//
//function Canvas::setCursor(%this, %cursor)
//{
//Canvas.activeCursor = %cursor;
//deactivatePackage("CursorPack");
//Canvas.setCursor(%cursor);
//activatePackage("CursorPack");
//}
//};
//activatePackage("CursorPack");

if (getCompileTimeString() $= "Mar 19 2003 at 15:04:04")
	$Version::Blaster = true;

function shadow(%offset, %color) {
	if ($Version::Blaster)
		return "";
	if (%offset !$= "")
		%string = "<shadow:" @ getWord(%offset, 0) @ ":" @ getWord(%offset, 1) @ ">";
	if (%color !$= "") {
		%string = %string @ "<shadowcolor:" @ %color;
		//%string = %string @ baseDecimalToHex(getWord(%color, 0))
		//@ baseDecimalToHex(getWord(%color, 1))
		//@ baseDecimalToHex(getWord(%color, 2));
		//if (%alpha !$= "")
		//%string = %string @ baseDecimalToHex(%alpha);
		%string = %string @ ">";
	}
	return %string;
}

function Canvas::getCursor(%this) {
	//return %this.activeCursor;
	return DefaultCursor;
}

// Returns the lowest GUI object that isn't obstructed by other GUIs

function Canvas::getCursorContent(%this) {
	for (%i = %this.getCount() - 1; %i >= 0; %i --) {
		%active = %this.getObject(%i);
		%member = %active.cursorLowestMember();
		if (isObject(%member))
			return %member;
	}
}

function GuiControl::cursorLowestMember(%this, %offset) {
	if (%offset $= "")
		%offset = "0 0";  //0 0 is top left corner

	//Guis are layered from the bottom up, so start at the end of the list
	for (%i = %this.getCount()-1; %i > -1; %i--) {
		%obj = %this.getObject(%i);
		if (!%obj.isVisible())
			continue;
		if (%obj.isCursorOn()) {
			//The cursor is over this child gui,
			//and it has no children of its own; stop here.
			if (%obj.getCount() == 0) {
				if (%this.profile.modal && !%this.noHover)
					return %obj;
				//This gui is non-modal, can't hover it
				return -1;
			}
			//if it does have children, recursion time
			else {
				//If it doesn't have a selected child and is modal, go to the next one
				%lowest = %obj.cursorLowestMember(vectorAdd(%offset, %obj.position));
				if (isObject(%lowest))
					return %lowest;
			}
		}
	}
	//The cursor isn't over any of this gui's children
	if (%this.isCursorOn() && %this.profile.modal)
		return %this;
	//This gui is non-modal
	return -1;
}

function GuiControl::isHover(%this) {
	%content = Canvas._cursorContent;
	if (!isObject(%content) || !isObject(%this))
		return false;
	return %content.getId() == %this.getId();
}

// Save the calculated offset for this long (ms)
$_offdecaymax = 2000;

// Check whether the cursor is within the boundaries of a specific GUI

// function GuiControl::isCursorOn(%this, %offset, %extent) {
// 	if (%offset $= "") {
// 		if ($_offdecay[%this] && getRealTime() - $_offdecay[%this] > $_offdecaymax) {
// 			$_off[%this] = "";
// 			$_offdecay[%this] = 0;
// 		}
// 		if ($_off[%this] !$= "")
// 			%offset = $_off[%this];
// 		else {
// 			%obj = %this;
// 			while (true) {
// 				%group = %obj.getGroup();
// 				if (%group == -1) {
// 					warn(%this @ ".isCursorOn() - Gui is not active");
// 					return 0;
// 				}
// 				if (%group == Canvas.getID())
// 					break;
// 				%offset = vectorAdd(%offset, %group.position);
// 				%obj = %group;
// 			}

// 			$_off[%this] = %offset;
// 			$_offdecay[%this] = getRealTime();
// 		}
// 	}
// 	if (%extent $= "")
// 		%extent = %this.extent;
// 	if (getWord(%extent, 0) $= "-")
// 		%extent = setWord(%extent, 0, getWord(%this.extent, 0));
// 	if (getWord(%extent, 1) $= "-")
// 		%extent = setWord(%extent, 1, getWord(%this.extent, 1));

// 	%cursorPos = vectorAdd(Canvas.getCursorPos(), Canvas.getCursor().hotspot);
// 	%lowBound = vectorAdd(%this.position, %offset);
// 	%highBound = vectorAdd(%lowBound, %this.extent);
// 	%subtract = vectorSub(%this.extent, %extent);

// 	%cursorPosX = getWord(%cursorPos, 0);
// 	%cursorPosY = getWord(%cursorPos, 1);
// 	%lowBoundX = getWord(%lowBound, 0);
// 	%lowBoundY = getWord(%lowBound, 1);
// 	%highBoundX = getWord(%highBound, 0) - getWord(%subtract, 0);
// 	%highBoundY = getWord(%highBound, 1) - getWord(%subtract, 1);

// 	return (%cursorPosX >  %lowBoundX  &&
// 	        %cursorPosX <= %highBoundX &&
// 	        %cursorPosY >  %lowBoundY  &&
// 	        %cursorPosY <= %highBoundY);
// }

package CanvasHover {
	function onFrameAdvance(%delta) {
		Parent::onFrameAdvance(%delta);
		Canvas._cursorContent2 = Canvas.getMouseControl();
		Canvas._cursorContent = Canvas.getCursorContent();
	}
};
activatePackage(CanvasHover);

//-------------------------------------------------

//WTF why is this trying to happen
function SimGroup::getAbsolutePosition(%this) {
	return "0 0";
}

function GuiControl::getAbsolutePosition(%this) {
	if (!isObject(%this.getGroup())) {
		return "0 0";
	}
	return vectorAdd(%this.position, %this.getGroup().getAbsolutePosition());
}

// function GuiControl::getX(%gui) {
// 	return getWord(%gui.position, 0);
// }

// function GuiControl::getY(%gui) {
// 	return getWord(%gui.position, 1);
// }

// function GuiControl::getWidth(%gui) {
// 	return getWord(%gui.extent, 0);
// }

// function GuiControl::getHeight(%gui) {
// 	return getWord(%gui.extent, 1);
// }

// function GuiControl::setExtent(%gui, %extent) {
// 	if (%gui.extent $= %extent)
// 		return;
// 	%p1 = getWord(%gui.position, 0);
// 	%p2 = getWord(%gui.position, 1);
// 	%e1 = getWord(%extent, 0);
// 	%e2 = getWord(%extent, 1);

// 	%gui.resize(%p1, %p2, %e1, %e2);
// }

// function GuiControl::setWidth(%gui, %width) {
// 	if (getWord(%gui.extent, 0) $= %width)
// 		return;
// 	%p1 = getWord(%gui.position, 0);
// 	%p2 = getWord(%gui.position, 1);
// 	%e1 = %width;
// 	%e2 = getWord(%gui.extent, 1);

// 	%gui.resize(%p1, %p2, %e1, %e2);
// }

// function GuiControl::setHeight(%gui, %height) {
// 	if (getWord(%gui.extent, 1) $= %height)
// 		return;
// 	%p1 = getWord(%gui.position, 0);
// 	%p2 = getWord(%gui.position, 1);
// 	%e1 = getWord(%gui.extent, 0);
// 	%e2 = %height;

// 	%gui.resize(%p1, %p2, %e1, %e2);
// }

// function GuiControl::setPosition(%gui, %position) {
// 	if (%gui.position $= %position)
// 		return;

// 	%p1 = getWord(%position, 0);
// 	%p2 = getWord(%position, 1);
// 	%e1 = getWord(%gui.extent, 0);
// 	%e2 = getWord(%gui.extent, 1);

// 	%gui.resize(%p1, %p2, %e1, %e2);
// }
