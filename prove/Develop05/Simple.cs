using System;

class Simple : Goal
{
    private bool _completion;
    public Simple(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        _completion = false;
    }
    public Simple(string goalType, string name, string description, int points, bool completion) : base(goalType, name, description, points)
    {
        _completion = completion;
    }
    public override void IsComplete()
    {
        base.IsComplete();
    }
    public override void RecordEvent()
    {
        base.RecordEvent();
    }
    public override string SaveString()
    {
        return $"{base.SaveString()}~~{_completion}";
    }
}