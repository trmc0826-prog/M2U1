History<string> history = new History<string>();
history.Add("Launch");
history.Add("Orbit");
List<string> snapshot = history.GetSnapshot();
Console.WriteLine(history.Count);
Console.WriteLine(snapshot.Count);
snapshot.Clear();
Console.WriteLine(history.Count);
// TODO: Legg til resten av testene, også med int.
