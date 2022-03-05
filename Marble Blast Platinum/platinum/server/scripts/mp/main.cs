//------------------------------------------------------------------------------
// Multiplayer Package: Iteration 7
// main.cs
// Because this is totally possible, we're totally doing it... AGAIN :D
// Created: 1/1/13 (yay 2013)
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

function initMultiplayerServer() {
	// All the server commands
	exec("./commands.cs");

	// Game timer control
	exec("./time.cs");

	// Lobby code for servers
	exec("./lobby.cs");

	// Callbacks on the server-side
	exec("./callbacks.cs");

	// Team support
	exec("./team.cs");

	// Game connection commands for sending to clients
	exec("./gameConnection.cs");

	// Ghosting for server-side
	exec("./ghost.cs");

	// main server functions
	exec("./server.cs");

	// server particles
	exec("./particles.cs");

	// Blast
	exec("./blast.cs");

	// Collision scripts
	exec("./collision.cs");

	// server spectating
	exec("./spectator.cs");

	// server download of mission files
	exec("./download.cs");

	// Server chat and muting
	exec("./chat.cs");

	// Sync objects
	exec("./sync.cs");

	// "Cycle server" where it auto plays itself
	exec("./cycle.cs");
}

//-----------------------------------------------------------------------------

function initDedicatedServer() {
	// WHOOOO
	// So we need to replicate an actual server starting up

	enableWinConsole(true);

	// Dedicated things
	exec("./dcon.cs");
	exec("./dsupport.cs");

	// Set the game
	$CurrentGame = "Hunt";

	// Server variables
	$Server::Lobby = true;
	$Server::Hosting = true;
	$Server::Loaded = false;
	$Server::Loading = false;

	// TODO: take this out for release, although we might need it because
	// of dsupport.cs
	$CRC_NOPE = false;

	dParseArgs();

	if ($Pref::Server::Name $= "")
		$Pref::Server::Name = "Unnamed Dedicated Server";

	//Load mission list
	statsGetMissionList("Multiplayer");

	// Initialize the connection
	allowConnections(true);
	portInit(28000);

	// Create the server
	createServer("MultiPlayer");

	// Display it
	startHeartbeat();

	// Start up our io
	schedule(1000, 0, loadInput);
	schedule(1000, 0, printStatus);

	// Settings
	saveSettings();
}
