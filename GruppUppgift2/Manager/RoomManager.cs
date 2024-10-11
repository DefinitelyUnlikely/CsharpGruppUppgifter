public class RoomManager
{
    public static List<Room> rooms = [];

    // Stores the currently active room
    public static Room currentRoom;

    // Called at game initialization to create all rooms.
    public static void CreateRooms()
    {
        //rooms.Add(new HubRoom().CreateRoom());
        rooms.Add(new ExampleRoom().CreateRoom());
    }

    // Called whenever a new room is entered to show description from base class.
    public static void EnterRoom(int roomId)
    {
        currentRoom = rooms[roomId];
        //currentRoom.Display();
        Console.Write("press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }
}
