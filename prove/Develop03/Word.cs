public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        char[] displayChars = _text.ToCharArray();

        if (_isHidden)
        {
            for (int i = 0; i < displayChars.Length; i++)
            {
                displayChars[i] = '_';
            }
        }

        return new string(displayChars);
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }
}