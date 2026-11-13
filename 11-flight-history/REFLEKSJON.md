# Refleksjon — Flight History

## Plan før koding

gå igjennom history<t> og fullføre metodene for å legge til, telle og fjerne elementer. bruke getsnapshot sånn at den lager en kopi av listen.


## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| Add("Launch"), Add("Orbit") | History Count: 2 | 2 |
| GetSnapshot() etter to Add | Snapshot Count: 2 | 2 |
| Clear() på snapshot | History Count: 2 | 2 |
| Opprett secondSnapshot før Add("Landing") | Snapshot Count: 2 | 2 |
| Add("Landing") i historikken | History Count: 3 | 3 |
| Clear() på historikken | History Count: 0 | 0 |
| secondSnapshot etter Clear | Snapshot Count: 2 | 2 |
| History<int> med 42 og 7 | Count: 2 | 2 |
| Clear() på numberHistory | Count: 0 | 0 |
| thirdSnapshot etter Clear | Count: 2 | 2 |
| Ny tom historikk, GetSnapshot().Count | 0 | 0 | 




## Forklaring

Hva vil fremdeles være delt dersom T senere er en klasse med endringsbare egenskaper?

Mitt svar: Begge listene vil forstatt kunne innehold referanser til samme objektene. Om vi endrer egenskapen på et objekt gjennom kopien vil endringen også være synlig i originalen.

## Hva endret jeg, og hvorfor?

Count til å retunere _items.count + add() og clear() for å legge til/fjerne elementer
endret snapshot til å retunere new list<t>(_items) sånn at vi får en ny liste med de eksistrende elementene.

teste med både string og int for å se at historikken gir en tom liste

## Hva trenger jeg mer øving på?

bedre forståelse for kopi/referanse med lister og objekter. Mer øving med getsnapshot().count