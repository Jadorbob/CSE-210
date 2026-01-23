public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    public void Display()
    {
        Console.WriteLine(_company);
        Console.WriteLine(_jobTitle);
        Console.WriteLine(_startYear);
        Console.WriteLine(_endYear);
    }
}
