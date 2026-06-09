public class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description):base(name, description)
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public ReflectingActivity(List<string> prompts, List<string> questions, string name, string description): base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }


    public void Run()
    {
        this.DisplayStartingMsg();
        do
        {
            Console.Clear();
            Console.WriteLine("Get Ready...");
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt.");
            this.DisplayPrompt();
            Console.Write("\nWhen you have something in mind, press enter to continue or foward slash enter to generate a new prompt. > "); 
        }

        while(Console.ReadLine() == "/");
        

        Console.Write("\nNow ponder on each of the questions as they are relate to this experience.");
        this.ShowcountDown(10, "\b \b\b \b");
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime  = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            this.DisplayQuestion();
            this.ShowSpinner(15);
            Console.WriteLine();

        }

        this.DisplayEndingMsg();
    }
    
    

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count())];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count())];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{this.GetRandomPrompt()}---");
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {this.GetRandomQuestion()}");
    }


}