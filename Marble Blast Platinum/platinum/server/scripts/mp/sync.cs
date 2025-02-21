//-----------------------------------------------------------------------------
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

function serverResetSyncObjects() {
	devecho("Resetting sync objects");
	for (%i = 0; %i < $Server::SyncObjects; %i ++) {
		%obj = $Server::SyncObject[%i];
		if (isObject(%obj)) {
			%obj._sync = false;
			$Server::SyncObject[%obj] = "";
		}
	}

	$Server::SyncObjects = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.sentSyncObjects = false;
		%client.syncObjects = 0;
	}
}

function serverCleanSyncObjects() {
	for (%i = 0; %i < $Server::SyncObjects; %i ++) {
		%obj = $Server::SyncObject[%i];
		if (!isObject(%obj)) {
			//devecho("Sync object " @ %obj @ " #" @ %i @ " no longer exists");
			$Server::SyncObject[%i] = $Server::SyncObject[$Server::SyncObjects - 1];
			$Server::SyncObject[%i, "finishCmd"] = $Server::SyncObject[$Server::SyncObjects - 1, "finishCmd"];
			$Server::SyncObject[%i, "arg0"] = $Server::SyncObject[$Server::SyncObjects - 1, "arg0"];
			$Server::SyncObjects --;
		}
	}
}

function NetObject::setSync(%this, %finishCmd, %arg0) {
	//Damnit
	%this = %this.getId();
	%this._sync = true;
	%this._syncCmd = %finishCmd;
	%this._syncArg0 = %arg0;

	if ($Server::SyncObject[%this] $= "") {
		devecho("Set sync of " @ %this @ " #" @ $Server::SyncObjects @ " of type " @ %this.getClassName() @ " / " @ %this.getParentClasses());
		$Server::SyncObject[$Server::SyncObjects] = %this;
		$Server::SyncObject[$Server::SyncObjects, "finishCmd"] = %finishCmd;
		$Server::SyncObject[$Server::SyncObjects, "arg0"] = %arg0;
		$Server::SyncObjects ++;
		$Server::SyncObject[%this] = $Server::SyncObjects;
	} else {
		%index = $Server::SyncObjects[%this];
	}

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.sentSyncObjects) {
			//They already got the rest of the objects, just send this one at the end
			%client.syncObject(%this, %finishCmd, %arg0);
		}
	}
}

//Resend the sync object using the same parameters as when it was first synced
function NetObject::resync(%this) {
	if (%this._sync) {
		%this.setSync(%this._syncCmd, %this._syncArg0);
	}
}

function GameConnection::testSyncObjects(%this) {
	for (%i = 0; %i < $Server::SyncObjects; %i ++) {
		%obj = $Server::SyncObject[%i];
		if (!%this.syncObject[%obj]) {
			devecho("We don't have " @ %obj);
		}
		if (!$Client::SyncObject[%obj.getSyncId()]) {
			devecho("Client doesn't have " @ %obj);
		}
	}
}

function GameConnection::sendSyncObjects(%this) {
	serverCleanSyncObjects();

	devecho("sending " @ $Server::SyncObjects @ " sync objects to client " @ %this.namebase);
	for (%i = 0; %i < $Server::SyncObjects; %i ++) {
		%obj = $Server::SyncObject[%i];
		%finishCmd = $Server::SyncObject[%i, "finishCmd"];
		%arg0 = $Server::SyncObject[%i, "arg0"];

		%this.syncObject(%obj, %finishCmd, %arg0);
	}
	commandToClient(%this, 'SyncObjectCount', %this.syncObjects);
	%this.sentSyncObjects = true;
}

function GameConnection::syncObject(%this, %object, %finishCmd, %arg0) {
	%db = (%object.getType() & $TypeMasks::GameBaseObjectType) ? %object.getDataBlock().getName() @ " / " : "";
	devecho("Sending sync object " @ %object @ " to " @ %this @ " cmd " @ %finishCmd @ " of type " @ %db @ %object.getParentClasses());

	if (stripos(%object.getParentClasses(), "NetObject") == -1) {
		error("Tried to sync a " @ %object.getClassName() @ "!");
		return;
	}
	//If you sync an invisible object everything will explode
	if ((%object.getType() & $TypeMasks::ShapeBaseObjectType) && %object.isHidden()) {
		error("Tried to sync a hidden object: " @ %object);
		return;
	}
	if (%object.getClassName() $= "Camera" && %this.camera.getId() != %object.getId()) {
		//Don't sync our camera with other people, but DO sync our own camera with ourselves
		return;
	}

	if (!%this.syncObject[%object]) {
		%this.syncObject[%object] = true;
		%this.syncObjects ++;
	}

	//Make sure the object lets the client know it exists
	%object.setScopeAlways();
	%object.scopeToClient(%this);
	%object.forceNetUpdate();
	%this.syncObject1(%object, %finishCmd, %arg0);
	//commandToClient(%this, 'SyncObjectTest', %object.getSyncId(), %finishCmd, %arg0);
}

function serverCmdSyncObjectResend(%client, %id, %finishCmd, %arg0) {
	%object = getServerSyncObject(%id);
	if (isObject(%object)) {
		%object.forceNetUpdate();
		%client.syncObject(%object, %finishCmd, %arg0);
	} else {
		//Doesn't exist, shut up
		commandToClient(%client, 'SyncObjectFail', %id);
	}
}

function serverCmdSyncObjectFinish(%client, %id, %finishCmd, %arg0) {
	%object = getServerSyncObject(%id);
	if (isObject(%object)) {
		traceGuard();
		// field SPC value TAB field SPC value ....
		%fields = %object.getFields(1);

		//devecho("Sent sync object " @ %object.getSyncId() @ " (" @ %object.getClassName() @ ") to client " @ %this);

		// Send off the whole string
		commandToClientLong(%client, 'SyncObject', %fields, %object.getName(), %id, %finishCmd, %arg0);
		traceGuardEnd();
	}
}

function serverCmdSyncObjectUpdate(%client, %id) {
	%object = getServerSyncObject(%id);
	if (isObject(%object)) {
		%object.forceNetUpdate();
	} else {
		//Doesn't exist, shut up
		commandToClient(%client, 'SyncObjectFail', %id);
	}
}

function serverCmdSyncObjectComplete(%client, %which, %total) {
	%client.onSyncObjectComplete(%total);
	if (%total == %client.syncObjects) {
		%client.onAllSyncObjectsComplete();
	}
}
