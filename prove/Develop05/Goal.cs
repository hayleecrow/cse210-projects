using System;

class Goal
{
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;
    public Goal(string goalType, string name, string description, int points)
    {
        //
    }
    public virtual void IsComplete()
    {
        //
    }
    public virtual void RecordEvent()
    {
        //
    }
    public virtual string SaveString()
    {
        return $"save";
    }
    public int GetPoints()
    {
        return _points;
    }
}