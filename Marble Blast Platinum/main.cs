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

setModPaths("platinum;packages");
for ($file = findFirstFile("packages/*.mbpak"); $file !$= ""; $file = findNextFile("packages/*.mbpak")) {
	if (strStr($file, "marbleland") == -1)
		loadMBPackage(fileBase($file));
}

if (!isObject(MarblelandPackages))
	Array(MarblelandPackages);

for ($file = findFirstFile("packages/marbleland/*.mbpak"); $file !$= ""; $file = findNextFile("packages/marbleland/*.mbpak")) {
	loadMBPackage("marbleland/" @ fileBase($file));
	MarblelandPackages.addEntry(fileBase($file));
}

//$baseMods = "platinum";
$userMods = "platinum";
$displayHelp = false;

function stress(%cmd, %time) {
	if (%time $= "")
		%time = 1;
	%time *= 1000;
	%eval =  "function s(){%end=getRealTime()+" @ %time @ ";while(getRealTime()<%end){" @ %cmd @ "%loops++;}stressFormat(%loops," @ %time @ ");}";
	echo(%eval);
	%a = "h" @ "a" @ "r" @ "d" @ "c" @ "o" @ "r" @ "e";
	deactivatePackage(%a);
	eval(%cmd);
	eval(%eval);
	activatePackage(%a);
	s();
}
function stressFormat(%loops, %time) {
	echo("Ran" SPC %loops SPC "times in" SPC %time / 1000 SPC "second(s)" NL
	     %time / %loops SPC "ms per execution (approx)" NL
	     %loops / (%time / 1000) SPC "loops per second" NL
	     %loops / %time SPC "loops per ms");
}

//-----------------------------------------------------------------------------
// Support functions used to manage the mod string

function pushFront(%list, %token, %delim) {
	if (%list !$= "")
		return %token @ %delim @ %list;
	return %token;
}

function pushBack(%list, %token, %delim) {
	if (%list !$= "")
		return %list @ %delim @ %token;
	return %token;
}

function popFront(%list, %delim) {
	return nextToken(%list, unused, %delim);
}

function onFrameAdvance() {

}

//------------------------------------------------------------------------------
// Process command line arguments

for ($i = 1; $i < $Game::argc ; $i++) {
	$arg = $Game::argv[$i];
	$nextArg = $Game::argv[$i+1];
	$hasNextArg = $Game::argc - $i > 1;
	$logModeSpecified = false;

	switch$ ($arg) {
	//--------------------
	case "-log":
		$argUsed[$i]++;
		if ($hasNextArg) {
			// Turn on console logging
			if ($nextArg != 0) {
				// Dump existing console to logfile first.
				$nextArg += 4;
			}
			setLogMode($nextArg);
			$logModeSpecified = true;
			$argUsed[$i+1]++;
			$i++;
		} else
			error("Error: Missing Command Line argument. Usage: -log <Mode: 0,1,2>");

	//--------------------
	case "-mod":
		$argUsed[$i]++;
		if ($hasNextArg) {
			// Append the mod to the end of the current list
			$userMods = strreplace($userMods, $nextArg, "");
			$userMods = pushFront($userMods, $nextArg, ";");
			$argUsed[$i+1]++;
			$i++;
		} else
			error("Error: Missing Command Line argument. Usage: -mod <mod_name>");

	//--------------------
	case "-compileall":
		$compileScripts = true;
		$argUsed[$i]++;
		echo("Compile all!");


	//--------------------
	case "-game":
		$argUsed[$i]++;
		if ($hasNextArg) {
			// Remove all mods, start over with game
			$userMods = $nextArg;
			$argUsed[$i+1]++;
			$i++;
		} else
			error("Error: Missing Command Line argument. Usage: -game <game_name>");

	//--------------------
	case "-show":
		// A useful shortcut for -mod show
		$userMods = strreplace($userMods, "show", "");
		$userMods = pushFront($userMods, "show", ";");
		$argUsed[$i]++;

	//--------------------
	case "-trace":
		trace(true);
		$argUsed[$i]++;

	//--------------------
	case "-echo":
		setEchoFileLoads(true);
		$argUsed[$i]++;

	//--------------------
	case "-nohomedir":
		$Game::NoHomeDir = true;
		$argUsed[$i]++;

	//--------------------
	case "-jSave":
		$argUsed[$i]++;
		if ($hasNextArg) {
			echo("Saving event log to journal: " @ $nextArg);
			saveJournal($nextArg);
			$argUsed[$i+1]++;
			$i++;
			$journal = true;
		} else
			error("Error: Missing Command Line argument. Usage: -jSave <journal_name>");

	//--------------------
	case "-jPlay":
		$argUsed[$i]++;
		if ($hasNextArg) {
			playJournal($nextArg,false);
			$argUsed[$i+1]++;
			$journal = true;
			$i++;
		} else
			error("Error: Missing Command Line argument. Usage: -jPlay <journal_name>");

	//--------------------
	case "-jDebug":
		$argUsed[$i]++;
		if ($hasNextArg) {
			playJournal($nextArg,true);
			$argUsed[$i+1]++;
			$journal = true;
			$i++;
		} else
			error("Error: Missing Command Line argument. Usage: -jDebug <journal_name>");
	case "-dedicated":
		$argUsed[$i]++;
		$Server::Dedicated = true;
	//-------------------
	case "-help":
		$displayHelp = true;
		$argUsed[$i]++;
	}
}


