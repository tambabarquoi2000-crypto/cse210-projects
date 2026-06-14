public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(): base()
    {
        _isCompleted = false;
    }

    public SimpleGoal(string name, string descr, int points, bool isCompleted = false): base(name, descr, points)
    {
        _isCompleted = isCompleted;
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
    }

    public override bool IsCompleted()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{this.GetShortName()},{this.GetDescription()},{this.GetPoints()},{_isCompleted}";
    }

}