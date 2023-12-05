// //------------------------------------------------------------------------------
// // Race Mode
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

// function Mode_race::onLoad(%this) {
// 	%this.registerCallback("shouldPickupGem");
// 	%this.registerCallback("shouldPickupPowerUp");
// 	%this.registerCallback("shouldDisablePowerup");
// 	%this.registerCallback("shouldUseClientPowerups");
// 	%this.registerCallback("shouldResetGem");
// 	%this.registerCallback("shouldRestartOnOOB");
// 	%this.registerCallback("shouldResetTime");
// 	%this.registerCallback("shouldRespawnGems");
// 	%this.registerCallback("onFoundGem");
// 	%this.registerCallback("shouldTotalGemCount");
// 	%this.registerCallback("updateWinner");
// 	%this.registerCallback("getQuickRespawnTimeout");
// 	echo("[Mode" SPC %this.name @ "]: Loaded!");
// }
// function Mode_race::shouldRespawnGems(%this, %object) {
// 	return true;
// }
// function Mode_race::shouldRestartOnOOB(%this, %object) {
// 	return false;
// }
// function Mode_race::shouldResetTime(%this, %object) {
// 	return false;
// }
// function Mode_race::shouldPickupGem(%this, %object) {
// 	commandToClient(%object.user.client, 'GemPickup', %object.obj.getSyncId());
// 	return false;
// }
// function Mode_race::shouldDisablePowerup(%this, %object) {
// 	//Stuff that is handled by the client
// 	return %object.this.coopClient;
// }
// function Mode_race::shouldPickupPowerup(%this, %object) {
// 	//Stuff that is handled by the client
// 	return !%object.this.coopClient;
// }
// function Mode_race::shouldUseClientPowerups(%this) {
// 	return true;
// }
// function Mode_race::shouldResetGem(%this, %object) {
// 	if (!isObject(%object.obj.staticgem)) {
// 		MissionCleanup.add(%object.obj.staticgem = new StaticShape() {
// 			position = %object.obj.position;
// 			rotation = %object.obj.rotation;
// 			scale = VectorSub(%object.obj.scale, "0.01 0.01 0.01");
// 			datablock = "StaticGem";
// 		});
// 		%object.obj.staticgem.setCloaked(1);
// 	}
// 	%object.obj.hide(false);
// 	return true;
// }
// function Mode_race::onFoundGem(%this, %object) {
// 	%remaining = $Game::gemCount - %object.client.getGemCount();
// 	if (%remaining <= 0) {
// 		messageClient(%object.client, 'MsgHaveAllGems', "\c0You have all the gems, head for the finish!");
// 		%object.client.playPitchedSound("gotalldiamonds");
// 	} else {
// 		if (%remaining == 1)
// 			%msg = "\c0You picked up a gem! Only one gem to go!";
// 		else
// 			%msg = "\c0You picked up a gem!  " @ %remaining @" gems to go!";

// 		messageClient(%object.client, 'MsgItemPickup', %msg, %remaining);
// 		%object.client.playPitchedSound("gotDiamond");
// 	}
// }
// function Mode_race::shouldTotalGemCount(%this) {
// 	return false;
// }
// function Mode_race::updateWinner(%this, %winners) {
// 	//In race mode, whoever has the most gems or finishes first wins
// 	if ($Game::GemCount == 0) {
// 		%winner = $Game::FinishClient;
// 		%winners.addEntry(%winner);
// 	} else {
// 		%winner = ClientGroup.getObject(0);
// 		%count = ClientGroup.getCount();

// 		//Who has the most gems?
// 		for (%i = 1; %i < %count; %i ++) {
// 			%client = ClientGroup.getObject(%i);
// 			if (%client.gemCount > %winner.gemCount)
// 				%winner = %client;
// 		}
// 		%winners.addEntry(%winner);
// 		//Check for other winners
// 		for (%i = 0; %i < %count; %i ++) {
// 			%client = ClientGroup.getObject(%i);
// 			if (%winner == %client)
// 				continue;
// 			if (%client.gemCount == %winner.gemCount)
// 				%winners.addEntry(%client);
// 		}
// 	}
// }
// function Mode_race::getQuickRespawnTimeout(%this, %object) {
// 	//Allow them to respawn instantly
// 	return 0;
// }


