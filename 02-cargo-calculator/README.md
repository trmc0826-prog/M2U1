# Oppgave 02 — Cargo Calculator

**Hovedfokus:** metodeansvar og atferdsbevarende refaktorering  
**Forkunnskaper:** Oppgave 01; statiske metoder, argumenter og returverdier fra uke 2.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

Refaktorering endrer struktur uten å endre avtalt oppførsel. En beregningsmetode kan motta verdier og returnere resultatet, mens kalleren tar seg av utskrift. Bruk de samme testdataene før og etter endringen.

## Oppdrag

1. Kjør og noter resultatene før du endrer noe.
2. Opprett en statisk metode CalculateRemainingCapacity med to int-parametere: capacity og usedCapacity. Den skal returnere ledig kapasitet.
3. Flytt den gjentatte beregningen inn i metoden og kall den begge steder.
4. Behold utskriftene hos kalleren. Metoden skal ikke bruke Console.
5. Bruk vanlige metodekropper og eksplisitt returtype. Ingen nye klasser er nødvendig.

## Test selv

| capacity | usedCapacity | Returverdi |
|---|---|---|
| 12 | 5 | 7 |
| 20 | 8 | 12 |
| 5 | 5 | 0 |
| 0 | 0 | 0 |

For denne oppgaven er tallene ikke-negative, og brukt kapasitet er aldri større enn kapasiteten.

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hva er parameterne, argumentene og returverdien i ett av kallene dine?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 02-cargo-calculator
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
