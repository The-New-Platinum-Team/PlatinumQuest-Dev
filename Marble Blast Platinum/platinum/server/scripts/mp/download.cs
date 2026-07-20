//-----------------------------------------------------------------------------
// Multiplayer Package
// serverDownload.cs
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

/**
 * @param {GameConnection} %client
 */
function serverCmdRequestMissionFile(%client, %file) {
//   echo("Client" SPC %client.getUsername() SPC "is requesting a file transfer.");
//   echo("   File:" SPC %file);

	if (%client.canDownload[%file] || $Server::Dedicated) {
		%client.sendFile(%file);
		%script = filePath(%file) @ "/" @ fileBase(%file) @ ".cs";
		if (isFile(%script)) {
			%client.sendFile(%script);
		}
	} else
		commandToClient(%client, 'FileDownloadError', %file);
}

// send a mission file to the client
/**
 * @param {GameConnection} %this
 */
function GameConnection::sendFile(%this, %file) {
	// encode mission to make it smaller
	%stream = encodeMission(%file);

	// UH-OH, WE GOT A PROBLEM
	if (%stream $= "") {
		error("Could not send mission file" SPC %file SPC "to Client" SPC %client.getUsername());
		error("   Reason: unable to open the file.  It is either missing or damaged.");

		// inform the client as well so they know what the heck happened.
		commandToClient(%this, 'FileDownloadError', %file);
		return;
	}

	// TorqueScript packets for remote commands can only have a string
	// length of up to 255 characters
	%count = mCeil(strLen(%stream) / 255);

	%seq = $MP::DownloadSequence ++;

	// inform the client that they are going to be receiving a file
	// send the file's path and name so it knows where to go and the total
	// amounts of packets that it is going to receive.
	commandToClient(%this, 'FileDownloadStart', %seq, %file, %count);

	// send the contents of the file
	for (%i = 0; %i < %count; %i ++) {
		// send the content with %send
		// %i + 1 is the amount being sent / total
		// (percent of download completion)
		%send = getSubStr(%stream, %i * 255, 255);
		commandToClient(%this, 'FileDownloadChunk', %seq, %send, %i + 1);
	}

	// inform the client that it sent
	commandToClient(%this, 'FileDownloadEnd', %seq);
}

function checkMissionLoad(%file) {
	$Game::RequireDifs[%file] = 0;
	%conts = fread(%file);
	if (%conts $= "")
		return false;

	for (%i = 0; %i < getRecordCount(%conts); %i ++) {
		%line = getRecord(%conts, %i);
		if (strPos(trim(%line), "interiorFile") == 0) {
			//Interior
			%dif = "%" @ trim(getSubStr(%line, 0, strPos(%line, ";"))) @ ";";
			eval(%dif);
			%interiorFile = expandFilename(%interiorFile);
			if (!isFile(%interiorFile))
				return false;

			commandToAll('RequireDif', %file, %interiorFile);
			$Game::RequireDif[%file, $Game::RequireDifs[%file]] = %interiorFile;
			$Game::RequireDifs[%file] ++;
		}
	}
}

/**
 * @param {Type} %client
 */
function serverCmdDifExists(%client, %file, %dif, %has) {
	%client.hasDif[%file, %dif] = %has;
}

/**
 * @param {GameConnection} %this
 */
function GameConnection::canLoadMission(%this, %file) {
	for (%i = 0; %i < $Game::RequireDifs[%file]; %i ++) {
		if (!%this.hasDif[%file, $Game::RequireDif[%file, %i]]) {
			echo("Client" SPC %this SPC "missing interior" SPC $Game::RequireDif[%file, %i] SPC "for file" SPC %file);
			return false;
		}
	}
	return true;
}
