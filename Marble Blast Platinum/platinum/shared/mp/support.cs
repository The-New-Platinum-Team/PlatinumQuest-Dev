//------------------------------------------------------------------------------
// Multiplayer Package
// support.cs
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

$PingMin = 50;

function commandToAll(%command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++)
		commandToClient(ClientGroup.getObject(%i), %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);
}

function commandToAllExcept(%exception, %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);

		if (%client == %exception)
			continue;

		commandToClient(%client, %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);
	}
}

function commandToTeam(%team, %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10) {
	if (!$MP::TeamMode)
		return commandToAll(%command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);

	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return commandToAll(%command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);

	%count = %team.getCount();
	for (%i = 0; %i < %count; %i ++)
		commandToClient(%team.getObject(%i), %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);
}

// commands to a client by ping
function commandToClientByPing(%client, %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10) {
	%ping = %client.getPing();

	// local host gets 0 for this but we want to help those a tiny bit
	// with latency issues.  ServerConnection is actually 15MS according to
	// the method, however for some odd reason client.getping on server is 0Ms
	if (%ping < $PingMin)
		%ping = $PingMin;

	schedule(%ping, 0, "commandToClient", %client, %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);
}

// command to all by ping, will not send the commandToClient until the ping time.
function commandToAllByPing(%command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10)  {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%ping = %client.getPing();

		// local host gets 0 for this but we want to help those a tiny bit
		// with latency issues.  ServerConnection is actually 15MS according to
		// the method, however for some odd reason client.getping on server is 0Ms
		if (%ping < $PingMin)
			%ping = $PingMin;

		schedule(%ping, 0, "commandToClient", %client, %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);
	}
}

// command to all by ping, will not send the commandToClient until the ping time.
// Exception: do not send to the exception.
function commandToAllExceptByPing(%exception, %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10)  {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);

		// if we are the exception, do not send it!
		if (%client == %exception)
			continue;

		%ping = %client.getPing();

		// local host gets 0 for this but we want to help those a tiny bit
		// with latency issues.  ServerConnection is actually 15MS according to
		// the method, however for some odd reason client.getping on server is 0Ms
		if (%ping < $PingMin)
			%ping = $PingMin;

		schedule(%ping, 0, "commandToClient", %client, %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);
	}
}

function commandToJeff(%command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);

		if (%client.getUsername() !$= "Jeff")
			continue;
		commandToClient(%client, %command, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);
	}
}

//-----------------------------------------------------------------------------

// Server end
function commandToClientLong(%client, %cmd, %arg, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6) {
	%parts = mCeil(strlen(%arg) / 255);
	if (%parts == 1) {
		// Short circut if we only have 1 command. No need to waste
		// banwidth.
		commandToClient(%client, %cmd, %arg, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6);
		return;
	}

	commandToClient(%client, 'LongCommandBegin');
	for (%i = 0; %i < %parts; %i++) {
		%part = getSubStr(%arg, %i * 255, 255);
		commandToClient(%client, 'LongCommandUpdate', %part);
	}
	commandToClient(%client, 'LongCommandEnd', %cmd, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6);
}

function commandToAllLong(%cmd, %arg, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		commandToClientLong(%client, %cmd, %arg, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6);
	}
}

// ~~~~~~~~~~~
// Client end
// ~~~~~~~~~~~

function clientCmdLongCommandBegin() {
	$Client::LongCommandMessage = "";
}

function clientCmdLongCommandUpdate(%msg) {
	$Client::LongCommandMessage = $Client::LongCommandMessage @ %msg;
}

function clientCmdLongCommandEnd(%function, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6) {
	// detag as it's sent as a network cached string
	call("clientCmd" @ detag(%function), $Client::LongCommandMessage, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6);
	$Client::LongCommandMessage = "";
}

//-----------------------------------------------------------------------------

