using System;
using System.IO;

public class Journal
{
    public string _menu = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ";
    public List<string> _entries = new List<string>();
    string _fileName = "saveFile.csv";

    // ---------------------------

    public int MenuInput()
    {
        Console.Write($"\n{_menu}");
        string response = Console.ReadLine();
        return int.Parse(response);
    }
    public void DisplayFile()
    {
        foreach (string entry in _entries)
        {
            string[] parts = entry.Split("~");

            string line1 = parts[0];
            string line2 = parts[1];
            
            Console.WriteLine($"\n{line1}\n{line2}\n");
        }
    }
    public void LoadFile()
    {
        List<string> temp_list = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        
        Console.Write("\nWhat is your password? ");
        string password = Console.ReadLine();
        string code = lines[0];
        while (password != code)
        {
            Console.WriteLine("\nPassword incorrect. Try again. ");
            Console.Write("What is your password? ");
            password = Console.ReadLine();
        }
        bool firstline = true;
        foreach (string line in lines)
        {
            if (firstline)
            {
                firstline = false;
                continue;
            }
            temp_list.Add(line);
        }
            _entries = temp_list;
            Console.WriteLine("File Loaded.");
    }
    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            Console.Write("\nSet your password: ");
            string password = Console.ReadLine();
            outputFile.WriteLine(password);

            foreach (string line in _entries)
            {
                outputFile.WriteLine(line);
            }
        }
    }
}