//-----------------------------------------------------------------------------
// Shared Client/Server Scripts
//
// Copyright (c) 2014 The Platinum Team
// Copyright (c) 2014 Whirligig231
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

// gets the 2D point in the view from (-1,-1) to (1,1) corresponding to a point in 2D space
// function getGuiSpace(%pos,%iter) {
// %width = getWord(getResolution(),0);
// %height = getWord(getResolution(),1);
// %aspect = %width/%height;
// %camera = getCamTrans();
// %forward = MatrixForward(%camera);
// %diff = VectorSub(%pos,MatrixPos(%camera));
// %projOut = VectorRej(%diff,%forward);
// %projRot = MatrixMulVector(MatrixInverse(%camera),%projOut);
// %dist = VectorProjLen(%diff,%forward);
// if (%dist < 0 && !%iter) {
// //Behind you, rotate the point and do some math
// %pos = VectorAdd(%pos, VectorScale(VectorSub(%camera, %pos), 2));
// %rotated = VectorScale(getGuiSpace(%pos,true), -1);
// //Since it's behind you, we need to scale to the edge of the screen
// //Sqrt 2 will get us out of bounds, even in the corners
// %rotated = VectorScale(VectorNormalize(%rotated), mSqrt(2));
// return %rotated;
// }
// %slopeP = mTan(getFov()/2*$pi/180);
// %slopeX = getWord(%projRot,0)/%dist;
// %slopeY = getWord(%projRot,2)/%dist;
// %projX = %slopeX/%slopeP;
// %projY = %slopeY/%slopeP;
// %projY *= %aspect;
// return %projX SPC -%projY;
// }

function MatrixForward(%mat) {
	return MatrixMulVector(%mat,"0 1 0");
}

function MatrixBackward(%mat) {
	return MatrixMulVector(%mat,"0 -1 0");
}

function MatrixRight(%mat) {
	return MatrixMulVector(%mat,"1 0 0");
}

function MatrixLeft(%mat) {
	return MatrixMulVector(%mat,"-1 0 0");
}

function MatrixUp(%mat) {
	return MatrixMulVector(%mat,"0 0 1");
}

function MatrixDown(%mat) {
	return MatrixMulVector(%mat,"0 0 -1");
}

function MatrixPos(%mat) {
	return getWords(%mat,0,2);
}

function MatrixRot(%mat) {
	return getWords(%mat,3,6);
}

// rotates a transformation matrix to point a given vector towards a given point
function MatrixPoint(%mat,%pt,%vec) {
	%st = getWords(%mat,0,2);
	if (%vec $= "")
		%vec = "0 0 1";
	%next = VectorSub(%st,%pt);
	%r = VectorRot(%vec,%next);
	return %st SPC %r;
}

//function MatrixInverse(%mat) {
//   %pos = getWords(%mat,0,2);
//   %rot = getWords(%mat,3,6);
//   %newPos = VectorScale(%pos,-1);
//   %newRot = getWords(%rot,0,2) SPC -getWord(%rot,3);
//   %matA = "0 0 0" SPC %newRot;
//   %matB = %newPos SPC "1 0 0 0";
//   return MatrixMultiply(%matA,%matB);
//}

// angle between two vectors
//function VectorAngle(%u,%v) {
//   return mAcos(VectorDot(%u,%v)/VectorLen(%u)/VectorLen(%v));
//}

// rotate one vector around another
//function VectorRotate(%vec,%axis,%angle) {
//   %axis = VectorNormalize(%axis);
//   %part1 = VectorScale(%vec,mCos(%angle));
//   %part2 = VectorScale(VectorCross(%axis,%vec),mSin(%angle));
//   %part3 = VectorScale(%axis,VectorDot(%axis,%vec)*(1-mCos(%angle)));
//   return VectorAdd(VectorAdd(%part1,%part2),%part3);
//}

