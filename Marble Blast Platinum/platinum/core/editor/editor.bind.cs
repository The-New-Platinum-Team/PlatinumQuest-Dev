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
// Portions Copyright (c) 2001 by Sierra Online, Inc.
//-----------------------------------------------------------------------------

//------------------------------------------------------------------------------
// Mission Editor Manager
new ActionMap(EditorMap);

EditorMap.bindCmd(keyboard, "f2", "editor.setEditor(\"World Editor\");", "");
EditorMap.bindCmd(keyboard, "f3", "editor.setEditor(\"World Editor Inspector\");", "");
EditorMap.bindCmd(keyboard, "f4", "editor.setEditor(\"World Editor Creator\");", "");
EditorMap.bind(keyboard, "f5", toggleParticleEditor);

EditorMap.bindCmd(keyboard, "alt s", "RootGui.pushDialog(EditorSaveMissionDlg);", "");
//EditorMap.bindCmd(keyboard, "alt r", "lightScene(\"\", forceAlways);", "");
EditorMap.bindCmd(keyboard, "escape", "editor.close();", "");

// alt-#: set bookmark
for (%i = 0; %i < 9; %i++)
	EditorMap.bindCmd(keyboard, "alt " @ %i, "editor.setBookmark(" @ %i @ ");", "");

// ctrl-#: goto bookmark
for (%i = 0; %i < 9; %i++)
	EditorMap.bindCmd(keyboard, "ctrl " @ %i, "editor.gotoBookmark(" @ %i @ ");", "");

EditorMap.bindCmd(keyboard, "ctrl f", "EWorldEditor.focusOnSelection();", "");
