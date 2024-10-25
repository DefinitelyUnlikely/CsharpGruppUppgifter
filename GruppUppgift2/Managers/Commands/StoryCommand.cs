public class StoryCommand : Command
{
    public StoryCommand()
        : base("story", "Story - Print the rooms current description") { }

    public override void Execute(string[] commandArgs)
    {
        Console.WriteLine(RoomManager.currentRoom.RoomStory.GetStoryDescription());
    }
}
