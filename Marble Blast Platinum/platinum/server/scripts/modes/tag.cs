//-----------------------------------------------------------------------------
// Tag mode
//
// Originally created in 2014
//
// Copyright (c) 2023 The Platinum Team
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

function Mode_tag::onLoad(%this) {
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onBlast");
	%this.registerCallback("onCollision");
	%this.registerCallback("enableMarbleCollisions");
	%this.registerCallback("onClientLeaveGame");
	%this.registerCallback("onClientEnterGame");
	%this.registerCallback("onPlayerJoin");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("getStartTime");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("onOutOfBounds");
	%this.registerCallback("onQuickRespawnPlayer");
	%this.registerCallback("onGameState");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("shouldSetSpectate");
	%this.registerCallback("getMaxSpectators");
	%this.registerCallback("shouldRestorePowerup");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	%this.registerCallback("onEnterPad");
	%this.registerCallback("shouldDumpScores");
	%this.registerCallback("onDeactivate");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_tag::onMissionReset(%this) {
	//Choose the tagger to start the game
	chooseTagger();

	//Get rid of the gems
	hideGems();

	if (MissionInfo.campMode) {
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (!%client.isActive())
				%client.onNextFrame(TagRemoveScore);
		}
	}
}
function Mode_tag::onMissionEnded(%this) {
	//Reset all the clients
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setTag(false);
	}
}
function Mode_tag::onBlast(%this, %object) {
	if (%object.this == %object.other)
		return;
	//Define blast radius
	%tagRadius = %object.this.client.blastValue * 7.5;
	if (%object.this.client.usingTripleBlast) {
		%tagRadius = 3;
	}
	if (%object.this.client.usingSpecialBlast) {
		%tagRadius = 10;
	}
	if (%object.this.client.isMegaMarble()) {
		%tagRadius /= $MP::MegaBlastModifier;
	}
	if (%object.other.client.isMegaMarble()) {
		return;
	}
	%mePos = %object.this.getWorldBoxCenter();
	%theyPos = %object.other.getWorldBoxCenter();
	if (VectorDist(%mePos, %theyPos) < %tagRadius) {
		//Someone got tagged
		%object.this.client.onTag(%object.other.client);
	}
}
function Mode_tag::onCollision(%this, %object) {
	if (%object.client1.tagger != %object.client2.tagger) {
		//Someone got tagged
		if (!%object.client1.tagger) {
			%object.client1.onTag(%object.client2);
		} else {
			%object.client2.onTag(%object.client1);
		}
	}
}
function Mode_tag::enableMarbleCollisions(%this) {
	return true;
}
function Mode_tag::onClientLeaveGame(%this, %object) {
	if (%object.client.tagger) {
		//Choose a new tagger
		$Tag::LastInitial = %object.client;
		chooseTagger();
	}

	if (MissionInfo.campMode && isGameStarted() && mp()) {
		%object.client.TagRemoveScore();
	}
}
function Mode_tag::onClientEnterGame(%this, %object) {
	if (MissionInfo.campMode && isGameStarted() && mp()) {
		%object.client.setSpectating(true);
	}
}
function Mode_tag::onPlayerJoin(%this, %object) {
	if (MissionInfo.campMode && isGameStarted() && mp()) 
		%object.client.TagRemoveScore();
}
function Mode_tag::shouldResetTime(%this) {
	return false;
}
function Mode_tag::shouldRestartOnOOB(%this) {
	return false;
}
function Mode_tag::getStartTime(%this) {
	return (MissionInfo.time ? MissionInfo.time : 300000);
}
function Mode_tag::timeMultiplier(%this) {
	return -1;
}
function Mode_tag::shouldRespawnGems(%this) {
	return false;
}
function Mode_tag::onOutOfBounds(%this, %object) {
	//You are no longer the tagger if you go OOB
	if (!MissionInfo.campMode && %object.client.tagger) {
		%object.client.schedule(2000, setMessage, "tagger", 4000);
		$Tag::LastInitial = %object.client;
		chooseTagger();

	//Opposite for camp mode
	} else if (MissionInfo.campMode && !%object.client.tagger) {
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (%client.tagger) {
				%client.setTag(false);
				%client.onFoundGem(0);
				%client.addHelpLine("You are no longer the Tagger.");
			}
		}
		
		%object.client.setTag(true, true);
		%object.client.schedule(2000, setMessage, "tagger", 4000);
		commandToAll('TaggerID', %object.client.player.getSyncID());
	}
}
function Mode_tag::onQuickRespawnPlayer(%this, %object) {
	//You are no longer the tagger if you quick respawn
	if (!MissionInfo.campMode && %object.client.tagger && $Game::State $= "Go") {
		%object.client.setMessage("tagger", 4000);
		$Tag::LastInitial = %object.client;
		chooseTagger();

	//Opposite for camp mode
	} else if (MissionInfo.campMode && !%object.client.tagger && $Game::State $= "Go" && %object.client.isActive()) {
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (%client.tagger) {
				%client.setTag(false);
				%client.onFoundGem(0);
				%client.addHelpLine("You are no longer the Tagger.");
			}
		}
		
		%object.client.setTag(true);
		%object.client.setMessage("tagger", 4000);
		commandToAll('TaggerID', %object.client.player.getSyncID());
	}
}
function Mode_tag::onGameState(%this, %object) {
	//Give everyone an Ultra Blast at the start
	if (%object.state $= "Start") {
		%object.client.onNextFrame(setBlastValue, 1);
		%object.client.onNextFrame(setSpecialBlast, true);
	}
}
function Mode_tag::onFoundGem(%this, %object) {
	%object.client.playPitchedSound("gotDiamond");
	whiteAll(0.10);
}
function Mode_tag::shouldSetSpectate(%this, %object) {
	if (!MissionInfo.campMode) {
		//No spectator abuse
		return !%object.client.tagger;

	} else {
		//Spectating is disabled in camp mode
		return false;
	}
}
function Mode_tag::getMaxSpectators(%this) {
	//Need at least two players
	return getRealPlayerCount() - 2;
}
function Mode_tag::shouldRestorePowerup(%this) {
	return true;
}
function Mode_tag::getScoreType(%this) {
	return $ScoreType::Score;
}
function Mode_tag::getFinalScore(%this, %object) {
	return $ScoreType::Score TAB %object.client.getGemCount();
}
function Mode_tag::onEnterPad(%this, %object) {
	return true;
}
function Mode_tag::shouldDumpScores(%this) {
	return false;
}
function Mode_tag::onDeactivate(%this) {
	%this.onMissionEnded();
}

