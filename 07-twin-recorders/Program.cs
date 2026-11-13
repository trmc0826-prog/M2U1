
TextRecorder text = new TextRecorder();
NumberRecorder numbers = new NumberRecorder();

text.Add("Orbit");
numbers.Add(7);

Console.WriteLine(text.Count);
Console.WriteLine(numbers.Count);

Console.WriteLine(text.Contains("Orbit"));
Console.WriteLine(numbers.Contains(7));

Console.WriteLine(text.Contains("Landing"));
Console.WriteLine(numbers.Contains(9));

text.Clear();
numbers.Clear();

Console.WriteLine(text.Count);
Console.WriteLine(numbers.Count);

Console.WriteLine(text.Contains("Orbit"));
Console.WriteLine(numbers.Contains(7));

text.Clear();
numbers.Clear();

Console.WriteLine(text.Count);
Console.WriteLine(numbers.Count);