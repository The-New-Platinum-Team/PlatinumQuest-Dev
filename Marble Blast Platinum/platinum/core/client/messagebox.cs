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

function MessageCallback(%dlg,%callback) {
	RootGui.popDialog(%dlg);
	if (ControllerGui.isJoystick() && isObject(%dlg.prevControl)) {
		ControllerGui.selectControl(%dlg.prevControl);
	}
	eval(%callback);
}

// MBSetText resizes the message window, based on the change in size of the text
// area.

function MBSetText(%text, %frame, %msg) {
	if ($GuiPack::Active) {
		$GuiPack::CurrentPack.MessageBoxOKDlg.MBSetText(%text, %frame, %msg);
		return;
	}
	%text.setText("<just:center><font:18>" @ %msg);
	%text.forceReflow();

	%windowPos = %frame.getPosition();
	%windowExt = %frame.getExtent();

	%height = getWord(%text.getExtent(), 1);
	%height = mClamp(%height, 100, 400) + 140;

	%frame.resize(getWord(%windowPos, 0), (getWord(Canvas.getExtent(), 1) - %height) / 2, getWord(%windowExt, 0), %height);
}

//-----------------------------------------------------------------------------
// MessageBox OK
//-----------------------------------------------------------------------------

function MessageBoxOK(%title, %message, %callback) {
	if ($GuiPack::Active) {
		$GuiPack::CurrentPack.MessageBoxOKDlg.showMessage(%title, %message, %callback);
		return;
	}
	if (ControllerGui.isJoystick()) {
		MessageBoxOKDlg.prevControl = ControllerGui.control;
	}
	MBOKTitle.setText("<just:center><bold:28>" @ %title);
	RootGui.pushDialog(MessageBoxOKDlg);
	MBSetText(MBOKText, MBOKFrame, %message);
	MessageBoxOKDlg.callback = %callback;
	if (ControllerGui.isJoystick()) {
		//Do this now so we don't get one frame of it being off
		ControllerGui.updateHighlight();
	}
}

//------------------------------------------------------------------------------
function MessageBoxOKDlg::onSleep(%this) {
	%this.callback = "";
}

//------------------------------------------------------------------------------
// MessageBox Yes/No dialog:
//------------------------------------------------------------------------------

function MessageBoxYesNo(%title, %message, %yesCallback, %noCallback) {
	if ($GuiPack::Active) {
		$GuiPack::CurrentPack.MessageBoxYesNoDlg.showMessage(%title, %message, %yesCallback, %noCallback);
		return;
	}
	if (ControllerGui.isJoystick()) {
		MessageBoxOKDlg.prevControl = ControllerGui.control;
	}
	MBYesNoTitle.setText("<just:center><bold:28>" @ %title);
	RootGui.pushDialog(MessageBoxYesNoDlg);
	MBSetText(MBYesNoText, MBYesNoFrame, %message);
	MessageBoxYesNoDlg.yesCallBack = %yesCallback;
	MessageBoxYesNoDlg.noCallback = %noCallBack;
	if (ControllerGui.isJoystick()) {
		//Do this now so we don't get one frame of it being off
		ControllerGui.updateHighlight();
	}
}

//------------------------------------------------------------------------------
function MessageBoxYesNoDlg::onSleep(%this) {
	%this.yesCallback = "";
	%this.noCallback = "";
}
