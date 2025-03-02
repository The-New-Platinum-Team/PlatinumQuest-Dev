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

//-------------------------------------------//
// ORIGINAL BY GARAGEGAMES
// MODIFIED BY SEIZURE22 FOR PQ
//-------------------------------------------//

// The Particle Editor!
// Edits both emitters and their particles in realtime in game.
//
// Open the particle editor to spawn a test emitter in front of the player.
// Edit the sliders, check boxes, and text fields and see the results in
// realtime.  Switch between emitters and particles with the buttons in the
// top left corner.  When in particle mode, the only particles available will
// be those assigned to the current emitter to avoid confusion.  In the top
// right corner, there is a button marked "Drop Emitter", which will spawn the
// test emitter in front of the player again, and a button marked "Restart
// Emitter", which will play the particle animation again.

//TO/*notmine*/DO: animTexName on Particles (max 50)

//TODO:
// - reload properly when choosing a new texture
//
// - hax-in valid "invalid" values
//  - phireference vel can go negative
//  - thetamin can go negative
//  - ejectionVelocity can go negative (use with velocity variance and constantacceleration)
//  - ^this is important for aiming emitters

datablock ParticleData(PE_TEMPLATEPARTICLE : BounceParticle) {
	useInvAlpha =  true;
};

datablock ParticleEmitterData(PE_TEMPLATEEMITTER) {
	ejectionPeriodMS = 80;
	periodVarianceMS = 0;
	ejectionVelocity = 3.0;
	velocityVariance = 0.25;
	thetaMin         = 80.0;
	thetaMax         = 90.0;
	lifetimeMS       = 0;
	particles = "PE_TEMPLATEPARTICLE";
};

function toggleParticleEditor(%val) {
	if (!%val)
		return;

	if ($ParticleEditor::isOpen) {
		RootGui.popDialog(ParticleEditor);
		$ParticleEditor::isOpen = false;
		return;
	}

	if (!isObject(ParticleEditor)) {
		exec("./ParticleEditor.gui");
		ParticleEditor.initEditor();
	}
	ParticleEditor.startup();

	RootGui.pushDialog(ParticleEditor);
	$ParticleEditor::isOpen = true;
}


function ParticleEditor::startup(%this) {
	$ParticleEditor::activeEditor.updateControls();
	if (!isObject($ParticleEditor::emitterNode))
		%this.resetEmitterNode();
}

function ParticleEditor::initEditor(%this) {
	%this.refreshDatablocks(1);
	PEE_EmitterSelector.setSelected(0);
	%this.openEmitterPane();
}

function ParticleEditor::refreshDatablocks(%this, %init) {
	if (%init) {
		echo("Initializing ParticleEmitterData and ParticleData DataBlocks...");
		PED.echo("Initializing ParticleEmitterData and ParticleData DataBlocks...");
	} else {
		PED.echo("Refreshing datablocks...");
	}

	%count = rootgroup.getCount();
	%h = 0;

	// Find some datablocks that might be sitting in root
	for (%i = 0; %i < %count; %i++) {
		%obj = rootgroup.getObject(%i);
		%class = %obj.getClassName();
		if (%class $= "ParticleData" || %class $= "ParticleEmitterData") {
			//%toData[%h] = %obj;
			%h++;
		}
	}
	//for (%i = 0; %i < %h; %i++)
	//DatablockGroup.add(%toData[%i]);

	if (%h > 0) {
		PED.error(%h @ " datablocks are sitting in RootGroup..");
		PED.error("Make sure they use the datablock keyword!");
	}

	PED.echo("Refreshing saved particle data...");

	// Load every CS in the particles folder
	for (%file = findFirstFile($currentMod @ "/data/particles/*.cs");
	        %file !$= "";
	        %file = findNextFile($currentMod @ "/data/particles/*.cs")) {
		if (!strstrbool(%file, "temp.cs"))
			exec(%file);
	}

	%count = DatablockGroup.getCount();
	%emitterCount = 0;
	%particleCount = 0;

	PEE_EmitterSelector.clear();
	PEE_EmitterParticleSelector1.clear();
	PEE_EmitterParticleSelector2.clear();
	PEE_EmitterParticleSelector3.clear();
	PEE_EmitterParticleSelector4.clear();
	PEP_ParticleSelector.clear();

	for (%i = 0; %i < %count; %i++) {
		%obj = DatablockGroup.getObject(%i);
		if (%obj.getClassName() $= "ParticleEmitterData") {
			PEE_EmitterSelector.add(%obj.getName(), %emitterCount);
			%emitterCount++;
		} else if (%obj.getClassName() $= "ParticleData") {
			PEP_ParticleSelector.add(%obj.getName(), %particleCount);
			PEE_EmitterParticleSelector1.add(%obj.getName(), %particleCount);
			PEE_EmitterParticleSelector2.add(%obj.getName(), %particleCount);
			PEE_EmitterParticleSelector3.add(%obj.getName(), %particleCount);
			PEE_EmitterParticleSelector4.add(%obj.getName(), %particleCount);
			%particleCount++;
		}
	}
	PEE_EmitterParticleSelector2.add("", %particleCount); //insert a blank space
	PEE_EmitterParticleSelector3.add("", %particleCount); //insert a blank space
	PEE_EmitterParticleSelector4.add("", %particleCount); //insert a blank space

	if (%init) {
		echo("Found" SPC %emitterCount SPC "emitters and" SPC %particleCount SPC "particles.");
		PED.success("Found" SPC %emitterCount SPC "emitters and" SPC %particleCount SPC "particles.");
	}
	PEP_ParticleSelector.sort();
	PEE_EmitterSelector.sort();
	PEE_EmitterParticleSelector1.sort();
	PEE_EmitterParticleSelector2.sort();
	PEE_EmitterParticleSelector3.sort();
	PEE_EmitterParticleSelector4.sort();
}


