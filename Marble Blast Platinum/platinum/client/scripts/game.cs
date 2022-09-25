//-----------------------------------------------------------------------------
// Portions Copyright (c) 2021 The Platinum Team
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
// Torque Game Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

// Additional code for Marble Blast Platinum by Matan Weissman and Alex Swanson

// How many highscores should be shown?
$Game::HighscoreCount = 5;

$ScoreType::Time = 0;
$ScoreType::Score = 1;

//--------------------------------------------------------------------------------
// Game start / end events sent from the server
//--------------------------------------------------------------------------------

function clientCmdGameStart() {
	$Client::Loaded = false;
	$Client::Loading = false;
	$Client::NextMission = "";
	$Game::FinalScore = "";

	//Cache this because it is unset before clientCmdGameEnd is called.
	$Client::PlayingDemo = $playingDemo;

	if (!$Record::Started && !$playingDemo && !$Game::Menu) {
		if ($Game::Record) {
			$Record::NeedSave = true;
			recordMissionReplay();
		} else if (lb() && !mp()) {
			//Matan calls this the "anti-Xenox" system. I think I just spent two
			// weeks writing something to take down one guy.
			// (2 years later): This system is incredibly useful and I am less salty now
			recordMissionReplay("platinum/data/recordings/lb-latest.rrec");
		}
	}

	updateGameDiscordStatus();
	$Client::GameRunning = true;
}

// Called when you respawn
function clientCmdGameRespawn() {
}

function updateGameDiscordStatus() {
	if ($Game::Menu) {
		// Handled by the UI
	} else if ($playingDemo) {
		setDiscordStatus("Watching a Replay");
	} else {
		%info = getMissionInfo($Client::MissionFile);
		%name = %info.name;
		if (mp()) {
			if ($SpectateMode) {
				setDiscordStatus("Spectating", %name);
			} else {
				setDiscordStatus("In a Server", %name);
			}
		} else {
			setDiscordStatus("Single Player", %name);
		}
	}
}

function getBestTimes(%info) {
	%file = (%info.file $= "" ? $Client::MissionFile : %info.file);

	//Surrogate mission because fucking VV. Only for the eggs though because times would be weird otherwise
	%surrogate = %file;
	if (isFile(%info.surrogate)) {
		%surrogate = %info.surrogate;
	}
	%default = ClientMode::callbackForMission(%info, "getDefaultScore", $ScoreType::Time TAB 5999999 TAB "Matan W.");

	%isMarbleland = marblelandIsMission(%file);

	if (lb() && !%isMarbleland) {
		if (%info.id $= "") {
			%info = getMissionInfo(%info.file, true);
		}
		if (%info.id !$= "") {
			//Online, get our online scores
			%missionId = %info.id;

			//This is slow, so only do it if we really have to
			%surrogateId = %missionId;
			if (isFile(%info.surrogate)) {
				%surrogateId = getMissionInfo(%surrogate, true).id;
			}

			if (%missionId $= "") {
				//Level has no id, has no scores or something
				devecho("Mission has no id for getting scores. Using offline scores instead.");
			} else {
				if (%info.gameMode $= "challenge") {
					%scores = PlayMissionGui.personalScoreCache[%missionId, "challenge"].scores;
				} else
					%scores = PlayMissionGui.personalScoreCache[%missionId].scores;

				//Find out how many scores we can get from the online cache
				%count = 0;
				if (!isObject(%scores)) {
					%scoreCache = 0;
					if (%info.gameMode $= "challenge") {
						%scoreCache = PlayMissionGui.personalScoreListCache.challenge;
					} else {
						%scoreCache = PlayMissionGui.personalScoreListCache;
					}

					if (isObject(%scoreCache)) {
						devecho("Didn't find best times but have cache for mission id " @ %missionId);
						//Grab the best time we have
						%best = %scoreCache.getFieldValue(%missionId);
						if (isObject(%best)) {
							%count = 1;
							%type = (%best.score_type $= "time" ? $ScoreType::Time : $ScoreType::Score);
							$hs[0] = %type TAB %best.score TAB LBResolveName($LB::Username, true);
						}
					} else {
						devecho("Didn't find best times and no cache for mission id " @ %missionId);
					}
				} else {
					//devecho("Found best times for mission id " @ %missionId);
					%count = min(%scores.getSize(), $Game::HighscoreCount);

					//And load them into $hs
					for (%i = 0; %i < %count; %i ++) {
						%score = %scores.getEntry(%i);

						%typeStr = %score.score_type;
						switch$ (%typeStr) {
						case "time":
							%type = $ScoreType::Time;
						case "score":
							%type = $ScoreType::Score;
						}

						//Mimic how $hs works
						$hs[%i] = %type TAB %score.score TAB LBResolveName($LB::Username, true);
					}
				}
				//Fill the rest with empty
				for (%i = %count; %i < $Game::HighscoreCount; %i ++) {
					$hs[%i] = %default;
				}

				//Get our egg time
				if (isObject(PlayMissionGui.onlineEasterEggCache)) {
					$hs["egg"] = PlayMissionGui.onlineEasterEggCache.getFieldValue(%surrogateId);
				} else {
					$hs["egg"] = "";
				}
				$hs["eggFound"] = true;
				if ($hs["egg"] $= "") {
					$hs["egg"] = 5999999; //Default for no egg score
					$hs["eggFound"] = false;
				}

				//And quota 100
				if (isObject(PlayMissionGui.personalScoreListCache.quota100)) {
					$hs["quota100"] = PlayMissionGui.personalScoreListCache.quota100.getFieldValue(%surrogateId).score;
				} else {
					//Nothing
					$hs["quota100"] = "";
				}
				return true;
			}
		}
	}
	//Offline, use the offline scores
	%mis = strreplace(%file, "lbmission", "mission");
	%surrogateMis = strreplace(%surrogate, "lbmission", "mission");

	//Load the highscores from prefs, and fill in default ones with blanks if they don't exist
	for (%i = 0; %i < $Game::HighscoreCount; %i++) {
		$hs[%i] = $pref::highScores[%mis, %i];
		if ($hs[%i] $= "") {
			$hs[%i] = %default;
		}
		//Because the default switched from 98:59.999 to 99:59.990 to 99:59.999
		// Blame torque's integer support
		if (getField($hs[%i], 1) $= "Matan W." && (getField($hs[%i], 0) $= "5998999" || getField($hs[%i], 0) $= "5999990" || getField($hs[%i], 0) == %info.time)) {
			$hs[%i] = %default;
		}
		//We're now using 3-field scores
		if (getFieldCount($hs[%i]) == 2) {
			$hs[%i] = getField(%default, 0) TAB $hs[%i];
		}
	}

	//Nest|Easter Egg times
	$hs["egg"] = $pref::EasterEggTime[%surrogateMis];
	$hs["eggFound"] = true;
	if ($hs["egg"] $= "") {
		$hs["egg"] = 5999999; //Default for no egg score
		$hs["eggFound"] = false;
	}

	$hs["quota100"] = $pref::Quota100[%surrogateMis];
	return true;
}

