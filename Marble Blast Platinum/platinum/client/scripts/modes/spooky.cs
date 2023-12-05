//-----------------------------------------------------------------------------
// Halloween mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_spooky) {
	class = "ModeInfo_spooky";
	superclass = "ModeInfo";

	identifier = "spooky";
	file = "spooky";

	name = "Halloween Event";
	desc = "3spooky5me";
});

function ModeInfo_Spooky::isAvailable(%this) {
	return !!$LB::SpookyMode;
}

function ClientMode_spooky::onLoad(%this) {
	%this.registerCallback("updatePlayMission");
	%this.registerCallback("onActivate");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("getEggIcon");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}

function updateSpookyButtons(%enable) {
	if (%enable) {
		$PMG::BarButton["BottomMP", "Name",       4] = "PM_MissionGhosts";
		$PMG::BarButton["BottomMP", "Command",    4] = "if ($ControllerEvent) {$MPPref::SpookyGhosts = !$MPPref::SpookyGhosts; $ThisControl.setValue($MPPref::SpookyGhosts); } updateGhostButton(); "; //Hack for controllers
		$PMG::BarButton["BottomMP", "Variable",   4] = "$MPPref::SpookyGhosts";
		$PMG::BarButton["BottomMP", "ButtonType", 4] = "ToggleButton";
		$PMG::BarButton["BottomMP", "Bitmap",     4] = "platinum/client/ui/play/buttons/ghosts.png";
		$PMG::BarButton["BottomMP", "Count"] = 5;

		if (mp()) {
			PlayMissionGui.buildButtonBar("BottomMP");
			PlayMissionGui.buildButtonBar("ExtraMP");
			PlayMissionGui.updateMPButtons();
			PlayMissionGui.clearServerPlayerList();
			PlayMissionGui.updateServerPlayerList();
			PM_MissionGhosts.setActive($Server::Hosting);
		}
		PM_ButtonBox.setExtent("534 90");

		updateGhostButton();
	} else {
		$PMG::BarButton["BottomMP", "Count"] = 4;

		if (mp()) {
			PlayMissionGui.buildButtonBar("BottomMP");
			PlayMissionGui.buildButtonBar("ExtraMP");
			PlayMissionGui.updateMPButtons();
			PlayMissionGui.clearServerPlayerList();
			PlayMissionGui.updateServerPlayerList();
			PM_MissionGhosts.setActive($Server::Hosting);
		}
		PM_ButtonBox.setExtent("434 90");
	}
}

function updateGhostButton() {
	if ($Server::Hosting) {
		commandToServer('SpookyGhosts', $MPPref::SpookyGhosts);
	}
}

function clientCmdSpookyGhosts(%enable) {
	$MPPref::SpookyGhosts = %enable;
	$MP::Server::SpookyGhosts = %enable;
	PlayMissionGui.updateMissionInfo();
}

function ClientMode_spooky::onActivate(%this) {
	if ($Server::Dedicated) {
		//TFW dedicated servers call client code
		return;
	}
	updateSpookyButtons($Server::Hosting);
	cancel($spookyTP);
	$spookyTP = schedule(100, 0, spookyTexturePackActivate);
}
function spookyTexturePackActivate() {
	activateTexturePack("spooky");
	reloadTexturePackFields();
}

function ClientMode_spooky::onDeactivate(%this) {
	if ($Server::Dedicated) {
		//TFW dedicated servers call client code
		return;
	}
	updateSpookyButtons(false);
	cancel($spookyTP);
	$spookyTP = schedule(100, 0, spookyTexturePackDeactivate);
}
function spookyTexturePackDeactivate() {
	deactivateTexturePack("spooky");
	reloadTexturePackFields();
}

function ClientMode_spooky::updatePlayMission(%this, %location) {
	switch$ (%location) {
	case "sp":
		%text = PM_MissionInfo.getText();
		%text = strReplace(%text, "<color:CCCCCC>Platinum", "<color:FF8000>Spooky");
		%text = strReplace(%text, "<color:FFCC33>Ultimate", "<color:CC2222>Scary");
		PM_MissionInfo.setText(%text);

		%text = PM_MissionScoresInfo.getText();
		%text = strReplace(%text, "<color:CCCCCC>", "<color:FF8000>");
		%text = strReplace(%text, "<color:FFCC33>", "<color:CC2222>");
		PM_MissionScoresInfo.setText(%text);
	}
}

function ClientMode_spooky::getEggIcon(%this, %found) {
	%egg = "platinum/data/texture_packs/spooky/candy";
	%egg = %egg @ (%found ? "" : "_nf");
	return %egg;
}


//This is so hacky it spooks your judging words right out of your mouth.
// ...
// I'm sorry
package SpookyLevelSelect {
	function PlayMissionGui::updateMissionFrame(%this, %frame) {
		Parent::updateMissionFrame(%this, %frame);
		if (strpos(%frame.mission.gamemode, "spooky") != -1) {
			%image = %frame.button.bitmap;
			%new = strReplace(%image, "client/ui/play", "data/texture_packs/spooky");
			%frame.button.setBitmap(%new);
		}
	}
};
activatePackage(SpookyLevelSelect);

function clientCmdCandyCorn(%time) {
	%saved = PlayMissionGui.onlineEasterEggCache.getFieldValue(PlayMissionGui.getMissionInfo().id);

	if (%time < %saved || %saved $= "") {
		PlayMissionGui.onlineEasterEggCache.setFieldValue(PlayMissionGui.getMissionInfo().id, %time);
	}

	statsRecordEgg(PlayMissionGui.getMissionInfo(), %time);
}

// //RIP Threefolder
// if (!$pref::Spookied && $pref::Video::TexturePack[1] $= "") {
// 	$pref::Spookied = true;
// 	$pref::Video::TexturePack[1] = "dark";
// }

//MenuLogo.setBitmap($usermods @ "/client/ui/menu/pq_frightfest");
//VersionText.setPosition(VectorAdd(VersionText.position, "5 40"));
