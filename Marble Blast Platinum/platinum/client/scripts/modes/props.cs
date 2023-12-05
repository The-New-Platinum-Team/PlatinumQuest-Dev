//-----------------------------------------------------------------------------
// Prop Hunt mode
//
// Originally created in 2015
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_props) {
	class = "ModeInfo_props";
	superclass = "ModeInfo";

	identifier = "props";
	file = "props";

	name = "Prop Hunt";
	desc = "Disguise yourself and try to evade detection!";
	complete = 1;
});


function ClientMode_props::onLoad(%this) {
	%this.registerCallback("onFrameAdvance");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("nametagDistance");
	%this.registerCallback("nametagRaycast");
	%this.registerCallback("disableBlastIndicator");
	%this.registercallback("shouldPickupItem");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("showSpectatorMenu");
	%this.registerCallback("shouldUpdateGems");
	%this.registerCallback("getDefaultScore");
	%this.registerCallback("radarShouldShowObject");
	%this.registerCallback("showEndGame");
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
}

if (!isObject(PropSet)) {
	RootGroup.add(new SimSet(PropSet));
}

function ClientMode_props::onFrameAdvance(%this, %delta) {
	//Update the prop positions
	for (%i = 0; %i < PropSet.getCount(); %i ++) {
		%prop = PropSet.getObject(%i);
		if (!isObject(%prop.player))
			return;

		//Set the item's position to the marble's position, rotated to gravity, and dropped at the ground.
		%gravity = %prop.player.getGravityRot();
		%trans = getWords(%prop.player.getTransform(), 0, 2) SPC %gravity;
		//Flip because gravity is inverse
		%trans = MatrixMultiply(%trans, "0 0 0 1 0 0 3.14159");
		//Put the prop inside the marble
		%add = MatrixMulPoint("0 0 0" SPC %gravity, "0 0" SPC %prop.player.getCollisionRadius());
		%trans = VectorAdd(MatrixPos(%trans), %add) SPC getWords(%trans, 3, 6);
		//Calculate the z-drop if needed
		if (%prop.zdrop $= "") {
			//Normalize position and rotation
			%prop.setTransform("0 0 0 1 0 0 0");
			%prop.zdrop = VectorSub(%prop.getPosition(), getWords(%prop.getWorldBoxCenter(), 0, 1) SPC getWord(%prop.getWorldBox(), 2));
		}

		%trans = MatrixMultiply(%trans, %prop.zdrop SPC "1 0 0 0");
		if (%prop.getClassName() $= "Item") {
			//Simulate item rotation because constant setTransform() breaks the engine rotation.
			//Period = 1 full turn / 3 seconds (hardcoded in engine)
			//Always on Z axis too
			%trans = MatrixMultiply(%trans, "0 0 0 0 0 1" SPC($Sim::Time * ($pi * 2) / 3));
		}
		%prop.setTransform(%trans);

		//Update any particle emitters
		for (%i = 0; %i < %prop.fxCount; %i ++) {
			%fx = %prop.fx[%i];
			%fx.setTransform(vectorAdd(%prop.getWorldBoxCenter(), "0 0 0.05") SPC %prop.getRotation());
			%fx.inspectPostApply();
		}
	}
}

function ClientMode_props::onMissionReset(%this) {
	clientCmdSeekGracePeriod();
	PropGui.enablePropGui(false);
	PropGui.currentGame = "";
	PropGui.currentCategory = "";
	//PropSet.clear();
}

//--------------------------------------------------------------------------

function ClientMode_props::timeMultiplier(%this) {
	return -1;
}
function ClientMode_props::onEndGameSetup(%this) {
	PropGui.enablePropGui(false);
	PlayGui.stopTimer();
}
function ClientMode_props::nametagDistance(%this) {
	return false;
}
function ClientMode_props::nametagRaycast(%this) {
	return false;
}
function ClientMode_props::disableBlastIndicator(%this) {
	return true;
}
function ClientMode_props::shouldPickupItem(%this, %object) {
	if (%object.this.prop)
		return false;
	if ($powerupLocked)
		return false;
	return isClientSidedItem(%object.this);
}
function ClientMode_props::onDeactivate(%this) {
	PropGui.enablePropGui(false);
}
function ClientMode_props::showSpectatorMenu(%this, %object) {
	if ($SpectateMode || !isObject($MP::MyMarble.prop))
		return true;
	PG_SpectatorText.setText("<bold:28><just:center>Prop Hunt Commands<font:14>\n" NL "<bold:22><just:left>Toggle Prop Selector:<just:right><func:bind inputEnablePropGui>" NL "<just:left>Freeze Prop:<just:right><func:bind freezeProp>");
	PG_SpectatorMenu.setVisible(true);
	return false;
}

