public class UseCommand : Command
{
    public UseCommand() : base("use", "Use <item>- use specified item, if possible. ") { }

    public override void Execute(Menu menu, string[] commandArgs)
    {
        throw new NotImplementedException();
    }
}