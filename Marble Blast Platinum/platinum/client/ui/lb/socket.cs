//-----------------------------------------------------------------------------
// Socket.cs
//
// Because I don't like having to do all this inside a gui file
//
// Copyright (c) 2014 The Platinum Team
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

//RELEASE PORT
// $LB::Server = "webchat.marbleblast.com:28002";

//DEV PORT
// $LB::Server = $ServerInfo::webchatServer;

//-----------------------------------------------------------------------------
// Connecting and Disconnecting
//-----------------------------------------------------------------------------

function LBconnect() {
	if ($Game::Offline)
		return;

	//Preliminary stuff
	pauseMusic();

	$LB::LoggedIn = false;

	// Let us chat from the start
	LBChatGui.setEnableChatEntry(true);

	%sock = new TCPObject(LBNetwork);
	%sock.connect($LBServerInfo::webchatServer);

	LBMessage("Logging In...", "LBdisconnect();");
}

function LBdisconnect(%finishCmd) {
//	error("Disconnecting from the LBs");
	LBNetwork.send("DISCONNECT\r\n");
	LBNetwork.shouldRelog = false;

	//Kick us out
	if (isObject(LBNetwork))
		LBNetwork.destroy();

	$LB::Loading = false;
	$LB::LoggedIn = false;
	$LB::LogoutSch = schedule(1000, 0, LB_FinishLogout, %finishCmd);
}

//-----------------------------------------------------------------------------
// Guest connections
//-----------------------------------------------------------------------------

function LBguestConnect() {
	if ($Game::Offline)
		return;

	//Preliminary stuff
	pauseMusic();

	LBChatGui.setEnableChatEntry(false);

	$LB::LoggedIn = false;
	$LB::Guest = true;

	%sock = new TCPObject(LBNetwork);
	%sock.connect($LBServerInfo::webchatServer);

	LBMessage("Logging In...", "LBdisconnect();");
}

//-----------------------------------------------------------------------------
// LBNetwork Base Functionality
//-----------------------------------------------------------------------------

function LBNetwork::onConnected(%this) {
	%this.echo("LBNetwork::onConnected Connected!");
	cancelIgnorePause($LB::ReloginSchedule);
	%this.shouldRelog = true;

	if ($Game::Offline)
		return;

	//The server is expecting us to IDENTIFY <username>
	%this.identifying = true;
	%this.identify();
	//Macs sometimes can't identify, doesn't hurt if we do this twice
	%this.scheduleIgnorePause(1000, identify);
}

function LBNetwork::onDisconnect(%this) {
	%this.echo("LBNetwork::onDisconnect Disconnected!");
	error("LBNetwork Disconnected!");

	//We've disconnected. There's nothing that can be done about it now.

	if (%this.shouldRelog) {
		%this.scheduleRelogin();
	}

	%this.delete();
}

function LBNetwork::pingDisconnect(%this) {
	%this.echo("LBNetwork::pingDisconnect Disconnected!");
	error("LBNetwork Disconnected: Timeout!");

	//We've disconnected. There's nothing that can be done about it now.

	if (%this.shouldRelog) {
		%this.scheduleRelogin();
	}

	%this.delete();
}

function LBNetwork::scheduleRelogin(%this) {
	%this.shouldRelog = false;

	//Try to reconnect:
	cancelIgnorePause($LB::ReloginSchedule);
	$LB::ReloginSchedule = scheduleIgnorePause(5000, LBRelogin);
}

function LBRelogin() {
	if (!$LB::LoggedIn)
		return;
	if ($Game::Offline)
		return;

	backtrace();

	warn("LBNetwork attempting a relogin!");

	$LB::Relogin = true;

	while (isObject(LBNetwork)) {
		LBNetwork.shouldRelog = false;
		LBNetwork.delete();
	}

	%sock = new TCPObject(LBNetwork);
	%sock.connect($LBServerInfo::webchatServer);

	cancelIgnorePause($LB::ReloginSchedule);
	$LB::ReloginSchedule = scheduleIgnorePause(5000, LBRelogin);
}

