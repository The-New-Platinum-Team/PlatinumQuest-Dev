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

// Variables used by client scripts & code.  The ones marked with (c)
// are accessed from code.  Variables preceeded by Pref:: are client
// preferences and stored automatically in the ~/client/	file
// in between sessions.
//
//    (c) Client::MissionFile             Mission file name
//    ( ) Client::Password                Password for server join

//    (?) Pref::Player::CurrentFOV
//    (?) Pref::Player::DefaultFov
//    ( ) Pref::Input::KeyboardTurnSpeed

//    (c) pref::Master[n]                 List of master servers
//    (c) pref::Net::RegionMask
//    (c) pref::Client::ServerFavoriteCount
//    (c) pref::Client::ServerFavorite[FavoriteCount]
//    .. Many more prefs... need to finish this off

// Moves, not finished with this either...
//    (c) firstPerson
//    $mv*Action...

//-----------------------------------------------------------------------------
// These are variables used to control the shell scripts and
// can be overriden by mods:

//-----------------------------------------------------------------------------
function initClient() {
	echo("\n--------- Initializing FPS: Client ---------");

	// Make sure this variable reflects the correct state.
	$Server::Dedicated = false;

	// DATA VARIABLES
	$Files::MissionsFolder["Platinum"]      = "missions_mbp";
	$Files::MissionsFolder["Gold"]          = "missions_mbg";
	$Files::MissionsFolder["Ultra"]         = "missions_mbu";
	$Files::MissionsFolder["PlatinumQuest"] = "missions_pq";
	$Files::MissionsFolder["Custom"]        = "missions";

	// Game information used to query the master server
	$Client::GameTypeQuery = "Any";
	$Client::MissionTypeQuery = "Any";

	// The common module provides basic client functionality
	initBaseClient();

	if ($Plugin::LoadedShotter || $Plugin::LoadedGraphicsExtension)
		$pref::Video::displayDevice = "OpenGL";

	//Create these directories if they don't exist yet
	mkdir("platinum/data/recordings", 493); //0755
	mkdir("platinum/data/screenshots", 493); //0755
	mkdir("platinum/data/state", 493); //0755
	chmod("platinum/data/recordings", 493); //0755
	chmod("platinum/data/screenshots", 493); //0755
	chmod("platinum/data/state", 493); //0755

	/// Load client-side Audio Profiles/Descriptions
	exec("./scripts/audioProfiles.cs");

	// InitCanvas starts up the graphics system.
	// The canvas needs to be constructed before the gui scripts are
	// run because many of the controls assume the canvas exists at
	// load time.
	initCanvas("PlatinumQuest" SPC $THIS_VERSION_NAME);

	Canvas.setContent(new GuiControl(RootGui) {
		profile = "GuiContentProfile";
		extent = Canvas.extent;
	});

	//Load tooltips early
	exec("./scripts/tooltip.cs");
	exec("./scripts/redundancycheck.cs");

	// Load up the Game GUIs
	exec("./ui/defaultGameProfiles.cs");
	exec("./ui/PlayGui.gui");
	exec("./scripts/menu.cs");
	exec("./ui/RootGui.gui");

	if ($Video::OpenGLVersion < 2) {
		MessageBoxOk("OpenGL", "OpenGL " @ $Video::OpenGLVersion @ " detected! This means either your graphics card is not detected or it's so old it doesn't support OpenGL 2." NL
			"In either case, there is no way PQ will be able to run. Make sure your drivers are up to date and your card was made after 2006.", "quit();");
		//No, seriously. You're not going to be able to play this game.
		return;
	}

	setNetPort(0);

	// Load up the shell GUIs
	exec("./ui/playMissionGui.gui");
	exec("./ui/mainMenuGui.gui");
	exec("./ui/EndGameDlg.gui");
	exec("./ui/LoadingGui.gui");
	exec("./ui/OptionsGui.gui");
	exec("./ui/OptionsTexturePackDlg.gui");
	exec("./ui/remapDlg.gui");
	exec("./ui/ExitGameDlg.gui");
	exec("./ui/MiniShotGui.gui");
	exec("./ui/ManualGui.gui"); //Unused but exists still

	// GUIs
	exec("./ui/MarbleSelectDlg.gui");
	exec("./ui/StatisticsDlg.gui");
	exec("./ui/PlayDemoGui.gui");
	exec("./ui/EditDemoDlg.gui");
	exec("./ui/ReminderDlg.gui");
	exec("./ui/ErrorHandlerDlg.gui");
	exec("./ui/CompleteDemoDlg.gui");
	exec("./ui/AchievementsDlg.gui");
	exec("./ui/SearchDlg.gui");
	exec("./ui/VersionDlg.gui");
	exec("./ui/JukeboxDlg.gui");
	exec("./ui/RenameFileDlg.gui");
	exec("./ui/ExtendedHelpDlg.gui");
	exec("./ui/HintsDlg.gui");
	exec("./ui/EditorOrNewDlg.gui");
	exec("./ui/ControllerGui.gui");
	exec("./ui/QueueResultsDlg.gui");

	// Gui Scripts
	exec("./scripts/EndGameDlg.cs");
	exec("./scripts/OptionsGui.cs");
	exec("./scripts/playGui.cs");
	exec("./scripts/loadingGui.cs");
	exec("./scripts/chatHud.cs");
	exec("./scripts/messagehud.cs");

	// Client scripts
	exec("./scripts/client.cs");
	exec("./scripts/missiondownload.cs");
	exec("./scripts/serverConnection.cs");
	exec("./scripts/centerPrint.cs");
	exec("./scripts/game.cs");
	exec("./scripts/radar.cs");
	exec("./scripts/taunt.cs");
	exec("./scripts/cannon.cs");
	exec("./scripts/moving.cs");
	exec("./scripts/speedometer.cs");
	exec("./scripts/triggers.cs");
	exec("./scripts/water.cs");
	exec("./scripts/physics.cs");
	exec("./scripts/blast.cs");
	exec("./scripts/gravity.cs");
	exec("./scripts/hats.cs");
	exec("./scripts/camera.cs");
	exec("./scripts/fireball.cs");
	exec("./scripts/unlock.cs");
	exec("./scripts/replay.cs");
	exec("./scripts/controllerUI.cs");
	exec("./scripts/texturePack.cs");

	// Default player key bindings
	exec("./scripts/default.bind.cs");

	// taunt.cs also contains keybindings for the taunts
	bindDefaultTauntKeys();

	if (isScriptFile(expandFilename("./config.cs"))) {
		exec("./config.cs");
		checkDefaultBinds();
	}

	// load leaderboard main script!
	exec("./ui/lb/main.cs");
	initBadWords();

	//Game Modes
	exec("./scripts/modes.cs");
	loadClientGameModes();

	//MP Support
	exec("./scripts/mp/main.cs");
	initMultiplayer();

	//Stop the game from allowing connections by default
	allowConnections(false);
	stopHeartbeat();

	//With the gfx extender we don't want shadows
	if ($Plugin::LoadedGraphicsExtension) {
		$pref::shadows = 0;
		$pref::useStencilShadows = 0;
	}

	// Prior to 2.0.10 we allowed x16. We have to force
	// disable it when they update.
	if ($pref::Video::AntiAliasing > 8) {
		$pref::Video::AntiAliasing = 8;
	}

	// Copy saved script prefs into C++ code.
	setShadowDetailLevel($pref::shadows);
	setDefaultFov($pref::Player::defaultFov);
	setZoomSpeed($pref::Player::zoomSpeed);
	applyGraphicsQuality();
	updateFrameController();

	loadAudioPack($pref::Audio::AudioPack);

	if ($pref::HighReadability !$= "" && $pref::HighReadability == 0 && $pref::Video::TexturePack[1] $= "") {
		$pref::Video::TexturePack[1] = "classic";
	}
	$pref::HighReadability = "";
	for (%i = 0; $pref::Video::TexturePack[%i] !$= ""; %i ++) {
		activateTexturePack($pref::Video::TexturePack[%i]);
	}
	reloadTexturePacks();

	// Initialize Discord integration
	initDiscord("378414884959944705");
	setLargeDiscordImage("logo_new");

	//Covers stuff defined as marble/data/interiors/stuff.dif
	addDirectoryOverride("marble/data/interiors/", "platinum/data/interiors_mbg/");
	addDirectoryOverride("marble/data/interiors/", "platinum/data/interiors/");
	//Covers things like ~/marble/data/interiors/stuff.dif
	addDirectoryOverride("platinum/data/interiors/", "platinum/data/interiors_mbg/");
	addDirectoryOverride("platinum/data/interiors/", "platinum/data/interiors_mbp/");
	//Anything else we probably can't save, but why not try?
	addDirectoryOverride("marble/data/", "platinum/data/");
	addDirectoryOverride("challenge/data/", "platinum/data/");

	// Start up the main menu... this is separated out into a
	// method for easier mod override.
	loadMainMenu();

	if ($missionArg !$= "") {
		%file = findNamedFile($missionArg, ".m?s");
		if (%file $= "") {
			ASSERT("Mission not found.", "The mission " @ $missionArg @ " couldn't be found.");
			error("Error: Mission file at -mission argument not found.");
		} else {
			RootGui.setContent(LoadingGui);
			schedule(1000, 0, doCreateGame, %file);
		}
	} else if ($interiorArg !$= "") {
		doInteriorTest($interiorArg);
	}

	// okay
	return true;
}

