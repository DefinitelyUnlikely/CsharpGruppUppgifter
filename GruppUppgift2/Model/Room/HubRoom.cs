public class HubRoom
{
    // Name of the room.
    string name = "The Hub";

    // Short introduction to the room. Only shown once?
    // Add a continue(press any key) command to go to first Chapter.
    string description = @"Welcome to the simulation. Complete all rooms to win";

    // List of all the items at the start of a room.
    List<GameObject> items =
        new() /*
        {
            new GameObject("steel door", "A heavy reinforced <steel door>"),
            new GameObject("wooden door", "A <wooden door>"),
            new GameObject("door3", "A door named door3."),
            new GameObject("left door", "A door to your left"),
        }*/
    ;

    List<Chapter> chapters =
        new()
        {
            // First Chapter is the main description of the room. (required)
            new Chapter(
                "Introduction",
                @"There are four doors. A <steel door>, a <wooden door>, <door3> and a door to your left<left door>."
            ),
            new Chapter(
                "One room completed",
                "You've completed one of the rooms, three remaining."
            ),
        };

    public Room CreateRoom()
    {
        // Story is a class containing all Chapters and keeps track of where in the story you are.
        Story story = new Story(chapters);
        Room room = new(name, description, items, story);
        return room;
    }
}
