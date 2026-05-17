using System;

// I added a promt to the entry class so that user will not have to answer the same that they have
// already provided answer for. The program generates a prompt and ask the user if a new one should be 
// generated. If the user provides yes or "y" the program generates a new one. if the user provide 
// and answer the program use it as the response for the prompt text.

class Program
{
    static void Main(string[] args)
    {

        Journal userJournal = new Journal ();
        string response;

        Console.WriteLine("Hello World! This is the Journal Project.");
        
        do
        {
            
            Console.WriteLine("Please selcet one of the following Choices:");
            Console.WriteLine("1.  Write");
            Console.WriteLine("2.  Display");
            Console.WriteLine("3.  Load");
            Console.WriteLine("4.  Save");
            Console.WriteLine("5.  Quit");
            Console.Write("Please select one of the following choices: ");
            response = Console.ReadLine(); 

            if (response == "1")
            {
                Entry entry = new Entry();
                userJournal.AddEntry(entry);
            }

            else if (response == "2")
            {
                userJournal.DisplayAll();
            }

            else if (response == "3")
            {
                userJournal.LoadFromFile();
            }

            else if (response == "4")
            {
                userJournal.SaveToFile();
            }
        }

        while (response != "5");

    }
}
