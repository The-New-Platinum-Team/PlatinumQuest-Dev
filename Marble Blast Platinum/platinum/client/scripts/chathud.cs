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

$ChatHudMessageXSpeed[-1] = 600; //px / sec
$ChatHudMessageXSpeed[1] = 900; //px / sec
$ChatHudMessageYSpeed = 250; //px / sec

//-----------------------------------------------------------------------------
// Notifications
//-----------------------------------------------------------------------------

function addHelpLine(%message, %playBeep) {
	if (%playBeep) {
		serverplay2d(HelpDingSfx);
	}
	if (getWordCount(%message)) {
		%message = $pref::OldItemNames ? replaceNewItemNames(%message, true) : %message;
		if ($TexturePack::MBPHelpUI) {
			addDownYellowMBP(%message);
			return;
		} else if ($TexturePack::MBGHelpUI) {
			addDownYellowMBG(%message);
			return;
		}
		$ChatHudMessageId ++;
		%text = "<bold:23>" @ %message;
		createHelpMessage($ChatHudMessageId, %text, 4000);
	}
}

function clearMessages() {
	PG_MessageListBox.clear();
	cancel($DownYellowFadeTimer);
	DownYellowMBPText.setAlpha(0.0);
	DownYellowMBPShadow.setAlpha(0.0);
	DownYellowMBGText.setAlpha(0.0);
	DownYellowMBGShadow.setAlpha(0.0);
}

function shiftMessages(%amount) {
	for (%i = 0; %i < PG_MessageListBox.getCount(); %i ++) {
		%box = PG_MessageListBox.getObject(%i);
		//Tell it to go up more
		%box.targetY -= %amount;
	}
}

function updateMessages(%delta) {
	for (%i = 0; %i < PG_MessageListBox.getCount(); %i ++) {
		%box = PG_MessageListBox.getObject(%i);
		%x = getWord(%box.getPosition(), 0);
		%y = getWord(%box.getPosition(), 1);

		if (%x != %box.targetX) {
			//Go in the direction given by directionX, each also has their own speed constant (see above)
			%x += $ChatHudMessageXSpeed[%box.directionX] * (%delta / 1000) * %box.directionX;
			//Don't go past the limit. Multiply by direction because lazy way of making it work both ways
			if (%x * %box.directionX > %box.targetX * %box.directionX)
				%x = %box.targetX;
			%box.setPosition(%x SPC getWord(%box.getPosition(), 1));
		} else if (%box.directionX == -1) {
			//Delete after this frame (but don't break our loop)
			%box.onNextFrame(delete);
		}
		if (%y != %box.targetY) {
			//Scoot it up
			%y -= $ChatHudMessageYSpeed * (%delta / 1000);
			//Don't go past the limit
			if (%y < %box.targetY)
				%y = %box.targetY;
			%box.setPosition(getWord(%box.getPosition(), 0) SPC %y);
		}
	}

	updateAchievementMessages(%delta);
}

function createHelpMessage(%id, %text, %timeout) {
	//So we can address each component by name after creation
	%boxName        = ("PG_Message" @ %id @ "_Box");
	%foregroundName = ("PG_Message" @ %id @ "_TextForeground");
	%backgroundName = ("PG_Message" @ %id @ "_TextBackground");

	%width = min(getWord(PG_ChatBubbleBox.position, 0) + 20, 400);

	new GuiControl(%boxName) {
		profile = "GuiDefaultProfile";
		horizSizing = "right";
		vertSizing = "top";
		position = -%width SPC getWord(PG_MessageListBox.getExtent(), 1);
		extent = %width SPC "70";
		minExtent = "8 8";
		visible = "1";
		targetX = 0;
		targetY = getWord(PG_MessageListBox.getExtent(), 1);
		directionX = 1;

		new GuiBitmapBorderCtrl() {
			profile = "GuiRoundBorderThinProfile";
			horizSizing = "width";
			vertSizing = "height";
			position = "-12 0";
			extent = (%width + 12) SPC "70";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
		};
		new GuiControl() {
			profile = "GuiDefaultProfile";
			horizSizing = "width";
			vertSizing = "height";
			position = "6 12";
			extent = (%width - 6) SPC "46";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";

			new GuiMLTextCtrl(%backgroundName) {
				profile = "GuiMLTextProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "1 1";
				extent = (%width - 24) SPC "46";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
			};
			new GuiMLTextCtrl(%foregroundName) {
				profile = "GuiMLTextProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "0 0";
				extent = (%width - 24) SPC "46";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
			};
		};
	};

	%backgroundName.setText("<color:777777>" @ %text);
	%foregroundName.setText("<color:ffffff>" @ %text);
	PG_MessageListBox.add(%boxName);

	//Reflow it so we can tell if we need to make the box bigger
	if (%foregroundName.isAwake())
		%foregroundName.forceReflow();

	//Update the size of the box
	%boxName.setExtent(VectorAdd(%foregroundName.getExtent(), "24 24"));
	//Shift every other message out of the way
	shiftMessages(getWord(%foregroundName.getExtent(), 1) + 24);

	//Tell it to move back after the timeout
	%boxName.schedule(%timeout, setFieldValue, "targetX", -%width);
	%boxName.schedule(%timeout, setFieldValue, "directionX", -1);
}

