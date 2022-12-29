//-----------------------------------------------------------------------------
// partyspawns Mode
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

function Mode_partyspawns::onLoad(%this) {
	echo("[Mode" SPC %this.name @ "]: Loaded!");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("shouldSendScores");
	%this.registerCallback("modifyScoreData");
}

function Mode_partyspawns::onFoundGem(%this, %object) {
	%trigger = %object.gem;
	switch (%object.gem._huntDatablock.huntExtraValue + 1) {
		case 1:
			if (%object.client.player.heldPowerup == 0) {
				switch$ (MissionInfo.modification) {
					case "PlatinumQuest":
						%object.client.player.setPowerup(SuperSpeedItem_PQ, false);
					case "Ultra":
						%object.client.player.setPowerup(SuperSpeedItem_MBU, false);
					default:
						%object.client.player.setPowerup(SuperSpeedItem, false);
				}
				commandToClient(%object.client, 'AddHelpLine', "You got a red gem, get a Super Speed!");
			}
		case 2:
		case 3:
			//commandToClient(%object.client, 'FireballInit', 20000);
			GameConnection::fireballInit(%object.client, 5000);
			FireballItem.onUse(%trigger, %object.client.player);
			alxPlay(PuFireballVoiceSfx);
		case 4:
			//commandToClient(%object.client, 'doPowerUp', 3);
			//SuperBounceItem.onUse(%trigger, %object.client);
			%duration = 5000;
			%x = new ScriptObject(LowTimeout) {
				timeout = %duration;
			};
			//if (getEventTimeLeft(%object.client.megaSchedule) < %duration) {
				// getEventTimeLeft must've been removed, sigh
			//if (!isEventPending(%object.client.megaSchedule)) {
			MegaMarbleItem.onUse(%x, %object.client.player);
			//}
		case 5:
		case 6:
			commandToClient(%object.client, 'doPowerUp', 2);
			SuperSpeedItem.onUse(%trigger, %object.client.player);
			commandToClient(%object.client, 'doPowerUp', 4);
			ShockAbsorberItem.onUse(%trigger, %object.client.player);
		case 7:
			commandToClient(%object.client, 'AddHelpLine', "You picked up a Triple Blast!");
			%object.client.usingPartyTripleBlast = true;
			%object.client.setBlastValue(1);
			$MP::PartyTripleBlast = true;
			//alxPlay(PuBlastVoiceSfx);
			//schedule(100, 0, alxPlay, PuBlastVoiceSfx);
			//schedule(200, 0, alxPlay, PuBlastVoiceSfx); // This will play "Ultra Ultra Ultra Blast" in MBU soundpack but I don't care
		case 10:
			//commandToClient(%object.client, 'doPowerUp', 5);
			//HelicopterItem.onUse(%trigger, %object.client);
			//commandToClient(%object.client, 'doPowerUp', 8);
			//AnvilItem.onUse(%trigger, %object.client);
			//commandToClient(%object.client, 'doPowerUp', 4);
			//ShockAbsorberItem.onUse(%trigger, %object.client);
		case 0:
			commandToAll('AddHelpLine', "White gem collected, everyone is now flying!");
			for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
				commandToClient(ClientGroup.getObject(%i), 'doPowerUp', 5);
				HelicopterItem.onUse(%trigger, ClientGroup.getObject(%i).player);
			}
		case -1:
			commandToAll('AddHelpLine', "Black gem collected, everyone else is now small!");
			for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
				if (%object.client != ClientGroup.getObject(%i)) {
					ClientGroup.getObject(%i).player.setCollisionRadius(0.1);
				}
			}
			alxPlay(BubblePopSfx);
	}
}

function Mode_partyspawns::shouldSendScores(%this) {
	if ($MPPref::Server::PartySpawns && !$MPPref::Server::HuntHardMode)
		return true;
	else
		return false;
}

function Mode_partyspawns::modifyScoreData(%this, %object) {
	if (!$MPPref::Server::HuntHardMode)
		return %object.data @ "&extraModes[]=partyspawns";
}