using System;

class Goal
{
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;
    private bool _completion;
    public Goal(string goalType, string name, string description, int points)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _completion = false;
    }
    public Goal(string goalType, string name, string description, int points, bool completion)
    { 
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _completion = completion;
    }
    public virtual void IsComplete()
    {
        _completion = true;
    }
    public void RecordEvent()
    {
        IsComplete();
    }
    public virtual string SaveString()
    {
        return $"{_goalType}|{_name}~~{_description}~~{_points}";
    }
    public virtual string DisplayString()
    {
        string x = " ";
        if (_completion == true)
        {
            x = "X";
        }

        return $"[{x}] {_name} ({_description})";
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public bool GetCompletion()
    {
        return _completion;
    }
    public string GetName()
    {
        return _name;
    }
}