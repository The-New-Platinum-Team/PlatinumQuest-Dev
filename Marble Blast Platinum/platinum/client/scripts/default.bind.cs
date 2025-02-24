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

if (isObject(MoveMap))
	MoveMap.delete();
new ActionMap(MoveMap);

if (isObject(JoystickMap))
	JoystickMap.delete();
new ActionMap(JoystickMap);

if (isObject(demoMap))
	demoMap.delete();
new ActionMap(demoMap);

demoMap.bindCmd(keyboard, "escape", "", "playbackCancel();");
demoMap.bind(keyboard, "alt c", replayToggleCamera);


$Controller::ValidAxes = "xaxis yaxis zaxis rxaxis ryaxis rzaxis";
$Controller::ValidActions = "Alt1 Alt2 Alt3 Alt4 Alt5 Alt6 Cancel DDown DLeft Down DRight DUp LB Left LS RB Right RS Select Up";

function loadJoystickConfiguration(%name) {
	%files[0] = expandFilename("~/client/config/" @ %name @ "." @ $platform @ ".json");
	%files[1] = expandFilename("~/client/config/" @ %name @ ".json");

	%conts = "";
	%struct = -1;

	//Load the first file that works
	for (%i = 0; %files[%i] !$= ""; %i ++) {
		%file = %files[%i];
		if (isFile(%file)) {
			%conts = fread(%file);
			%struct = jsonParse(%conts);

			if (isObject(%struct)) {
				break;
			} else {
				%conts = "";
				%struct = -1;
				error("Invalid format in joystick configuration file: " @ %file);
			}
		}
	}

	//Nothing worked?
	if (%conts $= "" || !isObject(%struct)) {
		error("Could not load joystick configuration file for map " @ %name);

		for (%i = 0; %files[%i] !$= ""; %i ++) {
			error("Tried " @ %files[%i]);
		}
		return;
	}

	echo("Loading joystick configuration: " @ %file);

	//Create axis virtualization mapping
	%mapping = joystickAddMap();
	for (%i = 0; %i < %struct.axes.getSize(); %i ++) {
		%axis = %struct.axes.getEntry(%i);
		if (%axis.axis !$= "") {
			if (findWord($Controller::ValidAxes, %axis.axis) == -1) {
				error("Invalid axis " @ %axis.axis @ " in joystick configuration file: " @ %file);
				echo("Pick one of " @ $Controller::ValidAxes);
			} else {
				joystickMapSetAxis(%mapping, %i, %axis.axis);
				devecho("Axis " @ %i @ " => " @ %axis.axis);

				if (%axis.name !$= "") {
					devecho("Axis " @ %axis.axis @ " => " @ %axis.name);
					$Controller::ButtonName[%name, %axis.axis] = %axis.name;
				}
			}
		}
	}
	$JoystickMap[%name] = %mapping;

	//Load button actions
	for (%i = 0; %i < %struct.buttons.getSize(); %i ++) {
		%button = %struct.buttons.getEntry(%i);
		%bind = "button" @ %i;

		if (%button.action1 !$= "") {
			if (findWord($Controller::ValidActions, %button.action1) == -1) {
				error("Invalid action " @ %button.action1 @ " in joystick configuration file: " @ %file);
				echo("Pick one of " @ $Controller::ValidActions);
			} else {
				$Controller::Action1[%name, %bind] = %button.action1;
				devecho("Button " @ %i @ " => 1: " @ %button.action1);
			}
		}
		if (%button.action2 !$= "") {
			if (findWord($Controller::ValidActions, %button.action2) == -1) {
				error("Invalid action " @ %button.action2 @ " in joystick configuration file: " @ %file);
				echo("Pick one of " @ $Controller::ValidActions);
			} else {
				$Controller::Action2[%name, %bind] = %button.action2;
				devecho("Button " @ %i @ " => 2: " @ %button.action2);
			}
		}
		if (%button.name !$= "") {
			devecho("Button " @ %i @ " => " @ %button.name);
			$Controller::ButtonName[%name, %bind] = %button.name;
		}
	}

	//Load bitmap mapping
	%fields = %struct.bitmaps.getDynamicFieldList();
	for (%i = 0; %i < getFieldCount(%fields); %i ++) {
		%key = getField(%fields, %i);
		%bitmap = %struct.bitmaps.getFieldValue(%key);

		$Controller::ButtonMap[%name, %key] = %bitmap;
		devecho("Bitmap " @ %key @ " => " @ %bitmap);
	}

	devecho(%struct);
}

