public class SwimmingActivity: Activity
{
    private int _numOfLaps;

    
    public SwimmingActivity():base()
    {
        _numOfLaps = 0;
    }

    public SwimmingActivity(int duration):base(duration)
    {
        _numOfLaps = 0;
    }

    public SwimmingActivity(int numOfLaps, int duration): base(duration)
    {
        _numOfLaps = numOfLaps;
    }

    public SwimmingActivity(string date, int duration):base(date, duration)
    {
        _numOfLaps = 0;
    }

    public SwimmingActivity(string date, int duration, int numOfLaps):base(date, duration)
    {
        _numOfLaps = numOfLaps;
    }


    public override double CalculateDistance()
    {
    
        return _numOfLaps * 50.0 / 1000;

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