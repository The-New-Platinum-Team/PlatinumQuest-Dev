//-----------------------------------------------------------------------------
// Hide and "Seek" mode
//
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
function Mode_seek::onLoad(%this) {
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onGameState");
	%this.registerCallback("onTimeExpire");
	%this.registerCallback("onCollision");
	%this.registerCallback("onUpdateGhost");
	%this.registerCallback("onPlayerLeave");
	%this.registerCallback("onPlayerJoin");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("updateWinner");
	%this.registerCallback("shouldAllowTTs");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
/**
 * @param {Mode_seek} %this
 */
function Mode_seek::onMissionReset(%this) {
	//Start up the game here
	chooseSeeker();
	startHiding();
	updateSeekFreeze();

	//No gems in seek mode. Screw you.
	hideGems();

	//Let them know when it's starting
	cancelCountdown();
	%time = (MissionInfo.hideTime ? MissionInfo.hideTime : 30000);
	startCountdown(%time, "Seeking starting in %s second(s)!", startSeeking);

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.freezeMarble(false);
	}

	%graceTime = (MissionInfo.graceTime ? MissionInfo.graceTime : 20000);
	commandToAll('SeekGracePeriod', %graceTime);
}
/**
 * @param {Mode_seek} %this
 */
function Mode_seek::onMissionEnded(%this) {
	//Reset all the clients
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setNameTag("");
		%client.seeker = false;
		%client.freezeMarble(false);
	}

	cancel($Game::SeekFreeze);
}
/**
 * @param {Mode_seek} %this
 * @param {Type} %object
 */
function Mode_seek::onGameState(%this, %object) {
	if (%object.state !$= "End" && %object.state !$= "Go") {
		cancel(%object.client.stateSchedule);
		%object.client.setGameState("Go");

		if (!$Game::Seeking) {
			%time = (MissionInfo.hideTime ? MissionInfo.hideTime : 30000);

			%object.client.stopTimer();
			%object.client.setTime(%time);
			%object.client.startTimer();

			//Don't let the seekers out if we haven't started yet!
			if (%object.client.seeker) {
				%object.client.player.setTransform(getField(%object.client.getCheckpointPos(), 0));
				%object.client.player.setMode(Start);
			}
		}
	}
}
/**
 * @param {Mode_seek} %this
 */
function Mode_seek::onTimeExpire(%this) {
	if ($Server::Hosting && !$MP::Restarting) {
		if ($Game::Seeking) {
			endGameSetup();
		} else {
			startSeeking();
		}
	}
	return false;
}
/**
 * @param {Mode_seek} %this
 * @param {Type} %object
 */
function Mode_seek::onCollision(%this, %object) {
	if (!$Game::Seeking)
		return;
	if (%object.client1.seeker != %object.client2.seeker) {
		//Someone got tagged
		if (%object.client1.seeker) {
			%object.client1.onFind(%object.client2);
		} else {
			%object.client2.onFind(%object.client1);
		}
	}
}
/**
 * @param {Mode_seek} %this
 * @param {Type} %object
 */
function Mode_seek::onUpdateGhost(%this, %object) {
	%object.client.updateSeekerMarble();
}
/**
 * @param {Mode_seek} %this
 * @param {Type} %object
 */
function Mode_seek::onPlayerJoin(%this, %object) {
	%object.client.setSeeker(true);
}
/**
 * @param {Mode_seek} %this
 */
function Mode_seek::onPlayerLeave(%this) {
	detectSeekerUpdate();
}
/**
 * @param {Mode_seek} %this
 */
function Mode_seek::shouldResetTime(%this) {
	return false;
}
/**
 * @param {Mode_seek} %this
 */
function Mode_seek::shouldRestartOnOOB(%this) {
	return false;
}
/**
 * @param {Mode_seek} %this
 */
function Mode_seek::onEndGameSetup(%this) {
	checkSeekVictory();
}
/**
 * @param {Mode_seek} %this
 */
function Mode_seek::updateWinner(%this, %winners) {
	updateSeekWinner(%winners);
}
/**
 * @param {Mode_seek} %this
 */
function Mode_seek::shouldAllowTTs(%this) {
	return false;
}

//--------------------------------------------------------------------------

/**
 * @param {GameConnection} %this
 * @param {GameConnection} %client
 */
function GameConnection::onFind(%this, %client) {
	//Let us know
	%this.addHelpLine("You have found" SPC %client.getDisplayName() @ "!");
	%this.onFoundGem(1);

	//Let them know
	%client.setSeeker(true);
	%client.addHelpLine("You have been found! Go find the other players!");
	%client.updateGhostDatablock();
	%client.freezeMarble(false);

	serverSendChat("<color:ff6666>" @ %this.getDisplayName() SPC "has found" SPC %client.getDisplayName() @ "!");

	detectSeekerUpdate();
}