// cross product; if the vectors are antiparallel, still finds a vector perpendicular to both
//function VectorCrossSpecial(%u,%v) {
//   if (VectorAngle(%u,%v) >= 3.14159) {
//      if (mAbs(getWord(%u,0)) < 0.01 && mAbs(getWord(%u,1)) < 0.01) return VectorCross(%u,"1 0 0");
//      return VectorCross(%u,"0 0 1");
//   }
//   return VectorCross(%u,%v);
//}

// converts 2D coordinates from the above format into actual pixels
function getPixelSpace(%pos) {
	%width = getWord(getResolution(),0);
	%height = getWord(getResolution(),1);
	%x = (getWord(%pos,0)*0.5+0.5)*%width;
	%y = (getWord(%pos,1)*0.5+0.5)*%height;
	return %x SPC %y;
}

function VectorClampGui(%v, %inset) {
	%res = getResolution();
	%v = mClamp(getWord(%v, 0), %inset, getWord(%res, 0) - %inset) SPC mClamp(getWord(%v, 1), %inset, getWord(%res, 1) - %inset);
	return %v;
}

function VectorClamp(%v, %min, %max) {
	for (%i = 0; %i < getWordCount(%v); %i ++) {
		%v = setWord(%v, %i, mClamp(getWord(%v, %i), %min, %max));
	}
	return %v;
}

//function mClamp(%a, %min, %max) {
//    return min(max(%a, %min), %max);
//}

function MatrixAddYaw(%mat, %yaw) {
	return MatrixMultiply(%mat, "0 0 0 0 0 1" SPC %yaw);
}

// returns a four-vector rotation mapping u onto v (directionally)
//function VectorRot(%u,%v) {
//   return VectorAxis(%u,%v) SPC VectorAngle(%u,%v);
//}

// returns the axis needed to rotate from u to v
//function VectorAxis(%u,%v) {
//   return VectorNormalize(VectorCrossSpecial(%u,%v));
//}

// gets the rotation four-vector for an ortho matrix
//function RotationFromOrtho(%ortho) {
//	%rx = getWord(%ortho, 0);
//	%ry = getWord(%ortho, 1);
//	%rz = getWord(%ortho, 2);
//	%bx = getWord(%ortho, 3);
//	%by = getWord(%ortho, 4);
//	%bz = getWord(%ortho, 5);
//	%dx = getWord(%ortho, 6);
//	%dy = getWord(%ortho, 7);
//	%dz = getWord(%ortho, 8);
//	if (mSqrt(mPow(%dy-%bz,2)+mPow(%rz-%dx,2)+mPow(%bx-%ry,2)) == 0) return "1 0 0" SPC mAcos((%rx+%by+%dz-1)/2);
//	// Solve for rotation axis
//	%rotX = (%dy-%bz)/mSqrt(mPow(%dy-%bz,2)+mPow(%rz-%dx,2)+mPow(%bx-%ry,2));
//	%rotY = (%rz-%dx)/mSqrt(mPow(%dy-%bz,2)+mPow(%rz-%dx,2)+mPow(%bx-%ry,2));
//	%rotZ = (%bx-%ry)/mSqrt(mPow(%dy-%bz,2)+mPow(%rz-%dx,2)+mPow(%bx-%ry,2));
//	%rotA = mAcos((%rx+%by+%dz-1)/2);
//	return %rotX SPC %rotY SPC %rotZ SPC %rotA;
//}

// composes two rotations
function RotMultiply(%rot1,%rot2) {
	return getWords(MatrixMultiply("0 0 0" SPC %rot1,"0 0 0" SPC %rot2),3);
}

// transforms a vector by a rotation
function RotMulVector(%rot,%vec) {
	return MatrixMulVector("0 0 0" SPC %rot,%vec);
}

// rotates a rotation to point a given vector towards a given direction
function RotPoint(%rot,%dir,%vec) {
	if (%vec $= "")
		%vec = "0 0 1";
	%vecrot = VectorRot(RotMulVector(%rot,%vec),%dir);
	return RotMultiply(%vecrot,%rot);
}

