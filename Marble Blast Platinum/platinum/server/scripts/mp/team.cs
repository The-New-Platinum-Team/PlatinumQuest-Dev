//------------------------------------------------------------------------------
// Multiplayer Package
// team.cs
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
// Team Creation and deletion
//-----------------------------------------------------------------------------

// Creates a new team with name %name with the leader %leader. If
// %permanent is set, then the team will be registered as a default (permanent)
// team, and will not be deleted when it has 0 players. If %private is set, then
// only the team leader or server host can add players to the team.
//
// Variables:
// %name        - String
// %leader      - GameConnection
// %permanent   - Boolean
// %private     - Boolean
// %description - String
// %color       - Integer
//
// Returns:
// <id>  of the team if team creation was successful
// false if there was an error

function Team::createTeam(%name, %leader, %permanent, %private, %description, %color) {
	// Always want to make sure that these exist
	Team::check();

	// If the team already exists with that name, it can't be created twice
	if (Team::getTeam(%name) != -1)
		return false;

	// Resolve the leader
	if (!isObject(%leader) && !isObject(%leader = nameToId(%leader)) && (%leader = GameConnection::resolveName(%leader)) == -1)
		return false;

	// Create a new SimSet for the team object and set its fields
	TeamGroup.add(%newTeam = new SimSet(TeamSet));
	%newTeam.name      = %name;
	%newTeam.number    = $MP::Teams;
	%newTeam.leader    = %leader;
	%newTeam.permanent = %permanent;
	%newTeam.private   = %private;
	%newTeam.desc      = %description;
	%newTeam.color     = %color;

	// Increment the total team counter
	$MP::Teams ++;

	// Add the leader to their new team
	Team::addPlayer(%newTeam, %leader);

	// Update the master team list
	updateTeams();

	return %newTeam;
}

// Deletes a specified team with name %name.
// Note that if %team is the default team, there may be an explosion. Please
// use precaution when deleting permanent teams, as this method does not protect
// against that.
//
// Variables:
// %name - String
//
// Returns:
// true  if team deletion was successful
// false if there was an error

function Team::deleteTeam(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// Take all the players out of this team
	%count = %team.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%player = %team.getObject(%i);

		// And add them to the default team
		Team::addPlayer(Team::getDefaultTeam(), %player);
	}

	// If it hasn't been deleted already
	if (isObject(%team))
		%team.delete();

	// Update the master team list
	updateTeams();

	return true;
}

//-----------------------------------------------------------------------------
// Modifying Team Player Lists
//-----------------------------------------------------------------------------

// Adds the player %player to the team %newTeam. They will be removed from
// any teams they currently are in, and will become leader of any teams with
// zero players.
//
// Variables:
// %newTeam - SimSet
// %player  - GameConnection
//
// Returns:
// true  if the player was added to the team
// false if there was an error

function Team::addPlayer(%newTeam, %player) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %newTeam to be a SimSet team instance or fail
	if (!isObject(%newTeam) && (%newTeam = Team::getTeam(%newTeam)) == -1)
		return false;

	// Resolve the player
	if (!isObject(%player) && !isObject(%player = nameToId(%player)) && (%player = GameConnection::resolveName(%player)) == -1)
		return false;

	// Don't join a team we're already part of
	if (%newTeam.isMember(%player))
		return;

	// Don't recurse!
	if (%player.adding)
		return false;

	%player.adding = true;

	// Make sure they're not on any other teams
	%count = TeamGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%team = TeamGroup.getObject(%i);

		if (%team.isMember(%player)) {
			// They're on another team!
			// If they're the leader, we may have problems

			if (%team.getId() == %newTeam.getId()) {
				// They just tried to add themselves to the same team...
				// We'll just set a thing or two to make sure, because SimSets
				// can't have duplicates

				%newTeam.add(%player);
				%player.team = %newTeam.getId();
				continue;
			}

			// Take them out of this team, regardless of if they were the
			// leader or not
			Team::removePlayer(%team, %player);

			// If they were the last player, their team will have been
			// deleted. We need to account for this
			%newCount = TeamGroup.getCount();
			if (%newCount < %count) {
				%i -= %count - %newCount;
				%count = %newCount;
			}
		}
	}

	%player.adding = false;

	if (%newTeam.getCount() == 0) {
		Team::setTeamLeader(%player);
	}

	// At this point, they should be ready to add to their new team
	%newTeam.add(%player);
	%player.team = %newTeam.getId();
	commandToClient(%player, 'TeamJoin', %newTeam.name);
	commandToTeam(%newTeam, 'TeamMessage', %player.getDisplayName() SPC "has joined the team.");

	// Send it out
	updateTeams();

	return true;
}

