public class MysteryRoom
{
    public string Name { get; } = "The Mystery Room";
    public string Description { get; } = "You have entered a seemingly normal room. There is a large wall, a window, and a table with a chair in front of the wall. A lamp is hanging from the ceiling. The room feels strange, as if it hides more than meets the eye.";
    public Menu Menu { get; } = new MysteryRoomMenu();

    public List<GameObject> items =
    [
        new Lamp("lamp", "A simple lamp. You can either 'turn it off' or 'leave it on'."),
        new Chair("chair", "An old chair in front of the table."),
        new UsableItem("strange module", "A panel with all letters of the alphabet.")
    ];

    // Definiera kapitel
    private List<Chapter> chapters =
    [
        new Chapter(
            "introduction",
            """
            You are in a mysterious room filled with strange artifacts.
            A lamp hangs from the ceiling, illuminating a table with a chair. What will you do?
            """
            ),
        new Chapter(
            "lamp_off",
             "You turned off the lamp. Red squares appear on the wall, hinting at a hidden word."
             ),
        new Chapter(
            "hangman_win",
             "Congratulations! You guessed the word and a hidden compartment opened up!"
             ),
    ];

    public Room CreateRoom()
    {
        Story story = new(chapters);
        Room room = new(Name, Description, story, ["The Hub"], items, Menu);
        return room;
    }
}