//--------------------------------------------------------------------------

function ClientMode_props::shouldUpdateGems(%this) {
	//Borrowed from hunt.cs
	PG_GemCounter.setVisible(false);
	PG_HuntCounter.setVisible(true);

	%count = PlayGui.gemCount;
	%max = PlayGui.maxGems;

	%one = %count % 10;
	%ten = ((%count - %one) / 10) % 10;
	%hundred = ((%count - %one - (%ten * 10)) / 100) % 10;
	%thousand = ((%count - %one - (%ten * 10) - (%hundred * 100)) / 1000) % 10;

	%color = ($Server::ServerType $= "Multiplayer" && PlayGui.gemGreen) ? $TimeColor["stopped"] : $TimeColor["normal"];

	HuntGemsFoundOne.setVisible(true);
	HuntGemsFoundTen.setVisible(true);
	HuntGemsFoundHundred.setVisible(true);
	HuntGemsFoundThousand.setVisible(true);

	if (%count < 10) {
		HuntGemsFoundTen.setVisible(false);
		HuntGemsFoundHundred.setVisible(false);
		HuntGemsFoundThousand.setVisible(false);

		HuntGemsFoundOne.setNumberColor(%one, %color);
	} else if (%count < 100) {
		HuntGemsFoundHundred.setVisible(false);
		HuntGemsFoundThousand.setVisible(false);

		HuntGemsFoundOne.setNumberColor(%one, %color);
		HuntGemsFoundTen.setNumberColor(%ten, %color);
	} else if (%count < 1000) {
		HuntGemsFoundThousand.setVisible(false);

		HuntGemsFoundOne.setNumberColor(%one, %color);
		HuntGemsFoundTen.setNumberColor(%ten, %color);
		HuntGemsFoundHundred.setNumberColor(%hundred, %color);
	} else {
		HuntGemsFoundOne.setNumberColor(%one, %color);
		HuntGemsFoundTen.setNumberColor(%ten, %color);
		HuntGemsFoundHundred.setNumberColor(%hundred, %color);
		HuntGemsFoundThousand.setNumberColor(%thousand, %color);
	}
	return false;
}
function ClientMode_props::getDefaultScore(%this) {
	return $ScoreType::Score TAB 0 TAB "Matan W.";
}

//--------------------------------------------------------------------------

function ClientMode_props::radarShouldShowObject(%this, %object) {
	//Disable radar
	return false;
}

function DetectProp(%prop, %playerID) {
	if ($Server::Lobby)
		return;
	%player = getClientSyncObject(%playerID);
	if (isObject(%prop) && isObject(%player)) {
		PropSet.add(%prop);
		%prop.player = %player;
		%player.prop = %prop;
		%prop.prop = true;
		%prop.fxCount = 0;
	}
}

function DetectPropFX(%fx, %propID) {
	if ($Server::Lobby)
		return;
	%prop = getClientSyncObject(%propID);
	if (isObject(%prop) && isObject(%fx)) {
		%prop.fx[%prop.fxCount] = %fx;
		%prop.fxCount ++;
	}
}

function clientCmdPropEliminated(%transform) {
	getCamera().setTransform(%transform);
	PropGui.enablePropGui(false);
}

