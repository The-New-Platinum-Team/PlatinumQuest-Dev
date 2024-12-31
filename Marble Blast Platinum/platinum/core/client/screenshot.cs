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
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------


function formatImageNumber(%number) {
	if (%number < 10)
		%number = "0" @ %number;
	if (%number < 100)
		%number = "0" @ %number;
	if (%number < 1000)
		%number = "0" @ %number;
	if (%number < 10000)
		%number = "0" @ %number;
	return %number;
}


//----------------------------------------
function recordMovie(%movieName, %fps) {
	$timeAdvance = 1000 / %fps;
	$screenGrabThread = schedule("movieGrabScreen(" @ %movieName @ ", 0);", $timeAdvance);
}

function movieGrabScreen(%movieName, %frameNumber) {
	screenshot(%movieName @ formatImageNumber(%frameNumber) @ ".png");
	$screenGrabThread = schedule("movieGrabScreen(" @ %movieName @ "," @ %frameNumber + 1 @ ");", $timeAdvance);
}

function stopMovie() {
	cancel($screenGrabThread);
}


//----------------------------------------
$screenshotNumber = 0;

function doScreenShot(%val) {
	//Disable MP screenshot bug
	if ($Server::ServerType $= "MultiPlayer" && !$Editor::Opened)
		return;

	if (%val) {
		while (isFile($usermods @ "/data/screenshots/screenshot_" @ formatImageNumber($screenshotNumber) @ ".png"))
			$screenshotNumber ++;
		$pref::interior::showdetailmaps = false;
		screenShot($usermods @ "/data/screenshots/screenshot_" @ formatImageNumber($screenshotNumber) @ ".png");

		if ($CurrentGame $= "PlatinumQuest") {
			// PlatinumQuest does not have control+p. This will effectivly stop it.
			pauseGame();
		}

		scheduleIgnorePause(100, onNextFrameScreenshot);
	}
}

function onNextFrameScreenshot() {
	if ($CurrentGame $= "PlatinumQuest") {
		// PlatinumQuest does not have control+p. This will effectivly stop it.
		MessageBoxOk("Screenshot Taken", "Saved as \"screenshot_" @ formatImageNumber($screenshotNumber) @ ".png\" in the /screenshots/ directory.", "resumeGame();");
	}

	//Don't lag
	correctNextFrame();

	$screenshotNumber ++;
}


// bind key to take screenshots
GlobalActionMap.bind(keyboard, "ctrl p", doScreenShot);
GlobalActionMap.bindCmd(keyboard, "ctrl l", "", "doMiniShot();");
GlobalActionMap.bindCmd(keyboard, "ctrl b", "", "doBigShot();");
