//-----------------------------------------------------------------------------
// Copyright (c) 2021 The Platinum Team
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
// PQ Demo statistics tracking
//-----------------------------------------------------------------------------

// $Stats::Server = "https://marbleblast.com";
// $Stats::Path   = "/pq/leader/";
// $Stats::Server = $ServerInfo::PQServer;
$Stats::Path   = "/";
$Stats::RetryTime = 15000;

function statsGet(%page, %values) {
	if (lb()) {
		%values = addParams(LBDefaultQuery(), %values);
	}
	%values = addParam(%values, "full", "1");

	return statsAddRequest("GET", $Stats::Path @ %page, %values);
}
function statsPost(%page, %values) {
	if (lb()) {
		%values = addParams(LBDefaultQuery(), %values);
	}
	%values = addParam(%values, "full", "1");

	return statsAddRequest("POST", $Stats::Path @ %page, %values);
}

function statsAddRequest(%method, %page, %values) {
	RootGroup.add(%req = new ScriptObject() {
		class = "StatsRequest";
		method = %method;
		page = %page;
		values = %values;
		script = fileBase(%page);
	});
	%req.values = addParam(%req.values, "req", %req);
	%req.send();

	return %req;
}

function StatsRequest::send(%this) {
	cancelIgnorePause(%this.retrySend);
	%this.retrySend = %this.scheduleIgnorePause($Stats::RetryTime, "send");

	if (!isObject(StatsRequests)) {
		RootGroup.add(new SimGroup(StatsRequests));
	}
	TCPGroup.add(new HTTPObject(StatsNetwork));
	if (!$pref::SSL::VerifyPeer) {
		StatsNetwork.setOption("verify-peer", false);
	}
	StatsNetwork.host = $LBServerInfo::PQServer;
	StatsNetwork.sendRequest(%this);

	if (%this.getGroup() !$= StatsRequests) {
		//Put it on the queue
		StatsRequests.add(%this);
	}
}

function StatsNetwork::sendRequest(%this, %req) {
	//Don't send the last request twice
	if (%req.sent) {
		return;
	}

	switch$ (%req.method) {
	case "GET":
		%this.get(%this.host, %req.page, %req.values);
		%this.echo("get " @ %this.host @ "/" @ %req.page @ " values: " @ %req.values);
	case "POST":
		%this.post(%this.host, %req.page, "", %req.values);
		%this.echo("post " @ %this.host @ "/" @ %req.page @ " values: " @ %req.values);
	}
}

function StatsNetwork::onLine(%this, %line) {
	%this.echo(%line, "Line");

	Parent::onLine(%this, %line);

	%first = firstWord(%line);
	//Not us
	if (%first !$= "pq")
		return;
	%line = restWords(%line);

	//Which script is this
	%req = firstWord(%line);
	%line = restWords(%line);
	if (isObject(%req)) {
		%script = %req.script;
		cancelIgnorePause(%req.retrySend);

		//Delete last request
		if (%req != %this.lastReq) {
			if (isObject(%this.lastReq)) {
				%this.lastReq.delete();
			}
			%this.lastReq = %req;
		}
		%req.sent = true;
	} else {
		%script = %req;
	}

	if (isFunction("stats" @ %script @ "Line")) {
		if (isObject(%req)) {
			call("stats" @ %script @ "Line", %line, %req);
		} else {
			call("stats" @ %script @ "Line", %line);
		}
	}
}

function StatsNetwork::onDisconnect(%this) {
	%this.delete();
}

function statsGetMissionIdentifier(%mission) {
	if (%mission.is_custom || %mission.id $= "") {
		//Need to provide these:
		//missionFile
		//missionName
		//missionHash
		//difficultyId

		%missionData =  "missionFile="     @ URLEncode(%mission.file) @
		               "&missionName="     @ URLEncode(%mission.name) @
		               "&missionHash="     @ URLEncode(getMissionHash(%mission)) @
		               "&missionGamemode=" @ URLEncode(resolveMissionGameModes(%mission, "")) @
		               "&difficultyId="    @ URLEncode(%mission.difficultyId) ;
	} else {
		return "missionId=" @ %mission.id;
	}
}

//-----------------------------------------------------------------------------
// Basic server stuff
//-----------------------------------------------------------------------------

function statsGetServerStatus() {
	statsGet("api/Server/GetServerStatus.php");
}

function statsGetServerStatusLine(%line) {
	fwrite("platinum/json/serverStatus.json", %line);

	%parsed = jsonParse(%line);
	LBLoginGui.onServerStatus(%parsed);
}

//-----------------------------------------------------------------------------

function statsGetServerVersion() {
	statsGet("api/Server/GetServerVersion.php");
}

function statsGetServerVersionLine(%line) {
	fwrite("platinum/json/serverVersion.json", %line);

	%parsed = jsonParse(%line);
	onVersionCheck(%parsed);
}

//-----------------------------------------------------------------------------

function statsCheckLogin(%version) {
	%params = LBDefaultQuery();
	%params = addParam(%params, "version", %version);
	statsPost("api/Player/CheckLogin.php", %params);
}