function fadeCenterWhiteMBG(%fade){ // Old helptext rendering from MBG
   WhiteCenterMBGText.setAlpha(1.0 * %fade);
   WhiteCenterMBGShadow.setAlpha(%fade);
   if(%fade > 0){
      %nextFade = %fade - 0.03;
      if(%nextFade < 0)
         %nextFade = 0;
      $CenterWhiteFadeTimer = schedule(32, 0, fadeCenterWhiteMBG, %nextFade);
   }
}
function addCenterWhiteMBG(%message, %help) {
	%text = "<just:center><font:DomCasualD:32>" @ %message;
	WhiteCenterMBGShadow.setText("<color:000000>" @ %text);
	WhiteCenterMBGText.setText("<color:FFFFFF>" @ %text);

	if (getWord(WhiteCenterMBGText.getExtent(), 1) > 203 || %help) {
			%text = "<just:center><font:DomCasualD:32>Press X to read this message!";
			WhiteCenterMBGShadow.setText("<color:777777>" @ %text);
			WhiteCenterMBGText.setText("<color:FFFFFF>" @ %text);
			PlayGui.extendedHelp = %message;
			PlayGui.hasExtendedHelp = true;
	}

	cancel($CenterWhiteFadeTimer);
	WhiteCenterMBGText.setAlpha(1.0);
	WhiteCenterMBGShadow.setAlpha(1.0);
	$CenterWhiteFadeTimer = schedule(3000, 0, fadeCenterWhiteMBG, 1.0);
}

function fadeCenterWhiteMBP(%fade) {
   WhiteCenterMBPText.setAlpha(1.0 * %fade);
   WhiteCenterMBPShadow.setAlpha(%fade);
   if(%fade > 0){
      %nextFade = %fade - 0.03;
      if(%nextFade < 0)
         %nextFade = 0;
      $CenterWhiteFadeTimer = schedule(32, 0, fadeCenterWhiteMBP, %nextFade);
   }
}
function addCenterWhiteMBP(%message, %help) {
	%text = "<just:center><font:DomCasualD:32>" @ %message;
	WhiteCenterMBPShadow.setText("<color:777777>" @ %text);
	WhiteCenterMBPText.setText("<color:FFFFFF>" @ %text);
	WhiteCenterMBPText.forceReflow();

	if (getWord(WhiteCenterMBPText.getExtent(), 1) > 203 || %help) {
		%text = "<just:center><font:DomCasualD:32>Press X to read this message!";
		WhiteCenterMBPShadow.setText("<color:777777>" @ %text);
		WhiteCenterMBPText.setText("<color:FFFFFF>" @ %text);
		PlayGui.extendedHelp = %message;
		PlayGui.hasExtendedHelp = true;
	}

	cancel($CenterWhiteFadeTimer);
	WhiteCenterMBPText.setAlpha(1.0);
	WhiteCenterMBPShadow.setAlpha(1.0);
	$CenterWhiteFadeTimer = schedule(3000, 0, fadeCenterWhiteMBP, 1.0);
}

//-----------------------------------------------------------------------------
// Achievement Messages
//-----------------------------------------------------------------------------

function addAchievementMessage(%text, %bitmap, %extent) {
	$ChatHudMessageId ++;
	createAchievementMessage($ChatHudMessageId, %text, %bitmap, %extent, 4000);
}

function shiftAchievementMessages(%amount) {
	for (%i = 0; %i < PG_AchievementListBox.getCount(); %i ++) {
		%box = PG_AchievementListBox.getObject(%i);
		//Tell it to go up more
		%box.targetY -= %amount;
	}
}

