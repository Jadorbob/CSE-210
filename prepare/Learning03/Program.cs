using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction MyFraction1 = new Fraction();
        Random random = new Random();
        
        for (int i = 0; i < 20 ;i++)
        {
            
            MyFraction1.SetTop(random.Next(1, 100));
            MyFraction1.SetBottom(random.Next(1, 100));

            Console.WriteLine(MyFraction1.GetFractionString());
            Console.WriteLine(MyFraction1.GetDecimal());
        }
    }
}