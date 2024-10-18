public class Player
{
    string Name { get; set; }
    public bool[] completedRooms = { false, false, false, false, false };
    public Inventory inventory = new Inventory();

    // Om vi tänkte identifiera rum med namn, tänker jag att vi kör str istället för int.
    // Om player objektet ens behöver denna, RoomManager har en currentRoom.
    // string currentRoom = "";

    public Player(string name)
    {
        Name = name;
    }
}
