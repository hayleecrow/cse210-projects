using System;


class Scripture
{
    private List<Word> _scriptureText = new List<Word>();
    private string _reference;
    public Scripture(string text, string reference)
    {
        /// Initial scripture constructor iterates through text and creates word object for
        /// each word and then adds it to the word list
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _scriptureText.Add(newWord);
        }
        _reference = reference;
    }
    public void DisplayText()
    {
        Console.Clear();

        Console.WriteLine($"\n{_reference}\n");
        foreach (Word word in _scriptureText)
        {
            word.Display();
        }
    }
    private void HideWords()
    {
        //
    }
    private void IsCompletelyHidden()
    {
        //
    }
}