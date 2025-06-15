using System;

public class Breathing : Activity
{
    public Breathing(string name, string start) : base(name, start)
    {
        // string name = "";
        // string start = "";
        // string end = "";
        // int time = 0;
    }
    public void Run()
    {
        base.DisplayStartPrompt();

        int seconds = base.GetTime();
        DateTime now = DateTime.Now;
        DateTime target = now.AddSeconds(seconds);

        while (DateTime.Now < target) // repeats breathe in and out for certain amount of time
        {
            BreatheIn();
            BreatheOut();

            Console.WriteLine();
        }

        base.DisplayEndPrompt();
    }
    private void BreatheIn()
    {
        Console.Write("Breathe in... ");
        base.Countdown(4);
    }
    private void BreatheOut()
    {
        Console.Write("Now breathe out... ");
        base.Countdown(6);
    }
}