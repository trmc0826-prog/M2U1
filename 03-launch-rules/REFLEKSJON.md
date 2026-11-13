# Refleksjon — Launch Rules

## Plan før koding

Se gjennom eksisterende koden, prøve å forstå hva som kreves for koden godkjennes. Prøve å gjøre den enklere ved bruk av early returns uten å få "feil" resultat.

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
Crew Fuel Hatch closed Expected Actual
3 50 true True True
2 50 true False False
3 49 true False False
3 50 false False False
4 80 true True True

## Forklaring

Hvorfor er dette refaktorering og ikke en ny oppskytingsregel?

Mitt svar: Vi har ikke endret reglene for oppskyting, bare hvordan koden funker. Programmet har samme krav og gir samme resultat.

## Hva endret jeg, og hvorfor?

Jeg fjerna de nestede if/else blokkene og erstattet dem med separerte if-setninger og tidligere returns. Gjør koden lettere å lese og forstå.

## Hva trenger jeg mer øving på?

å bli tryggere på når jeg bør bruke return/early return. Forstå unødvendige if/else-chains
