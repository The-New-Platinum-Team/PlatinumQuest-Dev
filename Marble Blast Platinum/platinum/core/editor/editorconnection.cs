//-----------------------------------------------------------------------------
// editorconnection.cs
//
// Communication steps:
// 1. External program exports DIF(s) and notifies PQ.
// 2. PQ deletes the old interiors and DIFs and notifies program.
// 3. Program moves the new DIFs into the game files and notifies PQ.
// 4. PQ adds the interiors back into the mission.
//
// Copyright (c) 2025 The Platinum Team
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

function ConnectAutoDIF(%type, %port) {
  if(%type !$= "Constructor" && %type !$= "Blender") {
    error("AutoDIF: Unsupported editor type" SPC %type);
    return;
  }
  if(%type $= "Constructor" && $platform !$= "windows") {
    MessageBoxOK("Error", "This feature is only available on Windows.");
    return;
  }
  
  if(isObject(MissionGroup)) {
    if(isObject(AutoDIFConnection)) {
      AutoDIFConnection.disconnect();
      AutoDIFConnection.delete();
    }
    %con = new TCPObject(AutoDIFConnection);
    %con.connect("127.0.0.1:" @ %port);
    %con.type = %type;
    
    // Keep the connection confined to the current mission
    if(isObject(MissionCleanup))
      MissionCleanup.add(AutoDIFConnection);
  }
  else {
    error("AutoDIF: Cannot connect outside of a level");
  }
}

function DisconnectAutoDIF() {
  // Use when you want to free the objects into the mission
  if(isObject(AutoInterior_g)) {
    ProcessInteriorGroup(AutoInterior_g, false);
    while(AutoInterior_g.getCount() > 0)
      MissionGroup.add(AutoInterior_g.getObject(0));
    AutoInterior_g.delete();
  }
  if(isObject(AutoDIFConnection))
    AutoDIFConnection.delete();
}

function ProcessInteriorGroup(%group, %lock) {
  // Set lock and start MPs
  for(%i = 0; %i < %group.getCount(); %i++) {
    %obj = %group.getObject(%i);
    if(%obj.getClassName() $= "PathedInterior")
      %obj.getDatablock().schedule(50, "onMissionReset", %obj);
    if(%obj.getClassName() $= "SimGroup" || %obj.getClassName() $= "Path")
      ProcessInteriorGroup(%obj, %lock);
    else
      %obj.locked = %lock;
  }
}

function AutoDIFConnection::onConnectFailed(%this) {
  messageBoxYesNo("No connection", "This feature requires the auto_dif plugin enabled in" SPC %this.type @ ". Visit GitHub?", "gotoWebPage(\"https://github.com/KeppyMarbles/auto_dif\");");
  %this.delete();
}

function AutoDIFConnection::onDisconnect(%this) {
  messageBoxOK(%this.type SPC "Disconnected", %this.type SPC "was closed or an error occurred.");
  %this.delete();
}

function AutoDIFConnection::onConnected(%this) {
  echo("AutoDIF: Connected to" SPC %this.type @ "; requesting scene");
  %this.sendCommand("export_difs");
}

function AutoDIFConnection::onLine(%this, %line) {
  echo("AutoDIF: Recieved" SPC %this.type SPC "message:" SPC %line);
  %this.recieveCommand(%line);
}

function AutoDIFConnection::sendCommand(%this, %name, %a1, %a2, %a3) {
  %message = %name;
  for(%i = 1; %a[%i] !$= ""; %i++) {
    %message = %message @ "|" @ %a[%i];
  }
  echo("AutoDIF: Sending message:" SPC %message);
  if(%this.type $= "Constructor")
    %this.send(%message @ "\n");
  else
    %this.send(%message);
}

function AutoDIFConnection::recieveCommand(%this, %msg) {
  //%msg is in the format "methodName|arg1|arg2|arg3..."
  while(%msg !$= "") {
    %msg = nextToken(%msg, "token", "|");
    if(%func $= "")
      %func = %this @ "." @ %token @ "(";
    else {
      %func = %func @ "\"" @ %token @ "\"";
      if(%msg !$= "")
        %func = %func @ ",";
    }
  }
  eval(%func @ ");");
}

