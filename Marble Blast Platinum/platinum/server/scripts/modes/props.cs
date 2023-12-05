// //-----------------------------------------------------------------------------
// // Prop Hunt mode
// //
// // Copyright (c) 2015 The Platinum Team
// //
// // Permission is hereby granted, free of charge, to any person obtaining a copy
// // of this software and associated documentation files (the "Software"), to
// // deal in the Software without restriction, including without limitation the
// // rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// // sell copies of the Software, and to permit persons to whom the Software is
// // furnished to do so, subject to the following conditions:
// //
// // The above copyright notice and this permission notice shall be included in
// // all copies or substantial portions of the Software.
// //
// // THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// // IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// // FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// // AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// // LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// // FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// // DEALINGS IN THE SOFTWARE.
// //-----------------------------------------------------------------------------

// //-----------------------------------------------------------------------------
// // TODO:
// //  - Hider and seeker roles
// //  - OOB makes hiders lose
// //  - Lowest score wins
// //  - Client options to select item type
// //  - Hack DTS to have collision-less hazards?
// //-----------------------------------------------------------------------------

// function Mode_props::onLoad(%this) {
// 	%this.registerCallback("shouldPickupItem");
// 	%this.registerCallback("getStartTime");
// 	%this.registerCallback("shouldDisablePowerup");
// 	%this.registerCallback("shouldResetGem");
// 	%this.registerCallback("shouldResetTime");
// 	%this.registerCallback("shouldRestartOnOOB");
// 	%this.registerCallback("shouldRespawnGems");
// 	%this.registerCallback("shouldDisableCheckpoint");
// 	%this.registerCallback("shouldAllowTTs");
// 	%this.registerCallback("onFoundGem");
// 	%this.registerCallback("onServerChat");
// 	%this.registerCallback("onTimeExpire");
// 	%this.registerCallback("onPlayerLeave");
// 	%this.registerCallback("onMissionReset");
// 	%this.registerCallback("onGameState");
// 	%this.registerCallback("timeMultiplier");
// 	echo("[Mode" SPC %this.name @ "]: Loaded!");
// }
// function Mode_props::shouldPickupItem(%this, %object) {
// 	if (%object.obj.prop)
// 		return false;
// 	return true;
// }
// function Mode_props::getStartTime(%this) {
// 	return (MissionInfo.time ? MissionInfo.time : 300000);
// }
// function Mode_props::shouldDisablePowerup(%this, %object) {
// 	return !%this.shouldPickupItem(%object);
// }
// function Mode_props::shouldResetGem(%this, %object) {
// 	return false;
// }
// function Mode_props::shouldResetTime(%this, %object) {
// 	return false;
// }
// function Mode_props::shouldRestartOnOOB(%this, %object) {
// 	return false;
// }
// function Mode_props::shouldRespawnGems(%this, %object) {
// 	return false;
// }
// function Mode_props::shouldDisableCheckpoint(%this, %object) {
// 	return false;
// }
// function Mode_props::shouldAllowTTs(%this) {
// 	return false;
// }
// function Mode_props::timeMultiplier(%this) {
// 	return -1;
// }
// function Mode_props::onFoundGem(%this, %object) {
// 	%object.client.playPitchedSound("gotDiamond");
// }
// function Mode_props::onServerChat(%this, %object) {
// 	if (getWord(%object.message, 0) $= "/prop") {
// 		if (isObject(getWord(%object.message, 1))) {
// 			%object.client.setProp(getWord(%object.message, 1));
// 		} else {
// 			%object.client.sendChat("No such object.");
// 		}
// 		return true;
// 	}
// }
// function Mode_props::onTimeExpire(%this) {
// 	//backtrace();
// 	if ($Server::Hosting && !$MP::Restarting) {
// 		if ($Game::Seeking) {
// 			endGameSetup();
// 		} else {
// 			startSeeking();
// 		}
// 	}
// 	return false;
// }
// function Mode_props::onPlayerLeave(%this, %object) {
// 	if (isObject(%object.client.prop))
// 		%object.client.prop.delete();
// }
// function Mode_props::onMissionReset(%this) {
// 	chooseSeeker();
// 	startHiding();
// }
// function Mode_props::onGameState(%this, %object) {
// 	if (%object.state !$= "End" && %object.state !$= "Go" && %object.state !$= "Waiting") {
// 		cancel(%object.client.stateSchedule);
// 		%object.client.setGameState("Go");

