//-----------------------------------------------------------------------------
// Hunt - Hard Mode Mode
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

function Mode_hunthardmode::onLoad(%this) {
	echo("[Mode" SPC %this.name @ "]: Loaded!");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("shouldRestorePowerup");
	%this.registerCallback("shouldSendScores");
	%this.registerCallback("modifyScoreData");
}

function Mode_hunthardmode::onFoundGem(%this, %object) {
	if (%object.gem._huntDatablock.huntExtraValue + 1 == -1) {

		%puphh = getRandom(0, 3);

		switch (%puphh) {
			case 0:
			    %object.client.player.setPowerup(SuperJumpItem, false);
			    commandToClient(%object.client, 'AddHelpLine', "You picked up a Super Jump PowerUp!");
			    alxPlay(PuSuperJumpVoiceSfx);
			case 1:
				%object.client.player.setPowerup(SuperSpeedItem, false);
			    commandToClient(%object.client, 'AddHelpLine', "You picked up a Super Speed PowerUp!");
			    alxPlay(PuSuperSpeedVoiceSfx);
			case 2:
				%object.client.player.setPowerup(HelicopterItem, false);
			    commandToClient(%object.client, 'AddHelpLine', "You picked up a Helicopter PowerUp!");
			    alxPlay(PuGyrocopterVoiceSfx);
			case 3:
			    %object.client.player.setPowerup(MegaMarbleItem, false);
			    commandToClient(%object.client, 'AddHelpLine', "You picked up a Mega Marble PowerUp!");
			    alxPlay(PuMegaMarbleVoiceSfx);
		}
	}

	%object.client.setBlastValue(0);
}

function Mode_hunthardmode::shouldRestorePowerup(%this, %object) {
	return false; //No restoring your powerup fuck you
}

function Mode_hunthardmode::shouldSendScores(%this) {
	if ($MPPref::Server::HuntHardMode && !$MPPref::Server::PartySpawns)
		return true;
	else
		return false;
}

function Mode_hunthardmode::modifyScoreData(%this, %object) {
	if (!$MPPref::Server::PartySpawns)
		return %object.data @ "&extraModes[]=hunthardmode";
}