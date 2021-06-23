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

// UNCOMMENT ONCE SOUNDS ARE IMPLEMENTED IN CODE
$GameAudioType = 0; // Fuck dedicated servers
$AchievementAudioType  = 1;
$SimAudioType     = 1;
$MessageAudioType = 1;
$EffectAudioType  = 1;
$MusicAudioType   = 2;
$GuiAudioType     = 3;

//-----------------------------------------------------------------------------
// 3D Sounds
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Single shot sounds

datablock AudioDescription(AudioDefault3d) {
	volume   = 1.0;
	isLooping= false;

	is3D     = true;
	ReferenceDistance= 20.0;
	MaxDistance= 100.0;
	type     = $EffectAudioType;
};

datablock AudioDescription(AudioClose3d) {
	volume   = 1.0;
	isLooping= false;

	is3D     = true;
	ReferenceDistance= 10.0;
	MaxDistance= 60.0;
	type     = $EffectAudioType;
};

datablock AudioDescription(AudioClosest3d) {
	volume   = 1.0;
	isLooping= false;

	is3D     = true;
	ReferenceDistance= 5.0;
	MaxDistance= 30.0;
	type     = $EffectAudioType;
};


//-----------------------------------------------------------------------------
// Looping sounds

//Unused.
// datablock AudioDescription(AudioDefaultLooping3d) {
// 	volume   = 1.0;
// 	isLooping= true;

// 	is3D     = true;
// 	ReferenceDistance= 20.0;
// 	MaxDistance= 100.0;
// 	type     = $EffectAudioType;
// };


//Unused.
// datablock AudioDescription(AudioCloseLooping3d) {
// 	volume   = 1.0;
// 	isLooping= true;

// 	is3D     = true;
// 	ReferenceDistance= 10.0;
// 	MaxDistance= 50.0;
// 	type     = $EffectAudioType;
// };

datablock AudioDescription(AudioClosestLooping3d) {
	volume   = 1.0;
	isLooping= true;

	is3D     = true;
	ReferenceDistance= 5.0;
	MaxDistance= 30.0;
	type     = $EffectAudioType;
};

datablock AudioDescription(Quieter3D) {
	volume   = 0.40;
	isLooping= false;

	is3D     = true;
	ReferenceDistance= 20.0;
	MaxDistance= 100.0;
	type     = $EffectAudioType;
};

//-----------------------------------------------------------------------------
// 2d sounds
//-----------------------------------------------------------------------------

// Used for non-looping environmental sounds (like power on, power off)
datablock AudioDescription(Audio2D) {
	volume = 1.0;
	isLooping = false;
	is3D = false;
	type = $EffectAudioType;
};

// Used for Looping Environmental Sounds
datablock AudioDescription(AudioLooping2D) {
	volume = 1.0;
	isLooping = true;
	is3D = false;
	type = $EffectAudioType;
};


//-----------------------------------------------------------------------------
// Ready - Set - Get Rolling

// datablock AudioProfile(pickupSfx) {
// 	filename    = "~/data/sound/pickup.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };

datablock AudioProfile(HelpDingSfx) {
	filename    = "~/data/sound/InfoTutorial.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(ReadyVoiceSfx) {
	filename    = "~/data/sound/ready.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(SetVoiceSfx) {
	filename    = "~/data/sound/set.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(GetRollingVoiceSfx) {
	filename    = "~/data/sound/go.wav";
	description = AudioDefault3d;
	preload = true;
};

// datablock AudioProfile(jumpSfx) {
// 	filename    = "~/data/sound/bounce.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };

// datablock AudioProfile(bounceSfx) {
// 	filename    = "~/data/sound/bounce.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };

datablock AudioProfile(blastSfx) {
	filename    = "~/data/sound/blast.wav";
	description = AudioDefault3d;
	preload = true;
};

// datablock AudioProfile(Silence) {
// 	filename    = "~/data/sound/Silence.ogg";
// 	description = AudioClosest3d;
// 	preload = true;
// };

datablock AudioProfile(fireballSizzleSfx) {
	filename    = "~/data/sound/fireballSizzle.wav";
	description = AudioDefault3d;
	preload = true;
};

datablock AudioProfile(bubbleSnuffSfx) {
	filename    = "~/data/sound/bubbleSnuff.wav";
	description = AudioDefault3d;
	preload = true;
};


//-----------------------------------------------------------------------------
// Misc

// datablock AudioProfile(PenaltyVoiceSfx) {
// 	filename    = "~/data/sound/penalty.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };

datablock AudioProfile(OutOfBoundsVoiceSfx) {
	filename    = "~/data/sound/whoosh.wav";
	description = AudioDefault3d;
	preload = true;
};

// datablock AudioProfile(DestroyedVoiceSfx) {
// 	filename    = "~/data/sound/destroyedVoice.wav";
// 	description = AudioDefault3d;
// 	preload = true;
// };