function updateAchievementMessages(%delta) {
	for (%i = 0; %i < PG_AchievementListBox.getCount(); %i ++) {
		%box = PG_AchievementListBox.getObject(%i);
		%x = getWord(%box.getPosition(), 0);
		%y = getWord(%box.getPosition(), 1);

		if (%x != %box.targetX) {
			//Go in the direction given by directionX, each also has their own speed constant (see above)
			%x += $ChatHudMessageXSpeed[%box.directionX] * (%delta / 1000) * %box.directionX;
			//Don't go past the limit. Multiply by direction because lazy way of making it work both ways
			if (%x * %box.directionX > %box.targetX * %box.directionX)
				%x = %box.targetX;
			%box.setPosition(%x SPC getWord(%box.getPosition(), 1));
		} else if (%box.directionX == 1) {
			//Delete after this frame (but don't break our loop)
			%box.onNextFrame(delete);
		}
		if (%y != %box.targetY) {
			//Scoot it up
			%y -= $ChatHudMessageYSpeed * (%delta / 1000);
			//Don't go past the limit
			if (%y < %box.targetY)
				%y = %box.targetY;
			%box.setPosition(getWord(%box.getPosition(), 0) SPC %y);
		}
	}
}

function createAchievementMessage(%id, %text, %bitmap, %extent, %timeout) {
	//So we can address each component by name after creation
	%boxName        = ("PG_Message" @ %id @ "_Box");
	%foregroundName = ("PG_Message" @ %id @ "_TextForeground");
	%backgroundName = ("PG_Message" @ %id @ "_TextBackground");
	%bitmapName     = ("PG_Message" @ %id @ "_Bitmap");

	%bitmapMax = 72;
	%extentMax = max(getWord(%extent, 0), getWord(%extent, 1));
	%scale = %bitmapMax / %extentMax;
	%bitmapExtent = VectorRound(VectorScale(%extent, %scale));

	%width = min(getWord(PG_ChatBubbleBox.position, 0) + 20, 400);

	new GuiControl(%boxName) {
		profile = "GuiDefaultProfile";
		horizSizing = "right";
		vertSizing = "top";
		position = PG_AchievementListBox.getExtent();
		extent = %width SPC "70";
		minExtent = "8 8";
		visible = "1";
		targetX = getWord(PG_AchievementListBox.getExtent(), 0) - %width;
		targetY = getWord(PG_AchievementListBox.getExtent(), 1);
		directionX = -1;

		new GuiBitmapBorderCtrl() {
			profile = "GuiRoundBorderThinProfile";
			horizSizing = "width";
			vertSizing = "height";
			position = "12 0";
			extent = (%width + 12) SPC "70";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
		};
		new GuiBitmapCtrl(%bitmapName) {
			profile = "GuiDefaultProfile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "16 8";
			extent = %bitmapExtent;
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
			wrap = "0";
		};
		new GuiControl() {
			profile = "GuiDefaultProfile";
			horizSizing = "width";
			vertSizing = "height";
			position = "18 12";
			extent = (%width - 6) SPC "46";
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";

			new GuiMLTextCtrl(%backgroundName) {
				profile = "GuiMLTextProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "1 1";
				extent = (%width - 24) SPC "46";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
			};
			new GuiMLTextCtrl(%foregroundName) {
				profile = "GuiMLTextProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "0 0";
				extent = (%width - 24) SPC "46";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
			};
		};
	};

	%bitmapName.setBitmap(%bitmap);
	%text = "<lmargin:80><bold:28>Achievement Unlocked!\n<bold:25>\"" @ %text @ "\"";

	%backgroundName.setText("<color:777777>" @ %text);
	%foregroundName.setText("<color:ffffff>" @ %text);
	PG_AchievementListBox.add(%boxName);

	//Reflow it so we can tell if we need to make the box bigger
	if (%foregroundName.isAwake())
		%foregroundName.forceReflow();

	//Update the size of the box
	%boxName.setExtent(VectorAdd(%foregroundName.getExtent(), "24 24"));
	//Shift every other message out of the way
	shiftAchievementMessages(getWord(%foregroundName.getExtent(), 1) + 24);

	//Tell it to move back after the timeout
	%boxName.schedule(%timeout, setFieldValue, "targetX", %width);
	%boxName.schedule(%timeout, setFieldValue, "directionX", 1);
}

//-----------------------------------------------------------------------------
// Help bubble
//-----------------------------------------------------------------------------

