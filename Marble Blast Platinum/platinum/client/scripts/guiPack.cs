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

function loadGuiPack(%packname, %auto) {
	%inOptions = (isObject($GuiPack::CurrentPack) && $GuiPack::CurrentPack.OptionsGui.isAwake()) || OptionsGui.isAwake();
	unloadGuiPack($GuiPack::CurrentPack, %auto);

	if (%packname $= "") 
		return;

	%spec = $userMods @ "/client/ui/packs/" @ %packname @ "/" @ %packname @ ".json";
	%pack = jsonParse(fread(%spec));
	if (!isObject(%pack)) {
		if (%pack !$= "") {
			MessageBoxOk("GUI Pack Error!", "Could not load the GUI pack \"" @ %packname @ "\"!");
		}
		return;
	}
	warn("Executing GUI pack" SPC %pack.name SPC "by" SPC %pack.author @ "...");
	$GuiPack::CurrentPack = %pack;

	//Load any scripts for the pack first
	%script = $userMods @ "/client/ui/packs/" @ %packname @ "/" @ %packname @ ".cs";
	if (isFile(%script)) {
		exec(%script);
		if (isPackage(%packname @ "Gui"))
			activatePackage(%packname @ "Gui");
	}

	//Then, load the GUIs
	%pattern = $usermods @ "/client/ui/packs/" @ %packname @ "/*.gui";
	for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
		exec(%file);
	}

	//Restore specified GUI fields
	if (isObject(%pack.SaveFields)) {
		%fieldObj = %pack.identifier @ "GuiFields";
		if (isObject(%fieldObj)) {
			%restoreFields = %fieldObj.getDynamicFieldList();
			%restoreCount = getFieldCount(%restoreFields);
			for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
				%gui = nameToId(fileBase(%file));
				for (%i = 0; %i < %restoreCount; %i ++) {
					%restoreField = getField(%restoreFields, %i);
					if (strStr(%restoreField, %gui.getName()) != -1)
						%gui.setFieldValue(getSubStr(%restoreField, strLen(%gui.getName()), strLen(%restoreField)), %fieldObj.getFieldValue(%restoreField));
				}
			}
			%fieldObj.delete();
		}
	}

	if (%pack.MenuHandler !$= "") {
		deactivateMenuHandler(PMMenu);
		deactivateMenuHandler(RootMenu);
		activateMenuHandler(%pack.MenuHandler);
	}

	if (%pack.ShellMusic !$= "" && getVariable("$pref::" @ strupr(%pack.identifier) @ "Gui::SongsMenu") $= "")
		setVariable("$pref::" @ strupr(%pack.identifier) @ "Gui::SongsMenu", %pack.ShellMusic);
	if (%pack.LBShellMusic !$= "" && getVariable("$pref::" @ strupr(%pack.identifier) @ "Gui::SongsLB") $= "")
		setVariable("$pref::" @ strupr(%pack.identifier) @ "Gui::SongsLB", %pack.LBShellMusic);

	$GuiPack::Active = true;

	if (!%auto) {
		if (%inOptions) {
			%pack.OptionsGui.load();

		} else if (PlayGui.isAwake()) {
			if (lb()) {
				LBMessageHudDlg.setVisible(false);
				%pack.LBMessageHudDlg.positionMessageHud();
			}
		} else {
			Canvas.setContent(mp() ? %pack.MPPlayMissionGui : (lb() ? %pack.LBChatGui : %pack.MainMenuGui));
		}
		if (PlayGui.isAwake()) {
			playMusic($currentMusicBase);
		} else if (lb()) {
			playLBMusic();
		} else {
			playShellMusic();
		}
	}
}