// reverses a rotation
function RotInverse(%rot) {
	return getWords(%rot,0,2) SPC -getWord(%rot,3);
}

function VectorYaw(%v) {
	return mAtan(getWord(%v,1),getWord(%v,0));
}

// interpolates between two rotations
//function RotInterpolate(%rot1,%rot2,%t) {
//   %mat1 = "0 0 0" SPC %rot1;
//   %mat2 = "0 0 0" SPC %rot2;
//   %matSub = MatrixDivide(%mat2,%mat1);
//   %subAxis = getWords(%matSub,3,5);
//   %subAng = getWord(%matSub,6);
//   %newAng = %t*%subAng;
//   %newSub = "0 0 0" SPC %subAxis SPC %newAng;
//   %newMat = MatrixMultiply(%newSub,%mat1);
//   return getWords(%newMat,3);
//}

////  divides one matrix by another matrix
//function MatrixDivide(%mat1,%mat2) {
//   return MatrixMultiply(%mat1,MatrixInverse(%mat2));
//}

//function MatInterpolate(%m1, %m2, %t) {
//    %pos1 = getWords(%m1, 0, 2);
//    %pos2 = getWords(%m2, 0, 2);
//    %rot1 = getWords(%m1, 3, 6);
//    %rot2 = getWords(%m2, 3, 6);

//    return VectorLerp(%pos1, %pos2, %t) SPC RotInterpolate(%rot1, %rot2, %t);
//}


// Credit for ease() function:
//http://stackoverflow.com/questions/13462001/ease-in-and-ease-out-animation-formula
// Adapted to TorqueScript by me, don't expect any comments.
// Quadratic ease in / out
// Source: http://gizma.com/easing/
function ease(%start, %len, %total, %current) {
	%current /= %total / 2;
	if (%current < 1)
		return %len / 2 * %current * %current + %start;
	%current --;
	return -%len / 2 * (%current * (%current - 2) - 1) + %start;
}

function easeFrom(%a, %b, %progress) {
	return ease(%a, %b - %a, 1, %progress);
}

// I want interpolation, I want LERP
// this will predict the next movement of where to go based upon positions.
function vectorLerp(%a, %b, %delta) {
	return vectorAdd(%a, vectorScale(vectorSub(%b, %a), %delta));
}

function vectorEase(%a, %b, %delta) {
	return ease(getWord(%a, 0), getWord(%b, 0) - getWord(%a, 0), 1, %delta) SPC
	       ease(getWord(%a, 1), getWord(%b, 1) - getWord(%a, 1), 1, %delta) SPC
	       ease(getWord(%a, 2), getWord(%b, 2) - getWord(%a, 2), 1, %delta);
}

//-----------------------------------------------------------------------------
// Bezier curves and shit
// Grats to http://www.cs.mtu.edu/~shene/COURSES/cs3621/NOTES/spline/Bezier/bezier-der.html
//-----------------------------------------------------------------------------

//Turn {p0, p1, ... pn} into {p0 TAB p1 TAB ... pn}
function _makeList(%p0, %p1, %p2, %p3, %p4, %p5, %p6, %p7, %p8, %p9) {
	%plist = %p0;
	if (%p1 !$= "") %plist = %plist TAB %p1;
	if (%p2 !$= "") %plist = %plist TAB %p2;
	if (%p3 !$= "") %plist = %plist TAB %p3;
	if (%p4 !$= "") %plist = %plist TAB %p4;
	if (%p5 !$= "") %plist = %plist TAB %p5;
	if (%p6 !$= "") %plist = %plist TAB %p6;
	if (%p7 !$= "") %plist = %plist TAB %p7;
	if (%p8 !$= "") %plist = %plist TAB %p8;
	if (%p9 !$= "") %plist = %plist TAB %p9;
	return %plist;
}

