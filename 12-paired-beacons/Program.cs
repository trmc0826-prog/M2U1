Console.WriteLine("Paired Beacons");


Pair<string> directions = new Pair<string>("North", "South");

PairDisplay.ShowPair<string>(directions);

Pair<int> numbers = new Pair<int>(12, 24);

PairDisplay.ShowPair<int>(numbers);

Beacon A = new Beacon("A");
Beacon B = new Beacon("B"); 

Pair<Beacon> beacons = new Pair<Beacon>(A, B);

Console.WriteLine($"{beacons.First.Name}, {beacons.Second.Name}");

Pair<string> moreDirections = new Pair<string>("East", "West");

Console.WriteLine($"{directions.First}, {directions.Second}");


// TODO: Planlegg, opprett Pair.cs og PairDisplay.cs, og skriv testkallene her.

