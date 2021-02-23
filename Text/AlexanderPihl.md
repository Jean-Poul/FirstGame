# Alexander Pihl - Flow 1 Handin
Vi har samlet i gruppen valgt at lave hver vores scene "bane" i et samlet spil. scenerne tage udgangspunkt i forskellige universer/temaer. I denne sammenhæng har jeg valgt bygge scenen op omkring et low poly floating island univers, hvor man skal bevæge sig fra den ene ø til den anden. Man vil blive stillet over for en masse udfordringer undervejs, og det er så op til spilleren at komme igennem disse udfordringer. 

# Components, Scripts og Animationer.

## Scripts, Box Collider og Animationer
Jeg har gjort brug af script til flere forskellige ting igennem scenen. Der er bla. brugt scripts sammen med box colliders og animationer, på de enkelte bevægelige prefab elementer, til at fastholde en spiller på det skib eller den sten spilleren hopper ud på.

## Respawn
Der forskellige respawnpunkter rund omkring i scenen. Disse er lavet af urenderede 3D Cube objekter som har en Box Collider tilknyttet, som bliver brugt som trigger. Derefter har jeg lavet et scripts som siger at hvis spilleren rammer denne trigger skal han respawne ved et givent spawn. Dette spawn er lavet med et empty object, som er knyttet til scriptet og respawn triggeren.

## Hierachi og Parenting
Der er gjort brug af Hierachi og Parenting til organisere elementerne. F.eks. er kæden i scenen sat sammen af en masse små kædestykker og for at de skal reagere som en lang kæde er der brugt parenting.

## Components
- Scripts
  - Til flere ting bla. som beskrevet ovenover.
- Mesh Collider
- Box Collider
  - Brugt i de fleste tilfælde som trigger sammen med et script.
- Animationer
  - Brugt til gøre forskellige til bevægelige som beskrevet ovenover.
- Camera
  - Som en del af Shadow(3rdPerson) prefab sammen med et script for at håndtere 3rd person Camera.
- Rigidbody
- Light
  - Brugt til at skabe lys i de blå gems rundt omkring i scenen samt andre steder.
- Particle System
  - Brugt til at lave bålet ved teltet for at imitere ild.
