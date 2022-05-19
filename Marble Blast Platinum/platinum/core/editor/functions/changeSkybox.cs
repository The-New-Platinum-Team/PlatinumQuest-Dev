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

function csbbutton(%revert) {
	%pos = LFDWScroll.getPosition();
	LargeFunctionDlg.init("applyDML", "Change Skybox", 1);

	%skies = "";
	for (%file = findFirstFile($usermods @ "*.dml"); %file !$= ""; %file = findNextFile($usermods @ "*.dml")) {
		%name = fileBase(filePath(%file));
		if (strstr(%file, "skies_mbu") >= 0) {
			%name = %name SPC "(MBU)";
		}
		%skies = addRecord(%skies, %file TAB %name);
	}

	%current = Sky.materialList;
	LargeFunctionDlg.addDropMenu("CSB_Sky", "Skybox:", 5, %skies, %current);
}

function applyDML() {
	%dml = CSB_Sky.getValue();

	%sky = Sky.getID();
	new Sky(Sky) {
		position = "0 0 0";
		rotation = "1 0 0 0";
		scale = "1 1 1";
		cloudHeightPer[0] = %sky.cloudheightper0;
		cloudHeightPer[1] = %sky.cloudheightper1;
		cloudHeightPer[2] = %sky.cloudheightper2;
		cloudSpeed1 = %sky.cloudspeed1;
		cloudSpeed2 = %sky.cloudspeed2;
		cloudSpeed3 = %sky.cloudspeed3;
		visibleDistance = %sky.visibledistance;
		useSkyTextures = %sky.useskytextures;
		renderBottomTexture = %sky.renderbottomtexture;
		SkySolidColor = %sky.skysolidcolor;
		fogDistance = %sky.fogdistance;
		fogColor = %sky.fogcolor;
		fogVolume1 = %sky.fogvolume1;
		fogVolume2 = %sky.fogvolume2;
		fogVolume3 = %sky.fogvolume3;
		materialList = %dml;
		windVelocity = %sky.windvelocity;
		windEffectPrecipitation = %sky.windEffectPrecipitation;
		noRenderBans = %sky.norenderbans;
		fogVolumeColor1 = %sky.fogvolumecolor1;
		fogVolumeColor2 = %sky.fogvolumecolor2;
		fogVolumeColor3 = %sky.fogvolumecolor3;
	};
	%sky.delete();
	MissionData.add(Sky);
}