/**
 * @param {GameConnection} %this
 */
function GameConnection::setSeeker(%this, %seeker) {
	%this.seeker = %seeker;
	if (%seeker) {
		%this.setNameTag("<color:ff6666>" @ %this.getDisplayName());
	} else {
		%this.setNameTag("");
	}
}

/**
 * @param {GameConnection} %this
 */
function GameConnection::updateSeekerMarble(%this) {
	if ($Game::Seeking) {
		if (%this.seeker) {
			if (%this.isMegaMarble()) {
				%this.player.setDatablock(SeekerMegaMarble);
			} else {
				%this.player.setDatablock(SeekerMarble);
			}
			%this.player.setSkinName("skin50");
		} else {
			%skinChoice = %this.skinChoice;
			%skin = getField(%skinChoice, 2);

			if (%this.isMegaMarble()) {
				%playerdb = $Seek::HiderMegaDatablock[getField(%skinChoice, 1)];
			} else {
				%playerdb = $Seek::HiderDatablock[getField(%skinChoice, 1)];
			}
			%this.player.setDatablock(%playerdb);
			%this.player.setSkinName(%skin);
		}
	} else {
		if (%this.seeker) {
			if (%this.isMegaMarble()) {
				%this.player.setDatablock(SeekerMegaMarble);
			} else {
				%this.player.setDatablock(SeekerMarble);
			}
			%this.player.setSkinName("skin50");
		}
	}
}

//--------------------------------------------------------------------------

function detectSeekerUpdate() {
	//Check if nobody is a seeker. If that's the case, we need a new seeker!
	//Also check if everyone is a seeker. If so, the seekers win!

	%seekers = 0;
	%hiders = 0;

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.seeker) {
			%seekers ++;
		} else {
			%hiders ++;
		}
	}

	//Choose a new seeker if we need to
	if (%seekers == 0) {
		//This might cause the next statement to trigger, if you only have one
		// player left who is a hider. So we do this first.
		%hiders --;
		%seekers ++;

		//If we aren't full of seekers yet, then pick a new one. Otherwise, we
		// end up picking a new seeker right as the game ends
		if (%hiders != 0) {
			chooseSeeker();
		}
	}
	//If we're all out of hiders, game over
	if (%hiders == 0) {
		//This hits endGame
		endGameSetup();
	}
}

//--------------------------------------------------------------------------

/**
 * @param {GameConnection} %seeker
 */
function chooseSeeker(%seeker) {
	//Fuck the RNG.
	setRandomSeed($Sim::Time);

	echo("Last seeker was" SPC $Seek::LastInitial.getUsername() SPC "so we\'ll pick someone new.");

	//Make everyone a hider except for one seeker
	%possible = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		/** @type {GameConnection} */
		%client = ClientGroup.getObject(%i);
		%client.setSeeker(false);

		//Don't let the same person go twice
		if ($Seek::LastInitial.getId() == %client.getId())
			continue;

		%clients[%possible] = %client;
		%possible ++;
	}

	//Pick them from ClientGroup at random
	if (!isObject(%seeker) && isObject($queuedSeeker)) {
		%seeker = $queuedSeeker;
		$queuedSeeker = 0;
	}


	if (!isObject(%seeker))
		%seeker = %clients[getRandom(0, %possible - 1)];

	$Seek::LastInitial = %seeker;
	%seeker.setSeeker(true);
	detectSeekerUpdate();
}

function queueSeeker(%client) {
	$queuedSeeker = %client;
}

function startHiding() {
	//Init hiding period
	$Game::Seeking = false;

	//Stop the seeker, let the hiders go
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.updateGhostDatablock();

		if (%client.seeker) {
			//The seeker is anchored to the start pad
			%client.addHelpLine("Everyone is hiding, better take notes!");
			%client.player.setTransform(getField(%client.getCheckpointPos(), 0));
			%client.player.setMode(Start);
			%client.player.setCloaked(false);
			%client.freezeMarble(false);
		} else {
			%client.player.setCloaked(true);
			%client.addHelpLine("The Seeker is coming to get you! Find a place to hide!");
			%client.freezeMarble(false);
		}

		%time = (MissionInfo.hideTime ? MissionInfo.hideTime : 30000);
		%client.stopTimer();
		%client.setTime(%time);
		%client.startTimer();
	}
}

function updateSeekFreeze() {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.seeker) {
			%client.freezeMarble($Game::Seeking);
		} else {
			if ($Game::Seeking) {
				%client.player.setMode(Normal);
			} else {
				%client.player.setMode(Start);
			}
		}
	}
}

