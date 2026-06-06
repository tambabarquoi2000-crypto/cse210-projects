public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public Activity(string name)
    {
        _name = name;
        _description = "";
        _duration = 0;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMsg()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would link for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine("\n");
    }

    public void DisplayEndingMsg()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds {_name}");
        this.ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        string[] animationStrings = ["/", "—", "\\", "|"];

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Length)
            {
                i = 0;
            }
        }
    }

    public void ShowcountDown(int seconds, string backspace = "\b \b")
    {
        int timeLeft = seconds;
        while (timeLeft > 0)
        {

            Console.Write(timeLeft);
            Thread.Sleep(1000);

            if (timeLeft.ToString().Length < 2)
            {
                backspace = "\b \b";
            }

            Console.Write(backspace);

            timeLeft--;
        }
    }

}
