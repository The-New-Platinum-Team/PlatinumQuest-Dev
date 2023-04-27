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

// Cando: The Ragedar is normally used only for Hunt levels, but let's expand it to *any* level unless we make a enableRadar = "1"; field.

// TODO: Allow Radar Distance to be modified in OptionsGui

//stuff todo:
//[10:51:04 PM] Matan Weissman: 1) show start/end pads, gems, tts only
//[10:51:07 PM] Matan Weissman: 2) hunt: show normally
//[10:51:24 PM] Matan Weissman: 3) gem madness: limit to 10 nearest gems, doesn't matter distance
//[10:51:36 PM] Matan Weissman: OR limit to 10-15 gems within radius X
//[10:51:40 PM] Matan Weissman: i think the former is easier
//[10:51:49 PM] Matan Weissman: and thats all we need
//[10:51:58 PM] Matan Weissman: we dont need coins/eggs/powerups/chkpt etc.

//todo: mission-specific radar distances
$Game::RMD = 35; //Radar minimum search distance in dynamic mode
$Game::RMDL = 70; //(large) Radar minimum search distance in dynamic mode
$Game::RD = 500;  //Radar search distance
//todo: discuss about radar prefs (maxdots, timemult, maybe others, like distances)
$Radar::TimeMultiplier = 2; //Multiply schedule time by this amount.  For example, 2 = only calculate (close to) every other frame
$Radar::Fast = 1;  //Radar will not do an expensive check for 100% accurate camera yaw

//Now $MPPref::MaxRadarItems
//$Radar::MaxDots = 25; //To stop being agitated by my dots

//$Radar::SearchRule
// 0 = ALL SHAPEBASE      (original radar spammy thing)
// 1 = GEMS               (automatic for Hunt / GemMadness modes; otherwise must specify)
// 2 = TIME TRAVELS       Only show "good" time travels (other ones are traps)
// 4 = END PAD            Show End Pad as objective / pad icon when collected all gems / hit quota
// 8 = CHECKPOINTS        Use a single icon, same with pads
// 16 = CANNONS
// 32 = POWERUPS
// we won't display powerups/hazards specifically since useless
// although in custom levels people like hiding those as 0.001 0.001 0.001 coz they're dicks
// so we can have people add those manually themselves so they can find out the hidden stuff

$Radar::Flags::None        = 0;
$Radar::Flags::Gems        = 1 << 0;
$Radar::Flags::TimeTravels = 1 << 1;
$Radar::Flags::EndPad      = 1 << 2;
$Radar::Flags::Checkpoints = 1 << 3;
$Radar::Flags::Cannons     = 1 << 4;
$Radar::Flags::Powerups    = 1 << 5;

function Radar::Stop(%val) {
	$Radar::PreviousMode = %val ? $Game::RadarMode : "";
	cancel($Radar::Schedule);
}

function Radar::Init() {
	if (!shouldShowRadar()) {
		Radar::ClearTargets();
		return;
	}

	MPGetMyMarble();

	if ($Server::ServerType $= "SinglePlayer") {
		schedule(1000, 0, RadarLoop);
		schedule(2000, 0, RadarLoop);
		schedule(3000, 0, RadarLoop);
	}

	if (!isObject(TargetGroup)) {
		RootGroup.add(new SimGroup(TargetGroup));
	}
	Radar::ClearTargets();
	echo($Radar::PreviousMode);
	if ($Radar::PreviousMode !$= "")
		// Simulate a toggle cycle
		for (%i = 0; %i <= $Radar::PreviousMode; %i++)
			schedule(250 * %i, 0, "RadarSetMode", %i);

	if (MissionInfo.forceRadar) {
		//Colonel hackery
		schedule(500, 0, RadarSetMode, 3);
	}

	if (MissionInfo.CustomRadarRule !$= "") {
		$Radar::SearchRule = MissionInfo.CustomRadarRule | $Radar::Flags::Gems | $Radar::Flags::EndPad;
	} else {
		$Radar::SearchRule = $Radar::Flags::Gems | $Radar::Flags::EndPad;
	}
	$Game::RD = MissionInfo.RadarDistance !$= "" ? MissionInfo.RadarDistance : 50;
	//Only applies to gems and (somehow) the finish pad
	$Game::GemRD = MissionInfo.RadarGemDistance !$= "" ? MissionInfo.RadarGemDistance : 50000;

	RadarBuildSearch();
	RadarLoop();
}

