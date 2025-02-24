//-----------------------------------------------------------------------------
// Level Unlocking and Progression
//
// Copyright (c) 2016 The Platinum Team
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

//-----------------------------------------------------------------------------
// Helper functions for use in the unlock methods.
//-----------------------------------------------------------------------------

//Helper function to check if we can play a mission. Called from PlayMissionGui
function Unlock::canPlayMission(%mission) {
	if (marblelandUsesCustomCode(%mission) && lb()) {
		%mission.requirements = "Play the level Offline as it uses custom code.";
		return false;
	}

	%unlockFunc = %mission.unlockFunc;
	if (%unlockFunc $= "")
		return true;
	if ($Unlock::PlayAll) {
		return !lb();
	}
	return call(%unlockFunc, %mission);
}

//Helper function to check if we can display a mission. Called from PlayMissionGui
function Unlock::canDisplayMission(%mission) {
	%displayFunc = %mission.displayFunc;
	if (%displayFunc $= "")
		return true;
	if ($Unlock::DisplayAll) {
		return !lb();
	}
	return call(%displayFunc, %mission);
}

$Completion::Par           =   1; // BIT(1)
$Completion::Gold          =   2; // BIT(2)
$Completion::Platinum      =   4; // BIT(3)
$Completion::Ultimate      =   8; // BIT(4)
$Completion::Awesome       =  16; // BIT(5)
$Completion::EasterEgg     =  32; // BIT(6)
$Completion::GemMadnessAll =  64; // BIT(7)
$Completion::Quota100      = 128; // BIT(8)

//Get what parts of a mission you have completed
// @arg mission The mission to check, should be a MissionInfo ScriptObject (use
// getMissionInfo("path/to/file.mis") if you need one).
// @arg noSurrogate Don't use surrogate missions (aka fuck you vice versa)
function Unlock::getMissionCompletion(%mission, %noSurrogate) {
	%surrogate = Unlock::getSurrogateMission(%mission);
	if (isObject(%surrogate) && !%noSurrogate) {
		%mission = %surrogate;
	}
	getBestTimes(%mission);

	//<type> TAB <score> TAB <name>
	%default = ClientMode::callbackForMission(%mission, "getDefaultScore", $ScoreType::Time TAB 5999999 TAB "Matan W.");

	//If the best score is the default then there is no best score
	%top = $hs[0];
	if (%top $= %default) {
		//No score, no qualifications
		%flags = 0;

		//Non time-based
		%easter = (%mission.easterEgg ? $hs["eggFound"] : false);
		if (%easter)
			%flags |= $Completion::EasterEgg;

		return %flags;
	}
	return Unlock::getMissionScoreFlags(%mission, %top);
}

