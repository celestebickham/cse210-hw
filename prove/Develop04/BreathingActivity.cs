using System;

public class BreathingActivity : Activity
{
    private DateTime _time;

    public BreathingActivity(string activityName, string activityDescription, string activityMessage) : base(activityName, activityDescription, activityMessage)
    {
        DateTime startTime = DateTime.Now;
        _time = startTime.AddSeconds(0);
    }

    public BreathingActivity(string activityName, string activityDescription, string activityMessage, int timeActivity) : base(activityName, activityDescription, activityMessage)
    {
        string timeString = timeActivity.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _time = startTime.AddSeconds(int.Parse(timeString));
    }

    public DateTime GetTime()
    {
        return _time;
    }

    public void SetTitle(DateTime setTime)
    {
        string timeString = setTime.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _time = startTime.AddSeconds(int.Parse(timeString));
    }
    public int GetBreatheActivity(int seconds)
    {
        Console.WriteLine("Time to begin...");
        ShowSpinner(" Press enter to start ");

        const int breatheInDuration = 4;
        const int breatheOutDuration = 4;

        int remainingSeconds = seconds;
        bool isBreathingIn = true;
        while (remainingSeconds > 0)
        {
            Console.Clear();

            int countdown = isBreathingIn ? breatheInDuration : breatheOutDuration;
            string message = isBreathingIn ? "Breathe in..." : "Breathe out...";

            while (countdown > 0 && remainingSeconds > 0)
            {
                Console.Clear();
                Console.WriteLine($"{message} {countdown}");

                Thread.Sleep(1000);

                countdown--;
                remainingSeconds--;
            }

            isBreathingIn = !isBreathingIn;
        }

        return seconds;
    }
}