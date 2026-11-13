public class History<T>
{
    private List<T> _items = new List<T>();
    public int Count
    {
        get
        {
            return _items.Count;
        }
    }
    public void Add(T item)
    {
        _items.Add(item);
    }
    public List<T> GetSnapshot()
    {
        return new List<T>(_items); 
    }
    public void Clear()
    {
        // TODO: Tøm historikken.
        _items.Clear();
    }
}