//Check if %a is better than %b
// Returns true if %a is better
function compareScores(%a, %b) {
	if (%b $= "") {
		return true;
	}
	if (%a $= "") {
		return false;
	}
	%aType  = getField(%a, 0);
	%aScore = getField(%a, 1);
	%bType  = getField(%b, 0);
	%bScore = getField(%b, 1);

	if (%aType == $ScoreType::Time && %bType == $ScoreType::Score) {
		//This a time in a list of scores, aka you got all the gems in gem madness
		return true;
	} else if (%aType == $ScoreType::Score && %bType == $ScoreType::Time) {
		//Inverse of the above
		return false;
	} else {
		//Same type
		if (%aType == $ScoreType::Time) {
			//Time, lesser is better
			return %aScore < %bScore;
		} else {
			//Score, greater is better
			return %aScore > %bScore;
		}
	}

	//Can never get here
	return false;
}

//Add a best score locally to prefs.cs
// %scoreInfo is %type TAB %score TAB %name
// Return value is the index of the score or "" if worse than all bests
function addBestScore(%missionFile, %scoreInfo) {
	if ($Game::isMode["challenge"]) {
		%missionFile = strReplace(%missionFile, "platinum/data", "challenge/data");
	}
	getBestTimes(getMissionInfo(%missionFile));

	%index = "";
	for (%i = 0; %i < $Game::HighscoreCount; %i++) {
		%saved = $hs[%i];

		//If better then insert the new one
		if (compareScores(%scoreInfo, %saved)) {
			for (%j = $Game::HighscoreCount - 1; %j > %i; %j--) {
				$hs[%j] = $hs[%j - 1];
			}
			$hs[%i] = %scoreInfo;
			%index = %i;
			break;
		}
	}

	for (%i = 0; %i < $Game::HighscoreCount; %i++) {
		$pref::highScores[%missionFile, %i] = $hs[%i];
	}

	return %index;
}

