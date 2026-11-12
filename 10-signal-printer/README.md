# Oppgave 10 — Signal Printer

**Hovedfokus:** generisk metode i en ikke-generisk klasse  
**Forkunnskaper:** Oppgave 09; statiske metoder og foreach.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

En metode kan ha sin egen typeparameter selv om klassen ikke har det. I en signatur som static void Inspect<T>(T value) gjelder T for metoden. Typeargumentet kan ofte utledes fra argumentene; vis det eksplisitt først. En ubegrenset T lover ikke at verdiene kan summeres eller har en Name-egenskap.

## Oppdrag

1. Gjør PrintStrings om til PrintItems<T> med en List<T>-parameter.
2. Behold foreach og én utskrift per element. Klassen SignalPrinter skal ikke være generisk.
3. Kall metoden med strenger og heltall. Skriv typeargument eksplisitt i det første kallet.
4. Prøv et kall uten eksplisitt typeargument og forklar hvordan kompilatoren kan finne typen.
5. Test en tom liste. Ikke bruk LINQ eller overlast én metode per datatype.

## Test selv

| Inndata | Forventet utskrift |
|---|---|
| "SOS", "ACK" | SOS og ACK på hver sin linje |
| 4, 8 | 4 og 8 på hver sin linje |
| Tom List<int> | Ingen linjer fra metoden |

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hvor er T deklarert, og hvordan skiller dette seg fra Recorder<T>?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 10-signal-printer
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
