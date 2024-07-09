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

//----------------------------------------------------------------------------
// Enter Chat Message Hud
//----------------------------------------------------------------------------

function PlayGui::positionMessageHud(%this) {
	//Sizing variables
	%w             = getWord(%this.getExtent(), 0);
	%h             = getWord(%this.getExtent(), 1);
	%mp            = (lb() || ($PlayingDemo && $demoLB)) && $Server::ServerType $= "Multiplayer";
	%ultra         = MissionInfo.game $= "Ultra";
	%isEndGame     = (isObject(EndGameDlg.getGroup()) && EndGameDlg.getGroup().getName() $= "Canvas");
	%hideChat      = $pref::ScreenshotMode > 0 || %isEndGame || isCannonActive();
	%hideAll       = $pref::ScreenshotMode == 2;

	%height = 60 + (20 * $LBPref::ChatMessageSize); // From 80 - 160

	%chatWidth = %w;
	%chatStartX = 0;

	%chatHeight = %height - 60; // Originally just -60

	%entryStart = (%mp || %ultra) && $chathud ? 135 : 0;

	//Resize the FPS meter
	%fps_w = (lb() ? 118 : 96);
	%fps_h = 32;

	//Width of individual chat scrolls
	%chatboxWidth = %chatWidth;
	if (%mp) {
		if ($MP::TeamMode)
			%chatboxWidth /= 3;
		else
			%chatboxWidth /= 2;
	}

	if (lb()) {
		LBMessageHudDlg.setExtent(PlayGui.getExtent());

		PG_LBChatBackground.resize(0, %h - %height, %w, %height);
		PG_LBChatTextPanel.resize(%chatStartX, 0, %chatWidth, %height);
		PG_LBChatText.setPosition(1, -(getWord(PG_LBChatText.getExtent(), 1)));
		PG_ServerChatScroll.setVisible($Server::ServerType $= "Multiplayer");

		%pad = 1;

		PG_LBChatScroll.setWidth(%chatboxWidth - %pad);
		PG_ServerChatScroll.setWidth(%chatboxWidth - %pad);
		PG_ServerChatScroll.setPosition((%chatboxWidth + %pad) SPC 0);
		PG_TeamChatScroll.setWidth(%chatboxWidth - (%pad * 2));
		PG_TeamChatScroll.setPosition(((%chatboxWidth + %pad) * 2) SPC 0);
		PG_ChatSeparator0.setPosition((%chatboxWidth + %pad) SPC 0);
		PG_ChatSeparator0.setVisible(%mp);
		PG_ChatSeparator1.setPosition((%chatboxWidth * 2) SPC 0);
		PG_ChatSeparator1.setVisible(%mp && $MP::TeamMode);
		PG_TeamChatScroll.setVisible(%mp && $MP::TeamMode);

		if (%hideChat) {
			RootGui.popDialog(LBMessageHudDlg);
		} else if (RootGui.getContent().getName() $= "PlayGui") {
			RootGui.pushDialog(LBMessageHudDlg);
			//Otherwise it will try to focus the textfield
			disableChatHUD();
		}
	}
	PlayGuiContent.setVisible(!(%hideAll || %isEndGame));
	PG_RadarContent.setVisible(!(%hideAll || %isEndGame) || $pref::EnableRadarEvenIfUIOff);
	PG_AchievementListBox.setVisible(!%hideAll);
	PG_BlastBar.setVisible(shouldEnableBlast());
	%blastY = getWord(VectorSub(PlayGui.getExtent(), (lb() && !%hideChat ? "0" SPC (35 + (20 * $LBPref::ChatMessageSize)) : "0 35")), 1);
	PG_BlastBar.setPosition(6 SPC %blastY);

	PG_MessageListBox.setHeight(%h - (lb() && !%hideChat ? (20 * $LBPref::ChatMessageSize) + 100 : 100) - (shouldEnableBlast() ? 34 : 0));

	%this.updateMessageHud();
}

