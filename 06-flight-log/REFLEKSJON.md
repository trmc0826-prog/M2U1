# Refleksjon — Flight Log

## Plan før koding

Gå gjennom FlightLog-klassen og fullføre de tre metodene for å legge til, telle og fjerne loggoppføringer. Deretter teste at listen fungerer som forventet, og at to forskjellige objekter har hver sin liste.

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| ---------------------- | ------------------ | ---------------- |

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| ---------------------- | ------------------ | ---------------- |
| Ny FlightLog           | Count: 0           | 0                |
| Add("Launch")          | Count: 1           | 1                |
| Add("Orbit")           | Count: 2           | 2                |
| Clear()                | Count: 0           | 0                |
| Clear() igjen          | Count: 0           | 0                |
| Add("")                | Count: 1           | 1                |
| Ny secondLog           | Count: 0           | 0                |

## Forklaring

Hva kan gå galt hvis både listen og et eget tellerfelt lagrer antallet?

Mitt svar:
Hvis vi bruker både listen og en egen teller, blir det ubalansert. For eksempel hvis vi legger til eller fjerner noe fra listen, men glemmer å oppdatere telleren. Ved å bruke \_entries.Count får vi alltid antallet direkte fra listen.

## Hva endret jeg, og hvorfor?

Endret count så den retunerer antallet fra \_entries istedenfor alltid å returnere 0

fullførte add/clear så man kan legge til og fjerne oppføringer fra listen

## Hva trenger jeg mer øving på?

Å bli tryggere på hvordan klasser bruker private lister, og hvordan metoder kan endre innholdet uten at listen er tilgjengelig direkte fra resten av programmet.
