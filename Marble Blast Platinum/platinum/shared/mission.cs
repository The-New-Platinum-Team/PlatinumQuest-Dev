//-----------------------------------------------------------------------------
// Mission Information
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

// grab mission info
function getMissionInfo(%file, %partial) {

	%origfile = %file;

	%isChallenge = strPos(%file, "challenge/data") != -1;
	if (%isChallenge) {
		%file = strReplace(%file, "challenge/data", "platinum/data");
	}

	if (!isScriptFile(%file))
		%file = resolveMissionFile(%file);

	%file = expandFilename(%file);

	if (fileExt(%file) $= ".mcs") {
		//Super fast caching so we don't have to read the file again
		if (isObject($Mission::Info[%origfile]))
			return $Mission::Info[%origfile];

		//MCS has a convenient function for getting the mission info
		%fn = "PQ_" @ alphaNum(fileBase(%file)) @ "_GetMissionInfo";

		//Leaderboards need a separate method
		if (mp() || strPos(%file, "data/multiplayer") != -1) {
			%fn = "MP_" @ %fn;
		} else if (lb() || strPos(%file, "data/lb") != -1) {
			%fn = "LB_" @ %fn;
		}

		//Load the mission if the function hasn't been loaded yet
		if (!isFunction(%fn)) {
			$loadingMissionInfo = true;
			exec(%file);
			$loadingMissionInfo = false;
		}

		if (!$Server::Dedicated && $ScriptError !$= "") {
			MessageBoxOk("Script Error", $ScriptError);
		}

		//Wtf
		if (!isFunction(%fn)) {
			if (isFile(%file)) {
				error(".mcs file " @ %file @ " does not have the correct GetMissionInfo function!");
				error("Should be " @ %fn @ " but no such function was found!");

				//Only do this once else you get like 10000 of them
				if (!$Errored[%file]) {
					$ScriptError = $ScriptError NL ".mcs file " @ %file @ " does not have the correct GetMissionInfo function! Should be " @ %fn @ " but no such function was found!";
					$Errored[%file] = true;
				}
			} else {
				error("Attempted to getMissionInfo non-existing mcs file: " @ %file);
			}
			return -1;
		}

		//Look how simple that was
		%info = call(%fn);
		//So we don't accidentally delete it
		%info.setName("");
		%info.file = %file;
	} else {

		%fileHash = getMissionHash(%file);
		//Super fast caching so we don't have to read the file again
		%info = $Mission::Info[%origfile];
		if (isObject(%info)) {
			if (%partial) {
				//Partial won't care whether or not it's fully loaded
				return %info;
			} else {
				if (!%info.partial) {
					//If it's fully loaded then we're good anyway
					return %info;
				}
				//So it's partial and we need to complete it. Just run it through the same thing.
			}

			// Clean up before we do anything
			%info.gems = 0;
			%info.easterEgg = false;
			for (%i = 0; %i < %info.interiors; %i ++) {
				%info.interior[%i] = "";
			}
			%info.interiors = 0;

			// No longer partial info
			%info.partial = false;
		} else {
			//Nothing found yet, create a new mission info
			%info = new ScriptObject() {
				file = %file;
				partial = %partial;
			};
		}

		%generateCache = false;

		%openFile = %file;

		if (!isFile(%file @ ".cache")) {
			%generateCache = true;
		} else {
			// Check if cache needs to be updated
			%fo = new FileObject();
			if (%fo.openForRead(%file @ ".cache")) {
				while (!%fo.isEOF()) {
					%line = %fo.readLine();
					//Cut off any comments in the mission (because they can throw us off)
					%comment = strPos(%line, "//");
					if (%comment != -1) {
						//In case a string has // inside it, check to see if there is a quote
						// after the // and then assume it's not a comment.
						%quote = strrpos(%line, "\"");
						if (%quote != -1 && %quote < %comment) {
							%line = getSubStr(%line, 0, %comment);
						}
					}
					//Trim extra space
					%line = trim(%line);
					//There's no point in processing empty lines
					if (%line $= "")
						continue;

					if ((!%inInfoBlock) && (stristr(%line, "new ScriptObject() {") != -1)) {
						%inInfoBlock = true;
						continue;
					} else if (%inInfoBlock && (stristr(%line, "};") != -1)) {
						%inInfoBlock = false;
						break;
					} else if (%inInfoBlock) {
						if (stripos(%line, "=") != -1) {
							//First part
							%key = trim(getSubStr(%line, 0, stripos(%line, "=")));
							%value = trim(getSubStr(%line, stripos(%line, "=") + 1, strlen(%line)));

							if (%key !$= "" && %value !$= "") {
								//Strip semicolon
								%value = getSubStr(%value, 0, strlen(%value) - 1);

								//Check if it's a basic quoted string
								%basic =
									(getSubStr(%value, 0, 1) $= "\"") && //Quotes are the first character
									(getSubStr(%value, strlen(%value) - 1, strlen(%value)) $= "\"") && //Quotes are the last character
									(stripos(%value, "\"", 1) == strlen(%value) - 1); //There are no quotes in between

								if (%basic) {
									//Quotes
									%value = collapseEscape(getSubStr(%value, 1, strlen(%value) - 2));
								} else {
									//It's a variable or an expression
									echo("getMissionInfo() :: eval: " @ %value);
									%value = eval("return " @ %value @ ";");
								}
								%info.setFieldValue(%key, %value);
							}
						}
						continue;
					}
				}
				%fo.close();
			} else {
				error("Can't open mission file " @ %file);
				%fo.delete();
				return -1;
			}
			%fo.delete();

			if (%info.hash !$= %fileHash && !%isChallenge) {
				devecho("Generating MissionInfo cache for" SPC %file SPC "(" @ %fileHash @ " != " @ %info.hash @ ")");
				%generateCache = true;
			} else {
				devecho("Using MissionInfo cache for" SPC %file);
			}
		}

		if (isFile(%file) ) {
			if (%generateCache || %partial) {
				%fo = new FileObject();
				if (%fo.openForRead(%file)) {
					while (!%fo.isEOF()) {
						%line = %fo.readLine();
						//Cut off any comments in the mission (because they can throw us off)
						%comment = strPos(%line, "//");
						if (%comment != -1) {
							//In case a string has // inside it, check to see if there is a quote
							// after the // and then assume it's not a comment.
							%quote = strrpos(%line, "\"");
							if (%quote != -1 && %quote < %comment) {
								%line = getSubStr(%line, 0, %comment);
							}
						}
						//Trim extra space
						%line = trim(%line);
						//There's no point in processing empty lines
						if (%line $= "")
							continue;

						if ((!%inInfoBlock) && (stristr(%line, "new ScriptObject(MissionInfo) {") != -1)) {
							%inInfoBlock = true;
							continue;
						} else if (%inInfoBlock && (stristr(%line, "};") != -1)) {
							%inInfoBlock = false;
							//For partial missions we don't care about finding if it has an egg or interiors
							if (%partial) {
								break;
							} else {
								continue;
							}
						} else if (%inInfoBlock) {
							if (stripos(%line, "=") != -1) {
								//First part
								%key = trim(getSubStr(%line, 0, stripos(%line, "=")));
								%value = trim(getSubStr(%line, stripos(%line, "=") + 1, strlen(%line)));

								if (%key !$= "" && %value !$= "") {
									//Strip semicolon
									%value = getSubStr(%value, 0, strlen(%value) - 1);

									//Check if it's a basic quoted string
									%basic =
										(getSubStr(%value, 0, 1) $= "\"") && //Quotes are the first character
										(getSubStr(%value, strlen(%value) - 1, strlen(%value)) $= "\"") && //Quotes are the last character
										(stripos(%value, "\"", 1) == strlen(%value) - 1); //There are no quotes in between

									if (%basic) {
										//Quotes
										%value = collapseEscape(getSubStr(%value, 1, strlen(%value) - 2));
									} else {
										//It's a variable or an expression
										devecho("getMissionInfo() :: eval: " @ %value);
										%value = eval("return " @ %value @ ";");
									}
									%info.setFieldValue(%key, %value);
								}
							}
							continue;
						} else {
							if (!%isCacheFile) {
								//Check for interiors
								if (stripos(%line, "interiorFile") != -1 || stripos(%line, "interiorResource") != -1) {
									//interiorFile --> normal interior filename
									//interiorResource --> moving platform

									//= "interiorname.dif";
									%interior = getSubStr(%line, stripos(%line, "="), strlen(%line));
									//interiorname.dif";
									%interior = getSubStr(%interior, stripos(%interior, "\"") + 1, strlen(%interior));
									//interiorname.dif
									%interior = getSubStr(%interior, 0, strrpos(%interior, "\""));

									//Make sure it doesn't already have the interior
									%found = false;
									for (%i = 0; %i < %info.interiors; %i ++) {
										if (%info.interior[%i] $= %interior) {
											%found = true;
											break;
										}
									}
									if (!%found) {
										%info.interior[%info.interiors] = %interior;
										%info.interiors ++;
									}
								}
								if ((stristr(%line, "easteregg") != -1) || (stristr(%line, "nestegg_pq") != -1)) // easter egg!
									%info.easterEgg = true;
								else if (stristr(%line, "gemitem") != -1) // gems!
									%info.gems ++;
							}
						}
					}
					%fo.close();
				} else {
					error("Can't open mission file " @ %file);
					%fo.delete();
					return -1;
				}
				%fo.delete();
			}
		} else {
			error("Mission file does not exist: " @ %file);
			return -1;
		}
	}

	if (!isObject(MissionInfoGroup))
		RootGroup.add(new SimGroup(MissionInfoGroup));

	MissionInfoGroup.add(%info);
	$Mission::Info[%origfile] = %info;

	//Update these
	%info.game = resolveMissionGame(%info);
	%info.type = resolveMissionType(%info);
	%info.modification = resolveMissionModification(%info);

	if (%generateCache && !%partial) {
		%info.hash = %fileHash;
		%info.save(%file @ ".cache");
	}

	return %info.getId();
}

