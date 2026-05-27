
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    public Reference()
    {
        _book = "Genesis";
        _chapter = 1;
        _verse = 1;
        _endverse = 0;
    }

    public Reference(string book)
    {
        _book = book;
        _chapter = 1;
        _verse = 1;
        _endverse = 0;
    }

    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _verse = 1;
        _endverse = 0;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endverse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endverse}";
        }

        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }

    }

    public void SetRef(string book, int chap, int verse, int endVerse=0)
    {
        _book = book;
        _chapter = chap;
        _verse = verse;
        _endverse = endVerse;
    }
}