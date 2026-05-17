public class GeneratePrompt
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What new did I discover today?",
        "Which mood swing did I show of today to my firends?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        
        int _promotIndex = rand.Next(0, _prompts.Count());

        return _prompts[_promotIndex];
        

    }
}