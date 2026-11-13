public class SignalPrinter
{
    public static void PrintItems<T>(List<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
// TODO: Generaliser metoden, ikke klassen.
