# Refleksjon — Universal Recorder

## Plan før koding

Gå gjennom recorder-klassen gjøre den generisk ved å bruke T istedet. Teste at klasse funker med både tall og tekst, og at metodene funker likt

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| Add("Orbit") og Count | 1 | 1 |
| Contains("Orbit") | True | True |
| Ny Recorder<int>, Count | 0 | 0 |
| Contains(7) før Add | False | False |
| Add(7) to ganger, Count | 2 | 2 |
| Contains(7) etter Add | True | True |
| Clear() på tallbeholder, Count | 0 | 0 |
| Contains(7) etter Clear | False | False |
| Count på tekstbeholder etter Clear på tallbeholder | 1 | 1 |
| Contains("orbit") | False | False |

## Forklaring

Hvorfor er det feil å erstatte absolutt alle typer i klassen med T?

Mitt svar: Fordi ikke alle datatypene i klassen skal være avhengige av hva vi lagrer. T brukest for verdiene som leggest til listen, mens count fortsatt må retunere int siden den teller antall elementer. Contains må retunere bool for å sjekke om en verdi finnes, true/false.

## Hva endret jeg, og hvorfor?

Endret recorder til recorder<T> og byttet ut string med T i listen og parameterne til add() & contains().

oppdaterte program så jeg kan bruke både rrecorder<string> og recorder<int>

testet å legge til verdier, søke etter dem og tømme listen. Sjekket at objektene ikke påvirket hverandre og at Orbit/orbit behandles som forskjeliige verider.

## Hva trenger jeg mer øving på?
framdeles å bli tryggere på generics. Generelle typeargument og metodene deres.