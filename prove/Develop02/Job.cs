public class Job
{
    public string _startDate;
    public  string _endDate;
    public string _title;

    // -------------------------------------

    public string GetDescription()
    {
        return $"Job: {_title} starting {_startDate} ending {_endDate}";
    }
}