function doInteriorTest(%interiorName) {
	if (%interiorName $= "") {
		ASSERT("Interior test failed.", "The interior filename was missing.");
		error("doInteriorTest: Interior filename missing.");
		return;
	}

	%file = findNamedFile(%interiorName, ".dif");
	if (%file $= "") {
		ASSERT("Interior test failed.", "The interior " @ %interiorName @ " couldn't be found.");
		error("doInteriorTest: Interior with filename " @ %interiorName @ " not found.");
		return;
	}

	onServerCreated(); // gotta hack here to get the datablocks loaded...

	%missionGroup = createEmptyMission("Interior Test: " @ %interiorName);
	%interior = new InteriorInstance() {
		position = "0 0 0";
		rotation = "1 0 0 0";
		scale = "1 1 1";
		interiorFile = %file;
	};
	%missionGroup.add(%interior);
	%interior.magicButton();

	if (!isObject(StartPoint)) {
		%pt = new StaticShape(StartPoint) {
			position = "0 -5 0";
			rotation = "1 0 0 0";
			scale = "1 1 1";
			dataBlock = "StartPad_PQ";
		};
		MissionGroup.add(%pt);
	}

	if (!isObject(EndPoint)) {
		%pt = new StaticShape(EndPoint) {
			position = "0 5 0";
			rotation = "1 0 0 0";
			scale = "1 1 1";
			dataBlock = "EndPad_PQ";
		};
		MissionGroup.add(%pt);
	}

	$InstantGroup = MissionCleanup;
	%box = MissionGroup.getWorldBox();
	%box = VectorSub(BoxMin(%box), "15 15 5") SPC VectorAdd(BoxMax(%box), "15 15 50");
	$InstantGroup = MissionGroup;

	new Trigger(Bounds) {
		position = "0 0 0";
		scale = "1 1 1";
		rotation = "1 0 0 0";
		dataBlock = "InBoundsTrigger";
		polyhedron = "0.0000000 0.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 -1.0000000 0.0000000 0.0000000 0.0000000 1.0000000";
	};
	Bounds.setBounds(%box);
	MissionGroup.add(Bounds);

	%missionGroup.save($usermods @ "/data/missions/testMission.mis");
	%missionGroup.delete();
	doCreateGame($usermods @ "/data/missions/testMission.mis");
}


