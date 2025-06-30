using System;

class Eternal : Goal
{
    private int _totalPoints;
    private int _timesCompleted;
    public Eternal(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        _totalPoints = 0;
        _timesCompleted = 0;
    }
    public Eternal(string goalType, string name, string description, int points, int total, int completed) : base(goalType, name, description, points)
    {
        _totalPoints = total;
        _timesCompleted = completed;
    }
    public override void IsComplete()
    {
        _timesCompleted++;
        _totalPoints = _totalPoints + base.GetPoints();
    }
    public override string SaveString()
    {
        return $"{base.SaveString()}~~{_totalPoints}~~{_timesCompleted}";
    }
    public override string DisplayString()
    {
        return $"{base.DisplayString()} -- Completed {_timesCompleted} times ({_totalPoints} points)";
    }
}