function PE_EmitterEditor::updateControls(%this) {
	%id = PEE_EmitterSelector.getSelected();
	if (%id == 0)
		return;
	%data = PEE_EmitterSelector.getTextById(%id);

	PEE_ejectionPeriodMS.setValue(%data.ejectionPeriodMS);
	PEE_periodVarianceMS.setValue(%data.ejectionPeriodMS);
	PEE_ejectionVelocity.setValue(%data.ejectionVelocity);
	PEE_velocityVariance.setValue(%data.velocityVariance);
	PEE_ejectionOffset.setValue(%data.ejectionOffset);
	PEE_lifetimeMS.setValue(%data.lifetimeMS);
	PEE_lifetimeVarianceMS.setValue(%data.lifetimeVarianceMS);
	PEE_thetaMin.setValue(%data.thetaMin);
	PEE_thetaMax.setValue(%data.thetaMax);
	PEE_phiReferenceVel.setValue(%data.phiReferenceVel);
	PEE_phiVariance.setValue(%data.phiVariance);
	PEE_overrideAdvance.setValue(%data.overrideAdvance);
	PEE_orientParticles.setValue(%data.orientParticles);
	PEE_orientOnVelocity.setValue(%data.orientOnVelocity);
	PEE_useEmitterSizes.setValue(%data.useEmitterSizes);
	PEE_useEmitterColors.setValue(%data.useEmitterColors);
	PEE_noHide.setValue(%data.noHide);

	PEE_EmitterParticleSelector1.setText(getField(%data.particles, 0));
	PEE_EmitterParticleSelector2.setText(getField(%data.particles, 1));
	PEE_EmitterParticleSelector3.setText(getField(%data.particles, 2));
	PEE_EmitterParticleSelector4.setText(getField(%data.particles, 3));

	$ParticleEditor::currEmitter = %data;
	$ParticleEditor::currParticle = getField(%data.particles, 0);
}

function PE_ParticleEditor::updateControls(%this) {
	%id = PEP_ParticleSelector.getSelected();
	if (%id == 0)
		return;
	%data = PEP_ParticleSelector.getTextById(%id);

	PEP_dragCoefficient.setValue(%data.dragCoefficient);
	PEP_windCoefficient.setValue(%data.windCoefficient);
	PEP_gravityCoefficient.setValue(%data.gravityCoefficient);
	PEP_inheritedVelFactor.setValue(%data.inheritedVelFactor);
	PEP_constantAcceleration.setValue(%data.constantAcceleration);
	PEP_lifetimeMS.setValue(%data.lifetimeMS);
	PEP_lifetimeVarianceMS.setValue(%data.lifetimeVarianceMS);
	PEP_spinSpeed.setValue(%data.spinSpeed);
	PEP_spinRandomMin.setValue(%data.spinRandomMin);
	PEP_framesPerSec.setValue(%data.framesPerSec);
	PEP_useInvAlpha.setValue(%data.useInvAlpha);
	PEP_animateTexture.setValue(%data.animateTexture);
	for (%i = 0; %i < 4; %i++) {
		%obj = "PEP_times" @ %i;
		%obj.setText(%data.times[%i]);
		%obj.LastValue = %data.times[%i];
		%obj = "PEP_sizes" @ %i;
		%obj.setText(%data.sizes[%i]);
		%obj.LastValue = %data.sizes[%i];
		%obj = "PEP_colors" @ %i;
		%obj.setText(%data.colors[%i]);
		%obj.LastValue = %data.colors[%i];
	}
	PEP_textureName.setText(%data.textureName);
	PEP_textureName.LastValue = %data.textureName;

	$ParticleEditor::currParticle =   %data;
}

function ParticleEditor::openEmitterPane(%this) {
	PE_Window.setText("Particle Editor - Emitters");
	PE_EmitterEditor.setVisible(true);
	PE_EmitterButton.setActive(false);
	PE_ParticleEditor.setVisible(false);
	PE_ParticleButton.setActive(true);
	PE_EmitterEditor.updateControls();
	$ParticleEditor::activeEditor = PE_EmitterEditor;
}

