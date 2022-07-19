//------------------------------------------------------------------------------
// Multiplayer Package
// clientItems.cs
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

function clientCmdUpdateItems() {
	updateClientItems();
	// Just run this a fuckton of times. It takes 1.001 ms to run on my
	// PoC laptop, you can stand to run it quite a bit.
	schedule(100, 0, updateClientItems);

	// Because we can never be sure of the timing
	schedule(ServerConnection.getPing(), 0, updateClientItems);
	schedule(ServerConnection.getPing() / 2, 0, updateClientItems);
	schedule(ServerConnection.getPing() * 1.1, 0, updateClientItems);
}

// hide these items depending on our preferences
function updateClientItems() {
	if ($Server::ServerType !$= "MultiPlayer")
		return;

	%count = ServerConnection.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);

		switch$ (%obj.getClassName()) {
		case "ParticleEmitterData":
			if (!%obj.periodModified || %obj.ejectionPeriodMS != %obj.newPeriod || %db.periodVarianceMS != %db.newVarianceMS) {
				if (%db.oldPeriod $= "")
					%db.oldPeriod = %db.ejectionPeriodMS;
				if (%db.oldVarianceMS $= "")
					%db.oldVarianceMS = %db.periodVarianceMS;

				if ($pref::Video::ParticlesPercent == 0) {
					%db.ejectionPeriodMS = 1000000;
					%db.periodVarianceMS = 500000;
				} else {
					%db.ejectionPeriodMS = max(mCeil(%db.oldPeriod * (1 / $pref::Video::ParticlesPercent)), 1);
					%db.periodVarianceMS = max(mCeil(%db.oldVarianceMS * (1 / $pref::Video::ParticlesPercent)), 1);
				}
				%db.newPeriod = %db.ejectionPeriodMS;
				%db.newVarianceMS = %db.periodVarianceMS;
				%db.periodModified = true;
			}
		case "Item":
			if (!$Server::Hosting || $Server::_Dedicated) {
				MissionGroup.add(%obj);
			}
		case "StaticShape":
			if (!$Server::Hosting || $Server::_Dedicated) {
				MissionGroup.add(%obj);
			}
		}
	}
}

//-----------------------------------------------------------------------------
// Item Collision and Other Goodies
//-----------------------------------------------------------------------------

// update collision with items
function updateItemCollision() {
	if (!isObject($MP::MyMarble) && MPGetMyMarble() == -1 || $Server::ServerType $= "SinglePlayer")
		return;

	%pos     = $MP::MyMarble.getWorldBoxCenter();
	%marbBox = $MP::MyMarble.getWorldBox();
//   if (!isObject(%mesh))
//      return;
//
//   if (isObject(%mesh)) {
//      %box = %mesh.getWorldBox();
//      %width  = getWord(%box, 3) - getWord(%box, 0);
//      %depth  = getWord(%box, 4) - getWord(%box, 1);
//      %height = getWord(%box, 5) - getWord(%box, 2);
//
//      %width  /= 2;
//      %depth  /= 2;
//      %height /= 2;
//
//      %marbBox = VectorSub(%pos, %width SPC %depth SPC %height) SPC VectorAdd(%pos, %width SPC %depth SPC %height);
//   }

	%count = ItemArray.getSize();
	%rebuild = ServerConnection.getCount() != $LastSCCount;
	for (%i = 0; %i < %count; %i ++) {
		%obj = ItemArray.getEntryByIndex(%i);
		%box = getField(%obj, 1);
		%obj = nameToID(getField(%obj, 0));
		if (%obj == -1)
			continue;

//      if (VectorDist(%pos, %obj.getPosition()) < 10)
		//echo(VectorDist(%pos, %obj.getPosition()) TAB %box TAB %marbBox TAB boxInterceptsBox(%box, %marbBox));
		if (VectorDist(%pos, %obj.getPosition()) < 10 && boxInterceptsBox(%box, %marbBox)) {
			if (ClientMode::callback("shouldIgnoreItem", false, new ScriptObject() {
				this = %obj;
				marble = $MP::MyMarble;
				_delete = true;
			})) {
				continue;
			}

			// only hide not permantent items
			if (%obj.getDatablock().density != 9001) {
//            echo("hiding object:" SPC %obj);

				// If the server is a different OS than us, we have to accept
				// this collision and call oncollision if the object isn't hidden
				commandToServer('ItemCollision', %obj.getPosition(), %obj);
			}
			%obj.onClientCollision($MP::MyMarble);

			%rebuild = true;
		}
	}

	// reset the list to make execution faster
	// hidden items do not stay within the serverConnection
	// object
	if (%rebuild)
		buildItemList();
}

