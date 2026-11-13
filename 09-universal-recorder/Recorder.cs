public class Recorder<T>
{
    private List<T> _items = new List<T>();
    public int Count { get { return _items.Count; } }
    public void Add(T item) { _items.Add(item); }
    public bool Contains(T item) { return _items.Contains(item); }
    public void Clear() { _items.Clear(); }
}
// TODO: Gjør denne konkrete tekstbeholderen generisk.
