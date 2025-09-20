//-----------------------------------------------------------------------------
// Coop mode
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_coop) {
	class = "ModeInfo_coop";
	superclass = "ModeInfo";

	identifier = "coop";
	file = "coop";
	force = 1;

	name = "Co-op";
	desc = "Team up with a friend and beat levels together!";
	complete = 0;
	hide = 1;

	teams = 0;
});


function ClientMode_coop::onLoad(%this) {
	%this.registerCallback("shouldIgnoreItem");
	%this.registerCallback("shouldPickupItem");
	%this.registerCallback("shouldUseClientPowerups");
	%this.registerCallback("showEndGame");
	%this.registerCallback("closeEndGame");
	%this.registerCallback("onShowPlayGui");
	%this.registerCallback("onFrameAdvance");
	%this.registerCallback("getLevelGame");
	%this.registerCallback("getLevelType");
	%this.registerCallback("shouldUpdateBlast");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}
function ClientMode_coop::shouldIgnoreItem(%this, %object) {
	%name = %object.this.getDataBlock().getName();
	switch$ (%name) {
	case  "SuperJumpItem" or "SuperJumpItem_PQ" or "SuperJumpItem_MBU" or
			"SuperSpeedItem" or "SuperSpeedItem_PQ" or "SuperSpeedItem_MBU" or
			"SuperBounceItem" or "SuperBounceItem_PQ" or
			"ShockAbsorberItem" or "ShockAbsorberItem_PQ" or
			"HelicopterItem" or "HelicopterItem_PQ" or "HelicopterItem_MBU" or
			"MegaMarbleItem" or "MegaMarbleItem_MBU" or
			"AntiGravityItem" or "AntiGravityItem_PQ" or "AntiGravityItem_MBU" or
			"NoRespawnAntiGravityItem" or "NoRespawnAntiGravityItem_PQ" or
			"TeleportItem" or "AnvilItem":
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
	case "BlastItem" or "BlastItem_MBU" or "BubbleItem" or "FireballItem":
		if (%object.this.respawning) {
			return true;
		} else {
			return false;
		}
	}
}
function ClientMode_coop::shouldPickupItem(%this, %object) {
	%name = %object.this.getDataBlock().getName();
	switch$ (%name) {
	case  "SuperJumpItem" or "SuperJumpItem_PQ" or "SuperJumpItem_MBU" or
			"SuperSpeedItem" or "SuperSpeedItem_PQ" or "SuperSpeedItem_MBU" or
			"SuperBounceItem" or "SuperBounceItem_PQ" or
			"ShockAbsorberItem" or "ShockAbsorberItem_PQ" or
			"HelicopterItem" or "HelicopterItem_PQ" or "HelicopterItem_MBU" or
			"MegaMarbleItem" or "MegaMarbleItem_MBU" or
			"AntiGravityItem" or "AntiGravityItem_PQ" or "AntiGravityItem_MBU" or
			"NoRespawnAntiGravityItem" or "NoRespawnAntiGravityItem_PQ" or
			"TeleportItem" or "AnvilItem":
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
	case "BlastItem" or "BlastItem_MBU" or "BubbleItem" or "FireballItem":
		if (%object.this.respawning) {
			return false;
		} else {
			return true;
		}
	}
	return false;
}
function ClientMode_coop::shouldUseClientPowerups(%this) {
	return true;
}
function ClientMode_coop::showEndGame(%this) {
	RootGui.pushDialog(MPCoopEndGameDlg);
	return true;
}
function ClientMode_coop::closeEndGame(%this) {
	RootGui.popDialog(MPCoopEndGameDlg);
}
function ClientMode_coop::onShowPlayGui(%this) {
	//Show this by default
	if ($pref::ShowCoopView $= "")
		$pref::ShowCoopView = true;
	PGCoopView.setVisible($pref::ShowCoopView);
}
function ClientMode_coop::onFrameAdvance(%this, %delta) {
	%count = ServerConnection.getCount();
	if (!isObject(ClientCoOpMarbleSimSet)) {
		new SimSet(ClientCoOpMarbleSimSet);
		RootGroup.add(ClientCoOpMarbleSimSet);
	}
	// count changed, rebuild list.
	if (%count != $Client::LastCoOpPlayerViewServerConnectionCount) {
		ClientCoOpMarbleSimSet.clear();

		for (%i = 0; %i < %count; %i++) {
			%obj = ServerConnection.getObject(%i);
			if (%obj.getClassName() $= "Marble" && (!isObject($MP::MyMarble) || %obj.getId() != $MP::MyMarble.getId())) {
				ClientCoOpMarbleSimSet.add(%obj);
			}
		}
	}

	// If there are none, bail.
	%marbleCount = ClientCoOpMarbleSimSet.getCount();
	if (%marbleCount == 0) {
		PGCoopView.setVisible(false);
		return;
	}


	// If the current marble we were viewing isn't in the simset, they left or crashed or something weird happened.
	// If so, just pick the first one.
	// If it is in the simset, recalc their position in the simset.
	// Only do this if we have the co op view open, if it is closed, don't show it.
	%visible = ($pref::ShowCoopView != -1);
	if (%visible) {
		PGCoopView.setVisible(true);
		if (!ClientCoOpMarbleSimSet.isMember($Client::LastCoOpMarble)) {
			// grab first one.
			$pref::ShowCoopView = 0;
		}
	}

	// Update variables and view visibility/marble
	$Client::LastCoOpPlayerViewServerConnectionCount = %count;
	PGCoopView.setVisible(%visible);
	if (%visible) {
		PGCoopView.setCameraTransform($Client::LastCoOpMarble.getEstCameraTransform());
		$Client::LastCoOpMarble = ClientCoOpMarbleSimSet.getObject($pref::ShowCoopView);
	}
}
function ClientMode_coop::getLevelGame(%this, %level) {
	if (strPos(%level, "coop/") != -1) {
		if (strPos(%level, "custom") != -1)
			return "custom";
		%dir = fileBase(filePath(%level));
		if (strPos(%dir, "_") == -1)
			return %dir;
		return getSubStr(%dir, 0, strPos(%dir, "_"));
	}
	return ""; //Unsure; keep looking
}
function ClientMode_coop::getLevelType(%this, %level) {
	if (strPos(%level, "coop/") != -1) {
		if (strPos(%level, "custom") != -1)
			return "custom";
		%dir = fileBase(filePath(%level));
		if (strPos(%dir, "_") == -1)
			return %dir;
		return getSubStr(%dir, strPos(%dir, "_") + 1, strLen(%dir));
	}
	return ""; //Unsure; keep looking
}
function ClientMode_coop::shouldUpdateBlast(%this) {
	//Allow people to use blast if they're starting the level
	return $Game::State !$= "End";
}

