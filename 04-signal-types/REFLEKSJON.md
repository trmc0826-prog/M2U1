# Refleksjon — Signal Types

## Plan før koding

gå gjennom variabler og se hvilke data typer de har. T

#

## Testlogg

| Inndata eller handling      | Forventet resultat  | Faktisk resultat |
| --------------------------- | ------------------- | ---------------- |
| Opprinnelig program         | Echo: READY         | Echo: READY      |
| messages.Add(42)            | Kompileringsfeil    | CS1503           |
| retries = "three"           | Kompileringsfeil    | CS0029           |
| Legge til "LAUNCH" i listen | Antall meldinger: 2 | 2                |

## Forklaring

Er string i List<string> en tekstverdi eller en type? Hvorfor kan ikke var retries senere bli tekst?

Mitt svar: string er en datatype som forteller at listen kun kan inneholde tekst.
var bestemmer datatypen basert på verdien som blir oppgitt.
Siden retries starter med tallet 3, blir den en int og kan ikke senere få en tekstverdi.

## Hva endret jeg, og hvorfor?

testet feillinjene for å se hva som skjedde med feil datatype. La til en ny melding i listen med add() og brukte count for å kontrollere at listen inneholdt to meldinger.

## Hva trenger jeg mer øving på?

å få bedre forståelse på forskjellen mellom variabler/datatyper/paramtere/argumenter. Spessielt når de brukest sammen med metoder/lister.
