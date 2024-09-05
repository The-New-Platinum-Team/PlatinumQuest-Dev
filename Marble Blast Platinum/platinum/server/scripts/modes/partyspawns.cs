//-----------------------------------------------------------------------------
// Party Spawns
//
// Originally created in 2021
//
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

function Mode_partyspawns::onLoad(%this) {
	%this.registerCallback("onFoundGem");
	%this.registerCallback("onMissionReset");
	%this.registerCallback("onMissionEnded");
	%this.registerCallback("onActivate");
	%this.registerCallback("onDeactivate");
	%this.registerCallback("onEditorOpened");
	%this.registerCallback("onUpdateGhost");
	%this.registerCallback("onRespawnPlayer");
	echo("[Mode" SPC %this.name @ "]: Loaded!");
}

new ScriptObject(LowTimeout) { //Hack: Use a script object for green gem and orange gem effects
	timeout = 5000;
	activeTime = 5000;
};

function Mode_partyspawns::onFoundGem(%this, %object) {
	%trigger = %object.gem;
	%cl = %object.client;
	switch$ (%trigger._huntColor) {

		case "Orange":
			if (!$Party::BlackGem || %cl.blackGemImmune || %cl.rainbow) {
				if (%cl.getFireballTime() < 5000) {
					%cl.fireballInit(5000);
					serverPlay3D(PuFireballVoiceSfx, %trigger.getPosition());
					%cl.player._fireball = LowTimeout;
				} else {
					serverPlay3D(PuFireballVoiceSfx, %trigger.getPosition());
				}
			}


		case "Green":
			if (!$Party::BlackGem || %cl.blackGemImmune || %cl.rainbow) {
				if (5000 > %cl.player._MMTimeout - (getSimTime() - %cl.player._MMStartTime)) {
					MegaMarbleItem.onUse(LowTimeout, %cl.player);
				} else {
					serverPlay3D(DoMegaMarbleSfx, %trigger.getPosition());
				}
			}


		case "Purple":
			commandToClient(%cl, 'doPowerUp', 2);
			SuperSpeedItem.onUse(%trigger, %cl.player);
			commandToClient(%cl, 'doPowerUp', 4);
			ShockAbsorberItem.onUse(%trigger, %cl.player);


		case "Turquoise":
			%cl.addHelpLine("You picked up a Triple Blast!");
			%cl.setBlastValue(1);
			%cl.setSpecialBlast(false);
			%cl.setTripleBlast(true);


		case "Pink":
			commandToClient(%cl, 'doPowerUp', 3);
			SuperBounceItem.onUse(%trigger, %cl.player);
			commandToClient(%cl, 'ApplyImpulse', "0 0 0", "0 0 -10");


		case "Black":
			cancel(%this.resetBlackGem);
			$Party::BlackGem = true;
			%cl.blackGemImmune = true;
			%cl.updateGhostDatablock();
			commandToClient(%cl, 'EndBlackGem');
			for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
				%client = ClientGroup.getObject(%i);
				//%client.addHelpLine("Black gem collected, everyone is now small!");
				%client.addHelpLine("Black gem collected!");
				if (!%client.blackGemImmune && !%client.rainbow) {
					%client.setMegaMarble(false);
					%client.fireballExpire();
					%client.player.setCollisionRadius(0.094875);
					commandToClient(%client, 'BlackGem', true);
				}
			}
			commandToAll('AlxPlay', "BubblePopSfx");
			%this.resetBlackGem = %this.schedule(10000, resetPartyBlackGem);


		case "White":
			cancel(%this.resetWhiteGem);
			$Party::WhiteGem = true;
			%cl.whiteGemImmune = true;
			commandToClient(%cl, 'EndWhiteGem');
			for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
				%client = ClientGroup.getObject(%i);
				//%client.addHelpLine("White gem collected, everyone is now flying!");
				//commandToClient(%client, 'doPowerUp', 5);
				%client.addHelpLine("White gem collected!");
				if (!%client.whiteGemImmune && !%client.rainbow)
					commandToClient(%client, 'WhiteGem', true);
			}
			%this.resetWhiteGem = %this.schedule(5000, resetPartyWhiteGem);
			
		
		case "Rainbow":
			cancel(%cl.resetRainbowGem);
			commandToClient(%cl, 'RainbowGem', true);
			%cl.rainbow = true;
			%cl.resetRainbowGem = %cl.schedule(20000, endRainbowGem);
			%cl.addHelpLine("You picked up a Rainbow Gem!");
			if (!%cl.isMegaMarble())
				%cl.player.setCollisionRadius(0.3);

			commandToClient(%cl, 'EndBlackGem');
			commandToClient(%cl, 'EndWhiteGem');


	}
}

//-----------------------------------------------------------------------------

