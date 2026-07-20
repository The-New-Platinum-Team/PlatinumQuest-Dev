//-----------------------------------------------------------------------------
// Tag mode
// I was bored. Ok?
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

/**
 * @param {Mode} %this
 */
function Mode_tag::onLoad(%this) {
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("getStartTime");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onBlast");
	%this.registerCallback("timeMultiplier");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
/**
 * @param {Mode_tag} %this
 */
function Mode_tag::shouldResetTime(%this, %object) {
	return false;
}
/**
 * @param {Mode_tag} %this
 */
function Mode_tag::shouldRestartOnOOB(%this, %object) {
	return false;
}
/**
 * @param {Mode_tag} %this
 */
function Mode_tag::timeMultiplier(%this) {
	return -1;
}
/**
 * @param {Mode_tag} %this
 * @param {Type} %object
 */
function Mode_tag::onRespawnPlayer(%this, %object) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		ClientGroup.getObject(%i).setTag(false);
	}
	%object.client.setTag(true);
}
/**
 * @param {Mode_tag} %this
 * @param {Type} %object
 */
function Mode_tag::onFoundGem(%this, %object) {
	%object.client.playPitchedSound("gotDiamond");
}
/**
 * @param {Mode_tag} %this
 */
function Mode_tag::onMissionReset(%this, %object) {
	for (%clientIndex = 0; %clientIndex < %count; %clientIndex++) {
		%cl = ClientGroup.getObject(%clientIndex);
		if (!%cl.spectating && !$Server::FirstSpawn)
			%cl.respawnPlayer(%cl.spawnPoint);
	}
}
/**
 * @param {Mode_tag} %this
 */
function Mode_tag::getStartTime(%this) {
	return (MissionInfo.time ? MissionInfo.time : 300000);
}
/**
 * @param {Mode_tag} %this
 * @param {Type} %object
 */
function Mode_tag::onBlast(%this, %object) {
	%mePos = %object.this.getWorldBoxCenter();
	%theyPos = %object.other.getWorldBoxCenter();
	if (VectorDist(%mePos, %theyPos) < %object.this.getBlastRadius(%object.strength, %object.other)) {
		%object.this.client.onTag(%object.other.client);
	}
}

/**
 * @param {GameConnection} %this
 */
function GameConnection::setTag(%this, %isTagger) {
	if (!$Game::isMode["tag"])
		return;
	if (%isTagger) {
		//You are now the tagger

		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (%client.tagger)
				%client.tagger = false;
		}

		%this.taggerSchedule = %this.schedule(1000, taggerUpdate);
		%this.setMessage("tagger");
		%this.schedule(4000, setMessage, "");
		%this.setNameTag("<color:ff9999>" @ stripMLControlChars(%this.getNameTag()));
	} else {
		%this.setMessage("");
		%this.setNameTag(stripMLControlChars(%this.getNameTag()));
	}
	%this.tagger = %isTagger;

	%this.updateGhostDatablock();
	%this.taggerUpdate();
	%this.taggerTimeout = true;
	%this.schedule(2000, taggerTimeoutEnd);

	updateScores();
}

/**
 * @param {GameConnection} %this
 */
function GameConnection::taggerTimeoutEnd(%this) {
	%this.taggerTimeout = false;
}

/**
 * @param {GameConnection} %this
 */
function GameConnection::taggerUpdate(%this) {
	if (!%this.tagger)
		return;
	if (!$Game::isMode["tag"])
		return;
	cancel(%this.taggerSchedule);

	if (%this.state $= "play" || %this.state $= "go") {
		%this.gemCount ++;
		%this.setGemCount(%this.gemCount);
	}

	%this.taggerSchedule = %this.schedule(1000, taggerUpdate);
	updateScores();
}

/**
 * @param {GameConnection} %this
 * @param {GameConnection} %client
 */
function GameConnection::onTag(%this, %client) {
	if (!$Game::isMode["tag"])
		return;
	//%this tagged %client

	echo(%this.getUsername() SPC "tagging" SPC %client.getUsername());

	if ($Game::IsMode["stampede"] && %client.tagger && !%client.taggerTimeout && !%this.taggerTimeout) {
		//Stampede mode, you want to be the tagger
		%this.setTag(true);
		%client.setTag(false);
	} else if ($Game::IsMode["keepAway"] && %this.tagger && !%client.taggerTimeout && !%this.taggerTimeout) {
		//Camp mode, you don't want to be
		%this.setTag(false);
		%client.setTag(true);
	}
}

/**
 * @param {Marble} %this
 * @param {Marble} %opponent
 */
function Marble::getBlastRadius(%this, %strength, %opponent) {
	%maxRadius = (MissionInfo.tagRadius ? MissionInfo.tagRadius : 15);
	echo("maxrad was" SPC %maxRadius);
	%myMod   = mPow(1 + (%this.client.getPing() + 200) / 170, 1.1);
	%theyMod = mPow(1 + (%opponent.client.getPing() + 200) / 170, 0.9);
	%myMod = mClamp(%myMod, 0.5, 4);
	%theyMod = mClamp(%theyMod, 0.5, 4);
	echo("Myping:" SPC %this.client.getPing());
	echo("Theyping:" SPC %opponent.client.getPing());
	echo("Mymod:" SPC %myMod);
	echo("Theymod:" SPC %theyMod);
	%maxRadius = (%maxRadius * %myMod) / %theyMod;
	echo("maxrad is" SPC %maxRadius);
	%tagDistance = %maxRadius / (1 + mPow($e, -(%strength - 3)));
	return %tagDistance;
}