function ParticleEditor::openParticlePane(%this) {
	PE_Window.setText("Particle Editor - Particles");
	PE_EmitterEditor.setVisible(false);
	PE_EmitterButton.setActive(true);
	PE_ParticleEditor.setVisible(true);
	PE_ParticleButton.setActive(false);

	PEP_ParticleSelector.sort();
	//PEP_ParticleSelector.setSelected(0);



	if (PEE_EmitterParticleSelector1.getText() !$= "") { //temp hax
		%i = 0;
		%text = PEE_EmitterParticleSelector1.getText();
		while (%i < 200) {
			if (PEP_ParticleSelector.getTextById(%i) $= %text) {
				%win = 1;

				break;
			} else
				%i++;
		}
		if (%win)
			PEP_ParticleSelector.setSelected(%i);
	} else
		PEP_ParticleSelector.setSelected(0);

	PE_ParticleEditor.updateControls();
	$ParticleEditor::activeEditor = PE_ParticleEditor;

	return;

	//buggy code past this point

	PEP_ParticleSelector.clear();
	PEP_ParticleSelector.add(PEE_EmitterParticleSelector1.getText(), 0);
	%count = 1;
	if (PEE_EmitterParticleSelector2.getText() !$= "") {
		PEP_ParticleSelector.add(PEE_EmitterParticleSelector2.getText(), %count);
		%count++;
	}
	if (PEE_EmitterParticleSelector3.getText() !$= "") {
		PEP_ParticleSelector.add(PEE_EmitterParticleSelector3.getText(), %count);
		%count++;
	}
	if (PEE_EmitterParticleSelector4.getText() !$= "")
		PEP_ParticleSelector.add(PEE_EmitterParticleSelector4.getText(), %count);

	PEP_ParticleSelector.sort();
	PEP_ParticleSelector.setSelected(0);   //select the PEE_EmitterParticleSelector1 particle

	PE_ParticleEditor.updateControls();
	$ParticleEditor::activeEditor = PE_ParticleEditor;
}

function PE_EmitterEditor::updateEmitter(%this) {
	$ParticleEditor::currEmitter.ejectionPeriodMS = PEE_ejectionPeriodMS.getValue();
	$ParticleEditor::currEmitter.periodVarianceMS = PEE_periodVarianceMS.getValue();
	if ($ParticleEditor::currEmitter.periodVarianceMS >= $ParticleEditor::currEmitter.ejectionPeriodMS) {
		$ParticleEditor::currEmitter.periodVarianceMS = $ParticleEditor::currEmitter.ejectionPeriodMS - 1;
		PEE_periodVarianceMS.setValue($ParticleEditor::currEmitter.periodVarianceMS);
	}
	$ParticleEditor::currEmitter.ejectionVelocity   = PEE_ejectionVelocity.getValue();
	$ParticleEditor::currEmitter.velocityVariance   = PEE_velocityVariance.getValue();
	if ($ParticleEditor::currEmitter.velocityVariance >= $ParticleEditor::currEmitter.ejectionVelocity) {
		$ParticleEditor::currEmitter.velocityVariance = $ParticleEditor::currEmitter.ejectionVelocity - 0.01;
		if ($ParticleEditor::currEmitter.velocityVariance < 0)
			$ParticleEditor::currEmitter.velocityVariance = 0;
		PEE_velocityVariance.setValue($ParticleEditor::currEmitter.velocityVariance);
	}
	$ParticleEditor::currEmitter.ejectionOffset     = PEE_ejectionOffset.getValue();
	$ParticleEditor::currEmitter.lifetimeMS         = PEE_lifetimeMS.getValue();
	$ParticleEditor::currEmitter.lifetimeVarianceMS = PEE_lifetimeVarianceMS.getValue();
	if ($ParticleEditor::currEmitter.lifetimeMS == 0) {
		$ParticleEditor::currEmitter.lifetimeVarianceMS = 0;
		PEE_lifetimeVarianceMS.setValue($ParticleEditor::currEmitter.lifetimeVarianceMS);
	} else if ($ParticleEditor::currEmitter.lifetimeVarianceMS >= $ParticleEditor::currEmitter.lifetimeMS) {
		$ParticleEditor::currEmitter.lifetimeVarianceMS = $ParticleEditor::currEmitter.lifetimeMS - 1;
		PEE_lifetimeVarianceMS.setValue($ParticleEditor::currEmitter.lifetimeVarianceMS);
	}
	$ParticleEditor::currEmitter.thetaMin           = PEE_thetaMin.getValue();
	$ParticleEditor::currEmitter.thetaMax           = PEE_thetaMax.getValue();
	$ParticleEditor::currEmitter.phiReferenceVel    = PEE_phiReferenceVel.getValue();
	$ParticleEditor::currEmitter.phiVariance        = PEE_phiVariance.getValue();
	$ParticleEditor::currEmitter.overrideAdvance    = PEE_overrideAdvance.getValue();
	$ParticleEditor::currEmitter.orientParticles    = PEE_orientParticles.getValue();
	$ParticleEditor::currEmitter.orientOnVelocity   = PEE_orientOnVelocity.getValue();
	$ParticleEditor::currEmitter.useEmitterSizes    = PEE_useEmitterSizes.getValue();
	$ParticleEditor::currEmitter.useEmitterColors   = PEE_useEmitterColors.getValue();
	$ParticleEditor::currEmitter.noHide             = PEE_noHide.getValue();
	$ParticleEditor::currEmitter.particles          = PEE_EmitterParticleSelector1.getText();

	if (PEE_EmitterParticleSelector2.getText() !$= "")
		$ParticleEditor::currEmitter.particles = $ParticleEditor::currEmitter.particles TAB PEE_EmitterParticleSelector2.getText();
	if (PEE_EmitterParticleSelector3.getText() !$= "")
		$ParticleEditor::currEmitter.particles = $ParticleEditor::currEmitter.particles TAB PEE_EmitterParticleSelector3.getText();
	if (PEE_EmitterParticleSelector4.getText() !$= "")
		$ParticleEditor::currEmitter.particles = $ParticleEditor::currEmitter.particles TAB PEE_EmitterParticleSelector4.getText();

	//$ParticleEditor::currEmitter.reload();
}

