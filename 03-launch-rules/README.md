# Oppgave 03 — Launch Rules

**Hovedfokus:** tidlig retur og tester som bevarer regler  
**Forkunnskaper:** Oppgave 02; bool, sammenligninger og if.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

En tidlig retur avslutter en metode med en gang svaret er kjent. Det kan redusere unødvendig nesting. Eksempel: En metode som vurderer tilgang kan først avvise et utløpt kort. Normaltilfellet kommer etter avvisningene. Kortest mulig kode er ikke målet; reglene skal være lette å lese.

## Oppdrag

1. Les CanLaunch og skriv de tre avvisningsreglene i vanlig språk.
2. Refaktorer metoden til tidlige returer. Behold signatur og oppførsel.
3. Ikke bruk else, ternær operator eller ett samlet bool-uttrykk i løsningen: her øver vi på tidlige returer.
4. Kjør alle testtilfellene, og dokumenter forventet og faktisk verdi.

## Test selv

| crewCount | fuel | isHatchClosed | Returverdi |
|---|---|---|---|
| 3 | 50 | true | true |
| 2 | 50 | true | false |
| 3 | 49 | true | false |
| 3 | 50 | false | false |
| 4 | 80 | true | true |

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hvorfor er dette refaktorering og ikke en ny oppskytingsregel?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 03-launch-rules
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