function statsCheckLoginLine(%line) {
	fwrite("platinum/json/checkLogin.json", %line);

	%parsed = jsonParse(%line);
	LBLoginGui.onLoginStatus(%parsed);
}

//-----------------------------------------------------------------------------

function statsRegisterUser(%username, %password, %email) {
	%params = "username=" @ %username;
	%params = addParam(%params, "password", %password);
	%params = addParam(%params, "email", %email);

	statsPost("api/Player/RegisterUser.php", %params);
}

function statsRegisterUserLine(%line) {
	fwrite("platinum/json/registerUser.json", %line);

	%parsed = jsonParse(%line);
	LBRegisterDlg.onRegisterStatus(%parsed);
}

//-----------------------------------------------------------------------------
// Single Player Submitting:
//-----------------------------------------------------------------------------

//Various little challenges that people try
$Stats::Modifiers::GotEasterEgg      = (1 <<  0);
$Stats::Modifiers::NoJumping         = (1 <<  1);
$Stats::Modifiers::SpecialMode       = (1 <<  2);
$Stats::Modifiers::NoTimeTravels     = (1 <<  3);
//If you use a controller you're challenged
$Stats::Modifiers::Controller        = (1 << 16);
//Game mode-specific
$Stats::Modifiers::QuotaHundred      = (1 <<  4);
$Stats::Modifiers::GemMadnessAll     = (1 <<  5);
//Challenge time-based
$Stats::Modifiers::BeatParTime       = (1 <<  6);
$Stats::Modifiers::BeatPlatinumTime  = (1 <<  7);
$Stats::Modifiers::BeatUltimateTime  = (1 <<  8);
$Stats::Modifiers::BeatAwesomeTime   = (1 <<  9);
//Challenge score-based
$Stats::Modifiers::BeatParScore      = (1 << 10);
$Stats::Modifiers::BeatPlatinumScore = (1 << 11);
$Stats::Modifiers::BeatUltimateScore = (1 << 12);
$Stats::Modifiers::BeatAwesomeScore  = (1 << 13);
//Of the score was the world record when it was achieved (could still be WR too)
$Stats::Modifiers::WasWorldRecord    = (1 << 14);
//If this score is their current best (rows are updated in RecordScore)
// TODO: Not implemented
$Stats::Modifiers::IsBestScore       = (1 << 15);


function statsRecordScore(%mission) {
	%score = $Game::FinalScore;

	//Extract the parts of the score and make them pretty
	%scoreType = getField(%score, 0) == $ScoreType::Time ? "time" : "score";
	%score = removeScientificNotation(getField(%score, 1));
	%marble = MarbleSelectDlg.getOnlineMarbleId();

	//Modifiers that tell us information about the score
	%gotEasterEgg  =  $Game::EasterEgg; //Got EE
	%noJumping     = !$Game::Jumped; //No jumping
	%specialMode   =  $Game::SpecialMode; //Double Diamond achievement & others
	%noTimeTravels = (PlayGui.totalBonus == 0); //No time travels
	%quotaHundred  = ($Game::isMode["quota"] && PlayGui.gemCount == $Game::GemCount); //100% on quota
	%gemMadnessAll = ($Game::isMode["gemMadness"] && $Game::UseTimeScore); //All gems on gem madness
	%controller    =  $pref::Input::ControlDevice $= "Joystick"; //Cheatable but idc that much

	//Combine them in a nice bitfield
	%modifiers =
		  (%gotEasterEgg  ? $Stats::Modifiers::GotEasterEgg  : 0)
		| (%noJumping     ? $Stats::Modifiers::NoJumping     : 0)
		| (%specialMode   ? $Stats::Modifiers::SpecialMode   : 0)
		| (%noTimeTravels ? $Stats::Modifiers::NoTimeTravels : 0)
		| (%quotaHundred  ? $Stats::Modifiers::QuotaHundred  : 0)
		| (%gemMadnessAll ? $Stats::Modifiers::GemMadnessAll : 0)
		| (%controller    ? $Stats::Modifiers::Controller    : 0);

	//Hack
	%totalBonus = $Time::TotalBonus;

	//Major hack
	%client = LocalClientConnection;

	//Additional fields
	%gemFields = "&gemCount=" @ %client.gemsFoundTotal @
	             "&gems1="    @ %client.gemsFound[1] @
	             "&gems2="    @ %client.gemsFound[2] @
	             "&gems5="    @ %client.gemsFound[5] @
	             "&gems10="   @ %client.gemsFound[10];

	%modeFields = ClientMode::callbackForMission(%mission, "getScoreFields", "");

	statsPost("api/Score/RecordScore.php",
		statsGetMissionIdentifier(%mission) @
		"&score=" @ %score @
		"&scoreType=" @ %scoreType @
		"&totalBonus=" @ %totalBonus @
		"&modifiers=" @ %modifiers @
		"&marbleId=" @ %selection @
		%gemFields @
		%modeFields);
}
function statsRecordScoreLine(%line) {
	%command = firstWord(%line);
	switch$ (%command) {
	case "SUCCESS":
		echo("Stats: Score recorded");
		$LB::RatingPending = false;
		if (!$LB::Guest) {
			statsGetPersonalTopScores(getMissionInfo($Client::MissionFile));
		}
		statsGetGlobalTopScores(getMissionInfo($Client::MissionFile));
	case "FAILURE":
		echo("Stats: Score record failure");
	case "RATING":
		%rating = restWords(%line);
		echo("Stats: Score rating is " @ %rating);
		$LB::Rating = %rating;
		reformatGameEndText();
	case "NEWRATING":
		%rating = restWords(%line);
		echo("Stats: General rating is " @ %rating);
		$LB::TotalRating = %rating;
		reformatGameEndText();
	case "POSITION":
		%position = restWords(%line);
		echo("Stats: Score position is " @ %position);
		$LB::LevelPosition = %position;
		reformatGameEndText();
	case "DELTA":
		%delta = restWords(%line);
		echo("Stats: Rating delta is " @ %delta);
		$LB::RatingDelta = %delta;
		reformatGameEndText();
	case "RECORDING":
		//The server wants our recording, let's oblige
		statsRecordReplay(getMissionInfo($Client::MissionFile), "Replay");
	case "ACHIEVEMENT":
		%achId = restWords(%line);
		echo("Stats: Got achievement id" @ %achId);

		LBAchievementsDlg.onGrantAchievement(%achId);
	}
}

