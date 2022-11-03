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

if ($pref::UseLowResGlass) {
	datablock StaticShapeData(glass_3shape) {
		shapeFile = "~/data/shapes/Glass/3x3.dts";
	};

	datablock StaticShapeData(glass_6shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/6x3.dts";
	};

	datablock StaticShapeData(glass_9shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/9x3.dts";
	};

	datablock StaticShapeData(glass_12shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/12x3.dts";
	};

	datablock StaticShapeData(glass_15shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/15x3.dts";
	};

	datablock StaticShapeData(glass_18shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/18x3.dts";
	};
} else {
	datablock StaticShapeData(glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/3x3.dts";
	};

	datablock StaticShapeData(glass_6shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/6x3.dts";
	};

	datablock StaticShapeData(glass_9shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/9x3.dts";
	};

	datablock StaticShapeData(glass_12shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/12x3.dts";
	};

	datablock StaticShapeData(glass_15shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/15x3.dts";
	};

	datablock StaticShapeData(glass_18shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/18x3.dts";
	};
}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//This whole ass .cs is barren and I'm going to make fucking use of it with Marble Blast XP shapes. - Daniel
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

datablock StaticShapeData(Empty) {
	shapeFile = "~/data/shapes_mbxp/empty.dts";
	className = "LevelParts";
	category = "Other";
};
datablock StaticShapeData(ForceFieldPost) {
	className = "ForceFieldClass";
	shapeFile = "~/data/shapes_mbxp/bumpers/post_only2.dts";
	playAnimation = true;
};
datablock StaticShapeData(ForceFieldBumper : ForceFieldPost) {
	shapeFile = "~/data/shapes_mbxp/bumpers/rail2.dts";
	playAnimation = true;
};

function Empty::onAdd(%this, %obj) {
   if ($TexturePack::MBXP && %obj.realDataBlock $= "ForceFieldPost") {
	%obj.setDataBlock("ForceFieldPost");
	%obj.playThread(0,"ambient_ifl");
   }

   if ($TexturePack::MBXP && %obj.realDataBlock $= "ForceFieldBumper") {
	%obj.setDataBlock("ForceFieldBumper");
	%obj.playThread(0,"ambient_ifl");
   }

   if ($TexturePack::MBXP && %obj.realDataBlock $= "Checkpoint_MBXP") {
	%obj.setDataBlock("Checkpoint_MBXP");
   }
}	

function ForceFieldClass::onAdd(%this, %obj) {
	if (%this.playAnimation)
		%obj.playThread(0,"ambient_ifl");
}	

datablock StaticShapeData(EndPad_MBXP : EndPad) {
	shapeFile = "~/data/shapes_mbxp/pads/endarea.dts";

	playAnimation = true;
};

datablock StaticShapeData(StartPad_MBXP : StartPad) {
	shapeFile = "~/data/shapes_mbxp/pads/startarea.dts";

	playAnimation = true;
};

function EndPad_MBXP::onAdd(%this, %obj) {
	$Game::EndPad = %obj;
	%obj.setName("EndPoint");
	%obj.playThread(0,"ambient_ifl");
	%obj.playThread(1,"effect_loop");
	%obj.playThread(2, "effect_vis");
}

function StartPad_MBXP::onAdd(%this, %obj) {
	$Game::StartPad = %obj;
	%obj.setName("StartPoint");
	%obj.playThread(0,"ambient_ifl");
}

// function StartPad_MBXP::onMissionReset(%this, %obj) {
// 	if (!$Game::Menu) {
// 		if ($Game::State $= "Ready"){
// 			%obj.setThreadDir(%i, false);
// 		}

// 		for (%i = 2; %i < 4; %i++) {
// 			%obj.setThreadDir(%i, true);
// 			%obj.idleSch0 = %obj.schedule(50, "playThread", 2, "effect_vis");
// 			%obj.idleSch1 = %obj.schedule(250, "playThread", 3, "ring_vis");
// 			%obj.idleSch2 = %obj.schedule(2250, "setThreadDir", 3, false);
// 			%obj.idleSch3 = %obj.schedule(2800, "setThreadDir", 2, false);
// 		}
// 	}
// }