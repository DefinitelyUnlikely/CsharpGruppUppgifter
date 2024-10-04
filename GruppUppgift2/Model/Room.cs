public class Room : Object
{
    public int[] ConnectsToRoom { get; set; }

    public Room(string name, string description, int[] connectsToRoom)
    {
        Name = name;
        Description = description;
        ConnectsToRoom = connectsToRoom;
    }
}
