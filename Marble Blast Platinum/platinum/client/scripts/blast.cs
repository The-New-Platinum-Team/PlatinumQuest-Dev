//-----------------------------------------------------------------------------
// Client sided blast information
// blast.cs
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

function shouldEnableBlast() {

	if ($Game::IsMode["challenge"]) {
		if ($CurrentWeeklyChallenge.blast || $CurrentWeeklyChallenge.tripleBlast)
			return true;
		if ($CurrentWeeklyChallenge.noBlast)
			return false;
	}

	if (MissionInfo.noBlast) { //Allow missions to disable blast in MP
		return false;
	}
	if (MissionInfo.blast) { //Allow missions to allow blast
		return true;
	}
	if ($Server::ServerType $= "Multiplayer") {
		if ($SpectateMode) { //Don't let people blast as a camera
			return false;
		}

		return true; //MP blast by default
	} else {
		if (MissionInfo.game $= "Ultra") { //All ultra missions should have blast
			return true;
		}
		
		if ($Game::IsMode["free"]) { //Free World allows blast by default
			return true;
		}

		return false; //SP no blast by default
	}
}

function shouldUpdateBlast() {
	return (shouldEnableBlast() && $PlayTimerActive) || //Only let them use blast when the time is running
	       ($Game::State !$= "End" && MissionInfo.game $= "Ultra" && $Server::ServerType $= "SinglePlayer") || //Unless they're in a MBU level
	       ClientMode::callback("shouldUpdateBlast", false); //Modes can say if they should update blast too
}

function clientUpdateBlast(%timeDelta) {
	if ($MP::TripleBlast) { // Do not increment it in triple-blast mode
		PlayGui.updateBlastIndicator();
		return;
	}
	
	// blast code update
	if ($Game::IsMode["challenge"] && $CurrentWeeklyChallenge.tripleBlast)
		$MP::BlastValue += (%timeDelta / 12000);
	else
		$MP::BlastValue += (%timeDelta / $MP::BlastChargeTime);
	if ($MP::BlastValue > 1)
		$MP::BlastValue = 1;
	if ($MP::BlastValue < 0)
		$MP::BlastValue = 0;
	PlayGui.setBlastValue($MP::BlastValue);
}

function performBlast() {
	%blastValue = ($MP::SpecialBlast ? $MP::BlastRechargePower : mSqrt($MP::BlastValue));
	if ((($Game::IsMode["challenge"] && $CurrentWeeklyChallenge.tripleBlast) || $MP::TripleBlast) && !$MP::SpecialBlast)
		%blastValue = $MP::TripleBlastPower;
		
	//Best results found when whacked from here
	%attack = "0 0 -1";

	//Confusing, but all this does is set the impulse
	//to the blast value shown * 10 and then adjusted
	//to the gravity (so we don't get blasted sideways
	//after a gravity modifier)
	%vector = %blastValue * -$MP::BlastPower;
	%vector = %vector SPC %vector SPC %vector;
	%gravity = getGravityDir();
	%push = VectorMult(%vector, %gravity);

	//Get the local marble, as impulsing the server one
	//will reset the camera angle; we don't want that
	$MP::MyMarble.applyImpulse(%attack, %push);

	// tell the server to make the particle and to also
	// send the shockwave
	commandToServer('Blast', $Game::GravityRot);

	//Finally, reset
	PG_BlastBar.setValue(0);
	$MP::BlastValue = 0;

	$Game::LastBlast = $Sim::Time;

	$Demo::Blasts ++;
	$Demo::Blast[$Demo::Blasts] = PlayGui.currentTime + PlayGui.totalBonus;
	$Demo::BlastStr[$Demo::Blasts] = %attack TAB %push;
}