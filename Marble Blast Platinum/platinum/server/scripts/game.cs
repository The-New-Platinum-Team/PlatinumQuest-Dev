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

//-----------------------------------------------------------------------------
// Penalty and bonus times.
$Game::TimeTravelBonus = 5000;

// Item respawn values, only powerups currently respawn
$Item::RespawnTime = 7 * 1000;

// Can only respawn every this many ms. To prevent race conditions.
$Game::RespawnDelay = 250;

//-----------------------------------------------------------------------------
// Variables extracted from the mission
$Game::GemCount = 0;
$Game::StartPad = 0;
$Game::EndPad = 0;

// Change this if you want !!
$powerupDelay = 600; // This makes sure that you're not going to left-click too long and use the powerup by accident.

//Extra time between mission load and mission play to give the game time to load
$Game::StartDelay = 500;

//Legacy (non-pq only): Allow finish if oob for less than this amount of time
$Game::LegacyOOBGrace = 500;

//-----------------------------------------------------------------------------
//  Functions that implement game-play
//-----------------------------------------------------------------------------

function onServerCreated() {
	onServerInfoQuery();

	// GameStartTime is the sim time the game started. Used to calculated
	// game elapsed time.
	$Game::StartTime = 0;

	// Reset teams
	$MP::TeamMode = 0;
	$MP::Teams = 0;
	if (isObject(TeamGroup))
		TeamGroup.delete();

	Team::createDefaultTeam();

	// Load up all datablocks, objects etc.  This function is called when
	// a server is constructed.
	exec("./audioProfiles.cs");
	exec("./camera.cs");
	exec("./triggers.cs");
	exec("./inventory.cs");
	exec("./shapebase.cs");
	exec("./staticshape.cs");
	exec("./item.cs");
	exec("./huntGems.cs");
	exec("./fx.cs");

	//Particle data
	loadParticles();

	// Basic items
	exec("./marble.cs");
	exec("./gems.cs");
	exec("./powerUps.cs");
	exec("./buttons.cs");
	exec("./hazards.cs");
	exec("./pads.cs");
	exec("./bumpers.cs");
	exec("./signs.cs");
	exec("./fireworks.cs");
	exec("./particles.cs");
	exec("./interior.cs");
	exec("./glass.cs");
	exec("./skies.cs");
	exec("./gravity.cs");
	exec("./fadingPlatforms.cs");
	exec("./moving.cs");
	exec("./cannon.cs");
	exec("./help.cs");
	exec("./water.cs");
	exec("./physMod.cs");
	exec("./fireball.cs");
	exec("./replay.cs");
	helpBubbleInit();

	exec("./scenery.cs");

	// stuff
	exec("./checkpoint.cs");
	exec("./teleporter.cs");

	//Game modes
	exec("./modes.cs");
	loadGameModes();

	//MP Support
	exec("./mp/main.cs");
	initMultiplayerServer();

	// Platforms and interior doors
	exec("./pathedInteriors.cs");

	// Keep track of when the game started
	$Game::StartTime = $Sim::Time;

	// multiplayer scripts for multiplayer mode
	// screw it, keep it for single player too, can't hurt....
	MPinitLoops();

	// this drives me nuts, I want a server variable NOW
	$Game::ServerRunning = true;
	$Game::Restarted = false;

	loadAudioPack($pref::Audio::AudioPack);
}

function loadParticles() {
	//Particle data
	// Load every CS in the particles folder
	%pattern = $usermods @ "/server/scripts/particles/*.cs";
	for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
		exec(%file);
	}
	%pattern = $usermods @ "/server/scripts/particles/*.cs.dso";
	for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
		%cs = getSubStr(%file, 0, strlen(%file) - 4); // strlen(".dso")
		if (!isFile(%cs)) {
			exec(%cs);
		}
	}
}

function MPinitLoops() {
	MPOutofBounds();
	updateScores();
	MPUpdateGhostCollision();
	serverBlastUpdate();
	MPSyncClocks();
	// We want this to be called!
	schedule(1000, 0, MPUpdateGhostCollision);
}

function onServerDestroyed() {
	// Perform any game cleanup without actually ending the game
	destroyGame();

	// stop any server loops going on
	cancel($MP::Schedule::Collision);
	cancel($MP::Schedule::OOB);
	cancel($MP::Schedule::BlastUpdate);
	cancel($MP::Schedule::Scores);
	cancel($MP::Schedule::ClockSync);

	cancel($bubbleLoop);

	// Make sure fireworks are cleaned up and tell emitters to kys (#626)
	endFireWorks();
	cleanupEmitters();

	if (isObject($Game::SpawnTriggers))
		$Game::SpawnTriggers.delete();

	// this drives me nuts, I want a server variable NOW
	$Game::ServerRunning = false;
	$Game::State = "";
	$Event::Modes = ""; // Fuck this shit
}

//-----------------------------------------------------------------------------

function onBeforeMissionLoad() {
	//Override any mission startup scripts
	eval("function MissionStartup() {}");
	exec("./mp/callbacks.cs");

	//Local host client only: clear scripts
	if ($Server::Hosting && !$Server::_Dedicated && !$Server::Dedicated) {
		exec("~/client/scripts/mp/callbacks.cs");
	}

	//Tell all the clients to update scripts
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.getAddress() !$= "local") {
			%client.sendMissionScript();
		}
	}

	initSprng();
	initCannons();
	activateMovingObjects(false);

	Mode::callback("onBeforeMissionLoad");
}

//-----------------------------------------------------------------------------

