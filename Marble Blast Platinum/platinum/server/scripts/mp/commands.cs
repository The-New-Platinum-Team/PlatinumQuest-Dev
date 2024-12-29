//------------------------------------------------------------------------------
// Multiplayer Package
// serverCmds.cs
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

function serverCmdReady(%client, %ready) {
	%client.ready = %ready;
	updatePlayerlist();
}

// pregame play - start the match
function serverCmdPreGamePlay(%client, %override) {
	// make sure ALL clients are ready unless we overrode it.
	pruneFakeClients();
	if (getRealPlayerCount() != $MP::ReadyCount && !%override) {
		commandToClient(%client, 'HostNotReady');
		return;
	}

	if (%client.isHost()) {
		serverPreGamePlay(%override);
	}
}

function serverPreGamePlay(%override) {
	//Fix people being able to start game a lot of times #1176
	if ($Server::Started) {
		error("Trying to start game that is already started!");
		return;
	}

	// If we overrode, we need to force spectate on clients who are not ready.
	if (%override) {
		%max = Mode::callback("getMaxSpectators", getRealPlayerCount() - 1);

		%specCount = 0;
		%count = ClientGroup.getCount();
		for (%i = 0; %i < %count; %i++) {
			%cl = ClientGroup.getObject(%i);
			if (!%cl.ready || %cl.spectating) {
				%specCount ++;
			}
		}

		if (%specCount <= %max) {
			//Everyone who is not ready needs to spectate
			for (%i = 0; %i < %count; %i++) {
				%cl = ClientGroup.getObject(%i);
				if (!%cl.ready) {
					serverCmdSetSpectate(%cl, true);
				}
			}
		}
	}

	serverStartGame();
}

// gets the mouse button for server sided check clicking
function serverCmdMouseFire(%client, %mousefire) {
	%client.mouseFire = %mousefire;
	MPOutofBounds();
}

// for the respond key
function serverCmdQuickRespawn(%client) {
	if (!$Game::Finished && $MPPref::AllowQuickRespawn && (!$MPPref::Server::CompetitiveMode || !$Game::isMode["hunt"])) {
		if (%client.canQuickRespawn) {
			%client.quickRespawnPlayer();
			%client.setQuickRespawnStatus(false);
			%client.schedule(Mode::callback("getQuickRespawnTimeout", $MP::QuickSpawnTimeout, new ScriptObject() {
				client = %client;
				_delete = true;
			}), "setQuickRespawnStatus", true);
		}
	}
}

function serverCmdUpdateMarble(%client, %marble) {
	// Replay has its own setting of skin choice.
	if ($playingDemo)
		return;

	%client.skinChoice = %marble;
	if ($Game::Running && isObject(%client.player)) {
		// Update their player
		%client.updateGhostDatablock();
	}

	%us = MPGetMyMarble();
	if (isObject(%us))
		%us.reloadShader();

	//Update player lists
	updatePlayerlist();
	//Because playerlist is on the next frame too
	if (isObject(%client.player)) {
		onNextFrame(commandToAll, 'UpdateMarbleShape', %client.player.getSyncId());
	}
}

function serverCmdItemCollision(%client, %position, %cid) {
	// They said they collided. Did they really?
	%obj = -1;

	// Grab it from MissionGroup
	for (%i = 0; %i < MissionGroup.getCount(); %i ++) {
		%temp = MissionGroup.getObject(%i);

		// only check items!
		if (%temp.getClassName() $= "Item") {
			if (%temp.getPosition() $= %position) {
				%obj = %temp;
				break;
			}
		}
	}

	// Try MissionCleanup too
	if (%obj == -1) {
		for (%i = 0; %i < MissionCleanup.getCount(); %i ++) {
			%temp = MissionCleanup.getObject(%i);
			// only check items!
			if (%temp.getClassName() $= "Item") {
				if (%temp.getPosition() $= %position) {
					%obj = %temp;
					break;
				}
			}
		}
	}

	// If it doesn't exist, they didn't collide
	if (%obj == -1) {
		commandToClient(%client, 'NoCollision', %cid);
		return;
	}

	// If it's still showing, they didn't collide either
	if (!%obj.isHidden()) {
		// If they've said they picked it up though, then they have
		if (%client.gemPickup[%obj])
			return;

		commandToClient(%client, 'NoCollision', %cid);
		return;
	}
}

