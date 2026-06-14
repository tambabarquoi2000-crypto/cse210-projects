public class Square: Shape
{
    private double _side;

    public Square(): base()
    {
        _side = 0;
    }

    public Square(string name, string color, double side): base(name, color)
    {
        _side = side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }

    public override double GetArea()
    {
        return Math.Round(_side * _side, 2);
    }
}