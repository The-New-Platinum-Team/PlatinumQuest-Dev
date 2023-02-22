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

// Variables used by server scripts & code.  The ones marked with (c)
// are accessed from code.  Variables preceeded by Pref:: are server
// preferences and stored automatically in the ServerPrefs.cs file
// in between server sessions.
//
//    (c) Server::ServerType              {SinglePlayer, MultiPlayer}
//    (c) Server::GameType                Unique game name
//    (c) Server::Dedicated               Bool
//    ( ) Server::MissionFile             Mission .mis file name
//    (c) Server::MissionName             DisplayName from .mis file
//    (c) Server::MissionType             Not used
//    (c) Server::PlayerCount             Current player count
//    (c) Server::GuidList                Player GUID (record list?)
//    (c) Server::Status                  Current server status
//
//    (c) Pref::Server::Name              Server Name
//    (c) Pref::Server::Password          Password for client connections
//    ( ) Pref::Server::AdminPassword     Password for client admins
//    (c) Pref::Server::Info              Server description
//    (c) Pref::Server::MaxPlayers        Max allowed players
//    (c) Pref::Server::RegionMask        Registers this mask with master server
//    ( ) Pref::Server::BanTime           Duration of a player ban
//    ( ) Pref::Server::KickBanTime       Duration of a player kick & ban
//    ( ) Pref::Server::MaxChatLen        Max chat message len
//    ( ) Pref::Server::FloodProtectionEnabled Bool

//-----------------------------------------------------------------------------


//-----------------------------------------------------------------------------

function initServer() {
	echo("\n--------- Initializing FPS: Server ---------");

	// Server::Status is returned in the Game Info Query and represents the
	// current status of the server. This string sould be very short.
	$Server::Status = "Unknown";

	// The common module provides the basic server functionality
	initBaseServer();

	// Load up game server support scripts
	exec("./scripts/commands.cs");
	exec("./scripts/centerprint.cs");
	exec("./scripts/game.cs");
	exec("./scripts/settings.cs");
	exec("./scripts/speedrun.cs");
}


//-----------------------------------------------------------------------------

function initDedicated() {
	enableWinConsole(true);
	echo("\n--------- Starting Dedicated Server ---------");

	schedule(100, 0, fixDedicatedShit);

	//Only 60fps max otherwise your server will explode
	if ($pref::Server::TickInterval $= "")
		setTickInterval(16);
	else
		setTickInterval($pref::Server::TickInterval);

	// Make sure this variable reflects the correct state.
	$Server::Dedicated = true;

	// Let people control this server!
	$Server::Controllable = true;

	// The server isn't started unless a mission has been specified.
	if ($missionArg !$= "") {
		$Server::MissionFile = $missionArg;
//      createServer("MultiPlayer", $missionArg);
//      loadMission($missionArg, true);
	} else
		echo("No mission specified (use -mission filename)");
}

function fixDedicatedShit() {
	// Things we need
	exec($usermods @ "/client/ui/lb/main.cs");

	// Fix master server
	exec($usermods @ "/shared/mp/defaults.cs");

	// Client game modes need to be activated too
	exec($usermods @ "/client/scripts/modes.cs");
	loadClientGameModes();

	// Server stuff for MP (for initDedicatedServer)
	exec("./scripts/mp/main.cs");

	// Marbles
	exec($usermods @ "/server/scripts/mp/marbleList.cs");

	// Validate ignition so we can play
	if ($platform $= "x86UNIX")
		new IgnitionObject().validate();

	$Server::Started = true;
	schedule(1000, 0, initDedicatedServer);
}