// Record current score to local and online leaderboards
function recordScore() {
	if ($Game::isMode["challenge"]) {
		$Client::MissionFile = strReplace($Client::MissionFile, "platinum/data", "challenge/data");
	}

	%isMarbleland = marblelandIsMission($Client::MissionFile);

	getBestTimes(getMissionInfo($Client::MissionFile));

	%score = $Game::FinalScore;
	%flags = Unlock::getMissionScoreFlags(MissionInfo, %score);
	%scoreInfo = %score TAB $pref::highScoreName;

	$highScoreIndex = "";
	if (!$Cheats::Activated && !$Editor::Opened) {
		$highScoreIndex = addBestScore($Client::MissionFile, %scoreInfo);
		if (lb()  && !$Game::isMode["challenge"] && !%isMarbleland) {
			//See if we should add it to offline too
			%offMisFile = strReplace($Client::MissionFile, "/lbmissions", "/missions");
			if (isScriptFile(%offMisFile)) {
				addBestScore(%offMisFile, %scoreInfo);
			}
		}

		//Awesome time noise
		%awesomeMessage = false;
		if (%flags & $Completion::Awesome) {
			if (!$pref::ShowAwesomeHints) {
				%awesomeMessage = true;
			}

			$pref::LevelAwesomes[$Server::MissionFile] ++;
			$pref::ShowAwesomeHints = true;
			if (%awesomeMessage) {
				alxPlay(GotAwesomeSfx);
			} else if ($pref::LevelAwesomes[$Server::MissionFile] > 4 &&
				getField(%score, 0) == $ScoreType::Time &&
				MissionInfo.awesomeTime && getField(%score, 1) < (MissionInfo.awesomeTime * 0.9) &&
				getRandom() > 0.75) {
				//Super awesome or some bs
				alxPlay(GotAwesomeSfx);
				alxPlay(GotAwesomeAwesomeSfx);
			} else if ($pref::LevelAwesomes[$Server::MissionFile] > 4 &&
				getField(%score, 0) == $ScoreType::Score &&
				MissionInfo.awesomeScore && getField(%score, 1) > (MissionInfo.awesomeScore * 1.15) &&
				getRandom() > 0.75) {
				//Super awesome or some bs
				alxPlay(GotAwesomeSfx);
				alxPlay(GotAwesomeAwesomeSfx);
			} else {
				//Regular awesome
				alxPlay(GotAwesomeSfx);
			}
		}
	}

	if (lb() && !%isMarbleland) {
		// Set rating to "Submitting..."
		if ($Game::isMode["challenge"]) {
			$LB::RatingPending = false;
			statsRecordChallengeScore(PlayMissionGui.getMissionInfo());
		} else {
			$LB::RatingPending = true;
			statsRecordScore(PlayMissionGui.getMissionInfo());
		}
	}

	// Marbleland mission LB
	if (!$Cheats::Activated && !$Editor::Opened && %isMarbleland) {
		// Set rating to "Submitting..."
		$LB::RatingPending = true;

		%marblelandScoreName = "Unnamed Player";
		if ($LB::Username !$= "") {
			if ($LB::DisplayName !$= "")
				%marblelandScoreName = $LB::DisplayName;
			else
				%marblelandScoreName = $LB::Username;
		}
		else if ($pref::highScoreName !$= "")
			%marblelandScoreName = $pref::highScoreName;

		MarblelandSubmit($Server::MissionFile, %marblelandScoreName, getField(%score, 1), getField(%score, 0));
	}

	if (lb()) {
		if ($highScoreIndex !$= "") {
			//Hack: update the top score as quick as we can
			%scores = PlayMissionGui.personalScoreCache[PlayMissionGui.getMissionInfo().id].scores;
			if ($Game::isMode["challenge"]) {
				%scores = PlayMissionGui.personalScoreCache[PlayMissionGui.getMissionInfo().id, "challenge"].scores;
			}
			if (%scores.getSize() == 0) {
				JSONGroup.add(%dummy = new ScriptObject() {
					score_type = getField(%score, 0) == $ScoreType::Time ? "time" : "score";
					score = getField(%score, 1);
				});
				%scores.addEntry(%dummy);
			} else {
				for (%i = min(%scores.getSize(), $Game::HighscoreCount - 1); %i > $highScoreIndex; %i--) {
					if (%scores.getSize() == %i) {
						JSONGroup.add(%dummy = new ScriptObject() {
							score_type = %scores.getEntry(%i).score_type;
							score = %scores.getEntry(%i).score;
						});
						%scores.addEntry(%dummy);
					}
					%scores.getEntry(%i).score_type = %scores.getEntry(%i - 1).score_type;
					%scores.getEntry(%i).score = %scores.getEntry(%i - 1).score;
				}
				if (%scores.getSize() == $highScoreIndex) {
					JSONGroup.add(%dummy = new ScriptObject() {
						score_type = getField(%score, 0) == $ScoreType::Time ? "time" : "score";
						score = getField(%score, 1);
					});
					%scores.addEntry(%dummy);
				} else {
					%scores.getEntry($highScoreIndex).score_type = getField(%score, 0) == $ScoreType::Time ? "time" : "score";
					%scores.getEntry($highScoreIndex).score = getField(%score, 1);
				}
			}
		}
	}
}

function clientCmdGameEnd() {
	if ($Client::PlayingDemo) {
		return;
	}

	if ($Record::Recording) {
		//Give 3 sec at the end screen before we finish the rec
		cancel($recordFinish);
		$recordFinish = schedule(3000, 0, recordFinish);
	}

	if (ClientMode::callback("showEndGame", false)) {
		return;
	}

	// Multiplayer has its own things
	if (mp()) {
		RootGui.pushDialog(MPEndGameDlg);
		return;
	}

	recordScore();

	if (isObject($Menu::Queue)) {
		menuEndQueueMission();
		return;
	}

	RootGui.pushDialog(EndGameDlg);
	PlayGui.positionMessageHud();
	//Hack: why isn't this being called
	EndGameDlg.onWake();
	EndGameDlg.schedule(50, onWake);
	if ($highScoreIndex !$= "") {
		// modify highscore system to support 5
		if ($highScoreIndex == 0)
			%msgIn = "";
		else if ($highScoreIndex == 1)
			%msgIn = " second";
		else if ($highScoreIndex == 2)
			%msgIn = " third";
		else if ($highScoreIndex == 3)
			%msgIn = " fourth";
		else
			%msgIn = " fifth";

		if ($pref::DisableHighScoreNamePopup) {
			EnterNameDlg.setVisible(false);
			EnterNameEdit.makeFirstResponder(false);
		} else {
			if (ControllerGui.isJoystick()) {
				ControllerGui.selectControl(%awesomeMessage ? EnterNameAwesomeClose : EnterNameAcceptButton);
			}

			// fix the system for "nil" entries.
			EnterNameAcceptButton.setActive($pref::HighScoreName !$= "");

			EnterNameText.setText("<just:center><bold:32>Enter your name!");
			EnterNameDlg.setVisible(true);
			$highScoreAccept = false;
			EnterNameEdit.setSelectionRange(0, 100000);
			EnterNameEdit.makeFirstResponder(true);

			//Callout for awesome times
			EnterNameBox.setVisible(!%awesomeMessage);
			EnterNameAwesomeBox.setVisible(%awesomeMessage);
			EnterNameAwesomeText.setText("<just:center><bold:30>You beat an <spush><color:FF4444>Awesome " @ (%useLess ? "Time" : "Score") @ "<spop>!" NL
				"<font:19>Every PlatinumQuest level has an Awesome Time or Score" SPC
				"that requires plenty of skill to beat. They are based on the staff's best," SPC
				"aimed for the hardcore players, and made to be pretty difficult." @
				"<font:Arial:9>\n\n<font:19><just:center>Are you prepared for the <spush><color:200000>awesome<spop> quest awaiting you?");
			highScoreNameChanged();
		}

	} else {
		EnterNameDlg.setVisible(false);
		EnterNameEdit.makeFirstResponder(false);

		//If we don't show scores, we can't accept score so make sure to check achievements anyway
		if (PlayMissionGui.ml.shouldCheckAchievements($CurrentGame)) {
			checkEndgameAchievements();
		}
	}

	reformatGameEndText();
}

