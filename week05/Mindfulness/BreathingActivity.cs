using System.Data;

public class BreathingActivity: Activity
{
    public BreathingActivity(string name, string description):base(name, description)
    {
        
    }

    public void Run()
    {
        this.DisplayStartingMsg();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this._duration);

        while(DateTime.Now < endTime)
        {
        
            Console.Write("Breathe in...");
            this.ShowcountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            this.ShowcountDown(6);
            Console.WriteLine();
            Console.WriteLine();  
        }

        this.DisplayEndingMsg();       
    }

    }
