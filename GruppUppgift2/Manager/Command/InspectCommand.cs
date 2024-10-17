public class InspectCommand : Command
{
    public InspectCommand() : base("inspect", "Inspect <item> - inspects an item in the game world.") { }

    public override void Execute(string[] commandArgs, Menu menu)
    {
        throw new NotImplementedException();
    }
}