//------------------------------------------------------------------------------
// Scenery For PQ
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

// TODO: MMS made some amazing skies for his levels.
// I'd like these rotating clouds done and put in SSD-SCenery.cs
// This can mean all levels can have those

// --- Scenery ---
// Clouds: Cloud48, Cloud36, Cloud24, FlatLargeClouds, Orbiting Clouds
// Fences: Fences of 1-5 tiles, Fence pole
// Vegetation: Plants, Ferns, Flowers, Tulips, Effect Plants, Grass, Large Grass, Grass 2 Small, Grass 2 Large, Vine (non-existent), Trees, Rocks
// Graffiti
// Sand Hills
// Space: Asteroid


//---------------------------------------------------------------------
// 36 Clouds

datablock StaticShapeData(Cloud48) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Clouds";
	shapeFile = "~/data/shapes_pq/Scenery/Clouds/Cloud48.dts";
	skin[0] = "base";
	skin[1] = "lb";
	skin[2] = "y";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
datablock StaticShapeData(Cloud36 : Cloud48) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Clouds";
	shapeFile = "~/data/shapes_pq/Scenery/Clouds/Cloud36.dts";
	skin[0] = "base";
	skin[1] = "lb";
	skin[2] = "y";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
datablock StaticShapeData(Cloud24) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Clouds";
	shapeFile = "~/data/shapes_pq/Scenery/Clouds/Cloud24.dts";
	skin[0] = "base";
	skin[1] = "b03";
	skin[2] = "b04";
	skin[3] = "b05";
	skin[4] = "b06";
	skin[5] = "b07";
	skin[6] = "b08";
	skin[7] = "b09";
	skin[8] = "b10";
	skin[9] = "b11";
	skin[10] = "lb02";
	skin[11] = "lb03";
	skin[12] = "lb04";
	skin[13] = "lb05";
	skin[14] = "lb06";
	skin[15] = "lb07";
	skin[16] = "lb08";
	skin[17] = "lb09";
	skin[18] = "lb10";
	skin[19] = "lb11";
	skin[20] = "y02";
	skin[21] = "y03";
	skin[22] = "y04";
	skin[23] = "y05";
	skin[24] = "y06";
	skin[25] = "y07";
	skin[26] = "y08";
	skin[27] = "y09";
	skin[28] = "y10";
	skin[29] = "y11";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

// Flat clouds - require MO to actually do something

datablock StaticShapeData(FlatLargeClouds) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Clouds";
	shapeFile = "~/data/shapes_pq/Scenery/Clouds/flatlarge.dts";
};

// Orbiting clouds (animated)

datablock StaticShapeData(OrbitingClouds) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Clouds";
	shapeFile = "~/data/shapes_pq/Scenery/Clouds/cloudscape.dts";

	customField[0, "field"  ] = "reverse";
	customField[0, "type"   ] = "boolean";
	customField[0, "name"   ] = "Reverse Direction";
	customField[0, "desc"   ] = "If the clouds should spin backwards.";
	customField[0, "default"] = "0";
};

function OrbitingClouds::onAdd(%this, %obj) {
	if (!%obj.reverse)
		%obj.playThread(0, "orbit");
	else
		%obj.playThread(0, "orbit-reverse");
	Scenery::onAdd(%this, %obj);
}

//---------------------------------------------------------------------
// Fences
// Note: To avoid camera collision, please use TSSTATIC
// TODO: Please write this as part of the Level Editor help guide

datablock StaticShapeData(Fence_1TilesLength) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Fence (Camera Collision)";
	shapeFile = "~/data/shapes_pq/Scenery/Fence/Fence_1TilesLength.dts";
};

datablock StaticShapeData(Fence_2TilesLength : Fence_1TilesLength) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/Fence_2TilesLength.dts";
};

datablock StaticShapeData(Fence_3TilesLength : Fence_1TilesLength) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/Fence_3TilesLength.dts";
};

datablock StaticShapeData(Fence_4TilesLength : Fence_1TilesLength) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/Fence_4TilesLength.dts";
};

datablock StaticShapeData(Fence_5TilesLength : Fence_1TilesLength) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/Fence_5TilesLength.dts";
};

datablock StaticShapeData(FencePole : Fence_1TilesLength) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/Fence_Pole.dts";
};

//construction fences
datablock StaticShapeData(Metal_End_Fence_Short) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Fence (Camera Collision)";
	shapeFile = "~/data/shapes_pq/Scenery/Fence/MetalEndFenceShort.dts";
};

