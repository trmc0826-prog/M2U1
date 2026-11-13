# Refleksjon — Signal Printer

## Plan før koding

gå gjennom signalprinter gjøre metoden generisk med T istedet for string. Teste at det funker med tekst, tall og tom liste

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| PrintItems<string>(messages) med "SOS", "ACK" | SOS og ACK på hver sin linje | SOS og ACK |
| PrintItems(numbers) med 4 og 8 | 4 og 8 på hver sin linje | 4 og 8 |
| PrintItems(emptyNumbers) med tom List<int> | Ingen utskrift | Ingen ekstra utskrift |
| Kall uten eksplisitt typeargument | C# finner riktig datatype | Programmet kjørte uten feil |


## Forklaring

Hvor er T deklarert, og hvordan skiller dette seg fra Recorder<T>?

Mitt svar: T er deklarert på metoden PrintItems<T>() og ikke på klassen. Betyr at metoden kan brukest med forskjellige datatyper uten at klassen må være generisk

## Hva endret jeg, og hvorfor?
Endret printstrings til printitems<T> og byttet T i parameteren og foreach-løkken

oppdaterte progrma.cs for å teste metoden med liste/tekst og en liste med heltall.

teste også å kalle metoden uten å skrive typeargument eksplisitt. csharp klarte å finne riktig datatype ut fra listen som ble kjørt.

## Hva trenger jeg mer øving på?
forskjellen på generiske klasser og generisk metoder.. bedre forståelse for hva c# kan finne automatisk.