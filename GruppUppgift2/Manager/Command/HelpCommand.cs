public class HelpCommand : Command
{
    public HelpCommand()
        : base("help", "Help - Shows commands available in current menu") { }

    public override void Execute(string[] commandArgs)
    {
        foreach (Command command in MenuManager.GetCurrentMenu().GetCommands())
        {
            Console.WriteLine($"• {command.HelpDescription}");
        }
        Console.WriteLine("Please Enter a command: <name of command> ");
    }
}
