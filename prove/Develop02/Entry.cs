public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string csvEntry)
    {
        string[] entryParts = csvEntry.Split(";");
        _date = entryParts[0];
        _promptText = entryParts[1];
        _entryText = entryParts[2];
    }
    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

    public string ToCSV()
    {
        return string.Join(";", _date, _entryText, _promptText);
    }

}