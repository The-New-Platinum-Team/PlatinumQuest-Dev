//-----------------------------------------------------------------------------
// Hunt - Plus mode
//
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

function Mode_huntplus::onLoad(%this) {
	%this.registerCallback("onRestartLevel");
	%this.registerCallback("onHuntGemSpawn");
	%this.registerCallback("modifyScoreData");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}

function Mode_huntplus::onHuntGemSpawn(%this, %object) {
ClientAudioGroup.add(new AudioProfile(TimeTickSfx) {
	filename    = "~/data/sound/TimeTravelActive.wav";
	description = "ClientAudio2D";
	preload = true;
});

    if (missioninfo.additionaltime != "") {      //Bonus Time upon New Spawn - Modifier 1
		if ($Game::FirstSpawn) {
            return;
		} else {
            %additionalhunttime = missioninfo.additionaltime / 1000;

    	    Time::set($Time::CurrentTime + missioninfo.additionaltime);
            alxPlay("TimeTickSfx");

			if (missioninfo.additionaltime < 0) {
	            PlayGui.displayGemMessage(%additionalhunttime @ "s", "ff8888"); 
			} else {
		        PlayGui.displayGemMessage("+" @ %additionalhunttime @ "s", "88ff88");
			}
		}
	}
	
	if (missioninfo.ragingbull) {                //Ragingbull - SS and SJ upon new spawn - Modifier 2
		if ($Game::FirstSpawn) {
			return;
		} else {
			commandToAll('doPowerUp', 1);
			commandToAll('doPowerUp', 2);
			for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
				%client = ClientGroup.getObject(%i);
				SuperJumpItem.onUse(%trigger, %client.player);
				SuperSpeedItem.onUse(%trigger, %client.player);
			}
		}
	}

    if (missioninfo.gravitex && !$Game::FirstSpawn || $MPPref::Server::GravitexHP && !$Game::FirstSpawn && mp()) {              //Gravitex - Switch Gravity upon new spawn - Modifier 3
		if (%this.gravityswitchhp == 1) {
		    %this.gravityswitchhp = 0;
		    commandtoAll('setGravityDir', "-0.965925 0 0.258822 0 1 0 -0.258822 0 -0.965925");
			commandtoAll('AddHelpLine', "Gravity Switched!");
			alxPlay(PuAntiGravityVoiceSfx);
			$MP::HuntPlusGravitex1 = false;
			$MP::HuntPlusGravitex0 = true;
	    } else if (%this.gravityswitchhp == 0 || %this.gravityswitchhp == 2) {
		    %this.gravityswitchhp = 1;
		    commandtoAll('setGravityDir', "-0.965926 0 -0.258817 0 1 0 0.258817 0 -0.965926");
			commandtoAll('AddHelpLine', "Gravity Switched!");
			alxPlay(PuAntiGravityVoiceSfx);
			$MP::HuntPlusGravitex1 = true;
			$MP::HuntPlusGravitex0 = false;
		}
	}

	if ($Game::FirstSpawn) {
		%this.gravityswitchhp = 2;
	}
}

function Mode_huntplus::onRestartLevel(%this, %object) {
    $MP::HuntPlusGravitex1 = false;
	$MP::HuntPlusGravitex0 = false;
}

function Mode_huntplus::modifyScoreData(%this, %object) {
	if (!$MPPref::Server::PartySpawns && $MPPref::Server::GravitexHP)
		return %object.data @ "&extraModes[]=gravitex";
}