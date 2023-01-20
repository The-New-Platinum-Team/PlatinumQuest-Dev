//-----------------------------------------------------------------------------
// support.cs
//
// Copyright (c) 2013 The Platinum Team
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

// destroysTorqueML torqueML from a string, so that we can't have nuttcases
// using differnt colors in the chat and stuff :)
function destroyTorqueML(%string) {
	%finish = "";
	for (%i = 0; %i < strlen(%string); %i ++) {
		%subStr = getSubStr(%string,%i,1);
		// will goof up torqueML and embarass the user
		if (%subStr $= "<")
			%subStr = "<<spush><spop>";
		%finish = (%finish $= "") ? %subStr : %finish @ %subStr;
	}
	return %finish;
}

// check to see if a person is a guest
function isGuest(%user) {
	return (strStr(%user, "Guest_") != -1);
}

function GameConnection::isGuest(%this) {
	return isGuest(%this.getUsername());
}

// convert number to string for status
function LBResolveStatus(%status) {
	if ($LB::FoundStatus[%status])
		return $LB::Status[%status];
	else
		return "(Unknown)";
}

function LBColorFormat(%username, %display, %access) {
//	echo("Chat coloring for" SPC %username);
	%color = LBChatColor(%username);
	if (%color $= "") {
//		echo("Could not find a color");
		switch (%access) {
		case -3: %color = LBChatColor("normal");
		case 0:  %color = LBChatColor("normal");
		case 1:  %color = LBChatColor("mod");
		case 2:  %color = LBChatColor("admin");
		default: %color = LBChatColor("normal");
		}
	}
	%display = "<spush>" @ %color @ %display @ "<spop>";
	return %display;
}

function LBAccountType(%access) {
	switch (%access) {
	case -3: return "Banned";
	case 0:  return "User";
	case 1:  return "Moderator";
	case 2:  return "Administrator";
	case 3:  return "Guest";
	default: return "User";
	}
}

function LBSpecialColor(%number, %alt) {
	if (%number == 1)
		%color = "<color:DAA520><shadow:1:1><shadowcolor:0000007f>";
	else if (%number == 2)
		%color = "<color:E3E4E5><shadow:1:1><shadowcolor:0000007f>";
	else if (%number == 3)
		%color = "<color:A67B3D><shadow:1:1><shadowcolor:0000007f>";
	else if (%number <= 5 && %alt)
		%color = "";
	return %color;
}

function decodeName(%name) {
	%name = strReplace(%name, "-TAB-", "\t");
	%name = strReplace(%name, "-NL-", "\n");
	%name = strReplace(%name, "-SPC-", " ");
	return %name;
}

function encodeName(%name) {
	%name = strReplace(%name, " ", "-SPC-");
	%name = strReplace(%name, "\n", "-NL-");
	%name = strReplace(%name, "\t", "-TAB-");
	return %name;
}

function mRound(%num, %places) {
	%mult = mPow(10, (%places $= "" ? 0 : %places));
	%num *= %mult;
	if (%num < 0) {
		%mult *= -1;
		%num *= -1;
	}
	if ((%num * 2) % 2) return mCeil(%num) / %mult;
	else return mFloor(%num) / %mult;
}

//-----------------------------------------------------------------------------
// String encryption / decryption
// Don't ask, I'm not willing to explain it.
//-----------------------------------------------------------------------------

function strEnc(%string, %method) {
	%start = getRealTime();
	%table = "abcdefghijklmnopqrstuvwxyzABCDEFGHJIKLMNOPQRSTUVWXYZ1234567890 -=_+`~[]{}\\|;:\'\",.<>/?()*&^%$#@!";
	setRandomSeed(getRealTime());
	%seed = getRandom(getRealTime());
	while (%seed < 100000)
		%seed *= 9;
	while (%seed > 100000)
		%seed /= 9;
	%seed = mFloor(%seed);
	if (%seed == 100000)
		%seed --;
	%tableSc = strScr(%table, %seed, (%method == 0 ? 5 : 15));
	%finished = strLet(%seed);
	for (%i = 0; %i < strLen(%string); %i ++) {
//      devecho("TABLESC IS" SPC %tableSc);
		%char = getSubStr(%string, %i, 1);
		%pos = strPos(%tableSc, %char);
		if (%pos == -1)
			%char2 = %char;
		else
			%char2 = getSubStr(%table, %pos, 1);
		%finished = %finished @ %char2;
		if (%method == 2)
			%tableSc = getSubStr(%tableSc, 7, strlen(%tableSc)) @ getSubStr(%tableSc, 0, 7);
	}
	return %finished;
}

