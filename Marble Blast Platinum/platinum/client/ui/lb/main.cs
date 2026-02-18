//-----------------------------------------------------------------------------
// main.cs
//
// this file holds core material for the leaderboards
//
// Leaderboard Variable namespace: $LB::*
// Pref Leaderboard Variable namespace: $LBPref::*
//
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

// core function for loading leaderboards
function initLeaderboards() {

	// Unload all marbleland packages or else bruh shit happens
	marblelandUnloadMissions();

	// delete old leaderboard stuff before making a new one
	doCloseLeaderboards();

	if ($Game::Offline)
		return;

	if ($Game::Menu) {
		menuDestroyServer();
		menuSetMission($Menu::MissionFile);
	}

	exec("./LBMessageGui.gui");
	LBMessage("Loading PlatinumQuest Online...");
	Canvas.repaint();

	//Kill this because secrets are more fun
	trace(false);
	%letters = "a"@"b"@"c"@"d"@"e"@"f"@"g"@"h"@"i"@"j"@"k"@"l"@"m"@"n"@"o"@"p"@"q"@"r"@"s"@"t"@"u"@"v"@"w"@"x"@"y"@"z"@"A"@"B"@"C"@"D"@"E"@"F"@"G"@"H"@"I"@"J"@"K"@"L"@"M"@"N"@"O"@"P"@"Q"@"R"@"S"@"T"@"U"@"V"@"W"@"X"@"Y"@"Z"@"1"@"2"@"3"@"4"@"5"@"6"@"7"@"8"@"9"@"0"@"."@"-"@"\'"@"\""@"["@"]"@","@"("@")"@"!"@"$"@"&"@"^"@"#"@"@"@"+"@"="@"-"@"_"@";";
	%crcdata = call("q"@"u"@"e"@"r"@"y"@"S"@"H"@"A");

	// if (getField(%crcdata, 0) != 0 || getField(%crcdata, 1) !$= ("c"@"r"@"c"@"G"@"o"@"o"@"d")) {
	// 	//Blow up here
	// 	exec("./LBErrorHandlerDlg.gui");
	// 	LBAssert("Redundancy Error!", "It appears one or more game files have been modified. PlatinumQuest Online requires that no modifications have been made to the game files. If this was done either by you or a virus, please check for affected files in the launcher log.\n\nAffected file:" SPC getField(%crcData, 1), "closeLeaderboards(); RootGui.setContent(MainMenuGui); alxStop($LBNope); ");
	// 	alxStopAll();
	// 	$LBNope = alxPlay(LBNope);
	// 	return;
	// }

	devecho("Initilizing leaderboards in PlatinumQuest");
	initLBConstants(); // grab core constants

	// Guis
	exec("./LBLoginGui.gui");
	exec("./LBChatGui.gui");

	// dialogs
	exec("./LBErrorHandlerDlg.gui");
	exec("./LBStatsDlg.gui");
	exec("./LBRegisterDlg.gui");
	exec("./LBScoresDlg.gui");
	exec("./LBUserDlg.gui");
	exec("./LBTermsDlg.gui");
	exec("./LBMessageHudDlg.gui");
	exec("./LBAchievementsDlg.gui");

	// scripts
	exec("./socket.cs");
//   exec("./pauseGame.cs");

	// Used for quickie reference. Do *not* rely on this!
	$LB = 1;
	$LB::JustLoggedIn = false;

	// now show the login gui, as everything has loaded
	switch$ ($LBPref::AutoLogin) {
	case "None" or "":
		RootGui.setContent(LBLoginGui);
	case "Guest":
		LBLoginGui.guestLogin();
	case "User":
		LBLoginGui.login(true);
	}

	setDiscordStatus("Offline", "Logging In...");
}

// leaderboard constants init
function initLBConstants() {
	if ($Game::Offline)
		return;

	// Default Heartbeats
	$LB::ChatHeartbeatTime = 5000;
	$LB::UserListHeartbeatTime = 15000;

	// Slower for in-game and less lag
	$LB::SlowChatHeartbeatTime = 10000;
	$LB::SlowUserListHeartbeatTime = 25000;

	// These have defaults as well
	$LB::ChatStart = 0;
	$LB::NotifyStart = 0;
	$LB::Access = 0;
	$LB::TotalRating = 0;
	$LB::WelcomeMessage = "<spush><color:ff0000><lmargin:2>An error has occurred.<spop>";

	$LB::BlockListCount = 0;
	$LB::FriendListCount = 0;

	// Disable cheats!
	$Editor::Enabled = 0;

	// This should be init'd at 0
	$LB::Schedules = 0;

	// Create this so we don't have any issues
	Array(LBUserListArray);

	// Activate this here
	activatePackage(Tickable);
}

// core function for closing the leaderboards
// deletes leaderboard variables at the end
function closeLeaderboards() {
	// Schedule this on the next frame to prevent memory corruption from the gui being deleted (#631)
	onNextFrame(doCloseLeaderboards);

	// Reload Marbleland cause bruh
	marblelandReloadMissions();
}

function doCloseLeaderboards() {
	savePrefs();

	// while loop through all Gui/Dlg to ensure all are deleted
	while (isObject(LBLoginGui))
		LBLoginGui.delete();
	while (isObject(LBChatGui))
		LBChatGui.delete();
	while (isObject(LBMessageGui))
		LBMessageGui.delete();
	while (isObject(LBScoresDlg))
		LBScoresDlg.delete();
	while (isObject(LBRegisterDlg))
		LBRegisterDlg.delete();
	while (isObject(LBServersDlg))
		LBServersDlg.delete();
	while (isObject(LBStatsDlg))
		LBStatsDlg.delete();
	while (isObject(LBAchievementsDlg))
		LBAchievementsDlg.delete();
	while (isObject(LBUAchievementsDlg))
		LBUAchievementsDlg.delete();
	while (isObject(LBMessageHudDlg))
		LBMessageHudDlg.delete();
	while (isObject(LBUserDlg))
		LBUserDlg.delete();
	while (isObject(LBSCRestoreDlg))
		LBSCRestoreDlg.delete();
	while (isObject(LBSCSaveDlg))
		LBSCSaveDlg.delete();
	if (isObject(LBErrorHandlerDlg) && LBErrorHandlerDlg.isAwake())
		LBErrorOkHandlerButton.command = "while (isObject(LBErrorHandlerDlg))LBErrorHandlerDlg.delete(); ";
	else {
		while (isObject(LBErrorHandlerDlg))
			LBErrorHandlerDlg.delete();
	}

	// for loop through tcp group and delete them
	// this prevents the game from crashing when you exit
	%count = TCPGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		// We don't want to interfere with other things
		if (getSubStr(TCPGroup.getObject(%i).getName(), 0, 2) $= "LB" && TCPGroup.getObject(%i).getName() !$= "LBNetwork")
			TCPGroup.getObject(%i).destroy();
	}

	while (StatsRequests.getCount() > 0) {
		StatsRequests.getObject(0).delete();
	}

	// additional stuff to delete
	while (isObject(LBMarbleList))
		LBMarbleList.delete();
	deleteVariables("$LB::*");

	$LB = 0;

	// Oh my god shut up
	deactivatePackage(Tickable);
}

$LBGameSess = strRand(64);

function LB_OH_NO() {
	MessageBoxOk("Bad User, no Cookie", "If you\'ve managed to trigger this then there\'s a serious problem. Please tell us about this on our forums. :)", "gotoWebPage(\"http://marbleblast.com\");");
}
