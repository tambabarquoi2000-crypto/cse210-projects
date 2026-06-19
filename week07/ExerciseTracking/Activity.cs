public abstract class Activity
{
    // Member Variables
    // ===================================================
    private string _date;
    private int _duration;



    // Constructors
    // ===================================================
    public Activity()
    {
        _date = DateTime.Now.ToString("dd MMM yyyy");
        _duration = 0;
    }

    public Activity(int duration)
    {
        _date = DateTime.Now.ToString("dd MMM yyyy");
        _duration = duration;
    }

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    
    }

    // Getters & Setters 
    // =====================================================
    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration / 60;
    }


    // Methods
    // ===========================================================

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    public  string GetSummaryString()
    {
        return $"{this.GetDate()} Running ({this.GetDuration()} min) - Distance {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km."; 
    }
    
}