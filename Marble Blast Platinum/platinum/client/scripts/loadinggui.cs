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

//------------------------------------------------------------------------------
function LoadingGui::onAdd(%this) {
	%this.qLineCount = 0;
}

//------------------------------------------------------------------------------
function LoadingGui::onWake(%this) {
	$Game::Loading = true;
	if (isObject($Menu::Queue)) {
		%qtext = "<just:center>" @ shrinkToFit($Menu::Queue.getQueueName(), $DefaultFont["Bold"], 36, 24, 560) @ "<font:28><lmargin:70><rmargin:630>";

		%qtext = "<shadow:1:1><shadowcolor:000000bf><font:32><tab:460,550>";
		%qtext = %qtext @ "Level\tScore\tTotal<font:22>";

		// Show missions 1, (n-3) -> n if we're on n
		%firstVisible = $Menu::QueueIndex - 2;
		if (%firstVisible < 0)
			%firstVisible = 0;
		%lastVisible = min(%firstVisible + 4, $Menu::Queue.getMissionCount());
		if (%lastVisible == $Menu::Queue.getMissionCount()) {
			%firstVisible = max(0, %lastVisible - 5);
		}

		for (%i = %firstVisible; %i < %lastVisible; %i ++) {
			%mis = $Menu::Queue.getMissionInfo(%i);
			if (%i == $Menu::QueueIndex) {
				%qtext = %qtext @ "<color:00cc00>";
			}
			if (%i > $Menu::QueueIndex && $Menu::Queue.isUpcomingHidden()) {
				%name = (%i + 1) @ ". ???";
			} else {
				%name = clipPx($DefaultFont, 22, (%i + 1) @ ". " @ %mis.name, 460, true);
			}
			%qtext = %qtext @ "\n" @ %name @ "\t";

			if ($Menu::Queue.missionCompleted[%i] || %i >= $Menu::QueueIndex) {
				%scoreInfo = $Menu::Queue.missionScore[%i];
				%type = getField(%scoreInfo, 0);
				%score = getField(%scoreInfo, 1);

				if (%type $= $ScoreType::Time) {
					%qtext = %qtext @ formatTime(%score) @ "\t";
				} else {
					%qtext = %qtext @ formatScore(%score) @ "\t";
				}
			} else {
				%qtext = %qtext @ "<skipped>\t";
			}
			%qtext = %qtext @ formatTime($Menu::Queue.missionTotalTimeScore[%i]);
			if ($Menu::Queue.missionTotalScoreScore[%i] > 0) {
				%qtext = %qtext @ " + " @ formatScore($Menu::Queue.missionTotalScoreScore[%i]);
			}
			%qtext = %qtext @ "<color:000000>";
		}

		if (%lastVisible != $Menu::Queue.getMissionCount()) {
			if ($Menu::Queue.isUpcomingHidden()) {
				%name = "???";
			} else {
				%name = $Menu::Queue.getMissionInfo($Menu::Queue.getMissionCount() - 1).name;
			}
			%qtext = %qtext @ "\n" @ clipPx($DefaultFont, 22, $Menu::Queue.getMissionCount() @ ". " @ %name, 460, true);
			%qtext = %qtext @ "\t\t" @ formatTime(0);
		}
		%qtext = %qtext @ "\n" @ "Total:\t\t" @ formatTime($Menu::Queue.totalTimeScore);
		if ($Menu::Queue.totalScoreScore > 0) {
			%qtext = %qtext @ " + " @ formatScore($Menu::Queue.totalScoreScore);
		}
		%qtext = %qtext @ "\n" @ "Real Time:\t\t" @ formatTime($Menu::Queue.totalRealTime);

		LoadingMessage.setText(%qtext);
	} else if (isObject($Client::NextMission)) {
		%info = $Client::NextMission;
		%name = %info.name;
		%text = "<bold:36><just:center>" @ %name @ "<font:28><lmargin:70><rmargin:630>";

		%showAwesome = ((Unlock::getMissionCompletion(%info) & $Completion::Awesome) == $Completion::Awesome) || $Unlock::DisplayAll;

		//Challenge times
		%parTimeLabel      = (%info.time         ? formatTime(%info.time)         : "N/A");
		%goldTimeLabel     = (%info.goldTime     ? formatTime(%info.goldTime)     : "N/A");
		%platinumTimeLabel = (%info.platinumTime ? formatTime(%info.platinumTime) : "N/A");
		%ultimateTimeLabel = (%info.ultimateTime ? formatTime(%info.ultimateTime) : "N/A");
		%awesomeTimeLabel  = (%info.awesomeTime  ? formatTime(%info.awesomeTime)  : "N/A");
		//Challenge scores
		%parScoreLabel      = (%info.score         !$= "" ? formatScore(%info.score)         : "N/A");
		%goldScoreLabel     = (%info.goldScore     !$= "" ? formatScore(%info.goldScore)     : "N/A");
		%platinumScoreLabel = (%info.platinumScore !$= "" ? formatScore(%info.platinumScore) : "N/A");
		%ultimateScoreLabel = (%info.ultimateScore !$= "" ? formatScore(%info.ultimateScore) : "N/A");
		%awesomeScoreLabel  = (%info.awesomeScore  !$= "" ? formatScore(%info.awesomeScore)  : "N/A");

		if (mp()) {
			//See if we have more than one other player
			%vs = !$Server::Hosting //Not host, so there must be someone else who is
				|| (!$Server::_Dedicated && ClientGroup.getCount() > 1) //Hosting local, another player
				|| ($Server::_Dedicated && isObject(ScoreList.player[1])); //Hosting dedicated, hack but should work

			%index = (%vs ? 0 : 1);

			//The MP indexed scores override any previously set scores. But don't override
			// unless we actually have one.
			%parScoreLabel      = (%info.score[%index]         !$= "" ? formatScore(%info.score[%index])         : %parScoreLabel);
			%platinumScoreLabel = (%info.platinumScore[%index] !$= "" ? formatScore(%info.platinumScore[%index]) : %platinumScoreLabel);
			%ultimateScoreLabel = (%info.ultimateScore[%index] !$= "" ? formatScore(%info.ultimateScore[%index]) : %ultimateScoreLabel);
			%awesomeScoreLabel  = (%info.awesomeScore[%index]  !$= "" ? formatScore(%info.awesomeScore[%index])  : %awesomeScoreLabel);
		} else if (%info.platinumScore[1] !$= "") { // Transfer the [1] score to singleplayer
			%platinumScoreLabel = %info.platinumScore[1];
			%ultimateScoreLabel = %info.ultimateScore[1];
			%awesomeScoreLabel = %info.awesomeScore[1];
		} else if (%info.goldScore[1] !$= "") { // GOLD SCORE????
			%goldScoreLabel     = %info.goldScore[1];
		}
		//Use score if a time isn't available
		%parLabel      = (%parScoreLabel     $= "N/A" ? %parTimeLabel       : %parScoreLabel);
		%goldLabel     = (%goldTimeLabel     $= "N/A" ? %goldScoreLabel     : %goldTimeLabel);
		%platinumLabel = (%platinumTimeLabel $= "N/A" ? %platinumScoreLabel : %platinumTimeLabel);
		%ultimateLabel = (%ultimateTimeLabel $= "N/A" ? %ultimateScoreLabel : %ultimateTimeLabel);
		%awesomeLabel  = (%awesomeTimeLabel  $= "N/A" ? %awesomeScoreLabel  : %awesomeTimeLabel);
		%parType      = (%parScoreLabel     $= "N/A" ? "Time" : "Score");
		%goldType     = (%goldTimeLabel     $= "N/A" ? "Score" : "Time");
		%platinumType = (%platinumTimeLabel $= "N/A" ? "Score" : "Time");
		%ultimateType = (%ultimateTimeLabel $= "N/A" ? "Score" : "Time");
		%awesomeType  = (%awesomeTimeLabel  $= "N/A" ? "Score" : "Time");

		//Figure out what times/scores it needs
		%defined = "Gold Platinum Ultra PlatinumQuest LBCustom";
		%game = ((findWord(%defined, $CurrentGame) == -1) ? resolveMissionModification(%info) : $CurrentGame);
		switch$ (%game) {
		case "Gold":
			//Need qualify and gold times
			%parTitle = "Qualify";
			%goldTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFFF00>Gold";
			%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum"; // For hunt maps, just in case
			%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate"; // For hunt maps, just in case
			%awesomeTitle = "";
		case "Platinum":
			//Need par / platinum / ultimate
			%parTitle = "Par";
			%goldTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum";
			%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum"; // For hunt maps, just in case
			%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";
			%awesomeTitle = "";
		case "Ultra":
			//Need par / gold / ultimate
			%parTitle = "Par";
			%goldTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFFF00>Gold";
			%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum"; // For hunt maps, just in case
			%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";
			%awesomeTitle = "";
		case "PlatinumQuest":
			//Need par / platinum / ultimate / (awesome?)
			%parTitle = "Par";
			%goldTitle = "";
			%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum";
			%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";
			%awesomeTitle = "<shadow:1:1><shadowcolor:0000007f><color:FF4444>Awesome";
		case "LBCustom":
			//Not really sure with these, just assume platinum
			%parTitle = "Par";
			%goldTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum";
			%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum"; // For hunt maps, just in case
			%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";
			%awesomeTitle = "<shadow:1:1><shadowcolor:0000007f><color:FF4444>Awesome";
		default:
			//It's custom, we're not really sure here
			%parTitle = "Par";
			%goldTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFFF00>Gold";
			%platinumTitle = "<shadow:1:1><shadowcolor:0000007f><color:CCCCCC>Platinum";
			%ultimateTitle = "<shadow:1:1><shadowcolor:0000007f><color:FFCC33>Ultimate";
			%awesomeTitle = "<shadow:1:1><shadowcolor:0000007f><color:FF4444>Awesome";
		}

		%parText      = %parTitle      SPC %parType;
		%goldText     = %goldTitle     SPC %goldType;
		%platinumText = %platinumTitle SPC %platinumType;
		%ultimateText = %ultimateTitle SPC %ultimateType;
		%awesomeText  = %awesomeTitle  SPC %awesomeType;

		//Not a par time, a duration
		if (ClientMode::callbackForMission(%info, "timeMultiplier", 1) < 0) {
			%parText = "Duration";
		}

		//Par can have both time and score
		if (%parTimeLabel !$= "N/A") {
			%text = %text NL "<just:left><spush>" @ %parText @ ":<spop><just:right>" @ %parTimeLabel;
		}
		if (%parScoreLabel !$= "N/A") {
			%text = %text NL "<just:left><spush>" @ %parTitle SPC "Score:<spop><just:right>" @ %parScoreLabel;
		}

		//Show what we need to
		if (%goldTitle     !$= "" && %goldLabel     !$= "N/A") %text = %text NL "<just:left><spush>" @ %goldText @ ":<spop><just:right>" @ %goldLabel;
		if (%platinumTitle !$= "" && %platinumLabel !$= "N/A") %text = %text NL "<just:left><spush>" @ %platinumText @ ":<spop><just:right>" @ %platinumLabel;
		if (%ultimateTitle !$= "" && %ultimateLabel !$= "N/A") %text = %text NL "<just:left><spush>" @ %ultimateText @ ":<spop><just:right>" @ %ultimateLabel;

		if (%showAwesome) {
			if (%awesomeTitle !$= "" && %awesomeLabel !$= "N/A") %text = %text NL "<just:left><spush>" @ %awesomeText @ ":<spop><just:right>" @ %awesomeLabel;
		}

		%text = %text NL "";

		//Game modes display
		%modes = resolveMissionGameModes(%info, %info.gameMode);
		%modes = formatGameModes(%modes);
		for (%i = 0; %i < getWordCount(%modes); %i ++) {
			%mode = getWord(%modes, %i);
			%minfo = getModeInfo(%mode);
			%text = %text NL "<bold:22><just:left>" @ %minfo.name @ ": <font:22>" @ %minfo.desc;
		}

		LoadingMessage.setText(%text);
	} else {
		LoadingMessage.setText("<bold:28>" @ %this.getTip());
	}

	LoadingMessage.forceReflow();

	LoadingBody.setExtent(1038 SPC (mClamp(getWord(LoadingMessage.extent, 1), 230, 630) + 195));

	LoadingProgressMessage.setText("");
	LoadingProgressBar.setVisible(false);
}

