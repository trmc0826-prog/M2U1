var x = new List<string> { "Ada", "Bo", "Cy" };
// Skriv antallet.
Console.WriteLine($"Crew: {x.Count}");
// Oppdraget krever minst tre personer av sikkerhetshensyn.
if(x.Count>=3){Console.WriteLine("Ready");}
else{Console.WriteLine("Waiting");}
// TODO: Forbedre lesbarheten uten å endre resultatet.