if (!$Server::Dedicated) {

//--- OBJECT WRITE BEGIN ---
	new GuiBitmapCtrl(MPCoopEndGameDlg) {
		profile = "GuiDefaultProfile";
		horizSizing = "width";
		vertSizing = "height";
		position = "0 0";
		extent = "800 600";
		minExtent = "8 8";
		visible = "1";
		helpTag = "0";
		bitmap = "~/client/ui/exit/black";
		wrap = "0";
		_guiSize = "800 600";
		defaultControl = "MPCEndGameLobby";
		commandAlt1 = "MPCoopEndGameDlg.restart();";
		commandNameAlt1 = "Restart";

		new GuiControl() {
			profile = "GuiDefaultProfile";
			horizSizing = "center";
			vertSizing = "center";
			position = "25 0";
			extent = "750 600";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";

			new GuiMLTextCtrl(MPCEndGame_Title) {
				profile = "GuiMLTextProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "0 15";
				extent = "750 14";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
			};
			new GuiMLTextCtrl(MPCEndGame_Time) {
				profile = "GuiMLTextProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "0 65";
				extent = "750 14";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
			};
			new GuiMLTextCtrl(MPCEndGame_ChallengeTimes) {
				profile = "GuiMLTextProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "0 115";
				extent = "750 14";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
			};
			new GuiMLTextCtrl(MPCEndGame_Rank) {
				profile = "GuiMLTextProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "0 535";
				extent = "750 14";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
			};
			new GuiScrollCtrl() {
				profile = "PQScrollWhiteProfile";
				horizSizing = "width";
				vertSizing = "height";
				position = "0 160";
				extent = "750 290";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				willFirstRespond = "1";
				hScrollBar = "dynamic";
				vScrollBar = "alwaysOff";
				constantThumbHeight = "0";
				childMargin = "0 0";

				new GuiControl(MPCEndGame_Scroll) {
					profile = "GuiDefaultProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "0 0";
					extent = "750 270";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
				};
			};
			new GuiControl(MPCEndButtonsContainer) {
				profile = "GuiDefaultProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "172 450";
				extent = "456 55";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";

				new GuiBorderButtonCtrl(MPCEndGameRestart) {
					profile = "PQButton28Profile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "0 0";
					extent = "114 55";
					minExtent = "8 8";
					visible = "1";
					command = "MPCoopEndGameDlg.restart();";
					helpTag = "0";
					text = "Restart";
					groupNum = "-1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
					controlRight = "MPCEndGameRate";
				};
				new GuiBorderButtonCtrl(MPCEndGameRate) {
					profile = "PQButton28Profile";
					horizSizing = "left";
					vertSizing = "top";
					position = "114 0";
					extent = "114 55";
					minExtent = "8 8";
					visible = "1";
					command = "MPCoopEndGameDlg.showRate();";
					helpTag = "0";
					text = "Rate";
					groupNum = "-1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
					controlLeft = "MPCEndGameRestart";
					controlRight = "MPCEndGameLobby";
				};
				new GuiBorderButtonCtrl(MPCEndGameLobby) {
					profile = "PQButton28Profile";
					horizSizing = "left";
					vertSizing = "top";
					position = "228 0";
					extent = "114 55";
					minExtent = "8 8";
					visible = "1";
					command = "MPCoopEndGameDlg.lobby();";
					helpTag = "0";
					text = "Lobby";
					groupNum = "-1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
					controlLeft = "MPCEndGameRate";
					controlRight = "MPCEndGameNext";
				};
				new GuiBorderButtonCtrl(MPCEndGameNext) {
					profile = "PQButton28Profile";
					horizSizing = "left";
					vertSizing = "top";
					position = "342 0";
					extent = "114 55";
					minExtent = "8 8";
					visible = "1";
					command = "MPCoopEndGameDlg.cont();";
					helpTag = "0";
					text = "Next";
					groupNum = "-1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
					controlLeft = "MPCEndGameLobby";
				};
			};
			new GuiControl(MPCEndRateContainer) {
				profile = "GuiDefaultProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "250 450";
				extent = "300 100";
				minExtent = "8 8";
				visible = "0";
				helpTag = "0";

				new GuiMLTextCtrl(MPCEndRateTitle) {
					profile = "GuiMLTextProfile";
					horizSizing = "width";
					vertSizing = "bottom";
					position = "0 56";
					extent = "300 25";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
					lineSpacing = "2";
					allowColorChars = "0";
					maxChars = "-1";
				};
				new GuiBitmapButtonCtrl(MPCEndRateNegative) {
					profile = "GuiDefaultProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "40 0";
					extent = "60 60";
					minExtent = "8 8";
					visible = "1";
					command = "MPCoopEndGameDlg.rate(-1);";
					helpTag = "0";
					text = "Dislike";
					groupNum = "1";
					buttonType = "RadioButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
					bitmap = "platinum/client/ui/mp/end/rate-negative";
					controlRight = "MPCEndRateNeutral";
				};
				new GuiBitmapButtonCtrl(MPCEndRateNeutral) {
					profile = "GuiDefaultProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "120 0";
					extent = "60 60";
					minExtent = "8 8";
					visible = "1";
					command = "MPCoopEndGameDlg.rate(0);";
					helpTag = "0";
					text = "Indifferent";
					groupNum = "1";
					buttonType = "RadioButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
					bitmap = "platinum/client/ui/mp/end/rate-neutral";
					controlLeft = "MPCEndRateNegative";
					controlRight = "MPCEndRatePositive";
				};
				new GuiBitmapButtonCtrl(MPCEndRatePositive) {
					profile = "GuiDefaultProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "200 0";
					extent = "60 60";
					minExtent = "8 8";
					visible = "1";
					command = "MPCoopEndGameDlg.rate(1);";
					helpTag = "0";
					text = "Like";
					groupNum = "1";
					buttonType = "RadioButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
					bitmap = "platinum/client/ui/mp/end/rate-positive";
					controlLeft = "MPCEndRateNeutral";
				};
			};
		};
	};
//--- OBJECT WRITE END ---
}

