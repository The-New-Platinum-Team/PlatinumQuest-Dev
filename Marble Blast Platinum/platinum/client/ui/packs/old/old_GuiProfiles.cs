//-----------------------------------------------------------------------------
// Copyright (c) 2024 The Platinum Team
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

if (!isObject(OldGuiProfilesGroup))
		RootGroup.add(new SimGroup(OldGuiProfilesGroup));

if(!isObject(OldGuiBacklessScrollProfile)) OldGuiProfilesGroup.add(new GuiControlProfile (OldGuiBacklessScrollProfile){
	opaque = false;
	fillColor = "0 0 0 0";
	border = 0;
	borderThickness = 0;
	borderColor = "0 0 0 0";
	bitmap = "platinum/client/ui/packs/old/offline/noscroll";
	hasBitmapArray = true;
});

if(!isObject(OldGuiWhiteBacklessScrollProfile)) OldGuiProfilesGroup.add(new GuiControlProfile (OldGuiWhiteBacklessScrollProfile : OldGuiBacklessScrollProfile)
{
   bitmap = "platinum/client/ui/packs/old/offline/noscroll-white";
});

if (!isObject(OldPMDifficultyButtonProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldPMDifficultyButtonProfile : GuiButtonProfile) {
	fontType = "Marker Felt";
	fontSize = "24";
	fontColor = "0 0 0 255";
	justify = "left";
});
if (!isObject(OldPMDifficultyButtonNAProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldPMDifficultyButtonNAProfile : OldPMDifficultyButtonProfile) {
	fontColor = "120 120 120 255";
});

if (!isObject(OldGuiBigTextEditProfile)) OldGuiProfilesGroup.add(new GuiControlProfile (OldGuiBigTextEditProfile)
{
	fontType = "DomCasualD";
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
});

if (!isObject(OldGuiGreenScrollProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldGuiGreenScrollProfile : GuiPhilScrollProfile) {
	bitmap = "platinum/core/ui/greenscroll";
});

if (!isObject(OldSearchProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldSearchProfile : GuiDefaultProfile) {
	fontType = "Marker Felt";
	fontSize = "24";
	fontColor = "0 0 0 255";
	fontColorHL = "0 0 0 255";
	fillColorHL = "0 0 0 51";
});

if (!isObject(OldSearchShadowProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldSearchShadowProfile : OldSearchProfile) {
	fontColor = "255 255 255 128";
	fontColorHL = "255 255 255 128";
	fillColorHL = "255 255 255 0";
});

if (!isObject(OldMPSearchProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldMPSearchProfile : GuiTextListProfile) {
   fontType = "Marker Felt";
   fontSize = "24";
   fontColor = "255 255 255 255";
   fontColorHL = "255 255 255 255";
   fillColorHL = "255 255 255 51";
});

if (!isObject(OldMPSearchShadowProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldMPSearchShadowProfile : OldMPSearchProfile) {
   fontColor = "0 0 0 128";
   fontColorHL = "0 0 0 128";
   fillColorHL = "255 255 255 0";
});

if(!isObject(OldGuiMediumTextEditProfile)) OldGuiProfilesGroup.add(new GuiControlProfile (OldGuiMediumTextEditProfile : GuiTextProfile)
{
	fontType = "DomCasualD";
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
});

if (!isObject(OldGuiOptionsButtonProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldGuiOptionsButtonProfile : GuiDefaultProfile) {
	fontType = "Marker Felt";
	fontSize = 18;
	justify = "center";
});

if (!isObject(OldGuiOptionsTextEditProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldGuiOptionsTextEditProfile : GuiTextProfile) {
	fontType = "Marker Felt";
	fontSize = 24;
	opaque = false;
	border = false;
	borderColor = "0 0 0";
	autoSizeWidth = false;
	autoSizeHeight = true;
	tab = true;
	canKeyFocus = true;
});

if (!isObject(OldGuiOptionsListProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldGuiOptionsListProfile : GuiDefaultProfile) {
	fontType = "Marker Felt";
	fontSize = 18;
	justify = "left";
	fillColorHL = "255 255 255 0";
});

if(!isObject(OldGuiTransListProfile)) OldGuiProfilesGroup.add(new GuiControlProfile (OldGuiTransListProfile : GuiTextProfile) {
   fillColorHL = "255 255 255 100";
});

if (!isObject(OldGuiLBUserlistProfile)) OldGuiProfilesGroup.add(new GuiControlProfile (OldGuiLBUserlistProfile : OldGuiTransListProfile) {
  fontType = "DomCasualD";
  fontSize = 24;
  opaque = true;
  mouseoverselected = true;
  fillcolor = "192 192 192 255";
  fillColorHL = "255 255 255 255";
  fontColors[0] = "204 0 0";
  fontColors[1] = "0 0 204";
  fontColors[2] = "0 0 0";
  fontColorhl = "0 0 204 255";
});

