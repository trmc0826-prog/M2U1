Recorder<string> recorder = new Recorder<string>();
Recorder<int> numberRecorder = new Recorder<int>();

recorder.Add("Orbit");

Console.WriteLine(recorder.Count);

Console.WriteLine(recorder.Contains("Orbit"));

Console.WriteLine(numberRecorder.Count);

Console.WriteLine(numberRecorder.Contains(7));
numberRecorder.Add(7);
numberRecorder.Add(7);
Console.WriteLine(numberRecorder.Count);
Console.WriteLine(numberRecorder.Contains(7));
numberRecorder.Clear();
Console.WriteLine(numberRecorder.Count);
Console.WriteLine(numberRecorder.Contains(7));
Console.WriteLine(recorder.Count);

Console.WriteLine(recorder.Contains("orbit"));
// TODO: Oppdater kallene når klassen er generalisert, og test med int.
