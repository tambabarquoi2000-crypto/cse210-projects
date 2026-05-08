using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string quit;

        do 
        {
            Random randomGenerator = new Random();
            int guessNumber = randomGenerator.Next(1, 100);
            int userGuess;
            int guessCount = 0;
            string guessWord;

            do
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess > guessNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (userGuess < guessNumber)
                {
                    Console.WriteLine("Lower");
                }

                guessCount++;
            }

            while (userGuess != guessNumber);

            if (guessCount < 2)
            {
                guessWord = "guess";
            }
            else
            {
                guessWord = "gueses";
            }
            Console.WriteLine($"Congratulations!! \nYou made {guessCount} {guessWord}");
        
            
            Console.Write("Play again? (yes/no)");
            quit = Console.ReadLine();
    

        }
        while (quit.Equals("yes"));
        

    }
}