function MPCoopEndGameDlg::onWake(%this) {
	disableChatHUD();
	if (ControllerGui.isJoystick()) {
		showControllerUI();
	}

	%time = $Game::ScoreTime;
	%timeColor = "ffffff";

	%scoreVals = $Game::FinalScore;
	%flags = Unlock::getMissionScoreFlags(MissionInfo, %scoreVals);

	%type = getField(%scoreVals, 0);
	%score = getField(%scoreVals, 1);
	%name = (%type $= $ScoreType::Time) ? "Time" : "Score";

	%color = getScoreFormatting(%scoreVals, MissionInfo);
	%formatted = %color @ (%type == $ScoreType::Time ? formatTime(%score) : formatScore(%score));

	%text = "<bold:48><color:FFFFFF><just:center><shadowcolor:0000007f><shadow:1:1>";

	if ($Cheats::Activated) {
		%text = %text @ "Nice Cheats!";
	} else if ($Editor::Opened) {
		%text = %text @ "<color:00cc00><shadow:1:1><shadowcolor:0000007f>Level Editor Opened";
	} else {
		if (%flags & $Completion::Awesome) {
			%text = %text @ "Who's Awesome? <spush><color:FF3333><shadowcolor:AA22227F>You're<spop> Awesome!";
		} else if (%flags & $Completion::Ultimate) {
			%text = %text @ "You beat the <spush><color:FFCC33><shadowcolor:0000007F>Ultimate<spop> " @ %name @ "!";
		} else if (%flags & $Completion::Platinum) {
			%text = %text @ "You beat the <spush><color:CCCCCC><shadowcolor:0000007F>Platinum<spop> " @ %name @ "!";
		} else if (%flags & $Completion::Gold) {
			%text = %text @ "You beat the <spush><color:FFEE11><shadowcolor:0000007F>Gold<spop> " @ %name @ "!";
		} else if (%flags & $Completion::Par) {
			//No score, you just qualified
			if ($CurrentGame $= "Gold") {
				%text = %text @ "You've Qualified!";
			} else {
				%text = %text @ "You beat the Par " @ %name @ "!";
			}
		} else {
			if ($CurrentGame $= "Gold") {
				%text = %text @ "<color:f55555><shadowcolor:800000>You didn\'t pass the Qualify " @ %name @ "!";
			} else {
				%text = %text @ "<color:f55555><shadowcolor:800000>You didn\'t pass the Par " @ %name @ "!";
			}
		}
	}
	MPCEndGame_Title.setText(%text);

	MPCEndGame_Time.setText("<font:38><color:ffffff><just:center>" @ shadow("1 1", "0000007f") @
	                        "Your " @ %name @ ": <color:" @ %timeColor @ ">" @ %formatted);

	//Challenge times
	%goldTimeLabel     = (MissionInfo.goldTime     !$= "" ? formatTime(MissionInfo.goldTime)     : "");
	%platinumTimeLabel = (MissionInfo.platinumTime !$= "" ? formatTime(MissionInfo.platinumTime) : "");
	%ultimateTimeLabel = (MissionInfo.ultimateTime !$= "" ? formatTime(MissionInfo.ultimateTime) : "");
	//Challenge scores
	%goldScoreLabel     = (MissionInfo.goldScore     !$= "" ? formatScore(MissionInfo.goldScore)     : "");
	%platinumScoreLabel = (MissionInfo.platinumScore !$= "" ? formatScore(MissionInfo.platinumScore) : "");
	%ultimateScoreLabel = (MissionInfo.ultimateScore !$= "" ? formatScore(MissionInfo.ultimateScore) : "");

	//Type is time if we have a time, otherwise score if we have a score, otherwise default
	%goldType     = (%goldTimeLabel     $= "" ? (%goldScoreLabel     $= "" ? %name : "Score") : "Time");
	%platinumType = (%platinumTimeLabel $= "" ? (%platinumScoreLabel $= "" ? %name : "Score") : "Time");
	%ultimateType = (%ultimateTimeLabel $= "" ? (%ultimateScoreLabel $= "" ? %name : "Score") : "Time");

	//Use score if a time isn't available
	%goldLabel     = ((%goldType     $= "Score") ? %goldScoreLabel     : %goldTimeLabel);
	%platinumLabel = ((%platinumType $= "Score") ? %platinumScoreLabel : %platinumTimeLabel);
	%ultimateLabel = ((%ultimateType $= "Score") ? %ultimateScoreLabel : %ultimateTimeLabel);

	//Information text
	%goldTitle     = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum"; //Yeah even in MBG... idc enough
	%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum";
	%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";

	%text = "";
	//Show what we need to
	if (%goldTitle     !$= "" && %goldLabel     !$= "")
		%text = %text @ (%text $= "" ? "" : "   ") @ "<spush>" @ %goldTitle     SPC %goldType     @ ": " @ %goldLabel     @ "<spop>";
	if (%platinumTitle !$= "" && %platinumLabel !$= "")
		%text = %text @ (%text $= "" ? "" : "   ") @ "<spush>" @ %platinumTitle SPC %platinumType @ ": " @ %platinumLabel @ "<spop>";
	if (%ultimateTitle !$= "" && %ultimateLabel !$= "")
		%text = %text @ (%text $= "" ? "" : "   ") @ "<spush>" @ %ultimateTitle SPC %ultimateType @ ": " @ %ultimateLabel @ "<spop>";
	%text = "<font:32><color:ffffff><just:center>" @ %text;

	MPCEndGame_ChallengeTimes.setText(%text);

	%this.populate();
	%this.updateActive();
	%this.updateRating();
	%this.force = false;

	MPCEndGameLobby.setText(($Server::Hosting && !%this.force) ? "Lobby" : "Exit");
	MPCEndGameRestart.setActive($Server::Hosting);
	MPCEndGameNext.setActive($Server::Hosting);

	MPCEndButtonsContainer.setVisible(1);
	MPCEndRateContainer.setVisible(0);
}

