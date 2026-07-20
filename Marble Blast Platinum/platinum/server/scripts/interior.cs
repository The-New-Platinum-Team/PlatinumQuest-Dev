//-----------------------------------------------------------------------------
// Interior fixes and additions
// Currently only ConsDirection (thanks a ton to Seizure22)
//
// Copyright (c) 2015 The Platinum Team
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

//Seizure-level hacking
package ConsDirection {
	/**
	 * @param {InteriorInstance} %this
	 */
	function InteriorInstance::magicButton(%this) {
		Parent::magicButton(%this);
		//Modify all the created items from magic button
		%rotMatrix = "0 0 0" SPC MatrixRot(%this.getTransform());
		for (%obj = %this.getId() + 1; isObject(%obj); %obj ++) {
			if (%obj.consDirection !$= "") {
				%rotMatrix = MatrixMultiply(%rotMatrix, MatrixInverse(MatrixCreateFromEuler(%obj.consDirection)));
			}
			//Only do actual game objects
			if (%obj.getType() & $TypeMasks::GameBaseObjectType) {
				%obj.setTransform(MatrixMultiply(%obj.getTransform(), %rotMatrix));
			}
		}
	}
};

//activatePackage(ConsDirection);