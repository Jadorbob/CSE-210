using System;

class Program
{
    static void Main(string[] args)
    {
        string script = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";
        
        Reference nephi1 = new Reference("1 Nephi", 1, "1");
        Scripture myscripture1 = new Scripture(nephi1, script);
        
        do 
        {
            Console.Clear();
            myscripture1.PrintFullScripture();

            Console.WriteLine("\n\nPress ENTER to continue or type 'quit' to finish!");
            string response = Console.ReadLine();

            if (response == "quit")
            {
                break;
            }

            myscripture1.Make3Invisible();

        } while (myscripture1.AreAllInvisible());

        Console.WriteLine("Time for your test! Type it by memory: ");
        string check = Console.ReadLine();

        if (check != script)
        {
            Console.WriteLine("\nUnfortunatly, you failed. Better luck next time...");
        } else
        {
            Console.WriteLine("\nYou did it!! I'm very proud of you!!");
        }

    }
}