function statsRecordChallengeScore(%mission) {
	%score = $Game::FinalScore;

	//Extract the parts of the score and make them pretty
	%score = removeScientificNotation(getField(%score, 1));

	//Major hack
	%client = LocalClientConnection;

	%modeFields = ClientMode::callbackForMission(%mission, "getScoreFields", "");

	statsPost("api/Score/RecordChallengeScore.php",
		statsGetMissionIdentifier(%mission) @
		"&score=" @ %score @
		%modeFields);
}
function statsRecordChallengeScoreLine(%line) {
	%command = firstWord(%line);
	switch$ (%command) {
	case "SUCCESS":
		echo("Stats: Score recorded");
		if (!$LB::Guest) {
			statsGetPersonalTopScores(getMissionInfo($Client::MissionFile)); // TODO
		}
		statsGetGlobalChallengeTopScores(getMissionInfo($Client::MissionFile), $CurrentWeeklyChallenge.name);
	case "FAILURE":
		echo("Stats: Score record failure");
	case "POSITION":
		%position = restWords(%line);
		echo("Stats: Score position is " @ %position);
		$LB::LevelPosition = %position;
		reformatGameEndText();
	}
}

//-----------------------------------------------------------------------------

function statsRecordEgg(%mission, %time) {
	statsPost("api/Egg/RecordEgg.php", statsGetMissionIdentifier(%mission) @ "&time=" @ removeScientificNotation(%time));
}
function statsRecordEggLine(%line) {
	if (%line $= "SUCCESS") {
		echo("Stats: Egg recorded");
		statsGetTopScoreModes(getMissionInfo($Client::MissionFile));
	} else if (%line $= "FAILURE") {
		echo("Stats: Egg record failure");
	} else if (%line $= "ALREADY") {
		echo("Stats: Egg already found");
	} else if (%line $= "RECORDING") {
		echo("Stats: Egg world record");
		statsRecordReplay(PlayMissionGui.getMissionInfo(), "Egg");
	}
}

//-----------------------------------------------------------------------------

function statsRecordMetrics() {
	//All possible resolutions in a tab-separated list (with a tab at the front)
	%resList = "\t" @ getResolutionList($pref::Video::displayDevice);
	//Replace all tabs to the field name
	%resList = strReplace(%resList, "\t", "&supportedResolutions[]=");

	statsPost("api/Player/RecordMetrics.php", "screenResolution=" @ getDesktopResolution() @ "&windowResolution=" @ getResolution() @ %resList);
}
function statsRecordMetricsLine(%line) {
	if (%line $= "SUCCESS") {
		echo("Stats: Metrics recorded");
	} else if (%line $= "FAILURE") {
		echo("Stats: Metrics record failure");
	}
}

//-----------------------------------------------------------------------------

function statsRecordGraphicsMetrics() {
	%info       = getVideoDriverInfo();
	%vendor     = getField(%info, 0);
	%renderer   = getField(%info, 1);
	%version    = getWord(getField(%info, 2), 0);
	%major      = getSubStr(%version, 0, strpos(%version, "."));
	%minor      = getSubStr(%version, strpos(%version, ".") + 1, strlen(%version));
	%extensions = getField(%info, 3);

	%extensions = strReplace(" " @ %extensions, " ", "&extensions[]=");

	%params = "major=" @ %major @ "&minor=" @ %minor @ "&vendor=" @ %vendor @ "&renderer=" @ %renderer @ "&os=" @ $platform @ %extensions;

	statsPost("api/Metrics/RecordGraphicsMetrics.php", %params);
}
function statsRecordGraphicsMetricsLine(%line) {
	if (%line $= "SUCCESS") {
		echo("Stats: Graphics metrics recorded");
	} else if (%line $= "FAILURE") {
		echo("Stats: Graphics metrics record failure");
	}
}