function strDec(%string, %method) {
	%table = "abcdefghijklmnopqrstuvwxyzABCDEFGHJIKLMNOPQRSTUVWXYZ1234567890 -=_+`~[]{}\\|;:\'\",.<>/?()*&^%$#@!";
	%seed = strNum(getSubStr(%string, 0, 5));
	%tableSc = strScr(%table, %seed, (%method == 0 ? 5 : 15));
	%string = getSubStr(%string, 5, strLen(%string));
	%finished = "";
	for (%i = 0; %i < strLen(%string); %i ++) {
//      devecho("TABLESC IS" SPC %tableSc);
		%char = getSubStr(%string, %i, 1);
		%pos = strPos(%table, %char);
		if (%pos == -1)
			%char2 = %char;
		else
			%char2 = getSubStr(%tableSc, %pos, 1);
		%finished = %finished @ %char2;
		if (%method == 2)
			%tableSc = getSubStr(%tableSc, 7, strlen(%tableSc)) @ getSubStr(%tableSc, 0, 7);
	}
	return %finished;
}

function strScr(%string, %seed, %count) {
	%oldSeed = getRandomSeed();
	if (%seed)
		setRandomSeed(%seed);
	for (%i = 0; %i < strLen(%string) * %count; %i ++) {
		%pos = getRandom(strLen(%string));
		%pos2 = getRandom(strLen(%string));
		%char = getSubStr(%string, %pos, 1);
		%before = getSubStr(%string, 0, %pos);
		%after = getSubStr(%string, %pos + 1, strLen(%string));
		%string = %before @ %after;
		%before = getSubStr(%string, 0, %pos2);
		%after = getSubStr(%string, %pos2, strLen(%string));
		%string = %before @ %char @ %after;
	}
	setRandomSeed(%oldSeed);
	return %string;
}

function strLet(%number) {
	%let = "abcdefghij";
	%fin = "";
	for (%i = 0; %i < strLen(%number); %i ++) {
		%char = getSubStr(%number, %i, 1);
		%char2 = getSubStr(%let, %char, 1);
		%fin = %fin @ %char2;
	}
	return %fin;
}

function strNum(%string) {
	%let = "abcdefghij";
	%fin = "";
	for (%i = 0; %i < strLen(%string); %i ++) {
		%char = getSubStr(%string, %i, 1);
		%pos = strPos(%let, %char);
		%fin = %fin @ %pos;
	}
	return %fin;
}

//-----------------------------------------------------------------------------

// Weak "encrypts" a string so it can't be seen in clear-text
function garbledeguck(%string) {
	%finish = "";
	for (%i = 0; %i < strlen(%string); %i ++) {
		%char = getSubStr(%string, %i, 1);
		%val = chrValue(%char);
		%val = 128 - %val;
		%hex = dec2hex(%val, 2);
		%finish = %hex @ %finish; //Why not?
	}
	return "gdg" @ %finish;
}

function deGarbledeguck(%string) {
	if (getSubStr(%string, 0, 3) !$= "gdg")
		return %string;
	%finish = "";
	for (%i = 3; %i < strLen(%string); %i += 2) {
		%hex = getSubStr(%string, %i, 2);
		%val = hex2dec(%hex);
		%char = chrForValue(128 - %val);
		%finish = %char @ %finish;
	}
	return %finish;
}

function strRepeat(%string, %times) {
	if (%times < 1)
		return;
	%ret = %string;
	for (%i = 1; %i < %times; %i ++)
		%ret = %ret @ %string;
	return %ret;
}

function fwrite(%file, %text) {
	if (!isObject($_fwriteo))
		RootGroup.add($_fwriteo = new FileObject(fwrite_fo));

	if (!$_fwriteo.openForWrite(%file)) {
		$_fwriteo.close();
		return false;
	}
	%text = strReplace(%text, "\n", "\r\n"); //Add carriage returns
	$_fwriteo.writeBase64(base64encode(%text));
	$_fwriteo.close();
	return true;
}

function fread(%file) {
	if (!isObject($_freado))
		RootGroup.add($_freado = new FileObject(fread_fo));
	if (!$_freado.openForRead(%file)) {
		$_freado.close();
		return "";
	}
	%ret = base64decode($_freado.readBase64());
	%ret = strReplace(%ret, "\r\n", "\n"); //Strip carriage returns
	$_freado.close();
	return %ret;
}