//--------------------------------------------------------------------------

function chooseTagger() {
	setRandomSeed($Sim::Time);

	//Don't choose a new tagger if there is no one to choose
	if (mp()) {
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (!%client.isActive())
				continue;
			%active ++;
			if (!%client.tagger)
				continue;
			%taggers ++;
		}
		if (%active == %taggers || %active == 0)
			return;
	}

	%possible = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setTag(false);

		if ($Tag::LastInitial.getId() == %client.getId())
			continue;

		if (!%client.isActive())
			continue;

		%clients[%possible] = %client;
		%possible ++;
	}

	//Pick them from ClientGroup at random
	%tagger = %clients[getRandom(0, %possible - 1)];

	$Tag::LastInitial = %tagger;
	%tagger.setTag(true);
	commandToAll('TaggerID', %tagger.player.getSyncID());
	%tagger.onNextFrame(addHelpLine, "You are the Tagger.");
	
	if ($Game::State $= "Go" && $Time::ElapsedTime != 0) { 
		%tagger.onFoundGem(0); 
	}
}


function GameConnection::TagRemoveScore(%this) {
	//Hack: This makes the score disappear from the scoreboard, and tanks their score
	//TODO: Better method?
	%this.gemCount = -100000;
	%this.setGemCount(%this.gemCount);
	updateSingleScore(%this);
}

//--------------------------------------------------------------------------

function GameConnection::onTag(%this, %client) {
	if (!$Game::isMode["tag"])
		return;
	//%this tagged %client

	//Don't allow people to be tagged before the game starts!
	if ($Game::State $= "Go") {
		//Is the gamemode normal or camp?
		if (!MissionInfo.campMode && %client.tagger && !%client.taggerTimeout && !%this.taggerTimeout) {
			echo("[Mode Tag]:" SPC %this.getDisplayName() SPC "tagging" SPC %client.getDisplayName());
			%this.setTag(true);
			%this.addHelpLine("You tagged" SPC %client.getDisplayName() @ "!");
			%this.onFoundGem(0);
			%this.taggerTimeout = true;
			%this.schedule(3000, taggerTimeoutEnd);
			commandToAll('TaggerID', %this.player.getSyncID());
			%client.setTag(false);
			%client.setMessage("tagger", 4000);
			%client.taggerTimeout = true;
			%client.schedule(3000, taggerTimeoutEnd);

		} else if (MissionInfo.campMode && %this.tagger && !%client.taggerTimeout && !%this.taggerTimeout) {
			echo("[Mode Tag]:" SPC %this.getDisplayName() SPC "tagging" SPC %client.getDisplayName());
			%this.setTag(false);
			%this.addHelpLine("You tagged" SPC %client.getDisplayName() @ "!");
			%this.onFoundGem(0);
			%this.taggerTimeout = true;
			%this.schedule(3000, taggerTimeoutEnd);
			%client.setTag(true);
			%client.setMessage("tagger", 4000);
			%client.taggerTimeout = true;
			%client.schedule(3000, taggerTimeoutEnd);
			commandToAll('TaggerID', %client.player.getSyncID());
		}
	}
}

function GameConnection::setTag(%this, %tagger, %oob) {
	%this.tagger = %tagger;
	if (%tagger) {
		%this.taggerUpdate();
		%this.setNameTag("<color:ff9999>" @ %this.getDisplayName());
		if (!%oob)
			%this.setMessage("");
	} else {
		%this.setNameTag("");
	}

}

function GameConnection::taggerTimeoutEnd(%this) {
	%this.taggerTimeout = false;
}

function GameConnection::taggerUpdate(%this) {
	if (!%this.tagger)
		return;
	if (!$Game::isMode["tag"])
		return;
	cancel(%this.taggerSchedule);

	if (%this.state $= "play" || %this.state $= "go") {
		if (!MissionInfo.campMode) {
			%this.gemCount ++;
			%this.setGemCount(%this.gemCount);
			updateScores();
		} else {
			%this.gemCount --;
			%this.setGemCount(%this.gemCount);
			updateScores();
		}
	}

	%this.taggerSchedule = %this.schedule(1000, taggerUpdate);
}