# StormTheCastle VR

How it works:

PlayerManager - keeps track of the player instance at all times. This is used in the enemy pathfinding as they are constantly looking for if this instance is close enough to target.

AIEnemyController - Uses a NavMeshAgent in order to navigate the map with the player instance as its target. Has a tweakable sense radius that will look for the player target instance to get within that distance in which the enemy will run to the enemy and start attacking when close enough. 

ChestSpawner + EnemySpawner - spawn in at random one chest, and all enemies.

colliderDetector - Listens for a collision, and depending on the type of collison, will execute and attack, or collection. If the collision detects an enemy, a new Enemy instance is grabbed from teh collision, and that enemy will be dealt damage via an attack function. If the collision detects it is a chest, and the user presses A while in this detection, the scene is switched back to the main scene where the user can choose to play again.

EnemyCombat - Handles the attack function for the enemy. Has a cooldown of 2 seconds to prevent the enemy from attacking too fast.

Enemy - Holds the healthbar and code for taking damage and changing that health bar.

CharacterAnimator - used for switching between movement animation, combat animation, and idle animations.

CharacterStats - holds the general stats and damage function for both player and enemies.

