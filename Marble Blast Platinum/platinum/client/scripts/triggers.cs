//-----------------------------------------------------------------------------
// triggers.cs
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

// TODO: DOCSTRINGS

if (!isObject(ClientTriggerSet)) {
	new SimSet(ClientTriggerSet);
	RootGroup.add(ClientTriggerSet);
}

// credits to seizure22
function Trigger::isPointInside(%trigger, %point, %includeEqualTo) {
	%box = %trigger.getWorldBox();
	%x1 = getWord(%box, 0);
	%x2 = getWord(%box, 3);
	%y1 = getWord(%box, 1);
	%y2 = getWord(%box, 4);
	%z1 = getWord(%box, 2);
	%z2 = getWord(%box, 5);

	%px = getWord(%point, 0);
	%py = getWord(%point, 1);
	%pz = getWord(%point, 2);

	if (%includeEqualTo)
		return (%px >= %x1 && %px <= %x2 &&
		        %py >= %y1 && %py <= %y2 &&
		        %pz >= %z1 && %pz <= %z2);
	else
		return (%px > %x1 && %px < %x2 &&
		        %py > %y1 && %py < %y2 &&
		        %pz > %z1 && %pz < %z2);
}

function Trigger::onClientEnterTrigger(%this, %user) {
	call(%this.getDatablock().getName() @ "_onClientEnterTrigger", %this.getDatablock(), %this, %user);
}
function Trigger::onClientStayTrigger(%this, %user) {
	call(%this.getDatablock().getName() @ "_onClientStayTrigger", %this.getDatablock(), %this, %user);
}
function Trigger::onClientLeaveTrigger(%this, %user) {
	call(%this.getDatablock().getName() @ "_onClientLeaveTrigger", %this.getDatablock(), %this, %user);
}
function Trigger::onPlayerEnter(%this, %user) {
	call(%this.getDatablock().getName() @ "_onPlayerEnter", %this.getDatablock(), %this, %user);
}
function Trigger::onPlayerUpdate(%this, %user) {
	call(%this.getDatablock().getName() @ "_onPlayerUpdate", %this.getDatablock(), %this, %user);
}
function Trigger::onPlayerLeave(%this, %user) {
	call(%this.getDatablock().getName() @ "_onPlayerLeave", %this.getDatablock(), %this, %user);
}
function Trigger::shouldTriggerForPlayer(%this, %user) {
	return call(%this.getDatablock().getName() @ "_shouldTriggerForPlayer", %this.getDatablock(), %this, %user);
}
function Trigger::getDistance(%this, %user) {
	return call(%this.getDatablock().getName() @ "_getDistance", %this.getDatablock(), %this, %user);
}
function Trigger::getRadius(%this, %user) {
	return call(%this.getDatablock().getName() @ "_getRadius", %this.getDatablock(), %this, %user);
}

//-----------------------------------------------------------------------------

/// This function is received before any triggers have been sent. It clears the
/// trigger list so we don't duplicate triggers if any are re-sent.
function clientCmdReceiveTriggerStart() {
	ClientTriggerSet.clear();
}

function onReceiveTrigger(%trigger) {
	%worldBox = %trigger.getWorldBox();
	%datablock = %trigger.getDatablock();

	devecho("Received trigger at worldbox:" SPC %worldBox SPC "with datablock:" SPC %datablock);

	// STORE the string precached
	// build the info string based upon marble attributes
	%i = 0;
	%fields = "";
	while ((%attribute = %trigger.marbleAttribute[%i]) !$= "") {
		// append each set of attributes.
		if (%fields $= "")
			%fields = %attribute SPC %trigger.value[%i] SPC %trigger.megaValue[%i];
		else
			%fields = %fields NL %attribute SPC %trigger.value[%i] SPC %trigger.megaValue[%i];

		%i++;
	}
	%trigger.fieldCache = %fields;
	ClientTriggerSet.add(%trigger);
}

//-----------------------------------------------------------------------------

/// Calculates a discrete collision test between the client control object's
/// marble and all of the triggers that have been registered with the client.
/// Whenever the marble enters a trigger, it will invoke the method
/// ClientTrigger::onClientEnterTrigger() and whenever the marble leaves a trigger,
/// it will invoke the method ClientTrigger::onClientLeaveTrigger()
function clientTriggerCollisionTest() {
	%size = PlayerList.getSize();
	for (%i = 0; %i < %size; %i++) {
		%marble = PlayerList.getEntry(%i).player;
		if (!isObject(%marble))
			continue;

		//Split this off to another method so we can use the hacked MP::MyMarble
		// code below to make triggers faster.
		checkMarbleTriggerCollisions(%marble);
	}

	if (MPMyMarbleExists())
		checkMarbleTriggerCollisions($MP::MyMarble);
}

