using System;

class Game
{
    private List<Goal> _goals;
    private int _totalScore;
    public Game()
    {
        _totalScore = 0;
        _goals = new List<Goal>{ };
    }
    public int GetScore()
    {
        return _totalScore;
    }
    public void NewGoal()
    {
        //
    }
    public void DisplayGoals()
    {
        //
    }
    public void SaveGoals()
    {
        //
    }
    public void LoadGoals()
    {
        // 1. for reading the file, indicate line[0] = total points and then remove it from the array, so you can iterate through the rest of the lines
        // 2. also for reading each line, first seperate based on the "colon" then seperate based on the "commas"
    }
    public void RecordingEvent()
    { 
        //
    }
}