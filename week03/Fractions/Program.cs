using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction noPara = new Fraction();

        Fraction topPara = new Fraction(5);

        Fraction bothPara = new Fraction(5, 6);

        noPara.SetTopValue(1);
        noPara.SetBottomValue(1);

        topPara.SetBottomValue(4);

        bothPara.SetTopValue(4);
        bothPara.SetBottomValue(11);

        Console.WriteLine(bothPara.GetDecimalValue());

    }
}