//-----------------------------------------------------------------------------
// Copyright (c) 2023 The Platinum Team
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

$RtaSpeedrun::IsEnabled = false;
$RtaSpeedrun::IsTiming = false;
$RtaSpeedrun::IsDone = false;
$RtaSpeedrun::Time = 0;
$RtaSpeedrun::EndMission = "";
$RtaSpeedrun::LastSplitTime = -1;

package rtaSpeedrunFrameAdvance {
	function onFrameAdvance(%timeDelta) {
		if ($RtaSpeedrun::IsTiming && !($Client::Loading || $Game::Loading || $Menu::Loading)) {
			$RtaSpeedrun::Time += %timeDelta;
			RtaSpeedrunUpdateTimers();
		}
	}
};
activatePackage(rtaSpeedrunFrameAdvance);

function RtaSpeedrunUpdateTimers() {
	%text = formatTime($RtaSpeedrun::Time);
	if ($RtaSpeedrun::IsDone)
		%text = %text SPC "Final Time";
	else if ($RtaSpeedrun::LastSplitTime > 0)
		%text = %text NL formatTime($RtaSpeedrun::LastSplitTime) SPC "Split";
	PlayGui.updateRtaSpeedrunTimer(%text);
	PlayMissionGui.updateRtaSpeedrunTimer(%text);
	LoadingGui.updateRtaSpeedrunTimer(%text);
}

function RtaSpeedrunStart() {
	$RtaSpeedrun::IsEnabled = true;
	$RtaSpeedrun::IsTiming = false;
	$RtaSpeedrun::IsDone = false;
	$RtaSpeedrun::Time = 0;
	$RtaSpeedrun::LastSplitTime = -1;
	RtaSpeedrunUpdateTimers();
}

function RtaSpeedrunSetEnd() {
	$RtaSpeedrun::EndMission = $Server::MissionFile;
}
