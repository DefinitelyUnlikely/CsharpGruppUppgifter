public class StoryCommand : Command
{
    public StoryCommand() : base("story", "Story - Print the rooms current description") { }

    public override void Execute(Menu menu, string[] commandArgs)
    {
        RoomManager.currentRoom.PrintStory();
    }
}