function safeExecPrefs(%file) {
	%conts = fread(%file);
	%records = getRecordCount(%conts);
	for (%i = 0; %i < %records; %i ++) {
		%line = getRecord(%conts, %i);
		// Evaluate each line:
		// $variable = value;
		//
		// Now, this can be easily exploited if someone knows how.
		// That's why I've come up with this method that makes it virtually
		// impossible to hack. Read on and find out!

		// Step 0: Cut out comments and ignore blank lines

		// Clip off anything after //
		if (strPos(%line, "//") != -1)
			%line = getSubStr(%line, 0, strPos(%line, "//"));

		// Why would we evaluate this line anyway?
		if (trim(%line) $= "")
			continue;

		%line = trim(%line);

		// Step 1: Make sure the line is valid

		// Must have a "$" at the start
		if (strPos(%line, "$") != 0)
			continue;

		// Must have a ";" at the end
		if (strPos(%line, ";") != strLen(%line) - 1)
			continue;

		// Must have an "=" sign
		if (strPos(%line, "=") == -1)
			continue;

		// Now we've verified that it is probably a prefs line. How can we
		// be sure they haven't done this though: "$foo = bar; hax();"?

		// Step 2: Splitting it into parts

		%nameEnd = strPos(%line, "=");
		if (%nameEnd == -1)
			continue;

		while (getSubStr(%line, %nameEnd - 1, 1) $= " ")
			%nameEnd --;

		%name = getSubStr(%line, 1, %nameEnd - 1);

		%varStart = strPos(%line, "=") + 1;
		while (getSubStr(%line, %varStart, 1) $= " ")
			%varStart ++;

		%var = getSubStr(%line, %varStart, strlen(%line));
		%var = getSubStr(%var, 0, strlen(%var) - 1);

		//echo("Name: \"" @ %name @ "\" Var: \"" @ %var @ "\"");

		// Part 3: Fixing the parts

		%name = stripNot(%name, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890:[]");
		if (getSubStr(%var, 0, 1) $= "\"")
			%var = getSubStr(%var, 1, strlen(%var) - 2);
		%var = "\"" @ expandEscape(%var) @ "\"";

		// Evaluate the bits

//      devecho("eval: $" @ %name @ " = " @ %var @ ";");
//      devecho("eval: $" @ %name @ " = " @ "collapseEscape($" @ %name @ ");");
		eval("$" @ %name @ " = " @ %var @ ";");
		eval("$" @ %name @ " = " @ "collapseEscape($" @ %name @ ");");
	}
}

function dumpObject(%obj, %format) {
	if (%obj $= "RootGroup") //just no.
		return "";
	if (!isObject(%obj))
		return "";
	%ret = "new" SPC %obj.getClassName() @ "(" @ %obj.getName() @ ") {";

	%fields = %obj.getFieldList();
	%count = getFieldCount(%fields);

	//Get each field...
	for (%i = 0; %i < %count; %i ++) {
		%field = getField(%fields, %i);
		%value = %obj.getFieldValue(%field);
		if (%value !$= "" && %value !$= "<NULL>")
			%ret = (%format ? %ret NL expandEscape(%field) : %ret @ expandEscape(%field)) @ (%format == 2 ? ":" : " = \"") @ expandEscape(%value) @ (%format == 2 ? "" : "\";");
	}
	%ret = (%format ? %ret NL "};" : %ret @ "};");
	if (%format == 3)
		devecho(%ret);
	return %ret;
}


function LBResolveName(%name, %notitle) {
	if (!$LB::LoggedIn) {
		//Not online, still want to get their name though (they could've been disconnected in a server)
		%name = decodeName(%name);
		if (%name $= $LB::Username && $LB::DisplayName !$= "") {
			return $LB::DisplayName;
		} else {
			return %name;
		}
	}

	%name = decodeName(%name);

	//Get their user info from the list
	%entry = LBUserListArray.getEntryByVariable("username", %name);
	if (!isObject(%entry)) {
		if (%name $= $LB::Username && $LB::DisplayName !$= "") {
			return $LB::DisplayName;
		}
		return %name;
	}

	%name = %entry.display;

	//Pre+Suf
	if (%entry.prefix !$= "" && !%notitle)
		%name = %entry.prefix SPC %name;
	if (%entry.suffix !$= "" && !%notitle)
		%name = %name SPC %entry.suffix;

	//Flair is added to the front, in front of prefix
	if (%entry.flair !$= "" && !%notitle)
		%name = "<bitmap:" @ $usermods @ "/client/ui/lb/chat/flair/" @ %entry.flair @ ".png>" SPC %name;
	return %name;
}

// chat color reference guide
// <color:000000> - User / normal text
// <color:0000CC> - Mod
// <color:CC0000> - Admin
// <color:FFCC33> - Whisper
// <color:CC9900> - Notification
// <color:669900> - welcome message

//-----------------------------------------------------------------------------
// New colors system allows for having the same text be different colors
// on different interfaces. Basic usage of the system is as follows:
//
// Defining a color:
//    LBRegisterChatColor("Test Color", "00ccff", "00ccff", "ffccff");
// Args are:
//    Color Name, LBChat Color, In-Game Color, MPPlayMission Color
//
// Referencing a color:
//    LBChatColor("Test Color")
// Args are:
//    Color Name
// Returns:
//    Color Code (e.g. \x14\x1A)
//
// Resolving color codes for displaying text:
//    LBResolveChatColors(<block of text>, "chat");
// Args are:
//    Text to Resolve, Color Location (e.g. "chat" or "ingame")
//

$LBChatColors = 0;

//Fix any malformed colors and put them into something that torque recognizes
function fixColor(%color) {
	%len = strlen(%color);
	if (%len >= 6) {
		// abcdefgh -> abcdef
		%color = getSubStr(%color, 0, 6);
		%len = 6;
	}
	%old = %color;
	%color = "";
	for (%i = 0; %i < %len; %i ++) {
		%char = getSubStr(%old, %i, 1);
		if (strpos("0123456789abcdefABCDEF", %char) == -1) {
			%char = 0;
		}
		%color = %color @ %char;
	}
	if (%len == 6) {
		return %color;
	}
	if (%len <= 3) {
		// ab -> ab0
		%color = %color @ strRepeat("0", 3 - %len);

		// abc -> aabbcc
		return
			getSubStr(%color, 0, 1) @
			getSubStr(%color, 0, 1) @
			getSubStr(%color, 1, 1) @
			getSubStr(%color, 1, 1) @
			getSubStr(%color, 2, 1) @
			getSubStr(%color, 2, 1);
	}
	// abcde -> abcde0
	return %color @ strRepeat("0", 6 - %len);
}

function LBRegisterChatColor(%name, %chat, %ingame, %mp, %isUser) {
	%chat   = fixColor(%chat);
	%ingame = fixColor(%ingame);
	%mp     = fixColor(%mp);

	if (%isUser) {
		if ($TexturePack::InvertTextColors) {
			if (strlwr(%chat) !$= "ffffff")
				%chat = invertColor(%chat);
		}
	}

	if ($LBChatColor[%name] !$= "") {
		$LBChatColor[$LBChatColor[%name], "chat"]   = "<color:" @ %chat @ ">";
		$LBChatColor[$LBChatColor[%name], "ingame"] = "<color:" @ %ingame @ ">";
		$LBChatColor[$LBChatColor[%name], "mp"]     = "<color:" @ %mp @ ">";

		return $LBChatColor[$LBChatColor[%name], "replace"];
	}

	%num = $LBChatColors;
	$LBChatColor[%name] = %num;
	$LBChatColor[%num, "name"]   = %name;
	$LBChatColor[%num, "chat"]   = "<color:" @ %chat @ ">";
	$LBChatColor[%num, "ingame"] = "<color:" @ %ingame @ ">";
	$LBChatColor[%num, "mp"]     = "<color:" @ %mp @ ">";
	%short = "";
//   devecho("Num is" SPC %num);
	while (%num >= 0) {
		//\\x12 - \\x1F are free
		%mod = min(%num, 13);
//      devecho("Mod is" SPC %mod);
		%char = collapseEscape("\\x" @ dec2hex(%mod + 18));
		%num -= 13;
		%short = %short @ %char;
	}
//	devecho("Registering chat color:" SPC %name SPC "(" @ expandEscape(%short) @ ")");
	$LBChatColor[$LBChatColors, "replace"] = %short;
	$LBChatColors ++;

	return %short;
}

function LBChatColor(%name) {
	return $LBChatColor[$LBChatColor[%name], "replace"];
}

function LBResolveChatColors(%str, %type) {
	for (%i = $LBChatColors - 1; %i >= 0; %i --)
		%str = strReplace(%str, $LBChatColor[%i, "replace"], $LBChatColor[%i, %type]);

	return %str;
}

function LBTestChatColors() {
	for (%i = 0; %i < $LBChatColors; %i ++)
		addLBChatLine(LBChatColor($LBChatColor[%i, "name"]) @ "Color" SPC %i @ ":" SPC upperFirst($LBChatColor[%i, "name"]));
}

// Default colors, change them if wanted

//                                    chat     ingame      mp
LBRegisterChatColor("normal",       "000000", "000000", "000000");
LBRegisterChatColor("mod",          "0000CC", "0000CC", "000099");
LBRegisterChatColor("admin",        "CC0000", "CC0000", "990000");
LBRegisterChatColor("whisperfrom",  "999999", "999999", "CCCCCC");
LBRegisterChatColor("whispermsg",   "804300", "804300", "FFCC33");
LBRegisterChatColor("notification", "CC9900", "CC9900", "FFEE99");
LBRegisterChatColor("welcome",      "669900", "669900", "99FF99");
LBRegisterChatColor("help",         "669900", "669900", "99FF99");
LBRegisterChatColor("lagout",       "FF0000", "FF0000", "FF6666");
LBRegisterChatColor("usage",        "999999", "999999", "CCCCCC");
LBRegisterChatColor("server",       "0000FF", "0000FF", "000099");
LBRegisterChatColor("me",           "8000FF", "8000FF", "8000FF");
LBRegisterChatColor("visible",      "009900", "009900", "66FF66");
LBRegisterChatColor("invisible",    "999999", "999999", "CCCCCC");
LBRegisterChatColor("record",       "009900", "003300", "AAFFAA");
LBRegisterChatColor("tasks",        "6699FF", "6699FF", "6699FF");
LBRegisterChatColor("greentext",    "789922", "567711", "CCDD88");

//-----------------------------------------------------------------------------

if (!isObject(BadWords)) {
	Array(BadWords);
}

function filterBadWords(%message) {
	%count = BadWords.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%stuff = BadWords.getEntry(%i);
		%whole = getField(%stuff, 0);
		%bad = getField(%stuff, 1);
		%len = strlen(%bad);
		%replacement = "***"; //Or something fancy if you want?

		%pos = stripos(%message, %bad);
		while (%pos != -1) {
			%replace = true;

			if (%whole) {
				if (%replace && %pos > 0) {
					%before = getSubStr(%message, %pos - 1, 1);
					if (strpos("abcdefghijklmnopqrstuvwxyzABCDEFGHJIKLMNOPQRSTUVWXYZ1234567890", %before) != -1) {
						//Part of another word
						%replace = false;
					}
				}
				if (%replace && %pos + %len < strlen(%message)) {
					%after = getSubStr(%message, %pos + %len, 1);
					if (strpos("abcdefghijklmnopqrstuvwxyzABCDEFGHJIKLMNOPQRSTUVWXYZ1234567890", %after) != -1) {
						//Part of another word
						%replace = false;
					}
				}
			}

			if (%replace) {
				%message = getSubStr(%message, 0, %pos) @ %replacement @ getSubStr(%message, %pos + %len, 9999999);
			} else {
				%pos += %len;
			}
			%pos = stripos(%message, %bad, %pos);
		}
	}

	return %message;
}

