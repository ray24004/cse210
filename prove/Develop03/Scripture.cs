public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        string[] textWords = text.Split(' ');
        foreach (string textWord in textWords)
        {
            _words.Add(new Word(textWord));
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string text = string.Join(' ', _words.Select(w => w.GetDisplayText()));

        return $"{reference} {text}";
    }

    public bool GetIsCompletelyHidden()
    {
        return _words.All(w => w.GetIsHidden());
    }

    public void HideWords(int amount)
    {
        List<Word> visibleWords = _words.Where(w => !w.GetIsHidden()).ToList();

        Random random = new Random();
        while (visibleWords.Count > 0 && amount > 0)
        {
            Word randomWord = visibleWords[random.Next(visibleWords.Count)];
            randomWord.Hide();
            visibleWords.Remove(randomWord);
            amount--;
        }
    }
}