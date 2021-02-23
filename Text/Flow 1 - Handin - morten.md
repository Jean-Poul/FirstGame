# Flow 1 - Handin
Morten Rahbek

## Projektbeskrivelse
Til vores første unity-handin, har vi i gruppen besluttet os for at lave et parkour spil. 
Hver gruppe medlem har grebet det lidt forskelligt an. Jeg har f.eks. valgt at lave en dungeon inspireret af de gamle counter-strike "de_rats" baner. Banen har taget en god del over 3 timer at bygge, da jeg havde langt mere fokus på udseendet, lys og opbygningen af banen. Og først senere fundet ud af der også skulle inkluderes visse elementer. 

Banen er bygget op som et middelalder laboratorie, hvor der er gemt 4 stykker frugt man skal samle, 
Hvert stykke frugt trigger at lyset i et af hjørnerne på den store gravst i hjørnet skifter farve. Således at man kan se hvor mange man har samlet.  
Senere stadie af spillet vil åbne op for en exit af banen i den store gryde, samt evt. fall damage og respawns.

## Simple Shapes

Meget af banen er opbygget af assets, men simple shapes er også blevet brugt i flere tilfælde

## Components & Scripting

### Light Change on collisione
Jeg har brugt  OnCollisionEnter til at registrere når spilleren rammer ind i en af frugterne, der derefter skifter farven på et lys fra rød til grøn.

### Audio
Et halloween tema er blevet sat op til at spille ved banens start