//-----------------------------------------------------------------------------
// Chat
//-----------------------------------------------------------------------------

function statsGetFlairBitmap(%flair) {
	statsPost("api/Chat/GetFlairBitmap.php", "flair=" @ %flair);
}

function statsGetFlairBitmapLine(%line) {
	%parsed = jsonParse(%line);

	if (%parsed.error $= "") {
		%path = "platinum/client/ui/lb/chat/flair/" @ %parsed.filename;

		%fo = new FileObject();
		%fo.openForWrite(%path);
		for (%i = 0; %i < %parsed.contents.getSize(); %i ++) {
			%fo.writeBase64(%parsed.contents.getEntry(%i));
		}
		%fo.close();
		%fo.delete();

		%parsed.delete();
	}
}

//-----------------------------------------------------------------------------
// Level Select:
//-----------------------------------------------------------------------------

function statsGetGlobalTopScores(%mission, %modifiers) {
	%missionData = statsGetMissionIdentifier(%mission);

	if (%modifiers !$= "") {
		%missionData = addParam(%missionData, "modifiers", %modifiers);
	}

	%req = statsPost("api/Score/GetGlobalTopScores.php", %missionData);
	%req.mission = %mission;
}
function statsGetGlobalTopScoresLine(%line, %req) {
	if (firstWord(%line) $= "ARGUMENT") {
		//Nope
		PlayMissionGui.onOnlineScoreFailed(%req.mission);
		return;
	}
	fwrite("platinum/json/globalTopScores.json", %line);

	//Json data
	%parsed = jsonParse(%line);
	if (isObject(%parsed)) {
		if (%req.mission.is_custom) {
			devecho("Found custom mission id " @ %parsed.missionId @ " for mission " @ %req.mission.file);
			%req.mission.id = %parsed.missionId;
		}
		PlayMissionGui.onOnlineScoreUpdate(%parsed);
	} else {
		PlayMissionGui.onOnlineScoreFailed(%req.mission);
	}
}

function statsGetGlobalChallengeTopScores(%mission, %challenge) {
	%missionData = statsGetMissionIdentifier(%mission);

	if (%challenge !$= "") {
		%missionData = addParam(%missionData, "challenge", %challenge);
	}

	%req = statsPost("api/Score/GetGlobalChallengeTopScores.php", %missionData);
	%req.mission = %mission;
}
function statsGetGlobalChallengeTopScoresLine(%line, %req) {
	if (firstWord(%line) $= "ARGUMENT") {
		//Nope
		PlayMissionGui.onOnlineChallengeScoreFailed(%req.mission);
		return;
	}
	fwrite("platinum/json/globalChallengeTopScores.json", %line);

	//Json data
	%parsed = jsonParse(%line);
	if (isObject(%parsed)) {
		if (%req.mission.is_custom) {
			devecho("Found custom mission id " @ %parsed.missionId @ " for mission " @ %req.mission.file);
			%req.mission.id = %parsed.missionId;
		}
		PlayMissionGui.onOnlineChallengeScoreUpdate(%parsed);
	} else {
		PlayMissionGui.onOnlineChallengeScoreFailed(%req.mission);
	}
}

//-----------------------------------------------------------------------------

function statsGetTopScoreModes(%mission, %modifiers) {
	%missionData = statsGetMissionIdentifier(%mission);

	if (%modifiers !$= "") {
		%missionData = addParam(%missionData, "modifiers", %modifiers);
	}

	%req = statsPost("api/Score/GetTopScoreModes.php", %missionData);
	%req.mission = %mission;
}
function statsGetTopScoreModesLine(%line, %req) {
	if (firstWord(%line) $= "ARGUMENT") {
		//Nope
		PlayMissionGui.onOnlineScoreModeFailed(%req.mission);
		return;
	}
	fwrite("platinum/json/topScoreModes.json", %line);

	//Json data
	%parsed = jsonParse(%line);
	if (isObject(%parsed)) {
		echo(%parsed);
		if (%req.mission.is_custom) {
			devecho("Found custom mission id " @ %parsed.missionId @ " for mission " @ %req.mission.file);
			%req.mission.id = %parsed.missionId;
		}
		PlayMissionGui.onOnlineScoreModeUpdate(%parsed);
	} else {
		PlayMissionGui.onOnlineScoreModeFailed(%req.mission);
	}
}

//-----------------------------------------------------------------------------

function statsGetPersonalTopScores(%mission, %challenge) {
	%missionData = statsGetMissionIdentifier(%mission);

	if (%challenge !$= "") {
		%missionData = addParam(%missionData, "challenge", %challenge);
	}

	%req = statsPost("api/Score/GetPersonalTopScores.php", %missionData);
	%req.mission = %mission;

	if (%challenge !$= "") {
		%req.challenge = true;
	}
}
function statsGetPersonalTopScoresLine(%line, %req) {

	%challenge = 0;
	if (%req.challenge)
		%challenge = 1;

	if (firstWord(%line) $= "ARGUMENT") {
		//Nope
		PlayMissionGui.onPersonalScoreFailed(%req.mission, %challenge);
		return;
	}
	fwrite("platinum/json/personalTopScores.json", %line);

	//Json data
	%parsed = jsonParse(%line);
	if (isObject(%parsed)) {
		if (%req.mission.is_custom) {
			devecho("Found custom mission id " @ %parsed.missionId @ " for mission " @ %req.mission.file);
			%req.mission.id = %parsed.missionId;
		}
		PlayMissionGui.onPersonalScoreUpdate(%parsed, %challenge);
	} else {
		PlayMissionGui.onPersonalScoreFailed(%req.mission, %challenge);
	}
}

