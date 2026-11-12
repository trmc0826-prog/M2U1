# Oppgave 09 — Universal Recorder

**Hovedfokus:** lage en generisk klasse fra konkrete implementasjoner  
**Forkunnskaper:** Oppgave 07–08.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

En generisk klasse er nyttig når oppførselen er den samme for flere typer. Typeparameteren knytter sammen hva klassen mottar, lagrer og eventuelt returnerer. Ikke alle typer i klassen skal byttes til T: Count er fortsatt int, og Contains returnerer fortsatt bool.

## Oppdrag

1. Gjør den ferdige Recorder-klassen generisk som Recorder<T>.
2. Generaliser innholdstypen i feltet og i metodene som mottar elementer. Behold Count og bool-resultatet som de er.
3. Oppdater Program.cs og bruk både Recorder<string> og Recorder<int>.
4. Begge skal støtte Add, Contains, Clear og Count med samme oppførsel.
5. Bruk én klassedefinisjon. Ikke bruk object, dynamic, casting eller interfaces.

## Test selv

| Tilfelle | Forventning |
|---|---|
| Ny Recorder<int> | Count 0, Contains(7) false |
| Legg til 7 to ganger | Count 2, Contains(7) true |
| Clear | Count 0, Contains(7) false |
| Tekstbeholder med "Orbit" | Contains("Orbit") true, Contains("orbit") false |
| To beholdere | Endring i én påvirker ikke den andre |

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hvorfor er det feil å erstatte absolutt alle typer i klassen med T?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 09-universal-recorder
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
