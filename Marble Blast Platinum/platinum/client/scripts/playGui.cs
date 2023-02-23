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

//-----------------------------------------------------------------------------
// PlayGui is the main TSControl through which the game is viewed.
// The PlayGui also contains the hud controls.
//-----------------------------------------------------------------------------

function PlayGui::onWake(%this) {
	%this.doFPSCounter();

	// Turn off any shell sounds...
	// alxStop( ... );

	$PlayGuiGem = true;
	$PlayGuiTT = true;
	$InPlayGUI = true;
	resetCameraFov();

	hideControllerUI();

	// this screws my computer up, making this a pref
	if ($Pref::EnableDirectInput)
		$enableDirectInput = "1";
	activateDirectInput();

	if (ControllerGui.isJoystick())
		enableJoystick();
	else
		disableJoystick();

	// Message hud dialog
	//RootGui.pushDialog( MainChatHud );
	//chatHud.attach(HudMessageVector);

	// Make sure the display is up to date
	%this.setGemCount(%this.gemCount);
	%this.setMaxGems(%this.maxGems);

	// just update the action map here
	if ($playingDemo) {
		demoMap.push();
	} else {
		if (ControllerGui.isJoystick()) {
			JoystickMap.push();
		} else {
			MoveMap.push();
		}
	}

	// Check if enable showing FPS
	FPSMetreCtrl.setVisible($pref::showFPSCounter);

	// hack city - these controls are floating around and need to be clamped
	onNextFrame("refreshCenterTextCtrl");
	onNextFrame("refreshBottomTextCtrl");
	playGameMusic();

	LagIcon.setVisible(false);
	showSpectatorMenu(false);

	%this.updateRecordingIndicator();

	PG_LBChatEntry.setTickable(true);
	PGCoopView.setVisible(false);
	GemsQuota.setVisible(false);

	//Thousands
	PG_Timer.setVisible(!$pref::Thousandths);
	PG_TimerThousands.setVisible($pref::Thousandths);

	if (lb()) {
		// decide which mode we have to set
		if (mp()) {
			if ($Server::Hosting) {
				LBSetMode(6); //Hosting
			} else {
				LBSetMode(12); //MultiPlayer
			}
		} else {
			LBSetMode(2); //Playing
		}

		RootGui.pushDialog(LBMessageHudDlg);

		disableChatHUD();
		PG_LBChatScroll.setVisible(true);
		LBUpdateChat();

		// clear any uncleaned up nametags
		while (isObject(NameTagCtrl.getObject(0)))
			NameTagCtrl.getObject(0).delete();

	} else {
		PG_LBChatScroll.setVisible(false);
		RootGui.popDialog(LBMessageHudDlg);
	}

	// if we are multiplayer, show the pregame dialog
	%multiplayer = ($Server::ServerType $= "Multiplayer");
	if (%multiplayer && $Game::Pregame) {
		RootGui.pushDialog(MPPreGameDlg);
		%this.setTime(0);
		%this.stopTimer();
		resetScoreList();
	}
	if (shouldEnableBlast())
		%this.updateBlastBar();

	alxSetChannelVolume(1, $pref::Audio::channelVolume1);
	alxSetChannelVolume(2, $pref::Audio::channelVolume2);

	%this.clearPowerupTimers();

	PGScoreListContainer.setVisible(%multiplayer);
	PG_BlastBar.setVisible(!$SpectateMode && shouldEnableBlast());
	RadarSetMode($Pref::RadarMode);
	clearMessages();
	applyGraphicsQuality();

	%this.positionMessageHud();
	%this.onNextFrame(positionMessageHud);
	%this.updateGems();
	%this.stopCountdown();
	useScriptCameraTransform(false);

	// update the fader status
	// this variable is set true in missiondownload.cs
	PG_Fader.setVisible($PlayGuiFader);
	$PlayGuiFader = false;

	$Game::PlayingStart = $Sim::Time;

	PGLapsCounter.setVisible(false);
	PGSpeedometer.setVisible(ClientMode::callback("shouldShowSpeedometer", false));

	if ($pref::alwaysshowspeedometer) {
	    PGSpeedometer.setVisible(1);	
	}

	ClientMode::callback("onShowPlayGui", "");
}

function PlayGui::onSleep(%this) {
	%this.stopFPSCounter();
	%this.stopCountdown();
	RootGui.resetDisplay();

	$InPlayGUI = false;

	//RootGui.popDialog(MainChatHud);
	// Terminate all playing sounds
	alxStopAll();

	setCameraFov(90);

	// Play the right song!
	if (lb())
		playLBMusic();
	else
		playShellMusic();

	RadarSetMode(0);
	Radar::ShowDots(false);
	Radar::ClearTargets();

	//How long were you on the level?
	%levelTime = $Sim::Time - $Game::PlayingStart;
	//Save it as a pref
	$pref::LevelTime[strreplace($Client::MissionFile, "lbmission", "mission")] += %levelTime;

	// pop the keymaps
	MoveMap.pop();
	JoystickMap.pop();
	demoMap.pop();

	if (ControllerGui.isJoystick())
		showControllerUI();
}

function PlayGui::updateRecordingIndicator(%this) {
    if ($Game::Record && !mp() && !$playingDemo) {
		PG_RecordingIndicator.setVisible(true);
        RecordingIndicatorIcon.setVisible(true);
	} else {
	    PG_RecordingIndicator.setVisible(false);
		RecordingIndicatorIcon.setVisible(false);	
	}
}

// The FPS counter only updates per second now - there is no need to repeatedly be setting
// the text on frame advance since it's just wasting CPU and could possibly be contributing
// to the crashing going on

function PlayGui::stopFPSCounter(%this) {
	cancel(%this.fpsCounterSched);
}

// Just more of a shorthand
function PlayGui::doFPSCounter(%this) {
	%pingnum = "high";
	if (ServerConnection.getPing() >= 100) %pingnum = "medium";
	if (ServerConnection.getPing() >= 250) %pingnum = "low";
	if (ServerConnection.getPing() >= 500) %pingnum = "matanny";
	if (ServerConnection.getPing() >= 1000) %pingnum = "unknown";
	%fps = $fps::real;
	if (%fps >= 100) %fps = mRound(%fps) @ " ";
	FPSMetreText.setText("<bold:24><just:left>FPS:<condensed:23>" SPC %fps @ ($Server::ServerType $= "MultiPlayer" ? "<bitmap:" @ $usermods @ "/client/ui/lb/play/connection-" @ %pingnum @ ".png>" : ""));
	cancel(%this.fpsCounterSched);
	%this.fpsCounterSched = %this.schedule(500, doFPSCounter);
}

//-----------------------------------------------------------------------------

function PlayGui::setMessage(%this,%bitmap,%timer) {
	// Set the center message bitmap
	%dir = $userMods @ "/client/ui/game/state/";
	if (%bitmap !$= "" && isFile(%dir @ %bitmap @ ".png"))  {
		// Fun fact -- if this bitmap doesn't exist, you crash. Really badly. It's hilarious
		CenterMessageDlg.setBitmap(%dir @ %bitmap @ ".png",true);
		CenterMessageDlg.setVisible(true);
		cancel(CenterMessageDlg.timer);
		if (%timer)
			CenterMessageDlg.timer = CenterMessageDlg.schedule(%timer,"setVisible",false);
	} else
		CenterMessageDlg.setVisible(false);
}


