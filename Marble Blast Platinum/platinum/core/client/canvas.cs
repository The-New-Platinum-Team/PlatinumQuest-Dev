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
// Function to construct and initialize the default canvas window
// used by the games

function initCanvas(%windowName) {
	//videoSetGammaCorrection($pref::OpenGL::gammaCorrection);
	if (!createCanvas(%windowName)) {
		quit();
		return;
	}
	setWindowTitle(%windowName);

	setOpenGLTextureCompressionHint($pref::OpenGL::compressionHint);
	setOpenGLAnisotropy($pref::OpenGL::anisotropy);
	setOpenGLMipReduction($pref::OpenGL::mipReduction);
	setOpenGLInteriorMipReduction($pref::OpenGL::interiorMipReduction);
	setOpenGLSkyMipReduction($pref::OpenGL::skyMipReduction);

	//Dump graphics info
	echo("Graphics init: Supported extensions:");
	%extensions = glGetExtensions();
	%count = getWordCount(%extensions);
	for (%i = 0; %i < %count; %i ++) {
		echo(getWord(%extensions, %i));
	}
	checkSupportedExtensions();

	//Check the graphics prefs before we try to do anything that could blow them up
	applyGraphicsQuality();

	// Declare default GUI Profiles.
	exec("~/core/ui/defaultProfiles.cs");
	exec("~/core/ui/pqProfiles.cs");

	// 100% more PQ
	exec("~/core/ui/misc.cs");
	exec("./controls/controls.cs");

	initControls();

	// Common GUI's
	exec("~/core/ui/GuiEditorGui.gui");
	exec("~/core/ui/ConsoleDlg.gui");
	exec("~/core/ui/InspectDlg.gui");
	exec("~/core/ui/LoadFileDlg.gui");
	exec("~/core/ui/SaveFileDlg.gui");
	exec("~/core/ui/MessageBoxOKDlg.gui");
	exec("~/core/ui/MessageBoxYesNoDlg.gui");

	// Commonly used helper scripts
	exec("./metrics.cs");
	exec("./messagebox.cs");
	exec("./screenshot.cs");
	exec("./cursor.cs");
	exec("./debugView.cs");

	// Init the audio system
	OpenALInit();
}

function resetCanvas() {
	//Unused but called
}

function checkGraphicsQuality() {
	//Some checks so we don't crash
	echo("Checking graphics quality...");
	if ($pref::Video::InteriorShaderQuality >= 0 && !canSupportShaders()) {
		$pref::Video::InteriorShaderQuality = -1;
		warn("Graphics cannot support interior shaders");
	}
	if ($pref::Video::PostProcessing >= 0 && !canSupportPostFX()) {
		$pref::Video::PostProcessing = 0;
		$pref::Video::MarbleReflectionQuality = 0;
		warn("Graphics cannot support post processing");
		warn("Graphics cannot support marble shaders");
	}
	if ($pref::Video::AntiAliasing >= 0 && !canSupportAntiAliasing()) {
		$pref::Video::AntiAliasing = 0;
		warn("Graphics cannot support anti aliasing");
	}
}

function checkSupportedExtensions() {
	%info = getVideoDriverInfo();
	$Video::OpenGLVersion = getWord(getField(%info, 2), 0);

	// if ($Video::OpenGLVersion < 2) {
	// 	//OpenGL 1.x support is a very bad thing
	// 	error("OpenGL " @ $Video::OpenGLVersion @ " detected! This means either your graphics card is not detected or it's so old it doesn't support OpenGL 2.");
	// 	error("In either case, there is no way PQ will be able to run. Make sure your drivers are up to date and your card was made after 2006.");

	// 	//This will kill nearly everything custom GL we do. I don't think it's enough though.
	// 	disableGraphicsExtender();
	// 	return;
	// }

	//GL_EXTENSIONS lies, so we have to check for texture arrays by creating a shader that uses them and
	// seeing if that fails to compile.
	$Video::SupportsExtension["GL_EXT_texture_array"] = true; // glTestExtension("GL_EXT_texture_array");
	//Can't actually use framebuffer_object in a shader so this is how we check
	$Video::SupportsExtension["GL_ARB_framebuffer_object"] = true; // findWord(glGetExtensions(), "GL_ARB_framebuffer_object") != -1;
}

