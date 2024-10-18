using System.Linq;

public class RoomManager
{
    // Dictionary med alla rum. Room.Name används som key.
    public static Dictionary<string, Room> rooms = [];

    // Stores the currently active room
    public static Room currentRoom;

    // Called at game initialization to create all rooms.
    public static void CreateRooms()
    {
        //rooms.Add(new HubRoom().CreateRoom());
        Room example = new ExampleRoom().CreateRoom();
        rooms.Add(example.Name, example);

        Room library = new MartinsRoom().CreateRoom();
        rooms.Add(library.Name, library);

        Room speed = new SpeedTrialRoom().CreateRoom();
        rooms.Add(speed.Name, speed);

        currentRoom = rooms["The Library"];
    }

    // Called whenever a new room is entered to show description from base class.
    public static void EnterRoom(string roomName)
    {
        currentRoom = rooms[roomName];
        currentRoom.Display();
        // MenuManager.GetCurrentMenu().TryExecuteCommand("help");
        // Deprecated. Runs in Menu.SetMenu()
        Console.Write("press any key to continue");
        Console.ReadKey();
        Console.Clear();
        currentRoom.StartRoom();
    }
}