function Unlock::getMissionScoreFlags(%mission, %scoreInfo) {
	%default = ClientMode::callbackForMission(%mission, "getDefaultScore", $ScoreType::Time TAB 5999999 TAB "Matan W.");

	%scoreType = getField(%scoreInfo, 0);
	%score = getField(%scoreInfo, 1);

	%scores = %scoreType == $ScoreType::Score;

	//Challenge times / scores
	%parScore      = %mission.score;
	%goldScore     = %mission.goldScore;
	%platinumScore = %mission.platinumScore;
	%ultimateScore = %mission.ultimateScore;
	%awesomeScore  = %mission.awesomeScore;

	%parTime      = %mission.time;
	%goldTime     = %mission.goldTime;
	%platinumTime = %mission.platinumTime;
	%ultimateTime = %mission.ultimateTime;
	%awesomeTime  = %mission.awesomeTime;

	//MP missions use platinumScore[0] and platinumScore[1]
	if (mp()) {
		//See if we have more than one other player
		%vs = !$Server::Hosting //Not host, so there must be someone else who is
		      || (!$Server::_Dedicated && ClientGroup.getCount() > 1) //Hosting local, another player
		      || ($Server::_Dedicated && isObject(ScoreList.player[1])); //Hosting dedicated, hack but should work

		%index = (%vs ? 0 : 1);
		%platinumScore = (%mission.platinumScore[%index] ? %mission.platinumScore[%index] : %platinumScore);
		%ultimateScore = (%mission.ultimateScore[%index] ? %mission.ultimateScore[%index] : %ultimateScore);
		%awesomeScore  = (%mission.awesomeScore[%index]  ? %mission.awesomeScore[%index]  : %awesomeScore);
	} else if (%mission.platinumScore[1] !$= "") { // Transfer the [1] score to singleplayer
		%platinumScore = %mission.platinumScore[1];
		%ultimateScore = %mission.ultimateScore[1];
		%awesomeScore = %mission.awesomeScore[1];
	}

	//Non time-based
	%easter = (%mission.easterEgg ? $hs["eggFound"] : false);
	%quota100 = ($hs["quota100"] !$= "");
	%gemmadnessAll = (stripos(%mission.gameMode, "GemMadness") != -1) && !%scores;

	//See which we qualify for
	%flags = 0;

	if (%scores) {
		//We have par if we beat it, or if no par exists and we have a top
		if (%parScore && (%score >= %parScore) || (!%parScore && %score != getField(%default, 1)))
			%flags |= $Completion::Par;

		if (%goldScore      && (%score >= %goldScore))
			%flags |= $Completion::Gold;
		if (%platinumScore  && (%score >= %platinumScore))
			%flags |= $Completion::Platinum;
		if (%ultimateScore  && (%score >= %ultimateScore))
			%flags |= $Completion::Ultimate;
		if (%awesomeScore   && (%score >= %awesomeScore))
			%flags |= $Completion::Awesome;
	} else {
		//We have par if we beat it, or if no par exists and we have a top
		if (%parTime && (%score < %parTime) || (!%parTime && %score != getField(%default, 1)))
			%flags |= $Completion::Par;

		if (%goldTime      && (%score < %goldTime))
			%flags |= $Completion::Gold;
		if (%platinumTime  && (%score < %platinumTime))
			%flags |= $Completion::Platinum;
		if (%ultimateTime  && (%score < %ultimateTime))
			%flags |= $Completion::Ultimate;
		if (%awesomeTime   && (%score < %awesomeTime))
			%flags |= $Completion::Awesome;

		//Because MBP uses gold times for platinum times... what
		%defined = "Gold Platinum Ultra PlatinumQuest LBCustom";
		%game = ((findWord(%defined, $CurrentGame) == -1) ? resolveMissionModification(%mission) : $CurrentGame);
		if (%goldTime && %game $= "platinum" && (%flags & $Completion::Gold)) {
			%flags &= ~$Completion::Gold;
			%flags |= $Completion::Platinum;
		}

		//GemMadness is messy with ATs and stuff
		if (%gemmadnessAll) {
			//You've beaten all that there are scores for.
			if (%goldScore)
				%flags |= $Completion::Gold;
			if (%platinumScore)
				%flags |= $Completion::Platinum;
			if (%ultimateScore)
				%flags |= $Completion::Ultimate;
			if (%awesomeScore)
				%flags |= $Completion::Awesome;
		}
	}

	//These don't depend on the type of score
	if (%easter)
		%flags |= $Completion::EasterEgg;
	if (%quota100)
		%flags |= $Completion::Quota100;
	if (%gemmadnessAll)
		%flags |= $Completion::GemMadnessAll;

	return %flags;
}

function Unlock::hasBeatMissionPar(%mission) {
	return Unlock::getMissionCompletion(%mission) & $Completion::Par;
}

//Get which mission stands in for another mission. Literally only used for VV.
// Fuck you, Matan, for making me have to do this.
function Unlock::getSurrogateMission(%mission) {
	if (isScriptFile(%mission.surrogate)) {
		return getMissionInfo(%mission.surrogate);
	}
	return "";
}

//Get the total game completion of the current game. Value is returned as a
// proportion (0.0 -> 1.0). Does not count custom/bonus levels.
// @arg game Optional game to check, default is the current game
function Unlock::getGameCompletion(%game) {
	//Default argument values
	if (%game $= "")
		%game = $CurrentGame;

	%complete = $Unlock::GameCompletion[%game];
	%total = $Unlock::GameMissionTotal[%game];

	return %complete / %total;
}

//Get the total number of levels completed in the current game.
// Does not count custom/bonus levels.
// @arg game Optional game to check, default is the current game
function Unlock::getGameCompletionCount(%game) {
	//Default argument values
	if (%game $= "")
		%game = $CurrentGame;

	%complete = $Unlock::GameCompletion[%game];

	return %complete;
}

