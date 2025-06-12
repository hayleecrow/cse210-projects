using System;

public class Breathing : Activity
{
    public Breathing(string name, string start, string end, int time) : base(name, start, end, time)
    {
        // string name = "";
        // string start = "";
        // string end = "";
        // int time = 0;
    }
    public void Run()
    {
        base.DisplayStartPrompt();

        // loop for countdown??
        // repeats breathe in and out for certain amount of time

        base.DisplayEndPrompt();
    }
    private void BreathIn()
    {
        Console.Write("Breathe in...");
        // base.Countdown(4);
    }
    private void BreathOut()
    {
        Console.Write("Now breathe out...");
        // base.Countdown(6);
    }
}