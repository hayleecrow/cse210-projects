using System;

class Word
{
    private string _word;
    public Word(string word)
    {
        _word = word;
    }
    private string Hide()
    {
        return "";
    }
    private string Show()
    {
        //
        return "";
    }
    private string IsHidden()
    {
        //
        return "";
    }
    public void Display()
    {
        Console.Write($"{_word} ");
    }
}