//Factorial of n
//function mFact(%n) {
//    %a = 1;
//    for (%i = %n; %i > 0; %i --) {
//        if (%n < 11)
//            %a *= %i;
//        else //Hooray for math64
//            %a = mult64_int(%a, %i);
//    }
//    return %a;
//}

//Bezier curve coefficients for a curve:
// With order n
// For point i
// At distance on the curve u
//function mBez(%n, %i, %u) {
//	//              n!
//	//B_n,i(u) = --------  u^i (1-u)^(n-i)
//	//           i!(n-i)!

//	return (mFact(%n) / (mFact(%i) * (mFact(%n - %i)))) * mPow(%u, %i) * mPow((1 - %u), (%n - %i));
//}

//Bezier curve between points:
// With points p0, p1, ... pn (up to 9 currently)
// At distance on the curve u
//function VectorBezier(%u, %p0, %p1, %p2, %p3, %p4, %p5, %p6, %p7, %p8, %p9) {
//	%plist = _makeList(%p0, %p1, %p2, %p3, %p4, %p5, %p6, %p7, %p8, %p9);

//	//n - The curve's order - one less than the number of control points
//	%n = getFieldCount(%plist) - 1;

//	%ret = "0 0 0";
//	for (%i = 0; %i <= %n; %i ++) {
//		//P_i - The control point at i
//		%p_i = getField(%plist, %i);

//		//         n
//		// C(u) =  E  B_n,i(u)*P_i
//		//        i=0
//		%ret = VectorAdd(%ret, VectorScale(%p_i, mBez(%n, %i, %u)));
//	}

//	return %ret;
//}

//function VectorBezierDeriv(%u, %p0, %p1, %p2, %p3, %p4, %p5, %p6, %p7, %p8, %p9) {
//	%plist = _makeList(%p0, %p1, %p2, %p3, %p4, %p5, %p6, %p7, %p8, %p9);

//	//n - The curve's order - one less than the number of control points
//	%n = getFieldCount(%plist) - 1;

//	%ret = "0 0 0";

//	//From 0 -> n - 1
//	for (%i = 0; %i < %n; %i ++) {
//		//P_i - The control point at i
//		%p_i = getField(%plist, %i);

//		//P_i+1 - Point at i+1
//		%p_i1 = getField(%plist, %i + 1);

//		//Q_i = n(P_i+1 - P_i)
//		%q_i = VectorScale(VectorSub(%p_i1, %p_i), %n);

//		//       n-1
//		//C'(u) = E  B_n-1,i(u) * Q_i
//		//       i=0
//		%ret = VectorAdd(%ret, VectorScale(%q_i, mBez(%n - 1, %i, %u)));
//	}
//	return %ret;
//}

//-----------------------------------------------------------------------------

//function RotBezier(%t, %p0, %p1, %p2, %p3, %p4, %p5, %p6, %p7, %p8, %p9) {
//	//https://en.wikipedia.org/wiki/Bezier_curve
//	%plist = _makeList(%p0, %p1, %p2, %p3, %p4, %p5, %p6, %p7, %p8, %p9);

//	%ret = _RotBezier(%t, %plist);
////	devecho("RotBezier:" SPC %t SPC %plist SPC %ret);
//	return %ret;
//}

//function _RotBezier(%t, %plist) {
//	%order = getFieldCount(%plist);
//	if (%order == 1)
//		return getField(%plist, 0);
//	%b0 = _RotBezier(%t, getFields(%plist, 0, %order - 2));
//	%b1 = _RotBezier(%t, getFields(%plist, 1, %order - 1));
//	return RotInterpolate(%b0, %b1, %t);
//}

//-----------------------------------------------------------------------------

//Evaluates f for x
function mFunc(%f, %x) {
	return eval("return" SPC %f @ ";");
}

//Derivative of f at x
function mDeriv(%f, %x) {
	return (mFunc(%f, %x + 0.001) - mFunc(%f, %x - 0.001)) / 0.002;
}

