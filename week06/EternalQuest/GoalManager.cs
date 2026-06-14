using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public GoalManager(List<Goal> goals)
    {
        _goals = goals;
        _score = 0;
    }

    public void SetGoalManager(List<Goal> goals)
    {
        _goals = goals;
    }


    private void CreateGoal(string type)
    {
        Console.Write("What is the name of the goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string descr = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if(type == "1")
        {
            SimpleGoal simpGoal = new SimpleGoal(goalName, descr, points);
            _goals.Add(simpGoal);
        }

        else if(type == "2")
        {
            EnternalGoal entGoal = new EnternalGoal(goalName, descr, points);
            _goals.Add(entGoal);
        }

        else if(type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for completing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, descr, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        Console.WriteLine();
    }

    public void Start()
    {
        string input = "";
        do
        {
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Events");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            // Get input from the user
            input = Console.ReadLine();

            if(input == "1")
            {
                // Console.Clear();
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Enternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of Goal would like to create? ");

                string crtGoalInput = Console.ReadLine();
                CreateGoal(crtGoalInput);
            }

            else if(input == "2")
            {
                this.ListGoals();
            }

            else if(input == "3")
            {
                this.SaveFile();
                
            }

            else if(input == "4")
            {
                this.LoadFile();
            }

            else if(input == "5")
            {
                this.RecordEvent();
            }
        }

        while(!(input == "6"));
    }

    private void DisplayPlayerInfo()
    {
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals)
        {
            
            Console.WriteLine($" {count}. {goal.GetShortName()}");
            count ++;
        }
    }

    private void ListGoals()
    {
        int count = 1; // use for ordinal numbering
        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($" {count}. {goal.GetDetailString()}");
            count ++;
        }
        Console.WriteLine();
    }

    private void RecordEvent()
    {
        this.DisplayPlayerInfo();
        Console.Write("Which goal did you accomplish? ");
        int response = int.Parse(Console.ReadLine()); // get the index of the goal accomplish
        
        if(response - 1 < _goals.Count())
        {
            int index = response - 1;
            _goals[index].RecordEvent(); // response - 1 for computer 0 indexing

            if(!_goals[index].IsCompleted())
            {
                int point = _goals[index].GetPoints();
            _score += point;
            Console.WriteLine($"Congratulation! You have earned {point} points.\nYou now have {_score} points");
            }
            
        }
        Console.WriteLine(); 
    }

    private void SaveFile()
    {
                Console.Write("What is the name of the file? ");
            
                FileStream myFile = File.Create(Console.ReadLine()); // get file name from the user and let C# create a file
                using (StreamWriter writer = new StreamWriter(myFile))
                {
                    writer.WriteLine(_score);
                    foreach(Goal goal in _goals)
                    {
                        writer.WriteLine(goal.GetStringRepresentation());
                    }
                }
    }

    private void ProcessRecod(string [] recordinfos, string goalType)
    {
        bool status = false; // this variable is for simple goal

        int bonus = 0; // this vaariable is for checklist goal
        int target = 0; // this vaariable is for checklist goal
        int amountCompleted = 0; // this vaariable is for checklist goal

        

        string name = recordinfos[0]; // general variables
        string description = recordinfos[1];
        int pointValue = int.Parse(recordinfos[2]);

        if(goalType == "Simple Goal")
        {
            status = bool.Parse(recordinfos[3]);
        }
 
            if(goalType == "Checklist Goal")
        {
            bonus  = int.Parse(recordinfos[3]);
            target = int.Parse(recordinfos[4]);
            amountCompleted = int.Parse(recordinfos[5]);
        }

        if(goalType == "Simple Goal")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, pointValue, status);
            _goals.Add(simpleGoal);
        }

        else if(goalType == "Enternal Goal")
        {
            EnternalGoal enternalGoal = new EnternalGoal(name, description, pointValue);
            _goals.Add(enternalGoal);
        }

        else if(goalType == "Checklist Goal")
        {
            ChecklistGoal cheklistGoal = new ChecklistGoal(name, description, pointValue,target, bonus, amountCompleted);
            _goals.Add(cheklistGoal);
        }
    }

    private void LoadFile()
    {
        _goals = []; // initialize the list empty to avoid ambigous loading
        Console.Write("Please enter the file name. ");
        string file = Console.ReadLine();
        string [] linesInFile = System.IO.File.ReadAllLines(file);

        for(int i=0; i<linesInFile.Length; i++)
        {
            if(i == 0)
            {
                _score = int.Parse(linesInFile[i]);
            }

            else
            {
                string [] lineParts = linesInFile[i].Split(":"); // initialize a list variable to hold each line parts.
                string [] playerRecord = lineParts[1].Split(","); // initialize a list variable to hold each item from the second item in the line parts varible
                
                string goalType = lineParts[0];
                ProcessRecod(playerRecord, goalType);
            }
        }

        Console.WriteLine(); 
    }

}