//Get the total number of levels completed in the current game passing the
// given flags.
// Does not count custom levels.
// @arg game Optional game to check, default is the current game
// @arg flags Flags that all missions need to pass
function Unlock::getGameCompletionCountFlags(%game, %flags) {
	//Default argument values
	if (%game $= "")
		%game = $CurrentGame;

	%complete = $Unlock::GameCompletionFlags[%game, %flags];
	if (%complete !$= "") {
		return %complete;
	}
	%complete = 0;

	%difficulties = PlayMissionGui.getDifficultyList(%game);

	for (%i = 0; %i < getFieldCount(%difficulties); %i ++) {
		%difficulty = getField(%difficulties, %i);

		//Don't count custom levels as required
		if (%difficulty $= "Custom")
			continue;

		%dir = "platinum/data/" @ $Files::MissionsFolder[%game] @ "/" @ %difficulty @ "/*";
		for (%file = findFirstMission(%dir); %file !$= ""; %file = findNextMission(%dir)) {
			//Get the file's info
			%info = getMissionInfo(%file);

			//Don't count missions we can't see
			if (!Unlock::canDisplayMission(%info)) {
				continue;
			}

			//Check if we've beat it
			if ((Unlock::getMissionCompletion(%info) & %flags) == %flags) {
				%complete ++;
			}
		}
	}
	return %complete;
}

//Get the total number of levels completed in the current difficulty passing the
// given flags.
// Does not count custom levels.
// @arg game Optional game to check, default is the current game
// @arg flags Flags that all missions need to pass
function Unlock::getDifficultyCompletionCountFlags(%difficulty, %game, %flags) {
	//Default argument values
	if (%game $= "")
		%game = $CurrentGame;
	if (%difficulty $= "")
		%difficulty = $MissionType;

	%complete = $Unlock::DifficultyCompletionFlags[%game, %difficulty, %flags];
	if (%complete !$= "") {
		return %complete;
	}
	%complete = 0;

	%dir = "platinum/data/" @ $Files::MissionsFolder[%game] @ "/" @ %difficulty @ "/*";
	for (%file = findFirstMission(%dir); %file !$= ""; %file = findNextMission(%dir)) {
		//Get the file's info
		%info = getMissionInfo(%file);

		//Don't count missions we can't see
		if (!Unlock::canDisplayMission(%info)) {
			continue;
		}

		//Check if we've beat it
		if ((Unlock::getMissionCompletion(%info) & %flags) == %flags) {
			%complete ++;
		}
	}

	return %complete;
}

//Get the total time of levels completed in the current game.
// Does not count custom levels.
// @arg game Optional game to check, default is the current game
function Unlock::getGameCompletionTime(%game) {
	//Default argument values
	if (%game $= "")
		%game = $CurrentGame;

	%time = $Unlock::GameMissionTotalTime[%game];

	return %time;
}

//Get the total number of levels in the game Does not count custom/bonus levels.
// @arg game Optional game to check, default is the current game
function Unlock::getGameLevelCount(%game) {
	//Default argument values
	if (%game $= "")
		%game = $CurrentGame;

	%total = $Unlock::GameMissionTotal[%game];

	return %total;
}

//Get the total completion of a given difficulty. Value is returned as a
// proportion (0.0 -> 1.0).
// @arg difficulty Optional difficulty to check, default is the current difficulty.
// @arg game Optional game to check, default is the current game
function Unlock::getDifficultyCompletion(%difficulty, %game) {
	//Default argument values
	if (%difficulty $= "")
		%difficulty = $MissionType;
	if (%game $= "")
		%game = $CurrentGame;

	%complete = $Unlock::DifficultyCompletion[%game, %difficulty];
	%total = $Unlock::DifficultyMissionTotal[%game, %difficulty];

	return %complete / %total;
}

//Get the total number of levels completed in a given difficulty.
// @arg difficulty Optional difficulty to check, default is the current difficulty.
// @arg game Optional game to check, default is the current game
function Unlock::getDifficultyCompletionCount(%difficulty, %game) {
	//Default argument values
	if (%difficulty $= "")
		%difficulty = $MissionType;
	if (%game $= "")
		%game = $CurrentGame;

	%complete = $Unlock::DifficultyCompletion[%game, %difficulty];

	return %complete;
}

//Get the total number of levels in a given difficulty.
// @arg difficulty Optional difficulty to check, default is the current difficulty.
// @arg game Optional game to check, default is the current game
function Unlock::getDifficultyLevelCount(%difficulty, %game) {
	//Default argument values
	if (%difficulty $= "")
		%difficulty = $MissionType;
	if (%game $= "")
		%game = $CurrentGame;

	%total = $Unlock::DifficultyMissionTotal[%game, %difficulty];

	return %total;
}

