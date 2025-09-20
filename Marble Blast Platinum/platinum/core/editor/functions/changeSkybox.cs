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

	LargeFunctionDlg.addNote("\c4----------- Main Game Skyboxes -----------");
	LargeFunctionDlg.addDropMenu("MainGameSkyboxes", "Main Game Skyboxes:", 5, "skies\tGold\nBeginner\tPlatinum Beginner\nIntermediate\tPlatinum Intermediate\nAdvanced\tPlatinum Advanced\nExpert\tPlatinum Expert\nSpaceStation\tPlatinum Space\nBlender1\tPQ One\nBlender2\tPQ Two\nBlender3\tPQ Three\nBlender4\tPQ Four\nbeginner (mbu)\tUltra Beginner\nintermediate (mbu)\tUltra Intermediate\nadvanced (mbu)\tUltra Advanced");
	MainGameSkyboxes.command = "onSelectMGSkybox();";
	LargeFunctionDlg.addNote("\c4----------- All Skyboxes -----------");
	LargeFunctionDlg.addDropMenu("CSB_Sky", "Selected Skybox:", 5, %skies, %current);
	CSB_Sky.command = "UnselectMGSkybox();";
}

function onSelectMGSkybox() {
	if (MainGameSkyboxes.getValue() !$= "") { //If you don't select anything, don't have it override what you already have selected in the other dropdown menu. ~Connie
		CSB_Sky.setValue(MainGameSkyboxes.getValue());
	}
}

function UnselectMGSkybox() { //The reason for this is to not have one dropdown menu be inaccurate to the other, in case a person changes the skybox using the bigger dropdown menu. ~Connie
	MainGameSkyboxes.setValue("");
}

function applyDML() {
	%dml = CSB_Sky.getValue();

	%sky = Sky.getID();
	%sky.changeMaterial(%dml);
}
