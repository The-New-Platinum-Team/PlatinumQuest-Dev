//-----------------------------------------------------------------------------
// Portions Copyright (c) 2021 The Platinum Team
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
// Torque Game Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// This script function is called before a client connection
// is accepted.  Returning "" will accept the connection,
// anything else will be sent back as an error to the client.
// All the connect args are passed also to onConnectRequest
//
function GameConnection::onConnectRequest(%client, %netAddress, %name, %password, %marble, %bologna) {
	if (%client.getAddress() $= "local")
		%password = $MP::ServerPassword = $MPPref::ServerPassword;

	// Included for the lulz, you can remove this if you dislike it
	if (%bologna !$= "bologna") //Credit to Whirligig for realizing I misspelled bologna again
		echo("One more connection, saved by bologna!");

	return "";
}
//-----------------------------------------------------------------------------
// This script function is the first called on a client accept
//
function GameConnection::onConnect(%client, %name, %password, %marble, %bologna) {
	if ($Server::ServerType $= "MultiPlayer" && %client.getAddress() !$= "local") {
		echo("Connect request from: " @ %netAddress);
		if (getRealPlayerCount() >= $pref::Server::MaxPlayers + 1) {
			%client.schedule(1000, delete, "CR_SERVERFULL");
			// Hold the client in a separate group until they've finished.
			// We don't want them clogging up ClientGroup, now do we?
			if (!isObject(HoldGroup))
				RootGroup.add(new SimGroup(HoldGroup));

			HoldGroup.add(%this);
			return;
		}
		tryCreateBanList();
		if (BanList.containsEntryAtField(%name, 0)) {
			%client.schedule(1000, delete, "CR_YOUAREBANNED");
			// Hold the client in a separate group until they've finished.
			// We don't want them clogging up ClientGroup, now do we?
			if (!isObject(HoldGroup))
				RootGroup.add(new SimGroup(HoldGroup));

			HoldGroup.add(%this);
			return;
		}
		// DON'T USE $PREF::SERVER::PASSWORD, IT D/CES YOUR LOCAL CONNECTION
		if (strcmp(%password, $MPPref::Server::Password) != 0) {
			%client.schedule(1000, delete, "CHR_PASSWORD");
			echo("They tried to guess a password of " @ %password @ " but they were very wrong.");
			// Hold the client in a separate group until they've finished.
			// We don't want them clogging up ClientGroup, now do we?
			if (!isObject(HoldGroup))
				RootGroup.add(new SimGroup(HoldGroup));

			HoldGroup.add(%this);
			return;
		}
		if (BanList.containsEntryAtField(%client.getAddress(), 1)) {
			%client.schedule(1000, delete, "CR_YOUAREBANNED");
			// Hold the client in a separate group until they've finished.
			// We don't want them clogging up ClientGroup, now do we?
			if (!isObject(HoldGroup))
				RootGroup.add(new SimGroup(HoldGroup));

			HoldGroup.add(%this);
			return;
		}
	}

	%client.connected = true;

	// if hosting this server, set this client to superAdmin
	if (%client.getAddress() $= "local") {
		%client.isAdmin = true;
		%client.isSuperAdmin = true;
	}

	// Store these, but we need to check their CRC before they can connect
	%client._name     = %name;
	%client._password = %password;
	%client._marble   = %marble;
	%client._bologna  = %bologna;

	// Check server/mp/commands and client/mp/commands for CRC
	// checking. Singleplayer folks get easy free access, as we don't want to
	// screw that up!
	if ($Server::ServerType $= "MultiPlayer")
		%client.validateCRC();
	else
		%client.finishConnect();
}

