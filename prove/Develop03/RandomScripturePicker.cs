public class RandomScripturePicker
{
    private Scripture[] _scriptures;

    public RandomScripturePicker(string csvFilename, string csvDelimiter)
    {
        string[] fileLines = File.ReadAllLines(csvFilename);
        _scriptures = new Scripture[fileLines.Length];

        for (int i = 0; i < fileLines.Length; i++)
        {
            _scriptures[i] = GetScriptureFromCsvLine(fileLines[i], csvDelimiter);
        }
    }

    public Scripture GetRandomScripture()
    {
        return _scriptures[new Random().Next(_scriptures.Length)];
    }

    private Scripture GetScriptureFromCsvLine(string csvLine, string csvDelimiter)
    {
        string[] lineData = csvLine.Split(csvDelimiter);

        string book = lineData[0];
        int chapter = int.Parse(lineData[1]);
        int startVerse = int.Parse(lineData[2]);
        int endVerse = string.IsNullOrWhiteSpace(lineData[3]) ? startVerse : int.Parse(lineData[3]);
        string text = lineData[4];

        return new Scripture(new Reference(book, chapter, startVerse, endVerse), text);
    }
}