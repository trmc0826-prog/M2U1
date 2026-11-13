public class NumberRecorder
{
    private List<int> _items = new List<int>();
    public int Count { get { return _items.Count; } }
    public void Add(int item) { _items.Add(item); }
    public bool Contains(int item) { return _items.Contains(item); }
    public void Clear()
    {
        _items.Clear();
    }
}
