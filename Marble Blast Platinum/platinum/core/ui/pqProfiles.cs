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

//This is here so the game doesn't crash when you make a new GuiBorderButtonCtrl
if (!isObject(GuiBorderButtonProfile)) new GuiControlProfile(GuiBorderButtonProfile : GuiButtonProfile) {
	fontColor = "241 242 242 255";
	fontColorHL = "241 242 242 255";
	fontColorSEL = "241 242 242 255";
	fontColorNA = "128 128 128 255";
	justify = "center";
	fontType = $DefaultFont["Bold"];
	fontSize = 24;
	bitmap = "./button";
};
if (!isObject(PQButtonProfile)) new GuiControlProfile(PQButtonProfile : GuiButtonProfile) {
	fontColor = "241 242 242 255";
	fontColorHL = "241 242 242 255";
	fontColorSEL = "241 242 242 255";
	fontColorNA = "128 128 128 255";
	justify = "center";
	fontType = $DefaultFont;
	fontSize = 24;
	bitmap = "./button";
};

if (!isObject(PQButtonPlainProfile)) new GuiControlProfile(PQButtonPlainProfile : PQButtonProfile) {
	bitmap = "./button-plain";
	fontType = $DefaultFontBold;
	fontSize = 28;
};

if (!isObject(PQButton20Profile)) new GuiControlProfile(PQButton20Profile : PQButtonProfile) {
	fontSize = 20;
};
if (!isObject(PQButton26Profile)) new GuiControlProfile(PQButton26Profile : PQButtonProfile) {
	fontSize = 26;
};
if (!isObject(PQButton28Profile)) new GuiControlProfile(PQButton28Profile : PQButtonProfile) {
	fontSize = 28;
};
if (!isObject(PQButton36Profile)) new GuiControlProfile(PQButton36Profile : PQButtonProfile) {
	fontSize = 36;
};
if (!isObject(PQButton40Profile)) new GuiControlProfile(PQButton40Profile : PQButtonProfile) {
	fontSize = 40;
};
if (!isObject(PQButton48Profile)) new GuiControlProfile(PQButton48Profile : PQButtonProfile) {
	fontSize = 48;
};
if (!isObject(PQButton64Profile)) new GuiControlProfile(PQButton64Profile : PQButtonProfile) {
	fontSize = 64;
};

//Pill buttons, look kinda like this
// ( a | b | c )
//Not to be confused with Phil buttons, which use gradients and Phillow emboss
if (!isObject(PQButtonPillLeftProfile)) new GuiControlProfile(PQButtonPillLeftProfile : PQButtonProfile) {
	bitmap = "./button-pillleft";
};
if (!isObject(PQButtonPillCenterProfile)) new GuiControlProfile(PQButtonPillCenterProfile : PQButtonProfile) {
	bitmap = "./button-pillcenter";
};
if (!isObject(PQButtonPillRightProfile)) new GuiControlProfile(PQButtonPillRightProfile : PQButtonProfile) {
	bitmap = "./button-pillright";
};

//Smaller versions for when you need tiny text
if (!isObject(PQButtonPillSmallLeftProfile)) new GuiControlProfile(PQButtonPillSmallLeftProfile : PQButtonPillLeftProfile) {
	fontSize = "20";
};
if (!isObject(PQButtonPillSmallCenterProfile)) new GuiControlProfile(PQButtonPillSmallCenterProfile : PQButtonPillCenterProfile) {
	fontSize = "20";
};
if (!isObject(PQButtonPillSmallRightProfile)) new GuiControlProfile(PQButtonPillSmallRightProfile : PQButtonPillRightProfile) {
	fontSize = "20";
};

//Editor-style danger and warning text boxes
if (!isObject(GuiTextEditDangerProfile)) new GuiControlProfile(GuiTextEditDangerProfile) {
	opaque = true;
	fillColor = "255 153 153";
	fillColorHL = "128 128 128";
	border = 3;
	borderThickness = 2;
	borderColor = "0 0 0";
	fontColor = "0 0 0";
	fontColorHL = "255 255 255";
	fontColorNA = "128 128 128";
	textOffset = "0 2";
	autoSizeWidth = false;
	autoSizeHeight = true;
	tab = true;
	canKeyFocus = true;
};
if (!isObject(GuiTextEditWarnProfile)) new GuiControlProfile(GuiTextEditWarnProfile) {
	opaque = true;
	fillColor = "255 255 153";
	fillColorHL = "128 128 128";
	border = 3;
	borderThickness = 2;
	borderColor = "0 0 0";
	fontColor = "0 0 0";
	fontColorHL = "255 255 255";
	fontColorNA = "128 128 128";
	textOffset = "0 2";
	autoSizeWidth = false;
	autoSizeHeight = true;
	tab = true;
	canKeyFocus = true;
};
if (!isObject(GuiTextEditSuccessProfile)) new GuiControlProfile(GuiTextEditSuccessProfile) {
	opaque = true;
	fillColor = "153 255 153";
	fillColorHL = "128 128 128";
	border = 3;
	borderThickness = 2;
	borderColor = "0 0 0";
	fontColor = "0 0 0";
	fontColorHL = "255 255 255";
	fontColorNA = "128 128 128";
	textOffset = "0 2";
	autoSizeWidth = false;
	autoSizeHeight = true;
	tab = true;
	canKeyFocus = true;
};

if (!isObject(PQCheckboxProfile)) new GuiControlProfile(PQCheckboxProfile : GuiCheckboxProfile) {
	opaque = false;
	fillColor = "232 232 232";
	border = false;
	borderColor = "0 0 0";
	fontType = $DefaultFont["Bold"];
	fontSize = 21;
	fontColor = "241 242 242";
	fontColorHL = "241 242 242";
	fixedExtent = true;
	justify = "left";
	bitmap = "./pqcheckbox";
	hasBitmapArray = true;
	disableProfile = "PQCheckboxDisableProfile";
};

