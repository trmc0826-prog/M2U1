public class History<T>
{
    private List<T> _items = new List<T>();
    public int Count
    {
        get
        {
            // TODO: Les antallet fra samlingen.
            return 0;
        }
    }
    public void Add(T item)
    {
        // TODO: Oppbevar elementet.
    }
    public List<T> GetSnapshot()
    {
        // TODO: Returner en samlingskopi med eksisterende elementer.
        return new List<T>();
    }
    public void Clear()
    {
        // TODO: Tøm historikken.
    }
}
