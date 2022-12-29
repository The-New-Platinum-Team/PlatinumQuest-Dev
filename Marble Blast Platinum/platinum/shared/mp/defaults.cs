//------------------------------------------------------------------------------
// defaults.cs
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

// These values are set for proper gameplay, and cannot be changed by clients.

//-----------------------------------------------------------------------------
// Control
//-----------------------------------------------------------------------------

// MP Revision (only updated when changes to MP happen), probably reliable
$MP::RevisionOn = 10000;

echo("Initializing Multiplayer Scripts Revision" SPC $MP::RevisionOn);

//-----------------------------------------------------------------------------
// Update Times
//-----------------------------------------------------------------------------

// Calls fixGhost() on interval
$MP::ClientFixTime = 2000; //ms

// Server-side collision detection
$MP::Collision::Delta = 20; //ms

// Dampening for team hits
$MP::CollisionTeamDampen = 6;

//-----------------------------------------------------------------------------
// Collision
//-----------------------------------------------------------------------------

// "Nudges" players out of the way if they happen to collide
$MP::Collision::EnableNudge = false; //true/false

// "Clips" player meshes (sets them to non-collision) if two players collide
$MP::Collision::EnableClip = true; //true/false

$MP::Collision::Multiplier = 4;
$MP::Collision::Maximum = 25;
$MP::Collision::MegaMultiplier = 5;
$MP::Collision::MegaMaximum = 35;

//-----------------------------------------------------------------------------
// Blast
//-----------------------------------------------------------------------------

// Blast strength applied to surrounding players
$MP::BlastShockwaveStrength = 5;

// Blast Recharge - Blast strength applied to surrounding players
$MP::BlastRechargeShockwaveStrength = 10;

// Blast Impulse - Blast power, this is the amount of up-boost you get
// Higher values make the marbles go crazy. Default is 10
$MP::BlastPower = 10;

// Blast Recharge - Blast power
// Add just a bit power to our blast more if we collected Blast Recharge
$MP::BlastRechargePower = 1.03;

// Amount of blast bar filled (x / 1.0) required to use blast
$MP::BlastRequiredAmount = 0.2;

// Time required for blast to fully recharge from 0.0 - 1.0
$MP::BlastChargeTime = 25000;

// Normal blast divisor Default is 1 (lower = stronger)
$MP::NormalBlastModifier = 1.0;

// Mega blast divisor (lower values = more blasty)
$MP::MegaBlastModifier = 0.7;

//-----------------------------------------------------------------------------
// Teams
//-----------------------------------------------------------------------------

// The default team will have this name applied when it is created, and it
// cannot be changed by the leader.
$MP::DefaultTeamName = "Default Team";

// The default team will have this description applied when it is created, and
// it cannot be changed by the leader.
$MP::DefaultTeamDesc = "This is the default team. Any players who join the game or leave their team will be part of this team until they join another team. This team will not be deleted if it has zero players, and cannot be renamed.";

// The team description before it has been sent to the server
$MP::NewTeamDesc = "Incomplete team description.";

// Useful to stop crashing!
$MP::TeamDescMaxLength = 1024;

// Displayed role for the team's leader
$MP::TeamLeaderRoleName = "Leader";

// Displayed role for anyone not on a specific team
$MP::TeamUnaffiliatedRoleName = "If you see this, contact Platinum Team ASAP.";

// Displayed role for general team players
$MP::TeamGeneralRoleName = "Player";

//-----------------------------------------------------------------------------
// Misc
//-----------------------------------------------------------------------------

// Allow quickrespawn (backspace / tab key) in MP games
$MPPref::AllowQuickRespawn = true;

// Quick Respawn is disabled for this many ms after being used (to prevent
// abuse)
$MP::QuickSpawnTimeout = 25000;

// Enables the "direct connect" dialog in JoinServer
$MP::EnableDirectConnect = true;

// Server max players limits. Can't set MaxPlayers to anything outside this
// range.
$MP::PlayerMaximum = 64;
$MP::PlayerMinimum = 2;

// Enable scaling of radar gem icons based on height
$MPPref::RadarZ = true;

// Amount of segments to send loading in so that way I don't slow down
$MP::LoadSegments = 20;

// Overview time for a full 360° (seconds)
$MPPref::OverviewSpeed = 100;

// Overview finish time (seconds)
$MPPref::OverviewFinishSpeed = 0;

// Ban list file
$MP::BanlistFile = $usermods @ "/shared/mp/banlist.txt";

// So they can chat!
$MPPref::AllowServerChat = true;

// Back up clients
$MPPref::BackupClients = true;

// Client-sided powerups
$MPPref::FastPowerups = false;

//Allow snowballs for snowball levels
$MPPref::EnableSnowballs = true;

//Disable gems and only have snowballs
$MPPref::SnowballsOnly = false;

//Number of gems on the radar
$MPPref::MaxRadarItems = 25;

//Taunts for client and server
$MPPref::AllowTaunts = true;
$MPPref::Server::AllowTaunts = true;

//Flying ghosts for the halloween event
$MPPref::SpookyGhosts = true;

//Submit scores by default
$MPPref::Server::SubmitScores = true;

//Let other players pick up collected gems for this amount of time
$MPPref::Server::PingStealFix = 250;

//If we should spawn 2 groups of gems at once
$MPPref::Server::DoubleSpawnGroups = false;

//-----------------------------------------------------------------------------
// Prefs
//-----------------------------------------------------------------------------

function MPloadPrefs() {
	traceGuard();
		%file = expandFilename("./prefs.cs");
		if (isFile(%file)) {
			safeExecPrefs(%file);
		}
	traceGuardEnd();
}

function MPsavePrefs() {
	export("$MPPref::*", "./prefs.cs");
}

// Load em!
MPloadPrefs();
