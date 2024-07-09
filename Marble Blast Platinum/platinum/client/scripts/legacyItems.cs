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

//-----------------------------------------------------------------------------
// Legacy Items option
//-----------------------------------------------------------------------------

function applyLegacyItems() {
	if ($pref::legacyItems ? MegaMarbleItem_MBU.shapeFile !$= "platinum/data/shapes/items/MegaMarble.dts" : MegaMarbleItem_MBU.shapeFile !$= "platinum/data/shapes_mbu/images/megamarble.dts") {
		MegaMarbleItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/MegaMarble.dts" : "platinum/data/shapes_mbu/images/megamarble.dts");
		SuperJumpItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/superjump.dts" : "platinum/data/shapes_mbu/items/superjump.dts");
		HelicopterItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/images/helicopter.dts" : "platinum/data/shapes_mbu/images/helicopter.dts");
		SuperSpeedItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/superspeed.dts" : "platinum/data/shapes_mbu/items/superspeed.dts");
		BlastItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/blast.dts" : "platinum/data/shapes_mbu/images/blast.dts");
		EasterEgg_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/easteregg.dts" : "platinum/data/shapes_mbu/items/egg.dts");
		NoRespawnAntiGravityItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/antiGravity.dts" : "platinum/data/shapes_mbu/items/antiGravity.dts");
		AntiGravityItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/antiGravity.dts" : "platinum/data/shapes_mbu/items/antiGravity.dts");
		TimeTravelItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/timetravel.dts" : "platinum/data/shapes_mbu/items/timetravel.dts");
		TimePenaltyItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/timetravel.dts" : "platinum/data/shapes_mbu/items/timetravel.dts");
		RoundBumper_Original.reloadShape($pref::legacyItems ? "platinum/data/shapes/bumpers/pball_round.dts" : "platinum/data/shapes_mbu/bumpers/mbgbumperedit.dts");
		TrapDoor_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/hazards/trapdoor.dts" : "platinum/data/shapes_mbu/hazards/trapdoor.dts");
		Ductfan_MBM.reloadShape($pref::legacyItems ? "platinum/data/shapes/hazards/ductfan.dts" : "platinum/data/shapes_mbu/hazards/ductfan.dts");
		SmallDuctFan_MBM.reloadShape($pref::legacyItems ? "platinum/data/shapes/hazards/ductfan.dts" : "platinum/data/shapes_mbu/hazards/ductfan.dts");
		EndPad_MBM.reloadShape($pref::legacyItems ? "platinum/data/shapes/pads/endarea.dts" : "platinum/data/shapes_mbu/pads/endarea.dts");
		StartPad_MBM.reloadShape($pref::legacyItems ? "platinum/data/shapes/pads/startarea.dts" : "platinum/data/shapes_mbu/pads/startarea.dts");
		GemItem_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/gem.dts" : "platinum/data/shapes_mbu/items/gem.dts");
		GemItemRed_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/gem.dts" : "platinum/data/shapes_mbu/items/gem.dts");
		GemItemYellow_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/gem.dts" : "platinum/data/shapes_mbu/items/gem.dts");
		GemItemBlue_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/gem.dts" : "platinum/data/shapes_mbu/items/gem.dts");
		GemItemPlatinum_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/items/gem.dts" : "platinum/data/shapes_mbu/items/gem.dts");
		Astrolabe.reloadShape($pref::legacyItems ? "platinum/data/shapes_mbu/astrolabe/legacy/Ball.dts" : "platinum/data/shapes_mbu/astrolabe/Astrolabe.dts");
		ArrowUp.reloadShape($pref::legacyItems ? "platinum/data/shapes/signs/signup.dts" : "platinum/data/shapes_mbu/signs/arrowsign_up.dts");
		ArrowSide.reloadShape($pref::legacyItems ? "platinum/data/shapes/signs/signside.dts" : "platinum/data/shapes_mbu/signs/arrowsign_side.dts");
		ArrowDown.reloadShape($pref::legacyItems ? "platinum/data/shapes/signs/signdown.dts" : "platinum/data/shapes_mbu/signs/arrowsign_down.dts");
		if (HelicopterImage_MBU.stateSequence[0] $= "")
			HelicopterImage_MBU.stateSequence[0] = "rotate";
		if (HelicopterImage_MBUBall.stateSequence[0] $= "")
			HelicopterImage_MBUBall.stateSequence[0] = "rotate";
		HelicopterImage_MBU.reloadShape($pref::legacyItems ? "platinum/data/shapes/images/helicopter.dts" :  "platinum/data/shapes_mbu/images/helicopter_image.dts");
		HelicopterImage_MBUBall.reloadShape($pref::legacyItems ? "platinum/data/shapes/images/helicopter.dts" : "platinum/data/shapes_mbu/images/helicopter_image_mbu.dts");
		$PlayGuiGem = true;
		$PlayGuiTT = true;
		PlayGui.updateGems();
	}

	%astrolabe = findAstrolabe(ServerConnection);
	if (%astrolabe != -1) {
		%astrolabe.setFieldValue("isAstrolabe", true);
		if (!$pref::legacyItems) {
			%astrolabe.stopThread(0);
			%astrolabe.setDatablock("Astrolabe");
			%astrolabe.setScale("1 1 1");
			%astrolabe.setTransform("0 0 -600");
			%astrolabe.playThread(0, "ambient");
		} else {
			%astrolabe.stopThread(0);
			%sky = findSky(ServerConnection);
			%distance = %sky.getFieldValue("visibleDistance") - 50;
			%astrolabe.setScale(%distance SPC %distance SPC %distance);
			%astrolabe.setTransform("0 0 0");
			%astrolabe.setDatablock($MissionType $= "beginner" ? "clear" : ($MissionType $= "Intermediate" ? "dusk" : ($MissionType $= "Advanced" ? "wintry" : "clear")));
			%material = %sky.getFieldValue("materialList");
			if ($CurrentGame $= "Custom" || PlayMissionGui.ml == getMissionList("marbleland")) {
				if (%material $= "platinum/data/skies_mbu/beginner/sky_beginner.dml" || %material $= "platinum/data/skies/beginner/Beginner_Sky.dml" || %material $= "platinum/data/skies_pq/Blender3/blender3.dml" || %material $= "platinum/data/skies_pq/Blender1/blender1.dml")
					%astrolabe.setDatablock("clear");
				else if (%material $= "platinum/data/skies_mbu/intermediate/sky_intermediate.dml" || %material $= "platinum/data/skies/intermediate/Intermediate_Sky.dml" || %material $= "platinum/data/skies_pq/Blender2/blender2.dml")
					%astrolabe.setDatablock("dusk");
				else if (%material $= "platinum/data/skies_mbu/advanced/sky_advanced.dml" || %material $= "platinum/data/skies/advanced/Advanced_Sky.dml" || %material $= "platinum/data/skies_pq/Blender4/blender4.dml" || %material $= "platinum/data/skies_pq/Wave/wave.dml" || %material $= "platinum/data/skies/expert/Expert_Sky.dml")
					%astrolabe.setDatablock("wintry");
			}
			if (MissionInfo.legacySky !$= "" && (MissionInfo.legacySky $= "clear" || MissionInfo.legacySky $= "dusk" || MissionInfo.legacySky $= "wintry" || MissionInfo.legacySky $= "vermontry"))
				%astrolabe.setDatablock(MissionInfo.legacySky);
			%astrolabe.playThread(0, "Rotate");
		}
	}
}

