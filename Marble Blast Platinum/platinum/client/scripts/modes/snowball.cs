//-----------------------------------------------------------------------------
// Snowball mode
//
// Copyright (c) 2015 The Platinum Team
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_snowball) {
	class = "ModeInfo_snowball";
	superclass = "ModeInfo";

	identifier = "snowball";
	file = "snowball";

	name = "Holiday Snow";
	desc = "Feel the freeze and steal points by shooting other players with snowballs!";

	teams = 1;
});

function ModeInfo_snowball::isAvailable(%this) {
	return !!$LB::WinterMode;
}

function ClientMode_snowball::onLoad(%this) {
	%this.registerCallback("onFrameAdvance");
	%this.registerCallback("updatePlayMission");
	%this.registerCallback("onActivate");
	%this.registerCallback("getEggIcon");
	%this.registerCallback("onDeactivate");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_snowball::onFrameAdvance(%this, %timeDelta) {
	extrapolateSnowBalls();
}

function ClientMode_snowball::onActivate(%this) {
	if ($Server::Dedicated) {
		//TFW dedicated servers call client code
		return;
	}
	updateSnowballButtons($Server::Hosting);
	cancel($snowballTP);
	$snowballTP = schedule(100, 0, snowballTexturePackActivate);
}
function snowballTexturePackActivate() {
	activateTexturePack("snowball");
	reloadTexturePackFields();
}

function ClientMode_snowball::onDeactivate(%this) {
	if ($Server::Dedicated) {
		//TFW dedicated servers call client code
		return;
	}
	updateSnowballButtons(false);
	cancel($snowballTP);
	$snowballTP = schedule(100, 0, snowballTexturePackDeactivate);
}
function snowballTexturePackDeactivate() {
	deactivateTexturePack("snowball");
	reloadTexturePackFields();
}

function ClientMode_snowball::getEggIcon(%this, %found) {
	%egg = "platinum/data/texture_packs/snowball/egg_snowglobe_";
	%egg = %egg @ (%found ? "get_ol" : "notfound_ol");
	return %egg;
}

function ClientMode_snowball::updatePlayMission(%this, %location) {
	switch$ (%location) {
	case "sp":
		%text = PM_MissionInfo.getText();
		%text = strReplace(%text, "<color:CCCCCC>Platinum", "<color:EEEEEE>Chilly");
		%text = strReplace(%text, "<color:FFCC33>Ultimate", "<color:22CCFF>Frozen");
		PM_MissionInfo.setText(%text);

		%text = PM_MissionScoresInfo.getText();
		%text = strReplace(%text, "<color:CCCCCC>", "<color:EEEEEE>");
		%text = strReplace(%text, "<color:FFCC33>", "<color:22CCFF>");
		PM_MissionScoresInfo.setText(%text);
	}
}

function updateSnowballButtons(%enable) {
	if (%enable) {
		$PMG::BarButton["BottomMP", "Name",       4] = "PM_MissionSnowballs";
		$PMG::BarButton["BottomMP", "Command",    4] = "if ($ControllerEvent) {$MPPref::EnableSnowballs = !$MPPref::EnableSnowballs; $ThisControl.setValue($MPPref::EnableSnowballs); } updateSnowballsButton(); "; //Hack for controllers
		$PMG::BarButton["BottomMP", "Variable",   4] = "$MPPref::EnableSnowballs";
		$PMG::BarButton["BottomMP", "ButtonType", 4] = "ToggleButton";
		$PMG::BarButton["BottomMP", "Bitmap",     4] = "platinum/client/ui/play/buttons/snowballs.png";
		$PMG::BarButton["BottomMP", "Name",       5] = "PM_MissionSnowballsOnly";
		$PMG::BarButton["BottomMP", "Command",    5] = "if ($ControllerEvent) {$MPPref::SnowballsOnly = !$MPPref::SnowballsOnly; $ThisControl.setValue($MPPref::SnowballsOnly); } updateSnowballsOnlyButton(); "; //Hack for controllers
		$PMG::BarButton["BottomMP", "Variable",   5] = "$MPPref::SnowballsOnly";
		$PMG::BarButton["BottomMP", "ButtonType", 5] = "ToggleButton";
		$PMG::BarButton["BottomMP", "Bitmap",     5] = "platinum/client/ui/play/buttons/snowballsonly.png";
		$PMG::BarButton["BottomMP", "Count"] = 6;

		if (mp()) {
			PlayMissionGui.buildButtonBar("BottomMP");
			PlayMissionGui.buildButtonBar("ExtraMP");
			PlayMissionGui.updateMPButtons();
			PlayMissionGui.clearServerPlayerList();
			PlayMissionGui.updateServerPlayerList();
			PM_MissionSnowballsOnly.setActive($Server::Hosting);
		}
		PM_ButtonBox.setExtent("634 90");

		updateSnowballsButton();
		updateSnowballsOnlyButton();
	} else {
		$PMG::BarButton["BottomMP", "Count"] = 4;

		if (mp()) {
			PlayMissionGui.buildButtonBar("BottomMP");
			PlayMissionGui.buildButtonBar("ExtraMP");
			PlayMissionGui.updateMPButtons();
			PlayMissionGui.clearServerPlayerList();
			PlayMissionGui.updateServerPlayerList();
			PM_MissionSnowballsOnly.setActive($Server::Hosting);
		}
		PM_ButtonBox.setExtent("434 90");
	}
}


function updateSnowballsButton() {
	if ($Server::Hosting) {
		commandToServer('EnableSnowballs', $MPPref::EnableSnowballs);
	}
}

function updateSnowballsOnlyButton() {
	if ($Server::Hosting) {
		commandToServer('SnowballsOnly', $MPPref::SnowballsOnly);
	}
}

function clientCmdEnableSnowballs(%enable) {
	$MPPref::EnableSnowballs = %enable;
	$MP::Server::EnableSnowballs = %enable;
}

function clientCmdSnowballsOnly(%enable) {
	$MPPref::SnowballsOnly = %enable;
	$MP::Server::SnowballsOnly = %enable;
	PlayMissionGui.updateMissionInfo();
}

function clientCmdIceShardEarn() {
	//You earned the ice shard achievement. Hooray!
	statsRecordAchievement(3001);
}

function clientCmdSnowGlobe(%time) {
	statsRecordEgg(PlayMissionGui.getMissionInfo(), %time);

	PlayGui.showEggTime(%time);

	//Record the egg
	$Game::EasterEgg = true;
	$Game::EasterEggTime = %time;

	%first = ($pref::EasterEggTime[$Server::MissionFile] $= "");
	if ($pref::EasterEggTime[$Server::MissionFile] $= "") {
		$pref::EasterEggTime[$Server::MissionFile] = %time;
	} else {
		$pref::EasterEggTime[$Server::MissionFile] = min(%time, $pref::EasterEggTime[$Server::MissionFile]);
	}

	if (lb()) {
		%saved = PlayMissionGui.onlineEasterEggCache.getFieldValue(PlayMissionGui.getMissionInfo().id);

		if (%time < %saved || %saved $= "") {
			PlayMissionGui.onlineEasterEggCache.setFieldValue(PlayMissionGui.getMissionInfo().id, %time);
		}

		statsRecordEgg(PlayMissionGui.getMissionInfo(), %time);
	}
	savePrefs();
}

function extrapolateSnowBalls() {
	// If fast mode, we do not interpolate
	// this will destroy Loquendo's PC
	if ($pref::FastMode)
		return;

	// Local host (non dedicated) does not interpolate, they are already updating the snowball
	// like a bunch on the server side and can see it immediatly....saves performance and less
	// lag for all!
	if ($Server::Hosting && !$Server::_Dedicated)
		return;

	if (!isObject(ServerConnection))
		return;

	%count = ServerConnection.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);
		if (%obj.getClassName() $= "StaticShape") {
			if (strstr(%obj.getDataBlock().shapeFile, "/snowball") != -1) {
				%position = %obj.getPosition();
				%rotation = getWords(%obj.getTransform(), 3, 6);

				// check to see if we got the position from the server
				// if we did, looks like we got it updated from the UDP socket
				if (%position !$= %obj.lastPosition) {
					// got an update from the server!
					%obj.onServerTransformUpdate();
				}

				%delta = getRealTime() - %obj.lastLerp;

				// extrapolate position
				%position = %obj.lastServerPosition;
				%extrapPosition = vectorExtrapolate(%position, %obj.velocity, (%delta / 1000));
				%obj.setTransform(%extrapPosition SPC %rotation);

				// store transform
				%obj.lastPosition = %extrapPosition;
			}
		}
	}
}

///@server called whenever a packet is received for this object
function SceneObject::onServerTransformUpdate(%this) {
	if (getRealTime() - %this.lastLerp < ServerConnection.getPing() / 2)
		return;

	// calculate dx/dt (velocity) of the shape, based upon reference frames
	%vel = vectorSub(%this.getPosition(), %this.lastServerPosition);
	%vel = vectorScale(%vel, 1000 / (getRealTime() - %this.lastLerp));
	%this.velocity = %vel;

	// set reference frame position
	%this.lastServerPosition = %this.getPosition();
	%this.lastPosition = %this.getPosition();
	%this.lastLerp = getRealTime();
}

///@summary linear extrapolation, extrapolate using velocity from known position and
/// a time delta for scaling.
///@return vector that is extrapolated that is added to current position
function vectorExtrapolate(%pos, %vel, %delta) {
	return VectorAdd(%pos, VectorScale(%vel, %delta));
}

//MenuLogo.setBitmap($usermods @ "/client/ui/menu/pq_winterfest");
//VersionText.setPosition(VectorAdd(VersionText.position, "16 60"));
