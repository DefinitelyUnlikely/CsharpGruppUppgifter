public class GameManager
{
    public static bool running = true;

    public static void Run()
    {
        RoomManager.CreateRooms();
        RoomManager.EnterRoom(0);

        Player player = new Player();

        while (running)
        {
            RoomManager.currentRoom.PrintStory();
            Console.Write("Enter input: ");
            string[] userInput = Console.ReadLine()!.ToLower().Split();
            Console.Clear();
            CommandManager.TryExecuteCommand(userInput);
        }
    }
}
