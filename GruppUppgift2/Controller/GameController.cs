public class GameController
{
    public static bool running = true;

    public static void Run()
    {
        RoomController.CreateRooms();
        foreach (Room room in RoomController.rooms)
        {
            Console.WriteLine(room.Name);
        }

        while (running)
        {
            Console.Write("Enter input: ");
            string[] userInput = Console.ReadLine()!.ToLower().Split();
            Console.Clear();
            switch (userInput[0])
            {
                case "help":
                {
                    HelpCommand.Execute(userInput);
                    break;
                }
                case "exit":
                {
                    ExitCommand.Execute();
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid input. Type 'help' for a list of commands.");
                    break;
                }
            }
        }
    }
}