loadJoystickConfiguration("default");
loadJoystickConfiguration("xbox360");
loadJoystickConfiguration("xboxone");
loadJoystickConfiguration("ps4");

//Activate the correct virtualization map
if (isJoystickDetected()) {
	echo("Found a joystick of type " @ getJoystickName(0) @ ". Activating axis mapping.");
	joystickMapActivate($JoystickMap[getJoystickName(0)]);
}

//-----------------------------------------------------------------------------
// Bind Defaults
//-----------------------------------------------------------------------------

$Bind::Defaults = 0;
$Bind::Joy::Defaults = 0;

function setDefaultBind(%device, %key, %command) {
	MoveMap.bind(%device, %key, %command);
	$Bind::Default[$Bind::Defaults] = 0 TAB %device TAB %key TAB %command;
	$Bind::Defaults ++;
}

function setDefaultBindCmd(%device, %key, %make, %break) {
	MoveMap.bindCmd(%device, %key, %make, %break);
	$Bind::Default[$Bind::Defaults] = 1 TAB %device TAB %key TAB %make TAB %break;
	$Bind::Defaults ++;
}

function joySetDefaultBind(%device, %key, %command) {
	JoystickMap.bind(%device, %key, %command);
	$Bind::Joy::Default[$Bind::Joy::Defaults] = 0 TAB %device TAB %key TAB %command;
	$Bind::Joy::Defaults ++;
}

function joySetDefaultBindCmd(%device, %key, %make, %break) {
	JoystickMap.bindCmd(%device, %key, %make, %break);
	$Bind::Joy::Default[$Bind::Joy::Defaults] = 1 TAB %device TAB %key TAB %make TAB %break;
	$Bind::Joy::Defaults ++;
}

function checkDefaultBinds() {
	for (%i = 0; %i < $Bind::Defaults; %i ++) {
		%binding = $Bind::Default[%i];
		if (getField(%binding, 0) == 0) {
			%device  = getField(%binding, 1);
			%action  = getField(%binding, 2);
			%command = getField(%binding, 3);
			if (MoveMap.getBinding(%command) $= "" && MoveMap.getCommand(%device, %action) $= "") {
				echo("Setting default bind for " @ %device SPC %action @ " to " @ %command);
				MoveMap.bind(%device, %action, %command);
			}
		} else {
			%device = getField(%binding, 1);
			%action = getField(%binding, 2);
			%make   = getField(%binding, 3);
			%break  = getField(%binding, 4);
			echo("Setting default bind for " @ %device SPC %action @ " to " @ %command);
			MoveMap.bindCmd(%device, %action, %make, %break);
		}
	}
	for (%i = 0; %i < $Bind::Joy::Defaults; %i ++) {
		%binding = $Bind::Joy::Default[%i];
		if (getField(%binding, 0) == 0) {
			%device  = getField(%binding, 1);
			%action  = getField(%binding, 2);
			%command = getField(%binding, 3);
			if (JoystickMap.getBinding(%command) $= "" && JoystickMap.getCommand(%device, %action) $= "") {
				echo("Setting default bind for " @ %device SPC %action @ " to " @ %command);
				JoystickMap.bind(%device, %action, %command);
			}
		} else {
			%device = getField(%binding, 1);
			%action = getField(%binding, 2);
			%make   = getField(%binding, 3);
			%break  = getField(%binding, 4);
			echo("Setting default bind for " @ %device SPC %action @ " to " @ %command);
			JoystickMap.bindCmd(%device, %action, %make, %break);
		}
	}
}

//------------------------------------------------------------------------------

function input_escapeFromGame(%val) {
	if ($Game::State $= "End" || (%val !$= "" && !%val))
		return;

	if ($playingDemo) {
		playbackCancel();
		return;
	}

	if (ControllerGui.isJoystick()) {
		showControllerUI();
	}

	// We don't want the disconnect DLG for LB peoples
	if ($Server::ServerType $= "SinglePlayer" || $LB::LoggedIn)  {
		// In single player, we'll pause the game while the dialog box is up.
		pauseGame();

		if ($Server::ServerType $= "Multiplayer") {
			if (!$Server::Lobby && !$Game::Pregame)  {
				RootGui.pushDialog(MPExitGameDlg);
				alxPlay(PauseMenuSfx);
			}
		} else {
			RootGui.pushDialog(ExitGameDlg);
			alxPlay(PauseMenuSfx);
			alxSetChannelVolume(1, 0); // main_gi
		}
	} else {
		MessageBoxYesNo("Disconnect", "Disconnect from the server?",
		                "disconnect(); hideControllerUI();", "hideControllerUI();");
	}
}

