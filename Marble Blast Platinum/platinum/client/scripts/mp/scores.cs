//------------------------------------------------------------------------------
// Multiplayer Package
// clientScores.cs
//
// Copyright (c) 2013 The Platinum Team
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

function clientCmdScoreListStart() {
	scoreListStart();
}

function scoreListStart() {
	// Prepare for a list!
	if (isObject(ScoreList)) {
		//Delete all player objects in the list
		for (%i = 0; %i < ScoreList.getSize(); %i ++) {
			%obj = ScoreList.getEntry(%i);
			if (isObject(%obj)) {
				%obj.delete();
			}
		}
		ScoreList.delete();
	}
	if (isObject(TeamScoreList))
		TeamScoreList.delete();
	if (isObject(TeamScorePlayerList))
		TeamScorePlayerList.delete();

	if (!isObject(ScoreObjectGroup))
		RootGroup.add(new SimGroup(ScoreObjectGroup));

	$MP::ScoreTeams = 0;
	$MP::ScorePlayers = 0;
	if ($MP::TeamMode) {
		Array(TeamScoreList);
		Array(TeamScorePlayerList);
	}
	Array(ScoreList);
}

function clientCmdScoreListPlayer(%list) {
	scoreListStart();

	%count = getRecordCount(%list);
	for (%i = 0; %i < %count; %i++) {
		%record = getRecord(%list, %i);

		%name = collapseEscape(getField(%record, 0));
		%score = getField(%record, 1);
		%gems = getField(%record, 2);
		%index = getField(%record, 3);
		%skin = collapseEscape(getField(%record, 4));
		%bonus = getField(%record, 5);

		%obj = new ScriptObject() {
			name = %name;
			score = %score;
			index = %index;
			skin = %skin;
			gems = %gems;
			bonus = %bonus;
		};
		ScoreObjectGroup.add(%obj);
		ScoreList.addEntry(%obj);
		ScoreList.player[%index] = %obj;
		$MP::ScorePlayers ++;
	}

	scoreListUpdate();
}

function clientCmdScoreListUpdate(%index, %score, %gems, %bonus) {
	//Delete all player objects in the list
	%player = ScoreList.player[%index];
	if (!isObject(%player))
		return;
	%player.score = %score;
	%player.gems = %gems;
	%player.bonus = %bonus;

	scoreListUpdate();
}

function clientCmdScoreListTeamPlayer(%list) {
	scoreListStart();

	while (%list !$= "") {
		%list = nextToken(%list, "teamInfo", "$$");

		%teamName = collapseEscape(getField(%teamInfo, 0));
		%totalScore = getField(%teamInfo, 1);
		%teamNumber = getField(%teamInfo, 2);
		%teamColor = getField(%teamInfo, 3);
		%playerList = getFields(%teamInfo, 4);

		TeamScoreList.team[%teamNumber] = TeamScoreList.getSize();
		TeamScoreList.addEntry(%teamName NL %totalScore NL 0 NL %teamNumber NL %teamColor);
		$MP::ScoreTeams ++;

		%playerCount = getRecordCount(%playerList);
		for (%i = 0; %i < %playerCount; %i++) {
			%record = getRecord(%playerList, %i);

			%name = collapseEscape(getField(%record, 0));
			%score = getField(%record, 1);
			%index = getField(%record, 2);
			%marble = collapseEscape(getField(%record, 3));
			%gems = getField(%record, 4);
			%bonus = getField(%record, 5);

			TeamScorePlayerList.player[%index] = TeamScorePlayerList.getSize();
			TeamScorePlayerList.addEntry(%teamName NL %name NL %score NL %index NL %marble NL %gems NL %bonus);
			$MP::ScorePlayers ++;

			//Add one to that team's player count
			for (%j = $MP::ScoreTeams - 1; %j >= 0; %j--) {
				%_team = TeamScoreList.getEntry(%j);
				if (getRecord(%_team, 0) $= %teamName) {
					%_team = setRecord(%_team, 2, getRecord(%_team, 2) + 1);
					TeamScoreList.replaceEntryByIndex(%j, %_team);
					break;
				}
			}
		}
	}

	scoreListUpdate();
}

function clientCmdScoreListTeamUpdate(%name, %score, %number, %color) {
	%lookup = TeamScoreList.team[%number];
	%players = getRecord(TeamScoreList.getEntry(%lookup), 2);
	TeamScoreList.replaceEntryByIndex(%lookup, %name NL %score NL %players NL %number NL %color);
}

function clientCmdScoreListTeamPlayerUpdate(%team, %name, %score, %index, %marble, %gems) {
	%lookup = TeamScorePlayerList.player[%index];
	TeamScorePlayerList.replaceEntryByIndex(%lookup, %team NL %name NL %score NL %index NL %marble NL %gems NL %bonus);
	scoreListUpdate();
}

// When the server owner starts a new level

function clientCmdServerLoading() {
	if (!$Server::Hosting)
		LBMessage("Waiting for Server...");
}

