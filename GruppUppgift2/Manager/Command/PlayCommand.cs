public class PlayCommand : Command
{
    public PlayCommand() : base("play", "Play - Start the game") { }

    public override void Execute(string[] commandArgs, Menu menu)
    {
        GameManager.Run();
    }
}