function checkMarbleTriggerCollisions(%marble) {
	//Apparently sometimes %marble isn't a marble
	%collBox = %marble.getClassName() $= "Marble" ? %marble.getCollisionBox() : %marble.getWorldBox();
	%marbleBox = BoxAddVector(%collBox, %marble.getWorldBoxCenter());

	%count = ClientTriggerSet.getCount();
	for (%i = 0; %i < %count; %i++) {
		%trigger = ClientTriggerSet.getObject(%i);

		if (%trigger.testObject(%marble)) {
			// If we are not registered as in inside, then we just entered the
			// trigger
			if (!%trigger.isInTrigger[%marble]) {
				devecho("Marble " @ %marble @ " is inside " @ %trigger);
				devecho("Was not before, calling enter");
				%trigger.onClientEnterTrigger(%marble);
				%trigger.isInTrigger[%marble] = true;
			} else {
				//Stay event
				%trigger.onClientStayTrigger(%marble);
			}
		} else if (%trigger.isInTrigger[%marble]) {
			devecho("Marble " @ %marble @ " no longer inside " @ %trigger);
			// the marble has left the trigger
			%trigger.onClientLeaveTrigger(%marble);
			%trigger.isInTrigger[%marble] = false;
		}
	}
}

/// Clears the client trigger list
function clearClientTriggerList() {
	// TODO: see if this is being called properly
	// (the function, not the while loop)
	PhysicsLayerArray.clear();
	while (ClientTriggerSet.getCount()) {
		%trigger = ClientTriggerSet.getObject(0);
		if (%trigger.isInTrigger) {
			// the marble has left the trigger
			%trigger.onClientLeaveTrigger();
			%trigger.isInTrigger = false;
		}
		ClientTriggerSet.remove(%trigger);
	}
}
function clientResetTriggerEntry() {
	if (!isObject(ServerConnection))
		return;
	%ctrl = ServerConnection.getControlObject();
	if (!isObject(%ctrl) || %ctrl.getClassName() !$= "Marble")
		return;

	%count = ClientTriggerSet.getCount();
	for (%i = 0; %i < %count; %i++) {
		%trigger = ClientTriggerSet.getObject(%i);

		//Use the trigger's dynamic field list to see every marble that has entered it
		%fields = %trigger.getDynamicFieldList();
		%fieldCount = getFieldCount(%fields);
		for (%j = 0; %j < %fieldCount; %j ++) {
			%field = getField(%fields, %j);
			//Check if the field is isInTrigger<marble>
			if (getSubStr(%field, 0, 11) $= "isInTrigger") {
				//Extract player id
				%marble = getSubStr(%field, 11, strlen(%field));
				//Don't leave them if they're not real
				if (isObject(%marble) && %trigger.isInTrigger[%marble]) {
					%trigger.onClientLeaveTrigger(%marble);
				}
				//Clean up the trigger
				%trigger.isInTrigger[%marble] = false;
			}
		}
	}
}

function AlignmentTrigger_onClientEnterTrigger(%this, %trigger, %user) {
	AlignmentTrigger_align(%this, %trigger, %user);
}

function AlignmentTrigger_onClientStayTrigger(%this, %trigger, %user) {
	if (%trigger.alwaysOn) {
		AlignmentTrigger_align(%this, %trigger, %user);
	}
}

function AlignmentTrigger_onClientLeaveTrigger(%this, %trigger, %user) {

}