function unloadGuiPack(%pack, %auto) {
	if (%pack $= "")
		return;

	%packname = %pack.identifier;
	%inOptions = $GuiPack::CurrentPack.OptionsGui.isAwake() || OptionsGui.isAwake();
	OptionsGui.content = ((PlayGui.isAwake() || $GuiPack::CurrentPack.PlayMissionGui.isAwake() || $GuiPack::CurrentPack.LBPlayMissionGui.isAwake() || mp()) ? "exit" : (lb() ? "lb" : ""));
	%index = $GuiPack::CurrentPack.PlayMissionGui.getSelectedIndex();

	warn("Resetting GUI pack...");
	
	%script = $userMods @ "/client/ui/packs/" @ %packname @ "/" @ %packname @ ".cs";
	if (isFile(%script) && isPackage(%packname @ "Gui")) {
		deactivatePackage(%packname @ "Gui");
	}

	%pattern = $usermods @ "/client/ui/packs/" @ %packname @ "/*.gui";

	//Save any fields that are specified
	if (isObject(%pack.SaveFields)) {
		%fieldObj = %pack.identifier @ "GuiFields";
		if (!isObject(%fieldObj))
			new ScriptObject(%fieldObj);
		%saveFields = %pack.SaveFields.getDynamicFieldList();
		for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
			%gui = nameToId(fileBase(%file));
			%fields = %gui.getDynamicFieldList();
			%count = getFieldCount(%fields);
			for (%i = 0; %i < %count; %i ++) {
				%field = getField(%fields, %i);
				if (findField(%saveFields, %field) != -1 && %gui.getFieldValue(%field) !$= "") {
					%fieldObj.setFieldValue(%gui.getName() @ %field, %gui.getFieldValue(%field));
				}
			}
		}
	}

	//Delete the GUIs
	for (%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern)) {
		%gui = nameToId(fileBase(%file));
		Canvas.popDialog(%gui);
		%gui.onNextFrame(delete);
	}

	if (%pack.MenuHandler !$= "") {
		activateMenuHandler(PMMenu);
		activateMenuHandler(RootMenu);
		deactivateMenuHandler(%pack.MenuHandler);
	}

	deleteVariables("$GuiPack::*");
	
	$GuiPack::Active = false;

	if (!%auto) {
		PlayMissionGui.marbleland = marblelandIsMission($Menu::MissionFile);
		PlayMissionGui.selectedIndex = %index;
		PlayMissionGui.noLoad = true;
		PlayMissionGui.init();
		PlayMissionGui.noLoad = false;
		if (lb()) {
			LBUpdateChat();
			LBChatGui.updateUserList();
		}
		if (mp()) {
			MPUpdateServerChat();
			updateTeamChat();
			PlayMissionGui.onNextFrame(updateServerPlayerList);
		}
		RootGui.showPreviewImage(true);
		if (PlayGui.isAwake())
			RootGui.showPreviewImage(false);
		if (%inOptions) {
			if (PlayGui.isAwake()) {
				if (lb()) {
					PlayGui.positionMessageHud();
				}
				if (mp()) {
					if ($Game::Pregame) {
						MPPreGameDlg.save = true;
						RootGui.pushDialog(MPPreGameDlg);
					} else {
						RootGui.pushDialog(MPExitGameDlg);
					}
				} else if ($gamePaused) {
					RootGui.pushDialog(ExitGameDlg);
				}
			} else if (OptionsGui.content $= "exit") {
				RootGui.setContent(PlayMissionGui);
			} else if (OptionsGui.content $= "lb") {
				RootGui.setContent(LBChatGui);
			}
			OptionsGui.show(OptionsGui.content);

		} else if (PlayGui.isAwake()) {
			if (lb()) {
				%pack.LBMessageHudDlg.setVisible(false);
				PlayGui.positionMessageHud();
			}
		} else {
			RootGui.setContent(mp() ? PlayMissionGui : (lb() ? LBChatGui : MainMenuGui));
		}
		if (PlayGui.isAwake()) {
			playMusic($currentMusicBase);
		} else if (lb()) {
			playLBMusic();
		} else {
			playShellMusic();
		}
	}
}

function loadGuiPackProfiles() {
	for (%i = 0; %i < GuiPackArray.getSize(); %i ++) {
		%pack = GuiPackArray.getEntry(%i);
		%packname = getField(%pack, 1);
		%profiles = $userMods @ "/client/ui/packs/" @ %packname @ "/" @ %packname @ "_GuiProfiles.cs";
		if (isFile(%profiles)) {
			exec(%profiles);
		}
	}
}

loadGuiPackProfiles();