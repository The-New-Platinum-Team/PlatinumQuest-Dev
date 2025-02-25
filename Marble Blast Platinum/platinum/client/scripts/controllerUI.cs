//-----------------------------------------------------------------------------
// Navigate the interface with a controller
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

//-----------------------------------------------------------------------------
// Button actions (mapped to xbox 360 controller)
//
// Button #  Xbox 360  Action1  Action2 | Xbox One  Action1  Action2
// button0:  A         Select           | A         Select
// button1:  B         Cancel           | B         Cancel
// button2:  X         Alt1             | X         Alt1
// button3:  Y         Alt2             | Y         Alt2
// button4:  LB        LB       Left    | LB        LB       Left
// button5:  RB        RB       Right   | RB        RB       Right
// button6:  LS        LS               | LS        LS
// button7:  RS        RS               | RS        RS
// button8:  Start     Alt3             | Select    Alt3
// button9:  Back      Alt4             | Options   Alt4
// button10: Guide     Alt5             | Guide     Alt5
// button11: DUp       DUp      Up      | DUp       DUp      Up
// button12: DDown     DDown    Down    | DDown     DDown    Down
// button13: DLeft     DLeft    Left    | DLeft     DLeft    Left
// button14: DRight    DRight   Right   | DRight    DRight   Right
//-----------------------------------------------------------------------------
// Button #  PS4        Action1  Action2
// button0:  Square     Alt2
// button1:  Cross      Select
// button2:  Circle     Cancel
// button3:  Triangle   Alt1
// button4:  L1         LB       Left
// button5:  R1         RB       Right
// button6:  L2
// button7:  R2
// button8:  Share      Alt3
// button9:  Options    Alt4
// button10: L3         LS
// button11: R3         RS
// button12: PSN        Alt5
// button13: Touchpad   Alt6
// button14: DUp        DUp      Up
// button15: DDown      DDown    Down
// button16: DLeft      DLeft    Left
// button17: DRight     DRight   Right
//-----------------------------------------------------------------------------

// (Most) Controller joystick mappings
// xaxis:  XAxis    LSRight   Right   LSLeft   Left
// rxaxis: RXAxis   RSRight   Right   RSLeft   Left
// yaxis:  YAxis    LSDown    Down    LSUp     Up
// ryaxis: RYAxis   RSDown    Down    RSUp     Up
// zaxis:  LT       Left     (RT      Right  with DirectInput)
// rzaxis: RT       Right
//-----------------------------------------------------------------------------

//Axes will do a 'make' event after going this far, otherwise it's a 'break'
$Controller::JoystickMakeValue = 0.8;

//Override the canvas methods so we can update when the window changes
package ControllerUI {
	function RootGui::setContent(%this, %ctrl) {
		ControllerGui.saveControls();
		Canvas.popDialog(ControllerGui);
		Parent::setContent(%this, %ctrl);
		Canvas.detectControls(true);
	}

	function GuiCanvas::pushDialog(%this, %ctrl) {
		//Ignore ControllerGui
		if (%ctrl.getId() == ControllerGui.getId()) {
			Parent::pushDialog(%this, %ctrl);
			return;
		}

		ControllerGui.saveControls();
		Parent::pushDialog(%this, %ctrl);
		%this.detectControls(true);
	}

	function GuiCanvas::popDialog(%this, %ctrl) {
		//Ignore ControllerGui
		if (%ctrl.getId() == ControllerGui.getId()) {
			Parent::popDialog(%this, %ctrl);
			return;
		}

		ControllerGui.saveControls();
		Parent::popDialog(%this, %ctrl);
		%this.detectControls(false);
	}

	function GuiCanvas::popLayer(%this, %layer) {
		ControllerGui.saveControls();
		Parent::popLayer(%this, %layer);
		%this.detectControls(false);
	}
};

function GuiCanvas::detectControls(%this, %needPush) {
	//Recursion protection
	if (%this.detectingControls)
		return;
	%this.detectingControls = true;

	//Go backwards so we get the topmost gui
	for (%i = %this.getCount() - 1; %i >= 0; %i --) {
		%window = %this.getObject(%i);
		//Ignore some stuff like ControllerGui
		if (%window.noControls)
			continue;

		//We're already displaying on this window, so we're good
		if (isObject(%this.controlWindow) && %this.controlWindow.getId() == %window.getId()) {
			//Disable on some stuff like the console
			if (!%window.disableControls && %needPush) {
				%window.enableControls();
			}
			%this.detectingControls = false;
			return;
		}
		//Disable the active window
		if (isObject(%this.controlWindow))
			%this.controlWindow.disableControls();

		//Disable on some stuff like the console
		%this.controlWindow = %window;
		if (%window.disableControls) {
			%this.detectingControls = false;
			return;
		}

		//And then enable on the new one
		%window.enableControls();
		%this.detectingControls = false;
		return;
	}
}

function ControllerGui::saveControls(%this) {
	if (isObject(%this.root) && isObject(%this.control)) {
		%this.root._lastControl = %this.control;
	}
}

