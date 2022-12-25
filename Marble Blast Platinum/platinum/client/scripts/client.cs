//-----------------------------------------------------------------------------
// Portions Copyright (c) 2021 The Platinum Team
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

//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Server Admin Commands
//-----------------------------------------------------------------------------

function SAD(%password) {
	if (%password !$= "")
		commandToServer('SAD', %password);
}

//----------------------------------------------------------------------------
// Misc server commands
//----------------------------------------------------------------------------

function clientCmdSyncClock(%running, %time, %bonus, %total, %ping) {
	if (%running) {
		PlayGui.startTimer();
	} else {
		PlayGui.stopTimer();
	}

	if ($PlayTimerActive) {
		if (%bonus == 0) {
			//If we're playing, try to account for lag, but don't overcompensate by
			// going past 0.
			%time = max64_int(0, sub64_int(%time, %ping));
		} else {
			%bonus = max64_int(0, sub64_int(%bonus, %ping));
		}
	}
	//Set their time
	PlayGui.setTime(%time);
	PlayGui.setBonusTime(%bonus);

	PlayGui.totalTime = %total;
}

//-----------------------------------------------------------------------------

function OOBCounter::check() {
	%oobRandom[0] = "Let\'s be clear of the blatant truth: You suck!";
	%oobRandom[1] = "Honestly, do you have any control over the marble? It seems to have a life on its own...";
	%oobRandom[2] = "Are you sure you know how to play Marble Blast?";
	%oobRandom[3] = "I really hope you\'re seeing this message on Manic Bounce right now. If you\'re not, man do YOU have some practicing to do.";
	%oobRandom[4] = "Look at the bright side, it\'s part of the learning experience, but it doesn\'t change the fact that you still suck.";
	%oobRandom[5] = "If we ever had a \'You suck\' achievement, you\'d be having the honour to wear it today.";
	%oobRandom[6] = "200 more times to go Out of Bounds before you see this message again. For your sake, try and do better.";
	%oobRandom[7] = "\"I didn\'t play on the computer! It...it was.. my auntie!\" Yeah, right. Admit it, you suck.";
	%oobRandom[8] = "Are you having fun going Out of Bounds all the time? It seriously looks like it.";
	%oobRandom[9] = "Don\'t you just hate all these messages that make a mockery of your suckiness? It\'s a joke of course, but it\'s a nice easter egg.\nIf you don\'t want to see them anymore, then stop going Out of Bounds so many times!";
	%oobRandom[10] = "My grandmother is better than you!";
	%oobRandom[11] = "We\'ll see what happens first: You finishing the level, or the clock hitting the 100 minute mark.";
	%oobRandom[12] = "Can we put this on the video show? I mean, that was absolutely stupid of you to go Out of Bounds like that!";
	%oobRandom[13] = "While we\'re on the subject of you going Out of Bounds, you should try and find out all the possible ways to go Out of Bounds, including the stupid ways which you seem to excel in.";
	%oobRandom[14] = "This level isn\'t made out completely out of tiny thin tightropes! You have no excuse whatsoever on failing this badly. If you see this message on Tightropes, Under Construction, Catwalks, or Slopwropes, ignore it. Instead, change it to \"HAHAHA!\"";
	%oobRandom[15] = "Excuse of the Day: \"I was pushed Out of Bounds by an invisible Mega Marble!\"";
	%oobRandom[16] = "Congratulations, you win--- wait, no, no you don\'t. You went Out of Bounds. Sorry, you lose. Again.";
	%oobRandom[17] = "I found a way for you not to go Out of Bounds. We\'ll change the shape of the marble to a cube. Wait, never mind, you\'ll still find a way, because you can.";
	%oobRandom[18] = "You sure you played the beginner levels? You did? Doesn\'t look like it.";
	%oobRandom[19] = "You know what would be hilarious? This message popping up on \'Training Wheels\'. I hope you aren\'t playing that level right now... are you?";
	%oobRandom[20] = "Mind if we\'ll change your name to \'Mr. McFail?\'";
	%oobRandom[21] = "Excuse of the Day: \"But I was distracted by ________ and he/she/it wouldn\'t stop and forced me to go Out of Bounds.\"";
	%oobRandom[22] = "Which one are you: a bad player or a bad player? We willl go with option C: a really bad player.";
	%oobRandom[23] = "Excuse of the Day: WHO PUT THAT GRAVITY MODIFIER IN THERE??!?!";
	%oobRandom[24] = "Excuse of the Day: That In Bounds Trigger WAS NOT in the level last time I played it! Somebody hacked the level and put one in there!";
	%oobRandom[25] = "Excuse of the Day: My awesome marble was abducted by aliens and was replaced by a really crap one!";
	%oobRandom[26] = "Excuse of the Day: That Out of Bounds trigger was NOT there before! I swear!";
	%oobRandom[27] = "Excuse of the Day: I\'m not Xelna :(";
	%oobRandom[28] = "Excuse of the Day: I don\'t suck, I fell off because I wanted to get to the next 200 Out of Bounds multiplier so I can see the awesome messages that are written down.";
	%oobRandom[29] = "You know, you won\'t beat the level if you keep falling off. You will, however, see more of these messages. Try and stay on the level next time. Our guess is that you can\'t, because you\'re bad.";
	%oobRandom[30] = "Look at the statistics page! I bet you fell more times than the amount of levels you beat!";
	%oobRandom[31] = "Excuse of the Day: I\'m learning to play... the hard way.";
	%oobRandom[32] = "Apparently your marble isn\'t supermarble. It is suckmarble.";
	%oobRandom[33] = "Foo-Foo Marble laughs at how bad you are.";
	%oobRandom[34] = "A Rock Can Do Better!";
	%oobRandom[35] = "Please, Quit Embarrassing Yourself.";
	%oobRandom[36] = "Keep this up and you\'ll win the \'Award of LOL\', courtesy of Marble Blast Fubar creators!";
	%oobRandom[37] = "Marble Blast Fubar creators would like to give you the title of \'Official NOOB of the Year\'. Congratulations!";
	%oobRandom[38] = "Did you hear that \'Practice Makes Perfect\'? Apparently not.";
	%oobRandom[39] = "You should create a new level and title it \'Learn the In Bounds and Out of Bounds Triggers\' because you\'re so experienced with them.";
	%oobRandom[40] = "We\'ve seen the ways you fell while playing this game and we gotta admit, some of their are epic fails. We still can\'t stop laughing!";
	%oobRandom[41] = "SING WITH ME:\n\nOne hundred and ninety nine times Out of Bounds, one hundred and ninety nine times Out of Bounds, throw the marble off the level, two hundred times Out of Bounds!";
	%oobRandom[42] = "*sigh*, you just can\'t stop yourself from going Out of Bounds, can you?";
	%oobRandom[43] = "Excuse of the Day: I\'m playing one of those special levels from Technostick where you must fall off in order to beat them.";
	%oobRandom[44] = "Excuse of the Day: I\'m under bad karma today.";
	%oobRandom[45] = "Excuse of the Day: So THAT\'S what my astrologist referred to when he said I\'ll keep falling off today.";
	%oobRandom[46] = "What do you have against the marble that you keep making it fall off the level?!";
	%oobRandom[47] = "I bet having a Blast powerup would have really helped you there, no? Well, too bad! \nOh, and if you\'re playing an Ultra level, pretend this message says \"HAHAHA!\" instead.";
	%oobRandom[48] = "And how is it OUR fault that you\'re playing so badly?";
	%oobRandom[49] = "Do you ever think about the marble\'s safety when you\'re playing? Apparently not because you\'re really careless with it.";

	%oobSpecial[0] = "You went Out of Bounds for 1,250 times. This program will now sit in the corner and cry about how bad you are and hope that when you open it again you won\'t repeat it. False hopes are still hopes.";
	%oobSpecial[1] = "You went Out of Bounds for 2,500 times. If you aren\'t tired of going Out of Bounds all the time, we sure are. Stop it already!";
	%oobSpecial[2] = "Another 1,250 marbles had fallen to the great sea below, and you\'ve reached the 3,750 Out of Bounds mark. You definitely suck. Ah yes, greenpeace would like to see you in court for your \"contribution\" to rising sea levels.";
	%oobSpecial[3] = "If I had a nickel for every marble that fell Out of Bounds I\'d be rich right now and all thanks to you. However, I\'m not going to give you any money. Instead, I\'ll stick my tongue out at you and then laugh at you. Ah yes, congratulations on hitting the 5,000 Out of Bounds mark.";
	%oobSpecial[4] = "6,750 times Out of Bounds. Let\'s assume, hypothetically, that you won\'t go Out of Bounds ever again. Actually, never mind that, you will still suck even if you don\'t go Out of Bounds again.";
	%oobSpecial[5] = "I have an awesome gut feeling that you are going 7,500 times Out of Bounds on purpose if only to see these messages and to hear about how bad you are.\nWell then, I won\'t keep it away from you.\nYou suck!";
	%oobSpecial[6] = "8,750 times Out of Bounds. For reaching this landmark, I\'m giving you a nice Australian Slang sentence to answer the question: Will you ever stop sucking in this game and go Out of Bounds? Answer:\nTill it rains in Marble Bar\n\n\nIn your language it means:\nNever.";
	%oobSpecial[7] = "Wow, you truly are bad, probably one of the worst Marble Blast players to ever live on this planet. Or you just keep failing to good runs. Are you sure you aren\'t playing an easy level while this message pops up? Whatever, those messages will now repeat themselves (with a few exceptions), but for now, please remember this:\n\n\nYOU suck!";
	%oobSpecial[8] = "SING WITH ME:\n\nForty nine thousand nine hundred and ninety nine times Out of Bounds, forty nine thousand nine hundred and ninety nine times Out of Bounds, knock a marble off the level, fifty thousand times Out of Bounds!";
	%oobSpecial[9] = "What\'s that in the sky? Is it a plane? Is it a bird? No! It\'s the marble! And it\'s way off the level!!! Congratulations on hitting 300,000 Out of Bounds mark. You may now suck more.";
	%oobSpecial[10] = "1,000,000 times Out of Bounds?!?! You seriously love this game, don\'t you? Well then, thanks for playing PlatinumQuest! Please keep this bad playing up and continue to go Out of Bounds. We\'ll just laugh at how bad you are. Also, this is the final message as from now on they\'re all repeats. Thank you for sucking at PlatinumQuest!";
	%oobSpecial[11] = "You have no life. This is official.";

	// So many unescaped apostrophes were making my IDE go bonkers. ESCAPED

	switch ($PREF::OOBCOUNT) {
	case 1250:
		ASSERT("Out of Bounds",%oobSpecial[0]);
		return 1;
	case 2500:
		ASSERT("Out of Bounds",%oobSpecial[1]);
		return 1;
	case 3750:
		ASSERT("Out of Bounds",%oobSpecial[2]);
		return 1;
	case 5000:
		ASSERT("Out of Bounds",%oobSpecial[3]);
		return 1;
	case 6250:
		ASSERT("Out of Bounds",%oobSpecial[4]);
		return 1;
	case 7500:
		ASSERT("Out of Bounds",%oobSpecial[5]);
		return 1;
	case 8750:
		ASSERT("Out of Bounds",%oobSpecial[6]);
		return 1;
	case 10000:
		ASSERT("Out of Bounds",%oobSpecial[7]);
		return 1;
	case 50000:
		ASSERT("Out of Bounds",%oobSpecial[8]);
		return 1;
	case 300000:
		ASSERT("Out of Bounds",%oobSpecial[9]);
		return 1;
	case 1000000:
		ASSERT("Out of Bounds",%oobSpecial[10]);
		return 1;
	case 30000000:
		ASSERT("Out of Bounds",%oobSpecial[11]);
		return 1;
	}

	if ($PREF::OOBCOUNT != 0 && $PREF::OOBCOUNT % 200 == 0)
		ASSERT("Out of Bounds" SPC $PREF::OOBCOUNT SPC "times",%oobRandom[getRandom(0,49)]);
}
