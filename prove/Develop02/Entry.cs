public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string csvEntry = null)
    {
        if (csvEntry == null)
        {
            return;
        }

        string[] entryParts = csvEntry.Split(";");
        _date = entryParts[0];
        _promptText = entryParts[1];
        _entryText = entryParts[2];
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }

    public string ToCSV()
    {
        return string.Join(";", _date, _entryText, _promptText);
    }

}