function highScoreNameAccept() {
	EnterNameDlg.setVisible(false);
	EnterNameEdit.makeFirstResponder(false);

	if (ControllerGui.isJoystick()) {
		ControllerGui.selectControl(EG_Replay);
	}
	$highScoreAccept = true;
	// Save prefs
	savePrefs();

	if (PlayMissionGui.ml.shouldCheckAchievements($CurrentGame)) {
		checkEndgameAchievements();
	}
}

function highScoreNameChanged() {
	if ($highScoreAccept)
		return;

	// prevent nil name entries
	// you need to check it before onWake!
	if ($pref::highScoreName $= "")
		EnterNameAcceptButton.setActive(false);
	else
		EnterNameAcceptButton.setActive(true);

	if ($Game::isMode["challenge"]) {
		$Server::MissionFile = strReplace($Server::MissionFile, "platinum/data", "challenge/data");
	}

	%score = $Game::FinalScore;
	if ($highScoreIndex !$= "") {
		%name = ($pref::highScoreName $= "" ? " " : $pref::highScoreName);
		$pref::highScores[$Server::MissionFile, $highScoreIndex] = %score @ "\t" @ %name;
	}
	reformatGameEndText();
}

// Fuck Natural Logarithms, I'm making my own handy mathematical functions here.
function mLog10(%n) {
	return (mLog(%n) / mLog(10));
}
// I'm not using this function but I made it because...I don't know why.
function mLogb(%n,%b) {
	return (mLog(%n) / mLog(%b));
}

