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
        }
        _reference = reference;
    }
    public void DisplayText()
    {
        string action = "";

        while (action == "")
        {
            Console.Clear();

            Console.WriteLine($"\n{_reference}\n{_scriptureText}");

            Console.WriteLine($"Press enter to take out more words or type 'quit' to finish");
            string prompt = Console.ReadLine();
            if (prompt.ToLower() == "quit")
            {
                action = "quit";
            }
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