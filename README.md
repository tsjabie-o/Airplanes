## Airplanes
Opdracht voor studie

# Opdracht
"De taak van een luchtverkeersleider is om al het luchtverkeer veilig door het luchtruim te
navigeren, door piloten instructies te geven omtrent hun te volgen koers. Een belangrijk doel
is dat vliegtuigen niet te dicht bij elkaar in de buurt komen. Jij hebt dus een correct
en snel algoritme nodig, dat voor een gegeven verzameling (x, y)-coordinaten van vliegtuigen
in een bepaald rechthoekig gebied, bepaalt wat de kleinste onderlinge afstand is die er tussen
twee van die vliegtuigen bestaat.
De eerste regel van de input bevat een geheel getal 2 ≤ n ≤ 1 000 000, het aantal vliegtuigen
op het scherm. Daarna volgen n regels met op elke regel de positie van een vliegtuig, in de
vorm van een x- en een y-coordinaat. Dit zijn niet-negatieve gehele getallen ≤ 10 000 000,
gescheiden door een spatie. Als output geef je het kwadraat van de minimale afstand tussen
twee posities in de verzameling van n posities."

Om dit snel genoeg op te lossen wordt ***recursie*** gebruikt. Eerst worden de vliegtuigen gesorteerd op x coordinaat. Vervolgens wordt (recursief) bekeken of de vliegtuigen met de kleinste afstand in de linker- of rechterhelft van de middelste x coordinaat zitten. De base case voor deze recursie is als er maar 1 vliegtuig is, dan wordt de afstand als MAXINT ingesteld. Vervolgens wordt bekeken of de kortse afstand misschien over de middengrens gaat. Dit kan en moet in **O(1)** tijd, een uitleg van hoe dit precies kan is te vinden door Closest-Points problem te googlen.

Hiervoor heb ik een simpele Point class gemaakt, met een x- en y-coordinaat als properties.
Ook heb ik de ***IComparer interface*** gebruikt om Point-objecten op x- of y-coordinaat te kunnen vergelijken.

---------------
Dit is in feite het ***Closest Points probleem***
