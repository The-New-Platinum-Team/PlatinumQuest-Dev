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
    %group = isObject(MissionData) ? MissionData : MissionGroup;
    for(%i = 0; %i < %group.getCount(); %i++) {
        %obj = %group.getObject(%i);
        if(%obj.getClassName() $= "Sun") {
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

    for(%i = 0; $WEPref::sunPresets[%i] !$= ""; %i++) {
        %name = getField($WEPref::sunPresets[%i], 0);
        %dropdown = %dropdown @ "\n" @ %name @ "\t" @ %name;
        LargeFunctionDlg.sunPresets[%name] = $WEPref::sunPresets[%i];
    }

    LargeFunctionDlg.addDropMenu("SunPresets", "Presets:", 5, %dropdown);
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

    LargeFunctionDlg.addButton("SavePresetButton", "Save Preset");
    LargeFunctionDlg.addButton("DeletePresetButton", "Delete Preset");
    
    SunElevationSlider.ticks = SunAzimuthSlider.ticks = 3;
    SunElevationSlider.extent = SunAzimuthSlider.extent = "220 35";

    updateSunSliders();
    activatePackage(cancelSunChanges);
}

function onSelectSun() {
    %preset = LargeFunctionDlg.sunPresets[SunPresets.getValue()];
    LargeFunctionDlg.sun.direction = getField(%preset, 1);
    LargeFunctionDlg.sun.color = getField(%preset, 2);
    LargeFunctionDlg.sun.ambient = getField(%preset, 3);
    updateSunSliders();
    updateEditSun();
}

/**
 * @param {SunRedSlider} %this
 */
function SunRedSlider::onMouseDragged(%this) { updateEditSunColor(); }
/**
 * @param {SunGreenSlider} %this
 */
function SunGreenSlider::onMouseDragged(%this) { updateEditSunColor(); }
/**
 * @param {SunBlueSlider} %this
 */
function SunBlueSlider::onMouseDragged(%this) { updateEditSunColor(); }

/**
 * @param {SunRedAmbientSlider} %this
 */
function SunRedAmbientSlider::onMouseDragged(%this) { updateEditSunAmbient(); }
/**
 * @param {SunGreenAmbientSlider} %this
 */
function SunGreenAmbientSlider::onMouseDragged(%this) { updateEditSunAmbient(); }
/**
 * @param {SunBlueAmbientSlider} %this
 */
function SunBlueAmbientSlider::onMouseDragged(%this) { updateEditSunAmbient(); }

/**
 * @param {SunElevationSlider} %this
 */
function SunElevationSlider::onMouseDragged(%this) { updateEditSunDirection(); }
/**
 * @param {SunAzimuthSlider} %this
 */
function SunAzimuthSlider::onMouseDragged(%this) { updateEditSunDirection(); }

/**
 * @param {SavePresetButton} %this
 */
function SavePresetButton::onPressed(%this) { SingleValueGui.open(%this); }
/**
 * @param {DeletePresetButton} %this
 */
function DeletePresetButton::onPressed(%this) { deleteSunPreset(); }

/**
 * @param {SavePresetButton} %this
 * @param {Type} %name
 * @param {Type} %value
 */
function SavePresetButton::svcallback(%this, %name, %value) {
    if(saveSunPreset(%value)) {
        sunbutton();
        SunPresets.setValue(%value);
    }
}

function updateEditSunDirection() {
    LargeFunctionDlg.sun.direction = VectorFromAzEl(SunAzimuthSlider.getValue(), SunElevationSlider.getValue()); //TODO fix
    LargeFunctionDlg.sun.onNextFrame("inspectPostApply");
}

function updateEditSunColor() {
    LargeFunctionDlg.sun.color = SunRedSlider.getValue() / 255 SPC SunGreenSlider.getValue() / 255 SPC SunBlueSlider.getValue() / 255;
    LargeFunctionDlg.sun.onNextFrame("inspectPostApply");
}

function updateEditSunAmbient() {
    LargeFunctionDlg.sun.ambient = SunRedAmbientSlider.getValue() / 255 SPC SunGreenAmbientSlider.getValue() / 255 SPC SunBlueAmbientSlider.getValue() / 255;
    LargeFunctionDlg.sun.onNextFrame("inspectPostApply");
}

function updateEditSun() {
    updateEditSunDirection();
    updateEditSunColor();
    updateEditSunAmbient();
}

function updateSunSliders() {
    %sun = LargeFunctionDlg.sun;

    SunRedSlider.setValue(getWord(%sun.color, 0) * 255);
    SunGreenSlider.setValue(getWord(%sun.color, 1) * 255);
    SunBlueSlider.setValue(getWord(%sun.color, 2) * 255);
    
    SunRedAmbientSlider.setValue(getWord(%sun.ambient, 0) * 255);
    SunGreenAmbientSlider.setValue(getWord(%sun.ambient, 1) * 255);
    SunBlueAmbientSlider.setValue(getWord(%sun.ambient, 2) * 255);

    %x = getWord(%sun.direction, 0);
    %y = getWord(%sun.direction, 1);
    %z = getWord(%sun.direction, 2);

    %az = mAtan(%x, %y);
    %dist = mSqrt(%x*%x + %y*%y);
    %el = mAtan(%z, %dist);

    SunAzimuthSlider.setValue(%az);
    SunElevationSlider.setValue(%el);
}

function acceptSun() {
    LargeFunctionDlg.sunAccepted = true;
}

function saveSunPreset(%name) {
    for(%i = 0; $WEPref::sunPresets[%i] !$= ""; %i++) {
        if(getField($WEPref::sunPresets[%i], 0) $= %name) {
            MessageBoxOK("Error", "Preset with that name already exists.");
            return false;
        }
    }
    $WEPref::sunPresets[%i] = %name TAB LargeFunctionDlg.sun.direction TAB LargeFunctionDlg.sun.color TAB LargeFunctionDlg.sun.ambient;
    return true;
}

function deleteSunPreset() {
    %name = SunPresets.getValue();
    if (%name $= "") return;
    MessageBoxYesNo("Delete Preset", "Delete the sun preset '" @ %name @ "'?", "doDeleteSunPreset(\"" @ %name @ "\"); sunbutton();", "");
}

function doDeleteSunPreset(%name) {
    for (%i = 0; $WEPref::sunPresets[%i] !$= ""; %i++) {
        %currentName = getField($WEPref::sunPresets[%i], 0);
        if (%currentName $= %name)
            %found = true;
        if (%found)
            $WEPref::sunPresets[%i] = $WEPref::sunPresets[%i+1];
    }
    if(%found)
        deleteVariables("$WEPref::sunPresets" @ (%i - 1));
}

package cancelSunChanges {
    /**
     * @param {Type} %this
     */
    function LargeFunctionDlg::onSleep(%this) {
        if(!LargeFunctionDlg.sunAccepted && isObject(LargeFunctionDlg.sun)) {
            %sun = LargeFunctionDlg.sun;
            %sun.color = LargeFunctionDlg.originalSunColor;
            %sun.ambient = LargeFunctionDlg.originalSunAmbient;
            %sun.direction = LargeFunctionDlg.originalSunDirection;
            %sun.inspectPostApply();
        }
        LargeFunctionDlg.sun = "";
        LargeFunctionDlg.sunAccepted = false;
        deactivatePackage(cancelSunChanges);
    }
};

function VectorFromAzEl(%az, %el) {
    return mSin(%az)*mCos(%el) SPC mCos(%az)*mCos(%el) SPC mSin(%el);
}

if($WEPref::sunPresets0 $= "")
    $WEPref::sunPresets0 = "Gold\t0.544508 0.439467 -0.714409\t1.4 1.2 0.4 1\t0.3 0.3 0.4 1";
if($WEPref::sunPresets1 $= "")
    $WEPref::sunPresets1 = "Ultra\t0.5732009 0.2753569 -0.7717638\t1.08 1.03 0.9 1\t0.4 0.4 0.5 1";
if($WEPref::sunPresets2 $= "")
    $WEPref::sunPresets2 = "Platinum Expert\t0.638261 0.459006 -0.61801\t0.7 0.7 0.7 1\t0.1 0.1 0.2 1";