function freezeProp(%val) {
	if (!$Game::isMode["props"])
		return;
	if (%val && isObject($MP::MyMarble.prop)) {
		//Only if they are touching the ground...
		%gravity = $MP::MyMarble.getGravityRot();
		%trans = MatrixMultiply(getWords($MP::MyMarble.getTransform(), 0, 2) SPC %gravity, "0 0 0 1 0 0 3.14159");
		%castDir = MatrixMulPoint("0 0 0" SPC %gravity, "0 0" SPC $MP::MyMarble.getCollisionRadius() + 0.01);
		if (!ClientContainerRayCast(MatrixPos(%trans), VectorAdd(MatrixPos(%trans), %castDir), $TypeMasks::InteriorObjectType | $TypeMasks::StaticShapeObjectType))
			return;

		//Freeze their velocity
		$MP::MyMarble.setVelocity("0 0 0");
		$MP::MyMarble.setAngularVelocity("0 0 0");
	}
}
setDefaultBind(keyboard, "alt z", freezeProp);

function clientCmdPushPropLayer() {
	Physics::pushLayerName(PropMarble);
}

function clientCmdClearPropLayer() {
	Physics::popLayerName(PropMarble);
}

Physics::registerLayer("PropMarble",
                       "maxRollVelocity 4.5 3.6" NL
                       "angularAcceleration 22.5 18" NL
                       "brakingAcceleration 20 16.67" NL
                       "airAcceleration 1 1" NL
                       "staticFriction 1.4 1.27" NL
                       "kineticFriction 0.95 1.09" NL
                       "bounceKineticFriction 0.04 0.06"
                      );

//--------------------------------------------------------------------------

if (!$Server::Dedicated) {
	new GuiControl(PropGui) {
		profile = "GuiDefaultProfile";
		horizSizing = "width";
		vertSizing = "height";
		position = "0 0";
		extent = "800 600";
		minExtent = "8 8";
		visible = "0";
		helpTag = "0";
		categories = "0";

		new GuiControl() {
			profile = "PQWindowProfile";
			horizSizing = "center";
			vertSizing = "center";
			position = "0 0";
			extent = "800 600";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";

			new GuiBorderButtonCtrl(Props_GameSelector) {
				profile = "PMDifficultyButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "586 -11";
				extent = "211 101";
				minExtent = "8 8";
				visible = "1";
				command = "PropGui.toggleGameSelector();";
				helpTag = "0";
				text = "Gold/Platinum";
				groupNum = "-1";
				buttonType = "ToggleButton";
				repeatPeriod = "1000";
				repeatDecay = "1";
			};
			new GuiBorderButtonCtrl(Props_CategorySelector) {
				profile = "PMDifficultyButtonProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "3 -11";
				extent = "211 101";
				minExtent = "8 8";
				visible = "1";
				command = "PropGui.toggleCategorySelector();";
				helpTag = "0";
				text = "Items";
				groupNum = "-1";
				buttonType = "ToggleButton";
				repeatPeriod = "1000";
				repeatDecay = "1";
			};
			new GuiMLTextCtrl(Props_TitleText) {
				profile = "GuiMLTextProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "197 24";
				extent = "211 101";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
				defaultText = "<bold:35><shadow:1:1><shadowcolor:000000bf><just:center>Select Prop";
			};
			new GuiScrollCtrl() {
				profile = "PQScrollProfile";
				horizSizing = "center";
				vertSizing = "height";
				position = "10 80";
				extent = "775 505";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				willFirstRespond = "1";
				hScrollBar = "alwaysOff";
				vScrollBar = "dynamic";
				constantThumbHeight = "0";
				childMargin = "0 0";

				new GuiControl(Props_Scroller) {
					profile = "GuiDefaultProfile";
					horizSizing = "center";
					vertSizing = "height";
					position = "10 80";
					extent = "775 505";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
				};
			};
			new GuiBitmapCtrl(Props_GameListBitmap) {
				profile = "GuiDefaultProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "602 60";
				extent = "178 105";
				minExtent = "8 8";
				visible = "0";
				helpTag = "0";
				bitmap = $userMods @ "/client/ui/lb/play/pc_trans/0";
				wrap = "0";

				new GuiControl(Props_GameList) {
					profile = "GuiDefaultProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "0 0";
					extent = "178 105";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";

					new GuiBitmapButtonTextCtrl(Props_GameButton0) {
						profile = "PMDifficultyButtonProfile";
						horizSizing = "left";
						vertSizing = "bottom";
						position = "0 0";
						extent = "178 35";
						minExtent = "8 8";
						visible = "1";
						helpTag = "0";
						text = "Gold/Platinum";
						command = "PropGui.setGame(0);";
						groupNum = "-1";
						buttonType = "PushButton";
						bitmap = $userMods @ "/client/ui/play/difficulty";
					};
					new GuiBitmapButtonTextCtrl(Props_GameButton1) {
						profile = "PMDifficultyButtonProfile";
						horizSizing = "left";
						vertSizing = "bottom";
						position = "0 35";
						extent = "178 35";
						minExtent = "8 8";
						visible = "1";
						helpTag = "0";
						text = "PlatinumQuest";
						command = "PropGui.setGame(1);";
						groupNum = "-1";
						buttonType = "PushButton";
						bitmap = $userMods @ "/client/ui/play/difficulty";
					};
					new GuiBitmapButtonTextCtrl(Props_GameButton2) {
						profile = "PMDifficultyButtonProfile";
						horizSizing = "left";
						vertSizing = "bottom";
						position = "0 70";
						extent = "178 35";
						minExtent = "8 8";
						visible = "1";
						helpTag = "0";
						text = "Ultra";
						command = "PropGui.setGame(2);";
						groupNum = "-1";
						buttonType = "PushButton";
						bitmap = $userMods @ "/client/ui/play/difficulty";
					};
				};
			};
			new GuiBitmapCtrl(Props_CategoryListBitmap) {
				profile = "GuiDefaultProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "19 60";
				extent = "178 105";
				minExtent = "8 8";
				visible = "0";
				helpTag = "0";
				bitmap = $userMods @ "/client/ui/lb/play/pc_trans/0";
				wrap = "0";

				new GuiControl(Props_CategoryList) {
					profile = "GuiDefaultProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "0 0";
					extent = "178 105";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
				};
			};
		};
	};
}

