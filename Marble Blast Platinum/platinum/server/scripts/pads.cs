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

datablock StaticShapeData(StartPad) {
	className = "StartPadClass";
	category = "Pads";
	shapeFile = "~/data/shapes/pads/startArea.dts";
	scopeAlways = true;
	emap = false;

	skinCount = 0;
	playAnimation = true;
};

datablock StaticShapeData(StartPad_BM : StartPad) {
	shapeFile = "~/data/shapes_bm/pads/startArea.dts";

	skinCount = 0;
	playAnimation = true;
};

datablock StaticShapeData(StartPad_PQ : StartPad) {
	shapeFile = "~/data/shapes_pq/Gameplay/pads/startpad.dts";

	// Seizure's skins from PQ
	skinCount = 5;

	skin[0] = "base";
	skin[1] = "pepto";
	skin[2] = "purple";
	skin[3] = "green";
	skin[4] = "blue";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

datablock StaticShapeData(StartPad_MBG : StartPad) {
	shapeFile = "~/data/shapes/pads/MBGPads/startArea.dts";

	playAnimation = true;
};

datablock StaticShapeData(StartPad_PQ_Construction : StartPad) {
	shapeFile = "~/data/shapes_pq/Gameplay/pads/startpadconst.dts";

	// Construction pad doesn't have animation.
	playAnimation = false;
};

datablock StaticShapeData(StartPad_MBU : StartPad) {
	shapeFile = "~/data/shapes_mbu/pads/mbu/startarea.dts";

	playAnimation = true;
};

function StartPad_MBU::onMissionReset(%this, %obj) {
	if (!$Game::Menu) {
    	%obj.stopThread( 0 );
		%obj.playThread(0, "start");
	}
}

function StartPad_MBM::onAdd(%this,%obj) {
   if ($pref::spchanges && %obj.isTemperable $= "1")
	%obj.setDataBlock("StartPad_MBU");
	return StartPadClass::onAdd(%this, %obj);
}

function EndPad_MBM::onAdd(%this,%obj) {
   if ($pref::spchanges && %obj.isTemperable $= "1") {
	%obj.setDataBlock("EndPad_MBU");
	return EndPad_MBU::onAdd(%this, %obj);
   } else
	return EndPadClass::onAdd(%this, %obj);
}

function StartPadClass::onAdd(%this, %obj) {
	$Game::StartPad = %obj;
	%obj.setName("StartPoint");

	// Some start pads do not play any animation.
	if (%this.playAnimation)
		%obj.playThread(0, "ambient");

	// skin selection, random skin is put in place if the skin was not chosen
	// and there are multiple skins available.
	if (%obj.skin !$= "")
		%obj.setSkinName(%obj.skin);
	else if (%this.skinCount > 0)
		%obj.setSkinName(%this.skin[getRandom(%this.skinCount)]);

    if (Sky.materialList $= "platinum/data/skies/sky_day.dml") {
  		%obj.setDataBlock("StartPad_MBG");

		if ($TexturePack::MBXP && !lb()) {
			%obj.setDataBlock("StartPad_MBXP");
		  	%obj.playThread(0,"ambient_ifl");
		}
   }
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(EndPad) {
	className = "EndPadClass";
	category = "Pads";
	shapeFile = "~/data/shapes/pads/endArea.dts";
	scopeAlways = true;
	emap = false;

	skinCount = 0;
	playAnimation = true;
};

datablock StaticShapeData(EndPad_BM : EndPad) {
	shapeFile = "~/data/shapes_bm/pads/endarea.dts";
	
	skinCount = 0;
};

datablock StaticShapeData(EndPad_PQ : EndPad) {
	shapeFile = "~/data/shapes_pq/Gameplay/pads/endpad.dts";

	// Seizure's skins from PQ
	skinCount = 5;

	skin[0] = "base";
	skin[1] = "cyan";
	skin[2] = "yellow";
	skin[3] = "brown";
	skin[4] = "green";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

datablock StaticShapeData(EndPad_MBG : EndPad) {
	shapeFile = "~/data/shapes/pads/MBGPads/endarea.dts";

	playAnimation = true;
};

datablock StaticShapeData(EndPad_PQ_Construction : EndPad) {
	shapeFile = "~/data/shapes_pq/Gameplay/pads/endpadconst.dts";

	// No animation on construction end pad
	playAnimation = false;
};

datablock StaticShapeData(EndPad_MBU : EndPad) {
	shapeFile = "~/data/shapes_mbu/pads/mbu/endarea.dts";

	playAnimation = true;
};

datablock StaticShapeData(MBU_LightBeam : EndPad) {
	className = "";
	shapefile = "~/data/shapes_mbu/pads/mbu/lightbeam.dts";
};

function EndPad_MBU::onAdd(%this, %obj) {
	$Game::EndPad = %obj;
	%obj.setName("EndPoint");

	%temp = new StaticShape() {
		datablock = MBU_LightBeam;
		position = %obj.getPosition();
		rotation = %rotation;
		scale = %obj.getScale();
	};
	%temp.setParent(%obj, "0 0 0 1 0 0 0", true, "0 0 0");
	%obj._mbulightbeam = %temp;
	MissionCleanup.add(%temp);
}

function EndPad_MBU::onEditorDrag(%this, %obj) {
	%obj._mbulightbeam.setTransform(%obj.getTransform());
	%obj._mbulightbeam.setScale(%obj.getScale());
}

function EndPad_MBU::onInspectApply(%this, %obj) {
	%obj._mbulightbeam.setTransform(%obj.getTransform());
	%obj._mbulightbeam.setScale(%obj.getScale());
}

function EndPadClass::onAdd(%this, %obj) {
	$Game::EndPad = %obj;
	%obj.setName("EndPoint");

	if (%this.playAnimation)
		%obj.playThread(0,"ambient");

	// skin selection, random skin is put in place if the skin was not chosen
	// and there are multiple skins available.
	if (%obj.skin !$= "")
		%obj.setSkinName(%obj.skin);
	else if (%this.skinCount > 0)
		%obj.setSkinName(%this.skin[getRandom(%this.skinCount)]);

    if (Sky.materialList $= "platinum/data/skies/sky_day.dml") {
  		%obj.setDataBlock("EndPad_MBG");

		if ($TexturePack::MBXP && !lb()) {
			%obj.setDataBlock("EndPad_MBXP");
		  	%obj.playThread(0,"ambient_ifl");
		  	%obj.playThread(1,"effect_loop");
			%obj.playThread(2, "effect_vis");
		}
   }
}

//MBM Datablocks down below.

if (!$pref::LegacyItems) {
	datablock StaticShapeData(EndPad_MBM : EndPad) {
		shapeFile = "~/data/shapes_mbu/pads/endarea.dts";
		skin[0] = "base";
		skin[1] = "mbm";
		
		customField[0, "field"  ] = "skin";
		customField[0, "type"   ] = "string";
		customField[0, "name"   ] = "Skin Name";
		customField[0, "desc"   ] = "Which skin to use (see skin selector).";
		customField[0, "default"] = "base";

		playAnimation = true;
	};

	datablock StaticShapeData(StartPad_MBM : StartPad) {
		shapeFile = "~/data/shapes_mbu/pads/startarea.dts";
		skin[0] = "base";
		skin[1] = "mbm";

		customField[0, "field"  ] = "skin";
		customField[0, "type"   ] = "string";
		customField[0, "name"   ] = "Skin Name";
		customField[0, "desc"   ] = "Which skin to use (see skin selector).";
		customField[0, "default"] = "base";

		playAnimation = true;
	};
} else {
	datablock StaticShapeData(EndPad_MBM : EndPad) {
		shapeFile = "~/data/shapes/pads/endarea.dts";

		playAnimation = true;
	};

	datablock StaticShapeData(StartPad_MBM : StartPad) {
		shapeFile = "~/data/shapes/pads/startarea.dts";

		playAnimation = true;
	};
}
