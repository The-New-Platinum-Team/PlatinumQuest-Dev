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

$interfaceStyle = (($platform $= "macos" && $appearance !$= "windows") || $appearance $= "macos") ? "osx" : "dark";

//--------------------------------------------------------------------------

$Gui::fontCacheDirectory = expandFilename("./cache");

$DefaultFont                  = ($pref::DefaultFont                  $= "" ? "Whatney"        : $pref::DefaultFont);
$DefaultFont["Bold"]          = ($pref::DefaultFont["Bold"]          $= "" ? "Squishney"      : $pref::DefaultFont["Bold"]);
$DefaultFont["Italic"]        = ($pref::DefaultFont["Italic"]        $= "" ? "Whatney Italic" : $pref::DefaultFont["Italic"]);
$DefaultFont["Condensed"]     = ($pref::DefaultFont["Condensed"]     $= "" ? "Squatney"       : $pref::DefaultFont["Condensed"]);
$DefaultFont["PointPopups"]   = ($pref::DefaultFont["PointPopups"]   $= "" ? "Squishney"      : $pref::DefaultFont["PointPopups"]); // Gem and TT indicators
$DefaultFont["Small"]         = ($pref::DefaultFont["Small"]         $= "" ? "Arial"          : $pref::DefaultFont["Small"]);
$DefaultFont["SmallBold"]     = ($pref::DefaultFont["SmallBold"]     $= "" ? "Arial Bold"     : $pref::DefaultFont["SmallBold"]);
$DefaultFont["SmallItalic"]   = ($pref::DefaultFont["SmallItalic"]   $= "" ? "Arial Italic"   : $pref::DefaultFont["SmallItalic"]);
$DefaultFont["PowerupTimers"] = ($pref::DefaultFont["PowerupTimers"] $= "" ? "Whatney"        : $pref::DefaultFont["PowerupTimers"]);

// GuiDefaultProfile is a special case, all other profiles are initialized
// to the contents of this profile first then the profile specific
// overrides are assigned.

if (!isObject(GuiDefaultProfile)) new GuiControlProfile(GuiDefaultProfile) {
	tab = false;
	canKeyFocus = false;
	hasBitmapArray = false;
	mouseOverSelected = false;

	// fill color
	opaque = false;
	fillColor = $interfaceStyle $= "osx" ? "235 235 235" : "192 192 192";
	fillColorHL = $interfaceStyle $= "osx" ? "235 235 235" : "220 220 220";
	fillColorNA = $interfaceStyle $= "osx" ? "235 235 235" : "220 220 220";

	// border color
	border = false;
	borderColor   = "0 0 0";
	borderColorHL = "128 128 128";
	borderColorNA = "64 64 64";

	// font
	fontType = $DefaultFont["Small"];
	fontSize = 14;

	fontColor = "0 0 0";
	fontColorHL = "32 100 100";
	fontColorNA = "0 0 0";
	fontColorSEL= "200 200 200";

	// bitmap information
	bitmap = "./" @ $interfaceStyle @ "Window";
	bitmapBase = "";
	textOffset = "0 0";

	// used by guiTextControl
	modal = true;
	justify = "left";
	autoSizeWidth = false;
	autoSizeHeight = false;
	returnTab = false;
	numbersOnly = false;
	cursorColor = "0 0 0 255";

	// sounds
	soundButtonDown = AudioButtonDown;
	soundButtonOver = "";
};


if (!isObject(GuiComic24Profile)) new GuiControlProfile(GuiComic24Profile) {
	fontType = "Comic Sans MS Bold";
	fontSize = 24;
	fontColor = "0 0 0";
	autoSizeWidth = true;
	autoSizeHeight = true;
};


if (!isObject(GuiInputCtrlProfile)) new GuiControlProfile(GuiInputCtrlProfile) {
	tab = true;
	canKeyFocus = true;
};

if (!isObject(GuiDialogProfile)) new GuiControlProfile(GuiDialogProfile);


if (!isObject(GuiSolidDefaultProfile)) new GuiControlProfile(GuiSolidDefaultProfile) {
	opaque = true;
	border = true;
};