function getMissionInfoByField(%field, %value) {
	//Check for all missions with this field
	for (%i = 0; %i < MissionInfoGroup.getCount(); %i ++) {
		%mission = MissionInfoGroup.getObject(%i);
		if (%mission.getFieldValue(%field) $= %value)
			return %mission;
	}
	return -1;
}

//Thanks for giving me something to do SummerArmy xoxo. ~Connie
function checkForMaliciousCode(%file) {
	//Doesn't exempt comment lines because you really shouldn't have these kinds of comments in mission files either.

	//The reason this exempts Marbleland levels is because, I'm assuming, Marbleland will no longer allow levels with this shit. Currently, there are no known levels on Marbleland with truly Malicious Code. ~Connie
	if (marblelandIsMission(%file)) {
		return 0;
	}

    if (isFile(%file)) {
        %fo = new FileObject();
        if (%fo.openForRead(%file)) {
            %returnval = 0;

            while (!%fo.isEOF()) {
                %line = %fo.readLine();

				//Entirely skip empty lines. ~Connie
                if (%line $= "") {
                    continue;
                }

				//Once it detects the first part of the mission which is not outside of the main Mission Group, it will skip everything until it gets to the end.
				//This is done to prevent any possible false positives in help texts, descriptions, start help texts, etc. ~Connie
				if ((!%inMainBlock) && (stristr(strlwr(%line), "new simgroup(missiongroup) {") != -1)) {
					%inMainBlock = true;
				} else if ((%inMainBlock) && (stristr(%line, "};") != -1) && (getSubStr(%line, strstr(%line, "};") - 1, 1) $= "")) {
					%inMainBlock = false;
				}

				if (%inMainBlock) {
					continue;
				}

				//Forbidden words. ~Connie
                %keywords = "exec( eval( dump( call( tree( winconsole dbgsetparameters telnetsetparameters deletefile movefile deletevariables";

                for (%i = 0; %i < getWordCount(%keywords); %i++) {
                    %keyword = getWord(%keywords, %i);
					%charbeforekeyword = strlwr(getSubStr(%line, strstr(strlwr(%line), %keyword) - 1, 1));

					if (%charbeforekeyword $= "") {
						%charbeforekeyword = " ";
					}

					//Checks if: 1) The Keyword was found; 2) The Keyword has a letter before it; 3) The Keyword has an equals sign before it (just in case). ~Connie
					if ((strstr(strlwr(%line), %keyword)) != -1 && ((strPos("abcdefghijklmnopqrstuvwxyz", %charbeforekeyword) == -1) || (%charbeforekeyword $= "="))) {
						%returnval = 1;
                        break;
                    }
                }
            }

            %fo.close();
        }

        %fo.delete();
        return %returnval;
    }
}


