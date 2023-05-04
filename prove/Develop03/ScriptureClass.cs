
using System;

public class Scripture
{
    private string _phrase;

    public Scripture()
    {
        _phrase = "None";
    }

    public Scripture(string phaseToInput)
    {
        _phrase = phaseToInput;
    }

    public string GetPhase()
    {
        return _phrase;
    }

    public void SetPhase(string phaseToSet)
    {
        _phrase = phaseToSet;
    }

    public string GetCompleteScripture()
    {
        string phaseToReturn = _phrase;
        return phaseToReturn;
    }
}