function LBNetwork::delete(%this) {
	%this.send("DISCONNECT");
	Parent::delete(%this);
}

function LBNetwork::send(%this, %data) {
	%this.echo(trim(%data), "Send");
	echo("LBNetwork << " @ %data);
	Parent::send(%this, %data);
}

//-----------------------------------------------------------------------------
// LBNetwork Functions
//-----------------------------------------------------------------------------

function LBNetwork::identify(%this) {
	if ($Game::Offline)
		return;
	if (!%this.identifying) {
		error("LBNetwork::identify Identifying when we are not ready!");
		return;
	}
	if ($LB::Guest) {
		%this.send("IDENTIFY Guest" @ "\r\n");
	} else {
		//Send IDENTIFY and VERIFY requests
		if ($LB::Relogin)
			%this.send("RELOGIN\r\n");
		%this.send("IDENTIFY" SPC $LB::Username @ "\r\n");
		%this.send("VERIFY" SPC $MP::RevisionOn SPC garbledeguck($LB::Password) @ "\r\n");
	}

	%this.send("SESSION" SPC $LBGameSess @ "\r\n");

	//Tracking data
	%this.send("TRACK" SPC
	           encodeName(getDesktopResolution()) SPC
	           encodeName($pref::Video::Resolution) SPC
	           encodeName($pref::Video::fullScreen) SPC
	           encodeName($platform) SPC
	           encodeName($pref::useStencilShadows) SPC
	           encodeName($pref::Player::defaultFov) SPC
	           0 SPC //Ignition version
	           encodeName($pref::Video::displayDevice) SPC
	           encodeName(getFields(getVideoDriverInfo(), 0, 2)) SPC
	           encodeName(!!$pref::FastMode)
	           @ "\r\n");

	//Send Gui tracks
	for (%i = 0; %i < $LBPref::GuiCount; %i ++) {
		%this.send("GUITRACK" SPC encodeName($LBPref::Gui[%i]) SPC encodeName($LBPref::GuiCount[%i]) @ "\r\n");
		$LBPref::Gui[%i] = "";
		$LBPref::GuiCount[%i] = "";
	}
	$LBPref::GuiCount = "";
	savePrefs();
}

function LBNetwork::finishLogin(%this) {
	if ($Game::Offline)
		return;
	if ($LB::LoggedIn) {
		error("LBNetwork::finishLogin Already logged in!");
		return;
	}

	//Set variables for the LBs
	$LB::LoggedIn = true;

	if ($LB::Relogin) {
		return;
	}
	//Update this here since we're about to get old chat messages
	LBChatGui.welcomeMessage();

	$LB::Loading = true;
	$LB::LoadProgress = 1;
	$LB::LoadTotal = 0;

	if (!$LB::Guest) {
		statsGetEasterEggs(); //Increments total
	}
	statsGetMarbleList(); //Increments total
	statsGetMissionList("Single Player"); //Increments total
	statsGetMissionList("Multiplayer"); //Increments total
	statsGetAchievementList(); //Increments total
	statsRecordMetrics();
	statsRecordGraphicsMetrics();
	LBOnLoadProgress(); //Increments total
}

function LBAddLoadProgress() {
	backtrace();
	if (!$LB::LoggedIn)
		return;
	if (!$LB::Loading)
		return;
	//Some nice progress for the users
	$LB::LoadProgress ++;
	LBMessage("Downloading Data (" @ $LB::LoadTotal @ " of " @ $LB::LoadProgress @ ")...", "LBdisconnect();");
}

//Called whenever a loading process completes
function LBOnLoadProgress() {
	backtrace();
	if (!$LB::LoggedIn)
		return;
	if (!$LB::Loading)
		return;
	//Some nice progress for the users
	$LB::LoadTotal ++;
	LBMessage("Downloading Data (" @ $LB::LoadTotal @ " of " @ $LB::LoadProgress @ ")...", "LBdisconnect();");

	//If we finish, go to chat
	if ($LB::LoadTotal == $LB::LoadProgress) {
		$LB::LoadTotal = 0;
		$LB::Loading = false;
		//So you can see it complete
		RootGui.schedule(1000, setContent, LBChatGui);
	}
}