//-----------------------------------------------------------------------------
// CRC check
// CRC validation will check to ensure that clients are not cheating.
// although not totally perfect, it will provide a sufficient amount
// of protection and will also prevent hacked up servers from being used.
// Note this will only CRC the .cs.dso files
//
// Also will check .cs.dso file counts to ensure that we dont have
// additional scripts

// This method brakes off from onConnect, clients have to pass this check
// in order to finish connecting to the server
function GameConnection::validateCRC(%this) {
	// It's the client's job to send the correct data.
	// The server doesn't care that they might not like using the little extra
	// bit of power to figure out which files to send. It's their job. They have
	// no say in it. If they say no, then they miss out on onConnect.

	// Hold the client in a separate group until they've finished. We don't
	// want them clogging up ClientGroup, now do we?
	if (!isObject(HoldGroup))
		RootGroup.add(new SimGroup(HoldGroup));

	HoldGroup.add(%this);

	// They should know what to send.
	commandToClient(%this, 'CheckCRC');
}

function serverCmdStartCRC(%client) {
	// Oh boy. The client is sending us CRCs. How joyful. </sarcasm>
	// Let's just get this over with and kick 'em if we can!

	%client.checkingCRC = true;
	%client.failedCRC = false;
}

function serverCmdFileCRC(%client, %file, %crc) {
	// Here's a CRC coming in from %client! Let's hope they get it wrong
	// so we can kick them off the server!

	// No point wasting precious server CPU if they've already failed
//   if (%client.failedCRC)
//      return;

	// If they try to send us a file that we don't have, it's probably hax
	// or something we couldn't handle if we tried. Just kick 'em off.
	// if (!isFile(%file)) {
	// 	commandToClient(%client, 'CRCError', fileBase(%file) @ fileExt(%file) @ " unknown file");
	// 	devecho("\c2" @ %client.getUsername() SPC "unknown file" SPC %file @ "!");
	// 	// Haha, sucker!
	// 	%client.failedCRC = true;
	// 	return;
	// }

	// // THOUGHT YOU COULD GET AWAY WITH IT, HUH? NOPE.
	// if ($MP::ServerCRC[%file] !$= %crc) {
	// 	commandToClient(%client, 'CRCError', fileBase(%file) @ fileExt(%file) @ " invalid crc (" @ %crc SPC "!=" SPC $MP::ServerCRC[%file] @ ")");
	// 	devecho("\c2" @ %client.getUsername() SPC "invalid file crc" SPC %file SPC "(" @ %crc SPC "!=" SPC $MP::ServerCRC[%file] @ ")");
	// 	// Haha, sucker!
	// 	%client.failedCRC = true;
	// 	return;
	// }

	// Hopefully they reach here, as then the file is correct. The next
	// message will come through any moment, let's see how they fare.

	%client.crcSuccess[%file] = true;
}

// Make this "true" in the release build. We need this false for
// dedicated server though.
$CRC_NOPE = (!$Server::Dedicated);
$LB::ValidateSessions = true;