function reformatGameEndText() {
	// Clear everything first
	EG_Result.setText("");
	EG_Description.setText("");

	// -------------------------------------------------------------------------------
	// Final Time
	// -------------------------------------------------------------------------------

	if ($Game::isMode["challenge"]) {
		$Client::MissionFile = strReplace($Client::MissionFile, "platinum/data", "challenge/data");
	}

	%info = getMissionInfo($Client::MissionFile);

	//Do this here because this screws with $hs
	%showAwesome = ((Unlock::getMissionCompletion(%info) & $Completion::Awesome) == $Completion::Awesome) || $Unlock::DisplayAll;
	%showRecord = %showAwesome || $LBPref::ShowRecords;

	getBestTimes(%info);

	%scoreVals = $Game::FinalScore;
	%flags = Unlock::getMissionScoreFlags(%info, %scoreVals);

	%type = getField(%scoreVals, 0);
	%score = getField(%scoreVals, 1);
	%name = (%type $= $ScoreType::Time) ? "Time" : "Score";

	%color = getScoreFormatting(%scoreVals, %info);
	%formatted = %color @ (%type == $ScoreType::Time ? formatTime(%score) : formatScore(%score));

	EG_TitleText.setText("<bold:48><color:000000><shadow:1:1><shadowcolor:777777>Your " @ %name @ ":");
	EG_Result.setText("<bold:48><color:000000><shadow:1:1><shadowcolor:777777><just:right>" @ %formatted);

	// -------------------------------------------------------------------------------
	// Decision on which Qualification message to display
	// -------------------------------------------------------------------------------
	%text = "<color:000000><shadow:1:1><shadowcolor:7777777F><just:center><bold:30>";

	//Times, in order of precedence:
	// Staff/Awesome time
	// Ultimate Time
	// Platinum Time (PQ Only)
	// Gold/Platinum Time (MBP/Custom)
	// Par/Qualify Time
	// Failed to qualify

	if ($Cheats::Activated) {
		%text = %text @ "Nice Cheats!";
	} else if ($Editor::Opened) {
		%text = %text @ "<color:00cc00><shadow:1:1><shadowcolor:0000007f>Level Editor Opened";
	} else {
		if (%flags & $Completion::Awesome) {
			%text = %text @ "Who's Awesome? <color:FF3333><shadowcolor:AA22227F>You're<color:000000><shadowcolor:7777777F> Awesome!";
		} else if (%flags & $Completion::Ultimate) {
			%text = %text @ "You beat the <color:FFCC33><shadowcolor:0000007F>Ultimate<color:000000><shadowcolor:7777777F> " @ %name @ "!";
		} else if (%flags & $Completion::Platinum) {
			%text = %text @ "You beat the <color:CCCCCC><shadowcolor:0000007F>Platinum<color:000000><shadowcolor:7777777F> " @ %name @ "!";
		} else if (%flags & $Completion::Gold) {
			%text = %text @ "You beat the <color:FFEE11><shadowcolor:0000007F>Gold<color:000000><shadowcolor:7777777F> " @ %name @ "!";
		} else if (%flags & $Completion::Par) {
			//No score, you just qualified
			if ($CurrentGame $= "Gold") {
				%text = %text @ "You've Qualified!";
			} else {
				%text = %text @ "You beat the Par " @ %name @ "!";
			}
		} else {
			if ($CurrentGame $= "Gold") {
				%text = %text @ "<color:f55555><shadowcolor:800000>You didn\'t pass the Qualify " @ %name @ "!";
			} else {
				%text = %text @ "<color:f55555><shadowcolor:800000>You didn\'t pass the Par " @ %name @ "!";
			}
		}
	}

	// -------------------------------------------------------------------------------
	// Time stats from Mission
	// -------------------------------------------------------------------------------

	%text = %text @ "<font:Arial:9>\n\n<tab:208><color:000000><font:26><shadowcolor:7777777F><just:left>";

	//Challenge times
	%goldTimeLabel     = (%info.goldTime     !$= "" ? formatTime(%info.goldTime)     : "N/A");
	%platinumTimeLabel = (%info.platinumTime !$= "" ? formatTime(%info.platinumTime) : "N/A");
	%ultimateTimeLabel = (%info.ultimateTime !$= "" ? formatTime(%info.ultimateTime) : "N/A");
	%awesomeTimeLabel  = (%info.awesomeTime  !$= "" ? formatTime(%info.awesomeTime)  : "N/A");
	//Challenge scores
	%goldScoreLabel     = (%info.goldScore     !$= "" ? formatScore(%info.goldScore)     : "N/A");
	%platinumScoreLabel = (%info.platinumScore !$= "" ? formatScore(%info.platinumScore) : "N/A");
	%ultimateScoreLabel = (%info.ultimateScore !$= "" ? formatScore(%info.ultimateScore) : "N/A");
	%awesomeScoreLabel  = (%info.awesomeScore  !$= "" ? formatScore(%info.awesomeScore)  : "N/A");
	if (%info.platinumScore[1] !$= "") { // Transfer the [1] score to singleplayer
		%platinumScoreLabel = %info.platinumScore[1];
		%ultimateScoreLabel = %info.ultimateScore[1];
		%awesomeScoreLabel = %info.awesomeScore[1];
	} else if (%info.goldScore[1] !$= "") { // GOLD SCORE????
		%goldScoreLabel     = %info.goldScore[1];
	}

	//Use score if a time isn't available
	%parLabel      = (%parScoreLabel     $= "N/A" ? %parTimeLabel       : %parScoreLabel);
	%goldLabel     = (%goldTimeLabel     $= "N/A" ? %goldScoreLabel     : %goldTimeLabel);
	%platinumLabel = (%platinumTimeLabel $= "N/A" ? %platinumScoreLabel : %platinumTimeLabel);
	%ultimateLabel = (%ultimateTimeLabel $= "N/A" ? %ultimateScoreLabel : %ultimateTimeLabel);
	%awesomeLabel  = (%awesomeTimeLabel  $= "N/A" ? %awesomeScoreLabel  : %awesomeTimeLabel);
	%parType      = (%parScoreLabel     $= "N/A" ? "Time" : "Score");
	%goldType     = (%goldTimeLabel     $= "N/A" ? "Score" : "Time");
	%platinumType = (%platinumTimeLabel $= "N/A" ? "Score" : "Time");
	%ultimateType = (%ultimateTimeLabel $= "N/A" ? "Score" : "Time");
	%awesomeType  = (%awesomeTimeLabel  $= "N/A" ? "Score" : "Time");

	//Get the world record
	%record = false; 

	%isMarbleland = marblelandIsMission($Client::MissionFile);

	if (lb() && !%isMarbleland) {
		%cache = PlayMissionGui.globalScoreCache[PlayMissionGui.getMissionInfo().id];
		if ($Game::isMode["challenge"])
			%cache = PlayMissionGui.globalChallengeScoreCache[PlayMissionGui.getMissionInfo().id];
		if (isObject(%cache)) {
			%scores = %cache.scores;
			if (%scores.getSize()) {
				%record = %scores.getEntry(0).score;
				%recordType = %scores.getEntry(0).score_type;
				%recordLabel = (%recordType $= "time" ? formatTime(%record) : formatScore(%record));
			}
		}
	}

	//Par is special, as it should only be shown if there's no par score
	%parTimeLabel = (%info.time ? formatTime(%info.time) : "N/A");
	%parScoreLabel = (%info.score !$= "" ? formatScore(%info.score) : "N/A");
	%parLabel = ((%type == $ScoreType::Time) ? %parTimeLabel : %parScoreLabel);
	%parType = ((%type == $ScoreType::Time) ? "Time" : "Score");

	//Information text
	%game = ($CurrentGame $= "Custom" ? resolveMissionModification(%info) : $CurrentGame);
	if ($CurrentGame $= "challenge") {
		%game = PlayMissionGui.ml.lookupDifficulty["challenge", $MissionType].display;
	}
	switch$ (%game) {
	case "Gold":
		//Need qualify and gold times
		%parTitle = "Qualify";
		%goldTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFEE11>Gold";
		%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum"; // For hunt maps, just in case
		%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate"; // For hunt maps, just in case
		%recordTitle = "<shadow:1:1><shadowcolor:0000007f><color:0060f0>World Record";
	case "Platinum":
		//Need par / platinum / ultimate
		%parTitle = "Par";
		%goldTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum";
		%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum"; // For hunt maps, just in case
		%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";
		%recordTitle = "<shadow:1:1><shadowcolor:0000007f><color:0060f0>World Record";
	case "Ultra":
		//Need par / gold / ultimate
		%parTitle = "Par";
		%goldTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFEE11>Gold";
		%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum"; // For hunt maps, just in case
		%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";
		%recordTitle = "<shadow:1:1><shadowcolor:0000007f><color:0060f0>World Record";
	case "PlatinumQuest":
		//Need par / platinum / ultimate / (awesome?)
		%parTitle = "Par";
		%goldTitle = "";
		%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum";
		%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";
		%awesomeTitle = "<shadow:1:1><shadowcolor:0000007f><color:FF3333>Awesome";
		%recordTitle = "<shadow:1:1><shadowcolor:0000007f><color:0060f0>World Record";
	default:
		//It's custom, we're not really sure here
		%parTitle = "Par";
		%goldTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFEE11>Gold";
		%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum";
		%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";
		%awesomeTitle = "<shadow:1:1><shadowcolor:0000007f><color:FF3333>Awesome";
		%recordTitle = "<shadow:1:1><shadowcolor:0000007f><color:0060f0>World Record";
	}

	//Show what we need to
	//Except always show Par because otherwise the end screen is too barren in MBG/MBP
	if (%parTitle !$= "")                                  %text = %text @ "<just:left><spush>" @ %parTitle SPC %parType @ ":<just:right>" @ %parLabel @ "<spop>\n";
	if (%goldTitle !$= ""     && %goldLabel !$= "N/A")     %text = %text @ "<just:left><spush>" @ %goldTitle SPC %goldType @ ":<just:right>" @ %goldLabel @ "<spop>\n";
	if (%platinumTitle !$= "" && %platinumLabel !$= "N/A") %text = %text @ "<just:left><spush>" @ %platinumTitle SPC %platinumType @ ":<just:right>" @ %platinumLabel @ "<spop>\n";
	if (%ultimateTitle !$= "" && %ultimateLabel !$= "N/A") %text = %text @ "<just:left><spush>" @ %ultimateTitle SPC %ultimateType @ ":<just:right>" @ %ultimateLabel @ "<spop>\n";

	//Awesome times
	if (%showAwesome) {
		if (%awesomeTitle !$= "" && %awesomeLabel !$= "N/A") %text = %text @ "<just:left><spush>" @ %awesomeTitle SPC %awesomeType @ ":<just:right>" @ %awesomeLabel @ "<spop>\n";
	}
	if (%record && %showRecord) {
		%text = %text @ "<just:left><spush>" @ %recordTitle @ ":<just:right>" @ %recordLabel @ "<spop>\n";
	}

	%text = %text @ "<just:center><color:000000><font:26><shadowcolor:7777777F>";

	%totalTTs = countTTs(MissionGroup);
	if (mp() || %totalTTs == 0 || anyRespawningTTs(MissionGroup)) { // No time travels, don't bother with a message
		%textTTs = "";
	} else {
		%grabbedTTs = countInvisibleTTs(MissionGroup);
		%plural = %totalTTs > 1? "'s" : "";
		%textTTs = "<spush><shadow:1:1><shadowcolor:0000007f><color:00FF00>(" @ %grabbedTTs @ "/" @ %totalTTs @ " TT" @ %plural @ ")<spop> ";
	}

	%text = %text @
	        "<just:left>Time Passed:<just:right>" @ formatTime($Game::ElapsedTime) @ "\n" @
	        "<just:left>Clock Bonuses:<just:right>" @ %textTTs @ formatTime($Game::BonusTime) @ "\n";

	// Display the score info
	EG_Description.setText(%text);

	%isMarbleland = marblelandIsMission($Client::MissionFile);

	// you can't be a guest to get rating.
	if (lb() && !$LB::Guest && !%isMarbleland) {
		%text = "<color:000000><font:26><shadowcolor:7777777F><shadow:1:1>";
		%rating = formatRating($LB::Rating);
		if ($LB::RatingDelta > 0) {
			%rating = "<color:00ff00>(+" @ formatRating($LB::RatingDelta) @ ")<color:000000> " @ %rating;
		}
		if (!$Game::isMode["challenge"]) {
			%text = %text @ "<just:left>Rating:<just:right>" @ ($LB::RatingPending ? "..." : %rating) @ "\n";
			%text = %text @ "<just:left>General Rating:<just:right>" @ formatRating($LB::TotalRating) @ "\n";
		}
		%text = %text @ "<just:left>Global Level Rank:<just:right>" @ ($LB::RatingPending ? "..." : $LB::LevelPosition);

		EG_Rating.setText(%text);
	} else {
		EG_Rating.setText("");
	}

	// -------------------------------------------------------------------------------
	// Grab the times from the preferences file
	// -------------------------------------------------------------------------------

	%levelName = MissionInfo.name;
	%scoreText = "<bold:28><color:000000><shadow:1:1><shadowColor:7777777F><just:center>" @ %levelName @ ", Top " @ $Game::HighscoreCount;

	for (%i = 0; %i < $Game::HighscoreCount; %i ++) {
		%type = getField($hs[%i], 0);
		%score = getField($hs[%i], 1);
		%name = getField($hs[%i], 2);

		%scoreText = %scoreText NL "<spush><shadow:1:1><font:26><just:left>";

		%current = (%i == $highScoreIndex && $highScoreIndex !$= "");
		if (%current) {
			%scoreText = %scoreText @ "<color:00DD00><shadowcolor:7777777F>" @(%i + 1) @ ". ";
		} else {
			switch (%i) {
			case 0: %scoreText = %scoreText @ "<color:eec884><shadowcolor:816d48>1. ";
			case 1: %scoreText = %scoreText @ "<color:cdcdcd><shadowcolor:7e7e7e>2. ";
			case 2: %scoreText = %scoreText @ "<color:c9afa0><shadowcolor:7f6f65>3. ";
			case 3: %scoreText = %scoreText @ "<color:a4a4a4><shadowcolor:7e7e7e>4. ";
			case 4: %scoreText = %scoreText @ "<color:949494><shadowcolor:7f6f65>5. ";
			}
		}

		%color = getScoreFormatting($hs[%i], %info);
		%formatted = (%type == $ScoreType::Time ? formatTime(%score) : formatScore(%score));

		%scoreText = %scoreText @ "<shadowcolor:7777777F>" @(%current ? "<color:00DD00>" : "<color:000000>")
		             @ %name @ (%current ? "" : %color) @ "\t<just:right>" @ %formatted @ "<spop>";
	}

	EG_TopTimesText.setText(%scoreText);

	ClientMode::callback("updateEndGame");
}
function anyRespawningTTs(%group) {
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i++) {
		%object = %group.getObject(%i);
		%type = %object.getClassName();
		if (%type $= "SimGroup") {
			if (anyRespawningTTs(%object)) {
				return true;
			}
		} else if (%object.respawnTime > 0 && %object.timeBonus > 0) {
			return true;
		}
	}
	return false;
}
function countTTs(%group) {
	// stolen from countgems function in server/game.cs
	%tts = 0;
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i++) {
		%object = %group.getObject(%i);
		%type = %object.getClassName();
		if (%type $= "SimGroup")
			%tts += countTTs(%object);
		else if (%type $= "Item" && %object.timeBonus > 0 && %object.timePenalty $= "") // There are time penalty TT's with a timeBonus AND a timePenalty. Why.
			%tts++;
	}
	return %tts;
}
function countInvisibleTTs(%group) {
	%tts = 0;
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i++) {
		%object = %group.getObject(%i);
		%type = %object.getClassName();
		if (%type $= "SimGroup")
			%tts += countInvisibleTTs(%object);
		else if (%type $= "Item" && %object.timeBonus > 0 && %object.timePenalty $= "" && %object.isHidden())
			%tts++;
	}
	return %tts;
}

