//-----------------------------------------------------------------------------
// Game modes for client
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

//-----------------------------------------------------------------------------
// Mode activation
//-----------------------------------------------------------------------------

function resetClientModes() {
	for (%i = 0; %i < $Client::Modes; %i ++) {
		%name = $Client::Mode[%i];
		echo("[Client Mode]: Reset Mode" SPC %name);

		%object = _clientModeGetObject(%name);
		if (isObject(%object)) {
			%object.callback("onReset");
		}
	}
}

function clearClientModes() {
	resetClientModes();

	for (%i = 0; %i < $Client::Modes; %i ++) {
		%name = $Client::Mode[%i];

		//Deactivate it
		deactivateClientMode(%name);
	}

	deleteVariables("$Game::IsMode*");
	deleteVariables("$Client::Mode*");
	$Client::Modes = 0;
}

function activateClientMode(%name) {
	echo("[Client Mode]: Activate Mode" SPC %name);

	//Activate the package
	%package = _clientModeGetPackage(%name);
	if (isPackage(%package) && !isActivePackage(%package)) {
		activatePackage(%package);
	}
	//Send an activate callback
	%object = _clientModeGetObject(%name);
	if (isObject(%object)) {
		%object.callback("onActivate");
	}

	$Client::Mode[$Client::Modes] = %name;
	$Client::Modes ++;

	$Game::IsMode[%name] = true;
}

function deactivateClientMode(%name) {
	echo("[Client Mode]: Deactivate Mode" SPC %name);

	//Send a deactivate callback
	%object = _clientModeGetObject(%name);
	if (isObject(%object)) {
		%object.callback("onDeactivate");
	}

	//And deactivate the package
	%package = _clientModeGetPackage(%name);
	if (isPackage(%package) && isActivePackage(%package)) {
		deactivatePackage(%package);
	}
}

function setClientGameModes(%modes) {
	clearClientModes();

	//Load the new modes
	for (%i = 0; %i < getWordCount(%modes); %i ++) {
		%mode = getWord(%modes, %i);
		activateClientMode(%mode);
	}
}

function clientCmdSetGameModes(%modes) {
	echo("[Mode]: Received mode list:" SPC %modes);
	setClientGameModes(%modes);
}

//-----------------------------------------------------------------------------
// Mode object creation and lifecycle
//-----------------------------------------------------------------------------

function loadClientMode(%name) {
	//See if our mode exists yet
	%info = _modeGetInfo(%name);
	if (!isObject(%info)) {
		//We need to exec first
		if (isScriptFile(expandFilename("./modes/" @ %name @ ".cs"))) {
			exec("./modes/" @ %name @ ".cs");
		}

		if (!isObject(_modeGetInfo(%name))) {
			//Can't find it.
			error("[Client Mode]: Mode Not Found:" SPC %name);
			return;
		}
	}
	echo("[Client Mode]: Load Mode" SPC %name);

	//Create the object
	%objName = _clientModeGetObjectName(%name);
	%object = new ScriptObject(%objName) {
		superclass = "ClientMode";
		class = %objName;
		name = %name;
	};

	//You need an onLoad callback
	%object.registerCallback("onLoad");

	//Add it to ModeGroup
	if (!isObject(ModeGroup)) {
		RootGroup.add(new SimGroup(ModeGroup));
	}
	ModeGroup.add(%object);

	//Send a callback
	%object.callback("onLoad");
}

//Load all game modes from the modes directory
function loadClientGameModes() {
	//Create the Mode Info Group
	if (isObject(ModeInfoGroup)) {
		while (ModeInfoGroup.getCount()) {
			ModeInfoGroup.getObject(0).delete();
		}
		ModeInfoGroup.delete();
	}
	RootGroup.add(new SimGroup(ModeInfoGroup));

	%pattern = $usermods @ "/client/scripts/modes/*";
	for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
		//Check for DSO, load the file ending in cs
		//If it's a CS, only load it if there's no DSO
		if (fileExt(%file) $= ".dso") {
			%name = fileBase(fileBase(%file));
		} else if (fileExt(%file) $= ".cs" && !isFile(%file @ ".dso")) {
			%name = fileBase(%file);
		}
		loadClientMode(%name);
	}
}

function reloadClientGameModes() {
	for (%i = 0; %i < $Client::Modes; %i ++) {
		%name = $Client::Mode[%i];
		echo("[Client Mode]: Reload Mode" SPC %name);

		if (isScriptFile(expandFilename("./modes/" @ %name @ ".cs"))) {
			%object = _modeGetInfo(%name);
			if (isObject(%object)) {
				%object.delete();
			}
			%package = _clientModeGetPackage(%name);
			if (isPackage(%package)) {
				deactivatePackage(%package);
			}

			loadClientMode(%name);
			if (isPackage(%package)) {
				activatePackage(%package);
			}
		}
	}
}