//-----------------------------------------------------------------------------

function statsGetPersonalTopScoreList() {
	statsPost("api/Score/GetPersonalTopScoreList.php");
	LBAddLoadProgress();
}
function statsGetPersonalTopScoreListLine(%line) {
	fwrite("platinum/json/personalTopScoreList.json", %line);

	//Json data
	%parsed = jsonParse(%line);
	PlayMissionGui.onPersonalScoreListUpdate(%parsed);
	PlayMissionGui.copyOnlinePrefs();
	LBOnLoadProgress();
}

//-----------------------------------------------------------------------------

function statsGetEasterEggs() {
	statsPost("api/Egg/GetEasterEggs.php");
	LBAddLoadProgress();
}
function statsGetEasterEggsLine(%line) {
	fwrite("platinum/json/easterEggs.json", %line);
	//Json data
	%parsed = jsonParse(%line);
	PlayMissionGui.onEasterEggUpdate(%parsed);
	LBOnLoadProgress();
}

//-----------------------------------------------------------------------------

function statsGetMissionList(%gameType) {
	%req = statsPost("api/Mission/GetMissionListChallenge.php", "gameType=" @ %gameType);
	%req.gameType = %gameType;
	if (!$Server::Dedicated) {
		LBAddLoadProgress();
	}
}

function statsGetMissionListChallengeLine(%line, %req) {
	fwrite("platinum/json/missionList-" @ %req.gameType @ ".json", %line);

	%update = false;
	%parsed = jsonParse(%line);
	correctNextFrame(); //This is gonna take a while
	if (%parsed.gameType $= "Single Player") {
		%ml = getMissionList("lb");

		if (%ml.setOnlineMissionList(%parsed)) {
			%update = lb() && !mp();
		}
	} else if (%parsed.gameType $= "Multiplayer") {
		%ml = getMissionList("mp");

		if (%ml.setOnlineMissionList(%parsed)) {
			%update = mp();
		}
	} else {
		//???
		echo("Got unknown mission list type: " @ %parsed.gameType);
	}

	//Only update the interface if this list is the one we're using
	if (%update) {
		if ($Server::Dedicated) {
			//Don't have Unlock::updateCaches to build the list for us, just do it here
			%games = %ml.getGameList();
			%gcount = getRecordCount(%games);
			for (%i = 0; %i < %gcount; %i ++) {
				%game = getRecord(%games, %i);
				%gameName = getField(%game, 0);

				%difficulties = %ml.getDifficultyList(%gameName);
				%dcount = getRecordCount(%difficulties);
				for (%j = 0; %j < %dcount; %j ++) {
					%difficulty = getRecord(%difficulties, %j);
					%difficultyName = getField(%difficulty, 0);
					%ml.buildMissionList(%gameName, %difficultyName);
				}
			}

			$CurrentGame = getField(getRecord(%games, 0), 0);
			$MissionType = getField(getRecord(%ml.getDifficultyList($CurrentGame), 0), 0);
		} else {
			PlayMissionGui.init();
			Unlock::updateCaches();
			statsGetPersonalTopScoreList();
		}
	}

	if (!$Server::Dedicated) {
		LBOnLoadProgress();
	}
}

//-----------------------------------------------------------------------------
// Top Scores:
//-----------------------------------------------------------------------------

function statsGetTopPlayers() {
	statsPost("api/Player/GetTopPlayers.php");
}
function statsGetTopPlayersLine(%line) {
	fwrite("platinum/json/topPlayers.json", %line);

	//Json data
	%parsed = jsonParse(%line);
	LBScoresDlg.onTopPlayersUpdate(%parsed);
}

//-----------------------------------------------------------------------------
// Marble Select:
//-----------------------------------------------------------------------------

function statsGetMarbleList() {
	statsPost("api/Marble/GetMarbleList.php");
	LBAddLoadProgress();
}

function statsGetMarbleListLine(%line) {
	fwrite("platinum/json/marbleList.json", %line);

	%parsed = jsonParse(%line);
	if ($Server::Dedicated) {
		loadDedicatedMarbleList(%parsed);
	} else {
		MarbleSelectDlg.setOnlineMarbleList(%parsed);

		if ($LB::Loading && $LB::LoggedIn) {
			if ($LB::Guest) {
				MarbleSelectDlg.setOnlineMarbleId("1 1");
			} else {
				statsGetCurrentMarble();
			}
		}
		LBOnLoadProgress();
	}
}

//-----------------------------------------------------------------------------

function statsGetCurrentMarble() {
	statsPost("api/Marble/GetCurrentMarble.php");
	LBAddLoadProgress();
}

