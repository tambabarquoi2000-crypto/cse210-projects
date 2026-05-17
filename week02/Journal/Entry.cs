public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _promptText = "";
    public string _entryText;

    public void Display()
    {
        GeneratePrompt _prompt = new GeneratePrompt();
        _promptText = _prompt.GetRandomPrompt();
        Console.Write(_promptText);

        Console.WriteLine(" Generate New Prompt? [Y] ");
        Console.Write("> ");
        string response = Console.ReadLine().ToLower();
        if (response == "y")
        {
            Display();
        }

        else
        {

            _entryText = response;

        }

    }
}