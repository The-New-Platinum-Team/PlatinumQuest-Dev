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

//----------------------------------------------------------------------------
// Mission Loading & Mission Info
// The mission loading server handshaking is handled by the
// common/client/missingLoading.cs.  This portion handles the interface
// with the game GUI.
//----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Player list
//
// Client Ready States:
// 0 - Lobby
// 1 - Preloading
// 2 - Ready for Start
//
// Client Load States:
// 0 - Loading
// 1 - Sending Files
// 2 - Confirming
// 3 - Ready
// 4 - Playing
//
//-----------------------------------------------------------------------------

//----------------------------------------------------------------------------
// Loading Phases:
// Phase 1: Download Datablocks
// Phase 2: Download Ghost Objects
// Phase 3: Scene Lighting

//----------------------------------------------------------------------------
// Phase 1
//----------------------------------------------------------------------------

function onMissionDownloadPhase1(%missionName, %musicTrack) {
	if ($Server::_Dedicated) {
		// My ears, my ears!

		// Better version only affects game sounds
		alxSetChannelVolume($GameAudioType, $pref::Audio::channelVolume1);
	}

	//Reload stuff so we don't have collisions
	flushInteriorRenderBuffers();
	cleanupReflectiveMarble();

	// Close and clear the message hud (in case it's open)
	//MessageHud.close();
	//cls();

	if (!$pref::NoFadeIn) {
		// this variable is used for the fader effect in playGui::onWake
		$PlayGuiFader = true;
	}

	setLoadProgress(0, 1, 0);
}

function onPhase1Progress(%progress) {
	setLoadProgress(0, 1, %progress);
}

function onPhase1Complete() {
	setLoadProgress(0, 1, 1);
}

//----------------------------------------------------------------------------
// Phase 2
//----------------------------------------------------------------------------

function onMissionDownloadPhase2() {
	setLoadProgress(0, 2, 0);
}

function onPhase2Progress(%progress) {
	setLoadProgress(0, 2, %progress);
}

function onPhase2Complete() {
	setLoadProgress(0, 2, 1);
	$MP::DownloadingFile = false;
}

//----------------------------------------------------------------------------
// Phase 3
//----------------------------------------------------------------------------

function onMissionDownloadPhase3() {
	setLoadProgress(0, 3, 0);
}

function onPhase3Progress(%progress) {
	setLoadProgress(0, 3, %progress);
}

function onPhase3Complete() {
	setLoadProgress(3, 1, 1);

	//Safe to do this here, should cover SP as well as MP

	//MBG Customs Textures Patch
	if (!$pref::FastMode) {
		if (!$skyMBG && Sky.materialList $= "platinum/data/skies/sky_day.dml") {
			mbgTexPatchActivate();
			$skyMBG = true;
		} else if ($skyMBG && Sky.materialList !$= "platinum/data/skies/sky_day.dml") {
			mbgTexPatchDeactivate();
			$skyMBG = false;
		}
	}
	
	//Automatic Audio
	if ($pref::AutomaticAudio) {
		$optimizedaudio = false;
		if (Sky.materialList $= "platinum/data/skies/sky_day.dml") { 
			loadAudioPack(mbg);
		} else if 
			((MissionInfo.game $= "Ultra") || (MissionInfo.modification $= "Ultra")) {
			loadAudioPack(mbu);
		} else if 
			((MissionInfo.game $= "Platinum") || ((Sky.materialList $= "platinum/data/skies/Beginner/Beginner_Sky.dml") || (Sky.materialList $= "platinum/data/skies/Intermediate/Intermediate_Sky.dml") || (Sky.materialList $= "platinum/data/skies/Advanced/Advanced_Sky.dml") || (Sky.materialList $= "platinum/data/skies/Expert/Expert_Sky.dml") || (Sky.materialList $= "platinum/data/skies/Bonus/Bonus_Sky.dml") || (Sky.materialList $= "platinum/data/skies/SpaceStation/SpaceStationSky.dml"))) {
			loadAudioPack(mbp);
		} else if 
			((MissionInfo.game $= "PlatinumQuest") || (MissionInfo.modification $= "PlatinumQuest")) {
			loadAudioPack($pref::Audio::AudioPack);
		}
    } else if (!$optimizedaudio) {
		$optimizedaudio = true;
		loadAudioPack($pref::Audio::AudioPack);
	}
}

// Start of MBG Custom Textures Patch