//-----------------------------------------------------------------------------

function PlayGui::setPowerUp(%this,%shapeFile,%skinName) {
	// Update the power up hud control
	if (%shapeFile $= "")
		HUD_ShowPowerUp.setEmpty();
	else
		HUD_ShowPowerUp.setModel(%shapeFile, %skinName);
}

function PlayGui::lockPowerup(%this, %locked) {
	if (%locked)
		HUD_PowerupBackground.setBitmap($userMods @ "/client/ui/game/powerup_locked.png");
	else
		HUD_PowerupBackground.setBitmap($userMods @ "/client/ui/game/powerup.png");
}

//-----------------------------------------------------------------------------

function quotaCompleteParty() { // code half taken from \platinum\client\ui\MainMenuGui.gui
	cancel($quotacompleteparty);
	$hue++;
	GemsFoundHundred.setNumberColor(PlayGui.GemsFoundHundredTracked, HSVtoRGB($hue+90, 1, 1));
	GemsFoundTen.setNumberColor(PlayGui.GemsFoundTenTracked, HSVtoRGB($hue+75, 1, 1));
	GemsFoundOne.setNumberColor(PlayGui.GemsFoundOneTracked, HSVtoRGB($hue+60, 1, 1));
	GemsSlash.setNumberColor("slash", HSVtoRGB($hue+45, 1, 1));
	GemsTotalHundred.setNumberColor(PlayGui.GemsTotalHundredTracked, HSVtoRGB($hue+30, 1, 1));
	GemsTotalTen.setNumberColor(PlayGui.GemsTotalTenTracked, HSVtoRGB($hue+15, 1, 1));
	GemsTotalOne.setNumberColor(PlayGui.GemsTotalOneTracked, HSVtoRGB($hue, 1, 1));

	$quotacompleteparty = schedule(10, 0, quotaCompleteParty);
}

function PlayGui::setMaxGems(%this,%count) {
	%prevMax = %this.maxGems;
	%this.maxGems = %count;
	%this.updateGems(%prevMax == %this.maxGems);
}

function PlayGui::setGemCount(%this,%count,%green) {
	%this.gemCount = %count;
	%this.gemGreen = %green;
	%this.updateGems();
}


function PlayGui::updateGems(%this, %updateMax) {
	%count = %this.gemCount;
	%max = %this.maxGems;

	PG_HuntCounter.setVisible(false);
	PG_GemCounter.setVisible(%max);

	PG_Timer.setVisible(!$pref::Thousandths);
	PG_TimerThousands.setVisible($pref::Thousandths);


	if ($PlayGuiGem) {
		// PQ gets its own gem
		if ($currentGame $= "PlatinumQuest") {
			%skins = "platinum";
			%dts = $usermods @ "/data/shapes_pq/gameplay/gems/gem.dts";
		} else if
		   ($currentGame $= "Ultra") {
			%skins = "red";
			%dts = $usermods @ "/data/shapes_mbu/items/gem.dts";
		} else {
			%skins = "base black blue green orange platinum purple red turquoise yellow";
			%dts = $usermods @ "/data/shapes/items/gem.dts";
		}

		// choose it
		%skin = getWord(%skins, getRandom(0, getWordCount(%skins) - 1));
		echo("Setting the PlayGUI gem to" SPC %skin);

		HUD_ShowGem.setModel(%dts, %skin);
		Hunt_ShowGem.setModel(%dts, %skin);
		$PlayGuiGem = false;
	}


	if ($PlayGuiTT) {
		// PQ gets its own TT
		if ($currentGame $= "PlatinumQuest") {
			%skins = "base";
			%dts = $usermods @ "/data/shapes_pq/gameplay/powerups/timetravel.dts";
		} else if
		   ($currentGame $= "Ultra") {
			%skins = "base";
			%dts = $usermods @ "/data/shapes_mbu/items/timetravel.dts";
		} else if
		   (Sky.materialList $= "platinum/data/skies/sky_day.dml") {
			%skins = "mbg";
			%dts = $usermods @ "/data/shapes/items/timetravel.dts";
		} else {
			%skins = "base";
			%dts = $usermods @ "/data/shapes/items/timetravel.dts";
		}

		// choose it
		%skin = getWord(%skins, getRandom(0, getWordCount(%skins) - 1));
		echo("Setting the PlayGUI TT to" SPC %skin);

		PGCountdownTTImage.setModel(%dts, %skin);
		$PlayGuiTT = false;
	}

	if (!ClientMode::callback("shouldUpdateGems", true))
		return;


	//If the mode changes this
	%count = %this.gemCount;
	%max = %this.maxGems;

	if (!%max)
		return;

	if (%this.gemRainbow && %count > %max) {
		quotaCompleteParty();
		%max = %this.gemRainbowNewMax; // example: on 100%, gem counter goes from 40/20 to 40/40.
	} else {
		%this.gemRainbow = false;
		cancel($quotacompleteparty);
	}

	%color = (%this.gemGreen ? $TimeColor["stopped"] : $TimeColor["normal"]);
	GemsSlash.setNumberColor("slash", %color);


	%maxNeedsToUpdate = (%this.GemsTotalTracked != %this.maxGems || %this.ColorTracked != %color || %this.gemRainbow || %updateMax);
	%this.GemsTotalTracked = %max;
	%this.ColorTracked = %color;

	%one = %count % 10;
	%ten = ((%count - %one) / 10) % 10;
	%hun = ((%count - %one) / 10 - %ten) / 10;
	GemsFoundHundred.setNumberColor(%hun, %color);
	GemsFoundTen.setNumberColor(%ten, %color);
	GemsFoundOne.setNumberColor(%one, %color);

	GemsFoundHundred.setVisible(!(%hun == 0) || $pref::GemCounterAlwaysThreeDigits); 
	GemsFoundTen.setVisible(!(%hun == 0 && %ten == 0) || $pref::GemCounterAlwaysThreeDigits || $pref::GemCounterAlwaysTwoDigits); 

	%this.GemsFoundHundredTracked = %hun;
	%this.GemsFoundTenTracked = %ten;
	%this.GemsFoundOneTracked = %one;

	if (%hun != 0 || $pref::GemCounterAlwaysThreeDigits) { // Move the slash and everything over.
		GemsFoundHundred.setPosition("30 0");
		GemsFoundTen.setPosition("54 0");
		GemsFoundOne.setPosition("78 0"); // 78 + 23 = 101
		GemsSlash.setPosition("101 0"); // 101 + 19 = 20
		GemsTotalHundred.setPosition("120 0");
		GemsTotalTen.setPosition("144 0");
		GemsTotalOne.setPosition("168 0");
	} else {
		GemsFoundHundred.setPosition("6 0"); // This shouldn't appear, but it should show here I guess
		GemsFoundTen.setPosition("30 0");
		GemsFoundOne.setPosition("54 0");
		GemsSlash.setPosition("77 0");
		GemsTotalHundred.setPosition("96 0");
		GemsTotalTen.setPosition("120 0");
		GemsTotalOne.setPosition("144 0");
	}
	
	GemsQuota.setPosition((%max < 10? "157" : (%max < 100? "181" : "205")) + (%hun == 0? -24 : 0) SPC "28");
	// quota is 37 away by default, 120+37=157 144+37=181, -24 if current gems are 2 digit instead of 3 digit
	if (%maxNeedsToUpdate) {
		%one = %max % 10;
		%ten = ((%max - %one) / 10) % 10;
		%hun = ((%max - %one) / 10 - %ten) / 10;

		if ($pref::GemCounterAlwaysThreeDigits) {
			GemsTotalHundred.setNumberColor(%hun, %color);
			GemsTotalTen.setNumberColor(%ten, %color);
			GemsTotalOne.setNumberColor(%one, %color);
			%this.GemsTotalHundredTracked = %hun;
			%this.GemsTotalTenTracked = %ten;
			%this.GemsTotalOneTracked = %one;
			GemsQuota.setPosition("205 28");
			GemsTotalTen.setVisible(true);
			GemsTotalOne.setVisible(true);
			return;
		} else if ($pref::GemCounterAlwaysTwoDigits && %max < 100) {
			GemsTotalHundred.setNumberColor(%ten, %color);
			%this.GemsTotalHundredTracked = %ten;
			GemsTotalTen.setNumberColor(%one, %color);
			%this.GemsTotalTenTracked = %one;
			GemsTotalHundred.setVisible(true);
			GemsTotalTen.setVisible(true);
			GemsTotalOne.setVisible(false);
			return;
		}

		if (%max < 10) {
			GemsTotalHundred.setNumberColor(%one, %color);
			%this.GemsTotalHundredTracked = %one;
		} else if (%max < 100) {
			GemsTotalHundred.setNumberColor(%ten, %color);
			%this.GemsTotalHundredTracked = %ten;
			GemsTotalTen.setNumberColor(%one, %color);
			%this.GemsTotalTenTracked = %one;
		} else {
			GemsTotalHundred.setNumberColor(%hun, %color);
			GemsTotalTen.setNumberColor(%ten, %color);
			GemsTotalOne.setNumberColor(%one, %color);
			%this.GemsTotalHundredTracked = %hun;
			%this.GemsTotalTenTracked = %ten;
			%this.GemsTotalOneTracked = %one;
		}
		GemsTotalTen.setVisible(%ten != 0 || %hun != 0); // 0X0 or X00 where X is not 0
		GemsTotalOne.setVisible(%hun != 0);
	}
}

