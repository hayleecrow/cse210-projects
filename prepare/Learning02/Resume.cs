public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        for (int i = 0; i < _jobs.Count; i++)
        {
            _jobs[i].Display();
        }

        // or could do the following:
        // foreach (Job job in _jobs)
        // {
        //    job.Display();
        // }
    }
}