function MPCoopEndGameDlg::updateActive(%this) {
	MPCEndGameRestart.setActive($Server::Hosting);
	%this.commandNameAlt1 = (MPCEndGameRestart.isActive() ? "Restart" : "");
	%this.commandAlt1 = (MPCEndGameRestart.isActive() ? MPCEndGameRestart.command : "");
	if (ControllerGui.isJoystick()) {
		ControllerGui.updateButtons();
	}
}

function coop() {
	MPCoopEndGameDlg.delete();
	reloadClientGameModes();
	Canvas.pushDialog(MPCoopEndGameDlg);
}

function MPCoopEndGameDlg::cont(%this) {
	//Load next
	%pmg = PlayMissionGui;

	while (true) {
		%list = %pmg.getMissionList($CurrentGame, $MissionType);
		%pmg.selectedIndex ++;

		if (%pmg.selectedIndex >= %list.getSize()) {
			devecho("Next: End of list " @ $MissionType);
			//Next list
			%diffs = %pmg.getDifficultyList($CurrentGame);
			%diff = $MissionType;
			for (%i = 0; %i < getRecordCount(%diffs); %i ++) {
				%record = getRecord(%diffs, %i);
				if (getField(%record, 0) $= %diff) {
					%found = true;
					break;
				}
			}
			if (!%found) {
				//Unknown difficulty?
				devecho("Next: Can't find difficulty");
				%this.lobby();
				return;
			}
			%next = getField(getRecord(%diffs, %i + 1), 0);
			if (%next $= "") {
				devecho("Next: Out of missions");
				%this.lobby();
				return;
			}

			//Select the next difficulty
			%pmg.setMissionType(%next);
			%pmg.selectedIndex = 0;
			devecho("Next: Trying list " @ $MissionType);
			%list = %pmg.getMissionList($CurrentGame, %next);
		}

		%mission = %list.getEntry(%pmg.selectedIndex);
		devecho("Next: Found mission " @ %mission.name);
		devecho("Next: Can display: " @ Unlock::canDisplayMission(%mission));
		devecho("Next: Can play: " @ Unlock::canPlayMission(%mission));

		if (Unlock::canDisplayMission(%mission) && Unlock::canPlayMission(%mission))
			break;
	}
	devecho("Next: Final choice is " @ %mission.name);
	if (isObject(%mission)) {
		%file = %mission.file;
		%pmg.setMissionByIndex(%pmg.selectedIndex);
		commandToServer('LoadMission', %file);
	}
}

