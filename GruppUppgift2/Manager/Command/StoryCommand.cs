public class StoryCommand : Command
{
    public StoryCommand()
        : base("story", "Story - Print the rooms current description") { }

    public override void Execute(string[] commandArgs)
    {
        RoomManager.currentRoom.Display();
    }
}