datablock StaticShapeData(Metal_Start_Fence_Short : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/MetalStartFenceShort.dts";
};

datablock StaticShapeData(Metal_Pole_Fence_Short : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/MetalPoleFenceLong.dts";
};

datablock StaticShapeData(Metal_End_Fence_Tall : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/MetalEndFenceTall.dts";
};

datablock StaticShapeData(Metal_Start_Fence_Tall : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/MetalStartFenceTall.dts";
};

datablock StaticShapeData(Metal_Pole_Fence_Tall : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/MetalPoleFenceShort.dts";
};

//plastic fence
datablock StaticShapeData(Plastic_End_Fence_Short : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/PlasticEndFenceShort.dts";
};

datablock StaticShapeData(Plastic_Start_Fence_Short : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/PlasticStartFenceShort.dts";
};

datablock StaticShapeData(Plastic_Pole_Fence_Short : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/PlasticPoleFenceLong.dts";
};

datablock StaticShapeData(Plastic_End_Fence_Tall : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/PlasticEndFenceTall.dts";
};

datablock StaticShapeData(Plastic_Start_Fence_Tall : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/PlasticStartFenceTall.dts";
};

datablock StaticShapeData(Plastic_Pole_Fence_Tall : Metal_End_Fence_Short) {
	shapeFile = "~/data/shapes_pq/Scenery/Fence/PlasticPoleFenceShort.dts";
};



//---------------------------------------------------------------------
// Vegetation

datablock StaticShapeData(Plant01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/Plant.dts";
	renderDistance = "100";
	skin[0] = "base";
	skin[1] = "light";
	skin[2] = "dark";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

datablock StaticShapeData(Fern01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/fern01.dts";
	renderDistance = "100";
	skin[0] = "base";
	skin[1] = "light";
	skin[2] = "dark";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

datablock StaticShapeData(Flowers) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/Flowers.dts";
	renderDistance = "100";
	skin[0] = "base";
	skin[1] = "yellow";
	skin[2] = "green";
	skin[3] = "turquoise";
	skin[4] = "blue";
	skin[5] = "navy";
	skin[6] = "purple";
	skin[7] = "pink";
	skin[8] = "red";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

function Scenery::onAdd(%this, %obj) {
	if (%obj.skin !$= "") {
		%obj.setSkinName(%obj.skin);
	}
	if (!$pref::noGroupsPlz) {
		if (!isObject(SceneryGroup)) {
			new SimGroup(SceneryGroup);
			MissionGroup.add(SceneryGroup);
			bumpMissionGroup(SceneryGroup);
		}
		SceneryGroup.schedule(100, add, %obj);
	}
}

function buildFlowerBed(%x, %y, %amt, %variety) {
	for (%i = 0; Flowers.skin[%i] !$= ""; %i++)
		%skincount++;

	if (%variety > %skincount)
		%variety = %skincount;
	else if (%variety < 1)
		%variety = 1;

	%mp = marbleObject.getPosition();
	%mx = getWord(%mp, 0);
	%my = getWord(%mp, 1);
	%mz = getWord(%mp, 2);

	for (%i = 0; %i < %amt; %i++) {
		%rand = getRandom(%variety - 1);
		%db = Flowers.skin[%rand];            // get one of available colors for spawn

		%fx = %mx + (getRandom(%x * 100) / 100) - (%mx / 2);
		%fy = %my + (getRandom(%y * 100) / 100) - (%my / 2);

		new StaticShape() {
			datablock = "Flowers";
			position = %fx SPC %fy SPC %mz - 0.25;
			rotation = "0 0 1" SPC getrandom(360);
			skin = Flowers.skin[%rand];
		};
	}
}
//------------------------------------------------------
//Tulips
//Yes I do know these comments take space
//No I don't give a damn
//Yes they are here in order for me to get arround faster
//------------------------------------------------------
datablock StaticShapeData(Tulip) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/tulip.dts";
	renderDistance = "100";
	skin[0] = "base";
	skin[1] = "blue";
	skin[2] = "green";
	skin[3] = "purple";
	skin[4] = "yellow";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

datablock StaticShapeData(Scarce_Tulips : Tulip) {
	shapeFile = "~/data/shapes_pq/Scenery/Nature/scarce_tulip.dts";
};

datablock StaticShapeData(Dense_Tulips : Tulip) {
	shapeFile = "~/data/shapes_pq/Scenery/Nature/dense_tulip.dts";
};
datablock StaticShapeData(Scarce_tulips_3tiles : Tulip) {
	shapeFile = "~/data/shapes_pq/Scenery/Nature/dense_tulip_3tiles.dts";
};
//----------------------------------------------
//Effect plants
//----------------------------------------------
datablock StaticShapeData(EffectPlant) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation - Other";
	shapeFile = "~/data/shapes_pq/Other/EffectPlant.dts";
	renderDistance = "100";
	skin[0] = "base";
	skin[1] = "red";
	skin[2] = "blue";
	skin[3] = "yellow";
	skin[4] = "pink";
	skin[5] = "cyan";
	skin[6] = "orange";
	skin[7] = "white";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
//------------------------------------------------
//Weed
//------------------------------------------------
datablock StaticShapeData(Grass) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/grass.dts";
	renderDistance = "100";
};

datablock StaticShapeData(LargeGrass) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/grasslarge.dts";
	renderDistance = "100";
};

