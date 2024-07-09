//-----------------------------------------------------------------------------
// nametag.cs
//
// Copyright (c) 2014 The Platinum Team
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

/// collision flag to hide name tag
$NameTag::TypeMask = $TypeMasks::InteriorObjectType;

/// background image path for nametag
$NameTag::BackGround = $userMods @ "/client/ui/game/hudfill";

function updateNameTags() {
	if ($pref::FastMode) {
		clearNameTags();
		return;
	}

	%count = PlayerList.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%entry = PlayerList.getEntry(%i);

		if (!isObject(%entry) || !isObject(%entry.player))
			continue;

		updateNameTag(%i);
	}

	cleanUpNameTags();
}

// called in extrapolateGhosts
function updateNameTag(%index) {
	if ($pref::FastMode)
		return;

	//Don't show nametags for ourselves
	if (%index == $MP::ClientIndex)
		return;

	%entry = PlayerList.getEntry(%index);
	if (!isObject(%entry.player))
		return;
	//Not really sure how/why this bugs but it does
	if (%entry.player.getClassName() !$= "Marble")
		return;

	createNameTag(%index);
	%tag = %entry.player.nameTag;
	if (!isObject(%tag))
		return;

	// do not show nametag of the person we are spectating in orbit mode
	if ($SpectateMode && !$SpectateFlying && $spectatorPerson == %entry.player) {
		%tag.setVisible(false);
		return;
	}
	if ($Server::ServerType $= "")
		return;

	// player position
	%pos = %entry.player.getWorldBoxCenter();

	// make it above the marble
	%cameraTrans = getCameraTransform();

	%distance = vectorDist(MatrixPos(%cameraTrans), %entry.player.getPosition());
	%pos = vectorAdd(%pos, VectorScale(getGravityDir(), -2 * %entry.player.getCollisionRadius()));

	//Just pick something really large as default so they go the whole way
	%maxDist = ClientMode::callback("nametagDistance", 2000); //Should be ~draw distance
	if (%distance > %maxDist) {
		%tag.setVisible(false);
		//echo("out of range");
		return;
	}

	%screenPos = getGuiSpace(%cameraTrans, %pos, getCameraFov());
	// are we off the screen?
	if (isOffScreen(%screenPos)) {
		%tag.setVisible(false);
		return;
	}

	// see if the player is hidden. If it is, don't display the nametag.
	// we delay raycast so that we only have to draw the ray if the marbles
	// are in the viewport =)
	//
	// Please note, fast mode does not do this check. (This could get laggy
	// for people with bad CPUs, all these raycasts!)
	%doCast = ClientMode::callback("nametagRaycast", true);
	if (!$pref::FastMode && %doCast) {
		// do not put an exeption in clientContainerRaycasting, I think its causing
		// virtual memory errors......
		if (clientContainerRayCast(%cameraTrans, %pos, $NameTag::TypeMask)) {
			%tag.setVisible(false);
			return;
		}
	}

	%extent = %tag.defaultLength SPC "18";

	%screenPos = VectorClamp(%screenPos, -1, 1);
	%screenPos = getPixelSpace(%screenPos);
	%screenPos = VectorClampGui(%screenPos, 8);
	%screenPos = VectorRound(VectorSub(%screenPos, VectorScale(%extent, 0.5)));

	%tag.setPosition(%screenPos);
	%tag.setVisible(true);
	if (RootGui.getContent().getName() $= "PlayGui")
		%tag.forceReflow();
}


// create a name tag for a specific player
function createNameTag(%index) {
	// get name
	%entry = PlayerList.getEntry(%index);
	%name = %entry.nameTag;
	if (%name $= "")
		return;
	%objName = "NameTag_" @ %index;

	if (isObject(%entry.player.nameTag) && %entry.player.nameTag.getValue() $= %name)
		return;

	if (!isObject(%entry.player))
		return;

	if (%entry.player.isHidden())
		return;

	if ($pref::FastMode)
		return;

	if (isObject(%objName))
		%objName.delete();

	// figure out background extent
	%oldTags = $TexturePack::MBPHelpUI || $TexturePack::MBGHelpUI;
	%font = %oldTags ? "Marker Felt" : $DefaultFont;
	%len = textLen(stripMLControlChars(%name), %font, 22) + 8;

	%gui = new GuiMLTextCtrl(%objName) {
		profile = "GuiDefaultProfile";
		position = "0 0";
		extent = %len SPC (%oldTags ? "19" : "24");
		minExtent = "8 8";
		defaultLength = %len;

		new GuiBitmapCtrl() {
			profile = "GuiDefaultProfile";
			position = "0" SPC (%oldTags ? "0" : "4");
			extent = %len SPC "18";
			minExtent = "8 8";
			bitmap = $NameTag::BackGround;
		};
	};
	%gui.setText("<just:center>" @ (%oldTags ? "<font:" @ %font @ ":18>" : "<font:22>") @ "<color:ffffff>" @ %name);
	%gui.sub = %gui.getObject(0);
	NameTagCtrl.add(%gui);

	// attach to player
	%entry.player.nameTag = %gui;
	%gui.player = %entry.player;
}

function clearNameTags() {
	%count = NameTagCtrl.getCount();
	%remove = 0;
	for (%i = 0; %i < %count && %count > 0; %i ++) {
		%obj = NameTagCtrl.getObject(%i);
		%obj.delete();
		%i --;
		%count --;
	}
	%count = PlayerList.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%entry = PlayerList.getEntry(%i);

		if (!isObject(%entry))
			continue;

		if (isObject(%entry.player.nameTag))
			%entry.player.nameTag.delete();
	}
}

function cleanUpNameTags() {
	// if players don't exist anymore, clean 'em up!
	%count = NameTagCtrl.getCount();
	%remove = 0;
	for (%i = 0; %i < %count; %i ++) {
		%obj = NameTagCtrl.getObject(%i);
		if (!isObject(%obj))
			continue;
		if (!isObject(%obj.player) || %obj.player.isHidden()) {
			%tag[%remove] = %obj;
			%remove ++;
		}
	}
	for (%i = 0; %i < %remove; %i ++)
			%tag[%i].delete();
}