function getScoreFormatting(%score, %info, %showAwesome, %placement) {
	if (%info $= "")
		%info = MissionInfo;
	%flags = Unlock::getMissionScoreFlags(%info, %score);
	if (%showAwesome $= "")
		%showAwesome = $pref::ShowAwesomeHints;

	if (%placement == 1)
		return "<shadow:1:1><shadowcolor:0000007F><color:0060f0>";
	else if (%showAwesome && (%flags & $Completion::Awesome))
		return "<shadow:1:1><shadowcolor:0000007F><color:FF4444>";
	else if (%flags & $Completion::Ultimate)
		return "<shadow:1:1><shadowcolor:0000007F><color:FFCC33>";
	else if (%flags & $Completion::Platinum)
		return "<shadow:1:1><shadowcolor:0000007F><color:CCCCCC>";
	else if (%flags & $Completion::Gold)
		return "<shadow:1:1><shadowcolor:0000007F><color:FFEE11>";

	return ""; //No color-- default color
}

//-----------------------------------------------------------------------------

function formatTime(%time, %tab) {
	%isNeg = (%tab ? "\t" : "");
	if (%time < 0) {
		%time = -%time;
		%isNeg = (%tab ? "\t-" : "-");
	}
	%hundredth = div64_int(mod64_int(%time, 1000), 10);
	%totalSeconds = div64_int(%time, 1000);
	%seconds = %totalSeconds % 60;
	%minutes = (%totalSeconds - %seconds) / 60;

	%secondsOne   = %seconds % 10;
	%secondsTen   = (%seconds - %secondsOne) / 10;
	%minutesOne   = %minutes % 10;
	%minutesTen   = (%minutes - %minutesOne) / 10;
	%hundredthOne = %hundredth % 10;
	%hundredthTen = (%hundredth - %hundredthOne) / 10;

	if ($pref::Thousandths) {
		return %isNeg @ %minutesTen @ %minutesOne @ ":" @
		       %secondsTen @ %secondsOne @ "." @
		       %hundredthTen @ %hundredthOne @(%time % 10);
	} else {
		return %isNeg @ %minutesTen @ %minutesOne @ ":" @
		       %secondsTen @ %secondsOne @ "." @
		       %hundredthTen @ %hundredthOne;
	}
}

