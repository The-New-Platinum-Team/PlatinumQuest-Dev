//-----------------------------------------------------------------------------
// Mission Queue
//
// Copyright (c) 2021 The Platinum Team
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
// MissionQueue Interface
//-----------------------------------------------------------------------------

/// Get the name of the queue
/// @return Queue display name
function MissionQueue::getQueueName(%this) {
	error("MissionQueue::getQueueName unimplemented");
	return "Unnamed";
}

/// Get the total number of missions in the queue
/// @return Total number of missions
function MissionQueue::getMissionCount(%this) {
	error("MissionQueue::getMissionCount unimplemented");
	return 0;
}

/// Get a MissionInfo ScriptObject for the mission in the queue at the given index
/// @return Mission info
function MissionQueue::getMissionInfo(%this, %index) {
	error("MissionQueue::getMissionInfo unimplemented");
	return 0;
}

/// Determine if upcoming missions are hidden to the player
/// @return True if missions should be hidden
function MissionQueue::isUpcomingHidden(%this) {
	return false;
}

/// Callback for when you start playing the Queue
function MissionQueue::onPlay(%this) {
	// You probably want to put this at the start of your override:
	// MissionQueue::onPlay(%this);

	%this.totalTimeScore = 0;
	%this.totalScoreScore = 0;
	%this.totalBonus = 0;
	%this.totalElapsed = 0;
	%this.totalRealTime = 0;
}

/// Callback for when you finish playing the last level in the Queue
/// @param completed If the player completed every level (ie did not exit early)
function MissionQueue::onEnd(%this, %completed) {
	// You probably want to put this at the start of your override:
	// MissionQueue::onEnd(%this, %completed);

	%this.schedule(100, delete);
}

/// Callback for when you start playing a level in the Queue
/// @param index Index of level to start playing
function MissionQueue::onPlayMission(%this, %index) {
	// You probably want to put this at the start of your override:
	// MissionQueue::onPlayMission(%this, %index);

	%this.missionStart[%index] = getRealTime();
}

/// Callback for when you finish playing a level in the Queue
/// @param index Index of level finished
/// @param completed If the player completed the level (ie did not exit)
function MissionQueue::onEndMission(%this, %index, %completed) {
	// You probably want to put this at the start of your override:
	// MissionQueue::onEndMission(%this, %index, %completed);

	%this.missionCompleted[%index] = %completed;

	%this.missionEnd[%index] = getRealTime();
	%this.missionRealTime[%index] = sub64_int(%this.missionEnd[%index], %this.missionStart[%index]);
	%this.totalRealTime = add64_int(%this.totalRealTime, %this.missionRealTime[%index]);

	if (%completed) {
		%this.missionScore[%index] = $Game::FinalScore;
		%this.missionBonus[%index] = $Game::BonusTime;
		%this.missionElapsed[%index] = $Game::ElapsedTime;

		%this.missionScore[%index] = $Game::FinalScore;
		%this.missionBonus[%index] = $Game::BonusTime;
		%this.missionElapsed[%index] = $Game::ElapsedTime;

		%type = getField($Game::FinalScore, 0);
		%score = getField($Game::FinalScore, 1);

		if (%type $= $ScoreType::Time) {
			%this.totalTimeScore = add64_int(%this.totalTimeScore, %score);
			%this.totalElapsed = add64_int(%this.totalElapsed, %this.missionElapsed[%index]);
		} else {
			%this.totalScoreScore = add64_int(%this.totalScoreScore, %score);
		}
		%this.totalBonus = add64_int(%this.totalBonus, %this.missionBonus[%index]);
	}
	%this.missionTotalElapsed[%index] = %this.totalElapsed;
	%this.missionTotalTimeScore[%index] = %this.totalTimeScore;
	%this.missionTotalScoreScore[%index] = %this.totalScoreScore;
}

//-----------------------------------------------------------------------------

function MissionQueue::getMissionFile(%this, %index) {
	return %this.getMissionInfo(%index).file;
}

