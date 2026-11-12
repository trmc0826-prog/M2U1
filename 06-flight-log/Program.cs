FlightLog log = new FlightLog();
Console.WriteLine(log.Count);
log.Add("Launch");
log.Add("Orbit");
Console.WriteLine(log.Count);
log.Clear();
Console.WriteLine(log.Count);
// TODO: Legg til de resterende testene.
