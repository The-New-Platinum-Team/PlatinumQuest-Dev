//------------------------------------------------------------------------------
// Multiplayer Package
// clientChat.cs
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

function onServerChat(%user, %message) {
	if (!mp()) {
		return;
	}

	%display = LBResolveName(%user) @ ":";
	%display2 = LBResolveName(%user, true);

	// Get their access code
	%access = LBUserListArray.getEntryByVariable("username", %user).access;

	// Color their name accordingly
	%display  = LBColorFormat(%user, %display,  %access);
	%display2 = LBColorFormat(%user, %display2, %access);

	if (getSubStr(%message, 0, 1) $= "/") {
		%cmd = getSubStr(firstWord(%message), 1, strlen(%message));

		// Vtaunt
		if (%cmd $= "vtaunt") {
			if (!$MPPref::AllowTaunts)
				return;
			%tnum = getWord(%message, 1);
			MPAddServerChat(%display SPC tauntText(%tnum));
			playTaunt(%tnum);
			return;
		} else if (getSubStr(%cmd, 0, 1) $= "vtaunt") {
			if (!$MPPref::AllowTaunts)
				return;
			%tnum = getSubStr(%cmd, 6, strlen(%cmd));
			MPAddServerChat(%display SPC tauntText(%tnum));
			playTaunt(%tnum);
			return;
		} else if (getSubStr(%cmd, 0, 1) $= "v") {
			if (!$MPPref::AllowTaunts)
				return;
			%tnum = getSubStr(%cmd, 1, strlen(%cmd));
			MPAddServerChat(%display SPC tauntText(%tnum));
			playTaunt(%tnum);
			return;
		}

		switch$ (%cmd) {
		case "me":
			MPAddServerChat(%display2 SPC restWords(%message));
			return;
		case "slap":
			MPAddServerChat(LBSlapMessage(%user, getWord(%message, 1)));
			return;
			// case "boo":
			// 	if ($Server::Hosting)
			// 		PlayMissionGui.toggleFrightfest();
			// 	else
			// 		MPAddServerChat(LBChatColor("admin") @ "You must be the server host to enable Frightfest!");
			// 	return;
			// case "hohoho":
			// 	if ($Server::Hosting)
			// 		PlayMissionGui.toggleWinterfest();
			// 	else
			// 		MPAddServerChat(LBChatColor("admin") @ "You must be the server host to enable Winterfest!");
			// 	return;
		}
	}

	if (strPos(strlwr(%message), strlwr($LB::Username)) != -1 || strPos(strlwr(%message), strlwr($LB::DisplayName)) != -1) {
		// They mentioned your name, flash the thing!
		if (RootGui.getContent().getId() == PlayMissionGui.getId()) {
			PlayMissionGui.notifyServerChat();
		}
	}

	if (%user $= "")
		return;
	if (%message $= "")
		MPAddServerChat(%user);
	else {
		// Format the message
		%message = destroyTorqueML(%message);
		%message = linkify(%message);
		%message = styleify(%message);

		MPAddServerChat(%display SPC %message);
	}
}

function mpSendChat(%message) {
	if (%message $= "")
		return;
	commandToServer('PrivateChat', %message);
	onServerChat($LB::Username, %message);
}

function MPAddServerChat(%message) {
	%message = LBResolveChatColors(strReplace(strReplace(%message, "\x10", $DefaultFont), "\x11", 17), "chat");
	%message = filterBadWords(%message);

	$MP::ServerChat = $MP::ServerChat @ ($MP::ServerChat $= "" ? "" : "\n") @ "<spush>" @ %message @ "<spop>";

	traceGuard();
	// Too many chat lines causes some people to crash. This tries to avoid that.
	if (strlen($MP::ServerChat) > 20000) {
		while (strlen($MP::ServerChat) > 10000) {
			popServerChatLine();
		}
		%message = ""; // Force LBUpdateChat to do a full update (slow!)
	}
	traceGuardEnd();

	MPUpdateServerChat(%message);
}

