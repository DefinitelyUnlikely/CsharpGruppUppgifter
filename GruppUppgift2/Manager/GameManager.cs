public class GameManager
{
    public static bool gameRunning = false;
    public static Player player;

    public static void Run()
    {
        gameRunning = true;

        // Ifall vi vill använda spelarens namn till något.
        Console.WriteLine("Enter your name: ");
        player = new Player(Console.ReadLine());

        // MenuManager.SetMenu(new LibraryMenu()); // I framtiden, menu för the hub.
        // Menu currentMenu = MenuManager.GetCurrentMenu();

        RoomManager.CreateRooms();
        RoomManager.EnterRoom("The Hub"); // I framtiden, the hub.

        gameRunning = true;

        // Deprecated methods. Called from Display() on EnterRoom and from Menu.SetMenu.
        //RoomManager.currentRoom.PrintStory();
        //currentMenu.TryExecuteCommand("help");
        while (gameRunning)
        {
            // Console.WriteLine("Type 'help' for a list of commands");
            // Console.Write("Enter input: ");
            string userInput = Console.ReadLine()!;
            MenuManager.GetCurrentMenu().TryExecuteCommand(userInput);
        }
    }
}
