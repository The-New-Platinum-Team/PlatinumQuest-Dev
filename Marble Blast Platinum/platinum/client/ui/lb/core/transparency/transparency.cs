//-----------------------------------------------------------------------------
// Transparency.cs
//
// Because Andrew's PoS computer can't handle GuiBitmapBorderCtrls. (sigh)
// They were a pain to implement, and they worked SO NICELY TOO!
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

if (!isObject(GuiTransparencyProfile)) new GuiControlProfile(GuiTransparencyProfile) {
	border = false;
	opaque = false;
	fillColor = "0 0 0 0";
	transType = "50";
	transSize = 14;
};

if (!isObject(GuiTransparency75Profile)) new GuiControlProfile(GuiTransparency75Profile) {
	border = false;
	opaque = false;
	fillColor = "0 0 0 0";
	transType = "75";
	transSize = 14;
};

if (!isObject(PQPanelProfile)) new GuiControlProfile(PQPanelProfile) {
	border = false;
	opaque = false;
	fillColor = "0 0 0 0";
	transType = "75square";
	transSize = 21;
};

if (!isObject(PQWindowProfile)) new GuiControlProfile(PQWindowProfile) {
	border = false;
	opaque = false;
	fillColor = "0 0 0 0";
	transType = "pqwindow";
	transSize = 31;
	transBlur = true;
	transBounds = "12 12 12 12";
};

if (!isObject(PQTextboxBorderProfile)) new GuiControlProfile(PQTextboxBorderProfile) {
	border = false;
	opaque = false;
	fillColor = "0 0 0 0";
	transType = "75noshadow";
	transSize = 11;
};

if (!isObject(GuiTransparencyTextProfile)) new GuiControlProfile(GuiTransparencyTextProfile) {
	border = false;
	opaque = false;
	fillColor = "0 0 0 0";
	transType = "50";
};

if (!isObject(GuiTransparencyText75Profile)) new GuiControlProfile(GuiTransparencyText75Profile) {
	border = false;
	opaque = false;
	fillColor = "0 0 0 0";
	transType = "75";
};

if (!isObject(GuiTransparencyInnerProfile)) new GuiControlProfile(GuiTransparencyInnerProfile) {
	modal = false;
};