function clientCmdRadarBuildSearch() {
	if (!shouldShowRadar()) {
		Radar::ClearTargets();
		return;
	}

	RadarBuildSearch();
	schedule(ServerConnection.getPing(), 0, RadarBuildSearch);

	RadarLoop();
	schedule(100, 0, RadarBuildSearch);
	schedule(300, 0, RadarBuildSearch);
	schedule(600, 0, RadarBuildSearch);
}

function clientCmdRadarStart() {
	if (!shouldShowRadar()) {
		Radar::ClearTargets();
		return;
	}

	// We init the radar here, because it's client-sided and on the PlayGui
	Radar::init();

	// Defaults to off mode
	if (MissionInfo.forceRadar)
		RadarSetMode(3);
	else
		RadarSetMode($Pref::RadarMode);

	// If you forget to call RadarLoop, it never starts up!
	RadarLoop();
}

function RadarBuildSearch() {
	if (!shouldShowRadar()) {
		Radar::ClearTargets();
		return;
	}

	cancel($RadarBuild);
	if ($Game::RadarMode == 0)
		return;

	if (!isObject(TargetGroup))
		return;

	Radar::ClearTargets();

	if (isObject(ServerConnection)) {
		%marblePos = ServerConnection.getControlObject().getPosition();
		_innerRadarBuildSearch(%marblePos, "radarShouldShow", "radarShouldShowFinish");
	}

	$RadarBuild = schedule(1000, 0, "RadarBuildSearch");
}

function Radar::AddTarget(%object, %bitmap) {
	if (!shouldShowRadar())
		return;

	if (!isObject(TargetGroup)) {
		RootGroup.add(new SimGroup(TargetGroup));
	}
	//echo("whee" SPC %object.getId());
	%script = new ScriptObject("RadarTarget" @ %object.getID()) {
		obj = %object;
		dot = Radar::AddDot(%object, %bitmap);
	};
	TargetGroup.add(%script);
}

function Radar::RemoveTarget(%object) {
	if (isObject(%object))
		%script = "RadarTarget" @ %object.getID();
	else
		%script = "RadarTarget" @ %object;
	if (isObject(%script)) {
		if (isObject(%script.dot)) {
			%script.dot.delete();
		}
		%script.delete();
	}
	if (isObject(%object))
		%dot = "RadarDot" @ %object.getID();
	else
		%dot = "RadarDot" @ %object;
	while (isObject(%dot))
		%dot.delete();
}

function Radar::ClearTargets() {
	RadarClearTargets();
	$Radar::NumDots = 0;
	return;
	if (isObject(TargetGroup)) {
		while (TargetGroup.getCount() > 0) {
			%script = TargetGroup.getObject(0);
			if (isObject(%script.dot))
				%script.dot.delete();
			%script.delete();
		}
	}
	for (%i = 0; %i < PlayGui.getCount(); %i ++) {
		%obj = PlayGui.getObject(%i);
		if (strPos(%obj.getName(), "RadarDot") == 0) {
			%obj.delete();
			%i --;
		} else if (strPos(%obj.getName(), "RadarTarget") == 0) {
			%obj.delete();
			%i --;
		}
	}

	$Radar::NumDots = 0;
}

/// Called back from C++
function Radar::setDot(%dot, %pos, %extent, %bitmap, %reset) {
	if (%reset) {
		%dot.bitmapRotation = "";
		%dot.bitmapColor = "";
		%dot.setVisible(true);
	}
	%dot.setPosition(%pos);
	%dot.setExtent(%extent);
	%dot.setBitmap(%bitmap);
}

