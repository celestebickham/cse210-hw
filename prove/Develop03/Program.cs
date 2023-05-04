
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the book: ");
        string userBook = Console.ReadLine();

        if (userBook == "")
        {
            userBook = "2 Nephi";
        }

        Console.Write("Enter the chapter: ");
        string userChapter = Console.ReadLine();

        if (userChapter == "")
        {
            userChapter = "2";
        }

        Console.Write("Enter the verse number(s) (ex 3, or 4-8): ");
        string userVerse = Console.ReadLine();

        if (userVerse == "")
        {
            userVerse = "25";
        }

        Console.Write("Enter your scripture: ");
        string userPhase = Console.ReadLine();

        if (userPhase == "")
        {
            userPhase = "Adam fell that men might be; and men are, that they might have joy.";
        }

        Reference referenceStructure = new(userBook, userChapter, userVerse);
        string reference = referenceStructure.GetCompleteReference();

        Scripture scritureStructure = new Scripture(userPhase);
        string scripture = scritureStructure.GetCompleteScripture();

        Phrase phrase = new Phrase(reference, scripture);
        string completePhase = phrase.CompletePhase();

        Words words = new(true);

        List<string> list = new();
        list = scripture.Split(" ").ToList();
        List<string> listWithSlashs = new();

        bool condition = true;
        Console.Clear();

        words.GetCompletePhase(completePhase, list, condition, reference);
        listWithSlashs.Add(reference + " ");

        for (int i = 0; i < list.Count; i++)
        {
            listWithSlashs.Add((string)list[i] + " ");
            Console.Clear();
        }

        Console.Write("");
        Console.WriteLine("-You have exited the program and ended with this: ");
        Console.WriteLine();

        foreach (var item in listWithSlashs)
        {
            Console.Write($"{item}");
        }
    }
}


