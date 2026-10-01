//-----------------------------------------------------------------------------
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

//Dedicated servers need the marble select but they can't do any GUI
new ScriptObject(MarbleSelectDlg) {
	lists = array(MarbleSelectListsArray);
};

/**
 * @param {JSONObject} %parsed
 */
function loadDedicatedMarbleList(%parsed) {
	//Add all of the categories
	%count = %parsed.categories.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%category = %parsed.categories.getEntry(%i);
		%id = %category.id;
		%name = %category.name;
		%base = strReplace(%category.file_base, "~", $usermods);

		devecho("Got new marble category: " @ %name @ ", base " @ %base @ " id " @ %id);

		MarbleSelectDlg.lists.addEntry(new ScriptObject() {
			name = %name;
			id = %id;
			base = %base;
			marbles = array("MarbleSelectListMarblesArray");
			skins = false;
		});
	}

	//Add all of the missions
	%count = %parsed.marbles.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%marble = %parsed.marbles.getEntry(%i);
		%id = %marble.id;
		%category = %marble.category_id;
		%name = %marble.name;
		%shape = %marble.shape_file;
		%skin = %marble.skin;

		//Get list by id
		%list = -1;
		for (%j = 0; %j < MarbleSelectDlg.lists.getSize(); %j ++) {
			%test = MarbleSelectDlg.lists.getEntry(%j);
			if (%test.id == %category) {
				%list = %test;
				break;
			}
		}

		%listName = %list.name;

		devecho("Got new marble: " @ %name @ " list " @ %listName @ " shape " @ %shape @ " skin " @ %skin);

		%list.marbles.addEntry(new ScriptObject() {
			name = %name;
			shape = %shape;
			skin = %skin;
			normalize = true;
			id = %id;
			shaderV = %marble.shaderV;
			shaderF = %marble.shaderF;
		});
	}

	%parsed.recurseDelete();

	createMarbleDatablocks();
}

//Please load
function tryLoadDedicatedMarbleList() {
	if (MarbleSelectDlg.lists.getSize() == 0) {
		statsGetMarbleList();
		schedule(5000, 0, tryLoadDedicatedMarbleList);
	}
}

//Later!
schedule(1000, 0, tryLoadDedicatedMarbleList);