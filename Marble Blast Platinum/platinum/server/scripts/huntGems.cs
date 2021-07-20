//------------------------------------------------------------------------------
// Multiplayer Package
// huntGems.cs
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

$Hunt::RadiusFromGem = 15;
$Hunt::MaxGemsPerSpawn = 7;

$Hunt::MinPointsPerSpawn = 5;
$Hunt::MinGemsPerSpawn = 3;
$Hunt::MaxSpawnSearchLoops = 5;

$Hunt::CurrentGemCount = 0;

// If a gem is picked, it will do a getrandom() and compare it to the fraction here.
// If the random is lower than the fraction, the gem will show.
// (if getrandom() returns anything below 0.65, yellow will show)
// If it is higher than the fraction, the gem will not show.
// (meaning, if getrandom() returns 0.23... when testing for platinum, platinum will not show)
// Adjust as you see fit

// IRD: Final spawn values
$Hunt::SpawnChance["Red"] = 90/100;         // Red gem spawn chance
$Hunt::SpawnChance["Yellow"] = 65/100;      // Yellow spawn chance
//$GM::HGSCDefaultOrange = 0.90 * 0.65; // Orange spawn chance
$Hunt::SpawnChance["Blue"] = 35/100;        // Blue spawn chance
$Hunt::SpawnChance["Platinum"] = 18/100;    // Platinum spawn chance

datablock StaticShapeData(GemLight) {
	shapeFile = "~/data/shapes/gemlights/gemlight.dts";
	emap = false;
};

//le gem

// spawn the gem group
function spawnHuntGemGroup(%exclude) {
	//backtrace();

	// No recursing!
	if ($Game::SpawningGems)
		return;
	if (!$Server::Hosting || $Server::_Dedicated)
		return;
	if (!$Game::isMode["hunt"])
		return;
	if ($playingDemo)
		return;
	if ($Game::isMode["snowball"] && $MPPref::SnowballsOnly) {
		hideGems();
		return;
	}

	if (MissionInfo.nukesweeper) {
		%ret = nukesweeperSpawn(%exclude);
		return %ret;
	}

	// We want to hide the gemlights
	commandToAll('UpdateItems');

	$Game::SpawningGems = true;
	if (doSpawnHuntGemGroup(%exclude)) {
		Mode::callback("onHuntGemSpawn");

		if (SpawnedSet.getCount()) {
			commandToAll('HuntGemSpawn', SpawnedSet.getCount());
			for (%i = 0; %i < SpawnedSet.getCount(); %i ++) {
				SpawnedSet.getObject(%i).setSync("gemSpawnSync");
			}
		}
	}
	$Game::SpawningGems = false;
	commandToAll('RadarBuildSearch');
}