// function SceneObject::SetRadarTarget(%this, %bitmap) {
// 	if (!shouldShowRadar())
// 		return;
// 	Radar::AddTarget(%this, %bitmap);
// }

// function SceneObject::RemoveRadarTarget(%this) {
// 	Radar::RemoveTarget(%this);
// }

function RadarLoop() {
	// don't call every frame, don't waste CPU
	// only for fast mode
	if ($pref::FastMode) {
		%last = $Radar::LastTime;
		%time = getRealTime();
		if ((%time - %last) < 30)
			return;
		$Radar::LastTime = %time;
	}

	if (!shouldShowRadar()) {
		RadarSetMode(0);
		return;
	}
	if (isObject(MPGetMyMarble())) {
		%pos = $MP::MyMarble.getTransform();
	} else if (isObject(LocalClientConnection.player)) {
		%pos = LocalClientConnection.player.getTransform();
	} else if (isObject(getCamera())) {
		%pos = getCamera().getTransform();
	} else if (isObject(LocalClientConnection.camera)) {
		%pos = LocalClientConnection.camera.getTransform();
	} else if (isObject(ServerConnection) && isObject(ServerConnection.getControlObject())) {
		%pos = ServerConnection.getControlObject().getTransform();
	} else {
		//Nothing to get position from
		return;
	}
	if ($Game::RadarMode == 0)
		return;

	//Yay, nukesweeper!
	if (MissionInfo.nukesweeper)
		return;

	Radar::ShowDots(0);

	%trans = getCameraTransform();
	%fov = getCameraFov();

	_innerRadarLoop(
	    TargetGroup,
	    %pos,
	    %trans,
	    %fov,
	    Canvas.getExtent(),
	    getMarbleCamYaw()
	);
}

function radarSwitch(%val) {
	//Called from MoveMap
	if (!%val)
		return;
	if (!shouldShowRadar())
		return;

	%forceOn = MissionInfo.forceRadar;
	%mode = $pref::RadarMode;

	//Find the next mode
	switch (%mode) {
	case 0: //Off
		%mode = 3; //Ultra
	case 1: //Mini
		%mode = 2; //Full screen
	case 2: //Full screen
		%mode = (%forceOn ? 3 : 0); //Ultra : Off
	case 3: //Ultra
		%mode = 1; //Mini
	}

	$Pref::RadarMode = %mode;

	RadarSetMode(%mode);
}

function RadarSetMode(%mode) {
	//Set mode to %mode

	if (!shouldShowRadar()) {
		RadarBitmap.setVisible(0);
		$Game::RadarMode = 0;
		return;
	}
	$Game::RadarMode = %mode;

	%x = getWord(Canvas.getExtent(), 0);
	%y = getWord(Canvas.getExtent(), 1);

	switch ($Game::RadarMode) {
	case 0:
		Radar::Stop();
		Radar::ShowDots(0);
		RadarBitmap.setVisible(0);
	case 1:
		RadarLoop();
		RadarBitmap.resize(%x - 330, 10, 256, 256);
		RadarBitmap.setVisible(1);
	case 2:
		RadarBitmap.resize((%x/2) - %y/2, (%y/2) - %y/2, %y, %y);
		RadarBitmap.setVisible(0);
	case 3:
		RadarBitmap.setVisible(0);
	}
	//Update positions
	RadarLoop();

	//Start the search building loop
	RadarBuildSearch();
}

function radarShouldShowFinish(%items) {
	return ClientMode::callback("radarShowShouldFinish", false, %items);
}