if (!isObject(PQCheckboxDisableProfile)) new GuiControlProfile(PQCheckboxDisableProfile : PQCheckboxProfile) {
	opaque = false;
	fillColor = "232 232 232";
	border = false;
	borderColor = "0 0 0";
	fontType = $DefaultFont["Bold"];
	fontSize = 21;
	fixedExtent = true;
	justify = "left";
	bitmap = "./pqcheckbox-disable";
	hasBitmapArray = true;
	fontColor = "153 153 153";
	fontColorHL = "153 153 153";
	enableProfile = "PQCheckboxProfile";
};

//Same size as a 94x45 standard button
if (!isObject(PQCheckboxLargeProfile)) new GuiControlProfile(PQCheckboxLargeProfile) {
	opaque = false;
	fillColor = "232 232 232";
	border = false;
	borderColor = "0 0 0";
	fontType = $DefaultFont["Bold"];
	fontSize = 24;
	fontColor = "241 242 242";
	fontColorHL = "241 242 242";
	fixedExtent = true;
	justify = "left";
	bitmap = "./pqcheckbox45";
	hasBitmapArray = true;
	disableProfile = "PQCheckboxLargeDisableProfile";
};

if (!isObject(PQCheckboxLargeDisableProfile)) new GuiControlProfile(PQCheckboxLargeDisableProfile : PQCheckboxLargeProfile) {
	opaque = false;
	fillColor = "232 232 232";
	border = false;
	borderColor = "0 0 0";
	fontType = $DefaultFont["Bold"];
	fontSize = 24;
	fixedExtent = true;
	justify = "left";
	bitmap = "./pqcheckbox45-disable";
	hasBitmapArray = true;
	fontColor = "102 102 102";
	fontColorHL = "102 102 102";
	enableProfile = "PQCheckboxLargeProfile";
};

if (!isObject(PQRadioProfile)) new GuiControlProfile(PQRadioProfile : GuiRadioProfile) {
	opaque = false;
	fillColor = "232 232 232";
	border = false;
	borderColor = "0 0 0";
	fontType = $DefaultFont["Bold"];
	fontSize = 21;
	fontColor = "241 242 242";
	fontColorHL = "241 242 242";
	fixedExtent = true;
	justify = "left";
	bitmap = "./pqradio";
	hasBitmapArray = true;
	disableProfile = "PQRadioDisableProfile";
};

if (!isObject(PQRadioDisableProfile)) new GuiControlProfile(PQRadioDisableProfile : PQRadioProfile) {
	opaque = false;
	fillColor = "232 232 232";
	border = false;
	borderColor = "0 0 0";
	fontType = $DefaultFont["Bold"];
	fontSize = 21;
	fixedExtent = true;
	justify = "left";
	bitmap = "./pqradio-disable";
	hasBitmapArray = true;
	fontColor = "102 102 102";
	fontColorHL = "102 102 102";
	enableProfile = "PQRadioProfile";
};

if (!isObject(PQTextboxProfile)) new GuiControlProfile(PQTextboxProfile) {
	fontType = $DefaultFont;
	opaque = false;
	fillColor = "241 242 242";
	fillColorHL = "128 128 128";
	border = false;
	borderColor = "0 0 0";
	fontColor = "241 242 242";
	fontColorHL = "241 242 242";
	fontColorNA = "128 128 128";
	textOffset = "0 2";
	autoSizeWidth = false;
	autoSizeHeight = true;
	tab = true;
	canKeyFocus = true;
	fontSize = 24;
};

if (!isObject(PQTextboxSmallProfile)) new GuiControlProfile(PQTextboxSmallProfile) {
	fontType = $DefaultFont;
	opaque = false;
	fillColor = "241 242 242";
	fillColorHL = "128 128 128";
	border = false;
	borderColor = "0 0 0";
	fontColor = "241 242 242";
	fontColorHL = "241 242 242";
	fontColorNA = "128 128 128";
	textOffset = "0 2";
	autoSizeWidth = false;
	autoSizeHeight = true;
	tab = true;
	canKeyFocus = true;
	fontSize = 18;
};

// a scroll profile with a simplified interface and
//no background / frame
if (!isObject(PQScrollProfile)) new GuiControlProfile(PQScrollProfile) {
	opaque = false;
	fillColor = "0 0 0 0";
	border = 0;
	borderThickness = 0;
	borderColor = "0 0 0 0";
	bitmap = "./pqscroll";
	hasBitmapArray = true;
};

// a scroll profile with a simplified interface and
//no background / frame
if (!isObject(PQScrollWhiteProfile)) new GuiControlProfile(PQScrollWhiteProfile : PQScrollProfile) {
	bitmap = "./pqscroll-white";
};

// ask phil :)
if (!isObject(GuiPhilScrollProfile)) new GuiControlProfile(GuiPhilScrollProfile) {
	opaque = false;
	fillColor = "0 0 0 0";
	border = 0;
	borderThickness = 0;
	borderColor = "0 0 0 0";
	bitmap = "./philscroll";
	hasBitmapArray = true;
};

new GuiControlProfile(PQTextListProfile : GuiTextListProfile) {
	fontType = $DefaultFont;
	fontSize = "16";
	fontColors[0] = "241 242 242 255";
	fontColorHL = "80 100 110 255";
	fillColorHL = "0 0 0 51";
	fontColorNA = "153 153 153";
};