function LBNetwork::sendChat(%this, %message, %destination) {
	%this.send("CHAT" SPC encodeName(%destination) SPC %message @ "\r\n");
}

function LBNetwork::setMode(%this, %location) {
	%this.send("LOCATION" SPC %location @ "\r\n");
}

function LBNetwork::ping(%this, %data) {
	%this.send("PING" SPC %data @ "\r\n");
	$LB::PingTime = $Sim::Time;

	%this.lastPing = %data;

	//We are expecting a PING back, if not we've disconnected
	cancelIgnorePause(%this.pingDisconnect);
	%this.pingDisconnect = %this.scheduleIgnorePause(10000, "pingDisconnect");
}

function LBNetwork::pong(%this, %data) {
	%this.send("PONG" SPC %data @ "\r\n");
}

function LBNetwork::addFriend(%this, %friend) {
	%this.send("FRIEND" SPC encodeName(%friend) @ "\r\n");
}

function LBNetwork::deleteFriend(%this, %friend) {
	%this.send("FRIENDDEL" SPC encodeName(%friend) @ "\r\n");
}

function LBNetwork::listFriends(%this) {
	%this.send("FRIENDLIST\r\n");
}

function LBNetwork::blockUser(%this, %user) {
	%this.send("BLOCK" SPC encodeName(%user) @ "\r\n");
}

function LBNetwork::unblockUser(%this, %user) {
	%this.send("UNBLOCK" SPC encodeName(%user) @ "\r\n");
}

//-----------------------------------------------------------------------------
// LBNetwork line parsing
//-----------------------------------------------------------------------------

function LBNetwork::onLine(%this, %line) {
	if (%this.disconnected)
		return;
	if ($Game::Offline)
		return;

	%this.echo(%line, "Line");
	echo("LBNetwork >> " @ %line);

	//Lines are always in the form of <cmd> <data>
	%cmd  = firstWord(%line);
	%data = restWords(%line);

	switch$ (%cmd) {
	case "IDENTIFY":
		%this.on_identify(%data);
	case "INFO":
		%this.on_info(%data);
	case "LOGGED":
		%this.on_logged(%data);
	case "ACCEPTTOS":
		%this.on_accepttos(%data);
	case "FRIEND":
		%this.on_friend(%data);
	case "BLOCK":
		%this.on_block(%data);
	case "FLAIR":
		%this.on_flair(%data);
	case "WINTER":
		%this.on_winter(%data);
	case "2SPOOKY":
		%this.on_2spooky(%data);
	case "USER":
		%this.on_user(%data);
	case "CHAT":
		%this.on_chat(%data);
	case "NOTIFY":
		%this.on_notify(%data);
	case "SHUTDOWN":
		%this.on_shutdown(%data);
	case "PING":
		%this.on_ping(%data);
	case "PONG":
		%this.on_pong(%data);
	case "PINGTIME":
		%this.on_pingtime(%data);
	case "STATUS":
		%this.on_status(%data);
	case "COLOR":
		%this.on_color(%data);
	}
}

