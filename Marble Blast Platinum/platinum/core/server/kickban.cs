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

//-----------------------------------------------------------------------------

function kick(%client) {
	// Tell people
	messageAll('MsgAdminForce', '\c2The Host has kicked %1.', %client.getDisplayName());
	commandToAllExcept(%client, 'PrivateMessage', LBChatColor("lagout") @ "The Host has kicked" SPC %client.getDisplayName());

	//Schedule an update to load so we don't prevent others from playing
	schedule(101, 0, checkAllClientsLoaded);

	// Kick them
	%client.schedule(100, delete, "CR_KICK");

	// Fix the interface
	updatePlayerlist();
	commandToAll('FixGhost');

	MPPlayersDlg.updatePlayerList();
}

function ban(%client) {
	// Tell people
	messageAll('MsgAdminForce', '\c2The Host has banned %1.', %client.getDisplayName());
	commandToAllExcept(%client, 'PrivateMessage', LBChatColor("lagout") @ "The Host has banned" SPC %client.getDisplayName());

	// Add them to the ban list
	if (!%client.isAIControlled()) {
		tryCreateBanlist();

		// Add their name and IP (we're going serious here)
		BanList.addEntry(%client.getUsername() TAB %client.getAddress());
		saveBanlist();
	}

	//Schedule an update to load so we don't prevent others from playing
	schedule(101, 0, checkAllClientsLoaded);

	// Kick them as well :D
	%client.schedule(100, delete, "CR_BAN");

	// Pretty some things up
	updatePlayerlist();
	commandToAll('FixGhost');

	MPPlayersDlg.updatePlayerList();
}

function unban(%player) {
	// If you don't have a banlist, why are you unbanning people. Moreover,
	// HOW are you unbanning people?
	tryCreateBanlist();

	// Try to remove them if they're a player
	if (BanList.containsEntryAtField(%player, 0))
		BanList.removeEntryByIndex(Banlist.getIndexByField(%player, 0));

	// Try to remove them if they're an IP
	if (BanList.containsEntryAtField(%player, 1))
		BanList.removeEntryByIndex(Banlist.getIndexByField(%player, 1));

	// Well, we tried :(

	// Pretend it's ok
	MPPlayersDlg.updatePlayerList();
}

function loadBanlist() {
	// Try to load from the file
	%fo = new FileObject();
	if (!%fo.openForRead($MP::BanlistFile)) {
		// No ban list, let's just create a new one
		error("Could not open ban list - creating a new one!");

		// Reset this if it exists
		createDefaultBanlist();

		// Clean up
		%fo.close();
		%fo.delete();
		return;
	}

	// Reset this if it exists
	createDefaultBanlist();

	// Read in the banlist, adding the entries
	while (!%fo.isEOF()) {
		%line = %fo.readLine();
		BanList.addEntry(%line);
	}

	// Clean up
	%fo.close();
	%fo.delete();
}

function saveBanlist() {
	// If we have no banlist, why are we saving it? I don't know. Just
	// make one exist so we don't throw an error.
	tryCreateBanlist();

	// Try to open the file
	%fo = new FileObject();
	if (!%fo.openForWrite($MP::BanlistFile)) {
		// If this happens, you won't be able to save your bans :(
		error("Could not write to ban list file! Banlist will not be saved!");

		// Clean up
		%fo.close();
		%fo.delete();
		return;
	}

	// Write out each ban
	for (%i = 0; %i < BanList.getSize(); %i ++) {
		%fo.writeLine(BanList.getEntry(%i));
	}

	// Clean up
	%fo.close();
	%fo.delete();
}

function tryCreateBanlist() {
	if (!isObject(BanList))
		createDefaultBanlist();
}

function createDefaultBanlist() {
	// Delete the old one
	if (isObject(BanList))
		BanList.delete();
	Array(BanList);

	// Add game-wide global bans here
	// BanList.addEntry("BlazerYO");
	// BanList.addEntry("Luke Skywalker");
	// BanList.addEntry("Robot Marble");
	// BanList.addEntry("Tech Geek");
	// BanList.addEntry("Matan Weissman");
	// BanList.addEntry("Matthieu Parizeau");
	// BanList.addEntry("Trace");
	// BanList.addEntry("*");
	// BanList.addEntry("x.x.x.x"); // historical note: this used to be matan's ip
	// BanList.addEntry("0.0.0.0/16");
	// BanList.addEntry("127.0.0.1");
	// BanList.addEntry("192.168.*.*");
	// BanList.addEntry("10.0.*.*");
	// BanList.addEntry("25.*.*.*");
	// BanList.addEntry("8.8.4.4");

	// Damn I can't wait for someone to find this list in CURRENT_YEAR
	// Hello person, looking at the PQ source code! What do you think?
	// Did you know that this entire feature doesn't work and never did?
}
