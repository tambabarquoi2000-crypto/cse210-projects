public class ListingActivity: Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description): base(name, description)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What personal strength of yours?",
            "Who are people you have helped this week?",
            "When have you felt the Holy Ghost this week?",
            "Who are some of your personal heroes?"
        };
    }
    public ListingActivity(int count, string name, string description): base(name, description)
    {
        count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What personal strength of yours?",
            "Who are people you have helped this week?",
            "When have you felt the Holy Ghost this week?",
            "Who are some of your personal heroes?"
        };
    }

   public ListingActivity(string name, string description, int count, List<string> prompts): base(name, description)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        this.DisplayStartingMsg();
        this.GetRandomPrompt();
        this.GetListFromUser();
        Console.WriteLine($"You have listed {_count} activities.");
        this.DisplayEndingMsg();


    }

    private void GetRandomPrompt()
    {
        Random rand = new Random();
        int randIndex = rand.Next(_prompts.Count());
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---{_prompts[randIndex]}---");
    }

    private List<string> GetListFromUser()
    {
        List<string> userActivities = new List<string>();
        Console.Write("You may begin in...");
        this.ShowcountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this._duration);
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            string newActivity = Console.ReadLine();
            if(newActivity.Trim() != "")
            {
                _count++;
            }
            userActivities.Add(newActivity); 
        }

        return userActivities;
    }
}