function createOldMPSky() {
	if ($CurrentGame !$= "Hunt" && $CurrentGame !$= "CustomHunt")
		return;

	if (isObject(OldMPSky))
		return;

	%sky = findSky(MissionGroup);
	%material = %sky.getFieldValue("materialList");

	if (%material $= "platinum/data/skies/Cloudy/cloudy.dml")
		return;
	for (%i = 0; %i < MissionGroup.getCount(); %i ++) {
		%obj = MissionGroup.getObject(%i);
		if (%obj.getClassName() !$= "StaticShape")
			continue;
		%db = %obj.getDatablock().getName();
		if (!%obj.getFieldValue("isAstrolabe") && (%db $= "clear" || %db $= "dusk" || %db $= "wintry" || %db $= "vermontry")) {
			return;
		}
	}

	%sky.visibleDistance = 10050;
	%sky.inspectPostApply();

	MissionCleanup.add(new StaticShape(OldMPSky) {
		position = "0 0 0";
		rotation = "1 0 0 0";
		scale = "10000 10000 10000";
		dataBlock = ($MissionType $= "beginner" ? "clear" : ($MissionType $= "Intermediate" ? "dusk" : ($MissionType $= "Advanced" ? "wintry" : "clear")));
	});
	OldMPSky.playThread(0, "Rotate");

	if ($MissionType $= "Custom") {
		if (%material $= "platinum/data/skies_mbu/beginner/sky_beginner.dml" || %material $= "platinum/data/skies/beginner/Beginner_Sky.dml" || %material $= "platinum/data/skies_pq/Blender3/blender3.dml" || %material $= "platinum/data/skies_pq/Blender1/blender1.dml")
			OldMPSky.setDatablock("clear");
		else if (%material $= "platinum/data/skies_mbu/intermediate/sky_intermediate.dml" || %material $= "platinum/data/skies/intermediate/Intermediate_Sky.dml" || %material $= "platinum/data/skies_pq/Blender2/blender2.dml")
			OldMPSky.setDatablock("dusk");
		else if (%material $= "platinum/data/skies_mbu/advanced/sky_advanced.dml" || %material $= "platinum/data/skies/advanced/Advanced_Sky.dml" || %material $= "platinum/data/skies_pq/Blender4/blender4.dml" || %material $= "platinum/data/skies_pq/Wave/wave.dml" || %material $= "platinum/data/skies/expert/Expert_Sky.dml")
			OldMPSky.setDatablock("wintry");
	}

	if (MissionInfo.legacySky !$= "" && (MissionInfo.legacySky $= "clear" || MissionInfo.legacySky $= "dusk" || MissionInfo.legacySky $= "wintry" || MissionInfo.legacySky $= "vermontry"))
		OldMPSky.setDatablock(MissionInfo.legacySky);

	OldMPSky.setScopeAlways();
	OldMPSky.forceNetUpdate();
}