function PE_ParticleEditor::updateParticle(%this) {
	$ParticleEditor::currParticle.dragCoefficient      = PEP_dragCoefficient.getValue();
	$ParticleEditor::currParticle.windCoefficient      = PEP_windCoefficient.getValue();
	$ParticleEditor::currParticle.gravityCoefficient   = PEP_gravityCoefficient.getValue();
	$ParticleEditor::currParticle.inheritedVelFactor   = PEP_inheritedVelFactor.getValue();
	$ParticleEditor::currParticle.constantAcceleration = PEP_constantAcceleration.getValue();
	$ParticleEditor::currParticle.lifetimeMS           = PEP_lifetimeMS.getValue();
	$ParticleEditor::currParticle.lifetimeVarianceMS   = PEP_lifetimeVarianceMS.getValue();
	if ($ParticleEditor::currParticle.lifetimeVarianceMS >= $ParticleEditor::currParticle.lifetimeMS) {
		$ParticleEditor::currParticle.lifetimeVarianceMS = $ParticleEditor::currParticle.lifetimeMS - 1;
		PEP_lifetimeVarianceMS.setValue($ParticleEditor::currParticle.lifetimeVarianceMS);
	}
	$ParticleEditor::currParticle.spinSpeed            = PEP_spinSpeed.getValue();
	$ParticleEditor::currParticle.spinRandomMin        = PEP_spinRandomMin.getValue();
	$ParticleEditor::currParticle.spinRandomMax        = PEP_spinRandomMax.getValue();
	$ParticleEditor::currParticle.framesPerSec         = PEP_framesPerSec.getValue();
	$ParticleEditor::currParticle.useInvAlpha          = PEP_useInvAlpha.getValue();
	$ParticleEditor::currParticle.animateTexture       = PEP_animateTexture.getValue();

	$ParticleEditor::currParticle.times[0]             = PEP_times0.getValue();
	$ParticleEditor::currParticle.times[1]             = PEP_times1.getValue();
	$ParticleEditor::currParticle.times[2]             = PEP_times2.getValue();
	$ParticleEditor::currParticle.times[3]             = PEP_times3.getValue();
	$ParticleEditor::currParticle.sizes[0]             = PEP_sizes0.getValue();
	$ParticleEditor::currParticle.sizes[1]             = PEP_sizes1.getValue();
	$ParticleEditor::currParticle.sizes[2]             = PEP_sizes2.getValue();
	$ParticleEditor::currParticle.sizes[3]             = PEP_sizes3.getValue();
	$ParticleEditor::currParticle.colors[0]            = PEP_colors0.getValue();
	$ParticleEditor::currParticle.colors[1]            = PEP_colors1.getValue();
	$ParticleEditor::currParticle.colors[2]            = PEP_colors2.getValue();
	$ParticleEditor::currParticle.colors[3]            = PEP_colors3.getValue();

	$ParticleEditor::currParticle.textureName          = PEP_textureName.getValue();

	//$ParticleEditor::currParticle.reload();
}

function PE_EmitterEditor::onNewEmitter(%this) {
	ParticleEditor.updateEmitterNode();
	PE_EmitterEditor.updateControls();
}

function PE_ParticleEditor::onNewParticle(%this) {
	PE_ParticleEditor.updateControls();
}