datablock StaticShapeData(Grass02Small) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/scarce_grass_small.dts";
	renderDistance = "100";
};

// nuked this file out of orbit as it crashes the game
//datablock StaticShapeData(Grass02Large : Grass02Small) {
//	shapeFile = "~/data/shapes_pq/Scenery/Nature/scarce_grass_large.dts";
//};

datablock StaticShapeData(Grass02DenseSmall : Grass02Small) {
	shapeFile = "~/data/shapes_pq/Scenery/Nature/dense_grass_small.dts";
};

datablock StaticShapeData(Grass02DenseLarge : Grass02Small) {
	shapeFile = "~/data/shapes_pq/Scenery/Nature/dense_grass_large.dts";
};
//------------------------------------------------
//Went green
//------------------------------------------------
datablock StaticShapeData(NaturalPlant) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	// shapeFile = "~/data/shapes_pq/Scenery/Nature/NaturalPlant.dts";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/fern01.dts";
	renderDistance = "100";
	// skin[0] = "base";
	// skin[1] = "dry";
	// skin[2] = "green";
	skin[0] = "base";
	skin[1] = "light";
	skin[2] = "dark";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
//------------------------------------------------
//Vines
//------------------------------------------------

datablock StaticShapeData(VinesWideLong) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/VinesWideLong.dts";
};
datablock StaticShapeData(VinesWideShort) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/VinesWideShort.dts";
};
datablock StaticShapeData(VinesThinLong) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/VinesThinLong.dts";
};
datablock StaticShapeData(VinesThinShort) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/VinesThinShort.dts";
};

//---------------------------------------------
//Trees
//Someone optimize this shit, the old method doesn't seem to work....
datablock StaticShapeData(Tree01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/Tree01.dts";
	skin[0] = "base";
	skin[1] = "summer";
	skin[2] = "autumn";
	skin[3] = "winter";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
datablock StaticShapeData(Tree02) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/Tree02.dts";
	skin[0] = "base";
	skin[1] = "summer";
	skin[2] = "autumn";
	skin[3] = "winter";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
datablock StaticShapeData(Tree03) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/Tree03.dts";
	skin[0] = "base";
	skin[1] = "summer";
	skin[2] = "autumn";
	skin[3] = "winter";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
datablock StaticShapeData(TreeBare01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/TreeBare01.dts";
};
datablock StaticShapeData(TreeBare02) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/TreeBare02.dts";
};
datablock StaticShapeData(TreeBare03) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Vegetation";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/TreeBare03.dts";
};
datablock StaticShapeData(FirTreeM01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "TreesBM";
	shapeFile = "~/data/shapes_bm/Scenery/Trees/FirTreeM1.dts";
};
datablock StaticShapeData(FirTreeM02) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "TreesBM";
	shapeFile = "~/data/shapes_bm/Scenery/Trees/FirTreeM2.dts";
};
datablock StaticShapeData(FirTreeM03) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "TreesBM";
	shapeFile = "~/data/shapes_bm/Scenery/Trees/FirTreeM3.dts";
};
datablock StaticShapeData(PineTreeL01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "TreesBM";
	shapeFile = "~/data/shapes_bm/Scenery/Trees/PineTreeL1.dts";
};
datablock StaticShapeData(PineTreeL02) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "TreesBM";
	shapeFile = "~/data/shapes_bm/Scenery/Trees/PineTreeL2.dts";
};
datablock StaticShapeData(PineTreeL03) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "TreesBM";
	shapeFile = "~/data/shapes_bm/Scenery/Trees/PineTreeL3.dts";
};
datablock StaticShapeData(PineTreeM01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "TreesBM";
	shapeFile = "~/data/shapes_bm/Scenery/Trees/PineTreeM1.dts";
};
datablock StaticShapeData(PineTreeM02) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "TreesBM";
	shapeFile = "~/data/shapes_bm/Scenery/Trees/PineTreeM2.dts";
};
datablock StaticShapeData(PineTreeM03) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "TreesBM";
	shapeFile = "~/data/shapes_bm/Scenery/Trees/PineTreeM3.dts";
};
//-------------------------------------------------
//Rocks

