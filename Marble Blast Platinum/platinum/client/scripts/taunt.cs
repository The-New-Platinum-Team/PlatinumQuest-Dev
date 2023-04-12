//-----------------------------------------------------------------------------
// taunts.cs
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

//-----------------------------------------------------------------------------
// taunt list:
//
// 1  - chicken
// 2  - random chars aka Confusion Taunt
// 3  - laughter
// 4  - you are a loser (aka anybody besides matan and xelna)
// 5  - mega marble kids!!
// 6  - MULTIPLAYER WHERe
// 7  - Come on!
// 8  - Pomp
// 9  - PQ WHERe
// 10 - RAISE UR DONGERS
// 11 - You got owned!
// 12 - WORTH IT
// 13 - Do da la la la...
//-----------------------------------------------------------------------------

function resolveTaunt(%name) {
	switch$ (%name) {
	case "chick":
		return 1;
	case "asdf":
		return 2;
	case "haha":
		return 3;
	case "loser":
		return 4;
	case "mega":
		return 5;
	case "mp":
		return 6;
	case "cmon":
		return 7;
	case "pomp":
		return 8;
	case "pq":
		return 9;
	case "raise":
		return 10;
	case "owned":
		return 11;
	case "worth":
		return 12;
	case "lala":
		return 13;
	case "gg":
		return 14;
	case "shaz":
		return 15;
	case "blue":
		return 16;
	case "lag":
		return 17;
	}
	return %name;
}

function tauntText(%number) {
	switch (%number) {
	case  1:
		return "You chicken? Bwk bwk bwk!";
	case  2:
		return "Gashfdklafaashn.zx,cbvz.e";
	case  3:
		return "Hahahahaha!";
	case  4:
		return "Welcome to loserville, population: You!";
	case  5:
		return "Mega Marble, Kids!";
	case  6:
		return "Multiplayer WHERe?";
	case  7:
		return "Oh, come on!";
	case  8:
		return "Pomp!";
	case  9:
		return "PQ WHERe?";
	case 10:
		return "Raise your dongers!";
	case 11:
		return "You got owned.";
	case 12:
		return "WOOOOORTH IT!!";
	case 13:
		return "Do da la la la la la la la la la la...";
	case 14:
		return "Good game!";
	case 15:
		return "SHAZBOT!";
	case 16:
		return "Bluuuee steaaaal!";
	case 17:
		return "%@#&ing lag!";
	}
	return "";
}

function tauntFile(%number) {
	if ($Audio::CurrentAudioPack $= "")
		%base = $usermods @ "/data/sound/taunts/";
	else
		%base = $usermods @ "/data/sound/ap_" @ $Audio::CurrentAudioPack @ "/";
	switch (%number) {
	case  1:
		return %base @ "Chicken.wav";
	case  2:
		return %base @ "Asdfasdf.wav";
	case  3:
		return %base @ "Hahahaha.wav";
	case  4:
		return %base @ "Loserville.wav";
	case  5:
		return %base @ "MegaMarble.wav";
	case  6:
		return %base @ "MPWHERe.wav";
	case  7:
		return %base @ "Cmon.wav";
	case  8:
		return %base @ "Pomp.wav";
	case  9:
		return %base @ "PQWHERe.wav";
	case 10:
		return %base @ "Dongers.wav";
	case 11:
		return %base @ "YouGotOwned.wav";
	case 12:
		return %base @ "WorthIt.wav";
	case 13:
		return %base @ "DoDaLaLaLa.wav";
	case 14:
		return %base @ "GoodGame.wav";
	case 15:
		return %base @ "Shazbot.wav";
	case 16:
		return %base @ "BlueSteal.wav";
	case 17:
		return %base @ "Lag.wav";
	}
}

function playTaunt(%number) {
	//Disable Taunts setting - The chat message will still appear, but the taunt sound will not play.
	if ($pref::disabletaunts) 
		return;

	if (!isObject(LBTaunt @ %number)) {
		RootGroup.add(new AudioProfile(LBTaunt @ %number) {
			filename = tauntFile(%number);
			description = "AudioGui";
			preload = true;
		});
	}
	alxPlay(LBTaunt @ %number);
}

function getTaunt(%number, %audio) {

}

function sendTaunt(%number) {
	if ($LB::Guest)
		return;

	mpSendChat("/v" @ %number);
}

//-----------------------------------------------------------------------------
// keybindings to taunts
//-----------------------------------------------------------------------------

function taunt1(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(1);
}

function taunt2(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(2);
}

function taunt3(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(3);
}

function taunt4(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(4);
}

function taunt5(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(5);
}

function taunt6(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(6);
}

function taunt7(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(7);
}

function taunt8(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(8);
}

function taunt9(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(9);
}

function taunt10(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(10);
}

function taunt11(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(11);
}

function taunt12(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(12);
}

function taunt13(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(13);
}

function taunt14(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(14);
}

function taunt15(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(15);
}

function taunt16(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(16);
}

function taunt17(%val) {
	if (%val && $Server::ServerType $= "Multiplayer")
		sendTaunt(17);
}

// bind the default keys
function bindDefaultTauntKeys() {
//   MoveMap.bind(keyboard, 1,        taunt1);
	MoveMap.bind(keyboard, 1,        taunt2);
	MoveMap.bind(keyboard, 2,        taunt3);
//   MoveMap.bind(keyboard, 4,        taunt4);
	MoveMap.bind(keyboard, 3,        taunt5);
//   MoveMap.bind(keyboard, 6,        taunt6);
	MoveMap.bind(keyboard, 4,        taunt7);
//   MoveMap.bind(keyboard, 8,        taunt8);
	MoveMap.bind(keyboard, 5,        taunt9);
	MoveMap.bind(keyboard, 6,        taunt10);
	MoveMap.bind(keyboard, 7,  taunt11);
	MoveMap.bind(keyboard, 8,   taunt12);
//   MoveMap.bind(keyboard, "ctrl 1", taunt13);
	MoveMap.bind(keyboard, 9,        taunt14);
	MoveMap.bind(keyboard, 0,        taunt15);
	MoveMap.bind(keyboard, "minus",        taunt16);
	MoveMap.bind(keyboard, "equals",        taunt17);
}