//-----------------------------------------------------------------------------
// Bars

function PlayGui::setBlastValue(%this, %value) {
	%this.blastValue = %value;
	%this.updateBlastBar();
}

function PlayGui::updateBlastBar(%this) {
	//Empty: 5 5 0   17
	//Full:  5 5 110 17
	//Partial: 5 5 (total * 110) 17
	PG_BlastFill.resize(5, 5, %this.blastValue * 110, 17);
	%oldBitmap = PG_BlastFrame.bitmap;
	if ((($Game::IsMode["challenge"] && $CurrentWeeklyChallenge.tripleBlast) || $MP::PartyTripleBlast))
		%newBitmap = $usermods @ "/client/ui/game/blastbar_triple";
	else
		%newBitmap = $usermods @ "/client/ui/game/blastbar";
	if ($MP::SpecialBlast)
		%newBitmap = %newBitmap @ "_charged";
	if (%oldBitmap !$= %newBitmap)
		PG_BlastFrame.setBitmap(%newBitmap);

	%oldBitmap = PG_BlastFill.bitmap;
	%newBitmap = $usermods @ "/client/ui/game/blastbar_bar";
	if (%this.blastValue >= (($Game::IsMode["challenge"] && $CurrentWeeklyChallenge.tripleBlast) ? 0.33 : $MP::BlastRequiredAmount))
		%newBitmap = %newBitmap @ "green";
	else
		%newBitmap = %newBitmap @ "gray";
	if ((($Game::IsMode["challenge"] && $CurrentWeeklyChallenge.tripleBlast) || $MP::PartyTripleBlast))
		%newBitmap = $usermods @ "/client/ui/game/blastbar_bar" @ "triple";
	if (%oldBitmap !$= %newBitmap)
		PG_BlastFill.setBitmap(%newBitmap);

	// Blast bar is hidden if we spectate.
	PG_BlastBar.setVisible(!$SpectateMode && shouldEnableBlast());
}

function PlayGui::updateBubbleBar(%this) {
	if ($Game::BubbleInfinite) {
		PG_BubbleContainer.setVisible(true);
		PG_BubbleMeterText.setVisible(false);
		PG_BubbleFill.setVisible(false);
		PG_BubbleMeterImage.setBitmap(expandFilename("~/client/ui/game/specials/bubblebar-infinite"));
	} else if ($Game::BubbleTime > 0) {
		PG_BubbleContainer.setVisible(true);
		PG_BubbleMeterText.setVisible(true);
		PG_BubbleFill.setVisible(true);
		PG_BubbleMeterImage.setBitmap(expandFilename("~/client/ui/game/specials/bubblebar"));

		//Full size is 133 62
		PG_BubbleFill.setExtent(50 + (83 * ($Game::BubbleTime / $Game::BubbleTotalTime)) SPC 62);
		//231 241 241
		PG_BubbleMeterText.setText("<just:center><font:24><color:000000>" @ roundToTenths($Game::BubbleTime));
	} else {
		PG_BubbleContainer.setVisible(false);
	}
}


function PlayGui::updateFireballBar(%this) {
	if ($Client::FireballActive) {
		PG_FireballContainer.setVisible(true);
		//echo("FIREBALL::UPDATEGUI: MARBLE ("@%marble@")");
		%time = $Client::FireballTime - (getSimTime() - $Client::FireballStartTime);
		if (%time < 0)
			return;

		%time = $Client::FireballTime - (getSimTime() - $Client::FireballStartTime);
		//check for cooldown is active OR time < 1000; if so, return
		%canBlast = !(%time < 1000 || (getSimTime() - $Client::FireballLastBlastTime < 2000));

		PG_FireballMeterImage.setBitmap(expandFilename("~/client/ui/game/specials/" @(%canBlast ? "fireballbar-lit" : "fireballbar-unlit")));
		//Full size is 133 62
		PG_FireballFill.setExtent(50 + (83 * (%time / $Client::FireballActiveTime)) SPC 62);
		PG_FireballMeterText.setText("<just:center><font:24><color:000000>" @ roundToTenths(%time));
	} else {
		PG_FireballContainer.setVisible(false);
	}
}

function roundToTenths(%x) {
	%rounded = ((%x + 49) / 1000); // Having 0001 ms will add 49 to it, making it 0050, so 0.0 should never show.
	if (%rounded >= 100) {
		%rounded = mRound(%rounded, 0);
	} else {
		%rounded = mRound(%rounded, 1);
		if (mFloor(%rounded) == %rounded) {
			//No decimal, add one
			%rounded = %rounded @ ".0";
		}
	}
	return %rounded;
}

