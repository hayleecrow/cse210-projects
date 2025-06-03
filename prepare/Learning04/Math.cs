using System;

class Math : Assignment
{
    private string _section;
    private string _problems;
    public Math(string name, string topic, string section, string problems) : base(name, topic)
    {
        _section = section;
        _problems = problems;
    }
    public string GetHomewordList()
    {
        string list = "";
        return list;
    }
}