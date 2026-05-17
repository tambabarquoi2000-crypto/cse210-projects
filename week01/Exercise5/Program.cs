using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int sqrt = SquareNumber(userNumber);
        DispalyResult(userName, sqrt);



        
    }

    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the program.");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(userName);
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DispalyResult(string user, int sqrnumber)
    {
        Console.WriteLine($"{user}, the square of your number is {sqrnumber}.");
    }

    
}

