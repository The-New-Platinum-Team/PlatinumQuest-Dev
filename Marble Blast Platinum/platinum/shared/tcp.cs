//-----------------------------------------------------------------------------
// tcp support
// Portions from the GG forums, documented below.
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


$portCheckServer = "https://marbleblast.com";
$portCheckFile = "/pq/leader/api/Server/CheckPortOpen.php";

// these methods that are listed here are basically support template
//       methods that hook into the tcpObject class. Some of them can be
//       over-ridden if necessary.  These methods will make it easier for the
//       programmer to send requests and queries to the server.

// declaration of "constants" - play with them for faster/slower execution of scripts
$TcpObject::reconnectTimer = 2000;
$TcpObject::retryTimer     = 6000;
$TcpObject::retryCount     = 5;
$TcpObject::queryStart     = getRealTime();
$TcpObject::totalQueries   = 0;

function TCPObject::get(%this, %server, %file, %values, %timer) {
	%this.auto = true;
	%this.file = %file @(%values !$= "" ? "?" @ %values : "");
	%this.host = %server;
	%this.mode = "get";
	%this.server = %server;
	%this.keepAlive = false;
	%this.finished = false;
	%this.retries = $TcpObject::retryCount;
	%this.timer = %timer ? %timer : $TcpObject::RetryTimer;
	%this.getCookies();
	%this.connect(%server);
	//%this.scheduleIgnorePause($TcpObject::reconnectTimer, "reconnect");
}

function TCPObject::post(%this, %server, %file, %values, %timer) {
	%this.auto = true;
	%this.file = %file;
	%this.values = %values;
	%this.host = %server;
	%this.mode = "post";
	%this.server = %server;
	%this.keepAlive = false;
	%this.finished = false;
	%this.retries = $TcpObject::retryCount;
	%this.timer = %timer ? %timer : $TcpObject::RetryTimer;
	%this.retryTimer = %this.timer;
	%this.getCookies();
	%this.connect(%server);
	//%this.scheduleIgnorePause($TcpObject::reconnectTimer, "reconnect"); // used for mac support, as reconnecting allows tcp sockets to work
}

function TCPObject::reconnect(%this) {
	if (!%this.auto || %this.destroying)
		return;

	%this.cancelAllIgnorePause();

	if (%this.reconnects > %this.retries) {
		%this.recreate();
		return;
	}

	%this.onReconnect();
	%this.reconnects  ++;

	//%this.disconnect();
	%this.cancelAllIgnorePause();
	cancelIgnorePause(%this.retry);
	//%this.retry = %this.scheduleIgnorePause($TcpObject::reconnectTimer, "reconnect"); // used for mac support, as reconnecting allows tcp sockets to work
	%this.connect(%this.server);
}

function TCPObject::recreate(%this) {
	error("TCP Object getting recreated");
	return;

	%new = new TCPObject(%this.getName());
	if (%this.mode $= "get")
		%new.get(%this.server, %this.file, %this.values, %this.timer);
	else
		%new.post(%this.server, %this.file, %this.values, %this.timer);
	%this.delete();
}

function TCPObject::onConnected(%this) {
	if (!%this.auto || %this.destroying)
		return;
	%this.cancelAllIgnorePause();

	%file = %this.file;
	%host = %this.host;
	if (%this.mode $= "get") {
		%this.lineCount = 0;
		%this.performGet(%file, %host);
		%this.scheduleIgnorePause(%this.timer, "retryGet", 0, %file, %host); // used for mac support, as reconnecting allows tcp sockets to work
	} else if (%this.mode $= "post") {
		%this.performPost(%file, %host, %this.values);
		%this.scheduleIgnorePause(%this.timer, "retryPost", 0, %file, %host, %this.values); // used for mac support, as reconnecting allows tcp sockets to work
	}
	%this.echo("Connected", "Status");
}

