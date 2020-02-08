Glitch Garden

A Plants vs Zombies Clone from a 2D Unity class I'm taking.

![Screenshot](https://github.com/djotaku/Glitch-Garden/raw/master/Assets/screenshots/20191120.png)

Video of Plants vs Zombies: https://youtu.be/H79ZjVVa4AU

Video of Glitch Garden: https://youtu.be/eaK9t-BB-Ig

I know there are some bugs in the code at the moment, but nothing that keeps it from being playable. Mostly there seems to be one bug where it doesn't stop things when a win or lose happens (like it's suposed to) and one bug where losing both says you lost and you won on the screen.

To play on the web: http://server.ericsbinaryworld.com/WebGL/GlitchGardenWebGL/

To play on Windows or Linux, go to releases to get the binaries.

# Visual and Audio Credits

Nearly all assets from a defunct game called Glitch (https://www.glitchthegame.com/) that made all its assets Creative Commons CC0 1.0 Universal Public Domain Dedication.

# What I've done since finishing this section of the class

Nothing yet, haven't finished

# What I learned in this module of the class

- Sprite Sheet Animation
- Bone Based Animation - just a mention - all the animation for this game was Sprite-Sheet based
- Different scenes can have different Canvas Scaler Options
- Use anchors on things like text and buttons if you want to allow things to scale with “shrink” (which doesn't create “black bars” if the aspect ratio is changed.
- Calculating a Safe zone when dealing with different aspect ratios. So if you want to have a safe zone for 4:3 when you want to support 16:9: ratio as a decimal. 16/9 = 1.77. 4/3=1.33333 So you take 1080*1.3333 to get the horizontal pixels. That gives you: 1440. So need 1920-1440 horizontal pixels (480) or 240 pixels on either end.
- How to have background in the UI instead of camera like we did in the other games
- Parent transforms are relative to the world while child transforms are relative to the parent. Location (0,0) for the child is on top of the parent - wherever it is in the world
- Using “Player Prefs” to save User Settings - easily hacked, so don't put critical info or player unlocks there.
- Tips for Tuning and Desgining Level Progression
