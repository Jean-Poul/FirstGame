# Parkour game
___

**Software**: Unity and Visual studio code.

**Stage**: First stage – Rock City.

**Work planner**: https://trello.com/b/kZXVMsHW/keen-games

**Stage rules**: Follow the clue and get to the end of the stage. To finish the stage, follow the command at the end of the stage.

**Component**: <br/>
•	*Rigidbody* for physics<br/>
•	*Collider* (Box, capsule and mesh) for “walls” and for triggering events<br/>
•	*Camera* for 3rd person view <br/>
•	*Canvas* for text display<br/>
•	*Scripts* to make components more dynamic (written in C#)<br/>
1.	Player -> BasicBehaviour, MoveBehaviour and ColorNearbyCubes<br/>
2.	FirstTrigger and  SecondTrigger -> Gps<br/>
3.	First, Second, Third and FourthPlatform -> PlatformAttach<br/>
4.	Cube(2-8) -> MyFirstScript<br/>
5.	Trigger -> ChangeMaterialColor<br/>

•	*Animator* for moving platforms <br/>
•	*Prefabs* for reusing similar parts and the Player (shadow)<br/>
•	*Mesh render* unticked for having invisible triggers <br/>

Besides that, I have used *simple 3d shapes* and *imported* several buildings and rocks from a low-poly package in the unity store to be able to build the city stage.

**Scenes**: 
FirstHandIn.unity: Contains all the scripts, components which are attached to those scripts and the shadow man (Players).
SampleScene.unity: Contains all the components used for the city. Also, there is a test platform outside the main stage which I have been using to test out my scripts.

**Thoughts**: To begin with my thoughts with this stage was that a player had to run to different waypoints in the city and collect triggers so the player would be able to spawn the platforms and get to the end of the stage. That was a bit to ambitious with the time I had to make the stage. I then made the decision to make a trigger that will spawn some text (with a big clue) to guide the player. When the player reaches the end of the stage another trigger has been set to display some text on what the player is able to do and then finish the stage.
I am missing colliders on several components so the player will have to live with some wallhack.

**Made by**: Jean-Poul Leth-Møller<br/>
HIGH FIVE!