function PropGui::addCategory(%this, %name, %noTypes) {
	%this.category[%this.categories] = %name;
	%this.noTypes[%this.categories] = %noTypes;
	%this.propCount[%this.categories, 0] = 0;
	%this.propCount[%this.categories, 1] = 0;
	%this.propCount[%this.categories, 2] = 0;
	%this.categories ++;
}

function PropGui::addAllowedProp(%this, %name, %category, %datablock, %PQdatablock, %MBUdatablock) {
	devecho("[Mode Props]: Adding prop" SPC %name);

	if (%datablock !$= "") {
		%index = %this.propCount[%category, 0];
		%this.prop[%category, 0, %index] = %name;
		%this.propDB[%name, 0] = %datablock;
		%this.propCount[%category, 0] ++;
	}
	if (%PQdatablock !$= "") {
		%index = %this.propCount[%category, 1];
		%this.prop[%category, 1, %index] = %name;
		%this.propDB[%name, 1] = %PQdatablock;
		%this.propCount[%category, 1] ++;
	}
	if (%MBUdatablock !$= "") {
		%index = %this.propCount[%category, 2];
		%this.prop[%category, 2, %index] = %name;
		%this.propDB[%name, 2] = %MBUdatablock;
		%this.propCount[%category, 2] ++;
	}
}