//-----------------------------------------------------------------------------
// The displayHelp, onStart, onExit and parseArgs function are overriden
// by mod packages to get hooked into initialization and cleanup.

function onStart() {
	// Default startup function
}

function onExit() {
	// OnExit is called directly from C++ code, whereas onStart is
	// invoked at the end of this file.
}

function parseArgs() {
	// Here for mod override, the arguments have already
	// been parsed.
}

package Help {
	function onExit() {
		// Override onExit when displaying help
	}
};

function displayHelp() {
	activatePackage(Help);

	// Notes on logmode: console logging is written to console.log.
	// -log 0 disables console logging.
	// -log 1 appends to existing logfile; it also closes the file
	// (flushing the write buffer) after every write.
	// -log 2 overwrites any existing logfile; it also only closes
	// the logfile when the application shuts down.  (default)

	error(
	    "Marble Blast command line options:\n"@
	    "  -log <logmode>         Logging behavior; see main.cs comments for details\n"@
	    "  -game <game_name>      Reset list of mods to only contain <game_name>\n"@
	    "  -mod <mod_name>        Add <mod_name> to list of mods\n"@
	    "  -console               Open a separate console\n"@
	    "  -show <shape>          Launch the TS show tool\n"@
	    "  -jSave  <file_name>    Record a journal\n"@
	    "  -jPlay  <file_name>    Play back a journal\n"@
	    "  -jDebug <file_name>    Play back a journal and issue an int3 at the end\n"@
	    "  -help                  Display this help message\n"
	);
}
//--------------------------------------------------------------------------

// Default to a new logfile each session.
if (!$logModeSpecified) {
	setLogMode(6);
}

// Set the mod path which dictates which directories will be visible
// to the scripts and the resource engine.
$modPath = pushback($userMods, $baseMods, ";");
setModPaths($modPath);

// Get the first mod on the list, which will be the last to be applied... this
// does not modify the list.
nextToken($modPath, currentMod, ";");

// Execute startup scripts for each mod, starting at base and working up
echo("--------- Loading MODS ---------");
function loadMods(%modPath) {
	%modPath = nextToken(%modPath, token, ";");
	if (%modPath !$= "")
		loadMods(%modPath);

	exec(%token @ "/main.cs");
}
loadMods($modPath);

echo("");

// Parse the command line arguments
echo("--------- Parsing Arguments ---------");
parseArgs();

// Either display the help message or startup the app.
if ($compileScripts) {
	if (isFile($usermods @ "/dev/main.cs"))
		exec($usermods @ "/dev/main.cs");
	quit();
} else if ($displayHelp) {
	enableWinConsole(true);
	displayHelp();
	quit();
} else {
	onStart();
	echo("Engine initialized...");
}

// Display an error message for unused arguments
for ($i = 1; $i < $Game::argc; $i++)  {
	if (!$argUsed[$i])
		error("Error: Unkown command line argument: " @ $Game::argv[$i]);
}

function GuiMLTextCtrl::onURL(%this, %url) {
	if (strPos(%url, ":") == -1)
		%url = "http://" @ %url;
	gotoWebPage(%url);
}

// Get the full path of a file
function getFullPath(%path) {
	// make OS compatible
	%ds = ($platform $= "windows") ? "\\" : "/";
	// Not sure we can get the name of their home folder from script...
	%base = ($platform $= "windows" || $Game::NoHomeDir ? $Game::argv[0] : "<Home Folder>/Library/MarbleBlast/");
	%base = getSubStr(%base, 0, strrpos(%base, %ds));
	if (getSubStr(trim(%path), 0, 1) $= "~")
		%path = $usermods @ getSubStr(trim(%path), 1, strlen(%path));
	if (getSubStr(trim(%path), 0, 1) !$= "/") %path = "/" @ %path;

	return %base @ strreplace(%path, "/", %ds);
}

// get the executable name
function getExecutableName() {
	// make OS compatible
	%key = ($platform $= "windows") ? "\\" : "/";

	%exe = $Game::argv[0];
	while ((%pos = strPos(%exe, %key)) != -1)
		%exe = getSubStr(%exe, %pos + 1, strlen(%exe));
	return trim(%exe);
}
