public class Word
{
    string _text;
    bool _isHidden;

    Word(string text) { }

    public void Hide() { }

    public void Show() { }

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        return "";
    }
}
