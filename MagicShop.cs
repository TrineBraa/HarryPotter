namespace HarryPotter;

public class MagicShop
{

    public string _name;
    private List<string> Items = new List<string>()
    {
        "ugle",
        "rotte",
        "katt",
        "Fønisk stav",
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
        while (shopping)
        {
            Console.WriteLine("Welcome to the shop!");
            Console.WriteLine("Here are some options on what you can buy!");
            Console.WriteLine("\tExit to leave the shop");

            PrintShopItems();


            string ItemToBuy = Console.ReadLine();

            if (ItemToBuy == "Exit")
            {
                shopping = false;
                break;
            }

            BuyItem(ItemToBuy);
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