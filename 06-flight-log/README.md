# Oppgave 06 — Flight Log

**Hovedfokus:** privat samling og beregnet Count  
**Forkunnskaper:** Oppgave 05; List.Add og Count fra uke 2.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

Når en klasse eier en liste, kan den tilby noen få kontrollerte operasjoner. Antallet kan leses fra listen i stedet for å lagres i en ekstra teller som kan komme ut av takt. En egenskap med bare get kan leses av kalleren, men ikke tilordnes derfra.

## Oppdrag

1. Fullfør Add og Count i FlightLog. Alle strenger, også tom streng, er gyldige her.
2. Bruk _entries.Count som eneste sannhet om antallet. Ikke innfør et tellerfelt.
3. La Clear tømme listen. List.Clear() er en bibliotekmetode som fjerner alle elementene.
4. La samlingen forbli privat. Test to separate logger.

## Test selv

| Handling | Forventet Count |
|---|---|
| Ny logg | 0 |
| Add("Launch") | 1 |
| Add("Orbit") | 2 |
| Clear() | 0 |
| Clear() igjen | 0 |
| Add("") | 1 |

En annen, ny logg skal fortsatt ha Count 0.

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hva kan gå galt hvis både listen og et eget tellerfelt lagrer antallet?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 06-flight-log
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
