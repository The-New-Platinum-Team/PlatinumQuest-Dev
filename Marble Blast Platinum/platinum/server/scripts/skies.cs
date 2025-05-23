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

// Skybox data

// Cloudy
// DO NOT USE IN MP - Gemlights disappear due to transparency

datablock StaticShapeData(Cloudy) {
	className = "Skies";
	category = "Skies";
	shapefile = $usermods @ "/data/shapes/Skies/Cloudy/Cloudy.dts";
};

function Cloudy::onAdd(%this, %obj) {
	%obj.playThread(0, "Rotate");
}


// Clear skies

datablock StaticShapeData(Clear) {
	className = "Skies";
	superCategory = "Scenery";
	category = "Skies";
	shapefile = $usermods @ "/data/shapes/Skies/Clear/Clear.dts";

	noBox = "1";
};

function Clear::onAdd(%this, %obj) {
	%obj.playThread(0, "Rotate");
}


// Dusk / Twilight

datablock StaticShapeData(Dusk) {
	className = "Skies";
	superCategory = "Scenery";
	category = "Skies";
	shapefile = $usermods @ "/data/shapes/Skies/Dusk/Dusk.dts";

	noBox = "1";
};

function Dusk::onAdd(%this, %obj) {
	%obj.playThread(0, "Rotate");
}


// Wintry

datablock StaticShapeData(Wintry) {
	className = "Skies";
	superCategory = "Scenery";
	category = "Skies";
	shapefile = $usermods @ "/data/shapes/Skies/Wintry/Wintry.dts";

	noBox = "1";
};

function Wintry::onAdd(%this, %obj) {
	%obj.playThread(0, "Rotate");
}

// Astrolabe

// datablock StaticShapeData(Astrolabe) {
// 	className = "Astrolabe";
// 	superCategory = "Scenery";
// 	category = "Astrolabe";
// 	shapefile = $usermods @ "/data/shapes_mbu/astrolabe/Astrolabe.dts";
// };

function Astrolabe::onAdd(%this, %obj) {

	if (!$pref::LegacyItems) {
		%obj.playThread(0, "ambient");
	} else {
		%obj.playthread(0, "Rotate");
		%obj.setScale("5000 5000 5000");
		%obj.setTransform("336 136 0");
	}

	if (Sky.materialList $= "platinum/data/skies_mbu/intermediate/sky_intermediate.dml")
		%obj.setSkinName("dusk");

	if (Sky.materialList $= "platinum/data/skies_mbu/advanced/sky_advanced.dml")
		%obj.setSkinName("wintry");
}

//MBU Datablocks down below.

if (!$pref::LegacyItems) {
	// Astrolabe MBU
	datablock StaticShapeData(Astrolabe) {
		className = "Astrolabe";
		superCategory = "Scenery";
		category = "Astrolabe";
		shapefile = $usermods @ "/data/shapes_mbu/astrolabe/Astrolabe.dts";

		noBox = "1";
	};

} else {

	// Ugly ass 1.50 MBP sky
	datablock StaticShapeData(Astrolabe) {
		className = "Astrolabe";
		superCategory = "Scenery";
		category = "Astrolabe";
		shapefile = $usermods @ "/data/shapes_mbu/astrolabe/legacy/Ball.dts";
		skin[0] = "base";
		skin[1] = "dusk";
		skin[1] = "wintry";

		noBox = "1";
	};
}
