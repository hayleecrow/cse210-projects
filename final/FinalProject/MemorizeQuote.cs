using System;

class MemorizeQuote
{
    private string _fullQuote;
    private List<string> _words;
    // private int _wordCount;
    private int _wordsHidden;
    public MemorizeQuote()
    {
        _fullQuote = "";
        _words = new List<string> { };
        // _wordCount = 1;
        _wordsHidden = 0;
    }
    public void InputQuote()
    {
        Console.Write($"What is the quote you would like to memorize? (Press enter when done)\n> ");
        _fullQuote = Console.ReadLine();

        _words = ConvertStringToList(_fullQuote);
        // _wordCount = _words.Count();
    }
    private List<string> ConvertStringToList(string quote)
    {
        string[] words = quote.Split(" ");

        List<string> list = new List<string> { };
        foreach (string word in words)
        {
            list.Add(word);
        }

        return list;
    }
    public void DisplayQuote()
    {
        foreach (string word in _words)
        {
            Console.Write($"{word} ");
        }
    }
    public void HideRandomWords()
    {
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            if (_words.Count() > _wordsHidden) // if still more words left
            {
                int index = random.Next(0, _words.Count());
                string chosen = _words[index];
                string chosenHidden = HideWord(chosen); // to test if word is already hidden or not

                while (chosen == chosenHidden)
                {
                    index = random.Next(0, _words.Count());
                    chosen = _words[index];
                    chosenHidden = HideWord(chosen); // to test if word is already hidden or not
                }

                _words[index] = chosenHidden;
                _wordsHidden++;
            }
            else if (_words.Count() <= _wordsHidden) // if all words are hidden
            {
                Console.WriteLine("All words are hidden");
                i = 3;
            }
        }
    }
    private string HideWord(string word)
    {
        string hidden = "";

        for (int i = 0; i < word.Count(); i++) // replace each letter in the word with a _
        {
            hidden = hidden + "_";
        }

        return hidden;
    }
    public int GetWordCount()
    {
        return _words.Count();
    }
    public int GetHiddenWordCount()
    {
        return _wordsHidden;
    }
}