//------------------------------------------------------------------------------
// Movement
//------------------------------------------------------------------------------

function input_moveLeft(%val) {
	$mvLeftAction = $Game::MovementSpeedMultiplier * %val;

	if (%val)
		$Game::LastPressLR = "left";
	if ($Record::Recording) {
		recordWriteMovement(RecordFO);
	}
}

function input_moveRight(%val) {
	$mvRightAction = $Game::MovementSpeedMultiplier * %val;

	if (%val)
		$Game::LastPressLR = "right";
	if ($Record::Recording) {
		recordWriteMovement(RecordFO);
	}
}

function input_moveForward(%val) {
	if ($Game::2D && !$Editor::Opened)
		return;

	$mvForwardAction = $Game::MovementSpeedMultiplier * %val;
	if ($Record::Recording) {
		recordWriteMovement(RecordFO);
	}
}

function input_moveBackward(%val) {
	if ($Game::2D && !$Editor::Opened)
		return;

	$mvBackwardAction = $Game::MovementSpeedMultiplier * %val;
	if ($Record::Recording) {
		recordWriteMovement(RecordFO);
	}
}

//------------------------------------------------------------------------------
// Camera
//------------------------------------------------------------------------------

function input_turnLeft(%val) {
	$mvYawRightSpeed = %val * $Game::CameraSpeedMultiplier;
}

function input_turnRight(%val) {
	$mvYawLeftSpeed = %val * $Game::CameraSpeedMultiplier;
}

function input_panUp(%val) {
	$mvPitchDownSpeed = %val * $Game::CameraSpeedMultiplier;
}

function input_panDown(%val) {
	$mvPitchUpSpeed = %val * $Game::CameraSpeedMultiplier;
}

function input_yaw(%val) {
	$mvYaw += %val * $Game::CameraSpeedMultiplier;
	$cameraYaw += %val * $Game::CameraSpeedMultiplier;
}

function input_pitch(%val) {
	$mvPitch += %val * $Game::CameraSpeedMultiplier;
	$cameraPitch += %val * $Game::CameraSpeedMultiplier;
}

//-----------------------------------------------------------------------------
// Actions
//-----------------------------------------------------------------------------

function input_jump(%val) {
	$mvTriggerCount2 = %val;
}

function input_freelook(%val) {
	$freeLooking = %val;
}

function input_mouseFire(%val) {
	// must come before powerup locked so OOB click still works.
	commandToServer('MouseFire', %val);

	if (%val && !$powerupLocked) {
		$MP::MyMarble._mouseFire();
	}

	$mouseFire = %val;
	if (!$powerupLocked) {
		usePowerup(%val);
	}
}

//Helper method that passes use to the engine
function input_usePowerup(%val) {
	$mvTriggerCount0 = %val;
}

function input_useBlast(%val) {
	if (isCannonActive()) {
		// get out of cannon.
		commandToServer('Blast');
		return;
	}

	$useBlast = %val;

	if ($Client::FireballActive) {
		// If we fire blasted, don't do a blast as well.
		// Or else you will fly like a magical unicorn marble.
		if (fireballBlast())
			return;
	}

	// No blast if you are frozen for you!
	if ($Client::Frozen)
		return;

	if (!shouldEnableBlast())
		return;

	if (%val) {
		if ($MP::BlastValue >= (($Game::IsMode["challenge"] && $CurrentWeeklyChallenge.tripleBlast) ? 0.33 : $MP::BlastRequiredAmount) && MPMyMarbleExists() != -1) {
			performBlast();
		}
	}
}

function input_forceRespawn(%val) {
	cancel($respawnSchedule);
	if (!%val)
		$forceCheckpointRespawn = false;
	if ($Client::GameRunning && %val) {
		//Update your respawns prefs
		$pref::LevelRespawns[strreplace($Client::MissionFile, "lbmission", "mission")] ++;
		$pref::RespawnCount ++;

		if ($Server::ServerType $= "SinglePlayer") {
			//Close the end game window in case we do this during play
			hideControllerUI();
			ExitGameDlg.close();
			resumeGame();

			if (LocalClientConnection.checkpointed) {
				LocalClientConnection.respawnOnCheckpoint();
				$respawnSchedule = schedule(1000, 0, commandToServer, 'restartLevel');
				$forceCheckpointRespawn = true;
			} else {
				if ($playingDemo)
					return;
				//Rate limit
				if (getSimTime() - $Game::LastRespawn < 500)
					return;
				$Game::LastRespawn = getSimTime();

				restartLevel();
			}
		} else if ($MP::AllowQuickRespawn) {
			commandToServer('QuickRespawn');
			if ($Server::Hosting) {
				$respawnSchedule = schedule(3000, 0, commandToServer, 'restartLevel');
			}
		}
	}
}