function applyOldMPSky() {
	if ($CurrentGame !$= "Hunt" && $CurrentGame !$= "CustomHunt")
		return;

	%astrolabe = findAstrolabe(ServerConnection);
	%oldSky = findLegacySky(ServerConnection);

	if (%oldSky == -1)
		return;

	if ($pref::legacyItems > 1) {
		if (MissionInfo.legacySky $= "cloudy") {
			changeEnvironment("", "", "", "platinum/data/skies/Cloudy/cloudy.dml");
			%oldSky.hide(true);
		} else {
			%oldSky.hide(false);
			if (isObject(%astrolabe)) {
				%astrolabe.hide(true);
			}
		}
	} else {
		if (MissionInfo.legacySky $= "cloudy") {
			resetEnvironment();
			%oldSky.hide(true);
		} else {
			%oldSky.hide(true);
			if (isObject(%astrolabe)) {
				%astrolabe.hide(false);
			}
		}
	}
}

//-----------------------------------------------------------------------------
// Particle System option
//-----------------------------------------------------------------------------

function applyParticleSystem() {
	//Marble Blast Ultra
	if ($pref::Video::particleSystem == 2) {
		BounceParticle.reloadShape("platinum/data/particles/mbu/smoke");
		BounceParticle.dragCoefficient = "0";
		BounceParticle.windCoefficient = "0";
		BounceParticle.gravityCoefficient = "-0.100122";
		BounceParticle.inheritedVelFactor = "0";
		BounceParticle.constantAcceleration = "-2";
		BounceParticle.lifetimeMS = "384";
		BounceParticle.lifetimeVarianceMS = "32";
		BounceParticle.spinSpeed = "90";
		BounceParticle.spinRandomMin = "-90";
		BounceParticle.spinRandomMax = "90";
		BounceParticle.useInvAlpha = "0";
		BounceParticle.animateTexture = "0";
		BounceParticle.framesPerSec = "1";
		BounceParticle.colors[0] = "0.500000 0.500000 0.500000 0.299213";
		BounceParticle.colors[1] = "0.299213 0.299213 0.196850 0.102362";
		BounceParticle.colors[2] = "0.196850 0.196850 0.102362 0.000000";
		BounceParticle.colors[3] = "1.000000 1.000000 1.000000 1.000000";
		BounceParticle.sizes[0] = "0.399805";
		BounceParticle.sizes[1] = "0.201428";
		BounceParticle.sizes[2] = "0.100714";
		BounceParticle.sizes[3] = "1";
		BounceParticle.times[0] = "0";
		BounceParticle.times[1] = "0.74902";
		BounceParticle.times[2] = "1";
		BounceParticle.times[3] = "2";
		BounceParticle.dragCoeffiecient = "0.5";

		MarbleBounceEmitter.className = "ParticleEmitterData";
		MarbleBounceEmitter.ejectionPeriodMS = "5";
		MarbleBounceEmitter.periodVarianceMS = "1";
		MarbleBounceEmitter.ejectionVelocity = "6";
		MarbleBounceEmitter.velocityVariance = "0.25";
		MarbleBounceEmitter.ejectionOffset = "0";
		MarbleBounceEmitter.thetaMin = "80";
		MarbleBounceEmitter.thetaMax = "90";
		MarbleBounceEmitter.phiReferenceVel = "0";
		MarbleBounceEmitter.phiVariance = "360";
		MarbleBounceEmitter.overrideAdvance = "0";
		MarbleBounceEmitter.orientParticles = "0";
		MarbleBounceEmitter.orientOnVelocity = "1";
		MarbleBounceEmitter.particles = "BounceParticle";
		MarbleBounceEmitter.lifetimeMS = "224";
		MarbleBounceEmitter.lifetimeVarianceMS = "0";
		MarbleBounceEmitter.useEmitterSizes = "0";
		MarbleBounceEmitter.useEmitterColors = "0";
		MarbleBounceEmitter.oldPeriod = "10";
		MarbleBounceEmitter.newVarianceMS = "1";
		MarbleBounceEmitter.newPeriod = "5";
		MarbleBounceEmitter.oldVarianceMS = "0";
		MarbleBounceEmitter.periodModified = "1";

		%count = MarbleDataSet.getCount();
		for (%i = 0; %i < %count; %i ++) {
			MarbleDataSet.getObject(%i).setFieldValue("trailEmitter", "");
		}

		MarbleTrailParticle.reloadShape("platinum/data/particles/blank");
		// MarbleTrailParticle.dragCoeffiecient     = "1.0";
		// MarbleTrailParticle.gravityCoefficient   = "0";
		// MarbleTrailParticle.windCoefficient      = "0";
		// MarbleTrailParticle.inheritedVelFactor   = "1";
		// MarbleTrailParticle.constantAcceleration = "0";
		// MarbleTrailParticle.lifetimeMS           = "100;
		// MarbleTrailParticle.lifetimeVarianceMS   = "10";
		// MarbleTrailParticle.useInvAlpha =  "1";
		// MarbleTrailParticle.spinSpeed     = "0";
		// MarbleTrailParticle.colors[0]     = "1 1 0 0.0";
		// MarbleTrailParticle.colors[1]     = "1 1 0 1";
		// MarbleTrailParticle.colors[2]     = "1 1 1 0.0";
		// MarbleTrailParticle.sizes[0]      = "0.7";
		// MarbleTrailParticle.sizes[1]      = "0.4";
		// MarbleTrailParticle.sizes[2]      = "0.1";
		// MarbleTrailParticle.times[0]      = "0";
		// MarbleTrailParticle.times[1]      = "0.15";
		// MarbleTrailParticle.times[2]      = "1.0";

		// MarbleTrailEmitter.ejectionPeriodMS = "9";
		// MarbleTrailEmitter.periodVarianceMS = "0";
		// MarbleTrailEmitter.ejectionVelocity = "3.0";
		// MarbleTrailEmitter.velocityVariance = "0.25";
		// MarbleTrailEmitter.thetaMin         = "60.0";
		// MarbleTrailEmitter.thetaMax         = "90.0";
		// MarbleTrailEmitter.lifetimeMS = "0";
		// MarbleTrailEmitter.lifetimeVarianceMS = "0";
		// MarbleTrailEmitter.particles = "MarbleTrailParticle";

		MarbleWhiteTrailParticle.reloadShape("platinum/data/particles/mbu/burst");
		MarbleWhiteTrailParticle.dragCoefficient = "0";
		MarbleWhiteTrailParticle.windCoefficient = "1";
		MarbleWhiteTrailParticle.gravityCoefficient = "0";
		MarbleWhiteTrailParticle.inheritedVelFactor = "0";
		MarbleWhiteTrailParticle.constantAcceleration = "0";
		MarbleWhiteTrailParticle.lifetimeMS = "1984";
		MarbleWhiteTrailParticle.lifetimeVarianceMS = "0";
		MarbleWhiteTrailParticle.spinSpeed = "0";
		MarbleWhiteTrailParticle.spinRandomMin = "-90";
		MarbleWhiteTrailParticle.spinRandomMax = "90";
		MarbleWhiteTrailParticle.useInvAlpha = "0";
		MarbleWhiteTrailParticle.animateTexture = "0";
		MarbleWhiteTrailParticle.framesPerSec = "1";
		MarbleWhiteTrailParticle.colors[0] = "0.500000 0.299213 0.196850 1.000000";
		MarbleWhiteTrailParticle.colors[1] = "0.500000 0.299213 0.196850 1.000000";
		MarbleWhiteTrailParticle.colors[2] = "0.196850 0.000000 0.000000 0.000000";
		MarbleWhiteTrailParticle.colors[3] = "1.000000 1.000000 1.000000 1.000000";
		MarbleWhiteTrailParticle.sizes[0] = "0.601233";
		MarbleWhiteTrailParticle.sizes[1] = "0.500519";
		MarbleWhiteTrailParticle.sizes[2] = "0.100714";
		MarbleWhiteTrailParticle.sizes[3] = "1";
		MarbleWhiteTrailParticle.times[0] = "0";
		MarbleWhiteTrailParticle.times[1] = "0.5";
		MarbleWhiteTrailParticle.times[2] = "1";
		MarbleWhiteTrailParticle.times[3] = "2";

		MarbleWhiteTrailEmitter.className = "ParticleEmitterData";
		MarbleWhiteTrailEmitter.ejectionPeriodMS = "5";
		MarbleWhiteTrailEmitter.periodVarianceMS = "1";
		MarbleWhiteTrailEmitter.ejectionVelocity = "3";
		MarbleWhiteTrailEmitter.velocityVariance = "0.25";
		MarbleWhiteTrailEmitter.ejectionOffset = "0";
		MarbleWhiteTrailEmitter.thetaMin = "60";
		MarbleWhiteTrailEmitter.thetaMax = "90";
		MarbleWhiteTrailEmitter.phiReferenceVel = "0";
		MarbleWhiteTrailEmitter.phiVariance = "360";
		MarbleWhiteTrailEmitter.overrideAdvance = "0";
		MarbleWhiteTrailEmitter.orientParticles = "0";
		MarbleWhiteTrailEmitter.orientOnVelocity = "1";
		MarbleWhiteTrailEmitter.particles = "MarbleWhiteTrailParticle";
		MarbleWhiteTrailEmitter.lifetimeMS = "0";
		MarbleWhiteTrailEmitter.lifetimeVarianceMS = "0";
		MarbleWhiteTrailEmitter.useEmitterSizes = "0";
		MarbleWhiteTrailEmitter.useEmitterColors = "0";
		MarbleWhiteTrailEmitter.oldPeriod = "9";
		MarbleWhiteTrailEmitter.newVarianceMS = "1";
		MarbleWhiteTrailEmitter.newPeriod = "5";
		MarbleWhiteTrailEmitter.oldVarianceMS = "0";
		MarbleWhiteTrailEmitter.periodModified = "1";

	//Marble Blast Gold
	} else if ($pref::Video::particleSystem == 1) {
		BounceParticle.reloadShape("platinum/data/particles/star");
		BounceParticle.dragCoefficient = "0";
		BounceParticle.windCoefficient = "0";
		BounceParticle.gravityCoefficient = "0";
		BounceParticle.inheritedVelFactor = "0";
		BounceParticle.constantAcceleration = "-2";
		BounceParticle.lifetimeMS = "480";
		BounceParticle.lifetimeVarianceMS = "96";
		BounceParticle.spinSpeed = "90";
		BounceParticle.spinRandomMin = "-90";
		BounceParticle.spinRandomMax = "90";
		BounceParticle.useInvAlpha = "1";
		BounceParticle.animateTexture = "0";
		BounceParticle.framesPerSec = "1";
		BounceParticle.colors[0] = "0.897638 0.000000 0.000000 1.000000";
		BounceParticle.colors[1] = "0.897638 0.897638 0.000000 1.000000";
		BounceParticle.colors[2] = "0.897638 0.897638 0.000000 0.000000";
		BounceParticle.colors[3] = "1.000000 1.000000 1.000000 1.000000";
		BounceParticle.sizes[0] = "0.250259";
		BounceParticle.sizes[1] = "0.250259";
		BounceParticle.sizes[2] = "0.250259";
		BounceParticle.sizes[3] = "1";
		BounceParticle.times[0] = "0";
		BounceParticle.times[1] = "0.74902";
		BounceParticle.times[2] = "1";
		BounceParticle.times[3] = "2";
		BounceParticle.dragCoeffiecient = "1";

		MarbleBounceEmitter.className = "ParticleEmitterData";
		MarbleBounceEmitter.ejectionPeriodMS = "40";
		MarbleBounceEmitter.periodVarianceMS = "1";
		MarbleBounceEmitter.ejectionVelocity = "3";
		MarbleBounceEmitter.velocityVariance = "0.25";
		MarbleBounceEmitter.ejectionOffset = "0";
		MarbleBounceEmitter.thetaMin = "80";
		MarbleBounceEmitter.thetaMax = "90";
		MarbleBounceEmitter.phiReferenceVel = "0";
		MarbleBounceEmitter.phiVariance = "360";
		MarbleBounceEmitter.overrideAdvance = "0";
		MarbleBounceEmitter.orientParticles = "0";
		MarbleBounceEmitter.orientOnVelocity = "1";
		MarbleBounceEmitter.particles = "BounceParticle";
		MarbleBounceEmitter.lifetimeMS = "224";
		MarbleBounceEmitter.lifetimeVarianceMS = "0";
		MarbleBounceEmitter.useEmitterSizes = "0";
		MarbleBounceEmitter.useEmitterColors = "0";
		MarbleBounceEmitter.oldPeriod = "80";
		MarbleBounceEmitter.newVarianceMS = "1";
		MarbleBounceEmitter.newPeriod = "40";
		MarbleBounceEmitter.oldVarianceMS = "0";
		MarbleBounceEmitter.periodModified = "1";

		%count = MarbleDataSet.getCount();
		for (%i = 0; %i < %count; %i ++) {
			MarbleDataSet.getObject(%i).setFieldValue("trailEmitter", MarbleTrailOldEmitter);
		}

		MarbleTrailParticle.reloadShape("platinum/data/particles/blank");
		// MarbleTrailParticle.dragCoefficient = "0";
		// MarbleTrailParticle.windCoefficient = "0";
		// MarbleTrailParticle.gravityCoefficient = "0";
		// MarbleTrailParticle.inheritedVelFactor = "1";
		// MarbleTrailParticle.constantAcceleration = "0";
		// MarbleTrailParticle.lifetimeMS = "96";
		// MarbleTrailParticle.lifetimeVarianceMS = "0";
		// MarbleTrailParticle.spinSpeed = "0";
		// MarbleTrailParticle.spinRandomMin = "0";
		// MarbleTrailParticle.spinRandomMax = "0";
		// MarbleTrailParticle.useInvAlpha = "1";
		// MarbleTrailParticle.animateTexture = "0";
		// MarbleTrailParticle.framesPerSec = "1";
		// MarbleTrailParticle.colors[0] = "1.000000 1.000000 0.000000 0.000000";
		// MarbleTrailParticle.colors[1] = "1.000000 1.000000 0.000000 1.000000";
		// MarbleTrailParticle.colors[2] = "1.000000 1.000000 1.000000 0.000000";
		// MarbleTrailParticle.colors[3] = "1.000000 1.000000 1.000000 1.000000";
		// MarbleTrailParticle.sizes[0] = "0.698895";
		// MarbleTrailParticle.sizes[1] = "0.399805";
		// MarbleTrailParticle.sizes[2] = "0.100714";
		// MarbleTrailParticle.sizes[3] = "1";
		// MarbleTrailParticle.times[0] = "0";
		// MarbleTrailParticle.times[1] = "0.14902";
		// MarbleTrailParticle.times[2] = "1";
		// MarbleTrailParticle.times[3] = "2";
		// MarbleTrailParticle.dragCoeffiecient = "1";

		// MarbleTrailEmitter.className = "ParticleEmitterData";
		// MarbleTrailEmitter.ejectionPeriodMS = "5";
		// MarbleTrailEmitter.periodVarianceMS = "1";
		// MarbleTrailEmitter.ejectionVelocity = "0";
		// MarbleTrailEmitter.velocityVariance = "0";
		// MarbleTrailEmitter.ejectionOffset = "0";
		// MarbleTrailEmitter.thetaMin = "80";
		// MarbleTrailEmitter.thetaMax = "90";
		// MarbleTrailEmitter.phiReferenceVel = "0";
		// MarbleTrailEmitter.phiVariance = "360";
		// MarbleTrailEmitter.overrideAdvance = "0";
		// MarbleTrailEmitter.orientParticles = "0";
		// MarbleTrailEmitter.orientOnVelocity = "1";
		// MarbleTrailEmitter.particles = "MarbleTrailParticle";
		// MarbleTrailEmitter.lifetimeMS = "9984";
		// MarbleTrailEmitter.lifetimeVarianceMS = "0";
		// MarbleTrailEmitter.useEmitterSizes = "0";
		// MarbleTrailEmitter.useEmitterColors = "0";
		// MarbleTrailEmitter.periodModified = "1";
		// MarbleTrailEmitter.oldPeriod = "5";
		// MarbleTrailEmitter.newVarianceMS = "1";
		// MarbleTrailEmitter.newPeriod = "3";
		// MarbleTrailEmitter.oldVarianceMS = "0";

		MarbleWhiteTrailParticle.reloadShape("platinum/data/particles/blank");
		// MarbleWhiteTrailParticle.dragCoeffiecient     = "1.0";
		// MarbleWhiteTrailParticle.gravityCoefficient   = "0";
		// MarbleWhiteTrailParticle.windCoefficient      = "0";
		// MarbleWhiteTrailParticle.inheritedVelFactor   = "1";
		// MarbleWhiteTrailParticle.constantAcceleration = "0";
		// MarbleWhiteTrailParticle.lifetimeMS           = "100";
		// MarbleWhiteTrailParticle.lifetimeVarianceMS   = "10";
		// MarbleWhiteTrailParticle.useInvAlpha =  "1";
		// MarbleWhiteTrailParticle.spinSpeed     = "0";
		// MarbleWhiteTrailParticle.colors[0]     = "1 1 0 0.0";
		// MarbleWhiteTrailParticle.colors[1]     = "1 1 0 1";
		// MarbleWhiteTrailParticle.colors[2]     = "1 1 1 0.0";
		// MarbleWhiteTrailParticle.sizes[0]      = "0.7";
		// MarbleWhiteTrailParticle.sizes[1]      = "0.4";
		// MarbleWhiteTrailParticle.sizes[2]      = "0.1";
		// MarbleWhiteTrailParticle.times[0]      = "0";
		// MarbleWhiteTrailParticle.times[1]      = "0.15";
		// MarbleWhiteTrailParticle.times[2]      = "1.0";

		// MarbleWhiteTrailEmitter.className = "ParticleEmitterData";
		// MarbleWhiteTrailEmitter.ejectionPeriodMS = "5";
		// MarbleWhiteTrailEmitter.periodVarianceMS = "0";
		// MarbleWhiteTrailEmitter.ejectionVelocity = "0.0";
		// MarbleWhiteTrailEmitter.velocityVariance = "0.25";
		// MarbleWhiteTrailEmitter.thetaMin         = "80.0";
		// MarbleWhiteTrailEmitter.thetaMax         = "90.0";
		// MarbleWhiteTrailEmitter.lifetimeMS = "0";
		// MarbleWhiteTrailEmitter.lifetimeVarianceMS = "0";
		// MarbleWhiteTrailEmitter.framesPerSec = "1";
		// MarbleWhiteTrailEmitter.particles = "MarbleWhiteTrailParticle";

	//PlatinumQuest
	} else {
		BounceParticle.reloadShape("platinum/data/particles/star");
		BounceParticle.dragCoefficient = "0";
		BounceParticle.windCoefficient = "0";
		BounceParticle.gravityCoefficient = "0";
		BounceParticle.inheritedVelFactor = "0";
		BounceParticle.constantAcceleration = "-2";
		BounceParticle.lifetimeMS = "480";
		BounceParticle.lifetimeVarianceMS = "96";
		BounceParticle.spinSpeed = "90";
		BounceParticle.spinRandomMin = "-90";
		BounceParticle.spinRandomMax = "90";
		BounceParticle.useInvAlpha = "1";
		BounceParticle.animateTexture = "0";
		BounceParticle.framesPerSec = "1";
		BounceParticle.colors[0] = "0.897638 0.000000 0.000000 1.000000";
		BounceParticle.colors[1] = "0.897638 0.897638 0.000000 1.000000";
		BounceParticle.colors[2] = "0.897638 0.897638 0.000000 0.000000";
		BounceParticle.colors[3] = "1.000000 1.000000 1.000000 1.000000";
		BounceParticle.sizes[0] = "0.250259";
		BounceParticle.sizes[1] = "0.250259";
		BounceParticle.sizes[2] = "0.250259";
		BounceParticle.sizes[3] = "1";
		BounceParticle.times[0] = "0";
		BounceParticle.times[1] = "0.74902";
		BounceParticle.times[2] = "1";
		BounceParticle.times[3] = "2";
		BounceParticle.dragCoeffiecient = "1";

		MarbleBounceEmitter.className = "ParticleEmitterData";
		MarbleBounceEmitter.ejectionPeriodMS = "40";
		MarbleBounceEmitter.periodVarianceMS = "1";
		MarbleBounceEmitter.ejectionVelocity = "3";
		MarbleBounceEmitter.velocityVariance = "0.25";
		MarbleBounceEmitter.ejectionOffset = "0";
		MarbleBounceEmitter.thetaMin = "80";
		MarbleBounceEmitter.thetaMax = "90";
		MarbleBounceEmitter.phiReferenceVel = "0";
		MarbleBounceEmitter.phiVariance = "360";
		MarbleBounceEmitter.overrideAdvance = "0";
		MarbleBounceEmitter.orientParticles = "0";
		MarbleBounceEmitter.orientOnVelocity = "1";
		MarbleBounceEmitter.particles = "BounceParticle";
		MarbleBounceEmitter.lifetimeMS = "224";
		MarbleBounceEmitter.lifetimeVarianceMS = "0";
		MarbleBounceEmitter.useEmitterSizes = "0";
		MarbleBounceEmitter.useEmitterColors = "0";
		MarbleBounceEmitter.oldVarianceMS = "0";
		MarbleBounceEmitter.periodModified = "1";
		MarbleBounceEmitter.oldPeriod = "80";
		MarbleBounceEmitter.newVarianceMS = "1";
		MarbleBounceEmitter.newPeriod = "40";

		%count = MarbleDataSet.getCount();
		for (%i = 0; %i < %count; %i ++) {
			MarbleDataSet.getObject(%i).setFieldValue("trailEmitter", "");
		}

		MarbleTrailParticle.reloadShape("platinum/data/particles/spark");
		MarbleTrailParticle.dragCoefficient = "0";
		MarbleTrailParticle.windCoefficient = "0";
		MarbleTrailParticle.gravityCoefficient = "-0.002442";
		MarbleTrailParticle.inheritedVelFactor = "0.246575";
		MarbleTrailParticle.constantAcceleration = "0";
		MarbleTrailParticle.lifetimeMS = "992";
		MarbleTrailParticle.lifetimeVarianceMS = "128";
		MarbleTrailParticle.spinSpeed = "10";
		MarbleTrailParticle.spinRandomMin = "0";
		MarbleTrailParticle.spinRandomMax = "0";
		MarbleTrailParticle.useInvAlpha = "1";
		MarbleTrailParticle.animateTexture = "0";
		MarbleTrailParticle.framesPerSec = "1";
		MarbleTrailParticle.colors[0] = "1.000000 1.000000 0.236220 0.228346";
		MarbleTrailParticle.colors[1] = "1.000000 1.000000 0.740157 1.000000";
		MarbleTrailParticle.colors[2] = "1.000000 1.000000 0.141732 0.000000";
		MarbleTrailParticle.colors[3] = "1.000000 1.000000 1.000000 1.000000";
		MarbleTrailParticle.sizes[0] = "0.189221";
		MarbleTrailParticle.sizes[1] = "0.189221";
		MarbleTrailParticle.sizes[2] = "0.289935";
		MarbleTrailParticle.sizes[3] = "1";
		MarbleTrailParticle.times[0] = "0";
		MarbleTrailParticle.times[1] = "0.2";
		MarbleTrailParticle.times[2] = "1";
		MarbleTrailParticle.times[3] = "1";

		MarbleTrailEmitter.className = "ParticleEmitterData";
		MarbleTrailEmitter.ejectionPeriodMS = "50";
		MarbleTrailEmitter.periodVarianceMS = "4";
		MarbleTrailEmitter.ejectionVelocity = "2";
		MarbleTrailEmitter.velocityVariance = "0.25";
		MarbleTrailEmitter.ejectionOffset = "0";
		MarbleTrailEmitter.thetaMin = "90";
		MarbleTrailEmitter.thetaMax = "100";
		MarbleTrailEmitter.phiReferenceVel = "0";
		MarbleTrailEmitter.phiVariance = "360";
		MarbleTrailEmitter.overrideAdvance = "0";
		MarbleTrailEmitter.orientParticles = "0";
		MarbleTrailEmitter.orientOnVelocity = "1";
		MarbleTrailEmitter.particles = "MarbleTrailParticle";
		MarbleTrailEmitter.lifetimeMS = "0";
		MarbleTrailEmitter.lifetimeVarianceMS = "0";
		MarbleTrailEmitter.useEmitterSizes = "0";
		MarbleTrailEmitter.useEmitterColors = "0";
		MarbleTrailEmitter.oldVarianceMS = "8";
		MarbleTrailEmitter.periodModified = "1";
		MarbleTrailEmitter.noHide = "0";
		MarbleTrailEmitter.oldPeriod = "100";
		MarbleTrailEmitter.newVarianceMS = "4";
		MarbleTrailEmitter.newPeriod = "50";

		MarbleWhiteTrailParticle.reloadShape("platinum/data/particles/spark");
		MarbleWhiteTrailParticle.dragCoefficient = "0";
		MarbleWhiteTrailParticle.windCoefficient = "0";
		MarbleWhiteTrailParticle.gravityCoefficient = "-0.002442";
		MarbleWhiteTrailParticle.inheritedVelFactor = "0.248532";
		MarbleWhiteTrailParticle.constantAcceleration = "0";
		MarbleWhiteTrailParticle.lifetimeMS = "992";
		MarbleWhiteTrailParticle.lifetimeVarianceMS = "128";
		MarbleWhiteTrailParticle.spinSpeed = "10";
		MarbleWhiteTrailParticle.spinRandomMin = "0";
		MarbleWhiteTrailParticle.spinRandomMax = "0";
		MarbleWhiteTrailParticle.useInvAlpha = "1";
		MarbleWhiteTrailParticle.animateTexture = "0";
		MarbleWhiteTrailParticle.framesPerSec = "1";
		MarbleWhiteTrailParticle.colors[0] = "1.000000 1.000000 1.000000 0.228346";
		MarbleWhiteTrailParticle.colors[1] = "1.000000 1.000000 1.000000 1.000000";
		MarbleWhiteTrailParticle.colors[2] = "1.000000 1.000000 1.000000 0.000000";
		MarbleWhiteTrailParticle.colors[3] = "1.000000 1.000000 1.000000 1.000000";
		MarbleWhiteTrailParticle.sizes[0] = "0.189221";
		MarbleWhiteTrailParticle.sizes[1] = "0.189221";
		MarbleWhiteTrailParticle.sizes[2] = "0.289935";
		MarbleWhiteTrailParticle.sizes[3] = "1";
		MarbleWhiteTrailParticle.times[0] = "0";
		MarbleWhiteTrailParticle.times[1] = "0.2";
		MarbleWhiteTrailParticle.times[2] = "1";
		MarbleWhiteTrailParticle.times[3] = "1";

		MarbleWhiteTrailEmitter.className = "ParticleEmitterData";
		MarbleWhiteTrailEmitter.ejectionPeriodMS = "25";
		MarbleWhiteTrailEmitter.periodVarianceMS = "4";
		MarbleWhiteTrailEmitter.ejectionVelocity = "2";
		MarbleWhiteTrailEmitter.velocityVariance = "0.25";
		MarbleWhiteTrailEmitter.ejectionOffset = "0";
		MarbleWhiteTrailEmitter.thetaMin = "90";
		MarbleWhiteTrailEmitter.thetaMax = "100";
		MarbleWhiteTrailEmitter.phiReferenceVel = "0";
		MarbleWhiteTrailEmitter.phiVariance = "360";
		MarbleWhiteTrailEmitter.overrideAdvance = "0";
		MarbleWhiteTrailEmitter.orientParticles = "0";
		MarbleWhiteTrailEmitter.orientOnVelocity = "1";
		MarbleWhiteTrailEmitter.particles = "MarbleWhiteTrailParticle";
		MarbleWhiteTrailEmitter.lifetimeMS = "0";
		MarbleWhiteTrailEmitter.lifetimeVarianceMS = "0";
		MarbleWhiteTrailEmitter.useEmitterSizes = "0";
		MarbleWhiteTrailEmitter.useEmitterColors = "0";
		MarbleWhiteTrailEmitter.oldVarianceMS = "8";
		MarbleWhiteTrailEmitter.periodModified = "1";
		MarbleWhiteTrailEmitter.noHide = "0";
		MarbleWhiteTrailEmitter.oldPeriod = "50";
		MarbleWhiteTrailEmitter.newVarianceMS = "4";
		MarbleWhiteTrailEmitter.newPeriod = "25";

	}
}