function doSpawnHuntGemGroup(%exclude) {
	if (isObject(GemGroups) && MissionInfo.gemGroups && GemGroups.getCount()) {
		// We need to do a gemgroups spawn
		//hideGems();
//		devecho("Doing a gemgroup spawn!");

		if (getHuntSpawnType() > 0) {
			//MAX POINTS (menu only)

			//Find the group with the highest valued gems and spawn one of those.
			// First, find highest point valued gems
			%highest = 0;
			makeGemGroup(MissionGroup);
			for (%i = 0; %i < $GemsCount; %i ++) {
				%gem = $Gems[%i];
				if (%gem._huntDatablock.huntExtraValue > %highest) {
					%highest = %gem._huntDatablock.huntExtraValue;
				}
			}
			%validCenters = Array(HuntValidCentersArray);
			for (%i = 0; %i < $GemsCount; %i ++) {
				%gem = $Gems[%i];
				if (%gem._huntDatablock.huntExtraValue == %highest) {
					%validCenters.addEntry(%gem);
				}
			}
			//Random gem of highest value, spawn its group
			%center = %validCenters.getEntry(getRandom(0, %validCenters.getSize() - 1));
			%validCenters.delete();
			%group = %center.getGroup();

			if (MissionInfo.gemGroups == 2) {
				//If we're mode 2, spawn gems inside that group
				return spawnHuntGemsInGroup(%group, %exclude);
			} else {
				for (%i = 0; %i < %group.getCount(); %i ++) {
					if (%group.getObject(%i) != %exclude)
						spawnGem(%group.getObject(%i));
				}
				return true;
			}
			return false;
		}

		// We can do a gemGroup spawn here!
		%count = 0;

		while ($Hunt::CurrentGemCount == 0 && (%count ++) < 20) {
			%groupCount = GemGroups.getCount();
			%spawnables = new ScriptObject() {
				count = 0;
			};
			%max = 0;
			if (%groupCount == 1)
				%toSpawn = GemGroups.getObject(0);
			else {
				devecho("Found" SPC %groupCount SPC "gemgroups");
				for (%i = 0; %i < %groupCount; %i ++) {
					%group = GemGroups.getObject(%i);
					if (%group._spawnCount > %max)
						%max = %group._spawnCount;
				}
				for (%i = 0; %i < %groupCount; %i ++) {
					%group = GemGroups.getObject(%i);
					for (%j = %group._spawnCount; %j <= %max + 1; %j ++) {
						%spawnables.group[%spawnables.count] = %group;
						%spawnables.count ++;
					}
				}

				while (!isObject(%spawnGroup))
					%spawnGroup = getRandom(0, %spawnables.count - 1);

				//%spawnables.dump();
				//echo("%max is" SPC %max);

				%toSpawn = %spawnables.group[%spawnGroup];
				%spawnables.delete();

				%toSpawn._spawnCount ++;
			}

			devecho("Spawning group" SPC %toSpawn);

			if (MissionInfo.gemGroups == 2) {
				//If we're mode 2, spawn gems inside that group
				return spawnHuntGemsInGroup(%toSpawn, %exclude);
			} else {
				for (%i = 0; %i < %toSpawn.getCount(); %i ++) {
					if (%toSpawn.getObject(%i) != %exclude)
						spawnGem(%toSpawn.getObject(%i));
				}
				return true;
			}
		}
		return false;
	}
	return spawnHuntGemsInGroup("MissionGroup;MissionCleanup", %exclude);
}

function spawnHuntGemsInGroup(%groups, %exclude) {
	//echo("Spawning in groups" SPC %groups);
	//hideGems();

	if (mp() && $MPPref::Server::SpawnRamp && !$Game::isMode["coop"]) {
		//Early in the game, exclude high-value gems from being spawned
		setGemGroups(%groups);
		%elapsedTime = $Time::ElapsedTime / Mode::callback("getStartTime", 0);

		for (%i = 0; %i < $GemsCount; %i ++) {
			%gem = $Gems[%i];
			//Red/Yellow: Always
			//Blue: After 25% time
			//Platinum: After 50% time
			if (%gem._huntDatablock.huntExtraValue == 4 && %elapsedTime < 0.25) {
				%exclude = addWord(%exclude, %gem);
			} else if (%gem._huntDatablock.huntExtraValue == 9 && %elapsedTime < 0.50) {
				%exclude = addWord(%exclude, %gem);
			}
		}
	}

	//Find center gem(s) to spawn group(s)
	%centerCount = ($MPPref::Server::DoubleSpawnGroups && mp() && !$Game::isMode["coop"]) ? 2 : 1;
	%centers = getCenterGems(%groups, %exclude, %centerCount);

	RootGroup.add(%spawnSet = new SimSet("SpawnSet"));
	%spawnSet.onNextFrame(delete);

	//From each center, find a selection of gems around it to spawn
	for (%i = 0; %i < %centerCount; %i ++) {
		%center = getField(%centers, %i);
		devecho("Center is" SPC %center);
		if (!isObject(%center)) {
			error("Could not spawn a gem group!");
			return false;
		}

		%set = spawnGemGroupSet(%center, %exclude);
		for (%j = 0; %j < %set.getCount(); %j ++) {
			if (%set.getObject(%j).isHidden()) {
				%spawnSet.add(%set.getObject(%j));
			}
		}

		//Only the first gem is the "real" center
		if (%i == 0) {
			$Game::LastGemSpawner = %center;
		}
	}

	//Actually spawn the gems
	%spawnSet.forEach("spawnGem");

	//Temp: So we can see which one is the center
	//for (%i = 0; %i < %centerCount; %i ++) {
	//	%center = getField(%centers, %i);
	//	%center._light.setSkinName("orange");
	//}

	//Flash
	if (!$MP::FinalSpawn) {
		%count = ClientGroup.getCount();
		for (%i = 0; %i < %count; %i ++) {
			%client = ClientGroup.getObject(%i);
			if (isObject(%client.player))
				%client.setWhiteOut(0.10);
		}
	}

	return true;
}