function onMissionLoaded() {
	// Called by loadMission() once the mission is finished loading.
	// Nothing special for now, just start up the game play.

	// Due to the sky not properly changing back when MBXP is activated, I will use this hack instead. ~Connie
	// (there's probably some better way to do this, but for now this will do I guess) ~Also Connie
	if ($TexturePack::MBXP && Sky.materialList $= "platinum/data/skies/sky_day.dml") { // If the player has the MBXP pack on and the sky is MBG, set it to the MBXP one.
	   %sky = Sky.getID();
	   new Sky(Sky) {
		   position = "0 0 0";
		   rotation = "1 0 0 0";
		   scale = "1 1 1";
		   cloudHeightPer[0] = %sky.cloudheightper0;
		   cloudHeightPer[1] = %sky.cloudheightper1;
		   cloudHeightPer[2] = %sky.cloudheightper2;
		   cloudSpeed1 = %sky.cloudspeed1;
		   cloudSpeed2 = %sky.cloudspeed2;
		   cloudSpeed3 = %sky.cloudspeed3;
		   visibleDistance = %sky.visibledistance;
		   useSkyTextures = %sky.useskytextures;
		   renderBottomTexture = %sky.renderbottomtexture;
		   SkySolidColor = %sky.skysolidcolor;
		   fogDistance = %sky.fogdistance;
		   fogColor = %sky.fogcolor;
		   fogVolume1 = %sky.fogvolume1;
	   	   fogVolume2 = %sky.fogvolume2;
		   fogVolume3 = %sky.fogvolume3;
		   materialList = "platinum/data/skies/sky_mbxp/sky_day.dml";
		   windVelocity = %sky.windvelocity;
		   windEffectPrecipitation = %sky.windEffectPrecipitation;
		   noRenderBans = %sky.norenderbans;
		   fogVolumeColor1 = %sky.fogvolumecolor1;
		   fogVolumeColor2 = %sky.fogvolumecolor2;
		   fogVolumeColor3 = %sky.fogvolumecolor3;
	   };
	   %sky.delete();
	   MissionData.add(Sky);
	}

	$Game::GemCount = countGems(MissionGroup);

	// Start the game here if multiplayer...
	if ($Server::ServerType $= "MultiPlayer") {
		// amount of spectators
		$Server::SpectateCount = 0;
		setGameState("Waiting");
		startGame();
		startHeartbeat();

		Time::reset();
	}

	MPinitLoops();
	serverCbOnMissionLoaded();
	buildPhysmodEmitters(MissionGroup);
	serverSendCallback("OnMissionLoaded");
	Mode::callback("onMissionLoaded", "");
}

function onMissionEnded() {
	// Called by endMission(), right before the mission is destroyed
	// This part of a normal mission cycling or end.
	endGame();
	serverCbOnMissionEnded();
	serverSendCallback("OnMissionEnded");
	Mode::callback("onMissionEnded", "");

	if ($Server::Hosting && !$Server::Dedicated) {
		clientCmdCbOnMissionEnded(); //Because commands won't get through
	}
}

function onWaitingEnd() {
	onMissionReset();
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++)
		ClientGroup.getObject(%i).respawnPlayer();
}

function onMissionReset() {
	// Reset the finished variable, this var is set true in State::end() of this file
	$Game::Finished = false;
	$Game::CalculatedWinners = false;
	$Game::EasterEgg = false;
	$Game::TimeStoppedClients = 0;
	cancel($Game::StateSchedule);

	$NoMovingPlatformFrictions = (MissionInfo.NoMPFriction $= "1") ? 1 : 0;

	endFireWorks();
	resetCannons();

	if (mp() && $MPPref::Server::DoubleSpawnGroups) {
		$MP::ScoreSendingDisabled = true;
	}

	// Reset the players and inform them we're starting
	%count = ClientGroup.getCount();
	for (%clientIndex = 0; %clientIndex < %count; %clientIndex++) {
		%cl = ClientGroup.getObject(%clientIndex);
		commandToClient(%cl, 'GameStart');
		%cl.resetStats();
	}

	$Game::Running = true;

	ServerGroup.onMissionReset();

	$Game::ResetTime = $Sim::Time;
	$Game::GemCount = countGems(MissionGroup);
	Time::reset();

	serverCbOnMissionReset();
	serverSendCallback("OnMissionReset");
	Mode::callback("onMissionReset", "");

	//For pathed stuff in PQ
	if (lb() || $CurrentGame !$= "Custom") {
		// LB levels and offline official levels do not have parenting mid-level, so this function doesn't need to reset parenting
		resetMovingObjectsFast();
	} else {
		resetMovingObjects();
	}
	MissionStartup();

	//Stop replays
	commandToAll('StopReplays');
	if (isObject(PlaybackGhostGroup)) {
		while (PlaybackGhostGroup.getCount()) {
			PlaybackGhostGroup.getObject(0).delete();
		}
	} else {
		MissionCleanup.add(new SimGroup(PlaybackGhostGroup));
	}
	//Start replays
	for (%i = 0; %i < MissionInfo.replays; %i ++) {
		cancel($Playback::GhostSchedule[%i]);
		%delay = MissionInfo.replayTime[%i];
		$Playback::GhostSchedule[%i] = schedule(%delay, 0, playbackGhost, MissionInfo.replay[%i], %delay);
	}
}

function SimGroup::onMissionReset(%this) {
	if (%this.resetting) //It's apparently inside itself.. Shit
		return;
	%this.resetting = true;
	%count = %this.getCount();
	for (%i = 0; %i < %count; %i++)
		%this.getObject(%i).onMissionReset();
	%this.resetting = "";
}

function SimObject::onMissionReset(%this) {
}

function GameBase::onMissionReset(%this) {
	%this.getDataBlock().initFX(%this);
	%this.getDataBlock().onMissionReset(%this);
}

//-----------------------------------------------------------------------------

