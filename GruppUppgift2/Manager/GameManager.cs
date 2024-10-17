public class GameManager
{
    public static bool gameRunning = false;

    public static void Run()
    {

        Menu libMenu = new LibraryMenu();   // I framtiden, menu för the hub.

        RoomManager.CreateRooms();
        RoomManager.EnterRoom("The Library");   // I framtiden, the hub.

        Player player = new Player();


        gameRunning = true;
        RoomManager.currentRoom.PrintStory();
        libMenu.TryExecuteCommand("help");
        while (gameRunning)
        {


            Console.WriteLine("Type 'help' for a list of commands");
            Console.Write("Enter input: ");
            string userInput = Console.ReadLine()!;
            libMenu.TryExecuteCommand(userInput);
        }
    }
}