function addBubbleLine(%message, %help, %time, %isAHelpLine) {
	// Do not show help trigger messages if we have it disabled in the options.
	if (%isAHelpLine && !$pref::HelpTriggers)
		return;
	%message = $pref::OldItemNames ? replaceNewItemNames(%message, true) : %message;
	if ($TexturePack::MBPHelpUI) {
		addCenterWhiteMBP(%message, %help);
		return;
	} else if ($TexturePack::MBGHelpUI) {
		addCenterWhiteMBG(%message, %help);
		return;
	}

	//Move the help bubble inwards
	PG_ChatBubbleBox.setVisible(true);

	//Font and size preferences
	%fontName = $DefaultFont["Bold"];
	%fontSize = 25;
	%font = "<font:" @ %fontName @ ":" @ %fontSize @ ">";

	%text = %font @ "<just:center>" @ %message;

	//If the text is longer than one line, add a slight indent on the first line
	// so we don't run into the help icon.
	%len = textLen(%message, %fontName, %fontSize);
	if (%len > 525)
		%text = "<tab:20>\t" @ %text;

	//Set the bubble's actual text
	PG_ChatBubbleBackground.setText("<color:777777>" @ %text);
	PG_ChatBubbleForeground.setText("<color:ffffff>" @ %text);

	//Resize the help bubble to fit
	tryBubbleReflow();

	//How tall is the text in the box?
	%textSize = getWord(PG_ChatBubbleForeground.extent, 1);
	%textSize += 65; //Padding
	%textSize = max(%textSize, 120); //Minimum size

	//If the message is too long, and/or they should show the help, let them know.
	if (%textSize > 205 || %help) {
		PlayGui.extendedHelp = %message;
		PlayGui.hasExtendedHelp = true;

		//Replace the help bubble's message with a short message to let them know
		// to press X.
		%text = %font @ "<just:center>Press X to read this message!";
		PG_ChatBubbleBackground.setText("<color:777777>" @ %text);
		PG_ChatBubbleForeground.setText("<color:ffffff>" @ %text);

		//Reset the size to the minimum, which is all that we'll need
		%textSize = 120;

		//Blue help bubble icon because we need to press X
		PG_ChatBubbleIcon.setBitmap($usermods @ "/client/ui/game/help/help_icon_blue");
	} else {
		PlayGui.hasExtendedHelp = false;

		//Red icon because it's the message here
		PG_ChatBubbleIcon.setBitmap($usermods @ "/client/ui/game/help/help_icon");
	}

	PG_ChatBubbleBox.setHeight(%textSize);

	//Don't try to show the bubble twice in a row
	if (PlayGui.showingBubble && !PlayGui.animatingBubble) {
		updateBubbleAnimation(30);
	} else {
		//Tell the bubble we're showing
		PlayGui.showingBubble = true;
		//Start animating if we have to
		if (!PlayGui.animatingBubble) {
			PlayGui.animatingBubble = true;
			//Start animating upwards
			updateBubbleAnimation(0);
		}
	}

	cancel($BubbleHideSchedule);
	if (%time !$= "") {
		$BubbleHideSchedule = schedule(%time, 0, "hideBubble");
	}
}

function updateBubbleAnimation(%progress) {
	//How large is it?
	%textSize = getWord(PG_ChatBubbleBox.extent, 1);
	cancel($BubbleSchedule);

	%bottom = getWord(PlayGui.extent, 1);
	//If we have chat open, we need to make extra room. Easiest way to do this
	// is to just pretend we have more text.

	%isEndGame = (isObject(EndGameDlg.getGroup()) && EndGameDlg.getGroup().getName() $= "Canvas");
	%moveChatUp = (lb() && $pref::ScreenshotMode == 0) || isCannonActive();

	if (%moveChatUp) {
		%textSize += (20 * ($LBPref::ChatMessageSize)) - 10; // previously 110 without the ChatMessageSize change
	}

	//Update the progress of the bubble
	if (%progress <= 30 && %progress >= 0) {
		//Move it up/down in ~0.5 seconds
		PG_ChatBubbleBox.setPosition(getWord(PG_ChatBubbleBox.position, 0) SPC(%bottom - (%textSize * %progress / 30)));
		$BubbleSchedule = schedule(16, 0, updateBubbleAnimation, (PlayGui.showingBubble ? %progress + 1 : %progress - 1));
	} else {
		//We've hit the end
		PlayGui.animatingBubble = false;

		//If we've hit the bottom, hide it for speed reasons.
		if (%progress < 0) {
			PG_ChatBubbleBox.setVisible(0);
		} else {
			//Just set us at the bottom
			PG_ChatBubbleBox.setPosition(getWord(PG_ChatBubbleBox.position, 0) SPC(%bottom - %textSize));
			//We haven't finished, but the GUI might update and we'd need to
			// move the bubble box down. So keep scheduling
			$BubbleSchedule = schedule(16, 0, updateBubbleAnimation, (PlayGui.showingBubble ? %progress + 1 : %progress - 1));
		}
	}
}

