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

        Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Apple";
        job2._startYear = 2017;
        job2._endYear = 2024;

        Console.WriteLine($"{job2._jobTitle} ({job2._company}) {job2._startYear}-{job2._endYear}");
    }
}