//-----------------------------------------------------------------------------
// Shared Client/Server Scripts
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

package Shared {
	function displayHelp() {
		Parent::displayHelp();
	}
	function parseArgs() {
		Parent::parseArgs();
	}
	function onStart() {
		Parent::onStart();
		echo("\n--------- Initializing MOD: Shared ---------");
		initShared();
	}
	function onExit() {
		Parent::onExit();
	}

};

// Shared package
activatePackage(Shared);

function initShared() {
	exec("./extended.cs");
	exec("./tcp.cs"); //for dec2hex for support
	exec("./mp/support.cs"); //for rot13
	exec("./support.cs");
	exec("./servers.cs");
	exec("./mp/defaults.cs");
	exec("./mp/opCodes.cs");
	exec("./mission.cs");
	exec("./stats.cs");

	exec("./miscfunctions.cs");
	exec("./vectors.cs");
	exec("./boxes.cs");
	exec("./defaultProperties.cs");
	exec("./interpolation.cs");
	exec("./missionList.cs");
	exec("./tree.cs");
	exec("./marbleland.cs");
}