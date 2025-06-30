using System;

class Checklist : Goal
{
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount;
    public Checklist(string goalType, string name, string description, int points, int bonus, int target) : base(goalType, name, description, points)
    {
        _bonusPoints = bonus;
        _targetCount = target;
        _currentCount = 0;
    }
    public Checklist(string goalType, string name, string description, int points, int bonus, int target, int current) : base(goalType, name, description, points)
    {
        _bonusPoints = bonus;
        _targetCount = target;
        _currentCount = current;

        if (_currentCount >= _targetCount)
        {
            base.IsComplete();
        }
    }
    public override void IsComplete()
    {
        _currentCount++;

        if (_currentCount >= _targetCount)
        {
            base.IsComplete();
        }
    }
    public override string SaveString()
    {
        return $"{base.SaveString()}~~{_bonusPoints}~~{_targetCount}~~{_currentCount}";
    }
    public override string DisplayString()
    {
        return $"{base.DisplayString()} -- Currently Completed: {_currentCount}/{_targetCount}";
    }
    public override int GetPoints()
    {
        if (_currentCount == _targetCount)
        {
            return base.GetPoints() + _bonusPoints;
        }
        else
        {
            return base.GetPoints();
        }
    }
}