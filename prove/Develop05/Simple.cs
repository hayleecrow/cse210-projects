using System;

class Simple : Goal
{
    public Simple(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        // pass parameters to base class
    }
    public Simple(string goalType, string name, string description, int points, bool completion) : base(goalType, name, description, points, completion)
    {
        // pass parameters to base class
    }
    public override string SaveString()
    {
        return $"{base.SaveString()}~~{base.GetCompletion()}";
    }
}