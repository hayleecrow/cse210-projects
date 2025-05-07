using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2025;

        Console.WriteLine($"{job1._jobTitle} ({job1._company}) {job1._startYear}-{job1._endYear}");
    }
}