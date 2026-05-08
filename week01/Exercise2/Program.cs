using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What your grade percentage? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        string letterGrade;
        string gradeSign;

        if (grade >= 90)
        {
            letterGrade = "a";
            
        }
        else if (grade >= 80)
        {
           letterGrade = "b";
           
        }
        else if (grade >= 70)
        {
            letterGrade = "c";
        }

        else if (grade >= 60)
        {
            letterGrade = "d";
        }

        else
        {
            letterGrade = "F";
            
        }

        if (grade % 10 >= 7)
        {
            gradeSign = "+";
        }
        else if (grade % 10 <= 3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }

        if (letterGrade == "a" && gradeSign == "+")
        {
            gradeSign = "";
            
        }

        else if (!(letterGrade == "a" || letterGrade == "b"))
        {
            gradeSign = "";
        }


         if (grade > 70)
        {
            Console.WriteLine($"Congratulations! \nYour grade is {letterGrade.ToUpper()}{gradeSign}.");
        }

        else
        {
            Console.WriteLine($"Sorry, you failed the course but you could do better next time. \nYour grade is {letterGrade.ToUpper()}{gradeSign}");
        }
    }
}