function getCenterGems(%groups, %exclude, %count) {
	%spawnCount = (MissionInfo.maxGemsPerSpawn ? MissionInfo.maxGemsPerSpawn : $Hunt::MaxGemsPerSpawn);
	%spawnRadius = (MissionInfo.radiusFromGem ? MissionInfo.radiusFromGem : $Hunt::RadiusFromGem);
	%spawnBlock = (MissionInfo.spawnBlock ? MissionInfo.spawnBlock : %spawnRadius * 2);

	//Somewhere far enough away that every gem is a valid spawn
	%blockPos = "-9999999 -9999999 -9999999";

	if (mp() && getPlayingPlayerCount() > 1) {
		//On MP, instead of blocking around the last gem, block around the player
		// currently in the lead. This should create closer games and discourage
		// camping for gems.

		//Find the leader
		%leader = -1;
		%loser = -1;
		for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
			%client = ClientGroup.getObject(%i);
			if (%client.spectating)
				continue;
			//If we have more, we're the leader
			if (%leader == -1 || %client.gemCount > %leader.gemCount)
				%leader = %client;
			//If we have fewe, we're the loser
			if (%loser == -1 || %client.gemCount < %loser.gemCount)
				%loser = %client;
		}

		//Difference in points determines spawn block multiplier. Range is [0, 3]x original size.
		// If you have the same score, then the block radius is nearly zero.
		// If you have twice the score then the radius is twice as large, etc
		%ratio = mClamp(((%leader.gemCount / max(%loser.gemCount, 1)) - 1) * 2, 0, 3);

		%blockCenter = %leader.player.getPosition();
		%spawnBlock *= %radius;
	} else {
		%lastSpawn = $Game::LastGemSpawner;
		devecho("Last spawn is" SPC %lastSpawn);
		if (isObject(%lastSpawn)) {
			%blockCenter = getWords(%lastSpawn.getTransform(), 0, 2);
			devecho("Won't spawn any gems inside the radius of " @ %spawnBlock @ " from the last gem");
			devecho("Last pos is" SPC %blockCenter);
		}
	}
	%furthest = 0;
	%furthestDist = 0;

	// Fuck getRandomSeed. Fuck it. Fuck. This is the most confusing thing
	// ever. It resets every time you call getRandom, unless it is 0, but then it
	// will only ever give you 0 for a random. FUCK. THIS. GAAAAAAAAAAAAAAH
	// Future me after taking a course in cryptography: lmao this is an LCG and if
	// you seed it with zero you'll get a confused 2013 me.
	if (getRandomSeed() == 0)
		setRandomSeed(getRealTime());

	setGemGroups(%groups);

	// Find a bunch of gems that could be the center, then pick a random one below
	%validCenters = Array(HuntValidCentersArray);

	for (%i = 0; %i < 10; %i ++) {
		%gem = $Gems[getRandom(0, $GemsCount - 1)];
		if (!isObject(%gem))
			continue;
		if (findWord(%exclude, %gem) != -1)
			continue;
		if (isObject(%lastSpawn) && %lastSpawn.getClassName() $= "Item") {
			// Compare positions
			%gemPos = getWords(%gem.getTransform(), 0, 3);
			%dist = VectorDist(%gemPos, %blockCenter) + %gem._spawnWeight;

			// OK I JUST FIGURED THIS OUT
			// APPARENTLY I'M SMARTER THAN MYSELF.... WHY?!

			// If the gem is not a candidate for spawning, store it in
			// case we can't spawn any. If it is the furthest of the bad spawns,
			// we'll spawn it.
			if (%dist < %spawnBlock) {
				// Store furthest group out of all in case no gem can
				// be found to spawn.
				if (%validCenters.getSize() == 0 && %dist > %furthestDist) {
					%furthestDist = %dist - %gem._spawnWeight;
					%furthest = %gem;
					devecho("Tested gem " @ %gem @ " is too close (but the furthest we've found so far): " @ %dist);
				}
				continue;
			} else {
				devecho("Tested gem " @ %gem @ " is far enough: " @ %dist @ " > " @ %spawnBlock);
				// If this gem works as a spawn center, USE IT USE IT
				%validCenters.addEntry(%gem);
			}
		} else {
			devecho("No lastSpawn, so we're just going with the first thing we got");
			// If lastSpawn is not a Gem, then any spawn should work
			%validCenters.addEntry(%gem);
		}
	}
	if (%furthest) {
		%validCenters.addEntry(%furthest);
	}
	if (getHuntSpawnType() > 0) {
		//MAX POINTS (menu only)
		//Find highest point valued gems, and then only spawn one of those
		%highest = 0;
		for (%i = 0; %i < $GemsCount; %i ++) {
			%gem = $Gems[%i];
			if (%gem._huntDatablock.huntExtraValue > %highest) {
				%highest = %gem._huntDatablock.huntExtraValue;
			}
		}
		devecho("Highest points is " @ %highest);
		%validCenters.delete();
		%validCenters = Array(HuntValidCentersArray);
		for (%i = 0; %i < $GemsCount; %i ++) {
			%gem = $Gems[%i];
			if (%gem._huntDatablock.huntExtraValue == %highest) {
				%validCenters.addEntry(%gem);
			}
		}
	}

	for (%i = 0; %i < %validCenters.getSize(); %i ++) {
		%gem = %validCenters.getEntry(%i);
		devecho("Valid center: " @ %gem @ ", value: " @ (1 + %gem._huntDatablock.huntExtraValue));
	}

	%ret = "";
	for (%i = 0; %i < %count; %i ++) {
		%bestDistance = 0;
		for (%j = 0; %j < 5; %j ++) {
			%test = %validCenters.getEntry(getRandom(0, %validCenters.getSize() - 1));

			%totalDistance = 0;
			for (%k = 0; %k < %i; %k ++) {
				%totalDistance += VectorDist(%test.position, %center[%k].position);
			}

			if (%totalDistance >= %bestDistance) {
				%center[%i] = %test;
				%bestDistance = %totalDistance;
			}
		}
		devecho("Center " @ %i @ " dist is" SPC VectorDist(%center[%i].getPosition(), %blockCenter));
		%ret = addField(%ret, %center[%i]);
	}

	%validCenters.delete();

	return %ret;
}