// 		if (!$Game::Seeking) {
// 			%time = (MissionInfo.hideTime ? MissionInfo.hideTime : 30000);

// 			%object.client.stopTimer();
// 			%object.client.setTime(%time);
// 			%object.client.startTimer();

// 			//Don't let the seekers out if we haven't started yet!
// 			if (%object.client.seeker) {
// 				%object.client.player.setTransform(getField(%object.client.getCheckpointPos(), 0));
// 				%object.client.player.setMode(Start);
// 			}
// 		}
// 	}
// }

// //--------------------------------------------------------------------------

// function GameConnection::setSeeker(%this, %seeker) {
// 	%this.seeker = %seeker;
// 	if (%seeker) {
// 		%this.setNameTag("<color:ff6666>" @ %this.getDisplayName());
// 		%this.clearProp();
// 	} else {
// 		%this.setNameTag("");
// 		%this.setProp("GemItem");
// 	}
// }

// //--------------------------------------------------------------------------

// function chooseSeeker(%seeker) {
// 	//Fuck the RNG.
// 	setRandomSeed($Sim::Time);

// 	echo("Last seeker was" SPC $Seek::LastInitial.getUsername() SPC "so we\'ll pick someone new.");

// 	//Make everyone a hider except for one seeker
// 	%possible = 0;
// 	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
// 		%client = ClientGroup.getObject(%i);
// 		%client.setSeeker(false);

// 		//Don't let the same person go twice
// 		if ($Seek::LastInitial.getId() == %client.getId())
// 			continue;

// 		%clients[%possible] = %client;
// 		%possible ++;
// 	}

// 	//Pick them from ClientGroup at random
// 	if (!isObject(%seeker) && isObject($queuedSeeker)) {
// 		%seeker = $queuedSeeker;
// 		$queuedSeeker = 0;
// 	}

// 	if (!isObject(%seeker))
// 		%seeker = %clients[getRandom(0, %possible - 1)];

// 	$Seek::LastInitial = %seeker;
// 	%seeker.setSeeker(true);
// 	detectSeekerUpdate();
// }

// function queueSeeker(%client) {
// 	$queuedSeeker = %client;
// }

// function startHiding() {
// 	//Init hiding period
// 	$Game::Seeking = false;

// 	//Stop the seeker, let the hiders go
// 	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
// 		%client = ClientGroup.getObject(%i);
// 		%client.updateGhostDatablock();

// 		if (%client.seeker) {
// 			//The seeker is anchored to the start pad
// 			%client.addHelpLine("Prop hunt! Try to find which gems are fake!");
// 			%client.player.setTransform(getField(%client.getCheckpointPos(), 0));
// 			%client.player.setMode(Start);
// 		} else {
// 			%client.addHelpLine("You\'ve been disguised! Try to blend in.");
// 		}

// 		%time = (MissionInfo.hideTime ? MissionInfo.hideTime : 30000);
// 		%client.stopTimer();
// 		%client.setTime(%time);
// 		%client.startTimer();
// 	}
// }

// function startSeeking() {
// 	$Game::Seeking = true;
// 	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
// 		%client = ClientGroup.getObject(%i);
// 		//Hiders become slower, seekers become faster
// 		%client.updateGhostDatablock();
// 		%client.stopTimer();
// 		%client.setTime(MissionInfo.time ? MissionInfo.time : 300000);
// 		%client.startTimer();

// 		//Start both the seeker and the hiders
// 		if (%client.seeker) {
// 			%client.addHelpLine("Good luck!");
// 			%client.player.setMode(Normal);
// 		} else {
// 			%client.addHelpLine("Good luck!");
// 		}
// 	}
// }

// function GameConnection::clearProp(%this) {
// 	%this.prop.delete();
// 	%this.cloakProp(false);
// 	cancel(%this.propSch);
// 	cancel(%this.cloakSch);
// }

