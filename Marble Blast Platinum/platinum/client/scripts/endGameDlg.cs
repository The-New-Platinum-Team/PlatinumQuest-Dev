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

function EndGameDlg::onWake(%this) {
	if (ControllerGui.isJoystick())
		showControllerUI();

	EG_Continue.setVisible(true);

	// Showing credits first time if we haven't seen credits and the mission was Manic Bounce.
	if ($Game::Introduction || $Game::RunCredits) {
		EG_Replay.setVisible(false);
		EG_Continue.setPosition("175" SPC getWord(EG_Continue.position, 1));
		EG_Continue.text = "Next";
	} else {
		EG_Replay.setVisible(true);
		EG_Continue.setPosition("325" SPC getWord(EG_Continue.position, 1));
		EG_Continue.text = "Menu";
	}

	EG_Next.setVisible(!$Game::Introduction && !$Game::RunCredits);

	if (!isObject(%this.getNextLevel())) {
		EG_Next.setVisible(false);
	}

	%height = (getWord(EndGameDlg.extent, 1) + 25);
	if (ControllerGui.isJoystick()) {
		%height -= 25;
	}
	EndGameContent.setExtent(469 SPC %height);
	EndGameContent.setPosition(((getWord(RootGui.getExtent(), 0) - 1024) / 2) SPC (-14));

	EnterNameBox.setPosition((getWord(EndGameContent.position, 0) + 492) SPC (getWord(EG_TopTimesText.position, 1) + ($highScoreIndex * 30) + getWord(EndGameBox.position, 1) + 50));
	EnterNameAwesomeBox.setPosition((getWord(EndGameContent.position, 0) + 492) SPC (getWord(EG_TopTimesText.position, 1) + ($highScoreIndex * 30) + getWord(EndGameBox.position, 1) + 50));

	//This is set to false for the credits, so let's just make it true here
	EG_Replay.setActive(true);
}

function EndGameDlg::end(%this) {
	//If we're waiting to end a recording, do that before anything else
	if (recordEnd("EndGameDlg.end();")) {
		return;
	}
	//Don't record the next level unless they ask
	$Game::Record = false;

	if ($Game::Introduction) {
		//Show a message or something
		menuOnPostIntroduction();
	} else {
		menuMissionExit();
	}
}

function EndGameDlg::restart(%this) {
	//If we're waiting to end a recording, do that before anything else
	if (recordEnd("EndGameDlg.restart();")) {
		return;
	}

	restartLevel(true);
	PlayGui.positionMessageHud();

	if (ControllerGui.isJoystick())
		hideControllerUI();
}

function EndGameDlg::getNextLevel(%this) {
	if (strStr(PlayMissionGui.getMissionInfo().file, "platinum/data/missions/marbleland/") == 0) {
		return;
	}

	//Load next
	%pmg = PlayMissionGui;
	%attempts = 0;
	while (%attempts < 10000) {
		%attempts++;

		%list = %pmg.getMissionList($CurrentGame, $MissionType);
		%pmg.selectedIndex ++;

		if (%pmg.selectedIndex >= %list.getSize()) {
			devecho("Next: End of list " @ $MissionType);
			//Next list
			%diffs = %pmg.getDifficultyList($CurrentGame);
			%diff = $MissionType;
			for (%i = 0; %i < getRecordCount(%diffs); %i ++) {
				%record = getRecord(%diffs, %i);
				if (getField(%record, 0) $= %diff) {
					%found = true;
					break;
				}
			}
			if (!%found) {
				//Unknown difficulty?
				devecho("Next: Can't find difficulty");
				return;
			}
			%next = getField(getRecord(%diffs, %i + 1), 0);
			if (%next $= "") {
				devecho("Next: Out of missions");
				return;
			}

			//Select the next difficulty
			%pmg.setMissionType(%next);
			%pmg.selectedIndex = 0;
			devecho("Next: Trying list " @ $MissionType);
			%list = %pmg.getMissionList($CurrentGame, %next);
		}

		%mission = %list.getEntry(%pmg.selectedIndex);
		devecho("Next: Found mission " @ %mission.name);
		devecho("Next: Can display: " @ Unlock::canDisplayMission(%mission));
		devecho("Next: Can play: " @ Unlock::canPlayMission(%mission));

		if (Unlock::canDisplayMission(%mission) && Unlock::canPlayMission(%mission))
			break;
	}
	devecho("Next: Final choice is " @ %mission.name);

	return %mission;
}


function EndGameDlg::next(%this) {
	//If we're waiting to end a recording, do that before anything else
	if (recordEnd("EndGameDlg.next();")) {
		return;
	}

	//Apparently you can call this from the intro
	if ($Game::Introduction) {
		menuOnPostIntroduction();
		return;
	}

	%mission = %this.getNextLevel();
	if (isObject(%mission)) {
		$Client::NextMission = %mission;

		%file = %mission.file;
		%pmg.setMissionByIndex(%pmg.selectedIndex);
		activateMenuHandler(NextLevel);
		menuLoadStartMission(%file);

		//So we have these ready at the end screen for the next level
		if (lb()) {
			statsGetPersonalTopScores(%mission);
		}
	} else {
		%this.end();
	}
}

function NextLevel_StartLoading() {
	LoadingGui.setProgress("Loading Next Level...", 0, 1, true);
}

function NextLevel_LoadProgress(%progress) {
	LoadingGui.setProgress("Loading Next Level...", %progress, 1);
}

function NextLevel_MissionLoaded() {
	deactivateMenuHandler(NextLevel);
}

function NextLevel_MissionLoadFailed() {
	deactivateMenuHandler(NextLevel);
}

