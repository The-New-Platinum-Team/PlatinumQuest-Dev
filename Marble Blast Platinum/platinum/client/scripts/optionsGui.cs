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

function OptionsGui::setTab(%this, %tab) {
	OptionsGraphicsPanel.setVisible(%tab $= "Graphics");
	OptionsGameplayPanel.setVisible(%tab $= "Gameplay");
	OptionsInputPanel.setVisible(%tab $= "Input");
	OptionsAudioPanel.setVisible(%tab $= "Audio");
	OptionsOnlinePanel.setVisible(%tab $= "Online");

	OptionsGraphicsButton.setValue(%tab $= "Graphics");
	OptionsGameplayButton.setValue(%tab $= "Gameplay");
	OptionsInputButton.setValue(%tab $= "Input");
	OptionsAudioButton.setValue(%tab $= "Audio");
	OptionsOnlineButton.setValue(%tab $= "Online");

	%this.tab = %tab;

	//Input does its own thing
	if (%tab $= "Input") {
		%this.generateHotkeysList();
	} else {
		%this.buildTab(%tab);
	}

	switch$ (%tab) {
	case "Graphics":
		%this.commandLT = OptionsOnlineButton.command;
		%this.commandRT = OptionsGameplayButton.command;
		%this.commandNameLT = "Online Tab";
		%this.commandNameRT = "Gameplay Tab";
	case "Gameplay":
		%this.commandLT = OptionsGraphicsButton.command;
		%this.commandRT = OptionsInputButton.command;
		%this.commandNameLT = "Graphics Tab";
		%this.commandNameRT = "Input Tab";
	case "Input":
		%this.commandLT = OptionsGameplayButton.command;
		%this.commandRT = OptionsAudioButton.command;
		%this.commandNameLT = "Gameplay Tab";
		%this.commandNameRT = "Audio Tab";
	case "Audio":
		%this.commandLT = OptionsInputButton.command;
		%this.commandRT = OptionsOnlineButton.command;
		%this.commandNameLT = "Input Tab";
		%this.commandNameRT = "Online Tab";
	case "Online":
		%this.commandLT = OptionsAudioButton.command;
		%this.commandRT = OptionsGraphicsButton.command;
		%this.commandNameLT = "Audio Tab";
		%this.commandNameRT = "Graphics Tab";
	}

	if (ControllerGui.isJoystick()) {
		ControllerGui.updateButtons();
	}
}

function OptionsGui::show(%this, %content) {
	%this.content = %content;
	if (%content $= "exit") {
		Canvas.pushDialog(%this);
	} else {
		RootGui.setContent(%this);
	}
}

// redoing the Home button because this
//       gui is now used for lb support
function OptionsGui::back(%this) {
	if (%this.content $= "exit") {
		//Make sure we can still play
		if ($playingDemo) {
			demoMap.push();
		} else {
			//Don't enable JoystickMap here cause the exit screen needs to work
			if (!ControllerGui.isJoystick()) {
				MoveMap.push();
			}
		}

		Canvas.popDialog(%this);
	} else {
		%gui = $LB::LoggedIn ? "LBChatGui" : "MainMenuGui";
		RootGui.setContent(%gui);
	}
}

function OptionsGui::onWake(%this, %dontDiscard) {
	buildResolutionList();

	%this.setTab("Graphics");

	//Activate the correct virtualization map
	if (isJoystickDetected()) {
		echo("Found a joystick of type " @ getJoystickName(0) @ ". Activating axis mapping.");
		joystickMapActivate($JoystickMap[getJoystickName(0)]);
	}

	$Options::TexturePackDirty = 0;
}

function OptionsGui::apply(%this) {
	updateFrameController();
	savePrefs();

	MoveMap.save("~/client/config.cs");
	JoystickMap.save("~/client/config.cs", true); //Append

	flushInteriorRenderBuffers();
	cleanupReflectiveMarble();

	%newDisplay = ($pref::Video::displayDevice !$= getDisplayDeviceName());
	%newRes = ($pref::Video::resolution !$= getResolution());

	if (%newDisplay) {
		disablePostFX();
		disableBlur();
		disableShaders();
		reloadDts();
		setDisplayDevice($pref::Video::displayDevice,
		                 firstWord($pref::Video::resolution),
		                 getWord($pref::Video::resolution, 1),
		                 getWord($pref::Video::resolution, 2),
		                 $pref::Video::fullScreen);
		//OptionsGui::deviceDependent( %this );
	} else if (%newRes) {
		disablePostFX();
		disableBlur();
		disableShaders();
		reloadDts();
		setScreenMode(firstWord($pref::Video::resolution),
		              getWord($pref::Video::resolution, 1),
		              getWord($pref::Video::resolution, 2),
		              $pref::Video::fullScreen);
	} else if ($pref::Video::fullScreen != isFullScreen()) {
		disablePostFX();
		disableBlur();
		disableShaders();
		reloadDts();
		toggleFullScreen();
	}
	if ($pref::Video::AntiAliasing != $OldConfig::Video::AntiAliasing) {
		if ($platform $= "macos" && !(%newDisplay || %newRes)) {
			disableShaders();
			disablePostFX();

			//Need to update the screen mode on OSX to get a new AGL context with the correct number of sample buffers.
			// However, if we just use the same settings Torque will optimize out our call. So just use this nasty hack.
			%oldBits = getWord($pref::Video::Resolution, 2);
			%otherBits = (%oldBits == 16 ? 32 : 16);
			//Sorry
			setScreenMode(firstWord($pref::Video::resolution),
			              getWord($pref::Video::resolution, 1),
			              %otherBits,
			              $pref::Video::fullScreen);
			setScreenMode(firstWord($pref::Video::resolution),
			              getWord($pref::Video::resolution, 1),
			              %oldBits,
			              $pref::Video::fullScreen);
		}
	}

	if ($Options::TexturePackDirty) {
		//Unload everything first
		for (%i = 0; %i < ActiveTexturePacks.getSize(); %i ++) {
			%pack = ActiveTexturePacks.getEntry(%i);
			unloadTexturePack(%pack);
		}
		ActiveTexturePacks.clear();
		//Then reload everything
		for (%i = 0; $pref::Video::TexturePack[%i] !$= ""; %i ++) {
			activateTexturePack($pref::Video::TexturePack[%i]);
		}
		reloadTexturePacks();
		$Options::TexturePackDirty = 0;
	}
	Canvas.repaint();

	applyGraphicsQuality();

	// Instead of pausing and resuming always, let's not bother the player with a music reset if it's not necessary.
	%playing = alxIsPlaying($currentMusicHandle);
	if (OptionsGui.messedWithMusicVolume) {
		if (%playing && Opt_musicVolume_getValue() < 10) {
			pauseMusic();
		} else if (!%playing && Opt_musicVolume_getValue() > 10) {
			resumeMusic();
		}
		OptionsGui.messedWithMusicVolume = false;
	}
}

//Functions for applyGraphicsQuality and updateFrameController moved to core/client/canvas.cs

function buildResolutionList() {
	// Code borrowed from Torque Demo: too lazy to figure it out myself. Sorry GG!
	if (!isObject(OptResolutions)) {
		Array(OptResolutions);
	} else {
		OptResolutions.clear();
	}

	%resList = getResolutionList($pref::Video::displayDevice);
	%resCount = getFieldCount(%resList);
	%deskRes = getDesktopResolution();

	//Extra resolutions
	%resList = %resList TAB "1024 768";
	%resCount ++;
	%resList = %resList TAB "1280 720";
	%resCount ++;
	%resList = %resList TAB "1920 1080";
	%resCount ++;

	for (%i = 0; %i < %resCount; %i++) {
		%res = getWords(getField(%resList, %i), 0, 1);

		if (!$pref::Video::fullScreen) {
			// Here they skip resolutions above your desktop res, in case you're playing windowed. Nice GG. Nice.
			if (firstWord(%res) >= firstWord(%deskRes))
				continue;
			if (getWord(%res, 1) >= getWord(%deskRes, 1))
				continue;
		}

		//Lower Bound
		if (firstWord(%res) < 1024 || getWord(%res, 1) < 768)
			continue;

		// yea add only if its not thar already man.
		if (!OptResolutions.containsEntry(%res)) {
			OptResolutions.addEntry(%res);
		}
	}
	OptResolutions.sort(sortResolution);
}

function sortResolution(%a, %b) {
	if (getWord(%a, 0) != getWord(%b, 0)) {
		return getWord(%a, 0) < getWord(%b, 0);
	}
	return getWord(%a, 1) < getWord(%b, 1);
}

//-----------------------------------------------------------------------------

function GuiSliderCtrl::getFormattedValue(%this, %min, %max) {
	//Raw value
	%value = %this.getValue();
	%thisMin = getWord(%this.range, 0);
	%thisMax = getWord(%this.range, 1);
	//In case you're lazy
	if (%min $= "") %min = %thisMin;
	if (%max $= "") %max = %thisMax;
	//Convert to [0, 1]
	%value = (%value - %thisMin) / (%thisMax - %thisMin);
	//Round to ticks
	%value = mRound(%value * %this.ticks) / %this.ticks;
	//Convert to [min, max];
	%value = (%value * (%max - %min)) + %min;
	return %value;
}

function GuiSliderCtrl::getTickSize(%this) {
	%thisMin = getWord(%this.range, 0);
	%thisMax = getWord(%this.range, 1);
	return (%thisMax - %thisMin) / %this.ticks;
}

function GuiSliderCtrl::getJoyTickSize(%this) {
	%thisMin = getWord(%this.range, 0);
	%thisMax = getWord(%this.range, 1);
	return (%thisMax - %thisMin) / (%this.joyTicks $= "" ? %this.ticks : %this.joyTicks);
}

//-----------------------------------------------------------------------------
// Graphics

$i = -1;
$Options::Name    ["Graphics", $i++] = "screenResolution";
$Options::Title   ["Graphics", $i  ] = "Screen Resolution";
$Options::Type    ["Graphics", $i  ] = "value";
$Options::Name    ["Graphics", $i++] = "screenStyle";
$Options::Title   ["Graphics", $i  ] = "Screen Style";
$Options::Type    ["Graphics", $i  ] = "value";
$Options::Name    ["Graphics", $i++] = "textureQuality";
$Options::Title   ["Graphics", $i  ] = "Texture Quality";
$Options::Type    ["Graphics", $i  ] = "value";
if (canSupportPostFX()) { //No point supporting reflections if you don't support postfx anyway
	$Options::Name ["Graphics", $i++] = "marbleReflections";
	$Options::Title["Graphics", $i  ] = "Marble Reflections";
	$Options::Type ["Graphics", $i  ] = "value";
	$Options::Name    ["Graphics", $i++] = "postprocessing";
	$Options::Title   ["Graphics", $i  ] = "Post Processing";
	$Options::Type    ["Graphics", $i  ] = "value";
	$Options::Name    ["Graphics", $i++] = "bloom";
	$Options::Title   ["Graphics", $i  ] = "Bloom";
	$Options::Type    ["Graphics", $i  ] = "value";
}
$Options::Name    ["Graphics", $i++] = "interiorShaders";
$Options::Title   ["Graphics", $i  ] = "Material Quality";
$Options::Type    ["Graphics", $i  ] = "value";
$Options::Name    ["Graphics", $i++] = "animateBackground";
$Options::Title   ["Graphics", $i  ] = "Preload Levels";
$Options::Type    ["Graphics", $i  ] = "boolean";
$Options::Name    ["Graphics", $i++] = "legacyItems";
$Options::Title   ["Graphics", $i  ] = "Legacy Items";
$Options::Type    ["Graphics", $i  ] = "boolean";
if (canSupportAntiAliasing()) { //This is not available on mac
	$Options::Name ["Graphics", $i++] = "antiAliasing";
	$Options::Title["Graphics", $i  ] = "Anti Aliasing";
	$Options::Type ["Graphics", $i  ] = "value";
}
$Options::Name    ["Graphics", $i++] = "maxFPS";
$Options::Title   ["Graphics", $i  ] = "Max FPS";
$Options::Type    ["Graphics", $i  ] = "value";
$Options::Name    ["Graphics", $i++] = "texturePack";
$Options::Title   ["Graphics", $i  ] = "Texture Packs";
$Options::Ctrl    ["Graphics", $i  ] = "button";
$Options::Name    ["Graphics", $i++] = "particleSystem";
$Options::Title   ["Graphics", $i  ] = "Particle System";
$Options::Type    ["Graphics", $i  ] = "value";
$Options::Name    ["Graphics", $i++] = "particles";
$Options::Title   ["Graphics", $i  ] = "Particles";
$Options::Ctrl    ["Graphics", $i  ] = "slider";
$Options::Min     ["Graphics", $i  ] = 0;
$Options::Max     ["Graphics", $i  ] = 200;
$Options::Ticks   ["Graphics", $i  ] = 40; //Every 5
$Options::JoyTicks["Graphics", $i  ] = 10; //Every 20
$Options::Name    ["Graphics", $i++] = "smoothShading";
$Options::Title   ["Graphics", $i  ] = "Smooth Shading";
$Options::Type    ["Graphics", $i  ] = "boolean";
$Options::Name    ["Graphics", $i++] = "fast";
$Options::Title   ["Graphics", $i  ] = "Fast Mode";
$Options::Type    ["Graphics", $i  ] = "boolean";

Array(TextureQualityArray);
TextureQualityArray.addEntry("Low"    TAB 0);
TextureQualityArray.addEntry("Medium" TAB 1);
TextureQualityArray.addEntry("High"   TAB 2);

Array(MarbleReflectionQualityArray);
MarbleReflectionQualityArray.addEntry("Disabled" TAB 0 TAB 32);
MarbleReflectionQualityArray.addEntry("Basic"    TAB 1 TAB 64);
MarbleReflectionQualityArray.addEntry("Advanced" TAB 2 TAB 128);

Array(BloomQualityArray);
BloomQualityArray.addEntry("Disabled" TAB 0);
BloomQualityArray.addEntry("Basic"    TAB 1);
BloomQualityArray.addEntry("High" TAB 2);
BloomQualityArray.addEntry("Ultra" TAB 3);

Array(InteriorShadersQualityArray);
InteriorShadersQualityArray.addEntry("Legacy" TAB -1);
if (canSupportShaders()) {
	InteriorShadersQualityArray.addEntry("Low"      TAB  0);
	InteriorShadersQualityArray.addEntry("Medium"   TAB  1);
	InteriorShadersQualityArray.addEntry("High"     TAB  2);
}

Array(AntiAliasingQualityArray);
AntiAliasingQualityArray.addEntry("Disabled" TAB  0);
AntiAliasingQualityArray.addEntry("2x"       TAB  2);
AntiAliasingQualityArray.addEntry("4x"       TAB  4);
AntiAliasingQualityArray.addEntry("8x"       TAB  8);

Array(MaxFPSArray);
MaxFPSArray.addEntry("Unlimited" TAB  -1);
MaxFPSArray.addEntry("VSync"     TAB   0);
MaxFPSArray.addEntry("30"        TAB  30);
MaxFPSArray.addEntry("60"        TAB  60);
MaxFPSArray.addEntry("75"        TAB  75);
MaxFPSArray.addEntry("120"       TAB 120);
MaxFPSArray.addEntry("200"       TAB 200);

