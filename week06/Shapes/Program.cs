using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Circle circle = new Circle("Circle", "Red", 12);
        Square square = new Square("Square", "Blue", 4);
        Rectangle rec = new Rectangle("Rectangle", "Purple", 10, 14);

        List<Shape> shapes = new List<Shape>{circle, square, rec};

        foreach (Shape shape in shapes)
        {
           Console.WriteLine($"The area of the {shape.GetName()} is {shape.GetArea()}cm.sqrt and the color is {shape.GetColor()}.") ;
        }


    }
}