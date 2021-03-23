//-----------------------------------------------------------------------------
// Null mode - default behavior
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

//Each mode has its own information object that lays out the details and
// configuration of the mode. You should adapt your mode from this one.
ModeInfoGroup.add(new ScriptObject(ModeInfo_null) {
	//The mode info's class should always be ModeInfo_$modeName
	class = "ModeInfo_null";
	//Super class must be ModeInfo
	superclass = "ModeInfo";

	//The identifier for the mode is the internal name that is recognized in
	// mission files under gameMode.
	identifier = "null";
	//The file should be the name of the current mode's file, for executing.
	file = "null";

	//The mode's display name is what will be shown in the mode selector.
	name = "Normal";
	//Description is optional, and not shown anywhere currently.
	desc = "Collect the Gems and finish!";

	//If the mode should be displayed on the mode list in the editor
	hide = 1;

	//If the mode is not considered "complete" then this null mode will be
	// loaded alongside it. Complete modes can run entirely on their own (and
	// are usually difficult to mix) while incomplete modes can be applied
	// liberally on top of any other mode.
	complete = 1;
});


//All modes are a subclass of ClientMode. Every mode will have a ScriptObject
// created for it which will have onLoad called when a user loads the mode.
function ClientMode_null::onLoad(%this) {
	//Register the mode for all of the callbacks which it will need to use.
	// The null mode registers for all callbacks, and has documentation on
	// each in the functions below.
	%this.registerCallback("onActivate");
	%this.registerCallback("onShowPlayGui");
	%this.registerCallback("onOutOfBounds");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onPlayerJoin");
	%this.registerCallback("onPlayerLeave");
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("shouldIgnoreItem");
	%this.registerCallback("shouldUpdateGems");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("updateControls");
	%this.registerCallback("nametagDistance");
	%this.registerCallback("nametagRaycast");
	%this.registerCallback("shouldGhostFollow");
	%this.registerCallback("updateGhostFollow");
	%this.registerCallback("radarShouldShowObject");
	%this.registerCallback("radarGetDotBitmap");
	%this.registerCallback("showEndGame");
	%this.registerCallback("shouldUpdateBlast");
	%this.registerCallback("shouldPickupItem");
	%this.registerCallback("shouldUseClientPowerups");
	%this.registerCallback("shouldShowSpeedometer");
	%this.registerCallback("updateSpeedometer");
	%this.registerCallback("radarShowShouldFinish");
	%this.registerCallback("getCameraFov");
	%this.registerCallback("getMenuCameraFov");
	%this.registerCallback("updateEndGame");
	%this.registerCallback("getScoreFields");
	%this.registerCallback("updatePlayMission");
	%this.registerCallback("getEggIcon");

	echo("[Client Mode" SPC %this.name @ "]: Loaded!");
}
function ClientMode_null::onActivate(%this, %object) {
	//Description:
	// Called when the mode is activated while loading a level or looking at a
	// level's info.
	//Parameters:
	// none

	//Bit of a major hack here:
	//Change mode name/desc based on if the mission we've selected has gems.
	// Need to do this here because updatePlayMission() is called *after* the
	// mode list is displayed and trying to replace this would be inefficient.
	if (!$Server::Dedicated) {
		%currentMis = PlayMissionGui.getMissionInfo();
	} else {
		//Probably correct but it probably doesn't matter
		%currentMis = MissionInfo;
	}
	if (%currentMis.gems > 0) {
		ModeInfo_null.name = "Gem Collection";
		if (%currentMis.gems == 1) {
			ModeInfo_null.desc = "Pick up 1 gem, and then get to the finish!";
		} else {
			ModeInfo_null.desc = "Pick up all" SPC %currentMis.gems SPC "gems, and then get to the finish!";
		}
	} else if (%currentMis.time > 0) {
		ModeInfo_null.name = "Time Trial";
		ModeInfo_null.desc = "Get to the finish before time runs out!";
	} else {
		ModeInfo_null.name = "Speedrun";
		ModeInfo_null.desc = "Get to the finish as fast as possible!";
	}
}
function ClientMode_null::onShowPlayGui(%this, %object) {
	//Description:
	// Called when the PlayGui is shown. (onWake)
	//Parameters:
	// none
}
function ClientMode_null::onOutOfBounds(%this, %object) {
	//Description:
	// Called when the client falls Out of Bounds.
	//Parameters:
	// none
}
function ClientMode_null::onRespawnPlayer(%this, %object) {
	//Description:
	// Called when the client respawns. (respawnPlayer)
	//Parameters:
	// none
}
function ClientMode_null::onPlayerJoin(%this, %object) {
	//Description:
	// Called when a client joins the server. (finishConnect)
	//Parameters:
	// none
}
function ClientMode_null::onPlayerLeave(%this, %object) {
	//Description:
	// Called when a client leaves the server (onDrop)
	//Parameters:
	// none
}
function ClientMode_null::onMissionLoaded(%this, %object) {
	//Description:
	// Called from onMissionLoaded.
	//Parameters:
	// none
}
function ClientMode_null::onMissionEnded(%this, %object) {
	//Description:
	// Called from onMissionEnded.
	//Parameters:
	// none
}
function ClientMode_null::onMissionReset(%this, %object) {
	//Description:
	// Called from onMissionReset.
	//Parameters:
	// none
}
function ClientMode_null::onEndGameSetup(%this, %object) {
	//Description:
	// Called from endGameSetup.
	//Parameters:
	// none
}
function ClientMode_null::shouldIgnoreItem(%this, %object) {
	//Description:
	// Called to determine if the marble should ignore client-side collision
	// for a give item. The item is passed as the variable, instead of as a
	// ScriptObject like the server modes (to save IDs).
	//Parameters:
	// object - Item
	// marble - Marble
	//Returns:
	// true/false
	return false;
}
function ClientMode_null::shouldUpdateGems(%this, %object) {
	//Description:
	// Called to determine if the PlayGui's gem counter should be updated. If
	// false is returned, the counter will not updated, allowing the mode to
	// customize the gem counter (such as hunt mode).
	//Parameters:
	// none
	//Returns:
	// true/false
	return true;
}
function ClientMode_null::timeMultiplier(%this, %object) {
	//Description:
	// Called to determine the game's time multiplier. All time increments
	// will be multiplied by this factor. If this is negative, the mode will
	// be a countdown mode (like hunt).
	//Parameters:
	// none
	//Returns:
	// integer
	return 1;
}
function ClientMode_null::updateControls(%this, %object) {
	//Description:
	// Called when the PlayGui updates its controls (timer, etc).
	//Parameters:
	// none
}
function ClientMode_null::nametagDistance(%this, %object) {
	//Description:
	// Called to determine the distance at which name tags will be hidden.
	// Any players further than the result of this function will not have a
	// name tag shown.
	//Parameters:
	// none
	//Returns:
	// integer
	return 2000;
}
function ClientMode_null::nametagRaycast(%this, %object) {
	//Description:
	// Called to determine whether or not to use client-side raycasting
	// when determining if name tags should be shown.
	//Parameters:
	// none
	//Returns:
	// true/false
	return true;
}
function ClientMode_null::shouldGhostFollow(%this, %object) {
	//Description:
	// Called to determine if ghost following objects should be enabled. If
	// true is returned, updateGhostFollow will be called for each object.
	//Parameters:
	// none
	//Returns:
	// true/false
	return false;
}
function ClientMode_null::updateGhostFollow(%this, %object) {
	//Description:
	// Called to update an object to follow the client's ghost. If false is
	// returned, a default behavior of setting the object's transform to the
	// ghost's transform is used. Return true if you use your own method.
	//Parameters (not a ScriptObject):
	// object - Item
	//Returns:
	// true/false
	return false;
}
function ClientMode_null::radarShouldShowObject(%this, %object) {
	//Description:
	// Called to determine if a particular gem should appear on the radar.
	// Gems that do not appear will still be visible in game.
	//Parameters (not a ScriptObject):
	// object - Item
	//Returns:
	// true/false
	return true;
}
function ClientMode_null::radarGetDotBitmap(%this, %object) {
	//Description:
	// Called to get the filepath to the image for the radar for an object.
	// Returns "path" TAB "skin"
	// If empty string, then default behavior is used.
	//Parameters (not a ScriptObject):
	// object - Item
	//Returns:
	// string
	return "";
}
function ClientMode_null::showEndGame(%this) {
	//Description:
	// Called if a mode wants to show its own end game screen. Return true
	// if the normal end game should not be shown.
	//Parameters:
	// none
	//Returns:
	// true/false
	return false;
}
function ClientMode_null::shouldUpdateBlast(%this) {
	//Description:
	// Called to determine if the blast bar should fill. This will only
	// be called in the event that it would not normally be filled.
	//Parameters:
	// none
	//Returns: true/false
	return false;
}
function ClientMode_null::shouldPickupItem(%this, %object) {
	//Description:
	// Called to determine if an object should be picked up client-side with
	// the fast powerups system.
	//Parameters:
	// object - Item
	// marble - Marble
	//Returns:
	// true/false
	return false;
}
function ClientMode_null::shouldUseClientPowerups(%this) {
	//Description:
	// Called to determine if the mode should use client-sided powerups.
	//Parameters:
	// none
	//Returns:
	// true/false
	return $MP::FastPowerups;
}
function ClientMode_null::shouldShowSpeedometer(%this) {
	//Description:
	// Called to determine if the PlayGui should show the speedometer.
	//Parameters:
	// none
	//Returns:
	// true/false
	return false;
}
function ClientMode_null::updateSpeedometer(%this, %velocity) {
	//Description:
	// Called every frame after the speedometer is updated
	//Parameters (not a ScriptObject):
	// velocity - Float
}
function ClientMode_null::radarShowShouldFinish(%this, %remaining) {
	//Description:
	// Called to determine if the radar should show the finish pad
	//Parameters (not a ScriptObject):
	// remaining - Int
	//Returns:
	// true/false
	return %remaining == 0;
}
function ClientMode_null::getCameraFov(%this) {
	//Description:
	// Should return the desired camera FOV when in-game
	//Parameters
	// none
	//Returns:
	// true/false
	return $pref::Player::defaultFov;
}
function ClientMode_null::getMenuCameraFov(%this) {
	//Description:
	// Should return the desired camera FOV when on the menu
	//Parameters
	// none
	//Returns:
	// true/false
	return 90;
}
function ClientMode_null::updateEndGame(%this) {
	//Description:
	// Called after the end game screen has finished updating so modes can add
	// extra text if they so desire.
	//Parameters:
	// none
}
function ClientMode_null::getScoreFields(%this) {
	//Description:
	// Called when submitting scores to the LBs so modes can add extra parameters
	// to the score query.
	//Parameters:
	// none
	//Returns:
	// string
	return "";
}
function ClientMode_null::updatePlayMission(%this, %which) {
	//Description:
	// Called when PlayMissionGui has finished displaying text for the level,
	// and before it does a final size layout. Use this to add extra features
	// to level scores or descriptions.
	//Parameters (not a ScriptObject):
	// which - String
}
function ClientMode_null::getEggIcon(%this, %found) {
	//Description:
	// Called when PlayMissionGui thinks it should display an egg for a level
	// and wants to know what bitmap to use.
	//Parameters (not a ScriptObject):
	// found - boolean, true if egg has been found
	//Returns:
	// string, full file path
	return "";
}
