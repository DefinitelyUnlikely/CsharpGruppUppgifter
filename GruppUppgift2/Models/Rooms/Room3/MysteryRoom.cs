public class MysteryRoom
{
    public string Name { get; } = "The Mystery Room";
    public string Description { get; } = "You have entered a seemingly normal room. There is a large wall, a window, and a table with a chair in front of the wall. A lamp is hanging from the ceiling. The room feels strange, as if it hides more than meets the eye.";
    public Menu Menu { get; } = new MysteryRoomMenu();

    public List<GameObject> items =
    [
        new Lamp("lamp", "A simple lamp. You can either 'turn it off' or 'leave it on'."),
        new Chair("chair", "An old chair in front of the table."),
        new Module("module", "A panel with all the letters of the alphabet.")
    ];

    // Definiera kapitel
    private List<Chapter> chapters =
    [
        new Chapter(
            "introduction",
            """
            You are in a mysterious room filled with strange artifacts.
            A <lamp> hangs from the ceiling, illuminating a table with a <chair>.
            In front of the chair, on the table, is a <module>, but it seems to lack power.
            What will you do?
            """
            ),
        new Chapter(
            "lamp_off",
            """
            You are in a mysterious room filled with strange artifacts.
            A <lamp> hangs from the ceiling, currently not providing any light to the room.
            The wall is filled with illuminated red squares, which had been invisible while the <lamp> was still shining brightly.
            The <chair> is barely visible, but the <module> on the table seems to have turned on.
            What will you do?
            """
             ),
        new Chapter(
            "hangman_win",
            """
            You are in a mysterious room filled with strange artifacts.
            A <lamp> hangs from the ceiling, currently not providing any light to the room.
            The wall is filled with illuminated red squares, now showing the letters you previously entered.
            The <chair> is barely visible, but the <module> seems to have turned on.
            The hidden compartment is lit up from the inside, and a <box> is clearly visible inside of it.
            What will you do?
            """
             ),
    ];

    public Room CreateRoom()
    {
        Story story = new(chapters);
        Room room = new(Name, Description, story, ["The Hub"], items, Menu);
        return room;
    }
}
