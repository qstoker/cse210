public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] separatedText = text.Split(' ');

        foreach (string textPiece in separatedText)
        {
            Word word = new Word(textPiece);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = new Random().Next(0, _words.Count);

            // This ensures "numberToHide" isn't wasted on already hidden words
            // while still quitting properly if all words are hidden.
            if (_words[index].IsHidden() && !IsCompletelyHidden())
            {
                i--;
            }
            else
            {
                _words[index].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            displayText += (" " + word.GetDisplayText());
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }

    // This shows the whole scripture
    public void ShowAllWords()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }
}
