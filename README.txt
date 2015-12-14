ASSETS IMPORTED:
	Cameras
	Characters
	Effects
	ParticleSystems
	Utility

things falling from the sky. Hit them with projectile launcher.
If a falling object hits the floor, it breaks, and any player standing on it falls into a pit of death and looses.

Survival game.
First person view.
Aiming is "halo style" with no "aim down sights".
The game is enclosed in a walled room with 4 glass floors. Glass floors break when any object toutches them.
Protect the floors by hitting them with your weapon before they hit the floor.
Floors will respawn by sliding out of the walls from time to time.

Floor respawn time will increase as the game goes on to increase difficulty.
	baseRate = 6 seconds
	increase linear by 1/10 of a second every second
The game will drop falling objects faster as the game goes on.
	baseRate = once every 3 seconds
	rate is inverse. (baseRate / timeInGame)

The falling object spawner has a chance of spawning a "cluster". Every time an object spawns, there is a 10% chance it will "cluster" meaning, it will immediately spawn another projectile exactly .1 seconds later, at a similar angle.
After a cluster is fired, 0.1 seconds is added to the time until the next non cluster object spawns.

Sometimes, bonus weapons will fall from the sky. These will mostly work like normal falling objects, however, if you catch them before they hit the ground, you get to use them.

Default grenade launcher.
	click to fire a projectile.
	projectile follows gravity
	when the projectile hits an object or a wall, it explodes.
	Anything within the radius of the explosion will be destroyed.
	CAN break glass on a direct hit (but not by explosion radius).
	Unlimited ammo. When the player runs out of a gun's ammo, it will switch back to this gun.

Bow and Arrow
	fire speed is faster
	fire rate is faster
	not as much drop
	will not break glass on direct hit.
	-no explosion
	ammo: 15

Rocket Launcher
	not affected by gravity
	large explosion radius
	
	ammo: 7

Flak Cannon
	Explodes using a timer (1 second after firing)
	ammo: 7


STORY:
You work in a glass vase corporation. The CEO of the company, Dr.Clear, feels that you are underperforming your job.
So, he sends you into the molten glass cage, where glass sheets are melted so they can be reformed into vases.
As the glass converyor system fails, and glass sheets get stuck, Dr.Clear becomes angry, and wants to speed up your death.
He does so by throwing everything in the work place at the glass floors to break them.