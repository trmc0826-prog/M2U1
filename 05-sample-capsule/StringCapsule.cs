public class StringCapsule
{
    private string _content = "";

    public StringCapsule(string content)
    {
        _content = content;
    }

    public string Read()
    {
        return _content;
    }

    public void Replace(string content)
    {
        _content = content;
    }
}