function startGame() {
	if ($Game::Running) {
		error("startGame: End the game first!");
		return;
	}
	$Game::Running = true;

	Mode::callback("onStartGame", "");
	onMissionReset();

	//Tell all the clients to start their games
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setMessage("");
		%client.startGame();
	}
	onNextFrame(setGameState, "start");
	onNextFrame(activateMovingObjects, true);

	if ($RtaSpeedrun::IsEnabled) {
		if (!$RtaSpeedrun::IsTiming) {
			echo("Speedrun mode began timing!");
			$RtaSpeedrun::IsTiming = true;
		}
		$RtaSpeedrun::LastSplitTime = -1;
		RtaSpeedrunUpdateTimers();
	}
}

function endGameSetup() {
	commandToAll('WaitForEndgame');

	//So we don't go back and forth
	$Game::Finished = true;

	setGameState("end");
	Time::stop();
	Time::sync();

	commandToAll('UpdateTimeTravelCountdown'); // main_gi v4.2.3

	$Server::SpawnGroups = false;
	$Game::State = "End";
	// TODO: For the brand sexy new race mode, make this 1000 to have a 1 second pause
	$Game::StateSchedule = schedule(2000, 0, "endGame");

	Mode::callback("onEndGameSetup", "");
	serverCbOnEndGameSetup();
	serverSendCallback("onEndGameSetup");

	if ($RtaSpeedrun::IsEnabled) {
		if ($RtaSpeedrun::EndMission $= $Server::MissionFile) {
			echo("Just finished the end level! Speedrun mode over");
			echo("Final time:" SPC $RtaSpeedrun::Time);
			$RtaSpeedrun::IsEnabled = false;
			$RtaSpeedrun::IsTiming = false;
			$RtaSpeedrun::IsDone = true;
			RtaSpeedrunUpdateTimers();
		} else {
			$RtaSpeedrun::LastSplitTime = $RtaSpeedrun::Time;
			RtaSpeedrunUpdateTimers();
		}
	}

	if ($Server::ServerType $= "MultiPlayer") {
		// update the score list
		MPsendScores();

		if (!$Game::CalculatedWinners) {
			// Check for winner
			updateWinner();
			$Game::CalculatedWinners = true;
		}

		syncClients();
	}
}

function endGame() {
	if (!$Game::Running) {
		//error("endGame: No game running!");
		return;
	}

	destroyGame();

	if (!$loadingMission && !$Game::Menu && !$Game::Credits) {
		// Inform the clients the game is over
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			ClientGroup.getObject(%i).sendEndGameScores();
		}
		commandToAll('GameEnd');
	}

	Mode::callback("onEndGame", "");
}

function pauseGame() {
	// if we are in lbs do not let them pause the game
	if ($Server::ServerType $= "SinglePlayer") {
		if (alxIsPlaying($PlayTimerAlarmHandle))
			alxStop($PlayTimerAlarmHandle);
		$gamePaused = true;
	}
}

function resumeGame() {
	// resume game
	alxSetChannelVolume(1, $pref::Audio::channelVolume1); // main_gi v4.2.3: fix volume
	$gamePaused = false;
}

function destroyGame() {
	// Cancel any client timers
	%count = ClientGroup.getCount();
	for (%index = 0; %index < %count; %index++) {
		%client = ClientGroup.getObject(%index);
		cancel(%client.respawnSchedule);
		cancel(%client.stateSchedule);
	}

	// Perform cleanup to reset the game.
	cancel($Game::CycleSchedule);
	cancel($Game::StateSchedule);
	Time::stop();

	if ($Server::ServerType !$= "MultiPlayer")
		$Game::Running = false;
}


//-----------------------------------------------------------------------------

function setGameState(%state) {
	if (!$Game::Finished && %state $= "End") {
		error("Deprecated: Missions should use endGameSetup() to end the game instead of setGameState()");
		//Hack for compatibility with older missions
		endGameSetup();
		return;
	}

	cancel($Game::StateSchedule);
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setGameState(%state);
	}

	//Server state
	cancel($Game::StateSchedule);
	$Game::State = %state;
	call("serverState" @ %state);
}

function GameConnection::setGameState(%this, %state) {
	if ($Server::Lobby)
		return;

	cancel(%this.stateSchedule);
	commandToClient(%this, 'SetGameState', %state);
	%this.state = %state;
	%state = alphaNum(%state); //Strip other chars

	%this.call("state" @ %state);

	Mode::callback("onGameState", "", new ScriptObject() {
		client = %this;
		state = %state;
		_delete = true;
	});
}

function GameConnection::stateWaiting(%this) {
	%this.setMessage("");
	%this.schedule(500, setMessage, "waiting");
	%this.setGemCount(%this.getGemCount());
	%this.setMaxGems($Game::GemCount);
}

function serverStateWaiting() {
	Time::reset();
}

function serverStateStart() {
	Time::reset();
	Time::set(Mode::callback("getStartTime", 0));
	if (!$TexturePack::MBXP || lb()) {
		$Game::StateSchedule = schedule(3500, 0, setGameState, "go");
	} else { 
		$Game::StateSchedule = schedule(2000, 0, setGameState, "go");
	}
}

function serverStateGo() {
	//Slight hack: Don't start time if someone is in a TimeStopTrigger
	if ($Game::TimeStoppedClients > 0)
		return;

	Time::start();
}

function serverStateEnd() {
	Time::sync();
	Time::stop();
}

function GameConnection::stateStart(%this) {
	%this.setMessage("");
	%this.setGemCount(%this.getGemCount());
	%this.setMaxGems($Game::GemCount);
	%this.stateSchedule = %this.schedule(500, "setGameState", "Ready");
	%this.setSpecialBlast(false);
	%this.setBlastValue(0);
	%this.playing = (MissionInfo.game $= "Ultra");

	//Let everyone know who we are
	%this.sendPlayerId();

	// This should be here!
	%this.player.setMode(Start);

	//Show the StartHelpText
	if (MissionInfo.startHelpText !$= "") {
		%this.addBubbleLine(MissionInfo.startHelpText, false, MissionInfo.persistStartHelpTextTime ? MissionInfo.persistStartHelpTextTime : 5000);
	}
}

