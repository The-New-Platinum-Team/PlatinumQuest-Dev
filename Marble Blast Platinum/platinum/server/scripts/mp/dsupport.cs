//------------------------------------------------------------------------------
// Multiplayer Package
// dsupport.cs
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

//$Radar::SearchRule
// 0 = ALL SHAPEBASE      (original radar spammy thing)
// 1 = GEMS               (automatic for Hunt / GemMadness modes; otherwise must specify)
// 2 = TIME TRAVELS       Only show "good" time travels (other ones are traps)
// 4 = END PAD            Show End Pad as objective / pad icon when collected all gems / hit quota
// 8 = CHECKPOINTS        Use a single icon, same with pads
// 16 = CANNONS
// 32 = POWERUPS
// we won't display powerups/hazards specifically since useless
// although in custom levels people like hiding those as 0.001 0.001 0.001 coz they're dicks
// so we can have people add those manually themselves so they can find out the hidden stuff

$Radar::Flags::None        = 0;
$Radar::Flags::Gems        = 1 << 0;
$Radar::Flags::TimeTravels = 1 << 1;
$Radar::Flags::EndPad      = 1 << 2;
$Radar::Flags::Checkpoints = 1 << 3;
$Radar::Flags::Cannons     = 1 << 4;
$Radar::Flags::Powerups    = 1 << 5;

$ScoreType::Time = 0;
$ScoreType::Score = 1;

function dParseArgs() {
	for (%i = 0; %i < $Game::argc; %i ++) {
		%arg = $Game::argv[%i];
		%nextArg = $Game::argv[%i+1];
		%hasNextArg = $Game::argc - %i > 1;

		switch$ (%arg) {
		case "-input":
			$argUsed[%i]++;
			if (%hasNextArg) {
				$inputfile = %nextArg;
				$argUsed[%i+1]++;
			} else {
				error("Error: Missing Command Line argument. Usage: -input <input file>");
			}
		case "-output":
			$argUsed[%i]++;
			if (%hasNextArg) {
				$outputfile = %nextArg;
				$argUsed[%i+1]++;
			} else {
				error("Error: Missing Command Line argument. Usage: -output <output file>");
			}
		case "-cycle":
			$argUsed[%i]++;

			echo("===================");
			echo(" CYCLE SERVER INIT ");
			echo("===================");

			schedule(3000, 0, startCycleServer);
		}
	}
}

function loadInput() {
	if (getFileCRC($inputfile) !$= $last) {
		$last = getFileCRC($inputfile);
		%conts = trim(fread($inputfile));

		echo("$ " @ %conts);
		eval(%conts);
		echo(""); //So we get output
	}

	cancel($loadInput);
	$loadInput = schedule(100, 0, loadInput);
}

function printStatus() {
	//Things we need:
	// Level, player count, team mode, version, host

	//Level
	if ($Server::Lobby) %status = "Lobby";
	else %status = MissionInfo.name;

	//Player Count
	%status = %status NL getRealPlayerCount();

	//Team mode
	%status = %status NL $MP::Teammode;

	//version
	%status = %status NL $MP::RevisionOn;

	//Host
	if (ClientGroup.getCount()) %status = %status NL ClientGroup.getObject(0).getUsername();
	else %status = %status NL "No Host";

	fwrite($outputfile, %status);

	cancel($printStatus);
	$printStatus = schedule(100, 0, printStatus);
}

function dedicatedUpdate() {
	if (getRealPlayerCount() > 0) {
		if (!isObject(GameConnection::getHost()) || GameConnection::getHost().isFake()) {
			dedicatedFindNewHost();
		}
	} else {
		//No players left, cancel the load
		lobbyReturn();
		resetSettings();
	}
}

function dedicatedFindNewHost(%oldHost) {
	resetSettings();
	if (isObject(%oldHost)) {
		//New host time!
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%cl = ClientGroup.getObject(%i);
			if (%cl.getId() != %oldHost.getId()) {
				//They are the new host now
				%cl.setHost(true);
				serverSendChat(LBChatColor("notification") @ "The Host has changed to " @ %cl.getDisplayName() @ ".");
				break;
			}
		}
	} else {
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.setHost(true);
			serverSendChat(LBChatColor("notification") @ "The Host has changed to " @ %client.getDisplayName() @ ".");
			break;
		}
	}
	MPinitLoops();
}

function GameConnection::injectScripts(%this) {
	//Nope
}

function saveSettings() {
	echo("Saving settings");

	for (%i = 0; %i < $MP::Server::Settings; %i ++) {
		%id = $MP::Server::Setting[%i, "id"];
		%variable = $MP::Server::Setting[%i, "variable"];
		%public = $MP::Server::Setting[%i, "public"];
		%name = $MP::Server::Setting[%i, "name"];

		//Not allowed to set these
		if (!%public) {
			continue;
		}

		//Only save new variables so we don't overwrite previous saves
		if ($MPPref::Server::Save[%id] $= "") {
			echo("New setting: " @ %name);
			$MPPref::Server::Save[%id] = getVariable(%variable);

			savePrefs(false);
		}
	}

	$MPPref::Server::SavedSettings = true;
}

function resetSettings() {
	echo("Resetting settings");

	if (!$MPPref::Server::SavedSettings) {
		error("Settings reset without prior save!");
		return;
	}

	for (%i = 0; %i < $MP::Server::Settings; %i ++) {
		%id = $MP::Server::Setting[%i, "id"];
		%variable = $MP::Server::Setting[%i, "variable"];
		%public = $MP::Server::Setting[%i, "public"];
		%name = $MP::Server::Setting[%i, "name"];

		//Not allowed to set these
		if (!%public) {
			continue;
		}

		//Only load saved variables
		if ($MPPref::Server::Save[%id] !$= "") {
			setVariable(%variable, $MPPref::Server::Save[%id]);
		}
	}
}

function GameConnection::sendInfo(%this) {
	saveSettings();

	commandToClient(%this, 'ServerSetting', "ForceSpectators", $MPPref::ForceSpectators);
	commandToClient(%this, 'ServerSetting', "MaxPlayers", $Pref::Server::MaxPlayers);

	%this.sendGameModes();
}

function GameConnection::sendGameModes(%this) {
	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%mode = ModeInfoGroup.getObject(%i);
		traceGuard();
		commandToClientLong(%this, 'GameModeList', %mode.getFields(), %mode.class, %mode.identifier);
		traceGuardEnd();
	}
}

function GameConnection::getHost() {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		if (ClientGroup.getObject(%i).isHost())
			return ClientGroup.getObject(%i);
	}

	return -1;
}

//HAX because hax
function ceval(%client, %text) {
	%maxChars = 255;
	for (%i = 0; %i < mCeil(strLen(%text) / %maxChars); %i ++) {
		messageClient(%client, 'MsgLoadMissionInfoPart', "", getSubStr(%text, %maxChars * %i, %maxChars));
	}
	messageClient(%client, 'MsgLoadInfoDone');
}

function cevall(%text) {
	%maxChars = 255;
	for (%i = 0; %i < mCeil(strLen(%text) / %maxChars); %i ++) {
		messageAll('MsgLoadMissionInfoPart', "", getSubStr(%text, %maxChars * %i, %maxChars));
	}
	messageAll('MsgLoadInfoDone');
}

function cevalh(%text) {
	eval(%text);
	%maxChars = 255;
	for (%i = 0; %i < mCeil(strLen(%text) / %maxChars); %i ++) {
		messageAll('MsgLoadMissionInfoPart', "", getSubStr(%text, %maxChars * %i, %maxChars));
	}
	messageAll('MsgLoadInfoDone');
}