//-----------------------------------------------------------------------------

function scoreListUpdate() {
	%snow = $Game::isMode["snowball"];
	%spooky = $Game::isMode["spooky"];

	%platinumLabel = (%spooky ? "Spooky" : (%snow ? "Chilly" : "Platinum"));
	%ultimateLabel = (%spooky ? "Scary"  : (%snow ? "Frozen" : "Ultimate"));

	%platinumColor = (%spooky ? "FF8000" : (%snow ? "EEEEEE" : "CCCCCC"));
	%ultimateColor = (%spooky ? "CC2222" : (%snow ? "22CCFF" : "FFCC22"));

	$MP::ScoreUpdate ++;

	%color[1] = "<color:CFB52B>";
	%color[2] = "<color:CDCDCD>";
	%color[3] = "<color:D19275>";

	%shadow = "<shadowcolor:ffffff7f><shadow:1:1>";
	%pgshadow = "<shadowcolor:0000007f><shadow:1:1>";
	//<shadow:1:1><shadowcolor:776622ff>

	%show10 = false;
	%players = $MP::ScorePlayers;

	%timeScores = ClientMode::callback("shouldUseTimeScoreboard", false);

	if (!$MP::TeamMode) {
		for (%j = 0; %j < %players; %j ++) {
			%gems   = ScoreList.getEntry(%j).gems;
			%gems10 = mFloor(getWord(%gems, 3));

			if (%gems10 > 0) {
				%show10 = true;
				break;
			}
		}
	} else {
		for (%j = 0; %j < %players; %j ++) {
			%gems   = getRecord(TeamScorePlayerList.getEntry(%j), 5);
			%gems10 = mFloor(getWord(%gems, 3));

			if (%gems10 > 0) {
				%show10 = true;
				break;
			}
		}
	}

//	echo("Showing 10:" SPC %show10);

	MPScoreRedGem.resize((%show10 ? 398 : 408), -5, 64, 64);
	MPScoreYellowGem.resize((%show10 ? 440 : 460), -5, 64, 64);
	MPScoreBlueGem.resize((%show10 ? 482 : 512), -5, 64, 64);
	MPScorePlatinumGem.resize((%show10 ? 524 : 564), -5, 64, 64);

	if (%timeScores) {
		PGScoreListContainer.setExtent("400 500");
		MPScoreRedGem.setVisible(false);
		MPScoreYellowGem.setVisible(false);
		MPScoreBlueGem.setVisible(false);
		MPScorePlatinumGem.setVisible(false);
	} else {
		PGScoreListContainer.setExtent("300 500");
		MPScoreRedGem.setVisible(true);
		MPScoreYellowGem.setVisible(true);
		MPScoreBlueGem.setVisible(true);
		MPScorePlatinumGem.setVisible(%show10);
	}

	if ($MP::TeamMode) {
		%teams = $MP::ScoreTeams;
		%face     = "<font:28>";
		%format   = %shadow @ "<color:ffffff>";
		%font     = %face @ %format @ "<tab:40,350><bold>";
		%font2    = %face @ %format @ "<color:ffffff><font:28><tab:310><bold>";
		%pgface   = "<font:28>";
		%pgformat = %pgshadow @ "<color:000000>";
		%pgfont   = %pgface @ %pgformat @ "<color:ffee99><tab:25,350><bold>";
		%pgfont2  = %pgface @ %pgformat @ "<color:ffee99><tab:310><bold>";
		%rowIdx   = 0;
		%teamIdx  = 0;

		// Sort it!
		%used = Array(ScoresUsedPlayersArray);
		for (%i = 0; %i < %teams; %i ++) {
			if (%timeScores) {
				%bestScore = 6000001;
			} else {
				%bestScore = -9999;
			}
			%bestIdx = -9999;
			for (%j = 0; %j < %teams; %j ++) {
				%team  = getRecord(TeamScoreList.getEntry(%j), 0);
				%score = getRecord(TeamScoreList.getEntry(%j), 1);
				if (%used.containsEntry(%team))
					continue;
				if (%timeScores) {
					if (%score < %bestScore) {
						%bestScore = %score;
						%bestIdx = %j;
					} else
						continue;
				} else {
					if (%score > %bestScore) {
						%bestScore = %score;
						%bestIdx = %j;
					} else
						continue;
				}
			}

			%team    = getRecord(TeamScoreList.getEntry(%bestIdx), 0);
			%score   = getRecord(TeamScoreList.getEntry(%bestIdx), 1);
			%players = getRecord(TeamScoreList.getEntry(%bestIdx), 2);
			%number  = getRecord(TeamScoreList.getEntry(%bestIdx), 3);
			%color   = getRecord(TeamScoreList.getEntry(%bestIdx), 4);

			if (%timeScores)
				%score = (%score > 5999999 ? ($Client::GameRunning || $Game::Pregame ? "" : "N/A") : formatTime(%score));

			%used.addEntry(%team);

			// Don't show teams with no players
			if (%players == 0)
				continue;

			%teamIdx ++;

			// Size of score rows
			%itemHeight   = 44;
			%pgitemHeight = 32;

			// Add the display for the team
			if ($MP::ScoreListTeamIndex[%team] $= "" || !isObject(MPScoreContainerTeam @ %number)) {
				// Set these for reference
				$MP::ScoreListTeamIndex[%team]    = %number;
				$MP::ScoreListTeamLookup[%number] = %team;

				// Score list text and object
				MPScoreListContainer.add(
				new GuiControl(MPScoreContainerTeam @ %number) {
					profile = "GuiMLTextProfile";
					position = "0 0";
					extent = 500 SPC %itemHeight;
					visible = "1";

					new GuiMLTextCtrl(MPScoreTextTeam @ %number) {
						profile = "GuiMLTextProfile";
						position = "8 3";
						extent = "430 14";
						visible = "1";
						lineSpacing = "2";
						maxChars = "-1";
					};
				}
				);
				// Score list text and object
				PGScoreListContainer.add(
				new GuiControl(PGScoreContainerTeam @ %number) {
					profile = "GuiMLTextProfile";
					position = "0 0";
					extent = 300 SPC %itemHeight;
					visible = "1";

					new GuiMLTextCtrl(PGScoreTextTeam @ %number) {
						profile = "GuiMLTextProfile";
						position = "8 3";
						extent = "235 14";
						visible = "1";
						lineSpacing = "2";
						maxChars = "-1";
						noInvert = true;
					};
				}
				);
			}

			// At this point, they should have a display entry. Set it up!
			%scoreText   = "MPScoreTextTeam"      @ %number;
			%container   = "MPScoreContainerTeam" @ %number;
			%pgscoreText = "PGScoreTextTeam"      @ %number;
			%pgcontainer = "PGScoreContainerTeam" @ %number;

			// Resize these to be at the correct position
			//                  x  y                        w    h
			%container.resize(0, %rowIdx * %itemHeight,   500, %itemHeight);
			%pgcontainer.resize(0, %rowIdx * %pgitemHeight, 300, %itemHeight);

			if (%timeScores) {
				%pgcontainer.resize(0, %rowIdx * %pgitemHeight, 400, %itemHeight);
				%pgscoreText.setExtent("335 14");
			} else {
				%pgscoreText.setExtent("235 14");
			}

			%container.team = %team;
			%pgcontainer.team = %team;

			// Total row counter
			%rowIdx ++;

			%nameWidth = 210 - (15 * strlen(%score));

			%color = "<color:" @ getTeamColor(%color) @ ">";
			%scoreText.setText(%font   @ %teamIdx @ "." TAB clipPx($DefaultFont, 28, %team, 300, true) TAB %score);
			%pgscoreText.setText(%pgfont @ %color[%teamIdx] @ %teamIdx @ "." TAB %color @ clipPx($DefaultFont, 28, %team, %nameWidth, true) @ %color[%teamIdx] @ "<just:right>" @ %face @ %score);

			%container.lastUpdate   = $MP::ScoreUpdate;
			%pgcontainer.lastUpdate = $MP::ScoreUpdate;

			// Go through the players and add those on the team
			%teamPlayers = Array(TeamUsedPlayersArray);
			%players = $MP::ScorePlayers;

			for (%j = 0; %j < %players; %j ++) {
				%player = TeamScorePlayerList.getEntry(%j);
				if (getRecord(%player, 0) $= %team)
					%teamPlayers.addEntry(%player);
			}

			%usedPlayers = Array(TeamsUsedPlayersArray);
			%teamPlayerCount = %teamPlayers.getSize();

			// Organize team players by score
			for (%j = 0; %j < %teamPlayerCount; %j ++) {
				if (%timeScores) {
					%bestScore = 6000001;
				} else {
					%bestScore = -9999;
				}
				%bestIdx = -1;
				for (%k = 0; %k < %teamPlayerCount; %k ++) {
					%player = getRecord(%teamPlayers.getEntry(%k), 1);
					%score  = getRecord(%teamPlayers.getEntry(%k), 2);
					if (%usedPlayers.containsEntry(%player))
						continue;
					if (%timeScores) {
						if (%score < %bestScore) {
							%bestScore = %score;
							%bestIdx = %j;
						} else
							continue;
					} else {
						if (%score > %bestScore) {
							%bestScore = %score;
							%bestIdx = %j;
						} else
							continue;
					}
				}

				%player = getRecord(%teamPlayers.getEntry(%bestIdx), 1);
				%score  = getRecord(%teamPlayers.getEntry(%bestIdx), 2);
				%index  = getRecord(%teamPlayers.getEntry(%bestIdx), 3);
				%marble = getRecord(%teamPlayers.getEntry(%bestIdx), 4);
				%gems   = getRecord(%teamPlayers.getEntry(%bestIdx), 5);
				%state  = PlayerList.getEntryByVariable("name", %player).specState;
				%ping   = PlayerList.getEntryByVariable("name", %player).ping;

				if (%timeScores)
					%score = (%score > 5999999 ? ($Client::GameRunning || $Game::Pregame ? "" : "N/A") : formatTime(%score));

				// Add the display for the player
				if ($MP::ScoreListIndex[%player] $= "" || !isObject(MPScoreContainer @ %index)) {
					// Set these for reference
					$MP::ScoreListIndex[%player] = %index;
					$MP::ScoreListLookup[%index] = %player;

					// Score list text and object
					MPScoreListContainer.add(
					new GuiControl(MPScoreContainer @ %index) {
						profile = "GuiMLTextProfile";
						position = "0 0";
						extent = 630 SPC %itemHeight;
						visible = "1";

						new GuiMLTextCtrl(MPScoreText @ %index) {
							profile = "GuiMLTextProfile";
							position = "8 3";
							extent = "438 14";
							visible = "1";
							lineSpacing = "2";
							maxChars = "-1";
						};
						new GuiMLTextCtrl(MPScoreTextR @ %index) {
							profile = "GuiMLTextProfile";
							position = "409 3";
							extent = "52 14";
							visible = "1";
							lineSpacing = "2";
							maxChars = "-1";
						};
						new GuiMLTextCtrl(MPScoreTextY @ %index) {
							profile = "GuiMLTextProfile";
							position = "461 3";
							extent = "52 14";
							visible = "1";
							lineSpacing = "2";
							maxChars = "-1";
						};
						new GuiMLTextCtrl(MPScoreTextB @ %index) {
							profile = "GuiMLTextProfile";
							position = "513 3";
							extent = "52 14";
							visible = "1";
							lineSpacing = "2";
							maxChars = "-1";
						};
						new GuiMLTextCtrl(MPScoreTextP @ %index) {
							profile = "GuiMLTextProfile";
							position = "565 3";
							extent = "52 14";
							visible = "1";
							lineSpacing = "2";
							maxChars = "-1";
						};
						new GuiObjectView(MPPlayerMarble @ %index) {
							profile = "GuiDefaultProfile";
							position = "562 -10";
							extent = "64 64";
							visible = "1";
							model = $usermods @ "/data/shapes/balls/ball-superball.dts";
							skin = "base";
							cameraZRotSpeed = "0.001";
							orbitDistance = "0.75";
						};
					}
					);
					// Score list text and object
					PGScoreListContainer.add(
					new GuiControl(PGScoreContainer @ %index) {
						profile = "GuiMLTextProfile";
						position = "0 0";
						extent = 300 SPC %pgitemHeight;
						visible = "1";

						new GuiMLTextCtrl(PGScoreText @ %index) {
							profile = "GuiMLTextProfile";
							position = "33 3";
							extent = "210 14";
							visible = "1";
							lineSpacing = "2";
							maxChars = "-1";
							noInvert = true;
						};
						new GuiObjectView(PGPlayerMarble @ %index) {
							profile = "GuiDefaultProfile";
							position = "260 -2";
							extent = "48 48";
							visible = "1";
							model = $usermods @ "/data/shapes/balls/ball-superball.dts";
							skin = "base";
							cameraZRotSpeed = "0.001";
							orbitDistance = "0.75";
						};
						new GuiBitmapCtrl(PGPlayerPing @ %index) {
							profile = "GuiMLTextProfile";
							position = "239 4";
							extent = "32 32";
							visible = "1";
							lineSpacing = "2";
							maxChars = "-1";
						};
					}
					);
				}

				// At this point, they should have a display entry. Set it up!
				%scoreText    = "MPScoreText"      @ %index;
				%objectView   = "MPPlayerMarble"   @ %index;
				%container    = "MPScoreContainer" @ %index;
				//%pingctrl     = "MPPlayerPing"     @ %index;
				%pgscoreText  = "PGScoreText"      @ %index;
				%pgobjectView = "PGPlayerMarble"   @ %index;
				%pgcontainer  = "PGScoreContainer" @ %index;
				%pgpingctrl   = "PGPlayerPing"     @ %index;
				%scoreTextR   = "MPScoreTextR"     @ %index;
				%scoreTextY   = "MPScoreTextY"     @ %index;
				%scoreTextB   = "MPScoreTextB"     @ %index;
				%scoreTextP   = "MPScoreTextP"     @ %index;

				// Resize these to be at the correct position
				//                  x  y                        w    h
				%container.resize(0, %rowIdx * %itemHeight,   630, %itemHeight);
				%pgcontainer.resize(0, %rowIdx * %pgitemHeight, 300, %itemHeight);
				%container.player   = %player;
				%pgcontainer.player = %player;

				%scoreTextR.resize((%show10 ? 399 : 409), 3, 52, 14);
				%scoreTextY.resize((%show10 ? 441 : 461), 3, 52, 14);
				%scoreTextB.resize((%show10 ? 483 : 513), 3, 52, 14);
				%scoreTextP.resize((%show10 ? 525 : 565), 3, 52, 14);

				%scoreTextP.setVisible(%show10);

			if (%timeScores) {
				%pgcontainer.resize(0, %rowIdx * %pgitemHeight, 400, %itemHeight);
				%pgscoreText.setExtent("310 14");
				%pgobjectView.setPosition("360 -2");
				%pgpingctrl.setPosition("339 4");
				%scoreTextR.setVisible(false);
				%scoreTextY.setVisible(false);
				%scoreTextB.setVisible(false);
				%scoreTextP.setVisible(false);
			} else {
				%pgscoreText.setExtent("210 14");
				%pgobjectView.setPosition("260 -2");
				%pgpingctrl.setPosition("239 4");
				%scoreTextR.setVisible(true);
				%scoreTextY.setVisible(true);
				%scoreTextB.setVisible(true);
				%scoreTextP.setVisible(true);
			}

				// Total row counter
				%rowIdx ++;

				%bitmap = "unknown";
				if (%ping < 100) %bitmap = "high";
				else if (%ping < 250) %bitmap = "medium";
				else if (%ping < 500) %bitmap = "low";
				else if (%ping < 1000) %bitmap = "matanny";
				%pgpingctrl.setBitmap($usermods @ "/client/ui/lb/play/connection-" @ %bitmap @ ".png");
				//%pingctrl.setBitmap($usermods @ "/client/ui/lb/play/connection-" @ %bitmap @ ".png");

				%gems1     = mFloor(getWord(%gems, 0));
				%gems2     = mFloor(getWord(%gems, 1));
				%gems5     = mFloor(getWord(%gems, 2));
				%gems10    = mFloor(getWord(%gems, 3));

				%gems1  = %gems1  $= "" || %gems1  == 0 ? "0" : %gems1;
				%gems2  = %gems2  $= "" || %gems2  == 0 ? "0" : %gems2;
				%gems5  = %gems5  $= "" || %gems5  == 0 ? "0" : %gems5;
				%gems10 = %gems10 $= "" || %gems10 == 0 ? "0" : %gems10;

				if (%gems1  < 10) %gems1  = " " @ %gems1  $= "" ? "0" : %gems1;
				if (%gems2  < 10) %gems2  = " " @ %gems2  $= "" ? "0" : %gems2;
				if (%gems5  < 10) %gems5  = " " @ %gems5  $= "" ? "0" : %gems5;
				if (%gems10 < 10) %gems10 = " " @ %gems10 $= "" ? "0" : %gems10;

				%prefix = "";
				if (%state $= "0") %prefix = "[DC] ";
				if (%state $= "2") %prefix = "[S] ";

				%scoreText.setText(%font2   @ clipPx($DefaultFont, 28, LBResolveName(%player, true), 300, true) TAB %face @ %score);
				%pgscoreText.setText(%pgfont2 @ "<spush>" @ %color @ clipPx($DefaultFont, 28, %prefix @ LBResolveName(%player, true), 170, true) @ "<spop><just:right>" @ %pgface @ %score);

				%gems1  = "<spush><color:FF0000>" @ %scoreColor @ %gems1  @ "<spop>";
				%gems2  = "<spush><color:FFFF00>" @ %scoreColor @ %gems2  @ "<spop>";
				%gems5  = "<spush><color:4040FF>" @ %scoreColor @ %gems5  @ "<spop>";
				%gems10 = "<spush><color:CCCCCC>" @ %scoreColor @ %gems10 @ "<spop>";

				%scoreText.setText(%font TAB clipPx($DefaultFont, 28, LBResolveName(%player, true), 230, true) TAB %face @ %score TAB (%rating == -1 ? "N/A" : %rating SPC %change));
				%scoreTextR.setText(%face @ "<just:center>" @ %gems1);
				%scoreTextY.setText(%face @ "<just:center>" @ %gems2);
				%scoreTextB.setText(%face @ "<just:center>" @ %gems5);
				%scoreTextP.setText(%face @ "<just:center>" @ %gems10);

				// Shape and skin for the marble
				%shape = getField(%marble, 0);
				%skin  = getField(%marble, 1);
				if (!isFile(%shape)) {
					%shape = $usermods @ "/data/shapes/balls/ball-superball.dts";
					%skin = "base";
				}
				%objectView.setModel(%shape, %skin);
				%pgobjectView.setModel(%shape, %skin);

				// Set fields so they don't reset when we pop the gui
				%objectView.model   = %shape;
				%objectView.skin    = %skin;
				%pgobjectView.model = %shape;
				%pgobjectView.skin  = %skin;

				%container.lastUpdate   = $MP::ScoreUpdate;
				%pgcontainer.lastUpdate = $MP::ScoreUpdate;

				%usedPlayers.addEntry(%player);
			}

			%usedPlayers.delete();
			%teamPlayers.delete();
		}
		%used.delete();

		%count = MPScoreListContainer.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%obj = MPScoreListContainer.getObject(%i);
			if ((%obj.team !$= "" && !TeamScoreList.containsEntryAtRecord(%obj.team, 0)) || (%obj.player !$= "" && !TeamScorePlayerList.containsEntryAtRecord(%obj.player, 1)) || %obj.lastUpdate != $MP::ScoreUpdate) {
				// Player/team no longer exists!
				%obj.delete();
				%i --;
				%count --;
			}
		}
		%count = PGScoreListContainer.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%obj = PGScoreListContainer.getObject(%i);
			if ((%obj.team !$= "" && !TeamScoreList.containsEntryAtRecord(%obj.team, 0)) || (%obj.player !$= "" && !TeamScorePlayerList.containsEntryAtRecord(%obj.player, 1)) || %obj.lastUpdate != $MP::ScoreUpdate) {
				// Player/team no longer exists!
				%obj.delete();
				%i --;
				%count --;
			}
		}
	} else {
		%face   = "<font:28>";
		%font   = %face @ "<color:ffffff><tab:40,320><bold>";
		%pgface  = "<font:28>";
		%pgfont = %pgshadow @ "<color:ffee99><bold:28>";
		%pgwinfont = %pgshadow @ "<color:88ffcc><bold:28>";
		%players = $MP::ScorePlayers;
		%rowIdx = 0;

		// Sort it!
		%used = Array(ScoresUsedPlayersArray);
		for (%i = 0; %i < %players; %i ++) {
			if (%timeScores) {
				%bestScore = 6000001;
			} else {
				%bestScore = -9999;
			}
			%bestIdx = -1;
			for (%j = 0; %j < %players; %j ++) {
				%player = ScoreList.getEntry(%j).name;
				%score  = ScoreList.getEntry(%j).score;
				if (%used.containsEntry(%player))
					continue;
				if (%timeScores) {
					if (%score < %bestScore) {
						%bestScore = %score;
						%bestIdx = %j;
					} else
						continue;
				} else {
					if (%score > %bestScore) {
						%bestScore = %score;
						%bestIdx = %j;
					} else
						continue;
				}
			}

			%player = ScoreList.getEntry(%bestIdx).name;
			%score  = ScoreList.getEntry(%bestIdx).score;
			%index  = ScoreList.getEntry(%bestIdx).index;
			%marble = ScoreList.getEntry(%bestIdx).skin;
			%gems   = ScoreList.getEntry(%bestIdx).gems;
			%state  = isObject(PlayerList) ? PlayerList.getEntryByVariable("name", %player).specState : 0;
			%ping   = isObject(PlayerList) ? PlayerList.getEntryByVariable("name", %player).ping : 0;

			if (%timeScores)
				%score = (%score > 5999999 ? ($Client::GameRunning || $Game::Pregame ? "" : "N/A") : formatTime(%score));

			// Size of score rows
			%itemHeight   = 44;
			%pgitemHeight = 32;

			// Add the display for the player
			if ($MP::ScoreListIndex[%player] $= "" || !isObject(MPScoreContainer @ %index)) {
				// Set these for reference
				$MP::ScoreListIndex[%player] = %index;
				$MP::ScoreListLookup[%index] = %player;

				// Score list text and object
				MPScoreListContainer.add(
				new GuiControl(MPScoreContainer @ %index) {
					profile = "GuiMLTextProfile";
					position = "0 0";
					extent = 630 SPC %itemHeight;
					visible = "1";

					new GuiMLTextCtrl(MPScoreText @ %index) {
						profile = "GuiMLTextProfile";
						position = "8 3";
						extent = "438 14";
						visible = "1";
						lineSpacing = "2";
						maxChars = "-1";
					};
					new GuiMLTextCtrl(MPScoreTextR @ %index) {
						profile = "GuiMLTextProfile";
						position = "409 3";
						extent = "52 14";
						visible = "1";
						lineSpacing = "2";
						maxChars = "-1";
					};
					new GuiMLTextCtrl(MPScoreTextY @ %index) {
						profile = "GuiMLTextProfile";
						position = "461 3";
						extent = "52 14";
						visible = "1";
						lineSpacing = "2";
						maxChars = "-1";
					};
					new GuiMLTextCtrl(MPScoreTextB @ %index) {
						profile = "GuiMLTextProfile";
						position = "513 3";
						extent = "52 14";
						visible = "1";
						lineSpacing = "2";
						maxChars = "-1";
					};
					new GuiMLTextCtrl(MPScoreTextP @ %index) {
						profile = "GuiMLTextProfile";
						position = "565 3";
						extent = "52 14";
						visible = "1";
						lineSpacing = "2";
						maxChars = "-1";
					};
					new GuiObjectView(MPPlayerMarble @ %index) {
						profile = "GuiDefaultProfile";
						position = "562 -10";
						extent = "64 64";
						visible = "1";
						model = $usermods @ "/data/shapes/balls/ball-superball.dts";
						skin = "base";
						cameraZRotSpeed = "0.001";
						orbitDistance = "0.75";
					};
				}
				);
				// Score list text and object
				PGScoreListContainer.add(
				new GuiControl(PGScoreContainer @ %index) {
					profile = "GuiMLTextProfile";
					position = "0 0";
					extent = 300 SPC %pgitemHeight;
					visible = "1";

					new GuiMLTextCtrl(PGScoreText @ %index) {
						profile = "GuiMLTextProfile";
						position = "8 3";
						extent = "235 14";
						visible = "1";
						lineSpacing = "2";
						maxChars = "-1";
					};
					new GuiObjectView(PGPlayerMarble @ %index) {
						profile = "GuiDefaultProfile";
						position = "260 -2";
						extent = "48 48";
						visible = "1";
						model = $usermods @ "/data/shapes/balls/ball-superball.dts";
						skin = "base";
						cameraZRotSpeed = "0.001";
						orbitDistance = "0.75";
					};
					new GuiBitmapCtrl(PGPlayerPing @ %index) {
						profile = "GuiMLTextProfile";
						position = "239 4";
						extent = "32 32";
						visible = "1";
						lineSpacing = "2";
						maxChars = "-1";
					};
				}
				);
			}

			// At this point, they should have a display entry. Set it up!
			%scoreText    = "MPScoreText"      @ %index;
			%objectView   = "MPPlayerMarble"   @ %index;
			%container    = "MPScoreContainer" @ %index;
			//%pingctrl     = "MPPlayerPing"   @ %index;
			%scoreTextR   = "MPScoreTextR"     @ %index;
			%scoreTextY   = "MPScoreTextY"     @ %index;
			%scoreTextB   = "MPScoreTextB"     @ %index;
			%scoreTextP   = "MPScoreTextP"     @ %index;

			%pgscoreText  = "PGScoreText"      @ %index;
			%pgobjectView = "PGPlayerMarble"   @ %index;
			%pgcontainer  = "PGScoreContainer" @ %index;
			%pgpingctrl   = "PGPlayerPing"     @ %index;

			// Resize these to be at the correct position
			//                  x  y                        w    h
			%container.resize(0, %rowIdx * %itemHeight,   630, %itemHeight);
			%pgcontainer.resize(0, %rowIdx * %pgitemHeight, 300, %itemHeight);
			%container.player   = %player;
			%pgcontainer.player = %player;

			%scoreTextR.resize((%show10 ? 399 : 409), 3, 52, 14);
			%scoreTextY.resize((%show10 ? 441 : 461), 3, 52, 14);
			%scoreTextB.resize((%show10 ? 483 : 513), 3, 52, 14);
			%scoreTextP.resize((%show10 ? 525 : 565), 3, 52, 14);

			%scoreTextP.setVisible(%show10);

			if (%timeScores) {
				%pgcontainer.resize(0, %rowIdx * %pgitemHeight, 400, %itemHeight);
				%pgscoreText.setExtent("335 14");
				%pgobjectView.setPosition("360 -2");
				%pgpingctrl.setPosition("339 4");
				%scoreTextR.setVisible(false);
				%scoreTextY.setVisible(false);
				%scoreTextB.setVisible(false);
				%scoreTextP.setVisible(false);
			} else {
				%pgscoreText.setExtent("235 14");
				%pgobjectView.setPosition("260 -2");
				%pgpingctrl.setPosition("239 4");
				%scoreTextR.setVisible(true);
				%scoreTextY.setVisible(true);
				%scoreTextB.setVisible(true);
				%scoreTextP.setVisible(true);
			}

			// Total row counter
			%rowIdx ++;

			%bitmap = "unknown";
			if (%ping < 100) %bitmap = "high";
			else if (%ping < 250) %bitmap = "medium";
			else if (%ping < 500) %bitmap = "low";
			else if (%ping < 1000) %bitmap = "matanny";
			%pgpingctrl.setBitmap($usermods @ "/client/ui/lb/play/connection-" @ %bitmap @ ".png");

			%estimated = mFloor(%score * (MissionInfo.time / max(1, MissionInfo.time - PlayGui.currentTime)));

			%gems1     = mFloor(getWord(%gems, 0));
			%gems2     = mFloor(getWord(%gems, 1));
			%gems5     = mFloor(getWord(%gems, 2));
			%gems10    = mFloor(getWord(%gems, 3));

			%gems1  = %gems1  $= "" || %gems1  == 0 ? "0" : %gems1;
			%gems2  = %gems2  $= "" || %gems2  == 0 ? "0" : %gems2;
			%gems5  = %gems5  $= "" || %gems5  == 0 ? "0" : %gems5;
			%gems10 = %gems10 $= "" || %gems10 == 0 ? "0" : %gems10;

			if (%gems1  < 10) %gems1  = " " @ %gems1  $= "" ? "0" : %gems1;
			if (%gems2  < 10) %gems2  = " " @ %gems2  $= "" ? "0" : %gems2;
			if (%gems5  < 10) %gems5  = " " @ %gems5  $= "" ? "0" : %gems5;
			if (%gems10 < 10) %gems10 = " " @ %gems10 $= "" ? "0" : %gems10;

			%prefix = "";
			if (%state $= "0") %prefix = "[DC] ";
			if (%state $= "2") %prefix = "[S] ";

			//See if we have more than one other player
			%vs = !$Server::Hosting //Not host, so there must be someone else who is
				|| (!$Server::_Dedicated && ClientGroup.getCount() > 1) //Hosting local, another player
				|| ($Server::_Dedicated && isObject(ScoreList.player[1])); //Hosting dedicated, hack but should work
			%scoreIdx = (%vs ? 0 : 1);

			%nameWidth = (%timeScores ? 330 : 200) - (15 * strlen(%score));

			%scoreText.setText(%font @ %rowIdx @ "." TAB clipPx($DefaultFont, 28, LBResolveName(%player, true), 280, true) TAB %face @ %score);
			%pgscoreText.setText(%pgfont @ %color[%rowIdx] @ %rowIdx @ "." SPC clipPx($DefaultFont, 28, %prefix @ LBResolveName(%player, true), %nameWidth, true) @ "<just:right>" @ %pgface @ %score);

			%gems1  = "<spush><color:FF0000>" @ %scoreColor @ %gems1  @ "<spop>";
			%gems2  = "<spush><color:FFFF00>" @ %scoreColor @ %gems2  @ "<spop>";
			%gems5  = "<spush><color:4040FF>" @ %scoreColor @ %gems5  @ "<spop>";
			%gems10 = "<spush><color:CCCCCC>" @ %scoreColor @ %gems10 @ "<spop>";

			%scoreTextR.setText(%face @ "<just:center>" @ %gems1);
			%scoreTextY.setText(%face @ "<just:center>" @ %gems2);
			%scoreTextB.setText(%face @ "<just:center>" @ %gems5);
			%scoreTextP.setText(%face @ "<just:center>" @ %gems10);

			// Shape and skin for the marble
			%shape = getField(%marble, 0);
			%skin  = getField(%marble, 1);
			if (!isFile(%shape)) {
				%shape = $usermods @ "/data/shapes/balls/ball-superball.dts";
				%skin = "base";
			}
			%objectView.setModel(%shape, %skin);
			%pgobjectView.setModel(%shape, %skin);

			// Set fields so they don't reset when we pop the gui
			%objectView.model   = %shape;
			%objectView.skin    = %skin;
			%pgobjectView.model = %shape;
			%pgobjectView.skin  = %skin;

			%container.lastUpdate   = $MP::ScoreUpdate;
			%pgcontainer.lastUpdate = $MP::ScoreUpdate;

			%used.addEntry(%player);
		}
		%used.delete();

		%count = MPScoreListContainer.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%obj = MPScoreListContainer.getObject(%i);
			if (!ScoreList.containsEntryAtVariable("name", %obj.player) || %obj.lastUpdate != $MP::ScoreUpdate) {
				// Player no longer exists!
				%obj.delete();
				%i --;
				%count --;
			}
		}
		%count = PGScoreListContainer.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%obj = PGScoreListContainer.getObject(%i);
			if (!ScoreList.containsEntryAtVariable("name", %obj.player) || %obj.lastUpdate != $MP::ScoreUpdate) {
				// Player no longer exists!
				%obj.delete();
				%i --;
				%count --;
			}
		}
	}

	MPScoreHeader.setText("<font:30><color:FFFFFF><tab:40,320> \tName\tScore<just:right>Marble");
	// display the result
}

function resetScoreList() {
	while (MPScoreListContainer.getCount()) {
		%obj = MPScoreListContainer.getObject(0);
		%obj.delete();
	}
	while (PGScoreListContainer.getCount()) {
		%obj = PGScoreListContainer.getObject(0);
		%obj.delete();
	}
}

//-----------------------------------------------------------------------------
// Master server ratings / scores / change

function clientCmdMasterScoreCount(%scores) {
	$MP::MasterScoreCount = %scores;
}

function clientCmdMasterScorePlayer(%id, %player) {
	$MP::MasterScorePlayer[%id] = %player;
	$MP::MasterScoreLookup[%player] = %id;
}

function clientCmdMasterScoreRating(%id, %rating) {
	$MP::MasterScoreRating[%id] = %rating;
}

function clientCmdMasterScoreChange(%id, %change) {
	$MP::MasterScoreChange[%id] = %change;
}

function clientCmdPlayerGemCount(%player, %gems1, %gems2, %gems5, %gems10) {
	$MP::PlayerGemCount[%player] = %gems1 TAB %gems2 TAB %gems5 TAB %gems10;
}

function clientCmdMasterScoreFinish() {
	MPEndGameDlg.updateScores();
}
