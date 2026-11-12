string label = "READY";
var retries = 3;
List<string> messages = new List<string> { label };
string result = RepeatLabel(label);
Console.WriteLine(result);
// messages.Add(42);
// retries = "three";
// TODO: Utforsk én feillinje om gangen, og legg til en gyldig melding.
static string RepeatLabel(string message)
{
    return $"Echo: {message}";
}
