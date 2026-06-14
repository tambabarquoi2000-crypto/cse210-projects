public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
  

    public ChecklistGoal(): base()
    {
        _amountCompleted = 0;
        _target = 0;
        _bonus = 0;

        
        
    }

    public ChecklistGoal(string name, string descr, int points, int target, int bonus, int amtCompleted=0): base(name, descr, points)
    {
        _amountCompleted = amtCompleted;
        _target = target;
        _bonus = bonus;
    
    }



    public override void RecordEvent()
    {
        if(_amountCompleted < _target)
        {
            _amountCompleted ++;

            if(IsCompleted())
            {
                this.SetPoints(this.GetPoints() + _bonus);
            }
        }

        else
        {
            Console.Write("You have completed this goal? Do which to restart it? [Y-N]> ");
            string response = Console.ReadLine().Trim().ToLower();
            if(response == "y")
            {
                this.SetPoints(this.GetPoints() - _bonus);
                _amountCompleted = 0;
                this.RecordEvent();
            }
            else
            {
                return;
            }
        }
        
        
    }

    public override bool IsCompleted()
    {
        bool isCompletedResult = false;

        if(_amountCompleted == _target)
        {
            isCompletedResult = true;
        }

        else
        {
            isCompletedResult = false;
        }

        return isCompletedResult;
    }

    public override string GetDetailString()
    {
        string compltIcon = this.IsCompleted()? "[x]" : "[]";

        return $"{compltIcon} {this.GetShortName()} ({this.GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
       return $"Checklist Goal:{this.GetShortName()},{this.GetDescription()},{this.GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }
}