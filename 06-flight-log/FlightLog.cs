public class FlightLog
{
    private List<string> _entries = new List<string>();

    public int Count
    {
        get
        {
            return _entries.Count;
        }
    }

    public void Add(string entry)
    {
        _entries.Add(entry);
    }

    public void Clear()
    {
        _entries.Clear();
    }
}
