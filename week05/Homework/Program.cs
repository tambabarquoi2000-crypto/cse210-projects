using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment mathAssignment = new MathAssignment("James", "Friction", "Section 7.4", "Problems 8-19");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());

        WritingAssignment writingAssignment = new WritingAssignment("James Davis", "European History", "The cause of World War II by Mary Waters.");

        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}