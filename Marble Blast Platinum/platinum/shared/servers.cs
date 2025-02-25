// File that handles the leaderboards server thing and shit

function loadServerInfo() {
	echo("Reading the online server connection details");
	%conts = jsonParse(fread("platinum/serverconfig.json"));
	$LBServerInfo::PQServer = %conts.PQServer;
	$LBServerInfo::webchatServer = %conts.webchatServer;
	$LBServerInfo::mpMasterServer = %conts.mpMasterServer;
}

loadServerInfo();