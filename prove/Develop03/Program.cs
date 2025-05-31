using System;

// Stretch idea: also give them option in the middle of
// program to get all the words back and then try again.
// To do this would need to add else if and have it use 
// the original scriptureText to reset the word list in the scripture class

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("D&C", 6, 36, 37);
        string scriptureText = @"Look unto me in every thought; doubt not, fear not. Behold the wounds which pierced my side, and also the prints of the nails in my hands and feet; be faithful, keep my commandments, and ye shall inherit the kingdom of heaven. Amen.";
        string scriptureRef = reference.GetReference(); // puts reference into a traditional format
        Scripture scripture = new Scripture(scriptureText, scriptureRef); // pass ref and text into scripture when initialize

        string action = "";

        while (action == "")
        {
            scripture.DisplayText();

            Console.Write($"\n\nPress enter to take out more words or type 'quit' to finish\n> ");
            string prompt = Console.ReadLine();
            if (prompt == "")
            {
                scripture.HideWords();
            }
            else if (prompt.ToLower() == "quit")
            {
                action = "quit";
            }
        }

        Console.WriteLine();
    }
}