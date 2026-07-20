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
// Torque Game Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

/**
 * @param {PETimelineDlg} %gui
 */
function PETimelineDlg::onWake(%gui) {
	%gui.extent = %gui.getObject(0).extent;
}

/**
 * @param {PETimelineDlg} %gui
 */
function PETimelineDlg::updateColor(%gui, %fromdata) {
	PED.echo("updateColor: " @ !!%fromdata SPC "(fromdata)");
	if (%fromdata) {
		%color = getWords($PETimeline::Colors[$PETimeline::ActiveNode], 0, 2);
		PETColorR.setValue(getWord(%color, 0));
		PETColorG.setValue(getWord(%color, 1));
		PETColorB.setValue(getWord(%color, 2));
		%alpha = getWord($PETimeline::Colors[$PETimeline::ActiveNode], 3);
		PETAlpha2.setValue(%alpha);
		PETColorA.setValue(%alpha);
		%size = $PETimeline::Sizes[$PETimeline::ActiveNode];
		PETSize2.setValue(%size);
		PETSize.setValue(%size);
		PETNumNodes.setValue($PETimeline::NumNodes);
		for (%i = 0; %i < 4; %i++) {
			PED.echo("Setting invisible: Node" SPC %i+1);
			%obj = "PETNode" @ %i+1;
			%obj.setVisible(0);
		}
		for (%i = 0; %i < $PETimeline::NumNodes; %i++) {
			PED.echo("Setting visible: Node" SPC %i+1);
			%obj = "PETNode" @ %i+1;
			%obj.setVisible(1);
			%obj.position = $PETimeline::times[%i] * 341 + 2 SPC 45 * (%i / ($PETimeline::NumNodes-1)) + 8;
		}
	} else
		%color = PETColorR.getValue() SPC PETColorG.getValue() SPC PETColorB.getValue();

	for (%i = 0; %i < 3; %i++) {
		PETColor.getObject(%i).setText(0, "#", %color);
	}

	if ($PETimeline::ApplyInstantly && !%fromdata)
		%gui.exportData($PETimeline::DB);

	if (!%fromdata)
		$PETimeline::Colors[$PETimeline::ActiveNode] = %color SPC PETColorA.getValue();
}

/**
 * @param {PETimelineDlg} %gui
 */
function PETimelineDlg::updateTime(%gui, %slider, %manual) {
	PED.echo("updateTime: " @ !!%slider SPC !!%manual SPC "(slider, manual)");
	if (%manual) {
		PETNode1.position = 2 SPC 8;
		if ($PETimeline::NumNodes == 2) {
			PETNode2.position = 343 SPC 53;
		} else if ($PETimeline::NumNodes == 3) {
			PETNode2.position = $PETimeLine::Times[1] * 341 + 2 SPC 30;
			PETNode3.position = 343 SPC 53;
		} else if ($PETimeline::NumNodes == 4) {
			PETNode2.position = $PETimeLine::Times[1] * 341 + 2 SPC 23;
			PETNode3.position = $PETimeLine::Times[2] * 341 + 2 SPC 38;
			PETNode4.position = 343 SPC 53;
		}
		return;
	}

	if (%slider) {
		if ($PETimeline::ActiveNode == $PETimeline::NumNodes - 1)
			PETTime.setValue(1);
		else if ($PETimeline::ActiveNode == 0)
			PETTime.setValue(0);
		else
			PETTime.setValue($PETimeline::times[$PETimeline::ActiveNode]);
		return;
	}

	%num = $PETimeline::ActiveNode;
	%pos = PETTime.getValue();

	// If we're dragging past another node, swap their values
	if (%num < $PETimeline::NumNodes-1 && %num > 0) {
		if (%pos == 0) {
			%gui.SwapNodes(0, %num);

		} else if (%pos == 1) {
			%gui.SwapNodes(%num, $PETimeline::NumNodes - 1);
		}
		if ($PETimeline::NumNodes == 4) {
			if (%num == 1) {
				if (%pos > $PETimeline::times[2]) {
					%gui.SwapNodes(%num, 2);

				} else if (%pos == $PETimeline::times[2]) {
					if ($PETimeline::times[2] < 0.99)
						$PETimeline::times[2] += 0.01;
					else if ($PETimeline::times[1] > 0.01)
						$PETimeline::times[1] -= 0.01;
					%bumped++;
				}
			} else if (%num == 2) {
				if (%pos < $PETimeline::times[1]) {
					%gui.SwapNodes(%num, 1);

				} else if (%pos == $PETimeline::times[1]) {
					if ($PETimeline::times[2] < 0.99)
						$PETimeline::times[2] += 0.01;
					else if ($PETimeline::times[1] > 0.01)
						$PETimeline::times[1] -= 0.01;
					%bumped++;
				}
			}
		}
	}


	// Hardcode end nodes to 0 and 1
	else if (%num == 0 || %num == $PETimeline::NumNodes - 1) {
		if (%num == 0) {
			PETNode1.position = 2 SPC 8;
			PETTime.setValue(0);
		} else {
			%obj = "PETNode" @ $PETimeline::NumNodes;
			%obj.position = 343 SPC 53;
			PETTime.setValue(1);
		}
		return;
	}

	%obj = "PETNode" @ %num+1;
	if (%bumped)
		%pos = $PETimeline::times[%num];
	else
		%pos = PETTime.getValue();
	%obj.position = %pos * 341 + 2 SPC 45 * (%num / ($PETimeline::NumNodes-1)) + 8;
	$PETimeline::times[%num] = %pos;
}

