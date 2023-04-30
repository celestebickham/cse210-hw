using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        int[] options = { 1, 2, 3, 4, 5 };
        int selection = 0;
        Console.Write("\nWelcome to Your Journal\n");
        Journal journal = new Journal();
        JournalPrompt jp = new JournalPrompt();


        while (selection != 5)
        {
            selection = Selection();

            switch (selection)
            {
                case 1:

                    string journalId = GetWriteId();
                    string dateInfo = GetDateTime();
                    string prompt = jp.GetPrompt();

                    JournalWrite write = new JournalWrite();
                    write._journalNumber = journalId;
                    write._dateTime = dateInfo;
                    write._journalPrompt = prompt;

                    Console.Write($"{prompt}\n");
                    Console.Write(">>> ");
                    string userSelection = Console.ReadLine();
                    write._journalWrite = userSelection;

                    journal._journal.Add(write);
                    break;

                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.LoadJournalFile();
                    break;
                case 4:
                    journal.CreateJournalFile();
                    break;
                case 5:
                    journal.SaveJournalCSV();
                    break;
                default:
                    Console.WriteLine($"\nPlease select a valid number.");
                    break;
            }
        }
    }


    static int Selection()
    {
        string options = @"
Please select one of the following options:
1. Write a new journal entry
2. Review your thoughts for today
3. Open your journal
4. Save as a txt file
5. Save as a CSV file
What would you like to do? ";
        int selection = 0;
        Console.Write(options);
        string userInput = Console.ReadLine();
        selection = int.Parse(userInput);
        return selection;
    }

    static string GetDateTime()
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        return currentDateTime;
    }
    static void AddJournalWrite()
    {
        string CelesteJournalFile = "CelesteJournal.txt";
        File.AppendAllText(CelesteJournalFile, "");
    }

    static string GetWriteId()
    {
        Guid writeid = Guid.NewGuid();
        string writeidString = writeid.ToString();

        return writeidString;
    }


}