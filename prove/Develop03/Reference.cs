using System;

// Display Reference has if statement for one v or multiple v
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        Console.WriteLine($"Start: {book} {chapter}:{verse}");
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        //
    }
    public string GetReference()
    {
        Console.WriteLine($"Gotten: {_book} {_chapter}:{_verse}");
        return $"{_book} {_chapter}:{_verse}";
    }
}