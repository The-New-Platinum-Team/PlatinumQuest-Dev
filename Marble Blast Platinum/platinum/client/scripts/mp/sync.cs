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

function clientCmdSyncObjectCount(%count) {
	$Client::SyncObjectCount = %count;

	checkSyncObjectsDone();
}

function clientCmdSyncObjectTest(%id, %finishCmd, %arg0) {
	if (getClientSyncObject(%id) == -1) {
		devecho("Need resend of sync object id " @ %id);
		commandToServer('SyncObjectResend', %id, %finishCmd, %arg0);
	} else {
		devecho("Get sync object id " @ %id @ " found " @ getClientSyncObject(%id));
		commandToServer('SyncObjectFinish', %id, %finishCmd, %arg0);
	}
}

function clientCmdSyncObject(%fields, %name, %id, %finishCmd, %arg0) {
	/** @type {SimObject} */
	%obj = getClientSyncObject(%id);
	if (%obj == -1) {
		//Hack -- if the object has magically disappeared then we need to ask for it again
		error(%id @ " has magically disappeared. Trying to find it again.");
		commandToServer('SyncObjectResend', %id, %finishCmd, %arg0);
		return;
	}

	%obj.setFields(%fields);

	//Don't conflict names with a server object if we're the local client
	if (!isObject(%name)) {
		%obj.setName(%name);
	}

	onSyncObjectReceived(%id);

	if (%finishCmd !$= "") {
		//devecho("Sync object " @ %id @ " has extra callback of " @ %finishCmd @ " with arg " @ %arg0);
		call(%finishCmd, %obj, %arg0);
	}
}

function onSyncObjectReceived(%id) {
	if (!$Client::SyncObject[%id]) {
		$Client::SyncObjects ++;
		$Client::SyncObject[%id] = true;
		devecho("Got sync object #" @ $Client::SyncObjects @ ": " @ %id);

		checkSyncObjectsDone();
	}
}

function checkSyncObjectsDone() {
	if ($Client::SyncObjects == $Client::SyncObjectCount) {
		onSyncObjectsDone();
		commandToServer('AllSyncObjectsComplete', $MSeq);
	} else if ($Client::SyncObjects < $Client::SyncObjectCount) {
		onPhase3Progress($Client::SyncObjects / $Client::SyncObjectCount);
	}
}

/**
 * @param {SimObject} %datablock
 */
function clientCmdDatablockField(%datablock, %field, %value) {
	devecho("DBField: " @ %datablock SPC%field SPC %value);
	if (isObject(%datablock)) {
		%datablock.setFieldValue(%field, %value);
	}
}

function clientCmdSyncObjectFail(%id) {
	//It doesn't exist
}


