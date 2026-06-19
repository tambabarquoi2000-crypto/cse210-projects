public class RunningActivity: Activity
{
    private double _distance;

    
    public RunningActivity():base()
    {
        _distance = 0;
    }

    public RunningActivity(int duration):base(duration)
    {
        _distance = 0;
    }

    public RunningActivity(int duration , int distance):base(duration)
    {
        _distance = distance;
    }

    public RunningActivity(string date, int duration):base(date, duration)
    {
        _distance = 0;
    }

    public RunningActivity(string date, int duration, int distance):base(date, duration)
    {
        _distance = distance;
    }


    public override double CalculateDistance()
    {
    
        return _distance / 1000;

    }

    public override double CalculateSpeed()
    {
        return Math.Round((CalculateDistance() / this.GetDuration()) * 60, 1);
    }


    public override double CalculatePace()
    {
        return Math.Round((60 / CalculateSpeed()), 2);
    }

}