Array(ParticleSystemArray);
ParticleSystemArray.addEntry("PlatinumQuest"    TAB 0);
ParticleSystemArray.addEntry("Marble Blast Gold" TAB 1);
ParticleSystemArray.addEntry("Marble Blast Ultra"   TAB 2);

//-----------------------------------------------------------------------------
// Audio

$Options::Name    ["Audio", 0] = "musicVolume";
$Options::Title   ["Audio", 0] = "Music Volume";
$Options::Ctrl    ["Audio", 0] = "slider";
$Options::Min     ["Audio", 0] = 0;
$Options::Max     ["Audio", 0] = 100;
$Options::Ticks   ["Audio", 0] = 20; //Every 5
$Options::JoyTicks["Audio", 0] = 20; //Every 5
$Options::Name    ["Audio", 1] = "soundVolume";
$Options::Title   ["Audio", 1] = "Sound Volume";
$Options::Ctrl    ["Audio", 1] = "slider";
$Options::Min     ["Audio", 1] = 0;
$Options::Max     ["Audio", 1] = 100;
$Options::Ticks   ["Audio", 1] = 20; //Every 5
$Options::JoyTicks["Audio", 1] = 20; //Every 5
$Options::Name    ["Audio", 2] = "audioPack";
$Options::Title   ["Audio", 2] = "Audio Pack";
$Options::Type    ["Audio", 2] = "value";
$Options::Name    ["Audio", 3] = "automaticAudio";
$Options::Title   ["Audio", 3] = "Automatic Audio Swap";
$Options::Type    ["Audio", 3] = "boolean";

//-----------------------------------------------------------------------------
// Gameplay

$i = -1;
$Options::Name    ["Gameplay", $i++] = "fpsCounter";
$Options::Title   ["Gameplay", $i  ] = "FPS Counter";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "freelook";
$Options::Title   ["Gameplay", $i  ] = "Free-Look";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "oobInsults";
$Options::Title   ["Gameplay", $i  ] = "OOB Insults";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "thousandths";
$Options::Title   ["Gameplay", $i  ] = "Thousandths";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "helptriggers";
$Options::Title   ["Gameplay", $i  ] = "Help Triggers";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "screenshotMode";
$Options::Title   ["Gameplay", $i  ] = "Show/Hide HUD";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "fov";
$Options::Title   ["Gameplay", $i  ] = "FOV";
$Options::Ctrl    ["Gameplay", $i  ] = "slider";
$Options::Min     ["Gameplay", $i  ] = 60;
$Options::Max     ["Gameplay", $i  ] = 140;
$Options::Ticks   ["Gameplay", $i  ] = 80; //Every 1
$Options::JoyTicks["Gameplay", $i  ] = 16; //Every 5
$Options::Name    ["Gameplay", $i++] = "maxRadarItems";
$Options::Title   ["Gameplay", $i  ] = "Max Radar Items";
$Options::Ctrl    ["Gameplay", $i  ] = "slider";
$Options::Min     ["Gameplay", $i  ] = 5;
$Options::Max     ["Gameplay", $i  ] = 85;
$Options::Ticks   ["Gameplay", $i  ] = 80; //Every 1
$Options::JoyTicks["Gameplay", $i  ] = 16; //Every 5
$Options::Name    ["Gameplay", $i++] = "alwaysShowSpeedometer";
$Options::Title   ["Gameplay", $i  ] = "Always Show Speedometer";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "powerupsAlwaysOnRadar";
$Options::Title   ["Gameplay", $i  ] = "Powerups Always on Radar";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "powerupTimers";
$Options::Title   ["Gameplay", $i  ] = "Powerup Timers";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "timeTravelTimer";
$Options::Title   ["Gameplay", $i  ] = "Time Travel Timer";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "minimalSpectateUI";
$Options::Title   ["Gameplay", $i  ] = "(Online) Minimal Spectate UI";
$Options::Type    ["Gameplay", $i  ] = "boolean";
$Options::Name    ["Gameplay", $i++] = "spchanges";
$Options::Title   ["Gameplay", $i  ] = "Ultra Violet";
$Options::Type    ["Gameplay", $i  ] = "boolean";

Array(ScreenshotModeArray);
ScreenshotModeArray.addEntry("Show Everything"  TAB 0);
ScreenshotModeArray.addEntry("Hide Chat Online" TAB 1);
ScreenshotModeArray.addEntry("Hide Everything"  TAB 2);

Array(TimeTravelTimerArray);
TimeTravelTimerArray.addEntry("Disabled"  TAB 0);
TimeTravelTimerArray.addEntry("Enabled" TAB 1);
TimeTravelTimerArray.addEntry("Enabled, Precise"  TAB 2);

//-----------------------------------------------------------------------------
// Online

$i = -1;
$Options::Name    ["Online", $i++] = "scorePredictor";
$Options::Title   ["Online", $i  ] = "Score Predictor";
$Options::Type    ["Online", $i  ] = "boolean";
$Options::Name    ["Online", $i++] = "showRecords";
$Options::Title   ["Online", $i  ] = "Always Show World Record";
$Options::Type    ["Online", $i  ] = "boolean";
$Options::Name    ["Online", $i++] = "serverPort";
$Options::Title   ["Online", $i  ] = "Server Port";
$Options::Ctrl    ["Online", $i  ] = "textbox";
$Options::Length  ["Online", $i  ] = 5;
$Options::Name    ["Online", $i++] = "profanityFilter";
$Options::Title   ["Online", $i  ] = "Profanity Filter";
$Options::Type    ["Online", $i  ] = "boolean";
$Options::Name    ["Online", $i++] = "globalSize";
$Options::Title   ["Online", $i  ] = "Global Score Page Size";
$Options::Type    ["Online", $i  ] = "value";
$Options::Name    ["Online", $i++] = "chatMessageSize";
$Options::Title   ["Online", $i  ] = "In-Game Lines of Chat";
$Options::Type    ["Online", $i  ] = "value";
$Options::Name    ["Online", $i++] = "noholepunch";
$Options::Title   ["Online", $i  ] = "Hole Punching";
$Options::Type    ["Online", $i  ] = "boolean";
$Options::Name    ["Online", $i++] = "autoLogin";
$Options::Title   ["Online", $i  ] = "Auto Login";
$Options::Type    ["Online", $i  ] = "boolean";

$Options::AutoLoginUserField = $i++;
$Options::AutoLoginPassField = $i++;

$Options::Name    ["Online", $Options::AutoLoginUserField] = "autoLoginUsername";
$Options::Title   ["Online", $Options::AutoLoginUserField] = "Username";
$Options::Ctrl    ["Online", $Options::AutoLoginUserField] = "textbox";
$Options::Length  ["Online", $Options::AutoLoginUserField] = 255;
$Options::Disable ["Online", $Options::AutoLoginUserField] = ($LBPref::AutoLogin !$= "User");
$Options::Name    ["Online", $Options::AutoLoginPassField] = "AutoLoginPassword";
$Options::Title   ["Online", $Options::AutoLoginPassField] = "Password";
$Options::Ctrl    ["Online", $Options::AutoLoginPassField] = "password";
$Options::Length  ["Online", $Options::AutoLoginPassField] = 255;
$Options::Disable ["Online", $Options::AutoLoginPassField] = ($LBPref::AutoLogin !$= "User");


Array(AutoLoginArray);
AutoLoginArray.addEntry("None"  TAB "None");
AutoLoginArray.addEntry("User"  TAB "User");
AutoLoginArray.addEntry("Guest" TAB "Guest");

Array(ProfanityFilterArray);
ProfanityFilterArray.addEntry("Disable" TAB 0);
ProfanityFilterArray.addEntry("Minimal" TAB 1);
ProfanityFilterArray.addEntry("Strong"  TAB 2);

Array(GlobalSizeArray);
GlobalSizeArray.addEntry("5"  TAB 5);
GlobalSizeArray.addEntry("10" TAB 10);

Array(ChatMessageSizeArray);
ChatMessageSizeArray.addEntry("1" TAB 1);
ChatMessageSizeArray.addEntry("2" TAB 2);
ChatMessageSizeArray.addEntry("3" TAB 3);
ChatMessageSizeArray.addEntry("4" TAB 4);
ChatMessageSizeArray.addEntry("5" TAB 5);
ChatMessageSizeArray.addEntry("6" TAB 6);

//-----------------------------------------------------------------------------
// Graphics Functions.

function Opt_screenResolution_getDisplay() {
	return getWord($pref::Video::Resolution, 0) SPC "x" SPC getWord($pref::Video::Resolution, 1);
}

function Opt_screenResolution_getValue() {
	return getWords($pref::Video::Resolution, 0, 1);
}

function Opt_screenResolution_decrease() {
	%current = opt_screenResolution_getValue();
	%index = OptResolutions.getIndexByEntry(%current);
	%index --;
	%index += OptResolutions.getSize();
	%index %= OptResolutions.getSize();
	%current = OptResolutions.getEntry(%index);
	$pref::Video::resolution = %current SPC getWord($pref::Video::resolution, 2);
	$pref::Video::WindowedRes = %current SPC getWord($pref::Video::resolution, 2);
}

function Opt_screenResolution_increase() {
	%current = opt_screenResolution_getValue();
	%index = OptResolutions.getIndexByEntry(%current);
	%index ++;
	%index += OptResolutions.getSize();
	%index %= OptResolutions.getSize();
	%current = OptResolutions.getEntry(%index);
	$pref::Video::resolution = %current SPC getWord($pref::Video::resolution, 2);
	$pref::Video::WindowedRes = %current SPC getWord($pref::Video::resolution, 2);
}

//-----------------------------------------------------------------------------

function Opt_screenStyle_getDisplay() {
	return $pref::Video::fullScreen ? "Full Screen" : "Windowed";
}

function Opt_screenStyle_getValue() {
	return $pref::Video::fullScreen;
}

function Opt_screenStyle_decrease() {
	$pref::Video::fullScreen = !$pref::Video::fullScreen;
	Opt_screenStyle_updateResolution();
}

function Opt_screenStyle_increase() {
	$pref::Video::fullScreen = !$pref::Video::fullScreen;
	Opt_screenStyle_updateResolution();
}


function Opt_screenStyle_updateResolution() {
	buildResolutionList();
	//And update the resolution pref... by going back and forth the really hacky way
	eval(OptionsscreenResolutionLeftArrow.command);
	eval(OptionsscreenResolutionRightArrow.command);
}

//-----------------------------------------------------------------------------

function Opt_textureQuality_getDisplay() {
	%entry = TextureQualityArray.getEntryByField($pref::Video::TextureQuality, 1);
	if (%entry $= "") {
		return $pref::Video::TextureQuality;
	}
	return getField(%entry, 0);
}

function Opt_textureQuality_getValue() {
	return $pref::Video::TextureQuality;
}

function Opt_textureQuality_decrease() {
	%index = TextureQualityArray.getIndexByField($pref::Video::TextureQuality, 1);
	%index --;
	if (%index < 0) {
		%index = TextureQualityArray.getSize() - 1;
	}
	$pref::Video::TextureQuality = getField(TextureQualityArray.getEntry(%index), 1);
}

function Opt_textureQuality_increase() {
	%index = TextureQualityArray.getIndexByField($pref::Video::TextureQuality, 1);
	%index ++;
	if (%index >= TextureQualityArray.getSize()) {
		%index = 0;
	}
	$pref::Video::TextureQuality = getField(TextureQualityArray.getEntry(%index), 1);
}

//-----------------------------------------------------------------------------

function Opt_marbleReflections_getDisplay() {
	%entry = MarbleReflectionQualityArray.getEntryByField($pref::Video::MarbleReflectionQuality, 1);
	if (%entry $= "") {
		return $pref::Video::MarbleReflectionQuality;
	}
	return getField(%entry, 0);
}

function Opt_marbleReflections_getValue() {
	return $pref::Video::MarbleReflectionQuality;
}

function Opt_marbleReflections_decrease() {
	%index = MarbleReflectionQualityArray.getIndexByField($pref::Video::MarbleReflectionQuality, 1);
	%index --;
	if (%index < 0) {
		%index = MarbleReflectionQualityArray.getSize() - 1;
	}
	$pref::Video::MarbleReflectionQuality = getField(MarbleReflectionQualityArray.getEntry(%index), 1);
	$pref::Video::MarbleCubemapExtent = getField(MarbleReflectionQualityArray.getEntry(%index), 2);
}

function Opt_marbleReflections_increase() {
	%index = MarbleReflectionQualityArray.getIndexByField($pref::Video::MarbleReflectionQuality, 1);
	%index ++;
	if (%index >= MarbleReflectionQualityArray.getSize()) {
		%index = 0;
	}
	$pref::Video::MarbleReflectionQuality = getField(MarbleReflectionQualityArray.getEntry(%index), 1);
	$pref::Video::MarbleCubemapExtent = getField(MarbleReflectionQualityArray.getEntry(%index), 2);
}

//-----------------------------------------------------------------------------

function Opt_postprocessing_getDisplay() {
	return $pref::Video::PostProcessing ? "Enabled" : "Disabled";
}

function Opt_postprocessing_getValue() {
	return $pref::Video::PostProcessing;
}

function Opt_postprocessing_decrease() {
	$pref::Video::PostProcessing = !$pref::Video::PostProcessing;
}

function Opt_postprocessing_increase() {
	$pref::Video::PostProcessing = !$pref::Video::PostProcessing;
}

//-----------------------------------------------------------------------------

function Opt_bloom_getDisplay() {
	%entry = BloomQualityArray.getEntryByField($pref::Video::ShapeBloomQuality, 1);
	if (%entry $= "") {
		return $pref::Video::ShapeBloomQuality;
	}
	return getField(%entry, 0);
}

function Opt_bloom_getValue() {
	return $pref::Video::ShapeBloomQuality;
}

function Opt_bloom_decrease() {
	%index = BloomQualityArray.getIndexByField($pref::Video::ShapeBloomQuality, 1);
	%index --;
	if (%index < 0) {
		%index = BloomQualityArray.getSize() - 1;
	}
	$pref::Video::ShapeBloomQuality = getField(BloomQualityArray.getEntry(%index), 1);
}

function Opt_bloom_increase() {
	%index = BloomQualityArray.getIndexByField($pref::Video::ShapeBloomQuality, 1);
	%index ++;
	if (%index >= BloomQualityArray.getSize()) {
		%index = 0;
	}
	$pref::Video::ShapeBloomQuality = getField(BloomQualityArray.getEntry(%index), 1);
}

//-----------------------------------------------------------------------------

function Opt_interiorShaders_getDisplay() {
	%entry = InteriorShadersQualityArray.getEntryByField($pref::Video::InteriorShaderQuality, 1);
	if (%entry $= "") {
		return $pref::Video::InteriorShaderQuality;
	}
	return getField(%entry, 0);
}

function Opt_interiorShaders_getValue() {
	return $pref::Video::InteriorShaderQuality;
}

