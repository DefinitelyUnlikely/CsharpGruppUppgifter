public class HelpCommand : Command
{
    public HelpCommand() : base("HelpCommand", "Help - Shows commands available in current menu") { }

    public override void Execute(string[] commandArgs)
    {
        throw new NotImplementedException();
    }
}