function serverCmdFinishCRC(%client, %cFiles) {
	// if (%client.failedCRC) {
	// 	devecho("\c2" @ %client._name SPC "failed CRC check!");
	// 	// Hahahahahahahahahaha NO.
	// 	if (!%client.isSuperAdmin) {
	// 		if ($CRC_NOPE) {
	// 			%client.delete("CRC_NOPE");
	// 			return;
	// 		}
	// 	}
	// }

	// // Ok fine, they've passed SO FAR. Will they pass the final test?
	// for (%i = 0; %i < $MP::ServerFiles; %i ++) {
	// 	%file = $MP::ServerFile[%i];
	// 	if (%client.crcSuccess[%file] $= "" && $fileExec[%file] !$= "") {
	// 		devecho("\c2" @ %client._name SPC "missing file" SPC %file @ "!");
	// 		// Caught you! Thought you could get away without that one pesky
	// 		// file that we needed. Get off my server, damned kids.
	// 		if (!%client.isSuperAdmin) {
	// 			if ($CRC_NOPE) {
	// 				%client.delete("CRC_NOPE");
	// 				return;
	// 			}
	// 		}
	// 	}

	// 	%client.crcSuccess[%file] = "";
	// }

	// %cFiles -= %client.crcExtra;

	// // Ok, here's the real test. Did they send the right values for %files?
	// if ($MP::ServerFiles != %cFiles) {
	// 	// Well, I guess you get to sit and think about what you just did
	// 	// in the naughty corner of NOPE!
	// 	devecho("\c2" @ %client._name SPC "invalid file count! (" @ %cFiles SPC "!=" SPC $MP::ServerFiles @ ")");
	// 	if (!%client.isSuperAdmin) {
	// 		if ($CRC_NOPE) {
	// 			%client.delete("CRC_NOPE");
	// 			return;
	// 		}
	// 	}
	// }

	// HOLY SHIT THEY ACTUALLY PASSED THE CRC CHECK. WHAT ARE THE CHANCES
	// OF THIS ACTUALLY HAPPENING? (oh god I hope it's > 50%)

	devecho("\c3" @ %client._name SPC "passed CRC check");

	// Clear this crap, nobody should need to see it
	%client.failedCRC = "";
	%client.checkingCRC = "";

	// Ok so now they think they're getting in. Right. Uh huh. Prove it.
	commandToClient(%client, 'VerifySession');
}

function initServerCRC() {
	$MP::ServerFiles = 0;
	%exp = "*.dso";
	for (%file = findFirstFile(%exp); %file !$= ""; %file = findNextFile(%exp)) {
		if (strPos(strlwr(%file), "prefs.cs") != -1 || strPos(strlwr(%file), ".svn") != -1 || strPos(strlwr(%file), "config.cs") != -1 || strPos(strlwr(%file), "banlist.cs") != -1)
			continue;
		if (filePath(filePath(filePath(%file))) $= ($usermods @ "/data/multiplayer"))
			continue;
		//Ignore mcs.dso
		if (fileExt(%file) $= ".dso" && fileExt(fileBase(%file)) $= ".mcs")
			continue;

		$MP::ServerFile[$MP::ServerFiles] = %file;
		$MP::ServerCRC[%file] = getFileCRC(%file);
		$MP::ServerFiles ++;
	}
}

function serverCmdVerifySession(%client, %session, %dev) {
	// I don't even
	if (%this.verified)
		return;

	// They sent us their dev status, let's hope they're not lying!
	%client.dev = %dev;

	// So we have their session... now let's verify it with the server
	// This function will call completeValidation() with the results
	statsVerifyPlayer(%client, %session);
}

function GameConnection::completeValidation(%this, %valid, %message) {
	// I don't even
	if (%this.verified)
		return;

	if (!%valid) {
		if (!%this.isSuperAdmin) {
			// Bahahahahahaha, you fail!
			devecho("\c2Client" @ %client._name SPC "validation error: \"" @ %message @ "\"!");
			%this.delete(%message $= "" ? "VALID_FAIL" : %message);
			return;
		} else {
			// Host and not valid... playing offline or something?
			$Server::Offline = true;
		}
	}

	commandToClient(%this, 'VerifySuccess');

	// We should know if they're verified
	%this.verified = true;

	// Well, we should probably let them in to the clientGroup
	ClientGroup.add(%this);

	// Let them into the pearly gates of ServerVille
	%this.finishConnect();
}
