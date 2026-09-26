//-----------------------------------------------------------------------------
// Copyright (c) 2025 The Platinum Team
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

function Mode_competitive::onLoad(%this) {
    %this.registerCallback("onTimeExpire");
    %this.registerCallback("onDeactivate");
    %this.registerCallback("onMissionReset");
    %this.registerCallback("onMissionEnded");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}

function Mode_competitive::onTimeExpire(%this) {
    //Check for a tie
    %max = -1;
    %tie = false;
    for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
        %client = ClientGroup.getObject(%i);
        %gems = %client.getGemCount();
        if (%gems > %max) {
            %max = %gems;
            %tie = false;
        } else if (%gems == %max) {
            %tie = true;
        }
    }

    //If there is a tie, extend the match into overtime
    if (%tie) {
        Time::stop();
        %time = MissionInfo.time ? MissionInfo.time : 300000;
        //Repeat ties: Extend the match by duration / 10
        if (%this.overtime) {
            Time::set(%time / 10);
            Time::start();
            for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
                %client = ClientGroup.getObject(%i);
                %client.addBubbleLine("Tie! The overtime has been extended.");
                serverPlay2D(SnowGlobeSfx);
                // %client.playPitchedSound("alarm_timeout");
            }
        //First tie: Extend the match by duration / 5
        } else {
            Time::set(%time / 5);
            Time::start();
            for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
                %client = ClientGroup.getObject(%i);
                %client.addBubbleLine("Tie! This match has entered overtime.");
                serverPlay2D(SnowGlobeSfx);
                // %client.playPitchedSound("alarm_timeout");
            }
            %this.overtime = true;
        }
        return false;
    }
    
    %this.overtime = false;
    return true;
}

function Mode_competitive::onDeactivate(%this) {
    //Cancel overtime if deactivated mid-game
    if (%this.overtime) {
        Time::stop();
        Time::set(0);
        endGameSetup();
    }
    %this.overtime = false;
}

function Mode_competitive::onMissionReset(%this) {
    %this.overtime = false;
}

function Mode_competitive::onMissionEnded(%this) {
    %this.overtime = false;
}

function isCompetitiveMode() {
    return $MPPref::Server::CompetitiveMode && mp() && !$Game::isMode["coop"] && $Game::isMode["hunt"];
}