// Mission Game: What game category it is in the mission list
function resolveMissionGame(%mission) {
	if (%mission.game !$= "") {
		return %mission.game;
	}

	%file = %mission.file;

	//Hack: If you use MissionInfo as the mission
	if (%file $= "") {
		%file = $Client::MissionFile;
	}

	//Check all known games or fallback to the mode
	return
	   (strStr(%file, "_pq/") != -1 ? "PlatinumQuest" :
	    (strStr(%file, "_mbp/") != -1 ? "Platinum" :
	     (strStr(%file, "_mbg/") != -1 ? "Gold" :
	      (strStr(%file, "_mbu/") != -1 ? "Ultra" :
	       (strStr(%file, "_custom/") != -1 ? "Custom" :
	        ClientMode::callbackForMission(%mission, "getLevelGame", "Custom", %file)
	       )
	      )
	     )
	    )
	   );
}

// Mission Type: Which difficulty/type the mission is in the mission list
function resolveMissionType(%mission) {
	if (isObject(%mission)) {
		%file = %mission.file;
	} else {
		%file = %mission;
	}
	return upperFirst(strlwr(fileBase(filePath(%file))));
}

function resolveMissionFile(%name) {
	// Why are you resolving this? We already have it
	if (isFile(%name))
		return %name;

	%mission = findFirstFile($usermods @ "/data/lb*/*/" @ %name @ ".mis");
	// After getting quite a few GG missions, I've added this in
	// to fix the problem.
	while (strStr(%mission, "gg/") != -1 || strStr(%mission, ".svn/") != -1) {
		%mission = findNextFile($usermods @ "/data/lb*/*/" @ %name @ ".mis");
	}
	// At this point, it's safe to assume this mission is multiplayer
	if (!isFile(%mission))
		%mission = findFirstFile($usermods @ "/data/multiplayer/*/*/" @ %name @ ".mis");

	// At this point we have no idea
	if (!isFile(%mission))
		return %name; // Just use what they gave us, maybe that's better

	return %mission;
}