function isScriptFile(%file) {
	%file = strReplace(%file, "challenge/data", "platinum/data");
	if (isFile(%file) || isFile(%file @ ".dso"))
		return true;
	return false;
}

function doCreateGame(%file) {
	MarbleSelectDlg.update();

	$playingDemo = false; // For some reason, this isn't reset.
	%id = PM_missionList.getSelectedId();
	//echo("ID IS" SPC %id);
	%mission = getMissionInfo(%file);
	//echo("MISSION IS" SPC %mission.file);
	$LastMissionType = %mission.type;

	// last mission played, save it
	%name = (%mission.name !$= "") ? %mission.name : fileBase(%mission.file);
	$Pref::LastMissionPlayed[$CurrentGame, $MissionType] = %name;
	savePrefs(); // moved save prefs to here

	// CRC checker. Nobody likes it, remember?
	//if(%mission.getGroup().getName() !$= "MTYPE_Custom")
	//{
	//if(!checkMissionCRC(%mission.file))
	//{
	//    ASSERT("Invalid Mission File","Probably your mission file has been modified.\nPlease reinstall the latest MBP patch or contact the MBP Team.");
	//    return;
	//	}
	//}

	while (!$Server::Hosting && isObject(ServerConnection))
		ServerConnection.delete();

	%multiplayer = strStr(%file, "multiplayer") != -1;
	if ($pref::HostMultiPlayer || %multiplayer)
		%serverType = "MultiPlayer";
	else
		%serverType = "SinglePlayer";

	// We need to start a server if one isn't already running
	if ($Server::ServerType $= "") {
		createServer(%serverType, %mission.file);
		loadMission(%mission.file, true);
		%conn = new GameConnection(ServerConnection);
		RootGroup.add(ServerConnection);
		%conn.setConnectArgs($LB::Username, "", MarbleSelectDlg.getSelection(), "bologna");
		%conn.setJoinPassword($MPPref::Server::Password);
		%conn.connectLocal();
		setNetPort(0);
	} else
		loadMission(%mission.file);
}