function SortHuntValue(%a, %b) {
	return %a._huntDatablock.huntExtraValue > %b._huntDatablock.huntExtraValue;
}

function spawnGemGroupSet(%center, %exclude) {
	RootGroup.add(%spawnSet = new SimSet(SpawnSet));

	//Spawn at most spawnCount gems inside spawnRadius (although radius is ignored if we
	// cannot get enough gems).
	%spawnCount = (MissionInfo.maxGemsPerSpawn ? MissionInfo.maxGemsPerSpawn : $Hunt::MaxGemsPerSpawn);
	%spawnRadius = (MissionInfo.radiusFromGem ? MissionInfo.radiusFromGem : $Hunt::RadiusFromGem);

	//So we don't get small spawns:
	// Need both minPoints points AND minCount gems per spawn.
	// If we don't get that, loop (until maxLoops times) growing the spawn radius
	// until we can find enough gems.
	%minPoints = (MissionInfo.minPointsPerSpawn ? MissionInfo.minPointsPerSpawn : $Hunt::MinPointsPerSpawn);
	%minCount = (MissionInfo.minGemsPerSpawn ? MissionInfo.minGemsPerSpawn : $Hunt::MinGemsPerSpawn);
	%maxLoops = $Hunt::MaxSpawnSearchLoops;

	if (mp() && $MPPref::Server::SpawnRamp && !$Game::isMode["coop"]) {
		%elapsedTime = $Time::ElapsedTime / Mode::callback("getStartTime", 0);
		%scaled = %minPoints * (%spawnCount / %minCount);
		%maxPoints = mRound((%minPoints + %scaled * 2 * %elapsedTime));
		//%minCount = mRound(%minCount * 1.5);
		%spawnCount = mRound(%spawnCount * (0.75 + %elapsedTime * 0.5));

		devecho("spawnCount: " @ %spawnCount);
		devecho("spawnRadius: " @ %spawnRadius);
		devecho("minPoints: " @ %minPoints);
		devecho("minCount: " @ %minCount);
		devecho("maxLoops: " @ %maxLoops);
		devecho("elapsedTime: " @ %elapsedTime);
		devecho("maxPoints min: " @ (%minPoints + %scaled * 2 * 0));
		devecho("maxPoints max: " @ (%minPoints + %scaled * 2 * 1));
		devecho("maxPoints: " @ %maxPoints);


	} else {
		%maxPoints = 9999;
	}


	if (getHuntSpawnType() > 1) {
		//First spawn / menu go for a full spawn, looks nicer
		%minCount = %spawnCount;
	}

	%centerPos = getWords(%center.getTransform(), 0, 3);

	//Keep track of what we've selected so we don't get too few points
	%spawned = 1;
	%points = 1 + %center._huntDatablock.huntExtraValue;
	%loops = 0;

	%spawnSet.add(%center);
	%spawnSet.onNextFrame(delete);

	%spawnables = Array(HuntSpawnablesArray);

	//Get a list of gems that we can spawn. Make sure we'll have enough for the
	// selection loop below (or we loop too much).
	while ((%points < %minPoints || %spawnables.getSize() < %minCount) && %loops < 2) {
		for (%i = 0; %i < $GemsCount; %i ++) {
			%gem = $Gems[%i];
			if ((findWord(%exclude, %gem) != -1) || %gem == %center)
				continue;
			if (%spawnables.containsEntry(%gem))
				continue;
			%gemPos = getWords(%gem.getTransform(), 0, 3);

			%dist = VectorSub(%gemPos, %centerPos);
			if (VectorLen(%dist) < %spawnRadius) {
				%value = 1 + %gem._huntDatablock.huntExtraValue;
				%spawnables.addEntry(%gem);
				//Higher gem weights mean the gems are more likely to be spawned.
				%gem._weight = %spawnRadius - VectorLen(%dist) - mAbs(getWord(%dist, 2)) + getRandom(0, (%gem._huntDatablock.huntExtraValue * 1) + 3);
				%points += %value;
			}
		}
		//Magic constant: increase radius so we can get more gems in the group
		%spawnRadius *= 2;
		%loops ++;
		devecho("Loop " @ %loops @ " of gem search total found " @ %spawnables.getSize() @ " gems");
	}
	%spawnables.sort(SortSpawnWeight);

	%spawned = 1;
	%points = 1 + %center._huntDatablock.huntExtraValue;
	%loops = 0;

	//Spawn gems until we have enough points and enough gems (or we loop too much).
	while ((%points < %minPoints || %spawned < %minCount) && %loops < %maxLoops) {
		devecho("Found" SPC %spawnables.getSize() SPC "gems, can only spawn up to" SPC %spawnCount);

		//Subtract one for the center gem which is already counted
		%count = min(%spawnables.getSize(), %spawnCount - 1);
		for (%i = 0; %i < %count; %i ++) {
			%gem = %spawnables.getEntry(%i);
			%dist = VectorSub(%gem.getPosition(), %centerPos);
			devecho("Gem" SPC %gem SPC "dist" SPC %dist SPC "(length " @ VectorLen(%dist) @ ")" SPC "weight" SPC %gem._weight);
			//Don't re-spawn something that is already spawned
			if (SpawnedSet.isMember(%gem)) {
				continue;
			}
			//PQ gems have a chance to (not) spawn
			if (!testSpawn(%gem)) {
				continue;
			}
			%value = 1 + %gem._huntDatablock.huntExtraValue;
			if (%points + %value > %maxPoints) {
				devecho("Rejected " @ %gem @ " because it would make total " @ (%points + %value) @ " but max is " @ %maxPoints);
				continue;
			}
			%spawnSet.add(%gem);
			%points += %value;
			%spawned ++;
		}
		%loops ++;
	}
	%spawnables.delete();

	// Get the furthest gem
	%maxDist = 0;
	for (%i = 0; %i < %spawned; %i ++) {
		%gem = %spawnables.spawned[%i];
		%dist = VectorDist(%gem.position, %centerPos);
		if (%dist > %maxDist)
			%maxDist = %dist;
	}

	// Apply spawn weights
	for (%i = 0; %i < %spawned; %i ++) {
		%gem = %spawnables.spawned[%i];
		%dist = VectorDist(%gem.position, %centerPos);
		%dist /= %maxDist;
		%dist = mFloor((1 - %dist) * 10);
		%gem._spawnWeight += %dist;
	}

	// Fix spawn weights so we don't get gems with 10000 spawn weight
	%min = 9999;
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];
		if (%gem._spawnWeight < %min) {
			%min = %gem._spawnWeight;
			//echo(%gem SPC %gem._spawnWeight SPC %min);
		}
	}

	if (%min) {
		//echo("Lowering total gem weight by" SPC %min);
		for (%i = 0; %i < $GemsCount; %i ++) {
			%gem = $Gems[%i];
			%gem._spawnWeight -= %min;
		}
	}

	devecho("Final spawn is " @ %spawned @ " gems for a total " @ %points @ " points.");

	return %spawnSet;
}

