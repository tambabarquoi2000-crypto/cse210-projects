using System;

// Creativity: In the Reflecting activity I added a funtionality to the program for the user to generate 
// new prompts if they are not feeling comfortable with the generated prompt by entering slash and enter 
// or just press enter if they are comfortable with the generated prompt.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string userInput = "";

        do
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start the breathing activity");
            Console.WriteLine ("  2. Start the reflecting activity");
            Console.WriteLine("  3. Starting listing activity"); 
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine().Trim().ToLower();
            Console.Clear();

            if(userInput == "1")
            {
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathingActivity = new BreathingActivity(name, description);
                breathingActivity.Run();
            }

            else if(userInput == "2")
            {
                string name = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                ReflectingActivity reflectingActivity = new ReflectingActivity(name, description);
                reflectingActivity.Run();
            }

            else if(userInput == "3")
            {
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                ListingActivity listingActivity = new ListingActivity(name, description);
                listingActivity.Run();

            }

        }

        while(userInput != "quit");
        
    }
}