if (!isObject(GuiWindowProfile)) new GuiControlProfile(GuiWindowProfile) {
	opaque = true;
	border = 2;
	fillColor = $interfaceStyle $= "osx" ? "235 235 235" : "192 192 192";
	fillColorHL = $interfaceStyle $= "osx" ? "235 235 235" : "64 150 150";
	fillColorNA = $interfaceStyle $= "osx" ? "235 235 235" : "150 150 150";
	fontColor = $interfaceStyle $= "osx" ? "0 0 0" : "255 255 255";
	fontColorHL = $interfaceStyle $= "osx" ? "200 200 200" : "0 0 0";
	text = "GuiWindowCtrl test";
	bitmap = "./" @ $interfaceStyle @ "Window";
	textOffset = $interfaceStyle $= "osx" ? "5 5" : "6 6";
	hasBitmapArray = true;
	justify = $interfaceStyle $= "osx" ? "center" : "left";
};

if (!isObject(GuiToolWindowProfile)) new GuiControlProfile(GuiToolWindowProfile) {
	opaque = true;
	border = 2;
	fillColor = "192 192 192";
	fillColorHL = "64 150 150";
	fillColorNA = "150 150 150";
	fontColor = "255 255 255";
	fontColorHL = "0 0 0";
	bitmap = "./torqueToolWindow";
	textOffset = "6 6";
};

if (!isObject(EditorToolButtonProfile)) new GuiControlProfile(EditorToolButtonProfile) {
	opaque = true;
	border = 2;
};

if (!isObject(GuiContentProfile)) new GuiControlProfile(GuiContentProfile) {
	opaque = true;
	fillColor = "255 255 255";
};

if (!isObject(GuiModelessDialogProfile)) new GuiControlProfile("GuiModelessDialogProfile") {
	modal = false;
};

if (!isObject(GuiButtonProfile)) new GuiControlProfile(GuiButtonProfile) {
	opaque = true;
	border = true;
	fontColor = "0 0 0";
	fontColorHL = "32 100 100";
	fixedExtent = true;
	justify = "center";
	canKeyFocus = false;
	soundButtonOver = AudioButtonOver;
	soundButtonDown = AudioButtonDown;
};

if (!isObject(GuiMenuBarProfile)) new GuiControlProfile(GuiMenuBarProfile) {
	opaque = true;
	fillColorHL = "0 0 96";
	border = 4;
	fontColor = "0 0 0";
	fontColorHL = "255 255 255";
	fontColorNA = "128 128 128";
	fixedExtent = true;
	justify = "center";
	canKeyFocus = false;
	mouseOverSelected = true;
	bitmap = "./" @ $interfaceStyle @ "Menu";
	hasBitmapArray = true;
};

if (!isObject(GuiButtonSmProfile)) new GuiControlProfile(GuiButtonSmProfile : GuiButtonProfile) {
	fontSize = 14;
};

if (!isObject(GuiRadioProfile)) new GuiControlProfile(GuiRadioProfile) {
	fontSize = 14;
	fillColor = "232 232 232";
	fontColorHL = "32 100 100";
	fixedExtent = true;
	bitmap = "./" @ $interfaceStyle @ "Radio";
	hasBitmapArray = true;
};

if (!isObject(GuiScrollProfile)) new GuiControlProfile(GuiScrollProfile) {
	opaque = true;
	fillColor = "255 255 255";
	border = 3;
	borderThickness = 2;
	borderColor = "0 0 0";
	bitmap = "./" @ $interfaceStyle @ "Scroll";
	hasBitmapArray = true;
};

if (!isObject(GuiBorderlessScrollProfile)) new GuiControlProfile(GuiBorderlessScrollProfile) {
	opaque = false;
	fillColor = "0 0 0 0";
	border = 0;
	borderThickness = 0;
	borderColor = "0 0 0 0";
	bitmap = "./" @ $interfaceStyle @ "Scroll";
	hasBitmapArray = true;
};

if (!isObject(GuiSliderProfile)) new GuiControlProfile(GuiSliderProfile);

if (!isObject(GuiTextProfile)) new GuiControlProfile(GuiTextProfile) {
	fontColor = "0 0 0";
	fontColorLink = "255 96 96";
	fontColorLinkHL = "0 0 255";
	autoSizeWidth = true;
	autoSizeHeight = true;
};

if (!isObject(EditorTextProfile)) new GuiControlProfile(EditorTextProfile) {
	fontType = $DefaultFont["SmallBold"];
	fontColor = "0 0 0";
	autoSizeWidth = true;
	autoSizeHeight = true;
};