function formatTimeSeconds(%time, %tab) {
	%isNeg = (%tab ? "\t" : "");
	if (%time < 0) {
		%time = -%time;
		%isNeg = (%tab ? "\t-" : "-");
	}
	%totalSeconds = div64_int(%time, 1000);
	%seconds = %totalSeconds % 60;
	%minutes = (%totalSeconds - %seconds) / 60;

	%secondsOne   = %seconds % 10;
	%secondsTen   = (%seconds - %secondsOne) / 10;
	%minutesOne   = %minutes % 10;
	%minutesTen   = (%minutes - %minutesOne) / 10;

	return %isNeg @ %minutesTen @ %minutesOne @ ":" @
	       %secondsTen @ %secondsOne;
}

function formatTimeHours(%time) {
	%hours = div64_int(%time, 3600);

	%minutes = div64_int(%time, 60) - (%hours * 60);
	%seconds = %time % 60;

	%secondsOne   = %seconds % 10;
	%secondsTen   = div64_int(%seconds, 10);
	%minutesOne   = %minutes % 10;
	%minutesTen   = div64_int(%minutes, 10);
	%hoursOne	  = %hours % 10;
	%hoursTen     = div64_int(%hours, 10);

	return %hoursTen @ %hoursOne @ ":" @
	       %minutesTen @ %minutesOne @ ":" @
	       %secondsTen @ %secondsOne;
}

