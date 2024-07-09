//-----------------------------------------------------------------------------
// Multiplayer Package
// clientDownload.cs
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

function clientCmdCanDownloadMission(%file, %status) {
	$MP::DownloadMissionAvailable[%file] = %status;
	PlayMissionGui.updateMPButtons();

	if ((!$Server::Hosting || $Server::_Dedicated) && !$MP::DownloadMissionAvailable[$MP::MissionFile]) {
		RootGui.popDialog(MPDownloadDlg);
	}
}

// incoming new mission file, set-up/reset variables.
function clientCmdFileDownloadStart(%seq, %file, %packets) {
	$DownloadFileFile[%seq]    = %file;
	$DownloadFilePackets[%seq] = %packets;
	$DownloadFileData[%seq]    = "";

	$DownloadFileNameLength[%seq] = textLen(fileBase(%file) @ fileExt(%file), $DefaultFont, 24);

	MPDownloadDlg.downloadStart();
}

// upon receiving a chunk of the mission file.
function clientCmdFileDownloadChunk(%seq, %chunk, %packet) {
	$DownloadFileData[%seq] = $DownloadFileData[%seq] @ %chunk;

	%recv = strlen($DownloadFileNameLength[%seq]);
	%total = $DownloadFilePackets[%seq] * 255;
	%file = $DownloadFileFile[%seq];

	if ($downloadStart[%file] $= "" || %recv < $downloadCurrent[%file])
		$downloadStart[%file] = getRealTime();

	$downloadCurrent[%file] = %recv;

	%rateS = (getRealTime() - $downloadStart[%file]) / 1000;
	%rate = %recv / %rateS;

	%estimated = ((getRealTime() - $downloadStart[%file]) / (%recv / %total)) - (getRealTime() - $downloadStart[%file]);

	if ($GuiPack::Active) {
		$GuiPack::CurrentPack.MPDownloadDlg.onFileDownloadChunk(%file, %recv, %total, %seq, %estimated);
	} else {
		MPDC_Info.setText(shadow("1 1", "0000007f") @ "<color:ffffff><font:24><just:center>Receiving" SPC fileBase(%file) @ fileExt(%file) SPC "-" SPC mFloor((100 * %recv) / %total) @ "%" @($DownloadFileNameLength[%seq] < 270 ? " (" @($DownloadFileNameLength[%seq] < 200 ? (mFloor(%recv / 100) / 10) @ "/" @(mFloor(%total / 100) / 10) SPC "kB, " : "") @ mFloor(%rate / 100) / 10 SPC "kB/s)" : "") @($DownloadFileNameLength[%seq] < 320 ? " " @ getSubStr(formatTimeSeconds(%estimated), 1, 999) : ""));
	}
}

function clientCmdFileDownloadEnd(%seq) {
	// decode the data and write it out!
	%data = decodeMission($DownloadFileFile[%seq], $DownloadFileData[%seq]);

	MPDownloadDlg.downloadFinish();
	PlayMissionGui.updateMPButtons();
}

// if it could not send, inform the client
function clientCmdFileDownloadError(%file) {
	MPDownloadDlg.downloadError();
}

function clientCmdRequireDif(%file, %dif) {
	commandToServer('DifExists', %file, %dif, isFile(%dif));
}