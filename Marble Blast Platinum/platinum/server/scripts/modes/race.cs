//------------------------------------------------------------------------------
// Race Mode
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

function Mode_race::onLoad(%this) {
	%this.registerCallback("onMissionLoaded");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onClientLeaveGame");
	%this.registerCallback("onStartPlaying");
	%this.registerCallback("onEnterPad");
	%this.registerCallback("onEndGameSetup");
	%this.registerCallback("onOutOfBounds");
	%this.registerCallback("shouldDisableBlastShockwave");
	%this.registerCallback("shouldUseUltraMarble");
	%this.registerCallback("getUltraMarbleSize");
	%this.registerCallback("getMaxSpectators");
	%this.registerCallback("canFinish");
	%this.registerCallback("getFinishMessage");
	%this.registerCallback("onGameState");
	%this.registerCallback("shouldPickupGem");
	%this.registerCallback("shouldPickupTimeItem");
	%this.registerCallback("shouldPickupPowerUp");
	%this.registerCallback("shouldDisablePowerup");
	%this.registerCallback("shouldUseClientPowerups");
	%this.registerCallback("shouldResetGem");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("shouldTotalGemCount");
	%this.registerCallback("updateWinner");
	%this.registerCallback("getScoreType");
	%this.registerCallback("getFinalScore");
	%this.registerCallback("getQuickRespawnTimeout");
	%this.registerCallback("shouldUseIndividualClocks");
	%this.registerCallback("onFrameAdvance");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onRespawnOnCheckpoint");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_race::shouldUseIndividualClocks(%this) {
	return true;
}
function Mode_race::shouldRespawnGems(%this, %object) {
	return true;
}
function Mode_race::shouldRestartOnOOB(%this, %object) {
	return false;
}
function Mode_race::shouldResetTime(%this, %object) {
	return false;
}
function Mode_race::shouldPickupGem(%this, %object) {
	commandToClient(%object.user.client, 'GemPickup', %object.obj.getSyncId());
	return false;
}
function Mode_race::shouldPickupTimeItem(%this, %object) {
	//Same idea as gems: leave the item live for everyone else, just tell
	//this one client to hide it locally
	commandToClient(%object.user.client, 'TimeItemPickup', %object.obj.getSyncId());
	return false;
}
function Mode_race::shouldDisablePowerup(%this, %object) {
	//Stuff that is handled by the client
	return %object.this.coopClient;
}
function Mode_race::shouldPickupPowerup(%this, %object) {
	//Stuff that is handled by the client
	return !%object.this.coopClient;
}
function Mode_race::shouldUseClientPowerups(%this) {
	return true;
}
function Mode_race::shouldResetGem(%this, %object) {
	if (!isObject(%object.obj.staticgem)) {
		MissionCleanup.add(%object.obj.staticgem = new StaticShape() {
			position = %object.obj.position;
			rotation = %object.obj.rotation;
			scale = VectorSub(%object.obj.scale, "0.01 0.01 0.01");
			datablock = "StaticGem";
		});
		%object.obj.staticgem.setCloaked(1);
	}
	%object.obj.hide(false);
	return true;
}
//PQ Quota levels only require MissionInfo.GemQuota gems to finish, not every
//gem in the level - carry that rule over from Mode_quota so those levels
//keep their original objective instead of race's usual "collect everything".
function Mode_race::canFinish(%this, %object) {
	if (MissionInfo.GemQuota !$= "")
		return !($Game::GemCount && %object.client.getGemCount() < MissionInfo.GemQuota);
	return !($Game::GemCount && %object.client.getGemCount() < $Game::GemCount);
}
function Mode_race::getFinishMessage(%this, %object) {
	if (MissionInfo.GemQuota $= "")
		return ""; //Not a quota level - fall back to the default message entirely
	if ($Game::GemCount && %object.client.getGemCount() < MissionInfo.GemQuota)
		return "You may not finish without reaching the gem quota!";
	return ""; //Quota met - fall through to the default "Congratulations!" message
}
//Drives the same client-side quota UI (PlayGui's main counter showing
//quota as the denominator, plus the small "/total" GemsQuota label) that
//Mode_quota normally uses - it's a plain global command, not routed
//through the mode system, so race just needs to send it too. This also
//doubles as the live standings' gem denominator, since it reads the same
//PlayGui.maxGems field.
function Mode_race::onGameState(%this, %object) {
	if (MissionInfo.GemQuota !$= "")
		commandToClient(%object.client, 'SetGemQuota', $Game::GemCount, MissionInfo.GemQuota);
}
function Mode_race::onFoundGem(%this, %object) {
	%required = (MissionInfo.GemQuota !$= "") ? MissionInfo.GemQuota : $Game::GemCount;
	%remaining = %required - %object.client.getGemCount();
	if (%remaining <= 0) {
		messageClient(%object.client, 'MsgHaveAllGems', "\c0You have all the gems, head for the finish!");
		%object.client.playPitchedSound("gotalldiamonds");
	} else {
		if (%remaining == 1)
			%msg = "\c0You picked up a gem! Only one gem to go!";
		else
			%msg = "\c0You picked up a gem!  " @ %remaining @" gems to go!";

		messageClient(%object.client, 'MsgItemPickup', %msg, %remaining);
		%object.client.playPitchedSound("gotDiamond");
	}

	//Record which checkpoint was active when this specific client picked up
	//this specific gem - see restoreGemPickupState below for why race needs
	//its own record of this instead of relying on the engine's shared
	//per-object _pickUp/_pickUpCheckpoint fields (those can't represent one
	//gem being independently owned by several different clients at once,
	//which is exactly what race does).
	%object.client._raceGemCheckpoint[%object.gem] = %object.client.curCheckpointNum;
	%object.client._raceGemList[%object.client._raceGemListCount] = %object.gem;
	%object.client._raceGemListCount ++;
}

