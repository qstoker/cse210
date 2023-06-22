public class Reference
{
    string _book;
    int _chapter;
    int _verse;
    int _endVerse;

    public Reference(string book, int chapter, int verse) { }

    public Reference(string book, int chapter, int startVerse, int endVerse) { }

    public string GetDisplaytext()
    {
        return "";
    }
}
