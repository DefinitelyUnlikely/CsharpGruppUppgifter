public class GameManager
{
    public static bool gameRunning = true;

    public static void Run()
    {


        RoomManager.CreateRooms();
        RoomManager.EnterRoom(0);

        Player player = new Player();

        while (gameRunning)
        {
            RoomManager.currentRoom.PrintStory();
            Console.Write("Enter input: ");
            string userInput = Console.ReadLine()!;
            Console.Clear();
            Menu.TryExecuteCommand(userInput);
        }
    }
}
