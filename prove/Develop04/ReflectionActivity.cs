using System;

public class ReflectionActivity : Activity
{
    private List<string> _listOfPhrases = new List<string>();
    private Random _random = new Random();

    public ReflectionActivity(string activityName, string activityDescription, string activityMessage) : base(activityName, activityDescription, activityMessage)
    {
        _listOfPhrases = new List<string>();
        _random = new Random();
    }

    public List<string> GetAllReflectionPhrases()
    {
        return _listOfPhrases;
    }

    public void SetAllReflectionList(List<string> phrase)
    {
        _listOfPhrases = phrase;
    }

    public void AddPhraseToList(string phrase)
    {
        _listOfPhrases.Add(phrase);
    }

    public string GetRandomPhrase()
    {
        int indexOfList = _random.Next(_listOfPhrases.Count);
        return _listOfPhrases[indexOfList];
    }

    public int GetTimeReflectionActivity(int seconds, List<string> listToUsePhrases, List<string> listaToUseQuestions)
    {
        _listOfPhrases = listToUsePhrases;
        int original = seconds;
        int copy = original;
        DateTime newTime = DateTime.Now.AddSeconds(copy);

        int remaining = seconds;
        string message = "You may begin in: ";

        Console.WriteLine("Let's start...");
        ShowSpinner(" Press enter to start ");
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        Random rand = new Random();
        int index = rand.Next(0, listToUsePhrases.Count);
        Console.WriteLine($"---- {listToUsePhrases[index]} ----");
        Console.WriteLine();
        Console.WriteLine("When you have thought of something, press 'Enter' to continue.");
        Console.Write("");
        string enterKey = Console.ReadLine();

        if (enterKey == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            while (DateTime.Now <= newTime)
            {
                for (int i = 3; i > 0; i--)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write($"\r{message}" + i);
                    Thread.Sleep(1000);
                }

                Console.Clear();

                for (int i = 0; i < listaToUseQuestions.Count; i++)
                {
                    ShowSpinner(listaToUseQuestions[i], "right");
                    Console.WriteLine();

                    if (DateTime.Now >= newTime)
                    {
                        break;
                    }
                }
            }
        }
        return original;
    }
}