function LoadingGui::setProgress(%this, %message, %amount, %total, %repaint) {
	if (%this.isAwake()) {
		LoadingProgressBar.setVisible(true);
		LoadingProgressBar.setWidth(838 * %amount / %total);
		LoadingProgressMessage.setText("<bold:28>" @ %message @ "<just:right>" @ mRound(%amount / %total * 100) @ "%");
		if (%repaint) {
			Canvas.repaint();
		}
	}
}

//------------------------------------------------------------------------------
function LoadingGui::onSleep(%this) {
	$Game::Loading = false;
}

// if we click cancel in LoadingGui
function LoadingGui::cancel(%this) {
	if ($Server::ServerType $= "SinglePlayer") {
		exitGame();
	} else {
		lobbyReturn();
	}
	cancel($LoadStage2);
}

$Loading::Tips[0] = -1;
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If you're using a Controller, you can configure its layout in the Options menu!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: When you play Online, beating every Gold or Platinum time in every official level in all four games will earn you a colored username!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Always have a Powerup on you in Multiplayer Gem Hunt games!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Practice using diagonal movement! You'll need to use it at times in the Advanced and Expert levels.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Unlock levels in the Bonus category by completing levels, challenges, and achievements.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If the game crashes, send us your game's console.log, crash.log (if available) and a bug report before restarting it so we can pinpoint the crash and fix it.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Watch out for white flames shooting from the ground. They signal PhysMod triggers, which affect how your marble controls!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If you're stuck on a difficult level, most of the time you can skip to the next one.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If you're stuck on a difficult level, try practising on some of the easier ones until you're able to complete it.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Use the Hints button at the bottom of the screen on the level select to check out tips and trivia about the current level. Beating challenge times will unlock further hints!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Nest Eggs are hidden around in several levels -- and they're not easy to find. Collecting them can unlock new Bonus levels!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Your spin in the air affects how the marble will bounce when it lands. Don't bounce off of the platform you're trying to land on!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The longer you wait to Super Jump after jumping first, the lower you'll fly.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Restarting until you have several high-point value Gem spawns in Gem Hunt mode can go a long way towards the Ultimate Score.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The Gyrocopter is a versatile Powerup. Combine it with different powerups to achieve a low-gravity version of them.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The Mega Marble Powerup can wreck havoc against your opponents, while the Blast Powerup will throw them away from you. Your Blast becomes more powerful when you're Mega!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Use the Fireball to destroy ice shards by rolling into them, or use its blast power to get height while destroying some ice shards in the process.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Nest Eggs in PlatinumQuest are generally much more difficult to find and collect over their Easter Egg counterparts in Platinum and Ultra.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: You can use a Super Speed to slow down, too. Just activate it while facing away from where you're going!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: In PlatinumQuest, respawning on a Checkpoint will cancel a currently-active Time Travel's effects.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If you're new, the recommended order to play the games is: Gold, Ultra, PlatinumQuest and Platinum.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Watching others play may give you tips on how to solve certain challenges.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: All but Orange-banded cannons allow you to aim them and fire at will, at varying power levels. Orange-banded cannons fire the marble instantly in the direction it's facing.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The Fireball Powerup fizzles out when you touch water or collect a Bubble Powerup. Likewise, the Bubble Powerup pops away when you pick up a Fireball Powerup.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The Bubble Powerup stays with you at all times until it is used up or you pick up a Fireball Powerup.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The Sundial Item acts the same way as the Time Travel, it's just a bit fancier.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: PlatinumQuest Time Travel Items have identifiable bands; gold bands freeze the clock and red bands add time.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: In Multiplayer, if you activate a Mega Marble and hit an Ice Shard, your marble will shrink but remain unfrozen.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: By activating a Mega Marble Powerup right before hitting a high-friction floor, you can get a crazy speed boost.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Easter Eggs and Nest Eggs in custom Online levels net you an additional 12,500 rating points per egg.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Official and Bonus PlatinumQuest levels give you 25,000 rating points on every Nest Egg you catch.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If you collect all the gems in a Gem Madness level before the time limit runs out, you will be scored based on how much time remains on the clock.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Buttons do useful things, such as activate moving platforms. It's possible to use them in elaborate puzzles...";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: You can start the level at near full speed by rolling and jumping during the Ready-Set-Go sequence. Time a jump so you hit the start pad on 'Go!' for the best result.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Moving diagonally is faster than moving straight forward. Jumping repeatedly while moving will further increase the marble's speed.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The Marble Blast Forums have an 'Advanced Techniques' thread which lists out every technique known in this game, and how it works.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Head over to the MarbleBlast.com Website to download more mods for Marble Blast, check out the latest community levels, compete in tournaments and more!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: You can add your own custom marbles by adding textures to the data/custom_marbles directory.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Completing Online achievements awards you additional rating points, which helps you move up the general rankings.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Frightfest and Winterfest are seasonal events that take the game's Multiplayer levels and spice them up for Halloween, or for the holidays!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The current Radar mode can be changed with <func:bind radarSwitch>. Test out all the different modes!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Help Bubbles contain useful messages that appear on the bottom of the screen. These messages often give hints on how to beat an upcoming challenge.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Radar is available by default in PlatinumQuest, Ultra and Multiplayer levels.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Hints are available in PlatinumQuest and Custom levels.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Online, completing a Quota level with all gems collected will award you an additional bonus in general rating points.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Gem point values for Hunt and Gem Madness: Red = 1 point, Yellow = 2 points, Blue = 5 points, Platinum = 10 points.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The level editor has many handy functions, including rounding nearest scale unit, dropping items to the ground and even selecting skins for some shapes!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The level editor contains a handy particle editor. If you can figure it out you can create some really cool effects, just watch out for the lag.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The level editor allows you to edit the mission info in-game instead of in a text editor.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Press Ctrl + Alt + Select on an object's face you want to scale or position. It will become blue-shaded and you can then move it";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Enabling the Descriptive Inspector Field Names option will list object properties in a user-friendly manner. Otherwise it shows these as they are known by the game's code.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The level editor, under World Editor Settings, has a Snap to Grid feature. You can then move items on the selected grid size, which really helps moving things around!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The level editor, under World Editor Settings, allows you to create default Gem types: Marble Blast Gold Gems, PlatinumQuest standard or fancy Gems.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Saved a level in the editor? Under File, click the Reload Current Mission button to instantly reload the mission and see your saved changes.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: In the level editor, pressing Alt + F with an object selected will cause the camera to focus on that object. Extremely helpful!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Make sure to play all Tutorial and Beginner levels, as they teach you all the basics you need to know for PlatinumQuest.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The default port for Multiplayer is 28000, but you can use any port you want, as long as you open it through your firewall or router.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Ice Shards can be used to instantly stop you if you're going too fast.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Jumping on surfaces made of ice or space can give you more control.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Grass, Sand and Water friction floors reduce the marble's bounce height, making for a perfect landing place.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Sending us a bug report is the best way to get it fixed! Let us know about any issues on our Discord server or the website's forums.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Halloween and Xmas themed level remakes often contain new achievements and flairs for you to attain. Join us for these events!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Craving Mega Marble Wars? A unique Mega Marble mode gives you points based on how hard you Mega Marble your opponents. Can you be the King?";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: When creating a recording, it will automatically restart itself until you beat the level or exit it. You can always replay the level and a new recording will be made.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If you get a World Record, the game will automatically upload a recording to the server, save one locally and announce your achievement to our Discord server.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If you fall Out of Bounds, press the powerup key to respawn faster! In Hunt levels, if you're carrying a powerup, it will not be consumed.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If you press the Respawn button in Multiplayer, it will de-activate for 25 seconds. No cheating to get closer to the gems!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Besides filling the Blast Bar to its maximum power, the Blast Item gives you a small 3% boost!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The Mega Marble powerup will make your opponents run in fear! If two Mega Marbles collide, the slower one will get booted away!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Mega Marbles are very useful for collecting loads of tightly-packed Gems.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: The Fireball powerup takes priority over the standard multiplayer Blast. If you immediately activate Blast after using Fire Blast, then your boost will be much bigger.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If you enter a Cannon as a Mega Marble, it will shrink your marble back down to size. We can't have you clogging the cannons!";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Join our official Discord server to interact directly with the community, get links to live streams, and access new user-created content faster than ever! You can find a link to it at marbleblast.com/webchat or from the community tab only if you're logged in.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Colliding with an Ice Shard as a Mega Marble will shrink your marble to its regular size instead of freezing you.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: Ghosts are spooky! Once a ghost collides with you, you will not be attacked by any ghost for about 10-20 seconds.";
$Loading::Tip[0, $Loading::Tips[0] ++] = "Tip: If a Ghost chases you, go Out of Bounds to reset its spooky timer! It will not go after you for 10-20 seconds after this event.";
$Loading::TipsChance[0] = 0.80;