function radarShouldShow(%object) {
	//Ask the mode first
	if (!ClientMode::callback("radarShouldShowObject", true, %object)) {
		return false;
	}
	%bitmap = ClientMode::callback("radarGetDotBitmap", "", %object);
	if (%bitmap !$= "" && isFile(getField(%bitmap, 0))) {
		return true;
	}
	if ($Radar::SearchRule == 0)
		return false;

	%class = %object.getClassName();
	if (%class $= "TSStatic") {
		if (stripos(%object.shapeFile, "endpad") != -1) {
			//Pretend to be the real thing
			%class = "StaticShape";
			%name = "EndPad";
			%skin = "base";
		} else if (stripos(%object.shapeFile, "checkpoint") != -1) {
			%class = "StaticShape";
			%name = "Checkpoint";
			%skin = "base";
		} else {
			//Unknown
			return false;
		}
	} else {
		%name = %object.getDatablock().getName();
		%name = strReplace(%name, "_PQ", "");
		%name = strReplace(%name, "_MBU", "");
		%name = strReplace(%name, "_MBM", "");
		%name = strReplace(%name, "_MBXP", "");
		%name = strReplace(%name, "_BM", "");
		%name = strReplace(%name, "_BMGate", "");
		%skin = %object.getSkinName();
	}
	%bitmap = $userMods @ "/client/ui/mp/radar/" @ %name @ ".png";

	//Some custom rules
	if (%name $= "EndPad" && ($Radar::SearchRule & $Radar::Flags::EndPad) == 0)
		return false;
	if (%name $= "Checkpoint" && ($Radar::SearchRule & $Radar::Flags::EndPad) == 0)
		return false;

	//All cannons are the same
	if (stripos(%name, "Cannon") != -1 && ($Radar::SearchRule & $Radar::Flags::Cannon) == 0)
		return false;

	//PowerUps and stuff
	if (%class $= "Item") {
		switch$ (%name) {
		case "AntiGravityItem"
			or "NoRespawnAntiGravityItem":
			%rotation = getWords(%object.getTransform(),3);
			%ortho = vectorOrthoBasis(%rotation);
			%ortho = VectorRemoveNotation(%ortho);

			if (VectorEqual(getWords($MP::MyMarble.getGravityDir(), 6, 8), getWords(%ortho, 6, 8))) { // same gravity as you
				return false;
			}
		case "SuperJumpItem"
			or "SuperBounceItem"
			or "SuperSpeedItem"
			or "ShockAbsorberItem"
			or "HelicopterItem"
			or "RandomPowerUpItem"
			or "BlastItem"
			or "MegaMarbleItem"
			or "TeleportItem"
			or "AnvilItem"
			or "BubbleItem"
			or "CustomSuperJumpItem":
			if (($Radar::SearchRule & $Radar::Flags::Powerups) == 0 && !$pref::powerupsAlwaysOnRadar)
				return false;
		case "TimeTravelItem"
			or "TimePenaltyItem"
			or "RespawningTimeTravelItem"
			or "RespawningTimePenaltyItem"
			or "SundialItem":
			if (($Radar::SearchRule & $Radar::Flags::TimeTravels) == 0 && !$pref::powerupsAlwaysOnRadar)
				return false;
		}

		if (stripos(%name, "GemItem") != -1) {
			%bitmap = $userMods @ "/client/ui/mp/radar/GemItem" @ %skin @ ".png";

			if (($Radar::SearchRule & $Radar::Flags::Gems) == 0)
				return false;
		}
	}
	return isFile(%bitmap);
}