function GameConnection::finishConnect(%client) {
	// I don't even
	if (%this.verified) {
		error("Dongers from somewhere");
		return;
	}

	// Grab these back
	%name     = %client._name;

	//echo("Name is" SPC %name);
	%password = %client._password;
	%marble   = %client._marble;
	%bologna  = %client._bologna;

	// We don't need these silly fields anymore
	%client._name     = "";
	%client._number   = "";
	%client._password = "";
	%client._marble   = "";
	%client._bologna  = "";
	%client._platform = "";

	//Compatibility in case we need to hack some scripts in
	if ($Server::Dedicated) {
		%client.injectScripts();
	}

	// Send down the connection error info, the client is
	// responsible for displaying this message if a connection
	// error occures.
	messageClient(%client,'MsgConnectionError',"",$Pref::Server::ConnectionError);

	// Simulated client lag for testing...
	// %client.setSimulatedNetParams(0.1, 30);

	// Get the client's unique id:
	// %authInfo = %client.getAuthInfo();
	// %client.guid = getField(%authInfo, 3);
	%client.guid = 0;
	addToServerGuidList(%client.guid);

	if ($MP::TeamMode) {
		// Add them to the default team, or create it if none exists
		%defaultTeam = Team::createDefaultTeam();
		Team::addPlayer(%defaultTeam, %client);
	}

	// Set admin status
	%client.isHost = false;
	%client.isAdmin = false;
	%client.isSuperAdmin = false;

	// if hosting this server, set this client to superAdmin
	if (%client.getAddress() $= "local") {
		%client.isHost = true;
		%client.isAdmin = true;
		%client.isSuperAdmin = true;
	}

	// Custom player skins
	if (!$playingDemo) {
		// Replay has its own skin handling.
		%client.skinChoice = %marble;
	}

	if (isReturningName(%name)) {
		// THOUGHT YOU COULD LEAVE, DID YOU? WELL SCREW THAT. HAVE YOUR
		// POINTS BACK.

		//echo("Is returning:" SPC %name);

		%client.restore(%name);

		%client.restored = true;

		//commandToClient(%client, '_', "d();");
		//kick(%client);
		//return;
	} else {
		%client.setPlayerName(%name);

		// add the index to actually make MP WORK
		$Game::ClientIndex += 0;
		%client.index = $Game::ClientIndex;
		$Game::ClientIndex ++;
	}
	messageClient(%client, 'MsgClientIndex', "", %client.index);
	commandToClient(%client, 'Dedicated', $Server::Dedicated);

	$instantGroup = ServerGroup;
	$instantGroup = MissionCleanup;
	echo("CADD: " @ %client @ " " @ %client.getAddress());

	// Inform the client of all the other clients
	%count = ClientGroup.getCount();
	for (%cl = 0; %cl < %count; %cl++) {
		%other = ClientGroup.getObject(%cl);
		if (%other != %client) {
			commandToClient(%client, 'GhostIndex', %other.scale, %other.index);
		}
	}

	%client.sendSettings();

	if ($Server::ServerType $= "Multiplayer") {
		%client.sendDifficultyList();
		commandToAllExcept(%client, 'PrivateMessage', LBChatColor("notification") @ %client.getDisplayName() SPC "has joined the game.");
		commandToClient(%client, 'initSprng', $Server::SprngSeed);
	}

	if ($Server::Dedicated && $Server::Controllable) {
		%client.sendInfo();

		//Init the loops
		MPinitLoops();

		if (%client.isHost() || getRealPlayerCount() < 2) {
			//You're the host
			%client.setHost(true);
		}
	}

	$Server::PlayerCount = getRealPlayerCount();

	if ($Server::ServerType $= "MultiPlayer" && $Server::Lobby && !$missionRunning) {
		%client.loadLobby();
	} else {
		%client.updatePlaymission();
		%client.loadMission();

		// Set the loading state
		%client.loading = true;
		updatePlayerlist(); // Update the user list
	}

	if ($Server::ServerType $= "MultiPlayer") {
		commandToClient(%client, 'GameStatus', $Editor::Opened);
		startHeartbeat();
		serverSendCallback("OnPlayerJoin");
		Mode::callback("onPlayerJoin", "", new ScriptObject() {
			client = %client;
			_delete = true;
		});
	}
}

//-----------------------------------------------------------------------------
// A player's name could be obtained from the auth server, but for
// now we use the one passed from the client.
// %realName = getField(%authInfo, 0);
//
function GameConnection::setPlayerName(%client, %name) {
	%client.sendGuid = 0;

	// Minimum length requirements
	%name = stripTrailingSpaces(fixName(%name));
	if (strlen(%name) < 1)
		%name = "Guest";

	// Make sure the alias is unique, we'll hit something eventually
	if (!isNameUnique(%name)) {
		%isUnique = false;
		for (%suffix = 1; !%isUnique; %suffix ++) {
			%nameTry = %name @ "_" @ %suffix;
			%isUnique = isNameUnique(%nameTry);
		}
		%name = %nameTry;
	}

	%client.nameBase = %name;
}

function fixName(%name) {
	%mostlyFormatted = ltrim(stripChars(%name, ",.\'`"));
	while (strPos(%mostlyFormatted, "  ") != -1)
		%mostlyFormatted = strReplace(%mostlyFormatted, "  ", " ");
	while (strPos(%mostlyFormatted, " _") != -1)
		%mostlyFormatted = strReplace(%mostlyFormatted, " _", "_");
	%formatted = stripMLControlChars(%mostlyFormatted);
	return %formatted;
}

