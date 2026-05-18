public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber  = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int botttom)
    {
        _topNumber = top;
        _bottomNumber = botttom;
    }

    public int GetTopValue()
    {
        return _topNumber;
    }

    public int SetTopValue(int value)
    {
       return  _topNumber = value;
    }

    public int GetBottomValue()
    {
        return _bottomNumber;
    }


    public int SetBottomValue (int value)
    {
        return _bottomNumber = value;
    }


    public string GetFractionString()
    {
        return $"{_topNumber/_bottomNumber}";
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}