$Loading::Tips[1] = -1;
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Always stay up until 5am writing silly tips.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Never assume that Batman eats nachos.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Don't forget to brush your teeth.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Don't forget to floss!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Never Eat Shredded Wheat.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Pablo Vasquez is an anagram of Bosque Lav Zap.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: After eight years of development on PlatinumQuest, we can in fact confirm that yes, marbles do roll.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: This is not a tip.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Threefolder didn't create Three-Fold Maze.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Eat a banana every day.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Sometimes, light speed is too slow.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: About 20% if you're American.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Say Challenge one more time, I dare you!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: A crash is imminent. Prepare to send your console.log file.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: This tip is as dank as the memes about PlatinumQuest";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip? Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper blandit justo, id ornare mi venenatis consectetur. Aliquam eget quam ante. In maximus condimentum odio.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: If you're bad at this game, the Out of Bounds special taunt messages will make fun of you.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Matan needs to stop watching How It's Made food videos and work on this game.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: IT'S TIME TO D-D-D-D-D-DUEL!!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: MEGA MARBLE KIDS!!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Playing against Threefolder in Multiplayer may result in the spamming of the 'Blue Steal' taunt.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: STOOL PARTY YEEEAAAHHH!!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: It's 2:50am. Do you know where your programmer is?";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: JOHN CENA!!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Hi, Mom!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Puns make everything punstatic!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: c() , d()";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Fetch, Stash, Pull with Rebase, Pop, Resolve Conflicts";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Type \'party\' on the main menu to have a party.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Writing these tips crashed the game.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: IT WAS COLD, BRO!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: up, up, down, down, left, right, left, right, B, A";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: We gave up on the changelog. Stuff got added, stuff got fixed, stuff was deleted, and we probably crashed the game a thousand times, give or take.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: HIGUY BUG CRASH";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: GO MARBLE DUDE!!";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: This still isn't cannon.cs";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Just Monika";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: hPerks will never read this.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: Refer to this game as 'Marble Blast Platinum Quest' instead of just 'PlatinumQuest' to bother Matan.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: After eight years in development, hopefully PQ will have been worth the wait.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: That doesn't sound good from downstairs.";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: u";
$Loading::Tip[1, $Loading::Tips[1] ++] = "Tip: free jojo";

