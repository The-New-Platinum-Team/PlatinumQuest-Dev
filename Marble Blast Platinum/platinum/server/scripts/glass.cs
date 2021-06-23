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

if ($pref::UseLowResGlass) {
	datablock StaticShapeData(glass_3shape) {
		shapeFile = "~/data/shapes/Glass/3x3.dts";
	};

	datablock StaticShapeData(glass_6shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/6x3.dts";
	};

	datablock StaticShapeData(glass_9shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/9x3.dts";
	};

	datablock StaticShapeData(glass_12shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/12x3.dts";
	};

	datablock StaticShapeData(glass_15shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/15x3.dts";
	};

	datablock StaticShapeData(glass_18shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/18x3.dts";
	};
} else {
	datablock StaticShapeData(glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/3x3.dts";
	};

	datablock StaticShapeData(glass_6shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/6x3.dts";
	};

	datablock StaticShapeData(glass_9shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/9x3.dts";
	};

	datablock StaticShapeData(glass_12shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/12x3.dts";
	};

	datablock StaticShapeData(glass_15shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/15x3.dts";
	};

	datablock StaticShapeData(glass_18shape: glass_3shape) {
		shapeFile = "~/data/shapes/Glass/Col/18x3.dts";
	};
}