//Apparently MB doesn't have this, but it's a torque builtin
function addBadWord(%word) {
	BadWords.addEntry(%word);
}

function initBadWords() {
	BadWords.clear();

	//So the letters don't leak into the dso
	$HeyHowsItGoing = "a"@"b"@"c"@"d"@"e"@"f"@"g"@"h"@"i"@"j"@"k"@"l"@"m"@"n"@"o"@"p"@"q"@"r"@"s"@"t"@"u"@"v"@"w"@"x"@"y"@"z";

	//Minimal filtering
	if ($pref::ProfanityFilter > 0) {
		// (<whole word only>) TAB (<word>)
		BadWords.addEntry(0 TAB "f"@"u"@"c"@"k");
		BadWords.addEntry(0 TAB "c"@"u"@"n"@"t");
		BadWords.addEntry(0 TAB "n"@"i"@"g"@"g"@"e"@"r");
	}
	//MAXIMUM EFFO-, I mean, Filtering
	if ($pref::ProfanityFilter > 1) {
		BadWords.addEntry(0 TAB "d"@"a"@"m"@"n");
		BadWords.addEntry(0 TAB "s"@"h"@"i"@"t");
		BadWords.addEntry(0 TAB "b"@"i"@"t"@"c"@"h");
		BadWords.addEntry(1 TAB "c"@"l"@"i"@"t");
		BadWords.addEntry(1 TAB "f"@"a"@"g");
		BadWords.addEntry(0 TAB "f"@"a"@"g"@"g"@"o"@"t");
		BadWords.addEntry(0 TAB "d"@"o"@"u"@"c"@"h"@"e");
		BadWords.addEntry(1 TAB "d"@"i"@"c"@"k");
		BadWords.addEntry(1 TAB "c"@"o"@"c"@"k");
		BadWords.addEntry(1 TAB "a"@"s"@"s");
	}

	// ;)
	//BadWords.addEntry("joj");
}
