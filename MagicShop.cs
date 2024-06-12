
namespace HarryPotter
{
    public class MagicShop
    {
        public string _name;
        private List<string> Items = new List<string>()
    {
        "ugle",
        "rotte",
        "katt",
        "Føniks stav",
        "Enhjørning stav",
        "Troll stav",
    };

        public MagicShop(string Name)
        {
            _name = Name;
        }

        public void ShopMenu()
        {
            var shopping = true;
            while (true)
            {
                Console.WriteLine("Welcome to the shop!");
                Console.WriteLine("Here are some options on what you can buy!");
                Console.WriteLine("\tExit to leave the shop");

                PrintShopItems();

                string ItemToBuy = Console.ReadLine();

                switch (ItemToBuy)
                {
                    case "ugle":
                        Console.WriteLine("You bought an owl :P");
                        break;
                    case "rotte":
                        Console.WriteLine("You bought yourself a rat 8)");
                        break;
                    case "katt":
                        Console.WriteLine("You just bought a cat :DD");
                        break;
                    case "føniks stav":
                        Console.WriteLine("The phoenix wand was an awesome choice!");
                        break;
                    case "enhjørning stav":
                        Console.WriteLine("The unicorn wand is an excellent choice!");
                        break;
                    case "troll stav":
                        Console.WriteLine("The magic wand is a superb choice!");
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("The item is not in the list, please try again");
                        break;
                }
                if (ItemToBuy == "exit")
                {
                    break;
                }

                // if (ItemToBuy == "Exit")
                // {
                //     shopping = false;
                //     break;
                // }
                // BuyItem(ItemToBuy);
            }
        }

        public void PrintShopItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }

        public void BuyItem(string ItemToBuy)
        {
            var foundItem = Items.Where(items => items.Contains(ItemToBuy));
            Console.WriteLine(foundItem);
        }
    }
}