function GameConnection::stateReady(%this) {
	//Because it activates when we leave spectator
	%this.spawnTime = $Time::CurrentTime;
	%this.play2d(ReadyVoiceSfx);
	%this.setMessage("ready");
	if (!$TexturePack::MBXP || lb()) {
		%this.stateSchedule = %this.schedule(1500, "setGameState", "set");
	} else { 
		if ($Game::State !$= "Start")
			%this.stateSchedule = %this.schedule(1500, "setGameState", "Go");
	}
	
}

function GameConnection::stateSet(%this) {
	%this.play2d(SetVoiceSfx);
	%this.setMessage("set");

	//If the server is at "start" then it will "go" for us
	if ($Game::State !$= "Start")
		%this.stateSchedule = %this.schedule(1500, "setGameState", "Go");
}

function GameConnection::stateGo(%this) {
	%this.play2d(GetRollingVoiceSfx);
	%this.setMessage("go", 2000);

	%this.spawnTime = $Time::CurrentTime;
	%this.playing = true;

	// Target the players to the end pad and let them lose
	%this.player.setPad($Game::EndPad);
	%this.player.setMode(Normal);
}

function GameConnection::stateEnd(%this) {
	%this.lastScore = %this.gemCount;
	%this.playing = false;

	// Do score calculations, messages to winner, losers, etc.
	%this.player.setMode("Victory"); //No more moving!
	%this.playPitchedSound("firewrks");

	if (%this.player.isFrozen) {
		%this.player.iceShard.getDatablock().unfreeze(%this.player.iceShard, %this.player, true);
	}

	if ($Server::ServerType $= "SinglePlayer" && isObject($Game::EndPad))
		startFireWorks($Game::EndPad);
}

//-----------------------------------------------------------------------------
// GameConnection Methods
// These methods are extensions to the GameConnection class. Extending
// GameConnection make is easier to deal with some of this functionality,
// but these could also be implemented as stand-alone functions.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

function GameConnection::incBonusTime(%this,%dt) {
	Time::addBonusTime(%dt);

	if ($Server::ServerType $= "MultiPlayer") {
		//Sync all clients
		%count = ClientGroup.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.bonusTime += %dt;
		}
		%this.totalBonus += %dt;
	} else {
		%this.bonusTime += %dt;
	}
}


function GameConnection::onClientEnterGame(%this) {
	// Create a new camera object.
	%this.camera = new Camera() {
		dataBlock = Observer;
	};
	MissionCleanup.add(%this.camera);
	%this.camera.scopeToClient(%this);
	%this.setControlObject(%this.camera);

	// Setup game parameters and create the player
	if (!%this.restored)
		%this.resetStats();

	// used for OOB Click in Multiplayer
	%this.isOOB = false;
	commandToClient(%this, 'LockPowerup', false);

	// Anchor the player to the start pad
	if (isObject(%this.player))
		%this.player.setMode(Start);

	// Unset the loading state
	%this.loading = false;

	// Cleanup this
	%this.activateCannon();

	// Send physics values per mission to client
	commandToClient(%this, 'PhysicsValues', $Game::Gravity, $Game::JumpImpulse);

	// Force activation of moving objects. This ensures even if yoiu join midgame,
	// it will have nice moving objects.
	commandToClient(%this, 'ActivateMovingObjects', $Server::MovingObjectsActive);

	//If we're at the menu, don't create a player or start the game
	if ($Game::Menu || $Game::Credits) {
		return;
	}

	// Start the game here for single player
	if ($Server::ServerType $= "SinglePlayer") {
		%this.spawnPlayer();
		startGame();
		%this.radarInit();
	} else {
		commandToClient(%this, 'CloseLobby');
		%this.radarInit();
		updateReadyUserList(); // Update the user list
		%this.setQuickRespawnStatus(true); // enable the 1st quick respawn
		%this.forceSpectate = false;
		if ($Server::Started) {
			%this.setPregame(false);
			%this.resetTimer();
			%this.setTime($Time::CurrentTime);

			//Spectating...
			if (%this.restored && !%this._spectating && !$Game::Finished) {
				%this.spawnPlayer();
				%this.respawnPlayer();
				%this.startGame();
			} else {
				%this.setSpectating(true);
				%this.setGameState("go");

				if ($MPPref::ForceSpectators) {
					%this.forceSpectate = true;
				} else {
					schedule(2000, 0, commandToClient, %this, 'SpectateChoice');
				}
			}

			%this.sendAllPlayerIds();

			if ($Game::Finished) {
				// You're too late!
				%this.sendEndGameScores();
				schedule(1000, 0, commandToClient, %this, 'GameEnd');
				schedule(1000, 0, commandToClient, %this, 'ResetTimer');

				schedule(1000, 0, serverSendScores);
				%this.setGameState("waiting");
				%this.schedule(1000, setMessage, "");
				%this.syncClock();
			} else {
				commandToClient(%this, 'GameStart');
				%this.startTimer();
				%this.setGameState("go");
				%this.syncClock();
			}
		} else {
			%this.setGameState("waiting");
			%this.setPregame(true);
			%this.stopTimer();
			%this.startOverview();
		}
	}

	Mode::callback("onClientEnterGame", "", new ScriptObject() {
		client = %this;
		_delete = true;
	});
}