function GuiControl::enableControls(%this) {
	Canvas.pushDialog(ControllerGui);

	%control = (isObject(%this.defaultControl) ? %this.defaultControl : %this._lastControl);

	ControllerGui.setRoot(%this);
	ControllerGui.selectControl(%control);
}

function GuiControl::disableControls(%this) {
	Canvas.popDialog(ControllerGui);
}

function GuiControl::isBeingControlled(%this) {
	return isObject(ControllerGui.root) && ControllerGui.root.getId() == %this.getId();
}

function ControllerGui::setRoot(%this, %root) {
	%this.root = %root;
}

function ControllerGui::isJoystick(%this) {
	return $pref::Input::ControlDevice $= "Joystick";
}

function ControllerGui::selectControl(%this, %control) {
	if (!%this.isAwake()) {
		Canvas.pushDialog(%this);
	}
	Canvas.pushToBack(%this);

	%this.control = %control;

	//Update scroll views
	if (isObject(%control)) {
		%box = %this.control.getScrollVisibleBox();
		%origin = getWords(%box, 0, 1);
		%extent = getWords(%box, 2, 3);
		%this.updateScroll(%control, %origin, %extent);
	}
	%this.updateHighlight();
	%this.updateButtons();
}

function ControllerGui::updateScroll(%this, %base, %pos, %extent) {
	%parent = %base.getGroup();
	if (!isObject(%parent) || !isObject(%base))
		return;
	if (%parent.getClassName() $= "GuiScrollCtrl") {
		//Scroll on the X axis
		%left = getWord(%pos, 0);
		%right = %left + getWord(%extent, 0);

		%vLeft = -getWord(%base.position, 0);
		%vRight = %vLeft + getWord(%parent.extent, 0);

		if (%left < %vLeft) {
			%base.setPosition(-%left SPC getWord(%base.position, 1));
		}
		if (%right > %vRight) {
			%base.setPosition((getWord(%parent.extent, 0) - %right) SPC getWord(%base.position, 1));
		}

		//Scroll on the Y axis
		%bottom = getWord(%pos, 1);
		%top = %bottom + getWord(%extent, 1);

		%vBottom = -getWord(%base.position, 1);
		%vTop = %vBottom + getWord(%parent.extent, 1);

		if (%bottom < %vBottom) {
			%base.setPosition(getWord(%base.position, 0) SPC -%bottom);
		}
		if (%top > %vTop) {
			%base.setPosition(getWord(%base.position, 0) SPC (getWord(%parent.extent, 1) - %top));
		}
	} else if (%parent.getClassName() !$= "GuiCanvas") {
		%this.updateScroll(%parent, VectorAdd(%base.position, %pos), %extent);
	}
}

function ControllerGui::updateHighlight(%this) {
	cancelIgnorePause(%this.highlightSch);
	if (!%this.isJoystick()) {
		ControllerHighlight.setVisible(false);
		return;
	}

	if (isObject(%this.control)) {
		%box = %this.control.getControlBox();
		%origin = getWords(%box, 0, 1);
		%extent = getWords(%box, 2, 3);

		ControllerHighlight.setVisible(true);
		ControllerHighlight.setPosition(%origin);
		ControllerHighlight.setExtent(%extent);
	} else {
		ControllerHighlight.setVisible(false);
	}

	%this.highlightSch = %this.scheduleIgnorePause(100, updateHighlight);
}

function GuiControl::getControlBox(%this) {
	//Top left pixel of the control
	%origin = %this.getAbsolutePosition();
	if (%this.controlOffset !$= "")
		%origin = VectorAdd(%origin, %this.controlOffset);
	//Visible extent
	%extent = %this.getExtent();
	if (%this.controlExtent !$= "")
		%extent = %this.controlExtent;
	//Some stuff needs padding
	%padding = ControllerGui.customControlPadding[%this.getClassName()];
	if (%padding !$= "") {
		%origin = VectorSub(%origin, %padding SPC %padding);
		%extent = VectorAdd(%extent, (%padding * 2) SPC (%padding * 2));
	}

	return getWords(%origin, 0, 1) SPC getWords(%extent, 0, 1);
}

function GuiControl::getScrollVisibleBox(%this) {
	return "0 0" SPC %this.extent;
}

