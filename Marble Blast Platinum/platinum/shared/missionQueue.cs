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

/// Callback for when you start playing the Queue
function MissionQueue::onPlay(%this) {

}

/// Callback for when you finish playing the last level in the Queue
/// @param completed If the player completed every level (ie did not exit early)
function MissionQueue::onEnd(%this, %completed) {

}

/// Callback for when you start playing a level in the Queue
/// @param index Index of level to start playing
function MissionQueue::onPlayMission(%this, %index) {

}

/// Callback for when you finish playing a level in the Queue
/// @param index Index of level finished
/// @param completed If the player completed the level (ie did not exit)
function MissionQueue::onEndMission(%this, %index, %completed) {

}

//-----------------------------------------------------------------------------

function MissionQueue::getMissionFile(%this, %index) {
    return %this.getMissionInfo(%index).file;
}