// // I wonder if frosty remembers this
// $sp2mp_level[0]  = "~/data/lbmissions_mbg/beginner/ThereandBackAgain.mis";
// $sp2mp_level[1]  = "~/data/lbmissions_mbg/beginner/GrandFinale.mis";
// $sp2mp_level[2]  = "~/data/lbmissions_mbg/intermediate/SkatePark.mis";
// $sp2mp_level[3]  = "~/data/lbmissions_mbg/intermediate/Half-Pipe.mis";
// $sp2mp_level[4]  = "~/data/lbmissions_mbg/intermediate/Gauntlet.mis";
// $sp2mp_level[5]  = "~/data/lbmissions_mbg/intermediate/UpwardSpiral.mis";
// $sp2mp_level[6]  = "~/data/lbmissions_mbg/advanced/ThrillRide.mis";
// $sp2mp_level[7]  = "~/data/lbmissions_mbg/advanced/FreewayCrossing.mis";
// $sp2mp_level[8]  = "~/data/lbmissions_mbg/advanced/SteppingStones.mis";
// $sp2mp_level[9]  = "~/data/lbmissions_mbg/advanced/ObstacleCourse.mis";
// $sp2mp_level[10] = "~/data/lbmissions_mbg/advanced/PointsoftheCompass.mis";
// $sp2mp_level[11] = "~/data/lbmissions_mbg/advanced/TubeTreasure.mis";
// $sp2mp_level[12] = "~/data/lbmissions_mbg/advanced/Plumber\'sPortal.mis";
// $sp2mp_level[13] = "~/data/lbmissions_mbg/advanced/SkiSlopes.mis";
// $sp2mp_level[14] = "~/data/lbmissions_mbg/advanced/Acrobat.mis";
// $sp2mp_level[15] = "~/data/lbmissions_mbg/advanced/Whirl.mis";
// $sp2mp_level[16] = "~/data/lbmissions_mbg/advanced/Mudslide.mis";
// $sp2mp_level[17] = "~/data/lbmissions_mbg/advanced/Scaffold.mis";
// $sp2mp_level[18] = "~/data/lbmissions_mbg/advanced/Airwalk.mis";
// $sp2mp_level[19] = "~/data/lbmissions_mbg/advanced/PinballWizard.mis";
// $sp2mp_level[20] = "~/data/lbmissions_mbg/advanced/EyeoftheStorm.mis";
// $sp2mp_level[21] = "~/data/lbmissions_mbg/advanced/Dive!.mis";
// $sp2mp_level[22] = "~/data/lbmissions_mbg/advanced/Tango.mis";
// $sp2mp_level[23] = "~/data/lbmissions_mbg/advanced/KingoftheMountain.mis";
// $sp2mp_level[24] = "~/data/lbmissions_mbp/beginner/KingoftheMarble.mis";
// $sp2mp_level[25] = "~/data/lbmissions_mbp/beginner/Battlecube.mis";
// $sp2mp_level[26] = "~/data/lbmissions_mbp/intermediate/LoopExits.mis";
// $sp2mp_level[27] = "~/data/lbmissions_mbp/intermediate/Technoropes.mis";
// $sp2mp_level[28] = "~/data/lbmissions_mbp/intermediate/PowerupPractice.mis";
// $sp2mp_level[29] = "~/data/lbmissions_mbp/intermediate/ByzantineHelix.mis";
// $sp2mp_level[30] = "~/data/lbmissions_mbp/intermediate/FloorClimb.mis";
// $sp2mp_level[31] = "~/data/lbmissions_mbp/intermediate/BumpyHighway.mis";
// $sp2mp_level[32] = "~/data/lbmissions_mbp/intermediate/MarbleAgilityCourse.mis";
// $sp2mp_level[33] = "~/data/lbmissions_mbp/intermediate/PuzzleOrdeal.mis";
// $sp2mp_level[34] = "~/data/lbmissions_mbp/intermediate/DraggedUp!.mis";
// $sp2mp_level[35] = "~/data/lbmissions_mbp/intermediate/Gym.mis";
// $sp2mp_level[36] = "~/data/lbmissions_mbp/intermediate/Divergence.mis";
// $sp2mp_level[37] = "~/data/lbmissions_mbp/intermediate/SkillZone.mis";
// $sp2mp_level[38] = "~/data/lbmissions_mbp/intermediate/BattlecubeRevisited.mis";
// $sp2mp_level[39] = "~/data/lbmissions_mbp/advanced/DiamondSeekingFun.mis";
// $sp2mp_level[40] = "~/data/lbmissions_mbp/advanced/GapAimer.mis";
// $sp2mp_level[41] = "~/data/lbmissions_mbp/advanced/Nukesweeper.mis";
// $sp2mp_level[42] = "~/data/lbmissions_mbp/advanced/Treachery.mis";
// $sp2mp_level[43] = "~/data/lbmissions_mbp/advanced/Swivel.mis";
// $sp2mp_level[44] = "~/data/lbmissions_mbp/advanced/NukeField.mis";
// $sp2mp_level[45] = "~/data/lbmissions_mbp/advanced/SlopeMadness.mis";
// $sp2mp_level[46] = "~/data/lbmissions_mbp/advanced/NeonTech.mis";
// $sp2mp_level[47] = "~/data/lbmissions_mbp/advanced/SlipUp.mis";
// $sp2mp_level[48] = "~/data/lbmissions_mbp/advanced/Michael\'sAdventureMBP.mis";
// $sp2mp_level[49] = "~/data/lbmissions_mbp/advanced/TreacherousPath.mis";
// $sp2mp_level[50] = "~/data/lbmissions_mbp/advanced/RollingtoEternity.mis";
// $sp2mp_level[51] = "~/data/lbmissions_mbp/advanced/RandomMayhem.mis";
// $sp2mp_level[52] = "~/data/lbmissions_mbp/advanced/FrictionalBattlecube.mis";
// $sp2mp_level[53] = "~/data/lbmissions_mbp/expert/Trigonometry.mis";
// $sp2mp_level[54] = "~/data/lbmissions_mbp/expert/NukesweeperRevisited.mis";
// $sp2mp_level[55] = "~/data/lbmissions_mbp/expert/DizzyingHeights.mis";
// $sp2mp_level[56] = "~/data/lbmissions_mbp/expert/BouncingFun.mis";
// $sp2mp_level[57] = "~/data/lbmissions_mbp/expert/Sandstorm.mis";
// $sp2mp_level[58] = "~/data/lbmissions_mbp/expert/PlatformMayhem.mis";
// $sp2mp_level[59] = "~/data/lbmissions_mbp/expert/UphillRacing.mis";
// $sp2mp_level[60] = "~/data/lbmissions_mbp/expert/ArchAcropolis.mis";
// $sp2mp_level[61] = "~/data/lbmissions_mbp/expert/Slowropes.mis";
// $sp2mp_level[62] = "~/data/lbmissions_mbp/expert/BattlecubeFinale.mis";
// $sp2mp_max = 63;

// function loadRandom() {
// 	%levels = 0;
// 	for (%i = 0; %i < $sp2mp_max; %i ++) {
// 		if ($MPPref::sp2mpPicks[%i]) {
// 			echo("Already picked" SPC %i);
// 			continue;
// 		}
// 		%level[%levels] = %i;
// 		%levels ++;
// 	}

// 	if (%levels == 0) {
// 		for (%i = 0; %i < $sp2mp_max; %i ++) {
// 			$MPPref::sp2mpPicks[%i] = false;
// 			%level[%levels] = %i;
// 			%levels ++;
// 		}
// 	}

// 	%num = getRandom(0, %levels - 1);

// 	echo("%num =" SPC %num);
// 	echo("%level[%num] =" SPC %level[%num]);
// 	%mission = expandFilename($sp2mp_level[%level[%num]]);

// 	serverSendChat("Trying to load " @ %mission);

// 	$MPPref::sp2mpPicks[%level[%num]] = 1;

// 	loadMission(%mission);
// }