function SortSpawnWeight(%a, %b) {
	return %a._weight > %b._weight;
}

function testSpawn(%gem) {
	//Fake having nice things on the menu
	if (getHuntSpawnType() > 1) {
		return true;
	}
	// Check for PQ-spawn mechanics
	if (MissionInfo.game $= "PlatinumQuest") {
		%db = %gem.getDataBlock().getName();
		%color = %gem._huntColor;

		%chance = MissionInfo.spawnChance[%color];
		if (%chance $= "")
			%chance = MissionInfo.getFieldValue(%color @ "SpawnChance");
		if (%chance $= "")
			%chance = %db.spawnChance;
		if (%chance $= "")
			%chance = $Hunt::SpawnChance[%color];

		%test = getRandom();

		if ($spawns)
			echo("checking" SPC %gem SPC "chance" SPC %chance SPC "got" SPC %test);

		// Spawn chance
		if (%test > %chance) {
			//echo("Failed");
			return false;
		}
	}
	return true;
}

function getHuntSpawnType() {
	if ($Game::Menu) {
		return 2;
	} else if ($Game::FirstSpawn && !mp()) {
		return 1;
	}
	return 0;
}

function resetSpawnWeights() {
	makeGemGroup(MissionGroup, true);
	makeGemGroup(MissionCleanup);

	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];
		%gem._spawnWeight = 0;
	}
}

