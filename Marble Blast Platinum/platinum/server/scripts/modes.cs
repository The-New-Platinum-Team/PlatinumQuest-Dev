//-----------------------------------------------------------------------------
// Game modes of any sort
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

function resetModes() {
	for (%i = 0; %i < $Server::Modes; %i ++) {
		%name = $Server::Mode[%i];
		echo("[Mode]: Reset Mode" SPC %name);

		%object = _modeGetObject(%name);
		if (isObject(%object)) {
			%object.callback("onReset");
		}
	}
}

function clearModes() {
	resetModes();

	for (%i = 0; %i < $Server::Modes; %i ++) {
		%name = $Server::Mode[%i];

		//Deactivate it
		deactivateMode(%name);
	}

	deleteVariables("$Game::IsMode*");
	deleteVariables("$Server::Mode*");
	$Server::Modes = 0;
}

function activateMode(%name) {
	echo("[Mode]: Activate Mode" SPC %name);

	//Activate the package
	%package = _modeGetPackage(%name);
	if (isPackage(%package) && !isActivePackage(%package)) {
		activatePackage(%package);
	}
	//Send an activate callback
	%object = _modeGetObject(%name);
	if (isObject(%object)) {
		%object.callback("onActivate");
	}

	$Server::Mode[$Server::Modes] = %name;
	$Server::Modes ++;

	$Game::IsMode[%name] = true;
}

function deactivateMode(%name) {
	echo("[Mode]: Deactivate Mode" SPC %name);

	//Send a deactivate callback
	%object = _modeGetObject(%name);
	if (isObject(%object)) {
		%object.callback("onDeactivate");
	}

	//And deactivate the package
	%package = _modeGetPackage(%name);
	if (isPackage(%package) && isActivePackage(%package)) {
		deactivatePackage(%package);
	}

	$Game::IsMode[%name] = false;

	for (%i = 0; %i < $Server::Modes; %i ++) {
		if ($Server::Mode[%i] $= %name) {
			for (%j = %i; %j < $Server::Modes - 1; %j ++) {
				$Server::Mode[%j] = $Server::Mode[%j + 1];
			}
			break;
		}
	}
	$Server::Mode[$Server::Modes - 1] = "";
	$Server::Modes --;
}

function setGameModes(%modes) {
	echo("[Mode]: Proccessing Game Modes:" SPC %modes);
	//Clear duplicate modes (because somehow this is happening)
	for (%i = 0; %i < getWordCount(%modes); %i ++) {
		%wi = getWord(%modes, %i);
		for (%j = %i + 1; %j < getWordCount(%modes); %j ++) {
			if (getWord(%modes, %j) $= %wi) {
				echo("[Mode]: Duplicate mode " @ %wi);
				%modes = removeWord(%modes, %j);
				%j --;
			}
		}
	}

	echo("[Mode]: Setting Game Modes:" SPC %modes);
	clearModes();

	//Load the new modes
	for (%i = 0; %i < getWordCount(%modes); %i ++) {
		%mode = getWord(%modes, %i);
		activateMode(%mode);
	}

	if ($Server::ServerType $= "SinglePlayer") {
		setClientGameModes(%modes);
	} else {
		$Server::GameModes = %modes;
		commandToAll('SetGameModes', %modes);
	}

	//Dedicated servers need these for resolving a few things.
	if ($Server::Dedicated) {
		setClientGameModes(%modes);
	}
}

//-----------------------------------------------------------------------------
// Mode object creation and lifecycle
//-----------------------------------------------------------------------------

function loadMode(%name) {
	if ($pref::Mode::Disable[%name]) {
		//Because I will run into this later and get extremely confused
		error("As per $pref::Mode::Disable, skipping loading mode" SPC %name);
		return;
	}

	%object = _modeGetObject(%name);
	if (isObject(%object)) {
		//Clean up the old mode
		%object.delete();
	}

	echo("[Mode]: Load Mode" SPC %name);

	//We need to exec first
	if (isScriptFile(expandFilename("./modes/" @ %name @ ".cs"))) {
		exec("./modes/" @ %name @ ".cs");
	}

	//Create the object
	%objName = _modeGetObjectName(%name);
	%object = new ScriptObject(%objName) {
		class = %objName;
		superclass = "Mode";
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
function loadGameModes() {
	%pattern = $usermods @ "/server/scripts/modes/*";
	for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
		//Check for DSO, load the file ending in cs
		//If it's a CS, only load it if there's no DSO
		if (fileExt(%file) $= ".dso") {
			%name = fileBase(fileBase(%file));
		} else if (fileExt(%file) $= ".cs" && !isFile(%file @ ".dso")) {
			%name = fileBase(%file);
		}
		loadMode(%name);
	}
}

function reloadGameModes() {
	for (%i = 0; %i < $Server::Modes; %i ++) {
		%name = $Server::Mode[%i];
		echo("[Mode]: Reload Mode" SPC %name);

		%object = _modeGetObject(%name);
		if (isObject(%object)) {
			%object.delete();
		}
		%package = _modeGetPackage(%name);
		if (isPackage(%package)) {
			deactivatePackage(%package);
		}

		if (isScriptFile(expandFilename("./modes/" @ %name @ ".cs"))) {
			loadMode(%name);
		}
		if (isPackage(%package)) {
			activatePackage(%package);
		}
	}
}

//-----------------------------------------------------------------------------

function Mode::registerCallback(%this, %callback) {
	%this.hasCallback[%callback] = true;
}

function Mode::callback(%this, %callback, %default, %object) {
	if (%object._delete) {
		if (!isObject(DeleteGroup)) {
			RootGroup.add(new SimGroup(DeleteGroup));
		}
		DeleteGroup.add(%object);
	}
	if (isObject(%this)) {
		if (!%this.hasCallback[%callback]) {
			//if ($DEBUG)
				//echo("[Mode" SPC %this.name @ "] Unused Callback" SPC %callback);
			return %default;
		}

		//Send it
		if (%object !$= "") {
			%object = "\"" @ expandEscape(%object) @ "\"";
			%value = eval("return " @ %this.getName() @ "::" @ %callback @ "(" @ %this @ "," @ %object @ ");");
		} else {
			%value = eval("return " @ %this.getName() @ "::" @ %callback @ "(" @ %this @ ");");
		}
		if ($DEBUG)
			echo("[Mode" SPC %this.name @ "] Callback" SPC %callback SPC "returned" SPC %value);
	} else {
		//Send the callback to everyone!
		//Everything will be shifted over one though
		%object = %default;
		%default = %callback;
		%callback = %this;

		//And send
		for (%i = $Server::Modes - 1; %i >= 0; %i --) {
			%name = $Server::Mode[%i];

			%mode = _modeGetObject(%name);
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

//-----------------------------------------------------------------------------

function _modeGetObject(%name) {
	return nameToId(_modeGetObjectName(%name));
}

function _modeGetObjectName(%name) {
	return "Mode_" @ %name;
}

function _modeGetPackage(%name) {
	return "Mode_" @ %name;
}