function alpha(%string) {
	return stripNot(%string, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
}

function alphaNum(%string) {
	return stripNot(%string, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890");
}

function rot13(%string) {
	%finishedString = "";
	%notRotLower = "abcdefghijklmnopqrstuvwxyz";
	%rotLower = "nopqrstuvwxyzabcdefghijklm";
	%notRotUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	%rotUpper = "NOPQRSTUVWXYZABCDEFGHIJKLM";
	for (%i = 0; %i < strlen(%string); %i ++) {
		%letter = getSubStr(%string, %i, 1);
		if (strPos(%notRotLower, %letter) == -1) {
			if (strPos(%notRotUpper, %letter) == -1) {
				%finishedString = %finishedString @ %letter;
				continue;
			}
			%pos = strPos(%notRotUpper, %letter);
			%letter = getSubStr(%rotUpper, %pos, 1);
			%finishedString = %finishedString @ %letter;
			continue;
		}
		%pos = strPos(%notRotLower, %letter);
		%letter = getSubStr(%rotLower, %pos, 1);
		%finishedString = %finishedString @ %letter;
	}
	return %finishedString;
}

// get the average ping of the clients
function getAveragePing() {
	%ping = 0;
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++)
		%ping += ClientGroup.getObject(%i).getPing();
	%ping = mFloor(%ping / %count);
	return %ping;
}

function Vector2d(%vec) {
	return getWord(%vec, 0) SPC getWord(%vec, 1);
}

function VectorMult(%vec1, %vec2) {
	%finished = "";
	//Iterate through all the dimensions of the two vectors
	//The count is of length of whichever vector is longer
	for (%i = 0; %i < max(getWordCount(%vec1), getWordCount(%vec2)); %i ++) {
		if (%i) {
			//Append dimension
			%finished = %finished SPC getWord(%vec1, %i) * getWord(%vec2, %i);
		} else {
			//Set %finished to dimension
			%finished = getWord(%vec1, %i) * getWord(%vec2, %i);
		}
	}
	return %finished;
}

// returns the absolute value of a vector
function vectorAbs(%vec) {
	return strreplace(%vec, "-", "");
}

// returns the angleaxis rotation from the specified yaw and pitch
function rotateYawPitch(%position, %yaw, %pitch) {
	%yaw   = "0 0 0 0 0 1" SPC %yaw;
	%pitch = "0 0 0 1 0 0" SPC %pitch;

	%rotation = MatrixMultiply(%yaw, %pitch);
	%rotation = MatrixMultiply(%position SPC "0 0 0 0", %rotation);
	%rotation = getWords(%rotation, 3, 6);
	return %rotation;
}

function compareOS(%os) {
	return true;

	if (%os $= $platform)
		return true;
	if ((%os $= "x86UNIX" || %os $= "macos") && ($platform $= "x86UNIX" || $platform $= "macos"))
		return true;
	return false;
}

function VectorRound(%vec, %places) {
	for (%i = 0; %i < getWordCount(%vec); %i ++) {
		%word = getWord(%vec, %i);
		%word = mRound(%word, %places);
		%vec = setWord(%vec, %i, %word);
	}
	return %vec;
}

function getGemAtPosition(%position, %datablock, %grp) {
	%set = findObjectsAtPosition(%position, %grp);
	%set.onNextFrame("delete"); //Memory mgmt

	//We might have more than one gem
	for (%i = 0; %i < %set.getSize(); %i ++) {
		%obj = %set.getEntry(%i);
		//If it's correct
		if (%obj.getClassName() $= "Item" && %obj.getDataBlock().className $= "Gem" && %obj.position $= %position && %obj.getDataBlock().getName() $= %datablock)
			return %obj;
	}
	return -1;
}

function findObjectsAtPosition(%position, %grp, %array) {
	if (%array $= "")
		%array = Array(FindAtPositionArray);

	if (%grp $= "")
		%grp = MissionGroup;

	for (%i = 0; %i < %grp.getCount(); %i ++) {
		%obj = %grp.getObject(%i);
		if (%obj.getClassName() $= "SimGroup") //Append to %array
			findObjectsAtPosition(%position, %obj, %array);
		//Ignore these
		if (!(%obj.getType() & ($TypeMasks::GameBaseObjectType | $TypeMasks::InteriorObjectType)))
			continue;
		if (%obj.getPosition() $= %position)
			%array.addEntry(%obj);
	}

	return %array;
}

function findObjectsNearPosition(%position, %distance, %grp, %array) {
	if (%array $= "")
		%array = Array(FindNearPositionArray);

	if (%grp $= "")
		%grp = MissionGroup;

	for (%i = 0; %i < %grp.getCount(); %i ++) {
		%obj = %grp.getObject(%i);
		if (%obj.getClassName() $= "SimGroup") //Append to %array
			findObjectsNearPosition(%position, %distance, %obj, %array);
		//Ignore these
		if (!(%obj.getType() & ($TypeMasks::GameBaseObjectType | $TypeMasks::InteriorObjectType)))
			continue;
		if (VectorDist(%obj.getPosition(), %position) < %distance)
			%array.addEntry(%obj);
	}
	return %array;
}

function getCurrentSky() {
	%count = ServerConnection.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);

		if (%obj.getClassName() $= "Sky")
			return %obj;
	}
}

function getTeamColor(%color) {
	if (%color $= "")
		return "000000";
	switch (%color) {
	case -1:
		return "000000";
	case  0:
		return "ff0000";
	case  1:
		return "ffff00";
	case  2:
		return "00ff00";
	case  3:
		return "00ffff";
	case  4:
		return "0000ff";
	case  5:
		return "ff00ff";
	case  6:
		return "ff8000";
	case  7:
		return "8000ff";
	default:
		return "000000";
	}
}