function Opt_interiorShaders_decrease() {
	%index = InteriorShadersQualityArray.getIndexByField($pref::Video::InteriorShaderQuality, 1);
	%index --;
	if (%index < 0) {
		%index = InteriorShadersQualityArray.getSize() - 1;
	}
	$pref::Video::InteriorShaderQuality = getField(InteriorShadersQualityArray.getEntry(%index), 1);
}

function Opt_interiorShaders_increase() {
	%index = InteriorShadersQualityArray.getIndexByField($pref::Video::InteriorShaderQuality, 1);
	%index ++;
	if (%index >= InteriorShadersQualityArray.getSize()) {
		%index = 0;
	}
	$pref::Video::InteriorShaderQuality = getField(InteriorShadersQualityArray.getEntry(%index), 1);
}

//-----------------------------------------------------------------------------

function Opt_animateBackground_getDisplay() {
	return $pref::animatePreviews ? "Enabled" : "Disabled";
}

function Opt_animateBackground_getValue() {
	return $pref::animatePreviews;
}

function Opt_animateBackground_decrease() {
	$pref::animatePreviews = !$pref::animatePreviews;
}

function Opt_animateBackground_increase() {
	$pref::animatePreviews = !$pref::animatePreviews;
}

//-----------------------------------------------------------------------------

function Opt_legacyItems_getDisplay() {
	return $pref::legacyItems ? "Enabled" : "Disabled";
}

function Opt_legacyItems_getValue() {
	return $pref::legacyItems;
}

function Opt_legacyItems_decrease() {
	$pref::legacyItems = !$pref::legacyItems;

	if (!$liAssert) {
		$liAssert = true;
		MessageBoxOK("Notice", "This option requires you to restart the game.");
	}
}

function Opt_legacyItems_increase() {
	$pref::legacyItems = !$pref::legacyItems;

	if (!$liAssert) {
		$liAssert = true;
		MessageBoxOK("Notice", "This option requires you to restart the game.");
	}
}

//-----------------------------------------------------------------------------

function Opt_antiAliasing_getDisplay() {
	%entry = AntiAliasingQualityArray.getEntryByField($pref::Video::AntiAliasing, 1);
	if (%entry $= "") {
		return $pref::Video::AntiAliasing;
	}
	return getField(%entry, 0);
}

function Opt_antiAliasing_getValue() {
	return $pref::Video::AntiAliasing;
}

function Opt_antiAliasing_decrease() {
	%index = AntiAliasingQualityArray.getIndexByField($pref::Video::AntiAliasing, 1);
	%index --;
	if (%index < 0) {
		%index = AntiAliasingQualityArray.getSize() - 1;
	}
	$pref::Video::AntiAliasing = getField(AntiAliasingQualityArray.getEntry(%index), 1);

	if (%index > 1 && !$aaAssert) {
		$aaAssert = true;
		MessageBoxOK("Performance Notice", "With higher levels of anti-aliasing you may experience performace drops. If you experience lag after activating this, try reducing this setting.");
	}
}

function Opt_antiAliasing_increase() {
	%index = AntiAliasingQualityArray.getIndexByField($pref::Video::AntiAliasing, 1);
	%index ++;
	if (%index >= AntiAliasingQualityArray.getSize()) {
		%index = 0;
	}
	$pref::Video::AntiAliasing = getField(AntiAliasingQualityArray.getEntry(%index), 1);

	if (%index > 1 && !$aaAssert) {
		$aaAssert = true;
		MessageBoxOK("Performance Notice", "With higher levels of anti-aliasing you may experience performace drops. If you experience lag after activating this, try reducing this setting.");
	}
}

//-----------------------------------------------------------------------------

function Opt_maxFPS_getDisplay() {
	%entry = MaxFPSArray.getEntryByField($pref::Video::MaxFPS, 1);
	if (%entry $= "") {
		return $pref::Video::MaxFPS;
	}
	return getField(%entry, 0);
}

function Opt_maxFPS_getValue() {
	return $pref::Video::MaxFPS;
}

function Opt_maxFPS_decrease() {
	%index = MaxFPSArray.getIndexByField($pref::Video::MaxFPS, 1);
	%index --;
	if (%index < 0) {
		%index = MaxFPSArray.getSize() - 1;
	}
	$pref::Video::MaxFPS = getField(MaxFPSArray.getEntry(%index), 1);

	if ($platform $= "macos" && (%index == 0) && !$vsyncAssert) {
		$vsyncAssert = true;
		MessageBoxOK("Performance Notice", "Unlimited framerate will make your game render as fast as possible." NL
			"This has been known to turn laptops into toasters as OSX doesn't activate the fans until your CPU reaches almost boiling point.");
	}
}

function Opt_maxFPS_increase() {
	%index = MaxFPSArray.getIndexByField($pref::Video::MaxFPS, 1);
	%index ++;
	if (%index == MaxFPSArray.getSize()) {
		%index = 0;
	}
	$pref::Video::MaxFPS = getField(MaxFPSArray.getEntry(%index), 1);

	if ($platform $= "macos" && (%index == 0) && !$vsyncAssert) {
		$vsyncAssert = true;
		MessageBoxOK("Performance Notice", "Unlimited framerate will make your game render as fast as possible." NL
			"This has been known to turn laptops into toasters as OSX doesn't activate the fans until your CPU reaches almost boiling point.");
	}
}


//-----------------------------------------------------------------------------

function Opt_particleSystem_getDisplay() {
	%entry = ParticleSystemArray.getEntryByField($pref::Video::particleSystem, 1);
	if (%entry $= "") {
		return $pref::Video::particleSystem;
	}
	return getField(%entry, 0);
}

function Opt_particleSystem_getValue() {
	return $pref::Video::particleSystem;
}

function Opt_particleSystem_decrease() {
	%index = ParticleSystemArray.getIndexByField($pref::Video::particleSystem, 1);
	%index --;
	if (%index < 0) {
		%index = ParticleSystemArray.getSize() - 1;
	}
	$pref::Video::particleSystem = getField(ParticleSystemArray.getEntry(%index), 1);

	if (!$psAssert) {
		$psAssert = true;
		MessageBoxOK("Notice", "This option requires you to restart the game.");
	}
}

function Opt_particleSystem_increase() {
	%index = ParticleSystemArray.getIndexByField($pref::Video::particleSystem, 1);
	%index ++;
	if (%index >= ParticleSystemArray.getSize()) {
		%index = 0;
	}
	$pref::Video::particleSystem = getField(ParticleSystemArray.getEntry(%index), 1);

	if (!$psAssert) {
		$psAssert = true;
		MessageBoxOK("Notice", "This option requires you to restart the game.");
	}
}

//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

function Opt_texturePack_edit() {
	// Dialog does all the config for us (and sets $Options::TexturePackDirty)
	RootGui.pushDialog(OptionsTexturePackDlg);
}

//-----------------------------------------------------------------------------

function Opt_particles_getValue() {
	return $pref::Video::ParticlesPercent * 100;
}

function Opt_particles_getDisplay() {
	return mRound(Opt_particles_getValue());
}

function Opt_particles_decrease(%size) {
	Opt_particles_setValue(Opt_particles_getValue() - %size);
}

function Opt_particles_increase(%size) {
	Opt_particles_setValue(Opt_particles_getValue() + %size);
}

function Opt_particles_setValue(%value) {
	$pref::Video::ParticlesPercent = %value / 100;
}

//-----------------------------------------------------------------------------

function Opt_smoothShading_getDisplay() {
	return $pref::Interior::SmoothShading ? "Enabled" : "Disabled";
}

function Opt_smoothShading_getValue() {
	return $pref::Interior::SmoothShading;
}

function Opt_smoothShading_decrease() {
	$pref::Interior::SmoothShading = !$pref::Interior::SmoothShading;
	enableInterpolation(!$pref::Interior::SmoothShading);
}

function Opt_smoothShading_increase() {
	$pref::Interior::SmoothShading = !$pref::Interior::SmoothShading;
	enableInterpolation(!$pref::Interior::SmoothShading);
}

//-----------------------------------------------------------------------------

function Opt_fast_getDisplay() {
	return $pref::fastMode ? "Enabled" : "Disabled";
}

function Opt_fast_getValue() {
	return $pref::fastMode;
}

function Opt_fast_decrease() {
	$pref::fastMode = !$pref::fastMode;
	enableInterpolation(!$pref::FastMode);
}

function Opt_fast_increase() {
	$pref::fastMode = !$pref::fastMode;
	enableInterpolation(!$pref::FastMode);
}

//-----------------------------------------------------------------------------
// Audio Functions.

function Opt_musicVolume_getValue() {
	return $pref::Audio::channelVolume2 * 100;
}

function Opt_musicVolume_getDisplay() {
	%value = Opt_musicVolume_getValue();
	if (%value < 10) {
		// Torque mutes the audio under 10% for some reason
		return "Muted";
	}
	return mRound(%value) @ "%";
}

function Opt_musicVolume_decrease(%size) {
	Opt_musicVolume_setValue(Opt_musicVolume_getValue() - %size);
}

function Opt_musicVolume_increase(%size) {
	%value = Opt_musicVolume_getValue() + %size;
	if (%value < 10) {
		%value = 10;
	}
	Opt_musicVolume_setValue(%value);
}

function Opt_musicVolume_setValue(%value) {
	// scale down from 0-100 to 0-1 when setting the variable
	if (%value < 10) {
		// Torque mutes the audio under 10% for some reason **only in some cases
		%value = 0;
	}

	$pref::Audio::channelVolume2 = (%value / 100);
	OptionsGui.updateChannelVolume(2);

	OptionsGui.messedWithMusicVolume = true;
}

//-----------------------------------------------------------------------------

function Opt_soundVolume_getValue() {
	return $pref::Audio::channelVolume1 * 100; // or 3 could work too...
}

function Opt_soundVolume_getDisplay() {
	%value = Opt_soundVolume_getValue();
	if (%value < 10) {
		// Torque mutes the audio under 10% for some reason
		return "Muted";
	}
	return mRound(%value) @ "%";
}

function Opt_soundVolume_decrease(%size) {
	Opt_soundVolume_setValue(Opt_soundVolume_getValue() - %size);
}

function Opt_soundVolume_increase(%size) {
	%value = Opt_soundVolume_getValue() + %size;
	if (%value < 10) {
		%value = 10;
	}
	Opt_soundVolume_setValue(%value);
}

function Opt_soundVolume_setValue(%value) {
	// scale down from 0-100 to 0-1 when setting the variable
	if (%value < 10) {
		// Torque mutes the audio under 10% for some reason **only in some cases
		%value = 0;
	}

	// Channels 1 and 3 are sound related (1 - in game sounds, 3 - gui sounds)
	$pref::Audio::channelVolume1 = (%value / 100);
	$pref::Audio::channelVolume3 = (%value / 100);

	OptionsGui.updateChannelVolume(1);
	OptionsGui.updateChannelVolume(3);
}

//-----------------------------------------------------------------------------

function buildAudioPackArray() {
	if (isObject(AudioPackArray)) {
		AudioPackArray.delete();
	}
	Array(AudioPackArray);
	AudioPackArray.addEntry("PlatinumQuest" TAB "");

	%spec = $userMods @ "/data/sound/ap_*/*.apk";
	for (%file = findFirstFile(%spec); %file !$= ""; %file = findNextFile(%spec)) {
		%pack = jsonParse(fread(%file));
		if (!isObject(%pack)) {
			continue;
		}

		//Name TAB value
		AudioPackArray.addEntry(%pack.name TAB fileBase(%file));
	}
}
buildAudioPackArray();

function Opt_audioPack_getDisplay() {
	%entry = AudioPackArray.getEntryByField($pref::Audio::AudioPack, 1);
	if (%entry $= "") {
		return $pref::Audio::AudioPack;
	}
	return getField(%entry, 0);
}

function Opt_audioPack_getValue() {
	return $pref::Audio::AudioPack;
}

function Opt_audioPack_decrease() {
	%index = AudioPackArray.getIndexByField($pref::Audio::AudioPack, 1);
	%index --;
	if (%index < 0) {
		%index = AudioPackArray.getSize() - 1;
	}
	$pref::Audio::AudioPack = getField(AudioPackArray.getEntry(%index), 1);
	loadAudioPack($pref::Audio::AudioPack);
}

function Opt_audioPack_increase() {
	%index = AudioPackArray.getIndexByField($pref::Audio::AudioPack, 1);
	%index ++;
	if (%index >= AudioPackArray.getSize()) {
		%index = 0;
	}
	$pref::Audio::AudioPack = getField(AudioPackArray.getEntry(%index), 1);
	loadAudioPack($pref::Audio::AudioPack);
}

//-----------------------------------------------------------------------------

function OptionsGui::updateChannelVolume(%this, %channel) {
	if (%channel < 1 || %channel > 8)
		return;

	alxSetChannelVolume(%channel, $pref::Audio::channelVolume[%channel]);
	if (!alxIsPlaying($AudioTestHandle) && %channel == 1) {
		$AudioTestHandle = alxCreateSource("AudioChannel"@%channel, expandFilename("~/data/sound/testing.wav"));
		alxPlay($AudioTestHandle);
	}
}

//-----------------------------------------------------------------------------
// Gameplay Functions

function Opt_fpsCounter_getDisplay() {
	return $pref::showFPSCounter ? "Enabled" : "Disabled";
}

function Opt_fpsCounter_getValue() {
	return $pref::showFPSCounter;
}

function Opt_fpsCounter_decrease() {
	$pref::showFPSCounter = !$pref::showFPSCounter;
	FPSMetreCtrl.setVisible($pref::showFPSCounter);
}

function Opt_fpsCounter_increase() {
	$pref::showFPSCounter = !$pref::showFPSCounter;
	FPSMetreCtrl.setVisible($pref::showFPSCounter);
}

//-----------------------------------------------------------------------------

function Opt_freelook_getDisplay() {
	return $pref::Input::alwaysFreeLook ? "Enabled" : "Disabled";
}

function Opt_freelook_getValue() {
	return $pref::Input::alwaysFreeLook;
}

function Opt_freelook_decrease() {
	$pref::Input::alwaysFreeLook = !$pref::Input::alwaysFreeLook;
}

function Opt_freelook_increase() {
	$pref::Input::alwaysFreeLook = !$pref::Input::alwaysFreeLook;
}

//-----------------------------------------------------------------------------

function Opt_oobInsults_getDisplay() {
	return $pref::showOOBMessages ? "Enabled" : "Disabled";
}

function Opt_oobInsults_getValue() {
	return $pref::showOOBMessages;
}

function Opt_oobInsults_decrease() {
	$pref::showOOBMessages = !$pref::showOOBMessages;
}

function Opt_oobInsults_increase() {
	$pref::showOOBMessages = !$pref::showOOBMessages;
}

//-----------------------------------------------------------------------------

function Opt_thousandths_getDisplay() {
	return $pref::Thousandths ? "Enabled" : "Disabled";
}

function Opt_thousandths_getValue() {
	return $pref::Thousandths;
}