datablock StaticShapeData(Rock01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Nature Obstacles";
	shapeFile = "~/data/shapes_pq/Scenery/Nature/Rock01.dts";
	env_map=true;
	skin[0] = "base";
	skin[1] = "gray";
	skin[2] = "reddish";
	skin[3] = "sandy";
	skin[4] = "white";
	skin[5] = "thisiscoal";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
datablock StaticShapeData(Rock02 : Rock01) {
	shapeFile = "~/data/shapes_pq/Scenery/Nature/Rock02.dts";
};
datablock StaticShapeData(Rock03 : Rock01) {
	shapeFile = "~/data/shapes_pq/Scenery/Nature/Rock03.dts";
};
datablock StaticShapeData(Rock04 : Rock01) {
	shapeFile = "~/data/shapes_pq/Scenery/Nature/Rock04.dts";
};
datablock StaticShapeData(RockRoundL01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "RocksBM";
	shapeFile = "~/data/shapes_bm/Scenery/Rocks/RockRoundL1.dts";
};
datablock StaticShapeData(RockRoundL02) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "RocksBM";
	shapeFile = "~/data/shapes_bm/Scenery/Rocks/RockRoundL2.dts";
};
datablock StaticShapeData(RockRoundL03) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "RocksBM";
	shapeFile = "~/data/shapes_bm/Scenery/Rocks/RockRoundL3.dts";
};
datablock StaticShapeData(RockRoundL04) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "RocksBM";
	shapeFile = "~/data/shapes_bm/Scenery/Rocks/RockRoundL4.dts";
};
datablock StaticShapeData(RockRoundL05) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "RocksBM";
	shapeFile = "~/data/shapes_bm/Scenery/Rocks/RockRoundL5.dts";
};
datablock StaticShapeData(RockWall01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "RocksBM";
	shapeFile = "~/data/shapes_bm/Scenery/Rocks/RockWall1.dts";
};
datablock StaticShapeData(RockWall02) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "RocksBM";
	shapeFile = "~/data/shapes_bm/Scenery/Rocks/RockWall2.dts";
};
datablock StaticShapeData(RockWall03) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "RocksBM";
	shapeFile = "~/data/shapes_bm/Scenery/Rocks/RockWall3.dts";
};
datablock StaticShapeData(RockWall04) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "RocksBM";
	shapeFile = "~/data/shapes_bm/Scenery/Rocks/RockWall4.dts";
};

function Rock01::onAdd(%this, %obj) {
	if (%obj.skin $= "" || %obj.skin $= "base") {
		if (getRandom() < 0.01) {
			%obj.setSkinName("tinted");
		}
	}
}

//---------------------------------------------------------------------
// Graffiti

datablock StaticShapeData(Marble_Graffiti) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Graffiti";
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_marble.dts";
	zdrop = 0.01;
};

datablock StaticShapeData(SuperJump_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_sj.dts";
};
datablock StaticShapeData(Cannon_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_cannon.dts";
};
datablock StaticShapeData(PQ_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_pq.dts";
};
datablock StaticShapeData(PQRulez_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_pqrulez.dts";
};
datablock StaticShapeData(Logo_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_logo.dts";
};
datablock StaticShapeData(GG_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_GG.dts";
};
datablock StaticShapeData(GGlogo_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_gglogo.dts";
};
datablock StaticShapeData(PhilsEmpire_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_pe.dts";
};
datablock StaticShapeData(Tornado_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_tornado.dts";
};
datablock StaticShapeData(Hourglass_Graffiti : Marble_Graffiti) {
	shapeFile = "~/data/shapes_pq/Scenery/Graffiti/graffiti_hourglass.dts";
};

//---------------------------------------------------------------------
// Sand hills

datablock StaticShapeData(Sandhill01) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Obstacles";
	shapeFile = "~/data/shapes_pq/Scenery/Obstacles/Sandhill1.dts";
};

datablock StaticShapeData(Sandhill02 : Sandhill01) {
	shapeFile = "~/data/shapes_pq/Scenery/Obstacles/Sandhill2.dts";
};