function applyGraphicsQuality() {
	if ($Server::Dedicated) {
		//Stop
		disableShaders();
		//What are you doing
		disablePostFX();
		//Why are you trying to get shaders on a dedicated server
		disableInteriorRenderBuffers();
		//It wouldn't even do anything
		return;
	}

	checkGraphicsQuality();

	echo("Graphics Capabilities:");
	echo("   Can support shaders: " @ canSupportShaders());
	echo("   Can support postFX: " @ canSupportPostFX());
	echo("   Can support anti aliasing: " @ canSupportAntiAliasing());
	echo("Graphics Settings:");
	echo("   Interior Shader Quality: " @ $pref::Video::InteriorShaderQuality);
	echo("   Marble Reflection Quality: " @ $pref::Video::MarbleReflectionQuality);
	echo("   Anti Aliasing: " @ $pref::Video::AntiAliasing);
	echo("   Post Processing: " @ $pref::Video::PostProcessing);

	if ($pref::Video::InteriorShaderQuality == -1) {
		disableShaders();
	} else {
		enableShaders();
		reloadShaders();
		reloadGlowShaders();
	}

	if ($pref::Video::PostProcessing) {
		enablePostFX();
		enableBlur();
		updatePostFX();
	} else {
		disablePostFX();
		disableBlur();
	}

	// Always use 1.0 for detail quality.
	$pref::TS::detailAdjust = 1.0;

	setParticleMaxDistance($pref::Video::ParticleMaxDistance);
}

function updatePostFX() {
	if (!canSupportPostFX()) {
		return;
	}

	//Set current postFX shader
	%shaderV = $pref::Video::defaultPostFXShaderV;
	%shaderF = $pref::Video::defaultPostFXShaderF;

	if (MissionInfo.postFXShaderV !$= "" && isFile(MissionInfo.postFXShaderV)) {
		%shaderV = MissionInfo.postFXShaderV;
	}
	if (MissionInfo.postFXShaderF !$= "" && isFile(MissionInfo.postFXShaderF)) {
		%shaderF = MissionInfo.postFXShaderF;
	}

	if ($TexturePack::PostFX::ShaderV !$= "" && isFile($TexturePack::PostFX::ShaderV)) {
		%shaderV = $TexturePack::PostFX::ShaderV;
	}
	if ($TexturePack::PostFX::ShaderF !$= "" && isFile($TexturePack::PostFX::ShaderF)) {
		%shaderF = $TexturePack::PostFX::ShaderF;
	}

	if (!isFile(%shaderV)) {
		%shaderV = "platinum/data/shaders/postfxV.glsl";
	}
	if (!isFile(%shaderF)) {
		%shaderF = "platinum/data/shaders/postfxF.glsl";
	}

	setPostFXShader(%shaderV, %shaderF);
}

function updateFrameController() {
	if ($pref::Video::MaxFPS $= "")
		$pref::Video::MaxFPS = -1;

	// Unlimited.
	switch ($pref::Video::MaxFPS) {
	case -1: //Unlimited
		setTickInterval(1);
	case 0: //Vsync
		setVerticalSync(true);
	default: //Manual
		setMaxFPS($pref::Video::MaxFPS);
	}

	if ($pref::Video::renderPriority $= "")
		$pref::Video::renderPriority = 0;
	
	switch ($pref::Video::renderPriority) {
		case 0: // Vsync
			setVerticalSync(true);
			$pref::prioritizeRender = false;
		case 1:
			setVerticalSync(false);
			$pref::prioritizeRender = false;
		case 2:
			setVerticalSync(false);
			$pref::prioritizeRender = true;
	}
}


function disableBlur() {
	if (!canSupportPostFX()) {
		return;
	}

	unloadBlur();
}

function enableBlur() {
	if (!canSupportPostFX()) {
		return;
	}

	if (isFullScreen()) {
		%res = $pref::Video::resolution;
	} else {
		%res = $pref::Video::windowedRes;
	}
	blurInit(%res, $pref::Video::BlurPasses, "platinum/data/shaders/blurV.glsl", "platinum/data/shaders/blurF.glsl");

	//Hack-- update menu blurs if we've reset over the framebuffer
	if (RootGui.previewImage) {
		copyBlurImage(PM_MissionImage.bitmap);
	}
}

function reloadBlur() {
	disableBlur();
	enableBlur();
}

function canSupportShaders() {
	return true;
}

function canSupportPostFX() {
	return true;
}

function canSupportAntiAliasing() {
	return false; // Rip
}
