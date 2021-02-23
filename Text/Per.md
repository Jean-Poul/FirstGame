# Flow 1 - Handin
Per Kringelbach

## Projektbeskrivelse
I det første unity-project har jeg lavet en simpel forhindringsbane. Som player starter man i en forladt skov med ruiner fra en ødelagt by. Man skal så finde frem til forhindringsbanen, og igennem, for at finde vej ud af level. 

## Terrain, Simple Shapes & Prefabs
Level er bygget op med et Terrain som er formet ved brug af Terrain Tools. Derefter er der brugt forskelige texture og prefabs som er hentet i Asset store. På selve Terrain laget er der blevet brugt flere layer til selve texturen.


Til bygninger og forhindringsbane har jeg brugt Prefabs. Også til træer er der blevet brugt Prefabs som er tilføjet Terrain ved brug af 'Mass Place Trees' hvorefter de træer som ikke skulle værer der blev fjernet.


## Components & Scripting

### Respawn
Jeg har brugt cubes collider component som trigger til at respawne player når han falder af platformen fra forhindringsbanen. Respawn scriptet 
tjekker om player kolliderer med cubes collider og flytter player til et tomt GameObject, som er en child til cuben. For at cuben ikke skal renderes har jeg fjernet flueben i Mesh Renderer.

## Audio
Jeg har lagt 'stemnings-musik' i baggrunden ved hjælp af et tomt GameObject. I det tomme GameObject har jeg først tilføjet Audio Source componentet og bagefter musik til AudioClip. Musiken er importeret til en mappe, som ligger under Assets i Project.
