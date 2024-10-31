public class CompleteCommand : Command
{
    public CompleteCommand()
     : base("complete", "Complete - test command to complete a room. usage: 'complete <room #>'. Example: complete 1") { }


    public override void Execute(string[] commandArgs)
    {
        if (commandArgs.Length != 2)
        {
            throw new ArgumentException("usage: complete <room #>, example: complete 1 to complete room 1");
        }

        if (!int.TryParse(commandArgs[1], out int i))
        {
            throw new ArgumentException("usage: complete <room #>, example: complete 1 to complete room 1");
        }

        GameManager.player.completedRooms[i] = true;
        Console.WriteLine($"Marked room {i} as completed");
    }
}