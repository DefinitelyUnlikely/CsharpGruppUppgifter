public class EnterCommand : Command
{
    public EnterCommand()
        : base("enter", "Enter - enters the specified room if possible.") { }

    public override void Execute(string[] commandArgs)
    {
        if (commandArgs.Length < 2)
        {
            throw new ArgumentException("Enter 'roomname'.");
        }
        string roomName = string.Join(" ", commandArgs.Skip(1));
        RoomManager.TryEnterRoom(roomName);
    }
}
