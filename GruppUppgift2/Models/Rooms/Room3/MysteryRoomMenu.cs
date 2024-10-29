public class HangmanRoomMenu : Menu
{
    public HangmanRoomMenu()
    {
        AddCommand(new UseCommand());
        AddCommand(new TakeCommand());
        AddCommand(new InspectCommand());
        AddCommand(new StoryCommand());
        AddCommand(new LeaveCommand());
    }
}