function PropGui::onWake(%this) {
	if (!%this.done) {
		//Add all the categories
		%this.addCategory("Items");
		%this.addCategory("Special", 1);
		// %this.addCategory("Hazards");
		%this.buildCategoryList();

		//Add all the allowed props
		%this.addAllowedProp("Gem",               0,   "GemItem",             "GemItem_PQ",             "GemItem_MBU");
		%this.addAllowedProp("Fancy Gem",         0,   "",                    "FancyGemItem_PQ",        "");
		%this.addAllowedProp("Super Speed",       0,   "SuperSpeedItem",      "SuperSpeedItem_PQ",      "SuperSpeedItem_MBU");
		%this.addAllowedProp("Super Jump",        0,   "SuperJumpItem",       "SuperJumpItem_PQ",       "SuperJumpItem_MBU");
		%this.addAllowedProp("Gyrocopter",        0,   "HelicopterItem",      "HelicopterItem_PQ",      "HelicopterItem_MBU");
		%this.addAllowedProp("Shock Absorber",    0,   "ShockAbsorberItem",   "ShockAbsorberItem_PQ",   "");
		%this.addAllowedProp("Super Bounce",      0,   "SuperBounceItem",     "SuperBounceItem_PQ",     "");
		%this.addAllowedProp("Gravity Modifier",  0,   "AntiGravityItem",     "AntiGravityItem_PQ",     "AntiGravityItem_MBU");
		%this.addAllowedProp("Time Travel",       0,   "TimeTravelItem",      "TimeTravelItem_PQ",      "TimeTravelItem_MBU");
		%this.addAllowedProp("Time Penalty",      0,   "TimePenaltyItem",     "TimePenaltyItem_PQ",     "");
		%this.addAllowedProp("Mega Marble",       0,   "MegaMarbleItem",      "MegaMarbleItem",         "MegaMarbleItem_MBU");
		%this.addAllowedProp("Blast",             0,   "BlastItem",           "BlastItem",              "BlastItem_MBU");
		%this.addAllowedProp("Anvil",             0,   "",                    "AnvilItem",              "");
		%this.addAllowedProp("Teleporter",        0,   "",                    "TeleportItem",           "");
		%this.addAllowedProp("Bubble",            0,   "",                    "BubbleItem",             "");
		%this.addAllowedProp("Fireball",          0,   "",                    "FireballItem",           "");
		%this.addAllowedProp("Sundial",           0,   "",                    "SundialItem_PQ",         "");
		%this.addAllowedProp("Random Powerup",    0,   "RandomPowerUpItem",   "",                       "");

		%this.addAllowedProp("Marble Dummy",      1,   "DefaultMarble");
		%this.addAllowedProp("Party Hat",         1,   "PartyHatImage");
		%this.addAllowedProp("Red Candy",         1,   "CandyItemRed");
		%this.addAllowedProp("Yellow Candy",      1,   "CandyItemYellow");
		%this.addAllowedProp("Blue Candy",        1,   "CandyItemBlue");
		%this.addAllowedProp("Plant",             1,   "Plant01");
		%this.addAllowedProp("Tulip",             1,   "Tulip");

		//TODO: Hack physics to allow collision-less objects?
		// %this.addAllowedProp("Present",           1,   "GiftCrateNormalClosed");
		// %this.addAllowedProp("Bumper",            2,   "RoundBumper",         "RoundBumper_PQ",         "RoundBumper_MBU");
		// %this.addAllowedProp("Triangle Bumper",   2,   "TriangleBumper",      "TriangleBumper_PQ",      "");
		// %this.addAllowedProp("Mine",              2,   "LandMine",            "LandMine_PQ",            "LandMine_MBM");
		// %this.addAllowedProp("Nuke",              2,   "Nuke",                "Nuke_PQ",                "");
		// %this.addAllowedProp("Fan",               2,   "DuctFan",             "DuctFan_PQ",             "DuctFan_MBU");
		// %this.addAllowedProp("Tornado",           2,   "Tornado",             "Tornado_PQ",             "Tornado_MBM");
		// %this.addAllowedProp("Magnet",            2,   "Magnet",              "",                       "");
		// %this.addAllowedProp("Oil Slick",         2,   "oilslick",            "",                       "");
		// %this.addAllowedProp("Ice Shard",         2,   "",                    "IceShard1",              "");
		// %this.addAllowedProp("Ice Slick",         2,   "",                    "IceSlick3",              "");

		%this.done = true;
	}

	if (%this.currentGame $= "")
		%this.currentGame = (MissionInfo.game $= "PlatinumQuest" ? 1 : (MissionInfo.game $= "Ultra" ? 2 : 0));

	%this.buildPropList(%this.currentGame, %this.currentCategory);
}

