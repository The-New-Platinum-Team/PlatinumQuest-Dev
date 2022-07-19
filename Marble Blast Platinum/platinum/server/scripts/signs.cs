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
// Sign base class
//-----------------------------------------------------------------------------

function Sign::onAdd(%this,%obj) {
	if (%this.skin !$= "")
		%obj.setSkinName(%this.skin);

	// PQ signs
	if (%obj.skin !$= "")
		%obj.setSkinName(%obj.skin);
}

//-----------------------------------------------------------------------------
// Different signs...
//-----------------------------------------------------------------------------

datablock StaticShapeData(Sign) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBP";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/sign.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

datablock StaticShapeData(SignDown : Sign) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBP";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/signdown.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

datablock StaticShapeData(SignUp: Sign) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBP";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/signup.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

datablock StaticShapeData(SignSide: Sign) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBP";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/signside.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

datablock StaticShapeData(SignDownSide: Sign) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBP";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/signdown-side.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

datablock StaticShapeData(SignUpSide: Sign) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBP";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/signup-side.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

//-----------------------------------------------------------------------------

datablock StaticShapeData(Arrow: Sign) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBP";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/sign.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

//-----------------------------------------------------------------------------

datablock StaticShapeData(SignCaution) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBG";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/cautionsign.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

datablock StaticShapeData(SignCautionCaution: SignCaution) {
	skin = "caution";
};

datablock StaticShapeData(SignCautionDanger: SignCaution) {
	skin = "danger";
};


//-----------------------------------------------------------------------------

datablock StaticShapeData(SignFinish) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBG";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/finishlinesign.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

function SignFinish::onAdd(%this,%obj) {
	%obj.playThread(0,"ambient");
}

//-----------------------------------------------------------------------------
datablock StaticShapeData(SignPlain) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs MBG";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes/signs/plainsign.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

datablock StaticShapeData(SignPlainUp: SignPlain) {
	skin = "up";
};

datablock StaticShapeData(SignPlainDown: SignPlain) {
	skin = "down";
};

datablock StaticShapeData(SignPlainLeft: SignPlain) {
	skin = "left";
};

datablock StaticShapeData(SignPlainRight: SignPlain) {
	skin = "right";
};

//--------------------------------------------------------------------
// PQ Wooden signs
datablock StaticShapeData(Sign01) {
	className = "Sign";
	superCategory = "Scenery";
	category = "Signs PQ";
	shapeFile = "~/data/shapes_pq/Scenery/Signs/Sign01.dts";
	skin[0] = "base";
	skin[1] = "red_left";
	skin[2] = "red_right";
	skin[3] = "red_up";
	skin[4] = "red_down";
	skin[5] = "red_leftright";
	skin[6] = "red_updown";
	skin[7] = "red_diag_1";
	skin[8] = "red_diag_2";
	skin[9] = "red_diag_3";
	skin[10] = "red_diag_4";
	skin[11] = "blue_left";
	skin[12] = "blue_right";
	skin[13] = "blue_up";
	skin[14] = "blue_down";
	skin[15] = "blue_leftright";
	skin[16] = "blue_updown";
	skin[17] = "blue_diag_1";
	skin[18] = "blue_diag_2";
	skin[19] = "blue_diag_3";
	skin[20] = "blue_diag_4";
	skin[21] = "yellow_left";
	skin[22] = "yellow_right";
	skin[23] = "yellow_up";
	skin[24] = "yellow_down";
	skin[25] = "yellow_leftright";
	skin[26] = "yellow_updown";
	skin[27] = "yellow_diag_1";
	skin[28] = "yellow_diag_2";
	skin[29] = "yellow_diag_3";
	skin[30] = "yellow_diag_4";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

datablock StaticShapeData(Sign02 : Sign01) {
	shapeFile = "~/data/shapes_pq/Scenery/Signs/Sign02.dts";
};

//----------------------------------------------------------------------
// PQ Roadsigns
datablock StaticShapeData(RoadsignYellow) {
	className = "Sign";
	superCategory = "Scenery";
	category = "Signs PQ";
	shapeFile = "~/data/shapes_pq/Scenery/Signs/RoadsignYellow.dts";
	skin[0] = "base";
	skin[1] = "Caution";
	skin[2] = "ActualCaution";
	skin[3] = "Danger";
	skin[4] = "ActualDanger";
	skin[5] = "Up";
	skin[6] = "Right";
	skin[7] = "Left";
	skin[8] = "Down";
	skin[9] = "UpRight";
	skin[10] = "DownRight";
	skin[11] = "UpLeft";
	skin[12] = "DownLeft";
	skin[13] = "HorizontalBothWays";
	skin[14] = "VerticalBothWays";
	skin[15] = "TurnArround";
	skin[16] = "Native";
	skin[17] = "Dragon";
	skin[18] = "DragonCaution";
	skin[19] = "NoFunAllowed";
	skin[20] = "BlastedCaution";
	skin[21] = "BlastedDanger";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";

};

datablock StaticShapeData(RoadsignRed : RoadsignYellow) {
	shapeFile = "~/data/shapes_pq/Scenery/Signs/RoadsignRed.dts";
};

datablock StaticShapeData(ConstructonRoadsignYellow : RoadsignYellow) {
	shapeFile = "~/data/shapes_pq/Scenery/Signs/ConstructonRoadsignYellow.dts";
};

datablock StaticShapeData(ConstructonRoadsignRed : RoadsignYellow) {
	shapeFile = "~/data/shapes_pq/Scenery/Signs/ConstructonRoadsignRed.dts";
};

datablock StaticShapeData(DetourRoadsignYellow : RoadsignYellow) {
	shapeFile = "~/data/shapes_pq/Scenery/Signs/DetourRoadsignYellow.dts";
};

datablock StaticShapeData(DetourRoadsignRed : RoadsignYellow) {
	shapeFile = "~/data/shapes_pq/Scenery/Signs/DetourRoadsignRed.dts";
};
//----------------------------------------------------
//CutoutSignMeme
//
datablock StaticShapeData(Cardboardsign) {
	className = "Sign";
	superCategory = "Scenery";
	category = "Signs PQ";
	shapeFile = "~/data/shapes_pq/Gameplay/Signs/Threefolder.dts";
};

datablock StaticShapeData(Carboardsign_L : CardboardSign) {
	shapeFile = "~/data/shapes_pq/Gameplay/Signs/ThreefolderLEFTsign.dts";
};

datablock StaticShapeData(Carboardsign_R : CardboardSign) {
	shapeFile = "~/data/shapes_pq/Gameplay/Signs/ThreefolderRIGHTsign.dts";
};

datablock StaticShapeData(Carboardsign_UP_L : CardboardSign) {
	shapeFile = "~/data/shapes_pq/Gameplay/Signs/ThreefolderUPsignL.dts";
};

datablock StaticShapeData(Carboardsign_UP_R : CardboardSign) {
	shapeFile = "~/data/shapes_pq/Gameplay/Signs/ThreefolderUPsignR.dts";
};

datablock StaticShapeData(Carboardsign_DOWN_L : CardboardSign) {
	shapeFile = "~/data/shapes_pq/Gameplay/Signs/ThreefolderDOWNsignL.dts";
};
datablock StaticShapeData(Carboardsign_DOWN_R : CardboardSign) {
	shapeFile = "~/data/shapes_pq/Gameplay/Signs/ThreefolderDOWNsignr.dts";
};
//-----FinishlinesignsPQ

datablock StaticShapeData(RegularFinishlinesign) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs PQ";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/signs/Regularfinishsign.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
};