//Get the total number of levels unlocked in a given game.
// @arg game Optional game to check, default is the current game
function Unlock::getGameUnlockedLevelCount(%game) {
	//Default argument values
	if (%game $= "")
		%game = $CurrentGame;

	%total = $Unlock::GameUnlockedTotal[%game];

	return %total;
}

//Get the total number of levels unlocked in a given difficulty.
// @arg difficulty Optional difficulty to check, default is the current difficulty.
// @arg game Optional game to check, default is the current game
function Unlock::getDifficultyUnlockedLevelCount(%difficulty, %game) {
	//Default argument values
	if (%difficulty $= "")
		%difficulty = $MissionType;
	if (%game $= "")
		%game = $CurrentGame;

	%total = $Unlock::DifficultyUnlockedTotal[%game, %difficulty];

	return %total;
}

function Unlock::getGameEasterEggCount(%game) {
	//Default argument values
	if (%game $= "")
		%game = $CurrentGame;

	%total = $Unlock::GameTotalEggs[%game];

	return %total;
}

function Unlock::getDifficultyEasterEggCount(%difficulty, %game) {
	//Default argument values
	if (%difficulty $= "")
		%difficulty = $MissionType;
	if (%game $= "")
		%game = $CurrentGame;

	%total = $Unlock::DifficultyTotalEggs[%game, %difficulty];

	return %total;
}

