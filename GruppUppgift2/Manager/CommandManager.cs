public class CommandManager
{
    public static void TryExecuteCommand(string[] userInput)
    {
        if (userInput.Length == 0)
        {
            throw new ArgumentException("Command is empty.");
        }

        string command = userInput[0];

        switch (command)
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
            case "open":
            {
                OpenCommand.Execute(userInput);
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