function GameConnection::onClientLeaveGame(%this) {
	if (%this.player.isFrozen) {
		%this.player.iceShard.getDatablock().unfreeze(%this.player.iceShard, %this.player, true);
	}
	cancel(%this.stateSchedule);

	if (isObject(%this.camera))
		%this.camera.delete();
	%this.camera = "";

	%this.deletePlayer();

	if ($Server::ServerType $= "Multiplayer") {
		// update the score list
		updateScores();
	}

	%this.hideBubble();
	%this.cancelCannon();
	$Event::Modes = ""; // Fuck this shit

	Mode::callback("onClientLeaveGame", "", new ScriptObject() {
		client = %this;
		_delete = true;
	});
}

function GameConnection::deletePlayer(%this) {
	// delete the trail emitter
	for (%i = 0; %i < %this.player.trailEmitters; %i ++) {
		%this.player.trailEmitter[%i].delete();
	}

	%this.clearAllPowerups();

	if (isObject(%this.player.teleporterWire))
		%this.player.teleporterWire.delete();

	if (isObject(%this.hat))
		%this.hat.delete();
	%this.hat = "";

	if (isObject(%this.player))
		%this.player.delete();
	%this.player = "";
}

function GameConnection::sendEndGameScores(%this) {
	%score = Mode::callback("getFinalScore", $ScoreType::Time TAB $Time::CurrentTime, new ScriptObject() {
		client = %this;
		_delete = true;
	});

	commandToClient(%this, 'EndGameSetup', %score, $Time::ElapsedTime, $Time::TotalBonus, $Game::FinishClient.index);
}

function GameConnection::resetStats(%this) {
	// Reset game stats
	%this.bonusTime = 0;
	%this.gemCount = 0;
	%this.totalBonus = 0;

	%this.gemsFound[1] = 0;
	%this.gemsFound[2] = 0;
	%this.gemsFound[5] = 0;
	%this.gemsFound[10] = 0;
	%this.gemsFoundTotal = 0;

	commandToAll('PlayerGemCount', %this.getUsername(), 0, 0, 0, 0);

	%this.resetCheckpoint();
	%this.clearAllPowerups();

	Mode::callback("onResetStats", "", new ScriptObject() {
		client = %this;
		_delete = true;
	});
}


//-----------------------------------------------------------------------------

function GameConnection::onEnterPad(%this) {
	if (Mode::callback("onEnterPad", false, new ScriptObject() {
		client = %this;
		_delete = true;
	}))
		return;

	//Don't let us finish twice
	if ($Game::Finished) {
		return;
	}

	if (%this.player.getPad() == $Game::EndPad) {
		echo("GemCount is" SPC %gemCount SPC "(user)," SPC $Game::GemCount SPC "(game)");

		%message = %this.getFinishMessage();
		if (%this.canFinish()) {
			%this.player.setMode(Victory);
			if (%message !$= "") {
				messageClient(%this, 'MsgRaceOver', %message);
			}
			$Game::FinishClient = %this;
			endGameSetup();
		} else {
			%this.playPitchedSound("missinggems");
			if (%message !$= "") {
				messageClient(%this, 'MsgMissingGems', %message);
			}
		}
	}
}

function GameConnection::canFinish(%this) {
	//Can finish on OOB only if
	// - Not PQ
	// - Been oob for less than 500 ms
	if (%this.isOOB) {
		if (MissionInfo.game $= "PlatinumQuest") {
			return false;
		}
		//Probably won't overflow
		if (getSimTime() > (%this.oobTime + $Game::LegacyOOBGrace)) {
			return false;
		}
	}

	return Mode::callback("canFinish", !($Game::GemCount && %this.getGemCount() < $Game::GemCount), new ScriptObject() {
		client = %this;
		_delete = true;
	});
}

function GameConnection::getFinishMessage(%this) {
	//OOB finish is fucking stupid because of backwards compatibility.
	// There's not really any good message we can put here that won't be wrong
	// 50% of the time. So just don't say anything.
	if (%this.isOOB) {
		if (MissionInfo.game $= "PlatinumQuest") {
			return "";
		}
		if (getSimTime() > (%this.oobTime + $Game::LegacyOOBGrace)) {
			return "";
		}
	}

	%message = Mode::callback("getFinishMessage", "", new ScriptObject() {
		client = %this;
		_delete = true;
	});
	if (%message !$= "")
		return %message;

	if ($Game::GemCount && %this.getGemCount() < $Game::GemCount) {
		return "You may not finish without all the gems!";
	}

	return "Congratulations! You\'ve finished!";
}

function GameConnection::onLeavePad(%this) {
	Mode::callback("onLeavePad", "", new ScriptObject() {
		client = %this;
		_delete = true;
	});
}


//-----------------------------------------------------------------------------

function GameConnection::onOutOfBounds(%this, %hideMessage) {
	if ($Game::State $= "End")
		return;

	// Apparently we go oob when we delete our marble. So let's not
	// try to respawn without a marble.
	if (%this.spectating || %this.overview) {
		return;
	}

	//Only play this if we're not already OOB
	if (!%this.isOOB) {
		//Play the OOB sound
		if ($pref::OOBVoice)
			%this.play2d(OutOfBoundsVoiceSfx);
	}

	// used for OOB Click in Multiplayer
	%this.isOOB = true;
	//Because old levels allow you to finish oob after a short time
	%this.oobTime = getSimTime();

	%this.player.oldPowerupData = %this.player.powerUpData;
	%this.player.oldPowerupObj = %this.player.powerUpObj;

	// keep second paramater false so that gyrocopter image and
	// stuff remains on it until reset is complete
	%this.player.setPowerUp(0, false);

	// Reset the player back to the last checkpoint
	if (!%hideMessage)
		%this.setMessage("outOfBounds", 2000);

	%this.player.setOOB(true);
	commandToClient(%this, 'LockPowerup', true);

	%this.incrementOOBCounter(); // Moved to clientCmds
	%this.sendCallback("OnOutOfBounds");

	if (!isEventPending(%this.respawnSchedule)) {
		%this.respawnSchedule = %this.schedule(2500, respawnFromOOB);
	}

	Mode::callback("onOutOfBounds", "", new ScriptObject() {
		client = %this;
		_delete = true;
	});

	serverCbOnOutOfBounds(%this);
}

