public class Rectangle: Shape
{
    private double _length;
    private double _width;

    public Rectangle(): base()
    {
        _length = 1;
        _width = 1;
    }

    public Rectangle(string name, string color, double length, double width): base(name, color)
    {
        _length = length;
        _width = width;
    }

    public void SetLength(int length)
    {
        _length = length;
    }
    public double GetLength()
    {
        return _length;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}