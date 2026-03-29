using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>(); 
        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();
            DisplayMenu();
            string choiceInput = Console.ReadLine();
            choice = int.Parse(choiceInput);

            if (choice == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                
                Console.WriteLine("What is the type of goal you would like to create? ");
                choiceInput = Console.ReadLine();
                choice = int.Parse(choiceInput);
                
                Console.Write("What is the name of your goal? ");
                string nameInput = Console.ReadLine();

                Console.Write("\nWhat is the goal description? ");
                string descriptionInput = Console.ReadLine();

                Console.Write("\nHow many points is this goal worth? ");
                string pointValueInput = Console.ReadLine();
                int pointValue = int.Parse(pointValueInput);


                if (choice == 1)
                {
                    Goal goal1 = new SimpleGoal(nameInput, descriptionInput, pointValue);

                    _goals.Add(goal1);
                }
                else if (choice == 2)
                {
                    Goal goal1 = new EternalGoal(nameInput, descriptionInput, pointValue);

                    _goals.Add(goal1);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    string timesNeededInput = Console.ReadLine();
                    int timesNeeded = int.Parse(timesNeededInput);

                    Console.WriteLine("How many bonus points is this worth? ");
                    string bonusPointsInput = Console.ReadLine();
                    int bonusPoints= int.Parse(bonusPointsInput);

                    
                    Goal goal1 = new ChecklistGoal(nameInput, descriptionInput, pointValue, timesNeeded, bonusPoints);

                    _goals.Add(goal1);
                } else
                {
                    Console.Write("Enter a valid number");
                }

            }
            else if (choice == 2)
            {
                Console.WriteLine("The Goals are: ");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.Write($"\n{i + 1}. [{_goals[i].IsComplete()}] {_goals[i].GetName()} ({_goals[i].GetDescription()})");
                    if (_goals[i] is ChecklistGoal checklistGoal)
                    {
                        Console.WriteLine($" -- Currently completed: {checklistGoal.GetTimesCompleted()}/{checklistGoal.GetTimesNeeded()}");
                    }
                }
                Console.Write("\n\nPress ENTER to continue");
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                Save();
            }
            else if (choice == 4)
            {
                Load();
            }
            else if (choice == 5)
            {
                Console.WriteLine("The Goals are: ");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($" {i + 1} {_goals[i].GetName()}");
                }
                Console.WriteLine("Which goal did you accomplish?");
                string consoleInput = Console.ReadLine();
                int goalIndex = int.Parse(consoleInput);

                _goals[goalIndex - 1].RecordEvent();
            }
            else if (choice == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please Enter a valid input :)");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
            }
        }

    int PointTotaler()
    {
        int runningTotal = 0;
        
        foreach (Goal goal in _goals)
            {
                runningTotal += goal.GetPointsEarned();
            }

        return  runningTotal;
    }
    void DisplayMenu()
    {
        Console.WriteLine($"You have {PointTotaler()} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.WriteLine("Select a choice from the menu: ");

    }

    void Save()
    {
        Console.Write("Enter a password to protect your save file: ");
        string password = Console.ReadLine();

        Console.Write("Enter a file name: ");
        string fileName = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(password);

            foreach (Goal goal in _goals)
            {
                if (goal is ChecklistGoal cg)
                    outputFile.WriteLine($"ChecklistGoal|{cg.FileFormat()}|{cg.GetTimesCompleted()}|{cg.GetBonusPoints()}|{cg.GetPointsEarned()}");
                else if (goal is SimpleGoal sg)
                    outputFile.WriteLine($"SimpleGoal|{sg.FileFormat()}|{sg.GetPointsEarned()}");
                else if (goal is EternalGoal eg)
                    outputFile.WriteLine($"EternalGoal|{eg.FileFormat()}|{eg.GetPointsEarned()}");
            }
        }
    }

    void Load()
    {
        Console.Write("Enter the file name to load: ");
        string fileName = Console.ReadLine() + ".txt";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        Console.Write("Enter the password: ");
        string passwordAttempt = Console.ReadLine();

        if (passwordAttempt != lines[0])
        {
            Console.WriteLine("Incorrect password.");
            return;
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts     = lines[i].Split('|');
            string type        = parts[0];
            string name        = parts[1];
            string description = parts[2];
            int    points      = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                int pointsEarned = int.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, description, points, pointsEarned));
            }
            else if (type == "EternalGoal")
            {
                int pointsEarned = int.Parse(parts[4]);
                _goals.Add(new EternalGoal(name, description, points, pointsEarned));
            }
            else if (type == "ChecklistGoal")
            {
                int timesNeeded    = int.Parse(parts[4]);
                int bonusPoints    = int.Parse(parts[5]);
                int pointsEarned   = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(name, description, points, timesNeeded, bonusPoints, pointsEarned));
            }
        }
    }

}

}