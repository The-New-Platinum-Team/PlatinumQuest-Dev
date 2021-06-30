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

// The master server is declared with the server defaults, which is
// loaded on both clients & dedicated servers.  If the server mod
// is not loaded on a client, then the master must be defined.
$pref::Master[0] = $LBServerInfo::mpMasterServer;

// Stuff ported and organised to reflect PQ, some stuff modified.

$pref::Player::Name = "Platinum Player";
$pref::Player::defaultFov = 90;
$pref::Player::zoomSpeed = 0;
$pref::Thousandths = 1;
$pref::alwaysshowspeedometer = 0;
$pref::showFPSCounter = 0;
$pref::environmentMaps = 0;
$pref::HelpTriggers = 1;
$pref::ScreenshotMode = 0;

$pref::checkLETip = "1";
$pref::checkTip[1] = "1";
$pref::FirstRun[$THIS_VERSION] = true;
$pref::ShowOOBMessages = false;

$Pref::Net::LagThreshold = "400";
$pref::Net::PacketRateToClient = "32";
$pref::Net::PacketRateToServer = "32";
$pref::Net::PacketSize = "400";

$pref::shadows = "0";
$pref::HudMessageLogSize = 40;
$pref::ChatHudLength = 1;
$pref::useStencilShadows = 0;

$pref::Input::LinkMouseSensitivity = 1;
// Direct Input keyboard, mouse, and joystick prefs
$pref::Input::KeyboardEnabled = 1;
$pref::Input::MouseEnabled = 1;
$pref::Input::JoystickEnabled = 0;

$pref::Input::KeyboardTurnSpeed = 0.05;
$pref::Input::MouseSensitivity = 0.50;
$pref::Input::InvertYAxis = 0;
$pref::Input::AlwaysFreeLook = 1;
$pref::Input::ControlDevice = "keyboard";

$pref::Input::Joystick::RightStickMovement = false;
$pref::Input::Joystick::CameraSpeedX = 0.029;
$pref::Input::Joystick::CameraSpeedY = 0.029;
$pref::Input::Joystick::DeadZone = 0.23;

$pref::Interior::TexturedFog = 0;
$pref::Interior::SmoothShading = 1;

$pref::OpenGL::force16BitTexture = "0";
$pref::OpenGL::forcePalettedTexture = "0";
$pref::OpenGL::maxHardwareLights = 3;
$pref::OpenGL::textureTrilinear = "1"; // I don't think this works unless you enter it in console... and then it resets itself when you quit MB.
$pref::VisibleDistanceMod = 1.0;

$pref::Audio::driver = "OpenAL";
$pref::Audio::forceMaxDistanceUpdate = 0;
$pref::Audio::environmentEnabled = 0;
$pref::Audio::masterVolume   = 1.0;
$pref::Audio::channelVolume1 = 0.65;
$pref::Audio::channelVolume2 = 0.5;
$pref::Audio::channelVolume3 = 0.65;
$pref::Audio::channelVolume4 = 0.5;
$pref::Audio::channelVolume5 = 0.5;
$pref::Audio::channelVolume6 = 0.5;
$pref::Audio::channelVolume7 = 0.5;
$pref::Audio::channelVolume8 = 0.5;
$pref::OOBVoice = 1;
$pref::Audio::AudioPack = "";

$Pref::EnableDirectInput = true;
$Pref::Unix::OpenALFrequency = 44100;

$pref::CannonAimIterations = 125;
$pref::CannonAimPrecision = 0.01;
$pref::CannonAimIterationsFast = 24;
$pref::CannonAimPrecisionFast = 0.1;

//LBPrefs

$LBPref::Server = 0;
$LBPref::MaxChatLines = 1000;
$LBPref::GlobalPageSize = 5;
$LBPref::ChatMessageSize = 6;
$pref::SSL::VerifyPeer = 1;
$LBPref::ShowRecords = false;

$pref::Music::Songs["LB"]     = "Comforting Mystery.ogg";
$pref::Music::Songs["Menu"]   = "Pianoforte.ogg";
$pref::Music::Songs["Game"]   = "*";

//Graphics
$pref::Snore = true;
$pref::AnimatePreviews = true;
$pref::LegacyItems = false;
$pref::ProfanityFilter = 2;
$pref::DefaultSkybox = "platinum/data/skies_pq/Blender3/blender3.dml";
$pref::FastMode = false;

//Video quality
$pref::Video::AntiAliasing = 0;
$pref::Video::BlurPasses = 4;
$pref::Video::InteriorShaderQuality = 2;
$pref::Video::ParticleMaxDistance = 50;
$pref::Video::ParticlesPercent = 1;
$pref::Video::PostProcessing = 1;
$pref::Video::TextureQuality = 2;
//Marble reflection settings
$pref::Video::MarbleReflectionQuality = 1;
$pref::Video::MarbleCubemapExtent = 64;
$pref::Video::MarbleReflectionFramesPerRender = 2;
$pref::Video::MaxReflectedMarbles = 1;
$pref::Video::MarbleReflectionQualityOthers = 0;
$pref::Video::MarbleCubemapExtentOthers = 32;
$pref::Video::MarbleReflectionFramesPerRenderOthers = 6;
//Video general
$pref::Video::displayDevice = "OpenGL"; //D3D isn't even supported anymore
$pref::Video::fullScreen = 0;
$pref::Video::resolution = "1280 720 32";
$pref::Video::windowedRes = "1280 720";
//Vsync by default because apparently it's choppy otherwise?
$pref::Video::disableVerticalSync = false;
$pref::Video::MaxFPS = 0;
//Video core
$pref::Video::allowD3D = 0; //Nope
$pref::Video::allowOpenGL = 1;
$pref::Video::appliedPref = 0;
$pref::Video::monitorNum = 0;
$pref::Video::preferOpenGL = 1;
//Post effects, customizable
$pref::Video::defaultPostFXShaderV = "platinum/data/shaders/postfxV.glsl";
$pref::Video::defaultPostFXShaderF = "platinum/data/shaders/postfxF.glsl";
//Texture packs
$pref::Video::TexturePack[0] = "default";
