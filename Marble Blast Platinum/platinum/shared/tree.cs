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

function TreeBuild(%root, %path) {
	%slash = strpos(%path, "/");
	if (%slash == -1) {
		%name = %path;
		%rest = "";
	} else {
		%name = getSubStr(%path, 0, %slash);
		%rest = getSubStr(%path, %slash + 1, strlen(%path));
	}
	%count = %root.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%entry = %root.getEntry(%i);
		if (%entry.class !$= "Array") {
			continue;
		}
		if (%entry.name $= %name) {
			return TreeBuild(%entry, %rest);
		}
	}
	if (%name $= "") {
		return %root;
	}

	%next = TreeNode(new ScriptObject() {
		name = %name;
		parent = %root;
	});
	%root.__obj[%root.getSize()] = 1;
	%root.addEntry(%next);
	return TreeBuild(%next, %rest);
}

function TreeGet(%root, %path) {
	%slash = strpos(%path, "/");
	if (%slash == -1) {
		%name = %path;
		%rest = "";
	} else {
		%name = getSubStr(%path, 0, %slash);
		%rest = getSubStr(%path, %slash + 1, strlen(%path));
	}
	%count = %root.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%entry = %root.getEntry(%i);
		if (%entry.class !$= "Array") {
			continue;
		}
		if (%entry.name $= %name) {
			return TreeGet(%entry, %rest);
		}
	}
	if (%name $= "") {
		return %root;
	}
	return -1;
}

function TreePath(%root, %node) {
	%path = "";
	while (%node.getId() != %root.getId()) {
		%path = %node.name @ "/" @ %path;
		%node = %node.parent;
	}
	return %path;
}

function TreeNode(%obj) {
	%t = Array("TreeNode");
	if (isObject(%obj)) {
		%t.setFields(%obj.getFields());
	}
	return %t;
}

function TreeDepth(%root, %node) {
	%depth = 0;
	while (%node.getId() != %root.getId()) {
		%depth ++;
		%node = %node.parent;
	}
	return %depth;
}

function TreeCollapseDepth(%root, %node) {
	%depth = 0;
	while (%node.getId() != %root.getId()) {
		//Only count nodes that have items other than other nodes
		if (%node.getEntry(%node.getSize() - 1).class !$= "Array") {
			%depth ++;
		}
		%node = %node.parent;
	}
	return %depth;
}

function TreeCollapsePath(%root, %node) {
	%path = "";
	while (%node.getId() != %root.getId()) {
		%path = %node.name @ "/" @ %path;
		%node = %node.parent;
		//Only count nodes that have items other than other nodes
		if (%node.getEntry(%node.getSize() - 1).class !$= "Array") {
			return %path;
		}
	}
	return %path;
}

function recurseSort(%array, %fn) {
	%array.sort(%fn);

	%count = %array.getSize();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %array.getEntry(%i);
		if (isObject(%obj) && (%obj.class $= "Array")) {
			recurseSort(%obj, %fn);
		}
	}
}

function sortNameOrArray(%a, %b) {
	%aArray = isObject(%a) && (%a.class $= "Array");
	%bArray = isObject(%b) && (%b.class $= "Array");
	//Arrays sort first
	if (%aArray != %bArray) {
		return %aArray && !%bArray;
	}
	if (%aArray && %bArray) {
		return stricmp(%a.name, %b.name) < 0;
	}
	return stricmp(%a, %b) < 0;
}

function sortIndexOrArray(%a, %b) {
	%aArray = isObject(%a) && (%a.class $= "Array");
	%bArray = isObject(%b) && (%b.class $= "Array");
	//Arrays sort first
	if (%aArray != %bArray) {
		return %aArray && !%bArray;
	}
	return false;
}