function spawnGem(%gem) {
	if (!isObject(%gem))
		return false;

	if (%gem._huntDatablock.huntExtraValue $= "") {
		// If it's not a red/yellow/blue gem, make it a red gem
		%gem.setDataBlock(GemItemRed);
		%gem.setSkinName("red");
	}
	if (!isObject(SpawnedSet))
		RootGroup.add(new SimSet(SpawnedSet));

	SpawnedSet.add(%gem);
	%gem._leftBehind = false; // For competitive

	if ($MP::FinalSpawn)
		return true;

	if (%gem.isHidden()) {
		%gem.hide(false);

		if (%gem.path !$= "") {
			%gem.resetPath();
			%gem.moveOnPath(%gem.path);
		}

		if (%gem.getDataBlock().pq && !isObject(%gem.fx)) {
			%gem.getDatablock().initFX(%gem);
		}
		addGemLight(%gem);
		if (!$Server::Dedicated)
			%gem.setRadarTarget();
		$Hunt::CurrentGemCount ++;
	}

	return true;
}

function getCurrentSpawnScore() {
	%score = 0;
	for (%i = 0; %i < SpawnedSet.getCount(); %i ++) {
		%score += 1 + SpawnedSet.getObject(%i)._huntDatablock.huntExtraValue;
	}
	return %score;
}
$Hunt::CurrentCompetitivePointsLeftBehind = 0;
function unspawnGem(%gem, %nocheck) {
	if (!isObject(%gem))
		return;
	if (!isObject(SpawnedSet))
		RootGroup.add(new SimSet(SpawnedSet));
	if (SpawnedSet.isMember(%gem))
		SpawnedSet.remove(%gem);
	if ($Hunt::CurrentGemCount > 0)
		$Hunt::CurrentGemCount --;
	if (%gem._leftBehind) {
		$Hunt::CurrentCompetitivePointsLeftBehind -= %gem._huntDatablock.huntExtraValue + 1;
	}

	devecho("Unspawn");
	devecho($Hunt::CurrentCompetitivePointsLeftBehind);
	if ($MPPref::Server::CompetitiveMode && $Game::Running && !%nocheck) {
		// If current gem POINTS of the current spawn are 2 or less, respawn.
		// This leaves some gems behind. The number of gems left behind should be tracked.
		%curspawn = getCurrentSpawnScore() - $Hunt::CurrentCompetitivePointsLeftBehind;
		if (%curspawn <= 2) {
			// all previously left behind gems disappear, all gems now are considered 'left behind'
			for (%i = SpawnedSet.getCount() - 1; %i >= 0; %i --) {
				%gem2 = SpawnedSet.getObject(%i);
				if (%gem2._leftBehind == true) {
					%gem2._leftBehind = false;
					unspawnGem(%gem2, 1); // (, 1) so this doesn't recurse
				} else {
					%gem2._leftBehind = true;
					%gem2._light.setSkinName("black");
				}
			}
			$Hunt::CurrentCompetitivePointsLeftBehind = %curspawn; // %curspawn is the old leftbehind plus the current spawn. We are removing those now, so the current spawn is our new leftbehind.
			spawnHuntGemGroup(%gem);
		}
	} else {
		%gem._leftBehind = false;
		if ($Hunt::CurrentGemCount <= 0 && !%nocheck)
			spawnHuntGemGroup(%gem);
	}
	//Nukesweeper deletes gems, causes warnings
	if (!isObject(%gem))
		return;

	removeGemLight(%gem);
	%gem.getDataBlock().clearFX(%gem);
	%gem.hide(true);
}