function Mode_partyspawns::onMissionReset(%this) {
	%this.reset();
	if (!$Game::isMode["coop"] && !$Editor::Opened) {
		$Party::nonPartyGemsPerSpawn = (MissionInfo.maxGemsPerSpawn ? MissionInfo.maxGemsPerSpawn : $Hunt::MaxGemsPerSpawn);
		MissionInfo.maxGemsPerSpawn = $Party::nonPartyGemsPerSpawn * 1.5;
	} else {
		if ($Party::nonPartyGemsPerSpawn) {
			MissionInfo.maxGemsPerSpawn = $Party::nonPartyGemsPerSpawn;
			$Party::nonPartyGemsPerSpawn = "";
		}
	}
	if ($Game::isMode["hunt"])
		Mode_hunt.onMissionReset();
}

function Mode_partyspawns::onMissionEnded(%this) {
	%this.reset();
}

function Mode_partyspawns::onActivate(%this) {
	$Party::nonPartyGemsPerSpawn = (MissionInfo.maxGemsPerSpawn ? MissionInfo.maxGemsPerSpawn : $Hunt::MaxGemsPerSpawn);
}

function Mode_partyspawns::onDeactivate(%this) {
	%this.reset();
}

function Mode_partyspawns::onEditorOpened(%this) {
	%this.reset();
}

//Reset party effects
function Mode_partyspawns::reset(%this) {
	%this.resetPartyBlackGem();
	%this.resetPartyWhiteGem();

	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.setTripleBlast(false);
		%client.endRainbowGem();
	}
	
	//Reset gem skins
	makeGemGroup(MissionGroup, true);
	makeGemGroup(MissionCleanup);
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];
		if (%gem._nonPartyDatablock !$= "") {
			%gem.setDataBlock(%gem._nonPartyDatablock);
			%gem.setSkinName(%gem._nonPartySkin);
			%gem.setTransform(%gem._nonPartyPosition);
			%gem.setScale(%gem._nonPartyScale);
			%gem._nonPartyDatablock = "";
			%gem.onInspectApply();
		}
	}
	if ($Party::nonPartyGemsPerSpawn) {
		MissionInfo.maxGemsPerSpawn = $Party::nonPartyGemsPerSpawn;
		$Party::nonPartyGemsPerSpawn = "";
	}
}

//-----------------------------------------------------------------------------

function Mode_partyspawns::onUpdateGhost(%this, %object) {
	if ($Party::BlackGem && !%object.client.blackGemImmune && !%object.client.rainbow) {
		%object.client.player.setCollisionRadius(0.094875);
	}
	if (%object.client.rainbow && !%object.client.isMegaMarble()) {
		%object.client.player.setCollisionRadius(0.3);
	}
}

function Mode_partyspawns::onRespawnPlayer(%this, %object) {
	if ($Party::WhiteGem && !%object.client.whiteGemImmune && !%object.client.rainbow) {
		commandToClient(%object.client, 'WhiteGem');
	}
	if ($Party::BlackGem && !%object.client.blackGemImmune && !%object.client.rainbow) {
		commandToClient(%object.client, 'BlackGem');
	}
	if (%object.client.rainbow) {
		commandToClient(%object.client, 'RainbowGem');
	}

	%object.client.player._MMTimeout = 0;
}

function Mode_partyspawns::resetPartyBlackGem(%this) {
	cancel(%this.resetBlackGem);
	$Party::BlackGem = false;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.blackGemImmune = false;
		%client.updateGhostDatablock();
		commandToClient(%client, 'EndBlackGem');
	}
}

function Mode_partyspawns::resetPartyWhiteGem(%this) {
	cancel(%this.resetWhiteGem);
	$Party::WhiteGem = false;
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		%client = ClientGroup.getObject(%i);
		%client.whiteGemImmune = false;
		commandToClient(%client, 'EndWhiteGem');
	}
}

function GameConnection::setTripleBlast(%this, %enable) {
	%this.usingTripleBlast = %enable;
	commandToClient(%this, 'TripleBlast', %enable);
}

function GameConnection::endRainbowGem(%this) {
	%this.rainbow = false;
	commandToClient(%this, 'EndRainbowGem');
	%this.updateGhostDatablock();
}

//-----------------------------------------------------------------------------
$GemSkinColors[11] = "white";
$GemSkinColors[12] = "rainbow";

datablock ItemData(GemItemWhite : GemItem) {
	skin = "white";
	huntExtraValue = -1; //0 pts
	spawnChance = 0.20;
	messageColor = "ffffff";
	customField[0, "field"] = "";
};

datablock ItemData(GemItemRainbow : GemItem) {
	skin = "rainbow";
	huntExtraValue = 19; //20 pts
	spawnChance = 0.01;
	messageColor = "4b0082";
	customField[0, "field"] = "";
};