function Opt_thousandths_decrease() {
	$pref::Thousandths = !$pref::Thousandths;

	PG_Timer.setVisible(!$pref::Thousandths);
	PG_TimerThousands.setVisible($pref::Thousandths);
	PlayGui.updateControls();
	PlayGui.updateTimeTravelCountdown();
}

function Opt_thousandths_increase() {
	$pref::Thousandths = !$pref::Thousandths;

	PG_Timer.setVisible(!$pref::Thousandths);
	PG_TimerThousands.setVisible($pref::Thousandths);
	PlayGui.updateControls();
	PlayGui.updateTimeTravelCountdown();
}

//-----------------------------------------------------------------------------
// Connie: This was simpler to do than I had originally expected lmao
//-----------------------------------------------------------------------------

function Opt_alwaysShowSpeedometer_getDisplay() {
	return $pref::alwaysShowSpeedometer ? "Enabled" : "Disabled";
}

function Opt_alwaysShowSpeedometer_getValue() {
	return $pref::alwaysShowSpeedometer;
}

function Opt_alwaysShowSpeedometer_decrease() {
	$pref::alwaysShowSpeedometer = !$pref::alwaysShowSpeedometer;
}

function Opt_alwaysShowSpeedometer_increase() {
	$pref::alwaysShowSpeedometer = !$pref::alwaysShowSpeedometer;
}

//-----------------------------------------------------------------------------

function Opt_powerupsAlwaysOnRadar_getDisplay() {
	return $pref::powerupsAlwaysOnRadar ? "Enabled" : "Disabled";
}

function Opt_powerupsAlwaysOnRadar_getValue() {
	return $pref::powerupsAlwaysOnRadar;
}

function Opt_powerupsAlwaysOnRadar_decrease() {
	$pref::powerupsAlwaysOnRadar = !$pref::powerupsAlwaysOnRadar;
}

function Opt_powerupsAlwaysOnRadar_increase() {
	$pref::powerupsAlwaysOnRadar = !$pref::powerupsAlwaysOnRadar;
}

//-----------------------------------------------------------------------------

function Opt_powerupTimers_getDisplay() {
	return $pref::powerupTimers ? "Enabled" : "Disabled";
}

function Opt_powerupTimers_getValue() {
	return $pref::powerupTimers;
}

function Opt_powerupTimers_decrease() {
	$pref::powerupTimers = !$pref::powerupTimers;
}

function Opt_powerupTimers_increase() {
	$pref::powerupTimers = !$pref::powerupTimers;
}

//-----------------------------------------------------------------------------

function Opt_timeTravelTimer_getDisplay() {
	%entry = TimeTravelTimerArray.getEntryByField($pref::timeTravelTimer, 1);
	if (%entry $= "") {
		return $pref::timeTravelTimer;
	}
	return getField(%entry, 0);
}

function Opt_timeTravelTimer_getValue() {
	return $pref::timeTravelTimer;
}

function Opt_timeTravelTimer_decrease() {
	%index = TimeTravelTimerArray.getIndexByField($pref::timeTravelTimer, 1);
	%index --;
	if (%index < 0) {
		%index = TimeTravelTimerArray.getSize() - 1;
	}
	$pref::timeTravelTimer = getField(TimeTravelTimerArray.getEntry(%index), 1);
	PlayGui.updateTimeTravelCountdown();
}

function Opt_timeTravelTimer_increase() {
	%index = TimeTravelTimerArray.getIndexByField($pref::timeTravelTimer, 1);
	%index ++;
	if (%index >= TimeTravelTimerArray.getSize()) {
		%index = 0;
	}
	$pref::timeTravelTimer = getField(TimeTravelTimerArray.getEntry(%index), 1);
	PlayGui.updateTimeTravelCountdown();
}

//-----------------------------------------------------------------------------

function Opt_minimalSpectateUI_getDisplay() {
	return $pref::minimalSpectateUI ? "Enabled" : "Disabled";
}

function Opt_minimalSpectateUI_getValue() {
	return $pref::minimalSpectateUI;
}

function Opt_minimalSpectateUI_decrease() {
	$pref::minimalSpectateUI = !$pref::minimalSpectateUI;
}

function Opt_minimalSpectateUI_increase() {
	$pref::minimalSpectateUI = !$pref::minimalSpectateUI;
}

//-----------------------------------------------------------------------------

function Opt_helptriggers_getDisplay() {
	return $pref::HelpTriggers ? "Enabled" : "Disabled";
}

function Opt_helptriggers_getValue() {
	return $pref::HelpTriggers;
}

function Opt_helptriggers_decrease() {
	$pref::HelpTriggers = !$pref::HelpTriggers;
}

function Opt_helptriggers_increase() {
	$pref::HelpTriggers = !$pref::HelpTriggers;
}

//-----------------------------------------------------------------------------

function Opt_automaticaudio_getDisplay() {
	return $pref::AutomaticAudio ? "Enabled" : "Disabled";
}

function Opt_automaticaudio_getValue() {
	return $pref::AutomaticAudio;
}

function Opt_automaticaudio_decrease() {
	$pref::AutomaticAudio = !$pref::AutomaticAudio;
}

function Opt_automaticaudio_increase() {
	$pref::AutomaticAudio = !$pref::AutomaticAudio;
}

//-----------------------------------------------------------------------------

function Opt_fov_getValue() {
	return $pref::Player::defaultFov;
}

function Opt_fov_getDisplay() {
	return mRound(Opt_fov_getValue());
}

function Opt_fov_decrease(%size) {
	Opt_fov_setValue(Opt_fov_getValue() - %size);
}

function Opt_fov_increase(%size) {
	Opt_fov_setValue(Opt_fov_getValue() + %size);
}

function Opt_fov_setValue(%value) {
	$pref::Player::defaultFov = %value;
	if (RootGui.getContent().getName() $= "PlayGui") {
		resetCameraFov();
	}
}

//-----------------------------------------------------------------------------

function Opt_maxRadarItems_getValue() {
	return $MPPref::MaxRadarItems;
}

function Opt_maxRadarItems_getDisplay() {
	return mRound(Opt_maxRadarItems_getValue());
}

function Opt_maxRadarItems_decrease(%size) {
	Opt_maxRadarItems_setValue(Opt_maxRadarItems_getValue() - %size);
}

function Opt_maxRadarItems_increase(%size) {
	Opt_maxRadarItems_setValue(Opt_maxRadarItems_getValue() + %size);
}

function Opt_maxRadarItems_setValue(%value) {
	$MPPref::MaxRadarItems = %value;
}

//-----------------------------------------------------------------------------

function Opt_keyboardSpeed_getValue() {
	return $pref::Input::KeyboardTurnSpeed;
}

function Opt_keyboardSpeed_getDisplay() {
	return OptionskeyboardSpeedValue.getFormattedValue(5, 95);
}

function Opt_keyboardSpeed_decrease(%size) {
	Opt_keyboardSpeed_setValue(Opt_keyboardSpeed_getValue() - %size);
}

function Opt_keyboardSpeed_increase(%size) {
	Opt_keyboardSpeed_setValue(Opt_keyboardSpeed_getValue() + %size);
}

function Opt_keyboardSpeed_setValue(%value) {
	$pref::Input::KeyboardTurnSpeed = %value;
}

//-----------------------------------------------------------------------------

function Opt_mouseSpeed_getValue() {
	return $pref::Input::MouseSensitivity;
}

function Opt_mouseSpeed_getDisplay() {
	return OptionsmouseSpeedValue.getFormattedValue(5, 95);
}

function Opt_mouseSpeed_decrease(%size) {
	Opt_mouseSpeed_setValue(Opt_mouseSpeed_getValue() - %size);
}

function Opt_mouseSpeed_increase(%size) {
	Opt_mouseSpeed_setValue(Opt_mouseSpeed_getValue() + %size);
}

function Opt_mouseSpeed_setValue(%value) {
	$pref::Input::MouseSensitivity = %value;
}

//-----------------------------------------------------------------------------

function Opt_spChanges_getDisplay() {
	return $pref::spchanges ? "Enabled" : "Disabled";
}

function Opt_spChanges_getValue() {
	return $pref::spchanges;
}

function Opt_spChanges_decrease() {
	$pref::spchanges = !$pref::spchanges;
	if ($pref::spchanges)
		MessageBoxOK("The Time Has Come", "With this feature enabled Marble Blast Ultra Levels will now resemble their 360 counterparts even more in Singleplayer!");
}

function Opt_spChanges_increase() {
	$pref::spchanges = !$pref::spchanges;
	if ($pref::spchanges)
		MessageBoxOK("The Time Has Come", "With this feature enabled Marble Blast Ultra Levels will now resemble their 360 counterparts even more in Singleplayer!");
	
}

//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

function Opt_scorePredictor_getDisplay() {
	return $MPPref::ScorePredictor ? "Enabled" : "Disabled";
}

function Opt_scorePredictor_getValue() {
	return $MPPref::ScorePredictor;
}

function Opt_scorePredictor_decrease() {
	$MPPref::ScorePredictor = !$MPPref::ScorePredictor;
}

function Opt_scorePredictor_increase() {
	$MPPref::ScorePredictor = !$MPPref::ScorePredictor;
}

//-----------------------------------------------------------------------------

function Opt_showRecords_getDisplay() {
	return $LBPref::ShowRecords ? "Enabled" : "Disabled";
}

function Opt_showRecords_getValue() {
	return $LBPref::ShowRecords;
}

function Opt_showRecords_decrease() {
	$LBPref::ShowRecords = !$LBPref::ShowRecords;
}

function Opt_showRecords_increase() {
	$LBPref::ShowRecords = !$LBPref::ShowRecords;
}

//-----------------------------------------------------------------------------

function Opt_screenshotMode_getDisplay() {
	%entry = ScreenshotModeArray.getEntryByField($pref::screenshotMode, 1);
	if (%entry $= "") {
		return $pref::screenshotMode;
	}
	return getField(%entry, 0);
}

function Opt_screenshotMode_getValue() {
	return $pref::screenshotMode;
}

function Opt_screenshotMode_decrease() {
	%index = ScreenshotModeArray.getIndexByField($pref::screenshotMode, 1);
	%index --;
	if (%index < 0) {
		%index = ScreenshotModeArray.getSize() - 1;
	}
	$pref::screenshotMode = getField(ScreenshotModeArray.getEntry(%index), 1);
	PlayGui.positionMessageHud();
}

function Opt_screenshotMode_increase() {
	%index = ScreenshotModeArray.getIndexByField($pref::screenshotMode, 1);
	%index ++;
	if (%index >= ScreenshotModeArray.getSize()) {
		%index = 0;
	}
	$pref::screenshotMode = getField(ScreenshotModeArray.getEntry(%index), 1);
	PlayGui.positionMessageHud();
}

//-----------------------------------------------------------------------------

function Opt_serverPort_getValue() {
	return $pref::server::Port;
}

function Opt_serverPort_getDisplay() {
	return Opt_serverPort_getValue();
}

function Opt_serverPort_setValue(%value) {
	%clamped = mClamp(%value, 1024, 65535);
	$pref::server::Port = %clamped;

	cancel($optServerPortValidateSch);
	$optServerPortValidateSch = schedule(1000, 0, Opt_serverPort_validate, %value);
}

function Opt_serverPort_validate(%value) {
	%clamped = mClamp(%value, 1024, 65535);
	OptionsserverPortValue.setValue(%clamped);
}

//-----------------------------------------------------------------------------

function Opt_profanityFilter_getDisplay() {
	%entry = ProfanityFilterArray.getEntryByField($pref::ProfanityFilter, 1);
	if (%entry $= "") {
		return $pref::ProfanityFilter;
	}
	return getField(%entry, 0);
}

function Opt_profanityFilter_getValue() {
	return $pref::ProfanityFilter;
}

function Opt_profanityFilter_decrease() {
	%index = ProfanityFilterArray.getIndexByField($pref::ProfanityFilter, 1);
	%index --;
	if (%index < 0) {
		%index = ProfanityFilterArray.getSize() - 1;
	}
	$pref::ProfanityFilter = getField(ProfanityFilterArray.getEntry(%index), 1);
}

function Opt_profanityFilter_increase() {
	%index = ProfanityFilterArray.getIndexByField($pref::ProfanityFilter, 1);
	%index ++;
	if (%index >= ProfanityFilterArray.getSize()) {
		%index = 0;
	}
	$pref::ProfanityFilter = getField(ProfanityFilterArray.getEntry(%index), 1);
}

//-----------------------------------------------------------------------------

function Opt_globalSize_getDisplay() {
	%entry = GlobalSizeArray.getEntryByField($LBPref::GlobalPageSize, 1);
	if (%entry $= "") {
		return $LBPref::GlobalPageSize;
	}
	return getField(%entry, 0);
}

function Opt_globalSize_getValue() {
	return $LBPref::GlobalPageSize;
}

function Opt_globalSize_decrease() {
	%index = GlobalSizeArray.getIndexByField($LBPref::GlobalPageSize, 1);
	%index --;
	if (%index < 0) {
		%index = GlobalSizeArray.getSize() - 1;
	}
	$LBPref::GlobalPageSize = getField(GlobalSizeArray.getEntry(%index), 1);
}

function Opt_globalSize_increase() {
	%index = GlobalSizeArray.getIndexByField($LBPref::GlobalPageSize, 1);
	%index ++;
	if (%index >= GlobalSizeArray.getSize()) {
		%index = 0;
	}
	$LBPref::GlobalPageSize = getField(GlobalSizeArray.getEntry(%index), 1);
}


//-----------------------------------------------------------------------------

function Opt_chatMessageSize_getDisplay() {
	%entry = ChatMessageSizeArray.getEntryByField($LBPref::ChatMessageSize, 1);
	if (%entry $= "") {
		return $LBPref::ChatMessageSize;
	}
	return getField(%entry, 0);
}

function Opt_chatMessageSize_getValue() {
	return $LBPref::ChatMessageSize;
}

function Opt_chatMessageSize_decrease() {
	%index = ChatMessageSizeArray.getIndexByField($LBPref::ChatMessageSize, 1);
	%index --;
	if (%index < 0) {
		%index = ChatMessageSizeArray.getSize() - 1;
	}
	$LBPref::ChatMessageSize = getField(ChatMessageSizeArray.getEntry(%index), 1);
	PlayGui.positionMessageHud();
}

function Opt_chatMessageSize_increase() {
	%index = ChatMessageSizeArray.getIndexByField($LBPref::ChatMessageSize, 1);
	%index ++;
	if (%index >= ChatMessageSizeArray.getSize()) {
		%index = 0;
	}
	$LBPref::ChatMessageSize = getField(ChatMessageSizeArray.getEntry(%index), 1);
	PlayGui.positionMessageHud();
}

function Opt_noholepunch_getDisplay() {
	return $pref::NoHolePunching ? "Disabled" : "Enabled";
}

function Opt_noholepunch_getValue() {
	return $pref::NoHolePunching;
}

function Opt_noholepunch_decrease() {
	$pref::NoHolePunching = !$pref::NoHolePunching;
}