function statsGetCurrentMarbleLine(%line) {
	MarbleSelectDlg.setOnlineMarbleId(%line);

	LBOnLoadProgress();
}

//-----------------------------------------------------------------------------

function statsRecordMarbleSelection() {
	%selection = MarbleSelectDlg.getOnlineMarbleId();
	if ($curStatsMarbleSelection !$= %selection) {
		statsPost("api/Marble/RecordMarbleSelection.php", "marbleId=" @ %selection);
		$curStatsMarbleSelection = %selection;
	}
}
function statsRecordMarbleSelectionLine(%line) {
	if (%line $= "SUCCESS") {
		echo("Stats: Marble selection recorded");
	} else if (%line $= "FAILURE") {
		echo("Stats: Marble selection record failure");
	}
}

//-----------------------------------------------------------------------------
// Profile:
//-----------------------------------------------------------------------------

function statsGetPlayerProfileInfo(%user) {
	statsPost("api/Player/GetPlayerProfileInfo.php", "user=" @ %user);
}

function statsGetPlayerProfileInfoLine(%line) {
	fwrite("platinum/json/playerProfileInfo.json", %line);

	%parsed = jsonParse(%line);
	LBUserDlg.onPlayerProfileInfoUpdate(%parsed);
}

//-----------------------------------------------------------------------------

function statsGetPlayerAvatar(%username) {
	statsPost("api/Player/GetPlayerAvatar.php", "user=" @ %username);
}

function statsGetPlayerAvatarLine(%line) {
	%parsed = jsonParse(%line);

	if (%parsed.error $= "") {
		%path = "platinum/client/ui/lb/avatars/" @ %parsed.filename;

		%fo = new FileObject();
		%fo.openForWrite(%path);
		for (%i = 0; %i < %parsed.contents.getSize(); %i ++) {
			%fo.writeBase64(%parsed.contents.getEntry(%i));
		}
		%fo.close();
		%fo.delete();

		$LBPref::AvatarCache[%parsed.username, "path"] = %path;
		$LBPref::AvatarCache[%parsed.username, "hash"] = %parsed.hash;

		%parsed.delete();

		LBUserDlg.onPlayerAvatarUpdate();
	}
}

//-----------------------------------------------------------------------------
// Statistics:
//-----------------------------------------------------------------------------

function statsGetPlayerStats(%user) {
	statsPost("api/Player/GetPlayerStats.php", "user=" @ %user);
}

function statsGetPlayerStatsLine(%line) {
	fwrite("platinum/json/playerStats.json", %line);

	%parsed = jsonParse(%line);
	LBStatsDlg.onPlayerStatsUpdate(%parsed);
}

//-----------------------------------------------------------------------------
// Achievements:
//-----------------------------------------------------------------------------

function statsGetAchievementList() {
	statsPost("api/Achievement/GetAchievementList.php");
	LBAddLoadProgress();
}

function statsGetAchievementListLine(%line) {
	fwrite("platinum/json/achievementList.json", %line);

	%parsed = jsonParse(%line);
	LBAchievementsDlg.onAchievementListUpdate(%parsed);

	statsGetPlayerAchievements($LB::Username);
	LBOnLoadProgress();
}

//-----------------------------------------------------------------------------

function statsGetPlayerAchievements(%user) {
	statsPost("api/Player/GetPlayerAchievements.php", "user=" @ %user);
	LBAddLoadProgress();
}

function statsGetPlayerAchievementsLine(%line) {
	fwrite("platinum/json/playerAchievements.json", %line);

	%parsed = jsonParse(%line);
	LBAchievementsDlg.onPlayerAchievementsUpdate(%parsed);

	LBOnLoadProgress();
}

//-----------------------------------------------------------------------------

function statsRecordAchievement(%achId) {
	%req = statsPost("api/Achievement/RecordAchievement.php", "achievement=" @ %achId);
	%req.achId = %achId;
}

function statsRecordAchievementLine(%line, %req) {
	switch$ (%line) {
	case "NOACH":
		echo("Stats: No achievement exists");
	case "AUTOMATIC":
		echo("Stats: Achievement is not manually awarded");
	case "GRANTED":
		echo("Stats: Achievement granted");
		LBAchievementsDlg.onGrantAchievement(%req.achId);
	}
}

//-----------------------------------------------------------------------------
// WR Replays
//-----------------------------------------------------------------------------

$TCP::MaxPostLength = 1024 * 1024 * 7; //7MB
$Replay::MaxTimeout = 1000; //ms