function ControllerGui::updateButtons(%this) {
	%this.clearActionButtons();

	//Find anything we can do from here
	%buttons = "button0 button1 button2 button3 button4 button5 button6 button7 button8 button9 button10 button11 button12 button13 button14 button15 button16 button17 button18 button19 button20 button21 button22 button23 button24 button25 button26 button27 button28 button29 button30 button31";
	%axes = "xaxis XAxis XAxis\txaxis LSLeft LSLeft Left\txaxis LSRight LSRight Right\trxaxis RXAxis RXAxis \trxaxis RSLeft RSLeft Left\trxaxis RSRight RSRight Right\tyaxis YAxis YAxis \tyaxis LSDown LSDown Down\tyaxis LSUp LSUp Up\tryaxis RYAxis RYAxis \tryaxis RSDown RSDown Down\tryaxis RSUp RSUp Up\tzaxis zaxis LT Left\trzaxis rzaxis RT Right\tzaxis zaxis LT Left\trzaxis rzaxis RT Right";
	%name = getJoystickName(%joy);

	%axisButtons = Array(ControllerAxisButtons);

	for (%i = 0; %i < getWordCount(%buttons); %i ++) {
		%event = getWord(%buttons, %i);
		%action1 = "";
		%action2 = "";
		if ($Controller::Action1[%name, %event] !$= "") {
			%action1 = $Controller::Action1[%name, %event];
			%action2 = $Controller::Action2[%name, %event];
		} else if ($Controller::Action1[%event] !$= "") {
			%action1 = $Controller::Action1[%event];
			%action2 = $Controller::Action2[%event];
		} else {
			%action1 = %event;
		}
		%info = %this.getActionInfo(%action1, %action2);
		%handler = getField(%info, 0);
		%action  = getField(%info, 1);
		%name    = getField(%info, 2);
		if (%name !$= "") {
			if (%axisButtons.containsEntryAtRecord(%event, 1) && getRecord(%axisButtons.getEntryByRecord(%event, 1), 2) $= %name) {
				continue;
			}
			%axisButtons.addEntry(%handler NL %event NL %name);
		}
	}
	for (%i = 0; %i < getFieldCount(%axes); %i ++) {
		%event = getWord(getField(%axes, %i), 0);
		%bitmap = getWord(getField(%axes, %i), 1);
		%action1 = getWord(getField(%axes, %i), 2);
		%action2 = getWord(getField(%axes, %i), 3);
		%info = %this.getActionInfo(%action1, %action2);
		%handler = getField(%info, 0);
		%action  = getField(%info, 1);
		%name    = getField(%info, 2);
		if (%name !$= "") {
			if (%axisButtons.containsEntryAtRecord(%event, 1) && getRecord(%axisButtons.getEntryByRecord(%event, 1), 2) $= %name) {
				continue;
			}
			%axisButtons.addEntry(%handler NL %bitmap NL %name);
		}
	}
	%axisButtons.sort(sortActionEvents);

	for (%i = 0; %i < %axisButtons.getSize(); %i ++) {
		%event = %axisButtons.getEntry(%i);
		%this.addActionButton(getRecord(%event, 1), getRecord(%event, 2));
	}

	%axisButtons.delete();
}

function sortActionEvents(%a, %b) {
	return getRecord(%a, 0).getId() > getRecord(%b, 0).getId();
}

function ControllerGui::clearActionButtons(%this) {
	%this.actionStart = 0;
	ControllerButtons.clear();
}

function ControllerGui::addActionButton(%this, %event, %name) {
	%bitmap = getJoystickBindingBitmap("joystick0" TAB %event);
	if (!isBitmap(%bitmap)) {
		%bitmap = %bitmap @ "_n";
	}
	ControllerButtons.add(new GuiBitmapCtrl() {
		profile = "GuiDefaultProfile";
		horizSizing = "bottom";
		vertSizing = "right";
		position = (0 + %this.actionStart) SPC 0;
		extent = "37 25";
		minExtent = "8 8";
		visible = "1";
		helpTag = "0";
		bitmap = %bitmap;
	});
	ControllerButtons.add(%text = new GuiTextCtrl() {
		profile = "GuiControllerButtonsTextProfile";
		horizSizing = "bottom";
		vertSizing = "right";
		position = (37 + %this.actionStart) SPC -4;
		extent = "37 25";
		minExtent = "8 8";
		visible = "1";
		helpTag = "0";
		text = %name;
	});

	%this.actionStart = getWord(%text.position, 0) + getWord(%text.extent, 0) + 5;
}

//-----------------------------------------------------------------------------
// Custom methods for various controls
//-----------------------------------------------------------------------------

function GuiSliderCtrl::RSRight(%this) {
	if (%this.variable !$= "") {
		%tick = %this.getJoyTickSize();
		%lower = getWord(%this.range, 0);
		%upper = getWord(%this.range, 1);
		%val = getVariable(%this.variable);

		%val += %tick;
		if (%val > %upper)
			%val = %upper;
		if (%val < %lower)
			%val = %lower;

		setVariable(%this.variable, %val);
		%this.setValue(%val);

		$ThisControl = %this;
		eval(%this.altCommand);
		return true;
	}
}
function GuiSliderCtrl::RSLeft(%this) {
	if (%this.variable !$= "") {
		%tick = %this.getJoyTickSize();
		%lower = getWord(%this.range, 0);
		%upper = getWord(%this.range, 1);
		%val = getVariable(%this.variable);

		%val -= %tick;
		if (%val > %upper)
			%val = %upper;
		if (%val < %lower)
			%val = %lower;

		setVariable(%this.variable, %val);
		%this.setValue(%val);

		$ThisControl = %this;
		eval(%this.altCommand);
		return true;
	}
}

