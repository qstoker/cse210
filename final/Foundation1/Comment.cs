public class Comment
{
    string _name;
    string _content;

    public Comment(string name, string content)
    {
        _name = name;
        _content = content;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetContent()
    {
        return _content;
    }
}
