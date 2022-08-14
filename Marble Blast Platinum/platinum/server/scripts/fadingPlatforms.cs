//-----------------------------------------------------------------------------
// fadingPlatform.cs
//
// Copyright (c) 2009 The Platinum Team
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

datablock StaticShapeData(FadePlatform) {
	category = "FadingPlatforms";
	superCategory = "Level Parts";
	className = "FadePlatformClass";
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/FadePlatform.dts";
	emap = false;

	// TODO: rethink which textures to use, perhaps use more. Remove frictions as they do not take effect.
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
	skin[5] = "skin4";
	skin[6] = "skin5";
	skin[7] = "skin6";
	skin[8] = "skin7";
	skin[9] = "skin8";
	skin[10] = "skin9";
	skin[11] = "skin10";
	skin[12] = "skin11";
	skin[13] = "skin12";
	skin[14] = "skin13";
	skin[15] = "skin14";
	skin[16] = "skin15";
	skin[17] = "skin16";
	skin[18] = "skin17";
	skin[19] = "skin18";
	skin[20] = "skin19";
	skin[21] = "skin20";
	skin[22] = "skin21";
	skin[23] = "skin22";
	skin[24] = "skin23";
	skin[25] = "skin24";
	skin[26] = "skin25";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "skin0";
	customField[1, "field"  ] = "functionality";
	customField[1, "type"   ] = "enum";
	customField[1, "name"   ] = "Functionality";
	customField[1, "desc"   ] = "What type of fading platform this is.";
	customField[1, "default"] = "trapdoor";
	customEnum["functionality", 0, "value"] = "trapdoor";
	customEnum["functionality", 0, "name" ] = "Trapdoor";
	customEnum["functionality", 1, "value"] = "fading";
	customEnum["functionality", 1, "name" ] = "Fading";
	customEnum["functionality", 2, "value"] = "periodic";
	customEnum["functionality", 2, "name" ] = "Periodic";
	customField[2, "field"  ] = "fadeStyle";
	customField[2, "type"   ] = "enum";
	customField[2, "name"   ] = "Fade Style";
	customField[2, "desc"   ] = "Which style of fading to use.";
	customField[2, "default"] = "cloak";
	customEnum["fadeStyle", 0, "value"] = "cloak";
	customEnum["fadeStyle", 0, "name" ] = "White";
	customEnum["fadeStyle", 1, "value"] = "fade";
	customEnum["fadeStyle", 1, "name" ] = "Textured";
	customField[3, "field"  ] = "fadeInTime";
	customField[3, "type"   ] = "time";
	customField[3, "name"   ] = "Fade-In Time";
	customField[3, "desc"   ] = "How long the platform takes to fade in.";
	customField[3, "default"] = "500";
	customField[4, "field"  ] = "fadeOutTime";
	customField[4, "type"   ] = "time";
	customField[4, "name"   ] = "Fade-Out Time";
	customField[4, "desc"   ] = "How long the platform takes to fade out.";
	customField[4, "default"] = "500";
	customField[5, "field"  ] = "visibleTime";
	customField[5, "type"   ] = "time";
	customField[5, "name"   ] = "Visible Time";
	customField[5, "desc"   ] = "How long the platform is visible when faded in.";
	customField[5, "default"] = "500";
	customField[6, "field"  ] = "invisibleTime";
	customField[6, "type"   ] = "time";
	customField[6, "name"   ] = "Invisible Time";
	customField[6, "desc"   ] = "How long the platform remains invisible when faded out.";
	customField[6, "default"] = "500";
	customField[7, "field"  ] = "startOffset";
	customField[7, "type"   ] = "time";
	customField[7, "name"   ] = "Start Time Offset";
	customField[7, "desc"   ] = "How long from the start of the level before the platform begins its cycle.";
	customField[7, "default"] = "0";
	customField[8, "field"  ] = "permanent";
	customField[8, "type"   ] = "boolean";
	customField[8, "name"   ] = "Permanent";
	customField[8, "desc"   ] = "If the platform should not re-appear after hiding.";
	customField[8, "default"] = "0";
};

datablock StaticShapeData(FadePlatform2_1x1 : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/FadePlatform2_1x1.dts";
};

