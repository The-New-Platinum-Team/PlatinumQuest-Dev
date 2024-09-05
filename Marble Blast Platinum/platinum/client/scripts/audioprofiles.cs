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

// Channel assignments (channel 0 is unused in-game).


// UNCOMMENT ONCE SOUNDS ARE IMPLEMENTED IN CODE
$GameAudioType = 0; // Fuck dedicated servers
$AchievementAudioType  = 1;
$SimAudioType     = 1;
$MessageAudioType = 1;
$EffectAudioType  = 1;
$MusicAudioType   = 2;
$GuiAudioType     = 3;

RootGroup.add(new SimGroup(ClientAudioGroup));

ClientAudioGroup.add(new AudioDescription(AudioGui) {
	volume   = 1.0;
	isLooping= false;
	is3D     = false;
	type     = $GuiAudioType;
});

ClientAudioGroup.add(new AudioDescription(LoopingAudioGui) {
	volume   = 1.0;
	isLooping= true;
	is3D     = false;
	type     = $GuiAudioType;
});
ClientAudioGroup.add(new AudioDescription(AudioChatGui) {
	volume   = 0.8;
	isLooping= false;
	is3D     = false;
	type  = $GuiAudioType;
});
ClientAudioGroup.add(new AudioDescription(AudioAchievementGui) {
	volume   = 1.0;
	isLooping= false;
	is3D     = false;
	type     = $AchievementAudioType;
});

ClientAudioGroup.add(new AudioDescription(ClientAudio2D) {
	volume   = 1.0;
	isLooping= false;
	is3D     = false;
	type     = $MessageAudioType;
});

ClientAudioGroup.add(new AudioDescription(ClientAudioLooping2D) {
	volume = 1.0;
	isLooping = true;
	is3D = false;
	type = $EffectAudioType;
});