function specialBarFor(%id) {
	if (%id == 3) { // Super Bounce
		return expandFilename("~/client/ui/game/specials/superbouncebar");
	} else if (%id == 4) { // Shock Absorber
		return expandFilename("~/client/ui/game/specials/shockabsorberbar");
	} else if (%id == 5) { // Gyrocopter
		return expandFilename("~/client/ui/game/specials/gyrocopterbar");
	} else if (%id == 6) { // Mega Marble
		return expandFilename("~/client/ui/game/specials/megamarblebar");
	} else if (%id == 7) { // Teleporter
		return expandFilename("~/client/ui/game/specials/teleporterbar");
	} else if (%id == 777777) { // Transporter
		return expandFilename("~/client/ui/game/specials/transporterbar");
	} else if (%id == 696969) { // Teleport (not item, 696969 is dummy value)
		return expandFilename("~/client/ui/game/specials/teleporttriggerbar");
	}
	return expandFilename("~/client/ui/game/specials/gray");
}

function PlayGui::updateBarPositions(%this) {
	if (!isObject(ServerConnection) || !isObject(ServerConnection.getControlObject()))
		return;

	%trans = ServerConnection.getControlObject().getCameraTransform();

	//Which bars are active
	%bubble = ($Game::BubbleInfinite || $Game::BubbleTime > 0);
	%fireball = $Client::FireballActive;

	//Get the position of the side of the marble for us to position the bars relative to it
	%obj = ServerConnection.getControlObject();
	%rad = (%obj.getClassName() $= "Marble" ? %obj.getCollisionRadius() : 0.5);
	%mpos = %obj.getPosition();
	%rpos = VectorAdd(%mpos, RotMulVector(MatrixRot(%trans), %rad SPC "0 0"));

	%mpix = getPixelSpace(getGuiSpace(%trans, %mpos, getCameraFov()));
	%rpix = getPixelSpace(getGuiSpace(%trans, %rpos, getCameraFov()));

	//Offset a bit so we don't cover the marble and so we line up
	%x = getWord(%rpix, 0) + 20;
	%y = getWord(%mpix, 1) - 38;

	if (%fireball && %bubble) {
		//Because I know SOMEONE will try this
		PG_BubbleContainer.setPosition(%x SPC %y + 40);
		PG_FireballContainer.setPosition(%x SPC %y - 20);
	} else if (%bubble) {
		PG_BubbleContainer.setPosition(%x SPC %y);
	} else if (%fireball) {
		PG_FireballContainer.setPosition(%x SPC %y);
	}

	if (%this.powerupTimersTrueLength >= 1) {
		%num = %this.powerupTimersTrueIndexToFalse[0];
		%timer = %this.powerupTimersDuration[%num] - mAbs(PlayGui.totalTime - %this.powerupTimersTimeActivated[%num]);
		PG_FirstTimerContainer.setVisible(true);
		PG_FirstTimerContainer.setPosition(%x SPC %y + 60);
		PG_FirstTimerMeterText.setText("<just:center><font:24><color:000000>" @ roundToTenths(%timer));
		PG_FirstTimerMeterImage.setBitmap(specialBarFor(%this.powerupTimersId[%num]));
		PG_FirstTimerFill.setExtent(50 + (83 * (mAbs(%this.powerupTimersDuration[%num] - mAbs(PlayGui.totalTime - %this.powerupTimersTimeActivated[%num])) / %this.powerupTimersDuration[%num])) SPC 62);
	} else {
		PG_FirstTimerContainer.setVisible(false);
	}

	if (%this.powerupTimersTrueLength >= 2) {
		%num = %this.powerupTimersTrueIndexToFalse[1];
		%timer = %this.powerupTimersDuration[%num] - mAbs(PlayGui.totalTime - %this.powerupTimersTimeActivated[%num]);
		PG_SecondTimerContainer.setVisible(true);
		PG_SecondTimerContainer.setPosition(%x SPC %y + 120);
		PG_SecondTimerMeterText.setText("<just:center><font:24><color:000000>" @ roundToTenths(%timer));
		PG_SecondTimerMeterImage.setBitmap(specialBarFor(%this.powerupTimersId[%num]));
		PG_SecondTimerFill.setExtent(50 + (83 * (mAbs(%this.powerupTimersDuration[%num] - mAbs(PlayGui.totalTime - %this.powerupTimersTimeActivated[%num])) / %this.powerupTimersDuration[%num])) SPC 62);
	} else {
		PG_SecondTimerContainer.setVisible(false);
	}
	if (%this.powerupTimersTrueLength >= 3) {
		%num = %this.powerupTimersTrueIndexToFalse[2];
		%timer = %this.powerupTimersDuration[%num] - mAbs(PlayGui.totalTime - %this.powerupTimersTimeActivated[%num]);
		PG_ThirdTimerContainer.setVisible(true);
		PG_ThirdTimerContainer.setPosition(%x SPC %y + 180);
		PG_ThirdTimerMeterText.setText("<just:center><font:24><color:000000>" @ roundToTenths(%timer));
		PG_ThirdTimerMeterImage.setBitmap(specialBarFor(%this.powerupTimersId[%num]));
		PG_ThirdTimerFill.setExtent(50 + (83 * (mAbs(%this.powerupTimersDuration[%num] - mAbs(PlayGui.totalTime - %this.powerupTimersTimeActivated[%num])) / %this.powerupTimersDuration[%num])) SPC 62);
	} else {
		PG_ThirdTimerContainer.setVisible(false);
	}
	if (%this.powerupTimersTrueLength >= 4) {
		%num = %this.powerupTimersTrueIndexToFalse[3];
		%timer = %this.powerupTimersDuration[%num] - mAbs(PlayGui.totalTime - %this.powerupTimersTimeActivated[%num]);
		PG_FourthTimerContainer.setVisible(true);
		PG_FourthTimerContainer.setPosition(%x SPC %y + 240);
		PG_FourthTimerMeterText.setText("<just:center><font:24><color:000000>" @ roundToTenths(%timer));
		PG_FourthTimerMeterImage.setBitmap(specialBarFor(%this.powerupTimersId[%num]));
		PG_FourthTimerFill.setExtent(50 + (83 * (mAbs(%this.powerupTimersDuration[%num] - mAbs(PlayGui.totalTime - %this.powerupTimersTimeActivated[%num])) / %this.powerupTimersDuration[%num])) SPC 62);
	} else {
		PG_FourthTimerContainer.setVisible(false);
	}
}

