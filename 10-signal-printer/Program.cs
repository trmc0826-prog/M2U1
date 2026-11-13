List<string> messages = new List<string> { "SOS", "ACK" };
SignalPrinter.PrintItems<string>(messages);

List<int> numbers = new List<int> {4, 8};
SignalPrinter.PrintItems(numbers);

List<int> emptyNumbers = new List<int>();
SignalPrinter.PrintItems<int>(emptyNumbers);

// TODO: Oppdater kallet og legg til heltall og en tom liste.