//-----------------------------------------------------------------------------

function ClientMode::registerCallback(%this, %callback) {
	%this.hasCallback[%callback] = true;
}

function ClientMode::callback(%this, %callback, %default, %object) {
	// return ClientModeCallback(%this, %callback, %default, %object);
	if (%object._delete) {
		if (!isObject(DeleteGroup)) {
			RootGroup.add(new SimGroup(DeleteGroup));
		}
		DeleteGroup.add(%object);
	}
	if (isObject(%this)) {
		if (!%this.hasCallback[%callback]) {
			return %default;
		}

		//Send it
		if (%object !$= "") {
			%object = "\"" @ expandEscape(%object) @ "\"";
			%value = eval("return " @ %this.getName() @ "::" @ %callback @ "(" @ %this @ "," @ %object @ ");");
		} else {
			%value = eval("return " @ %this.getName() @ "::" @ %callback @ "(" @ %this @ ");");
		}
	} else {
		//Send the callback to everyone!
		//Everything will be shifted over one though
		%object = %default;
		%default = %callback;
		%callback = %this;

		//And send
		for (%i = $Client::Modes - 1; %i >= 0; %i --) {
			%name = $Client::Mode[%i];

			%mode = _clientModeGetObject(%name);
			if (isObject(%mode)) {
				//First mode to return a value gets it.
				//Pass a blank default because the mode might not return anything,
				// and another mode would get pushed out by the default.
				if (%value $= "") {
					%value = %mode.callback(%callback, "", %object);
				} else {
					%mode.callback(%callback, "", %object);
				}
			}
		}
	}

	//Clean up
	if (%object._delete) {
		%object.delete();
	}

	if (%value !$= "") {
		//If we have a value, give it up
		return %value;
	} else {
		//Or just give them the default
		return %default;
	}
}

function ClientMode::callbackModeList(%modes, %callback, %default, %object) {
	if (%object._delete) {
		if (!isObject(DeleteGroup)) {
			RootGroup.add(new SimGroup(DeleteGroup));
		}
		DeleteGroup.add(%object);
	}

	//Send the callback to everyone!
	%count = getWordCount(%modes);
	for (%i = %count - 1; %i >= 0; %i --) {
		%name = getWord(%modes, %i);

		%mode = _clientModeGetObject(%name);
		if (isObject(%mode)) {
			//First mode to return a value gets it.
			//Pass a blank default because the mode might not return anything,
			// and another mode would get pushed out by the default.
			if (%value $= "") {
				%value = %mode.callback(%callback, "", %object);
			} else {
				%mode.callback(%callback, "", %object);
			}
		}
	}

	//Clean up
	if (%object._delete) {
		%object.delete();
	}

	if (%value !$= "") {
		//If we have a value, give it up
		return %value;
	} else {
		//Or just give them the default
		return %default;
	}
}

function ClientMode::callbackForMission(%mission, %callback, %default, %object) {
	%modes = resolveMissionGameModes(%mission, %mission.gameMode);
	return ClientMode::callbackModeList(%modes, %callback, %default, %object);
}

//-----------------------------------------------------------------------------

function _clientModeGetObject(%name) {
	return nameToId(_clientModeGetObjectName(%name));
}

function _clientModeGetObjectName(%name) {
	return "ClientMode_" @ %name;
}

function _clientModeGetPackage(%name) {
	return "ClientMode_" @ %name;
}

//-----------------------------------------------------------------------------

function getModeInfo(%identifier) {
	//Check first for identifier
	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%mode = ModeInfoGroup.getObject(%i);
		if (%mode.identifier $= %identifier)
			return %mode;
	}
	//Then for file
	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%mode = ModeInfoGroup.getObject(%i);
		if (%mode.file $= %identifier)
			return %mode;
	}
	//Then for name
	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%mode = ModeInfoGroup.getObject(%i);
		if (%mode.name $= %identifier)
			return %mode;
	}
}

function resolveGameModeFile(%identifier) {
	for (%i = 0; %i < ModeInfoGroup.getCount(); %i ++) {
		%mode = ModeInfoGroup.getObject(%i);
		if (%mode.identifier $= %identifier)
			return %mode.file;
	}
}

function _modeGetInfoName(%name) {
	return "ModeInfo_" @ %name;
}

function _modeGetInfo(%name) {
	return nameToId(_modeGetInfoName(%name));
}

function ModeInfo::isAvailable(%this) {
	return true;
}

//-----------------------------------------------------------------------------
// Dedicated Server Support

function clientCmdGameModeList(%fields, %class, %identifier) {
	if (!$Server::_Dedicated)
		return;

	if (!isObject(getModeInfo(%identifier))) {
		ModeInfoGroup.add(%mode = new ScriptObject(%class) {
			class = %class;
			superclass = "ModeInfo";

			identifier = %identifier;
		});
		%mode.setFields(%fields);
	}
}
