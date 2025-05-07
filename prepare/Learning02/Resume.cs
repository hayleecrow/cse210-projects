public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine(_name);
        for (int i = 0; ;i++)
        {
            Console.WriteLine(_jobs[i]._jobTitle);
        }
    }
}