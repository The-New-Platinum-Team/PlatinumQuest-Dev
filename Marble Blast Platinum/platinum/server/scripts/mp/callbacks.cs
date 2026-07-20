//-----------------------------------------------------------------------------
// ServerCallbacks.cs
//
// For mis mod support that doesn't make me go crazy
// Re-executed on server creation / level load
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
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

function serverCbOnMissionLoaded() {

}

function serverCbOnMissionEnded() {

}

function serverCbOnMissionReset() {

}

function serverCbOnEndGameSetup() {

}

function serverCbOnOutOfBounds(%client) {

}

function serverCbOnRespawn(%client) {

}

function serverCbOnFrameAdvance(%timeDelta) {

}

function serverSendCallback(%cb, %arg) {
	for (%i = 0; %i < ClientGroup.getCount(); %i ++) {
		ClientGroup.getObject(%i).sendCallback(%cb, %arg);
	}
}

/**
 * @param {GameConnection} %this
 */
function GameConnection::sendCallback(%this, %cb, %arg) {
	commandToClient(%this, addTaggedString("cb" @ %cb), %arg);
}