public class Locker<T>
{
    private T _content;

    public Locker(T content)
    {
        _content = content;
    }

    public T Read()
    {
        return _content;
    }

    public void Replace(T content)
    {
        _content = content;
    }
}