function startSeeking() {
	$Game::Seeking = true;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		//Hiders become slower, seekers become faster
		%client.updateGhostDatablock();
		%client.stopTimer();
		%client.setTime(MissionInfo.time ? MissionInfo.time : 300000);
		%client.startTimer();

		//Start both the seeker and the hiders
		if (%client.seeker) {
			%client.addHelpLine("Go find them!");
			%client.player.setMode(Normal);
		} else {
			%client.freezeMarble(true);
			%client.player.setCloaked(false);
			%client.addHelpLine("The Seeker is loose!");
		}
	}
}

//--------------------------------------------------------------------------

function checkSeekVictory() {
	$Game::Seeking = false;

	//Count the total number of hiders and seekers to see who wins
	%seekers = 0;
	%hiders = 0;

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.seeker) {
			%seekers ++;
		} else {
			%hiders ++;
		}
	}

	if (%seekers == 0) {
		serverSendChat("<color:66ff66>The hiders have won!");

		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.winner = !%client.seeker;
		}
	} else if (%hiders == 0) {
		serverSendChat("<color:66ff66>The seekers have won!");

		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.winner = %client.seeker;
		}
	} else {
		//Nobody is left ...

		//Nobody wins!
	}
}

/**
 * @param {Array} %winners
 */
function updateSeekWinner(%winners) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.winner) {
			%winners.addEntry(%client);
		}
	}
}

//--------------------------------------------------------------------------

function startCountdown(%time, %message) {
	$countdownEvent1 = schedule(%time - 3000, 0, countdownRemaining, 3, %message);
	$countdownEvent2 = schedule(%time - 2000, 0, countdownRemaining, 2, %message);
	$countdownEvent3 = schedule(%time - 1000, 0, countdownRemaining, 1, %message);
}

function cancelCountdown() {
	cancel($countdownEvent1);
	cancel($countdownEvent2);
	cancel($countdownEvent3);
}

function countdownRemaining(%seconds, %message) {
	//Quick and dirty string replacement
	%message = strreplace(%message, "%s", %seconds);

	//Plurals as well
	%message = strreplace(%message, "(s)", (%seconds == 1 ? "" : "(s)"));

	//And tell everyone
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.addHelpLine(%message);
	}
}

//-----------------------------------------------------------------------------

datablock MarbleData(SeekerMarble : LBDefaultMarble) {
	maxRollVelocity = 20;
	angularAcceleration = 85;
	brakingAcceleration = 40;
	airAcceleration = 7;

	staticFriction = 1.4;
	kineticFriction = 0.9;
	bounceKineticFriction = 0.3;
};

datablock MarbleData(SeekerMegaMarble : MegaMarble) {
	maxRollVelocity = 20;
	angularAcceleration = 75;
	brakingAcceleration = 40;

	staticFriction = 1.4;
	kineticFriction = 0.9;
	bounceKineticFriction = 0.3;
};

datablock MarbleData(HiderMarble : LBDefaultMarble) {
	maxRollVelocity = 7.5;
	angularAcceleration = 30;
	brakingAcceleration = 20;
	airAcceleration = 1;

	staticFriction = 1.2;
	kineticFriction = 0.7;
	bounceKineticFriction = 0.2;

	mass = 4;
};

datablock MarbleData(HiderMegaMarble : MegaMarble) {
	maxRollVelocity = 7.5;
	angularAcceleration = 19;
	brakingAcceleration = 13;
	airAcceleration = 1;

	staticFriction = 1.4;
	kineticFriction = 0.8;
	bounceKineticFriction = 0.2;

	mass = 4;
};

//Hider needs extra DBs because they can have any skin. Seeker is forced into
//	using the "Hex" skin
datablock MarbleData(HiderMarble3D : HiderMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/3dMarble.dts";
};
datablock MarbleData(HiderMarbleMidP : HiderMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/midp.dts";
};
datablock MarbleData(HiderMarblePack1 : HiderMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/pack1/pack1marble.dts";
	emap = false;
};
datablock MarbleData(HiderMegaMarble3D : HiderMegaMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/3dMarble.dts";
};
datablock MarbleData(HiderMegaMarbleMidP : HiderMegaMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/midp.dts";
};
datablock MarbleData(HiderMegaMarblePack1 : HiderMegaMarble) {
	shapeFile = $usermods @ "/data/shapes/balls/pack1/pack1marble.dts";
	emap = false;
};

//List of datablocks
$Seek::HiderDatablock[0] = HiderMarble;
$Seek::HiderDatablock[1] = HiderMarble3D;
$Seek::HiderDatablock[2] = HiderMarbleMidP;
$Seek::HiderDatablock[4] = HiderMarblePack1;
$Seek::HiderMegaDatablock[0] = HiderMegaMarble;
$Seek::HiderMegaDatablock[1] = HiderMegaMarble3D;
$Seek::HiderMegaDatablock[2] = HiderMegaMarbleMidP;
$Seek::HiderMegaDatablock[4] = HiderMegaMarblePack1;