function TCPObject::onLine(%this, %line) {
	if (!%this.auto || %this.destroying)
		return;
	// a base method, be sure to parent the current tcp object to this method,
	// so that it will provide extended functionallity to the getOutput() method
	// purpose: keeps track of every single line that is received from the server

	%this.echo(%line, "Line");

	%this.cancelAllIgnorePause();
	%this.lineCount ++;

	if (%this.receivingHeaders) {
		if (%line $= "") {
			%this.receivingHeaders = false;
		}
		if (strPos(%line, "Set-Cookie") == 0) {
			//Set-Cookie: 33096fb4c4fd7002efa2f081b0b33797=4D1A4D1155435B+0+C+717+E122B5870454C17141B11554A4311+B415746+2164E575656+74850+6431F; expires=Sun, 04-Jan-2015 02:36:39 GMT; path=/; httponly
			%cookie = getSubStr(%line, strPos(%line, " ") + 1, strlen(%line));
			//33096fb4c4fd7002efa2f081b0b33797=4D1A4D1155435B+0+C+717+E122B5870454C17141B11554A4311+B415746+2164E575656+74850+6431F; expires=Sun, 04-Jan-2015 02:36:39 GMT; path=/; httponly
			%cname = getSubStr(%cookie, 0, strPos(%cookie, "="));
			//33096fb4c4fd7002efa2f081b0b33797
			%cdata = getSubStr(%cookie, strPos(%cookie, "=") + 1, strPos(%cookie, ";") - (strPos(%cookie, "=") + 1));
			//E122B5870454C17141B11554A4311+B415746+2164E575656+74850+6431F

			setCookie(%this.host, %cname, %cdata);
		}
		if (strPos(%line, "HTTP") == 0) {
			//HTTP/1.1 200 OK
			%response   = getWord(%line, 1);
			%respstring = getWords(%line, 2);
			if (%response != 200) {
				%this.echo("Got Server Response:" SPC %respstring SPC "(" @ %response @ ")", "Response");
				switch (%response) {
				case 400:
				case 401:
				case 403:
				case 404:
				case 500:
				case 502:
				}
			}
		}
		return false;
	}
	return true;
}

function setCookie(%host, %name, %data) {
	if ($cookie[%host, %name] $= "") {
		$cookies[%host] += 0;
		$cookie[%host, $cookies[%host]] = %name;
		$cookie[%host, %name] = %data;
		$cookies[%host, %name] = $cookies[%host];
		$cookies[%host] ++;
	} else {
		if (%data $= "deleted") {
			deleteVariables("$cookie" @ %host @ "_" @ %name);
			%num = $cookies[%host, %name];
			//Move them all down one
			for (%i = %num + 1; %i < $cookies[%host]; %i ++) {
				$cookie[%host, %i] = %cookie[%host, %i + 1];
				$cookie[%host, $cookie[%host, %i]] = %cookie[%host, $cookie[%host, %i + 1]];
				$cookies[%host, $cookie[%host, %i + 1]] = %i;
			}
			$cookies[%host] --;

		} else
			$cookies[%host, %name] = %data;
	}
}

function clearCookies(%host) {
	deleteVariables("$cookie" @ %host @ "*");
	deleteVariables("$cookies" @ %host);
}

function clearAllCookies(%host) {
	deleteVariables("$cookie*");
}

function TCPObject::getCookies(%this) {
	if ($cookies[%this.host] > 0)
		%this.cookie = "Cookie:";
	for (%i = 0; %i < $cookies[%this.host]; %i ++) {
		%cname = $cookie[%this.host, %i];
		%cdata = $cookie[%this.host, %cname];
		%this.cookie = %this.cookie SPC URLEncode(%cname) @ "=" @ URLEncode(%cdata) @ ";";
	}
}

function TCPObject::performGet(%this, %file, %host) {
	if (!%this.auto || %this.destroying)
		return;
	// The actual method that performs the get query
	%this.cancelAllIgnorePause();
	%query = "GET" SPC %file SPC "HTTP/1.1\r\n" @
	         "User-Agent: Torque 1.0\r\n" @
	         "Host:" SPC %host @
	         (%this.cookie $= "" ? "" : "\r\n" @ %this.cookie) @ "\r\n" @
	         "Connection: close\r\n" @
	         "Accept: text/html\r\n" @
	         "Cache-Control: max-age=0\r\n" @
	         "\r\n";

	%this.query[%this.queries ++] = %query;

	%this.totalqueries ++;
	$TCPObject::TotalQueries ++;
	if (($TCPObject::TotalQueries / (getRealTime() - $TCPObject::queryStart)) > 0.025) {
		error("HOLD THE PHONE! QUERY OVERLOAD");
		MessageBoxOk("Console", "Would be super nice of you to upload your console.log file to <a:marbleblast.com>MarbleBlast.com</a> or send it to marbleblastforums@gmail.com");
		echo("TCPGroup:");
		for (%i = 0; %i < TCPGroup.getCount(); %i ++)
			dumpObject(TCPGroup.getObject(%i), 3);
	}

	%this.echo(%query, "Send");
	%this.send(%query);
	%this.receivingHeaders = true;
}