function Marble::onOOBClick(%this) {
}

function GameConnection::onDestroyed(%this) {
	//Nothing
}

function GameConnection::onFoundGem(%this,%amount,%gem) {
	%ret = $LB::LoggedIn || $Server::Dedicated;
	if (%ret && $platform $= "windows")
	{
		anticheatDetect(); // This shit aint exist on mac lmaoo
	}
	%this.gemCount += %amount;

	Mode::callback("onFoundGem", "", new ScriptObject() {
		client = %this;
		amount = %amount;
		gem = %gem;
		_delete = true;
	});

	%this.setGemCount(%this.getGemCount());

	// update the score list
	if ($Server::ServerType $= "Multiplayer") {
		updateSingleScore(%this);
		%count = ClientGroup.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%client = ClientGroup.getObject(%i);
			if (%client == %this)
				continue;

			// update whiteout and sound
			if (isObject(%client.player))
				%client.setWhiteOut(0.05);
			%client.playPitchedSound("opponentDiamond");
		}
	}
}

//-----------------------------------------------------------------------------

function GameConnection::spawnPlayer(%this, %spawnPoint) {
	// Combination create player and drop him somewhere
	if (%spawnPoint $= "")
		%spawnPoint = %this.getCheckpointPos(0);
	%this.createPlayer(%spawnPoint);
	%this.updateGhostDatablock();
	%this.setGravityDir("1 0 0 0 -1 0 0 0 -1", true, "1 0 0 3.1415926535");

	%this.unblockSpawning();
	%this.playPitchedSound("spawn");
	Mode::callback("onSpawnPlayer", "", new ScriptObject() {
		client = %this;
		spawnPoint = %spawnPoint;
		_delete = true;
	});
}

function GameConnection::startGame(%this) {
	// Give the client control of the player
	%this.setControlObject(%this.player);
	%this.respawnPlayer();
}

// TODO: remove exitgame paramater

function restartLevel(%exitgame) {
	if ($Server::ServerType $= "MultiPlayer") {
		$MP::Restarting = true;
	}

	$Game::Restarted = true;
	$Server::SpawnGroups = true;
	$Game::Running = true;

	// Reset the player back to the last checkpoint
	onMissionReset();
	setGameState("start");
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.restartLevel();
		%client.setQuickRespawnStatus(true);
	}

	Mode::callback("onRestartLevel", "");
	serverSendCallback("onRestartLevel");
}

function GameConnection::quickRespawnPlayer(%this) {
	// If we're finished, don't respawn.
	if ($Game::State $= "End")
		return;

	%this.player.oldPowerupData = %this.player.powerUpData;
	%this.player.oldPowerupObj = %this.player.powerUpObj;

//   %this.gemCount = max(0, %this.gemCount - 50);

	// keep second paramater false so that gyrocopter image and
	// stuff remains on it until reset is complete
	%this.player.setPowerUp(0, false);

	// So... they want to quick respawn, do they?
	// They're not getting off *that* easy. No spawn abusing!
	%this.quickRespawning = true;
	%this.respawnFromOOB();
	%this.quickRespawning = false;

	Mode::callback("onQuickRespawnPlayer", "", new ScriptObject() {
		client = %this;
		_delete = true;
	});
}

function GameConnection::stopRespawn(%this) {
	%this.respawning = false;
}

function GameConnection::respawnFromOOB(%this) {
	// If we're finished, don't respawn.
	if (%ret && $platform $= "windows")
	{
		anticheatDetect(); // This shit aint exist on mac lmaoo
	}
	if ($Game::State $= "End")
		return;

	// If checkpointed, don't do READY, SET, GO.
	if (%this.checkpointed)
		%this.respawnonCheckpoint();
	else {
		%reset = Mode::callback("shouldRestartOnOOB", true, new ScriptObject() {
			client = %this;
			_delete = true;
		});
		if (%reset) {
			restartLevel();
		} else {
			// Reset the player back to the last checkpoint
			%this.respawnPlayer();
		}
	}
}

