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

//------------------------------------------------------------------------------
// Loading info is text displayed on the client side while the mission
// is being loaded.  This information is extracted from the mission file
// and sent to each the client as it joins.
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// sendLoadInfoToClient
//
// Sends mission description to the client
//------------------------------------------------------------------------------
function sendLoadInfoToClient(%client) {
	echo("You just lost the game");

	if (isScriptFile($Server::MissionFile)) {
		%info = getMissionInfo($Server::MissionFile);
	} else {
		// We don't have this mission... yet we're here?
		// It could be a marbleland mission we haven't downloaded yet.
		%marblelandId = marblelandGetFileId($Server::MissionFile);
		if (%marblelandId !$= "") {
			// Yep, stupid
			%info = marblelandGetMission(%marblelandId);
		}
	}

	messageClient(%client, 'MsgLoadInfo', "", %info.name);
	messageClient(%client, 'MsgLoadMode', "", %info.gameMode);
	messageClient(%client, 'MsgLoadDescripition', "", %info.desc);
	messageClient(%client, 'MsgServerDedicated', "", $Server::Dedicated);
	messageClient(%client, 'MsgServerDescription', "", $Pref::Server::Info);
	messageClient(%client, 'MsgServerName', "", $Pref::Server::Name);
	// Transmit MissionInfo securely
	%fields = %info.getDynamicFieldList();
	for (%i = 0; %i < getFieldCount(%fields); %i ++) {
		%key = getField(%fields, %i);
		%value = %info.getFieldValue(%key);
		%maxChars = 255;
		for (%j = 0; %j < mCeil(strLen(%value) / %maxChars); %j ++) {
			messageClient(%client, 'MsgLoadMissionInfoPart', "", %key, getSubStr(%value, %maxChars * %j, %maxChars));
		}
	}
	messageClient(%client, 'MsgLoadInfoDone');
}
