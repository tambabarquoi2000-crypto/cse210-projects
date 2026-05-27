public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "";
        _isHidden = false;
    }

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string nText = "";
        if (_isHidden)
        {
            for(int i=0; i<_text.Length; i++)
            {
                
                nText += "_ ";
            }

            return nText.Trim();
        }

        else
        {
            return _text.Trim();
        }
    }

}