function LBNetwork::on_identify(%this, %line) {
	//IDENTIFY <status>
	//Status can be any of the following:
	//BANNED - you are banned
	//INVALID - your pass/user is wrong
	//CHALLENGE - try again
	//OUTOFDATE - client update required
	//SUCCESS - identified

	//We're no longer identifying if we're getting responses from an identify
	%this.identifying = false;

	%status = firstWord(%line);
	switch$ (%status) {
	case "BANNED":
		%data = trim(decodeName(restWords(%line)));
		if (%data !$= "") {
			LBAssert("You are Banned", "You have been banned from the leaderboards!\n\nBan message: " @ %data, "LBdisconnect();");
		} else {
			LBAssert("You are Banned", "You have been banned from the leaderboards!", "LBdisconnect();");
		}
	case "INVALID":
		LBAssert("Login Failed", "Invalid username or password, please try again!", "LBdisconnect();");
	case "OUTOFDATE":
		LBAssert("Error!", "Out of date client, please update your game!", "LBdisconnect();");
	case "NEEDACTIVATION":
		LBAssert("Login Failed", "Please activate your account first. Check your email for a link with your activation code.", "LBdisconnect();");
	case "CHALLENGE":
	case "SUCCESS":
	}
}

function LBNetwork::on_info(%this, %line) {
	//INFO <info type> <info data>
	//Type can be any of the following:
	//LOGGING - turn on debug logging
	//ACCESS - what your user access is
	//DISPLAY - what your display name is
	//SERVERTIME - the server's current time
	//CURRATING - your current rating
	//WELCOME - the welcome message
	//DEFAULT - the default score name
	//ADDRESS - your IP address
	//HELP - help info

	%type = firstWord(%line);
	%data = restWords(%line);

	switch$ (%type) {
	case "LOGGING":
	//Nothing, we ignore this now
	case "ACCESS":
		$LB::Access = %data;
	case "DISPLAY":
		$LB::DisplayName = %data; //Display name
	case "CURRATING":
		$LB::TotalRating = %data;
	case "WELCOME":
		$LB::WelcomeMessage = "<spush><lmargin:2>" @ LBChatColor("welcome") @ collapseEscape(%data) @ "<spop>";
	case "DEFAULT":
		$LB::DefaultHSName = decodeName(%data);
	case "ADDRESS":
		$ip = %data;
	case "HELP":
		$LB::ChatHelpMessage[firstWord(%data)] = "<spush><lmargin:2>" @ LBChatColor("help") @ collapseEscape(restWords(%data)) @ "<spop>";
	case "USERNAME":
		$LB::Username = %data;
	case "CANCHAT":
		%status = !!getWord(%data, 0);
		LBChatGui.setEnableChatEntry(%status);
	}
}

function LBNetwork::on_winter(%this, %line) {
	if ($Game::Offline)
		return;
	$LB::WinterMode = true;
}

function LBNetwork::on_2spooky(%this, %line) {
	if ($Game::Offline)
		return;
	$LB::SpookyMode = true;
}

function LBNetwork::on_logged(%this, %line) {
	if ($Game::Offline)
		return;
	//We've successfully logged in
	if ($LB::Relogin) {
		LBSetMode($LB::StatusNumeric);
		$LB::Relogin = false;
		return;
	}

	//Should probably handle this, but it's not really the right place.
	// Every other case leads to success or disconnection, and we don't want
	// to send info after disconnecting.
	%this.finishLogin();
}

function LBNetwork::on_accepttos(%this, %line) {
	if ($Game::Offline)
		return;
	//Sucker
	RootGui.setContent(LBTermsDlg);
}

function LBNetwork::on_friend(%this, %line) {
	//FRIEND <type> [name]
	//We'll get one of the following:
	//FRIEND START
	//FRIEND NAME <friend>
	//FRIEND DONE

	%type = firstWord(%line);
	%data = restWords(%line);
	switch$ (%type) {
	case "START":
		%this.receivingFriends = true;
		$LB::FriendListCount = 0;
	case "NAME":
		if (!%this.receivingFriends) {
			error("LBNetwork::on_friend Not receiving friends!");
			return;
		}
		$LB::FriendListUser[$LB::FriendListCount] = decodeName(getWord(%data, 1)) TAB decodeName(getWord(%data, 0));
		$LB::FriendListCount ++;
	case "DONE":
		%this.receivingFriends = false;
	case "ADDED":

	case "DELETED":
	case "FAILED":
	}
}

