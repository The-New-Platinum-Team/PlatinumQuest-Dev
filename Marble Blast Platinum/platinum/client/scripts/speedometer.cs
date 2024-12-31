//-----------------------------------------------------------------------------
// PlayGui Speedometer Control
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

function PlayGui::updateSpeedometer(%this) {
	//We need a marble to calculate velocity!
	if (!MPMyMarbleExists())
		return;
	//Duh
	if (!PGSpeedometer.isVisible())
		return;

	//How fast is the marble
	%velocity = VectorLen(MPGetMyMarble().getVelocity());

	//Do we need to show the hundred's place?
	if (%velocity < 100) {
		PGSPDDigitOne.setPosition("39 0");
		PGSPDDigitTen.setPosition("13 0");
		PGSPDDigitHun.setVisible(false);
	} else {
		PGSPDDigitOne.setPosition("52 0");
		PGSPDDigitTen.setPosition("26 0");
		PGSPDDigitHun.setVisible(true);
	}
	PGSPDDigitTen.setVisible(%velocity >= 10);

	//Extract digits from the velocity
	%one = mFloor(%velocity) % 10;
	%ten = mFloor(%velocity / 10) % 10;
	%hun = mFloor(%velocity / 100) % 10;

	//Are we qualified?
	if (MissionInfo.MinimumSpeed && %velocity < MissionInfo.MinimumSpeed) {
		%color = $TimeColor["danger"];
	} else if (MissionInfo.SpeedToQualify && %velocity > MissionInfo.SpeedToQualify) {
		%color = $TimeColor["stopped"];
	} else {
		%color = $TimeColor["normal"];
	}

	//Set number elements
	PGSPDDigitOne.setNumberColor(%one, %color);
	PGSPDDigitTen.setNumberColor(%ten, %color);
	PGSPDDigitHun.setNumberColor(%hun, %color);

	//Align the analog speedometer
	%base = getWord(PGSPDBackground.position, 0);
	%targetY = -759 + (8 * %velocity);

	//Warp speed!
	if (%targetY > 2138) {
		%targetY = 2138;

		//"They've Gone to Plaid" achievement
		activateAchievement($Achievement::Category::General, 13);
	}

	//Where is the base?
	%targetPos = %base SPC %targetY;

	//Update the speedometer tick positions
	PGSPDBackground.position = %targetPos;
	PGSPDBackground2.position = %base SPC getWord(%targetPos, 1) - 1008;
	PGSPDBackground3.position = %base SPC getWord(%targetPos, 1) - 2016;

	ClientMode::callback("updateSpeedometer", "", %velocity);
}