$Loading::TipsChance[1] = 0.03;

$Loading::Tips[2] = -1;
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Scrapped Powerups in development include the Wings, which would have granted some form of flight, and Marbledude, which increased the effects of other Powerups and negated hazards.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Most levels were originally going to be locked, and the goal was to make your own way through the levels. This was scrapped.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: One of the original ideas was to create an overworld with a map consisting of the level images, and lines that drew paths between these levels. Beat levels that lead to others, and thus unlock the later ones.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The Mega Marble was originally going to appear in PlatinumQuest levels as a standard powerup.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: PlatinumQuest levels don't feature rug, carpet, tarmac, random force, or magnets.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: PlatinumQuest started as an update to Marble Blast Platinum, then turned into a standalone mod, and then returned to being an update to Platinum.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: It's easier to make broken new features than to fix bugs. We learned this the hard way.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: In older versions of the game, a buffer overflow caused missions with long help texts to eat up your entire hard drive with an insanely huge mission file.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: PlatinumQuest was designed to be easier than Marble Blast Platinum, but there are still a few levels that will cause you to scratch your head.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Alex Swanson, the creator of most of Marble Blast Gold's levels, donated two never-before-seen levels to PlatinumQuest -- Gravity Tower, and an old version of Skate Battle Royale, known in-game as Skate Park Square.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: PlatinumQuest was designed to not use edge-hitting or trap-launching in any way in the level design, save for one level. Can you guess which one?";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Almost every one of Matan's levels uses level-specific code. A huge headache to HiGuy, to say the least.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: PlatinumQuest had a development hiatus between 2012 and 2015. Matan was the only developer that stuck with the project from its inception in 2009 to its completion in 2017.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Tilo was originally in Marble Blast Advanced and was re-created by Kwill on request for Multiplayer. It's epic fun!";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: If you say 'Marble Blast PlatinumQuest', Matan will be thrown into a raging fit. PlatinumQuest does not have 'Marble Blast' in front of it.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Checkpoints were coded and added to Marble Blast Platinum two weeks before its first full release to the public.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The original error message noise was in fact Matan screaming 'Spy', referring to Spy47 who originally coded the Online section.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Due to a programming oversight, Marble Blast Platinum used to be able to delete any file or folder from a user's computer, including system files and folders.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Hypercube was an exclusive on Marble Blast Gold for the XBOX. Find it in Ultra's levels as Advanced 21. It retains the Gold marble size and disables the radar.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The Sundial item was originally created as a replacement to the Time Travel item, but after MadMarioSkills created the new Time Travel model, it was simply used for variety instead.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Negative (red-banded) Time Travels are actually called Time Penalty Items.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: PlatinumQuest has three main themes to its levels: regular, garden and construction, all with textures, scenery items and more to go along with them.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Levels can be created using multiple simultaneous modes. The most complex level you can make is a 2D, Quota, Laps, Haste and Consistency level. Why not give it a shot?";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: A Pinball gamemode was in the works along with levels to go with it, but was dropped. Multi-ball, Extra Ball and other Powerups were actually possible.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Some of the standard features in PlatinumQuest started as one-time custom codes for Matan.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Thanks to Torque's terrible time storage, if a server had an uptime of 24 days, the time would become negative.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: One of the dropped gamemodes was called 'Distance', where you had to travel a certain distance before being allowed to finish the level. No end pad required.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Most of PlatinumQuest's code was rewritten starting in 2015 to support Multiplayer.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: In rare cases, Moving Objects may magically disappear.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The current version of Multiplayer is actually the 8th version of a protocol that started in Marble Blast Emerald, a mod headed by Jeff and HiGuy.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The shader model in PlatinumQuest uses Flat Shading with Blinn-Phong specular highlights.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The joystick remapping tip is hard-coded to show up when you first plug in a joystick.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: PlatinumQuest's scripts contain over 115,000 lines of code. The extender adds another 50,000 lines. That is almost 4 times as many lines of code as in Marble Blast Gold!";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: It's been over 10 years and we still don't have a better version of map2dif.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: PlatinumQuest was coded almost entirely in Sublime Text.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Over the course of development, PlatinumQuest has used two different gits and one subversion repository.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Most of Matan's levels have a lot of shapes and triggers data in the interior, as he didn't want to use the Level Editor for alignment purposes. That worked somewhat, but not as well as he wanted.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Marble Blast Platinum originally started as a mini-mod that was supposed to include only 30 levels and be based within Marble Blast Gold. Matan caused it to become bigger, much to Phil's displeasure.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Alex Swanson helped create the original code for the Ultimate Time.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The Help Bubble was originally created as a replacement for the Help Trigger, but later on in development, the Bubble's features were added to the Help Trigger. Both are used in stock PlatinumQuest levels, but unmarked Help Triggers are rare.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Two friction floors that were never added to Platinum or PlatinumQuest are the frictionless floor from Oaky (0 in friction) and a super-bouncy one, with 500 units put into force.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Throughout the years, the fonts that were mainly used in the game had changed from Arial to DomCasualD to Marker Felt to Whitney. Next stop: Wingdings.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Challenges and Super Challenges appeared in Marble Blast Platinum 1.50, but were removed with PlatinumQuest's release. They were very buggy and crashed really badly.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The Out of Bounds taunt messages used to purposely crash your game whenever you reached a certain multiple of OOBs.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The community, historically, views the unseen Marblaxia as the Marble's arch-enemy. The planet where the Marble 'lives' is Marblius.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: A feature that was cut was a Random Initial Position for Moving Platforms, so that they started in different spots on their path when the level was loaded (and restarted). Unsurprisingly it was requested by Matan for a laps level of his that never materialised.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Additional collectibles that were cut are Coins and Stars. Coins helped you unlock marble skins and levels, while collecting all Stars would unlock special levels that use a new Powerup, called Wings. Both had shapes and were collectible before their removal in 2015.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Cannon.cs caused more issues than we'd like to admit in just about every stage of development.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Due to how the Online rating system works, Arctic Inferno can technically award the player 31,883,030 points for destroying all Ice Shards. Due to the time limit, it's not possible to achieve such a score.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: There are more than 100 ghost sounds! Talk about spooky entertainment!";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Winterfest was developed in 3 days! It drained our energy very quickly, as bugs were patched only days after released.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: Frightfest was developed a week before its first launch. We learned nothing from the Winterfest event.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: The servers, Tsuf and Thistle, are named after Matan's cockatiel and HiGuy's dog, respectively.";
$Loading::Tip[2, $Loading::Tips[2] ++] = "Trivia: PlatinumQuest's Ice friction is 0.07331 in value, which is Matan's way of putting leet speek in backwards. MEMES!";

$Loading::TipsChance[2] = 0.17;

function LoadingGui::getTip(%this) {
	//Hacky: Because joystick users should know
	if (isJoystickDetected() && !$pref::JoyTip) {
		$pref::JoyTip = true;
		return $Loading::Tip[0, 0];
	}

	if ($pref::tipCount < 4) {
		%cat = 0;
	} else {
		%tip = getRandom();
		for (%i = 0; %i < 3; %i ++) {
			if (%tip < $Loading::TipsChance[%i]) {
				%cat = %i;
				break;
			}
			%tip -= $Loading::TipsChance[%i];
		}
	}
	$pref::tipCount ++;
	%tip = getRandom(0, $Loading::Tips[%cat]);
	return $Loading::Tip[%cat, %tip];
}

function LoadingGui::updateRtaSpeedrunTimer(%this, %text) {
	LG_RtaSpeedrunTimer.setText("<condensed:48><color:FFFFFF><shadow:2:2><shadowcolor:777777>" @ %text);
}
