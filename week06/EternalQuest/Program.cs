// I added a code to restrict the user from loading the same file more than once
// or stacking file on files

// Also added the ability to restart a completed goal especially for checklist goal


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine();

        GoalManager myGoalManager = new GoalManager();
        myGoalManager.Start();
    }
}