function resolveMissionBitmap(%mission) {
	if (!isObject(%mission))
		%mission = getMissionInfo(%mission);

	%final = filePath(%mission.file) @ "/" @ fileBase(%mission.file);

	// If the image exists, no need to looking for it
	if (!isBitmap(%final)) {
		//Try swapping LB out?
		if (stripos(%final, "/lbmissions") != -1) {
			%final = strReplace(%final, "/lbmissions", "/missions");
		}

		//Or maybe MP?
		if (stripos(%final, "/multiplayer/") != -1) {
			//TODO
		}
	}

	if (isBitmap(%final)) {
		devecho("Found level image:" SPC %final);
	} else {
		devecho("Can't found level image:" SPC %final);
	}

	return %final;
}

function isBitmap(%file) {
	return isFile(%file)
		|| isFile(%file @ ".png")
		|| isFile(%file @ ".jpg")
		|| isFile(%file @ ".bmp")
		|| isFile(%file @ ".dds")
	;
}

//------------------------------------------------------------------------------
// Get Game Modes for a Mission
//------------------------------------------------------------------------------

function resolveMissionGameModes(%mission, %inputmodes) {
	if (isObject(%mission)) {
		%info = %mission;
		%modes = %info.gameMode;
		for (%i = 0; %i < getWordCount(%inputmodes); %i++) {
			%mode = getWord(%inputmodes, %i);
			if (strPos(%modes, %mode) == -1) {
				%modes = trim(%modes SPC %mode);
			}
		}
	} else if (isScriptFile(%mission)) {
		%info = getMissionInfo($Server::MissionFile);
		%modes = %info.gameMode;
		for (%i = 0; %i < getWordCount(%inputmodes); %i++) {
			%mode = getWord(%inputmodes, %i);
			if (strPos(%modes, %mode) == -1) {
				%modes = trim(%modes SPC %mode);
			}
		}
	} else {
		%modes = %inputmodes;
	}

	if ($Server::ServerType $= "MultiPlayer" && $MP::CurrentModeInfo.force) {
		%modes = addWord(%modes, $MP::CurrentModeInfo.identifier);
	}

	if ($Event::Modes !$= "") {
		%modes = addWord(%modes, $Event::Modes);
	}

	%isChallenge = strPos(%info.file, "challenge/data") != -1;

	if (%isChallenge && strPos(%modes, "challenge") == -1) {
		%modes = addWord(%modes, "challenge");
	}

	%complete = false;
	//Check if we need to load the null mode
	for (%i = 0; %i < getWordCount(%modes); %i ++) {
		%mode = getWord(%modes, %i);
		//Duh, don't check if null is complete
		if (%mode $= "null") {
			continue;
		}

		%info = _modeGetInfo(%mode);
		//If we have a complete mode, we don't need to load the null mode
		if (%info.complete) {
			%complete = true;
		}
	}
	if (%complete) {
		//We're complete, make sure null isn't included in the mode list
		%null = findWord(%modes, "null");
		if (%null != -1) {
			%modes = removeWord(%modes, %null);
		}
	} else {
		//Only add null if we don't already have null
		%null = findWord(%modes, "null");
		if (%null == -1) {
			%modes = "null" SPC %modes;
		}
	}
	%modes = trim(%modes);

	//Multiplayer modes
	if ($Server::ServerType $= "MultiPlayer") {
		if ($MP::Server::SpookyGhosts && $MP::CurrentModeInfo.identifier $= "spooky")
			%modes = %modes SPC "ghosts";
		if ($MP::Server::SnowballsOnly && $MP::CurrentModeInfo.identifier $= "snowball")
			%modes = %modes SPC "snowballsonly";
		// if ($MPPref::Server::StealMode || $MP::Client::ServerSetting["StealMode"])
		// 	%modes = %modes SPC "steal";
		if (findWord(%modes, "hunt") != -1 && findWord(%modes, "coop") == -1 && $MP::Client::ServerSetting["CompetitiveMode"])
			%modes = %modes SPC "competitive";
	}

	return strlwr(%modes);
}