if (!isObject(EditorTextProfileWhite)) new GuiControlProfile(EditorTextProfileWhite) {
	fontType = $DefaultFont["SmallBold"];
	fontColor = "255 255 255";
	autoSizeWidth = true;
	autoSizeHeight = true;
};

if (!isObject(GuiMediumTextProfile)) new GuiControlProfile(GuiMediumTextProfile : GuiTextProfile) {
	fontSize = 24;
};

if (!isObject(GuiMediumTextEditProfile)) new GuiControlProfile(GuiMediumTextEditProfile : GuiTextProfile) {
	fontType = $DefaultFont;
	opaque = false;
	fillColor = "255 255 255";
	fillColorHL = "128 128 128";
	border = false;
	borderColor = "0 0 0";
	fontColor = "0 0 0";
	fontColorHL = "255 255 255";
	fontColorNA = "128 128 128";
	textOffset = "0 2";
	autoSizeWidth = false;
	autoSizeHeight = true;
	tab = true;
	canKeyFocus = true;
	fontSize = 24;
};

if (!isObject(GuiBigTextProfile)) new GuiControlProfile(GuiBigTextProfile : GuiTextProfile) {
	fontSize = 36;
};

if (!isObject(GuiCenterTextProfile)) new GuiControlProfile(GuiCenterTextProfile : GuiTextProfile) {
	justify = "center";
};

if (!isObject(MissionEditorProfile)) new GuiControlProfile(MissionEditorProfile) {
	canKeyFocus = true;
};

if (!isObject(EditorScrollProfile)) new GuiControlProfile(EditorScrollProfile) {
	opaque = true;
	fillColor = "192 192 192 192";
	border = 3;
	borderThickness = 2;
	borderColor = "0 0 0";
	bitmap = "./" @ $interfaceStyle @ "Scroll";
	hasBitmapArray = true;
};

