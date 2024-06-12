namespace HarryPotter;
public class Character
{
    private string _name;
    private string _house;
    private List<string> _inventory;

    public Character(string name, string house)
    {
        _name = name;
        _house = house;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetHouse()
    {
        return _house;
    }

    public List<string> GetInventory()
    {
        return _inventory;
    }

  


}
