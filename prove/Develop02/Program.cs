using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        Entry entry1 = new Entry();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        
        int response = journal1.MenuInput();
        while (response != 5)
        {
           
           if(response == 1)
            {
                (string var1, string var2) = entry1.WriteEntry();
                string var4 = entry1.ConstructFullEntry(var1, var2);

                journal1._entries.Add(var4);

                response = journal1.MenuInput();
            } 
            else if (response == 2)
            {
                journal1.DisplayFile();

                response = journal1.MenuInput();
            }
            else if (response == 3)
            {
                journal1.LoadFile();
                response = journal1.MenuInput();
            }
            else if (response == 4)
            {
                journal1.SaveFile();
                response = journal1.MenuInput();
            }
            
        }
    }
}