function isNameUnique(%name) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%test = ClientGroup.getObject(%i);
		if (strcmp(%name, %test.nameBase) == 0)
			return false;
	}
	return true;
}

function isReturningName(%name) {
	%count = FakeClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%test = FakeClientGroup.getObject(%i);
		if (strcmp(%name, %test.nameBase) == 0)
			return true;
	}
	return false;
}

function GameConnection::getUsername(%this) {
	if (%this._name !$= "")
		return %this._name;
	return %this.nameBase;
}

function GameConnection::getDisplayName(%this) {
	if (%this.displayName $= "") {
		return %this.getUsername();
	}
	return %this.displayName;
}

//-----------------------------------------------------------------------------
// This function is called when a client drops for any reason
//
function GameConnection::onDrop(%client, %reason) {
	if (%client.pinging) return;
	%client.onClientLeaveGame();

	removeFromServerGuidList(%client.guid);
	if (%client.connected && %client.getDisplayName() !$= "" && $Server::ServerType $= "Multiplayer") {
		messageAllExcept(%client, -1, 'MsgClientDrop', '\c1%1 has left the game.', %client.getDisplayName(), %client);
		commandToAllExcept(%client, 'PrivateMessage', LBChatColor("notification") @ %client.getDisplayName() SPC "has left the game.");
	}

	if ($Server::Hosting && %client.address !$= "local" && %client.connected) {
		Team::removePlayer(%client.team, %client);
		if ($Server::Loading) {
			//Schedule an update to load so we don't prevent others from playing
			schedule(100, 0, checkAllClientsLoaded);
		}
		if ($Server::ServerType $= "MultiPlayer") {
			// NOT SO FAST! IF YOU'RE GOING TO QUIT, YOU'RE GOING TO REGRET
			// IT! (Unless you're Matan and winning. Screw you.)

			// Back up client scores

			// Not worth it if we're at the lobby. I mean, c'mon!
			if (!$Server::Lobby && !$Game::Finished)
				%client.backup();
		}
	}

	echo("CDROP: " @ %client @ " " @ %client.getAddress());

	// Reset the server if everyone has left the game
	if ($Server::Dedicated && $Server::Controllable) {
		schedule(100, 0, "dedicatedUpdate");
		//If they're the host we need to find a new host
		if (%client.isHost()) {
			//New host time!
			dedicatedFindNewHost(%client);
		}
	}

	if ($Server::Hosting && $Server::ServerType $= "Multiplayer" && %client.address !$= "local") {
		updatePlayerlist();
		startHeartbeat();
		serverSendCallback("OnPlayerLeave");
		Mode::callback("onPlayerLeave", "", new ScriptObject() {
			client = %client;
			_delete = true;
		});
	}
}

//-----------------------------------------------------------------------------

// Gets the count of non-fake players on the server
function getRealPlayerCount() {
	return ClientGroup.getCount();
}

// Gets the count of non-fake, non-spectatind players on the server
function getPlayingPlayerCount() {
	%count = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.spectating)
			%count ++;
	}

	return %count;
}

// Gets the count of all players on the server, real and fake.
function getTotalPlayerCount() {
	return ClientGroup.getCount();
}

// Gets the count of all clients on the server, not including fake
// players, and including pinging and verifying players
function getRealClientCount() {
	return getRealPlayerCount() + HoldGroup.getCount();
}

function isRealClient(%client) {
	return (!%client.fake && isObject(%client) && %client.getClassName() $= "GameConnection");
}

function GameConnection::isReal(%this) {
	return isRealClient(%this);
}

function FakeGameConnection::isReal(%this) {
	return false;
}

function GameConnection::setHost(%this, %host) {
	%this.isHost = %host;
	commandToClient(%this, 'HostStatus', %host);

	if ($Server::Dedicated) {
		%this.sendInfo();
	}
}

function GameConnection::isHost(%this) {
	return %this.isHost;
}

function GameConnection::isAdmin(%this) {
	return %this.isAdmin || %this.isSuperAdmin;
}

function FakeGameConnection::isAdmin(%this) {
	return false;
}

function FakeGameConnection::isAIControlled(%this) {
	return true; //Makes a lot of things shut up
}

function FakeGameConnection::getPing(%this) {
	return 9999; //Well they won't get your messages anyway...
}

function FakeGameConnection::isGuest(%this) {
	//Redirect
	return GameConnection::isGuest(%this);
}

