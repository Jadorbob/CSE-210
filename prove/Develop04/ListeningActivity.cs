public class ListeningActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public ListeningActivity(string start, string end, string name, string description) 
    : base(start, end, name, description)
    {
        
    }

    public void RunActivity(int time)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinnerPause(5);

        System.DateTime futureTime = QuestionTime(time);
        Random random = new Random();
        Console.WriteLine("List as many responses you can to the following prompt:");

        int randIndex = random.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[randIndex]} ---\n");

        Console.Write("You may begin in: ");
        CountDown();
        Console.WriteLine();

        int promptCount = 0;
        while (futureTime >= DateTime.Now)
        {
           Console.ReadLine();
           promptCount += 1; 
        }

        Console.WriteLine($"You listed {promptCount} items!");
        CountPause(1000);
    }
    public void CountDown()
    {      
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