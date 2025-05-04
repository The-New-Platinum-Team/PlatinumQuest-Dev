//------------------------------------------------------------------------------
// Multiplayer Package
// serverChat.cs
//
// Copyright (c) 2015 The Platinum Team
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

function serverSendChat(%message) {
	commandToAll('PrivateMessage', %message);
}

function GameConnection::sendChat(%this, %message) {
	commandToClient(%this, 'PrivateMessage', %message);
}

// private chat
function serverCmdPrivateChat(%client, %message) {
	if ($Editor::Opened && EWorldEditor.checkChat(%client, %message))
		return;
	if (%client.checkSpam())
		return;
	if (%message $= "")
		return;
	if (getSubStr(%message, 0, 2) $= "/v") {
		if (%client.isGuest())
			return;
		if (!$MPPref::Server::AllowTaunts)
			return;
	}
	if (runServerChatCommand(%client, %message))
		return;
	if (Mode::callback("onServerChat", false, new ScriptObject() {
		client = %client;
		message = %message;
		_delete = true;
	})) {
		return;
	}

	echo("Server chat from" SPC %client.getUsername() @ ":" SPC %message);

	// don't send it to yourself you fool
	commandToAllExcept(%client, 'PrivateMessage', %client.getUsername(), %message);
}

function serverCmdTeamChat(%client, %message) {
	commandToTeam(%client.team, 'TeamChat', %client.getUsername(), Team::getTeamName(%client.team), Team::isTeamLeader(%client.team, %client), %message);
}

function serverCmdRandomMapSelected(%client, %mapName) {
	if (%client.checkSpam())
		return;
	%name = %client.getDisplayName();
	if (%client.isHost())
		%name = "The Host (" @ %name @ ")";
	serverSendChat(LBChatColor("notification") @ %name SPC "has rolled the random map" SPC %mapName @ ".");
}


function GameConnection::checkSpam(%this) {
	if (%this.getAddress() $= "local")
		return false;
	if (%this.spamming) {
		commandToClient(%this, 'PrivateMessage', LBChatColor("notification") @ "You have been muted for spamming. You will be unmuted in" SPC mRound((%this.spamLength / 1000) - (getRealTime() - %this.spamTime) / 1000) SPC "seconds.");
		%this.spamLength += 1000;
		cancel(%this.spamSch);
		%this.spamSch = %this.schedule(%this.spamLength - (getRealTime() - %this.spamTime), "unspam");
		return true;
	}
	%this.messages ++;
	%this.schedule(5000, "unmessage");
	if (%this.messages > 10 && !%this.isHost()) {
		%this.mute();
		return true;
	}
	return false;
}

function GameConnection::unmessage(%this) {
	%this.messages --;
}

function GameConnection::mute(%this) {
	%this.spamming = true;
	%this.spamTime = getRealTime();
	%this.spamLength = 25000;
	%this.spamSch = %this.schedule(%this.spamLength, "unspam");
	commandToClient(%this, 'PrivateMessage', LBChatColor("notification") @ "You have been muted for spamming. You will be unmuted in 25 seconds.");
}

function GameConnection::unspam(%this) {
	%this.spamming = false;
	commandToClient(%this, 'PrivateMessage', LBChatColor("notification") @ "You have been unmuted.");
}

function runServerChatCommand(%client, %message) {
	if (getSubStr(%message, 0, 1) !$= "/")
		return false;
	%cmd = getSubStr(firstWord(%message), 1, strlen(%message));
	if (isFunction(serverChatCommand @ %cmd)) {
		return call(serverChatCommand @ %cmd, %client, restWords(%message));
	}
	return false;
}