//Integral of f over [a, b]
function mInteg(%f, %a, %b) {
	%area = 0;

	%slices = 10;
	%h = (%b - %a) / %slices;
	for (%i = 0; %i < %slices; %i ++) {
		%a1 = %a + (%i * %h);
		%b1 = %a + ((%i + 1) * %h);
		%area += (%h / 6) * (mFunc(%f, %a1) + (4 * mFunc(%f, (%a1 + %b1) / 2)) + mFunc(%f, %b1));
	}

	return %area;
}

//Length of curve f over [a, b]
function mLength(%f, %a, %b) {
	//l = integ(sqrt(1 + (dy / dx)^2) dx)
	return mInteg("mSqrt(1 + mPow(mDeriv(\"" @ %f @ "\", %x), 2))", %a, %b);
}

//-----------------------------------------------------------------------------

function orthoCompare(%o1, %o2) {
	for (%i = 0; %i < 9; %i ++) {
		if (mAbs(getWord(%o1, %i) - getWord(%o2, %i)) > 0.00001) {
			return false;
		}
	}
	return true;
}

function VectorEqual(%o1, %o2) {
	if (getWordCount(%o1) != getWordCount(%o2)) {
		return false;
	}
	%count = getWordCount(%o1);
	for (%i = 0; %i < %count; %i ++) {
		if (mAbs(getWord(%o1, %i) - getWord(%o2, %i)) > 0.00001) {
			return false;
		}
	}
	return true;
}

//-----------------------------------------------------------------------------
// Removes scientific notation from numbers and leaves them as strings
// Warning: lossy
//-----------------------------------------------------------------------------

//function removeScientificNotation(%number) {
//    //Not sci-non
//    if (strPos(%number, "e") == -1)
//        return %number;

//    //Find the number after the "e"
//    %power = stripChars(getSubStr(%number, strPos(%number, "e") + 1, strLen(%number)), "+");

//    //Strip off the power
//    %number = getSubStr(%number, 0, strPos(%number, "e"));

////	echo("Taking" SPC %number SPC "by 10^" @ %power);

//    //Strip the decimal
//    %number = stripChars(%number, ".");

//    //Now add zeroes
//    if (%power > 0) {
//        //xxxx000
//        %places = strLen(%number);
//        while (%places < (%power + 1)) {
//            %number = %number @ "0";
//            %places ++;
//        }
//    } else {
//        //0.0000xxxx
//        %places = 0;
//        while (%places < -(%power + 1)) {
//            %number = "0" @ %number;
//            %places ++;
//        }
//        %number = "0." @ %number;
//    }

//    return %number;
//}

function VectorUnnotate(%vector) {
	for (%i = 0; %i < getWordCount(%vector); %i ++) {
		%vector = setWord(%vector, %i, removeScientificNotation(getWord(%vector, %i)));
	}
	return %vector;
}

function VectorRemoveNotation(%vector) {
	for (%i = 0; %i < getWordCount(%vector); %i ++) {
		%word = getWord(%vector, %i);
		if (strPos(%word, "e-0") != -1) {
			%vector = setWord(%vector, %i, "0");
		}
	}
	return %vector;
}

function VectorNanCheck(%vector, %default) {
	for (%i = 0; %i < getWordCount(%vector); %i ++) {
		%word = getWord(%vector, %i);

		//Can't save it
		if (strPos(%word, "nan") != -1 || strPos(%word, "inf") != -1) {
			return %default;
		}
	}
	return %vector;
}

function nanCheck(%n, %default) {
	if (strPos(%n, "nan") != -1 || strPos(%n, "inf") != -1)
		return %default;
	return %n;
}

function sanityCheck(%n, %default) {
	if (strPos(%n, "nan") != -1 || strPos(%n, "inf") != -1 || %n < 1)
		return %default;
	return %n;
}