function PlayGui::updateMessageHud(%this) {
	showSpectatorMenu($SpectateMode);

	%lb = lb();
	//Sizing variables
	%w             = getWord(%this.getExtent(), 0);
	%h             = getWord(%this.getExtent(), 1);
	%mp            = (%lb || ($PlayingDemo && $demoLB)) && $Server::ServerType $= "Multiplayer";
	%ultra         = MissionInfo.game $= "Ultra";
	%isEndGame     = (isObject(EndGameDlg.getGroup()) && EndGameDlg.getGroup().getName() $= "Canvas");
	%hideChat      = $pref::ScreenshotMode > 0 || %isEndGame || isCannonActive();

	%height = 60 + (20 * $LBPref::ChatMessageSize); // From 80 - 160

	%chatWidth = %w;
	%chatStartX = 0;

	%chatHeight = %height - 60;

	%entryStart = (%mp || %ultra) && $chathud ? 135 : 0;

	if ($SpectateMode) {
		%entryStart += 175;
	}

	//Resize the FPS meter
	%fps_w = (%lb && !%hideChat ? 118 : 96);
	%fps_h = 32;

	if (%lb && !%hideChat)
		FPSMetreCtrl.resize(%w - %fps_w, %h - %fps_h - %chatHeight, %fps_w, %fps_h);
	else
		FPSMetreCtrl.resize(%w - %fps_w, %h - %fps_h, %fps_w, %fps_h);

	//Fix the bitmap
	%bmp = %lb && !%hideChat ? ($usermods @ "/client/ui/lb/play/pc_trans/fps") : ($usermods @ "/client/ui/game/transparency_fps-flipped");
	if (FPSMetreBitmap.bitmap !$= %bmp)
		FPSMetreBitmap.setBitmap(%bmp);

	FPSMetreBitmap.resize(0, 0, %fps_w, %fps_h);

	//Width of individual chat scrolls
	%chatboxWidth = %chatWidth;
	if (%lb) {
		if (%mp) {
			// The original line is:
			// FPSMetreText.resize(%lb && !%mp && !%hideChat ? 20 : 10, %lb && !%mp && !%hideChat ? 10 : 3, 106, 28);
			FPSMetreText.resize(10, 3, 106, 28); // Because %mp is on
			if ($MP::TeamMode) {
				%chatboxWidth /= 3;
			} else {
				%chatboxWidth /= 2;
			}
		} else {
			FPSMetreText.resize(!%hideChat ? 20 : 10, !%hideChat ? 10 : 3, 106, 28);
		}
		%shadowStart = 0;
		if ($SpectateMode)
			%shadowStart = 302;

		PG_SpectatorMenu.resize(0, (%h - %height) - 90, 302, 150);
		PG_SpectatorWindow.resize(0, 0, 302, 150);

		if ($pref::showFPSCounter) {
			PG_LBTopShadow.resize(%shadowStart, 52, ($chathud ? %entryStart : %chatWidth - %fps_w) - %shadowStart, 8);
			if ($chathud) {
				PG_LBChatEntryContainer.resize(%entryStart, 15, %chatWidth -%fps_w - %entryStart, 45);
			}
		} else {
			PG_LBTopShadow.resize(%shadowStart, 52, ($chathud ? %entryStart : %chatWidth - %entryStart) - %shadowStart, 8);
			if ($chathud) {
				PG_LBChatEntryContainer.resize(%entryStart, 15, %chatWidth - %start, 45);
			}
		}

		LBScrollChat();

		%pad = 1;
		PG_ChatSeparator0.setPosition((%chatboxWidth + %pad) SPC 0);
		PG_ChatSeparator0.setVisible(%mp);
		PG_ChatSeparator1.setPosition((%chatboxWidth * 2) SPC 0);
		PG_ChatSeparator1.setVisible(%mp && $MP::TeamMode);
		PG_TeamChatScroll.setVisible(%mp && $MP::TeamMode);

		%pad = "1 2";
		%shift = "0 60";

		%pos0 = 0;
		%pos1 = getWord(PG_ChatSeparator0.getPosition(), 0);
		%pos2 = getWord(PG_ChatSeparator1.getPosition(), 0);
		%pos3 = getWord(Canvas.getExtent(), 0);

		switch$ ($chatHudType) {
		case "global":
			PG_SelectedChatHighlight.resize(%pos0, 60, %pos1 - %pos0 + 1, getWord(PG_LBChatScroll.getExtent(), 1) + 1);
		case "private":
			PG_SelectedChatHighlight.resize(%pos1, 60, %pos2 - %pos1 + 1, getWord(PG_LBChatScroll.getExtent(), 1) + 1);
		case "team":
			PG_SelectedChatHighlight.resize(%pos2, 60, %pos3 - %pos2 + 1, getWord(PG_LBChatScroll.getExtent(), 1) + 1);
		}
	} else {
		FPSMetreText.resize(10, 3, 106, 28); // Because %lb is off
	}
}

