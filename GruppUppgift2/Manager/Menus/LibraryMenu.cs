public class LibraryMenu : Menu
{
    public LibraryMenu()
    {
        AddCommand(new UseCommand());
        AddCommand(new InspectCommand());
        AddCommand(new StoryCommand());
    }
}