if (!isObject(GuiTextEditProfile)) new GuiControlProfile(GuiTextEditProfile) {
	opaque = true;
	fillColor = "255 255 255";
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
if (!isObject(GuiControlListPopupProfile)) new GuiControlProfile(GuiControlListPopupProfile) {
	opaque = true;
	fillColor = "255 255 255";
	fillColorHL = "128 128 128";
	border = true;
	borderColor = "0 0 0";
	fontColor = "0 0 0";
	fontColorHL = "255 255 255";
	fontColorNA = "128 128 128";
	textOffset = "0 2";
	autoSizeWidth = false;
	autoSizeHeight = true;
	tab = true;
	canKeyFocus = true;
	bitmap = "./" @ $interfaceStyle @ "Scroll";
	hasBitmapArray = true;
};

if (!isObject(GuiTextArrayProfile)) new GuiControlProfile(GuiTextArrayProfile : GuiTextProfile) {
	fontColorHL = "32 100 100";
	fillColorHL = "200 200 200";
};

if (!isObject(GuiTextListProfile)) new GuiControlProfile(GuiTextListProfile : GuiTextProfile) ;

if (!isObject(GuiTransListProfile)) new GuiControlProfile(GuiTransListProfile : GuiTextProfile) {
	fillColorHL = "255 255 255 100";
	fontColorHL = "0 0 0";
};

if (!isObject(GuiPackListProfile)) new GuiControlProfile(GuiPackListProfile : GuiTextProfile) {
	fontType = $DefaultFont;
	fontSize = "24";
};

if (!isObject(GuiTreeViewProfile)) new GuiControlProfile(GuiTreeViewProfile) {
	fontSize = 13;  // dhc - trying a better fit...
	fontColor = "0 0 0";
	fontColorHL = "64 150 150";
};

if (!isObject(GuiCheckBoxProfile)) new GuiControlProfile(GuiCheckBoxProfile) {
	opaque = false;
	fillColor = "232 232 232";
	border = false;
	borderColor = "0 0 0";
	fontSize = 14;
	fontColor = "0 0 0";
	fontColorHL = "32 100 100";
	fixedExtent = true;
	justify = "left";
	bitmap = "./" @ $interfaceStyle @ "Check";
	hasBitmapArray = true;
};

if (!isObject(GuiPopUpMenuProfile)) new GuiControlProfile(GuiPopUpMenuProfile) {
	opaque = true;
	mouseOverSelected = true;

	border = 4;
	borderThickness = 2;
	borderColor = "0 0 0";
	fontSize = 14;
	fontColor = "0 0 0";
	fontColorHL = "32 100 100";
	fontColorSEL = "32 100 100";
	fixedExtent = true;
	justify = "center";
	bitmap = "./" @ $interfaceStyle @ "Scroll";
	hasBitmapArray = true;
};

if (!isObject(GuiEditorClassProfile)) new GuiControlProfile(GuiEditorClassProfile) {
	opaque = true;
	fillColor = "232 232 232";
	border = true;
	borderColor   = "0 0 0";
	borderColorHL = "127 127 127";
	fontColor = "0 0 0";
	fontColorHL = "32 100 100";
	fixedExtent = true;
	justify = "center";
	bitmap = "./" @ $interfaceStyle @ "Scroll";
	hasBitmapArray = true;
};


if (!isObject(LoadTextProfile)) new GuiControlProfile("LoadTextProfile") {
	fontColor = "66 219 234";
	autoSizeWidth = true;
	autoSizeHeight = true;
};


if (!isObject(GuiMLTextProfile)) new GuiControlProfile("GuiMLTextProfile") {
	fontColorLink = "255 96 96";
	fontColorLinkHL = "0 0 255";
};

if (!isObject(GuiMLTextEditProfile)) new GuiControlProfile(GuiMLTextEditProfile) {
	fontColorLink = "255 96 96";
	fontColorLinkHL = "0 0 255";

	fillColor = "255 255 255";
	fillColorHL = "128 128 128";

	fontColor = "0 0 0";
	fontColorHL = "255 255 255";
	fontColorNA = "128 128 128";

	autoSizeWidth = true;
	autoSizeHeight = true;
	tab = true;
	canKeyFocus = true;
};

//--------------------------------------------------------------------------
// Console Window

if (!isObject(GuiConsoleProfile)) new GuiControlProfile("GuiConsoleProfile") {
	fontType = $interfaceStyle $= "osx" ? "Courier New" : "Lucida Console";
	fontSize = 12;
	fontColor = "0 0 0";
	fontColorHL = "130 130 130";
	fontColorNA = "255 0 0";
	fontColors[3] = "0 190 0";
	fontColors[6] = "50 50 50";
	fontColors[7] = "50 50 0";
	fontColors[8] = "0 0 50";
	fontColors[9] = "0 50 0";
};


if (!isObject(GuiProgressProfile)) new GuiControlProfile("GuiProgressProfile") {
	opaque = false;
	fillColor = "44 152 162 100";
	border = true;
	borderColor   = "78 88 120";
};

if (!isObject(GuiProgressTextProfile)) new GuiControlProfile("GuiProgressTextProfile") {
	fontColor = "0 0 0";
	justify = "center";
};



//--------------------------------------------------------------------------
// Gui Inspector

if (!isObject(GuiInspectorTextEditProfile)) new GuiControlProfile("GuiInspectorTextEditProfile") {
	opaque = true;
	fillColor = "255 255 255";
	fillColorHL = "128 128 128";
	border = true;
	borderColor = "0 0 0";
	fontColor = "0 0 0";
	fontColorHL = "255 255 255";
	autoSizeWidth = false;
	autoSizeHeight = true;
	tab = false;
	canKeyFocus = true;
};

if (!isObject(GuiBitmapBorderProfile)) new GuiControlProfile(GuiBitmapBorderProfile) {
	bitmap = "./" @ $interfaceStyle @ "Border";
	hasBitmapArray = true;
};

//-------------------------------------- Cursors
//
new GuiCursor(DefaultCursor) {
	hotSpot = "1 1";
	bitmapName = "./CUR_3darrow";
};

if (!isObject(GuiListButtonProfile)) new GuiControlProfile("GuiListButtonProfile") {
	fontColor = "0 0 0";
	fontColorSEL = "32 100 100";
	fontColorNA = "128 128 128";
	fontType = $DefaultFont;
	fontSize = 24;
};

if (!isObject(GuiProgressFrameProfile))
	new GuiControlProfile(GuiProgressFrameProfile) {
	border = false;
	hasBitmapArray = true;
	bitmap = "./loadingbar";
	category = "Core";
};

//Transparency
exec("~/client/ui/lb/core/transparency/transparency.cs");
