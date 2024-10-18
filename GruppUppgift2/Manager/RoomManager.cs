public class RoomManager
{
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
    }

    // Called whenever a new room is entered to show description from base class.
    public static void EnterRoom(string roomName)
    {
        currentRoom = rooms[roomName];
        //currentRoom.Display();
        Console.Write("press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }
}