function Radar::AddDot(%object, %bitmap) {
	if (!shouldShowRadar())
		return;

	//%bitmap is the bitmap when it's on screen
	//%skin defines the skin of the arrows for off-screen

	%modeBitmap = ClientMode::callback("radarGetDotBitmap", "", %object);
	if (%modeBitmap !$= "") {
		//Going to assume this is valid if you pass it from a mode
		%bitmap = getField(%modeBitmap, 0);
		%skin = getField(%modeBitmap, 1);
	} else {
		%class = %object.getClassName();
		if (%class $= "TSStatic") {
			%skin = "none";
			if (stripos(%object.shapeFile, "endpad") != -1) {
				%bitmap = $userMods @ "/client/ui/mp/radar/EndPad.png";
				%remaining = $Game::GemCount - PlayGui.gemCount;
				if (ClientMode::callback("radarShowShouldFinish", %remaining == 0, %remaining)) {
					%skin = "white";
				}
			}
		} else {
			%name = %object.getDatablock().getName();
			%name = strReplace(%name, "_PQ", "");
			%name = strReplace(%name, "_MBU", "");
			%name = strReplace(%name, "_MBM", "");
			%name = strReplace(%name, "_MBXP", "");
			%name = strReplace(%name, "_BM", "");
			%name = strReplace(%name, "_BMGate", "");
			%skin = %object.getSkinName();
			%bitmap = $userMods @ "/client/ui/mp/radar/" @ %name @ ".png";

			if (%class $= "StaticShape") {
				%skin = "none";
				if ((stripos(%name, "EndPad") != -1)) {
					%remaining = $Game::GemCount - PlayGui.gemCount;
					if (ClientMode::callback("radarShowShouldFinish", %remaining == 0, %remaining)) {
						%skin = "white";
					}
				}
			} else if (%class $= "Item") {
				if (stripos(%name, "GemItem") != -1) {
					%bitmap = $userMods @ "/client/ui/mp/radar/GemItem" @ %skin @ ".png";
				} else if (stripos(%name, "CandyItem") == -1) {
					%skin = "none";
				}
			} else {
				%skin = "none";
			}
		}
	}

	%dot = new GuiBitmapCtrl("RadarDot" @ %object.getID()) {
		profile = "GuiDefaultProfile";
		horizSizing = "left";
		vertSizing = "bottom";
		extent = "16 16";
		minExtent = "8 8";
		visible = "1";
		bitmap = %bitmap;
		object = %object.getId();
		image = %bitmap; // 1.50 change, used for radar mode 3 (to toggle between arrows and that)
		skin = %skin;
	};
	%dot.setVisible($Game::RadarMode > 0);
	PG_RadarContent.add(%dot);
	return %dot;
}

$RadarColor["base"]      = "255 51 255 255";
$RadarColor["blue"]      = "51 51 255 255";
$RadarColor["red"]       = "255 51 51 255";
$RadarColor["yellow"]    = "255 255 51 255";
$RadarColor["purple"]    = "128 51 255 255";
$RadarColor["orange"]    = "255 153 51 255";
$RadarColor["green"]     = "51 255 51 255";
$RadarColor["turquoise"] = "51 255 255 255";
$RadarColor["black"]     = "0 0 0 255";
$RadarColor["platinum"]  = "128 128 128 255";
$RadarColor["specialyellow"] = "255 225	51 255";
$RadarColor["specialpurple"] = "128 51 255 255";
$RadarColor["specialplatinum"] = "128 128 128 255";

function RadarSetDotColor(%dot, %skin, %angle) {
	%dot.setBitmap("platinum/client/ui/mp/radar/Pointer.png");
	%dot.bitmapRotation = -mRadToDeg(%angle);
	%dot.bitmapColor = $RadarColor[%skin];
	%dot.setVisible(%skin !$= "none");
}

function Radar::ShowDots(%val) {
	for (%i = 0; %i < $Radar::NumDots; %i++) {
		%obj = "RadarDot" @ %i;
		%obj.setVisible(%val);
	}

	if (!isObject(TargetGroup))
		return;
	%count = TargetGroup.getCount();
	for (%i = 0; %i < %count; %i++) {
		%obj = TargetGroup.getObject(%i).dot;
		%obj.setVisible(%val);
	}
}

//Method that is called to determine if the radar should be shown.
function shouldShowRadar() {
	//Mission-specific radar disabling
	if (MissionInfo.hideRadar) {
		return false;
	}
	//Nothing to show
	if ($Radar::SearchRule !$= "" && $Radar::SearchRule == $Radar::Flags::None) {
		return false;
	}
	return true;
	////Or levels that specifically ask for it
	//if (MissionInfo.radar) {
	//	return true;
	//}
}
