using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int perToLet = int.Parse(percentage);

        string letter;

        if (perToLet >= 90)
        {
            letter = "A";
        }
        else if (perToLet >= 80)
        {
            letter = "B";
        }
        else if (perToLet >= 70)
        {
            letter = "C";
        }
        else if (perToLet >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (perToLet < 70)
        {
            Console.WriteLine("You Failed! Better luck next time champ!");
        }
        else
        {
            Console.WriteLine("You Passed! :)");
        }
    }
}