function spawnBackupGem(%gem) {
	MissionCleanup.add(%obj = new Item() {
		position = %gem.position;
		rotation = %gem.rotation;
		scale = %gem.scale;
		datablock = "BackupGem";
		collideable = "0";
		static = "1";
		rotate = "1";
		_huntDatablock = %gem._huntDatablock;
		_huntColor = %gem._huntColor;
		_gem = %gem;
	});

	%obj.schedule($MPPref::Server::PingStealFix, delete);
	return %obj;
}

function BackupGem::onPickup(%this, %obj, %user, %amount) {
	if (!%obj._finder[%user]) {
		%obj._finder[%user] = true;
		huntStoreGem(%user.client, %obj._huntDatablock.huntExtraValue, %obj._huntDatablock.messageColor);
		%user.client.gemsFoundTotal ++;
		%user.client.onFoundGem(%amount, %obj);
	}
}

// hides *ALL* the gems
function hideGems() {
	$Hunt::CurrentGemCount = 0;
	makeGemGroup(MissionGroup, true);
	makeGemGroup(MissionCleanup);
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];
		unspawnGem(%gem, true);
	}
}

// Shows all gems, but without gemlights / gemcount
// Used only by the level editor
function showGems() {
	hideGems();
	$Hunt::CurrentGemCount = 0;
	makeGemGroup(MissionGroup, true);
	makeGemGroup(MissionCleanup);
	if ($Game::IsMode["hunt"]) {
		for (%i = 0; %i < $GemsCount; %i ++) {
			%gem = $Gems[%i];
			if (!isObject(%gem))
				continue;
			%gem.hide(false);
		}
	}
}