function Opt_noholepunch_increase() {
	$pref::NoHolePunching = !$pref::NoHolePunching;
}

//-----------------------------------------------------------------------------

function Opt_autoLogin_getDisplay() {
	%entry = AutoLoginArray.getEntryByField($LBPref::AutoLogin, 1);
	if (%entry $= "") {
		return $LBPref::AutoLogin;
	}
	return getField(%entry, 0);
}

function Opt_autoLogin_getValue() {
	return $LBPref::AutoLogin;
}

function Opt_autoLogin_decrease() {
	%index = AutoLoginArray.getIndexByField($LBPref::AutoLogin, 1);
	%index --;
	if (%index < 0) {
		%index = AutoLoginArray.getSize() - 1;
	}
	$LBPref::AutoLogin = getField(AutoLoginArray.getEntry(%index), 1);
	$Options::Disable["Online", $Options::AutoLoginUserField] = ($LBPref::AutoLogin !$= "User");
	$Options::Disable["Online", $Options::AutoLoginPassField] = ($LBPref::AutoLogin !$= "User");

	if ($LBPref::AutoLogin !$= "User") {
		$LBPref::AutoLoginUsername = "";
		$LBPref::AutoLoginPassword = "";
	}

	if (ControllerGui.isJoystick()) {
		%control = ControllerGui.control.getName();
	}
	OptionsGui.buildTab("Online");
	if (ControllerGui.isJoystick()) {
		ControllerGui.selectControl(%control);
	}
}

function Opt_autoLogin_increase() {
	%index = AutoLoginArray.getIndexByField($LBPref::AutoLogin, 1);
	%index ++;
	if (%index >= AutoLoginArray.getSize()) {
		%index = 0;
	}
	$LBPref::AutoLogin = getField(AutoLoginArray.getEntry(%index), 1);
	$Options::Disable["Online", $Options::AutoLoginUserField] = ($LBPref::AutoLogin !$= "User");
	$Options::Disable["Online", $Options::AutoLoginPassField] = ($LBPref::AutoLogin !$= "User");

	if ($LBPref::AutoLogin !$= "User") {
		$LBPref::AutoLoginUsername = "";
		$LBPref::AutoLoginPassword = "";
	}

	if (ControllerGui.isJoystick()) {
		%control = ControllerGui.control.getName();
	}
	OptionsGui.buildTab("Online");
	if (ControllerGui.isJoystick()) {
		ControllerGui.selectControl(%control);
	}
}

//-----------------------------------------------------------------------------

function Opt_autoLoginUsername_getValue() {
	return $LBPref::AutoLoginUsername;
}

function Opt_autoLoginUsername_setValue(%value) {
	$LBPref::AutoLoginUsername = %value;
}

function Opt_autoLoginUsername_validate(%value) {
}

//-----------------------------------------------------------------------------

function Opt_autoLoginPassword_getValue() {
	return strDec($LBPref::AutoLoginPassword, 2);
}

function Opt_autoLoginPassword_setValue(%value) {
	$LBPref::AutoLoginPassword = strEnc(%value, 2);
}

function Opt_autoLoginPassword_validate(%value) {
}

//-----------------------------------------------------------------------------

function OptionsGui::buildTab(%this, %tab) {
	%content = ("Options" @ %tab @ "Content");
	%content.clear();

	%width = getWord(%content.extent, 0);
	%rowHeight = 40;

	%titleFont = "<bold:32>";
	%valueFontButton = "<bold:24><just:center>";
	%valueFontSlider = "<bold:24><just:right>";
	%valueFontTextbox = "<bold:24><just:left>";

	for (%i = 0; $Options::Name[%tab, %i] !$= ""; %i ++) {
		%disable = $Options::Disable[%tab, %i];
		if (%disable) {
			continue;
		}

		%name = $Options::Name[%tab, %i];
		%title = $Options::Title[%tab, %i] @ ":";
		%type = $Options::Type[%tab, %i];

		%titleCtrl   = "Options" @ %name @ "Title";
		%displayCtrl = "Options" @ %name @ "Display";
		%valueCtrl   = "Options" @ %name @ "Value";

		%ctrl     = "Options" @ %name @ "Ctrl";
		%upCtrl   = "Options" @ ($Options::Name[%tab, %i - 1]) @ "Ctrl";
		%downCtrl = "Options" @ ($Options::Name[%tab, %i + 1]) @ "Ctrl";

		%leftArrow  = "Options" @ %name @ "LeftArrow";
		%rightArrow = "Options" @ %name @ "RightArrow";
		%button     = "Options" @ %name @ "Button";
		%whatControl = $Options::Ctrl[%tab, %i];

		switch$ (%whatControl) {
			case "slider":
				%valueFont = %valueFontSlider;
				%tickSize = "$pref::Input::ControlDevice $= \"Joystick\" ? " @ %valueCtrl @ ".getJoyTickSize() :" @ %valueCtrl @ ".getTickSize()";
				%commandSlider = "opt_" @ %name @ "_setValue(" @ %valueCtrl @ ".getFormattedValue());";
				%commandLeft   = "opt_" @ %name @ "_decrease(" @ %tickSize @ ");" @ %valueCtrl @ ".setValue(opt_" @ %name @ "_getValue());";
				%commandRight  = "opt_" @ %name @ "_increase(" @ %tickSize @ ");" @ %valueCtrl @ ".setValue(opt_" @ %name @ "_getValue());";
				%commandSlider = %commandSlider @ %displayCtrl @ ".setText(\"" @ %valueFont @ "\" @ opt_" @ %name @ "_getDisplay());";
				%commandLeft   = %commandLeft   @ %displayCtrl @ ".setText(\"" @ %valueFont @ "\" @ opt_" @ %name @ "_getDisplay());";
				%commandRight  = %commandRight  @ %displayCtrl @ ".setText(\"" @ %valueFont @ "\" @ opt_" @ %name @ "_getDisplay());";
				%nameLeft = "Decrease";
				%nameRight = "Increase";
			case "textbox" or "password":
				%valueFont = %valueFontTextbox;
				%commandTextbox = "opt_" @ %name @ "_setValue(" @ %valueCtrl @ ".getValue());";
				%commandValidate = "opt_" @ %name @ "_validate(" @ %valueCtrl @ ".getValue());";
				%commandLeft  = "";
				%commandRight = "";
				%nameLeft = "";
				%nameRight = "";
			case "button":
				%valueFont = %valueFontButton;
				%commandButton = "opt_" @ %name @ "_edit();";
				%commandLeft  = "";
				%commandRight = "";
				%nameLeft = "";
				%nameRight = "";
			default:
				%valueFont = %valueFontButton;
				%commandLeft  = "opt_" @ %name @ "_decrease(); ";
				%commandRight = "opt_" @ %name @ "_increase(); ";
				%commandLeft  = %commandLeft  @ %displayCtrl @ ".setText(\"" @ %valueFont @ "\" @ opt_" @ %name @ "_getDisplay());";
				%commandRight = %commandRight @ %displayCtrl @ ".setText(\"" @ %valueFont @ "\" @ opt_" @ %name @ "_getDisplay());";

				%nameLeft = (%type $= "boolean" ? "Toggle" : "Decrease");
				%nameRight = (%type $= "boolean" ? "Toggle" : "Increase");
		}

		%content.add(new GuiControl(%ctrl) {
			profile = "GuiDefaultProfile";
			horizSizing = "right";
			vertSizing = "bottom";
			position = "0" SPC (%i * %rowHeight);
			extent = %width SPC %rowHeight;
			minExtent = "8 8";
			visible = "1";
			helpTag = "0";
				controlLSUp = %upCtrl;
				controlLSDown = %downCtrl;
				commandRSLeft = %commandLeft;
				commandRSRight = %commandRight;
				commandRepeatRSLeft = true;
				commandRepeatRSRight = true;
				controlOffset = "6 -6";
				controlExtent = (%width - 7) SPC (%rowHeight + 12);
				commandName["RSLeft"] = %nameLeft;
				commandName["RSRight"] = %nameRight;

			new GuiMLTextCtrl(%titleCtrl) {
				profile = "GuiMLTextProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "16 0";
				extent = "360 14";
				minExtent = "8 8";
				visible = "1";
				helpTag = "0";
				lineSpacing = "2";
				allowColorChars = "0";
				maxChars = "-1";
			};
		});

		switch$ (%whatControl) {
			case "slider":
				%range = $Options::Min[%tab, %i] SPC $Options::Max[%tab, %i];
				%defaultValue = call("Opt_" @ %name @ "_getValue");
				%ctrl.add(new GuiBitmapCtrl() {
					profile = "GuiDefaultProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "400 18";
					extent = "230 10";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
					bitmap = "~/client/ui/options/slider_bar";
					wrap = "0";
				});
				%ctrl.add(new GuiSliderCtrl(%valueCtrl) {
					profile = "GuiSliderProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "385 5";
					extent = "260 35";
					minExtent = "8 8";
					visible = "1";
					altCommand = %commandSlider;
					helpTag = "0";
					range = %range;
					ticks = $Options::Ticks[%tab, %i];
					joyTicks = $Options::JoyTicks[%tab, %i];
					value = %defaultValue;
					bitmap = "~/client/ui/options/slider";
				});
				%ctrl.add(new GuiMLTextCtrl(%displayCtrl) {
					profile = "GuiMLTextProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "625 8";
					extent = "75 14";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
					lineSpacing = "2";
					allowColorChars = "0";
					maxChars = "-1";
				});
				eval(%commandSlider); // hack to get slider UI to show textbox.

			case "textbox" or "password":
				%var = $Options::Var[%tab, %i];
				%length = $Options::Length[%tab, %i];
				%defaultValue = call("Opt_" @ %name @ "_getValue");
				%ctrl.add(new GuiControl() {
					profile = "PQTextboxBorderProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "381 4";
					extent = "319 32";
					minExtent = "21 21";
					visible = "1";

					new GuiTextEditCtrl(%valueCtrl) {
						profile = "PQTextboxProfile";
						horizSizing = "right";
						vertSizing = "bottom";
						position = "3 1";
						extent = "313 26";
						minExtent = "8 8";
						visible = "1";
						variable = %var;
						command = %commandTextbox;
						helpTag = "0";
						maxLength = %length;
						maxPixelWidth = "0";
						validate = %commandValidate;
						historySize = "0";
						password = (%whatControl $= "password");
						tabComplete = "0";
						sinkAllKeyEvents = "0";
					};
				});
				%valueCtrl.setValue(%defaultValue);
				eval(%commandTextbox);

			case "button":
				%ctrl.add(new GuiBorderButtonCtrl(%buttonCtrl) {
					profile = "GuiBorderButtonProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "375 -2";
					extent = "331 44";
					minExtent = "8 8";
					visible = "1";
					command = %commandButton;
					helpTag = "0";
					text = "Edit...";
					groupNum = "1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
				});
				%ctrl.commandSelect = %commandButton;
				%ctrl.commandNameSelect = "Edit";
			default:
				%ctrl.add(new GuiMLTextCtrl(%displayCtrl) {
					profile = "GuiMLTextProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "420 5";
					extent = "242 14";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
					lineSpacing = "2";
					allowColorChars = "0";
					maxChars = "-1";
				});
				%ctrl.add(new GuiBorderButtonCtrl(%rightArrow) {
					profile = "GuiBorderButtonProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "662 -2";
					extent = "44 44";
					minExtent = "8 8";
					visible = "1";
					command = %commandRight;
					helpTag = "0";
					text = ">";
					groupNum = "1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
				});
				%ctrl.add(new GuiBorderButtonCtrl(%leftArrow) {
					profile = "GuiBorderButtonProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "375 -2";
					extent = "44 44";
					minExtent = "8 8";
					visible = "1";
					command = %commandLeft;
					helpTag = "0";
					text = "<";
					groupNum = "1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
				});
		}

		%titleCtrl.setText(%titleFont @ %title);
		if (isObject(%displayCtrl)) {
			%display = call("opt_" @ %name @ "_getDisplay");
			%displayCtrl.setText(%valueFont @ %display);
		}
	}
	%content.setHeight(%i * %rowHeight);

	if (ControllerGui.isJoystick()) {
		%this.defaultControl = ("Options" @ ($Options::Name[%tab, 0]) @ "Ctrl");
		ControllerGui.selectControl("Options" @ ($Options::Name[%tab, 0]) @ "Ctrl");
	}
}

//-----------------------------------------------------------------------------

function getMapDisplayName(%device, %action, %fullText) {
	if (%device $= "") {
		return "Nothing";
	}
	if (%device $= "keyboard") {
		if (%action $= "space") {
			return "Space Bar";
		}
		return upperFirst(%action);
	} else if (strstr(%device, "mouse") != -1) {
		// Substitute "mouse" for "button" in the action string:
		%pos = strstr(%action, "button");
		if (%pos != -1) {
			%mods = getSubStr(%action, 0, %pos);
			%object = getSubStr(%action, %pos, 1000);
			%instance = getSubStr(%object, strlen("button"), 1000);
			if (%fullText) {
				if (%instance < 2) {
					if (%mods $= "") {
						%mods = "the ";
					}
					if ($platform $= "macos" && %instance == 0) {
						return %mods @ "Mouse Button";
					}
					if (%instance == 0) {
						return %mods @ "Left Mouse Button";
					}
					return %mods @ "Right Mouse Button";
				} else {
					return %mods @ "Mouse Button " @ (%instance + 1);
				}
			} else {
				if (%instance < 2) {
					if ($platform $= "macos" && %instance == 0) {
						return %mods @ "Mouse Button";
					}
					if (%instance == 0) {
						return %mods @ "Left Mouse";
					}
					return %mods @ "Right Mouse";
				} else {
					return %mods @ "Mouse Btn. " @ (%instance + 1);
				}
			}
		} else {
			if (strstr(%action, "axis") != -1) {
				switch$ (%action) {
				case "xaxis": return "Mouse X Axis";
				case "yaxis": return "Mouse Y Axis";
				case "zaxis": return "Scroll Wheel";
				default:      return "??";
				}
			} else {
				error("Mouse input object other than button or axis passed to getDisplayMapName:" SPC %action @ "!");
			}
		}
	} else if (strstr(%device, "joystick") != -1) {
		// Substitute "joystick" for "button" in the action string:
		%joystickNum = getSubStr(%device, strlen("joystick"), strlen(%device));
		return getJoystickMapName(getJoystickName(%joystickNum), %action);
	}

	return "??";
}

function getJoystickName(%index) {
	%type = getJoystickType(%index);
	if (stripos(%type, "Xbox One") != -1) return "xboxone";
	if (stripos(%type, "X360") != -1) return "xbox360";
	if (stripos(%type, "XInput") != -1) return "xbox360"; //Ew but windows
	if (stripos(%type, "Xbox 360") != -1) return "xbox360";
	if (stripos(%type, "PS4") != -1) return "ps4";
	//TODO: make the configs control this, instead of the other way around

	return "default";
}

function getJoystickMapName(%preset, %action) {
	if ($Controller::ButtonName[%preset, %action] !$= "") {
		return $Controller::ButtonName[%preset, %action];
	}
	return getDefaultControllerMapName(%action);
}

