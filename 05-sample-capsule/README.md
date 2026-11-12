# Oppgave 05 — Sample Capsule

**Hovedfokus:** konstruktør, privat felt og instansmetoder  
**Forkunnskaper:** Oppgave 04; klasser og objekter fra uke 3.  
**Anslått tid:** 15–25 minutter.

## Før du begynner

En konstruktør kjører når et objekt opprettes. Et privat felt oppbevarer tilstand for det enkelte objektet. En instansmetode kan lese eller endre denne tilstanden. To objekter av samme klasse har hver sin tilstand. Denne oppgaven bruker bare string, uten generics.

## Oppdrag

1. Fullfør StringCapsule slik at konstruktøren oppbevarer teksten i _content.
2. La Read returnere gjeldende innhold, og Replace erstatte det.
3. Behold feltet privat. Ingen konsollutskrift inne i klassen.
4. Test begge objektene før og etter utskifting. Objekt nummer to skal være uendret.

## Test selv

| Handling | Forventet innhold |
|---|---|
| Opprett first med "dust" | first.Read() er "dust" |
| Opprett second med "ice" | second.Read() er "ice" |
| first.Replace("rock") | first er "rock", second er fortsatt "ice" |
| first.Replace("") | first er tom streng |

Noter forventet og faktisk resultat. Startkoden er ment å kunne bygges, men TODO-er kan gi ufullstendige resultater. En vellykket kompilering betyr ikke at oppgaven er løst.

## Forklar med egne ord

Hvorfor skal _content være et instansfelt og ikke static?

## Ferdig når

- Kravene er oppfylt og testtilfellene er prøvd.
- Prosjektet bygger uten bevisste feilkall.
- Du kan forklare endringene og har fylt ut REFLEKSJON.md.

## Kjøring

Fra ukemappen:

```bash
dotnet run --project 05-sample-capsule
```

Fra oppgavemappen kan du bruke `dotnet run`. Bruk `dotnet build` samme sted for bare å kompilere.
