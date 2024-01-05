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

//Why not
setPrintTime(true);

// Must be called so we can get dedicated support
parseArgs();

deleteFile(expandFilename("./core/ui/cache/.backup.gui"));
deleteFile(expandFilename("./core/ui/cache/.backup.gui.dso"));

// Dedicated servers require external console usage. Don't worry. We
// disable all LB stuff if they're on a dedicated ;)
if (!$Server::Dedicated) {
	// This should be enough to prevent use of the external console,
	// it is the earliest point it can "safely" be disabled.
	enableWinConsole(false);

	// It might be an idea here to obfuscate this string below,
	// so that at a glance they can't peek in this file's dso
	// and find why they can't use the external console

	// this is so that the client can't detect which letters are being
	// obfuscated.
	$null = "a"@"b"@"c"@"d"@"e"@"f"@"g"@"h"@"i"@"j"@"k"@"l"@"m"@"n"@"o"@"p"@"q"@"r"@"s"@"t"@"u"@"v"@"w"@"x"@"y"@"z"@"A"@"B"@"C"@"D"@"E"@"F"@"G"@"H"@"I"@"J"@"K"@"L"@"M"@"N"@"O"@"P"@"Q"@"R"@"S"@"T"@"U"@"V"@"W"@"X"@"Y"@"Z"@"1"@"2"@"3"@"4"@"5"@"6"@"7"@"8"@"9"@"0"@"("@")"@"{"@"}"@"["@"]";
	deleteVariables("$null");

	// Good enough for science...
	eval("f"@"u"@"n"@"c"@"t"@"i"@"o"@"n"@" "@"e"@"n"@"a"@"b"@"l"@"e"@"W"@"i"@"n"@"C"@"o"@"n"@"s"@"o"@"l"@"e"@"("@")"@" "@"{"@"}");
	eval("f"@"u"@"n"@"c"@"t"@"i"@"o"@"n"@" "@"d"@"b"@"g"@"S"@"e"@"t"@"P"@"a"@"r"@"a"@"m"@"e"@"t"@"e"@"r"@"s"@"("@")"@" "@"{"@"}");
	eval("f"@"u"@"n"@"c"@"t"@"i"@"o"@"n"@" "@"t"@"e"@"l"@"n"@"e"@"t"@"S"@"e"@"t"@"P"@"a"@"r"@"a"@"m"@"e"@"t"@"e"@"r"@"s"@"("@")"@" "@"{"@"}");
}


// someone, anyone, some plebian tell me what does this do?
$fileExec[$con::file] = getFileCRC($con::file);

// lol 1.14's version is 14; wanted to do '15' but the server might be looking for '30' right now.
// we totally need 15 or something.

$THIS_VERSION = 2000; //Major Minor Patch Patch
$THIS_VERSION_NAME = "2.0.0";
$THIS_VERSION_SUB = "Dev";

//-----------------------------------------------------------------------------
// Load the core stuff before anything else
exec("./core/client/packages.cs");
exec("./core/main.cs");
exec("./shared/main.cs");

//-----------------------------------------------------------------------------
// Load up defaults console values.

// Defaults console values
exec("./client/defaults.cs");
exec("./server/defaults.cs");
exec("./client/scripts/version.cs");

// Preferences (overide defaults)
exec("./client/mbpPrefs.cs");
exec("./client/lbprefs.cs");

//This variable can fuck right off. Will crash your game on mission load if this
// is not empty string.
$pref::Server::Password = "";