package SexyTransparency {
	/**
	 * @param {GuiControl} %this
	 */
	function GuiControl::onAdd(%this) {
		Parent::onAdd(%this);
		%this.checkTransparency();
	}
	function transparencyBitmap(%bitmap) {
		%bitmap = expandFilename(%bitmap);
		if ($TexturePack::SwapTextures[%bitmap] !$= "") {
			// Why
			return $TexturePack::SwapTextures[%bitmap];
		}
		return %bitmap;
	}
	/**
	 * @param {GuiControl} %this
	 */
	function GuiControl::reloadTransparency(%this) {
		// Sanity
		if (%this.getCount() == 0)
			return;
		if (!%this.getObject(0).transparency)
			return;

		%trans = %this.getObject(0);
		%this.hasTransparency = false;
		%this.checkTransparency();
		%this.pushToBack(%trans);
		%trans.delete();
	}
	/**
	 * @param {GuiControl} %this
	 */
	function GuiControl::checkTransparency(%this) {
		%transType = "";
		// Different types of transparency get different profiles
		%transType = %this.profile.transType;
		if (%transType $= "")
			return;
		if (%this.hasTransparency)
			return;

		%extent = %this.extent;
		%sz = %this.profile.transSize;

		// Scoot it out 2 pixels for the completely transparent bits
		%extent = VectorAdd(%extent, "2 2");
		%this.minExtent = (%sz * 2 - 1) SPC(%sz * 2 - 1);
		%this.hasTransparency = true;

		%trans = new GuiControl() {
			profile = "GuiTransparencyInnerProfile";
			horizSizing = "width";
			vertSizing = "height";
			position = "-1 -1";
			minExtent = (%sz * 2 + 1) SPC(%sz * 2 + 1);
			extent = %extent;
			minExtent = "1 1";
			visible = "1";
			transparency = "1";

			new GuiBitmapCtrl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "right";
				vertSizing = "bottom";
				position = "0 0";
				extent = %sz SPC %sz;
				minExtent = "1 1";
				visible = "1";
				bitmap = transparencyBitmap("./" @ %transType @ "/transparency-TL");
			};
			new GuiBitmapCtrl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "left";
				vertSizing = "bottom";
				position = getWord(%extent, 0) - %sz SPC "0";
				extent = %sz SPC %sz;
				minExtent = "1 1";
				visible = "1";
				bitmap = transparencyBitmap("./" @ %transType @ "/transparency-TR");
			};
			new GuiBitmapCtrl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "right";
				vertSizing = "top";
				position = "0" SPC getWord(%extent, 1) - %sz;
				extent = %sz SPC %sz;
				minExtent = "1 1";
				visible = "1";
				bitmap = transparencyBitmap("./" @ %transType @ "/transparency-BL");
			};
			new GuiBitmapCtrl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "left";
				vertSizing = "top";
				position = getWord(%extent, 0) - %sz SPC getWord(%extent, 1) - %sz;
				extent = %sz SPC %sz;
				minExtent = "1 1";
				visible = "1";
				bitmap = transparencyBitmap("./" @ %transType @ "/transparency-BR");
			};
			new GuiBitmapCtrl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "right";
				vertSizing = "height";
				position = "0" SPC %sz;
				extent = %sz SPC getWord(%extent, 1) - (%sz * 2);
				minExtent = "1 1";
				visible = "1";
				bitmap = transparencyBitmap("./" @ %transType @ "/transparency-L");
			};
			new GuiBitmapCtrl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "width";
				vertSizing = "bottom";
				position = %sz SPC "0";
				extent = getWord(%extent, 0) - (%sz * 2) SPC %sz;
				minExtent = "1 1";
				visible = "1";
				bitmap = transparencyBitmap("./" @ %transType @ "/transparency-T");
			};
			new GuiBitmapCtrl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "left";
				vertSizing = "height";
				position = getWord(%extent, 0) - %sz SPC %sz;
				extent = %sz SPC getWord(%extent, 1) - (%sz * 2);
				minExtent = "1 1";
				visible = "1";
				bitmap = transparencyBitmap("./" @ %transType @ "/transparency-R");
			};
			new GuiBitmapCtrl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "width";
				vertSizing = "top";
				position = %sz SPC getWord(%extent, 1) - %sz;
				extent = getWord(%extent, 0) - (%sz * 2) SPC %sz;
				minExtent = "1 1";
				visible = "1";
				bitmap = transparencyBitmap("./" @ %transType @ "/transparency-B");
			};
			new GuiBitmapCtrl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "width";
				vertSizing = "height";
				position = %sz SPC %sz;
				extent = getWord(%extent, 0) - (%sz * 2) SPC getWord(%extent, 1) - (%sz * 2);
				minExtent = "1 1";
				visible = "1";
				bitmap = transparencyBitmap("./" @ %transType @ "/transparencyfill");
			};
		};
		%this.add(%trans);
		%this.bringToFront(%trans);

		if (%this.profile.transBlur) {
			%bounds = %this.profile.transBounds;
			%trans.add(%blur = new GuiControl() {
				profile = "GuiTransparencyInnerProfile";
				horizSizing = "width";
				vertSizing = "height";
				position = getWords(%bounds, 0, 1);
				extent = (getWord(%extent, 0) - getWord(%bounds, 0) - getWord(%bounds, 2)) SPC (getWord(%extent, 1) - getWord(%bounds, 1) - getWord(%bounds, 3));
				visible = "1";
				blur = "1";
			});
			%trans.bringToFront(%blur);
		}
	}
	/**
	 * @param {GuiControl} %this
	 */
	function GuiControl::onInspectApply(%this) {
		Parent::onInspectApply(%this);
		//Clear transparency if we can

		if (%this.hasTransparency !$= "") {
			%this.hasTransparency = "";

			//Find trans
			for (%i = 0; %i < %this.getCount(); %i ++) {
				%obj = %this.getObject(%i);
				if (%obj.transparency) {
					//Yep
					%this.pushToBack(%obj);
					%obj.delete();
					break;
				}
			}
		}

		%this.checkTransparency();
	}
	/**
	 * @param {GuiControl} %this
	 */
	function GuiControl::onGuiEditorPreSave(%this) {
		Parent::onGuiEditorPreSave(%this);
		if (%this.transparency $= "1") {
			%this.getGroup().pushToBack(%this);
			%this.delete();
			return;
		}
		if (%this.hasTransparency !$= "") {
			%this.hasTransparency = "";
			$transparency[%this.getId()] = 1;
		}
	}
	/**
	 * @param {GuiControl} %this
	 */
	function GuiControl::onGuiEditorPostSave(%this) {
		Parent::onGuiEditorPostSave(%this);
		if ($transparency[%this.getId()] == 1) {
			$transparency[%this.getId()] = "";
			%this.checkTransparency();
		}
	}
};

activatePackage(SexyTransparency);