//-----------------------------------------------------------------------------

function GuiScrollCtrl::Up(%this) {
	if (%this.vScrollBar $= "alwaysOff") {
		return false;
	}
	%stepSize = mClamp(getWord(%this.extent, 1) / 10, 20, 100);
	%this.getObject(0).setPosition(VectorAdd(%this.getObject(0).position, "0 " @ %stepSize));
	return true;
}

function GuiScrollCtrl::Down(%this) {
	if (%this.vScrollBar $= "alwaysOff") {
		return false;
	}
	%stepSize = mClamp(getWord(%this.extent, 1) / 10, 20, 100);
	%this.getObject(0).setPosition(VectorAdd(%this.getObject(0).position, "0 -" @ %stepSize));
	return true;
}

function GuiScrollCtrl::Left(%this) {
	if (%this.hScrollBar $= "alwaysOff") {
		return false;
	}
	%stepSize = mClamp(getWord(%this.extent, 0) / 10, 20, 100);
	%this.getObject(0).setPosition(VectorAdd(%this.getObject(0).position, %stepSize @ " 0"));
	return true;
}

function GuiScrollCtrl::Right(%this) {
	if (%this.hScrollBar $= "alwaysOff") {
		return false;
	}
	%stepSize = mClamp(getWord(%this.extent, 0) / 10, 20, 100);
	%this.getObject(0).setPosition(VectorAdd(%this.getObject(0).position, "-" @ %stepSize @ " 0"));
	return true;
}

//-----------------------------------------------------------------------------

function GuiRadioCtrl::Select(%this) {
	if (!%this.isActive()) {
		return false;
	}
	%this.setValue(!%this.getValue());
	$ThisControl = %this;
	eval(%this.command);
	return true;
}

//-----------------------------------------------------------------------------

function GuiCheckBoxCtrl::Select(%this) {
	if (!%this.isActive()) {
		return false;
	}
	%this.setValue(!%this.getValue());
	$ThisControl = %this;
	eval(%this.command);
	return true;
}

//-----------------------------------------------------------------------------

function GuiTextListCtrl::getControlBox(%this) {
	if (%this._selecting) {
		%offset = %this.getRowOrigin(%this._selectedRow);

		//Top left pixel of the control
		%origin = %this.getAbsolutePosition();
		%origin = VectorAdd(%origin, %offset);
		//Visible extent
		%extent = %this.getRowSize();
		//Some stuff needs padding
		%padding = ControllerGui.customControlPadding[%this.getClassName()];
		if (%padding !$= "") {
			%origin = VectorSub(%origin, %padding SPC %padding);
			%extent = VectorAdd(%extent, (%padding * 2) SPC (%padding * 2));
		}

		return getWords(%origin, 0, 1) SPC getWords(%extent, 0, 1);
	} else {
		return %this.getGroup().getControlBox();
	}
}

function GuiTextListCtrl::getScrollVisibleBox(%this) {
	if (%this._selecting) {
		%offset = %this.getRowOrigin(%this._selectedRow);
	} else {
		%offset = %this.getRowOrigin(%this.getRowNumById(%this.getSelectedId()));
	}
	%extent = %this.getRowSize();

	return %offset SPC %extent;
}

function GuiTextListCtrl::Select(%this) {
	if (%this._selecting) {
		%this.controlUp = %this._controlUp;
		%this.controlDown = %this._controlDown;
		%this._controlUp = "";
		%this._controlDown = "";

		%this._selecting = false;
		%this.setSelectedRow(%this._selectedRow);
	} else {
		%this._controlUp = %this.controlUp;
		%this._controlDown = %this.controlDown;
		%this.controlUp = "";
		%this.controlDown = "";

		%this._selecting = true;
		%selectedRow = %this.getSelectedId();
		%index = %selectedRow == -1 ? 0 : %this.getRowNumById(%selectedRow);
		%this._selectedRow = %index;
	}
	ControllerGui.updateScroll(%this, %this.getRowOrigin(%this._selectedRow), %this.getRowSize());
	return true;
}

function GuiTextListCtrl::Cancel(%this) {
	if (%this._selecting) {
		%this.controlUp = %this._controlUp;
		%this.controlDown = %this._controlDown;
		%this._controlUp = "";
		%this._controlDown = "";

		%this._selecting = false;
		return true;
	}
	return false;
}

function GuiTextListCtrl::Up(%this) {
	if (%this._selecting) {
		%index = %this._selectedRow;
		%index --;
		if (%index >= 0) {
			%this._selectedRow = %index;
		}
		ControllerGui.updateScroll(%this, %this.getRowOrigin(%this._selectedRow), %this.getRowSize());
		return true;
	}
	return false;
}

function GuiTextListCtrl::Down(%this) {
	if (%this._selecting) {
		%index = %this._selectedRow;
		%index ++;
		if (%index < %this.rowCount()) {
			%this._selectedRow = %index;
		}
		ControllerGui.updateScroll(%this, %this.getRowOrigin(%this._selectedRow), %this.getRowSize());
		return true;
	}
	return false;
}

