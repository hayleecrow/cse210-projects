using System;

class Program
{
    static void Main(string[] args)
    {
        Math math = new Math("Samuel Bennett", "Multiplication", "7.3", "8-19");
        string summary = math.GetSummary();
        string list = math.GetHomeworkList();
        Console.WriteLine($"{summary}\n{list}");
    }
}