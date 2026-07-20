//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Copyright (c) 2001 GarageGames.Com
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

//------------------------------------------------------------------------------
// Utility remap functions:
//------------------------------------------------------------------------------

/**
 * @param {ActionMap} %this
 * @param {ActionMap} %otherMap
 */
function ActionMap::copyBind(%this, %otherMap, %command) {
	if (!isObject(%otherMap)) {
		error("ActionMap::copyBind - \"" @ %otherMap @ "\" is not an object!");
		return;
	}

	%bind = %otherMap.getBinding(%command);
	if (%bind !$= "") {
		%device = getField(%bind, 0);
		%action = getField(%bind, 1);
		%flags = %otherMap.isInverted(%device, %action) ? "SDI" : "SD";
		%deadZone = %otherMap.getDeadZone(%device, %action);
		%scale = %otherMap.getScale(%device, %action);
		%this.bind(%device, %action, %flags, %deadZone, %scale, %command);
	}
}

//------------------------------------------------------------------------------

/**
 * @param {ActionMap} %this
 * @param {ActionMap} %otherMap
 */
function ActionMap::blockBind(%this, %otherMap, %command) {
	if (!isObject(%otherMap)) {
		error("ActionMap::blockBind - \"" @ %otherMap @ "\" is not an object!");
		return;
	}

	%bind = %otherMap.getBinding(%command);
	if (%bind !$= "")
		%this.bind(getField(%bind, 0), getField(%bind, 1), "");
}
