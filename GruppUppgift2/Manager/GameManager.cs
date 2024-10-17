public class GameManager
{
    public static bool gameRunning = false;

    public static void Run()
    {

        RoomManager.CreateRooms();
        RoomManager.EnterRoom("The Library");   // I framtiden, the hub.

        Player player = new Player();

        gameRunning = true;
        while (gameRunning)
        {
            RoomManager.currentRoom.PrintStory();
            Console.Write("Enter input: ");
            string userInput = Console.ReadLine()!;
            Console.Clear();
            // Menu.TryExecuteCommand(userInput);
        }
    }
}