function TCPObject::performPost(%this, %file, %host, %values) {
	if (!%this.auto || %this.destroying)
		return;
	// The actual method that performs the post query
	//        %values are sent to the server as arguments
	%this.cancelAllIgnorePause();

	%query = "POST" SPC %file SPC "HTTP/1.1\r\n" @
	         "Host:" SPC %host @(%this.cookie $= "" ? "" : "\r\n" @ %this.cookie) @ "\r\n" @
	         "User-Agent: Torque 1.0 \r\n" @
	         "Accept: text/*\r\n" @
	         "Connection: close\r\n" @
	         "Content-Type: application/x-www-form-urlencoded; charset=UTF-8\r\n" @
	         "Content-Length: " @ strLen(%values) @ "\r\n\r\n"
	         @ %values @ "\r\n";

	%this.query[%this.queries ++] = %query;

	%this.totalqueries ++;
	$TCPObject::TotalQueries ++;
	if (($TCPObject::TotalQueries / (getRealTime() - $TCPObject::queryStart)) > 0.025) {
		error("HOLD THE PHONE! QUERY OVERLOAD");
		MessageBoxOk("Console", "Would be super nice of you to upload your console.log file to <a:marbleblast.com>MarbleBlast.com</a> or send it to marbleblastforums@gmail.com");
		echo("TCPGroup:");
		for (%i = 0; %i < TCPGroup.getCount(); %i ++)
			dumpObject(TCPGroup.getObject(%i), 3);
	}

	%this.echo(%query, "Send");
	%this.send(%query);
	%this.receivingHeaders = true;
}

function TCPObject::retryGet(%this,%count,%file,%host) {
	if (!%this.auto || %this.destroying)
		return;
	%this.cancelAllIgnorePause();
	if (%count >= %this.retries) {
		%this.reconnect();
		return;
	}
	if (%count % 5 == 0)
		%this.retryTimer = %this.timer;
	if (%count % 10 == 0 && %count > 0) {
		%this.reconnect();
		return;
	}

	%this.onRetrySend();
	%this.performGet(%file, %host);

	%this.retryTimer += 100;

	%this.cancelAllIgnorePause();
	cancelIgnorePause(%this.retry);
	%this.retry = %this.scheduleIgnorePause(%this.Timer, "retryGet", %count + 1, %file, %host);
}

function TCPObject::retryPost(%this, %count, %file, %host, %values) {
	if (!%this.auto || %this.destroying)
		return;
	%this.cancelAllIgnorePause();
	if (%count >= %this.retries) {
		%this.reconnect();
		return;
	}

	if (%count % 5 == 0)
		%this.retryTimer = %this.timer;
	if (%count % 10 == 0 && %count > 0) {
		%this.reconnect();
		return;
	}

	%this.onRetrySend();
	%this.performPost(%file, %host, %values);

	%this.retryTimer += 100;

	%this.cancelAllIgnorePause();
	cancelIgnorePause(%this.retry);
	%this.retry = %this.scheduleIgnorePause(%this.retryTimer, "retryPost", %count + 1, %file, %host, %values);
}

function TCPObject::onDisconnect(%this) {
	if (!%this.auto)
		return;
	%this.cancelAllIgnorePause();
	cancelIgnorePause(%this.retry);
	%this.cancel(true);
	%this.echo("Disconnected", "Status");
}

function TCPObject::cancel(%this, %dontDis) {
	if (!%this.auto)
		return;
	%this.cancelAllIgnorePause();
	cancelIgnorePause(%this.retry);
	//if (!%dontDis)
	//%this.disconnect();
	%this.onFinish();
	if (!%this.keepAlive && isEventPendingIgnorePause(%this.destroySch))
		%this.destroy(); // I assume we don't need it anymore
	// You almost blew up the whole leaderboards!
	//%this.delete();
}

function TCPObject::onFinish(%this) {
	// Nothing, just a template for overriding it
}

function TCPObject::onRetrySend(%this) {
	// Nothing here, override this!
}

function TCPObject::onReconnect(%this) {
	// Another overridable
}

function TCPObject::onDNSFailed(%this) {
	%this.cancel();
}

function TCPObject::onConnectFailed(%this) {
	%this.cancel();
}

// Cannot remember which one it is
function TCPObject::onConnectionFailed(%this) {
	%this.cancel();
}

