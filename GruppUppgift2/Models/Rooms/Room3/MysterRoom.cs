public class MysteryRoom
{
    public string Name { get; } = "Mystery Room";
    public string Description { get; } = "You have entered a seemingly normal room. There is a large wall, a window, and a table with a chair in front of the wall. A lamp is hanging from the ceiling. The room feels strange, as if it hides more than meets the eye.";
    public Menu Menu { get; } = new MysteryRoomMenu();

    private List<GameObject> items;

    public MysteryRoom()
    {
        items = new List<GameObject>
        {
            new Lamp("lamp", "A simple lamp. You can either 'turn it off' or 'leave it on'."),
            new Chair("chair", "An old chair in front of the table."),
            new UsableItem("strange module", "A panel with all letters of the alphabet.")
        };
    }

    // Definiera kapitel
    private List<Chapter> chapters = new List<Chapter>
    {
        new Chapter("introduction", @"You are in a mysterious room filled with strange artifacts. A lamp hangs from the ceiling, illuminating a table with a chair. What will you do?"),
        new Chapter("lamp_off", "You turned off the lamp. Red squares appear on the wall, hinting at a hidden word."),
        new Chapter("chair_interaction", "You sit down on the chair in front of the table. There is a strange panel on the table, a module with all the letters of the alphabet."),
        new Chapter("hangman_start", "You must now guess the hidden word by using the module on the table."),
        new Chapter("hangman_win", "Congratulations! You guessed the word and a hidden compartment opened up!"),
        new Chapter("key_found", "Inside the box, you find a shiny key. It feels important."),
        new Chapter("exit", "You leave the room, ready to face whatever challenge comes next with the key in your possession.")
    };

    public Room CreateRoom()
    {
        Story story = new Story(chapters);
        Room room = new Room(Name, Description, story, items, Menu);
        return room;
    }
}