function input_toggleSpectateModeType(%val) {
	if ($SpectateMode && %val) {
		toggleSpectateMode();
	}
}

function input_throwSnowball(%val) {
	if (%val) {
		if ($Game::IsMode["snowball"]) {
			commandToServer('ThrowSnowball', $MP::MyMarble.getCameraYaw() TAB $MP::MyMarble.getCameraPitch(), $MP::MyMarble.getPosition());
		}
	}
}

function input_displayScoreList(%val) {
	if ($Server::ServerType $= "MultiPlayer") {
		if (%val) {
			RootGui.pushDialog(MPScoresDlg);
		} else {
			RootGui.popDialog(MPScoresDlg);
		}
	}
}

function input_screenshotMode(%val) {
	//Hides all the PlayGui interface for Matan :3

	if (%val) {
		$pref::ScreenshotMode ++;
		//If we're not online don't bother making us cycle through the online-only option
		if (!lb() && $pref::ScreenshotMode == 1) {
			$pref::ScreenshotMode = 2;
		}
		$pref::ScreenshotMode %= 3;
		PlayGui.positionMessageHud();
	}
}

function input_toggleCoopView(%val) {
	if (%val) {
		// make -1 by default, as we inc right afterwards.
		if ($pref::ShowCoopView $= "")
			$pref::ShowCoopView = -1;

		$pref::ShowCoopView++;
		if (!isObject(ClientCoOpMarbleSimSet) || ClientCoOpMarbleSimSet.getCount() == 0 || $pref::ShowCoopView >= ClientCoOpMarbleSimSet.getCount()) {
			// make it -1. that will hide it.
			$pref::ShowCoopView = -1;
		}
	}
}

function input_toggleCamera(%val) {
	if ($Server::ServerType $= "Multiplayer" && %val && (!$MP::SpectateFull || $SpectateMode))
		commandToServer('Spectate');

	if ($playingDemo) {
		if (LocalClientConnection.getControlObject() == LocalClientConnection.camera) {
			replayToggleCamera(%val);
		}
		return;
	}

	if ($LB::LoggedIn)
		return;
	if (!$Editor::Opened)
		return;

	if (%val)
		commandToServer('ToggleCamera');
}

//-----------------------------------------------------------------------------
// Keyboard/Mouse Input
//-----------------------------------------------------------------------------

function moveLeft(%val) {
	if ($SpectateMode && !$SpectateFlying) {
		if (%val)
			pickPrevSpectator();
		return;
	}
	input_moveLeft(%val);
}

function moveRight(%val) {
	if ($SpectateMode && !$SpectateFlying) {
		if (%val)
			pickNextSpectator();
		return;
	}
	input_moveRight(%val);
}

function moveForward(%val) {
	input_moveForward(%val);
}

function moveBackward(%val) {
	input_moveBackward(%val);
}

function turnLeft(%val) {
	input_turnLeft(%val ? $Pref::Input::KeyboardTurnSpeed : 0);
}

function turnRight(%val) {
	input_turnRight(%val ? $Pref::Input::KeyboardTurnSpeed : 0);
}

function panUp(%val) {
	input_panUp(%val ? $Pref::Input::KeyboardTurnSpeed : 0);
}

function panDown(%val) {
	input_panDown(%val ? $Pref::Input::KeyboardTurnSpeed : 0);
}

function escapeFromGame(%val) {
	input_escapeFromGame(%val);
}

function jump(%val) {
	input_jump(%val);
}

function freelook(%val) {
	input_freelook(%val);
}

function mouseFire(%val) {
	input_mouseFire(%val);
}

function usePowerup(%val) {
	input_usePowerup(%val);
}

function useBlast(%val) {
	input_useBlast(%val);
}

function forceRespawn(%val) {
	input_forceRespawn(%val);
}

function toggleSpectateModeType(%val) {
	input_toggleSpectateModeType(%val);
}

function throwSnowball(%val) {
	input_throwSnowball(%val);
}

function displayScoreList(%val) {
	input_displayScoreList(%val);
}

function screenshotMode(%val) {
	input_screenshotMode(%val);
}

function toggleCoopView(%val) {
	input_toggleCoopView(%val);
}

function toggleCamera(%val) {
	input_toggleCamera(%val);
}

function getMouseAdjustAmount(%val) {
	// based on a default camera fov of 90'
	return ($pref::Input::MouseSensitivity * %val * ($cameraFov / 90) * 0.01);
}