function FakeGameConnection::isHost(%this) {
	//Nope!
	return false;
}

function FakeGameConnection::setHost(%this) {
	//Nope!
	return;
}

function FakeGameConnection::getNameTag(%this) {
	//Redirect
	return GameConnection::getNameTag(%this);
}

function FakeGameConnection::getUsername(%this) {
	//Redirect
	return GameConnection::getUsername(%this);
}

function FakeGameConnection::getDisplayName(%this) {
	//Redirect
	return GameConnection::getDisplayName(%this);
}

function GameConnection::find(%name) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.nameBase $= %name) {
			return %client;
		}
	}
	return "";
}

//-----------------------------------------------------------------------------

function GameConnection::startMission(%this) {
	// Inform the client the mission starting
	commandToClient(%this, 'MissionStart', $missionSequence);
}


function GameConnection::endMission(%this) {
	%ret = $LB::LoggedIn || $Server::Dedicated;
	if (%ret && $platform $= "windows")
	{
		anticheatDetect(); // This shit aint exist on mac lmaoo
	}
	// Inform the client the mission is done
	commandToClient(%this, 'MissionEnd', $missionSequence);
}

//--------------------------------------------------------------------------

function GameConnection::backup(%this) {
	if (!$MPPref::BackupClients) return;
	if (!%this.connected) return;
	if (%this.namebase $= "") return;

	FakeClientGroup.add(%fake = new ScriptObject(FakeConnection) {
		class = "FakeGameConnection";
		nameBase = %this.namebase;
		number = -1;
		pinging = false;
		isAdmin = false;
		isSuperAdmin = false;
		score = 0;
		index = %this.index;
		fake = true;

		skinChoice = %this.skinChoice;
		gemCount = %this.gemCount;
		gemsFound[1]  = %this.gemsFound[1];
		gemsFound[2]  = %this.gemsFound[2];
		gemsFound[5]  = %this.gemsFound[5];
		gemsFound[10] = %this.gemsFound[10];

		team = Team::getTeamName(%this.team);
		spectating = %this.spectating;
		wins = %this.wins;
	});

	echo("Backing up " @ %this.getUsername() @ " (id " @ %this.getId() @ ") to fake client id " @ %fake);
}

function addFakeClient(%name) {
	FakeClientGroup.add(%fake = new ScriptObject(FakeConnection) {
		class = "FakeGameConnection";
		nameBase = %name;
		name = %name;
		number = -1;
		pinging = false;
		isAdmin = false;
		isSuperAdmin = false;
		score = 0;
		index = $Game::ClientIndex;
		fake = true;

		gemCount = 0;
	});
}

function GameConnection::restore(%this, %name) {
	echo("Attempting to restore" SPC %name);
	%count = FakeClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%test = FakeClientGroup.getObject(%i);
		if (strcmp(%name, %test.nameBase) == 0) {
			echo("Actually restoring" SPC %name SPC "from" SPC %test);
			%this.index = %test.index;

			// Restore their stats and prefs
			%this.skinChoice = %test.skinChoice;
			%this.gemCount = %test.gemCount;
			%this.gemsFound[1]  = %test.gemsFound[1];
			%this.gemsFound[2]  = %test.gemsFound[2];
			%this.gemsFound[5]  = %test.gemsFound[5];
			%this.gemsFound[10] = %test.gemsFound[10];
			%this._spectating = %test.spectating;

			%this.wins = %test.wins;

			// Restore their team
			%team = %test.team;
			if ($MP::TeamMode && (%team = Team::getTeam(%team)) != -1 && !%team.private) {
				Team::addPlayer(%team, %this);
			}

			// Clean up
			%test.delete();

			%this.setPlayerName(%name);

			return;
		}
	}
	return false;
}

function GameConnection::sendSettings(%this) {
	%this.sendSettingsList();
	messageClient(%this,
	              'MsgServerPrefs', "",
	              $MP::BlastRequiredAmount,
	              $MP::BlastChargeTime,
	              $MPPref::AllowQuickRespawn,
	              $MP::BlastPower,
	              $MP::BlastRechargePower,
	              $Pref::Server::Info,
	              $MPPref::FastPowerups);
}

function pruneFakeClients() {
	FakeClientGroup.clear();
}

function GameConnection::isFake(%this) {
	return false;
}

function FakeGameConnection::isFake(%this) {
	return true;
}

function GameConnection::isReal(%this) {
	return true;
}

function FakeGameConnection::isReal(%this) {
	return false;
}