function LBNetwork::on_block(%this, %line) {
	//BLOCK <type> [name]
	//We'll get one of the following:
	//BLOCK START
	//BLOCK NAME <friend>
	//BLOCK DONE

	%type = firstWord(%line);
	%data = restWords(%line);
	switch$ (%type) {
	case "START":
		%this.receivingBlock = true;
		$LB::BlockListCount = 0;
	case "NAME":
		if (!%this.receivingBlock) {
			error("LBNetwork::on_block Not receiving blocks!");
			return;
		}
		$LB::BlockListUser[$LB::BlockListCount] = decodeName(getWord(%data, 1)) TAB decodeName(getWord(%data, 0));
		$LB::BlockListCount ++;
	case "DONE":
		%this.receivingBlock = false;
	case "ADDED":

	case "DELETED":
	case "FAILED":
	}
}

function LBNetwork::on_flair(%this, %line) {
	//FLAIR <flair>
	//Check if we have it
	if (!isFile("platinum/client/ui/lb/chat/flair/" @ %line @ ".png")) {
		//Need to download
		statsGetFlairBitmap(%line);
	}
}

function LBNetwork::on_user(%this, %line) {
	//USER <type> [name]
	//We'll get one of the following:
	//USER START
	//USER INFO <username> <access> <location> <display> <color> <flair> <prefix> <suffix>
	//USER DONE

	%type = firstWord(%line);
	%data = restWords(%line);
	switch$ (%type) {
	case "START":
		%this.receivingUsers = true;

		if (!isObject(LBUserListArray))
			Array(LBUserListArray);
		if (!isObject(LBUserGroupArray))
			Array(LBUserGroupArray);
		if (!isObject(LBUserListGroup))
			RootGroup.add(new SimGroup(LBUserListGroup));
		if (!isObject(LBUserGroupGroup))
			RootGroup.add(new SimGroup(LBUserGroupGroup));

		Array(LBUserListUpdateArray);
		Array(LBUserGroupUpdateArray);
		%count = LBUserListGroup.getCount();
		for (%i = 0; %i < %count; %i ++) {
			LBUserListGroup.getObject(%i).update = false;
		}
		%count = LBUserGroupGroup.getCount();
		for (%i = 0; %i < %count; %i ++) {
			LBUserGroupGroup.getObject(%i).update = false;
		}

	case "GROUP":
		if (!%this.receivingUsers) {
			error("LBNetwork::on_user Not receiving users!");
			return;
		}

		//{$level} {$info["ordering"]} " . encodeName($info["groupName"]). encodeName($info["singleName"])

		//Find which entry we want, or create a new one if we don't have any
		%group = decodeName(getWord(%data, 0));
		if (LBUserGroupArray.containsEntryAtVariable("group", %group)) {
			%entry = LBUserGroupArray.getEntryByVariable("group", %group);
		} else {
			%entry = new ScriptObject();
			%entry.group = %group;
			LBUserGroupGroup.add(%entry);
		}

		%entry.ordering   = getWord(%data, 1);
		%entry.name       = decodeName(getWord(%data, 2));
		%entry.singleName = decodeName(getWord(%data, 3));

		%entry.update = true;
		LBUserGroupUpdateArray.addEntry(%entry);

	case "INFO":
		if (!%this.receivingUsers) {
			error("LBNetwork::on_user Not receiving users!");
			return;
		}

		//Find which entry we want, or create a new one if we don't have any
		%username = decodeName(getWord(%data, 0));
		if (LBUserListArray.containsEntryAtVariable("username", %username)) {
			%entry = LBUserListArray.getEntryByVariable("username", %username);
		} else {
			%entry = new ScriptObject();
			%entry.username = %username;
			LBUserListGroup.add(%entry);
		}

		%entry.groupNum = getWord(%data, 1);
		%entry.location = getWord(%data, 2);
		%entry.display  = filterBadWords(decodeName(getWord(%data, 3)));
		%entry.color    = getWord(%data, 4);
		%entry.colorId  = LBRegisterChatColor(%username, getWord(%data, 4), getWord(%data, 4), getWord(%data, 4), true);
		%entry.flair    = decodeName(getWord(%data, 5));
		%entry.prefix   = decodeName(getWord(%data, 6));
		%entry.suffix   = decodeName(getWord(%data, 7));

		%entry.update = true;
		LBUserListUpdateArray.addEntry(%entry);

	case "DONE":
		%this.receivingUsers = false;

		//Prune removed users and groups
		for (%i = 0; %i < LBUserListGroup.getCount(); %i ++) {
			%entry = LBUserListGroup.getObject(%i);
			if (!%entry.update) {
				%entry.delete();
				%i --;
			}
		}
		for (%i = 0; %i < LBUserGroupGroup.getCount(); %i ++) {
			%entry = LBUserGroupGroup.getObject(%i);
			if (!%entry.update) {
				%entry.delete();
				%i --;
			}
		}

		LBUserListArray.delete();
		LBUserListUpdateArray.setName("LBUserListArray");
		LBUserGroupArray.delete();
		LBUserGroupUpdateArray.setName("LBUserGroupArray");

		//Assign group objects for each user object
		for (%i = 0; %i < LBUserListGroup.getCount(); %i ++) {
			%entry = LBUserListGroup.getObject(%i);
			%entry.group = LBUserGroupArray.getEntryByVariable("group", %entry.groupNum);
		}

		LBUserGroupArray.sort(sortUserGroupItems);
		LBUserListArray.sort(sortUserlistItems);

		LBChatGui.updateUserlist();
	}
}

