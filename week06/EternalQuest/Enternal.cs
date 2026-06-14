public class EnternalGoal: Goal
{
    public EnternalGoal(): base()
    {
        
    }

    public EnternalGoal(string name, string descr, int points): base(name, descr, points)
    {
        
    }

    public override void RecordEvent()
    {
        return;
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Enternal Goal:{this.GetShortName()},{this.GetDescription()},{this.GetPoints()}";
    }
}