public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~!~{entry._promptText}~!~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~!~");

            Entry loadedEntry = new Entry();

            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];

            AddEntry(loadedEntry);
        }
    }
}