function TCPObject::echo(%this, %text, %abbr) {
	if (!isObject(%this))
		return;

	if (!$TCPShowOutput)
		return;

	//Removed due to devmode
	%prefix = %this.getName() @ (%abbr $= "" ? "" : " (" @ %abbr @ ")") SPC ":: ";
	%text = %prefix @ strReplace(%text, "\n", "\n" @ %prefix);
	%text = strReplace(%text, "\r\n", "\n");
	devecho(%text);
}

function TCPObject::dump(%this) {
	// I choose to override this because we do not want the client
	// to be able to view our queries.  This is for data security, because
	// all queries and info are stored into the actual tcp object itself.
	// This is a standard c++ error code, implimented to make this thing look legit.
	warn("<input> (0): Unknown command dump.");
	if (%this.getName() $= "")
		warn("  Object (" @ %this.getID() @ ") TCPObject -> SimObject");
	else
		warn("  Object " @ %this.getName() @ "(" @ %this.getID() @ ") " @ %this.getName() @ " -> TCPObject -> SimObject");
}

//-----------------------------------------------------------------------------
// http://www.garagegames.com/community/blogs/view/10202
//-----------------------------------------------------------------------------

function dec2hex(%val) {
	// Converts a decimal number into a 2 digit HEX number
	%digits = "0123456789ABCDEF";	//HEX digit table

	// To get the first number we divide by 16 and then round down, using
	// that number as a lookup into our HEX table.
	%firstDigit = getSubStr(%digits,mFloor(%val/16),1);

	// To get the second number we do a MOD 16 and using that number as a
	// lookup into our HEX table.
	%secDigit = getSubStr(%digits,%val % 16,1);

	// return our two digit HEX number
	return %firstDigit @ %secDigit;
}

function hex2dec(%val) {
	// Converts a decimal number into a 2 digit HEX number
	%digits = "0123456789ABCDEF";	//HEX digit table

	// To get the first number we divide by 16 and then round down, using
	// that number as a lookup into our HEX table.
	%firstDigit = strPos(%digits, getSubStr(%val, 0, 1));

	// To get the second number we do a MOD 16 and using that number as a
	// lookup into our HEX table.
	%secondDigit = strPos(%digits, getSubStr(%val, 1, 1));

	// return our two digit HEX number
	return (%firstDigit * 16) + %secondDigit;
}

function chrValue(%chr) {
	// So we don't have to do any C++ changes we approximate the function
	// to return ASCII Values for a character.  This ignores the first 31
	// characters and the last 128.

	// Setup our Character Table.  Starting with ASCII character 32 (SPACE)
	%charTable = " !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^\'_abcdefghijklmnopqrstuvwxyz{|}~\t\n\r";

	//Find the position in the string for the Character we are looking for the value of
	%value = strpos(%charTable,%chr);

	// Add 32 to the value to get the true ASCII value
	%value = %value + 32;

	//HACK:  Encode TAB, New Line and Carriage Return

	if (%value >= 127) {
		if (%value == 127)
			%value = 9;
		if (%value == 128)
			%value = 10;
		if (%value == 129)
			%value = 13;
	}

	//return the value of the character
	return %value;
}

function chrForValue(%chr) {
	// So we don't have to do any C++ changes we approximate the function
	// to return ASCII Values for a character.  This ignores the first 31
	// characters and the last 128.

	// Setup our Character Table.  Starting with ASCII character 32 (SPACE)
	%charTable = " !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^\'_abcdefghijklmnopqrstuvwxyz{|}~\t\n\r";

	//HACK:  Decode TAB, New Line and Carriage Return

	if (%chr == 9)
		%chr = 127;
	if (%chr == 10)
		%chr = 128;
	if (%chr == 13)
		%chr = 129;

	%chr -= 32;
	%value = getSubStr(%charTable,%chr, 1);

	return %value;
}

