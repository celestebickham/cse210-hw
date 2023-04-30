using System;

public class JournalWrite
{
    public string _journalNumber = "";
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalWrite = "";
    public string _journalFile = "";

    public JournalWrite()
    {
    }

    public void Display()
    {
        Console.WriteLine($"\n#: {_journalNumber}");
        Console.WriteLine($"\nDate: {_dateTime}");
        Console.WriteLine($"\nPrompt: {_journalPrompt}");
        Console.WriteLine($"\nEntry: {_journalWrite}");
    }

}