function setPlayMissionGui() {
	resumeGame();
	disconnect();
	PlayMissionGui.open();
}

//-----------------------------------------------------------------------------
function startTotalTimer() {
	// This function is for.... THE TOTAL TIMER DUDE!!!
	// This function is damn loop.
	if (!$TotalTimer::Stopped)
		schedule(1000, 0, "startTotalTimer");
	else {
		$TotalTimer::Stopped = false;
		return;
	}

	if ($pref::TotalTimer >= 86400) {
		$pref::TotalTimerDaysAdd++;
		$pref::TotalTimer = 0;
	} else
		$pref::TotalTimer++;
}

function loadMainMenu() {
	Canvas.setCursor("DefaultCursor");

	//Setup loading screen
	Canvas.setContent(RootGui);
	if ($pref::AnimatePreviews || !$pref::Introduced) {
		$Menu::Startup = true;
	}
	RootGui.setContent(LoadingGui);

	activateMenuHandler(RootMenu);

	//Show the loaded level before doing anything slow
	PlayMissionGui.init();
	if ($pref::AnimatePreviews && $pref::Introduced) {
		PlayMissionGui.loadMission();
	}
	Canvas.repaint();

	//Here's the slow part
	Unlock::updateCaches(true);

	//Go straight to the main menu if we're not loading a mission
	if ((!$pref::AnimatePreviews && $pref::Introduced)) {
		RootGui.setContent(MainMenuGui);
	}

	JukeboxDlg.getSongList();
	playShellMusic();

	// Check if we got a presentable error from bad command-line arguments. (ASSERT isn't defined during platinum/main.cs' execution)
	if ($argError > 0)
		presentCommandLineError($argError);

	startTotalTimer();

	MainMenuGui.fixSizing();
}

function presentCommandLineError() {
	switch ($argError) {
	case 1:
		ASSERT("Mission launch failed.", "The mission filename was missing.");
	case 2:
		ASSERT("Interior test failed.", "The interior filename was missing.");
	}
}

//-----------------------------------------------------------------------------

// here man
function enableSavePrefs() {
	$cantSavePrefs = false;
}

function savePrefs(%showAssert) {
	echo("Exporting client prefs");
	export("$pref::*", "~/client/mbpPrefs.cs", False);
	export("$LBPref::*", "~/client/lbprefs.cs", False);
	MPsavePrefs();

	if (%showAssert && !$cantSavePrefs) {
		pauseGame();
		ASSERT("Saved successfully","Data was saved correctly.","resumeGame();");
		$cantSavePrefs = true;
		schedule(5000,0,"enableSavePrefs");
	}
}
/////////////////
