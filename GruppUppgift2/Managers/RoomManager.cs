public class RoomManager
{
    // Dictionary med alla rum. Room.Name används som key.
    public static Dictionary<string, Room> rooms = [];

    // Stores the currently active room
    public static Room currentRoom;

    // Ha koll på senaste rum för "leave"-kommando."
    private static string lastRoom;

    // Called at game initialization to create all rooms.
    public static void CreateRooms()
    {
        // Bara för att quit till main menu ska funka.
        if (rooms.Count != 0)
        {
            currentRoom = rooms["The Hub"];
            return;
        }

        // Skapar alla rummen i spelet.
        Room hub = new HubRoom().CreateRoom();
        rooms.Add(hub.Name, hub);

        Room hologram = new Hologram().CreateRoom();
        rooms.Add(hologram.Name, hologram);

        Room workshop = new Workshop().CreateRoom();
        rooms.Add(workshop.Name, workshop);

        Room mystery = new MysteryRoom().CreateRoom();
        rooms.Add(mystery.Name, mystery);

        Room library = new TheLibrary().CreateRoom();
        rooms.Add(library.Name, library);

        currentRoom = rooms["The Hub"];
    }

    // Called whenever a new room is entered to show description from base class.
    public static void EnterRoom(string roomName)
    {
        Console.Clear();
        lastRoom = currentRoom.Name;
        currentRoom = rooms[roomName];
        currentRoom.Display();
        // MenuManager.GetCurrentMenu().TryExecuteCommand("help");
        // Deprecated. Runs in Menu.SetMenu()
        Console.WriteLine("press any key to continue");
        Console.ReadKey(true);
        currentRoom.StartRoom();
    }

    // Används av enter command för
    public static void TryEnterRoom(string roomName)
    {
        foreach (string name in currentRoom.ConnectedRooms)
        {
            if (roomName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                EnterRoom(name);
                return;
            }
        }
        Console.WriteLine("No room with that name. Available rooms are: ");
        Console.WriteLine(string.Join(", ", currentRoom.ConnectedRooms));
    }

    public static void LeaveRoom()
    {
        EnterRoom(lastRoom);
    }

}