//-----------------------------------------------------------------------------
// Package overrides to initialize the mod.
package marble {
	function displayHelp() {
		Parent::displayHelp();
		error(
		    // Should update this?
		    "Marble Mod options:\n"@
		    "  -mission <filename>    For dedicated or non-dedicated: Load the mission\n" @
		    "  -test <.dif filename>  Test an interior map file"
		);
	}

	function parseArgs() {
		// Call the parent
		Parent::parseArgs();

		// Arguments, which override everything else.
		for (%i = 1; %i < $Game::argc ; %i++) {
			%arg = $Game::argv[%i];
			%nextArg = $Game::argv[%i+1];
			%twoNextArg = $Game::argv[%i+2];
			%hasNextArg = $Game::argc - %i > 1;
			%hasTwoNextArgs = $Game::argc - %i > 2;

			switch$ (%arg) {
			case "-mission":
				$argUsed[%i]++;
				if (%hasNextArg) {
					$missionArg = %nextArg;
					$argUsed[%i+1]++;
					%i++;
				} else {
					error("Error: Missing Command Line argument. Usage: -mission <filename>");
					$argError = 1; // Present error at main menu
				}
			case "-marbleland":
				$argUsed[%i]++;
				if (%hasNextArg) {
					$marblelandArg = %nextArg;
					$argUsed[%i+1]++;
					%i++;
				} else {
					error("Error: Missing Command Line argument. Usage: -marbleland <id>");
					$argError = 1; // Present error at main menu
				}
			case "-server":
				$argUsed[%i]++;
				if (%hasNextArg) {
					$JoinGameAddress = %nextArg;
					$argUsed[%i+1]++;
					%i++;
				}
			case "-test":
				$argUsed[%i]++;
				if (%hasNextArg) {
					$Editor::Enabled = true;
					$interiorArg = %nextArg;
					$argUsed[%i+1]++;
					%i++;
				} else {
					error("Error: Missing Command Line argument. Usage: -test <interior filename>");
					$argError = 2; // Present error at main menu
				}

			case "-appear":
				$argUsed[%i]++;
				if (%hasNextArg) {
					$appearance = %nextArg;
					$argUsed[%i+1]++;
					%i++;
				} else
					error("Error: Missing Command Line argument. Usage: -appear <appearance>");
			case "-resolution":
				if (%hasTwoNextArgs) {
					$pref::Video::Resolution = %nextArg SPC %twoNextArg SPC getWord($pref::Video::resolution, 2);
					schedule(100, 0, setResolution, %nextArg, %twoNextArg);

					$argUsed[%i]++;
					$argUsed[%i+1]++;
					$argUsed[%i+2]++;
					%i += 2;
				} else
					error("Error: Missing Command Line argument. Usage: -resolution <width> <height>");
			case "-offline":
				if ($Server::Dedicated)
					$Server::Offline = true;
				else
					$Game::Offline = true;
				$argUsed[%i]++;
			}
		}
	}

	function onStart() {
		echo("Version" SPC $THIS_VERSION_NAME @ "-" @ $THIS_VERSION_SUB);

		Parent::onStart();
		echo("\n--------- Initializing MOD: Platinum ---------");

		// Load the scripts that start it all...
		exec("./client/init.cs");
		exec("./server/init.cs");
		exec("./data/init.cs");

		// Server gets loaded for all sessions, since clients
		// can host in-game servers.
		initServer();

		// Start up in either client, or dedicated server mode
		if ($Server::Dedicated)
			initDedicated();
		else {
			initClient();
		}
	}

	function onExit() {
		echo("------------- QUITTING -------------");

		echo("Exporting client prefs...");
		export("$pref::*", "~/client/mbpPrefs.cs", False);
		export("$LBPref::*", "~/client/lbprefs.cs", False);

		MPsavePrefs();

		//So we don't hear the menu when we quit
		alxSetChannelVolume(1, 0);
		alxSetChannelVolume(2, 0);

		// possibly crashing because of serverconnections
		$quitting = true;
		echo("Disconnecting...");
		disconnect(true);

		// clean up shaders to prevent GL leak
		echo("Cleaning up shaders...");
		destroyShaders();

		Parent::onExit();
	}

	function startHeartbeat() {
		backtrace();
		if ($Server::ServerType $= "" || !$Server::Hosting)
			return;

		echo("Starting heartbeat!");
		$pref::Net::DisplayOnMaster = "";
		onServerInfoQuery();
		Parent::startHeartbeat();
	}

	function allowConnections(%allow) {
		backtrace();
		if ($Server::ServerType $= "" || !$Server::Hosting) {
			Parent::allowConnections(false);
			return;
		}

		echo((%allow ? "Allowing" : "Disallowing") @ " connections!");
		Parent::allowConnections(%allow);
	}

	function stopHeartbeat() {
		backtrace();
		echo("Stopping heartbeat!");
		$pref::Net::DisplayOnMaster = "Never";
		onServerInfoQuery();
		Parent::stopHeartbeat();
	}

	function trace(%on, %untick) {
//      echo("TRACE IS" SPC %on);
		backtrace();
		$tracing = %on;
		if (%on && %untick)
			deactivatePackage(Tickable);
		else if ($LB)
			activatePackage(Tickable);
		Parent::trace(%on);
	}

	function commandToClient(%client, %cmd, %a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a10, %dummy) {
		if (%dummy !$= "") {
			error("Too many args passed into commandToClient!");
		}
		if ($echoCmd)
			echo("commandToClient("@%client@", \'"@getTaggedString(%cmd)@"\', \""@%a0@"\", \""@%a1@"\", \""@%a2@"\", \""@%a3@"\", \""@%a4@"\", \""@%a5@"\", \""@%a6@"\", \""@%a7@"\", \""@%a8@"\", \""@%a9@"\", \""@%a10@"\"); ");
		if (%client.getClassName() !$= "GameConnection") {
			error("Command to client tried to call on a fake client!");
			return;
		}
		Parent::commandToClient(%client, %cmd, %a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a100);
	}

	function warn(%a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a10) {
		Parent::warn("Warning: " @ %a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a10);

		//Do something so we can see this in tracelogs
		%preBuf = $Con::LogBufferEnabled;
		if (!($DEBUG || $Server::Dedicated)) {
			$Con::LogBufferEnabled = false;
		}
		backtrace();
		$Con::LogBufferEnabled = %preBuf;
	}
	function error(%a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a10) {
		Parent::error("Error: " @ %a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a10);

		//Do something so we can see this in tracelogs
		%preBuf = $Con::LogBufferEnabled;
		if (!($DEBUG || $Server::Dedicated)) {
			$Con::LogBufferEnabled = false;
		}
		backtrace();
		$Con::LogBufferEnabled = %preBuf;
	}
};
// Client package
activatePackage(marble);

function listResolutions() {
	%deviceList = getDisplayDeviceList();
	for(%deviceIndex = 0; (%device = getField(%deviceList, %deviceIndex)) !$= ""; %deviceIndex++) {
		%resList = getResolutionList(%device);
		for(%resIndex = 0; (%res = getField(%resList, %resIndex)) !$= ""; %resIndex++)
			echo(%device @ " - " @ getWord(%res, 0) @ " x " @ getWord(%res, 1) @ "(" @ getWord(%res, 2) @ " bpp)");
	}
}

// Migrated from root main.cs so IT DOESN'T SHOW UP IN THE CONSOLE
function devecho(%text) {
	//Do something so we can see this in tracelogs
	if ($DEBUG) {
		echo("DEBUG:" SPC %text);
	}
}

function lb() {
	%ret = $LB::LoggedIn || $Server::Dedicated;
	return %ret;
}

function mp() {
	return lb() && $Server::ServerType $= "MultiPlayer";
}