function ParticleEditor::resetEmitterNode(%this) {
	%tform = ServerConnection.getControlObject().getEyeTransform();
	%vec = VectorNormalize(ServerConnection.getControlObject().getForwardVector());
	%vec = VectorScale(%vec, 4);
	%tform = setWord(%tform, 0, getWord(%tform, 0) + getWord(%vec, 0));
	%tform = setWord(%tform, 1, getWord(%tform, 1) + getWord(%vec, 1));
	%tform = setWord(%tform, 2, getWord(%tform, 2) + getWord(%vec, 2));

	if (!isObject($ParticleEditor::emitterNode)) {
		if (!isObject(TestEmitterNodeData)) {
			datablock ParticleEmitterNodeData(TestEmitterNodeData) {
				timeMultiple = 1;
			};
		}
		if (isObject(PEE_EmitterSelector.getText()))
			%emitter = PEE_EmitterSelector.getText();
		else
			%emitter = MarbleBounceEmitter;

		$ParticleEditor::emitterNode = new ParticleEmitterNode() {
			emitter = %emitter;
			velocity = 1;
			position = getWords(%tform, 0, 2);
			rotation = getWords(%tform, 3, 6);
			datablock = TestEmitterNodeData;
		};
		MissionCleanup.add($ParticleEditor::emitterNode);
		//grab the client-side emitter node so we can reload the emitter datablock
		$ParticleEditor::clientEmitterNode = $ParticleEditor::emitterNode+1;
	} else {
		$ParticleEditor::clientEmitterNode.setTransform(%tform);
		ParticleEditor.updateEmitterNode();
	}
}

function ParticleEditor::updateEmitterNode() {
	if (isObject($ParticleEditor::EmitterNode)) {
		%pos = $ParticleEditor::clientEmitterNode.getPosition();
		$ParticleEditor::EmitterNode.delete();
	} else
		%pos = localclientconnection.getControlObject().getPosition();

	if (isObject(PEE_EmitterSelector.getText()))
		%emitter = PEE_EmitterSelector.getText();
	else
		%emitter = MarbleBounceEmitter;

	$ParticleEditor::emitterNode = new ParticleEmitterNode() {
		emitter = %emitter;
		velocity = 1;
		position = %pos;
		rotation = "1 0 0 0";
		datablock = TestEmitterNodeData;
	};

	$ParticleEditor::clientEmitterNode = $ParticleEditor::emitterNode+1;
}

function PE_EmitterEditor::save(%this) {
	PE_ParticleEditor.save();

	// Commented code is for saving a single datablock.
	// Currently, both emitter & particle are done in the same file.

	//%mod = $currentMod;
	//if (%mod $= "")
	//{
	//PED.warn("Warning: No mod detected, saving in common.");
	//%mod = "common";
	//}
	//%filename = %mod @ "/data/particles/" @ $ParticleEditor::currEmitter @ ".cs";
	//$ParticleEditor::currEmitter.save(%filename);
	//%file = new FileObject();
	//%file.openForRead(%filename);
	//for (%i = -1; !%file.isEOF(); %line[%i++] = %file.readLine())
	//{
	//if (getSubStr(%line[%i], 0, 3) $= "new")
	//%line[%i] = "datablock" @ getSubStr(%line[%i], 3, 255);
	//}
	//%file.close();
	//%file.openForWrite(%filename);
	//for (%written = 0; %written < %i+1; %written++)
	//{
	//%file.writeLine(%line[%written]);
	//}
	//PED.success("Saved emitter to " @ %filename @ "!");
	//%file.close();
	//%file.delete();
}

