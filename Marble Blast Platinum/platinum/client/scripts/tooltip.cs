//-----------------------------------------------------------------------------
// Tooltips, super fun
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

$TooltipHoverTime = 500;
$TooltipMaxWidth = 300;
$TooltipMinWidth = 100;

package Tooltips {
	function GuiControl::setTooltip(%this, %tip) {
		%this.tooltip = %tip;

		if (%this.showingTooltip) {
			//If we're showing the tooltip, update it
			TooltipGui.update(%tip);
		}

		//Oh yeah, this uses tickable too :D
		%this.setTickable(true);
	}

	function GuiControl::onTick(%this, %delta) {
		if (%this.tooltip !$= "" && %this.isAwake()) {

			//We have a tooltip, check for it!

			//Such an easy method that calls a metric shitton of functions
			%hover = %this.isHover() || (%this.showingTooltip && (TooltipClose.isHover()));

			//Are we moused over?
			if (%hover) {
				//No point
				if (%this.showingTooltip)
					return;

				%wait = (%this.tooltipHover !$= "" ? %this.tooltipHover : $TooltipHoverTime);

				%pos = Canvas.getCursorPos();
				if (%pos !$= %this.tooltipPos) {
					%this.tooltipPos = %pos;
					%this.tooltipStart = getRealTime();
				}

				//Wait %wait ms before showing
				if (%this.tooltipStart $= "")
					%this.tooltipStart = getRealTime();
				else if (getRealTime() - %this.tooltipStart > %wait) {
					//Now show
					%this.showTooltip();
					%this.showingTooltip = true;
				}
			} else {
				//Clear this
				%this.tooltipStart = "";

				//If we're not showing, no need to hide
				if (!%this.showingTooltip)
					return;

				//Or just hide
				%this.hideTooltip();
				%this.showingTooltip = false;
			}
		}

		Parent::onTick(%this, %delta);
	}

	function GuiControl::showTooltip(%this) {
		TooltipGui.show(Canvas.getCursorPos(), %this.tooltip);
	}

	function GuiControl::hideTooltip(%this) {
		TooltipGui.hide();
	}

	function GuiCanvas::setContent(%this, %cnt) {
		Parent::setContent(%this, %cnt);
		%this.updateTooltip();
	}

	function GuiCanvas::pushDialog(%this, %cnt) {
		Parent::pushDialog(%this, %cnt);
		//%this.updateTooltip();
	}

	function GuiControl::updateTooltip(%this) {
		%count = %this.getCount();
		for (%i = 0; %i < %count; %i ++)
			%this.getObject(%i).updateTooltip();

		//Set up our tooltip
		if (%this.tooltip !$= "")
			%this.setTooltip(%this.tooltip);
	}
};

activatePackage(Tooltips);


if (!isObject(GuiTooltipProfile)) new GuiControlProfile(GuiTooltipProfile) {
	opaque = true;
	border = true;
	fontColor = "0 0 0";
	fontColorHL = "32 100 100";
	fillColor = "255 255 204";
	fillColorHL = "255 255 204";
	fillColorNA = "255 255 204";
	fixedExtent = true;
	justify = "center";
	canKeyFocus = false;
};

if (!isObject(TooltipGui)) new GuiControl(TooltipGui) {
	profile = "GuiModelessDialogProfile";
	horizSizing = "width";
	vertSizing = "height";
	position = "0 0";
	extent = "640 480";
	minExtent = "8 8";
	visible = "1";
	helpTag = "0";
	noCursor = "1"; //Fix for playGui

	new GuiButtonCtrl(TooltipWindow) {
		profile = "GuiTooltipProfile";
		horizSizing = "right";
		vertSizing = "bottom";
		position = "0 0";
		extent = "40 20";
		minExtent = "8 8";
		visible = "1";
		command = "TooltipGui.hide();";
		groupNum = "-1";
		text = "";
		buttonType = "PushButton";
		helpTag = "0";

		new GuiMLTextCtrl(TooltipText) {
			profile = "GuiMLTextProfile";
			horizSizing = "width";
			vertSizing = "height";
			position = "4 2";
			extent = "32 20";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
			lineSpacing = "2";
			allowColorChars = "0";
			maxChars = "-1";
			noInvert = "1";
		};
		new GuiButtonBaseCtrl(TooltipClose) {
			profile = "GuiDefaultProfile";
			horizSizing = "width";
			vertSizing = "height";
			position = "0 0";
			extent = "40 20";
			minExtent = "8 8";
			visible = "1";
			command = "TooltipGui.hide();";
			groupNum = "-1";
			text = "";
			buttonType = "PushButton";
			helpTag = "0";
		};
	};
};

function TooltipGui::show(%this, %pos, %text) {
	%len = textLen(%text);

	%width = $TooltipMaxWidth;
	%minWidth = min($TooltipMinWidth, %len + 8);
	if (%width > getWord(Canvas.getExtent(), 0) - getWord(%pos, 0)) {
		%width = max(getWord(Canvas.getExtent(), 0) - getWord(%pos, 0), %minWidth);
		%pos = setWord(%pos, 0, getWord(Canvas.getExtent(), 0) - %width);
	}

	RootGui.pushDialog(%this);
	TooltipText.setText(%text);
	%rows = mCeil(%len / (%width - 8));
	%height = (%rows * 14) + 8;
	%y = mClamp(getWord(%pos, 1) - %height, 0, getWord(Canvas.getExtent(), 1) - %height);
	TooltipWindow.resize(getWord(%pos, 0), %y, %width, %height);
}

function TooltipGui::update(%this, %text) {
	%pos = TooltipWindow.position;
	%len = textLen(%text);

	%width = $TooltipMaxWidth;
	%minWidth = min($TooltipMinWidth, %len + 8);
	if (%width > getWord(Canvas.getExtent(), 0) - getWord(%pos, 0)) {
		%width = max(getWord(Canvas.getExtent(), 0) - getWord(%pos, 0), %minWidth);
		%pos = setWord(%pos, 0, getWord(Canvas.getExtent(), 0) - %width);
	}

	TooltipText.setText(%text);
	%rows = mCeil(%len / %pos);
	%height = (%rows * 14) + 8;
	%y = mClamp(getWord(%pos, 1), 0, getWord(Canvas.getExtent(), 1) - %height);
	TooltipWindow.resize(getWord(%pos, 0), %y, %width, %height);
}

function TooltipGui::hide(%this) {
	RootGui.popDialog(%this);
}

//Oh god, tooltip has stopped looking like a word. Can't unsee
