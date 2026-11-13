History<string> history = new History<string>();
history.Add("Launch");
history.Add("Orbit");
List<string> snapshot = history.GetSnapshot();
Console.WriteLine(history.Count);
Console.WriteLine(snapshot.Count);
snapshot.Clear();
Console.WriteLine(history.Count);

// TODO: Legg til resten av testene, også med int.

List<string> secondSnapshot = history.GetSnapshot();
history.Add("Landing");
Console.WriteLine(secondSnapshot.Count);
Console.WriteLine(history.Count);

history.Clear();
Console.WriteLine(history.Count);
Console.WriteLine(secondSnapshot.Count);

History<int> numberHistory = new History<int>();
numberHistory.Add(42);
numberHistory.Add(7);
Console.WriteLine(numberHistory.Count);


List<int> thirdSnapshot = numberHistory.GetSnapshot();
numberHistory.Clear();
Console.WriteLine(numberHistory.Count);
Console.WriteLine(thirdSnapshot.Count);

History<string> emptyHistory = new History<string>();
Console.WriteLine(emptyHistory.GetSnapshot().Count);