function PE_ParticleEditor::save(%this) {
	%mod = $currentMod;
	if (%mod $= "") {
		PED.warn("Warning: No mod detected, saving in common.");
		%mod = "common";
	}
	%temp = %mod @ "/data/particles/temp.cs";
	%filename = %mod @ "/server/scripts/particles/" @ $ParticleEditor::currEmitter @ ".cs";
	$ParticleEditor::currParticle.save(%temp);
	%file = new FileObject();
	%file.openForRead(%temp);
	for (%i = -1; true; %line[%i++] = %file.readLine()) {
		if (getSubStr(%line[%i], 0, 2) $= "//") {
			if (%line[%i] $= "//--- OBJECT WRITE END ---") {
				%i--;
				break;
			}
			%line[%i] = " ";
		} else if (getSubStr(%line[%i], 0, 3) $= "new")
			%line[%i] = "datablock" @ getSubStr(%line[%i], 3, 255);
		if (getSubStr(%line[%i], 3, 11) $= "textureName")
			%line[%i] = "   textureName = \"" @ PEP_textureName.getValue() @ "\";";
	}
	%file.close();

	//The particles silder adds these extra fields that we don't need
	$ParticleEditor::currEmitter.oldPeriod = "";
	$ParticleEditor::currEmitter.newPeriod = "";
	$ParticleEditor::currEmitter.periodModified = "";

	$ParticleEditor::currEmitter.save(%temp);

	%file.openForRead(%temp);
	for (%g = -1; true; %lineB[%g++] = %file.readLine()) {
		if (getSubStr(%lineB[%g], 0, 7) $= "//--- O") {
			if (%lineB[%g] $= "//--- OBJECT WRITE END ---") {
				%g--;
				break;
			}
			%lineB[%g] = " ";
		} else if (getSubStr(%lineB[%g], 0, 3) $= "new")
			%lineB[%g] = "datablock" @ getSubStr(%lineB[%g], 3, 255);
	}
	%file.close();
	%file.openforWrite(%filename);

	// Write out the Particle, then Emitter.
	%file.writeLine(" ");
	%file.writeLine("//--- Particle ---");
	for (%written = 1; %written < %i+1; %written++)
		%file.writeLine(%line[%written]);

	%file.writeLine(" ");
	%file.writeLine("//--- Emitter ---");
	for (%written = 1; %written < %g+1; %written++)
		%file.writeLine(%lineB[%written]);

	PED.success("Saved emitter and particle to " @ %filename @ "!");
	%file.close();
	%file.delete();

	//%initcs = %mod @ "/data/particles/init.cs";
	//
	//%execString = "exec(\"./" @ $ParticleEditor::currEmitter @ ".cs\");";
	//
	//%file.openForRead(%initcs);
	////Skip the first four
	//%file.readLine(); %file.readLine(); %file.readLine(); %file.readLine();
	//%i = -1;
	//while(true)
	//{
	//%line[%i++] = %file.readLine();
	//if (%line[%i] $= %execString)
	//break;
	//if (%file.isEOF())
	//{
	//%writeExec = 1;
	//break;
	//}
	//}

	//%file.close();
	//
	//if (%writeExec)
	//{
	//%file.openForWrite(%initcs);
	//%file.writeLine("//---------------------------------");
	//%file.writeLine("// ParticleEditor saves");
	//%file.writeLine("//---------------------------------");
	//%file.writeLine(" ");
	//for (%written = 0; %written < %i; %written++)
	//%file.writeLine(%line[%written]);
	//%file.writeLine(%execString);
	//%file.writeLine(" ");
	//PED.success("Wrote entry to ParticleEditor save file!");
	//}
	//%file.delete();

	deleteFile(%temp);
}

function ParticleEditor::CreateNewEmitter() {
	%name = PEE_NewName.getValue();
	if (%name $= "") {
		PED.warn("Please type a name for the new Emitter");
		return;
	}
	if (isObject(%name)) {
		PED.error("Name " @ %name @ " is taken by another object");
		return;
	}
	eval("datablock ParticleEmitterData(" @ %name @ " : PE_TEMPLATEEMITTER){i=\"\";};");

	PEE_NewName.setValue("");
	particleeditor.refreshDatablocks();
	if (isObject(%name))
		PED.success("Created new Emitter: " @ %name);
	else
		PED.error("Create emitter failed!");
}

function ParticleEditor::CreateNewParticle() {
	%name = PEP_NewName.getValue();
	if (%name $= "") {
		PED.warn("Please type a name for the new Particle");
		return;
	}
	if (isObject(%name)) {
		PED.error("Name " @ %name @ " is taken by another object");
		return;
	}

	eval("datablock ParticleData(" @ %name @ " : PE_TEMPLATEPARTICLE){i=\"\";};");

	PEP_NewName.setValue("");
	particleeditor.refreshDatablocks();
	if (isObject(%name))
		PED.success("Created new Particle: " @ %name);
	else
		PED.error("Create particle failed!");
}

function ParticleEditor::ToggleLog() {
	if ($ParticleEditor::Log $= "")
		$ParticleEditor::Log = 0;
	PE_Window.extent = getWord(PE_Window.extent, 0) SPC 385 + (118 * !$ParticleEditor::Log);
	$ParticleEditor::Log = !$ParticleEditor::Log;
	PEDBorder.setVisible($ParticleEditor::Log);
}

function ParticleEditor::SingleValueEdit(%gui, %valueName) {
	%prefix = %gui.getPrefix();
	%obj = %prefix @ %valueName;
	if (!isObject(%obj)) {
		PED.error("PE::SVEdit() " SPC %obj SPC "not an object!");
		return;
	}
	%pos = %obj.position;
	%x = getWord(%pos, 0);
	%y = getWord(%pos, 1);
	%x -= 104;
	%y += 53;
	SingleValueGui.open(%gui, %valueName, %obj.getValue(), %x SPC %y);
}

function ParticleEditor::svcallback(%gui, %name, %value) {
	%prefix = %gui.getPrefix();
	%obj = %prefix @ %name;
	echo(%obj.getName());
	if (!isObject(%obj))
		return;

	%obj.setValue(%value);
	if (%prefix $= "PEE_")
		PE_EmitterEditor.updateEmitter();
	else
		PE_ParticleEditor.updateParticle();
}

function ParticleEditor::PETimeLineDlgCallback(%gui, %db) {
	if (!isObject(%db)) {
		PED.error("PETimeLineDlgCallback: Datablock doesn't exist!");
		return;
	}
	for (%i = 0; %i < 3; %i++) {
		%obj = "PEP_colors" @ %i;
		%obj.setValue(%db.colors[%i]);
		%obj = "PEP_sizes" @ %i;
		%obj.setValue(%db.sizes[%i]);
		%obj = "PEP_times" @ %i;
		%obj.setValue(%db.times[%i]);
	}
}

