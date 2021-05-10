from os import path
import pathlib;
import os;
import hashlib;

# put your PQ directory here
PQDir = pathlib.Path("");

# how querySHA works
# return 1 TAB <file> if error
# return 0 TAB crcGood if we good

scriptfiles = PQDir.rglob("*.dso");
scripthashes = [];
for dsofile in scriptfiles:
    pathstr = str(dsofile)
    if "pref" not in pathstr.lower() and "config" not in pathstr.lower(): # ignore hashing prefs
        relpath = dsofile.relative_to(PQDir);
        sha = hashlib.sha256()
        with open(pathstr, "rb") as f:
            sha.update(f.read())
        hash = sha.hexdigest()
        scripthashes.append((str(relpath), hash))

shapefiles = PQDir.rglob("*.dts");
shapehashes = [];
for dsofile in shapefiles:
    pathstr = str(dsofile)
    relpath = dsofile.relative_to(PQDir);
    sha = hashlib.sha256()
    with open(pathstr, "rb") as f:
        sha.update(f.read())
    hash = sha.hexdigest()
    shapehashes.append((str(relpath), hash))

def generateCheck(flist):
    retlist = [];
    for file, hash in flist:
        file = file.replace('\\','/')
        retlist.append(f"   if (getFileSHA256(\"{file}\") !$= \"{hash}\") return \"{file}\";");
    return "\n".join(retlist)

generatedcs = f"""
function querySHA()
{{
    %letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.[],()!$&^#@+=-_;";
    LBMessage("Loading PlatinumQuest Online (1 of 3)");
    Canvas.repaint();
    %filestuff = shaScripts();
    if (%filestuff !$= "good") return 1 TAB %filestuff;
    LBMessage("Loading PlatinumQuest Online (2 of 3)");
    Canvas.repaint();
    %filestuff = shaShapes();
    if (%filestuff !$= "good") return 1 TAB %filestuff;
    LBMessage("Loading PlatinumQuest Online (3 of 3)");
    Canvas.repaint();
    return 0 TAB "crcGood";
}}
function shaScripts()
{{
{ generateCheck(scripthashes) }
    return "good";
}}
function shaShapes()
{{
{ generateCheck(shapehashes) }
    return "good";
}}
"""

with open("redundancycheck.cs", "w") as f:
    print(generatedcs, file=f)