function clientCmdPushTimer(%whichpowerup, %timer, %duration) {
	PlayGui.pushPowerupTimer(%whichpowerup, %timer, %duration);
}
function PlayGui::clearPowerupTimers(%this) {
	for (%i = 0; %i < %this.powerupTimersLength; %i ++) { // Cancel all the schedules.
		cancel(%this.powerupTimersSchedules[%i]);
	}
	%this.powerupTimersLength = 0;
	%this.powerupTimersTrueLength = 0;
}
function PlayGui::pushPowerupTimer(%this, %whichpowerup, %time, %duration) {
	if (!$pref::powerupTimers)
		return;
	%powerupAlreadyQueued = false;
	%powerupAlreadyQueuedIndex = 0;
	for (%i = 0; %i < %this.powerupTimersLength; %i ++) { // No duplicate IDs.
		if (%whichpowerup == %this.powerupTimersId[%i]) {
			%powerupAlreadyQueued = true;
			%powerupAlreadyQueuedIndex = %i;
			break;
		}
	}
	if (%powerupAlreadyQueued == false) {
		// If this was Fubar, we'd look for an open slot to put the timer in. There is no code for that though, since I've decided to use a system where there can be infinite queue length, but powerups won't be visually slotted earlier in the list.

		%this.powerupTimersLength ++;     // If you stacked like 10 powerups and the first 7 expired, the pointers to the 3 active powerups would be 7, 8, 9. That's what this Length variable is about. I pretty much have to do this, because I can't modify schedules after they're made, so instead, powerup timer schedules are stored as 'pointers' and the pointers can be changed.
		%this.powerupTimersTrueLength ++; // This is the amount of powerups truly active.

		%curIndex = %this.powerupTimersLength-1; // just to be safe, ++ and then -1, so this is 0 at first
		%this.powerupTimersId[%curIndex] = %whichpowerup;

		%trueIndex = %this.powerupTimersTrueLength-1;
		%this.powerupTimersTrueIndexToFalse[%trueIndex] = %curIndex;
		%this.powerupTimersFalseIndexToTrue[%curIndex] = %trueIndex;
		// It's a pair of lookup arrays.
		// Want the 3rd active powerup? It's %this.powerupTimersTrueIndexToFalse[2].

	} else { // making it a new schedule, we don't want the old one to pop
		%curIndex = %powerupAlreadyQueuedIndex;
		cancel(%this.powerupTimersSchedules[%curIndex]);
	}

	%this.powerupTimersTimeActivated[%curIndex] = PlayGui.totalTime;
	%this.powerupTimersDuration[%curIndex] = %duration;
	%this.powerupTimersSchedules[%curIndex] = %this.schedule(%duration, popPowerupTimer, %curIndex);
}

function PlayGui::popPowerupTimer(%this, %index) { // The powerup ID does not matter in this case.
	%this.powerupTimersId[%index] = -1;
	%this.powerupTimersTrueLength --;
	if (%this.powerupTimersTrueLength == 0) { // If there are no powerups, we can get rid of the whole powerup stack.
		%this.powerupTimersLength = 0;
	}
	// Offset the future true indexes -1.
	%trueIndex = %this.powerupTimersFalseIndexToTrue[%index];
	for (%i = %trueIndex; %i < %this.powerupTimersTrueLength; %i ++) {
		%this.powerupTimersFalseIndexToTrue[%this.powerupTimersTrueIndexToFalse[%i+1]] --;
		%this.powerupTimersTrueIndexToFalse[%i] = %this.powerupTimersTrueIndexToFalse[%i+1];
	}
}

// Look through up to the length and get the ones that are actually active. If there is nothing, set both the length and true length to 0.

//-----------------------------------------------------------------------------
// Elapsed Timer Display

function PlayGui::setTime(%this,%dt) {
	%this.currentTime = %dt;
	%this.updateControls();
}

function PlayGui::resetTimer(%this,%dt) {
	$PlayTimerColor = $TimeColor["stopped"];
	$PlayTimerFailedText = false;
	$PlayTimerAlarmText = false;
	%this.currentTime = 0;
	%this.bonusTime = 0;
	%this.totalBonus = 0;
	%this.totalTime = 0;
	$MP::BlastValue = 0;
	if ($BonusSfx !$= "") {
		alxStop($BonusSfx);
		$BonusSfx = "";
	}

	PG_Timer.setVisible(!$pref::Thousandths);
	PG_TimerThousands.setVisible($pref::Thousandths);

	%this.stopCountdown();
	%this.updateCountdown();
	%this.updateTimeTravelCountdown(); // main_gi v4.2.3
	%this.updateControls();
	%this.stopTimer();
}

function PlayGui::adjustTimer(%this,%dt) {
	%this.totalTime = add64_int(%this.totalTime, %dt);
	%this.currentTime = add64_int(%this.currentTime, %dt);
	%this.updateControls();
}

function PlayGui::setBonusTime(%this, %time) {
	%this.bonusTime = %time;
	if (alxIsPlaying($BonusSfx) && !%time)
		alxStop($BonusSfx);
	if ($BonusSfx $= "" && %time && !alxIsPlaying($PlayTimerAlarmHandle))
		$BonusSfx = alxPlay(TimeTravelLoopSfx);
}

function PlayGui::addBonusTime(%this, %dt) {
	%this.bonusTime = add64_int(%this.bonusTime, %dt);
	if ($BonusSfx $= "" && !alxIsPlaying($PlayTimerAlarmHandle))
		$BonusSfx = alxPlay(TimeTravelLoopSfx);
}

function PlayGui::refreshRed(%this) {
	if ($PlayTimerActive && $InPlayGUI) {
		if (%this.bonusTime || $Editor::Opened || %this.stopped)
			$PlayTimerColor = $TimeColor["stopped"];
		else {
			%dir = ClientMode::callback("timeMultiplier", 1);
			if (%dir > 0) {
				if (!MissionInfo.time || %this.currentTime < (MissionInfo.time - $PlayTimerAlarmStartTime)) {
					$PlayTimerColor = $TimeColor["normal"];
				} else if (%this.currentTime >= (MissionInfo.time - $PlayTimerAlarmStartTime) && %this.currentTime < MissionInfo.time) {
					if (!alxIsPlaying($PlayTimerAlarmHandle))
						$PlayTimerAlarmHandle = alxPlay(TimerAlarm);

					if (!$PlayTimerAlarmText) {
						%seconds = ($PlayTimerAlarmStartTime / 1000);
						addBubbleLine("You have " @ %seconds SPC (%seconds == 1 ? "second" : "seconds") SPC "left.", false, 5000);
						$PlayTimerAlarmText = true;
					}

					$PlayTimerColor = (((%this.currentTime / 1000) % 2) ? $TimeColor["danger"] : $TimeColor["normal"]);
				} else {
					if (alxIsPlaying($PlayTimerAlarmHandle))
						alxStop($PlayTimerAlarmHandle);

					if (!$PlayTimerFailedText) {
						addBubbleLine("The clock has passed the Par Time.", false, 5000);
						playPitchedSound("alarm_timeout");
						$PlayTimerFailedText = true;
					}
					$PlayTimerColor = $TimeColor["danger"];
				}
			} else if (%dir < 0) {
				$PlayTimerColor = $TimeColor["normal"];
				if (%this.currentTime <= $PlayTimerAlarmStartTime && %this.currentTime > 0) {
					if (!alxIsPlaying($PlayTimerAlarmHandle))
						$PlayTimerAlarmHandle = alxPlay(TimerAlarm);

					if (!$PlayTimerAlarmText) {
						%seconds = ($PlayTimerAlarmStartTime / 1000);
						addBubbleLine("You have " @ %seconds SPC (%seconds == 1 ? "second" : "seconds") SPC "left.", false, 5000);
						$PlayTimerAlarmText = true;
					}
					$PlayTimerColor = (((%this.currentTime / 1000) % 2) ? $TimeColor["danger"] : $TimeColor["normal"]);
				} else if (%this.currentTime == 0) {
					if (alxIsPlaying($PlayTimerAlarmHandle))
						alxStop($PlayTimerAlarmHandle);
					$PlayTimerColor = $TimeColor["stopped"];
				}
			}
		}
	}
}

