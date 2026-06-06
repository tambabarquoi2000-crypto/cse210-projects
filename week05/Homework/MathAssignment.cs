public class MathAssignment: Assignment
{
    private string _textbookSection = "";
    private string _problem = "";

    public MathAssignment(string name, string topic, string textbookSec, string problem):base(name, topic)
    {
        _textbookSection = textbookSec;
        _problem = problem;
    }

    public string GetHomeWorkList()
    {
        return $"{_textbookSection} - {_problem}";
    }
}