public class CyclingActivity: Activity
{
    private double _speed;

    
    public CyclingActivity():base()
    {
        _speed = 0;
    }

    public CyclingActivity(int duration):base(duration)
    {
        _speed = 0;
    }

    public CyclingActivity(double speed, int duration): base(duration)
    {
        _speed = speed;
    }

    public CyclingActivity(string date, int duration):base(date, duration)
    {
        _speed = 0;
    }

    public CyclingActivity(string date, int duration, int speed):base(date, duration)
    {
        _speed = speed;
    }


    public override double CalculateDistance()
    {
    
        return _speed * this.GetDuration() / 60;

    }

    public override double CalculateSpeed()
    {
        return _speed;
    }


    public override double CalculatePace()
    {
        return Math.Round((CalculateSpeed() / 60), 2);
    }

    public override string GetSummaryString()
    {
        return $"{this.GetDate()} Cycling ({this.GetDuration()} min) - Distance {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()}. min per km.";
    }
}