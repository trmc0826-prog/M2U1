FlightLog log = new FlightLog();
Console.WriteLine(log.Count);
log.Add("Launch");
log.Add("Orbit");
Console.WriteLine(log.Count);
log.Clear();
Console.WriteLine(log.Count);

log.Add("");
Console.WriteLine(log.Count);

FlightLog secondLog = new FlightLog();
Console.WriteLine(secondLog.Count);