function getDefaultControllerMapName(%action) {
	%pos = strstr(%action, "button");
	if (%pos != -1) {
		%mods = getSubStr(%action, 0, %pos);
		%object = getSubStr(%action, %pos, 1000);
		%instance = getSubStr(%object, strlen("button"), 1000);
		return %mods @ "Button " @ (%instance + 1);
	} else {
		%pos = strstr(%action, "pov");
		if (%pos != -1) {
			%wordCount = getWordCount(%action);
			%mods = %wordCount > 1 ? getWords(%action, 0, %wordCount - 2) @ " " : "";
			%object = getWord(%action, %wordCount - 1);
			switch$ (%object) {
			case "xpov":   %object = "POV1 x";
			case "ypov":   %object = "POV1 y";
			case "upov":   %object = "POV1 up";
			case "dpov":   %object = "POV1 down";
			case "lpov":   %object = "POV1 left";
			case "rpov":   %object = "POV1 right";
			case "xpov2":  %object = "POV2 x";
			case "ypov2":  %object = "POV2 y";
			case "upov2":  %object = "POV2 up";
			case "dpov2":  %object = "POV2 down";
			case "lpov2":  %object = "POV2 left";
			case "rpov2":  %object = "POV2 right";
			default:       %object = "??";
			}
			return %mods @ %object;
		} else {
			%pos = strstr(%action, "axis");
			if (%pos != -1) {
				%wordCount = getWordCount(%action);
				%mods = %wordCount > 1 ? getWords(%action, 0, %wordCount - 2) @ " " : "";
				%object = getWord(%action, %wordCount - 1);
				switch$ (%object) {
				case "xaxis":  %object = "X Axis";
				case "yaxis":  %object = "Y Axis";
				case "zaxis":  %object = "Z Axis";
				case "rxaxis": %object = "Right X Axis";
				case "ryaxis": %object = "Right Y Axis";
				case "rzaxis": %object = "Right Z Axis";
				default:       %object = "??";
				}
				return %mods @ %object;
			} else {
				error("Unsupported Joystick input object passed to getDefaultControllerMapName:" SPC %action @ "!");
			}
		}
	}
}

$Options::HotKey["Keyboard", 0, "Title"]     = "Move Forward";
$Options::HotKey["Keyboard", 0, "Function"]  = "moveforward";
$Options::HotKey["Keyboard", 1, "Title"]     = "Move Left";
$Options::HotKey["Keyboard", 1, "Function"]  = "moveleft";
$Options::HotKey["Keyboard", 2, "Title"]     = "Move Backward";
$Options::HotKey["Keyboard", 2, "Function"]  = "movebackward";
$Options::HotKey["Keyboard", 3, "Title"]     = "Move Right";
$Options::HotKey["Keyboard", 3, "Function"]  = "moveright";
$Options::HotKey["Keyboard", 4, "Title"]     = "Look Up";
$Options::HotKey["Keyboard", 4, "Function"]  = "panUp";
$Options::HotKey["Keyboard", 5, "Title"]     = "Look Left";
$Options::HotKey["Keyboard", 5, "Function"]  = "turnLeft";
$Options::HotKey["Keyboard", 6, "Title"]     = "Look Down";
$Options::HotKey["Keyboard", 6, "Function"]  = "panDown";
$Options::HotKey["Keyboard", 7, "Title"]     = "Look Right";
$Options::HotKey["Keyboard", 7, "Function"]  = "turnRight";
$Options::HotKey["Keyboard", 8, "Title"]     = "Jump";
$Options::HotKey["Keyboard", 8, "Function"]  = "jump";
$Options::HotKey["Keyboard", 9, "Title"]     = "Use PowerUp";
$Options::HotKey["Keyboard", 9, "Function"]  = "mouseFire";
$Options::HotKey["Keyboard", 10, "Title"]    = "Use Blast";
$Options::HotKey["Keyboard", 10, "Function"] = "useblast";
$Options::HotKey["Keyboard", 11, "Title"]    = "Respawn";
$Options::HotKey["Keyboard", 11, "Function"] = "forceRespawn";
$Options::HotKey["Keyboard", 12, "Title"]    = "Global Chat";
$Options::HotKey["Keyboard", 12, "Function"] = "toggleChatHUD";
$Options::HotKey["Keyboard", 13, "Title"]    = "Server Chat";
$Options::HotKey["Keyboard", 13, "Function"] = "togglePrivateChatHUD";
$Options::HotKey["Keyboard", 14, "Title"]    = "Team Chat";
$Options::HotKey["Keyboard", 14, "Function"] = "toggleTeamChatHUD";
$Options::HotKey["Keyboard", 15, "Title"]    = "Free Look";
$Options::HotKey["Keyboard", 15, "Function"] = "freelook";
$Options::HotKey["Keyboard", 16, "Title"]    = "Toggle Interface";
$Options::HotKey["Keyboard", 16, "Function"] = "screenshotMode";
$Options::HotKey["Keyboard", 17, "Title"]    = "Toggle Radar";
$Options::HotKey["Keyboard", 17, "Function"] = "radarSwitch";
$Options::HotKey["Keyboard", 18, "Title"]    = "Spectate Mode";
$Options::HotKey["Keyboard", 18, "Function"] = "toggleSpectateModeType";
$Options::HotKey["Keyboard", 19, "Title"]    = "Score List";
$Options::HotKey["Keyboard", 19, "Function"] = "displayScoreList";
$Options::HotKey["Keyboard", 20, "Title"]    = "Coop Partner View";
$Options::HotKey["Keyboard", 20, "Function"] = "toggleCoopView";
$Options::HotKey["Keyboard", 21, "Title"]    = "Throw Snowball";
$Options::HotKey["Keyboard", 21, "Function"] = "throwSnowball";
$Options::HotKey["Keyboard", 22, "Title"]    = "Taunt: Confusion";
$Options::HotKey["Keyboard", 22, "Function"] = "taunt2";
$Options::HotKey["Keyboard", 23, "Title"]    = "Taunt: Laughter";
$Options::HotKey["Keyboard", 23, "Function"] = "taunt3";
$Options::HotKey["Keyboard", 24, "Title"]    = "Taunt: Mega Marble";
$Options::HotKey["Keyboard", 24, "Function"] = "taunt5";
$Options::HotKey["Keyboard", 25, "Title"]    = "Taunt: Come On";
$Options::HotKey["Keyboard", 25, "Function"] = "taunt7";
$Options::HotKey["Keyboard", 26, "Title"]    = "Taunt: PQ WHERe";
$Options::HotKey["Keyboard", 26, "Function"] = "taunt9";
$Options::HotKey["Keyboard", 27, "Title"]    = "Taunt: Dongers";
$Options::HotKey["Keyboard", 27, "Function"] = "taunt10";
$Options::HotKey["Keyboard", 28, "Title"]    = "Taunt: Owned";
$Options::HotKey["Keyboard", 28, "Function"] = "taunt11";
$Options::HotKey["Keyboard", 29, "Title"]    = "Taunt: Worth It";
$Options::HotKey["Keyboard", 29, "Function"] = "taunt12";
$Options::HotKey["Keyboard", 30, "Title"]    = "Taunt: Good Game";
$Options::HotKey["Keyboard", 30, "Function"] = "taunt14";
$Options::HotKey["Keyboard", 31, "Title"]    = "Taunt: Shazbot";
$Options::HotKey["Keyboard", 31, "Function"] = "taunt15";
$Options::HotKey["Keyboard", 32, "Title"]    = "Taunt: Blue Steal";
$Options::HotKey["Keyboard", 32, "Function"] = "taunt16";

$Options::HotKey["Joystick", 0, "Title"]     = "Jump";
$Options::HotKey["Joystick", 0, "Function"]  = "joyJump";
$Options::HotKey["Joystick", 1, "Title"]     = "Use PowerUp";
$Options::HotKey["Joystick", 1, "Function"]  = "joyMouseFire";
$Options::HotKey["Joystick", 2, "Title"]     = "Use Blast";
$Options::HotKey["Joystick", 2, "Function"]  = "joyUseBlast";
$Options::HotKey["Joystick", 3, "Title"]     = "Respawn";
$Options::HotKey["Joystick", 3, "Function"]  = "joyForceRespawn";
$Options::HotKey["Joystick", 4, "Title"]     = "Pause";
$Options::HotKey["Joystick", 4, "Function"]  = "joyEscapeFromGame";
$Options::HotKey["Joystick", 5, "Title"]     = "Global Chat";
$Options::HotKey["Joystick", 5, "Function"]  = "toggleChatHUD";
$Options::HotKey["Joystick", 6, "Title"]     = "Server Chat";
$Options::HotKey["Joystick", 6, "Function"]  = "togglePrivateChatHUD";
$Options::HotKey["Joystick", 7, "Title"]     = "Team Chat";
$Options::HotKey["Joystick", 7, "Function"]  = "toggleTeamChatHUD";
$Options::HotKey["Joystick", 8, "Title"]     = "Free Look";
$Options::HotKey["Joystick", 8, "Function"]  = "joyFreelook";
$Options::HotKey["Joystick", 9, "Title"]     = "Toggle Interface";
$Options::HotKey["Joystick", 9, "Function"]  = "joyScreenshotMode";
$Options::HotKey["Joystick", 10, "Title"]    = "Toggle Radar";
$Options::HotKey["Joystick", 10, "Function"] = "joyRadarSwitch";
$Options::HotKey["Joystick", 11, "Title"]    = "Enter Spectate";
$Options::HotKey["Joystick", 11, "Function"] = "joyToggleCamera";
$Options::HotKey["Joystick", 12, "Title"]    = "Change Spectate Mode";
$Options::HotKey["Joystick", 12, "Function"] = "joyToggleSpectateModeType";
$Options::HotKey["Joystick", 13, "Title"]    = "Score List";
$Options::HotKey["Joystick", 13, "Function"] = "joyDisplayScoreList";
$Options::HotKey["Joystick", 14, "Title"]    = "Coop Partner View";
$Options::HotKey["Joystick", 14, "Function"] = "joyToggleCoopView";
$Options::HotKey["Joystick", 15, "Title"]    = "Throw Snowball";
$Options::HotKey["Joystick", 15, "Function"] = "joyThrowSnowball";
$Options::HotKey["Joystick", 16, "Title"]    = "Confusion Taunt";
$Options::HotKey["Joystick", 16, "Function"] = "taunt2";
$Options::HotKey["Joystick", 17, "Title"]    = "Laughter Taunt";
$Options::HotKey["Joystick", 17, "Function"] = "taunt3";
$Options::HotKey["Joystick", 18, "Title"]    = "Mega Taunt";
$Options::HotKey["Joystick", 18, "Function"] = "taunt5";
$Options::HotKey["Joystick", 19, "Title"]    = "Come On Taunt";
$Options::HotKey["Joystick", 19, "Function"] = "taunt7";
$Options::HotKey["Joystick", 20, "Title"]    = "PQ WHERe Taunt";
$Options::HotKey["Joystick", 20, "Function"] = "taunt9";
$Options::HotKey["Joystick", 21, "Title"]    = "Dongers Taunt";
$Options::HotKey["Joystick", 21, "Function"] = "taunt10";
$Options::HotKey["Joystick", 22, "Title"]    = "Owned Taunt";
$Options::HotKey["Joystick", 22, "Function"] = "taunt11";
$Options::HotKey["Joystick", 23, "Title"]    = "Worth It Taunt";
$Options::HotKey["Joystick", 23, "Function"] = "taunt12";
$Options::HotKey["Joystick", 24, "Title"]    = "Good Game Taunt";
$Options::HotKey["Joystick", 24, "Function"] = "taunt14";
$Options::HotKey["Joystick", 25, "Title"]    = "Shazbot Taunt";
$Options::HotKey["Joystick", 25, "Function"] = "taunt15";
$Options::HotKey["Joystick", 26, "Title"]    = "Blue Steal Taunt";
$Options::HotKey["Joystick", 26, "Function"] = "taunt16";

if (isObject(OptionsEventMap))
	OptionsEventMap.delete();
new ActionMap(OptionsEventMap);

$Options::Events["JoyButton"] = "button0 button1 button2 button3 button4 button5 button6 button7 button8 button9 button10 button11 button12 button13 button14 button15 button16 button17 button18 button19 button20 button21 button22 button23 button24 button25 button26 button27 button28 button29 button30 button31";
$Options::Events["JoyAxis"]   = "xaxis yaxis zaxis rxaxis ryaxis rzaxis xpov ypov upov dpov lpov rpov xpov2 ypov2 upov2 dpov2 lpov2 rpov2";
$Options::Events["Key"]       = "a b c d e f g h i j k l m n o p q r s t u v w x y z 0 1 2 3 4 5 6 7 8 9 backspace tab return enter shift ctrl alt pause capslock escape space pagedown pageup end home left up right down print insert delete help win_lwindow win_rwindow win_apps cmd opt lopt ropt numpad0 numpad1 numpad2 numpad3 numpad4 numpad5 numpad6 numpad7 numpad8 numpad9 numpadmult numpadadd numpadsep numpadminus numpaddecimal numpaddivide numpadenter f1 f2 f3 f4 f5 f6 f7 f8 f9 f10 f11 f12 f13 f14 f15 f16 f17 f18 f19 f20 f21 f22 f23 f24 numlock scrolllock lshift rshift lcontrol rcontrol lalt ralt tilde minus equals lbracket rbracket backslash semicolon apostrophe comma period slash lessthan";
$Options::Events["Mouse"]     = "xaxis yaxis zaxis button0 button1 button2 button3 button4 button5 button6 button7 button8";

function OptionsGui::buildEvents(%this, %device, %category) {
	for (%joy = 0; getJoystickAxes(%joy) !$= ""; %joy ++) {
		for (%i = 0; %i < getWordCount($Options::Events[%category]); %i ++) {
			%event = getWord($Options::Events[%category], %i);
			eval("function __opt" @ %joy @ %category @ %event @ "(%val) {OptionsGui.event(\"" @ %joy @ "\", \"" @ %category @ "\", \"" @ %event @ "\", %val);}");
			OptionsEventMap.bind(%device, %event, "__opt" @ %joy @ %category @ %event);
			%this.eventValue[%joy, %category, %event] = 0;
		}
	}
}

OptionsGui.buildEvents("joystick", "JoyButton");
OptionsGui.buildEvents("joystick", "JoyAxis");
OptionsGui.buildEvents("keyboard", "Key");
OptionsGui.buildEvents("mouse",    "Mouse");

function OptionsGui::enableJoystick(%this) {
	// this screws my computer up, making this a pref
	if ($Pref::EnableDirectInput)
		$enableDirectInput = "1";
	$pref::Input::JoystickEnabled = 0;
	activateDirectInput();
	enableJoystick();
	OptionsEventMap.push();
	//GlobalActionMap.pop();
	//MoveMap.pop();
	//GamePadMap.pop();
}

