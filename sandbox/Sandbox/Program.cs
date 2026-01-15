using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Hello World");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Something is wrong {e.ToString()}");

            // hello
        }
    }
}