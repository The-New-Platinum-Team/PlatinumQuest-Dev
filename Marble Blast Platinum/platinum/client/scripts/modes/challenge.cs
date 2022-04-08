//-----------------------------------------------------------------------------
// Weekly Challenge mode
//-----------------------------------------------------------------------------

if (!isObject(WeeklyChallengeTemplates))
{
	RootGroup.add(new SimGroup(WeeklyChallengeTemplates));
}

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "bowling";
		description = "Bowling";
		paramDesc = "Roll Force: 150%" NL "Gravity: 200%" NL "Friction Force: 200%" NL "Marble Size: 200%";
		marbleSizeMult = "2";
	}
);
Physics::registerLayer("bowling",
                       "maxRollVelocity 22.5 22.5" NL
                       "gravity 40 40" NL
                       "staticFriction 2.2 2.2" NL
                       "kineticFriction 1.4 1.4" NL
                       "bounceKineticFriction 0.4 0.4"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "beachball";
		description = "Beach Ball";
		paramDesc = "Gravity: 40%" NL "Marble Size: 300%" NL "No Powerups" NL "Blast";
		noPowerups = "1";
		marbleSizeMult = "3";
		blast = "1";
	}
);
Physics::registerLayer("beachball",
                       "gravity 8 8"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "steelie";
		description = "Steelie";
		marbleSizeMult = "0.75";
		paramDesc = "Gravity: 167%" NL "Friction Force: 167%" NL "Marble Size: 75%";
	}
);
Physics::registerLayer("steelie",
                       "gravity 33.4 33.4" NL
                       "staticFriction 1.837 1.837" NL
                       "kineticFriction 1.169 1.169" NL
                       "bounceKineticFriction 0.334 0.334"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "highjump";
		description = "High Jump";
		noPowerups = "1";
		paramDesc = "Jump Force: 333%" NL "No Powerups";
	}
);
Physics::registerLayer("highjump", "jumpImpulse 24.975 24.975");

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "superball";
		description = "Superball";
		paramDesc = "Jump Force: 133%" NL "Bounce Force: 180%" NL "Friction Force: 200%";
	}
);
Physics::registerLayer("superball",
					   "staticFriction 2.2 2.2" NL
					   "kineticFriction 1.4 1.4" NL
					   "bounceKineticFriction 0.4 0.4" NL
					   "jumpImpulse 9.975 9.975" NL
					   "bounceRestitution 0.9 0.9"
					  );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "powerless";
		description = "Powerless";
		noPowerups = "1";
		paramDesc = "No Powerups";
	}
);
Physics::registerLayer("powerless","");

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "moonwalk";
		description = "Moon Walk";
		paramDesc = "Gravity: 17%";
	}
);
Physics::registerLayer("moonwalk",
                       "gravity 3.4 3.4"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "megamarble";
		description = "Mega Marble";
		marbleSizeMult = "2.5";
		paramDesc = "Marble Size: 250%" NL "Gravity: 140%" NL "Jump Force: 160%";
	}
);
Physics::registerLayer("megamarble",
                       "gravity 28 28" NL
					   "jumpImpulse 12 12"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "aircontrol";
		description = "Air Control";
		paramDesc = "Air Force: 400%" NL "Roll Speed: 10%";
	}
);
Physics::registerLayer("aircontrol",
                       "airAcceleration 20 20" NL
					   "maxRollVelocity 1.5 1.5"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "blastclub";
		description = "Blast Club";
		blast = "1";
		paramDesc = "Bounce Force: 200%" NL "Jump Force: 0%" NL "Blast";
	}
);
Physics::registerLayer("blastclub",
                       "bounceRestitution 1.005 1.005" NL
					   "jumpImpulse 0 0"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "ricochet";
		description = "Ricochet";
		paramDesc = "Friction Force: 15%" NL "Air Force: 0%";
	}
);
Physics::registerLayer("ricochet",
					   "staticFriction 0.165 0.165" NL
					   "kineticFriction 0.21 0.21" NL
					   "bounceKineticFriction 0.03 0.03" NL
					   "airAcceleration 0 0"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "tortoise";
		description = "Tortoise";
		paramDesc = "Roll Force: 50%" NL "Air Force: 50%" NL "Friction Force: 200%";
	}
);
Physics::registerLayer("tortoise",
                       "airAcceleration 2.5 2.5" NL
					   "maxRollVelocity 7.5 7.5" NL
					   "staticFriction 2.2 2.2" NL
                       "kineticFriction 1.4 1.4" NL
                       "bounceKineticFriction 0.4 0.4"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "slipslide";
		description = "Slip and Slide";
		paramDesc = "Friction Force: 20%";
	}
);
Physics::registerLayer("slipslide",
					   "staticFriction 0.22 0.22" NL
					   "kineticFriction 0.14 0.14" NL
					   "bounceKineticFriction 0.04 0.04"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "groundcontrol";
		description = "Ground Control";
		paramDesc = "Friction Force: 200%" NL "Jump Force: 25%";
	}
);
Physics::registerLayer("groundcontrol",
					   "jumpImpulse 1.875 1.875" NL
                       "staticFriction 2.2 2.2" NL
                       "kineticFriction 1.4 1.4" NL
                       "bounceKineticFriction 0.4 0.4"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "fastforward";
		description = "Fast Forward";
		paramDesc = "Roll Force: 400%" NL "Air Force: 400%" NL "Gravity: 400%" NL "Jump Force: 400%";
	}
);
Physics::registerLayer("fastforward",
                       "airAcceleration 20 20" NL
					   "maxRollVelocity 60 60" NL
					   "gravity 80 80" NL
                       "jumpImpulse 30 30"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "offroad";
		description = "Offroad";
		noGems = "1";
		paramDesc = "No Gems";
	}
);
Physics::registerLayer("offroad", "");

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "landlocked";
		description = "Land Locked";
		noPowerups = "1";
		paramDesc = "Jump Impulse: 25%" NL "No Powerups";
	}
);
Physics::registerLayer("landlocked",
					   "jumpImpulse 1.875 1.875"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "grounded";
		description = "Grounded";
		paramDesc = "Jump Impulse: 25%";
	}
);
Physics::registerLayer("grounded",
					   "jumpImpulse 1.875 1.875"
                      );