function GuiTextListCtrl::RSUp(%this) {
	%selected = %this.getSelectedId();
	%index = (%selected == -1 ? 0 : (%this.getRowNumById(%selected) - 1));
	if (%index >= 0) {
		%this._selectedRow = %index;
		%this.setSelectedRow(%index);
		ControllerGui.updateScroll(%this, %this.getRowOrigin(%index), %this.getRowSize());
		return true;
	}
	return false;
}

function GuiTextListCtrl::RSDown(%this) {
	%selected = %this.getSelectedId();
	%index = (%selected == -1 ? 0 : (%this.getRowNumById(%selected) + 1));
	if (%index < %this.rowCount()) {
		%this._selectedRow = %index;
		%this.setSelectedRow(%index);
		ControllerGui.updateScroll(%this, %this.getRowOrigin(%index), %this.getRowSize());
		return true;
	}
	return false;
}

function GuiTextListCtrl::getRowOrigin(%this, %num) {
	%pos = %this.profile.fontSize + 4;

	return "0" SPC %pos * %num;
}

function GuiTextListCtrl::getRowSize(%this) {
	return getWord(%this.extent, 0) SPC (%this.profile.fontSize + 4);
}

//-----------------------------------------------------------------------------
// Controller actions interface
//-----------------------------------------------------------------------------

function enableControllerUI() {
	activatePackage(ControllerUI);
	Canvas.detectControls();
	ControllerUIMap.push();

	//Apparently windows uses this variable
	if ($Pref::EnableDirectInput)
		$enableDirectInput = "1";
	//Tell the engine to turn on joystick support
	activateDirectInput();
	enableJoystick();
}

function disableControllerUI() {
	deactivatePackage(ControllerUI);
	if (isObject(ControllerGui.root))
		ControllerGui.root.disableControls();
	ControllerUIMap.pop();

	//Apparently windows uses this variable
	if ($Pref::EnableDirectInput)
		$enableDirectInput = "0";
	//Tell the engine to shut off joystick support
	deactivateDirectInput();
	disableJoystick();
}

function hideControllerUI() {
	if (isObject(ControllerGui.root))
		ControllerGui.root.disableControls();
	ControllerUIMap.pop();
	ControllerGui.hide = true;
}

function showControllerUI() {
	Canvas.detectControls();
	ControllerUIMap.push();
	ControllerGui.hide = false;

	Canvas.pushToBack(ControllerGui);
}

function ControllerGui::action(%this, %action1, %action2, %value, %make) {
	if ($debugInput) {
		echo("ACTION:" SPC %action1 SPC %action2 SPC %value SPC %make);
	}

	if (%make $= "") {
		// Neither make nor break (immediate)
		%this.doAction(%action1, %action2, %value);
		return;
	}

	%this.stopRepeat(%action1, %action2, %value);
	if (%make) {
		%repeat = %this.doAction(%action1, %action2, %value);

		if (%repeat) {
			%this.startRepeat(%action1, %action2, %value);
		}
	}
}

function ControllerGui::startRepeat(%this, %action1, %action2, %value) {
	%this.repeatPeriod[%action1, %action2] = 450;
	%this.repeatTimer[%action1, %action2] = %this.schedule(%this.repeatPeriod[%action1, %action2], repeat, %action1, %action2, %value);
}

function ControllerGui::stopRepeat(%this, %action1, %action2, %value) {
	cancel(%this.repeatTimer[%action1, %action2]);
}

function ControllerGui::repeat(%this, %action1, %action2, %value) {
	cancel(%this.repeatTimer[%action1, %action2]);
	if (%this.doAction(%action1, %action2, %value)) {
		%this.repeatPeriod[%action1, %action2] = max(%this.repeatPeriod[%action1, %action2] * 0.9, 200);
		%this.repeatTimer[%action1, %action2] = %this.schedule(%this.repeatPeriod[%action1, %action2], repeat, %action1, %action2, %value);
	}
}