function MPCoopEndGameDlg::lobby(%this) {
	if ($Server::Hosting && !%this.force) {
		%this.force = true;
		commandToServer('LobbyReturn');
		MPCEndGameLobby.schedule(500, setText, "Exit");
	} else {
		disconnect();
	}
}

function MPCoopEndGameDlg::restart(%this) {
	commandToServer('LobbyRestart');
}

function MPCoopEndGameDlg::showRate(%this) {
	MPCEndButtonsContainer.setVisible(0);
	MPCEndRateContainer.setVisible(1);

	if (ControllerGui.isJoystick()) {
		ControllerGui.selectControl(MPCEndRatePositive);
	}
}

function MPCoopEndGameDlg::populate(%this) {
	%this.clearPlayers();
	if ($MP::TeamMode) {
		%count = TeamScorePlayerList.getSize();
		for (%i = 0; %i < %count; %i ++) {
			%player = getRecord(TeamScorePlayerList.getEntry(%i), 1);
			%score  = getRecord(TeamScorePlayerList.getEntry(%i), 2);
			%index  = getRecord(TeamScorePlayerList.getEntry(%i), 3);
			%marble = getRecord(TeamScorePlayerList.getEntry(%i), 4);
			%bonus  = getRecord(TeamScorePlayerList.getEntry(%i), 6);

			%this.addPlayer(%i, %count, %player, %score, %bonus, %marble, %index);
		}
	} else {
		%count = ScoreList.getSize();
		for (%i = 0; %i < %count; %i ++) {
			%player = ScoreList.getEntry(%i).name;
			%score  = ScoreList.getEntry(%i).score;
			%index  = ScoreList.getEntry(%i).index;
			%marble = ScoreList.getEntry(%i).skin;
			%bonus  = ScoreList.getEntry(%i).bonus;

			%this.addPlayer(%i, %count, %player, %score, %bonus, %marble, %index);
		}
	}
}

