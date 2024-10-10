namespace GruppUppgift2.Model;

public class Player
{
    string Name { get; set; }
    bool[] completedRooms = { false, false, false, false, false };
    public Inventory inventory = new Inventory();

    // Om vi tänkte identifiera rum med namn, tänker jag att vi kör str istället för int.
    string currentRoom = "";

}