function formatGameModes(%modes) {
	if ($Event::Modes !$= "") {
		for (%i = 0; %i < getWordCount($Event::Modes); %i ++) {
			%mode = getWord($Event::Modes, %i);
			%eventIndex = findWord(%modes, %mode);
			%modes = removeWord(%modes, %eventIndex);
		}
	}

	//"Normal 2d" is a pretty crappy mode, just use "2d"
	if (getWord(%modes, 0) $= "null" && getWordCount(%modes) > 1)
		%modes = getWords(%modes, 1);

	//No mode? No problem
	if (%modes $= "")
		%modes = "null";

	if ($MP::CurrentModeInfo.force) {
		//Swap out our forcemode to be the first mode
		%forceIndex = findWord(%modes, $MP::CurrentModeInfo.identifier);
		if (%forceIndex != -1) {
			if (%forceIndex != 0) {
				//Not the first, better swap
				%modes = removeWord(%modes, %forceIndex);
				if (%modes $= "") {
					//Wow we're the only once
					%modes = $MP::CurrentModeInfo.identifier;
				} else {
					//Put us at the front
					%modes = $MP::CurrentModeInfo.identifier SPC %modes;
				}
			}
		} else {
			//?? We're forcing this mode but it's not on the list? Ok then.
		}
	}

	if (findWord(%modes, "snowballsOnly") != -1) {
		%huntLoc = findWord(%modes, "hunt");
		if (%huntLoc != -1) {
			%modes = removeWord(%modes, %huntLoc);
		}
	}

	return %modes;
}

//-----------------------------------------------------------------------------
// Guess what modification a mission is from
//-----------------------------------------------------------------------------

