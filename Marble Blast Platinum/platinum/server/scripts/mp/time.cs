//-----------------------------------------------------------------------------
// Time control (like PlayGUI but server-side)
//
// Copyright (c) 2015 The Platinum Team
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

package ServerTime {
	/**
	 * @param {Type} %delta
	 */
	function onFrameAdvance(%delta) {
		Parent::onFrameAdvance(%delta);

		//Make sure we have a server active before we try to do server stuff
		if ($Server::Hosting && !$Server::_Dedicated) {
			//Branch this out to a function so we don't have a PlayGui.cs 2.0
			Time::advance(%delta);

			if ($Server::MovingObjectsActive) {
				//Moving objects
				updateServerMovingObjects(%delta);
				updateServerParentedObjects(%delta);
			}

			Mode::callback("onFrameAdvance", "", %delta);
			serverCbOnFrameAdvance(%delta);
		}
	}
};

activatePackage(ServerTime);

//Independent or shared clock
function shouldUseIndividualClocks() {
	return ($Server::ServerType $= "MultiPlayer") && $Game::IsMode["race"];
}

function Time::advance(%delta) {
	//Some modes run the timer backwards
	%mult = ClientMode::callback("timeMultiplier", 1);

	//Raw total time
	$Time::TotalTime = add64_int($Time::TotalTime, %delta);

	//Only update display time when the timer runs
	if ($Time::TimerRunning) {
		//Elapsed time includes time travel
		$Time::ElapsedTime = add64_int($Time::ElapsedTime, %delta);

		if (shouldUseIndividualClocks()) {
			//Each client eats their own bonus time and advances their own clock
			%count = ClientGroup.getCount();
			for (%i = 0; %i < %count; %i ++) {
				%client = ClientGroup.getObject(%i);
				if (%client.spectating)
					continue;
				%client.advanceClock(%delta, %mult);
			}
			return;
		}

		//Take off any bonus time from our final time
		if ($Time::BonusTime != 0) {
			if ($Time::BonusTime > %delta) {
				$Time::TotalBonus += %delta;
				$Time::BonusTime -= %delta;
				%delta = 0;
			} else {
				$Time::TotalBonus += $Time::BonusTime;
				%delta -= $Time::BonusTime;
				$Time::BonusTime = 0;
			}
		}

		//Current time should factor bonuses into it
		$Time::CurrentTime = add64_int($Time::CurrentTime, %delta * %mult);

		// Some sanity checking
		if ($Time::CurrentTime > 5999999)
			$Time::CurrentTime = 5999999;

		//If the game is running, we're not restarting
		if ($Time::CurrentTime > 0)
			$MP::Restarting = false;

		//Time is over
		if ($Time::CurrentTime <= 0 && !$Editor::Opened) {
			//Add the negative overflow (so this subtracts from elapsed)
			$Time::ElapsedTime += $Time::CurrentTime;
			//And reset to zero
			$Time::CurrentTime = 0;

			//Don't call this if we're restarting; that makes an infinite loop
			if (!$MP::Restarting) {
				//Let the mode decide if we want to do something special
				if (Mode::callback("onTimeExpire", (%mult <= 0))) {
					//Normally just end the game
					endGameSetup();
				}
			}
		}
	}
}

// Advance clock of an individual client
function GameConnection::advanceClock(%this, %delta, %mult) {
	if (%this.bonusTime > 0) {
		if (%this.bonusTime > %delta) {
			%this.totalBonus += %delta;
			%this.bonusTime -= %delta;
			%delta = 0;
		} else {
			%this.totalBonus += %this.bonusTime;
			%delta -= %this.bonusTime;
			%this.bonusTime = 0;
		}
	}

	%this.clockTime = add64_int(%this.clockTime, %delta * %mult);

	if (%this.clockTime > 5999999)
		%this.clockTime = 5999999;
	if (%this.clockTime < 0)
		%this.clockTime = 0;
}

//Sync all clients' times
function Time::sync() {
	syncClients();
}

//Basic time functions
function Time::set(%time) {
	$Time::CurrentTime = %time;
	//Update all clients
	ClientGroup.forEach("%this.setTime", %time);
	Time::sync();
}

function Time::start() {
	$Time::TimerRunning = true;
	//Update all clients
	ClientGroup.forEach("%this.startTimer");
	Time::sync();
}

function Time::stop() {
	$Time::TimerRunning = false;
	//Update all clients
	ClientGroup.forEach("%this.stopTimer");
	Time::sync();
}

function Time::reset() {
	$Time::CurrentTime = Mode::callback("getStartTime", 0);
	$Time::BonusTime = 0;
	$Time::TotalBonus = 0;
	$Time::ElapsedTime = 0;
	$Time::TimerRunning = false;
	$Time::TotalTime = 0;

	if (shouldUseIndividualClocks()) {
		%count = ClientGroup.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%client = ClientGroup.getObject(%i);
			%client.clockTime = $Time::CurrentTime;
			%client.bonusTime = 0;
			%client.totalBonus = 0;
		}
	}

	//Update all clients
	ClientGroup.forEach("%this.resetTimer");
	Time::sync();
}

function Time::addBonusTime(%time) {
	$Time::BonusTime += %time;
	if (%time < 0) {
		Time::advance(0);
	}
	//Update all clients
	ClientGroup.forEach("%this.addBonusTime", %time);
	Time::sync();
}

function Time::setBonusTime(%time) {
	$Time::BonusTime = 0;
	//Update all clients
	Time::sync();
}

