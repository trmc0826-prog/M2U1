# Oppgave 12 — Paired Beacons

**Hovedfokus:** selvstendig overføring og begrunnet kodekvalitet  
**Forkunnskaper:** Oppgave 01–11. Ingen nye språkfunksjoner.  
**Anslått tid:** 30–45 minutter.

## Før du begynner

Nå skal du bruke kjente konsepter i en ny sammenheng. Et par består av to verdier av samme type. Planlegg dataene, konstruktøren og de offentlige medlemmene før du skriver kode. Du trenger ingen arv, interfaces eller constraints for å oppbevare og vise verdier.

## Oppdrag

1. Skriv tre korte planpunkter i REFLEKSJON.md før kodingen.
2. Lag Pair<T> i Pair.cs. Konstruktøren skal motta to verdier. Egenskapene First og Second skal kunne leses utenfra, men ikke settes utenfra.
3. Lag en statisk generisk metode ShowPair<T> i en ikke-generisk klasse PairDisplay. Metoden tar et Pair<T> og skriver First og Second på hver sin linje.
4. Bruk klassen med string, int og den ferdige Beacon-klassen. For Beacon-paret: vis navnene via egenskapene i Program.cs; ShowPair trenger ikke spesialbehandle Beacon.
5. Kontroller alle testene. Gjennomfør så én begrunnet forbedring av lesbarheten og test igjen.
6. Ikke bruk object, dynamic, casting, records, primary constructors, arv eller interfaces.

## Test selv

| Par | Forventning |
|---|---|
| "North", "South" | First er North, Second er South; ShowPair skriver begge |
| 12, 24 | First er 12, Second er 24; ShowPair skriver begge |
| To Beacon-objekter med navn A og B | First.Name er A, Second.Name er B |
| Nytt par etter første par | Første par er uendret |
| Forsøk å tilordne First fra Program.cs | Kompileringsfeil; fjern feilkallet før levering |

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hvorfor trenger ikke Pair<T> vite hvilke egenskaper Beacon har? Hva gir generics her som to separate klasser ikke gir?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 12-paired-beacons
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
