//-----------------------------------------------------------------------------
// Collection Mode
//
// Copyright (c) 2015 The Platinum Team
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

function Mode_collection::onLoad(%this) {
	%this.registerCallback("shouldPickupGem");
	%this.registerCallback("shouldIgnoreGem");
	%this.registerCallback("shouldStoreGem");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("shouldResetGem");
	%this.registerCallback("shouldResetTime");
	%this.registerCallback("shouldRestartOnOOB");
	%this.registerCallback("shouldRespawnGems");
	%this.registerCallback("shouldSetSpectate");
	%this.registerCallback("onGameState");
	%this.registerCallback("onFoundGem");
	%this.registerCallback("shouldTotalGemCount");
	%this.registerCallback("getStartTime");
	%this.registerCallback("onUpdateGhost");
	%this.registerCallback("timeMultiplier");
	%this.registerCallback("onTimeExpire"); // main_gi
	%this.registerCallback("getScoreType"); // main_gi
	%this.registerCallback("getFinalScore"); // main_gi
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}
function Mode_collection::shouldIgnoreGem(%this, %object) {
	//Make sure it's our color
	%color = %object.user.client.collectioncolor;
	if (%this.getGemColor(%object.obj) $= %color) {
		//Gems always give one
		%object.user.client.onFoundGem(1);
		%object.user.client.gemsFound[1] ++;
		%this.checkWin(%object.user.client);
	}
	return true;
}
function Mode_collection::shouldPickupGem(%this, %object) {
	%color = %object.user.client.collectioncolor;
	return %this.getGemColor(%object.obj) $= %color;
}
function Mode_collection::shouldStoreGem(%this, %object) {
	return false;
}
function Mode_collection::timeMultiplier(%this) {
	return 1;
}
function Mode_collection::shouldSetSpectate(%this, %object) {
	return $Game::Pregame;
}
function Mode_collection::onMissionReset(%this, %object) {
	//If they haven't specified to not randomize colors, then do so
	if (!MissionInfo.noRandom) {
		%this.randomizeColors();
	}

	//Find which colors were chosen
	%colors = %this.getColors();
	echo("[Mode Collection]: Found collection colors:" SPC %colors);

	//Divide the colors up for each client
	%count = ClientGroup.getCount();
	for (%clientIndex = 0; %clientIndex < %count; %clientIndex ++) {
		%cl = ClientGroup.getObject(%clientIndex);
		if (%cl.spectating)
			continue;

		//Pick a random color for the client and remove it from the list of available colors
		%index = getRandom(0, getWordCount(%colors) - 1);
		%cl.setCollectionColor(getWord(%colors, %index));
		%colors = removeWord(%colors, %index);
	}
}
function GameConnection::setCollectionColor(%this, %color) {
	%this.collectioncolor = %color;

	//Tell them how many gems they need to collect
	%this.setMaxGems(Mode_collection.getColorCount(%this.collectioncolor));

	//Tell them which color they are
	commandToClient(%this, 'SetCollectionColor', %this.collectioncolor);
}
function Mode_collection::onGameState(%this, %object) {
	%object.client.setMaxGems(%this.getColorCount(%object.client.collectioncolor));
}
function Mode_collection::getStartTime(%this) {
	return 0;
}
function Mode_collection::shouldResetGem(%this, %object) {
	return true;
}
function Mode_collection::shouldResetTime(%this, %object) {
	return false;
}
function Mode_collection::shouldRestartOnOOB(%this, %object) {
	return false;
}
function Mode_collection::shouldRespawnGems(%this, %object) {
	return false;
}
function Mode_collection::onFoundGem(%this, %object) {
	%object.client.playPitchedSound("gotDiamond");
}
function Mode_collection::shouldTotalGemCount(%this) {
	return false;
}
function Mode_collection::onUpdateGhost(%this, %object) {
	//backtrace();
	%object.client.updateCollectionRing();
	%object.client.schedule(1000, call, updateCollectionRing);
}
function GameConnection::updateCollectionRing(%this) {
	//Need to mount as base first so the skin sets
	if (!isObject(%this.collectionRing)) {
		MissionCleanup.add(%this.collectionRing = new StaticShape() {
			position = "0 0 0";
			rotation = "1 0 0 0";
			scale = "1 1 1";
			datablock = "CollectionRing";
		});
		%this.collectionRing.setScopeAlways();
		%this.collectionRing.forceNetUpdate();
		%this.sendCollectionRing();
	}
	%this.collectionRing.setSkinName(%this.collectioncolor);
}
function GameConnection::sendCollectionRing(%this) {
	if (%this.collectionRing.getSyncId() == -1) {
		%this.schedule(100, sendCollectionRing);
		return;
	}
	commandToAll('CollectionRing', %this.index, %this.collectionRing.getSyncId());
}
function Mode_collection::checkWin(%this, %client) {
	%color = %client.collectioncolor;

	makeGemGroup(MissionGroup, true);
	makeGemGroup(MissionCleanup);

	//Check if the client has NOT collected a gem of their color. If so, then
	// they do not have all the gems and have not won.
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];

		if (%this.getGemColor(%gem) $= %color) {
			if (!%gem.isHidden())
				return;
		}
	}
	//We win!

	// main_gi
	%this.gotAllGems = true;
	commandToClient(%this, 'UseTimeScore', true);
	Time::stop();
	Time::set(MissionInfo.time - $Time::CurrentTime);

	endGameSetup();
}
function Mode_collection::getColors(%this) {
	%colors = "";
	makeGemGroup(MissionGroup, true);
	makeGemGroup(MissionCleanup);

	//Check every gem
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];
		%color = %this.getGemColor(%gem);
		if (%gem.isHidden() || %gem.getSkinName() $= "base")
			continue;

		//If we haven't seen its color before, add it to the list
		if (strPos(%colors, %color) == -1) {
			if (%colors $= "")
				%colors = %color;
			else
				%colors = %colors SPC %color;
		}
	}
	return %colors;
}
function Mode_collection::getColorCount(%this, %color) {
	%count = 0;

	makeGemGroup(MissionGroup, true);
	makeGemGroup(MissionCleanup);

	//Count how many gems are of this color
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];

		if (%this.getGemColor(%gem) $= %color) {
			%count ++;
		}
	}
	return %count;
}
function Mode_collection::getGemColor(%this, %gem) {
	return %gem.getSkinName();
}
function Mode_collection::randomizeColors(%this) {
	//Don't include fake and spectating players
	%players = getActivePlayerCount();

	//Generate a list of all gems, string separated
	%gems = "";

	//Make gem groups and count the gems
	makeGemGroup(MissionGroup, true);
	makeGemGroup(MissionCleanup);
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];

		if (%gems $= "")
			%gems = %gem;
		else
			%gems = %gems SPC %gem;
	}

	//How many gems should each player get?
	%total = getWordCount(%gems);
	%per = mFloor(%total / %players);

	//List of possible gem colors
	%colors = "blue red yellow green black orange purple turquoise platinum";

	//Check the MissionInfo to see if we should not pick a color (because
	// nobody likes getting yellow gems on yellow levels)
	if (MissionInfo.disableColor !$= "") {
		%color = MissionInfo.disableColor;
		//Can we find the color?
		%index = findWord(%colors, %color);
		//Take the color out if it exists
		if (%index != -1) {
			%colors = removeWord(%colors, %index);
		}
	}

	echo("[Mode Collection]: Possible colors:" SPC %colors);

	//Divide the gems up into even groups for each player
	for (%i = 0; %i < %players; %i ++) {
		//Pick a random color from the list of colors and remove it
		%colorIndex = getRandom(0, getWordCount(%colors) - 1);
		%color = getWord(%colors, %colorIndex);
		%colors = removeWord(%colors, %colorIndex);

		for (%j = 0; %j < %per; %j ++) {
			//Pick a random gem from the list and remove it
			%index = getRandom(0, getWordCount(%gems) - 1);
			%gem = getWord(%gems, %index);
			%gems = removeWord(%gems, %index);

			//Set its color
			echo("[Mode Collection]:" SPC %gem SPC "Set color" SPC %color);
			%gem.setSkinName(%color);
		}
	}
	//Hide the rest of the gems so we don't have any unclaimed gems
	while (getWordCount(%gems)) {
		%gem = getWord(%gems, 0);
		%gem.setSkinName("base");
		%gem.hide(true);
		%gems = removeWord(%gems, 0);
	}
}

datablock StaticShapeData(CollectionRing) {
	shapeFile = "~/data/shapes/images/ring.dts";

	emap = true;
};



function Mode_collection::onTimeExpire(%this) {
	// main_gi
	%this.gotAllGems = false;
	commandToAll('UseTimeScore', false);
}
function Mode_collection::getScoreType(%this) {
	if (%this.gotAllGems) {
		return $ScoreType::Time;
	}
	return $ScoreType::Score;
}
function Mode_collection::getFinalScore(%this, %object) {
	if (%this.gotAllGems) {
		return $ScoreType::Time TAB $Time::CurrentTime;
	}
	return $ScoreType::Score TAB %object.client.getGemCount();
}