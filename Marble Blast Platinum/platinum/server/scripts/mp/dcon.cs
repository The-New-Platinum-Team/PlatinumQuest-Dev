//-----------------------------------------------------------------------------
// dcon.cs ("Dedicated Console")
// Multiplayer Hax Package
//
// Copyright (C) 2012 The Multiplayer Team
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//------------------------------------------------------------------------------

package dcon {
	function eval(%a0) {
		//If it's a dcon function, execute it
		if (dcon::func(getWord(%a0, 0)) != -1) {
			dcon::eval(%a0);
			return;
		}
		//Otherwise just go with regular eval
		Parent::eval(%a0);
	}

	function dcon::eval(%func) {
		//Check if the function exists, also get the function number
		if ((%i = dcon::func(getWord(%func, 0))) != -1) {

			//Check for the correct amount of args
			%length = getField($dcon::func[%i], 1);
			if (getWordCount(%func) > %length + 1 && !getField($dcon::func[%i], 2))
				return dcon::usage(%func);

			%long = getField($dcon::func[%i], 2);

			//Organize args
			%a0 = getWord(%func, 0);
			%a1 = (%long && %length < 2 ? getWords(%func, 1) : getWord(%func, 1));
			%a2 = (%long && %length < 3 ? getWords(%func, 2) : getWord(%func, 2));
			%a3 = (%long && %length < 4 ? getWords(%func, 3) : getWord(%func, 3));
			%a4 = (%long && %length < 5 ? getWords(%func, 4) : getWord(%func, 4));
			%a5 = (%long && %length < 6 ? getWords(%func, 5) : getWord(%func, 5));
			%a6 = (%long && %length < 7 ? getWords(%func, 6) : getWord(%func, 6));
			%a7 = (%long && %length < 8 ? getWords(%func, 7) : getWord(%func, 7));
			%a8 = (%long && %length < 9 ? getWords(%func, 8) : getWord(%func, 8));

			//Check for this
			if (%a0 $= "?") %a0 = "help";

			//Call the function based on the args
			if (%a0 $= "") return;
			if (%a1 $= "") return call("dcon" @ %a0);
			if (%a2 $= "") return call("dcon" @ %a0, %a1);
			if (%a3 $= "") return call("dcon" @ %a0, %a1, %a2);
			if (%a4 $= "") return call("dcon" @ %a0, %a1, %a2, %a3);
			if (%a5 $= "") return call("dcon" @ %a0, %a1, %a2, %a3, %a4);
			if (%a6 $= "") return call("dcon" @ %a0, %a1, %a2, %a3, %a4, %a5);
			if (%a7 $= "") return call("dcon" @ %a0, %a1, %a2, %a3, %a4, %a5, %a6);
			if (%a8 $= "") return call("dcon" @ %a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7);
			return call("dcon" @ %a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8);
		}
	}

	//Prints the usage of a function
	function dcon::usage(%func) {
		if ((%i = dcon::func(getWord(%func, 0))) != -1) {
			echo("| Usage:" SPC getField($dcon::func[%i], 3));
			return;
		}
	}

	//Gets the number of a function
	function dcon::func(%name) {
		for (%i = 0; %i < $dcon::funcc; %i ++) {
			if (getField($dcon::func[%i], 0) $= %name)
				return %i;
		}
		return -1;
	}

	//Adds a function to the list
	//Name: Function name
	//Args: Minimum number of args passed to function
	//Usage: "Usage" string that shows function possibilities
	//Help: One-line help text
	//Page: Multi-line specific help
	function dcon::addFunc(%name, %args, %long, %usage, %help, %page) {
		$dcon::func[$dcon::funcc] = %name TAB %args TAB %long TAB %usage TAB %help TAB %page;
		$dcon::funcc ++;
	}

	//---------------------------------------------------------------------------
	// Dcon functions
	//---------------------------------------------------------------------------

	//Print help for a function
	function dconhelp(%func) {
		echo("|------------------------------------------------------");
		if (%func $= "" || %func * 1 != 0) {
			//If there is no specified function, print the list
			%longest = 0;
			for (%i = 0; %i < $dcon::funcc; %i ++) {
				if (strlen(getField($dcon::func[%i], 0)) > %longest)
					%longest = strlen(getField($dcon::func[%i], 0));
			}
			for (%i = 0; %i < $dcon::funcc; %i ++)
				echo("|" SPC getField($dcon::func[%i], 0) SPC strRepeat(".", %longest - strlen(getField($dcon::func[%i], 0)) + 2) SPC getField($dcon::func[%i], 4));
		} else {
			//Print specific help
			if ((%i = dcon::func(%func)) != -1) {
				echo("|" SPC getField($dcon::func[%i], 0) SPC "-" SPC getField($dcon::func[%i], 4) NL
				     "| Takes" SPC getField($dcon::func[%i], 1) SPC(getField($dcon::func[%i], 1) == 1 ? "argument" : "arguments") @ "\n|");
				%page = getFields($dcon::func[%i], 5);
				for (%j = 0; %j < getFieldCount(%page); %j ++) {
					%field = getField(%page, %j);
					for (%k = 0; %k < mCeil(strlen(%field) / 77); %k ++)
						echo("|" SPC getSubStr(%field, 77 * %k, 77));
				}
			} else
				//The function doesn't exist
				echo("| Help: \"" @ %func @ "\" - Unknown function");
		}
		echo("|------------------------------------------------------");
	}

	function dconinfo() {
		echo("|------------------------------------------------------");
		echo("| Server Information:");
		echo("|");
		echo("| Players:" SPC $Server::PlayerCount);
		echo("| Mission File:" SPC $Server::MissionFile);
		echo("|------------------------------------------------------");
	}

	function dcondcon(%command) {
		echo("|------------------------------------------------------");
		if (%command $= "") %command = "info";
		switch$ (%command) {
		case "reload":
			exec($Con::File);
			return;
		case "info":
			echo("| Dcon Package");
			echo("| Current Version: 1.0");
			echo("| Function count:" SPC $dcon::funcc);
		case "disable":
			echo("| Deactivating package Dcon...");
			echo("| To reactivate, type:");
			echo("|");
			echo("| activatePackage(dcon);");
			deactivatePackage(dcon);
		}
		echo("|------------------------------------------------------");
	}

	function dconlist() {
		echo("|------------------------------------------------------");
		echo("| Currently" SPC ClientGroup.getCount() SPC "player(s) online:");

		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			echo("| " SPC %client.getDisplayName() @ " (" @ %client.getUsername() @ ")");
		}

		echo("|------------------------------------------------------");
	}

	function dconquit() {
		echo("|------------------------------------------------------");
		echo("| Shutting down master server connection...");
		echo("|------------------------------------------------------");
		stopHeartbeat();
		schedule(1000, 0, dconquit2);
	}

	function dconquit2() {
		if ($Master::Running)
			return schedule(100, 0, dconquit2);
		quit();
	}

	function dconclear() {
		//Should be about enough
		echo("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
	}

	function dconkick(%person) {
		echo("|------------------------------------------------------");
		if (%person $= "")
			dcon::usage("kick");
		else if (getClientByName(%person) == -1)
			echo("| Could not find player" SPC %person);
		else {
			echo("| Kicked" SPC %person);
			kick(%person);
		}
		echo("|------------------------------------------------------");
	}

	function dconban(%person) {
		echo("|------------------------------------------------------");
		if (%person $= "")
			dcon::usage("ban");
		else if (getClientByName(%person) == -1)
			echo("| Could not find player" SPC %person);
		else {
			echo("| Banned" SPC %person);
			ban(%person);
		}
		echo("|------------------------------------------------------");
	}

	function dconbanip(%person) {
		echo("|------------------------------------------------------");
		if (%person $= "")
			dcon::usage("banip");
		else if (getClientByName(%person) == -1)
			echo("| Could not find player" SPC %person);
		else {
			echo("| Banned" SPC %person SPC "by their IP" SPC getClientByName(%person).getIP());
			banip(%person);
		}
		echo("|------------------------------------------------------");
	}

	function dconrespawn(%person) {
		echo("|------------------------------------------------------");
		if (%person $= "")
			dcon::usage("respawn");
		else if (%person $= "all") {
			respawnAll();
			echo("| Respawned all players");
		} else if (getClientByName(%person) == -1)
			echo("| Could not find player" SPC %person);
		else {
			echo("| Respawned" SPC %person);
			getClientByName(%person).respawnPlayer();
		}
		echo("|------------------------------------------------------");
	}

	function dconmaster(%command) {
		echo("|------------------------------------------------------");
		if (%command $= "") %command = "info";
		switch$ (%command) {
		case "start":
			if ($Master::Started)
				echo("| Master server connection is already open!");
			else {
				startHeartbeat();
				echo("| Opening connection to master server...");
			}
		case "stop":
			if (!$Master::Started)
				echo("| Master server connection has not been opened!");
			else {
				stopHeartbeat();
				echo("| Closing connection to master server...");
			}
		case "info":
			echo("| Master Server Information:");
			echo("|");
			echo("| Connection Open:" SPC($Master::Active ? "Yes" : "No"));
			if ($Master::Active) {
				echo("| Server Name:" SPC $Pref::Server::Name);
				echo("| Server Mode:" SPC($MP::Teammode ? "Teams" : "Free for all"));
				echo("| Server Has Password:" SPC(($MPPref::Server::Password !$= "") ? "Yes" : "No"));
			}
			echo("|");
			echo("| Mod Identifier:" SPC $Master::Mod);
			echo("| Server Version:" SPC $MP::RevisionOn);
		}
		echo("|------------------------------------------------------");
	}

	function dconmission(%mission) {
		if (%mission $= "")
			dcon::usage("mission");
		else if ($Server::Lobby) {
			%file = resolveMissionFile(%mission);
			echo("|------------------------------------------------------");
			echo("| Loading mission info for mission:");
			echo("|" SPC %file);

			%info = getMissionInfo(%file);

			echo("| Got mission info as object:" SPC %info);
			echo("| Mission Name:" SPC %info.name);

			$MP::MissionObj = %info;
			$MP::MissionFile = %info.file;

			$MP::MissionType = %info.type;
			$MPPref::SelectedRow[%info.type] = %info.level;

			reloadAllPlayMission();

			echo("| Sent mission info to" SPC ClientGroup.getCount() SPC "clients");
			echo("|------------------------------------------------------");
		}
	}

	function dconset(%variable, %value) {
		if (%variable $= "" || %value $= "")
			dcon::usage("set");
		else {
			//Translate %variable into something we can use
			switch$ (strlwr(%variable)) {
			case "name" or "servername":
				$Pref::Server::Name = %value;
			case "max" or "maxplayers":
				$pref::Server::MaxPlayers = %value;
			case "port":
				$pref::Server::Port = %value;
				portInit(%value);
			case "info":
				$Pref::Server::Info = %value;
			case "teams":
				$MP::Teammode = %value;
				updateTeamMode();
			case "password":
				$MPPref::Server::Password = %value;
			default:
				echo("|------------------------------------------------------");
				echo("| Server variable list:");
				echo("| Name / ServerName: The server\'s name");
				echo("| Max / MaxPlayers: The maximum number of players");
				echo("|                   allowed on the server");
				echo("| Port: The server\'s port (default 28000)");
				echo("| Info: The server description/info");
				echo("| Teams: If teams mode is enabled");
				echo("| Password: The password for joining the server");
				echo("|------------------------------------------------------");
			}
		}
		startHeartbeat();
	}

	function dconscores() {
		// I like my info
		echo("|------------------------------------------------------");
		echo("| Scores List:");
		echo("|");
		%count = ClientGroup.getCount();

		for (%i = 0; %i < %count; %i ++) {
			%client = ClientGroup.getObject(%i);
			if (isRealClient(%client) && !%client.connected)
				continue;
			%score = %client.gemCount;
			echo("|" SPC %client.getUsername() @ ":" SPC %score SPC "(" @ %client.gemsFound[1] SPC %client.gemsFound[2] SPC %client.gemsFound[5] SPC %client.gemsFound[10] @ ")");
		}
		echo("|------------------------------------------------------");
	}

	function dconpreload() {
		if (!$Server::Preloaded && !$Server::Preloading)
			lobbyPreload($MP::MissionFile);
		else
			echo("Cannot preload at this time.");
	}

	function dconstart() {
		if ($Server::Preloaded)
			preloadFinish();
		else
			echo("Server is not preloaded!");
	}

	//---------------------------------------------------------------------------

	//Initialize
	function dcon::init() {
		$dcon::funcc = 0;

		dcon::addFunc("help", 1, false, "help [function]", "Shows this help screen",
		              "If help is not given any arguments, it will show the function listing."
		              NL "Otherwise, it will show help on a specified function.");

		dcon::addFunc("?", 1, false, "? [function]", "Substitute for help",
		              "If help is not given any arguments, it will show the function listing."
		              NL "Otherwise, it will show help on a specified function.");

		dcon::addFunc("info", 0, false, "info", "Shows server information",
		              "Info will print out server information including:"
		              NL "Player Count"
		              NL "Current Mission"
		              NL "Cheats Enabled");

		dcon::addFunc("dcon", 1, false, "dcon (reload|info|disable)", "Interface with the dcon package",
		              "Dcon will interact with the dcon package in the way specified."
		              NL ""
		              NL "Possible dcon commands are:"
		              NL "reload  - Reloads the dcon package"
		              NL "info    - Prints info about the dcon package (Default)"
		              NL "disable - Disables the dcon package");

		dcon::addFunc("list", 0, false, "list", "Lists currently online players",
		              "List will display a list of all players who are currently connected to the server.");

		dcon::addFunc("quit", 0, false, "quit", "Safely quits the server",
		              "Quit will stop the server, safely disconnecting from the master server.");

		dcon::addFunc("clear", 0, false, "clear", "Clears the console screen",
		              "Clear will clear the console window, but does not clear the console.log file.");

		dcon::addFunc("kick", 1, true, "kick <person>", "Kicks a player from the server",
		              "Kick will kick a player off the server."
		              NL "Kick will also set a short ban of 30 seconds for that player."
		              NL "The ban is to prevent automatic reconnecting to the server.");

		dcon::addFunc("ban", 1, true, "ban <person>", "Bans a player from the server",
		              "Ban will block a player from joining the server with the name given."
		              NL "Note that this is insecure, as names are not verified, and are"
		              NL "thus not persistant to any person. Use banip for more security."
		              NL "Ban also kicks a player from a server.");

		dcon::addFunc("banip", 1, true, "banip <person>", "Bans a player\'s IP from the server",
		              "Banip will block a player from joining the server from the IP they are"
		              NL "currently at. Note that this blocks all players from that IP, even"
		              NL "if they use a different name or are a different person.");

		dcon::addFunc("respawn", 1, true, "respawn (<person>|all)", "Respawns one or all players",
		              "Respawn will respawn the specified player back to the start point."
		              NL "If \"all\" is substituted for a name, respawn will respawn all players.");

		dcon::addFunc("master", 1, false, "master (start|stop|info)", "Interface with the master server connection",
		              "Master will let you view and modify settings used with the master server."
		              NL ""
		              NL "Possible master commands are:"
		              NL "start - Starts the server connection and adds the server to the master list."
		              NL "        Note: The master server connection is started by default"
		              NL "stop  - Stops the server connection and takes the server off the master list."
		              NL "info  - Prints info about the connection to the master server. (Default)");

		dcon::addFunc("mission", 1, true, "mission <mission name>", "Select a mission by its name",
		              "Mission selects a mission based on file name, e.g. \"mission Sprawl\""
		              NL "would select Sprawl as the mission. Please note that this can only be"
		              NL "used in the lobby, for obvious reasons.");

		dcon::addFunc("set", 2, true, "set <variable> <value>", "Sets a server variable to a given value",
		              "Set sets a server variable to a given value. Server variable list:"
		              NL "Name / ServerName, Max / MaxPlayers, Port, Info, Teams,"
		              NL "Password");

		dcon::addFunc("preload", 0, false, "preload", "Preloads the current mission",
		              "Preload loads the current mission for all clients on the server,"
		              NL "use start to start the mission after preloading");

		dcon::addFunc("start", 0, false, "start", "Starts the currently preloaded mission",
		              "Start sends all the preloaded clients to the ingame pre-game window.");

		//Why not?
		$Con::Prompt = "$ ";
		$Dcon::Active = true;

		echo("|------------------------------------------------------");
		echo("| DCon::Init complete");
		echo("|------------------------------------------------------");
	}

	function strrepeat(%str, %times) {
		%finish = "";
		for (%i = 0; %i < %times; %i ++)
			%finish = %finish @ %str;
		return %finish;
	}
};

activatePackage(dcon);
dcon::init();
