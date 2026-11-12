public class Recorder
{
    private List<string> _items = new List<string>();
    public int Count { get { return _items.Count; } }
    public void Add(string item) { _items.Add(item); }
    public bool Contains(string item) { return _items.Contains(item); }
    public void Clear() { _items.Clear(); }
}
// TODO: Gjør denne konkrete tekstbeholderen generisk.
