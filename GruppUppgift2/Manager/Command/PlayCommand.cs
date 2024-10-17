public class PlayCommand : Command
{
    public PlayCommand() : base("play", "Play - Start the game") { }

    public override void Execute(Menu menu, string[] commandArgs)
    {
        GameManager.Run();
    }
}