function ParticleEditor::getPrefix(%gui) {
	if ($ParticleEditor::activeEditor.getName() $= "PE_EmitterEditor")
		%prefix = "PEE_";
	else if ($ParticleEditor::activeEditor.getName() $= "PE_ParticleEditor")
		%prefix = "PEP_";
	return %prefix;
}

function ParticleEditor::onNewTexture(%gui) {
	//TODO
}


// dirty hack because the GuiTextEditSliderCtrl doesn't send its command
function ParticleEditor::loop(%gui) {
	if (%gui.getGroup() != Canvas.getID())
		return;

	%refresh = 0;

	for (%i = 0; %i < 12; %i++) {
		if (%i < 4)
			%obj = "PEP_times" @ %i;
		else if (%i < 8)
			%obj = "PEP_times" @ %i-4;
		else
			%obj = "PEP_times" @ %i-8;
		if (%obj.getValue() != %obj.LastValue) {
			%obj.LastValue = %obj.getValue();
			%refresh++;
		}
	}
	if (%refresh > 0) {
		PE_ParticleEditor.updateParticle();
		%gui.schedule(100, "loop");
		return;
	}

	if (PEP_textureName.LastValue !$= PEP_textureName.getValue()) {
		if (isFile(findFirstFile(PEP_textureName.getValue() @ "*")))
			%gui.onNewTexture();
		PEP_textureName.LastValue = PEP_textureName.getValue();
	}

	%gui.schedule(100, "loop");
}


//if (mAbs(getWord(%z, 2)) < 0.9)
//%x = vectorCross(%z, "0 0 1");  case 1
//else
//%x = vectorCross(%z, "0 1 0");  case 2

//Case 1:
// - Can be rotated about the X axis until -0.9
// - After that point, it flips about the emitter's origin

function petest(%obj, %edges) {
	for (%i = 0; %i < 5; %i++) {
		%testobj = "PETest" @ %i;
		if (isObject(%testobj))
			continue;

		new StaticShape(%testobj) {
			datablock = "BezierHandle";
			scale = "0.5 0.5 0.5";
		};
	}


	%rot = %obj.getRotation();
	%x = rottoVector(%rot, "1 0 0");
	//%y = rottoVector(%rot, "0 1 0");
	%z = rottoVector(%rot, "0 0 1");
	//%xy = vectorCross(%x, %y);
	//%ejectionAxis = matrixMultiplyByVector(rotAAtoM(%rot), "0 0 1");

	//%z = matrixMultiplyByVector(rotAAtoM(%rot), "0 0 1");

	if (mAbs(getWord(%z, 2)) < 0.9)
		%x = vectorCross(%z, "0 0 1");
	else
		%x = vectorCross(%z, "0 1 0");

	//%x = vectorScale(vectorNormalize(%x), -1);
	%x = vectorNormalize(%x);



	%db = %obj.emitter;
	for (%i = 0; %i < 5; %i++) {
		if (%edges) {
			if (%i == 0) {
				%theta = 1 * (%db.thetaMin);
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 1 * (%db.phiVariance / 2);
				%phiAA = %z SPC mDegToRad(%phi);
			}
			if (%i == 1) {
				%theta = 1 * (%db.thetaMax);
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 1 * (%db.phiVariance / 2);
				%phiAA = %z SPC mDegToRad(%phi);
			}
			if (%i == 2) {
				%theta = 1 * (%db.thetaMin + %db.thetaMax) / 2;
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 0;
				%phiAA = %z SPC mDegToRad(%phi);
			}
			if (%i == 3) {
				%theta = 1 * (%db.thetaMin + %db.thetaMax) / 2;
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 1 * (%db.phiVariance);
				%phiAA = %z SPC mDegToRad(%phi);
			}
			if (%i == 4) { //original, center
				%theta = 1 * (%db.thetaMin + %db.thetaMax) / 2;
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 1 * (%db.phiVariance / 2);
				%phiAA = %z SPC mDegToRad(%phi);
			}
		} else {
			if (%i == 0) {
				%theta = 1 * (%db.thetaMin);
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 1 * (%db.phiVariance);
				%phiAA = %z SPC mDegToRad(%phi);
			}
			if (%i == 1) {
				%theta = 1 * (%db.thetaMax);
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 1 * (%db.phiVariance);
				%phiAA = %z SPC mDegToRad(%phi);
			}
			if (%i == 2) {
				%theta = 1 * (%db.thetaMin);
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 0;
				%phiAA = %z SPC mDegToRad(%phi);
			}
			if (%i == 3) {
				%theta = 1 * (%db.thetaMax);
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 0;
				%phiAA = %z SPC mDegToRad(%phi);
			}
			if (%i == 4) { //original, center
				%theta = 1 * (%db.thetaMin + %db.thetaMax) / 2;
				%thetaAA = %x SPC mDegToRad(%theta);
				%phi = 1 * (%db.phiVariance / 2);
				%phiAA = %z SPC mDegToRad(%phi);
			}
		}

		//%theta = 1 * (%db.thetaMin + %db.thetaMax) / 2;
		//%thetaAA = %x SPC mDegToRad(%theta);
		//%phi = 1 * (%db.phiVariance / 2);
		//%phiAA = %z SPC mDegToRad(%phi);


		%ejectionAxis = %z;

		%temp = setMatrixAA(%thetaAA);
		%ejectionAxis = matrixMultiplyByVector(%temp, %ejectionAxis);
		%temp = setMatrixAA(%phiAA);
		%ejectionAxis = matrixMultiplyByVector(%temp, %ejectionAxis);

		//%final = vectorDot(%z, "0 0 1");
		%final = %ejectionAxis;
		//echo(%final);

		%testobj[%i] = "PETest" @ %i;

		if (isObject(%testobj[%i])) {
			%testobj[%i].setPosition(vectorAdd(%obj.getPosition(), %final));
		}
	}
}

