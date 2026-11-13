# Refleksjon — Paired Beacons

## Plan før koding

Lage en generisk klasse Pair<T> som kan lagre to verdier av samme datatype
Lage konstruktør som tar imot to verdier og lagrer dem i egenskapene first og second
Lage metode showpair<T> som skriver ut verdiene, teste med string, int


## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| Opprett Pair<string>("North", "South") og kall ShowPair | North og South på hver sin linje | North, South |
| Opprett Pair<int>(12, 24) og kall ShowPair | 12 og 24 på hver sin linje | 12, 24 |
| Opprett Pair<Beacon> med navn A og B | First.Name = A, Second.Name = B | A, B |
| Opprett nytt Pair<string> med East og West | Første par er fortsatt North og South | North, South |
| Forsøk directions.First = "East" | Kompileringsfeil | CS0200: Property is read only |
| Fjern feilkallet og kjør igjen | Programmet bygger og kjører | Kjørte uten feil |
| Forbedre variabelnavnet Beacons til beacons | Samme funksjonalitet og utskrift | Uendret utskrift |


## Forklaring

Hvorfor trenger ikke Pair<T> vite hvilke egenskaper Beacon har? Hva gir generics her som to separate klasser ikke gir?

Mitt svar: Pair<T> trenger ikke vite hvilke egenskaper Beacon har, fordi klassen bare skal lagre to verdier og gjøre dem tilgjengelige gjennom First og Second.

Når vi bruker Pair<Beacon>, blir T erstattet med Beacon. Vi kan derfor hente ut objektene og bruke .Name i Program.cs, uten at Pair<T> trenger å kjenne til denne egenskapen.

## Hva endret jeg, og hvorfor?

Lagde pair.cs med generisk klasse. to egenskaper og en konstruktør som tar imot 2 verdier

lagde pairdisplay.cs med ShowPair<T>

Testet klassen med tekst, heltall og to beacon objekter - 

Prøvde å endre First direkte fra program.cs men fikk kompileringsfeil siden egenskapen er ksrivebeskyttet.

## Hva trenger jeg mer øving på?
mer øving på konstruktører, spesielt paramterene og hvordan de brukes til å sette verdier i egenskaper.