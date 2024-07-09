//-----------------------------------------------------------------------------
// Backend Server for the menu
//
// Warning: Major hackitude in here
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

function menuCreateServer() {
	echo("*** Menu create server");

	//Load a mission so we don't show nothing
	$Game::Menu = true;

	createServer("SinglePlayer");
	menuSendCb("CreateServer");
}

function menuDestroyServer() {
	echo("*** Menu destroy server");

	//Reset sound back to normal
	alxSetChannelVolume(1, $pref::Audio::channelVolume1);

	//Clean up anything we've left over
	if ($Menu::Loaded) {
		menuMissionEnd();
	}

	//Kill it
	$Game::UseMenu = false;
	disconnect();

	menuSendCb("DestroyServer");
}

function menuRestartClient() {
	echo("Restarting menu client");

	if (isObject(ServerConnection))
		ServerConnection.delete();
	if (isObject(LocalClientConnection))
		LocalClientConnection.delete();

	%conn = new GameConnection(ServerConnection);
	RootGroup.add(ServerConnection);
	%conn.setConnectArgs($LB::Username, "", MarbleSelectDlg.getSelection(), "bologna");
	%conn.setJoinPassword($MPPref::Server::Password);
	%conn.connectLocal();
}

//-----------------------------------------------------------------------------

function menuSetMission(%file) {
	echo("*** Menu set mission " @ %file);

	//Clean up anything we've left over
	if ($Menu::Loaded) {
		menuMissionEnd();
	}

	$Menu::Loaded = false;
	$Menu::Loading = false;
	$Menu::MissionFile = %file;

	menuSendCb("NewMission", %file);
}

function menuLoadMission(%file) {
	echo("*** Menu load mission " @ %file);

	$Server::GhostObjects = 0;
	$Client::GhostObjects = 0;

	menuSetMission(%file);
	menuStartLoading();

	$Menu::CurrentlyLoadedMission = %file;
	$Menu::FirstLoad = false;
	//If we need to start a server first, do so here
	if (!$Game::Menu) {
		$Menu::FirstLoad = true;
		menuCreateServer();
	}

	menuRestartClient();
	menuMissionEnd();

	$Menu::MissionLoadParts = 0;
	loadMission(%file, true);

	menuSendCb("LoadMission");
}

function menuLoadGhostsComplete() {
	echo("*** Menu load ghosts complete");
	menuOnMissionLoaded();
}

function menuOnLoadProgress(%progress) {
	$Menu::Progress = %progress;
	menuSendCb("LoadProgress", %progress);
}

function menuStartLoading() {
	echo("*** Menu start loading");
	$Menu::Loaded = false;
	$Menu::Loading = true;
	$Menu::Progress = 0;
	menuSendCb("StartLoading");
}

function menuOnMissionLoaded() {
	echo("*** Menu mission loaded");

	if (!$Menu::Loaded) {
		$Menu::Loaded = true;
		$Menu::Loading = false;

		if ($Menu::Startup) {
			onMissionLoaded();
		}

		//No fan noises
		alxSetChannelVolume(1, 0);
		onMissionReset();

		menuSendCb("MissionLoaded");
	}

	if (isObject($Menu::Queue)) {
		$Menu::Queue.onPlayMission($Menu::QueueIndex);
	}
}

function menuOnMissionLoadFailed() {
	echo("*** Menu mission load failed");

	$Menu::Loaded = false;
	$Menu::Loading = false;

	menuSendCb("MissionLoadFailed");
}

//-----------------------------------------------------------------------------

function menuPlayQueue(%queue) {
	echo("*** Menu play queue: " @ %queue.class SPC %queue.getName() SPC %queue.getId());
	$Menu::Queue = %queue;

	if (%queue.getMissionCount() == 0) {
		menuFinishQueue(false);
		return;
	}

	%queue.export("platinum/json/queue.json");

	$Menu::QueueIndex = 0;
	$Menu::Queue.onPlay();

	%mission = $Menu::Queue.getMissionInfo(0);
	$Client::NextMission = %mission;
	menuLoadStartMission(%mission.file);

	menuSendCb("PlayQueue", $Menu::Queue);
}

function menuEndQueueMission() {
	echo("*** Menu end mission in queue: " @ $Menu::QueueIndex);
	$Menu::Queue.onEndMission($Menu::QueueIndex, true);
	$Menu::Queue.export("platinum/json/queue.json");
	schedule(3000, 0, menuPlayNextQueue);
}

