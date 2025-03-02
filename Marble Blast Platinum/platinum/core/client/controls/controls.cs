//-----------------------------------------------------------------------------
// Custom Controls Library
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

function initControls() {
	exec("./timeEntryCtrl.cs");
}

function Controls::addControl(%class, %name) {
	if ($Controls[%class] $= "") {
		Controls::addClass(%class);
	}
	if ($Controls[%class, %name])
		return;

	$Controls[%class, $Controls[%class]] = %name;
	$Controls[%class, %name] = true;
	$Controls[%class] ++;

	if (isPackage(%name)) {
		activatePackage(%name);
	}
}

function Controls::addClass(%class) {
	$Controls[%class] = 0;
}

function Controls::check(%ctrl) {
	//Check anything it could be
	%classes = %ctrl.getParentClasses();
	for (%i = 0; %i < getFieldCount(%classes); %i ++) {
		%class = getField(%classes, %i);

		//Find all custom controls for its class
		for (%j = 0; %j < $Controls[%class]; %j ++) {
			%control = $Controls[%class, %j];
			//If it has the field, it gets the control
			if (%ctrl.getFieldValue(%control)) {
				call(%control, %ctrl, %ctrl.getFieldValue(%control));
			}
		}
	}
}

function GuiControl::onAdd(%this) {
	Controls::check(%this);
}