//Race deliberately never hides a gem's server object once it's picked up
//(see shouldPickupGem above) - each client is just told to hide it locally,
//so every other racer can still independently collect the very same gem.
//That collides with GameConnection::respawnObjects() (checkpoint.cs), which
//every respawn calls (via restoreCheckpointGemCount's sibling cleanup) to
//enforce the checkpoint gem-count rollback: it unconditionally clears this
//client's ENTIRE gem pickup dedup history, not just the gems actually being
//rolled back. In every other mode that's harmless, because an already-
//picked-up gem is hidden (and so untouchable) server-side; in race it isn't,
//so a gem picked up long before the checkpoint being returned to becomes
//walkable and re-countable again - on top of whichever real gems are still
//to find, gemCount can end up higher than the level's actual total (and a
//player can reach a quota/finish without ever finding some of the real
//gems). Restore the correct per-gem dedup state right after: still-spent
//(gemCount only rolls back to the checkpoint's saved value, not to zero) for
//anything picked up at or before this checkpoint, pickupable again only for
//what was genuinely picked up after it.
function Mode_race::onRespawnPlayer(%this, %object) {
	%this.restoreGemPickupState(%object.client);
}
function Mode_race::onRespawnOnCheckpoint(%this, %object) {
	%this.restoreGemPickupState(%object.client);
}
function Mode_race::restoreGemPickupState(%this, %client) {
	if (MissionInfo.pqSourceMode $= "GemMadness")
		return; //Gems are banked forever here - never rolled back to begin with

	%count = %client._raceGemListCount;
	for (%i = 0; %i < %count; %i ++) {
		%gem = %client._raceGemList[%i];
		if (!isObject(%gem))
			continue;
		%client.gemPickup[%gem] = (%client._raceGemCheckpoint[%gem] < %client.curCheckpointNum);
	}
}
function Mode_race::shouldTotalGemCount(%this) {
	return false;
}
function Mode_race::onMissionLoaded(%this) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.resetRaceStats();
	}
}
function Mode_race::onMissionReset(%this) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.resetRaceStats();
	}
	if (MissionInfo.GemQuota !$= "")
		commandToAll('SetGemQuota', $Game::GemCount, MissionInfo.GemQuota);

	%this.roundStartSimTime = getSimTime();
	%this.gemMadnessTimeExpired = false;
}
function Mode_race::onClientLeaveGame(%this, %object) {
	//The base GameConnection::onClientLeaveGame already broadcast one last
	//(stale) score update before this callback ever runs - a disconnecting
	//client who hadn't finished yet would otherwise sit on everyone else's
	//standings forever with whatever score/time they happened to have (often
	//0, sorting them into first place). Mark them DNF and push a corrected
	//update so they settle to the bottom instead.
	%client = %object.client;
	if (isObject(%client) && !%client.raceFinished) {
		%client.raceDNF = true;
		updateSingleScore(%client);
	}

	%count = ClientGroup.getCount();
	if (%count <= 1) {
		%winner = %this.getRaceWinner();
		if (%winner !$= "")
			$Game::FinishClient = %winner;
		else if (%count == 1)
			$Game::FinishClient = ClientGroup.getObject(0);
		endGameSetup();
	}
}
function Mode_race::onEnterPad(%this, %object) {
	%client = %object.client;
	if (%client.raceFinished)
		return true;

	if (!%client.canFinish()) {
		%client.playPitchedSound("missinggems");
		%message = %client.getFinishMessage();
		if (%message !$= "")
			messageClient(%client, 'MsgMissingGems', %message);
		return true;
	}

	%client.raceFinished = true;
	%client.raceFinishTime = sub64_int(%client.clockTime, %client.raceStartTime);
	%client.player.setMode(Victory);
	serverCmdSetSpectate(%client, true);
	if (%client.spectating)
		%client.setSpectating(true);

	serverSendChat(%client.getDisplayName() SPC "finished in" SPC formatTime(%client.raceFinishTime) @ "!");

	%this.checkRaceShouldEnd();

	return true;
}
// Individual clocks mean a still-racing player can be sitting on a better
// (lower) time than someone who already finished, thanks to time travels.
// So once only one player is left racing, don't end the match the instant
// they'd otherwise be the last one - keep it going until their live clock
// passes the worst finish time already on the board, since until then they
// could still improve on SOME position, not just take the win. Checked both
// right after any finish (onEnterPad) and every frame (onFrameAdvance),
// since the last player crossing that time threshold isn't itself an event
// - it just happens as their clock ticks up.
function Mode_race::onFrameAdvance(%this, %delta) {
	if ($Game::Finished)
		return;

	//PQ Gem Madness levels have a real time limit - unlike normal race
	//levels, which just wait for everyone to finish. Once it runs out, end
	//the round; whoever hasn't finished yet gets scored by gem count
	//instead of DNF (see onEndGameSetup/getFinalScore), matching how the
	//original Gem Madness mode falls back when time expires.
	if (!%this.gemMadnessTimeExpired && MissionInfo.pqSourceMode $= "GemMadness" && MissionInfo.time !$= ""
			&& (getSimTime() - %this.roundStartSimTime) >= MissionInfo.time) {
		%this.gemMadnessTimeExpired = true;
		$Game::FinishClient = %this.getRaceWinner();
		endGameSetup();
		return;
	}

	%this.checkRaceShouldEnd();
}
function Mode_race::checkRaceShouldEnd(%this) {
	if ($Game::Finished)
		return;

	%count = ClientGroup.getCount();
	if (%count == 0)
		return;

	%finished = 0;
	%active = 0;
	%worstTime = -1;
	%remaining = "";
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		//A client still spectating and never having finished isn't actually
		//racing (e.g. a late joiner who hasn't chosen to play yet) - don't
		//let their stale clock count them as "the one player left" and end
		//the race out from under them before they've even started
		if (%client.spectating && !%client.raceFinished)
			continue;
		%active ++;
		if (%client.raceFinished) {
			%finished ++;
			if (%client.raceFinishTime > %worstTime)
				%worstTime = %client.raceFinishTime;
		} else {
			%remaining = %client;
		}
	}

	if (%active == 0)
		return;

	if (%finished >= %active) {
		//Everyone still racing is done
		$Game::FinishClient = %this.getRaceWinner();
		endGameSetup();
	} else if (%finished > 0 && %finished == (%active - 1) && isObject(%remaining) && %remaining.clockTime > %worstTime) {
		//One player left, and their live time has passed even the worst
		//finish time already on the board - there's no position left for
		//them to improve on, so it's safe to end now instead of making
		//everyone wait for them to finish
		$Game::FinishClient = %this.getRaceWinner();
		endGameSetup();
	}
}
function Mode_race::getRaceWinner(%this) {
	%winner = "";
	%bestTime = 999999999;
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.raceFinished)
			continue;
		if (%client.raceFinishTime < %bestTime) {
			%winner = %client;
			%bestTime = %client.raceFinishTime;
		}
	}
	return %winner;
}
function Mode_race::updateWinner(%this, %winners) {
	%winner = %this.getRaceWinner();
	if (%winner !$= "") {
		%winners.addEntry(%winner);
	}
}
function Mode_race::getScoreType(%this) {
	return $ScoreType::Time;
}
function Mode_race::getFinalScore(%this, %object) {
	if (%object.client.raceFinished)
		return $ScoreType::Time TAB %object.client.raceFinishTime;
	if (%object.client.raceScoredByGems)
		//PQ Gem Madness time ran out before they finished - score them by
		//gem count instead, like the original mode's own time-expiry
		//fallback. Everything here shares one $ScoreType::Time value space
		//(the standings/end-game UI only support one score type per round),
		//so this sits below the DNF sentinel but above any real finish time
		//(capped well under 6000000 by the clock's own max), and more gems
		//sorts better (lower) within that band.
		return $ScoreType::Time TAB (10000000 - %object.client.getGemCount());
	if (%object.client.raceDNF)
		//Sorts after every real finish time (which is capped well below this
		//by the clock's own 5999999 max), without colliding with the
		//999999999 sentinel the client-side sort loops seed themselves with
		return $ScoreType::Time TAB 99999999;
	if (%object.client.raceStartTime $= "")
		//Hasn't actually started racing yet (still spectating, e.g. a late
		//joiner) - show a neutral 00:00.000 instead of a blank/undefined clock
		return $ScoreType::Time TAB 0;
	return $ScoreType::Time TAB %object.client.clockTime;
}
function Mode_race::getQuickRespawnTimeout(%this, %object) {
	//Allow them to respawn instantly
	return 0;
}
function GameConnection::resetRaceStats(%this) {
	%this.raceFinished = false;
	%this.raceFinishTime = -1;
	%this.raceDNF = false;
	%this.raceScoredByGems = false;
	%this.racePlace = 0;
	%this.clockTime = 0;
	%this.bonusTime = 0;
	%this.totalBonus = 0;
	%this.raceStartTime = %this.clockTime;
	%this._raceGemListCount = 0;
}

