public class HubRoom
{
    // Name of the room.
    string name = "The Hub";

    // Short introduction to the room. Only shown once?
    // Add a continue(press any key) command to go to first Chapter.
    string description = @"Welcome to the simulation. Complete all rooms to win";

    Menu menu = new HubMenu();

    // List of all the items at the start of a room.
    List<GameObject> items =
        new()
        {
            new GameObject("steel door", "A heavy reinforced <steel door>"),
            new GameObject("wooden door", "A <wooden door>"),
        };

    List<Chapter> chapters =
        new()
        {
            // First Chapter is the main description of the room. (required)
            new Chapter(
                "Introduction",
                @"There are four doors. A <steel door>, a <wooden door>, Not implemented: <door3> and a door to your left<left door>."
            ),
            new Chapter(
                "One room completed",
                "You've completed one of the rooms, three remaining."
            ),
        };

    string[] connectedRooms = ["The Library", "The Workshop", "The Mystery Room"];

    public Room CreateRoom()
    {
        // Story is a class containing all Chapters and keeps track of where in the story you are.
        Story story = new Story(chapters);
        Room room = new(name, description, story, connectedRooms, items, menu);
        return room;
    }
}