// Removes the player %player from the team %team. If they were the leader
// of the team, then the second person on the team becomes leader. If the team
// is left with zero players, it will be deleted unless it is the default team.
//
// Variables:
// %team   - SimSet
// %player - GameConnection
//
// Returns:
// true  if the player was removed from the team
// false if there was an error

function Team::removePlayer(%team, %player) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// Resolve the player
	if (!isObject(%player) && !isObject(%player = nameToId(%player)) && (%player = GameConnection::resolveName(%player)) == -1)
		return false;

	// Can't leave a team we're not part of
	if (!%team.isMember(%player))
		return;

	// Take %player out of %team, and remove %team if it has no players
	%team.remove(%player);
	commandToClient(%player, 'TeamLeave', %team.name);
	commandToTeam(%newTeam, 'TeamMessage', %player.getDisplayName() SPC "has left the team.");

	// Add them to the default team so we don't get any errors
	Team::addPlayer(Team::getDefaultTeam(), %player);

	// If we're removing the team leader, we have to find a new leader
	if (%team.leader.getId() == %player.getId()) {
		Team::resolveLeader(%team);
	}

	// It's that easy
	if (%team.getCount() == 0) {
		// Leader is removed, incase this is the default team and it won't
		// be destroyed
		%team.leader = "";

		// Don't delete the default team! Then we wouldn't have anywhere to
		// dump people who have their team deleted.
		if (%team.permanent)
			return false;

		Team::deleteTeam(%team);
	}

	// Send it out
	updateTeams();

	return true;
}

//-----------------------------------------------------------------------------
// Accessing Teams
//-----------------------------------------------------------------------------

// Access to the team with the name %teamName, or -1 if no team with that
// name currently exists.
//
// Variables:
// %teamName - String
//
// Returns:
// <id> of the team with the given name
// -1   if no team with that name exists

function Team::getTeam(%teamName) {
	// Always want to make sure that these exist
	Team::check();

	// Now why would you be sending a whole team?
	if (isObject(%teamName))
		return %teamName;

	// Iterate through the list and return the matching team
	%count = TeamGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%team = TeamGroup.getObject(%i);
		if (%team.name $= %teamName)
			return %team.getId();
	}

	// If none exist, return -1
	return -1;
}

// Access to the default team, or the first permanent team.
//
// Returns:
// <id> of the default team or the first permanent team
// -1   if no permanent teams exist

function Team::getDefaultTeam() {
	// Always want to make sure that these exist
	Team::check();

	// Iterate through the list and return the first permanent team.
	// Technically, only the default team should be permanent, but in the event
	// that someone *really* likes their team, then they should be allright with
	// random people accidentally joining them.

	%count = TeamGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%team = TeamGroup.getObject(%i);
		if (%team.permanent)
			return %team.getId();
	}

	// If none exist, return -1
	return -1;
}

//-----------------------------------------------------------------------------
// Player / Team Information
//-----------------------------------------------------------------------------

// Access to the team that the player %player is part of.
//
// Variables:
// %player - GameConnection
//
// Returns:
// <id>  of the team that the player is in
// -1    if the player is not on a team
// false if there was an error

