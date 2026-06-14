public class Circle: Shape
{
    private double _radius;

    public Circle(): base()
    {
        _radius = 0;
    }

    public Circle(string name, string color, double radius): base(name, color)
    {
        _radius = radius;

    }

    public void Setradius(double radius)
    {
        _radius = radius;
    }
    public double Getradius()
    {
        return _radius;
    }

    public override double GetArea()
    {
        return Math.Round(Math.PI * _radius * _radius, 2);
    }
}