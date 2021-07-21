# bridge-of-ice
Ice road truckers but it's a horror game

Bridge of Ice (Design doc):

(Everything here is tentative, subject to iteration and open to change! This text, when set in stone is duplicated verbatim in the #design-doc channel for the sake of immediacy and convenience)

STORY:
 - The weather is getting dangerously bad, no-one else is doing ice road deliveries because the weather channels are all telling them to stay inside.
- Unfortunately for you, money is tight and a contract just made itself available. You need the cash, so you take up the delivery and deliver the goods.
- The return journey however took a turn for the worst. All the other safer routes home have been shuttered because of the snowstorms.
- Now you must cross the thin and perilous ice bridge in one sitting as the day turns to night. If it's not all downhill from here, it's down into the drink. Take care.

GAMEPLAY:
- In more direct terms, you are effectively following an invisible line from one end of a flat plane to an end goal point on the other side with only sound and visual cues helping you to stay on that line (trees and hills mark a hard limit to how far a player can steer off-course).
- You move forward automatically in the truck at the regulation limit of 25mph, steering left and right where necessary with the use of two keys/buttons.
- Listen very closely past the sounds of your revving truck engine for gurgling water beneath the ice as well as loose ice crunching beneath your tires.
- Be sure also to keep an eye out for thinner, less white sheets of ice where cracks have formed, bringing with it bubbles and the remnants of other fallen trucks from the deep blue.
- They will serve as signals indicating you must steer away and onto safer ground. If you stay on thin ice too long, your truck will crash through the ice and you will die.
- If you panic and steer too much on thin ice to over-correct, the ice will only break away faster, so try not to overreact.

VARIATION:
- Snow: Driving over too many small mounds of snow can lead to them getting stuck in the tires and your steering will become erratic until they melt away after a time
- Truck Engine: Sometimes the engine of your old busted up truck will start to rattle away for a bit and obscure the sounds you need to be listening out for (occurs randomly)
- Vision and Sound-Obscuring Weather Effects: As the game progresses, the sun will set, forcing the use of headlights while the fog and snow will become heavier, requiring windscreen wipers (these are both automated)
- Visual Red Herrings: Tire marks from other trucks are imprinted on the snow, but not all of them are created equal and some can even lead you directly towards danger (and do I see a shadow moving UNDER the ice, or is that just me...?)
- Time: The night darkness will arrive swiftly if the player takes too long to cross the ice sheet, meaning that they are forced to constantly consider a tough decision: take the long safe approach and make things more difficult later on or cut corners to beat the sun and risk the possibility of near-instant failure

AUDIO:
- The sounds of the roads are going to figure into the gameplay, so consideration should be made that all ambient and decorative sound design take a backseat to sounds directly pertaining to the gameplay experience.

- Vital gameplay sounds  (should all be mixed at a higher dB): 
Several levels of texture for driving, ranging from rock solid concrete, icy roads, cracking ice, sloshing, etc.
Texture for driving with snow-covered wheels
Engine running and occasionally running hot (drowning out the road sounds)
Gurgling water which becomes louder as the truck approaches a bad path
Breaking through the ice should be loud and frightening (a glass-shatter  sound?)
Impact running into boundaries/road obstacles? Does the truck explode, break down, or crash through the ice?

- Tertiary gameplay sounds
Ambient weather sounds - howling winds growing into a louder and louder blizzard (also drowns out the road sounds a bit)
Car sounds (headlights, windshield wipers)
 Squealing tires on tight turns
More specific sound effects relating to road hazards and/or environmental setpieces

- Music
Ambient industrial BGM, grinding and intensifying over the course of the game with a crescendo at the end
Title screen music? Something slow, dark and melodic
Post-death shouldn’t be full music but I can make an eerie ambient piece
I can also make a track for a victory sequence

- UI
Standard menu sounds (scroll, confirm, return)

SCENES:
Title screen (includes commands such as “Play”, “Quit”, “Options”, (visual, audio, controls) and “Credits”
By default, the game starts at the “Options” screen before moving to the main Title menu on first-time start-up, taking the user through a series of screens to alter (in order) separations of sound levels regarding important in-game audio cues to accommodate for hearing disabilities (framed as “move bar until you can hear ice-cracking sound), set steering input to toggle or hold to accommodate for physical disabilities, maximum fog depth and gamma levels to accommodate for sight disabilities (framed as “move bar until you can see trees in the background” and “move bar until the logo stands out against the background”). Changes are saved and this sequence is skipped on subsequent sessions)
Intro sequence (text based public safety broadcast with weather warning alarm, this can be skipped, cut to black as tv is turned off, fade in to text on back background detailing the story context with gameplay controls, truck door slams and engine starts when player presses a button to fade in on main gameplay)
Main gameplay scenario (driving over the frozen lake)
Game Over screen (after truck crashes through ice, Gaussian blur as truck is submerged in blue, fade to black, metal creaking and cold underwater noise as “game over” text fades in over the top, takes players back to title screen)
Victory screen (fade to black, audio of engine stopping and character entering home via front door with calming homely ambience and “congratulations” text on-screen with credits.)

CODING REQS:

Main Gameplay Loop:
Truck
Constant moving
Turning
truck drive forward     until predefined end or hits obstacle (Obstacle = another partially sunken truck sticking out from under the ice sheet OR a tree situated on the boundaries of the game map)    
ICE: As detailed on the map pinned in #image-moodboard there are various safe zone routes that thin out as the player makes progress across the ice bridge. These safe zones are constructed with collision meshes that are invisible to the player.
(Player leaves safe zone collision mesh > 15 sec death timer ticks down + truck speed decreases slowly by up to 30% + Ice crack sounds play, intensify with increased range > if death timer reaches zero > ice truck sinking sequence plays > game over)
(Player re-enters safe-zone before death timer reaches zero > truck speed goes back to original default + death timer resets, time can be balanced + if player had less than four seconds before the death timer ran out, activate visual effect “Water splashing underneath newly cracked ice” behind player, viewable from truck rear view mirror)
Snow mounds (Truck passes over > sounds of slushy sleet in the tire > erratic sensitivity for steering controls (lasts 15 secs, can be balanced)

Audio:
Audio effect triggers
Truck engine hiccups: (no discernible pattern or correlation with gameplay actions or events; they occur solely to throw the player off, can play every minute or so)
Loud blizzard sounds: (slowly rise in volume and intensity to obscure other important sounds as night time encroaches to obscure vision)
Ice cracks, In order of intensity (as the player drives out and further away from the safe zones): Subtle ice rumbling/water bubbling between the fissures, tires shredding ice as it all starts to break apart
Audio Groups(sfx, vo, music, ambience)
Any Dialogue? (don’t think there will be any)

Visual Effects:
“Low-resolution” screen filter effects (partially emulating a high-contrast colour-bleeding CRT feed of classic playstation 1 gameplay)
Fail sequence (control is ripped from the player, truck slows to a crawl, angles downward to drive “through” the ice into blue fog under it, water splash visuals erupt from the front window, quick gaussian blur and fade to black after 5 secs)
Death screen (“game over” text fades in slowly on black background, slowly fades out after 5 secs, load main menu “opening screen” after)
Ice and Snow mound effects
Blizzard particle effects in world/front truck window obscured by landing snow at its borders, narrowing field of view
Water splashing underneath newly cracked ice
Dark “shapes” under the ice moving briefly with the truck
Dark “shapes” receding in truck rear view mirror
Fog
“Day” slowly turning to “night” (world light dimming gradually on a timer)
Camera rapidly “RinterpTo” one of three dutch angles when driving over a snow mound or escaping a danger zone just before the “death timer” expires (this happens on random instances of such events)

UI:
Opening Screen (camera viewing ice sheet horizon from low angle while underneath the truck model, logo top-centre, “play”, “exit” and “options” etc bottom of screen)
pause screen (exit game, audio settings, controls, ect)
Controls (rebind keys?, set steering input to toggle button for input or hold down button for input)
audio settings (adjust “helpful” audio to distinguish it from the general ambience)
Help screen? (Text dump explaining story context, game objective and survival hints)
Cutscenes/Animations:
Arms on steering wheel that rotates based on truck steering direction, attached to unmoving body
Gently rattling camera shake that becomes more violent as the player steers further and further away from the safe zone
Opening cinematic can probably be done best with cinemachine and timeline
Any character animations will need to be done by non coders though (character activity can be implied and obscured behind screen overlays to cut down on dev time)
Game does the panning down to trucks intro sequence finishes sequence then calls signal to begin actual gameplay (NEXT PAGE)




INTRO CUTSCENE:

[PLAY GAME selected]
[Slow fade to white]
[Loading with no icons]
[Fade in slowly on scene with gradual ominous ambient music]
[Camera pulls backwards across ice lake from end/midpoint on, sunset seen through foggy horizon, camera faces the same single direction at all times only moving backwards from sunset, lines of text appear and disappear in sequence one after the other]

"Date:
October 18th 2011
16:24pm"

[Break]

"Location:
Amur River
Sino-Russian Border"

[Break]

"Begin log:
Returning to base after delivery
No other drivers on hand to assist"

[Break]

"Weather is bad
Local reports warned of heavy fog
Snowstorms also blocking public routes"

[Break]

"Needed to pay rent
Money was scarce
This job should see me through for a while"

[Break, Thick layers of snow are seen on the ice as the camera speed starts to slow, ambient music intensifies]

"Running on fumes now
All roads are blocked up by heavy snowfall
Road works aren't fast enough"

[Truck drives over the snow towards the ice, moving in the opposite direction to the slower moving camera]

"Union PSA gave severe caution
Advised heavily against driving on ice
The river ice is still compromised"

[Camera moves past broken caution tape implying the truck just broke through it, camera slows to a stop just on the main road that the truck seemingly veered away from]

"No choice now"

[Cut to black with break, ambient music stops at climax]

"End log"

[Loading, No icons, Smash-cut to gameplay with sound, No fancy transition]









ENDING CUTSCENE:
    
[Truck reaches the main road again]
[In-game sounds echo into silence, screen fades slowly to white]
[Beat]
[Slow fade to black]
[Beat]
[Soothing ambience plays with soft distant truck engine hum over final diary log entries]

"Date: October 18th 2011, 21:08pm"

[Break]

"Location: The Home Stretch"

[Break]

"Begin log:
So tired"

[Break]

"Will eat and rest for a bit now"

[Break]

"Then prep for more winter deliveries"

[In the darkness, a small pair of truck headlamps slowly drift across the screen from the right as the log entries keep appearing on-screen, light occasionally blocked by trees]

"Called friends so they know I'm okay"

[Break]

"They were very concerned"

[Break]

"I will have help next time"

[Break]

"But it still won't be easy"

[Truck headlamps stop three quarters of the way to the left of the screen, soothing ambient music and engine hum stops]

"For any of us"

[Two more lights appear, both square shaped, one is coming through a window, the other is through an open door]

"None of us are ever really finished"

[Break]

"So tired"

[All lights turn off with an audible “click”, screen is bathed in black]

"End log"

[Break]
[Slow fade in on "Thank you for playing" credits screen]


Extras:
If Dialogue then closed captions always helpful