datablock ParticleEmitterData(GemEmitterWhite : GemEmitterBase) {
	particles = "GemParticleWhite";
};

datablock ParticleData(GemParticleWhite : GemParticleBase) {
	colors[0]     = "1.0 1.0 1.0 1.0";
	colors[1]     = "1.0 1.0 1.0 1.0";
	colors[2]     = "1.0 1.0 1.0 1.0";
};

//$GemSkinColors[13] = "gold";

//datablock ItemData(GemItemGold : GemItem) {
	//skin = "gold";
	//huntExtraValue = 8; //9 pts
	//spawnChance = 0.10;
	//messageColor = "d4af37";
	//customField[0, "field"] = "";
//};

//$GemSkinColors[14] = "clear";

//datablock ItemData(GemItemClear : GemItem) {
	//skin = "clear";
	//huntExtraValue = -1; //0 pts
	//spawnChance = 0.01;
	//messageColor = "dbdbdb";
	//customField[0, "field"] = "";
//};

//function GemItemClear::onAdd(%this, %obj) {
	//Parent::onAdd(%this, %obj);
	//%obj.setCloaked(true);
//}

//$GemSkinColors[15] = "maroon";

//datablock ItemData(GemItemMaroon : GemItem) {
	//skin = "maroon";
	//huntExtraValue = -3; //-2 pts
	//spawnChance = 0.01;
	//messageColor = "800000";
	//customField[0, "field"] = "";
//};

//-----------------------------------------------------------------------------

