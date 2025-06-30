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

// Functions dealing with connecting to a server

//-----------------------------------------------------------------------------
// Server connection error
//-----------------------------------------------------------------------------

addMessageCallback('MsgConnectionError', handleConnectionErrorMessage);

function handleConnectionErrorMessage(%msgType, %msgString, %msgError) {
	// On connect the server transmits a message to display if there
	// are any problems with the connection.  Most connection errors
	// are game version differences, so hopefully the server message
	// will tell us where to get the latest version of the game.
	$ServerConnectionErrorMessage = %msgError;
}


//----------------------------------------------------------------------------
// GameConnection client callbacks
//----------------------------------------------------------------------------

function GameConnection::initialControlSet(%this) {
	echo("*** Initial Control Object");

	// The first control object has been set by the server
	// and we are now ready to go.

	// first check if the editor is active
	if (!Editor::checkActiveLoadDone()) {
		if ($Game::Menu) {
			menuLoadGhostsComplete();
		} else if (RootGui.getContent() != PlayGui.getId()) {
			RootGui.setContent(PlayGui);
		}
		applyGraphicsQuality();
		//Reload graphics
		loadSkyboxTextures();

		// enable interior render buffering.
		// Aka activate interior shaders.
		enableInteriorRenderBuffers();
		findMarbleDatablocks();

		adjustFrictions();

		//Disable marble interpolation for fast mode
		enableInterpolation(!$pref::FastMode);
	}
}

function GameConnection::setLagIcon(%this, %state) {
	if (%this.getAddress() $= "local")
		return;
	LagIcon.setVisible(%state $= "true");
}

function GameConnection::onConnectionAccepted(%this) {

	// Called on the new connection object after connect() succeeds.
	LagIcon.setVisible(false);
	$Event::Modes = ""; // Disable this bs

	clientCbOnServerJoin();
}

function GameConnection::onConnectionTimedOut(%this) {
	// Called when an established connection times out
	disconnectedCleanup(false);
	MessageBoxOK("TIMED OUT", "The server connection has timed out.");
}

function GameConnection::onConnectionDropped(%this, %msg) {
	switch$ (%msg) {
	case "CR_INVALID_PROTOCOL_VERSION":
		%error = "Incompatible protocol version: Your game version is not compatible with this server.";
	case "CR_INVALID_CONNECT_PACKET":
		%error = "Internal Error: badly formed network packet";
	case "CR_YOUAREBANNED":
		%error = "You are banned from this server.";
	case "CR_SERVERFULL":
		%error = "This server is full.";
	case "CHR_PASSWORD":
		// XXX Should put up a password-entry dialog.
		RootGui.setContent(LBChatGui);
		RootGui.pushDialog(MPJoinServerDlg);
		MPJoinServerDlg.pushPassword(MPJoinServerDlg.joinIP, $MP::ServerPassword !$= "");
		$MP::ServerPassword = "";
		MPJoinServerDlg.joining = false;

		disconnectedCleanup(true);
		return;
	case "CHR_PROTOCOL":
		%error = "Incompatible protocol version: Your game version is not compatible with this server.";
	case "CHR_CLASSCRC":
		%error = "Incompatible game classes: Your game version is not compatible with this server.";
	case "CHR_INVALID_CHALLENGE_PACKET":
		%error = "Internal Error: Invalid server response packet";
	case "SERVER_CLOSE":
		%error = "The server was closed.";
	case "CRC_FAKE":
		%error = "Your leaderboards session was invalid. Please log out of the leaderboards and log in again.";
	case "CRC_NOPE":
		%error = "Incompatible game scripts: Your game version is not compatible with this server.";
	case "VALID_FAIL":
		%error = "Your leaderboards session could not be validated.";
	case "MIN_RATING":
		%error = "Your rating is too low to play on this server.";
	case "":
		%error = "Connection timed out.";
	default:
		%error = %msg;
	}
	disconnectedCleanup(false);
	MessageBoxOK("DISCONNECT", "The server has dropped the connection:" NL %error);
}

function GameConnection::onConnectionError(%this, %msg) {
	// General connection error, usually raised by ghosted objects
	// initialization problems, such as missing files.  We'll display
	// the server's connection error message.
	disconnectedCleanup(false);
	MessageBoxOK("DISCONNECT", $ServerConnectionErrorMessage @ " (" @ %msg @ ")" );
}


//----------------------------------------------------------------------------
// Connection Failed Events
// These events aren't attached to a GameConnection object because they
// occur before one exists.
//----------------------------------------------------------------------------

