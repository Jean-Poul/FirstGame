# Flow 1 - Handin
Mick Larsen

## Projektbeskrivelse
I dette, første, unity-projekt har jeg lavet en simpel forhindringsbane på ca. 3 timer.
Som player skal man igennem en kort række udfordringer og banen indkluderer scriptede prefabs, respawn script mm.

## Simple Shapes
Flere steder er der anvendt simple shapes, såsom cubes og planes.  
Jeg startede med et kæmpe terrain, formede det og lagde textures på, men droppede det eventuelt til fordel for simple platforme med cubes.  
De samme cubes inkl. assets er blevet brugt som forskellige forhindringer og pynt i banen.

## Components & Scripting

### Respawn
Jeg har udnyttet cubes collider component som trigger, som gør, at spilleren respawner når man falder ud over kanten på platformen.
Respawn scriptet tjekker om det kolliderer med en player, og flytter playeren til et empty game-object som er hægtet på respawn scriptet.

### Prefab Spawn
Når playeren går igennem en speciel trigger, spawnes der en prefab (Simpel sphere) som falder ned bag spilleren og triller efter ham i bedste Indiana Jones stil. Dette script ligner respawn-scriptet, bortset fra, at det ikke transformer en position, men instantiater en pre-fab.

### Platform gravity drop
Sidst i banen skal spilleren hoppe fra en svævende platform til en anden.  
Når spilleren hopper væk fra en platform aktiveres gravity på RigidBody componentet og platformen falder ned.

### Trigger med audio
En trigger blev sat op til, at afspille lyd på spillerens audiolistener, når spilleren gik igennem denne trigger.  
Effekten spiller temasangen til indiana jones og der spawnes en kæmpe sphere bag spilleren som gerne skulle "Motivere" spilleren til at komme videre.