function mbgTexPatchActivate() {
	swapTextures("platinum/data/interiors/custom_woodblockside", "platinum/data/interiors_mbg/custom_woodblockside");
	swapTextures("platinum/data/interiors/custom_woodblocktop", "platinum/data/interiors_mbg/custom_woodblocktop");
	swapTextures("platinum/data/interiors/edge_cool1", "platinum/data/interiors_mbg/edge_cool1");
	swapTextures("platinum/data/interiors/edge_cool2", "platinum/data/interiors_mbg/edge_cool2");
	swapTextures("platinum/data/interiors/edge_neutral1", "platinum/data/interiors_mbg/edge_neutral1");
	swapTextures("platinum/data/interiors/edge_neutral2", "platinum/data/interiors_mbg/edge_neutral2");
	swapTextures("platinum/data/interiors/edge_warm1", "platinum/data/interiors_mbg/edge_warm1");
	swapTextures("platinum/data/interiors/edge_warm2", "platinum/data/interiors_mbg/edge_warm2");
	swapTextures("platinum/data/interiors/edge_white", "platinum/data/interiors_mbg/edge_white");
	swapTextures("platinum/data/interiors/grid_cool2", "platinum/data/interiors_mbg/grid_cool2");
	swapTextures("platinum/data/interiors/grid_neutral", "platinum/data/interiors_mbg/grid_neutral");
	swapTextures("platinum/data/interiors/grid_neutral1", "platinum/data/interiors_mbg/grid_neutral1");
	swapTextures("platinum/data/interiors/grid_neutral2", "platinum/data/interiors_mbg/grid_neutral2");
	swapTextures("platinum/data/interiors/grid_neutral4", "platinum/data/interiors_mbg/grid_neutral4");
	swapTextures("platinum/data/interiors/grid_warm", "platinum/data/interiors_mbg/grid_warm");
	swapTextures("platinum/data/interiors/grid_warm1", "platinum/data/interiors_mbg/grid_warm1");
	swapTextures("platinum/data/interiors/stripe_caution", "platinum/data/interiors_mbg/stripe_caution");
	swapTextures("platinum/data/interiors/tube_cool", "platinum/data/interiors_mbg/tube_cool");
	swapTextures("platinum/data/interiors/tube_neutral", "platinum/data/interiors_mbg/tube_neutral");
	swapTextures("platinum/data/interiors/tube_warm", "platinum/data/interiors_mbg/tube_warm");
	swapTextures("platinum/data/interiors/edge_white2", "platinum/data/interiors_mbg/edge_white2");
}

function mbgTexPatchDeactivate() {
	swapTextures("platinum/data/interiors/custom_woodblockside", "platinum/data/interiors/custom_woodblockside");
	swapTextures("platinum/data/interiors/custom_woodblocktop", "platinum/data/interiors/custom_woodblocktop");
	swapTextures("platinum/data/interiors/edge_cool1", "platinum/data/interiors/edge_cool1");
	swapTextures("platinum/data/interiors/edge_cool2", "platinum/data/interiors/edge_cool2");
	swapTextures("platinum/data/interiors/edge_neutral1", "platinum/data/interiors/edge_neutral1");
	swapTextures("platinum/data/interiors/edge_neutral2", "platinum/data/interiors/edge_neutral2");
	swapTextures("platinum/data/interiors/edge_warm1", "platinum/data/interiors/edge_warm1");
	swapTextures("platinum/data/interiors/edge_warm2", "platinum/data/interiors/edge_warm2");
	swapTextures("platinum/data/interiors/edge_white", "platinum/data/interiors/edge_white");
	swapTextures("platinum/data/interiors/grid_cool2", "platinum/data/interiors/grid_cool2");
	swapTextures("platinum/data/interiors/grid_neutral", "platinum/data/interiors/grid_neutral");
	swapTextures("platinum/data/interiors/grid_neutral1", "platinum/data/interiors/grid_neutral1");
	swapTextures("platinum/data/interiors/grid_neutral2", "platinum/data/interiors/grid_neutral2");
	swapTextures("platinum/data/interiors/grid_neutral4", "platinum/data/interiors/grid_neutral4");
	swapTextures("platinum/data/interiors/grid_warm", "platinum/data/interiors/grid_warm");
	swapTextures("platinum/data/interiors/grid_warm1", "platinum/data/interiors/grid_warm1");
	swapTextures("platinum/data/interiors/stripe_caution", "platinum/data/interiors/stripe_caution");
	swapTextures("platinum/data/interiors/tube_cool", "platinum/data/interiors/tube_cool");
	swapTextures("platinum/data/interiors/tube_neutral", "platinum/data/interiors/tube_neutral");
	swapTextures("platinum/data/interiors/tube_warm", "platinum/data/interiors/tube_warm");
	swapTextures("platinum/data/interiors/edge_white2", "platinum/data/interiors/edge_white2");
}

