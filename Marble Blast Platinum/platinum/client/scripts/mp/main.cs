//------------------------------------------------------------------------------
// Multiplayer Package: Iteration 7
// main.cs
// Because this is totally possible, we're totally doing it... AGAIN :D
// Created: 1/1/13 (yay 2013)
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

function initMultiplayer() {
	// All the client commands
	exec("./commands.cs");

	// Items that have methods delt client side
	exec("./items.cs");

	// Client marble stuff
	exec("./marble.cs");

	// Lobby code for clients
	exec("./lobby.cs");

	// Callbacks on the client-side
	exec("./callbacks.cs");

	// Ghosting for client-side
	exec("./ghost.cs");

	// client particles
	exec("./particles.cs");

	// client spectating
	exec("./spectator.cs");

	// Score list stuff
	exec("./scores.cs");

	// client download of mission files
	exec("./download.cs");

	// Server chat and other things
	exec("./chat.cs");

	// nametags
	exec("./nametag.cs");

	// Sync objects
	exec("./sync.cs");

	// Direct connect dialog
	if ($MP::EnableDirectConnect)
		exec("~/client/ui/mp/MPDirectConnectDlg.gui");

	// PRE GAME DIALOG
	exec("~/client/ui/mp/MPPreGameDlg.gui");

	// Join server GUI
	exec("~/client/ui/mp/MPJoinServerDlg.gui");

	// Team select dialog
	exec("~/client/ui/mp/MPTeamSelectDlg.gui");

	// Team join dialog
	exec("~/client/ui/mp/MPTeamJoinDlg.gui");

	// Team create dialog
	exec("~/client/ui/mp/MPTeamCreateDlg.gui");

	// Team options dialog
	exec("~/client/ui/mp/MPTeamOptionsDlg.gui");

	// Team invite dialog
	exec("~/client/ui/mp/MPTeamInviteDlg.gui");

	// Score overlay dialog
	exec("~/client/ui/mp/MPScoresDlg.gui");

	// Server information dialog
	exec("~/client/ui/mp/MPServerDlg.gui");

	// Dedicated Server settings dialog
	exec("~/client/ui/mp/MPDedicatedServerDlg.gui");

	// Dedicated Server players dialog
	exec("~/client/ui/mp/MPDedicatedPlayersDlg.gui");

	// End game screen
	exec("~/client/ui/mp/MPEndGameDlg.gui");

	// Kick Screen
	exec("~/client/ui/mp/MPPlayersDlg.gui");

	// Exit Game Screen
	exec("~/client/ui/mp/MPExitGameDlg.gui");

	// Download dialog
	exec("~/client/ui/mp/MPDownloadDlg.gui");

	// Gamemode customization
	exec("~/client/ui/mp/MPCustomizeMatchDlg.gui");

	// Poll creation dialog
	exec("~/client/ui/mp/MPPollCreateDlg.gui");

	// Poll dialog
	exec("~/client/ui/mp/MPPollDlg.gui");

	//Lists that are used everywhere
	Array(PlayerList);

	// Mode customization
	loadModeSettings();
}
