using System;

public class Reference
{
    private string _book;

    private string _chapter;

    private string _verse;

    public Reference()
    {
        _book = "Unknown";
        _chapter = "Unknown";
        _verse = "Unknown";
    }

    public Reference(string bookToInput, string chapterToInput, string verseToInput)
    {
        _book = bookToInput;
        _chapter = chapterToInput;
        _verse = verseToInput;
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string bookSetted)
    {
        _book = bookSetted;
    }

    public string GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(string chapterSetted)
    {
        _chapter = chapterSetted;
    }

    public string GetVerse()
    {
        return _verse;
    }

    public void SetVerse(string verseSetted)
    {
        _verse = verseSetted;
    }

    public string GetCompleteReference()
    {
        string completeReference = $"{_book} {_chapter}:{_verse}";
        return completeReference;
    }
}