function URLEncode(%rawString) {
	// Encode strings to be HTTP safe for URL use

	// Table of characters that are valid in an HTTP URL
	%validChars = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz:/.?=_-$(){}~&";


	// If the string we are encoding has text... start encoding
	if (strlen(%rawString) > 0) {
		// Loop through each character in the string
		for (%i = 0; %i < strlen(%rawString); %i ++) {
			// Grab the character at our current index location
			%chrTemp = getSubStr(%rawString, %i, 1);

			//  If the character is not valid for an HTTP URL... Encode it
			if (strstr(%validChars, %chrTemp) == -1) {
				//Get the HEX value for the character
				%chrTemp = dec2hex(chrValue(%chrTemp));

				// Is it a space?  Change it to a "+" symbol
				if (%chrTemp $= "20") {
					%chrTemp = "+";
				} else {
					// It's not a space, prepend the HEX value with a %
					%chrTemp = "%" @ %chrTemp;
				}
			}
			// Build our encoded string
			%encodeString = %encodeString @ %chrTemp;
		}
	}
	// Return the encoded string value
	return %encodeString;
}
function URLDecode(%rawString) {
	// Encode strings from HTTP safe for URL use

	// If the string we are encoding has text... start encoding
	if (strlen(%rawString) > 0) {
		// Loop through each character in the string
		for (%i = 0; %i < strlen(%rawString); %i ++) {
			// Grab the character at our current index location
			%chrTemp = getSubStr(%rawString, %i, 1);

			if (%chrTemp $= "+") {
				// Was it a "+" symbol?  Change it to a space
				%chrTemp = " ";
			}
			//  If the character was not valid for an HTTP URL... Decode it
			if (%chrTemp $= "%") {
				//Get the dec value for the character
				%chrTemp = chrForValue(hex2dec(getSubStr(%rawString, %i + 1, 2)));
				%i += 2;
			}
			// Build our encoded string
			%encodeString = %encodeString @ %chrTemp;
		}
	}
	// Return the encoded string value
	return %encodeString;
}


function addParam(%params, %name, %value) {
	if (%params $= "")
		return URLEncode(%name) @ "=" @ URLEncode(%value);
	else
		return %params @ "&" @ URLEncode(%name) @ "=" @ URLEncode(%value);
}

function addParams(%params, %toAdd) {
	if (%toAdd $= "")
		return %params;
	if (%params $= "")
		return %toAdd;
	else
		return %params @ "&" @ %toAdd;
}

function LBDefaultQuery(%username, %password) {
	%username = %username $= "" ? $LB::username : %username;

	traceGuard();
	%password = %password $= "" ? $LB::Password2 : garbledeguck(%password);
	traceGuardEnd();

	%key = strRand(40);
	%Version = $MP::RevisionOn;
	if ($LB::ChatKey $= "")
		return "username=" @ %username @ "&password=" @ %password @ "&joomlaAuth=0&key=" @ %key @ "&version=" @ %version;
	else
		return "username=" @ %username @ "&joomlaAuth=0&key=" @ $LB::ChatKey @ "&version=" @ %version;
}

//------------------------------------------------------------------------------

function TCPObject::destroy(%this) {
	//%this.disconnect();
	if (!%this.shhhhh && $LBShowSigs)
		%this.echo("Destroying!");
	%this.destroying = true;
	%this.cancelAllIgnorePause();
	cancelIgnorePause(%this.retry);

	%this.destroySch = %this.scheduleIgnorePause(500, "delete");
}

function GameConnection::destroy(%this) {
	%this.disconnect();
	//%this.schedule(500, "delete");
}

//------------------------------------------------------------------------------

function checkPort() {
	if ($PortStatus !$= "global")
		$PortStatus = "checking";

	new HTTPObject(PortChecker);
	echo("Port check via " @ $portCheckServer @ $portCheckFile);
	PortChecker.get($portCheckServer, $portCheckFile, "port=" @ $pref::Server::Port);
}

function PortChecker::onLine(%this,%line) {
	Parent::onLine(%this,%line);
	if (firstWord(%line) $= "PORT") { //Port status
		if (getWord(%line, 1) $= "SUCCESS") {
			$PortStatus = "global";
		} else {
			$PortStatus = "lan";
		}
	} else if (firstWord(%line) $= "ERROR") { //Shit!
		$PortStatus = "error";
	}
	%this.destroy();
	MPServerDlg.portMappingFinished();
}

//------------------------------------------------------------------------------

function trackGuiOpen(%gui) {
	%name = (isObject(%gui) ? %gui.getName() : %gui);
//	echo("Tracking open:" SPC %name);
	%index = -1;
	for (%i = 0; %i < $LBPref::GuiCount; %i ++) {
		if ($LBPref::Gui[%i] $= %name) {
			%index = %i;
			break;
		}
	}

	if (%index == -1) {
		%index = $LBPref::GuiCount;
		$LBPref::GuiCount ++;
		$LBPref::GUI[%index] = %name;
	}

	$LBPref::GUICount[%index] ++;
//	savePrefs();
}
