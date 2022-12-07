# GED-Final

# **Created From Scratch** 

This project was made from Scratch, since my Student Number is 100795120, with an accumulation of 25, I am ODD making me have the designated game of PAC-MAN.

Since we are supposed to create a Low-fidelity scene, the implementation from scratch would be more meaningful as creating own navigation system and movement would allow me to resemble the movement of Pac-Man. Furthermore with the design patterns we have to implement this would help createing only the instances needed for the ghosts and pellets to make it look like a level out of Pac-Man.

The Ghost AI script, should naviagate the ghosts that would have been created by the Object pool, towards Pac-Man, when colliding with Pac-Man a lose condition should have appeared.


# Object Pooling

The Object Pooling was implemented by creating an Abstract class called Pool. This Pool class had refrences to the prefab made for the ghost object, the tag of the ghost, and the size that will be instantiated when the object pool runs.

This Abstract class would be refrences in another class, this class the ObjectPooler would have a list refrencing the Abstract class Pool for multiple objects to be instantiated, and a refrence to the GameObjects. A dictionary would be made to refrence pool and instantiate them from the prefab that was chosen, once it is complete it would set the object active to false until it is needed. The pool would make sure to spawn in the same position and rotation of the prefab, when it is set to Active.

The ghosts class refrenes the ObjectPooler and the instance of the function SpawnfromPool, to create the Ghost clones, if the Objectpooling is done, then it instantiates the prefab. It is supposed to when the Ghosts are enabled it enables their transform to start moving and when disabled they are put to sleep, making them unable to move. It was supposed when colliding with the Player object, the game concldues.