function Team::getPlayerTeam(%player) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve the player
	if (!isObject(%player) && !isObject(%player = nameToId(%player)) && (%player = GameConnection::resolveName(%player)) == -1)
		return false;

	// Iterate through the list and return the matching team
	%count = TeamGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%team = TeamGroup.getObject(%i);
		if (%team.isMember(%player))
			return %team.getId();
	}

	return -1;
}

// Access to the name of %team.
//
// Variables:
// %team - SimSet
//
// Returns:
// <string> of the team name
// false    if there was an error

function Team::getTeamName(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	return %team.name;
}

// Changes the name of %team to %name.
//
// Variables:
// %team - SimSet
// %name - String
//
// Returns:
// true  if the name was changed
// false if there was an error

function Team::setTeamName(%team, %name) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// Can't be having two teams with the same name!
	if (Team::getTeam(%name) != -1 && Team::getTeam(%name).getId() != %team.getId())
		return false;

	// Can't set a blank name
	if (trim(%name) $= "")
		return false;

	if (%name !$= %team.name)
		commandToTeam(%team, 'TeamMessage', "The team name has been changed to \"" @ %name @ "\".");

	// Simple set
	%team.name = %name;

	// Send it out
	updateTeams();

	return true;
}

// Access to the description of %team.
//
// Variables:
// %team - SimSet
//
// Returns:
// <string> of the team description
// false    if there was an error

function Team::getTeamDescription(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	return %team.desc;
}

// Changes the description of %team to %description.
//
// Variables:
// %team        - SimSet
// %description - String
//
// Returns:
// true  if the description was changed
// false if there was an error

function Team::setTeamDescription(%team, %description) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// Simple set
	%team.desc = %description;

	// Send it out
	updateTeams();

	return true;
}

// Access to the team color of %team. The team color is
// stored as an integer to the color (see color list) that all players on the
// team are shown with.
//
// Variables:
// %team - SimSet
//
// Returns:
// <int> of the team color
// false if there was an error

function Team::getTeamColor(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	return %team.color;
}

// Changes the team color of %team to %color.
//
// Variables:
// %team  - SimSet
// %color - Integer
//
// Returns:
// true  if the color was changed
// false if there was an error

function Team::setTeamColor(%team, %color) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// Simple set
	%team.color = %color;

	// Send it out
	updateTeams();

	return true;
}

// Access to the score of %team.
//
// Variables:
// %team - SimSet
//
// Returns:
// <int> The score of the team

function Team::getTeamScore(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	%score = 0;
	%players = %team.getCount();
	for (%i = 0; %i < %players; %i ++)
		%score += %team.getObject(%i).gemCount;

	return %score;
}

// Access to the place of %team.
//
// Variables:
// %team - SimSet
//
// Returns:
// <int> The score of the team

function Team::getTeamPlace(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	%place = 1;
	for (%i = 0; %i < TeamGroup.getCount(); %i ++) {
		%tteam = TeamGroup.getObject(%i);
		if (%tteam.getId() == %team.getId())
			continue;
		if (Team::getTeamScore(%tteam) > Team::getTeamScore(%team))
			%place ++;
	}

	return %place;
}

// Access to the private status of %team.
//
// Variables:
// %team - SimSet
//
// Returns:
// true  if the team is private
// false if the team is public or if there was an error

function Team::getTeamPrivate(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	return %team.private;
}

// Changes the private status of %team to %description.
//
// Variables:
// %team    - SimSet
// %private - Boolean
//
// Returns:
// true  if the private status was changed
// false if there was an error

function Team::setTeamPrivate(%team, %private) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	if (%private != %team.private)
		commandToTeam(%newTeam, 'TeamMessage', "This team is now" SPC (%private ? "private" : "public") @ ".");

	// Simple set
	%team.private = %private;

	// Send it out
	updateTeams();

	return true;
}