function OptionsGui::disableJoystick(%this) {
	// this screws my computer up, making this a pref
	if ($Pref::EnableDirectInput)
		$enableDirectInput = "0";
	deactivateDirectInput();
	disableJoystick();
	OptionsEventMap.pop();
	//GlobalActionMap.push();
}

function isSharedTriggers(%joystickNum) {
	%count = getField(getJoystickAxes(%joystickNum), 0);
	//Can't deal with this
	if ($platform !$= "windows") return false;
	//Probably should have a console function for this
	if ($Input::XInput) return false;
	//5 fields -- only one trigger axis. Probably shared
	if (%count == 5) return true;
	//No idea, best to not chance it
	return false;
}

function getBindFunction(%function, %index) {
	return %function @ (%index == 0 ? "" : %index);
}

function OptionsGui::generateHotkeysList(%this) {
	%height = 37;

	OptionsInputHotkeys.clear();
	%device = $pref::Input::ControlDevice;
	%map = (%device $= "Joystick") ? JoystickMap : MoveMap;

	%lastBoxName = "";
	%row = 0;
	for (%i = 0; $Options::HotKey[%device, %i, "Title"] !$= ""; %i ++) {
		%title    = $Options::HotKey[%device, %i, "Title"];
		%function = $Options::HotKey[%device, %i, "Function"];

		//Can you not have more than 4 buttons per bind please
		for (%j = 0; %j < 4; %j ++) {
			%bindFn = getBindFunction(%function, %j);
			%binding = %map.getBinding(%bindFn);

			%boxName = "Opt_Input_" @ %device @ "_" @ %bindFn @ "_Box";
			%buttonName = "Opt_Input_" @ %device @ "_" @ %bindFn;

			//Only show secondary binds if they exist
			if ((%binding $= "") && (%j > 0)) {
				continue;
			}

			OptionsInputHotkeys.add(
				%box = new GuiControl(%boxName) {
					profile = "GuiMLTextProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = 0 SPC (%row * %height);
					extent = "400 37";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
						controlSelect = %buttonName;
						controlUp = %lastBoxName;
						controlName["Select"] = "Edit";
						commandRight = "OptionsGui.inputGoRight(\"" @ %boxName @ "\");";
						commandRepeatRight = true;
						controlOffset = "0 -4";
						controlExtent = "400 45";
				}
			);
			%lastBoxName.controlDown = %boxName;
			%lastBoxName = %boxName;

			if (%j == 0) {
				%box.add(new GuiMLTextCtrl() {
					profile = "GuiMLTextProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "10 4";
					extent = "200 30";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
					lineSpacing = "2";
					allowColorChars = "0";
					maxChars = "-1";
						defaultText = "<bold:28>" @ %title @ ":";
				});

				%addButton = "Opt_Input_Add_" @ %device @ "_" @ %bindFn;
				%box.add(new GuiBorderButtonCtrl(%addButton) {
					profile = "PQButton26Profile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "355 -4";
					extent = "45 45";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
					text = "+";
					command = "OptionsGui.addBinding(\"" @ %bindFn @ "\", \"" @ %title @ "\");";
					groupNum = "-1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
						controlLeft = %buttonName;
						controlCancel = %box;
						commandName["Select"] = "Add";
						commandSelect = "OptionsGui.addBinding(\"" @ %bindFn @ "\", \"" @ %title @ "\");";
						controlName["Cancel"] = "Cancel";
				});
				%sideButton = %addButton;
			} else {
				%subButton = "Opt_Input_Sub_" @ %device @ "_" @ %bindFn;
				%box.add(new GuiBorderButtonCtrl(%subButton) {
					profile = "PQButton26Profile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "355 -4";
					extent = "45 45";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
					text = "-";
					command = "OptionsGui.removeBinding(\"" @ %bindFn @ "\", \"" @ %title @ "\");";
					groupNum = "-1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
						controlLeft = %buttonName;
						controlCancel = %box;
						commandName["Select"] = "Remove";
						commandSelect = "OptionsGui.removeBinding(\"" @ %bindFn @ "\", \"" @ %title @ "\");";
						controlName["Cancel"] = "Cancel";
				});
				%sideButton = %subButton;
			}

			//Too many bindings!
			if (%j == (4 - 1)) {
				%addButton = "Opt_Input_Add_" @ %device @ "_" @ getBindFunction(%function, 0);
				%addButton.setActive(0);
			}

			if (%device $= "Joystick") {
				%joyDevice = getField(%binding, 0);
				%joyAction = getField(%binding, 1);
				%joyBitmap = getJoystickBindingBitmap(%binding);
				%box.add(new GuiBitmapButtonCtrl(%buttonName) {
					profile = "GuiDefaultProfile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "300 0";
					extent = "55 37";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
					text = "Button";
					command = "OptionsGui.remap(\"" @ %bindFn @ "\", \"" @ %title @ "\");";
					groupNum = "-1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
					bitmap = %joyBitmap;
					controlCancel = %box;
					controlRight = %sideButton;
					commandName["Select"] = "Edit";
					commandSelect = "OptionsGui.remap(\"" @ %bindFn @ "\", \"" @ %title @ "\");";
					controlName["Cancel"] = "Cancel";
				});
			} else {
				%keyDevice = getField(%binding, 0);
				%keyAction = getField(%binding, 1);
				%actionName = getMapDisplayName(%keyDevice, %keyAction, false);

				%box.add(new GuiBorderButtonCtrl(%buttonName) {
					profile = "PQButton20Profile";
					horizSizing = "right";
					vertSizing = "bottom";
					position = "200 -4";
					extent = "163 45";
					minExtent = "8 8";
					visible = "1";
					helpTag = "0";
					text = %actionName;
					command = "OptionsGui.remap(\"" @ %bindFn @ "\", \"" @ %title @ "\");";
					groupNum = "-1";
					buttonType = "PushButton";
					repeatPeriod = "1000";
					repeatDecay = "1";
				});
			}

			%row ++;
		}
	}
	%lastBoxName.controlDown = OptionsControlsKeyboardButton;
	OptionsControlsKeyboardButton.controlUp = %lastBoxName;

	OptionskeyboardSpeedValue.setValue(opt_keyboardSpeed_getValue());
	OptionsmouseSpeedValue.setValue(opt_mouseSpeed_getValue());

	OptionsInputHotkeys.setExtent(400 SPC (%row * %height));
	%this.updateControlDisplay();

	%row = 0;

	if (ControllerGui.isJoystick()) {
		%this.defaultControl = OptionsInputHotkeys.getObject(0);
		ControllerGui.selectControl(%this.defaultControl);
	}

	OptionsControlsJoystickPanel.setVisible(ControllerGui.isJoystick());
	OptionsControlsKeyboardPanel.setVisible(!ControllerGui.isJoystick());
}

function OptionsGui::setControlDevice(%this, %device) {
	$pref::Input::ControlDevice = %device;

	%this.controlDevice = %device;
	%this.generateHotkeysList();
	%this.updateControlDisplay();

	if (%device $= "Joystick") {
		enableControllerUI();
	} else {
		disableControllerUI();
	}
}

function OptionsGui::inputGoRight(%this, %box) {
	OptionsControlsInvertLX.controlLeft = %box;
	OptionsControlsInvertLY.controlLeft = %box;
	OptionsControlsLSMovement.controlLeft = %box;
	OptionsControlsLSCamera.controlLeft = %box;
	OptionsControlsJoystickSpeedXSlider.controlLeft = %box;
	OptionsControlsJoystickSpeedYSlider.controlLeft = %box;
	ControllerGui.selectControl(OptionsControlsInvertLX);
}

function OptionsGui::updateControlDisplay(%this) {
	for (%i = 0; $Options::HotKey["Keyboard", %i, "Title"] !$= ""; %i ++) {
		%function = $Options::HotKey["Keyboard", %i, "Function"];

		%keyButton = "Opt_Input_Keyboard_" @ %function;
		if (!isObject(%keyButton)) {
			continue;
		}
		%keyBinding = MoveMap.getBinding(%function);
		%keyDevice = getField(%keyBinding, 0);
		%keyAction = getField(%keyBinding, 1);

		%actionName = getMapDisplayName(%keyDevice, %keyAction, false);
		%keyButton.setVisible($pref::Input::ControlDevice $= "Keyboard");
		%keyButton.setText(%actionName);
	}

	for (%i = 0; $Options::HotKey["Joystick", %i, "Title"] !$= ""; %i ++) {
		%function = $Options::HotKey["Joystick", %i, "Function"];

		%joyButton = "Opt_Input_Joystick_" @ %function;
		if (!isObject(%joyButton)) {
			continue;
		}
		%joyBinding = JoystickMap.getBinding(%function);
		%joyDevice = getField(%joyBinding, 0);
		%joyAction = getField(%joyBinding, 1);

		//Check for DirectInput bullshit
		if (isSharedTriggers(0)) {
			if ($pref::Input::TriggerAction["Left"] $= %function) {
				%joyAction = $pref::Input::TriggerAction["Left"];
			}
			if ($pref::Input::TriggerAction["Right"] $= %function) {
				%joyAction = $pref::Input::TriggerAction["Right"];
			}
		}

		%joyBitmap = getJoystickBindingBitmap(%joyBinding);
		%joyButton.setVisible($pref::Input::ControlDevice $= "Joystick");
		%joyButton.setBitmap(%joyBitmap);
	}

	OptionsControlsJoystickButton.setValue($pref::Input::ControlDevice $= "Joystick");
	OptionsControlsKeyboardButton.setValue($pref::Input::ControlDevice $= "Keyboard");

	OptionsControlsLeftJoystick.setVisible(true);
	OptionsControlsRightJoystick.setVisible(true);

	%leftDead  = 0.23;
	%rightDead = 0.23;

	%leftScale  = 1;
	%rightScale = 1;

	if ($pref::Input::Joystick::RightStickMovement) {
		%rightScale = 1.68; //Slightly more than sqrt(2)
	} else {
		%leftScale = 1.68; //Slightly more than sqrt(2)
	}

	OptionsControlsLSMovement.setValue(!$pref::Input::Joystick::RightStickMovement);
	OptionsControlsLSCamera.setValue($pref::Input::Joystick::RightStickMovement);
	OptionsControlsRSMovement.setValue($pref::Input::Joystick::RightStickMovement);
	OptionsControlsRSCamera.setValue(!$pref::Input::Joystick::RightStickMovement);

	%invertLX = $pref::Input::InvertJoystickLX ? -1 : 1;
	%invertRX = $pref::Input::InvertJoystickRX ? -1 : 1;
	%invertLY = $pref::Input::InvertJoystickLY ? -1 : 1;
	%invertRY = $pref::Input::InvertJoystickRY ? -1 : 1;

	//Get raw movement values for each joystick axis from the gui.
	%lx = %this.eventValue[0, "JoyAxis",  "xaxis"];
	%ly = %this.eventValue[0, "JoyAxis",  "yaxis"];
	%rx = %this.eventValue[0, "JoyAxis", "rxaxis"];
	%ry = %this.eventValue[0, "JoyAxis", "ryaxis"];

	//Normalize the movement axis to be around a circle
	if ($pref::Input::Joystick::RightStickMovement) {
		if (VectorLen(%rx SPC %ry SPC 0) > 1) {
			%rx = getWord(VectorNormalize(%rx SPC %ry SPC 0), 0);
			%ry = getWord(VectorNormalize(%rx SPC %ry SPC 0), 1);
		}
	} else {
		if (VectorLen(%lx SPC %ly SPC 0) > 1) {
			%lx = getWord(VectorNormalize(%lx SPC %ly SPC 0), 0);
			%ly = getWord(VectorNormalize(%lx SPC %ly SPC 0), 1);
		}
	}

	//Get individual up/down/left/right components
	%leftUp     = max(0, -%invertLY * %ly);
	%rightUp    = max(0, -%invertRY * %ry);
	%leftLeft   = max(0, -%invertLX * %lx);
	%rightLeft  = max(0, -%invertRX * %rx);
	%leftDown   = max(0,  %invertLY * %ly);
	%rightDown  = max(0,  %invertRY * %ry);
	%leftRight  = max(0,  %invertLX * %lx);
	%rightRight = max(0,  %invertRX * %rx);

	//Ignore any inputs that are in the dead zones, and scale each by their scale factors
	%leftUp     = (%leftUp     < %leftDead  ? 0.0 : %leftScale  * %leftUp);
	%rightUp    = (%rightUp    < %rightDead ? 0.0 : %rightScale * %rightUp);
	%leftLeft   = (%leftLeft   < %leftDead  ? 0.0 : %leftScale  * %leftLeft);
	%rightLeft  = (%rightLeft  < %rightDead ? 0.0 : %rightScale * %rightLeft);
	%leftDown   = (%leftDown   < %leftDead  ? 0.0 : %leftScale  * %leftDown);
	%rightDown  = (%rightDown  < %rightDead ? 0.0 : %rightScale * %rightDown);
	%leftRight  = (%leftRight  < %leftDead  ? 0.0 : %leftScale  * %leftRight);
	%rightRight = (%rightRight < %rightDead ? 0.0 : %rightScale * %rightRight);

	//Arrow dimensions, from the GUI
	%arrowSide = 39;
	%arrowLong = 54;

	//These just resize easily
	OptionsControlsLeftJoystickArrowDown.setExtent  (%arrowSide SPC %arrowLong * %leftDown );
	OptionsControlsRightJoystickArrowDown.setExtent (%arrowSide SPC %arrowLong * %rightDown);
	OptionsControlsLeftJoystickArrowRight.setExtent (               %arrowLong * %leftRight  SPC %arrowSide);
	OptionsControlsRightJoystickArrowRight.setExtent(               %arrowLong * %rightRight SPC %arrowSide);

	//These need a party to work right
	OptionsControlsLeftJoystickArrowUp.setExtent          (%arrowSide SPC %arrowLong * %leftUp       );
	OptionsControlsLeftJoystickArrowUp.setPosition        (0          SPC %arrowLong * (1 - %leftUp ));
	OptionsControlsLeftJoystickArrowUpInner.setPosition   (0          SPC %arrowLong * (%leftUp  - 1));
	OptionsControlsRightJoystickArrowUp.setExtent         (%arrowSide SPC %arrowLong * %rightUp      );
	OptionsControlsRightJoystickArrowUp.setPosition       (0          SPC %arrowLong * (1 - %rightUp));
	OptionsControlsRightJoystickArrowUpInner.setPosition  (0          SPC %arrowLong * (%rightUp - 1));
	OptionsControlsLeftJoystickArrowLeft.setExtent        (               %arrowLong * %leftLeft        SPC %arrowSide);
	OptionsControlsLeftJoystickArrowLeft.setPosition      (               %arrowLong * (1 - %leftLeft ) SPC 0);
	OptionsControlsLeftJoystickArrowLeftInner.setPosition (               %arrowLong * (%leftLeft  - 1) SPC 0);
	OptionsControlsRightJoystickArrowLeft.setExtent       (               %arrowLong * %rightLeft       SPC %arrowSide);
	OptionsControlsRightJoystickArrowLeft.setPosition     (               %arrowLong * (1 - %rightLeft) SPC 0);
	OptionsControlsRightJoystickArrowLeftInner.setPosition(               %arrowLong * (%rightLeft - 1) SPC 0);

	//Update some labels
	%this.updateJoystickSpeedX();
	%this.updateJoystickSpeedY();
	%this.updateMouseSpeed();
	%this.updateKeyboardSpeed();
}

