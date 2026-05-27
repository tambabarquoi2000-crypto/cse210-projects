public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();

    public Scripture(string text)
    {
        _reference = new Reference("Proverb", 3, 1, 5);

        string[] _textparts = text.Split(" ");

        foreach (string word in _textparts)
        {
            Word wrdInTxtParts = new Word(word);
            _words.Add(wrdInTxtParts);
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }

        return $"{_reference.GetDisplayText()} {displayText.Trim()}";
    }

    public void HideRandomWords(int numOfWords)
    {
        Random rand = new Random();
        int hideWordIndex = 0;

        // Verify if the number of words not hidden is >= the number of words to hide

        int numOfWordNotHidden = 0;

        foreach (Word HIddenWord in _words)
        {
            if (!HIddenWord.IsHidden())
            {
                numOfWordNotHidden++;
            }
        }

        // Prevent the system from selecting a word that is alreaady hidden to be hidden

        for (int i = 0; i < numOfWords && i <= numOfWordNotHidden; i++)
        {


            hideWordIndex = rand.Next(0, _words.Count);

            if (_words[hideWordIndex].IsHidden())
        {

            while (_words[hideWordIndex].IsHidden() && numOfWordNotHidden >= 1)
            {
                hideWordIndex = rand.Next(0, _words.Count);
            }

            _words[hideWordIndex].Hide();
            numOfWordNotHidden --;
        }

        else
        {
            _words[hideWordIndex].Hide();
        }

    }
        }
    public bool IsCompletelyHidden()
    {
        bool result = true;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                result = false;
            }
        }

        return result;
    }

}