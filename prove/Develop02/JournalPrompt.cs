using System;
public class JournalPrompt
{
    public static string[] _prompt = {
        "What was something you learned today?",
        "Who did you talk to today?",
        "Who called you today?",
        "What was something funny that happened today?",
        "Who did you help today?",
        "What is something you want to remember from today?",
        "What did you read in the scriptures today?",
        "What did you grow today?",
        "what did you accomplish today"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public JournalPrompt()
    {

    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];

        return journalPrompt;
    }
}