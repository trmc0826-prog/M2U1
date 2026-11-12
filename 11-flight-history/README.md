# Oppgave 11 — Flight History

**Hovedfokus:** generics kombinert med innkapsling og kopier  
**Forkunnskaper:** Oppgave 06, 09 og referansetyper fra uke 4.  
**Anslått tid:** 30–45 minutter.

## Før du begynner

En samlingskopi har sin egen liste, men kopierer ikke automatisk objektene inni. new List<T>(existingItems) lager en ny liste med elementene fra existingItems. Med int og string kan vi her undersøke listestrukturen uten å innføre kloning av mutable objekter. Denne historikken skal ikke implementere angre-funksjonalitet.

## Oppdrag

1. Fullfør History<T>: Add oppbevarer en verdi; Count viser antallet.
2. GetSnapshot skal returnere en ny liste med historikkens elementer i innsettingsrekkefølge.
3. Clear skal tømme historikken. Behold listen privat.
4. Test med string og int. Endre en returnert liste og kontroller at historikkens antall er uendret.
5. Test også at et gammelt øyeblikksbilde av listen ikke vokser når historikken får et nytt element.

## Test selv

| Handling | Forventning |
|---|---|
| Ny historikk, GetSnapshot | Tom liste |
| Add("Launch"), Add("Orbit") | Count 2; kopi inneholder Launch, Orbit |
| Fjern alle elementer fra kopien | Historikken har fortsatt Count 2 |
| Hent ny kopi, legg til "Landing" i historikken | Kopien har Count 2; historikken har Count 3 |
| Clear på historikken | Count 0; tidligere kopi har fortsatt Count 2 |

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hva vil fremdeles være delt dersom T senere er en klasse med endringsbare egenskaper?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 11-flight-history
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