//The game only ends once someone still racing can no longer affect the
//standings (see checkRaceShouldEnd), which can leave players who never
//crossed the finish line. Mark them DNF here, before scores go out, instead
//of falling back to getFinalScore's live-clockTime branch (which reads as
//"finished a fraction of a second behind the last real finisher").
function Mode_race::onEndGameSetup(%this) {
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (!%client.raceFinished) {
			if (%this.gemMadnessTimeExpired)
				%client.raceScoredByGems = true;
			else
				%client.raceDNF = true;
		}
	}

	%this.announceFinalStandings();
}

//Re-announce every finish (in rank order, DNFs last) once the race is
//actually over, instead of relying on the scattered "X finished in Y!"
//messages sent as each player crossed the line.
function Mode_race::announceFinalStandings(%this) {
	%count = ClientGroup.getCount();
	if (%count == 0)
		return;

	serverSendChat("Final Standings:");

	%used = Array(RaceStandingsUsedArray);
	%rank = 0;
	for (%i = 0; %i < %count; %i ++) {
		%bestTime = 999999999;
		%bestClient = -1;
		for (%j = 0; %j < %count; %j ++) {
			%client = ClientGroup.getObject(%j);
			if (%used.containsEntry(%client))
				continue;
			//Must be strictly less than %bestTime's own seed value below, or a
			//DNF never wins the "< %bestTime" check once it's the only
			//candidate left and silently drops out of the recap
			%time = %client.raceDNF ? 99999999 : (%client.raceScoredByGems ? (10000000 - %client.getGemCount()) : %client.raceFinishTime);
			if (%time < %bestTime) {
				%bestTime = %time;
				%bestClient = %client;
			}
		}
		if (!isObject(%bestClient))
			break;

		%used.addEntry(%bestClient);
		%rank ++;

		if (%bestClient.raceDNF)
			serverSendChat(%rank @ ". " @ %bestClient.getDisplayName() @ " (DNF)");
		else if (%bestClient.raceScoredByGems)
			serverSendChat(%rank @ ". " @ %bestClient.getDisplayName() @ " (" @ %bestClient.getGemCount() @ "/" @ $Game::GemCount @ " gems)");
		else
			serverSendChat(%rank @ ". " @ %bestClient.getDisplayName() @ " (" @ formatTime(%bestClient.raceFinishTime) @ ")");
	}
	%used.delete();
}