function yaw(%val) {
	if ($pref::Input::InvertXAxis) {
		input_yaw(-getMouseAdjustAmount(%val));
	} else {
		input_yaw(getMouseAdjustAmount(%val));
	}
}

function pitch(%val) {
	if ($freelooking || $pref::Input::AlwaysFreeLook || isCannonActive()) {
		if ($pref::input::InvertYAxis) {
			input_pitch(-getMouseAdjustAmount(%val));
		} else {
			input_pitch(getMouseAdjustAmount(%val));
		}
	}
}

//-----------------------------------------------------------------------------
// Joystick movement and camera
//
// A few things to note:
// - Default dead zone is 0.23. If you set it to something less than this you
//   may start moving unexpectedly (and slowly)
// - Movement speed is multiplied by 1.68 so diagonal movement works.
//   This is slightly more than what is required for diagonal movement with
//   the sticks perfectly diagonal.
//-----------------------------------------------------------------------------

function isDeadZone(%val) {
	return mAbs(%val) < $pref::Input::Joystick::DeadZone;
}

$joyMoveX = 0;
$joyMoveY = 0;

// Move marble X
function joy_moveX(%val) {
	if (isDeadZone(%val))
		%val = 0;

	//Normalize to a circle before applying diagonal movement fix
	$joyMoveX = %val; //So we can access from the other move function
	if (VectorLen($joyMoveX SPC $joyMoveY SPC 0) > 1) {
		%val = getWord(VectorNormalize($joyMoveX SPC $joyMoveY SPC 0), 0);
	}

	if (%val < 0) {
		input_moveLeft(-%val * 1.68);
		input_moveRight(0);
	} else if (%val > 0) {
		input_moveLeft(0);
		input_moveRight(%val * 1.68);
	} else {
		input_moveLeft(0);
		input_moveRight(0);
	}
}

// Move marble Y
function joy_moveY(%val) {
	if (isDeadZone(%val))
		%val = 0;

	//Normalize to a circle before applying diagonal movement fix
	$joyMoveY = %val; //So we can access from the other move function
	if (VectorLen($joyMoveX SPC $joyMoveY SPC 0) > 1) {
		%val = getWord(VectorNormalize($joyMoveX SPC $joyMoveY SPC 0), 1);
	}

	if (%val < 0) {
		input_moveForward(-%val * 1.68);
		input_moveBackward(0);
	} else if (%val > 0) {
		input_moveForward(0);
		input_moveBackward(%val * 1.68);
	} else {
		input_moveForward(0);
		input_moveBackward(0);
	}
}

// Move camera X
function joy_cameraX(%val) {
	if (isDeadZone(%val))
		%val = 0;

	if (%val < 0) {
		input_turnLeft(-%val * $pref::Input::Joystick::CameraSpeedX);
		input_turnRight(0);
	} else if (%val > 0) {
		input_turnLeft(0);
		input_turnRight(%val * $pref::Input::Joystick::CameraSpeedX);
	} else {
		input_turnLeft(0);
		input_turnRight(0);
	}
}

// Move camera Y
function joy_cameraY(%val) {
	//If not free look, then snap pitch back when we're not cannon
	if (!$pref::Input::AlwaysFreeLook && !$freeLooking && !isCannonActive()) {
		if (isDeadZone(%val)) {
			//Go back
			%destPitch = (0.45 + $marblePitch) / 2;
		} else if (%val < 0) {
			%val = (%val * 0.4);
			%destPitch = (%val * 2) + 0.45;
		} else {
			%val = (%val * 0.4);
			%destPitch = (2 * %val) + 0.45;
		}
		input_pitch(%destPitch - $marblePitch);
	} else {
		//Otherwise we have a free camera
		if (isDeadZone(%val))
			%val = 0;
		if (%val < 0) {
			input_panUp(-%val * $pref::Input::Joystick::CameraSpeedY);
			input_panDown(0);
		} else if (%val > 0) {
			input_panUp(0);
			input_panDown(%val * $pref::Input::Joystick::CameraSpeedY);
		} else {
			input_panUp(0);
			input_panDown(0);
		}
	}
}

//-----------------------------------------------------------------------------
// Actual joystick input functions, these change behavior depending on which
// you have set to be movement.
//-----------------------------------------------------------------------------