function ControllerGui::doAction(%this, %action1, %action2, %value) {
	//Action 1 gets priority always
	if (%action1 !$= "") {
		if (isObject(%this.control) && %this.customCommand[%this.control.getClassName(), %action1]) {
			if (%this.control.call(%action1)) {
				return %this.customCommandRepeat[%this.control.getClassName(), %action1];
			}
		}
		if (isObject(%this.control) && isObject(%this.control.getFieldValue("control" @ %action1))) {
			%this.selectControl(%this.control.getFieldValue("control" @ %action1));
			return true;
		}
		if (isObject(%this.control) && %this.control.getFieldValue("command" @ %action1) !$= "") {
			$ThisControl = %this.control;
			eval(%this.control.getFieldValue("command" @ %action1));
			return %this.control.getFieldValue("commandRepeat" @ %action1);
		}
		//If the root has an override for this then let them get it
		if (isObject(%this.root) && isObject(%this.root.getFieldValue("control" @ %action1))) {
			%this.selectControl(%this.root.getFieldValue("control" @ %action1));
			return true;
		}
		if (isObject(%this.root) && %this.root.getFieldValue("command" @ %action1) !$= "") {
			$ThisControl = %this.root;
			eval(%this.root.getFieldValue("command" @ %action1));
			return %this.root.getFieldValue("commandRepeat" @ %action1);
		}
	}

	//Action 2 if nothing is found for 1
	if (%action2 !$= "") {
		if (isObject(%this.control) && %this.customCommand[%this.control.getClassName(), %action2]) {
			if (%this.control.call(%action2)) {
				return %this.customCommandRepeat[%this.control.getClassName(), %action2];
			}
		}
		if (isObject(%this.control) && isObject(%this.control.getFieldValue("control" @ %action2))) {
			%this.selectControl(%this.control.getFieldValue("control" @ %action2));
			return true;
		}
		if (isObject(%this.control) && %this.control.getFieldValue("command" @ %action2) !$= "") {
			$ThisControl = %this.control;
			eval(%this.control.getFieldValue("command" @ %action2));
			return %this.control.getFieldValue("commandRepeat" @ %action2);
		}
		//If the root has an override for this then let them get it
		if (isObject(%this.root) && isObject(%this.root.getFieldValue("control" @ %action2))) {
			%this.selectControl(%this.root.getFieldValue("control" @ %action2));
			return true;
		}
		if (isObject(%this.root) && %this.root.getFieldValue("command" @ %action2) !$= "") {
			$ThisControl = %this.root;
			eval(%this.root.getFieldValue("command" @ %action2));
			return %this.root.getFieldValue("commandRepeat" @ %action2);
		}
	}

	//Specials
	if (isObject(%this.control) && %this.control.isActive() && (%action1 $= "Select" || %action2 $= "Select") && (%this.control.command !$= "")) {
		$ThisControl = %this.control;
		eval(%this.control.command);
		return %this.control.commandRepeat || (%this.control.buttonType $= "RepeaterButton");
	}
	if (isObject(%this.root) && (%action1 $= "Cancel" || %action2 $= "Cancel") && (%this.root.cancelCommand !$= "")) {
		$ThisControl = %this.root;
		eval(%this.root.cancelCommand);
		return %this.root.commandRepeat || (%this.root.buttonType $= "RepeaterButton");
	}

	return false;
}

function ControllerGui::getActionInfo(%this, %action1, %action2) {
	if ($debugInput) {
		echo("getActionInfo " @ %action1 SPC %action2);
	}

	//Action 1 gets priority always
	if (%action1 !$= "") {
		if (isObject(%this.control) && isObject(%this.control.getFieldValue("control" @ %action1))) {
			return %this.control TAB %action1 TAB %this.getControlName(%this.control, %action1);
		}
		if (isObject(%this.control) && %this.control.getFieldValue("command" @ %action1) !$= "") {
			return %this.control TAB %action1 TAB %this.getCommandName(%this.control, %action1);
		}
		if (isObject(%this.control) && %this.customCommand[%this.control.getClassName(), %action1]) {
			return %this.control TAB %action1 TAB %this.customCommandName[%this.control.getClassName(), %action1];
		}
		//If the root has an override for this then let them get it
		if (isObject(%this.root) && isObject(%this.root.getFieldValue("control" @ %action1))) {
			return %this.root TAB %action1 TAB %this.getControlName(%this.root, %action1);
		}
		if (isObject(%this.root) && %this.root.getFieldValue("command" @ %action1) !$= "") {
			return %this.root TAB %action1 TAB %this.getCommandName(%this.root, %action1);
		}
	}

	//Action 2 if nothing is found for 1
	if (%action2 !$= "") {
		if (isObject(%this.control) && isObject(%this.control.getFieldValue("control" @ %action2))) {
			return %this.control TAB %action2 TAB %this.getControlName(%this.control, %action2);
		}
		if (isObject(%this.control) && %this.control.getFieldValue("command" @ %action2) !$= "") {
			return %this.control TAB %action2 TAB %this.getCommandName(%this.control, %action2);
		}
		if (isObject(%this.control) && %this.customCommand[%this.control.getClassName(), %action2]) {
			return %this.control TAB %action2 TAB %this.customCommandName[%this.control.getClassName(), %action2];
		}
		//If the root has an override for this then let them get it
		if (isObject(%this.root) && isObject(%this.root.getFieldValue("control" @ %action2))) {
			return %this.root TAB %action2 TAB %this.getControlName(%this.root, %action2);
		}
		if (isObject(%this.root) && %this.root.getFieldValue("command" @ %action2) !$= "") {
			return %this.root TAB %action2 TAB %this.getCommandName(%this.root, %action2);
		}
	}

	//Specials
	if (isObject(%this.control) && %this.control.isActive() && %action1 $= "Select" && (%this.control.command !$= "")) {
		return %this.control TAB %action1 TAB "Select";
	}
	if (isObject(%this.control) && %this.control.isActive() && %action2 $= "Select" && (%this.control.command !$= "")) {
		return %this.control TAB %action2 TAB "Select";
	}
	if (isObject(%this.root) && %action1 $= "Cancel" && (%this.root.cancelCommand !$= "")) {
		return %this.root TAB %action1 TAB "Cancel";
	}
	if (isObject(%this.root) && %action2 $= "Cancel" && (%this.root.cancelCommand !$= "")) {
		return %this.root TAB %action2 TAB "Cancel";
	}

	return "";
}

