using System;

public class Journal
{
    public List<JournalWrite> _journal = new List<JournalWrite>();
    private string _journalFileName;

    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine("\n Journal Entries ");
        foreach (JournalWrite journalWrite in _journal)
        {
            journalWrite.Display();
        }
        Console.WriteLine("\n Journal End ");
    }

    public void CreateJournalFile()
    {
        Console.Write("What is the name of your journal? (Hint: CelesteJournal) ");
        string userInput = Console.ReadLine();
        _journalFileName = userInput + ".txt";

        if (!File.Exists(_journalFileName))
        {
            File.CreateText(_journalFileName);
            Console.Write($"\n Your journal {_journalFileName} has been created.  \n");
            Console.Write("   Your journal has been saved.  \n");
            SaveJournalFile(_journalFileName);
        }
        else
        {
            Console.Write($"\n The journal {_journalFileName} already exits, and so your thoughts were saved there.  \n");
            AppendJournalFile(_journalFileName);
        }
    }

    public void SaveJournalCSV()
    {
        Console.Write("What is the name of your journal? (Hint: CelesteJournal) ");
        string userInput = Console.ReadLine();
        _journalFileName = userInput + ".csv";

        if (!File.Exists(_journalFileName))
        {
            File.CreateText(_journalFileName);
            Console.Write($"\n Your journal {_journalFileName} has been saved as a CSV.  \n");
            SaveJournalFile(_journalFileName);
        }
        else
        {
            Console.Write($"\n The journal {_journalFileName} already exits, and so your thoughts were saved there and are ready to import.  \n");
            AppendJournalFile(_journalFileName);
        }
    }

    public void SaveJournalFile(string _journalFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_journalFileName))
        {
            foreach (JournalWrite journalWrite in _journal)
            {
                outputFile.WriteLine($"{journalWrite._journalNumber}| {journalWrite._dateTime}| {journalWrite._journalPrompt}| {journalWrite._journalWrite}");
            }
        }
    }

    public void AppendJournalFile(string _journalFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_journalFileName, append: true))
        {
            foreach (JournalWrite journalWrite in _journal)
            {
                outputFile.WriteLine($"{journalWrite._journalNumber}| {journalWrite._dateTime}| {journalWrite._journalPrompt}| {journalWrite._journalWrite}");
            }
        }
    }

    public void LoadJournalFile()
    {
        Console.Write("What your file name? (Hint: CelesteJournal) ");
        string userInput = Console.ReadLine();
        _journalFileName = userInput + ".txt";

        if (File.Exists(_journalFileName))
        {
            List<string> readText = File.ReadAllLines(_journalFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] comments = line.Split("| ");

                JournalWrite write = new JournalWrite();

                write._journalNumber = comments[0];
                write._dateTime = comments[1];
                write._journalPrompt = comments[2];
                write._journalWrite = comments[3];

                _journal.Add(write);
            }

            foreach (JournalWrite journalWrite in _journal)
            {
                journalWrite.Display();
            }


        }
    }


}