//Flash the offending player's name red on everyone's live standings for a
//moment when they go OOB.
function Mode_race::onOutOfBounds(%this, %object) {
	commandToAll('RaceOOBFlash', %object.client.index);
}

//A late joiner isn't in ClientGroup yet when onMissionLoaded/onMissionReset
//run resetRaceStats on everyone, so their clock never gets initialized.
//Catch them the moment they actually start playing (exiting spectator
//mode) instead - guarded so it only fires once, and never re-fires for a
//player who briefly re-spectates mid-race or has already finished.
function Mode_race::onStartPlaying(%this, %object) {
	%client = %object.client;
	if (%client.raceStartTime $= "" && !%client.raceFinished)
		%client.resetRaceStats();
}

//Blast's self-launch is still fine in a race (whether it's even available at
//all is decided per-level, client-side - see ClientMode_race::shouldEnableBlast),
//but the knockback shockwave it sends to nearby players doesn't belong in a
//race, even on Ultra levels where blast itself is on. Marble Melee Primer is
//the one exception - it's the Ultra tutorial level for the shockwave itself
//("shoves other marbles away"), so leave it on there.
function Mode_race::shouldDisableBlastShockwave(%this) {
	return fileBase($Server::MissionFile) !$= "mptrain_ultra";
}

//The default "someone has to actually play" spectator cap (getRealPlayerCount() - 1)
//doesn't fit race - everyone joins into spectator mode by design and picks their own
//moment to start, including a single player testing solo. Left uncapped, that default
//was throwing the "too many people spectating" popup in perfectly normal situations.
//No spectating behavior itself is meant to change here, just remove that cap.
function Mode_race::getMaxSpectators(%this) {
	return 9999;
}