function OptionsGui::setJoystickMovement(%this, %stick, %which) {
	$pref::Input::Joystick::RightStickMovement = (%stick $= "LS" && %which $= "Camera") || (%stick $= "RS" && %which $= "Movement");
	%this.updateControlDisplay();
}

function OptionsGui::updateJoystickSpeedX(%this) {
	%value = OptionsControlsJoystickSpeedXSlider.getFormattedValue(10, 90);
	OptionsControlsJoystickSpeedXTitle.setText("<bold:24>X: <just:right>" @ %value);
}

function OptionsGui::updateJoystickSpeedY(%this) {
	%value = OptionsControlsJoystickSpeedYSlider.getFormattedValue(10, 90);
	OptionsControlsJoystickSpeedYTitle.setText("<bold:24>Y: <just:right>" @ %value);
}

function OptionsGui::updateMouseSpeed(%this) {
	opt_keyboardSpeed_setValue(OptionskeyboardSpeedValue.getFormattedValue());
	OptionskeyboardSpeedDisplay.setText("<bold:24><just:right>" @ opt_keyboardSpeed_getDisplay());
}

function OptionsGui::updateKeyboardSpeed(%this) {
	opt_mouseSpeed_setValue(OptionsmouseSpeedValue.getFormattedValue());
	OptionsmouseSpeedDisplay.setText("<bold:24><just:right>" @ opt_mouseSpeed_getDisplay());
}

function OptionsGui::setYAxis(%this, %value) {
	%this.eventValue[0, "JoyAxis",  "yaxis"] = %value;
	%this.updateControlDisplay();
}
function OptionsGui::setRYAxis(%this, %value) {
	%this.eventValue[0, "JoyAxis", "ryaxis"] = %value;
	%this.updateControlDisplay();
}
function OptionsGui::setXAxis(%this, %value) {
	%this.eventValue[0, "JoyAxis",  "xaxis"] = %value;
	%this.updateControlDisplay();
}
function OptionsGui::setRXAxis(%this, %value) {
	%this.eventValue[0, "JoyAxis", "rxaxis"] = %value;
	%this.updateControlDisplay();
}

//-----------------------------------------------------------------------------

function OptionsGui::addBinding(%this, %ctrl, %name) {
	%map = ($pref::Input::ControlDevice $= "Joystick") ? JoystickMap : MoveMap;

	//Can you not have more than 4 buttons per bind please
	for (%i = 0; %i < 4; %i ++) {
		%bindFn = getBindFunction(%ctrl, %i);
		%binding = %map.getBinding(%bindFn);
		if (%binding $= "") {
			break;
		}
	}

	%this.remap(%bindFn, %name);
}

function OptionsGui::removeBinding(%this, %ctrl, %name) {
	if ($pref::Input::ControlDevice $= "Joystick") {
		//TODO: DI triggers
		%binding = JoystickMap.getBinding(%ctrl);
		JoystickMap.unbind(getField(%binding, 0), getField(%binding, 1));
	} else {
		%binding = MoveMap.getBinding(%ctrl);
		MoveMap.unbind(getField(%binding, 0), getField(%binding, 1));
	}
	%this.generateHotkeysList();
}

function OptionsGui::remap(%this, %ctrl, %name) {
	if ($pref::Input::ControlDevice $= "Joystick") {
		//Joystick rebinding
		%this.joyRemapping = true;
		%this.remapName = %name;
		%this.remapCommand = %ctrl;

		ControllerUIMap.pop();
		OptionsEventMap.push();
	}
	OptRemapText.setText("<just:center><font:20>Press a new key or button for \"" @ %name @ "\"");
	OptRemapInputCtrl.ctrl = %ctrl;
	OptRemapInputCtrl.nameText = %name;
	OptRemapInputCtrl.actionMap = %name;
	if (ControllerGui.isJoystick()) {
		RemapDlg.prevControl = ControllerGui.control;
	}
	Canvas.pushDialog(RemapDlg);
}

function OptionsGui::closeRemap(%this) {
	Canvas.popDialog(RemapDlg);

	if (ControllerGui.isJoystick() && isObject(RemapDlg.prevControl)) {
		ControllerGui.selectControl(RemapDlg.prevControl);
	}
}

//------------------------------------------------------------------------------

function OptionsGui::checkBindings(%this) {
	%map = ($pref::Input::ControlDevice $= "Joystick") ? JoystickMap : MoveMap;

	for (%i = 0; $Options::HotKey[$pref::Input::ControlDevice, %i, "Function"] !$= ""; %i++) {
		%function = $Options::HotKey[$pref::Input::ControlDevice, %i, "Function"];

		//Can you not have more than 4 buttons per bind please
		for (%j = 0; %j < 4; %j ++) {
			%bindFn = getBindFunction(%function, %j);
			%binding = %map.getBinding(%bindFn);
			if (%binding $= "") {
				//Try to get the next one
				for (%k = %j + 1; %k < 4; %k ++) {
					%bindFnK = getBindFunction(%function, %k);
					%bindingK = %map.getBinding(%bindFnK);
					if (%bindingK !$= "") {
						//Yep, a later one is bound, so replace the former
						%map.bind(getField(%bindingK, 0), getField(%bindingK, 1), %bindFn);
						break;
					}
				}
			}
		}
	}
}

//------------------------------------------------------------------------------

function OptionsGui::redoMapping(%this, %device, %action, %cmd) {
	if (%this.joyRemapping) {
		%this.setJoyMapping(%action);
	} else {
		MoveMap.bind(%device, %action, %cmd);
		%this.onNewBinding();
	}
}

function OptionsGui::onNewBinding(%this) {
	%this.checkBindings();
	%this.updateControlDisplay();
	%this.generateHotkeysList();
	%this.joyRemapping = false;
}

//------------------------------------------------------------------------------
function findRemapCmdIndex(%command) {
	for (%i = 0; $Options::HotKey[$pref::Input::ControlDevice, %i, "Function"] !$= ""; %i++) {
		//Can you not have more than 4 buttons per bind please
		for (%j = 0; %j < 4; %j ++) {
			%bindFn = getBindFunction($Options::HotKey[$pref::Input::ControlDevice, %i, "Function"], %j);
			if (%command $= %bindFn)
				return %i;
		}
	}
	return -1;
}

function OptRemapInputCtrl::onInputEvent(%this, %device, %action) {
	error("** onInputEvent called - device = " @ %device @ ", action = " @ %action @ " **");

	// Test for the reserved keystrokes:
	if (%device $= "keyboard") {
		// Cancel...
		if (%action $= "escape") {
			// Do nothing...
			OptionsGui.closeRemap();
			OptionsGui.joyRemapping = false;
			return;
		}
	}
	if (%action $= "")
		return;

	//Ignore key presses and mouse on joystick remap
	if (OptionsGui.joyRemapping && ((stripos(%device, "keyboard") != -1) || (stripos(%device, "mouse") != -1))) {
		return;
	}

	OptionsGui.closeRemap();

	%cmd  = %this.ctrl;
	%name = %this.nameText;

	// First check to see if the given action is already mapped:
	%prevMap = moveMap.getCommand(%device, %action);
	if (findRemapCmdIndex(%prevMap) !$= findRemapCmdIndex(%cmd)) {
		if (%prevMap $= "") {
			moveMap.bind(%device, %action, %cmd);
			OptionsGui.onNewBinding();
		} else {
			%mapName = getMapDisplayName(%device, %action);
			%prevMapIndex = findRemapCmdIndex(%prevMap);
			if (%prevMapIndex == -1) {
				MessageBoxOK("REMAP FAILED", "\"" @ %mapName @ "\" is already bound to a non-remappable command!", "", true);
			} else {
				%prevCmdName = $Options::HotKey[$pref::Input::ControlDevice, %prevMapIndex, "Title"];
				MessageBoxYesNo("WARNING",
					"\"" @ %mapName @ "\" is already bound to \""
					@ %prevCmdName @ "\"!\nDo you want to undo this mapping?",
					"OptionsGui.redoMapping(" @ %device @ ", \"" @ %action @ "\", \"" @ %cmd @ "\");", "");
			}
			return;
		}
	}
}

function OptionsGui::exportJoystick(%this, %target, %category) {
	for (%joy = 0; getJoystickAxes(%joy) !$= ""; %joy ++) {
		for (%i = 0; %i < getWordCount($Options::Events[%category]); %i ++) {
			%event = getWord($Options::Events[%category], %i);
			%val = %this.eventValue[%joy, %category, %event];

			%target.eventValue[%joy, %category, %event] = %val;
		}
	}
}

function OptionsGui::event(%this, %joy, %category, %event, %val) {
	%this.eventValue[%joy, %category, %event] = %val;

	if ($debugInput) {
		echo("Opt:" SPC %joy SPC %category SPC %event SPC %val);
	}

	if (%this.joyRemapping) {
		if (%category $= "JoyAxis" || %category $= "JoyButton") {
			//So without XInput, Windows will put both triggers on one axis as + and - for LT and RT respectively
			// This makes it a pain in the ass and we have to override it.
			if (%event $= "zaxis" && isSharedTriggers(0)) {
				%this.remapDInput = true;
				if (%val > 0.5) {
					//Positive: LT
					%trigger = "Left";
					%otherTrigger = "Right";
					%axis = "zaxis";
				} else if (%val < -0.5) {
					//Negative: RT
					%trigger = "Right";
					%otherTrigger = "Left";
					%axis = "rzaxis";
				}
				if (%trigger !$= "") {
					%this.remapDInputTrigger = %trigger;
					%this.closeRemap();
					//Check if we have anything on the other axis and need to pop a warning
					if ($pref::Input::TriggerAction[%otherTrigger] !$= "" && $pref::Input::TriggerAction[%otherTrigger] !$= %this.remapCommand) {
						//Yes we do, show a warning
						MessageBoxYesNo("DirectInput Triggers", "Due to the way Windows reads your controller, you will be unable to press" SPC
							"both LT and RT at the same time. You can still bind an action to each if you want, but note that pressing both" SPC
							"at the same time will make neither one of the actions happen. Do you still want to bind this?",
							"OptionsGui.onJoyRebind(\"" @ %axis @ "\");", "OptionsGui.cancelDITriggerBind();");
					} else {
						//Don't have the other one bound, just bind it like normal
						OptionsGui.onJoyRebind(%axis);
					}
				}
			} else if (%val > 0 && (%event !$= "xaxis" && %event !$= "yaxis" && %event !$= "rxaxis" && %event !$= "ryaxis")) {
				if (%event $= "zaxis" && !isSharedTriggers(0)) {
					if ($pref::Input::TriggerAction["Left"] !$= "" || $pref::Input::TriggerAction["Right"] !$= "") {
						//Make sure to unbind the zaxis
						%old = JoystickMap.getCommand("joystick0", "zaxis");
						if (%old $= "joyDITrigger") {
							JoystickMap.unbind("joystick0", "zaxis");
							$pref::Input::TriggerAction["Left"] = "";
							$pref::Input::TriggerAction["Right"] = "";
						}
					}
				}
				//Normal axis that isn't bullshit or a movement/camera stick
				OptionsGui.onJoyRebind(%event);
			}
		}
		return;
	}
}

function OptionsGui::cancelDITriggerBind(%this) {
	%this.remapDInput = false;
	%this.remapDInputTrigger = "";

	//Restart the remapping
	%this.remapJoystick(%this.remapName, %this.remapCommand);
}

function OptionsGui::onJoyRebind(%this, %action) {
	%this.closeRemap();

	OptionsEventMap.pop();
	ControllerUIMap.push();

	//Hack: Update ControllerUI with everything we know
	%this.exportJoystick(ControllerGui, "JoyAxis");
	%this.exportJoystick(ControllerGui, "JoyButton");

	if (%action $= "")
		return;

	%cmd  = %this.remapCommand;
	%name = %this.remapName;

	%actionName = getJoystickMapName(getJoystickName(0), %action);

	// First check to see if the given action is already mapped:
	%prevMap = JoystickMap.getCommand("joystick0", %action);
	if (findRemapCmdIndex(%prevMap) !$= findRemapCmdIndex(%cmd)) {
		if (%prevMap $= "") {
			%this.setJoyMapping(%action);
			%this.onNewBinding();
		} else {
			%prevMapIndex = findRemapCmdIndex(%prevMap);
			if (%prevMapIndex == -1) {
				MessageBoxOK("REMAP FAILED", "\"" @ %actionName @ "\" is already bound to a non-remappable command!", "", true);
			} else {
				%prevCmdName = $Options::HotKey[$pref::Input::ControlDevice, %prevMapIndex, "Title"];
				MessageBoxYesNo("WARNING",
					"\"" @ %actionName @ "\" is already bound to \""
					@ %prevCmdName @ "\"!\nDo you want to undo this mapping?",
					"OptionsGui.setJoyMapping(\"" @ %action @ "\");", "");
			}
		}
	}
}

function OptionsGui::setJoyMapping(%this, %action) {
	if (!%this.joyRemapping) {
		echo("setJoyMapping when not mapping");
		return;
	}
	%this.joyRemapping = false;

	if (%this.remapDInput) {
		//Bullshit!
		%trigger = %this.remapDInputTrigger;

		%this.remapDInput = false;
		%this.remapDInputTrigger = "";

		//Check to see if we're overriding the other
		if ($pref::Input::TriggerAction[(%trigger $= "Left" ? "Right" : "Left")] $= %this.remapCommand) {
			//Clear it
			$pref::Input::TriggerAction[(%trigger $= "Left" ? "Right" : "Left")] = "";
		}

		//Fake it so we make it
		$pref::Input::TriggerAction[%trigger] = %this.remapCommand;
		JoystickMap.bind("joystick0", "zaxis", "joyDITrigger");

		//Find out which one we overwrote
		%old = JoystickMap.getBinding(%this.remapCommand);
		//And clear it
		JoystickMap.unbind(getField(%old, 0), getField(%old, 1));
		%this.onNewBinding();
		return;
	}

	if ($pref::Input::TriggerAction["Left"] $= %this.remapCommand)
		$pref::Input::TriggerAction["Left"] = "";
	if ($pref::Input::TriggerAction["Right"] $= %this.remapCommand)
		$pref::Input::TriggerAction["Right"] = "";

	if ($pref::Input::TriggerAction["Left"] $= "" && $pref::Input::TriggerAction["Right"] $= "") {
		//Make sure to unbind the zaxis
		%old = JoystickMap.getCommand("joystick0", "zaxis");
		if (%old $= "joyDITrigger") {
			JoystickMap.unbind("joystick0", "zaxis");
		}
	}

	echo("new binding: " @ %action @ " to " @ %this.remapCommand);

	//And bind the new one
	%device = "joystick0";
	JoystickMap.bind(%device, %action, %this.remapCommand);
	%this.onNewBinding();
}
