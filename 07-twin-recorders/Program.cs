TextRecorder text = new TextRecorder();
NumberRecorder numbers = new NumberRecorder();
text.Add("Orbit");
numbers.Add(7);
Console.WriteLine(text.Contains("Orbit"));
Console.WriteLine(numbers.Contains(7));
// TODO: Kall Clear på begge og kontroller tilstanden.
