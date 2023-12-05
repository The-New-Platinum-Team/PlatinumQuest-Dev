//------------------------------------------------------------------------------
// Multiplayer Package
// serverGhost.cs
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

function GameConnection::updateGhostDatablock(%this) {
	if (!isObject(%this.player))
		return;
	%marble = %this.getMarbleChoice();
	%db = getField(%marble, 0);
	%skin = getField(%marble, 1);
	%normalize = getField(%marble, 2);

	%this.player.setDataBlock(%db);
	%this.player.setSkinName(%skin);

	if (isObject(%this.hat)) {
		%this.hat.setDataBlock(%this.isMegaMarble() ? %this.hat.megadata : %this.hat.data);
	}

	if (%normalize) {
		if (%this.isMegaMarble()) {
			%this.player.setCollisionRadius(Mode::callback("getMegaMarbleSize", %db.megaScale, new ScriptObject() {
				client = %this;
				skinChoice = %skinChoice;
				_delete = true;
			})); //Mega marble size
		} else if (Mode::callback("shouldUseUltraMarble", false, new ScriptObject() {
			client = %this;
			skinChoice = %skinChoice;
			_delete = true;
		})) {
			%this.player.setCollisionRadius(Mode::callback("getUltraMarbleSize", %db.ultraScale, new ScriptObject() {
				client = %this;
				skinChoice = %skinChoice;
				_delete = true;
			})); //Ultra marble size
		} else {
			%this.player.setCollisionRadius(Mode::callback("getMarbleSize", %db.scale, new ScriptObject() {
				client = %this;
				skinChoice = %skinChoice;
				_delete = true;
			})); //Normal marble size
		}
	} else {
		%player.setCollisionRadius(%db.getCollisionRadius());
	}

	Mode::callback("onUpdateGhost", "", new ScriptObject() {
		client = %this;
		_delete = true;
	});
}

function GameConnection::isMegaMarble(%this) {
	return (isObject(%this.player) && %this.player.megaMarble) || MissionInfo.mega;
}

function GameConnection::setMegaMarble(%this, %mega) {
	%this.player.megaMarble = %mega;

	if (isEventPending(%this.player.megaSchedule)) {
		MegaMarbleItem.onUnuse(-1, %this.player);
		return;
	}

	%mega = %this.isMegaMarble();
	commandToClient(%this, 'MegaMarble', %mega);
	%this.updateGhostDatablock();
}

function serverCmdMegaMarble(%client, %mega) {
	if ($MPPref::FastPowerups) {
		// Oh well, just listen to them
		%client.player.megaMarble = %mega;
		%client.updateGhostDatablock();
	}
}


function GameConnection::createGhostHat(%this, %data, %megadata) {
	%hat = new StaticShape() {
		datablock = %data;
		position = %this.player.getPosition();

		data = %data;
		megadata = %megadata;
	};
	MissionCleanup.add(%hat);
	%this.hat = %hat;
	%this.hat.setSync("MPFindHat", %this.player.getSyncId());

	return %hat;
}
