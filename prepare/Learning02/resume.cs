public class Resume
{
    public string _bmpName;
    public List<Job> _bmpJobs = new List<Job>();

    public void BmpDisplay()
    {
        Console.WriteLine(_bmpName);
        foreach (Job bmpJob in _bmpJobs)
        {
            bmpJob.BmpDisplayJobDetails();
        }
    }
}