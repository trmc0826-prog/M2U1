# Refleksjon — Typed Lockers

## Plan før koding

Lese gjennom generiske klassen se hvordan den funker, opprette to skap med forskjellige datatyper og teste read/replace
og se hva som skjer om vi bruker feil datatype


## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
|---|---|---|
| Opprett Locker<string>("Beacon") og Read() | Beacon | Beacon |
| Opprett Locker<int>(42) og Read() | 42 | 42 |
| Replace("Relay") og Read() | Relay | Relay |
| Replace(99) og Read() | 99 | 99 |
| numberLocker.Replace("Hello") | Kompileringsfeil | CS1503: cannot convert from 'string' to 'int' |
| Fjern feilkallet og kjør igjen | Programmet kjører uten feil | Kjørte uten feil |

## Forklaring

Hva er forskjellen mellom typeargumentet int og konstruktørargumentet 42?

Mitt svar: int bestemmer hvilken datatype skapet skal bruke, mens 42 er verdien som blir lagret i skapet når det oprettes

når vi bruker int kan vi bare lagre heltall

## Hva endret jeg, og hvorfor?

Laget lockerstring med verdien beacon og lockerint med verdi 42.

Brukte read for å hente verdiene og replace for å endre dem.

Testet å sende tekstverdi til tallskapets replace. Fikk kompileringsfeil siden metoden forventet int og ikke en string.

## Hva trenger jeg mer øving på?

å bli tryggere på generics og typeparameterene.