function MPUpdateServerChat(%message) {
	if (%message $= "") {
		PM_MPChatText.setText("<font:17>" @ $MP::ServerChat);
		PG_ServerChatText.setText("<font:17>" @ $MP::ServerChat);
	} else {
		PM_MPChatText.addText("\n<font:17>" @ %message);
		PG_ServerChatText.addText("\n<font:17>" @ %message);
	}

	if (RootGui.getContent().getName() $= "PlayMissionGui")
		PM_MPChatText.forceReflow();
	if (RootGui.getContent().getName() $= "PlayGUI")
		PG_ServerChatText.forceReflow();

	PM_MPChatContainer.scrollToBottom();
	PM_MPChatContainer.schedule(0, scrollToBottom);
	PM_MPChatContainer.schedule(100, scrollToBottom);
	PM_MPChatContainer.schedule(1000, scrollToBottom);
	PG_ServerChatScroll.scrollToBottom();
	PG_ServerChatScroll.schedule(0, scrollToBottom);
	PG_ServerChatScroll.schedule(100, scrollToBottom);
	PG_ServerChatScroll.schedule(1000, scrollToBottom);
}

function popServerChatLine() {
	//Strip off one <spush><spop> (all chat lines have them)
	$MP::ServerChat = popSpushSpop($MP::ServerChat, 0);

	//Strip off the newline too
	$MP::ServerChat = getSubStr($MP::ServerChat, 1, strlen($MP::ServerChat));
}

//-----------------------------------------------------------------------------
// Team chat

function teamSendChat(%message) {
	if (%message $= "")
		return;
	commandToServer('TeamChat', %message);
}

function onTeamChat(%sender, %team, %leader, %message) {
	// Received a team chat from %sender
	// If %leader is true, then they are the team leader
	// %team is the team name
	// %message is their message

	// Get their access code
	%access = LBUserListArray.getEntryByVariable("username", %sender).access;

	%display = (%leader ? "[L] " : "") @ LBResolveName(%sender) @ ":";
	%display2 = LBResolveName(%sender, true);

	// Color their name accordingly
	%display  = LBColorFormat(%sender, %display,  %access);
	%display2 = LBColorFormat(%sender, %display2, %access);

	addTeamChatLine(%display SPC %message);

	if (strPos(strlwr(%message), strlwr($LB::Username)) != -1 || strPos(strlwr(%message), strlwr($LB::DisplayName)) != -1) {
		// They mentioned your name, flash the thing!
		if (RootGui.getContent().getId() == PlayMissionGui.getId()) {
			PlayMissionGui.notifyTeamChat();
		}
	}
}

function addTeamChatLine(%message) {
	%message = LBResolveChatColors(strReplace(strReplace(%message, "\x10", $DefaultFont), "\x11", 17), "chat");
	%message = filterBadWords(%message);

	$MP::TeamChat = $MP::TeamChat @ ($MP::TeamChat $= "" ? "" : "\n") @ "<spush>" @ %message @ "<spop>";

	traceGuard();
	// Too many chat lines causes some people to crash. This tries to avoid that.
	if (strlen($MP::TeamChat) > 20000) {
		while (strlen($MP::TeamChat) > 10000) {
			popTeamChatLine();
		}
		%message = ""; // Force LBUpdateChat to do a full update (slow!)
	}
	traceGuardEnd();

	updateTeamChat(%message);
}

function updateTeamChat(%message) {
	if (%message $= "") {
		PM_TeamChatText.setText("<font:17>" @ $MP::TeamChat);
		PG_TeamChatText.setText("<font:17>" @ $MP::TeamChat);
	} else {
		PM_TeamChatText.addText("\n<font:17>" @ %message);
		PG_TeamChatText.addText("\n<font:17>" @ %message);
	}

	if (RootGui.getContent().getName() $= "PlayMissionGui")
		PM_TeamChatText.forceReflow();
	if (RootGui.getContent().getName() $= "PlayGUI")
		PG_TeamChatText.forceReflow();

	PM_TeamChatContainer.scrollToBottom();
	PM_TeamChatContainer.schedule(0, scrollToBottom);
	PM_TeamChatContainer.schedule(100, scrollToBottom);
	PM_TeamChatContainer.schedule(1000, scrollToBottom);
	PG_TeamChatScroll.scrollToBottom();
	PG_TeamChatScroll.schedule(0, scrollToBottom);
	PG_TeamChatScroll.schedule(100, scrollToBottom);
	PG_TeamChatScroll.schedule(1000, scrollToBottom);
}

function popTeamChatLine() {
	//Strip off one <spush><spop> (all chat lines have them)
	$MP::TeamChat = popSpushSpop($MP::TeamChat, 0);

	//Strip off the newline too
	$MP::TeamChat = getSubStr($MP::TeamChat, 1, strlen($MP::TeamChat));
}
