
var crewNames = new List<string> { "Ada", "Bo", "Cy" };

Console.WriteLine($"Crew: {crewNames.Count}");

// Oppdraget krever minst tre personer av sikkerhetshensyn.

if (crewNames.Count >= 3)
{
    Console.WriteLine("Ready");
}
else
{
    Console.WriteLine("Waiting");
}
