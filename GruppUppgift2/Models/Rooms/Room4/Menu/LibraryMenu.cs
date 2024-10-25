public class LibraryMenu : Menu
{
    public LibraryMenu()
    {
        AddCommand(new UseCommand());
        AddCommand(new TakeCommand());
        AddCommand(new InspectCommand());
        AddCommand(new StoryCommand());
        AddCommand(new LeaveCommand());
    }
}
