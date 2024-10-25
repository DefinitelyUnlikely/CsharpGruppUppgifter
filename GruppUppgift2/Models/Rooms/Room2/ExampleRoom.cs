public class ExampleRoom
{
    // Name of the room.
    string name = "The Laboratory";

    // Short introduction to the room. Only shown once?
    // Add a continue command to go to first Chapter.
    string description =
        @"You find yourself in an old, abandoned laboratory. The room is dimly lit, with flickering 
fluorescent lights casting eerie shadows. The air is thick with dust, and the faint smell of chemicals lingers.";

    // List of all the items at the start of a room.
    List<GameObject> items =
        new()
        {
            new GameObject("door", "A heavy reinforced steel door with a digital <keypad>"),
            new CollectibleItem(
                "screwdriver",
                "A regular screwdriver. Maybe you can open something with it.",
                "grate"
            ),
            new GameObject(
                "workbench",
                @"On the workbench, there are various tools and a partially disassembled robot. Among the tools, you find
    a <screwdriver> and a pair of <pliers>."
            ),
            new GameObject("Grate", "A grate fastened with screws."),
        };

    List<Chapter> chapters =
        new()
        {
            // First Chapter is the main description of the room. (required)
            new Chapter(
                "Introduction",
                @"The main exit is a heavy, reinforced <door> with a digital <keypad>. 
On a desk in the middle of the room theres a <computer> terminal but 
it requires a password to access. On one of the walls, there's a <poster> of 
the periodic table."
            ),
            // Optional Chapters after the main one.
            new Chapter("Chapter one", "Continuation of the story."),
        };

    public Room CreateRoom()
    {
        // Story is a class containing all Chapters and keeps track of where in the story you are.
        Story story = new Story(chapters);
        Room room = new(name, description, story, items, null);
        return room;
    }
}
