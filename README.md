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
- Visual Red Herrings: Tire marks from other trucks are inprinted on the snow, but not all of them are created equal and some can even lead you directly towards danger (and do I see a shadow moving UNDER the ice, or is that just me...?)
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



Things to Implement:
Truck
Constant moving
Turning
Loose ice
Warning ice
Cracked ice
Snow mounds
Death screen