function AlignmentTrigger_align(%this, %trigger, %user) {
	//Don't care if other people need to be aligned
	if (!MPMyMarbleExists() || %user.getId() != MPGetMyMarble().getId())
		return;
	%pos = %user.getPosition();
	%vel = %user.getVelocity();
	%ang = %user.getAngularVelocity();

	%tpos = %trigger.getWorldBoxCenter();

	if (%trigger.x !$= "none") {
		if (%trigger.x $= "trigger") //Trigger-specified value
			%pos = setWord(%pos, 0, getWord(%tpos, 0));
		else //Center of trigger
			%pos = setWord(%pos, 0, %trigger.x);
		//Make sure to clear any velocity in this direction so we don't misalign immediately after hitting the trigger
		%vel = setWord(%vel, 0, 0);
		//Also clear x/y angular so we don't roll out of it
		%ang = setWord(%ang, 1, 0);
	}
	if (%trigger.y !$= "none") {
		if (%trigger.y $= "trigger") //Trigger-specified value
			%pos = setWord(%pos, 1, getWord(%tpos, 1));
		else //Center of trigger
			%pos = setWord(%pos, 1, %trigger.y);
		//Make sure to clear any velocity in this direction so we don't misalign immediately after hitting the trigger
		%vel = setWord(%vel, 1, 0);
		//Also clear x/y angular so we don't roll out of it
		%ang = setWord(%ang, 0, 0);
	}
	if (%trigger.z !$= "none") {
		if (%trigger.z $= "trigger") //Trigger-specified value
			%pos = setWord(%pos, 2, getWord(%tpos, 2));
		else //Center of trigger
			%pos = setWord(%pos, 2, %trigger.z);
		//Make sure to clear any velocity in this direction so we don't misalign immediately after hitting the trigger
		%vel = setWord(%vel, 2, 0);
	}

	%user.setTransform(%pos SPC %user.getRotation());
	%user.setVelocity(%vel);
	%user.setAngularVelocity(%ang);
}

//-----------------------------------------------------------------------------

function BubbleUseTrigger_onClientEnterTrigger(%this, %trigger, %user) {
	//Don't care if other people use this
	if (!MPMyMarbleExists() || %user.getId() != MPGetMyMarble().getId())
		return;

	devecho("ClientBubbleUseTrigger::onClientEnterTrigger");
	// start bubble and keep it active
	// we make it an infinite bubble.
	$Game::ForceBubble = true;
	clientCmdSetBubbleTime(1, true);
}

function BubbleUseTrigger_onClientStayTrigger(%this, %trigger, %user) {
	//Nothing
}

function BubbleUseTrigger_onClientLeaveTrigger(%this, %trigger, %user) {
	//Don't care if other people use this
	if (!MPMyMarbleExists() || %user.getId() != MPGetMyMarble().getId())
		return;

	devecho("ClientBubbleUseTrigger::onClientLeaveTrigger");
	// stop bubbles
	$Game::ForceBubble = false;
	clientCmdSetBubbleTime(0, false);
}

//-----------------------------------------------------------------------------

function changeEnvironment(%direction, %color, %ambient, %skybox) {
	if (%direction !$= "" && %color !$= "" && %ambient !$= "") {
		%sun = findSun(ServerConnection);
		if (%sun != -1) {
			if (%sun.getFieldValue("notedDirection") $= "" || %sun.getFieldValue("notedColor") $= "" || %sun.getFieldValue("notedAmbient") $= "") {
				%sun.setFieldValue("notedDirection", %sun.getFieldValue("direction"));
				%sun.setFieldValue("notedColor", %sun.getFieldValue("color"));
				%sun.setFieldValue("notedAmbient", %sun.getFieldValue("ambient"));
			}
			%sun.setColor(%direction, %color, %ambient);
		}
	}
	if (%skybox !$= "") {
		%sky = findSky(ServerConnection);
		if (%sky != -1) {
			if (%sky.getFieldValue("notedMaterialList") $= "") {
				%sky.setFieldValue("notedMaterialList", %sky.getFieldValue("materialList"));
			}
			%sky.setMaterialList(%skybox);
		}
	}
}

function resetEnvironment() {
	%sun = findSun(ServerConnection);
	if (%sun != -1) {
		%direction = %sun.getFieldValue("notedDirection");
		%color = %sun.getFieldValue("notedColor");
		%ambient = %sun.getFieldValue("notedAmbient");
		if (%direction !$= "" && %color !$= "" && %ambient !$= "") {
			%sun.setColor(%direction, %color, %ambient);
		}
	}
	%sky = findSky(ServerConnection);
	if (%sky != -1) {
		%skybox = %sky.getFieldValue("notedMaterialList");
		if (%skybox !$= "") {
			%sky.setMaterialList(%skybox);
		}
	}
}

function clientCmdChangeEnvironment(%direction, %color, %ambient, %skybox) {
	changeEnvironment(%direction, %color, %ambient, %skybox);
}

function clientCmdResetEnvironment() {
	resetEnvironment();
}