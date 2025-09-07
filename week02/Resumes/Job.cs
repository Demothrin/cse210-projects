public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startDate = 0;
    public int _endDate = 0;

    public Job()
    {

    }

    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startDate}-{_endDate}");
    }

}