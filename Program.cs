using HarryPotter;

List<string> inventory = new List<string>() { "coffee cup" };
Character newCharacter = new Character("Trine", "Hufflepuff");
MagicShop shopMenu = new MagicShop("Magical shop");

Main();

void Main()
{
    Console.Clear();

    Console.WriteLine("Welcome! What do you want to do?");
    Console.WriteLine("\n\t1. Go to Magic Shop");
    Console.WriteLine("\t2. Cast a spell");
    Console.WriteLine("\t3. Log out");
    
    MainMenu();


}






void MainMenu()
{

    int userInput = int.Parse(Console.ReadLine());


    while (true)
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
            default:
                Console.WriteLine("Invalid input, please try again");
                break;
        }
    }
}









void SpellMenu()
{
    Console.Clear();

    bool Spellkasting = true;
    while (Spellkasting)
    {


        Console.WriteLine("You wish to cast a spell? write the spell you want to cast!");
        Console.WriteLine("\n\tKnown spells: Vingardium Leviosa, Hokus Pokus");
        Console.WriteLine("Exit to return to the menu.");
        var spell = Console.ReadLine();

        if (spell == "Vingardium Leviosa")
        {
            Console.WriteLine("The feather lifts and floats in the air! good job!");
        }
        else if (spell == "Hokus Pokus")
        {
            Console.WriteLine("What a wonderful display of fireworks!");
        }
        else if (spell == "Exit")
        {
            Spellkasting = false;
            break;

        }
        else
        {
            Console.WriteLine("That isn't even a spell! Try again.");
        }

    }

}



void PrintInventory()
{
    foreach (var item in inventory)
    {
        Console.WriteLine($"{item}");
    }
}

Console.WriteLine(
    $"Name: {newCharacter.GetName()}, house: {newCharacter.GetHouse()}");