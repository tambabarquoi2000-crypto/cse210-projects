using System.Net.NetworkInformation;
using Microsoft.VisualBasic;

public abstract class Goal
{
    private string _shortName;
    private string _shortdescr;
    private int _points;

    public Goal()
    {
        _shortName = "";
        _shortdescr = "";
        _points = 0;

    }

    public Goal(string name, string descr, int points)
    {
        _shortName = name;
        _shortdescr = descr;
        _points = points;

    }

    // Getters and Setters
    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string name)
    {
        _shortName = name;
    }

    public string GetDescription()
    {
        return _shortdescr;
    }

    public void SetDescription(string description)
    {
        _shortdescr = description;
    }

    public int GetPoints()
    {
        return _points;   
    }

    public void SetPoints(int point)
    {
        _points = point;
    }

    // Abstract classes for individual goals to define how record event is done
    public abstract void RecordEvent();

    public abstract bool IsCompleted();

    public virtual string GetDetailString()
    {
        string completionIcon = this.IsCompleted()? "[x]" : "[]";
        return $"{completionIcon} {_shortName} ({_shortdescr})";
    }

    public abstract string GetStringRepresentation();


}