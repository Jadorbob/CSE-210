using System;

class Program
{
    static void Main(string[] args)
    {
//--------------------------------------------
        string input = "";
        string bActName = "Breathing Activity";
        string rActName = "Reflecting Activity";
        string lActName = "Listening Activity";

        string bActWel = "Welcome to the Breathing Activity.";
        string rActWel = "Welcome to the Reflecting Activity.";
        string lActWel = "Welcome to the Listening Activity.";

        string bActDes = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string rActDes = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string lActDes = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        string actPrompt = "How long, in seconds, would you like for your session? ";

        string wellDone = "Well done!!";

        string bActEnd = "You have completed another Breathing Activity.";
        string rActEnd = "You have completed another Reflecting Activity.";
        string lActEnd = "You have completed another Listening Activity.";
//---------------------------------------------

        while (input != "4")
        {
            Console.Clear();
            DisplayMenu();
            input =  Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity activity1 = new BreathingActivity(bActWel, bActEnd, bActName, bActDes);
                Console.Clear();

                activity1.DisplayStartMessage();
                activity1.DisplayDescription();
                Console.WriteLine();
                Console.WriteLine(actPrompt);
                
                string sTime = Console.ReadLine();
                int time = int.Parse(sTime);

                activity1.RunActivity(time);
                Console.Clear();
                Console.WriteLine(wellDone);
                activity1.SpinnerPause(4);

                activity1.DisplayEndMessage();
                activity1.SpinnerPause(4);
                Console.Clear();

            } else if (input == "2")
            {
                ReflectingActivity activity2 = new ReflectingActivity(rActWel, rActEnd, rActName, rActDes);
                Console.Clear();

                activity2.DisplayStartMessage();
                activity2.DisplayDescription();
                Console.WriteLine();
                Console.WriteLine(actPrompt);
                
                string sTime = Console.ReadLine();
                int time = int.Parse(sTime);

                activity2.RunActivity(time);
                
                Console.WriteLine(wellDone);
                activity2.SpinnerPause(4);

                activity2.DisplayEndMessage();
                activity2.SpinnerPause(4);
                Console.Clear();

            } else if (input == "3")
            {
                ListeningActivity activity3 = new ListeningActivity(lActWel, lActEnd, lActName, lActDes);
                Console.Clear();

                activity3.DisplayStartMessage();
                activity3.DisplayDescription();
                Console.WriteLine();
                Console.WriteLine(actPrompt);
                
                string sTime = Console.ReadLine();
                int time = int.Parse(sTime);

                activity3.RunActivity(time);
                Console.Clear();
                Console.WriteLine(wellDone);
                activity3.SpinnerPause(4);

                activity3.DisplayEndMessage();
                activity3.SpinnerPause(4);
                Console.Clear();

            } else if (input == "4")
            {
                
            } else
            {
                Console.WriteLine("Please enter a valid number!");
                Thread.Sleep(1000);
            }
        }
        
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start Reflecting activity");
        Console.WriteLine(" 3. Start listening activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}