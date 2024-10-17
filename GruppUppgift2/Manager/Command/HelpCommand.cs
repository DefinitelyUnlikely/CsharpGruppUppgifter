public class HelpCommand : Command
{
    public HelpCommand() : base("help", "Help - Shows commands available in current menu") { }

    public override void Execute(Menu menu, string[] commandArgs)
    {
        // Vi vill kanske ta bort listPoint, ifall det ses förvirrande för användaren.
        int listPoint = 0;
        foreach (Command command in menu.GetCommands())
        {
            Console.WriteLine($"{++listPoint}. {command.HelpDescription}");
        }
        Console.WriteLine("Please Enter a command: <name of command> ");
        Console.WriteLine("Type 'help' for a list of commands");
    }
}