// Easy knowledge of whether %team is a default team
//
// Variables:
// %team - SimSet
//
// Returns:
// true  if that team is a default team
// false if it is not a default team, or if there was an error

function Team::isDefaultTeam(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	return %team.permanent;
}

function Team::getTeamRole(%team, %player) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// Resolve the player
	if (!isObject(%player) && !isObject(%player = nameToId(%player)) && (%player = GameConnection::resolveName(%player)) == -1)
		return false;

	if (Team::isTeamLeader(%team, %player))
		return $MP::TeamLeaderRoleName;
	if (%player.team.getId() != %team.getId())
		return $MP::TeamUnaffiliatedRoleName;
	return $MP::TeamGeneralRoleName;
}

//-----------------------------------------------------------------------------
// Team Leader
//-----------------------------------------------------------------------------

// Changes the leader of %team to %newLeader, keeping the old leader in
// the team, but removing their leader status.
//
// Variables:
// %team      - SimSet
// %newLeader - GameConnection
//
// Returns:
// true  if the leader was changed
// false if there was an error

function Team::setTeamLeader(%team, %newLeader) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// Resolve the player
	if (!isObject(%newLeader) && !isObject(%newLeader = nameToId(%newLeader)) && (%newLeader = GameConnection::resolveName(%newLeader)) == -1)
		return false;

	// Simple set
	%team.leader = %newLeader.getId();

	// Send it out
	updateTeams();

	return true;
}

// Access to the leader of %team.
//
// Variables:
// %team - SimSet
//
// Returns:
// <id>  of the team leader
// false if there was an error

function Team::getTeamLeader(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	return %team.leader;
}

// Easy knowledge of whether %player is the leader of %team.
//
// Variables:
// %team   - SimSet
// %player - GameConnection
//
// Returns:
// true  if that player is the leader of that team
// false if they are not the leader, or if there was an error

function Team::isTeamLeader(%team, %player) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// Resolve the player
	if (!isObject(%player) && !isObject(%player = nameToId(%player)) && (%player = GameConnection::resolveName(%player)) == -1)
		return false;

	if (!isObject(%team.leader)) {
		Team::resolveLeader(%team);
	}

	if (%player.getId() == %team.leader.getId())
		return true;
	return false;
}

// Fix a possibly unleadered team and set their leader to the next player
// if necessary. Permanent teams will always have their leader set as the local
// client.
//
// Variables:
// %team - SimSet
//
// Returns:
// true  if the leader was fixed
// false if there was an error
//

function Team::resolveLeader(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// If we already have a leader, then why are we resolving?
	if (isObject(%team.leader) && %team.leader.team == %team)
		return false;

	// The default team is owned by the local client
	if (%team.permanent) {
		Team::setTeamLeader(%team, ClientGroup.getObject(0));
		return true;
	}

	// We need to find the next leader for %team
	%newLeader = -1;

	// Iterate through
	%teamCount = %team.getCount();
	for (%j = 0; %j < %teamCount; %j ++) {
		%next = %team.getObject(%j);
		%newLeader = %next;
		break;
	}

	// If we found a new leader, let them rule
	if (%newLeader != -1) {
		Team::setTeamLeader(%team, %newLeader);
		commandToTeam(%team, 'TeamMessage', %newLeader.getDisplayName() SPC "is the new team leader.");
		return true;
	}

	return false;
}

//-----------------------------------------------------------------------------
// Message Sending
//-----------------------------------------------------------------------------

// Calls a method on all players on a team.
//
// Variables:
// %team   - SimSet
// %method - String
// %arg[]  - Unknown
//
// Returns:
// true  if the method was called on all players
// false if there was an error

function Team::call(%team, %method, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	%count = %team.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%player = %team.getObject(%i);

		// SimObject::call() is defined in platinum/main.cs
		%player.call(%method, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10);
	}

	return true;
}

