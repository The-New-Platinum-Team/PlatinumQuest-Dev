//-----------------------------------------------------------------------------
// arrayObject.cs
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

// make the array group
if (!isObject(ArrayGroup)) {
	RootGroup.add(new SimGroup(ArrayGroup));
}
if (!isObject(JSONGroup)) {
	RootGroup.add(new SimGroup(JSONGroup));
}

// Get the index of the first object with %value at field %field
function Array::getIndexByField(%this, %value, %field) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		if (getField(%this.getEntry(%i), %field) $= %value)
			return %i;
	}
	return -1;
}

// Get the index of the first object with %value at record %record
function Array::getIndexByRecord(%this, %value, %record) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		if (getRecord(%this.getEntry(%i), %record) $= %value)
			return %i;
	}
	return -1;
}

// Get the first object with %value at field %field
function Array::getEntryByField(%this, %value, %field) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		if (getField(%this.getEntry(%i), %field) $= %value)
			return %this.getEntry(%i);
	}
	return "";
}

// Get the first object with %value at record %record
function Array::getEntryByRecord(%this, %value, %record) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		if (getRecord(%this.getEntry(%i), %record) $= %value)
			return %this.getEntry(%i);
	}
	return "";
}

// Get the first object with %value at variable %var
function Array::getEntryByVariable(%this, %var, %value) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		if (isObject(%this.getEntry(%i)) && %this.getEntry(%i).getFieldValue(%var) $= %value)
			return %this.getEntry(%i);
	}
	return "";
}

// get the index of the specified entry
function Array::getIndexByEntry(%this, %value) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		if (%this.getEntry(%i) $= %value)
			return %i;
	}
	return -1;
}

// Shorthand again!
function Array::getIndex(%this, %value) {
	return %this.getIndexByEntry(%value);
}

function Array::containsEntryAtField(%this, %entry, %field) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		%ientry = getField(%this.getEntry(%i), %field);
		if (%ientry $= %entry)
			return true;
	}
	return false;
}

// I like shortness
function Array::containsField(%this, %entry, %field) {
	return %this.containsEntryAtField(%entry, %field);
}

function Array::containsEntryAtRecord(%this, %entry, %record) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		%ientry = getRecord(%this.getEntry(%i), %record);
		if (%ientry $= %entry)
			return true;
	}
	return false;
}

// I like shortness
function Array::containsRecord(%this, %entry, %record) {
	return %this.containsEntryAtRecord(%entry, %record);
}


function Array::containsEntryAtVariable(%this, %var, %entry) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		if (!isObject(%this.getEntry(%i)))
			continue;
		%ientry = %this.getEntry(%i).getFieldValue(%var);
		if (%ientry $= %entry)
			return true;
	}
	return false;
}

// I like shortness
function Array::containsVariable(%this, %var, %entry) {
	return %this.containsEntryAtVariable(%var, %entry);
}

function compareLesser(%a, %b) {
	return %a < %b;
}

function compareStringLesser(%a, %b) {
	return stricmp(%a, %b) < 0;
}

//This is really ugly, but the only way to support engine methods that need a fixed number of arguments
function SimObject::_call(%this, %func, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9) {
	if (%arg9 !$= "")
		return %this.call(%func, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9);
	if (%arg8 !$= "")
		return %this.call(%func, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8);
	if (%arg7 !$= "")
		return %this.call(%func, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7);
	if (%arg6 !$= "")
		return %this.call(%func, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6);
	if (%arg5 !$= "")
		return %this.call(%func, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5);
	if (%arg4 !$= "")
		return %this.call(%func, %arg0, %arg1, %arg2, %arg3, %arg4);
	if (%arg3 !$= "")
		return %this.call(%func, %arg0, %arg1, %arg2, %arg3);
	if (%arg2 !$= "")
		return %this.call(%func, %arg0, %arg1, %arg2);
	if (%arg1 !$= "")
		return %this.call(%func, %arg0, %arg1);
	if (%arg0 !$= "")
		return %this.call(%func, %arg0);
	return %this.call(%func);
}

function funccall(%func, %obj, %i, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9) {
	//Member functions have a "%this." at the front
	if (strpos(%func, "%this.") == 0) {
		//Strip off the "%this."
		%func = getSubStr(%func, strlen("%this."), strlen(%func));
		//Call it
		return %obj._call(%func, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9);
	} else {
		//Normal call
		return call(%func, %obj, %i, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9);
	}
}

// Call a function on each element in a list
function Array::forEach(%this, %func, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9) {
	for (%i = 0; %i < %this.getSize(); %i ++) {
		funccall(%func, %this.getEntry(%i), %i, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9);
	}
}

// Return a new list with the result of calling a function on each element
function Array::map(%this, %func) {
	%newList = Array(MapArray);
	%newList.schedule(1000, delete); //Clean up if we don't need it
	for (%i = 0; %i < %this.getSize(); %i ++) {
		%newList.addEntry(funccall(%func, %this.getEntry(%i), %i));
	}
	return %newList;
}

// Return a new list with the entries from this list which match a given function
function Array::filter(%this, %func) {
	%newList = Array(FilterArray);
	%newList.schedule(1000, delete); //Clean up if we don't need it
	for (%i = 0; %i < %this.getSize(); %i ++) {
		if (funccall(%func, %this.getEntry(%i), %i)) {
			%newList.addEntry(%this.getEntry(%i));
		}
	}
	return %newList;
}

// Calls a function over every value in the array, but accumulated left-to-right and stored in a parameter.
function Array::reduce(%this, %func, %initial) {
	%val = %initial;
	for (%i = 0; %i < %this.getSize(); %i ++) {
		%val = call(%func, %val, %this.getEntry(%i), %i);
	}
	return %val;
}