function ControllerGui::getControlName(%this, %control, %action) {
	if ($debugInput) {
		echo("getControlName " @ %control SPC %action);
	}
	%newControl = %control.getFieldValue("control" @ %action);
	if (%newControl.name !$= "") {
		return %newControl.name;
	}
	if (%control.controlName[%newControl] !$= "") {
		return %control.controlName[%newControl];
	}
	if (%control.controlName[%action] !$= "") {
		return %control.controlName[%action];
	}
	return "";
}

function ControllerGui::getCommandName(%this, %control, %action) {
	if ($debugInput) {
		echo("getCommandName " @ %control SPC %action);
	}
	if (%control.commandName[%action] !$= "") {
		return %control.commandName[%action];
	}
	return "";
}

//Bind all the events
if (isObject(ControllerUIMap))
	ControllerUIMap.delete();
new ActionMap(ControllerUIMap);

//This is everything Torque supports
$Controller::Events["JoyButton"] = "button0 button1 button2 button3 button4 button5 button6 button7 button8 button9 button10 button11 button12 button13 button14 button15 button16 button17 button18 button19 button20 button21 button22 button23 button24 button25 button26 button27 button28 button29 button30 button31";
$Controller::Events["JoyAxis"]   = "xaxis yaxis zaxis rxaxis ryaxis rzaxis xpov ypov upov dpov lpov rpov xpov2 ypov2 upov2 dpov2 lpov2 rpov2";

function ControllerGui::buildEvents(%this, %category) {
	//For all joysticks that we have connected, create events
	for (%joy = 0; getJoystickAxes(%joy) !$= ""; %joy ++) {
		%device = "joystick" @ %joy;
		//Create for every word in the input string
		for (%i = 0; %i < getWordCount($Controller::Events[%category]); %i ++) {
			%event = getWord($Controller::Events[%category], %i);
			//function __cui0JoyButtonbutton0(%val) { ControllerGui.event("0", "JoyButton", "button0", %val); }
			eval("function __cui" @ %joy @ %category @ %event @ "(%val) {ControllerGui.event(\"" @ %joy @ "\", \"" @ %category @ "\", \"" @ %event @ "\", %val);}");
			ControllerUIMap.bind(%device, %event, "__cui" @ %joy @ %category @ %event);
			%this.eventValue[%joy, %category, %event] = 0;
		}
	}
}

ControllerGui.buildEvents("JoyButton");
ControllerGui.buildEvents("JoyAxis");

//Action names for the different buttons (see top of file)
$Controller::Action1["button0"] = "Select";
$Controller::Action1["button1"] = "Cancel";
$Controller::Action1["button2"] = "Alt1";
$Controller::Action1["button3"] = "Alt2";
$Controller::Action1["button4"] = "LB";
$Controller::Action2["button4"] = "Left";
$Controller::Action1["button5"] = "RB";
$Controller::Action2["button5"] = "Right";
$Controller::Action1["button6"] = "LS";
$Controller::Action1["button7"] = "RS";
$Controller::Action1["button8"] = "Alt3";
$Controller::Action1["button9"] = "Alt4";
$Controller::Action1["button10"] = "Alt5";
$Controller::Action1["button11"] = "DUp";
$Controller::Action2["button11"] = "Up";
$Controller::Action1["button12"] = "DDown";
$Controller::Action2["button12"] = "Down";
$Controller::Action1["button13"] = "DLeft";
$Controller::Action2["button13"] = "Left";
$Controller::Action1["button14"] = "DRight";
$Controller::Action2["button14"] = "Right";
if ($platform $= "windows") {
	$Controller::Action1["button8"] = "LS";
	$Controller::Action1["button9"] = "RS";
	$Controller::Action1["button7"] = "Alt3";
	$Controller::Action1["button6"] = "Alt4";
}

