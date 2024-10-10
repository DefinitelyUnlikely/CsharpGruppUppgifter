public class OpenCommand
{
    public static void Execute(string[] commandArgs)
    {
        // Need to specify what to open (more arguments).
        if (commandArgs.Length < 2)
        {
            Console.WriteLine("Open what?");
            return;
        }

        if (commandArgs[1] == "door")
        {
            string doorIdentifier;

            if (commandArgs.Length < 3)
            {
                doorIdentifier = "red";
            }
            else
                doorIdentifier = commandArgs[2];
            Console.WriteLine($"Trying to open door {doorIdentifier}");
            Console.ReadLine();
            CommandManager.TryExecuteCommand(commandArgs);
        }
        else
        {
            Console.WriteLine($"Cannot open {commandArgs[1]}.");
        }
    }
}
