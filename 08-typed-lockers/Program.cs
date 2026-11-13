Console.WriteLine("Typed Lockers");

Locker<string> textLocker = new Locker<string>("Beacon");
Console.WriteLine(textLocker.Read());

Locker<int> numberLocker = new Locker<int>(42);
Console.WriteLine(numberLocker.Read());

textLocker.Replace("Relay");
numberLocker.Replace(99);

Console.WriteLine(textLocker.Read());
Console.WriteLine(numberLocker.Read());



