# Oppgave 01 — Mission Cleanup

**Hovedfokus:** navn, innrykk og lesbarhet  
**Forkunnskaper:** Variabler, if/else, foreach og List<string>.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

Kodestil er felles avtaler om hvordan vi skriver kode. Bruk camelCase for lokale variabler og parametere, PascalCase for klasser, egenskaper og metoder, og _camelCase for private felt. Bruk fire mellomrom som innrykk og klammeparenteser rundt blokker. En stilendring skal ikke endre programmets resultat.

## Oppdrag

1. Kjør startkoden og noter utskriften i REFLEKSJON.md.
2. Gi alle lokale variabler navn som beskriver innholdet. Rett innrykk og blokker.
3. Fjern kommentaren som bare gjentar det neste kodelinjen gjør. Behold eller forbedre kommentaren som forklarer regelen.
4. Kjør igjen. Resultatet skal være identisk. Ikke legg til nye funksjoner eller metoder.

## Test selv

| Mannskap | Forventet resultat |
|---|---|
| Ada, Bo, Cy | `Crew: 3`, deretter `Ready` |
| Ada, Bo | `Crew: 2`, deretter `Waiting` |
| Ingen | `Crew: 0`, deretter `Waiting` |

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hvilken endring gjorde koden lettere å forstå uten å endre oppførselen?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 01-mission-cleanup
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
