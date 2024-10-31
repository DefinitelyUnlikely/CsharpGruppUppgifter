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
            new Exit("exit", "A smooth plastic looking door, with the word <exit> on it."),
            new Room1Door("steel door", "A heavy reinforced <steel door>. The sign reads 'Hologram"),
            new Room2Door("wooden door", "A <wooden door>. The sign reads 'The Workshop'"),
            new Room3Door("mysterious door", "A <mysterious door>. The sign reads 'The Mystery Room'"),
            new Room4Door("old door", "An <old door>, black from mold. The sign reads 'The Library'"),

            new ControlPanel("control panel", "A panel with 4 lights flashing red.")
        };

    List<Chapter> chapters =
        new()
        {
            // First Chapter is the main description of the room. (required)
            new Chapter(
                "Introduction",
                """
                You find yourself in the middle of a large room. Right in front of you is a <control panel>, with lights and a button on it.
                They seem to indicate your progress. Currently, they are all flashing red. You also see a large, smooth,
                almost plastic looking door with the text <exit> written over it. A red light above the door tells you
                it is currently inaccessible. Besides that, the room is barren. The walls look weirdly 'sci-fi'ish.
                But you notice that along the walls of the room are 4 doors. One <steel door>, one <wooden door>, one <mysterious door>
                and finally one <old door>. All the doors have signs over them, but they are too far away for you to be able to discern what
                they say from this distance. You will probably have to get in closer and inspect them if you wish to read the text. 
                """
            ),
            new Chapter(
                "One room completed",
                """
                You find yourself in the middle of a large room. Right in front of you is a <control panel>, with lights and a button on it.
                They seem to indicate your progress. Currently, All but one is flashing red. You also see a large, smooth,
                almost plastic looking door with the text <exit> written over it. A red light above the door tells you
                it is currently inaccessible. Besides that, the room is barren. The walls look weirdly 'sci-fi'ish.
                But you notice that along the walls of the room are 4 doors. One <steel door>, one <wooden door>, one <mysterious door>
                and finally one <old door>. All the doors have signs over them, but they are too far away for you to be able to discern what
                they say from this distance. You will probably have to get in closer and inspect them if you wish to read the text. 
                """
            ),
            new Chapter(
                "Two rooms completed",
                """
                You find yourself in the middle of a large room. Right in front of you is a <control panel>, with lights and a button on it.
                They seem to indicate your progress. Now, two of them flash a satisfying green. You also see a large, smooth,
                almost plastic looking door with the text <exit> written over it. A red light above the door tells you
                it is currently inaccessible. Besides that, the room is barren. The walls look weirdly 'sci-fi'ish.
                But you notice that along the walls of the room are 4 doors. One <steel door>, one <wooden door>, one <mysterious door>
                and finally one <old door>. All the doors have signs over them, but they are too far away for you to be able to discern what
                they say from this distance. You will probably have to get in closer and inspect them if you wish to read the text. 
                """
            ),
            new Chapter(
                "Three rooms completed",
                """
                You find yourself in the middle of a large room. Right in front of you is a <control panel>, with lights and a button on it.
                They seem to indicate your progress. Now, three of them flash green. You can almost taste freedom. You also see a large, smooth,
                almost plastic looking door with the text <exit> written over it. A red light above the door tells you
                it is currently inaccessible. Besides that, the room is barren. The walls look weirdly 'sci-fi'ish.
                But you notice that along the walls of the room are 4 doors. One <steel door>, one <wooden door>, one <mysterious door>
                and finally one <old door>. All the doors have signs over them, but they are too far away for you to be able to discern what
                they say from this distance. You will probably have to get in closer and inspect them if you wish to read the text. 
                """
            ),
            new Chapter(
                "Four rooms completed",
                """
                You find yourself in the middle of a large room. Right in front of you is a <control panel>, with lights on it.
                They seem to indicate your progress. All of them flash green. Perhaps time to press the button? You also see a large, smooth,
                almost plastic looking door with the text <exit> written over it. A red light above the door tells you
                it is currently inaccessible. Besides that, the room is barren. The walls look weirdly 'sci-fi'ish.
                But you notice that along the walls of the room are 4 doors. One <steel door>, one <wooden door>, one <mysterious door>
                and finally one <old door>. All the doors have signs over them, but they are too far away for you to be able to discern what
                they say from this distance. You will probably have to get in closer and inspect them if you wish to read the text. 
                """
            ),
            new Chapter(
                "Control panel button pressed",
                """
                You find yourself in the middle of a large room. Right in front of you is a <control panel>, with lights on it.
                They seem to indicate your progress. All of them flash green. You also see a large, smooth,
                almost plastic looking door with the text <exit> written over it. A green light now shines above it,
                signaling to you that you may finally exit. 
                """
            ),

        };

    string[] connectedRooms = ["Hologram", "The Workshop", "The Mystery Room", "The Library"];

    public Room CreateRoom()
    {
        // Story is a class containing all Chapters and keeps track of where in the story you are.
        Story story = new Story(chapters);
        Room room = new(name, description, story, connectedRooms, items, menu);
        return room;
    }
}