function Item::onClientCollision(%this, %marble) {
	if (!ClientMode::callback("shouldPickupItem", isClientSidedItem(%this), new ScriptObject() {
			this = %this;
			marble = $MP::MyMarble;
			_delete = true;
		}))
		return;

	switch$ (%this.getDataBlock().getName()) {
	case "AntiGravityItem" or "NoRespawnAntiGravityItem" or "AntiGravityItem_PQ" or "NoRespawnAntiGravityItem_PQ" or "AntiGravityItem_MBU" or "NoRespawnAntiGravityItem_MBU":
		// It's a gravity modifier
		%rotation = getWords(%this.getTransform(),3);
		%ortho = VectorRemoveNotation(vectorOrthoBasis(%rotation));
		if (!VectorEqual(getWords($Game::LastGravityDir, 6, 8), getWords(%ortho, 6, 8))) {
			devecho("set grav");
			clientCmdSetGravityDir(%ortho, false, %rotation);
			alxPlay(PuAntiGravityVoiceSfx);
		}
	case "SuperJumpItem" or "SuperJumpItem_PQ" or "SuperJumpItem_MBU":
		$MP::MyMarble._setPowerUp(%this.getDatablock(), true, %this);
		alxPlay(PuSuperJumpVoiceSfx);
	case "SuperSpeedItem" or "SuperSpeedItem_PQ" or "SuperSpeedItem_MBU":
		$MP::MyMarble._setPowerUp(%this.getDatablock(), true, %this);
		alxPlay(PuSuperSpeedVoiceSfx);
	case "SuperBounceItem" or "SuperBounceItem_PQ":
		$MP::MyMarble._setPowerUp(%this.getDatablock(), true, %this);
		alxPlay(PuSuperBounceVoiceSfx);
	case "ShockAbsorberItem" or "ShockAbsorberItem_PQ":
		$MP::MyMarble._setPowerUp(%this.getDatablock(), true, %this);
		alxPlay(PuShockAbsorberVoiceSfx);
	case "HelicopterItem" or "HelicopterItem_PQ" or "HelicopterItem_MBU":
		$MP::MyMarble._setPowerUp(%this.getDatablock(), true, %this);
		alxPlay(PuGyrocopterVoiceSfx);
	case "MegaMarbleItem" or "MegaMarbleItem_MBU":
		$MP::MyMarble._setPowerUp(%this.getDatablock(), true, %this);
		alxPlay(PuMegaMarbleVoiceSfx);
	}
	if ($mvTriggerCount0) {
		$MP::MyMarble._onPowerUpUsed();
	}
	if (%this.getDatablock().density != 9001) { //Magic constant for NoRespawnGravityModifiers
		%this._respawn();
	}
}

function Item::_getPowerUpId(%this) {
	return %this.getDatablock()._getPowerUpId();
}

function ItemData::_getPowerUpId(%this) {
	switch$ (%this.getName()) {
	case "SuperJumpItem" or "SuperJumpItem_PQ" or "SuperJumpItem_MBU":
		return 1;
	case "SuperSpeedItem" or "SuperSpeedItem_PQ" or "SuperSpeedItem_MBU":
		return 2;
	case "SuperBounceItem" or "SuperBounceItem_PQ":
		return 3;
	case "ShockAbsorberItem" or "ShockAbsorberItem_PQ":
		return 4;
	case "HelicopterItem" or "HelicopterItem_PQ" or "HelicopterItem_MBU":
		return 5;
	case "MegaMarbleItem" or "MegaMarbleItem_MBU":
		return 6;
	case "AnvilItem" or "AnvilItem_BM":
		return 8;
	case "CustomSuperJumpItem_PQ":
		return 9;
	default:
		return 0;
	}
}

