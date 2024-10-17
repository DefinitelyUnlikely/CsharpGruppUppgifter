public class InspectCommand : Command
{
    public InspectCommand() : base("inspect", "Inspect <item> - inspects an item in the game world.") { }

    public override void Execute(Menu menu, string[] commandArgs)
    {
        throw new NotImplementedException();
    }
}