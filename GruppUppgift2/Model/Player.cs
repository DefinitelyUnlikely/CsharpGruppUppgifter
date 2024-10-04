public class Player
{
    string Name { get; set; }
    bool[] completedRooms = { false, false, false, false, false };

    int currentRoom = 0;
}