/**
 * @param {PETimelineDlg} %gui
 */
function PETimelineDlg::open(%gui) {
	RootGui.pushDialog(%gui);
	%gui.importData();
	%gui.setActiveNode(1);
	$PETimeline::ApplyInstantly = 1;
	%gui.schedule(1000, "loop");
}

/**
 * @param {PETimelineDlg} %gui
 */
function PETimelineDlg::setActiveNode(%gui, %node) {
	PED.echo("setActiveNode: " @ %node);
	if (%node < 1 || %node > $PETimeline::NumNodes)
		return;
	$PETimeline::ActiveNode = %node-1;
	PETEditInfo.setText("Editing Node " @ %node @ "/" @ $PETimeline::NumNodes);

	%gui.updateColor(1);
	%gui.updateTime(1);
}

function PETimelineDlg::swapNodes(%gui, %swap1, %swap2) {
	PED.echo("Swapping nodes " @ %swap1+1 @ " and " @ %swap2+1 @ "...");

}

function PETimelineDlg::importData(%gui) {
	$PETimeline::NumNodes = 2;
	$PETimeline::MaxTime = 1;

	// Get datablock from the main gui

	%db = PEP_ParticleSelector.getText();
	$PETimeline::DB = %db;

	// Store up original stats to be re-applied with the cancel button.
	for (%i = 0; %i <= 3; %i++) {
		$PETimeline::OTimes[%i] = %db.times[%i];
		$PETimeline::OSizes[%i] = %db.sizes[%i];
		$PETimeline::OColors[%i] = %db.colors[%i];
	}

	// Store up stats with modifications to Times.
	// PETimeLineDlg actively edits these strings.
	for (%i = 0; %i <= 3; %i++) {
		if (%i >= 2 && %db.times[%i] > %db.times[%i-1])
			$PETimeline::NumNodes++;

		$PETimeline::Times[%i] = %db.times[%i];
		$PETimeline::Sizes[%i] = %db.sizes[%i];
		$PETimeline::Colors[%i] = %db.colors[%i];

		if (%db.times[%i] > $PETimeline::MaxTime)
			$PETimeline::MaxTime = %db.times[%i];
	}
	if ($PETimeline::NumNodes >= 3)
		$PETimeline::Times[1] = $PETimeline::Times[1] / $PETimeline::MaxTime;
	if ($PETimeline::NumNodes >= 4)
		$PETimeline::Times[2] = $PETimeline::Times[2] / $PETimeline::MaxTime;

	$PETimeline::Times[0] = 0;
	$PETimeline::Times[$PETimeline::NumNodes-1] = 1;


	for (%i = 0; %i < %numnodes; %i++) {
		if (%i == 0)
			return;
	}
}

function PETimelineDlg::exportData(%gui) {
	%db = $PETimeline::DB;
	for (%i = 0; %i <= 3; %i++) {
		%db.Times[%i] = $PETimeline::times[%i];
		%db.Sizes[%i] = $PETimeline::Sizes[%i];
		%db.Colors[%i] = $PETimeline::Colors[%i];
	}
	ParticleEditor.PETimeLineDlgCallback(%db);
}

