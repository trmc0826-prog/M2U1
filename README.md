# Week 1 — Clean Code and Generics

Tolv minioppgaver med romfartstema, selvstendige .NET 10-konsollprosjekter og gradvis mindre startstøtte. Vi går fra lesbar kode og konkrete typer til egne generiske klasser og metoder. 

## Oppgaver

| Nr. | Oppgave | Hovedfokus |
|---|---|---|
| 01 | [Mission Cleanup](01-mission-cleanup/README.md) | navn, innrykk og lesbarhet |
| 02 | [Cargo Calculator](02-cargo-calculator/README.md) | metodeansvar og atferdsbevarende refaktorering |
| 03 | [Launch Rules](03-launch-rules/README.md) | tidlig retur og tester som bevarer regler |
| 04 | [Signal Types](04-signal-types/README.md) | type, verdi, parameter og argument |
| 05 | [Sample Capsule](05-sample-capsule/README.md) | konstruktør, privat felt og instansmetoder |
| 06 | [Flight Log](06-flight-log/README.md) | privat samling og beregnet Count |
| 07 | [Twin Recorders](07-twin-recorders/README.md) | gjenkjenne duplisering før generalisering |
| 08 | [Typed Lockers](08-typed-lockers/README.md) | bruke en ferdig generisk klasse |
| 09 | [Universal Recorder](09-universal-recorder/README.md) | lage en generisk klasse fra konkrete implementasjoner |
| 10 | [Signal Printer](10-signal-printer/README.md) | generisk metode i en ikke-generisk klasse |
| 11 | [Flight History](11-flight-history/README.md) | generics kombinert med innkapsling og kopier |
| 12 | [Paired Beacons](12-paired-beacons/README.md) | selvstendig overføring og begrunnet kodekvalitet |

## Før du starter

Du trenger .NET 10 **SDK**, en kodeeditor og forkunnskapene fra C# Basic uke 1–4. Kontroller SDK med `dotnet --list-sdks`: minst én linje skal begynne med 10.0. Du trenger ingen eksterne NuGet-pakker.

Les oppgavens README før Program.cs. Hver oppgave har nødvendig begrepsstøtte, krav, tester, REFLEKSJON.md og AGENTS.md. Filnavn og kode er på engelsk; forklaringene er på norsk.

## Kjør en oppgave

Åpne terminalen i denne ukemappen:

```bash
dotnet run --project 01-mission-cleanup
dotnet run --project 08-typed-lockers
```

Bruk Tab for å fullføre mappenavn og pil opp for å hente forrige kommando. Ctrl+C stopper et kjørende program. Hvis prosjektet ikke blir funnet, kontroller at du står i ukemappen. Inne i en oppgavemappe holder `dotnet run`.

## Arbeidsmønster

1. Les oppgaven og fagforklaringen. Forutsi resultatet.
2. Kjør startkoden. TODO-er og midlertidige returverdier er bevisst uferdige.
3. Skriv litt kode selv, lagre og kjør på nytt.
4. Prøv testtabellen og noter forventet/faktisk resultat.
5. Forklar hva du gjorde i REFLEKSJON.md.

Startprosjektene er laget for å kunne bygges. Oppgave 04 og 08 ber deg aktivere en typefeil midlertidig: fjern den igjen etter at du har forklart den. Det følger ingen elevfasit med.

## Bruk av KI

KI kan forklare, stille spørsmål, hjelpe med feilmeldinger og foreslå tester. Rotens og oppgavemappenes AGENTS.md ber KI opptre som veileder og la deg gjøre endringene selv. Dette er veiledningsinstruksjoner, ikke en teknisk garanti for hvordan alle KI-verktøy oppfører seg.