// function GameConnection::setProp(%this, %propdb) {
// 	if (isObject(%this.prop))
// 		%this.prop.delete();

// 	//Class is the datablock class sans "Data" (e.g. ItemData -> Item)
// 	%propClass = getSubStr(%propdb.getClassName(), 0, strlen(%propdb.getClassName()) - 4);

// 	//<client>.prop = new <Class>() {
// 	//   scale = "<Client Scale>";
// 	//   datablock = "<Datablock>";
// 	//   prop = "1";
// 	//};
// 	eval(%this @ ".prop = new " @ %propClass @ "() { scale = \"" @ %this.scale @ "\"; datablock = \"" @ %propdb @ "\"; prop = \"1\"; };");

// 	if (%propClass $= "Item") {
// 		//Need to set these otherwise you crash
// 		%this.prop.static = true;
// 		%this.prop.rotate = true;
// 		%this.prop.collideable = false;
// 	}

// 	MissionCleanup.add(%this.prop);
// 	%this.updateProp();

// 	commandToClient(%this, 'DetectProp', %this.scale, %propClass, %propdb);
// }

// function GameConnection::cloakProp(%this, %cloaked) {
// 	//No need to re-cloak
// 	if (%this.propCloaked == %cloaked)
// 		return;
// 	%this.propCloaked = %cloaked;

// 	//Hide ghost and cloak player
// 	%this.player.setCloaked(%cloaked);
// }

// function GameConnection::updateProp(%this) {
// 	cancel(%this.propSch);
// 	//Don't bother if we don't have a prop
// 	if (!isObject(%this.prop) || !isObject(%this.player))
// 		return;

// 	//If you stop moving, you'll disappear
// 	if (%this.speed < 0.01) {
// 		//Make sure to not schedule this twice
// 		if (!%this.propCloaked && !isEventPending(%this.cloakSch)) {
// 			//You have to be still for 3 seconds before it cloaks you, so that
// 			// you can't just lag for 100 ms.
// 			%this.cloakSch = %this.schedule(3000, "cloakProp", true);
// 		}
// 	} else {
// 		//Uncloak, however, is instant
// 		cancel(%this.cloakSch);
// 		%this.cloakProp(false);
// 	}

// 	//Set the item's position to the marble's position,
// 	// rotated to gravity, and dropped at the ground.
// 	%gravity = %this.player.getGravityRot();
// 	%trans = getWords(%this.player.getTransform(), 0, 2) SPC %gravity;
// 	//Flip because gravity is inverse
// 	%trans = MatrixMultiply(%trans, "0 0 0 1 0 0 3.14159");
// 	//Which direction do we cast in?
// 	%castDir = MatrixMulPoint("0 0 0" SPC %gravity, "0 0 2");
// 	//Cast
// 	%cast = ClientContainerRayCast(MatrixPos(%trans), VectorAdd(MatrixPos(%trans), %castDir), $TypeMasks::InteriorObjectType | $TypeMasks::StaticShapeObjectType);
// 	if (%cast) {
// 		//Move to cast pos
// 		%trans = getWords(%cast, 1, 3) SPC getWords(%trans, 3, 6);
// 	} else {
// 		//No cast, put it inside the marble with a radius of 0.2
// 		%add = MatrixMulPoint("0 0 0" SPC %gravity, "0 0 0.2");
// 		%trans = VectorAdd(MatrixPos(%trans), %add) SPC getWords(%trans, 3, 6);
// 	}
// 	//Calculate the zdrop if needed
// 	if (%this.prop.zdrop $= "") {
// 		%this.prop.setTransform("0 0 0 1 0 0 0");
// 		%this.prop.zdrop = VectorSub(%this.prop.getPosition(), getWords(%this.prop.getWorldBoxCenter(), 0, 1) SPC getWord(%this.prop.getWorldBox(), 2));
// 	}

// 	%trans = MatrixMultiply(%trans, %this.prop.zdrop SPC "1 0 0 0");
// 	%this.prop.setTransform(%trans);
// 	%this.propSch = %this.schedule(20, updateProp);
// }