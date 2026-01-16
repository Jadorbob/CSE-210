using System;

class Program
{
    static void WelcomeMessage() 
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string AskUserName() 
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }
    static int AskUserNumber() 
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }
    static void AskUserBirth(out int BirthYear)
    {
        Console.Write("What is your birth year? ");
        BirthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int x) 
    {
        return x * x;
    }
    static void DisplayResult(string name, int SquareNumber, int BirthYear) 
    {
        int age = 2026 - BirthYear;
        
        Console.WriteLine($"{name}, the square of your number is {SquareNumber}.");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    
    static void Main(string[] args)
    {
        WelcomeMessage();

        string name = AskUserName();
        int number = AskUserNumber();
        int square = SquareNumber(number);

        AskUserBirth(out int BirthYear);

        DisplayResult(name, square, BirthYear);
    }
}