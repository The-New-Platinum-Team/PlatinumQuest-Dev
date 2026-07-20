//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Misc. server commands avialable to clients
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

/**
 * @param {GameConnection} %client
 */
function serverCmdSAD(%client, %password) {
	if (!(%client.isSuperAdmin && %client.isAdmin) && %password !$= "" && %password $= $Pref::Server::AdminPassword) {
		%client.isAdmin = true;
		%client.isSuperAdmin = true;
		%name = %client.getDisplayName();
		serverSendChat(LBChatColor("notification") @ %name @ " is now a Server Admin.");
	}
}
