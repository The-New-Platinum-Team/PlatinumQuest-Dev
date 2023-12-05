//-----------------------------------------------------------------------------
// Client-sided marbles
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

function Marble::_setPowerUp(%this, %data, %reset, %obj, %fields) {
	if (isObject(%data)) {
		%id = %data._getPowerUpId();

		%this._powerUpData = %data;
		%this._powerUpId = %id;
		%this._setPowerUpObj(%obj, %fields);
		if (!$mvTriggerCount0)
			PlayGui.setPowerUp(%data.shapeFile);

		if (%id > 5) {
			%this.setPowerUpId(0, true);
		} else {
			%this.setPowerUpId(%id, %reset);
		}
	} else {
		%this.setPowerUpId(0, %reset);
		cancel(%this.mountSch);
		%this.unmountImage(0);

		%this._powerUpData = "";
		%this._powerUpId = "";
		%this._setPowerUpObj(0);
	}

	devecho(%this SPC "setting powerupid to" SPC %data SPC "/" SPC %id SPC "reset:" SPC %reset SPC "fields:" SPC %fields);
}

function Marble::_setPowerUpObj(%this, %obj, %fields) {
	%oldFields = %this.getDynamicFieldList();
	for (%i = 0; %i < getFieldCount(%oldFields); %i ++) {
		%field = getField(%oldFields, %i);
		if (strpos(%field, "_powerUpFields") == 0) {
			%this.setFieldValue(%field, "");
			devecho(%field SPC "reset");
		}
	}

	//Fields from the call
	for (%i = 0; %i < getRecordCount(%fields); %i ++) {
		%record = getRecord(%fields, %i);
		%field = getField(%record, 0);
		%value = getField(%record, 1);
		%this._powerUpFields[%field] = %value;
		devecho("From server: " @ %field SPC %value);
	}

	if (isObject(%obj)) {
		%fields = %obj.getDynamicFieldList();
		for (%i = 0; %i < getFieldCount(%fields); %i ++) {
			%field = getField(%fields, %i);
			%this._powerUpFields[%field] = %obj.getFieldValue(%field);
			devecho("From client: " @ %field SPC %obj.getFieldValue(%field));
		}
	}
}

function Marble::_onPowerUpUsed(%this, %id) {
	if (%id $= "") {
		%id = %this._powerUpId;
		commandToServer('OnPowerUpUsed', %id);
	}
	devecho("Sending server a client powerup usage; Id: " @ %id);

	devecho(%this SPC "using powerup" SPC %id);
	$Client::UsedPowerup[%id] = true;

	if (%id) {
		// When you use a powerup, we want to know
		switch (%id) {
		case 1:
			alxPlay(doSuperJumpSfx);
		case 2:
			alxPlay(doSuperSpeedSfx);
		case 3:
			%this.mountImage(SuperBounceImage, 0);
			%this.mountSch = %this.schedule(5000, "unmountImage", 0);
		case 4:
			%this.mountImage(ShockAbsorberImage, 0);
			%this.mountSch = %this.schedule(5000, "unmountImage", 0);
		case 5:
			%this.mountImage((%this.megaMarble ? MegaHelicopterImage : ActualHelicopterImage), 0);
			%this.mountSch = %this.schedule(5000, "unmountImage", 0);
		case 6: //Mega
			if (!%this.megaMarble) {
				$MegaOldRadius = %this.getCollisionRadius();
				%this.setCollisionRadius(0.6666);
			}

			cancel(%this.unMega);
			%this.unMega = %this.schedule(10000, "_unMega");

			%this.megaMarble = true;
			$Client::MegaMarble = true;
			Physics::reloadLayers();

			%this.setPowerUpId(0, true);
		case 8: // anvil
			if ($Game::GravityUV !$= "0 0 -1")
				$MP::MyMarble.applyImpulse("0 0 0", rottoVector($Game::GravityRot, "0 0 20"));
			else
				$MP::MyMarble.applyImpulse("0 0 0", "0 0 -20");
		case 9: // custom superjump item
			$MP::MyMarble.doPowerup(1); // does regular superjump

			// cancel some force from regular superjump
			// this makes it effectivly weak
			echo("Custom SJ with power " @ %this._powerUpFields["power"]);
			$MP::MyMarble.applyImpulse("0 0 0", vectorScale(rottoVector($Game::GravityRot, "0 0 1"), (20 - %this._powerUpFields["power"])));
		}

		%this._powerUpId = 0;
		%this._powerUpData = 0;
		%this._setPowerUpObj(0);
	}

	PlayGui.setPowerUp("");
}

function Marble::_mouseFire(%this) {
	if (%this._powerUpId) {
		%this._onPowerUpUsed();
	}
	%this._powerUpId = 0;
}

function Marble::_respawnPowerup(%this) {
	%this._setPowerUp(0, true, 0);
	%this._checkpointPowerup = 0;
	%this._checkpointPowerupObj = 0;

	while (ClientRespawnSet.getCount()) {
		ClientRespawnSet.getObject(0)._respawnEnd(); //Removes the item from the set too
	}
}

function Marble::_respawnPowerupOnCheckpoint(%this) {
	devecho("Checkpoint respawn client powerup");
	RootGroup.add(%fakePU = new ScriptObject(FakePup));
	%fields = %this.getDynamicFieldList();
	for (%i = 0; %i < getFieldCount(%fields); %i ++) {
		%cpField = getField(%fields, %i);
		if (strpos(%cpField, "_checkpointPowerUpFields") == 0) {
			%field = getSubStr(%cpField, 24, strlen(%cpField));
			devecho(%field SPC %cpField SPC %this.getFieldValue(%cpField));
			%fakePU.setFieldValue(%field, %this.getFieldValue(%cpField));
		}
	}

	if (%this._powerUpId || %this._checkpointPowerup) {
		%this._setPowerUp(0, true, 0);
		%this.schedule(500, _setPowerUp, %this._checkpointPowerup, true, %fakePU);
		%fakePU.schedule(1000, delete);
	}
}

