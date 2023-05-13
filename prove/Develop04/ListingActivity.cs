using System;

public class ListingActivity : Activity
{
    private List<string> _itemsList = new List<string>();
    private Random _random = new Random();

    public ListingActivity(string activityName, string activityDescription, string activityMessage) : base(activityName, activityDescription, activityMessage)
    {
        _itemsList = new List<string>();
        _random = new Random();
    }

    public List<string> GetAllListing()
    {
        return _itemsList;
    }

    public void SetReflectionList(List<string> listingItems)
    {
        _itemsList = listingItems;
    }

    public void AddItemsListing(string listingItems)
    {
        _itemsList.Add(listingItems);
    }

    public string GetRandomItems()
    {
        int indexOfList = _random.Next(_itemsList.Count);
        return _itemsList[indexOfList];
    }

    public int GetTimeListingActivity(int seconds, List<string> listToUsePhrases)
    {
        _itemsList = listToUsePhrases;
        int original = seconds;
        DateTime newTime = DateTime.Now.AddSeconds(original);

        Console.WriteLine("Let's start...");
        ShowSpinner(" Press enter to start ");

        Console.Clear();
        Console.WriteLine("List as many responses you can: ");
        Console.WriteLine();

        Random rand = new Random();
        Console.WriteLine($"---- {listToUsePhrases[rand.Next(listToUsePhrases.Count)]} ----");
        Console.WriteLine();

        Console.Write("You may start in: ");
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        Console.WriteLine();

        List<string> responses = new List<string>();
        while (DateTime.Now <= newTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
            {
                break;
            }
            responses.Add(response);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count} things! Press enter to continue.");

        return original;
    }
}