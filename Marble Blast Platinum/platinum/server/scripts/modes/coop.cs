//-----------------------------------------------------------------------------
// Coop mode
//
// Copyright (c) 2021 The Platinum Team
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

function Mode_coop::onLoad(%this) {
	%this.registerCallback("shouldPickupPowerUp");
	%this.registerCallback("shouldDisablePowerup");
	%this.registerCallback("shouldUseClientPowerups");
	%this.registerCallback("shouldTotalGemCount");
	%this.registerCallback("getGemCount");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("getQuickRespawnTimeout");
	%this.registerCallback("getMaxSpectators");
	%this.registerCallback("shouldDisableBlastShockwave");
	%this.registerCallback("getPregameUserRow");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_coop::shouldDisablePowerup(%this, %object) {
	//Stuff that is handled by the client
	return %object.this.coopClient;
}
function Mode_coop::shouldPickupPowerup(%this, %object) {
	//Stuff that is handled by the client
	return !%object.this.coopClient;
}
function Mode_coop::shouldUseClientPowerups(%this) {
	return true;
}
function Mode_coop::shouldTotalGemCount(%this) {
	return true;
}
function Mode_coop::getGemCount(%this, %object) {
	//Get the total gemcount and tell everyone
	%gemCount = 0;
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++)
		%gemCount += ClientGroup.getObject(%i).gemCount;

	return %gemCount;
}
function Mode_coop::shouldResetTime(%this, %object) {
	return %this.shouldRestartOnOOB(%object);
}
function Mode_coop::shouldRestartOnOOB(%this, %object) {
	//Check if all clients are oob
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.spectating)
			continue;

		//Don't check if the respawner went OOB, we know they did
		if (%client.getId() == %object.client.getId())
			continue;

		//Don't restart everyone if someone isn't oob
		if (!%client.isOOB || %client.checkpointed)
			return false;
	}
	//Everyone went oob, so let other modes take care of this
	return "";
}
function Mode_coop::getQuickRespawnTimeout(%this, %object) {
	//Allow them to respawn instantly
	return 0;
}
function Mode_coop::getMaxSpectators(%this) {
	//Need at least two players
	return getRealPlayerCount() - 2;
}
function Mode_coop::shouldDisableBlastShockwave(%this) {
	return true;
}
function Mode_coop::getPregameUserRow(%this, %object) {
	%name = %object.client.getDisplayName();

	%px = 300;
	if ($MP::TeamMode)
		%px = 150;

	// add on stuff to the list
	if (%object.client.isHost()) {
		%name = clipPx($DefaultFont, 18, %name, %px - 50, true);
		%name = %name SPC "[Host]";
	} else if (%object.client.isAdmin()) {
		%name = clipPx($DefaultFont, 18, %name, %px - 50, true);
		%name = %name SPC "[Admin]";
	} else {
		%name = clipPx($DefaultFont, 18, %name, %px, true);
	}

	if (%object.client.ready) {
		%status = "[Ready]";
	} else if (%object.client.loading) {
		%status = "[Loading...]";
	} else {
		%status = "[Waiting]";
	}

	if ($MP::TeamMode) {
		%teamname = clipPx($DefaultFont, 18, Team::getTeamName(%object.client.team), 135, true);
		%color = Team::getTeamColor(%object.client.team);
		switch (%color) {
		case -1:
			%color = "\c1";
		case  0:
			%color = "\c2";
		case  1:
			%color = "\c3";
		case  2:
			%color = "\c4";
		case  3:
			%color = "\c5";
		case  4:
			%color = "\c6";
		case  5:
			%color = "\c7";
		case  6:
			%color = "\c8";
		case  7:
			%color = "\c9";
		}
		%teamname = "\cp" @ %color @ %teamname @ "\co";
	}
	return %name TAB %teamName TAB formatTime(%object.client.bestScore[filebase($MP::MissionObj.file)]) TAB %status;
}