package Mode_partyspawns {
	function spawnGem(%gem) {
		if (!isObject(%gem))
			return false;

		if (%gem._huntDatablock.huntExtraValue $= "") {
			%gem._annoyingsuffix = strchr(%gem.getDataBlock().getName(), "_");
			%gem.setDataBlock("GemItem" @ %gem._annoyingsuffix);
			%gem.setSkinName("red");
		}
		if (!$Game::isMode["coop"] && !$Editor::Opened) {
			if ($Party::nonPartyGemsPerSpawn != MissionInfo.maxGemsPerSpawn / 1.5 && !$Editor::Opened) { 
				$Party::nonPartyGemsPerSpawn = (MissionInfo.maxGemsPerSpawn ? MissionInfo.maxGemsPerSpawn : $Hunt::MaxGemsPerSpawn);
				MissionInfo.maxGemsPerSpawn = $Party::nonPartyGemsPerSpawn * 1.5;
			}
			if (%gem._nonPartyDatablock $= "") {
				%gem._nonPartyDatablock = %gem.getDataBlock().getName();
				%gem._nonPartySkin = %gem.getDataBlock().skin;
				%gem._nonPartySuffix = strchr(%gem.getDataBlock().getName(), "_");
				%gem._nonPartyPosition = %gem.position;
				%gem._nonPartyScale = %gem.scale ? %gem.scale : "1 1 1";
			}
			%gem.setTransform(%gem._nonPartyPosition);
			%gem.setScale(%gem._nonPartyScale);

			%elapsedTime = $Time::ElapsedTime / Mode::callback("getStartTime", 0);
			%chosen = getRandom(1, 1000);
			%platinum = false;
			%blue = false;

			if ($MP::PartySpawnsRamp && getRandom(1, 3) > 1) { // 2/3 of the gems are boosted by the spawn ramp
				if (%elapsedTime > 0.9) {
					%chosen = (%chosen / 10);
				} else if (%elapsedTime > 0.75) {
					%chosen = (%chosen / 4);
				} else if (%elapsedTime > 0.5) {
					%chosen = (%chosen / 2);	
				}
			}

			//Party Spawns gem alternator
			%gem.setDataBlock("GemItem" @ %gem._nonPartySuffix);
			if (%gem._nonPartySkin $= "red") {
				if (%chosen <= 3) {
					%gem.setSkinName("platinum");
					%platinum = true;
				} else if (%chosen <= 7) {
					%gem.setSkinName("turquoise");
				} else if (%chosen <= 11) {
					%gem.setSkinName("purple");
				} else if (%chosen <= 41) {
					%gem.setSkinName("blue");
				} else if (%chosen <= 56) {
					%gem.setSkinName("pink");
				} else if (%chosen <= 60) {
					%gem.setSkinName("black");
				} else if (%chosen <= 66) {
					%gem.setSkinName("white");
				} else if (%chosen <= 131) {
					%gem.setSkinName("green");
				} else if (%chosen <= 246) {
					%gem.setSkinName("orange");
				} else if (%chosen <= 446) {
					%gem.setSkinName("yellow");
				} else {
					%gem.setSkinName("red");
				}

			} else if (%gem._nonPartySkin $= "yellow") {
				if (%chosen <= 30) {
					%gem.setSkinName("platinum");
					%platinum = true;
				} else if (%chosen <= 70) {
					%gem.setSkinName("turquoise");
				} else if (%chosen <= 110) {
					%gem.setSkinName("purple");
				} else if (%chosen <= 224) {
					%gem.setSkinName("blue");
				} else if (%chosen <= 276) {
					%gem.setSkinName("pink");
				} else if (%chosen <= 286) {
					%gem.setSkinName("black");
				} else if (%chosen <= 306) {
					%gem.setSkinName("white");
				} else if (%chosen <= 431) {
					%gem.setSkinName("green");
				} else if (%chosen <= 591) {
					%gem.setSkinName("orange");
				} else {
					%gem.setSkinName("yellow");
				}

			} else if (%gem._nonPartySkin $= "blue") {
				%gem.setScale(VectorScale(%gem._nonPartyScale, 3));
				%blue = true;
				if (%chosen <= 45) {
					%gem.setSkinName("rainbow");
					%platinum = true;
				} else if (%chosen <= 270) {
					%gem.setSkinName("platinum");
					%platinum = true;
				} else if (%chosen <= 570) {
					%gem.setSkinName("turquoise");
				} else if (%chosen <= 870) {
					%gem.setSkinName("purple");
				} else {
					%gem.setSkinName("blue");
				}

			} else if (%gem._nonPartySkin $= "platinum") {
				%gem.setScale(VectorScale(%gem._nonPartyScale, 3));
				%blue = true;
				%platinum = true;
				if (%chosen <= 225) {
					%gem.setSkinName("rainbow");
				} else {
					%gem.setSkinName("platinum");
				}
			}


			if (getRandom(1, 20) == 1 && !%blue)
				%gem.setScale(VectorScale(%gem._nonPartyScale, 2));

			if (getRandom(1, 45) == 1)
				%gem.setScale(VectorScale(%gem._nonPartyScale, 10));
			

			if (%platinum) {
				if (getRandom(1, 2) == 1) { // Up high!
					%gem.setTransform(getWords(%gem._nonPartyPosition, 0, 1) SPC getWord(%gem._nonPartyPosition, 2) + 15);
					// "%gem.position =" only works visually, don't do it
					%gem.setScale(VectorScale(%gem._nonPartyScale, 10));
				}
			}

			%gem.onInspectApply();
			
		} else {
			if ($Party::nonPartyGemsPerSpawn) {
				MissionInfo.maxGemsPerSpawn = $Party::nonPartyGemsPerSpawn;
				$Party::nonPartyGemsPerSpawn = "";
			}
			if (%gem._nonPartyDatablock !$= "") {
				%gem.setDataBlock(%gem._nonPartyDatablock);
				%gem.setSkinName(%gem._nonPartySkin);
				%gem.setTransform(%gem._nonPartyPosition);
				%gem.setScale(%gem._nonPartyScale);
				%gem._nonPartyDatablock = "";
				%gem.onInspectApply();
			}
		}

		return Parent::spawnGem(%gem);
	}


	function MegaMarbleItem::onUse(%this, %obj, %user) {
		if (!isActivePackage("Mode_partyspawns")) { 
			return MegaMarbleItem::onUse(%this, %obj, %user);
		}

		if ($Party::BlackGem && !%user.client.blackGemImmune && !%user.client.rainbow) {
			%user.client.play2D(DoMegaMarbleSfx);
			return true;
		}
		
		//TODO: Add this to regular Mega Marble, good QOL change
		%user._MMStartTime = getSimTime();
		%user._MMTimeout = (%obj.timeout ? %obj.timeout : 10000);
		
		return Parent::onUse(%this, %obj, %user);
	}

	function serverCmdFireballBlast(%client, %position) {
		if (%client.player._fireballActive) {
			FireballItem::Blast(FireballItem, %client.player._fireball, %client.player); //Hack: For orange gem
		}
	}

	function IceShard::onCollision(%this, %ice, %marble, %unused1, %unused2, %material) {
		if (!GameBaseData::onCollision(%this, %ice, %marble, %unused1, %unused2, %material)) return;

		if (%marble._fireballActive) {
			if (FireballItem::IceCollision(FireballItem, %marble._fireball, %marble, %ice)) //Hack: For orange gem
				return true;
		}
		if (%marble.client.rainbow)
			return true;

		return Parent::onCollision(%this, %ice, %marble, %unused1, %unused2, %material);
	}

	function GameConnection::enterCannon(%this, %cannon) {
		if (%this.rainbow) //Cannons break with larger marbles
			return false;

		return Parent::enterCannon(%this, %cannon);
	}

};

$MP::PartySpawnsRamp = true;