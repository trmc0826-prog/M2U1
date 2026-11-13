# Refleksjon — Sample Capsule

## Plan før koding

Lese gjennom stringcapsule-klassen og forstå konstruktøren, private feltet og metodene. Teste og fullføre koden og at objektene fungerer uavhengig av hverandre

## Testlogg

| Inndata eller handling   | Forventet resultat         | Faktisk resultat           |
| ------------------------ | -------------------------- | -------------------------- |
| Opprett first med "dust" | dust                       | dust                       |
| Opprett second med "ice" | ice                        | ice                        |
| first.Replace("rock")    | first = rock, second = ice | first = rock, second = ice |
| first.Replace("")        | blank linje                | blank linje                |

## Forklaring

Hvorfor skal \_content være et instansfelt og ikke static?

Mitt svar:
Fordi hvert objekt skal ha sitt eget innhold. Hvis \_content hadde vært static, ville alle objektene delt den samme verdien. Da kunne endring av first også påvirket second.

## Hva endret jeg, og hvorfor?

Jeg fullførte konstruktøren slik at den lagrer teksten i \_content. Deretter endret jeg Read() slik at den returnerer innholdet, og Replace() slik at den kan oppdatere det.

## Hva trenger jeg mer øving på?

Å forstå forskjellen mellom konstruktører og vanlige metoder
