using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5);
        string scriptureText = "text";
        string scriptureRef = reference.GetReference();
        Console.WriteLine($"\n{scriptureRef}\n{scriptureText}");
        // pass ref and text into scripture when initialize
        // call DisplayText function

        Console.WriteLine();
    }
}