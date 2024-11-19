public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine(entry.ToCSV());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] csvEntries = File.ReadAllLines(filename);
        foreach (string csvEntry in csvEntries)
        {
            _entries.Add(new Entry(csvEntry));
        }
    }
}