function menuSkipNextQueue() {
	resumeGame();
	echo("*** Menu skipping next in queue: " @ $Menu::QueueIndex);
	$Menu::Queue.onEndMission($Menu::QueueIndex, false);
	$Menu::Queue.export("platinum/json/queue.json");
	menuPlayNextQueue();
}

function menuPlayNextQueue() {
	echo("*** Menu play next in queue: " @ $Menu::QueueIndex);
	$Menu::QueueIndex ++;
	if ($Menu::QueueIndex == $Menu::Queue.getMissionCount()) {
		menuMissionExit();
		return;
	}

	%mission = $Menu::Queue.getMissionInfo($Menu::QueueIndex);
	$Client::NextMission = %mission;
	menuLoadStartMission(%mission.file);

	menuSendCb("PlayNextQueue", $Menu::Queue);
}

function menuFinishQueue(%completed) {
	echo("*** Menu finish queue with completed: " @ %completed);
	$Menu::Queue.onEnd(%completed);

	menuSendCb("FinishQueue", $Menu::Queue);

	$Menu::Queue = 0;
}

//-----------------------------------------------------------------------------

function menuStartCameraOverview() {
	//Major hack here to get this up and running
	activateMovingObjects(true);
	clientCmdActivateMovingObjects(true);

	ServerConnection.getControlObject().setTransform(CameraPath1.getTransform());
	LocalClientConnection.camera.schedule(1000, moveOnPath, CameraPath1);
}

function menuStopCameraOverview() {
	//Clean up the mess we just made
	activateMovingObjects(false);
	clientCmdActivateMovingObjects(false);

	//Cancel before we call onClientEnterGame because that creates a new camera for us
	LocalClientConnection.camera.cancelMoving();
	cancelMoving(ServerConnection.getControlObject());
}

function menuPlay() {
	echo("*** Menu play");

	//Reset sound back to normal
	alxStopAll();
	alxSetChannelVolume(1, $pref::Audio::channelVolume1);

	//Start the mission
	endGame();
	$Game::Menu = false;

	menuStopCameraOverview();
	commandToServer('UpdateMarble', MarbleSelectDlg.getSelection());

	//Send this so it generates gemcounts and stuff
	onMissionLoaded();
	applyGraphicsQuality();

	//Hack: Some hunt levels have too many gems and we aren't able to spawn our player
	if (countGems(MissionGroup) > 100) {
		// onMissionReset should take care of this anyway
		hideGems();
	}

	//Stick us ingame
	LocalClientConnection.onClientEnterGame();
	ServerConnection.initialControlSet();

	PlayGui.setMessage("");

	menuSendCb("Play");
}

//-----------------------------------------------------------------------------

function menuMissionExit() {
	echo("*** Menu mission exit");

	resumeGame();

	//This keeps being called from disconnect()
	if ($Server::ServerType $= "")
		return;

	//Check if we need to load the credits
	if (menuCheckCredits()) {
		return;
	}

	$Game::Menu = true;

	if ($pref::AnimatePreviews) {
		//No fan noises
		alxSetChannelVolume(1, 0);

		//Clean up stuff from the level
		onMissionReset();

		//Create a new camera for the client
		MissionCleanup.add(%camera = new Camera() {
			dataBlock = Observer;
		});
		%camera.setTransform(CameraPath1.getTransform());
		%camera.scopeToClient(LocalClientConnection);
		LocalClientConnection.setControlObject(%camera);

		//Destroy player, etc
		LocalClientConnection.onClientLeaveGame();
		LocalClientConnection.camera = %camera;

		//Make sure we don't leave the RSG running
		cancelAll(LocalClientConnection);

		//Start camera loop
		LocalClientConnection.camera.schedule(1000, moveOnPath, CameraPath1);
	} else {
		// main_gi:
		// Making it so if it's off, stay in the level, just don't render the camera.
		alxSetChannelVolume(1, 0);
		onMissionReset();
		MissionCleanup.add(%camera = new Camera() {
			dataBlock = Observer;
		});
		%camera.setTransform("-999999 -999999 -999999 1 0 0 0"); // Move it far, far away.
		%camera.scopeToClient(LocalClientConnection);
		LocalClientConnection.setControlObject(%camera);
		LocalClientConnection.onClientLeaveGame();
		cancelAll(LocalClientConnection);
		menuSendCb("NewMission", $Menu::CurrentlyLoadedMission); // Show the static background image.
	}

	menuSendCb("MissionExit");

	if (isObject($Menu::Queue)) {
		menuFinishQueue($Menu::QueueIndex == $Menu::Queue.getMissionCount());
	}
}

