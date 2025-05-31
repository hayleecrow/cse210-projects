using System;

class Word
{
    private string _word;
    private bool _isHidden;
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public string Hide()
    {
        // include iternates to correlate _ to number of letters in word
        _word = "___";
        _isHidden = true;
        return _word;
    }
    public string Show()
    {
        //
        return "";
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public void Display()
    {
        Console.Write($"{_word} ");
    }
}