//-----------------------------------------------------------------------------
// Copyright (c) 2026 The Platinum Team
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

function pathbutton(%mpOrMarker) {
    if(%mpOrMarker.getClassName() $= "Marker" && %mpOrMarker.getGroup().getClassName() $= "Path") {
        %path = %mpOrMarker.getGroup();
    }
    else if(%mpOrMarker.getClassName() $= "PathedInterior") {
        %path = %mpOrMarker.getPath();
    }
    if (!isObject(%path)) {
        error("Could not find path");
        return;
    }

    LargeFunctionDlg.path = %path;
    LargeFunctionDlg.pathedInterior = %mp;
    
    for(%i = 0; (%obj = %path.getObject(%i)) != -1; %i++) {
        //LargeFunctionDlg.originalMarkerTransform[%obj] = %obj.getTransform();
        LargeFunctionDlg.originalMarkerTime[%obj] = %obj.msToNext;
        LargeFunctionDlg.originalMarkerSmoothingType[%obj] = %obj.smoothingType;
    }
    LargeFunctionDlg.originalPathSpeed = %path.speed;
    
    LargeFunctionDlg.init("acceptPath", "Edit Path", 0);

    LargeFunctionDlg.addDropMenu("PathSmoothingTypes", "Smoothing", 5, "Spline\tSpline\nLinear\tLinear\nAccelerate\tAccelerate", %path.getObject(0).smoothingType);
    PathSmoothingTypes.command = "onSelectSmoothingType();";

    LargeFunctionDlg.addCheckBox("ConstantSpeedBox", "Normalize Speed", %path.speed !$= "");

    LargeFunctionDlg.addSlider("PathSpeedSlider", "Normalized Speed:", "0 20", %path.speed, 2, true);
    PathSpeedSlider.command = "onSelectPathSpeed();";

    LargeFunctionDlg.addButton("PathCenterButton", "Center Path");
    LargeFunctionDlg.addButton("SelectPathButton", "Select Path");
    LargeFunctionDlg.addButton("SelectMPsButton", "Select MPs");
    //LargeFunctionDlg.addButton("FixSeqNumButton", "Fix seqNums");

    activatePackage(cancelPathChanges);
}

function onSelectSmoothingType() {
    LargeFunctionDlg.path.setSmoothingType(PathSmoothingTypes.getValue());
}

function onSelectPathSpeed() {
    LargeFunctionDlg.path.setSpeed(max(0.1, PathSpeedSlider.getValue()));
    ConstantSpeedBox.setValue(true);
}

function ConstantSpeedBox::onPressed(%this, %gui) {
    if(!%this.getValue()) {
        LargeFunctionDlg.path.speed = "";
        for(%i = 0; (%obj = LargeFunctionDlg.path.getObject(%i)) != -1; %i++) {
            %obj.msToNext = LargeFunctionDlg.originalMarkerTime[%obj];
        }
        LargeFunctionDlg.path.update();
    }
    else {
        onSelectPathSpeed();
    }
}

function PathCenterButton::onPressed(%this, %gui) {
    if(isObject(%gui.pathedInterior))
        %gui.pathedInterior.recenterPath();
    else if (isObject(%group = %gui.path.getGroup())) {
        for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
            if(%obj.getClassName() $= "PathedInterior") {
                %obj.recenterPath();
                break;
            }
        }
    }
}

function SelectPathButton::onPressed(%this, %gui) {
    EWorldEditor.clearSelection();
    EWorldEditor.selectGroup(%gui.path);
}

function SelectMPsButton::onPressed(%this, %gui) {
    EWorldEditor.clearSelection();
    if (isObject(%group = %gui.path.getGroup())) {
        for(%i = 0; (%obj = %group.getObject(%i)) != -1; %i++) {
            if(%obj.getClassName() $= "PathedInterior") {
                EditorTree.onSelect(%obj);
            }
        }
    }
}

function acceptPath() {
    LargeFunctionDlg.pathAccepted = true;
    syncMovingPlatforms();
}

package cancelPathChanges {
    function LargeFunctionDlg::onSleep(%this) {
        if(!LargeFunctionDlg.pathAccepted && isObject(LargeFunctionDlg.path)) {
            for(%i = 0; (%obj = LargeFunctionDlg.path.getObject(%i)) != -1; %i++) {
                //%obj.setTransform(LargeFunctionDlg.originalMarkerTransform[%obj]);
                %obj.msToNext = LargeFunctionDlg.originalMarkerTime[%obj];
                %obj.smoothingType = LargeFunctionDlg.originalMarkerSmoothingType[%obj];
            }
            LargeFunctionDlg.path.speed = LargeFunctionDlg.originalPathSpeed;
            LargeFunctionDlg.path.onNextFrame("update");
        }
        LargeFunctionDlg.path = "";
        LargeFunctionDlg.pathAccepted = false;
        deactivatePackage(cancelPathChanges);
    }
};