function PropGui::buildPropList(%this, %game, %category) {
	if (%game $= "")
		%game = 0;
	if (%category $= "")
		%category = 0;

	if (%this.noTypes[%category]) {
		%game = 0;
		Props_GameSelector.setActive(0);
	} else {
		Props_GameSelector.setActive(1);
	}

	Props_Scroller.clear();
	Props_Scroller.setExtent("775" SPC mCeil(%this.propCount[%category, %game] * 0.25) * 190 - 25);
	Props_GameListBitmap.setVisible(false);
	%gameButton = "Props_GameButton" @ %game;
	Props_GameSelector.setText(!%this.noTypes[%category] ? %gameButton.text : "Misc.");
	Props_GameSelector.setValue(0);
	Props_CategoryListBitmap.setVisible(false);
	%categoryButton = "Props_CategoryButton" @ %category;
	Props_CategorySelector.setText(%categoryButton.text);
	Props_CategorySelector.setValue(0);


	//Build the prop list
	%row = 0;
	%column = 0;
	for (%i = 0; %i < %this.propCount[%category, %game]; %i ++) {
		%name = %this.prop[%category, %game, %i];
		%prop = %this.propDB[%name, %game];

		%button = new GuiControl(Props_Prop @ %i) {
			profile = "GuiDefaultProfile";
			horizSizing = "height";
			vertSizing = "height";
			position = 190 * %column SPC 190 * %row;
			extent = "190 190";
			visible = "1";

			new GuiMLTextCtrl(Props_PropText @ %i) {
				profile = "GuiMLTextProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "0 0";
				extent = "190 190";
				minExtent = "8 8";
				visible = "1";
				lineSpacing = "2";
				maxChars = "-1";
				noInvert = true;
				defaultText = %name;
			};
			new GuiObjectView(Props_PropObject @ %i) {
				profile = "GuiDefaultProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "0 0";
				extent = "190 190";
				minExtent = "8 8";
				visible = "1";
				model = %prop.shapeFile;
				skin = "base";
				forceFOV = "0";
				cameraRotX = "0";
				cameraZRotSpeed = "0.001";
				orbitDistance = "2.25";
			};

			new GuiButtonBaseCtrl(Props_PropButton @ %i) {
				profile = "GuiDefaultProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "0 0";
				extent = "190 190";
				minExtent = "8 8";
				visible = "1";
				command = "commandToServer(\'setProp\'," SPC %prop @ ");";
				helpTag = "0";
				groupNum = "-1";
				buttonType = "PushButton";
				text = "";
			};
		};
		%propText = "Props_PropText" @ %i;
		%propText.setText("<bold:28><just:center>" @ %name);

		//Change stuff if required
		%propObject = "Props_PropObject" @ %i;
		if (strStr(%prop, "GemItem") != -1) {
			%propObject.skin = $GemSkinColors[getRandom(1, 10)];
		} else if (strStr(%prop, "CandyItem") != -1) {
			%propObject.skin = (strStr(%prop, "Yellow") != -1 ? "orange" : (strStr(%prop, "Blue") != -1 ? "black" : "red"));
		} else if (%prop $= "TimePenaltyItem") {
			%propObject.skin = "penalty";
		} else if (%prop $= "Plant01") {
			%propObject.orbitDistance = "3";
		}
		// if (%category == 2)
		// 	%propObject.cameraRotX = "1";
		// if (%prop $= "IceShard1" || %prop $= "RoundBumper_MBU") {
		// 	%propObject.cameraRotX = "0";
		// } else if (%prop $= "Nuke_PQ") {
		// 	%propObject.skin = "nuke";
		// } else if (strStr(%prop, "Tornado") != -1) {
		// 	%propObject.orbitDistance = strStr(%prop, "_MBM") != -1 ? "42.5" : "12.75";
		// 	%propObject.cameraRotX = "0";
		// } else if (strStr(%prop, "DuctFan") != -1) {
		// 	%propObject.orbitDistance = strStr(%prop, "_MBU") != -1 ? "3.5" : "3";
		// } else if (%prop $= "TriangleBumper") {
		// 	%propObject.orbitDistance = "2.75";
		// } else if (%prop $= "oilslick" || %prop $= "IceSlick3") {
		// 	%propObject.orbitDistance = "6";
		// }

		Props_Scroller.add(%button);
		%column ++;
		if ((%i + 1) % 4 == 0) {
			%row ++;
			%column = 0;
		}
	}
}