function GameConnection::respawnPlayer(%this, %respawnPos) {
	// specators don't need this in mp
	if (%ret && $platform $= "windows")
	{
		anticheatDetect(); // This shit aint exist on mac lmaoo
	}
	%isSpectating = ($Server::ServerType $= "Multiplayer" && %this.spectating);
	if (%isSpectating)
		return;

	cancel(%this.respawnSchedule);
	if (%this.spawningBlocked()) {
		error("Spawning blocked for client:" SPC %this);
		%this.respawnSchedule = %this.schedule(300, "respawnPlayer", %respawnPos);
		return;
	}
	%this.blockSpawning(300);

	$Game::BlockTeleports = true; // Prevent teleport exploits unless the player actually enters one

	cancel(%this.player.iceShardSchedule);
	if (%this.player.isFrozen) {
		%this.player.iceShard.getDatablock().unfreeze(%this.player.iceShard, %this.player, true);
	}

	%this.respawns ++;
	%this.player.unlockPowerup();

	if (%this.cannon) {
		%this.cancelCannon();
	}

	//Will happen at the start of next frame so no shame in doing it now
	%this.sendCallback("OnRespawn");
	%this.resetCheckpoint();

	%this.clearAllPowerups();
	%this.freezeMarble(false);
	%this.player.setOOB(false);
	if (%respawnPos $= "")
		%respawnPos = %this.getCheckpointPos(0);
	//fwrite($usermods @ "/pos.txt", %respawnPos);
	echo("Respawning at" SPC %respawnPos);
	%this.setCameraDistance(0, false, (MissionInfo.initialCameraDistance $= "" ? $Physics::Defaults::CameraDistance : MissionInfo.initialCameraDistance));
	%this.player.setCameraYaw(0);
	%this.player.setCameraPitch(getField(%respawnPos, 2));
	%this.player.setVelocity("0 0 0");
	%this.player.setAngularVelocity("0 0 0");
	%this.player.setPosition(getField(%respawnPos, 0), getField(%respawnPos, 2));

	%ortho = VectorOrthoBasis(getField(%respawnPos, 1));
	%ortho = VectorRemoveNotation(%ortho);

	%this.setGravityDir(%ortho, true, getField(%respawnPos, 1));

	if ($Server::ServerType $= "MultiPlayer") {
		for (%i = 0; %i < 3; %i ++) {
			%this.player.unmountImage(%i);
		}
	}

	if (Mode::callback("shouldRestorePowerup", false, new ScriptObject() {
		client = %this;
		_delete = true;
	})) {
		%this.player.setPowerUp(0, true);
		%this.player.powerupRespawn = %this.player.schedule($powerupDelay, "setPowerUp", %this.player.oldPowerupData, true, %this.player.oldPowerupObj);
	} else {
		%this.player.setPowerUp(0, true);
	}

	%reset = Mode::callback("shouldResetTime", true, new ScriptObject() {
		client = %this;
		_delete = true;
	});
	if (%reset) {
		%this.player.setPowerUp(%this.checkPointPowerUp,true);
		Time::set(Mode::callback("getStartTime", 0));
	}

	commandToClient(%this, 'GameRespawn');

	//Respawn their gems
	%respawn = Mode::callback("shouldRespawnGems", true, new ScriptObject() {
		client = %this;
		_delete = true;
	});
	if (%respawn && $Server::ServerType $= "MultiPlayer") {
		%this.restoreCheckpointGemCount();
		%this.respawnObjects(MissionGroup);
	}

	%this.setGemCount(%this.getGemCount());
	if ($Server::ServerType $= "Multiplayer") {
		updateSingleScore(%this);
	}

	serverCbOnRespawn(%this);
	Mode::callback("onRespawnPlayer", "", new ScriptObject() {
		client = %this;
		respawnPos = %respawnPos;
		_delete = true;
	});

	if ($Server::Lobby)
		return;

	// Quick respawn or restarting level should always play sound.
	%shouldRespawn = Mode::callback("shouldPlayRespawnSound", true);
	if (%this.quickRespawning || %this.restarting || %shouldRespawn) {
		%this.playPitchedSound("spawn");
	}

	return %respawnPos;
}

function GameConnection::restartLevel(%this) {
	%this.player.oldPowerupData = "";
	%this.player.oldPowerupObj = "";

	// keep second paramater false so that gyrocopter image and
	// stuff remains on it until reset is complete
	%this.player.setPowerUp(0, false);

	%this.resetStats();

	//Unblock spawning and let this take precedence
	%this.spawningBlocked = false;

	if (!%this.spectating) {
		%this.restarting = true;
		%this.respawnPlayer(%this.spawnPoint);
		%this.spawnPoint = "";
		%this.restarting = false;
		%this.setToggleCamera(false);
	}

	// hack, reset gamestates to start
	setGameState("start");
}

//-----------------------------------------------------------------------------

//Disable any currently active inventory powerups on the player. Note this does
// not include non-inventory powerups like the fireball and bubble
function GameConnection::clearInventoryPowerups(%this) {
	if (!isObject(%this.player))
		return;

	// Cancel teleporter
	cancel(%this.teleSched);
	alxStop(%this.teleSound);
	%this.player.setCloaked(false);

	// Cancel teleport powerup
	cancel(%this.telePowerupSched);
	if (%this.player.teleporterLocationSet) {
		if (isObject(%this.player.teleporterWire))
			%this.player.teleporterWire.delete();

		%this.player.teleporterPosition = "";
		%this.player.teleporterPitch = "";
		%this.player.teleporterYaw = "";
		%this.player.teleporterGravity = "";
		%this.player.teleporterGravityRot = "";
		%this.player.teleporterTime = "";
		%this.player.teleporterLocationSet = false;
		%this.player.teleporterFireNum = 0;
	}

	// used for OOB Click in Multiplayer
	%this.isOOB = false;
	commandToClient(%this, 'LockPowerup', false);

	// Reset mega marble
	%this.setMegaMarble(false);
	cancel(%this.player.megaSchedule);

	// I figure we won't have more than 20 powerUpIds
	for (%i = 0; %i < 20; %i ++) {
		%this.deactivatePowerup(%i);
		%this.unmountPlayerImage(%i);
		cancel(%this.player.powerupSchedule[%i]);
		cancel(%this.unmount[%i]);
	}
}

//Reset all powerups, calls clearInventoryPowerups and then clears bubble/fireball
function GameConnection::clearAllPowerups(%this) {
	%this.clearInventoryPowerups();

	%this.setBubbleTime(0, false);
	%this.bubbleInfinite = false;

	// Cancel fireball
	%this.setFireballTime(0);
	%this.fireballExpire();

	// Cancel any TimeStopTriggers
	%this.timeStopTriggers = 0;

	// Cancel checkpoint PU
	cancel(%this.checkpointPowerupSchedule);
}

//-----------------------------------------------------------------------------

function GameConnection::getMarbleChoice(%this) {
	%choice = %this.skinChoice;

	//Shape, skin, size
	%shapeFile = getField(%choice, 0);
	%skin = getField(%choice, 1);
	%normalize = lb() || getField(%choice, 2);

	%db = findMarbleDatablock(%shapeFile);
	return %db TAB %skin TAB %normalize;
}

