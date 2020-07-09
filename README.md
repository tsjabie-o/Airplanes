# Airplanes
Opdracht voor studie

De taak van een luchtverkeersleider is om al het luchtverkeer veilig door het luchtruim te
navigeren, door piloten instructies te geven omtrent hun te volgen koers. Een belangrijk doel
is dat vliegtuigen niet te dicht bij elkaar in de buurt komen. Jij hebt dus een correct
en snel algoritme nodig, dat voor een gegeven verzameling (x, y)-coordinaten van vliegtuigen
in een bepaald rechthoekig gebied, bepaalt wat de kleinste onderlinge afstand is die er tussen
twee van die vliegtuigen bestaat. Ze kan dan een menselijke operator ondersteunen door hem
of haar te wijzen op zo’n paar, waar het risico het grootst is, en een gesprekje met de piloten
geboden is.

De eerste regel van de input bevat een geheel getal 2 ≤ n ≤ 1 000 000, het aantal vliegtuigen
op het scherm. Daarna volgen n regels met op elke regel de positie van een vliegtuig, in de
vorm van een x- en een y-coordinaat. Dit zijn niet-negatieve gehele getallen ≤ 10 000 000,
gescheiden door een spatie. Als output geef je het kwadraat van de minimale afstand tussen
twee posities in de verzameling van n posities.

Je moet recursie gebruiken om een algoritme te ontwerpen dat snel genoeg is.

---------------
Dit is in feite het Closest Points probleem
