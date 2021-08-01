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
}

function Mode_partyspawns::onFoundGem(%this, %object) {
	%trigger = %object.gem;
	switch (%object.gem._huntDatablock.huntExtraValue + 1) {
		case 1:
		case 2:
		case 3:
			//commandToClient(%object.client, 'FireballInit', 20000);
			GameConnection::fireballInit(%object.client, 20000);
			FireballItem.onUse(%trigger, %object);
			commandToClient(%object.client);
		case 4:
			//commandToClient(%object.client, 'doPowerUp', 3);
			//SuperBounceItem.onUse(%trigger, MPGetMyMarble());
			%duration = 5000;
			%x = new ScriptObject(LowTimeout) {
				timeout = %duration;
			};
			//if (getEventTimeLeft(MPGetMyMarble().megaSchedule) < %duration) {
				// getEventTimeLeft must've been removed, sigh
			//if (!isEventPending(MPGetMyMarble().megaSchedule)) {
			MegaMarbleItem.onUse(%x, MPGetMyMarble());
			//}
		case 5:
		case 6:
			commandToClient(%object.client, 'doPowerUp', 2);
			SuperSpeedItem.onUse(%trigger, MPGetMyMarble());
			commandToClient(%object.client, 'doPowerUp', 4);
			ShockAbsorberItem.onUse(%trigger, MPGetMyMarble());
		case 7:
			//commandToClient(%object.client, 'doPowerUp', 1);
			//SuperJumpItem.onUse(%trigger, MPGetMyMarble());
			commandToClient(%object.client, 'doPowerUp', 2);
			SuperSpeedItem.onUse(%trigger, MPGetMyMarble());
			commandToClient(%object.client, 'doPowerUp', 2);
			SuperSpeedItem.onUse(%trigger, MPGetMyMarble());
		case 10:
			//commandToClient(%object.client, 'doPowerUp', 5);
			//HelicopterItem.onUse(%trigger, MPGetMyMarble());
			//commandToClient(%object.client, 'doPowerUp', 8);
			//AnvilItem.onUse(%trigger, MPGetMyMarble());
			//commandToClient(%object.client, 'doPowerUp', 4);
			//ShockAbsorberItem.onUse(%trigger, MPGetMyMarble());
		case -1:
			// Black gem: Mega/Fireball/SB
			MegaMarbleItem.onUse(%x, MPGetMyMarble());
			GameConnection::fireballInit(%object.client, 10000);
			FireballItem.onUse(%trigger, %object);
			commandToClient(%object.client, 'doPowerUp', 3);
			SuperBounceItem.onUse(%trigger, MPGetMyMarble());
	}
}