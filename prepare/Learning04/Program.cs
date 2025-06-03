using System;

class Program
{
    static void Main(string[] args)
    {
        Math math = new Math("Samuel Bennett", "Multiplication", "7.3", "8-19");
        string summary = math.GetSummary();
        string list = math.GetHomeworkList();
        Console.WriteLine($"\n{summary}\n{list}");

        Writing writing = new Writing("Mary Waters", "European History", "The Causes of World War II");
        string summary1 = writing.GetSummary();
        string info = writing.GetWritingInfo();
        Console.WriteLine($"\n{summary1}\n{info}\n");
    }
}