// End of MBG Custom Textures Patch

//----------------------------------------------------------------------------

$MP::LoadPhases[0] = 3;
$MP::LoadPhases[1] = 1;
$MP::LoadPhases[2] = 1;
$MP::LoadPhases[3] = 1;
$MP::LoadPhases[4] = 1;

function setLoadProgress(%loadState, %phase, %progress) {
	//echo("Set load progress " @ %loadState SPC %phase SPC %progress);
	//backtrace();

	//Adjusted progress (eg state 1 phase 2 progress 0 is 0.333)
	%adjusted = getLoadProgress(%loadState, %phase, %progress);

	//Notify the menu system if we're using that
	if ($Game::Menu) {
		//We don't care about the other phases offline, but it looks bad if
		// we say we're at 0%.
		if (%loadState > 0) {
			menuOnLoadProgress(1);
		} else {
			menuOnLoadProgress(%adjusted);
		}
	}

	if (mp()) {
		//Update our loading bar on MPPMG if we have one
		if (isObject(PlayerListBox @ $MP::ClientIndex)) {
			(PlayerListBox @ $MP::ClientIndex).setValue(%adjusted);
		}

		//Update our client-side player info if that exists
		%entry = PlayerList.getEntry($MP::ClientIndex);
		if (isObject(%entry)) {
			%entry.progress = %adjusted;
			%entry.loadState = %loadState;
			PlayMissionGui.updateServerPlayerList();
		}

		//Round it off so we don't send too many updates to the server
		%rounded = getNextLoadSegment(%loadState, %adjusted);
		if (!$pref::FastMode && %rounded !$= $MP::LastLoadProgress[%loadState]) {
			//Tell our server we have more progress
			commandToServer('MissionLoadProgress', %rounded, %loadState);
			$MP::LastLoadProgress[%loadState] = %rounded;
		}
	}
}

function getLoadProgress(%loadState, %phase, %progress) {
	if (%loadState < 0 || %phase < 0 || %progress < 0) return 0;
	return ((%phase - 1) / $MP::LoadPhases[%loadState]) + (%progress / $MP::LoadPhases[%loadState]);
}
function getNextLoadSegment(%loadState, %progress) {
	return mFloor(%progress * $MP::LoadSegments) / $MP::LoadSegments;
}

//----------------------------------------------------------------------------
// Mission loading done!
//----------------------------------------------------------------------------

function onMissionDownloadComplete() {
	// Client will shortly be dropped into the game, so this is
	// good place for any last minute gui cleanup.
	PlayMissionGui.updateMissionInfo();

	if (mp()) {
		PlayMissionGui.updateTeams();
	}
}

//----------------------------------------------------------------------------
// Receiving files
//----------------------------------------------------------------------------

function onFileChunkReceived(%file, %recv, %total) {
	if ($downloadStart[%file] $= "" || %recv < $downloadCurrent[%file])
		$downloadStart[%file] = getRealTime();

	$downloadCurrent[%file] = %recv;

	%rateS = (getRealTime() - $downloadStart[%file]) / 1000;
	%rate = %recv / %rateS;

	%estimated = ((getRealTime() - $downloadStart[%file]) / (%recv / %total)) - (getRealTime() - $downloadStart[%file]);

	if (%file !$= $downloadLastFile) {
		$downloadLastFile = %file;
		commandToServer('MissionLoadFile', %file);
	}

	%progress = %recv / %total;
	setLoadProgress(1, 1, %progress);

	$MP::LastDownloadUpdate = $Sim::Time;
	$MP::DownloadingFile = true;
}

//------------------------------------------------------------------------------
// Before downloading a mission, the server transmits the mission
// information through these messages.
//------------------------------------------------------------------------------

addMessageCallback('MsgClientIndex', handleClientIndexMessage);
addMessageCallback('MsgLoadInfo', handleLoadInfoMessage);
addMessageCallback('MsgLoadDescripition', handleLoadDescriptionMessage);
addMessageCallback('MsgServerDedicated', handleServerDedicatedMessage);
addMessageCallback('MsgServerDescription', handleServerInfoMessage);
addMessageCallback('MsgServerName', handleServerNameMessage);
addMessageCallback('MsgReadyCount', handleReadyCountMessage);
addMessageCallback('MsgLoadInfoDone', handleLoadInfoDoneMessage);
addMessageCallback('MsgLoadMissionInfoPart', handleLoadMissionInfoPartMessage);
addMessageCallback('MsgServerPrefs', handleServerPrefsMessage);