function PlayGui::startTimer(%this) {
	$PlayTimerActive = true;
	if (MissionInfo.alarmStartTime)
		$PlayTimerAlarmStartTime = MissionInfo.AlarmStartTime * 1000;
	else
		$PlayTimerAlarmStartTime = 10000;
	%this.refreshRed();
}

// -----------------------------------------------------
// Doing this to hopefully save some CPU usage

$pitchMax =  1.5;
$pitchMin = -0.95;

package frameAdvance {
	function onFrameAdvance(%timeDelta) {
		Parent::onFrameAdvance(%timeDelta);

		// adjust yaw
		$cameraYaw += $mvYawLeftSpeed;
		$cameraYaw -= $mvYawRightSpeed;
		$cameraPitch += $mvPitchUpSpeed;
		$cameraPitch -= $mvPitchDownSpeed;

		// wrap yaw between -pi and pi
		while ($cameraYaw > $pi)
			$cameraYaw -= $tau;
		while ($cameraYaw < -$pi)
			$cameraYaw += $tau;

		// Engine-defined max/min pitch vars
		if ($cameraPitch < $pitchMin)
			$cameraPitch = $pitchMin;
		if ($cameraPitch > $pitchMax)
			$cameraPitch = $pitchMax;

		//Detect new marble
		%lastMarble = MPGetMyMarble();
		if (%lastMarble != $MP::LastMarble) {
			$MP::LastMarble = %lastMarble;
			if (isObject(%lastMarble)) {
				echo("New client marble detected: " @ %lastMarble);
				//TODO: Other things that need to happen?

				//Gotta reload all client side triggers because we exist now
				clientResetTriggerEntry();
			}
		}

		if (MPMyMarbleExists() && $mvTriggerCount0 & 1) {
			$MP::MyMarble._mouseFire();
		}

		playbackStep();

		if (RootGui.getContent().getName() $= "PlayGui")
			PlayGui.updateMessageHud();

		PlayGui.totalTime = add64_int(PlayGui.totalTime, %timeDelta);
		if ($PlayTimerActive) {
			PlayGui.updateTimer(%timeDelta);
		}

		PlayGui.updateSpeedometer();

		if (shouldUpdateBlast()) {
			clientUpdateBlast(%timeDelta);
		}

		if ($SpectateMode)
			interpolateCamera(%timeDelta);

		if (isObject($MP::MyMarble)) {
			if (isObject(GhostFollowSet) &&
			        ClientMode::callback("shouldGhostFollow", false)) {
				for (%i = 0; %i < GhostFollowSet.getCount(); %i ++) {
					%obj = GhostFollowSet.getObject(%i);

					//Tell the mode
					if (!ClientMode::callback("updateGhostFollow", false, %obj)) {
						//Make it follow: default behavior
						%obj.setTransform($MP::MyMarble.getTransform());
					}
				}
			}
		}
		MPupdateHats();

		ClientMode::callBack("onFrameAdvance", "", %timeDelta);

		//Cannon
		updateCannon(%timeDelta);

		if ($Client::MovingObjectsActive) {
			updateClientMovingObjects(%timeDelta);
			updateClientParentedObjects(%timeDelta);
		}

		// trigger collision checks
		clientTriggerCollisionTest();

		// water
		updateClientWater();
		BubbleLoop(%timeDelta);

		updateItemCollision();
		Gravity::update();

		updateEmitterPositions();

		updateMessages(%timeDelta);

		if ($Game::ScriptCameraTransform) {
			PG_ShowCtrl.setCameraTransform(getScriptCameraTransform());
			PG_SaveMyBaconCtrl.setCameraTransform(getScriptCameraTransform());
		}

		//Fireball
		if ($Client::FireballActive) {
			PlayGui.updateFireballBar();
		}
		PlayGui.updateBarPositions();

		if ($Record::Recording) {
			recordLoop(%timeDelta);
		}

		// radar
		RadarLoop();

		if ($Server::ServerType $= "MultiPlayer") {
			updateNameTags();
		}

		//Missions
		clientCbOnFrameAdvance(%timeDelta);
	}
};
activatePackage(frameAdvance);

// -----------------------------------------------------

function PlayGui::stopTimer(%this) {
	$PlayTimerColor = $TimeColor["stopped"];
	if (alxIsPlaying($PlayTimerAlarmHandle))
		alxStop($PlayTimerAlarmHandle);

	$PlayTimerActive = false;
	%this.updateControls();
	if ($BonusSfx !$= "") {
		alxStop($BonusSfx);
		$BonusSfx = "";
	}
}

function PlayGui::setTimeStopped(%this, %stopped) {
	%this.stopped = %stopped;

	echo("Time stop:" SPC %stopped);

	if (%stopped) {
		if ($BonusSfx $= "" && !alxIsPlaying($PlayTimerAlarmHandle))
			$BonusSfx = alxPlay(TimeTravelLoopSfx);
	}

	%this.refreshRed();
}

function PlayGui::updateTimer(%this, %timeInc) {
	if (%this.stopped) {
		// HACK: If inside Time Stop trigger, keep time stopped by adding bonus time
		%this.bonusTime = add64_int(%this.bonusTime, %timeInc);
	}

	//Countdown isn't affected by time travels so do it first
	%this.updateCountdown(%timeInc);

	if (%this.bonusTime) {
		if (%this.bonusTime > %timeInc) {
			%this.bonusTime -= %timeInc;
			%this.totalBonus = add64_int(%this.totalBonus, %timeInc);
			%timeInc = 0;
		} else {
			%timeInc -= %this.bonusTime;
			%this.totalBonus = add64_int(%this.totalBonus, %this.bonusTime);
			%this.bonusTime = 0;
		}
	}
	%this.updateTimeTravelCountdown(); // main_gi v4.2.3
	if (!%this.stopped && !%this.bonusTime) {
		alxStop($BonusSfx);
		$BonusSfx = "";
	}
	%this.allTTime = add64_int(%this.allTTime, %timeInc);

	%mult = ClientMode::callback("timeMultiplier", 1);
	%this.currentTime = add64_int(%this.currentTime, %timeInc * %mult);

	// Some sanity checking
	if (%this.currentTime > 5999999)
		%this.currentTime = 5999999;

	if (%this.currentTime <= 0 && !$Editor::Opened) {
		%this.currentTime = 0;
		if (alxIsPlaying($PlayTimerAlarmHandle))
			alxStop($PlayTimerAlarmHandle);
	}

	%this.updateControls();
}

function clientCmdUpdateTimeTravelCountdown() {
	// main_gi v4.2.3: By default, the color DOESN'T change to green properly if you get a TT timer during the start phase, if you end the level with a TT, or if you enter a timestop with a TT. So this function is called in /server/powerups.cs (TimeTravelItem::onPickup), /server/triggers.cs (TimeStopTrigger), /server/game.cs (endGameSetup).
	PlayGui.updateTimeTravelCountdown();
}

