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

function sunbutton() {
    for(%i = 0; %i < MissionGroup.getCount(); %i++) {
        %obj = MissionGroup.getObject(%i);
        if(MissionGroup.getObject(%i).getClassName() $= "Sun") {
            %sun = %obj;
            break;
        }
    }
    if(!isObject(%sun)) {
        error("Could not find sun");
        return;
    }
    
    LargeFunctionDlg.originalSunColor = %sun.color;
    LargeFunctionDlg.originalSunAmbient = %sun.ambient;
    LargeFunctionDlg.originalSunDirection = %sun.direction;
    LargeFunctionDlg.sun = %sun;
    
    LargeFunctionDlg.init("acceptSun", "Edit Sun", 0);
    
    LargeFunctionDlg.addDropMenu("SunPresets", "Main Game Suns:", 5, "Gold\tGold\nExpert\tPlatinum Expert");
    SunPresets.command = "onSelectSun();";
    
    LargeFunctionDlg.addNote("----------- Sun Color -----------");
    LargeFunctionDlg.addNote();
    LargeFunctionDlg.addSlider("SunRedSlider", "Red:", "0 255");
    LargeFunctionDlg.addSlider("SunGreenSlider", "Green:", "0 255");
    LargeFunctionDlg.addSlider("SunBlueSlider", "Blue:", "0 255");
    LargeFunctionDlg.addNote();
    
    LargeFunctionDlg.addNote("----------- Sun Ambient -----------");
    LargeFunctionDlg.addNote();
    LargeFunctionDlg.addSlider("SunRedAmbientSlider", "Red:", "0 255");
    LargeFunctionDlg.addSlider("SunGreenAmbientSlider", "Green:", "0 255");
    LargeFunctionDlg.addSlider("SunBlueAmbientSlider", "Blue:", "0 255");
    LargeFunctionDlg.addNote();
    
    SunRedSlider.ticks = SunGreenSlider.ticks = SunBlueSlider.ticks = 0;
    SunRedAmbientSlider.ticks = SunGreenAmbientSlider.ticks = SunBlueAmbientSlider.ticks = 0;
    
    LargeFunctionDlg.addNote("----------- Sun Direction -----------");
    LargeFunctionDlg.addNote();
    LargeFunctionDlg.addSlider("SunElevationSlider", "Elevation:", -$pi SPC $pi);
    LargeFunctionDlg.addNote("\tMorning\t\tNoon\t\tEvening", 3);
    LargeFunctionDlg.addNote("", 0);
    LargeFunctionDlg.addSlider("SunAzimuthSlider", "Azimuth:", -$pi SPC $pi);
    LargeFunctionDlg.addNote("  \tSouth\t\t\tWest\t\t\tNorth\t\t\tEast", 3);
    
    SunElevationSlider.ticks = SunAzimuthSlider.ticks = 3;
    SunElevationSlider.extent = SunAzimuthSlider.extent = "220 35";

    updateSunSliders();
    updateSun();
    activatePackage(cancelSunUpdates);
}

function onSelectSun() {
    // TODO save custom presets?
    switch$ (SunPresets.getValue()) {
        case "Gold":
            LargeFunctionDlg.sun.direction = "0.544508 0.439467 -0.714409";
            LargeFunctionDlg.sun.color = "1.400000 1.200000 0.400000 1.000000";
            LargeFunctionDlg.sun.ambient = "0.300000 0.300000 0.400000 1.000000";
        case "Expert":
            LargeFunctionDlg.sun.color = "0.700000 0.700000 0.700000 1.000000";
            LargeFunctionDlg.sun.ambient = "0.100000 0.100000 0.200000 1.000000";
            LargeFunctionDlg.sun.direction = "0.638261 0.459006 -0.61801";
    }
    updateSunSliders();
}

function updateSunSliders() {
    %sun = LargeFunctionDlg.sun;

    SunRedSlider.value = getWord(%sun.color, 0) * 255;
    SunGreenSlider.value = getWord(%sun.color, 1) * 255;
    SunBlueSlider.value = getWord(%sun.color, 2) * 255;
    
    SunRedAmbientSlider.value = getWord(%sun.ambient, 0) * 255;
    SunGreenAmbientSlider.value = getWord(%sun.ambient, 1) * 255;
    SunBlueAmbientSlider.value = getWord(%sun.ambient, 2) * 255;

    SunAzimuthSlider.value = mAtan(getWord(%sun.direction, 0), getWord(%sun.direction, 1));
    SunElevationSlider.value = mAtan(getWord(%sun.direction, 2), getWord(%sun.direction, 1));
    
    SunRedSlider.inspectPostApply();
    SunGreenSlider.inspectPostApply();
    SunBlueSlider.inspectPostApply();
    
    SunRedAmbientSlider.inspectPostApply();
    SunGreenAmbientSlider.inspectPostApply();
    SunBlueAmbientSlider.inspectPostApply();
    
    SunElevationSlider.inspectPostApply();
    SunAzimuthSlider.inspectPostApply();
}

function updateSun() {
    %sun = LargeFunctionDlg.sun;
    if(isObject(%sun)) {
        %sun.color = SunRedSlider.value / 255 SPC SunGreenSlider.value / 255 SPC SunBlueSlider.value / 255;
        %sun.ambient = SunRedAmbientSlider.value / 255 SPC SunGreenAmbientSlider.value / 255 SPC SunBlueAmbientSlider.value / 255;
        %sun.direction = VectorFromAzEl(SunAzimuthSlider.value, SunElevationSlider.value);
        %sun.inspectPostApply();
        cancel(LargeFunctionDlg.sunSch);
        LargeFunctionDlg.sunSch = schedule(50, 0, "updateSun");
    }
}

function acceptSun() {
    LargeFunctionDlg.sunAccepted = true;
}

package cancelSunUpdates {
    function LargeFunctionDlg::onSleep(%this) {
        if(!LargeFunctionDlg.sunAccepted && isObject(LargeFunctionDlg.sun)) {
            %sun = LargeFunctionDlg.sun;
            %sun.color = LargeFunctionDlg.originalSunColor;
            %sun.ambient = LargeFunctionDlg.originalSunAmbient;
            %sun.direction = LargeFunctionDlg.originalSunDirection;
            %sun.inspectPostApply();
        }
        cancel(LargeFunctionDlg.sunSch);
        LargeFunctionDlg.sun = "";
        LargeFunctionDlg.sunAccepted = false;
        deactivatePackage(cancelSunUpdates);
    }
};

function VectorFromAzEl(%az, %el) {
  return mSin(%az)*mCos(%el) SPC mCos(%az)*mCos(%el) SPC mSin(%el);
}