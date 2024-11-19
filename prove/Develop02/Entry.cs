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

        string[] entryParts = csvEntry.Split("\",\"");
        _date = entryParts[0].Trim('\"');
        _promptText = entryParts[1].Trim('\"');;
        _entryText = entryParts[2].Trim('\"');;
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }

    public string ToCSV()
    {
        string[] dataParts = [
            _date,
            _promptText,
            _entryText,
        ];

        string csvLine = "";
        foreach(string data in dataParts) 
        {
            csvLine += $"\"{data}\",";
        }
        csvLine = csvLine.Trim(',');

        return csvLine;
    }
}