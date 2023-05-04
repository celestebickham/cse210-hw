using System;

public class Phrase
{
    private string _reference;

    private string _scripture;

    public Phrase()
    {
        _reference = "Unknown";
        _scripture = "Unknown";
    }

    public Phrase(string referenceToInput)
    {
        _reference = referenceToInput;
        _scripture = "";
    }

    public Phrase(string referenceToInput, string scriptureToInput)
    {
        _reference = referenceToInput;
        _scripture = scriptureToInput;
    }

    public string CompletePhase()
    {
        string phrase = _reference + " " + _scripture;
        return phrase;
    }
}