// Left stick X
function moveXAxis(%val) {
	%invert = $pref::Input::InvertJoystickLX ? -1 : 1;

	if ($pref::Input::Joystick::RightStickMovement) {
		joy_cameraX(%val * %invert);
	} else {
		joy_moveX(%val * %invert);
	}
}
// Left stick Y
function moveYAxis(%val) {
	%invert = $pref::Input::InvertJoystickLY ? -1 : 1;

	if ($pref::Input::Joystick::RightStickMovement) {
		joy_cameraY(%val * %invert);
	} else {
		joy_moveY(%val * %invert);
	}
}
// Right stick X
function moveYawAxis(%val) {
	%invert = $pref::Input::InvertJoystickRX ? -1 : 1;

	if ($pref::Input::Joystick::RightStickMovement) {
		joy_moveX(%val * %invert);
	} else {
		joy_cameraX(%val * %invert);
	}
}
// Right stick Y
function movePitchAxis(%val) {
	%invert = $pref::Input::InvertJoystickRY ? -1 : 1;

	if ($pref::Input::Joystick::RightStickMovement) {
		joy_moveY(%val * %invert);
	} else {
		joy_cameraY(%val * %invert);
	}
}

//-----------------------------------------------------------------------------

//Convert from either a joystick button or LT/RT axis to a true/false value
function joyConvertButtonOrAxis(%val) {
	//If you use LT or RT then this is a float from -1 to 1
	if (%val != 1 && %val != 0) {
		%val = (%val > 0);
	}
	return %val;
}

function joyJump(%val) {
	input_jump(joyConvertButtonOrAxis(%val));
}

function joyMouseFire(%val) {
	input_mouseFire(joyConvertButtonOrAxis(%val));
}

function joyFreelook(%val) {
	input_freelook(joyConvertButtonOrAxis(%val));
}

function joyUseBlast(%val) {
	input_useBlast(joyConvertButtonOrAxis(%val));
}

function joyEscapeFromGame(%val) {
	input_escapeFromGame(joyConvertButtonOrAxis(%val));
}

function joyRadarSwitch(%val) {
	radarSwitch(joyConvertButtonOrAxis(%val));
}

function joyForceRespawn(%val) {
	input_forceRespawn(joyConvertButtonOrAxis(%val));
}

function joyToggleSpectateModeType(%val) {
	input_toggleSpectateModeType(joyConvertButtonOrAxis(%val));
}

function joyThrowSnowball(%val) {
	input_throwSnowball(joyConvertButtonOrAxis(%val));
}

function joyDisplayScoreList(%val) {
	input_displayScoreList(joyConvertButtonOrAxis(%val));
}

function joyScreenshotMode(%val) {
	input_screenshotMode(joyConvertButtonOrAxis(%val));
}

function joyToggleCoopView(%val) {
	input_toggleCoopView(joyConvertButtonOrAxis(%val));
}

function joyToggleCamera(%val) {
	input_toggleCamera(joyConvertButtonOrAxis(%val));
}

function joyDITrigger(%val) {
	//Bullshit piece of bullshit where LT and RT are on one axis

	//We don't have to support this
	if (!isSharedTriggers(0))
		return;

	if (%val > 0) {
		%axis = "Left";
		%val = (%val * 2) - 1;
	} else {
		%axis = "Right";
		%val = (-%val * 2) - 1;
	}

	//Nothing set for this trigger
	if ($pref::Input::TriggerAction[%axis] $= "")
		return;

	call($pref::Input::TriggerAction[%axis], %val);
}

//------------------------------------------------------------------------------
// Default bindings
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// Xbox360 controller specific gamepad buttons and stuff so it works perfect
// button0: a
// button1: b
// button2: x
// button3: y
// button4: lb
// button5: rb
// button6: ls      windows: back
// button7: rs      windows: start
// button8: start   windows: LS
// button9: back    windows: RS
// button10: guide
// button11: dpad_up
// button12: dpad_down
// button13: dpad_left
// button14: dpad_right
//
// Can't bind LT and RT without a mess involving DirectInput, so don't use either
// of them as default binds.
//------------------------------------------------------------------------------