function Unlock::updateCaches(%firstLoad) {
	%ml = PlayMissionGui.ml;

	deleteVariables("$Unlock::*");

	//Don't do this on servers, you'll try to download all their missions and it'll be bad
	if (mp() && !($Server::Hosting && !$Server::_Dedicated)) {
		return;
	}

	%games = %ml.getGameList();
	%gameCount = getRecordCount(%games);
	for (%i = 0; %i < %gameCount; %i ++) {
		%gameInfo = getRecord(%games, %i);
		%game = getField(%gameInfo, 0);

		if (%game $= "Custom")
			continue;

		$Unlock::GameMissionTotalTime[%game] = 0;
		$Unlock::GameTotalEggs[%game] = 0;
		$Unlock::GameUnlockedTotal[%game] = 0;
		$Unlock::GameCompletion[%game] = 0;
		$Unlock::GameCompletionFlags[%game, $Completion::Gold] = 0;
		$Unlock::GameMissionTotal[%game] = 0;
		$Unlock::GameCompletionFlags[%game, $Completion::Platinum] = 0;
		$Unlock::GameCompletionFlags[%game, $Completion::Ultimate] = 0;
		$Unlock::GameCompletionFlags[%game, $Completion::Awesome] = 0;
		$Unlock::GameCompletionFlags[%game, $Completion::EasterEgg] = 0;
		$Unlock::GameCompletionFlags[%game, $Completion::GemMadnessAll] = 0;
		$Unlock::GameCompletionFlags[%game, $Completion::Quota100] = 0;

		%count = ModeInfoGroup.getCount();
		for (%mi = 0; %mi < %count; %mi ++) {
			%mode = ModeInfoGroup.getObject(%mi);
			$Unlock::GameGamemodeMissionTotal[%game, %mode.identifier] = 0;
		}

		%difficulties = %ml.getDifficultyList(%game);
		%difficultyCount = getRecordCount(%difficulties);
		for (%j = 0; %j < %difficultyCount; %j ++) {
			%difficultyInfo = getRecord(%difficulties, %j);
			%difficulty = getField(%difficultyInfo, 0);

			if (%difficulty $= "Custom")
				continue;

			$Unlock::DifficultyMissionTotalTime[%game, %difficulty] = 0;
			$Unlock::DifficultyTotalEggs[%game, %difficulty] = 0;
			$Unlock::DifficultyUnlockedTotal[%game, %difficulty] = 0;
			$Unlock::DifficultyCompletion[%game, %difficulty] = 0;
			$Unlock::DifficultyMissionTotal[%game, %difficulty] = 0;
			$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Gold] = 0;
			$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Platinum] = 0;
			$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Ultimate] = 0;
			$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Awesome] = 0;
			$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::EasterEgg] = 0;
			$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::GemMadnessAll] = 0;
			$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Quota100] = 0;

			%count = ModeInfoGroup.getCount();
			for (%mi = 0; %mi < %count; %mi ++) {
				%mode = ModeInfoGroup.getObject(%mi);
				$Unlock::DifficultyGamemodeMissionTotal[%game, %difficulty, %mode.identifier] = 0;
			}

			//Now update the everything
			%list = %ml.getMissionList(%game, %difficulty);
			if (!isObject(%list)) {
				%ml.buildMissionList(%game, %difficulty);
			}

			%missionCount = %list.getSize();
			for (%k = 0; %k < %missionCount; %k ++) {
				//Get the file's info
				%info = %list.getEntry(%k);
				if (%firstLoad && %info.partial) {
					getMissionInfo(%info.file);
				}

				//Don't count missions we can't see
				if (!Unlock::canDisplayMission(%info)) {
					%info.canDisplay = false;
					continue;
				}

				%canPlay = Unlock::canPlayMission(%info);
				%completion = Unlock::getMissionCompletion(%info);
				%egg = %info.easterEgg;

				%info.canPlay = %canPlay;
				%info.completion = %completion;

				//Top time for that mission
				if (%completion & $Completion::Par) {
					%top = $pref::highScores[%info.file, 0];
					if (getField(%top, 0) $= $ScoreType::Score) {
						%time = %info.time;
					} else {
						%time = getField(%top, 1);
					}
				} else {
					%time = 0;
				}

				//Lots and lots of log
				//echo("Mission " @ %info.name @ " "  @ %game @ " " @ %difficulty @ " can play: " @ %canPlay @ " completion: " @ %completion @ " egg: " @ %egg @ " time: " @ %time);

				$Unlock::GameMissionTotal[%game] ++;
				$Unlock::DifficultyMissionTotal[%game, %difficulty] ++;

				%modes = resolveMissionGameModes(%info, %info.gameMode);
				%count = getWordCount(%modes);
				for (%mi = 0; %mi < %count; %mi ++) {
					%mode = getWord(%modes, %mi);
					$Unlock::GameGamemodeMissionTotal[%game, %mode] ++;
					$Unlock::DifficultyGamemodeMissionTotal[%game, %difficulty, %mode] ++;
				}

				$Unlock::GameMissionTotalTime[%game] = add64_int($Unlock::GameMissionTotalTime[%game], %time);
				$Unlock::DifficultyMissionTotalTime[%game, %difficulty] = add64_int($Unlock::DifficultyMissionTotalTime[%game, %difficulty], %time);

				if (%egg) {
					$Unlock::GameTotalEggs[%game] ++;
					$Unlock::DifficultyTotalEggs[%game, %difficulty] ++;

					if (%completion & $Completion::EasterEgg) {
						$Unlock::GameCompletionFlags[%game, $Completion::EasterEgg] ++;
						$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::EasterEgg] ++;
					}
				}

				if (%canPlay) {
					$Unlock::GameUnlockedTotal[%game] ++;
					$Unlock::DifficultyUnlockedTotal[%game, %difficulty] ++;
				}
				if (%completion & $Completion::Par) {
					$Unlock::GameCompletion[%game] ++;
					$Unlock::DifficultyCompletion[%game, %difficulty] ++;
				}
				if (%completion & $Completion::Gold) {
					$Unlock::GameCompletionFlags[%game, $Completion::Gold] ++;
					$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Gold] ++;
				}
				if (%completion & $Completion::Platinum) {
					$Unlock::GameCompletionFlags[%game, $Completion::Platinum] ++;
					$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Platinum] ++;
				}
				if (%completion & $Completion::Ultimate) {
					$Unlock::GameCompletionFlags[%game, $Completion::Ultimate] ++;
					$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Ultimate] ++;
				}
				if (%completion & $Completion::Awesome) {
					$Unlock::GameCompletionFlags[%game, $Completion::Awesome] ++;
					$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Awesome] ++;
				}
				if (%completion & $Completion::GemMadnessAll) {
					$Unlock::GameCompletionFlags[%game, $Completion::GemMadnessAll] ++;
					$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::GemMadnessAll] ++;
				}
				if (%completion & $Completion::Quota100) {
					$Unlock::GameCompletionFlags[%game, $Completion::Quota100] ++;
					$Unlock::DifficultyCompletionFlags[%game, %difficulty, $Completion::Quota100] ++;
				}
			}
			//Update progress if we're doing that
			//GameCount - 1 because "Custom" game we don't care about
			if (%firstLoad) {
				LoadingGui.setProgress("Loading Levels...", %i + ((%j + 1) / %difficultyCount), %gameCount - 1, true);
			}
		}
		if (%firstLoad) {
			LoadingGui.setProgress("Loading Levels...", %i + 1, %gameCount - 1, true);
		}
	}
}
