using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();

        Swimming swimming = new Swimming(41, "May 16, 2023", 50);
        activities.Add(swimming);

        Cycling cycling = new Cycling(65, "May 25, 2023 2023", 23);
        activities.Add(cycling);

        Running running = new Running(92, "April 4, 2023", 13.1);
        activities.Add(running);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}\n");
        }
    }
}