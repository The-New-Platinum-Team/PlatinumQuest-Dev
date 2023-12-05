//-----------------------------------------------------------------------------
// Racing mode
//
// Originally created in 2014
//
// Copyright (c) 2024 The Platinum Team
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_race) {
	class = "ModeInfo_race";
	superclass = "ModeInfo";

	identifier = "race";
	file = "race";

	name = "Racing";
	desc = "Race against your opponents and see who can finish the fastest!";
	complete = 1;
});


function ClientMode_race::onLoad(%this) {
	%this.registerCallback("shouldUseTimeScoreboard");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("radarShouldShowObject");
	%this.registerCallback("shouldIgnoreItem");
	%this.registerCallback("shouldPickupItem");
	%this.registerCallback("shouldUseClientPowerups");
	%this.registerCallback("showSpectatorMenu");
	%this.registerCallback("displayScoreList");
	%this.registerCallback("showEndGame");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_race::shouldUseTimeScoreboard(%this) {
	return true;
}
function ClientMode_race::onDeactivate(%this) {
	%this.updateRaceEndGame(true);
}

//-----------------------------------------------------------------------------

function ClientMode_race::radarShouldShowObject(%this, %object) {
	return !%object.isHidden() && !%object.isCloaked();
}

function clientCmdRacingOnRespawn() {
	for (%i = 0; %i < ServerConnection.getCount(); %i ++) {
		%obj = ServerConnection.getObject(%i);
		if (!%obj.isKindOfClass("GameBase"))
			continue;
		if (strStr(strlwr(%obj.getDatablock().getName()), "staticgem") != -1) {
			%obj.hide(true);
			%obj._checkpoint = 0;
		} else if (strStr(strlwr(%obj.getDatablock().getName()), "gem") != -1) {
			%obj.hide(false);
			%obj._checkpoint = 0;
			if (isObject(%obj.fx) && %obj.fx._oldPos !$= "") {
				%obj.fx.setTransform(%obj.fx._oldPos);
				%obj.fx.inspectPostApply();
			}
		}
	}
	RadarBuildSearch();
}

function clientCmdRacingOnRespawnOnCheckpoint(%checkpoint) {
	for (%i = 0; %i < ServerConnection.getCount(); %i ++) {
		%obj = ServerConnection.getObject(%i);
		if (!%obj.isKindOfClass("GameBase"))
			continue;
		if (strStr(strlwr(%obj.getDatablock().getName()), "staticgem") != -1 && %obj._checkpoint >= %checkpoint) {
			%obj.hide(true);
		} else if (strStr(strlwr(%obj.getDatablock().getName()), "gem") != -1 && %obj._checkpoint >= %checkpoint) {
			%obj.hide(false);
			if (isObject(%obj.fx) && %obj.fx._oldPos !$= "") {
				%obj.fx.setTransform(%obj.fx._oldPos);
				%obj.fx.inspectPostApply();
			}
		}
	}
	RadarBuildSearch();
}

function clientCmdGemPickup(%ID, %staticID, %fxID, %checkpoint) {
	%gem = getClientSyncObject(%ID);
	if (!isObject(%gem))
		return;
	//Hide the gem
	%gem.hide(true);
	%gem._checkpoint = %checkpoint;
	//Show the static gem
	%staticGem = getClientSyncObject(%staticID);
	if (isObject(%staticGem)) {
		%staticGem.hide(false);
		%staticGem._checkpoint = %checkpoint;
	}
	//Hack: Hide the particles
	%fx = getClientSyncObject(%fxID);
	if (isObject(%fxID)) {
		%fx._oldPos = %fx.getTransform();
		%fx.setTransform("-1e9 -1e9 -1e9 1 0 0 0");
		%fx.inspectPostApply();
		%gem.fx = %fx;
	}
	//Radar::RemoveTarget(%gem);
	RadarBuildSearch();
}

//-----------------------------------------------------------------------------

function ClientMode_race::shouldIgnoreItem(%this, %object) {
	switch$ (%object.this.getDataBlock().getName()) {
	case  "SuperJumpItem" or "SuperJumpItem_PQ" or "SuperJumpItem_MBU" or
			"SuperSpeedItem" or "SuperSpeedItem_PQ" or "SuperSpeedItem_MBU" or
			"SuperBounceItem" or "SuperBounceItem_PQ" or
			"ShockAbsorberItem" or "ShockAbsorberItem_PQ" or
			"HelicopterItem" or "HelicopterItem_PQ" or "HelicopterItem_MBU" or
			"MegaMarbleItem" or "MegaMarbleItem_MBU" or
			"BlastItem" or "BlastItem_MBU" or
			"AntiGravityItem" or "AntiGravityItem_PQ" or "AntiGravityItem_MBU" or
			"NoRespawnAntiGravityItem" or "NoRespawnAntiGravityItem_PQ":
		//PowerUp
		if (%object.this.respawning) {
			return true;
		} else {
			if (%object.this._getPowerUpId() != 0) {
				if (%object.marble._powerUpId == %object.this._getPowerUpId()) {
					return true;
				}
				return false;
			}
			return false;
		}
	}
	return true;
}
function ClientMode_race::shouldPickupItem(%this, %object) {
	switch$ (%object.this.getDataBlock().getName()) {
	case  "SuperJumpItem" or "SuperJumpItem_PQ" or "SuperJumpItem_MBU" or
			"SuperSpeedItem" or "SuperSpeedItem_PQ" or "SuperSpeedItem_MBU" or
			"SuperBounceItem" or "SuperBounceItem_PQ" or
			"ShockAbsorberItem" or "ShockAbsorberItem_PQ" or
			"HelicopterItem" or "HelicopterItem_PQ" or "HelicopterItem_MBU" or
			"MegaMarbleItem" or "MegaMarbleItem_MBU" or
			"BlastItem" or "BlastItem_MBU" or
			"AntiGravityItem" or "AntiGravityItem_PQ" or "AntiGravityItem_MBU" or
			"NoRespawnAntiGravityItem" or "NoRespawnAntiGravityItem_PQ":
		//PowerUp
		if (%object.this.respawning) {
			return false;
		} else {
			if (%object.this._getPowerUpId() != 0) {
				if (%object.marble._powerUpId == %object.this._getPowerUpId()) {
					return false;
				}
				return true;
			}
			return true;
		}
	}
	return false;
}
function ClientMode_race::shouldUseClientPowerups(%this) {
	return true;
}

//-----------------------------------------------------------------------------

function ClientMode_race::showSpectatorMenu(%this, %object) {
	if (%object.show) {
		%text = "<bold:28><just:center>Spectator Info<font:14>\n" NL "<bold:22><just:left>Toggle Fly / Orbit:<just:right><func:bind toggleSpectateModeType>" NL "<just:left>Toggle Score List:<just:right><func:bind displayScoreList>";
		if (!$SpectateFlying) {
			%text = %text @ "<just:left>Prev Player:<just:right><func:bind moveLeft>" NL "<just:left>Next Player:<just:right><func:bind moveRight>";
		}
		PG_SpectatorText.setText(%text);
	}
	PG_SpectatorMenu.setVisible(%object.show);
	return false;
}

function ClientMode_race::displayScoreList(%this, %object) {
	if (!$SpectateMode || !$Client::GameRunning || $Game::Pregame)
		return false;
	//Show the end game GUI instead of the scores GUI
	RootGui.popDialog(MPScoresDlg);
	if (%object.val) {
		if (!MPEndGameDlg.isAwake()) { 
			RootGui.pushDialog(MPEndGameDlg);
		} else {
			RootGui.popDialog(MPEndGameDlg);
		}
	}
	return true;
}

function ClientMode_race::showEndGame(%this) {
	%this.onNextFrame(updateRaceEndGame);
	return false;
}

function ClientMode_race::updateRaceEndGame(%this, %cleanup) {
	if (!$Game::isMode["race"] && !%cleanup)
		return;
	//Swap the buttons at the bottom
	if ($Client::GameRunning && !%cleanup) {
		MPEndGameRestart.setVisible(false);
		MPEndGameLobby.setVisible(false);
		MPEndRateContainer.setVisible(false);
		MPEndGameRate.text = "Spectate";
		MPEndGameRate.command = "RootGui.popDialog(MPEndGameDlg);";
		MPEndGameRate.setExtent("128 55");
		MPEndGameRate.setPosition("107 0");
	} else {
		MPEndGameRestart.setVisible(true);
		MPEndGameLobby.setVisible(true);
		MPEndGameRate.text = "Rate";
		MPEndGameRate.command = "MPEndGameDlg.showRate();";
		MPEndGameRate.setExtent("114 55");
		MPEndGameRate.setPosition("114 0");
	}
}