function menuMissionEnd() {
	echo("*** Menu mission end");

	$Event::Modes = ""; // Fuck this shit
	//Actually clear everything
	clientCbOnServerLeave();
	clientCbOnMissionEnded();
	serverCbOnMissionEnded();
	clearClientTriggerList();
	clientClearPaths();
	Physics::resetToDefaultMarble();
	CDTReset();

	menuSendCb("MissionEnded");
}

//-----------------------------------------------------------------------------

function menuStartIntroduction() {
	//Hey! You! Go play Training Wheels! Don't come back until you've beaten it!
	$Game::Introduction = true;

	//Hardcoded for victory
	menuLoadMission("platinum/data/missions_pq/tutorial/Tut_TrainingWheels.mcs");

	menuSendCb("StartIntroduction");
}

function menuOnPostIntroduction(%this) {
	//Clean up the old mission when the game still thinks we're running the intro
	menuMissionExit();
	menuOnMissionLoaded();

	//No longer playing the introduction
	$Game::Introduction = false;
	$pref::Introduced = true;

	menuSendCb("PostIntroduction");
}

//-----------------------------------------------------------------------------

function menuCheckCredits() {
	//Did we beat Manic Bounce for the first time?
	if (!$Game::RunCredits) {
		return false;
	}
	//Don't show unless we've won
	if (!$Game::Finished) {
		return false;
	}
	//So we don't run them twice
	$Game::RunCredits = false;
	menuStartCredits();
	return true;
}

function menuStartCredits() {
	//Change your menu music
	$pref::Music::Songs["Menu"] = "Electroforte.ogg";

	// Is this the first time we are congratulating?
	if (!$pref::Congratulated) {
		$Game::Credits::FirstTime = true;
	}

	//Hey, congratulations!
	$pref::Congratulated = true;

	//SAVE it
	savePrefs();

	//Let us know to play the credits
	$Game::Credits = true;

	deactivateMenuHandler(PMMenu);
	RootGui.setContent(LoadingGui);

	%file = (lb() ? "platinum/data/lbmissions_pq/bonus/UpbeatFreedom.mcs" : "platinum/data/missions_pq/bonus/UpbeatFreedom.mcs");
	menuLoadStartMission(%file);

	menuSendCb("StartCredits");
}
//-----------------------------------------------------------------------------

function menuLoadStartMission(%file) {
	menuSetMission(%file);
	RootGui.setContent(LoadingGui);
	Canvas.repaint();

	//How convenient
	deactivateMenuHandler("PMMenu");
	activateMenuHandler("MLSM");
	if ($Menu::Loaded && $Menu::MissionFile $= %file) {
		MLSM_MissionLoaded();
	} else {
		menuLoadMission(%file);
	}
}

function MLSM_MissionLoaded() {
	menuPlay();
}

function MLSM_Play() {
	deactivateMenuHandler("MLSM");
	activateMenuHandler("PMMenu");
	RootGui.setContent(PlayGui);
}


//-----------------------------------------------------------------------------
// Menu callbacks
//-----------------------------------------------------------------------------

function activateMenuHandler(%name) {
	if (!isObject(MenuHandlers)) {
		Array(MenuHandlers);
	}
	MenuHandlers.addEntry(%name);
}
function deactivateMenuHandler(%name) {
	MenuHandlers.removeMatching(%name);
}

//Callback list:
// _CreateServer()
// _DestroyServer()
// _NewMission(%file)
// _LoadMission()
// _LoadProgress(%progress)
// _StartLoading()
// _MissionLoaded()
// _MissionLoadFailed()
// _PlayQueue()
// _PlayNextQueue()
// _FinishQueue()
// _Play()
// _MissionExit()
// _MissionEnded()
// _StartIntroduction()
// _PostIntroduction()
// _StartCredits()

function menuSendCb(%name, %arg) {
	%count = MenuHandlers.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%fn = MenuHandlers.getEntry(%i) @ "_" @ %name;
		if (isFunction(%fn)) {
			call(%fn, %arg);
		}
		if (MenuHandlers.getSize() < %count) {
			//Someone deactivated in their callback
			%i --;
			%count = MenuHandlers.getSize();
		}
	}
}