function PropGui::buildCategoryList(%this) {
	%height = 35;
	%extent = %height * %this.categories;
	Props_CategoryList.setExtent("178" SPC %extent);
	Props_CategoryListBitmap.setExtent("178" SPC %extent);
	for (%i = 0; %i < %this.categories; %i ++) {
		Props_CategoryList.add(new GuiBitmapButtonTextCtrl(Props_CategoryButton @ %i) {
			profile = "PMDifficultyButtonProfile";
			horizSizing = "left";
			vertSizing = "bottom";
			position = "0" SPC %height * %i;
			extent = "178" SPC %height;
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
			text = %this.category[%i];
			command = "PropGui.setCategory(" @ %i @ ");";
			groupNum = "-1";
			buttonType = "PushButton";
			bitmap = $userMods @ "/client/ui/play/difficulty";
		});
	}
}

function PropGui::setGame(%this, %game) {
	%this.currentGame = %game;
	%this.buildPropList(%this.currentGame, %this.currentCategory);
}

function PropGui::setCategory(%this, %category) {
	%this.currentCategory = %category;
	%this.buildPropList(%this.currentGame, %this.currentCategory);
}

function PropGui::toggleGameSelector(%this) {
	%enable = !Props_GameListBitmap.isVisible();
	Props_GameListBitmap.setVisible(%enable);
	if (%enable) {
		Props_CategoryListBitmap.setVisible(false);
		Props_CategorySelector.setValue(0);
	}
}

function PropGui::toggleCategorySelector(%this) {
	%enable = !Props_CategoryListBitmap.isVisible();
	Props_CategoryListBitmap.setVisible(%enable);
	if (%enable) {
		Props_GameListBitmap.setVisible(false);
		Props_GameSelector.setValue(0);
	}
}

function PropGui::enablePropGui(%this, %enable) {
	if (%enable && isObject($MP::MyMarble.prop) && $Client::GameRunning && !$gamePaused) {
		RootGui.pushDialog(PropGui);
		PropGui.setVisible(true);
	} else {
		RootGui.popDialog(PropGui);
		PropGui.setVisible(false);
	}
}

function inputEnablePropGui(%val) {
	if (!$Game::isMode["props"])
		return;
	if (%val) {
		PropGui.enablePropGui(!PropGui.isVisible());
	}
}
setDefaultBind(keyboard, "[", inputEnablePropGui);

//--------------------------------------------------------------------------

function ClientMode_props::showEndGame(%this) {
	%this.onNextFrame(updatePropsEndGame);
	return false;
}

function ClientMode_props::updatePropsEndGame(%this) {
	if (!$Game::isMode["props"])
		return;
	//Prop Hunt end screen: Platinums = Props you found; Blues = Win as a prop
	MPEndGameRedGem.setVisible(false);
	MPEndGameYellowGem.setVisible(false);
	MPEndGameBlueGem.setVisible(false);
	MPEndGamePlatinumGem.setVisible(false);
	MPDualCategoryOne.setVisible(true);
	MPDualCategoryTwo.setVisible(true);
	MPDualCategoryOne.setText("<bold:30><just:center><color:4040FF>Prop\nWin");
	MPDualCategoryTwo.setText("<bold:30><just:center><color:CCCCCC>Props\nFound");

	%players = ($MP::TeamMode ? TeamScorePlayerList.getSize() : ScoreList.getSize());
	for (%i = 0; %i < %players; %i ++) {
		%index = ($MP::TeamMode ? getRecord(TeamScorePlayerList.getEntry(%i), 3) : ScoreList.getEntry(%i).index);
		%R = "MPEndTextR" @ %index;
		%Y = "MPEndTextY" @ %index;
		%B = "MPEndTextB" @ %index;
		%P = "MPEndTextP" @ %index;
		%R.setVisible(false);
		%Y.setVisible(false);
		%B.resize(369, 3, 52, 14);
		%P.setVisible(true);
		%P.resize(444, 3, 52, 14);
	}
}