function LBscrollChat() {
	if (isObject(PG_LBChatScroll)) {
		if (RootGui.getContent().getName() $= "PlayGui" && LBMessageHudDlg.isAwake()) {
			PG_LBChatText.forceReflow();
			PG_ServerChatText.forceReflow();
		}
		PG_LBChatScroll.scrollToBottom();
		PG_LBChatScroll.schedule(100, scrollToBottom);
		PG_LBChatScroll.schedule(1000, scrollToBottom);
		PG_ServerChatScroll.scrollToBottom();
		PG_ServerChatScroll.schedule(100, scrollToBottom);
		PG_ServerChatScroll.schedule(1000, scrollToBottom);
		PG_TeamChatScroll.scrollToBottom();
		PG_TeamChatScroll.schedule(100, scrollToBottom);
		PG_TeamChatScroll.schedule(1000, scrollToBottom);
	}
}

//------------------------------------------------------------------------------

function PlayGui::sendChat(%this) {
	%message = trim(PG_LBChatEntry.getValue());
	devecho("Send chat: " @ %message);

	switch$ ($chatHudType) {
	case "private":
		mpSendChat(%message);
	case "global":
		%line = strlwr(%message); // used for comparisons
		%dest = (getWord(%line,0) $= "/whisper") ? getWord(%message,1) : "";
		LBSendChat(%message, %dest);
	case "team":
		teamSendChat(%message);
	}
	PG_LBChatEntry.setValue("");
	LBSetChatMessage("", PG_LBChatEntry);
	disableChatHUD();
}

function PlayGui::chatUpdate(%this) {
	%message = PG_LBChatEntry.getValue();

	if (getSubStr(%message, 0, 3) $= "@@@") {
		%message = "/whisper" SPC $LB::LastWhisper SPC ltrim(getSubStr(%message, 3, strLen(%message)));
	}
	if (getSubStr(%message, 0, 2) $= "@@" && strLen(%message) > 2) {
		%message = "/whisper " @ ltrim(getSubStr(%message, 2, strLen(%message)));
	}
	//Strip control characters from chat
	%message = stripChars(%message, "\x01\x02\x03\x04\x05\x06\x07\x08\x09\x0a\x0b\x0c\x0d\x0e\x0f\x10\x11\x12\x13\x14\x15\x16\x17\x18\x19\x1a\x1b\x1c\x1d\x1e\x1f");

	//Update all chat
	LBSetChatMessage(%message, PG_LBChatEntry);

	if (PG_LBChatEntry.getValue() !$= %message) {
		PG_LBChatEntry.setValue(%message);
	}

	PG_LBChatEntry.setPosition("65" SPC (34 - getWord(PG_LBChatEntry.getExtent(), 1)));
}

