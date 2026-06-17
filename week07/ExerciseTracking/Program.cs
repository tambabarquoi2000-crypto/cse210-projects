using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        

        // Running Data
        int duration = 30;
        int distance = 4800;

        RunningActivity runningEx = new RunningActivity(duration, distance);
        
        // Swimming Data
        int numOfLaps = 30;
        int sDuration = 20;

        SwimmingActivity swimmingEx = new SwimmingActivity(numOfLaps, sDuration);

        // Cyclling
        int speed = 15;
        int cDuration = 20;

        CyclingActivity cyclingEx = new CyclingActivity(speed, cDuration);

        List<Activity> allActivities = new List<Activity>
        {
            runningEx, swimmingEx, cyclingEx
        };

        foreach(Activity act in allActivities)
        {
            Console.WriteLine(act.GetSummaryString());

        }
        
    }
}