function ControllerGui::event(%this, %joy, %category, %event, %val) {
	%last = %this.eventValue[%joy, %category, %event];
	%this.eventValue[%joy, %category, %event] = %val;

	if ($debugInput) {
		echo("CUI:" SPC %joy SPC %category SPC %event SPC %val);
	}

	$ControllerEvent = true;

	switch$ (%category) {
	case "JoyAxis":
		switch$ (%event) {
		case "xaxis": //LS X
			%this.action("XAxis", "", %val);
			if (%val < -$Controller::JoystickMakeValue && %last >= -$Controller::JoystickMakeValue) {
				%this.action("LSLeft", "Left", %val, true);
			}
			if (%val >= -$Controller::JoystickMakeValue && %last < -$Controller::JoystickMakeValue) {
				%this.action("LSLeft", "Left", %val, false);
			}
			if (%val > $Controller::JoystickMakeValue && %last <= $Controller::JoystickMakeValue) {
				%this.action("LSRight", "Right", %val, true);
			}
			if (%val <= $Controller::JoystickMakeValue && %last > $Controller::JoystickMakeValue) {
				%this.action("LSRight", "Right", %val, false);
			}
		case "rxaxis": //RS X
			%this.action("RXAxis", "", %val);
			if (%val < -$Controller::JoystickMakeValue && %last >= -$Controller::JoystickMakeValue) {
				%this.action("RSLeft", "Left", %val, true);
			}
			if (%val >= -$Controller::JoystickMakeValue && %last < -$Controller::JoystickMakeValue) {
				%this.action("RSLeft", "Left", %val, false);
			}
			if (%val > $Controller::JoystickMakeValue && %last <= $Controller::JoystickMakeValue) {
				%this.action("RSRight", "Right", %val, true);
			}
			if (%val <= $Controller::JoystickMakeValue && %last > $Controller::JoystickMakeValue) {
				%this.action("RSRight", "Right", %val, false);
			}
		case "yaxis": //LS Y
			%this.action("YAxis", "", %val);
			if (%val < -$Controller::JoystickMakeValue && %last >= -$Controller::JoystickMakeValue) {
				%this.action("LSUp", "Up", %val, true);
			}
			if (%val >= -$Controller::JoystickMakeValue && %last < -$Controller::JoystickMakeValue) {
				%this.action("LSUp", "Up", %val, false);
			}
			if (%val > $Controller::JoystickMakeValue && %last <= $Controller::JoystickMakeValue) {
				%this.action("LSDown", "Down", %val, true);
			}
			if (%val <= $Controller::JoystickMakeValue && %last > $Controller::JoystickMakeValue) {
				%this.action("LSDown", "Down", %val, false);
			}
		case "ryaxis": //RS Y
			%this.action("RYAxis", "", %val);
			if (%val < -$Controller::JoystickMakeValue && %last >= -$Controller::JoystickMakeValue) {
				%this.action("RSUp", "Up", %val, true);
			}
			if (%val >= -$Controller::JoystickMakeValue && %last < -$Controller::JoystickMakeValue) {
				%this.action("RSUp", "Up", %val, false);
			}
			if (%val > $Controller::JoystickMakeValue && %last <= $Controller::JoystickMakeValue) {
				%this.action("RSDown", "Down", %val, true);
			}
			if (%val <= $Controller::JoystickMakeValue && %last > $Controller::JoystickMakeValue) {
				%this.action("RSDown", "Down", %val, false);
			}
		case "rzaxis": //RT
			if (%val > 0 && %last <= 0) {
				%this.action("RT", "Right", %val, true);
			}
			if (%val <= 0 && %last > 0) {
				%this.action("RT", "Right", %val, false);
			}
		case "zaxis": //LT (or RT and LT for shared)
			if (isSharedTriggers(%joy)) {
				if (%val > $Controller::JoystickMakeValue && %last <= $Controller::JoystickMakeValue) {
					%this.action("LT", "Left", %val, true);
				}
				if (%val <= $Controller::JoystickMakeValue && %last > $Controller::JoystickMakeValue) {
					%this.action("LT", "Left", %val, false);
				}
				if (%val < -$Controller::JoystickMakeValue && %last >= -$Controller::JoystickMakeValue) {
					%this.action("RT", "Right", %val, true);
				}
				if (%val >= -$Controller::JoystickMakeValue && %last < -$Controller::JoystickMakeValue) {
					%this.action("RT", "Right", %val, false);
				}
			} else {
				if (%val > 0 && %last <= 0) {
					%this.action("LT", "Left", %val, true);
				}
				if (%val <= 0 && %last > 0) {
					%this.action("LT", "Left", %val, false);
				}
			}
		}
	case "JoyButton":
		//If this is a button we have a name bound, then use that
		%name = getJoystickName(%joy);
		if ($Controller::Action1[%name, %event] !$= "") {
			%this.action($Controller::Action1[%name, %event], $Controller::Action2[%name, %event], %val, !!%val);
		} else if ($Controller::Action1[%event] !$= "") {
			%this.action($Controller::Action1[%event], $Controller::Action2[%event], %val, !!%val);
		} else {
			%this.action(%event, "", %val, !!%val);
		}
	}

	$ControllerEvent = false;
}

//-----------------------------------------------------------------------------
// Button images

function getJoystickBindingBitmap(%binding) {
	%device = getField(%binding, 0);
	%action = getField(%binding, 1);

	%joystickNum = mFloor(getSubStr(%device, 8, 4)); // strlen("joystick") and 4 because 9999 joysticks... really?
	%name = getJoystickName(%joystickNum);

	if ($Controller::ButtonMap[%name, %action] !$= "") {
		return $Controller::ButtonMap[%name, %action];
	}
	return $Controller::ButtonMap[%name, ""];
}

