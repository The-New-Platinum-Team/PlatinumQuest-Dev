//-----------------------------------------------------------------------------
// Copyright (c) 2024 The Platinum Team
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

function GuiControl::setRandomBackground(%this) {
	if (%this.noRandomBackground) {
		return;
	}
	if (!%this.backgroundGameSpecific) {
		if (%this.followBitmap.randomBackground !$= "") {
			%this.randomBackground = %this.followBitmap.randomBackground;
		}
		if (%this.randomBackground $= "") {
			%num = getRandom(1, 90);
			%category = %num <= 12 ? "gold" : (%num <= 40 ? "platinum" : (%num <= 68 ? "platinumquest" : (%num <= 81 ? "multi" : "ultra")));
			switch$ (%category) {
				case "gold":

				case "platinum":
					%num -= 12;
				case "platinumquest":
					%num -= 40;
				case "multi":
					%num -= 68;
				case "ultra":
					%num -= 81;
			}
			%this.randomBackground = "platinum/client/ui/packs/old/backgrounds/" @ %category @ "/" @ %num;
		}
		%this.setBitmap(%this.randomBackground);
		if (%this.followBitmap !$= "") {
			%this.followBitmap.randomBackground = %this.randomBackground;
		}
	} else {
		if (!%this.loadedBackgrounds && %this.randomBackgrounds !$= "") {
			%count = getFieldCount(%this.randomBackgrounds);
			for (%i = 0; %i < %count; %i ++) {
				%this.randomBackground[getWord(getField(%this.randomBackgrounds, %i), 0)] = "platinum/client/ui/packs/old/backgrounds/" @ getWord(getField(%this.randomBackgrounds, %i), 1) @ "/" @ getWord(getField(%this.randomBackgrounds, %i), 2);
			}
		}
		%category = (($Server::ServerType $= "MultiPlayer" || $CurrentGame $= "Hunt") ? "multi" : $CurrentGame);
		if (%this.followBitmap.randomBackground[%category] !$= "") {
			%this.randomBackground[%category] = %this.followBitmap.randomBackground[%category];
		}
		if (%this.randomBackground[%category] $= "") {
			if (findWord("gold platinum ultra platinumquest multi", %category) == -1) {
				%num = getRandom(1, 90);
				%bitmapCat = %num <= 12 ? "gold" : (%num <= 40 ? "platinum" : (%num <= 68 ? "platinumquest" : (%num <= 81 ? "multi" : "ultra")));
				switch$ (%bitmapCat) {
					case "gold":

					case "platinum":
						%num -= 12;
					case "platinumquest":
						%num -= 40;
					case "multi":
						%num -= 68;
					case "ultra":
						%num -= 81;
				}
				%this.randomBackground[%category] = "platinum/client/ui/packs/old/backgrounds/" @ %bitmapCat @ "/" @ %num;
				%this.randomBackgrounds = %this.randomBackgrounds TAB %category SPC %bitmapCat SPC %num;
			} else {
				switch$ (%category) {
					case "gold":
						%count = 12;
					case "platinum":
						%count = 28;
					case "platinumquest":
						%count = 28;
					case "multi":
						%count = 13;
					case "ultra":
						%count = 9;
				}
				%num = getRandom(1, %count);
				%this.randomBackground[%category] = "platinum/client/ui/packs/old/backgrounds/" @ %category @ "/" @ %num;
				%this.randomBackgrounds = %this.randomBackgrounds TAB %category SPC %category SPC %num;
			}
		}
		%this.setBitmap(%this.randomBackground[%category]);
		if (%this.followBitmap !$= "") {
			%this.followBitmap.randomBackground[%category] = %this.randomBackground[%category];
		}
		%this.loadedBackgrounds = true;
	}
}

package OldGui {
	function GuiCanvas::setContent(%this, %ctrl) {
		Parent::setContent(%this, %ctrl);
		%ctrl.setRandomBackground();
	}

	function Unlock::canDisplayMission(%mission) {
		if (!isActivePackage(OldGui))
			return Unlock::canDisplayMission(%mission);
		
		//Do not show marbleland missions in PlayMissionGui
		if ($PMG::CurrentGui $= "OldPlayMissionGui" && $CurrentGame $= "Custom")
			return Parent::canDisplayMission(%mission) && strStr(%mission.file, "platinum/data/missions/marbleland") == -1;

		return Parent::canDisplayMission(%mission);
	}

	function LBNetwork::on_accepttos(%this, %line) {
		if ($Game::Offline)
			return;
		//Usually, when logging in as a guest, the terms dialog is shown here. However, the user should have already accepted the terms through LBGuestLoginGui, so displaying a terms dialog here is not necessary
		if ($LB::AcceptedTOS) {
			LBNetwork.onNextFrame(send, "ACCEPTTOS\n");
		} else {
			LBAssert("Cannot Accept TOS", "Your game cannot verify the TOS.", "LBdisconnect();");
		}
	}
};

if ($pref::OldGui::NewExitGame $= "")
	$pref::OldGui::NewExitGame = 1;

if ($pref::OldGui::TotD $= "")
	$pref::OldGui::TotD = true;

if ($pref::OldGui::MarblelandFastRepeatSpeed $= "")
	$pref::OldGui::MarblelandFastRepeatSpeed = 30;

if ($pref::OldGui::MarblelandNormalRepeatSpeed $= "")
	$pref::OldGui::MarblelandNormalRepeatSpeed = 400;

if ($pref::OldGui::OldLBUserList $= "")
	$pref::OldGui::OldLBUserList = true;

if ($pref::OldGui::ExpandedLBUserInfo $= "")
	$pref::OldGui::ExpandedLBUserInfo = true;

if ($pref::OldGui::ShowLBWorldRecord $= "")
	$pref::OldGui::ShowLBWorldRecord = true;

if ($pref::OldGui::NewMPPreGame $= "")
	$pref::OldGui::NewMPPreGame = true;

if ($pref::OldGui::NewMPExitGame $= "")
	$pref::OldGui::NewMPExitGame = true;

if ($pref::OldGui::SearchType $= "")
	$pref::OldGui::SearchType = 0;

if ($pref::OldGui::LETip $= "")
	$pref::OldGui::LETip = true;