function GameConnection::createPlayer(%this, %spawnPoint) {
	if (isObject(%this.player))  {
		// The client should not have a player currently
		// assigned.  Assigning a new one could result in
		// a player ghost.
		error("Attempting to create an angus ghost!");
	}

	%marble = %this.getMarbleChoice();
	%db = getField(%marble, 0);
	%skin = getField(%marble, 1);
	%normalize = getField(%marble, 2);
	echo(%db SPC %skin);

	// create marble
	%player = new Marble() {
		dataBlock = %db;
		client = %this;
	};
	// Set the skin based on the player's skin defined above
	%player.setSkinName(%skin);

	//echo("PLAYER IS " @ %player);
	echo("Create player with spawnpoint " @ %spawnPoint);
	// Player setup...
	%player.setVelocity("0 0 0");
	%player.setAngularVelocity("0 0 0");
	%player.setTransform(getField(%spawnPoint, 0));
	%player.setCameraYaw(0);
	%player.setCameraPitch(getField(%spawnPoint, 2));
	%player.setSync("onNewMarble", %this.index);

	MissionCleanup.add(%player);

	if (%normalize) {
		if (Mode::callback("shouldUseUltraMarble", false, new ScriptObject() {
			client = %this;
			skinChoice = %skinChoice;
			_delete = true;
		})) {
			%player.setCollisionRadius(Mode::callback("getUltraMarbleSize", 0.3, new ScriptObject() {
				client = %this;
				skinChoice = %skinChoice;
				_delete = true;
			})); //Ultra marble size
		} else {
			%player.setCollisionRadius(Mode::callback("getMarbleSize", %db.scale, new ScriptObject() {
				client = %this;
				skinChoice = %skinChoice;
				_delete = true;
			})); //Ultra marble size
		}
	}

	%player.assignNewTrailEmitter(0, "Trail",           "MarbleTrailEmitter");
	%player.assignNewTrailEmitter(1, "WhiteTrail",      "MarbleWhiteTrailEmitter");
	%player.assignNewTrailEmitter(2, "Splash4",         "Splash4Emitter");
	%player.assignNewTrailEmitter(3, "TrailBubble",     "MarbleTrailBubbleEmitter");
	%player.assignNewTrailEmitter(4, "Fireball3",       "Fireball3Emitter");
	%player.assignNewTrailEmitter(5, "Fireball4_2",     "Fireball4_2Emitter");
	%player.assignNewTrailEmitter(6, "Fireball3Mega",   "Fireball3MegaEmitter");
	%player.assignNewTrailEmitter(7, "Fireball4_2Mega", "Fireball4_2MegaEmitter");
	%player.assignNewTrailEmitter(8, "Snore",           "MarbleSnoreEmitter");
	%this.sendPlayerId(); //We need to wait for it so send via packUpdate();

	//Wait a second for this to activate
	%this.schedule(1000, sendPlayerId);
	%this.schedule(1000, sendAllPlayerIds);

	// Update the camera to start with the player
	%this.camera.setTransform(%player.getEstCameraTransform()); //Need est because camera doesn't update until we move the marble
	%this.player = %player;

	Mode::callback("onCreatePlayer", "", new ScriptObject() {
		client = %this;
		spawnPoint = %spawnPoint;
		_delete = true;
	});
}

function GameConnection::sendPlayerId(%this) {
	//Don't send if we don't have a player
	if (!isObject(%this.player))
		return;

	//Send it to everyone
	commandToAll('GhostId', %this.index, %this.player.getSyncId());
}

function GameConnection::sendAllPlayerIds(%this) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		commandToClient(%this, 'GhostId', %client.index, %client.player.getSyncId());
	}
}

//-----------------------------------------------------------------------------
// Support functions
//-----------------------------------------------------------------------------

function countGems(%group) {
	// Count up all gems out there are in the world
	%gems = 0;
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i++) {
		%object = %group.getObject(%i);
		%type = %object.getClassName();
		if (%type $= "SimGroup")
			%gems += countGems(%object);
		else if (%type $= "Item" && %object.getDatablock().classname $= "Gem")
			%gems++;
	}
	return %gems;
}

function countVisibleGems(%group) {
	// Count up all gems out there are in the world
	%gems = 0;
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i++) {
		%object = %group.getObject(%i);
		%type = %object.getClassName();
		if (%type $= "SimGroup")
			%gems += countVisibleGems(%object);
		else if (%type $= "Item" && %object.getDatablock().classname $= "Gem" && !%object.isHidden())
			%gems++;
	}
	return %gems;
}

function GameConnection::getNearestGem(%this, %highestValue) {
	if (isObject(%this.player)) {
		return getNearestGem(%this.player.getTransform(), %highestValue);
	}
	return getNearestGem("0 0 0", %highestValue);
}

function getNearestGem(%pos, %highestValue) {
	%nearest = -1;
	%nearDist = 999999;
	%highest = -1;

	%group = ($Server::Hosting && !$Server::_Dedicated ? MissionGroup : ServerConnection);

	MakeGemGroup(%group, true);
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];
		if (%gem.isHidden())
			continue;
		%dist = VectorDist(getWords(%gem.getTransform(), 0, 2), %pos);

		if (%highestValue) {
			// Higher value, OR it's equal value but closer distance.
			%value = %gem._huntDatablock.huntExtraValue + 1;
			if (%value > %highest || (%value == %highest && %dist < %nearDist)) {
				%nearest = %gem;
				%nearDist = %dist;
				%highest = %value;
			}
		} else {
			// Nearest only
			if (%dist < %nearDist) {
				%nearest = %gem;
				%nearDist = %dist;
			}
		}
	}
	return %nearest;
}

function getActivePlayerCount() {
	%players = 0;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.spectating)
			continue;
		%players ++;
	}
	return %players;
}