function isClientSidedItem(%item) {
	switch$ (%item.getDataBlock().getName()) {
	case
		"AntiGravityItem" or "AntiGravityItem_PQ" or "AntiGravityItem_MBU" or
		"NoRespawnAntiGravityItem" or "NoRespawnAntiGravityItem_PQ" or "NoRespawnAntiGravityItem_MBU" or
		"AnvilItem": return true;
	}
	return false;
}

// build the item list an in array object
function buildItemList() {
	while (isObject(ItemArray))
		ItemArray.delete();
	%array = Array(ItemArray);
	%count = ServerConnection.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = ServerConnection.getObject(%i);

		// use bitmasks for fast comparison, faster than using $=
		if (%obj.getType() & $TypeMasks::ItemObjectType) {

			// if we are hidden, then don't add it
			if (%obj.isHidden())
				continue;

			%array.addEntry(%obj.getID() TAB %obj.getWorldBox());
		}
	}
	$LastSCCount = ServerConnection.getCount();
}

if (!isObject(ClientRespawnSet)) {
	RootGroup.add(new SimSet(ClientRespawnSet));
}

function Item::_respawn(%this) {
	ClientRespawnSet.add(%this);

	devecho("Respawning (clientside)" SPC %this);
	%this.startFade(0, 0, true);
	%this.hide(true);
	%this.respawning = true;

	cancel(%this.respSch);

	// Shedule a reapearance
	%this.respSch = %this.schedule($Item::RespawnTime, "_respawnEnd");
}

function Item::_respawnEnd(%this) {
	ClientRespawnSet.remove(%this);
	cancel(%this.respSch);

	%this.respawning = false;
	%this.hide(false);
	%this.startFade(1000, 0, false);
}

function Item::_respawnCancel(%this) {
	ClientRespawnSet.remove(%this);
	cancel(%this.respSch);
	%this.respawning = false;
}
function clientCmdItemPickup(%id) {
	%item = getClientSyncObject(%id);

	if (!isObject(%item)) {
		devecho("Pickup invisible item");
		return;
	}
	if (!ClientMode::callback("shouldUseClientPowerups", false))
		return;

	if (%item._getPowerUpId() != 0) {
		%item._respawn();
		$MP::MyMarble._setPowerUp(%item.getDatablock(), true, %item);
	}
}

function clientCmdHuntGemSpawn(%count) {
	while (isObject(ClientSpawnedArray))
		ClientSpawnedArray.delete();
	Array(ClientSpawnedArray);
	$Client::WaitingSpawnCount = %count;
	deleteVariables("$Client::FoundSpawnSync*");
}

function gemSpawnSync(%obj) {
	if ($Client::FoundSpawnSync[%obj.getSyncId()]) {
		return;
	}
	$Client::FoundSpawnSync[%obj.getSyncId()] = true;
	$Client::WaitingSpawnCount --;
	ClientSpawnedArray.addEntry(%obj.getSyncId());

	//Don't tell the scripts we got a spawn until we have all the gems
	if ($Client::WaitingSpawnCount <= 0) {
		gemSpawnSyncComplete();
	}
}

function gemSpawnSyncComplete() {
	cancel($gsscTimer);
	for (%i = 0; %i < ClientSpawnedArray.getSize(); %i ++) {
		%syncId = ClientSpawnedArray.getEntry(%i);
		if (!isObject(getClientSyncObject(%syncId))) {
			$gsscTimer = schedule(100, 0, gemSpawnSyncComplete);
			return;
		}
	}
	clientCmdCbOnHuntGemSpawn();
}