joySetDefaultBind(joystick0, "xaxis",    moveXAxis);
joySetDefaultBind(joystick0, "yaxis",    moveYAxis);
joySetDefaultBind(joystick0, "rxaxis",   moveYawAxis);
joySetDefaultBind(joystick0, "ryaxis",   movePitchAxis);
joySetDefaultBind(joystick0, "button0",  joyJump);
joySetDefaultBind(joystick0, "button1",  joyMouseFire);
joySetDefaultBind(joystick0, "button2",  joyUseBlast);
joySetDefaultBind(joystick0, "button11", toggleChatHUD);
joySetDefaultBind(joystick0, "button14", togglePrivateChatHUD);
joySetDefaultBind(joystick0, "button12", toggleTeamChatHUD);
joySetDefaultBind(joystick0, "button3",  joyFreelook);
joySetDefaultBind(joystick0, "button5",  joyUseBlast1);
joySetDefaultBind(joystick0, "button4",  joyThrowSnowball);
//Windows is cool
joySetDefaultBind(joystick0, ($platform $= "windows" ? "button8" : "button6"), joyToggleCamera); //LS
joySetDefaultBind(joystick0, ($platform $= "windows" ? "button9" : "button7"), joyRadarSwitch); //RS
joySetDefaultBind(joystick0, ($platform $= "windows" ? "button7" : "button8"), joyEscapeFromGame); //Start
joySetDefaultBind(joystick0, ($platform $= "windows" ? "button6" : "button9"), joyForceRespawn); //Back
//May break if you have DI
joySetDefaultBind(joystick0, "zaxis",    joyJump1);
joySetDefaultBind(joystick0, "rzaxis",   joyMouseFire1);
//In case you unplug your joystick and need to quit
joySetDefaultBindCmd(keyboard, "escape", "", "escapeFromGame();");

if (isSharedTriggers(0)) {
	if (JoystickMap.getCommand("joystick0", "zaxis") !$= "joyDITrigger") {
		$pref::Input::TriggerAction["Left"] = JoystickMap.getCommand("joystick0", "zaxis");
		$pref::Input::TriggerAction["Right"] = JoystickMap.getCommand("joystick0", "rzaxis");
		warn("Shared triggers on joystick and no shared trigger function found.");
		warn("Current config set:");
		warn("Left Trigger: " @ $pref::Input::TriggerAction["Left"]);
		warn("Right Trigger: " @ $pref::Input::TriggerAction["Right"]);
		JoystickMap.bind("joystick0", "zaxis", "joyDITrigger");
		JoystickMap.unbind("joystick0", "zaxis");
	}
}

setDefaultBind(mouse,    "xaxis",     yaw);
setDefaultBind(mouse,    "yaxis",     pitch);
setDefaultBind(mouse,    "button0",   mouseFire);
setDefaultBind(mouse,    "button1",   useBlast);
setDefaultBind(keyboard, "t",         toggleChatHUD);
setDefaultBind(keyboard, "p",         togglePrivateChatHUD);
setDefaultBind(keyboard, "f",         toggleTeamChatHUD);
setDefaultBind(keyboard, "c",         toggleSpectateModeType);
setDefaultBind(keyboard, "a",         moveleft);
setDefaultBind(keyboard, "d",         moveright);
setDefaultBind(keyboard, "w",         moveforward);
setDefaultBind(keyboard, "s",         movebackward);
setDefaultBind(keyboard, "space",     jump);
setDefaultBind(keyboard, "up",        panUp);
setDefaultBind(keyboard, "down",      panDown);
setDefaultBind(keyboard, "left",      turnLeft);
setDefaultBind(keyboard, "right",     turnRight);
setDefaultBind(keyboard, "backspace", forceRespawn);
setDefaultBind(keyboard, "e",         useBlast1);
setDefaultBind(keyboard, "q",         throwSnowball);
setDefaultBind(keyboard, "o",         displayScoreList);
setDefaultBind(keyboard, "tab",       radarSwitch);
setDefaultBind(keyboard, "x",         popupExtendedHelp);
setDefaultBind(keyboard, "v",         toggleCoopView);
setDefaultBindCmd(keyboard, "escape", "", "escapeFromGame();");

//Keyboard
$Input::Function[0] = "moveLeft";
$Input::Function[1] = "moveRight";
$Input::Function[2] = "moveForward";
$Input::Function[3] = "moveBackward";
$Input::Function[4] = "turnLeft";
$Input::Function[5] = "turnRight";
$Input::Function[6] = "panUp";
$Input::Function[7] = "panDown";
$Input::Function[8] = "escapeFromGame";
$Input::Function[9] = "jump";
$Input::Function[10] = "freelook";
$Input::Function[11] = "mouseFire";
$Input::Function[12] = "usePowerup";
$Input::Function[13] = "useBlast";
$Input::Function[14] = "forceRespawn";
$Input::Function[15] = "toggleSpectateModeType";
$Input::Function[16] = "throwSnowball";
$Input::Function[17] = "displayScoreList";
$Input::Function[18] = "screenshotMode";
$Input::Function[19] = "toggleCoopView";
$Input::Function[20] = "toggleCamera";
$Input::Function[21] = "yaw";
$Input::Function[22] = "pitch";
//Joystick
$Input::Function[23] = "moveXAxis";
$Input::Function[24] = "moveYAxis";
$Input::Function[25] = "moveYawAxis";
$Input::Function[26] = "movePitchAxis";
$Input::Function[27] = "joyJump";
$Input::Function[28] = "joyMouseFire";
$Input::Function[29] = "joyFreelook";
$Input::Function[30] = "joyUseBlast";
$Input::Function[31] = "joyEscapeFromGame";
$Input::Function[32] = "joyRadarSwitch";
$Input::Function[33] = "joyForceRespawn";
$Input::Function[34] = "joyToggleSpectateModeType";
$Input::Function[35] = "joyThrowSnowball";
$Input::Function[36] = "joyDisplayScoreList";
$Input::Function[37] = "joyScreenshotMode";
$Input::Function[38] = "joyToggleCoopView";
$Input::Function[39] = "joyToggleCamera";