// Emitter data should have theta min/max at equidistant positions from "90"

function ParticleEmitterNode::aimNode(%this, %pitch, %yaw) {
	// applyrotations("0 90 0", "25 0 0", "0 90 0");
	// PITCH, 0 TO 180 --^      YAW       REQUIRED

	//%yaw -= %this.emitter.phiVariance / 2;

	if (%yaw < 0)
		%yaw += 360;
	if (%yaw > 0) {
		%rot = applyRotations(0 SPC %pitch SPC 0, %yaw @ " 0 0", "0 90 0");
		%x = rottoVector(%rot, "1 0 0");
		%z = rottoVector(%rot, "0 0 1");

		if (mAbs(getWord(%z, 2)) < 0.9)
			%x = vectorCross(%z, "0 0 1");
		else
			%x = vectorCross(%z, "0 1 0");

		%x = vectorNormalize(%x);

		%theta = (%db.thetaMin + %db.thetaMax) / 2;
		%thetaAA = %x SPC mDegToRad(%theta);
		%phi = (%db.phiVariance / 2);
		%phiAA = %z SPC mDegToRad(%phi);

		%ejectionAxis = %z;

		%temp = setMatrixAA(%thetaAA);
		%ejectionAxis = matrixMultiplyByVector(%temp, %ejectionAxis);
		%temp = setMatrixAA(%phiAA);
		%ejectionAxis = matrixMultiplyByVector(%temp, %ejectionAxis);

		%yaw += mRadToDeg(mAtan(getWord(%ejectionAxis, 1), getWord(%ejectionAxis, 0)))/2;

	}
	//seriously dude just use fan explosions
	%t = %this.getPosition() SPC applyRotations(0 SPC %pitch SPC 0, %yaw @ " 0 0", "0 90 0");
	findObjectInSC(%this).setTransform(%t);
	%this.setTransform(%t);
}

function aimThisNode(%node) {
	FindSCCamera();
	%uvec = vectorScale(vectorSub(%node.getPosition(), $SCCamera.getPosition()), -1);
	%xy = mSqrt(mPow(getWord(%uvec, 0), 2) + mPow(getWord(%uvec, 1), 2));
	%pitch = mAtan(getWord(%uvec, 2), %xy);
	%pitch *= -1;
	%yaw = mAtan(getWord(%uvec, 1), getWord(%uvec, 0));
	%node.aimNode(mRadToDeg(%pitch)+90, mRadToDeg(%yaw)+90);
	//%node.setTransform($SCCamera.getPosition() SPC %node.getRotation());
}


function setMatrixAA(%aa) {
	return setMatrixQ(rotAAtoQ(%aa));
}

//adapted from TGE's mMath_C.cc

function setMatrixQ(%q) {
	%w = getWord(%q, 0);
	%x = getWord(%q, 1);
	%y = getWord(%q, 2);
	%z = getWord(%q, 3);

	//this bit from TGE's mQuat.cc
	if (%x*%x + %y*%y + %z*%z < 10E-20)
		return identityMatrix();

	%xs = %x * 2.0;
	%ys = %y * 2.0;
	%zs = %z * 2.0;
	%wx = %w * %xs;
	%wy = %w * %ys;
	%wz = %w * %zs;
	%xx = %x * %xs;
	%xy = %x * %ys;
	%xz = %x * %zs;
	%yy = %y * %ys;
	%yz = %y * %zs;
	%zz = %z * %zs;

	%m00 = 1.0 - (%yy + %zz);
	%m10 = %xy - %wz;
	%m20 = %xz + %wy;

	%m01 = %xy + %wz;
	%m11 = 1.0 - (%xx + %zz);
	%m21 = %yz - %wx;

	%m02 = %xz - %wy;
	%m12 = %yz + %wx;
	%m22 = 1.0 - (%xx + %yy);

	return (%m00 SPC %m01 SPC %m02 SPC
	        %m10 SPC %m11 SPC %m12 SPC
	        %m20 SPC %m21 SPC %m22);
}