function MPCoopEndGameDlg::clearPlayers(%this) {
	//Remove all players
	MPCEndGame_Scroll.clear();
}

function MPCoopEndGameDlg::addPlayer(%this, %idx, %count, %name, %gems, %tts, %marble, %index) {
	//Name of the text fields
	%boxName    = "MPCEndGame_Player" @ %idx;
	%nameName   = "MPCEndGame_PlayerName" @ %idx;
	%gemsName   = "MPCEndGame_PlayerGems" @ %idx;
	%ttsName    = "MPCEndGame_PlayerTTs" @ %idx;
	%marbleName = "MPCEndGame_PlayerMarble" @ %idx;

	switch (%count) {
	case 1:
		%width = 750;
		%spacing = 750;
	case 2:
		%width = 350;
		%spacing = 375;
	case 3:
		%width = 250;
		%spacing = 250;
	case 4:
		%width = 180;
		%spacing = 187;
	default:
		%width = 180;
		%spacing = 187;
	}

	//Position of the control
	%position = (%idx * %spacing) SPC 0;
	%extent = %width SPC 270;

	%marblePos = ((%width / 2) - 50) SPC 40;

	//Resize the parent so we can scroll if necessary
	MPCEndGame_Scroll.setExtent(max(750, (%idx + 1) * %spacing) SPC 270);
	MPCEndGame_Scroll.add(
	new GuiControl(%boxName) {
		profile = "GuiDefaultProfile";
		horizSizing = "right";
		vertSizing = "bottom";
		position = %position;
		extent = %extent;
		visible = "1";

		new GuiMLTextCtrl(%nameName) {
			profile = "GuiMLTextProfile";
			horizSizing = "center";
			vertSizing = "bottom";
			position = "0 0";
			extent = %width SPC 14;
			visible = "1";
		};
		new GuiObjectView(%marbleName) {
			profile = "GuiDefaultProfile";
			horizSizing = "center";
			vertSizing = "bottom";
			position = %marblePos;
			extent = "100 100";
			visible = "1";
			cameraZRot = "0";
			forceFOV = "0";
			model = $usermods @ "/data/shapes/balls/ball-superball.dts";
			skin = "base";
			cameraRotX = "0";
			cameraZRotSpeed = "0.001";
			orbitDistance = "0.75";
			autoSize = "0";
		};
		new GuiObjectView() {
			profile = "GuiDefaultProfile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "0 140";
			extent = "64 64";
			visible = "1";
			cameraZRot = "0";
			forceFOV = "0";
			model = "~/data/shapes/items/gem.dts";
			skin = "base";
			cameraRotX = "0";
			cameraZRotSpeed = "0.001";
			orbitDistance = "1";
			autoSize = "0";
		};
		new GuiObjectView() {
			profile = "GuiDefaultProfile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "0 200";
			extent = "64 64";
			visible = "1";
			cameraZRot = "0";
			forceFOV = "0";
			model = "~/data/shapes/items/timetravel.dts";
			skin = "base";
			cameraRotX = "0";
			cameraZRotSpeed = "0.001";
			orbitDistance = "1.5";
			autoSize = "0";
		};
		new GuiMLTextCtrl(%gemsName) {
			profile = "GuiMLTextProfile";
			horizSizing = "left";
			vertSizing = "bottom";
			position = "64 150";
			extent = (%width - 64) SPC 14;
			visible = "1";
		};
		new GuiMLTextCtrl(%ttsName) {
			profile = "GuiMLTextProfile";
			horizSizing = "left";
			vertSizing = "bottom";
			position = "64 214";
			extent = (%width - 64) SPC 14;
			visible = "1";
		};
	}
	);

	echo(%name SPC %gems SPC %tts SPC %marble);

	%nameColor = (%index == $Game::FinisherIndex ? "<color:66BBFF>" : "<color:ffffff>");

	%nameName.setText("<font:32>" @ %nameColor @ "<just:center>" @ shadow("1 1", "0000007f") @ LBResolveName(%name, true));
	%gemsName.setText("<font:24><color:ffffff><just:right>" @ shadow("1 1", "0000007f") @ %gems);
	%ttsName.setText("<font:24><color:ffffff><just:right>" @ shadow("1 1", "0000007f") @ formatTime(%tts));

	// Shape and skin for the marble
	%shape = getField(%marble, 0);
	%skin  = getField(%marble, 1);
	if (!isFile(%shape)) {
		%shape = $usermods @ "/data/shapes/balls/ball-superball.dts";
		%skin = "base";
	}
	%marbleName.setModel(%shape, %skin);

	// Set fields so they don't reset when we pop the gui
	%marbleName.model   = %shape;
	%marbleName.skin    = %skin;
}

function MPCoopEndGameDlg::updateRating(%this) {
	MPCEndRateTitle.setText("<just:center><color:ffffff><font:18>Rate This Level");

	//Check if they've rated this level before
	%level = fileBase($Client::MissionFile);
	%choice = $MPPref::LevelRating[%level];

	if (%choice $= "") {
		MPCEndRateNegative.setValue(0);
		MPCEndRateNeutral.setValue(0);
		MPCEndRatePositive.setValue(0);
	} else {
		switch (%choice) {
		case -1:
			MPCEndRateNegative.setValue(1);
		case  0:
			MPCEndRateNeutral.setValue(1);
		case  1:
			MPCEndRatePositive.setValue(1);
		}
	}
}

function MPCoopEndGameDlg::rate(%this, %choice) {
	//Rate the level:
	// -1: Negative / Dislike
	//  0: Neutral / Indifferent
	//  1: Positive / Like

	statsRateMission(PlayMissionGui.getMissionInfo(), %choice);

	$MPPref::LevelRating[%level] = %choice;
	MPCEndButtonsContainer.setVisible(1);
	MPCEndRateContainer.setVisible(0);

	if (ControllerGui.isJoystick()) {
		ControllerGui.selectControl(MPCEndGameLobby);
	}
}