//-----------------------------------------------------------------------------
// Helper functions
//-----------------------------------------------------------------------------

function legacyApply() {
	if (!isObject(ServerConnection))
		return;
	applyLegacyItems();
	if ($CurrentGame $= "Hunt" || $CurrentGame $= "CustomHunt")
		applyOldMPSky();
}

function findSky(%group) {
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();
		if (%obj.getClassName() $= "Sky")
			return %obj;
		if (%class $= "SimGroup") {
				%sub = findSky(%obj);
				if (isObject(%sub))
					return %sub;
			}
	}
	return -1;
}

function findSun(%group) {
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();
		if (%obj.getClassName() $= "Sun")
			return %obj;
		if (%class $= "SimGroup") {
				%sub = findSky(%obj);
				if (isObject(%sub))
					return %sub;
			}
	}
	return -1;
}

function findAstrolabe(%group) {
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();
		if (%class $= "StaticShape") {
			if (%obj.getDatablock().getName() $= "astrolabe" || %obj.getFieldValue("isAstrolabe"))
				return %obj;
		}
		if (%class $= "SimGroup") {
				%sub = findAstrolabe(%obj);
				if (isObject(%sub))
					return %sub;
			}
	}
	return -1;
}

function findLegacySky(%group) {
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();
		if (%class $= "StaticShape") {
			%db = %obj.getDatablock().getName();
			if (!%obj.getFieldValue("isAstrolabe") && (%db $= "clear" || %db $= "dusk" || %db $= "wintry" || %db $= "vermontry"))
				return %obj;
		}
		if (%class $= "SimGroup") {
				%sub = findLegacySky(%obj);
				if (isObject(%sub))
					return %sub;
			}
	}
	return -1;
}