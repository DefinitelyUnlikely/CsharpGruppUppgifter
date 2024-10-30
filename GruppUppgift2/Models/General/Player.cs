public class Player
{
    string Name { get; init; }
    public bool[] completedRooms = { false, false, false, false, false };
    public Inventory inventory = new Inventory();

    public Player(string name)
    {
        Name = name;
    }
}