//--------------------------------------------------------------------------
// Sync the clock on the client.

/**
 * @param {NetConnection} %client
 */
function GameConnection::syncClock(%client, %time, %bonus, %total) {
	%individual = shouldUseIndividualClocks();
	if (%time $= "")
		%time = %individual ? %client.clockTime : $Time::CurrentTime;
	if (%bonus $= "")
		%bonus = %individual ? %client.bonusTime : $Time::BonusTime;
	if (%total $= "")
		%total = $Time::TotalTime;

	//Is the clock going?
	%running = $Time::TimerRunning;
	//Send them their ping so they can account for lag
	%ping = %client.getPing();
	commandToClient(%client, 'syncClock', %running, %time, %bonus, %total, %ping);
}


function syncClients() {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.syncClock();
	}
}

function formatTime(%time, %tab) {
	%isNeg = (%tab ? "\t" : "");
	if (%time < 0) {
		%time = -%time;
		%isNeg = (%tab ? "\t-" : "-");
	}
	%hundredth = div64_int(mod64_int(%time, 1000), 10);
	%totalSeconds = div64_int(%time, 1000);
	%seconds = %totalSeconds % 60;
	%minutes = (%totalSeconds - %seconds) / 60;

	%secondsOne   = %seconds % 10;
	%secondsTen   = (%seconds - %secondsOne) / 10;
	%minutesOne   = %minutes % 10;
	%minutesTen   = (%minutes - %minutesOne) / 10;
	%hundredthOne = %hundredth % 10;
	%hundredthTen = (%hundredth - %hundredthOne) / 10;

	if ($pref::Thousandths) {
		return %isNeg @ %minutesTen @ %minutesOne @ ":" @
		       %secondsTen @ %secondsOne @ "." @
		       %hundredthTen @ %hundredthOne @(%time % 10);
	} else {
		return %isNeg @ %minutesTen @ %minutesOne @ ":" @
		       %secondsTen @ %secondsOne @ "." @
		       %hundredthTen @ %hundredthOne;
	}
}

function formatTimeSeconds(%time, %tab) {
	%isNeg = (%tab ? "\t" : "");
	if (%time < 0) {
		%time = -%time;
		%isNeg = (%tab ? "\t-" : "-");
	}
	%totalSeconds = div64_int(%time, 1000);
	%seconds = %totalSeconds % 60;
	%minutes = (%totalSeconds - %seconds) / 60;

	%secondsOne   = %seconds % 10;
	%secondsTen   = (%seconds - %secondsOne) / 10;
	%minutesOne   = %minutes % 10;
	%minutesTen   = (%minutes - %minutesOne) / 10;

	return %isNeg @ %minutesTen @ %minutesOne @ ":" @
	       %secondsTen @ %secondsOne;
}

function formatTimeHours(%time) {
	%hours = div64_int(%time, 3600);

	%minutes = div64_int(%time, 60) - (%hours * 60);
	%seconds = %time % 60;

	%secondsOne   = %seconds % 10;
	%secondsTen   = div64_int(%seconds, 10);
	%minutesOne   = %minutes % 10;
	%minutesTen   = div64_int(%minutes, 10);
	%hoursOne	  = %hours % 10;
	%hoursTen     = div64_int(%hours, 10);

	return %hoursTen @ %hoursOne @ ":" @
	       %minutesTen @ %minutesOne @ ":" @
	       %secondsTen @ %secondsOne;
}

function formatTimeHoursMs(%time) {
	%hours = div64_int(%time, 3600000);
	%minutes = div64_int(mod64_int(%time, 3600000), 60000);
	%seconds = div64_int(mod64_int(%time, 60000), 1000);
	%thousandths = mod64_int(%time, 1000);

	%secondsOne   = %seconds % 10;
	%secondsTen   = mFloor(%seconds / 10);
	%minutesOne   = %minutes % 10;
	%minutesTen   = mFloor(%minutes / 10);
	%hoursOne	  = %hours % 10;
	%hoursTen     = mFloor(%hours / 10);
	%thousandthsOne = %thousandths % 10;
	%thousandthsTen = mFloor((%thousandths % 100) / 10);
	%thousandthsHun = mFloor(%thousandths / 100);

	%result = (%hours > 0 ? (%hoursTen > 0 ? %hoursTen : "") @ %hoursOne @ ":" : "") @
	          %minutesTen @ %minutesOne @ ":" @
	          %secondsTen @ %secondsOne @ "." @
	          %thousandthsHun @ %thousandthsTen;
	if ($pref::Thousandths)
		%result = %result @ %thousandthsOne;

	return %result;
}

function formatTimeDays(%time) {
	%days = $pref::TotalTimerDaysAdd;
	%hours = mFloor(%time / 3600);
	%minutes = mFloor(%time / 60) - (%hours * 60);
	%seconds = %time - (%minutes * 60) - (%hours * 3600);

	%secondsOne   = %seconds % 10;
	%secondsTen   = mFloor(%seconds / 10);
	%minutesOne   = %minutes % 10;
	%minutesTen   = mFloor(%minutes / 10);
	%hoursOne	  = %hours % 10;
	%hoursTen     = mFloor(%hours / 10);
	%daysOne	  = %days % 10;
	%daysTen      = mFloor(%days / 10);

	return %daysTen @ %daysOne @ ":" @
	       %hoursTen @ %hoursOne @ ":" @
	       %minutesTen @ %minutesOne @ ":" @
	       %secondsTen @ %secondsOne;
}