function RegularFinishlinesign::onAdd(%this,%obj) {
	%obj.playThread(0,"ambient");
}
//Construction finishlinesign with crane
datablock StaticShapeData(ConsFinishlinesign) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs PQ";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/signs/ConsFinishlinesign.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	fxEmitter[0] = "FinishEmitterYellow";
	fxEmitter[1] = "FinishEmitterBlack";
};

function ConsFinishlinesign::onAdd(%this,%obj) {
	%obj.playThread(0,"ambient");
}
//Nocrane Construction Finishlinesign
datablock StaticShapeData(ConsFinishlinesignNocrane) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs PQ";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/signs/ConsFinishlinesignNocrane.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;

	fxEmitter[0] = "FinishEmitterYellow";
	fxEmitter[1] = "FinishEmitterBlack";
};

function ConsFinishlinesignNocrane::onAdd(%this,%obj) {
	%obj.playThread(0,"ambient");
}
datablock StaticShapeData(NatureFinishlinesignLight) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs PQ";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/signs/naturfinishlinesignLight.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	skin[0] = "base";
	skin[1] = "Green";
	skin[2] = "Lime";
	skin[3] = "DragonRed";
	skin[4] = "Blue";
	skin[5] = "Pink";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};
datablock StaticShapeData(NatureFinishlinesignDark) {
	// Mission editor category
	superCategory = "Scenery";
	category = "Signs PQ";
	className = "Sign";

	// Basic Item properties
	shapeFile = "~/data/shapes_pq/Gameplay/signs/naturfinishlinesignDark.dts";
	mass = 1;
	friction = 1;
	elasticity = 0.3;
	skin[0] = "base";
	skin[1] = "Green";
	skin[2] = "Lime";
	skin[3] = "DragonRed";
	skin[4] = "Blue";
	skin[5] = "Pink";

	customField[0, "field"  ] = "skin";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Skin Name";
	customField[0, "desc"   ] = "Which skin to use (see skin selector).";
	customField[0, "default"] = "";
};

//MBU Signs Below.

datablock StaticShapeData(ArrowUp)
{
   // Mission editor category
	superCategory = "Scenery";
	category = "Signs MBU";

   // Basic Item properties
   shapeFile = "~/data/shapes_mbu/signs/arrowsign_up.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;
};

function ArrowUp::onAdd(%this,%obj)
{
   %obj.playThread(0,"ambient");
}

datablock StaticShapeData(ArrowSide)
{
   // Mission editor category
	superCategory = "Scenery";
	category = "Signs MBU";

   // Basic Item properties
   shapeFile = "~/data/shapes_mbu/signs/arrowsign_side.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;
};

function ArrowSide::onAdd(%this,%obj)
{
   %obj.playThread(0,"ambient");
}

datablock StaticShapeData(ArrowDown)
{
   // Mission editor category
	superCategory = "Scenery";
	category = "Signs MBU";

   // Basic Item properties
   shapeFile = "~/data/shapes_mbu/signs/arrowsign_down.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;
};

function ArrowDown::onAdd(%this,%obj)
{
   %obj.playThread(0,"ambient");
}