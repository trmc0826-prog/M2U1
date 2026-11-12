# Oppgave 07 — Twin Recorders

**Hovedfokus:** gjenkjenne duplisering før generalisering  
**Forkunnskaper:** Oppgave 06 og metoder som returnerer bool.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

To klasser kan ha samme regler selv om de oppbevarer ulike typer. DRY handler om å unngå at samme kunnskap må vedlikeholdes flere steder. Vi undersøker først om reglene virkelig er like; vi gjør ikke alt generisk bare fordi koden ligner.

## Oppdrag

1. Les TextRecorder og NumberRecorder. Marker linjene som er like og delene som bare skiller seg i type eller navn.
2. Begge skal få en Clear-metode. Implementer den samme oppførselen i begge.
3. Legg til en verdi, kontroller Count og Contains, tøm, og kontroller på nytt.
4. Skriv hvilke steder som måtte endres to ganger. Ikke lag generics ennå.

## Test selv

| Handling | Forventning |
|---|---|
| Legg til "Orbit" / 7 | Begge har Count 1 |
| Søk etter "Orbit" / 7 | Begge gir true |
| Søk etter "Landing" / 9 | Begge gir false |
| Clear på begge | Begge har Count 0 og finner ikke gammel verdi |
| Clear på tom beholder | Count forblir 0 |

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hva måtte vært forskjellig i reglene for at du ville beholdt to separate klasser?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 07-twin-recorders
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
