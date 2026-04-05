using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Dirt Bike Survival. The goal of Dirt Bike Survival is to go find items on your dirtbike!");
        Console.WriteLine("Press ENTER to start the game!");
        Console.ReadLine();

        Motorbike PlayerBike = ChooseABike();

        Console.WriteLine("Great! You are ready to go. Hit ENTER to continue!");
        Console.ReadLine();

        Inventory inventory = new Inventory();
        Player player = new Player(PlayerBike, inventory);

        List<Location> Locations = CreateThreeLocations();

        while (player.IsAlive() && PlayerBike.IsAlive())
        {
            DisplayMenu();
            string input = Console.ReadLine();
            int action = int.Parse(input);

            if (action == 1)
            {
                PlayerBike.Ride();
                Console.WriteLine("\n\nPick a location to visit:");
                foreach (Location location in Locations)
                {
                    location.Display();
                }
                Console.WriteLine("Input a number 1-3");
                string input2 = Console.ReadLine();
                int choice2 = int.Parse(input2);

                Locations[choice2 - 1].Visit();
                Pause();
            }
            else if (action == 2)
            {
                Console.WriteLine();
                player.DisplayStats();
                inventory.ShowItems();
                Pause();
            }
            else if (action == 3)
            {
                Console.Clear();
                Console.WriteLine($"Which item do you want to use?");
                Console.WriteLine($"1. Medkit");
                Console.WriteLine($"2. Repairkit");
                Console.Write("Enter your number: ");
                
                string input3 = Console.ReadLine();
                int itemUse = int.Parse(input3);

                Item Medkit = new Item("Medkit", 1);
                Item Repairkit = new Item("Repairkit", 2);
                if (itemUse == 1)
                {
                    Medkit.UseItem(player, PlayerBike);
                    Console.WriteLine("\nMedkit Used!");
                } else
                {
                    Repairkit.UseItem(player, PlayerBike);
                    Console.WriteLine("\nToolbox Used!");
                }
                Pause();
            }
                
            else if (action == 4) 
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                Pause();
            }

        }

    }

    public static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Here are your options: ");
        Console.WriteLine("1. Ride!");
        Console.WriteLine("2. Stats/Inventory");
        Console.WriteLine("3. Use an Item");
        Console.WriteLine("4. Quit Game");
        Console.Write("Choose an option: ");
    }

    public static Motorbike ChooseABike()
    {
        Console.WriteLine("You must first choose a motorbike!");
        Console.WriteLine("There are three types of Bikes:");
        Console.WriteLine(" 1. Cruiser");
        Console.WriteLine(" 2. DirtBike");
        Console.WriteLine(" 3. SportBike");
        Console.Write("Choose a number: ");
        string input = Console.ReadLine();
        int bikeNum = int.Parse(input);

        if (bikeNum == 3)
        {
            Motorbike playerBike = new SportBike();
            return playerBike;
        }
        else if (bikeNum == 2)
        {
            Motorbike playerBike = new DirtBike();
            return playerBike;
        }
        else
        {
            Motorbike playerBike = new Cruiser();
            return playerBike;
        }
    }

    public static List<Location> CreateThreeLocations()
    {
        Item Medkit = new Item("Medkit", 1);
        Item Repairkit = new Item("Repairkit", 2);
        List<Location> Locations = new List<Location>();

        Location Hotel = new Location("Hotel", 100, "A place for people to sleep", Medkit);
        Location SwimmingPool = new Location("SwimmingPool", 100, "A place for people to swim", Repairkit);
        Location DustyTown = new Location("DustyTown", 250, "An Abandoned Town", Repairkit);

        Locations.Add(Hotel);
        Locations.Add(SwimmingPool);
        Locations.Add(DustyTown);

        return Locations;
    }

    public static void Pause()
    {
        Console.WriteLine("\nPress ENTER to continue.");
        Console.ReadLine();
    }
}
