//-----------------------------------------------------------------------------
// blenderconnection.cs
//
// Basic idea:
// 1. Have Blender export DIF on save. Notify PQ.
// 2. Have PQ delete the related interiors and files. Notify Blender.
// 3. Have Blender move the new DIFs into the game files. Notify PQ.
// 4. Have PQ add the interiors back into the mission.
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

$BlenderPort = 7654;

function ConnectBlender() {
  if(isObject(MissionGroup)) {
    if(isObject(BlenderConnection)) {
      BlenderConnection.disconnect();
      BlenderConnection.delete();
    }
    %obj = new TCPObject(BlenderConnection);
    %obj.connect("127.0.0.1:" @ $BlenderPort);
    
    // Keep the connection confined to the current mission
    if(isObject(MissionCleanup))
      MissionCleanup.add(BlenderConnection);
  }
  else {
    error("Cannot connect with Blender outside of a level");
  }
}

function DisconnectBlender() {
  // Use when you want to free the objects into the mission
  if(isObject(BlenderInterior_g)) {
    ProcessBlenderGroup(BlenderInterior_g, false);
    while(BlenderInterior_g.getCount() > 0)
      MissionGroup.add(BlenderInterior_g.getObject(0));
    BlenderInterior_g.delete();
  }
  if(isObject(BlenderConnection))
    BlenderConnection.delete();
}

function ProcessBlenderGroup(%group, %lock) {
  // Set lock and start MPs
  for(%i = 0; %i < %group.getCount(); %i++) {
    %obj = %group.getObject(%i);
    if(%obj.getClassName() $= "PathedInterior")
      %obj.getDatablock().schedule(50, "onMissionReset", %obj);
    if(%obj.getClassName() $= "SimGroup" || %obj.getClassName() $= "Path")
      ProcessBlenderGroup(%obj, %lock);
    else
      %obj.locked = %lock;
  }
}

function BlenderConnection::onConnectFailed(%this) {
  messageBoxYesNo("No connection", "This feature requires the auto_dif plugin enabled in Blender. Visit GitHub?", "gotoWebPage(\"https://github.com/KeppyMarbles/auto_dif\");");
  %this.delete();
}

function BlenderConnection::onDisconnect(%this) {
  messageBoxOK("Blender Disconnected", "Blender was closed or an error occurred.");
  %this.delete();
}

function BlenderConnection::onConnected(%this) {
  echo("Connected to Blender; requesting scene");
  %this.sendCommand("export_difs");
}

function BlenderConnection::onLine(%this, %line) {
  echo("Recieved Blender message:" SPC %line);
  %this.recieveCommand(%line);
}

function BlenderConnection::sendCommand(%this, %name, %a1, %a2, %a3) {
  %message = %name;
  for(%i = 1; %a[%i] !$= ""; %i++) {
    %message = %message @ "|" @ %a[%i];
  }
  echo("Sending message:" SPC %message);
  %this.send(%message);
}

function BlenderConnection::recieveCommand(%this, %msg) {
  //%msg is in the format "methodName|arg1|arg2|arg3..."
  while(%msg !$= "") {
    %msg = nextToken(%msg, "token", "|");
    if(%func $= "") {
      %func = %this @ ".call(\"" @ %token @ "\"";
    }
    else {
      %func = %func @ "," SPC "\"" @ %token @ "\"";
    }
  }
  eval(%func @ ");");
}

function BlenderConnection::allocateDIFsPart1(%this, %folderPath, %dif_name, %amt) {
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
  echo("Resetting Blender group");
  while(isObject(BlenderInterior_g))
    BlenderInterior_g.delete();
  MissionGroup.add(new SimGroup(BlenderInterior_g));
  
  // Wait a frame before updating the resources
  %this.schedule(20, "allocateDIFsPart2", %folderPath, %dif_name, %amt);
}

function BlenderConnection::allocateDIFsPart2(%this, %folderPath, %dif_name, %amt) {
  // Delete the old difs and allocate the new ones in the filesystem
  for(%i = 0; true; %i++) {
    %filePath = %folderPath @ "/" @ %dif_name @ %i @ ".dif";
    %needsCreate = (%i < %amt);
    %needsDelete = isFile(%filePath);
    
    if(!%needsCreate && !%needsDelete) {
      break;
    }
    if(%needsDelete) {
      for(%j = 0; %j < MissionGroup.getCount(); %j++) {
        %obj = MissionGroup.getObject(%j);
        if(%obj.interiorFile $= %filePath) {
          messageBoxOK("Error", %filePath SPC "is currently in use by another InteriorInstance! You'll have to delete it or rename your current project to continue a connection with Blender.");
          return;
        }
      }
      echo("Deleting" SPC %filePath);
      deleteFile(%filePath);
    }
    if(%needsCreate) {
      echo("Creating blank file" SPC %filePath);
      %touch = new FileObject();
      %touch.openForWrite(%filePath);
      %touch.close();
      %touch.delete();
      %this.newInteriors[%i] = %filePath;
    }
  }
  %this.newInteriorCount = %amt;
  
  // Actually install them
  %this.sendCommand("install_difs", $Game::argv[0]);
}

function BlenderConnection::addNewInteriors(%this) {
  if(!isObject(BlenderInterior_g)) {
    error("Blender interior group was not found");
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
      echo("Added new interior" SPC %obj);
    
    BlenderInterior_g.add(%obj);
    
    // The subs are in the first dif
    if(%i == 0)
      %obj.magicButton();
  }
  %this.newInteriorCount = 0;
  ProcessBlenderGroup(BlenderInterior_g, true);
  
  // Put the marble back where it was in case it fell
  LocalClientConnection.player.setTransform(%this.marbleTransform);
  
  // Repause if necessary
  $gamePaused = %this.pauseGame;
}

function BlenderConnection::notifyError(%this, %message) {
  messageBoxOK("Error", "From Blender:" SPC %message);
}