//-----------------------------------------------------------------------------
// Helper functions
//-----------------------------------------------------------------------------

// Helper method that sets up team support variables. Should be called
// from every function in the Team:: namespace.
//
// Returns:
// nothing

function Team::check() {
	// Init some things that may not exist...
	// This makes sure that $MP::Teams is a number
	$MP::Teams += 0;

	// Create TeamGroup if it doesn't exist
	if (!isObject(TeamGroup))
		RootGroup.add(new SimGroup(TeamGroup));
}

// Helper method that fixes all loose ends on the teams system. Call as
// often as you want.
function Team::fix() {
	// Always want to make sure that these exist
	Team::check();

	// Make sure people have a team to join
	if ($MP::Teams == 0) {
		// Make a team for them
		%team = Team::createDefaultTeam();

		// If we just created the default team, then nobody has a team!
		%count = ClientGroup.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%client = ClientGroup.getObject(%i);
			Team::addPlayer(%team, %client);
		}
	}

	%default = Team::getDefaultTeam();

	// Make sure nobody is stranded without a team
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);

		// If your team does not exist, add you to the default team
		if (!isObject(%client.team))
			Team::addPlayer(%default, %client);
	}
}

// Resolves a GameConnection from a given name. Call this function from
// the GameConnection:: namespace, or if you want a lazy way to get the id, you
// can do <GameConnection object>.resolveName() to get its id.
//
// Variables:
// %name - String
//
// Returns:
// <id> of the client with the given name
// -1   if no clients with that name exist

function GameConnection::resolveName(%name) {
	// If we passed in a GameConnection, we just want the id
	if (isObject(%name) && %name.getClassName() $= "GameConnection")
		return %name.getId();

	// Iterate the list and check names
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.getUsername() $= %name)
			return %client.getId();
	}
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%client = ClientGroup.getObject(%i);
		if (%client.getDisplayName() $= %name)
			return %client.getId();
	}

	// Return -1 if no clients with %name are found
	return -1;
}

// Creates a default team in which unsorted players are added to, or
// simply returns the ID of the default team if it already exists.
//
// Returns:
// <id> of the default team

function Team::createDefaultTeam() {
	// Always want to make sure that these exist
	Team::check();

	if (Team::getDefaultTeam() != -1)
		return Team::getDefaultTeam();

	// Create the default team with a sample description and title.
	//
	// Default Team Settings:
	//
	// Name - Default Team
	// Leader - Local Client
	// Permanent - true
	// Private - false
	// Description - Default Team Description
	// Color - Any
	//
	return Team::createTeam($MP::DefaultTeamName, ClientGroup.getObject(0), true, false, $MP::DefaultTeamDesc, -1);
}

//-----------------------------------------------------------------------------
// Team Sorting
//-----------------------------------------------------------------------------

// Gets the general "strength" of a team based on its players' ratings.
//
// Variables:
// %team - The team to analyze
//
// Returns:
// <int> for the team strength
// <false> on failure
function Team::getTeamStrength(%team) {
	// Always want to make sure that these exist
	Team::check();

	// Resolve %team to be a SimSet team instance or fail
	if (!isObject(%team) && (%team = Team::getTeam(%team)) == -1)
		return false;

	// Empty teams have a strength of 1, the lowest
	if (%team.getCount() == 0)
		return 1;

	// Lowest is 1 because 0 sends as "false"
	%strength = 1;

	// Get the overall maximum and minimum ratings
	%maxRating = 0;
	%minRating = 9999;

	// Iterate through all clients
	%count = ClientGroup.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%player = ClientGroup.getObject(%i);

		// Get their rating
		%rating = %player.rating;

		// Check for min/max
		if (%rating > %maxRating)
			%maxRating = %rating;
		if (%rating < %minRating)
			%minRating = %rating;
	}

	// Go through each player in the team and get their rating
	%count = %team.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%player = %team.getObject(%i);

	}
}
