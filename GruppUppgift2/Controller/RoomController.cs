public static class RoomController
{
    public static List<Room> rooms = [];

    public static void CreateRooms()
    {
        Room room = new Room("Starting Room", "A room with 4 doors", { 1, 2, 3, 4 });
        rooms.Add(room);
    }
}