function resolveMissionModification(%mission) {
	//Duh
	if (%mission.modification !$= "") return %mission.modification;

	if (strpos(%mission.file, "missions_pq/") != -1) return "PlatinumQuest";
	if (strpos(%mission.file, "missions_mbg/") != -1) return "Gold";
	if (strpos(%mission.file, "missions_mbp/") != -1) return "Platinum";
	if (strpos(%mission.file, "missions_mbu/") != -1) return "Ultra";

	if (strpos(%mission.file, "coop/pq_") != -1) return "PlatinumQuest";
	if (strpos(%mission.file, "coop/gold_") != -1) return "Gold";
	if (strpos(%mission.file, "coop/platinum_") != -1) return "Platinum";
	if (strpos(%mission.file, "coop/ultra_") != -1) return "Ultra";

	//Some basic indicators
	if (%mission.game !$= "" && %mission.game !$= "Custom") return %mission.game;
	if (%mission.platinumTime !$= "") return "PlatinumQuest"; //Added in PQ
	if (%mission.awesomeScore !$= "") return "PlatinumQuest";
	if (%mission.ultimateTime !$= "") return "Platinum";
	if (%mission.ultimateScore !$= "") return "Platinum";
	if (%mission.awesomeScore[0] !$= "") return "PlatinumQuest";
	if (%mission.awesomeScore[1] !$= "") return "PlatinumQuest";
	if (%mission.platinumScore[0] !$= "") return "Platinum";
	if (%mission.platinumScore[1] !$= "") return "Platinum";
	if (%mission.ultimateScore[0] !$= "") return "Platinum";
	if (%mission.ultimateScore[1] !$= "") return "Platinum";
	if (%mission.easterEgg) return "Platinum";

	//Check interiors
	for (%i = 0; %i < %mission.interiors; %i ++) {
		%interior = %mission.interior[%i];
		if (strpos(%interior, "pq_") != -1) return "PlatinumQuest";
		if (strpos(%interior, "interiors_pq") != -1) return "PlatinumQuest";
		if (strpos(%interior, "mbp_") != -1) return "Platinum";
		if (strpos(%interior, "interiors_mbp") != -1) return "Platinum";
		if (strpos(%interior, "interiors_mbu") != -1) return "Ultra";
		if (strpos(%interior, "fubargame") != -1) return "Fubar";
	}

	return "Gold";
}

//-----------------------------------------------------------------------------

function findFirstMission(%pattern) {
	$FFMext = "m?s";

	%first = findFirstFile(%pattern @ "." @ $FFMext);
	if (%first $= "") {
		$FFMext = "mcs.dso";
		%first = findFirstFile(%pattern @ "." @ $FFMext);
	}
	if (%first !$= "" && $FFMext $= "mcs.dso") {
		%first = getSubStr(%first, 0, strlen(%first) - 4); //strlen(".dso")
		//No need to check if the .mcs exists like below because we've already
		// established that there are no .mcs files.
	}
	return %first;
}

function findNextMission(%pattern) {
	%next = findNextFile(%pattern @ "." @ $FFMext);
	if (%next $= "" && $FFMext $= "m?s") {
		$FFMext = "mcs.dso";
		$FFMext = "mcs.dso";
		%next = findFirstFile(%pattern @ "." @ $FFMext);
	}
	if (%next !$= "" && $FFMext $= "mcs.dso") {
		//Strip the extension so we don't try to exec() the dso
		%next = getSubStr(%next, 0, strlen(%next) - 4); //strlen(".dso")

		//Don't show .mcs.dso files where a .mcs exists
		while (isFile(%next)) {
			//Try the next file
			%next = findNextFile(%pattern @ "." @ $FFMext);
			//If there's no next file we're done here
			if (%next $= "") {
				return %next;
			}
			//Strip the extension so we don't try to exec() the dso
			%next = getSubStr(%next, 0, strlen(%next) - 4); //strlen(".dso")
		}
	}
	return %next;
}

//-----------------------------------------------------------------------------

function getMissionHash(%mission) {
	if (isObject(%mission))
		%mission = %mission.file;
	if (!isScriptFile(%mission))
		return "";

	if (fileExt(%mission) $= ".mis") {
		return getMissionSHA256(%mission);
	}
	if (fileExt(%mission) $= ".mcs") {
		if (isFile(%mission)) { //And not isScriptFile, we can't compile() a dso
			compile(%mission);
		}
		return getFileSHA256(%mission @ ".dso");
	}
	if (fileExt(%mission) $= ".dso") {
		return getFileSHA256(%mission);
	}
	return "";
}
