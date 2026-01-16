using System;

class Program
{
    static void Main(string[] args)
    {
        bool PlayAgain = true;
        
        while (PlayAgain)
        {

            Random rng = new Random();
            int MagicNumber = rng.Next(1,99);
            
            Console.WriteLine("I am thinking of a number between 1 and 100! Try to guess!");
            string SGuess = Console.ReadLine();
            int guess = int.Parse(SGuess);
            
            while (MagicNumber != guess)
            {   
                if (MagicNumber > guess)
                {
                    Console.WriteLine("Higher");
                    SGuess = Console.ReadLine();
                    guess = int.Parse(SGuess);
                }
                else if (MagicNumber < guess)
                {
                    Console.WriteLine("Lower");
                    SGuess = Console.ReadLine();
                    guess = int.Parse(SGuess);
                }
            }

            Console.Write("Congrats! You got it! Do you want to play again? ");
            string IfPlayAgain = Console.ReadLine();
            IfPlayAgain.ToLower();

            if (IfPlayAgain == "no")
            {
                PlayAgain = false;
            }
        }
    }
}