function GameConnection::onConnectRequestRejected(%this, %msg) {
	switch$ (%msg) {
	case "CR_INVALID_PROTOCOL_VERSION":
		%error = "Incompatible protocol version: Your game version is not compatible with this server.";
	case "CR_INVALID_CONNECT_PACKET":
		%error = "Internal Error: badly formed network packet";
	case "CR_YOUAREBANNED":
		%error = "You are banned from this server.";
	case "CR_SERVERFULL":
		%error = "This server is full.";
	case "CHR_PASSWORD":
		// XXX Should put up a password-entry dialog.
		RootGui.setContent(LBChatGui);
		RootGui.pushDialog(MPJoinServerDlg);
		MPJoinServerDlg.pushPassword(MPJoinServerDlg.joinIP, $MP::ServerPassword !$= "");
		$MP::ServerPassword = "";
		MPJoinServerDlg.joining = false;

		disconnectedCleanup(true);
		return;
	case "CHR_PROTOCOL":
		%error = "Incompatible protocol version: Your game version is not compatible with this server.";
	case "CHR_CLASSCRC":
		%error = "Incompatible game classes: Your game version is not compatible with this server.";
	case "CHR_INVALID_CHALLENGE_PACKET":
		%error = "Internal Error: Invalid server response packet";
	default:
		%error = "Connection error.  Please try another server.  Error code: (" @ %msg @ ")";
	}
	disconnectedCleanup(false);
	MessageBoxOK("REJECTED", %error);
}

function GameConnection::onConnectRequestTimedOut(%this) {
	disconnectedCleanup(false);
	MessageBoxOK("TIMED OUT", "Your connection to the server timed out.");
}


//-----------------------------------------------------------------------------
// Disconnect
//-----------------------------------------------------------------------------

function exitGame(%force) {
	clientCmdCbOnMissionEnded(); //Because commands won't get through

	resumeGame();
	endMission(true);
	disconnect();
}

function disconnect(%auto) {
	resumeGame();
	if ($Game::UseMenu && (!$Game::Menu && !$Game::Introduction)) {
		//For the PQ level select, we have our own method of this
		menuMissionExit();
		return;
	}

	// flush GL interior rendering buffers before deleting the interiors
	// within the scenegraph
	disableInteriorRenderBuffers();
	flushInteriorRenderBuffers();
	cleanupReflectiveMarble();

	// Delete the connection if it's still there.
	while (isObject(ServerConnection))
		ServerConnection.delete();
	disconnectedCleanup(%auto);

	// Call destroyServer in case we're hosting
	destroyServer();
}

function disconnectedCleanup(%auto) {
	// Clear misc script stuff
	HudMessageVector.clear();
	PG_TeamChatText.setValue("");
	PM_TeamChatText.setValue("");

	if (isObject(MusicPlayer))
		MusicPlayer.stop();

	// Clear all print messages
	clientCmdclearBottomPrint();
	clientCmdClearCenterPrint();

	clientCbOnServerLeave();
	clearClientTriggerList();

	// Back to the launch screen
	%needInit = mp();
	if (!%auto) {
		if ($LB::loggedin) {
			RootGui.setContent(LBChatGui);
			if (MPJoinServerDlg.joining || $Server::ServerType $= "MultiPlayer") {
				RootGui.pushDialog(MPJoinServerDlg);
				MPJoinServerDlg.joining = false;
			} else {
				RootGui.setContent(PlayMissionGui);
			}
		} else {
			if (!$Game::UseMenu || $Game::Menu || $Game::Introduction) {
				RootGui.setContent(MainMenuGui);
			}
		}

		// Reset These
		$LB::Kill = false;
	}

	//Not loading anymore
	$Client::Loaded = false;
	$Client::Loading = false;
	$Menu::Loaded = false;
	$Menu::Loading = false;
	$Server::Loaded = false;
	$Server::Loading = false;
	$loadingMission = false;

	//PQ UI variables
	$Game::Introduction = false;
	$Game::Menu = false;

	//Misc things that should go away
	$MP::Camera = -1;
	$MP::TeamMode = 0;
	$MP::ServerChat = "";
	$MP::TeamChat = "";

	MPUpdateServerChat();
	updateTeamChat();

	//These indicated that we're on a server
	$Server::_Dedicated = false;
	$Server::Dedicated = false;
	$Server::Hosting = false;
	$Server::Lobby = false;
	$Server::ServerType = "";
	$Server::Platform = "";

	//Clean Spectator
	$SpectateFlying = false;
	$SpectateMode = false;
	$spectatorIndex = 0;
	$spectatorPerson = -1;
	clearClientModes();

	if (isCannonActive())
		clientCmdLeaveCannon();

	deleteVariables("$Demo::Blast*");

	deleteVariables("$MP::ValidMission*");
	deleteVariables("$MP::InvalidMission*");

	// Dump anything we're not using
	clearTextureHolds();
	unloadTimerTextures();
	purgeResources();
	cleanupEmitters();
	stopDemo();
	clientClearPaths();
	clearSyncTodo();

	//Back to our original selection
	MarbleSelectDlg.loadPrefs();

	PlayerList.clear();
	PlayerObjectGroup.clear();

	if (%needInit) {
		PlayMissionGui.init();
	}
}

