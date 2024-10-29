public class MysteryRoomMenu : Menu
{
    public MysteryRoomMenu()
    {
        AddCommand(new UseCommand());
        AddCommand(new TakeCommand());
        AddCommand(new InspectCommand());
        AddCommand(new StoryCommand());
        AddCommand(new LeaveCommand());
    }
}