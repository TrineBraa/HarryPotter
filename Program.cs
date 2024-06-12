using HarryPotter;

class Program
{
    static List<string> inventory = new List<string>() { "coffee cup" };
    static Character newCharacter = new Character("Trine", "Hufflepuff");
    static MagicShop shopMenu = new MagicShop("Magical shop");

    static void Main(string[] args)
    {
        Run();
    }

    static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("Welcome! What do you want to do?");
            Console.WriteLine("\n\t1. Go to Magic Shop");
            Console.WriteLine("\t2. Cast a spell");
            Console.WriteLine("\t3. Log out");
            Console.WriteLine("\t4. Get to know me!");

            int userInput;
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                switch (userInput)
                {
                    case 1:
                        shopMenu.ShopMenu();
                        break;
                    case 2:
                        SpellMenu();
                        break;
                    case 3:
                        Console.WriteLine("Logging out ...");
                        Environment.Exit(0);
                        break;
                    case 4:
                        Console.WriteLine($"My name is {newCharacter.GetName()}, my house is {newCharacter.GetHouse()}");
                        Console.WriteLine( PrintInventory());
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number");
            }
        }
    }

    static void SpellMenu()
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine("You wish to cast a spell? Write the spell you want to cast!");
            Console.WriteLine("\n\tKnown spells: Vingardium Leviosa, Hokus Pokus");
            Console.WriteLine("Type 'Exit' to return to the main menu.");

            var spell = Console.ReadLine();

            if (spell == "Vingardium Leviosa")
            {
                Console.WriteLine("The feather lifts and floats in the air! Good job!");
            }
            else if (spell == "Hokus Pokus")
            {
                Console.WriteLine("What a wonderful display of fireworks!");
            }
            else if (spell == "Exit")
            {
                break; // Exit SpellMenu loop and return to MainMenu
            }
            else
            {
                Console.WriteLine("That isn't even a spell! >:( Try again.");
            }
        }
    }

    static void Run()
    {
        MainMenu();
    }

    static string PrintInventory()
    {
        foreach (var item in inventory)
        {
            Console.WriteLine("I always have a " + item + " in my inventory");
        }

        return null;
    }



}