datablock StaticShapeData(FadePlatform2_1x2 : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/FadePlatform2_1x2.dts";
};

datablock StaticShapeData(FadePlatform2_1x3 : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/FadePlatform2_1x3.dts";
};

datablock StaticShapeData(FadePlatform2_1x5 : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/FadePlatform2_1x5.dts";
};

datablock StaticShapeData(FadePlatform2_2x2 : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/FadePlatform2_2x2.dts";
};

datablock StaticShapeData(FadePlatform2_3x3 : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/FadePlatform2_3x3.dts";
};

datablock StaticShapeData(FadePlatform2_5x5 : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/FadePlatform2_5x5.dts";
};

datablock StaticShapeData(BMFadePlatform : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform1x2 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform1x2.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform1x3 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform1x3.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform1x4 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform1x4.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform1x5 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform1x5.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform2x1 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform2x1.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform3x1 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform3x1.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform4x1 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform4x1.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform5x1 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform5x1.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform2x2 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform2x2.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform3x3 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform3x3.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform4x4 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform4x4.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

datablock StaticShapeData(BMFadePlatform5x5 : FadePlatform) {
	shapeFile = "~/data/shapes_bm/Hazards/FadePlatform/BMFadePlatform5x5.dts";
	skin[0] = "base";
	skin[1] = "skin0";
	skin[2] = "skin1";
	skin[3] = "skin2";
	skin[4] = "skin3";
};

// These fade platforms cannot have the above's code as they don't use any other skin besides the one given to them

datablock StaticShapeData(FadePlatformConcrete : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/fadeplat_concrete_cube_2x2.dts";
	skin[0] = ""; //Don't allow skinning
};

datablock StaticShapeData(FadePlatformGrass : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/fadeplat_grass_cube_2x2.dts";
	skin[0] = ""; //Don't allow skinning
};

datablock StaticShapeData(FadePlatformIce : FadePlatform) {
	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/FadePlatform/fadeplat_ice_cube_2x2.dts";
	skin[0] = ""; //Don't allow skinning
};

function FadePlatformClass::onAdd(%this, %obj) {
	// Default variables
	if (%obj.skin $= "")
		%obj.skin = "skin0";

	if (%obj.functionality $= "")
		%obj.functionality = "trapdoor";

	if (%obj.fadeStyle $= "")
		%obj.fadeStyle = "cloak";

	if (%obj.fadeInTime $= "")
		%obj.fadeInTime = "500";

	if (%obj.fadeOutTime $= "")
		%obj.fadeOutTime = "500";

	if (%obj.fadeWaitLength !$= "") {
		%obj.invisibleTime = %obj.fadeWaitLength;
		%obj.visibleTime = %obj.fadeWaitLength;
		%obj.fadeWaitLength = "";
	}

	if (%obj.visibleTime $= "")
		%obj.visibleTime = "500";

	if (%obj.invisibleTime $= "")
		%obj.invisibleTime = "500";

	// We're limiting this to a maximum of 2 minutes and a minimum of 100ms.
	// I just don't see any use for it beyond these values...
	if (%obj.visibleTime > 120000)
		%obj.visibleTime = "120000";
	if (%obj.visibleTime < 100)
		%obj.visibleTime = "100";
	if (%obj.invisibleTime > 120000)
		%obj.invisibleTime = "120000";
	if (%obj.invisibleTime < 100)
		%obj.invisibleTime = "100";

	// Skin takes effect upon mission reset or reload
	if (%obj.skinName !$= "") { //clean up old skinname field
		%obj.skin = %obj.skinName;
		%obj.skinName = "";
	}

	if (%obj.skin $= "")
		%obj.skin = %obj.getSkinName();
	else
		%obj.setSkinName(%obj.skin);

	if (%obj.startOffset $= "")
		%obj.startOffset = "0";
	if (%obj.permanent $= "")
		%obj.permanent = "0";

	if (%obj.functionality $= "periodic") {
		// Start by fading out the platform
		%this.fadeOut(%obj, true);
	}
}

function FadePlatformClass::onRemove(%this, %obj) {
	// Cancel schedules to avoid console spam
	cancel(%obj._hideSch);
	cancel(%obj._toggleSch);
}

//Visually fade out
function FadePlatformClass::fadeOut(%this, %obj, %instant) {
	if (!isObject(%obj))
		return;
	cancel(%obj._hideSch);
	%obj._visible = false;
	if (%instant) {
		if (%obj.fadeStyle $= "cloak") {
			%obj.setCloaked(true);
		}
		%obj.hide(true);
	} else {
		if (%obj.fadeStyle $= "cloak") {
			%obj.setCloaked(true);
		} else {
			%obj.startFade(%obj.fadeOutTime, 0, true);
		}
		%obj._hideSch =  %obj.schedule(%obj.fadeOutTime, "hide", true);
	}
}

//Visually fade in
function FadePlatformClass::fadeIn(%this, %obj, %instant) {
	if (!isObject(%obj))
		return;
	cancel(%obj._hideSch);
	%obj._visible = true;
	if (%instant) {
		%obj.setCloaked(false);
		%obj.hide(false);
		if (%obj.fadeStyle !$= "cloak") {
			%obj.startFade(0, 0, false);
		}
	} else {
		%obj.hide(false);
		if (%obj.fadeStyle $= "cloak") {
			%obj._hideSch = %obj.schedule(20, setCloaked, false);
		} else {
			%obj.startFade(%obj.fadeInTime, 0, false);
		}
	}

}

//Fade out and then loop to fading in after invisibleTime
function FadePlatformClass::fadeOutLoop(%this, %obj) {
	if (!isObject(%obj))
		return;
	cancel(%obj._toggleSch);
	%this.fadeOut(%obj);
	%obj._toggleSch = %this.schedule(%obj.fadeOutTime + %obj.invisibleTime, "fadeInLoop", %obj);
}

//Fade in and then loop to fading out after visibleTime
function FadePlatformClass::fadeInLoop(%this, %obj) {
	if (!isObject(%obj))
		return;
	cancel(%obj._toggleSch);
	%this.fadeIn(%obj);
	%obj._toggleSch = %this.schedule(%obj.fadeInTime + %obj.visibleTime, "fadeOutLoop", %obj);
}

function FadePlatformClass::onCollision(%this, %obj, %col) {
	if (!Parent::onCollision(%this, %obj, %col)) return;
	switch$ (%obj.functionality) {
	case "trapdoor":
		if (%obj._visible) {
			// cloak and hide
			%this.fadeOut(%obj);

			if (!%obj.permanent) {
				// unhide and uncloak
				%obj._toggleSch = %this.schedule(%obj.fadeOutTime + %obj.invisibleTime, "fadeIn", %obj);
			}
		}
	case "fading":
		//If we need to set the initial state, do so
		if (%obj._initialState $= "")
			%obj._initialState = %obj.state;

		//Go to the next hide state
		%obj.state ++;
		%ratio = (%obj.level - %obj.state) / %obj.level;

		if (%ratio <= 0) {
			//Completely hidden, reset the fade
			%obj.hide(true);
			%obj.setFadeVal(1);
		} else {
			//Slightly hidden
			%obj.hide(false);
			%obj.setFadeVal(%ratio);
		}
	}
}

function FadePlatformClass::onMissionReset(%this, %obj) {
	switch$ (%obj.functionality) {
	case "fading":
		//If we need to set the initial state, do so
		if (%obj._initialState $= "")
			%obj._initialState = %obj.state;

		//Reset the state to the initial
		%obj.state = %obj._initialState;
		%ratio = (%obj.level - %obj.state) / %obj.level;

		if (%ratio <= 0) {
			//Completely hidden, reset the fade
			%obj.hide(true);
			%obj.setFadeVal(1);
		} else {
			//Slightly hidden
			%obj.hide(false);
			%obj.setFadeVal(%ratio);
		}
	case "trapdoor":
		cancelAll(%obj);
		%this.fadeIn(%obj, true);
	case "periodic":
		cancel(%obj._hideSch);
		cancel(%obj._toggleSch);

		// Start by fading out the platform
		%this.fadeOut(%obj, true);
		%this._toggleSch = %this.schedule(%obj.startOffset, fadeOutLoop, %obj);
	}
}