//------------------------------------------------------------------------------

function clientCmdShowLoadScreen() {
	if ($Game::Menu) {
		menuStartLoading();
	} else if (mp()) {
		setLoadProgress(0, 0, 0);

		//PMG does loading in MP
		RootGui.setContent(PlayMissionGui);
		PlayMissionGui.onMPStartLoading();
	} else {
		// Need to pop up the loading gui to display this stuff.
		RootGui.setContent(LoadingGui);
	}
}

function clientCmdMissionLoadFailed() {
	if ($Game::Menu) {
		menuOnMissionLoadFailed();
	} else if (mp()) {
		//Problems
		RootGui.setContent(PlayMissionGui);
		PlayMissionGui.onMPLoadFailed();
	} else {
		// We've failed, go back to PMG
		RootGui.setContent(PlayMissionGui);
	}
}

function handleClientIndexMessage(%msgType, %msgString, %index) {
	$MP::ClientIndex = %index;
}

//------------------------------------------------------------------------------

function handleLoadInfoMessage(%msgType, %msgString, %mapName) {
	if ($Game::Menu)
		return;

	// Clear all of the loading info lines:
	// for( %line = 0; %line < LoadingGui.qLineCount; %line++ )
	//LoadingGui.qLine[%line] = "";
	//LoadingGui.qLineCount = 0;

//	RootGui.setContent("LoadingGui");

	$Game::MapName = %mapName;

	$MP::MissionInfoPart = new ScriptObject() {};

	MPPreGameDlg.mapName = %mapName;
	MPPreGameDlg.updateInfo();
}

//------------------------------------------------------------------------------

function handleLoadDescriptionMessage(%msgType, %msgString, %line) {
	MPPreGameDlg.mapDesc = %line;
	MPPreGameDlg.updateInfo();
}

//------------------------------------------------------------------------------

function handleServerDedicatedMessage(%msgType, %msgString, %dedicated) {
	MPPreGameDlg.dedicated = %dedicated;
	MPPreGameDlg.updateInfo();
}

//------------------------------------------------------------------------------

function handleServerInfoMessage(%msgType, %msgString, %info) {
	MPPreGameDlg.info = %info;
	MPPreGameDlg.updateInfo();
}

//------------------------------------------------------------------------------

function handleServerNameMessage(%msgType, %msgString, %serverName) {
	MPPreGameDlg.serverName = %serverName;
	MPPreGameDlg.updateInfo();
}

//------------------------------------------------------------------------------

function handleReadyCountMessage(%msgType, %msgString, %readyCount, %playerCount) {
	MPPreGameDlg.readyCount = %readyCount;
	MPPreGameDlg.playerCount = %playerCount;
	MPPreGameDlg.updateInfo();
}

//------------------------------------------------------------------------------

function handleLoadMissionInfoPartMessage(%msgType, %msgString, %key, %value) {
	// This spits out the mission info
	$MP::MissionInfoPart.setFieldValue(%key, $MP::MissionInfoPart.getFieldValue(%key) @ %value);
}

//------------------------------------------------------------------------------

function handleLoadInfoDoneMessage(%msgType, %msgString) {
	// This will get called after the last description line is sent.

	if ((!$Server::Hosting || $Server::_Dedicated) && $Server::ServerType $= "MultiPlayer") {
		$MP::MissionInfoPart.setName("MissionInfo");
		$MP::MissionInfoPart.file = $Client::MissionFile;
	}
//   echo($MP::MissionInfoString);
}

//------------------------------------------------------------------------------

function handleServerPrefsMessage(%msgType, %msgString, %requiredAmount, %chargeTime, %quickRespawn, %blastPower, %rechargePower, %info, %fast) {
	$MP::BlastRequiredAmount = %requiredAmount;
	$MP::BlastChargeTime = %chargeTime;
	$MP::AllowQuickRespawn = %quickRespawn;
	$MP::BlastPower = %blastPower;
	$MP::BlastRechargePower = %rechargePower;
	$MP::ServerInfo = %info;
	$MP::FastPowerups = %fast;
	if ($MP::ServerChat $= "") {
		onServerChat(LBChatColor("welcome") @ %info @ "\n");
		MPUpdateServerChat(); //Reset
	}
}

