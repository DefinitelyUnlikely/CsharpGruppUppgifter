public class LeaveCommand : Command
{
    public LeaveCommand()
        : base("leave", "Leave - Go back to the last room.") { }

    public override void Execute(string[] commandArgs)
    {
        RoomManager.LeaveRoom();
    }
}