function Marble::_onActivateCheckpoint(%this) {
	%this._checkpointPowerup = %this._powerUpData;
	%this._checkpointPowerupObj = %this._powerUpDataObj;

	%fields = %this.getDynamicFieldList();
	for (%i = 0; %i < getFieldCount(%fields); %i ++) {
		%field = getField(%fields, %i);
		if (strpos(%field, "_checkpointPowerUpFields") == 0) {
			%this.setFieldValue(%field, "");
			devecho(%field SPC %cpField SPC "reset");
		}
	}
	for (%i = 0; %i < getFieldCount(%fields); %i ++) {
		%field = getField(%fields, %i);
		if (strpos(%field, "_powerUpFields") == 0) {
			%cpField = "_checkpointPowerUpFields" @ getSubStr(%field, 14, strlen(%field));
			devecho(%field SPC %cpField SPC %this.getFieldValue(%field));
			%this.setFieldValue(%cpfield, %this.getFieldValue(%field));
		}
	}
}

function Marble::_unMega(%this) {
	commandToServer('MegaMarble', false);
	%this.setCollisionRadius($MegaOldRadius);
	%this.megaMarble = false;
	$Client::MegaMarble = false;
	Physics::reloadLayers();
}

function Marble::onJump(%this) {
	//Client-sided
	$Game::LastJumpTime = $Sim::Time;
	$Game::Jumped = true;
	$Game::Jumps ++;
	%ret = $LB::LoggedIn || $Server::Dedicated;
	if (%ret && $platform $= "windows")
	{
		anticheatDetect(); // This shit aint exist on mac lmaoo
	}
}

function Marble::onClientGhostUpdate(%this) {
	//Nothing here but we can if we want
}

function Marble::onBeforeDoPowerUp(%this, %powerUpId) {
	if ($Client::Frozen) {
		//Hack: Save velocity so we don't affect it
		$Client::FreezeVelocity = %this.getVelocity();
		$Client::FreezeAngularVelocity = %this.getAngularVelocity();
	}
	$Client::UsedPowerup[%powerUpId] = true;

	if ($Game::2D) {
		%mult = $Game::LastPressLR $= "Left" ? -1 : 1;
		%amount = $pi_2 * %mult;
		$MP::MyMarble.setCameraYaw($Game::2DYaw + %amount);
	}
}

function Marble::onAfterDoPowerUp(%this, %powerUpId) {
	if ($Client::Frozen) {
		//Hack: Save velocity so we don't affect it
		%this.setVelocity($Client::FreezeVelocity);
		%this.setAngularVelocity($Client::FreezeAngularVelocity);
	}
	if ($Game::2D) {
		$MP::MyMarble.setCameraYaw($Game::2DYaw);
	}
}

function clientCmdPickupClientPowerup(%item, %reset, %objId, %fields) {
	$MP::MyMarble._setPowerUp(%item, %reset, getClientSyncObject(%objId), %fields);
}

function clientCmdResetClientPowerup(%item, %reset) {
	$MP::MyMarble._setPowerUp(0, true, 0);
	devecho("Reset client powerup");
}

function clientCmdClientPowerUp(%index, %id) {
	if (isObject(PlayerList.getEntry(%index)).player) {
		PlayerList.getEntry(%index).player._onPowerUpUsed(%id);
	}
}

function Marble::getVertexShader(%this) {
	%datablock = %this.getDataBlock().getName();
	if (%datablock $= "SeekerMarble" || %datablock $= "NullMarble") {
		return "";
	}
	if (mp()) {
		%player = PlayerList.getEntryByVariable("player", %this);
		%selection = %player.marble;
	} else {
		%selection = MarbleSelectDlg.getSelection();
	}

	//%shapeFile TAB %marbleSkin TAB %shapeNormalSize TAB %shaderV TAB %shaderF;
	return (getFieldCount(%selection) > 2 ? getField(%selection, 3) : "");
}

function Marble::getFragmentShader(%this) {
	%datablock = %this.getDataBlock().getName();
	if (%datablock $= "SeekerMarble" || %datablock $= "NullMarble") {
		return "";
	}
	if (mp()) {
		%player = PlayerList.getEntryByVariable("player", %this);
		%selection = %player.marble;
	} else {
		%selection = MarbleSelectDlg.getSelection();
	}

	//%shapeFile TAB %marbleSkin TAB %shapeNormalSize TAB %shaderV TAB %shaderF;
	return (getFieldCount(%selection) > 3 ? getField(%selection, 4) : "");
}

//-----------------------------------------------------------------------------

if (!isObject(MarbleDataSet)) {
	RootGroup.add(new SimSet(MarbleDataSet));
}

function findMarbleDatablocks(%group) {
	if (%group $= "") {
		%group = ($Server::Hosting && !$Server::_Dedicated ? DataBlockGroup : ServerConnection);
	}
	for (%i = 0; %i < %group.getCount(); %i++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();
		if (%class $= "MarbleData" && !MarbleDataSet.isMember(%obj)) {
			MarbleDataSet.add(%obj);
		} else if (%class $= "SimGroup") {
			findMarbleDatablocks(%obj);
		}
	}
}
