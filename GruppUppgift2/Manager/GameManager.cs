public class GameManager
{
    public static bool gameRunning = false;

    public static void Run()
    {
        MenuManager.SetMenu(new LibraryMenu()); // I framtiden, menu för the hub.
        Menu currentMenu = MenuManager.GetCurrentMenu();

        RoomManager.CreateRooms();
        RoomManager.EnterRoom("The Library"); // I framtiden, the hub.

        Player player = new Player();

        gameRunning = true;
        RoomManager.currentRoom.PrintStory();
        currentMenu.TryExecuteCommand("help");
        while (gameRunning)
        {
            Console.WriteLine("Type 'help' for a list of commands");
            Console.Write("Enter input: ");
            string userInput = Console.ReadLine()!;
            currentMenu.TryExecuteCommand(userInput);
        }
    }
}