function serverChatCommandPing(%client, %rest) {
	%client.sendChat(LBChatColor("help") @ "Pong!");
	return true;
}
function serverChatCommandStatus(%client, %rest) {
	%client.sendChat(LBChatColor("help") @ "Server Status:");
	%client.sendChat(LBChatColor("help") @ "Uptime: " @ $Sim::Time @ " seconds");
	%client.sendChat(LBChatColor("help") @ "Missions Loaded: " @ $missionSequence);
	return true;
}
function serverChatCommandAdmin(%client, %rest) {
	if ($Server::Dedicated) {
		if (%client.isAdmin()) {
			%client.isAdmin = false;
			%client.isSuperAdmin = false;
			echo(%client.getDisplayName() @ " giving up admin");
			return true;
		}
		echo(%client.getDisplayName() @ " trying to admin with password " @ %rest);
		serverCmdSAD(%client, %rest);
		return true;
	}
	return false;
}
function serverChatCommandHost(%client, %rest) {
	if ($Server::Dedicated && %client.isAdmin()) {
		%name = trim(%rest);
		if (%name $= "") {
			%name = %client.namebase;
		}

		%host = GameConnection::resolveName(%name);
		if (isObject(%host)) {
			if (%host.isHost()) {
				%client.sendChat(LBChatColor("help") @ "Player " @ %host.getDisplayName() @ " is already Host.");
			} else {
				//De-host anyone else
				for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
					%other = ClientGroup.getObject(%i);
					if (%other.isHost()) {
						%other.setHost(false);
					}
				}
				%host.setHost(true);

				serverSendChat(LBChatColor("notification") @ "An Admin has changed Host to " @ %host.getDisplayName() @ ".");
			}
		} else {
			%client.sendChat(LBChatColor("help") @ "Cannot find player with name " @ %name @ ".");
		}

		return true;
	}
	return false;
}
function serverChatCommandUpload(%client, %rest) {
	if (%client.isAdmin()) {
		%status = !!%rest;
		if (%status !$= $MPPref::Server::SubmitScores) {
			$MPPref::Server::SubmitScores = %status;
			if (%status) {
				serverSendChat(LBChatColor("notification") @ "An Admin has enabled score submission.");
			} else {
				serverSendChat(LBChatColor("notification") @ "An Admin has disabled score submission.");
			}
		}
		return true;
	}
	return false;
}
function serverChatCommandKick(%client, %rest) {
	if (%client.isAdmin()) {
		%name = trim(%rest);
		%player = GameConnection::resolveName(%name);
		if (isObject(%player)) {
			// I am extremely prepared for Matan to do this to himself
			if (%player.getId() == %client.getId() && (!%client.warned || %client.getAddress() $= "local")) {
				%client.sendChat(LBChatColor("help") @ "You're about to kick yourself...");
				%client.warned = true;
			} else {
				serverSendChat(LBChatColor("notification") @ "An Admin has kicked " @ %player.getDisplayName() @ ".");
				kick(%player);
			}
		} else {
			%client.sendChat(LBChatColor("help") @ "Cannot find player with name " @ %name @ ".");
		}

		return true;
	}
	return false;
}
function serverChatCommandBan(%client, %rest) {
	if (%client.isAdmin()) {
		%name = trim(%rest);
		%player = GameConnection::resolveName(%name);
		if (isObject(%player)) {
			// I am extremely prepared for Matan to do this to himself
			if (%player.getId() == %client.getId() && (!%client.warned || %client.getAddress() $= "local")) {
				%client.sendChat(LBChatColor("help") @ "You're about to ban yourself...");
				%client.warned = true;
			} else {
				serverSendChat(LBChatColor("notification") @ "An Admin has banned " @ %player.getDisplayName() @ ".");
				ban(%player);
			}
		} else {
			%client.sendChat(LBChatColor("help") @ "Cannot find player with name " @ %name @ ".");
		}

		return true;
	}
	return false;
}
function serverChatCommandCancel(%client, %rest) {
	if (%client.isAdmin() || (%client.isHost() && $Server::Dedicated)) {
		%client.sendChat(LBChatColor("help") @ "Cancelling mission load/play...");
		echo("Force cancelled mission load/play.");
		$loadingMission = false;
		lobbyReturn();
		cancel($LoadStage2);
		return true;
	}
	return false;
}