function sortUserGroupItems(%a, %b) {
	%aSort = %a.ordering;
	%bSort = %b.ordering;

	if (%aSort != %bSort) {
		return %aSort > %bSort;
	}
	return stricmp(%a.name, %b.name) < 0;
}

function sortUserlistItems(%a, %b) {
	%aSort = %a.group.ordering;
	%bSort = %b.group.ordering;

	if (%aSort != %bSort) {
		return %aSort > %bSort;
	}
	return stricmp(%a.display, %b.display) < 0;
}

function LBNetwork::on_chat(%this, %line) {
	if ($LB::Relogin) {
//		echo("Chat during relogin!");
		return;
	}
	//Punt this over to LBChatGui
	LBParseChat(%line);
}

function LBNetwork::on_notify(%this, %line) {
	//Punt this over to LBChatGui
	LBParseNotify(%line);
}

function LBNetwork::on_shutdown(%this, %line) {
	//That's never a good sign
	LB_FinishLogout();
	LBAssert("Shutdown!","The leaderboards server has just shut down. Please reconnect later!");
}

function LBNetwork::on_ping(%this, %line) {
	if ($Game::Offline) //If they've managed to get this far offline, color me impressed.
		return;

	//Send it back!
	%this.pong(%line);
	cancelIgnorePause(%this.pingSchedule);
	%this.pingSchedule = %this.scheduleIgnorePause(30000, "ping", getSimTime() SPC getRealTime());
}

function LBNetwork::on_pong(%this, %line) {
	if (%line $= %this.lastPing) {
		//Grab pingtime
		$LB::Ping = mRound(1000 * ($Sim::Time - $LB::PingTime));
		$LB::PingTime = "";

		cancelIgnorePause(%this.pingDisconnect);
	}
}

function LBNetwork::on_pingtime(%this, %line) {
	//PINGTIME <time>
	%time = getWord(%line, 0);
	$LB::Ping = mRound(%time * 1000);
}

function LBNetwork::on_status(%this, %line) {
	//<id> <text>
	%id = firstWord(%line);
	%value = restWords(%line);
	$LB::Status[%id] = %value;
	$LB::FoundStatus[%id] = true;
}

function LBNetwork::on_color(%this, %line) {
	//<id> <text>
	%id = firstWord(%line);
	%value = restWords(%line);
	$LB::Color[%id] = %value;
	$LB::ColorLookup[%value] = %id;
}