if(!isObject(OldJSTextListProfile)) OldGuiProfilesGroup.add(new GuiControlProfile (OldJSTextListProfile : GuiTextListProfile) {
   fontType = "Marker Felt";
   fontSize = 18;
   fontColors[0] = "255 255 255 255";
   fontColors[1] = "240 255 240 255";
   fontColors[2] = "240 240 255 255";
   fontColors[3] = "255 255 255 255";
   fontColors[4] = "255 240 240 255";
   fontColors[5] = "240 240 240 255";
   fontColors[6] = "200 255 255 255";
   fillColor = "0 0 0 0";
   fillColorHL = "255 255 255 51";
   fillColorNA = "255 255 255 51";
   fontColorNA = "153 153 153";
});

if(!isObject(OldJSTextListProfile2)) OldGuiProfilesGroup.add(new GuiControlProfile (OldJSTextListProfile2 : OldJSTextListProfile) {
   fontColors[0] = "0 0 0 128";
   fontColors[1] = "0 0 0 128";
   fontColors[2] = "0 0 0 128";
   fontColors[3] = "0 0 0 128";
   fontColors[4] = "0 0 0 128";
   fontColors[5] = "0 0 0 128";
   fontColors[6] = "0 0 0 128";
});

if (!isObject(OldMPDifficultyButtonProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldMPDifficultyButtonProfile : GuiButtonProfile) {
   fontType = "Marker Felt";
   fontSize = "24";
   fontColor = "0 0 0 255";
});

if (!isObject(OldGuiMPUserlistProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldGuiMPUserlistProfile : GuiTransListProfile) {
   fontType = "Marker Felt";
   fontSize = "18";
   mouseoverselected = true;
   fontColors[0] = "153 0 0";
   fontColors[1] = "0 0 204";
   fontColors[2] = "0 0 0";
});

if (!isObject(OldGuiMPDifficultyButtonProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldGuiMPDifficultyButtonProfile : GuiButtonProfile) {
   fontType = "Marker Felt";
   fontSize = "24";
   fontColor = "255 255 255 255";
   textOffset = "20 0";
   justify = "left";
});

if (!isObject(OldMPDifficultyButtonProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldMPDifficultyButtonProfile : GuiButtonProfile) {
   fontType = "Marker Felt";
   fontSize = "24";
   fontColor = "0 0 0 255";
});

if (!isObject(OldGuiMPPlayerlistProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldGuiMPPlayerlistProfile : GuiTransListProfile) {
   fontType = "Marker Felt";
   fontSize = "18";
   mouseoverselected = false;
   fontColor = "255 255 255";
   fontColors[1] = "0 0 0";
   fontColors[2] = "255 0 0";
   fontColors[3] = "255 255 0";
   fontColors[4] = "0 255 0";
   fontColors[5] = "0 255 255";
   fontColors[6] = "0 0 255";
   fontColors[7] = "255 0 255";
   fontColors[8] = "255 128 0";
   fontColors[9] = "128 0 255";
});

if (!isObject(OldGuiMPPlayerlistProfile2)) OldGuiProfilesGroup.add(new GuiControlProfile(OldGuiMPPlayerlistProfile2 : OldGuiMPPlayerlistProfile) {
   fontColor = "0 0 0 128";
   fontColors[1] = "0 0 0 128";
   fontColors[2] = "0 0 0 128";
   fontColors[3] = "0 0 0 128";
   fontColors[4] = "0 0 0 128";
   fontColors[5] = "0 0 0 128";
   fontColors[6] = "0 0 0 128";
   fontColors[7] = "0 0 0 128";
   fontColors[8] = "0 0 0 128";
   fontColors[9] = "0 0 0 128";
});

if (!isObject(OldMPTeamJoinListProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldMPTeamJoinListProfile : GuiTransListProfile) {
   fontColors[0] = "0 0 0 255";
   fontColors[1] = "153 0 0 255";  
   fontColors[2] = "153 153 0 255"; 
   fontColors[3] = "0 153 0 255";  
   fontColors[4] = "0 153 153 255"; 
   fontColors[5] = "0 0 153 255";   
   fontColors[6] = "153 0 153 255";
   fontColors[7] = "153 77 0 255"; 
   fontColors[8] = "77 0 153 255"; 
});

if (!isObject(OldGuiMLProgressProfile)) OldGuiProfilesGroup.add(new GuiControlProfile(OldGuiMLProgressProfile) {
  opaque = false;
  fillColor = "255 255 255 100";
  border = false;
});