//Mode_null already does exactly this by default, but race never registered
//either callback, so it was silently falling back to the regular (smaller)
//marble even on Ultra levels where MissionInfo.useUltraMarble is set. The
//size difference alone accounts for the "different physics" feel - there's
//no separate Ultra physics tuning, just a bigger collision radius.
function Mode_race::shouldUseUltraMarble(%this, %object) {
	return !!MissionInfo.useUltraMarble;
}
function Mode_race::getUltraMarbleSize(%this, %object) {
	return %object.client.player.getDataBlock().ultraScale;
}


// I wonder if frosty remembers this
$sp2mp_level[0]  = "~/data/lbmissions_mbg/beginner/ThereandBackAgain.mis";
$sp2mp_level[1]  = "~/data/lbmissions_mbg/beginner/GrandFinale.mis";
$sp2mp_level[2]  = "~/data/lbmissions_mbg/intermediate/SkatePark.mis";
$sp2mp_level[3]  = "~/data/lbmissions_mbg/intermediate/Half-Pipe.mis";
$sp2mp_level[4]  = "~/data/lbmissions_mbg/intermediate/Gauntlet.mis";
$sp2mp_level[5]  = "~/data/lbmissions_mbg/intermediate/UpwardSpiral.mis";
$sp2mp_level[6]  = "~/data/lbmissions_mbg/advanced/ThrillRide.mis";
$sp2mp_level[7]  = "~/data/lbmissions_mbg/advanced/FreewayCrossing.mis";
$sp2mp_level[8]  = "~/data/lbmissions_mbg/advanced/SteppingStones.mis";
$sp2mp_level[9]  = "~/data/lbmissions_mbg/advanced/ObstacleCourse.mis";
$sp2mp_level[10] = "~/data/lbmissions_mbg/advanced/PointsoftheCompass.mis";
$sp2mp_level[11] = "~/data/lbmissions_mbg/advanced/TubeTreasure.mis";
$sp2mp_level[12] = "~/data/lbmissions_mbg/advanced/Plumber\'sPortal.mis";
$sp2mp_level[13] = "~/data/lbmissions_mbg/advanced/SkiSlopes.mis";
$sp2mp_level[14] = "~/data/lbmissions_mbg/advanced/Acrobat.mis";
$sp2mp_level[15] = "~/data/lbmissions_mbg/advanced/Whirl.mis";
$sp2mp_level[16] = "~/data/lbmissions_mbg/advanced/Mudslide.mis";
$sp2mp_level[17] = "~/data/lbmissions_mbg/advanced/Scaffold.mis";
$sp2mp_level[18] = "~/data/lbmissions_mbg/advanced/Airwalk.mis";
$sp2mp_level[19] = "~/data/lbmissions_mbg/advanced/PinballWizard.mis";
$sp2mp_level[20] = "~/data/lbmissions_mbg/advanced/EyeoftheStorm.mis";
$sp2mp_level[21] = "~/data/lbmissions_mbg/advanced/Dive!.mis";
$sp2mp_level[22] = "~/data/lbmissions_mbg/advanced/Tango.mis";
$sp2mp_level[23] = "~/data/lbmissions_mbg/advanced/KingoftheMountain.mis";
$sp2mp_level[24] = "~/data/lbmissions_mbp/beginner/KingoftheMarble.mis";
$sp2mp_level[25] = "~/data/lbmissions_mbp/beginner/Battlecube.mis";
$sp2mp_level[26] = "~/data/lbmissions_mbp/intermediate/LoopExits.mis";
$sp2mp_level[27] = "~/data/lbmissions_mbp/intermediate/Technoropes.mis";
$sp2mp_level[28] = "~/data/lbmissions_mbp/intermediate/PowerupPractice.mis";
$sp2mp_level[29] = "~/data/lbmissions_mbp/intermediate/ByzantineHelix.mis";
$sp2mp_level[30] = "~/data/lbmissions_mbp/intermediate/FloorClimb.mis";
$sp2mp_level[31] = "~/data/lbmissions_mbp/intermediate/BumpyHighway.mis";
$sp2mp_level[32] = "~/data/lbmissions_mbp/intermediate/MarbleAgilityCourse.mis";
$sp2mp_level[33] = "~/data/lbmissions_mbp/intermediate/PuzzleOrdeal.mis";
$sp2mp_level[34] = "~/data/lbmissions_mbp/intermediate/DraggedUp!.mis";
$sp2mp_level[35] = "~/data/lbmissions_mbp/intermediate/Gym.mis";
$sp2mp_level[36] = "~/data/lbmissions_mbp/intermediate/Divergence.mis";
$sp2mp_level[37] = "~/data/lbmissions_mbp/intermediate/SkillZone.mis";
$sp2mp_level[38] = "~/data/lbmissions_mbp/intermediate/BattlecubeRevisited.mis";
$sp2mp_level[39] = "~/data/lbmissions_mbp/advanced/DiamondSeekingFun.mis";
$sp2mp_level[40] = "~/data/lbmissions_mbp/advanced/GapAimer.mis";
$sp2mp_level[41] = "~/data/lbmissions_mbp/advanced/Nukesweeper.mis";
$sp2mp_level[42] = "~/data/lbmissions_mbp/advanced/Treachery.mis";
$sp2mp_level[43] = "~/data/lbmissions_mbp/advanced/Swivel.mis";
$sp2mp_level[44] = "~/data/lbmissions_mbp/advanced/NukeField.mis";
$sp2mp_level[45] = "~/data/lbmissions_mbp/advanced/SlopeMadness.mis";
$sp2mp_level[46] = "~/data/lbmissions_mbp/advanced/NeonTech.mis";
$sp2mp_level[47] = "~/data/lbmissions_mbp/advanced/SlipUp.mis";
$sp2mp_level[48] = "~/data/lbmissions_mbp/advanced/Michael\'sAdventureMBP.mis";
$sp2mp_level[49] = "~/data/lbmissions_mbp/advanced/TreacherousPath.mis";
$sp2mp_level[50] = "~/data/lbmissions_mbp/advanced/RollingtoEternity.mis";
$sp2mp_level[51] = "~/data/lbmissions_mbp/advanced/RandomMayhem.mis";
$sp2mp_level[52] = "~/data/lbmissions_mbp/advanced/FrictionalBattlecube.mis";
$sp2mp_level[53] = "~/data/lbmissions_mbp/expert/Trigonometry.mis";
$sp2mp_level[54] = "~/data/lbmissions_mbp/expert/NukesweeperRevisited.mis";
$sp2mp_level[55] = "~/data/lbmissions_mbp/expert/DizzyingHeights.mis";
$sp2mp_level[56] = "~/data/lbmissions_mbp/expert/BouncingFun.mis";
$sp2mp_level[57] = "~/data/lbmissions_mbp/expert/Sandstorm.mis";
$sp2mp_level[58] = "~/data/lbmissions_mbp/expert/PlatformMayhem.mis";
$sp2mp_level[59] = "~/data/lbmissions_mbp/expert/UphillRacing.mis";
$sp2mp_level[60] = "~/data/lbmissions_mbp/expert/ArchAcropolis.mis";
$sp2mp_level[61] = "~/data/lbmissions_mbp/expert/Slowropes.mis";
$sp2mp_level[62] = "~/data/lbmissions_mbp/expert/BattlecubeFinale.mis";
$sp2mp_max = 63;

function loadRandom() {
	%levels = 0;
	for (%i = 0; %i < $sp2mp_max; %i ++) {
		if ($MPPref::sp2mpPicks[%i]) {
			echo("Already picked" SPC %i);
			continue;
		}
		%level[%levels] = %i;
		%levels ++;
	}

	if (%levels == 0) {
		for (%i = 0; %i < $sp2mp_max; %i ++) {
			$MPPref::sp2mpPicks[%i] = false;
			%level[%levels] = %i;
			%levels ++;
		}
	}

	%num = getRandom(0, %levels - 1);

	echo("%num =" SPC %num);
	echo("%level[%num] =" SPC %level[%num]);
	%mission = expandFilename($sp2mp_level[%level[%num]]);

	serverSendChat("Trying to load " @ %mission);

	$MPPref::sp2mpPicks[%level[%num]] = 1;

	loadMission(%mission);
}