function PETimelineDlg::restoreData(%gui) {
	%db = $PETimeline::DB;
	for (%i = 0; %i <= 3; %i++) {
		%db.Times[%i] = $PETimeline::OTimes[%i];
		%db.Sizes[%i] = $PETimeline::OSizes[%i];
		%db.Colors[%i] = $PETimeline::OColors[%i];
	}
	ParticleEditor.PETimeLineDlgCallback(%db);
}

/**
 * @param {PETimelineDlg} %gui
 */
function PETimelineDlg::updateNodes(%gui) {
	%num = PETNumNodes.getValue();
	$PETimeline::numNodes = %num;
	for (%i = 0; %i < 4; %i++) {
		PED.echo("Setting invisible: Node" SPC %i+1);
		%obj = "PETNode" @ %i+1;
		%obj.setVisible(0);
	}
	PETNode1.setVisible(1);
	PETNode2.setVisible(1);
	if (%num == 2) {
		$PETimeline::times[1] = 1;
	}
	if (%num == 3) {
		$PETimeline::times[1] = 0.5;
		$PETimeline::times[2] = 1;
		PED.echo("Setting invisible: Node" SPC 3);
		PETNode3.setVisible(1);
	} else if (%num == 4) {
		$PETimeline::times[1] *= $PETimeline::times[1] / 2;
		$PETimeline::times[2] = 0.5;
		$PETimeline::times[3] = 1;
		PETNode3.setVisible(1);
		PETNode4.setVisible(1);
		PED.echo("Setting invisible: Node 3 and 4");
	}
	%gui.updateTime(0, 1);

	if ($PETimeline::ActiveNode > %num-1)
		%gui.setActiveNode($PETimeline::numNodes);
	else
		%gui.setActiveNode($PETimeline::ActiveNode+1);
}

/**
 * @param {PETimelineDlg} %gui
 */
function PETimelineDlg::updateAlpha(%gui, %flag) {
	if (%flag)
		PETColorA.setValue(PETAlpha2.getValue());
	else
		PETAlpha2.setValue(PETColorA.getValue());

	if ($PETimeline::ApplyInstantly)
		%gui.exportData($PETimeline::DB);

	$PETimeline::Colors[$PETimeline::ActiveNode] = PETColorR.getValue() SPC PETColorG.getValue() SPC PETColorB.getValue() SPC PETColorA.getValue();
}

/**
 * @param {PETimelineDlg} %gui
 */
function PETimelineDlg::updateSize(%gui, %flag) {
	if (%flag)
		PETSize.setValue(PETSize2.getValue());
	else
		PETSize2.setValue(PETSize.getValue());

	if ($PETimeline::ApplyInstantly)
		%gui.exportData($PETimeline::DB);

	$PETimeline::Sizes[$PETimeline::ActiveNode] = PETSize2.getValue();
}


// dirty hack because the GuiTextEditSliderCtrl doesn't send its command
/**
 * @param {PETimelineDlg} %gui
 */
function PETimelineDlg::loop(%gui, %loop) {
	if (%gui.getGroup() != Canvas.getID())
		return;

	if ($PETimeline::NumNodes != PETNumNodes.getValue())
		%gui.updateNodes();

	if (PETColorA.LastValue != PETAlpha2.getValue()) {
		if (getSubStr(PETAlpha2.getValue(), 0, 4) != getSubStr(PETColorA.getValue(), 0, 4)) {
			PETColorA.setValue(PETAlpha2.getValue());
			PETColorA.LastValue = PETAlpha2.getValue();
			%change++;
		}
	}

	if (PETSize.LastValue != PETSize2.getValue()) {
		if (getSubStr(PETSize2.getValue(), 0, 4) != getSubStr(PETSize.getValue(), 0, 4)) {
			PETSize.setValue(PETSize2.getValue());
			PETSize.LastValue = PETSize2.getValue();
			%change++;
		}
	}

	//if (%change > 0 && $PETimeline::ApplyInstantly)
	//%gui.exportData($PETimeline::DB);
	if (%loop++ == 1 && $PETimeline::ApplyInstantly)
		%gui.exportData($PETimeline::DB);

	%gui.schedule(100, "loop", %loop % 5);
}