for ($i = 0; $Input::Function[$i] !$= ""; $i ++) {
	//Can you not have more than 4 buttons per bind please
	for ($j = 1; $j < 4; $j ++) {
		eval("function " @ $Input::Function[$i] @ $j @ "(%val) { " @ $Input::Function[$i] @ "(%val); }");
	}
}


$Input::JoyMap["moveLeft"]               = "moveXAxis";
$Input::JoyMap["moveRight"]              = "moveXAxis";
$Input::JoyMap["moveForward"]            = "moveYAxis";
$Input::JoyMap["moveBackward"]           = "moveYAxis";
$Input::JoyMap["turnLeft"]               = "moveYawAxis";
$Input::JoyMap["turnRight"]              = "moveYawAxis";
$Input::JoyMap["panUp"]                  = "movePitchAxis";
$Input::JoyMap["panDown"]                = "movePitchAxis";
$Input::JoyMap["escapeFromGame"]         = "joyEscapeFromGame";
$Input::JoyMap["jump"]                   = "joyJump";
$Input::JoyMap["freelook"]               = "joyFreelook";
$Input::JoyMap["mouseFire"]              = "joyMouseFire";
$Input::JoyMap["usePowerup"]             = "joyMouseFire";
$Input::JoyMap["useBlast"]               = "joyUseBlast";
$Input::JoyMap["forceRespawn"]           = "joyForceRespawn";
$Input::JoyMap["toggleSpectateModeType"] = "joyToggleSpectateModeType";
$Input::JoyMap["throwSnowball"]          = "joyThrowSnowball";
$Input::JoyMap["displayScoreList"]       = "joyDisplayScoreList";
$Input::JoyMap["screenshotMode"]         = "joyScreenshotMode";
$Input::JoyMap["toggleCoopView"]         = "joyToggleCoopView";
$Input::JoyMap["toggleCamera"]           = "joyToggleCamera";
$Input::JoyMap["yaw"]                    = "moveYawAxis";
$Input::JoyMap["pitch"]                  = "movePitchAxis";


//------------------------------------------------------------------------------
// Cheat and helper functions, these aren't really suitable for having joystick
// binds.
//------------------------------------------------------------------------------

function dropCameraAtPlayer(%val) {
	if ($LB::LoggedIn)
		return;

	if (%val)
		commandToServer('dropCameraAtPlayer');
}

function dropPlayerAtCamera(%val) {
	if ($LB::LoggedIn)
		return;

	if (%val)
		commandToServer('DropPlayerAtCamera');
}

function reloadConfig(%val) {
	if (!%val) {
		exec($usermods @ "/client/scripts/default.bind.cs");
		exec($usermods @ "/client/config.cs");
		checkDefaultBinds();

		if (RootGui.getContent().getName() $= "PlayGui") {
			MoveMap.push();
			JoystickMap.push();
		}

		ASSERT("Keybindings Reloaded", "Reloaded all keybinds from config.cs");
	}
}

setDefaultBind(keyboard, "alt c", toggleCamera);
setDefaultBind(keyboard, "F8", dropCameraAtPlayer);
setDefaultBind(keyboard, "F7", dropPlayerAtCamera);

//------------------------------------------------------------------------------
// Misc.
//------------------------------------------------------------------------------

function trace2(%toggle) {
	if (!%toggle)
		trace(!$tracing);
}
//GlobalActionMap.bind(keyboard, "ctrl T", "trace2");

GlobalActionMap.bindCmd(keyboard, "ctrl F12", "", "savePrefs(true);");
GlobalActionMap.bindCmd(keyboard, "alt enter", "", "pauseMusic();toggleFullScreen();resumeMusic();");
GlobalActionMap.bind(keyboard, "ctrl F9", reloadConfig);
