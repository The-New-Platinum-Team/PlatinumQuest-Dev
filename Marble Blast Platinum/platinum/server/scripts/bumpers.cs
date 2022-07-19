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

datablock AudioProfile(BumperDing) {
	filename    = "~/data/sound/bumperDing1.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(BumperFlat) {
	filename    = "~/data/sound/bumper1.wav";
	description = AudioDefault3d;
	preload = true;
};

function Bumper::onCollision(%this, %obj, %col) {
	if (!Parent::onCollision(%this, %obj, %col)) return;
	%obj.stopThread(0);

	// PQ's triangle bumper has a different animation.
	if (%this.pqTriangle)
		%obj.playThread(0, "anim0");
	else
		%obj.playThread(0,"push");

	%obj.playAudio(0, %this.sound);
}

//-----------------------------------------------------------------------------

datablock StaticShapeData(TriangleBumper) {
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";
	className = "Bumper";
	shapeFile = "~/data/shapes/bumpers/pball_tri.dts";
	scopeAlways = true;
	sound = BumperFlat;
};

datablock StaticShapeData(RoundBumper) {
	superCategory = "Hazards";
	category = "Marble Blast Gold/Platinum";
	className = "Bumper";
	shapeFile = "~/data/shapes/bumpers/pball_round.dts";
	scopeAlways = true;
	sound = BumperDing;
};

datablock StaticShapeData(TriangleBumper_PQ : TriangleBumper) {
	superCategory = "Hazards";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/bumpers/tribumper.dts";
	pqTriangle = true;
};

datablock StaticShapeData(RoundBumper_PQ : RoundBumper) {
	superCategory = "Hazards";
	category = "PlatinumQuest";

	shapeFile = "~/data/shapes_pq/Gameplay/Hazards/bumpers/roundbumper.dts";
};

datablock StaticShapeData(RoundBumper_BM : RoundBumper) {
	superCategory = "Hazards";
	category = "Blasted";
	className = "Bumper";
	shapeFile = "~/data/shapes_bm/hazards/RoundBumper_bm.dts";
	scopeAlways = true;
	sound = BumperDing;
};

datablock StaticShapeData(RoundBumper_MBU)
{
   superCategory = "Hazards";
   category = "Marble_Blast_Ultra/Mobile";	
   shapeFile = "~/data/shapes_mbu/bumpers/pball_round.dts";
   scopeAlways = true;
   sound = BumperDing;
};

function RoundBumper_MBU::onAdd( %this, %obj )
{
   %obj.playThread( 0, "idle" );
}

function RoundBumper_Original::onAdd( %this, %obj )
{
   if ($pref::spchanges && %obj.isTemperable $= "1")
	%obj.setDataBlock("RoundBumper_MBU");
    %obj.playThread( 0, "idle" );
}

// function RoundBumper_MBU::onEndSequence( %this, %obj, %slot )
// {
//    // This means the activate sequence is done, so put back to idle
//    %obj.stopThread( 0 );
//    %obj.playThread( 0, "idle" );
// }

function RoundBumper_MBU::onCollision( %this, %obj, %col ,%vec, %vecLen, %material )
{
   // Currently activates when any object hits it.
   //if( %material $= "BumperMaterial" ) 
   //{
      %obj.stopThread( 0 );
      %obj.playThread( 0, "activate" );
      %obj.playAudio( 0, %this.sound );
   	//   %obj.playThread( 0, "idle" );
	  %obj.idleSch = %obj.schedule(200, playThread, 0, "idle");
   //}
}


if (!$pref::LegacyItems) {
		datablock StaticShapeData(RoundBumper_Original) {
		superCategory = "Hazards";
		category = "Marble_Blast_Ultra/Mobile";
		className = "Bumper";
		shapeFile = "~/data/shapes_mbu/bumpers/mbgbumperedit.dts";
		scopeAlways = true;
		sound = BumperDing;
	};
} else {
		datablock StaticShapeData(RoundBumper_Original) {
		superCategory = "Hazards";
		category = "Marble_Blast_Ultra/Mobile";	
		shapeFile = "~/data/shapes/bumpers/pball_round.dts";
		scopeAlways = true;
		sound = BumperDing;
	};
}
