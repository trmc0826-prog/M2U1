# Refleksjon — Twin Recorders

## Plan før koding

Lese gjennom klassene og finne ut hva som er likt og forskjellig.
Putte inn clear og teste

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |

## Testlogg

| Inndata eller handling        | Forventet resultat      | Faktisk resultat |
| ----------------------------- | ----------------------- | ---------------- |
| Add("Orbit")                  | TextRecorder Count: 1   | 1                |
| Add(7)                        | NumberRecorder Count: 1 | 1                |
| Contains("Orbit")             | True                    | True             |
| Contains(7)                   | True                    | True             |
| Contains("Landing")           | False                   | False            |
| Contains(9)                   | False                   | False            |
| Clear() på begge              | Begge Count: 0          | 0 og 0           |
| Contains("Orbit") etter Clear | False                   | False            |
| Contains(7) etter Clear       | False                   | False            |
| Clear() igjen på begge        | Begge Count: 0          | 0 og 0           |

## Forklaring

Hva måtte vært forskjellig i reglene for at du ville beholdt to separate klasser?

Mitt svar: Hvis klassene hatt forskjellige regler for hvordan verdier legges til.

## Hva endret jeg, og hvorfor?

Puttet inn clear() i begge klassene med å bruke items.clear()
slik at innholdet listene kan tømmes.

Jeg la også til flere tester i program.cs for å kontrollere count/contains() og clear()

## Hva trenger jeg mer øving på?

Å gjenkenne duplisert kode og forstå når man kan samle logikk
