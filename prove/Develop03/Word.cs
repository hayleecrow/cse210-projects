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
        string newString = "";

        for (int i = 0; i < _word.Count(); i++) // replace each letter in the word with a _
        {
            newString = newString + "_";
        }

        _word = newString;
        _isHidden = true;
        return _word;
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