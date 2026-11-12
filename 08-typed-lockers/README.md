# Oppgave 08 — Typed Lockers

**Hovedfokus:** bruke en ferdig generisk klasse  
**Forkunnskaper:** Oppgave 04–07; se generics_intro før oppgaven.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

I Locker<T> er T en typeparameter. Når vi skriver Locker<bool>, er bool typeargumentet. Den samme klassedefinisjonen kan brukes med ulike typer, men hvert slikt objekt beholder sin bestemte type. Konstruktøren heter Locker, uten <T> i selve konstruktørnavnet. Den ferdige klassen er læringsstøtte; denne oppgaven handler om å bruke den.

## Oppdrag

1. Les Locker.cs. Pek ut alle steder T brukes, og forklar rollen til hvert sted.
2. Opprett en Locker<string> med "Beacon" og en Locker<int> med 42 i Program.cs.
3. Les verdiene, erstatt dem med "Relay" og 99, og les dem igjen.
4. Forsøk midlertidig å sende tekst til tallskapets Replace. Forklar feilen og fjern feilkallet.
5. Ikke endre Locker.cs eller bruk object, dynamic eller casting.

## Test selv

| Objekt | Før Replace | Etter Replace |
|---|---|---|
| Tekstskap | Beacon | Relay |
| Tallskap | 42 | 99 |

Et tekstargument til tallskapets Replace skal avvises ved kompilering.

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hva er forskjellen mellom typeargumentet int og konstruktørargumentet 42?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 08-typed-lockers
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
