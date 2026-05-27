using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scripture mScripture = new Scripture("Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him and he shall direct thy path.");

        string response = "";

        do
        {
            Console.Clear();
            Console.WriteLine(mScripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type quit to finish");
            Console.Write("> ");
            response = Console.ReadLine();



            if (mScripture.IsCompletelyHidden())
            {
                break;
            }

            else if (response == "")
            {
                mScripture.HideRandomWords(3);

            }

        }

        while (response != "quit");
    }

}