function hideBubble(%progress) {
	//Don't try to hide the bubble if it's not showing
	if (PlayGui.showingBubble) {
		//Tell the bubble we're hiding
		PlayGui.showingBubble = false;
		//Start animating if we have to
		if (!PlayGui.animatingBubble) {
			PlayGui.animatingBubble = true;
			//Start from the end so it animates backwards
			updateBubbleAnimation(30);
		}
	}

	//Clear the extended help so we can't press X again
	PlayGui.extendedHelp = "";
	PlayGui.hasExtendedHelp = false;

	cancel($CenterWhiteFadeTimer);
	WhiteCenterMBPText.setAlpha(0.0);
	WhiteCenterMBPShadow.setAlpha(0.0);
	WhiteCenterMBGText.setAlpha(0.0);
	WhiteCenterMBGShadow.setAlpha(0.0);
}

function popupExtendedHelp(%val) {
	if (%val && PlayGui.hasExtendedHelp) {
		//Shows the extended help information from a help bubble.
		ExtendedHelpDlg.open(PlayGui.extendedHelp);
	}
}

function tryBubbleReflow() {
	//Wait until we're at the PlayGui
	if (PG_ChatBubbleForeground.isAwake()) {
		PG_ChatBubbleForeground.forceReflow();
	} else {
		schedule(100, 0, tryBubbleReflow);
	}
}

function fadeDownYellowMBG(%fade){ // Old helptext rendering from MBG
   DownYellowMBGText.setAlpha(0.8 * %fade);
   DownYellowMBGShadow.setAlpha(%fade);
   if(%fade > 0) {
      %nextFade = %fade - 0.03;
      if(%nextFade < 0)
         %nextFade = 0;
      $DownYellowFadeTimer = schedule(32, 0, fadeDownYellowMBG, %nextFade);
   }
}

function addDownYellowMBG(%message,%color){
	if (%color $= "")
		%color = "ffff00";
		%text = "<just:center><font:DomCasualD:32>" @ %message;
		DownYellowMBGShadow.setText("<color:000000>" @ %text);
		DownYellowMBGText.setText("<color:" @ %color @ ">" @ %text);
		cancel($DownYellowFadeTimer);
		DownYellowMBGText.setAlpha(0.8);
		DownYellowMBGShadow.setAlpha(1.0);
		$DownYellowFadeTimer = schedule(3000, 0, fadeDownYellowMBG, 1.0);
		if (lb()) {
			%hideChat      = $pref::ScreenshotMode > 0 || %isEndGame || isCannonActive();
			if (!%hideChat) {
				DownYellowMBG.setPosition(0 SPC getWord(VectorSub(PlayGui.getExtent(), 0 SPC 62 + (20 * ($LBPref::ChatMessageSize))), 1)); // Change position based on height of chat, if visible
			}
		} else {
			DownYellowMBG.setPosition(0 SPC getWord(VectorSub(PlayGui.getExtent(), "0 62"), 1));
		}
}

function fadeDownYellowMBP(%fade) {
   DownYellowMBPText.setAlpha(0.8 * %fade);
   DownYellowMBPShadow.setAlpha(%fade);
   if(%fade > 0) {
      %nextFade = %fade - 0.03;
      if(%nextFade < 0)
         %nextFade = 0;
      $DownYellowFadeTimer = schedule(32, 0, fadeDownYellowMBP, %nextFade);
   }
}

function addDownYellowMBP(%message,%color) {
	if (%color $= "")
		%color = "ffee99";
	%text = "<just:center><font:DomCasualD:32>" @ %message;
	DownYellowMBPShadow.setText("<color:776622>" @ %text);
	DownYellowMBPText.setText("<color:" @ %color @ ">" @ %text);
	cancel($DownYellowFadeTimer);
	DownYellowMBPText.setAlpha(0.8);
	DownYellowMBPShadow.setAlpha(1.0);
	$DownYellowFadeTimer = schedule(3000, 0, fadeDownYellowMBP, 1.0);
	DownYellowMBP.setPosition(0 SPC getWord(VectorSub(PlayGui.getExtent(), "0 170"), 1));
}