public class BreathingActivity : Activity
{
    public BreathingActivity(string start, string end, string name, string description) 
    : base(start, end, name, description)
    {
        
    }

    //----------------------------

    public void RunActivity(int time)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinnerPause(5);

        System.DateTime futureTime = QuestionTime(time);

        while (futureTime >= DateTime.Now)
        {
            BreatheIn();
            BreatheOut();
        }
    }

    public void BreatheIn()
    {
        Console.Write("\n\nBreathe in...");
           
            Console.Write("4");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("3");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("2");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("1");
            Thread.Sleep(500);
            Console.Write("\b \b");
    }
    public void BreatheOut()
    {
        Console.Write("\nBreathe out...");
            Console.Write("4");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("3");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("2");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("1");
            Thread.Sleep(500);
            Console.Write("\b \b");
    }
}