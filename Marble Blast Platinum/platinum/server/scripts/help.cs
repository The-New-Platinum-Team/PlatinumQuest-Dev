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

//---------------------------------------------------------------------
// Help Bubble
// The help bubble is used for Help Triggers instead of help triggers

datablock StaticShapeData(HelpBubble) {
	className = "LevelParts";
	category = "Help";
	shapeFile = "platinum/data/shapes_pq/Gameplay/HelpBubble.dts";
	skinpass = true;
	skin[0] = "base";
	skin[1] = "blue";

	customField[0, "field"  ] = "text";
	customField[0, "type"   ] = "string";
	customField[0, "name"   ] = "Help Text";
	customField[0, "desc"   ] = "Text that is shown to the player when they enter the trigger.";
	customField[0, "default"] = "Help Text";
	customField[1, "field"  ] = "displayonce";
	customField[1, "type"   ] = "boolean";
	customField[1, "name"   ] = "Only Display Once";
	customField[1, "desc"   ] = "If the trigger should only show once (resets on restart).";
	customField[1, "default"] = "0";
	customField[2, "field"  ] = "persistTime";
	customField[2, "type"   ] = "time";
	customField[2, "name"   ] = "Persist Time";
	customField[2, "desc"   ] = "For how long the help message will be visible after entering the trigger.";
	customField[2, "default"] = "5000";
	customField[3, "field"  ] = "extended";
	customField[3, "type"   ] = "boolean";
	customField[3, "name"   ] = "Use Extended Help";
	customField[3, "desc"   ] = "If the extended help dialog should be used instead.";
	customField[3, "default"] = "0";
	customField[4, "field"  ] = "disable";
	customField[4, "type"   ] = "boolean";
	customField[4, "name"   ] = "Disabled";
	customField[4, "desc"   ] = "If the help bubble is disabled (for use with a trigger).";
	customField[4, "default"] = "0";
	customField[5, "field"  ] = "triggerRadius";
	customField[5, "type"   ] = "float";
	customField[5, "name"   ] = "Active Radius";
	customField[5, "desc"   ] = "Will only show when marble is within this distance.";
	customField[5, "default"] = "3";
};

/**
 * @param {StaticShapeData} %this
 * @param {StaticShape} %obj
 */
function HelpBubble::onAdd(%this, %obj) {
	if (!isObject(HelpBubbleGroup)) {
		new SimGroup(HelpBubbleGroup);
		MissionGroup.add(HelpBubbleGroup);
		bumpMissionGroup(HelpBubbleGroup);
		helpBubbleInit();
	}
	HelpBubbleGroup.schedule(100, add, %obj);

	if (%obj.disable $= "")  //disable normal bubble functionality (for using with trigger or whatever)
		%obj.disable = 0;
	if (%obj.text $= "")
		%obj.text = " ";
	if (%obj.extended $= "") //press button to open large text help window
		%obj.extended = 0;
	if (%obj.triggerRadius $= "")
		%obj.triggerRadius = 3;
	if (%obj.persistTime $= "")  //time that text popup stays onscreen after leaving radius
		%obj.persistTime = 2000;
	if (%obj.displayOnce $= "") // if we should only display the help bubble once.
		%obj.displayOnce = 0;

	if (%obj.disable)
		%obj.setSkinName(%obj.skin);
	else if (%obj.extended)
		%obj.setSkinName('blue');
	else
		%obj.setSkinName('base');

	%obj.playThread(0, "bubble", 1);
}

/**
 * @param {StaticShapeData} %this
 * @param {StaticShape} %obj
 */
function HelpBubble::onMissionReset(%this, %obj) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i++) {
		%marble = ClientGroup.getObject(%i).player;
		if (!isObject(%marble))
			continue;

		// clear field as we have restarted the mission.
		%obj._hasBeenInOnce[%marble] = "";
		%marble._lastHelper = "";
	}
}

/**
 * @param {StaticShapeData} %this
 * @param {Type} %bubble
 * @param {Type} %marble
 */
function HelpBubble::onEnterRadius(%this, %bubble, %marble) {
	echo("HelpBubble::onEnterRadius:" SPC %this SPC %bubble SPC %marble);
	if (%marble._lastHelper !$= %bubble) {
		//Play the noise
		%marble.client.play2D(HelpDingSfx);
	}

	%marble._lastHelper = %bubble;
	cancel(%marble.client.downsched);
	cancel(%marble.client.clearHelperSch);
	%marble.client.addBubbleLine(%bubble.text, %bubble.extended, 0, true);
}

/**
 * @param {StaticShapeData} %this
 * @param {Type} %bubble
 * @param {SimObject} %marble
 */
function HelpBubble::onLeaveRadius(%this, %bubble, %marble) {
	echo("HelpBubble::onLeaveRadius:" SPC %this SPC %bubble SPC %marble);
	if (%bubble.persistTime > 0) {
		echo("HelpBubble::onLeaveRadius: Persist time is" SPC %bubble.persistTime @ "; trying again..." SPC %this SPC %bubble SPC %marble SPC %bubble);
		cancel(%marble.client.downsched);
		%marble.client.downsched = %marble.client.schedule(%bubble.persistTime, "hideBubble");
		%marble.client.clearHelperSch = %marble.schedule(%bubble.persistTime + 1000, "setFieldValue", "_lastHelper", "");
		return;
	}

	%marble.client.hideBubble();
}

//helpBubbleInit():
//should not be called manually
//is only called:
// - when we add the first bubble
// - on mission load

function helpBubbleInit() {
	helpBubbleLoop();
}

function helpBubbleLoop() {
	cancel($bubbleLoop);
	$bubbleLoop = schedule(100, 0, "helpBubbleLoop");

	if (!isObject(HelpBubbleGroup))
		return;

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%marble = %client.player;

		if (!isObject(%marble))
			continue;

		%mpos = %marble.getPosition();
		for (%j = 0; %j < HelpBubbleGroup.getCount(); %j++) {
			%bubble = HelpBubbleGroup.getObject(%j);
			if (%bubble.disable)
				continue;
			//echo(%bubble SPC %marble.isWithin[%bubble]);
			if (VectorDist(%mpos, %bubble.getPosition()) < %bubble.triggerRadius) {
				if (!%marble.isWithin[%bubble]) {
					// If this is a display once only help bubble, then
					// do not display it again
					if (%bubble.displayOnce) {
						// If we have visited it at least once, bail.
						if (%bubble._hasBeenInOnce[%marble])
							continue;
						else
							%bubble._hasBeenInOnce[%marble] = true;
					}

					HelpBubble.onEnterRadius(%bubble, %marble);
					%marble.isWithin[%bubble] = 1;
				}
			} else {
				if (%marble.isWithin[%bubble]) {
					HelpBubble.onLeaveRadius(%bubble, %marble);
					%marble.isWithin[%bubble] = 0;
				}
			}
		}
	}
}
