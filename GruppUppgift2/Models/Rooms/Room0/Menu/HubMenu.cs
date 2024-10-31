public class HubMenu : Menu
{
    public HubMenu()
    {
        AddCommand(new UseCommand());
        AddCommand(new InspectCommand());
        AddCommand(new StoryCommand());
        AddCommand(new EnterCommand());
        AddCommand(new HintCommand());
        AddCommand(new CompleteCommand());
    }
}