function MissionQueue::export(%this, %path) {
	// Load all levels
	%j = new ScriptObject(MissionQueueExport) {
		class = "JSONObject";
	};
	%j.name = %this.getQueueName();
	%j.upcomingHidden = %this.isUpcomingHidden();
	%j.missionCount = %this.getMissionCount();

	%j.totalTimeScore = %this.totalTimeScore;
	%j.totalScoreScore = %this.totalScoreScore;
	%j.totalBonus = %this.totalBonus;
	%j.totalElapsed = %this.totalElapsed;
	%j.totalRealTime = %this.totalRealTime;

	%j.missionFile = Array(MissionQueueExportFiles);
	%j.__obj["missionFile"] = true;
	%j.missionCompleted = Array(MissionQueueExportMissionCompleted);
	%j.__obj["missionCompleted"] = true;
	%j.missionStart = Array(MissionQueueExportMissionStart);
	%j.__obj["missionStart"] = true;
	%j.missionScore = Array(MissionQueueExportMissionScore);
	%j.__obj["missionScore"] = true;
	%j.missionBonus = Array(MissionQueueExportMissionBonus);
	%j.__obj["missionBonus"] = true;
	%j.missionElapsed = Array(MissionQueueExportMissionElapsed);
	%j.__obj["missionElapsed"] = true;
	%j.missionEnd = Array(MissionQueueExportMissionEnd);
	%j.__obj["missionEnd"] = true;
	%j.missionRealTime = Array(MissionQueueExportMissionRealTime);
	%j.__obj["missionRealTime"] = true;
	%j.missionTotalTimeScore = Array(MissionQueueExportMissionTotalTimeScore);
	%j.__obj["missionTotalTimeScore"] = true;
	%j.missionTotalElapsed = Array(MissionQueueExportMissionTotalElapsed);
	%j.__obj["missionTotalElapsed"] = true;
	%j.missionTotalScoreScore = Array(MissionQueueExportMissionTotalScoreScore);
	%j.__obj["missionTotalScoreScore"] = true;

	for (%i = 0; %i < %j.missionCount; %i ++) {
		%j.missionFile.addEntry(%this.getMissionFile(%i));
		%j.missionCompleted.addEntry(%this.missionCompleted[%i]);
		%j.missionStart.addEntry(%this.missionStart[%i]);
		%j.missionScore.addEntry(%this.missionScore[%i]);
		%j.missionBonus.addEntry(%this.missionBonus[%i]);
		%j.missionElapsed.addEntry(%this.missionElapsed[%i]);
		%j.missionEnd.addEntry(%this.missionEnd[%i]);
		%j.missionRealTime.addEntry(%this.missionRealTime[%i]);
		%j.missionTotalTimeScore.addEntry(%this.missionTotalTimeScore[%i]);
		%j.missionTotalElapsed.addEntry(%this.missionTotalElapsed[%i]);
		%j.missionTotalScoreScore.addEntry(%this.missionTotalScoreScore[%i]);
	}

	fwrite(%path, jsonPrint(%j));
	%j.missionFile.delete();
	%j.missionCompleted.delete();
	%j.missionStart.delete();
	%j.missionScore.delete();
	%j.missionBonus.delete();
	%j.missionElapsed.delete();
	%j.missionEnd.delete();
	%j.missionRealTime.delete();
	%j.missionTotalTimeScore.delete();
	%j.missionTotalElapsed.delete();
	%j.missionTotalScoreScore.delete();
	%j.delete();
}

//-----------------------------------------------------------------------------

function MissionQueue::import(%path) {
	if (!isFile(%path))
		return;
	%q = new ScriptObject(ImportedQueue) {
		class = "ImportedMissionQueue";
		superClass = "MissionQueue";
	};
	%q.data = jsonParse(fread(%path));
	%q.totalTimeScore = %q.data.totalTimeScore;
	%q.totalScoreScore = %q.data.totalScoreScore;
	%q.totalBonus = %q.data.totalBonus;
	%q.totalElapsed = %q.data.totalElapsed;
	%q.totalRealTime = %q.data.totalRealTime;

	for (%i = 0; %i < %q.missionCount; %i ++) {
		%q.missionCompleted[%i] = %q.data.missionCompleted.getEntry(%i);
		%q.missionStart[%i] = %q.data.missionStart.getEntry(%i);
		%q.missionScore[%i] = %q.data.missionScore.getEntry(%i);
		%q.missionBonus[%i] = %q.data.missionBonus.getEntry(%i);
		%q.missionElapsed[%i] = %q.data.missionElapsed.getEntry(%i);
		%q.missionEnd[%i] = %q.data.missionEnd.getEntry(%i);
		%q.missionRealTime[%i] = %q.data.missionRealTime.getEntry(%i);
		%q.missionTotalTimeScore[%i] = %q.data.missionTotalTimeScore.getEntry(%i);
		%q.missionTotalElapsed[%i] = %q.data.missionTotalElapsed.getEntry(%i);
		%q.missionTotalScoreScore[%i] = %q.data.missionTotalScoreScore.getEntry(%i);
	}

	return %q;
}

function ImportedMissionQueue::getQueueName(%this) {
	return %this.data.name;
}

function ImportedMissionQueue::getMissionCount(%this) {
	return %this.data.missionCount;
}

function ImportedMissionQueue::getMissionInfo(%this, %index) {
	return getMissionInfo(%this.data.missionFile.getEntry(%index));
}

function ImportedMissionQueue::isUpcomingHidden(%this) {
	return %this.data.upcomingHidden;
}

//-----------------------------------------------------------------------------

function DifficultyMissionQueue::create(%ml, %game, %difficulty) {
	RootGroup.add(%queue = new ScriptObject(DifficultyQueue) {
		class = "DifficultyMissionQueue";
		superClass = "MissionQueue";
		ml = %ml;
		game = %game;
		difficulty = %difficulty;
	});
	return %queue;
}

function DifficultyMissionQueue::getQueueName(%this) {
	return %this.ml.getGameName(%this.game) @ " - " @ %this.ml.getDifficultyName(%this.game, %this.difficulty);
}

function DifficultyMissionQueue::getMissionCount(%this) {
	return %this.ml.getMissionList(%this.game, %this.difficulty).getSize();
}

function DifficultyMissionQueue::getMissionInfo(%this, %index) {
	return %this.ml.getMissionList(%this.game, %this.difficulty).getEntry(%index);
}

function DifficultyMissionQueue::isUpcomingHidden(%this) {
	return false;
}
