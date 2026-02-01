using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public List<string> _prompts = new List<string>{
        "Who was the most interesting person I interacted with today? ", 
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "If I could redo something that I did today what would it be? ",
        "On a scale of 1-10 how would I rate my kindness to others today? ",
        "How much progress did I make with one of my goals today? ",
    };
    
    // --------------------

    public (string, string) WriteEntry()
    {
        Random random = new Random();
        int randIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randIndex];
        Console.WriteLine($"\n{randomPrompt}");

        string entry = Console.ReadLine();
        return (randomPrompt, entry);
    }
    public string ConstructFullEntry(string prompt, string entry)
    {
        string newToday = DateTime.Today.ToString("MM/dd/yyyy");
        string finished = $"Date: {newToday} -- Prompt: {prompt}~{entry}";
        return finished; 
    }
}