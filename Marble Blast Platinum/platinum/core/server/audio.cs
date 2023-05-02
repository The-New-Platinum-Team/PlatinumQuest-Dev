//-----------------------------------------------------------------------------
// Portions Copyright (c) 2021 The Platinum Team
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
// Torque Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------

function ServerPlay2D(%profile) {
	// Play the given sound profile on every client.
	// The sounds will be transmitted as an event, not attached to any object.
	for (%idx = 0; %idx < ClientGroup.getCount(); %idx++) {
		%client = ClientGroup.getObject(%idx);
		if (!%client.loading) {
			//echo("Sending sound to" SPC %client.getUsername());
			ClientGroup.getObject(%idx).play2D(%profile);
		}
	}
}

function ServerPlay3D(%profile,%transform) {
	// Play the given sound profile at the given position on every client
	// The sound will be transmitted as an event, not attached to any object.
	for (%idx = 0; %idx < ClientGroup.getCount(); %idx++) {
		%client = ClientGroup.getObject(%idx);
		if (!%client.loading) {
			//echo("Sending sound to" SPC %client.getUsername());
			%client.play3D(%profile,%transform);
		}
	}
}

//Simple function for playing sounds for other clients using commandToAll() or similar - Yoshi
function clientCmdAlxPlay(%sound){
	AlxPlay(%sound);
}

// No more console errors
function FakeGameConnection::play2D(%this) {}
function FakeGameConnection::play3D(%this) {}
