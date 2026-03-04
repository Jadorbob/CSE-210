public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

//-----------------------------------------------------

    public ReflectingActivity(string start, string end, string name, string description) 
    : base(start, end, name, description)
    {
        
    }

    //-----------------------------

    public void RunActivity(int time)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinnerPause(5);

        System.DateTime futureTime = QuestionTime(time);
        Random random = new Random();

        while (futureTime >= DateTime.Now)
        {
            Console.WriteLine("Consider the folowing prompt:\n");

            int randIndex = random.Next(_prompts.Count);
            Console.WriteLine($"--- {_prompts[randIndex]} ---\n");
            Console.WriteLine("When you have something in mind press ENTER to continue.");
            Console.ReadLine();

            Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            CountDown();
            Console.Clear();
            
            Console.Write($"{_questions[3]}");
            SpinnerPause(4);
            Console.Write($"\n{_questions[0]}");
            SpinnerPause(4);

            Console.WriteLine();
        }
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