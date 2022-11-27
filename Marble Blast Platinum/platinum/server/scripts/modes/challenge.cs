//-----------------------------------------------------------------------------
// Challenge - Weekly Challenge
//-----------------------------------------------------------------------------

//All modes are a subclass of Mode. Every mode will have a ScriptObject
// created for it which will have onLoad called when a user loads the mode.
function Mode_challenge::onLoad(%this) {
	//Register the mode for all of the callbacks which it will need to use.
	// The null mode registers for all callbacks, and has documentation on
	// each in the functions below.
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("shouldPickupGem");
	%this.registerCallback("shouldPickupItem");
	%this.registerCallback("shouldIgnoreGem");
	%this.registerCallback("shouldDisablePowerup");
	%this.registerCallback("shouldPickupPowerup");
	%this.registerCallback("getMarbleSize");
	%this.registerCallback("getUltraMarbleSize");
	%this.registerCallback("canFinish");

	//Don't kill our CPU, but this is how you'd do it
	//%this.registerCallback("onFrameAdvance");

	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_challenge::onMissionLoaded(%this, %object) {
	if (!mp()) {    // There are no MP Challenges, so challenge modifiers should not persist when playing MP. ~Connie
       if ($CurrentWeeklyChallenge.noGems) $Game::GemCount = 0;
	}
}
function Mode_challenge::onMissionEnded(%this, %object) {
	//Description:
	// Called from onMissionEnded.
	//Parameters:
	// none
}
function Mode_challenge::onMissionReset(%this, %object) {
	if (!mp()) {
       if ($CurrentWeeklyChallenge.noGems) $Game::GemCount = 0;
	}
}
function Mode_challenge::shouldPickupGem(%this, %object) {
	if (!mp()) {
		if ($CurrentWeeklyChallenge.noGems) return false;
	    return true;
	}
}
function Mode_challenge::shouldIgnoreGem(%this, %object) {
	if (!mp()) {
		if ($CurrentWeeklyChallenge.noGems) return false;
	    return true;
	}
}
function Mode_challenge::shouldDisablePowerup(%this, %object) {
	if (!mp()) {
	    return $CurrentWeeklyChallenge.noPowerups $= "1";
	}
}
function Mode_challenge::shouldPickupPowerup(%this, %object) {
	if (!mp()) {
	    return $CurrentWeeklyChallenge.noPowerups !$= "1";
	}
}
function Mode_challenge::shouldPickupItem(%this, %object) {
	if (!mp()) {
	    switch$ (%object.obj.getDataBlock().getName()) {
		    case "EasterEgg" or "EasterEgg_MBG" or "EasterEgg_MBU" or "NestEgg_PQ":
			    return false;
	    }
	    return true;
	}
}
function Mode_challenge::getMarbleSize(%this, %object) {

    if (!mp()) {
	    %marbleSizeMult = 1.0;
	    if ($CurrentWeeklyChallenge.marbleSizeMult !$= "")
		    %marbleSizeMult = $CurrentWeeklyChallenge.marbleSizeMult;

	    if ($CurrentGame $= "Gold")
		    return %object.client.player.getDataBlock().goldScale * %marbleSizeMult;
	    else
		    return %object.client.player.getDataBlock().scale * %marbleSizeMult;
	}
}
function Mode_challenge::getUltraMarbleSize(%this, %object) {

	if (!mp()) {
	    %marbleSizeMult = 1.0;
	    if ($CurrentWeeklyChallenge.marbleSizeMult !$= "")
		    %marbleSizeMult = $CurrentWeeklyChallenge.marbleSizeMult;

	    return %object.client.player.getDataBlock().ultraScale * %marbleSizeMult;
	}
}
function Mode_challenge::canFinish(%this, %object) {
	//Description:
	// Called to determine if a player is allowed to finish the level.
	//Parameters:
	// client - GameConnection
	//Returns:
	// true/false

    if (!mp()) {
	    if ($CurrentWeeklyChallenge.noGems)
		    return true;

	    return !($Game::GemCount && %object.client.getGemCount() < $Game::GemCount);
	}
}
