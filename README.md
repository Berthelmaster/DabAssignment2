# DabAssignment2
Assignemnt2 Dab
Gruppe 9: Ali, Florent 201409781, Thomas 201710202 & Zabih 201704545

I f�lgende aflevering er der blevet taget udgangspunkt i opgave 1 hvori gruppen skulle bruge tidligere blackboard database fra aflevering 1.
Dette skulle omskrives til "entity frameworks cores code-first technique"

Inden programmet starter skal brugeren oprette migrations, og dette bliver gjort ved at brugeren indtaster add-migration initialcreate, og dern�st Update-database.
Programmet fungerer ved at brugeren starter programmet uden debugging(Ctrl+f5), og dern��st bliver brugerens valgmuligheder udskrevet p� sk�rmen, og brugeren kan v�lge imellem 11 kommandoer.
Disse kommandoer bliver bestemt udfra brugerens input som er 1-11. Disse kommandoer bliver beskrevet i terminalen og instruktionerne st�r ogs� beskrevet. Det skal bem�rkes at databasen
allerede er seedet med "dummydata", som brugeren kan se via terminalen. Brugeren har ogs� mulighed for at kunne tilf�je/redigeren databasen. Programmet k�rer i en do-while(true) l�kke,
og forts�tter derfor med at k�re indtil brugeren manuelt lukker terminalen, men de �ndringer der bliver fortaget bliver gemt i databasen. Det skal bem�rkes at brugeren f�rst skal 
oprette en lokal database ved navn "local" hvori alt bliver gemt i. 