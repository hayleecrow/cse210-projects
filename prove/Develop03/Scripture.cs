using System;


class Scripture
{
    private List<Word> _scriptureText = new List<Word>();
    private string _reference;
    public Scripture(string text, string reference)
    {
        // Iterates through text and creates word object for each word and then adds it to the word list
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _scriptureText.Add(newWord);
        }
        // Initializes reference
        _reference = reference;
    }
    public void DisplayText()
    {
        Console.Clear();

        Console.WriteLine($"{_reference}"); // displays scripture reference
        foreach (Word word in _scriptureText) // displays rendered scripture text
        {
            word.Display();
        }
    }
    public void HideWords()
    {
        Random random = new Random();

        for (int i = 0; i < 3; i++) // picks 3 words at random to hide
        {
            /// Are there any more words not hidden?
            int notHidden = 0;
            bool allHidden = false;

            foreach (Word word in _scriptureText)
            {
                if (word.GetIsHidden() == false) // counts how many words are still not hidden
                {
                    notHidden++;
                }
            }

            if (notHidden == 0)
            {
                allHidden = true;
            }

            /// if there are still words not hidden then it will hide another word
            if (allHidden == false)
            {
                int index = random.Next(0, _scriptureText.Count());
                while (_scriptureText[index].GetIsHidden() == true) // won't hide a word that's already been hidden
                {
                    index = random.Next(0, _scriptureText.Count());
                }

                _scriptureText[index].Hide();
            }
        }
    }
    public bool IsCompletelyHidden()
    {
        int i = 0;

        foreach (Word word in _scriptureText)
        {
            if (word.GetIsHidden() == false) // counts how many words are still not hidden
            {
                i++;
            }
        }

        if (i > 0) // not all the words are hidden
        {
            return false;
        }
        else // all the words are hidden
        {
            return true;
        }
    }
}