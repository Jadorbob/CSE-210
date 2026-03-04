public class Activity
{
    private string _startMessage;
    private string _endMessage;
    private string _activityName;
    private string _activityDescription;

    // -------------------------------------

    public Activity(string start, string end, string name, string description)
    {
        _startMessage = start;
        _endMessage = end;
        _activityName = name;
        _activityDescription = description;
    }

    // ----------------------------------------

    public void DisplayStartMessage()
    {
        Console.WriteLine(_startMessage);
    }

    public void DisplayDescription()
    {
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
        
    }
    public void SpinnerPause(int times)
    {
        int iteration = 0;
        while (iteration != times)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");

            iteration += 1;
        }
    }
    public void CountPause(int time)
    {
        Thread.Sleep(time);
    }
    public System.DateTime QuestionTime(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        return futureTime;
    }

    public void PressEnterPause()
    {
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
    }

    public (string, string, string, string) GetInfo()
    {
        return (_startMessage, _endMessage, _activityName, _activityDescription);
    }
}