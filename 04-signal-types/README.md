# Oppgave 04 — Signal Types

**Hovedfokus:** type, verdi, parameter og argument  
**Forkunnskaper:** Metoder og List<T> fra uke 2; oppgave 02.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

En type beskriver hvilke verdier og operasjoner som er tillatt. I int count = 4 er int typen, count variabelnavnet og 4 verdien. I List<string> er string et typeargument: listen tar imot strenger. var lar kompilatoren utlede en bestemt type; variabelen blir ikke typeløs.

## Oppdrag

1. Skriv typen til label, retries, messages og result i REFLEKSJON.md før du kjører.
2. Marker parameteren i RepeatLabel og argumentene i kallet.
3. Aktiver bare den første kommenterte feillinjen. Kjør dotnet build og forklar forventet og faktisk type. Kommenter linjen ut igjen.
4. Gjør det samme med den andre feillinjen. Avslutt med et byggbart prosjekt.
5. Legg til en gyldig melding og skriv ut antallet meldinger.

## Test selv

| Handling | Forventning |
|---|---|
| Opprinnelig program | `Echo: READY` |
| Aktiver messages.Add(42) | Kompileringsfeil: listen forventer string |
| Aktiver retries = "three" | Kompileringsfeil: retries er int |
| Legg til én streng i opprinnelig liste | Count blir 2 |

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Er string i List<string> en tekstverdi eller en type? Hvorfor kan ikke var retries senere bli tekst?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 04-signal-types
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