WeeklyChallengeTemplates.add(
	new ScriptObject(ChallengeTemplate)
	{
		name = "rebound";
		description = "Rebound";
		paramDesc = "Jump Impulse: 0%" NL "Bounce Force: 200%";
	}
);
Physics::registerLayer("rebound",
                       "bounceRestitution 1.005 1.005" NL
					   "jumpImpulse 0 0"
                      );

//Each mode has its own information object that lays out the details and
// configuration of the mode. You should adapt your mode from this one.
ModeInfoGroup.add(new ScriptObject(ModeInfo_challenge) {
	//The mode info's class should always be ModeInfo_$modeName
	class = "ModeInfo_challenge";
	//Super class must be ModeInfo
	superclass = "ModeInfo";

	//The identifier for the mode is the internal name that is recognized in
	// mission files under gameMode.
	identifier = "challenge";
	//The file should be the name of the current mode's file, for executing.
	file = "challenge";

	//The mode's display name is what will be shown in the mode selector.
	name = "Weekly Challenge";
	//Description is optional, and not shown anywhere currently.
	desc = "";

	//If the mode should be displayed on the mode list in the editor
	hide = 1;

	//If the mode is not considered "complete" then this null mode will be
	// loaded alongside it. Complete modes can run entirely on their own (and
	// are usually difficult to mix) while incomplete modes can be applied
	// liberally on top of any other mode.
	complete = 0;
});


//All modes are a subclass of ClientMode. Every mode will have a ScriptObject
// created for it which will have onLoad called when a user loads the mode.
function ClientMode_challenge::onLoad(%this) {
	//Register the mode for all of the callbacks which it will need to use.
	// The null mode registers for all callbacks, and has documentation on
	// each in the functions below.
	%this.registerCallback("onActivate");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onRespawnOnCheckpoint");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("shouldUpdateBlast");
	%this.registerCallback("getScoreFields");

	echo("[Client Mode" SPC %this.name @ "]: Loaded!");
}
function ClientMode_challenge::onActivate(%this, %object) {
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
	ModeInfo_challenge.desc = $CurrentWeeklyChallenge.paramDesc;
}

function updateWeeklyChallengePhysics()
{
	Physics::pushLayerName($CurrentWeeklyChallenge.name);
}

function ClientMode_challenge::onMissionReset(%this, %object) {
	onNextFrame(updateWeeklyChallengePhysics);
}
function ClientMode_challenge::onRespawnPlayer(%this) {
	onNextFrame(updateWeeklyChallengePhysics);
}
function ClientMode_challenge::onRespawnOnCheckpoint(%this) {
	onNextFrame(updateWeeklyChallengePhysics);
}

function ClientMode_challenge::onEndGameSetup(%this, %object) {
	//Description:
	// Called from endGameSetup.
	//Parameters:
	// none
}
function ClientMode_challenge::shouldUpdateBlast(%this) {
	return $CurrentWeeklyChallenge.blast;
}
function ClientMode_challenge::getScoreFields(%this) {
	//Description:
	// Called when submitting scores to the LBs so modes can add extra parameters
	// to the score query.
	//Parameters:
	// none
	//Returns:
	// string
	return "";
}

function listChallenges() {
	for (%i = 0; %i < WeeklyChallengeTemplates.getCount(); %i++) {
		%challenge = WeeklyChallengeTemplates.getObject(%i);
		echo("Challenge: " @ %challenge.name @ ":" @ %challenge.paramDesc);
	}
}

function activateChallenge(%challengeName) {
	activateMode("challenge");
	activateClientMode("challenge");
	for (%i = 0; %i < WeeklyChallengeTemplates.getCount(); %i++) {
		%challenge = WeeklyChallengeTemplates.getObject(%i);
		echo(%challenge.name @ "==" @ %challengeName);
		if (%challenge.name $= %challengeName) {
			$CurrentWeeklyChallenge = %challenge;
			break;
		}
	}
}