datablock StaticShapeData(Sandhill03 : Sandhill01) {
	shapeFile = "~/data/shapes_pq/Scenery/Obstacles/Sandhill3.dts";
};

datablock StaticShapeData(Sandhill04 : Sandhill01) {
	shapeFile = "~/data/shapes_pq/Scenery/Obstacles/Sandhill4.dts";
};

datablock StaticShapeData(Sandhill05 : Sandhill01) {
	shapeFile = "~/data/shapes_pq/Scenery/Obstacles/Sandhill5.dts";
};

//---------------------------------------------------------------------
// :Space:
// Asteroid

datablock StaticShapeData(Asteroid) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Space";
	shapeFile = "~/data/shapes_pq/LevelParts/asteroid.dts";
};

//-----------------------------------------------------------------------------
// Level Parts for PQ
//-----------------------------------------------------------------------------
// PQ Windows
// If there are any visual errors bug me after release of pq to fix them. Srssly can't be bothered with this shit anymore due to finals.
//-----------------------------------------------------------------------------
datablock StaticShapeData(Window01) {
	className = "Scenery";
	superCategory = "Level Parts";
	category = "Windows";
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01.dts";
};
datablock StaticShapeData(Window01) {
	className = "Scenery";
	superCategory = "Level Parts";
	category = "Windows";
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01.dts";
	skin[0] = "base";
	skin[1] = "lighter";
	skin[2] = "darker";
	skin[3] = "red";
	skin[4] = "red_lighter";
	skin[5] = "red_darker";
	skin[6] = "blu";
	skin[7] = "blu_lighter";
	skin[8] = "blu_darker";
	skin[9] = "green";
	skin[10] = "green_lighter";
	skin[11] = "green_darker";
	skin[12] = "yellow";
	skin[13] = "yellow_lighter";
	skin[14] = "yellow_darker";
	skin[15] = "threefolder";
	skin[16] = "threefolder_lighter";
	skin[17] = "threefolder_darker";


	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
datablock StaticShapeData(Window01_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01_light.dts";
};
datablock StaticShapeData(Window01_3x3 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01_3x3.dts";
};
datablock StaticShapeData(Window01_3x3_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01_3x3_light.dts";
};
datablock StaticShapeData(Window01_6x6 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01_6x6.dts";
};
datablock StaticShapeData(Window01_6x6_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01_6x6_light.dts";
};
datablock StaticShapeData(Window01_12x12 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01_12x12.dts";
};
datablock StaticShapeData(Window01_12x12_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01_12x12_light.dts";
};
datablock StaticShapeData(Window01_3x12 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01_3x12.dts";
};
datablock StaticShapeData(Window01_3x12_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01_3x12_light.dts";
};
//chircles 01
datablock StaticShapeData(Window01O : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01O.dts";
};
datablock StaticShapeData(Window01O_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01O_light.dts";
};
datablock StaticShapeData(Window01O_3x3 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01O_3x3.dts";
};
datablock StaticShapeData(Window01O_3x3_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01O_3x3_light.dts";
};
datablock StaticShapeData(Window01O_6x6 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01O_6x6.dts";
};
datablock StaticShapeData(Window01O_6x6_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01O_6x6_light.dts";
};
//reg 02
datablock StaticShapeData(Window02 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window01.dts";
};
datablock StaticShapeData(Window02_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window02_light.dts";
};
datablock StaticShapeData(Window02_3x3 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window02_3x3.dts";
};
datablock StaticShapeData(Window02_3x3_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window02_3x3_light.dts";
};

//chircles 02
datablock StaticShapeData(Window02O : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window02O.dts";
};
datablock StaticShapeData(Window02O_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window02O_light.dts";
};
datablock StaticShapeData(Window02O_3x3 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window02O_3x3.dts";
};
datablock StaticShapeData(Window02O_3x3_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window02O_3x3_light.dts";
};
//reg 03
datablock StaticShapeData(Window03 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window03.dts";
};
datablock StaticShapeData(Window03_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window03_light.dts";
};
datablock StaticShapeData(Window03_3x3 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window03_3x3.dts";
};
datablock StaticShapeData(Window03_3x3_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window03_3x3_light.dts";
};

//chircles 03
datablock StaticShapeData(Window03O : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window03O.dts";
};
datablock StaticShapeData(Window03O_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window03O_light.dts";
};
datablock StaticShapeData(Window03O_3x3 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window03O_3x3.dts";
};
datablock StaticShapeData(Window03O_3x3_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window03O_3x3_light.dts";
};
//reg 04
datablock StaticShapeData(Window04 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window04.dts";
};
datablock StaticShapeData(Window04_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window04_light.dts";
};
datablock StaticShapeData(Window04_3x3 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window04_3x3.dts";
};
datablock StaticShapeData(Window04_3x3_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window04_3x3_light.dts";
};

//chircles 04
datablock StaticShapeData(Window04O : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window04O.dts";
};
datablock StaticShapeData(Window04O_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window04O_light.dts";
};
datablock StaticShapeData(Window04O_3x3 : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window04O_3x3.dts";
};
datablock StaticShapeData(Window04O_3x3_light : Window01) {
	shapeFile = "~/data/shapes_pq/Scenery/Windows/Window04O_3x3_light.dts";
};

//Blasted
datablock StaticShapeData(Glass_BM : Window01) {
	shapeFile = "~/data/shapes_bm/scenery/bm_glass.dts";
};


//-----------------------------------------------------------------------
//----------------END OF WINDOWS-----------------------------------------
//-----------------------------------------------------------------------
datablock StaticShapeData(LapsRing) {
	className = "LapsRingClass";
	category = "Gameplay";
	shapeFile = "~/data/shapes_pq/Gameplay/ring_3.dts";
};

// datablock StaticShapeData(CurvedPlatform_2Radius_2Height) {
// 	className = "LevelParts";
// 	superCategory = "Level Parts";
// 	category = "Multi Decker";
// 	shapeFile = "~/data/shapes_pq/LevelParts/Platforms/CurvedPlatform_2Radius_2Height.dts";
// };

// datablock StaticShapeData(CurvedPlatform_2Radius_2Height_180) {
// 	className = "LevelParts";
// 	superCategory = "Level Parts";
// 	category = "Multi Decker";
// 	shapeFile = "~/data/shapes_pq/LevelParts/Platforms/CurvedPlatform_2Radius_2Height_180.dts";
// };

datablock StaticShapeData(Marblius) {
	className = "LevelParts";
	superCategory = "Level Parts";
	category = "MarbliusInAMinute";
	shapeFile = "~/data/shapes_pq/LevelParts/Marblius.dts";
};

datablock StaticShapeData(Propeller_BM_Base) {
	className = "LevelParts";
	superCategory = "Level Parts";
	category = "Propeller Base";
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/Blasted/bm_propeller_base.dts";
};

//-----------------------------------------------------------------------------
// Other
//-----------------------------------------------------------------------------

datablock StaticShapeData(Spectrum) {
	className = "EffectShape";
	category = "Other";
	shapeFile = "~/data/shapes_pq/Other/Spectrum.dts";
};

datablock StaticShapeData(Spectrum2: Spectrum) {
	className = "EffectShape";
	category = "Other";
	shapeFile = "~/data/shapes_pq/Other/Spectrum_sub.dts";
};

datablock StaticShapeData(Spectrum3: Spectrum) {
	className = "EffectShape";
	category = "Other";
	shapeFile = "~/data/shapes_pq/Other/Spectrum_unlit.dts";
};

datablock StaticShapeData(Spectrum4: Spectrum) {
	className = "EffectShape";
	category = "Other";
	shapeFile = "~/data/shapes_pq/Other/Spectrum_sub_unlit.dts";
};

datablock StaticShapeData(WireBall) {
	className = "Misc";
	category = "Other";
	shapeFile = "~/data/shapes_pq/Other/wireball.dts";
};

datablock StaticShapeData(soundstage) {
	classname = "Misc";
	category = "Other";
	shapeFile = "~/data/shapes_pq/other/soundstage.dts";
};

datablock StaticShapeData(EffectBox) {
	classname = "Misc";
	category = "Other";
	shapeFile = "~/data/shapes_pq/Other/Box/box.dts";
};

//datablock StaticShapeData(Colmesh)
//{
//className = "LevelParts";
//category = "Other";
//shapeFile = "~/data/shapes_pq/colmesh.dts";
//};

datablock StaticShapeData(PillowOnUse) {
	className = "Misc";
	category = "Other";
	shapeFile = "~/data/shapes_pq/Gameplay/Powerups/pillow2.dts";
};

//------------------------------------------------------------------
//Construction Scenery PQ
datablock StaticShapeData(Barrier) {
	className = "Scenery";
	superCategory = "Scenery";
	category = "Construction";
	shapeFile = "~/data/shapes_pq/Scenery/Construction/DetourBars.dts";
};