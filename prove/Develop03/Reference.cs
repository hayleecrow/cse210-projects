using System;

// Display Reference has if statement for one v or multiple v
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        Console.WriteLine($"Start: {book} {chapter}:{verse}");
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        Console.WriteLine($"Start: {book} {chapter}:{verse}-{endVerse}");
    }
    public string GetReference()
    {
        if (_endVerse == 0)
        {
            Console.WriteLine($"Gotten: {_book} {_chapter}:{_verse}");
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        { 
            Console.WriteLine($"Gotten: {_book} {_chapter}:{_verse}-{_endVerse}");
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}