function statsRecordReplay(%mission, %type, %isRetry) {
	//If we're waiting to end a recording, do that before anything else
	if (isEventPending($recordFinish)) {
		cancel($recordFinish);
		recordFinish();
		%keepRecording = false;
	} else {
		//Close handle to file
		RecordFO.close();
		RecordFO.delete();
		%keepRecording = true;
	}

	%file = "platinum/data/recordings/lb-" @ %type @ "-" @ fileBase(%mission.file) @ "-" @ %mission.id @ ".rrec";
	%i = 1;
	while (isFile(%file)) {
		%file = "platinum/data/recordings/lb-" @ %type @ "-" @ fileBase(%mission.file) @ "-" @ %mission.id @ "-" @ %i @ ".rrec";
		%i ++;
	}
	echo(%file);

	// Save header
	%author = $LB::DisplayName;
	%name = "World Record " @ %type @ " - " @ %mission.name @ " " @ %i;
	%desc = "Automatically saved.";

	%fr = new FileObject();
	if (!%fr.openForRead($Record::File)) {
		MessageBoxOk("Cannot submit replay", "Couldn't open temp file");
		if (%keepRecording) {
			new FileObject(RecordFO);
			RecordFO.openForAppend($Record::File);
		}
		return;
	}
	%fw = new FileObject();
	if (!%fw.openForWrite(%file)) {
		MessageBoxOk("Cannot submit replay", "Couldn't open copy file");
		if (%keepRecording) {
			new FileObject(RecordFO);
			RecordFO.openForAppend($Record::File);
		}
		return;
	}

	//Copy header
	%fw.writeRawS16(%fr.readRawS16());
	%fw.writeRawS16(%fr.readRawS16());
	%fw.writeRawString8(%fr.readRawString8());
	%fw.writeRawString8(%fr.readRawString8());

	//Change to mark as having metadata
	%flags = %fr.readRawU8();
	%flags |= 1;
	%fw.writeRawU8(%flags);

	//Write metadata
	recordWriteMetadata(%fw, %author, %name, %desc);

	//Write the rest of the everything
	%fw.writeBase64(%fr.readBase64());

	%fr.close();
	%fw.close();
	%fr.delete();
	%fw.delete();

	//Get contents
	%fo = new FileObject();
	if (!%fo.openForRead(%file)) {
		MessageBoxOk("Cannot submit replay", "Replay file failed to copy");
		if (%keepRecording) {
			new FileObject(RecordFO);
			RecordFO.openForAppend($Record::File);
		}
		return;
	}
	//El cheapo URLEncode
	%conts = strReplace(%fo.readBase64(), "+", "%2B");
	%len = strlen(%conts);

	%fo.close();
	%fo.delete();

	//Now submit it
	if (%len > $TCP::MaxPostLength) {
		MessageBoxOk("Cannot submit replay", "Replay file is too large to submit. Check " @ %file);
		if (%keepRecording) {
			new FileObject(RecordFO);
			RecordFO.openForAppend($Record::File);
		}
		return;
	}

	if (%keepRecording) {
		new FileObject(RecordFO);
		RecordFO.openForAppend($Record::File);
	}

	if (!%isRetry) {
		$Replay::LastTry = getRealTime();
	}

	%req = statsPost("api/Replay/RecordReplay.php", statsGetMissionIdentifier(%mission) @ "&type=" @ %type @ "&conts=" @ %conts);
	%req.file = %file;
	%req.mission = %mission;
	%req.type = %type;
}

function statsRecordReplayLine(%line, %req) {
	fwrite("platinum/json/recordReplay.json", %line);

	if (%line $= "RETRY") {
		// Fuck, try again
		if (getRealTime() - $Replay::LastTry < $Replay::MaxTimeout) {
			statsRecordReplay(%req.mission, %req.type, true);
		} else {
			%file = "platinum/data/recordings/lb-" @ %req.type @ "-" @ %req.mission.id @ ".rrec";
			MessageBoxOk("Cannot submit replay", "Server rejected replay, cannot submit. Check " @ %file);
		}
	}
}

//-----------------------------------------------------------------------------

function statsGetReplay(%mission, %type) {
	statsPost("api/Replay/GetReplay.php", statsGetMissionIdentifier(%mission) @ "&type=" @ %type);
}

function statsGetReplayLine(%line) {
	fwrite("platinum/json/getReplay.json", %line);

	%parsed = jsonParse(%line);

	if (%parsed.error $= "") {
		%path = "platinum/data/recordings/lb-current.rrec";

		%fo = new FileObject();
		%fo.openForWrite(%path);
		for (%i = 0; %i < %parsed.contents.getSize(); %i ++) {
			%fo.writeBase64(%parsed.contents.getEntry(%i));
		}
		%fo.close();
		%fo.delete();
		%parsed.delete();

		$replayFromWorldRecord = true;
		playReplay(%path);
	} else {
		MessageBoxOk("Cannot play replay", %parsed.error);
		%parsed.delete();
	}
}

//-----------------------------------------------------------------------------
// Multiplayer:
//-----------------------------------------------------------------------------

