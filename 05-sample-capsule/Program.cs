StringCapsule first = new StringCapsule("dust");
StringCapsule second = new StringCapsule("ice");
Console.WriteLine(first.Read());
Console.WriteLine(second.Read());
first.Replace("rock");
Console.WriteLine(first.Read());
Console.WriteLine(second.Read());
