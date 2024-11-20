using System;

public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public void Display()
    {
        Console.WriteLine($"Resume of {Name}:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.DisplayJobDetails();
        }
    }
}