function AutoDIFConnection::notifyError(%this, %message) {
  messageBoxOK("Error", "From" SPC %this.type @ ":" SPC %message);
}

function AutoDIFConnection::allocateDIFsPart1(%this, %folderPath, %dif_name, %amt) {
  if(!isObject(MissionGroup)) {
    error("User is not in a mission");
    return;
  }
  
  // Unpause the game so messages are handled properly
  %this.pauseGame = $gamePaused;
  if(%this.pauseGame)
    $gamePaused = false;
  
  // Save the marble pos in case we fall through the interior
  %this.marbleTransform = LocalClientConnection.player.getTransform();
  
  // Clear the interior and subobjects
  echo("AutoDIF: Resetting Interior group");
  while(isObject(AutoInterior_g))
    AutoInterior_g.delete();
  MissionGroup.add(new SimGroup(AutoInterior_g));
  AutoInterior_g.type = %this.type;
  
  // Wait a frame before updating the resources
  %this.schedule(20, "allocateDIFsPart2", %folderPath, %dif_name, %amt);
}

function AutoDIFConnection::allocateDIFsPart2(%this, %folderPath, %dif_name, %amt) {
  // Delete the old difs and allocate the new ones in the filesystem
  for(%i = 0; true; %i++) {
    if(%this.type $= "Constructor") {
      if(%i == 0)
        %filePath = %folderPath @ "/" @ %dif_name @ ".dif";
      else
        %filePath = %folderPath @ "/" @ %dif_name @ "-" @ %i @ ".dif";
    }
    else {
      %filePath = %folderPath @ "/" @ %dif_name @ %i @ ".dif";
    }

    %needsCreate = (%i < %amt);
    %needsDelete = isFile(%filePath);
    
    if(!%needsCreate && !%needsDelete) {
      break;
    }
    if(%needsDelete) {
      for(%j = 0; %j < MissionGroup.getCount(); %j++) {
        %obj = MissionGroup.getObject(%j);
        if(%obj.interiorFile $= %filePath) {
          messageBoxOK("Error", %filePath SPC "is currently in use by another InteriorInstance! You'll have to delete it or rename your current project to continue a connection with" SPC %this.type @ ".");
          AutoInterior_g.delete();
          return;
        }
      }
      echo("AutoDIF: Deleting" SPC %filePath);
      deleteFile(%filePath);
    }
    if(%needsCreate) {
      echo("AutoDIF: Creating blank file" SPC %filePath);
      %touch = new FileObject();
      %touch.openForWrite(%filePath);
      %touch.close();
      %touch.delete();
      %this.newInteriors[%i] = %filePath;
    }
  }
  %this.newInteriorCount = %amt;
  
  // Actually install them
  %exe_path = $Game::argv[0];
  if(%this.type $= "Constructor")
    %exe_path = strreplace(%exe_path, "\\", "/");
  
  %this.sendCommand("install_difs", %exe_path);
}

function AutoDIFConnection::addNewInteriors(%this) {
  if(!isObject(AutoInterior_g)) {
    error("AutoDIF: Interior group was not found");
    return;
  }
  // Add in the interiors using the cached filepaths
  for(%i = 0; %i < %this.newInteriorCount; %i++) {
    %obj = new InteriorInstance() {
      interiorFile = %this.newInteriors[%i];
    };
    
    if(!isObject(%obj)) {
      MessageBoxOK("Error", "The Interior was exported but not added. It may have been exported incorrectly or into the wrong directory.");
      return;
    }
    else
      echo("AutoDIF: Added new interior" SPC %obj);
    
    AutoInterior_g.add(%obj);
    
    // The subs are in the first dif
    if(%i == 0)
      %obj.magicButton();
  }
  %this.newInteriorCount = 0;
  ProcessInteriorGroup(AutoInterior_g, true);
  
  // Put the marble back where it was in case it fell
  LocalClientConnection.player.setTransform(%this.marbleTransform);
  
  // Repause if necessary
  $gamePaused = %this.pauseGame;
}