function addGemLight(%gem) {
	if (!isObject(%gem)) return false;
	if (isObject(%gem._light)) return false;
	if (%gem.noLight) return false;

	MissionCleanup.add(%gem._light = new StaticShape() {
		datablock = "GemLight";
		position = %gem.position;
		rotation = %gem.rotation;
		scale = %gem.scale;
	});

	%gem._light.setSkinName(%gem.getDataBlock().skin);
	if (%gem.getDataBlock().skin $= "default" || %gem.getDataBlock().skin $= "")
		%gem.setSkinName("red");
	if (isServerMovingObject(%gem)) {
		%gem._light.setParent(%gem, "0 0 0 1 0 0 0", true, "0 0 0");
		//If this is the first spawn, this won't go through
		%gem._light.schedule(100, setParent, %gem, "0 0 0 1 0 0 0", true, "0 0 0");
	}
	return %gem._light;
}

function removeGemLight(%gem) {
	if (!isObject(%gem)) return false;
	if (!isObject(%gem._light)) return false;

	%gem._light.delete();
	%gem._light = "";
}

// copied gem group function from emerald*
// This was originally in emerald, moved to opal, then PR, then elite, now it's here! Hooray!
function makeGemGroup(%group, %reset) {
	//echo("Making gem group for group" SPC %group);
	if (%reset) {
		$GemsCount = 0;
	}
	// Get all gems out there are in the world
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i++) {
		%object = %group.getObject(%i);
		%type = %object.getClassName();
		if (%type $= "SimGroup") {
			makeGemGroup(%object, false);
		} else {
			if (%type $= "Item" && %object.getDatablock().classname $= "Gem") {
				$Gems[$GemsCount] = %object;
				$GemsCount ++;
			}
		}
	}
}

function setGemGroups(%groups) {
	%groups = nextToken(%groups, "group", ";");
	makeGemGroup(%group, true);

	while (%groups !$= "") {
		%groups = nextToken(%groups, "group", ";");
		makeGemGroup(%group);
	}
}

function updateGemCount() {
	makeGemGroup(MissionGroup, true);
	makeGemGroup(MissionCleanup);

	$Hunt::CurrentGemCount = 0;
	for (%i = 0; %i < $GemsCount; %i ++) {
		%gem = $Gems[%i];
		if (!%gem.isHidden())
			$Hunt::CurrentGemCount ++;
	}
}

// Average all group element positions
function SimSet::getPosition(%this) {
	%center = "";
	%elements = %this.getCount();
	for (%i = 0; %i < %elements; %i ++) {
		%elem = %this.getObject(%i);
		%elemPos = %elem.getPosition();
		%center = VectorAdd(%center, %elemPos);
	}
	%center = VectorScale(%center, 1 / %elements);
	return %center;
}
