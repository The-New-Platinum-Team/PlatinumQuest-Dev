//-----------------------------------------------------------------------------
// Copyright (c) 2021 The Platinum Team
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

ModeInfoGroup.add(new ScriptObject(ModeInfo_party) {
	class = "ModeInfo_party";
	superclass = "ModeInfo";

	identifier = "party";
	file = "party";

	name = "PPPPPPARTY";
	desc = "Who else is surprised this game still works after a whole year?";

	hide = 1;
});

function ClientMode_party::onLoad(%this) {
	echo("[Mode" SPC %this.name @ " Client]: Loaded!");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onRespawnPlayer");
	%this.registerCallback("onRespawnOnCheckpoint");

	$Party::Client::Modes = 0;
	registerParty("float");
	registerParty("nojump");
	registerParty("releasio");
	registerParty("instantpup");
	registerParty("alljump");
}

function ClientMode_party::onDeactivate(%this) {
	deleteVariables("$Party::Client::ActiveMode*");
}

function ClientMode_party::onMissionReset(%this) {
	//Fucking great callback system, me
	onNextFrame(clientPartyCheckRespawn);
}
function ClientMode_party::onRespawnPlayer(%this) {
	onNextFrame(clientPartyCheckRespawn);
}
function ClientMode_party::onRespawnOnCheckpoint(%this) {
	onNextFrame(clientPartyCheckRespawn);
}

function clientPartyCheckRespawn() {
	for (%i = 0; %i < $Party::Client::Modes; %i ++) {
		%mode = $Party::Client::Mode[%i];
		if ($Party::Client::ActiveMode[%mode]) {
			call("partyUpdate" @ %mode);
		}
	}
}

function partyUpdatefloat() {
	Physics::pushLayerName("partyFloat");
}

function partyDisablefloat() {
	Physics::popLayerName("partyFloat");
}

function partyUpdatenojump() {
	Physics::pushLayerName("partyNoJump");
}

function partyDisablenojump() {
	Physics::popLayerName("partyNoJump");
}

function partyUpdatereleasio() {
	Physics::pushLayerName("partyReleasio");
}

function partyDisablereleasio() {
	Physics::popLayerName("partyReleasio");
}

function partyUpdateinstantpup() {
	input_mouseFire(1);
}

function partyDisableinstantpup() {
	input_mouseFire(0);
}

function partyUpdatealljump() {
	input_jump(1);
}

function partyDisablealljump() {
	input_jump(0);
}

function registerParty(%name) {
	$Party::Client::Mode[$Party::Client::Modes] = %name;
	$Party::Client::Modes ++;
}


package ClientMode_party {
	function input_moveBackward(%val) {
		if (!$Party::Client::ActiveMode["sssuper"]) {
			Parent::input_moveBackward(%val);
			return;
		}

		if ($Game::2D && !$Editor::Opened)
			return;

		//Pressing S makes you superspeed instead of roll backwards
		%back = (%val > 0);
		if ($Party::BackItUp != %back && %back && MPMyMarbleExists()) {
			MPGetMyMarble().doPowerUp(2);
			alxPlay(doSuperSpeedSfx);
		}
		$Party::BackItUp = %back;
	}

	function input_mouseFire(%val) {
		if (!$Party::Client::ActiveMode["instantpup"]) {
			Parent::input_mouseFire(%val);
			return;
		}
		Parent::input_mouseFire(1);
	}

	function input_jump(%val) {
		if (!$Party::Client::ActiveMode["alljump"]) {
			Parent::input_jump(%val);
			return;
		}
		Parent::input_jump(1);
	}
};

function clientCmdSetPartyModes(%modes) {
	echo("[Mode Party Client]: Got party mode list:" SPC %modes);

	for (%i = 0; %i < $Party::Client::Modes; %i ++) {
		%mode = $Party::Client::Mode[%i];
		if ($Party::Client::ActiveMode[%mode]) {
			call("partyDisable" @ %mode);
		}
	}

	deleteVariables("$Party::Client::ActiveMode*");
	for (%i = 0; %i < getWordCount(%modes); %i ++) {
		$Party::Client::ActiveMode[%i] = getWord(%modes, %i);
		$Party::Client::ActiveMode[getWord(%modes, %i)] = true;
	}
	$Party::Client::ActiveModes = getWordCount(%modes);

	clientPartyCheckRespawn();
}

Physics::registerLayer("partyFloat", "gravity 4");
Physics::registerLayer("partyNoJump", "jumpImpulse 0");
Physics::registerLayer("partyReleasio",
                       "maxRollVelocity 750" NL
                       "angularAcceleration 300" NL
                       "brakingAcceleration 30" NL
                       "gravity 9.5" NL
                       "staticFriction 10.6" NL
                       "kineticFriction 0.6" NL
                       "bounceKineticFriction 0.6" NL
                       "maxDotSlide 1.0" NL
                       "bounceRestitution 1.0" NL
                       "jumpImpulse 12.0" NL
                       "maxForceRadius 50"
                      );
