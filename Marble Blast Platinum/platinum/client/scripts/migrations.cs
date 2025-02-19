//-----------------------------------------------------------------------------
// Copyright (c) 2025 The Platinum Team
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

// 2.11 - Migrate scores from old hunt mission paths to new ones

if (!$Pref::Migrated2_11) {
	%oldMissions = "platinum/data/multiplayer/hunt/intermediate/RampsRevamped_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/intermediate/Sweep_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/intermediate/TerraceTundra_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/intermediate/Tilo_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/custom/nuked/KingOfTheRing_Hunt.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/archipelago.mis" TAB "platinum/data/multiplayer/hunt/custon/nuked/BlenderChop_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/intermediate/Exoplanet_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/custom/nuked/FaultLine_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/custom/existing/GoodToBeKing.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/Grassy.mis" TAB "platinum/data/multiplayer/hunt/beginner/GravityTower_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/custom/existing/Gym_Hunt.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/Heart_of_the_Typhoon.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/HikarusVShape.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/Landscape.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/Layered.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/Quartile.mis" TAB "platinum/data/multiplayer/hunt/custom/nuked/Ring_Hunt.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/SpherePlates.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/timbertown.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/TripleDeckers.mis" TAB "platinum/data/multiplayer/hunt/advanced/WonkyWaters_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/intermediate/BasicAgilityCourse_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/custom/existing/Daedalus_Hunt.mis" TAB "platinum/data/multiplayer/hunt/custom/existing/Meltdown.mis"   TAB "platinum/data/multiplayer/hunt/custom/nuked/RampMatrix_Hunt.mis" TAB "platinum/data/multiplayer/hunt/custom/nuked/RampsReloaded_Hunt.mis" TAB "platinum/data/multiplayer/hunt/advanced/ParkourPeaks_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/advanced/PlatinumConstructionCo_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/custom/existing/prophetic.mis" TAB "platinum/data/multiplayer/hunt/advanced/Spires_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/beginner/Apex_Hunt.mcs"     TAB "platinum/data/multiplayer/hunt/custom/existing/PointsOfTheRadar.mis"   TAB "platinum/data/multiplayer/hunt/advanced/SkateParkSquare_Hunt.mcs";
	%newMissions = "platinum/data/multiplayer/hunt/advanced/RampsRevamped_Hunt.mcs"     TAB "platinum/data/multiplayer/hunt/advanced/Sweep_Hunt.mcs"     TAB "platinum/data/multiplayer/hunt/advanced/TerraceTundra_Hunt.mcs"     TAB "platinum/data/multiplayer/hunt/advanced/Tilo_Hunt.mcs"     TAB "platinum/data/multiplayer/hunt/beginner/KingOfTheRing_Hunt.mis"     TAB "platinum/data/multiplayer/hunt/bonus/Archipelago_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/BlenderChop_Hunt.mcs"        TAB "platinum/data/multiplayer/hunt/bonus/Exoplanet_Hunt.mcs"        TAB "platinum/data/multiplayer/hunt/bonus/FaultLine_Hunt.mcs"        TAB "platinum/data/multiplayer/hunt/bonus/GoodToBeKing_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/Grassy_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/GravityTower_Hunt.mcs"    TAB "platinum/data/multiplayer/hunt/bonus/Gym_Hunt.mis"           TAB "platinum/data/multiplayer/hunt/bonus/HeartOfTheTyphoon_Hunt.mis"         TAB "platinum/data/multiplayer/hunt/bonus/HikarusVShape_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/Landscape_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/Layered_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/Quartile_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/Ring_Hunt.mis"        TAB "platinum/data/multiplayer/hunt/bonus/SpherePlates_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/Timbertown_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/TripleDeckers_Hunt.mis"      TAB "platinum/data/multiplayer/hunt/bonus/WonkyWaters_Hunt.mcs"    TAB "platinum/data/multiplayer/hunt/directorscut/BasicAgilityCourse_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/directorscut/Daedalus_Hunt.mis"    TAB "platinum/data/multiplayer/hunt/directorscut/Meltdown_Hunt.mis" TAB "platinum/data/multiplayer/hunt/directorscut/RampMatrix_Hunt.mis" TAB "platinum/data/multiplayer/hunt/directorscut/RampsReloaded_Hunt.mis" TAB "platinum/data/multiplayer/hunt/expert/ParkourPeaks_Hunt.mcs"   TAB "platinum/data/multiplayer/hunt/expert/PlatinumConstructionCo_Hunt.mcs"   TAB "platinum/data/multiplayer/hunt/expert/Prophetic_Hunt.mis"     TAB "platinum/data/multiplayer/hunt/expert/Spires_Hunt.mcs"   TAB "platinum/data/multiplayer/hunt/intermediate/Apex_Hunt.mcs" TAB "platinum/data/multiplayer/hunt/intermediate/PointsOfTheRadar_Hunt.mis" TAB "platinum/data/multiplayer/hunt/intermediate/SkateParkSquare_Hunt.mcs";

	%count = getFieldCount(%oldMissions);

	for (%i = 0; %i < %count; %i++) {
		%oldMission = getField(%oldMissions, %i);
		if ($pref::highscores[%oldMission, 0]) {
			%newMission = getField(%newMissions, %i);
			echo("Migrating high scores from" SPC %oldMission SPC "to" SPC %newMission);
			for (%j = 0; %j < 5; %j++) {
				$pref::highscores[%newMission, %j] = $pref::highscores[%oldMission, %j];
			}
		}
	}

	$Pref::Migrated2_11 = true;
}