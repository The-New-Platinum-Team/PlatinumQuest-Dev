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
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Chat Hud profiles


new GuiControlProfile("ChatHudMessageProfile") {
	fontType = "Arial";
	fontSize = 16;
	fontColor = "255 255 0";      // default color (death msgs, scoring, inventory)
	fontColors[1] = "4 235 105";   // client join/drop, tournament mode
	fontColors[2] = "219 200 128"; // gameplay, admin/voting, pack/deployable
	fontColors[3] = "77 253 95";   // team chat, spam protection message, client tasks
	fontColors[4] = "40 231 240";  // global chat
	fontColors[5] = "200 200 50 200";  // used in single player game
	// WARNING! Colors 6-9 are reserved for name coloring
	autoSizeWidth = true;
	autoSizeHeight = true;
};

//  User list profile colors
new GuiControlProfile("LBChatUserlistProfile") {
	fontType = "Arial";
	fontSize = 16;
	fontColor = "0 0 0";
	fontColors[1] = "80 80 80"; //
	fontColors[2] = "255 0 0"; // Admin
	fontColors[3] = "0 0 255"; // Mod
	fontColors[4] = "0 0 0"; // Normal person
	fontColors[5] = "0 0 0"; //
	fontColors[6] = "0 0 0"; //
	fontColors[7] = "0 0 0"; //
	fontColors[8] = "0 0 0"; //
	fontColors[9] = "0 0 0"; //
	autoSizeWidth = true;
	autoSizeHeight = true;
};

new GuiControlProfile("LBPlayChatProfile") {
	fontType = "Arial";
	fontSize = 16;
	fontColor = "0 0 0";
	fontColors[1] = "80 80 80"; // Player name in chat
	fontColors[2] = "0 140 0"; // Welcome messages
	fontColors[3] = "0 0 255"; // Mod
	fontColors[4] = "255 0 0"; // Admin
	fontColors[5] = "255 0 0"; // Server messages
	fontColors[6] = "128 0 255"; // Emotion messages
	fontColors[7] = "176 100 0"; // Notifications
	fontColors[8] = "100 50 0"; // Whisper from
	fontColors[9] = "50 50 50"; // Whisper msg
	autoSizeWidth = true;
	autoSizeHeight = true;
};

// WHY ARENT THESE IN HERE

new GuiControlProfile("GuiLBScrollProfile") {
	opaque = true;
	fillColor = "255 255 255 255";
	fillColorHL = "244 244 244 255";
	fillColorNA = "244 244 244 255";
	border = 3;
	borderThickness = 2;
	borderColor = "151 39 0 255";
	borderColorHL = "151 39 0 255";
	borderColorNA = "64 64 64 255";
	bitmap = ($platform $= "macos") ? $usermods @ "/core/ui/osxScroll" : $usermods @ "/core/ui/darkScroll";
};

new GuiControlProfile("GuiLBCheckBoxProfile" : GuiCheckBoxProfile) {
	// Nothing?
	opaque = false;
};

new GuiControlProfile("GuiLBPopupMenuProfile" : GuiPopupMenuProfile) {
	fontColor = "0 0 0 255";
	fontColors = "0 0 0 255";
	fontColorHL = "32 100 100 255";
	fontColorNA = "0 0 0 255";
	fontColorSEL = "32 100 100 255";
	borderColor = "0 0 0 255";
	borderColorHL = "151 39 0 255";
	borderColorNA = "64 64 64 255";
};

new GuiControlProfile("ChatHudScrollProfile") {
	opaque = false;
	bitmap = "~/core/ui/darkScroll";
	hasBitmapArray = true;
};


new GuiControlProfile(GuiTPTextEditProfile) {
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
};

new GuiControlProfile(OverlayScreenProfile) {
	opaque = true;
	fillColor = "0 0 0 96";
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
};

new GuiControlProfile(GuiBigTextEditProfile) {
	fontType = $DefaultFont;
	fontSize = 32;
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
};

new GuiControlProfile(GuiSearchTextEditProfile) {
	fontType = "Arial Bold";
	fontSize = 20;
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
};

new GuiControlProfile(BevelPurpleProfile) {
	// fill color
	opaque = true;
	border = 2;
	fillColor   = "161 150 229";
	fillColorHL = "255 0 0";
	fillColorNA = "0 0 255";

	// border color
	borderColor   = "0 255 0";
	borderColorNA = "92 86 131";

	textOffset = "6 6";

};

//-----------------------------------------------------------------------------
// Common Hud profiles

new GuiControlProfile("HudScrollProfile") {
	opaque = false;
	border = true;
	borderColor = "0 255 0";
	bitmap = "~/core/ui/darkScroll";
	hasBitmapArray = true;
};

new GuiControlProfile("HudTextProfile") {
	opaque = false;
	fillColor = "128 128 128";
	fontColor = "0 255 0";
	border = true;
	borderColor = "0 255 0";
};


//-----------------------------------------------------------------------------
// Center and bottom print

new GuiControlProfile("CenterPrintProfile") {
	opaque = false;
	fillColor = "128 128 128";
	fontColor = "0 255 0";
	border = true;
	borderColor = "0 255 0";
};

new GuiControlProfile("CenterPrintTextProfile") {
	opaque = false;
	fontType = "Arial";
	fontSize = 12;
	fontColor = "0 255 0";
};

if (!isObject(GuiBlastDisabledProfile)) {
	new GuiControlProfile(GuiBlastDisabledProfile) {
		opaque = false;
		fillColor = "152 152 152 100";
		border = true;
		borderColor = "78 88 120";
	};
}

if (!isObject(GuiBlastEnabledProfile)) {
	new GuiControlProfile(GuiBlastEnabledProfile) {
		opaque = false;
		fillColor = "44 152 162 100";
		border = true;
		borderColor   = "78 88 120";
	};
}

if (!isObject(GuiUltraBlastProfile)) {
	new GuiControlProfile(GuiUltraBlastProfile) {
		opaque = false;
		fillColor = "247 161 0 100";
		border = true;
		borderColor   = "78 88 120";
	};
}

if (!isObject(GuiMLProgressProfile)) {
	new GuiControlProfile(GuiMLProgressProfile) {
		opaque = false;
		fillColor = "153 204 255 100";
		border = false;
	};
}

if (!isObject(GemCollectionMessageProfile)) {
	new GuiControlProfile(GemCollectionMessageProfile) {
		opaque = false;
		fillColor = "128 128 128";
		fontColor = "0 255 0";
		border = false;
	};
}

new GuiControlProfile(GuiRoundBorderProfile) {
	fillColor = "79 61 56";
	bitmap = "./game/help/round_border.png";
	hasBitmapArray = true;
	opaque = true;
};

new GuiControlProfile(GuiRoundBorderThinProfile) {
	fillColor = "79 61 56";
	bitmap = "./game/help/round_border_thin.png";
	hasBitmapArray = true;
	opaque = true;
};