function PlayGui::updateTimeTravelCountdown(%this) {
	if ($pref::HideTimeTravelTimer) {
		PGCountdownTT.setVisible(false);
		return;
	}
	%timeUsed = %this.bonusTime + 99; // When you pick up a 5s timer, it should start by displaying 5.0, instead of 4.9. This also prevents the TT timer from showing 0.0. But if you add 100, picking up a 5s timer can show "5.1". Turns out adding 99 actually works perfectly here.
	%secondsLeft = mFloor(%timeUsed/1000);
	%tenths = mFloor(%timeUsed/100) % 10;

	%one = mFloor(%secondsLeft) % 10;
	%ten = mFloor(%secondsLeft / 10) % 10;
	%hun = mFloor(%secondsLeft / 100);

	%color = (%this.stopped || $PlayTimerActive == 0) ? $TimeColor["stopped"] : $TimeColor["normal"]; // can try $Game::TimeStoppedClients >= 1

	%offsetIfThousandths = $pref::Thousandths? 5:0;
	if (%secondsLeft < 10) {
		PGCountdownTTFirstDigit.setNumberColor(%one, %color);
		PGCountdownTTThirdDigitOrDecimal.setNumberColor(%tenths, %color);
		PGCountdownTTThirdDigitOrDecimal.setPosition("397" + %offsetIfThousandths SPC "0");
	} else if (%secondsLeft < 100) {
		PGCountdownTTFirstDigit.setNumberColor(%ten, %color);
		PGCountdownTTSecondDigit.setNumberColor(%one, %color);
		PGCountdownTTThirdDigitOrDecimal.setNumberColor(%tenths, %color);
		PGCountdownTTThirdDigitOrDecimal.setPosition("413" + %offsetIfThousandths SPC "0");
	} else if (%secondsLeft < 999) {
		PGCountdownTTFirstDigit.setNumberColor(%hun, %color);
		PGCountdownTTSecondDigit.setNumberColor(%ten, %color);
		PGCountdownTTThirdDigitOrDecimal.setNumberColor(%one, %color);
		PGCountdownTTThirdDigitOrDecimal.setPosition("407" + %offsetIfThousandths SPC "0");
	} else {
		PGCountdownTTFirstDigit.setNumberColor(9, %color);
		PGCountdownTTSecondDigit.setNumberColor(9, %color);
		PGCountdownTTThirdDigitOrDecimal.setNumberColor(9, %color);
		PGCountdownTTThirdDigitOrDecimal.setPosition("407" + %offsetIfThousandths SPC "0");
	}
	
	PGCountdownTTImage.setPosition("348" + %offsetIfThousandths SPC "3");
	PGCountdownTTFirstDigit.setPosition("375" + %offsetIfThousandths SPC "0");
	PGCountdownTTSecondDigit.setPosition("391" + %offsetIfThousandths SPC "0");

	PGCountdownTTPoint.setNumberColor("point", %color);
	PGCountdownTTPoint.setVisible(!(%secondsLeft >= 100));
	PGCountdownTTPoint.setPosition((%secondsLeft >= 10 ? "403" : "388") + %offsetIfThousandths SPC "0");

	PGCountdownTTSecondDigit.setVisible(%secondsLeft >= 10);
	PGCountdownTT.setVisible(%this.bonusTime);
}

function PlayGui::updateControls(%this) {
	%this.refreshRed();

	%et = %this.currentTime;
	%drawNeg = false;
	if (%et < 0) {
		%et = - %et;
		%drawNeg = true;
	}

	%hundredth = div64_int(mod64_int(%et, 1000), 10);
	%totalSeconds = div64_int(%et, 1000);
	%seconds = mod64_int(%totalSeconds, 60);
	%minutes = div64_int(sub64_int(%totalSeconds, %seconds), 60);

	%secondsOne      = %seconds % 10;
	%secondsTen      = (%seconds - %secondsOne) / 10;
	%minutesOne      = %minutes % 10;
	%minutesTen      = (%minutes - %minutesOne) / 10;
	%hundredthOne    = %hundredth % 10;
	%hundredthTen    = (%hundredth - %hundredthOne) / 10;
	%thousandth      = mod64_int(%et, 10);

	if ($pref::Thousandths) {
		// Update the controls
		Min_Ten_Th.setTimeNumber(%minutesTen);
		Min_One_Th.setTimeNumber(%minutesOne);
		Sec_Ten_Th.setTimeNumber(%secondsTen);
		Sec_One_Th.setTimeNumber(%secondsOne);
		Sec_Tenth_Th.setTimeNumber(%hundredthTen);
		Sec_Hundredth_Th.setTimeNumber(%hundredthOne);
		Sec_Thousandth_Th.setTimeNumber(%thousandth);
		PG_NegSign_Th.setVisible(%drawNeg);

		MinSec_Colon_Th.setTimeNumber("colon");
		MinSec_Point_Th.setTimeNumber("point");
	} else {
		// Update the controls
		Min_Ten.setTimeNumber(%minutesTen);
		Min_One.setTimeNumber(%minutesOne);
		Sec_Ten.setTimeNumber(%secondsTen);
		Sec_One.setTimeNumber(%secondsOne);
		Sec_Tenth.setTimeNumber(%hundredthTen);
		Sec_Hundredth.setTimeNumber(%hundredthOne);
		PG_NegSign.setVisible(%drawNeg);

		MinSec_Colon.setTimeNumber("colon");
		MinSec_Point.setTimeNumber("point");
	}

	ClientMode::callback("updateControls", "");
}

//-----------------------------------------------------------------------------

$numberPaths[0] = $userMods @ "/client/ui/game/numbers/0.png";
$numberPaths[1] = $userMods @ "/client/ui/game/numbers/1.png";
$numberPaths[2] = $userMods @ "/client/ui/game/numbers/2.png";
$numberPaths[3] = $userMods @ "/client/ui/game/numbers/3.png";
$numberPaths[4] = $userMods @ "/client/ui/game/numbers/4.png";
$numberPaths[5] = $userMods @ "/client/ui/game/numbers/5.png";
$numberPaths[6] = $userMods @ "/client/ui/game/numbers/6.png";
$numberPaths[7] = $userMods @ "/client/ui/game/numbers/7.png";
$numberPaths[8] = $userMods @ "/client/ui/game/numbers/8.png";
$numberPaths[9] = $userMods @ "/client/ui/game/numbers/9.png";
$numberPaths["point"] = $userMods @ "/client/ui/game/numbers/point.png";
$numberPaths["colon"] = $userMods @ "/client/ui/game/numbers/colon.png";
$numberPaths["dash"] = $userMods @ "/client/ui/game/numbers/dash.png";
$numberPaths["slash"] = $userMods @ "/client/ui/game/numbers/slash.png";

// function GuiBitmapCtrl::setNumber(%this,%number) {
// 	%this.setBitmap($numberPaths[%number]);
// }
// function GuiBitmapCtrl::setTimeNumber(%this,%number) {
// 	%this.setBitmap($numberPaths[%number]);
// 	%this.bitmapColor = $PlayTimerColor;
// }
// function GuiBitmapCtrl::setNumberColor(%this,%number,%color) {
// 	%this.setBitmap($numberPaths[%number]);
// 	%this.bitmapColor = %color;
// }

//-----------------------------------------------------------------------------

function refreshBottomTextCtrl() {
	BottomPrintText.position = "0 0";
}

