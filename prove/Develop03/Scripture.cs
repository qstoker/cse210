public class Scripture
{
    Reference _reference;
    List<Word> _words;

    Scripture(Reference reference, string text) { }

    public void HideRandomWords(int numberToHide) { }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}