function statsRecordMatch(%mission) {
	//Grab variables for query
	%players = getPlayingPlayerCount();
	%port    = $pref::Server::Port;
	%modes   = URLEncode(resolveMissionGameModes(MissionInfo, MissionInfo.gameMode));
	%total   = Mode::callback("getStartTime", 0);
	%type    = Mode::callback("getScoreType", $ScoreType::Time);
	%bonus   = $Time::TotalBonus;

	%type = (%type == $ScoreType::Time ? "time" : "score");

	%missionData = statsGetMissionIdentifier(%mission);

	//Generate query data
	%data = %missionData @
	        "&players="        @ %players    @
	        "&port="           @ %port       @
	        "&scoreType="      @ %type       @
	        "&totalBonus="     @ %bonus      @
	        "&modes="          @ %modes      ;

	if ($MP::TeamMode) {
		%data = %data @ "&teammode=1";
		for (%i = 0; %i < TeamGroup.getCount(); %i ++) {
			%team = TeamGroup.getObject(%i);
			if (%team.getCount() == 0)
				continue;
			%data = %data @ "&teams[number][]=" @ %team.number;
			%data = %data @ "&teams[name][]=" @ URLEncode(Team::getTeamName(%team));
			%data = %data @ "&teams[color][]=" @ Team::getTeamColor(%team);
		}
	} else {
		%data = %data @ "&teammode=0";
	}

	//Generate player query data
	%set = ClientGroup.merge(FakeClientGroup);
	for (%i = 0; %i < %set.getCount(); %i ++) {
		%player = %set.getObject(%i);
		// No spectators!
		if (%player.spectating && %player.gemCount == 0)
			continue;

		%score = Mode::callback("getFinalScore", $ScoreType::Time TAB $Time::CurrentTime, new ScriptObject() {
			client = %player;
			_delete = true;
		});
		%score = getField(%score, 1);

		%skin = MPMarbleList.findTextIndex(%player.skinChoice);
		%data = %data @ "&scores[username][]=" @ URLEncode(%player.getUsername());
		%data = %data @ "&scores[score][]=" @ mFloor(%score);
		%data = %data @ "&scores[place][]=" @ GameConnection::getPlace(%player);
		%data = %data @ "&scores[host][]=" @ !!%player.isHost();
		%data = %data @ "&scores[guest][]=" @ !!%player.isGuest();
		%data = %data @ "&scores[marble][]=" @ URLEncode(%skin);
		%data = %data @ "&scores[timePercent][]=" @ 1;
		%data = %data @ "&scores[disconnect][]=" @ !!%player.fake;
		%data = %data @ "&scores[gemCount][]=" @ mFloor(%player.gemsFoundTotal);
		%data = %data @ "&scores[gems1][]=" @ mFloor(%player.gemsFound[1]);
		%data = %data @ "&scores[gems2][]=" @ mFloor(%player.gemsFound[2]);
		%data = %data @ "&scores[gems5][]=" @ mFloor(%player.gemsFound[5]);
		%data = %data @ "&scores[gems10][]=" @ mFloor(%player.gemsFound[10]);
		if ($MP::TeamMode) {
			%data = %data @ "&scores[team][]=" @ mFloor(%player.team.number);
		} else {
			%data = %data @ "&scores[team][]=-1";
		}

		%data = Mode::callback("modifyPlayerScoreData", %data, new ScriptObject() {
			client = %player;
			data = %data;
			_delete = true;
		});
	}
	%set.delete();

	%data = Mode::callback("modifyScoreData", %data, new ScriptObject() {
		client = %player;
		data = %data;
		_delete = true;
	});

	statsPost("api/Multiplayer/RecordMatch.php", %data);
}

function statsRecordMatchLine(%line) {
	fwrite("platinum/json/recordMatch.json", %line);

	%parsed = jsonParse(%line);

	$Master::Scores = 0;
	for (%i = 0; %i < %parsed.getSize(); %i ++) {
		%entry = %parsed.getEntry(%i);

		$Master::ScorePlayer[$Master::Scores] = %entry.username;
		$Master::ScoreRating[$Master::Scores] = %entry.rating;
		GameConnection::resolveName(%entry.username).rating = %entry.rating;
		$Master::ScoreChange[$Master::Scores] = %entry.change;
		$Master::Scores ++;
	}
	serverSendScores();

	%parsed.delete();
}

//-----------------------------------------------------------------------------

function statsVerifyPlayer(%client, %session) {
	if ($Server::Offline) {
		%client.completeValidation(true);
		return;
	}

	%req = statsPost("api/Multiplayer/VerifyPlayer.php", "username=" @ %client.getUsername() @ "&session=" @ %session);
	%req.client = %client;
}

function statsVerifyPlayerLine(%line, %req) {
	fwrite("platinum/json/verifyPlayer.json", %line);

	%parsed = jsonParse(%line);
	%req.client.rating = %parsed.rating;
	%req.client.displayName = %parsed.display;
	%req.client.id = %parsed.id;

	%req.client.completeValidation(true);
	updatePlayerList();

	%parsed.delete();
}

//-----------------------------------------------------------------------------

function statsRateMission(%mission, %rating) {
	%params = statsGetMissionIdentifier(%mission);
	%params = addParam(%params, "rating", %rating);

	statsPost("api/Mission/RateMission.php", %params);
}

function statsRateMissionLine(%line) {
	//We good
}

//-----------------------------------------------------------------------------

function statsRecordEventTrigger(%client, %trigger, %obj) {
	%req = statsPost("api/Event/RecordEventTrigger.php", "username=" @ %client.getUsername() @ "&trigger=" @ %trigger);
	%req.client = %client;
	%req.obj = %obj;
}

function statsRecordEventTriggerLine(%line, %req) {
	%req.obj.getDataBlock().onEventLine(%req.obj, %line, %req.client);
}