function refreshCenterTextCtrl() {
	CenterPrintText.position = "0 0";
}

//-----------------------------------------------------------------------------

function PlayGui::displayGemMessage(%this, %amount, %color) {
	%startCenter = VectorMult(%this.getExtent(), "0.5 0.5");
	%startPos = VectorSub(%startCenter, "200 50");
	%this.add(%obj = new GuiMLTextCtrl() {
		profile = "GemCollectionMessageProfile";
		horizSizing = "center";
		vertSizing = "center";
		position = %startPos;
		extent = "400 100";
		minExtent = "8 8";
		visible = "1";
		helpTag = "0";
		lineSpacing = "2";
		allowColorChars = "0";
		maxChars = "-1";
	});

	if (%color $= "")
		%color = "ffcc66";

	%font = "<font:" @ $DefaultFont["PointPopups"] @ ":48>";
	%obj.setText("<just:center>" @ %font @ "<color:" @ %color @ ">" @ shadow("1 1", "0000007f") @ %amount);
	%this.updateGemMessage(%obj);
	%obj.schedule(700, "delete");
}

function PlayGui::updateGemMessage(%this, %obj, %num) {
	if (%num >= 60 || !isObject(%obj))
		return;
	if (%num > 30) {
		%obj.setAlpha(1 - (%num - 30) / 30);
	}
	%obj.setPosition(VectorSub(%obj.getPosition(), "0 1"));

	%this.schedule(10, updateGemMessage, %obj, %num + 1);
}

//-----------------------------------------------------------------------------

function PlayGui::updateLaps(%this) {
	%completeOne = (%this.lapsComplete % 10);
	%totalOne = (%this.lapsTotal % 10);

	%color = (%this.lapsComplete >= %this.lapsTotal ? $TimeColor["stopped"] : $TimeColor["normal"]);

	PGLapsOneComplete.setNumberColor(%completeOne, %color);
	PGLapsOneTotal.setNumberColor(%totalOne, %color);
	PGLapsSlash.setNumberColor("slash", %color);

	PGLapsLabel.setBitmap("platinum/client/ui/game/laps/laps_label");
}

function PlayGui::setLapsComplete(%this, %complete) {
	%this.lapsComplete = %Complete;
	%this.updateLaps();
}

function PlayGui::setLapsTotal(%this, %total) {
	%this.lapsTotal = %total;
	%this.updateLaps();
}

//-----------------------------------------------------------------------------

function PlayGui::showEggTime(%this, %time) {
	%pq = ($CurrentGame $= "PlatinumQuest" || ($CurrentGame $= "Custom" && $MissionType $= "PlatinumQuest") || MissionInfo.game $= "PlatinumQuest");

	PG_EggIcon.setBitmap("platinum/client/ui/play/egg" @ (%pq ? "_pq_big" : "_mbp_big"));
	PG_EggTimeBox.setVisible(true);
	PG_EggTimeDisplay.setText("<color:" @ (%pq ? "cccc99" : "4580ff") @ "><shadow:1:1><shadowcolor:0000007f><bold:28>" @ formatTime(%time));

	%this.showingEggTime = true;
	%this.updateEggTime();

	//Because I know SOMEONE will put in two eggs really close and then laugh
	// when it bugs out.
	cancel(%this.hideEggSch);
	%this.hideEggSch = %this.schedule(5000, hideEggTime);
}

function PlayGui::updateEggTime(%this) {
	%down = ($Game::isMode["laps"] || %this.runningCountdown);
	PG_EggTimeBox.setPosition(getWord(PG_EggTimeBox.position, 0) SPC (%down ? 100 : 60));
}

function PlayGui::hideEggTime(%this) {
	%this.showingEggTime = false;
	cancel(%this.hideEggSch);
	PG_EggTimeBox.setVisible(false);
}

//-----------------------------------------------------------------------------

function PlayGui::startCountdown(%this, %time, %image) {
	PGCountdownImage.setBitmap("platinum/client/ui/game/countdown/" @ %image);
	PGCountdownThImage.setBitmap("platinum/client/ui/game/countdown/" @ %image);
	%this.countdownTime = %time;
	%this.runningCountdown = %time > 0;

	if (%this.showingEggTime) {
		%this.updateEggTime();
	}
}

function PlayGui::stopCountdown(%this) {
	%this.runningCountdown = false;

	if (%this.showingEggTime) {
		%this.updateEggTime();
	}
}

function PlayGui::updateCountdown(%this, %delta) {
	%this.countdownTime = sub64_int(%this.countdownTime, %delta);

	%visible = (%this.countdownTime > -5000);
	if (!%visible) {
		%this.runningCountdown = false;
	}
	PGCountdownTimer.setVisible(%this.runningCountdown && !$pref::Thousandths);
	PGCountdownThTimer.setVisible(%this.runningCountdown && $pref::Thousandths);

	if (%this.runningCountdown) {
		%et = %this.countdownTime;
		if (%et < 0) {
			%et = 0;
			%color = $TimeColor["stopped"];
		} else {
			%color = $TimeColor["normal"];
		}

		%hundredth = mFloor((%et % 1000) / 10);
		%totalSeconds = mFloor(%et / 1000);
		%seconds = %totalSeconds % 60;
		%minutes = (%totalSeconds - %seconds) / 60;

		%secondsOne      = %seconds % 10;
		%secondsTen      = (%seconds - %secondsOne) / 10;
		%minutesOne      = %minutes % 10;
		%minutesTen      = (%minutes - %minutesOne) / 10;
		%hundredthOne    = %hundredth % 10;
		%hundredthTen    = (%hundredth - %hundredthOne) / 10;
		%thousandth      = %et % 10;

		if ($pref::Thousandths) {
			PGCountdownThMinTen.setNumberColor(%minutesTen, %color);
			PGCountdownThMinOne.setNumberColor(%minutesOne, %color);
			PGCountdownThSecTen.setNumberColor(%secondsTen, %color);
			PGCountdownThSecOne.setNumberColor(%secondsOne, %color);
			PGCountdownThSecTens.setNumberColor(%hundredthTen, %color);
			PGCountdownThSecHundredths.setNumberColor(%hundredthOne, %color);
			PGCountdownThSecThousandths.setNumberColor(%thousandth, %color);
			PGCountdownThMinSecColon.setNumberColor("colon", %color);
			PGCountdownThMinSecPoint.setNumberColor("point", %color);
		} else {
			PGCountdownMinTen.setNumberColor(%minutesTen, %color);
			PGCountdownMinOne.setNumberColor(%minutesOne, %color);
			PGCountdownSecTen.setNumberColor(%secondsTen, %color);
			PGCountdownSecOne.setNumberColor(%secondsOne, %color);
			PGCountdownSecTens.setNumberColor(%hundredthTen, %color);
			PGCountdownSecHundredths.setNumberColor(%hundredthOne, %color);
			PGCountdownMinSecColon.setNumberColor("colon", %color);
			PGCountdownMinSecPoint.setNumberColor("point", %color);
		}
	}
}

function PlayGui::updateRtaSpeedrunTimer(%this, %text) {
	PG_RtaSpeedrunTimer.setText("<condensed:48><color:FFFFFF><shadow:2:2><shadowcolor:777777>" @ %text);
}