ClientAudioGroup.add(new AudioProfile(GetAchievement) {
	fileName = "~/data/sound/getachievement.wav";
	description = AudioAchievementGui;
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(LB_Recieve) {
	fileName = "~/data/sound/lb_recieve.wav";
	description = AudioChatGui;
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(LB_Nudge) {
	fileName = "~/data/sound/lb_nudge.wav";
	description = AudioChatGui;
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(LB_Logout) {
	filename = "~/data/sound/lb_signout.wav";
	description = "AudioGui";
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(LB_Login) {
	filename = "~/data/sound/lb_signin.wav";
	description = "AudioGui";
	preload = true;
});

new AudioProfile(PlayerJoinSfx) {
	filename = "~/data/sound/player_join.wav";
	description = "AudioGui";
	preload = true;
};

new AudioProfile(PlayerLeaveSfx) {
	filename = "~/data/sound/player_leave.wav";
	description = "AudioGui";
	preload = true;
};

ClientAudioGroup.add(new AudioProfile(TimeTravelLoopSfx) {
	filename    = "~/data/sound/TimeTravelActive.wav";
	description = ClientAudioLooping2d;
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(AudioButtonOver) {
	filename = "~/data/sound/buttonOver.wav";
	description = "AudioGui";
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(AudioButtonDown) {
	filename = "~/data/sound/ButtonPress.wav";
	description = "AudioGui";
	preload = true;
});

new AudioProfile(PauseMenuSfx) {
	filename = "~/data/sound/pause.wav";
	description = "AudioGui";
	preload = true;
};

ClientAudioGroup.add(new AudioProfile(TimerAlarm) {
	filename = "~/data/sound/alarm.wav";
	description = "LoopingAudioGui";
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(GotAwesomeSfx) {
	filename = "~/data/sound/gotawesome.wav";
	description = "AudioGui";
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(GotAwesomeAwesomeSfx) {
	filename = "~/data/sound/gotawesomeawesome.wav";
	description = "AudioGui";
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(LBError) {
	filename = "~/data/sound/lb_error.wav";
	description = "AudioGui";
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(LBNope) {
	filename = "~/data/sound/lb_failed.wav";
	description = "LoopingAudioGui";
	preload = true;
});

ClientAudioGroup.add(new AudioProfile(BubblePopSfx) {
	filename    = "~/data/sound/bubble_pop.wav";
	description = "ClientAudio2D";
	preload = true;
});

function registerSoundKey(%sound, %index) {
	%base = "platinum/data/sound/" @ %sound @ "/";
	%keys = "A A_flat B B_flat C C_sharp D E E_flat F F_sharp G";

	for (%i = 0; %i < getWordCount(%keys); %i ++) {
		%key = getWord(%keys, %i);
		$SoundProfile[%sound, %key] = %sound @ %key;
		ClientAudioGroup.add(new AudioProfile(%sound @ %key) {
			filename = %base @ %key @ ".wav";
			description = "ClientAudio2D";
			preload = true;
		});
	}
}

$SoundProfile["gotDiamond", "A_flat_5"] = "gotDiamondA_flat_5";
ClientAudioGroup.add(new AudioProfile("gotDiamondA_flat_5") {
	filename = "platinum/data/sound/gotDiamond/A_flat_5.wav";
	description = "ClientAudio2D";
	preload = true;
});
$SoundProfile["gotDiamond", "F_5"] = "gotDiamondF_5";
ClientAudioGroup.add(new AudioProfile("gotDiamondF_5") {
	filename = "platinum/data/sound/gotDiamond/F_5.wav";
	description = "ClientAudio2D";
	preload = true;
});

//What field of $Key these line up with
registerSoundKey("alarm");
registerSoundKey("alarm_timeout");
registerSoundKey("checkpoint");
registerSoundKey("firewrks");
registerSoundKey("gotDiamond");
registerSoundKey("gotAllDiamonds");
registerSoundKey("missinggems");
registerSoundKey("easter");
registerSoundKey("easterfound");
registerSoundKey("spawn");
registerSoundKey("opponentDiamond");

function loadMusicKeys() {
	%pattern = expandFilename("~/client/audio/*.json");
	for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
		%conts = jsonParse(fread(%file));

		if (!isObject(%conts))
			continue;

		if (fileBase(%file) $= "default") {
			$KeyDefault = %conts;
		} else {
			$Key[fileBase(%file)] = %conts;
		}
	}
}

loadMusicKeys();

function playPitchedSound(%sound, %key) {
	//Ignore on credits
	if ($Game::Credits) {
		return;
	}

	%music = fileBase($currentMusicBase);

	if (getSubStr(%sound, 0, 10) $= "gotDiamond") {
		%sfxName = "gotDiamond";
	} else {
		%sfxName = %sound;
	}

	//If you have music off, just use the default pitch. Otherwise there's no
	// reason to pitch shift.
	if ($pref::Audio::channelVolume2 <= 0.01) {
		%key = $KeyDefault;
		%pitch = %key.getFieldValue(%sound);
		if (%sound $= "gotDiamond") {
			//Hack: gem sounds can be anything if you have the music off!

			if ($playSong $= "") {
				//Not every time, and only after a few times
				$playSong = (getRandom() < 0.001) && ($pref::tipCount > 20);
			}

			if ($playSong) {
				//Credits to Whirligig for transcribing this
				%notes = "B_flat C C_sharp C_sharp E_flat C B_flat A_flat B_flat B_flat C C_sharp B_flat A_flat A_flat_5 A_flat_5 E_flat B_flat B_flat C C_sharp B_flat C_sharp E_flat C B_flat B_flat A_flat B_flat B_flat C C_sharp B_flat A_flat A_flat E_flat E_flat E_flat F_5 E_flat C_sharp E_flat F_5 C_sharp E_flat E_flat E_flat F_5 E_flat A_flat A_flat B_flat C C_sharp B_flat E_flat F_5 E_flat A_flat B_flat C_sharp B_flat F_5 F_5 E_flat A_flat B_flat C B_flat E_flat E_flat C_sharp A_flat B_flat C_sharp B_flat C_sharp E_flat C A_flat A_flat E_flat C_sharp A_flat B_flat C_sharp B_flat F_5 F_5 E_flat A_flat B_flat C A_flat A_flat_5 C C_sharp A_flat B_flat C_sharp B_flat C_sharp E_flat C A_flat A_flat E_flat C_sharp";
				if ($songOn >= getWordCount(%notes)) {
					$songOn = 0;
					$playSong = false;
				}
				%pitch = getWord(%notes, $songOn);
				$songOn ++;
			}
		}
	} else {
		%key = $Key[%music] $= "" ? $KeyDefault : $Key[%music];
		%pitch = %key.getFieldValue(%sound);
	}
	if (%pitch $= "" && %sfxName $= "gotDiamond") {
		// Modify the sound to conform to standard four pitches
		%pitchNum = getSubStr(%sound, 10, 15);
		if (%pitchNum == 3 || %pitchNum == 4) {
			%pitch = %key.getFieldValue("gotDiamond2");
		} else if (%pitchNum >= 8) {
			%pitch = %key.getFieldValue("gotDiamond10");
		} else {
			%pitch = %key.getFieldValue("gotDiamond5");
		}
	}

	%sfx = $SoundProfile[%sfxName, %pitch];
	%handle = alxPlay(%sfx);
}

ClientAudioGroup.add(new AudioDescription(AudioMusic) {
	volume   = 1.0;
	isLooping = true;
	isStreaming = true;
	is3D     = false;
	type     = $MusicAudioType;
});

function playMusic(%musicFileBase) {
	//Don't play it twice
	if (alxIsPlaying($currentMusicHandle) && $currentMusicBase $= %musicFileBase)
		return;

	if (%musicFileBase $= "") {
		pauseMusic();
		return;
	}

	alxStop($currentMusicHandle);
	if (isObject(MusicProfile))
		MusicProfile.delete();

	%file = "~/data/sound/music/" @ %musicFileBase;
	ClientAudioGroup.add(new AudioProfile(MusicProfile) {
		fileName = %file;
		description = "AudioMusic";
		preload = false;
	});
	$currentMusicBase = %musicFileBase;
	$currentMusicHandle = alxPlay(MusicProfile);  //add this line

	JukeboxDlg.selectPlayingSong();
	$JukeboxDlg::isPlaying = true;
}

function playShellMusic() {
	if ($GuiPack::Active) {
		if (lb() && $GuiPack::CurrentPack.LBShellMusic !$= "") {
			playMusic(getVariable("$pref::" @ upperFirst($GuiPack::CurrentPack.identifier) @ "Gui::SongsLB"));
			return;
		} else if ($GuiPack::CurrentPack.ShellMusic !$= "") {
			playMusic(getVariable("$pref::" @ upperFirst($GuiPack::CurrentPack.identifier) @ "Gui::SongsMenu"));
			return;
		}
	}
	if (!$TexturePack::MBXP) 
		playMusic(getMusicFile("Menu"));
	else
		playMusic(getMusicFile("XP"));
}

function playLBMusic() {
	if ($GuiPack::Active) {
		if ($GuiPack::CurrentPack.LBShellMusic !$= "") {
			playMusic(getVariable("$pref::" @ upperFirst($GuiPack::CurrentPack.identifier) @ "Gui::SongsLB"));
			return;
		}
	}
	playMusic(getMusicFile("LB"));
}

function playGameMusic() {
	if (MissionInfo.music !$= "" && MissionInfo.music !$= "Pianoforte.ogg") {
		if (getSubStr(MissionInfo.music, 0, 1) $= "@")
			%file = filePath($Client::MissionFile) @ "/" @ getSubStr(MissionInfo.music, 1, strlen(MissionInfo.music));
		else
			%file = $usermods @ "/data/sound/music/" @ MissionInfo.music;

		if (isFile(%file))
			playMusic(MissionInfo.music);
		else
			playMusic(getMusicFile("Game"));
		return;
	}
	playMusic(getMusicFile("Game"));
}

function pauseMusic() {
	alxStop($currentMusicHandle);
	$JukeboxDlg::isPlaying = false;
}

function resumeMusic() {
	playMusic($currentMusicBase);
	$JukeboxDlg::isPlaying = true;
}

$Music::Exclude = "Pianoforte\tComforting Mystery\tQuiet Lab\tUpbeat Finale\tGood to Jump to (Loop Edit)\tElectroforte\tShell\tXmas Trance\tHalloween Trance\tFlanked\tMBP Old Shell\tMetropolis\tSeaside";
function buildMusicList() {
	if (!$musicFound) {
		$NumMusicFiles = 0;
		for (%file = findFirstFile($usermods @ "/data/sound/music/*.ogg"); %file !$= ""; %file = findNextFile($usermods @ "/data/sound/music/*.ogg")) {
			if (findField($Music::Exclude, fileBase(%file)) == -1) {
				$Music[$NumMusicFiles] = fileBase(%file) @ ".ogg";
				$NumMusicFiles++;
			}
		}
		$musicFound = true;
	}
}

$Music::Songs["LB"]     = "Comforting Mystery.ogg";
$Music::Songs["Menu"]   = "Pianoforte.ogg";
$Music::Songs["XP"]   = "ShellXP.ogg";
$Music::Songs["Game"]   = "*";

function getMusicFile(%location) {
	//Grab the songs for the location
	%songs = $pref::Music::Songs[%location];
	if (%songs $= "")
		%songs = $Music::Songs[%location];
	if (%songs $= "")
		return "Pianoforte.ogg";

	if (%songs $= "None")
		return "";

	//Make sure we have the music list
	buildMusicList();

	//Special wildcard "*"
	if (%songs $= "*") {
		if ($NumMusicFiles)
			return $Music[getRandom($NumMusicFiles - 1)];
		else
			return "Pianoforte.ogg";
	}

	//Or just play one from the list they gave us
	%song = getField(%songs, getRandom(getFieldCount(%songs) - 1));

	return %song;
}

//-----------------------------------------------------------------------------

function loadAudioPack(%packname) {
	warn("Resetting Audio Pack...");
	audioPackReset(RootGroup);
	if (mp())
		audioPackReset(ServerConnection);

	%apk = $userMods @ "/data/sound/ap_" @ %packname @ "/" @ %packname @ ".apk";
	%pack = jsonParse(fread(%apk));
	if (!isObject(%pack)) {
		if (%pack !$= "") {
			MessageBoxOk("Audio Pack Error!", "Could not load the audio pack \"" @ %packname @ "\"!");
		}
		return;
	}
	%pack.dump();
	warn("Executed Audio Pack" SPC %pack.name SPC "by" SPC %pack.author @ "...");
	$Audio::CurrentAudioPack = %pack;

	warn("Loading Audio Pack...");
	audioPackIterate(RootGroup, %pack);
	if (mp())
		audioPackIterate(ServerConnection, %pack);

	$SpawnKeyDefault = %pack.defaultSpawnKey;
}

function audioPackReset(%grp) {
	$Audio::CurrentAudioPack = "";
	for (%i = 0; %i < %grp.getCount(); %i ++) {
		%obj = %grp.getObject(%i);
		//Because texture materials don't have getClassName()... somehow
		$con::logBufferEnabled = false;
		%class = %obj.getClassName();
		$con::logBufferEnabled = true;
		switch$ (%class) {
		case "SimGroup":
			audioPackReset(%obj, %pack);
		case "AudioProfile":
			%filename = %obj.filename;
			%oldFilename = %obj.oldFilename;
			if (%oldFilename !$= "") {
				if (%filename !$= %oldFilename)
					echo("Substituting modified file" SPC %filename SPC "for original audio file" SPC %oldFilename);
				%obj.filename = %oldFilename;
			}
		default:
			continue;
		}
	}
}

function audioPackIterate(%grp, %pack) {
	for (%i = 0; %i < %grp.getCount(); %i ++) {
		%obj = %grp.getObject(%i);
		//Because texture materials don't have getClassName()... somehow
		$con::logBufferEnabled = false;
		%class = %obj.getClassName();
		$con::logBufferEnabled = true;
		switch$ (%class) {
		case "SimGroup":
			audioPackIterate(%obj, %pack);
		case "AudioProfile":
			%filename = %obj.filename;
			%base = fileBase(%filename);

			%found = false;
			if (%pack.sounds.getFieldValue(%base) !$= "") {
				%found = true;
			} else {
				//Pitched sounds?
				%base = fileBase(filePath(%fileName));

				if (%pack.sounds.getFieldValue(%base) !$= "") {
					%found = true;
				}
			}

			if (%found) {
				if (%obj.oldFilename $= "") {
					%obj.oldFilename = %filename;
				}
				%newfilename = $userMods @ "/data/sound/ap_" @ %pack.identifier @ "/" @ %base @ ".wav";
				echo("Substituting original file" SPC %filename SPC "for new audio file" SPC %newfilename);
				if (isFile(%newfilename))
					%obj.filename = %newfilename;
				else
					error("Could not find file" SPC %newfilename);
			}
		default:
			continue;
		}
	}
}
