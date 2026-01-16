using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type zero when finished. ");
        
        List<int> numbers = new List<int>();
        int NumberAdded = -1;

        while (NumberAdded != 0)
        {
            Console.Write("Enter number: ");
            
            string SNumber = Console.ReadLine();
            NumberAdded = int.Parse(SNumber);

            if (NumberAdded != 0)
            {   
                numbers.Add(NumberAdded);
            }
        }

        int Total = 0;
        int Count = 0;
        foreach (int number in numbers)
        {
            Total += number;
            Count++;
        }
        int Average = Total/Count;
        int Largest = numbers.Max();


        Console.WriteLine($"The Sum is: {Total}");
        Console.WriteLine($"The average is: {Average}");
        Console.WriteLine($"The largest number is: {Largest}");
    }
}