//----------------------------------------------------------------------------
// MessageHud key handlers

function toggleChatHUD(%make) {
	// Only when they push down the button
	if (%make) {
		if ($LB::Guest)
			return;
		if (!$LB::GlobalChatEnabled)
			return;
		$chatHudType = "global";
		PlayMissionGui.chatPanel = "global";
		if ($chatHud)
			disableChatHUD();
		else
			enableChatHUD();
	}
}

function togglePrivateChatHUD(%make) {
	// Only when they push down the button
	if (%make && $Server::ServerType $= "MultiPlayer") {
		$chatHudType = "private";
		PlayMissionGui.chatPanel = "server";
		if ($chatHud)
			disableChatHUD();
		else
			enableChatHUD();
	}
}

function toggleTeamChatHUD(%make) {
	// Only when they push down the button
	if (%make && $Server::ServerType $= "MultiPlayer" && $MP::TeamMode) {
		$chatHudType = "team";
		PlayMissionGui.chatPanel = "team";
		if ($chatHud)
			disableChatHUD();
		else
			enableChatHUD();
	}
}

function disableChatHUD(%remove) {
	if (%remove) {
		PG_LBChatEntry.setValue("");
		LBSetChatMessage("", PG_LBChatEntry);
	}

//   echo("DISABLING CHATHUD");
	PG_LBChatEntryContainer.setVisible(false);
	PG_LBChatEntry.makeFirstResponder(false);

	PG_SelectedChatHighlight.setVisible(false);
	PG_LBExtraMessageHighlight.setVisible(false);

	PG_LBChatText.setAlpha(1);
	PG_ServerChatText.setAlpha(1);
	PG_TeamChatText.setAlpha(1);

	// We want to place the chat behind everything BUT PlayGui
	%cont = RootGui.getContent();

	// Bring to front actually sends it to back... who wrote this function?
	Canvas.bringToFront(LBMessageHudDlg);
	Canvas.bringToFront(%cont);
	Canvas.bringToFront(RootGui);

	$chatHud = false;

	if ($pref::ScreenshotMode > 0) {
		//Hide chat entirely
		RootGui.popDialog(LBMessageHudDlg);
	}
}

function enableChatHUD() {
	//echo("ENABLING CHATHUD");
	PG_LBChatEntry.setTickable(true);
	// only lbs
	if (!$LB::LoggedIn || $LB::username $= "")
		return;
	PG_LBChatEntryContainer.setVisible(true);

	if ($Server::ServerType $= "MultiPlayer") {
		PG_SelectedChatHighlight.setVisible(true);
		PG_LBExtraMessageHighlight.setVisible(true);
	}

	%chatType = "Global";
	switch$ ($chatHudType) {
	case "global":
		%chatType = "Global";
		PG_LBChatText.setAlpha(1);
		PG_ServerChatText.setAlpha(0.4);
		PG_TeamChatText.setAlpha(0.4);
	case "private":
		%chatType = "Server";
		PG_LBChatText.setAlpha(0.4);
		PG_ServerChatText.setAlpha(1);
		PG_TeamChatText.setAlpha(0.4);
	case "team":
		%chatType = "Team";
		PG_LBChatText.setAlpha(0.4);
		PG_ServerChatText.setAlpha(0.4);
		PG_TeamChatText.setAlpha(1);
	}

	PG_LBChatEntryText.setText("<bold:24><color:555555>" @ %chatType @ ":");

	if (LBMessageHudDlg.getGroup().getId() == Canvas.getId()) {
		// We want to place the chat in front of everything
		// Push to back actually brings it to the front. Seriously.
		Canvas.pushToBack(LBMessageHudDlg);
	} else {
		//Need to show the dialog first!
		RootGui.pushDialog(LBMessageHudDlg);
	}

	PG_LBChatEntry.makeFirstResponder(true);
	$chatHud = true;

	PlayGui.updateMessageHud();
}
