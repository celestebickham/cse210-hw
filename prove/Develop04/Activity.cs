using System;

public class Activity
{
    protected string _activityName;
    protected int _activityDuration;
    protected string _activityDescription;
    protected string _activityMessage;
    public Activity(string activityName, string activityDescription, string activityMessage)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _activityMessage = activityMessage;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void SetActivityDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public string GetActivityMessage()
    {
        return _activityMessage;
    }

    public void SetActivityMessage(string activityMessage)
    {
        _activityMessage = activityMessage;
    }

    public string GetActivityNameShow()
    {
        return $"Welcome to the {_activityName}.";
    }

    public string GetActivityDescriptionShow()
    {
        return $"{_activityDescription}";
    }

    public string GetActivityDurationShow()
    {
        Console.Write("How many seconds would you like? ");
        string duration = "0";
        string result = Console.ReadLine();
        if (!string.IsNullOrEmpty(result))
        {
            duration = result;
        }
        return duration;
    }

    public string GetActivityMessageShow()
    {
        Console.WriteLine("Well done.");
        Console.WriteLine();
        Convert.ToString(_activityDuration);
        return $"You have finished another {_activityDuration} seconds of the {_activityName}. Press enter to continue.";
    }

    public void ShowSpinner(string text, string position = "left")
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;

        string[] spinnerFrames = new string[] { "| ", "/ ", "— ", "\\ " };
        int spinnerIndex = 0;

        while (true)
        {
            Console.SetCursorPosition(x, y);

            if (position == "left")
            {
                Console.Write(spinnerFrames[spinnerIndex] + text);
            }
            else if (position == "right")
            {
                Console.Write(text + " " + spinnerFrames[spinnerIndex]);
            }

            spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;

            Thread.Sleep(350);
            if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.SetCursorPosition(x + text.Length, y);
                Console.Write("   ");
                Console.WriteLine();
                break;
            }
        }
    }
}