function formatTimeHoursMs(%time) {
	%hours = mFloor(mFloor(%time / 1000) / 3600);
	%minutes = mFloor(mFloor(%time / 1000) / 60) - (%hours * 60) - (%days * 1440);
	%seconds = mFloor(%time / 1000) - (%minutes * 60) - (%hours * 3600) - (%days * 86400);
	%hundredth = mFloor((%time % 1000) / 10);

	%secondsOne   = %seconds % 10;
	%secondsTen   = mFloor(%seconds / 10);
	%minutesOne   = %minutes % 10;
	%minutesTen   = mFloor(%minutes / 10);
	%hoursOne	  = %hours % 10;
	%hoursTen     = mFloor(%hours / 10);
	%hundredthOne = %hundredth % 10;
	%hundredthTen = (%hundredth - %hundredthOne) / 10;

	if ($pref::Thousandths) {
		return (%hours > 0 ? (%hoursTen > 0 ? %hoursTen : "") @ %hoursOne @ ":" : "") @
		       %minutesTen @ %minutesOne @ ":" @
		       %secondsTen @ %secondsOne @ "." @
		       %hundredthTen @ %hundredthOne @(%time % 10);
	} else {
		return (%hours > 0 ? (%hoursTen > 0 ? %hoursTen : "") @ %hoursOne @ ":" : "") @
		       %minutesTen @ %minutesOne @ ":" @
		       %secondsTen @ %secondsOne @ "." @
		       %hundredthTen @ %hundredthOne;
	}
}

function formatTimeDays(%time) {
	%days = $pref::TotalTimerDaysAdd;
	%hours = mFloor(%time / 3600);
	%minutes = mFloor(%time / 60) - (%hours * 60);
	%seconds = %time - (%minutes * 60) - (%hours * 3600);

	%secondsOne   = %seconds % 10;
	%secondsTen   = mFloor(%seconds / 10);
	%minutesOne   = %minutes % 10;
	%minutesTen   = mFloor(%minutes / 10);
	%hoursOne	  = %hours % 10;
	%hoursTen     = mFloor(%hours / 10);
	%daysOne	  = %days % 10;
	%daysTen      = mFloor(%days / 10);

	return %daysTen @ %daysOne @ ":" @
	       %hoursTen @ %hoursOne @ ":" @
	       %minutesTen @ %minutesOne @ ":" @
	       %secondsTen @ %secondsOne;
}

function ActionMap::isPushed(%this) {
	if (!isObject(%this))
		return false;
	for (%i = 0; %i < ActiveActionMapSet.getCount(); %i ++) {
		if (ActiveActionMapSet.getObject(%i).getId() == %this.getId())
			return true;
	}
	return false;
}

function formatCommas(%number) {
	%fin = "";
	%c = -1;
	for (%i = strlen(%number); %i >= 0; %i --) {
		if (strPos("0123456789", getSubStr(%number, %i, 1)) == -1) {
			%fin = getSubStr(%number, %i, 1) @ %fin;
			continue;
		}

		if (%c % 3 == 0 && %c > 0)
			%fin = "," @ %fin;
		%fin = getSubStr(%number, %i, 1) @ %fin;
		%c ++;
	}
	return %fin;
}

function formatScore(%score, %tab) {
	return (%tab ? "\t" : "") @ formatCommas(%score);
}

function formatRating(%rating) {
	// Error Messages
	if (%rating == -1)    return "Level Error";   // Level not found
	if (%rating == -2)    return "Invalid Time";  // Score too low...
	if (%rating == -3)    return "Submitting..."; // Submitting score
	if (%rating == -4)    return "Still a WIP";   // Multiplayer Ratings
	if (%rating == -5)    return "Still a WIP";   // Other multiplayer stuffs
	if (%rating $= "INF") return "Server Error";  // The crap?

	return formatCommas(%rating);
}

//pts to next level:
//1:  50
//2: 100
//3: 150
//4: 200
//5: 250
//6: 300

//pts at level:
//1:   0
//2:  50
//3: 150
//4: 300
//5: 500
//6: 750

//total pts:
//1:   0 -  49
//2:  50 - 149
//3: 150 - 299
//4: 300 - 499
//5: 500 - 749
//6: 750 - 999

//pts to next:
//Every level is k points more to reach
//points = k/2 level^2 - k/2 level
//k/2 level^2 - k/2 level - points = 0
//level = k/2 +/- sqrt((k/2)^2 + 2k points) / k
//level = sqrt((k/2)^2 + 2k points) / k

$ptsPerLevelLevel = 50;

function levelTotalPoints(%level) {
	if (%level <= 0) return 0;
	return (($ptsPerLevelLevel / 2) * %level * %level) - (($ptsPerLevelLevel / 2) * %level);
}
function levelDeltaPoints(%level) {
	return levelTotalPoints(%level + 1) - levelTotalPoints(%level);
}
function pointsToLevel(%points) {
	if (%points <= 0) return 1;
	return mRound(mSqrt((($ptsPerLevelLevel / 2) * ($ptsPerLevelLevel / 2)) + (($ptsPerLevelLevel * 2) * %points)) / $ptsPerLevelLevel);
}

function formatLevel(%points, %size) {
	//° symbol:
	// ISO Latin 1: 0xB0
	// MacRoman: 0xA1

	return pointsToLevel(%points);
}

function formatExperience(%points) {
	return levelDeltaPoints(pointsToLevel(%points)) - (levelTotalPoints(pointsToLevel(%points) + 1) - %points);
}

function removeLeadingZerosFromTime(%time) { // 00:25.45 -> 25.45
	if (getSubStr(%time, 0, 1) $= "0" && %time !$= "0") { // %time !$= "0" just checks that it's not a score.
		if (getSubStr(%time, 1, 1) $= "0") {
			if (getSubStr(%time, 3, 1) $= "0") {
				return getSubStr(%time, 4, 10);
			}
			return getSubStr(%time, 3, 10); // 3, not 2, to remove the colon too
		}
		return getSubStr(%time, 1, 10);
	}
	return %time;
}